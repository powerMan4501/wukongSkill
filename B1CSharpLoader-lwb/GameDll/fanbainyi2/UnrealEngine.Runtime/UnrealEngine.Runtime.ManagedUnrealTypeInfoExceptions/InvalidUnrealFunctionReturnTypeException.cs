using System;
using System.Reflection;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class InvalidUnrealFunctionReturnTypeException : InvalidUnrealFunctionException
{
	public InvalidUnrealFunctionReturnTypeException(MethodInfo method, Type returnType)
		: base(method, "Invalid return type. Type: '" + returnType.FullName + "'")
	{
	}
}
