using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Media;
using Uno.UI.Samples.Controls;
using Uno.UI.Samples.UITests.Helpers;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UITests.Windows_UI_Xaml_Controls.ItemsControl
{
	[Sample("ItemsControl")]
	public sealed partial class ItemsControl_NestedReset : UserControl
	{
		public static object[] Fields1 = new object[] { new { Extensions = new object[0] } };
		public static object[] Fields2 = new object[] { new { Extensions = new object[1] } };

		private ViewModel _viewModel;
		public ItemsControl_NestedReset()
		{
			this.InitializeComponent();
			
			_viewModel = new ViewModel();
			this.DataContext = _viewModel;
		}

		private void Button_Click1(object sender, RoutedEventArgs e)
		{
			if (this.DataContext is ViewModel viewModel)
			{
				viewModel.Fields = Fields1;
			}
		}

		private void Button_Click2(object sender, RoutedEventArgs e)
		{
			if (this.DataContext is ViewModel viewModel)
			{
				viewModel.Fields = Fields2;

			}
		}

		private void DebugVT(object sender, RoutedEventArgs e)
		{
			var sanity = Uno.UI.FeatureConfiguration.Asd.SanityTimestamp;
			var fixEnabled = Uno.UI.FeatureConfiguration.Asd.EnableFix;

			//var container = XyVTH.GetFirstDescendant<ItemsControl>(this);
			//var tree = XyVTH.TreeGraph(container, DebugVTNode);
			var tree = this.ShowLocalVisualTree(0);
		}

		private class ViewModel : ViewModelBase
		{
			private object[] _Fields;
			public object[] Fields { get => _Fields; set => Set(ref _Fields, value); }
		}
	}
}
