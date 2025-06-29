using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class MemberAccessException : SystemException
{
	[__DynamicallyInvokable]
	public MemberAccessException()
		: base(Environment.GetResourceString("Arg_AccessException"))
	{
		SetErrorCode(-2146233062);
	}

	[__DynamicallyInvokable]
	public MemberAccessException(string message)
		: base(message)
	{
		SetErrorCode(-2146233062);
	}

	[__DynamicallyInvokable]
	public MemberAccessException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233062);
	}

	protected MemberAccessException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
