using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using Microsoft.Win32;

namespace System.IO.Pipes;

internal class IOCancellationHelper
{
	private CancellationToken _cancellationToken;

	private CancellationTokenRegistration _cancellationRegistration;

	[SecurityCritical]
	private SafeHandle _handle;

	[SecurityCritical]
	private unsafe NativeOverlapped* _overlapped;

	public IOCancellationHelper(CancellationToken cancellationToken)
	{
		_cancellationToken = cancellationToken;
	}

	[SecurityCritical]
	public unsafe void AllowCancellation(SafeHandle handle, NativeOverlapped* overlapped)
	{
		if (_cancellationToken.CanBeCanceled)
		{
			_handle = handle;
			_overlapped = overlapped;
			if (_cancellationToken.IsCancellationRequested)
			{
				Cancel();
			}
			else
			{
				_cancellationRegistration = _cancellationToken.Register(Cancel);
			}
		}
	}

	[SecurityCritical]
	public unsafe void SetOperationCompleted()
	{
		if (_overlapped != null)
		{
			_cancellationRegistration.Dispose();
			_handle = null;
			_overlapped = null;
		}
	}

	public void ThrowIOOperationAborted()
	{
		_cancellationToken.ThrowIfCancellationRequested();
		__Error.OperationAborted();
	}

	[SecurityCritical]
	private unsafe void Cancel()
	{
		SafeHandle handle = _handle;
		NativeOverlapped* overlapped = _overlapped;
		if (handle != null && !handle.IsInvalid && overlapped != null)
		{
			if (!Microsoft.Win32.UnsafeNativeMethods.CancelIoEx(handle, overlapped))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
			}
			SetOperationCompleted();
		}
	}
}
