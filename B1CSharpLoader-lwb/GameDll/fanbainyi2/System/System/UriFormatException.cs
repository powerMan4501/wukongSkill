using System.Runtime.Serialization;

namespace System;

[Serializable]
[global::__DynamicallyInvokable]
public class UriFormatException : FormatException, ISerializable
{
	[global::__DynamicallyInvokable]
	public UriFormatException()
	{
	}

	[global::__DynamicallyInvokable]
	public UriFormatException(string textString)
		: base(textString)
	{
	}

	[global::__DynamicallyInvokable]
	public UriFormatException(string textString, Exception e)
		: base(textString, e)
	{
	}

	protected UriFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		base.GetObjectData(serializationInfo, streamingContext);
	}
}
