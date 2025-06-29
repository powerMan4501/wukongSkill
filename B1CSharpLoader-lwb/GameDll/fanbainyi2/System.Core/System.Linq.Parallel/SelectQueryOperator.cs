using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class SelectQueryOperator<TInput, TOutput> : UnaryQueryOperator<TInput, TOutput>
{
	private class SelectQueryOperatorEnumerator<TKey> : QueryOperatorEnumerator<TOutput, TKey>
	{
		private readonly QueryOperatorEnumerator<TInput, TKey> m_source;

		private readonly Func<TInput, TOutput> m_selector;

		internal SelectQueryOperatorEnumerator(QueryOperatorEnumerator<TInput, TKey> source, Func<TInput, TOutput> selector)
		{
			m_source = source;
			m_selector = selector;
		}

		internal override bool MoveNext(ref TOutput currentElement, ref TKey currentKey)
		{
			TInput currentElement2 = default(TInput);
			if (m_source.MoveNext(ref currentElement2, ref currentKey))
			{
				currentElement = m_selector(currentElement2);
				return true;
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			m_source.Dispose();
		}
	}

	private class SelectQueryOperatorResults : UnaryQueryOperatorResults
	{
		private Func<TInput, TOutput> m_selector;

		private int m_childCount;

		internal override bool IsIndexible => true;

		internal override int ElementsCount => m_childCount;

		public static QueryResults<TOutput> NewResults(QueryResults<TInput> childQueryResults, SelectQueryOperator<TInput, TOutput> op, QuerySettings settings, bool preferStriping)
		{
			if (childQueryResults.IsIndexible)
			{
				return new SelectQueryOperatorResults(childQueryResults, op, settings, preferStriping);
			}
			return new UnaryQueryOperatorResults(childQueryResults, op, settings, preferStriping);
		}

		private SelectQueryOperatorResults(QueryResults<TInput> childQueryResults, SelectQueryOperator<TInput, TOutput> op, QuerySettings settings, bool preferStriping)
			: base(childQueryResults, (UnaryQueryOperator<TInput, TOutput>)op, settings, preferStriping)
		{
			m_selector = op.m_selector;
			m_childCount = m_childQueryResults.ElementsCount;
		}

		internal override TOutput GetElement(int index)
		{
			return m_selector(m_childQueryResults.GetElement(index));
		}
	}

	private Func<TInput, TOutput> m_selector;

	internal override bool LimitsParallelism => false;

	internal SelectQueryOperator(IEnumerable<TInput> child, Func<TInput, TOutput> selector)
		: base(child)
	{
		m_selector = selector;
		SetOrdinalIndexState(base.Child.OrdinalIndexState);
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TInput, TKey> inputStream, IPartitionedStreamRecipient<TOutput> recipient, bool preferStriping, QuerySettings settings)
	{
		PartitionedStream<TOutput, TKey> partitionedStream = new PartitionedStream<TOutput, TKey>(inputStream.PartitionCount, inputStream.KeyComparer, OrdinalIndexState);
		for (int i = 0; i < inputStream.PartitionCount; i++)
		{
			partitionedStream[i] = new SelectQueryOperatorEnumerator<TKey>(inputStream[i], m_selector);
		}
		recipient.Receive(partitionedStream);
	}

	internal override QueryResults<TOutput> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TInput> childQueryResults = base.Child.Open(settings, preferStriping);
		return SelectQueryOperatorResults.NewResults(childQueryResults, this, settings, preferStriping);
	}

	internal override IEnumerable<TOutput> AsSequentialQuery(CancellationToken token)
	{
		return base.Child.AsSequentialQuery(token).Select(m_selector);
	}
}
