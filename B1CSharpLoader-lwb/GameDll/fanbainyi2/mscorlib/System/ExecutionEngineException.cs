using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[Obsolete("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
[ComVisible(true)]
public sealed class ExecutionEngineException : SystemException
{
	public ExecutionEngineException()
		: base(Environment.GetResourceString("Arg_ExecutionEngineException"))
	{
		SetErrorCode(-2146233082);
	}

	public ExecutionEngineException(string message)
		: base(message)
	{
		SetErrorCode(-2146233082);
	}

	public ExecutionEngineException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233082);
	}

	internal ExecutionEngineException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
