using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Instrumentation;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class InstrumentationBaseException : Exception
{
	public InstrumentationBaseException()
	{
	}

	public InstrumentationBaseException(string message)
		: base(message)
	{
	}

	public InstrumentationBaseException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected InstrumentationBaseException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
