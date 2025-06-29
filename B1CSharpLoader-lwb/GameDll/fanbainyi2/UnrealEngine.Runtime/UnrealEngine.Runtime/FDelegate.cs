using System;

namespace UnrealEngine.Runtime;

public abstract class FDelegate<TDelegate> : FDelegateBase<TDelegate> where TDelegate : class
{
	private FScriptDelegate managedScriptDelegate;

	private unsafe FScriptDelegate* scriptDelegatePtr => (FScriptDelegate*)(void*)base.Address;

	public unsafe override bool IsBound
	{
		get
		{
			if (!base.IsNative)
			{
				return managedScriptDelegate.IsBound;
			}
			return scriptDelegatePtr->IsBound;
		}
	}

	public unsafe override void FromNative(IntPtr address)
	{
		Clear();
		FScriptDelegate fScriptDelegate = *(FScriptDelegate*)(void*)address;
		if (base.IsNative)
		{
			*scriptDelegatePtr = fScriptDelegate;
		}
		else
		{
			managedScriptDelegate = fScriptDelegate;
		}
	}

	public unsafe override void ToNative(IntPtr address)
	{
		FScriptDelegate* ptr = (FScriptDelegate*)(void*)address;
		ptr->Clear();
		if (base.IsNative)
		{
			*ptr = *scriptDelegatePtr;
		}
		else
		{
			*ptr = managedScriptDelegate;
		}
	}

	public unsafe override void CopyFrom(FDelegateBase<TDelegate> other)
	{
		Clear();
		if (other is FDelegate<TDelegate> fDelegate)
		{
			FScriptDelegate fScriptDelegate = (fDelegate.IsNative ? (*fDelegate.scriptDelegatePtr) : managedScriptDelegate);
			if (base.IsNative)
			{
				scriptDelegatePtr->Bind(fScriptDelegate.Object.GetPtr(), fScriptDelegate.FunctionName);
			}
			else
			{
				managedScriptDelegate.Bind(fScriptDelegate.Object.GetPtr(), fScriptDelegate.FunctionName);
			}
		}
	}

	public unsafe override void Bind(IntPtr obj, FName functionName)
	{
		if (base.IsNative)
		{
			scriptDelegatePtr->Bind(obj, functionName);
		}
		else
		{
			managedScriptDelegate.Bind(obj, functionName);
		}
	}

	public unsafe override void Unbind(IntPtr obj, FName functionName)
	{
		if (base.IsNative)
		{
			scriptDelegatePtr->Unbind(obj, functionName);
		}
		else
		{
			managedScriptDelegate.Unbind(obj, functionName);
		}
	}

	public unsafe override void Clear()
	{
		if (base.IsNative)
		{
			scriptDelegatePtr->Clear();
		}
		else
		{
			managedScriptDelegate.Clear();
		}
	}

	public unsafe override bool IsTargetBound(IntPtr obj, FName functionName)
	{
		if (base.IsNative)
		{
			return scriptDelegatePtr->IsTargetBound(obj, functionName);
		}
		return managedScriptDelegate.IsTargetBound(obj, functionName);
	}

	public unsafe override bool IsBoundToObject(IntPtr obj)
	{
		if (base.IsNative)
		{
			return scriptDelegatePtr->IsBoundToObject(obj);
		}
		return managedScriptDelegate.IsBoundToObject(obj);
	}

	public unsafe override void ProcessDelegate(IntPtr parameters)
	{
		if (base.IsNative)
		{
			scriptDelegatePtr->ProcessDelegate(parameters);
		}
		else
		{
			managedScriptDelegate.ProcessDelegate(parameters);
		}
	}

	public unsafe FScriptDelegate GetFunctionInfo()
	{
		if (base.IsNative)
		{
			return *scriptDelegatePtr;
		}
		return managedScriptDelegate;
	}

	public UObject GetObject()
	{
		return GetFunctionInfo().Object.Get();
	}

	public IntPtr GetObjectAddress()
	{
		return GetFunctionInfo().Object.GetPtr();
	}

	public UFunction GetFunction()
	{
		return GetFunctionInfo().GetFunction();
	}

	public IntPtr GetFunctionAddress()
	{
		return GetFunctionInfo().GetFunctionAddress();
	}
}
