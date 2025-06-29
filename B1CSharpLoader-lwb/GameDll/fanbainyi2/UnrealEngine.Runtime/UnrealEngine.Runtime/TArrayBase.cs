using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnrealEngine.Runtime;

[DebuggerTypeProxy(typeof(TArrayDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
public class TArrayBase<T> : IEnumerable<T>, IEnumerable
{
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private int index;

		private TArrayBase<T> array;

		public T Current => array.Get(index);

		object IEnumerator.Current => Current;

		public Enumerator(TArrayBase<T> array)
		{
			this.array = array;
			index = -1;
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			index++;
			return index < array.Count;
		}

		public void Reset()
		{
			index = -1;
		}
	}

	protected readonly UObject Owner;

	protected MarshalingDelegates<T>.FromNative FromNative;

	protected MarshalingDelegates<T>.ToNative ToNative;

	protected readonly FFieldAddress property;

	private unsafe readonly FScriptArray* array;

	protected FScriptArrayHelper ArrayHelper;

	public unsafe int Count
	{
		get
		{
			CheckOwner();
			return array->Count;
		}
	}

	protected unsafe IntPtr Address => (IntPtr)array;

	protected unsafe IntPtr Data => array->Data;

	public unsafe TArrayBase(UObject owner, FFieldAddress arrayProperty, IntPtr address, MarshalingDelegates<T>.FromNative fromNative, MarshalingDelegates<T>.ToNative toNative)
	{
		property = arrayProperty;
		array = (FScriptArray*)(void*)address;
		ArrayHelper = new FScriptArrayHelper(property.Address, address);
		Owner = owner;
		FromNative = fromNative;
		ToNative = toNative;
	}

	protected void CheckOwner()
	{
		if (Owner != null && Owner.IsDestroyed)
		{
			throw new UObjectDestroyedException("Trying to access a TArray which points to memory of a destroyed UObject (" + property.PathName + ")");
		}
	}

	protected void ClearInternal()
	{
		CheckOwner();
		ArrayHelper.Update(property);
		ArrayHelper.EmptyValues();
	}

	protected void AddInternal()
	{
		CheckOwner();
		ArrayHelper.Update(property);
		ArrayHelper.AddValue();
	}

	protected void InsertInternal(int index)
	{
		CheckOwner();
		ArrayHelper.Update(property);
		ArrayHelper.InsertValues(index);
	}

	protected void RemoveAtInternal(int index)
	{
		CheckOwner();
		ArrayHelper.Update(property);
		ArrayHelper.RemoveValues(index);
	}

	public T Get(int index)
	{
		if (index < 0 || index >= Count)
		{
			throw new IndexOutOfRangeException($"Index {index} out of bounds. Array is size {Count}");
		}
		ArrayHelper.Update(property);
		return FromNative(Data, index, ArrayHelper.InnerPropertyAddress);
	}

	public bool Contains(T item)
	{
		return IndexOf(item) >= 0;
	}

	public int IndexOf(T item)
	{
		ArrayHelper.Update(property);
		int count = Count;
		if (item == null)
		{
			for (int i = 0; i < count; i++)
			{
				if (FromNative(Data, i, ArrayHelper.InnerPropertyAddress) == null)
				{
					return i;
				}
			}
			return -1;
		}
		EqualityComparer<T> equalityComparer = EqualityComparer<T>.Default;
		for (int j = 0; j < count; j++)
		{
			if (equalityComparer.Equals(FromNative(Data, j, ArrayHelper.InnerPropertyAddress), item))
			{
				return j;
			}
		}
		return -1;
	}

	public Enumerator GetEnumerator()
	{
		return new Enumerator(this);
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return new Enumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new Enumerator(this);
	}
}
