using System;

namespace UnrealEngine.Runtime;

public class TSubclassOfMarshaler<T> where T : UObject
{
	public static TSubclassOf<T> FromNative(IntPtr nativeBuffer)
	{
		return new TSubclassOf<T>(BlittableTypeMarshaler<FSubclassOf>.FromNative(nativeBuffer).Class);
	}

	public static void ToNative(IntPtr nativeBuffer, TSubclassOf<T> value)
	{
		BlittableTypeMarshaler<FSubclassOf>.ToNative(nativeBuffer, value.subclassOf);
	}

	public static TSubclassOf<T> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new TSubclassOf<T>(BlittableTypeMarshaler<FSubclassOf>.FromNative(nativeBuffer, arrayIndex, prop).Class);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, TSubclassOf<T> value)
	{
		BlittableTypeMarshaler<FSubclassOf>.ToNative(nativeBuffer, arrayIndex, prop, value.subclassOf);
	}
}
