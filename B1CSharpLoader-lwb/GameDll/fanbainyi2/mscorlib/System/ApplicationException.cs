using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
public class ApplicationException : Exception
{
	public ApplicationException()
		: base(Environment.GetResourceString("Arg_ApplicationException"))
	{
		SetErrorCode(-2146232832);
	}

	public ApplicationException(string message)
		: base(message)
	{
		SetErrorCode(-2146232832);
	}

	public ApplicationException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146232832);
	}

	protected ApplicationException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
