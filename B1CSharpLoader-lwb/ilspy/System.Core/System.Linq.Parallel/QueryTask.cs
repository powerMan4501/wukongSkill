using System.Threading;
using System.Threading.Tasks;

namespace System.Linq.Parallel;

internal abstract class QueryTask
{
	protected int m_taskIndex;

	protected QueryTaskGroupState m_groupState;

	private static Action<object> s_runTaskSynchronouslyDelegate = RunTaskSynchronously;

	private static Action<object> s_baseWorkDelegate = delegate(object o)
	{
		((QueryTask)o).BaseWork(null);
	};

	protected QueryTask(int taskIndex, QueryTaskGroupState groupState)
	{
		m_taskIndex = taskIndex;
		m_groupState = groupState;
	}

	private static void RunTaskSynchronously(object o)
	{
		((QueryTask)o).BaseWork(null);
	}

	internal Task RunSynchronously(TaskScheduler taskScheduler)
	{
		Task task = new Task(s_runTaskSynchronouslyDelegate, this, TaskCreationOptions.AttachedToParent);
		task.RunSynchronously(taskScheduler);
		return task;
	}

	internal Task RunAsynchronously(TaskScheduler taskScheduler)
	{
		return Task.Factory.StartNew(s_baseWorkDelegate, this, default(CancellationToken), TaskCreationOptions.PreferFairness | TaskCreationOptions.AttachedToParent, taskScheduler);
	}

	private void BaseWork(object unused)
	{
		PlinqEtwProvider.Log.ParallelQueryFork(m_groupState.QueryId);
		try
		{
			Work();
		}
		finally
		{
			PlinqEtwProvider.Log.ParallelQueryJoin(m_groupState.QueryId);
		}
	}

	protected abstract void Work();
}
