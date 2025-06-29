using System;
using System.Diagnostics;
using System.Linq;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Debugger;

namespace ILRuntime.Runtime.Intepreter;

public class ILRuntimeException : Exception
{
	private string message;

	private string stackTrace;

	private string thisInfo;

	private string localInfo;

	public string nativeStackTrace;

	public override string Message => message + "\n" + stackTrace;

	public override string StackTrace => stackTrace;

	public string ThisInfo => thisInfo;

	public string LocalInfo => localInfo;

	internal ILRuntimeException(string message, ILIntepreter intepreter, ILMethod method, Exception innerException = null)
		: base(message, innerException)
	{
		this.message = message;
		DebugService debugService = intepreter.AppDomain.DebugService;
		if (innerException is ILRuntimeException)
		{
			ILRuntimeException ex = innerException as ILRuntimeException;
			stackTrace = ex.stackTrace;
			thisInfo = ex.thisInfo;
			localInfo = ex.localInfo;
		}
		else
		{
			stackTrace = debugService.GetStackTrace(intepreter);
			try
			{
				if (method.HasThis)
				{
					thisInfo = debugService.GetThisInfo(intepreter);
				}
				else
				{
					thisInfo = "";
				}
				localInfo = debugService.GetLocalVariableInfo(intepreter);
			}
			catch
			{
			}
		}
		if (debugService.OnILRuntimeException != null)
		{
			debugService.OnILRuntimeException(ToString());
		}
		StackFrame[] frames = new StackTrace(fNeedFileInfo: true).GetFrames();
		if (frames != null)
		{
			nativeStackTrace = string.Join("\n", from frame in frames
				where !string.IsNullOrEmpty(frame.GetFileName())
				select $"{frame.GetFileName()}: {frame.GetFileLineNumber()}");
		}
	}

	public override string ToString()
	{
		Exception ex = this;
		string text = "";
		while (ex != null)
		{
			text = ex.StackTrace + "\r\n" + text;
			ex = ex.InnerException;
		}
		return $"{GetBaseException().GetType()}: {GetBaseException().Message}\r\n{text}\r\n{nativeStackTrace}";
	}
}
