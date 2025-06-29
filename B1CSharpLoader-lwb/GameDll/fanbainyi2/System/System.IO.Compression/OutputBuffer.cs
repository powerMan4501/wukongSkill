namespace System.IO.Compression;

internal class OutputBuffer
{
	internal struct BufferState
	{
		internal int pos;

		internal uint bitBuf;

		internal int bitCount;
	}

	private byte[] byteBuffer;

	private int pos;

	private uint bitBuf;

	private int bitCount;

	internal int BytesWritten => pos;

	internal int FreeBytes => byteBuffer.Length - pos;

	internal int BitsInBuffer => bitCount / 8 + 1;

	internal void UpdateBuffer(byte[] output)
	{
		byteBuffer = output;
		pos = 0;
	}

	internal void WriteUInt16(ushort value)
	{
		byteBuffer[pos++] = (byte)value;
		byteBuffer[pos++] = (byte)(value >> 8);
	}

	internal void WriteBits(int n, uint bits)
	{
		bitBuf |= bits << bitCount;
		bitCount += n;
		if (bitCount >= 16)
		{
			byteBuffer[pos++] = (byte)bitBuf;
			byteBuffer[pos++] = (byte)(bitBuf >> 8);
			bitCount -= 16;
			bitBuf >>= 16;
		}
	}

	internal void FlushBits()
	{
		while (bitCount >= 8)
		{
			byteBuffer[pos++] = (byte)bitBuf;
			bitCount -= 8;
			bitBuf >>= 8;
		}
		if (bitCount > 0)
		{
			byteBuffer[pos++] = (byte)bitBuf;
			bitBuf = 0u;
			bitCount = 0;
		}
	}

	internal void WriteBytes(byte[] byteArray, int offset, int count)
	{
		if (bitCount == 0)
		{
			Array.Copy(byteArray, offset, byteBuffer, pos, count);
			pos += count;
		}
		else
		{
			WriteBytesUnaligned(byteArray, offset, count);
		}
	}

	private void WriteBytesUnaligned(byte[] byteArray, int offset, int count)
	{
		for (int i = 0; i < count; i++)
		{
			byte b = byteArray[offset + i];
			WriteByteUnaligned(b);
		}
	}

	private void WriteByteUnaligned(byte b)
	{
		WriteBits(8, b);
	}

	internal BufferState DumpState()
	{
		BufferState result = default(BufferState);
		result.pos = pos;
		result.bitBuf = bitBuf;
		result.bitCount = bitCount;
		return result;
	}

	internal void RestoreState(BufferState state)
	{
		pos = state.pos;
		bitBuf = state.bitBuf;
		bitCount = state.bitCount;
	}
}
