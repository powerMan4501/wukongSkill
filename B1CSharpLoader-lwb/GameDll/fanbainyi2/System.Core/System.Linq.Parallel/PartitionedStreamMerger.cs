using System.Threading.Tasks;

namespace System.Linq.Parallel;

internal class PartitionedStreamMerger<TOutput> : IPartitionedStreamRecipient<TOutput>
{
	private bool m_forEffectMerge;

	private ParallelMergeOptions m_mergeOptions;

	private bool m_isOrdered;

	private MergeExecutor<TOutput> m_mergeExecutor;

	private TaskScheduler m_taskScheduler;

	private int m_queryId;

	private CancellationState m_cancellationState;

	internal MergeExecutor<TOutput> MergeExecutor => m_mergeExecutor;

	internal PartitionedStreamMerger(bool forEffectMerge, ParallelMergeOptions mergeOptions, TaskScheduler taskScheduler, bool outputOrdered, CancellationState cancellationState, int queryId)
	{
		m_forEffectMerge = forEffectMerge;
		m_mergeOptions = mergeOptions;
		m_isOrdered = outputOrdered;
		m_taskScheduler = taskScheduler;
		m_cancellationState = cancellationState;
		m_queryId = queryId;
	}

	public void Receive<TKey>(PartitionedStream<TOutput, TKey> partitionedStream)
	{
		m_mergeExecutor = MergeExecutor<TOutput>.Execute(partitionedStream, m_forEffectMerge, m_mergeOptions, m_taskScheduler, m_isOrdered, m_cancellationState, m_queryId);
	}
}
