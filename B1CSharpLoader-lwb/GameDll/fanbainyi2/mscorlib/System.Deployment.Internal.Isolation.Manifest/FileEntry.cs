using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation.Manifest;

[StructLayout(LayoutKind.Sequential)]
internal class FileEntry : IDisposable
{
	[MarshalAs(UnmanagedType.LPWStr)]
	public string Name;

	public uint HashAlgorithm;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string LoadFrom;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string SourcePath;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string ImportPath;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string SourceName;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string Location;

	[MarshalAs(UnmanagedType.SysInt)]
	public IntPtr HashValue;

	public uint HashValueSize;

	public ulong Size;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string Group;

	public uint Flags;

	public MuiResourceMapEntry MuiMapping;

	public uint WritableType;

	public ISection HashElements;

	~FileEntry()
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
		if (HashValue != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(HashValue);
			HashValue = IntPtr.Zero;
		}
		if (fDisposing)
		{
			if (MuiMapping != null)
			{
				MuiMapping.Dispose(fDisposing: true);
				MuiMapping = null;
			}
			GC.SuppressFinalize(this);
		}
	}
}
