using System.Collections.Generic;

namespace System.Linq;

internal static class TypeHelper
{
	internal static bool IsEnumerableType(Type enumerableType)
	{
		return FindGenericType(typeof(IEnumerable<>), enumerableType) != null;
	}

	internal static bool IsKindOfGeneric(Type type, Type definition)
	{
		return FindGenericType(definition, type) != null;
	}

	internal static Type GetElementType(Type enumerableType)
	{
		Type type = FindGenericType(typeof(IEnumerable<>), enumerableType);
		if (type != null)
		{
			return type.GetGenericArguments()[0];
		}
		return enumerableType;
	}

	internal static Type FindGenericType(Type definition, Type type)
	{
		while (type != null && type != typeof(object))
		{
			if (type.IsGenericType && type.GetGenericTypeDefinition() == definition)
			{
				return type;
			}
			if (definition.IsInterface)
			{
				Type[] interfaces = type.GetInterfaces();
				foreach (Type type2 in interfaces)
				{
					Type type3 = FindGenericType(definition, type2);
					if (type3 != null)
					{
						return type3;
					}
				}
			}
			type = type.BaseType;
		}
		return null;
	}

	internal static bool IsNullableType(Type type)
	{
		if (type != null && type.IsGenericType)
		{
			return type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}
		return false;
	}

	internal static Type GetNonNullableType(Type type)
	{
		if (IsNullableType(type))
		{
			return type.GetGenericArguments()[0];
		}
		return type;
	}
}
