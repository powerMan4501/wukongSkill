using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;

namespace Microsoft.Win32.SafeHandles;

[SecuritySafeCritical]
internal sealed class SafeBCryptKeyHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal SafeBCryptKeyHandle()
		: base(ownsHandle: true)
	{
	}

	[DllImport("bcrypt.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	internal static extern BCryptNative.ErrorCode BCryptDestroyKey(IntPtr hKey);

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	protected override bool ReleaseHandle()
	{
		return BCryptDestroyKey(handle) == BCryptNative.ErrorCode.Success;
	}
}
