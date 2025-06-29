using System.Collections;
using System.Globalization;
using System.Security;

namespace System;

internal sealed class OrdinalRandomizedComparer : StringComparer, IWellKnownStringEqualityComparer
{
	private bool _ignoreCase;

	private long _entropy;

	internal OrdinalRandomizedComparer(bool ignoreCase)
	{
		_ignoreCase = ignoreCase;
		_entropy = HashHelpers.GetEntropy();
	}

	public override int Compare(string x, string y)
	{
		if ((object)x == y)
		{
			return 0;
		}
		if (x == null)
		{
			return -1;
		}
		if (y == null)
		{
			return 1;
		}
		if (_ignoreCase)
		{
			return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
		}
		return string.CompareOrdinal(x, y);
	}

	public override bool Equals(string x, string y)
	{
		if ((object)x == y)
		{
			return true;
		}
		if (x == null || y == null)
		{
			return false;
		}
		if (_ignoreCase)
		{
			if (x.Length != y.Length)
			{
				return false;
			}
			return string.Compare(x, y, StringComparison.OrdinalIgnoreCase) == 0;
		}
		return x.Equals(y);
	}

	[SecuritySafeCritical]
	public override int GetHashCode(string obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (_ignoreCase)
		{
			return TextInfo.GetHashCodeOrdinalIgnoreCase(obj, forceRandomizedHashing: true, _entropy);
		}
		return string.InternalMarvin32HashString(obj, obj.Length, _entropy);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is OrdinalRandomizedComparer ordinalRandomizedComparer))
		{
			return false;
		}
		if (_ignoreCase == ordinalRandomizedComparer._ignoreCase)
		{
			return _entropy == ordinalRandomizedComparer._entropy;
		}
		return false;
	}

	public override int GetHashCode()
	{
		string text = "OrdinalRandomizedComparer";
		int hashCode = text.GetHashCode();
		return (_ignoreCase ? (~hashCode) : hashCode) ^ (int)(_entropy & 0x7FFFFFFF);
	}

	IEqualityComparer IWellKnownStringEqualityComparer.GetRandomizedEqualityComparer()
	{
		return new OrdinalRandomizedComparer(_ignoreCase);
	}

	IEqualityComparer IWellKnownStringEqualityComparer.GetEqualityComparerForSerialization()
	{
		return new OrdinalComparer(_ignoreCase);
	}
}
