using System;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class InvalidUnrealDelegateException : ManagedUnrealTypeInfoException
{
	public InvalidUnrealDelegateException(Type delegateType, string innerMessage)
		: base("Invalid delegate. '" + delegateType.FullName + "' Error: " + innerMessage)
	{
	}
}
