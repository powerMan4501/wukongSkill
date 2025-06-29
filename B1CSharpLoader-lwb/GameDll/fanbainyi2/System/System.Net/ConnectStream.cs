using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

internal class ConnectStream : Stream, ICloseEx, IRequestLifetimeTracker
{
	private static class Nesting
	{
		public const int Idle = 0;

		public const int IoInProgress = 1;

		public const int Closed = 2;

		public const int InError = 3;

		public const int InternalIO = 4;
	}

	private const int ApplyTransportSetting = -1744830445;

	private const int QueryTransportSetting = -1744830444;

	private int m_CallNesting;

	private ScatterGatherBuffers m_BufferedData;

	private bool m_SuppressWrite;

	private bool m_BufferOnly;

	private long m_BytesLeftToWrite;

	private int m_BytesAlreadyTransferred;

	private Connection m_Connection;

	private byte[] m_ReadBuffer;

	private int m_ReadOffset;

	private int m_ReadBufferSize;

	private long m_ReadBytes;

	private bool m_Chunked;

	private int m_DoneCalled;

	private int m_ShutDown;

	private Exception m_ErrorException;

	private bool m_ChunkEofRecvd;

	private ChunkParser m_ChunkParser;

	private HttpWriteMode m_HttpWriteMode;

	private int m_ReadTimeout;

	private int m_WriteTimeout;

	private RequestLifetimeSetter m_RequestLifetimeSetter;

	private const long c_MaxDrainBytes = 65536L;

	private readonly AsyncCallback m_ReadCallbackDelegate;

	private readonly AsyncCallback m_WriteCallbackDelegate;

	private static readonly AsyncCallback m_WriteHeadersCallback = WriteHeadersCallback;

	private static readonly object ZeroLengthRead = new object();

	private HttpWebRequest m_Request;

	private static volatile int responseDrainTimeoutMilliseconds = -1;

	private const int defaultResponseDrainTimeoutMilliseconds = 500;

	private const string responseDrainTimeoutAppSetting = "responseDrainTimeout";

	private bool m_IgnoreSocketErrors;

	private bool m_ErrorResponseStatus;

	private const int AlreadyAborted = 777777;

	internal static byte[] s_DrainingBuffer = new byte[4096];

	public override bool CanTimeout => true;

	public override int ReadTimeout
	{
		get
		{
			return m_ReadTimeout;
		}
		set
		{
			if (value <= 0 && value != -1)
			{
				throw new ArgumentOutOfRangeException("value", SR.GetString("net_io_timeout_use_gt_zero"));
			}
			m_ReadTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return m_WriteTimeout;
		}
		set
		{
			if (value <= 0 && value != -1)
			{
				throw new ArgumentOutOfRangeException("value", SR.GetString("net_io_timeout_use_gt_zero"));
			}
			m_WriteTimeout = value;
		}
	}

	internal bool FinishedAfterWrite { get; set; }

	internal bool IgnoreSocketErrors => m_IgnoreSocketErrors;

	internal bool SuppressWrite
	{
		set
		{
			m_SuppressWrite = value;
		}
	}

	internal Connection Connection => m_Connection;

	internal bool BufferOnly => m_BufferOnly;

	internal ScatterGatherBuffers BufferedData
	{
		get
		{
			return m_BufferedData;
		}
		set
		{
			m_BufferedData = value;
		}
	}

	private bool WriteChunked => m_HttpWriteMode == HttpWriteMode.Chunked;

	internal long BytesLeftToWrite
	{
		get
		{
			return m_BytesLeftToWrite;
		}
		set
		{
			m_BytesLeftToWrite = value;
		}
	}

	private bool WriteStream => m_HttpWriteMode != HttpWriteMode.Unknown;

	internal bool IsPostStream => m_HttpWriteMode != HttpWriteMode.None;

	internal bool ErrorInStream => m_ErrorException != null;

	internal bool IsClosed => m_ShutDown != 0;

	public override bool CanRead
	{
		get
		{
			if (!WriteStream)
			{
				return !IsClosed;
			}
			return false;
		}
	}

	public override bool CanSeek => false;

	public override bool CanWrite
	{
		get
		{
			if (WriteStream)
			{
				return !IsClosed;
			}
			return false;
		}
	}

	public override long Length
	{
		get
		{
			throw new NotSupportedException(SR.GetString("net_noseek"));
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException(SR.GetString("net_noseek"));
		}
		set
		{
			throw new NotSupportedException(SR.GetString("net_noseek"));
		}
	}

	internal bool Eof
	{
		get
		{
			if (ErrorInStream)
			{
				return true;
			}
			if (m_Chunked)
			{
				return m_ChunkEofRecvd;
			}
			if (m_ReadBytes == 0L)
			{
				return true;
			}
			if (m_ReadBytes == -1)
			{
				if (m_DoneCalled > 0)
				{
					return m_ReadBufferSize <= 0;
				}
				return false;
			}
			return false;
		}
	}

	private Socket InternalSocket
	{
		get
		{
			Connection connection = m_Connection;
			if (connection != null)
			{
				NetworkStream networkStream = connection.NetworkStream;
				if (networkStream != null)
				{
					return networkStream.InternalSocket;
				}
			}
			return null;
		}
	}

	internal void ErrorResponseNotify(bool isKeepAlive)
	{
		m_ErrorResponseStatus = true;
		m_IgnoreSocketErrors |= !isKeepAlive;
	}

	internal void FatalResponseNotify()
	{
		if (m_ErrorException == null)
		{
			Interlocked.CompareExchange(ref m_ErrorException, new IOException(SR.GetString("net_io_readfailure", SR.GetString("net_io_connectionclosed"))), null);
		}
		m_ErrorResponseStatus = false;
	}

	public ConnectStream(Connection connection, HttpWebRequest request)
	{
		m_Connection = connection;
		m_ReadTimeout = (m_WriteTimeout = -1);
		m_Request = request;
		m_HttpWriteMode = request.HttpWriteMode;
		m_BytesLeftToWrite = ((m_HttpWriteMode == HttpWriteMode.ContentLength) ? request.ContentLength : (-1));
		if (request.HttpWriteMode == HttpWriteMode.Buffer)
		{
			m_BufferOnly = true;
			EnableWriteBuffering();
		}
		m_ReadCallbackDelegate = ReadCallback;
		m_WriteCallbackDelegate = WriteCallback;
	}

	public ConnectStream(Connection connection, byte[] buffer, int offset, int bufferCount, long readCount, bool chunked, HttpWebRequest request)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, "ConnectStream", SR.GetString("net_log_buffered_n_bytes", readCount));
		}
		m_ReadBytes = readCount;
		m_ReadTimeout = (m_WriteTimeout = -1);
		m_Chunked = chunked;
		m_Connection = connection;
		if (m_Chunked)
		{
			m_ChunkParser = new ChunkParser(m_Connection, buffer, offset, bufferCount, request.MaximumResponseHeadersLength * 1024);
		}
		else
		{
			m_ReadBuffer = buffer;
			m_ReadOffset = offset;
			m_ReadBufferSize = bufferCount;
		}
		m_Request = request;
		m_ReadCallbackDelegate = ReadCallback;
		m_WriteCallbackDelegate = WriteCallback;
	}

	internal void SwitchToContentLength()
	{
		m_HttpWriteMode = HttpWriteMode.ContentLength;
	}

	internal void CallDone()
	{
		CallDone(null);
	}

	private void CallDone(ConnectionReturnResult returnResult)
	{
		if (Interlocked.Increment(ref m_DoneCalled) != 1)
		{
			return;
		}
		if (!WriteStream)
		{
			if (returnResult == null)
			{
				if (m_Chunked && m_ChunkParser.TryGetLeftoverBytes(out var buffer, out var leftoverBufferOffset, out var leftoverBufferSize))
				{
					m_Connection.SetLeftoverBytes(buffer, leftoverBufferOffset, leftoverBufferSize);
				}
				m_Connection.ReadStartNextRequest(m_Request, ref returnResult);
			}
			else
			{
				ConnectionReturnResult.SetResponses(returnResult);
			}
		}
		else
		{
			m_Request.WriteCallDone(this, returnResult);
		}
	}

	internal void ProcessWriteCallDone(ConnectionReturnResult returnResult)
	{
		try
		{
			if (returnResult == null)
			{
				m_Connection.WriteStartNextRequest(m_Request, ref returnResult);
				if (!m_Request.Async)
				{
					object obj = m_Request.ConnectionReaderAsyncResult.InternalWaitForCompletion();
					if (obj == null && m_Request.NeedsToReadForResponse)
					{
						m_Connection.SyncRead(m_Request, userRetrievedStream: true, probeRead: false);
					}
				}
				m_Request.NeedsToReadForResponse = true;
			}
			ConnectionReturnResult.SetResponses(returnResult);
		}
		finally
		{
			if (IsPostStream || m_Request.Async)
			{
				m_Request.CheckWriteSideResponseProcessing();
			}
		}
	}

	internal void ResubmitWrite(ConnectStream oldStream, bool suppressWrite)
	{
		try
		{
			Interlocked.CompareExchange(ref m_CallNesting, 4, 0);
			ScatterGatherBuffers bufferedData = oldStream.BufferedData;
			SafeSetSocketTimeout(SocketShutdown.Send);
			if (!WriteChunked)
			{
				if (!suppressWrite)
				{
					m_Connection.Write(bufferedData);
				}
			}
			else
			{
				m_HttpWriteMode = HttpWriteMode.ContentLength;
				if (bufferedData.Length == 0)
				{
					m_Connection.Write(NclConstants.ChunkTerminator, 0, NclConstants.ChunkTerminator.Length);
				}
				else
				{
					int offset = 0;
					byte[] chunkHeader = GetChunkHeader(bufferedData.Length, out offset);
					BufferOffsetSize[] buffers = bufferedData.GetBuffers();
					BufferOffsetSize[] array = new BufferOffsetSize[buffers.Length + 3];
					array[0] = new BufferOffsetSize(chunkHeader, offset, chunkHeader.Length - offset, copyBuffer: false);
					int num = 0;
					BufferOffsetSize[] array2 = buffers;
					foreach (BufferOffsetSize bufferOffsetSize in array2)
					{
						array[++num] = bufferOffsetSize;
					}
					array[++num] = new BufferOffsetSize(NclConstants.CRLF, 0, NclConstants.CRLF.Length, copyBuffer: false);
					array[++num] = new BufferOffsetSize(NclConstants.ChunkTerminator, 0, NclConstants.ChunkTerminator.Length, copyBuffer: false);
					SplitWritesState splitWritesState = new SplitWritesState(array);
					for (BufferOffsetSize[] nextBuffers = splitWritesState.GetNextBuffers(); nextBuffers != null; nextBuffers = splitWritesState.GetNextBuffers())
					{
						m_Connection.MultipleWrite(nextBuffers);
					}
				}
			}
			if (Logging.On && bufferedData.GetBuffers() != null)
			{
				BufferOffsetSize[] buffers2 = bufferedData.GetBuffers();
				foreach (BufferOffsetSize bufferOffsetSize2 in buffers2)
				{
					if (bufferOffsetSize2 == null)
					{
						Logging.Dump(Logging.Web, this, "ResubmitWrite", null, 0, 0);
					}
					else
					{
						Logging.Dump(Logging.Web, this, "ResubmitWrite", bufferOffsetSize2.Buffer, bufferOffsetSize2.Offset, bufferOffsetSize2.Size);
					}
				}
			}
		}
		catch (Exception ex)
		{
			if (NclUtilities.IsFatal(ex))
			{
				throw;
			}
			WebException exception = new WebException(NetRes.GetWebStatusString("net_connclosed", WebExceptionStatus.SendFailure), WebExceptionStatus.SendFailure, WebExceptionInternalStatus.RequestFatal, ex);
			IOError(exception, willThrow: false);
		}
		finally
		{
			Interlocked.CompareExchange(ref m_CallNesting, 0, 4);
		}
		m_BytesLeftToWrite = 0L;
		CallDone();
	}

	internal void EnableWriteBuffering()
	{
		if (BufferedData == null)
		{
			if (WriteChunked)
			{
				BufferedData = new ScatterGatherBuffers();
			}
			else
			{
				BufferedData = new ScatterGatherBuffers(BytesLeftToWrite);
			}
		}
	}

	internal int FillFromBufferedData(byte[] buffer, ref int offset, ref int size)
	{
		if (m_ReadBufferSize == 0)
		{
			return 0;
		}
		int num = Math.Min(size, m_ReadBufferSize);
		Buffer.BlockCopy(m_ReadBuffer, m_ReadOffset, buffer, offset, num);
		m_ReadOffset += num;
		m_ReadBufferSize -= num;
		if (m_ReadBufferSize == 0)
		{
			m_ReadBuffer = null;
		}
		size -= num;
		offset += num;
		return num;
	}

	public override void Write(byte[] buffer, int offset, int size)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "Write", "");
		}
		if (!WriteStream)
		{
			throw new NotSupportedException(SR.GetString("net_readonlystream"));
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		if (Logging.On)
		{
			Logging.Dump(Logging.Web, this, "Write", buffer, offset, size);
		}
		InternalWrite(async: false, buffer, offset, size, null, null);
		if (Logging.On)
		{
			Logging.Exit(Logging.Web, this, "Write", "");
		}
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "BeginWrite", "");
		}
		if (!WriteStream)
		{
			throw new NotSupportedException(SR.GetString("net_readonlystream"));
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		if (Logging.On)
		{
			Logging.Dump(Logging.Web, this, "BeginWrite", buffer, offset, size);
		}
		IAsyncResult asyncResult = InternalWrite(async: true, buffer, offset, size, callback, state);
		if (Logging.On)
		{
			Logging.Exit(Logging.Web, this, "BeginWrite", asyncResult);
		}
		return asyncResult;
	}

	private IAsyncResult InternalWrite(bool async, byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		if (ErrorInStream)
		{
			throw m_ErrorException;
		}
		if (IsClosed && !IgnoreSocketErrors)
		{
			throw new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.ConnectionClosed), WebExceptionStatus.ConnectionClosed);
		}
		if (m_Request.Aborted && !IgnoreSocketErrors)
		{
			throw new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
		}
		int num = Interlocked.CompareExchange(ref m_CallNesting, 1, 0);
		if (num != 0 && num != 2)
		{
			throw new NotSupportedException(SR.GetString("net_no_concurrent_io_allowed"));
		}
		if (BufferedData != null && size != 0 && (m_Request.ContentLength != 0L || !IsPostStream || !m_Request.NtlmKeepAlive))
		{
			BufferedData.Write(buffer, offset, size);
		}
		LazyAsyncResult lazyAsyncResult = null;
		bool flag = false;
		try
		{
			if (size == 0 || BufferOnly || m_SuppressWrite || IgnoreSocketErrors)
			{
				if (m_SuppressWrite && m_BytesLeftToWrite > 0 && size > 0)
				{
					m_BytesLeftToWrite -= size;
				}
				if (async)
				{
					lazyAsyncResult = new LazyAsyncResult(this, state, callback);
					flag = true;
				}
				return lazyAsyncResult;
			}
			if (WriteChunked)
			{
				int offset2 = 0;
				byte[] chunkHeader = GetChunkHeader(size, out offset2);
				BufferOffsetSize[] buffers;
				if (!m_ErrorResponseStatus)
				{
					buffers = new BufferOffsetSize[3]
					{
						new BufferOffsetSize(chunkHeader, offset2, chunkHeader.Length - offset2, copyBuffer: false),
						new BufferOffsetSize(buffer, offset, size, copyBuffer: false),
						new BufferOffsetSize(NclConstants.CRLF, 0, NclConstants.CRLF.Length, copyBuffer: false)
					};
				}
				else
				{
					m_IgnoreSocketErrors = true;
					buffers = new BufferOffsetSize[1]
					{
						new BufferOffsetSize(NclConstants.ChunkTerminator, 0, NclConstants.ChunkTerminator.Length, copyBuffer: false)
					};
				}
				lazyAsyncResult = (async ? new NestedMultipleAsyncResult(this, state, callback, buffers) : null);
				try
				{
					if (async)
					{
						m_Connection.BeginMultipleWrite(buffers, m_WriteCallbackDelegate, lazyAsyncResult);
					}
					else
					{
						SafeSetSocketTimeout(SocketShutdown.Send);
						m_Connection.MultipleWrite(buffers);
					}
				}
				catch (Exception ex)
				{
					if (IgnoreSocketErrors && !NclUtilities.IsFatal(ex))
					{
						if (async)
						{
							flag = true;
						}
						return lazyAsyncResult;
					}
					if (m_Request.Aborted && (ex is IOException || ex is ObjectDisposedException))
					{
						throw new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
					}
					num = 3;
					if (NclUtilities.IsFatal(ex))
					{
						m_ErrorResponseStatus = false;
						IOError(ex);
						throw;
					}
					if (!m_ErrorResponseStatus)
					{
						IOError(ex);
						throw;
					}
					m_IgnoreSocketErrors = true;
					if (async)
					{
						flag = true;
					}
				}
				return lazyAsyncResult;
			}
			lazyAsyncResult = (async ? new NestedSingleAsyncResult(this, state, callback, buffer, offset, size) : null);
			if (BytesLeftToWrite != -1)
			{
				if (BytesLeftToWrite < size)
				{
					throw new ProtocolViolationException(SR.GetString("net_entitytoobig"));
				}
				if (!async)
				{
					m_BytesLeftToWrite -= size;
				}
			}
			try
			{
				if (async)
				{
					if (m_Request.ContentLength == 0L && IsPostStream)
					{
						m_BytesLeftToWrite -= size;
						flag = true;
					}
					else
					{
						m_BytesAlreadyTransferred = size;
						m_Connection.BeginWrite(buffer, offset, size, m_WriteCallbackDelegate, lazyAsyncResult);
					}
				}
				else
				{
					SafeSetSocketTimeout(SocketShutdown.Send);
					if (m_Request.ContentLength != 0L || !IsPostStream || !m_Request.NtlmKeepAlive)
					{
						m_Connection.Write(buffer, offset, size);
					}
				}
			}
			catch (Exception ex2)
			{
				if (IgnoreSocketErrors && !NclUtilities.IsFatal(ex2))
				{
					if (async)
					{
						flag = true;
					}
					return lazyAsyncResult;
				}
				if (m_Request.Aborted && (ex2 is IOException || ex2 is ObjectDisposedException))
				{
					throw new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
				}
				num = 3;
				if (NclUtilities.IsFatal(ex2))
				{
					m_ErrorResponseStatus = false;
					IOError(ex2);
					throw;
				}
				if (!m_ErrorResponseStatus)
				{
					IOError(ex2);
					throw;
				}
				m_IgnoreSocketErrors = true;
				if (async)
				{
					flag = true;
				}
			}
			return lazyAsyncResult;
		}
		finally
		{
			if (!async || num == 3 || flag)
			{
				num = Interlocked.CompareExchange(ref m_CallNesting, (num == 3) ? 3 : 0, 1);
				if (num == 2)
				{
					ResumeInternalClose(lazyAsyncResult);
				}
				else if (flag)
				{
					lazyAsyncResult?.InvokeCallback();
				}
			}
		}
	}

	private void WriteCallback(IAsyncResult asyncResult)
	{
		LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)asyncResult.AsyncState;
		((ConnectStream)lazyAsyncResult.AsyncObject).ProcessWriteCallback(asyncResult, lazyAsyncResult);
	}

	private void ProcessWriteCallback(IAsyncResult asyncResult, LazyAsyncResult userResult)
	{
		Exception ex = null;
		try
		{
			if (userResult is NestedSingleAsyncResult)
			{
				try
				{
					m_Connection.EndWrite(asyncResult);
					if (BytesLeftToWrite != -1)
					{
						m_BytesLeftToWrite -= m_BytesAlreadyTransferred;
						m_BytesAlreadyTransferred = 0;
					}
					return;
				}
				catch (Exception ex2)
				{
					ex = ex2;
					if (NclUtilities.IsFatal(ex2))
					{
						m_ErrorResponseStatus = false;
						IOError(ex2);
						throw;
					}
					if (m_ErrorResponseStatus)
					{
						m_IgnoreSocketErrors = true;
						ex = null;
					}
					return;
				}
			}
			NestedMultipleAsyncResult nestedMultipleAsyncResult = (NestedMultipleAsyncResult)userResult;
			try
			{
				m_Connection.EndMultipleWrite(asyncResult);
			}
			catch (Exception ex3)
			{
				ex = ex3;
				if (NclUtilities.IsFatal(ex3))
				{
					m_ErrorResponseStatus = false;
					IOError(ex3);
					throw;
				}
				if (m_ErrorResponseStatus)
				{
					m_IgnoreSocketErrors = true;
					ex = null;
				}
			}
		}
		finally
		{
			if (2 == ExchangeCallNesting((ex != null) ? 3 : 0, 1))
			{
				if (ex != null && m_ErrorException == null)
				{
					Interlocked.CompareExchange(ref m_ErrorException, ex, null);
				}
				ResumeInternalClose(userResult);
			}
			else
			{
				userResult.InvokeCallback(ex);
			}
		}
	}

	private int ExchangeCallNesting(int value, int comparand)
	{
		return Interlocked.CompareExchange(ref m_CallNesting, value, comparand);
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "EndWrite", "");
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (!(asyncResult is LazyAsyncResult lazyAsyncResult) || lazyAsyncResult.AsyncObject != this)
		{
			throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
		}
		if (lazyAsyncResult.EndCalled)
		{
			throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndWrite"));
		}
		lazyAsyncResult.EndCalled = true;
		object obj = lazyAsyncResult.InternalWaitForCompletion();
		if (ErrorInStream)
		{
			throw m_ErrorException;
		}
		if (obj is Exception ex)
		{
			if (ex is IOException && m_Request.Aborted)
			{
				throw new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
			}
			IOError(ex);
			throw ex;
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.Web, this, "EndWrite", "");
		}
	}

	public override int Read([In][Out] byte[] buffer, int offset, int size)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "Read", "");
		}
		if (WriteStream)
		{
			throw new NotSupportedException(SR.GetString("net_writeonlystream"));
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		if (ErrorInStream)
		{
			throw m_ErrorException;
		}
		if (IsClosed)
		{
			throw new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.ConnectionClosed), WebExceptionStatus.ConnectionClosed);
		}
		if (m_Request.Aborted)
		{
			throw new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
		}
		if (Interlocked.CompareExchange(ref m_CallNesting, 1, 0) != 0)
		{
			throw new NotSupportedException(SR.GetString("net_no_concurrent_io_allowed"));
		}
		int num = -1;
		try
		{
			SafeSetSocketTimeout(SocketShutdown.Receive);
		}
		catch (Exception exception)
		{
			IOError(exception);
			throw;
		}
		try
		{
			num = ReadWithoutValidation(buffer, offset, size);
		}
		catch (Exception ex)
		{
			if (ex.InnerException is Win32Exception { NativeErrorCode: 10060 })
			{
				ex = new WebException(SR.GetString("net_timeout"), WebExceptionStatus.Timeout);
			}
			throw ex;
		}
		Interlocked.CompareExchange(ref m_CallNesting, 0, 1);
		if (Logging.On && num > 0)
		{
			Logging.Dump(Logging.Web, this, "Read", buffer, offset, num);
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.Web, this, "Read", num);
		}
		return num;
	}

	private int ReadWithoutValidation(byte[] buffer, int offset, int size)
	{
		return ReadWithoutValidation(buffer, offset, size, abortOnError: true);
	}

	private int ReadWithoutValidation([In][Out] byte[] buffer, int offset, int size, bool abortOnError)
	{
		int num = 0;
		if (!m_Chunked)
		{
			num = (int)((m_ReadBytes == -1) ? size : Math.Min(m_ReadBytes, size));
		}
		else if (!m_ChunkEofRecvd)
		{
			try
			{
				num = m_ChunkParser.Read(buffer, offset, size);
				if (num == 0)
				{
					m_ChunkEofRecvd = true;
					CallDone();
				}
			}
			catch (Exception exception)
			{
				if (abortOnError)
				{
					IOError(exception);
				}
				throw;
			}
			return num;
		}
		if (num == 0 || Eof)
		{
			return 0;
		}
		try
		{
			num = InternalRead(buffer, offset, num);
		}
		catch (Exception exception2)
		{
			if (abortOnError)
			{
				IOError(exception2);
			}
			throw;
		}
		int num2 = num;
		bool flag = false;
		if (num2 <= 0)
		{
			num2 = 0;
			if (m_ReadBytes != -1)
			{
				if (!abortOnError)
				{
					throw m_ErrorException;
				}
				IOError(null, willThrow: false);
			}
			else
			{
				flag = true;
			}
		}
		if (m_ReadBytes != -1)
		{
			m_ReadBytes -= num2;
			if (m_ReadBytes < 0)
			{
				throw new InternalException();
			}
		}
		if (m_ReadBytes == 0 || flag)
		{
			m_ReadBytes = 0L;
			CallDone();
		}
		return num2;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "BeginRead", "");
		}
		if (WriteStream)
		{
			throw new NotSupportedException(SR.GetString("net_writeonlystream"));
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (size < 0 || size > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		if (ErrorInStream)
		{
			throw m_ErrorException;
		}
		if (IsClosed)
		{
			throw new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.ConnectionClosed), WebExceptionStatus.ConnectionClosed);
		}
		if (m_Request.Aborted)
		{
			throw new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
		}
		if (Interlocked.CompareExchange(ref m_CallNesting, 1, 0) != 0)
		{
			throw new NotSupportedException(SR.GetString("net_no_concurrent_io_allowed"));
		}
		IAsyncResult asyncResult = BeginReadWithoutValidation(buffer, offset, size, callback, state);
		if (Logging.On)
		{
			Logging.Exit(Logging.Web, this, "BeginRead", asyncResult);
		}
		return asyncResult;
	}

	private IAsyncResult BeginReadWithoutValidation(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
	{
		int size2 = 0;
		if (!m_Chunked)
		{
			size2 = (int)((m_ReadBytes == -1) ? size : Math.Min(m_ReadBytes, size));
		}
		else if (!m_ChunkEofRecvd)
		{
			return m_ChunkParser.ReadAsync(this, buffer, offset, size, callback, state);
		}
		if (size2 == 0 || Eof)
		{
			return new NestedSingleAsyncResult(this, state, callback, ZeroLengthRead);
		}
		try
		{
			int num = 0;
			if (m_ReadBufferSize > 0)
			{
				num = FillFromBufferedData(buffer, ref offset, ref size2);
				if (size2 == 0)
				{
					return new NestedSingleAsyncResult(this, state, callback, num);
				}
			}
			if (ErrorInStream)
			{
				throw m_ErrorException;
			}
			m_BytesAlreadyTransferred = num;
			IAsyncResult asyncResult = m_Connection.BeginRead(buffer, offset, size2, callback, state);
			if (asyncResult == null)
			{
				m_BytesAlreadyTransferred = 0;
				m_ErrorException = new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
				throw m_ErrorException;
			}
			return asyncResult;
		}
		catch (Exception exception)
		{
			IOError(exception);
			throw;
		}
	}

	private int InternalRead(byte[] buffer, int offset, int size)
	{
		int num = FillFromBufferedData(buffer, ref offset, ref size);
		if (num > 0)
		{
			return num;
		}
		if (ErrorInStream)
		{
			throw m_ErrorException;
		}
		return m_Connection.Read(buffer, offset, size);
	}

	private void ReadCallback(IAsyncResult asyncResult)
	{
		NestedSingleAsyncResult nestedSingleAsyncResult = (NestedSingleAsyncResult)asyncResult.AsyncState;
		ConnectStream connectStream = (ConnectStream)nestedSingleAsyncResult.AsyncObject;
		object obj = null;
		try
		{
			int num = connectStream.m_Connection.EndRead(asyncResult);
			if (Logging.On)
			{
				Logging.Dump(Logging.Web, connectStream, "ReadCallback", nestedSingleAsyncResult.Buffer, nestedSingleAsyncResult.Offset, Math.Min(nestedSingleAsyncResult.Size, num));
			}
			obj = num;
		}
		catch (Exception ex)
		{
			obj = ex;
		}
		nestedSingleAsyncResult.InvokeCallback(obj);
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "EndRead", "");
		}
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		bool zeroLengthRead = false;
		int num;
		if (asyncResult.GetType() == typeof(NestedSingleAsyncResult) || m_Chunked)
		{
			LazyAsyncResult lazyAsyncResult = (LazyAsyncResult)asyncResult;
			if (lazyAsyncResult.AsyncObject != this)
			{
				throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
			}
			if (lazyAsyncResult.EndCalled)
			{
				throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndRead"));
			}
			lazyAsyncResult.EndCalled = true;
			if (ErrorInStream)
			{
				throw m_ErrorException;
			}
			object obj = lazyAsyncResult.InternalWaitForCompletion();
			if (obj is Exception exception)
			{
				IOError(exception, willThrow: false);
				num = -1;
			}
			else if (obj == null)
			{
				num = 0;
			}
			else if (obj == ZeroLengthRead)
			{
				num = 0;
				zeroLengthRead = true;
			}
			else
			{
				try
				{
					num = (int)obj;
					if (m_Chunked && num == 0)
					{
						m_ChunkEofRecvd = true;
						CallDone();
					}
				}
				catch (InvalidCastException)
				{
					num = -1;
				}
			}
		}
		else
		{
			try
			{
				num = m_Connection.EndRead(asyncResult);
			}
			catch (Exception exception2)
			{
				if (NclUtilities.IsFatal(exception2))
				{
					throw;
				}
				IOError(exception2, willThrow: false);
				num = -1;
			}
		}
		num = EndReadWithoutValidation(num, zeroLengthRead);
		Interlocked.CompareExchange(ref m_CallNesting, 0, 1);
		if (Logging.On)
		{
			Logging.Exit(Logging.Web, this, "EndRead", num);
		}
		if (m_ErrorException != null)
		{
			throw m_ErrorException;
		}
		return num;
	}

	private int EndReadWithoutValidation(int bytesTransferred, bool zeroLengthRead)
	{
		int bytesAlreadyTransferred = m_BytesAlreadyTransferred;
		m_BytesAlreadyTransferred = 0;
		if (!m_Chunked)
		{
			bool flag = false;
			if (bytesTransferred <= 0)
			{
				if (m_ReadBytes != -1 && (bytesTransferred < 0 || !zeroLengthRead))
				{
					IOError(null, willThrow: false);
				}
				else
				{
					flag = true;
					bytesTransferred = 0;
				}
			}
			bytesTransferred += bytesAlreadyTransferred;
			if (m_ReadBytes != -1)
			{
				m_ReadBytes -= bytesTransferred;
			}
			if (m_ReadBytes == 0 || flag)
			{
				m_ReadBytes = 0L;
				CallDone();
			}
		}
		return bytesTransferred;
	}

	private static void WriteHeadersCallback(IAsyncResult ar)
	{
		if (ar.CompletedSynchronously)
		{
			return;
		}
		WriteHeadersCallbackState writeHeadersCallbackState = (WriteHeadersCallbackState)ar.AsyncState;
		ConnectStream stream = writeHeadersCallbackState.stream;
		HttpWebRequest request = writeHeadersCallbackState.request;
		WebExceptionStatus webExceptionStatus = WebExceptionStatus.SendFailure;
		try
		{
			try
			{
				stream.m_Connection.EndWrite(ar);
			}
			finally
			{
				request.FreeWriteBuffer();
			}
			if (stream.m_Connection.m_InnerException != null)
			{
				throw stream.m_Connection.m_InnerException;
			}
			webExceptionStatus = WebExceptionStatus.Success;
		}
		catch (Exception e)
		{
			stream.HandleWriteHeadersException(e, webExceptionStatus);
		}
		stream.ExchangeCallNesting(0, 4);
		if (webExceptionStatus == WebExceptionStatus.Success && !stream.ErrorInStream)
		{
			webExceptionStatus = WebExceptionStatus.ReceiveFailure;
			try
			{
				request.StartAsync100ContinueTimer();
				stream.m_Connection.CheckStartReceive(request);
				if (stream.m_Connection.m_InnerException != null)
				{
					throw stream.m_Connection.m_InnerException;
				}
				webExceptionStatus = WebExceptionStatus.Success;
			}
			catch (Exception e2)
			{
				stream.HandleWriteHeadersException(e2, webExceptionStatus);
			}
		}
		request.WriteHeadersCallback(webExceptionStatus, stream, async: true);
	}

	internal void WriteHeaders(bool async)
	{
		WebExceptionStatus webExceptionStatus = WebExceptionStatus.SendFailure;
		if (!ErrorInStream)
		{
			byte[] writeBuffer = m_Request.WriteBuffer;
			int writeBufferLength = m_Request.WriteBufferLength;
			try
			{
				Interlocked.CompareExchange(ref m_CallNesting, 4, 0);
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_sending_headers", m_Request.Headers.ToString(forTrace: true)));
				}
				if (async)
				{
					WriteHeadersCallbackState writeHeadersCallbackState = new WriteHeadersCallbackState(m_Request, this);
					IAsyncResult asyncResult = m_Connection.UnsafeBeginWrite(writeBuffer, 0, writeBufferLength, m_WriteHeadersCallback, writeHeadersCallbackState);
					if (asyncResult.CompletedSynchronously)
					{
						try
						{
							m_Connection.EndWrite(asyncResult);
						}
						finally
						{
							m_Request.FreeWriteBuffer();
						}
						webExceptionStatus = WebExceptionStatus.Success;
					}
					else
					{
						webExceptionStatus = WebExceptionStatus.Pending;
					}
				}
				else
				{
					SafeSetSocketTimeout(SocketShutdown.Send);
					try
					{
						m_Connection.Write(writeBuffer, 0, writeBufferLength);
					}
					finally
					{
						m_Request.FreeWriteBuffer();
					}
					webExceptionStatus = WebExceptionStatus.Success;
				}
			}
			catch (Exception e)
			{
				HandleWriteHeadersException(e, webExceptionStatus);
			}
			finally
			{
				if (webExceptionStatus != WebExceptionStatus.Pending)
				{
					Interlocked.CompareExchange(ref m_CallNesting, 0, 4);
				}
			}
		}
		switch (webExceptionStatus)
		{
		case WebExceptionStatus.Pending:
			return;
		case WebExceptionStatus.Success:
			if (ErrorInStream)
			{
				break;
			}
			webExceptionStatus = WebExceptionStatus.ReceiveFailure;
			try
			{
				if (async)
				{
					m_Request.StartAsync100ContinueTimer();
					m_Connection.CheckStartReceive(m_Request);
				}
				else
				{
					m_Request.StartContinueWait();
					m_Connection.CheckStartReceive(m_Request);
					if (m_Request.ShouldWaitFor100Continue())
					{
						PollAndRead(m_Request.UserRetrievedWriteStream);
					}
				}
				webExceptionStatus = WebExceptionStatus.Success;
			}
			catch (Exception e2)
			{
				HandleWriteHeadersException(e2, webExceptionStatus);
			}
			break;
		}
		m_Request.WriteHeadersCallback(webExceptionStatus, this, async);
	}

	private void HandleWriteHeadersException(Exception e, WebExceptionStatus error)
	{
		if (e is IOException || e is ObjectDisposedException)
		{
			e = ((m_Connection.AtLeastOneResponseReceived || m_Request.BodyStarted) ? new WebException(NetRes.GetWebStatusString("net_connclosed", error), error, m_Connection.AtLeastOneResponseReceived ? WebExceptionInternalStatus.Isolated : WebExceptionInternalStatus.RequestFatal, e) : new WebException(NetRes.GetWebStatusString("net_connclosed", error), error, WebExceptionInternalStatus.Recoverable, e));
		}
		IOError(e, willThrow: false);
	}

	internal ChannelBinding GetChannelBinding(ChannelBindingKind kind)
	{
		ChannelBinding result = null;
		if (m_Connection.NetworkStream is TlsStream tlsStream)
		{
			result = tlsStream.GetChannelBinding(kind);
		}
		return result;
	}

	internal void PollAndRead(bool userRetrievedStream)
	{
		m_Connection.PollAndRead(m_Request, userRetrievedStream);
	}

	private void SafeSetSocketTimeout(SocketShutdown mode)
	{
		if (!Eof)
		{
			int timeout = ((mode != SocketShutdown.Receive) ? WriteTimeout : ReadTimeout);
			m_Connection?.NetworkStream?.SetSocketTimeoutOption(mode, timeout, silent: false);
		}
	}

	internal int SetRtcOption(byte[] rtcInputSocketConfig, byte[] rtcOutputSocketResult)
	{
		Socket internalSocket = InternalSocket;
		try
		{
			internalSocket.IOControl(-1744830445, rtcInputSocketConfig, null);
			internalSocket.IOControl(-1744830444, rtcInputSocketConfig, rtcOutputSocketResult);
		}
		catch (SocketException ex)
		{
			IOError(ex, willThrow: false);
			return ex.ErrorCode;
		}
		return 0;
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing)
			{
				if (Logging.On)
				{
					Logging.Enter(Logging.Web, this, "Close", "");
				}
				((ICloseEx)this).CloseEx(CloseExState.Normal);
				if (Logging.On)
				{
					Logging.Exit(Logging.Web, this, "Close", "");
				}
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	internal void CloseInternal(bool internalCall)
	{
		((ICloseEx)this).CloseEx(internalCall ? CloseExState.Silent : CloseExState.Normal);
	}

	void ICloseEx.CloseEx(CloseExState closeState)
	{
		CloseInternal((closeState & CloseExState.Silent) != 0, (closeState & CloseExState.Abort) != 0);
		GC.SuppressFinalize(this);
	}

	private void ResumeInternalClose(LazyAsyncResult userResult)
	{
		if (WriteChunked && !ErrorInStream && !m_IgnoreSocketErrors)
		{
			m_IgnoreSocketErrors = true;
			try
			{
				if (userResult != null)
				{
					m_Connection.BeginWrite(NclConstants.ChunkTerminator, 0, NclConstants.ChunkTerminator.Length, ResumeClose_Part2_Wrapper, userResult);
					return;
				}
				SafeSetSocketTimeout(SocketShutdown.Send);
				m_Connection.Write(NclConstants.ChunkTerminator, 0, NclConstants.ChunkTerminator.Length);
			}
			catch (Exception)
			{
			}
		}
		ResumeClose_Part2(userResult);
	}

	private void ResumeClose_Part2_Wrapper(IAsyncResult ar)
	{
		try
		{
			m_Connection.EndWrite(ar);
		}
		catch (Exception)
		{
		}
		ResumeClose_Part2((LazyAsyncResult)ar.AsyncState);
	}

	private void ResumeClose_Part2(LazyAsyncResult userResult)
	{
		try
		{
			try
			{
				if (ErrorInStream)
				{
					m_Connection.AbortSocket(isAbortState: true);
				}
			}
			finally
			{
				CallDone();
			}
		}
		catch
		{
		}
		finally
		{
			userResult?.InvokeCallback();
		}
	}

	private void CloseInternal(bool internalCall, bool aborting)
	{
		bool flag = !aborting;
		Exception ex = null;
		if (aborting)
		{
			if (Interlocked.Exchange(ref m_ShutDown, 777777) >= 777777)
			{
				return;
			}
		}
		else
		{
			if (Interlocked.Increment(ref m_ShutDown) > 1)
			{
				return;
			}
			RequestLifetimeSetter.Report(m_RequestLifetimeSetter);
		}
		int num = ((IsPostStream && internalCall && !IgnoreSocketErrors && !BufferOnly && flag && !NclUtilities.HasShutdownStarted) ? 2 : 3);
		if (Interlocked.Exchange(ref m_CallNesting, num) == 1)
		{
			if (num == 2)
			{
				return;
			}
			flag &= !NclUtilities.HasShutdownStarted;
		}
		if (IgnoreSocketErrors && IsPostStream && !internalCall)
		{
			m_BytesLeftToWrite = 0L;
		}
		if (!IgnoreSocketErrors && flag)
		{
			if (!WriteStream)
			{
				Connection connection = m_Connection;
				if (connection != null)
				{
					NetworkStream networkStream = connection.NetworkStream;
					if (networkStream != null && networkStream.Connected)
					{
						flag = DrainSocket();
					}
				}
			}
			else
			{
				try
				{
					if (!ErrorInStream)
					{
						if (WriteChunked)
						{
							try
							{
								if (!m_IgnoreSocketErrors)
								{
									m_IgnoreSocketErrors = true;
									SafeSetSocketTimeout(SocketShutdown.Send);
									m_Connection.Write(NclConstants.ChunkTerminator, 0, NclConstants.ChunkTerminator.Length);
								}
							}
							catch
							{
							}
							m_BytesLeftToWrite = 0L;
						}
						else if (BytesLeftToWrite > 0)
						{
							if (!internalCall)
							{
								throw new IOException(SR.GetString("net_io_notenoughbyteswritten"));
							}
							m_Connection.AbortSocket(isAbortState: true);
						}
						else if (BufferOnly)
						{
							m_BytesLeftToWrite = BufferedData.Length;
							m_Request.SwitchToContentLength();
							SafeSetSocketTimeout(SocketShutdown.Send);
							m_Request.NeedEndSubmitRequest();
							return;
						}
					}
					else
					{
						flag = false;
					}
				}
				catch (Exception ex2)
				{
					flag = false;
					if (NclUtilities.IsFatal(ex2))
					{
						m_ErrorException = ex2;
						throw;
					}
					ex = new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), ex2, WebExceptionStatus.RequestCanceled, null);
				}
			}
		}
		if (!flag && m_DoneCalled == 0)
		{
			if (!aborting && Interlocked.Exchange(ref m_ShutDown, 777777) >= 777777)
			{
				return;
			}
			m_ErrorException = new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
			m_Connection.AbortSocket(isAbortState: true);
			if (WriteStream)
			{
				m_Request?.Abort();
			}
			if (ex != null)
			{
				CallDone();
				if (!internalCall)
				{
					throw ex;
				}
			}
		}
		CallDone();
	}

	public override void Flush()
	{
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return Task.CompletedTask;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException(SR.GetString("net_noseek"));
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException(SR.GetString("net_noseek"));
	}

	private bool DrainSocket()
	{
		if (IgnoreSocketErrors)
		{
			return true;
		}
		long readBytes = m_ReadBytes;
		if (!m_Chunked)
		{
			if (m_ReadBufferSize != 0)
			{
				m_ReadOffset += m_ReadBufferSize;
				if (m_ReadBytes != -1)
				{
					m_ReadBytes -= m_ReadBufferSize;
					if (m_ReadBytes < 0)
					{
						m_ReadBytes = 0L;
						return false;
					}
				}
				m_ReadBufferSize = 0;
				m_ReadBuffer = null;
			}
			if (readBytes == -1)
			{
				return true;
			}
		}
		if (Eof)
		{
			return true;
		}
		int responseDrainTimeout = GetResponseDrainTimeout();
		if (responseDrainTimeout == 0 || m_ReadBytes > 65536)
		{
			m_Connection.AbortSocket(isAbortState: false);
			return true;
		}
		int num = 0;
		Stopwatch stopwatch = new Stopwatch();
		int num2;
		try
		{
			NetworkStream networkStream = m_Connection.NetworkStream;
			networkStream.SetSocketTimeoutOption(SocketShutdown.Receive, responseDrainTimeout, silent: false);
			stopwatch.Start();
			do
			{
				if (stopwatch.ElapsedMilliseconds >= responseDrainTimeout)
				{
					num2 = -1;
					break;
				}
				num2 = ReadWithoutValidation(s_DrainingBuffer, 0, s_DrainingBuffer.Length, abortOnError: false);
				num += num2;
			}
			while (num2 > 0 && (long)num <= 65536L);
		}
		catch (IOException)
		{
			num2 = -1;
		}
		catch (ObjectDisposedException)
		{
			num2 = -1;
		}
		catch (Exception exception)
		{
			if (NclUtilities.IsFatal(exception))
			{
				throw;
			}
			num2 = -1;
		}
		finally
		{
			stopwatch.Stop();
		}
		if (num2 != 0)
		{
			m_Connection.AbortSocket(isAbortState: false);
		}
		else
		{
			SafeSetSocketTimeout(SocketShutdown.Receive);
		}
		return true;
	}

	private int GetResponseDrainTimeout()
	{
		if (responseDrainTimeoutMilliseconds == -1)
		{
			string s = ConfigurationManager.AppSettings["responseDrainTimeout"];
			if (int.TryParse(s, NumberStyles.None, CultureInfo.InvariantCulture, out var result))
			{
				responseDrainTimeoutMilliseconds = result;
			}
			else
			{
				responseDrainTimeoutMilliseconds = 500;
			}
		}
		return responseDrainTimeoutMilliseconds;
	}

	private void IOError(Exception exception)
	{
		IOError(exception, willThrow: true);
	}

	private void IOError(Exception exception, bool willThrow)
	{
		if (m_ErrorException == null)
		{
			if (exception == null)
			{
				Interlocked.CompareExchange(value: new IOException(WriteStream ? SR.GetString("net_io_writefailure", SR.GetString("net_io_connectionclosed")) : SR.GetString("net_io_readfailure", SR.GetString("net_io_connectionclosed"))), location1: ref m_ErrorException, comparand: null);
			}
			else
			{
				willThrow &= Interlocked.CompareExchange(ref m_ErrorException, exception, null) != null;
			}
		}
		ConnectionReturnResult returnResult = null;
		if (WriteStream)
		{
			m_Connection.HandleConnectStreamException(writeDone: true, readDone: false, WebExceptionStatus.SendFailure, ref returnResult, m_ErrorException);
		}
		else
		{
			m_Connection.HandleConnectStreamException(writeDone: false, readDone: true, WebExceptionStatus.ReceiveFailure, ref returnResult, m_ErrorException);
		}
		CallDone(returnResult);
		if (willThrow)
		{
			throw m_ErrorException;
		}
	}

	internal static byte[] GetChunkHeader(int size, out int offset)
	{
		uint num = 4026531840u;
		byte[] array = new byte[10];
		offset = -1;
		int num2 = 0;
		while (num2 < 8)
		{
			if (offset != -1 || (size & num) != 0L)
			{
				uint num3 = (uint)size >> 28;
				if (num3 < 10)
				{
					array[num2] = (byte)(num3 + 48);
				}
				else
				{
					array[num2] = (byte)(num3 - 10 + 65);
				}
				if (offset == -1)
				{
					offset = num2;
				}
			}
			num2++;
			size <<= 4;
		}
		array[8] = 13;
		array[9] = 10;
		return array;
	}

	void IRequestLifetimeTracker.TrackRequestLifetime(long requestStartTimestamp)
	{
		m_RequestLifetimeSetter = new RequestLifetimeSetter(requestStartTimestamp);
	}
}
