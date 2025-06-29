using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class FieldAccessException : MemberAccessException
{
	[__DynamicallyInvokable]
	public FieldAccessException()
		: base(Environment.GetResourceString("Arg_FieldAccessException"))
	{
		SetErrorCode(-2146233081);
	}

	[__DynamicallyInvokable]
	public FieldAccessException(string message)
		: base(message)
	{
		SetErrorCode(-2146233081);
	}

	[__DynamicallyInvokable]
	public FieldAccessException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233081);
	}

	protected FieldAccessException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
