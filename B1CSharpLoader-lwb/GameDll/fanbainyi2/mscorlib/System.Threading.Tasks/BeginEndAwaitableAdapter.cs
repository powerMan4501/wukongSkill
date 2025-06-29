using System.Runtime.CompilerServices;
using System.Security;

namespace System.Threading.Tasks;

internal sealed class BeginEndAwaitableAdapter : ICriticalNotifyCompletion, INotifyCompletion
{
	private static readonly Action CALLBACK_RAN = delegate
	{
	};

	private IAsyncResult _asyncResult;

	private Action _continuation;

	public static readonly AsyncCallback Callback = delegate(IAsyncResult asyncResult)
	{
		BeginEndAwaitableAdapter beginEndAwaitableAdapter = (BeginEndAwaitableAdapter)asyncResult.AsyncState;
		beginEndAwaitableAdapter._asyncResult = asyncResult;
		Interlocked.Exchange(ref beginEndAwaitableAdapter._continuation, CALLBACK_RAN)?.Invoke();
	};

	public bool IsCompleted => _continuation == CALLBACK_RAN;

	public BeginEndAwaitableAdapter GetAwaiter()
	{
		return this;
	}

	[SecurityCritical]
	public void UnsafeOnCompleted(Action continuation)
	{
		OnCompleted(continuation);
	}

	public void OnCompleted(Action continuation)
	{
		if (_continuation == CALLBACK_RAN || Interlocked.CompareExchange(ref _continuation, continuation, null) == CALLBACK_RAN)
		{
			Task.Run(continuation);
		}
	}

	public IAsyncResult GetResult()
	{
		IAsyncResult asyncResult = _asyncResult;
		_asyncResult = null;
		_continuation = null;
		return asyncResult;
	}
}
