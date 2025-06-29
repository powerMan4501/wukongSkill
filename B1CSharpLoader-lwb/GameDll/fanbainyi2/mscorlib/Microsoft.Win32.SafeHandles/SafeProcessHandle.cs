using System;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical]
internal sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeProcessHandle InvalidHandle => new SafeProcessHandle(IntPtr.Zero);

	private SafeProcessHandle()
		: base(ownsHandle: true)
	{
	}

	internal SafeProcessHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		return Win32Native.CloseHandle(handle);
	}
}
