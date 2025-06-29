using System.IO;

namespace System.Net.Cache;

internal class RangeStream : BaseWrapperStream, ICloseEx
{
	private long m_Offset;

	private long m_Size;

	private long m_Position;

	public override bool CanRead => base.WrappedStream.CanRead;

	public override bool CanSeek => base.WrappedStream.CanSeek;

	public override bool CanWrite => base.WrappedStream.CanWrite;

	public override long Length
	{
		get
		{
			long length = base.WrappedStream.Length;
			return m_Size;
		}
	}

	public override long Position
	{
		get
		{
			return base.WrappedStream.Position - m_Offset;
		}
		set
		{
			value += m_Offset;
			if (value > m_Offset + m_Size)
			{
				value = m_Offset + m_Size;
			}
			base.WrappedStream.Position = value;
		}
	}

	public override bool CanTimeout => base.WrappedStream.CanTimeout;

	public override int ReadTimeout
	{
		get
		{
			return base.WrappedStream.ReadTimeout;
		}
		set
		{
			base.WrappedStream.ReadTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return base.WrappedStream.WriteTimeout;
		}
		set
		{
			base.WrappedStream.WriteTimeout = value;
		}
	}

	internal RangeStream(Stream parentStream, long offset, long size)
		: base(parentStream)
	{
		m_Offset = offset;
		m_Size = size;
		if (base.WrappedStream.CanSeek)
		{
			base.WrappedStream.Position = offset;
			m_Position = offset;
			return;
		}
		throw new NotSupportedException(SR.GetString("net_cache_non_seekable_stream_not_supported"));
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		switch (origin)
		{
		case SeekOrigin.Begin:
			offset += m_Offset;
			if (offset > m_Offset + m_Size)
			{
				offset = m_Offset + m_Size;
			}
			if (offset < m_Offset)
			{
				offset = m_Offset;
			}
			break;
		case SeekOrigin.End:
			offset -= m_Offset + m_Size;
			if (offset > 0)
			{
				offset = 0L;
			}
			if (offset < -m_Size)
			{
				offset = -m_Size;
			}
			break;
		default:
			if (m_Position + offset > m_Offset + m_Size)
			{
				offset = m_Offset + m_Size - m_Position;
			}
			if (m_Position + offset < m_Offset)
			{
				offset = m_Offset - m_Position;
			}
			break;
		}
		m_Position = base.WrappedStream.Seek(offset, origin);
		return m_Position - m_Offset;
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException(SR.GetString("net_cache_unsupported_partial_stream"));
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (m_Position + count > m_Offset + m_Size)
		{
			throw new NotSupportedException(SR.GetString("net_cache_unsupported_partial_stream"));
		}
		base.WrappedStream.Write(buffer, offset, count);
		m_Position += count;
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		if (m_Position + offset > m_Offset + m_Size)
		{
			throw new NotSupportedException(SR.GetString("net_cache_unsupported_partial_stream"));
		}
		return base.WrappedStream.BeginWrite(buffer, offset, count, callback, state);
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		base.WrappedStream.EndWrite(asyncResult);
		m_Position = base.WrappedStream.Position;
	}

	public override void Flush()
	{
		base.WrappedStream.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (m_Position >= m_Offset + m_Size)
		{
			return 0;
		}
		if (m_Position + count > m_Offset + m_Size)
		{
			count = (int)(m_Offset + m_Size - m_Position);
		}
		int num = base.WrappedStream.Read(buffer, offset, count);
		m_Position += num;
		return num;
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		if (m_Position >= m_Offset + m_Size)
		{
			count = 0;
		}
		else if (m_Position + count > m_Offset + m_Size)
		{
			count = (int)(m_Offset + m_Size - m_Position);
		}
		return base.WrappedStream.BeginRead(buffer, offset, count, callback, state);
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		int num = base.WrappedStream.EndRead(asyncResult);
		m_Position += num;
		return num;
	}

	protected sealed override void Dispose(bool disposing)
	{
		Dispose(disposing, CloseExState.Normal);
	}

	void ICloseEx.CloseEx(CloseExState closeState)
	{
		Dispose(disposing: true, closeState);
	}

	protected virtual void Dispose(bool disposing, CloseExState closeState)
	{
		try
		{
			if (disposing)
			{
				if (base.WrappedStream is ICloseEx closeEx)
				{
					closeEx.CloseEx(closeState);
				}
				else
				{
					base.WrappedStream.Close();
				}
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}
}
