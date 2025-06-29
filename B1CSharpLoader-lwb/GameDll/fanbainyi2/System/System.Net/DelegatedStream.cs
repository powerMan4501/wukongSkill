using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

internal class DelegatedStream : Stream
{
	private Stream stream;

	private NetworkStream netStream;

	protected Stream BaseStream => stream;

	public override bool CanRead => stream.CanRead;

	public override bool CanSeek => stream.CanSeek;

	public override bool CanWrite => stream.CanWrite;

	public override long Length
	{
		get
		{
			if (!CanSeek)
			{
				throw new NotSupportedException(SR.GetString("SeekNotSupported"));
			}
			return stream.Length;
		}
	}

	public override long Position
	{
		get
		{
			if (!CanSeek)
			{
				throw new NotSupportedException(SR.GetString("SeekNotSupported"));
			}
			return stream.Position;
		}
		set
		{
			if (!CanSeek)
			{
				throw new NotSupportedException(SR.GetString("SeekNotSupported"));
			}
			stream.Position = value;
		}
	}

	protected DelegatedStream()
	{
	}

	protected DelegatedStream(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		this.stream = stream;
		netStream = stream as NetworkStream;
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		if (!CanRead)
		{
			throw new NotSupportedException(SR.GetString("ReadNotSupported"));
		}
		IAsyncResult asyncResult = null;
		if (netStream != null)
		{
			return netStream.UnsafeBeginRead(buffer, offset, count, callback, state);
		}
		return stream.BeginRead(buffer, offset, count, callback, state);
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		if (!CanWrite)
		{
			throw new NotSupportedException(SR.GetString("WriteNotSupported"));
		}
		IAsyncResult asyncResult = null;
		if (netStream != null)
		{
			return netStream.UnsafeBeginWrite(buffer, offset, count, callback, state);
		}
		return stream.BeginWrite(buffer, offset, count, callback, state);
	}

	public override void Close()
	{
		stream.Close();
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		if (!CanRead)
		{
			throw new NotSupportedException(SR.GetString("ReadNotSupported"));
		}
		return stream.EndRead(asyncResult);
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		if (!CanWrite)
		{
			throw new NotSupportedException(SR.GetString("WriteNotSupported"));
		}
		stream.EndWrite(asyncResult);
	}

	public override void Flush()
	{
		stream.Flush();
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return stream.FlushAsync(cancellationToken);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (!CanRead)
		{
			throw new NotSupportedException(SR.GetString("ReadNotSupported"));
		}
		return stream.Read(buffer, offset, count);
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (!CanRead)
		{
			throw new NotSupportedException(SR.GetString("ReadNotSupported"));
		}
		return stream.ReadAsync(buffer, offset, count, cancellationToken);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		if (!CanSeek)
		{
			throw new NotSupportedException(SR.GetString("SeekNotSupported"));
		}
		return stream.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		if (!CanSeek)
		{
			throw new NotSupportedException(SR.GetString("SeekNotSupported"));
		}
		stream.SetLength(value);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (!CanWrite)
		{
			throw new NotSupportedException(SR.GetString("WriteNotSupported"));
		}
		stream.Write(buffer, offset, count);
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (!CanWrite)
		{
			throw new NotSupportedException(SR.GetString("WriteNotSupported"));
		}
		return stream.WriteAsync(buffer, offset, count, cancellationToken);
	}
}
