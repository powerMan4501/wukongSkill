using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
public class CannotUnloadAppDomainException : SystemException
{
	public CannotUnloadAppDomainException()
		: base(Environment.GetResourceString("Arg_CannotUnloadAppDomainException"))
	{
		SetErrorCode(-2146234347);
	}

	public CannotUnloadAppDomainException(string message)
		: base(message)
	{
		SetErrorCode(-2146234347);
	}

	public CannotUnloadAppDomainException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146234347);
	}

	protected CannotUnloadAppDomainException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
