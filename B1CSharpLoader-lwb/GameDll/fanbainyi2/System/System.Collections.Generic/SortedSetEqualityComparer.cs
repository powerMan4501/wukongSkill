namespace System.Collections.Generic;

internal class SortedSetEqualityComparer<T> : IEqualityComparer<SortedSet<T>>
{
	private IComparer<T> comparer;

	private IEqualityComparer<T> e_comparer;

	public SortedSetEqualityComparer()
		: this((IComparer<T>)null, (IEqualityComparer<T>)null)
	{
	}

	public SortedSetEqualityComparer(IComparer<T> comparer)
		: this(comparer, (IEqualityComparer<T>)null)
	{
	}

	public SortedSetEqualityComparer(IEqualityComparer<T> memberEqualityComparer)
		: this((IComparer<T>)null, memberEqualityComparer)
	{
	}

	public SortedSetEqualityComparer(IComparer<T> comparer, IEqualityComparer<T> memberEqualityComparer)
	{
		if (comparer == null)
		{
			this.comparer = Comparer<T>.Default;
		}
		else
		{
			this.comparer = comparer;
		}
		if (memberEqualityComparer == null)
		{
			e_comparer = EqualityComparer<T>.Default;
		}
		else
		{
			e_comparer = memberEqualityComparer;
		}
	}

	public bool Equals(SortedSet<T> x, SortedSet<T> y)
	{
		return SortedSet<T>.SortedSetEquals(x, y, comparer);
	}

	public int GetHashCode(SortedSet<T> obj)
	{
		int num = 0;
		if (obj != null)
		{
			foreach (T item in obj)
			{
				num ^= e_comparer.GetHashCode(item) & 0x7FFFFFFF;
			}
		}
		return num;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is SortedSetEqualityComparer<T> sortedSetEqualityComparer))
		{
			return false;
		}
		return comparer == sortedSetEqualityComparer.comparer;
	}

	public override int GetHashCode()
	{
		return comparer.GetHashCode() ^ e_comparer.GetHashCode();
	}
}
