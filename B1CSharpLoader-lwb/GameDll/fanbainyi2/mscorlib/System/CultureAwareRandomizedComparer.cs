using System.Collections;
using System.Globalization;

namespace System;

internal sealed class CultureAwareRandomizedComparer : StringComparer, IWellKnownStringEqualityComparer
{
	private CompareInfo _compareInfo;

	private bool _ignoreCase;

	private long _entropy;

	internal CultureAwareRandomizedComparer(CompareInfo compareInfo, bool ignoreCase)
	{
		_compareInfo = compareInfo;
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
		return _compareInfo.Compare(x, y, _ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None);
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
		return _compareInfo.Compare(x, y, _ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None) == 0;
	}

	public override int GetHashCode(string obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		CompareOptions compareOptions = CompareOptions.None;
		if (_ignoreCase)
		{
			compareOptions |= CompareOptions.IgnoreCase;
		}
		return _compareInfo.GetHashCodeOfString(obj, compareOptions, forceRandomizedHashing: true, _entropy);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is CultureAwareRandomizedComparer cultureAwareRandomizedComparer))
		{
			return false;
		}
		if (_ignoreCase == cultureAwareRandomizedComparer._ignoreCase && _compareInfo.Equals(cultureAwareRandomizedComparer._compareInfo))
		{
			return _entropy == cultureAwareRandomizedComparer._entropy;
		}
		return false;
	}

	public override int GetHashCode()
	{
		int hashCode = _compareInfo.GetHashCode();
		return (_ignoreCase ? (~hashCode) : hashCode) ^ (int)(_entropy & 0x7FFFFFFF);
	}

	IEqualityComparer IWellKnownStringEqualityComparer.GetRandomizedEqualityComparer()
	{
		return new CultureAwareRandomizedComparer(_compareInfo, _ignoreCase);
	}

	IEqualityComparer IWellKnownStringEqualityComparer.GetEqualityComparerForSerialization()
	{
		return new CultureAwareComparer(_compareInfo, _ignoreCase);
	}
}
