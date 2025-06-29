using System.Collections;
using System.Collections.Generic;

namespace System.Linq.Parallel;

internal class OrderedGroupByGrouping<TGroupKey, TOrderKey, TElement> : IGrouping<TGroupKey, TElement>, IEnumerable<TElement>, IEnumerable
{
	private TGroupKey m_groupKey;

	private GrowingArray<TElement> m_values;

	private GrowingArray<TOrderKey> m_orderKeys;

	private IComparer<TOrderKey> m_orderComparer;

	TGroupKey IGrouping<TGroupKey, TElement>.Key => m_groupKey;

	internal OrderedGroupByGrouping(TGroupKey groupKey, IComparer<TOrderKey> orderComparer)
	{
		m_groupKey = groupKey;
		m_values = new GrowingArray<TElement>();
		m_orderKeys = new GrowingArray<TOrderKey>();
		m_orderComparer = orderComparer;
	}

	IEnumerator<TElement> IEnumerable<TElement>.GetEnumerator()
	{
		int valueCount = m_values.Count;
		TElement[] valueArray = m_values.InternalArray;
		for (int i = 0; i < valueCount; i++)
		{
			yield return valueArray[i];
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<TElement>)this).GetEnumerator();
	}

	internal void Add(TElement value, TOrderKey orderKey)
	{
		m_values.Add(value);
		m_orderKeys.Add(orderKey);
	}

	internal void DoneAdding()
	{
		Array.Sort(m_orderKeys.InternalArray, m_values.InternalArray, 0, m_values.Count, m_orderComparer);
	}
}
