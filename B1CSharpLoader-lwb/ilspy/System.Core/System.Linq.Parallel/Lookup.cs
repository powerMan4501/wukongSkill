using System.Collections;
using System.Collections.Generic;

namespace System.Linq.Parallel;

internal class Lookup<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	private IDictionary<TKey, IGrouping<TKey, TElement>> m_dict;

	private IEqualityComparer<TKey> m_comparer;

	private IGrouping<TKey, TElement> m_defaultKeyGrouping;

	public int Count
	{
		get
		{
			int num = m_dict.Count;
			if (m_defaultKeyGrouping != null)
			{
				num++;
			}
			return num;
		}
	}

	public IEnumerable<TElement> this[TKey key]
	{
		get
		{
			if (m_comparer.Equals(key, default(TKey)))
			{
				if (m_defaultKeyGrouping != null)
				{
					return m_defaultKeyGrouping;
				}
				return Enumerable.Empty<TElement>();
			}
			if (m_dict.TryGetValue(key, out var value))
			{
				return value;
			}
			return Enumerable.Empty<TElement>();
		}
	}

	internal Lookup(IEqualityComparer<TKey> comparer)
	{
		m_comparer = comparer;
		m_dict = new Dictionary<TKey, IGrouping<TKey, TElement>>(m_comparer);
	}

	public bool Contains(TKey key)
	{
		if (m_comparer.Equals(key, default(TKey)))
		{
			return m_defaultKeyGrouping != null;
		}
		return m_dict.ContainsKey(key);
	}

	internal void Add(IGrouping<TKey, TElement> grouping)
	{
		if (m_comparer.Equals(grouping.Key, default(TKey)))
		{
			m_defaultKeyGrouping = grouping;
		}
		else
		{
			m_dict.Add(grouping.Key, grouping);
		}
	}

	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		foreach (IGrouping<TKey, TElement> value in m_dict.Values)
		{
			yield return value;
		}
		if (m_defaultKeyGrouping != null)
		{
			yield return m_defaultKeyGrouping;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<IGrouping<TKey, TElement>>)this).GetEnumerator();
	}
}
