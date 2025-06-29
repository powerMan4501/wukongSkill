using System.Security;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class HttpServerSessionHandle : CriticalHandleZeroOrMinusOneIsInvalid
{
	private int disposed;

	private ulong serverSessionId;

	internal HttpServerSessionHandle(ulong id)
	{
		serverSessionId = id;
		SetHandle(new IntPtr(1));
	}

	internal ulong DangerousGetServerSessionId()
	{
		return serverSessionId;
	}

	protected override bool ReleaseHandle()
	{
		if (!IsInvalid && Interlocked.Increment(ref disposed) == 1)
		{
			return UnsafeNclNativeMethods.HttpApi.HttpCloseServerSession(serverSessionId) == 0;
		}
		return true;
	}
}
