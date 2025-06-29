using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

public class FSoftObjectPathMarshaler
{
	public static FSoftObjectPath FromNative(IntPtr nativeBuffer)
	{
		return new FSoftObjectPath(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoftObjectPath value)
	{
		Destroy(nativeBuffer, 0, IntPtr.Zero);
		BlittableTypeMarshaler<FSoftObjectPathUnsafe>.ToNative(nativeBuffer, new FSoftObjectPathUnsafe(value));
	}

	public static FSoftObjectPath FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoftObjectPath(BlittableTypeMarshaler<FSoftObjectPathUnsafe>.FromNative(nativeBuffer, arrayIndex, prop));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoftObjectPath value)
	{
		Destroy(nativeBuffer, arrayIndex, prop);
		BlittableTypeMarshaler<FSoftObjectPathUnsafe>.ToNative(nativeBuffer, arrayIndex, prop, new FSoftObjectPathUnsafe(value));
	}

	public static void Destroy(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		int num = Marshal.SizeOf(typeof(FSoftObjectPathUnsafe));
		IntPtr intPtr = nativeBuffer + arrayIndex * num;
		Marshal.PtrToStructure<FSoftObjectPathUnsafe>(intPtr).Dispose();
		FMemory.Memset(intPtr, 0, num);
	}
}
