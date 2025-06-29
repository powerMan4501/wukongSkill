using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class UnionQueryOperator<TInputOutput> : BinaryQueryOperator<TInputOutput, TInputOutput, TInputOutput>
{
	private class UnionQueryOperatorEnumerator<TLeftKey, TRightKey> : QueryOperatorEnumerator<TInputOutput, int>
	{
		private QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> m_leftSource;

		private QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TRightKey> m_rightSource;

		private readonly int m_partitionIndex;

		private Set<TInputOutput> m_hashLookup;

		private CancellationToken m_cancellationToken;

		private Shared<int> m_outputLoopCount;

		private readonly IEqualityComparer<TInputOutput> m_comparer;

		internal UnionQueryOperatorEnumerator(QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> leftSource, QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TRightKey> rightSource, int partitionIndex, IEqualityComparer<TInputOutput> comparer, CancellationToken cancellationToken)
		{
			m_leftSource = leftSource;
			m_rightSource = rightSource;
			m_partitionIndex = partitionIndex;
			m_comparer = comparer;
			m_cancellationToken = cancellationToken;
		}

		internal override bool MoveNext(ref TInputOutput currentElement, ref int currentKey)
		{
			if (m_hashLookup == null)
			{
				m_hashLookup = new Set<TInputOutput>(m_comparer);
				m_outputLoopCount = new Shared<int>(0);
			}
			if (m_leftSource != null)
			{
				TLeftKey currentKey2 = default(TLeftKey);
				Pair<TInputOutput, NoKeyMemoizationRequired> currentElement2 = default(Pair<TInputOutput, NoKeyMemoizationRequired>);
				int num = 0;
				while (m_leftSource.MoveNext(ref currentElement2, ref currentKey2))
				{
					if ((num++ & 0x3F) == 0)
					{
						CancellationState.ThrowIfCanceled(m_cancellationToken);
					}
					if (m_hashLookup.Add(currentElement2.First))
					{
						currentElement = currentElement2.First;
						return true;
					}
				}
				m_leftSource.Dispose();
				m_leftSource = null;
			}
			if (m_rightSource != null)
			{
				TRightKey currentKey3 = default(TRightKey);
				Pair<TInputOutput, NoKeyMemoizationRequired> currentElement3 = default(Pair<TInputOutput, NoKeyMemoizationRequired>);
				while (m_rightSource.MoveNext(ref currentElement3, ref currentKey3))
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
				m_rightSource.Dispose();
				m_rightSource = null;
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			if (m_leftSource != null)
			{
				m_leftSource.Dispose();
			}
			if (m_rightSource != null)
			{
				m_rightSource.Dispose();
			}
		}
	}

	private class OrderedUnionQueryOperatorEnumerator<TLeftKey, TRightKey> : QueryOperatorEnumerator<TInputOutput, ConcatKey<TLeftKey, TRightKey>>
	{
		private QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> m_leftSource;

		private QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TRightKey> m_rightSource;

		private IComparer<ConcatKey<TLeftKey, TRightKey>> m_keyComparer;

		private IEnumerator<KeyValuePair<Wrapper<TInputOutput>, Pair<TInputOutput, ConcatKey<TLeftKey, TRightKey>>>> m_outputEnumerator;

		private bool m_leftOrdered;

		private bool m_rightOrdered;

		private IEqualityComparer<TInputOutput> m_comparer;

		private CancellationToken m_cancellationToken;

		internal OrderedUnionQueryOperatorEnumerator(QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> leftSource, QueryOperatorEnumerator<Pair<TInputOutput, NoKeyMemoizationRequired>, TRightKey> rightSource, bool leftOrdered, bool rightOrdered, IEqualityComparer<TInputOutput> comparer, IComparer<ConcatKey<TLeftKey, TRightKey>> keyComparer, CancellationToken cancellationToken)
		{
			m_leftSource = leftSource;
			m_rightSource = rightSource;
			m_keyComparer = keyComparer;
			m_leftOrdered = leftOrdered;
			m_rightOrdered = rightOrdered;
			m_comparer = comparer;
			if (m_comparer == null)
			{
				m_comparer = EqualityComparer<TInputOutput>.Default;
			}
			m_cancellationToken = cancellationToken;
		}

		internal override bool MoveNext(ref TInputOutput currentElement, ref ConcatKey<TLeftKey, TRightKey> currentKey)
		{
			if (m_outputEnumerator == null)
			{
				IEqualityComparer<Wrapper<TInputOutput>> comparer = new WrapperEqualityComparer<TInputOutput>(m_comparer);
				Dictionary<Wrapper<TInputOutput>, Pair<TInputOutput, ConcatKey<TLeftKey, TRightKey>>> dictionary = new Dictionary<Wrapper<TInputOutput>, Pair<TInputOutput, ConcatKey<TLeftKey, TRightKey>>>(comparer);
				Pair<TInputOutput, NoKeyMemoizationRequired> currentElement2 = default(Pair<TInputOutput, NoKeyMemoizationRequired>);
				TLeftKey currentKey2 = default(TLeftKey);
				int num = 0;
				while (m_leftSource.MoveNext(ref currentElement2, ref currentKey2))
				{
					if ((num++ & 0x3F) == 0)
					{
						CancellationState.ThrowIfCanceled(m_cancellationToken);
					}
					ConcatKey<TLeftKey, TRightKey> concatKey = ConcatKey<TLeftKey, TRightKey>.MakeLeft(m_leftOrdered ? currentKey2 : default(TLeftKey));
					Wrapper<TInputOutput> key = new Wrapper<TInputOutput>(currentElement2.First);
					if (!dictionary.TryGetValue(key, out var value) || m_keyComparer.Compare(concatKey, value.Second) < 0)
					{
						dictionary[key] = new Pair<TInputOutput, ConcatKey<TLeftKey, TRightKey>>(currentElement2.First, concatKey);
					}
				}
				TRightKey currentKey3 = default(TRightKey);
				while (m_rightSource.MoveNext(ref currentElement2, ref currentKey3))
				{
					if ((num++ & 0x3F) == 0)
					{
						CancellationState.ThrowIfCanceled(m_cancellationToken);
					}
					ConcatKey<TLeftKey, TRightKey> concatKey2 = ConcatKey<TLeftKey, TRightKey>.MakeRight(m_rightOrdered ? currentKey3 : default(TRightKey));
					Wrapper<TInputOutput> key2 = new Wrapper<TInputOutput>(currentElement2.First);
					if (!dictionary.TryGetValue(key2, out var value2) || m_keyComparer.Compare(concatKey2, value2.Second) < 0)
					{
						dictionary[key2] = new Pair<TInputOutput, ConcatKey<TLeftKey, TRightKey>>(currentElement2.First, concatKey2);
					}
				}
				m_outputEnumerator = dictionary.GetEnumerator();
			}
			if (m_outputEnumerator.MoveNext())
			{
				Pair<TInputOutput, ConcatKey<TLeftKey, TRightKey>> value3 = m_outputEnumerator.Current.Value;
				currentElement = value3.First;
				currentKey = value3.Second;
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

	internal UnionQueryOperator(ParallelQuery<TInputOutput> left, ParallelQuery<TInputOutput> right, IEqualityComparer<TInputOutput> comparer)
		: base(left, right)
	{
		m_comparer = comparer;
		m_outputOrdered = base.LeftChild.OutputOrdered || base.RightChild.OutputOrdered;
	}

	internal override QueryResults<TInputOutput> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TInputOutput> leftChildQueryResults = base.LeftChild.Open(settings, preferStriping: false);
		QueryResults<TInputOutput> rightChildQueryResults = base.RightChild.Open(settings, preferStriping: false);
		return new BinaryQueryOperatorResults(leftChildQueryResults, rightChildQueryResults, this, settings, preferStriping: false);
	}

	public override void WrapPartitionedStream<TLeftKey, TRightKey>(PartitionedStream<TInputOutput, TLeftKey> leftStream, PartitionedStream<TInputOutput, TRightKey> rightStream, IPartitionedStreamRecipient<TInputOutput> outputRecipient, bool preferStriping, QuerySettings settings)
	{
		int partitionCount = leftStream.PartitionCount;
		if (base.LeftChild.OutputOrdered)
		{
			PartitionedStream<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> leftHashStream = ExchangeUtilities.HashRepartitionOrdered<TInputOutput, NoKeyMemoizationRequired, TLeftKey>(leftStream, null, null, m_comparer, settings.CancellationState.MergedCancellationToken);
			WrapPartitionedStreamFixedLeftType(leftHashStream, rightStream, outputRecipient, partitionCount, settings.CancellationState.MergedCancellationToken);
		}
		else
		{
			PartitionedStream<Pair<TInputOutput, NoKeyMemoizationRequired>, int> leftHashStream2 = ExchangeUtilities.HashRepartition<TInputOutput, NoKeyMemoizationRequired, TLeftKey>(leftStream, null, null, m_comparer, settings.CancellationState.MergedCancellationToken);
			WrapPartitionedStreamFixedLeftType(leftHashStream2, rightStream, outputRecipient, partitionCount, settings.CancellationState.MergedCancellationToken);
		}
	}

	private void WrapPartitionedStreamFixedLeftType<TLeftKey, TRightKey>(PartitionedStream<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> leftHashStream, PartitionedStream<TInputOutput, TRightKey> rightStream, IPartitionedStreamRecipient<TInputOutput> outputRecipient, int partitionCount, CancellationToken cancellationToken)
	{
		if (base.RightChild.OutputOrdered)
		{
			PartitionedStream<Pair<TInputOutput, NoKeyMemoizationRequired>, TRightKey> rightHashStream = ExchangeUtilities.HashRepartitionOrdered<TInputOutput, NoKeyMemoizationRequired, TRightKey>(rightStream, null, null, m_comparer, cancellationToken);
			WrapPartitionedStreamFixedBothTypes(leftHashStream, rightHashStream, outputRecipient, partitionCount, cancellationToken);
		}
		else
		{
			PartitionedStream<Pair<TInputOutput, NoKeyMemoizationRequired>, int> rightHashStream2 = ExchangeUtilities.HashRepartition<TInputOutput, NoKeyMemoizationRequired, TRightKey>(rightStream, null, null, m_comparer, cancellationToken);
			WrapPartitionedStreamFixedBothTypes(leftHashStream, rightHashStream2, outputRecipient, partitionCount, cancellationToken);
		}
	}

	private void WrapPartitionedStreamFixedBothTypes<TLeftKey, TRightKey>(PartitionedStream<Pair<TInputOutput, NoKeyMemoizationRequired>, TLeftKey> leftHashStream, PartitionedStream<Pair<TInputOutput, NoKeyMemoizationRequired>, TRightKey> rightHashStream, IPartitionedStreamRecipient<TInputOutput> outputRecipient, int partitionCount, CancellationToken cancellationToken)
	{
		if (base.LeftChild.OutputOrdered || base.RightChild.OutputOrdered)
		{
			IComparer<ConcatKey<TLeftKey, TRightKey>> keyComparer = ConcatKey<TLeftKey, TRightKey>.MakeComparer(leftHashStream.KeyComparer, rightHashStream.KeyComparer);
			PartitionedStream<TInputOutput, ConcatKey<TLeftKey, TRightKey>> partitionedStream = new PartitionedStream<TInputOutput, ConcatKey<TLeftKey, TRightKey>>(partitionCount, keyComparer, OrdinalIndexState.Shuffled);
			for (int i = 0; i < partitionCount; i++)
			{
				partitionedStream[i] = new OrderedUnionQueryOperatorEnumerator<TLeftKey, TRightKey>(leftHashStream[i], rightHashStream[i], base.LeftChild.OutputOrdered, base.RightChild.OutputOrdered, m_comparer, keyComparer, cancellationToken);
			}
			outputRecipient.Receive(partitionedStream);
		}
		else
		{
			PartitionedStream<TInputOutput, int> partitionedStream2 = new PartitionedStream<TInputOutput, int>(partitionCount, Util.GetDefaultComparer<int>(), OrdinalIndexState.Shuffled);
			for (int j = 0; j < partitionCount; j++)
			{
				partitionedStream2[j] = new UnionQueryOperatorEnumerator<TLeftKey, TRightKey>(leftHashStream[j], rightHashStream[j], j, m_comparer, cancellationToken);
			}
			outputRecipient.Receive(partitionedStream2);
		}
	}

	internal override IEnumerable<TInputOutput> AsSequentialQuery(CancellationToken token)
	{
		IEnumerable<TInputOutput> first = CancellableEnumerable.Wrap(base.LeftChild.AsSequentialQuery(token), token);
		IEnumerable<TInputOutput> second = CancellableEnumerable.Wrap(base.RightChild.AsSequentialQuery(token), token);
		return first.Union(second, m_comparer);
	}
}
