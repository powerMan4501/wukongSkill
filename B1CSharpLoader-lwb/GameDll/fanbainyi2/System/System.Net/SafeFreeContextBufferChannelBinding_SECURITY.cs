using System.Security;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeFreeContextBufferChannelBinding_SECURITY : SafeFreeContextBufferChannelBinding
{
	protected override bool ReleaseHandle()
	{
		return UnsafeNclNativeMethods.SafeNetHandles_SECURITY.FreeContextBuffer(handle) == 0;
	}
}
