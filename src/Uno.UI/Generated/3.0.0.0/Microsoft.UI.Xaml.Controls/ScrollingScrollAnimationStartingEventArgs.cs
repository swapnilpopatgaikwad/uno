#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollingScrollAnimationStartingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionAnimation Animation
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionAnimation ScrollingScrollAnimationStartingEventArgs.Animation is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.ScrollingScrollAnimationStartingEventArgs", "CompositionAnimation ScrollingScrollAnimationStartingEventArgs.Animation");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int CorrelationId
		{
			get
			{
				throw new global::System.NotImplementedException("The member int ScrollingScrollAnimationStartingEventArgs.CorrelationId is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector2 EndPosition
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 ScrollingScrollAnimationStartingEventArgs.EndPosition is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector2 StartPosition
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 ScrollingScrollAnimationStartingEventArgs.StartPosition is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollingScrollAnimationStartingEventArgs.Animation.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollingScrollAnimationStartingEventArgs.Animation.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollingScrollAnimationStartingEventArgs.StartPosition.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollingScrollAnimationStartingEventArgs.EndPosition.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.ScrollingScrollAnimationStartingEventArgs.CorrelationId.get
	}
}
