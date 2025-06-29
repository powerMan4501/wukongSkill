using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeFreeAddrInfo : SafeHandleZeroOrMinusOneIsInvalid
{
	private const string WS2_32 = "ws2_32.dll";

	private SafeFreeAddrInfo()
		: base(ownsHandle: true)
	{
	}

	internal static int GetAddrInfo(string nodename, string servicename, ref AddressInfo hints, out SafeFreeAddrInfo outAddrInfo)
	{
		return UnsafeNclNativeMethods.SafeNetHandlesXPOrLater.GetAddrInfoW(nodename, servicename, ref hints, out outAddrInfo);
	}

	protected override bool ReleaseHandle()
	{
		UnsafeNclNativeMethods.SafeNetHandlesXPOrLater.freeaddrinfo(handle);
		return true;
	}
}
