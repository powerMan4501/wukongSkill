using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Diagnostics.Eventing.Reader;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventLogReadingException : EventLogException
{
	public EventLogReadingException()
	{
	}

	public EventLogReadingException(string message)
		: base(message)
	{
	}

	public EventLogReadingException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected EventLogReadingException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
	}

	internal EventLogReadingException(int errorCode)
		: base(errorCode)
	{
	}
}
