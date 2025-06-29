using System.Net.Sockets;

namespace System.Net.NetworkInformation;

internal class SystemIcmpV6Statistics : IcmpV6Statistics
{
	private MibIcmpInfoEx stats;

	public override long MessagesSent => stats.outStats.dwMsgs;

	public override long MessagesReceived => stats.inStats.dwMsgs;

	public override long ErrorsSent => stats.outStats.dwErrors;

	public override long ErrorsReceived => stats.inStats.dwErrors;

	public override long DestinationUnreachableMessagesSent => stats.outStats.rgdwTypeCount[1];

	public override long DestinationUnreachableMessagesReceived => stats.inStats.rgdwTypeCount[1];

	public override long PacketTooBigMessagesSent => stats.outStats.rgdwTypeCount[2];

	public override long PacketTooBigMessagesReceived => stats.inStats.rgdwTypeCount[2];

	public override long TimeExceededMessagesSent => stats.outStats.rgdwTypeCount[3];

	public override long TimeExceededMessagesReceived => stats.inStats.rgdwTypeCount[3];

	public override long ParameterProblemsSent => stats.outStats.rgdwTypeCount[4];

	public override long ParameterProblemsReceived => stats.inStats.rgdwTypeCount[4];

	public override long EchoRequestsSent => stats.outStats.rgdwTypeCount[128];

	public override long EchoRequestsReceived => stats.inStats.rgdwTypeCount[128];

	public override long EchoRepliesSent => stats.outStats.rgdwTypeCount[129];

	public override long EchoRepliesReceived => stats.inStats.rgdwTypeCount[129];

	public override long MembershipQueriesSent => stats.outStats.rgdwTypeCount[130];

	public override long MembershipQueriesReceived => stats.inStats.rgdwTypeCount[130];

	public override long MembershipReportsSent => stats.outStats.rgdwTypeCount[131];

	public override long MembershipReportsReceived => stats.inStats.rgdwTypeCount[131];

	public override long MembershipReductionsSent => stats.outStats.rgdwTypeCount[132];

	public override long MembershipReductionsReceived => stats.inStats.rgdwTypeCount[132];

	public override long RouterAdvertisementsSent => stats.outStats.rgdwTypeCount[134];

	public override long RouterAdvertisementsReceived => stats.inStats.rgdwTypeCount[134];

	public override long RouterSolicitsSent => stats.outStats.rgdwTypeCount[133];

	public override long RouterSolicitsReceived => stats.inStats.rgdwTypeCount[133];

	public override long NeighborAdvertisementsSent => stats.outStats.rgdwTypeCount[136];

	public override long NeighborAdvertisementsReceived => stats.inStats.rgdwTypeCount[136];

	public override long NeighborSolicitsSent => stats.outStats.rgdwTypeCount[135];

	public override long NeighborSolicitsReceived => stats.inStats.rgdwTypeCount[135];

	public override long RedirectsSent => stats.outStats.rgdwTypeCount[137];

	public override long RedirectsReceived => stats.inStats.rgdwTypeCount[137];

	internal SystemIcmpV6Statistics()
	{
		uint icmpStatisticsEx = UnsafeNetInfoNativeMethods.GetIcmpStatisticsEx(out stats, AddressFamily.InterNetworkV6);
		if (icmpStatisticsEx != 0)
		{
			throw new NetworkInformationException((int)icmpStatisticsEx);
		}
	}
}
