using System;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class ManagedUnrealTypeInfoException : Exception
{
	public ManagedUnrealTypeInfoException(string message)
		: base(message)
	{
	}
}
