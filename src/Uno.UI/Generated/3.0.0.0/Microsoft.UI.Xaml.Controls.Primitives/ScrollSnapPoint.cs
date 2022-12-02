#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollSnapPoint : global::Microsoft.UI.Xaml.Controls.Primitives.ScrollSnapPointBase
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double Value
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollSnapPoint.Value is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ScrollSnapPoint( double snapPointValue,  global::Microsoft.UI.Xaml.Controls.Primitives.ScrollSnapPointsAlignment alignment) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollSnapPoint", "ScrollSnapPoint.ScrollSnapPoint(double snapPointValue, ScrollSnapPointsAlignment alignment)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollSnapPoint.ScrollSnapPoint(double, Microsoft.UI.Xaml.Controls.Primitives.ScrollSnapPointsAlignment)
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollSnapPoint.Value.get
	}
}
