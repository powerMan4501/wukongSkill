using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System;

[Serializable]
[ComVisible(true)]
public class UnhandledExceptionEventArgs : EventArgs
{
	private object _Exception;

	private bool _IsTerminating;

	public object ExceptionObject
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return _Exception;
		}
	}

	public bool IsTerminating
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return _IsTerminating;
		}
	}

	public UnhandledExceptionEventArgs(object exception, bool isTerminating)
	{
		_Exception = exception;
		_IsTerminating = isTerminating;
	}
}
