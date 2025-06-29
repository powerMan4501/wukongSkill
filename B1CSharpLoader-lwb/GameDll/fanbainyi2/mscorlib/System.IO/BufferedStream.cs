using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO;

[ComVisible(true)]
public sealed class BufferedStream : Stream
{
	private const int _DefaultBufferSize = 4096;

	private Stream _stream;

	private byte[] _buffer;

	private readonly int _bufferSize;

	private int _readPos;

	private int _readLen;

	private int _writePos;

	private BeginEndAwaitableAdapter _beginEndAwaitable;

	private Task<int> _lastSyncCompletedReadTask;

	private const int MaxShadowBufferSize = 81920;

	internal Stream UnderlyingStream
	{
		[FriendAccessAllowed]
		get
		{
			return _stream;
		}
	}

	internal int BufferSize
	{
		[FriendAccessAllowed]
		get
		{
			return _bufferSize;
		}
	}

	public override bool CanRead
	{
		get
		{
			if (_stream != null)
			{
				return _stream.CanRead;
			}
			return false;
		}
	}

	public override bool CanWrite
	{
		get
		{
			if (_stream != null)
			{
				return _stream.CanWrite;
			}
			return false;
		}
	}

	public override bool CanSeek
	{
		get
		{
			if (_stream != null)
			{
				return _stream.CanSeek;
			}
			return false;
		}
	}

	public override long Length
	{
		get
		{
			EnsureNotClosed();
			if (_writePos > 0)
			{
				FlushWrite();
			}
			return _stream.Length;
		}
	}

	public override long Position
	{
		get
		{
			EnsureNotClosed();
			EnsureCanSeek();
			return _stream.Position + (_readPos - _readLen + _writePos);
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
			}
			EnsureNotClosed();
			EnsureCanSeek();
			if (_writePos > 0)
			{
				FlushWrite();
			}
			_readPos = 0;
			_readLen = 0;
			_stream.Seek(value, SeekOrigin.Begin);
		}
	}

	private BufferedStream()
	{
	}

	public BufferedStream(Stream stream)
		: this(stream, 4096)
	{
	}

	public BufferedStream(Stream stream, int bufferSize)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (bufferSize <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferSize", Environment.GetResourceString("ArgumentOutOfRange_MustBePositive", "bufferSize"));
		}
		_stream = stream;
		_bufferSize = bufferSize;
		if (!_stream.CanRead && !_stream.CanWrite)
		{
			__Error.StreamIsClosed();
		}
	}

	private void EnsureNotClosed()
	{
		if (_stream == null)
		{
			__Error.StreamIsClosed();
		}
	}

	private void EnsureCanSeek()
	{
		if (!_stream.CanSeek)
		{
			__Error.SeekNotSupported();
		}
	}

	private void EnsureCanRead()
	{
		if (!_stream.CanRead)
		{
			__Error.ReadNotSupported();
		}
	}

	private void EnsureCanWrite()
	{
		if (!_stream.CanWrite)
		{
			__Error.WriteNotSupported();
		}
	}

	private void EnsureBeginEndAwaitableAllocated()
	{
		if (_beginEndAwaitable == null)
		{
			_beginEndAwaitable = new BeginEndAwaitableAdapter();
		}
	}

	private void EnsureShadowBufferAllocated()
	{
		if (_buffer.Length == _bufferSize && _bufferSize < 81920)
		{
			byte[] array = new byte[Math.Min(_bufferSize + _bufferSize, 81920)];
			Buffer.InternalBlockCopy(_buffer, 0, array, 0, _writePos);
			_buffer = array;
		}
	}

	private void EnsureBufferAllocated()
	{
		if (_buffer == null)
		{
			_buffer = new byte[_bufferSize];
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && _stream != null)
			{
				try
				{
					Flush();
					return;
				}
				finally
				{
					_stream.Close();
				}
			}
		}
		finally
		{
			_stream = null;
			_buffer = null;
			_lastSyncCompletedReadTask = null;
			base.Dispose(disposing);
		}
	}

	public override void Flush()
	{
		EnsureNotClosed();
		if (_writePos > 0)
		{
			FlushWrite();
		}
		else if (_readPos < _readLen)
		{
			if (_stream.CanSeek)
			{
				FlushRead();
				if (_stream.CanWrite || _stream is BufferedStream)
				{
					_stream.Flush();
				}
			}
		}
		else
		{
			if (_stream.CanWrite || _stream is BufferedStream)
			{
				_stream.Flush();
			}
			_writePos = (_readPos = (_readLen = 0));
		}
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		if (cancellationToken.IsCancellationRequested)
		{
			return Task.FromCancellation<int>(cancellationToken);
		}
		EnsureNotClosed();
		return FlushAsyncInternal(cancellationToken, this, _stream, _writePos, _readPos, _readLen);
	}

	private static async Task FlushAsyncInternal(CancellationToken cancellationToken, BufferedStream _this, Stream stream, int writePos, int readPos, int readLen)
	{
		SemaphoreSlim sem = _this.EnsureAsyncActiveSemaphoreInitialized();
		await sem.WaitAsync().ConfigureAwait(continueOnCapturedContext: false);
		try
		{
			if (writePos > 0)
			{
				await _this.FlushWriteAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			else if (readPos < readLen)
			{
				if (stream.CanSeek)
				{
					_this.FlushRead();
					if (stream.CanRead || stream is BufferedStream)
					{
						await stream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					}
				}
			}
			else if (stream.CanWrite || stream is BufferedStream)
			{
				await stream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		finally
		{
			sem.Release();
		}
	}

	private void FlushRead()
	{
		if (_readPos - _readLen != 0)
		{
			_stream.Seek(_readPos - _readLen, SeekOrigin.Current);
		}
		_readPos = 0;
		_readLen = 0;
	}

	private void ClearReadBufferBeforeWrite()
	{
		if (_readPos == _readLen)
		{
			_readPos = (_readLen = 0);
			return;
		}
		if (!_stream.CanSeek)
		{
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_CannotWriteToBufferedStreamIfReadBufferCannotBeFlushed"));
		}
		FlushRead();
	}

	private void FlushWrite()
	{
		_stream.Write(_buffer, 0, _writePos);
		_writePos = 0;
		_stream.Flush();
	}

	private async Task FlushWriteAsync(CancellationToken cancellationToken)
	{
		await _stream.WriteAsync(_buffer, 0, _writePos, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		_writePos = 0;
		await _stream.FlushAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	private int ReadFromBuffer(byte[] array, int offset, int count)
	{
		int num = _readLen - _readPos;
		if (num == 0)
		{
			return 0;
		}
		if (num > count)
		{
			num = count;
		}
		Buffer.InternalBlockCopy(_buffer, _readPos, array, offset, num);
		_readPos += num;
		return num;
	}

	private int ReadFromBuffer(byte[] array, int offset, int count, out Exception error)
	{
		try
		{
			error = null;
			return ReadFromBuffer(array, offset, count);
		}
		catch (Exception ex)
		{
			error = ex;
			return 0;
		}
	}

	public override int Read([In][Out] byte[] array, int offset, int count)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - offset < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		EnsureNotClosed();
		EnsureCanRead();
		int num = ReadFromBuffer(array, offset, count);
		if (num == count)
		{
			return num;
		}
		int num2 = num;
		if (num > 0)
		{
			count -= num;
			offset += num;
		}
		_readPos = (_readLen = 0);
		if (_writePos > 0)
		{
			FlushWrite();
		}
		if (count >= _bufferSize)
		{
			return _stream.Read(array, offset, count) + num2;
		}
		EnsureBufferAllocated();
		_readLen = _stream.Read(_buffer, 0, _bufferSize);
		num = ReadFromBuffer(array, offset, count);
		return num + num2;
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
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
		if (_stream == null)
		{
			__Error.ReadNotSupported();
		}
		EnsureCanRead();
		int num = 0;
		SemaphoreSlim semaphoreSlim = EnsureAsyncActiveSemaphoreInitialized();
		Task task = semaphoreSlim.WaitAsync();
		if (task.Status == TaskStatus.RanToCompletion)
		{
			bool flag = true;
			try
			{
				num = ReadFromBuffer(buffer, offset, count, out var error);
				flag = num == count || error != null;
				if (flag)
				{
					SynchronousAsyncResult synchronousAsyncResult = ((error == null) ? new SynchronousAsyncResult(num, state) : new SynchronousAsyncResult(error, state, isWrite: false));
					callback?.Invoke(synchronousAsyncResult);
					return synchronousAsyncResult;
				}
			}
			finally
			{
				if (flag)
				{
					semaphoreSlim.Release();
				}
			}
		}
		return BeginReadFromUnderlyingStream(buffer, offset + num, count - num, callback, state, num, task);
	}

	private IAsyncResult BeginReadFromUnderlyingStream(byte[] buffer, int offset, int count, AsyncCallback callback, object state, int bytesAlreadySatisfied, Task semaphoreLockTask)
	{
		Task<int> task = ReadFromUnderlyingStreamAsync(buffer, offset, count, CancellationToken.None, bytesAlreadySatisfied, semaphoreLockTask, useApmPattern: true);
		return TaskToApm.Begin(task, callback, state);
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (asyncResult is SynchronousAsyncResult)
		{
			return SynchronousAsyncResult.EndRead(asyncResult);
		}
		return TaskToApm.End<int>(asyncResult);
	}

	private Task<int> LastSyncCompletedReadTask(int val)
	{
		Task<int> lastSyncCompletedReadTask = _lastSyncCompletedReadTask;
		if (lastSyncCompletedReadTask != null && lastSyncCompletedReadTask.Result == val)
		{
			return lastSyncCompletedReadTask;
		}
		return _lastSyncCompletedReadTask = Task.FromResult(val);
	}

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
		EnsureNotClosed();
		EnsureCanRead();
		int num = 0;
		SemaphoreSlim semaphoreSlim = EnsureAsyncActiveSemaphoreInitialized();
		Task task = semaphoreSlim.WaitAsync();
		if (task.Status == TaskStatus.RanToCompletion)
		{
			bool flag = true;
			try
			{
				num = ReadFromBuffer(buffer, offset, count, out var error);
				flag = num == count || error != null;
				if (flag)
				{
					return (error == null) ? LastSyncCompletedReadTask(num) : Task.FromException<int>(error);
				}
			}
			finally
			{
				if (flag)
				{
					semaphoreSlim.Release();
				}
			}
		}
		return ReadFromUnderlyingStreamAsync(buffer, offset + num, count - num, cancellationToken, num, task, useApmPattern: false);
	}

	private async Task<int> ReadFromUnderlyingStreamAsync(byte[] array, int offset, int count, CancellationToken cancellationToken, int bytesAlreadySatisfied, Task semaphoreLockTask, bool useApmPattern)
	{
		await semaphoreLockTask.ConfigureAwait(continueOnCapturedContext: false);
		try
		{
			int num = ReadFromBuffer(array, offset, count);
			if (num == count)
			{
				return bytesAlreadySatisfied + num;
			}
			if (num > 0)
			{
				count -= num;
				offset += num;
				bytesAlreadySatisfied += num;
			}
			_readPos = (_readLen = 0);
			if (_writePos > 0)
			{
				await FlushWriteAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			if (count >= _bufferSize)
			{
				int num2;
				if (useApmPattern)
				{
					EnsureBeginEndAwaitableAllocated();
					_stream.BeginRead(array, offset, count, BeginEndAwaitableAdapter.Callback, _beginEndAwaitable);
					num2 = bytesAlreadySatisfied;
					Stream stream = _stream;
					return num2 + stream.EndRead(await _beginEndAwaitable);
				}
				num2 = bytesAlreadySatisfied;
				return num2 + await _stream.ReadAsync(array, offset, count, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			EnsureBufferAllocated();
			if (useApmPattern)
			{
				EnsureBeginEndAwaitableAllocated();
				_stream.BeginRead(_buffer, 0, _bufferSize, BeginEndAwaitableAdapter.Callback, _beginEndAwaitable);
				Stream stream = _stream;
				_readLen = stream.EndRead(await _beginEndAwaitable);
			}
			else
			{
				_readLen = await _stream.ReadAsync(_buffer, 0, _bufferSize, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			num = ReadFromBuffer(array, offset, count);
			return bytesAlreadySatisfied + num;
		}
		finally
		{
			SemaphoreSlim semaphoreSlim = EnsureAsyncActiveSemaphoreInitialized();
			semaphoreSlim.Release();
		}
	}

	public override int ReadByte()
	{
		EnsureNotClosed();
		EnsureCanRead();
		if (_readPos == _readLen)
		{
			if (_writePos > 0)
			{
				FlushWrite();
			}
			EnsureBufferAllocated();
			_readLen = _stream.Read(_buffer, 0, _bufferSize);
			_readPos = 0;
		}
		if (_readPos == _readLen)
		{
			return -1;
		}
		return _buffer[_readPos++];
	}

	private void WriteToBuffer(byte[] array, ref int offset, ref int count)
	{
		int num = Math.Min(_bufferSize - _writePos, count);
		if (num > 0)
		{
			EnsureBufferAllocated();
			Buffer.InternalBlockCopy(array, offset, _buffer, _writePos, num);
			_writePos += num;
			count -= num;
			offset += num;
		}
	}

	private void WriteToBuffer(byte[] array, ref int offset, ref int count, out Exception error)
	{
		try
		{
			error = null;
			WriteToBuffer(array, ref offset, ref count);
		}
		catch (Exception ex)
		{
			error = ex;
		}
	}

	public override void Write(byte[] array, int offset, int count)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array", Environment.GetResourceString("ArgumentNull_Buffer"));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (array.Length - offset < count)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidOffLen"));
		}
		EnsureNotClosed();
		EnsureCanWrite();
		if (_writePos == 0)
		{
			ClearReadBufferBeforeWrite();
		}
		int num;
		checked
		{
			num = _writePos + count;
			if (num + count < _bufferSize + _bufferSize)
			{
				WriteToBuffer(array, ref offset, ref count);
				if (_writePos >= _bufferSize)
				{
					_stream.Write(_buffer, 0, _writePos);
					_writePos = 0;
					WriteToBuffer(array, ref offset, ref count);
				}
				return;
			}
		}
		if (_writePos > 0)
		{
			if (num <= _bufferSize + _bufferSize && num <= 81920)
			{
				EnsureShadowBufferAllocated();
				Buffer.InternalBlockCopy(array, offset, _buffer, _writePos, count);
				_stream.Write(_buffer, 0, num);
				_writePos = 0;
				return;
			}
			_stream.Write(_buffer, 0, _writePos);
			_writePos = 0;
		}
		_stream.Write(array, offset, count);
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
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
		if (_stream == null)
		{
			__Error.ReadNotSupported();
		}
		EnsureCanWrite();
		SemaphoreSlim semaphoreSlim = EnsureAsyncActiveSemaphoreInitialized();
		Task task = semaphoreSlim.WaitAsync();
		if (task.Status == TaskStatus.RanToCompletion)
		{
			bool flag = true;
			try
			{
				if (_writePos == 0)
				{
					ClearReadBufferBeforeWrite();
				}
				flag = count < _bufferSize - _writePos;
				if (flag)
				{
					WriteToBuffer(buffer, ref offset, ref count, out var error);
					SynchronousAsyncResult synchronousAsyncResult = ((error == null) ? new SynchronousAsyncResult(state) : new SynchronousAsyncResult(error, state, isWrite: true));
					callback?.Invoke(synchronousAsyncResult);
					return synchronousAsyncResult;
				}
			}
			finally
			{
				if (flag)
				{
					semaphoreSlim.Release();
				}
			}
		}
		return BeginWriteToUnderlyingStream(buffer, offset, count, callback, state, task);
	}

	private IAsyncResult BeginWriteToUnderlyingStream(byte[] buffer, int offset, int count, AsyncCallback callback, object state, Task semaphoreLockTask)
	{
		Task task = WriteToUnderlyingStreamAsync(buffer, offset, count, CancellationToken.None, semaphoreLockTask, useApmPattern: true);
		return TaskToApm.Begin(task, callback, state);
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (asyncResult is SynchronousAsyncResult)
		{
			SynchronousAsyncResult.EndWrite(asyncResult);
		}
		else
		{
			TaskToApm.End(asyncResult);
		}
	}

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
			return Task.FromCancellation<int>(cancellationToken);
		}
		EnsureNotClosed();
		EnsureCanWrite();
		SemaphoreSlim semaphoreSlim = EnsureAsyncActiveSemaphoreInitialized();
		Task task = semaphoreSlim.WaitAsync();
		if (task.Status == TaskStatus.RanToCompletion)
		{
			bool flag = true;
			try
			{
				if (_writePos == 0)
				{
					ClearReadBufferBeforeWrite();
				}
				flag = count < _bufferSize - _writePos;
				if (flag)
				{
					WriteToBuffer(buffer, ref offset, ref count, out var error);
					return (error == null) ? Task.CompletedTask : Task.FromException(error);
				}
			}
			finally
			{
				if (flag)
				{
					semaphoreSlim.Release();
				}
			}
		}
		return WriteToUnderlyingStreamAsync(buffer, offset, count, cancellationToken, task, useApmPattern: false);
	}

	private async Task WriteToUnderlyingStreamAsync(byte[] array, int offset, int count, CancellationToken cancellationToken, Task semaphoreLockTask, bool useApmPattern)
	{
		await semaphoreLockTask.ConfigureAwait(continueOnCapturedContext: false);
		try
		{
			if (_writePos == 0)
			{
				ClearReadBufferBeforeWrite();
			}
			int num;
			checked
			{
				num = _writePos + count;
				if (num + count < _bufferSize + _bufferSize)
				{
					WriteToBuffer(array, ref offset, ref count);
					if (_writePos >= _bufferSize)
					{
						if (!useApmPattern)
						{
							await _stream.WriteAsync(_buffer, 0, _writePos, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
						}
						else
						{
							EnsureBeginEndAwaitableAllocated();
							_stream.BeginWrite(_buffer, 0, _writePos, BeginEndAwaitableAdapter.Callback, _beginEndAwaitable);
							Stream stream = _stream;
							stream.EndWrite(await _beginEndAwaitable);
						}
						_writePos = 0;
						WriteToBuffer(array, ref offset, ref count);
					}
					return;
				}
			}
			if (_writePos > 0)
			{
				if (num <= _bufferSize + _bufferSize && num <= 81920)
				{
					EnsureShadowBufferAllocated();
					Buffer.InternalBlockCopy(array, offset, _buffer, _writePos, count);
					if (!useApmPattern)
					{
						await _stream.WriteAsync(_buffer, 0, num, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					}
					else
					{
						EnsureBeginEndAwaitableAllocated();
						_stream.BeginWrite(_buffer, 0, num, BeginEndAwaitableAdapter.Callback, _beginEndAwaitable);
						Stream stream = _stream;
						stream.EndWrite(await _beginEndAwaitable);
					}
					_writePos = 0;
					return;
				}
				if (!useApmPattern)
				{
					await _stream.WriteAsync(_buffer, 0, _writePos, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				else
				{
					EnsureBeginEndAwaitableAllocated();
					_stream.BeginWrite(_buffer, 0, _writePos, BeginEndAwaitableAdapter.Callback, _beginEndAwaitable);
					Stream stream = _stream;
					stream.EndWrite(await _beginEndAwaitable);
				}
				_writePos = 0;
			}
			if (useApmPattern)
			{
				EnsureBeginEndAwaitableAllocated();
				_stream.BeginWrite(array, offset, count, BeginEndAwaitableAdapter.Callback, _beginEndAwaitable);
				Stream stream = _stream;
				stream.EndWrite(await _beginEndAwaitable);
			}
			else
			{
				await _stream.WriteAsync(array, offset, count, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
		}
		finally
		{
			SemaphoreSlim semaphoreSlim = EnsureAsyncActiveSemaphoreInitialized();
			semaphoreSlim.Release();
		}
	}

	public override void WriteByte(byte value)
	{
		EnsureNotClosed();
		if (_writePos == 0)
		{
			EnsureCanWrite();
			ClearReadBufferBeforeWrite();
			EnsureBufferAllocated();
		}
		if (_writePos >= _bufferSize - 1)
		{
			FlushWrite();
		}
		_buffer[_writePos++] = value;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		EnsureNotClosed();
		EnsureCanSeek();
		if (_writePos > 0)
		{
			FlushWrite();
			return _stream.Seek(offset, origin);
		}
		if (_readLen - _readPos > 0 && origin == SeekOrigin.Current)
		{
			offset -= _readLen - _readPos;
		}
		long position = Position;
		long num = _stream.Seek(offset, origin);
		_readPos = (int)(num - (position - _readPos));
		if (0 <= _readPos && _readPos < _readLen)
		{
			_stream.Seek(_readLen - _readPos, SeekOrigin.Current);
		}
		else
		{
			_readPos = (_readLen = 0);
		}
		return num;
	}

	public override void SetLength(long value)
	{
		if (value < 0)
		{
			throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_NegFileSize"));
		}
		EnsureNotClosed();
		EnsureCanSeek();
		EnsureCanWrite();
		Flush();
		_stream.SetLength(value);
	}
}
