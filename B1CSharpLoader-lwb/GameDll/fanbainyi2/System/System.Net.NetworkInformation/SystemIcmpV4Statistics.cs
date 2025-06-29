namespace System.Net.NetworkInformation;

internal class SystemIcmpV4Statistics : IcmpV4Statistics
{
	private MibIcmpInfo stats;

	public override long MessagesSent => stats.outStats.messages;

	public override long MessagesReceived => stats.inStats.messages;

	public override long ErrorsSent => stats.outStats.errors;

	public override long ErrorsReceived => stats.inStats.errors;

	public override long DestinationUnreachableMessagesSent => stats.outStats.destinationUnreachables;

	public override long DestinationUnreachableMessagesReceived => stats.inStats.destinationUnreachables;

	public override long TimeExceededMessagesSent => stats.outStats.timeExceeds;

	public override long TimeExceededMessagesReceived => stats.inStats.timeExceeds;

	public override long ParameterProblemsSent => stats.outStats.parameterProblems;

	public override long ParameterProblemsReceived => stats.inStats.parameterProblems;

	public override long SourceQuenchesSent => stats.outStats.sourceQuenches;

	public override long SourceQuenchesReceived => stats.inStats.sourceQuenches;

	public override long RedirectsSent => stats.outStats.redirects;

	public override long RedirectsReceived => stats.inStats.redirects;

	public override long EchoRequestsSent => stats.outStats.echoRequests;

	public override long EchoRequestsReceived => stats.inStats.echoRequests;

	public override long EchoRepliesSent => stats.outStats.echoReplies;

	public override long EchoRepliesReceived => stats.inStats.echoReplies;

	public override long TimestampRequestsSent => stats.outStats.timestampRequests;

	public override long TimestampRequestsReceived => stats.inStats.timestampRequests;

	public override long TimestampRepliesSent => stats.outStats.timestampReplies;

	public override long TimestampRepliesReceived => stats.inStats.timestampReplies;

	public override long AddressMaskRequestsSent => stats.outStats.addressMaskRequests;

	public override long AddressMaskRequestsReceived => stats.inStats.addressMaskRequests;

	public override long AddressMaskRepliesSent => stats.outStats.addressMaskReplies;

	public override long AddressMaskRepliesReceived => stats.inStats.addressMaskReplies;

	internal SystemIcmpV4Statistics()
	{
		uint icmpStatistics = UnsafeNetInfoNativeMethods.GetIcmpStatistics(out stats);
		if (icmpStatistics != 0)
		{
			throw new NetworkInformationException((int)icmpStatistics);
		}
	}
}
