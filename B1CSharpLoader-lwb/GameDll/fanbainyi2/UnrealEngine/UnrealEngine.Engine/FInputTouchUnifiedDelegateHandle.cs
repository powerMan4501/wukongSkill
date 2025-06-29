using System;

namespace UnrealEngine.Engine;

public struct FInputTouchUnifiedDelegateHandle
{
	public IntPtr Address;

	public FInputTouchUnifiedDelegateHandle(IntPtr address)
	{
		Address = address;
	}

	public static implicit operator IntPtr(FInputTouchUnifiedDelegateHandle handle)
	{
		return handle.Address;
	}

	public static explicit operator FInputTouchUnifiedDelegateHandle(IntPtr address)
	{
		return new FInputTouchUnifiedDelegateHandle(address);
	}
}
