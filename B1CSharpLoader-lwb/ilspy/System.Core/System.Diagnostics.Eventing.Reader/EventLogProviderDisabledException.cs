using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Diagnostics.Eventing.Reader;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventLogProviderDisabledException : EventLogException
{
	public EventLogProviderDisabledException()
	{
	}

	public EventLogProviderDisabledException(string message)
		: base(message)
	{
	}

	public EventLogProviderDisabledException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected EventLogProviderDisabledException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
	}

	internal EventLogProviderDisabledException(int errorCode)
		: base(errorCode)
	{
	}
}
