using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class RankException : SystemException
{
	[__DynamicallyInvokable]
	public RankException()
		: base(Environment.GetResourceString("Arg_RankException"))
	{
		SetErrorCode(-2146233065);
	}

	[__DynamicallyInvokable]
	public RankException(string message)
		: base(message)
	{
		SetErrorCode(-2146233065);
	}

	[__DynamicallyInvokable]
	public RankException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233065);
	}

	protected RankException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
