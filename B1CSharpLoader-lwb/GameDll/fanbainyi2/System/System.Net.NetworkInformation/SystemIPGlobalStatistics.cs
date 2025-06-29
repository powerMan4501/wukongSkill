using System.Net.Sockets;

namespace System.Net.NetworkInformation;

internal class SystemIPGlobalStatistics : IPGlobalStatistics
{
	private MibIpStats stats;

	public override bool ForwardingEnabled => stats.forwardingEnabled;

	public override int DefaultTtl => (int)stats.defaultTtl;

	public override long ReceivedPackets => stats.packetsReceived;

	public override long ReceivedPacketsWithHeadersErrors => stats.receivedPacketsWithHeaderErrors;

	public override long ReceivedPacketsWithAddressErrors => stats.receivedPacketsWithAddressErrors;

	public override long ReceivedPacketsForwarded => stats.packetsForwarded;

	public override long ReceivedPacketsWithUnknownProtocol => stats.receivedPacketsWithUnknownProtocols;

	public override long ReceivedPacketsDiscarded => stats.receivedPacketsDiscarded;

	public override long ReceivedPacketsDelivered => stats.receivedPacketsDelivered;

	public override long OutputPacketRequests => stats.packetOutputRequests;

	public override long OutputPacketRoutingDiscards => stats.outputPacketRoutingDiscards;

	public override long OutputPacketsDiscarded => stats.outputPacketsDiscarded;

	public override long OutputPacketsWithNoRoute => stats.outputPacketsWithNoRoute;

	public override long PacketReassemblyTimeout => stats.packetReassemblyTimeout;

	public override long PacketReassembliesRequired => stats.packetsReassemblyRequired;

	public override long PacketsReassembled => stats.packetsReassembled;

	public override long PacketReassemblyFailures => stats.packetsReassemblyFailed;

	public override long PacketsFragmented => stats.packetsFragmented;

	public override long PacketFragmentFailures => stats.packetsFragmentFailed;

	public override int NumberOfInterfaces => (int)stats.interfaces;

	public override int NumberOfIPAddresses => (int)stats.ipAddresses;

	public override int NumberOfRoutes => (int)stats.routes;

	private SystemIPGlobalStatistics()
	{
	}

	internal SystemIPGlobalStatistics(AddressFamily family)
	{
		uint ipStatisticsEx = UnsafeNetInfoNativeMethods.GetIpStatisticsEx(out stats, family);
		if (ipStatisticsEx != 0)
		{
			throw new NetworkInformationException((int)ipStatisticsEx);
		}
	}
}
