using System.Net.Sockets;

namespace System.Net.NetworkInformation;

internal class SystemUdpStatistics : UdpStatistics
{
	private MibUdpStats stats;

	public override long DatagramsReceived => stats.datagramsReceived;

	public override long IncomingDatagramsDiscarded => stats.incomingDatagramsDiscarded;

	public override long IncomingDatagramsWithErrors => stats.incomingDatagramsWithErrors;

	public override long DatagramsSent => stats.datagramsSent;

	public override int UdpListeners => (int)stats.udpListeners;

	private SystemUdpStatistics()
	{
	}

	internal SystemUdpStatistics(AddressFamily family)
	{
		uint udpStatisticsEx = UnsafeNetInfoNativeMethods.GetUdpStatisticsEx(out stats, family);
		if (udpStatisticsEx != 0)
		{
			throw new NetworkInformationException((int)udpStatisticsEx);
		}
	}
}
