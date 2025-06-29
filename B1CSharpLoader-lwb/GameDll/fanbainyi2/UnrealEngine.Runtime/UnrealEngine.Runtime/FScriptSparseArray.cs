using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FScriptSparseArray
{
	public FScriptArray Data;

	public FScriptBitArray AllocationFlags;

	public int FirstFreeIndex;

	public int NumFreeIndices;

	public int Count => Native_FScriptSparseArray.Num(ref this);

	public bool IsValidIndex(int index)
	{
		return Native_FScriptSparseArray.IsValidIndex(ref this, index);
	}

	public int Num()
	{
		return Native_FScriptSparseArray.Num(ref this);
	}

	public int GetMaxIndex()
	{
		return Native_FScriptSparseArray.GetMaxIndex(ref this);
	}

	public IntPtr GetData(int index, ref FScriptSparseArrayLayout layout)
	{
		return Native_FScriptSparseArray.GetData(ref this, index, ref layout);
	}

	public void Empty(int slack, ref FScriptSparseArrayLayout layout)
	{
		Native_FScriptSparseArray.Empty(ref this, slack, ref layout);
	}

	public int AddUninitialized(ref FScriptSparseArrayLayout layout)
	{
		return Native_FScriptSparseArray.AddUninitialized(ref this, ref layout);
	}

	public void RemoveAtUninitialized(ref FScriptSparseArrayLayout layout, int index, int count = 1)
	{
		Native_FScriptSparseArray.RemoveAtUninitialized(ref this, ref layout, index, count);
	}

	public void Destroy()
	{
		Native_FScriptSparseArray.Destroy(ref this);
		ZeroMemory();
	}

	private void ZeroMemory()
	{
		FMemory.Memzero(ref this);
	}

	public static FScriptSparseArrayLayout GetScriptLayout(int elementSize, int elementAlignment)
	{
		return Native_FScriptSparseArray.GetScriptLayout(elementSize, elementAlignment);
	}
}
