using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class NotImplementedException : SystemException
{
	[__DynamicallyInvokable]
	public NotImplementedException()
		: base(Environment.GetResourceString("Arg_NotImplementedException"))
	{
		SetErrorCode(-2147467263);
	}

	[__DynamicallyInvokable]
	public NotImplementedException(string message)
		: base(message)
	{
		SetErrorCode(-2147467263);
	}

	[__DynamicallyInvokable]
	public NotImplementedException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2147467263);
	}

	protected NotImplementedException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
