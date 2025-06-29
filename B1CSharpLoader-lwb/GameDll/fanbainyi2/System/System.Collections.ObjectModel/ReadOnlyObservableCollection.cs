using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Collections.ObjectModel;

[Serializable]
[TypeForwardedFrom("WindowsBase, Version=3.0.0.0, Culture=Neutral, PublicKeyToken=31bf3856ad364e35")]
[global::__DynamicallyInvokable]
public class ReadOnlyObservableCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged
{
	[global::__DynamicallyInvokable]
	event NotifyCollectionChangedEventHandler INotifyCollectionChanged.CollectionChanged
	{
		[global::__DynamicallyInvokable]
		add
		{
			CollectionChanged += value;
		}
		[global::__DynamicallyInvokable]
		remove
		{
			CollectionChanged -= value;
		}
	}

	[global::__DynamicallyInvokable]
	[method: global::__DynamicallyInvokable]
	protected virtual event NotifyCollectionChangedEventHandler CollectionChanged;

	[global::__DynamicallyInvokable]
	event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
	{
		[global::__DynamicallyInvokable]
		add
		{
			PropertyChanged += value;
		}
		[global::__DynamicallyInvokable]
		remove
		{
			PropertyChanged -= value;
		}
	}

	[global::__DynamicallyInvokable]
	[method: global::__DynamicallyInvokable]
	protected virtual event PropertyChangedEventHandler PropertyChanged;

	[global::__DynamicallyInvokable]
	public ReadOnlyObservableCollection(ObservableCollection<T> list)
		: base((IList<T>)list)
	{
		((INotifyCollectionChanged)base.Items).CollectionChanged += HandleCollectionChanged;
		((INotifyPropertyChanged)base.Items).PropertyChanged += HandlePropertyChanged;
	}

	[global::__DynamicallyInvokable]
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
		if (this.CollectionChanged != null)
		{
			this.CollectionChanged(this, args);
		}
	}

	[global::__DynamicallyInvokable]
	protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
	{
		if (this.PropertyChanged != null)
		{
			this.PropertyChanged(this, args);
		}
	}

	private void HandleCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		OnCollectionChanged(e);
	}

	private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		OnPropertyChanged(e);
	}
}
