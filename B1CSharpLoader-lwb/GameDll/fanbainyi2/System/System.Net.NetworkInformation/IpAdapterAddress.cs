using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

internal struct IpAdapterAddress
{
	internal uint length;

	internal AdapterAddressFlags flags;

	internal IntPtr next;

	internal IpSocketAddress address;

	internal static IPAddressCollection MarshalIpAddressCollection(IntPtr ptr)
	{
		IPAddressCollection iPAddressCollection = new IPAddressCollection();
		while (ptr != IntPtr.Zero)
		{
			IpAdapterAddress ipAdapterAddress = (IpAdapterAddress)Marshal.PtrToStructure(ptr, typeof(IpAdapterAddress));
			IPAddress iPAddress = ipAdapterAddress.address.MarshalIPAddress();
			iPAddressCollection.InternalAdd(iPAddress);
			ptr = ipAdapterAddress.next;
		}
		return iPAddressCollection;
	}

	internal static IPAddressInformationCollection MarshalIpAddressInformationCollection(IntPtr ptr)
	{
		IPAddressInformationCollection iPAddressInformationCollection = new IPAddressInformationCollection();
		while (ptr != IntPtr.Zero)
		{
			IpAdapterAddress ipAdapterAddress = (IpAdapterAddress)Marshal.PtrToStructure(ptr, typeof(IpAdapterAddress));
			IPAddress iPAddress = ipAdapterAddress.address.MarshalIPAddress();
			iPAddressInformationCollection.InternalAdd(new SystemIPAddressInformation(iPAddress, ipAdapterAddress.flags));
			ptr = ipAdapterAddress.next;
		}
		return iPAddressInformationCollection;
	}
}
