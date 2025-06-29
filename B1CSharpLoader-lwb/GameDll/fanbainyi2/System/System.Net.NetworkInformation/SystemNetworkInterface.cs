using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

internal class SystemNetworkInterface : NetworkInterface
{
	private string name;

	private string id;

	private string description;

	private byte[] physicalAddress;

	private uint addressLength;

	private NetworkInterfaceType type;

	private OperationalStatus operStatus;

	private long speed;

	private uint index;

	private uint ipv6Index;

	private AdapterFlags adapterFlags;

	private SystemIPInterfaceProperties interfaceProperties;

	internal static int InternalLoopbackInterfaceIndex => GetBestInterfaceForAddress(IPAddress.Loopback);

	internal static int InternalIPv6LoopbackInterfaceIndex => GetBestInterfaceForAddress(IPAddress.IPv6Loopback);

	public override string Id => id;

	public override string Name => name;

	public override string Description => description;

	public override NetworkInterfaceType NetworkInterfaceType => type;

	public override OperationalStatus OperationalStatus => operStatus;

	public override long Speed => speed;

	public override bool IsReceiveOnly => (adapterFlags & AdapterFlags.ReceiveOnly) > (AdapterFlags)0;

	public override bool SupportsMulticast => (adapterFlags & AdapterFlags.NoMulticast) == 0;

	private static int GetBestInterfaceForAddress(IPAddress addr)
	{
		SocketAddress socketAddress = new SocketAddress(addr);
		int result;
		int bestInterfaceEx = (int)UnsafeNetInfoNativeMethods.GetBestInterfaceEx(socketAddress.m_Buffer, out result);
		if (bestInterfaceEx != 0)
		{
			throw new NetworkInformationException(bestInterfaceEx);
		}
		return result;
	}

	internal static bool InternalGetIsNetworkAvailable()
	{
		try
		{
			NetworkInterface[] networkInterfaces = GetNetworkInterfaces();
			NetworkInterface[] array = networkInterfaces;
			foreach (NetworkInterface networkInterface in array)
			{
				if (networkInterface.OperationalStatus == OperationalStatus.Up && networkInterface.NetworkInterfaceType != NetworkInterfaceType.Tunnel && networkInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback)
				{
					return true;
				}
			}
		}
		catch (NetworkInformationException e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.Web, "SystemNetworkInterface", "InternalGetIsNetworkAvailable", e);
			}
		}
		return false;
	}

	internal static NetworkInterface[] GetNetworkInterfaces()
	{
		AddressFamily family = AddressFamily.Unspecified;
		uint outBufLen = 0u;
		SafeLocalFree safeLocalFree = null;
		FixedInfo fixedInfo = SystemIPGlobalProperties.GetFixedInfo();
		List<SystemNetworkInterface> list = new List<SystemNetworkInterface>();
		GetAdaptersAddressesFlags flags = GetAdaptersAddressesFlags.IncludeWins | GetAdaptersAddressesFlags.IncludeGateways;
		uint adaptersAddresses = UnsafeNetInfoNativeMethods.GetAdaptersAddresses(family, (uint)flags, IntPtr.Zero, SafeLocalFree.Zero, ref outBufLen);
		while (true)
		{
			switch (adaptersAddresses)
			{
			case 111u:
				try
				{
					safeLocalFree = SafeLocalFree.LocalAlloc((int)outBufLen);
					adaptersAddresses = UnsafeNetInfoNativeMethods.GetAdaptersAddresses(family, (uint)flags, IntPtr.Zero, safeLocalFree, ref outBufLen);
					if (adaptersAddresses == 0)
					{
						IntPtr intPtr = safeLocalFree.DangerousGetHandle();
						while (intPtr != IntPtr.Zero)
						{
							IpAdapterAddresses ipAdapterAddresses = (IpAdapterAddresses)Marshal.PtrToStructure(intPtr, typeof(IpAdapterAddresses));
							list.Add(new SystemNetworkInterface(fixedInfo, ipAdapterAddresses));
							intPtr = ipAdapterAddresses.next;
						}
					}
				}
				finally
				{
					safeLocalFree?.Close();
					safeLocalFree = null;
				}
				break;
			case 87u:
			case 232u:
				return new SystemNetworkInterface[0];
			default:
				throw new NetworkInformationException((int)adaptersAddresses);
			case 0u:
				return list.ToArray();
			}
		}
	}

	internal SystemNetworkInterface(FixedInfo fixedInfo, IpAdapterAddresses ipAdapterAddresses)
	{
		id = ipAdapterAddresses.AdapterName;
		name = ipAdapterAddresses.friendlyName;
		description = ipAdapterAddresses.description;
		index = ipAdapterAddresses.index;
		physicalAddress = ipAdapterAddresses.address;
		addressLength = ipAdapterAddresses.addressLength;
		type = ipAdapterAddresses.type;
		operStatus = ipAdapterAddresses.operStatus;
		speed = (long)ipAdapterAddresses.receiveLinkSpeed;
		ipv6Index = ipAdapterAddresses.ipv6Index;
		adapterFlags = ipAdapterAddresses.flags;
		interfaceProperties = new SystemIPInterfaceProperties(fixedInfo, ipAdapterAddresses);
	}

	public override PhysicalAddress GetPhysicalAddress()
	{
		byte[] array = new byte[addressLength];
		Array.Copy(physicalAddress, array, addressLength);
		return new PhysicalAddress(array);
	}

	public override IPInterfaceProperties GetIPProperties()
	{
		return interfaceProperties;
	}

	public override IPv4InterfaceStatistics GetIPv4Statistics()
	{
		return new SystemIPv4InterfaceStatistics(index);
	}

	public override IPInterfaceStatistics GetIPStatistics()
	{
		return new SystemIPInterfaceStatistics(index);
	}

	public override bool Supports(NetworkInterfaceComponent networkInterfaceComponent)
	{
		if (networkInterfaceComponent == NetworkInterfaceComponent.IPv6 && (adapterFlags & AdapterFlags.IPv6Enabled) != 0)
		{
			return true;
		}
		if (networkInterfaceComponent == NetworkInterfaceComponent.IPv4 && (adapterFlags & AdapterFlags.IPv4Enabled) != 0)
		{
			return true;
		}
		return false;
	}
}
