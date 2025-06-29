using System;

namespace UnrealEngine.Runtime;

public class TLazyObjectMarshaler<T> where T : UObject
{
	public static TLazyObject<T> FromNative(IntPtr nativeBuffer)
	{
		return new TLazyObject<T>(BlittableTypeMarshaler<FLazyObjectPtr>.FromNative(nativeBuffer));
	}

	public static void ToNative(IntPtr nativeBuffer, TLazyObject<T> value)
	{
		BlittableTypeMarshaler<FLazyObjectPtr>.ToNative(nativeBuffer, value.lazyObjectPtr);
	}

	public static TLazyObject<T> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new TLazyObject<T>(BlittableTypeMarshaler<FLazyObjectPtr>.FromNative(nativeBuffer, arrayIndex, prop));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, TLazyObject<T> value)
	{
		BlittableTypeMarshaler<FLazyObjectPtr>.ToNative(nativeBuffer, arrayIndex, prop, value.lazyObjectPtr);
	}
}
