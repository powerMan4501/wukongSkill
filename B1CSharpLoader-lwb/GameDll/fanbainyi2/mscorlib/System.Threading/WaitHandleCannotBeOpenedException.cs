using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Threading;

[Serializable]
[ComVisible(false)]
[__DynamicallyInvokable]
public class WaitHandleCannotBeOpenedException : ApplicationException
{
	[__DynamicallyInvokable]
	public WaitHandleCannotBeOpenedException()
		: base(Environment.GetResourceString("Threading.WaitHandleCannotBeOpenedException"))
	{
		SetErrorCode(-2146233044);
	}

	[__DynamicallyInvokable]
	public WaitHandleCannotBeOpenedException(string message)
		: base(message)
	{
		SetErrorCode(-2146233044);
	}

	[__DynamicallyInvokable]
	public WaitHandleCannotBeOpenedException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233044);
	}

	protected WaitHandleCannotBeOpenedException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
