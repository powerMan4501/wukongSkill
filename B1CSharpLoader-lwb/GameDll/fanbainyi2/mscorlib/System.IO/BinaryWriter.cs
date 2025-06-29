using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Text;

namespace System.IO;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class BinaryWriter : IDisposable
{
	[__DynamicallyInvokable]
	public static readonly BinaryWriter Null = new BinaryWriter();

	[__DynamicallyInvokable]
	protected Stream OutStream;

	private byte[] _buffer;

	private Encoding _encoding;

	private Encoder _encoder;

	[OptionalField]
	private bool _leaveOpen;

	[OptionalField]
	private char[] _tmpOneCharBuffer;

	private byte[] _largeByteBuffer;

	private int _maxChars;

	private const int LargeByteBufferSize = 256;

	[__DynamicallyInvokable]
	public virtual Stream BaseStream
	{
		[__DynamicallyInvokable]
		get
		{
			Flush();
			return OutStream;
		}
	}

	[__DynamicallyInvokable]
	protected BinaryWriter()
	{
		OutStream = Stream.Null;
		_buffer = new byte[16];
		_encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);
		_encoder = _encoding.GetEncoder();
	}

	[__DynamicallyInvokable]
	public BinaryWriter(Stream output)
		: this(output, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true), leaveOpen: false)
	{
	}

	[__DynamicallyInvokable]
	public BinaryWriter(Stream output, Encoding encoding)
		: this(output, encoding, leaveOpen: false)
	{
	}

	[__DynamicallyInvokable]
	public BinaryWriter(Stream output, Encoding encoding, bool leaveOpen)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		if (!output.CanWrite)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_StreamNotWritable"));
		}
		OutStream = output;
		_buffer = new byte[16];
		_encoding = encoding;
		_encoder = _encoding.GetEncoder();
		_leaveOpen = leaveOpen;
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
			if (_leaveOpen)
			{
				OutStream.Flush();
			}
			else
			{
				OutStream.Close();
			}
		}
	}

	[__DynamicallyInvokable]
	public void Dispose()
	{
		Dispose(disposing: true);
	}

	[__DynamicallyInvokable]
	public virtual void Flush()
	{
		OutStream.Flush();
	}

	[__DynamicallyInvokable]
	public virtual long Seek(int offset, SeekOrigin origin)
	{
		return OutStream.Seek(offset, origin);
	}

	[__DynamicallyInvokable]
	public virtual void Write(bool value)
	{
		_buffer[0] = (byte)(value ? 1u : 0u);
		OutStream.Write(_buffer, 0, 1);
	}

	[__DynamicallyInvokable]
	public virtual void Write(byte value)
	{
		OutStream.WriteByte(value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public virtual void Write(sbyte value)
	{
		OutStream.WriteByte((byte)value);
	}

	[__DynamicallyInvokable]
	public virtual void Write(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		OutStream.Write(buffer, 0, buffer.Length);
	}

	[__DynamicallyInvokable]
	public virtual void Write(byte[] buffer, int index, int count)
	{
		OutStream.Write(buffer, index, count);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe virtual void Write(char ch)
	{
		if (char.IsSurrogate(ch))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_SurrogatesNotAllowedAsSingleChar"));
		}
		int num = 0;
		fixed (byte* buffer = _buffer)
		{
			num = _encoder.GetBytes(&ch, 1, buffer, _buffer.Length, flush: true);
		}
		OutStream.Write(_buffer, 0, num);
	}

	[__DynamicallyInvokable]
	public virtual void Write(char[] chars)
	{
		if (chars == null)
		{
			throw new ArgumentNullException("chars");
		}
		byte[] bytes = _encoding.GetBytes(chars, 0, chars.Length);
		OutStream.Write(bytes, 0, bytes.Length);
	}

	[__DynamicallyInvokable]
	public virtual void Write(char[] chars, int index, int count)
	{
		byte[] bytes = _encoding.GetBytes(chars, index, count);
		OutStream.Write(bytes, 0, bytes.Length);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe virtual void Write(double value)
	{
		ulong num = *(ulong*)(&value);
		_buffer[0] = (byte)num;
		_buffer[1] = (byte)(num >> 8);
		_buffer[2] = (byte)(num >> 16);
		_buffer[3] = (byte)(num >> 24);
		_buffer[4] = (byte)(num >> 32);
		_buffer[5] = (byte)(num >> 40);
		_buffer[6] = (byte)(num >> 48);
		_buffer[7] = (byte)(num >> 56);
		OutStream.Write(_buffer, 0, 8);
	}

	[__DynamicallyInvokable]
	public virtual void Write(decimal value)
	{
		decimal.GetBytes(value, _buffer);
		OutStream.Write(_buffer, 0, 16);
	}

	[__DynamicallyInvokable]
	public virtual void Write(short value)
	{
		_buffer[0] = (byte)value;
		_buffer[1] = (byte)(value >> 8);
		OutStream.Write(_buffer, 0, 2);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public virtual void Write(ushort value)
	{
		_buffer[0] = (byte)value;
		_buffer[1] = (byte)(value >> 8);
		OutStream.Write(_buffer, 0, 2);
	}

	[__DynamicallyInvokable]
	public virtual void Write(int value)
	{
		_buffer[0] = (byte)value;
		_buffer[1] = (byte)(value >> 8);
		_buffer[2] = (byte)(value >> 16);
		_buffer[3] = (byte)(value >> 24);
		OutStream.Write(_buffer, 0, 4);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public virtual void Write(uint value)
	{
		_buffer[0] = (byte)value;
		_buffer[1] = (byte)(value >> 8);
		_buffer[2] = (byte)(value >> 16);
		_buffer[3] = (byte)(value >> 24);
		OutStream.Write(_buffer, 0, 4);
	}

	[__DynamicallyInvokable]
	public virtual void Write(long value)
	{
		_buffer[0] = (byte)value;
		_buffer[1] = (byte)(value >> 8);
		_buffer[2] = (byte)(value >> 16);
		_buffer[3] = (byte)(value >> 24);
		_buffer[4] = (byte)(value >> 32);
		_buffer[5] = (byte)(value >> 40);
		_buffer[6] = (byte)(value >> 48);
		_buffer[7] = (byte)(value >> 56);
		OutStream.Write(_buffer, 0, 8);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public virtual void Write(ulong value)
	{
		_buffer[0] = (byte)value;
		_buffer[1] = (byte)(value >> 8);
		_buffer[2] = (byte)(value >> 16);
		_buffer[3] = (byte)(value >> 24);
		_buffer[4] = (byte)(value >> 32);
		_buffer[5] = (byte)(value >> 40);
		_buffer[6] = (byte)(value >> 48);
		_buffer[7] = (byte)(value >> 56);
		OutStream.Write(_buffer, 0, 8);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe virtual void Write(float value)
	{
		uint num = *(uint*)(&value);
		_buffer[0] = (byte)num;
		_buffer[1] = (byte)(num >> 8);
		_buffer[2] = (byte)(num >> 16);
		_buffer[3] = (byte)(num >> 24);
		OutStream.Write(_buffer, 0, 4);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public unsafe virtual void Write(string value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		int byteCount = _encoding.GetByteCount(value);
		Write7BitEncodedInt(byteCount);
		if (_largeByteBuffer == null)
		{
			_largeByteBuffer = new byte[256];
			_maxChars = _largeByteBuffer.Length / _encoding.GetMaxByteCount(1);
		}
		if (byteCount <= _largeByteBuffer.Length)
		{
			_encoding.GetBytes(value, 0, value.Length, _largeByteBuffer, 0);
			OutStream.Write(_largeByteBuffer, 0, byteCount);
			return;
		}
		int num = 0;
		int num2 = value.Length;
		while (num2 > 0)
		{
			int num3 = ((num2 > _maxChars) ? _maxChars : num2);
			if (num < 0 || num3 < 0 || checked(num + num3) > value.Length)
			{
				throw new ArgumentOutOfRangeException("charCount");
			}
			int bytes;
			fixed (char* ptr = value)
			{
				fixed (byte* largeByteBuffer = _largeByteBuffer)
				{
					bytes = _encoder.GetBytes((char*)checked(unchecked((nuint)ptr) + unchecked((nuint)checked(unchecked((nint)num) * (nint)2))), num3, largeByteBuffer, _largeByteBuffer.Length, num3 == num2);
				}
			}
			OutStream.Write(_largeByteBuffer, 0, bytes);
			num += num3;
			num2 -= num3;
		}
	}

	[__DynamicallyInvokable]
	protected void Write7BitEncodedInt(int value)
	{
		uint num;
		for (num = (uint)value; num >= 128; num >>= 7)
		{
			Write((byte)(num | 0x80));
		}
		Write((byte)num);
	}
}
