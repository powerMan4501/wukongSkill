using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

public class FDelegateMarshaler<T> where T : IDelegateBase, new()
{
	public static T FromNative(IntPtr nativeBuffer)
	{
		T val = new T();
		val.FromNative(nativeBuffer);
		return val;
	}

	public static void ToNative(IntPtr nativeBuffer, T value)
	{
		if (value == null)
		{
			BlittableTypeMarshaler<FScriptDelegate>.ToNative(nativeBuffer, default(FScriptDelegate));
		}
		else
		{
			value.ToNative(nativeBuffer);
		}
	}

	public static T FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		T val = new T();
		val.FromNative(nativeBuffer + arrayIndex * Marshal.SizeOf(typeof(FScriptDelegate)));
		return val;
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, T value)
	{
		if (value == null)
		{
			BlittableTypeMarshaler<FScriptDelegate>.ToNative(nativeBuffer, arrayIndex, prop, default(FScriptDelegate));
		}
		else
		{
			value.ToNative(nativeBuffer + arrayIndex * Marshal.SizeOf(typeof(FScriptDelegate)));
		}
	}
}
