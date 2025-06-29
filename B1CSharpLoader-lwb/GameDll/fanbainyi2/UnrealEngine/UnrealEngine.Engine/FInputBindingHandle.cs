using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

public struct FInputBindingHandle
{
	public IntPtr Address;

	public bool ConsumeInput
	{
		get
		{
			return Native_FInputBinding.Get_bConsumeInput(Address);
		}
		set
		{
			Native_FInputBinding.Set_bConsumeInput(Address, value);
		}
	}

	public bool ExecuteWhenPaused
	{
		get
		{
			return Native_FInputBinding.Get_bExecuteWhenPaused(Address);
		}
		set
		{
			Native_FInputBinding.Set_bExecuteWhenPaused(Address, value);
		}
	}

	public FInputBindingHandle(IntPtr address)
	{
		Address = address;
	}

	public static implicit operator IntPtr(FInputBindingHandle handle)
	{
		return handle.Address;
	}

	public static explicit operator FInputBindingHandle(IntPtr address)
	{
		return new FInputBindingHandle(address);
	}
}
