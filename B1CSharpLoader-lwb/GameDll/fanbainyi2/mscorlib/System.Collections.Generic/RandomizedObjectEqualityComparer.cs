using System.Security;

namespace System.Collections.Generic;

internal sealed class RandomizedObjectEqualityComparer : IEqualityComparer, IWellKnownStringEqualityComparer
{
	private long _entropy;

	public RandomizedObjectEqualityComparer()
	{
		_entropy = HashHelpers.GetEntropy();
	}

	public new bool Equals(object x, object y)
	{
		if (x != null)
		{
			if (y != null)
			{
				return x.Equals(y);
			}
			return false;
		}
		if (y != null)
		{
			return false;
		}
		return true;
	}

	[SecuritySafeCritical]
	public int GetHashCode(object obj)
	{
		if (obj == null)
		{
			return 0;
		}
		if (obj is string text)
		{
			return string.InternalMarvin32HashString(text, text.Length, _entropy);
		}
		return obj.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (obj is RandomizedObjectEqualityComparer randomizedObjectEqualityComparer)
		{
			return _entropy == randomizedObjectEqualityComparer._entropy;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return GetType().Name.GetHashCode() ^ (int)(_entropy & 0x7FFFFFFF);
	}

	IEqualityComparer IWellKnownStringEqualityComparer.GetRandomizedEqualityComparer()
	{
		return new RandomizedObjectEqualityComparer();
	}

	IEqualityComparer IWellKnownStringEqualityComparer.GetEqualityComparerForSerialization()
	{
		return null;
	}
}
