using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Net.WebSockets;

[Serializable]
public sealed class WebSocketException : Win32Exception
{
	private WebSocketError m_WebSocketErrorCode;

	public override int ErrorCode => base.NativeErrorCode;

	public WebSocketError WebSocketErrorCode => m_WebSocketErrorCode;

	public WebSocketException()
		: this(Marshal.GetLastWin32Error())
	{
	}

	public WebSocketException(WebSocketError error)
		: this(error, GetErrorMessage(error))
	{
	}

	public WebSocketException(WebSocketError error, string message)
		: base(message)
	{
		m_WebSocketErrorCode = error;
	}

	public WebSocketException(WebSocketError error, Exception innerException)
		: this(error, GetErrorMessage(error), innerException)
	{
	}

	public WebSocketException(WebSocketError error, string message, Exception innerException)
		: base(message, innerException)
	{
		m_WebSocketErrorCode = error;
	}

	public WebSocketException(int nativeError)
		: base(nativeError)
	{
		m_WebSocketErrorCode = ((!WebSocketProtocolComponent.Succeeded(nativeError)) ? WebSocketError.NativeError : WebSocketError.Success);
		SetErrorCodeOnError(nativeError);
	}

	public WebSocketException(int nativeError, string message)
		: base(nativeError, message)
	{
		m_WebSocketErrorCode = ((!WebSocketProtocolComponent.Succeeded(nativeError)) ? WebSocketError.NativeError : WebSocketError.Success);
		SetErrorCodeOnError(nativeError);
	}

	public WebSocketException(int nativeError, Exception innerException)
		: base(SR.GetString("net_WebSockets_Generic"), innerException)
	{
		m_WebSocketErrorCode = ((!WebSocketProtocolComponent.Succeeded(nativeError)) ? WebSocketError.NativeError : WebSocketError.Success);
		SetErrorCodeOnError(nativeError);
	}

	public WebSocketException(WebSocketError error, int nativeError)
		: this(error, nativeError, GetErrorMessage(error))
	{
	}

	public WebSocketException(WebSocketError error, int nativeError, string message)
		: base(message)
	{
		m_WebSocketErrorCode = error;
		SetErrorCodeOnError(nativeError);
	}

	public WebSocketException(WebSocketError error, int nativeError, Exception innerException)
		: this(error, nativeError, GetErrorMessage(error), innerException)
	{
	}

	public WebSocketException(WebSocketError error, int nativeError, string message, Exception innerException)
		: base(message, innerException)
	{
		m_WebSocketErrorCode = error;
		SetErrorCodeOnError(nativeError);
	}

	public WebSocketException(string message)
		: base(message)
	{
	}

	public WebSocketException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	private WebSocketException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
	}

	private static string GetErrorMessage(WebSocketError error)
	{
		return error switch
		{
			WebSocketError.InvalidMessageType => SR.GetString("net_WebSockets_InvalidMessageType_Generic", typeof(WebSocket).Name + "CloseAsync", typeof(WebSocket).Name + "CloseOutputAsync"), 
			WebSocketError.Faulted => SR.GetString("net_Websockets_WebSocketBaseFaulted"), 
			WebSocketError.NotAWebSocket => SR.GetString("net_WebSockets_NotAWebSocket_Generic"), 
			WebSocketError.UnsupportedVersion => SR.GetString("net_WebSockets_UnsupportedWebSocketVersion_Generic"), 
			WebSocketError.UnsupportedProtocol => SR.GetString("net_WebSockets_UnsupportedProtocol_Generic"), 
			WebSocketError.HeaderError => SR.GetString("net_WebSockets_HeaderError_Generic"), 
			WebSocketError.ConnectionClosedPrematurely => SR.GetString("net_WebSockets_ConnectionClosedPrematurely_Generic"), 
			WebSocketError.InvalidState => SR.GetString("net_WebSockets_InvalidState_Generic"), 
			_ => SR.GetString("net_WebSockets_Generic"), 
		};
	}

	[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("WebSocketErrorCode", m_WebSocketErrorCode);
		base.GetObjectData(info, context);
	}

	private void SetErrorCodeOnError(int nativeError)
	{
		if (!WebSocketProtocolComponent.Succeeded(nativeError))
		{
			base.HResult = nativeError;
		}
	}
}
