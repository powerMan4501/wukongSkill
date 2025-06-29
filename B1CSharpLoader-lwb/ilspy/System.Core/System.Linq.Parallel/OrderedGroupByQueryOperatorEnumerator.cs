using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal abstract class OrderedGroupByQueryOperatorEnumerator<TSource, TGroupKey, TElement, TOrderKey> : QueryOperatorEnumerator<IGrouping<TGroupKey, TElement>, TOrderKey>
{
	private class Mutables
	{
		internal HashLookup<Wrapper<TGroupKey>, GroupKeyData> m_hashLookup;

		internal int m_hashLookupIndex;
	}

	protected class GroupKeyData
	{
		internal TOrderKey m_orderKey;

		internal OrderedGroupByGrouping<TGroupKey, TOrderKey, TElement> m_grouping;

		internal GroupKeyData(TOrderKey orderKey, TGroupKey hashKey, IComparer<TOrderKey> orderComparer)
		{
			m_orderKey = orderKey;
			m_grouping = new OrderedGroupByGrouping<TGroupKey, TOrderKey, TElement>(hashKey, orderComparer);
		}
	}

	protected readonly QueryOperatorEnumerator<Pair<TSource, TGroupKey>, TOrderKey> m_source;

	private readonly Func<TSource, TGroupKey> m_keySelector;

	protected readonly IEqualityComparer<TGroupKey> m_keyComparer;

	protected readonly IComparer<TOrderKey> m_orderComparer;

	protected readonly CancellationToken m_cancellationToken;

	private Mutables m_mutables;

	protected OrderedGroupByQueryOperatorEnumerator(QueryOperatorEnumerator<Pair<TSource, TGroupKey>, TOrderKey> source, Func<TSource, TGroupKey> keySelector, IEqualityComparer<TGroupKey> keyComparer, IComparer<TOrderKey> orderComparer, CancellationToken cancellationToken)
	{
		m_source = source;
		m_keySelector = keySelector;
		m_keyComparer = keyComparer;
		m_orderComparer = orderComparer;
		m_cancellationToken = cancellationToken;
	}

	internal override bool MoveNext(ref IGrouping<TGroupKey, TElement> currentElement, ref TOrderKey currentKey)
	{
		Mutables mutables = m_mutables;
		if (mutables == null)
		{
			mutables = (m_mutables = new Mutables());
			mutables.m_hashLookup = BuildHashLookup();
			mutables.m_hashLookupIndex = -1;
		}
		if (++mutables.m_hashLookupIndex < mutables.m_hashLookup.Count)
		{
			GroupKeyData value = mutables.m_hashLookup[mutables.m_hashLookupIndex].Value;
			currentElement = value.m_grouping;
			currentKey = value.m_orderKey;
			return true;
		}
		return false;
	}

	protected abstract HashLookup<Wrapper<TGroupKey>, GroupKeyData> BuildHashLookup();

	protected override void Dispose(bool disposing)
	{
		m_source.Dispose();
	}
}
