using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class ExceptQueryOperator<TInputOutput> : BinaryQueryOperator<TInputOutput, TInputOutput, TInputOutput>
{
	private class ExceptQueryOperatorEnumerator<TLeftKey> : QueryOperatorEnumerator<TInputOutput, int>
	{
		private QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> m_leftSource;

		private QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, int> m_rightSource;

		private IEqualityComparer<TInputOutput> m_comparer;

		private Set<TInputOutput> m_hashLookup;

		private CancellationToken m_cancellationToken;

		private Shared<int> m_outputLoopCount;

		internal ExceptQueryOperatorEnumerator(QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> leftSource, QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, int> rightSource, IEqualityComparer<TInputOutput> comparer, CancellationToken cancellationToken)
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
				if (m_hashLookup.Add(currentElement3.First))
				{
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

	private class OrderedExceptQueryOperatorEnumerator<TLeftKey> : QueryOperatorEnumerator<TInputOutput, TLeftKey>
	{
		private QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> m_leftSource;

		private QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, int> m_rightSource;

		private IEqualityComparer<TInputOutput> m_comparer;

		private IComparer<TLeftKey> m_leftKeyComparer;

		private IEnumerator<KeyValuePair<Wrapper<TInputOutput>, Pair<TInputOutput, TLeftKey>>> m_outputEnumerator;

		private CancellationToken m_cancellationToken;

		internal OrderedExceptQueryOperatorEnumerator(QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> leftSource, QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, int> rightSource, IEqualityComparer<TInputOutput> comparer, IComparer<TLeftKey> leftKeyComparer, CancellationToken cancellationToken)
		{
			m_leftSource = leftSource;
			m_rightSource = rightSource;
			m_comparer = comparer;
			m_leftKeyComparer = leftKeyComparer;
			m_cancellationToken = cancellationToken;
		}

		internal override bool MoveNext(ref TInputOutput currentElement, ref TLeftKey currentKey)
		{
			if (m_outputEnumerator == null)
			{
				Set<TInputOutput> set = new Set<TInputOutput>(m_comparer);
				Pair<TInputOutput, NoKeyMemoizationRequired> currentElement2 = default(Pair<TInputOutput, NoKeyMemoizationRequired>);
				int currentKey2 = 0;
				int num = 0;
				while (m_rightSource.MoveNext(ref currentElement2, ref currentKey2))
				{
					if ((num++ & 0x3F) == 0)
					{
						CancellationState.ThrowIfCanceled(m_cancellationToken);
					}
					set.Add(currentElement2.First);
				}
				Dictionary<Wrapper<TInputOutput>, Pair<TInputOutput, TLeftKey>> dictionary = new Dictionary<Wrapper<TInputOutput>, Pair<TInputOutput, TLeftKey>>(new WrapperEqualityComparer<TInputOutput>(m_comparer));
				Pair<TInputOutput, NoKeyMemoizationRequired> currentElement3 = default(Pair<TInputOutput, NoKeyMemoizationRequired>);
				TLeftKey currentKey3 = default(TLeftKey);
				while (m_leftSource.MoveNext(ref currentElement3, ref currentKey3))
				{
					if ((num++ & 0x3F) == 0)
					{
						CancellationState.ThrowIfCanceled(m_cancellationToken);
					}
					if (!set.Contains(currentElement3.First))
					{
						Wrapper<TInputOutput> key = new Wrapper<TInputOutput>(currentElement3.First);
						if (!dictionary.TryGetValue(key, out var value) || m_leftKeyComparer.Compare(currentKey3, value.Second) < 0)
						{
							dictionary[key] = new Pair<TInputOutput, TLeftKey>(currentElement3.First, currentKey3);
						}
					}
				}
				m_outputEnumerator = dictionary.GetEnumerator();
			}
			if (m_outputEnumerator.MoveNext())
			{
				Pair<TInputOutput, TLeftKey> value2 = m_outputEnumerator.Current.Value;
				currentElement = value2.First;
				currentKey = value2.Second;
				return true;
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

	internal ExceptQueryOperator(ParallelQuery<TInputOutput> left, ParallelQuery<TInputOutput> right, IEqualityComparer<TInputOutput> comparer)
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

	public override void WrapPartitionedStream<TLeftKey, TRightKey>(PartitionedStream<TInputOutput, TLeftKey> leftStream, PartitionedStream<TInputOutput, TRightKey> rightStream, IPartitionedStreamRecipient<TInputOutput> outputRecipient, bool preferStriping, QuerySettings settings)
	{
		if (base.OutputOrdered)
		{
			WrapPartitionedStreamHelper(ExchangeUtilities.HashRepartitionOrdered<TInputOutput, NoKeyMemoizationRequired, TLeftKey>(leftStream, null, null, m_comparer, settings.CancellationState.MergedCancellationToken), rightStream, outputRecipient, settings.CancellationState.MergedCancellationToken);
		}
		else
		{
			WrapPartitionedStreamHelper(ExchangeUtilities.HashRepartition<TInputOutput, NoKeyMemoizationRequired, TLeftKey>(leftStream, null, null, m_comparer, settings.CancellationState.MergedCancellationToken), rightStream, outputRecipient, settings.CancellationState.MergedCancellationToken);
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
				partitionedStream2[i] = new OrderedExceptQueryOperatorEnumerator<TLeftKey>(leftHashStream[i], partitionedStream[i], m_comparer, leftHashStream.KeyComparer, cancellationToken);
			}
			else
			{
				partitionedStream2[i] = (QueryOperatorEnumerator<TInputOutput, TLeftKey>)(object)new ExceptQueryOperatorEnumerator<TLeftKey>(leftHashStream[i], partitionedStream[i], m_comparer, cancellationToken);
			}
		}
		outputRecipient.Receive(partitionedStream2);
	}

	internal override IEnumerable<TInputOutput> AsSequentialQuery(CancellationToken token)
	{
		IEnumerable<TInputOutput> first = CancellableEnumerable.Wrap(base.LeftChild.AsSequentialQuery(token), token);
		IEnumerable<TInputOutput> second = CancellableEnumerable.Wrap(base.RightChild.AsSequentialQuery(token), token);
		return first.Except(second, m_comparer);
	}
}
