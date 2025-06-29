using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class MemoryStream : Stream
{
	private byte[] _buffer;

	private int _origin;

	private int _position;

	private int _length;

	private int _capacity;

	private bool _expandable;

	private bool _writable;

	private bool _exposable;

	private bool _isOpen;

	[NonSerialized]
	private Task<int> _lastReadTask;

	private const int MemStreamMaxLength = int.MaxValue;

	[__DynamicallyInvokable]
	public override bool CanRead
	{
		[__DynamicallyInvokable]
		get
		{
			return _isOpen;
		}
	}

	[__DynamicallyInvokable]
	public override bool CanSeek
	{
		[__DynamicallyInvokable]
		get
		{
			return _isOpen;
		}
	}

	[__DynamicallyInvokable]
	public override bool CanWrite
	{
		[__DynamicallyInvokable]
		get
		{
			return _writable;
		}
	}

	[__DynamicallyInvokable]
	public virtual int Capacity
	{
		[__DynamicallyInvokable]
		get
		{
			if (!_isOpen)
			{
				__Error.StreamIsClosed();
			}
			return _capacity - _origin;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value < Length)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_SmallCapacity"));
			}
			if (!_isOpen)
			{
				__Error.StreamIsClosed();
			}
			if (!_expandable && value != Capacity)
			{
				__Error.MemoryStreamNotExpandable();
			}
			if (!_expandable || value == _capacity)
			{
				return;
			}
			if (value > 0)
			{
				byte[] array = new byte[value];
				if (_length > 0)
				{
					Buffer.InternalBlockCopy(_buffer, 0, array, 0, _length);
				}
				_buffer = array;
			}
			else
			{
				_buffer = null;
			}
			_capacity = value;
		}
	}

	[__DynamicallyInvokable]
	public override long Length
	{
		[__DynamicallyInvokable]
		get
		{
			if (!_isOpen)
			{
				__Error.StreamIsClosed();
			}
			return _length - _origin;
		}
	}

	[__DynamicallyInvokable]
	public override long Position
	{
		[__DynamicallyInvokable]
		get
		{
			if (!_isOpen)
			{
				__Error.StreamIsClosed();
			}
			return _position - _origin;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
			}
			if (!_isOpen)
			{
				__Error.StreamIsClosed();
			}
			if (value > int.MaxValue)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_StreamLength"));
			}
			_position = _origin + (int)value;
		}
	}

	[__DynamicallyInvokable]
	public MemoryStream()
		: this(0)
	{
	}

	[__DynamicallyInvokable]
	public MemoryStream(int capacity)
	{
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException("capacity", Environment.GetResourceString("ArgumentOutOfRange_NegativeCapacity"));
		}
		_buffer = new byte[capacity];
		_capacity = capacity;
		_expandable = true;
		_writable = true;
		_exposable = true;
		_origin = 0;
		_isOpen = true;
	}

	[__DynamicallyInvokable]
	public MemoryStream(byte[] buffer)
		: this(buffer, writable: true)
	{
	}

	[__DynamicallyInvokable]
	public MemoryStream(byte[] buffer, bool writable)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		_buffer = buffer;
		_length = (_capacity = buffer.Length);
		_writable = writable;
		_exposable = false;
		_origin = 0;
		_isOpen = true;
	}

	[__DynamicallyInvokable]
	public MemoryStream(byte[] buffer, int index, int count)
		: this(buffer, index, count, writable: true, publiclyVisible: false)
	{
	}

	[__DynamicallyInvokable]
	public MemoryStream(byte[] buffer, int index, int count, bool writable)
		: this(buffer, index, count, writable, publiclyVisible: false)
	{
	}

	[__DynamicallyInvokable]
	public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible)
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
		_buffer = buffer;
		_origin = (_position = index);
		_length = (_capacity = index + count);
		_writable = writable;
		_exposable = publiclyVisible;
		_expandable = false;
		_isOpen = true;
	}

	private void EnsureWriteable()
	{
		if (!CanWrite)
		{
			__Error.WriteNotSupported();
		}
	}

	[__DynamicallyInvokable]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				_isOpen = false;
				_writable = false;
				_expandable = false;
				_lastReadTask = null;
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	private bool EnsureCapacity(int value)
	{
		if (value < 0)
		{
			throw new IOException(Environment.GetResourceString("IO.IO_StreamTooLong"));
		}
		if (value > _capacity)
		{
			int num = value;
			if (num < 256)
			{
				num = 256;
			}
			if (num < _capacity * 2)
			{
				num = _capacity * 2;
			}
			if ((uint)(_capacity * 2) > 2147483591u)
			{
				num = ((value > 2147483591) ? value : 2147483591);
			}
			Capacity = num;
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public override void Flush()
	{
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		if (cancellationToken.IsCancellationRequested)
		{
			return Task.FromCancellation(cancellationToken);
		}
		try
		{
			Flush();
			return Task.CompletedTask;
		}
		catch (Exception exception)
		{
			return Task.FromException(exception);
		}
	}

	public virtual byte[] GetBuffer()
	{
		if (!_exposable)
		{
			throw new UnauthorizedAccessException(Environment.GetResourceString("UnauthorizedAccess_MemStreamBuffer"));
		}
		return _buffer;
	}

	[__DynamicallyInvokable]
	public virtual bool TryGetBuffer(out ArraySegment<byte> buffer)
	{
		if (!_exposable)
		{
			buffer = default(ArraySegment<byte>);
			return false;
		}
		buffer = new ArraySegment<byte>(_buffer, _origin, _length - _origin);
		return true;
	}

	internal byte[] InternalGetBuffer()
	{
		return _buffer;
	}

	[FriendAccessAllowed]
	internal void InternalGetOriginAndLength(out int origin, out int length)
	{
		if (!_isOpen)
		{
			__Error.StreamIsClosed();
		}
		origin = _origin;
		length = _length;
	}

	internal int InternalGetPosition()
	{
		if (!_isOpen)
		{
			__Error.StreamIsClosed();
		}
		return _position;
	}

	internal int InternalReadInt32()
	{
		if (!_isOpen)
		{
			__Error.StreamIsClosed();
		}
		int num = (_position += 4);
		if (num > _length)
		{
			_position = _length;
			__Error.EndOfFile();
		}
		return _buffer[num - 4] | (_buffer[num - 3] << 8) | (_buffer[num - 2] << 16) | (_buffer[num - 1] << 24);
	}

	internal int InternalEmulateRead(int count)
	{
		if (!_isOpen)
		{
			__Error.StreamIsClosed();
		}
		int num = _length - _position;
		if (num > count)
		{
			num = count;
		}
		if (num < 0)
		{
			num = 0;
		}
		_position += num;
		return num;
	}

	[__DynamicallyInvokable]
	public override int Read([In][Out] byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (!_isOpen)
		{
			__Error.StreamIsClosed();
		}
		int num = _length - _position;
		if (num > count)
		{
			num = count;
		}
		if (num <= 0)
		{
			return 0;
		}
		if (num <= 8)
		{
			int num2 = num;
			while (--num2 >= 0)
			{
				buffer[offset + num2] = _buffer[_position + num2];
			}
		}
		else
		{
			Buffer.InternalBlockCopy(_buffer, _position, buffer, offset, num);
		}
		_position += num;
		return num;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (cancellationToken.IsCancellationRequested)
		{
			return Task.FromCancellation<int>(cancellationToken);
		}
		try
		{
			int num = Read(buffer, offset, count);
			Task<int> lastReadTask = _lastReadTask;
			return (lastReadTask != null && lastReadTask.Result == num) ? lastReadTask : (_lastReadTask = Task.FromResult(num));
		}
		catch (OperationCanceledException exception)
		{
			return Task.FromCancellation<int>(exception);
		}
		catch (Exception exception2)
		{
			return Task.FromException<int>(exception2);
		}
	}

	[__DynamicallyInvokable]
	public override int ReadByte()
	{
		if (!_isOpen)
		{
			__Error.StreamIsClosed();
		}
		if (_position >= _length)
		{
			return -1;
		}
		return _buffer[_position++];
	}

	[__DynamicallyInvokable]
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
		if (GetType() != typeof(MemoryStream))
		{
			return base.CopyToAsync(destination, bufferSize, cancellationToken);
		}
		if (cancellationToken.IsCancellationRequested)
		{
			return Task.FromCancellation(cancellationToken);
		}
		int position = _position;
		int count = InternalEmulateRead(_length - _position);
		if (!(destination is MemoryStream memoryStream))
		{
			return destination.WriteAsync(_buffer, position, count, cancellationToken);
		}
		try
		{
			memoryStream.Write(_buffer, position, count);
			return Task.CompletedTask;
		}
		catch (Exception exception)
		{
			return Task.FromException(exception);
		}
	}

	[__DynamicallyInvokable]
	public override long Seek(long offset, SeekOrigin loc)
	{
		if (!_isOpen)
		{
			__Error.StreamIsClosed();
		}
		if (offset > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_StreamLength"));
		}
		switch (loc)
		{
		case SeekOrigin.Begin:
		{
			int num3 = _origin + (int)offset;
			if (offset < 0 || num3 < _origin)
			{
				throw new IOException(Environment.GetResourceString("IO.IO_SeekBeforeBegin"));
			}
			_position = num3;
			break;
		}
		case SeekOrigin.Current:
		{
			int num2 = _position + (int)offset;
			if (_position + offset < _origin || num2 < _origin)
			{
				throw new IOException(Environment.GetResourceString("IO.IO_SeekBeforeBegin"));
			}
			_position = num2;
			break;
		}
		case SeekOrigin.End:
		{
			int num = _length + (int)offset;
			if (_length + offset < _origin || num < _origin)
			{
				throw new IOException(Environment.GetResourceString("IO.IO_SeekBeforeBegin"));
			}
			_position = num;
			break;
		}
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidSeekOrigin"));
		}
		return _position;
	}

	[__DynamicallyInvokable]
	public override void SetLength(long value)
	{
		if (value < 0 || value > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_StreamLength"));
		}
		EnsureWriteable();
		if (value > int.MaxValue - _origin)
		{
			throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_StreamLength"));
		}
		int num = _origin + (int)value;
		if (!EnsureCapacity(num) && num > _length)
		{
			Array.Clear(_buffer, _length, num - _length);
		}
		_length = num;
		if (_position > num)
		{
			_position = num;
		}
	}

	[__DynamicallyInvokable]
	public virtual byte[] ToArray()
	{
		byte[] array = new byte[_length - _origin];
		Buffer.InternalBlockCopy(_buffer, _origin, array, 0, _length - _origin);
		return array;
	}

	[__DynamicallyInvokable]
	public override void Write(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (!_isOpen)
		{
			__Error.StreamIsClosed();
		}
		EnsureWriteable();
		int num = _position + count;
		if (num < 0)
		{
			throw new IOException(Environment.GetResourceString("IO.IO_StreamTooLong"));
		}
		if (num > _length)
		{
			bool flag = _position > _length;
			if (num > _capacity && EnsureCapacity(num))
			{
				flag = false;
			}
			if (flag)
			{
				Array.Clear(_buffer, _length, num - _length);
			}
			_length = num;
		}
		if (count <= 8 && buffer != _buffer)
		{
			int num2 = count;
			while (--num2 >= 0)
			{
				_buffer[_position + num2] = buffer[offset + num2];
			}
		}
		else
		{
			Buffer.InternalBlockCopy(buffer, offset, _buffer, _position, count);
		}
		_position = num;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		if (cancellationToken.IsCancellationRequested)
		{
			return Task.FromCancellation(cancellationToken);
		}
		try
		{
			Write(buffer, offset, count);
			return Task.CompletedTask;
		}
		catch (OperationCanceledException exception)
		{
			return Task.FromCancellation<VoidTaskResult>(exception);
		}
		catch (Exception exception2)
		{
			return Task.FromException(exception2);
		}
	}

	[__DynamicallyInvokable]
	public override void WriteByte(byte value)
	{
		if (!_isOpen)
		{
			__Error.StreamIsClosed();
		}
		EnsureWriteable();
		if (_position >= _length)
		{
			int num = _position + 1;
			bool flag = _position > _length;
			if (num >= _capacity && EnsureCapacity(num))
			{
				flag = false;
			}
			if (flag)
			{
				Array.Clear(_buffer, _length, _position - _length);
			}
			_length = num;
		}
		_buffer[_position++] = value;
	}

	[__DynamicallyInvokable]
	public virtual void WriteTo(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream", Environment.GetResourceString("ArgumentNull_Stream"));
		}
		if (!_isOpen)
		{
			__Error.StreamIsClosed();
		}
		stream.Write(_buffer, _origin, _length - _origin);
	}
}
