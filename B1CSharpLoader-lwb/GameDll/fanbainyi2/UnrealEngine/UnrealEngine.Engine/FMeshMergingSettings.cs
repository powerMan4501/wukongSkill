using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.MeshMergingSettings", "Engine", UnrealModuleType.Engine)]
public struct FMeshMergingSettings
{
	private static bool TargetLightMapResolution_IsValid;

	private static int TargetLightMapResolution_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:TargetLightMapResolution")]
	public int TargetLightMapResolution;

	private static bool MaterialSettings_IsValid;

	private static int MaterialSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:MaterialSettings")]
	public FMaterialProxySettings MaterialSettings;

	private static bool SpecificLOD_IsValid;

	private static int SpecificLOD_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:SpecificLOD")]
	public int SpecificLOD;

	private static bool LODSelectionType_IsValid;

	private static FFieldAddress LODSelectionType_PropertyAddress;

	private static int LODSelectionType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:LODSelectionType")]
	public EMeshLODSelectionType LODSelectionType;

	private static bool GenerateLightMapUV_IsValid;

	private static FFieldAddress GenerateLightMapUV_PropertyAddress;

	private static int GenerateLightMapUV_Offset;

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:bGenerateLightMapUV")]
	public bool GenerateLightMapUV;

	private static bool ComputedLightMapResolution_IsValid;

	private static FFieldAddress ComputedLightMapResolution_PropertyAddress;

	private static int ComputedLightMapResolution_Offset;

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:bComputedLightMapResolution")]
	public bool ComputedLightMapResolution;

	private static bool PivotPointAtZero_IsValid;

	private static FFieldAddress PivotPointAtZero_PropertyAddress;

	private static int PivotPointAtZero_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:bPivotPointAtZero")]
	public bool PivotPointAtZero;

	private static bool MergePhysicsData_IsValid;

	private static FFieldAddress MergePhysicsData_PropertyAddress;

	private static int MergePhysicsData_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:bMergePhysicsData")]
	public bool MergePhysicsData;

	private static bool MergeMaterials_IsValid;

	private static FFieldAddress MergeMaterials_PropertyAddress;

	private static int MergeMaterials_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:bMergeMaterials")]
	public bool MergeMaterials;

	private static bool CreateMergedMaterial_IsValid;

	private static FFieldAddress CreateMergedMaterial_PropertyAddress;

	private static int CreateMergedMaterial_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:bCreateMergedMaterial")]
	public bool CreateMergedMaterial;

	private static bool BakeVertexDataToMesh_IsValid;

	private static FFieldAddress BakeVertexDataToMesh_PropertyAddress;

	private static int BakeVertexDataToMesh_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:bBakeVertexDataToMesh")]
	public bool BakeVertexDataToMesh;

	private static bool UseVertexDataForBakingMaterial_IsValid;

	private static FFieldAddress UseVertexDataForBakingMaterial_PropertyAddress;

	private static int UseVertexDataForBakingMaterial_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:bUseVertexDataForBakingMaterial")]
	public bool UseVertexDataForBakingMaterial;

	private static bool UseTextureBinning_IsValid;

	private static FFieldAddress UseTextureBinning_PropertyAddress;

	private static int UseTextureBinning_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:bUseTextureBinning")]
	public bool UseTextureBinning;

	private static bool UseLandscapeCulling_IsValid;

	private static FFieldAddress UseLandscapeCulling_PropertyAddress;

	private static int UseLandscapeCulling_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:bUseLandscapeCulling")]
	public bool UseLandscapeCulling;

	private static bool IncludeImposters_IsValid;

	private static FFieldAddress IncludeImposters_PropertyAddress;

	private static int IncludeImposters_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:bIncludeImposters")]
	public bool IncludeImposters;

	private static bool GenerateNaniteEnabledMesh_IsValid;

	private static FFieldAddress GenerateNaniteEnabledMesh_PropertyAddress;

	private static int GenerateNaniteEnabledMesh_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:bGenerateNaniteEnabledMesh")]
	public bool GenerateNaniteEnabledMesh;

	private static bool NaniteFallbackTrianglePercent_IsValid;

	private static int NaniteFallbackTrianglePercent_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MeshMergingSettings:NaniteFallbackTrianglePercent")]
	public float NaniteFallbackTrianglePercent;

	private static bool FMeshMergingSettings_IsValid;

	private static int FMeshMergingSettings_StructSize;

	public FMeshMergingSettings Copy()
	{
		return this;
	}

	public static FMeshMergingSettings FromNative(IntPtr nativeBuffer)
	{
		return new FMeshMergingSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMeshMergingSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMeshMergingSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMeshMergingSettings(nativeBuffer + arrayIndex * FMeshMergingSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMeshMergingSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMeshMergingSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMeshMergingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshMergingSettings");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetLightMapResolution_Offset), TargetLightMapResolution);
		FMaterialProxySettings.ToNative(IntPtr.Add(nativeStruct, MaterialSettings_Offset), MaterialSettings);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SpecificLOD_Offset), SpecificLOD);
		EnumMarshaler<EMeshLODSelectionType>.ToNative(IntPtr.Add(nativeStruct, LODSelectionType_Offset), 0, LODSelectionType_PropertyAddress.Address, LODSelectionType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GenerateLightMapUV_Offset), 0, GenerateLightMapUV_PropertyAddress.Address, GenerateLightMapUV);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ComputedLightMapResolution_Offset), 0, ComputedLightMapResolution_PropertyAddress.Address, ComputedLightMapResolution);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, PivotPointAtZero_Offset), 0, PivotPointAtZero_PropertyAddress.Address, PivotPointAtZero);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MergePhysicsData_Offset), 0, MergePhysicsData_PropertyAddress.Address, MergePhysicsData);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MergeMaterials_Offset), 0, MergeMaterials_PropertyAddress.Address, MergeMaterials);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CreateMergedMaterial_Offset), 0, CreateMergedMaterial_PropertyAddress.Address, CreateMergedMaterial);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BakeVertexDataToMesh_Offset), 0, BakeVertexDataToMesh_PropertyAddress.Address, BakeVertexDataToMesh);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseVertexDataForBakingMaterial_Offset), 0, UseVertexDataForBakingMaterial_PropertyAddress.Address, UseVertexDataForBakingMaterial);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseTextureBinning_Offset), 0, UseTextureBinning_PropertyAddress.Address, UseTextureBinning);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseLandscapeCulling_Offset), 0, UseLandscapeCulling_PropertyAddress.Address, UseLandscapeCulling);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeImposters_Offset), 0, IncludeImposters_PropertyAddress.Address, IncludeImposters);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GenerateNaniteEnabledMesh_Offset), 0, GenerateNaniteEnabledMesh_PropertyAddress.Address, GenerateNaniteEnabledMesh);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NaniteFallbackTrianglePercent_Offset), NaniteFallbackTrianglePercent);
	}

	public FMeshMergingSettings(IntPtr nativeStruct)
	{
		if (!FMeshMergingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshMergingSettings");
			TargetLightMapResolution = 0;
			MaterialSettings = default(FMaterialProxySettings);
			SpecificLOD = 0;
			LODSelectionType = EMeshLODSelectionType.AllLODs;
			GenerateLightMapUV = false;
			ComputedLightMapResolution = false;
			PivotPointAtZero = false;
			MergePhysicsData = false;
			MergeMaterials = false;
			CreateMergedMaterial = false;
			BakeVertexDataToMesh = false;
			UseVertexDataForBakingMaterial = false;
			UseTextureBinning = false;
			UseLandscapeCulling = false;
			IncludeImposters = false;
			GenerateNaniteEnabledMesh = false;
			NaniteFallbackTrianglePercent = 0f;
		}
		else
		{
			TargetLightMapResolution = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetLightMapResolution_Offset));
			MaterialSettings = FMaterialProxySettings.FromNative(IntPtr.Add(nativeStruct, MaterialSettings_Offset));
			SpecificLOD = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SpecificLOD_Offset));
			LODSelectionType = EnumMarshaler<EMeshLODSelectionType>.FromNative(IntPtr.Add(nativeStruct, LODSelectionType_Offset), 0, LODSelectionType_PropertyAddress.Address);
			GenerateLightMapUV = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GenerateLightMapUV_Offset), 0, GenerateLightMapUV_PropertyAddress.Address);
			ComputedLightMapResolution = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ComputedLightMapResolution_Offset), 0, ComputedLightMapResolution_PropertyAddress.Address);
			PivotPointAtZero = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, PivotPointAtZero_Offset), 0, PivotPointAtZero_PropertyAddress.Address);
			MergePhysicsData = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MergePhysicsData_Offset), 0, MergePhysicsData_PropertyAddress.Address);
			MergeMaterials = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MergeMaterials_Offset), 0, MergeMaterials_PropertyAddress.Address);
			CreateMergedMaterial = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CreateMergedMaterial_Offset), 0, CreateMergedMaterial_PropertyAddress.Address);
			BakeVertexDataToMesh = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BakeVertexDataToMesh_Offset), 0, BakeVertexDataToMesh_PropertyAddress.Address);
			UseVertexDataForBakingMaterial = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseVertexDataForBakingMaterial_Offset), 0, UseVertexDataForBakingMaterial_PropertyAddress.Address);
			UseTextureBinning = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseTextureBinning_Offset), 0, UseTextureBinning_PropertyAddress.Address);
			UseLandscapeCulling = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseLandscapeCulling_Offset), 0, UseLandscapeCulling_PropertyAddress.Address);
			IncludeImposters = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeImposters_Offset), 0, IncludeImposters_PropertyAddress.Address);
			GenerateNaniteEnabledMesh = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GenerateNaniteEnabledMesh_Offset), 0, GenerateNaniteEnabledMesh_PropertyAddress.Address);
			NaniteFallbackTrianglePercent = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NaniteFallbackTrianglePercent_Offset));
		}
	}

	static FMeshMergingSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMeshMergingSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMeshMergingSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MeshMergingSettings");
		FMeshMergingSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		TargetLightMapResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetLightMapResolution");
		TargetLightMapResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetLightMapResolution", Classes.FIntProperty);
		MaterialSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialSettings");
		MaterialSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialSettings", Classes.FStructProperty);
		SpecificLOD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpecificLOD");
		SpecificLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpecificLOD", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref LODSelectionType_PropertyAddress, intPtr, "LODSelectionType");
		LODSelectionType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODSelectionType");
		LODSelectionType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODSelectionType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateLightMapUV_PropertyAddress, intPtr, "bGenerateLightMapUV");
		GenerateLightMapUV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateLightMapUV");
		GenerateLightMapUV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateLightMapUV", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputedLightMapResolution_PropertyAddress, intPtr, "bComputedLightMapResolution");
		ComputedLightMapResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bComputedLightMapResolution");
		ComputedLightMapResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bComputedLightMapResolution", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PivotPointAtZero_PropertyAddress, intPtr, "bPivotPointAtZero");
		PivotPointAtZero_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPivotPointAtZero");
		PivotPointAtZero_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPivotPointAtZero", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MergePhysicsData_PropertyAddress, intPtr, "bMergePhysicsData");
		MergePhysicsData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMergePhysicsData");
		MergePhysicsData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMergePhysicsData", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeMaterials_PropertyAddress, intPtr, "bMergeMaterials");
		MergeMaterials_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMergeMaterials");
		MergeMaterials_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMergeMaterials", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateMergedMaterial_PropertyAddress, intPtr, "bCreateMergedMaterial");
		CreateMergedMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCreateMergedMaterial");
		CreateMergedMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCreateMergedMaterial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BakeVertexDataToMesh_PropertyAddress, intPtr, "bBakeVertexDataToMesh");
		BakeVertexDataToMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBakeVertexDataToMesh");
		BakeVertexDataToMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBakeVertexDataToMesh", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseVertexDataForBakingMaterial_PropertyAddress, intPtr, "bUseVertexDataForBakingMaterial");
		UseVertexDataForBakingMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseVertexDataForBakingMaterial");
		UseVertexDataForBakingMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseVertexDataForBakingMaterial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseTextureBinning_PropertyAddress, intPtr, "bUseTextureBinning");
		UseTextureBinning_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseTextureBinning");
		UseTextureBinning_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseTextureBinning", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseLandscapeCulling_PropertyAddress, intPtr, "bUseLandscapeCulling");
		UseLandscapeCulling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseLandscapeCulling");
		UseLandscapeCulling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseLandscapeCulling", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IncludeImposters_PropertyAddress, intPtr, "bIncludeImposters");
		IncludeImposters_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIncludeImposters");
		IncludeImposters_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIncludeImposters", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateNaniteEnabledMesh_PropertyAddress, intPtr, "bGenerateNaniteEnabledMesh");
		GenerateNaniteEnabledMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateNaniteEnabledMesh");
		GenerateNaniteEnabledMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateNaniteEnabledMesh", Classes.FBoolProperty);
		NaniteFallbackTrianglePercent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NaniteFallbackTrianglePercent");
		NaniteFallbackTrianglePercent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NaniteFallbackTrianglePercent", Classes.FFloatProperty);
		FMeshMergingSettings_IsValid = intPtr != IntPtr.Zero && TargetLightMapResolution_IsValid && MaterialSettings_IsValid && SpecificLOD_IsValid && LODSelectionType_IsValid && GenerateLightMapUV_IsValid && ComputedLightMapResolution_IsValid && PivotPointAtZero_IsValid && MergePhysicsData_IsValid && MergeMaterials_IsValid && CreateMergedMaterial_IsValid && BakeVertexDataToMesh_IsValid && UseVertexDataForBakingMaterial_IsValid && UseTextureBinning_IsValid && UseLandscapeCulling_IsValid && IncludeImposters_IsValid && GenerateNaniteEnabledMesh_IsValid && NaniteFallbackTrianglePercent_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.MeshMergingSettings", FMeshMergingSettings_IsValid);
	}
}
