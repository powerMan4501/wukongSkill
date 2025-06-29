using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation.Manifest;

[StructLayout(LayoutKind.Sequential)]
internal class AssemblyReferenceDependentAssemblyEntry : IDisposable
{
	[MarshalAs(UnmanagedType.LPWStr)]
	public string Group;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string Codebase;

	public ulong Size;

	[MarshalAs(UnmanagedType.SysInt)]
	public IntPtr HashValue;

	public uint HashValueSize;

	public uint HashAlgorithm;

	public uint Flags;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string ResourceFallbackCulture;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string Description;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string SupportUrl;

	public ISection HashElements;

	~AssemblyReferenceDependentAssemblyEntry()
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
			GC.SuppressFinalize(this);
		}
	}
}
