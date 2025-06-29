using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.IO.Compression;

[global::__DynamicallyInvokable]
public class DeflateStream : Stream
{
	internal delegate void AsyncWriteDelegate(byte[] array, int offset, int count, bool isAsync);

	private enum WorkerType : byte
	{
		Managed,
		ZLib,
		Unknown
	}

	internal const int DefaultBufferSize = 8192;

	private const int WindowSizeUpperBound = 47;

	private Stream _stream;

	private CompressionMode _mode;

	private bool _leaveOpen;

	private IInflater inflater;

	private IDeflater deflater;

	private byte[] buffer;

	private int asyncOperations;

	private readonly AsyncCallback m_CallBack;

	private readonly AsyncWriteDelegate m_AsyncWriterDelegate;

	private IFileFormatWriter formatWriter;

	private bool wroteHeader;

	private bool wroteBytes;

	private static volatile WorkerType deflaterType = WorkerType.Unknown;

	private static volatile WorkerType inflaterType = WorkerType.Unknown;

	[global::__DynamicallyInvokable]
	public Stream BaseStream
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _stream;
		}
	}

	[global::__DynamicallyInvokable]
	public override bool CanRead
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (_stream == null)
			{
				return false;
			}
			if (_mode == CompressionMode.Decompress)
			{
				return _stream.CanRead;
			}
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	public override bool CanWrite
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (_stream == null)
			{
				return false;
			}
			if (_mode == CompressionMode.Compress)
			{
				return _stream.CanWrite;
			}
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	public override bool CanSeek
	{
		[global::__DynamicallyInvokable]
		get
		{
			return false;
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
	public DeflateStream(Stream stream, CompressionMode mode)
		: this(stream, mode, leaveOpen: false)
	{
	}

	internal DeflateStream(Stream stream, bool leaveOpen, IFileFormatReader reader)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!stream.CanRead)
		{
			throw new ArgumentException(SR.GetString("NotReadableStream"), "stream");
		}
		inflater = CreateInflater(reader);
		m_CallBack = ReadCallback;
		_stream = stream;
		_mode = CompressionMode.Decompress;
		_leaveOpen = leaveOpen;
		buffer = new byte[8192];
	}

	[global::__DynamicallyInvokable]
	public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (CompressionMode.Compress != mode && mode != CompressionMode.Decompress)
		{
			throw new ArgumentException(SR.GetString("ArgumentOutOfRange_Enum"), "mode");
		}
		_stream = stream;
		_mode = mode;
		_leaveOpen = leaveOpen;
		switch (_mode)
		{
		case CompressionMode.Decompress:
			if (!_stream.CanRead)
			{
				throw new ArgumentException(SR.GetString("NotReadableStream"), "stream");
			}
			inflater = CreateInflater();
			m_CallBack = ReadCallback;
			break;
		case CompressionMode.Compress:
			if (!_stream.CanWrite)
			{
				throw new ArgumentException(SR.GetString("NotWriteableStream"), "stream");
			}
			deflater = CreateDeflater(null);
			m_AsyncWriterDelegate = InternalWrite;
			m_CallBack = WriteCallback;
			break;
		}
		buffer = new byte[8192];
	}

	[global::__DynamicallyInvokable]
	public DeflateStream(Stream stream, CompressionLevel compressionLevel)
		: this(stream, compressionLevel, leaveOpen: false)
	{
	}

	[global::__DynamicallyInvokable]
	public DeflateStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!stream.CanWrite)
		{
			throw new ArgumentException(SR.GetString("NotWriteableStream"), "stream");
		}
		_stream = stream;
		_mode = CompressionMode.Compress;
		_leaveOpen = leaveOpen;
		deflater = CreateDeflater(compressionLevel);
		m_AsyncWriterDelegate = InternalWrite;
		m_CallBack = WriteCallback;
		buffer = new byte[8192];
	}

	private static IDeflater CreateDeflater(CompressionLevel? compressionLevel)
	{
		switch (GetDeflaterType())
		{
		case WorkerType.Managed:
			return new DeflaterManaged();
		case WorkerType.ZLib:
			if (compressionLevel.HasValue)
			{
				return new DeflaterZLib(compressionLevel.Value);
			}
			return new DeflaterZLib();
		default:
			throw new SystemException("Program entered an unexpected state.");
		}
	}

	private static IInflater CreateInflater(IFileFormatReader reader = null)
	{
		switch (GetInflaterType())
		{
		case WorkerType.Managed:
			return new Inflater(reader);
		case WorkerType.ZLib:
			if (reader == null)
			{
				return new InflaterZlib(-15);
			}
			return new InflaterZlib(47);
		default:
			throw new SystemException("Program entered an unexpected state.");
		}
	}

	[SecuritySafeCritical]
	private static WorkerType GetDeflaterType()
	{
		if (WorkerType.Unknown != deflaterType)
		{
			return deflaterType;
		}
		if (CLRConfig.CheckLegacyManagedDeflateStream())
		{
			return deflaterType = WorkerType.Managed;
		}
		if (!CompatibilitySwitches.IsNetFx45LegacyManagedDeflateStream)
		{
			return deflaterType = WorkerType.ZLib;
		}
		return deflaterType = WorkerType.Managed;
	}

	[SecuritySafeCritical]
	private static WorkerType GetInflaterType()
	{
		if (WorkerType.Unknown != inflaterType)
		{
			return inflaterType;
		}
		if (!System.LocalAppContextSwitches.DoNotUseNativeZipLibraryForDecompression)
		{
			return inflaterType = WorkerType.ZLib;
		}
		return inflaterType = WorkerType.Managed;
	}

	internal void SetFileFormatWriter(IFileFormatWriter writer)
	{
		if (writer != null)
		{
			formatWriter = writer;
		}
	}

	[global::__DynamicallyInvokable]
	public override void Flush()
	{
		EnsureNotDisposed();
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
	public override int Read(byte[] array, int offset, int count)
	{
		EnsureDecompressionMode();
		ValidateParameters(array, offset, count);
		EnsureNotDisposed();
		int num = offset;
		int num2 = count;
		while (true)
		{
			int num3 = inflater.Inflate(array, num, num2);
			num += num3;
			num2 -= num3;
			if (num2 == 0 || inflater.Finished())
			{
				break;
			}
			int num4 = _stream.Read(buffer, 0, buffer.Length);
			if (num4 == 0)
			{
				break;
			}
			inflater.SetInput(buffer, 0, num4);
		}
		return count - num2;
	}

	private void ValidateParameters(byte[] array, int offset, int count)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (array.Length - offset < count)
		{
			throw new ArgumentException(SR.GetString("InvalidArgumentOffsetCount"));
		}
	}

	private void EnsureNotDisposed()
	{
		if (_stream == null)
		{
			throw new ObjectDisposedException(null, SR.GetString("ObjectDisposed_StreamClosed"));
		}
	}

	private void EnsureDecompressionMode()
	{
		if (_mode != CompressionMode.Decompress)
		{
			throw new InvalidOperationException(SR.GetString("CannotReadFromDeflateStream"));
		}
	}

	private void EnsureCompressionMode()
	{
		if (_mode != CompressionMode.Compress)
		{
			throw new InvalidOperationException(SR.GetString("CannotWriteToDeflateStream"));
		}
	}

	[global::__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		EnsureDecompressionMode();
		if (asyncOperations != 0)
		{
			throw new InvalidOperationException(SR.GetString("InvalidBeginCall"));
		}
		ValidateParameters(array, offset, count);
		EnsureNotDisposed();
		Interlocked.Increment(ref asyncOperations);
		try
		{
			DeflateStreamAsyncResult deflateStreamAsyncResult = new DeflateStreamAsyncResult(this, asyncState, asyncCallback, array, offset, count);
			deflateStreamAsyncResult.isWrite = false;
			int num = inflater.Inflate(array, offset, count);
			if (num != 0)
			{
				deflateStreamAsyncResult.InvokeCallback(completedSynchronously: true, num);
				return deflateStreamAsyncResult;
			}
			if (inflater.Finished())
			{
				deflateStreamAsyncResult.InvokeCallback(completedSynchronously: true, 0);
				return deflateStreamAsyncResult;
			}
			_stream.BeginRead(buffer, 0, buffer.Length, m_CallBack, deflateStreamAsyncResult);
			deflateStreamAsyncResult.m_CompletedSynchronously &= deflateStreamAsyncResult.IsCompleted;
			return deflateStreamAsyncResult;
		}
		catch
		{
			Interlocked.Decrement(ref asyncOperations);
			throw;
		}
	}

	private void ReadCallback(IAsyncResult baseStreamResult)
	{
		DeflateStreamAsyncResult deflateStreamAsyncResult = (DeflateStreamAsyncResult)baseStreamResult.AsyncState;
		deflateStreamAsyncResult.m_CompletedSynchronously &= baseStreamResult.CompletedSynchronously;
		int num = 0;
		try
		{
			EnsureNotDisposed();
			num = _stream.EndRead(baseStreamResult);
			if (num <= 0)
			{
				deflateStreamAsyncResult.InvokeCallback(0);
				return;
			}
			inflater.SetInput(buffer, 0, num);
			num = inflater.Inflate(deflateStreamAsyncResult.buffer, deflateStreamAsyncResult.offset, deflateStreamAsyncResult.count);
			if (num == 0 && !inflater.Finished())
			{
				_stream.BeginRead(buffer, 0, buffer.Length, m_CallBack, deflateStreamAsyncResult);
			}
			else
			{
				deflateStreamAsyncResult.InvokeCallback(num);
			}
		}
		catch (Exception result)
		{
			deflateStreamAsyncResult.InvokeCallback(result);
		}
	}

	[global::__DynamicallyInvokable]
	public override int EndRead(IAsyncResult asyncResult)
	{
		EnsureDecompressionMode();
		CheckEndXxxxLegalStateAndParams(asyncResult);
		DeflateStreamAsyncResult deflateStreamAsyncResult = (DeflateStreamAsyncResult)asyncResult;
		AwaitAsyncResultCompletion(deflateStreamAsyncResult);
		if (deflateStreamAsyncResult.Result is Exception ex)
		{
			throw ex;
		}
		return (int)deflateStreamAsyncResult.Result;
	}

	[global::__DynamicallyInvokable]
	public override void Write(byte[] array, int offset, int count)
	{
		EnsureCompressionMode();
		ValidateParameters(array, offset, count);
		EnsureNotDisposed();
		InternalWrite(array, offset, count, isAsync: false);
	}

	internal void InternalWrite(byte[] array, int offset, int count, bool isAsync)
	{
		DoMaintenance(array, offset, count);
		WriteDeflaterOutput(isAsync);
		deflater.SetInput(array, offset, count);
		WriteDeflaterOutput(isAsync);
	}

	private void WriteDeflaterOutput(bool isAsync)
	{
		while (!deflater.NeedsInput())
		{
			int deflateOutput = deflater.GetDeflateOutput(buffer);
			if (deflateOutput > 0)
			{
				DoWrite(buffer, 0, deflateOutput, isAsync);
			}
		}
	}

	private void DoWrite(byte[] array, int offset, int count, bool isAsync)
	{
		if (isAsync)
		{
			IAsyncResult asyncResult = _stream.BeginWrite(array, offset, count, null, null);
			_stream.EndWrite(asyncResult);
		}
		else
		{
			_stream.Write(array, offset, count);
		}
	}

	private void DoMaintenance(byte[] array, int offset, int count)
	{
		if (count <= 0)
		{
			return;
		}
		wroteBytes = true;
		if (formatWriter != null)
		{
			if (!wroteHeader)
			{
				byte[] header = formatWriter.GetHeader();
				_stream.Write(header, 0, header.Length);
				wroteHeader = true;
			}
			formatWriter.UpdateWithBytesRead(array, offset, count);
		}
	}

	private void PurgeBuffers(bool disposing)
	{
		if (!disposing || _stream == null)
		{
			return;
		}
		Flush();
		if (_mode != CompressionMode.Compress)
		{
			return;
		}
		if (wroteBytes)
		{
			WriteDeflaterOutput(isAsync: false);
			bool flag;
			do
			{
				flag = deflater.Finish(buffer, out var bytesRead);
				if (bytesRead > 0)
				{
					DoWrite(buffer, 0, bytesRead, isAsync: false);
				}
			}
			while (!flag);
		}
		if (formatWriter != null && wroteHeader)
		{
			byte[] footer = formatWriter.GetFooter();
			_stream.Write(footer, 0, footer.Length);
		}
	}

	[global::__DynamicallyInvokable]
	protected override void Dispose(bool disposing)
	{
		try
		{
			PurgeBuffers(disposing);
		}
		finally
		{
			try
			{
				if (disposing && !_leaveOpen && _stream != null)
				{
					_stream.Close();
				}
			}
			finally
			{
				_stream = null;
				try
				{
					if (deflater != null)
					{
						deflater.Dispose();
					}
					if (inflater != null)
					{
						inflater.Dispose();
					}
				}
				finally
				{
					inflater = null;
					deflater = null;
					base.Dispose(disposing);
				}
			}
		}
	}

	[global::__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
	{
		EnsureCompressionMode();
		if (asyncOperations != 0)
		{
			throw new InvalidOperationException(SR.GetString("InvalidBeginCall"));
		}
		ValidateParameters(array, offset, count);
		EnsureNotDisposed();
		Interlocked.Increment(ref asyncOperations);
		try
		{
			DeflateStreamAsyncResult deflateStreamAsyncResult = new DeflateStreamAsyncResult(this, asyncState, asyncCallback, array, offset, count);
			deflateStreamAsyncResult.isWrite = true;
			m_AsyncWriterDelegate.BeginInvoke(array, offset, count, isAsync: true, m_CallBack, deflateStreamAsyncResult);
			deflateStreamAsyncResult.m_CompletedSynchronously &= deflateStreamAsyncResult.IsCompleted;
			return deflateStreamAsyncResult;
		}
		catch
		{
			Interlocked.Decrement(ref asyncOperations);
			throw;
		}
	}

	private void WriteCallback(IAsyncResult asyncResult)
	{
		DeflateStreamAsyncResult deflateStreamAsyncResult = (DeflateStreamAsyncResult)asyncResult.AsyncState;
		deflateStreamAsyncResult.m_CompletedSynchronously &= asyncResult.CompletedSynchronously;
		try
		{
			m_AsyncWriterDelegate.EndInvoke(asyncResult);
		}
		catch (Exception result)
		{
			deflateStreamAsyncResult.InvokeCallback(result);
			return;
		}
		deflateStreamAsyncResult.InvokeCallback(null);
	}

	[global::__DynamicallyInvokable]
	public override void EndWrite(IAsyncResult asyncResult)
	{
		EnsureCompressionMode();
		CheckEndXxxxLegalStateAndParams(asyncResult);
		DeflateStreamAsyncResult deflateStreamAsyncResult = (DeflateStreamAsyncResult)asyncResult;
		AwaitAsyncResultCompletion(deflateStreamAsyncResult);
		if (deflateStreamAsyncResult.Result is Exception ex)
		{
			throw ex;
		}
	}

	private void CheckEndXxxxLegalStateAndParams(IAsyncResult asyncResult)
	{
		if (asyncOperations != 1)
		{
			throw new InvalidOperationException(SR.GetString("InvalidEndCall"));
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		EnsureNotDisposed();
		DeflateStreamAsyncResult deflateStreamAsyncResult = asyncResult as DeflateStreamAsyncResult;
		if (deflateStreamAsyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
	}

	private void AwaitAsyncResultCompletion(DeflateStreamAsyncResult asyncResult)
	{
		try
		{
			if (!asyncResult.IsCompleted)
			{
				asyncResult.AsyncWaitHandle.WaitOne();
			}
		}
		finally
		{
			Interlocked.Decrement(ref asyncOperations);
			asyncResult.Close();
		}
	}
}
