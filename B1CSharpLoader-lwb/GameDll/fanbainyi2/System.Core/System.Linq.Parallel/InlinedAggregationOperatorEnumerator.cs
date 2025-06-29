using System.Threading;

namespace System.Linq.Parallel;

internal abstract class InlinedAggregationOperatorEnumerator<TIntermediate> : QueryOperatorEnumerator<TIntermediate, int>
{
	private int m_partitionIndex;

	private bool m_done;

	protected CancellationToken m_cancellationToken;

	internal InlinedAggregationOperatorEnumerator(int partitionIndex, CancellationToken cancellationToken)
	{
		m_partitionIndex = partitionIndex;
		m_cancellationToken = cancellationToken;
	}

	internal sealed override bool MoveNext(ref TIntermediate currentElement, ref int currentKey)
	{
		if (!m_done && MoveNextCore(ref currentElement))
		{
			currentKey = m_partitionIndex;
			m_done = true;
			return true;
		}
		return false;
	}

	protected abstract bool MoveNextCore(ref TIntermediate currentElement);
}
