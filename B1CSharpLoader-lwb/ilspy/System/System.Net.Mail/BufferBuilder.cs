using System.Text;

namespace System.Net.Mail;

internal class BufferBuilder
{
	private byte[] buffer;

	private int offset;

	internal int Length => offset;

	internal BufferBuilder()
		: this(256)
	{
	}

	internal BufferBuilder(int initialSize)
	{
		buffer = new byte[initialSize];
	}

	private void EnsureBuffer(int count)
	{
		if (count > buffer.Length - offset)
		{
			byte[] dst = new byte[(buffer.Length * 2 > buffer.Length + count) ? (buffer.Length * 2) : (buffer.Length + count)];
			Buffer.BlockCopy(buffer, 0, dst, 0, offset);
			buffer = dst;
		}
	}

	internal void Append(byte value)
	{
		EnsureBuffer(1);
		buffer[offset++] = value;
	}

	internal void Append(byte[] value)
	{
		Append(value, 0, value.Length);
	}

	internal void Append(byte[] value, int offset, int count)
	{
		EnsureBuffer(count);
		Buffer.BlockCopy(value, offset, buffer, this.offset, count);
		this.offset += count;
	}

	internal void Append(string value)
	{
		Append(value, allowUnicode: false);
	}

	internal void Append(string value, bool allowUnicode)
	{
		if (!string.IsNullOrEmpty(value))
		{
			Append(value, 0, value.Length, allowUnicode);
		}
	}

	internal void Append(string value, int offset, int count, bool allowUnicode)
	{
		if (allowUnicode)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(value.ToCharArray(), offset, count);
			Append(bytes);
		}
		else
		{
			Append(value, offset, count);
		}
	}

	internal void Append(string value, int offset, int count)
	{
		EnsureBuffer(count);
		for (int i = 0; i < count; i++)
		{
			char c = value[offset + i];
			if (c > 'ÿ')
			{
				throw new FormatException(SR.GetString("MailHeaderFieldInvalidCharacter", c));
			}
			buffer[this.offset + i] = (byte)c;
		}
		this.offset += count;
	}

	internal byte[] GetBuffer()
	{
		return buffer;
	}

	internal void Reset()
	{
		offset = 0;
	}
}
