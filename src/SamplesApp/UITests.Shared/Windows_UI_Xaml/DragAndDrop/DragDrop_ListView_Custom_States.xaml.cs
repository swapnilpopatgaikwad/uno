﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UITests.Windows_UI_Xaml.DragAndDrop
{
	[Sample("DragAndDrop", "ListView")]
	public sealed partial class DragDrop_ListView_Custom_States : UserControl
	{
		public DragDrop_ListView_Custom_States()
		{
			this.InitializeComponent();

			SUT.ItemsSource = new ObservableCollection<string>()
{
			"ALGERIA",
			"ANDORRA",
			"AZERBAIJAN",
			"BRUNEI",
			"CENTRAL AFRICAN REPUBLIC",
			"CHINA",
			"BELIZE",
			"COLOMBIA",
			"BRAZIL",
			"CONGO, REPUBLIC OF THE",
			"BARBADOS",
			"BELGIUM",
			"ARGENTINA",
			"BURUNDI",
			"AUSTRALIA",
			"BANGLADESH",
			"BOTSWANA",
			"CUBA",
			"AFGHANISTAN",
			"CONGO, DEMOCRATIC REPUBLIC OF THE",
			"ANGOLA",
			"BAHRAIN",
			"BELARUS",
			"COMOROS",
			"BAHAMAS, THE",
			"CHAD",
			"CYPRUS",
			"CANADA",
			"BURKINA FASO",
			"CAMBODIA",
			"BENIN",
			"CZECH REPUBLIC",
			"CABO VERDE",
			"ANTIGUA AND BARBUDA",
			"COSTA RICA",
			"CHILE",
			"BOSNIA AND HERZEGOVINA",
			"BULGARIA",
			"BOLIVIA",
			"BHUTAN",
			"ALBANIA",
			"AUSTRIA",
			"CÔTE D'IVOIRE ",
			"CAMEROON",
			"ARMENIA",
			"CROATIA",
			"DENMARK",
			"DJIBOUTI",
			"DOMINICA",
			"DOMINICAN REPUBLIC"
		};
		}
	}
}
