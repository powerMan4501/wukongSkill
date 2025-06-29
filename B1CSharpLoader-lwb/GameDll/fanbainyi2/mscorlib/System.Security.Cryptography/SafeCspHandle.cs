using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

[SecurityCritical]
internal sealed class SafeCspHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeCspHandle()
		: base(ownsHandle: true)
	{
	}

	[DllImport("advapi32")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptReleaseContext(IntPtr hProv, int dwFlags);

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		return CryptReleaseContext(handle, 0);
	}
}
