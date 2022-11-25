﻿// Adapted from https://github.com/xamarin/Essentials/blob/1.6.0/Xamarin.Essentials/Connectivity/Connectivity.ios.tvos.macos.reachability.cs
#if __IOS__ || __MACOS__
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
#if __IOS__ && !__MACCATALYST__ // catalyst https://github.com/xamarin/xamarin-macios/issues/13931
using CoreTelephony;
#endif
using CoreFoundation;
using SystemConfiguration;
using Windows.Networking.Connectivity;
using Network;

#pragma warning disable BI1234 // 'CTCellularDataRestrictedState' is obsolete: 'Starting with ios14.0 Use the 'CallKit' API instead.'

namespace Uno.Networking.Connectivity.Internal
{
	enum NetworkStatus
    {
        NotReachable,
        ReachableViaCarrierDataNetwork,
        ReachableViaWiFiNetwork
    }

    static class Reachability
    {
        internal static NetworkStatus RemoteHostStatus()
        {
            using (var remoteHostReachability = new NetworkReachability(WinRTFeatureConfiguration.NetworkInformation.ReachabilityHostname))
            {
                var reachable = remoteHostReachability.TryGetFlags(out var flags);

                if (!reachable)
                    return NetworkStatus.NotReachable;

                if (!IsReachableWithoutRequiringConnection(flags))
                    return NetworkStatus.NotReachable;

#if __IOS__
                if ((flags & NetworkReachabilityFlags.IsWWAN) != 0)
                    return NetworkStatus.ReachableViaCarrierDataNetwork;
#endif

                return NetworkStatus.ReachableViaWiFiNetwork;
            }
        }

        internal static NetworkStatus InternetConnectionStatus()
        {
            var status = NetworkStatus.NotReachable;

            var defaultNetworkAvailable = IsNetworkAvailable(out var flags);

#if __IOS__
            // If it's a WWAN connection..
            if ((flags & NetworkReachabilityFlags.IsWWAN) != 0)
                status = NetworkStatus.ReachableViaCarrierDataNetwork;
#endif

            // If the connection is reachable and no connection is required, then assume it's WiFi
            if (defaultNetworkAvailable)
            {
                status = NetworkStatus.ReachableViaWiFiNetwork;
            }

            // If the connection is on-demand or on-traffic and no user intervention
            // is required, then assume WiFi.
            if (((flags & NetworkReachabilityFlags.ConnectionOnDemand) != 0 || (flags & NetworkReachabilityFlags.ConnectionOnTraffic) != 0) &&
                 (flags & NetworkReachabilityFlags.InterventionRequired) == 0)
            {
                status = NetworkStatus.ReachableViaWiFiNetwork;
            }

            return status;
        }

        internal static IEnumerable<NetworkStatus> GetActiveConnectionType()
        {
            var status = new List<NetworkStatus>();

            var defaultNetworkAvailable = IsNetworkAvailable(out var flags);

#if __IOS__
            // If it's a WWAN connection.
            if ((flags & NetworkReachabilityFlags.IsWWAN) != 0)
            {
                status.Add(NetworkStatus.ReachableViaCarrierDataNetwork);
            }
#endif

            if (defaultNetworkAvailable)
            {
                status.Add(NetworkStatus.ReachableViaWiFiNetwork);
            }
            else if (((flags & NetworkReachabilityFlags.ConnectionOnDemand) != 0 || (flags & NetworkReachabilityFlags.ConnectionOnTraffic) != 0) &&
                     (flags & NetworkReachabilityFlags.InterventionRequired) == 0)
            {
                // If the connection is on-demand or on-traffic and no user intervention
                // is required, then assume WiFi.
                status.Add(NetworkStatus.ReachableViaWiFiNetwork);
            }

            return status;
        }

        internal static bool IsNetworkAvailable(out NetworkReachabilityFlags flags)
        {
            var ip = new IPAddress(0);
            using (var defaultRouteReachability = new NetworkReachability(ip))
            {
                if (!defaultRouteReachability.TryGetFlags(out flags))
                    return false;

                return IsReachableWithoutRequiringConnection(flags);
            }
        }

        internal static bool IsReachableWithoutRequiringConnection(NetworkReachabilityFlags flags)
        {
            // Is it reachable with the current network configuration?
            var isReachable = (flags & NetworkReachabilityFlags.Reachable) != 0;

            // Do we need a connection to reach it?
            var noConnectionRequired = (flags & NetworkReachabilityFlags.ConnectionRequired) == 0;

#if __IOS__
            // Since the network stack will automatically try to get the WAN up,
            // probe that
            if ((flags & NetworkReachabilityFlags.IsWWAN) != 0)
                noConnectionRequired = true;
#endif

            return isReachable && noConnectionRequired;
        }
    }

    class ReachabilityListener : IDisposable
    {
        private readonly NetworkReachability _defaultRouteReachability;
        private readonly NetworkReachability _remoteHostReachability;
		private readonly NWPathMonitor _networkMonitor;


		internal ReachabilityListener()
        {
			var ip = new IPAddress(0);
            _defaultRouteReachability = new NetworkReachability(ip);
            _defaultRouteReachability.SetNotification(OnChange);
            _defaultRouteReachability.Schedule(CFRunLoop.Main, CFRunLoop.ModeDefault);

            _remoteHostReachability = new NetworkReachability(WinRTFeatureConfiguration.NetworkInformation.ReachabilityHostname);
			
			_networkMonitor = new NWPathMonitor();
			_networkMonitor.SnapshotHandler = OnPathMonitorChange;
			_networkMonitor.Start();
			
			// Need to probe before we queue, or we wont get any meaningful values
			// this only happens when you create NetworkReachability from a hostname
			_remoteHostReachability.TryGetFlags(out var flags);

            _remoteHostReachability.SetNotification(OnChange);
            _remoteHostReachability.Schedule(CFRunLoop.Main, CFRunLoop.ModeDefault);

#if __IOS__ && !__MACCATALYST__
            NetworkInformation.CellularData.RestrictionDidUpdateNotifier = new Action<CTCellularDataRestrictedState>(OnRestrictedStateChanged);
#endif
        }

        internal event Action ReachabilityChanged;

        void IDisposable.Dispose() => Dispose();

        internal void Dispose()
        {
            _defaultRouteReachability?.Dispose();
            _remoteHostReachability?.Dispose();
			_networkMonitor.SnapshotHandler = null;
			_networkMonitor?.Dispose();			
			
#if __IOS__ && !__MACCATALYST__
			NetworkInformation.CellularData.RestrictionDidUpdateNotifier = null;
#endif
        }

#if __IOS__ && !__MACCATALYST__
        void OnRestrictedStateChanged(CTCellularDataRestrictedState state)
        {
            ReachabilityChanged?.Invoke();
        }
#endif

        async void OnChange(NetworkReachabilityFlags flags)
        {
            // Add in artifical delay so the connection status has time to change
            // else it will return true no matter what.
            await Task.Delay(100);

            ReachabilityChanged?.Invoke();
        }

		private void OnPathMonitorChange(NWPath path)
		{
			ReachabilityChanged?.Invoke();
		}
	}
}
#endif
