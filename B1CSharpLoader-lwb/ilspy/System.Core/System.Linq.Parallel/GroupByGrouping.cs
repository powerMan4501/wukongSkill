using System.Collections;
using System.Collections.Generic;

namespace System.Linq.Parallel;

internal class GroupByGrouping<TGroupKey, TElement> : IGrouping<TGroupKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	private KeyValuePair<Wrapper<TGroupKey>, ListChunk<TElement>> m_keyValues;

	TGroupKey IGrouping<TGroupKey, TElement>.Key => m_keyValues.Key.Value;

	internal GroupByGrouping(KeyValuePair<Wrapper<TGroupKey>, ListChunk<TElement>> keyValues)
	{
		m_keyValues = keyValues;
	}

	IEnumerator<TElement> IEnumerable<TElement>.GetEnumerator()
	{
		return m_keyValues.Value.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<TElement>)this).GetEnumerator();
	}
}
