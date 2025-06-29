using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class BoolMarshaler
{
	private static int boolSize = 4;

	public static int BoolSize
	{
		get
		{
			return boolSize;
		}
		private set
		{
			boolSize = value;
		}
	}

	public static bool FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		if (prop == IntPtr.Zero)
		{
			return FromNative(nativeBuffer, arrayIndex, BoolSize);
		}
		return Native_FBoolProperty.GetPropertyValue(prop, nativeBuffer + arrayIndex * Native_FProperty.Get_ElementSize(prop));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, bool value)
	{
		if (prop == IntPtr.Zero)
		{
			ToNative(nativeBuffer, arrayIndex, value, BoolSize);
		}
		else
		{
			Native_FBoolProperty.SetPropertyValue(prop, nativeBuffer + arrayIndex * Native_FProperty.Get_ElementSize(prop), value);
		}
	}

	private static bool FromNative(IntPtr nativeBuffer, int arrayIndex, int size)
	{
		return size switch
		{
			1 => BlittableTypeMarshaler<byte>.FromNative(nativeBuffer, arrayIndex, IntPtr.Zero) != 0, 
			2 => BlittableTypeMarshaler<ushort>.FromNative(nativeBuffer, arrayIndex, IntPtr.Zero) != 0, 
			4 => BlittableTypeMarshaler<uint>.FromNative(nativeBuffer, arrayIndex, IntPtr.Zero) != 0, 
			8 => BlittableTypeMarshaler<ulong>.FromNative(nativeBuffer, arrayIndex, IntPtr.Zero) != 0, 
			_ => throw new NotImplementedException("Unexpected bool size " + size), 
		};
	}

	private static void ToNative(IntPtr nativeBuffer, int arrayIndex, bool value, int size)
	{
		switch (size)
		{
		case 1:
			BlittableTypeMarshaler<byte>.ToNative(nativeBuffer, arrayIndex, IntPtr.Zero, (byte)(value ? byte.MaxValue : 0));
			break;
		case 2:
			BlittableTypeMarshaler<ushort>.ToNative(nativeBuffer, arrayIndex, IntPtr.Zero, (ushort)(value ? ushort.MaxValue : 0));
			break;
		case 4:
			BlittableTypeMarshaler<uint>.ToNative(nativeBuffer, arrayIndex, IntPtr.Zero, value ? uint.MaxValue : 0u);
			break;
		case 8:
			BlittableTypeMarshaler<ulong>.ToNative(nativeBuffer, arrayIndex, IntPtr.Zero, (ulong)(value ? (-1) : 0));
			break;
		default:
			throw new NotImplementedException("Unexpected bool size " + size);
		}
	}

	internal static void OnNativeFunctionsRegistered()
	{
		BoolSize = Native_FBoolProperty.GetBoolSize();
	}
}
