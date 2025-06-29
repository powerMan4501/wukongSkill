using System;

namespace UnrealEngine.Runtime;

public class UObjectMarshaler<T> where T : UObject
{
	public unsafe static T FromNative(IntPtr nativeBuffer)
	{
		return GCHelper.Find<T>((IntPtr)(*(void**)(void*)nativeBuffer));
	}

	public unsafe static void ToNative(IntPtr nativeBuffer, T value)
	{
		IntPtr intPtr = value?.Address ?? IntPtr.Zero;
		*(void**)(void*)nativeBuffer = (void*)intPtr;
	}

	public unsafe static T FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return GCHelper.Find<T>((IntPtr)(*(void**)(void*)(nativeBuffer + arrayIndex * IntPtr.Size)));
	}

	public unsafe static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, T value)
	{
		IntPtr intPtr = nativeBuffer + arrayIndex * IntPtr.Size;
		IntPtr intPtr2 = value?.Address ?? IntPtr.Zero;
		*(void**)(void*)intPtr = (void*)intPtr2;
	}
}
