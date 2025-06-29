using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
[global::__DynamicallyInvokable]
public sealed class InvalidDataException : SystemException
{
	[global::__DynamicallyInvokable]
	public InvalidDataException()
		: base(SR.GetString("GenericInvalidData"))
	{
	}

	[global::__DynamicallyInvokable]
	public InvalidDataException(string message)
		: base(message)
	{
	}

	[global::__DynamicallyInvokable]
	public InvalidDataException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	internal InvalidDataException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
