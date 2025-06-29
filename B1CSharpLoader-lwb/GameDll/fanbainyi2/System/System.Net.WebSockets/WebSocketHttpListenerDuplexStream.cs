using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.WebSockets;

internal class WebSocketHttpListenerDuplexStream : Stream, WebSocketBase.IWebSocketStream
{
	internal class HttpListenerAsyncEventArgs : EventArgs, IDisposable
	{
		public enum HttpListenerAsyncOperation
		{
			None,
			Receive,
			Send
		}

		private const int Free = 0;

		private const int InProgress = 1;

		private const int Disposed = 2;

		private int m_Operating;

		private bool m_DisposeCalled;

		private SafeNativeOverlapped m_PtrNativeOverlapped;

		private Overlapped m_Overlapped;

		private byte[] m_Buffer;

		private IList<ArraySegment<byte>> m_BufferList;

		private int m_Count;

		private int m_Offset;

		private int m_BytesTransferred;

		private HttpListenerAsyncOperation m_CompletedOperation;

		private UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK[] m_DataChunks;

		private GCHandle m_DataChunksGCHandle;

		private ushort m_DataChunkCount;

		private Exception m_Exception;

		private bool m_ShouldCloseOutput;

		private readonly WebSocketBase m_WebSocket;

		private readonly WebSocketHttpListenerDuplexStream m_CurrentStream;

		private readonly bool m_AllocateOverlappedOnDemand;

		public int BytesTransferred => m_BytesTransferred;

		public byte[] Buffer => m_Buffer;

		public IList<ArraySegment<byte>> BufferList
		{
			get
			{
				return m_BufferList;
			}
			set
			{
				m_BufferList = value;
			}
		}

		public bool ShouldCloseOutput => m_ShouldCloseOutput;

		public int Offset => m_Offset;

		public int Count => m_Count;

		public Exception Exception => m_Exception;

		public ushort EntityChunkCount
		{
			get
			{
				if (m_DataChunks == null)
				{
					return 0;
				}
				return m_DataChunkCount;
			}
		}

		public SafeNativeOverlapped NativeOverlapped => m_PtrNativeOverlapped;

		public IntPtr EntityChunks
		{
			get
			{
				if (m_DataChunks == null)
				{
					return IntPtr.Zero;
				}
				return Marshal.UnsafeAddrOfPinnedArrayElement((Array)m_DataChunks, 0);
			}
		}

		public WebSocketHttpListenerDuplexStream CurrentStream => m_CurrentStream;

		private event EventHandler<HttpListenerAsyncEventArgs> m_Completed;

		public event EventHandler<HttpListenerAsyncEventArgs> Completed
		{
			add
			{
				m_Completed += value;
			}
			remove
			{
				m_Completed -= value;
			}
		}

		public HttpListenerAsyncEventArgs(WebSocketBase webSocket, WebSocketHttpListenerDuplexStream stream)
		{
			m_WebSocket = webSocket;
			m_CurrentStream = stream;
			m_AllocateOverlappedOnDemand = System.LocalAppContextSwitches.AllocateOverlappedOnDemand;
			if (!m_AllocateOverlappedOnDemand)
			{
				InitializeOverlapped();
			}
		}

		protected virtual void OnCompleted(HttpListenerAsyncEventArgs e)
		{
			this.m_Completed?.Invoke(e.m_CurrentStream, e);
		}

		public void SetShouldCloseOutput()
		{
			m_BufferList = null;
			m_Buffer = null;
			m_ShouldCloseOutput = true;
		}

		public void Dispose()
		{
			m_DisposeCalled = true;
			if (Interlocked.CompareExchange(ref m_Operating, 2, 0) == 0)
			{
				if (!m_AllocateOverlappedOnDemand)
				{
					FreeOverlapped(checkForShutdown: false);
				}
				GC.SuppressFinalize(this);
			}
		}

		~HttpListenerAsyncEventArgs()
		{
			if (!m_AllocateOverlappedOnDemand)
			{
				FreeOverlapped(checkForShutdown: true);
			}
		}

		private unsafe void InitializeOverlapped()
		{
			m_Overlapped = new Overlapped();
			m_PtrNativeOverlapped = new SafeNativeOverlapped(m_Overlapped.UnsafePack(CompletionPortCallback, null));
		}

		private void FreeOverlapped(bool checkForShutdown)
		{
			if (checkForShutdown && NclUtilities.HasShutdownStarted)
			{
				return;
			}
			if (m_PtrNativeOverlapped != null && !m_PtrNativeOverlapped.IsInvalid)
			{
				m_PtrNativeOverlapped.Dispose();
			}
			if (m_DataChunksGCHandle.IsAllocated)
			{
				m_DataChunksGCHandle.Free();
				if (m_AllocateOverlappedOnDemand)
				{
					m_DataChunks = null;
				}
			}
		}

		internal void StartOperationCommon(WebSocketHttpListenerDuplexStream currentStream)
		{
			if (Interlocked.CompareExchange(ref m_Operating, 1, 0) != 0)
			{
				if (m_DisposeCalled)
				{
					throw new ObjectDisposedException(GetType().FullName);
				}
				throw new InvalidOperationException();
			}
			if (m_AllocateOverlappedOnDemand)
			{
				InitializeOverlapped();
			}
			else
			{
				NativeOverlapped.ReinitializeNativeOverlapped();
			}
			m_Exception = null;
			m_BytesTransferred = 0;
		}

		internal void StartOperationReceive()
		{
			m_CompletedOperation = HttpListenerAsyncOperation.Receive;
		}

		internal void StartOperationSend()
		{
			UpdateDataChunk();
			m_CompletedOperation = HttpListenerAsyncOperation.Send;
		}

		public void SetBuffer(byte[] buffer, int offset, int count)
		{
			m_Buffer = buffer;
			m_Offset = offset;
			m_Count = count;
		}

		private void UpdateDataChunk()
		{
			if (m_DataChunks == null)
			{
				m_DataChunks = new UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK[2];
				m_DataChunksGCHandle = GCHandle.Alloc(m_DataChunks, GCHandleType.Pinned);
				m_DataChunks[0] = default(UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK);
				m_DataChunks[0].DataChunkType = UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK_TYPE.HttpDataChunkFromMemory;
				m_DataChunks[1] = default(UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK);
				m_DataChunks[1].DataChunkType = UnsafeNclNativeMethods.HttpApi.HTTP_DATA_CHUNK_TYPE.HttpDataChunkFromMemory;
			}
			if (m_Buffer != null)
			{
				UpdateDataChunk(0, m_Buffer, m_Offset, m_Count);
				UpdateDataChunk(1, null, 0, 0);
				m_DataChunkCount = 1;
			}
			else if (m_BufferList != null)
			{
				UpdateDataChunk(0, m_BufferList[0].Array, m_BufferList[0].Offset, m_BufferList[0].Count);
				UpdateDataChunk(1, m_BufferList[1].Array, m_BufferList[1].Offset, m_BufferList[1].Count);
				m_DataChunkCount = 2;
			}
			else
			{
				m_DataChunks = null;
			}
		}

		private unsafe void UpdateDataChunk(int index, byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				m_DataChunks[index].pBuffer = null;
				m_DataChunks[index].BufferLength = 0u;
				return;
			}
			if (m_WebSocket.InternalBuffer.IsInternalBuffer(buffer, offset, count))
			{
				m_DataChunks[index].pBuffer = (byte*)(void*)m_WebSocket.InternalBuffer.ToIntPtr(offset);
			}
			else
			{
				m_DataChunks[index].pBuffer = (byte*)(void*)m_WebSocket.InternalBuffer.ConvertPinnedSendPayloadToNative(buffer, offset, count);
			}
			m_DataChunks[index].BufferLength = (uint)count;
		}

		internal void Complete()
		{
			if (m_AllocateOverlappedOnDemand)
			{
				FreeOverlapped(checkForShutdown: false);
				Interlocked.Exchange(ref m_Operating, 0);
			}
			else
			{
				m_Operating = 0;
			}
			if (m_DisposeCalled)
			{
				Dispose();
			}
		}

		private void SetResults(Exception exception, int bytesTransferred)
		{
			m_Exception = exception;
			m_BytesTransferred = bytesTransferred;
		}

		internal void FinishOperationFailure(Exception exception, bool syncCompletion)
		{
			SetResults(exception, 0);
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.PrintError(Logging.WebSockets, m_CurrentStream, (m_CompletedOperation == HttpListenerAsyncOperation.Receive) ? "ReadAsyncFast" : "WriteAsyncFast", exception.ToString());
			}
			Complete();
			OnCompleted(this);
		}

		internal void FinishOperationSuccess(int bytesTransferred, bool syncCompletion)
		{
			SetResults(null, bytesTransferred);
			if (WebSocketBase.LoggingEnabled)
			{
				if (m_Buffer != null)
				{
					Logging.Dump(Logging.WebSockets, m_CurrentStream, (m_CompletedOperation == HttpListenerAsyncOperation.Receive) ? "ReadAsyncFast" : "WriteAsyncFast", m_Buffer, m_Offset, bytesTransferred);
				}
				else if (m_BufferList != null)
				{
					foreach (ArraySegment<byte> buffer in BufferList)
					{
						Logging.Dump(Logging.WebSockets, this, "WriteAsyncFast", buffer.Array, buffer.Offset, buffer.Count);
					}
				}
				else
				{
					Logging.PrintLine(Logging.WebSockets, TraceEventType.Verbose, 0, string.Format(CultureInfo.InvariantCulture, "Output channel closed for {0}#{1}", new object[2]
					{
						m_CurrentStream.GetType().Name,
						ValidationHelper.HashString(m_CurrentStream)
					}));
				}
			}
			if (m_ShouldCloseOutput)
			{
				m_CurrentStream.m_OutputStream.SetClosedFlag();
			}
			Complete();
			OnCompleted(this);
		}

		private unsafe void CompletionPortCallback(uint errorCode, uint numBytes, NativeOverlapped* nativeOverlapped)
		{
			if (errorCode == 0 || errorCode == 38)
			{
				FinishOperationSuccess((int)numBytes, syncCompletion: false);
			}
			else
			{
				FinishOperationFailure(new HttpListenerException((int)errorCode), syncCompletion: false);
			}
		}
	}

	private static class Methods
	{
		public const string CloseNetworkConnectionAsync = "CloseNetworkConnectionAsync";

		public const string OnCancel = "OnCancel";

		public const string OnReadCompleted = "OnReadCompleted";

		public const string OnWriteCompleted = "OnWriteCompleted";

		public const string ReadAsyncFast = "ReadAsyncFast";

		public const string ReadAsyncCore = "ReadAsyncCore";

		public const string WriteAsyncFast = "WriteAsyncFast";

		public const string WriteAsyncCore = "WriteAsyncCore";

		public const string MultipleWriteAsyncCore = "MultipleWriteAsyncCore";
	}

	private static readonly EventHandler<HttpListenerAsyncEventArgs> s_OnReadCompleted = OnReadCompleted;

	private static readonly EventHandler<HttpListenerAsyncEventArgs> s_OnWriteCompleted = OnWriteCompleted;

	private static readonly Func<Exception, bool> s_CanHandleException = CanHandleException;

	private static readonly Action<object> s_OnCancel = OnCancel;

	private readonly HttpRequestStream m_InputStream;

	private readonly HttpResponseStream m_OutputStream;

	private HttpListenerContext m_Context;

	private bool m_InOpaqueMode;

	private WebSocketBase m_WebSocket;

	private HttpListenerAsyncEventArgs m_WriteEventArgs;

	private HttpListenerAsyncEventArgs m_ReadEventArgs;

	private TaskCompletionSource<object> m_WriteTaskCompletionSource;

	private TaskCompletionSource<int> m_ReadTaskCompletionSource;

	private int m_CleanedUp;

	public override bool CanRead => m_InputStream.CanRead;

	public override bool CanSeek => false;

	public override bool CanTimeout
	{
		get
		{
			if (m_InputStream.CanTimeout)
			{
				return m_OutputStream.CanTimeout;
			}
			return false;
		}
	}

	public override bool CanWrite => m_OutputStream.CanWrite;

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

	public bool SupportsMultipleWrite => true;

	public WebSocketHttpListenerDuplexStream(HttpRequestStream inputStream, HttpResponseStream outputStream, HttpListenerContext context)
	{
		m_InputStream = inputStream;
		m_OutputStream = outputStream;
		m_Context = context;
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Associate(Logging.WebSockets, inputStream, this);
			Logging.Associate(Logging.WebSockets, outputStream, this);
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return m_InputStream.Read(buffer, offset, count);
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		WebSocketHelpers.ValidateBuffer(buffer, offset, count);
		return ReadAsyncCore(buffer, offset, count, cancellationToken);
	}

	private async Task<int> ReadAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, this, "ReadAsyncCore", WebSocketHelpers.GetTraceMsgForParameters(offset, count, cancellationToken));
		}
		CancellationTokenRegistration cancellationTokenRegistration = default(CancellationTokenRegistration);
		int bytesRead = 0;
		try
		{
			if (cancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration = cancellationToken.Register(s_OnCancel, this, useSynchronizationContext: false);
			}
			if (!m_InOpaqueMode)
			{
				bytesRead = await m_InputStream.ReadAsync(buffer, offset, count, cancellationToken).SuppressContextFlow();
			}
			else
			{
				m_ReadTaskCompletionSource = new TaskCompletionSource<int>();
				m_ReadEventArgs.SetBuffer(buffer, offset, count);
				if (!ReadAsyncFast(m_ReadEventArgs))
				{
					if (m_ReadEventArgs.Exception != null)
					{
						throw m_ReadEventArgs.Exception;
					}
					bytesRead = m_ReadEventArgs.BytesTransferred;
				}
				else
				{
					bytesRead = await m_ReadTaskCompletionSource.Task.SuppressContextFlow();
				}
			}
		}
		catch (Exception arg)
		{
			if (s_CanHandleException(arg))
			{
				cancellationToken.ThrowIfCancellationRequested();
			}
			throw;
		}
		finally
		{
			cancellationTokenRegistration.Dispose();
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, this, "ReadAsyncCore", bytesRead);
			}
		}
		return bytesRead;
	}

	private unsafe bool ReadAsyncFast(HttpListenerAsyncEventArgs eventArgs)
	{
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, this, "ReadAsyncFast", string.Empty);
		}
		eventArgs.StartOperationCommon(this);
		eventArgs.StartOperationReceive();
		uint num = 0u;
		bool flag = false;
		try
		{
			if (eventArgs.Count == 0 || m_InputStream.Closed)
			{
				eventArgs.FinishOperationSuccess(0, syncCompletion: true);
				return false;
			}
			uint num2 = 0u;
			int offset = eventArgs.Offset;
			int count = eventArgs.Count;
			if (m_InputStream.BufferedDataChunksAvailable)
			{
				num2 = m_InputStream.GetChunks(eventArgs.Buffer, eventArgs.Offset, eventArgs.Count);
				if (m_InputStream.BufferedDataChunksAvailable && num2 == eventArgs.Count)
				{
					eventArgs.FinishOperationSuccess(eventArgs.Count, syncCompletion: true);
					return false;
				}
			}
			if (num2 != 0)
			{
				offset += (int)num2;
				count -= (int)num2;
				if (count > 131072)
				{
					count = 131072;
				}
				eventArgs.SetBuffer(eventArgs.Buffer, offset, count);
			}
			else if (count > 131072)
			{
				count = 131072;
				eventArgs.SetBuffer(eventArgs.Buffer, offset, count);
			}
			m_InputStream.InternalHttpContext.EnsureBoundHandle();
			uint flags = 0u;
			uint bytesReturned = 0u;
			num = UnsafeNclNativeMethods.HttpApi.HttpReceiveRequestEntityBody2(m_InputStream.InternalHttpContext.RequestQueueHandle, m_InputStream.InternalHttpContext.RequestId, flags, (void*)m_WebSocket.InternalBuffer.ToIntPtr(eventArgs.Offset), (uint)eventArgs.Count, out bytesReturned, eventArgs.NativeOverlapped);
			if (num != 0 && num != 997 && num != 38)
			{
				throw new HttpListenerException((int)num);
			}
			if (num == 0 && HttpListener.SkipIOCPCallbackOnSuccess)
			{
				eventArgs.FinishOperationSuccess((int)bytesReturned, syncCompletion: true);
				flag = false;
			}
			else if (num == 38)
			{
				eventArgs.FinishOperationSuccess(0, syncCompletion: true);
				flag = false;
			}
			else
			{
				flag = true;
			}
		}
		catch (Exception exception)
		{
			m_ReadEventArgs.FinishOperationFailure(exception, syncCompletion: true);
			m_OutputStream.SetClosedFlag();
			m_OutputStream.InternalHttpContext.Abort();
			throw;
		}
		finally
		{
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, this, "ReadAsyncFast", flag);
			}
		}
		return flag;
	}

	public override int ReadByte()
	{
		return m_InputStream.ReadByte();
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return m_InputStream.BeginRead(buffer, offset, count, callback, state);
	}

	public override int EndRead(IAsyncResult asyncResult)
	{
		return m_InputStream.EndRead(asyncResult);
	}

	public Task MultipleWriteAsync(IList<ArraySegment<byte>> sendBuffers, CancellationToken cancellationToken)
	{
		if (sendBuffers.Count == 1)
		{
			ArraySegment<byte> arraySegment = sendBuffers[0];
			return WriteAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count, cancellationToken);
		}
		return MultipleWriteAsyncCore(sendBuffers, cancellationToken);
	}

	private async Task MultipleWriteAsyncCore(IList<ArraySegment<byte>> sendBuffers, CancellationToken cancellationToken)
	{
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, this, "MultipleWriteAsyncCore", string.Empty);
		}
		CancellationTokenRegistration cancellationTokenRegistration = default(CancellationTokenRegistration);
		try
		{
			if (cancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration = cancellationToken.Register(s_OnCancel, this, useSynchronizationContext: false);
			}
			m_WriteTaskCompletionSource = new TaskCompletionSource<object>();
			m_WriteEventArgs.SetBuffer(null, 0, 0);
			m_WriteEventArgs.BufferList = sendBuffers;
			if (WriteAsyncFast(m_WriteEventArgs))
			{
				await m_WriteTaskCompletionSource.Task.SuppressContextFlow();
			}
		}
		catch (Exception arg)
		{
			if (s_CanHandleException(arg))
			{
				cancellationToken.ThrowIfCancellationRequested();
			}
			throw;
		}
		finally
		{
			cancellationTokenRegistration.Dispose();
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, this, "MultipleWriteAsyncCore", string.Empty);
			}
		}
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		m_OutputStream.Write(buffer, offset, count);
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		WebSocketHelpers.ValidateBuffer(buffer, offset, count);
		return WriteAsyncCore(buffer, offset, count, cancellationToken);
	}

	private async Task WriteAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, this, "WriteAsyncCore", WebSocketHelpers.GetTraceMsgForParameters(offset, count, cancellationToken));
		}
		CancellationTokenRegistration cancellationTokenRegistration = default(CancellationTokenRegistration);
		try
		{
			if (cancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration = cancellationToken.Register(s_OnCancel, this, useSynchronizationContext: false);
			}
			if (!m_InOpaqueMode)
			{
				await m_OutputStream.WriteAsync(buffer, offset, count, cancellationToken).SuppressContextFlow();
				return;
			}
			m_WriteTaskCompletionSource = new TaskCompletionSource<object>();
			m_WriteEventArgs.BufferList = null;
			m_WriteEventArgs.SetBuffer(buffer, offset, count);
			if (WriteAsyncFast(m_WriteEventArgs))
			{
				await m_WriteTaskCompletionSource.Task.SuppressContextFlow();
			}
		}
		catch (Exception arg)
		{
			if (s_CanHandleException(arg))
			{
				cancellationToken.ThrowIfCancellationRequested();
			}
			throw;
		}
		finally
		{
			cancellationTokenRegistration.Dispose();
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, this, "WriteAsyncCore", string.Empty);
			}
		}
	}

	private bool WriteAsyncFast(HttpListenerAsyncEventArgs eventArgs)
	{
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, this, "WriteAsyncFast", string.Empty);
		}
		UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS hTTP_FLAGS = UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.NONE;
		eventArgs.StartOperationCommon(this);
		eventArgs.StartOperationSend();
		bool flag = false;
		try
		{
			if (m_OutputStream.Closed || (eventArgs.Buffer != null && eventArgs.Count == 0))
			{
				eventArgs.FinishOperationSuccess(eventArgs.Count, syncCompletion: true);
				return false;
			}
			if (eventArgs.ShouldCloseOutput)
			{
				hTTP_FLAGS |= UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.HTTP_RECEIVE_REQUEST_FLAG_COPY_BODY;
			}
			else
			{
				hTTP_FLAGS |= UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.HTTP_SEND_RESPONSE_FLAG_MORE_DATA;
				hTTP_FLAGS |= UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.HTTP_SEND_RESPONSE_FLAG_BUFFER_DATA;
			}
			m_OutputStream.InternalHttpContext.EnsureBoundHandle();
			uint pBytesSent;
			uint num = UnsafeNclNativeMethods.HttpApi.HttpSendResponseEntityBody2(m_OutputStream.InternalHttpContext.RequestQueueHandle, m_OutputStream.InternalHttpContext.RequestId, (uint)hTTP_FLAGS, eventArgs.EntityChunkCount, eventArgs.EntityChunks, out pBytesSent, SafeLocalFree.Zero, 0u, eventArgs.NativeOverlapped, IntPtr.Zero);
			if (num != 0 && num != 997)
			{
				throw new HttpListenerException((int)num);
			}
			if (num == 0 && HttpListener.SkipIOCPCallbackOnSuccess)
			{
				eventArgs.FinishOperationSuccess((int)pBytesSent, syncCompletion: true);
				flag = false;
			}
			else
			{
				flag = true;
			}
		}
		catch (Exception exception)
		{
			m_WriteEventArgs.FinishOperationFailure(exception, syncCompletion: true);
			m_OutputStream.SetClosedFlag();
			m_OutputStream.InternalHttpContext.Abort();
			throw;
		}
		finally
		{
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, this, "WriteAsyncFast", flag);
			}
		}
		return flag;
	}

	public override void WriteByte(byte value)
	{
		m_OutputStream.WriteByte(value);
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return m_OutputStream.BeginWrite(buffer, offset, count, callback, state);
	}

	public override void EndWrite(IAsyncResult asyncResult)
	{
		m_OutputStream.EndWrite(asyncResult);
	}

	public override void Flush()
	{
		m_OutputStream.Flush();
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return m_OutputStream.FlushAsync(cancellationToken);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException(SR.GetString("net_noseek"));
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException(SR.GetString("net_noseek"));
	}

	public async Task CloseNetworkConnectionAsync(CancellationToken cancellationToken)
	{
		await Task.Yield();
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, this, "CloseNetworkConnectionAsync", string.Empty);
		}
		CancellationTokenRegistration cancellationTokenRegistration = default(CancellationTokenRegistration);
		try
		{
			if (cancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration = cancellationToken.Register(s_OnCancel, this, useSynchronizationContext: false);
			}
			m_WriteTaskCompletionSource = new TaskCompletionSource<object>();
			m_WriteEventArgs.SetShouldCloseOutput();
			if (WriteAsyncFast(m_WriteEventArgs))
			{
				await m_WriteTaskCompletionSource.Task.SuppressContextFlow();
			}
		}
		catch (Exception arg)
		{
			if (!s_CanHandleException(arg))
			{
				throw;
			}
			cancellationToken.ThrowIfCancellationRequested();
		}
		finally
		{
			cancellationTokenRegistration.Dispose();
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, this, "CloseNetworkConnectionAsync", string.Empty);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && Interlocked.Exchange(ref m_CleanedUp, 1) == 0)
		{
			if (m_ReadTaskCompletionSource != null)
			{
				m_ReadTaskCompletionSource.TrySetCanceled();
			}
			if (m_WriteTaskCompletionSource != null)
			{
				m_WriteTaskCompletionSource.TrySetCanceled();
			}
			if (m_ReadEventArgs != null)
			{
				m_ReadEventArgs.Dispose();
			}
			if (m_WriteEventArgs != null)
			{
				m_WriteEventArgs.Dispose();
			}
			try
			{
				m_InputStream.Close();
			}
			finally
			{
				m_OutputStream.Close();
			}
		}
	}

	public void Abort()
	{
		OnCancel(this);
	}

	private static bool CanHandleException(Exception error)
	{
		if (!(error is HttpListenerException) && !(error is ObjectDisposedException))
		{
			return error is IOException;
		}
		return true;
	}

	private static void OnCancel(object state)
	{
		WebSocketHttpListenerDuplexStream webSocketHttpListenerDuplexStream = state as WebSocketHttpListenerDuplexStream;
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, state, "OnCancel", string.Empty);
		}
		try
		{
			webSocketHttpListenerDuplexStream.m_OutputStream.SetClosedFlag();
			webSocketHttpListenerDuplexStream.m_Context.Abort();
		}
		catch
		{
		}
		webSocketHttpListenerDuplexStream.m_ReadTaskCompletionSource?.TrySetCanceled();
		webSocketHttpListenerDuplexStream.m_WriteTaskCompletionSource?.TrySetCanceled();
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Exit(Logging.WebSockets, state, "OnCancel", string.Empty);
		}
	}

	public void SwitchToOpaqueMode(WebSocketBase webSocket)
	{
		if (m_InOpaqueMode)
		{
			throw new InvalidOperationException();
		}
		m_WebSocket = webSocket;
		m_InOpaqueMode = true;
		m_ReadEventArgs = new HttpListenerAsyncEventArgs(webSocket, this);
		m_ReadEventArgs.Completed += s_OnReadCompleted;
		m_WriteEventArgs = new HttpListenerAsyncEventArgs(webSocket, this);
		m_WriteEventArgs.Completed += s_OnWriteCompleted;
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Associate(Logging.WebSockets, this, webSocket);
		}
	}

	private static void OnWriteCompleted(object sender, HttpListenerAsyncEventArgs eventArgs)
	{
		WebSocketHttpListenerDuplexStream currentStream = eventArgs.CurrentStream;
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, currentStream, "OnWriteCompleted", string.Empty);
		}
		if (eventArgs.Exception != null)
		{
			currentStream.m_WriteTaskCompletionSource.TrySetException(eventArgs.Exception);
		}
		else
		{
			currentStream.m_WriteTaskCompletionSource.TrySetResult(null);
		}
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Exit(Logging.WebSockets, currentStream, "OnWriteCompleted", string.Empty);
		}
	}

	private static void OnReadCompleted(object sender, HttpListenerAsyncEventArgs eventArgs)
	{
		WebSocketHttpListenerDuplexStream currentStream = eventArgs.CurrentStream;
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, currentStream, "OnReadCompleted", string.Empty);
		}
		if (eventArgs.Exception != null)
		{
			currentStream.m_ReadTaskCompletionSource.TrySetException(eventArgs.Exception);
		}
		else
		{
			currentStream.m_ReadTaskCompletionSource.TrySetResult(eventArgs.BytesTransferred);
		}
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Exit(Logging.WebSockets, currentStream, "OnReadCompleted", string.Empty);
		}
	}
}
