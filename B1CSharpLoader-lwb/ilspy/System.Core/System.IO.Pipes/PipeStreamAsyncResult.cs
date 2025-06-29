using System.Security;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes;

internal sealed class PipeStreamAsyncResult : IAsyncResult
{
	internal AsyncCallback _userCallback;

	internal object _userStateObject;

	internal ManualResetEvent _waitHandle;

	[SecurityCritical]
	internal SafePipeHandle _handle;

	[SecurityCritical]
	internal unsafe NativeOverlapped* _overlapped;

	internal int _EndXxxCalled;

	internal int _numBytes;

	internal int _errorCode;

	internal bool _isMessageComplete;

	internal bool _isWrite;

	internal bool _isComplete;

	internal bool _completedSynchronously;

	public object AsyncState => _userStateObject;

	public bool IsCompleted => _isComplete;

	public unsafe WaitHandle AsyncWaitHandle
	{
		[SecurityCritical]
		get
		{
			if (_waitHandle == null)
			{
				ManualResetEvent manualResetEvent = new ManualResetEvent(initialState: false);
				if (_overlapped != null && _overlapped->EventHandle != IntPtr.Zero)
				{
					manualResetEvent.SafeWaitHandle = new SafeWaitHandle(_overlapped->EventHandle, ownsHandle: true);
				}
				if (_isComplete)
				{
					manualResetEvent.Set();
				}
				_waitHandle = manualResetEvent;
			}
			return _waitHandle;
		}
	}

	public bool CompletedSynchronously => _completedSynchronously;

	private void CallUserCallbackWorker(object callbackState)
	{
		_isComplete = true;
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
			ThreadPool.QueueUserWorkItem(CallUserCallbackWorker);
			return;
		}
		_isComplete = true;
		if (_waitHandle != null)
		{
			_waitHandle.Set();
		}
	}
}
