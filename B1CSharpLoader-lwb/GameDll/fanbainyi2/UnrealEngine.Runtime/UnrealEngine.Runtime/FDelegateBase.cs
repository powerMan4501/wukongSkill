using System;

namespace UnrealEngine.Runtime;

public abstract class FDelegateBase<TDelegate> : IDelegateBase where TDelegate : class
{
	public delegate bool Del_BindHook(TDelegate evnt, out TDelegate newEvnt);

	public delegate bool Del_UnBindHook(TDelegate evnt, out TDelegate newEvnt, out UObject Obj);

	public TDelegate Invoke;

	public static Del_BindHook BindHook;

	public static Del_UnBindHook UnBindHook;

	public IntPtr Address { get; private set; }

	public bool IsNative => Address != IntPtr.Zero;

	public abstract bool IsBound { get; }

	public FDelegateBase()
	{
		Invoke = GetInvoker();
	}

	public void SetAddress(IntPtr address)
	{
		Address = address;
	}

	public virtual TDelegate GetInvoker()
	{
		return null;
	}

	private void OnInvalidDelegate(TDelegate evnt)
	{
		string text = "null";
		string text2 = "null";
		if (evnt is Delegate obj)
		{
			UObject uObject = obj.Target as UObject;
			text = ((!(uObject != null)) ? "null" : uObject.GetPathName());
			text2 = ((!(obj.Method != null)) ? evnt.ToString() : ((obj.Method.DeclaringType != null) ? (obj.Method.DeclaringType.FullName + "." + obj.Method.Name) : obj.Method.Name));
		}
		else
		{
			text2 = evnt.ToString();
		}
		FMessage.Log(ELogVerbosity.Error, "Failed to find UFunction for delegate / dispatcher - UObject(" + text + ") Func(" + text2 + ")");
	}

	public void Bind(UObject obj, FName functionName)
	{
		Bind(obj.Address, functionName);
	}

	public void Bind(TDelegate evnt)
	{
		if (GetFunctionAddress(evnt, out var functionAddress, out var target))
		{
			Bind(target, NativeReflection.GetUFieldFName(functionAddress));
			return;
		}
		bool flag = false;
		if (BindHook != null && BindHook(evnt, out var newEvnt) && GetFunctionAddress(newEvnt, out functionAddress, out target))
		{
			Bind(target, NativeReflection.GetUFieldFName(functionAddress));
			flag = true;
		}
		if (!flag)
		{
			OnInvalidDelegate(evnt);
		}
	}

	public void Unbind(UObject obj, FName functionName)
	{
		Unbind(obj.Address, functionName);
	}

	public void Unbind(TDelegate evnt)
	{
		if (GetFunctionAddress(evnt, out var functionAddress, out var target))
		{
			Unbind(target, NativeReflection.GetUFieldFName(functionAddress));
			return;
		}
		bool flag = true;
		if (UnBindHook != null && UnBindHook(evnt, out var newEvnt, out target) && GetFunctionAddress(newEvnt, out functionAddress, out target))
		{
			Unbind(target, NativeReflection.GetUFieldFName(functionAddress));
			flag = false;
		}
		if (flag)
		{
			OnInvalidDelegate(evnt);
		}
	}

	public bool IsTargetBound(TDelegate evnt)
	{
		if (GetFunctionAddress(evnt, out var functionAddress, out var target))
		{
			return IsTargetBound(target, NativeReflection.GetUFieldFName(functionAddress));
		}
		OnInvalidDelegate(evnt);
		return false;
	}

	public bool IsTargetBound(UObject obj, FName functionName)
	{
		if (!(obj == null))
		{
			return IsTargetBound(obj.Address, functionName);
		}
		return false;
	}

	public bool IsBoundToObject(UObject obj)
	{
		if (!(obj == null))
		{
			return IsBoundToObject(obj.Address);
		}
		return false;
	}

	public abstract void CopyFrom(FDelegateBase<TDelegate> other);

	public abstract void Bind(IntPtr obj, FName functionName);

	public abstract void Unbind(IntPtr obj, FName functionName);

	public abstract void Clear();

	public abstract bool IsTargetBound(IntPtr obj, FName functionName);

	public abstract bool IsBoundToObject(IntPtr obj);

	public abstract void ProcessDelegate(IntPtr parameters);

	protected IntPtr GetFunctionAddress(TDelegate evnt)
	{
		return NativeReflection.LookupTable.GetFunctionAddress(evnt as Delegate);
	}

	protected bool GetFunctionAddress(TDelegate evnt, out IntPtr functionAddress, out UObject target)
	{
		return NativeReflection.LookupTable.GetFunctionAddress(evnt as Delegate, out functionAddress, out target);
	}

	public TDelegateClass Copy<TDelegateClass>() where TDelegateClass : FDelegateBase<TDelegate>, new()
	{
		TDelegateClass val = new TDelegateClass();
		val.CopyFrom(this);
		return val;
	}
}
