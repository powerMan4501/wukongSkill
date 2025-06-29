using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Security;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class SecureStringMarshal
{
	[SecuritySafeCritical]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IntPtr SecureStringToCoTaskMemAnsi(SecureString s)
	{
		return Marshal.SecureStringToCoTaskMemAnsi(s);
	}

	[SecuritySafeCritical]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IntPtr SecureStringToGlobalAllocAnsi(SecureString s)
	{
		return Marshal.SecureStringToGlobalAllocAnsi(s);
	}

	[SecuritySafeCritical]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IntPtr SecureStringToCoTaskMemUnicode(SecureString s)
	{
		return Marshal.SecureStringToCoTaskMemUnicode(s);
	}

	[SecuritySafeCritical]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s)
	{
		return Marshal.SecureStringToGlobalAllocUnicode(s);
	}
}
