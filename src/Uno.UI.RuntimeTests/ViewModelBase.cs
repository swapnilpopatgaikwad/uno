using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Uno.UI.RuntimeTests
{
	/// <summary>
	/// Basic VM that implements INPC.
	/// </summary>
	internal abstract class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private readonly Dictionary<string, object> _propertyValueStore = new Dictionary<string, object>();

		protected T GetProperty<T>([CallerMemberName] string propertyName = null)
		{
			return _propertyValueStore.TryGetValue(propertyName, out var value) ? (T)value : default;
		}

		protected void SetProperty<T>(T value, [CallerMemberName] string propertyName = null)
		{
			if (!(_propertyValueStore.TryGetValue(propertyName, out var oldValue) && oldValue?.Equals(value) == true))
			{
				_propertyValueStore[propertyName] = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
