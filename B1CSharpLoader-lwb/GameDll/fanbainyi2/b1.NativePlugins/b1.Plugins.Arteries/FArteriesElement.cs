using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.Arteries;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[UMetaPath("/Script/Arteries.ArteriesElement", "Arteries", UnrealModuleType.GamePlugin)]
public struct FArteriesElement
{
	private static bool FArteriesElement_IsValid;

	private static int FArteriesElement_StructSize;

	public FArteriesElement Copy()
	{
		return this;
	}

	public static FArteriesElement FromNative(IntPtr nativeBuffer)
	{
		return new FArteriesElement(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FArteriesElement value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FArteriesElement FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FArteriesElement(nativeBuffer + arrayIndex * FArteriesElement_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FArteriesElement value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FArteriesElement_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FArteriesElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Arteries.ArteriesElement");
		}
	}

	public FArteriesElement(IntPtr nativeStruct)
	{
		if (!FArteriesElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Arteries.ArteriesElement");
		}
	}

	static FArteriesElement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FArteriesElement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FArteriesElement));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Arteries.ArteriesElement");
		FArteriesElement_StructSize = NativeReflection.GetStructSize(intPtr);
		FArteriesElement_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Arteries.ArteriesElement", FArteriesElement_IsValid);
	}
}
