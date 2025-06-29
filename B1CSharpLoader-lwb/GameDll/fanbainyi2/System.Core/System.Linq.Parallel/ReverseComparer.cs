using System.Collections.Generic;

namespace System.Linq.Parallel;

internal class ReverseComparer<T> : IComparer<T>
{
	private IComparer<T> m_comparer;

	internal ReverseComparer(IComparer<T> comparer)
	{
		m_comparer = comparer;
	}

	public int Compare(T x, T y)
	{
		return -m_comparer.Compare(x, y);
	}
}
