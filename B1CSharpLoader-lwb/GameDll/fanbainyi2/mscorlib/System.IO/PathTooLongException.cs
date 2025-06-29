using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class PathTooLongException : IOException
{
	[__DynamicallyInvokable]
	public PathTooLongException()
		: base(Environment.GetResourceString("IO.PathTooLong"))
	{
		SetErrorCode(-2147024690);
	}

	[__DynamicallyInvokable]
	public PathTooLongException(string message)
		: base(message)
	{
		SetErrorCode(-2147024690);
	}

	[__DynamicallyInvokable]
	public PathTooLongException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147024690);
	}

	protected PathTooLongException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
