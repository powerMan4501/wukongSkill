using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairDecimationSettings", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairDecimationSettings
{
	private static bool FHairDecimationSettings_IsValid;

	private static int FHairDecimationSettings_StructSize;

	public FHairDecimationSettings Copy()
	{
		return this;
	}

	public static FHairDecimationSettings FromNative(IntPtr nativeBuffer)
	{
		return new FHairDecimationSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairDecimationSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairDecimationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairDecimationSettings(nativeBuffer + arrayIndex * FHairDecimationSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairDecimationSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairDecimationSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairDecimationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairDecimationSettings");
		}
	}

	public FHairDecimationSettings(IntPtr nativeStruct)
	{
		if (!FHairDecimationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairDecimationSettings");
		}
	}

	static FHairDecimationSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairDecimationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairDecimationSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairDecimationSettings");
		FHairDecimationSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairDecimationSettings_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairDecimationSettings", FHairDecimationSettings_IsValid);
	}
}
