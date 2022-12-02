#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls.Primitives
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScrollPresenter : global::Microsoft.UI.Xaml.FrameworkElement,global::Microsoft.UI.Xaml.Controls.IScrollAnchorProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.UIElement CurrentAnchor
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIElement ScrollPresenter.CurrentAnchor is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode HorizontalScrollMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode)this.GetValue(HorizontalScrollModeProperty);
			}
			set
			{
				this.SetValue(HorizontalScrollModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.Primitives.IScrollController HorizontalScrollController
		{
			get
			{
				throw new global::System.NotImplementedException("The member IScrollController ScrollPresenter.HorizontalScrollController is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "IScrollController ScrollPresenter.HorizontalScrollController");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingChainMode HorizontalScrollChainMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingChainMode)this.GetValue(HorizontalScrollChainModeProperty);
			}
			set
			{
				this.SetValue(HorizontalScrollChainModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double MaxZoomFactor
		{
			get
			{
				return (double)this.GetValue(MaxZoomFactorProperty);
			}
			set
			{
				this.SetValue(MaxZoomFactorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double HorizontalAnchorRatio
		{
			get
			{
				return (double)this.GetValue(HorizontalAnchorRatioProperty);
			}
			set
			{
				this.SetValue(HorizontalAnchorRatioProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingInputKinds IgnoredInputKinds
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingInputKinds)this.GetValue(IgnoredInputKindsProperty);
			}
			set
			{
				this.SetValue(IgnoredInputKindsProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double MinZoomFactor
		{
			get
			{
				return (double)this.GetValue(MinZoomFactorProperty);
			}
			set
			{
				this.SetValue(MinZoomFactorProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingRailMode HorizontalScrollRailMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingRailMode)this.GetValue(HorizontalScrollRailModeProperty);
			}
			set
			{
				this.SetValue(HorizontalScrollRailModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingContentOrientation ContentOrientation
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingContentOrientation)this.GetValue(ContentOrientationProperty);
			}
			set
			{
				this.SetValue(ContentOrientationProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.UIElement Content
		{
			get
			{
				return (global::Microsoft.UI.Xaml.UIElement)this.GetValue(ContentProperty);
			}
			set
			{
				this.SetValue(ContentProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Media.Brush Background
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Brush)this.GetValue(BackgroundProperty);
			}
			set
			{
				this.SetValue(BackgroundProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingZoomMode ZoomMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingZoomMode)this.GetValue(ZoomModeProperty);
			}
			set
			{
				this.SetValue(ZoomModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingChainMode ZoomChainMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingChainMode)this.GetValue(ZoomChainModeProperty);
			}
			set
			{
				this.SetValue(ZoomChainModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingRailMode VerticalScrollRailMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingRailMode)this.GetValue(VerticalScrollRailModeProperty);
			}
			set
			{
				this.SetValue(VerticalScrollRailModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode VerticalScrollMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode)this.GetValue(VerticalScrollModeProperty);
			}
			set
			{
				this.SetValue(VerticalScrollModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.Primitives.IScrollController VerticalScrollController
		{
			get
			{
				throw new global::System.NotImplementedException("The member IScrollController ScrollPresenter.VerticalScrollController is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "IScrollController ScrollPresenter.VerticalScrollController");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingChainMode VerticalScrollChainMode
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.ScrollingChainMode)this.GetValue(VerticalScrollChainModeProperty);
			}
			set
			{
				this.SetValue(VerticalScrollChainModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double VerticalAnchorRatio
		{
			get
			{
				return (double)this.GetValue(VerticalAnchorRatioProperty);
			}
			set
			{
				this.SetValue(VerticalAnchorRatioProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Composition.CompositionPropertySet ExpressionAnimationSources
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionPropertySet ScrollPresenter.ExpressionAnimationSources is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ExtentHeight
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollPresenter.ExtentHeight is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ExtentWidth
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollPresenter.ExtentWidth is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double HorizontalOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollPresenter.HorizontalOffset is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Controls.Primitives.ScrollSnapPointBase> HorizontalSnapPoints
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<ScrollSnapPointBase> ScrollPresenter.HorizontalSnapPoints is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ScrollableWidth
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollPresenter.ScrollableWidth is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.ScrollingInteractionState State
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScrollingInteractionState ScrollPresenter.State is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double VerticalOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollPresenter.VerticalOffset is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Controls.Primitives.ScrollSnapPointBase> VerticalSnapPoints
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<ScrollSnapPointBase> ScrollPresenter.VerticalSnapPoints is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ViewportHeight
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollPresenter.ViewportHeight is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ViewportWidth
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollPresenter.ViewportWidth is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float ZoomFactor
		{
			get
			{
				throw new global::System.NotImplementedException("The member float ScrollPresenter.ZoomFactor is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Microsoft.UI.Xaml.Controls.Primitives.ZoomSnapPointBase> ZoomSnapPoints
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<ZoomSnapPointBase> ScrollPresenter.ZoomSnapPoints is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ScrollableHeight
		{
			get
			{
				throw new global::System.NotImplementedException("The member double ScrollPresenter.ScrollableHeight is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty BackgroundProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Background), typeof(global::Microsoft.UI.Xaml.Media.Brush), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentOrientationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ContentOrientation), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingContentOrientation), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingContentOrientation)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ContentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(Content), typeof(global::Microsoft.UI.Xaml.UIElement), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.UIElement)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalAnchorRatioProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalAnchorRatio), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalScrollChainModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalScrollChainMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingChainMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingChainMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalScrollModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalScrollMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty HorizontalScrollRailModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(HorizontalScrollRailMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingRailMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingRailMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty IgnoredInputKindsProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(IgnoredInputKinds), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingInputKinds), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingInputKinds)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty MaxZoomFactorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MaxZoomFactor), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty MinZoomFactorProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(MinZoomFactor), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalAnchorRatioProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalAnchorRatio), typeof(double), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalScrollChainModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalScrollChainMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingChainMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingChainMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalScrollModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalScrollMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingScrollMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty VerticalScrollRailModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(VerticalScrollRailMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingRailMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingRailMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ZoomChainModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ZoomChainMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingChainMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingChainMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty ZoomModeProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(ZoomMode), typeof(global::Microsoft.UI.Xaml.Controls.ScrollingZoomMode), 
			typeof(global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.ScrollingZoomMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ScrollPresenter() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "ScrollPresenter.ScrollPresenter()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ScrollPresenter()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.Background.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.Background.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.Content.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.Content.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ExpressionAnimationSources.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalOffset.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ZoomFactor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ExtentWidth.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ExtentHeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ViewportWidth.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ViewportHeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ScrollableWidth.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ScrollableHeight.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ContentOrientation.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ContentOrientation.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalScrollChainMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalScrollChainMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalScrollChainMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalScrollChainMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalScrollRailMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalScrollRailMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalScrollRailMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalScrollRailMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalScrollMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalScrollMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalScrollMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalScrollMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ZoomChainMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ZoomChainMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ZoomMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ZoomMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.IgnoredInputKinds.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.IgnoredInputKinds.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.MinZoomFactor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.MinZoomFactor.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.MaxZoomFactor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.MaxZoomFactor.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.State.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalScrollController.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalScrollController.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalScrollController.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalScrollController.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalAnchorRatio.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalAnchorRatio.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalAnchorRatio.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalAnchorRatio.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalSnapPoints.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalSnapPoints.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ZoomSnapPoints.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ScrollTo( double horizontalOffset,  double verticalOffset)
		{
			throw new global::System.NotImplementedException("The member int ScrollPresenter.ScrollTo(double horizontalOffset, double verticalOffset) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ScrollTo( double horizontalOffset,  double verticalOffset,  global::Microsoft.UI.Xaml.Controls.ScrollingScrollOptions options)
		{
			throw new global::System.NotImplementedException("The member int ScrollPresenter.ScrollTo(double horizontalOffset, double verticalOffset, ScrollingScrollOptions options) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ScrollBy( double horizontalOffsetDelta,  double verticalOffsetDelta)
		{
			throw new global::System.NotImplementedException("The member int ScrollPresenter.ScrollBy(double horizontalOffsetDelta, double verticalOffsetDelta) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ScrollBy( double horizontalOffsetDelta,  double verticalOffsetDelta,  global::Microsoft.UI.Xaml.Controls.ScrollingScrollOptions options)
		{
			throw new global::System.NotImplementedException("The member int ScrollPresenter.ScrollBy(double horizontalOffsetDelta, double verticalOffsetDelta, ScrollingScrollOptions options) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int AddScrollVelocity( global::System.Numerics.Vector2 offsetsVelocity,  global::System.Numerics.Vector2? inertiaDecayRate)
		{
			throw new global::System.NotImplementedException("The member int ScrollPresenter.AddScrollVelocity(Vector2 offsetsVelocity, Vector2? inertiaDecayRate) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ZoomTo( float zoomFactor,  global::System.Numerics.Vector2? centerPoint)
		{
			throw new global::System.NotImplementedException("The member int ScrollPresenter.ZoomTo(float zoomFactor, Vector2? centerPoint) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ZoomTo( float zoomFactor,  global::System.Numerics.Vector2? centerPoint,  global::Microsoft.UI.Xaml.Controls.ScrollingZoomOptions options)
		{
			throw new global::System.NotImplementedException("The member int ScrollPresenter.ZoomTo(float zoomFactor, Vector2? centerPoint, ScrollingZoomOptions options) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ZoomBy( float zoomFactorDelta,  global::System.Numerics.Vector2? centerPoint)
		{
			throw new global::System.NotImplementedException("The member int ScrollPresenter.ZoomBy(float zoomFactorDelta, Vector2? centerPoint) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ZoomBy( float zoomFactorDelta,  global::System.Numerics.Vector2? centerPoint,  global::Microsoft.UI.Xaml.Controls.ScrollingZoomOptions options)
		{
			throw new global::System.NotImplementedException("The member int ScrollPresenter.ZoomBy(float zoomFactorDelta, Vector2? centerPoint, ScrollingZoomOptions options) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int AddZoomVelocity( float zoomFactorVelocity,  global::System.Numerics.Vector2? centerPoint,  float? inertiaDecayRate)
		{
			throw new global::System.NotImplementedException("The member int ScrollPresenter.AddZoomVelocity(float zoomFactorVelocity, Vector2? centerPoint, float? inertiaDecayRate) is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ExtentChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ExtentChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.StateChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.StateChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ViewChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ViewChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ScrollAnimationStarting.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ScrollAnimationStarting.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ZoomAnimationStarting.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ZoomAnimationStarting.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ScrollCompleted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ScrollCompleted.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ZoomCompleted.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ZoomCompleted.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.BringingIntoView.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.BringingIntoView.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.AnchorRequested.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.AnchorRequested.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.CurrentAnchor.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void RegisterAnchorCandidate( global::Microsoft.UI.Xaml.UIElement element)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "void ScrollPresenter.RegisterAnchorCandidate(UIElement element)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void UnregisterAnchorCandidate( global::Microsoft.UI.Xaml.UIElement element)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "void ScrollPresenter.UnregisterAnchorCandidate(UIElement element)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.BackgroundProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ContentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ContentOrientationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalScrollChainModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalScrollChainModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalScrollRailModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalScrollRailModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalScrollModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalScrollModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ZoomChainModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.ZoomModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.IgnoredInputKindsProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.MinZoomFactorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.MaxZoomFactorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.HorizontalAnchorRatioProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalAnchorRatioProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter, global::Microsoft.UI.Xaml.Controls.ScrollingAnchorRequestedEventArgs> AnchorRequested
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, ScrollingAnchorRequestedEventArgs> ScrollPresenter.AnchorRequested");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, ScrollingAnchorRequestedEventArgs> ScrollPresenter.AnchorRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter, global::Microsoft.UI.Xaml.Controls.ScrollingBringingIntoViewEventArgs> BringingIntoView
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, ScrollingBringingIntoViewEventArgs> ScrollPresenter.BringingIntoView");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, ScrollingBringingIntoViewEventArgs> ScrollPresenter.BringingIntoView");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter, object> ExtentChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, object> ScrollPresenter.ExtentChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, object> ScrollPresenter.ExtentChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter, global::Microsoft.UI.Xaml.Controls.ScrollingScrollAnimationStartingEventArgs> ScrollAnimationStarting
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, ScrollingScrollAnimationStartingEventArgs> ScrollPresenter.ScrollAnimationStarting");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, ScrollingScrollAnimationStartingEventArgs> ScrollPresenter.ScrollAnimationStarting");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter, global::Microsoft.UI.Xaml.Controls.ScrollingScrollCompletedEventArgs> ScrollCompleted
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, ScrollingScrollCompletedEventArgs> ScrollPresenter.ScrollCompleted");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, ScrollingScrollCompletedEventArgs> ScrollPresenter.ScrollCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter, object> StateChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, object> ScrollPresenter.StateChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, object> ScrollPresenter.StateChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter, object> ViewChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, object> ScrollPresenter.ViewChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, object> ScrollPresenter.ViewChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter, global::Microsoft.UI.Xaml.Controls.ScrollingZoomAnimationStartingEventArgs> ZoomAnimationStarting
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, ScrollingZoomAnimationStartingEventArgs> ScrollPresenter.ZoomAnimationStarting");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, ScrollingZoomAnimationStartingEventArgs> ScrollPresenter.ZoomAnimationStarting");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter, global::Microsoft.UI.Xaml.Controls.ScrollingZoomCompletedEventArgs> ZoomCompleted
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, ScrollingZoomCompletedEventArgs> ScrollPresenter.ZoomCompleted");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter", "event TypedEventHandler<ScrollPresenter, ScrollingZoomCompletedEventArgs> ScrollPresenter.ZoomCompleted");
			}
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Controls.IScrollAnchorProvider
	}
}
