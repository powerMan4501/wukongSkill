using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Win32;

[SuppressUnmanagedCodeSecurity]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
internal static class SafeNativeMethods
{
	[StructLayout(LayoutKind.Sequential)]
	internal class PROCESS_INFORMATION
	{
		public IntPtr hProcess = IntPtr.Zero;

		public IntPtr hThread = IntPtr.Zero;

		public int dwProcessId;

		public int dwThreadId;
	}

	public const int MB_RIGHT = 524288;

	public const int MB_RTLREADING = 1048576;

	public const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 256;

	public const int FORMAT_MESSAGE_IGNORE_INSERTS = 512;

	public const int FORMAT_MESSAGE_FROM_STRING = 1024;

	public const int FORMAT_MESSAGE_FROM_SYSTEM = 4096;

	public const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192;

	public const int ERROR_INSUFFICIENT_BUFFER = 122;

	public const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 255;

	public const int FORMAT_MESSAGE_FROM_HMODULE = 2048;

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	public static extern bool GetTextMetrics(IntPtr hDC, [In][Out] NativeMethods.TEXTMETRIC tm);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetStockObject(int nIndex);

	[DllImport("kernel32.dll", BestFitMapping = true, CharSet = CharSet.Auto)]
	public static extern void OutputDebugString(string message);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "MessageBoxW", ExactSpelling = true)]
	private static extern int MessageBoxSystem(IntPtr hWnd, string text, string caption, int type);

	[SecurityCritical]
	public static int MessageBox(IntPtr hWnd, string text, string caption, int type)
	{
		try
		{
			return MessageBoxSystem(hWnd, text, caption, type);
		}
		catch (DllNotFoundException)
		{
			return 0;
		}
		catch (EntryPointNotFoundException)
		{
			return 0;
		}
	}

	[DllImport("kernel32.dll", BestFitMapping = true, CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int FormatMessage(int dwFlags, IntPtr lpSource_mustBeNull, uint dwMessageId, int dwLanguageId, StringBuilder lpBuffer, int nSize, IntPtr[] arguments);

	[DllImport("kernel32.dll", BestFitMapping = true, CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int FormatMessage(int dwFlags, Microsoft.Win32.SafeHandles.SafeLibraryHandle lpSource, uint dwMessageId, int dwLanguageId, StringBuilder lpBuffer, int nSize, IntPtr[] arguments);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static extern bool CloseHandle(IntPtr handle);

	[DllImport("kernel32.dll")]
	public static extern bool QueryPerformanceCounter(out long value);

	[DllImport("kernel32.dll")]
	public static extern bool QueryPerformanceFrequency(out long value);

	[DllImport("user32.dll", BestFitMapping = false, CharSet = CharSet.Auto)]
	public static extern int RegisterWindowMessage(string msg);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern IntPtr LoadLibrary(string libFilename);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool FreeLibrary(HandleRef hModule);

	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto)]
	public static extern bool GetComputerName(StringBuilder lpBuffer, int[] nSize);

	public unsafe static int InterlockedCompareExchange(IntPtr pDestination, int exchange, int compare)
	{
		return Interlocked.CompareExchange(ref *(int*)pDestination.ToPointer(), exchange, compare);
	}

	[DllImport("perfcounter.dll", CharSet = CharSet.Auto)]
	public static extern int FormatFromRawValue(uint dwCounterType, uint dwFormat, ref long pTimeBase, NativeMethods.PDH_RAW_COUNTER pRawValue1, NativeMethods.PDH_RAW_COUNTER pRawValue2, NativeMethods.PDH_FMT_COUNTERVALUE pFmtValue);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool IsWow64Process(SafeProcessHandle hProcess, ref bool Wow64Process);

	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern SafeWaitHandle CreateSemaphore(NativeMethods.SECURITY_ATTRIBUTES lpSecurityAttributes, int initialCount, int maximumCount, string name);

	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern SafeWaitHandle OpenSemaphore(int desiredAccess, bool inheritHandle, string name);

	[DllImport("kernel32.dll", SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern bool ReleaseSemaphore(SafeWaitHandle handle, int releaseCount, out int previousCount);
}
