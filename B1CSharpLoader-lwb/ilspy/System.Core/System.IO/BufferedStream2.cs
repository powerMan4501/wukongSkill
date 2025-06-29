using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;

namespace System.IO;

[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
internal abstract class BufferedStream2 : Stream
{
	protected internal const int DefaultBufferSize = 32768;

	protected int bufferSize;

	private byte[] _buffer;

	private int _pendingBufferCopy;

	private int _writePos;

	private int _readPos;

	private int _readLen;

	protected long pos;

	protected long UnderlyingStreamPosition
	{
		get
		{
			return pos;
		}
		set
		{
			Interlocked.Exchange(ref pos, value);
		}
	}

	public override void Write(byte[] array, int offset, int count)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array", System.SR.GetString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", System.SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", System.SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - offset < count)
		{
			throw new ArgumentException(System.SR.GetString("Argument_InvalidOffLen"));
		}
		if (_writePos == 0)
		{
			if (!CanWrite)
			{
				__Error.WriteNotSupported();
			}
			if (_readPos < _readLen)
			{
				FlushRead();
			}
			_readPos = 0;
			_readLen = 0;
		}
		if (count == 0)
		{
			return;
		}
		int num2;
		while (true)
		{
			if (_writePos > bufferSize)
			{
				Thread.Sleep(1);
				continue;
			}
			if (_writePos == 0 && count >= bufferSize)
			{
				WriteCore(array, offset, count, blockForWrite: true);
				return;
			}
			Thread.BeginCriticalRegion();
			Interlocked.Increment(ref _pendingBufferCopy);
			int num = Interlocked.Add(ref _writePos, count);
			num2 = num - count;
			if (num <= bufferSize)
			{
				break;
			}
			Interlocked.Decrement(ref _pendingBufferCopy);
			Thread.EndCriticalRegion();
			if (_writePos > bufferSize && num2 <= bufferSize && num2 > 0)
			{
				while (_pendingBufferCopy != 0)
				{
					Thread.SpinWait(1);
				}
				WriteCore(_buffer, 0, num2, blockForWrite: true);
				_writePos = 0;
			}
		}
		if (_buffer == null)
		{
			Interlocked.CompareExchange(ref _buffer, new byte[bufferSize], null);
		}
		Buffer.BlockCopy(array, offset, _buffer, num2, count);
		Interlocked.Decrement(ref _pendingBufferCopy);
		Thread.EndCriticalRegion();
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public override void Flush()
	{
		try
		{
			if (_writePos > 0)
			{
				FlushWrite(blockForWrite: false);
			}
			else if (_readPos < _readLen)
			{
				FlushRead();
			}
		}
		finally
		{
			_writePos = 0;
			_readPos = 0;
			_readLen = 0;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	protected void FlushRead()
	{
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	protected void FlushWrite(bool blockForWrite)
	{
		if (_writePos > 0)
		{
			WriteCore(_buffer, 0, _writePos, blockForWrite);
		}
		_writePos = 0;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (_writePos > 0)
			{
				FlushWrite(disposing);
			}
		}
		finally
		{
			_readPos = 0;
			_readLen = 0;
			_writePos = 0;
			base.Dispose(disposing);
		}
	}

	protected long AddUnderlyingStreamPosition(long posDelta)
	{
		return Interlocked.Add(ref pos, posDelta);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	protected internal void DiscardBuffer()
	{
		_readPos = 0;
		_readLen = 0;
		_writePos = 0;
	}

	private void WriteCore(byte[] buffer, int offset, int count, bool blockForWrite)
	{
		WriteCore(buffer, offset, count, blockForWrite, out var _);
	}

	protected abstract void WriteCore(byte[] buffer, int offset, int count, bool blockForWrite, out long streamPos);
}
