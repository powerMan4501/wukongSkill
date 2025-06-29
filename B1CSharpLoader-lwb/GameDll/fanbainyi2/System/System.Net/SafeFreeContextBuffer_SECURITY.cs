using System.Security;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeFreeContextBuffer_SECURITY : SafeFreeContextBuffer
{
	internal SafeFreeContextBuffer_SECURITY()
	{
	}

	protected override bool ReleaseHandle()
	{
		return UnsafeNclNativeMethods.SafeNetHandles_SECURITY.FreeContextBuffer(handle) == 0;
	}
}
