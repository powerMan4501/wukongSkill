using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class GroupJoinQueryOperator<TLeftInput, TRightInput, TKey, TOutput> : BinaryQueryOperator<TLeftInput, TRightInput, TOutput>
{
	private readonly Func<TLeftInput, TKey> m_leftKeySelector;

	private readonly Func<TRightInput, TKey> m_rightKeySelector;

	private readonly Func<TLeftInput, IEnumerable<TRightInput>, TOutput> m_resultSelector;

	private readonly IEqualityComparer<TKey> m_keyComparer;

	internal override bool LimitsParallelism => false;

	internal GroupJoinQueryOperator(ParallelQuery<TLeftInput> left, ParallelQuery<TRightInput> right, Func<TLeftInput, TKey> leftKeySelector, Func<TRightInput, TKey> rightKeySelector, Func<TLeftInput, IEnumerable<TRightInput>, TOutput> resultSelector, IEqualityComparer<TKey> keyComparer)
		: base(left, right)
	{
		m_leftKeySelector = leftKeySelector;
		m_rightKeySelector = rightKeySelector;
		m_resultSelector = resultSelector;
		m_keyComparer = keyComparer;
		m_outputOrdered = base.LeftChild.OutputOrdered;
		SetOrdinalIndex(OrdinalIndexState.Shuffled);
	}

	internal override QueryResults<TOutput> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TLeftInput> leftChildQueryResults = base.LeftChild.Open(settings, preferStriping: false);
		QueryResults<TRightInput> rightChildQueryResults = base.RightChild.Open(settings, preferStriping: false);
		return new BinaryQueryOperatorResults(leftChildQueryResults, rightChildQueryResults, this, settings, preferStriping: false);
	}

	public override void WrapPartitionedStream<TLeftKey, TRightKey>(PartitionedStream<TLeftInput, TLeftKey> leftStream, PartitionedStream<TRightInput, TRightKey> rightStream, IPartitionedStreamRecipient<TOutput> outputRecipient, bool preferStriping, QuerySettings settings)
	{
		int partitionCount = leftStream.PartitionCount;
		if (base.LeftChild.OutputOrdered)
		{
			WrapPartitionedStreamHelper(ExchangeUtilities.HashRepartitionOrdered(leftStream, m_leftKeySelector, m_keyComparer, null, settings.CancellationState.MergedCancellationToken), rightStream, outputRecipient, partitionCount, settings.CancellationState.MergedCancellationToken);
		}
		else
		{
			WrapPartitionedStreamHelper(ExchangeUtilities.HashRepartition(leftStream, m_leftKeySelector, m_keyComparer, null, settings.CancellationState.MergedCancellationToken), rightStream, outputRecipient, partitionCount, settings.CancellationState.MergedCancellationToken);
		}
	}

	private void WrapPartitionedStreamHelper<TLeftKey, TRightKey>(PartitionedStream<Pair<TLeftInput, TKey>, TLeftKey> leftHashStream, PartitionedStream<TRightInput, TRightKey> rightPartitionedStream, IPartitionedStreamRecipient<TOutput> outputRecipient, int partitionCount, CancellationToken cancellationToken)
	{
		PartitionedStream<Pair<TRightInput, TKey>, int> partitionedStream = ExchangeUtilities.HashRepartition(rightPartitionedStream, m_rightKeySelector, m_keyComparer, null, cancellationToken);
		PartitionedStream<TOutput, TLeftKey> partitionedStream2 = new PartitionedStream<TOutput, TLeftKey>(partitionCount, leftHashStream.KeyComparer, OrdinalIndexState);
		for (int i = 0; i < partitionCount; i++)
		{
			partitionedStream2[i] = new HashJoinQueryOperatorEnumerator<TLeftInput, TLeftKey, TRightInput, TKey, TOutput>(leftHashStream[i], partitionedStream[i], null, m_resultSelector, m_keyComparer, cancellationToken);
		}
		outputRecipient.Receive(partitionedStream2);
	}

	internal override IEnumerable<TOutput> AsSequentialQuery(CancellationToken token)
	{
		IEnumerable<TLeftInput> outer = CancellableEnumerable.Wrap(base.LeftChild.AsSequentialQuery(token), token);
		IEnumerable<TRightInput> inner = CancellableEnumerable.Wrap(base.RightChild.AsSequentialQuery(token), token);
		return outer.GroupJoin(inner, m_leftKeySelector, m_rightKeySelector, m_resultSelector, m_keyComparer);
	}
}
