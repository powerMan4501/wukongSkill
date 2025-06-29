using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.ComponentModel.Design;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class CheckoutException : ExternalException
{
	public static readonly CheckoutException Canceled = new CheckoutException(SR.GetString("CHECKOUTCanceled"), -2147467260);

	public CheckoutException()
	{
	}

	public CheckoutException(string message)
		: base(message)
	{
	}

	public CheckoutException(string message, int errorCode)
		: base(message, errorCode)
	{
	}

	protected CheckoutException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public CheckoutException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
