using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;

namespace System;

[Serializable]
[CLSCompliant(false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct UInt16 : IComparable, IFormattable, IConvertible, IComparable<ushort>, IEquatable<ushort>
{
	private ushort m_value;

	[__DynamicallyInvokable]
	public const ushort MaxValue = 65535;

	[__DynamicallyInvokable]
	public const ushort MinValue = 0;

	public int CompareTo(object value)
	{
		if (value == null)
		{
			return 1;
		}
		if (value is ushort)
		{
			return this - (ushort)value;
		}
		throw new ArgumentException(Environment.GetResourceString("Arg_MustBeUInt16"));
	}

	[__DynamicallyInvokable]
	public int CompareTo(ushort value)
	{
		return this - value;
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (!(obj is ushort))
		{
			return false;
		}
		return this == (ushort)obj;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public bool Equals(ushort obj)
	{
		return this == obj;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return this;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public override string ToString()
	{
		return Number.FormatUInt32(this, null, NumberFormatInfo.CurrentInfo);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(IFormatProvider provider)
	{
		return Number.FormatUInt32(this, null, NumberFormatInfo.GetInstance(provider));
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(string format)
	{
		return Number.FormatUInt32(this, format, NumberFormatInfo.CurrentInfo);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(string format, IFormatProvider provider)
	{
		return Number.FormatUInt32(this, format, NumberFormatInfo.GetInstance(provider));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort Parse(string s)
	{
		return Parse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort Parse(string s, NumberStyles style)
	{
		NumberFormatInfo.ValidateParseStyleInteger(style);
		return Parse(s, style, NumberFormatInfo.CurrentInfo);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort Parse(string s, IFormatProvider provider)
	{
		return Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		NumberFormatInfo.ValidateParseStyleInteger(style);
		return Parse(s, style, NumberFormatInfo.GetInstance(provider));
	}

	private static ushort Parse(string s, NumberStyles style, NumberFormatInfo info)
	{
		uint num = 0u;
		try
		{
			num = Number.ParseUInt32(s, style, info);
		}
		catch (OverflowException innerException)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt16"), innerException);
		}
		if (num > 65535)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt16"));
		}
		return (ushort)num;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static bool TryParse(string s, out ushort result)
	{
		return TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out ushort result)
	{
		NumberFormatInfo.ValidateParseStyleInteger(style);
		return TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
	}

	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out ushort result)
	{
		result = 0;
		if (!Number.TryParseUInt32(s, style, info, out var result2))
		{
			return false;
		}
		if (result2 > 65535)
		{
			return false;
		}
		result = (ushort)result2;
		return true;
	}

	public TypeCode GetTypeCode()
	{
		return TypeCode.UInt16;
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
		return this;
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
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "UInt16", "DateTime"));
	}

	[__DynamicallyInvokable]
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return Convert.DefaultToType(this, type, provider);
	}
}
