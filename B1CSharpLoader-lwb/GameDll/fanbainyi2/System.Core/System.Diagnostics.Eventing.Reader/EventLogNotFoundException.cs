using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Diagnostics.Eventing.Reader;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventLogNotFoundException : EventLogException
{
	public EventLogNotFoundException()
	{
	}

	public EventLogNotFoundException(string message)
		: base(message)
	{
	}

	public EventLogNotFoundException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected EventLogNotFoundException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
	}

	internal EventLogNotFoundException(int errorCode)
		: base(errorCode)
	{
	}
}
