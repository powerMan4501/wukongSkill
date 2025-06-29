using System;

namespace UnrealEngine.Engine;

public struct FInputAxisUnifiedDelegateHandle
{
	public IntPtr Address;

	public FInputAxisUnifiedDelegateHandle(IntPtr address)
	{
		Address = address;
	}

	public static implicit operator IntPtr(FInputAxisUnifiedDelegateHandle handle)
	{
		return handle.Address;
	}

	public static explicit operator FInputAxisUnifiedDelegateHandle(IntPtr address)
	{
		return new FInputAxisUnifiedDelegateHandle(address);
	}
}
