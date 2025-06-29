using System;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class ValidateUnrealEnumFailedException : ManagedUnrealTypeInfoException
{
	public ValidateUnrealEnumFailedException(Type type, string reason)
		: base("Enum validation failed '" + type.FullName + "' Error: " + reason)
	{
	}
}
