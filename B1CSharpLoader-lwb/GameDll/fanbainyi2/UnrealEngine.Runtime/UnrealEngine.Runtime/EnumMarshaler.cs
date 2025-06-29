using System;
using System.Globalization;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class EnumMarshaler<T> where T : struct, IConvertible
{
	private const int defaultSize = 1;

	private static readonly TypeCode typeCode;

	private static readonly int enumSize;

	static EnumMarshaler()
	{
		typeCode = Type.GetTypeCode(Enum.GetUnderlyingType(typeof(T)));
		switch (typeCode)
		{
		default:
			enumSize = 1;
			break;
		case TypeCode.Int16:
		case TypeCode.UInt16:
			enumSize = 2;
			break;
		case TypeCode.Int32:
		case TypeCode.UInt32:
			enumSize = 4;
			break;
		case TypeCode.Int64:
		case TypeCode.UInt64:
			enumSize = 8;
			break;
		}
	}

	public static T FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		int size = ((prop == IntPtr.Zero) ? enumSize : Native_FProperty.Get_ElementSize(prop));
		return FromNativeConvert(nativeBuffer, arrayIndex, size);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, T value)
	{
		int size = ((prop == IntPtr.Zero) ? enumSize : Native_FProperty.Get_ElementSize(prop));
		ToNativeConvert(nativeBuffer, arrayIndex, value, size);
	}

	private static T FromNativeConvert(IntPtr nativeBuffer, int arrayIndex, int size)
	{
		IntPtr address = nativeBuffer + arrayIndex * size;
		return typeCode switch
		{
			TypeCode.SByte => (T)(object)(sbyte)ReadValue(address, size), 
			TypeCode.Byte => (T)(object)(byte)ReadValue(address, size), 
			TypeCode.Int16 => (T)(object)(short)ReadValue(address, size), 
			TypeCode.UInt16 => (T)(object)(ushort)ReadValue(address, size), 
			TypeCode.Int32 => (T)(object)(int)ReadValue(address, size), 
			TypeCode.UInt32 => (T)(object)(uint)ReadValue(address, size), 
			TypeCode.Int64 => (T)(object)ReadValue(address, size), 
			TypeCode.UInt64 => (T)(object)(ulong)ReadValue(address, size), 
			_ => default(T), 
		};
	}

	public static void ToNativeConvert(IntPtr nativeBuffer, int arrayIndex, T value, int size)
	{
		IntPtr address = nativeBuffer + arrayIndex * size;
		switch (typeCode)
		{
		case TypeCode.SByte:
			WriteValue(address, size, value.ToSByte(CultureInfo.InvariantCulture));
			break;
		case TypeCode.Byte:
			WriteValue(address, size, value.ToByte(CultureInfo.InvariantCulture));
			break;
		case TypeCode.Int16:
			WriteValue(address, size, value.ToInt16(CultureInfo.InvariantCulture));
			break;
		case TypeCode.UInt16:
			WriteValue(address, size, value.ToUInt16(CultureInfo.InvariantCulture));
			break;
		case TypeCode.Int32:
			WriteValue(address, size, value.ToUInt32(CultureInfo.InvariantCulture));
			break;
		case TypeCode.UInt32:
			WriteValue(address, size, value.ToInt32(CultureInfo.InvariantCulture));
			break;
		case TypeCode.Int64:
			WriteValue(address, size, value.ToInt64(CultureInfo.InvariantCulture));
			break;
		case TypeCode.UInt64:
			WriteValue(address, size, (long)value.ToUInt64(CultureInfo.InvariantCulture));
			break;
		}
	}

	public static T FromNativeUnsafe(IntPtr nativeBuffer, int arrayIndex, int size)
	{
		_ = nativeBuffer + arrayIndex * size;
		return default(T);
	}

	private static void ToNativeUnsafe(IntPtr nativeBuffer, int arrayIndex, T value, int size)
	{
		_ = nativeBuffer + arrayIndex * size;
	}

	private unsafe static long ReadValue(IntPtr address, int size)
	{
		return size switch
		{
			2 => *(short*)(void*)address, 
			4 => *(int*)(void*)address, 
			8 => *(long*)(void*)address, 
			_ => *(byte*)(void*)address, 
		};
	}

	private unsafe static void WriteValue(IntPtr address, int size, long value)
	{
		switch (size)
		{
		default:
			*(byte*)(void*)address = (byte)value;
			break;
		case 2:
			*(short*)(void*)address = (short)value;
			break;
		case 4:
			*(int*)(void*)address = (int)value;
			break;
		case 8:
			*(long*)(void*)address = value;
			break;
		}
	}
}
