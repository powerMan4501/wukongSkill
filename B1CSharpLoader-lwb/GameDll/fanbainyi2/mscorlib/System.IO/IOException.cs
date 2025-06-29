using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.IO;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class IOException : SystemException
{
	[NonSerialized]
	private string _maybeFullPath;

	[__DynamicallyInvokable]
	public IOException()
		: base(Environment.GetResourceString("Arg_IOException"))
	{
		SetErrorCode(-2146232800);
	}

	[__DynamicallyInvokable]
	public IOException(string message)
		: base(message)
	{
		SetErrorCode(-2146232800);
	}

	[__DynamicallyInvokable]
	public IOException(string message, int hresult)
		: base(message)
	{
		SetErrorCode(hresult);
	}

	internal IOException(string message, int hresult, string maybeFullPath)
		: base(message)
	{
		SetErrorCode(hresult);
		_maybeFullPath = maybeFullPath;
	}

	[__DynamicallyInvokable]
	public IOException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146232800);
	}

	protected IOException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
