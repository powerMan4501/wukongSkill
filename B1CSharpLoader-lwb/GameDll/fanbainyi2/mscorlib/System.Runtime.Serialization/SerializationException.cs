using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class SerializationException : SystemException
{
	private static string _nullMessage = Environment.GetResourceString("Arg_SerializationException");

	[__DynamicallyInvokable]
	public SerializationException()
		: base(_nullMessage)
	{
		SetErrorCode(-2146233076);
	}

	[__DynamicallyInvokable]
	public SerializationException(string message)
		: base(message)
	{
		SetErrorCode(-2146233076);
	}

	[__DynamicallyInvokable]
	public SerializationException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233076);
	}

	protected SerializationException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
