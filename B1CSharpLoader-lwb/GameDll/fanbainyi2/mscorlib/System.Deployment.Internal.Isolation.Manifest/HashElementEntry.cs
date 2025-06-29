using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation.Manifest;

[StructLayout(LayoutKind.Sequential)]
internal class HashElementEntry : IDisposable
{
	public uint index;

	public byte Transform;

	[MarshalAs(UnmanagedType.SysInt)]
	public IntPtr TransformMetadata;

	public uint TransformMetadataSize;

	public byte DigestMethod;

	[MarshalAs(UnmanagedType.SysInt)]
	public IntPtr DigestValue;

	public uint DigestValueSize;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string Xml;

	~HashElementEntry()
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
		if (TransformMetadata != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(TransformMetadata);
			TransformMetadata = IntPtr.Zero;
		}
		if (DigestValue != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(DigestValue);
			DigestValue = IntPtr.Zero;
		}
		if (fDisposing)
		{
			GC.SuppressFinalize(this);
		}
	}
}
