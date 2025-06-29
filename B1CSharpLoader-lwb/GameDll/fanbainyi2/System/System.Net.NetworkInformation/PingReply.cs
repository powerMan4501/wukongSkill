using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

public class PingReply
{
	private IPAddress address;

	private PingOptions options;

	private IPStatus ipStatus;

	private long rtt;

	private byte[] buffer;

	public IPStatus Status => ipStatus;

	public IPAddress Address => address;

	public long RoundtripTime => rtt;

	public PingOptions Options => options;

	public byte[] Buffer => buffer;

	internal PingReply()
	{
	}

	internal PingReply(IPStatus ipStatus)
	{
		this.ipStatus = ipStatus;
		buffer = new byte[0];
	}

	internal PingReply(byte[] data, int dataLength, IPAddress address, int time)
	{
		this.address = address;
		rtt = time;
		ipStatus = GetIPStatus((IcmpV4Type)data[20], (IcmpV4Code)data[21]);
		if (ipStatus == IPStatus.Success)
		{
			buffer = new byte[dataLength - 28];
			Array.Copy(data, 28, buffer, 0, dataLength - 28);
		}
		else
		{
			buffer = new byte[0];
		}
	}

	internal PingReply(IcmpEchoReply reply)
	{
		address = new IPAddress(reply.address);
		ipStatus = (IPStatus)reply.status;
		if (ipStatus == IPStatus.Success)
		{
			rtt = reply.roundTripTime;
			buffer = new byte[reply.dataSize];
			Marshal.Copy(reply.data, buffer, 0, reply.dataSize);
			options = new PingOptions(reply.options);
		}
		else
		{
			buffer = new byte[0];
		}
	}

	internal PingReply(Icmp6EchoReply reply, IntPtr dataPtr, int sendSize)
	{
		address = new IPAddress(reply.Address.Address, reply.Address.ScopeID);
		ipStatus = (IPStatus)reply.Status;
		if (ipStatus == IPStatus.Success)
		{
			rtt = reply.RoundTripTime;
			buffer = new byte[sendSize];
			Marshal.Copy(IntPtrHelper.Add(dataPtr, 36), buffer, 0, sendSize);
		}
		else
		{
			buffer = new byte[0];
		}
	}

	private IPStatus GetIPStatus(IcmpV4Type type, IcmpV4Code code)
	{
		return type switch
		{
			IcmpV4Type.ICMP4_ECHO_REPLY => IPStatus.Success, 
			IcmpV4Type.ICMP4_SOURCE_QUENCH => IPStatus.SourceQuench, 
			IcmpV4Type.ICMP4_PARAM_PROB => IPStatus.ParameterProblem, 
			IcmpV4Type.ICMP4_TIME_EXCEEDED => IPStatus.TtlExpired, 
			IcmpV4Type.ICMP4_DST_UNREACH => code switch
			{
				IcmpV4Code.ICMP4_UNREACH_NET => IPStatus.DestinationNetworkUnreachable, 
				IcmpV4Code.ICMP4_UNREACH_HOST => IPStatus.DestinationHostUnreachable, 
				IcmpV4Code.ICMP4_UNREACH_PROTOCOL => IPStatus.DestinationProtocolUnreachable, 
				IcmpV4Code.ICMP4_UNREACH_PORT => IPStatus.DestinationPortUnreachable, 
				IcmpV4Code.ICMP4_UNREACH_FRAG_NEEDED => IPStatus.PacketTooBig, 
				_ => IPStatus.DestinationUnreachable, 
			}, 
			_ => IPStatus.Unknown, 
		};
	}
}
