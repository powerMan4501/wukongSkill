using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal sealed class OrderedGroupByIdentityQueryOperatorEnumerator<TSource, TGroupKey, TOrderKey> : OrderedGroupByQueryOperatorEnumerator<TSource, TGroupKey, TSource, TOrderKey>
{
	internal OrderedGroupByIdentityQueryOperatorEnumerator(QueryOperatorEnumerator<Pair<TSource, TGroupKey>, TOrderKey> source, Func<TSource, TGroupKey> keySelector, IEqualityComparer<TGroupKey> keyComparer, IComparer<TOrderKey> orderComparer, CancellationToken cancellationToken)
		: base(source, keySelector, keyComparer, orderComparer, cancellationToken)
	{
	}

	protected override HashLookup<Wrapper<TGroupKey>, GroupKeyData> BuildHashLookup()
	{
		HashLookup<Wrapper<TGroupKey>, GroupKeyData> hashLookup = new HashLookup<Wrapper<TGroupKey>, GroupKeyData>(new WrapperEqualityComparer<TGroupKey>(m_keyComparer));
		Pair<TSource, TGroupKey> currentElement = default(Pair<TSource, TGroupKey>);
		TOrderKey currentKey = default(TOrderKey);
		int num = 0;
		while (m_source.MoveNext(ref currentElement, ref currentKey))
		{
			if ((num++ & 0x3F) == 0)
			{
				CancellationState.ThrowIfCanceled(m_cancellationToken);
			}
			Wrapper<TGroupKey> key = new Wrapper<TGroupKey>(currentElement.Second);
			GroupKeyData value = null;
			if (hashLookup.TryGetValue(key, ref value))
			{
				if (m_orderComparer.Compare(currentKey, value.m_orderKey) < 0)
				{
					value.m_orderKey = currentKey;
				}
			}
			else
			{
				value = new GroupKeyData(currentKey, key.Value, m_orderComparer);
				hashLookup.Add(key, value);
			}
			value.m_grouping.Add(currentElement.First, currentKey);
		}
		for (int i = 0; i < hashLookup.Count; i++)
		{
			hashLookup[i].Value.m_grouping.DoneAdding();
		}
		return hashLookup;
	}
}
