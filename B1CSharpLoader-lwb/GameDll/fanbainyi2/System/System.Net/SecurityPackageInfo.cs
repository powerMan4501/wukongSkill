using System.Runtime.InteropServices;

namespace System.Net;

internal struct SecurityPackageInfo
{
	internal int Capabilities;

	internal short Version;

	internal short RPCID;

	internal int MaxToken;

	internal IntPtr Name;

	internal IntPtr Comment;

	internal static readonly int Size = Marshal.SizeOf(typeof(SecurityPackageInfo));

	internal static readonly int NameOffest = (int)Marshal.OffsetOf(typeof(SecurityPackageInfo), "Name");
}
