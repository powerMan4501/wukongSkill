using System.Runtime.InteropServices;
using System.Text;

namespace System.Security.Cryptography;

internal class X509Utils
{
	[SecuritySafeCritical]
	internal static System.Security.Cryptography.SafeLocalAllocHandle StringToAnsiPtr(string s)
	{
		byte[] array = new byte[s.Length + 1];
		Encoding.ASCII.GetBytes(s, 0, s.Length, array, 0);
		System.Security.Cryptography.SafeLocalAllocHandle safeLocalAllocHandle = CapiNative.LocalAlloc(0u, new IntPtr(array.Length));
		Marshal.Copy(array, 0, safeLocalAllocHandle.DangerousGetHandle(), array.Length);
		return safeLocalAllocHandle;
	}
}
