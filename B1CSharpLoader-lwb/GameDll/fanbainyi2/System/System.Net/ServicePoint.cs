using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;

namespace System.Net;

[FriendAccessAllowed]
public class ServicePoint
{
	private class HandshakeDoneProcedure
	{
		private TlsStream m_SecureStream;

		private object m_Request;

		private ServicePoint m_ServicePoint;

		internal static RemoteCertValidationCallback CreateAdapter(ServicePoint serviePoint, TlsStream secureStream, object request)
		{
			HandshakeDoneProcedure handshakeDoneProcedure = new HandshakeDoneProcedure(serviePoint, secureStream, request);
			return handshakeDoneProcedure.CertValidationCallback;
		}

		private HandshakeDoneProcedure(ServicePoint serviePoint, TlsStream secureStream, object request)
		{
			m_ServicePoint = serviePoint;
			m_SecureStream = secureStream;
			m_Request = request;
		}

		private bool CertValidationCallback(string hostName, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			m_ServicePoint.UpdateServerCertificate(certificate);
			m_ServicePoint.UpdateClientCertificate(m_SecureStream.ClientCertificate);
			bool flag = true;
			if (m_Request is HttpWebRequest { ServerCertValidationCallback: not null } httpWebRequest)
			{
				return httpWebRequest.ServerCertValidationCallback.Invoke(m_Request, certificate, chain, sslPolicyErrors);
			}
			if (ServicePointManager.GetLegacyCertificatePolicy() != null && m_Request is WebRequest)
			{
				flag = false;
				bool flag2 = ServicePointManager.CertPolicyValidationCallback.Invoke(hostName, m_ServicePoint, certificate, (WebRequest)m_Request, chain, sslPolicyErrors);
				if (!flag2 && (!ServicePointManager.CertPolicyValidationCallback.UsesDefault || ServicePointManager.ServerCertificateValidationCallback == null))
				{
					return flag2;
				}
			}
			if (ServicePointManager.ServerCertificateValidationCallback != null)
			{
				flag = false;
				return ServicePointManager.ServerCertValidationCallback.Invoke(m_Request, certificate, chain, sslPolicyErrors);
			}
			if (flag)
			{
				return sslPolicyErrors == SslPolicyErrors.None;
			}
			return true;
		}
	}

	private class ConnectSocketState
	{
		internal ServicePoint servicePoint;

		internal Socket s4;

		internal Socket s6;

		internal object owner;

		internal IPAddress[] addresses;

		internal int currentIndex;

		internal int i;

		internal int unsuccessfulAttempts;

		internal bool connectFailure;

		internal PooledStream pooledStream;

		internal ConnectSocketState(ServicePoint servicePoint, PooledStream pooledStream, object owner, Socket s4, Socket s6)
		{
			this.servicePoint = servicePoint;
			this.pooledStream = pooledStream;
			this.owner = owner;
			this.s4 = s4;
			this.s6 = s6;
		}
	}

	internal const int LoopbackConnectionLimit = int.MaxValue;

	private int m_ConnectionLeaseTimeout;

	private TimerThread.Queue m_ConnectionLeaseTimerQueue;

	private bool m_ProxyServicePoint;

	private bool m_UserChangedLimit;

	private bool m_UseNagleAlgorithm;

	private TriState m_HostLoopbackGuess;

	private int m_ReceiveBufferSize;

	private bool m_Expect100Continue;

	private bool m_Understands100Continue;

	private HttpBehaviour m_HttpBehaviour;

	private string m_LookupString;

	private int m_ConnectionLimit;

	private Hashtable m_ConnectionGroupList;

	private Uri m_Address;

	private string m_Host;

	private int m_Port;

	private TimerThread.Queue m_IdlingQueue;

	private TimerThread.Timer m_ExpiringTimer;

	private DateTime m_IdleSince;

	private string m_ConnectionName;

	private int m_CurrentConnections;

	private bool m_HostMode;

	private BindIPEndPoint m_BindIPEndPointDelegate;

	private object m_CachedChannelBinding;

	private static readonly AsyncCallback m_ConnectCallbackDelegate = ConnectSocketCallback;

	private readonly TimerThread.Callback m_IdleConnectionGroupTimeoutDelegate;

	private readonly object m_ExpiringTimerLock = new object();

	private object m_ServerCertificateOrBytes;

	private object m_ClientCertificateOrBytes;

	private bool m_UseTcpKeepAlive;

	private int m_TcpKeepAliveTime;

	private int m_TcpKeepAliveInterval;

	private string m_HostName = string.Empty;

	private bool m_IsTrustedHost = true;

	private IPAddress[] m_IPAddressInfoList;

	private int m_CurrentAddressInfoIndex;

	private bool m_ConnectedSinceDns;

	private bool m_AddressListFailed;

	private DateTime m_LastDnsResolve;

	private bool m_IPAddressesAreLoopback;

	internal string LookupString => m_LookupString;

	internal string Hostname => m_HostName;

	internal bool IsTrustedHost => m_IsTrustedHost;

	public BindIPEndPoint BindIPEndPointDelegate
	{
		get
		{
			return m_BindIPEndPointDelegate;
		}
		set
		{
			ExceptionHelper.InfrastructurePermission.Demand();
			m_BindIPEndPointDelegate = value;
		}
	}

	internal object CachedChannelBinding => m_CachedChannelBinding;

	public int ConnectionLeaseTimeout
	{
		get
		{
			return m_ConnectionLeaseTimeout;
		}
		set
		{
			if (!ValidationHelper.ValidateRange(value, -1, int.MaxValue))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (value != m_ConnectionLeaseTimeout)
			{
				m_ConnectionLeaseTimeout = value;
				m_ConnectionLeaseTimerQueue = null;
			}
		}
	}

	internal TimerThread.Queue ConnectionLeaseTimerQueue
	{
		get
		{
			TimerThread.Queue connectionLeaseTimerQueue = m_ConnectionLeaseTimerQueue;
			if (connectionLeaseTimerQueue == null)
			{
				connectionLeaseTimerQueue = TimerThread.GetOrCreateQueue(ConnectionLeaseTimeout);
				m_ConnectionLeaseTimerQueue = connectionLeaseTimerQueue;
			}
			return m_ConnectionLeaseTimerQueue;
		}
	}

	public Uri Address
	{
		get
		{
			if (m_HostMode)
			{
				throw new NotSupportedException(SR.GetString("net_servicePointAddressNotSupportedInHostMode"));
			}
			if (m_ProxyServicePoint)
			{
				ExceptionHelper.WebPermissionUnrestricted.Demand();
			}
			return m_Address;
		}
	}

	internal Uri InternalAddress => m_Address;

	internal string Host
	{
		get
		{
			if (m_HostMode)
			{
				return m_Host;
			}
			return m_Address.Host;
		}
	}

	internal int Port => m_Port;

	public int MaxIdleTime
	{
		get
		{
			return m_IdlingQueue.Duration;
		}
		set
		{
			if (!ValidationHelper.ValidateRange(value, -1, int.MaxValue))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (value == m_IdlingQueue.Duration)
			{
				return;
			}
			lock (m_ExpiringTimerLock)
			{
				if (m_ExpiringTimer == null || m_ExpiringTimer.Cancel())
				{
					m_IdlingQueue = TimerThread.GetOrCreateQueue(value);
					if (m_ExpiringTimer != null)
					{
						double totalMilliseconds = (DateTime.Now - m_IdleSince).TotalMilliseconds;
						int num = ((totalMilliseconds >= 2147483647.0) ? int.MaxValue : ((int)totalMilliseconds));
						int durationMilliseconds = ((value == -1) ? (-1) : ((num < value) ? (value - num) : 0));
						m_ExpiringTimer = TimerThread.CreateQueue(durationMilliseconds).CreateTimer(ServicePointManager.IdleServicePointTimeoutDelegate, this);
					}
				}
			}
		}
	}

	public bool UseNagleAlgorithm
	{
		get
		{
			return m_UseNagleAlgorithm;
		}
		set
		{
			m_UseNagleAlgorithm = value;
		}
	}

	public int ReceiveBufferSize
	{
		get
		{
			return m_ReceiveBufferSize;
		}
		set
		{
			if (!ValidationHelper.ValidateRange(value, -1, int.MaxValue))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			m_ReceiveBufferSize = value;
		}
	}

	public bool Expect100Continue
	{
		get
		{
			return m_Expect100Continue;
		}
		set
		{
			m_Expect100Continue = value;
		}
	}

	public DateTime IdleSince => m_IdleSince;

	public virtual Version ProtocolVersion
	{
		get
		{
			if ((int)m_HttpBehaviour <= 1 && m_HttpBehaviour != HttpBehaviour.Unknown)
			{
				return HttpVersion.Version10;
			}
			return HttpVersion.Version11;
		}
	}

	internal HttpBehaviour HttpBehaviour
	{
		get
		{
			return m_HttpBehaviour;
		}
		set
		{
			m_HttpBehaviour = value;
			m_Understands100Continue = m_Understands100Continue && ((int)m_HttpBehaviour > 1 || m_HttpBehaviour == HttpBehaviour.Unknown);
		}
	}

	public string ConnectionName => m_ConnectionName;

	public int ConnectionLimit
	{
		get
		{
			if (!m_UserChangedLimit && m_IPAddressInfoList == null && m_HostLoopbackGuess == TriState.Unspecified)
			{
				lock (this)
				{
					if (!m_UserChangedLimit && m_IPAddressInfoList == null && m_HostLoopbackGuess == TriState.Unspecified)
					{
						IPAddress address = null;
						if (IPAddress.TryParse(m_Host, out address))
						{
							m_HostLoopbackGuess = (IsAddressListLoopback(new IPAddress[1] { address }) ? TriState.True : TriState.False);
						}
						else
						{
							m_HostLoopbackGuess = (NclUtilities.GuessWhetherHostIsLoopback(m_Host) ? TriState.True : TriState.False);
						}
					}
				}
			}
			if (!m_UserChangedLimit && !((m_IPAddressInfoList == null) ? (m_HostLoopbackGuess != TriState.True) : (!m_IPAddressesAreLoopback)))
			{
				return int.MaxValue;
			}
			return m_ConnectionLimit;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (m_UserChangedLimit && m_ConnectionLimit == value)
			{
				return;
			}
			lock (this)
			{
				if (!m_UserChangedLimit || m_ConnectionLimit != value)
				{
					m_ConnectionLimit = value;
					m_UserChangedLimit = true;
					ResolveConnectionLimit();
				}
			}
		}
	}

	public int CurrentConnections
	{
		get
		{
			int num = 0;
			lock (this)
			{
				foreach (ConnectionGroup value in m_ConnectionGroupList.Values)
				{
					num += value.CurrentConnections;
				}
				return num;
			}
		}
	}

	public X509Certificate Certificate
	{
		get
		{
			object serverCertificateOrBytes = m_ServerCertificateOrBytes;
			if (serverCertificateOrBytes != null && serverCertificateOrBytes.GetType() == typeof(byte[]))
			{
				return (X509Certificate)(m_ServerCertificateOrBytes = new X509Certificate((byte[])serverCertificateOrBytes));
			}
			return serverCertificateOrBytes as X509Certificate;
		}
	}

	public X509Certificate ClientCertificate
	{
		get
		{
			object clientCertificateOrBytes = m_ClientCertificateOrBytes;
			if (clientCertificateOrBytes != null && clientCertificateOrBytes.GetType() == typeof(byte[]))
			{
				return (X509Certificate)(m_ClientCertificateOrBytes = new X509Certificate((byte[])clientCertificateOrBytes));
			}
			return clientCertificateOrBytes as X509Certificate;
		}
	}

	public bool SupportsPipelining
	{
		get
		{
			if ((int)m_HttpBehaviour <= 1)
			{
				return m_HttpBehaviour == HttpBehaviour.Unknown;
			}
			return true;
		}
	}

	internal bool Understands100Continue
	{
		get
		{
			return m_Understands100Continue;
		}
		set
		{
			m_Understands100Continue = value;
		}
	}

	internal bool InternalProxyServicePoint => m_ProxyServicePoint;

	private bool HasTimedOut
	{
		get
		{
			int dnsRefreshTimeout = ServicePointManager.DnsRefreshTimeout;
			if (dnsRefreshTimeout != -1)
			{
				return m_LastDnsResolve + new TimeSpan(0, 0, 0, 0, dnsRefreshTimeout) < DateTime.UtcNow;
			}
			return false;
		}
	}

	internal ServicePoint(Uri address, TimerThread.Queue defaultIdlingQueue, int defaultConnectionLimit, string lookupString, bool userChangedLimit, bool proxyServicePoint)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "ServicePoint", address.DnsSafeHost + ":" + address.Port);
		}
		m_ProxyServicePoint = proxyServicePoint;
		m_Address = address;
		m_ConnectionName = address.Scheme;
		m_Host = address.DnsSafeHost;
		m_Port = address.Port;
		m_IdlingQueue = defaultIdlingQueue;
		m_ConnectionLimit = defaultConnectionLimit;
		m_HostLoopbackGuess = TriState.Unspecified;
		m_LookupString = lookupString;
		m_UserChangedLimit = userChangedLimit;
		m_UseNagleAlgorithm = ServicePointManager.UseNagleAlgorithm;
		m_Expect100Continue = ServicePointManager.Expect100Continue;
		m_ConnectionGroupList = new Hashtable(10);
		m_ConnectionLeaseTimeout = -1;
		m_ReceiveBufferSize = -1;
		m_UseTcpKeepAlive = ServicePointManager.s_UseTcpKeepAlive;
		m_TcpKeepAliveTime = ServicePointManager.s_TcpKeepAliveTime;
		m_TcpKeepAliveInterval = ServicePointManager.s_TcpKeepAliveInterval;
		m_Understands100Continue = true;
		m_HttpBehaviour = HttpBehaviour.Unknown;
		m_IdleSince = DateTime.Now;
		m_ExpiringTimer = m_IdlingQueue.CreateTimer(ServicePointManager.IdleServicePointTimeoutDelegate, this);
		m_IdleConnectionGroupTimeoutDelegate = IdleConnectionGroupTimeoutCallback;
	}

	internal ServicePoint(string host, int port, TimerThread.Queue defaultIdlingQueue, int defaultConnectionLimit, string lookupString, bool userChangedLimit, bool proxyServicePoint)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, this, "ServicePoint", host + ":" + port);
		}
		m_ProxyServicePoint = proxyServicePoint;
		m_ConnectionName = "ByHost:" + host + ":" + port.ToString(CultureInfo.InvariantCulture);
		m_IdlingQueue = defaultIdlingQueue;
		m_ConnectionLimit = defaultConnectionLimit;
		m_HostLoopbackGuess = TriState.Unspecified;
		m_LookupString = lookupString;
		m_UserChangedLimit = userChangedLimit;
		m_ConnectionGroupList = new Hashtable(10);
		m_ConnectionLeaseTimeout = -1;
		m_ReceiveBufferSize = -1;
		m_Host = host;
		m_Port = port;
		m_HostMode = true;
		m_IdleSince = DateTime.Now;
		m_ExpiringTimer = m_IdlingQueue.CreateTimer(ServicePointManager.IdleServicePointTimeoutDelegate, this);
		m_IdleConnectionGroupTimeoutDelegate = IdleConnectionGroupTimeoutCallback;
	}

	internal void SetCachedChannelBinding(Uri uri, ChannelBinding binding)
	{
		if (uri.Scheme == Uri.UriSchemeHttps)
		{
			m_CachedChannelBinding = ((binding != null) ? ((object)binding) : ((object)DBNull.Value));
		}
	}

	private ConnectionGroup FindConnectionGroup(string connName, bool dontCreate)
	{
		string key = ConnectionGroup.MakeQueryStr(connName);
		ConnectionGroup connectionGroup = m_ConnectionGroupList[key] as ConnectionGroup;
		if (connectionGroup == null && !dontCreate)
		{
			connectionGroup = new ConnectionGroup(this, connName);
			m_ConnectionGroupList[key] = connectionGroup;
		}
		return connectionGroup;
	}

	internal Socket GetConnection(PooledStream PooledStream, object owner, bool async, out IPAddress address, ref Socket abortSocket, ref Socket abortSocket6)
	{
		Socket socket = null;
		Socket socket2 = null;
		Socket socket3 = null;
		Exception exception = null;
		WebExceptionStatus webExceptionStatus = WebExceptionStatus.ConnectFailure;
		address = null;
		if (Socket.OSSupportsIPv4)
		{
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		}
		if (Socket.OSSupportsIPv6)
		{
			socket2 = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);
		}
		abortSocket = socket;
		abortSocket6 = socket2;
		ConnectSocketState state = null;
		if (async)
		{
			state = new ConnectSocketState(this, PooledStream, owner, socket, socket2);
		}
		webExceptionStatus = ConnectSocket(socket, socket2, ref socket3, ref address, state, out exception);
		switch (webExceptionStatus)
		{
		case WebExceptionStatus.Pending:
			return null;
		default:
			throw new WebException(NetRes.GetWebStatusString(webExceptionStatus), (webExceptionStatus == WebExceptionStatus.ProxyNameResolutionFailure || webExceptionStatus == WebExceptionStatus.NameResolutionFailure) ? Host : null, exception, webExceptionStatus, null, WebExceptionInternalStatus.ServicePointFatal);
		case WebExceptionStatus.Success:
			if (socket3 == null)
			{
				throw new IOException(SR.GetString("net_io_transportfailure"));
			}
			CompleteGetConnection(socket, socket2, socket3, address);
			return socket3;
		}
	}

	private void CompleteGetConnection(Socket socket, Socket socket6, Socket finalSocket, IPAddress address)
	{
		if (finalSocket.AddressFamily == AddressFamily.InterNetwork)
		{
			if (socket6 != null)
			{
				socket6.Close();
				socket6 = null;
			}
		}
		else if (socket != null)
		{
			socket.Close();
			socket = null;
		}
		if (!UseNagleAlgorithm)
		{
			finalSocket.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug, 1);
		}
		if (ReceiveBufferSize != -1)
		{
			finalSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveBuffer, ReceiveBufferSize);
		}
		if (m_UseTcpKeepAlive)
		{
			finalSocket.IOControl(IOControlCode.KeepAliveValues, new byte[12]
			{
				1,
				0,
				0,
				0,
				(byte)(m_TcpKeepAliveTime & 0xFF),
				(byte)((m_TcpKeepAliveTime >> 8) & 0xFF),
				(byte)((m_TcpKeepAliveTime >> 16) & 0xFF),
				(byte)((m_TcpKeepAliveTime >> 24) & 0xFF),
				(byte)(m_TcpKeepAliveInterval & 0xFF),
				(byte)((m_TcpKeepAliveInterval >> 8) & 0xFF),
				(byte)((m_TcpKeepAliveInterval >> 16) & 0xFF),
				(byte)((m_TcpKeepAliveInterval >> 24) & 0xFF)
			}, null);
		}
	}

	internal virtual void SubmitRequest(HttpWebRequest request)
	{
		SubmitRequest(request, null);
	}

	internal void SubmitRequest(HttpWebRequest request, string connName)
	{
		bool forcedsubmit = false;
		ConnectionGroup connectionGroup;
		lock (this)
		{
			connectionGroup = FindConnectionGroup(connName, dontCreate: false);
		}
		Connection connection;
		do
		{
			connection = connectionGroup.FindConnection(request, connName, out forcedsubmit);
		}
		while (connection != null && !connection.SubmitRequest(request, forcedsubmit));
	}

	public bool CloseConnectionGroup(string connectionGroupName)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, "CloseConnectionGroup", connectionGroupName);
		}
		return CloseConnectionGroupHelper(connectionGroupName, closeInternal: false);
	}

	internal void CloseConnectionGroupInternal(string connectionGroupName)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, "CloseConnectionGroupInternal", connectionGroupName);
		}
		CloseConnectionGroupHelper(connectionGroupName, closeInternal: true);
	}

	private bool CloseConnectionGroupHelper(string connectionGroupName, bool closeInternal)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, "CloseConnectionGroupHelper", "connectionGroupName=" + connectionGroupName + ", closeInternal=" + closeInternal);
		}
		string value = HttpWebRequest.GenerateConnectionGroup(connectionGroupName, unsafeConnectionGroup: false, isInternalGroup: false).ToString();
		string value2 = HttpWebRequest.GenerateConnectionGroup(connectionGroupName, unsafeConnectionGroup: true, isInternalGroup: false).ToString();
		string value3 = HttpWebRequest.GenerateConnectionGroup(connectionGroupName, unsafeConnectionGroup: false, isInternalGroup: true).ToString();
		string value4 = HttpWebRequest.GenerateConnectionGroup(connectionGroupName, unsafeConnectionGroup: true, isInternalGroup: true).ToString();
		List<string> list = null;
		lock (this)
		{
			foreach (object key in m_ConnectionGroupList.Keys)
			{
				string text = key as string;
				if (text.StartsWith(value3, StringComparison.Ordinal) || text.StartsWith(value4, StringComparison.Ordinal))
				{
					if (closeInternal)
					{
						if (list == null)
						{
							list = new List<string>();
						}
						list.Add(text);
					}
				}
				else if ((text.StartsWith(value, StringComparison.Ordinal) || text.StartsWith(value2, StringComparison.Ordinal)) && !closeInternal)
				{
					if (list == null)
					{
						list = new List<string>();
					}
					list.Add(text);
				}
			}
		}
		bool result = false;
		if (list != null)
		{
			foreach (string item in list)
			{
				if (ReleaseConnectionGroup(item))
				{
					result = true;
				}
			}
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, "CloseConnectionGroupHelper, returning", result.ToString());
		}
		return result;
	}

	private void ResolveConnectionLimit()
	{
		int connectionLimit = ConnectionLimit;
		foreach (ConnectionGroup value in m_ConnectionGroupList.Values)
		{
			value.ConnectionLimit = connectionLimit;
		}
	}

	internal void UpdateServerCertificate(X509Certificate certificate)
	{
		if (certificate != null)
		{
			m_ServerCertificateOrBytes = certificate.GetRawCertData();
		}
		else
		{
			m_ServerCertificateOrBytes = null;
		}
	}

	internal void UpdateClientCertificate(X509Certificate certificate)
	{
		if (certificate != null)
		{
			m_ClientCertificateOrBytes = certificate.GetRawCertData();
		}
		else
		{
			m_ClientCertificateOrBytes = null;
		}
	}

	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
	{
		if (enabled)
		{
			m_UseTcpKeepAlive = true;
			if (keepAliveTime <= 0)
			{
				throw new ArgumentOutOfRangeException("keepAliveTime");
			}
			if (keepAliveInterval <= 0)
			{
				throw new ArgumentOutOfRangeException("keepAliveInterval");
			}
			m_TcpKeepAliveTime = keepAliveTime;
			m_TcpKeepAliveInterval = keepAliveInterval;
		}
		else
		{
			m_UseTcpKeepAlive = false;
			m_TcpKeepAliveTime = 0;
			m_TcpKeepAliveInterval = 0;
		}
	}

	internal void IncrementConnection()
	{
		lock (m_ExpiringTimerLock)
		{
			m_CurrentConnections++;
			if (m_CurrentConnections == 1)
			{
				m_ExpiringTimer.Cancel();
				m_ExpiringTimer = null;
			}
		}
	}

	internal void DecrementConnection()
	{
		lock (m_ExpiringTimerLock)
		{
			m_CurrentConnections--;
			if (m_CurrentConnections == 0)
			{
				m_IdleSince = DateTime.Now;
				m_ExpiringTimer = m_IdlingQueue.CreateTimer(ServicePointManager.IdleServicePointTimeoutDelegate, this);
			}
			else if (m_CurrentConnections < 0)
			{
				m_CurrentConnections = 0;
			}
		}
	}

	internal RemoteCertValidationCallback SetupHandshakeDoneProcedure(TlsStream secureStream, object request)
	{
		return HandshakeDoneProcedure.CreateAdapter(this, secureStream, request);
	}

	private void IdleConnectionGroupTimeoutCallback(TimerThread.Timer timer, int timeNoticed, object context)
	{
		ConnectionGroup connectionGroup = (ConnectionGroup)context;
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_closed_idle", "ConnectionGroup", connectionGroup.GetHashCode()));
		}
		ReleaseConnectionGroup(connectionGroup.Name);
	}

	internal TimerThread.Timer CreateConnectionGroupTimer(ConnectionGroup connectionGroup)
	{
		return m_IdlingQueue.CreateTimer(m_IdleConnectionGroupTimeoutDelegate, connectionGroup);
	}

	internal bool ReleaseConnectionGroup(string connName)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, "ReleaseConnectionGroup", connName);
		}
		ConnectionGroup connectionGroup = null;
		lock (this)
		{
			connectionGroup = FindConnectionGroup(connName, dontCreate: true);
			if (connectionGroup == null)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.Web, this, "ReleaseConnectionGroup, returning", "false");
				}
				return false;
			}
			connectionGroup.CancelIdleTimer();
			m_ConnectionGroupList.Remove(connName);
		}
		connectionGroup.DisableKeepAliveOnConnections();
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, "ReleaseConnectionGroup, returning", "true");
		}
		return true;
	}

	internal void ReleaseAllConnectionGroups()
	{
		ArrayList arrayList = new ArrayList(m_ConnectionGroupList.Count);
		lock (this)
		{
			foreach (ConnectionGroup value in m_ConnectionGroupList.Values)
			{
				arrayList.Add(value);
			}
			m_ConnectionGroupList.Clear();
		}
		foreach (ConnectionGroup item in arrayList)
		{
			item.DisableKeepAliveOnConnections();
		}
	}

	private static void ConnectSocketCallback(IAsyncResult asyncResult)
	{
		ConnectSocketState connectSocketState = (ConnectSocketState)asyncResult.AsyncState;
		Socket socket = null;
		IPAddress address = null;
		Exception exception = null;
		Exception e = null;
		WebExceptionStatus webExceptionStatus = WebExceptionStatus.ConnectFailure;
		try
		{
			webExceptionStatus = connectSocketState.servicePoint.ConnectSocketInternal(connectSocketState.connectFailure, connectSocketState.s4, connectSocketState.s6, ref socket, ref address, connectSocketState, asyncResult, out exception);
		}
		catch (SocketException ex)
		{
			e = ex;
		}
		catch (ObjectDisposedException ex2)
		{
			e = ex2;
		}
		switch (webExceptionStatus)
		{
		case WebExceptionStatus.Pending:
			return;
		case WebExceptionStatus.Success:
			try
			{
				connectSocketState.servicePoint.CompleteGetConnection(connectSocketState.s4, connectSocketState.s6, socket, address);
			}
			catch (SocketException ex3)
			{
				e = ex3;
			}
			catch (ObjectDisposedException ex4)
			{
				e = ex4;
			}
			break;
		default:
			e = new WebException(NetRes.GetWebStatusString(webExceptionStatus), (webExceptionStatus == WebExceptionStatus.ProxyNameResolutionFailure || webExceptionStatus == WebExceptionStatus.NameResolutionFailure) ? connectSocketState.servicePoint.Host : null, exception, webExceptionStatus, null, WebExceptionInternalStatus.ServicePointFatal);
			break;
		}
		try
		{
			connectSocketState.pooledStream.ConnectionCallback(connectSocketState.owner, e, socket, address);
		}
		catch
		{
			if (socket != null && socket.CleanedUp)
			{
				return;
			}
			throw;
		}
	}

	private void BindUsingDelegate(Socket socket, IPEndPoint remoteIPEndPoint)
	{
		IPEndPoint remoteEndPoint = new IPEndPoint(remoteIPEndPoint.Address, remoteIPEndPoint.Port);
		int i;
		for (i = 0; i < int.MaxValue; i++)
		{
			IPEndPoint iPEndPoint = BindIPEndPointDelegate(this, remoteEndPoint, i);
			if (iPEndPoint != null)
			{
				try
				{
					socket.InternalBind(iPEndPoint);
				}
				catch
				{
					continue;
				}
			}
			break;
		}
		if (i == int.MaxValue)
		{
			throw new OverflowException("Reached maximum number of BindIPEndPointDelegate retries");
		}
	}

	private void SetUnicastReusePortForSocket(Socket socket)
	{
		if ((ServicePointManager.ReusePortSupported.HasValue && !ServicePointManager.ReusePortSupported.Value) || !ServicePointManager.ReusePort)
		{
			return;
		}
		try
		{
			socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseUnicastPort, 1);
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_set_socketoption_reuseport", "Socket", socket.GetHashCode()));
			}
			ServicePointManager.ReusePortSupported = true;
		}
		catch (SocketException)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_set_socketoption_reuseport_not_supported", "Socket", socket.GetHashCode()));
			}
			ServicePointManager.ReusePortSupported = false;
		}
		catch (Exception ex2)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_unexpected_exception", ex2.Message));
			}
		}
	}

	private WebExceptionStatus ConnectSocketInternal(bool connectFailure, Socket s4, Socket s6, ref Socket socket, ref IPAddress address, ConnectSocketState state, IAsyncResult asyncResult, out Exception exception)
	{
		exception = null;
		IPAddress[] array = null;
		for (int i = 0; i < 2; i++)
		{
			int j = 0;
			int currentIndex;
			if (asyncResult == null)
			{
				array = GetIPAddressInfoList(out currentIndex, array);
				if (array == null || array.Length == 0)
				{
					break;
				}
			}
			else
			{
				array = state.addresses;
				currentIndex = state.currentIndex;
				j = state.i;
				i = state.unsuccessfulAttempts;
			}
			for (; j < array.Length; j++)
			{
				IPAddress iPAddress = array[currentIndex];
				try
				{
					IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, m_Port);
					Socket socket2 = ((iPEndPoint.Address.AddressFamily != AddressFamily.InterNetwork) ? s6 : s4);
					if (state != null)
					{
						if (asyncResult == null)
						{
							state.addresses = array;
							state.currentIndex = currentIndex;
							state.i = j;
							state.unsuccessfulAttempts = i;
							state.connectFailure = connectFailure;
							if (!socket2.IsBound)
							{
								if (ServicePointManager.ReusePort)
								{
									SetUnicastReusePortForSocket(socket2);
								}
								if (BindIPEndPointDelegate != null)
								{
									BindUsingDelegate(socket2, iPEndPoint);
								}
							}
							socket2.UnsafeBeginConnect(iPEndPoint, m_ConnectCallbackDelegate, state);
							return WebExceptionStatus.Pending;
						}
						IAsyncResult asyncResult2 = asyncResult;
						asyncResult = null;
						socket2.EndConnect(asyncResult2);
					}
					else
					{
						if (!socket2.IsBound)
						{
							if (ServicePointManager.ReusePort)
							{
								SetUnicastReusePortForSocket(socket2);
							}
							if (BindIPEndPointDelegate != null)
							{
								BindUsingDelegate(socket2, iPEndPoint);
							}
						}
						bool success = false;
						SafeCloseSocket safeHandle = socket2.SafeHandle;
						try
						{
							if (ServicePointManager.UseSafeSynchronousClose)
							{
								safeHandle.DangerousAddRef(ref success);
							}
							socket2.InternalConnect(iPEndPoint);
						}
						finally
						{
							if (success)
							{
								safeHandle.DangerousRelease();
							}
						}
					}
					socket = socket2;
					address = iPAddress;
					exception = null;
					UpdateCurrentIndex(array, currentIndex);
					return WebExceptionStatus.Success;
				}
				catch (ObjectDisposedException)
				{
					return WebExceptionStatus.RequestCanceled;
				}
				catch (Exception ex2)
				{
					if (NclUtilities.IsFatal(ex2))
					{
						throw;
					}
					exception = ex2;
					connectFailure = true;
				}
				currentIndex++;
				if (currentIndex >= array.Length)
				{
					currentIndex = 0;
				}
			}
		}
		Failed(array);
		if (!connectFailure)
		{
			if (!InternalProxyServicePoint)
			{
				return WebExceptionStatus.NameResolutionFailure;
			}
			return WebExceptionStatus.ProxyNameResolutionFailure;
		}
		return WebExceptionStatus.ConnectFailure;
	}

	private WebExceptionStatus ConnectSocket(Socket s4, Socket s6, ref Socket socket, ref IPAddress address, ConnectSocketState state, out Exception exception)
	{
		return ConnectSocketInternal(connectFailure: false, s4, s6, ref socket, ref address, state, null, out exception);
	}

	[Conditional("DEBUG")]
	internal void DebugMembers(int requestHash)
	{
		foreach (ConnectionGroup value in m_ConnectionGroupList.Values)
		{
			if (value != null)
			{
				try
				{
				}
				catch
				{
				}
			}
		}
	}

	private void Failed(IPAddress[] addresses)
	{
		if (addresses != m_IPAddressInfoList)
		{
			return;
		}
		lock (this)
		{
			if (addresses == m_IPAddressInfoList)
			{
				m_AddressListFailed = true;
			}
		}
	}

	private void UpdateCurrentIndex(IPAddress[] addresses, int currentIndex)
	{
		if (addresses != m_IPAddressInfoList || (m_CurrentAddressInfoIndex == currentIndex && m_ConnectedSinceDns))
		{
			return;
		}
		lock (this)
		{
			if (addresses == m_IPAddressInfoList)
			{
				if (!ServicePointManager.EnableDnsRoundRobin)
				{
					m_CurrentAddressInfoIndex = currentIndex;
				}
				m_ConnectedSinceDns = true;
			}
		}
	}

	private IPAddress[] GetIPAddressInfoList(out int currentIndex, IPAddress[] addresses)
	{
		IPHostEntry result = null;
		currentIndex = 0;
		bool flag = false;
		bool flag2 = false;
		lock (this)
		{
			if (addresses != null && !m_ConnectedSinceDns && !m_AddressListFailed && addresses == m_IPAddressInfoList)
			{
				return null;
			}
			if (m_IPAddressInfoList == null || m_AddressListFailed || addresses == m_IPAddressInfoList || HasTimedOut)
			{
				m_CurrentAddressInfoIndex = 0;
				m_ConnectedSinceDns = false;
				m_AddressListFailed = false;
				m_LastDnsResolve = DateTime.UtcNow;
				flag = true;
			}
		}
		if (flag)
		{
			try
			{
				flag2 = !Dns.TryInternalResolve(m_Host, out result);
			}
			catch (Exception exception)
			{
				if (NclUtilities.IsFatal(exception))
				{
					throw;
				}
				flag2 = true;
			}
		}
		lock (this)
		{
			if (flag)
			{
				m_IPAddressInfoList = null;
				if (!flag2 && result != null && result.AddressList != null && result.AddressList.Length != 0)
				{
					SetAddressList(result);
				}
			}
			if (m_IPAddressInfoList != null && m_IPAddressInfoList.Length != 0)
			{
				currentIndex = m_CurrentAddressInfoIndex;
				if (ServicePointManager.EnableDnsRoundRobin)
				{
					m_CurrentAddressInfoIndex++;
					if (m_CurrentAddressInfoIndex >= m_IPAddressInfoList.Length)
					{
						m_CurrentAddressInfoIndex = 0;
					}
				}
				return m_IPAddressInfoList;
			}
		}
		return null;
	}

	private void SetAddressList(IPHostEntry ipHostEntry)
	{
		bool iPAddressesAreLoopback = m_IPAddressesAreLoopback;
		bool flag = m_IPAddressInfoList == null;
		m_IPAddressesAreLoopback = IsAddressListLoopback(ipHostEntry.AddressList);
		m_IPAddressInfoList = ipHostEntry.AddressList;
		m_HostName = ipHostEntry.HostName;
		m_IsTrustedHost = ipHostEntry.isTrustedHost;
		if (flag || iPAddressesAreLoopback != m_IPAddressesAreLoopback)
		{
			ResolveConnectionLimit();
		}
	}

	private static bool IsAddressListLoopback(IPAddress[] addressList)
	{
		IPAddress[] array = null;
		try
		{
			array = NclUtilities.LocalAddresses;
		}
		catch (Exception ex)
		{
			if (NclUtilities.IsFatal(ex))
			{
				throw;
			}
			if (Logging.On)
			{
				Logging.PrintError(Logging.Web, SR.GetString("net_log_retrieving_localhost_exception", ex));
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_resolved_servicepoint_may_not_be_remote_server"));
			}
		}
		int i;
		for (i = 0; i < addressList.Length; i++)
		{
			if (!IPAddress.IsLoopback(addressList[i]))
			{
				if (array == null)
				{
					break;
				}
				int j;
				for (j = 0; j < array.Length && !addressList[i].Equals(array[j]); j++)
				{
				}
				if (j >= array.Length)
				{
					break;
				}
			}
		}
		return i == addressList.Length;
	}
}
