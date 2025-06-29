using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
public sealed class SafeMemoryMappedViewHandle : SafeBuffer
{
	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal SafeMemoryMappedViewHandle()
		: base(ownsHandle: true)
	{
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal SafeMemoryMappedViewHandle(IntPtr handle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(handle);
	}

	protected override bool ReleaseHandle()
	{
		if (Microsoft.Win32.UnsafeNativeMethods.UnmapViewOfFile(handle))
		{
			handle = IntPtr.Zero;
			return true;
		}
		return false;
	}
}
