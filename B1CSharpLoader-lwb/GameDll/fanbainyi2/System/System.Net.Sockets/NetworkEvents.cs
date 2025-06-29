using System.Runtime.InteropServices;

namespace System.Net.Sockets;

internal struct NetworkEvents
{
	public AsyncEventBits Events;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
	public int[] ErrorCodes;
}
