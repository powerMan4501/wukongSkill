using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public static class MarshalingDelegateResolverSlow
{
	private static Dictionary<Type, Delegate> FromNative = new Dictionary<Type, Delegate>();

	private static Dictionary<Type, Delegate> ToNative = new Dictionary<Type, Delegate>();

	private static Dictionary<Type, Delegate> Destroy = new Dictionary<Type, Delegate>();

	public static Delegate GetFromNative(Type type)
	{
		return GetDelegate(type, FromNative);
	}

	public static Delegate GetToNative(Type type)
	{
		return GetDelegate(type, ToNative);
	}

	public static Delegate GetDestroy(Type type)
	{
		return GetDelegate(type, Destroy);
	}

	private static Delegate GetDelegate(Type type, Dictionary<Type, Delegate> collection)
	{
		if (!collection.TryGetValue(type, out var value))
		{
			ProcessType(type);
			collection.TryGetValue(type, out value);
		}
		return value;
	}

	private static void ProcessType(Type type)
	{
		Type type2 = typeof(MarshalingDelegateResolver<>).MakeGenericType(type);
		FromNative.Add(type, type2.GetField("FromNative").GetValue(null) as Delegate);
		ToNative.Add(type, type2.GetField("ToNative").GetValue(null) as Delegate);
		Destroy.Add(type, type2.GetField("Destroy").GetValue(null) as Delegate);
	}
}
