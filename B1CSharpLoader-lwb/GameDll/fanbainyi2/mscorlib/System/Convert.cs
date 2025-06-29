using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace System;

[__DynamicallyInvokable]
public static class Convert
{
	internal static readonly RuntimeType[] ConvertTypes = new RuntimeType[19]
	{
		(RuntimeType)typeof(Empty),
		(RuntimeType)typeof(object),
		(RuntimeType)typeof(DBNull),
		(RuntimeType)typeof(bool),
		(RuntimeType)typeof(char),
		(RuntimeType)typeof(sbyte),
		(RuntimeType)typeof(byte),
		(RuntimeType)typeof(short),
		(RuntimeType)typeof(ushort),
		(RuntimeType)typeof(int),
		(RuntimeType)typeof(uint),
		(RuntimeType)typeof(long),
		(RuntimeType)typeof(ulong),
		(RuntimeType)typeof(float),
		(RuntimeType)typeof(double),
		(RuntimeType)typeof(decimal),
		(RuntimeType)typeof(DateTime),
		(RuntimeType)typeof(object),
		(RuntimeType)typeof(string)
	};

	private static readonly RuntimeType EnumType = (RuntimeType)typeof(Enum);

	internal static readonly char[] base64Table = new char[65]
	{
		'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
		'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
		'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd',
		'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
		'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
		'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7',
		'8', '9', '+', '/', '='
	};

	private const int base64LineBreakPosition = 76;

	public static readonly object DBNull = System.DBNull.Value;

	[__DynamicallyInvokable]
	public static TypeCode GetTypeCode(object value)
	{
		if (value == null)
		{
			return TypeCode.Empty;
		}
		if (value is IConvertible convertible)
		{
			return convertible.GetTypeCode();
		}
		return TypeCode.Object;
	}

	public static bool IsDBNull(object value)
	{
		if (value == System.DBNull.Value)
		{
			return true;
		}
		if (!(value is IConvertible convertible))
		{
			return false;
		}
		return convertible.GetTypeCode() == TypeCode.DBNull;
	}

	public static object ChangeType(object value, TypeCode typeCode)
	{
		return ChangeType(value, typeCode, Thread.CurrentThread.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider)
	{
		if (value == null && (typeCode == TypeCode.Empty || typeCode == TypeCode.String || typeCode == TypeCode.Object))
		{
			return null;
		}
		if (!(value is IConvertible convertible))
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_IConvertible"));
		}
		return typeCode switch
		{
			TypeCode.Boolean => convertible.ToBoolean(provider), 
			TypeCode.Char => convertible.ToChar(provider), 
			TypeCode.SByte => convertible.ToSByte(provider), 
			TypeCode.Byte => convertible.ToByte(provider), 
			TypeCode.Int16 => convertible.ToInt16(provider), 
			TypeCode.UInt16 => convertible.ToUInt16(provider), 
			TypeCode.Int32 => convertible.ToInt32(provider), 
			TypeCode.UInt32 => convertible.ToUInt32(provider), 
			TypeCode.Int64 => convertible.ToInt64(provider), 
			TypeCode.UInt64 => convertible.ToUInt64(provider), 
			TypeCode.Single => convertible.ToSingle(provider), 
			TypeCode.Double => convertible.ToDouble(provider), 
			TypeCode.Decimal => convertible.ToDecimal(provider), 
			TypeCode.DateTime => convertible.ToDateTime(provider), 
			TypeCode.String => convertible.ToString(provider), 
			TypeCode.Object => value, 
			TypeCode.DBNull => throw new InvalidCastException(Environment.GetResourceString("InvalidCast_DBNull")), 
			TypeCode.Empty => throw new InvalidCastException(Environment.GetResourceString("InvalidCast_Empty")), 
			_ => throw new ArgumentException(Environment.GetResourceString("Arg_UnknownTypeCode")), 
		};
	}

	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider)
	{
		if (targetType == null)
		{
			throw new ArgumentNullException("targetType");
		}
		RuntimeType runtimeType = targetType as RuntimeType;
		if (runtimeType != null)
		{
			if (value.GetType() == targetType)
			{
				return value;
			}
			if (runtimeType == ConvertTypes[3])
			{
				return value.ToBoolean(provider);
			}
			if (runtimeType == ConvertTypes[4])
			{
				return value.ToChar(provider);
			}
			if (runtimeType == ConvertTypes[5])
			{
				return value.ToSByte(provider);
			}
			if (runtimeType == ConvertTypes[6])
			{
				return value.ToByte(provider);
			}
			if (runtimeType == ConvertTypes[7])
			{
				return value.ToInt16(provider);
			}
			if (runtimeType == ConvertTypes[8])
			{
				return value.ToUInt16(provider);
			}
			if (runtimeType == ConvertTypes[9])
			{
				return value.ToInt32(provider);
			}
			if (runtimeType == ConvertTypes[10])
			{
				return value.ToUInt32(provider);
			}
			if (runtimeType == ConvertTypes[11])
			{
				return value.ToInt64(provider);
			}
			if (runtimeType == ConvertTypes[12])
			{
				return value.ToUInt64(provider);
			}
			if (runtimeType == ConvertTypes[13])
			{
				return value.ToSingle(provider);
			}
			if (runtimeType == ConvertTypes[14])
			{
				return value.ToDouble(provider);
			}
			if (runtimeType == ConvertTypes[15])
			{
				return value.ToDecimal(provider);
			}
			if (runtimeType == ConvertTypes[16])
			{
				return value.ToDateTime(provider);
			}
			if (runtimeType == ConvertTypes[18])
			{
				return value.ToString(provider);
			}
			if (runtimeType == ConvertTypes[1])
			{
				return value;
			}
			if (runtimeType == EnumType)
			{
				return (Enum)value;
			}
			if (runtimeType == ConvertTypes[2])
			{
				throw new InvalidCastException(Environment.GetResourceString("InvalidCast_DBNull"));
			}
			if (runtimeType == ConvertTypes[0])
			{
				throw new InvalidCastException(Environment.GetResourceString("InvalidCast_Empty"));
			}
		}
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", value.GetType().FullName, targetType.FullName));
	}

	[__DynamicallyInvokable]
	public static object ChangeType(object value, Type conversionType)
	{
		return ChangeType(value, conversionType, Thread.CurrentThread.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider)
	{
		if (conversionType == null)
		{
			throw new ArgumentNullException("conversionType");
		}
		if (value == null)
		{
			if (conversionType.IsValueType)
			{
				throw new InvalidCastException(Environment.GetResourceString("InvalidCast_CannotCastNullToValueType"));
			}
			return null;
		}
		if (!(value is IConvertible convertible))
		{
			if (value.GetType() == conversionType)
			{
				return value;
			}
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_IConvertible"));
		}
		RuntimeType runtimeType = conversionType as RuntimeType;
		if (runtimeType == ConvertTypes[3])
		{
			return convertible.ToBoolean(provider);
		}
		if (runtimeType == ConvertTypes[4])
		{
			return convertible.ToChar(provider);
		}
		if (runtimeType == ConvertTypes[5])
		{
			return convertible.ToSByte(provider);
		}
		if (runtimeType == ConvertTypes[6])
		{
			return convertible.ToByte(provider);
		}
		if (runtimeType == ConvertTypes[7])
		{
			return convertible.ToInt16(provider);
		}
		if (runtimeType == ConvertTypes[8])
		{
			return convertible.ToUInt16(provider);
		}
		if (runtimeType == ConvertTypes[9])
		{
			return convertible.ToInt32(provider);
		}
		if (runtimeType == ConvertTypes[10])
		{
			return convertible.ToUInt32(provider);
		}
		if (runtimeType == ConvertTypes[11])
		{
			return convertible.ToInt64(provider);
		}
		if (runtimeType == ConvertTypes[12])
		{
			return convertible.ToUInt64(provider);
		}
		if (runtimeType == ConvertTypes[13])
		{
			return convertible.ToSingle(provider);
		}
		if (runtimeType == ConvertTypes[14])
		{
			return convertible.ToDouble(provider);
		}
		if (runtimeType == ConvertTypes[15])
		{
			return convertible.ToDecimal(provider);
		}
		if (runtimeType == ConvertTypes[16])
		{
			return convertible.ToDateTime(provider);
		}
		if (runtimeType == ConvertTypes[18])
		{
			return convertible.ToString(provider);
		}
		if (runtimeType == ConvertTypes[1])
		{
			return value;
		}
		return convertible.ToType(conversionType, provider);
	}

	[__DynamicallyInvokable]
	public static bool ToBoolean(object value)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToBoolean(null);
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool ToBoolean(object value, IFormatProvider provider)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToBoolean(provider);
		}
		return false;
	}

	[__DynamicallyInvokable]
	public static bool ToBoolean(bool value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static bool ToBoolean(sbyte value)
	{
		return value != 0;
	}

	public static bool ToBoolean(char value)
	{
		return ((IConvertible)value).ToBoolean((IFormatProvider)null);
	}

	[__DynamicallyInvokable]
	public static bool ToBoolean(byte value)
	{
		return value != 0;
	}

	[__DynamicallyInvokable]
	public static bool ToBoolean(short value)
	{
		return value != 0;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static bool ToBoolean(ushort value)
	{
		return value != 0;
	}

	[__DynamicallyInvokable]
	public static bool ToBoolean(int value)
	{
		return value != 0;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static bool ToBoolean(uint value)
	{
		return value != 0;
	}

	[__DynamicallyInvokable]
	public static bool ToBoolean(long value)
	{
		return value != 0;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static bool ToBoolean(ulong value)
	{
		return value != 0;
	}

	[__DynamicallyInvokable]
	public static bool ToBoolean(string value)
	{
		if (value == null)
		{
			return false;
		}
		return bool.Parse(value);
	}

	[__DynamicallyInvokable]
	public static bool ToBoolean(string value, IFormatProvider provider)
	{
		if (value == null)
		{
			return false;
		}
		return bool.Parse(value);
	}

	[__DynamicallyInvokable]
	public static bool ToBoolean(float value)
	{
		return value != 0f;
	}

	[__DynamicallyInvokable]
	public static bool ToBoolean(double value)
	{
		return value != 0.0;
	}

	[__DynamicallyInvokable]
	public static bool ToBoolean(decimal value)
	{
		return value != 0m;
	}

	public static bool ToBoolean(DateTime value)
	{
		return ((IConvertible)value).ToBoolean((IFormatProvider)null);
	}

	[__DynamicallyInvokable]
	public static char ToChar(object value)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToChar(null);
		}
		return '\0';
	}

	[__DynamicallyInvokable]
	public static char ToChar(object value, IFormatProvider provider)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToChar(provider);
		}
		return '\0';
	}

	public static char ToChar(bool value)
	{
		return ((IConvertible)value).ToChar((IFormatProvider)null);
	}

	public static char ToChar(char value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static char ToChar(sbyte value)
	{
		if (value < 0)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Char"));
		}
		return (char)value;
	}

	[__DynamicallyInvokable]
	public static char ToChar(byte value)
	{
		return (char)value;
	}

	[__DynamicallyInvokable]
	public static char ToChar(short value)
	{
		if (value < 0)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Char"));
		}
		return (char)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static char ToChar(ushort value)
	{
		return (char)value;
	}

	[__DynamicallyInvokable]
	public static char ToChar(int value)
	{
		if (value < 0 || value > 65535)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Char"));
		}
		return (char)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static char ToChar(uint value)
	{
		if (value > 65535)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Char"));
		}
		return (char)value;
	}

	[__DynamicallyInvokable]
	public static char ToChar(long value)
	{
		if (value < 0 || value > 65535)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Char"));
		}
		return (char)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static char ToChar(ulong value)
	{
		if (value > 65535)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Char"));
		}
		return (char)value;
	}

	[__DynamicallyInvokable]
	public static char ToChar(string value)
	{
		return ToChar(value, null);
	}

	[__DynamicallyInvokable]
	public static char ToChar(string value, IFormatProvider provider)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (value.Length != 1)
		{
			throw new FormatException(Environment.GetResourceString("Format_NeedSingleChar"));
		}
		return value[0];
	}

	public static char ToChar(float value)
	{
		return ((IConvertible)value).ToChar((IFormatProvider)null);
	}

	public static char ToChar(double value)
	{
		return ((IConvertible)value).ToChar((IFormatProvider)null);
	}

	public static char ToChar(decimal value)
	{
		return ((IConvertible)value).ToChar((IFormatProvider)null);
	}

	public static char ToChar(DateTime value)
	{
		return ((IConvertible)value).ToChar((IFormatProvider)null);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(object value)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToSByte(null);
		}
		return 0;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(object value, IFormatProvider provider)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToSByte(provider);
		}
		return 0;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(bool value)
	{
		if (!value)
		{
			return 0;
		}
		return 1;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(sbyte value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(char value)
	{
		if (value > '\u007f')
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_SByte"));
		}
		return (sbyte)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(byte value)
	{
		if (value > 127)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_SByte"));
		}
		return (sbyte)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(short value)
	{
		if (value < -128 || value > 127)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_SByte"));
		}
		return (sbyte)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(ushort value)
	{
		if (value > 127)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_SByte"));
		}
		return (sbyte)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(int value)
	{
		if (value < -128 || value > 127)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_SByte"));
		}
		return (sbyte)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(uint value)
	{
		if ((long)value > 127L)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_SByte"));
		}
		return (sbyte)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(long value)
	{
		if (value < -128 || value > 127)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_SByte"));
		}
		return (sbyte)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(ulong value)
	{
		if (value > 127)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_SByte"));
		}
		return (sbyte)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(float value)
	{
		return ToSByte((double)value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(double value)
	{
		return ToSByte(ToInt32(value));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(decimal value)
	{
		return decimal.ToSByte(decimal.Round(value, 0));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(string value)
	{
		if (value == null)
		{
			return 0;
		}
		return sbyte.Parse(value, CultureInfo.CurrentCulture);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(string value, IFormatProvider provider)
	{
		return sbyte.Parse(value, NumberStyles.Integer, provider);
	}

	[CLSCompliant(false)]
	public static sbyte ToSByte(DateTime value)
	{
		return ((IConvertible)value).ToSByte((IFormatProvider)null);
	}

	[__DynamicallyInvokable]
	public static byte ToByte(object value)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToByte(null);
		}
		return 0;
	}

	[__DynamicallyInvokable]
	public static byte ToByte(object value, IFormatProvider provider)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToByte(provider);
		}
		return 0;
	}

	[__DynamicallyInvokable]
	public static byte ToByte(bool value)
	{
		if (!value)
		{
			return 0;
		}
		return 1;
	}

	[__DynamicallyInvokable]
	public static byte ToByte(byte value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static byte ToByte(char value)
	{
		if (value > 'ÿ')
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Byte"));
		}
		return (byte)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static byte ToByte(sbyte value)
	{
		if (value < 0)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Byte"));
		}
		return (byte)value;
	}

	[__DynamicallyInvokable]
	public static byte ToByte(short value)
	{
		if (value < 0 || value > 255)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Byte"));
		}
		return (byte)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static byte ToByte(ushort value)
	{
		if (value > 255)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Byte"));
		}
		return (byte)value;
	}

	[__DynamicallyInvokable]
	public static byte ToByte(int value)
	{
		if (value < 0 || value > 255)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Byte"));
		}
		return (byte)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static byte ToByte(uint value)
	{
		if (value > 255)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Byte"));
		}
		return (byte)value;
	}

	[__DynamicallyInvokable]
	public static byte ToByte(long value)
	{
		if (value < 0 || value > 255)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Byte"));
		}
		return (byte)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static byte ToByte(ulong value)
	{
		if (value > 255)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Byte"));
		}
		return (byte)value;
	}

	[__DynamicallyInvokable]
	public static byte ToByte(float value)
	{
		return ToByte((double)value);
	}

	[__DynamicallyInvokable]
	public static byte ToByte(double value)
	{
		return ToByte(ToInt32(value));
	}

	[__DynamicallyInvokable]
	public static byte ToByte(decimal value)
	{
		return decimal.ToByte(decimal.Round(value, 0));
	}

	[__DynamicallyInvokable]
	public static byte ToByte(string value)
	{
		if (value == null)
		{
			return 0;
		}
		return byte.Parse(value, CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static byte ToByte(string value, IFormatProvider provider)
	{
		if (value == null)
		{
			return 0;
		}
		return byte.Parse(value, NumberStyles.Integer, provider);
	}

	public static byte ToByte(DateTime value)
	{
		return ((IConvertible)value).ToByte((IFormatProvider)null);
	}

	[__DynamicallyInvokable]
	public static short ToInt16(object value)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToInt16(null);
		}
		return 0;
	}

	[__DynamicallyInvokable]
	public static short ToInt16(object value, IFormatProvider provider)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToInt16(provider);
		}
		return 0;
	}

	[__DynamicallyInvokable]
	public static short ToInt16(bool value)
	{
		if (!value)
		{
			return 0;
		}
		return 1;
	}

	[__DynamicallyInvokable]
	public static short ToInt16(char value)
	{
		if (value > '翿')
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int16"));
		}
		return (short)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static short ToInt16(sbyte value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static short ToInt16(byte value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static short ToInt16(ushort value)
	{
		if (value > 32767)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int16"));
		}
		return (short)value;
	}

	[__DynamicallyInvokable]
	public static short ToInt16(int value)
	{
		if (value < -32768 || value > 32767)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int16"));
		}
		return (short)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static short ToInt16(uint value)
	{
		if ((long)value > 32767L)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int16"));
		}
		return (short)value;
	}

	[__DynamicallyInvokable]
	public static short ToInt16(short value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static short ToInt16(long value)
	{
		if (value < -32768 || value > 32767)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int16"));
		}
		return (short)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static short ToInt16(ulong value)
	{
		if (value > 32767)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int16"));
		}
		return (short)value;
	}

	[__DynamicallyInvokable]
	public static short ToInt16(float value)
	{
		return ToInt16((double)value);
	}

	[__DynamicallyInvokable]
	public static short ToInt16(double value)
	{
		return ToInt16(ToInt32(value));
	}

	[__DynamicallyInvokable]
	public static short ToInt16(decimal value)
	{
		return decimal.ToInt16(decimal.Round(value, 0));
	}

	[__DynamicallyInvokable]
	public static short ToInt16(string value)
	{
		if (value == null)
		{
			return 0;
		}
		return short.Parse(value, CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static short ToInt16(string value, IFormatProvider provider)
	{
		if (value == null)
		{
			return 0;
		}
		return short.Parse(value, NumberStyles.Integer, provider);
	}

	public static short ToInt16(DateTime value)
	{
		return ((IConvertible)value).ToInt16((IFormatProvider)null);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(object value)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToUInt16(null);
		}
		return 0;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(object value, IFormatProvider provider)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToUInt16(provider);
		}
		return 0;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(bool value)
	{
		if (!value)
		{
			return 0;
		}
		return 1;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(char value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(sbyte value)
	{
		if (value < 0)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt16"));
		}
		return (ushort)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(byte value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(short value)
	{
		if (value < 0)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt16"));
		}
		return (ushort)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(int value)
	{
		if (value < 0 || value > 65535)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt16"));
		}
		return (ushort)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(ushort value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(uint value)
	{
		if (value > 65535)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt16"));
		}
		return (ushort)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(long value)
	{
		if (value < 0 || value > 65535)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt16"));
		}
		return (ushort)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(ulong value)
	{
		if (value > 65535)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt16"));
		}
		return (ushort)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(float value)
	{
		return ToUInt16((double)value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(double value)
	{
		return ToUInt16(ToInt32(value));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(decimal value)
	{
		return decimal.ToUInt16(decimal.Round(value, 0));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(string value)
	{
		if (value == null)
		{
			return 0;
		}
		return ushort.Parse(value, CultureInfo.CurrentCulture);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(string value, IFormatProvider provider)
	{
		if (value == null)
		{
			return 0;
		}
		return ushort.Parse(value, NumberStyles.Integer, provider);
	}

	[CLSCompliant(false)]
	public static ushort ToUInt16(DateTime value)
	{
		return ((IConvertible)value).ToUInt16((IFormatProvider)null);
	}

	[__DynamicallyInvokable]
	public static int ToInt32(object value)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToInt32(null);
		}
		return 0;
	}

	[__DynamicallyInvokable]
	public static int ToInt32(object value, IFormatProvider provider)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToInt32(provider);
		}
		return 0;
	}

	[__DynamicallyInvokable]
	public static int ToInt32(bool value)
	{
		if (!value)
		{
			return 0;
		}
		return 1;
	}

	[__DynamicallyInvokable]
	public static int ToInt32(char value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static int ToInt32(sbyte value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static int ToInt32(byte value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static int ToInt32(short value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static int ToInt32(ushort value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static int ToInt32(uint value)
	{
		if (value > int.MaxValue)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int32"));
		}
		return (int)value;
	}

	[__DynamicallyInvokable]
	public static int ToInt32(int value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static int ToInt32(long value)
	{
		if (value < int.MinValue || value > int.MaxValue)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int32"));
		}
		return (int)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static int ToInt32(ulong value)
	{
		if (value > int.MaxValue)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int32"));
		}
		return (int)value;
	}

	[__DynamicallyInvokable]
	public static int ToInt32(float value)
	{
		return ToInt32((double)value);
	}

	[__DynamicallyInvokable]
	public static int ToInt32(double value)
	{
		if (value >= 0.0)
		{
			if (value < 2147483647.5)
			{
				int num = (int)value;
				double num2 = value - (double)num;
				if (num2 > 0.5 || (num2 == 0.5 && (num & 1) != 0))
				{
					num++;
				}
				return num;
			}
		}
		else if (value >= -2147483648.5)
		{
			int num3 = (int)value;
			double num4 = value - (double)num3;
			if (num4 < -0.5 || (num4 == -0.5 && (num3 & 1) != 0))
			{
				num3--;
			}
			return num3;
		}
		throw new OverflowException(Environment.GetResourceString("Overflow_Int32"));
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static int ToInt32(decimal value)
	{
		return decimal.FCallToInt32(value);
	}

	[__DynamicallyInvokable]
	public static int ToInt32(string value)
	{
		if (value == null)
		{
			return 0;
		}
		return int.Parse(value, CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static int ToInt32(string value, IFormatProvider provider)
	{
		if (value == null)
		{
			return 0;
		}
		return int.Parse(value, NumberStyles.Integer, provider);
	}

	public static int ToInt32(DateTime value)
	{
		return ((IConvertible)value).ToInt32((IFormatProvider)null);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(object value)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToUInt32(null);
		}
		return 0u;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(object value, IFormatProvider provider)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToUInt32(provider);
		}
		return 0u;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(bool value)
	{
		if (!value)
		{
			return 0u;
		}
		return 1u;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(char value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(sbyte value)
	{
		if (value < 0)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt32"));
		}
		return (uint)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(byte value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(short value)
	{
		if (value < 0)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt32"));
		}
		return (uint)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(ushort value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(int value)
	{
		if (value < 0)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt32"));
		}
		return (uint)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(uint value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(long value)
	{
		if (value < 0 || value > uint.MaxValue)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt32"));
		}
		return (uint)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(ulong value)
	{
		if (value > uint.MaxValue)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt32"));
		}
		return (uint)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(float value)
	{
		return ToUInt32((double)value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(double value)
	{
		if (value >= -0.5 && value < 4294967295.5)
		{
			uint num = (uint)value;
			double num2 = value - (double)num;
			if (num2 > 0.5 || (num2 == 0.5 && (num & 1) != 0))
			{
				num++;
			}
			return num;
		}
		throw new OverflowException(Environment.GetResourceString("Overflow_UInt32"));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(decimal value)
	{
		return decimal.ToUInt32(decimal.Round(value, 0));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(string value)
	{
		if (value == null)
		{
			return 0u;
		}
		return uint.Parse(value, CultureInfo.CurrentCulture);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(string value, IFormatProvider provider)
	{
		if (value == null)
		{
			return 0u;
		}
		return uint.Parse(value, NumberStyles.Integer, provider);
	}

	[CLSCompliant(false)]
	public static uint ToUInt32(DateTime value)
	{
		return ((IConvertible)value).ToUInt32((IFormatProvider)null);
	}

	[__DynamicallyInvokable]
	public static long ToInt64(object value)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToInt64(null);
		}
		return 0L;
	}

	[__DynamicallyInvokable]
	public static long ToInt64(object value, IFormatProvider provider)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToInt64(provider);
		}
		return 0L;
	}

	[__DynamicallyInvokable]
	public static long ToInt64(bool value)
	{
		return value ? 1 : 0;
	}

	[__DynamicallyInvokable]
	public static long ToInt64(char value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static long ToInt64(sbyte value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static long ToInt64(byte value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static long ToInt64(short value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static long ToInt64(ushort value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static long ToInt64(int value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static long ToInt64(uint value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static long ToInt64(ulong value)
	{
		if (value > long.MaxValue)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int64"));
		}
		return (long)value;
	}

	[__DynamicallyInvokable]
	public static long ToInt64(long value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static long ToInt64(float value)
	{
		return ToInt64((double)value);
	}

	[__DynamicallyInvokable]
	public static long ToInt64(double value)
	{
		return checked((long)Math.Round(value));
	}

	[__DynamicallyInvokable]
	public static long ToInt64(decimal value)
	{
		return decimal.ToInt64(decimal.Round(value, 0));
	}

	[__DynamicallyInvokable]
	public static long ToInt64(string value)
	{
		if (value == null)
		{
			return 0L;
		}
		return long.Parse(value, CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static long ToInt64(string value, IFormatProvider provider)
	{
		if (value == null)
		{
			return 0L;
		}
		return long.Parse(value, NumberStyles.Integer, provider);
	}

	public static long ToInt64(DateTime value)
	{
		return ((IConvertible)value).ToInt64((IFormatProvider)null);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(object value)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToUInt64(null);
		}
		return 0uL;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(object value, IFormatProvider provider)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToUInt64(provider);
		}
		return 0uL;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(bool value)
	{
		if (!value)
		{
			return 0uL;
		}
		return 1uL;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(char value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(sbyte value)
	{
		if (value < 0)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt64"));
		}
		return (ulong)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(byte value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(short value)
	{
		if (value < 0)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt64"));
		}
		return (ulong)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(ushort value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(int value)
	{
		if (value < 0)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt64"));
		}
		return (ulong)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(uint value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(long value)
	{
		if (value < 0)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt64"));
		}
		return (ulong)value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(ulong value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(float value)
	{
		return ToUInt64((double)value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(double value)
	{
		return checked((ulong)Math.Round(value));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(decimal value)
	{
		return decimal.ToUInt64(decimal.Round(value, 0));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(string value)
	{
		if (value == null)
		{
			return 0uL;
		}
		return ulong.Parse(value, CultureInfo.CurrentCulture);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(string value, IFormatProvider provider)
	{
		if (value == null)
		{
			return 0uL;
		}
		return ulong.Parse(value, NumberStyles.Integer, provider);
	}

	[CLSCompliant(false)]
	public static ulong ToUInt64(DateTime value)
	{
		return ((IConvertible)value).ToUInt64((IFormatProvider)null);
	}

	[__DynamicallyInvokable]
	public static float ToSingle(object value)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToSingle(null);
		}
		return 0f;
	}

	[__DynamicallyInvokable]
	public static float ToSingle(object value, IFormatProvider provider)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToSingle(provider);
		}
		return 0f;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static float ToSingle(sbyte value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static float ToSingle(byte value)
	{
		return (int)value;
	}

	public static float ToSingle(char value)
	{
		return ((IConvertible)value).ToSingle((IFormatProvider)null);
	}

	[__DynamicallyInvokable]
	public static float ToSingle(short value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static float ToSingle(ushort value)
	{
		return (int)value;
	}

	[__DynamicallyInvokable]
	public static float ToSingle(int value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static float ToSingle(uint value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static float ToSingle(long value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static float ToSingle(ulong value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static float ToSingle(float value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static float ToSingle(double value)
	{
		return (float)value;
	}

	[__DynamicallyInvokable]
	public static float ToSingle(decimal value)
	{
		return (float)value;
	}

	[__DynamicallyInvokable]
	public static float ToSingle(string value)
	{
		if (value == null)
		{
			return 0f;
		}
		return float.Parse(value, CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static float ToSingle(string value, IFormatProvider provider)
	{
		if (value == null)
		{
			return 0f;
		}
		return float.Parse(value, NumberStyles.Float | NumberStyles.AllowThousands, provider);
	}

	[__DynamicallyInvokable]
	public static float ToSingle(bool value)
	{
		return value ? 1 : 0;
	}

	public static float ToSingle(DateTime value)
	{
		return ((IConvertible)value).ToSingle((IFormatProvider)null);
	}

	[__DynamicallyInvokable]
	public static double ToDouble(object value)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToDouble(null);
		}
		return 0.0;
	}

	[__DynamicallyInvokable]
	public static double ToDouble(object value, IFormatProvider provider)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToDouble(provider);
		}
		return 0.0;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static double ToDouble(sbyte value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static double ToDouble(byte value)
	{
		return (int)value;
	}

	[__DynamicallyInvokable]
	public static double ToDouble(short value)
	{
		return value;
	}

	public static double ToDouble(char value)
	{
		return ((IConvertible)value).ToDouble((IFormatProvider)null);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static double ToDouble(ushort value)
	{
		return (int)value;
	}

	[__DynamicallyInvokable]
	public static double ToDouble(int value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static double ToDouble(uint value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static double ToDouble(long value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static double ToDouble(ulong value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static double ToDouble(float value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static double ToDouble(double value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static double ToDouble(decimal value)
	{
		return (double)value;
	}

	[__DynamicallyInvokable]
	public static double ToDouble(string value)
	{
		if (value == null)
		{
			return 0.0;
		}
		return double.Parse(value, CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static double ToDouble(string value, IFormatProvider provider)
	{
		if (value == null)
		{
			return 0.0;
		}
		return double.Parse(value, NumberStyles.Float | NumberStyles.AllowThousands, provider);
	}

	[__DynamicallyInvokable]
	public static double ToDouble(bool value)
	{
		return value ? 1 : 0;
	}

	public static double ToDouble(DateTime value)
	{
		return ((IConvertible)value).ToDouble((IFormatProvider)null);
	}

	[__DynamicallyInvokable]
	public static decimal ToDecimal(object value)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToDecimal(null);
		}
		return 0m;
	}

	[__DynamicallyInvokable]
	public static decimal ToDecimal(object value, IFormatProvider provider)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToDecimal(provider);
		}
		return 0m;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static decimal ToDecimal(sbyte value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static decimal ToDecimal(byte value)
	{
		return value;
	}

	public static decimal ToDecimal(char value)
	{
		return ((IConvertible)value).ToDecimal((IFormatProvider)null);
	}

	[__DynamicallyInvokable]
	public static decimal ToDecimal(short value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static decimal ToDecimal(ushort value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static decimal ToDecimal(int value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static decimal ToDecimal(uint value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static decimal ToDecimal(long value)
	{
		return value;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static decimal ToDecimal(ulong value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static decimal ToDecimal(float value)
	{
		return (decimal)value;
	}

	[__DynamicallyInvokable]
	public static decimal ToDecimal(double value)
	{
		return (decimal)value;
	}

	[__DynamicallyInvokable]
	public static decimal ToDecimal(string value)
	{
		if (value == null)
		{
			return 0m;
		}
		return decimal.Parse(value, CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static decimal ToDecimal(string value, IFormatProvider provider)
	{
		if (value == null)
		{
			return 0m;
		}
		return decimal.Parse(value, NumberStyles.Number, provider);
	}

	[__DynamicallyInvokable]
	public static decimal ToDecimal(decimal value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static decimal ToDecimal(bool value)
	{
		return value ? 1 : 0;
	}

	public static decimal ToDecimal(DateTime value)
	{
		return ((IConvertible)value).ToDecimal((IFormatProvider)null);
	}

	public static DateTime ToDateTime(DateTime value)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static DateTime ToDateTime(object value)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToDateTime(null);
		}
		return DateTime.MinValue;
	}

	[__DynamicallyInvokable]
	public static DateTime ToDateTime(object value, IFormatProvider provider)
	{
		if (value != null)
		{
			return ((IConvertible)value).ToDateTime(provider);
		}
		return DateTime.MinValue;
	}

	[__DynamicallyInvokable]
	public static DateTime ToDateTime(string value)
	{
		if (value == null)
		{
			return new DateTime(0L);
		}
		return DateTime.Parse(value, CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static DateTime ToDateTime(string value, IFormatProvider provider)
	{
		if (value == null)
		{
			return new DateTime(0L);
		}
		return DateTime.Parse(value, provider);
	}

	[CLSCompliant(false)]
	public static DateTime ToDateTime(sbyte value)
	{
		return ((IConvertible)value).ToDateTime((IFormatProvider)null);
	}

	public static DateTime ToDateTime(byte value)
	{
		return ((IConvertible)value).ToDateTime((IFormatProvider)null);
	}

	public static DateTime ToDateTime(short value)
	{
		return ((IConvertible)value).ToDateTime((IFormatProvider)null);
	}

	[CLSCompliant(false)]
	public static DateTime ToDateTime(ushort value)
	{
		return ((IConvertible)value).ToDateTime((IFormatProvider)null);
	}

	public static DateTime ToDateTime(int value)
	{
		return ((IConvertible)value).ToDateTime((IFormatProvider)null);
	}

	[CLSCompliant(false)]
	public static DateTime ToDateTime(uint value)
	{
		return ((IConvertible)value).ToDateTime((IFormatProvider)null);
	}

	public static DateTime ToDateTime(long value)
	{
		return ((IConvertible)value).ToDateTime((IFormatProvider)null);
	}

	[CLSCompliant(false)]
	public static DateTime ToDateTime(ulong value)
	{
		return ((IConvertible)value).ToDateTime((IFormatProvider)null);
	}

	public static DateTime ToDateTime(bool value)
	{
		return ((IConvertible)value).ToDateTime((IFormatProvider)null);
	}

	public static DateTime ToDateTime(char value)
	{
		return ((IConvertible)value).ToDateTime((IFormatProvider)null);
	}

	public static DateTime ToDateTime(float value)
	{
		return ((IConvertible)value).ToDateTime((IFormatProvider)null);
	}

	public static DateTime ToDateTime(double value)
	{
		return ((IConvertible)value).ToDateTime((IFormatProvider)null);
	}

	public static DateTime ToDateTime(decimal value)
	{
		return ((IConvertible)value).ToDateTime((IFormatProvider)null);
	}

	[__DynamicallyInvokable]
	public static string ToString(object value)
	{
		return ToString(value, null);
	}

	[__DynamicallyInvokable]
	public static string ToString(object value, IFormatProvider provider)
	{
		if (value is IConvertible convertible)
		{
			return convertible.ToString(provider);
		}
		if (value is IFormattable formattable)
		{
			return formattable.ToString(null, provider);
		}
		if (value != null)
		{
			return value.ToString();
		}
		return string.Empty;
	}

	[__DynamicallyInvokable]
	public static string ToString(bool value)
	{
		return value.ToString();
	}

	[__DynamicallyInvokable]
	public static string ToString(bool value, IFormatProvider provider)
	{
		return value.ToString(provider);
	}

	[__DynamicallyInvokable]
	public static string ToString(char value)
	{
		return char.ToString(value);
	}

	[__DynamicallyInvokable]
	public static string ToString(char value, IFormatProvider provider)
	{
		return value.ToString(provider);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static string ToString(sbyte value)
	{
		return value.ToString(CultureInfo.CurrentCulture);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static string ToString(sbyte value, IFormatProvider provider)
	{
		return value.ToString(provider);
	}

	[__DynamicallyInvokable]
	public static string ToString(byte value)
	{
		return value.ToString(CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static string ToString(byte value, IFormatProvider provider)
	{
		return value.ToString(provider);
	}

	[__DynamicallyInvokable]
	public static string ToString(short value)
	{
		return value.ToString(CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static string ToString(short value, IFormatProvider provider)
	{
		return value.ToString(provider);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static string ToString(ushort value)
	{
		return value.ToString(CultureInfo.CurrentCulture);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static string ToString(ushort value, IFormatProvider provider)
	{
		return value.ToString(provider);
	}

	[__DynamicallyInvokable]
	public static string ToString(int value)
	{
		return value.ToString(CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static string ToString(int value, IFormatProvider provider)
	{
		return value.ToString(provider);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static string ToString(uint value)
	{
		return value.ToString(CultureInfo.CurrentCulture);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static string ToString(uint value, IFormatProvider provider)
	{
		return value.ToString(provider);
	}

	[__DynamicallyInvokable]
	public static string ToString(long value)
	{
		return value.ToString(CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static string ToString(long value, IFormatProvider provider)
	{
		return value.ToString(provider);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static string ToString(ulong value)
	{
		return value.ToString(CultureInfo.CurrentCulture);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static string ToString(ulong value, IFormatProvider provider)
	{
		return value.ToString(provider);
	}

	[__DynamicallyInvokable]
	public static string ToString(float value)
	{
		return value.ToString(CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static string ToString(float value, IFormatProvider provider)
	{
		return value.ToString(provider);
	}

	[__DynamicallyInvokable]
	public static string ToString(double value)
	{
		return value.ToString(CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static string ToString(double value, IFormatProvider provider)
	{
		return value.ToString(provider);
	}

	[__DynamicallyInvokable]
	public static string ToString(decimal value)
	{
		return value.ToString(CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	public static string ToString(decimal value, IFormatProvider provider)
	{
		return value.ToString(provider);
	}

	[__DynamicallyInvokable]
	public static string ToString(DateTime value)
	{
		return value.ToString();
	}

	[__DynamicallyInvokable]
	public static string ToString(DateTime value, IFormatProvider provider)
	{
		return value.ToString(provider);
	}

	public static string ToString(string value)
	{
		return value;
	}

	public static string ToString(string value, IFormatProvider provider)
	{
		return value;
	}

	[__DynamicallyInvokable]
	public static byte ToByte(string value, int fromBase)
	{
		if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidBase"));
		}
		int num = ParseNumbers.StringToInt(value, fromBase, 4608);
		if (num < 0 || num > 255)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Byte"));
		}
		return (byte)num;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(string value, int fromBase)
	{
		if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidBase"));
		}
		int num = ParseNumbers.StringToInt(value, fromBase, 5120);
		if (fromBase != 10 && num <= 255)
		{
			return (sbyte)num;
		}
		if (num < -128 || num > 127)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_SByte"));
		}
		return (sbyte)num;
	}

	[__DynamicallyInvokable]
	public static short ToInt16(string value, int fromBase)
	{
		if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidBase"));
		}
		int num = ParseNumbers.StringToInt(value, fromBase, 6144);
		if (fromBase != 10 && num <= 65535)
		{
			return (short)num;
		}
		if (num < -32768 || num > 32767)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int16"));
		}
		return (short)num;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(string value, int fromBase)
	{
		if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidBase"));
		}
		int num = ParseNumbers.StringToInt(value, fromBase, 4608);
		if (num < 0 || num > 65535)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt16"));
		}
		return (ushort)num;
	}

	[__DynamicallyInvokable]
	public static int ToInt32(string value, int fromBase)
	{
		if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidBase"));
		}
		return ParseNumbers.StringToInt(value, fromBase, 4096);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(string value, int fromBase)
	{
		if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidBase"));
		}
		return (uint)ParseNumbers.StringToInt(value, fromBase, 4608);
	}

	[__DynamicallyInvokable]
	public static long ToInt64(string value, int fromBase)
	{
		if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidBase"));
		}
		return ParseNumbers.StringToLong(value, fromBase, 4096);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(string value, int fromBase)
	{
		if (fromBase != 2 && fromBase != 8 && fromBase != 10 && fromBase != 16)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidBase"));
		}
		return (ulong)ParseNumbers.StringToLong(value, fromBase, 4608);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static string ToString(byte value, int toBase)
	{
		if (toBase != 2 && toBase != 8 && toBase != 10 && toBase != 16)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidBase"));
		}
		return ParseNumbers.IntToString(value, toBase, -1, ' ', 64);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static string ToString(short value, int toBase)
	{
		if (toBase != 2 && toBase != 8 && toBase != 10 && toBase != 16)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidBase"));
		}
		return ParseNumbers.IntToString(value, toBase, -1, ' ', 128);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static string ToString(int value, int toBase)
	{
		if (toBase != 2 && toBase != 8 && toBase != 10 && toBase != 16)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidBase"));
		}
		return ParseNumbers.IntToString(value, toBase, -1, ' ', 0);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static string ToString(long value, int toBase)
	{
		if (toBase != 2 && toBase != 8 && toBase != 10 && toBase != 16)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidBase"));
		}
		return ParseNumbers.LongToString(value, toBase, -1, ' ', 0);
	}

	[__DynamicallyInvokable]
	public static string ToBase64String(byte[] inArray)
	{
		if (inArray == null)
		{
			throw new ArgumentNullException("inArray");
		}
		return ToBase64String(inArray, 0, inArray.Length, Base64FormattingOptions.None);
	}

	[ComVisible(false)]
	public static string ToBase64String(byte[] inArray, Base64FormattingOptions options)
	{
		if (inArray == null)
		{
			throw new ArgumentNullException("inArray");
		}
		return ToBase64String(inArray, 0, inArray.Length, options);
	}

	[__DynamicallyInvokable]
	public static string ToBase64String(byte[] inArray, int offset, int length)
	{
		return ToBase64String(inArray, offset, length, Base64FormattingOptions.None);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public unsafe static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options)
	{
		if (inArray == null)
		{
			throw new ArgumentNullException("inArray");
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_GenericPositive"));
		}
		if (options < Base64FormattingOptions.None || options > Base64FormattingOptions.InsertLineBreaks)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)options));
		}
		int num = inArray.Length;
		if (offset > num - length)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_OffsetLength"));
		}
		if (num == 0)
		{
			return string.Empty;
		}
		bool insertLineBreaks = options == Base64FormattingOptions.InsertLineBreaks;
		int length2 = ToBase64_CalculateAndValidateOutputLength(length, insertLineBreaks);
		string text = string.FastAllocateString(length2);
		fixed (char* outChars = text)
		{
			fixed (byte* inData = inArray)
			{
				int num2 = ConvertToBase64Array(outChars, inData, offset, length, insertLineBreaks);
				return text;
			}
		}
	}

	[__DynamicallyInvokable]
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut)
	{
		return ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut, Base64FormattingOptions.None);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public unsafe static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options)
	{
		if (inArray == null)
		{
			throw new ArgumentNullException("inArray");
		}
		if (outArray == null)
		{
			throw new ArgumentNullException("outArray");
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (offsetIn < 0)
		{
			throw new ArgumentOutOfRangeException("offsetIn", Environment.GetResourceString("ArgumentOutOfRange_GenericPositive"));
		}
		if (offsetOut < 0)
		{
			throw new ArgumentOutOfRangeException("offsetOut", Environment.GetResourceString("ArgumentOutOfRange_GenericPositive"));
		}
		if (options < Base64FormattingOptions.None || options > Base64FormattingOptions.InsertLineBreaks)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)options));
		}
		int num = inArray.Length;
		if (offsetIn > num - length)
		{
			throw new ArgumentOutOfRangeException("offsetIn", Environment.GetResourceString("ArgumentOutOfRange_OffsetLength"));
		}
		if (num == 0)
		{
			return 0;
		}
		bool insertLineBreaks = options == Base64FormattingOptions.InsertLineBreaks;
		int num2 = outArray.Length;
		int num3 = ToBase64_CalculateAndValidateOutputLength(length, insertLineBreaks);
		if (offsetOut > num2 - num3)
		{
			throw new ArgumentOutOfRangeException("offsetOut", Environment.GetResourceString("ArgumentOutOfRange_OffsetOut"));
		}
		int result;
		fixed (char* outChars = &outArray[offsetOut])
		{
			fixed (byte* inData = inArray)
			{
				result = ConvertToBase64Array(outChars, inData, offsetIn, length, insertLineBreaks);
			}
		}
		return result;
	}

	[SecurityCritical]
	private unsafe static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks)
	{
		int num = length % 3;
		int num2 = offset + (length - num);
		int num3 = 0;
		int num4 = 0;
		fixed (char* ptr = base64Table)
		{
			int i;
			for (i = offset; i < num2; i += 3)
			{
				if (insertLineBreaks)
				{
					if (num4 == 76)
					{
						outChars[num3++] = '\r';
						outChars[num3++] = '\n';
						num4 = 0;
					}
					num4 += 4;
				}
				outChars[num3] = ptr[(inData[i] & 0xFC) >> 2];
				outChars[num3 + 1] = ptr[((inData[i] & 3) << 4) | ((inData[i + 1] & 0xF0) >> 4)];
				outChars[num3 + 2] = ptr[((inData[i + 1] & 0xF) << 2) | ((inData[i + 2] & 0xC0) >> 6)];
				outChars[num3 + 3] = ptr[inData[i + 2] & 0x3F];
				num3 += 4;
			}
			i = num2;
			if (insertLineBreaks && num != 0 && num4 == 76)
			{
				outChars[num3++] = '\r';
				outChars[num3++] = '\n';
			}
			switch (num)
			{
			case 2:
				outChars[num3] = ptr[(inData[i] & 0xFC) >> 2];
				outChars[num3 + 1] = ptr[((inData[i] & 3) << 4) | ((inData[i + 1] & 0xF0) >> 4)];
				outChars[num3 + 2] = ptr[(inData[i + 1] & 0xF) << 2];
				outChars[num3 + 3] = ptr[64];
				num3 += 4;
				break;
			case 1:
				outChars[num3] = ptr[(inData[i] & 0xFC) >> 2];
				outChars[num3 + 1] = ptr[(inData[i] & 3) << 4];
				outChars[num3 + 2] = ptr[64];
				outChars[num3 + 3] = ptr[64];
				num3 += 4;
				break;
			}
		}
		return num3;
	}

	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks)
	{
		long num = (long)inputLength / 3L * 4;
		num += ((inputLength % 3 != 0) ? 4 : 0);
		if (num == 0L)
		{
			return 0;
		}
		if (insertLineBreaks)
		{
			long num2 = num / 76;
			if (num % 76 == 0L)
			{
				num2--;
			}
			num += num2 * 2;
		}
		if (num > int.MaxValue)
		{
			throw new OutOfMemoryException();
		}
		return (int)num;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static byte[] FromBase64String(string s)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		fixed (char* inputPtr = s)
		{
			return FromBase64CharPtr(inputPtr, s.Length);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static byte[] FromBase64CharArray(char[] inArray, int offset, int length)
	{
		if (inArray == null)
		{
			throw new ArgumentNullException("inArray");
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_GenericPositive"));
		}
		if (offset > inArray.Length - length)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_OffsetLength"));
		}
		fixed (char* ptr = inArray)
		{
			return FromBase64CharPtr(ptr + offset, length);
		}
	}

	[SecurityCritical]
	private unsafe static byte[] FromBase64CharPtr(char* inputPtr, int inputLength)
	{
		while (inputLength > 0)
		{
			int num = inputPtr[inputLength - 1];
			if (num != 32 && num != 10 && num != 13 && num != 9)
			{
				break;
			}
			inputLength--;
		}
		int num2 = FromBase64_ComputeResultLength(inputPtr, inputLength);
		byte[] array = new byte[num2];
		fixed (byte* startDestPtr = array)
		{
			int num3 = FromBase64_Decode(inputPtr, inputLength, startDestPtr, num2);
		}
		return array;
	}

	[SecurityCritical]
	private unsafe static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength)
	{
		char* ptr = startInputPtr;
		byte* ptr2 = startDestPtr;
		char* ptr3 = ptr + inputLength;
		byte* ptr4 = ptr2 + destLength;
		uint num = 255u;
		while (ptr < ptr3)
		{
			uint num2 = *ptr;
			ptr++;
			if (num2 - 65 <= 25)
			{
				num2 -= 65;
			}
			else if (num2 - 97 <= 25)
			{
				num2 -= 71;
			}
			else if (num2 - 48 <= 9)
			{
				num2 -= 4294967292u;
			}
			else
			{
				if (num2 <= 32)
				{
					if (num2 - 9 <= 1 || num2 == 13 || num2 == 32)
					{
						continue;
					}
					goto IL_0097;
				}
				if (num2 != 43)
				{
					if (num2 != 47)
					{
						if (num2 != 61)
						{
							goto IL_0097;
						}
						if (ptr == ptr3)
						{
							num <<= 6;
							if ((num & 0x80000000u) == 0)
							{
								throw new FormatException(Environment.GetResourceString("Format_BadBase64CharArrayLength"));
							}
							if ((int)(ptr4 - ptr2) < 2)
							{
								return -1;
							}
							*(ptr2++) = (byte)(num >> 16);
							*(ptr2++) = (byte)(num >> 8);
							num = 255u;
							break;
						}
						for (; ptr < ptr3 - 1; ptr++)
						{
							int num3 = *ptr;
							if (num3 != 32 && num3 != 10 && num3 != 13 && num3 != 9)
							{
								break;
							}
						}
						if (ptr == ptr3 - 1 && *ptr == '=')
						{
							num <<= 12;
							if ((num & 0x80000000u) == 0)
							{
								throw new FormatException(Environment.GetResourceString("Format_BadBase64CharArrayLength"));
							}
							if ((int)(ptr4 - ptr2) < 1)
							{
								return -1;
							}
							*(ptr2++) = (byte)(num >> 16);
							num = 255u;
							break;
						}
						throw new FormatException(Environment.GetResourceString("Format_BadBase64Char"));
					}
					num2 = 63u;
				}
				else
				{
					num2 = 62u;
				}
			}
			num = (num << 6) | num2;
			if ((num & 0x80000000u) != 0)
			{
				if ((int)(ptr4 - ptr2) < 3)
				{
					return -1;
				}
				*ptr2 = (byte)(num >> 16);
				ptr2[1] = (byte)(num >> 8);
				ptr2[2] = (byte)num;
				ptr2 += 3;
				num = 255u;
			}
			continue;
			IL_0097:
			throw new FormatException(Environment.GetResourceString("Format_BadBase64Char"));
		}
		if (num != 255)
		{
			throw new FormatException(Environment.GetResourceString("Format_BadBase64CharArrayLength"));
		}
		return (int)(ptr2 - startDestPtr);
	}

	[SecurityCritical]
	private unsafe static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength)
	{
		char* ptr = inputPtr + inputLength;
		int num = inputLength;
		int num2 = 0;
		while (inputPtr < ptr)
		{
			uint num3 = *inputPtr;
			inputPtr++;
			switch (num3)
			{
			case 0u:
			case 1u:
			case 2u:
			case 3u:
			case 4u:
			case 5u:
			case 6u:
			case 7u:
			case 8u:
			case 9u:
			case 10u:
			case 11u:
			case 12u:
			case 13u:
			case 14u:
			case 15u:
			case 16u:
			case 17u:
			case 18u:
			case 19u:
			case 20u:
			case 21u:
			case 22u:
			case 23u:
			case 24u:
			case 25u:
			case 26u:
			case 27u:
			case 28u:
			case 29u:
			case 30u:
			case 31u:
			case 32u:
				num--;
				break;
			case 61u:
				num--;
				num2++;
				break;
			}
		}
		switch (num2)
		{
		case 1:
			num2 = 2;
			break;
		case 2:
			num2 = 1;
			break;
		default:
			throw new FormatException(Environment.GetResourceString("Format_BadBase64Char"));
		case 0:
			break;
		}
		return num / 4 * 3 + num2;
	}
}
