using System.Reflection;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class InvalidUnrealFunctionException : ManagedUnrealTypeInfoException
{
	public InvalidUnrealFunctionException(MethodInfo method, string innerMessage)
		: base("Invalid function. '" + method.DeclaringType.FullName + ":" + method.Name + "' Error: " + innerMessage)
	{
	}
}
