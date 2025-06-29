using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net.NetworkInformation;

[SuppressUnmanagedCodeSecurity]
internal static class UnsafeNetInfoNativeMethods
{
	private const string IPHLPAPI = "iphlpapi.dll";

	[DllImport("iphlpapi.dll")]
	internal static extern uint GetAdaptersAddresses(AddressFamily family, uint flags, IntPtr pReserved, SafeLocalFree adapterAddresses, ref uint outBufLen);

	[DllImport("iphlpapi.dll")]
	internal static extern uint GetBestInterfaceEx(byte[] ipAddress, out int index);

	[DllImport("iphlpapi.dll")]
	internal static extern uint GetIfEntry2(ref MibIfRow2 pIfRow);

	[DllImport("iphlpapi.dll")]
	internal static extern uint GetIpStatisticsEx(out MibIpStats statistics, AddressFamily family);

	[DllImport("iphlpapi.dll")]
	internal static extern uint GetTcpStatisticsEx(out MibTcpStats statistics, AddressFamily family);

	[DllImport("iphlpapi.dll")]
	internal static extern uint GetUdpStatisticsEx(out MibUdpStats statistics, AddressFamily family);

	[DllImport("iphlpapi.dll")]
	internal static extern uint GetIcmpStatistics(out MibIcmpInfo statistics);

	[DllImport("iphlpapi.dll")]
	internal static extern uint GetIcmpStatisticsEx(out MibIcmpInfoEx statistics, AddressFamily family);

	[DllImport("iphlpapi.dll")]
	internal static extern uint GetTcpTable(SafeLocalFree pTcpTable, ref uint dwOutBufLen, bool order);

	[DllImport("iphlpapi.dll")]
	internal static extern uint GetExtendedTcpTable(SafeLocalFree pTcpTable, ref uint dwOutBufLen, bool order, uint IPVersion, TcpTableClass tableClass, uint reserved);

	[DllImport("iphlpapi.dll")]
	internal static extern uint GetUdpTable(SafeLocalFree pUdpTable, ref uint dwOutBufLen, bool order);

	[DllImport("iphlpapi.dll")]
	internal static extern uint GetExtendedUdpTable(SafeLocalFree pUdpTable, ref uint dwOutBufLen, bool order, uint IPVersion, UdpTableClass tableClass, uint reserved);

	[DllImport("iphlpapi.dll")]
	internal static extern uint GetNetworkParams(SafeLocalFree pFixedInfo, ref uint pOutBufLen);

	[DllImport("iphlpapi.dll")]
	internal static extern uint GetPerAdapterInfo(uint IfIndex, SafeLocalFree pPerAdapterInfo, ref uint pOutBufLen);

	[DllImport("iphlpapi.dll", SetLastError = true)]
	internal static extern SafeCloseIcmpHandle IcmpCreateFile();

	[DllImport("iphlpapi.dll", SetLastError = true)]
	internal static extern SafeCloseIcmpHandle Icmp6CreateFile();

	[DllImport("iphlpapi.dll", SetLastError = true)]
	internal static extern bool IcmpCloseHandle(IntPtr handle);

	[DllImport("iphlpapi.dll", SetLastError = true)]
	internal static extern uint IcmpSendEcho2(SafeCloseIcmpHandle icmpHandle, SafeWaitHandle Event, IntPtr apcRoutine, IntPtr apcContext, uint ipAddress, [In] SafeLocalFree data, ushort dataSize, ref IPOptions options, SafeLocalFree replyBuffer, uint replySize, uint timeout);

	[DllImport("iphlpapi.dll", SetLastError = true)]
	internal static extern uint IcmpSendEcho2(SafeCloseIcmpHandle icmpHandle, IntPtr Event, IntPtr apcRoutine, IntPtr apcContext, uint ipAddress, [In] SafeLocalFree data, ushort dataSize, ref IPOptions options, SafeLocalFree replyBuffer, uint replySize, uint timeout);

	[DllImport("iphlpapi.dll", SetLastError = true)]
	internal static extern uint Icmp6SendEcho2(SafeCloseIcmpHandle icmpHandle, SafeWaitHandle Event, IntPtr apcRoutine, IntPtr apcContext, byte[] sourceSocketAddress, byte[] destSocketAddress, [In] SafeLocalFree data, ushort dataSize, ref IPOptions options, SafeLocalFree replyBuffer, uint replySize, uint timeout);

	[DllImport("iphlpapi.dll", SetLastError = true)]
	internal static extern uint Icmp6SendEcho2(SafeCloseIcmpHandle icmpHandle, IntPtr Event, IntPtr apcRoutine, IntPtr apcContext, byte[] sourceSocketAddress, byte[] destSocketAddress, [In] SafeLocalFree data, ushort dataSize, ref IPOptions options, SafeLocalFree replyBuffer, uint replySize, uint timeout);

	[DllImport("iphlpapi.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern void FreeMibTable(IntPtr handle);

	[DllImport("iphlpapi.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static extern uint CancelMibChangeNotify2(IntPtr notificationHandle);

	[DllImport("iphlpapi.dll")]
	internal static extern uint NotifyStableUnicastIpAddressTable([In] AddressFamily addressFamily, out SafeFreeMibTable table, [In][MarshalAs(UnmanagedType.FunctionPtr)] StableUnicastIpAddressTableDelegate callback, [In] IntPtr context, out SafeCancelMibChangeNotify notificationHandle);
}
