namespace System.Threading.Tasks;

internal class ParallelForReplicaTask : Task
{
	internal object m_stateForNextReplica;

	internal object m_stateFromPreviousReplica;

	internal Task m_handedOverChildReplica;

	internal override object SavedStateForNextReplica
	{
		get
		{
			return m_stateForNextReplica;
		}
		set
		{
			m_stateForNextReplica = value;
		}
	}

	internal override object SavedStateFromPreviousReplica
	{
		get
		{
			return m_stateFromPreviousReplica;
		}
		set
		{
			m_stateFromPreviousReplica = value;
		}
	}

	internal override Task HandedOverChildReplica
	{
		get
		{
			return m_handedOverChildReplica;
		}
		set
		{
			m_handedOverChildReplica = value;
		}
	}

	internal ParallelForReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica)
		: base(taskReplicaDelegate, stateObject, parentTask, default(CancellationToken), creationOptionsForReplica, internalOptionsForReplica, taskScheduler)
	{
	}
}
