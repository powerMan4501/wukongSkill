using System.Collections.Generic;

namespace System.Linq.Parallel;

internal class SortQueryOperatorEnumerator<TInputOutput, TKey, TSortKey> : QueryOperatorEnumerator<TInputOutput, TSortKey>
{
	private readonly QueryOperatorEnumerator<TInputOutput, TKey> m_source;

	private readonly Func<TInputOutput, TSortKey> m_keySelector;

	private readonly IComparer<TSortKey> m_keyComparer;

	public IComparer<TSortKey> KeyComparer => m_keyComparer;

	internal SortQueryOperatorEnumerator(QueryOperatorEnumerator<TInputOutput, TKey> source, Func<TInputOutput, TSortKey> keySelector, IComparer<TSortKey> keyComparer)
	{
		m_source = source;
		m_keySelector = keySelector;
		m_keyComparer = keyComparer;
	}

	internal override bool MoveNext(ref TInputOutput currentElement, ref TSortKey currentKey)
	{
		TKey currentKey2 = default(TKey);
		if (!m_source.MoveNext(ref currentElement, ref currentKey2))
		{
			return false;
		}
		currentKey = m_keySelector(currentElement);
		return true;
	}

	protected override void Dispose(bool disposing)
	{
		m_source.Dispose();
	}
}
