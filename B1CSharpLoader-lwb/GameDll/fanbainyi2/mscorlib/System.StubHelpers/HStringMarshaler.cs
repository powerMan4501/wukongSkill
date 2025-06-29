using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;

namespace System.StubHelpers;

[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
internal static class HStringMarshaler
{
	[SecurityCritical]
	internal unsafe static IntPtr ConvertToNative(string managed)
	{
		if (!Environment.IsWinRTSupported)
		{
			throw new PlatformNotSupportedException(Environment.GetResourceString("PlatformNotSupported_WinRT"));
		}
		if (managed == null)
		{
			throw new ArgumentNullException();
		}
		IntPtr result = default(IntPtr);
		int errorCode = UnsafeNativeMethods.WindowsCreateString(managed, managed.Length, &result);
		Marshal.ThrowExceptionForHR(errorCode, new IntPtr(-1));
		return result;
	}

	[SecurityCritical]
	internal unsafe static IntPtr ConvertToNativeReference(string managed, [Out] HSTRING_HEADER* hstringHeader)
	{
		if (!Environment.IsWinRTSupported)
		{
			throw new PlatformNotSupportedException(Environment.GetResourceString("PlatformNotSupported_WinRT"));
		}
		if (managed == null)
		{
			throw new ArgumentNullException();
		}
		fixed (char* sourceString = managed)
		{
			IntPtr result = default(IntPtr);
			int errorCode = UnsafeNativeMethods.WindowsCreateStringReference(sourceString, managed.Length, hstringHeader, &result);
			Marshal.ThrowExceptionForHR(errorCode, new IntPtr(-1));
			return result;
		}
	}

	[SecurityCritical]
	internal static string ConvertToManaged(IntPtr hstring)
	{
		if (!Environment.IsWinRTSupported)
		{
			throw new PlatformNotSupportedException(Environment.GetResourceString("PlatformNotSupported_WinRT"));
		}
		return WindowsRuntimeMarshal.HStringToString(hstring);
	}

	[SecurityCritical]
	internal static void ClearNative(IntPtr hstring)
	{
		if (hstring != IntPtr.Zero)
		{
			UnsafeNativeMethods.WindowsDeleteString(hstring);
		}
	}
}
