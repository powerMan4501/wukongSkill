using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Threading;

[Serializable]
[ComVisible(true)]
public class ThreadStateException : SystemException
{
	public ThreadStateException()
		: base(Environment.GetResourceString("Arg_ThreadStateException"))
	{
		SetErrorCode(-2146233056);
	}

	public ThreadStateException(string message)
		: base(message)
	{
		SetErrorCode(-2146233056);
	}

	public ThreadStateException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233056);
	}

	protected ThreadStateException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
