using System.Runtime.InteropServices;

namespace System.Net;

internal struct IssuerListInfoEx
{
	public SafeHandle aIssuers;

	public uint cIssuers;

	public unsafe IssuerListInfoEx(SafeHandle handle, byte[] nativeBuffer)
	{
		aIssuers = handle;
		fixed (byte* ptr = nativeBuffer)
		{
			cIssuers = *(uint*)(ptr + IntPtr.Size);
		}
	}
}
