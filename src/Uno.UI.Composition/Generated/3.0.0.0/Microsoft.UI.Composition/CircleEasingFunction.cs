#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CircleEasingFunction : global::Microsoft.UI.Composition.CompositionEasingFunction
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionEasingFunctionMode Mode
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionEasingFunctionMode CircleEasingFunction.Mode is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CircleEasingFunction.Mode.get
	}
}
