using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

public struct FInputTouchBindingHandle
{
	public IntPtr Address;

	public FInputBindingHandle Base => (FInputBindingHandle)Address;

	public EInputEventType KeyEvent
	{
		get
		{
			return (EInputEventType)Native_FInputTouchBinding.Get_KeyEvent(Address);
		}
		set
		{
			Native_FInputTouchBinding.Set_KeyEvent(Address, (byte)value);
		}
	}

	public FInputTouchUnifiedDelegateHandle TouchDelegate => (FInputTouchUnifiedDelegateHandle)Native_FInputTouchBinding.Get_TouchDelegate(Address);

	public FInputTouchBindingHandle(IntPtr address)
	{
		Address = address;
	}

	public static implicit operator IntPtr(FInputTouchBindingHandle handle)
	{
		return handle.Address;
	}

	public static explicit operator FInputTouchBindingHandle(IntPtr address)
	{
		return new FInputTouchBindingHandle(address);
	}
}
