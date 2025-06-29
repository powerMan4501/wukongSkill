using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeCloseIcmpHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeCloseIcmpHandle()
		: base(ownsHandle: true)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	protected override bool ReleaseHandle()
	{
		return UnsafeNetInfoNativeMethods.IcmpCloseHandle(handle);
	}
}
