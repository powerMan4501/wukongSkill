using System.Security;
using System.Security.Authentication.ExtendedProtection;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal class SafeLocalFreeChannelBinding : ChannelBinding
{
	private const int LMEM_FIXED = 0;

	private int size;

	public override int Size => size;

	public static SafeLocalFreeChannelBinding LocalAlloc(int cb)
	{
		SafeLocalFreeChannelBinding safeLocalFreeChannelBinding = UnsafeNclNativeMethods.SafeNetHandles.LocalAllocChannelBinding(0, (UIntPtr)(ulong)cb);
		if (safeLocalFreeChannelBinding.IsInvalid)
		{
			safeLocalFreeChannelBinding.SetHandleAsInvalid();
			throw new OutOfMemoryException();
		}
		safeLocalFreeChannelBinding.size = cb;
		return safeLocalFreeChannelBinding;
	}

	protected override bool ReleaseHandle()
	{
		return UnsafeNclNativeMethods.SafeNetHandles.LocalFree(handle) == IntPtr.Zero;
	}
}
