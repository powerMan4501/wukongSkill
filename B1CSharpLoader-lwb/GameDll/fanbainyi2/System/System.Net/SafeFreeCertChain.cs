using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeFreeCertChain : SafeHandleZeroOrMinusOneIsInvalid
{
	internal SafeFreeCertChain(IntPtr handle)
		: base(ownsHandle: false)
	{
		SetHandle(handle);
	}

	internal SafeFreeCertChain(IntPtr handle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(handle);
	}

	public override string ToString()
	{
		return "0x" + DangerousGetHandle().ToString("x");
	}

	protected override bool ReleaseHandle()
	{
		UnsafeNclNativeMethods.SafeNetHandles.CertFreeCertificateChain(handle);
		return true;
	}
}
