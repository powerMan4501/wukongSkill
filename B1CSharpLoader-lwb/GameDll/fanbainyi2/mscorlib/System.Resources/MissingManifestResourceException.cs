using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Resources;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class MissingManifestResourceException : SystemException
{
	[__DynamicallyInvokable]
	public MissingManifestResourceException()
		: base(Environment.GetResourceString("Arg_MissingManifestResourceException"))
	{
		SetErrorCode(-2146233038);
	}

	[__DynamicallyInvokable]
	public MissingManifestResourceException(string message)
		: base(message)
	{
		SetErrorCode(-2146233038);
	}

	[__DynamicallyInvokable]
	public MissingManifestResourceException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233038);
	}

	protected MissingManifestResourceException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
