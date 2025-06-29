using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.WebSockets;

internal class WebSocketConnectionStream : BufferedReadStream, WebSocketBase.IWebSocketStream
{
	private static class Methods
	{
		public const string Close = "Close";

		public const string CloseNetworkConnectionAsync = "CloseNetworkConnectionAsync";

		public const string OnCancel = "OnCancel";

		public const string ReadAsync = "ReadAsync";

		public const string WriteAsync = "WriteAsync";

		public const string MultipleWriteAsync = "MultipleWriteAsync";
	}

	private class WebSocketConnection : DelegatedStream, WebSocketBase.IWebSocketStream
	{
		private static class Methods
		{
			public const string Close = "Close";

			public const string OnCancel = "OnCancel";

			public const string OnReadCompleted = "OnReadCompleted";

			public const string OnWriteCompleted = "OnWriteCompleted";

			public const string ReadAsyncCore = "ReadAsyncCore";

			public const string WriteAsync = "WriteAsync";

			public const string MultipleWriteAsync = "MultipleWriteAsync";
		}

		private static readonly EventHandler<SocketAsyncEventArgs> s_OnReadCompleted = OnReadCompleted;

		private static readonly EventHandler<SocketAsyncEventArgs> s_OnWriteCompleted = OnWriteCompleted;

		private static readonly Func<IList<ArraySegment<byte>>, AsyncCallback, object, IAsyncResult> s_BeginMultipleWrite = BeginMultipleWrite;

		private static readonly Action<IAsyncResult> s_EndMultipleWrite = EndMultipleWrite;

		private readonly Connection m_InnerStream;

		private readonly bool m_SupportsMultipleWrites;

		private bool m_InOpaqueMode;

		private WebSocketBase m_WebSocket;

		private SocketAsyncEventArgs m_WriteEventArgs;

		private SocketAsyncEventArgs m_ReadEventArgs;

		private TaskCompletionSource<object> m_WriteTaskCompletionSource;

		private TaskCompletionSource<int> m_ReadTaskCompletionSource;

		private int m_CleanedUp;

		private bool m_IgnoreReadError;

		internal Socket InnerSocket => GetInnerSocket(skipStateCheck: false);

		public override bool CanSeek => false;

		public override bool CanRead => true;

		public override bool CanWrite => true;

		public bool SupportsMultipleWrite => m_SupportsMultipleWrites;

		internal WebSocketConnection(Connection connection)
			: base(connection)
		{
			m_InnerStream = connection;
			m_InOpaqueMode = false;
			m_SupportsMultipleWrites = connection.NetworkStream.GetType().Assembly == s_NetworkStreamType.Assembly;
		}

		public Task CloseNetworkConnectionAsync(CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public override void Close()
		{
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Enter(Logging.WebSockets, this, "Close", string.Empty);
			}
			try
			{
				base.Close();
				if (Interlocked.Increment(ref m_CleanedUp) == 1)
				{
					if (m_WriteEventArgs != null)
					{
						m_WriteEventArgs.Completed -= s_OnWriteCompleted;
						m_WriteEventArgs.Dispose();
					}
					if (m_ReadEventArgs != null)
					{
						m_ReadEventArgs.Completed -= s_OnReadCompleted;
						m_ReadEventArgs.Dispose();
					}
				}
			}
			finally
			{
				if (WebSocketBase.LoggingEnabled)
				{
					Logging.Exit(Logging.WebSockets, this, "Close", string.Empty);
				}
			}
		}

		internal Socket GetInnerSocket(bool skipStateCheck)
		{
			if (!skipStateCheck)
			{
				m_WebSocket.ThrowIfClosedOrAborted();
			}
			try
			{
				return m_InnerStream.NetworkStream.InternalSocket;
			}
			catch (ObjectDisposedException)
			{
				m_WebSocket.ThrowIfClosedOrAborted();
				throw;
			}
		}

		private static IAsyncResult BeginMultipleWrite(IList<ArraySegment<byte>> sendBuffers, AsyncCallback callback, object asyncState)
		{
			WebSocketConnection webSocketConnection = asyncState as WebSocketConnection;
			BufferOffsetSize[] array = new BufferOffsetSize[sendBuffers.Count];
			for (int i = 0; i < sendBuffers.Count; i++)
			{
				ArraySegment<byte> arraySegment = sendBuffers[i];
				array[i] = new BufferOffsetSize(arraySegment.Array, arraySegment.Offset, arraySegment.Count, copyBuffer: false);
			}
			WebSocketHelpers.ThrowIfConnectionAborted(webSocketConnection.m_InnerStream, read: false);
			return webSocketConnection.m_InnerStream.NetworkStream.BeginMultipleWrite(array, callback, asyncState);
		}

		private static void EndMultipleWrite(IAsyncResult asyncResult)
		{
			WebSocketConnection webSocketConnection = asyncResult.AsyncState as WebSocketConnection;
			WebSocketHelpers.ThrowIfConnectionAborted(webSocketConnection.m_InnerStream, read: false);
			webSocketConnection.m_InnerStream.NetworkStream.EndMultipleWrite(asyncResult);
		}

		public Task MultipleWriteAsync(IList<ArraySegment<byte>> sendBuffers, CancellationToken cancellationToken)
		{
			if (!m_InOpaqueMode)
			{
				return Task.Factory.FromAsync(s_BeginMultipleWrite, s_EndMultipleWrite, sendBuffers, this);
			}
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Enter(Logging.WebSockets, this, "MultipleWriteAsync", string.Empty);
			}
			bool flag = false;
			try
			{
				cancellationToken.ThrowIfCancellationRequested();
				WebSocketHelpers.ThrowIfConnectionAborted(m_InnerStream, read: false);
				m_WriteTaskCompletionSource = new TaskCompletionSource<object>();
				m_WriteEventArgs.SetBuffer(null, 0, 0);
				m_WriteEventArgs.BufferList = sendBuffers;
				flag = InnerSocket.SendAsync(m_WriteEventArgs);
				if (!flag)
				{
					if (m_WriteEventArgs.SocketError != SocketError.Success)
					{
						throw new SocketException(m_WriteEventArgs.SocketError);
					}
					return Task.CompletedTask;
				}
				return m_WriteTaskCompletionSource.Task;
			}
			finally
			{
				if (WebSocketBase.LoggingEnabled)
				{
					Logging.Exit(Logging.WebSockets, this, "MultipleWriteAsync", flag);
				}
			}
		}

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			WebSocketHelpers.ValidateBuffer(buffer, offset, count);
			if (!m_InOpaqueMode)
			{
				return base.WriteAsync(buffer, offset, count, cancellationToken);
			}
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Enter(Logging.WebSockets, this, "WriteAsync", WebSocketHelpers.GetTraceMsgForParameters(offset, count, cancellationToken));
			}
			bool flag = false;
			try
			{
				cancellationToken.ThrowIfCancellationRequested();
				WebSocketHelpers.ThrowIfConnectionAborted(m_InnerStream, read: false);
				m_WriteTaskCompletionSource = new TaskCompletionSource<object>();
				m_WriteEventArgs.BufferList = null;
				m_WriteEventArgs.SetBuffer(buffer, offset, count);
				flag = InnerSocket.SendAsync(m_WriteEventArgs);
				if (!flag)
				{
					if (m_WriteEventArgs.SocketError != SocketError.Success)
					{
						throw new SocketException(m_WriteEventArgs.SocketError);
					}
					return Task.CompletedTask;
				}
				return m_WriteTaskCompletionSource.Task;
			}
			finally
			{
				if (WebSocketBase.LoggingEnabled)
				{
					Logging.Exit(Logging.WebSockets, this, "WriteAsync", flag);
				}
			}
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			WebSocketHelpers.ValidateBuffer(buffer, offset, count);
			if (!m_InOpaqueMode)
			{
				return base.ReadAsync(buffer, offset, count, cancellationToken);
			}
			return ReadAsyncCore(buffer, offset, count, cancellationToken, ignoreReadError: false);
		}

		internal Task<int> ReadAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool ignoreReadError)
		{
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Enter(Logging.WebSockets, this, "ReadAsyncCore", WebSocketHelpers.GetTraceMsgForParameters(offset, count, cancellationToken));
			}
			bool flag = false;
			m_IgnoreReadError = ignoreReadError;
			try
			{
				cancellationToken.ThrowIfCancellationRequested();
				WebSocketHelpers.ThrowIfConnectionAborted(m_InnerStream, read: true);
				m_ReadTaskCompletionSource = new TaskCompletionSource<int>();
				m_ReadEventArgs.SetBuffer(buffer, offset, count);
				Socket socket = ((!ignoreReadError) ? InnerSocket : GetInnerSocket(skipStateCheck: true));
				flag = socket.ReceiveAsync(m_ReadEventArgs);
				if (!flag)
				{
					if (m_ReadEventArgs.SocketError != SocketError.Success)
					{
						if (!m_IgnoreReadError)
						{
							throw new SocketException(m_ReadEventArgs.SocketError);
						}
						return Task.FromResult(0);
					}
					return Task.FromResult(m_ReadEventArgs.BytesTransferred);
				}
				return m_ReadTaskCompletionSource.Task;
			}
			finally
			{
				if (WebSocketBase.LoggingEnabled)
				{
					Logging.Exit(Logging.WebSockets, this, "ReadAsyncCore", flag);
				}
			}
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			if (!m_InOpaqueMode)
			{
				return base.FlushAsync(cancellationToken);
			}
			cancellationToken.ThrowIfCancellationRequested();
			return Task.CompletedTask;
		}

		public void Abort()
		{
		}

		internal static void OnCancel(object state)
		{
			WebSocketConnection webSocketConnection = state as WebSocketConnection;
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Enter(Logging.WebSockets, webSocketConnection, "OnCancel", string.Empty);
			}
			try
			{
				webSocketConnection.m_ReadTaskCompletionSource?.TrySetCanceled();
				webSocketConnection.m_WriteTaskCompletionSource?.TrySetCanceled();
			}
			finally
			{
				if (WebSocketBase.LoggingEnabled)
				{
					Logging.Exit(Logging.WebSockets, webSocketConnection, "OnCancel", string.Empty);
				}
			}
		}

		public void SwitchToOpaqueMode(WebSocketBase webSocket)
		{
			m_WebSocket = webSocket;
			m_InOpaqueMode = true;
			m_ReadEventArgs = new SocketAsyncEventArgs();
			m_ReadEventArgs.UserToken = this;
			m_ReadEventArgs.Completed += s_OnReadCompleted;
			m_WriteEventArgs = new SocketAsyncEventArgs();
			m_WriteEventArgs.UserToken = this;
			m_WriteEventArgs.Completed += s_OnWriteCompleted;
		}

		private static string GetIOCompletionTraceMsg(SocketAsyncEventArgs eventArgs)
		{
			return string.Format(CultureInfo.InvariantCulture, "LastOperation: {0}, SocketError: {1}", new object[2] { eventArgs.LastOperation, eventArgs.SocketError });
		}

		private static void OnWriteCompleted(object sender, SocketAsyncEventArgs eventArgs)
		{
			WebSocketConnection webSocketConnection = eventArgs.UserToken as WebSocketConnection;
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Enter(Logging.WebSockets, webSocketConnection, "OnWriteCompleted", GetIOCompletionTraceMsg(eventArgs));
			}
			if (eventArgs.SocketError != SocketError.Success)
			{
				webSocketConnection.m_WriteTaskCompletionSource.TrySetException(new SocketException(eventArgs.SocketError));
			}
			else
			{
				webSocketConnection.m_WriteTaskCompletionSource.TrySetResult(null);
			}
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, webSocketConnection, "OnWriteCompleted", string.Empty);
			}
		}

		private static void OnReadCompleted(object sender, SocketAsyncEventArgs eventArgs)
		{
			WebSocketConnection webSocketConnection = eventArgs.UserToken as WebSocketConnection;
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Enter(Logging.WebSockets, webSocketConnection, "OnReadCompleted", GetIOCompletionTraceMsg(eventArgs));
			}
			if (eventArgs.SocketError != SocketError.Success)
			{
				if (!webSocketConnection.m_IgnoreReadError)
				{
					webSocketConnection.m_ReadTaskCompletionSource.TrySetException(new SocketException(eventArgs.SocketError));
				}
				else
				{
					webSocketConnection.m_ReadTaskCompletionSource.TrySetResult(0);
				}
			}
			else
			{
				webSocketConnection.m_ReadTaskCompletionSource.TrySetResult(eventArgs.BytesTransferred);
			}
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, webSocketConnection, "OnReadCompleted", string.Empty);
			}
		}
	}

	private static readonly Func<Exception, bool> s_CanHandleException = CanHandleException;

	private static readonly Action<object> s_OnCancel = OnCancel;

	private static readonly Action<object> s_OnCancelWebSocketConnection = WebSocketConnection.OnCancel;

	private static readonly Type s_NetworkStreamType = typeof(NetworkStream);

	private readonly ConnectStream m_ConnectStream;

	private readonly string m_ConnectionGroupName;

	private readonly bool m_IsFastPathAllowed;

	private readonly object m_CloseConnectStreamLock;

	private bool m_InOpaqueMode;

	private WebSocketConnection m_WebSocketConnection;

	public override bool CanSeek => false;

	public override bool CanRead => true;

	public override bool CanWrite => true;

	public bool SupportsMultipleWrite => ((WebSocketConnection)base.BaseStream).SupportsMultipleWrite;

	public WebSocketConnectionStream(ConnectStream connectStream, string connectionGroupName)
		: base(new WebSocketConnection(connectStream.Connection), readMore: false)
	{
		m_ConnectStream = connectStream;
		m_ConnectionGroupName = connectionGroupName;
		m_CloseConnectStreamLock = new object();
		m_IsFastPathAllowed = m_ConnectStream.Connection.NetworkStream.GetType() == s_NetworkStreamType;
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Associate(Logging.WebSockets, this, m_ConnectStream.Connection);
		}
		ConsumeConnectStreamBuffer(connectStream);
	}

	public async Task CloseNetworkConnectionAsync(CancellationToken cancellationToken)
	{
		await Task.Yield();
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, this, "CloseNetworkConnectionAsync", string.Empty);
		}
		CancellationTokenSource reasonableTimeoutCancellationTokenSource = null;
		CancellationTokenSource linkedCancellationTokenSource = null;
		_ = CancellationToken.None;
		CancellationTokenRegistration cancellationTokenRegistration = default(CancellationTokenRegistration);
		int bytesRead = 0;
		try
		{
			reasonableTimeoutCancellationTokenSource = new CancellationTokenSource(1000);
			linkedCancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(reasonableTimeoutCancellationTokenSource.Token, cancellationToken);
			CancellationToken token = linkedCancellationTokenSource.Token;
			cancellationTokenRegistration = token.Register(s_OnCancel, this, useSynchronizationContext: false);
			WebSocketHelpers.ThrowIfConnectionAborted(m_ConnectStream.Connection, read: true);
			byte[] buffer = new byte[1];
			bytesRead = ((m_WebSocketConnection == null || !m_InOpaqueMode) ? (await base.ReadAsync(buffer, 0, 1, token).SuppressContextFlow()) : (await m_WebSocketConnection.ReadAsyncCore(buffer, 0, 1, token, ignoreReadError: true).SuppressContextFlow()));
			if (bytesRead != 0)
			{
				if (WebSocketBase.LoggingEnabled)
				{
					Logging.Dump(Logging.WebSockets, this, "CloseNetworkConnectionAsync", buffer, 0, bytesRead);
				}
				throw new WebSocketException(WebSocketError.NotAWebSocket);
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
			linkedCancellationTokenSource?.Dispose();
			reasonableTimeoutCancellationTokenSource?.Dispose();
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, this, "CloseNetworkConnectionAsync", bytesRead);
			}
		}
	}

	public override void Close()
	{
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, this, "Close", string.Empty);
		}
		try
		{
			lock (m_CloseConnectStreamLock)
			{
				m_ConnectStream.Connection.ServicePoint.CloseConnectionGroup(m_ConnectionGroupName);
			}
			base.Close();
		}
		finally
		{
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, this, "Close", string.Empty);
			}
		}
	}

	public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, this, "ReadAsync", WebSocketHelpers.GetTraceMsgForParameters(offset, count, cancellationToken));
		}
		CancellationTokenRegistration cancellationTokenRegistration = default(CancellationTokenRegistration);
		int bytesRead = 0;
		try
		{
			if (cancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration = cancellationToken.Register(s_OnCancel, this, useSynchronizationContext: false);
			}
			WebSocketHelpers.ThrowIfConnectionAborted(m_ConnectStream.Connection, read: true);
			bytesRead = await base.ReadAsync(buffer, offset, count, cancellationToken).SuppressContextFlow();
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Dump(Logging.WebSockets, this, "ReadAsync", buffer, offset, bytesRead);
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
				Logging.Exit(Logging.WebSockets, this, "ReadAsync", bytesRead);
			}
		}
		return bytesRead;
	}

	public override async Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, this, "WriteAsync", WebSocketHelpers.GetTraceMsgForParameters(offset, count, cancellationToken));
		}
		CancellationTokenRegistration cancellationTokenRegistration = default(CancellationTokenRegistration);
		try
		{
			if (cancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration = cancellationToken.Register(s_OnCancel, this, useSynchronizationContext: false);
			}
			WebSocketHelpers.ThrowIfConnectionAborted(m_ConnectStream.Connection, read: false);
			await base.WriteAsync(buffer, offset, count, cancellationToken).SuppressContextFlow();
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Dump(Logging.WebSockets, this, "WriteAsync", buffer, offset, count);
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
				Logging.Exit(Logging.WebSockets, this, "WriteAsync", string.Empty);
			}
		}
	}

	public void SwitchToOpaqueMode(WebSocketBase webSocket)
	{
		if (m_InOpaqueMode)
		{
			throw new InvalidOperationException();
		}
		m_WebSocketConnection = base.BaseStream as WebSocketConnection;
		if (m_WebSocketConnection != null && m_IsFastPathAllowed)
		{
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Associate(Logging.WebSockets, this, m_WebSocketConnection);
			}
			m_WebSocketConnection.SwitchToOpaqueMode(webSocket);
			m_InOpaqueMode = true;
		}
	}

	public async Task MultipleWriteAsync(IList<ArraySegment<byte>> sendBuffers, CancellationToken cancellationToken)
	{
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, this, "MultipleWriteAsync", string.Empty);
		}
		CancellationTokenRegistration cancellationTokenRegistration = default(CancellationTokenRegistration);
		try
		{
			if (cancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration = cancellationToken.Register(s_OnCancel, this, useSynchronizationContext: false);
			}
			WebSocketHelpers.ThrowIfConnectionAborted(m_ConnectStream.Connection, read: false);
			await ((WebSocketBase.IWebSocketStream)base.BaseStream).MultipleWriteAsync(sendBuffers, cancellationToken).SuppressContextFlow();
			if (!WebSocketBase.LoggingEnabled)
			{
				return;
			}
			foreach (ArraySegment<byte> sendBuffer in sendBuffers)
			{
				Logging.Dump(Logging.WebSockets, this, "MultipleWriteAsync", sendBuffer.Array, sendBuffer.Offset, sendBuffer.Count);
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
				Logging.Exit(Logging.WebSockets, this, "MultipleWriteAsync", string.Empty);
			}
		}
	}

	private static bool CanHandleException(Exception error)
	{
		if (!(error is SocketException) && !(error is ObjectDisposedException) && !(error is WebException))
		{
			return error is IOException;
		}
		return true;
	}

	private static void OnCancel(object state)
	{
		WebSocketConnectionStream webSocketConnectionStream = state as WebSocketConnectionStream;
		if (WebSocketBase.LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, state, "OnCancel", string.Empty);
		}
		try
		{
			lock (webSocketConnectionStream.m_CloseConnectStreamLock)
			{
				webSocketConnectionStream.m_ConnectStream.Connection.NetworkStream.InternalAbortSocket();
				((ICloseEx)webSocketConnectionStream.m_ConnectStream).CloseEx(CloseExState.Abort);
			}
			webSocketConnectionStream.CancelWebSocketConnection();
		}
		catch
		{
		}
		finally
		{
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, state, "OnCancel", string.Empty);
			}
		}
	}

	private void CancelWebSocketConnection()
	{
		if (m_InOpaqueMode)
		{
			WebSocketConnection obj = (WebSocketConnection)base.BaseStream;
			s_OnCancelWebSocketConnection(obj);
		}
	}

	public void Abort()
	{
		OnCancel(this);
	}

	private void ConsumeConnectStreamBuffer(ConnectStream connectStream)
	{
		if (connectStream.Eof)
		{
			return;
		}
		byte[] array = new byte[1024];
		int offset = 0;
		int size = array.Length;
		int num;
		while ((num = connectStream.FillFromBufferedData(array, ref offset, ref size)) > 0)
		{
			if (WebSocketBase.LoggingEnabled)
			{
				Logging.Dump(Logging.WebSockets, this, "ConsumeConnectStreamBuffer", array, 0, num);
			}
			Append(array, 0, num);
			offset = 0;
			size = array.Length;
		}
	}
}
