using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct Byte : IComparable, IFormattable, IConvertible, IComparable<byte>, IEquatable<byte>
{
	private byte m_value;

	[__DynamicallyInvokable]
	public const byte MaxValue = 255;

	[__DynamicallyInvokable]
	public const byte MinValue = 0;

	public int CompareTo(object value)
	{
		if (value == null)
		{
			return 1;
		}
		if (!(value is byte))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeByte"));
		}
		return this - (byte)value;
	}

	[__DynamicallyInvokable]
	public int CompareTo(byte value)
	{
		return this - value;
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (!(obj is byte))
		{
			return false;
		}
		return this == (byte)obj;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public bool Equals(byte obj)
	{
		return this == obj;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return this;
	}

	[__DynamicallyInvokable]
	public static byte Parse(string s)
	{
		return Parse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
	}

	[__DynamicallyInvokable]
	public static byte Parse(string s, NumberStyles style)
	{
		NumberFormatInfo.ValidateParseStyleInteger(style);
		return Parse(s, style, NumberFormatInfo.CurrentInfo);
	}

	[__DynamicallyInvokable]
	public static byte Parse(string s, IFormatProvider provider)
	{
		return Parse(s, NumberStyles.Integer, NumberFormatInfo.GetInstance(provider));
	}

	[__DynamicallyInvokable]
	public static byte Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		NumberFormatInfo.ValidateParseStyleInteger(style);
		return Parse(s, style, NumberFormatInfo.GetInstance(provider));
	}

	private static byte Parse(string s, NumberStyles style, NumberFormatInfo info)
	{
		int num = 0;
		try
		{
			num = Number.ParseInt32(s, style, info);
		}
		catch (OverflowException innerException)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Byte"), innerException);
		}
		if (num < 0 || num > 255)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Byte"));
		}
		return (byte)num;
	}

	[__DynamicallyInvokable]
	public static bool TryParse(string s, out byte result)
	{
		return TryParse(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
	}

	[__DynamicallyInvokable]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out byte result)
	{
		NumberFormatInfo.ValidateParseStyleInteger(style);
		return TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
	}

	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out byte result)
	{
		result = 0;
		if (!Number.TryParseInt32(s, style, info, out var result2))
		{
			return false;
		}
		if (result2 < 0 || result2 > 255)
		{
			return false;
		}
		result = (byte)result2;
		return true;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public override string ToString()
	{
		return Number.FormatInt32(this, null, NumberFormatInfo.CurrentInfo);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(string format)
	{
		return Number.FormatInt32(this, format, NumberFormatInfo.CurrentInfo);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(IFormatProvider provider)
	{
		return Number.FormatInt32(this, null, NumberFormatInfo.GetInstance(provider));
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(string format, IFormatProvider provider)
	{
		return Number.FormatInt32(this, format, NumberFormatInfo.GetInstance(provider));
	}

	public TypeCode GetTypeCode()
	{
		return TypeCode.Byte;
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
		return this;
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
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Byte", "DateTime"));
	}

	[__DynamicallyInvokable]
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return Convert.DefaultToType(this, type, provider);
	}
}
