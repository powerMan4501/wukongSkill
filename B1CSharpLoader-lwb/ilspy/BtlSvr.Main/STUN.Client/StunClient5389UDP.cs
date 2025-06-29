using System;
using System.Buffers;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using STUN.Enums;
using STUN.Messages;
using STUN.Proxy;
using STUN.StunResult;
using STUN.Utils;

namespace STUN.Client;

public class StunClient5389UDP : IStunClient, IDisposable
{
	private readonly IPEndPoint _remoteEndPoint;

	private readonly IUdpProxy _proxy;

	private StunResult5389 _state = new StunResult5389();

	public virtual IPEndPoint LocalEndPoint => (IPEndPoint)_proxy.Client.LocalEndPoint;

	public TimeSpan ReceiveTimeout { get; set; } = TimeSpan.FromSeconds(3.0);

	public StunResult5389 State
	{
		get
		{
			return _state;
		}
		set
		{
			_state = value;
		}
	}

	public StunClient5389UDP(IPEndPoint server, IPEndPoint local, IUdpProxy proxy = null)
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
		FilteringBehaviorTestBaseAsync();
		if (State.BindingTestResult != BindingTestResult.Success || State.FilteringBehavior == FilteringBehavior.UnsupportedServer)
		{
			return;
		}
		if (object.Equals(State.PublicEndPoint, State.LocalEndPoint))
		{
			State.MappingBehavior = MappingBehavior.Direct;
			return;
		}
		StunResult5389 result = MappingBehaviorTestBase2Async();
		if (State.MappingBehavior == MappingBehavior.Unknown)
		{
			MappingBehaviorTestBase3Async(result);
		}
	}

	public StunResult5389 BindingTestAsync()
	{
		return BindingTestBaseAsync(_remoteEndPoint);
	}

	public virtual StunResult5389 BindingTestBaseAsync(IPEndPoint remote)
	{
		StunResult5389 stunResult = new StunResult5389();
		StunMessage5389 sendMessage = new StunMessage5389
		{
			StunMessageType = StunMessageType.BindingRequest
		};
		StunResponse stunResponse = RequestAsync(sendMessage, remote, remote);
		IPEndPoint iPEndPoint = ((stunResponse != null) ? AttributeExtensions.GetXorMappedAddressAttribute(stunResponse.Message) : null);
		IPEndPoint otherEndPoint = ((stunResponse != null) ? AttributeExtensions.GetOtherAddressAttribute(stunResponse.Message) : null);
		if (stunResponse == null)
		{
			stunResult.BindingTestResult = BindingTestResult.Fail;
		}
		else if (iPEndPoint == null)
		{
			stunResult.BindingTestResult = BindingTestResult.UnsupportedServer;
		}
		else
		{
			stunResult.BindingTestResult = BindingTestResult.Success;
		}
		IPEndPoint localEndPoint = ((stunResponse == null) ? null : new IPEndPoint(stunResponse.LocalAddress, LocalEndPoint.Port));
		stunResult.LocalEndPoint = localEndPoint;
		stunResult.PublicEndPoint = iPEndPoint;
		stunResult.OtherEndPoint = otherEndPoint;
		return stunResult;
	}

	public void MappingBehaviorTestAsync()
	{
		State.Reset();
		StunResult5389 result = BindingTestAsync();
		State.Clone(result);
		if (State.BindingTestResult != BindingTestResult.Success)
		{
			return;
		}
		if (!HasValidOtherAddress(State.OtherEndPoint))
		{
			State.MappingBehavior = MappingBehavior.UnsupportedServer;
			return;
		}
		if (object.Equals(State.PublicEndPoint, State.LocalEndPoint))
		{
			State.MappingBehavior = MappingBehavior.Direct;
			return;
		}
		StunResult5389 result2 = MappingBehaviorTestBase2Async();
		if (State.MappingBehavior == MappingBehavior.Unknown)
		{
			MappingBehaviorTestBase3Async(result2);
		}
	}

	private StunResult5389 MappingBehaviorTestBase2Async()
	{
		StunResult5389 stunResult = BindingTestBaseAsync(new IPEndPoint(State.OtherEndPoint.Address, _remoteEndPoint.Port));
		if (stunResult.BindingTestResult != BindingTestResult.Success)
		{
			State.MappingBehavior = MappingBehavior.Fail;
		}
		else if (object.Equals(stunResult.PublicEndPoint, State.PublicEndPoint))
		{
			State.MappingBehavior = MappingBehavior.EndpointIndependent;
		}
		return stunResult;
	}

	private void MappingBehaviorTestBase3Async(StunResult5389 result2)
	{
		StunResult5389 stunResult = BindingTestBaseAsync(State.OtherEndPoint);
		if (stunResult.BindingTestResult != BindingTestResult.Success)
		{
			State.MappingBehavior = MappingBehavior.Fail;
		}
		else
		{
			State.MappingBehavior = (object.Equals(stunResult.PublicEndPoint, result2.PublicEndPoint) ? MappingBehavior.AddressDependent : MappingBehavior.AddressAndPortDependent);
		}
	}

	public void FilteringBehaviorTestAsync()
	{
		State.Reset();
		FilteringBehaviorTestBaseAsync();
	}

	private void FilteringBehaviorTestBaseAsync()
	{
		StunResult5389 result = BindingTestAsync();
		State.Clone(result);
		if (State.BindingTestResult != BindingTestResult.Success)
		{
			return;
		}
		if (!HasValidOtherAddress(State.OtherEndPoint))
		{
			State.FilteringBehavior = FilteringBehavior.UnsupportedServer;
			return;
		}
		StunResponse stunResponse = FilteringBehaviorTest2Async();
		if (stunResponse != null)
		{
			State.FilteringBehavior = ((!object.Equals(stunResponse.Remote, State.OtherEndPoint)) ? FilteringBehavior.UnsupportedServer : FilteringBehavior.EndpointIndependent);
			return;
		}
		StunResponse stunResponse2 = FilteringBehaviorTest3Async();
		if (stunResponse2 == null)
		{
			State.FilteringBehavior = FilteringBehavior.AddressAndPortDependent;
		}
		else if (object.Equals(stunResponse2.Remote.Address, _remoteEndPoint.Address) && stunResponse2.Remote.Port != _remoteEndPoint.Port)
		{
			State.FilteringBehavior = FilteringBehavior.AddressDependent;
		}
		else
		{
			State.FilteringBehavior = FilteringBehavior.UnsupportedServer;
		}
	}

	public virtual StunResponse FilteringBehaviorTest2Async()
	{
		StunMessage5389 stunMessage = new StunMessage5389();
		stunMessage.StunMessageType = StunMessageType.BindingRequest;
		stunMessage.Attributes = new StunAttribute[1] { AttributeExtensions.BuildChangeRequest(changeIp: true, changePort: true) };
		StunMessage5389 sendMessage = stunMessage;
		return RequestAsync(sendMessage, _remoteEndPoint, State.OtherEndPoint);
	}

	public virtual StunResponse FilteringBehaviorTest3Async()
	{
		StunMessage5389 stunMessage = new StunMessage5389();
		stunMessage.StunMessageType = StunMessageType.BindingRequest;
		stunMessage.Attributes = new StunAttribute[1] { AttributeExtensions.BuildChangeRequest(changeIp: false, changePort: true) };
		StunMessage5389 sendMessage = stunMessage;
		return RequestAsync(sendMessage, _remoteEndPoint, _remoteEndPoint);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool HasValidOtherAddress(IPEndPoint other)
	{
		if (other != null && !object.Equals(other.Address, _remoteEndPoint.Address))
		{
			return other.Port != _remoteEndPoint.Port;
		}
		return false;
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

	public void Dispose()
	{
		_proxy.Dispose();
	}
}
