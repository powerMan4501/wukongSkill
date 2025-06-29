using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairShadowSettings", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairShadowSettings
{
	private static bool HairShadowDensity_IsValid;

	private static int HairShadowDensity_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/HairStrandsCore.HairShadowSettings:HairShadowDensity")]
	public float HairShadowDensity;

	private static bool HairRaytracingRadiusScale_IsValid;

	private static int HairRaytracingRadiusScale_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/HairStrandsCore.HairShadowSettings:HairRaytracingRadiusScale")]
	public float HairRaytracingRadiusScale;

	private static bool UseHairRaytracingGeometry_IsValid;

	private static FFieldAddress UseHairRaytracingGeometry_PropertyAddress;

	private static int UseHairRaytracingGeometry_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/HairStrandsCore.HairShadowSettings:bUseHairRaytracingGeometry")]
	public bool UseHairRaytracingGeometry;

	private static bool Voxelize_IsValid;

	private static FFieldAddress Voxelize_PropertyAddress;

	private static int Voxelize_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/HairStrandsCore.HairShadowSettings:bVoxelize")]
	public bool Voxelize;

	private static bool FHairShadowSettings_IsValid;

	private static int FHairShadowSettings_StructSize;

	public FHairShadowSettings Copy()
	{
		return this;
	}

	public static FHairShadowSettings FromNative(IntPtr nativeBuffer)
	{
		return new FHairShadowSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairShadowSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairShadowSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairShadowSettings(nativeBuffer + arrayIndex * FHairShadowSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairShadowSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairShadowSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairShadowSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairShadowSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HairShadowDensity_Offset), HairShadowDensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HairRaytracingRadiusScale_Offset), HairRaytracingRadiusScale);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseHairRaytracingGeometry_Offset), 0, UseHairRaytracingGeometry_PropertyAddress.Address, UseHairRaytracingGeometry);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Voxelize_Offset), 0, Voxelize_PropertyAddress.Address, Voxelize);
	}

	public FHairShadowSettings(IntPtr nativeStruct)
	{
		if (!FHairShadowSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairShadowSettings");
			HairShadowDensity = 0f;
			HairRaytracingRadiusScale = 0f;
			UseHairRaytracingGeometry = false;
			Voxelize = false;
		}
		else
		{
			HairShadowDensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HairShadowDensity_Offset));
			HairRaytracingRadiusScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HairRaytracingRadiusScale_Offset));
			UseHairRaytracingGeometry = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseHairRaytracingGeometry_Offset), 0, UseHairRaytracingGeometry_PropertyAddress.Address);
			Voxelize = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Voxelize_Offset), 0, Voxelize_PropertyAddress.Address);
		}
	}

	static FHairShadowSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairShadowSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairShadowSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairShadowSettings");
		FHairShadowSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		HairShadowDensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairShadowDensity");
		HairShadowDensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairShadowDensity", Classes.FFloatProperty);
		HairRaytracingRadiusScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairRaytracingRadiusScale");
		HairRaytracingRadiusScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairRaytracingRadiusScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseHairRaytracingGeometry_PropertyAddress, intPtr, "bUseHairRaytracingGeometry");
		UseHairRaytracingGeometry_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseHairRaytracingGeometry");
		UseHairRaytracingGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseHairRaytracingGeometry", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Voxelize_PropertyAddress, intPtr, "bVoxelize");
		Voxelize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bVoxelize");
		Voxelize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bVoxelize", Classes.FBoolProperty);
		FHairShadowSettings_IsValid = intPtr != IntPtr.Zero && HairShadowDensity_IsValid && HairRaytracingRadiusScale_IsValid && UseHairRaytracingGeometry_IsValid && Voxelize_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairShadowSettings", FHairShadowSettings_IsValid);
	}
}
