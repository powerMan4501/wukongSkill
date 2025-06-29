using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class ReverseQueryOperator<TSource> : UnaryQueryOperator<TSource, TSource>
{
	private class ReverseQueryOperatorEnumerator<TKey> : QueryOperatorEnumerator<TSource, TKey>
	{
		private readonly QueryOperatorEnumerator<TSource, TKey> m_source;

		private readonly CancellationToken m_cancellationToken;

		private List<Pair<TSource, TKey>> m_buffer;

		private Shared<int> m_bufferIndex;

		internal ReverseQueryOperatorEnumerator(QueryOperatorEnumerator<TSource, TKey> source, CancellationToken cancellationToken)
		{
			m_source = source;
			m_cancellationToken = cancellationToken;
		}

		internal override bool MoveNext(ref TSource currentElement, ref TKey currentKey)
		{
			if (m_buffer == null)
			{
				m_bufferIndex = new Shared<int>(0);
				m_buffer = new List<Pair<TSource, TKey>>();
				TSource currentElement2 = default(TSource);
				TKey currentKey2 = default(TKey);
				int num = 0;
				while (m_source.MoveNext(ref currentElement2, ref currentKey2))
				{
					if ((num++ & 0x3F) == 0)
					{
						CancellationState.ThrowIfCanceled(m_cancellationToken);
					}
					m_buffer.Add(new Pair<TSource, TKey>(currentElement2, currentKey2));
					m_bufferIndex.Value++;
				}
			}
			if (--m_bufferIndex.Value >= 0)
			{
				currentElement = m_buffer[m_bufferIndex.Value].First;
				currentKey = m_buffer[m_bufferIndex.Value].Second;
				return true;
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			m_source.Dispose();
		}
	}

	private class ReverseQueryOperatorResults : UnaryQueryOperatorResults
	{
		private int m_count;

		internal override bool IsIndexible => true;

		internal override int ElementsCount => m_count;

		public static QueryResults<TSource> NewResults(QueryResults<TSource> childQueryResults, ReverseQueryOperator<TSource> op, QuerySettings settings, bool preferStriping)
		{
			if (childQueryResults.IsIndexible)
			{
				return new ReverseQueryOperatorResults(childQueryResults, op, settings, preferStriping);
			}
			return new UnaryQueryOperatorResults(childQueryResults, op, settings, preferStriping);
		}

		private ReverseQueryOperatorResults(QueryResults<TSource> childQueryResults, ReverseQueryOperator<TSource> op, QuerySettings settings, bool preferStriping)
			: base(childQueryResults, (UnaryQueryOperator<TSource, TSource>)op, settings, preferStriping)
		{
			m_count = m_childQueryResults.ElementsCount;
		}

		internal override TSource GetElement(int index)
		{
			return m_childQueryResults.GetElement(m_count - index - 1);
		}
	}

	internal override bool LimitsParallelism => false;

	internal ReverseQueryOperator(IEnumerable<TSource> child)
		: base(child)
	{
		if (base.Child.OrdinalIndexState == OrdinalIndexState.Indexible)
		{
			SetOrdinalIndexState(OrdinalIndexState.Indexible);
		}
		else
		{
			SetOrdinalIndexState(OrdinalIndexState.Shuffled);
		}
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TSource, TKey> inputStream, IPartitionedStreamRecipient<TSource> recipient, bool preferStriping, QuerySettings settings)
	{
		int partitionCount = inputStream.PartitionCount;
		PartitionedStream<TSource, TKey> partitionedStream = new PartitionedStream<TSource, TKey>(partitionCount, new ReverseComparer<TKey>(inputStream.KeyComparer), OrdinalIndexState.Shuffled);
		for (int i = 0; i < partitionCount; i++)
		{
			partitionedStream[i] = new ReverseQueryOperatorEnumerator<TKey>(inputStream[i], settings.CancellationState.MergedCancellationToken);
		}
		recipient.Receive(partitionedStream);
	}

	internal override QueryResults<TSource> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TSource> childQueryResults = base.Child.Open(settings, preferStriping: false);
		return ReverseQueryOperatorResults.NewResults(childQueryResults, this, settings, preferStriping);
	}

	internal override IEnumerable<TSource> AsSequentialQuery(CancellationToken token)
	{
		IEnumerable<TSource> source = CancellableEnumerable.Wrap(base.Child.AsSequentialQuery(token), token);
		return source.Reverse();
	}
}
