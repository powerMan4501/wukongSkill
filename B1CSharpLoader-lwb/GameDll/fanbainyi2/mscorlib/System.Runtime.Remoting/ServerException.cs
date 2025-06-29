using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting;

[Serializable]
[ComVisible(true)]
public class ServerException : SystemException
{
	private static string _nullMessage = Environment.GetResourceString("Remoting_Default");

	public ServerException()
		: base(_nullMessage)
	{
		SetErrorCode(-2146233074);
	}

	public ServerException(string message)
		: base(message)
	{
		SetErrorCode(-2146233074);
	}

	public ServerException(string message, Exception InnerException)
		: base(message, InnerException)
	{
		SetErrorCode(-2146233074);
	}

	internal ServerException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
