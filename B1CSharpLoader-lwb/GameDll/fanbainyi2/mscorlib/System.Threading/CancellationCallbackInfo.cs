using System.Security;

namespace System.Threading;

internal class CancellationCallbackInfo
{
	internal readonly Action<object> Callback;

	internal readonly object StateForCallback;

	internal readonly SynchronizationContext TargetSyncContext;

	internal readonly ExecutionContext TargetExecutionContext;

	internal readonly CancellationTokenSource CancellationTokenSource;

	[SecurityCritical]
	private static ContextCallback s_executionContextCallback;

	internal CancellationCallbackInfo(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource)
	{
		Callback = callback;
		StateForCallback = stateForCallback;
		TargetSyncContext = targetSyncContext;
		TargetExecutionContext = targetExecutionContext;
		CancellationTokenSource = cancellationTokenSource;
	}

	[SecuritySafeCritical]
	internal void ExecuteCallback()
	{
		if (TargetExecutionContext != null)
		{
			ContextCallback callback = ExecutionContextCallback;
			ExecutionContext.Run(TargetExecutionContext, callback, this);
		}
		else
		{
			ExecutionContextCallback(this);
		}
	}

	[SecurityCritical]
	private static void ExecutionContextCallback(object obj)
	{
		CancellationCallbackInfo cancellationCallbackInfo = obj as CancellationCallbackInfo;
		cancellationCallbackInfo.Callback(cancellationCallbackInfo.StateForCallback);
	}
}
