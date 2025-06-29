using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
public sealed class StackOverflowException : SystemException
{
	public StackOverflowException()
		: base(Environment.GetResourceString("Arg_StackOverflowException"))
	{
		SetErrorCode(-2147023895);
	}

	public StackOverflowException(string message)
		: base(message)
	{
		SetErrorCode(-2147023895);
	}

	public StackOverflowException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147023895);
	}

	internal StackOverflowException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
