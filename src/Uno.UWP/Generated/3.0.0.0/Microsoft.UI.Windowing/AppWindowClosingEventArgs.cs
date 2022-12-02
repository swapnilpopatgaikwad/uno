#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Windowing
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppWindowClosingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Cancel
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AppWindowClosingEventArgs.Cancel is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.AppWindowClosingEventArgs", "bool AppWindowClosingEventArgs.Cancel");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowClosingEventArgs.Cancel.get
		// Forced skipping of method Microsoft.UI.Windowing.AppWindowClosingEventArgs.Cancel.set
	}
}
