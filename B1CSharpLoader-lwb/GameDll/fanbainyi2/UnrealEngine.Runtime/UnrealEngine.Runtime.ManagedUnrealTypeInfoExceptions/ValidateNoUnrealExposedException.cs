using System;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class ValidateNoUnrealExposedException : Exception
{
	public ValidateNoUnrealExposedException(string msg)
		: base(msg)
	{
	}
}
