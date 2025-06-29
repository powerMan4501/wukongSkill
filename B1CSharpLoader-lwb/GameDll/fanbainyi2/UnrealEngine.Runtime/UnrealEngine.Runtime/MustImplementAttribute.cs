using System;
using System.Reflection;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class MustImplementAttribute : UMetaAttribute
{
	public MustImplementAttribute(Type interfaceType)
		: this(GetInterfaceTypeName(interfaceType))
	{
	}

	public MustImplementAttribute(string interfaceTypeName)
		: base(MDProp.MustImplement, interfaceTypeName)
	{
	}

	private static string GetInterfaceTypeName(Type interfaceType)
	{
		UUnrealTypePathAttribute customAttribute = interfaceType.GetCustomAttribute<UUnrealTypePathAttribute>();
		if (customAttribute != null && !string.IsNullOrEmpty(customAttribute.Path))
		{
			return customAttribute.Path;
		}
		return interfaceType.Name;
	}
}
