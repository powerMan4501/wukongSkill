using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

public class TSoftClassMarshaler<T> where T : UObject
{
	public static TSoftClass<T> FromNative(IntPtr nativeBuffer)
	{
		return new TSoftClass<T>(BlittableTypeMarshaler<FSoftObjectPtrUnsafe>.FromNative(nativeBuffer).ObjectPath);
	}

	public static void ToNative(IntPtr nativeBuffer, TSoftClass<T> value)
	{
		Destroy(nativeBuffer, 0, IntPtr.Zero);
		BlittableTypeMarshaler<FSoftObjectPtrUnsafe>.ToNative(nativeBuffer, new FSoftObjectPtrUnsafe(value.ObjectPath));
	}

	public static TSoftClass<T> FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new TSoftClass<T>(BlittableTypeMarshaler<FSoftObjectPtrUnsafe>.FromNative(nativeBuffer, arrayIndex, prop).ObjectPath);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, TSoftClass<T> value)
	{
		Destroy(nativeBuffer, arrayIndex, prop);
		BlittableTypeMarshaler<FSoftObjectPtrUnsafe>.ToNative(nativeBuffer, arrayIndex, prop, new FSoftObjectPtrUnsafe(value.ObjectPath));
	}

	public static void Destroy(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		int num = Marshal.SizeOf(typeof(FSoftObjectPtrUnsafe));
		IntPtr intPtr = nativeBuffer + arrayIndex * num;
		Marshal.PtrToStructure<FSoftObjectPtrUnsafe>(intPtr).Dispose();
		FMemory.Memset(intPtr, 0, num);
	}
}
