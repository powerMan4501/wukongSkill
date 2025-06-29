using System.Diagnostics;
using System.Runtime.InteropServices;

namespace System.Net;

[StructLayout(LayoutKind.Sequential)]
internal class SecurityBufferDescriptor
{
	public readonly int Version;

	public readonly int Count;

	public unsafe void* UnmanagedPointer;

	public unsafe SecurityBufferDescriptor(int count)
	{
		Version = 0;
		Count = count;
		UnmanagedPointer = null;
	}

	[Conditional("TRAVE")]
	internal void DebugDump()
	{
	}
}
