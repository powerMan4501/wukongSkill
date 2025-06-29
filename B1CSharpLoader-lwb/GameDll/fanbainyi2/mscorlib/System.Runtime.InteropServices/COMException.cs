using System.Globalization;
using System.Runtime.Serialization;
using System.Security;
using Microsoft.Win32;

namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class COMException : ExternalException
{
	[__DynamicallyInvokable]
	public COMException()
		: base(Environment.GetResourceString("Arg_COMException"))
	{
		SetErrorCode(-2147467259);
	}

	[__DynamicallyInvokable]
	public COMException(string message)
		: base(message)
	{
		SetErrorCode(-2147467259);
	}

	[__DynamicallyInvokable]
	public COMException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2147467259);
	}

	[__DynamicallyInvokable]
	public COMException(string message, int errorCode)
		: base(message)
	{
		SetErrorCode(errorCode);
	}

	[SecuritySafeCritical]
	internal COMException(int hresult)
		: base(Win32Native.GetMessage(hresult))
	{
		SetErrorCode(hresult);
	}

	internal COMException(string message, int hresult, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(hresult);
	}

	protected COMException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public override string ToString()
	{
		string message = Message;
		string text = GetType().ToString();
		string text2 = text + " (0x" + base.HResult.ToString("X8", CultureInfo.InvariantCulture) + ")";
		if (message != null && message.Length > 0)
		{
			text2 = text2 + ": " + message;
		}
		Exception innerException = base.InnerException;
		if (innerException != null)
		{
			text2 = text2 + " ---> " + innerException.ToString();
		}
		if (StackTrace != null)
		{
			text2 = text2 + Environment.NewLine + StackTrace;
		}
		return text2;
	}
}
