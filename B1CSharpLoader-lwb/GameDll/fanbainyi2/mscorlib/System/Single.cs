using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct Single : IComparable, IFormattable, IConvertible, IComparable<float>, IEquatable<float>
{
	internal float m_value;

	[__DynamicallyInvokable]
	public const float MinValue = -3.4028235E+38f;

	[__DynamicallyInvokable]
	public const float Epsilon = 1E-45f;

	[__DynamicallyInvokable]
	public const float MaxValue = 3.4028235E+38f;

	[__DynamicallyInvokable]
	public const float PositiveInfinity = 1f / 0f;

	[__DynamicallyInvokable]
	public const float NegativeInfinity = -1f / 0f;

	[__DynamicallyInvokable]
	public const float NaN = 0f / 0f;

	[SecuritySafeCritical]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe static bool IsInfinity(float f)
	{
		return (*(int*)(&f) & 0x7FFFFFFF) == 2139095040;
	}

	[SecuritySafeCritical]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe static bool IsPositiveInfinity(float f)
	{
		return *(int*)(&f) == 2139095040;
	}

	[SecuritySafeCritical]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe static bool IsNegativeInfinity(float f)
	{
		return *(int*)(&f) == -8388608;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SecuritySafeCritical]
	[NonVersionable]
	[__DynamicallyInvokable]
	public unsafe static bool IsNaN(float f)
	{
		return (*(int*)(&f) & 0x7FFFFFFF) > 2139095040;
	}

	public int CompareTo(object value)
	{
		if (value == null)
		{
			return 1;
		}
		if (value is float num)
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
		throw new ArgumentException(Environment.GetResourceString("Arg_MustBeSingle"));
	}

	[__DynamicallyInvokable]
	public int CompareTo(float value)
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

	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool operator ==(float left, float right)
	{
		return left == right;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool operator !=(float left, float right)
	{
		return left != right;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool operator <(float left, float right)
	{
		return left < right;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool operator >(float left, float right)
	{
		return left > right;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool operator <=(float left, float right)
	{
		return left <= right;
	}

	[NonVersionable]
	[__DynamicallyInvokable]
	public static bool operator >=(float left, float right)
	{
		return left >= right;
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (!(obj is float num))
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

	[__DynamicallyInvokable]
	public bool Equals(float obj)
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
		float num = this;
		if (num == 0f)
		{
			return 0;
		}
		return *(int*)(&num);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public override string ToString()
	{
		return Number.FormatSingle(this, null, NumberFormatInfo.CurrentInfo);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(IFormatProvider provider)
	{
		return Number.FormatSingle(this, null, NumberFormatInfo.GetInstance(provider));
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(string format)
	{
		return Number.FormatSingle(this, format, NumberFormatInfo.CurrentInfo);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(string format, IFormatProvider provider)
	{
		return Number.FormatSingle(this, format, NumberFormatInfo.GetInstance(provider));
	}

	[__DynamicallyInvokable]
	public static float Parse(string s)
	{
		return Parse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.CurrentInfo);
	}

	[__DynamicallyInvokable]
	public static float Parse(string s, NumberStyles style)
	{
		NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
		return Parse(s, style, NumberFormatInfo.CurrentInfo);
	}

	[__DynamicallyInvokable]
	public static float Parse(string s, IFormatProvider provider)
	{
		return Parse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.GetInstance(provider));
	}

	[__DynamicallyInvokable]
	public static float Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
		return Parse(s, style, NumberFormatInfo.GetInstance(provider));
	}

	private static float Parse(string s, NumberStyles style, NumberFormatInfo info)
	{
		return Number.ParseSingle(s, style, info);
	}

	[__DynamicallyInvokable]
	public static bool TryParse(string s, out float result)
	{
		return TryParse(s, NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.CurrentInfo, out result);
	}

	[__DynamicallyInvokable]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result)
	{
		NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
		return TryParse(s, style, NumberFormatInfo.GetInstance(provider), out result);
	}

	private static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result)
	{
		if (s == null)
		{
			result = 0f;
			return false;
		}
		if (!Number.TryParseSingle(s, style, info, out result))
		{
			string text = s.Trim();
			if (text.Equals(info.PositiveInfinitySymbol))
			{
				result = float.PositiveInfinity;
			}
			else if (text.Equals(info.NegativeInfinitySymbol))
			{
				result = float.NegativeInfinity;
			}
			else
			{
				if (!text.Equals(info.NaNSymbol))
				{
					return false;
				}
				result = float.NaN;
			}
		}
		return true;
	}

	public TypeCode GetTypeCode()
	{
		return TypeCode.Single;
	}

	[__DynamicallyInvokable]
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return Convert.ToBoolean(this);
	}

	[__DynamicallyInvokable]
	char IConvertible.ToChar(IFormatProvider provider)
	{
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Single", "Char"));
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
		return this;
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
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Single", "DateTime"));
	}

	[__DynamicallyInvokable]
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return Convert.DefaultToType(this, type, provider);
	}
}
