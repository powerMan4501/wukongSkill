using System.Net.Sockets;

namespace System.Net.NetworkInformation;

internal class SystemTcpStatistics : TcpStatistics
{
	private MibTcpStats stats;

	public override long MinimumTransmissionTimeout => stats.minimumRetransmissionTimeOut;

	public override long MaximumTransmissionTimeout => stats.maximumRetransmissionTimeOut;

	public override long MaximumConnections => stats.maximumConnections;

	public override long ConnectionsInitiated => stats.activeOpens;

	public override long ConnectionsAccepted => stats.passiveOpens;

	public override long FailedConnectionAttempts => stats.failedConnectionAttempts;

	public override long ResetConnections => stats.resetConnections;

	public override long CurrentConnections => stats.currentConnections;

	public override long SegmentsReceived => stats.segmentsReceived;

	public override long SegmentsSent => stats.segmentsSent;

	public override long SegmentsResent => stats.segmentsResent;

	public override long ErrorsReceived => stats.errorsReceived;

	public override long ResetsSent => stats.segmentsSentWithReset;

	public override long CumulativeConnections => stats.cumulativeConnections;

	private SystemTcpStatistics()
	{
	}

	internal SystemTcpStatistics(AddressFamily family)
	{
		uint tcpStatisticsEx = UnsafeNetInfoNativeMethods.GetTcpStatisticsEx(out stats, family);
		if (tcpStatisticsEx != 0)
		{
			throw new NetworkInformationException((int)tcpStatisticsEx);
		}
	}
}
