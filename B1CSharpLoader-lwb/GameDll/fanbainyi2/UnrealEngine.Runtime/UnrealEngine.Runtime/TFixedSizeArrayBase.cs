using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnrealEngine.Runtime;

[DebuggerTypeProxy(typeof(TFixedSizeArrayDebugView<>))]
[DebuggerDisplay("Length = {Length}")]
public abstract class TFixedSizeArrayBase<T> : IEnumerable<T>, IEnumerable
{
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private int index;

		private TFixedSizeArrayBase<T> array;

		public T Current => array.Get(index);

		object IEnumerator.Current => Current;

		public Enumerator(TFixedSizeArrayBase<T> array)
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
			return index < array.Length;
		}

		public void Reset()
		{
			index = -1;
		}
	}

	private readonly IntPtr address;

	private readonly FFieldAddress property;

	private readonly UObject owner;

	private static readonly MarshalingDelegates<T>.FromNative fromNative = MarshalingDelegateResolver<T>.FromNative;

	private static readonly MarshalingDelegates<T>.ToNative toNative = MarshalingDelegateResolver<T>.ToNative;

	public int Length => property.ArrayDim;

	public TFixedSizeArrayBase(IntPtr address, FFieldAddress property, UObject owner)
	{
		this.address = address;
		this.property = property;
		this.owner = owner;
	}

	private void CheckOwner()
	{
		if (owner != null && owner.IsDestroyed)
		{
			throw new UObjectDestroyedException("Trying to access a TFixedSizeArray which points to memory of a destroyed UObject (" + property.PathName + ")");
		}
	}

	protected T Get(int index)
	{
		CheckOwner();
		if (index < 0 || index >= Length)
		{
			throw new IndexOutOfRangeException($"Index {index} out of bounds. Array is size {Length}.");
		}
		return fromNative(address, index, property.Address);
	}

	protected void Set(int index, ref T value)
	{
		CheckOwner();
		if (index < 0 || index >= Length)
		{
			throw new IndexOutOfRangeException($"Index {index} out of bounds. Array is size {Length}.");
		}
		toNative(address, index, property.Address, value);
	}

	public T[] ToArray()
	{
		T[] array = new T[Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = fromNative(address, i, property.Address);
		}
		return array;
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
