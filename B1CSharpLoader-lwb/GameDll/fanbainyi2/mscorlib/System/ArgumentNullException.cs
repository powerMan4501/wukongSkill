using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class ArgumentNullException : ArgumentException
{
	[__DynamicallyInvokable]
	public ArgumentNullException()
		: base(Environment.GetResourceString("ArgumentNull_Generic"))
	{
		SetErrorCode(-2147467261);
	}

	[__DynamicallyInvokable]
	public ArgumentNullException(string paramName)
		: base(Environment.GetResourceString("ArgumentNull_Generic"), paramName)
	{
		SetErrorCode(-2147467261);
	}

	[__DynamicallyInvokable]
	public ArgumentNullException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147467261);
	}

	[__DynamicallyInvokable]
	public ArgumentNullException(string paramName, string message)
		: base(message, paramName)
	{
		SetErrorCode(-2147467261);
	}

	[SecurityCritical]
	protected ArgumentNullException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
