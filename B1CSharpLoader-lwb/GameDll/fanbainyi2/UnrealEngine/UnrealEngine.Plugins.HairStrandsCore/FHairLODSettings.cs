using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairLODSettings", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairLODSettings
{
	private static bool FHairLODSettings_IsValid;

	private static int FHairLODSettings_StructSize;

	public FHairLODSettings Copy()
	{
		return this;
	}

	public static FHairLODSettings FromNative(IntPtr nativeBuffer)
	{
		return new FHairLODSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairLODSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairLODSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairLODSettings(nativeBuffer + arrayIndex * FHairLODSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairLODSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairLODSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairLODSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairLODSettings");
		}
	}

	public FHairLODSettings(IntPtr nativeStruct)
	{
		if (!FHairLODSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairLODSettings");
		}
	}

	static FHairLODSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairLODSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairLODSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairLODSettings");
		FHairLODSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairLODSettings_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairLODSettings", FHairLODSettings_IsValid);
	}
}
