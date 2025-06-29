using System;
using System.Collections;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public class TArrayReadWrite<T> : TArrayBase<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	public T this[int index]
	{
		get
		{
			return Get(index);
		}
		set
		{
			if (index < 0 || index >= base.Count)
			{
				throw new IndexOutOfRangeException($"Index {index} out of bounds. Array is size {base.Count}");
			}
			ToNative(base.Data, index, ArrayHelper.InnerPropertyAddress, value);
		}
	}

	public bool IsReadOnly => false;

	public TArrayReadWrite(UObject owner, FFieldAddress arrayProperty, IntPtr address, MarshalingDelegates<T>.FromNative fromNative, MarshalingDelegates<T>.ToNative toNative)
		: base(owner, arrayProperty, address, fromNative, toNative)
	{
	}

	public void SetValues(IList<T> values)
	{
		CheckOwner();
		ArrayHelper.Update(property);
		ArrayHelper.EmptyAndAddZeroedValues(values.Count);
		for (int i = 0; i < values.Count; i++)
		{
			ToNative(base.Data, i, ArrayHelper.InnerPropertyAddress, values[i]);
		}
	}

	public void Add(T item)
	{
		int count = base.Count;
		AddInternal();
		this[count] = item;
	}

	public void Clear()
	{
		ClearInternal();
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		int count = base.Count;
		for (int i = 0; i < count; i++)
		{
			array[i + arrayIndex] = this[i];
		}
	}

	public bool Remove(T item)
	{
		int num = IndexOf(item);
		if (num != -1)
		{
			RemoveAt(num);
			return true;
		}
		return false;
	}

	public void Insert(int index, T item)
	{
		InsertInternal(index);
		this[index] = item;
	}

	public void RemoveAt(int index)
	{
		RemoveAtInternal(index);
	}

	public List<T> ToList()
	{
		return new List<T>(this);
	}
}
