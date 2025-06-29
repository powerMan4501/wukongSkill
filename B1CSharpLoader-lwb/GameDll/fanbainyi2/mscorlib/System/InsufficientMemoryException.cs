using System.Runtime.Serialization;

namespace System;

[Serializable]
public sealed class InsufficientMemoryException : OutOfMemoryException
{
	public InsufficientMemoryException()
		: base(Exception.GetMessageFromNativeResources(ExceptionMessageKind.OutOfMemory))
	{
		SetErrorCode(-2146233027);
	}

	public InsufficientMemoryException(string message)
		: base(message)
	{
		SetErrorCode(-2146233027);
	}

	public InsufficientMemoryException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233027);
	}

	private InsufficientMemoryException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
