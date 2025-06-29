namespace System.Collections.Generic;

[Serializable]
internal class GenericComparer<T> : Comparer<T> where T : IComparable<T>
{
	public override int Compare(T x, T y)
	{
		if (x != null)
		{
			if (y != null)
			{
				return x.CompareTo(y);
			}
			return 1;
		}
		if (y != null)
		{
			return -1;
		}
		return 0;
	}

	public override bool Equals(object obj)
	{
		GenericComparer<T> genericComparer = obj as GenericComparer<T>;
		return genericComparer != null;
	}

	public override int GetHashCode()
	{
		return GetType().Name.GetHashCode();
	}
}
