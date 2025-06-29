using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct Double : IComparable, IFormattable, IConvertible, IComparable<double>, IEquatable<double>
{
	internal double m_value;

	[__DynamicallyInvokable]
	public const double MinValue = -1.7976931348623157E+308;

	[__DynamicallyInvokable]
	public const double MaxValue = 1.7976931348623157E+308;

	[__DynamicallyInvokable]
	public const double Epsilon = 5E-324;

	[__DynamicallyInvokable]
	public const double NegativeInfinity = -1.0 / 0.0;

	[__DynamicallyInvokable]
	public const double PositiveInfinity = 1.0 / 0.0;

	[__DynamicallyInvokable]
	public const double NaN = 0.0 / 0.0;

	internal static double NegativeZero = BitConverter.Int64BitsToDouble(long.MinValue);

	[SecuritySafeCritical]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe static bool IsInfinity(double d)
	{
		return (*(long*)(&d) & 0x7FFFFFFFFFFFFFFFL) == 9218868437227405312L;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool IsPositiveInfinity(double d)
	{
		if (d == double.PositiveInfinity)
		{
			return true;
		}
		return false;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool IsNegativeInfinity(double d)
	{
		if (d == double.NegativeInfinity)
		{
			return true;
		}
		return false;
	}

	[SecuritySafeCritical]
	internal unsafe static bool IsNegative(double d)
	{
		return (*(long*)(&d) & long.MinValue) == long.MinValue;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe static bool IsNaN(double d)
	{
		return (ulong)(*(long*)(&d) & 0x7FFFFFFFFFFFFFFFL) > 9218868437227405312uL;
	}

	public int CompareTo(object value)
	{
		if (value == null)
		{
			return 1;
		}
		if (value is double num)
		{
			if (this < num)
			{
				return -1;
			}
			if (this > num)
			{
				return 1;
			}
			if (this == num)
			{
				return 0;
			}
			if (IsNaN(this))
			{
				if (!IsNaN(num))
				{
					return -1;
				}
				return 0;
			}
			return 1;
		}
		throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDouble"));
	}

	[__DynamicallyInvokable]
	public int CompareTo(double value)
	{
		if (this < value)
		{
			return -1;
		}
		if (this > value)
		{
			return 1;
		}
		if (this == value)
		{
			return 0;
		}
		if (IsNaN(this))
		{
			if (!IsNaN(value))
			{
				return -1;
			}
			return 0;
		}
		return 1;
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (!(obj is double num))
		{
			return false;
		}
		if (num == this)
		{
			return true;
		}
		if (IsNaN(num))
		{
			return IsNaN(this);
		}
		return false;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool operator ==(double left, double right)
	{
		return left == right;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool operator !=(double left, double right)
	{
		return left != right;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool operator <(double left, double right)
	{
		return left < right;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool operator >(double left, double right)
	{
		return left > right;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool operator <=(double left, double right)
	{
		return left <= right;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool operator >=(double left, double right)
	{
		return left >= right;
	}

	[__DynamicallyInvokable]
	public bool Equals(double obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (IsNaN(obj))
		{
			return IsNaN(this);
		}
		return false;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override int GetHashCode()
	{
		double num = this;
		if (num == 0.0)
		{
			return 0;
		}
		long num2 = *(long*)(&num);
		return (int)num2 ^ (int)(num2 >> 32);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public override string ToString()
	{
		return Number.FormatDouble(this, null, NumberFormatInfo.CurrentInfo);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(string format)
	{
		return Number.FormatDouble(this, format, NumberFormatInfo.CurrentInfo);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(IFormatProvider provider)
	{
		return Number.FormatDouble(this, null, NumberFormatInfo.GetInstance(provider));
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(string format, IFormatProvider provider)
	{
		return Number.FormatDouble(this, format, NumberFormatInfo.GetInstance(provider));
	}

	[__DynamicallyInvokable]
	public static double Parse(string s)
	{
		return Parse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.CurrentInfo);
	}

	[__DynamicallyInvokable]
	public static double Parse(string s, NumberStyles style)
	{
		NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
		return Parse(s, style, NumberFormatInfo.CurrentInfo);
	}

	[__DynamicallyInvokable]
	public static double Parse(string s, IFormatProvider provider)
	{
		return Parse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.GetInstance(provider));
	}

	[__DynamicallyInvokable]
	public static double Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
		return Parse(s, style, NumberFormatInfo.GetInstance(provider));
	}

	private static double Parse(string s, NumberStyles style, NumberFormatInfo info)
	{
		return Number.ParseDouble(s, style, info);
	}

	[__DynamicallyInvokable]
	public static bool TryParse(string s, out double result)
	{
		return TryParse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.CurrentInfo, out result);
	}

	[__DynamicallyInvokable]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result)
	{
		NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
		return TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
	}

	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out double result)
	{
		if (s == null)
		{
			result = 0.0;
			return false;
		}
		if (!Number.TryParseDouble(s, style, info, out result))
		{
			string text = s.Trim();
			if (text.Equals(info.PositiveInfinitySymbol))
			{
				result = double.PositiveInfinity;
			}
			else if (text.Equals(info.NegativeInfinitySymbol))
			{
				result = double.NegativeInfinity;
			}
			else
			{
				if (!text.Equals(info.NaNSymbol))
				{
					return false;
				}
				result = double.NaN;
			}
		}
		return true;
	}

	public TypeCode GetTypeCode()
	{
		return TypeCode.Double;
	}

	[__DynamicallyInvokable]
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return Convert.ToBoolean(this);
	}

	[__DynamicallyInvokable]
	char IConvertible.ToChar(IFormatProvider provider)
	{
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Double", "Char"));
	}

	[__DynamicallyInvokable]
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return Convert.ToSByte(this);
	}

	[__DynamicallyInvokable]
	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return Convert.ToByte(this);
	}

	[__DynamicallyInvokable]
	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return Convert.ToInt16(this);
	}

	[__DynamicallyInvokable]
	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return Convert.ToUInt16(this);
	}

	[__DynamicallyInvokable]
	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return Convert.ToInt32(this);
	}

	[__DynamicallyInvokable]
	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return Convert.ToUInt32(this);
	}

	[__DynamicallyInvokable]
	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return Convert.ToInt64(this);
	}

	[__DynamicallyInvokable]
	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return Convert.ToUInt64(this);
	}

	[__DynamicallyInvokable]
	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return Convert.ToSingle(this);
	}

	[__DynamicallyInvokable]
	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return this;
	}

	[__DynamicallyInvokable]
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return Convert.ToDecimal(this);
	}

	[__DynamicallyInvokable]
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Double", "DateTime"));
	}

	[__DynamicallyInvokable]
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return Convert.DefaultToType(this, type, provider);
	}
}
