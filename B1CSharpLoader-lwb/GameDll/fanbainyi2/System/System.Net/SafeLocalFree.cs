using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeLocalFree : SafeHandleZeroOrMinusOneIsInvalid
{
	private const int LMEM_FIXED = 0;

	private const int NULL = 0;

	public static SafeLocalFree Zero = new SafeLocalFree(ownsHandle: false);

	private SafeLocalFree()
		: base(ownsHandle: true)
	{
	}

	private SafeLocalFree(bool ownsHandle)
		: base(ownsHandle)
	{
	}

	public static SafeLocalFree LocalAlloc(int cb)
	{
		SafeLocalFree safeLocalFree = UnsafeNclNativeMethods.SafeNetHandles.LocalAlloc(0, (UIntPtr)(ulong)cb);
		if (safeLocalFree.IsInvalid)
		{
			safeLocalFree.SetHandleAsInvalid();
			throw new OutOfMemoryException();
		}
		return safeLocalFree;
	}

	protected override bool ReleaseHandle()
	{
		return UnsafeNclNativeMethods.SafeNetHandles.LocalFree(handle) == IntPtr.Zero;
	}
}
