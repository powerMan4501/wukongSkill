using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting;

[Serializable]
[ComVisible(true)]
public class RemotingException : SystemException
{
	private static string _nullMessage = Environment.GetResourceString("Remoting_Default");

	public RemotingException()
		: base(_nullMessage)
	{
		SetErrorCode(-2146233077);
	}

	public RemotingException(string message)
		: base(message)
	{
		SetErrorCode(-2146233077);
	}

	public RemotingException(string message, Exception InnerException)
		: base(message, InnerException)
	{
		SetErrorCode(-2146233077);
	}

	protected RemotingException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
