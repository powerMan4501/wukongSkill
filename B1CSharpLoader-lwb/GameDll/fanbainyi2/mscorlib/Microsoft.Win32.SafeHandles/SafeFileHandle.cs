using System;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical]
public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeFileHandle()
		: base(ownsHandle: true)
	{
	}

	public SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(preexistingHandle);
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		return Win32Native.CloseHandle(handle);
	}
}
