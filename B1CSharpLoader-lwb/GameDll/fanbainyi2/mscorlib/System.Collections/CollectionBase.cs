using System.Runtime.InteropServices;

namespace System.Collections;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public abstract class CollectionBase : IList, ICollection, IEnumerable
{
	private ArrayList list;

	protected ArrayList InnerList
	{
		get
		{
			if (list == null)
			{
				list = new ArrayList();
			}
			return list;
		}
	}

	protected IList List => this;

	[ComVisible(false)]
	public int Capacity
	{
		get
		{
			return InnerList.Capacity;
		}
		set
		{
			InnerList.Capacity = value;
		}
	}

	public int Count
	{
		[__DynamicallyInvokable]
		get
		{
			if (list != null)
			{
				return list.Count;
			}
			return 0;
		}
	}

	bool IList.IsReadOnly => InnerList.IsReadOnly;

	bool IList.IsFixedSize => InnerList.IsFixedSize;

	bool ICollection.IsSynchronized => InnerList.IsSynchronized;

	object ICollection.SyncRoot => InnerList.SyncRoot;

	object IList.this[int index]
	{
		get
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
			}
			return InnerList[index];
		}
		set
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
			}
			OnValidate(value);
			object obj = InnerList[index];
			OnSet(index, obj, value);
			InnerList[index] = value;
			try
			{
				OnSetComplete(index, obj, value);
			}
			catch
			{
				InnerList[index] = obj;
				throw;
			}
		}
	}

	protected CollectionBase()
	{
		list = new ArrayList();
	}

	protected CollectionBase(int capacity)
	{
		list = new ArrayList(capacity);
	}

	[__DynamicallyInvokable]
	public void Clear()
	{
		OnClear();
		InnerList.Clear();
		OnClearComplete();
	}

	[__DynamicallyInvokable]
	public void RemoveAt(int index)
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		object value = InnerList[index];
		OnValidate(value);
		OnRemove(index, value);
		InnerList.RemoveAt(index);
		try
		{
			OnRemoveComplete(index, value);
		}
		catch
		{
			InnerList.Insert(index, value);
			throw;
		}
	}

	void ICollection.CopyTo(Array array, int index)
	{
		InnerList.CopyTo(array, index);
	}

	bool IList.Contains(object value)
	{
		return InnerList.Contains(value);
	}

	int IList.Add(object value)
	{
		OnValidate(value);
		OnInsert(InnerList.Count, value);
		int num = InnerList.Add(value);
		try
		{
			OnInsertComplete(num, value);
			return num;
		}
		catch
		{
			InnerList.RemoveAt(num);
			throw;
		}
	}

	void IList.Remove(object value)
	{
		OnValidate(value);
		int num = InnerList.IndexOf(value);
		if (num < 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_RemoveArgNotFound"));
		}
		OnRemove(num, value);
		InnerList.RemoveAt(num);
		try
		{
			OnRemoveComplete(num, value);
		}
		catch
		{
			InnerList.Insert(num, value);
			throw;
		}
	}

	int IList.IndexOf(object value)
	{
		return InnerList.IndexOf(value);
	}

	void IList.Insert(int index, object value)
	{
		if (index < 0 || index > Count)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		OnValidate(value);
		OnInsert(index, value);
		InnerList.Insert(index, value);
		try
		{
			OnInsertComplete(index, value);
		}
		catch
		{
			InnerList.RemoveAt(index);
			throw;
		}
	}

	[__DynamicallyInvokable]
	public IEnumerator GetEnumerator()
	{
		return InnerList.GetEnumerator();
	}

	protected virtual void OnSet(int index, object oldValue, object newValue)
	{
	}

	protected virtual void OnInsert(int index, object value)
	{
	}

	protected virtual void OnClear()
	{
	}

	protected virtual void OnRemove(int index, object value)
	{
	}

	protected virtual void OnValidate(object value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
	}

	protected virtual void OnSetComplete(int index, object oldValue, object newValue)
	{
	}

	protected virtual void OnInsertComplete(int index, object value)
	{
	}

	protected virtual void OnClearComplete()
	{
	}

	protected virtual void OnRemoveComplete(int index, object value)
	{
	}
}
