using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class LastQueryOperator<TSource> : UnaryQueryOperator<TSource, TSource>
{
	private class LastQueryOperatorEnumerator<TKey> : QueryOperatorEnumerator<TSource, int>
	{
		private QueryOperatorEnumerator<TSource, TKey> m_source;

		private Func<TSource, bool> m_predicate;

		private bool m_alreadySearched;

		private int m_partitionId;

		private LastQueryOperatorState<TKey> m_operatorState;

		private CountdownEvent m_sharedBarrier;

		private CancellationToken m_cancellationToken;

		private IComparer<TKey> m_keyComparer;

		internal LastQueryOperatorEnumerator(QueryOperatorEnumerator<TSource, TKey> source, Func<TSource, bool> predicate, LastQueryOperatorState<TKey> operatorState, CountdownEvent sharedBarrier, CancellationToken cancelToken, IComparer<TKey> keyComparer, int partitionId)
		{
			m_source = source;
			m_predicate = predicate;
			m_operatorState = operatorState;
			m_sharedBarrier = sharedBarrier;
			m_cancellationToken = cancelToken;
			m_keyComparer = keyComparer;
			m_partitionId = partitionId;
		}

		internal override bool MoveNext(ref TSource currentElement, ref int currentKey)
		{
			if (m_alreadySearched)
			{
				return false;
			}
			TSource val = default(TSource);
			TKey val2 = default(TKey);
			bool flag = false;
			try
			{
				int num = 0;
				TSource currentElement2 = default(TSource);
				TKey currentKey2 = default(TKey);
				while (m_source.MoveNext(ref currentElement2, ref currentKey2))
				{
					if ((num & 0x3F) == 0)
					{
						CancellationState.ThrowIfCanceled(m_cancellationToken);
					}
					if (m_predicate == null || m_predicate(currentElement2))
					{
						val = currentElement2;
						val2 = currentKey2;
						flag = true;
					}
					num++;
				}
				if (flag)
				{
					lock (m_operatorState)
					{
						if (m_operatorState.m_partitionId == -1 || m_keyComparer.Compare(val2, m_operatorState.m_key) > 0)
						{
							m_operatorState.m_partitionId = m_partitionId;
							m_operatorState.m_key = val2;
						}
					}
				}
			}
			finally
			{
				m_sharedBarrier.Signal();
			}
			m_alreadySearched = true;
			if (m_partitionId == m_operatorState.m_partitionId)
			{
				m_sharedBarrier.Wait(m_cancellationToken);
				if (m_operatorState.m_partitionId == m_partitionId)
				{
					currentElement = val;
					currentKey = 0;
					return true;
				}
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			m_source.Dispose();
		}
	}

	private class LastQueryOperatorState<TKey>
	{
		internal TKey m_key;

		internal int m_partitionId = -1;
	}

	private readonly Func<TSource, bool> m_predicate;

	private readonly bool m_prematureMergeNeeded;

	internal override bool LimitsParallelism => false;

	internal LastQueryOperator(IEnumerable<TSource> child, Func<TSource, bool> predicate)
		: base(child)
	{
		m_predicate = predicate;
		m_prematureMergeNeeded = base.Child.OrdinalIndexState.IsWorseThan(OrdinalIndexState.Increasing);
	}

	internal override QueryResults<TSource> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TSource> childQueryResults = base.Child.Open(settings, preferStriping: false);
		return new UnaryQueryOperatorResults(childQueryResults, this, settings, preferStriping);
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TSource, TKey> inputStream, IPartitionedStreamRecipient<TSource> recipient, bool preferStriping, QuerySettings settings)
	{
		if (m_prematureMergeNeeded)
		{
			PartitionedStream<TSource, int> partitionedStream = QueryOperator<TSource>.ExecuteAndCollectResults(inputStream, inputStream.PartitionCount, base.Child.OutputOrdered, preferStriping, settings).GetPartitionedStream();
			WrapHelper(partitionedStream, recipient, settings);
		}
		else
		{
			WrapHelper(inputStream, recipient, settings);
		}
	}

	private void WrapHelper<TKey>(PartitionedStream<TSource, TKey> inputStream, IPartitionedStreamRecipient<TSource> recipient, QuerySettings settings)
	{
		int partitionCount = inputStream.PartitionCount;
		LastQueryOperatorState<TKey> operatorState = new LastQueryOperatorState<TKey>();
		CountdownEvent sharedBarrier = new CountdownEvent(partitionCount);
		PartitionedStream<TSource, int> partitionedStream = new PartitionedStream<TSource, int>(partitionCount, Util.GetDefaultComparer<int>(), OrdinalIndexState.Shuffled);
		for (int i = 0; i < partitionCount; i++)
		{
			partitionedStream[i] = new LastQueryOperatorEnumerator<TKey>(inputStream[i], m_predicate, operatorState, sharedBarrier, settings.CancellationState.MergedCancellationToken, inputStream.KeyComparer, i);
		}
		recipient.Receive(partitionedStream);
	}

	internal override IEnumerable<TSource> AsSequentialQuery(CancellationToken token)
	{
		throw new NotSupportedException();
	}
}
