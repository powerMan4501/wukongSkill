using System;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class ValidateUnrealClassFailedException : ManagedUnrealTypeInfoException
{
	public ValidateUnrealClassFailedException(Type type, string reason)
		: base("Class validation failed '" + type.FullName + "' Error: " + reason)
	{
	}
}
