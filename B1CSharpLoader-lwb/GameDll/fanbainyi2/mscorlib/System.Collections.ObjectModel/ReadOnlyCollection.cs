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
public class ReadOnlyCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	private IList<T> list;

	[NonSerialized]
	private object _syncRoot;

	[__DynamicallyInvokable]
	public int Count
	{
		[__DynamicallyInvokable]
		get
		{
			return list.Count;
		}
	}

	[__DynamicallyInvokable]
	public T this[int index]
	{
		[__DynamicallyInvokable]
		get
		{
			return list[index];
		}
	}

	[__DynamicallyInvokable]
	protected IList<T> Items
	{
		[__DynamicallyInvokable]
		get
		{
			return list;
		}
	}

	[__DynamicallyInvokable]
	bool ICollection<T>.IsReadOnly
	{
		[__DynamicallyInvokable]
		get
		{
			return true;
		}
	}

	[__DynamicallyInvokable]
	T IList<T>.this[int index]
	{
		[__DynamicallyInvokable]
		get
		{
			return list[index];
		}
		[__DynamicallyInvokable]
		set
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
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
				if (list is ICollection collection)
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
	bool IList.IsFixedSize
	{
		[__DynamicallyInvokable]
		get
		{
			return true;
		}
	}

	[__DynamicallyInvokable]
	bool IList.IsReadOnly
	{
		[__DynamicallyInvokable]
		get
		{
			return true;
		}
	}

	[__DynamicallyInvokable]
	object IList.this[int index]
	{
		[__DynamicallyInvokable]
		get
		{
			return list[index];
		}
		[__DynamicallyInvokable]
		set
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}
	}

	[__DynamicallyInvokable]
	public ReadOnlyCollection(IList<T> list)
	{
		if (list == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.list);
		}
		this.list = list;
	}

	[__DynamicallyInvokable]
	public bool Contains(T value)
	{
		return list.Contains(value);
	}

	[__DynamicallyInvokable]
	public void CopyTo(T[] array, int index)
	{
		list.CopyTo(array, index);
	}

	[__DynamicallyInvokable]
	public IEnumerator<T> GetEnumerator()
	{
		return list.GetEnumerator();
	}

	[__DynamicallyInvokable]
	public int IndexOf(T value)
	{
		return list.IndexOf(value);
	}

	[__DynamicallyInvokable]
	void ICollection<T>.Add(T value)
	{
		ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
	}

	[__DynamicallyInvokable]
	void ICollection<T>.Clear()
	{
		ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
	}

	[__DynamicallyInvokable]
	void IList<T>.Insert(int index, T value)
	{
		ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
	}

	[__DynamicallyInvokable]
	bool ICollection<T>.Remove(T value)
	{
		ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		return false;
	}

	[__DynamicallyInvokable]
	void IList<T>.RemoveAt(int index)
	{
		ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
	}

	[__DynamicallyInvokable]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable)list).GetEnumerator();
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
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.arrayIndex, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
		}
		if (array.Length - index < Count)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		if (array is T[] array2)
		{
			list.CopyTo(array2, index);
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
		int count = list.Count;
		try
		{
			for (int i = 0; i < count; i++)
			{
				array3[index++] = list[i];
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
		ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		return -1;
	}

	[__DynamicallyInvokable]
	void IList.Clear()
	{
		ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
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
		ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
	}

	[__DynamicallyInvokable]
	void IList.Remove(object value)
	{
		ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
	}

	[__DynamicallyInvokable]
	void IList.RemoveAt(int index)
	{
		ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
	}
}
