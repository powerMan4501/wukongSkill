using System.Collections.Generic;

namespace System.Linq.Parallel;

internal abstract class HashRepartitionStream<TInputOutput, THashKey, TOrderKey> : PartitionedStream<Pair<TInputOutput, THashKey>, TOrderKey>
{
	private readonly IEqualityComparer<THashKey> m_keyComparer;

	private readonly IEqualityComparer<TInputOutput> m_elementComparer;

	private readonly int m_distributionMod;

	private const int NULL_ELEMENT_HASH_CODE = 0;

	internal HashRepartitionStream(int partitionsCount, IComparer<TOrderKey> orderKeyComparer, IEqualityComparer<THashKey> hashKeyComparer, IEqualityComparer<TInputOutput> elementComparer)
		: base(partitionsCount, orderKeyComparer, OrdinalIndexState.Shuffled)
	{
		m_keyComparer = hashKeyComparer;
		m_elementComparer = elementComparer;
		checked
		{
			for (m_distributionMod = 503; m_distributionMod < partitionsCount; m_distributionMod *= 2)
			{
			}
		}
	}

	internal int GetHashCode(TInputOutput element)
	{
		return (0x7FFFFFFF & ((m_elementComparer != null) ? m_elementComparer.GetHashCode(element) : (element?.GetHashCode() ?? 0))) % m_distributionMod;
	}

	internal int GetHashCode(THashKey key)
	{
		return (0x7FFFFFFF & ((m_keyComparer != null) ? m_keyComparer.GetHashCode(key) : (key?.GetHashCode() ?? 0))) % m_distributionMod;
	}
}
