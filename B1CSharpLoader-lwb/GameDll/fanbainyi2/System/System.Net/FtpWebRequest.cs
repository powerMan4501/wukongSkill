using System.Diagnostics.Tracing;
using System.IO;
using System.Net.Cache;
using System.Net.Sockets;
using System.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Threading;

namespace System.Net;

public sealed class FtpWebRequest : WebRequest
{
	private enum RequestStage
	{
		CheckForError,
		RequestStarted,
		WriteReady,
		ReadReady,
		ReleaseConnection
	}

	private object m_SyncObject;

	private ICredentials m_AuthInfo;

	private readonly Uri m_Uri;

	private FtpMethodInfo m_MethodInfo;

	private string m_RenameTo;

	private bool m_GetRequestStreamStarted;

	private bool m_GetResponseStarted;

	private DateTime m_StartTime;

	private int m_Timeout = s_DefaultTimeout;

	private int m_RemainingTimeout;

	private long m_ContentLength;

	private long m_ContentOffset;

	private IWebProxy m_Proxy;

	private X509CertificateCollection m_ClientCertificates;

	private bool m_KeepAlive = true;

	private bool m_Passive = true;

	private bool m_Binary = true;

	private string m_ConnectionGroupName;

	private ServicePoint m_ServicePoint;

	private bool m_CacheDone;

	private bool m_Async;

	private bool m_Aborted;

	private bool m_TimedOut;

	private HttpWebRequest m_HttpWebRequest;

	private Exception m_Exception;

	private TimerThread.Queue m_TimerQueue = s_DefaultTimerQueue;

	private TimerThread.Callback m_TimerCallback;

	private bool m_EnableSsl;

	private bool m_ProxyUserSet;

	private ConnectionPool m_ConnectionPool;

	private FtpControlStream m_Connection;

	private Stream m_Stream;

	private RequestStage m_RequestStage;

	private bool m_OnceFailed;

	private WebHeaderCollection m_FtpRequestHeaders;

	private FtpWebResponse m_FtpWebResponse;

	private int m_ReadWriteTimeout = 300000;

	private ContextAwareResult m_WriteAsyncResult;

	private LazyAsyncResult m_ReadAsyncResult;

	private LazyAsyncResult m_RequestCompleteAsyncResult;

	private static readonly GeneralAsyncDelegate m_AsyncCallback = AsyncCallbackWrapper;

	private static readonly CreateConnectionDelegate m_CreateConnectionCallback = CreateFtpConnection;

	private static readonly NetworkCredential DefaultFtpNetworkCredential = new NetworkCredential("anonymous", "anonymous@", string.Empty);

	private static readonly int s_DefaultTimeout = 100000;

	private static readonly TimerThread.Queue s_DefaultTimerQueue = TimerThread.GetOrCreateQueue(s_DefaultTimeout);

	internal FtpMethodInfo MethodInfo => m_MethodInfo;

	internal static NetworkCredential DefaultNetworkCredential => DefaultFtpNetworkCredential;

	public new static RequestCachePolicy DefaultCachePolicy
	{
		get
		{
			RequestCachePolicy policy = RequestCacheManager.GetBinding(Uri.UriSchemeFtp).Policy;
			if (policy == null)
			{
				return WebRequest.DefaultCachePolicy;
			}
			return policy;
		}
		set
		{
			ExceptionHelper.WebPermissionUnrestricted.Demand();
			RequestCacheBinding binding = RequestCacheManager.GetBinding(Uri.UriSchemeFtp);
			RequestCacheManager.SetBinding(Uri.UriSchemeFtp, new RequestCacheBinding(binding.Cache, binding.Validator, value));
		}
	}

	public override string Method
	{
		get
		{
			return m_MethodInfo.Method;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException(SR.GetString("net_ftp_invalid_method_name"), "value");
			}
			if (InUse)
			{
				throw new InvalidOperationException(SR.GetString("net_reqsubmitted"));
			}
			try
			{
				m_MethodInfo = FtpMethodInfo.GetMethodInfo(value);
			}
			catch (ArgumentException)
			{
				throw new ArgumentException(SR.GetString("net_ftp_unsupported_method"), "value");
			}
		}
	}

	public string RenameTo
	{
		get
		{
			return m_RenameTo;
		}
		set
		{
			if (InUse)
			{
				throw new InvalidOperationException(SR.GetString("net_reqsubmitted"));
			}
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException(SR.GetString("net_ftp_invalid_renameto"), "value");
			}
			m_RenameTo = value;
		}
	}

	public override ICredentials Credentials
	{
		get
		{
			return m_AuthInfo;
		}
		set
		{
			if (InUse)
			{
				throw new InvalidOperationException(SR.GetString("net_reqsubmitted"));
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value is SystemNetworkCredential)
			{
				throw new ArgumentException(SR.GetString("net_ftp_no_defaultcreds"), "value");
			}
			m_AuthInfo = value;
		}
	}

	public override Uri RequestUri => m_Uri;

	public override int Timeout
	{
		get
		{
			return m_Timeout;
		}
		set
		{
			if (InUse)
			{
				throw new InvalidOperationException(SR.GetString("net_reqsubmitted"));
			}
			if (value < 0 && value != -1)
			{
				throw new ArgumentOutOfRangeException("value", SR.GetString("net_io_timeout_use_ge_zero"));
			}
			if (m_Timeout != value)
			{
				m_Timeout = value;
				m_TimerQueue = null;
			}
		}
	}

	internal int RemainingTimeout => m_RemainingTimeout;

	public int ReadWriteTimeout
	{
		get
		{
			return m_ReadWriteTimeout;
		}
		set
		{
			if (m_GetResponseStarted)
			{
				throw new InvalidOperationException(SR.GetString("net_reqsubmitted"));
			}
			if (value <= 0 && value != -1)
			{
				throw new ArgumentOutOfRangeException("value", SR.GetString("net_io_timeout_use_gt_zero"));
			}
			m_ReadWriteTimeout = value;
		}
	}

	public long ContentOffset
	{
		get
		{
			return m_ContentOffset;
		}
		set
		{
			if (InUse)
			{
				throw new InvalidOperationException(SR.GetString("net_reqsubmitted"));
			}
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			m_ContentOffset = value;
		}
	}

	public override long ContentLength
	{
		get
		{
			return m_ContentLength;
		}
		set
		{
			m_ContentLength = value;
		}
	}

	public override IWebProxy Proxy
	{
		get
		{
			ExceptionHelper.WebPermissionUnrestricted.Demand();
			return m_Proxy;
		}
		set
		{
			ExceptionHelper.WebPermissionUnrestricted.Demand();
			if (InUse)
			{
				throw new InvalidOperationException(SR.GetString("net_reqsubmitted"));
			}
			m_ProxyUserSet = true;
			m_Proxy = value;
			m_ServicePoint = null;
			ServicePoint servicePoint = ServicePoint;
		}
	}

	public override string ConnectionGroupName
	{
		get
		{
			return m_ConnectionGroupName;
		}
		set
		{
			if (InUse)
			{
				throw new InvalidOperationException(SR.GetString("net_reqsubmitted"));
			}
			m_ConnectionGroupName = value;
		}
	}

	public ServicePoint ServicePoint
	{
		get
		{
			if (m_ServicePoint == null)
			{
				IWebProxy proxy = m_Proxy;
				if (!m_ProxyUserSet)
				{
					proxy = WebRequest.InternalDefaultWebProxy;
				}
				ServicePoint servicePoint = ServicePointManager.FindServicePoint(m_Uri, proxy);
				lock (m_SyncObject)
				{
					if (m_ServicePoint == null)
					{
						m_ServicePoint = servicePoint;
						m_Proxy = proxy;
					}
				}
			}
			return m_ServicePoint;
		}
	}

	internal bool Aborted => m_Aborted;

	private TimerThread.Queue TimerQueue
	{
		get
		{
			if (m_TimerQueue == null)
			{
				m_TimerQueue = TimerThread.GetOrCreateQueue(RemainingTimeout);
			}
			return m_TimerQueue;
		}
	}

	public bool KeepAlive
	{
		get
		{
			return m_KeepAlive;
		}
		set
		{
			if (InUse)
			{
				throw new InvalidOperationException(SR.GetString("net_reqsubmitted"));
			}
			m_KeepAlive = value;
		}
	}

	public bool UseBinary
	{
		get
		{
			return m_Binary;
		}
		set
		{
			if (InUse)
			{
				throw new InvalidOperationException(SR.GetString("net_reqsubmitted"));
			}
			m_Binary = value;
		}
	}

	public bool UsePassive
	{
		get
		{
			return m_Passive;
		}
		set
		{
			if (InUse)
			{
				throw new InvalidOperationException(SR.GetString("net_reqsubmitted"));
			}
			m_Passive = value;
		}
	}

	public X509CertificateCollection ClientCertificates
	{
		get
		{
			if (m_ClientCertificates == null)
			{
				lock (m_SyncObject)
				{
					if (m_ClientCertificates == null)
					{
						m_ClientCertificates = new X509CertificateCollection();
					}
				}
			}
			return m_ClientCertificates;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			m_ClientCertificates = value;
		}
	}

	public bool EnableSsl
	{
		get
		{
			return m_EnableSsl;
		}
		set
		{
			if (InUse)
			{
				throw new InvalidOperationException(SR.GetString("net_reqsubmitted"));
			}
			m_EnableSsl = value;
		}
	}

	public override WebHeaderCollection Headers
	{
		get
		{
			if (HttpProxyMode)
			{
				return GetHttpWebRequest().Headers;
			}
			if (m_FtpRequestHeaders == null)
			{
				m_FtpRequestHeaders = new WebHeaderCollection(WebHeaderCollectionType.FtpWebRequest);
			}
			return m_FtpRequestHeaders;
		}
		set
		{
			if (HttpProxyMode)
			{
				GetHttpWebRequest().Headers = value;
			}
			m_FtpRequestHeaders = value;
		}
	}

	public override string ContentType
	{
		get
		{
			throw ExceptionHelper.PropertyNotSupportedException;
		}
		set
		{
			throw ExceptionHelper.PropertyNotSupportedException;
		}
	}

	public override bool UseDefaultCredentials
	{
		get
		{
			throw ExceptionHelper.PropertyNotSupportedException;
		}
		set
		{
			throw ExceptionHelper.PropertyNotSupportedException;
		}
	}

	public override bool PreAuthenticate
	{
		get
		{
			throw ExceptionHelper.PropertyNotSupportedException;
		}
		set
		{
			throw ExceptionHelper.PropertyNotSupportedException;
		}
	}

	private bool InUse
	{
		get
		{
			if (m_GetRequestStreamStarted || m_GetResponseStarted)
			{
				return true;
			}
			return false;
		}
	}

	private bool HttpProxyMode => m_HttpWebRequest != null;

	internal FtpWebRequest(Uri uri)
	{
		new WebPermission(NetworkAccess.Connect, uri).Demand();
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, ".ctor", uri.ToString());
		}
		if ((object)uri.Scheme != Uri.UriSchemeFtp)
		{
			throw new ArgumentOutOfRangeException("uri");
		}
		m_TimerCallback = TimerCallback;
		m_SyncObject = new object();
		NetworkCredential networkCredential = null;
		m_Uri = uri;
		m_MethodInfo = FtpMethodInfo.GetMethodInfo("RETR");
		if (m_Uri.UserInfo != null && m_Uri.UserInfo.Length != 0)
		{
			string userInfo = m_Uri.UserInfo;
			string userName = userInfo;
			string password = "";
			int num = userInfo.IndexOf(':');
			if (num != -1)
			{
				userName = Uri.UnescapeDataString(userInfo.Substring(0, num));
				num++;
				password = Uri.UnescapeDataString(userInfo.Substring(num, userInfo.Length - num));
			}
			networkCredential = new NetworkCredential(userName, password);
		}
		if (networkCredential == null)
		{
			networkCredential = DefaultFtpNetworkCredential;
		}
		m_AuthInfo = networkCredential;
		SetupCacheProtocol(m_Uri);
	}

	public override WebResponse GetResponse()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "GetResponse", "");
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, "GetResponse", SR.GetString("net_log_method_equal", m_MethodInfo.Method));
		}
		if (FrameworkEventSource.Log.IsEnabled())
		{
			LogBeginGetResponse(success: true, synchronous: true);
		}
		bool success = false;
		int statusCode = -1;
		try
		{
			CheckError();
			if (m_FtpWebResponse != null)
			{
				success = true;
				statusCode = GetStatusCode(m_FtpWebResponse);
				return m_FtpWebResponse;
			}
			if (m_GetResponseStarted)
			{
				throw new InvalidOperationException(SR.GetString("net_repcall"));
			}
			m_GetResponseStarted = true;
			m_StartTime = DateTime.UtcNow;
			m_RemainingTimeout = Timeout;
			ServicePoint servicePoint = ServicePoint;
			if (Timeout != -1)
			{
				m_RemainingTimeout = Timeout - (int)(DateTime.UtcNow - m_StartTime).TotalMilliseconds;
				if (m_RemainingTimeout <= 0)
				{
					throw new WebException(NetRes.GetWebStatusString(WebExceptionStatus.Timeout), WebExceptionStatus.Timeout);
				}
			}
			if (ServicePoint.InternalProxyServicePoint)
			{
				if (EnableSsl)
				{
					m_GetResponseStarted = false;
					throw new WebException(SR.GetString("net_ftp_proxy_does_not_support_ssl"));
				}
				try
				{
					HttpWebRequest httpWebRequest = GetHttpWebRequest();
					if (Logging.On)
					{
						Logging.Associate(Logging.Web, this, httpWebRequest);
					}
					m_FtpWebResponse = new FtpWebResponse((HttpWebResponse)httpWebRequest.GetResponse());
				}
				catch (WebException ex)
				{
					if (ex.Response != null && ex.Response is HttpWebResponse)
					{
						ex = new WebException(ex.Message, null, ex.Status, new FtpWebResponse((HttpWebResponse)ex.Response), ex.InternalStatus);
					}
					SetException(ex);
					statusCode = GetStatusCode(ex);
					throw ex;
				}
				catch (InvalidOperationException exception)
				{
					SetException(exception);
					FinishRequestStage(RequestStage.CheckForError);
					throw;
				}
			}
			else
			{
				RequestStage requestStage = FinishRequestStage(RequestStage.RequestStarted);
				if (requestStage >= RequestStage.RequestStarted)
				{
					if (requestStage < RequestStage.ReadReady)
					{
						lock (m_SyncObject)
						{
							if (m_RequestStage < RequestStage.ReadReady)
							{
								m_ReadAsyncResult = new LazyAsyncResult(null, null, null);
							}
						}
						if (m_ReadAsyncResult != null)
						{
							m_ReadAsyncResult.InternalWaitForCompletion();
						}
						CheckError();
					}
				}
				else
				{
					do
					{
						SubmitRequest(async: false);
						if (m_MethodInfo.IsUpload)
						{
							FinishRequestStage(RequestStage.WriteReady);
						}
						else
						{
							FinishRequestStage(RequestStage.ReadReady);
						}
						CheckError();
					}
					while (!CheckCacheRetrieveOnResponse());
					EnsureFtpWebResponse(null);
					CheckCacheUpdateOnResponse();
					if (m_FtpWebResponse.IsFromCache)
					{
						FinishRequestStage(RequestStage.ReleaseConnection);
					}
				}
			}
			statusCode = GetStatusCode(m_FtpWebResponse);
			success = true;
		}
		catch (Exception ex2)
		{
			if (FrameworkEventSource.Log.IsEnabled() && ex2 is WebException webException)
			{
				statusCode = GetStatusCode(webException);
			}
			if (Logging.On)
			{
				Logging.Exception(Logging.Web, this, "GetResponse", ex2);
			}
			if (m_Exception == null)
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.Web, SR.GetString("net_log_unexpected_exception", "GetResponse()"));
				}
				NclUtilities.IsFatal(ex2);
				SetException(ex2);
				FinishRequestStage(RequestStage.CheckForError);
			}
			throw;
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, this, "GetResponse", "");
			}
			if (FrameworkEventSource.Log.IsEnabled())
			{
				LogEndGetResponse(success, synchronous: true, statusCode);
			}
		}
		return m_FtpWebResponse;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "BeginGetResponse", "");
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, "BeginGetResponse", SR.GetString("net_log_method_equal", m_MethodInfo.Method));
		}
		bool success = true;
		ContextAwareResult contextAwareResult;
		try
		{
			if (m_FtpWebResponse != null)
			{
				contextAwareResult = new ContextAwareResult(this, state, callback);
				contextAwareResult.InvokeCallback(m_FtpWebResponse);
				return contextAwareResult;
			}
			if (m_GetResponseStarted)
			{
				throw new InvalidOperationException(SR.GetString("net_repcall"));
			}
			m_GetResponseStarted = true;
			CheckError();
			if (ServicePoint.InternalProxyServicePoint)
			{
				HttpWebRequest httpWebRequest = GetHttpWebRequest();
				if (Logging.On)
				{
					Logging.Associate(Logging.Web, this, httpWebRequest);
				}
				contextAwareResult = (ContextAwareResult)httpWebRequest.BeginGetResponse(callback, state);
			}
			else
			{
				RequestStage requestStage = FinishRequestStage(RequestStage.RequestStarted);
				contextAwareResult = (ContextAwareResult)(m_ReadAsyncResult = new ContextAwareResult(captureIdentity: true, forceCaptureContext: true, this, state, callback));
				if (requestStage >= RequestStage.RequestStarted)
				{
					contextAwareResult.StartPostingAsyncOp();
					contextAwareResult.FinishPostingAsyncOp();
					if (requestStage >= RequestStage.ReadReady)
					{
						contextAwareResult = null;
					}
					else
					{
						lock (m_SyncObject)
						{
							if (m_RequestStage >= RequestStage.ReadReady)
							{
								contextAwareResult = null;
							}
						}
					}
					if (contextAwareResult == null)
					{
						contextAwareResult = (ContextAwareResult)m_ReadAsyncResult;
						if (!contextAwareResult.InternalPeekCompleted)
						{
							contextAwareResult.InvokeCallback();
						}
					}
				}
				else
				{
					lock (contextAwareResult.StartPostingAsyncOp())
					{
						SubmitRequest(async: true);
						contextAwareResult.FinishPostingAsyncOp();
					}
					FinishRequestStage(RequestStage.CheckForError);
				}
			}
		}
		catch (Exception e)
		{
			success = false;
			if (Logging.On)
			{
				Logging.Exception(Logging.Web, this, "BeginGetResponse", e);
			}
			throw;
		}
		finally
		{
			if (FrameworkEventSource.Log.IsEnabled())
			{
				LogBeginGetResponse(success, synchronous: false);
			}
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, this, "BeginGetResponse", "");
			}
		}
		return contextAwareResult;
	}

	public override WebResponse EndGetResponse(IAsyncResult asyncResult)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "EndGetResponse", "");
		}
		bool success = false;
		int statusCode = -1;
		try
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (!(asyncResult is LazyAsyncResult lazyAsyncResult))
			{
				throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
			}
			if (HttpProxyMode ? (lazyAsyncResult.AsyncObject != GetHttpWebRequest()) : (lazyAsyncResult.AsyncObject != this))
			{
				throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
			}
			if (lazyAsyncResult.EndCalled)
			{
				throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndGetResponse"));
			}
			if (HttpProxyMode)
			{
				try
				{
					CheckError();
					if (m_FtpWebResponse == null)
					{
						m_FtpWebResponse = new FtpWebResponse((HttpWebResponse)GetHttpWebRequest().EndGetResponse(asyncResult));
						statusCode = GetStatusCode(m_FtpWebResponse);
					}
				}
				catch (WebException ex)
				{
					statusCode = GetStatusCode(ex);
					if (ex.Response != null && ex.Response is HttpWebResponse)
					{
						throw new WebException(ex.Message, null, ex.Status, new FtpWebResponse((HttpWebResponse)ex.Response), ex.InternalStatus);
					}
					throw;
				}
			}
			else
			{
				lazyAsyncResult.InternalWaitForCompletion();
				lazyAsyncResult.EndCalled = true;
				CheckError();
			}
			success = true;
		}
		catch (Exception ex2)
		{
			if (FrameworkEventSource.Log.IsEnabled() && ex2 is WebException webException)
			{
				statusCode = GetStatusCode(webException);
			}
			if (Logging.On)
			{
				Logging.Exception(Logging.Web, this, "EndGetResponse", ex2);
			}
			throw;
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, this, "EndGetResponse", "");
			}
			if (FrameworkEventSource.Log.IsEnabled())
			{
				LogEndGetResponse(success, synchronous: false, statusCode);
			}
		}
		return m_FtpWebResponse;
	}

	public override Stream GetRequestStream()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "GetRequestStream", "");
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, "GetRequestStream", SR.GetString("net_log_method_equal", m_MethodInfo.Method));
		}
		if (FrameworkEventSource.Log.IsEnabled())
		{
			LogBeginGetRequestStream(success: true, synchronous: true);
		}
		bool success = false;
		try
		{
			if (m_GetRequestStreamStarted)
			{
				throw new InvalidOperationException(SR.GetString("net_repcall"));
			}
			m_GetRequestStreamStarted = true;
			if (!m_MethodInfo.IsUpload)
			{
				throw new ProtocolViolationException(SR.GetString("net_nouploadonget"));
			}
			CheckError();
			m_StartTime = DateTime.UtcNow;
			m_RemainingTimeout = Timeout;
			ServicePoint servicePoint = ServicePoint;
			if (Timeout != -1)
			{
				m_RemainingTimeout = Timeout - (int)(DateTime.UtcNow - m_StartTime).TotalMilliseconds;
				if (m_RemainingTimeout <= 0)
				{
					throw new WebException(NetRes.GetWebStatusString(WebExceptionStatus.Timeout), WebExceptionStatus.Timeout);
				}
			}
			if (ServicePoint.InternalProxyServicePoint)
			{
				HttpWebRequest httpWebRequest = GetHttpWebRequest();
				if (Logging.On)
				{
					Logging.Associate(Logging.Web, this, httpWebRequest);
				}
				m_Stream = httpWebRequest.GetRequestStream();
			}
			else
			{
				FinishRequestStage(RequestStage.RequestStarted);
				SubmitRequest(async: false);
				FinishRequestStage(RequestStage.WriteReady);
				CheckError();
			}
			if (m_Stream.CanTimeout)
			{
				m_Stream.WriteTimeout = ReadWriteTimeout;
				m_Stream.ReadTimeout = ReadWriteTimeout;
			}
			success = true;
		}
		catch (Exception e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.Web, this, "GetRequestStream", e);
			}
			throw;
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, this, "GetRequestStream", "");
			}
			if (FrameworkEventSource.Log.IsEnabled())
			{
				LogEndGetRequestStream(success, synchronous: true);
			}
		}
		return m_Stream;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "BeginGetRequestStream", "");
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, "BeginGetRequestStream", SR.GetString("net_log_method_equal", m_MethodInfo.Method));
		}
		ContextAwareResult contextAwareResult = null;
		bool success = false;
		try
		{
			if (m_GetRequestStreamStarted)
			{
				throw new InvalidOperationException(SR.GetString("net_repcall"));
			}
			m_GetRequestStreamStarted = true;
			if (!m_MethodInfo.IsUpload)
			{
				throw new ProtocolViolationException(SR.GetString("net_nouploadonget"));
			}
			CheckError();
			if (ServicePoint.InternalProxyServicePoint)
			{
				HttpWebRequest httpWebRequest = GetHttpWebRequest();
				if (Logging.On)
				{
					Logging.Associate(Logging.Web, this, httpWebRequest);
				}
				contextAwareResult = (ContextAwareResult)httpWebRequest.BeginGetRequestStream(callback, state);
			}
			else
			{
				FinishRequestStage(RequestStage.RequestStarted);
				contextAwareResult = new ContextAwareResult(captureIdentity: true, forceCaptureContext: true, this, state, callback);
				lock (contextAwareResult.StartPostingAsyncOp())
				{
					m_WriteAsyncResult = contextAwareResult;
					SubmitRequest(async: true);
					contextAwareResult.FinishPostingAsyncOp();
					FinishRequestStage(RequestStage.CheckForError);
				}
			}
			success = true;
			return contextAwareResult;
		}
		catch (Exception e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.Web, this, "BeginGetRequestStream", e);
			}
			throw;
		}
		finally
		{
			if (FrameworkEventSource.Log.IsEnabled())
			{
				LogBeginGetRequestStream(success, synchronous: false);
			}
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, this, "BeginGetRequestStream", "");
			}
		}
	}

	public override Stream EndGetRequestStream(IAsyncResult asyncResult)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "EndGetRequestStream", "");
		}
		Stream stream = null;
		bool success = false;
		try
		{
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (!(asyncResult is LazyAsyncResult lazyAsyncResult) || (HttpProxyMode ? (lazyAsyncResult.AsyncObject != GetHttpWebRequest()) : (lazyAsyncResult.AsyncObject != this)))
			{
				throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
			}
			if (lazyAsyncResult.EndCalled)
			{
				throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndGetResponse"));
			}
			if (HttpProxyMode)
			{
				stream = GetHttpWebRequest().EndGetRequestStream(asyncResult);
			}
			else
			{
				lazyAsyncResult.InternalWaitForCompletion();
				lazyAsyncResult.EndCalled = true;
				CheckError();
				stream = m_Stream;
				lazyAsyncResult.EndCalled = true;
			}
			if (stream.CanTimeout)
			{
				stream.WriteTimeout = ReadWriteTimeout;
				stream.ReadTimeout = ReadWriteTimeout;
			}
			success = true;
		}
		catch (Exception e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.Web, this, "EndGetRequestStream", e);
			}
			throw;
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, this, "EndGetRequestStream", "");
			}
		}
		if (FrameworkEventSource.Log.IsEnabled())
		{
			LogEndGetRequestStream(success, synchronous: false);
		}
		return stream;
	}

	private void SubmitRequest(bool async)
	{
		try
		{
			m_Async = async;
			if (CheckCacheRetrieveBeforeSubmit())
			{
				RequestCallback(null);
				return;
			}
			if (m_ConnectionPool == null)
			{
				m_ConnectionPool = ConnectionPoolManager.GetConnectionPool(ServicePoint, GetConnectionGroupLine(), m_CreateConnectionCallback);
			}
			while (true)
			{
				FtpControlStream ftpControlStream = m_Connection;
				if (ftpControlStream == null)
				{
					ftpControlStream = QueueOrCreateConnection();
					if (ftpControlStream == null)
					{
						return;
					}
				}
				if (!async && Timeout != -1)
				{
					m_RemainingTimeout = Timeout - (int)(DateTime.UtcNow - m_StartTime).TotalMilliseconds;
					if (m_RemainingTimeout <= 0)
					{
						break;
					}
				}
				ftpControlStream.SetSocketTimeoutOption(SocketShutdown.Both, RemainingTimeout, silent: false);
				try
				{
					Stream stream = TimedSubmitRequestHelper(async);
					return;
				}
				catch (Exception e)
				{
					if (AttemptedRecovery(e))
					{
						if (!async && Timeout != -1)
						{
							m_RemainingTimeout = Timeout - (int)(DateTime.UtcNow - m_StartTime).TotalMilliseconds;
							if (m_RemainingTimeout <= 0)
							{
								throw;
							}
						}
						continue;
					}
					throw;
				}
			}
			throw new WebException(NetRes.GetWebStatusString(WebExceptionStatus.Timeout), WebExceptionStatus.Timeout);
		}
		catch (WebException ex)
		{
			if (ex.InnerException is IOException { InnerException: SocketException { ErrorCode: 10060 } })
			{
				SetException(new WebException(SR.GetString("net_timeout"), WebExceptionStatus.Timeout));
			}
			SetException(ex);
		}
		catch (Exception exception)
		{
			SetException(exception);
		}
	}

	private FtpControlStream QueueOrCreateConnection()
	{
		FtpControlStream ftpControlStream = (FtpControlStream)m_ConnectionPool.GetConnection(this, m_Async ? m_AsyncCallback : null, m_Async ? (-1) : RemainingTimeout);
		if (ftpControlStream == null)
		{
			return null;
		}
		lock (m_SyncObject)
		{
			if (m_Aborted)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.Web, this, "", SR.GetString("net_log_releasing_connection", ValidationHelper.HashString(ftpControlStream)));
				}
				m_ConnectionPool.PutConnection(ftpControlStream, this, RemainingTimeout);
				CheckError();
				throw new InternalException();
			}
			m_Connection = ftpControlStream;
			if (Logging.On)
			{
				Logging.Associate(Logging.Web, this, m_Connection);
			}
		}
		return ftpControlStream;
	}

	private Stream TimedSubmitRequestHelper(bool async)
	{
		if (async)
		{
			if (m_RequestCompleteAsyncResult == null)
			{
				m_RequestCompleteAsyncResult = new LazyAsyncResult(null, null, null);
			}
			return m_Connection.SubmitRequest(this, async: true, readInitalResponseOnConnect: true);
		}
		Stream stream = null;
		bool flag = false;
		TimerThread.Timer timer = TimerQueue.CreateTimer(m_TimerCallback, null);
		try
		{
			stream = m_Connection.SubmitRequest(this, async: false, readInitalResponseOnConnect: true);
		}
		catch (Exception ex)
		{
			if ((!(ex is SocketException) && !(ex is ObjectDisposedException)) || !timer.HasExpired)
			{
				timer.Cancel();
				throw;
			}
			flag = true;
		}
		if (flag || !timer.Cancel())
		{
			m_TimedOut = true;
			throw new WebException(NetRes.GetWebStatusString(WebExceptionStatus.Timeout), WebExceptionStatus.Timeout);
		}
		if (stream != null)
		{
			lock (m_SyncObject)
			{
				if (m_Aborted)
				{
					((ICloseEx)stream).CloseEx(CloseExState.Abort | CloseExState.Silent);
					CheckError();
					throw new InternalException();
				}
				m_Stream = stream;
			}
		}
		return stream;
	}

	private void TimerCallback(TimerThread.Timer timer, int timeNoticed, object context)
	{
		m_Connection?.AbortConnect();
	}

	private bool AttemptedRecovery(Exception e)
	{
		if (!(e is WebException) || ((WebException)e).InternalStatus != WebExceptionInternalStatus.Isolated)
		{
			if (e is ThreadAbortException || e is StackOverflowException || e is OutOfMemoryException || m_OnceFailed || m_Aborted || m_TimedOut || m_Connection == null || !m_Connection.RecoverableFailure)
			{
				return false;
			}
			m_OnceFailed = true;
		}
		lock (m_SyncObject)
		{
			if (m_ConnectionPool == null || m_Connection == null)
			{
				return false;
			}
			m_Connection.CloseSocket();
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.Web, this, "", SR.GetString("net_log_releasing_connection", ValidationHelper.HashString(m_Connection)));
			}
			m_ConnectionPool.PutConnection(m_Connection, this, RemainingTimeout);
			m_Connection = null;
		}
		return true;
	}

	private void SetException(Exception exception)
	{
		if (exception is ThreadAbortException || exception is StackOverflowException || exception is OutOfMemoryException)
		{
			m_Exception = exception;
			throw exception;
		}
		FtpControlStream connection = m_Connection;
		if (m_Exception == null)
		{
			if (exception is WebException)
			{
				EnsureFtpWebResponse(exception);
				m_Exception = new WebException(exception.Message, null, ((WebException)exception).Status, m_FtpWebResponse);
			}
			else if (exception is AuthenticationException || exception is SecurityException)
			{
				m_Exception = exception;
			}
			else if (connection != null && connection.StatusCode != FtpStatusCode.Undefined)
			{
				EnsureFtpWebResponse(exception);
				m_Exception = new WebException(SR.GetString("net_servererror", connection.StatusLine), exception, WebExceptionStatus.ProtocolError, m_FtpWebResponse);
			}
			else
			{
				m_Exception = new WebException(exception.Message, exception);
			}
			if (connection != null && m_FtpWebResponse != null)
			{
				m_FtpWebResponse.UpdateStatus(connection.StatusCode, connection.StatusLine, connection.ExitMessage);
			}
		}
	}

	private void CheckError()
	{
		if (m_Exception != null)
		{
			throw m_Exception;
		}
	}

	internal override ContextAwareResult GetWritingContext()
	{
		if (m_ReadAsyncResult != null && m_ReadAsyncResult is ContextAwareResult)
		{
			return (ContextAwareResult)m_ReadAsyncResult;
		}
		if (m_WriteAsyncResult != null)
		{
			return m_WriteAsyncResult;
		}
		return null;
	}

	internal override void RequestCallback(object obj)
	{
		if (m_Async)
		{
			AsyncRequestCallback(obj);
		}
		else
		{
			SyncRequestCallback(obj);
		}
	}

	private void SyncRequestCallback(object obj)
	{
		RequestStage stage = RequestStage.CheckForError;
		try
		{
			bool flag = obj == null;
			if (obj is Exception exception)
			{
				SetException(exception);
				return;
			}
			if (!flag)
			{
				throw new InternalException();
			}
			FtpControlStream connection = m_Connection;
			bool flag2 = false;
			if (connection != null)
			{
				EnsureFtpWebResponse(null);
				m_FtpWebResponse.UpdateStatus(connection.StatusCode, connection.StatusLine, connection.ExitMessage);
				flag2 = !m_CacheDone && (base.CacheProtocol.ProtocolStatus == CacheValidationStatus.Continue || base.CacheProtocol.ProtocolStatus == CacheValidationStatus.RetryResponseFromServer);
				if (m_MethodInfo.IsUpload)
				{
					CheckCacheRetrieveOnResponse();
					CheckCacheUpdateOnResponse();
				}
			}
			if (!flag2)
			{
				stage = RequestStage.ReleaseConnection;
			}
		}
		catch (Exception exception2)
		{
			SetException(exception2);
		}
		finally
		{
			FinishRequestStage(stage);
			CheckError();
		}
	}

	private void AsyncRequestCallback(object obj)
	{
		RequestStage stage = RequestStage.CheckForError;
		try
		{
			FtpControlStream ftpControlStream = obj as FtpControlStream;
			FtpDataStream ftpDataStream = obj as FtpDataStream;
			Exception ex = obj as Exception;
			bool flag = obj == null;
			while (true)
			{
				if (ex != null)
				{
					if (AttemptedRecovery(ex))
					{
						ftpControlStream = QueueOrCreateConnection();
						if (ftpControlStream == null)
						{
							break;
						}
						ex = null;
					}
					if (ex != null)
					{
						SetException(ex);
						break;
					}
				}
				if (ftpControlStream != null)
				{
					lock (m_SyncObject)
					{
						if (m_Aborted)
						{
							if (Logging.On)
							{
								Logging.PrintInfo(Logging.Web, this, "", SR.GetString("net_log_releasing_connection", ValidationHelper.HashString(ftpControlStream)));
							}
							m_ConnectionPool.PutConnection(ftpControlStream, this, Timeout);
							break;
						}
						m_Connection = ftpControlStream;
						if (Logging.On)
						{
							Logging.Associate(Logging.Web, this, m_Connection);
						}
					}
					try
					{
						ftpDataStream = (FtpDataStream)TimedSubmitRequestHelper(async: true);
						break;
					}
					catch (Exception ex2)
					{
						ex = ex2;
					}
					continue;
				}
				if (ftpDataStream != null)
				{
					lock (m_SyncObject)
					{
						if (m_Aborted)
						{
							((ICloseEx)ftpDataStream).CloseEx(CloseExState.Abort | CloseExState.Silent);
							break;
						}
						m_Stream = ftpDataStream;
					}
					ftpDataStream.SetSocketTimeoutOption(SocketShutdown.Both, Timeout, silent: true);
					EnsureFtpWebResponse(null);
					CheckCacheRetrieveOnResponse();
					CheckCacheUpdateOnResponse();
					stage = (ftpDataStream.CanRead ? RequestStage.ReadReady : RequestStage.WriteReady);
					break;
				}
				bool flag2;
				if (flag)
				{
					ftpControlStream = m_Connection;
					flag2 = false;
					if (ftpControlStream != null)
					{
						EnsureFtpWebResponse(null);
						m_FtpWebResponse.UpdateStatus(ftpControlStream.StatusCode, ftpControlStream.StatusLine, ftpControlStream.ExitMessage);
						flag2 = !m_CacheDone && (base.CacheProtocol.ProtocolStatus == CacheValidationStatus.Continue || base.CacheProtocol.ProtocolStatus == CacheValidationStatus.RetryResponseFromServer);
						lock (m_SyncObject)
						{
							if (!CheckCacheRetrieveOnResponse())
							{
								continue;
							}
							if (m_FtpWebResponse.IsFromCache)
							{
								flag2 = false;
							}
							CheckCacheUpdateOnResponse();
							goto IL_0220;
						}
					}
					goto IL_0220;
				}
				throw new InternalException();
				IL_0220:
				if (!flag2)
				{
					stage = RequestStage.ReleaseConnection;
				}
				break;
			}
		}
		catch (Exception exception)
		{
			SetException(exception);
		}
		finally
		{
			FinishRequestStage(stage);
		}
	}

	private RequestStage FinishRequestStage(RequestStage stage)
	{
		if (m_Exception != null)
		{
			stage = RequestStage.ReleaseConnection;
		}
		RequestStage requestStage;
		LazyAsyncResult writeAsyncResult;
		LazyAsyncResult readAsyncResult;
		FtpControlStream connection;
		lock (m_SyncObject)
		{
			requestStage = m_RequestStage;
			if (stage == RequestStage.CheckForError)
			{
				return requestStage;
			}
			if (requestStage == RequestStage.ReleaseConnection && stage == RequestStage.ReleaseConnection)
			{
				return RequestStage.ReleaseConnection;
			}
			if (stage > requestStage)
			{
				m_RequestStage = stage;
			}
			if (stage <= RequestStage.RequestStarted)
			{
				return requestStage;
			}
			writeAsyncResult = m_WriteAsyncResult;
			readAsyncResult = m_ReadAsyncResult;
			connection = m_Connection;
			if (stage == RequestStage.ReleaseConnection)
			{
				if (m_Exception == null && !m_Aborted && requestStage != RequestStage.ReadReady && m_MethodInfo.IsDownload && !m_FtpWebResponse.IsFromCache)
				{
					return requestStage;
				}
				if (m_Exception != null || !m_FtpWebResponse.IsFromCache || KeepAlive)
				{
					m_Connection = null;
				}
			}
		}
		try
		{
			if ((stage == RequestStage.ReleaseConnection || requestStage == RequestStage.ReleaseConnection) && connection != null)
			{
				try
				{
					if (m_Exception != null)
					{
						connection.Abort(m_Exception);
					}
					else if (m_FtpWebResponse.IsFromCache && !KeepAlive)
					{
						connection.Quit();
					}
				}
				finally
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.Web, this, "", SR.GetString("net_log_releasing_connection", ValidationHelper.HashString(connection)));
					}
					m_ConnectionPool.PutConnection(connection, this, RemainingTimeout);
					if (m_Async && m_RequestCompleteAsyncResult != null)
					{
						m_RequestCompleteAsyncResult.InvokeCallback();
					}
				}
			}
			return requestStage;
		}
		finally
		{
			try
			{
				if (stage >= RequestStage.WriteReady)
				{
					if (m_MethodInfo.IsUpload && !m_GetRequestStreamStarted)
					{
						if (m_Stream != null)
						{
							m_Stream.Close();
						}
					}
					else if (writeAsyncResult != null && !writeAsyncResult.InternalPeekCompleted)
					{
						writeAsyncResult.InvokeCallback();
					}
				}
			}
			finally
			{
				if (stage >= RequestStage.ReadReady && readAsyncResult != null && !readAsyncResult.InternalPeekCompleted)
				{
					readAsyncResult.InvokeCallback();
				}
			}
		}
	}

	private static void AsyncCallbackWrapper(object request, object state)
	{
		FtpWebRequest ftpWebRequest = (FtpWebRequest)request;
		ftpWebRequest.RequestCallback(state);
	}

	private static PooledStream CreateFtpConnection(ConnectionPool pool)
	{
		return new FtpControlStream(pool, TimeSpan.MaxValue, checkLifetime: false);
	}

	public override void Abort()
	{
		if (m_Aborted)
		{
			return;
		}
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "Abort", "");
		}
		try
		{
			if (HttpProxyMode)
			{
				GetHttpWebRequest().Abort();
				return;
			}
			if (base.CacheProtocol != null)
			{
				base.CacheProtocol.Abort();
			}
			Stream stream;
			FtpControlStream connection;
			lock (m_SyncObject)
			{
				if (m_RequestStage >= RequestStage.ReleaseConnection)
				{
					return;
				}
				m_Aborted = true;
				stream = m_Stream;
				connection = m_Connection;
				m_Exception = new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
			}
			if (stream != null)
			{
				((ICloseEx)stream).CloseEx(CloseExState.Abort | CloseExState.Silent);
			}
			connection?.Abort(ExceptionHelper.RequestAbortedException);
		}
		catch (Exception e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.Web, this, "Abort", e);
			}
			throw;
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, this, "Abort", "");
			}
		}
	}

	private void EnsureFtpWebResponse(Exception exception)
	{
		if (m_FtpWebResponse != null && (!(m_FtpWebResponse.GetResponseStream() is FtpWebResponse.EmptyStream) || m_Stream == null))
		{
			return;
		}
		lock (m_SyncObject)
		{
			if (m_FtpWebResponse == null || (m_FtpWebResponse.GetResponseStream() is FtpWebResponse.EmptyStream && m_Stream != null))
			{
				Stream stream = m_Stream;
				if (m_MethodInfo.IsUpload)
				{
					stream = null;
				}
				if (m_Stream != null && m_Stream.CanRead && m_Stream.CanTimeout)
				{
					m_Stream.ReadTimeout = ReadWriteTimeout;
					m_Stream.WriteTimeout = ReadWriteTimeout;
				}
				FtpControlStream connection = m_Connection;
				long num = connection?.ContentLength ?? (-1);
				if (stream == null && num < 0)
				{
					num = 0L;
				}
				if (m_FtpWebResponse != null)
				{
					m_FtpWebResponse.SetResponseStream(stream);
				}
				else if (connection != null)
				{
					m_FtpWebResponse = new FtpWebResponse(stream, num, connection.ResponseUri, connection.StatusCode, connection.StatusLine, connection.LastModified, connection.BannerMessage, connection.WelcomeMessage, connection.ExitMessage);
				}
				else
				{
					m_FtpWebResponse = new FtpWebResponse(stream, -1L, m_Uri, FtpStatusCode.Undefined, null, DateTime.Now, null, null, null);
				}
			}
		}
	}

	private HttpWebRequest GetHttpWebRequest()
	{
		lock (m_SyncObject)
		{
			if (m_HttpWebRequest == null)
			{
				if (m_ContentOffset > 0)
				{
					throw new InvalidOperationException(SR.GetString("net_ftp_no_offsetforhttp"));
				}
				if (!m_MethodInfo.HasHttpCommand)
				{
					throw new InvalidOperationException(SR.GetString("net_ftp_no_http_cmd"));
				}
				m_HttpWebRequest = new HttpWebRequest(m_Uri, ServicePoint);
				m_HttpWebRequest.Credentials = Credentials;
				m_HttpWebRequest.InternalProxy = m_Proxy;
				m_HttpWebRequest.KeepAlive = KeepAlive;
				m_HttpWebRequest.Timeout = Timeout;
				m_HttpWebRequest.Method = m_MethodInfo.HttpCommand;
				m_HttpWebRequest.CacheProtocol = base.CacheProtocol;
				RequestCacheLevel requestCacheLevel = ((CachePolicy == null) ? RequestCacheLevel.BypassCache : CachePolicy.Level);
				if (requestCacheLevel == RequestCacheLevel.Revalidate)
				{
					requestCacheLevel = RequestCacheLevel.Reload;
				}
				m_HttpWebRequest.CachePolicy = new HttpRequestCachePolicy((HttpRequestCacheLevel)requestCacheLevel);
				base.CacheProtocol = null;
			}
		}
		return m_HttpWebRequest;
	}

	private string GetConnectionGroupLine()
	{
		return ConnectionGroupName + "_" + GetUserString();
	}

	internal string GetUserString()
	{
		string text = null;
		if (Credentials != null)
		{
			NetworkCredential credential = Credentials.GetCredential(m_Uri, "basic");
			if (credential != null)
			{
				text = credential.InternalGetUserName();
				string text2 = credential.InternalGetDomain();
				if (!ValidationHelper.IsBlankString(text2))
				{
					text = text2 + "\\" + text;
				}
			}
		}
		if (text != null)
		{
			if (string.Compare(text, "anonymous", StringComparison.InvariantCultureIgnoreCase) != 0)
			{
				return text;
			}
			return null;
		}
		return null;
	}

	private bool CheckCacheRetrieveBeforeSubmit()
	{
		if (base.CacheProtocol == null || m_CacheDone)
		{
			m_CacheDone = true;
			return false;
		}
		if (base.CacheProtocol.ProtocolStatus == CacheValidationStatus.CombineCachedAndServerResponse || base.CacheProtocol.ProtocolStatus == CacheValidationStatus.DoNotTakeFromCache)
		{
			return false;
		}
		Uri uri = RequestUri;
		string text = GetUserString();
		if (text != null)
		{
			text = Uri.EscapeDataString(text);
		}
		if (uri.Fragment.Length != 0 || text != null)
		{
			if (text == null)
			{
				uri = new Uri(uri.GetParts(UriComponents.HttpRequestUrl, UriFormat.SafeUnescaped));
			}
			else
			{
				text = uri.GetParts(UriComponents.Scheme | UriComponents.KeepDelimiter, UriFormat.SafeUnescaped) + text + "@";
				text += uri.GetParts(UriComponents.PathAndQuery | UriComponents.Host | UriComponents.Port, UriFormat.SafeUnescaped);
				uri = new Uri(text);
			}
		}
		base.CacheProtocol.GetRetrieveStatus(uri, this);
		if (base.CacheProtocol.ProtocolStatus == CacheValidationStatus.Fail)
		{
			throw base.CacheProtocol.ProtocolException;
		}
		if (base.CacheProtocol.ProtocolStatus != CacheValidationStatus.ReturnCachedResponse)
		{
			return false;
		}
		if (m_MethodInfo.Operation != FtpOperation.DownloadFile)
		{
			throw new NotSupportedException(SR.GetString("net_cache_not_supported_command"));
		}
		if (base.CacheProtocol.ProtocolStatus == CacheValidationStatus.ReturnCachedResponse)
		{
			FtpRequestCacheValidator ftpRequestCacheValidator = (FtpRequestCacheValidator)base.CacheProtocol.Validator;
			m_FtpWebResponse = new FtpWebResponse(base.CacheProtocol.ResponseStream, base.CacheProtocol.ResponseStreamLength, RequestUri, UsePassive ? FtpStatusCode.DataAlreadyOpen : FtpStatusCode.OpeningData, (UsePassive ? FtpStatusCode.DataAlreadyOpen : FtpStatusCode.OpeningData).ToString(), (ftpRequestCacheValidator.CacheEntry.LastModifiedUtc == DateTime.MinValue) ? DateTime.Now : ftpRequestCacheValidator.CacheEntry.LastModifiedUtc.ToLocalTime(), string.Empty, string.Empty, string.Empty);
			m_FtpWebResponse.InternalSetFromCache = true;
			m_FtpWebResponse.InternalSetIsCacheFresh = ftpRequestCacheValidator.CacheFreshnessStatus != CacheFreshnessStatus.Stale;
		}
		return true;
	}

	private bool CheckCacheRetrieveOnResponse()
	{
		if (base.CacheProtocol == null || m_CacheDone)
		{
			return true;
		}
		if (base.CacheProtocol.ProtocolStatus != CacheValidationStatus.Continue)
		{
			return true;
		}
		if (base.CacheProtocol.ProtocolStatus == CacheValidationStatus.Fail)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.Web, this, "CheckCacheRetrieveOnResponse", base.CacheProtocol.ProtocolException);
			}
			throw base.CacheProtocol.ProtocolException;
		}
		base.CacheProtocol.GetRevalidateStatus(m_FtpWebResponse, null);
		if (base.CacheProtocol.ProtocolStatus == CacheValidationStatus.RetryResponseFromServer)
		{
			if (m_FtpWebResponse != null)
			{
				m_FtpWebResponse.SetResponseStream(null);
			}
			return false;
		}
		if (base.CacheProtocol.ProtocolStatus != CacheValidationStatus.ReturnCachedResponse)
		{
			return false;
		}
		if (m_MethodInfo.Operation != FtpOperation.DownloadFile)
		{
			throw new NotSupportedException(SR.GetString("net_cache_not_supported_command"));
		}
		FtpRequestCacheValidator ftpRequestCacheValidator = (FtpRequestCacheValidator)base.CacheProtocol.Validator;
		FtpWebResponse ftpWebResponse = m_FtpWebResponse;
		m_Stream = base.CacheProtocol.ResponseStream;
		m_FtpWebResponse = new FtpWebResponse(base.CacheProtocol.ResponseStream, base.CacheProtocol.ResponseStreamLength, RequestUri, UsePassive ? FtpStatusCode.DataAlreadyOpen : FtpStatusCode.OpeningData, (UsePassive ? FtpStatusCode.DataAlreadyOpen : FtpStatusCode.OpeningData).ToString(), (ftpRequestCacheValidator.CacheEntry.LastModifiedUtc == DateTime.MinValue) ? DateTime.Now : ftpRequestCacheValidator.CacheEntry.LastModifiedUtc.ToLocalTime(), string.Empty, string.Empty, string.Empty);
		m_FtpWebResponse.InternalSetFromCache = true;
		m_FtpWebResponse.InternalSetIsCacheFresh = base.CacheProtocol.IsCacheFresh;
		ftpWebResponse.Close();
		return true;
	}

	private void CheckCacheUpdateOnResponse()
	{
		if (base.CacheProtocol == null || m_CacheDone)
		{
			return;
		}
		m_CacheDone = true;
		if (m_Connection != null)
		{
			m_FtpWebResponse.UpdateStatus(m_Connection.StatusCode, m_Connection.StatusLine, m_Connection.ExitMessage);
			if (m_Connection.StatusCode == FtpStatusCode.OpeningData && m_FtpWebResponse.ContentLength == 0L)
			{
				m_FtpWebResponse.SetContentLength(m_Connection.ContentLength);
			}
		}
		if (base.CacheProtocol.ProtocolStatus == CacheValidationStatus.CombineCachedAndServerResponse)
		{
			m_Stream = new CombinedReadStream(base.CacheProtocol.Validator.CacheStream, m_FtpWebResponse.GetResponseStream());
			FtpStatusCode statusCode = (UsePassive ? FtpStatusCode.DataAlreadyOpen : FtpStatusCode.OpeningData);
			m_FtpWebResponse.UpdateStatus(statusCode, statusCode.ToString(), string.Empty);
			m_FtpWebResponse.SetResponseStream(m_Stream);
		}
		if (base.CacheProtocol.GetUpdateStatus(m_FtpWebResponse, m_FtpWebResponse.GetResponseStream()) == CacheValidationStatus.UpdateResponseInformation)
		{
			m_Stream = base.CacheProtocol.ResponseStream;
			m_FtpWebResponse.SetResponseStream(m_Stream);
		}
		else if (base.CacheProtocol.ProtocolStatus == CacheValidationStatus.Fail)
		{
			throw base.CacheProtocol.ProtocolException;
		}
	}

	internal void DataStreamClosed(CloseExState closeState)
	{
		if ((closeState & CloseExState.Abort) == 0)
		{
			if (!m_Async)
			{
				if (m_Connection != null)
				{
					m_Connection.CheckContinuePipeline();
				}
			}
			else
			{
				m_RequestCompleteAsyncResult.InternalWaitForCompletion();
				CheckError();
			}
		}
		else
		{
			m_Connection?.Abort(ExceptionHelper.RequestAbortedException);
		}
	}

	private static int GetStatusCode(WebException webException)
	{
		int result = -1;
		if (FrameworkEventSource.Log.IsEnabled() && webException != null && webException.Response != null)
		{
			if (webException.Response is HttpWebResponse httpWebResponse)
			{
				try
				{
					result = (int)httpWebResponse.StatusCode;
				}
				catch (ObjectDisposedException)
				{
				}
			}
			else
			{
				FtpWebResponse ftpWebResponse = webException.Response as FtpWebResponse;
				result = GetStatusCode(ftpWebResponse);
			}
		}
		return result;
	}

	private static int GetStatusCode(FtpWebResponse ftpWebResponse)
	{
		int result = -1;
		if (FrameworkEventSource.Log.IsEnabled() && ftpWebResponse != null)
		{
			try
			{
				result = (int)ftpWebResponse.StatusCode;
			}
			catch (ObjectDisposedException)
			{
			}
		}
		return result;
	}
}
