using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.IO;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public abstract class Stream : MarshalByRefObject, IDisposable
{
	private struct ReadWriteParameters
	{
		internal byte[] Buffer;

		internal int Offset;

		internal int Count;
	}

	private sealed class ReadWriteTask : Task<int>, ITaskCompletionAction
	{
		internal readonly bool _isRead;

		internal Stream _stream;

		internal byte[] _buffer;

		internal int _offset;

		internal int _count;

		private AsyncCallback _callback;

		private ExecutionContext _context;

		[SecurityCritical]
		private static ContextCallback s_invokeAsyncCallback;

		internal void ClearBeginState()
		{
			_stream = null;
			_buffer = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SecuritySafeCritical]
		public ReadWriteTask(bool isRead, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback)
			: base(function, state, CancellationToken.None, TaskCreationOptions.DenyChildAttach)
		{
			StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
			_isRead = isRead;
			_stream = stream;
			_buffer = buffer;
			_offset = offset;
			_count = count;
			if (callback != null)
			{
				_callback = callback;
				_context = ExecutionContext.Capture(ref stackMark, ExecutionContext.CaptureOptions.IgnoreSyncCtx | ExecutionContext.CaptureOptions.OptimizeDefaultCase);
				AddCompletionAction(this);
			}
		}

		[SecurityCritical]
		private static void InvokeAsyncCallback(object completedTask)
		{
			ReadWriteTask readWriteTask = (ReadWriteTask)completedTask;
			AsyncCallback callback = readWriteTask._callback;
			readWriteTask._callback = null;
			callback(readWriteTask);
		}

		[SecuritySafeCritical]
		void ITaskCompletionAction.Invoke(Task completingTask)
		{
			ExecutionContext context = _context;
			if (context == null)
			{
				AsyncCallback callback = _callback;
				_callback = null;
				callback(completingTask);
				return;
			}
			_context = null;
			ContextCallback callback2 = InvokeAsyncCallback;
			using (context)
			{
				ExecutionContext.Run(context, callback2, this, preserveSyncCtx: true);
			}
		}
	}

	[Serializable]
	private sealed class NullStream : Stream
	{
		private static Task<int> s_nullReadTask;

		public override bool CanRead => true;

		public override bool CanWrite => true;

		public override bool CanSeek => true;

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		internal NullStream()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void Flush()
		{
		}

		[ComVisible(false)]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return Task.CompletedTask;
			}
			return Task.FromCancellation(cancellationToken);
		}

		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (!CanRead)
			{
				__Error.ReadNotSupported();
			}
			return BlockingBeginRead(buffer, offset, count, callback, state);
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			return BlockingEndRead(asyncResult);
		}

		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (!CanWrite)
			{
				__Error.WriteNotSupported();
			}
			return BlockingBeginWrite(buffer, offset, count, callback, state);
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			BlockingEndWrite(asyncResult);
		}

		public override int Read([In][Out] byte[] buffer, int offset, int count)
		{
			return 0;
		}

		[ComVisible(false)]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			Task<int> task = s_nullReadTask;
			if (task == null)
			{
				task = (s_nullReadTask = new Task<int>(canceled: false, 0, (TaskCreationOptions)16384, CancellationToken.None));
			}
			return task;
		}

		public override int ReadByte()
		{
			return -1;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[ComVisible(false)]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return Task.CompletedTask;
			}
			return Task.FromCancellation(cancellationToken);
		}

		public override void WriteByte(byte value)
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long length)
		{
		}
	}

	internal sealed class SynchronousAsyncResult : IAsyncResult
	{
		private readonly object _stateObject;

		private readonly bool _isWrite;

		private ManualResetEvent _waitHandle;

		private ExceptionDispatchInfo _exceptionInfo;

		private bool _endXxxCalled;

		private int _bytesRead;

		public bool IsCompleted => true;

		public WaitHandle AsyncWaitHandle => LazyInitializer.EnsureInitialized(ref _waitHandle, () => new ManualResetEvent(initialState: true));

		public object AsyncState => _stateObject;

		public bool CompletedSynchronously => true;

		internal SynchronousAsyncResult(int bytesRead, object asyncStateObject)
		{
			_bytesRead = bytesRead;
			_stateObject = asyncStateObject;
		}

		internal SynchronousAsyncResult(object asyncStateObject)
		{
			_stateObject = asyncStateObject;
			_isWrite = true;
		}

		internal SynchronousAsyncResult(Exception ex, object asyncStateObject, bool isWrite)
		{
			_exceptionInfo = ExceptionDispatchInfo.Capture(ex);
			_stateObject = asyncStateObject;
			_isWrite = isWrite;
		}

		internal void ThrowIfError()
		{
			if (_exceptionInfo != null)
			{
				_exceptionInfo.Throw();
			}
		}

		internal static int EndRead(IAsyncResult asyncResult)
		{
			SynchronousAsyncResult synchronousAsyncResult = asyncResult as SynchronousAsyncResult;
			if (synchronousAsyncResult == null || synchronousAsyncResult._isWrite)
			{
				__Error.WrongAsyncResult();
			}
			if (synchronousAsyncResult._endXxxCalled)
			{
				__Error.EndReadCalledTwice();
			}
			synchronousAsyncResult._endXxxCalled = true;
			synchronousAsyncResult.ThrowIfError();
			return synchronousAsyncResult._bytesRead;
		}

		internal static void EndWrite(IAsyncResult asyncResult)
		{
			SynchronousAsyncResult synchronousAsyncResult = asyncResult as SynchronousAsyncResult;
			if (synchronousAsyncResult == null || !synchronousAsyncResult._isWrite)
			{
				__Error.WrongAsyncResult();
			}
			if (synchronousAsyncResult._endXxxCalled)
			{
				__Error.EndWriteCalledTwice();
			}
			synchronousAsyncResult._endXxxCalled = true;
			synchronousAsyncResult.ThrowIfError();
		}
	}

	[Serializable]
	internal sealed class SyncStream : Stream, IDisposable
	{
		private Stream _stream;

		[NonSerialized]
		private bool? _overridesBeginRead;

		[NonSerialized]
		private bool? _overridesBeginWrite;

		public override bool CanRead => _stream.CanRead;

		public override bool CanWrite => _stream.CanWrite;

		public override bool CanSeek => _stream.CanSeek;

		[ComVisible(false)]
		public override bool CanTimeout => _stream.CanTimeout;

		public override long Length
		{
			get
			{
				lock (_stream)
				{
					return _stream.Length;
				}
			}
		}

		public override long Position
		{
			get
			{
				lock (_stream)
				{
					return _stream.Position;
				}
			}
			set
			{
				lock (_stream)
				{
					_stream.Position = value;
				}
			}
		}

		[ComVisible(false)]
		public override int ReadTimeout
		{
			get
			{
				return _stream.ReadTimeout;
			}
			set
			{
				_stream.ReadTimeout = value;
			}
		}

		[ComVisible(false)]
		public override int WriteTimeout
		{
			get
			{
				return _stream.WriteTimeout;
			}
			set
			{
				_stream.WriteTimeout = value;
			}
		}

		internal SyncStream(Stream stream)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			_stream = stream;
		}

		public override void Close()
		{
			lock (_stream)
			{
				try
				{
					_stream.Close();
				}
				finally
				{
					base.Dispose(disposing: true);
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			lock (_stream)
			{
				try
				{
					if (disposing)
					{
						((IDisposable)_stream).Dispose();
					}
				}
				finally
				{
					base.Dispose(disposing);
				}
			}
		}

		public override void Flush()
		{
			lock (_stream)
			{
				_stream.Flush();
			}
		}

		public override int Read([In][Out] byte[] bytes, int offset, int count)
		{
			lock (_stream)
			{
				return _stream.Read(bytes, offset, count);
			}
		}

		public override int ReadByte()
		{
			lock (_stream)
			{
				return _stream.ReadByte();
			}
		}

		private static bool OverridesBeginMethod(Stream stream, string methodName)
		{
			MethodInfo[] methods = stream.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public);
			MethodInfo[] array = methods;
			foreach (MethodInfo methodInfo in array)
			{
				if (methodInfo.DeclaringType == typeof(Stream) && methodInfo.Name == methodName)
				{
					return false;
				}
			}
			return true;
		}

		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (!_overridesBeginRead.HasValue)
			{
				_overridesBeginRead = OverridesBeginMethod(_stream, "BeginRead");
			}
			lock (_stream)
			{
				return _overridesBeginRead.Value ? _stream.BeginRead(buffer, offset, count, callback, state) : _stream.BeginReadInternal(buffer, offset, count, callback, state, serializeAsynchronously: true);
			}
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			lock (_stream)
			{
				return _stream.EndRead(asyncResult);
			}
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			lock (_stream)
			{
				return _stream.Seek(offset, origin);
			}
		}

		public override void SetLength(long length)
		{
			lock (_stream)
			{
				_stream.SetLength(length);
			}
		}

		public override void Write(byte[] bytes, int offset, int count)
		{
			lock (_stream)
			{
				_stream.Write(bytes, offset, count);
			}
		}

		public override void WriteByte(byte b)
		{
			lock (_stream)
			{
				_stream.WriteByte(b);
			}
		}

		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (!_overridesBeginWrite.HasValue)
			{
				_overridesBeginWrite = OverridesBeginMethod(_stream, "BeginWrite");
			}
			lock (_stream)
			{
				return _overridesBeginWrite.Value ? _stream.BeginWrite(buffer, offset, count, callback, state) : _stream.BeginWriteInternal(buffer, offset, count, callback, state, serializeAsynchronously: true);
			}
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			lock (_stream)
			{
				_stream.EndWrite(asyncResult);
			}
		}
	}

	[__DynamicallyInvokable]
	public static readonly Stream Null = new NullStream();

	private const int _DefaultCopyBufferSize = 81920;

	[NonSerialized]
	private ReadWriteTask _activeReadWriteTask;

	[NonSerialized]
	private SemaphoreSlim _asyncActiveSemaphore;

	[__DynamicallyInvokable]
	public abstract bool CanRead
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract bool CanSeek
	{
		[__DynamicallyInvokable]
		get;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public virtual bool CanTimeout
	{
		[__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[__DynamicallyInvokable]
	public abstract bool CanWrite
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract long Length
	{
		[__DynamicallyInvokable]
		get;
	}

	[__DynamicallyInvokable]
	public abstract long Position
	{
		[__DynamicallyInvokable]
		get;
		[__DynamicallyInvokable]
		set;
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public virtual int ReadTimeout
	{
		[__DynamicallyInvokable]
		get
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_TimeoutsNotSupported"));
		}
		[__DynamicallyInvokable]
		set
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_TimeoutsNotSupported"));
		}
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	public virtual int WriteTimeout
	{
		[__DynamicallyInvokable]
		get
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_TimeoutsNotSupported"));
		}
		[__DynamicallyInvokable]
		set
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_TimeoutsNotSupported"));
		}
	}

	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
	{
		return LazyInitializer.EnsureInitialized(ref _asyncActiveSemaphore, () => new SemaphoreSlim(1, 1));
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task CopyToAsync(Stream destination)
	{
		return CopyToAsync(destination, 81920);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task CopyToAsync(Stream destination, int bufferSize)
	{
		return CopyToAsync(destination, bufferSize, CancellationToken.None);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
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
		return CopyToAsyncInternal(destination, bufferSize, cancellationToken);
	}

	private async Task CopyToAsyncInternal(Stream destination, int bufferSize, CancellationToken cancellationToken)
	{
		byte[] buffer = new byte[bufferSize];
		int count;
		while ((count = await ReadAsync(buffer, 0, buffer.Length, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) != 0)
		{
			await destination.WriteAsync(buffer, 0, count, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
	}

	[__DynamicallyInvokable]
	public void CopyTo(Stream destination)
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
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
		InternalCopyTo(destination, 81920);
	}

	[__DynamicallyInvokable]
	public void CopyTo(Stream destination, int bufferSize)
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
		InternalCopyTo(destination, bufferSize);
	}

	private void InternalCopyTo(Stream destination, int bufferSize)
	{
		byte[] array = new byte[bufferSize];
		int count;
		while ((count = Read(array, 0, array.Length)) != 0)
		{
			destination.Write(array, 0, count);
		}
	}

	public virtual void Close()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[__DynamicallyInvokable]
	public void Dispose()
	{
		Close();
	}

	[__DynamicallyInvokable]
	protected virtual void Dispose(bool disposing)
	{
	}

	[__DynamicallyInvokable]
	public abstract void Flush();

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task FlushAsync()
	{
		return FlushAsync(CancellationToken.None);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task FlushAsync(CancellationToken cancellationToken)
	{
		return Task.Factory.StartNew(delegate(object state)
		{
			((Stream)state).Flush();
		}, this, cancellationToken, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
	}

	[Obsolete("CreateWaitHandle will be removed eventually.  Please use \"new ManualResetEvent(false)\" instead.")]
	protected virtual WaitHandle CreateWaitHandle()
	{
		return new ManualResetEvent(initialState: false);
	}

	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return BeginReadInternal(buffer, offset, count, callback, state, serializeAsynchronously: false);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously)
	{
		if (!CanRead)
		{
			__Error.ReadNotSupported();
		}
		if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			return BlockingBeginRead(buffer, offset, count, callback, state);
		}
		SemaphoreSlim semaphoreSlim = EnsureAsyncActiveSemaphoreInitialized();
		Task task = null;
		if (serializeAsynchronously)
		{
			task = semaphoreSlim.WaitAsync();
		}
		else
		{
			semaphoreSlim.Wait();
		}
		ReadWriteTask readWriteTask = new ReadWriteTask(isRead: true, delegate
		{
			ReadWriteTask readWriteTask2 = Task.InternalCurrent as ReadWriteTask;
			int result = readWriteTask2._stream.Read(readWriteTask2._buffer, readWriteTask2._offset, readWriteTask2._count);
			readWriteTask2.ClearBeginState();
			return result;
		}, state, this, buffer, offset, count, callback);
		if (task != null)
		{
			RunReadWriteTaskWhenReady(task, readWriteTask);
		}
		else
		{
			RunReadWriteTask(readWriteTask);
		}
		return readWriteTask;
	}

	[__DynamicallyInvokable]
	public virtual int EndRead(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			return BlockingEndRead(asyncResult);
		}
		ReadWriteTask activeReadWriteTask = _activeReadWriteTask;
		if (activeReadWriteTask == null)
		{
			throw new ArgumentException(Environment.GetResourceString("InvalidOperation_WrongAsyncResultOrEndReadCalledMultiple"));
		}
		if (activeReadWriteTask != asyncResult)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_WrongAsyncResultOrEndReadCalledMultiple"));
		}
		if (!activeReadWriteTask._isRead)
		{
			throw new ArgumentException(Environment.GetResourceString("InvalidOperation_WrongAsyncResultOrEndReadCalledMultiple"));
		}
		try
		{
			return activeReadWriteTask.GetAwaiter().GetResult();
		}
		finally
		{
			_activeReadWriteTask = null;
			_asyncActiveSemaphore.Release();
		}
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task<int> ReadAsync(byte[] buffer, int offset, int count)
	{
		return ReadAsync(buffer, offset, count, CancellationToken.None);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (!cancellationToken.IsCancellationRequested)
		{
			return BeginEndReadAsync(buffer, offset, count);
		}
		return Task.FromCancellation<int>(cancellationToken);
	}

	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count)
	{
		return TaskFactory<int>.FromAsyncTrim(this, new ReadWriteParameters
		{
			Buffer = buffer,
			Offset = offset,
			Count = count
		}, (Stream stream, ReadWriteParameters args, AsyncCallback callback, object state) => stream.BeginRead(args.Buffer, args.Offset, args.Count, callback, state), (Stream stream, IAsyncResult asyncResult) => stream.EndRead(asyncResult));
	}

	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return BeginWriteInternal(buffer, offset, count, callback, state, serializeAsynchronously: false);
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously)
	{
		if (!CanWrite)
		{
			__Error.WriteNotSupported();
		}
		if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			return BlockingBeginWrite(buffer, offset, count, callback, state);
		}
		SemaphoreSlim semaphoreSlim = EnsureAsyncActiveSemaphoreInitialized();
		Task task = null;
		if (serializeAsynchronously)
		{
			task = semaphoreSlim.WaitAsync();
		}
		else
		{
			semaphoreSlim.Wait();
		}
		ReadWriteTask readWriteTask = new ReadWriteTask(isRead: false, delegate
		{
			ReadWriteTask readWriteTask2 = Task.InternalCurrent as ReadWriteTask;
			readWriteTask2._stream.Write(readWriteTask2._buffer, readWriteTask2._offset, readWriteTask2._count);
			readWriteTask2.ClearBeginState();
			return 0;
		}, state, this, buffer, offset, count, callback);
		if (task != null)
		{
			RunReadWriteTaskWhenReady(task, readWriteTask);
		}
		else
		{
			RunReadWriteTask(readWriteTask);
		}
		return readWriteTask;
	}

	private void RunReadWriteTaskWhenReady(Task asyncWaiter, ReadWriteTask readWriteTask)
	{
		if (asyncWaiter.IsCompleted)
		{
			RunReadWriteTask(readWriteTask);
			return;
		}
		asyncWaiter.ContinueWith(delegate(Task t, object state)
		{
			Tuple<Stream, ReadWriteTask> tuple = (Tuple<Stream, ReadWriteTask>)state;
			tuple.Item1.RunReadWriteTask(tuple.Item2);
		}, Tuple.Create(this, readWriteTask), default(CancellationToken), TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
	}

	private void RunReadWriteTask(ReadWriteTask readWriteTask)
	{
		_activeReadWriteTask = readWriteTask;
		readWriteTask.m_taskScheduler = TaskScheduler.Default;
		readWriteTask.ScheduleAndStart(needsProtection: false);
	}

	[__DynamicallyInvokable]
	public virtual void EndWrite(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
		{
			BlockingEndWrite(asyncResult);
			return;
		}
		ReadWriteTask activeReadWriteTask = _activeReadWriteTask;
		if (activeReadWriteTask == null)
		{
			throw new ArgumentException(Environment.GetResourceString("InvalidOperation_WrongAsyncResultOrEndWriteCalledMultiple"));
		}
		if (activeReadWriteTask != asyncResult)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_WrongAsyncResultOrEndWriteCalledMultiple"));
		}
		if (activeReadWriteTask._isRead)
		{
			throw new ArgumentException(Environment.GetResourceString("InvalidOperation_WrongAsyncResultOrEndWriteCalledMultiple"));
		}
		try
		{
			activeReadWriteTask.GetAwaiter().GetResult();
		}
		finally
		{
			_activeReadWriteTask = null;
			_asyncActiveSemaphore.Release();
		}
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task WriteAsync(byte[] buffer, int offset, int count)
	{
		return WriteAsync(buffer, offset, count, CancellationToken.None);
	}

	[ComVisible(false)]
	[__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (!cancellationToken.IsCancellationRequested)
		{
			return BeginEndWriteAsync(buffer, offset, count);
		}
		return Task.FromCancellation(cancellationToken);
	}

	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count)
	{
		return TaskFactory<VoidTaskResult>.FromAsyncTrim(this, new ReadWriteParameters
		{
			Buffer = buffer,
			Offset = offset,
			Count = count
		}, (Stream stream, ReadWriteParameters args, AsyncCallback callback, object state) => stream.BeginWrite(args.Buffer, args.Offset, args.Count, callback, state), delegate(Stream stream, IAsyncResult asyncResult)
		{
			stream.EndWrite(asyncResult);
			return default(VoidTaskResult);
		});
	}

	[__DynamicallyInvokable]
	public abstract long Seek(long offset, SeekOrigin origin);

	[__DynamicallyInvokable]
	public abstract void SetLength(long value);

	[__DynamicallyInvokable]
	public abstract int Read([In][Out] byte[] buffer, int offset, int count);

	[__DynamicallyInvokable]
	public virtual int ReadByte()
	{
		byte[] array = new byte[1];
		if (Read(array, 0, 1) == 0)
		{
			return -1;
		}
		return array[0];
	}

	[__DynamicallyInvokable]
	public abstract void Write(byte[] buffer, int offset, int count);

	[__DynamicallyInvokable]
	public virtual void WriteByte(byte value)
	{
		Write(new byte[1] { value }, 0, 1);
	}

	[HostProtection(SecurityAction.LinkDemand, Synchronization = true)]
	public static Stream Synchronized(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (stream is SyncStream)
		{
			return stream;
		}
		return new SyncStream(stream);
	}

	[Obsolete("Do not call or override this method.")]
	protected virtual void ObjectInvariant()
	{
	}

	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		SynchronousAsyncResult synchronousAsyncResult;
		try
		{
			int bytesRead = Read(buffer, offset, count);
			synchronousAsyncResult = new SynchronousAsyncResult(bytesRead, state);
		}
		catch (IOException ex)
		{
			synchronousAsyncResult = new SynchronousAsyncResult(ex, state, isWrite: false);
		}
		callback?.Invoke(synchronousAsyncResult);
		return synchronousAsyncResult;
	}

	internal static int BlockingEndRead(IAsyncResult asyncResult)
	{
		return SynchronousAsyncResult.EndRead(asyncResult);
	}

	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		SynchronousAsyncResult synchronousAsyncResult;
		try
		{
			Write(buffer, offset, count);
			synchronousAsyncResult = new SynchronousAsyncResult(state);
		}
		catch (IOException ex)
		{
			synchronousAsyncResult = new SynchronousAsyncResult(ex, state, isWrite: true);
		}
		callback?.Invoke(synchronousAsyncResult);
		return synchronousAsyncResult;
	}

	internal static void BlockingEndWrite(IAsyncResult asyncResult)
	{
		SynchronousAsyncResult.EndWrite(asyncResult);
	}

	[__DynamicallyInvokable]
	protected Stream()
	{
	}
}
