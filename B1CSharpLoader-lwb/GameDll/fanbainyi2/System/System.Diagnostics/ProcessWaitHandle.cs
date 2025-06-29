using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics;

internal class ProcessWaitHandle : WaitHandle
{
	internal ProcessWaitHandle(SafeProcessHandle processHandle)
	{
		SafeWaitHandle targetHandle = null;
		if (!Microsoft.Win32.NativeMethods.DuplicateHandle(new HandleRef(this, Microsoft.Win32.NativeMethods.GetCurrentProcess()), (SafeHandle)processHandle, new HandleRef(this, Microsoft.Win32.NativeMethods.GetCurrentProcess()), out targetHandle, 0, bInheritHandle: false, 2))
		{
			Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
		}
		base.SafeWaitHandle = targetHandle;
	}
}
