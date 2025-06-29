using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal sealed class SafeCertContextHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeCertContextHandle InvalidHandle
	{
		get
		{
			SafeCertContextHandle safeCertContextHandle = new SafeCertContextHandle(IntPtr.Zero);
			GC.SuppressFinalize(safeCertContextHandle);
			return safeCertContextHandle;
		}
	}

	private SafeCertContextHandle()
		: base(ownsHandle: true)
	{
	}

	internal SafeCertContextHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[DllImport("crypt32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern bool CertFreeCertificateContext(IntPtr pCertContext);

	protected override bool ReleaseHandle()
	{
		return CertFreeCertificateContext(handle);
	}
}
