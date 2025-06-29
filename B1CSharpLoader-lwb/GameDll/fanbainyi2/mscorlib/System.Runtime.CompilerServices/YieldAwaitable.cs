using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[__DynamicallyInvokable]
public struct YieldAwaitable
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public struct YieldAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private static readonly WaitCallback s_waitCallbackRunAction = RunAction;

		private static readonly SendOrPostCallback s_sendOrPostCallbackRunAction = RunAction;

		[__DynamicallyInvokable]
		public bool IsCompleted
		{
			[__DynamicallyInvokable]
			get
			{
				return false;
			}
		}

		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		public void OnCompleted(Action continuation)
		{
			QueueContinuation(continuation, flowContext: true);
		}

		[SecurityCritical]
		[__DynamicallyInvokable]
		public void UnsafeOnCompleted(Action continuation)
		{
			QueueContinuation(continuation, flowContext: false);
		}

		[SecurityCritical]
		private static void QueueContinuation(Action continuation, bool flowContext)
		{
			if (continuation == null)
			{
				throw new ArgumentNullException("continuation");
			}
			if (TplEtwProvider.Log.IsEnabled())
			{
				continuation = OutputCorrelationEtwEvent(continuation);
			}
			SynchronizationContext currentNoFlow = SynchronizationContext.CurrentNoFlow;
			if (currentNoFlow != null && currentNoFlow.GetType() != typeof(SynchronizationContext))
			{
				currentNoFlow.Post(s_sendOrPostCallbackRunAction, continuation);
				return;
			}
			TaskScheduler current = TaskScheduler.Current;
			if (current == TaskScheduler.Default)
			{
				if (flowContext)
				{
					ThreadPool.QueueUserWorkItem(s_waitCallbackRunAction, continuation);
				}
				else
				{
					ThreadPool.UnsafeQueueUserWorkItem(s_waitCallbackRunAction, continuation);
				}
			}
			else
			{
				Task.Factory.StartNew(continuation, default(CancellationToken), TaskCreationOptions.PreferFairness, current);
			}
		}

		private static Action OutputCorrelationEtwEvent(Action continuation)
		{
			int continuationId = Task.NewId();
			Task internalCurrent = Task.InternalCurrent;
			TplEtwProvider.Log.AwaitTaskContinuationScheduled(TaskScheduler.Current.Id, internalCurrent?.Id ?? 0, continuationId);
			return AsyncMethodBuilderCore.CreateContinuationWrapper(continuation, delegate
			{
				TplEtwProvider log = TplEtwProvider.Log;
				log.TaskWaitContinuationStarted(continuationId);
				Guid oldActivityThatWillContinue = default(Guid);
				if (log.TasksSetActivityIds)
				{
					EventSource.SetCurrentThreadActivityId(TplEtwProvider.CreateGuidForTaskID(continuationId), out oldActivityThatWillContinue);
				}
				continuation();
				if (log.TasksSetActivityIds)
				{
					EventSource.SetCurrentThreadActivityId(oldActivityThatWillContinue);
				}
				log.TaskWaitContinuationComplete(continuationId);
			});
		}

		private static void RunAction(object state)
		{
			((Action)state)();
		}

		[__DynamicallyInvokable]
		public void GetResult()
		{
		}
	}

	[__DynamicallyInvokable]
	public YieldAwaiter GetAwaiter()
	{
		return default(YieldAwaiter);
	}
}
