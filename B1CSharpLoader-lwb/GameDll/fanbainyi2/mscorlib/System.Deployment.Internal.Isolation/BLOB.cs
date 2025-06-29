using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

internal struct BLOB : IDisposable
{
	[MarshalAs(UnmanagedType.U4)]
	public uint Size;

	[MarshalAs(UnmanagedType.SysInt)]
	public IntPtr BlobData;

	[SecuritySafeCritical]
	public void Dispose()
	{
		if (BlobData != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(BlobData);
			BlobData = IntPtr.Zero;
		}
	}
}
