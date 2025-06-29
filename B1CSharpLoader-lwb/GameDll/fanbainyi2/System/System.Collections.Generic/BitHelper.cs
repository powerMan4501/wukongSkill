using System.Security;

namespace System.Collections.Generic;

internal class BitHelper
{
	private const byte MarkedBitFlag = 1;

	private const byte IntSize = 32;

	private int m_length;

	[SecurityCritical]
	private unsafe int* m_arrayPtr;

	private int[] m_array;

	private bool useStackAlloc;

	[SecurityCritical]
	internal unsafe BitHelper(int* bitArrayPtr, int length)
	{
		m_arrayPtr = bitArrayPtr;
		m_length = length;
		useStackAlloc = true;
	}

	internal BitHelper(int[] bitArray, int length)
	{
		m_array = bitArray;
		m_length = length;
	}

	[SecurityCritical]
	internal unsafe void MarkBit(int bitPosition)
	{
		if (useStackAlloc)
		{
			int num = bitPosition / 32;
			if (num < m_length && num >= 0)
			{
				m_arrayPtr[num] |= 1 << bitPosition % 32;
			}
		}
		else
		{
			int num2 = bitPosition / 32;
			if (num2 < m_length && num2 >= 0)
			{
				m_array[num2] |= 1 << bitPosition % 32;
			}
		}
	}

	[SecurityCritical]
	internal unsafe bool IsMarked(int bitPosition)
	{
		if (useStackAlloc)
		{
			int num = bitPosition / 32;
			if (num < m_length && num >= 0)
			{
				return (m_arrayPtr[num] & (1 << bitPosition % 32)) != 0;
			}
			return false;
		}
		int num2 = bitPosition / 32;
		if (num2 < m_length && num2 >= 0)
		{
			return (m_array[num2] & (1 << bitPosition % 32)) != 0;
		}
		return false;
	}

	internal static int ToIntArrayLength(int n)
	{
		if (n <= 0)
		{
			return 0;
		}
		return (n - 1) / 32 + 1;
	}
}
