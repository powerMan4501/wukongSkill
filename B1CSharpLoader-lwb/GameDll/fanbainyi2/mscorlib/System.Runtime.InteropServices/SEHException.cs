using System.Runtime.Serialization;

namespace System.Runtime.InteropServices;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class SEHException : ExternalException
{
	[__DynamicallyInvokable]
	public SEHException()
	{
		SetErrorCode(-2147467259);
	}

	[__DynamicallyInvokable]
	public SEHException(string message)
		: base(message)
	{
		SetErrorCode(-2147467259);
	}

	[__DynamicallyInvokable]
	public SEHException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2147467259);
	}

	protected SEHException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	[__DynamicallyInvokable]
	public virtual bool CanResume()
	{
		return false;
	}
}
