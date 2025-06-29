using System;
using System.Reflection;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class InvalidManagedUnrealAttributeException : ManagedUnrealTypeInfoException
{
	public InvalidManagedUnrealAttributeException(Type type, ManagedUnrealAttributeBase attribute)
		: base("Failed to handle attribute on type '" + type.FullName + "' Reason: " + attribute.InvalidTargetReason)
	{
	}

	public InvalidManagedUnrealAttributeException(MethodInfo method, ManagedUnrealAttributeBase attribute)
		: base("Failed to handle attribute on method '" + method.DeclaringType.FullName + ":" + method.Name + "' Reason: " + attribute.InvalidTargetReason)
	{
	}

	public InvalidManagedUnrealAttributeException(MemberInfo member, ManagedUnrealAttributeBase attribute)
		: base("Failed to handle attribute on member '" + member.DeclaringType.FullName + ":" + member.Name + "' Reason: " + attribute.InvalidTargetReason)
	{
	}

	public InvalidManagedUnrealAttributeException(MethodInfo method, ParameterInfo parameter, ManagedUnrealAttributeBase attribute)
		: base("Failed to handle attribute on parameter '" + method.DeclaringType.FullName + ":" + method?.ToString() + "." + parameter.Name + "' Reason: " + attribute.InvalidTargetReason)
	{
	}
}
