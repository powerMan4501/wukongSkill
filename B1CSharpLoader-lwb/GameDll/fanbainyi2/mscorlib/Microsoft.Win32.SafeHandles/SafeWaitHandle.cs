using System;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical]
[__DynamicallyInvokable]
public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeWaitHandle()
		: base(ownsHandle: true)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public SafeWaitHandle(IntPtr existingHandle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(existingHandle);
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		return Win32Native.CloseHandle(handle);
	}
}
