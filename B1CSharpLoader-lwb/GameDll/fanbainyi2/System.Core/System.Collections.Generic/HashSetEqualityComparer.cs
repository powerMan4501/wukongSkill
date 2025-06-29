namespace System.Collections.Generic;

[Serializable]
internal class HashSetEqualityComparer<T> : IEqualityComparer<HashSet<T>>
{
	private IEqualityComparer<T> m_comparer;

	public HashSetEqualityComparer()
	{
		m_comparer = EqualityComparer<T>.Default;
	}

	public HashSetEqualityComparer(IEqualityComparer<T> comparer)
	{
		if (comparer == null)
		{
			m_comparer = EqualityComparer<T>.Default;
		}
		else
		{
			m_comparer = comparer;
		}
	}

	public bool Equals(HashSet<T> x, HashSet<T> y)
	{
		return HashSet<T>.HashSetEquals(x, y, m_comparer);
	}

	public int GetHashCode(HashSet<T> obj)
	{
		int num = 0;
		if (obj != null)
		{
			foreach (T item in obj)
			{
				num ^= m_comparer.GetHashCode(item) & 0x7FFFFFFF;
			}
		}
		return num;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is HashSetEqualityComparer<T> hashSetEqualityComparer))
		{
			return false;
		}
		return m_comparer == hashSetEqualityComparer.m_comparer;
	}

	public override int GetHashCode()
	{
		return m_comparer.GetHashCode();
	}
}
