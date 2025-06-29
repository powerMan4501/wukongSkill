using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.ComponentModel;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class InvalidAsynchronousStateException : ArgumentException
{
	public InvalidAsynchronousStateException()
		: this(null)
	{
	}

	public InvalidAsynchronousStateException(string message)
		: base(message)
	{
	}

	public InvalidAsynchronousStateException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected InvalidAsynchronousStateException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
