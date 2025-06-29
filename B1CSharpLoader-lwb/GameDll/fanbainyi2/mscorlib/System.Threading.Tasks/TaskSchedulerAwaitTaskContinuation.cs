using System.Security;

namespace System.Threading.Tasks;

internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
{
	private readonly TaskScheduler m_scheduler;

	[SecurityCritical]
	internal TaskSchedulerAwaitTaskContinuation(TaskScheduler scheduler, Action action, bool flowExecutionContext, ref StackCrawlMark stackMark)
		: base(action, flowExecutionContext, ref stackMark)
	{
		m_scheduler = scheduler;
	}

	internal sealed override void Run(Task ignored, bool canInlineContinuationTask)
	{
		if (m_scheduler == TaskScheduler.Default)
		{
			base.Run(ignored, canInlineContinuationTask);
			return;
		}
		bool flag = canInlineContinuationTask && (TaskScheduler.InternalCurrent == m_scheduler || Thread.CurrentThread.IsThreadPoolThread);
		Task task = CreateTask(delegate(object state)
		{
			try
			{
				((Action)state)();
			}
			catch (Exception exc)
			{
				AwaitTaskContinuation.ThrowAsyncIfNecessary(exc);
			}
		}, m_action, m_scheduler);
		if (flag)
		{
			TaskContinuation.InlineIfPossibleOrElseQueue(task, needsProtection: false);
			return;
		}
		try
		{
			task.ScheduleAndStart(needsProtection: false);
		}
		catch (TaskSchedulerException)
		{
		}
	}
}
