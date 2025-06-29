using System.Runtime.CompilerServices;

namespace System.Threading.Tasks;

internal class ParallelForReplicatingTask : Task
{
	private int m_replicationDownCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ParallelForReplicatingTask(ParallelOptions parallelOptions, Action action, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		: base(action, null, Task.InternalCurrent, default(CancellationToken), creationOptions, internalOptions | InternalTaskOptions.SelfReplicating, null)
	{
		m_replicationDownCount = parallelOptions.EffectiveMaxConcurrencyLevel;
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		PossiblyCaptureContext(ref stackMark);
	}

	internal override bool ShouldReplicate()
	{
		if (m_replicationDownCount == -1)
		{
			return true;
		}
		if (m_replicationDownCount > 0)
		{
			m_replicationDownCount--;
			return true;
		}
		return false;
	}

	internal override Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica)
	{
		return new ParallelForReplicaTask(taskReplicaDelegate, stateObject, parentTask, taskScheduler, creationOptionsForReplica, internalOptionsForReplica);
	}
}
