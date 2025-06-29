using System;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical]
internal sealed class SafeLsaPolicyHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeLsaPolicyHandle InvalidHandle => new SafeLsaPolicyHandle(IntPtr.Zero);

	private SafeLsaPolicyHandle()
		: base(ownsHandle: true)
	{
	}

	internal SafeLsaPolicyHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		return Win32Native.LsaClose(handle) == 0;
	}
}
