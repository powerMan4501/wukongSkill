using System;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

public struct FInputAxisKeyBindingHandle
{
	public IntPtr Address;

	public FInputBindingHandle Base => (FInputBindingHandle)Address;

	public float AxisValue
	{
		get
		{
			return Native_FInputAxisKeyBinding.Get_AxisValue(Address);
		}
		set
		{
			Native_FInputAxisKeyBinding.Set_AxisValue(Address, value);
		}
	}

	public FKey AxisKey
	{
		get
		{
			Native_FInputAxisKeyBinding.Get_AxisKey(Address, out var result);
			return result;
		}
		set
		{
			Native_FInputAxisKeyBinding.Set_AxisKey(Address, ref value);
		}
	}

	public FInputAxisUnifiedDelegateHandle AxisDelegate => (FInputAxisUnifiedDelegateHandle)Native_FInputAxisKeyBinding.Get_AxisDelegate(Address);

	public FInputAxisKeyBindingHandle(IntPtr address)
	{
		Address = address;
	}

	public static implicit operator IntPtr(FInputAxisKeyBindingHandle handle)
	{
		return handle.Address;
	}

	public static explicit operator FInputAxisKeyBindingHandle(IntPtr address)
	{
		return new FInputAxisKeyBindingHandle(address);
	}
}
