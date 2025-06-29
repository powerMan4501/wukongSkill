using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.GroomBuildSettings", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FGroomBuildSettings
{
	private static bool OverrideGuides_IsValid;

	private static FFieldAddress OverrideGuides_PropertyAddress;

	private static int OverrideGuides_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBuildSettings:bOverrideGuides")]
	public bool OverrideGuides;

	private static bool HairToGuideDensity_IsValid;

	private static int HairToGuideDensity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBuildSettings:HairToGuideDensity")]
	public float HairToGuideDensity;

	private static bool InterpolationQuality_IsValid;

	private static FFieldAddress InterpolationQuality_PropertyAddress;

	private static int InterpolationQuality_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBuildSettings:InterpolationQuality")]
	public EGroomInterpolationQuality InterpolationQuality;

	private static bool InterpolationDistance_IsValid;

	private static FFieldAddress InterpolationDistance_PropertyAddress;

	private static int InterpolationDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBuildSettings:InterpolationDistance")]
	public EGroomInterpolationWeight InterpolationDistance;

	private static bool RandomizeGuide_IsValid;

	private static FFieldAddress RandomizeGuide_PropertyAddress;

	private static int RandomizeGuide_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBuildSettings:bRandomizeGuide")]
	public bool RandomizeGuide;

	private static bool UseUniqueGuide_IsValid;

	private static FFieldAddress UseUniqueGuide_PropertyAddress;

	private static int UseUniqueGuide_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomBuildSettings:bUseUniqueGuide")]
	public bool UseUniqueGuide;

	private static bool FGroomBuildSettings_IsValid;

	private static int FGroomBuildSettings_StructSize;

	public FGroomBuildSettings Copy()
	{
		return this;
	}

	public static FGroomBuildSettings FromNative(IntPtr nativeBuffer)
	{
		return new FGroomBuildSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGroomBuildSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGroomBuildSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGroomBuildSettings(nativeBuffer + arrayIndex * FGroomBuildSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGroomBuildSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGroomBuildSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGroomBuildSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.GroomBuildSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OverrideGuides_Offset), 0, OverrideGuides_PropertyAddress.Address, OverrideGuides);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HairToGuideDensity_Offset), HairToGuideDensity);
		EnumMarshaler<EGroomInterpolationQuality>.ToNative(IntPtr.Add(nativeStruct, InterpolationQuality_Offset), 0, InterpolationQuality_PropertyAddress.Address, InterpolationQuality);
		EnumMarshaler<EGroomInterpolationWeight>.ToNative(IntPtr.Add(nativeStruct, InterpolationDistance_Offset), 0, InterpolationDistance_PropertyAddress.Address, InterpolationDistance);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RandomizeGuide_Offset), 0, RandomizeGuide_PropertyAddress.Address, RandomizeGuide);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseUniqueGuide_Offset), 0, UseUniqueGuide_PropertyAddress.Address, UseUniqueGuide);
	}

	public FGroomBuildSettings(IntPtr nativeStruct)
	{
		if (!FGroomBuildSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.GroomBuildSettings");
			OverrideGuides = false;
			HairToGuideDensity = 0f;
			InterpolationQuality = EGroomInterpolationQuality.Low;
			InterpolationDistance = EGroomInterpolationWeight.Parametric;
			RandomizeGuide = false;
			UseUniqueGuide = false;
		}
		else
		{
			OverrideGuides = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OverrideGuides_Offset), 0, OverrideGuides_PropertyAddress.Address);
			HairToGuideDensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HairToGuideDensity_Offset));
			InterpolationQuality = EnumMarshaler<EGroomInterpolationQuality>.FromNative(IntPtr.Add(nativeStruct, InterpolationQuality_Offset), 0, InterpolationQuality_PropertyAddress.Address);
			InterpolationDistance = EnumMarshaler<EGroomInterpolationWeight>.FromNative(IntPtr.Add(nativeStruct, InterpolationDistance_Offset), 0, InterpolationDistance_PropertyAddress.Address);
			RandomizeGuide = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RandomizeGuide_Offset), 0, RandomizeGuide_PropertyAddress.Address);
			UseUniqueGuide = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseUniqueGuide_Offset), 0, UseUniqueGuide_PropertyAddress.Address);
		}
	}

	static FGroomBuildSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGroomBuildSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGroomBuildSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.GroomBuildSettings");
		FGroomBuildSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref OverrideGuides_PropertyAddress, intPtr, "bOverrideGuides");
		OverrideGuides_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideGuides");
		OverrideGuides_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideGuides", Classes.FBoolProperty);
		HairToGuideDensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairToGuideDensity");
		HairToGuideDensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairToGuideDensity", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InterpolationQuality_PropertyAddress, intPtr, "InterpolationQuality");
		InterpolationQuality_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpolationQuality");
		InterpolationQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpolationQuality", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref InterpolationDistance_PropertyAddress, intPtr, "InterpolationDistance");
		InterpolationDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpolationDistance");
		InterpolationDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpolationDistance", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomizeGuide_PropertyAddress, intPtr, "bRandomizeGuide");
		RandomizeGuide_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRandomizeGuide");
		RandomizeGuide_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRandomizeGuide", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseUniqueGuide_PropertyAddress, intPtr, "bUseUniqueGuide");
		UseUniqueGuide_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseUniqueGuide");
		UseUniqueGuide_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseUniqueGuide", Classes.FBoolProperty);
		FGroomBuildSettings_IsValid = intPtr != IntPtr.Zero && OverrideGuides_IsValid && HairToGuideDensity_IsValid && InterpolationQuality_IsValid && InterpolationDistance_IsValid && RandomizeGuide_IsValid && UseUniqueGuide_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.GroomBuildSettings", FGroomBuildSettings_IsValid);
	}
}
