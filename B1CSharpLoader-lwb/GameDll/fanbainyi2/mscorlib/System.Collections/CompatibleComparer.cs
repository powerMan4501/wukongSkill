namespace System.Collections;

[Serializable]
internal class CompatibleComparer : IEqualityComparer
{
	private IComparer _comparer;

	private IHashCodeProvider _hcp;

	internal IComparer Comparer => _comparer;

	internal IHashCodeProvider HashCodeProvider => _hcp;

	internal CompatibleComparer(IComparer comparer, IHashCodeProvider hashCodeProvider)
	{
		_comparer = comparer;
		_hcp = hashCodeProvider;
	}

	public int Compare(object a, object b)
	{
		if (a == b)
		{
			return 0;
		}
		if (a == null)
		{
			return -1;
		}
		if (b == null)
		{
			return 1;
		}
		if (_comparer != null)
		{
			return _comparer.Compare(a, b);
		}
		if (a is IComparable comparable)
		{
			return comparable.CompareTo(b);
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_ImplementIComparable"));
	}

	public new bool Equals(object a, object b)
	{
		return Compare(a, b) == 0;
	}

	public int GetHashCode(object obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (_hcp != null)
		{
			return _hcp.GetHashCode(obj);
		}
		return obj.GetHashCode();
	}
}
