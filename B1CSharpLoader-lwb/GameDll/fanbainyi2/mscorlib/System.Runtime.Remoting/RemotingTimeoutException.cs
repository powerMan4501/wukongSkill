using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting;

[Serializable]
[ComVisible(true)]
public class RemotingTimeoutException : RemotingException
{
	private static string _nullMessage = Environment.GetResourceString("Remoting_Default");

	public RemotingTimeoutException()
		: base(_nullMessage)
	{
	}

	public RemotingTimeoutException(string message)
		: base(message)
	{
		SetErrorCode(-2146233077);
	}

	public RemotingTimeoutException(string message, Exception InnerException)
		: base(message, InnerException)
	{
		SetErrorCode(-2146233077);
	}

	internal RemotingTimeoutException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
