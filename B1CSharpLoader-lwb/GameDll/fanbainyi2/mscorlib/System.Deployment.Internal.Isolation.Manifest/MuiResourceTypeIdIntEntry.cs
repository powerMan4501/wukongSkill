using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation.Manifest;

[StructLayout(LayoutKind.Sequential)]
internal class MuiResourceTypeIdIntEntry : IDisposable
{
	[MarshalAs(UnmanagedType.SysInt)]
	public IntPtr StringIds;

	public uint StringIdsSize;

	[MarshalAs(UnmanagedType.SysInt)]
	public IntPtr IntegerIds;

	public uint IntegerIdsSize;

	~MuiResourceTypeIdIntEntry()
	{
		Dispose(fDisposing: false);
	}

	void IDisposable.Dispose()
	{
		Dispose(fDisposing: true);
	}

	[SecuritySafeCritical]
	public void Dispose(bool fDisposing)
	{
		if (StringIds != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(StringIds);
			StringIds = IntPtr.Zero;
		}
		if (IntegerIds != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(IntegerIds);
			IntegerIds = IntPtr.Zero;
		}
		if (fDisposing)
		{
			GC.SuppressFinalize(this);
		}
	}
}
