using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class TakeOrSkipQueryOperator<TResult> : UnaryQueryOperator<TResult, TResult>
{
	private class TakeOrSkipQueryOperatorEnumerator<TKey> : QueryOperatorEnumerator<TResult, TKey>
	{
		private readonly QueryOperatorEnumerator<TResult, TKey> m_source;

		private readonly int m_count;

		private readonly bool m_take;

		private readonly IComparer<TKey> m_keyComparer;

		private readonly FixedMaxHeap<TKey> m_sharedIndices;

		private readonly CountdownEvent m_sharedBarrier;

		private readonly CancellationToken m_cancellationToken;

		private List<Pair<TResult, TKey>> m_buffer;

		private Shared<int> m_bufferIndex;

		internal TakeOrSkipQueryOperatorEnumerator(QueryOperatorEnumerator<TResult, TKey> source, bool take, FixedMaxHeap<TKey> sharedIndices, CountdownEvent sharedBarrier, CancellationToken cancellationToken, IComparer<TKey> keyComparer)
		{
			m_source = source;
			m_count = sharedIndices.Size;
			m_take = take;
			m_sharedIndices = sharedIndices;
			m_sharedBarrier = sharedBarrier;
			m_cancellationToken = cancellationToken;
			m_keyComparer = keyComparer;
		}

		internal override bool MoveNext(ref TResult currentElement, ref TKey currentKey)
		{
			if (m_buffer == null && m_count > 0)
			{
				List<Pair<TResult, TKey>> list = new List<Pair<TResult, TKey>>();
				TResult currentElement2 = default(TResult);
				TKey currentKey2 = default(TKey);
				int num = 0;
				while (list.Count < m_count && m_source.MoveNext(ref currentElement2, ref currentKey2))
				{
					if ((num++ & 0x3F) == 0)
					{
						CancellationState.ThrowIfCanceled(m_cancellationToken);
					}
					list.Add(new Pair<TResult, TKey>(currentElement2, currentKey2));
					lock (m_sharedIndices)
					{
						if (!m_sharedIndices.Insert(currentKey2))
						{
							break;
						}
					}
				}
				m_sharedBarrier.Signal();
				m_sharedBarrier.Wait(m_cancellationToken);
				m_buffer = list;
				m_bufferIndex = new Shared<int>(-1);
			}
			if (m_take)
			{
				if (m_count == 0 || m_bufferIndex.Value >= m_buffer.Count - 1)
				{
					return false;
				}
				m_bufferIndex.Value++;
				currentElement = m_buffer[m_bufferIndex.Value].First;
				currentKey = m_buffer[m_bufferIndex.Value].Second;
				if (m_sharedIndices.Count != 0)
				{
					return m_keyComparer.Compare(m_buffer[m_bufferIndex.Value].Second, m_sharedIndices.MaxValue) <= 0;
				}
				return true;
			}
			TKey val = default(TKey);
			if (m_count > 0)
			{
				if (m_sharedIndices.Count < m_count)
				{
					return false;
				}
				val = m_sharedIndices.MaxValue;
				if (m_bufferIndex.Value < m_buffer.Count - 1)
				{
					m_bufferIndex.Value++;
					while (m_bufferIndex.Value < m_buffer.Count)
					{
						if (m_keyComparer.Compare(m_buffer[m_bufferIndex.Value].Second, val) > 0)
						{
							currentElement = m_buffer[m_bufferIndex.Value].First;
							currentKey = m_buffer[m_bufferIndex.Value].Second;
							return true;
						}
						m_bufferIndex.Value++;
					}
				}
			}
			if (m_source.MoveNext(ref currentElement, ref currentKey))
			{
				return true;
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			m_source.Dispose();
		}
	}

	private class TakeOrSkipQueryOperatorResults : UnaryQueryOperatorResults
	{
		private TakeOrSkipQueryOperator<TResult> m_takeOrSkipOp;

		private int m_childCount;

		internal override bool IsIndexible => m_childCount >= 0;

		internal override int ElementsCount
		{
			get
			{
				if (m_takeOrSkipOp.m_take)
				{
					return Math.Min(m_childCount, m_takeOrSkipOp.m_count);
				}
				return Math.Max(m_childCount - m_takeOrSkipOp.m_count, 0);
			}
		}

		public static QueryResults<TResult> NewResults(QueryResults<TResult> childQueryResults, TakeOrSkipQueryOperator<TResult> op, QuerySettings settings, bool preferStriping)
		{
			if (childQueryResults.IsIndexible)
			{
				return new TakeOrSkipQueryOperatorResults(childQueryResults, op, settings, preferStriping);
			}
			return new UnaryQueryOperatorResults(childQueryResults, op, settings, preferStriping);
		}

		private TakeOrSkipQueryOperatorResults(QueryResults<TResult> childQueryResults, TakeOrSkipQueryOperator<TResult> takeOrSkipOp, QuerySettings settings, bool preferStriping)
			: base(childQueryResults, (UnaryQueryOperator<TResult, TResult>)takeOrSkipOp, settings, preferStriping)
		{
			m_takeOrSkipOp = takeOrSkipOp;
			m_childCount = m_childQueryResults.ElementsCount;
		}

		internal override TResult GetElement(int index)
		{
			if (m_takeOrSkipOp.m_take)
			{
				return m_childQueryResults.GetElement(index);
			}
			return m_childQueryResults.GetElement(m_takeOrSkipOp.m_count + index);
		}
	}

	private readonly int m_count;

	private readonly bool m_take;

	private bool m_prematureMerge;

	internal override bool LimitsParallelism => false;

	internal TakeOrSkipQueryOperator(IEnumerable<TResult> child, int count, bool take)
		: base(child)
	{
		m_count = count;
		m_take = take;
		SetOrdinalIndexState(OutputOrdinalIndexState());
	}

	private OrdinalIndexState OutputOrdinalIndexState()
	{
		OrdinalIndexState ordinalIndexState = base.Child.OrdinalIndexState;
		if (ordinalIndexState == OrdinalIndexState.Indexible)
		{
			return OrdinalIndexState.Indexible;
		}
		if (ordinalIndexState.IsWorseThan(OrdinalIndexState.Increasing))
		{
			m_prematureMerge = true;
			ordinalIndexState = OrdinalIndexState.Correct;
		}
		if (!m_take && ordinalIndexState == OrdinalIndexState.Correct)
		{
			ordinalIndexState = OrdinalIndexState.Increasing;
		}
		return ordinalIndexState;
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TResult, TKey> inputStream, IPartitionedStreamRecipient<TResult> recipient, bool preferStriping, QuerySettings settings)
	{
		if (m_prematureMerge)
		{
			ListQueryResults<TResult> listQueryResults = QueryOperator<TResult>.ExecuteAndCollectResults(inputStream, inputStream.PartitionCount, base.Child.OutputOrdered, preferStriping, settings);
			PartitionedStream<TResult, int> partitionedStream = listQueryResults.GetPartitionedStream();
			WrapHelper(partitionedStream, recipient, settings);
		}
		else
		{
			WrapHelper(inputStream, recipient, settings);
		}
	}

	private void WrapHelper<TKey>(PartitionedStream<TResult, TKey> inputStream, IPartitionedStreamRecipient<TResult> recipient, QuerySettings settings)
	{
		int partitionCount = inputStream.PartitionCount;
		FixedMaxHeap<TKey> sharedIndices = new FixedMaxHeap<TKey>(m_count, inputStream.KeyComparer);
		CountdownEvent sharedBarrier = new CountdownEvent(partitionCount);
		PartitionedStream<TResult, TKey> partitionedStream = new PartitionedStream<TResult, TKey>(partitionCount, inputStream.KeyComparer, OrdinalIndexState);
		for (int i = 0; i < partitionCount; i++)
		{
			partitionedStream[i] = new TakeOrSkipQueryOperatorEnumerator<TKey>(inputStream[i], m_take, sharedIndices, sharedBarrier, settings.CancellationState.MergedCancellationToken, inputStream.KeyComparer);
		}
		recipient.Receive(partitionedStream);
	}

	internal override QueryResults<TResult> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TResult> childQueryResults = base.Child.Open(settings, preferStriping: true);
		return TakeOrSkipQueryOperatorResults.NewResults(childQueryResults, this, settings, preferStriping);
	}

	internal override IEnumerable<TResult> AsSequentialQuery(CancellationToken token)
	{
		if (m_take)
		{
			return base.Child.AsSequentialQuery(token).Take(m_count);
		}
		IEnumerable<TResult> source = CancellableEnumerable.Wrap(base.Child.AsSequentialQuery(token), token);
		return source.Skip(m_count);
	}
}
