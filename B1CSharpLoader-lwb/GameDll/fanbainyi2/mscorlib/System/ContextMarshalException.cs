using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
public class ContextMarshalException : SystemException
{
	public ContextMarshalException()
		: base(Environment.GetResourceString("Arg_ContextMarshalException"))
	{
		SetErrorCode(-2146233084);
	}

	public ContextMarshalException(string message)
		: base(message)
	{
		SetErrorCode(-2146233084);
	}

	public ContextMarshalException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233084);
	}

	protected ContextMarshalException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
