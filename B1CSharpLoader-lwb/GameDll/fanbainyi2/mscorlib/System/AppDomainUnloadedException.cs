using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
public class AppDomainUnloadedException : SystemException
{
	public AppDomainUnloadedException()
		: base(Environment.GetResourceString("Arg_AppDomainUnloadedException"))
	{
		SetErrorCode(-2146234348);
	}

	public AppDomainUnloadedException(string message)
		: base(message)
	{
		SetErrorCode(-2146234348);
	}

	public AppDomainUnloadedException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146234348);
	}

	protected AppDomainUnloadedException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
