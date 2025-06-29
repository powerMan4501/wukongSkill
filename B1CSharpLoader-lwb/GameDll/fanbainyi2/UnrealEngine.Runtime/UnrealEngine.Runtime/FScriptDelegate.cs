using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FScriptDelegate
{
	public FWeakObjectPtr Object;

	public FName FunctionName;

	public bool IsBound
	{
		get
		{
			if (FunctionName != FName.None)
			{
				IntPtr ptr = Object.GetPtr();
				if (ptr != IntPtr.Zero)
				{
					return Native_UObject.FindFunction(ptr, ref FunctionName) != IntPtr.Zero;
				}
				return false;
			}
			return false;
		}
	}

	public FScriptDelegate(UObject obj, FName functionName)
	{
		Object = default(FWeakObjectPtr);
		FunctionName = functionName;
		Object.Set(obj);
	}

	public FScriptDelegate(IntPtr obj, FName functionName)
	{
		Object = default(FWeakObjectPtr);
		FunctionName = functionName;
		Object.Set(obj);
	}

	public FScriptDelegate(FWeakObjectPtr obj, FName functionName)
	{
		Object = obj;
		FunctionName = functionName;
	}

	public void Bind(IntPtr obj, FName functionName)
	{
		Object.Set(obj);
		FunctionName = functionName;
	}

	public void Unbind(IntPtr obj, FName functionName)
	{
		if (Object.GetPtr() == obj && FunctionName == functionName)
		{
			Object.Set(IntPtr.Zero);
			FunctionName = FName.None;
		}
	}

	public bool IsTargetBound(IntPtr obj, FName functionName)
	{
		if (FunctionName == FName.None)
		{
			return false;
		}
		if (Object.GetPtrEvenIfUnreachable() == obj)
		{
			return FunctionName == functionName;
		}
		return false;
	}

	public bool IsBoundToObject(IntPtr obj)
	{
		if (obj == IntPtr.Zero)
		{
			return false;
		}
		return Object.GetPtrEvenIfUnreachable() == obj;
	}

	public void Clear()
	{
		Object.Set(IntPtr.Zero);
		FunctionName = FName.None;
	}

	public void ProcessDelegate(IntPtr parameters)
	{
		Native_FScriptDelegate.ProcessDelegate(ref this, parameters);
	}

	public IntPtr GetFunctionAddress()
	{
		if (FunctionName == FName.None)
		{
			return IntPtr.Zero;
		}
		IntPtr ptr = Object.GetPtr();
		if (!(ptr == IntPtr.Zero))
		{
			return Native_UObject.FindFunction(ptr, ref FunctionName);
		}
		return IntPtr.Zero;
	}

	public UFunction GetFunction()
	{
		return GCHelper.Find<UFunction>(GetFunctionAddress());
	}
}
