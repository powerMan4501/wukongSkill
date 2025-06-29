using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class DataMisalignedException : SystemException
{
	[__DynamicallyInvokable]
	public DataMisalignedException()
		: base(Environment.GetResourceString("Arg_DataMisalignedException"))
	{
		SetErrorCode(-2146233023);
	}

	[__DynamicallyInvokable]
	public DataMisalignedException(string message)
		: base(message)
	{
		SetErrorCode(-2146233023);
	}

	[__DynamicallyInvokable]
	public DataMisalignedException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233023);
	}

	internal DataMisalignedException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
