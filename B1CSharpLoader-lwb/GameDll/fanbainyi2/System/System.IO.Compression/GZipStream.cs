using System.Security.Permissions;

namespace System.IO.Compression;

[global::__DynamicallyInvokable]
public class GZipStream : Stream
{
	private DeflateStream deflateStream;

	[global::__DynamicallyInvokable]
	public override bool CanRead
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (deflateStream == null)
			{
				return false;
			}
			return deflateStream.CanRead;
		}
	}

	[global::__DynamicallyInvokable]
	public override bool CanWrite
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (deflateStream == null)
			{
				return false;
			}
			return deflateStream.CanWrite;
		}
	}

	[global::__DynamicallyInvokable]
	public override bool CanSeek
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (deflateStream == null)
			{
				return false;
			}
			return deflateStream.CanSeek;
		}
	}

	[global::__DynamicallyInvokable]
	public override long Length
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw new NotSupportedException(SR.GetString("NotSupported"));
		}
	}

	[global::__DynamicallyInvokable]
	public override long Position
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw new NotSupportedException(SR.GetString("NotSupported"));
		}
		[global::__DynamicallyInvokable]
		set
		{
			throw new NotSupportedException(SR.GetString("NotSupported"));
		}
	}

	[global::__DynamicallyInvokable]
	public Stream BaseStream
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (deflateStream != null)
			{
				return deflateStream.BaseStream;
			}
			return null;
		}
	}

	[global::__DynamicallyInvokable]
	public GZipStream(Stream stream, CompressionMode mode)
		: this(stream, mode, leaveOpen: false)
	{
	}

	[global::__DynamicallyInvokable]
	public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
	{
		if (mode == CompressionMode.Decompress)
		{
			deflateStream = new DeflateStream(stream, leaveOpen, new GZipDecoder());
			return;
		}
		deflateStream = new DeflateStream(stream, mode, leaveOpen);
		deflateStream.SetFileFormatWriter(new GZipFormatter());
	}

	[global::__DynamicallyInvokable]
	public GZipStream(Stream stream, CompressionLevel compressionLevel)
		: this(stream, compressionLevel, leaveOpen: false)
	{
	}

	[global::__DynamicallyInvokable]
	public GZipStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen)
	{
		deflateStream = new DeflateStream(stream, compressionLevel, leaveOpen);
		deflateStream.SetFileFormatWriter(new GZipFormatter());
	}

	[global::__DynamicallyInvokable]
	public override void Flush()
	{
		if (deflateStream == null)
		{
			throw new ObjectDisposedException(null, SR.GetString("ObjectDisposed_StreamClosed"));
		}
		deflateStream.Flush();
	}

	[global::__DynamicallyInvokable]
	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException(SR.GetString("NotSupported"));
	}

	[global::__DynamicallyInvokable]
	public override void SetLength(long value)
	{
		throw new NotSupportedException(SR.GetString("NotSupported"));
	}

	[global::__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		if (deflateStream == null)
		{
			throw new InvalidOperationException(SR.GetString("ObjectDisposed_StreamClosed"));
		}
		return deflateStream.BeginRead(array, offset, count, asyncCallback, asyncState);
	}

	[global::__DynamicallyInvokable]
	public override int EndRead(IAsyncResult asyncResult)
	{
		if (deflateStream == null)
		{
			throw new InvalidOperationException(SR.GetString("ObjectDisposed_StreamClosed"));
		}
		return deflateStream.EndRead(asyncResult);
	}

	[global::__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		if (deflateStream == null)
		{
			throw new InvalidOperationException(SR.GetString("ObjectDisposed_StreamClosed"));
		}
		return deflateStream.BeginWrite(array, offset, count, asyncCallback, asyncState);
	}

	[global::__DynamicallyInvokable]
	public override void EndWrite(IAsyncResult asyncResult)
	{
		if (deflateStream == null)
		{
			throw new InvalidOperationException(SR.GetString("ObjectDisposed_StreamClosed"));
		}
		deflateStream.EndWrite(asyncResult);
	}

	[global::__DynamicallyInvokable]
	public override int Read(byte[] array, int offset, int count)
	{
		if (deflateStream == null)
		{
			throw new ObjectDisposedException(null, SR.GetString("ObjectDisposed_StreamClosed"));
		}
		return deflateStream.Read(array, offset, count);
	}

	[global::__DynamicallyInvokable]
	public override void Write(byte[] array, int offset, int count)
	{
		if (deflateStream == null)
		{
			throw new ObjectDisposedException(null, SR.GetString("ObjectDisposed_StreamClosed"));
		}
		deflateStream.Write(array, offset, count);
	}

	[global::__DynamicallyInvokable]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && deflateStream != null)
			{
				deflateStream.Close();
			}
			deflateStream = null;
		}
		finally
		{
			base.Dispose(disposing);
		}
	}
}
