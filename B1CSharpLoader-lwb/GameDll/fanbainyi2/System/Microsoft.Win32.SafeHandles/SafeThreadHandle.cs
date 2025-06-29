using System;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeThreadHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal SafeThreadHandle()
		: base(ownsHandle: true)
	{
	}

	internal void InitialSetHandle(IntPtr h)
	{
		SetHandle(h);
	}

	protected override bool ReleaseHandle()
	{
		return Microsoft.Win32.SafeNativeMethods.CloseHandle(handle);
	}
}
