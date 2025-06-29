using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

[SecurityCritical]
internal sealed class SafeProvHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal static SafeProvHandle InvalidHandle => new SafeProvHandle();

	private SafeProvHandle()
		: base(ownsHandle: true)
	{
		SetHandle(IntPtr.Zero);
	}

	private SafeProvHandle(IntPtr handle)
		: base(ownsHandle: true)
	{
		SetHandle(handle);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	private static extern void FreeCsp(IntPtr pProviderContext);

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		FreeCsp(handle);
		return true;
	}
}
