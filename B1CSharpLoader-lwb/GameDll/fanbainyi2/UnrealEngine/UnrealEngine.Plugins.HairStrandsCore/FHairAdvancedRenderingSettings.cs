using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairAdvancedRenderingSettings", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairAdvancedRenderingSettings
{
	private static bool UseStableRasterization_IsValid;

	private static FFieldAddress UseStableRasterization_PropertyAddress;

	private static int UseStableRasterization_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/HairStrandsCore.HairAdvancedRenderingSettings:bUseStableRasterization")]
	public bool UseStableRasterization;

	private static bool ScatterSceneLighting_IsValid;

	private static FFieldAddress ScatterSceneLighting_PropertyAddress;

	private static int ScatterSceneLighting_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/HairStrandsCore.HairAdvancedRenderingSettings:bScatterSceneLighting")]
	public bool ScatterSceneLighting;

	private static bool FHairAdvancedRenderingSettings_IsValid;

	private static int FHairAdvancedRenderingSettings_StructSize;

	public FHairAdvancedRenderingSettings Copy()
	{
		return this;
	}

	public static FHairAdvancedRenderingSettings FromNative(IntPtr nativeBuffer)
	{
		return new FHairAdvancedRenderingSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairAdvancedRenderingSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairAdvancedRenderingSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairAdvancedRenderingSettings(nativeBuffer + arrayIndex * FHairAdvancedRenderingSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairAdvancedRenderingSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairAdvancedRenderingSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairAdvancedRenderingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairAdvancedRenderingSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseStableRasterization_Offset), 0, UseStableRasterization_PropertyAddress.Address, UseStableRasterization);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ScatterSceneLighting_Offset), 0, ScatterSceneLighting_PropertyAddress.Address, ScatterSceneLighting);
	}

	public FHairAdvancedRenderingSettings(IntPtr nativeStruct)
	{
		if (!FHairAdvancedRenderingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairAdvancedRenderingSettings");
			UseStableRasterization = false;
			ScatterSceneLighting = false;
		}
		else
		{
			UseStableRasterization = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseStableRasterization_Offset), 0, UseStableRasterization_PropertyAddress.Address);
			ScatterSceneLighting = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ScatterSceneLighting_Offset), 0, ScatterSceneLighting_PropertyAddress.Address);
		}
	}

	static FHairAdvancedRenderingSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairAdvancedRenderingSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairAdvancedRenderingSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairAdvancedRenderingSettings");
		FHairAdvancedRenderingSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref UseStableRasterization_PropertyAddress, intPtr, "bUseStableRasterization");
		UseStableRasterization_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseStableRasterization");
		UseStableRasterization_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseStableRasterization", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterSceneLighting_PropertyAddress, intPtr, "bScatterSceneLighting");
		ScatterSceneLighting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bScatterSceneLighting");
		ScatterSceneLighting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bScatterSceneLighting", Classes.FBoolProperty);
		FHairAdvancedRenderingSettings_IsValid = intPtr != IntPtr.Zero && UseStableRasterization_IsValid && ScatterSceneLighting_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairAdvancedRenderingSettings", FHairAdvancedRenderingSettings_IsValid);
	}
}
