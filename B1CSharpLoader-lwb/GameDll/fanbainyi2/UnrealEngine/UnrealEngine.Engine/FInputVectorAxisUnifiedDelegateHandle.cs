using System;

namespace UnrealEngine.Engine;

public struct FInputVectorAxisUnifiedDelegateHandle
{
	public IntPtr Address;

	public FInputVectorAxisUnifiedDelegateHandle(IntPtr address)
	{
		Address = address;
	}

	public static implicit operator IntPtr(FInputVectorAxisUnifiedDelegateHandle handle)
	{
		return handle.Address;
	}

	public static explicit operator FInputVectorAxisUnifiedDelegateHandle(IntPtr address)
	{
		return new FInputVectorAxisUnifiedDelegateHandle(address);
	}
}
