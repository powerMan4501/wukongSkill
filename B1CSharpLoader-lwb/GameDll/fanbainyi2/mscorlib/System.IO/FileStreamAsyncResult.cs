using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO;

internal sealed class FileStreamAsyncResult : IAsyncResult
{
	private AsyncCallback _userCallback;

	private object _userStateObject;

	private ManualResetEvent _waitHandle;

	[SecurityCritical]
	private SafeFileHandle _handle;

	[SecurityCritical]
	private unsafe NativeOverlapped* _overlapped;

	internal int _EndXxxCalled;

	private int _numBytes;

	private int _errorCode;

	private int _numBufferedBytes;

	private bool _isWrite;

	private bool _isComplete;

	private bool _completedSynchronously;

	[SecurityCritical]
	private static IOCompletionCallback s_IOCallback;

	internal unsafe NativeOverlapped* OverLapped
	{
		[SecurityCritical]
		get
		{
			return _overlapped;
		}
	}

	internal unsafe bool IsAsync
	{
		[SecuritySafeCritical]
		get
		{
			return _overlapped != null;
		}
	}

	internal int NumBytes => _numBytes;

	internal int ErrorCode => _errorCode;

	internal int NumBufferedBytes => _numBufferedBytes;

	internal int NumBytesRead => _numBytes + _numBufferedBytes;

	internal bool IsWrite => _isWrite;

	public object AsyncState => _userStateObject;

	public bool IsCompleted => _isComplete;

	public unsafe WaitHandle AsyncWaitHandle
	{
		[SecuritySafeCritical]
		get
		{
			if (_waitHandle == null)
			{
				ManualResetEvent manualResetEvent = new ManualResetEvent(initialState: false);
				if (_overlapped != null && _overlapped->EventHandle != IntPtr.Zero)
				{
					manualResetEvent.SafeWaitHandle = new SafeWaitHandle(_overlapped->EventHandle, ownsHandle: true);
				}
				if (Interlocked.CompareExchange(ref _waitHandle, manualResetEvent, null) == null)
				{
					if (_isComplete)
					{
						_waitHandle.Set();
					}
				}
				else
				{
					manualResetEvent.Close();
				}
			}
			return _waitHandle;
		}
	}

	public bool CompletedSynchronously => _completedSynchronously;

	[SecuritySafeCritical]
	internal unsafe FileStreamAsyncResult(int numBufferedBytes, byte[] bytes, SafeFileHandle handle, AsyncCallback userCallback, object userStateObject, bool isWrite)
	{
		_userCallback = userCallback;
		_userStateObject = userStateObject;
		_isWrite = isWrite;
		_numBufferedBytes = numBufferedBytes;
		_handle = handle;
		ManualResetEvent waitHandle = new ManualResetEvent(initialState: false);
		_waitHandle = waitHandle;
		Overlapped overlapped = new Overlapped(0, 0, IntPtr.Zero, this);
		if (userCallback != null)
		{
			IOCompletionCallback iocb = AsyncFSCallback;
			_overlapped = overlapped.Pack(iocb, bytes);
		}
		else
		{
			_overlapped = overlapped.UnsafePack(null, bytes);
		}
	}

	internal static FileStreamAsyncResult CreateBufferedReadResult(int numBufferedBytes, AsyncCallback userCallback, object userStateObject, bool isWrite)
	{
		FileStreamAsyncResult fileStreamAsyncResult = new FileStreamAsyncResult(numBufferedBytes, userCallback, userStateObject, isWrite);
		fileStreamAsyncResult.CallUserCallback();
		return fileStreamAsyncResult;
	}

	private FileStreamAsyncResult(int numBufferedBytes, AsyncCallback userCallback, object userStateObject, bool isWrite)
	{
		_userCallback = userCallback;
		_userStateObject = userStateObject;
		_isWrite = isWrite;
		_numBufferedBytes = numBufferedBytes;
	}

	private void CallUserCallbackWorker()
	{
		_isComplete = true;
		Thread.MemoryBarrier();
		if (_waitHandle != null)
		{
			_waitHandle.Set();
		}
		_userCallback(this);
	}

	internal void CallUserCallback()
	{
		if (_userCallback != null)
		{
			_completedSynchronously = false;
			ThreadPool.QueueUserWorkItem(delegate(object state)
			{
				((FileStreamAsyncResult)state).CallUserCallbackWorker();
			}, this);
			return;
		}
		_isComplete = true;
		Thread.MemoryBarrier();
		if (_waitHandle != null)
		{
			_waitHandle.Set();
		}
	}

	[SecurityCritical]
	internal unsafe void ReleaseNativeResource()
	{
		if (_overlapped != null)
		{
			Overlapped.Free(_overlapped);
		}
	}

	internal void Wait()
	{
		if (_waitHandle != null)
		{
			try
			{
				_waitHandle.WaitOne();
			}
			finally
			{
				_waitHandle.Close();
			}
		}
	}

	[SecurityCritical]
	private unsafe static void AsyncFSCallback(uint errorCode, uint numBytes, NativeOverlapped* pOverlapped)
	{
		Overlapped overlapped = Overlapped.Unpack(pOverlapped);
		FileStreamAsyncResult fileStreamAsyncResult = (FileStreamAsyncResult)overlapped.AsyncResult;
		fileStreamAsyncResult._numBytes = (int)numBytes;
		if (FrameworkEventSource.IsInitialized && FrameworkEventSource.Log.IsEnabled(EventLevel.Informational, (EventKeywords)16L))
		{
			FrameworkEventSource.Log.ThreadTransferReceive((long)fileStreamAsyncResult.OverLapped, 2, string.Empty);
		}
		if (errorCode == 109 || errorCode == 232)
		{
			errorCode = 0u;
		}
		fileStreamAsyncResult._errorCode = (int)errorCode;
		fileStreamAsyncResult._completedSynchronously = false;
		fileStreamAsyncResult._isComplete = true;
		Thread.MemoryBarrier();
		ManualResetEvent waitHandle = fileStreamAsyncResult._waitHandle;
		if (waitHandle != null && !waitHandle.Set())
		{
			__Error.WinIOError();
		}
		fileStreamAsyncResult._userCallback?.Invoke(fileStreamAsyncResult);
	}

	[SecuritySafeCritical]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	internal unsafe void Cancel()
	{
		if (!IsCompleted && !_handle.IsInvalid && !Win32Native.CancelIoEx(_handle, _overlapped))
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			if (lastWin32Error != 1168)
			{
				__Error.WinIOError(lastWin32Error, string.Empty);
			}
		}
	}
}
