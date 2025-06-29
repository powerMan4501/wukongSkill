using System;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical]
internal sealed class SafeLsaLogonProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeLsaLogonProcessHandle InvalidHandle => new SafeLsaLogonProcessHandle(IntPtr.Zero);

	private SafeLsaLogonProcessHandle()
		: base(ownsHandle: true)
	{
	}

	internal SafeLsaLogonProcessHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		return Win32Native.LsaDeregisterLogonProcess(handle) >= 0;
	}
}
