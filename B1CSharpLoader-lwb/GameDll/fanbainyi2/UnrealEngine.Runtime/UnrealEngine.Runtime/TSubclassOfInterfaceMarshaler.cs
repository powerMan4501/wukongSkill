using System;

namespace UnrealEngine.Runtime;

public class TSubclassOfInterfaceMarshaler<T> where T : class, IInterface
{
	public static TSubclassOfInterface<T> FromNative(IntPtr nativeBuffer)
	{
		return new TSubclassOfInterface<T>(BlittableTypeMarshaler<FSubclassOf>.FromNative(nativeBuffer).Class);
	}

	public static void ToNative(IntPtr nativeBuffer, TSubclassOfInterface<T> value)
	{
		BlittableTypeMarshaler<FSubclassOf>.ToNative(nativeBuffer, value.subclassOf);
	}

	public static TSubclassOfInterface<T> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new TSubclassOfInterface<T>(BlittableTypeMarshaler<FSubclassOf>.FromNative(nativeBuffer, arrayIndex, prop).Class);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, TSubclassOfInterface<T> value)
	{
		BlittableTypeMarshaler<FSubclassOf>.ToNative(nativeBuffer, arrayIndex, prop, value.subclassOf);
	}
}
