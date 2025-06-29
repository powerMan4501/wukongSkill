using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

internal static class SimpleMarshalerTypeMap
{
	private static Dictionary<Type, Type> marshalerTypeMap;

	public static Type GetMarshalerType(Type type)
	{
		if (type.IsGenericType && !type.IsGenericTypeDefinition)
		{
			type = type.GetGenericTypeDefinition();
		}
		marshalerTypeMap.TryGetValue(type, out var value);
		return value;
	}

	static SimpleMarshalerTypeMap()
	{
		marshalerTypeMap = new Dictionary<Type, Type>();
		marshalerTypeMap.Add(typeof(TSubclassOf<>), typeof(TSubclassOfMarshaler<>));
		marshalerTypeMap.Add(typeof(TSubclassOfInterface<>), typeof(TSubclassOfInterfaceMarshaler<>));
		marshalerTypeMap.Add(typeof(TSoftClass<>), typeof(TSoftClassMarshaler<>));
		marshalerTypeMap.Add(typeof(TSoftObject<>), typeof(TSoftObjectMarshaler<>));
		marshalerTypeMap.Add(typeof(TWeakObject<>), typeof(TWeakObjectMarshaler<>));
		marshalerTypeMap.Add(typeof(TLazyObject<>), typeof(TLazyObjectMarshaler<>));
		marshalerTypeMap.Add(typeof(FSoftObjectPath), typeof(FSoftObjectPathMarshaler));
		marshalerTypeMap.Add(typeof(bool), typeof(BoolMarshaler));
		marshalerTypeMap.Add(typeof(string), typeof(FStringMarshaler));
		marshalerTypeMap.Add(typeof(FText), typeof(FTextMarshaler));
	}
}
