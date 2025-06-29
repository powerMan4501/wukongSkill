using System.Runtime.InteropServices;

namespace System.Net;

internal struct NegotiationInfo
{
	internal IntPtr PackageInfo;

	internal uint NegotiationState;

	internal static readonly int Size = Marshal.SizeOf(typeof(NegotiationInfo));

	internal static readonly int NegotiationStateOffest = (int)Marshal.OffsetOf(typeof(NegotiationInfo), "NegotiationState");
}
