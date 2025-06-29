using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal sealed class SafeBCryptAlgorithmHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeBCryptAlgorithmHandle()
		: base(ownsHandle: true)
	{
	}

	[DllImport("bcrypt")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	private static extern BCryptNative.ErrorCode BCryptCloseAlgorithmProvider(IntPtr hAlgorithm, int flags);

	protected override bool ReleaseHandle()
	{
		return BCryptCloseAlgorithmProvider(handle, 0) == BCryptNative.ErrorCode.Success;
	}
}
