using System;
using System.Net;
using System.Net.Sockets;

namespace STUN.Proxy;

public class NoneUdpProxy : IUdpProxy, IDisposable
{
	public Socket Client { get; }

	public NoneUdpProxy(IPEndPoint localEndPoint)
	{
		Client = new Socket(localEndPoint.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
		Client.ReceiveTimeout = 3000;
		Client.Bind(localEndPoint);
	}

	public void ConnectAsync()
	{
	}

	public void CloseAsync()
	{
	}

	public SocketReceiveMessageFromResult ReceiveMessageFromInner(Memory<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint)
	{
		int num = 1024;
		byte[] array = new byte[num];
		IPPacketInformation ipPacketInformation;
		int num2 = Client.ReceiveMessageFrom(array, 0, num, ref socketFlags, ref remoteEndPoint, out ipPacketInformation);
		new Span<byte>(array, 0, num2).CopyTo(buffer.Span);
		SocketReceiveMessageFromResult result = default(SocketReceiveMessageFromResult);
		result.ReceivedBytes = num2;
		result.PacketInformation = ipPacketInformation;
		result.RemoteEndPoint = remoteEndPoint;
		result.SocketFlags = socketFlags;
		return result;
	}

	public SocketReceiveMessageFromResult ReceiveMessageFromAsync(Memory<byte> buffer, SocketFlags socketFlags, EndPoint remoteEndPoint)
	{
		return ReceiveMessageFromInner(buffer, socketFlags, remoteEndPoint);
	}

	public int SendToInner(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, EndPoint remoteEP)
	{
		return Client.SendTo(buffer.ToArray(), socketFlags, remoteEP);
	}

	public int SendToAsync(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, EndPoint remoteEP)
	{
		return SendToInner(buffer, socketFlags, remoteEP);
	}

	public void Dispose()
	{
		Client.Dispose();
		GC.SuppressFinalize(this);
	}
}
