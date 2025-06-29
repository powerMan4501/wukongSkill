using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class IndexOutOfRangeException : SystemException
{
	[__DynamicallyInvokable]
	public IndexOutOfRangeException()
		: base(Environment.GetResourceString("Arg_IndexOutOfRangeException"))
	{
		SetErrorCode(-2146233080);
	}

	[__DynamicallyInvokable]
	public IndexOutOfRangeException(string message)
		: base(message)
	{
		SetErrorCode(-2146233080);
	}

	[__DynamicallyInvokable]
	public IndexOutOfRangeException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233080);
	}

	internal IndexOutOfRangeException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
