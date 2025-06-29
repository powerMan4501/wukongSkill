using System.Security;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class HttpRequestQueueV2Handle : CriticalHandleZeroOrMinusOneIsInvalid
{
	private int disposed;

	private HttpRequestQueueV2Handle()
	{
	}

	internal IntPtr DangerousGetHandle()
	{
		return handle;
	}

	protected override bool ReleaseHandle()
	{
		if (!IsInvalid && Interlocked.Increment(ref disposed) == 1)
		{
			return UnsafeNclNativeMethods.SafeNetHandles.HttpCloseRequestQueue(handle) == 0;
		}
		return true;
	}
}
