using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class DirectoryNotFoundException : IOException
{
	[__DynamicallyInvokable]
	public DirectoryNotFoundException()
		: base(Environment.GetResourceString("Arg_DirectoryNotFoundException"))
	{
		SetErrorCode(-2147024893);
	}

	[__DynamicallyInvokable]
	public DirectoryNotFoundException(string message)
		: base(message)
	{
		SetErrorCode(-2147024893);
	}

	[__DynamicallyInvokable]
	public DirectoryNotFoundException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147024893);
	}

	protected DirectoryNotFoundException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
