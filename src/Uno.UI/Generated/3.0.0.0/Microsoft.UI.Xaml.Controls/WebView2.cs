#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebView2 : global::Microsoft.UI.Xaml.FrameworkElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Uri Source
		{
			get
			{
				return (global::System.Uri)this.GetValue(SourceProperty);
			}
			set
			{
				this.SetValue(SourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool CanGoForward
		{
			get
			{
				return (bool)this.GetValue(CanGoForwardProperty);
			}
			set
			{
				this.SetValue(CanGoForwardProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool CanGoBack
		{
			get
			{
				return (bool)this.GetValue(CanGoBackProperty);
			}
			set
			{
				this.SetValue(CanGoBackProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanGoBackProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CanGoBack), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.WebView2), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanGoForwardProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CanGoForward), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.WebView2), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty SourceProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Source), typeof(global::System.Uri), 
			typeof(global::Microsoft.UI.Xaml.Controls.WebView2), 
			new FrameworkPropertyMetadata(default(global::System.Uri)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public WebView2() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "WebView2.WebView2()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.WebView2()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CoreWebView2.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction EnsureCoreWebView2Async()
		{
			throw new global::System.NotImplementedException("The member IAsyncAction WebView2.EnsureCoreWebView2Async() is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<string> ExecuteScriptAsync( string javascriptCode)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> WebView2.ExecuteScriptAsync(string javascriptCode) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.Source.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.Source.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CanGoForward.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CanGoForward.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CanGoBack.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CanGoBack.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Reload()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "void WebView2.Reload()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void GoForward()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "void WebView2.GoForward()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void GoBack()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "void WebView2.GoBack()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void NavigateToString( string htmlContent)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "void WebView2.NavigateToString(string htmlContent)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Close()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "void WebView2.Close()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.NavigationCompleted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.NavigationCompleted.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.WebMessageReceived.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.WebMessageReceived.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.NavigationStarting.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.NavigationStarting.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CoreProcessFailed.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CoreProcessFailed.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CoreWebView2Initialized.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CoreWebView2Initialized.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.SourceProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CanGoForwardProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.WebView2.CanGoBackProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.WebView2, global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs> CoreProcessFailed
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, CoreWebView2ProcessFailedEventArgs> WebView2.CoreProcessFailed");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, CoreWebView2ProcessFailedEventArgs> WebView2.CoreProcessFailed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.WebView2, global::Microsoft.UI.Xaml.Controls.CoreWebView2InitializedEventArgs> CoreWebView2Initialized
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, CoreWebView2InitializedEventArgs> WebView2.CoreWebView2Initialized");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, CoreWebView2InitializedEventArgs> WebView2.CoreWebView2Initialized");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.WebView2, global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs> NavigationCompleted
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, CoreWebView2NavigationCompletedEventArgs> WebView2.NavigationCompleted");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, CoreWebView2NavigationCompletedEventArgs> WebView2.NavigationCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.WebView2, global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs> NavigationStarting
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, CoreWebView2NavigationStartingEventArgs> WebView2.NavigationStarting");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, CoreWebView2NavigationStartingEventArgs> WebView2.NavigationStarting");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.WebView2, global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, CoreWebView2WebMessageReceivedEventArgs> WebView2.WebMessageReceived");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.WebView2", "event TypedEventHandler<WebView2, CoreWebView2WebMessageReceivedEventArgs> WebView2.WebMessageReceived");
			}
		}
		#endif
	}
}
