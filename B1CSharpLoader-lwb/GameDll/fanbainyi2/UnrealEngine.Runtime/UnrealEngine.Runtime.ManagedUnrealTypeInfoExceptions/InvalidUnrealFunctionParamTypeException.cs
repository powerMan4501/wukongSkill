using System.Reflection;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class InvalidUnrealFunctionParamTypeException : InvalidUnrealFunctionException
{
	public InvalidUnrealFunctionParamTypeException(MethodInfo method, ParameterInfo paramInfo)
		: base(method, "Invalid param type. Param: '" + paramInfo.Name + "' Type: " + paramInfo.ParameterType.FullName)
	{
	}
}
