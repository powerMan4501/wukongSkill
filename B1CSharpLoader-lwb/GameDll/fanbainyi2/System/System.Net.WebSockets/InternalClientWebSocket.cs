using System.IO;
using System.Runtime.InteropServices;

namespace System.Net.WebSockets;

internal sealed class InternalClientWebSocket : WebSocketBase
{
	private readonly SafeHandle m_SessionHandle;

	private readonly WebSocketProtocolComponent.Property[] m_Properties;

	internal override SafeHandle SessionHandle => m_SessionHandle;

	public InternalClientWebSocket(Stream innerStream, string subProtocol, int receiveBufferSize, int sendBufferSize, TimeSpan keepAliveInterval, bool useZeroMaskingKey, ArraySegment<byte> internalBuffer)
		: base(innerStream, subProtocol, keepAliveInterval, WebSocketBuffer.CreateClientBuffer(internalBuffer, receiveBufferSize, sendBufferSize))
	{
		m_Properties = base.InternalBuffer.CreateProperties(useZeroMaskingKey);
		m_SessionHandle = CreateWebSocketHandle();
		if (m_SessionHandle == null || m_SessionHandle.IsInvalid)
		{
			WebSocketHelpers.ThrowPlatformNotSupportedException_WSPC();
		}
		StartKeepAliveTimer();
	}

	private SafeHandle CreateWebSocketHandle()
	{
		WebSocketProtocolComponent.WebSocketCreateClientHandle(m_Properties, out var webSocketHandle);
		return webSocketHandle;
	}
}
