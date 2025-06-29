using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class NotSupportedException : SystemException
{
	[__DynamicallyInvokable]
	public NotSupportedException()
		: base(Environment.GetResourceString("Arg_NotSupportedException"))
	{
		SetErrorCode(-2146233067);
	}

	[__DynamicallyInvokable]
	public NotSupportedException(string message)
		: base(message)
	{
		SetErrorCode(-2146233067);
	}

	[__DynamicallyInvokable]
	public NotSupportedException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233067);
	}

	protected NotSupportedException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
