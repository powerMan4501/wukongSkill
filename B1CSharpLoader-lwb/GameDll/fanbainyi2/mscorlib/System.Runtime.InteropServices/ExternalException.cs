using System.Globalization;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
public class ExternalException : SystemException
{
	public virtual int ErrorCode => base.HResult;

	public ExternalException()
		: base(Environment.GetResourceString("Arg_ExternalException"))
	{
		SetErrorCode(-2147467259);
	}

	public ExternalException(string message)
		: base(message)
	{
		SetErrorCode(-2147467259);
	}

	public ExternalException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2147467259);
	}

	public ExternalException(string message, int errorCode)
		: base(message)
	{
		SetErrorCode(errorCode);
	}

	protected ExternalException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public override string ToString()
	{
		string message = Message;
		string text = GetType().ToString();
		string text2 = text + " (0x" + base.HResult.ToString("X8", CultureInfo.InvariantCulture) + ")";
		if (!string.IsNullOrEmpty(message))
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
