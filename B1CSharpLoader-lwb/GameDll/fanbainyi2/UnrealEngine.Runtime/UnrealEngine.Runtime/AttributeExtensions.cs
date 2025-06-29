using System;
using System.Reflection;

namespace UnrealEngine.Runtime;

public static class AttributeExtensions
{
	public static bool HasCustomAttribute<T>(this MemberInfo element, bool inherit) where T : Attribute
	{
		object[] customAttributes = element.GetCustomAttributes(typeof(T), inherit);
		if (customAttributes != null)
		{
			return customAttributes.Length != 0;
		}
		return false;
	}

	public static bool HasCustomAttribute<T>(this ParameterInfo element, bool inherit) where T : Attribute
	{
		object[] customAttributes = element.GetCustomAttributes(typeof(T), inherit);
		if (customAttributes != null)
		{
			return customAttributes.Length != 0;
		}
		return false;
	}

	public static bool HasCustomAttribute<T>(this Assembly element, bool inherit) where T : Attribute
	{
		object[] customAttributes = element.GetCustomAttributes(typeof(T), inherit);
		if (customAttributes != null)
		{
			return customAttributes.Length != 0;
		}
		return false;
	}

	public static bool HasCustomAttribute<T>(this Module element, bool inherit) where T : Attribute
	{
		object[] customAttributes = element.GetCustomAttributes(typeof(T), inherit);
		if (customAttributes != null)
		{
			return customAttributes.Length != 0;
		}
		return false;
	}
}
