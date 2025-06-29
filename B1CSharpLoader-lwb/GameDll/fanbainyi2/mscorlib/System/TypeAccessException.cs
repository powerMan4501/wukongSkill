using System.Runtime.Serialization;

namespace System;

[Serializable]
[__DynamicallyInvokable]
public class TypeAccessException : TypeLoadException
{
	[__DynamicallyInvokable]
	public TypeAccessException()
		: base(Environment.GetResourceString("Arg_TypeAccessException"))
	{
		SetErrorCode(-2146233021);
	}

	[__DynamicallyInvokable]
	public TypeAccessException(string message)
		: base(message)
	{
		SetErrorCode(-2146233021);
	}

	[__DynamicallyInvokable]
	public TypeAccessException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233021);
	}

	protected TypeAccessException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		SetErrorCode(-2146233021);
	}
}
