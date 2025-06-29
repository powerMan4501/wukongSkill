using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

[SecurityCritical]
internal sealed class SafeHashHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeHashHandle InvalidHandle => new SafeHashHandle();

	private SafeHashHandle()
		: base(ownsHandle: true)
	{
		SetHandle(IntPtr.Zero);
	}

	private SafeHashHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	private static extern void FreeHash(IntPtr pHashContext);

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		FreeHash(handle);
		return true;
	}
}
