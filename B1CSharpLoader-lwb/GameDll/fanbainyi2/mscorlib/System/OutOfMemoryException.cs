using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class OutOfMemoryException : SystemException
{
	[__DynamicallyInvokable]
	public OutOfMemoryException()
		: base(Exception.GetMessageFromNativeResources(ExceptionMessageKind.OutOfMemory))
	{
		SetErrorCode(-2147024882);
	}

	[__DynamicallyInvokable]
	public OutOfMemoryException(string message)
		: base(message)
	{
		SetErrorCode(-2147024882);
	}

	[__DynamicallyInvokable]
	public OutOfMemoryException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147024882);
	}

	protected OutOfMemoryException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
