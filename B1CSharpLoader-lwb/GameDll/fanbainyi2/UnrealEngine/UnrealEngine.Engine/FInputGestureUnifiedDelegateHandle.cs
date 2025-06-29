using System;

namespace UnrealEngine.Engine;

public struct FInputGestureUnifiedDelegateHandle
{
	public IntPtr Address;

	public FInputGestureUnifiedDelegateHandle(IntPtr address)
	{
		Address = address;
	}

	public static implicit operator IntPtr(FInputGestureUnifiedDelegateHandle handle)
	{
		return handle.Address;
	}

	public static explicit operator FInputGestureUnifiedDelegateHandle(IntPtr address)
	{
		return new FInputGestureUnifiedDelegateHandle(address);
	}
}
