using System;

namespace UnrealEngine.Runtime;

public class FTextMarshaler
{
	public static FText FromNative(IntPtr nativeBuffer)
	{
		return FromNative(nativeBuffer, 0, IntPtr.Zero);
	}

	public static FText FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return FText.FromNative(nativeBuffer + arrayIndex * FText.FTextNative.StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, FText value)
	{
		ToNative(nativeBuffer, 0, IntPtr.Zero, value);
	}

	public unsafe static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FText value)
	{
		FText.FTextNative* ptr = (FText.FTextNative*)(void*)value.Address;
		FText.FTextNative* ptr2 = (FText.FTextNative*)(void*)(nativeBuffer + arrayIndex * FText.FTextNative.StructSize);
		ptr2->TextData.ReleaseSharedReference(ESPMode.ThreadSafe);
		*ptr2 = *ptr;
		ptr2->TextData.AddSharedReference(ESPMode.ThreadSafe);
	}
}
