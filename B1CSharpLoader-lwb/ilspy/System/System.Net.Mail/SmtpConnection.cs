using System.Globalization;
using System.IO;
using System.Security.Authentication;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;

namespace System.Net.Mail;

internal class SmtpConnection
{
	private class AuthenticateCallbackContext
	{
		internal readonly SmtpConnection thisPtr;

		internal readonly ISmtpAuthenticationModule module;

		internal readonly NetworkCredential credential;

		internal readonly string spn;

		internal readonly ChannelBinding token;

		internal Authorization result;

		internal AuthenticateCallbackContext(SmtpConnection thisPtr, ISmtpAuthenticationModule module, NetworkCredential credential, string spn, ChannelBinding Token)
		{
			this.thisPtr = thisPtr;
			this.module = module;
			this.credential = credential;
			this.spn = spn;
			token = Token;
			result = null;
		}
	}

	private class ConnectAndHandshakeAsyncResult : LazyAsyncResult
	{
		private static readonly GeneralAsyncDelegate m_ConnectionCreatedCallback = ConnectionCreatedCallback;

		private string authResponse;

		private SmtpConnection connection;

		private int currentModule = -1;

		private int port;

		private static AsyncCallback handshakeCallback = HandshakeCallback;

		private static AsyncCallback sendEHelloCallback = SendEHelloCallback;

		private static AsyncCallback sendHelloCallback = SendHelloCallback;

		private static AsyncCallback authenticateCallback = AuthenticateCallback;

		private static AsyncCallback authenticateContinueCallback = AuthenticateContinueCallback;

		private string host;

		private readonly ContextAwareResult m_OuterResult;

		internal ConnectAndHandshakeAsyncResult(SmtpConnection connection, string host, int port, ContextAwareResult outerResult, AsyncCallback callback, object state)
			: base(null, state, callback)
		{
			this.connection = connection;
			this.host = host;
			this.port = port;
			m_OuterResult = outerResult;
		}

		private static void ConnectionCreatedCallback(object request, object state)
		{
			ConnectAndHandshakeAsyncResult connectAndHandshakeAsyncResult = (ConnectAndHandshakeAsyncResult)request;
			if (state is Exception)
			{
				connectAndHandshakeAsyncResult.InvokeCallback((Exception)state);
				return;
			}
			SmtpPooledStream smtpPooledStream = (SmtpPooledStream)(PooledStream)state;
			try
			{
				while (smtpPooledStream.creds != null && smtpPooledStream.creds != connectAndHandshakeAsyncResult.connection.credentials)
				{
					connectAndHandshakeAsyncResult.connection.connectionPool.PutConnection(smtpPooledStream, smtpPooledStream.Owner, connectAndHandshakeAsyncResult.connection.Timeout, canReuse: false);
					smtpPooledStream = (SmtpPooledStream)connectAndHandshakeAsyncResult.connection.connectionPool.GetConnection(connectAndHandshakeAsyncResult, m_ConnectionCreatedCallback, connectAndHandshakeAsyncResult.connection.Timeout);
					if (smtpPooledStream == null)
					{
						return;
					}
				}
				if (Logging.On)
				{
					Logging.Associate(Logging.Web, connectAndHandshakeAsyncResult.connection, smtpPooledStream);
				}
				smtpPooledStream.Owner = connectAndHandshakeAsyncResult.connection;
				smtpPooledStream.creds = connectAndHandshakeAsyncResult.connection.credentials;
				lock (connectAndHandshakeAsyncResult.connection)
				{
					if (connectAndHandshakeAsyncResult.connection.isClosed)
					{
						connectAndHandshakeAsyncResult.connection.connectionPool.PutConnection(smtpPooledStream, smtpPooledStream.Owner, connectAndHandshakeAsyncResult.connection.Timeout, canReuse: false);
						connectAndHandshakeAsyncResult.InvokeCallback(null);
						return;
					}
					connectAndHandshakeAsyncResult.connection.pooledStream = smtpPooledStream;
				}
				connectAndHandshakeAsyncResult.Handshake();
			}
			catch (Exception result)
			{
				connectAndHandshakeAsyncResult.InvokeCallback(result);
			}
		}

		internal static void End(IAsyncResult result)
		{
			ConnectAndHandshakeAsyncResult connectAndHandshakeAsyncResult = (ConnectAndHandshakeAsyncResult)result;
			object obj = connectAndHandshakeAsyncResult.InternalWaitForCompletion();
			if (obj is Exception)
			{
				throw (Exception)obj;
			}
		}

		internal void GetConnection(bool synchronous)
		{
			if (connection.isConnected)
			{
				throw new InvalidOperationException(SR.GetString("SmtpAlreadyConnected"));
			}
			SmtpPooledStream smtpPooledStream = (SmtpPooledStream)connection.connectionPool.GetConnection(this, synchronous ? null : m_ConnectionCreatedCallback, connection.Timeout);
			if (smtpPooledStream == null)
			{
				return;
			}
			try
			{
				while (smtpPooledStream.creds != null && smtpPooledStream.creds != connection.credentials)
				{
					connection.connectionPool.PutConnection(smtpPooledStream, smtpPooledStream.Owner, connection.Timeout, canReuse: false);
					smtpPooledStream = (SmtpPooledStream)connection.connectionPool.GetConnection(this, synchronous ? null : m_ConnectionCreatedCallback, connection.Timeout);
					if (smtpPooledStream == null)
					{
						return;
					}
				}
				smtpPooledStream.creds = connection.credentials;
				smtpPooledStream.Owner = connection;
				lock (connection)
				{
					connection.pooledStream = smtpPooledStream;
				}
				Handshake();
			}
			catch (Exception result)
			{
				InvokeCallback(result);
			}
		}

		private void Handshake()
		{
			connection.responseReader = new SmtpReplyReaderFactory(connection.pooledStream.NetworkStream);
			connection.pooledStream.UpdateLifetime();
			if (((SmtpPooledStream)connection.pooledStream).previouslyUsed)
			{
				connection.isConnected = true;
				InvokeCallback();
				return;
			}
			SmtpReplyReader nextReplyReader = connection.Reader.GetNextReplyReader();
			IAsyncResult asyncResult = nextReplyReader.BeginReadLine(handshakeCallback, this);
			if (!asyncResult.CompletedSynchronously)
			{
				return;
			}
			LineInfo lineInfo = nextReplyReader.EndReadLine(asyncResult);
			if (lineInfo.StatusCode != SmtpStatusCode.ServiceReady)
			{
				throw new SmtpException(lineInfo.StatusCode, lineInfo.Line, serverResponse: true);
			}
			try
			{
				SendEHello();
			}
			catch
			{
				SendHello();
			}
		}

		private static void HandshakeCallback(IAsyncResult result)
		{
			if (result.CompletedSynchronously)
			{
				return;
			}
			ConnectAndHandshakeAsyncResult connectAndHandshakeAsyncResult = (ConnectAndHandshakeAsyncResult)result.AsyncState;
			try
			{
				try
				{
					LineInfo lineInfo = connectAndHandshakeAsyncResult.connection.Reader.CurrentReader.EndReadLine(result);
					if (lineInfo.StatusCode != SmtpStatusCode.ServiceReady)
					{
						connectAndHandshakeAsyncResult.InvokeCallback(new SmtpException(lineInfo.StatusCode, lineInfo.Line, serverResponse: true));
					}
					else if (connectAndHandshakeAsyncResult.SendEHello())
					{
					}
				}
				catch (SmtpException)
				{
					if (connectAndHandshakeAsyncResult.SendHello())
					{
					}
				}
			}
			catch (Exception result2)
			{
				connectAndHandshakeAsyncResult.InvokeCallback(result2);
			}
		}

		private bool SendEHello()
		{
			IAsyncResult asyncResult = EHelloCommand.BeginSend(connection, connection.client.clientDomain, sendEHelloCallback, this);
			if (asyncResult.CompletedSynchronously)
			{
				connection.extensions = EHelloCommand.EndSend(asyncResult);
				connection.ParseExtensions(connection.extensions);
				if (connection.pooledStream.NetworkStream is TlsStream)
				{
					Authenticate();
					return true;
				}
				if (connection.EnableSsl)
				{
					if (!connection.serverSupportsStartTls && !(connection.pooledStream.NetworkStream is TlsStream))
					{
						throw new SmtpException(SR.GetString("MailServerDoesNotSupportStartTls"));
					}
					SendStartTls();
				}
				else
				{
					Authenticate();
				}
				return true;
			}
			return false;
		}

		private static void SendEHelloCallback(IAsyncResult result)
		{
			if (result.CompletedSynchronously)
			{
				return;
			}
			ConnectAndHandshakeAsyncResult connectAndHandshakeAsyncResult = (ConnectAndHandshakeAsyncResult)result.AsyncState;
			try
			{
				try
				{
					connectAndHandshakeAsyncResult.connection.extensions = EHelloCommand.EndSend(result);
					connectAndHandshakeAsyncResult.connection.ParseExtensions(connectAndHandshakeAsyncResult.connection.extensions);
					if (connectAndHandshakeAsyncResult.connection.pooledStream.NetworkStream is TlsStream)
					{
						connectAndHandshakeAsyncResult.Authenticate();
						return;
					}
				}
				catch (SmtpException ex)
				{
					if (ex.StatusCode != SmtpStatusCode.CommandUnrecognized && ex.StatusCode != SmtpStatusCode.CommandNotImplemented)
					{
						throw ex;
					}
					if (!connectAndHandshakeAsyncResult.SendHello())
					{
						return;
					}
				}
				if (connectAndHandshakeAsyncResult.connection.EnableSsl)
				{
					if (!connectAndHandshakeAsyncResult.connection.serverSupportsStartTls && !(connectAndHandshakeAsyncResult.connection.pooledStream.NetworkStream is TlsStream))
					{
						throw new SmtpException(SR.GetString("MailServerDoesNotSupportStartTls"));
					}
					connectAndHandshakeAsyncResult.SendStartTls();
				}
				else
				{
					connectAndHandshakeAsyncResult.Authenticate();
				}
			}
			catch (Exception result2)
			{
				connectAndHandshakeAsyncResult.InvokeCallback(result2);
			}
		}

		private bool SendHello()
		{
			IAsyncResult asyncResult = HelloCommand.BeginSend(connection, connection.client.clientDomain, sendHelloCallback, this);
			if (asyncResult.CompletedSynchronously)
			{
				connection.supportedAuth = SupportedAuth.Login;
				HelloCommand.EndSend(asyncResult);
				Authenticate();
				return true;
			}
			return false;
		}

		private static void SendHelloCallback(IAsyncResult result)
		{
			if (!result.CompletedSynchronously)
			{
				ConnectAndHandshakeAsyncResult connectAndHandshakeAsyncResult = (ConnectAndHandshakeAsyncResult)result.AsyncState;
				try
				{
					HelloCommand.EndSend(result);
					connectAndHandshakeAsyncResult.Authenticate();
				}
				catch (Exception result2)
				{
					connectAndHandshakeAsyncResult.InvokeCallback(result2);
				}
			}
		}

		private bool SendStartTls()
		{
			IAsyncResult asyncResult = StartTlsCommand.BeginSend(connection, SendStartTlsCallback, this);
			if (asyncResult.CompletedSynchronously)
			{
				StartTlsCommand.EndSend(asyncResult);
				TlsStream networkStream = new TlsStream(connection.pooledStream.ServicePoint.Host, connection.pooledStream.NetworkStream, ServicePointManager.CheckCertificateRevocationList, (SslProtocols)ServicePointManager.SecurityProtocol, connection.ClientCertificates, connection.pooledStream.ServicePoint, connection.client, m_OuterResult.ContextCopy);
				connection.pooledStream.NetworkStream = networkStream;
				connection.responseReader = new SmtpReplyReaderFactory(connection.pooledStream.NetworkStream);
				SendEHello();
				return true;
			}
			return false;
		}

		private static void SendStartTlsCallback(IAsyncResult result)
		{
			if (!result.CompletedSynchronously)
			{
				ConnectAndHandshakeAsyncResult connectAndHandshakeAsyncResult = (ConnectAndHandshakeAsyncResult)result.AsyncState;
				try
				{
					StartTlsCommand.EndSend(result);
					TlsStream networkStream = new TlsStream(connectAndHandshakeAsyncResult.connection.pooledStream.ServicePoint.Host, connectAndHandshakeAsyncResult.connection.pooledStream.NetworkStream, ServicePointManager.CheckCertificateRevocationList, (SslProtocols)ServicePointManager.SecurityProtocol, connectAndHandshakeAsyncResult.connection.ClientCertificates, connectAndHandshakeAsyncResult.connection.pooledStream.ServicePoint, connectAndHandshakeAsyncResult.connection.client, connectAndHandshakeAsyncResult.m_OuterResult.ContextCopy);
					connectAndHandshakeAsyncResult.connection.pooledStream.NetworkStream = networkStream;
					connectAndHandshakeAsyncResult.connection.responseReader = new SmtpReplyReaderFactory(connectAndHandshakeAsyncResult.connection.pooledStream.NetworkStream);
					connectAndHandshakeAsyncResult.SendEHello();
				}
				catch (Exception result2)
				{
					connectAndHandshakeAsyncResult.InvokeCallback(result2);
				}
			}
		}

		private void Authenticate()
		{
			if (connection.credentials != null)
			{
				while (++currentModule < connection.authenticationModules.Length)
				{
					ISmtpAuthenticationModule smtpAuthenticationModule = connection.authenticationModules[currentModule];
					if (!connection.AuthSupported(smtpAuthenticationModule))
					{
						continue;
					}
					NetworkCredential credential = connection.credentials.GetCredential(host, port, smtpAuthenticationModule.AuthenticationType);
					if (credential == null)
					{
						continue;
					}
					Authorization authorization = connection.SetContextAndTryAuthenticate(smtpAuthenticationModule, credential, m_OuterResult);
					if (authorization == null || authorization.Message == null)
					{
						continue;
					}
					IAsyncResult asyncResult = AuthCommand.BeginSend(connection, connection.authenticationModules[currentModule].AuthenticationType, authorization.Message, authenticateCallback, this);
					if (!asyncResult.CompletedSynchronously)
					{
						return;
					}
					LineInfo lineInfo = AuthCommand.EndSend(asyncResult);
					if (lineInfo.StatusCode == (SmtpStatusCode)334)
					{
						authResponse = lineInfo.Line;
						if (!AuthenticateContinue())
						{
							return;
						}
					}
					else if (lineInfo.StatusCode == (SmtpStatusCode)235)
					{
						smtpAuthenticationModule.CloseContext(connection);
						connection.isConnected = true;
						break;
					}
				}
			}
			connection.isConnected = true;
			InvokeCallback();
		}

		private static void AuthenticateCallback(IAsyncResult result)
		{
			if (result.CompletedSynchronously)
			{
				return;
			}
			ConnectAndHandshakeAsyncResult connectAndHandshakeAsyncResult = (ConnectAndHandshakeAsyncResult)result.AsyncState;
			try
			{
				LineInfo lineInfo = AuthCommand.EndSend(result);
				if (lineInfo.StatusCode == (SmtpStatusCode)334)
				{
					connectAndHandshakeAsyncResult.authResponse = lineInfo.Line;
					if (!connectAndHandshakeAsyncResult.AuthenticateContinue())
					{
						return;
					}
				}
				else if (lineInfo.StatusCode == (SmtpStatusCode)235)
				{
					connectAndHandshakeAsyncResult.connection.authenticationModules[connectAndHandshakeAsyncResult.currentModule].CloseContext(connectAndHandshakeAsyncResult.connection);
					connectAndHandshakeAsyncResult.connection.isConnected = true;
					connectAndHandshakeAsyncResult.InvokeCallback();
					return;
				}
				connectAndHandshakeAsyncResult.Authenticate();
			}
			catch (Exception result2)
			{
				connectAndHandshakeAsyncResult.InvokeCallback(result2);
			}
		}

		private bool AuthenticateContinue()
		{
			while (true)
			{
				Authorization authorization = connection.authenticationModules[currentModule].Authenticate(authResponse, null, connection, connection.client.TargetName, connection.channelBindingToken);
				if (authorization == null)
				{
					throw new SmtpException(SR.GetString("SmtpAuthenticationFailed"));
				}
				IAsyncResult asyncResult = AuthCommand.BeginSend(connection, authorization.Message, authenticateContinueCallback, this);
				if (!asyncResult.CompletedSynchronously)
				{
					return false;
				}
				LineInfo lineInfo = AuthCommand.EndSend(asyncResult);
				if (lineInfo.StatusCode == (SmtpStatusCode)235)
				{
					connection.authenticationModules[currentModule].CloseContext(connection);
					connection.isConnected = true;
					InvokeCallback();
					return false;
				}
				if (lineInfo.StatusCode != (SmtpStatusCode)334)
				{
					break;
				}
				authResponse = lineInfo.Line;
			}
			return true;
		}

		private static void AuthenticateContinueCallback(IAsyncResult result)
		{
			if (result.CompletedSynchronously)
			{
				return;
			}
			ConnectAndHandshakeAsyncResult connectAndHandshakeAsyncResult = (ConnectAndHandshakeAsyncResult)result.AsyncState;
			try
			{
				LineInfo lineInfo = AuthCommand.EndSend(result);
				if (lineInfo.StatusCode == (SmtpStatusCode)235)
				{
					connectAndHandshakeAsyncResult.connection.authenticationModules[connectAndHandshakeAsyncResult.currentModule].CloseContext(connectAndHandshakeAsyncResult.connection);
					connectAndHandshakeAsyncResult.connection.isConnected = true;
					connectAndHandshakeAsyncResult.InvokeCallback();
					return;
				}
				if (lineInfo.StatusCode == (SmtpStatusCode)334)
				{
					connectAndHandshakeAsyncResult.authResponse = lineInfo.Line;
					if (!connectAndHandshakeAsyncResult.AuthenticateContinue())
					{
						return;
					}
				}
				connectAndHandshakeAsyncResult.Authenticate();
			}
			catch (Exception result2)
			{
				connectAndHandshakeAsyncResult.InvokeCallback(result2);
			}
		}
	}

	private static readonly CreateConnectionDelegate m_CreateConnectionCallback = CreateSmtpPooledStream;

	private static readonly ContextCallback s_AuthenticateCallback = AuthenticateCallback;

	private BufferBuilder bufferBuilder = new BufferBuilder();

	private bool isConnected;

	private bool isClosed;

	private bool isStreamOpen;

	private bool sawNegotiate;

	private EventHandler onCloseHandler;

	internal SmtpTransport parent;

	internal SmtpClient client;

	private SmtpReplyReaderFactory responseReader;

	private const int sizeOfAuthString = 5;

	private const int sizeOfAuthExtension = 4;

	private const string authExtension = "auth";

	private const string authLogin = "login";

	private const string authNtlm = "ntlm";

	private const string authGssapi = "gssapi";

	private const string authWDigest = "wdigest";

	private PooledStream pooledStream;

	private ConnectionPool connectionPool;

	private SupportedAuth supportedAuth;

	private bool serverSupportsStartTls;

	private ISmtpAuthenticationModule[] authenticationModules;

	private ICredentialsByHost credentials;

	private int timeout = 100000;

	private string[] extensions;

	private ChannelBinding channelBindingToken;

	private bool enableSsl;

	private X509CertificateCollection clientCertificates;

	internal BufferBuilder BufferBuilder => bufferBuilder;

	internal bool IsConnected => isConnected;

	internal bool IsStreamOpen => isStreamOpen;

	internal bool DSNEnabled
	{
		get
		{
			if (pooledStream != null)
			{
				return ((SmtpPooledStream)pooledStream).dsnEnabled;
			}
			return false;
		}
	}

	internal SmtpReplyReaderFactory Reader => responseReader;

	internal bool EnableSsl
	{
		get
		{
			return enableSsl;
		}
		set
		{
			enableSsl = value;
		}
	}

	internal int Timeout
	{
		get
		{
			return timeout;
		}
		set
		{
			timeout = value;
		}
	}

	internal X509CertificateCollection ClientCertificates
	{
		get
		{
			return clientCertificates;
		}
		set
		{
			clientCertificates = value;
		}
	}

	internal bool ServerSupportsEai
	{
		get
		{
			SmtpPooledStream smtpPooledStream = (SmtpPooledStream)pooledStream;
			return smtpPooledStream.serverSupportsEai;
		}
	}

	private static PooledStream CreateSmtpPooledStream(ConnectionPool pool)
	{
		return new SmtpPooledStream(pool, TimeSpan.MaxValue, checkLifetime: false);
	}

	internal SmtpConnection(SmtpTransport parent, SmtpClient client, ICredentialsByHost credentials, ISmtpAuthenticationModule[] authenticationModules)
	{
		this.client = client;
		this.credentials = credentials;
		this.authenticationModules = authenticationModules;
		this.parent = parent;
		onCloseHandler = OnClose;
	}

	internal IAsyncResult BeginGetConnection(ServicePoint servicePoint, ContextAwareResult outerResult, AsyncCallback callback, object state)
	{
		if (Logging.On)
		{
			Logging.Associate(Logging.Web, this, servicePoint);
		}
		if (EnableSsl && ClientCertificates != null && ClientCertificates.Count > 0)
		{
			connectionPool = ConnectionPoolManager.GetConnectionPool(servicePoint, ClientCertificates.GetHashCode().ToString(NumberFormatInfo.InvariantInfo), m_CreateConnectionCallback);
		}
		else
		{
			connectionPool = ConnectionPoolManager.GetConnectionPool(servicePoint, "", m_CreateConnectionCallback);
		}
		ConnectAndHandshakeAsyncResult connectAndHandshakeAsyncResult = new ConnectAndHandshakeAsyncResult(this, servicePoint.Host, servicePoint.Port, outerResult, callback, state);
		connectAndHandshakeAsyncResult.GetConnection(synchronous: false);
		return connectAndHandshakeAsyncResult;
	}

	internal IAsyncResult BeginFlush(AsyncCallback callback, object state)
	{
		return pooledStream.UnsafeBeginWrite(bufferBuilder.GetBuffer(), 0, bufferBuilder.Length, callback, state);
	}

	internal void EndFlush(IAsyncResult result)
	{
		pooledStream.EndWrite(result);
		bufferBuilder.Reset();
	}

	internal void Flush()
	{
		pooledStream.Write(bufferBuilder.GetBuffer(), 0, bufferBuilder.Length);
		bufferBuilder.Reset();
	}

	internal void ReleaseConnection()
	{
		if (!isClosed)
		{
			lock (this)
			{
				if (!isClosed && pooledStream != null)
				{
					if (channelBindingToken != null)
					{
						channelBindingToken.Close();
					}
					((SmtpPooledStream)pooledStream).previouslyUsed = true;
					connectionPool.PutConnection(pooledStream, pooledStream.Owner, Timeout);
				}
				isClosed = true;
			}
		}
		isConnected = false;
	}

	internal void Abort()
	{
		if (!isClosed)
		{
			lock (this)
			{
				if (!isClosed && pooledStream != null)
				{
					if (channelBindingToken != null)
					{
						channelBindingToken.Close();
					}
					pooledStream.Close(0);
					connectionPool.PutConnection(pooledStream, pooledStream.Owner, Timeout, canReuse: false);
				}
				isClosed = true;
			}
		}
		isConnected = false;
	}

	internal void ParseExtensions(string[] extensions)
	{
		supportedAuth = SupportedAuth.None;
		foreach (string text in extensions)
		{
			if (string.Compare(text, 0, "auth", 0, 4, StringComparison.OrdinalIgnoreCase) == 0)
			{
				string[] array = text.Remove(0, 4).Split(new char[2] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
				string[] array2 = array;
				foreach (string strA in array2)
				{
					if (string.Compare(strA, "login", StringComparison.OrdinalIgnoreCase) == 0)
					{
						supportedAuth |= SupportedAuth.Login;
					}
					else if (string.Compare(strA, "ntlm", StringComparison.OrdinalIgnoreCase) == 0)
					{
						supportedAuth |= SupportedAuth.NTLM;
					}
					else if (string.Compare(strA, "gssapi", StringComparison.OrdinalIgnoreCase) == 0)
					{
						supportedAuth |= SupportedAuth.GSSAPI;
					}
					else if (string.Compare(strA, "wdigest", StringComparison.OrdinalIgnoreCase) == 0)
					{
						supportedAuth |= SupportedAuth.WDigest;
					}
				}
			}
			else if (string.Compare(text, 0, "dsn ", 0, 3, StringComparison.OrdinalIgnoreCase) == 0)
			{
				((SmtpPooledStream)pooledStream).dsnEnabled = true;
			}
			else if (string.Compare(text, 0, "STARTTLS", 0, 8, StringComparison.OrdinalIgnoreCase) == 0)
			{
				serverSupportsStartTls = true;
			}
			else if (string.Compare(text, 0, "SMTPUTF8", 0, 8, StringComparison.OrdinalIgnoreCase) == 0)
			{
				((SmtpPooledStream)pooledStream).serverSupportsEai = true;
			}
		}
	}

	internal bool AuthSupported(ISmtpAuthenticationModule module)
	{
		if (module is SmtpLoginAuthenticationModule)
		{
			if ((supportedAuth & SupportedAuth.Login) > SupportedAuth.None)
			{
				return true;
			}
		}
		else if (module is SmtpNegotiateAuthenticationModule)
		{
			if ((supportedAuth & SupportedAuth.GSSAPI) > SupportedAuth.None)
			{
				sawNegotiate = true;
				return true;
			}
		}
		else if (module is SmtpNtlmAuthenticationModule)
		{
			if (!sawNegotiate && (supportedAuth & SupportedAuth.NTLM) > SupportedAuth.None)
			{
				return true;
			}
		}
		else if (module is SmtpDigestAuthenticationModule && (supportedAuth & SupportedAuth.WDigest) > SupportedAuth.None)
		{
			return true;
		}
		return false;
	}

	internal void GetConnection(ServicePoint servicePoint)
	{
		if (isConnected)
		{
			throw new InvalidOperationException(SR.GetString("SmtpAlreadyConnected"));
		}
		if (Logging.On)
		{
			Logging.Associate(Logging.Web, this, servicePoint);
		}
		connectionPool = ConnectionPoolManager.GetConnectionPool(servicePoint, "", m_CreateConnectionCallback);
		PooledStream connection = connectionPool.GetConnection(this, null, Timeout);
		while (((SmtpPooledStream)connection).creds != null && ((SmtpPooledStream)connection).creds != credentials)
		{
			connectionPool.PutConnection(connection, connection.Owner, Timeout, canReuse: false);
			connection = connectionPool.GetConnection(this, null, Timeout);
		}
		if (Logging.On)
		{
			Logging.Associate(Logging.Web, this, connection);
		}
		lock (this)
		{
			pooledStream = connection;
		}
		((SmtpPooledStream)connection).creds = credentials;
		responseReader = new SmtpReplyReaderFactory(connection.NetworkStream);
		connection.UpdateLifetime();
		if (((SmtpPooledStream)connection).previouslyUsed)
		{
			isConnected = true;
			return;
		}
		LineInfo lineInfo = responseReader.GetNextReplyReader().ReadLine();
		SmtpStatusCode statusCode = lineInfo.StatusCode;
		if (statusCode != SmtpStatusCode.ServiceReady)
		{
			throw new SmtpException(lineInfo.StatusCode, lineInfo.Line, serverResponse: true);
		}
		try
		{
			extensions = EHelloCommand.Send(this, client.clientDomain);
			ParseExtensions(extensions);
		}
		catch (SmtpException ex)
		{
			if (ex.StatusCode != SmtpStatusCode.CommandUnrecognized && ex.StatusCode != SmtpStatusCode.CommandNotImplemented)
			{
				throw ex;
			}
			HelloCommand.Send(this, client.clientDomain);
			supportedAuth = SupportedAuth.Login;
		}
		if (enableSsl)
		{
			if (!serverSupportsStartTls && !(connection.NetworkStream is TlsStream))
			{
				throw new SmtpException(SR.GetString("MailServerDoesNotSupportStartTls"));
			}
			StartTlsCommand.Send(this);
			TlsStream tlsStream = (TlsStream)(connection.NetworkStream = new TlsStream(servicePoint.Host, connection.NetworkStream, ServicePointManager.CheckCertificateRevocationList, (SslProtocols)ServicePointManager.SecurityProtocol, clientCertificates, servicePoint, client, null));
			channelBindingToken = tlsStream.GetChannelBinding(ChannelBindingKind.Unique);
			responseReader = new SmtpReplyReaderFactory(connection.NetworkStream);
			extensions = EHelloCommand.Send(this, client.clientDomain);
			ParseExtensions(extensions);
		}
		if (credentials != null)
		{
			for (int i = 0; i < authenticationModules.Length; i++)
			{
				if (!AuthSupported(authenticationModules[i]))
				{
					continue;
				}
				NetworkCredential credential = credentials.GetCredential(servicePoint.Host, servicePoint.Port, authenticationModules[i].AuthenticationType);
				if (credential == null)
				{
					continue;
				}
				Authorization authorization = SetContextAndTryAuthenticate(authenticationModules[i], credential, null);
				if (authorization == null || authorization.Message == null)
				{
					continue;
				}
				lineInfo = AuthCommand.Send(this, authenticationModules[i].AuthenticationType, authorization.Message);
				if (lineInfo.StatusCode == SmtpStatusCode.CommandParameterNotImplemented)
				{
					continue;
				}
				while (lineInfo.StatusCode == (SmtpStatusCode)334)
				{
					authorization = authenticationModules[i].Authenticate(lineInfo.Line, null, this, client.TargetName, channelBindingToken);
					if (authorization == null)
					{
						throw new SmtpException(SR.GetString("SmtpAuthenticationFailed"));
					}
					lineInfo = AuthCommand.Send(this, authorization.Message);
					if (lineInfo.StatusCode == (SmtpStatusCode)235)
					{
						authenticationModules[i].CloseContext(this);
						isConnected = true;
						return;
					}
				}
			}
		}
		isConnected = true;
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlPrincipal)]
	private Authorization SetContextAndTryAuthenticate(ISmtpAuthenticationModule module, NetworkCredential credential, ContextAwareResult context)
	{
		if (credential is SystemNetworkCredential)
		{
			WindowsIdentity windowsIdentity = context?.Identity;
			try
			{
				IDisposable disposable = windowsIdentity?.Impersonate();
				if (disposable != null)
				{
					using (disposable)
					{
						return module.Authenticate(null, credential, this, client.TargetName, channelBindingToken);
					}
				}
				ExecutionContext executionContext = context?.ContextCopy;
				if (executionContext != null)
				{
					AuthenticateCallbackContext authenticateCallbackContext = new AuthenticateCallbackContext(this, module, credential, client.TargetName, channelBindingToken);
					ExecutionContext.Run(executionContext, s_AuthenticateCallback, authenticateCallbackContext);
					return authenticateCallbackContext.result;
				}
				return module.Authenticate(null, credential, this, client.TargetName, channelBindingToken);
			}
			catch
			{
				throw;
			}
		}
		return module.Authenticate(null, credential, this, client.TargetName, channelBindingToken);
	}

	private static void AuthenticateCallback(object state)
	{
		AuthenticateCallbackContext authenticateCallbackContext = (AuthenticateCallbackContext)state;
		authenticateCallbackContext.result = authenticateCallbackContext.module.Authenticate(null, authenticateCallbackContext.credential, authenticateCallbackContext.thisPtr, authenticateCallbackContext.spn, authenticateCallbackContext.token);
	}

	internal void EndGetConnection(IAsyncResult result)
	{
		ConnectAndHandshakeAsyncResult.End(result);
	}

	internal Stream GetClosableStream()
	{
		ClosableStream result = new ClosableStream(pooledStream.NetworkStream, onCloseHandler);
		isStreamOpen = true;
		return result;
	}

	private void OnClose(object sender, EventArgs args)
	{
		isStreamOpen = false;
		DataStopCommand.Send(this);
	}
}
