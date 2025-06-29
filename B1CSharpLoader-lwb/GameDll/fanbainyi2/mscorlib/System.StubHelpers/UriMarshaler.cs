using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.StubHelpers;

[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
internal static class UriMarshaler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	internal static extern string GetRawUriFromNative(IntPtr pUri);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal unsafe static extern IntPtr CreateNativeUriInstanceHelper(char* rawUri, int strLen);

	[SecurityCritical]
	internal unsafe static IntPtr CreateNativeUriInstance(string rawUri)
	{
		fixed (char* rawUri2 = rawUri)
		{
			return CreateNativeUriInstanceHelper(rawUri2, rawUri.Length);
		}
	}
}
