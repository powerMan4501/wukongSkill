namespace System.Threading.Tasks;

internal class StandardTaskContinuation : TaskContinuation
{
	internal readonly Task m_task;

	internal readonly TaskContinuationOptions m_options;

	private readonly TaskScheduler m_taskScheduler;

	internal StandardTaskContinuation(Task task, TaskContinuationOptions options, TaskScheduler scheduler)
	{
		m_task = task;
		m_options = options;
		m_taskScheduler = scheduler;
		if (AsyncCausalityTracer.LoggingOn)
		{
			AsyncCausalityTracer.TraceOperationCreation(CausalityTraceLevel.Required, m_task.Id, "Task.ContinueWith: " + ((Delegate)task.m_action).Method.Name, 0uL);
		}
		if (Task.s_asyncDebuggingEnabled)
		{
			Task.AddToActiveTasks(m_task);
		}
	}

	internal override void Run(Task completedTask, bool bCanInlineContinuationTask)
	{
		TaskContinuationOptions options = m_options;
		bool flag = (completedTask.IsRanToCompletion ? ((options & TaskContinuationOptions.NotOnRanToCompletion) == 0) : (completedTask.IsCanceled ? ((options & TaskContinuationOptions.NotOnCanceled) == 0) : ((options & TaskContinuationOptions.NotOnFaulted) == 0)));
		Task task = m_task;
		if (flag)
		{
			if (!task.IsCanceled && AsyncCausalityTracer.LoggingOn)
			{
				AsyncCausalityTracer.TraceOperationRelation(CausalityTraceLevel.Important, task.Id, CausalityRelation.AssignDelegate);
			}
			task.m_taskScheduler = m_taskScheduler;
			if (!bCanInlineContinuationTask || (options & TaskContinuationOptions.ExecuteSynchronously) == 0)
			{
				try
				{
					task.ScheduleAndStart(needsProtection: true);
					return;
				}
				catch (TaskSchedulerException)
				{
					return;
				}
			}
			TaskContinuation.InlineIfPossibleOrElseQueue(task, needsProtection: true);
		}
		else
		{
			task.InternalCancel(bCancelNonExecutingOnly: false);
		}
	}

	internal override Delegate[] GetDelegateContinuationsForDebugger()
	{
		if (m_task.m_action == null)
		{
			return m_task.GetDelegateContinuationsForDebugger();
		}
		return new Delegate[1] { m_task.m_action as Delegate };
	}
}
