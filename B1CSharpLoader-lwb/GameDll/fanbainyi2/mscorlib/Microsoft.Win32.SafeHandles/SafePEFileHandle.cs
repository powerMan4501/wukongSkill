using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical]
internal sealed class SafePEFileHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafePEFileHandle()
		: base(ownsHandle: true)
	{
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	private static extern void ReleaseSafePEFileHandle(IntPtr peFile);

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		ReleaseSafePEFileHandle(handle);
		return true;
	}
}
