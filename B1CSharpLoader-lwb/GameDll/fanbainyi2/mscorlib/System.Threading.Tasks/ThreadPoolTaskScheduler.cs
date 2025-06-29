using System.Collections.Generic;
using System.Security;

namespace System.Threading.Tasks;

internal sealed class ThreadPoolTaskScheduler : TaskScheduler
{
	private static readonly ParameterizedThreadStart s_longRunningThreadWork = LongRunningThreadWork;

	internal override bool RequiresAtomicStartTransition => false;

	internal ThreadPoolTaskScheduler()
	{
		int id = base.Id;
	}

	private static void LongRunningThreadWork(object obj)
	{
		Task task = obj as Task;
		task.ExecuteEntry(bPreventDoubleExecution: false);
	}

	[SecurityCritical]
	protected internal override void QueueTask(Task task)
	{
		if ((task.Options & TaskCreationOptions.LongRunning) != TaskCreationOptions.None)
		{
			Thread thread = new Thread(s_longRunningThreadWork);
			thread.IsBackground = true;
			thread.Start(task);
		}
		else
		{
			bool forceGlobal = (task.Options & TaskCreationOptions.PreferFairness) != 0;
			ThreadPool.UnsafeQueueCustomWorkItem(task, forceGlobal);
		}
	}

	[SecurityCritical]
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
	{
		if (taskWasPreviouslyQueued && !ThreadPool.TryPopCustomWorkItem(task))
		{
			return false;
		}
		bool flag = false;
		try
		{
			return task.ExecuteEntry(bPreventDoubleExecution: false);
		}
		finally
		{
			if (taskWasPreviouslyQueued)
			{
				NotifyWorkItemProgress();
			}
		}
	}

	[SecurityCritical]
	protected internal override bool TryDequeue(Task task)
	{
		return ThreadPool.TryPopCustomWorkItem(task);
	}

	[SecurityCritical]
	protected override IEnumerable<Task> GetScheduledTasks()
	{
		return FilterTasksFromWorkItems(ThreadPool.GetQueuedWorkItems());
	}

	private IEnumerable<Task> FilterTasksFromWorkItems(IEnumerable<IThreadPoolWorkItem> tpwItems)
	{
		foreach (IThreadPoolWorkItem tpwItem in tpwItems)
		{
			if (tpwItem is Task)
			{
				yield return (Task)tpwItem;
			}
		}
	}

	internal override void NotifyWorkItemProgress()
	{
		ThreadPool.NotifyWorkItemProgress();
	}
}
