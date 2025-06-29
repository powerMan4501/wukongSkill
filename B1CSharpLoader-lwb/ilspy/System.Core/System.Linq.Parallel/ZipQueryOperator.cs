using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class ZipQueryOperator<TLeftInput, TRightInput, TOutput> : QueryOperator<TOutput>
{
	internal class ZipQueryOperatorResults : QueryResults<TOutput>
	{
		private readonly QueryResults<TLeftInput> m_leftChildResults;

		private readonly QueryResults<TRightInput> m_rightChildResults;

		private readonly Func<TLeftInput, TRightInput, TOutput> m_resultSelector;

		private readonly int m_count;

		private readonly int m_partitionCount;

		private readonly bool m_preferStriping;

		internal override int ElementsCount => m_count;

		internal override bool IsIndexible => true;

		internal ZipQueryOperatorResults(QueryResults<TLeftInput> leftChildResults, QueryResults<TRightInput> rightChildResults, Func<TLeftInput, TRightInput, TOutput> resultSelector, int partitionCount, bool preferStriping)
		{
			m_leftChildResults = leftChildResults;
			m_rightChildResults = rightChildResults;
			m_resultSelector = resultSelector;
			m_partitionCount = partitionCount;
			m_preferStriping = preferStriping;
			m_count = Math.Min(m_leftChildResults.Count, m_rightChildResults.Count);
		}

		internal override TOutput GetElement(int index)
		{
			return m_resultSelector(m_leftChildResults.GetElement(index), m_rightChildResults.GetElement(index));
		}

		internal override void GivePartitionedStream(IPartitionedStreamRecipient<TOutput> recipient)
		{
			PartitionedStream<TOutput, int> partitionedStream = ExchangeUtilities.PartitionDataSource(this, m_partitionCount, m_preferStriping);
			recipient.Receive(partitionedStream);
		}
	}

	private readonly Func<TLeftInput, TRightInput, TOutput> m_resultSelector;

	private readonly QueryOperator<TLeftInput> m_leftChild;

	private readonly QueryOperator<TRightInput> m_rightChild;

	private readonly bool m_prematureMergeLeft;

	private readonly bool m_prematureMergeRight;

	private readonly bool m_limitsParallelism;

	internal override OrdinalIndexState OrdinalIndexState => OrdinalIndexState.Indexible;

	internal override bool LimitsParallelism => m_limitsParallelism;

	internal ZipQueryOperator(ParallelQuery<TLeftInput> leftChildSource, IEnumerable<TRightInput> rightChildSource, Func<TLeftInput, TRightInput, TOutput> resultSelector)
		: this(QueryOperator<TLeftInput>.AsQueryOperator(leftChildSource), QueryOperator<TRightInput>.AsQueryOperator(rightChildSource), resultSelector)
	{
	}

	private ZipQueryOperator(QueryOperator<TLeftInput> left, QueryOperator<TRightInput> right, Func<TLeftInput, TRightInput, TOutput> resultSelector)
		: base(left.SpecifiedQuerySettings.Merge(right.SpecifiedQuerySettings))
	{
		m_leftChild = left;
		m_rightChild = right;
		m_resultSelector = resultSelector;
		m_outputOrdered = m_leftChild.OutputOrdered || m_rightChild.OutputOrdered;
		OrdinalIndexState ordinalIndexState = m_leftChild.OrdinalIndexState;
		OrdinalIndexState ordinalIndexState2 = m_rightChild.OrdinalIndexState;
		m_prematureMergeLeft = ordinalIndexState != OrdinalIndexState.Indexible;
		m_prematureMergeRight = ordinalIndexState2 != OrdinalIndexState.Indexible;
		m_limitsParallelism = (m_prematureMergeLeft && ordinalIndexState != OrdinalIndexState.Shuffled) || (m_prematureMergeRight && ordinalIndexState2 != OrdinalIndexState.Shuffled);
	}

	internal override QueryResults<TOutput> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TLeftInput> queryResults = m_leftChild.Open(settings, preferStriping);
		QueryResults<TRightInput> queryResults2 = m_rightChild.Open(settings, preferStriping);
		int value = settings.DegreeOfParallelism.Value;
		if (m_prematureMergeLeft)
		{
			PartitionedStreamMerger<TLeftInput> partitionedStreamMerger = new PartitionedStreamMerger<TLeftInput>(forEffectMerge: false, ParallelMergeOptions.FullyBuffered, settings.TaskScheduler, m_leftChild.OutputOrdered, settings.CancellationState, settings.QueryId);
			queryResults.GivePartitionedStream(partitionedStreamMerger);
			queryResults = new ListQueryResults<TLeftInput>(partitionedStreamMerger.MergeExecutor.GetResultsAsArray(), value, preferStriping);
		}
		if (m_prematureMergeRight)
		{
			PartitionedStreamMerger<TRightInput> partitionedStreamMerger2 = new PartitionedStreamMerger<TRightInput>(forEffectMerge: false, ParallelMergeOptions.FullyBuffered, settings.TaskScheduler, m_rightChild.OutputOrdered, settings.CancellationState, settings.QueryId);
			queryResults2.GivePartitionedStream(partitionedStreamMerger2);
			queryResults2 = new ListQueryResults<TRightInput>(partitionedStreamMerger2.MergeExecutor.GetResultsAsArray(), value, preferStriping);
		}
		return new ZipQueryOperatorResults(queryResults, queryResults2, m_resultSelector, value, preferStriping);
	}

	internal override IEnumerable<TOutput> AsSequentialQuery(CancellationToken token)
	{
		using IEnumerator<TLeftInput> leftEnumerator = m_leftChild.AsSequentialQuery(token).GetEnumerator();
		using IEnumerator<TRightInput> rightEnumerator = m_rightChild.AsSequentialQuery(token).GetEnumerator();
		while (leftEnumerator.MoveNext() && rightEnumerator.MoveNext())
		{
			yield return m_resultSelector(leftEnumerator.Current, rightEnumerator.Current);
		}
	}
}
