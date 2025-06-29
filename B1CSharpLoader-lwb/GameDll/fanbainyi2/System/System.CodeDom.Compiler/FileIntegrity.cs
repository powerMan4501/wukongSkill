using System.Runtime.InteropServices;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.CodeDom.Compiler;

internal static class FileIntegrity
{
	private static readonly Lazy<bool> s_lazyIsEnabled = new Lazy<bool>(delegate
	{
		Version version = Environment.OSVersion.Version;
		if (version.Major < 6 || (version.Major == 6 && version.Minor < 2))
		{
			return false;
		}
		using Microsoft.Win32.SafeHandles.SafeLibraryHandle safeLibraryHandle = Microsoft.Win32.SafeHandles.SafeLibraryHandle.LoadLibraryEx("wldp.dll", IntPtr.Zero, 2048);
		if (safeLibraryHandle.IsInvalid)
		{
			return false;
		}
		IntPtr moduleHandle = Microsoft.Win32.UnsafeNativeMethods.GetModuleHandle("wldp.dll");
		if (!(moduleHandle != IntPtr.Zero) || !(IntPtr.Zero != Microsoft.Win32.UnsafeNativeMethods.GetProcAddress(moduleHandle, "WldpIsDynamicCodePolicyEnabled")) || !(IntPtr.Zero != Microsoft.Win32.UnsafeNativeMethods.GetProcAddress(moduleHandle, "WldpSetDynamicCodeTrust")) || !(IntPtr.Zero != Microsoft.Win32.UnsafeNativeMethods.GetProcAddress(moduleHandle, "WldpQueryDynamicCodeTrust")))
		{
			return false;
		}
		int enabled = 0;
		int errorCode = Microsoft.Win32.UnsafeNativeMethods.WldpIsDynamicCodePolicyEnabled(out enabled);
		Marshal.ThrowExceptionForHR(errorCode, new IntPtr(-1));
		return enabled != 0;
	});

	public static bool IsEnabled => s_lazyIsEnabled.Value;

	public static void MarkAsTrusted(SafeFileHandle safeFileHandle)
	{
		int errorCode = Microsoft.Win32.UnsafeNativeMethods.WldpSetDynamicCodeTrust(safeFileHandle);
		Marshal.ThrowExceptionForHR(errorCode, new IntPtr(-1));
	}

	public static bool IsTrusted(SafeFileHandle safeFileHandle)
	{
		int num = Microsoft.Win32.UnsafeNativeMethods.WldpQueryDynamicCodeTrust(safeFileHandle, IntPtr.Zero, 0u);
		if (num == -805305819)
		{
			return false;
		}
		Marshal.ThrowExceptionForHR(num, new IntPtr(-1));
		return true;
	}
}
