using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical]
internal sealed class SafeLocalAllocHandle : SafeBuffer
{
	internal static SafeLocalAllocHandle InvalidHandle => new SafeLocalAllocHandle(IntPtr.Zero);

	private SafeLocalAllocHandle()
		: base(ownsHandle: true)
	{
	}

	internal SafeLocalAllocHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		return Win32Native.LocalFree(handle) == IntPtr.Zero;
	}
}
