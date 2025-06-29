using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public abstract class Enum : ValueType, IComparable, IFormattable, IConvertible
{
	private enum ParseFailureKind
	{
		None,
		Argument,
		ArgumentNull,
		ArgumentWithParameter,
		UnhandledException
	}

	private struct EnumResult
	{
		internal object parsedEnum;

		internal bool canThrow;

		internal ParseFailureKind m_failure;

		internal string m_failureMessageID;

		internal string m_failureParameter;

		internal object m_failureMessageFormatArgument;

		internal Exception m_innerException;

		internal void Init(bool canMethodThrow)
		{
			parsedEnum = 0;
			canThrow = canMethodThrow;
		}

		internal void SetFailure(Exception unhandledException)
		{
			m_failure = ParseFailureKind.UnhandledException;
			m_innerException = unhandledException;
		}

		internal void SetFailure(ParseFailureKind failure, string failureParameter)
		{
			m_failure = failure;
			m_failureParameter = failureParameter;
			if (canThrow)
			{
				throw GetEnumParseException();
			}
		}

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
		{
			m_failure = failure;
			m_failureMessageID = failureMessageID;
			m_failureMessageFormatArgument = failureMessageFormatArgument;
			if (canThrow)
			{
				throw GetEnumParseException();
			}
		}

		internal Exception GetEnumParseException()
		{
			return m_failure switch
			{
				ParseFailureKind.Argument => new ArgumentException(Environment.GetResourceString(m_failureMessageID)), 
				ParseFailureKind.ArgumentNull => new ArgumentNullException(m_failureParameter), 
				ParseFailureKind.ArgumentWithParameter => new ArgumentException(Environment.GetResourceString(m_failureMessageID, m_failureMessageFormatArgument)), 
				ParseFailureKind.UnhandledException => m_innerException, 
				_ => new ArgumentException(Environment.GetResourceString("Arg_EnumValueNotFound")), 
			};
		}
	}

	private class ValuesAndNames
	{
		public ulong[] Values;

		public string[] Names;

		public ValuesAndNames(ulong[] values, string[] names)
		{
			Values = values;
			Names = names;
		}
	}

	private static readonly char[] enumSeperatorCharArray = new char[1] { ',' };

	private const string enumSeperator = ", ";

	[SecuritySafeCritical]
	private static ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames)
	{
		ValuesAndNames valuesAndNames = enumType.GenericCache as ValuesAndNames;
		if (valuesAndNames == null || (getNames && valuesAndNames.Names == null))
		{
			ulong[] o = null;
			string[] o2 = null;
			GetEnumValuesAndNames(enumType.GetTypeHandleInternal(), JitHelpers.GetObjectHandleOnStack(ref o), JitHelpers.GetObjectHandleOnStack(ref o2), getNames);
			valuesAndNames = (ValuesAndNames)(enumType.GenericCache = new ValuesAndNames(o, o2));
		}
		return valuesAndNames;
	}

	private static string InternalFormattedHexString(object value)
	{
		return Convert.GetTypeCode(value) switch
		{
			TypeCode.SByte => ((byte)(sbyte)value).ToString("X2", null), 
			TypeCode.Byte => ((byte)value).ToString("X2", null), 
			TypeCode.Boolean => Convert.ToByte((bool)value).ToString("X2", null), 
			TypeCode.Int16 => ((ushort)(short)value).ToString("X4", null), 
			TypeCode.UInt16 => ((ushort)value).ToString("X4", null), 
			TypeCode.Char => ((ushort)(char)value).ToString("X4", null), 
			TypeCode.UInt32 => ((uint)value).ToString("X8", null), 
			TypeCode.Int32 => ((uint)(int)value).ToString("X8", null), 
			TypeCode.UInt64 => ((ulong)value).ToString("X16", null), 
			TypeCode.Int64 => ((ulong)(long)value).ToString("X16", null), 
			_ => throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_UnknownEnumType")), 
		};
	}

	private static string InternalFormat(RuntimeType eT, object value)
	{
		if (!eT.IsDefined(typeof(FlagsAttribute), inherit: false))
		{
			string name = GetName(eT, value);
			if (name == null)
			{
				return value.ToString();
			}
			return name;
		}
		return InternalFlagsFormat(eT, value);
	}

	private static string InternalFlagsFormat(RuntimeType eT, object value)
	{
		ulong num = ToUInt64(value);
		ValuesAndNames cachedValuesAndNames = GetCachedValuesAndNames(eT, getNames: true);
		string[] names = cachedValuesAndNames.Names;
		ulong[] values = cachedValuesAndNames.Values;
		int num2 = values.Length - 1;
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		ulong num3 = num;
		while (num2 >= 0 && (num2 != 0 || values[num2] != 0L))
		{
			if ((num & values[num2]) == values[num2])
			{
				num -= values[num2];
				if (!flag)
				{
					stringBuilder.Insert(0, ", ");
				}
				stringBuilder.Insert(0, names[num2]);
				flag = false;
			}
			num2--;
		}
		if (num != 0L)
		{
			return value.ToString();
		}
		if (num3 == 0L)
		{
			if (values.Length != 0 && values[0] == 0L)
			{
				return names[0];
			}
			return "0";
		}
		return stringBuilder.ToString();
	}

	internal static ulong ToUInt64(object value)
	{
		switch (Convert.GetTypeCode(value))
		{
		case TypeCode.SByte:
		case TypeCode.Int16:
		case TypeCode.Int32:
		case TypeCode.Int64:
			return (ulong)Convert.ToInt64(value, CultureInfo.InvariantCulture);
		case TypeCode.Boolean:
		case TypeCode.Char:
		case TypeCode.Byte:
		case TypeCode.UInt16:
		case TypeCode.UInt32:
		case TypeCode.UInt64:
			return Convert.ToUInt64(value, CultureInfo.InvariantCulture);
		default:
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_UnknownEnumType"));
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern int InternalCompareTo(object o1, object o2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	internal static extern RuntimeType InternalGetUnderlyingType(RuntimeType enumType);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void GetEnumValuesAndNames(RuntimeTypeHandle enumType, ObjectHandleOnStack values, ObjectHandleOnStack names, bool getNames);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern object InternalBoxEnum(RuntimeType enumType, long value);

	[__DynamicallyInvokable]
	public static bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct
	{
		return TryParse<TEnum>(value, ignoreCase: false, out result);
	}

	[__DynamicallyInvokable]
	public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct
	{
		result = default(TEnum);
		EnumResult parseResult = default(EnumResult);
		parseResult.Init(canMethodThrow: false);
		bool result2;
		if (result2 = TryParseEnum(typeof(TEnum), value, ignoreCase, ref parseResult))
		{
			result = (TEnum)parseResult.parsedEnum;
		}
		return result2;
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public static object Parse(Type enumType, string value)
	{
		return Parse(enumType, value, ignoreCase: false);
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public static object Parse(Type enumType, string value, bool ignoreCase)
	{
		EnumResult parseResult = default(EnumResult);
		parseResult.Init(canMethodThrow: true);
		if (TryParseEnum(enumType, value, ignoreCase, ref parseResult))
		{
			return parseResult.parsedEnum;
		}
		throw parseResult.GetEnumParseException();
	}

	private static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref EnumResult parseResult)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		RuntimeType runtimeType = enumType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "enumType");
		}
		if (!enumType.IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		if (value == null)
		{
			parseResult.SetFailure(ParseFailureKind.ArgumentNull, "value");
			return false;
		}
		value = value.Trim();
		if (value.Length == 0)
		{
			parseResult.SetFailure(ParseFailureKind.Argument, "Arg_MustContainEnumInfo", null);
			return false;
		}
		ulong num = 0uL;
		if (char.IsDigit(value[0]) || value[0] == '-' || value[0] == '+')
		{
			Type underlyingType = GetUnderlyingType(enumType);
			try
			{
				object value2 = Convert.ChangeType(value, underlyingType, CultureInfo.InvariantCulture);
				parseResult.parsedEnum = ToObject(enumType, value2);
				return true;
			}
			catch (FormatException)
			{
			}
			catch (Exception failure)
			{
				if (parseResult.canThrow)
				{
					throw;
				}
				parseResult.SetFailure(failure);
				return false;
			}
		}
		string[] array = value.Split(enumSeperatorCharArray);
		ValuesAndNames cachedValuesAndNames = GetCachedValuesAndNames(runtimeType, getNames: true);
		string[] names = cachedValuesAndNames.Names;
		ulong[] values = cachedValuesAndNames.Values;
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = array[i].Trim();
			bool flag = false;
			for (int j = 0; j < names.Length; j++)
			{
				if (ignoreCase)
				{
					if (string.Compare(names[j], array[i], StringComparison.OrdinalIgnoreCase) != 0)
					{
						continue;
					}
				}
				else if (!names[j].Equals(array[i]))
				{
					continue;
				}
				ulong num2 = values[j];
				num |= num2;
				flag = true;
				break;
			}
			if (!flag)
			{
				parseResult.SetFailure(ParseFailureKind.ArgumentWithParameter, "Arg_EnumValueNotFound", value);
				return false;
			}
		}
		try
		{
			parseResult.parsedEnum = ToObject(enumType, num);
			return true;
		}
		catch (Exception failure2)
		{
			if (parseResult.canThrow)
			{
				throw;
			}
			parseResult.SetFailure(failure2);
			return false;
		}
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public static Type GetUnderlyingType(Type enumType)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		return enumType.GetEnumUnderlyingType();
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public static Array GetValues(Type enumType)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		return enumType.GetEnumValues();
	}

	internal static ulong[] InternalGetValues(RuntimeType enumType)
	{
		return GetCachedValuesAndNames(enumType, getNames: false).Values;
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public static string GetName(Type enumType, object value)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		return enumType.GetEnumName(value);
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public static string[] GetNames(Type enumType)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		return enumType.GetEnumNames();
	}

	internal static string[] InternalGetNames(RuntimeType enumType)
	{
		return GetCachedValuesAndNames(enumType, getNames: true).Names;
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public static object ToObject(Type enumType, object value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		TypeCode typeCode = Convert.GetTypeCode(value);
		if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8 && (typeCode == TypeCode.Boolean || typeCode == TypeCode.Char))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnumBaseTypeOrEnum"), "value");
		}
		return typeCode switch
		{
			TypeCode.Int32 => ToObject(enumType, (int)value), 
			TypeCode.SByte => ToObject(enumType, (sbyte)value), 
			TypeCode.Int16 => ToObject(enumType, (short)value), 
			TypeCode.Int64 => ToObject(enumType, (long)value), 
			TypeCode.UInt32 => ToObject(enumType, (uint)value), 
			TypeCode.Byte => ToObject(enumType, (byte)value), 
			TypeCode.UInt16 => ToObject(enumType, (ushort)value), 
			TypeCode.UInt64 => ToObject(enumType, (ulong)value), 
			TypeCode.Char => ToObject(enumType, (char)value), 
			TypeCode.Boolean => ToObject(enumType, (bool)value), 
			_ => throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnumBaseTypeOrEnum"), "value"), 
		};
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public static bool IsDefined(Type enumType, object value)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		return enumType.IsEnumDefined(value);
	}

	[ComVisible(true)]
	[__DynamicallyInvokable]
	public static string Format(Type enumType, object value, string format)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		if (!enumType.IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		RuntimeType runtimeType = enumType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "enumType");
		}
		Type type = value.GetType();
		Type underlyingType = GetUnderlyingType(enumType);
		if (type.IsEnum)
		{
			Type underlyingType2 = GetUnderlyingType(type);
			if (!type.IsEquivalentTo(enumType))
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_EnumAndObjectMustBeSameType", type.ToString(), enumType.ToString()));
			}
			type = underlyingType2;
			value = ((Enum)value).GetValue();
		}
		else if (type != underlyingType)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumFormatUnderlyingTypeAndObjectMustBeSameType", type.ToString(), underlyingType.ToString()));
		}
		if (format.Length != 1)
		{
			throw new FormatException(Environment.GetResourceString("Format_InvalidEnumFormatSpecification"));
		}
		switch (format[0])
		{
		case 'D':
		case 'd':
			return value.ToString();
		case 'X':
		case 'x':
			return InternalFormattedHexString(value);
		case 'G':
		case 'g':
			return InternalFormat(runtimeType, value);
		case 'F':
		case 'f':
			return InternalFlagsFormat(runtimeType, value);
		default:
			throw new FormatException(Environment.GetResourceString("Format_InvalidEnumFormatSpecification"));
		}
	}

	[SecuritySafeCritical]
	internal unsafe object GetValue()
	{
		fixed (byte* data = &JitHelpers.GetPinningHelper(this).m_data)
		{
			void* ptr = data;
			return InternalGetCorElementType() switch
			{
				CorElementType.I1 => *(sbyte*)ptr, 
				CorElementType.U1 => *(byte*)ptr, 
				CorElementType.Boolean => *(bool*)ptr, 
				CorElementType.I2 => *(short*)ptr, 
				CorElementType.U2 => *(ushort*)ptr, 
				CorElementType.Char => *(char*)ptr, 
				CorElementType.I4 => *(int*)ptr, 
				CorElementType.U4 => *(uint*)ptr, 
				CorElementType.R4 => *(float*)ptr, 
				CorElementType.I8 => *(long*)ptr, 
				CorElementType.U8 => *(ulong*)ptr, 
				CorElementType.R8 => *(double*)ptr, 
				CorElementType.I => *(IntPtr*)ptr, 
				CorElementType.U => *(UIntPtr*)ptr, 
				_ => null, 
			};
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern bool InternalHasFlag(Enum flags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	private extern CorElementType InternalGetCorElementType();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public override extern bool Equals(object obj);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe override int GetHashCode()
	{
		fixed (byte* data = &JitHelpers.GetPinningHelper(this).m_data)
		{
			void* ptr = data;
			return InternalGetCorElementType() switch
			{
				CorElementType.I1 => ((sbyte*)ptr)->GetHashCode(), 
				CorElementType.U1 => ((byte*)ptr)->GetHashCode(), 
				CorElementType.Boolean => ((bool*)ptr)->GetHashCode(), 
				CorElementType.I2 => ((short*)ptr)->GetHashCode(), 
				CorElementType.U2 => ((ushort*)ptr)->GetHashCode(), 
				CorElementType.Char => ((char*)ptr)->GetHashCode(), 
				CorElementType.I4 => ((int*)ptr)->GetHashCode(), 
				CorElementType.U4 => ((uint*)ptr)->GetHashCode(), 
				CorElementType.R4 => ((float*)ptr)->GetHashCode(), 
				CorElementType.I8 => ((long*)ptr)->GetHashCode(), 
				CorElementType.U8 => ((ulong*)ptr)->GetHashCode(), 
				CorElementType.R8 => ((double*)ptr)->GetHashCode(), 
				CorElementType.I => ((IntPtr*)ptr)->GetHashCode(), 
				CorElementType.U => ((UIntPtr*)ptr)->GetHashCode(), 
				_ => 0, 
			};
		}
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		return InternalFormat((RuntimeType)GetType(), GetValue());
	}

	[Obsolete("The provider argument is not used. Please use ToString(String).")]
	public string ToString(string format, IFormatProvider provider)
	{
		return ToString(format);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public int CompareTo(object target)
	{
		if (this == null)
		{
			throw new NullReferenceException();
		}
		int num = InternalCompareTo(this, target);
		if (num < 2)
		{
			return num;
		}
		if (num == 2)
		{
			Type type = GetType();
			Type type2 = target.GetType();
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumAndObjectMustBeSameType", type2.ToString(), type.ToString()));
		}
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_UnknownEnumType"));
	}

	[__DynamicallyInvokable]
	public string ToString(string format)
	{
		if (format == null || format.Length == 0)
		{
			format = "G";
		}
		if (string.Compare(format, "G", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return ToString();
		}
		if (string.Compare(format, "D", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return GetValue().ToString();
		}
		if (string.Compare(format, "X", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return InternalFormattedHexString(GetValue());
		}
		if (string.Compare(format, "F", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return InternalFlagsFormat((RuntimeType)GetType(), GetValue());
		}
		throw new FormatException(Environment.GetResourceString("Format_InvalidEnumFormatSpecification"));
	}

	[Obsolete("The provider argument is not used. Please use ToString().")]
	public string ToString(IFormatProvider provider)
	{
		return ToString();
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public bool HasFlag(Enum flag)
	{
		if (flag == null)
		{
			throw new ArgumentNullException("flag");
		}
		if (!GetType().IsEquivalentTo(flag.GetType()))
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EnumTypeDoesNotMatch", flag.GetType(), GetType()));
		}
		return InternalHasFlag(flag);
	}

	public TypeCode GetTypeCode()
	{
		Type type = GetType();
		Type underlyingType = GetUnderlyingType(type);
		if (underlyingType == typeof(int))
		{
			return TypeCode.Int32;
		}
		if (underlyingType == typeof(sbyte))
		{
			return TypeCode.SByte;
		}
		if (underlyingType == typeof(short))
		{
			return TypeCode.Int16;
		}
		if (underlyingType == typeof(long))
		{
			return TypeCode.Int64;
		}
		if (underlyingType == typeof(uint))
		{
			return TypeCode.UInt32;
		}
		if (underlyingType == typeof(byte))
		{
			return TypeCode.Byte;
		}
		if (underlyingType == typeof(ushort))
		{
			return TypeCode.UInt16;
		}
		if (underlyingType == typeof(ulong))
		{
			return TypeCode.UInt64;
		}
		if (underlyingType == typeof(bool))
		{
			return TypeCode.Boolean;
		}
		if (underlyingType == typeof(char))
		{
			return TypeCode.Char;
		}
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_UnknownEnumType"));
	}

	[__DynamicallyInvokable]
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return Convert.ToBoolean(GetValue(), CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	char IConvertible.ToChar(IFormatProvider provider)
	{
		return Convert.ToChar(GetValue(), CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return Convert.ToSByte(GetValue(), CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return Convert.ToByte(GetValue(), CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return Convert.ToInt16(GetValue(), CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return Convert.ToUInt16(GetValue(), CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return Convert.ToInt32(GetValue(), CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return Convert.ToUInt32(GetValue(), CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return Convert.ToInt64(GetValue(), CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return Convert.ToUInt64(GetValue(), CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return Convert.ToSingle(GetValue(), CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return Convert.ToDouble(GetValue(), CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return Convert.ToDecimal(GetValue(), CultureInfo.CurrentCulture);
	}

	[__DynamicallyInvokable]
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Enum", "DateTime"));
	}

	[__DynamicallyInvokable]
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return Convert.DefaultToType(this, type, provider);
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	[ComVisible(true)]
	public static object ToObject(Type enumType, sbyte value)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		if (!enumType.IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		RuntimeType runtimeType = enumType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "enumType");
		}
		return InternalBoxEnum(runtimeType, value);
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public static object ToObject(Type enumType, short value)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		if (!enumType.IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		RuntimeType runtimeType = enumType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "enumType");
		}
		return InternalBoxEnum(runtimeType, value);
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public static object ToObject(Type enumType, int value)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		if (!enumType.IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		RuntimeType runtimeType = enumType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "enumType");
		}
		return InternalBoxEnum(runtimeType, value);
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public static object ToObject(Type enumType, byte value)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		if (!enumType.IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		RuntimeType runtimeType = enumType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "enumType");
		}
		return InternalBoxEnum(runtimeType, value);
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	[ComVisible(true)]
	public static object ToObject(Type enumType, ushort value)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		if (!enumType.IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		RuntimeType runtimeType = enumType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "enumType");
		}
		return InternalBoxEnum(runtimeType, value);
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	[ComVisible(true)]
	public static object ToObject(Type enumType, uint value)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		if (!enumType.IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		RuntimeType runtimeType = enumType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "enumType");
		}
		return InternalBoxEnum(runtimeType, value);
	}

	[SecuritySafeCritical]
	[ComVisible(true)]
	public static object ToObject(Type enumType, long value)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		if (!enumType.IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		RuntimeType runtimeType = enumType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "enumType");
		}
		return InternalBoxEnum(runtimeType, value);
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	[ComVisible(true)]
	public static object ToObject(Type enumType, ulong value)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		if (!enumType.IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		RuntimeType runtimeType = enumType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "enumType");
		}
		return InternalBoxEnum(runtimeType, (long)value);
	}

	[SecuritySafeCritical]
	private static object ToObject(Type enumType, char value)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		if (!enumType.IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		RuntimeType runtimeType = enumType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "enumType");
		}
		return InternalBoxEnum(runtimeType, value);
	}

	[SecuritySafeCritical]
	private static object ToObject(Type enumType, bool value)
	{
		if (enumType == null)
		{
			throw new ArgumentNullException("enumType");
		}
		if (!enumType.IsEnum)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeEnum"), "enumType");
		}
		RuntimeType runtimeType = enumType as RuntimeType;
		if (runtimeType == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeType"), "enumType");
		}
		return InternalBoxEnum(runtimeType, value ? 1 : 0);
	}

	[__DynamicallyInvokable]
	protected Enum()
	{
	}
}
