using System.Runtime.Serialization;

namespace System.Security.Authentication;

[Serializable]
public class AuthenticationException : SystemException
{
	public AuthenticationException()
	{
	}

	protected AuthenticationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
	}

	public AuthenticationException(string message)
		: base(message)
	{
	}

	public AuthenticationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
