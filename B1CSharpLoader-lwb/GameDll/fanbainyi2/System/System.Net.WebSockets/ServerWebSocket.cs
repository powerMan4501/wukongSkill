using System.IO;
using System.Runtime.InteropServices;

namespace System.Net.WebSockets;

internal sealed class ServerWebSocket : WebSocketBase
{
	private readonly SafeHandle m_SessionHandle;

	private readonly WebSocketProtocolComponent.Property[] m_Properties;

	internal override SafeHandle SessionHandle => m_SessionHandle;

	public ServerWebSocket(Stream innerStream, string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval, ArraySegment<byte> internalBuffer)
		: base(innerStream, subProtocol, keepAliveInterval, WebSocketBuffer.CreateServerBuffer(internalBuffer, receiveBufferSize))
	{
		m_Properties = base.InternalBuffer.CreateProperties(useZeroMaskingKey: false);
		m_SessionHandle = CreateWebSocketHandle();
		if (m_SessionHandle == null || m_SessionHandle.IsInvalid)
		{
			WebSocketHelpers.ThrowPlatformNotSupportedException_WSPC();
		}
		StartKeepAliveTimer();
	}

	private SafeHandle CreateWebSocketHandle()
	{
		WebSocketProtocolComponent.WebSocketCreateServerHandle(m_Properties, m_Properties.Length, out var webSocketHandle);
		return webSocketHandle;
	}
}
