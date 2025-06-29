using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.StubHelpers;

[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
internal static class HResultExceptionMarshaler
{
	internal static int ConvertToNative(Exception ex)
	{
		if (!Environment.IsWinRTSupported)
		{
			throw new PlatformNotSupportedException(Environment.GetResourceString("PlatformNotSupported_WinRT"));
		}
		return ex?._HResult ?? 0;
	}

	[SecuritySafeCritical]
	internal static Exception ConvertToManaged(int hr)
	{
		if (!Environment.IsWinRTSupported)
		{
			throw new PlatformNotSupportedException(Environment.GetResourceString("PlatformNotSupported_WinRT"));
		}
		Exception result = null;
		if (hr < 0)
		{
			result = StubHelpers.InternalGetCOMHRExceptionObject(hr, IntPtr.Zero, null, fForWinRT: true);
		}
		return result;
	}
}
