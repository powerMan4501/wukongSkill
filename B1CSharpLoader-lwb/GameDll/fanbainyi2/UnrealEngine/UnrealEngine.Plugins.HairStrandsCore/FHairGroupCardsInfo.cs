using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairGroupCardsInfo", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairGroupCardsInfo
{
	private static bool FHairGroupCardsInfo_IsValid;

	private static int FHairGroupCardsInfo_StructSize;

	public FHairGroupCardsInfo Copy()
	{
		return this;
	}

	public static FHairGroupCardsInfo FromNative(IntPtr nativeBuffer)
	{
		return new FHairGroupCardsInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairGroupCardsInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairGroupCardsInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairGroupCardsInfo(nativeBuffer + arrayIndex * FHairGroupCardsInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairGroupCardsInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairGroupCardsInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairGroupCardsInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupCardsInfo");
		}
	}

	public FHairGroupCardsInfo(IntPtr nativeStruct)
	{
		if (!FHairGroupCardsInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupCardsInfo");
		}
	}

	static FHairGroupCardsInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairGroupCardsInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairGroupCardsInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairGroupCardsInfo");
		FHairGroupCardsInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairGroupCardsInfo_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairGroupCardsInfo", FHairGroupCardsInfo_IsValid);
	}
}
