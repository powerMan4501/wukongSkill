using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class TFixedSizeArrayMarshaler<T>
{
	private static readonly MarshalingDelegates<T>.FromNative fromNative = MarshalingDelegateResolver<T>.FromNative;

	private static readonly MarshalingDelegates<T>.ToNative toNative = MarshalingDelegateResolver<T>.ToNative;

	public static T[] FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		int num = Native_FProperty.Get_ArrayDim(prop);
		T[] array = new T[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = fromNative(nativeBuffer, i, prop);
		}
		return array;
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, T[] value)
	{
		int num = Native_FProperty.Get_ArrayDim(prop);
		for (int i = 0; i < num; i++)
		{
			toNative(nativeBuffer, i, prop, (value == null || i >= value.Length) ? StructDefault<T>.Value : value[i]);
		}
	}
}
