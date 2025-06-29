using System.Runtime.InteropServices;

namespace System.Net;

internal struct ChainParameters
{
	public uint cbSize;

	public CertUsageMatch RequestedUsage;

	public CertUsageMatch RequestedIssuancePolicy;

	public uint UrlRetrievalTimeout;

	public int BoolCheckRevocationFreshnessTime;

	public uint RevocationFreshnessTime;

	public static readonly uint StructSize = (uint)Marshal.SizeOf(typeof(ChainParameters));
}
