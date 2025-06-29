using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class TargetParameterCountException : ApplicationException
{
	[__DynamicallyInvokable]
	public TargetParameterCountException()
		: base(Environment.GetResourceString("Arg_TargetParameterCountException"))
	{
		SetErrorCode(-2147352562);
	}

	[__DynamicallyInvokable]
	public TargetParameterCountException(string message)
		: base(message)
	{
		SetErrorCode(-2147352562);
	}

	[__DynamicallyInvokable]
	public TargetParameterCountException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2147352562);
	}

	internal TargetParameterCountException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
