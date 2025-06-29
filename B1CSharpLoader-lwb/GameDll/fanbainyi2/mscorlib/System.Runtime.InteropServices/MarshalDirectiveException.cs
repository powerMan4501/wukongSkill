using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class MarshalDirectiveException : SystemException
{
	[__DynamicallyInvokable]
	public MarshalDirectiveException()
		: base(Environment.GetResourceString("Arg_MarshalDirectiveException"))
	{
		SetErrorCode(-2146233035);
	}

	[__DynamicallyInvokable]
	public MarshalDirectiveException(string message)
		: base(message)
	{
		SetErrorCode(-2146233035);
	}

	[__DynamicallyInvokable]
	public MarshalDirectiveException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233035);
	}

	protected MarshalDirectiveException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
