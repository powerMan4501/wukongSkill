using System.Threading;
using System.Threading.Tasks;

namespace System.Net.WebSockets;

public sealed class ClientWebSocket : WebSocket
{
	private readonly ClientWebSocketOptions options;

	private WebSocket innerWebSocket;

	private readonly CancellationTokenSource cts;

	private int state;

	private const int created = 0;

	private const int connecting = 1;

	private const int connected = 2;

	private const int disposed = 3;

	public ClientWebSocketOptions Options => options;

	public override WebSocketCloseStatus? CloseStatus
	{
		get
		{
			if (innerWebSocket != null)
			{
				return innerWebSocket.CloseStatus;
			}
			return null;
		}
	}

	public override string CloseStatusDescription
	{
		get
		{
			if (innerWebSocket != null)
			{
				return innerWebSocket.CloseStatusDescription;
			}
			return null;
		}
	}

	public override string SubProtocol
	{
		get
		{
			if (innerWebSocket != null)
			{
				return innerWebSocket.SubProtocol;
			}
			return null;
		}
	}

	public override WebSocketState State
	{
		get
		{
			if (innerWebSocket != null)
			{
				return innerWebSocket.State;
			}
			return state switch
			{
				0 => WebSocketState.None, 
				1 => WebSocketState.Connecting, 
				3 => WebSocketState.Closed, 
				_ => WebSocketState.Closed, 
			};
		}
	}

	static ClientWebSocket()
	{
		WebSocket.RegisterPrefixes();
	}

	public ClientWebSocket()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.WebSockets, this, ".ctor", null);
		}
		if (!WebSocketProtocolComponent.IsSupported)
		{
			WebSocketHelpers.ThrowPlatformNotSupportedException_WSPC();
		}
		state = 0;
		options = new ClientWebSocketOptions();
		cts = new CancellationTokenSource();
		if (Logging.On)
		{
			Logging.Exit(Logging.WebSockets, this, ".ctor", null);
		}
	}

	public Task ConnectAsync(Uri uri, CancellationToken cancellationToken)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		if (!uri.IsAbsoluteUri)
		{
			throw new ArgumentException(SR.GetString("net_uri_NotAbsolute"), "uri");
		}
		if (uri.Scheme != Uri.UriSchemeWs && uri.Scheme != Uri.UriSchemeWss)
		{
			throw new ArgumentException(SR.GetString("net_WebSockets_Scheme"), "uri");
		}
		switch (Interlocked.CompareExchange(ref state, 1, 0))
		{
		case 3:
			throw new ObjectDisposedException(GetType().FullName);
		default:
			throw new InvalidOperationException(SR.GetString("net_WebSockets_AlreadyStarted"));
		case 0:
			options.SetToReadOnly();
			return ConnectAsyncCore(uri, cancellationToken);
		}
	}

	private async Task ConnectAsyncCore(Uri uri, CancellationToken cancellationToken)
	{
		HttpWebResponse response = null;
		CancellationTokenRegistration connectCancellation = default(CancellationTokenRegistration);
		try
		{
			HttpWebRequest request = CreateAndConfigureRequest(uri);
			if (Logging.On)
			{
				Logging.Associate(Logging.WebSockets, this, request);
			}
			connectCancellation = cancellationToken.Register(AbortRequest, request, useSynchronizationContext: false);
			response = (await request.GetResponseAsync().SuppressContextFlow()) as HttpWebResponse;
			if (Logging.On)
			{
				Logging.Associate(Logging.WebSockets, this, response);
			}
			string subProtocol = ValidateResponse(request, response);
			innerWebSocket = WebSocket.CreateClientWebSocket(response.GetResponseStream(), subProtocol, options.ReceiveBufferSize, options.SendBufferSize, options.KeepAliveInterval, useZeroMaskingKey: false, options.GetOrCreateBuffer());
			if (Logging.On)
			{
				Logging.Associate(Logging.WebSockets, this, innerWebSocket);
			}
			if (Interlocked.CompareExchange(ref state, 2, 1) != 1)
			{
				throw new ObjectDisposedException(GetType().FullName);
			}
		}
		catch (WebException innerException)
		{
			ConnectExceptionCleanup(response);
			WebSocketException ex = new WebSocketException(SR.GetString("net_webstatus_ConnectFailure"), innerException);
			if (Logging.On)
			{
				Logging.Exception(Logging.WebSockets, this, "ConnectAsync", ex);
			}
			throw ex;
		}
		catch (Exception e)
		{
			ConnectExceptionCleanup(response);
			if (Logging.On)
			{
				Logging.Exception(Logging.WebSockets, this, "ConnectAsync", e);
			}
			throw;
		}
		finally
		{
			connectCancellation.Dispose();
		}
	}

	private void ConnectExceptionCleanup(HttpWebResponse response)
	{
		Dispose();
		response?.Dispose();
	}

	private HttpWebRequest CreateAndConfigureRequest(Uri uri)
	{
		if (!(WebRequest.Create(uri) is HttpWebRequest httpWebRequest))
		{
			throw new InvalidOperationException(SR.GetString("net_WebSockets_InvalidRegistration"));
		}
		foreach (string key in options.RequestHeaders.Keys)
		{
			httpWebRequest.Headers.Add(key, options.RequestHeaders[key]);
		}
		if (options.RequestedSubProtocols.Count > 0)
		{
			httpWebRequest.Headers.Add("Sec-WebSocket-Protocol", string.Join(", ", options.RequestedSubProtocols));
		}
		if (options.UseDefaultCredentials)
		{
			httpWebRequest.UseDefaultCredentials = true;
		}
		else if (options.Credentials != null)
		{
			httpWebRequest.Credentials = options.Credentials;
		}
		if (options.InternalClientCertificates != null)
		{
			httpWebRequest.ClientCertificates = options.InternalClientCertificates;
		}
		httpWebRequest.Proxy = options.Proxy;
		httpWebRequest.CookieContainer = options.Cookies;
		cts.Token.Register(AbortRequest, httpWebRequest, useSynchronizationContext: false);
		return httpWebRequest;
	}

	private string ValidateResponse(HttpWebRequest request, HttpWebResponse response)
	{
		if (response.StatusCode != HttpStatusCode.SwitchingProtocols)
		{
			throw new WebSocketException(SR.GetString("net_WebSockets_Connect101Expected", (int)response.StatusCode));
		}
		string text = response.Headers["Upgrade"];
		if (!string.Equals(text, "websocket", StringComparison.OrdinalIgnoreCase))
		{
			throw new WebSocketException(SR.GetString("net_WebSockets_InvalidResponseHeader", "Upgrade", text));
		}
		string text2 = response.Headers["Connection"];
		if (!string.Equals(text2, "Upgrade", StringComparison.OrdinalIgnoreCase))
		{
			throw new WebSocketException(SR.GetString("net_WebSockets_InvalidResponseHeader", "Connection", text2));
		}
		string text3 = response.Headers["Sec-WebSocket-Accept"];
		string secWebSocketAcceptString = WebSocketHelpers.GetSecWebSocketAcceptString(request.Headers["Sec-WebSocket-Key"]);
		if (!string.Equals(text3, secWebSocketAcceptString, StringComparison.OrdinalIgnoreCase))
		{
			throw new WebSocketException(SR.GetString("net_WebSockets_InvalidResponseHeader", "Sec-WebSocket-Accept", text3));
		}
		string text4 = response.Headers["Sec-WebSocket-Protocol"];
		if (!string.IsNullOrWhiteSpace(text4) && options.RequestedSubProtocols.Count > 0)
		{
			bool flag = false;
			foreach (string requestedSubProtocol in options.RequestedSubProtocols)
			{
				if (string.Equals(requestedSubProtocol, text4, StringComparison.OrdinalIgnoreCase))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				throw new WebSocketException(SR.GetString("net_WebSockets_AcceptUnsupportedProtocol", string.Join(", ", options.RequestedSubProtocols), text4));
			}
		}
		if (!string.IsNullOrWhiteSpace(text4))
		{
			return text4;
		}
		return null;
	}

	public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
	{
		ThrowIfNotConnected();
		return innerWebSocket.SendAsync(buffer, messageType, endOfMessage, cancellationToken);
	}

	public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
	{
		ThrowIfNotConnected();
		return innerWebSocket.ReceiveAsync(buffer, cancellationToken);
	}

	public override Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
	{
		ThrowIfNotConnected();
		return innerWebSocket.CloseAsync(closeStatus, statusDescription, cancellationToken);
	}

	public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
	{
		ThrowIfNotConnected();
		return innerWebSocket.CloseOutputAsync(closeStatus, statusDescription, cancellationToken);
	}

	public override void Abort()
	{
		if (state != 3)
		{
			if (innerWebSocket != null)
			{
				innerWebSocket.Abort();
			}
			Dispose();
		}
	}

	private void AbortRequest(object obj)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)obj;
		httpWebRequest.Abort();
	}

	public override void Dispose()
	{
		int num = Interlocked.Exchange(ref state, 3);
		if (num != 3)
		{
			cts.Cancel(throwOnFirstException: false);
			cts.Dispose();
			if (innerWebSocket != null)
			{
				innerWebSocket.Dispose();
			}
		}
	}

	private void ThrowIfNotConnected()
	{
		if (state == 3)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (state != 2)
		{
			throw new InvalidOperationException(SR.GetString("net_WebSockets_NotConnected"));
		}
	}
}
