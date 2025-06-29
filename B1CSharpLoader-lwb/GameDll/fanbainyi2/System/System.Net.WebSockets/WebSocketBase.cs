using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.WebSockets;

internal abstract class WebSocketBase : WebSocket, IDisposable
{
	private abstract class WebSocketOperation
	{
		public class ReceiveOperation : WebSocketOperation
		{
			private int m_ReceiveState;

			private bool m_PongReceived;

			private bool m_ReceiveCompleted;

			protected override WebSocketProtocolComponent.ActionQueue ActionQueue => WebSocketProtocolComponent.ActionQueue.Receive;

			protected override int BufferCount => 1;

			public ReceiveOperation(WebSocketBase webSocket)
				: base(webSocket)
			{
			}

			protected override void Initialize(ArraySegment<byte>? buffer, CancellationToken cancellationToken)
			{
				m_PongReceived = false;
				m_ReceiveCompleted = false;
				m_WebSocket.ThrowIfDisposed();
				switch (Interlocked.CompareExchange(ref m_WebSocket.m_ReceiveState, 1, 0))
				{
				case 0:
					m_ReceiveState = 1;
					break;
				case 2:
				{
					if (!m_WebSocket.m_InternalBuffer.ReceiveFromBufferedPayload(buffer.Value, out var receiveResult))
					{
						m_WebSocket.UpdateReceiveState(0, 2);
					}
					base.ReceiveResult = receiveResult;
					m_ReceiveCompleted = true;
					break;
				}
				case 1:
					break;
				}
			}

			protected override void Cleanup()
			{
			}

			protected override bool ShouldContinue(CancellationToken cancellationToken)
			{
				cancellationToken.ThrowIfCancellationRequested();
				if (m_ReceiveCompleted)
				{
					return false;
				}
				m_WebSocket.ThrowIfDisposed();
				m_WebSocket.ThrowIfPendingException();
				WebSocketProtocolComponent.WebSocketReceive(m_WebSocket);
				return true;
			}

			protected override bool ProcessAction_NoAction()
			{
				if (m_PongReceived)
				{
					m_ReceiveCompleted = false;
					m_PongReceived = false;
					return false;
				}
				m_ReceiveCompleted = true;
				if (base.ReceiveResult.MessageType == WebSocketMessageType.Close)
				{
					return true;
				}
				return false;
			}

			protected override void ProcessAction_IndicateReceiveComplete(ArraySegment<byte>? buffer, WebSocketProtocolComponent.BufferType bufferType, WebSocketProtocolComponent.Action action, WebSocketProtocolComponent.Buffer[] dataBuffers, uint dataBufferCount, IntPtr actionContext)
			{
				int num = 0;
				m_PongReceived = false;
				if (bufferType == WebSocketProtocolComponent.BufferType.PingPong)
				{
					m_PongReceived = true;
					WebSocketProtocolComponent.WebSocketCompleteAction(m_WebSocket, actionContext, num);
					return;
				}
				WebSocketReceiveResult receiveResult;
				try
				{
					WebSocketMessageType messageType = GetMessageType(bufferType);
					int newReceiveState = 0;
					if (bufferType == WebSocketProtocolComponent.BufferType.Close)
					{
						ArraySegment<byte> emptyPayload = WebSocketHelpers.EmptyPayload;
						m_WebSocket.m_InternalBuffer.ConvertCloseBuffer(action, dataBuffers[0], out var closeStatus, out var reason);
						receiveResult = new WebSocketReceiveResult(num, messageType, endOfMessage: true, closeStatus, reason);
					}
					else
					{
						ArraySegment<byte> emptyPayload = m_WebSocket.m_InternalBuffer.ConvertNativeBuffer(action, dataBuffers[0], bufferType);
						bool endOfMessage = bufferType == WebSocketProtocolComponent.BufferType.BinaryMessage || bufferType == WebSocketProtocolComponent.BufferType.UTF8Message || bufferType == WebSocketProtocolComponent.BufferType.Close;
						if (emptyPayload.Count > buffer.Value.Count)
						{
							m_WebSocket.m_InternalBuffer.BufferPayload(emptyPayload, buffer.Value.Count, messageType, endOfMessage);
							newReceiveState = 2;
							endOfMessage = false;
						}
						num = Math.Min(emptyPayload.Count, buffer.Value.Count);
						if (num > 0)
						{
							Buffer.BlockCopy(emptyPayload.Array, emptyPayload.Offset, buffer.Value.Array, buffer.Value.Offset, num);
						}
						receiveResult = new WebSocketReceiveResult(num, messageType, endOfMessage);
					}
					m_WebSocket.UpdateReceiveState(newReceiveState, m_ReceiveState);
				}
				finally
				{
					WebSocketProtocolComponent.WebSocketCompleteAction(m_WebSocket, actionContext, num);
				}
				base.ReceiveResult = receiveResult;
			}
		}

		public class SendOperation : WebSocketOperation
		{
			protected bool m_BufferHasBeenPinned;

			protected override WebSocketProtocolComponent.ActionQueue ActionQueue => WebSocketProtocolComponent.ActionQueue.Send;

			protected override int BufferCount => 2;

			internal WebSocketProtocolComponent.BufferType BufferType { get; set; }

			public SendOperation(WebSocketBase webSocket)
				: base(webSocket)
			{
			}

			protected virtual WebSocketProtocolComponent.Buffer? CreateBuffer(ArraySegment<byte>? buffer)
			{
				if (!buffer.HasValue)
				{
					return null;
				}
				WebSocketProtocolComponent.Buffer value = default(WebSocketProtocolComponent.Buffer);
				m_WebSocket.m_InternalBuffer.PinSendBuffer(buffer.Value, out m_BufferHasBeenPinned);
				value.Data.BufferData = m_WebSocket.m_InternalBuffer.ConvertPinnedSendPayloadToNative(buffer.Value);
				value.Data.BufferLength = (uint)buffer.Value.Count;
				return value;
			}

			protected override bool ProcessAction_NoAction()
			{
				return false;
			}

			protected override void Cleanup()
			{
				if (m_BufferHasBeenPinned)
				{
					m_BufferHasBeenPinned = false;
					m_WebSocket.m_InternalBuffer.ReleasePinnedSendBuffer();
				}
			}

			protected override void Initialize(ArraySegment<byte>? buffer, CancellationToken cancellationToken)
			{
				m_WebSocket.ThrowIfDisposed();
				m_WebSocket.ThrowIfPendingException();
				WebSocketProtocolComponent.Buffer? buffer2 = CreateBuffer(buffer);
				if (buffer2.HasValue)
				{
					WebSocketProtocolComponent.WebSocketSend(m_WebSocket, BufferType, buffer2.Value);
				}
				else
				{
					WebSocketProtocolComponent.WebSocketSendWithoutBody(m_WebSocket, BufferType);
				}
			}

			protected override bool ShouldContinue(CancellationToken cancellationToken)
			{
				if (base.AsyncOperationCompleted)
				{
					return false;
				}
				cancellationToken.ThrowIfCancellationRequested();
				return true;
			}
		}

		public class CloseOutputOperation : SendOperation
		{
			internal WebSocketCloseStatus CloseStatus { get; set; }

			internal string CloseReason { get; set; }

			public CloseOutputOperation(WebSocketBase webSocket)
				: base(webSocket)
			{
				base.BufferType = WebSocketProtocolComponent.BufferType.Close;
			}

			protected override WebSocketProtocolComponent.Buffer? CreateBuffer(ArraySegment<byte>? buffer)
			{
				m_WebSocket.ThrowIfDisposed();
				m_WebSocket.ThrowIfPendingException();
				if (CloseStatus == WebSocketCloseStatus.Empty)
				{
					return null;
				}
				WebSocketProtocolComponent.Buffer value = default(WebSocketProtocolComponent.Buffer);
				if (CloseReason != null)
				{
					byte[] bytes = Encoding.UTF8.GetBytes(CloseReason);
					ArraySegment<byte> payload = new ArraySegment<byte>(bytes, 0, Math.Min(123, bytes.Length));
					m_WebSocket.m_InternalBuffer.PinSendBuffer(payload, out m_BufferHasBeenPinned);
					value.CloseStatus.ReasonData = m_WebSocket.m_InternalBuffer.ConvertPinnedSendPayloadToNative(payload);
					value.CloseStatus.ReasonLength = (uint)payload.Count;
				}
				value.CloseStatus.CloseStatus = (ushort)CloseStatus;
				return value;
			}
		}

		private readonly WebSocketBase m_WebSocket;

		protected bool AsyncOperationCompleted { get; set; }

		public WebSocketReceiveResult ReceiveResult { get; protected set; }

		protected abstract int BufferCount { get; }

		protected abstract WebSocketProtocolComponent.ActionQueue ActionQueue { get; }

		internal WebSocketOperation(WebSocketBase webSocket)
		{
			m_WebSocket = webSocket;
			AsyncOperationCompleted = false;
		}

		protected abstract void Initialize(ArraySegment<byte>? buffer, CancellationToken cancellationToken);

		protected abstract bool ShouldContinue(CancellationToken cancellationToken);

		protected abstract bool ProcessAction_NoAction();

		protected virtual void ProcessAction_IndicateReceiveComplete(ArraySegment<byte>? buffer, WebSocketProtocolComponent.BufferType bufferType, WebSocketProtocolComponent.Action action, WebSocketProtocolComponent.Buffer[] dataBuffers, uint dataBufferCount, IntPtr actionContext)
		{
			throw new NotImplementedException();
		}

		protected abstract void Cleanup();

		internal async Task<WebSocketReceiveResult> Process(ArraySegment<byte>? buffer, CancellationToken cancellationToken)
		{
			bool sessionHandleLockTaken = false;
			AsyncOperationCompleted = false;
			ReceiveResult = null;
			try
			{
				Monitor.Enter(m_WebSocket.SessionHandle, ref sessionHandleLockTaken);
				m_WebSocket.ThrowIfPendingException();
				Initialize(buffer, cancellationToken);
				while (ShouldContinue(cancellationToken))
				{
					bool completed = false;
					while (!completed)
					{
						WebSocketProtocolComponent.Buffer[] array = new WebSocketProtocolComponent.Buffer[BufferCount];
						uint dataBufferCount = (uint)BufferCount;
						m_WebSocket.ThrowIfDisposed();
						WebSocketProtocolComponent.WebSocketGetAction(m_WebSocket, ActionQueue, array, ref dataBufferCount, out var action, out var bufferType, out var actionContext);
						switch (action)
						{
						case WebSocketProtocolComponent.Action.NoAction:
							if (ProcessAction_NoAction())
							{
								bool thisLockTaken = false;
								try
								{
									if (m_WebSocket.StartOnCloseReceived(ref thisLockTaken))
									{
										ReleaseLock(m_WebSocket.SessionHandle, ref sessionHandleLockTaken);
										bool flag;
										try
										{
											flag = await m_WebSocket.StartOnCloseCompleted(thisLockTaken, sessionHandleLockTaken, cancellationToken).SuppressContextFlow();
										}
										catch (Exception)
										{
											m_WebSocket.ResetFlagAndTakeLock(m_WebSocket.m_ThisLock, ref thisLockTaken);
											throw;
										}
										if (flag)
										{
											m_WebSocket.ResetFlagAndTakeLock(m_WebSocket.m_ThisLock, ref thisLockTaken);
											m_WebSocket.FinishOnCloseCompleted();
										}
									}
									m_WebSocket.FinishOnCloseReceived(ReceiveResult.CloseStatus.Value, ReceiveResult.CloseStatusDescription);
								}
								finally
								{
									if (thisLockTaken)
									{
										ReleaseLock(m_WebSocket.m_ThisLock, ref thisLockTaken);
									}
								}
							}
							completed = true;
							break;
						case WebSocketProtocolComponent.Action.IndicateReceiveComplete:
							ProcessAction_IndicateReceiveComplete(buffer, bufferType, action, array, dataBufferCount, actionContext);
							break;
						case WebSocketProtocolComponent.Action.ReceiveFromNetwork:
						{
							int count = 0;
							try
							{
								ArraySegment<byte> arraySegment = m_WebSocket.m_InternalBuffer.ConvertNativeBuffer(action, array[0], bufferType);
								ReleaseLock(m_WebSocket.SessionHandle, ref sessionHandleLockTaken);
								WebSocketHelpers.ThrowIfConnectionAborted(m_WebSocket.m_InnerStream, read: true);
								try
								{
									Task<int> task = m_WebSocket.m_InnerStream.ReadAsync(arraySegment.Array, arraySegment.Offset, arraySegment.Count, cancellationToken);
									count = await task.SuppressContextFlow();
									m_WebSocket.m_KeepAliveTracker.OnDataReceived();
								}
								catch (ObjectDisposedException innerException)
								{
									throw new WebSocketException(WebSocketError.ConnectionClosedPrematurely, innerException);
								}
								catch (NotSupportedException innerException2)
								{
									throw new WebSocketException(WebSocketError.ConnectionClosedPrematurely, innerException2);
								}
								Monitor.Enter(m_WebSocket.SessionHandle, ref sessionHandleLockTaken);
								m_WebSocket.ThrowIfPendingException();
								if (count == 0)
								{
									throw new WebSocketException(WebSocketError.ConnectionClosedPrematurely);
								}
							}
							finally
							{
								WebSocketProtocolComponent.WebSocketCompleteAction(m_WebSocket, actionContext, count);
							}
							break;
						}
						case WebSocketProtocolComponent.Action.IndicateSendComplete:
							WebSocketProtocolComponent.WebSocketCompleteAction(m_WebSocket, actionContext, 0);
							AsyncOperationCompleted = true;
							ReleaseLock(m_WebSocket.SessionHandle, ref sessionHandleLockTaken);
							await m_WebSocket.m_InnerStream.FlushAsync().SuppressContextFlow();
							Monitor.Enter(m_WebSocket.SessionHandle, ref sessionHandleLockTaken);
							break;
						case WebSocketProtocolComponent.Action.SendToNetwork:
						{
							int bytesSent = 0;
							try
							{
								if ((m_WebSocket.State != WebSocketState.CloseSent || (bufferType != WebSocketProtocolComponent.BufferType.PingPong && bufferType != WebSocketProtocolComponent.BufferType.UnsolicitedPong)) && dataBufferCount != 0)
								{
									List<ArraySegment<byte>> list = new List<ArraySegment<byte>>((int)dataBufferCount);
									int sendBufferSize = 0;
									ArraySegment<byte> item = m_WebSocket.m_InternalBuffer.ConvertNativeBuffer(action, array[0], bufferType);
									list.Add(item);
									sendBufferSize += item.Count;
									if (dataBufferCount == 2)
									{
										ArraySegment<byte> item2 = ((!m_WebSocket.m_InternalBuffer.IsPinnedSendPayloadBuffer(array[1], bufferType)) ? m_WebSocket.m_InternalBuffer.ConvertNativeBuffer(action, array[1], bufferType) : m_WebSocket.m_InternalBuffer.ConvertPinnedSendPayloadFromNative(array[1], bufferType));
										list.Add(item2);
										sendBufferSize += item2.Count;
									}
									ReleaseLock(m_WebSocket.SessionHandle, ref sessionHandleLockTaken);
									WebSocketHelpers.ThrowIfConnectionAborted(m_WebSocket.m_InnerStream, read: false);
									await m_WebSocket.SendFrameAsync(list, cancellationToken).SuppressContextFlow();
									Monitor.Enter(m_WebSocket.SessionHandle, ref sessionHandleLockTaken);
									m_WebSocket.ThrowIfPendingException();
									bytesSent += sendBufferSize;
									m_WebSocket.m_KeepAliveTracker.OnDataSent();
								}
							}
							finally
							{
								WebSocketProtocolComponent.WebSocketCompleteAction(m_WebSocket, actionContext, bytesSent);
							}
							break;
						}
						default:
							string.Format(CultureInfo.InvariantCulture, "Invalid action '{0}' returned from WebSocketGetAction.", new object[1] { action });
							throw new InvalidOperationException();
						}
					}
					ReleaseLock(m_WebSocket.SessionHandle, ref sessionHandleLockTaken);
					Monitor.Enter(m_WebSocket.SessionHandle, ref sessionHandleLockTaken);
				}
			}
			finally
			{
				Cleanup();
				ReleaseLock(m_WebSocket.SessionHandle, ref sessionHandleLockTaken);
			}
			return ReceiveResult;
		}
	}

	private abstract class KeepAliveTracker : IDisposable
	{
		private class DisabledKeepAliveTracker : KeepAliveTracker
		{
			public override void OnDataReceived()
			{
			}

			public override void OnDataSent()
			{
			}

			public override void ResetTimer()
			{
			}

			public override void StartTimer(WebSocketBase webSocket)
			{
			}

			public override bool ShouldSendKeepAlive()
			{
				return false;
			}

			public override void Dispose()
			{
			}
		}

		private class DefaultKeepAliveTracker : KeepAliveTracker
		{
			private static readonly TimerCallback s_KeepAliveTimerElapsedCallback = OnKeepAlive;

			private readonly TimeSpan m_KeepAliveInterval;

			private readonly Stopwatch m_LastSendActivity;

			private readonly Stopwatch m_LastReceiveActivity;

			private Timer m_KeepAliveTimer;

			public DefaultKeepAliveTracker(TimeSpan keepAliveInterval)
			{
				m_KeepAliveInterval = keepAliveInterval;
				m_LastSendActivity = new Stopwatch();
				m_LastReceiveActivity = new Stopwatch();
			}

			public override void OnDataReceived()
			{
				m_LastReceiveActivity.Restart();
			}

			public override void OnDataSent()
			{
				m_LastSendActivity.Restart();
			}

			public override void ResetTimer()
			{
				ResetTimer((int)m_KeepAliveInterval.TotalMilliseconds);
			}

			public override void StartTimer(WebSocketBase webSocket)
			{
				int dueTime = (int)m_KeepAliveInterval.TotalMilliseconds;
				if (ExecutionContext.IsFlowSuppressed())
				{
					m_KeepAliveTimer = new Timer(s_KeepAliveTimerElapsedCallback, webSocket, -1, -1);
					m_KeepAliveTimer.Change(dueTime, -1);
					return;
				}
				using (ExecutionContext.SuppressFlow())
				{
					m_KeepAliveTimer = new Timer(s_KeepAliveTimerElapsedCallback, webSocket, -1, -1);
					m_KeepAliveTimer.Change(dueTime, -1);
				}
			}

			public override bool ShouldSendKeepAlive()
			{
				TimeSpan idleTime = GetIdleTime();
				if (idleTime >= m_KeepAliveInterval)
				{
					return true;
				}
				ResetTimer((int)(m_KeepAliveInterval - idleTime).TotalMilliseconds);
				return false;
			}

			public override void Dispose()
			{
				m_KeepAliveTimer.Dispose();
			}

			private void ResetTimer(int dueInMilliseconds)
			{
				m_KeepAliveTimer.Change(dueInMilliseconds, -1);
			}

			private TimeSpan GetIdleTime()
			{
				TimeSpan timeElapsed = GetTimeElapsed(m_LastSendActivity);
				TimeSpan timeElapsed2 = GetTimeElapsed(m_LastReceiveActivity);
				if (timeElapsed2 < timeElapsed)
				{
					return timeElapsed2;
				}
				return timeElapsed;
			}

			private TimeSpan GetTimeElapsed(Stopwatch watch)
			{
				if (watch.IsRunning)
				{
					return watch.Elapsed;
				}
				return m_KeepAliveInterval;
			}
		}

		public abstract void OnDataReceived();

		public abstract void OnDataSent();

		public abstract void Dispose();

		public abstract void StartTimer(WebSocketBase webSocket);

		public abstract void ResetTimer();

		public abstract bool ShouldSendKeepAlive();

		public static KeepAliveTracker Create(TimeSpan keepAliveInterval)
		{
			if ((int)keepAliveInterval.TotalMilliseconds > 0)
			{
				return new DefaultKeepAliveTracker(keepAliveInterval);
			}
			return new DisabledKeepAliveTracker();
		}
	}

	private class OutstandingOperationHelper : IDisposable
	{
		private volatile int m_OperationsOutstanding;

		private volatile CancellationTokenSource m_CancellationTokenSource;

		private volatile bool m_IsDisposed;

		private readonly object m_ThisLock = new object();

		public bool TryStartOperation(CancellationToken userCancellationToken, out CancellationToken linkedCancellationToken)
		{
			linkedCancellationToken = CancellationToken.None;
			ThrowIfDisposed();
			lock (m_ThisLock)
			{
				if (++m_OperationsOutstanding == 1)
				{
					linkedCancellationToken = CreateLinkedCancellationToken(userCancellationToken);
					return true;
				}
				return false;
			}
		}

		public void CompleteOperation(bool ownsCancellationTokenSource)
		{
			if (m_IsDisposed)
			{
				return;
			}
			CancellationTokenSource cancellationTokenSource = null;
			lock (m_ThisLock)
			{
				m_OperationsOutstanding--;
				if (ownsCancellationTokenSource)
				{
					cancellationTokenSource = m_CancellationTokenSource;
					m_CancellationTokenSource = null;
				}
			}
			cancellationTokenSource?.Dispose();
		}

		private CancellationToken CreateLinkedCancellationToken(CancellationToken cancellationToken)
		{
			return (m_CancellationTokenSource = ((!(cancellationToken == CancellationToken.None)) ? CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, new CancellationTokenSource().Token) : new CancellationTokenSource())).Token;
		}

		public void CancelIO()
		{
			CancellationTokenSource cancellationTokenSource = null;
			lock (m_ThisLock)
			{
				if (m_OperationsOutstanding == 0)
				{
					return;
				}
				cancellationTokenSource = m_CancellationTokenSource;
			}
			if (cancellationTokenSource != null)
			{
				try
				{
					cancellationTokenSource.Cancel();
				}
				catch (ObjectDisposedException)
				{
				}
			}
		}

		public void Dispose()
		{
			if (m_IsDisposed)
			{
				return;
			}
			CancellationTokenSource cancellationTokenSource = null;
			lock (m_ThisLock)
			{
				if (m_IsDisposed)
				{
					return;
				}
				m_IsDisposed = true;
				cancellationTokenSource = m_CancellationTokenSource;
				m_CancellationTokenSource = null;
			}
			cancellationTokenSource?.Dispose();
		}

		private void ThrowIfDisposed()
		{
			if (m_IsDisposed)
			{
				throw new ObjectDisposedException(GetType().FullName);
			}
		}
	}

	internal interface IWebSocketStream
	{
		bool SupportsMultipleWrite { get; }

		void SwitchToOpaqueMode(WebSocketBase webSocket);

		void Abort();

		Task MultipleWriteAsync(IList<ArraySegment<byte>> buffers, CancellationToken cancellationToken);

		Task CloseNetworkConnectionAsync(CancellationToken cancellationToken);
	}

	private static class ReceiveState
	{
		internal const int SendOperation = -1;

		internal const int Idle = 0;

		internal const int Application = 1;

		internal const int PayloadAvailable = 2;
	}

	internal static class Methods
	{
		internal const string ReceiveAsync = "ReceiveAsync";

		internal const string SendAsync = "SendAsync";

		internal const string CloseAsync = "CloseAsync";

		internal const string CloseOutputAsync = "CloseOutputAsync";

		internal const string Abort = "Abort";

		internal const string Initialize = "Initialize";

		internal const string Fault = "Fault";

		internal const string StartOnCloseCompleted = "StartOnCloseCompleted";

		internal const string FinishOnCloseReceived = "FinishOnCloseReceived";

		internal const string OnKeepAlive = "OnKeepAlive";
	}

	private static volatile bool s_LoggingEnabled;

	private readonly OutstandingOperationHelper m_CloseOutstandingOperationHelper;

	private readonly OutstandingOperationHelper m_CloseOutputOutstandingOperationHelper;

	private readonly OutstandingOperationHelper m_ReceiveOutstandingOperationHelper;

	private readonly OutstandingOperationHelper m_SendOutstandingOperationHelper;

	private readonly Stream m_InnerStream;

	private readonly IWebSocketStream m_InnerStreamAsWebSocketStream;

	private readonly string m_SubProtocol;

	private readonly SemaphoreSlim m_SendFrameThrottle;

	private readonly object m_ThisLock;

	private readonly WebSocketBuffer m_InternalBuffer;

	private readonly KeepAliveTracker m_KeepAliveTracker;

	private volatile bool m_CleanedUp;

	private volatile TaskCompletionSource<object> m_CloseReceivedTaskCompletionSource;

	private volatile Task m_CloseOutputTask;

	private volatile bool m_IsDisposed;

	private volatile Task m_CloseNetworkConnectionTask;

	private volatile bool m_CloseAsyncStartedReceive;

	private volatile WebSocketState m_State;

	private volatile Task m_KeepAliveTask;

	private volatile WebSocketOperation.ReceiveOperation m_ReceiveOperation;

	private volatile WebSocketOperation.SendOperation m_SendOperation;

	private volatile WebSocketOperation.SendOperation m_KeepAliveOperation;

	private volatile WebSocketOperation.CloseOutputOperation m_CloseOutputOperation;

	private WebSocketCloseStatus? m_CloseStatus;

	private string m_CloseStatusDescription;

	private int m_ReceiveState;

	private Exception m_PendingException;

	internal static bool LoggingEnabled => s_LoggingEnabled;

	public override WebSocketState State => m_State;

	public override string SubProtocol => m_SubProtocol;

	public override WebSocketCloseStatus? CloseStatus => m_CloseStatus;

	public override string CloseStatusDescription => m_CloseStatusDescription;

	internal WebSocketBuffer InternalBuffer => m_InternalBuffer;

	internal abstract SafeHandle SessionHandle { get; }

	protected WebSocketBase(Stream innerStream, string subProtocol, TimeSpan keepAliveInterval, WebSocketBuffer internalBuffer)
	{
		WebSocketHelpers.ValidateInnerStream(innerStream);
		WebSocketHelpers.ValidateOptions(subProtocol, internalBuffer.ReceiveBufferSize, internalBuffer.SendBufferSize, keepAliveInterval);
		s_LoggingEnabled = Logging.On && Logging.WebSockets.Switch.ShouldTrace(TraceEventType.Critical);
		string text = string.Empty;
		if (s_LoggingEnabled)
		{
			text = string.Format(CultureInfo.InvariantCulture, "ReceiveBufferSize: {0}, SendBufferSize: {1},  Protocols: {2}, KeepAliveInterval: {3}, innerStream: {4}, internalBuffer: {5}", internalBuffer.ReceiveBufferSize, internalBuffer.SendBufferSize, subProtocol, keepAliveInterval, Logging.GetObjectLogHash(innerStream), Logging.GetObjectLogHash(internalBuffer));
			Logging.Enter(Logging.WebSockets, this, "Initialize", text);
		}
		m_ThisLock = new object();
		try
		{
			m_InnerStream = innerStream;
			m_InternalBuffer = internalBuffer;
			if (s_LoggingEnabled)
			{
				Logging.Associate(Logging.WebSockets, this, m_InnerStream);
				Logging.Associate(Logging.WebSockets, this, m_InternalBuffer);
			}
			m_CloseOutstandingOperationHelper = new OutstandingOperationHelper();
			m_CloseOutputOutstandingOperationHelper = new OutstandingOperationHelper();
			m_ReceiveOutstandingOperationHelper = new OutstandingOperationHelper();
			m_SendOutstandingOperationHelper = new OutstandingOperationHelper();
			m_State = WebSocketState.Open;
			m_SubProtocol = subProtocol;
			m_SendFrameThrottle = new SemaphoreSlim(1, 1);
			m_CloseStatus = null;
			m_CloseStatusDescription = null;
			m_InnerStreamAsWebSocketStream = innerStream as IWebSocketStream;
			if (m_InnerStreamAsWebSocketStream != null)
			{
				m_InnerStreamAsWebSocketStream.SwitchToOpaqueMode(this);
			}
			m_KeepAliveTracker = KeepAliveTracker.Create(keepAliveInterval);
		}
		finally
		{
			if (s_LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, this, "Initialize", text);
			}
		}
	}

	protected void StartKeepAliveTimer()
	{
		m_KeepAliveTracker.StartTimer(this);
	}

	public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
	{
		WebSocketHelpers.ValidateArraySegment(buffer, "buffer");
		return ReceiveAsyncCore(buffer, cancellationToken);
	}

	private async Task<WebSocketReceiveResult> ReceiveAsyncCore(ArraySegment<byte> buffer, CancellationToken cancellationToken)
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, this, "ReceiveAsync", string.Empty);
		}
		try
		{
			ThrowIfPendingException();
			ThrowIfDisposed();
			WebSocket.ThrowOnInvalidState(State, WebSocketState.Open, WebSocketState.CloseSent);
			bool ownsCancellationTokenSource = false;
			CancellationToken linkedCancellationToken = CancellationToken.None;
			WebSocketReceiveResult webSocketReceiveResult;
			try
			{
				ownsCancellationTokenSource = m_ReceiveOutstandingOperationHelper.TryStartOperation(cancellationToken, out linkedCancellationToken);
				if (!ownsCancellationTokenSource)
				{
					lock (m_ThisLock)
					{
						if (m_CloseAsyncStartedReceive)
						{
							throw new InvalidOperationException(SR.GetString("net_WebSockets_ReceiveAsyncDisallowedAfterCloseAsync", "CloseAsync", "CloseOutputAsync"));
						}
						throw new InvalidOperationException(SR.GetString("net_Websockets_AlreadyOneOutstandingOperation", "ReceiveAsync"));
					}
				}
				EnsureReceiveOperation();
				webSocketReceiveResult = await m_ReceiveOperation.Process(buffer, linkedCancellationToken).SuppressContextFlow();
				if (s_LoggingEnabled && webSocketReceiveResult.Count > 0)
				{
					Logging.Dump(Logging.WebSockets, this, "ReceiveAsync", buffer.Array, buffer.Offset, webSocketReceiveResult.Count);
				}
			}
			catch (Exception exception)
			{
				bool isCancellationRequested = linkedCancellationToken.IsCancellationRequested;
				Abort();
				ThrowIfConvertibleException("ReceiveAsync", exception, cancellationToken, isCancellationRequested);
				throw;
			}
			finally
			{
				m_ReceiveOutstandingOperationHelper.CompleteOperation(ownsCancellationTokenSource);
			}
			return webSocketReceiveResult;
		}
		finally
		{
			if (s_LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, this, "ReceiveAsync", string.Empty);
			}
		}
	}

	public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
	{
		if (messageType != WebSocketMessageType.Binary && messageType != WebSocketMessageType.Text)
		{
			throw new ArgumentException(SR.GetString("net_WebSockets_Argument_InvalidMessageType", messageType, "SendAsync", WebSocketMessageType.Binary, WebSocketMessageType.Text, "CloseOutputAsync"), "messageType");
		}
		WebSocketHelpers.ValidateArraySegment(buffer, "buffer");
		return SendAsyncCore(buffer, messageType, endOfMessage, cancellationToken);
	}

	private async Task SendAsyncCore(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
	{
		string inputParameter = string.Empty;
		if (s_LoggingEnabled)
		{
			inputParameter = string.Format(CultureInfo.InvariantCulture, "messageType: {0}, endOfMessage: {1}", new object[2] { messageType, endOfMessage });
			Logging.Enter(Logging.WebSockets, this, "SendAsync", inputParameter);
		}
		try
		{
			ThrowIfPendingException();
			ThrowIfDisposed();
			WebSocket.ThrowOnInvalidState(State, WebSocketState.Open, WebSocketState.CloseReceived);
			bool ownsCancellationTokenSource = false;
			CancellationToken linkedCancellationToken = CancellationToken.None;
			try
			{
				while (true)
				{
					bool flag;
					ownsCancellationTokenSource = (flag = m_SendOutstandingOperationHelper.TryStartOperation(cancellationToken, out linkedCancellationToken));
					if (flag)
					{
						break;
					}
					Task keepAliveTask;
					lock (SessionHandle)
					{
						keepAliveTask = m_KeepAliveTask;
						if (keepAliveTask == null)
						{
							m_SendOutstandingOperationHelper.CompleteOperation(ownsCancellationTokenSource);
							ownsCancellationTokenSource = (flag = m_SendOutstandingOperationHelper.TryStartOperation(cancellationToken, out linkedCancellationToken));
							if (flag)
							{
								break;
							}
							throw new InvalidOperationException(SR.GetString("net_Websockets_AlreadyOneOutstandingOperation", "SendAsync"));
						}
					}
					await keepAliveTask.SuppressContextFlow();
					ThrowIfPendingException();
					m_SendOutstandingOperationHelper.CompleteOperation(ownsCancellationTokenSource);
				}
				if (s_LoggingEnabled && buffer.Count > 0)
				{
					Logging.Dump(Logging.WebSockets, this, "SendAsync", buffer.Array, buffer.Offset, buffer.Count);
				}
				_ = buffer.Offset;
				EnsureSendOperation();
				m_SendOperation.BufferType = GetBufferType(messageType, endOfMessage);
				await m_SendOperation.Process(buffer, linkedCancellationToken).SuppressContextFlow();
			}
			catch (Exception exception)
			{
				bool isCancellationRequested = linkedCancellationToken.IsCancellationRequested;
				Abort();
				ThrowIfConvertibleException("SendAsync", exception, cancellationToken, isCancellationRequested);
				throw;
			}
			finally
			{
				m_SendOutstandingOperationHelper.CompleteOperation(ownsCancellationTokenSource);
			}
		}
		finally
		{
			if (s_LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, this, "SendAsync", inputParameter);
			}
		}
	}

	private async Task SendFrameAsync(IList<ArraySegment<byte>> sendBuffers, CancellationToken cancellationToken)
	{
		bool sendFrameLockTaken = false;
		try
		{
			await m_SendFrameThrottle.WaitAsync(cancellationToken).SuppressContextFlow();
			sendFrameLockTaken = true;
			if (sendBuffers.Count > 1 && m_InnerStreamAsWebSocketStream != null && m_InnerStreamAsWebSocketStream.SupportsMultipleWrite)
			{
				await m_InnerStreamAsWebSocketStream.MultipleWriteAsync(sendBuffers, cancellationToken).SuppressContextFlow();
				return;
			}
			foreach (ArraySegment<byte> sendBuffer in sendBuffers)
			{
				await m_InnerStream.WriteAsync(sendBuffer.Array, sendBuffer.Offset, sendBuffer.Count, cancellationToken).SuppressContextFlow();
			}
		}
		catch (ObjectDisposedException innerException)
		{
			throw new WebSocketException(WebSocketError.ConnectionClosedPrematurely, innerException);
		}
		catch (NotSupportedException innerException2)
		{
			throw new WebSocketException(WebSocketError.ConnectionClosedPrematurely, innerException2);
		}
		finally
		{
			if (sendFrameLockTaken)
			{
				m_SendFrameThrottle.Release();
			}
		}
	}

	public override void Abort()
	{
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, this, "Abort", string.Empty);
		}
		bool thisLockTaken = false;
		bool sessionHandleLockTaken = false;
		try
		{
			if (WebSocket.IsStateTerminal(State))
			{
				return;
			}
			TakeLocks(ref thisLockTaken, ref sessionHandleLockTaken);
			if (!WebSocket.IsStateTerminal(State))
			{
				m_State = WebSocketState.Aborted;
				if (SessionHandle != null && !SessionHandle.IsClosed && !SessionHandle.IsInvalid)
				{
					WebSocketProtocolComponent.WebSocketAbortHandle(SessionHandle);
				}
				m_ReceiveOutstandingOperationHelper.CancelIO();
				m_SendOutstandingOperationHelper.CancelIO();
				m_CloseOutputOutstandingOperationHelper.CancelIO();
				m_CloseOutstandingOperationHelper.CancelIO();
				if (m_InnerStreamAsWebSocketStream != null)
				{
					m_InnerStreamAsWebSocketStream.Abort();
				}
				CleanUp();
			}
		}
		finally
		{
			ReleaseLocks(ref thisLockTaken, ref sessionHandleLockTaken);
			if (s_LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, this, "Abort", string.Empty);
			}
		}
	}

	public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
	{
		WebSocketHelpers.ValidateCloseStatus(closeStatus, statusDescription);
		return CloseOutputAsyncCore(closeStatus, statusDescription, cancellationToken);
	}

	private async Task CloseOutputAsyncCore(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
	{
		string inputParameter = string.Empty;
		if (s_LoggingEnabled)
		{
			inputParameter = string.Format(CultureInfo.InvariantCulture, "closeStatus: {0}, statusDescription: {1}", new object[2] { closeStatus, statusDescription });
			Logging.Enter(Logging.WebSockets, this, "CloseOutputAsync", inputParameter);
		}
		try
		{
			ThrowIfPendingException();
			if (WebSocket.IsStateTerminal(State))
			{
				return;
			}
			ThrowIfDisposed();
			bool thisLockTaken = false;
			bool sessionHandleLockTaken = false;
			bool needToCompleteSendOperation = false;
			bool ownsCloseOutputCancellationTokenSource = false;
			bool ownsSendCancellationTokenSource = false;
			CancellationToken linkedCancellationToken = CancellationToken.None;
			try
			{
				TakeLocks(ref thisLockTaken, ref sessionHandleLockTaken);
				ThrowIfPendingException();
				ThrowIfDisposed();
				if (WebSocket.IsStateTerminal(State))
				{
					return;
				}
				WebSocket.ThrowOnInvalidState(State, WebSocketState.Open, WebSocketState.CloseReceived);
				ownsCloseOutputCancellationTokenSource = m_CloseOutputOutstandingOperationHelper.TryStartOperation(cancellationToken, out linkedCancellationToken);
				if (!ownsCloseOutputCancellationTokenSource)
				{
					Task closeOutputTask = m_CloseOutputTask;
					if (closeOutputTask != null)
					{
						ReleaseLocks(ref thisLockTaken, ref sessionHandleLockTaken);
						await closeOutputTask.SuppressContextFlow();
						TakeLocks(ref thisLockTaken, ref sessionHandleLockTaken);
					}
					return;
				}
				needToCompleteSendOperation = true;
				while (true)
				{
					bool flag;
					ownsSendCancellationTokenSource = (flag = m_SendOutstandingOperationHelper.TryStartOperation(cancellationToken, out linkedCancellationToken));
					if (flag)
					{
						break;
					}
					if (m_KeepAliveTask != null)
					{
						Task keepAliveTask = m_KeepAliveTask;
						ReleaseLocks(ref thisLockTaken, ref sessionHandleLockTaken);
						await keepAliveTask.SuppressContextFlow();
						TakeLocks(ref thisLockTaken, ref sessionHandleLockTaken);
						ThrowIfPendingException();
						m_SendOutstandingOperationHelper.CompleteOperation(ownsSendCancellationTokenSource);
						continue;
					}
					throw new InvalidOperationException(SR.GetString("net_Websockets_AlreadyOneOutstandingOperation", "SendAsync"));
				}
				EnsureCloseOutputOperation();
				m_CloseOutputOperation.CloseStatus = closeStatus;
				m_CloseOutputOperation.CloseReason = statusDescription;
				m_CloseOutputTask = m_CloseOutputOperation.Process(null, linkedCancellationToken);
				ReleaseLocks(ref thisLockTaken, ref sessionHandleLockTaken);
				await m_CloseOutputTask.SuppressContextFlow();
				TakeLocks(ref thisLockTaken, ref sessionHandleLockTaken);
				if (OnCloseOutputCompleted())
				{
					bool flag2;
					try
					{
						flag2 = await StartOnCloseCompleted(thisLockTaken, sessionHandleLockTaken, linkedCancellationToken).SuppressContextFlow();
					}
					catch (Exception)
					{
						ResetFlagsAndTakeLocks(ref thisLockTaken, ref sessionHandleLockTaken);
						throw;
					}
					if (flag2)
					{
						ResetFlagsAndTakeLocks(ref thisLockTaken, ref sessionHandleLockTaken);
						FinishOnCloseCompleted();
					}
				}
			}
			catch (Exception exception)
			{
				bool isCancellationRequested = linkedCancellationToken.IsCancellationRequested;
				Abort();
				ThrowIfConvertibleException("CloseOutputAsync", exception, cancellationToken, isCancellationRequested);
				throw;
			}
			finally
			{
				m_CloseOutputOutstandingOperationHelper.CompleteOperation(ownsCloseOutputCancellationTokenSource);
				if (needToCompleteSendOperation)
				{
					m_SendOutstandingOperationHelper.CompleteOperation(ownsSendCancellationTokenSource);
				}
				m_CloseOutputTask = null;
				ReleaseLocks(ref thisLockTaken, ref sessionHandleLockTaken);
			}
		}
		finally
		{
			if (s_LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, this, "CloseOutputAsync", inputParameter);
			}
		}
	}

	private bool OnCloseOutputCompleted()
	{
		if (WebSocket.IsStateTerminal(State))
		{
			return false;
		}
		switch (State)
		{
		case WebSocketState.Open:
			m_State = WebSocketState.CloseSent;
			return false;
		case WebSocketState.CloseReceived:
			return true;
		default:
			return false;
		}
	}

	private async Task<bool> StartOnCloseCompleted(bool thisLockTakenSnapshot, bool sessionHandleLockTakenSnapshot, CancellationToken cancellationToken)
	{
		if (WebSocket.IsStateTerminal(m_State))
		{
			return false;
		}
		m_State = WebSocketState.Closed;
		if (m_InnerStreamAsWebSocketStream != null)
		{
			bool lockTaken = thisLockTakenSnapshot;
			bool sessionHandleLockTaken = sessionHandleLockTakenSnapshot;
			try
			{
				if (m_CloseNetworkConnectionTask == null)
				{
					m_CloseNetworkConnectionTask = m_InnerStreamAsWebSocketStream.CloseNetworkConnectionAsync(cancellationToken);
				}
				if (lockTaken && sessionHandleLockTaken)
				{
					ReleaseLocks(ref lockTaken, ref sessionHandleLockTaken);
				}
				else if (lockTaken)
				{
					ReleaseLock(m_ThisLock, ref lockTaken);
				}
				await m_CloseNetworkConnectionTask.SuppressContextFlow();
			}
			catch (Exception ex)
			{
				if (!CanHandleExceptionDuringClose(ex))
				{
					ThrowIfConvertibleException("StartOnCloseCompleted", ex, cancellationToken, cancellationToken.IsCancellationRequested);
					throw;
				}
			}
		}
		return true;
	}

	private void FinishOnCloseCompleted()
	{
		CleanUp();
	}

	public override Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
	{
		WebSocketHelpers.ValidateCloseStatus(closeStatus, statusDescription);
		return CloseAsyncCore(closeStatus, statusDescription, cancellationToken);
	}

	private async Task CloseAsyncCore(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
	{
		string inputParameter = string.Empty;
		if (s_LoggingEnabled)
		{
			inputParameter = string.Format(CultureInfo.InvariantCulture, "closeStatus: {0}, statusDescription: {1}", new object[2] { closeStatus, statusDescription });
			Logging.Enter(Logging.WebSockets, this, "CloseAsync", inputParameter);
		}
		try
		{
			ThrowIfPendingException();
			if (WebSocket.IsStateTerminal(State))
			{
				return;
			}
			ThrowIfDisposed();
			bool lockTaken = false;
			Monitor.Enter(m_ThisLock, ref lockTaken);
			bool ownsCloseCancellationTokenSource = false;
			CancellationToken linkedCancellationToken = CancellationToken.None;
			try
			{
				ThrowIfPendingException();
				if (WebSocket.IsStateTerminal(State))
				{
					return;
				}
				ThrowIfDisposed();
				WebSocket.ThrowOnInvalidState(State, WebSocketState.Open, WebSocketState.CloseReceived, WebSocketState.CloseSent);
				ownsCloseCancellationTokenSource = m_CloseOutstandingOperationHelper.TryStartOperation(cancellationToken, out linkedCancellationToken);
				Task task;
				if (ownsCloseCancellationTokenSource)
				{
					task = m_CloseOutputTask;
					if (task == null && State != WebSocketState.CloseSent)
					{
						if (m_CloseReceivedTaskCompletionSource == null)
						{
							m_CloseReceivedTaskCompletionSource = new TaskCompletionSource<object>();
						}
						ReleaseLock(m_ThisLock, ref lockTaken);
						task = CloseOutputAsync(closeStatus, statusDescription, linkedCancellationToken);
					}
				}
				else
				{
					task = m_CloseReceivedTaskCompletionSource.Task;
				}
				if (task != null)
				{
					ReleaseLock(m_ThisLock, ref lockTaken);
					try
					{
						await task.SuppressContextFlow();
					}
					catch (Exception ex)
					{
						Monitor.Enter(m_ThisLock, ref lockTaken);
						if (!CanHandleExceptionDuringClose(ex))
						{
							ThrowIfConvertibleException("CloseOutputAsync", ex, cancellationToken, linkedCancellationToken.IsCancellationRequested);
							throw;
						}
					}
					if (!lockTaken)
					{
						Monitor.Enter(m_ThisLock, ref lockTaken);
					}
				}
				if (OnCloseOutputCompleted())
				{
					bool flag;
					try
					{
						flag = await StartOnCloseCompleted(lockTaken, sessionHandleLockTakenSnapshot: false, linkedCancellationToken).SuppressContextFlow();
					}
					catch (Exception)
					{
						ResetFlagAndTakeLock(m_ThisLock, ref lockTaken);
						throw;
					}
					if (flag)
					{
						ResetFlagAndTakeLock(m_ThisLock, ref lockTaken);
						FinishOnCloseCompleted();
					}
				}
				if (WebSocket.IsStateTerminal(State))
				{
					return;
				}
				linkedCancellationToken = CancellationToken.None;
				bool flag2 = m_ReceiveOutstandingOperationHelper.TryStartOperation(cancellationToken, out linkedCancellationToken);
				if (flag2)
				{
					m_CloseAsyncStartedReceive = true;
					ArraySegment<byte> closeMessageBuffer = new ArraySegment<byte>(new byte[256]);
					EnsureReceiveOperation();
					Task<WebSocketReceiveResult> task2 = m_ReceiveOperation.Process(closeMessageBuffer, linkedCancellationToken);
					ReleaseLock(m_ThisLock, ref lockTaken);
					WebSocketReceiveResult receiveResult = null;
					try
					{
						receiveResult = await task2.SuppressContextFlow();
					}
					catch (Exception ex3)
					{
						Monitor.Enter(m_ThisLock, ref lockTaken);
						if (!CanHandleExceptionDuringClose(ex3))
						{
							ThrowIfConvertibleException("CloseAsync", ex3, cancellationToken, linkedCancellationToken.IsCancellationRequested);
							throw;
						}
					}
					if (receiveResult != null)
					{
						if (s_LoggingEnabled && receiveResult.Count > 0)
						{
							Logging.Dump(Logging.WebSockets, this, "ReceiveAsync", closeMessageBuffer.Array, closeMessageBuffer.Offset, receiveResult.Count);
						}
						if (receiveResult.MessageType != WebSocketMessageType.Close)
						{
							throw new WebSocketException(WebSocketError.InvalidMessageType, SR.GetString("net_WebSockets_InvalidMessageType", typeof(WebSocket).Name + ".CloseAsync", typeof(WebSocket).Name + ".CloseOutputAsync", receiveResult.MessageType));
						}
					}
				}
				else
				{
					m_ReceiveOutstandingOperationHelper.CompleteOperation(flag2);
					ReleaseLock(m_ThisLock, ref lockTaken);
					await m_CloseReceivedTaskCompletionSource.Task.SuppressContextFlow();
				}
				if (!lockTaken)
				{
					Monitor.Enter(m_ThisLock, ref lockTaken);
				}
				if (WebSocket.IsStateTerminal(State))
				{
					return;
				}
				bool ownsSendCancellationSource = false;
				try
				{
					ownsSendCancellationSource = m_SendOutstandingOperationHelper.TryStartOperation(cancellationToken, out linkedCancellationToken);
					bool flag3;
					try
					{
						flag3 = await StartOnCloseCompleted(lockTaken, sessionHandleLockTakenSnapshot: false, linkedCancellationToken).SuppressContextFlow();
					}
					catch (Exception)
					{
						ResetFlagAndTakeLock(m_ThisLock, ref lockTaken);
						throw;
					}
					if (flag3)
					{
						ResetFlagAndTakeLock(m_ThisLock, ref lockTaken);
						FinishOnCloseCompleted();
					}
				}
				finally
				{
					m_SendOutstandingOperationHelper.CompleteOperation(ownsSendCancellationSource);
				}
			}
			catch (Exception exception)
			{
				bool isCancellationRequested = linkedCancellationToken.IsCancellationRequested;
				Abort();
				ThrowIfConvertibleException("CloseAsync", exception, cancellationToken, isCancellationRequested);
				throw;
			}
			finally
			{
				m_CloseOutstandingOperationHelper.CompleteOperation(ownsCloseCancellationTokenSource);
				ReleaseLock(m_ThisLock, ref lockTaken);
			}
		}
		finally
		{
			if (s_LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, this, "CloseAsync", inputParameter);
			}
		}
	}

	public override void Dispose()
	{
		if (m_IsDisposed)
		{
			return;
		}
		bool thisLockTaken = false;
		bool sessionHandleLockTaken = false;
		try
		{
			TakeLocks(ref thisLockTaken, ref sessionHandleLockTaken);
			if (!m_IsDisposed)
			{
				if (!WebSocket.IsStateTerminal(State))
				{
					Abort();
				}
				else
				{
					CleanUp();
				}
				m_IsDisposed = true;
			}
		}
		finally
		{
			ReleaseLocks(ref thisLockTaken, ref sessionHandleLockTaken);
		}
	}

	private void ResetFlagAndTakeLock(object lockObject, ref bool thisLockTaken)
	{
		thisLockTaken = false;
		Monitor.Enter(lockObject, ref thisLockTaken);
	}

	private void ResetFlagsAndTakeLocks(ref bool thisLockTaken, ref bool sessionHandleLockTaken)
	{
		thisLockTaken = false;
		sessionHandleLockTaken = false;
		TakeLocks(ref thisLockTaken, ref sessionHandleLockTaken);
	}

	private void TakeLocks(ref bool thisLockTaken, ref bool sessionHandleLockTaken)
	{
		Monitor.Enter(SessionHandle, ref sessionHandleLockTaken);
		Monitor.Enter(m_ThisLock, ref thisLockTaken);
	}

	private void ReleaseLocks(ref bool thisLockTaken, ref bool sessionHandleLockTaken)
	{
		if (!(thisLockTaken | sessionHandleLockTaken))
		{
			return;
		}
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			if (thisLockTaken)
			{
				Monitor.Exit(m_ThisLock);
				thisLockTaken = false;
			}
			if (sessionHandleLockTaken)
			{
				Monitor.Exit(SessionHandle);
				sessionHandleLockTaken = false;
			}
		}
	}

	private void EnsureReceiveOperation()
	{
		if (m_ReceiveOperation != null)
		{
			return;
		}
		lock (m_ThisLock)
		{
			if (m_ReceiveOperation == null)
			{
				m_ReceiveOperation = new WebSocketOperation.ReceiveOperation(this);
			}
		}
	}

	private void EnsureSendOperation()
	{
		if (m_SendOperation != null)
		{
			return;
		}
		lock (m_ThisLock)
		{
			if (m_SendOperation == null)
			{
				m_SendOperation = new WebSocketOperation.SendOperation(this);
			}
		}
	}

	private void EnsureKeepAliveOperation()
	{
		if (m_KeepAliveOperation != null)
		{
			return;
		}
		lock (m_ThisLock)
		{
			if (m_KeepAliveOperation == null)
			{
				WebSocketOperation.SendOperation sendOperation = new WebSocketOperation.SendOperation(this);
				sendOperation.BufferType = WebSocketProtocolComponent.BufferType.UnsolicitedPong;
				m_KeepAliveOperation = sendOperation;
			}
		}
	}

	private void EnsureCloseOutputOperation()
	{
		if (m_CloseOutputOperation != null)
		{
			return;
		}
		lock (m_ThisLock)
		{
			if (m_CloseOutputOperation == null)
			{
				m_CloseOutputOperation = new WebSocketOperation.CloseOutputOperation(this);
			}
		}
	}

	private static void ReleaseLock(object lockObject, ref bool lockTaken)
	{
		if (lockTaken)
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				Monitor.Exit(lockObject);
				lockTaken = false;
			}
		}
	}

	private static WebSocketProtocolComponent.BufferType GetBufferType(WebSocketMessageType messageType, bool endOfMessage)
	{
		if (messageType == WebSocketMessageType.Text)
		{
			if (endOfMessage)
			{
				return WebSocketProtocolComponent.BufferType.UTF8Message;
			}
			return WebSocketProtocolComponent.BufferType.UTF8Fragment;
		}
		if (endOfMessage)
		{
			return WebSocketProtocolComponent.BufferType.BinaryMessage;
		}
		return WebSocketProtocolComponent.BufferType.BinaryFragment;
	}

	private static WebSocketMessageType GetMessageType(WebSocketProtocolComponent.BufferType bufferType)
	{
		switch (bufferType)
		{
		case WebSocketProtocolComponent.BufferType.Close:
			return WebSocketMessageType.Close;
		case WebSocketProtocolComponent.BufferType.BinaryMessage:
		case WebSocketProtocolComponent.BufferType.BinaryFragment:
			return WebSocketMessageType.Binary;
		case WebSocketProtocolComponent.BufferType.UTF8Message:
		case WebSocketProtocolComponent.BufferType.UTF8Fragment:
			return WebSocketMessageType.Text;
		default:
			throw new WebSocketException(WebSocketError.NativeError, SR.GetString("net_WebSockets_InvalidBufferType", bufferType, WebSocketProtocolComponent.BufferType.Close, WebSocketProtocolComponent.BufferType.BinaryFragment, WebSocketProtocolComponent.BufferType.BinaryMessage, WebSocketProtocolComponent.BufferType.UTF8Fragment, WebSocketProtocolComponent.BufferType.UTF8Message));
		}
	}

	internal void ValidateNativeBuffers(WebSocketProtocolComponent.Action action, WebSocketProtocolComponent.BufferType bufferType, WebSocketProtocolComponent.Buffer[] dataBuffers, uint dataBufferCount)
	{
		m_InternalBuffer.ValidateNativeBuffers(action, bufferType, dataBuffers, dataBufferCount);
	}

	internal void ThrowIfClosedOrAborted()
	{
		if (State == WebSocketState.Closed || State == WebSocketState.Aborted)
		{
			throw new WebSocketException(WebSocketError.InvalidState, SR.GetString("net_WebSockets_InvalidState_ClosedOrAborted", GetType().FullName, State));
		}
	}

	private void ThrowIfAborted(bool aborted, Exception innerException)
	{
		if (aborted)
		{
			throw new WebSocketException(WebSocketError.InvalidState, SR.GetString("net_WebSockets_InvalidState_ClosedOrAborted", GetType().FullName, WebSocketState.Aborted), innerException);
		}
	}

	private bool CanHandleExceptionDuringClose(Exception error)
	{
		if (State != WebSocketState.Closed)
		{
			return false;
		}
		if (!(error is OperationCanceledException) && !(error is WebSocketException) && !(error is SocketException) && !(error is HttpListenerException))
		{
			return error is IOException;
		}
		return true;
	}

	private void ThrowIfConvertibleException(string methodName, Exception exception, CancellationToken cancellationToken, bool aborted)
	{
		if (s_LoggingEnabled && !string.IsNullOrEmpty(methodName))
		{
			Logging.Exception(Logging.WebSockets, this, methodName, exception);
		}
		if (exception is OperationCanceledException)
		{
			if (cancellationToken.IsCancellationRequested || !aborted)
			{
				return;
			}
			ThrowIfAborted(aborted, exception);
		}
		WebSocketException ex2 = exception as WebSocketException;
		if (ex2 != null)
		{
			cancellationToken.ThrowIfCancellationRequested();
			ThrowIfAborted(aborted, ex2);
			return;
		}
		if (exception is SocketException ex3)
		{
			ex2 = new WebSocketException(ex3.NativeErrorCode, ex3);
		}
		if (exception is HttpListenerException ex4)
		{
			ex2 = new WebSocketException(ex4.ErrorCode, ex4);
		}
		if (exception is IOException innerException && exception.InnerException is SocketException ex5)
		{
			ex2 = new WebSocketException(ex5.NativeErrorCode, innerException);
		}
		if (ex2 != null)
		{
			cancellationToken.ThrowIfCancellationRequested();
			ThrowIfAborted(aborted, ex2);
			throw ex2;
		}
		if (!(exception is AggregateException ex6))
		{
			return;
		}
		ReadOnlyCollection<Exception> innerExceptions = ex6.Flatten().InnerExceptions;
		if (innerExceptions.Count == 0)
		{
			return;
		}
		foreach (Exception item in innerExceptions)
		{
			ThrowIfConvertibleException(null, item, cancellationToken, aborted);
		}
	}

	private void CleanUp()
	{
		if (m_CleanedUp)
		{
			return;
		}
		m_CleanedUp = true;
		if (SessionHandle != null)
		{
			SessionHandle.Dispose();
		}
		if (m_InternalBuffer != null)
		{
			m_InternalBuffer.Dispose(State);
		}
		if (m_ReceiveOutstandingOperationHelper != null)
		{
			m_ReceiveOutstandingOperationHelper.Dispose();
		}
		if (m_SendOutstandingOperationHelper != null)
		{
			m_SendOutstandingOperationHelper.Dispose();
		}
		if (m_CloseOutputOutstandingOperationHelper != null)
		{
			m_CloseOutputOutstandingOperationHelper.Dispose();
		}
		if (m_CloseOutstandingOperationHelper != null)
		{
			m_CloseOutstandingOperationHelper.Dispose();
		}
		if (m_InnerStream != null)
		{
			try
			{
				m_InnerStream.Close();
			}
			catch (ObjectDisposedException)
			{
			}
			catch (IOException)
			{
			}
			catch (SocketException)
			{
			}
			catch (HttpListenerException)
			{
			}
		}
		m_KeepAliveTracker.Dispose();
	}

	private void OnBackgroundTaskException(Exception exception)
	{
		if (Interlocked.CompareExchange(ref m_PendingException, exception, null) == null)
		{
			if (s_LoggingEnabled)
			{
				Logging.Exception(Logging.WebSockets, this, "Fault", exception);
			}
			Abort();
		}
	}

	private void ThrowIfPendingException()
	{
		Exception ex = Interlocked.Exchange(ref m_PendingException, null);
		if (ex != null)
		{
			throw new WebSocketException(WebSocketError.Faulted, ex);
		}
	}

	private void ThrowIfDisposed()
	{
		if (m_IsDisposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
	}

	private void UpdateReceiveState(int newReceiveState, int expectedReceiveState)
	{
		int num = Interlocked.Exchange(ref m_ReceiveState, newReceiveState);
	}

	private bool StartOnCloseReceived(ref bool thisLockTaken)
	{
		ThrowIfDisposed();
		if (WebSocket.IsStateTerminal(State) || State == WebSocketState.CloseReceived)
		{
			return false;
		}
		Monitor.Enter(m_ThisLock, ref thisLockTaken);
		if (WebSocket.IsStateTerminal(State) || State == WebSocketState.CloseReceived)
		{
			return false;
		}
		if (State == WebSocketState.Open)
		{
			m_State = WebSocketState.CloseReceived;
			if (m_CloseReceivedTaskCompletionSource == null)
			{
				m_CloseReceivedTaskCompletionSource = new TaskCompletionSource<object>();
			}
			return false;
		}
		return true;
	}

	private void FinishOnCloseReceived(WebSocketCloseStatus closeStatus, string closeStatusDescription)
	{
		if (m_CloseReceivedTaskCompletionSource != null)
		{
			m_CloseReceivedTaskCompletionSource.TrySetResult(null);
		}
		m_CloseStatus = closeStatus;
		m_CloseStatusDescription = closeStatusDescription;
		if (s_LoggingEnabled)
		{
			string param = string.Format(CultureInfo.InvariantCulture, "closeStatus: {0}, closeStatusDescription: {1}, m_State: {2}", new object[3] { closeStatus, closeStatusDescription, m_State });
			Logging.PrintInfo(Logging.WebSockets, this, "FinishOnCloseReceived", param);
		}
	}

	private static async void OnKeepAlive(object sender)
	{
		WebSocketBase thisPtr = sender as WebSocketBase;
		bool lockTaken = false;
		if (s_LoggingEnabled)
		{
			Logging.Enter(Logging.WebSockets, thisPtr, "OnKeepAlive", string.Empty);
		}
		CancellationToken linkedCancellationToken = CancellationToken.None;
		try
		{
			Monitor.Enter(thisPtr.SessionHandle, ref lockTaken);
			if (thisPtr.m_IsDisposed || thisPtr.m_State != WebSocketState.Open || thisPtr.m_CloseOutputTask != null || !thisPtr.m_KeepAliveTracker.ShouldSendKeepAlive())
			{
				return;
			}
			bool ownsCancellationTokenSource = false;
			try
			{
				ownsCancellationTokenSource = thisPtr.m_SendOutstandingOperationHelper.TryStartOperation(CancellationToken.None, out linkedCancellationToken);
				if (ownsCancellationTokenSource)
				{
					thisPtr.EnsureKeepAliveOperation();
					thisPtr.m_KeepAliveTask = thisPtr.m_KeepAliveOperation.Process(null, linkedCancellationToken);
					ReleaseLock(thisPtr.SessionHandle, ref lockTaken);
					await thisPtr.m_KeepAliveTask.SuppressContextFlow();
				}
			}
			finally
			{
				if (!lockTaken)
				{
					Monitor.Enter(thisPtr.SessionHandle, ref lockTaken);
				}
				thisPtr.m_SendOutstandingOperationHelper.CompleteOperation(ownsCancellationTokenSource);
				thisPtr.m_KeepAliveTask = null;
			}
			thisPtr.m_KeepAliveTracker.ResetTimer();
		}
		catch (Exception exception)
		{
			try
			{
				thisPtr.ThrowIfConvertibleException("OnKeepAlive", exception, CancellationToken.None, linkedCancellationToken.IsCancellationRequested);
				throw;
			}
			catch (Exception exception2)
			{
				thisPtr.OnBackgroundTaskException(exception2);
			}
		}
		finally
		{
			ReleaseLock(thisPtr.SessionHandle, ref lockTaken);
			if (s_LoggingEnabled)
			{
				Logging.Exit(Logging.WebSockets, thisPtr, "OnKeepAlive", string.Empty);
			}
		}
	}
}
