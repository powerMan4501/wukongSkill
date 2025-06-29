using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class SafeArrayRankMismatchException : SystemException
{
	[__DynamicallyInvokable]
	public SafeArrayRankMismatchException()
		: base(Environment.GetResourceString("Arg_SafeArrayRankMismatchException"))
	{
		SetErrorCode(-2146233032);
	}

	[__DynamicallyInvokable]
	public SafeArrayRankMismatchException(string message)
		: base(message)
	{
		SetErrorCode(-2146233032);
	}

	[__DynamicallyInvokable]
	public SafeArrayRankMismatchException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233032);
	}

	protected SafeArrayRankMismatchException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
