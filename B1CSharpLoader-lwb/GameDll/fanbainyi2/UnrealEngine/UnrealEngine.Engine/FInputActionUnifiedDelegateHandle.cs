using System;

namespace UnrealEngine.Engine;

public struct FInputActionUnifiedDelegateHandle
{
	public IntPtr Address;

	public FInputActionUnifiedDelegateHandle(IntPtr address)
	{
		Address = address;
	}

	public static implicit operator IntPtr(FInputActionUnifiedDelegateHandle handle)
	{
		return handle.Address;
	}

	public static explicit operator FInputActionUnifiedDelegateHandle(IntPtr address)
	{
		return new FInputActionUnifiedDelegateHandle(address);
	}
}
