using System;
using System.Net;
using System.Net.Sockets;

namespace STUN.Proxy;

public interface IUdpProxy : IDisposable
{
	Socket Client { get; }

	void ConnectAsync();

	void CloseAsync();

	SocketReceiveMessageFromResult ReceiveMessageFromAsync(Memory<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint);

	int SendToAsync(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, EndPoint remoteEP);
}
