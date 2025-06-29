using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical]
public sealed class SafeX509ChainHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeX509ChainHandle InvalidHandle
	{
		get
		{
			SafeX509ChainHandle safeX509ChainHandle = new SafeX509ChainHandle(IntPtr.Zero);
			GC.SuppressFinalize(safeX509ChainHandle);
			return safeX509ChainHandle;
		}
	}

	private SafeX509ChainHandle()
		: base(ownsHandle: true)
	{
	}

	internal SafeX509ChainHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[DllImport("crypt32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern void CertFreeCertificateChain(IntPtr handle);

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		CertFreeCertificateChain(handle);
		return true;
	}
}
