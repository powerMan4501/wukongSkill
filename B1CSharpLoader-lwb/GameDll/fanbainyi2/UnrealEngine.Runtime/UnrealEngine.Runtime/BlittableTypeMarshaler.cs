using System;

namespace UnrealEngine.Runtime;

public class BlittableTypeMarshaler<T> where T : unmanaged
{
	private unsafe static readonly int TSize = sizeof(T);

	public unsafe static T FromNative(IntPtr nativeBuffer)
	{
		return *(T*)(void*)nativeBuffer;
	}

	public unsafe static void ToNative(IntPtr nativeBuffer, T value)
	{
		*(T*)(void*)nativeBuffer = value;
	}

	public unsafe static T FromNative(IntPtr nativeBuffer, int arrayIndex)
	{
		return ((T*)(void*)nativeBuffer)[arrayIndex];
	}

	public unsafe static void ToNative(IntPtr nativeBuffer, int arrayIndex, T value)
	{
		((T*)(void*)nativeBuffer)[arrayIndex] = value;
	}

	public unsafe static T FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return ((T*)(void*)nativeBuffer)[arrayIndex];
	}

	public unsafe static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, T value)
	{
		((T*)(void*)nativeBuffer)[arrayIndex] = value;
	}
}
