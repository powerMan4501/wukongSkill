using System.Reflection;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class InvalidUnrealFunctionFixedSizeArrayUsedException : InvalidUnrealFunctionException
{
	public InvalidUnrealFunctionFixedSizeArrayUsedException(MethodInfo method)
		: base(method, "Fixed size array used. Fixed size arrays aren't supported on functions.")
	{
	}
}
