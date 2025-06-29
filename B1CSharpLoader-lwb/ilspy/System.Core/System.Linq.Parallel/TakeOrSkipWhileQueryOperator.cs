using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class TakeOrSkipWhileQueryOperator<TResult> : UnaryQueryOperator<TResult, TResult>
{
	private class TakeOrSkipWhileQueryOperatorEnumerator<TKey> : QueryOperatorEnumerator<TResult, TKey>
	{
		private readonly QueryOperatorEnumerator<TResult, TKey> m_source;

		private readonly Func<TResult, bool> m_predicate;

		private readonly Func<TResult, TKey, bool> m_indexedPredicate;

		private readonly bool m_take;

		private readonly IComparer<TKey> m_keyComparer;

		private readonly OperatorState<TKey> m_operatorState;

		private readonly CountdownEvent m_sharedBarrier;

		private readonly CancellationToken m_cancellationToken;

		private List<Pair<TResult, TKey>> m_buffer;

		private Shared<int> m_bufferIndex;

		private int m_updatesSeen;

		private TKey m_currentLowKey;

		internal TakeOrSkipWhileQueryOperatorEnumerator(QueryOperatorEnumerator<TResult, TKey> source, Func<TResult, bool> predicate, Func<TResult, TKey, bool> indexedPredicate, bool take, OperatorState<TKey> operatorState, CountdownEvent sharedBarrier, CancellationToken cancelToken, IComparer<TKey> keyComparer)
		{
			m_source = source;
			m_predicate = predicate;
			m_indexedPredicate = indexedPredicate;
			m_take = take;
			m_operatorState = operatorState;
			m_sharedBarrier = sharedBarrier;
			m_cancellationToken = cancelToken;
			m_keyComparer = keyComparer;
		}

		internal override bool MoveNext(ref TResult currentElement, ref TKey currentKey)
		{
			if (m_buffer == null)
			{
				List<Pair<TResult, TKey>> list = new List<Pair<TResult, TKey>>();
				try
				{
					TResult currentElement2 = default(TResult);
					TKey currentKey2 = default(TKey);
					int num = 0;
					while (m_source.MoveNext(ref currentElement2, ref currentKey2))
					{
						if ((num++ & 0x3F) == 0)
						{
							CancellationState.ThrowIfCanceled(m_cancellationToken);
						}
						list.Add(new Pair<TResult, TKey>(currentElement2, currentKey2));
						if (m_updatesSeen != m_operatorState.m_updatesDone)
						{
							lock (m_operatorState)
							{
								m_currentLowKey = m_operatorState.m_currentLowKey;
								m_updatesSeen = m_operatorState.m_updatesDone;
							}
						}
						if (m_updatesSeen > 0 && m_keyComparer.Compare(currentKey2, m_currentLowKey) > 0)
						{
							break;
						}
						if ((m_predicate == null) ? m_indexedPredicate(currentElement2, currentKey2) : m_predicate(currentElement2))
						{
							continue;
						}
						lock (m_operatorState)
						{
							if (m_operatorState.m_updatesDone == 0 || m_keyComparer.Compare(m_operatorState.m_currentLowKey, currentKey2) > 0)
							{
								m_currentLowKey = (m_operatorState.m_currentLowKey = currentKey2);
								m_updatesSeen = ++m_operatorState.m_updatesDone;
							}
						}
						break;
					}
				}
				finally
				{
					m_sharedBarrier.Signal();
				}
				m_sharedBarrier.Wait(m_cancellationToken);
				m_buffer = list;
				m_bufferIndex = new Shared<int>(-1);
			}
			if (m_take)
			{
				if (m_bufferIndex.Value >= m_buffer.Count - 1)
				{
					return false;
				}
				m_bufferIndex.Value++;
				currentElement = m_buffer[m_bufferIndex.Value].First;
				currentKey = m_buffer[m_bufferIndex.Value].Second;
				if (m_operatorState.m_updatesDone != 0)
				{
					return m_keyComparer.Compare(m_operatorState.m_currentLowKey, currentKey) > 0;
				}
				return true;
			}
			if (m_operatorState.m_updatesDone == 0)
			{
				return false;
			}
			if (m_bufferIndex.Value < m_buffer.Count - 1)
			{
				m_bufferIndex.Value++;
				while (m_bufferIndex.Value < m_buffer.Count)
				{
					if (m_keyComparer.Compare(m_buffer[m_bufferIndex.Value].Second, m_operatorState.m_currentLowKey) >= 0)
					{
						currentElement = m_buffer[m_bufferIndex.Value].First;
						currentKey = m_buffer[m_bufferIndex.Value].Second;
						return true;
					}
					m_bufferIndex.Value++;
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

	private class OperatorState<TKey>
	{
		internal volatile int m_updatesDone;

		internal TKey m_currentLowKey;
	}

	private Func<TResult, bool> m_predicate;

	private Func<TResult, int, bool> m_indexedPredicate;

	private readonly bool m_take;

	private bool m_prematureMerge;

	private bool m_limitsParallelism;

	internal override bool LimitsParallelism => m_limitsParallelism;

	internal TakeOrSkipWhileQueryOperator(IEnumerable<TResult> child, Func<TResult, bool> predicate, Func<TResult, int, bool> indexedPredicate, bool take)
		: base(child)
	{
		m_predicate = predicate;
		m_indexedPredicate = indexedPredicate;
		m_take = take;
		InitOrderIndexState();
	}

	private void InitOrderIndexState()
	{
		OrdinalIndexState state = OrdinalIndexState.Increasing;
		OrdinalIndexState ordinalIndexState = base.Child.OrdinalIndexState;
		if (m_indexedPredicate != null)
		{
			state = OrdinalIndexState.Correct;
			m_limitsParallelism = ordinalIndexState == OrdinalIndexState.Increasing;
		}
		OrdinalIndexState ordinalIndexState2 = ordinalIndexState.Worse(OrdinalIndexState.Correct);
		if (ordinalIndexState2.IsWorseThan(state))
		{
			m_prematureMerge = true;
		}
		if (!m_take)
		{
			ordinalIndexState2 = ordinalIndexState2.Worse(OrdinalIndexState.Increasing);
		}
		SetOrdinalIndexState(ordinalIndexState2);
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
		OperatorState<TKey> operatorState = new OperatorState<TKey>();
		CountdownEvent sharedBarrier = new CountdownEvent(partitionCount);
		Func<TResult, TKey, bool> indexedPredicate = (Func<TResult, TKey, bool>)(object)m_indexedPredicate;
		PartitionedStream<TResult, TKey> partitionedStream = new PartitionedStream<TResult, TKey>(partitionCount, inputStream.KeyComparer, OrdinalIndexState);
		for (int i = 0; i < partitionCount; i++)
		{
			partitionedStream[i] = new TakeOrSkipWhileQueryOperatorEnumerator<TKey>(inputStream[i], m_predicate, indexedPredicate, m_take, operatorState, sharedBarrier, settings.CancellationState.MergedCancellationToken, inputStream.KeyComparer);
		}
		recipient.Receive(partitionedStream);
	}

	internal override QueryResults<TResult> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TResult> childQueryResults = base.Child.Open(settings, preferStriping: true);
		return new UnaryQueryOperatorResults(childQueryResults, this, settings, preferStriping);
	}

	internal override IEnumerable<TResult> AsSequentialQuery(CancellationToken token)
	{
		if (m_take)
		{
			if (m_indexedPredicate != null)
			{
				return base.Child.AsSequentialQuery(token).TakeWhile(m_indexedPredicate);
			}
			return base.Child.AsSequentialQuery(token).TakeWhile(m_predicate);
		}
		if (m_indexedPredicate != null)
		{
			IEnumerable<TResult> source = CancellableEnumerable.Wrap(base.Child.AsSequentialQuery(token), token);
			return source.SkipWhile(m_indexedPredicate);
		}
		IEnumerable<TResult> source2 = CancellableEnumerable.Wrap(base.Child.AsSequentialQuery(token), token);
		return source2.SkipWhile(m_predicate);
	}
}
