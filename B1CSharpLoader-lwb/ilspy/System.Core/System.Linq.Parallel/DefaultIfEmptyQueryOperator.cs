using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class DefaultIfEmptyQueryOperator<TSource> : UnaryQueryOperator<TSource, TSource>
{
	private class DefaultIfEmptyQueryOperatorEnumerator<TKey> : QueryOperatorEnumerator<TSource, TKey>
	{
		private QueryOperatorEnumerator<TSource, TKey> m_source;

		private bool m_lookedForEmpty;

		private int m_partitionIndex;

		private int m_partitionCount;

		private TSource m_defaultValue;

		private Shared<int> m_sharedEmptyCount;

		private CountdownEvent m_sharedLatch;

		private CancellationToken m_cancelToken;

		internal DefaultIfEmptyQueryOperatorEnumerator(QueryOperatorEnumerator<TSource, TKey> source, TSource defaultValue, int partitionIndex, int partitionCount, Shared<int> sharedEmptyCount, CountdownEvent sharedLatch, CancellationToken cancelToken)
		{
			m_source = source;
			m_defaultValue = defaultValue;
			m_partitionIndex = partitionIndex;
			m_partitionCount = partitionCount;
			m_sharedEmptyCount = sharedEmptyCount;
			m_sharedLatch = sharedLatch;
			m_cancelToken = cancelToken;
		}

		internal override bool MoveNext(ref TSource currentElement, ref TKey currentKey)
		{
			bool flag = m_source.MoveNext(ref currentElement, ref currentKey);
			if (!m_lookedForEmpty)
			{
				m_lookedForEmpty = true;
				if (!flag)
				{
					if (m_partitionIndex == 0)
					{
						m_sharedLatch.Wait(m_cancelToken);
						m_sharedLatch.Dispose();
						if (m_sharedEmptyCount.Value == m_partitionCount - 1)
						{
							currentElement = m_defaultValue;
							currentKey = default(TKey);
							return true;
						}
						return false;
					}
					Interlocked.Increment(ref m_sharedEmptyCount.Value);
				}
				if (m_partitionIndex != 0)
				{
					m_sharedLatch.Signal();
				}
			}
			return flag;
		}

		protected override void Dispose(bool disposing)
		{
			m_source.Dispose();
		}
	}

	private readonly TSource m_defaultValue;

	internal override bool LimitsParallelism => false;

	internal DefaultIfEmptyQueryOperator(IEnumerable<TSource> child, TSource defaultValue)
		: base(child)
	{
		m_defaultValue = defaultValue;
		SetOrdinalIndexState(base.Child.OrdinalIndexState.Worse(OrdinalIndexState.Correct));
	}

	internal override QueryResults<TSource> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TSource> childQueryResults = base.Child.Open(settings, preferStriping);
		return new UnaryQueryOperatorResults(childQueryResults, this, settings, preferStriping);
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TSource, TKey> inputStream, IPartitionedStreamRecipient<TSource> recipient, bool preferStriping, QuerySettings settings)
	{
		int partitionCount = inputStream.PartitionCount;
		Shared<int> sharedEmptyCount = new Shared<int>(0);
		CountdownEvent sharedLatch = new CountdownEvent(partitionCount - 1);
		PartitionedStream<TSource, TKey> partitionedStream = new PartitionedStream<TSource, TKey>(partitionCount, inputStream.KeyComparer, OrdinalIndexState);
		for (int i = 0; i < partitionCount; i++)
		{
			partitionedStream[i] = new DefaultIfEmptyQueryOperatorEnumerator<TKey>(inputStream[i], m_defaultValue, i, partitionCount, sharedEmptyCount, sharedLatch, settings.CancellationState.MergedCancellationToken);
		}
		recipient.Receive(partitionedStream);
	}

	internal override IEnumerable<TSource> AsSequentialQuery(CancellationToken token)
	{
		return base.Child.AsSequentialQuery(token).DefaultIfEmpty(m_defaultValue);
	}
}
