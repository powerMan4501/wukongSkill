using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

[Serializable]
[ComVisible(true)]
public class InvalidFilterCriteriaException : ApplicationException
{
	public InvalidFilterCriteriaException()
		: base(Environment.GetResourceString("Arg_InvalidFilterCriteriaException"))
	{
		SetErrorCode(-2146232831);
	}

	public InvalidFilterCriteriaException(string message)
		: base(message)
	{
		SetErrorCode(-2146232831);
	}

	public InvalidFilterCriteriaException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146232831);
	}

	protected InvalidFilterCriteriaException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
