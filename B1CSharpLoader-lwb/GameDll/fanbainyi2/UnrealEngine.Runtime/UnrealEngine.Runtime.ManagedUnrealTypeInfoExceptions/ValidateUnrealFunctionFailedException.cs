using System.Reflection;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class ValidateUnrealFunctionFailedException : InvalidUnrealFunctionException
{
	public ValidateUnrealFunctionFailedException(MethodInfo method, string reason)
		: base(method, "Function validation failed - " + reason)
	{
	}
}
