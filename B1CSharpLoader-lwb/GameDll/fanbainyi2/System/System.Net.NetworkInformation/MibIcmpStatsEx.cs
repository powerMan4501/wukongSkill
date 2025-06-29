using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

internal struct MibIcmpStatsEx
{
	internal uint dwMsgs;

	internal uint dwErrors;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
	internal uint[] rgdwTypeCount;
}
