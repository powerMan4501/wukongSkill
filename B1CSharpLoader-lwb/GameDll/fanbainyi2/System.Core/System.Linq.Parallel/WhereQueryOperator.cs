using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class WhereQueryOperator<TInputOutput> : UnaryQueryOperator<TInputOutput, TInputOutput>
{
	private class WhereQueryOperatorEnumerator<TKey> : QueryOperatorEnumerator<TInputOutput, TKey>
	{
		private readonly QueryOperatorEnumerator<TInputOutput, TKey> m_source;

		private readonly Func<TInputOutput, bool> m_predicate;

		private CancellationToken m_cancellationToken;

		private Shared<int> m_outputLoopCount;

		internal WhereQueryOperatorEnumerator(QueryOperatorEnumerator<TInputOutput, TKey> source, Func<TInputOutput, bool> predicate, CancellationToken cancellationToken)
		{
			m_source = source;
			m_predicate = predicate;
			m_cancellationToken = cancellationToken;
		}

		internal override bool MoveNext(ref TInputOutput currentElement, ref TKey currentKey)
		{
			if (m_outputLoopCount == null)
			{
				m_outputLoopCount = new Shared<int>(0);
			}
			while (m_source.MoveNext(ref currentElement, ref currentKey))
			{
				if ((m_outputLoopCount.Value++ & 0x3F) == 0)
				{
					CancellationState.ThrowIfCanceled(m_cancellationToken);
				}
				if (m_predicate(currentElement))
				{
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

	private Func<TInputOutput, bool> m_predicate;

	internal override bool LimitsParallelism => false;

	internal WhereQueryOperator(IEnumerable<TInputOutput> child, Func<TInputOutput, bool> predicate)
		: base(child)
	{
		SetOrdinalIndexState(base.Child.OrdinalIndexState.Worse(OrdinalIndexState.Increasing));
		m_predicate = predicate;
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TInputOutput, TKey> inputStream, IPartitionedStreamRecipient<TInputOutput> recipient, bool preferStriping, QuerySettings settings)
	{
		PartitionedStream<TInputOutput, TKey> partitionedStream = new PartitionedStream<TInputOutput, TKey>(inputStream.PartitionCount, inputStream.KeyComparer, OrdinalIndexState);
		for (int i = 0; i < inputStream.PartitionCount; i++)
		{
			partitionedStream[i] = new WhereQueryOperatorEnumerator<TKey>(inputStream[i], m_predicate, settings.CancellationState.MergedCancellationToken);
		}
		recipient.Receive(partitionedStream);
	}

	internal override QueryResults<TInputOutput> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TInputOutput> childQueryResults = base.Child.Open(settings, preferStriping);
		return new UnaryQueryOperatorResults(childQueryResults, this, settings, preferStriping);
	}

	internal override IEnumerable<TInputOutput> AsSequentialQuery(CancellationToken token)
	{
		IEnumerable<TInputOutput> source = CancellableEnumerable.Wrap(base.Child.AsSequentialQuery(token), token);
		return source.Where(m_predicate);
	}
}
