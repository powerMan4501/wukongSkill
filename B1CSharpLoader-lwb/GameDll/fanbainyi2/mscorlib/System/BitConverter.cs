using System.Security;

namespace System;

[__DynamicallyInvokable]
public static class BitConverter
{
	[__DynamicallyInvokable]
	public static readonly bool IsLittleEndian = true;

	[__DynamicallyInvokable]
	public static byte[] GetBytes(bool value)
	{
		return new byte[1] { (byte)(value ? 1 : 0) };
	}

	[__DynamicallyInvokable]
	public static byte[] GetBytes(char value)
	{
		return GetBytes((short)value);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static byte[] GetBytes(short value)
	{
		byte[] array = new byte[2];
		fixed (byte* ptr = array)
		{
			*(short*)ptr = value;
		}
		return array;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static byte[] GetBytes(int value)
	{
		byte[] array = new byte[4];
		fixed (byte* ptr = array)
		{
			*(int*)ptr = value;
		}
		return array;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static byte[] GetBytes(long value)
	{
		byte[] array = new byte[8];
		fixed (byte* ptr = array)
		{
			*(long*)ptr = value;
		}
		return array;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static byte[] GetBytes(ushort value)
	{
		return GetBytes((short)value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static byte[] GetBytes(uint value)
	{
		return GetBytes((int)value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static byte[] GetBytes(ulong value)
	{
		return GetBytes((long)value);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static byte[] GetBytes(float value)
	{
		return GetBytes(*(int*)(&value));
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static byte[] GetBytes(double value)
	{
		return GetBytes(*(long*)(&value));
	}

	[__DynamicallyInvokable]
	public static char ToChar(byte[] value, int startIndex)
	{
		if (value == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
		}
		if ((uint)startIndex >= value.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
		}
		if (startIndex > value.Length - 2)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		return (char)ToInt16(value, startIndex);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static short ToInt16(byte[] value, int startIndex)
	{
		if (value == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
		}
		if ((uint)startIndex >= value.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
		}
		if (startIndex > value.Length - 2)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		fixed (byte* ptr = &value[startIndex])
		{
			if (startIndex % 2 == 0)
			{
				return *(short*)ptr;
			}
			if (IsLittleEndian)
			{
				return (short)(*ptr | (ptr[1] << 8));
			}
			return (short)((*ptr << 8) | ptr[1]);
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static int ToInt32(byte[] value, int startIndex)
	{
		if (value == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
		}
		if ((uint)startIndex >= value.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
		}
		if (startIndex > value.Length - 4)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		fixed (byte* ptr = &value[startIndex])
		{
			if (startIndex % 4 == 0)
			{
				return *(int*)ptr;
			}
			if (IsLittleEndian)
			{
				return *ptr | (ptr[1] << 8) | (ptr[2] << 16) | (ptr[3] << 24);
			}
			return (*ptr << 24) | (ptr[1] << 16) | (ptr[2] << 8) | ptr[3];
		}
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static long ToInt64(byte[] value, int startIndex)
	{
		if (value == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
		}
		if ((uint)startIndex >= value.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
		}
		if (startIndex > value.Length - 8)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		fixed (byte* ptr = &value[startIndex])
		{
			if (startIndex % 8 == 0)
			{
				return *(long*)ptr;
			}
			if (IsLittleEndian)
			{
				int num = *ptr | (ptr[1] << 8) | (ptr[2] << 16) | (ptr[3] << 24);
				int num2 = ptr[4] | (ptr[5] << 8) | (ptr[6] << 16) | (ptr[7] << 24);
				return (uint)num | ((long)num2 << 32);
			}
			int num3 = (*ptr << 24) | (ptr[1] << 16) | (ptr[2] << 8) | ptr[3];
			int num4 = (ptr[4] << 24) | (ptr[5] << 16) | (ptr[6] << 8) | ptr[7];
			return (uint)num4 | ((long)num3 << 32);
		}
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(byte[] value, int startIndex)
	{
		if (value == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
		}
		if ((uint)startIndex >= value.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
		}
		if (startIndex > value.Length - 2)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		return (ushort)ToInt16(value, startIndex);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(byte[] value, int startIndex)
	{
		if (value == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
		}
		if ((uint)startIndex >= value.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
		}
		if (startIndex > value.Length - 4)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		return (uint)ToInt32(value, startIndex);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(byte[] value, int startIndex)
	{
		if (value == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
		}
		if ((uint)startIndex >= value.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
		}
		if (startIndex > value.Length - 8)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		return (ulong)ToInt64(value, startIndex);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static float ToSingle(byte[] value, int startIndex)
	{
		if (value == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
		}
		if ((uint)startIndex >= value.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
		}
		if (startIndex > value.Length - 4)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		int num = ToInt32(value, startIndex);
		return *(float*)(&num);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static double ToDouble(byte[] value, int startIndex)
	{
		if (value == null)
		{
			ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
		}
		if ((uint)startIndex >= value.Length)
		{
			ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
		}
		if (startIndex > value.Length - 8)
		{
			ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
		}
		long num = ToInt64(value, startIndex);
		return *(double*)(&num);
	}

	private static char GetHexValue(int i)
	{
		if (i < 10)
		{
			return (char)(i + 48);
		}
		return (char)(i - 10 + 65);
	}

	[__DynamicallyInvokable]
	public static string ToString(byte[] value, int startIndex, int length)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (startIndex < 0 || (startIndex >= value.Length && startIndex > 0))
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_StartIndex"));
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_GenericPositive"));
		}
		if (startIndex > value.Length - length)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_ArrayPlusOffTooSmall"));
		}
		if (length == 0)
		{
			return string.Empty;
		}
		if (length > 715827882)
		{
			throw new ArgumentOutOfRangeException("length", Environment.GetResourceString("ArgumentOutOfRange_LengthTooLarge", 715827882));
		}
		int num = length * 3;
		char[] array = new char[num];
		int num2 = 0;
		int num3 = startIndex;
		for (num2 = 0; num2 < num; num2 += 3)
		{
			byte b = value[num3++];
			array[num2] = GetHexValue(b / 16);
			array[num2 + 1] = GetHexValue(b % 16);
			array[num2 + 2] = '-';
		}
		return new string(array, 0, array.Length - 1);
	}

	[__DynamicallyInvokable]
	public static string ToString(byte[] value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return ToString(value, 0, value.Length);
	}

	[__DynamicallyInvokable]
	public static string ToString(byte[] value, int startIndex)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return ToString(value, startIndex, value.Length - startIndex);
	}

	[__DynamicallyInvokable]
	public static bool ToBoolean(byte[] value, int startIndex)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (startIndex > value.Length - 1)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (value[startIndex] != 0)
		{
			return true;
		}
		return false;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static long DoubleToInt64Bits(double value)
	{
		return *(long*)(&value);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe static double Int64BitsToDouble(long value)
	{
		return *(double*)(&value);
	}
}
