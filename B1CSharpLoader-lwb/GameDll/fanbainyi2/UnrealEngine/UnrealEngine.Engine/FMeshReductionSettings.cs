using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.MeshReductionSettings", "Engine", UnrealModuleType.Engine)]
public struct FMeshReductionSettings
{
	private static bool PercentTriangles_IsValid;

	private static int PercentTriangles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:PercentTriangles")]
	public float PercentTriangles;

	private static bool PercentVertices_IsValid;

	private static int PercentVertices_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:PercentVertices")]
	public float PercentVertices;

	private static bool MaxDeviation_IsValid;

	private static int MaxDeviation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:MaxDeviation")]
	public float MaxDeviation;

	private static bool PixelError_IsValid;

	private static int PixelError_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:PixelError")]
	public float PixelError;

	private static bool WeldingThreshold_IsValid;

	private static int WeldingThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:WeldingThreshold")]
	public float WeldingThreshold;

	private static bool HardAngleThreshold_IsValid;

	private static int HardAngleThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:HardAngleThreshold")]
	public float HardAngleThreshold;

	private static bool BaseLODModel_IsValid;

	private static int BaseLODModel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:BaseLODModel")]
	public int BaseLODModel;

	private static bool SilhouetteImportance_IsValid;

	private static FFieldAddress SilhouetteImportance_PropertyAddress;

	private static int SilhouetteImportance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:SilhouetteImportance")]
	public EMeshFeatureImportance SilhouetteImportance;

	private static bool TextureImportance_IsValid;

	private static FFieldAddress TextureImportance_PropertyAddress;

	private static int TextureImportance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:TextureImportance")]
	public EMeshFeatureImportance TextureImportance;

	private static bool ShadingImportance_IsValid;

	private static FFieldAddress ShadingImportance_PropertyAddress;

	private static int ShadingImportance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:ShadingImportance")]
	public EMeshFeatureImportance ShadingImportance;

	private static bool RecalculateNormals_IsValid;

	private static FFieldAddress RecalculateNormals_PropertyAddress;

	private static int RecalculateNormals_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:bRecalculateNormals")]
	public bool RecalculateNormals;

	private static bool GenerateUniqueLightmapUVs_IsValid;

	private static FFieldAddress GenerateUniqueLightmapUVs_PropertyAddress;

	private static int GenerateUniqueLightmapUVs_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:bGenerateUniqueLightmapUVs")]
	public bool GenerateUniqueLightmapUVs;

	private static bool KeepSymmetry_IsValid;

	private static FFieldAddress KeepSymmetry_PropertyAddress;

	private static int KeepSymmetry_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:bKeepSymmetry")]
	public bool KeepSymmetry;

	private static bool VisibilityAided_IsValid;

	private static FFieldAddress VisibilityAided_PropertyAddress;

	private static int VisibilityAided_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:bVisibilityAided")]
	public bool VisibilityAided;

	private static bool CullOccluded_IsValid;

	private static FFieldAddress CullOccluded_PropertyAddress;

	private static int CullOccluded_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:bCullOccluded")]
	public bool CullOccluded;

	private static bool TerminationCriterion_IsValid;

	private static FFieldAddress TerminationCriterion_PropertyAddress;

	private static int TerminationCriterion_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:TerminationCriterion")]
	public EStaticMeshReductionTerimationCriterion TerminationCriterion;

	private static bool VisibilityAggressiveness_IsValid;

	private static FFieldAddress VisibilityAggressiveness_PropertyAddress;

	private static int VisibilityAggressiveness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:VisibilityAggressiveness")]
	public EMeshFeatureImportance VisibilityAggressiveness;

	private static bool VertexColorImportance_IsValid;

	private static FFieldAddress VertexColorImportance_PropertyAddress;

	private static int VertexColorImportance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshReductionSettings:VertexColorImportance")]
	public EMeshFeatureImportance VertexColorImportance;

	private static bool FMeshReductionSettings_IsValid;

	private static int FMeshReductionSettings_StructSize;

	public FMeshReductionSettings Copy()
	{
		return this;
	}

	public static FMeshReductionSettings FromNative(IntPtr nativeBuffer)
	{
		return new FMeshReductionSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMeshReductionSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMeshReductionSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMeshReductionSettings(nativeBuffer + arrayIndex * FMeshReductionSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMeshReductionSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMeshReductionSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMeshReductionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshReductionSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PercentTriangles_Offset), PercentTriangles);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PercentVertices_Offset), PercentVertices);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxDeviation_Offset), MaxDeviation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PixelError_Offset), PixelError);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WeldingThreshold_Offset), WeldingThreshold);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HardAngleThreshold_Offset), HardAngleThreshold);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BaseLODModel_Offset), BaseLODModel);
		EnumMarshaler<EMeshFeatureImportance>.ToNative(IntPtr.Add(nativeStruct, SilhouetteImportance_Offset), 0, SilhouetteImportance_PropertyAddress.Address, SilhouetteImportance);
		EnumMarshaler<EMeshFeatureImportance>.ToNative(IntPtr.Add(nativeStruct, TextureImportance_Offset), 0, TextureImportance_PropertyAddress.Address, TextureImportance);
		EnumMarshaler<EMeshFeatureImportance>.ToNative(IntPtr.Add(nativeStruct, ShadingImportance_Offset), 0, ShadingImportance_PropertyAddress.Address, ShadingImportance);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecalculateNormals_Offset), 0, RecalculateNormals_PropertyAddress.Address, RecalculateNormals);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GenerateUniqueLightmapUVs_Offset), 0, GenerateUniqueLightmapUVs_PropertyAddress.Address, GenerateUniqueLightmapUVs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, KeepSymmetry_Offset), 0, KeepSymmetry_PropertyAddress.Address, KeepSymmetry);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, VisibilityAided_Offset), 0, VisibilityAided_PropertyAddress.Address, VisibilityAided);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CullOccluded_Offset), 0, CullOccluded_PropertyAddress.Address, CullOccluded);
		EnumMarshaler<EStaticMeshReductionTerimationCriterion>.ToNative(IntPtr.Add(nativeStruct, TerminationCriterion_Offset), 0, TerminationCriterion_PropertyAddress.Address, TerminationCriterion);
		EnumMarshaler<EMeshFeatureImportance>.ToNative(IntPtr.Add(nativeStruct, VisibilityAggressiveness_Offset), 0, VisibilityAggressiveness_PropertyAddress.Address, VisibilityAggressiveness);
		EnumMarshaler<EMeshFeatureImportance>.ToNative(IntPtr.Add(nativeStruct, VertexColorImportance_Offset), 0, VertexColorImportance_PropertyAddress.Address, VertexColorImportance);
	}

	public FMeshReductionSettings(IntPtr nativeStruct)
	{
		if (!FMeshReductionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshReductionSettings");
			PercentTriangles = 0f;
			PercentVertices = 0f;
			MaxDeviation = 0f;
			PixelError = 0f;
			WeldingThreshold = 0f;
			HardAngleThreshold = 0f;
			BaseLODModel = 0;
			SilhouetteImportance = EMeshFeatureImportance.Off;
			TextureImportance = EMeshFeatureImportance.Off;
			ShadingImportance = EMeshFeatureImportance.Off;
			RecalculateNormals = false;
			GenerateUniqueLightmapUVs = false;
			KeepSymmetry = false;
			VisibilityAided = false;
			CullOccluded = false;
			TerminationCriterion = EStaticMeshReductionTerimationCriterion.Triangles;
			VisibilityAggressiveness = EMeshFeatureImportance.Off;
			VertexColorImportance = EMeshFeatureImportance.Off;
		}
		else
		{
			PercentTriangles = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PercentTriangles_Offset));
			PercentVertices = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PercentVertices_Offset));
			MaxDeviation = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxDeviation_Offset));
			PixelError = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PixelError_Offset));
			WeldingThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WeldingThreshold_Offset));
			HardAngleThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HardAngleThreshold_Offset));
			BaseLODModel = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BaseLODModel_Offset));
			SilhouetteImportance = EnumMarshaler<EMeshFeatureImportance>.FromNative(IntPtr.Add(nativeStruct, SilhouetteImportance_Offset), 0, SilhouetteImportance_PropertyAddress.Address);
			TextureImportance = EnumMarshaler<EMeshFeatureImportance>.FromNative(IntPtr.Add(nativeStruct, TextureImportance_Offset), 0, TextureImportance_PropertyAddress.Address);
			ShadingImportance = EnumMarshaler<EMeshFeatureImportance>.FromNative(IntPtr.Add(nativeStruct, ShadingImportance_Offset), 0, ShadingImportance_PropertyAddress.Address);
			RecalculateNormals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecalculateNormals_Offset), 0, RecalculateNormals_PropertyAddress.Address);
			GenerateUniqueLightmapUVs = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GenerateUniqueLightmapUVs_Offset), 0, GenerateUniqueLightmapUVs_PropertyAddress.Address);
			KeepSymmetry = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, KeepSymmetry_Offset), 0, KeepSymmetry_PropertyAddress.Address);
			VisibilityAided = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, VisibilityAided_Offset), 0, VisibilityAided_PropertyAddress.Address);
			CullOccluded = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CullOccluded_Offset), 0, CullOccluded_PropertyAddress.Address);
			TerminationCriterion = EnumMarshaler<EStaticMeshReductionTerimationCriterion>.FromNative(IntPtr.Add(nativeStruct, TerminationCriterion_Offset), 0, TerminationCriterion_PropertyAddress.Address);
			VisibilityAggressiveness = EnumMarshaler<EMeshFeatureImportance>.FromNative(IntPtr.Add(nativeStruct, VisibilityAggressiveness_Offset), 0, VisibilityAggressiveness_PropertyAddress.Address);
			VertexColorImportance = EnumMarshaler<EMeshFeatureImportance>.FromNative(IntPtr.Add(nativeStruct, VertexColorImportance_Offset), 0, VertexColorImportance_PropertyAddress.Address);
		}
	}

	static FMeshReductionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMeshReductionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMeshReductionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MeshReductionSettings");
		FMeshReductionSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		PercentTriangles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PercentTriangles");
		PercentTriangles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PercentTriangles", Classes.FFloatProperty);
		PercentVertices_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PercentVertices");
		PercentVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PercentVertices", Classes.FFloatProperty);
		MaxDeviation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxDeviation");
		MaxDeviation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxDeviation", Classes.FFloatProperty);
		PixelError_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PixelError");
		PixelError_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PixelError", Classes.FFloatProperty);
		WeldingThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeldingThreshold");
		WeldingThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeldingThreshold", Classes.FFloatProperty);
		HardAngleThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HardAngleThreshold");
		HardAngleThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HardAngleThreshold", Classes.FFloatProperty);
		BaseLODModel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BaseLODModel");
		BaseLODModel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BaseLODModel", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SilhouetteImportance_PropertyAddress, intPtr, "SilhouetteImportance");
		SilhouetteImportance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SilhouetteImportance");
		SilhouetteImportance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SilhouetteImportance", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref TextureImportance_PropertyAddress, intPtr, "TextureImportance");
		TextureImportance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextureImportance");
		TextureImportance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextureImportance", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ShadingImportance_PropertyAddress, intPtr, "ShadingImportance");
		ShadingImportance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadingImportance");
		ShadingImportance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadingImportance", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref RecalculateNormals_PropertyAddress, intPtr, "bRecalculateNormals");
		RecalculateNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecalculateNormals");
		RecalculateNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecalculateNormals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateUniqueLightmapUVs_PropertyAddress, intPtr, "bGenerateUniqueLightmapUVs");
		GenerateUniqueLightmapUVs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateUniqueLightmapUVs");
		GenerateUniqueLightmapUVs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateUniqueLightmapUVs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref KeepSymmetry_PropertyAddress, intPtr, "bKeepSymmetry");
		KeepSymmetry_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bKeepSymmetry");
		KeepSymmetry_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bKeepSymmetry", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VisibilityAided_PropertyAddress, intPtr, "bVisibilityAided");
		VisibilityAided_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bVisibilityAided");
		VisibilityAided_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bVisibilityAided", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CullOccluded_PropertyAddress, intPtr, "bCullOccluded");
		CullOccluded_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCullOccluded");
		CullOccluded_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCullOccluded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TerminationCriterion_PropertyAddress, intPtr, "TerminationCriterion");
		TerminationCriterion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TerminationCriterion");
		TerminationCriterion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TerminationCriterion", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref VisibilityAggressiveness_PropertyAddress, intPtr, "VisibilityAggressiveness");
		VisibilityAggressiveness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VisibilityAggressiveness");
		VisibilityAggressiveness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VisibilityAggressiveness", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref VertexColorImportance_PropertyAddress, intPtr, "VertexColorImportance");
		VertexColorImportance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VertexColorImportance");
		VertexColorImportance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VertexColorImportance", Classes.FByteProperty);
		FMeshReductionSettings_IsValid = intPtr != IntPtr.Zero && PercentTriangles_IsValid && PercentVertices_IsValid && MaxDeviation_IsValid && PixelError_IsValid && WeldingThreshold_IsValid && HardAngleThreshold_IsValid && BaseLODModel_IsValid && SilhouetteImportance_IsValid && TextureImportance_IsValid && ShadingImportance_IsValid && RecalculateNormals_IsValid && GenerateUniqueLightmapUVs_IsValid && KeepSymmetry_IsValid && VisibilityAided_IsValid && CullOccluded_IsValid && TerminationCriterion_IsValid && VisibilityAggressiveness_IsValid && VertexColorImportance_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.MeshReductionSettings", FMeshReductionSettings_IsValid);
	}
}
