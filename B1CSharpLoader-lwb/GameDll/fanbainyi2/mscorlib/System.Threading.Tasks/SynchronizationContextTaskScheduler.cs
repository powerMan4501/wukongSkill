using System.Collections.Generic;
using System.Security;

namespace System.Threading.Tasks;

internal sealed class SynchronizationContextTaskScheduler : TaskScheduler
{
	private SynchronizationContext m_synchronizationContext;

	private static SendOrPostCallback s_postCallback = PostCallback;

	public override int MaximumConcurrencyLevel => 1;

	internal SynchronizationContextTaskScheduler()
	{
		SynchronizationContext current = SynchronizationContext.Current;
		if (current == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("TaskScheduler_FromCurrentSynchronizationContext_NoCurrent"));
		}
		m_synchronizationContext = current;
	}

	[SecurityCritical]
	protected internal override void QueueTask(Task task)
	{
		m_synchronizationContext.Post(s_postCallback, task);
	}

	[SecurityCritical]
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
	{
		if (SynchronizationContext.Current == m_synchronizationContext)
		{
			return TryExecuteTask(task);
		}
		return false;
	}

	[SecurityCritical]
	protected override IEnumerable<Task> GetScheduledTasks()
	{
		return null;
	}

	private static void PostCallback(object obj)
	{
		Task task = (Task)obj;
		task.ExecuteEntry(bPreventDoubleExecution: true);
	}
}
