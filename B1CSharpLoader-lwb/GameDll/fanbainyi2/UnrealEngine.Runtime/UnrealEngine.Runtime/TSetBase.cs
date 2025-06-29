using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[DebuggerTypeProxy(typeof(TSetDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
public class TSetBase<T> : IEnumerable<T>, IEnumerable
{
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private int index;

		private TSetBase<T> set;

		public T Current => set.Get(index);

		object IEnumerator.Current => Current;

		public Enumerator(TSetBase<T> set)
		{
			this.set = set;
			index = -1;
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			int maxIndex = set.SetHelper.GetMaxIndex();
			while (++index < maxIndex && !set.SetHelper.IsValidIndex(index))
			{
			}
			return index < maxIndex;
		}

		public void Reset()
		{
			index = -1;
		}
	}

	protected readonly UObject Owner;

	protected MarshalingDelegates<T>.FromNative FromNative;

	protected MarshalingDelegates<T>.ToNative ToNative;

	private readonly FFieldAddress property;

	private unsafe readonly FScriptSet* set;

	protected FScriptSetHelper SetHelper;

	public unsafe int Count => set->Count;

	protected unsafe IntPtr Address => (IntPtr)set;

	public unsafe TSetBase(UObject owner, FFieldAddress setProperty, IntPtr address, MarshalingDelegates<T>.FromNative fromNative, MarshalingDelegates<T>.ToNative toNative)
	{
		property = setProperty;
		set = (FScriptSet*)(void*)address;
		SetHelper = new FScriptSetHelper(property.Address, address);
		Owner = owner;
		FromNative = fromNative;
		ToNative = toNative;
		ContainerHashValidator.Validate(Native_FSetProperty.Get_ElementProp(setProperty.Address));
	}

	[Conditional("DEBUG")]
	protected void CheckOwner()
	{
		if (Owner != null && Owner.IsDestroyed)
		{
			throw new UObjectDestroyedException("Trying to access a TSet which points to memory of a destroyed UObject (" + property.PathName + ")");
		}
	}

	protected void ClearInternal()
	{
		SetHelper.Update(property);
		SetHelper.EmptyValues();
	}

	protected void AddInternal(T item)
	{
		SetHelper.Update(property);
		SetHelper.AddElement(item, ToNative);
	}

	protected void RemoveAtInternal(int index)
	{
		if (SetHelper.IsValidIndex(index))
		{
			SetHelper.Update(property);
			SetHelper.RemoveAt(index);
		}
	}

	public T Get(int index)
	{
		if (!SetHelper.IsValidIndex(index))
		{
			throw new IndexOutOfRangeException($"Index {index} is invalid. Indicies aren't necessarily sequential.");
		}
		SetHelper.Update(property);
		return FromNative(SetHelper.GetElementPtr(index), 0, SetHelper.ElementPropertyAddress);
	}

	public bool Contains(T item)
	{
		return IndexOf(item) >= 0;
	}

	public int IndexOf(T item)
	{
		SetHelper.Update(property);
		return SetHelper.IndexOf(item, ToNative, Owner);
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
