using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class DllNotFoundException : TypeLoadException
{
	[__DynamicallyInvokable]
	public DllNotFoundException()
		: base(Environment.GetResourceString("Arg_DllNotFoundException"))
	{
		SetErrorCode(-2146233052);
	}

	[__DynamicallyInvokable]
	public DllNotFoundException(string message)
		: base(message)
	{
		SetErrorCode(-2146233052);
	}

	[__DynamicallyInvokable]
	public DllNotFoundException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233052);
	}

	protected DllNotFoundException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
