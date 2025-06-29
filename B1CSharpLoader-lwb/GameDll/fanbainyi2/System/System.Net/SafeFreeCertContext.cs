using System.Runtime.ConstrainedExecution;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Net;

[SuppressUnmanagedCodeSecurity]
internal sealed class SafeFreeCertContext : SafeHandleZeroOrMinusOneIsInvalid
{
	private const string CRYPT32 = "crypt32.dll";

	private const string ADVAPI32 = "advapi32.dll";

	private const uint CRYPT_ACQUIRE_SILENT_FLAG = 64u;

	internal SafeFreeCertContext()
		: base(ownsHandle: true)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal void Set(IntPtr value)
	{
		handle = value;
	}

	protected override bool ReleaseHandle()
	{
		UnsafeNclNativeMethods.SafeNetHandles.CertFreeCertificateContext(handle);
		return true;
	}
}
