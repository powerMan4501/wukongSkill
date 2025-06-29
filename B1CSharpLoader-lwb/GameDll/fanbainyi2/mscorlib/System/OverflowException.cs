using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class OverflowException : ArithmeticException
{
	[__DynamicallyInvokable]
	public OverflowException()
		: base(Environment.GetResourceString("Arg_OverflowException"))
	{
		SetErrorCode(-2146233066);
	}

	[__DynamicallyInvokable]
	public OverflowException(string message)
		: base(message)
	{
		SetErrorCode(-2146233066);
	}

	[__DynamicallyInvokable]
	public OverflowException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233066);
	}

	protected OverflowException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
