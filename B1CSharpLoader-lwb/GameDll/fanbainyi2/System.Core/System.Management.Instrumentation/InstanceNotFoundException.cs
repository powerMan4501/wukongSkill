using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Instrumentation;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class InstanceNotFoundException : InstrumentationException
{
	public InstanceNotFoundException()
	{
	}

	public InstanceNotFoundException(string message)
		: base(message)
	{
	}

	public InstanceNotFoundException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected InstanceNotFoundException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
