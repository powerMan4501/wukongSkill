using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
public class CustomAttributeFormatException : FormatException
{
	public CustomAttributeFormatException()
		: base(Environment.GetResourceString("Arg_CustomAttributeFormatException"))
	{
		SetErrorCode(-2146232827);
	}

	public CustomAttributeFormatException(string message)
		: base(message)
	{
		SetErrorCode(-2146232827);
	}

	public CustomAttributeFormatException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146232827);
	}

	protected CustomAttributeFormatException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
