using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class IndexedSelectQueryOperator<TInput, TOutput> : UnaryQueryOperator<TInput, TOutput>
{
	private class IndexedSelectQueryOperatorEnumerator : QueryOperatorEnumerator<TOutput, int>
	{
		private readonly QueryOperatorEnumerator<TInput, int> m_source;

		private readonly Func<TInput, int, TOutput> m_selector;

		internal IndexedSelectQueryOperatorEnumerator(QueryOperatorEnumerator<TInput, int> source, Func<TInput, int, TOutput> selector)
		{
			m_source = source;
			m_selector = selector;
		}

		internal override bool MoveNext(ref TOutput currentElement, ref int currentKey)
		{
			TInput currentElement2 = default(TInput);
			if (m_source.MoveNext(ref currentElement2, ref currentKey))
			{
				currentElement = m_selector(currentElement2, currentKey);
				return true;
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			m_source.Dispose();
		}
	}

	private class IndexedSelectQueryOperatorResults : UnaryQueryOperatorResults
	{
		private IndexedSelectQueryOperator<TInput, TOutput> m_selectOp;

		private int m_childCount;

		internal override int ElementsCount => m_childQueryResults.ElementsCount;

		internal override bool IsIndexible => true;

		public static QueryResults<TOutput> NewResults(QueryResults<TInput> childQueryResults, IndexedSelectQueryOperator<TInput, TOutput> op, QuerySettings settings, bool preferStriping)
		{
			if (childQueryResults.IsIndexible)
			{
				return new IndexedSelectQueryOperatorResults(childQueryResults, op, settings, preferStriping);
			}
			return new UnaryQueryOperatorResults(childQueryResults, op, settings, preferStriping);
		}

		private IndexedSelectQueryOperatorResults(QueryResults<TInput> childQueryResults, IndexedSelectQueryOperator<TInput, TOutput> op, QuerySettings settings, bool preferStriping)
			: base(childQueryResults, (UnaryQueryOperator<TInput, TOutput>)op, settings, preferStriping)
		{
			m_selectOp = op;
			m_childCount = m_childQueryResults.ElementsCount;
		}

		internal override TOutput GetElement(int index)
		{
			return m_selectOp.m_selector(m_childQueryResults.GetElement(index), index);
		}
	}

	private readonly Func<TInput, int, TOutput> m_selector;

	private bool m_prematureMerge;

	private bool m_limitsParallelism;

	internal override bool LimitsParallelism => m_limitsParallelism;

	internal IndexedSelectQueryOperator(IEnumerable<TInput> child, Func<TInput, int, TOutput> selector)
		: base(child)
	{
		m_selector = selector;
		m_outputOrdered = true;
		InitOrdinalIndexState();
	}

	private void InitOrdinalIndexState()
	{
		OrdinalIndexState ordinalIndexState = base.Child.OrdinalIndexState;
		OrdinalIndexState ordinalIndexState2 = ordinalIndexState;
		if (ordinalIndexState.IsWorseThan(OrdinalIndexState.Correct))
		{
			m_prematureMerge = true;
			m_limitsParallelism = ordinalIndexState != OrdinalIndexState.Shuffled;
			ordinalIndexState2 = OrdinalIndexState.Correct;
		}
		SetOrdinalIndexState(ordinalIndexState2);
	}

	internal override QueryResults<TOutput> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TInput> childQueryResults = base.Child.Open(settings, preferStriping);
		return IndexedSelectQueryOperatorResults.NewResults(childQueryResults, this, settings, preferStriping);
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TInput, TKey> inputStream, IPartitionedStreamRecipient<TOutput> recipient, bool preferStriping, QuerySettings settings)
	{
		int partitionCount = inputStream.PartitionCount;
		PartitionedStream<TInput, int> partitionedStream;
		if (m_prematureMerge)
		{
			ListQueryResults<TInput> listQueryResults = QueryOperator<TInput>.ExecuteAndCollectResults(inputStream, partitionCount, base.Child.OutputOrdered, preferStriping, settings);
			partitionedStream = listQueryResults.GetPartitionedStream();
		}
		else
		{
			partitionedStream = (PartitionedStream<TInput, int>)(object)inputStream;
		}
		PartitionedStream<TOutput, int> partitionedStream2 = new PartitionedStream<TOutput, int>(partitionCount, Util.GetDefaultComparer<int>(), OrdinalIndexState);
		for (int i = 0; i < partitionCount; i++)
		{
			partitionedStream2[i] = new IndexedSelectQueryOperatorEnumerator(partitionedStream[i], m_selector);
		}
		recipient.Receive(partitionedStream2);
	}

	internal override IEnumerable<TOutput> AsSequentialQuery(CancellationToken token)
	{
		return base.Child.AsSequentialQuery(token).Select(m_selector);
	}
}
