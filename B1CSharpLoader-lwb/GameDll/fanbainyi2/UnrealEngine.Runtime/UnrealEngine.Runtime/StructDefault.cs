using System;
using System.Reflection;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class StructDefault<T>
{
	private static IntPtr unrealStruct;

	private static int structSize;

	private static bool isLoaded;

	private static bool useDefaultT;

	private static readonly string structPath;

	private static readonly MarshalingDelegates<T>.FromNative fromNative;

	public static readonly bool IsStruct;

	public static readonly bool IsStructAsClass;

	public static readonly bool IsBlittableStruct;

	public static int Size
	{
		get
		{
			if (!isLoaded)
			{
				Load();
			}
			return structSize;
		}
	}

	public unsafe static T Value
	{
		get
		{
			if (useDefaultT)
			{
				return default(T);
			}
			if (!isLoaded)
			{
				Load();
				if (!isLoaded || useDefaultT)
				{
					return default(T);
				}
			}
			if (IsStructAsClass)
			{
				IntPtr intPtr = FMemory.Malloc(structSize);
				Native_UStruct.InitializeStruct(unrealStruct, intPtr, 1);
				return fromNative(intPtr, 0, IntPtr.Zero);
			}
			IntPtr intPtr2 = (IntPtr)stackalloc byte[(int)(uint)structSize];
			Native_UStruct.InitializeStruct(unrealStruct, intPtr2, 1);
			T result = fromNative(intPtr2, 0, IntPtr.Zero);
			Native_UStruct.DestroyStruct(unrealStruct, intPtr2, 1);
			return result;
		}
	}

	private static void Load()
	{
		unrealStruct = UScriptStruct.ResolveStructAddress(structPath);
		if (unrealStruct != IntPtr.Zero)
		{
			isLoaded = true;
			structSize = NativeReflection.GetStructSize(unrealStruct);
			if (!IsStructAsClass && UScriptStruct.IsPODZeroInit(unrealStruct))
			{
				useDefaultT = true;
			}
		}
	}

	static StructDefault()
	{
		Type typeFromHandle = typeof(T);
		IsStructAsClass = typeFromHandle.IsSubclassOf(typeof(StructAsClass));
		if (!typeFromHandle.IsValueType && !IsStructAsClass)
		{
			useDefaultT = true;
			return;
		}
		UUnrealTypePathAttribute value = UnrealTypes.GetPathAttribute(typeFromHandle);
		if (UnrealTypes.All.TryGetValue(typeFromHandle, out value) && !string.IsNullOrEmpty(value.Path))
		{
			structPath = value.Path;
		}
		IsStruct = !string.IsNullOrEmpty(structPath);
		if (IsStructAsClass)
		{
			useDefaultT = false;
			fromNative = MarshalingDelegateResolver<T>.FromNative;
			return;
		}
		if (!IsStruct)
		{
			useDefaultT = true;
			return;
		}
		MethodInfo[] methods = typeFromHandle.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public);
		foreach (MethodInfo methodInfo in methods)
		{
			if (methodInfo.Name == "FromNative" && methodInfo.GetParameters().Length == 3)
			{
				fromNative = (MarshalingDelegates<T>.FromNative)Delegate.CreateDelegate(typeof(MarshalingDelegates<T>.FromNative), methodInfo);
				break;
			}
		}
		if (fromNative != null)
		{
			IsBlittableStruct = false;
		}
		else
		{
			IsBlittableStruct = true;
		}
	}
}
