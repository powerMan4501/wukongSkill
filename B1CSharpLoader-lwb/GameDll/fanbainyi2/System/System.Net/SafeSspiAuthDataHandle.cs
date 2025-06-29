using System.Runtime.ConstrainedExecution;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeSspiAuthDataHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	public SafeSspiAuthDataHandle()
		: base(ownsHandle: true)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	protected override bool ReleaseHandle()
	{
		return UnsafeNclNativeMethods.SspiHelper.SspiFreeAuthIdentity(handle) == SecurityStatus.OK;
	}
}
