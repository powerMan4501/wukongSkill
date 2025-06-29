using System.Collections.ObjectModel;
using System.Diagnostics.Tracing;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly Task m_task;

	[__DynamicallyInvokable]
	public bool IsCompleted
	{
		[__DynamicallyInvokable]
		get
		{
			return m_task.IsCompleted;
		}
	}

	internal TaskAwaiter(Task task)
	{
		m_task = task;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public void OnCompleted(Action continuation)
	{
		OnCompletedInternal(m_task, continuation, continueOnCapturedContext: true, flowExecutionContext: true);
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public void UnsafeOnCompleted(Action continuation)
	{
		OnCompletedInternal(m_task, continuation, continueOnCapturedContext: true, flowExecutionContext: false);
	}

	[__DynamicallyInvokable]
	public void GetResult()
	{
		ValidateEnd(m_task);
	}

	internal static void ValidateEnd(Task task)
	{
		if (task.IsWaitNotificationEnabledOrNotRanToCompletion)
		{
			HandleNonSuccessAndDebuggerNotification(task);
		}
	}

	private static void HandleNonSuccessAndDebuggerNotification(Task task)
	{
		if (!task.IsCompleted)
		{
			bool flag = task.InternalWait(-1, default(CancellationToken));
		}
		task.NotifyDebuggerOfWaitCompletionIfNecessary();
		if (!task.IsRanToCompletion)
		{
			ThrowForNonSuccess(task);
		}
	}

	private static void ThrowForNonSuccess(Task task)
	{
		switch (task.Status)
		{
		case TaskStatus.Canceled:
			task.GetCancellationExceptionDispatchInfo()?.Throw();
			throw new TaskCanceledException(task);
		case TaskStatus.Faulted:
		{
			ReadOnlyCollection<ExceptionDispatchInfo> exceptionDispatchInfos = task.GetExceptionDispatchInfos();
			if (exceptionDispatchInfos.Count > 0)
			{
				exceptionDispatchInfos[0].Throw();
				break;
			}
			throw task.Exception;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext)
	{
		if (continuation == null)
		{
			throw new ArgumentNullException("continuation");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		if (TplEtwProvider.Log.IsEnabled() || Task.s_asyncDebuggingEnabled)
		{
			continuation = OutputWaitEtwEvents(task, continuation);
		}
		task.SetContinuationForAwait(continuation, continueOnCapturedContext, flowExecutionContext, ref stackMark);
	}

	private static Action OutputWaitEtwEvents(Task task, Action continuation)
	{
		if (Task.s_asyncDebuggingEnabled)
		{
			Task.AddToActiveTasks(task);
		}
		TplEtwProvider etwLog = TplEtwProvider.Log;
		if (etwLog.IsEnabled())
		{
			Task internalCurrent = Task.InternalCurrent;
			Task task2 = AsyncMethodBuilderCore.TryGetContinuationTask(continuation);
			etwLog.TaskWaitBegin(internalCurrent?.m_taskScheduler.Id ?? TaskScheduler.Default.Id, internalCurrent?.Id ?? 0, task.Id, TplEtwProvider.TaskWaitBehavior.Asynchronous, task2?.Id ?? 0, Thread.GetDomainID());
		}
		return AsyncMethodBuilderCore.CreateContinuationWrapper(continuation, delegate
		{
			if (Task.s_asyncDebuggingEnabled)
			{
				Task.RemoveFromActiveTasks(task.Id);
			}
			Guid oldActivityThatWillContinue = default(Guid);
			bool flag = etwLog.IsEnabled();
			if (flag)
			{
				Task internalCurrent2 = Task.InternalCurrent;
				etwLog.TaskWaitEnd(internalCurrent2?.m_taskScheduler.Id ?? TaskScheduler.Default.Id, internalCurrent2?.Id ?? 0, task.Id);
				if (etwLog.TasksSetActivityIds && (task.Options & (TaskCreationOptions)1024) != TaskCreationOptions.None)
				{
					EventSource.SetCurrentThreadActivityId(TplEtwProvider.CreateGuidForTaskID(task.Id), out oldActivityThatWillContinue);
				}
			}
			continuation();
			if (flag)
			{
				etwLog.TaskWaitContinuationComplete(task.Id);
				if (etwLog.TasksSetActivityIds && (task.Options & (TaskCreationOptions)1024) != TaskCreationOptions.None)
				{
					EventSource.SetCurrentThreadActivityId(oldActivityThatWillContinue);
				}
			}
		});
	}
}
[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public struct TaskAwaiter<TResult> : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly Task<TResult> m_task;

	[__DynamicallyInvokable]
	public bool IsCompleted
	{
		[__DynamicallyInvokable]
		get
		{
			return m_task.IsCompleted;
		}
	}

	internal TaskAwaiter(Task<TResult> task)
	{
		m_task = task;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public void OnCompleted(Action continuation)
	{
		TaskAwaiter.OnCompletedInternal(m_task, continuation, continueOnCapturedContext: true, flowExecutionContext: true);
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public void UnsafeOnCompleted(Action continuation)
	{
		TaskAwaiter.OnCompletedInternal(m_task, continuation, continueOnCapturedContext: true, flowExecutionContext: false);
	}

	[__DynamicallyInvokable]
	public TResult GetResult()
	{
		TaskAwaiter.ValidateEnd(m_task);
		return m_task.ResultOnSuccess;
	}
}
