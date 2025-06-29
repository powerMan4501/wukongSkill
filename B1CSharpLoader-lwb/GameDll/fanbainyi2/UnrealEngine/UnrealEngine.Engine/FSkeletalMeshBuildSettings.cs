using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SkeletalMeshBuildSettings", "Engine", UnrealModuleType.Engine)]
public struct FSkeletalMeshBuildSettings
{
	private static bool RecomputeNormals_IsValid;

	private static FFieldAddress RecomputeNormals_PropertyAddress;

	private static int RecomputeNormals_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshBuildSettings:bRecomputeNormals")]
	public bool RecomputeNormals;

	private static bool RecomputeTangents_IsValid;

	private static FFieldAddress RecomputeTangents_PropertyAddress;

	private static int RecomputeTangents_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshBuildSettings:bRecomputeTangents")]
	public bool RecomputeTangents;

	private static bool UseMikkTSpace_IsValid;

	private static FFieldAddress UseMikkTSpace_PropertyAddress;

	private static int UseMikkTSpace_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshBuildSettings:bUseMikkTSpace")]
	public bool UseMikkTSpace;

	private static bool ComputeWeightedNormals_IsValid;

	private static FFieldAddress ComputeWeightedNormals_PropertyAddress;

	private static int ComputeWeightedNormals_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshBuildSettings:bComputeWeightedNormals")]
	public bool ComputeWeightedNormals;

	private static bool RemoveDegenerates_IsValid;

	private static FFieldAddress RemoveDegenerates_PropertyAddress;

	private static int RemoveDegenerates_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshBuildSettings:bRemoveDegenerates")]
	public bool RemoveDegenerates;

	private static bool UseHighPrecisionTangentBasis_IsValid;

	private static FFieldAddress UseHighPrecisionTangentBasis_PropertyAddress;

	private static int UseHighPrecisionTangentBasis_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshBuildSettings:bUseHighPrecisionTangentBasis")]
	public bool UseHighPrecisionTangentBasis;

	private static bool UseFullPrecisionUVs_IsValid;

	private static FFieldAddress UseFullPrecisionUVs_PropertyAddress;

	private static int UseFullPrecisionUVs_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshBuildSettings:bUseFullPrecisionUVs")]
	public bool UseFullPrecisionUVs;

	private static bool UseBackwardsCompatibleF16TruncUVs_IsValid;

	private static FFieldAddress UseBackwardsCompatibleF16TruncUVs_PropertyAddress;

	private static int UseBackwardsCompatibleF16TruncUVs_Offset;

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshBuildSettings:bUseBackwardsCompatibleF16TruncUVs")]
	public bool UseBackwardsCompatibleF16TruncUVs;

	private static bool ThresholdPosition_IsValid;

	private static int ThresholdPosition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshBuildSettings:ThresholdPosition")]
	public float ThresholdPosition;

	private static bool ThresholdTangentNormal_IsValid;

	private static int ThresholdTangentNormal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshBuildSettings:ThresholdTangentNormal")]
	public float ThresholdTangentNormal;

	private static bool ThresholdUV_IsValid;

	private static int ThresholdUV_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshBuildSettings:ThresholdUV")]
	public float ThresholdUV;

	private static bool MorphThresholdPosition_IsValid;

	private static int MorphThresholdPosition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshBuildSettings:MorphThresholdPosition")]
	public float MorphThresholdPosition;

	private static bool FSkeletalMeshBuildSettings_IsValid;

	private static int FSkeletalMeshBuildSettings_StructSize;

	public FSkeletalMeshBuildSettings Copy()
	{
		return this;
	}

	public static FSkeletalMeshBuildSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSkeletalMeshBuildSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSkeletalMeshBuildSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSkeletalMeshBuildSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSkeletalMeshBuildSettings(nativeBuffer + arrayIndex * FSkeletalMeshBuildSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSkeletalMeshBuildSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSkeletalMeshBuildSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSkeletalMeshBuildSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SkeletalMeshBuildSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecomputeNormals_Offset), 0, RecomputeNormals_PropertyAddress.Address, RecomputeNormals);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecomputeTangents_Offset), 0, RecomputeTangents_PropertyAddress.Address, RecomputeTangents);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseMikkTSpace_Offset), 0, UseMikkTSpace_PropertyAddress.Address, UseMikkTSpace);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ComputeWeightedNormals_Offset), 0, ComputeWeightedNormals_PropertyAddress.Address, ComputeWeightedNormals);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RemoveDegenerates_Offset), 0, RemoveDegenerates_PropertyAddress.Address, RemoveDegenerates);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseHighPrecisionTangentBasis_Offset), 0, UseHighPrecisionTangentBasis_PropertyAddress.Address, UseHighPrecisionTangentBasis);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseFullPrecisionUVs_Offset), 0, UseFullPrecisionUVs_PropertyAddress.Address, UseFullPrecisionUVs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseBackwardsCompatibleF16TruncUVs_Offset), 0, UseBackwardsCompatibleF16TruncUVs_PropertyAddress.Address, UseBackwardsCompatibleF16TruncUVs);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ThresholdPosition_Offset), ThresholdPosition);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ThresholdTangentNormal_Offset), ThresholdTangentNormal);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ThresholdUV_Offset), ThresholdUV);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MorphThresholdPosition_Offset), MorphThresholdPosition);
	}

	public FSkeletalMeshBuildSettings(IntPtr nativeStruct)
	{
		if (!FSkeletalMeshBuildSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SkeletalMeshBuildSettings");
			RecomputeNormals = false;
			RecomputeTangents = false;
			UseMikkTSpace = false;
			ComputeWeightedNormals = false;
			RemoveDegenerates = false;
			UseHighPrecisionTangentBasis = false;
			UseFullPrecisionUVs = false;
			UseBackwardsCompatibleF16TruncUVs = false;
			ThresholdPosition = 0f;
			ThresholdTangentNormal = 0f;
			ThresholdUV = 0f;
			MorphThresholdPosition = 0f;
		}
		else
		{
			RecomputeNormals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecomputeNormals_Offset), 0, RecomputeNormals_PropertyAddress.Address);
			RecomputeTangents = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecomputeTangents_Offset), 0, RecomputeTangents_PropertyAddress.Address);
			UseMikkTSpace = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseMikkTSpace_Offset), 0, UseMikkTSpace_PropertyAddress.Address);
			ComputeWeightedNormals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ComputeWeightedNormals_Offset), 0, ComputeWeightedNormals_PropertyAddress.Address);
			RemoveDegenerates = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RemoveDegenerates_Offset), 0, RemoveDegenerates_PropertyAddress.Address);
			UseHighPrecisionTangentBasis = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseHighPrecisionTangentBasis_Offset), 0, UseHighPrecisionTangentBasis_PropertyAddress.Address);
			UseFullPrecisionUVs = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseFullPrecisionUVs_Offset), 0, UseFullPrecisionUVs_PropertyAddress.Address);
			UseBackwardsCompatibleF16TruncUVs = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseBackwardsCompatibleF16TruncUVs_Offset), 0, UseBackwardsCompatibleF16TruncUVs_PropertyAddress.Address);
			ThresholdPosition = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ThresholdPosition_Offset));
			ThresholdTangentNormal = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ThresholdTangentNormal_Offset));
			ThresholdUV = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ThresholdUV_Offset));
			MorphThresholdPosition = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MorphThresholdPosition_Offset));
		}
	}

	static FSkeletalMeshBuildSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSkeletalMeshBuildSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSkeletalMeshBuildSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SkeletalMeshBuildSettings");
		FSkeletalMeshBuildSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref RecomputeNormals_PropertyAddress, intPtr, "bRecomputeNormals");
		RecomputeNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecomputeNormals");
		RecomputeNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecomputeNormals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RecomputeTangents_PropertyAddress, intPtr, "bRecomputeTangents");
		RecomputeTangents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecomputeTangents");
		RecomputeTangents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecomputeTangents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseMikkTSpace_PropertyAddress, intPtr, "bUseMikkTSpace");
		UseMikkTSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseMikkTSpace");
		UseMikkTSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseMikkTSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeWeightedNormals_PropertyAddress, intPtr, "bComputeWeightedNormals");
		ComputeWeightedNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bComputeWeightedNormals");
		ComputeWeightedNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bComputeWeightedNormals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveDegenerates_PropertyAddress, intPtr, "bRemoveDegenerates");
		RemoveDegenerates_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRemoveDegenerates");
		RemoveDegenerates_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRemoveDegenerates", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseHighPrecisionTangentBasis_PropertyAddress, intPtr, "bUseHighPrecisionTangentBasis");
		UseHighPrecisionTangentBasis_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseHighPrecisionTangentBasis");
		UseHighPrecisionTangentBasis_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseHighPrecisionTangentBasis", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseFullPrecisionUVs_PropertyAddress, intPtr, "bUseFullPrecisionUVs");
		UseFullPrecisionUVs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseFullPrecisionUVs");
		UseFullPrecisionUVs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseFullPrecisionUVs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseBackwardsCompatibleF16TruncUVs_PropertyAddress, intPtr, "bUseBackwardsCompatibleF16TruncUVs");
		UseBackwardsCompatibleF16TruncUVs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseBackwardsCompatibleF16TruncUVs");
		UseBackwardsCompatibleF16TruncUVs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseBackwardsCompatibleF16TruncUVs", Classes.FBoolProperty);
		ThresholdPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ThresholdPosition");
		ThresholdPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ThresholdPosition", Classes.FFloatProperty);
		ThresholdTangentNormal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ThresholdTangentNormal");
		ThresholdTangentNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ThresholdTangentNormal", Classes.FFloatProperty);
		ThresholdUV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ThresholdUV");
		ThresholdUV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ThresholdUV", Classes.FFloatProperty);
		MorphThresholdPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MorphThresholdPosition");
		MorphThresholdPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MorphThresholdPosition", Classes.FFloatProperty);
		FSkeletalMeshBuildSettings_IsValid = intPtr != IntPtr.Zero && RecomputeNormals_IsValid && RecomputeTangents_IsValid && UseMikkTSpace_IsValid && ComputeWeightedNormals_IsValid && RemoveDegenerates_IsValid && UseHighPrecisionTangentBasis_IsValid && UseFullPrecisionUVs_IsValid && UseBackwardsCompatibleF16TruncUVs_IsValid && ThresholdPosition_IsValid && ThresholdTangentNormal_IsValid && ThresholdUV_IsValid && MorphThresholdPosition_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SkeletalMeshBuildSettings", FSkeletalMeshBuildSettings_IsValid);
	}
}
