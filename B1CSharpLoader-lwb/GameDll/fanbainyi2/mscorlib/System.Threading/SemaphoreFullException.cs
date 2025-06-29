using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Threading;

[Serializable]
[ComVisible(false)]
[TypeForwardedFrom("System, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b77a5c561934e089")]
[__DynamicallyInvokable]
public class SemaphoreFullException : SystemException
{
	[__DynamicallyInvokable]
	public SemaphoreFullException()
		: base(Environment.GetResourceString("Threading_SemaphoreFullException"))
	{
	}

	[__DynamicallyInvokable]
	public SemaphoreFullException(string message)
		: base(message)
	{
	}

	[__DynamicallyInvokable]
	public SemaphoreFullException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected SemaphoreFullException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
