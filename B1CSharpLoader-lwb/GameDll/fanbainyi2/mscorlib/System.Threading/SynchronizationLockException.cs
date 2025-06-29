using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Threading;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class SynchronizationLockException : SystemException
{
	[__DynamicallyInvokable]
	public SynchronizationLockException()
		: base(Environment.GetResourceString("Arg_SynchronizationLockException"))
	{
		SetErrorCode(-2146233064);
	}

	[__DynamicallyInvokable]
	public SynchronizationLockException(string message)
		: base(message)
	{
		SetErrorCode(-2146233064);
	}

	[__DynamicallyInvokable]
	public SynchronizationLockException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233064);
	}

	protected SynchronizationLockException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
