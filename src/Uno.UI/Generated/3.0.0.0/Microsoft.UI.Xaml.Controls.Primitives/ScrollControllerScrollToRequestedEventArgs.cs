#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollControllerScrollToRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int CorrelationId
		{
			get
			{
				throw new global::System.NotImplementedException("The member int ScrollControllerScrollToRequestedEventArgs.CorrelationId is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs", "int ScrollControllerScrollToRequestedEventArgs.CorrelationId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double Offset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollControllerScrollToRequestedEventArgs.Offset is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingScrollOptions Options
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScrollingScrollOptions ScrollControllerScrollToRequestedEventArgs.Options is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ScrollControllerScrollToRequestedEventArgs( double offset,  global::Microsoft.UI.Xaml.Controls.ScrollingScrollOptions options) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs", "ScrollControllerScrollToRequestedEventArgs.ScrollControllerScrollToRequestedEventArgs(double offset, ScrollingScrollOptions options)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs.ScrollControllerScrollToRequestedEventArgs(double, Microsoft.UI.Xaml.Controls.ScrollingScrollOptions)
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs.Offset.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs.Options.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs.CorrelationId.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollControllerScrollToRequestedEventArgs.CorrelationId.set
	}
}
