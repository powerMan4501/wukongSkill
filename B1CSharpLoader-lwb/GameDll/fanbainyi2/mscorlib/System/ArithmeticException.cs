using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class ArithmeticException : SystemException
{
	[__DynamicallyInvokable]
	public ArithmeticException()
		: base(Environment.GetResourceString("Arg_ArithmeticException"))
	{
		SetErrorCode(-2147024362);
	}

	[__DynamicallyInvokable]
	public ArithmeticException(string message)
		: base(message)
	{
		SetErrorCode(-2147024362);
	}

	[__DynamicallyInvokable]
	public ArithmeticException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147024362);
	}

	protected ArithmeticException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
