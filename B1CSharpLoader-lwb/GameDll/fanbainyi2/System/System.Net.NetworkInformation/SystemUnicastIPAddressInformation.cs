using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

internal class SystemUnicastIPAddressInformation : UnicastIPAddressInformation
{
	private long dhcpLeaseLifetime;

	private SystemIPAddressInformation innerInfo;

	private IPAddress ipv4Mask;

	private PrefixOrigin prefixOrigin;

	private SuffixOrigin suffixOrigin;

	private DuplicateAddressDetectionState dadState;

	private uint validLifetime;

	private uint preferredLifetime;

	private byte prefixLength;

	public override IPAddress Address => innerInfo.Address;

	public override IPAddress IPv4Mask
	{
		get
		{
			if (Address.AddressFamily != AddressFamily.InterNetwork)
			{
				return IPAddress.Any;
			}
			return ipv4Mask;
		}
	}

	public override int PrefixLength => prefixLength;

	public override bool IsTransient => innerInfo.IsTransient;

	public override bool IsDnsEligible => innerInfo.IsDnsEligible;

	public override PrefixOrigin PrefixOrigin => prefixOrigin;

	public override SuffixOrigin SuffixOrigin => suffixOrigin;

	public override DuplicateAddressDetectionState DuplicateAddressDetectionState => dadState;

	public override long AddressValidLifetime => validLifetime;

	public override long AddressPreferredLifetime => preferredLifetime;

	public override long DhcpLeaseLifetime => dhcpLeaseLifetime;

	internal SystemUnicastIPAddressInformation(IpAdapterUnicastAddress adapterAddress)
	{
		IPAddress iPAddress = adapterAddress.address.MarshalIPAddress();
		innerInfo = new SystemIPAddressInformation(iPAddress, adapterAddress.flags);
		prefixOrigin = adapterAddress.prefixOrigin;
		suffixOrigin = adapterAddress.suffixOrigin;
		dadState = adapterAddress.dadState;
		validLifetime = adapterAddress.validLifetime;
		preferredLifetime = adapterAddress.preferredLifetime;
		dhcpLeaseLifetime = adapterAddress.leaseLifetime;
		prefixLength = adapterAddress.prefixLength;
		if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
		{
			ipv4Mask = PrefixLengthToSubnetMask(prefixLength, iPAddress.AddressFamily);
		}
	}

	internal static UnicastIPAddressInformationCollection MarshalUnicastIpAddressInformationCollection(IntPtr ptr)
	{
		UnicastIPAddressInformationCollection unicastIPAddressInformationCollection = new UnicastIPAddressInformationCollection();
		while (ptr != IntPtr.Zero)
		{
			IpAdapterUnicastAddress adapterAddress = (IpAdapterUnicastAddress)Marshal.PtrToStructure(ptr, typeof(IpAdapterUnicastAddress));
			unicastIPAddressInformationCollection.InternalAdd(new SystemUnicastIPAddressInformation(adapterAddress));
			ptr = adapterAddress.next;
		}
		return unicastIPAddressInformationCollection;
	}

	private static IPAddress PrefixLengthToSubnetMask(byte prefixLength, AddressFamily family)
	{
		byte[] array = ((family != AddressFamily.InterNetwork) ? new byte[16] : new byte[4]);
		for (int i = 0; i < prefixLength; i++)
		{
			array[i / 8] |= (byte)(128 >> i % 8);
		}
		return new IPAddress(array);
	}
}
