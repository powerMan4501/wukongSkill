using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Collections.ObjectModel;

[Serializable]
[TypeForwardedFrom("WindowsBase, Version=3.0.0.0, Culture=Neutral, PublicKeyToken=31bf3856ad364e35")]
[global::__DynamicallyInvokable]
public class ObservableCollection<T> : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged
{
	[Serializable]
	[TypeForwardedFrom("WindowsBase, Version=3.0.0.0, Culture=Neutral, PublicKeyToken=31bf3856ad364e35")]
	private class SimpleMonitor : IDisposable
	{
		private int _busyCount;

		public bool Busy => _busyCount > 0;

		public void Enter()
		{
			_busyCount++;
		}

		public void Dispose()
		{
			_busyCount--;
		}
	}

	private const string CountString = "Count";

	private const string IndexerName = "Item[]";

	private SimpleMonitor _monitor = new SimpleMonitor();

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
	public virtual event NotifyCollectionChangedEventHandler CollectionChanged;

	[global::__DynamicallyInvokable]
	[method: global::__DynamicallyInvokable]
	protected virtual event PropertyChangedEventHandler PropertyChanged;

	[global::__DynamicallyInvokable]
	public ObservableCollection()
	{
	}

	public ObservableCollection(List<T> list)
		: base((IList<T>)((list != null) ? new List<T>(list.Count) : list))
	{
		CopyFrom(list);
	}

	[global::__DynamicallyInvokable]
	public ObservableCollection(IEnumerable<T> collection)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		CopyFrom(collection);
	}

	private void CopyFrom(IEnumerable<T> collection)
	{
		IList<T> list = base.Items;
		if (collection == null || list == null)
		{
			return;
		}
		foreach (T item in collection)
		{
			list.Add(item);
		}
	}

	[global::__DynamicallyInvokable]
	public void Move(int oldIndex, int newIndex)
	{
		MoveItem(oldIndex, newIndex);
	}

	[global::__DynamicallyInvokable]
	protected override void ClearItems()
	{
		CheckReentrancy();
		base.ClearItems();
		OnPropertyChanged("Count");
		OnPropertyChanged("Item[]");
		OnCollectionReset();
	}

	[global::__DynamicallyInvokable]
	protected override void RemoveItem(int index)
	{
		CheckReentrancy();
		T val = base[index];
		base.RemoveItem(index);
		OnPropertyChanged("Count");
		OnPropertyChanged("Item[]");
		OnCollectionChanged(NotifyCollectionChangedAction.Remove, val, index);
	}

	[global::__DynamicallyInvokable]
	protected override void InsertItem(int index, T item)
	{
		CheckReentrancy();
		base.InsertItem(index, item);
		OnPropertyChanged("Count");
		OnPropertyChanged("Item[]");
		OnCollectionChanged(NotifyCollectionChangedAction.Add, item, index);
	}

	[global::__DynamicallyInvokable]
	protected override void SetItem(int index, T item)
	{
		CheckReentrancy();
		T val = base[index];
		base.SetItem(index, item);
		OnPropertyChanged("Item[]");
		OnCollectionChanged(NotifyCollectionChangedAction.Replace, val, item, index);
	}

	[global::__DynamicallyInvokable]
	protected virtual void MoveItem(int oldIndex, int newIndex)
	{
		CheckReentrancy();
		T val = base[oldIndex];
		base.RemoveItem(oldIndex);
		base.InsertItem(newIndex, val);
		OnPropertyChanged("Item[]");
		OnCollectionChanged(NotifyCollectionChangedAction.Move, val, newIndex, oldIndex);
	}

	[global::__DynamicallyInvokable]
	protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
	{
		if (this.PropertyChanged != null)
		{
			this.PropertyChanged(this, e);
		}
	}

	[global::__DynamicallyInvokable]
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
	{
		if (this.CollectionChanged != null)
		{
			using (BlockReentrancy())
			{
				this.CollectionChanged(this, e);
			}
		}
	}

	[global::__DynamicallyInvokable]
	protected IDisposable BlockReentrancy()
	{
		_monitor.Enter();
		return _monitor;
	}

	[global::__DynamicallyInvokable]
	protected void CheckReentrancy()
	{
		if (_monitor.Busy && this.CollectionChanged != null && this.CollectionChanged.GetInvocationList().Length > 1)
		{
			throw new InvalidOperationException(SR.GetString("ObservableCollectionReentrancyNotAllowed"));
		}
	}

	private void OnPropertyChanged(string propertyName)
	{
		OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
	}

	private void OnCollectionChanged(NotifyCollectionChangedAction action, object item, int index)
	{
		OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, item, index));
	}

	private void OnCollectionChanged(NotifyCollectionChangedAction action, object item, int index, int oldIndex)
	{
		OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, item, index, oldIndex));
	}

	private void OnCollectionChanged(NotifyCollectionChangedAction action, object oldItem, object newItem, int index)
	{
		OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, newItem, oldItem, index));
	}

	private void OnCollectionReset()
	{
		OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
	}
}
