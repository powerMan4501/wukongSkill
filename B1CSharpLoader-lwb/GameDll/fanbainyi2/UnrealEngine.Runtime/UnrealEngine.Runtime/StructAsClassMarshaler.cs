using System;

namespace UnrealEngine.Runtime;

public class StructAsClassMarshaler<T> where T : StructAsClass, new()
{
	private static int StructSize = StructDefault<T>.Size;

	public static T FromNative(IntPtr nativeBuffer)
	{
		T val = new T();
		val.Initialize();
		val.InternalCopyFrom(nativeBuffer);
		return val;
	}

	public static void ToNative(IntPtr nativeBuffer, T value)
	{
		if (value == null)
		{
			using (T val = StructDefault<T>.Value)
			{
				val.InternalCopyTo(nativeBuffer);
				return;
			}
		}
		value.InternalCopyTo(nativeBuffer);
	}

	public static T FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return FromNative(IntPtr.Add(nativeBuffer, StructSize * arrayIndex));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, T value)
	{
		ToNative(IntPtr.Add(nativeBuffer, StructSize * arrayIndex), value);
	}

	public static void CopyFromNative(IntPtr nativeBuffer, ref T value)
	{
		if (value == null)
		{
			value = new T();
			value.Initialize();
		}
		value.InternalCopyFrom(nativeBuffer);
	}

	public static void CopyFromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, ref T value)
	{
		T val = value;
		val.InternalCopyFrom(nativeBuffer + StructSize * arrayIndex);
	}
}
