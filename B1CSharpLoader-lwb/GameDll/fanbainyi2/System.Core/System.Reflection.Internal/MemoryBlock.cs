using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

namespace System.Reflection.Internal;

[DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
internal struct MemoryBlock
{
	[SecurityCritical]
	internal unsafe readonly byte* Pointer;

	internal readonly int Length;

	[SecurityCritical]
	internal unsafe MemoryBlock(byte* buffer, int length)
	{
		Pointer = buffer;
		Length = length;
	}

	[SecurityCritical]
	internal unsafe static MemoryBlock CreateChecked(byte* buffer, int length)
	{
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		if (buffer == null && length != 0)
		{
			throw new ArgumentNullException("buffer");
		}
		return new MemoryBlock(buffer, length);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void CheckBounds(int offset, int byteCount)
	{
		if ((ulong)((long)(uint)offset + (long)(uint)byteCount) > (ulong)Length)
		{
			Throw.OutOfBounds();
		}
	}

	[SecuritySafeCritical]
	internal unsafe byte[] ToArray()
	{
		if (Pointer != null)
		{
			return PeekBytes(0, Length);
		}
		return null;
	}

	[SecuritySafeCritical]
	private unsafe string GetDebuggerDisplay()
	{
		if (Pointer == null)
		{
			return "<null>";
		}
		int displayedBytes;
		return GetDebuggerDisplay(out displayedBytes);
	}

	internal string GetDebuggerDisplay(out int displayedBytes)
	{
		displayedBytes = Math.Min(Length, 64);
		string text = BitConverter.ToString(PeekBytes(0, displayedBytes));
		if (displayedBytes < Length)
		{
			text += "-...";
		}
		return text;
	}

	[SecuritySafeCritical]
	internal unsafe string GetDebuggerDisplay(int offset)
	{
		if (Pointer == null)
		{
			return "<null>";
		}
		int displayedBytes;
		string debuggerDisplay = GetDebuggerDisplay(out displayedBytes);
		if (offset < displayedBytes)
		{
			return debuggerDisplay.Insert(offset * 3, "*");
		}
		if (displayedBytes == Length)
		{
			return debuggerDisplay + "*";
		}
		return debuggerDisplay + "*...";
	}

	[SecuritySafeCritical]
	internal unsafe MemoryBlock GetMemoryBlockAt(int offset, int length)
	{
		CheckBounds(offset, length);
		return new MemoryBlock(Pointer + offset, length);
	}

	[SecuritySafeCritical]
	internal unsafe byte PeekByte(int offset)
	{
		CheckBounds(offset, 1);
		return Pointer[offset];
	}

	internal int PeekInt32(int offset)
	{
		uint num = PeekUInt32(offset);
		if ((int)num != num)
		{
			Throw.ValueOverflow();
		}
		return (int)num;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecuritySafeCritical]
	internal unsafe uint PeekUInt32(int offset)
	{
		CheckBounds(offset, 4);
		byte* ptr = Pointer + offset;
		return (uint)(*ptr | (ptr[1] << 8) | (ptr[2] << 16) | (ptr[3] << 24));
	}

	[SecuritySafeCritical]
	internal unsafe int PeekCompressedInteger(int offset, out int numberOfBytesRead)
	{
		CheckBounds(offset, 0);
		byte* ptr = Pointer + offset;
		long num = Length - offset;
		if (num == 0L)
		{
			numberOfBytesRead = 0;
			return int.MaxValue;
		}
		byte b = *ptr;
		if ((b & 0x80) == 0)
		{
			numberOfBytesRead = 1;
			return b;
		}
		if ((b & 0x40) == 0)
		{
			if (num >= 2)
			{
				numberOfBytesRead = 2;
				return ((b & 0x3F) << 8) | ptr[1];
			}
		}
		else if ((b & 0x20) == 0 && num >= 4)
		{
			numberOfBytesRead = 4;
			return ((b & 0x1F) << 24) | (ptr[1] << 16) | (ptr[2] << 8) | ptr[3];
		}
		numberOfBytesRead = 0;
		return int.MaxValue;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecuritySafeCritical]
	internal unsafe ushort PeekUInt16(int offset)
	{
		CheckBounds(offset, 2);
		byte* ptr = Pointer + offset;
		return (ushort)(*ptr | (ptr[1] << 8));
	}

	internal uint PeekTaggedReference(int offset, bool smallRefSize)
	{
		return PeekReferenceUnchecked(offset, smallRefSize);
	}

	internal uint PeekReferenceUnchecked(int offset, bool smallRefSize)
	{
		if (!smallRefSize)
		{
			return PeekUInt32(offset);
		}
		return PeekUInt16(offset);
	}

	internal int PeekReference(int offset, bool smallRefSize)
	{
		if (smallRefSize)
		{
			return PeekUInt16(offset);
		}
		uint num = PeekUInt32(offset);
		if (!TokenTypeIds.IsValidRowId(num))
		{
			Throw.ReferenceOverflow();
		}
		return (int)num;
	}

	internal int PeekHeapReference(int offset, bool smallRefSize)
	{
		if (smallRefSize)
		{
			return PeekUInt16(offset);
		}
		uint num = PeekUInt32(offset);
		if (!HeapHandleType.IsValidHeapOffset(num))
		{
			Throw.ReferenceOverflow();
		}
		return (int)num;
	}

	[SecuritySafeCritical]
	internal unsafe Guid PeekGuid(int offset)
	{
		CheckBounds(offset, sizeof(Guid));
		byte* ptr = Pointer + offset;
		if (BitConverter.IsLittleEndian)
		{
			return *(Guid*)ptr;
		}
		return new Guid(*ptr | (ptr[1] << 8) | (ptr[2] << 16) | (ptr[3] << 24), (short)(ptr[4] | (ptr[5] << 8)), (short)(ptr[6] | (ptr[7] << 8)), ptr[8], ptr[9], ptr[10], ptr[11], ptr[12], ptr[13], ptr[14], ptr[15]);
	}

	[SecuritySafeCritical]
	internal unsafe string PeekUtf16(int offset, int byteCount)
	{
		CheckBounds(offset, byteCount);
		byte* ptr = Pointer + offset;
		if (BitConverter.IsLittleEndian)
		{
			return new string((char*)ptr, 0, byteCount / 2);
		}
		return Encoding.Unicode.GetString(ptr, byteCount);
	}

	[SecuritySafeCritical]
	internal unsafe string PeekUtf8(int offset, int byteCount)
	{
		CheckBounds(offset, byteCount);
		return Encoding.UTF8.GetString(Pointer + offset, byteCount);
	}

	[SecuritySafeCritical]
	internal unsafe string PeekUtf8NullTerminated(int offset, out int numberOfBytesRead, char terminator = '\0')
	{
		CheckBounds(offset, 0);
		int utf8NullTerminatedLength = GetUtf8NullTerminatedLength(offset, out numberOfBytesRead, terminator);
		return new string((sbyte*)Pointer, offset, utf8NullTerminatedLength, Encoding.UTF8);
	}

	[SecuritySafeCritical]
	internal unsafe int GetUtf8NullTerminatedLength(int offset, out int numberOfBytesRead, char terminator = '\0')
	{
		CheckBounds(offset, 0);
		byte* ptr = Pointer + offset;
		byte* ptr2 = Pointer + Length;
		byte* ptr3;
		for (ptr3 = ptr; ptr3 < ptr2; ptr3++)
		{
			byte b = *ptr3;
			if (b == 0 || b == terminator)
			{
				break;
			}
		}
		int result = (numberOfBytesRead = (int)(ptr3 - ptr));
		if (ptr3 < ptr2)
		{
			numberOfBytesRead++;
		}
		return result;
	}

	[SecuritySafeCritical]
	internal unsafe byte[] PeekBytes(int offset, int byteCount)
	{
		CheckBounds(offset, byteCount);
		return BlobUtilities.ReadBytes(Pointer + offset, byteCount);
	}

	internal int IndexOf(byte b, int start)
	{
		CheckBounds(start, 0);
		return IndexOfUnchecked(b, start);
	}

	[SecuritySafeCritical]
	internal unsafe int IndexOfUnchecked(byte b, int start)
	{
		byte* ptr = Pointer + start;
		for (byte* ptr2 = Pointer + Length; ptr < ptr2; ptr++)
		{
			if (*ptr == b)
			{
				return (int)(ptr - Pointer);
			}
		}
		return -1;
	}

	internal int BinarySearchReference(int rowCount, int rowSize, int referenceOffset, uint referenceValue, bool isReferenceSmall)
	{
		int num = 0;
		int num2 = rowCount - 1;
		while (num <= num2)
		{
			int num3 = (num + num2) / 2;
			uint num4 = PeekReferenceUnchecked(num3 * rowSize + referenceOffset, isReferenceSmall);
			if (referenceValue > num4)
			{
				num = num3 + 1;
				continue;
			}
			if (referenceValue < num4)
			{
				num2 = num3 - 1;
				continue;
			}
			return num3;
		}
		return -1;
	}

	internal int BinarySearchReference(int[] ptrTable, int rowSize, int referenceOffset, uint referenceValue, bool isReferenceSmall)
	{
		int num = 0;
		int num2 = ptrTable.Length - 1;
		while (num <= num2)
		{
			int num3 = (num + num2) / 2;
			uint num4 = PeekReferenceUnchecked((ptrTable[num3] - 1) * rowSize + referenceOffset, isReferenceSmall);
			if (referenceValue > num4)
			{
				num = num3 + 1;
				continue;
			}
			if (referenceValue < num4)
			{
				num2 = num3 - 1;
				continue;
			}
			return num3;
		}
		return -1;
	}

	internal int[] BuildPtrTable(int numberOfRows, int rowSize, int referenceOffset, bool isReferenceSmall)
	{
		int[] array = new int[numberOfRows];
		uint[] unsortedReferences = new uint[numberOfRows];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i + 1;
		}
		ReadColumn(unsortedReferences, rowSize, referenceOffset, isReferenceSmall);
		Array.Sort(array, (int a, int b) => unsortedReferences[a - 1].CompareTo(unsortedReferences[b - 1]));
		return array;
	}

	private void ReadColumn(uint[] result, int rowSize, int referenceOffset, bool isReferenceSmall)
	{
		int num = referenceOffset;
		int length = Length;
		int num2 = 0;
		while (num < length)
		{
			result[num2] = PeekReferenceUnchecked(num, isReferenceSmall);
			num += rowSize;
			num2++;
		}
	}

	internal bool PeekHeapValueOffsetAndSize(int index, out int offset, out int size)
	{
		int numberOfBytesRead;
		int num = PeekCompressedInteger(index, out numberOfBytesRead);
		if (num == int.MaxValue)
		{
			offset = 0;
			size = 0;
			return false;
		}
		offset = index + numberOfBytesRead;
		size = num;
		return true;
	}
}
