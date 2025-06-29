using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace System.IO;

[ComVisible(true)]
[__DynamicallyInvokable]
public class BinaryReader : IDisposable
{
	private const int MaxCharBytesSize = 128;

	private Stream m_stream;

	private byte[] m_buffer;

	private Decoder m_decoder;

	private byte[] m_charBytes;

	private char[] m_singleChar;

	private char[] m_charBuffer;

	private int m_maxCharsSize;

	private bool m_2BytesPerChar;

	private bool m_isMemoryStream;

	private bool m_leaveOpen;

	[__DynamicallyInvokable]
	public virtual Stream BaseStream
	{
		[__DynamicallyInvokable]
		get
		{
			return m_stream;
		}
	}

	[__DynamicallyInvokable]
	public BinaryReader(Stream input)
		: this(input, new UTF8Encoding(), leaveOpen: false)
	{
	}

	[__DynamicallyInvokable]
	public BinaryReader(Stream input, Encoding encoding)
		: this(input, encoding, leaveOpen: false)
	{
	}

	[__DynamicallyInvokable]
	public BinaryReader(Stream input, Encoding encoding, bool leaveOpen)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		if (!input.CanRead)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_StreamNotReadable"));
		}
		m_stream = input;
		m_decoder = encoding.GetDecoder();
		m_maxCharsSize = encoding.GetMaxCharCount(128);
		int num = encoding.GetMaxByteCount(1);
		if (num < 16)
		{
			num = 16;
		}
		m_buffer = new byte[num];
		m_2BytesPerChar = encoding is UnicodeEncoding;
		m_isMemoryStream = m_stream.GetType() == typeof(MemoryStream);
		m_leaveOpen = leaveOpen;
	}

	public virtual void Close()
	{
		Dispose(disposing: true);
	}

	[__DynamicallyInvokable]
	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			Stream stream = m_stream;
			m_stream = null;
			if (stream != null && !m_leaveOpen)
			{
				stream.Close();
			}
		}
		m_stream = null;
		m_buffer = null;
		m_decoder = null;
		m_charBytes = null;
		m_singleChar = null;
		m_charBuffer = null;
	}

	[__DynamicallyInvokable]
	public void Dispose()
	{
		Dispose(disposing: true);
	}

	[__DynamicallyInvokable]
	public virtual int PeekChar()
	{
		if (m_stream == null)
		{
			__Error.FileNotOpen();
		}
		if (!m_stream.CanSeek)
		{
			return -1;
		}
		long position = m_stream.Position;
		int result = Read();
		m_stream.Position = position;
		return result;
	}

	[__DynamicallyInvokable]
	public virtual int Read()
	{
		if (m_stream == null)
		{
			__Error.FileNotOpen();
		}
		return InternalReadOneChar();
	}

	[__DynamicallyInvokable]
	public virtual bool ReadBoolean()
	{
		FillBuffer(1);
		return m_buffer[0] != 0;
	}

	[__DynamicallyInvokable]
	public virtual byte ReadByte()
	{
		if (m_stream == null)
		{
			__Error.FileNotOpen();
		}
		int num = m_stream.ReadByte();
		if (num == -1)
		{
			__Error.EndOfFile();
		}
		return (byte)num;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public virtual sbyte ReadSByte()
	{
		FillBuffer(1);
		return (sbyte)m_buffer[0];
	}

	[__DynamicallyInvokable]
	public virtual char ReadChar()
	{
		int num = Read();
		if (num == -1)
		{
			__Error.EndOfFile();
		}
		return (char)num;
	}

	[__DynamicallyInvokable]
	public virtual short ReadInt16()
	{
		FillBuffer(2);
		return (short)(m_buffer[0] | (m_buffer[1] << 8));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public virtual ushort ReadUInt16()
	{
		FillBuffer(2);
		return (ushort)(m_buffer[0] | (m_buffer[1] << 8));
	}

	[__DynamicallyInvokable]
	public virtual int ReadInt32()
	{
		if (m_isMemoryStream)
		{
			if (m_stream == null)
			{
				__Error.FileNotOpen();
			}
			MemoryStream memoryStream = m_stream as MemoryStream;
			return memoryStream.InternalReadInt32();
		}
		FillBuffer(4);
		return m_buffer[0] | (m_buffer[1] << 8) | (m_buffer[2] << 16) | (m_buffer[3] << 24);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public virtual uint ReadUInt32()
	{
		FillBuffer(4);
		return (uint)(m_buffer[0] | (m_buffer[1] << 8) | (m_buffer[2] << 16) | (m_buffer[3] << 24));
	}

	[__DynamicallyInvokable]
	public virtual long ReadInt64()
	{
		FillBuffer(8);
		uint num = (uint)(m_buffer[0] | (m_buffer[1] << 8) | (m_buffer[2] << 16) | (m_buffer[3] << 24));
		uint num2 = (uint)(m_buffer[4] | (m_buffer[5] << 8) | (m_buffer[6] << 16) | (m_buffer[7] << 24));
		return (long)(((ulong)num2 << 32) | num);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public virtual ulong ReadUInt64()
	{
		FillBuffer(8);
		uint num = (uint)(m_buffer[0] | (m_buffer[1] << 8) | (m_buffer[2] << 16) | (m_buffer[3] << 24));
		uint num2 = (uint)(m_buffer[4] | (m_buffer[5] << 8) | (m_buffer[6] << 16) | (m_buffer[7] << 24));
		return ((ulong)num2 << 32) | num;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe virtual float ReadSingle()
	{
		FillBuffer(4);
		uint num = (uint)(m_buffer[0] | (m_buffer[1] << 8) | (m_buffer[2] << 16) | (m_buffer[3] << 24));
		return *(float*)(&num);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe virtual double ReadDouble()
	{
		FillBuffer(8);
		uint num = (uint)(m_buffer[0] | (m_buffer[1] << 8) | (m_buffer[2] << 16) | (m_buffer[3] << 24));
		uint num2 = (uint)(m_buffer[4] | (m_buffer[5] << 8) | (m_buffer[6] << 16) | (m_buffer[7] << 24));
		ulong num3 = ((ulong)num2 << 32) | num;
		return *(double*)(&num3);
	}

	[__DynamicallyInvokable]
	public virtual decimal ReadDecimal()
	{
		FillBuffer(16);
		try
		{
			return decimal.ToDecimal(m_buffer);
		}
		catch (ArgumentException innerException)
		{
			throw new IOException(Environment.GetResourceString("Arg_DecBitCtor"), innerException);
		}
	}

	[__DynamicallyInvokable]
	public virtual string ReadString()
	{
		if (m_stream == null)
		{
			__Error.FileNotOpen();
		}
		int num = 0;
		int num2 = Read7BitEncodedInt();
		if (num2 < 0)
		{
			throw new IOException(Environment.GetResourceString("IO.IO_InvalidStringLen_Len", num2));
		}
		if (num2 == 0)
		{
			return string.Empty;
		}
		if (m_charBytes == null)
		{
			m_charBytes = new byte[128];
		}
		if (m_charBuffer == null)
		{
			m_charBuffer = new char[m_maxCharsSize];
		}
		StringBuilder stringBuilder = null;
		do
		{
			int count = ((num2 - num > 128) ? 128 : (num2 - num));
			int num3 = m_stream.Read(m_charBytes, 0, count);
			if (num3 == 0)
			{
				__Error.EndOfFile();
			}
			int chars = m_decoder.GetChars(m_charBytes, 0, num3, m_charBuffer, 0);
			if (num == 0 && num3 == num2)
			{
				return new string(m_charBuffer, 0, chars);
			}
			if (stringBuilder == null)
			{
				stringBuilder = StringBuilderCache.Acquire(Math.Min(num2, 360));
			}
			stringBuilder.Append(m_charBuffer, 0, chars);
			num += num3;
		}
		while (num < num2);
		return StringBuilderCache.GetStringAndRelease(stringBuilder);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public virtual int Read(char[] buffer, int index, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - index < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (m_stream == null)
		{
			__Error.FileNotOpen();
		}
		return InternalReadChars(buffer, index, count);
	}

	[SecurityCritical]
	private unsafe int InternalReadChars(char[] buffer, int index, int count)
	{
		int num = 0;
		int num2 = count;
		if (m_charBytes == null)
		{
			m_charBytes = new byte[128];
		}
		while (num2 > 0)
		{
			int num3 = 0;
			num = num2;
			if (m_decoder is DecoderNLS { HasState: not false } && num > 1)
			{
				num--;
			}
			if (m_2BytesPerChar)
			{
				num <<= 1;
			}
			if (num > 128)
			{
				num = 128;
			}
			int num4 = 0;
			byte[] array = null;
			if (m_isMemoryStream)
			{
				MemoryStream memoryStream = m_stream as MemoryStream;
				num4 = memoryStream.InternalGetPosition();
				num = memoryStream.InternalEmulateRead(num);
				array = memoryStream.InternalGetBuffer();
			}
			else
			{
				num = m_stream.Read(m_charBytes, 0, num);
				array = m_charBytes;
			}
			if (num == 0)
			{
				return count - num2;
			}
			checked
			{
				if (num4 < 0 || num < 0 || num4 + num > array.Length)
				{
					throw new ArgumentOutOfRangeException("byteCount");
				}
				if (index < 0 || num2 < 0 || index + num2 > buffer.Length)
				{
					throw new ArgumentOutOfRangeException("charsRemaining");
				}
			}
			fixed (byte* ptr = array)
			{
				fixed (char* ptr2 = buffer)
				{
					num3 = m_decoder.GetChars((byte*)checked(unchecked((nuint)ptr) + unchecked((nuint)num4)), num, (char*)checked(unchecked((nuint)ptr2) + unchecked((nuint)checked(unchecked((nint)index) * (nint)2))), num2, flush: false);
				}
			}
			num2 -= num3;
			index += num3;
		}
		return count - num2;
	}

	private int InternalReadOneChar()
	{
		int num = 0;
		int num2 = 0;
		long num3 = (num3 = 0L);
		if (m_stream.CanSeek)
		{
			num3 = m_stream.Position;
		}
		if (m_charBytes == null)
		{
			m_charBytes = new byte[128];
		}
		if (m_singleChar == null)
		{
			m_singleChar = new char[1];
		}
		while (num == 0)
		{
			num2 = ((!m_2BytesPerChar) ? 1 : 2);
			int num4 = m_stream.ReadByte();
			m_charBytes[0] = (byte)num4;
			if (num4 == -1)
			{
				num2 = 0;
			}
			if (num2 == 2)
			{
				num4 = m_stream.ReadByte();
				m_charBytes[1] = (byte)num4;
				if (num4 == -1)
				{
					num2 = 1;
				}
			}
			if (num2 == 0)
			{
				return -1;
			}
			try
			{
				num = m_decoder.GetChars(m_charBytes, 0, num2, m_singleChar, 0);
			}
			catch
			{
				if (m_stream.CanSeek)
				{
					m_stream.Seek(num3 - m_stream.Position, SeekOrigin.Current);
				}
				throw;
			}
		}
		if (num == 0)
		{
			return -1;
		}
		return m_singleChar[0];
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public virtual char[] ReadChars(int count)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (m_stream == null)
		{
			__Error.FileNotOpen();
		}
		if (count == 0)
		{
			return EmptyArray<char>.Value;
		}
		char[] array = new char[count];
		int num = InternalReadChars(array, 0, count);
		if (num != count)
		{
			char[] array2 = new char[num];
			Buffer.InternalBlockCopy(array, 0, array2, 0, 2 * num);
			array = array2;
		}
		return array;
	}

	[__DynamicallyInvokable]
	public virtual int Read(byte[] buffer, int index, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - index < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (m_stream == null)
		{
			__Error.FileNotOpen();
		}
		return m_stream.Read(buffer, index, count);
	}

	[__DynamicallyInvokable]
	public virtual byte[] ReadBytes(int count)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (m_stream == null)
		{
			__Error.FileNotOpen();
		}
		if (count == 0)
		{
			return EmptyArray<byte>.Value;
		}
		byte[] array = new byte[count];
		int num = 0;
		do
		{
			int num2 = m_stream.Read(array, num, count);
			if (num2 == 0)
			{
				break;
			}
			num += num2;
			count -= num2;
		}
		while (count > 0);
		if (num != array.Length)
		{
			byte[] array2 = new byte[num];
			Buffer.InternalBlockCopy(array, 0, array2, 0, num);
			array = array2;
		}
		return array;
	}

	[__DynamicallyInvokable]
	protected virtual void FillBuffer(int numBytes)
	{
		if (m_buffer != null && (numBytes < 0 || numBytes > m_buffer.Length))
		{
			throw new ArgumentOutOfRangeException("numBytes", Environment.GetResourceString("ArgumentOutOfRange_BinaryReaderFillBuffer"));
		}
		int num = 0;
		int num2 = 0;
		if (m_stream == null)
		{
			__Error.FileNotOpen();
		}
		if (numBytes == 1)
		{
			num2 = m_stream.ReadByte();
			if (num2 == -1)
			{
				__Error.EndOfFile();
			}
			m_buffer[0] = (byte)num2;
			return;
		}
		do
		{
			num2 = m_stream.Read(m_buffer, num, numBytes - num);
			if (num2 == 0)
			{
				__Error.EndOfFile();
			}
			num += num2;
		}
		while (num < numBytes);
	}

	[__DynamicallyInvokable]
	protected internal int Read7BitEncodedInt()
	{
		int num = 0;
		int num2 = 0;
		byte b;
		do
		{
			if (num2 == 35)
			{
				throw new FormatException(Environment.GetResourceString("Format_Bad7BitInt32"));
			}
			b = ReadByte();
			num |= (b & 0x7F) << num2;
			num2 += 7;
		}
		while ((b & 0x80) != 0);
		return num;
	}
}
