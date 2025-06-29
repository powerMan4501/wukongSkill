namespace System.Net.NetworkInformation;

[global::__DynamicallyInvokable]
public abstract class IPGlobalStatistics
{
	[global::__DynamicallyInvokable]
	public abstract int DefaultTtl
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract bool ForwardingEnabled
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract int NumberOfInterfaces
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract int NumberOfIPAddresses
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long OutputPacketRequests
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long OutputPacketRoutingDiscards
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long OutputPacketsDiscarded
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long OutputPacketsWithNoRoute
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long PacketFragmentFailures
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long PacketReassembliesRequired
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long PacketReassemblyFailures
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long PacketReassemblyTimeout
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long PacketsFragmented
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long PacketsReassembled
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long ReceivedPackets
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long ReceivedPacketsDelivered
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long ReceivedPacketsDiscarded
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long ReceivedPacketsForwarded
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long ReceivedPacketsWithAddressErrors
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long ReceivedPacketsWithHeadersErrors
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract long ReceivedPacketsWithUnknownProtocol
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	public abstract int NumberOfRoutes
	{
		[global::__DynamicallyInvokable]
		get;
	}

	[global::__DynamicallyInvokable]
	protected IPGlobalStatistics()
	{
	}
}
