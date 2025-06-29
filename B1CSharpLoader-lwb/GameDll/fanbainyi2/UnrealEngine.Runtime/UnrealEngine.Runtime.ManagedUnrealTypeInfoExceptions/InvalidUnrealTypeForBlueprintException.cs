using System.Reflection;

namespace UnrealEngine.Runtime.ManagedUnrealTypeInfoExceptions;

public class InvalidUnrealTypeForBlueprintException : ManagedUnrealTypeInfoException
{
	public InvalidUnrealTypeForBlueprintException(ManagedUnrealTypeInfo typeInfo, MemberInfo member, ManagedUnrealPropertyInfo propertyInfo)
		: base("Unsupported type exposed to blueprint in '" + typeInfo.FullName + "' member: '" + member.Name + "' type: " + propertyInfo.Type.TypeCode.ToString() + " " + (propertyInfo.IsCollection ? " (check supported inner collection types)" : string.Empty))
	{
	}

	public InvalidUnrealTypeForBlueprintException(ManagedUnrealTypeInfo typeInfo, MethodInfo method, ManagedUnrealPropertyInfo propertyInfo)
		: base("Unsupported type exposed to blueprint in '" + typeInfo.FullName + "' function: '" + method.Name + "' param: '" + propertyInfo.Name + " type: " + propertyInfo.Type.TypeCode.ToString() + " " + (propertyInfo.IsCollection ? " (check supported inner collection types)" : string.Empty))
	{
	}
}
