using System.Threading.Tasks;

namespace System.Linq.Parallel;

internal class OrderPreservingSpoolingTask<TInputOutput, TKey> : SpoolingTaskBase
{
	private Shared<TInputOutput[]> m_results;

	private SortHelper<TInputOutput> m_sortHelper;

	private OrderPreservingSpoolingTask(int taskIndex, QueryTaskGroupState groupState, Shared<TInputOutput[]> results, SortHelper<TInputOutput> sortHelper)
		: base(taskIndex, groupState)
	{
		m_results = results;
		m_sortHelper = sortHelper;
	}

	internal static void Spool(QueryTaskGroupState groupState, PartitionedStream<TInputOutput, TKey> partitions, Shared<TInputOutput[]> results, TaskScheduler taskScheduler)
	{
		int maxToRunInParallel = partitions.PartitionCount - 1;
		SortHelper<TInputOutput, TKey>[] sortHelpers = SortHelper<TInputOutput, TKey>.GenerateSortHelpers(partitions, groupState);
		Task task = new Task(delegate
		{
			for (int i = 0; i < maxToRunInParallel; i++)
			{
				QueryTask queryTask = new OrderPreservingSpoolingTask<TInputOutput, TKey>(i, groupState, results, sortHelpers[i]);
				queryTask.RunAsynchronously(taskScheduler);
			}
			QueryTask queryTask2 = new OrderPreservingSpoolingTask<TInputOutput, TKey>(maxToRunInParallel, groupState, results, sortHelpers[maxToRunInParallel]);
			queryTask2.RunSynchronously(taskScheduler);
		});
		groupState.QueryBegin(task);
		task.RunSynchronously(taskScheduler);
		for (int num = 0; num < sortHelpers.Length; num++)
		{
			sortHelpers[num].Dispose();
		}
		groupState.QueryEnd(userInitiatedDispose: false);
	}

	protected override void SpoolingWork()
	{
		TInputOutput[] value = m_sortHelper.Sort();
		if (!m_groupState.CancellationState.MergedCancellationToken.IsCancellationRequested && m_taskIndex == 0)
		{
			m_results.Value = value;
		}
	}
}
