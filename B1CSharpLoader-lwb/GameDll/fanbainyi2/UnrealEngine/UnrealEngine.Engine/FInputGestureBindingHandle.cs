using System;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

public struct FInputGestureBindingHandle
{
	public IntPtr Address;

	public FInputBindingHandle Base => (FInputBindingHandle)Address;

	public float GestureValue
	{
		get
		{
			return Native_FInputGestureBinding.Get_GestureValue(Address);
		}
		set
		{
			Native_FInputGestureBinding.Set_GestureValue(Address, value);
		}
	}

	public FKey GestureKey
	{
		get
		{
			Native_FInputGestureBinding.Get_GestureKey(Address, out var result);
			return result;
		}
		set
		{
			Native_FInputGestureBinding.Set_GestureKey(Address, ref value);
		}
	}

	public FInputGestureUnifiedDelegateHandle GestureDelegate => (FInputGestureUnifiedDelegateHandle)Native_FInputGestureBinding.Get_GestureDelegate(Address);

	public FInputGestureBindingHandle(IntPtr address)
	{
		Address = address;
	}

	public static implicit operator IntPtr(FInputGestureBindingHandle handle)
	{
		return handle.Address;
	}

	public static explicit operator FInputGestureBindingHandle(IntPtr address)
	{
		return new FInputGestureBindingHandle(address);
	}
}
