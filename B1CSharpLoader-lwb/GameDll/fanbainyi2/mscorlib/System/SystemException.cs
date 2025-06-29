using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
public class SystemException : Exception
{
	public SystemException()
		: base(Environment.GetResourceString("Arg_SystemException"))
	{
		SetErrorCode(-2146233087);
	}

	public SystemException(string message)
		: base(message)
	{
		SetErrorCode(-2146233087);
	}

	public SystemException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233087);
	}

	protected SystemException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
