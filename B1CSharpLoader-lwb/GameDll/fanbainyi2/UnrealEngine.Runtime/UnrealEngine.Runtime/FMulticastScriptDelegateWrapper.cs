using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

internal struct FMulticastScriptDelegateWrapper
{
	private List<FScriptDelegate> delegates;

	public List<FScriptDelegate> Delegates
	{
		get
		{
			if (delegates == null)
			{
				return delegates = new List<FScriptDelegate>();
			}
			return delegates;
		}
	}

	public FScriptDelegate this[int index]
	{
		get
		{
			return Delegates[index];
		}
		set
		{
			Delegates[index] = value;
		}
	}

	public int Count => Delegates.Count;

	public void Clear()
	{
		Delegates.Clear();
	}

	public void Add(FScriptDelegate value)
	{
		Delegates.Add(value);
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
			Delegates.RemoveAt(index);
		}
	}

	public int IndexOf(FScriptDelegate value)
	{
		return Delegates.IndexOf(value);
	}

	public bool Contains(FScriptDelegate value)
	{
		return IndexOf(value) >= 0;
	}

	public int IndexOf(IntPtr obj, FName functionName)
	{
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
		FMulticastScriptDelegate instance = default(FMulticastScriptDelegate);
		instance.InvocationList.AddZeroed(Marshal.SizeOf(typeof(FScriptDelegate)), Count);
		for (int i = 0; i < Count; i++)
		{
			BlittableTypeMarshaler<FScriptDelegate>.ToNative(instance.InvocationList.Data, i, this[i]);
		}
		Native_FMulticastScriptDelegate.ProcessMulticastDelegate(ref instance, parameters);
		CopyFrom(instance);
		instance.InvocationList.Destroy();
	}

	public void CopyFrom(FMulticastScriptDelegate native)
	{
		Clear();
		int count = native.Count;
		for (int i = 0; i < count; i++)
		{
			Add(native[i]);
		}
	}
}
