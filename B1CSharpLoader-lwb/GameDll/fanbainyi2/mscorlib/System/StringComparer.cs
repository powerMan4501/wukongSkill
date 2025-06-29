using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string>
{
	private static readonly StringComparer _invariantCulture = new CultureAwareComparer(CultureInfo.InvariantCulture, ignoreCase: false);

	private static readonly StringComparer _invariantCultureIgnoreCase = new CultureAwareComparer(CultureInfo.InvariantCulture, ignoreCase: true);

	private static readonly StringComparer _ordinal = new OrdinalComparer(ignoreCase: false);

	private static readonly StringComparer _ordinalIgnoreCase = new OrdinalComparer(ignoreCase: true);

	public static StringComparer InvariantCulture => _invariantCulture;

	public static StringComparer InvariantCultureIgnoreCase => _invariantCultureIgnoreCase;

	[__DynamicallyInvokable]
	public static StringComparer CurrentCulture
	{
		[__DynamicallyInvokable]
		get
		{
			return new CultureAwareComparer(CultureInfo.CurrentCulture, ignoreCase: false);
		}
	}

	[__DynamicallyInvokable]
	public static StringComparer CurrentCultureIgnoreCase
	{
		[__DynamicallyInvokable]
		get
		{
			return new CultureAwareComparer(CultureInfo.CurrentCulture, ignoreCase: true);
		}
	}

	[__DynamicallyInvokable]
	public static StringComparer Ordinal
	{
		[__DynamicallyInvokable]
		get
		{
			return _ordinal;
		}
	}

	[__DynamicallyInvokable]
	public static StringComparer OrdinalIgnoreCase
	{
		[__DynamicallyInvokable]
		get
		{
			return _ordinalIgnoreCase;
		}
	}

	[__DynamicallyInvokable]
	public static StringComparer Create(CultureInfo culture, bool ignoreCase)
	{
		if (culture == null)
		{
			throw new ArgumentNullException("culture");
		}
		return new CultureAwareComparer(culture, ignoreCase);
	}

	public int Compare(object x, object y)
	{
		if (x == y)
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
		if (x is string x2 && y is string y2)
		{
			return Compare(x2, y2);
		}
		if (x is IComparable comparable)
		{
			return comparable.CompareTo(y);
		}
		throw new ArgumentException(Environment.GetResourceString("Argument_ImplementIComparable"));
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
		if (x is string x2 && y is string y2)
		{
			return Equals(x2, y2);
		}
		return x.Equals(y);
	}

	public int GetHashCode(object obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (obj is string obj2)
		{
			return GetHashCode(obj2);
		}
		return obj.GetHashCode();
	}

	[__DynamicallyInvokable]
	public abstract int Compare(string x, string y);

	[__DynamicallyInvokable]
	public abstract bool Equals(string x, string y);

	[__DynamicallyInvokable]
	public abstract int GetHashCode(string obj);

	[__DynamicallyInvokable]
	protected StringComparer()
	{
	}
}
