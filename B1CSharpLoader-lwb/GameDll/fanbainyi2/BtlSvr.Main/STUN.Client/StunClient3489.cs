using System;
using System.Buffers;
using System.Net;
using System.Net.Sockets;
using STUN.Enums;
using STUN.Messages;
using STUN.Proxy;
using STUN.StunResult;
using STUN.Utils;

namespace STUN.Client;

public class StunClient3489 : IStunClient, IDisposable
{
	private readonly IPEndPoint _remoteEndPoint;

	private readonly IUdpProxy _proxy;

	public ClassicStunResult _state = new ClassicStunResult();

	public virtual IPEndPoint LocalEndPoint => (IPEndPoint)_proxy.Client.LocalEndPoint;

	public TimeSpan ReceiveTimeout { get; set; } = TimeSpan.FromSeconds(3.0);

	public ClassicStunResult State => _state;

	public StunClient3489(IPEndPoint server, IPEndPoint local, IUdpProxy proxy = null)
	{
		_proxy = proxy ?? new NoneUdpProxy(local);
		_remoteEndPoint = server;
		State.LocalEndPoint = local;
	}

	public void ConnectProxyAsync()
	{
		_proxy.ConnectAsync();
	}

	public void CloseProxyAsync()
	{
		_proxy.CloseAsync();
	}

	public void QueryAsync()
	{
		State.Reset();
		StunResponse stunResponse = Test1Async();
		if (stunResponse == null)
		{
			State.NatType = NatType.UdpBlocked;
			return;
		}
		State.LocalEndPoint = new IPEndPoint(stunResponse.LocalAddress, LocalEndPoint.Port);
		IPEndPoint mappedAddressAttribute = AttributeExtensions.GetMappedAddressAttribute(stunResponse.Message);
		IPEndPoint changedAddressAttribute = AttributeExtensions.GetChangedAddressAttribute(stunResponse.Message);
		State.PublicEndPoint = mappedAddressAttribute;
		if (mappedAddressAttribute == null || changedAddressAttribute == null || object.Equals(changedAddressAttribute.Address, stunResponse.Remote.Address) || changedAddressAttribute.Port == stunResponse.Remote.Port)
		{
			State.NatType = NatType.UnsupportedServer;
			return;
		}
		StunResponse stunResponse2 = Test2Async(changedAddressAttribute);
		IPEndPoint publicEndPoint = ((stunResponse2 != null) ? AttributeExtensions.GetMappedAddressAttribute(stunResponse2.Message) : null);
		if (stunResponse2 != null && (object.Equals(stunResponse.Remote.Address, stunResponse2.Remote.Address) || stunResponse.Remote.Port == stunResponse2.Remote.Port))
		{
			State.NatType = NatType.UnsupportedServer;
			State.PublicEndPoint = publicEndPoint;
			return;
		}
		if (object.Equals(mappedAddressAttribute.Address, stunResponse.LocalAddress) && mappedAddressAttribute.Port == LocalEndPoint.Port)
		{
			if (stunResponse2 == null)
			{
				State.NatType = NatType.SymmetricUdpFirewall;
				State.PublicEndPoint = mappedAddressAttribute;
			}
			else
			{
				State.NatType = NatType.OpenInternet;
				State.PublicEndPoint = publicEndPoint;
			}
			return;
		}
		if (stunResponse2 != null)
		{
			State.NatType = NatType.FullCone;
			State.PublicEndPoint = publicEndPoint;
			return;
		}
		StunResponse stunResponse3 = Test1_2Async(changedAddressAttribute);
		IPEndPoint iPEndPoint = ((stunResponse3 != null) ? AttributeExtensions.GetMappedAddressAttribute(stunResponse3.Message) : null);
		if (iPEndPoint == null)
		{
			State.NatType = NatType.Unknown;
			return;
		}
		if (!object.Equals(iPEndPoint, mappedAddressAttribute))
		{
			State.NatType = NatType.Symmetric;
			State.PublicEndPoint = iPEndPoint;
			return;
		}
		StunResponse stunResponse4 = Test3Async();
		if (stunResponse4 != null)
		{
			IPEndPoint mappedAddressAttribute2 = AttributeExtensions.GetMappedAddressAttribute(stunResponse4.Message);
			if (mappedAddressAttribute2 != null && object.Equals(stunResponse4.Remote.Address, stunResponse.Remote.Address) && stunResponse4.Remote.Port != stunResponse.Remote.Port)
			{
				State.NatType = NatType.RestrictedCone;
				State.PublicEndPoint = mappedAddressAttribute2;
				return;
			}
		}
		State.NatType = NatType.PortRestrictedCone;
		State.PublicEndPoint = iPEndPoint;
	}

	private StunResponse RequestAsync(StunMessage5389 sendMessage, IPEndPoint remote, IPEndPoint receive)
	{
		try
		{
			using IMemoryOwner<byte> memoryOwner = MemoryPool<byte>.Shared.Rent(65536);
			Memory<byte> memory = memoryOwner.Memory;
			int length = sendMessage.WriteTo(memory.Span);
			_proxy.SendToAsync(memory.Slice(0, length), SocketFlags.None, remote);
			SocketReceiveMessageFromResult socketReceiveMessageFromResult = _proxy.ReceiveMessageFromAsync(memory, SocketFlags.None, receive);
			StunMessage5389 stunMessage = new StunMessage5389();
			if (stunMessage.TryParse(memory.Span.Slice(0, socketReceiveMessageFromResult.ReceivedBytes)) && stunMessage.IsSameTransaction(sendMessage))
			{
				return new StunResponse(stunMessage, (IPEndPoint)socketReceiveMessageFromResult.RemoteEndPoint, socketReceiveMessageFromResult.PacketInformation.Address);
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	public virtual StunResponse Test1Async()
	{
		StunMessage5389 sendMessage = new StunMessage5389
		{
			StunMessageType = StunMessageType.BindingRequest,
			MagicCookie = 0u
		};
		return RequestAsync(sendMessage, _remoteEndPoint, _remoteEndPoint);
	}

	public virtual StunResponse Test2Async(IPEndPoint other)
	{
		StunMessage5389 stunMessage = new StunMessage5389();
		stunMessage.StunMessageType = StunMessageType.BindingRequest;
		stunMessage.MagicCookie = 0u;
		stunMessage.Attributes = new StunAttribute[1] { AttributeExtensions.BuildChangeRequest(changeIp: true, changePort: true) };
		StunMessage5389 sendMessage = stunMessage;
		return RequestAsync(sendMessage, _remoteEndPoint, other);
	}

	public virtual StunResponse Test1_2Async(IPEndPoint other)
	{
		StunMessage5389 sendMessage = new StunMessage5389
		{
			StunMessageType = StunMessageType.BindingRequest,
			MagicCookie = 0u
		};
		return RequestAsync(sendMessage, other, other);
	}

	public virtual StunResponse Test3Async()
	{
		StunMessage5389 stunMessage = new StunMessage5389();
		stunMessage.StunMessageType = StunMessageType.BindingRequest;
		stunMessage.MagicCookie = 0u;
		stunMessage.Attributes = new StunAttribute[1] { AttributeExtensions.BuildChangeRequest(changeIp: false, changePort: true) };
		StunMessage5389 sendMessage = stunMessage;
		return RequestAsync(sendMessage, _remoteEndPoint, _remoteEndPoint);
	}

	public void Dispose()
	{
		_proxy.Dispose();
	}
}
