using System.Collections.Generic;

namespace System.Linq.Parallel;

internal struct WrapperEqualityComparer<T> : IEqualityComparer<Wrapper<T>>
{
	private IEqualityComparer<T> m_comparer;

	internal WrapperEqualityComparer(IEqualityComparer<T> comparer)
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

	public bool Equals(Wrapper<T> x, Wrapper<T> y)
	{
		return m_comparer.Equals(x.Value, y.Value);
	}

	public int GetHashCode(Wrapper<T> x)
	{
		return m_comparer.GetHashCode(x.Value);
	}
}
