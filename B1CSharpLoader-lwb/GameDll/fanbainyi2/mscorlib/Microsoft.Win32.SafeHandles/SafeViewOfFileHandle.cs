using System;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical]
internal sealed class SafeViewOfFileHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	[SecurityCritical]
	internal SafeViewOfFileHandle()
		: base(ownsHandle: true)
	{
	}

	[SecurityCritical]
	internal SafeViewOfFileHandle(IntPtr handle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(handle);
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		if (Win32Native.UnmapViewOfFile(handle))
		{
			handle = IntPtr.Zero;
			return true;
		}
		return false;
	}
}
