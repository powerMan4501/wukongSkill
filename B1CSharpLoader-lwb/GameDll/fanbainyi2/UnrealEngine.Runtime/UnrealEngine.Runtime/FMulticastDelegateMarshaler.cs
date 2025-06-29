using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

public class FMulticastDelegateMarshaler<T> where T : IDelegateBase, new()
{
	public static T FromNative(IntPtr nativeBuffer)
	{
		T val = new T();
		val.FromNative(nativeBuffer);
		return val;
	}

	public unsafe static void ToNative(IntPtr nativeBuffer, T value)
	{
		if (value == null)
		{
			((FMulticastScriptDelegate*)(void*)nativeBuffer)->InvocationList.Destroy();
		}
		else
		{
			value.ToNative(nativeBuffer);
		}
	}

	public static T FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		T val = new T();
		val.FromNative(nativeBuffer + arrayIndex * Marshal.SizeOf(typeof(FMulticastScriptDelegate)));
		return val;
	}

	public unsafe static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, T value)
	{
		if (value == null)
		{
			((FMulticastScriptDelegate*)(void*)(nativeBuffer + arrayIndex * Marshal.SizeOf(typeof(FMulticastScriptDelegate))))->InvocationList.Destroy();
		}
		else
		{
			value.ToNative(nativeBuffer + arrayIndex * Marshal.SizeOf(typeof(FMulticastScriptDelegate)));
		}
	}
}
