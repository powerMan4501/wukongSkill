using System;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

public struct FInputActionBindingHandle
{
	public IntPtr Address;

	public FInputBindingHandle Base => (FInputBindingHandle)Address;

	public EInputEventType KeyEvent
	{
		get
		{
			return (EInputEventType)Native_FInputActionBinding.Get_KeyEvent(Address);
		}
		set
		{
			Native_FInputActionBinding.Set_KeyEvent(Address, (byte)value);
		}
	}

	public FInputActionUnifiedDelegateHandle ActionDelegate => (FInputActionUnifiedDelegateHandle)Native_FInputActionBinding.Get_ActionDelegate(Address);

	public FName ActionName
	{
		get
		{
			Native_FInputActionBinding.GetActionName(Address, out var result);
			return result;
		}
	}

	public bool IsPaired => Native_FInputActionBinding.IsPaired(Address);

	public FInputActionBindingHandle(IntPtr address)
	{
		Address = address;
	}

	public static implicit operator IntPtr(FInputActionBindingHandle handle)
	{
		return handle.Address;
	}

	public static explicit operator FInputActionBindingHandle(IntPtr address)
	{
		return new FInputActionBindingHandle(address);
	}
}
