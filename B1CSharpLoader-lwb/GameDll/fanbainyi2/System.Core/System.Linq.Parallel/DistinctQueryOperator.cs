using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class DistinctQueryOperator<TInputOutput> : UnaryQueryOperator<TInputOutput, TInputOutput>
{
	private class DistinctQueryOperatorEnumerator<TKey> : QueryOperatorEnumerator<TInputOutput, int>
	{
		private QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TKey> m_source;

		private Set<TInputOutput> m_hashLookup;

		private CancellationToken m_cancellationToken;

		private Shared<int> m_outputLoopCount;

		internal DistinctQueryOperatorEnumerator(QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TKey> source, IEqualityComparer<TInputOutput> comparer, CancellationToken cancellationToken)
		{
			m_source = source;
			m_hashLookup = new Set<TInputOutput>(comparer);
			m_cancellationToken = cancellationToken;
		}

		internal override bool MoveNext(ref TInputOutput currentElement, ref int currentKey)
		{
			TKey currentKey2 = default(TKey);
			Pair<TInputOutput, NoKeyMemoizationRequired> currentElement2 = default(Pair<TInputOutput, NoKeyMemoizationRequired>);
			if (m_outputLoopCount == null)
			{
				m_outputLoopCount = new Shared<int>(0);
			}
			while (m_source.MoveNext(ref currentElement2, ref currentKey2))
			{
				if ((m_outputLoopCount.Value++ & 0x3F) == 0)
				{
					CancellationState.ThrowIfCanceled(m_cancellationToken);
				}
				if (m_hashLookup.Add(currentElement2.First))
				{
					currentElement = currentElement2.First;
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

	private class OrderedDistinctQueryOperatorEnumerator<TKey> : QueryOperatorEnumerator<TInputOutput, TKey>
	{
		private QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TKey> m_source;

		private Dictionary<Wrapper<TInputOutput>, TKey> m_hashLookup;

		private IComparer<TKey> m_keyComparer;

		private IEnumerator<KeyValuePair<Wrapper<TInputOutput>, TKey>> m_hashLookupEnumerator;

		private CancellationToken m_cancellationToken;

		internal OrderedDistinctQueryOperatorEnumerator(QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TKey> source, IEqualityComparer<TInputOutput> comparer, IComparer<TKey> keyComparer, CancellationToken cancellationToken)
		{
			m_source = source;
			m_keyComparer = keyComparer;
			m_hashLookup = new Dictionary<Wrapper<TInputOutput>, TKey>(new WrapperEqualityComparer<TInputOutput>(comparer));
			m_cancellationToken = cancellationToken;
		}

		internal override bool MoveNext(ref TInputOutput currentElement, ref TKey currentKey)
		{
			if (m_hashLookupEnumerator == null)
			{
				Pair<TInputOutput, NoKeyMemoizationRequired> currentElement2 = default(Pair<TInputOutput, NoKeyMemoizationRequired>);
				TKey currentKey2 = default(TKey);
				int num = 0;
				while (m_source.MoveNext(ref currentElement2, ref currentKey2))
				{
					if ((num++ & 0x3F) == 0)
					{
						CancellationState.ThrowIfCanceled(m_cancellationToken);
					}
					Wrapper<TInputOutput> key = new Wrapper<TInputOutput>(currentElement2.First);
					if (!m_hashLookup.TryGetValue(key, out var value) || m_keyComparer.Compare(currentKey2, value) < 0)
					{
						m_hashLookup[key] = currentKey2;
					}
				}
				m_hashLookupEnumerator = m_hashLookup.GetEnumerator();
			}
			if (m_hashLookupEnumerator.MoveNext())
			{
				KeyValuePair<Wrapper<TInputOutput>, TKey> current = m_hashLookupEnumerator.Current;
				currentElement = current.Key.Value;
				currentKey = current.Value;
				return true;
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			m_source.Dispose();
			if (m_hashLookupEnumerator != null)
			{
				m_hashLookupEnumerator.Dispose();
			}
		}
	}

	private readonly IEqualityComparer<TInputOutput> m_comparer;

	internal override bool LimitsParallelism => false;

	internal DistinctQueryOperator(IEnumerable<TInputOutput> source, IEqualityComparer<TInputOutput> comparer)
		: base(source)
	{
		m_comparer = comparer;
		SetOrdinalIndexState(OrdinalIndexState.Shuffled);
	}

	internal override QueryResults<TInputOutput> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TInputOutput> childQueryResults = base.Child.Open(settings, preferStriping: false);
		return new UnaryQueryOperatorResults(childQueryResults, this, settings, preferStriping: false);
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TInputOutput, TKey> inputStream, IPartitionedStreamRecipient<TInputOutput> recipient, bool preferStriping, QuerySettings settings)
	{
		if (base.OutputOrdered)
		{
			WrapPartitionedStreamHelper(ExchangeUtilities.HashRepartitionOrdered<TInputOutput, NoKeyMemoizationRequired, TKey>(inputStream, null, null, m_comparer, settings.CancellationState.MergedCancellationToken), recipient, settings.CancellationState.MergedCancellationToken);
		}
		else
		{
			WrapPartitionedStreamHelper(ExchangeUtilities.HashRepartition<TInputOutput, NoKeyMemoizationRequired, TKey>(inputStream, null, null, m_comparer, settings.CancellationState.MergedCancellationToken), recipient, settings.CancellationState.MergedCancellationToken);
		}
	}

	private void WrapPartitionedStreamHelper<TKey>(PartitionedStream<Pair<TInputOutput, NoKeyMemoizationRequired>, TKey> hashStream, IPartitionedStreamRecipient<TInputOutput> recipient, CancellationToken cancellationToken)
	{
		int partitionCount = hashStream.PartitionCount;
		PartitionedStream<TInputOutput, TKey> partitionedStream = new PartitionedStream<TInputOutput, TKey>(partitionCount, hashStream.KeyComparer, OrdinalIndexState.Shuffled);
		for (int i = 0; i < partitionCount; i++)
		{
			if (base.OutputOrdered)
			{
				partitionedStream[i] = new OrderedDistinctQueryOperatorEnumerator<TKey>(hashStream[i], m_comparer, hashStream.KeyComparer, cancellationToken);
			}
			else
			{
				partitionedStream[i] = (QueryOperatorEnumerator<TInputOutput, TKey>)(object)new DistinctQueryOperatorEnumerator<TKey>(hashStream[i], m_comparer, cancellationToken);
			}
		}
		recipient.Receive(partitionedStream);
	}

	internal override IEnumerable<TInputOutput> AsSequentialQuery(CancellationToken token)
	{
		IEnumerable<TInputOutput> source = CancellableEnumerable.Wrap(base.Child.AsSequentialQuery(token), token);
		return source.Distinct(m_comparer);
	}
}
