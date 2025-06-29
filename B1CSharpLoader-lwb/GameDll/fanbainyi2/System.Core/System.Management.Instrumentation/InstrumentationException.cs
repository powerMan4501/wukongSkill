using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Instrumentation;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class InstrumentationException : InstrumentationBaseException
{
	public InstrumentationException()
	{
	}

	public InstrumentationException(string message)
		: base(message)
	{
	}

	public InstrumentationException(Exception innerException)
		: base(null, innerException)
	{
	}

	public InstrumentationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected InstrumentationException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
