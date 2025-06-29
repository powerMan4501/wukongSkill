using System.Collections.Generic;

namespace System.Linq.Parallel;

internal class PartitionedStream<TElement, TKey>
{
	protected QueryOperatorEnumerator<TElement, TKey>[] m_partitions;

	private readonly IComparer<TKey> m_keyComparer;

	private readonly OrdinalIndexState m_indexState;

	internal QueryOperatorEnumerator<TElement, TKey> this[int index]
	{
		get
		{
			return m_partitions[index];
		}
		set
		{
			m_partitions[index] = value;
		}
	}

	public int PartitionCount => m_partitions.Length;

	internal IComparer<TKey> KeyComparer => m_keyComparer;

	internal OrdinalIndexState OrdinalIndexState => m_indexState;

	internal PartitionedStream(int partitionCount, IComparer<TKey> keyComparer, OrdinalIndexState indexState)
	{
		m_partitions = new QueryOperatorEnumerator<TElement, TKey>[partitionCount];
		m_keyComparer = keyComparer;
		m_indexState = indexState;
	}
}
