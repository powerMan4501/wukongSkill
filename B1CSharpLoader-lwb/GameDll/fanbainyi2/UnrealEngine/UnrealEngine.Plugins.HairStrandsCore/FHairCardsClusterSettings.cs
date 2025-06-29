using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairCardsClusterSettings", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairCardsClusterSettings
{
	private static bool FHairCardsClusterSettings_IsValid;

	private static int FHairCardsClusterSettings_StructSize;

	public FHairCardsClusterSettings Copy()
	{
		return this;
	}

	public static FHairCardsClusterSettings FromNative(IntPtr nativeBuffer)
	{
		return new FHairCardsClusterSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairCardsClusterSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairCardsClusterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairCardsClusterSettings(nativeBuffer + arrayIndex * FHairCardsClusterSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairCardsClusterSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairCardsClusterSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairCardsClusterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairCardsClusterSettings");
		}
	}

	public FHairCardsClusterSettings(IntPtr nativeStruct)
	{
		if (!FHairCardsClusterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairCardsClusterSettings");
		}
	}

	static FHairCardsClusterSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairCardsClusterSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairCardsClusterSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairCardsClusterSettings");
		FHairCardsClusterSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairCardsClusterSettings_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairCardsClusterSettings", FHairCardsClusterSettings_IsValid);
	}
}
