using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class IndexedWhereQueryOperator<TInputOutput> : UnaryQueryOperator<TInputOutput, TInputOutput>
{
	private class IndexedWhereQueryOperatorEnumerator : QueryOperatorEnumerator<TInputOutput, int>
	{
		private readonly QueryOperatorEnumerator<TInputOutput, int> m_source;

		private readonly Func<TInputOutput, int, bool> m_predicate;

		private CancellationToken m_cancellationToken;

		private Shared<int> m_outputLoopCount;

		internal IndexedWhereQueryOperatorEnumerator(QueryOperatorEnumerator<TInputOutput, int> source, Func<TInputOutput, int, bool> predicate, CancellationToken cancellationToken)
		{
			m_source = source;
			m_predicate = predicate;
			m_cancellationToken = cancellationToken;
		}

		internal override bool MoveNext(ref TInputOutput currentElement, ref int currentKey)
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
				if (m_predicate(currentElement, currentKey))
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

	private Func<TInputOutput, int, bool> m_predicate;

	private bool m_prematureMerge;

	private bool m_limitsParallelism;

	internal override bool LimitsParallelism => m_limitsParallelism;

	internal IndexedWhereQueryOperator(IEnumerable<TInputOutput> child, Func<TInputOutput, int, bool> predicate)
		: base(child)
	{
		m_predicate = predicate;
		m_outputOrdered = true;
		InitOrdinalIndexState();
	}

	private void InitOrdinalIndexState()
	{
		OrdinalIndexState ordinalIndexState = base.Child.OrdinalIndexState;
		if (ordinalIndexState.IsWorseThan(OrdinalIndexState.Correct))
		{
			m_prematureMerge = true;
			m_limitsParallelism = ordinalIndexState != OrdinalIndexState.Shuffled;
		}
		SetOrdinalIndexState(OrdinalIndexState.Increasing);
	}

	internal override QueryResults<TInputOutput> Open(QuerySettings settings, bool preferStriping)
	{
		QueryResults<TInputOutput> childQueryResults = base.Child.Open(settings, preferStriping);
		return new UnaryQueryOperatorResults(childQueryResults, this, settings, preferStriping);
	}

	internal override void WrapPartitionedStream<TKey>(PartitionedStream<TInputOutput, TKey> inputStream, IPartitionedStreamRecipient<TInputOutput> recipient, bool preferStriping, QuerySettings settings)
	{
		int partitionCount = inputStream.PartitionCount;
		PartitionedStream<TInputOutput, int> partitionedStream;
		if (m_prematureMerge)
		{
			ListQueryResults<TInputOutput> listQueryResults = QueryOperator<TInputOutput>.ExecuteAndCollectResults(inputStream, partitionCount, base.Child.OutputOrdered, preferStriping, settings);
			partitionedStream = listQueryResults.GetPartitionedStream();
		}
		else
		{
			partitionedStream = (PartitionedStream<TInputOutput, int>)(object)inputStream;
		}
		PartitionedStream<TInputOutput, int> partitionedStream2 = new PartitionedStream<TInputOutput, int>(partitionCount, Util.GetDefaultComparer<int>(), OrdinalIndexState);
		for (int i = 0; i < partitionCount; i++)
		{
			partitionedStream2[i] = new IndexedWhereQueryOperatorEnumerator(partitionedStream[i], m_predicate, settings.CancellationState.MergedCancellationToken);
		}
		recipient.Receive(partitionedStream2);
	}

	internal override IEnumerable<TInputOutput> AsSequentialQuery(CancellationToken token)
	{
		IEnumerable<TInputOutput> source = CancellableEnumerable.Wrap(base.Child.AsSequentialQuery(token), token);
		return source.Where(m_predicate);
	}
}
