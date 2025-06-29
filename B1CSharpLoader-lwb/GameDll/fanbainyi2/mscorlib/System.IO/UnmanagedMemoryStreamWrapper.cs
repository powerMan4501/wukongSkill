using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO;

internal sealed class UnmanagedMemoryStreamWrapper : MemoryStream
{
	private UnmanagedMemoryStream _unmanagedStream;

	public override bool CanRead => _unmanagedStream.CanRead;

	public override bool CanSeek => _unmanagedStream.CanSeek;

	public override bool CanWrite => _unmanagedStream.CanWrite;

	public override int Capacity
	{
		get
		{
			return (int)_unmanagedStream.Capacity;
		}
		set
		{
			throw new IOException(Environment.GetResourceString("IO.IO_FixedCapacity"));
		}
	}

	public override long Length => _unmanagedStream.Length;

	public override long Position
	{
		get
		{
			return _unmanagedStream.Position;
		}
		set
		{
			_unmanagedStream.Position = value;
		}
	}

	internal UnmanagedMemoryStreamWrapper(UnmanagedMemoryStream stream)
	{
		_unmanagedStream = stream;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				_unmanagedStream.Close();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public override void Flush()
	{
		_unmanagedStream.Flush();
	}

	public override byte[] GetBuffer()
	{
		throw new UnauthorizedAccessException(Environment.GetResourceString("UnauthorizedAccess_MemStreamBuffer"));
	}

	public override bool TryGetBuffer(out ArraySegment<byte> buffer)
	{
		buffer = default(ArraySegment<byte>);
		return false;
	}

	public override int Read([In][Out] byte[] buffer, int offset, int count)
	{
		return _unmanagedStream.Read(buffer, offset, count);
	}

	public override int ReadByte()
	{
		return _unmanagedStream.ReadByte();
	}

	public override long Seek(long offset, SeekOrigin loc)
	{
		return _unmanagedStream.Seek(offset, loc);
	}

	[SecuritySafeCritical]
	public unsafe override byte[] ToArray()
	{
		if (!_unmanagedStream._isOpen)
		{
			__Error.StreamIsClosed();
		}
		if (!_unmanagedStream.CanRead)
		{
			__Error.ReadNotSupported();
		}
		byte[] array = new byte[_unmanagedStream.Length];
		Buffer.Memcpy(array, 0, _unmanagedStream.Pointer, 0, (int)_unmanagedStream.Length);
		return array;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		_unmanagedStream.Write(buffer, offset, count);
	}

	public override void WriteByte(byte value)
	{
		_unmanagedStream.WriteByte(value);
	}

	public override void WriteTo(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream", Environment.GetResourceString("ArgumentNull_Stream"));
		}
		if (!_unmanagedStream._isOpen)
		{
			__Error.StreamIsClosed();
		}
		if (!CanRead)
		{
			__Error.ReadNotSupported();
		}
		byte[] array = ToArray();
		stream.Write(array, 0, array.Length);
	}

	public override void SetLength(long value)
	{
		base.SetLength(value);
	}

	public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (bufferSize <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferSize", Environment.GetResourceString("ArgumentOutOfRange_NeedPosNum"));
		}
		if (!CanRead && !CanWrite)
		{
			throw new ObjectDisposedException(null, Environment.GetResourceString("ObjectDisposed_StreamClosed"));
		}
		if (!destination.CanRead && !destination.CanWrite)
		{
			throw new ObjectDisposedException("destination", Environment.GetResourceString("ObjectDisposed_StreamClosed"));
		}
		if (!CanRead)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_UnreadableStream"));
		}
		if (!destination.CanWrite)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_UnwritableStream"));
		}
		return _unmanagedStream.CopyToAsync(destination, bufferSize, cancellationToken);
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return _unmanagedStream.FlushAsync(cancellationToken);
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return _unmanagedStream.ReadAsync(buffer, offset, count, cancellationToken);
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		return _unmanagedStream.WriteAsync(buffer, offset, count, cancellationToken);
	}
}
