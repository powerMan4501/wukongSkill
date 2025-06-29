using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace System.Diagnostics;

internal class MainWindowFinder
{
	private IntPtr bestHandle;

	private int processId;

	public IntPtr FindMainWindow(int processId)
	{
		bestHandle = (IntPtr)0;
		this.processId = processId;
		Microsoft.Win32.NativeMethods.EnumThreadWindowsCallback enumThreadWindowsCallback = EnumWindowsCallback;
		Microsoft.Win32.NativeMethods.EnumWindows(enumThreadWindowsCallback, IntPtr.Zero);
		GC.KeepAlive(enumThreadWindowsCallback);
		return bestHandle;
	}

	private bool IsMainWindow(IntPtr handle)
	{
		if (Microsoft.Win32.NativeMethods.GetWindow(new HandleRef(this, handle), 4) != (IntPtr)0 || !Microsoft.Win32.NativeMethods.IsWindowVisible(new HandleRef(this, handle)))
		{
			return false;
		}
		return true;
	}

	private bool EnumWindowsCallback(IntPtr handle, IntPtr extraParameter)
	{
		Microsoft.Win32.NativeMethods.GetWindowThreadProcessId(new HandleRef(this, handle), out var num);
		if (num == processId && IsMainWindow(handle))
		{
			bestHandle = handle;
			return false;
		}
		return true;
	}
}
