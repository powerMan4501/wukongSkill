using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public static class UnrealInterfacePool
{
	private static Dictionary<Type, Type> interfaceTypes = new Dictionary<Type, Type>();

	private static Dictionary<Type, Stack<IInterfaceImpl>> pools = new Dictionary<Type, Stack<IInterfaceImpl>>();

	internal static void LoadType(Type type)
	{
		if (type.IsInterface && UnrealTypes.All.TryGetValue(type, out var value) && value.InterfaceImpl != null && !pools.ContainsKey(value.InterfaceImpl))
		{
			interfaceTypes[type] = value.InterfaceImpl;
			pools[value.InterfaceImpl] = new Stack<IInterfaceImpl>();
		}
	}

	public static IInterface New(Type type, UObjectRef objRef)
	{
		if (interfaceTypes.TryGetValue(type, out var value) && pools.TryGetValue(value, out var value2))
		{
			if (value2.Count > 0)
			{
				IInterfaceImpl interfaceImpl = value2.Pop();
				interfaceImpl.SetObj(objRef);
				return interfaceImpl;
			}
			IInterfaceImpl obj = (IInterfaceImpl)Activator.CreateInstance(value);
			obj.SetObj(objRef);
			return obj;
		}
		return null;
	}

	public static void ReturnObject(IInterface obj)
	{
		if (obj != null && pools.TryGetValue(obj.GetType(), out var value))
		{
			IInterfaceImpl interfaceImpl = (IInterfaceImpl)obj;
			interfaceImpl.ResetInterface();
			interfaceImpl.SetObj(null);
			value.Push(interfaceImpl);
		}
	}
}
