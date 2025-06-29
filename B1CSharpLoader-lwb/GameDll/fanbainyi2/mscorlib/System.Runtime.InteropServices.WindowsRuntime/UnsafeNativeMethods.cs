using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal static class UnsafeNativeMethods
{
	[DllImport("api-ms-win-core-winrt-error-l1-1-1.dll", PreserveSig = false)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
	internal static extern IRestrictedErrorInfo GetRestrictedErrorInfo();

	[DllImport("api-ms-win-core-winrt-error-l1-1-1.dll")]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool RoOriginateLanguageException(int error, [MarshalAs(UnmanagedType.HString)] string message, IntPtr languageException);

	[DllImport("api-ms-win-core-winrt-error-l1-1-1.dll", PreserveSig = false)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
	internal static extern void RoReportUnhandledError(IRestrictedErrorInfo error);

	[DllImport("api-ms-win-core-winrt-string-l1-1-0.dll", CallingConvention = CallingConvention.StdCall)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
	internal unsafe static extern int WindowsCreateString([MarshalAs(UnmanagedType.LPWStr)] string sourceString, int length, [Out] IntPtr* hstring);

	[DllImport("api-ms-win-core-winrt-string-l1-1-0.dll", CallingConvention = CallingConvention.StdCall)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
	internal unsafe static extern int WindowsCreateStringReference(char* sourceString, int length, [Out] HSTRING_HEADER* hstringHeader, [Out] IntPtr* hstring);

	[DllImport("api-ms-win-core-winrt-string-l1-1-0.dll", CallingConvention = CallingConvention.StdCall)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
	internal static extern int WindowsDeleteString(IntPtr hstring);

	[DllImport("api-ms-win-core-winrt-string-l1-1-0.dll", CallingConvention = CallingConvention.StdCall)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
	internal unsafe static extern char* WindowsGetStringRawBuffer(IntPtr hstring, [Out] uint* length);
}
