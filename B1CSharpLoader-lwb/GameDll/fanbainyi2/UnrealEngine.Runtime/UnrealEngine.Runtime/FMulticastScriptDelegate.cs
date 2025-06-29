using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FMulticastScriptDelegate
{
	public FScriptArray InvocationList;

	private int ElementSize => Marshal.SizeOf(typeof(FScriptDelegate));

	public FScriptDelegate this[int index]
	{
		get
		{
			return BlittableTypeMarshaler<FScriptDelegate>.FromNative(InvocationList.Data, index);
		}
		set
		{
			BlittableTypeMarshaler<FScriptDelegate>.ToNative(InvocationList.Data, index, value);
		}
	}

	public int Count => InvocationList.Count;

	public FScriptDelegate Get(int index)
	{
		return this[index];
	}

	public void Set(int index, FScriptDelegate value)
	{
		this[index] = value;
	}

	public void Clear()
	{
		InvocationList.Empty(0, ElementSize);
	}

	public void Add(FScriptDelegate value)
	{
		this[InvocationList.AddZeroed(ElementSize)] = value;
	}

	public void Remove(FScriptDelegate value)
	{
		int num = IndexOf(value);
		if (num >= 0)
		{
			RemoveAt(num);
		}
	}

	public void RemoveAt(int index)
	{
		if (index >= 0 && index < Count)
		{
			InvocationList.RemoveAt(index, ElementSize);
		}
	}

	public int IndexOf(FScriptDelegate value)
	{
		EqualityComparer<FScriptDelegate> equalityComparer = EqualityComparer<FScriptDelegate>.Default;
		int count = Count;
		for (int i = 0; i < count; i++)
		{
			if (equalityComparer.Equals(this[i], value))
			{
				return i;
			}
		}
		return -1;
	}

	public bool Contains(FScriptDelegate value)
	{
		return IndexOf(value) >= 0;
	}

	public int IndexOf(IntPtr obj, FName functionName)
	{
		if (obj == IntPtr.Zero)
		{
			return -1;
		}
		int count = Count;
		for (int i = 0; i < count; i++)
		{
			FScriptDelegate fScriptDelegate = this[i];
			if (fScriptDelegate.Object.GetPtrEvenIfUnreachable() == obj && fScriptDelegate.FunctionName == functionName)
			{
				return i;
			}
		}
		return -1;
	}

	public bool Contains(IntPtr obj, FName functionName)
	{
		return IndexOf(obj, functionName) >= 0;
	}

	public bool IsBoundToObject(IntPtr obj)
	{
		if (obj == IntPtr.Zero)
		{
			return false;
		}
		int count = Count;
		for (int i = 0; i < count; i++)
		{
			if (this[i].Object.GetPtrEvenIfUnreachable() == obj)
			{
				return true;
			}
		}
		return false;
	}

	public void ProcessMulticastDelegate(IntPtr parameters)
	{
		Native_FMulticastScriptDelegate.ProcessMulticastDelegate(ref this, parameters);
	}
}
