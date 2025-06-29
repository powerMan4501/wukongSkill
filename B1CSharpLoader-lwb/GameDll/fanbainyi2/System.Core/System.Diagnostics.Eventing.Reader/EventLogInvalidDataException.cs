using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Diagnostics.Eventing.Reader;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public class EventLogInvalidDataException : EventLogException
{
	public EventLogInvalidDataException()
	{
	}

	public EventLogInvalidDataException(string message)
		: base(message)
	{
	}

	public EventLogInvalidDataException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected EventLogInvalidDataException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
	}

	internal EventLogInvalidDataException(int errorCode)
		: base(errorCode)
	{
	}
}
