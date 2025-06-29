namespace System.Net.NetworkInformation;

internal class SystemIPv4InterfaceStatistics : IPv4InterfaceStatistics
{
	private MibIfRow2 ifRow;

	public override long OutputQueueLength => (long)ifRow.outQLen;

	public override long BytesSent => (long)ifRow.outOctets;

	public override long BytesReceived => (long)ifRow.inOctets;

	public override long UnicastPacketsSent => (long)ifRow.outUcastPkts;

	public override long UnicastPacketsReceived => (long)ifRow.inUcastPkts;

	public override long NonUnicastPacketsSent => (long)ifRow.outNUcastPkts;

	public override long NonUnicastPacketsReceived => (long)ifRow.inNUcastPkts;

	public override long IncomingPacketsDiscarded => (long)ifRow.inDiscards;

	public override long OutgoingPacketsDiscarded => (long)ifRow.outDiscards;

	public override long IncomingPacketsWithErrors => (long)ifRow.inErrors;

	public override long OutgoingPacketsWithErrors => (long)ifRow.outErrors;

	public override long IncomingUnknownProtocolPackets => (long)ifRow.inUnknownProtos;

	internal SystemIPv4InterfaceStatistics(long index)
	{
		ifRow = SystemIPInterfaceStatistics.GetIfEntry2(index);
	}
}
