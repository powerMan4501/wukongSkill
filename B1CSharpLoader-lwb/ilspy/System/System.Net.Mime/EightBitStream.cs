using System.IO;

namespace System.Net.Mime;

internal class EightBitStream : DelegatedStream, IEncodableStream
{
	private WriteStateInfoBase writeState;

	private bool shouldEncodeLeadingDots;

	private WriteStateInfoBase WriteState
	{
		get
		{
			if (writeState == null)
			{
				writeState = new WriteStateInfoBase();
			}
			return writeState;
		}
	}

	internal EightBitStream(Stream stream)
		: base(stream)
	{
	}

	internal EightBitStream(Stream stream, bool shouldEncodeLeadingDots)
		: this(stream)
	{
		this.shouldEncodeLeadingDots = shouldEncodeLeadingDots;
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset >= buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (offset + count > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (shouldEncodeLeadingDots)
		{
			EncodeLines(buffer, offset, count);
			return base.BeginWrite(WriteState.Buffer, 0, WriteState.Length, callback, state);
		}
		return base.BeginWrite(buffer, offset, count, callback, state);
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		base.EndWrite(asyncResult);
		WriteState.BufferFlushed();
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset >= buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (offset + count > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (shouldEncodeLeadingDots)
		{
			EncodeLines(buffer, offset, count);
			base.Write(WriteState.Buffer, 0, WriteState.Length);
			WriteState.BufferFlushed();
		}
		else
		{
			base.Write(buffer, offset, count);
		}
	}

	private void EncodeLines(byte[] buffer, int offset, int count)
	{
		for (int i = offset; i < offset + count && i < buffer.Length; i++)
		{
			if (buffer[i] == 13 && i + 1 < offset + count && buffer[i + 1] == 10)
			{
				WriteState.AppendCRLF(includeSpace: false);
				i++;
			}
			else if (WriteState.CurrentLineLength == 0 && buffer[i] == 46)
			{
				WriteState.Append(46);
				WriteState.Append(buffer[i]);
			}
			else
			{
				WriteState.Append(buffer[i]);
			}
		}
	}

	public int DecodeBytes(byte[] buffer, int offset, int count)
	{
		throw new NotImplementedException();
	}

	public int EncodeBytes(byte[] buffer, int offset, int count)
	{
		throw new NotImplementedException();
	}

	public Stream GetStream()
	{
		return this;
	}

	public string GetEncodedString()
	{
		throw new NotImplementedException();
	}
}
