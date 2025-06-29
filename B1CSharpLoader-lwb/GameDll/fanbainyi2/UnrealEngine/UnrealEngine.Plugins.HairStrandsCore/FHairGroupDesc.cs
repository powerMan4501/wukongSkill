using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairGroupDesc", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairGroupDesc
{
	private static bool HairWidth_IsValid;

	private static int HairWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:HairWidth")]
	public float HairWidth;

	private static bool HairWidth_Override_IsValid;

	private static FFieldAddress HairWidth_Override_PropertyAddress;

	private static int HairWidth_Override_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:HairWidth_Override")]
	public bool HairWidth_Override;

	private static bool HairRootScale_IsValid;

	private static int HairRootScale_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:HairRootScale")]
	public float HairRootScale;

	private static bool HairRootScale_Override_IsValid;

	private static FFieldAddress HairRootScale_Override_PropertyAddress;

	private static int HairRootScale_Override_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:HairRootScale_Override")]
	public bool HairRootScale_Override;

	private static bool HairTipScale_IsValid;

	private static int HairTipScale_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:HairTipScale")]
	public float HairTipScale;

	private static bool HairTipScale_Override_IsValid;

	private static FFieldAddress HairTipScale_Override_PropertyAddress;

	private static int HairTipScale_Override_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:HairTipScale_Override")]
	public bool HairTipScale_Override;

	private static bool HairShadowDensity_IsValid;

	private static int HairShadowDensity_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:HairShadowDensity")]
	public float HairShadowDensity;

	private static bool HairShadowDensity_Override_IsValid;

	private static FFieldAddress HairShadowDensity_Override_PropertyAddress;

	private static int HairShadowDensity_Override_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:HairShadowDensity_Override")]
	public bool HairShadowDensity_Override;

	private static bool HairRaytracingRadiusScale_IsValid;

	private static int HairRaytracingRadiusScale_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:HairRaytracingRadiusScale")]
	public float HairRaytracingRadiusScale;

	private static bool HairRaytracingRadiusScale_Override_IsValid;

	private static FFieldAddress HairRaytracingRadiusScale_Override_PropertyAddress;

	private static int HairRaytracingRadiusScale_Override_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:HairRaytracingRadiusScale_Override")]
	public bool HairRaytracingRadiusScale_Override;

	private static bool UseHairRaytracingGeometry_IsValid;

	private static FFieldAddress UseHairRaytracingGeometry_PropertyAddress;

	private static int UseHairRaytracingGeometry_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:bUseHairRaytracingGeometry")]
	public bool UseHairRaytracingGeometry;

	private static bool UseHairRaytracingGeometry_Override_IsValid;

	private static FFieldAddress UseHairRaytracingGeometry_Override_PropertyAddress;

	private static int UseHairRaytracingGeometry_Override_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:bUseHairRaytracingGeometry_Override")]
	public bool UseHairRaytracingGeometry_Override;

	private static bool LODBias_IsValid;

	private static int LODBias_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:LODBias")]
	public float LODBias;

	private static bool UseStableRasterization_IsValid;

	private static FFieldAddress UseStableRasterization_PropertyAddress;

	private static int UseStableRasterization_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:bUseStableRasterization")]
	public bool UseStableRasterization;

	private static bool UseStableRasterization_Override_IsValid;

	private static FFieldAddress UseStableRasterization_Override_PropertyAddress;

	private static int UseStableRasterization_Override_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:bUseStableRasterization_Override")]
	public bool UseStableRasterization_Override;

	private static bool ScatterSceneLighting_IsValid;

	private static FFieldAddress ScatterSceneLighting_PropertyAddress;

	private static int ScatterSceneLighting_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:bScatterSceneLighting")]
	public bool ScatterSceneLighting;

	private static bool ScatterSceneLighting_Override_IsValid;

	private static FFieldAddress ScatterSceneLighting_Override_PropertyAddress;

	private static int ScatterSceneLighting_Override_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:bScatterSceneLighting_Override")]
	public bool ScatterSceneLighting_Override;

	private static bool HairLengthScale_IsValid;

	private static int HairLengthScale_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:HairLengthScale")]
	public float HairLengthScale;

	private static bool HairLengthScale_Override_IsValid;

	private static FFieldAddress HairLengthScale_Override_PropertyAddress;

	private static int HairLengthScale_Override_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGroupDesc:HairLengthScale_Override")]
	public bool HairLengthScale_Override;

	private static bool FHairGroupDesc_IsValid;

	private static int FHairGroupDesc_StructSize;

	public FHairGroupDesc Copy()
	{
		return this;
	}

	public static FHairGroupDesc FromNative(IntPtr nativeBuffer)
	{
		return new FHairGroupDesc(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairGroupDesc value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairGroupDesc FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairGroupDesc(nativeBuffer + arrayIndex * FHairGroupDesc_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairGroupDesc value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairGroupDesc_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairGroupDesc_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupDesc");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HairWidth_Offset), HairWidth);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HairWidth_Override_Offset), 0, HairWidth_Override_PropertyAddress.Address, HairWidth_Override);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HairRootScale_Offset), HairRootScale);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HairRootScale_Override_Offset), 0, HairRootScale_Override_PropertyAddress.Address, HairRootScale_Override);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HairTipScale_Offset), HairTipScale);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HairTipScale_Override_Offset), 0, HairTipScale_Override_PropertyAddress.Address, HairTipScale_Override);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HairShadowDensity_Offset), HairShadowDensity);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HairShadowDensity_Override_Offset), 0, HairShadowDensity_Override_PropertyAddress.Address, HairShadowDensity_Override);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HairRaytracingRadiusScale_Offset), HairRaytracingRadiusScale);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HairRaytracingRadiusScale_Override_Offset), 0, HairRaytracingRadiusScale_Override_PropertyAddress.Address, HairRaytracingRadiusScale_Override);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseHairRaytracingGeometry_Offset), 0, UseHairRaytracingGeometry_PropertyAddress.Address, UseHairRaytracingGeometry);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseHairRaytracingGeometry_Override_Offset), 0, UseHairRaytracingGeometry_Override_PropertyAddress.Address, UseHairRaytracingGeometry_Override);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LODBias_Offset), LODBias);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseStableRasterization_Offset), 0, UseStableRasterization_PropertyAddress.Address, UseStableRasterization);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseStableRasterization_Override_Offset), 0, UseStableRasterization_Override_PropertyAddress.Address, UseStableRasterization_Override);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ScatterSceneLighting_Offset), 0, ScatterSceneLighting_PropertyAddress.Address, ScatterSceneLighting);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ScatterSceneLighting_Override_Offset), 0, ScatterSceneLighting_Override_PropertyAddress.Address, ScatterSceneLighting_Override);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HairLengthScale_Offset), HairLengthScale);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HairLengthScale_Override_Offset), 0, HairLengthScale_Override_PropertyAddress.Address, HairLengthScale_Override);
	}

	public FHairGroupDesc(IntPtr nativeStruct)
	{
		if (!FHairGroupDesc_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupDesc");
			HairWidth = 0f;
			HairWidth_Override = false;
			HairRootScale = 0f;
			HairRootScale_Override = false;
			HairTipScale = 0f;
			HairTipScale_Override = false;
			HairShadowDensity = 0f;
			HairShadowDensity_Override = false;
			HairRaytracingRadiusScale = 0f;
			HairRaytracingRadiusScale_Override = false;
			UseHairRaytracingGeometry = false;
			UseHairRaytracingGeometry_Override = false;
			LODBias = 0f;
			UseStableRasterization = false;
			UseStableRasterization_Override = false;
			ScatterSceneLighting = false;
			ScatterSceneLighting_Override = false;
			HairLengthScale = 0f;
			HairLengthScale_Override = false;
		}
		else
		{
			HairWidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HairWidth_Offset));
			HairWidth_Override = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HairWidth_Override_Offset), 0, HairWidth_Override_PropertyAddress.Address);
			HairRootScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HairRootScale_Offset));
			HairRootScale_Override = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HairRootScale_Override_Offset), 0, HairRootScale_Override_PropertyAddress.Address);
			HairTipScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HairTipScale_Offset));
			HairTipScale_Override = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HairTipScale_Override_Offset), 0, HairTipScale_Override_PropertyAddress.Address);
			HairShadowDensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HairShadowDensity_Offset));
			HairShadowDensity_Override = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HairShadowDensity_Override_Offset), 0, HairShadowDensity_Override_PropertyAddress.Address);
			HairRaytracingRadiusScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HairRaytracingRadiusScale_Offset));
			HairRaytracingRadiusScale_Override = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HairRaytracingRadiusScale_Override_Offset), 0, HairRaytracingRadiusScale_Override_PropertyAddress.Address);
			UseHairRaytracingGeometry = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseHairRaytracingGeometry_Offset), 0, UseHairRaytracingGeometry_PropertyAddress.Address);
			UseHairRaytracingGeometry_Override = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseHairRaytracingGeometry_Override_Offset), 0, UseHairRaytracingGeometry_Override_PropertyAddress.Address);
			LODBias = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LODBias_Offset));
			UseStableRasterization = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseStableRasterization_Offset), 0, UseStableRasterization_PropertyAddress.Address);
			UseStableRasterization_Override = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseStableRasterization_Override_Offset), 0, UseStableRasterization_Override_PropertyAddress.Address);
			ScatterSceneLighting = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ScatterSceneLighting_Offset), 0, ScatterSceneLighting_PropertyAddress.Address);
			ScatterSceneLighting_Override = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ScatterSceneLighting_Override_Offset), 0, ScatterSceneLighting_Override_PropertyAddress.Address);
			HairLengthScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HairLengthScale_Offset));
			HairLengthScale_Override = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HairLengthScale_Override_Offset), 0, HairLengthScale_Override_PropertyAddress.Address);
		}
	}

	static FHairGroupDesc()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairGroupDesc)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairGroupDesc));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairGroupDesc");
		FHairGroupDesc_StructSize = NativeReflection.GetStructSize(intPtr);
		HairWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairWidth");
		HairWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref HairWidth_Override_PropertyAddress, intPtr, "HairWidth_Override");
		HairWidth_Override_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairWidth_Override");
		HairWidth_Override_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairWidth_Override", Classes.FBoolProperty);
		HairRootScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairRootScale");
		HairRootScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairRootScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref HairRootScale_Override_PropertyAddress, intPtr, "HairRootScale_Override");
		HairRootScale_Override_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairRootScale_Override");
		HairRootScale_Override_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairRootScale_Override", Classes.FBoolProperty);
		HairTipScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairTipScale");
		HairTipScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairTipScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref HairTipScale_Override_PropertyAddress, intPtr, "HairTipScale_Override");
		HairTipScale_Override_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairTipScale_Override");
		HairTipScale_Override_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairTipScale_Override", Classes.FBoolProperty);
		HairShadowDensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairShadowDensity");
		HairShadowDensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairShadowDensity", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref HairShadowDensity_Override_PropertyAddress, intPtr, "HairShadowDensity_Override");
		HairShadowDensity_Override_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairShadowDensity_Override");
		HairShadowDensity_Override_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairShadowDensity_Override", Classes.FBoolProperty);
		HairRaytracingRadiusScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairRaytracingRadiusScale");
		HairRaytracingRadiusScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairRaytracingRadiusScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref HairRaytracingRadiusScale_Override_PropertyAddress, intPtr, "HairRaytracingRadiusScale_Override");
		HairRaytracingRadiusScale_Override_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairRaytracingRadiusScale_Override");
		HairRaytracingRadiusScale_Override_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairRaytracingRadiusScale_Override", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseHairRaytracingGeometry_PropertyAddress, intPtr, "bUseHairRaytracingGeometry");
		UseHairRaytracingGeometry_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseHairRaytracingGeometry");
		UseHairRaytracingGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseHairRaytracingGeometry", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseHairRaytracingGeometry_Override_PropertyAddress, intPtr, "bUseHairRaytracingGeometry_Override");
		UseHairRaytracingGeometry_Override_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseHairRaytracingGeometry_Override");
		UseHairRaytracingGeometry_Override_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseHairRaytracingGeometry_Override", Classes.FBoolProperty);
		LODBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODBias");
		LODBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODBias", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseStableRasterization_PropertyAddress, intPtr, "bUseStableRasterization");
		UseStableRasterization_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseStableRasterization");
		UseStableRasterization_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseStableRasterization", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseStableRasterization_Override_PropertyAddress, intPtr, "bUseStableRasterization_Override");
		UseStableRasterization_Override_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseStableRasterization_Override");
		UseStableRasterization_Override_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseStableRasterization_Override", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterSceneLighting_PropertyAddress, intPtr, "bScatterSceneLighting");
		ScatterSceneLighting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bScatterSceneLighting");
		ScatterSceneLighting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bScatterSceneLighting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScatterSceneLighting_Override_PropertyAddress, intPtr, "bScatterSceneLighting_Override");
		ScatterSceneLighting_Override_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bScatterSceneLighting_Override");
		ScatterSceneLighting_Override_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bScatterSceneLighting_Override", Classes.FBoolProperty);
		HairLengthScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairLengthScale");
		HairLengthScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairLengthScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref HairLengthScale_Override_PropertyAddress, intPtr, "HairLengthScale_Override");
		HairLengthScale_Override_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairLengthScale_Override");
		HairLengthScale_Override_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairLengthScale_Override", Classes.FBoolProperty);
		FHairGroupDesc_IsValid = intPtr != IntPtr.Zero && HairWidth_IsValid && HairWidth_Override_IsValid && HairRootScale_IsValid && HairRootScale_Override_IsValid && HairTipScale_IsValid && HairTipScale_Override_IsValid && HairShadowDensity_IsValid && HairShadowDensity_Override_IsValid && HairRaytracingRadiusScale_IsValid && HairRaytracingRadiusScale_Override_IsValid && UseHairRaytracingGeometry_IsValid && UseHairRaytracingGeometry_Override_IsValid && LODBias_IsValid && UseStableRasterization_IsValid && UseStableRasterization_Override_IsValid && ScatterSceneLighting_IsValid && ScatterSceneLighting_Override_IsValid && HairLengthScale_IsValid && HairLengthScale_Override_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairGroupDesc", FHairGroupDesc_IsValid);
	}
}
