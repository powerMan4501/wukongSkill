using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnrealEngine.Runtime;

public static class MarshalingDelegateResolver<T>
{
	public static readonly MarshalingDelegates<T>.FromNative FromNative;

	public static readonly MarshalingDelegates<T>.ToNative ToNative;

	public static readonly MarshalingDelegates<T>.Destroy Destroy;

	static MarshalingDelegateResolver()
	{
		Type typeFromHandle = typeof(T);
		Type type = null;
		if (typeFromHandle.IsEnum)
		{
			type = typeof(EnumMarshaler<>).MakeGenericType(typeof(T));
		}
		else if (typeFromHandle.IsSameOrSubclassOf(typeof(UObject)))
		{
			type = typeof(UObjectMarshaler<>).MakeGenericType(typeof(T));
		}
		else if (typeFromHandle.IsSameOrSubclassOfGeneric(typeof(FDelegate<>)))
		{
			type = typeof(FDelegateMarshaler<>).MakeGenericType(typeof(T));
		}
		else if (typeFromHandle.IsSameOrSubclassOfGeneric(typeof(FMulticastDelegate<>)))
		{
			type = typeof(FMulticastDelegateMarshaler<>).MakeGenericType(typeof(T));
		}
		else if (typeFromHandle.IsSubclassOf(typeof(StructAsClass)))
		{
			type = typeof(StructAsClassMarshaler<>).MakeGenericType(typeof(T));
		}
		else if (typeFromHandle.IsInterface && typeof(IInterface).IsAssignableFrom(typeFromHandle) && typeFromHandle != typeof(IInterface))
		{
			type = typeof(InterfaceMarshaler<>).MakeGenericType(typeFromHandle);
		}
		else
		{
			type = SimpleMarshalerTypeMap.GetMarshalerType(typeFromHandle);
			if (type != null)
			{
				if (type.IsGenericTypeDefinition)
				{
					type = type.MakeGenericType(typeFromHandle.GetGenericArguments()[0]);
				}
			}
			else if (typeFromHandle.IsValueType)
			{
				type = ((!StructDefault<T>.IsStruct || StructDefault<T>.IsBlittableStruct) ? typeof(BlittableTypeMarshaler<>).MakeGenericType(typeof(T)) : typeof(T));
			}
			else if (typeFromHandle.IsGenericType)
			{
				Type[] interfaces = typeFromHandle.GetGenericTypeDefinition().GetInterfaces();
				for (int i = -1; i < interfaces.Length; i++)
				{
					Type type2 = null;
					type2 = ((i != -1) ? interfaces[i] : (typeFromHandle.IsInterface ? typeFromHandle : null));
					if (type2 != null && type2.IsGenericType)
					{
						Type genericTypeDefinition = type2.GetGenericTypeDefinition();
						if (genericTypeDefinition.IsSameOrSubclassOf(typeof(ISet<>)))
						{
							type = typeof(TSetStaticCopyMarshaler<>).MakeGenericType(typeof(T).GetGenericArguments());
							break;
						}
						if (genericTypeDefinition.IsSameOrSubclassOf(typeof(IDictionary<, >)) || genericTypeDefinition.IsSameOrSubclassOf(typeof(IReadOnlyDictionary<, >)))
						{
							type = typeof(TMapStaticCopyMarshaler<, >).MakeGenericType(typeof(T).GetGenericArguments());
							break;
						}
						if (genericTypeDefinition.IsSameOrSubclassOf(typeof(IList<>)) || genericTypeDefinition.IsSameOrSubclassOf(typeof(IReadOnlyList<>)))
						{
							type = typeof(TArrayStaticCopyMarshaler<>).MakeGenericType(typeof(T).GetGenericArguments());
							break;
						}
					}
				}
			}
		}
		MethodInfo method = type.GetMethod("FromNative", new Type[3]
		{
			typeof(IntPtr),
			typeof(int),
			typeof(IntPtr)
		});
		MethodInfo method2 = type.GetMethod("ToNative", new Type[4]
		{
			typeof(IntPtr),
			typeof(int),
			typeof(IntPtr),
			typeof(T)
		});
		MethodInfo method3 = type.GetMethod("Destroy", new Type[3]
		{
			typeof(IntPtr),
			typeof(int),
			typeof(IntPtr)
		});
		FromNative = (MarshalingDelegates<T>.FromNative)Delegate.CreateDelegate(typeof(MarshalingDelegates<T>.FromNative), method);
		ToNative = (MarshalingDelegates<T>.ToNative)Delegate.CreateDelegate(typeof(MarshalingDelegates<T>.ToNative), method2);
		if (method3 != null)
		{
			Destroy = (MarshalingDelegates<T>.Destroy)Delegate.CreateDelegate(typeof(MarshalingDelegates<T>.Destroy), method3);
		}
	}
}
