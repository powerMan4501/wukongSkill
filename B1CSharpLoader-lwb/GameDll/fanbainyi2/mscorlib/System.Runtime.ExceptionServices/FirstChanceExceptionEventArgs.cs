using System.Runtime.ConstrainedExecution;

namespace System.Runtime.ExceptionServices;

public class FirstChanceExceptionEventArgs : EventArgs
{
	private Exception m_Exception;

	public Exception Exception
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return m_Exception;
		}
	}

	public FirstChanceExceptionEventArgs(Exception exception)
	{
		m_Exception = exception;
	}
}
