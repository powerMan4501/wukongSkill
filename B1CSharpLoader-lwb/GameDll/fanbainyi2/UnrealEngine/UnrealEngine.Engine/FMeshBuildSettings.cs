using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.MeshBuildSettings", "Engine", UnrealModuleType.Engine)]
public struct FMeshBuildSettings
{
	private static bool UseMikkTSpace_IsValid;

	private static FFieldAddress UseMikkTSpace_PropertyAddress;

	private static int UseMikkTSpace_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:bUseMikkTSpace")]
	public bool UseMikkTSpace;

	private static bool RecomputeNormals_IsValid;

	private static FFieldAddress RecomputeNormals_PropertyAddress;

	private static int RecomputeNormals_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:bRecomputeNormals")]
	public bool RecomputeNormals;

	private static bool RecomputeTangents_IsValid;

	private static FFieldAddress RecomputeTangents_PropertyAddress;

	private static int RecomputeTangents_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:bRecomputeTangents")]
	public bool RecomputeTangents;

	private static bool ComputeWeightedNormals_IsValid;

	private static FFieldAddress ComputeWeightedNormals_PropertyAddress;

	private static int ComputeWeightedNormals_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:bComputeWeightedNormals")]
	public bool ComputeWeightedNormals;

	private static bool RemoveDegenerates_IsValid;

	private static FFieldAddress RemoveDegenerates_PropertyAddress;

	private static int RemoveDegenerates_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:bRemoveDegenerates")]
	public bool RemoveDegenerates;

	private static bool BuildReversedIndexBuffer_IsValid;

	private static FFieldAddress BuildReversedIndexBuffer_PropertyAddress;

	private static int BuildReversedIndexBuffer_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:bBuildReversedIndexBuffer")]
	public bool BuildReversedIndexBuffer;

	private static bool UseHighPrecisionTangentBasis_IsValid;

	private static FFieldAddress UseHighPrecisionTangentBasis_PropertyAddress;

	private static int UseHighPrecisionTangentBasis_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:bUseHighPrecisionTangentBasis")]
	public bool UseHighPrecisionTangentBasis;

	private static bool UseFullPrecisionUVs_IsValid;

	private static FFieldAddress UseFullPrecisionUVs_PropertyAddress;

	private static int UseFullPrecisionUVs_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:bUseFullPrecisionUVs")]
	public bool UseFullPrecisionUVs;

	private static bool UseBackwardsCompatibleF16TruncUVs_IsValid;

	private static FFieldAddress UseBackwardsCompatibleF16TruncUVs_PropertyAddress;

	private static int UseBackwardsCompatibleF16TruncUVs_Offset;

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:bUseBackwardsCompatibleF16TruncUVs")]
	public bool UseBackwardsCompatibleF16TruncUVs;

	private static bool GenerateLightmapUVs_IsValid;

	private static FFieldAddress GenerateLightmapUVs_PropertyAddress;

	private static int GenerateLightmapUVs_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:bGenerateLightmapUVs")]
	public bool GenerateLightmapUVs;

	private static bool GenerateDistanceFieldAsIfTwoSided_IsValid;

	private static FFieldAddress GenerateDistanceFieldAsIfTwoSided_PropertyAddress;

	private static int GenerateDistanceFieldAsIfTwoSided_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:bGenerateDistanceFieldAsIfTwoSided")]
	public bool GenerateDistanceFieldAsIfTwoSided;

	private static bool SupportFaceRemap_IsValid;

	private static FFieldAddress SupportFaceRemap_PropertyAddress;

	private static int SupportFaceRemap_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:bSupportFaceRemap")]
	public bool SupportFaceRemap;

	private static bool MinLightmapResolution_IsValid;

	private static int MinLightmapResolution_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:MinLightmapResolution")]
	public int MinLightmapResolution;

	private static bool SrcLightmapIndex_IsValid;

	private static int SrcLightmapIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:SrcLightmapIndex")]
	public int SrcLightmapIndex;

	private static bool DstLightmapIndex_IsValid;

	private static int DstLightmapIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:DstLightmapIndex")]
	public int DstLightmapIndex;

	private static bool BuildScale3D_IsValid;

	private static int BuildScale3D_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:BuildScale3D")]
	public FVector BuildScale3D;

	private static bool DistanceFieldResolutionScale_IsValid;

	private static int DistanceFieldResolutionScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:DistanceFieldResolutionScale")]
	public float DistanceFieldResolutionScale;

	private static bool DistanceFieldReplacementMesh_IsValid;

	private static int DistanceFieldReplacementMesh_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:DistanceFieldReplacementMesh")]
	public UStaticMesh DistanceFieldReplacementMesh;

	private static bool MaxLumenMeshCards_IsValid;

	private static int MaxLumenMeshCards_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshBuildSettings:MaxLumenMeshCards")]
	public int MaxLumenMeshCards;

	private static bool FMeshBuildSettings_IsValid;

	private static int FMeshBuildSettings_StructSize;

	public FMeshBuildSettings Copy()
	{
		return this;
	}

	public static FMeshBuildSettings FromNative(IntPtr nativeBuffer)
	{
		return new FMeshBuildSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMeshBuildSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMeshBuildSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMeshBuildSettings(nativeBuffer + arrayIndex * FMeshBuildSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMeshBuildSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMeshBuildSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMeshBuildSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshBuildSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseMikkTSpace_Offset), 0, UseMikkTSpace_PropertyAddress.Address, UseMikkTSpace);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecomputeNormals_Offset), 0, RecomputeNormals_PropertyAddress.Address, RecomputeNormals);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecomputeTangents_Offset), 0, RecomputeTangents_PropertyAddress.Address, RecomputeTangents);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ComputeWeightedNormals_Offset), 0, ComputeWeightedNormals_PropertyAddress.Address, ComputeWeightedNormals);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RemoveDegenerates_Offset), 0, RemoveDegenerates_PropertyAddress.Address, RemoveDegenerates);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BuildReversedIndexBuffer_Offset), 0, BuildReversedIndexBuffer_PropertyAddress.Address, BuildReversedIndexBuffer);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseHighPrecisionTangentBasis_Offset), 0, UseHighPrecisionTangentBasis_PropertyAddress.Address, UseHighPrecisionTangentBasis);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseFullPrecisionUVs_Offset), 0, UseFullPrecisionUVs_PropertyAddress.Address, UseFullPrecisionUVs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseBackwardsCompatibleF16TruncUVs_Offset), 0, UseBackwardsCompatibleF16TruncUVs_PropertyAddress.Address, UseBackwardsCompatibleF16TruncUVs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GenerateLightmapUVs_Offset), 0, GenerateLightmapUVs_PropertyAddress.Address, GenerateLightmapUVs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GenerateDistanceFieldAsIfTwoSided_Offset), 0, GenerateDistanceFieldAsIfTwoSided_PropertyAddress.Address, GenerateDistanceFieldAsIfTwoSided);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SupportFaceRemap_Offset), 0, SupportFaceRemap_PropertyAddress.Address, SupportFaceRemap);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MinLightmapResolution_Offset), MinLightmapResolution);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SrcLightmapIndex_Offset), SrcLightmapIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DstLightmapIndex_Offset), DstLightmapIndex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, BuildScale3D_Offset), BuildScale3D);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DistanceFieldResolutionScale_Offset), DistanceFieldResolutionScale);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(nativeStruct, DistanceFieldReplacementMesh_Offset), DistanceFieldReplacementMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxLumenMeshCards_Offset), MaxLumenMeshCards);
	}

	public FMeshBuildSettings(IntPtr nativeStruct)
	{
		if (!FMeshBuildSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshBuildSettings");
			UseMikkTSpace = false;
			RecomputeNormals = false;
			RecomputeTangents = false;
			ComputeWeightedNormals = false;
			RemoveDegenerates = false;
			BuildReversedIndexBuffer = false;
			UseHighPrecisionTangentBasis = false;
			UseFullPrecisionUVs = false;
			UseBackwardsCompatibleF16TruncUVs = false;
			GenerateLightmapUVs = false;
			GenerateDistanceFieldAsIfTwoSided = false;
			SupportFaceRemap = false;
			MinLightmapResolution = 0;
			SrcLightmapIndex = 0;
			DstLightmapIndex = 0;
			BuildScale3D = default(FVector);
			DistanceFieldResolutionScale = 0f;
			DistanceFieldReplacementMesh = null;
			MaxLumenMeshCards = 0;
		}
		else
		{
			UseMikkTSpace = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseMikkTSpace_Offset), 0, UseMikkTSpace_PropertyAddress.Address);
			RecomputeNormals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecomputeNormals_Offset), 0, RecomputeNormals_PropertyAddress.Address);
			RecomputeTangents = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecomputeTangents_Offset), 0, RecomputeTangents_PropertyAddress.Address);
			ComputeWeightedNormals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ComputeWeightedNormals_Offset), 0, ComputeWeightedNormals_PropertyAddress.Address);
			RemoveDegenerates = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RemoveDegenerates_Offset), 0, RemoveDegenerates_PropertyAddress.Address);
			BuildReversedIndexBuffer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BuildReversedIndexBuffer_Offset), 0, BuildReversedIndexBuffer_PropertyAddress.Address);
			UseHighPrecisionTangentBasis = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseHighPrecisionTangentBasis_Offset), 0, UseHighPrecisionTangentBasis_PropertyAddress.Address);
			UseFullPrecisionUVs = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseFullPrecisionUVs_Offset), 0, UseFullPrecisionUVs_PropertyAddress.Address);
			UseBackwardsCompatibleF16TruncUVs = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseBackwardsCompatibleF16TruncUVs_Offset), 0, UseBackwardsCompatibleF16TruncUVs_PropertyAddress.Address);
			GenerateLightmapUVs = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GenerateLightmapUVs_Offset), 0, GenerateLightmapUVs_PropertyAddress.Address);
			GenerateDistanceFieldAsIfTwoSided = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GenerateDistanceFieldAsIfTwoSided_Offset), 0, GenerateDistanceFieldAsIfTwoSided_PropertyAddress.Address);
			SupportFaceRemap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SupportFaceRemap_Offset), 0, SupportFaceRemap_PropertyAddress.Address);
			MinLightmapResolution = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MinLightmapResolution_Offset));
			SrcLightmapIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SrcLightmapIndex_Offset));
			DstLightmapIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DstLightmapIndex_Offset));
			BuildScale3D = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, BuildScale3D_Offset));
			DistanceFieldResolutionScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DistanceFieldResolutionScale_Offset));
			DistanceFieldReplacementMesh = UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(nativeStruct, DistanceFieldReplacementMesh_Offset));
			MaxLumenMeshCards = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxLumenMeshCards_Offset));
		}
	}

	static FMeshBuildSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMeshBuildSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMeshBuildSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MeshBuildSettings");
		FMeshBuildSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref UseMikkTSpace_PropertyAddress, intPtr, "bUseMikkTSpace");
		UseMikkTSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseMikkTSpace");
		UseMikkTSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseMikkTSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RecomputeNormals_PropertyAddress, intPtr, "bRecomputeNormals");
		RecomputeNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecomputeNormals");
		RecomputeNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecomputeNormals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RecomputeTangents_PropertyAddress, intPtr, "bRecomputeTangents");
		RecomputeTangents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecomputeTangents");
		RecomputeTangents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecomputeTangents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeWeightedNormals_PropertyAddress, intPtr, "bComputeWeightedNormals");
		ComputeWeightedNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bComputeWeightedNormals");
		ComputeWeightedNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bComputeWeightedNormals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveDegenerates_PropertyAddress, intPtr, "bRemoveDegenerates");
		RemoveDegenerates_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRemoveDegenerates");
		RemoveDegenerates_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRemoveDegenerates", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildReversedIndexBuffer_PropertyAddress, intPtr, "bBuildReversedIndexBuffer");
		BuildReversedIndexBuffer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBuildReversedIndexBuffer");
		BuildReversedIndexBuffer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBuildReversedIndexBuffer", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseHighPrecisionTangentBasis_PropertyAddress, intPtr, "bUseHighPrecisionTangentBasis");
		UseHighPrecisionTangentBasis_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseHighPrecisionTangentBasis");
		UseHighPrecisionTangentBasis_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseHighPrecisionTangentBasis", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseFullPrecisionUVs_PropertyAddress, intPtr, "bUseFullPrecisionUVs");
		UseFullPrecisionUVs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseFullPrecisionUVs");
		UseFullPrecisionUVs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseFullPrecisionUVs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseBackwardsCompatibleF16TruncUVs_PropertyAddress, intPtr, "bUseBackwardsCompatibleF16TruncUVs");
		UseBackwardsCompatibleF16TruncUVs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseBackwardsCompatibleF16TruncUVs");
		UseBackwardsCompatibleF16TruncUVs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseBackwardsCompatibleF16TruncUVs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateLightmapUVs_PropertyAddress, intPtr, "bGenerateLightmapUVs");
		GenerateLightmapUVs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateLightmapUVs");
		GenerateLightmapUVs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateLightmapUVs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateDistanceFieldAsIfTwoSided_PropertyAddress, intPtr, "bGenerateDistanceFieldAsIfTwoSided");
		GenerateDistanceFieldAsIfTwoSided_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateDistanceFieldAsIfTwoSided");
		GenerateDistanceFieldAsIfTwoSided_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateDistanceFieldAsIfTwoSided", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SupportFaceRemap_PropertyAddress, intPtr, "bSupportFaceRemap");
		SupportFaceRemap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSupportFaceRemap");
		SupportFaceRemap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSupportFaceRemap", Classes.FBoolProperty);
		MinLightmapResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinLightmapResolution");
		MinLightmapResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinLightmapResolution", Classes.FIntProperty);
		SrcLightmapIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SrcLightmapIndex");
		SrcLightmapIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SrcLightmapIndex", Classes.FIntProperty);
		DstLightmapIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DstLightmapIndex");
		DstLightmapIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DstLightmapIndex", Classes.FIntProperty);
		BuildScale3D_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BuildScale3D");
		BuildScale3D_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BuildScale3D", Classes.FStructProperty);
		DistanceFieldResolutionScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceFieldResolutionScale");
		DistanceFieldResolutionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceFieldResolutionScale", Classes.FFloatProperty);
		DistanceFieldReplacementMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceFieldReplacementMesh");
		DistanceFieldReplacementMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceFieldReplacementMesh", Classes.FObjectProperty);
		MaxLumenMeshCards_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxLumenMeshCards");
		MaxLumenMeshCards_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxLumenMeshCards", Classes.FIntProperty);
		FMeshBuildSettings_IsValid = intPtr != IntPtr.Zero && UseMikkTSpace_IsValid && RecomputeNormals_IsValid && RecomputeTangents_IsValid && ComputeWeightedNormals_IsValid && RemoveDegenerates_IsValid && BuildReversedIndexBuffer_IsValid && UseHighPrecisionTangentBasis_IsValid && UseFullPrecisionUVs_IsValid && UseBackwardsCompatibleF16TruncUVs_IsValid && GenerateLightmapUVs_IsValid && GenerateDistanceFieldAsIfTwoSided_IsValid && SupportFaceRemap_IsValid && MinLightmapResolution_IsValid && SrcLightmapIndex_IsValid && DstLightmapIndex_IsValid && BuildScale3D_IsValid && DistanceFieldResolutionScale_IsValid && DistanceFieldReplacementMesh_IsValid && MaxLumenMeshCards_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.MeshBuildSettings", FMeshBuildSettings_IsValid);
	}
}
