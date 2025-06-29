using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

[SecurityCritical]
internal sealed class SafeCspKeyHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal SafeCspKeyHandle()
		: base(ownsHandle: true)
	{
	}

	[DllImport("advapi32")]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptDestroyKey(IntPtr hKey);

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		return CryptDestroyKey(handle);
	}
}
