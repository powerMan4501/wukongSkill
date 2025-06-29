using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;

namespace System;

[Serializable]
[CLSCompliant(false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct SByte : IComparable, IFormattable, IConvertible, IComparable<sbyte>, IEquatable<sbyte>
{
	private sbyte m_value;

	[__DynamicallyInvokable]
	public const sbyte MaxValue = 127;

	[__DynamicallyInvokable]
	public const sbyte MinValue = -128;

	public int CompareTo(object obj)
	{
		if (obj == null)
		{
			return 1;
		}
		if (!(obj is sbyte))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeSByte"));
		}
		return this - (sbyte)obj;
	}

	[__DynamicallyInvokable]
	public int CompareTo(sbyte value)
	{
		return this - value;
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (!(obj is sbyte))
		{
			return false;
		}
		return this == (sbyte)obj;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public bool Equals(sbyte obj)
	{
		return this == obj;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return this ^ (this << 8);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public override string ToString()
	{
		return Number.FormatInt32(this, null, NumberFormatInfo.CurrentInfo);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(IFormatProvider provider)
	{
		return Number.FormatInt32(this, null, NumberFormatInfo.GetInstance(provider));
	}

	[__DynamicallyInvokable]
	public string ToString(string format)
	{
		return ToString(format, NumberFormatInfo.CurrentInfo);
	}

	[__DynamicallyInvokable]
	public string ToString(string format, IFormatProvider provider)
	{
		return ToString(format, NumberFormatInfo.GetInstance(provider));
	}

	[SecuritySafeCritical]
	private string ToString(string format, NumberFormatInfo info)
	{
		if (this < 0 && format != null && format.Length > 0 && (format[0] == 'X' || format[0] == 'x'))
		{
			uint value = (uint)(this & 0xFF);
			return Number.FormatUInt32(value, format, info);
		}
		return Number.FormatInt32(this, format, info);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte Parse(string s)
	{
		return Parse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte Parse(string s, NumberStyles style)
	{
		NumberFormatInfo.ValidateParseStyleInteger(style);
		return Parse(s, style, NumberFormatInfo.CurrentInfo);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte Parse(string s, IFormatProvider provider)
	{
		return Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		NumberFormatInfo.ValidateParseStyleInteger(style);
		return Parse(s, style, NumberFormatInfo.GetInstance(provider));
	}

	private static sbyte Parse(string s, NumberStyles style, NumberFormatInfo info)
	{
		int num = 0;
		try
		{
			num = Number.ParseInt32(s, style, info);
		}
		catch (OverflowException innerException)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_SByte"), innerException);
		}
		if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
		{
			if (num < 0 || num > 255)
			{
				throw new OverflowException(Environment.GetResourceString("Overflow_SByte"));
			}
			return (sbyte)num;
		}
		if (num < -128 || num > 127)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_SByte"));
		}
		return (sbyte)num;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static bool TryParse(string s, out sbyte result)
	{
		return TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out sbyte result)
	{
		NumberFormatInfo.ValidateParseStyleInteger(style);
		return TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
	}

	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out sbyte result)
	{
		result = 0;
		if (!Number.TryParseInt32(s, style, info, out var result2))
		{
			return false;
		}
		if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
		{
			if (result2 < 0 || result2 > 255)
			{
				return false;
			}
			result = (sbyte)result2;
			return true;
		}
		if (result2 < -128 || result2 > 127)
		{
			return false;
		}
		result = (sbyte)result2;
		return true;
	}

	public TypeCode GetTypeCode()
	{
		return TypeCode.SByte;
	}

	[__DynamicallyInvokable]
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return Convert.ToBoolean(this);
	}

	[__DynamicallyInvokable]
	char IConvertible.ToChar(IFormatProvider provider)
	{
		return Convert.ToChar(this);
	}

	[__DynamicallyInvokable]
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return this;
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
		return this;
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
		return Convert.ToDouble(this);
	}

	[__DynamicallyInvokable]
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return Convert.ToDecimal(this);
	}

	[__DynamicallyInvokable]
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "SByte", "DateTime"));
	}

	[__DynamicallyInvokable]
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return Convert.DefaultToType(this, type, provider);
	}
}
