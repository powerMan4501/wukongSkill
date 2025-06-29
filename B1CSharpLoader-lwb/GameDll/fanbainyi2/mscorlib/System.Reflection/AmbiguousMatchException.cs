using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AmbiguousMatchException : SystemException
{
	[__DynamicallyInvokable]
	public AmbiguousMatchException()
		: base(Environment.GetResourceString("RFLCT.Ambiguous"))
	{
		SetErrorCode(-2147475171);
	}

	[__DynamicallyInvokable]
	public AmbiguousMatchException(string message)
		: base(message)
	{
		SetErrorCode(-2147475171);
	}

	[__DynamicallyInvokable]
	public AmbiguousMatchException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2147475171);
	}

	internal AmbiguousMatchException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
