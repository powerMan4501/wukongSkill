using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class IntersectQueryOperator<TInputOutput> : BinaryQueryOperator<TInputOutput, TInputOutput, TInputOutput>
{
	private class IntersectQueryOperatorEnumerator<TLeftKey> : QueryOperatorEnumerator<TInputOutput, int>
	{
		private QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> m_leftSource;

		private QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, int> m_rightSource;

		private IEqualityComparer<TInputOutput> m_comparer;

		private Set<TInputOutput> m_hashLookup;

		private CancellationToken m_cancellationToken;

		private Shared<int> m_outputLoopCount;

		internal IntersectQueryOperatorEnumerator(QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> leftSource, QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, int> rightSource, IEqualityComparer<TInputOutput> comparer, CancellationToken cancellationToken)
		{
			m_leftSource = leftSource;
			m_rightSource = rightSource;
			m_comparer = comparer;
			m_cancellationToken = cancellationToken;
		}

		internal override bool MoveNext(ref TInputOutput currentElement, ref int currentKey)
		{
			if (m_hashLookup == null)
			{
				m_outputLoopCount = new Shared<int>(0);
				m_hashLookup = new Set<TInputOutput>(m_comparer);
				Pair<TInputOutput, NoKeyMemoizationRequired> currentElement2 = default(Pair<TInputOutput, NoKeyMemoizationRequired>);
				int currentKey2 = 0;
				int num = 0;
				while (m_rightSource.MoveNext(ref currentElement2, ref currentKey2))
				{
					if ((num++ & 0x3F) == 0)
					{
						CancellationState.ThrowIfCanceled(m_cancellationToken);
					}
					m_hashLookup.Add(currentElement2.First);
				}
			}
			Pair<TInputOutput, NoKeyMemoizationRequired> currentElement3 = default(Pair<TInputOutput, NoKeyMemoizationRequired>);
			TLeftKey currentKey3 = default(TLeftKey);
			while (m_leftSource.MoveNext(ref currentElement3, ref currentKey3))
			{
				if ((m_outputLoopCount.Value++ & 0x3F) == 0)
				{
					CancellationState.ThrowIfCanceled(m_cancellationToken);
				}
				if (m_hashLookup.Contains(currentElement3.First))
				{
					m_hashLookup.Remove(currentElement3.First);
					currentElement = currentElement3.First;
					return true;
				}
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			m_leftSource.Dispose();
			m_rightSource.Dispose();
		}
	}

	private class OrderedIntersectQueryOperatorEnumerator<TLeftKey> : QueryOperatorEnumerator<TInputOutput, TLeftKey>
	{
		private QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> m_leftSource;

		private QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, int> m_rightSource;

		private IEqualityComparer<Wrapper<TInputOutput>> m_comparer;

		private IComparer<TLeftKey> m_leftKeyComparer;

		private Dictionary<Wrapper<TInputOutput>, Pair<TInputOutput, TLeftKey>> m_hashLookup;

		private CancellationToken m_cancellationToken;

		internal OrderedIntersectQueryOperatorEnumerator(QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> leftSource, QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, int> rightSource, IEqualityComparer<TInputOutput> comparer, IComparer<TLeftKey> leftKeyComparer, CancellationToken cancellationToken)
		{
			m_leftSource = leftSource;
			m_rightSource = rightSource;
			m_comparer = new WrapperEqualityComparer<TInputOutput>(comparer);
			m_leftKeyComparer = leftKeyComparer;
			m_cancellationToken = cancellationToken;
		}

		internal override bool MoveNext(ref TInputOutput currentElement, ref TLeftKey currentKey)
		{
			int num = 0;
			if (m_hashLookup == null)
			{
				m_hashLookup = new Dictionary<Wrapper<TInputOutput>, Pair<TInputOutput, TLeftKey>>(m_comparer);
				Pair<TInputOutput, NoKeyMemoizationRequired> currentElement2 = default(Pair<TInputOutput, NoKeyMemoizationRequired>);
				TLeftKey currentKey2 = default(TLeftKey);
				while (m_leftSource.MoveNext(ref currentElement2, ref currentKey2))
				{
					if ((num++ & 0x3F) == 0)
					{
						CancellationState.ThrowIfCanceled(m_cancellationToken);
					}
					Wrapper<TInputOutput> key = new Wrapper<TInputOutput>(currentElement2.First);
					if (!m_hashLookup.TryGetValue(key, out var value) || m_leftKeyComparer.Compare(currentKey2, value.Second) < 0)
					{
						m_hashLookup[key] = new Pair<TInputOutput, TLeftKey>(currentElement2.First, currentKey2);
					}
				}
			}
			Pair<TInputOutput, NoKeyMemoizationRequired> currentElement3 = default(Pair<TInputOutput, NoKeyMemoizationRequired>);
			int currentKey3 = 0;
			while (m_rightSource.MoveNext(ref currentElement3, ref currentKey3))
			{
				if ((num++ & 0x3F) == 0)
				{
					CancellationState.ThrowIfCanceled(m_cancellationToken);
				}
				Wrapper<TInputOutput> key2 = new Wrapper<TInputOutput>(currentElement3.First);
				if (m_hashLookup.TryGetValue(key2, out var value2))
				{
					currentElement = value2.First;
					currentKey = value2.Second;
					m_hashLookup.Remove(new Wrapper<TInputOutput>(value2.First));
					return true;
				}
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			m_leftSource.Dispose();
			m_rightSource.Dispose();
		}
	}

	private readonly IEqualityComparer<TInputOutput> m_comparer;

	internal override bool LimitsParallelism => false;

	internal IntersectQueryOperator(ParallelQuery<TInputOutput> left, ParallelQuery<TInputOutput> right, IEqualityComparer<TInputOutput> comparer)
		: base(left, right)
	{
		m_comparer = comparer;
		m_outputOrdered = base.LeftChild.OutputOrdered;
		SetOrdinalIndex(OrdinalIndexState.Shuffled);
	}

	internal override QueryResults<TInputOutput> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TInputOutput> leftChildQueryResults = base.LeftChild.Open(settings, preferStriping: false);
		QueryResults<TInputOutput> rightChildQueryResults = base.RightChild.Open(settings, preferStriping: false);
		return new BinaryQueryOperatorResults(leftChildQueryResults, rightChildQueryResults, this, settings, preferStriping: false);
	}

	public override void WrapPartitionedStream<TLeftKey, TRightKey>(PartitionedStream<TInputOutput, TLeftKey> leftPartitionedStream, PartitionedStream<TInputOutput, TRightKey> rightPartitionedStream, IPartitionedStreamRecipient<TInputOutput> outputRecipient, bool preferStriping, QuerySettings settings)
	{
		if (base.OutputOrdered)
		{
			WrapPartitionedStreamHelper(ExchangeUtilities.HashRepartitionOrdered<TInputOutput, NoKeyMemoizationRequired, TLeftKey>(leftPartitionedStream, null, null, m_comparer, settings.CancellationState.MergedCancellationToken), rightPartitionedStream, outputRecipient, settings.CancellationState.MergedCancellationToken);
		}
		else
		{
			WrapPartitionedStreamHelper(ExchangeUtilities.HashRepartition<TInputOutput, NoKeyMemoizationRequired, TLeftKey>(leftPartitionedStream, null, null, m_comparer, settings.CancellationState.MergedCancellationToken), rightPartitionedStream, outputRecipient, settings.CancellationState.MergedCancellationToken);
		}
	}

	private void WrapPartitionedStreamHelper<TLeftKey, TRightKey>(PartitionedStream<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> leftHashStream, PartitionedStream<TInputOutput, TRightKey> rightPartitionedStream, IPartitionedStreamRecipient<TInputOutput> outputRecipient, CancellationToken cancellationToken)
	{
		int partitionCount = leftHashStream.PartitionCount;
		PartitionedStream<Pair<TInputOutput, NoKeyMemoizationRequired>, int> partitionedStream = ExchangeUtilities.HashRepartition<TInputOutput, NoKeyMemoizationRequired, TRightKey>(rightPartitionedStream, null, null, m_comparer, cancellationToken);
		PartitionedStream<TInputOutput, TLeftKey> partitionedStream2 = new PartitionedStream<TInputOutput, TLeftKey>(partitionCount, leftHashStream.KeyComparer, OrdinalIndexState.Shuffled);
		for (int i = 0; i < partitionCount; i++)
		{
			if (base.OutputOrdered)
			{
				partitionedStream2[i] = new OrderedIntersectQueryOperatorEnumerator<TLeftKey>(leftHashStream[i], partitionedStream[i], m_comparer, leftHashStream.KeyComparer, cancellationToken);
			}
			else
			{
				partitionedStream2[i] = (QueryOperatorEnumerator<TInputOutput, TLeftKey>)(object)new IntersectQueryOperatorEnumerator<TLeftKey>(leftHashStream[i], partitionedStream[i], m_comparer, cancellationToken);
			}
		}
		outputRecipient.Receive(partitionedStream2);
	}

	internal override IEnumerable<TInputOutput> AsSequentialQuery(CancellationToken token)
	{
		IEnumerable<TInputOutput> first = CancellableEnumerable.Wrap(base.LeftChild.AsSequentialQuery(token), token);
		IEnumerable<TInputOutput> second = CancellableEnumerable.Wrap(base.RightChild.AsSequentialQuery(token), token);
		return first.Intersect(second, m_comparer);
	}
}
