using System.Runtime.Serialization;
using System.Security;

namespace System.Threading;

[Serializable]
[global::__DynamicallyInvokable]
public class BarrierPostPhaseException : Exception
{
	[global::__DynamicallyInvokable]
	public BarrierPostPhaseException()
		: this((string)null)
	{
	}

	[global::__DynamicallyInvokable]
	public BarrierPostPhaseException(Exception innerException)
		: this(null, innerException)
	{
	}

	[global::__DynamicallyInvokable]
	public BarrierPostPhaseException(string message)
		: this(message, null)
	{
	}

	[global::__DynamicallyInvokable]
	public BarrierPostPhaseException(string message, Exception innerException)
		: base((message == null) ? SR.GetString("BarrierPostPhaseException") : message, innerException)
	{
	}

	[SecurityCritical]
	protected BarrierPostPhaseException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
