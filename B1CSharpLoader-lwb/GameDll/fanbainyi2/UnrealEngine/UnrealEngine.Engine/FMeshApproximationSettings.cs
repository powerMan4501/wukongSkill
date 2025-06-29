using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.MeshApproximationSettings", "Engine", UnrealModuleType.Engine)]
public struct FMeshApproximationSettings
{
	private static bool OutputType_IsValid;

	private static FFieldAddress OutputType_PropertyAddress;

	private static int OutputType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:OutputType")]
	public EMeshApproximationType OutputType;

	private static bool ApproximationAccuracy_IsValid;

	private static int ApproximationAccuracy_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:ApproximationAccuracy")]
	public float ApproximationAccuracy;

	private static bool ClampVoxelDimension_IsValid;

	private static int ClampVoxelDimension_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:ClampVoxelDimension")]
	public int ClampVoxelDimension;

	private static bool AttemptAutoThickening_IsValid;

	private static FFieldAddress AttemptAutoThickening_PropertyAddress;

	private static int AttemptAutoThickening_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:bAttemptAutoThickening")]
	public bool AttemptAutoThickening;

	private static bool TargetMinThicknessMultiplier_IsValid;

	private static int TargetMinThicknessMultiplier_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:TargetMinThicknessMultiplier")]
	public float TargetMinThicknessMultiplier;

	private static bool IgnoreTinyParts_IsValid;

	private static FFieldAddress IgnoreTinyParts_PropertyAddress;

	private static int IgnoreTinyParts_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:bIgnoreTinyParts")]
	public bool IgnoreTinyParts;

	private static bool TinyPartSizeMultiplier_IsValid;

	private static int TinyPartSizeMultiplier_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:TinyPartSizeMultiplier")]
	public float TinyPartSizeMultiplier;

	private static bool BaseCapping_IsValid;

	private static FFieldAddress BaseCapping_PropertyAddress;

	private static int BaseCapping_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:BaseCapping")]
	public EMeshApproximationBaseCappingType BaseCapping;

	private static bool WindingThreshold_IsValid;

	private static int WindingThreshold_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:WindingThreshold")]
	public float WindingThreshold;

	private static bool FillGaps_IsValid;

	private static FFieldAddress FillGaps_PropertyAddress;

	private static int FillGaps_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:bFillGaps")]
	public bool FillGaps;

	private static bool GapDistance_IsValid;

	private static int GapDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:GapDistance")]
	public float GapDistance;

	private static bool OcclusionMethod_IsValid;

	private static FFieldAddress OcclusionMethod_PropertyAddress;

	private static int OcclusionMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:OcclusionMethod")]
	public EOccludedGeometryFilteringPolicy OcclusionMethod;

	private static bool OccludeFromBottom_IsValid;

	private static FFieldAddress OccludeFromBottom_PropertyAddress;

	private static int OccludeFromBottom_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:bOccludeFromBottom")]
	public bool OccludeFromBottom;

	private static bool SimplifyMethod_IsValid;

	private static FFieldAddress SimplifyMethod_PropertyAddress;

	private static int SimplifyMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:SimplifyMethod")]
	public EMeshApproximationSimplificationPolicy SimplifyMethod;

	private static bool TargetTriCount_IsValid;

	private static int TargetTriCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:TargetTriCount")]
	public int TargetTriCount;

	private static bool TrianglesPerM_IsValid;

	private static int TrianglesPerM_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:TrianglesPerM")]
	public float TrianglesPerM;

	private static bool GeometricDeviation_IsValid;

	private static int GeometricDeviation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:GeometricDeviation")]
	public float GeometricDeviation;

	private static bool GroundClipping_IsValid;

	private static FFieldAddress GroundClipping_PropertyAddress;

	private static int GroundClipping_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:GroundClipping")]
	public EMeshApproximationGroundPlaneClippingPolicy GroundClipping;

	private static bool GroundClippingZHeight_IsValid;

	private static int GroundClippingZHeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:GroundClippingZHeight")]
	public float GroundClippingZHeight;

	private static bool EstimateHardNormals_IsValid;

	private static FFieldAddress EstimateHardNormals_PropertyAddress;

	private static int EstimateHardNormals_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:bEstimateHardNormals")]
	public bool EstimateHardNormals;

	private static bool HardNormalAngle_IsValid;

	private static int HardNormalAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:HardNormalAngle")]
	public float HardNormalAngle;

	private static bool UVGenerationMethod_IsValid;

	private static FFieldAddress UVGenerationMethod_PropertyAddress;

	private static int UVGenerationMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:UVGenerationMethod")]
	public EMeshApproximationUVGenerationPolicy UVGenerationMethod;

	private static bool InitialPatchCount_IsValid;

	private static int InitialPatchCount_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:InitialPatchCount")]
	public int InitialPatchCount;

	private static bool CurvatureAlignment_IsValid;

	private static int CurvatureAlignment_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:CurvatureAlignment")]
	public float CurvatureAlignment;

	private static bool MergingThreshold_IsValid;

	private static int MergingThreshold_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:MergingThreshold")]
	public float MergingThreshold;

	private static bool MaxAngleDeviation_IsValid;

	private static int MaxAngleDeviation_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:MaxAngleDeviation")]
	public float MaxAngleDeviation;

	private static bool GenerateNaniteEnabledMesh_IsValid;

	private static FFieldAddress GenerateNaniteEnabledMesh_PropertyAddress;

	private static int GenerateNaniteEnabledMesh_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:bGenerateNaniteEnabledMesh")]
	public bool GenerateNaniteEnabledMesh;

	private static bool NaniteProxyTrianglePercent_IsValid;

	private static int NaniteProxyTrianglePercent_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:NaniteProxyTrianglePercent")]
	public float NaniteProxyTrianglePercent;

	private static bool SupportRayTracing_IsValid;

	private static FFieldAddress SupportRayTracing_PropertyAddress;

	private static int SupportRayTracing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:bSupportRayTracing")]
	public bool SupportRayTracing;

	private static bool AllowDistanceField_IsValid;

	private static FFieldAddress AllowDistanceField_PropertyAddress;

	private static int AllowDistanceField_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:bAllowDistanceField")]
	public bool AllowDistanceField;

	private static bool MultiSamplingAA_IsValid;

	private static int MultiSamplingAA_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:MultiSamplingAA")]
	public int MultiSamplingAA;

	private static bool RenderCaptureResolution_IsValid;

	private static int RenderCaptureResolution_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:RenderCaptureResolution")]
	public int RenderCaptureResolution;

	private static bool MaterialSettings_IsValid;

	private static int MaterialSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:MaterialSettings")]
	public FMaterialProxySettings MaterialSettings;

	private static bool CaptureFieldOfView_IsValid;

	private static int CaptureFieldOfView_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:CaptureFieldOfView")]
	public float CaptureFieldOfView;

	private static bool NearPlaneDist_IsValid;

	private static int NearPlaneDist_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:NearPlaneDist")]
	public float NearPlaneDist;

	private static bool UseRenderLODMeshes_IsValid;

	private static FFieldAddress UseRenderLODMeshes_PropertyAddress;

	private static int UseRenderLODMeshes_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:bUseRenderLODMeshes")]
	public bool UseRenderLODMeshes;

	private static bool EnableSimplifyPrePass_IsValid;

	private static FFieldAddress EnableSimplifyPrePass_PropertyAddress;

	private static int EnableSimplifyPrePass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:bEnableSimplifyPrePass")]
	public bool EnableSimplifyPrePass;

	private static bool EnableParallelBaking_IsValid;

	private static FFieldAddress EnableParallelBaking_PropertyAddress;

	private static int EnableParallelBaking_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:bEnableParallelBaking")]
	public bool EnableParallelBaking;

	private static bool PrintDebugMessages_IsValid;

	private static FFieldAddress PrintDebugMessages_PropertyAddress;

	private static int PrintDebugMessages_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:bPrintDebugMessages")]
	public bool PrintDebugMessages;

	private static bool EmitFullDebugMesh_IsValid;

	private static FFieldAddress EmitFullDebugMesh_PropertyAddress;

	private static int EmitFullDebugMesh_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshApproximationSettings:bEmitFullDebugMesh")]
	public bool EmitFullDebugMesh;

	private static bool FMeshApproximationSettings_IsValid;

	private static int FMeshApproximationSettings_StructSize;

	public FMeshApproximationSettings Copy()
	{
		return this;
	}

	public static FMeshApproximationSettings FromNative(IntPtr nativeBuffer)
	{
		return new FMeshApproximationSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMeshApproximationSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMeshApproximationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMeshApproximationSettings(nativeBuffer + arrayIndex * FMeshApproximationSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMeshApproximationSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMeshApproximationSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMeshApproximationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshApproximationSettings");
			return;
		}
		EnumMarshaler<EMeshApproximationType>.ToNative(IntPtr.Add(nativeStruct, OutputType_Offset), 0, OutputType_PropertyAddress.Address, OutputType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ApproximationAccuracy_Offset), ApproximationAccuracy);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ClampVoxelDimension_Offset), ClampVoxelDimension);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AttemptAutoThickening_Offset), 0, AttemptAutoThickening_PropertyAddress.Address, AttemptAutoThickening);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TargetMinThicknessMultiplier_Offset), TargetMinThicknessMultiplier);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnoreTinyParts_Offset), 0, IgnoreTinyParts_PropertyAddress.Address, IgnoreTinyParts);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TinyPartSizeMultiplier_Offset), TinyPartSizeMultiplier);
		EnumMarshaler<EMeshApproximationBaseCappingType>.ToNative(IntPtr.Add(nativeStruct, BaseCapping_Offset), 0, BaseCapping_PropertyAddress.Address, BaseCapping);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WindingThreshold_Offset), WindingThreshold);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FillGaps_Offset), 0, FillGaps_PropertyAddress.Address, FillGaps);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GapDistance_Offset), GapDistance);
		EnumMarshaler<EOccludedGeometryFilteringPolicy>.ToNative(IntPtr.Add(nativeStruct, OcclusionMethod_Offset), 0, OcclusionMethod_PropertyAddress.Address, OcclusionMethod);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OccludeFromBottom_Offset), 0, OccludeFromBottom_PropertyAddress.Address, OccludeFromBottom);
		EnumMarshaler<EMeshApproximationSimplificationPolicy>.ToNative(IntPtr.Add(nativeStruct, SimplifyMethod_Offset), 0, SimplifyMethod_PropertyAddress.Address, SimplifyMethod);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetTriCount_Offset), TargetTriCount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TrianglesPerM_Offset), TrianglesPerM);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GeometricDeviation_Offset), GeometricDeviation);
		EnumMarshaler<EMeshApproximationGroundPlaneClippingPolicy>.ToNative(IntPtr.Add(nativeStruct, GroundClipping_Offset), 0, GroundClipping_PropertyAddress.Address, GroundClipping);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GroundClippingZHeight_Offset), GroundClippingZHeight);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EstimateHardNormals_Offset), 0, EstimateHardNormals_PropertyAddress.Address, EstimateHardNormals);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HardNormalAngle_Offset), HardNormalAngle);
		EnumMarshaler<EMeshApproximationUVGenerationPolicy>.ToNative(IntPtr.Add(nativeStruct, UVGenerationMethod_Offset), 0, UVGenerationMethod_PropertyAddress.Address, UVGenerationMethod);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, InitialPatchCount_Offset), InitialPatchCount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CurvatureAlignment_Offset), CurvatureAlignment);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MergingThreshold_Offset), MergingThreshold);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxAngleDeviation_Offset), MaxAngleDeviation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GenerateNaniteEnabledMesh_Offset), 0, GenerateNaniteEnabledMesh_PropertyAddress.Address, GenerateNaniteEnabledMesh);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NaniteProxyTrianglePercent_Offset), NaniteProxyTrianglePercent);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SupportRayTracing_Offset), 0, SupportRayTracing_PropertyAddress.Address, SupportRayTracing);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowDistanceField_Offset), 0, AllowDistanceField_PropertyAddress.Address, AllowDistanceField);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MultiSamplingAA_Offset), MultiSamplingAA);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RenderCaptureResolution_Offset), RenderCaptureResolution);
		FMaterialProxySettings.ToNative(IntPtr.Add(nativeStruct, MaterialSettings_Offset), MaterialSettings);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CaptureFieldOfView_Offset), CaptureFieldOfView);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NearPlaneDist_Offset), NearPlaneDist);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseRenderLODMeshes_Offset), 0, UseRenderLODMeshes_PropertyAddress.Address, UseRenderLODMeshes);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableSimplifyPrePass_Offset), 0, EnableSimplifyPrePass_PropertyAddress.Address, EnableSimplifyPrePass);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableParallelBaking_Offset), 0, EnableParallelBaking_PropertyAddress.Address, EnableParallelBaking);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, PrintDebugMessages_Offset), 0, PrintDebugMessages_PropertyAddress.Address, PrintDebugMessages);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EmitFullDebugMesh_Offset), 0, EmitFullDebugMesh_PropertyAddress.Address, EmitFullDebugMesh);
	}

	public FMeshApproximationSettings(IntPtr nativeStruct)
	{
		if (!FMeshApproximationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshApproximationSettings");
			OutputType = EMeshApproximationType.MeshAndMaterials;
			ApproximationAccuracy = 0f;
			ClampVoxelDimension = 0;
			AttemptAutoThickening = false;
			TargetMinThicknessMultiplier = 0f;
			IgnoreTinyParts = false;
			TinyPartSizeMultiplier = 0f;
			BaseCapping = EMeshApproximationBaseCappingType.NoBaseCapping;
			WindingThreshold = 0f;
			FillGaps = false;
			GapDistance = 0f;
			OcclusionMethod = EOccludedGeometryFilteringPolicy.NoOcclusionFiltering;
			OccludeFromBottom = false;
			SimplifyMethod = EMeshApproximationSimplificationPolicy.FixedTriangleCount;
			TargetTriCount = 0;
			TrianglesPerM = 0f;
			GeometricDeviation = 0f;
			GroundClipping = EMeshApproximationGroundPlaneClippingPolicy.NoGroundClipping;
			GroundClippingZHeight = 0f;
			EstimateHardNormals = false;
			HardNormalAngle = 0f;
			UVGenerationMethod = EMeshApproximationUVGenerationPolicy.PreferUVAtlas;
			InitialPatchCount = 0;
			CurvatureAlignment = 0f;
			MergingThreshold = 0f;
			MaxAngleDeviation = 0f;
			GenerateNaniteEnabledMesh = false;
			NaniteProxyTrianglePercent = 0f;
			SupportRayTracing = false;
			AllowDistanceField = false;
			MultiSamplingAA = 0;
			RenderCaptureResolution = 0;
			MaterialSettings = default(FMaterialProxySettings);
			CaptureFieldOfView = 0f;
			NearPlaneDist = 0f;
			UseRenderLODMeshes = false;
			EnableSimplifyPrePass = false;
			EnableParallelBaking = false;
			PrintDebugMessages = false;
			EmitFullDebugMesh = false;
		}
		else
		{
			OutputType = EnumMarshaler<EMeshApproximationType>.FromNative(IntPtr.Add(nativeStruct, OutputType_Offset), 0, OutputType_PropertyAddress.Address);
			ApproximationAccuracy = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ApproximationAccuracy_Offset));
			ClampVoxelDimension = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ClampVoxelDimension_Offset));
			AttemptAutoThickening = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AttemptAutoThickening_Offset), 0, AttemptAutoThickening_PropertyAddress.Address);
			TargetMinThicknessMultiplier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TargetMinThicknessMultiplier_Offset));
			IgnoreTinyParts = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IgnoreTinyParts_Offset), 0, IgnoreTinyParts_PropertyAddress.Address);
			TinyPartSizeMultiplier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TinyPartSizeMultiplier_Offset));
			BaseCapping = EnumMarshaler<EMeshApproximationBaseCappingType>.FromNative(IntPtr.Add(nativeStruct, BaseCapping_Offset), 0, BaseCapping_PropertyAddress.Address);
			WindingThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WindingThreshold_Offset));
			FillGaps = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FillGaps_Offset), 0, FillGaps_PropertyAddress.Address);
			GapDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GapDistance_Offset));
			OcclusionMethod = EnumMarshaler<EOccludedGeometryFilteringPolicy>.FromNative(IntPtr.Add(nativeStruct, OcclusionMethod_Offset), 0, OcclusionMethod_PropertyAddress.Address);
			OccludeFromBottom = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OccludeFromBottom_Offset), 0, OccludeFromBottom_PropertyAddress.Address);
			SimplifyMethod = EnumMarshaler<EMeshApproximationSimplificationPolicy>.FromNative(IntPtr.Add(nativeStruct, SimplifyMethod_Offset), 0, SimplifyMethod_PropertyAddress.Address);
			TargetTriCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetTriCount_Offset));
			TrianglesPerM = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TrianglesPerM_Offset));
			GeometricDeviation = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GeometricDeviation_Offset));
			GroundClipping = EnumMarshaler<EMeshApproximationGroundPlaneClippingPolicy>.FromNative(IntPtr.Add(nativeStruct, GroundClipping_Offset), 0, GroundClipping_PropertyAddress.Address);
			GroundClippingZHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GroundClippingZHeight_Offset));
			EstimateHardNormals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EstimateHardNormals_Offset), 0, EstimateHardNormals_PropertyAddress.Address);
			HardNormalAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HardNormalAngle_Offset));
			UVGenerationMethod = EnumMarshaler<EMeshApproximationUVGenerationPolicy>.FromNative(IntPtr.Add(nativeStruct, UVGenerationMethod_Offset), 0, UVGenerationMethod_PropertyAddress.Address);
			InitialPatchCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, InitialPatchCount_Offset));
			CurvatureAlignment = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CurvatureAlignment_Offset));
			MergingThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MergingThreshold_Offset));
			MaxAngleDeviation = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxAngleDeviation_Offset));
			GenerateNaniteEnabledMesh = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GenerateNaniteEnabledMesh_Offset), 0, GenerateNaniteEnabledMesh_PropertyAddress.Address);
			NaniteProxyTrianglePercent = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NaniteProxyTrianglePercent_Offset));
			SupportRayTracing = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SupportRayTracing_Offset), 0, SupportRayTracing_PropertyAddress.Address);
			AllowDistanceField = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowDistanceField_Offset), 0, AllowDistanceField_PropertyAddress.Address);
			MultiSamplingAA = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MultiSamplingAA_Offset));
			RenderCaptureResolution = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RenderCaptureResolution_Offset));
			MaterialSettings = FMaterialProxySettings.FromNative(IntPtr.Add(nativeStruct, MaterialSettings_Offset));
			CaptureFieldOfView = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CaptureFieldOfView_Offset));
			NearPlaneDist = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NearPlaneDist_Offset));
			UseRenderLODMeshes = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseRenderLODMeshes_Offset), 0, UseRenderLODMeshes_PropertyAddress.Address);
			EnableSimplifyPrePass = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableSimplifyPrePass_Offset), 0, EnableSimplifyPrePass_PropertyAddress.Address);
			EnableParallelBaking = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableParallelBaking_Offset), 0, EnableParallelBaking_PropertyAddress.Address);
			PrintDebugMessages = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, PrintDebugMessages_Offset), 0, PrintDebugMessages_PropertyAddress.Address);
			EmitFullDebugMesh = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EmitFullDebugMesh_Offset), 0, EmitFullDebugMesh_PropertyAddress.Address);
		}
	}

	static FMeshApproximationSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMeshApproximationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMeshApproximationSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MeshApproximationSettings");
		FMeshApproximationSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref OutputType_PropertyAddress, intPtr, "OutputType");
		OutputType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputType");
		OutputType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputType", Classes.FEnumProperty);
		ApproximationAccuracy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ApproximationAccuracy");
		ApproximationAccuracy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ApproximationAccuracy", Classes.FFloatProperty);
		ClampVoxelDimension_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClampVoxelDimension");
		ClampVoxelDimension_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClampVoxelDimension", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AttemptAutoThickening_PropertyAddress, intPtr, "bAttemptAutoThickening");
		AttemptAutoThickening_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAttemptAutoThickening");
		AttemptAutoThickening_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAttemptAutoThickening", Classes.FBoolProperty);
		TargetMinThicknessMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetMinThicknessMultiplier");
		TargetMinThicknessMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetMinThicknessMultiplier", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreTinyParts_PropertyAddress, intPtr, "bIgnoreTinyParts");
		IgnoreTinyParts_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreTinyParts");
		IgnoreTinyParts_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreTinyParts", Classes.FBoolProperty);
		TinyPartSizeMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TinyPartSizeMultiplier");
		TinyPartSizeMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TinyPartSizeMultiplier", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BaseCapping_PropertyAddress, intPtr, "BaseCapping");
		BaseCapping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BaseCapping");
		BaseCapping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BaseCapping", Classes.FEnumProperty);
		WindingThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindingThreshold");
		WindingThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindingThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FillGaps_PropertyAddress, intPtr, "bFillGaps");
		FillGaps_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFillGaps");
		FillGaps_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFillGaps", Classes.FBoolProperty);
		GapDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GapDistance");
		GapDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GapDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OcclusionMethod_PropertyAddress, intPtr, "OcclusionMethod");
		OcclusionMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionMethod");
		OcclusionMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OccludeFromBottom_PropertyAddress, intPtr, "bOccludeFromBottom");
		OccludeFromBottom_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOccludeFromBottom");
		OccludeFromBottom_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOccludeFromBottom", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SimplifyMethod_PropertyAddress, intPtr, "SimplifyMethod");
		SimplifyMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SimplifyMethod");
		SimplifyMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SimplifyMethod", Classes.FEnumProperty);
		TargetTriCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetTriCount");
		TargetTriCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetTriCount", Classes.FIntProperty);
		TrianglesPerM_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TrianglesPerM");
		TrianglesPerM_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TrianglesPerM", Classes.FFloatProperty);
		GeometricDeviation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GeometricDeviation");
		GeometricDeviation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GeometricDeviation", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GroundClipping_PropertyAddress, intPtr, "GroundClipping");
		GroundClipping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroundClipping");
		GroundClipping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroundClipping", Classes.FEnumProperty);
		GroundClippingZHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroundClippingZHeight");
		GroundClippingZHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroundClippingZHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EstimateHardNormals_PropertyAddress, intPtr, "bEstimateHardNormals");
		EstimateHardNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEstimateHardNormals");
		EstimateHardNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEstimateHardNormals", Classes.FBoolProperty);
		HardNormalAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HardNormalAngle");
		HardNormalAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HardNormalAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UVGenerationMethod_PropertyAddress, intPtr, "UVGenerationMethod");
		UVGenerationMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVGenerationMethod");
		UVGenerationMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVGenerationMethod", Classes.FEnumProperty);
		InitialPatchCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialPatchCount");
		InitialPatchCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialPatchCount", Classes.FIntProperty);
		CurvatureAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurvatureAlignment");
		CurvatureAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurvatureAlignment", Classes.FFloatProperty);
		MergingThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MergingThreshold");
		MergingThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MergingThreshold", Classes.FFloatProperty);
		MaxAngleDeviation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxAngleDeviation");
		MaxAngleDeviation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxAngleDeviation", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateNaniteEnabledMesh_PropertyAddress, intPtr, "bGenerateNaniteEnabledMesh");
		GenerateNaniteEnabledMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateNaniteEnabledMesh");
		GenerateNaniteEnabledMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateNaniteEnabledMesh", Classes.FBoolProperty);
		NaniteProxyTrianglePercent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NaniteProxyTrianglePercent");
		NaniteProxyTrianglePercent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NaniteProxyTrianglePercent", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SupportRayTracing_PropertyAddress, intPtr, "bSupportRayTracing");
		SupportRayTracing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSupportRayTracing");
		SupportRayTracing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSupportRayTracing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowDistanceField_PropertyAddress, intPtr, "bAllowDistanceField");
		AllowDistanceField_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowDistanceField");
		AllowDistanceField_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowDistanceField", Classes.FBoolProperty);
		MultiSamplingAA_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MultiSamplingAA");
		MultiSamplingAA_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MultiSamplingAA", Classes.FIntProperty);
		RenderCaptureResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RenderCaptureResolution");
		RenderCaptureResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RenderCaptureResolution", Classes.FIntProperty);
		MaterialSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialSettings");
		MaterialSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialSettings", Classes.FStructProperty);
		CaptureFieldOfView_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CaptureFieldOfView");
		CaptureFieldOfView_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CaptureFieldOfView", Classes.FFloatProperty);
		NearPlaneDist_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NearPlaneDist");
		NearPlaneDist_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NearPlaneDist", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseRenderLODMeshes_PropertyAddress, intPtr, "bUseRenderLODMeshes");
		UseRenderLODMeshes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseRenderLODMeshes");
		UseRenderLODMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseRenderLODMeshes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSimplifyPrePass_PropertyAddress, intPtr, "bEnableSimplifyPrePass");
		EnableSimplifyPrePass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableSimplifyPrePass");
		EnableSimplifyPrePass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableSimplifyPrePass", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableParallelBaking_PropertyAddress, intPtr, "bEnableParallelBaking");
		EnableParallelBaking_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableParallelBaking");
		EnableParallelBaking_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableParallelBaking", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PrintDebugMessages_PropertyAddress, intPtr, "bPrintDebugMessages");
		PrintDebugMessages_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPrintDebugMessages");
		PrintDebugMessages_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPrintDebugMessages", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EmitFullDebugMesh_PropertyAddress, intPtr, "bEmitFullDebugMesh");
		EmitFullDebugMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEmitFullDebugMesh");
		EmitFullDebugMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEmitFullDebugMesh", Classes.FBoolProperty);
		FMeshApproximationSettings_IsValid = intPtr != IntPtr.Zero && OutputType_IsValid && ApproximationAccuracy_IsValid && ClampVoxelDimension_IsValid && AttemptAutoThickening_IsValid && TargetMinThicknessMultiplier_IsValid && IgnoreTinyParts_IsValid && TinyPartSizeMultiplier_IsValid && BaseCapping_IsValid && WindingThreshold_IsValid && FillGaps_IsValid && GapDistance_IsValid && OcclusionMethod_IsValid && OccludeFromBottom_IsValid && SimplifyMethod_IsValid && TargetTriCount_IsValid && TrianglesPerM_IsValid && GeometricDeviation_IsValid && GroundClipping_IsValid && GroundClippingZHeight_IsValid && EstimateHardNormals_IsValid && HardNormalAngle_IsValid && UVGenerationMethod_IsValid && InitialPatchCount_IsValid && CurvatureAlignment_IsValid && MergingThreshold_IsValid && MaxAngleDeviation_IsValid && GenerateNaniteEnabledMesh_IsValid && NaniteProxyTrianglePercent_IsValid && SupportRayTracing_IsValid && AllowDistanceField_IsValid && MultiSamplingAA_IsValid && RenderCaptureResolution_IsValid && MaterialSettings_IsValid && CaptureFieldOfView_IsValid && NearPlaneDist_IsValid && UseRenderLODMeshes_IsValid && EnableSimplifyPrePass_IsValid && EnableParallelBaking_IsValid && PrintDebugMessages_IsValid && EmitFullDebugMesh_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.MeshApproximationSettings", FMeshApproximationSettings_IsValid);
	}
}
