using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeCloseHandle : CriticalHandleZeroOrMinusOneIsInvalid
{
	private int _disposed;

	private SafeCloseHandle()
	{
	}

	internal IntPtr DangerousGetHandle()
	{
		return handle;
	}

	protected override bool ReleaseHandle()
	{
		if (!IsInvalid && Interlocked.Increment(ref _disposed) == 1)
		{
			return UnsafeNclNativeMethods.SafeNetHandles.CloseHandle(handle);
		}
		return true;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal void Abort()
	{
		ReleaseHandle();
		SetHandleAsInvalid();
	}
}
