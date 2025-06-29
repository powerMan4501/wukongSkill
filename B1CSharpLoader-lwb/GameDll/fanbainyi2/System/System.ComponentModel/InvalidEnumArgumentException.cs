using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.ComponentModel;

[Serializable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public class InvalidEnumArgumentException : ArgumentException
{
	public InvalidEnumArgumentException()
		: this(null)
	{
	}

	public InvalidEnumArgumentException(string message)
		: base(message)
	{
	}

	public InvalidEnumArgumentException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	public InvalidEnumArgumentException(string argumentName, int invalidValue, Type enumClass)
		: base(SR.GetString("InvalidEnumArgument", argumentName, invalidValue.ToString(CultureInfo.CurrentCulture), enumClass.Name), argumentName)
	{
	}

	protected InvalidEnumArgumentException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
