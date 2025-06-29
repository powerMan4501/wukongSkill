using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates;

internal sealed class SafeCertContextHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeCertContextHandle InvalidHandle
	{
		[SecuritySafeCritical]
		get
		{
			SafeCertContextHandle safeCertContextHandle = new SafeCertContextHandle(IntPtr.Zero);
			GC.SuppressFinalize(safeCertContextHandle);
			return safeCertContextHandle;
		}
	}

	[SecuritySafeCritical]
	private SafeCertContextHandle()
		: base(ownsHandle: true)
	{
	}

	[SecuritySafeCritical]
	internal SafeCertContextHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[DllImport("crypt32.dll", SetLastError = true)]
	private static extern bool CertFreeCertificateContext(IntPtr pCertContext);

	[SecuritySafeCritical]
	protected override bool ReleaseHandle()
	{
		return CertFreeCertificateContext(handle);
	}
}
