using System.Threading;

namespace System.Net;

internal class AsyncProtocolRequest
{
	private AsyncProtocolCallback _Callback;

	private int _CompletionStatus;

	private const int StatusNotStarted = 0;

	private const int StatusCompleted = 1;

	private const int StatusCheckedOnSyncCompletion = 2;

	public LazyAsyncResult UserAsyncResult;

	public int Result;

	public object AsyncState;

	public byte[] Buffer;

	public int Offset;

	public int Count;

	internal object AsyncObject => UserAsyncResult.AsyncObject;

	public bool MustCompleteSynchronously
	{
		get
		{
			switch (Interlocked.Exchange(ref _CompletionStatus, 2))
			{
			case 2:
				throw new InternalException();
			case 1:
				_CompletionStatus = 0;
				return true;
			default:
				return false;
			}
		}
	}

	internal bool IsUserCompleted => UserAsyncResult.InternalPeekCompleted;

	public AsyncProtocolRequest(LazyAsyncResult userAsyncResult)
	{
		UserAsyncResult = userAsyncResult;
	}

	public void SetNextRequest(byte[] buffer, int offset, int count, AsyncProtocolCallback callback)
	{
		if (_CompletionStatus != 0)
		{
			throw new InternalException();
		}
		Buffer = buffer;
		Offset = offset;
		Count = count;
		_Callback = callback;
	}

	internal void CompleteRequest(int result)
	{
		Result = result;
		switch (Interlocked.Exchange(ref _CompletionStatus, 1))
		{
		case 1:
			throw new InternalException();
		case 2:
			_CompletionStatus = 0;
			_Callback(this);
			break;
		}
	}

	internal void CompleteWithError(Exception e)
	{
		UserAsyncResult.InvokeCallback(e);
	}

	internal void CompleteUser()
	{
		UserAsyncResult.InvokeCallback();
	}

	internal void CompleteUser(object userResult)
	{
		UserAsyncResult.InvokeCallback(userResult);
	}
}
