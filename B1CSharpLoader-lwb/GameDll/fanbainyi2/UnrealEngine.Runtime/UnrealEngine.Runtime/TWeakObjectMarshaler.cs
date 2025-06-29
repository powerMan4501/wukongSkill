using System;

namespace UnrealEngine.Runtime;

public class TWeakObjectMarshaler<T> where T : UObject
{
	public static TWeakObject<T> FromNative(IntPtr nativeBuffer)
	{
		return new TWeakObject<T>(BlittableTypeMarshaler<FWeakObjectPtr>.FromNative(nativeBuffer));
	}

	public static void ToNative(IntPtr nativeBuffer, TWeakObject<T> value)
	{
		BlittableTypeMarshaler<FWeakObjectPtr>.ToNative(nativeBuffer, value.weakObjectPtr);
	}

	public static TWeakObject<T> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new TWeakObject<T>(BlittableTypeMarshaler<FWeakObjectPtr>.FromNative(nativeBuffer, arrayIndex, prop));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, TWeakObject<T> value)
	{
		BlittableTypeMarshaler<FWeakObjectPtr>.ToNative(nativeBuffer, arrayIndex, prop, value.weakObjectPtr);
	}
}
