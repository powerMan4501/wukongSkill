using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Security;
using System.Threading;

namespace System.Net;

internal class Connection : PooledStream
{
	private class StatusLineValues
	{
		internal int MajorVersion;

		internal int MinorVersion;

		internal int StatusCode;

		internal string StatusDescription;
	}

	private class WaitListItem
	{
		private HttpWebRequest request;

		private long queueStartTime;

		public HttpWebRequest Request => request;

		public long QueueStartTime => queueStartTime;

		public WaitListItem(HttpWebRequest request, long queueStartTime)
		{
			this.request = request;
			this.queueStartTime = queueStartTime;
		}
	}

	private class AsyncTriState
	{
		public TriState Value;

		public AsyncTriState(TriState newValue)
		{
			Value = newValue;
		}
	}

	[ThreadStatic]
	private static int t_SyncReadNesting;

	private const int CRLFSize = 2;

	private const long c_InvalidContentLength = -2L;

	private const int CachedBufferSize = 4096;

	private static PinnableBufferCache s_PinnableBufferCache = new PinnableBufferCache("System.Net.Connection", 4096);

	private WebExceptionStatus m_Error;

	internal Exception m_InnerException;

	internal int m_IISVersion = -1;

	private byte[] m_ReadBuffer;

	private bool m_ReadBufferFromPinnableCache;

	private int m_BytesRead;

	private int m_BytesScanned;

	private int m_TotalResponseHeadersLength;

	private int m_MaximumResponseHeadersLength;

	private long m_MaximumUnauthorizedUploadLength;

	private CoreResponseData m_ResponseData;

	private ReadState m_ReadState;

	private StatusLineValues m_StatusLineValues;

	private int m_StatusState;

	private List<WaitListItem> m_WaitList;

	private ArrayList m_WriteList;

	private IAsyncResult m_LastAsyncResult;

	private TimerThread.Timer m_RecycleTimer;

	private WebParseError m_ParseError;

	private bool m_AtLeastOneResponseReceived;

	private static readonly WaitCallback m_PostReceiveDelegate = PostReceiveWrapper;

	private static readonly AsyncCallback m_ReadCallback = ReadCallbackWrapper;

	private static readonly AsyncCallback m_TunnelCallback = TunnelThroughProxyWrapper;

	private static byte[] s_NullBuffer = new byte[0];

	private HttpAbortDelegate m_AbortDelegate;

	private ConnectionGroup m_ConnectionGroup;

	private UnlockConnectionDelegate m_ConnectionUnlock;

	private DateTime m_PrepareCloseConnectionSocketCalledUtc;

	private DateTime m_AbortSocketCalledUtc;

	private DateTime m_IdleSinceUtc;

	private HttpWebRequest m_LockedRequest;

	private HttpWebRequest m_CurrentRequest;

	private bool m_CanPipeline;

	private bool m_Free = true;

	private bool m_Idle = true;

	private bool m_KeepAlive = true;

	private bool m_Pipelining;

	private int m_ReservedCount;

	private bool m_ReadDone;

	private bool m_WriteDone;

	private bool m_RemovedFromConnectionList;

	private bool m_NonKeepAliveRequestPipelined;

	private bool m_IsPipelinePaused;

	private static int s_MaxPipelinedCount = 10;

	private static int s_MinPipelinedCount = 5;

	private const int BeforeVersionNumbers = 0;

	private const int MajorVersionNumber = 1;

	private const int MinorVersionNumber = 2;

	private const int StatusCodeNumber = 3;

	private const int AfterStatusCode = 4;

	private const int AfterCarriageReturn = 5;

	private const string BeforeVersionNumberBytes = "HTTP/";

	private static readonly string[] s_ShortcutStatusDescriptions = new string[3] { "OK", "Continue", "Unauthorized" };

	internal override ServicePoint ServicePoint => ConnectionGroup.ServicePoint;

	private ConnectionGroup ConnectionGroup => m_ConnectionGroup;

	internal HttpWebRequest LockedRequest
	{
		get
		{
			return m_LockedRequest;
		}
		set
		{
			HttpWebRequest lockedRequest = m_LockedRequest;
			if (value == lockedRequest)
			{
				if (value != null && (object)value.UnlockConnectionDelegate != m_ConnectionUnlock)
				{
					throw new InternalException();
				}
				return;
			}
			object obj = lockedRequest?.UnlockConnectionDelegate;
			if (obj != null && (value != null || m_ConnectionUnlock != obj))
			{
				throw new InternalException();
			}
			if (value == null)
			{
				m_LockedRequest = null;
				lockedRequest.UnlockConnectionDelegate = null;
				return;
			}
			UnlockConnectionDelegate unlockConnectionDelegate = value.UnlockConnectionDelegate;
			if (unlockConnectionDelegate != null)
			{
				if ((object)unlockConnectionDelegate == m_ConnectionUnlock)
				{
					throw new InternalException();
				}
				unlockConnectionDelegate();
			}
			value.UnlockConnectionDelegate = m_ConnectionUnlock;
			m_LockedRequest = value;
		}
	}

	internal int BusyCount => ((!m_ReadDone) ? 1 : 0) + 2 * (m_WaitList.Count + m_WriteList.Count) + m_ReservedCount;

	internal int IISVersion => m_IISVersion;

	internal bool AtLeastOneResponseReceived => m_AtLeastOneResponseReceived;

	internal bool KeepAlive => m_KeepAlive;

	internal bool NonKeepAliveRequestPipelined => m_NonKeepAliveRequestPipelined;

	private void UnlockRequest()
	{
		LockedRequest = null;
		if (ConnectionGroup != null)
		{
			ConnectionGroup.ConnectionGoneIdle();
		}
	}

	internal Connection(ConnectionGroup connectionGroup)
		: base(null)
	{
		m_MaximumUnauthorizedUploadLength = SettingsSectionInternal.Section.MaximumUnauthorizedUploadLength;
		if (m_MaximumUnauthorizedUploadLength > 0)
		{
			m_MaximumUnauthorizedUploadLength *= 1024L;
		}
		m_ResponseData = new CoreResponseData();
		m_ConnectionGroup = connectionGroup;
		if (ServicePointManager.UseHttpPipeliningAndBufferPooling)
		{
			m_ReadBuffer = s_PinnableBufferCache.AllocateBuffer();
			m_ReadBufferFromPinnableCache = true;
		}
		else
		{
			m_ReadBuffer = new byte[4096];
		}
		m_ReadState = ReadState.Start;
		m_WaitList = new List<WaitListItem>();
		m_WriteList = new ArrayList();
		m_AbortDelegate = AbortOrDisassociate;
		m_ConnectionUnlock = UnlockRequest;
		m_StatusLineValues = new StatusLineValues();
		m_RecycleTimer = ConnectionGroup.ServicePoint.ConnectionLeaseTimerQueue.CreateTimer();
		ConnectionGroup.Associate(this);
		m_ReadDone = true;
		m_WriteDone = true;
		m_Error = WebExceptionStatus.Success;
		if (PinnableBufferCacheEventSource.Log.IsEnabled())
		{
			PinnableBufferCacheEventSource.Log.DebugMessage1("CTOR: In System.Net.Connection.Connnection", GetHashCode());
		}
	}

	~Connection()
	{
		if (m_ReadBufferFromPinnableCache && PinnableBufferCacheEventSource.Log.IsEnabled())
		{
			PinnableBufferCacheEventSource.Log.DebugMessage1("DTOR: ERROR Needing to Free m_ReadBuffer in Connection Destructor", m_ReadBuffer.GetHashCode());
		}
		FreeReadBuffer();
	}

	private void FreeReadBuffer()
	{
		if (m_ReadBufferFromPinnableCache)
		{
			s_PinnableBufferCache.FreeBuffer(m_ReadBuffer);
			m_ReadBufferFromPinnableCache = false;
		}
		m_ReadBuffer = null;
	}

	protected override void Dispose(bool disposing)
	{
		if (PinnableBufferCacheEventSource.Log.IsEnabled())
		{
			PinnableBufferCacheEventSource.Log.DebugMessage1("In System.Net.Connection.Dispose()", GetHashCode());
		}
		base.Dispose(disposing);
	}

	internal bool SubmitRequest(HttpWebRequest request, bool forcedsubmit)
	{
		TriState triState = TriState.Unspecified;
		ConnectionReturnResult returnResult = null;
		bool flag = false;
		lock (this)
		{
			request.AbortDelegate = m_AbortDelegate;
			if (request.Aborted)
			{
				UnlockIfNeeded(request);
				return true;
			}
			if (!base.CanBePooled)
			{
				UnlockIfNeeded(request);
				return false;
			}
			if (!forcedsubmit && NonKeepAliveRequestPipelined)
			{
				UnlockIfNeeded(request);
				return false;
			}
			if (m_RecycleTimer.Duration != ServicePoint.ConnectionLeaseTimerQueue.Duration)
			{
				m_RecycleTimer.Cancel();
				m_RecycleTimer = ServicePoint.ConnectionLeaseTimerQueue.CreateTimer();
			}
			if (m_RecycleTimer.HasExpired)
			{
				request.KeepAlive = false;
			}
			if (LockedRequest != null && LockedRequest != request)
			{
				return false;
			}
			if (!forcedsubmit && !m_NonKeepAliveRequestPipelined)
			{
				m_NonKeepAliveRequestPipelined = !request.KeepAlive && !request.NtlmKeepAlive;
			}
			if (m_Free && m_WriteDone && (m_WriteList.Count == 0 || (request.Pipelined && !request.HasEntityBody && m_CanPipeline && m_Pipelining && !m_IsPipelinePaused && !forcedsubmit)))
			{
				m_Free = false;
				triState = StartRequest(request, canPollRead: true);
				if (triState == TriState.Unspecified)
				{
					flag = true;
					PrepareCloseConnectionSocket(ref returnResult);
					Close(0);
				}
			}
			else
			{
				m_WaitList.Add(new WaitListItem(request, NetworkingPerfCounters.GetTimestamp()));
				NetworkingPerfCounters.Instance.Increment(NetworkingPerfCounterName.HttpWebRequestQueued);
				CheckNonIdle();
			}
		}
		if (flag)
		{
			ConnectionReturnResult.SetResponses(returnResult);
			return false;
		}
		if (Logging.On)
		{
			Logging.Associate(Logging.Web, this, request);
		}
		if (triState != TriState.Unspecified)
		{
			CompleteStartRequest(onSubmitThread: true, request, triState);
		}
		if (!request.Async)
		{
			object obj = request.ConnectionAsyncResult.InternalWaitForCompletion();
			ConnectStream connectStream = obj as ConnectStream;
			AsyncTriState asyncTriState = null;
			if (connectStream == null)
			{
				asyncTriState = obj as AsyncTriState;
			}
			if (triState == TriState.Unspecified && asyncTriState != null)
			{
				CompleteStartRequest(onSubmitThread: true, request, asyncTriState.Value);
			}
			else if (connectStream != null)
			{
				request.SetRequestSubmitDone(connectStream);
			}
		}
		return true;
	}

	private void UnlockIfNeeded(HttpWebRequest request)
	{
		if (LockedRequest == request)
		{
			UnlockRequest();
		}
	}

	private TriState StartRequest(HttpWebRequest request, bool canPollRead)
	{
		if (m_WriteList.Count == 0)
		{
			if (ServicePoint.MaxIdleTime != -1 && m_IdleSinceUtc != DateTime.MinValue && m_IdleSinceUtc + TimeSpan.FromMilliseconds(ServicePoint.MaxIdleTime) < DateTime.UtcNow)
			{
				return TriState.Unspecified;
			}
			if (canPollRead && !IsConnectionReusable())
			{
				return TriState.Unspecified;
			}
		}
		TriState result = TriState.False;
		m_IdleSinceUtc = DateTime.MinValue;
		if (!m_IsPipelinePaused)
		{
			m_IsPipelinePaused = m_WriteList.Count >= s_MaxPipelinedCount;
		}
		m_Pipelining = m_CanPipeline && request.Pipelined && !request.HasEntityBody;
		m_WriteDone = false;
		m_WriteList.Add(request);
		CheckNonIdle();
		if (base.IsInitalizing)
		{
			result = TriState.True;
		}
		return result;
	}

	private bool IsConnectionReusable()
	{
		try
		{
			if (PollRead())
			{
				return false;
			}
		}
		catch (SocketException ex)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.Web, this, "IsConnectionReusable", ex.ToString());
			}
			return false;
		}
		return true;
	}

	private void CompleteStartRequest(bool onSubmitThread, HttpWebRequest request, TriState needReConnect)
	{
		if (needReConnect == TriState.True)
		{
			try
			{
				if (request.Async)
				{
					CompleteStartConnection(async: true, request);
				}
				else if (onSubmitThread)
				{
					CompleteStartConnection(async: false, request);
				}
			}
			catch (Exception exception)
			{
				if (NclUtilities.IsFatal(exception))
				{
					throw;
				}
			}
			if (!request.Async)
			{
				request.ConnectionAsyncResult.InvokeCallback(new AsyncTriState(needReConnect));
			}
		}
		else
		{
			if (request.Async)
			{
				request.OpenWriteSideResponseWindow();
			}
			ConnectStream connectStream = new ConnectStream(this, request);
			if (request.Async || onSubmitThread)
			{
				request.SetRequestSubmitDone(connectStream);
			}
			else
			{
				request.ConnectionAsyncResult.InvokeCallback(connectStream);
			}
		}
	}

	private HttpWebRequest CheckNextRequest()
	{
		if (m_WaitList.Count == 0)
		{
			m_Free = m_KeepAlive;
			return null;
		}
		if (!base.CanBePooled)
		{
			return null;
		}
		WaitListItem waitListItem = m_WaitList[0];
		HttpWebRequest httpWebRequest = waitListItem.Request;
		if (m_IsPipelinePaused)
		{
			m_IsPipelinePaused = m_WriteList.Count > s_MinPipelinedCount;
		}
		if ((!httpWebRequest.Pipelined || httpWebRequest.HasEntityBody || !m_CanPipeline || !m_Pipelining || m_IsPipelinePaused) && m_WriteList.Count != 0)
		{
			httpWebRequest = null;
		}
		if (httpWebRequest != null)
		{
			NetworkingPerfCounters.Instance.IncrementAverage(NetworkingPerfCounterName.HttpWebRequestAvgQueueTime, waitListItem.QueueStartTime);
			m_WaitList.RemoveAt(0);
			CheckIdle();
		}
		return httpWebRequest;
	}

	private void CompleteStartConnection(bool async, HttpWebRequest httpWebRequest)
	{
		WebExceptionStatus webExceptionStatus = WebExceptionStatus.ConnectFailure;
		m_InnerException = null;
		bool flag = true;
		try
		{
			if ((httpWebRequest.IsWebSocketRequest || httpWebRequest.Address.Scheme == Uri.UriSchemeHttps) && ServicePoint.InternalProxyServicePoint)
			{
				if (!TunnelThroughProxy(ServicePoint.InternalAddress, httpWebRequest, async))
				{
					webExceptionStatus = WebExceptionStatus.ConnectFailure;
					flag = false;
				}
				if (async && flag)
				{
					return;
				}
			}
			else if (!Activate(httpWebRequest, async, CompleteConnectionWrapper))
			{
				return;
			}
		}
		catch (Exception ex)
		{
			if (m_InnerException == null)
			{
				m_InnerException = ex;
			}
			if (ex is WebException)
			{
				webExceptionStatus = ((WebException)ex).Status;
			}
			flag = false;
		}
		if (!flag)
		{
			ConnectionReturnResult returnResult = null;
			HandleError(writeDone: false, readDone: false, webExceptionStatus, ref returnResult);
			ConnectionReturnResult.SetResponses(returnResult);
		}
		else
		{
			CompleteConnection(async, httpWebRequest);
		}
	}

	private void CompleteConnectionWrapper(object request, object state)
	{
		if (state is Exception innerException)
		{
			ConnectionReturnResult returnResult = null;
			if (m_InnerException == null)
			{
				m_InnerException = innerException;
			}
			HandleError(writeDone: false, readDone: false, WebExceptionStatus.ConnectFailure, ref returnResult);
			ConnectionReturnResult.SetResponses(returnResult);
		}
		CompleteConnection(async: true, (HttpWebRequest)request);
	}

	private void CompleteConnection(bool async, HttpWebRequest request)
	{
		WebExceptionStatus webExceptionStatus = WebExceptionStatus.ConnectFailure;
		if (request.Async)
		{
			request.OpenWriteSideResponseWindow();
		}
		try
		{
			try
			{
				if (request.Address.Scheme == Uri.UriSchemeHttps)
				{
					TlsStream networkStream = new TlsStream(request.GetRemoteResourceUri().IdnHost, base.NetworkStream, request.CheckCertificateRevocationList, request.SslProtocols, request.ClientCertificates, ServicePoint, request, request.Async ? request.GetConnectingContext().ContextCopy : null);
					base.NetworkStream = networkStream;
				}
				webExceptionStatus = WebExceptionStatus.Success;
			}
			catch
			{
				base.NetworkStream.Close();
				throw;
			}
			finally
			{
				m_ReadState = ReadState.Start;
				ClearReaderState();
				request.SetRequestSubmitDone(new ConnectStream(this, request));
			}
		}
		catch (Exception ex)
		{
			if (m_InnerException == null)
			{
				m_InnerException = ex;
			}
			if (ex is WebException ex2)
			{
				webExceptionStatus = ex2.Status;
			}
		}
		if (webExceptionStatus != WebExceptionStatus.Success)
		{
			ConnectionReturnResult returnResult = null;
			HandleError(writeDone: false, readDone: false, webExceptionStatus, ref returnResult);
			ConnectionReturnResult.SetResponses(returnResult);
			if (Logging.On)
			{
				Logging.PrintError(Logging.Web, this, "CompleteConnection", "on error");
			}
		}
	}

	private void InternalWriteStartNextRequest(HttpWebRequest request, ref bool calledCloseConnection, ref TriState startRequestResult, ref HttpWebRequest nextRequest, ref ConnectionReturnResult returnResult)
	{
		lock (this)
		{
			m_WriteDone = true;
			if (!m_KeepAlive || m_Error != WebExceptionStatus.Success || !base.CanBePooled)
			{
				if (m_ReadDone)
				{
					if (m_Error == WebExceptionStatus.Success)
					{
						m_Error = WebExceptionStatus.KeepAliveFailure;
					}
					PrepareCloseConnectionSocket(ref returnResult);
					calledCloseConnection = true;
					Close();
				}
				else if (m_Error == WebExceptionStatus.Success)
				{
				}
			}
			else
			{
				if (m_Pipelining || m_ReadDone)
				{
					nextRequest = CheckNextRequest();
				}
				if (nextRequest != null)
				{
					startRequestResult = StartRequest(nextRequest, canPollRead: false);
				}
			}
		}
	}

	internal void WriteStartNextRequest(HttpWebRequest request, ref ConnectionReturnResult returnResult)
	{
		TriState startRequestResult = TriState.Unspecified;
		HttpWebRequest nextRequest = null;
		bool calledCloseConnection = false;
		InternalWriteStartNextRequest(request, ref calledCloseConnection, ref startRequestResult, ref nextRequest, ref returnResult);
		if (!calledCloseConnection && startRequestResult != TriState.Unspecified)
		{
			CompleteStartRequest(onSubmitThread: false, nextRequest, startRequestResult);
		}
	}

	internal void SetLeftoverBytes(byte[] buffer, int bufferOffset, int bufferCount)
	{
		if (bufferOffset > 0)
		{
			Buffer.BlockCopy(buffer, bufferOffset, buffer, 0, bufferCount);
		}
		if (m_ReadBuffer != buffer)
		{
			FreeReadBuffer();
			m_ReadBuffer = buffer;
		}
		m_BytesScanned = 0;
		m_BytesRead = bufferCount;
	}

	internal void ReadStartNextRequest(WebRequest currentRequest, ref ConnectionReturnResult returnResult)
	{
		HttpWebRequest httpWebRequest = null;
		TriState triState = TriState.Unspecified;
		bool flag = false;
		bool flag2 = false;
		int num = Interlocked.Decrement(ref m_ReservedCount);
		try
		{
			lock (this)
			{
				if (m_WriteList.Count > 0 && currentRequest == m_WriteList[0])
				{
					m_ReadState = ReadState.Start;
					m_WriteList.RemoveAt(0);
					m_ResponseData.m_ConnectStream = null;
				}
				else
				{
					flag2 = true;
				}
				if (!flag2)
				{
					if (m_ReadDone)
					{
						throw new InternalException();
					}
					if (!m_KeepAlive || m_Error != WebExceptionStatus.Success || !base.CanBePooled)
					{
						m_ReadDone = true;
						if (m_WriteDone)
						{
							if (m_Error == WebExceptionStatus.Success)
							{
								m_Error = WebExceptionStatus.KeepAliveFailure;
							}
							PrepareCloseConnectionSocket(ref returnResult);
							if (currentRequest is HttpWebRequest { TunnelConnection: not null } httpWebRequest2)
							{
								httpWebRequest2.TunnelConnection.RemoveFromConnectionList();
							}
							flag = true;
							Close();
						}
					}
					else
					{
						m_AtLeastOneResponseReceived = true;
						if (m_WriteList.Count != 0)
						{
							httpWebRequest = m_WriteList[0] as HttpWebRequest;
							if (!httpWebRequest.HeadersCompleted)
							{
								httpWebRequest = null;
								m_ReadDone = true;
							}
						}
						else
						{
							m_ReadDone = true;
							if (m_WriteDone)
							{
								httpWebRequest = CheckNextRequest();
								if (httpWebRequest != null)
								{
									if (httpWebRequest.HeadersCompleted)
									{
										throw new InternalException();
									}
									triState = StartRequest(httpWebRequest, canPollRead: false);
								}
								else
								{
									m_Free = true;
								}
							}
						}
					}
				}
			}
		}
		finally
		{
			CheckIdle();
			if (returnResult != null)
			{
				ConnectionReturnResult.SetResponses(returnResult);
			}
		}
		if (flag2 || flag)
		{
			return;
		}
		if (triState != TriState.Unspecified)
		{
			CompleteStartRequest(onSubmitThread: false, httpWebRequest, triState);
		}
		else if (httpWebRequest != null)
		{
			if (!httpWebRequest.Async)
			{
				httpWebRequest.ConnectionReaderAsyncResult.InvokeCallback();
			}
			else if (m_BytesScanned < m_BytesRead)
			{
				ReadComplete(0, WebExceptionStatus.Success);
			}
			else if (Thread.CurrentThread.IsThreadPoolThread)
			{
				PostReceive();
			}
			else
			{
				ThreadPool.UnsafeQueueUserWorkItem(m_PostReceiveDelegate, this);
			}
		}
	}

	internal void MarkAsReserved()
	{
		int num = Interlocked.Increment(ref m_ReservedCount);
	}

	internal void CheckStartReceive(HttpWebRequest request)
	{
		lock (this)
		{
			request.HeadersCompleted = true;
			if (m_WriteList.Count == 0 || !m_ReadDone || m_WriteList[0] != request)
			{
				return;
			}
			m_ReadDone = false;
			m_CurrentRequest = (HttpWebRequest)m_WriteList[0];
		}
		if (!request.Async)
		{
			request.ConnectionReaderAsyncResult.InvokeCallback();
		}
		else if (m_BytesScanned < m_BytesRead)
		{
			ReadComplete(0, WebExceptionStatus.Success);
		}
		else if (Thread.CurrentThread.IsThreadPoolThread)
		{
			PostReceive();
		}
		else
		{
			ThreadPool.UnsafeQueueUserWorkItem(m_PostReceiveDelegate, this);
		}
	}

	private void InitializeParseStatusLine()
	{
		m_StatusState = 0;
		m_StatusLineValues.MajorVersion = 0;
		m_StatusLineValues.MinorVersion = 0;
		m_StatusLineValues.StatusCode = 0;
		m_StatusLineValues.StatusDescription = null;
	}

	private DataParseStatus ParseStatusLine(byte[] statusLine, int statusLineLength, ref int bytesParsed, ref int[] statusLineInts, ref string statusDescription, ref int statusState, ref WebParseError parseError)
	{
		DataParseStatus dataParseStatus = DataParseStatus.Done;
		int num = 0;
		int num2 = -1;
		int num3 = 0;
		while (true)
		{
			if (bytesParsed < statusLineLength && statusLine[bytesParsed] != 13 && statusLine[bytesParsed] != 10)
			{
				switch (statusState)
				{
				case 0:
					if (statusLine[bytesParsed] == 47)
					{
						statusState++;
					}
					else if (statusLine[bytesParsed] == 32)
					{
						statusState = 3;
					}
					break;
				case 1:
					if (statusLine[bytesParsed] == 46)
					{
						statusState++;
						break;
					}
					goto case 2;
				case 2:
					if (statusLine[bytesParsed] == 32)
					{
						statusState++;
						break;
					}
					goto case 3;
				case 3:
					if (char.IsDigit((char)statusLine[bytesParsed]))
					{
						int num4 = statusLine[bytesParsed] - 48;
						statusLineInts[statusState] = statusLineInts[statusState] * 10 + num4;
					}
					else if (statusLineInts[3] > 0)
					{
						statusState++;
					}
					else if (!char.IsWhiteSpace((char)statusLine[bytesParsed]))
					{
						statusLineInts[statusState] = -1;
					}
					break;
				case 4:
					if (statusLine[bytesParsed] != 32)
					{
						num3 = bytesParsed;
						if (num2 == -1)
						{
							num2 = bytesParsed;
						}
					}
					break;
				}
				bytesParsed++;
				if (m_MaximumResponseHeadersLength >= 0 && ++m_TotalResponseHeadersLength >= m_MaximumResponseHeadersLength)
				{
					dataParseStatus = DataParseStatus.DataTooBig;
					break;
				}
				continue;
			}
			num = bytesParsed;
			if (num2 != -1)
			{
				statusDescription += WebHeaderCollection.HeaderEncoding.GetString(statusLine, num2, num3 - num2 + 1);
			}
			if (bytesParsed == statusLineLength)
			{
				return DataParseStatus.NeedMoreData;
			}
			while (true)
			{
				if (bytesParsed < statusLineLength && (statusLine[bytesParsed] == 13 || statusLine[bytesParsed] == 32))
				{
					bytesParsed++;
					if (m_MaximumResponseHeadersLength >= 0 && ++m_TotalResponseHeadersLength >= m_MaximumResponseHeadersLength)
					{
						dataParseStatus = DataParseStatus.DataTooBig;
						break;
					}
					continue;
				}
				if (bytesParsed == statusLineLength)
				{
					dataParseStatus = DataParseStatus.NeedMoreData;
				}
				else if (statusLine[bytesParsed] == 10)
				{
					bytesParsed++;
					dataParseStatus = ((m_MaximumResponseHeadersLength < 0 || ++m_TotalResponseHeadersLength < m_MaximumResponseHeadersLength) ? DataParseStatus.Done : DataParseStatus.DataTooBig);
				}
				break;
			}
			break;
		}
		if (dataParseStatus == DataParseStatus.Done && statusState != 4 && (statusState != 3 || statusLineInts[3] <= 0))
		{
			dataParseStatus = DataParseStatus.Invalid;
		}
		if (dataParseStatus == DataParseStatus.Invalid)
		{
			parseError.Section = WebParseErrorSection.ResponseStatusLine;
			parseError.Code = WebParseErrorCode.Generic;
		}
		return dataParseStatus;
	}

	private unsafe static DataParseStatus ParseStatusLineStrict(byte[] statusLine, int statusLineLength, ref int bytesParsed, ref int statusState, StatusLineValues statusLineValues, int maximumHeaderLength, ref int totalBytesParsed, ref WebParseError parseError)
	{
		int num = bytesParsed;
		DataParseStatus dataParseStatus = DataParseStatus.DataTooBig;
		int num2 = ((maximumHeaderLength <= 0) ? int.MaxValue : (maximumHeaderLength - totalBytesParsed + bytesParsed));
		if (statusLineLength < num2)
		{
			dataParseStatus = DataParseStatus.NeedMoreData;
			num2 = statusLineLength;
		}
		if (bytesParsed < num2)
		{
			fixed (byte* ptr = statusLine)
			{
				switch (statusState)
				{
				default:
					goto end_IL_0030;
				case 0:
					while (true)
					{
						if (totalBytesParsed - num + bytesParsed < "HTTP/".Length)
						{
							if ((byte)"HTTP/"[totalBytesParsed - num + bytesParsed] != ptr[bytesParsed])
							{
								dataParseStatus = DataParseStatus.Invalid;
								break;
							}
							if (++bytesParsed == num2)
							{
								break;
							}
							continue;
						}
						if (ptr[bytesParsed] == 46)
						{
							dataParseStatus = DataParseStatus.Invalid;
							break;
						}
						statusState = 1;
						goto case 1;
					}
					goto end_IL_0030;
				case 1:
					while (true)
					{
						if (ptr[bytesParsed] != 46)
						{
							if (ptr[bytesParsed] < 48 || ptr[bytesParsed] > 57)
							{
								dataParseStatus = DataParseStatus.Invalid;
								break;
							}
							statusLineValues.MajorVersion = statusLineValues.MajorVersion * 10 + ptr[bytesParsed] - 48;
							if (++bytesParsed == num2)
							{
								break;
							}
							continue;
						}
						if (bytesParsed + 1 == num2)
						{
							break;
						}
						bytesParsed++;
						if (ptr[bytesParsed] == 32)
						{
							dataParseStatus = DataParseStatus.Invalid;
							break;
						}
						statusState = 2;
						goto case 2;
					}
					goto end_IL_0030;
				case 2:
					while (true)
					{
						if (ptr[bytesParsed] != 32)
						{
							if (ptr[bytesParsed] < 48 || ptr[bytesParsed] > 57)
							{
								dataParseStatus = DataParseStatus.Invalid;
							}
							else
							{
								statusLineValues.MinorVersion = statusLineValues.MinorVersion * 10 + ptr[bytesParsed] - 48;
								if (++bytesParsed != num2)
								{
									continue;
								}
							}
						}
						else
						{
							statusState = 3;
							statusLineValues.StatusCode = 1;
							if (++bytesParsed != num2)
							{
								break;
							}
						}
						goto end_IL_0030;
					}
					goto case 3;
				case 3:
					while (ptr[bytesParsed] >= 48 && ptr[bytesParsed] <= 57)
					{
						if (statusLineValues.StatusCode >= 1000)
						{
							dataParseStatus = DataParseStatus.Invalid;
						}
						else
						{
							statusLineValues.StatusCode = statusLineValues.StatusCode * 10 + ptr[bytesParsed] - 48;
							if (++bytesParsed != num2)
							{
								continue;
							}
						}
						goto end_IL_0030;
					}
					if (ptr[bytesParsed] != 32 || statusLineValues.StatusCode < 1000)
					{
						if (ptr[bytesParsed] == 13 && statusLineValues.StatusCode >= 1000)
						{
							statusLineValues.StatusDescription = statusLineValues.StatusDescription ?? string.Empty;
							statusLineValues.StatusCode -= 1000;
							statusState = 5;
							if (++bytesParsed != num2)
							{
								break;
							}
						}
						else
						{
							dataParseStatus = DataParseStatus.Invalid;
						}
					}
					else
					{
						statusLineValues.StatusCode -= 1000;
						statusState = 4;
						if (++bytesParsed != num2)
						{
							goto case 4;
						}
					}
					goto end_IL_0030;
				case 4:
				{
					if (statusLineValues.StatusDescription == null)
					{
						string[] array = s_ShortcutStatusDescriptions;
						foreach (string text in array)
						{
							if (bytesParsed >= num2 - text.Length || ptr[bytesParsed] != (byte)text[0])
							{
								continue;
							}
							byte* ptr2 = ptr + bytesParsed + 1;
							int j;
							for (j = 1; j < text.Length; j++)
							{
								if (*(ptr2++) != (byte)text[j])
								{
									break;
								}
							}
							if (j == text.Length)
							{
								statusLineValues.StatusDescription = text;
								bytesParsed += text.Length;
							}
							break;
						}
					}
					int num3 = bytesParsed;
					while (true)
					{
						if (ptr[bytesParsed] != 13)
						{
							if (ptr[bytesParsed] < 32 || ptr[bytesParsed] == 127)
							{
								dataParseStatus = DataParseStatus.Invalid;
							}
							else
							{
								if (++bytesParsed != num2)
								{
									continue;
								}
								string text2 = WebHeaderCollection.HeaderEncoding.GetString(ptr + num3, bytesParsed - num3);
								if (statusLineValues.StatusDescription == null)
								{
									statusLineValues.StatusDescription = text2;
								}
								else
								{
									statusLineValues.StatusDescription += text2;
								}
							}
						}
						else
						{
							if (bytesParsed > num3)
							{
								string text3 = WebHeaderCollection.HeaderEncoding.GetString(ptr + num3, bytesParsed - num3);
								if (statusLineValues.StatusDescription == null)
								{
									statusLineValues.StatusDescription = text3;
								}
								else
								{
									statusLineValues.StatusDescription += text3;
								}
							}
							else if (statusLineValues.StatusDescription == null)
							{
								statusLineValues.StatusDescription = "";
							}
							statusState = 5;
							if (++bytesParsed != num2)
							{
								break;
							}
						}
						goto end_IL_0030;
					}
					break;
				}
				case 5:
					break;
				}
				if (ptr[bytesParsed] != 10)
				{
					dataParseStatus = DataParseStatus.Invalid;
				}
				else
				{
					dataParseStatus = DataParseStatus.Done;
					bytesParsed++;
				}
				end_IL_0030:;
			}
		}
		totalBytesParsed += bytesParsed - num;
		if (dataParseStatus == DataParseStatus.Invalid)
		{
			parseError.Section = WebParseErrorSection.ResponseStatusLine;
			parseError.Code = WebParseErrorCode.Generic;
		}
		return dataParseStatus;
	}

	private void SetStatusLineParsed()
	{
		m_ResponseData.m_StatusCode = (HttpStatusCode)m_StatusLineValues.StatusCode;
		m_ResponseData.m_StatusDescription = m_StatusLineValues.StatusDescription;
		m_ResponseData.m_IsVersionHttp11 = m_StatusLineValues.MajorVersion >= 1 && m_StatusLineValues.MinorVersion >= 1;
		if (ServicePoint.HttpBehaviour == HttpBehaviour.Unknown || (ServicePoint.HttpBehaviour == HttpBehaviour.HTTP11 && !m_ResponseData.m_IsVersionHttp11))
		{
			ServicePoint.HttpBehaviour = ((!m_ResponseData.m_IsVersionHttp11) ? HttpBehaviour.HTTP10 : HttpBehaviour.HTTP11);
		}
		if (ServicePointManager.UseHttpPipeliningAndBufferPooling)
		{
			m_CanPipeline = ServicePoint.SupportsPipelining;
		}
	}

	private long ProcessHeaderData(ref bool fHaveChunked, HttpWebRequest request, out bool dummyResponseStream)
	{
		long result = -1L;
		fHaveChunked = false;
		string text = m_ResponseData.m_ResponseHeaders["Transfer-Encoding"];
		if (text != null)
		{
			text = text.ToLower(CultureInfo.InvariantCulture);
			fHaveChunked = text.IndexOf("chunked") != -1;
		}
		if (!fHaveChunked)
		{
			string text2 = m_ResponseData.m_ResponseHeaders.ContentLength;
			if (text2 != null)
			{
				int num = text2.IndexOf(':');
				if (num != -1)
				{
					text2 = text2.Substring(num + 1);
				}
				if (!long.TryParse(text2, NumberStyles.None, CultureInfo.InvariantCulture.NumberFormat, out result))
				{
					result = -1L;
					num = text2.LastIndexOf(',');
					if (num != -1)
					{
						text2 = text2.Substring(num + 1);
						if (!long.TryParse(text2, NumberStyles.None, CultureInfo.InvariantCulture.NumberFormat, out result))
						{
							result = -1L;
						}
					}
				}
				if (result < 0)
				{
					result = -2L;
				}
			}
		}
		dummyResponseStream = !request.CanGetResponseStream || m_ResponseData.m_StatusCode < HttpStatusCode.OK || m_ResponseData.m_StatusCode == HttpStatusCode.NoContent || (m_ResponseData.m_StatusCode == HttpStatusCode.NotModified && result < 0);
		if (m_KeepAlive)
		{
			bool flag = false;
			if (!dummyResponseStream && result < 0 && !fHaveChunked)
			{
				flag = true;
			}
			else if (m_ResponseData.m_StatusCode == HttpStatusCode.Forbidden && base.NetworkStream is TlsStream)
			{
				flag = true;
			}
			else if (m_ResponseData.m_StatusCode > (HttpStatusCode)299 && (request.CurrentMethod == KnownHttpVerb.Post || request.CurrentMethod == KnownHttpVerb.Put) && m_MaximumUnauthorizedUploadLength >= 0 && request.ContentLength > m_MaximumUnauthorizedUploadLength && (request.CurrentAuthenticationState == null || request.CurrentAuthenticationState.Module == null))
			{
				flag = true;
			}
			else
			{
				bool flag2 = false;
				bool flag3 = false;
				string text3 = m_ResponseData.m_ResponseHeaders["Connection"];
				if (text3 == null && (ServicePoint.InternalProxyServicePoint || request.IsTunnelRequest))
				{
					text3 = m_ResponseData.m_ResponseHeaders["Proxy-Connection"];
				}
				if (text3 != null)
				{
					text3 = text3.ToLower(CultureInfo.InvariantCulture);
					if (text3.IndexOf("keep-alive") != -1)
					{
						flag3 = true;
					}
					else if (text3.IndexOf("close") != -1)
					{
						flag2 = true;
					}
				}
				if ((flag2 && ServicePoint.HttpBehaviour == HttpBehaviour.HTTP11) || (!flag3 && (int)ServicePoint.HttpBehaviour <= 1))
				{
					flag = true;
				}
			}
			if (flag)
			{
				lock (this)
				{
					m_KeepAlive = false;
					m_Free = false;
				}
			}
		}
		return result;
	}

	private DataParseStatus ParseStreamData(ref ConnectionReturnResult returnResult)
	{
		if (m_CurrentRequest == null)
		{
			m_ParseError.Section = WebParseErrorSection.Generic;
			m_ParseError.Code = WebParseErrorCode.UnexpectedServerResponse;
			return DataParseStatus.Invalid;
		}
		bool fHaveChunked = false;
		bool dummyResponseStream;
		long num = ProcessHeaderData(ref fHaveChunked, m_CurrentRequest, out dummyResponseStream);
		if (num == -2)
		{
			m_ParseError.Section = WebParseErrorSection.ResponseHeader;
			m_ParseError.Code = WebParseErrorCode.InvalidContentLength;
			return DataParseStatus.Invalid;
		}
		int num2 = m_BytesRead - m_BytesScanned;
		if (m_ResponseData.m_StatusCode > (HttpStatusCode)299)
		{
			m_CurrentRequest.ErrorStatusCodeNotify(this, m_KeepAlive, fatal: false);
		}
		int num3;
		if (dummyResponseStream)
		{
			num3 = 0;
			fHaveChunked = false;
		}
		else
		{
			num3 = -1;
			if (!fHaveChunked && num <= int.MaxValue)
			{
				num3 = (int)num;
			}
		}
		DataParseStatus result;
		if (m_CurrentRequest.IsWebSocketRequest && m_ResponseData.m_StatusCode == HttpStatusCode.SwitchingProtocols)
		{
			m_ResponseData.m_ConnectStream = new ConnectStream(this, m_ReadBuffer, m_BytesScanned, num2, num2, fHaveChunked, m_CurrentRequest);
			result = DataParseStatus.Done;
			ClearReaderState();
		}
		else if (num3 != -1 && num3 <= num2)
		{
			m_ResponseData.m_ConnectStream = new ConnectStream(this, m_ReadBuffer, m_BytesScanned, num3, dummyResponseStream ? 0 : num, fHaveChunked, m_CurrentRequest);
			result = DataParseStatus.ContinueParsing;
			m_BytesScanned += num3;
		}
		else
		{
			m_ResponseData.m_ConnectStream = new ConnectStream(this, m_ReadBuffer, m_BytesScanned, num2, dummyResponseStream ? 0 : num, fHaveChunked, m_CurrentRequest);
			result = DataParseStatus.Done;
			ClearReaderState();
		}
		m_ResponseData.m_ContentLength = num;
		ConnectionReturnResult.Add(ref returnResult, m_CurrentRequest, m_ResponseData.Clone());
		return result;
	}

	private void ClearReaderState()
	{
		m_BytesRead = 0;
		m_BytesScanned = 0;
	}

	private DataParseStatus ParseResponseData(ref ConnectionReturnResult returnResult, out bool requestDone, out CoreResponseData continueResponseData)
	{
		DataParseStatus result = DataParseStatus.NeedMoreData;
		requestDone = false;
		continueResponseData = null;
		switch (m_ReadState)
		{
		case ReadState.Start:
			if (m_CurrentRequest == null)
			{
				lock (this)
				{
					if (m_WriteList.Count == 0 || (m_CurrentRequest = m_WriteList[0] as HttpWebRequest) == null)
					{
						m_ParseError.Section = WebParseErrorSection.Generic;
						m_ParseError.Code = WebParseErrorCode.Generic;
						result = DataParseStatus.Invalid;
						break;
					}
				}
			}
			m_KeepAlive &= m_CurrentRequest.KeepAlive || m_CurrentRequest.NtlmKeepAlive;
			m_MaximumResponseHeadersLength = m_CurrentRequest.MaximumResponseHeadersLength * 1024;
			m_ResponseData = new CoreResponseData();
			m_ReadState = ReadState.StatusLine;
			m_TotalResponseHeadersLength = 0;
			InitializeParseStatusLine();
			goto case ReadState.StatusLine;
		case ReadState.StatusLine:
		{
			DataParseStatus dataParseStatus;
			if (SettingsSectionInternal.Section.UseUnsafeHeaderParsing)
			{
				int[] statusLineInts = new int[4] { 0, m_StatusLineValues.MajorVersion, m_StatusLineValues.MinorVersion, m_StatusLineValues.StatusCode };
				if (m_StatusLineValues.StatusDescription == null)
				{
					m_StatusLineValues.StatusDescription = "";
				}
				dataParseStatus = ParseStatusLine(m_ReadBuffer, m_BytesRead, ref m_BytesScanned, ref statusLineInts, ref m_StatusLineValues.StatusDescription, ref m_StatusState, ref m_ParseError);
				m_StatusLineValues.MajorVersion = statusLineInts[1];
				m_StatusLineValues.MinorVersion = statusLineInts[2];
				m_StatusLineValues.StatusCode = statusLineInts[3];
			}
			else
			{
				dataParseStatus = ParseStatusLineStrict(m_ReadBuffer, m_BytesRead, ref m_BytesScanned, ref m_StatusState, m_StatusLineValues, m_MaximumResponseHeadersLength, ref m_TotalResponseHeadersLength, ref m_ParseError);
			}
			if (dataParseStatus == DataParseStatus.Done)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_received_status_line", m_StatusLineValues.MajorVersion + "." + m_StatusLineValues.MinorVersion, m_StatusLineValues.StatusCode, m_StatusLineValues.StatusDescription));
				}
				SetStatusLineParsed();
				m_ReadState = ReadState.Headers;
				m_ResponseData.m_ResponseHeaders = new WebHeaderCollection(WebHeaderCollectionType.HttpWebResponse);
				goto case ReadState.Headers;
			}
			if (dataParseStatus != DataParseStatus.NeedMoreData)
			{
				result = dataParseStatus;
			}
			break;
		}
		case ReadState.Headers:
		{
			if (m_BytesScanned >= m_BytesRead)
			{
				break;
			}
			DataParseStatus dataParseStatus = ((!SettingsSectionInternal.Section.UseUnsafeHeaderParsing) ? m_ResponseData.m_ResponseHeaders.ParseHeadersStrict(m_ReadBuffer, m_BytesRead, ref m_BytesScanned, ref m_TotalResponseHeadersLength, m_MaximumResponseHeadersLength, ref m_ParseError) : m_ResponseData.m_ResponseHeaders.ParseHeaders(m_ReadBuffer, m_BytesRead, ref m_BytesScanned, ref m_TotalResponseHeadersLength, m_MaximumResponseHeadersLength, ref m_ParseError));
			if (dataParseStatus == DataParseStatus.Invalid || dataParseStatus == DataParseStatus.DataTooBig)
			{
				result = dataParseStatus;
				break;
			}
			if (dataParseStatus != DataParseStatus.Done)
			{
				break;
			}
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_received_headers", m_ResponseData.m_ResponseHeaders.ToString(forTrace: true)));
			}
			if (m_IISVersion == -1)
			{
				string server = m_ResponseData.m_ResponseHeaders.Server;
				if (server != null && server.ToLower(CultureInfo.InvariantCulture).Contains("microsoft-iis"))
				{
					int num = server.IndexOf("/");
					if (num++ > 0 && num < server.Length)
					{
						m_IISVersion = server[num++] - 48;
						while (num < server.Length && char.IsDigit(server[num]))
						{
							m_IISVersion = m_IISVersion * 10 + server[num++] - 48;
						}
					}
				}
				if (m_IISVersion == -1 && m_ResponseData.m_StatusCode != HttpStatusCode.Continue)
				{
					m_IISVersion = 0;
				}
			}
			bool flag = ServicePointManager.UseStrictRfcInterimResponseHandling && m_ResponseData.m_StatusCode > HttpStatusCode.SwitchingProtocols && m_ResponseData.m_StatusCode < HttpStatusCode.OK;
			if (m_ResponseData.m_StatusCode == HttpStatusCode.Continue || m_ResponseData.m_StatusCode == HttpStatusCode.BadRequest || flag)
			{
				if (m_ResponseData.m_StatusCode != HttpStatusCode.BadRequest)
				{
					if (m_ResponseData.m_StatusCode == HttpStatusCode.Continue)
					{
						m_CurrentRequest.Saw100Continue = true;
						if (!ServicePoint.Understands100Continue)
						{
							ServicePoint.Understands100Continue = true;
						}
						continueResponseData = m_ResponseData;
					}
					goto case ReadState.Start;
				}
				if (ServicePoint.HttpBehaviour == HttpBehaviour.HTTP11 && m_CurrentRequest.HttpWriteMode == HttpWriteMode.Chunked && m_ResponseData.m_ResponseHeaders.Via != null && string.Compare(m_ResponseData.m_StatusDescription, "Bad Request ( The HTTP request includes a non-supported header. Contact the Server administrator.  )", StringComparison.OrdinalIgnoreCase) == 0)
				{
					ServicePoint.HttpBehaviour = HttpBehaviour.HTTP11PartiallyCompliant;
				}
			}
			m_ReadState = ReadState.Data;
			goto case ReadState.Data;
		}
		case ReadState.Data:
			requestDone = true;
			result = ParseStreamData(ref returnResult);
			break;
		}
		if (m_BytesScanned == m_BytesRead)
		{
			ClearReaderState();
		}
		return result;
	}

	internal void CloseOnIdle()
	{
		lock (this)
		{
			m_KeepAlive = false;
			m_RemovedFromConnectionList = true;
			if (!m_Idle)
			{
				CheckIdle();
			}
			if (m_Idle)
			{
				AbortSocket(isAbortState: false);
				GC.SuppressFinalize(this);
			}
		}
	}

	internal bool AbortOrDisassociate(HttpWebRequest request, WebException webException)
	{
		ConnectionReturnResult returnResult = null;
		lock (this)
		{
			int num = m_WriteList.IndexOf(request);
			if (num == -1)
			{
				WaitListItem waitListItem = null;
				if (m_WaitList.Count > 0)
				{
					waitListItem = m_WaitList.Find((WaitListItem o) => o.Request == request);
				}
				if (waitListItem != null)
				{
					NetworkingPerfCounters.Instance.IncrementAverage(NetworkingPerfCounterName.HttpWebRequestAvgQueueTime, waitListItem.QueueStartTime);
					m_WaitList.Remove(waitListItem);
					UnlockIfNeeded(waitListItem.Request);
				}
				return true;
			}
			m_KeepAlive = false;
			if (webException != null && m_InnerException == null)
			{
				m_InnerException = webException;
				m_Error = webException.Status;
			}
			else
			{
				m_Error = WebExceptionStatus.RequestCanceled;
			}
			PrepareCloseConnectionSocket(ref returnResult, num);
			Close(0);
		}
		ConnectionReturnResult.SetResponses(returnResult);
		return false;
	}

	internal void AbortSocket(bool isAbortState)
	{
		m_AbortSocketCalledUtc = DateTime.UtcNow;
		if (isAbortState)
		{
			UnlockRequest();
			CheckIdle();
		}
		else
		{
			m_Error = WebExceptionStatus.KeepAliveFailure;
		}
		lock (this)
		{
			Close(0);
		}
	}

	private void PrepareCloseConnectionSocket(ref ConnectionReturnResult returnResult, int abortedPipelinedRequestIndex = 0)
	{
		m_PrepareCloseConnectionSocketCalledUtc = DateTime.UtcNow;
		m_IdleSinceUtc = DateTime.MinValue;
		base.CanBePooled = false;
		if (m_WriteList.Count != 0 || m_WaitList.Count != 0)
		{
			HttpWebRequest lockedRequest = LockedRequest;
			if (lockedRequest != null)
			{
				bool flag = false;
				foreach (HttpWebRequest write in m_WriteList)
				{
					if (write == lockedRequest)
					{
						flag = true;
					}
				}
				if (!flag)
				{
					foreach (WaitListItem wait in m_WaitList)
					{
						if (wait.Request == lockedRequest)
						{
							flag = true;
							break;
						}
					}
				}
				if (flag)
				{
					UnlockRequest();
				}
			}
			HttpWebRequest[] array = null;
			if (m_WaitList.Count != 0)
			{
				array = new HttpWebRequest[m_WaitList.Count];
				for (int i = 0; i < m_WaitList.Count; i++)
				{
					array[i] = m_WaitList[i].Request;
				}
				ConnectionReturnResult.AddExceptionRange(ref returnResult, array, ExceptionHelper.IsolatedException);
			}
			if (m_WriteList.Count != 0)
			{
				Exception ex = m_InnerException;
				if (!(ex is WebException) && !(ex is SecurityException))
				{
					if (m_Error == WebExceptionStatus.ServerProtocolViolation)
					{
						string text = NetRes.GetWebStatusString(m_Error);
						string text2 = "";
						if (m_ParseError.Section != WebParseErrorSection.Generic)
						{
							text2 = text2 + " Section=" + m_ParseError.Section;
						}
						if (m_ParseError.Code != WebParseErrorCode.Generic)
						{
							text2 = text2 + " Detail=" + SR.GetString("net_WebResponseParseError_" + m_ParseError.Code);
						}
						if (text2.Length != 0)
						{
							text = text + "." + text2;
						}
						ex = new WebException(text, ex, m_Error, null, WebExceptionInternalStatus.RequestFatal);
					}
					else if (m_Error == WebExceptionStatus.SecureChannelFailure)
					{
						ex = new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.SecureChannelFailure), WebExceptionStatus.SecureChannelFailure);
					}
					else if (m_Error == WebExceptionStatus.Timeout)
					{
						ex = new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.Timeout), WebExceptionStatus.Timeout);
					}
					else if (m_Error == WebExceptionStatus.RequestCanceled)
					{
						ex = new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled, WebExceptionInternalStatus.RequestFatal, ex);
					}
					else if (m_Error == WebExceptionStatus.MessageLengthLimitExceeded || m_Error == WebExceptionStatus.TrustFailure)
					{
						ex = new WebException(NetRes.GetWebStatusString("net_connclosed", m_Error), m_Error, WebExceptionInternalStatus.RequestFatal, ex);
					}
					else
					{
						if (m_Error == WebExceptionStatus.Success)
						{
							throw new InternalException();
						}
						bool flag2 = false;
						bool flag3 = false;
						if (m_WriteList.Count != 1)
						{
							flag2 = true;
						}
						else if (m_Error == WebExceptionStatus.KeepAliveFailure)
						{
							HttpWebRequest httpWebRequest2 = (HttpWebRequest)m_WriteList[0];
							if (!httpWebRequest2.BodyStarted)
							{
								flag3 = true;
							}
						}
						else
						{
							flag2 = !AtLeastOneResponseReceived && !((HttpWebRequest)m_WriteList[0]).BodyStarted;
						}
						ex = new WebException(NetRes.GetWebStatusString("net_connclosed", m_Error), m_Error, flag3 ? WebExceptionInternalStatus.Isolated : (flag2 ? WebExceptionInternalStatus.Recoverable : WebExceptionInternalStatus.RequestFatal), ex);
					}
				}
				WebException exception = new WebException(NetRes.GetWebStatusString("net_connclosed", WebExceptionStatus.PipelineFailure), WebExceptionStatus.PipelineFailure, WebExceptionInternalStatus.Recoverable, ex);
				array = new HttpWebRequest[m_WriteList.Count];
				m_WriteList.CopyTo(array, 0);
				ConnectionReturnResult.AddExceptionRange(ref returnResult, array, abortedPipelinedRequestIndex, exception, ex);
			}
			m_WriteList.Clear();
			foreach (WaitListItem wait2 in m_WaitList)
			{
				NetworkingPerfCounters.Instance.IncrementAverage(NetworkingPerfCounterName.HttpWebRequestAvgQueueTime, wait2.QueueStartTime);
			}
			m_WaitList.Clear();
		}
		CheckIdle();
		if (m_Idle)
		{
			GC.SuppressFinalize(this);
		}
		if (!m_RemovedFromConnectionList && ConnectionGroup != null)
		{
			RemoveFromConnectionList();
		}
	}

	internal void RemoveFromConnectionList()
	{
		m_RemovedFromConnectionList = true;
		ConnectionGroup.Disassociate(this);
	}

	internal void HandleConnectStreamException(bool writeDone, bool readDone, WebExceptionStatus webExceptionStatus, ref ConnectionReturnResult returnResult, Exception e)
	{
		if (m_InnerException == null)
		{
			m_InnerException = e;
			if (!(e is WebException) && base.NetworkStream is TlsStream)
			{
				webExceptionStatus = ((TlsStream)base.NetworkStream).ExceptionStatus;
			}
			else if (e is ObjectDisposedException)
			{
				webExceptionStatus = WebExceptionStatus.RequestCanceled;
			}
		}
		HandleError(writeDone, readDone, webExceptionStatus, ref returnResult);
	}

	private void HandleErrorWithReadDone(WebExceptionStatus webExceptionStatus, ref ConnectionReturnResult returnResult)
	{
		HandleError(writeDone: false, readDone: true, webExceptionStatus, ref returnResult);
	}

	private void HandleError(bool writeDone, bool readDone, WebExceptionStatus webExceptionStatus, ref ConnectionReturnResult returnResult)
	{
		lock (this)
		{
			if (writeDone)
			{
				m_WriteDone = true;
			}
			if (readDone)
			{
				m_ReadDone = true;
			}
			if (webExceptionStatus == WebExceptionStatus.Success)
			{
				throw new InternalException();
			}
			m_Error = webExceptionStatus;
			PrepareCloseConnectionSocket(ref returnResult);
			Close(0);
		}
	}

	private static void ReadCallbackWrapper(IAsyncResult asyncResult)
	{
		if (!asyncResult.CompletedSynchronously)
		{
			((Connection)asyncResult.AsyncState).ReadCallback(asyncResult);
		}
	}

	private void ReadCallback(IAsyncResult asyncResult)
	{
		int num = -1;
		WebExceptionStatus webExceptionStatus = WebExceptionStatus.ReceiveFailure;
		try
		{
			num = EndRead(asyncResult);
			if (num == 0)
			{
				num = -1;
			}
			webExceptionStatus = WebExceptionStatus.Success;
		}
		catch (Exception ex)
		{
			m_CurrentRequest?.ErrorStatusCodeNotify(this, isKeepAlive: false, fatal: true);
			if (m_InnerException == null)
			{
				m_InnerException = ex;
			}
			if (ex.GetType() == typeof(ObjectDisposedException))
			{
				webExceptionStatus = WebExceptionStatus.RequestCanceled;
			}
			webExceptionStatus = ((!(base.NetworkStream is TlsStream)) ? WebExceptionStatus.ReceiveFailure : ((TlsStream)base.NetworkStream).ExceptionStatus);
		}
		ReadComplete(num, webExceptionStatus);
	}

	internal void PollAndRead(HttpWebRequest request, bool userRetrievedStream)
	{
		request.NeedsToReadForResponse = true;
		if (request.ConnectionReaderAsyncResult.InternalPeekCompleted && request.ConnectionReaderAsyncResult.Result == null && base.CanBePooled)
		{
			SyncRead(request, userRetrievedStream, probeRead: true);
		}
	}

	internal void SyncRead(HttpWebRequest request, bool userRetrievedStream, bool probeRead)
	{
		if (t_SyncReadNesting > 0)
		{
			return;
		}
		bool flag = !probeRead;
		try
		{
			t_SyncReadNesting++;
			int num = (probeRead ? request.RequestContinueCount : 0);
			int num2 = -1;
			WebExceptionStatus errorStatus = WebExceptionStatus.ReceiveFailure;
			if (m_BytesScanned < m_BytesRead)
			{
				flag = true;
				num2 = 0;
				errorStatus = WebExceptionStatus.Success;
			}
			bool flag2;
			do
			{
				flag2 = true;
				try
				{
					if (num2 != 0)
					{
						errorStatus = WebExceptionStatus.ReceiveFailure;
						if (!flag)
						{
							flag = Poll(request.ContinueTimeout * 1000, SelectMode.SelectRead);
						}
						if (flag)
						{
							ReadTimeout = request.Timeout;
							num2 = Read(m_ReadBuffer, m_BytesRead, m_ReadBuffer.Length - m_BytesRead);
							errorStatus = WebExceptionStatus.Success;
							if (num2 == 0)
							{
								num2 = -1;
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
					if (m_InnerException == null)
					{
						m_InnerException = ex;
					}
					if (ex.GetType() == typeof(ObjectDisposedException))
					{
						errorStatus = WebExceptionStatus.RequestCanceled;
					}
					else if (base.NetworkStream is TlsStream)
					{
						errorStatus = ((TlsStream)base.NetworkStream).ExceptionStatus;
					}
					else if (ex.InnerException is SocketException ex2)
					{
						errorStatus = ((ex2.ErrorCode != 10060) ? WebExceptionStatus.ReceiveFailure : WebExceptionStatus.Timeout);
					}
				}
				if (flag)
				{
					flag2 = ReadComplete(num2, errorStatus);
				}
				num2 = -1;
			}
			while (!flag2 && (userRetrievedStream || num == request.RequestContinueCount));
		}
		finally
		{
			t_SyncReadNesting--;
		}
		if (!probeRead)
		{
			return;
		}
		request.FinishContinueWait();
		if (flag)
		{
			if (!request.Saw100Continue && !userRetrievedStream)
			{
				request.NeedsToReadForResponse = false;
			}
		}
		else
		{
			request.SetRequestContinue();
		}
	}

	private bool ReadComplete(int bytesRead, WebExceptionStatus errorStatus)
	{
		bool requestDone = true;
		CoreResponseData continueResponseData = null;
		ConnectionReturnResult returnResult = null;
		HttpWebRequest httpWebRequest = null;
		try
		{
			if (bytesRead < 0)
			{
				if (m_ReadState == ReadState.Start && m_AtLeastOneResponseReceived)
				{
					if (errorStatus == WebExceptionStatus.Success || errorStatus == WebExceptionStatus.ReceiveFailure)
					{
						errorStatus = WebExceptionStatus.KeepAliveFailure;
					}
				}
				else if (errorStatus == WebExceptionStatus.Success)
				{
					errorStatus = WebExceptionStatus.ConnectionClosed;
				}
				m_CurrentRequest?.ErrorStatusCodeNotify(this, isKeepAlive: false, fatal: true);
				HandleErrorWithReadDone(errorStatus, ref returnResult);
			}
			else
			{
				bytesRead += m_BytesRead;
				if (bytesRead > m_ReadBuffer.Length)
				{
					throw new InternalException();
				}
				m_BytesRead = bytesRead;
				DataParseStatus dataParseStatus = ParseResponseData(ref returnResult, out requestDone, out continueResponseData);
				httpWebRequest = m_CurrentRequest;
				if (dataParseStatus != DataParseStatus.NeedMoreData)
				{
					m_CurrentRequest = null;
				}
				switch (dataParseStatus)
				{
				case DataParseStatus.Invalid:
				case DataParseStatus.DataTooBig:
					httpWebRequest?.ErrorStatusCodeNotify(this, isKeepAlive: false, fatal: false);
					if (dataParseStatus == DataParseStatus.Invalid)
					{
						HandleErrorWithReadDone(WebExceptionStatus.ServerProtocolViolation, ref returnResult);
					}
					else
					{
						HandleErrorWithReadDone(WebExceptionStatus.MessageLengthLimitExceeded, ref returnResult);
					}
					break;
				case DataParseStatus.NeedMoreData:
				{
					int num = m_BytesRead - m_BytesScanned;
					if (num != 0)
					{
						if (m_BytesScanned == 0 && m_BytesRead == m_ReadBuffer.Length)
						{
							byte[] array = new byte[m_ReadBuffer.Length * 2];
							Buffer.BlockCopy(m_ReadBuffer, 0, array, 0, m_BytesRead);
							FreeReadBuffer();
							m_ReadBuffer = array;
						}
						else
						{
							Buffer.BlockCopy(m_ReadBuffer, m_BytesScanned, m_ReadBuffer, 0, num);
						}
					}
					m_BytesRead = num;
					m_BytesScanned = 0;
					if (httpWebRequest != null && httpWebRequest.Async)
					{
						if (Thread.CurrentThread.IsThreadPoolThread)
						{
							PostReceive();
						}
						else
						{
							ThreadPool.UnsafeQueueUserWorkItem(m_PostReceiveDelegate, this);
						}
					}
					break;
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
			requestDone = true;
			if (m_InnerException == null)
			{
				m_InnerException = ex;
			}
			m_CurrentRequest?.ErrorStatusCodeNotify(this, isKeepAlive: false, fatal: true);
			HandleErrorWithReadDone(WebExceptionStatus.ReceiveFailure, ref returnResult);
		}
		try
		{
			if (httpWebRequest != null && httpWebRequest.HttpWriteMode != HttpWriteMode.None && (continueResponseData != null || (returnResult != null && returnResult.IsNotEmpty && httpWebRequest.AllowWriteStreamBuffering)) && httpWebRequest.FinishContinueWait())
			{
				httpWebRequest.SetRequestContinue(continueResponseData);
			}
		}
		finally
		{
			ConnectionReturnResult.SetResponses(returnResult);
		}
		return requestDone;
	}

	internal void Write(ScatterGatherBuffers writeBuffer)
	{
		BufferOffsetSize[] buffers = writeBuffer.GetBuffers();
		if (buffers != null)
		{
			MultipleWrite(buffers);
		}
	}

	private static void PostReceiveWrapper(object state)
	{
		Connection connection = state as Connection;
		connection.PostReceive();
	}

	private void PostReceive()
	{
		try
		{
			if (m_LastAsyncResult != null && !m_LastAsyncResult.IsCompleted)
			{
				throw new InternalException();
			}
			m_LastAsyncResult = UnsafeBeginRead(m_ReadBuffer, m_BytesRead, m_ReadBuffer.Length - m_BytesRead, m_ReadCallback, this);
			if (m_LastAsyncResult.CompletedSynchronously)
			{
				ReadCallback(m_LastAsyncResult);
			}
		}
		catch (Exception)
		{
			m_CurrentRequest?.ErrorStatusCodeNotify(this, isKeepAlive: false, fatal: true);
			ConnectionReturnResult returnResult = null;
			HandleErrorWithReadDone(WebExceptionStatus.ReceiveFailure, ref returnResult);
			ConnectionReturnResult.SetResponses(returnResult);
		}
	}

	private static void TunnelThroughProxyWrapper(IAsyncResult result)
	{
		if (result.CompletedSynchronously)
		{
			return;
		}
		bool flag = false;
		WebExceptionStatus webExceptionStatus = WebExceptionStatus.ConnectFailure;
		HttpWebRequest httpWebRequest = (HttpWebRequest)((LazyAsyncResult)result).AsyncObject;
		Connection connection = ((TunnelStateObject)result.AsyncState).Connection;
		HttpWebRequest originalRequest = ((TunnelStateObject)result.AsyncState).OriginalRequest;
		try
		{
			httpWebRequest.EndGetResponse(result);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			ConnectStream connectStream = (ConnectStream)httpWebResponse.GetResponseStream();
			connection.NetworkStream = new NetworkStream(connectStream.Connection.NetworkStream, ownsSocket: true);
			connectStream.Connection.NetworkStream.ConvertToNotSocketOwner();
			if (ServicePointManager.FinishProxyTunnelConnectionEarly)
			{
				connectStream.Connection.ForceFinishTunnelConnection();
			}
			else
			{
				originalRequest.TunnelConnection = connectStream.Connection;
			}
			flag = true;
		}
		catch (Exception ex)
		{
			if (connection.m_InnerException == null)
			{
				connection.m_InnerException = ex;
			}
			if (ex is WebException)
			{
				webExceptionStatus = ((WebException)ex).Status;
			}
		}
		if (!flag)
		{
			ConnectionReturnResult returnResult = null;
			connection.HandleError(writeDone: false, readDone: false, webExceptionStatus, ref returnResult);
			ConnectionReturnResult.SetResponses(returnResult);
		}
		else
		{
			connection.CompleteConnection(async: true, originalRequest);
		}
	}

	private bool TunnelThroughProxy(Uri proxy, HttpWebRequest originalRequest, bool async)
	{
		bool result = false;
		HttpWebRequest httpWebRequest = null;
		HttpWebResponse httpWebResponse = null;
		try
		{
			new WebPermission(NetworkAccess.Connect, proxy).Assert();
			try
			{
				httpWebRequest = new HttpWebRequest(proxy, originalRequest.Address, originalRequest);
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
			}
			httpWebRequest.Credentials = ((originalRequest.InternalProxy == null) ? null : originalRequest.InternalProxy.Credentials);
			httpWebRequest.InternalProxy = null;
			httpWebRequest.PreAuthenticate = true;
			httpWebRequest.UserAgent = originalRequest.UserAgent;
			if (async)
			{
				IAsyncResult asyncResult = httpWebRequest.BeginGetResponse(state: new TunnelStateObject(originalRequest, this), callback: m_TunnelCallback);
				if (!asyncResult.CompletedSynchronously)
				{
					return true;
				}
				httpWebResponse = (HttpWebResponse)httpWebRequest.EndGetResponse(asyncResult);
			}
			else
			{
				httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			}
			ConnectStream connectStream = (ConnectStream)httpWebResponse.GetResponseStream();
			base.NetworkStream = new NetworkStream(connectStream.Connection.NetworkStream, ownsSocket: true);
			connectStream.Connection.NetworkStream.ConvertToNotSocketOwner();
			if (ServicePointManager.FinishProxyTunnelConnectionEarly)
			{
				connectStream.Connection.ForceFinishTunnelConnection();
			}
			result = true;
		}
		catch (Exception innerException)
		{
			if (m_InnerException == null)
			{
				m_InnerException = innerException;
			}
		}
		return result;
	}

	private void ForceFinishTunnelConnection()
	{
		ServicePoint.DecrementConnection();
		ConnectionGroup.DecrementConnection();
		RemoveFromConnectionList();
	}

	private void CheckNonIdle()
	{
		if (m_Idle && BusyCount != 0)
		{
			m_Idle = false;
			ServicePoint.IncrementConnection();
			ConnectionGroup.IncrementConnection();
		}
	}

	private void CheckIdle()
	{
		if (!m_Idle && BusyCount == 0)
		{
			m_Idle = true;
			ServicePoint.DecrementConnection();
			if (ConnectionGroup != null)
			{
				ConnectionGroup.DecrementConnection();
				ConnectionGroup.ConnectionGoneIdle();
			}
			m_IdleSinceUtc = DateTime.UtcNow;
		}
	}

	[Conditional("TRAVE")]
	private void DebugDumpWriteListEntries()
	{
		for (int i = 0; i < m_WriteList.Count; i++)
		{
		}
	}

	[Conditional("TRAVE")]
	private void DebugDumpWaitListEntries()
	{
		for (int i = 0; i < m_WaitList.Count; i++)
		{
		}
	}

	[Conditional("TRAVE")]
	private void DebugDumpListEntry(int currentPos, HttpWebRequest req, string listType)
	{
	}

	[Conditional("DEBUG")]
	internal void DebugMembers(int requestHash)
	{
	}
}
