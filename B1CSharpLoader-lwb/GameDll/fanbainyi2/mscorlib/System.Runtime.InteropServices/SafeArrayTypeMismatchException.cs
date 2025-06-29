using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class SafeArrayTypeMismatchException : SystemException
{
	[__DynamicallyInvokable]
	public SafeArrayTypeMismatchException()
		: base(Environment.GetResourceString("Arg_SafeArrayTypeMismatchException"))
	{
		SetErrorCode(-2146233037);
	}

	[__DynamicallyInvokable]
	public SafeArrayTypeMismatchException(string message)
		: base(message)
	{
		SetErrorCode(-2146233037);
	}

	[__DynamicallyInvokable]
	public SafeArrayTypeMismatchException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233037);
	}

	protected SafeArrayTypeMismatchException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
