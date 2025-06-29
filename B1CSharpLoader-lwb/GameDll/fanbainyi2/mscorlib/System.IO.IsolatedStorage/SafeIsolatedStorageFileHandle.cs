using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.IO.IsolatedStorage;

[SecurityCritical]
internal sealed class SafeIsolatedStorageFileHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern void Close(IntPtr file);

	private SafeIsolatedStorageFileHandle()
		: base(ownsHandle: true)
	{
		SetHandle(IntPtr.Zero);
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		Close(handle);
		return true;
	}
}
