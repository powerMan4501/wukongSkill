using System;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class UnrealTypeGenericsNotSupportedException : ManagedUnrealTypeInfoException
{
	public UnrealTypeGenericsNotSupportedException(Type type)
		: base("The type '" + type?.ToString() + "' uses generics and cannot be exported to unreal")
	{
	}
}
