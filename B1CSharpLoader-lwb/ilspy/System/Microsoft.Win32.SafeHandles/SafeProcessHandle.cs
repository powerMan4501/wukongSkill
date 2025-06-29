using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace Microsoft.Win32.SafeHandles;

[SuppressUnmanagedCodeSecurity]
public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeProcessHandle InvalidHandle = new SafeProcessHandle(IntPtr.Zero);

	internal SafeProcessHandle()
		: base(ownsHandle: true)
	{
	}

	internal SafeProcessHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	public SafeProcessHandle(IntPtr existingHandle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(existingHandle);
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern SafeProcessHandle OpenProcess(int access, bool inherit, int processId);

	internal void InitialSetHandle(IntPtr h)
	{
		handle = h;
	}

	protected override bool ReleaseHandle()
	{
		return Microsoft.Win32.SafeNativeMethods.CloseHandle(handle);
	}
}
