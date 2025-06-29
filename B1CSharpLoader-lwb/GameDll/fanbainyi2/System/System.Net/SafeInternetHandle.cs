using System.Runtime.ConstrainedExecution;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeInternetHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	public SafeInternetHandle()
		: base(ownsHandle: true)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	protected override bool ReleaseHandle()
	{
		return UnsafeNclNativeMethods.WinHttp.WinHttpCloseHandle(handle);
	}
}
