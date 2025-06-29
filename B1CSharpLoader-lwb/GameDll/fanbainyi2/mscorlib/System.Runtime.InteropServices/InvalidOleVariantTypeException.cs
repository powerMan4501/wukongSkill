using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class InvalidOleVariantTypeException : SystemException
{
	[__DynamicallyInvokable]
	public InvalidOleVariantTypeException()
		: base(Environment.GetResourceString("Arg_InvalidOleVariantTypeException"))
	{
		SetErrorCode(-2146233039);
	}

	[__DynamicallyInvokable]
	public InvalidOleVariantTypeException(string message)
		: base(message)
	{
		SetErrorCode(-2146233039);
	}

	[__DynamicallyInvokable]
	public InvalidOleVariantTypeException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233039);
	}

	protected InvalidOleVariantTypeException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
