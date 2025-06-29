using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Threading.Tasks;

internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
{
	private static readonly SendOrPostCallback s_postCallback = delegate(object state)
	{
		((Action)state)();
	};

	[SecurityCritical]
	private static ContextCallback s_postActionCallback;

	private readonly SynchronizationContext m_syncContext;

	[SecurityCritical]
	internal SynchronizationContextAwaitTaskContinuation(SynchronizationContext context, Action action, bool flowExecutionContext, ref StackCrawlMark stackMark)
		: base(action, flowExecutionContext, ref stackMark)
	{
		m_syncContext = context;
	}

	[SecuritySafeCritical]
	internal sealed override void Run(Task task, bool canInlineContinuationTask)
	{
		if (canInlineContinuationTask && m_syncContext == SynchronizationContext.CurrentNoFlow)
		{
			RunCallback(AwaitTaskContinuation.GetInvokeActionCallback(), m_action, ref Task.t_currentTask);
			return;
		}
		TplEtwProvider log = TplEtwProvider.Log;
		if (log.IsEnabled())
		{
			m_continuationId = Task.NewId();
			log.AwaitTaskContinuationScheduled((task.ExecutingTaskScheduler ?? TaskScheduler.Default).Id, task.Id, m_continuationId);
		}
		RunCallback(GetPostActionCallback(), this, ref Task.t_currentTask);
	}

	[SecurityCritical]
	private static void PostAction(object state)
	{
		SynchronizationContextAwaitTaskContinuation synchronizationContextAwaitTaskContinuation = (SynchronizationContextAwaitTaskContinuation)state;
		TplEtwProvider log = TplEtwProvider.Log;
		if (log.TasksSetActivityIds && synchronizationContextAwaitTaskContinuation.m_continuationId != 0)
		{
			synchronizationContextAwaitTaskContinuation.m_syncContext.Post(s_postCallback, GetActionLogDelegate(synchronizationContextAwaitTaskContinuation.m_continuationId, synchronizationContextAwaitTaskContinuation.m_action));
		}
		else
		{
			synchronizationContextAwaitTaskContinuation.m_syncContext.Post(s_postCallback, synchronizationContextAwaitTaskContinuation.m_action);
		}
	}

	private static Action GetActionLogDelegate(int continuationId, Action action)
	{
		return delegate
		{
			Guid activityId = TplEtwProvider.CreateGuidForTaskID(continuationId);
			EventSource.SetCurrentThreadActivityId(activityId, out var oldActivityThatWillContinue);
			try
			{
				action();
			}
			finally
			{
				EventSource.SetCurrentThreadActivityId(oldActivityThatWillContinue);
			}
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecurityCritical]
	private static ContextCallback GetPostActionCallback()
	{
		return PostAction;
	}
}
