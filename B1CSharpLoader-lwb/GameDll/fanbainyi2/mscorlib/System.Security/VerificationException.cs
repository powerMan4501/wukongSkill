using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class VerificationException : SystemException
{
	[__DynamicallyInvokable]
	public VerificationException()
		: base(Environment.GetResourceString("Verification_Exception"))
	{
		SetErrorCode(-2146233075);
	}

	[__DynamicallyInvokable]
	public VerificationException(string message)
		: base(message)
	{
		SetErrorCode(-2146233075);
	}

	[__DynamicallyInvokable]
	public VerificationException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233075);
	}

	protected VerificationException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
