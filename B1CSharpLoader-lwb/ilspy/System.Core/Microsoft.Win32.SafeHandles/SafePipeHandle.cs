using System;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class SafePipeHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafePipeHandle()
		: base(ownsHandle: true)
	{
	}

	public SafePipeHandle(IntPtr preexistingHandle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(preexistingHandle);
	}

	protected override bool ReleaseHandle()
	{
		return Microsoft.Win32.UnsafeNativeMethods.CloseHandle(handle);
	}
}
