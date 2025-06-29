using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairGroupCardsTextures", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairGroupCardsTextures
{
	private static bool FHairGroupCardsTextures_IsValid;

	private static int FHairGroupCardsTextures_StructSize;

	public FHairGroupCardsTextures Copy()
	{
		return this;
	}

	public static FHairGroupCardsTextures FromNative(IntPtr nativeBuffer)
	{
		return new FHairGroupCardsTextures(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairGroupCardsTextures value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairGroupCardsTextures FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairGroupCardsTextures(nativeBuffer + arrayIndex * FHairGroupCardsTextures_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairGroupCardsTextures value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairGroupCardsTextures_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairGroupCardsTextures_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupCardsTextures");
		}
	}

	public FHairGroupCardsTextures(IntPtr nativeStruct)
	{
		if (!FHairGroupCardsTextures_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupCardsTextures");
		}
	}

	static FHairGroupCardsTextures()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairGroupCardsTextures)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairGroupCardsTextures));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairGroupCardsTextures");
		FHairGroupCardsTextures_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairGroupCardsTextures_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairGroupCardsTextures", FHairGroupCardsTextures_IsValid);
	}
}
