using System.Diagnostics;
using System.Reflection.Internal;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Reflection.Metadata;

[DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
internal struct BlobReader
{
	private static readonly char[] s_nullCharArray = new char[1];

	internal const int InvalidCompressedInteger = int.MaxValue;

	private readonly MemoryBlock _block;

	[SecurityCritical]
	private unsafe readonly byte* _endPointer;

	[SecurityCritical]
	private unsafe byte* _currentPointer;

	public unsafe byte* StartPointer
	{
		[SecurityCritical]
		get
		{
			return _block.Pointer;
		}
	}

	public unsafe byte* CurrentPointer
	{
		[SecurityCritical]
		get
		{
			return _currentPointer;
		}
	}

	public int Length => _block.Length;

	public unsafe int Offset
	{
		[SecuritySafeCritical]
		get
		{
			return (int)(_currentPointer - _block.Pointer);
		}
		[SecuritySafeCritical]
		set
		{
			if ((uint)value > (uint)_block.Length)
			{
				Throw.OutOfBounds();
			}
			_currentPointer = _block.Pointer + value;
		}
	}

	public unsafe int RemainingBytes
	{
		[SecuritySafeCritical]
		get
		{
			return (int)(_endPointer - _currentPointer);
		}
	}

	[SecurityCritical]
	public unsafe BlobReader(byte* buffer, int length)
		: this(MemoryBlock.CreateChecked(buffer, length))
	{
	}

	[SecuritySafeCritical]
	internal unsafe BlobReader(MemoryBlock block)
	{
		_block = block;
		_currentPointer = block.Pointer;
		_endPointer = block.Pointer + block.Length;
	}

	[SecuritySafeCritical]
	internal unsafe string GetDebuggerDisplay()
	{
		if (_block.Pointer == null)
		{
			return "<null>";
		}
		int displayedBytes;
		string debuggerDisplay = _block.GetDebuggerDisplay(out displayedBytes);
		if (Offset < displayedBytes)
		{
			return debuggerDisplay.Insert(Offset * 3, "*");
		}
		if (displayedBytes == _block.Length)
		{
			return debuggerDisplay + "*";
		}
		return debuggerDisplay + "*...";
	}

	[SecuritySafeCritical]
	public unsafe void Reset()
	{
		_currentPointer = _block.Pointer;
	}

	public void Align(byte alignment)
	{
		if (!TryAlign(alignment))
		{
			Throw.OutOfBounds();
		}
	}

	[SecuritySafeCritical]
	internal unsafe bool TryAlign(byte alignment)
	{
		int num = Offset & (alignment - 1);
		if (num != 0)
		{
			int num2 = alignment - num;
			if (num2 > RemainingBytes)
			{
				return false;
			}
			_currentPointer += num2;
		}
		return true;
	}

	[SecuritySafeCritical]
	internal unsafe MemoryBlock GetMemoryBlockAt(int offset, int length)
	{
		CheckBounds(offset, length);
		return new MemoryBlock(_currentPointer + offset, length);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecuritySafeCritical]
	private unsafe void CheckBounds(int offset, int byteCount)
	{
		if ((ulong)((long)(uint)offset + (long)(uint)byteCount) > (ulong)(_endPointer - _currentPointer))
		{
			Throw.OutOfBounds();
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecuritySafeCritical]
	private unsafe void CheckBounds(int byteCount)
	{
		if ((uint)byteCount > _endPointer - _currentPointer)
		{
			Throw.OutOfBounds();
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecurityCritical]
	private unsafe byte* GetCurrentPointerAndAdvance(int length)
	{
		byte* currentPointer = _currentPointer;
		if ((uint)length > (uint)(_endPointer - currentPointer))
		{
			Throw.OutOfBounds();
		}
		_currentPointer = currentPointer + length;
		return currentPointer;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecurityCritical]
	private unsafe byte* GetCurrentPointerAndAdvance1()
	{
		byte* currentPointer = _currentPointer;
		if (currentPointer == _endPointer)
		{
			Throw.OutOfBounds();
		}
		_currentPointer = currentPointer + 1;
		return currentPointer;
	}

	public bool ReadBoolean()
	{
		return ReadByte() != 0;
	}

	[SecuritySafeCritical]
	public unsafe sbyte ReadSByte()
	{
		return (sbyte)(*GetCurrentPointerAndAdvance1());
	}

	[SecuritySafeCritical]
	public unsafe byte ReadByte()
	{
		return *GetCurrentPointerAndAdvance1();
	}

	[SecuritySafeCritical]
	public unsafe char ReadChar()
	{
		byte* currentPointerAndAdvance = GetCurrentPointerAndAdvance(2);
		return (char)(*currentPointerAndAdvance + (currentPointerAndAdvance[1] << 8));
	}

	[SecuritySafeCritical]
	public unsafe short ReadInt16()
	{
		byte* currentPointerAndAdvance = GetCurrentPointerAndAdvance(2);
		return (short)(*currentPointerAndAdvance + (currentPointerAndAdvance[1] << 8));
	}

	[SecuritySafeCritical]
	public unsafe ushort ReadUInt16()
	{
		byte* currentPointerAndAdvance = GetCurrentPointerAndAdvance(2);
		return (ushort)(*currentPointerAndAdvance + (currentPointerAndAdvance[1] << 8));
	}

	[SecuritySafeCritical]
	public unsafe int ReadInt32()
	{
		byte* currentPointerAndAdvance = GetCurrentPointerAndAdvance(4);
		return *currentPointerAndAdvance + (currentPointerAndAdvance[1] << 8) + (currentPointerAndAdvance[2] << 16) + (currentPointerAndAdvance[3] << 24);
	}

	[SecuritySafeCritical]
	public unsafe uint ReadUInt32()
	{
		byte* currentPointerAndAdvance = GetCurrentPointerAndAdvance(4);
		return (uint)(*currentPointerAndAdvance + (currentPointerAndAdvance[1] << 8) + (currentPointerAndAdvance[2] << 16) + (currentPointerAndAdvance[3] << 24));
	}

	[SecuritySafeCritical]
	public unsafe long ReadInt64()
	{
		byte* currentPointerAndAdvance = GetCurrentPointerAndAdvance(8);
		uint num = (uint)(*currentPointerAndAdvance + (currentPointerAndAdvance[1] << 8) + (currentPointerAndAdvance[2] << 16) + (currentPointerAndAdvance[3] << 24));
		uint num2 = (uint)(currentPointerAndAdvance[4] + (currentPointerAndAdvance[5] << 8) + (currentPointerAndAdvance[6] << 16) + (currentPointerAndAdvance[7] << 24));
		return (long)(num + ((ulong)num2 << 32));
	}

	public ulong ReadUInt64()
	{
		return (ulong)ReadInt64();
	}

	[SecuritySafeCritical]
	public unsafe float ReadSingle()
	{
		int num = ReadInt32();
		return *(float*)(&num);
	}

	[SecuritySafeCritical]
	public unsafe double ReadDouble()
	{
		long num = ReadInt64();
		return *(double*)(&num);
	}

	[SecuritySafeCritical]
	public unsafe Guid ReadGuid()
	{
		byte* currentPointerAndAdvance = GetCurrentPointerAndAdvance(16);
		if (BitConverter.IsLittleEndian)
		{
			return *(Guid*)currentPointerAndAdvance;
		}
		return new Guid(*currentPointerAndAdvance | (currentPointerAndAdvance[1] << 8) | (currentPointerAndAdvance[2] << 16) | (currentPointerAndAdvance[3] << 24), (short)(currentPointerAndAdvance[4] | (currentPointerAndAdvance[5] << 8)), (short)(currentPointerAndAdvance[6] | (currentPointerAndAdvance[7] << 8)), currentPointerAndAdvance[8], currentPointerAndAdvance[9], currentPointerAndAdvance[10], currentPointerAndAdvance[11], currentPointerAndAdvance[12], currentPointerAndAdvance[13], currentPointerAndAdvance[14], currentPointerAndAdvance[15]);
	}

	[SecuritySafeCritical]
	public unsafe decimal ReadDecimal()
	{
		byte* currentPointerAndAdvance = GetCurrentPointerAndAdvance(13);
		byte b = (byte)(*currentPointerAndAdvance & 0x7F);
		if (b > 28)
		{
			throw new BadImageFormatException("ValueTooLarge");
		}
		return new decimal(currentPointerAndAdvance[1] | (currentPointerAndAdvance[2] << 8) | (currentPointerAndAdvance[3] << 16) | (currentPointerAndAdvance[4] << 24), currentPointerAndAdvance[5] | (currentPointerAndAdvance[6] << 8) | (currentPointerAndAdvance[7] << 16) | (currentPointerAndAdvance[8] << 24), currentPointerAndAdvance[9] | (currentPointerAndAdvance[10] << 8) | (currentPointerAndAdvance[11] << 16) | (currentPointerAndAdvance[12] << 24), (*currentPointerAndAdvance & 0x80) != 0, b);
	}

	public DateTime ReadDateTime()
	{
		return new DateTime(ReadInt64());
	}

	public int IndexOf(byte value)
	{
		int offset = Offset;
		int num = _block.IndexOfUnchecked(value, offset);
		if (num < 0)
		{
			return -1;
		}
		return num - offset;
	}

	[SecuritySafeCritical]
	public unsafe string ReadUTF8(int byteCount)
	{
		string result = _block.PeekUtf8(Offset, byteCount);
		_currentPointer += byteCount;
		return result;
	}

	[SecuritySafeCritical]
	public unsafe string ReadUTF16(int byteCount)
	{
		string result = _block.PeekUtf16(Offset, byteCount);
		_currentPointer += byteCount;
		return result;
	}

	[SecuritySafeCritical]
	public unsafe byte[] ReadBytes(int byteCount)
	{
		byte[] result = _block.PeekBytes(Offset, byteCount);
		_currentPointer += byteCount;
		return result;
	}

	[SecuritySafeCritical]
	public unsafe void ReadBytes(int byteCount, byte[] buffer, int bufferOffset)
	{
		Marshal.Copy((IntPtr)GetCurrentPointerAndAdvance(byteCount), buffer, bufferOffset, byteCount);
	}

	[SecuritySafeCritical]
	internal unsafe string ReadUtf8NullTerminated()
	{
		int numberOfBytesRead;
		string result = _block.PeekUtf8NullTerminated(Offset, out numberOfBytesRead);
		_currentPointer += numberOfBytesRead;
		return result;
	}

	[SecuritySafeCritical]
	private unsafe int ReadCompressedIntegerOrInvalid()
	{
		int numberOfBytesRead;
		int result = _block.PeekCompressedInteger(Offset, out numberOfBytesRead);
		_currentPointer += numberOfBytesRead;
		return result;
	}

	public bool TryReadCompressedInteger(out int value)
	{
		value = ReadCompressedIntegerOrInvalid();
		return value != int.MaxValue;
	}

	public int ReadCompressedInteger()
	{
		if (!TryReadCompressedInteger(out var value))
		{
			Throw.InvalidCompressedInteger();
		}
		return value;
	}

	[SecuritySafeCritical]
	public unsafe bool TryReadCompressedSignedInteger(out int value)
	{
		value = _block.PeekCompressedInteger(Offset, out var numberOfBytesRead);
		if (value == int.MaxValue)
		{
			return false;
		}
		bool flag = (value & 1) != 0;
		value >>= 1;
		if (flag)
		{
			switch (numberOfBytesRead)
			{
			case 1:
				value |= -64;
				break;
			case 2:
				value |= -8192;
				break;
			default:
				value |= -268435456;
				break;
			}
		}
		_currentPointer += numberOfBytesRead;
		return true;
	}

	public int ReadCompressedSignedInteger()
	{
		if (!TryReadCompressedSignedInteger(out var value))
		{
			Throw.InvalidCompressedInteger();
		}
		return value;
	}

	public BlobHandle ReadBlobHandle()
	{
		return BlobHandle.FromOffset(ReadCompressedInteger());
	}
}
