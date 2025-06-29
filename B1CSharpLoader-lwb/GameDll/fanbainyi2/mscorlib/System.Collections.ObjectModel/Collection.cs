using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace System.Collections.ObjectModel;

[Serializable]
[ComVisible(false)]
[DebuggerTypeProxy(typeof(Mscorlib_CollectionDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
[__DynamicallyInvokable]
public class Collection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	private IList<T> items;

	[NonSerialized]
	private object _syncRoot;

	[__DynamicallyInvokable]
	public int Count
	{
		[__DynamicallyInvokable]
		get
		{
			return items.Count;
		}
	}

	[__DynamicallyInvokable]
	protected IList<T> Items
	{
		[__DynamicallyInvokable]
		get
		{
			return items;
		}
	}

	[__DynamicallyInvokable]
	public T this[int index]
	{
		[__DynamicallyInvokable]
		get
		{
			return items[index];
		}
		[__DynamicallyInvokable]
		set
		{
			if (items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			if (index < 0 || index >= items.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			SetItem(index, value);
		}
	}

	[__DynamicallyInvokable]
	bool ICollection<T>.IsReadOnly
	{
		[__DynamicallyInvokable]
		get
		{
			return items.IsReadOnly;
		}
	}

	[__DynamicallyInvokable]
	bool ICollection.IsSynchronized
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[__DynamicallyInvokable]
	object ICollection.SyncRoot
	{
		[__DynamicallyInvokable]
		get
		{
			if (_syncRoot == null)
			{
				if (items is ICollection collection)
				{
					_syncRoot = collection.SyncRoot;
				}
				else
				{
					Interlocked.CompareExchange<object>(ref _syncRoot, new object(), (object)null);
				}
			}
			return _syncRoot;
		}
	}

	[__DynamicallyInvokable]
	object IList.this[int index]
	{
		[__DynamicallyInvokable]
		get
		{
			return items[index];
		}
		[__DynamicallyInvokable]
		set
		{
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
			try
			{
				this[index] = (T)value;
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
			}
		}
	}

	[__DynamicallyInvokable]
	bool IList.IsReadOnly
	{
		[__DynamicallyInvokable]
		get
		{
			return items.IsReadOnly;
		}
	}

	[__DynamicallyInvokable]
	bool IList.IsFixedSize
	{
		[__DynamicallyInvokable]
		get
		{
			if (items is IList list)
			{
				return list.IsFixedSize;
			}
			return items.IsReadOnly;
		}
	}

	[__DynamicallyInvokable]
	public Collection()
	{
		items = new List<T>();
	}

	[__DynamicallyInvokable]
	public Collection(IList<T> list)
	{
		if (list == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.list);
		}
		items = list;
	}

	[__DynamicallyInvokable]
	public void Add(T item)
	{
		if (items.IsReadOnly)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}
		int count = items.Count;
		InsertItem(count, item);
	}

	[__DynamicallyInvokable]
	public void Clear()
	{
		if (items.IsReadOnly)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}
		ClearItems();
	}

	[__DynamicallyInvokable]
	public void CopyTo(T[] array, int index)
	{
		items.CopyTo(array, index);
	}

	[__DynamicallyInvokable]
	public bool Contains(T item)
	{
		return items.Contains(item);
	}

	[__DynamicallyInvokable]
	public IEnumerator<T> GetEnumerator()
	{
		return items.GetEnumerator();
	}

	[__DynamicallyInvokable]
	public int IndexOf(T item)
	{
		return items.IndexOf(item);
	}

	[__DynamicallyInvokable]
	public void Insert(int index, T item)
	{
		if (items.IsReadOnly)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}
		if (index < 0 || index > items.Count)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_ListInsert);
		}
		InsertItem(index, item);
	}

	[__DynamicallyInvokable]
	public bool Remove(T item)
	{
		if (items.IsReadOnly)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}
		int num = items.IndexOf(item);
		if (num < 0)
		{
			return false;
		}
		RemoveItem(num);
		return true;
	}

	[__DynamicallyInvokable]
	public void RemoveAt(int index)
	{
		if (items.IsReadOnly)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}
		if (index < 0 || index >= items.Count)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException();
		}
		RemoveItem(index);
	}

	[__DynamicallyInvokable]
	protected virtual void ClearItems()
	{
		items.Clear();
	}

	[__DynamicallyInvokable]
	protected virtual void InsertItem(int index, T item)
	{
		items.Insert(index, item);
	}

	[__DynamicallyInvokable]
	protected virtual void RemoveItem(int index)
	{
		items.RemoveAt(index);
	}

	[__DynamicallyInvokable]
	protected virtual void SetItem(int index, T item)
	{
		items[index] = item;
	}

	[__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable)items).GetEnumerator();
	}

	[__DynamicallyInvokable]
	void ICollection.CopyTo(Array array, int index)
	{
		if (array == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
		}
		if (array.Rank != 1)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
		}
		if (array.GetLowerBound(0) != 0)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
		}
		if (index < 0)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (array.Length - index < Count)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		if (array is T[] array2)
		{
			items.CopyTo(array2, index);
			return;
		}
		Type elementType = array.GetType().GetElementType();
		Type typeFromHandle = typeof(T);
		if (!elementType.IsAssignableFrom(typeFromHandle) && !typeFromHandle.IsAssignableFrom(elementType))
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
		}
		object[] array3 = array as object[];
		if (array3 == null)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
		}
		int count = items.Count;
		try
		{
			for (int i = 0; i < count; i++)
			{
				array3[index++] = items[i];
			}
		}
		catch (ArrayTypeMismatchException)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArrayType);
		}
	}

	[__DynamicallyInvokable]
	int IList.Add(object value)
	{
		if (items.IsReadOnly)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}
		ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
		try
		{
			Add((T)value);
		}
		catch (InvalidCastException)
		{
			ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
		}
		return Count - 1;
	}

	[__DynamicallyInvokable]
	bool IList.Contains(object value)
	{
		if (IsCompatibleObject(value))
		{
			return Contains((T)value);
		}
		return false;
	}

	[__DynamicallyInvokable]
	int IList.IndexOf(object value)
	{
		if (IsCompatibleObject(value))
		{
			return IndexOf((T)value);
		}
		return -1;
	}

	[__DynamicallyInvokable]
	void IList.Insert(int index, object value)
	{
		if (items.IsReadOnly)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}
		ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
		try
		{
			Insert(index, (T)value);
		}
		catch (InvalidCastException)
		{
			ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
		}
	}

	[__DynamicallyInvokable]
	void IList.Remove(object value)
	{
		if (items.IsReadOnly)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}
		if (IsCompatibleObject(value))
		{
			Remove((T)value);
		}
	}

	private static bool IsCompatibleObject(object value)
	{
		if (!(value is T))
		{
			if (value == null)
			{
				return default(T) == null;
			}
			return false;
		}
		return true;
	}
}
