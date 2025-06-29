using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FScriptSet
{
	public FScriptSparseArray Elements;

	public FHashAllocator Hash;

	public int HashSize;

	public int Count => Native_FScriptSet.Num(ref this);

	public bool IsValidIndex(int index)
	{
		return Native_FScriptSet.IsValidIndex(ref this, index);
	}

	public int Num()
	{
		return Native_FScriptSet.Num(ref this);
	}

	public int GetMaxIndex()
	{
		return Native_FScriptSet.GetMaxIndex(ref this);
	}

	public IntPtr GetData(int index, ref FScriptSetLayout layout)
	{
		return Native_FScriptSet.GetData(ref this, index, ref layout);
	}

	public void Empty(int slack, ref FScriptSetLayout layout)
	{
		Native_FScriptSet.Empty(ref this, slack, ref layout);
	}

	public void RemoveAt(int index, ref FScriptSetLayout layout)
	{
		Native_FScriptSet.RemoveAt(ref this, index, ref layout);
	}

	public int AddUninitialized(ref FScriptSetLayout layout)
	{
		return Native_FScriptSet.AddUninitialized(ref this, ref layout);
	}

	public void Rehash(ref FScriptSetLayout layout, HashDelegates.GetKeyHash getKeyHash)
	{
		Native_FScriptSet.Rehash(ref this, ref layout, getKeyHash);
	}

	public int FindIndex(IntPtr element, ref FScriptSetLayout layout, HashDelegates.GetKeyHash getKeyHash, HashDelegates.Equality equalityFn)
	{
		return Native_FScriptSet.FindIndex(ref this, element, ref layout, getKeyHash, equalityFn);
	}

	public void Add(IntPtr element, ref FScriptSetLayout layout, HashDelegates.GetKeyHash getKeyHash, HashDelegates.Equality equalityFn, HashDelegates.Construct constructFn, HashDelegates.Destruct destructFn)
	{
		Native_FScriptSet.Add(ref this, element, ref layout, getKeyHash, equalityFn, constructFn, destructFn);
	}

	public void Destroy()
	{
		Native_FScriptSet.Destroy(ref this);
		ZeroMemory();
	}

	public unsafe void Destroy(IntPtr mapProperty)
	{
		fixed (FScriptSet* ptr = &this)
		{
			Native_FProperty.DestroyValue(mapProperty, (IntPtr)ptr);
		}
		ZeroMemory();
	}

	public void Destroy(FSetProperty property)
	{
		Destroy(property.Address);
	}

	private void ZeroMemory()
	{
		FMemory.Memzero(ref this);
	}

	public static FScriptSetLayout GetScriptLayout(int elementSize, int elementAlignment)
	{
		return Native_FScriptSet.GetScriptLayout(elementSize, elementAlignment);
	}
}
