using System;

namespace UnrealEngine.Runtime;

public abstract class FMulticastDelegate<TDelegate> : FDelegateBase<TDelegate> where TDelegate : class
{
	private FMulticastScriptDelegateWrapper managedScriptDelegate;

	private unsafe FMulticastScriptDelegate* scriptDelegatePtr => (FMulticastScriptDelegate*)(void*)base.Address;

	public unsafe int Count
	{
		get
		{
			if (!base.IsNative)
			{
				return managedScriptDelegate.Count;
			}
			return scriptDelegatePtr->Count;
		}
	}

	public override bool IsBound => Count > 0;

	public unsafe override void FromNative(IntPtr address)
	{
		Clear();
		FMulticastScriptDelegate fMulticastScriptDelegate = *(FMulticastScriptDelegate*)(void*)address;
		for (int i = 0; i < fMulticastScriptDelegate.Count; i++)
		{
			if (base.IsNative)
			{
				scriptDelegatePtr->Add(fMulticastScriptDelegate[i]);
			}
			else
			{
				managedScriptDelegate.Add(fMulticastScriptDelegate[i]);
			}
		}
	}

	public unsafe override void ToNative(IntPtr address)
	{
		FMulticastScriptDelegate* ptr = (FMulticastScriptDelegate*)(void*)address;
		ptr->Clear();
		for (int i = 0; i < Count; i++)
		{
			if (base.IsNative)
			{
				ptr->Add(scriptDelegatePtr->Get(i));
			}
			else
			{
				ptr->Add(managedScriptDelegate[i]);
			}
		}
	}

	public unsafe override void CopyFrom(FDelegateBase<TDelegate> other)
	{
		Clear();
		if (!(other is FMulticastDelegate<TDelegate> fMulticastDelegate))
		{
			return;
		}
		if (fMulticastDelegate.IsNative)
		{
			FMulticastScriptDelegate fMulticastScriptDelegate = *fMulticastDelegate.scriptDelegatePtr;
			int count = fMulticastScriptDelegate.Count;
			for (int i = 0; i < count; i++)
			{
				if (base.IsNative)
				{
					scriptDelegatePtr->Add(fMulticastScriptDelegate[i]);
				}
				else
				{
					managedScriptDelegate.Add(fMulticastScriptDelegate[i]);
				}
			}
			return;
		}
		FMulticastScriptDelegateWrapper fMulticastScriptDelegateWrapper = fMulticastDelegate.managedScriptDelegate;
		int count2 = fMulticastScriptDelegateWrapper.Count;
		for (int j = 0; j < count2; j++)
		{
			if (base.IsNative)
			{
				scriptDelegatePtr->Add(fMulticastScriptDelegateWrapper[j]);
			}
			else
			{
				managedScriptDelegate.Add(fMulticastScriptDelegateWrapper[j]);
			}
		}
	}

	public unsafe override void Bind(IntPtr obj, FName functionName)
	{
		if (base.IsNative)
		{
			if (!scriptDelegatePtr->Contains(obj, functionName))
			{
				scriptDelegatePtr->Add(new FScriptDelegate(obj, functionName));
			}
		}
		else if (!managedScriptDelegate.Contains(obj, functionName))
		{
			managedScriptDelegate.Add(new FScriptDelegate(obj, functionName));
		}
	}

	public unsafe override void Unbind(IntPtr obj, FName functionName)
	{
		if (base.IsNative)
		{
			int num = scriptDelegatePtr->IndexOf(obj, functionName);
			if (num >= 0)
			{
				scriptDelegatePtr->RemoveAt(num);
			}
		}
		else
		{
			int num2 = managedScriptDelegate.IndexOf(obj, functionName);
			if (num2 >= 0)
			{
				managedScriptDelegate.RemoveAt(num2);
			}
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
			return scriptDelegatePtr->Contains(obj, functionName);
		}
		return managedScriptDelegate.Contains(obj, functionName);
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
			scriptDelegatePtr->ProcessMulticastDelegate(parameters);
		}
		else
		{
			managedScriptDelegate.ProcessMulticastDelegate(parameters);
		}
	}

	public unsafe FScriptDelegate[] GetFunctionInfos()
	{
		FScriptDelegate[] array = new FScriptDelegate[Count];
		if (base.IsNative)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (*scriptDelegatePtr)[i];
			}
		}
		else
		{
			for (int j = 0; j < array.Length; j++)
			{
				array[j] = managedScriptDelegate[j];
			}
		}
		return array;
	}

	public unsafe UObject[] GetObjects()
	{
		UObject[] array = new UObject[Count];
		if (base.IsNative)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (*scriptDelegatePtr)[i].Object.Get();
			}
		}
		else
		{
			for (int j = 0; j < array.Length; j++)
			{
				array[j] = managedScriptDelegate[j].Object.Get();
			}
		}
		return array;
	}

	public unsafe IntPtr[] GetObjectAddresses()
	{
		IntPtr[] array = new IntPtr[Count];
		if (base.IsNative)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (*scriptDelegatePtr)[i].Object.GetPtr();
			}
		}
		else
		{
			for (int j = 0; j < array.Length; j++)
			{
				array[j] = managedScriptDelegate[j].Object.GetPtr();
			}
		}
		return array;
	}

	public unsafe UFunction[] GetFunctions()
	{
		UFunction[] array = new UFunction[Count];
		if (base.IsNative)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (*scriptDelegatePtr)[i].GetFunction();
			}
		}
		else
		{
			for (int j = 0; j < array.Length; j++)
			{
				array[j] = managedScriptDelegate[j].GetFunction();
			}
		}
		return array;
	}

	public unsafe IntPtr[] GetFunctionAddresses()
	{
		IntPtr[] array = new IntPtr[Count];
		if (base.IsNative)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (*scriptDelegatePtr)[i].GetFunctionAddress();
			}
		}
		else
		{
			for (int j = 0; j < array.Length; j++)
			{
				array[j] = managedScriptDelegate[j].GetFunctionAddress();
			}
		}
		return array;
	}
}
