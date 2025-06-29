using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeFreeCertChainList : SafeHandleZeroOrMinusOneIsInvalid
{
	internal SafeFreeCertChainList()
		: base(ownsHandle: true)
	{
	}

	public override string ToString()
	{
		return "0x" + DangerousGetHandle().ToString("x");
	}

	protected override bool ReleaseHandle()
	{
		UnsafeNclNativeMethods.SafeNetHandles.CertFreeCertificateChainList(handle);
		return true;
	}
}
