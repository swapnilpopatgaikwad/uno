#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionMipmapSurface : global::Microsoft.UI.Composition.CompositionObject,global::Microsoft.UI.Composition.ICompositionSurface
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.Graphics.DirectX.DirectXAlphaMode AlphaMode
		{
			get
			{
				throw new global::System.NotImplementedException("The member DirectXAlphaMode CompositionMipmapSurface.AlphaMode is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint LevelCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint CompositionMipmapSurface.LevelCount is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.Graphics.DirectX.DirectXPixelFormat PixelFormat
		{
			get
			{
				throw new global::System.NotImplementedException("The member DirectXPixelFormat CompositionMipmapSurface.PixelFormat is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.SizeInt32 SizeInt32
		{
			get
			{
				throw new global::System.NotImplementedException("The member SizeInt32 CompositionMipmapSurface.SizeInt32 is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionMipmapSurface.LevelCount.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionMipmapSurface.AlphaMode.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionMipmapSurface.PixelFormat.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionMipmapSurface.SizeInt32.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionDrawingSurface GetDrawingSurfaceForLevel( uint level)
		{
			throw new global::System.NotImplementedException("The member CompositionDrawingSurface CompositionMipmapSurface.GetDrawingSurfaceForLevel(uint level) is not implemented in Uno.");
		}
		#endif
		// Processing: Microsoft.UI.Composition.ICompositionSurface
	}
}
