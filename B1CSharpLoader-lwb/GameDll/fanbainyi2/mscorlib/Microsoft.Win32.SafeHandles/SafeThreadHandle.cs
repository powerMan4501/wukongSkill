using System;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical]
internal sealed class SafeThreadHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeThreadHandle()
		: base(ownsHandle: true)
	{
	}

	internal SafeThreadHandle(IntPtr handle)
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
