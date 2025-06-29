using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.LightmassWorldInfoSettings", "Engine", UnrealModuleType.Engine)]
public struct FLightmassWorldInfoSettings
{
	private static bool StaticLightingLevelScale_IsValid;

	private static int StaticLightingLevelScale_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:StaticLightingLevelScale")]
	public float StaticLightingLevelScale;

	private static bool NumIndirectLightingBounces_IsValid;

	private static int NumIndirectLightingBounces_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:NumIndirectLightingBounces")]
	public int NumIndirectLightingBounces;

	private static bool NumSkyLightingBounces_IsValid;

	private static int NumSkyLightingBounces_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:NumSkyLightingBounces")]
	public int NumSkyLightingBounces;

	private static bool IndirectLightingQuality_IsValid;

	private static int IndirectLightingQuality_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:IndirectLightingQuality")]
	public float IndirectLightingQuality;

	private static bool IndirectLightingSmoothness_IsValid;

	private static int IndirectLightingSmoothness_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:IndirectLightingSmoothness")]
	public float IndirectLightingSmoothness;

	private static bool EnvironmentColor_IsValid;

	private static int EnvironmentColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:EnvironmentColor")]
	public FColor EnvironmentColor;

	private static bool EnvironmentIntensity_IsValid;

	private static int EnvironmentIntensity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:EnvironmentIntensity")]
	public float EnvironmentIntensity;

	private static bool DiffuseBoost_IsValid;

	private static int DiffuseBoost_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:DiffuseBoost")]
	public float DiffuseBoost;

	private static bool VolumeLightingMethod_IsValid;

	private static FFieldAddress VolumeLightingMethod_PropertyAddress;

	private static int VolumeLightingMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:VolumeLightingMethod")]
	public EVolumeLightingMethod VolumeLightingMethod;

	private static bool UseAmbientOcclusion_IsValid;

	private static FFieldAddress UseAmbientOcclusion_PropertyAddress;

	private static int UseAmbientOcclusion_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:bUseAmbientOcclusion")]
	public bool UseAmbientOcclusion;

	private static bool GenerateAmbientOcclusionMaterialMask_IsValid;

	private static FFieldAddress GenerateAmbientOcclusionMaterialMask_PropertyAddress;

	private static int GenerateAmbientOcclusionMaterialMask_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:bGenerateAmbientOcclusionMaterialMask")]
	public bool GenerateAmbientOcclusionMaterialMask;

	private static bool VisualizeMaterialDiffuse_IsValid;

	private static FFieldAddress VisualizeMaterialDiffuse_PropertyAddress;

	private static int VisualizeMaterialDiffuse_Offset;

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:bVisualizeMaterialDiffuse")]
	public bool VisualizeMaterialDiffuse;

	private static bool VisualizeAmbientOcclusion_IsValid;

	private static FFieldAddress VisualizeAmbientOcclusion_PropertyAddress;

	private static int VisualizeAmbientOcclusion_Offset;

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:bVisualizeAmbientOcclusion")]
	public bool VisualizeAmbientOcclusion;

	private static bool CompressLightmaps_IsValid;

	private static FFieldAddress CompressLightmaps_PropertyAddress;

	private static int CompressLightmaps_Offset;

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:bCompressLightmaps")]
	public bool CompressLightmaps;

	private static bool VolumetricLightmapDetailCellSize_IsValid;

	private static int VolumetricLightmapDetailCellSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:VolumetricLightmapDetailCellSize")]
	public float VolumetricLightmapDetailCellSize;

	private static bool VolumetricLightmapMaximumBrickMemoryMb_IsValid;

	private static int VolumetricLightmapMaximumBrickMemoryMb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:VolumetricLightmapMaximumBrickMemoryMb")]
	public float VolumetricLightmapMaximumBrickMemoryMb;

	private static bool VolumetricLightmapSphericalHarmonicSmoothing_IsValid;

	private static int VolumetricLightmapSphericalHarmonicSmoothing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:VolumetricLightmapSphericalHarmonicSmoothing")]
	public float VolumetricLightmapSphericalHarmonicSmoothing;

	private static bool VolumeLightSamplePlacementScale_IsValid;

	private static int VolumeLightSamplePlacementScale_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:VolumeLightSamplePlacementScale")]
	public float VolumeLightSamplePlacementScale;

	private static bool DirectIlluminationOcclusionFraction_IsValid;

	private static int DirectIlluminationOcclusionFraction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:DirectIlluminationOcclusionFraction")]
	public float DirectIlluminationOcclusionFraction;

	private static bool IndirectIlluminationOcclusionFraction_IsValid;

	private static int IndirectIlluminationOcclusionFraction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:IndirectIlluminationOcclusionFraction")]
	public float IndirectIlluminationOcclusionFraction;

	private static bool OcclusionExponent_IsValid;

	private static int OcclusionExponent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:OcclusionExponent")]
	public float OcclusionExponent;

	private static bool FullyOccludedSamplesFraction_IsValid;

	private static int FullyOccludedSamplesFraction_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:FullyOccludedSamplesFraction")]
	public float FullyOccludedSamplesFraction;

	private static bool MaxOcclusionDistance_IsValid;

	private static int MaxOcclusionDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LightmassWorldInfoSettings:MaxOcclusionDistance")]
	public float MaxOcclusionDistance;

	private static bool FLightmassWorldInfoSettings_IsValid;

	private static int FLightmassWorldInfoSettings_StructSize;

	public FLightmassWorldInfoSettings Copy()
	{
		return this;
	}

	public static FLightmassWorldInfoSettings FromNative(IntPtr nativeBuffer)
	{
		return new FLightmassWorldInfoSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLightmassWorldInfoSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLightmassWorldInfoSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLightmassWorldInfoSettings(nativeBuffer + arrayIndex * FLightmassWorldInfoSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLightmassWorldInfoSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLightmassWorldInfoSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLightmassWorldInfoSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.LightmassWorldInfoSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StaticLightingLevelScale_Offset), StaticLightingLevelScale);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumIndirectLightingBounces_Offset), NumIndirectLightingBounces);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumSkyLightingBounces_Offset), NumSkyLightingBounces);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, IndirectLightingQuality_Offset), IndirectLightingQuality);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, IndirectLightingSmoothness_Offset), IndirectLightingSmoothness);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, EnvironmentColor_Offset), EnvironmentColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EnvironmentIntensity_Offset), EnvironmentIntensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DiffuseBoost_Offset), DiffuseBoost);
		EnumMarshaler<EVolumeLightingMethod>.ToNative(IntPtr.Add(nativeStruct, VolumeLightingMethod_Offset), 0, VolumeLightingMethod_PropertyAddress.Address, VolumeLightingMethod);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseAmbientOcclusion_Offset), 0, UseAmbientOcclusion_PropertyAddress.Address, UseAmbientOcclusion);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GenerateAmbientOcclusionMaterialMask_Offset), 0, GenerateAmbientOcclusionMaterialMask_PropertyAddress.Address, GenerateAmbientOcclusionMaterialMask);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, VisualizeMaterialDiffuse_Offset), 0, VisualizeMaterialDiffuse_PropertyAddress.Address, VisualizeMaterialDiffuse);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, VisualizeAmbientOcclusion_Offset), 0, VisualizeAmbientOcclusion_PropertyAddress.Address, VisualizeAmbientOcclusion);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CompressLightmaps_Offset), 0, CompressLightmaps_PropertyAddress.Address, CompressLightmaps);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VolumetricLightmapDetailCellSize_Offset), VolumetricLightmapDetailCellSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VolumetricLightmapMaximumBrickMemoryMb_Offset), VolumetricLightmapMaximumBrickMemoryMb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VolumetricLightmapSphericalHarmonicSmoothing_Offset), VolumetricLightmapSphericalHarmonicSmoothing);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VolumeLightSamplePlacementScale_Offset), VolumeLightSamplePlacementScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DirectIlluminationOcclusionFraction_Offset), DirectIlluminationOcclusionFraction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, IndirectIlluminationOcclusionFraction_Offset), IndirectIlluminationOcclusionFraction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OcclusionExponent_Offset), OcclusionExponent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FullyOccludedSamplesFraction_Offset), FullyOccludedSamplesFraction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxOcclusionDistance_Offset), MaxOcclusionDistance);
	}

	public FLightmassWorldInfoSettings(IntPtr nativeStruct)
	{
		if (!FLightmassWorldInfoSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.LightmassWorldInfoSettings");
			StaticLightingLevelScale = 0f;
			NumIndirectLightingBounces = 0;
			NumSkyLightingBounces = 0;
			IndirectLightingQuality = 0f;
			IndirectLightingSmoothness = 0f;
			EnvironmentColor = default(FColor);
			EnvironmentIntensity = 0f;
			DiffuseBoost = 0f;
			VolumeLightingMethod = EVolumeLightingMethod.VLM_VolumetricLightmap;
			UseAmbientOcclusion = false;
			GenerateAmbientOcclusionMaterialMask = false;
			VisualizeMaterialDiffuse = false;
			VisualizeAmbientOcclusion = false;
			CompressLightmaps = false;
			VolumetricLightmapDetailCellSize = 0f;
			VolumetricLightmapMaximumBrickMemoryMb = 0f;
			VolumetricLightmapSphericalHarmonicSmoothing = 0f;
			VolumeLightSamplePlacementScale = 0f;
			DirectIlluminationOcclusionFraction = 0f;
			IndirectIlluminationOcclusionFraction = 0f;
			OcclusionExponent = 0f;
			FullyOccludedSamplesFraction = 0f;
			MaxOcclusionDistance = 0f;
		}
		else
		{
			StaticLightingLevelScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StaticLightingLevelScale_Offset));
			NumIndirectLightingBounces = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumIndirectLightingBounces_Offset));
			NumSkyLightingBounces = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumSkyLightingBounces_Offset));
			IndirectLightingQuality = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, IndirectLightingQuality_Offset));
			IndirectLightingSmoothness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, IndirectLightingSmoothness_Offset));
			EnvironmentColor = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, EnvironmentColor_Offset));
			EnvironmentIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EnvironmentIntensity_Offset));
			DiffuseBoost = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DiffuseBoost_Offset));
			VolumeLightingMethod = EnumMarshaler<EVolumeLightingMethod>.FromNative(IntPtr.Add(nativeStruct, VolumeLightingMethod_Offset), 0, VolumeLightingMethod_PropertyAddress.Address);
			UseAmbientOcclusion = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseAmbientOcclusion_Offset), 0, UseAmbientOcclusion_PropertyAddress.Address);
			GenerateAmbientOcclusionMaterialMask = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GenerateAmbientOcclusionMaterialMask_Offset), 0, GenerateAmbientOcclusionMaterialMask_PropertyAddress.Address);
			VisualizeMaterialDiffuse = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, VisualizeMaterialDiffuse_Offset), 0, VisualizeMaterialDiffuse_PropertyAddress.Address);
			VisualizeAmbientOcclusion = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, VisualizeAmbientOcclusion_Offset), 0, VisualizeAmbientOcclusion_PropertyAddress.Address);
			CompressLightmaps = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CompressLightmaps_Offset), 0, CompressLightmaps_PropertyAddress.Address);
			VolumetricLightmapDetailCellSize = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VolumetricLightmapDetailCellSize_Offset));
			VolumetricLightmapMaximumBrickMemoryMb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VolumetricLightmapMaximumBrickMemoryMb_Offset));
			VolumetricLightmapSphericalHarmonicSmoothing = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VolumetricLightmapSphericalHarmonicSmoothing_Offset));
			VolumeLightSamplePlacementScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VolumeLightSamplePlacementScale_Offset));
			DirectIlluminationOcclusionFraction = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DirectIlluminationOcclusionFraction_Offset));
			IndirectIlluminationOcclusionFraction = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, IndirectIlluminationOcclusionFraction_Offset));
			OcclusionExponent = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OcclusionExponent_Offset));
			FullyOccludedSamplesFraction = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FullyOccludedSamplesFraction_Offset));
			MaxOcclusionDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxOcclusionDistance_Offset));
		}
	}

	static FLightmassWorldInfoSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLightmassWorldInfoSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLightmassWorldInfoSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.LightmassWorldInfoSettings");
		FLightmassWorldInfoSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		StaticLightingLevelScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StaticLightingLevelScale");
		StaticLightingLevelScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StaticLightingLevelScale", Classes.FFloatProperty);
		NumIndirectLightingBounces_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumIndirectLightingBounces");
		NumIndirectLightingBounces_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumIndirectLightingBounces", Classes.FIntProperty);
		NumSkyLightingBounces_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumSkyLightingBounces");
		NumSkyLightingBounces_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumSkyLightingBounces", Classes.FIntProperty);
		IndirectLightingQuality_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IndirectLightingQuality");
		IndirectLightingQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IndirectLightingQuality", Classes.FFloatProperty);
		IndirectLightingSmoothness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IndirectLightingSmoothness");
		IndirectLightingSmoothness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IndirectLightingSmoothness", Classes.FFloatProperty);
		EnvironmentColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnvironmentColor");
		EnvironmentColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnvironmentColor", Classes.FStructProperty);
		EnvironmentIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnvironmentIntensity");
		EnvironmentIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnvironmentIntensity", Classes.FFloatProperty);
		DiffuseBoost_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DiffuseBoost");
		DiffuseBoost_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DiffuseBoost", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref VolumeLightingMethod_PropertyAddress, intPtr, "VolumeLightingMethod");
		VolumeLightingMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeLightingMethod");
		VolumeLightingMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeLightingMethod", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref UseAmbientOcclusion_PropertyAddress, intPtr, "bUseAmbientOcclusion");
		UseAmbientOcclusion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseAmbientOcclusion");
		UseAmbientOcclusion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseAmbientOcclusion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateAmbientOcclusionMaterialMask_PropertyAddress, intPtr, "bGenerateAmbientOcclusionMaterialMask");
		GenerateAmbientOcclusionMaterialMask_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateAmbientOcclusionMaterialMask");
		GenerateAmbientOcclusionMaterialMask_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateAmbientOcclusionMaterialMask", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VisualizeMaterialDiffuse_PropertyAddress, intPtr, "bVisualizeMaterialDiffuse");
		VisualizeMaterialDiffuse_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bVisualizeMaterialDiffuse");
		VisualizeMaterialDiffuse_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bVisualizeMaterialDiffuse", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VisualizeAmbientOcclusion_PropertyAddress, intPtr, "bVisualizeAmbientOcclusion");
		VisualizeAmbientOcclusion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bVisualizeAmbientOcclusion");
		VisualizeAmbientOcclusion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bVisualizeAmbientOcclusion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CompressLightmaps_PropertyAddress, intPtr, "bCompressLightmaps");
		CompressLightmaps_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCompressLightmaps");
		CompressLightmaps_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCompressLightmaps", Classes.FBoolProperty);
		VolumetricLightmapDetailCellSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumetricLightmapDetailCellSize");
		VolumetricLightmapDetailCellSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumetricLightmapDetailCellSize", Classes.FFloatProperty);
		VolumetricLightmapMaximumBrickMemoryMb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumetricLightmapMaximumBrickMemoryMb");
		VolumetricLightmapMaximumBrickMemoryMb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumetricLightmapMaximumBrickMemoryMb", Classes.FFloatProperty);
		VolumetricLightmapSphericalHarmonicSmoothing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumetricLightmapSphericalHarmonicSmoothing");
		VolumetricLightmapSphericalHarmonicSmoothing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumetricLightmapSphericalHarmonicSmoothing", Classes.FFloatProperty);
		VolumeLightSamplePlacementScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeLightSamplePlacementScale");
		VolumeLightSamplePlacementScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeLightSamplePlacementScale", Classes.FFloatProperty);
		DirectIlluminationOcclusionFraction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DirectIlluminationOcclusionFraction");
		DirectIlluminationOcclusionFraction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DirectIlluminationOcclusionFraction", Classes.FFloatProperty);
		IndirectIlluminationOcclusionFraction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IndirectIlluminationOcclusionFraction");
		IndirectIlluminationOcclusionFraction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IndirectIlluminationOcclusionFraction", Classes.FFloatProperty);
		OcclusionExponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionExponent");
		OcclusionExponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionExponent", Classes.FFloatProperty);
		FullyOccludedSamplesFraction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FullyOccludedSamplesFraction");
		FullyOccludedSamplesFraction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FullyOccludedSamplesFraction", Classes.FFloatProperty);
		MaxOcclusionDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxOcclusionDistance");
		MaxOcclusionDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxOcclusionDistance", Classes.FFloatProperty);
		FLightmassWorldInfoSettings_IsValid = intPtr != IntPtr.Zero && StaticLightingLevelScale_IsValid && NumIndirectLightingBounces_IsValid && NumSkyLightingBounces_IsValid && IndirectLightingQuality_IsValid && IndirectLightingSmoothness_IsValid && EnvironmentColor_IsValid && EnvironmentIntensity_IsValid && DiffuseBoost_IsValid && VolumeLightingMethod_IsValid && UseAmbientOcclusion_IsValid && GenerateAmbientOcclusionMaterialMask_IsValid && VisualizeMaterialDiffuse_IsValid && VisualizeAmbientOcclusion_IsValid && CompressLightmaps_IsValid && VolumetricLightmapDetailCellSize_IsValid && VolumetricLightmapMaximumBrickMemoryMb_IsValid && VolumetricLightmapSphericalHarmonicSmoothing_IsValid && VolumeLightSamplePlacementScale_IsValid && DirectIlluminationOcclusionFraction_IsValid && IndirectIlluminationOcclusionFraction_IsValid && OcclusionExponent_IsValid && FullyOccludedSamplesFraction_IsValid && MaxOcclusionDistance_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.LightmassWorldInfoSettings", FLightmassWorldInfoSettings_IsValid);
	}
}
