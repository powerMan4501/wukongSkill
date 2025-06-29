using System.Runtime.InteropServices;

namespace System.Net;

internal struct ChainPolicyParameter
{
	public uint cbSize;

	public uint dwFlags;

	public unsafe SSL_EXTRA_CERT_CHAIN_POLICY_PARA* pvExtraPolicyPara;

	public static readonly uint StructSize = (uint)Marshal.SizeOf(typeof(ChainPolicyParameter));
}
