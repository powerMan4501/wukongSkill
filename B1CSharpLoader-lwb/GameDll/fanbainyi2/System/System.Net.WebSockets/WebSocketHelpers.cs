using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.WebSockets;

internal static class WebSocketHelpers
{
	internal static class MethodNames
	{
		internal const string AcceptWebSocketAsync = "AcceptWebSocketAsync";

		internal const string ValidateWebSocketHeaders = "ValidateWebSocketHeaders";
	}

	internal const string SecWebSocketKeyGuid = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";

	internal const string WebSocketUpgradeToken = "websocket";

	internal const int DefaultReceiveBufferSize = 16384;

	internal const int DefaultClientSendBufferSize = 16384;

	internal const int MaxControlFramePayloadLength = 123;

	internal const int ClientTcpCloseTimeout = 1000;

	private const int CloseStatusCodeAbort = 1006;

	private const int CloseStatusCodeFailedTLSHandshake = 1015;

	private const int InvalidCloseStatusCodesFrom = 0;

	private const int InvalidCloseStatusCodesTo = 999;

	private const string Separators = "()<>@,;:\\\"/[]?={} ";

	private static readonly ArraySegment<byte> s_EmptyPayload = new ArraySegment<byte>(new byte[0], 0, 0);

	private static readonly Random s_KeyGenerator = new Random();

	private static volatile bool s_HttpSysSupportsWebSockets = ComNetOS.IsWin8orLater;

	internal static ArraySegment<byte> EmptyPayload => s_EmptyPayload;

	internal static Task<HttpListenerWebSocketContext> AcceptWebSocketAsync(HttpListenerContext context, string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval, ArraySegment<byte> internalBuffer)
	{
		ValidateOptions(subProtocol, receiveBufferSize, 16, keepAliveInterval);
		ValidateArraySegment(internalBuffer, "internalBuffer");
		WebSocketBuffer.Validate(internalBuffer.Count, receiveBufferSize, 16, isServerBuffer: true);
		return AcceptWebSocketAsyncCore(context, subProtocol, receiveBufferSize, keepAliveInterval, internalBuffer);
	}

	private static async Task<HttpListenerWebSocketContext> AcceptWebSocketAsyncCore(HttpListenerContext context, string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval, ArraySegment<byte> internalBuffer)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.WebSockets, context, "AcceptWebSocketAsync", "");
		}
		try
		{
			HttpListenerResponse response = context.Response;
			HttpListenerRequest request = context.Request;
			ValidateWebSocketHeaders(context);
			string secWebSocketVersion = request.Headers["Sec-WebSocket-Version"];
			string origin = request.Headers["Origin"];
			List<string> secWebSocketProtocols = new List<string>();
			if (ProcessWebSocketProtocolHeader(request.Headers["Sec-WebSocket-Protocol"], subProtocol, out var acceptProtocol))
			{
				secWebSocketProtocols.Add(acceptProtocol);
				response.Headers.Add("Sec-WebSocket-Protocol", acceptProtocol);
			}
			string secWebSocketKey = request.Headers["Sec-WebSocket-Key"];
			string secWebSocketAcceptString = GetSecWebSocketAcceptString(secWebSocketKey);
			response.Headers.Add("Connection", "Upgrade");
			response.Headers.Add("Upgrade", "websocket");
			response.Headers.Add("Sec-WebSocket-Accept", secWebSocketAcceptString);
			response.StatusCode = 101;
			response.ComputeCoreHeaders();
			ulong num = SendWebSocketHeaders(response);
			if (num != 0L)
			{
				throw new WebSocketException((int)num, SR.GetString("net_WebSockets_NativeSendResponseHeaders", "AcceptWebSocketAsync", num));
			}
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.WebSockets, string.Format("{0} = {1}", "Origin", origin));
				Logging.PrintInfo(Logging.WebSockets, string.Format("{0} = {1}", "Sec-WebSocket-Version", secWebSocketVersion));
				Logging.PrintInfo(Logging.WebSockets, string.Format("{0} = {1}", "Sec-WebSocket-Key", secWebSocketKey));
				Logging.PrintInfo(Logging.WebSockets, string.Format("{0} = {1}", "Sec-WebSocket-Accept", secWebSocketAcceptString));
				Logging.PrintInfo(Logging.WebSockets, string.Format("Request  {0} = {1}", "Sec-WebSocket-Protocol", request.Headers["Sec-WebSocket-Protocol"]));
				Logging.PrintInfo(Logging.WebSockets, string.Format("Response {0} = {1}", "Sec-WebSocket-Protocol", acceptProtocol));
			}
			await response.OutputStream.FlushAsync().SuppressContextFlow();
			HttpResponseStream outputStream = response.OutputStream as HttpResponseStream;
			((HttpResponseStream)response.OutputStream).SwitchToOpaqueMode();
			HttpRequestStream httpRequestStream = new HttpRequestStream(context);
			httpRequestStream.SwitchToOpaqueMode();
			WebSocketHttpListenerDuplexStream innerStream = new WebSocketHttpListenerDuplexStream(httpRequestStream, outputStream, context);
			WebSocket webSocket = WebSocket.CreateServerWebSocket(innerStream, subProtocol, receiveBufferSize, keepAliveInterval, internalBuffer);
			HttpListenerWebSocketContext httpListenerWebSocketContext = new HttpListenerWebSocketContext(request.Url, request.Headers, request.Cookies, context.User, request.IsAuthenticated, request.IsLocal, request.IsSecureConnection, origin, secWebSocketProtocols.AsReadOnly(), secWebSocketVersion, secWebSocketKey, webSocket);
			if (Logging.On)
			{
				Logging.Associate(Logging.WebSockets, context, httpListenerWebSocketContext);
				Logging.Associate(Logging.WebSockets, httpListenerWebSocketContext, webSocket);
			}
			return httpListenerWebSocketContext;
		}
		catch (Exception e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.WebSockets, context, "AcceptWebSocketAsync", e);
			}
			throw;
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.WebSockets, context, "AcceptWebSocketAsync", "");
			}
		}
	}

	internal static string GetSecWebSocketAcceptString(string secWebSocketKey)
	{
		using SHA1 sHA = SHA1.Create();
		string s = secWebSocketKey + "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		return Convert.ToBase64String(sHA.ComputeHash(bytes));
	}

	internal static string GetTraceMsgForParameters(int offset, int count, CancellationToken cancellationToken)
	{
		return string.Format(CultureInfo.InvariantCulture, "offset: {0}, count: {1}, cancellationToken.CanBeCanceled: {2}", new object[3] { offset, count, cancellationToken.CanBeCanceled });
	}

	internal static bool ProcessWebSocketProtocolHeader(string clientSecWebSocketProtocol, string subProtocol, out string acceptProtocol)
	{
		acceptProtocol = string.Empty;
		if (string.IsNullOrEmpty(clientSecWebSocketProtocol))
		{
			if (subProtocol != null)
			{
				throw new WebSocketException(WebSocketError.UnsupportedProtocol, SR.GetString("net_WebSockets_ClientAcceptingNoProtocols", subProtocol));
			}
			return false;
		}
		if (subProtocol == null)
		{
			return true;
		}
		string[] array = clientSecWebSocketProtocol.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
		acceptProtocol = subProtocol;
		for (int i = 0; i < array.Length; i++)
		{
			string strB = array[i].Trim();
			if (string.Compare(acceptProtocol, strB, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
		}
		throw new WebSocketException(WebSocketError.UnsupportedProtocol, SR.GetString("net_WebSockets_AcceptUnsupportedProtocol", clientSecWebSocketProtocol, subProtocol));
	}

	internal static ConfiguredTaskAwaitable SuppressContextFlow(this Task task)
	{
		return task.ConfigureAwait(continueOnCapturedContext: false);
	}

	internal static ConfiguredTaskAwaitable<T> SuppressContextFlow<T>(this Task<T> task)
	{
		return task.ConfigureAwait(continueOnCapturedContext: false);
	}

	internal static void ValidateBuffer(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || count > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("count");
		}
	}

	private unsafe static ulong SendWebSocketHeaders(HttpListenerResponse response)
	{
		return response.SendHeaders(null, null, UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.HTTP_SEND_RESPONSE_FLAG_MORE_DATA | UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.HTTP_SEND_RESPONSE_FLAG_BUFFER_DATA | UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.HTTP_SEND_RESPONSE_FLAG_OPAQUE, isWebSocketHandshake: true);
	}

	private static void ValidateWebSocketHeaders(HttpListenerContext context)
	{
		EnsureHttpSysSupportsWebSockets();
		if (!context.Request.IsWebSocketRequest)
		{
			throw new WebSocketException(WebSocketError.NotAWebSocket, SR.GetString("net_WebSockets_AcceptNotAWebSocket", "ValidateWebSocketHeaders", "Connection", "Upgrade", "websocket", context.Request.Headers["Upgrade"]));
		}
		string text = context.Request.Headers["Sec-WebSocket-Version"];
		if (string.IsNullOrEmpty(text))
		{
			throw new WebSocketException(WebSocketError.HeaderError, SR.GetString("net_WebSockets_AcceptHeaderNotFound", "ValidateWebSocketHeaders", "Sec-WebSocket-Version"));
		}
		if (string.Compare(text, WebSocketProtocolComponent.SupportedVersion, StringComparison.OrdinalIgnoreCase) != 0)
		{
			throw new WebSocketException(WebSocketError.UnsupportedVersion, SR.GetString("net_WebSockets_AcceptUnsupportedWebSocketVersion", "ValidateWebSocketHeaders", text, WebSocketProtocolComponent.SupportedVersion));
		}
		if (string.IsNullOrWhiteSpace(context.Request.Headers["Sec-WebSocket-Key"]))
		{
			throw new WebSocketException(WebSocketError.HeaderError, SR.GetString("net_WebSockets_AcceptHeaderNotFound", "ValidateWebSocketHeaders", "Sec-WebSocket-Key"));
		}
	}

	internal static void PrepareWebRequest(ref HttpWebRequest request)
	{
		request.Connection = "Upgrade";
		request.Headers["Upgrade"] = "websocket";
		byte[] array = new byte[16];
		lock (s_KeyGenerator)
		{
			s_KeyGenerator.NextBytes(array);
		}
		request.Headers["Sec-WebSocket-Key"] = Convert.ToBase64String(array);
		if (WebSocketProtocolComponent.IsSupported)
		{
			request.Headers["Sec-WebSocket-Version"] = WebSocketProtocolComponent.SupportedVersion;
		}
	}

	internal static void ValidateSubprotocol(string subProtocol)
	{
		if (string.IsNullOrWhiteSpace(subProtocol))
		{
			throw new ArgumentException(SR.GetString("net_WebSockets_InvalidEmptySubProtocol"), "subProtocol");
		}
		char[] array = subProtocol.ToCharArray();
		string text = null;
		for (int i = 0; i < array.Length; i++)
		{
			char c = array[i];
			if (c < '!' || c > '~')
			{
				text = string.Format(CultureInfo.InvariantCulture, "[{0}]", new object[1] { (int)c });
				break;
			}
			if (!char.IsLetterOrDigit(c) && "()<>@,;:\\\"/[]?={} ".IndexOf(c) >= 0)
			{
				text = c.ToString();
				break;
			}
		}
		if (text != null)
		{
			throw new ArgumentException(SR.GetString("net_WebSockets_InvalidCharInProtocolString", subProtocol, text), "subProtocol");
		}
	}

	internal static void ValidateCloseStatus(WebSocketCloseStatus closeStatus, string statusDescription)
	{
		if (closeStatus == WebSocketCloseStatus.Empty && !string.IsNullOrEmpty(statusDescription))
		{
			throw new ArgumentException(SR.GetString("net_WebSockets_ReasonNotNull", statusDescription, WebSocketCloseStatus.Empty), "statusDescription");
		}
		if ((closeStatus >= (WebSocketCloseStatus)0 && closeStatus <= (WebSocketCloseStatus)999) || closeStatus == (WebSocketCloseStatus)1006 || closeStatus == (WebSocketCloseStatus)1015)
		{
			throw new ArgumentException(SR.GetString("net_WebSockets_InvalidCloseStatusCode", (int)closeStatus), "closeStatus");
		}
		int num = 0;
		if (!string.IsNullOrEmpty(statusDescription))
		{
			num = Encoding.UTF8.GetByteCount(statusDescription);
		}
		if (num > 123)
		{
			throw new ArgumentException(SR.GetString("net_WebSockets_InvalidCloseStatusDescription", statusDescription, 123), "statusDescription");
		}
	}

	internal static void ValidateOptions(string subProtocol, int receiveBufferSize, int sendBufferSize, TimeSpan keepAliveInterval)
	{
		if (subProtocol != null)
		{
			ValidateSubprotocol(subProtocol);
		}
		ValidateBufferSizes(receiveBufferSize, sendBufferSize);
		if (keepAliveInterval < Timeout.InfiniteTimeSpan)
		{
			throw new ArgumentOutOfRangeException("keepAliveInterval", keepAliveInterval, SR.GetString("net_WebSockets_ArgumentOutOfRange_TooSmall", Timeout.InfiniteTimeSpan.ToString()));
		}
	}

	internal static void ValidateBufferSizes(int receiveBufferSize, int sendBufferSize)
	{
		if (receiveBufferSize < 256)
		{
			throw new ArgumentOutOfRangeException("receiveBufferSize", receiveBufferSize, SR.GetString("net_WebSockets_ArgumentOutOfRange_TooSmall", 256));
		}
		if (sendBufferSize < 16)
		{
			throw new ArgumentOutOfRangeException("sendBufferSize", sendBufferSize, SR.GetString("net_WebSockets_ArgumentOutOfRange_TooSmall", 16));
		}
		if (receiveBufferSize > 65536)
		{
			throw new ArgumentOutOfRangeException("receiveBufferSize", receiveBufferSize, SR.GetString("net_WebSockets_ArgumentOutOfRange_TooBig", "receiveBufferSize", receiveBufferSize, 65536));
		}
		if (sendBufferSize > 65536)
		{
			throw new ArgumentOutOfRangeException("sendBufferSize", sendBufferSize, SR.GetString("net_WebSockets_ArgumentOutOfRange_TooBig", "sendBufferSize", sendBufferSize, 65536));
		}
	}

	internal static void ValidateInnerStream(Stream innerStream)
	{
		if (innerStream == null)
		{
			throw new ArgumentNullException("innerStream");
		}
		if (!innerStream.CanRead)
		{
			throw new ArgumentException(SR.GetString("NotReadableStream"), "innerStream");
		}
		if (!innerStream.CanWrite)
		{
			throw new ArgumentException(SR.GetString("NotWriteableStream"), "innerStream");
		}
	}

	internal static void ThrowIfConnectionAborted(Stream connection, bool read)
	{
		if ((!read && !connection.CanWrite) || (read && !connection.CanRead))
		{
			throw new WebSocketException(WebSocketError.ConnectionClosedPrematurely);
		}
	}

	internal static void ThrowPlatformNotSupportedException_WSPC()
	{
		throw new PlatformNotSupportedException(SR.GetString("net_WebSockets_UnsupportedPlatform"));
	}

	private static void ThrowPlatformNotSupportedException_HTTPSYS()
	{
		throw new PlatformNotSupportedException(SR.GetString("net_WebSockets_UnsupportedPlatform"));
	}

	internal static void ValidateArraySegment<T>(ArraySegment<T> arraySegment, string parameterName)
	{
		if (arraySegment.Array == null)
		{
			throw new ArgumentNullException(parameterName + ".Array");
		}
		if (arraySegment.Offset < 0 || arraySegment.Offset > arraySegment.Array.Length)
		{
			throw new ArgumentOutOfRangeException(parameterName + ".Offset");
		}
		if (arraySegment.Count < 0 || arraySegment.Count > arraySegment.Array.Length - arraySegment.Offset)
		{
			throw new ArgumentOutOfRangeException(parameterName + ".Count");
		}
	}

	private static void EnsureHttpSysSupportsWebSockets()
	{
		if (!s_HttpSysSupportsWebSockets)
		{
			ThrowPlatformNotSupportedException_HTTPSYS();
		}
	}
}
