using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

internal struct MibUdp6RowOwnerPid
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	internal byte[] localAddr;

	internal uint localScopeId;

	internal byte localPort1;

	internal byte localPort2;

	internal byte ignoreLocalPort3;

	internal byte ignoreLocalPort4;

	internal uint owningPid;
}
