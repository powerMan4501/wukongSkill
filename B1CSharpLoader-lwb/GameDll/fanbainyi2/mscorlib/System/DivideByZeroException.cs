using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class DivideByZeroException : ArithmeticException
{
	[__DynamicallyInvokable]
	public DivideByZeroException()
		: base(Environment.GetResourceString("Arg_DivideByZero"))
	{
		SetErrorCode(-2147352558);
	}

	[__DynamicallyInvokable]
	public DivideByZeroException(string message)
		: base(message)
	{
		SetErrorCode(-2147352558);
	}

	[__DynamicallyInvokable]
	public DivideByZeroException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147352558);
	}

	protected DivideByZeroException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
