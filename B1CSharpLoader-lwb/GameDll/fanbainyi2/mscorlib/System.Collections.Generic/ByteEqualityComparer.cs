using System.Security;

namespace System.Collections.Generic;

[Serializable]
internal class ByteEqualityComparer : EqualityComparer<byte>
{
	public override bool Equals(byte x, byte y)
	{
		return x == y;
	}

	public override int GetHashCode(byte b)
	{
		return b.GetHashCode();
	}

	[SecuritySafeCritical]
	internal unsafe override int IndexOf(byte[] array, byte value, int startIndex, int count)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (startIndex < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex", Environment.GetResourceString("ArgumentOutOfRange_Index"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_Count"));
		}
		if (count > array.Length - startIndex)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (count == 0)
		{
			return -1;
		}
		fixed (byte* src = array)
		{
			return Buffer.IndexOfByte(src, value, startIndex, count);
		}
	}

	internal override int LastIndexOf(byte[] array, byte value, int startIndex, int count)
	{
		int num = startIndex - count + 1;
		for (int num2 = startIndex; num2 >= num; num2--)
		{
			if (array[num2] == value)
			{
				return num2;
			}
		}
		return -1;
	}

	public override bool Equals(object obj)
	{
		ByteEqualityComparer byteEqualityComparer = obj as ByteEqualityComparer;
		return byteEqualityComparer != null;
	}

	public override int GetHashCode()
	{
		return GetType().Name.GetHashCode();
	}
}
