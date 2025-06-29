namespace System.Net.Mime;

internal class WriteStateInfoBase
{
	protected byte[] _header;

	protected byte[] _footer;

	protected int _maxLineLength;

	protected byte[] buffer;

	protected int _currentLineLength;

	protected int _currentBufferUsed;

	protected const int defaultBufferSize = 1024;

	internal int FooterLength => _footer.Length;

	internal byte[] Footer => _footer;

	internal byte[] Header => _header;

	internal byte[] Buffer => buffer;

	internal int Length => _currentBufferUsed;

	internal int CurrentLineLength => _currentLineLength;

	internal int MaxLineLength => _maxLineLength;

	internal WriteStateInfoBase()
	{
		buffer = new byte[1024];
		_header = new byte[0];
		_footer = new byte[0];
		_maxLineLength = EncodedStreamFactory.DefaultMaxLineLength;
		_currentLineLength = 0;
		_currentBufferUsed = 0;
	}

	internal WriteStateInfoBase(int bufferSize, byte[] header, byte[] footer, int maxLineLength)
		: this(bufferSize, header, footer, maxLineLength, 0)
	{
	}

	internal WriteStateInfoBase(int bufferSize, byte[] header, byte[] footer, int maxLineLength, int mimeHeaderLength)
	{
		buffer = new byte[bufferSize];
		_header = header;
		_footer = footer;
		_maxLineLength = maxLineLength;
		_currentLineLength = mimeHeaderLength;
		_currentBufferUsed = 0;
	}

	private void EnsureSpaceInBuffer(int moreBytes)
	{
		int num = Buffer.Length;
		while (_currentBufferUsed + moreBytes >= num)
		{
			num *= 2;
		}
		if (num > Buffer.Length)
		{
			byte[] array = new byte[num];
			buffer.CopyTo(array, 0);
			buffer = array;
		}
	}

	internal void Append(byte aByte)
	{
		EnsureSpaceInBuffer(1);
		Buffer[_currentBufferUsed++] = aByte;
		_currentLineLength++;
	}

	internal void Append(params byte[] bytes)
	{
		EnsureSpaceInBuffer(bytes.Length);
		bytes.CopyTo(buffer, Length);
		_currentLineLength += bytes.Length;
		_currentBufferUsed += bytes.Length;
	}

	internal void AppendCRLF(bool includeSpace)
	{
		AppendFooter();
		Append(13, 10);
		_currentLineLength = 0;
		if (includeSpace)
		{
			Append(32);
		}
		AppendHeader();
	}

	internal void AppendHeader()
	{
		if (Header != null && Header.Length != 0)
		{
			Append(Header);
		}
	}

	internal void AppendFooter()
	{
		if (Footer != null && Footer.Length != 0)
		{
			Append(Footer);
		}
	}

	internal void Reset()
	{
		_currentBufferUsed = 0;
		_currentLineLength = 0;
	}

	internal void BufferFlushed()
	{
		_currentBufferUsed = 0;
	}
}
