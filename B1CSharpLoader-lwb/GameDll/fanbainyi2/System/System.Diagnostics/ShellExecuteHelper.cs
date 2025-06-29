using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;

namespace System.Diagnostics;

internal class ShellExecuteHelper
{
	private Microsoft.Win32.NativeMethods.ShellExecuteInfo _executeInfo;

	private int _errorCode;

	private bool _succeeded;

	public int ErrorCode => _errorCode;

	public ShellExecuteHelper(Microsoft.Win32.NativeMethods.ShellExecuteInfo executeInfo)
	{
		_executeInfo = executeInfo;
	}

	public void ShellExecuteFunction()
	{
		if (!(_succeeded = Microsoft.Win32.NativeMethods.ShellExecuteEx(_executeInfo)))
		{
			_errorCode = Marshal.GetLastWin32Error();
		}
	}

	public bool ShellExecuteOnSTAThread()
	{
		if (Thread.CurrentThread.GetApartmentState() != ApartmentState.STA)
		{
			ThreadStart start = ShellExecuteFunction;
			Thread thread = new Thread(start);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			thread.Join();
		}
		else
		{
			ShellExecuteFunction();
		}
		return _succeeded;
	}
}
