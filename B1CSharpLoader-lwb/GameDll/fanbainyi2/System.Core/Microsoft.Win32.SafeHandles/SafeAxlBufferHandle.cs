using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.SafeHandles;

[SecurityCritical(SecurityCriticalScope.Everything)]
internal sealed class SafeAxlBufferHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeAxlBufferHandle()
		: base(ownsHandle: true)
	{
	}

	[DllImport("kernel32")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	private static extern IntPtr GetProcessHeap();

	[DllImport("kernel32")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool HeapFree(IntPtr hHeap, int dwFlags, IntPtr lpMem);

	protected override bool ReleaseHandle()
	{
		HeapFree(GetProcessHeap(), 0, handle);
		return true;
	}
}
