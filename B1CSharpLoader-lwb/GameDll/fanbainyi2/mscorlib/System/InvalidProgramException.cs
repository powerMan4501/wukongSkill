using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class InvalidProgramException : SystemException
{
	[__DynamicallyInvokable]
	public InvalidProgramException()
		: base(Environment.GetResourceString("InvalidProgram_Default"))
	{
		SetErrorCode(-2146233030);
	}

	[__DynamicallyInvokable]
	public InvalidProgramException(string message)
		: base(message)
	{
		SetErrorCode(-2146233030);
	}

	[__DynamicallyInvokable]
	public InvalidProgramException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233030);
	}

	internal InvalidProgramException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
