using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FScriptMap
{
	public FScriptSet Pairs;

	public static readonly int StructSize = Marshal.SizeOf<FScriptMap>();

	public int Count => Pairs.Count;

	public bool IsValidIndex(int index)
	{
		return Pairs.IsValidIndex(index);
	}

	public int Num()
	{
		return Pairs.Num();
	}

	public int GetMaxIndex()
	{
		return Pairs.GetMaxIndex();
	}

	public IntPtr GetData(int index, ref FScriptMapLayout layout)
	{
		return Pairs.GetData(index, ref layout.SetLayout);
	}

	public void Empty(int slack, ref FScriptMapLayout layout)
	{
		Pairs.Empty(slack, ref layout.SetLayout);
	}

	public void RemoveAt(int index, ref FScriptMapLayout layout)
	{
		Pairs.RemoveAt(index, ref layout.SetLayout);
	}

	public int AddUninitialized(ref FScriptMapLayout layout)
	{
		return Pairs.AddUninitialized(ref layout.SetLayout);
	}

	public void Rehash(ref FScriptMapLayout layout, HashDelegates.GetKeyHash getKeyHash)
	{
		Pairs.Rehash(ref layout.SetLayout, getKeyHash);
	}

	public unsafe int FindPairIndex(IntPtr key, ref FScriptMapLayout layout, HashDelegates.GetKeyHash getKeyHash, HashDelegates.Equality keyEqualityFn)
	{
		int result;
		fixed (FScriptMap* ptr = &this)
		{
			result = Native_FScriptMap.FindPairIndex((IntPtr)ptr, key, ref layout, getKeyHash, keyEqualityFn);
		}
		return result;
	}

	public unsafe int FindPairIndexEx(IntPtr key, ref FScriptMapLayout layout, IntPtr KeyProperty)
	{
		int result;
		fixed (FScriptMap* ptr = &this)
		{
			result = Native_FScriptMapEx.FindPairIndex((IntPtr)ptr, key, ref layout, KeyProperty);
		}
		return result;
	}

	public unsafe IntPtr FindValue(IntPtr key, ref FScriptMapLayout layout, HashDelegates.GetKeyHash getKeyHash, HashDelegates.Equality keyEqualityFn)
	{
		fixed (FScriptMap* ptr = &this)
		{
			return Native_FScriptMap.FindValue((IntPtr)ptr, key, ref layout, getKeyHash, keyEqualityFn);
		}
	}

	public unsafe IntPtr FindValueEx(IntPtr key, ref FScriptMapLayout layout, IntPtr KeyProperty)
	{
		fixed (FScriptMap* ptr = &this)
		{
			return Native_FScriptMapEx.FindValue((IntPtr)ptr, key, ref layout, KeyProperty);
		}
	}

	public unsafe void Add(IntPtr key, IntPtr value, ref FScriptMapLayout layout, HashDelegates.GetKeyHash getKeyHash, HashDelegates.Equality keyEqualityFn, HashDelegates.ConstructAndAssign keyConstructAndAssignFn, HashDelegates.ConstructAndAssign valueConstructAndAssignFn, HashDelegates.Assign valueAssignFn, HashDelegates.Destruct destructKeyFn, HashDelegates.Destruct destructValueFn)
	{
		fixed (FScriptMap* ptr = &this)
		{
			Native_FScriptMap.Add((IntPtr)ptr, key, value, ref layout, getKeyHash, keyEqualityFn, keyConstructAndAssignFn, valueConstructAndAssignFn, valueAssignFn, destructKeyFn, destructValueFn);
		}
	}

	public unsafe void AddEx(IntPtr key, IntPtr value, ref FScriptMapLayout layout, IntPtr KeyProperty, IntPtr ValueProperty)
	{
		fixed (FScriptMap* ptr = &this)
		{
			Native_FScriptMapEx.Add((IntPtr)ptr, key, value, ref layout, KeyProperty, ValueProperty);
		}
	}

	public unsafe void Destroy()
	{
		fixed (FScriptMap* ptr = &this)
		{
			Native_FScriptMap.Destroy((IntPtr)ptr);
		}
		ZeroMemory();
	}

	public unsafe void Destroy(IntPtr property)
	{
		fixed (FScriptMap* ptr = &this)
		{
			Native_FProperty.DestroyValue(property, (IntPtr)ptr);
		}
		ZeroMemory();
	}

	public void Destroy(FMapProperty property)
	{
		Destroy(property.Address);
	}

	private void ZeroMemory()
	{
		FMemory.Memzero(ref this);
	}

	public static FScriptMapLayout GetScriptLayout(int keySize, int keyAlignment, int valueSize, int valueAlignment)
	{
		return Native_FScriptMap.GetScriptLayout(keySize, keyAlignment, valueSize, valueAlignment);
	}
}
