using System;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical]
internal sealed class SafeFileMappingHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	[SecurityCritical]
	internal SafeFileMappingHandle()
		: base(ownsHandle: true)
	{
	}

	[SecurityCritical]
	internal SafeFileMappingHandle(IntPtr handle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(handle);
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		return Win32Native.CloseHandle(handle);
	}
}
