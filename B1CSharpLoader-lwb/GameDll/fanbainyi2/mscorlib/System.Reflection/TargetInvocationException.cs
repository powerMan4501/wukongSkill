using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class TargetInvocationException : ApplicationException
{
	private TargetInvocationException()
		: base(Environment.GetResourceString("Arg_TargetInvocationException"))
	{
		SetErrorCode(-2146232828);
	}

	private TargetInvocationException(string message)
		: base(message)
	{
		SetErrorCode(-2146232828);
	}

	[__DynamicallyInvokable]
	public TargetInvocationException(Exception inner)
		: base(Environment.GetResourceString("Arg_TargetInvocationException"), inner)
	{
		SetErrorCode(-2146232828);
	}

	[__DynamicallyInvokable]
	public TargetInvocationException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146232828);
	}

	internal TargetInvocationException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
