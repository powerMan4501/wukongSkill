using System.Runtime.Serialization;

namespace System.Security.Authentication;

[Serializable]
public class InvalidCredentialException : AuthenticationException
{
	public InvalidCredentialException()
	{
	}

	protected InvalidCredentialException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
	}

	public InvalidCredentialException(string message)
		: base(message)
	{
	}

	public InvalidCredentialException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
