using System;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

public struct FInputAxisBindingHandle
{
	public IntPtr Address;

	public FInputBindingHandle Base => (FInputBindingHandle)Address;

	public FName AxisName
	{
		get
		{
			Native_FInputAxisBinding.Get_AxisName(Address, out var result);
			return result;
		}
		set
		{
			Native_FInputAxisBinding.Set_AxisName(Address, ref value);
		}
	}

	public FInputAxisUnifiedDelegateHandle AxisDelegate => (FInputAxisUnifiedDelegateHandle)Native_FInputAxisBinding.Get_AxisDelegate(Address);

	public float AxisValue
	{
		get
		{
			return Native_FInputAxisBinding.Get_AxisValue(Address);
		}
		set
		{
			Native_FInputAxisBinding.Set_AxisValue(Address, value);
		}
	}

	public FInputAxisBindingHandle(IntPtr address)
	{
		Address = address;
	}

	public static implicit operator IntPtr(FInputAxisBindingHandle handle)
	{
		return handle.Address;
	}

	public static explicit operator FInputAxisBindingHandle(IntPtr address)
	{
		return new FInputAxisBindingHandle(address);
	}
}
