using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
public class TypeUnloadedException : SystemException
{
	public TypeUnloadedException()
		: base(Environment.GetResourceString("Arg_TypeUnloadedException"))
	{
		SetErrorCode(-2146234349);
	}

	public TypeUnloadedException(string message)
		: base(message)
	{
		SetErrorCode(-2146234349);
	}

	public TypeUnloadedException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146234349);
	}

	protected TypeUnloadedException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
