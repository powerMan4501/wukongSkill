using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeGlobalFree : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeGlobalFree()
		: base(ownsHandle: true)
	{
	}

	private SafeGlobalFree(bool ownsHandle)
		: base(ownsHandle)
	{
	}

	protected override bool ReleaseHandle()
	{
		return UnsafeNclNativeMethods.SafeNetHandles.GlobalFree(handle) == IntPtr.Zero;
	}
}
