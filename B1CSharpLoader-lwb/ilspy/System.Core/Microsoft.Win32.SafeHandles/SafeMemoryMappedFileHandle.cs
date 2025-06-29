using System;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
public sealed class SafeMemoryMappedFileHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal SafeMemoryMappedFileHandle()
		: base(ownsHandle: true)
	{
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal SafeMemoryMappedFileHandle(IntPtr handle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(handle);
	}

	protected override bool ReleaseHandle()
	{
		return Microsoft.Win32.UnsafeNativeMethods.CloseHandle(handle);
	}
}
