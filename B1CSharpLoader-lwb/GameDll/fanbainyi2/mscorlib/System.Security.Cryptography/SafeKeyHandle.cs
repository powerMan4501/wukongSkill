using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

[SecurityCritical]
internal sealed class SafeKeyHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeKeyHandle InvalidHandle => new SafeKeyHandle();

	private SafeKeyHandle()
		: base(ownsHandle: true)
	{
		SetHandle(IntPtr.Zero);
	}

	private SafeKeyHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	private static extern void FreeKey(IntPtr pKeyCotext);

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		FreeKey(handle);
		return true;
	}
}
