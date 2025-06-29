using System.Runtime.InteropServices;

namespace System.Net;

internal struct ChainPolicyStatus
{
	public uint cbSize;

	public uint dwError;

	public uint lChainIndex;

	public uint lElementIndex;

	public unsafe void* pvExtraPolicyStatus;

	public static readonly uint StructSize = (uint)Marshal.SizeOf(typeof(ChainPolicyStatus));
}
