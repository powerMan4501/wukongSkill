using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal struct MibIfRow2
{
	private const int GuidLength = 16;

	private const int IfMaxStringSize = 256;

	private const int IfMaxPhysAddressLength = 32;

	internal ulong interfaceLuid;

	internal uint interfaceIndex;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	internal byte[] interfaceGuid;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 257)]
	internal char[] alias;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 257)]
	internal char[] description;

	internal uint physicalAddressLength;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	internal byte[] physicalAddress;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	internal byte[] permanentPhysicalAddress;

	internal uint mtu;

	internal NetworkInterfaceType type;

	internal InterfaceTunnelType tunnelType;

	internal uint mediaType;

	internal uint physicalMediumType;

	internal uint accessType;

	internal uint directionType;

	internal byte interfaceAndOperStatusFlags;

	internal OperationalStatus operStatus;

	internal uint adminStatus;

	internal uint mediaConnectState;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	internal byte[] networkGuid;

	internal InterfaceConnectionType connectionType;

	internal ulong transmitLinkSpeed;

	internal ulong receiveLinkSpeed;

	internal ulong inOctets;

	internal ulong inUcastPkts;

	internal ulong inNUcastPkts;

	internal ulong inDiscards;

	internal ulong inErrors;

	internal ulong inUnknownProtos;

	internal ulong inUcastOctets;

	internal ulong inMulticastOctets;

	internal ulong inBroadcastOctets;

	internal ulong outOctets;

	internal ulong outUcastPkts;

	internal ulong outNUcastPkts;

	internal ulong outDiscards;

	internal ulong outErrors;

	internal ulong outUcastOctets;

	internal ulong outMulticastOctets;

	internal ulong outBroadcastOctets;

	internal ulong outQLen;
}
