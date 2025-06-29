using System.Security;

namespace System.Collections.Generic;

internal sealed class RandomizedStringEqualityComparer : IEqualityComparer<string>, IEqualityComparer, IWellKnownStringEqualityComparer
{
	private long _entropy;

	public RandomizedStringEqualityComparer()
	{
		_entropy = HashHelpers.GetEntropy();
	}

	public new bool Equals(object x, object y)
	{
		if (x == y)
		{
			return true;
		}
		if (x == null || y == null)
		{
			return false;
		}
		if (x is string && y is string)
		{
			return Equals((string)x, (string)y);
		}
		ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_InvalidArgumentForComparison);
		return false;
	}

	public bool Equals(string x, string y)
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
	public int GetHashCode(string obj)
	{
		if (obj == null)
		{
			return 0;
		}
		return string.InternalMarvin32HashString(obj, obj.Length, _entropy);
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
		if (obj is RandomizedStringEqualityComparer randomizedStringEqualityComparer)
		{
			return _entropy == randomizedStringEqualityComparer._entropy;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return GetType().Name.GetHashCode() ^ (int)(_entropy & 0x7FFFFFFF);
	}

	IEqualityComparer IWellKnownStringEqualityComparer.GetRandomizedEqualityComparer()
	{
		return new RandomizedStringEqualityComparer();
	}

	IEqualityComparer IWellKnownStringEqualityComparer.GetEqualityComparerForSerialization()
	{
		return EqualityComparer<string>.Default;
	}
}
