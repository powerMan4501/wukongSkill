using System.Reflection;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class ValidateUnrealPropertyFailedException : ManagedUnrealTypeInfoException
{
	public ValidateUnrealPropertyFailedException(MemberInfo member, string reason)
		: base("Property validation failed. '" + member.DeclaringType.FullName + ":" + member.Name + "' Error: " + reason)
	{
	}
}
