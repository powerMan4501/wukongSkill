using System.Collections.Generic;
using System.Threading.Tasks;

namespace System.Linq.Parallel;

internal class OrderPreservingMergeHelper<TInputOutput, TKey> : IMergeHelper<TInputOutput>
{
	private QueryTaskGroupState m_taskGroupState;

	private PartitionedStream<TInputOutput, TKey> m_partitions;

	private Shared<TInputOutput[]> m_results;

	private TaskScheduler m_taskScheduler;

	internal OrderPreservingMergeHelper(PartitionedStream<TInputOutput, TKey> partitions, TaskScheduler taskScheduler, CancellationState cancellationState, int queryId)
	{
		m_taskGroupState = new QueryTaskGroupState(cancellationState, queryId);
		m_partitions = partitions;
		m_results = new Shared<TInputOutput[]>(null);
		m_taskScheduler = taskScheduler;
	}

	void IMergeHelper<TInputOutput>.Execute()
	{
		OrderPreservingSpoolingTask<TInputOutput, TKey>.Spool(m_taskGroupState, m_partitions, m_results, m_taskScheduler);
	}

	IEnumerator<TInputOutput> IMergeHelper<TInputOutput>.GetEnumerator()
	{
		return ((IEnumerable<TInputOutput>)m_results.Value).GetEnumerator();
	}

	public TInputOutput[] GetResultsAsArray()
	{
		return m_results.Value;
	}
}
