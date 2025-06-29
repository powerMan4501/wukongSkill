using System;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

public struct FInputVectorAxisBindingHandle
{
	public IntPtr Address;

	public FInputBindingHandle Base => (FInputBindingHandle)Address;

	public FVector AxisValue
	{
		get
		{
			Native_FInputVectorAxisBinding.Get_AxisValue(Address, out var result);
			return result;
		}
		set
		{
			Native_FInputVectorAxisBinding.Set_AxisValue(Address, ref value);
		}
	}

	public FKey AxisKey
	{
		get
		{
			Native_FInputVectorAxisBinding.Get_AxisKey(Address, out var result);
			return result;
		}
		set
		{
			Native_FInputVectorAxisBinding.Set_AxisKey(Address, ref value);
		}
	}

	public FInputVectorAxisUnifiedDelegateHandle AxisDelegate => (FInputVectorAxisUnifiedDelegateHandle)Native_FInputVectorAxisBinding.Get_AxisDelegate(Address);

	public FInputVectorAxisBindingHandle(IntPtr address)
	{
		Address = address;
	}

	public static implicit operator IntPtr(FInputVectorAxisBindingHandle handle)
	{
		return handle.Address;
	}

	public static explicit operator FInputVectorAxisBindingHandle(IntPtr address)
	{
		return new FInputVectorAxisBindingHandle(address);
	}
}
