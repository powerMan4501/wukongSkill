using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)821039269uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SkinnedMeshComponent", "Engine", UnrealModuleType.Engine)]
public class USkinnedMeshComponent : UMeshComponent, ILODSyncInterface, IInterface
{
	private static bool SkeletalMesh_IsValid;

	private static int SkeletalMesh_Offset;

	private static bool MasterPoseComponent_IsValid;

	private static int MasterPoseComponent_Offset;

	private static bool SkinCacheUsage_IsValid;

	private static FFieldAddress SkinCacheUsage_PropertyAddress;

	private static int SkinCacheUsage_Offset;

	private TArrayReadOnlyMarshaler<ESkinCacheUsage> SkinCacheUsage_MarshalerCached;

	private static bool MeshDeformer_IsValid;

	private static int MeshDeformer_Offset;

	private static bool PhysicsAssetOverride_IsValid;

	private static int PhysicsAssetOverride_Offset;

	private static bool ForcedLodModel_IsValid;

	private static int ForcedLodModel_Offset;

	private static bool MinLodModel_IsValid;

	private static int MinLodModel_Offset;

	private static bool StreamingDistanceMultiplier_IsValid;

	private static int StreamingDistanceMultiplier_Offset;

	private static bool VisibilityBasedAnimTickOption_IsValid;

	private static FFieldAddress VisibilityBasedAnimTickOption_PropertyAddress;

	private static int VisibilityBasedAnimTickOption_Offset;

	private static bool OverrideMinLod_IsValid;

	private static FFieldAddress OverrideMinLod_PropertyAddress;

	private static int OverrideMinLod_Offset;

	private static bool UseBoundsFromMasterPoseComponent_IsValid;

	private static FFieldAddress UseBoundsFromMasterPoseComponent_PropertyAddress;

	private static int UseBoundsFromMasterPoseComponent_Offset;

	private static bool DisableMorphTarget_IsValid;

	private static FFieldAddress DisableMorphTarget_PropertyAddress;

	private static int DisableMorphTarget_Offset;

	private static bool PerBoneMotionBlur_IsValid;

	private static FFieldAddress PerBoneMotionBlur_PropertyAddress;

	private static int PerBoneMotionBlur_Offset;

	private static bool ComponentUseFixedSkelBounds_IsValid;

	private static FFieldAddress ComponentUseFixedSkelBounds_PropertyAddress;

	private static int ComponentUseFixedSkelBounds_Offset;

	private static bool ConsiderAllBodiesForBounds_IsValid;

	private static FFieldAddress ConsiderAllBodiesForBounds_PropertyAddress;

	private static int ConsiderAllBodiesForBounds_Offset;

	private static bool SyncAttachParentLOD_IsValid;

	private static FFieldAddress SyncAttachParentLOD_PropertyAddress;

	private static int SyncAttachParentLOD_Offset;

	private static bool CastCapsuleDirectShadow_IsValid;

	private static FFieldAddress CastCapsuleDirectShadow_PropertyAddress;

	private static int CastCapsuleDirectShadow_Offset;

	private static bool CastCapsuleIndirectShadow_IsValid;

	private static FFieldAddress CastCapsuleIndirectShadow_PropertyAddress;

	private static int CastCapsuleIndirectShadow_Offset;

	private static bool EnableUpdateRateOptimizations_IsValid;

	private static FFieldAddress EnableUpdateRateOptimizations_PropertyAddress;

	private static int EnableUpdateRateOptimizations_Offset;

	private static bool DisplayDebugUpdateRateOptimizations_IsValid;

	private static FFieldAddress DisplayDebugUpdateRateOptimizations_PropertyAddress;

	private static int DisplayDebugUpdateRateOptimizations_Offset;

	private static bool RenderStatic_IsValid;

	private static FFieldAddress RenderStatic_PropertyAddress;

	private static int RenderStatic_Offset;

	private static bool IgnoreMasterPoseComponentLOD_IsValid;

	private static FFieldAddress IgnoreMasterPoseComponentLOD_PropertyAddress;

	private static int IgnoreMasterPoseComponentLOD_Offset;

	private static bool ClothingUseRefSkeleton_IsValid;

	private static FFieldAddress ClothingUseRefSkeleton_PropertyAddress;

	private static int ClothingUseRefSkeleton_Offset;

	private static bool CapsuleIndirectShadowMinVisibility_IsValid;

	private static int CapsuleIndirectShadowMinVisibility_Offset;

	private static bool UnloadSkinWeightProfile_IsValid;

	private static IntPtr UnloadSkinWeightProfile_FunctionAddress;

	private static int UnloadSkinWeightProfile_ParamsSize;

	private static bool UnloadSkinWeightProfile_InProfileName_IsValid;

	private static FFieldAddress UnloadSkinWeightProfile_InProfileName_PropertyAddress;

	private static int UnloadSkinWeightProfile_InProfileName_Offset;

	private static bool UnHideBoneByName_IsValid;

	private static IntPtr UnHideBoneByName_FunctionAddress;

	private static int UnHideBoneByName_ParamsSize;

	private static bool UnHideBoneByName_BoneName_IsValid;

	private static FFieldAddress UnHideBoneByName_BoneName_PropertyAddress;

	private static int UnHideBoneByName_BoneName_Offset;

	private static bool TransformToBoneSpace_IsValid;

	private static IntPtr TransformToBoneSpace_FunctionAddress;

	private static int TransformToBoneSpace_ParamsSize;

	private static bool TransformToBoneSpace_BoneName_IsValid;

	private static FFieldAddress TransformToBoneSpace_BoneName_PropertyAddress;

	private static int TransformToBoneSpace_BoneName_Offset;

	private static bool TransformToBoneSpace_InPosition_IsValid;

	private static FFieldAddress TransformToBoneSpace_InPosition_PropertyAddress;

	private static int TransformToBoneSpace_InPosition_Offset;

	private static bool TransformToBoneSpace_InRotation_IsValid;

	private static FFieldAddress TransformToBoneSpace_InRotation_PropertyAddress;

	private static int TransformToBoneSpace_InRotation_Offset;

	private static bool TransformToBoneSpace_OutPosition_IsValid;

	private static FFieldAddress TransformToBoneSpace_OutPosition_PropertyAddress;

	private static int TransformToBoneSpace_OutPosition_Offset;

	private static bool TransformToBoneSpace_OutRotation_IsValid;

	private static FFieldAddress TransformToBoneSpace_OutRotation_PropertyAddress;

	private static int TransformToBoneSpace_OutRotation_Offset;

	private static bool TransformFromBoneSpace_IsValid;

	private static IntPtr TransformFromBoneSpace_FunctionAddress;

	private static int TransformFromBoneSpace_ParamsSize;

	private static bool TransformFromBoneSpace_BoneName_IsValid;

	private static FFieldAddress TransformFromBoneSpace_BoneName_PropertyAddress;

	private static int TransformFromBoneSpace_BoneName_Offset;

	private static bool TransformFromBoneSpace_InPosition_IsValid;

	private static FFieldAddress TransformFromBoneSpace_InPosition_PropertyAddress;

	private static int TransformFromBoneSpace_InPosition_Offset;

	private static bool TransformFromBoneSpace_InRotation_IsValid;

	private static FFieldAddress TransformFromBoneSpace_InRotation_PropertyAddress;

	private static int TransformFromBoneSpace_InRotation_Offset;

	private static bool TransformFromBoneSpace_OutPosition_IsValid;

	private static FFieldAddress TransformFromBoneSpace_OutPosition_PropertyAddress;

	private static int TransformFromBoneSpace_OutPosition_Offset;

	private static bool TransformFromBoneSpace_OutRotation_IsValid;

	private static FFieldAddress TransformFromBoneSpace_OutRotation_PropertyAddress;

	private static int TransformFromBoneSpace_OutRotation_Offset;

	private static bool ShowMaterialSection_IsValid;

	private static IntPtr ShowMaterialSection_FunctionAddress;

	private static int ShowMaterialSection_ParamsSize;

	private static bool ShowMaterialSection_MaterialID_IsValid;

	private static FFieldAddress ShowMaterialSection_MaterialID_PropertyAddress;

	private static int ShowMaterialSection_MaterialID_Offset;

	private static bool ShowMaterialSection_SectionIndex_IsValid;

	private static FFieldAddress ShowMaterialSection_SectionIndex_PropertyAddress;

	private static int ShowMaterialSection_SectionIndex_Offset;

	private static bool ShowMaterialSection_bShow_IsValid;

	private static FFieldAddress ShowMaterialSection_bShow_PropertyAddress;

	private static int ShowMaterialSection_bShow_Offset;

	private static bool ShowMaterialSection_LODIndex_IsValid;

	private static FFieldAddress ShowMaterialSection_LODIndex_PropertyAddress;

	private static int ShowMaterialSection_LODIndex_Offset;

	private static bool ShowAllMaterialSections_IsValid;

	private static IntPtr ShowAllMaterialSections_FunctionAddress;

	private static int ShowAllMaterialSections_ParamsSize;

	private static bool ShowAllMaterialSections_LODIndex_IsValid;

	private static FFieldAddress ShowAllMaterialSections_LODIndex_PropertyAddress;

	private static int ShowAllMaterialSections_LODIndex_Offset;

	private static bool SetVertexOffsetUsage_IsValid;

	private static IntPtr SetVertexOffsetUsage_FunctionAddress;

	private static int SetVertexOffsetUsage_ParamsSize;

	private static bool SetVertexOffsetUsage_LODIndex_IsValid;

	private static FFieldAddress SetVertexOffsetUsage_LODIndex_PropertyAddress;

	private static int SetVertexOffsetUsage_LODIndex_Offset;

	private static bool SetVertexOffsetUsage_Usage_IsValid;

	private static FFieldAddress SetVertexOffsetUsage_Usage_PropertyAddress;

	private static int SetVertexOffsetUsage_Usage_Offset;

	private static bool SetVertexColorOverride_LinearColor_IsValid;

	private static IntPtr SetVertexColorOverride_LinearColor_FunctionAddress;

	private static int SetVertexColorOverride_LinearColor_ParamsSize;

	private static bool SetVertexColorOverride_LinearColor_LODIndex_IsValid;

	private static FFieldAddress SetVertexColorOverride_LinearColor_LODIndex_PropertyAddress;

	private static int SetVertexColorOverride_LinearColor_LODIndex_Offset;

	private static bool SetVertexColorOverride_LinearColor_VertexColors_IsValid;

	private static FFieldAddress SetVertexColorOverride_LinearColor_VertexColors_PropertyAddress;

	private static int SetVertexColorOverride_LinearColor_VertexColors_Offset;

	private static bool SetSkinWeightProfile_IsValid;

	private static IntPtr SetSkinWeightProfile_FunctionAddress;

	private static int SetSkinWeightProfile_ParamsSize;

	private static bool SetSkinWeightProfile_InProfileName_IsValid;

	private static FFieldAddress SetSkinWeightProfile_InProfileName_PropertyAddress;

	private static int SetSkinWeightProfile_InProfileName_Offset;

	private static bool SetSkinWeightProfile_ReturnValue_IsValid;

	private static FFieldAddress SetSkinWeightProfile_ReturnValue_PropertyAddress;

	private static int SetSkinWeightProfile_ReturnValue_Offset;

	private static bool SetSkinWeightOverride_IsValid;

	private static IntPtr SetSkinWeightOverride_FunctionAddress;

	private static int SetSkinWeightOverride_ParamsSize;

	private static bool SetSkinWeightOverride_LODIndex_IsValid;

	private static FFieldAddress SetSkinWeightOverride_LODIndex_PropertyAddress;

	private static int SetSkinWeightOverride_LODIndex_Offset;

	private static bool SetSkinWeightOverride_SkinWeights_IsValid;

	private static FFieldAddress SetSkinWeightOverride_SkinWeights_PropertyAddress;

	private static int SetSkinWeightOverride_SkinWeights_Offset;

	private static bool SetSkeletalMesh_IsValid;

	private static IntPtr SetSkeletalMesh_FunctionAddress;

	private static int SetSkeletalMesh_ParamsSize;

	private static bool SetSkeletalMesh_NewMesh_IsValid;

	private static FFieldAddress SetSkeletalMesh_NewMesh_PropertyAddress;

	private static int SetSkeletalMesh_NewMesh_Offset;

	private static bool SetSkeletalMesh_bReinitPose_IsValid;

	private static FFieldAddress SetSkeletalMesh_bReinitPose_PropertyAddress;

	private static int SetSkeletalMesh_bReinitPose_Offset;

	private static bool SetRenderStatic_IsValid;

	private static IntPtr SetRenderStatic_FunctionAddress;

	private static int SetRenderStatic_ParamsSize;

	private static bool SetRenderStatic_bNewValue_IsValid;

	private static FFieldAddress SetRenderStatic_bNewValue_PropertyAddress;

	private static int SetRenderStatic_bNewValue_Offset;

	private static bool SetPreSkinningOffsets_IsValid;

	private static IntPtr SetPreSkinningOffsets_FunctionAddress;

	private static int SetPreSkinningOffsets_ParamsSize;

	private static bool SetPreSkinningOffsets_LODIndex_IsValid;

	private static FFieldAddress SetPreSkinningOffsets_LODIndex_PropertyAddress;

	private static int SetPreSkinningOffsets_LODIndex_Offset;

	private static bool SetPreSkinningOffsets_Offsets_IsValid;

	private static FFieldAddress SetPreSkinningOffsets_Offsets_PropertyAddress;

	private static int SetPreSkinningOffsets_Offsets_Offset;

	private static bool SetPostSkinningOffsets_IsValid;

	private static IntPtr SetPostSkinningOffsets_FunctionAddress;

	private static int SetPostSkinningOffsets_ParamsSize;

	private static bool SetPostSkinningOffsets_LODIndex_IsValid;

	private static FFieldAddress SetPostSkinningOffsets_LODIndex_PropertyAddress;

	private static int SetPostSkinningOffsets_LODIndex_Offset;

	private static bool SetPostSkinningOffsets_Offsets_IsValid;

	private static FFieldAddress SetPostSkinningOffsets_Offsets_PropertyAddress;

	private static int SetPostSkinningOffsets_Offsets_Offset;

	private static bool SetPhysicsAsset_IsValid;

	private static IntPtr SetPhysicsAsset_FunctionAddress;

	private static int SetPhysicsAsset_ParamsSize;

	private static bool SetPhysicsAsset_NewPhysicsAsset_IsValid;

	private static FFieldAddress SetPhysicsAsset_NewPhysicsAsset_PropertyAddress;

	private static int SetPhysicsAsset_NewPhysicsAsset_Offset;

	private static bool SetPhysicsAsset_bForceReInit_IsValid;

	private static FFieldAddress SetPhysicsAsset_bForceReInit_PropertyAddress;

	private static int SetPhysicsAsset_bForceReInit_Offset;

	private static bool SetMinLOD_IsValid;

	private static IntPtr SetMinLOD_FunctionAddress;

	private static int SetMinLOD_ParamsSize;

	private static bool SetMinLOD_InNewMinLOD_IsValid;

	private static FFieldAddress SetMinLOD_InNewMinLOD_PropertyAddress;

	private static int SetMinLOD_InNewMinLOD_Offset;

	private static bool SetMeshDeformer_IsValid;

	private static IntPtr SetMeshDeformer_FunctionAddress;

	private static int SetMeshDeformer_ParamsSize;

	private static bool SetMeshDeformer_InMeshDeformer_IsValid;

	private static FFieldAddress SetMeshDeformer_InMeshDeformer_PropertyAddress;

	private static int SetMeshDeformer_InMeshDeformer_Offset;

	private static bool SetMasterPoseComponent_IsValid;

	private static IntPtr SetMasterPoseComponent_FunctionAddress;

	private static int SetMasterPoseComponent_ParamsSize;

	private static bool SetMasterPoseComponent_NewMasterBoneComponent_IsValid;

	private static FFieldAddress SetMasterPoseComponent_NewMasterBoneComponent_PropertyAddress;

	private static int SetMasterPoseComponent_NewMasterBoneComponent_Offset;

	private static bool SetMasterPoseComponent_bForceUpdate_IsValid;

	private static FFieldAddress SetMasterPoseComponent_bForceUpdate_PropertyAddress;

	private static int SetMasterPoseComponent_bForceUpdate_Offset;

	private static bool SetForcedLOD_IsValid;

	private static IntPtr SetForcedLOD_FunctionAddress;

	private static int SetForcedLOD_ParamsSize;

	private static bool SetForcedLOD_InNewForcedLOD_IsValid;

	private static FFieldAddress SetForcedLOD_InNewForcedLOD_PropertyAddress;

	private static int SetForcedLOD_InNewForcedLOD_Offset;

	private static bool SetCastCapsuleIndirectShadow_IsValid;

	private static IntPtr SetCastCapsuleIndirectShadow_FunctionAddress;

	private static int SetCastCapsuleIndirectShadow_ParamsSize;

	private static bool SetCastCapsuleIndirectShadow_bNewValue_IsValid;

	private static FFieldAddress SetCastCapsuleIndirectShadow_bNewValue_PropertyAddress;

	private static int SetCastCapsuleIndirectShadow_bNewValue_Offset;

	private static bool SetCastCapsuleDirectShadow_IsValid;

	private static IntPtr SetCastCapsuleDirectShadow_FunctionAddress;

	private static int SetCastCapsuleDirectShadow_ParamsSize;

	private static bool SetCastCapsuleDirectShadow_bNewValue_IsValid;

	private static FFieldAddress SetCastCapsuleDirectShadow_bNewValue_PropertyAddress;

	private static int SetCastCapsuleDirectShadow_bNewValue_Offset;

	private static bool SetCapsuleIndirectShadowMinVisibility_IsValid;

	private static IntPtr SetCapsuleIndirectShadowMinVisibility_FunctionAddress;

	private static int SetCapsuleIndirectShadowMinVisibility_ParamsSize;

	private static bool SetCapsuleIndirectShadowMinVisibility_NewValue_IsValid;

	private static FFieldAddress SetCapsuleIndirectShadowMinVisibility_NewValue_PropertyAddress;

	private static int SetCapsuleIndirectShadowMinVisibility_NewValue_Offset;

	private static bool IsUsingSkinWeightProfile_IsValid;

	private static IntPtr IsUsingSkinWeightProfile_FunctionAddress;

	private static int IsUsingSkinWeightProfile_ParamsSize;

	private static bool IsUsingSkinWeightProfile_ReturnValue_IsValid;

	private static FFieldAddress IsUsingSkinWeightProfile_ReturnValue_PropertyAddress;

	private static int IsUsingSkinWeightProfile_ReturnValue_Offset;

	private static bool IsMaterialSectionShown_IsValid;

	private static IntPtr IsMaterialSectionShown_FunctionAddress;

	private static int IsMaterialSectionShown_ParamsSize;

	private static bool IsMaterialSectionShown_MaterialID_IsValid;

	private static FFieldAddress IsMaterialSectionShown_MaterialID_PropertyAddress;

	private static int IsMaterialSectionShown_MaterialID_Offset;

	private static bool IsMaterialSectionShown_LODIndex_IsValid;

	private static FFieldAddress IsMaterialSectionShown_LODIndex_PropertyAddress;

	private static int IsMaterialSectionShown_LODIndex_Offset;

	private static bool IsMaterialSectionShown_ReturnValue_IsValid;

	private static FFieldAddress IsMaterialSectionShown_ReturnValue_PropertyAddress;

	private static int IsMaterialSectionShown_ReturnValue_Offset;

	private static bool IsBoneHiddenByName_IsValid;

	private static IntPtr IsBoneHiddenByName_FunctionAddress;

	private static int IsBoneHiddenByName_ParamsSize;

	private static bool IsBoneHiddenByName_BoneName_IsValid;

	private static FFieldAddress IsBoneHiddenByName_BoneName_PropertyAddress;

	private static int IsBoneHiddenByName_BoneName_Offset;

	private static bool IsBoneHiddenByName_ReturnValue_IsValid;

	private static FFieldAddress IsBoneHiddenByName_ReturnValue_PropertyAddress;

	private static int IsBoneHiddenByName_ReturnValue_Offset;

	private static bool HideBoneByName_IsValid;

	private static IntPtr HideBoneByName_FunctionAddress;

	private static int HideBoneByName_ParamsSize;

	private static bool HideBoneByName_BoneName_IsValid;

	private static FFieldAddress HideBoneByName_BoneName_PropertyAddress;

	private static int HideBoneByName_BoneName_Offset;

	private static bool HideBoneByName_PhysBodyOption_IsValid;

	private static FFieldAddress HideBoneByName_PhysBodyOption_PropertyAddress;

	private static int HideBoneByName_PhysBodyOption_Offset;

	private static bool GetVertexOffsetUsage_IsValid;

	private static IntPtr GetVertexOffsetUsage_FunctionAddress;

	private static int GetVertexOffsetUsage_ParamsSize;

	private static bool GetVertexOffsetUsage_LODIndex_IsValid;

	private static FFieldAddress GetVertexOffsetUsage_LODIndex_PropertyAddress;

	private static int GetVertexOffsetUsage_LODIndex_Offset;

	private static bool GetVertexOffsetUsage_ReturnValue_IsValid;

	private static FFieldAddress GetVertexOffsetUsage_ReturnValue_PropertyAddress;

	private static int GetVertexOffsetUsage_ReturnValue_Offset;

	private static bool GetTwistAndSwingAngleOfDeltaRotationFromRefPose_IsValid;

	private static IntPtr GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress;

	private static int GetTwistAndSwingAngleOfDeltaRotationFromRefPose_ParamsSize;

	private static bool GetTwistAndSwingAngleOfDeltaRotationFromRefPose_BoneName_IsValid;

	private static FFieldAddress GetTwistAndSwingAngleOfDeltaRotationFromRefPose_BoneName_PropertyAddress;

	private static int GetTwistAndSwingAngleOfDeltaRotationFromRefPose_BoneName_Offset;

	private static bool GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutTwistAngle_IsValid;

	private static FFieldAddress GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutTwistAngle_PropertyAddress;

	private static int GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutTwistAngle_Offset;

	private static bool GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutSwingAngle_IsValid;

	private static FFieldAddress GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutSwingAngle_PropertyAddress;

	private static int GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutSwingAngle_Offset;

	private static bool GetTwistAndSwingAngleOfDeltaRotationFromRefPose_ReturnValue_IsValid;

	private static FFieldAddress GetTwistAndSwingAngleOfDeltaRotationFromRefPose_ReturnValue_PropertyAddress;

	private static int GetTwistAndSwingAngleOfDeltaRotationFromRefPose_ReturnValue_Offset;

	private static bool GetSocketBoneName_IsValid;

	private static IntPtr GetSocketBoneName_FunctionAddress;

	private static int GetSocketBoneName_ParamsSize;

	private static bool GetSocketBoneName_InSocketName_IsValid;

	private static FFieldAddress GetSocketBoneName_InSocketName_PropertyAddress;

	private static int GetSocketBoneName_InSocketName_Offset;

	private static bool GetSocketBoneName_ReturnValue_IsValid;

	private static FFieldAddress GetSocketBoneName_ReturnValue_PropertyAddress;

	private static int GetSocketBoneName_ReturnValue_Offset;

	private static bool GetRefPoseTransform_IsValid;

	private static IntPtr GetRefPoseTransform_FunctionAddress;

	private static int GetRefPoseTransform_ParamsSize;

	private static bool GetRefPoseTransform_BoneIndex_IsValid;

	private static FFieldAddress GetRefPoseTransform_BoneIndex_PropertyAddress;

	private static int GetRefPoseTransform_BoneIndex_Offset;

	private static bool GetRefPoseTransform_ReturnValue_IsValid;

	private static FFieldAddress GetRefPoseTransform_ReturnValue_PropertyAddress;

	private static int GetRefPoseTransform_ReturnValue_Offset;

	private static bool GetRefPosePosition_IsValid;

	private static IntPtr GetRefPosePosition_FunctionAddress;

	private static int GetRefPosePosition_ParamsSize;

	private static bool GetRefPosePosition_BoneIndex_IsValid;

	private static FFieldAddress GetRefPosePosition_BoneIndex_PropertyAddress;

	private static int GetRefPosePosition_BoneIndex_Offset;

	private static bool GetRefPosePosition_ReturnValue_IsValid;

	private static FFieldAddress GetRefPosePosition_ReturnValue_PropertyAddress;

	private static int GetRefPosePosition_ReturnValue_Offset;

	private static bool GetParentBone_IsValid;

	private static IntPtr GetParentBone_FunctionAddress;

	private static int GetParentBone_ParamsSize;

	private static bool GetParentBone_BoneName_IsValid;

	private static FFieldAddress GetParentBone_BoneName_PropertyAddress;

	private static int GetParentBone_BoneName_Offset;

	private static bool GetParentBone_ReturnValue_IsValid;

	private static FFieldAddress GetParentBone_ReturnValue_PropertyAddress;

	private static int GetParentBone_ReturnValue_Offset;

	private static bool GetNumLODs_IsValid;

	private static IntPtr GetNumLODs_FunctionAddress;

	private static int GetNumLODs_ParamsSize;

	private static bool GetNumLODs_ReturnValue_IsValid;

	private static FFieldAddress GetNumLODs_ReturnValue_PropertyAddress;

	private static int GetNumLODs_ReturnValue_Offset;

	private static bool GetNumBones_IsValid;

	private static IntPtr GetNumBones_FunctionAddress;

	private static int GetNumBones_ParamsSize;

	private static bool GetNumBones_ReturnValue_IsValid;

	private static FFieldAddress GetNumBones_ReturnValue_PropertyAddress;

	private static int GetNumBones_ReturnValue_Offset;

	private static bool GetForcedLOD_IsValid;

	private static IntPtr GetForcedLOD_FunctionAddress;

	private static int GetForcedLOD_ParamsSize;

	private static bool GetForcedLOD_ReturnValue_IsValid;

	private static FFieldAddress GetForcedLOD_ReturnValue_PropertyAddress;

	private static int GetForcedLOD_ReturnValue_Offset;

	private static bool GetDeltaTransformFromRefPose_IsValid;

	private static IntPtr GetDeltaTransformFromRefPose_FunctionAddress;

	private static int GetDeltaTransformFromRefPose_ParamsSize;

	private static bool GetDeltaTransformFromRefPose_BoneName_IsValid;

	private static FFieldAddress GetDeltaTransformFromRefPose_BoneName_PropertyAddress;

	private static int GetDeltaTransformFromRefPose_BoneName_Offset;

	private static bool GetDeltaTransformFromRefPose_BaseName_IsValid;

	private static FFieldAddress GetDeltaTransformFromRefPose_BaseName_PropertyAddress;

	private static int GetDeltaTransformFromRefPose_BaseName_Offset;

	private static bool GetDeltaTransformFromRefPose_ReturnValue_IsValid;

	private static FFieldAddress GetDeltaTransformFromRefPose_ReturnValue_PropertyAddress;

	private static int GetDeltaTransformFromRefPose_ReturnValue_Offset;

	private static bool GetCurrentSkinWeightProfileName_IsValid;

	private static IntPtr GetCurrentSkinWeightProfileName_FunctionAddress;

	private static int GetCurrentSkinWeightProfileName_ParamsSize;

	private static bool GetCurrentSkinWeightProfileName_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentSkinWeightProfileName_ReturnValue_PropertyAddress;

	private static int GetCurrentSkinWeightProfileName_ReturnValue_Offset;

	private static bool GetBoneName_IsValid;

	private static IntPtr GetBoneName_FunctionAddress;

	private static int GetBoneName_ParamsSize;

	private static bool GetBoneName_BoneIndex_IsValid;

	private static FFieldAddress GetBoneName_BoneIndex_PropertyAddress;

	private static int GetBoneName_BoneIndex_Offset;

	private static bool GetBoneName_ReturnValue_IsValid;

	private static FFieldAddress GetBoneName_ReturnValue_PropertyAddress;

	private static int GetBoneName_ReturnValue_Offset;

	private static bool GetBoneIndex_IsValid;

	private static IntPtr GetBoneIndex_FunctionAddress;

	private static int GetBoneIndex_ParamsSize;

	private static bool GetBoneIndex_BoneName_IsValid;

	private static FFieldAddress GetBoneIndex_BoneName_PropertyAddress;

	private static int GetBoneIndex_BoneName_Offset;

	private static bool GetBoneIndex_ReturnValue_IsValid;

	private static FFieldAddress GetBoneIndex_ReturnValue_PropertyAddress;

	private static int GetBoneIndex_ReturnValue_Offset;

	private static bool FindClosestBone_K2_IsValid;

	private static IntPtr FindClosestBone_K2_FunctionAddress;

	private static int FindClosestBone_K2_ParamsSize;

	private static bool FindClosestBone_K2_TestLocation_IsValid;

	private static FFieldAddress FindClosestBone_K2_TestLocation_PropertyAddress;

	private static int FindClosestBone_K2_TestLocation_Offset;

	private static bool FindClosestBone_K2_BoneLocation_IsValid;

	private static FFieldAddress FindClosestBone_K2_BoneLocation_PropertyAddress;

	private static int FindClosestBone_K2_BoneLocation_Offset;

	private static bool FindClosestBone_K2_IgnoreScale_IsValid;

	private static FFieldAddress FindClosestBone_K2_IgnoreScale_PropertyAddress;

	private static int FindClosestBone_K2_IgnoreScale_Offset;

	private static bool FindClosestBone_K2_bRequirePhysicsAsset_IsValid;

	private static FFieldAddress FindClosestBone_K2_bRequirePhysicsAsset_PropertyAddress;

	private static int FindClosestBone_K2_bRequirePhysicsAsset_Offset;

	private static bool FindClosestBone_K2_ReturnValue_IsValid;

	private static FFieldAddress FindClosestBone_K2_ReturnValue_PropertyAddress;

	private static int FindClosestBone_K2_ReturnValue_Offset;

	private static bool ClearVertexColorOverride_IsValid;

	private static IntPtr ClearVertexColorOverride_FunctionAddress;

	private static int ClearVertexColorOverride_ParamsSize;

	private static bool ClearVertexColorOverride_LODIndex_IsValid;

	private static FFieldAddress ClearVertexColorOverride_LODIndex_PropertyAddress;

	private static int ClearVertexColorOverride_LODIndex_Offset;

	private static bool ClearSkinWeightProfile_IsValid;

	private static IntPtr ClearSkinWeightProfile_FunctionAddress;

	private static int ClearSkinWeightProfile_ParamsSize;

	private static bool ClearSkinWeightOverride_IsValid;

	private static IntPtr ClearSkinWeightOverride_FunctionAddress;

	private static int ClearSkinWeightOverride_ParamsSize;

	private static bool ClearSkinWeightOverride_LODIndex_IsValid;

	private static FFieldAddress ClearSkinWeightOverride_LODIndex_PropertyAddress;

	private static int ClearSkinWeightOverride_LODIndex_Offset;

	private static bool BoneIsChildOf_IsValid;

	private static IntPtr BoneIsChildOf_FunctionAddress;

	private static int BoneIsChildOf_ParamsSize;

	private static bool BoneIsChildOf_BoneName_IsValid;

	private static FFieldAddress BoneIsChildOf_BoneName_PropertyAddress;

	private static int BoneIsChildOf_BoneName_Offset;

	private static bool BoneIsChildOf_ParentBoneName_IsValid;

	private static FFieldAddress BoneIsChildOf_ParentBoneName_PropertyAddress;

	private static int BoneIsChildOf_ParentBoneName_Offset;

	private static bool BoneIsChildOf_ReturnValue_IsValid;

	private static FFieldAddress BoneIsChildOf_ReturnValue_PropertyAddress;

	private static int BoneIsChildOf_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SkeletalMesh")]
	public USkeletalMesh SkeletalMesh
	{
		get
		{
			CheckDestroyed();
			if (!SkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:SkeletalMesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(base.Address, SkeletalMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkeletalMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:SkeletalMesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(base.Address, SkeletalMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141641756uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:MasterPoseComponent")]
	public TWeakObject<USkinnedMeshComponent> MasterPoseComponent
	{
		get
		{
			CheckDestroyed();
			if (!MasterPoseComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:MasterPoseComponent");
				return default(TWeakObject<USkinnedMeshComponent>);
			}
			return TWeakObjectMarshaler<USkinnedMeshComponent>.FromNative(IntPtr.Add(base.Address, MasterPoseComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MasterPoseComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:MasterPoseComponent");
			}
			else
			{
				TWeakObjectMarshaler<USkinnedMeshComponent>.ToNative(IntPtr.Add(base.Address, MasterPoseComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SkinCacheUsage")]
	public TArrayReadOnly<ESkinCacheUsage> SkinCacheUsage
	{
		get
		{
			CheckDestroyed();
			if (!SkinCacheUsage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:SkinCacheUsage");
				return null;
			}
			if (SkinCacheUsage_MarshalerCached == null)
			{
				SkinCacheUsage_MarshalerCached = new TArrayReadOnlyMarshaler<ESkinCacheUsage>(1, SkinCacheUsage_PropertyAddress, CachedMarshalingDelegates<ESkinCacheUsage, EnumMarshaler<ESkinCacheUsage>>.FromNative, CachedMarshalingDelegates<ESkinCacheUsage, EnumMarshaler<ESkinCacheUsage>>.ToNative);
			}
			return SkinCacheUsage_MarshalerCached.FromNative(IntPtr.Add(base.Address, SkinCacheUsage_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:MeshDeformer")]
	public UMeshDeformer MeshDeformer
	{
		get
		{
			CheckDestroyed();
			if (!MeshDeformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:MeshDeformer");
				return null;
			}
			return UObjectMarshaler<UMeshDeformer>.FromNative(IntPtr.Add(base.Address, MeshDeformer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeshDeformer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:MeshDeformer");
			}
			else
			{
				UObjectMarshaler<UMeshDeformer>.ToNative(IntPtr.Add(base.Address, MeshDeformer_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7885767187628565uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:PhysicsAssetOverride")]
	public UPhysicsAsset PhysicsAssetOverride
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsAssetOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:PhysicsAssetOverride");
				return null;
			}
			return UObjectMarshaler<UPhysicsAsset>.FromNative(IntPtr.Add(base.Address, PhysicsAssetOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsAssetOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:PhysicsAssetOverride");
			}
			else
			{
				UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(base.Address, PhysicsAssetOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:ForcedLodModel")]
	public int ForcedLodModel
	{
		get
		{
			CheckDestroyed();
			if (!ForcedLodModel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:ForcedLodModel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ForcedLodModel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForcedLodModel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:ForcedLodModel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ForcedLodModel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:MinLodModel")]
	public int MinLodModel
	{
		get
		{
			CheckDestroyed();
			if (!MinLodModel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:MinLodModel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinLodModel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinLodModel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:MinLodModel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinLodModel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:StreamingDistanceMultiplier")]
	public float StreamingDistanceMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!StreamingDistanceMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:StreamingDistanceMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StreamingDistanceMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StreamingDistanceMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:StreamingDistanceMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StreamingDistanceMultiplier_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759875870736901uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:VisibilityBasedAnimTickOption")]
	public EVisibilityBasedAnimTickOption VisibilityBasedAnimTickOption
	{
		get
		{
			CheckDestroyed();
			if (!VisibilityBasedAnimTickOption_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:VisibilityBasedAnimTickOption");
				return EVisibilityBasedAnimTickOption.AlwaysTickPoseAndRefreshBones;
			}
			return EnumMarshaler<EVisibilityBasedAnimTickOption>.FromNative(IntPtr.Add(base.Address, VisibilityBasedAnimTickOption_Offset), 0, VisibilityBasedAnimTickOption_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VisibilityBasedAnimTickOption_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:VisibilityBasedAnimTickOption");
			}
			else
			{
				EnumMarshaler<EVisibilityBasedAnimTickOption>.ToNative(IntPtr.Add(base.Address, VisibilityBasedAnimTickOption_Offset), 0, VisibilityBasedAnimTickOption_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:bOverrideMinLod")]
	public bool OverrideMinLod
	{
		get
		{
			CheckDestroyed();
			if (!OverrideMinLod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bOverrideMinLod");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideMinLod_Offset), 0, OverrideMinLod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideMinLod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bOverrideMinLod");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideMinLod_Offset), 0, OverrideMinLod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:bUseBoundsFromMasterPoseComponent")]
	public bool UseBoundsFromMasterPoseComponent
	{
		get
		{
			CheckDestroyed();
			if (!UseBoundsFromMasterPoseComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bUseBoundsFromMasterPoseComponent");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseBoundsFromMasterPoseComponent_Offset), 0, UseBoundsFromMasterPoseComponent_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseBoundsFromMasterPoseComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bUseBoundsFromMasterPoseComponent");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseBoundsFromMasterPoseComponent_Offset), 0, UseBoundsFromMasterPoseComponent_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:bDisableMorphTarget")]
	public bool DisableMorphTarget
	{
		get
		{
			CheckDestroyed();
			if (!DisableMorphTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bDisableMorphTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableMorphTarget_Offset), 0, DisableMorphTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableMorphTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bDisableMorphTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableMorphTarget_Offset), 0, DisableMorphTarget_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:bPerBoneMotionBlur")]
	public bool PerBoneMotionBlur
	{
		get
		{
			CheckDestroyed();
			if (!PerBoneMotionBlur_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bPerBoneMotionBlur");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PerBoneMotionBlur_Offset), 0, PerBoneMotionBlur_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PerBoneMotionBlur_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bPerBoneMotionBlur");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PerBoneMotionBlur_Offset), 0, PerBoneMotionBlur_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:bComponentUseFixedSkelBounds")]
	public bool ComponentUseFixedSkelBounds
	{
		get
		{
			CheckDestroyed();
			if (!ComponentUseFixedSkelBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bComponentUseFixedSkelBounds");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ComponentUseFixedSkelBounds_Offset), 0, ComponentUseFixedSkelBounds_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ComponentUseFixedSkelBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bComponentUseFixedSkelBounds");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ComponentUseFixedSkelBounds_Offset), 0, ComponentUseFixedSkelBounds_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:bConsiderAllBodiesForBounds")]
	public bool ConsiderAllBodiesForBounds
	{
		get
		{
			CheckDestroyed();
			if (!ConsiderAllBodiesForBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bConsiderAllBodiesForBounds");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ConsiderAllBodiesForBounds_Offset), 0, ConsiderAllBodiesForBounds_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConsiderAllBodiesForBounds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bConsiderAllBodiesForBounds");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ConsiderAllBodiesForBounds_Offset), 0, ConsiderAllBodiesForBounds_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:bSyncAttachParentLOD")]
	public bool SyncAttachParentLOD
	{
		get
		{
			CheckDestroyed();
			if (!SyncAttachParentLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bSyncAttachParentLOD");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SyncAttachParentLOD_Offset), 0, SyncAttachParentLOD_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SyncAttachParentLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bSyncAttachParentLOD");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SyncAttachParentLOD_Offset), 0, SyncAttachParentLOD_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:bCastCapsuleDirectShadow")]
	public bool CastCapsuleDirectShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastCapsuleDirectShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bCastCapsuleDirectShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastCapsuleDirectShadow_Offset), 0, CastCapsuleDirectShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastCapsuleDirectShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bCastCapsuleDirectShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastCapsuleDirectShadow_Offset), 0, CastCapsuleDirectShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:bCastCapsuleIndirectShadow")]
	public bool CastCapsuleIndirectShadow
	{
		get
		{
			CheckDestroyed();
			if (!CastCapsuleIndirectShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bCastCapsuleIndirectShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastCapsuleIndirectShadow_Offset), 0, CastCapsuleIndirectShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastCapsuleIndirectShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bCastCapsuleIndirectShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastCapsuleIndirectShadow_Offset), 0, CastCapsuleIndirectShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:bEnableUpdateRateOptimizations")]
	public bool EnableUpdateRateOptimizations
	{
		get
		{
			CheckDestroyed();
			if (!EnableUpdateRateOptimizations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bEnableUpdateRateOptimizations");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableUpdateRateOptimizations_Offset), 0, EnableUpdateRateOptimizations_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableUpdateRateOptimizations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bEnableUpdateRateOptimizations");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableUpdateRateOptimizations_Offset), 0, EnableUpdateRateOptimizations_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:bDisplayDebugUpdateRateOptimizations")]
	public bool DisplayDebugUpdateRateOptimizations
	{
		get
		{
			CheckDestroyed();
			if (!DisplayDebugUpdateRateOptimizations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bDisplayDebugUpdateRateOptimizations");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisplayDebugUpdateRateOptimizations_Offset), 0, DisplayDebugUpdateRateOptimizations_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisplayDebugUpdateRateOptimizations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bDisplayDebugUpdateRateOptimizations");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisplayDebugUpdateRateOptimizations_Offset), 0, DisplayDebugUpdateRateOptimizations_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:bRenderStatic")]
	public bool RenderStatic
	{
		get
		{
			CheckDestroyed();
			if (!RenderStatic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bRenderStatic");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RenderStatic_Offset), 0, RenderStatic_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RenderStatic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bRenderStatic");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RenderStatic_Offset), 0, RenderStatic_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:bIgnoreMasterPoseComponentLOD")]
	public bool IgnoreMasterPoseComponentLOD
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreMasterPoseComponentLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bIgnoreMasterPoseComponentLOD");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnoreMasterPoseComponentLOD_Offset), 0, IgnoreMasterPoseComponentLOD_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreMasterPoseComponentLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bIgnoreMasterPoseComponentLOD");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnoreMasterPoseComponentLOD_Offset), 0, IgnoreMasterPoseComponentLOD_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:bClothingUseRefSkeleton")]
	public bool ClothingUseRefSkeleton
	{
		get
		{
			CheckDestroyed();
			if (!ClothingUseRefSkeleton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bClothingUseRefSkeleton");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ClothingUseRefSkeleton_Offset), 0, ClothingUseRefSkeleton_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClothingUseRefSkeleton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:bClothingUseRefSkeleton");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ClothingUseRefSkeleton_Offset), 0, ClothingUseRefSkeleton_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:CapsuleIndirectShadowMinVisibility")]
	public float CapsuleIndirectShadowMinVisibility
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleIndirectShadowMinVisibility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:CapsuleIndirectShadowMinVisibility");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CapsuleIndirectShadowMinVisibility_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleIndirectShadowMinVisibility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkinnedMeshComponent:CapsuleIndirectShadowMinVisibility");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CapsuleIndirectShadowMinVisibility_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:UnloadSkinWeightProfile")]
	public unsafe void UnloadSkinWeightProfile(FName InProfileName)
	{
		CheckDestroyed();
		if (!UnloadSkinWeightProfile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:UnloadSkinWeightProfile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnloadSkinWeightProfile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnloadSkinWeightProfile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, UnloadSkinWeightProfile_InProfileName_Offset), 0, UnloadSkinWeightProfile_InProfileName_PropertyAddress.Address, InProfileName);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnloadSkinWeightProfile_FunctionAddress, intPtr, UnloadSkinWeightProfile_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:UnHideBoneByName")]
	public unsafe void UnHideBoneByName(FName BoneName)
	{
		CheckDestroyed();
		if (!UnHideBoneByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:UnHideBoneByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnHideBoneByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnHideBoneByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, UnHideBoneByName_BoneName_Offset), 0, UnHideBoneByName_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnHideBoneByName_FunctionAddress, intPtr, UnHideBoneByName_ParamsSize);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:TransformToBoneSpace")]
	public unsafe void TransformToBoneSpace(FName BoneName, FVector InPosition, FRotator InRotation, out FVector OutPosition, out FRotator OutRotation)
	{
		CheckDestroyed();
		if (!TransformToBoneSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:TransformToBoneSpace");
			OutPosition = default(FVector);
			OutRotation = default(FRotator);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TransformToBoneSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TransformToBoneSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, TransformToBoneSpace_BoneName_Offset), 0, TransformToBoneSpace_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TransformToBoneSpace_InPosition_Offset), 0, TransformToBoneSpace_InPosition_PropertyAddress.Address, InPosition);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, TransformToBoneSpace_InRotation_Offset), 0, TransformToBoneSpace_InRotation_PropertyAddress.Address, InRotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, TransformToBoneSpace_FunctionAddress, intPtr, TransformToBoneSpace_ParamsSize);
		OutPosition = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, TransformToBoneSpace_OutPosition_Offset), 0, TransformToBoneSpace_OutPosition_PropertyAddress.Address);
		OutRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, TransformToBoneSpace_OutRotation_Offset), 0, TransformToBoneSpace_OutRotation_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:TransformFromBoneSpace")]
	public unsafe void TransformFromBoneSpace(FName BoneName, FVector InPosition, FRotator InRotation, out FVector OutPosition, out FRotator OutRotation)
	{
		CheckDestroyed();
		if (!TransformFromBoneSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:TransformFromBoneSpace");
			OutPosition = default(FVector);
			OutRotation = default(FRotator);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TransformFromBoneSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TransformFromBoneSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, TransformFromBoneSpace_BoneName_Offset), 0, TransformFromBoneSpace_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TransformFromBoneSpace_InPosition_Offset), 0, TransformFromBoneSpace_InPosition_PropertyAddress.Address, InPosition);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, TransformFromBoneSpace_InRotation_Offset), 0, TransformFromBoneSpace_InRotation_PropertyAddress.Address, InRotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, TransformFromBoneSpace_FunctionAddress, intPtr, TransformFromBoneSpace_ParamsSize);
		OutPosition = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, TransformFromBoneSpace_OutPosition_Offset), 0, TransformFromBoneSpace_OutPosition_PropertyAddress.Address);
		OutRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, TransformFromBoneSpace_OutRotation_Offset), 0, TransformFromBoneSpace_OutRotation_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:ShowMaterialSection")]
	public unsafe void ShowMaterialSection(int MaterialID, int SectionIndex, bool bShow, int LODIndex)
	{
		CheckDestroyed();
		if (!ShowMaterialSection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:ShowMaterialSection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowMaterialSection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowMaterialSection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ShowMaterialSection_MaterialID_Offset), 0, ShowMaterialSection_MaterialID_PropertyAddress.Address, MaterialID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ShowMaterialSection_SectionIndex_Offset), 0, ShowMaterialSection_SectionIndex_PropertyAddress.Address, SectionIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ShowMaterialSection_bShow_Offset), 0, ShowMaterialSection_bShow_PropertyAddress.Address, bShow);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ShowMaterialSection_LODIndex_Offset), 0, ShowMaterialSection_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShowMaterialSection_FunctionAddress, intPtr, ShowMaterialSection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:ShowAllMaterialSections")]
	public unsafe void ShowAllMaterialSections(int LODIndex)
	{
		CheckDestroyed();
		if (!ShowAllMaterialSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:ShowAllMaterialSections");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowAllMaterialSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowAllMaterialSections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ShowAllMaterialSections_LODIndex_Offset), 0, ShowAllMaterialSections_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShowAllMaterialSections_FunctionAddress, intPtr, ShowAllMaterialSections_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetVertexOffsetUsage")]
	public unsafe void SetVertexOffsetUsage(int LODIndex, int Usage)
	{
		CheckDestroyed();
		if (!SetVertexOffsetUsage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetVertexOffsetUsage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVertexOffsetUsage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVertexOffsetUsage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetVertexOffsetUsage_LODIndex_Offset), 0, SetVertexOffsetUsage_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetVertexOffsetUsage_Usage_Offset), 0, SetVertexOffsetUsage_Usage_PropertyAddress.Address, Usage);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVertexOffsetUsage_FunctionAddress, intPtr, SetVertexOffsetUsage_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetVertexColorOverride_LinearColor")]
	public unsafe void SetVertexColorOverride_LinearColor(int LODIndex, List<FLinearColor> VertexColors)
	{
		CheckDestroyed();
		if (!SetVertexColorOverride_LinearColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetVertexColorOverride_LinearColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVertexColorOverride_LinearColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVertexColorOverride_LinearColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetVertexColorOverride_LinearColor_LODIndex_Offset), 0, SetVertexColorOverride_LinearColor_LODIndex_PropertyAddress.Address, LODIndex);
		new TArrayCopyMarshaler<FLinearColor>(1, SetVertexColorOverride_LinearColor_VertexColors_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).ToNative(IntPtr.Add(intPtr, SetVertexColorOverride_LinearColor_VertexColors_Offset), VertexColors);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVertexColorOverride_LinearColor_FunctionAddress, intPtr, SetVertexColorOverride_LinearColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetVertexColorOverride_LinearColor_VertexColors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetSkinWeightProfile")]
	public unsafe bool SetSkinWeightProfile(FName InProfileName)
	{
		CheckDestroyed();
		if (!SetSkinWeightProfile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetSkinWeightProfile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSkinWeightProfile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSkinWeightProfile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetSkinWeightProfile_InProfileName_Offset), 0, SetSkinWeightProfile_InProfileName_PropertyAddress.Address, InProfileName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSkinWeightProfile_FunctionAddress, intPtr, SetSkinWeightProfile_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetSkinWeightProfile_ReturnValue_Offset), 0, SetSkinWeightProfile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetSkinWeightOverride")]
	public unsafe void SetSkinWeightOverride(int LODIndex, List<FSkelMeshSkinWeightInfo> SkinWeights)
	{
		CheckDestroyed();
		if (!SetSkinWeightOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetSkinWeightOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSkinWeightOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSkinWeightOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSkinWeightOverride_LODIndex_Offset), 0, SetSkinWeightOverride_LODIndex_PropertyAddress.Address, LODIndex);
		new TArrayCopyMarshaler<FSkelMeshSkinWeightInfo>(1, SetSkinWeightOverride_SkinWeights_PropertyAddress, CachedMarshalingDelegates<FSkelMeshSkinWeightInfo, FSkelMeshSkinWeightInfo>.FromNative, CachedMarshalingDelegates<FSkelMeshSkinWeightInfo, FSkelMeshSkinWeightInfo>.ToNative).ToNative(IntPtr.Add(intPtr, SetSkinWeightOverride_SkinWeights_Offset), SkinWeights);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSkinWeightOverride_FunctionAddress, intPtr, SetSkinWeightOverride_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSkinWeightOverride_SkinWeights_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetSkeletalMesh")]
	public unsafe void SetSkeletalMesh(USkeletalMesh NewMesh, bool bReinitPose = true)
	{
		CheckDestroyed();
		if (!SetSkeletalMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetSkeletalMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSkeletalMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSkeletalMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, SetSkeletalMesh_NewMesh_Offset), 0, SetSkeletalMesh_NewMesh_PropertyAddress.Address, NewMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSkeletalMesh_bReinitPose_Offset), 0, SetSkeletalMesh_bReinitPose_PropertyAddress.Address, bReinitPose);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSkeletalMesh_FunctionAddress, intPtr, SetSkeletalMesh_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetRenderStatic")]
	public unsafe void SetRenderStatic(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetRenderStatic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetRenderStatic");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderStatic_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderStatic_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRenderStatic_bNewValue_Offset), 0, SetRenderStatic_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRenderStatic_FunctionAddress, intPtr, SetRenderStatic_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetPreSkinningOffsets")]
	public unsafe void SetPreSkinningOffsets(int LODIndex, List<FVector> Offsets)
	{
		CheckDestroyed();
		if (!SetPreSkinningOffsets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetPreSkinningOffsets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPreSkinningOffsets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPreSkinningOffsets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPreSkinningOffsets_LODIndex_Offset), 0, SetPreSkinningOffsets_LODIndex_PropertyAddress.Address, LODIndex);
		new TArrayCopyMarshaler<FVector>(1, SetPreSkinningOffsets_Offsets_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, SetPreSkinningOffsets_Offsets_Offset), Offsets);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPreSkinningOffsets_FunctionAddress, intPtr, SetPreSkinningOffsets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPreSkinningOffsets_Offsets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetPostSkinningOffsets")]
	public unsafe void SetPostSkinningOffsets(int LODIndex, List<FVector> Offsets)
	{
		CheckDestroyed();
		if (!SetPostSkinningOffsets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetPostSkinningOffsets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPostSkinningOffsets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPostSkinningOffsets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPostSkinningOffsets_LODIndex_Offset), 0, SetPostSkinningOffsets_LODIndex_PropertyAddress.Address, LODIndex);
		new TArrayCopyMarshaler<FVector>(1, SetPostSkinningOffsets_Offsets_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, SetPostSkinningOffsets_Offsets_Offset), Offsets);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPostSkinningOffsets_FunctionAddress, intPtr, SetPostSkinningOffsets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPostSkinningOffsets_Offsets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetPhysicsAsset")]
	public unsafe void SetPhysicsAsset(UPhysicsAsset NewPhysicsAsset, bool bForceReInit = false)
	{
		CheckDestroyed();
		if (!SetPhysicsAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetPhysicsAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPhysicsAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPhysicsAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPhysicsAsset>.ToNative(IntPtr.Add(intPtr, SetPhysicsAsset_NewPhysicsAsset_Offset), 0, SetPhysicsAsset_NewPhysicsAsset_PropertyAddress.Address, NewPhysicsAsset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPhysicsAsset_bForceReInit_Offset), 0, SetPhysicsAsset_bForceReInit_PropertyAddress.Address, bForceReInit);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPhysicsAsset_FunctionAddress, intPtr, SetPhysicsAsset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetMinLOD")]
	public unsafe void SetMinLOD(int InNewMinLOD)
	{
		CheckDestroyed();
		if (!SetMinLOD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetMinLOD");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinLOD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinLOD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMinLOD_InNewMinLOD_Offset), 0, SetMinLOD_InNewMinLOD_PropertyAddress.Address, InNewMinLOD);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMinLOD_FunctionAddress, intPtr, SetMinLOD_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetMeshDeformer")]
	public unsafe void SetMeshDeformer(UMeshDeformer InMeshDeformer)
	{
		CheckDestroyed();
		if (!SetMeshDeformer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetMeshDeformer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMeshDeformer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMeshDeformer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMeshDeformer>.ToNative(IntPtr.Add(intPtr, SetMeshDeformer_InMeshDeformer_Offset), 0, SetMeshDeformer_InMeshDeformer_PropertyAddress.Address, InMeshDeformer);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMeshDeformer_FunctionAddress, intPtr, SetMeshDeformer_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetMasterPoseComponent")]
	public unsafe void SetMasterPoseComponent(USkinnedMeshComponent NewMasterBoneComponent, bool bForceUpdate = false)
	{
		CheckDestroyed();
		if (!SetMasterPoseComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetMasterPoseComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMasterPoseComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMasterPoseComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkinnedMeshComponent>.ToNative(IntPtr.Add(intPtr, SetMasterPoseComponent_NewMasterBoneComponent_Offset), 0, SetMasterPoseComponent_NewMasterBoneComponent_PropertyAddress.Address, NewMasterBoneComponent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetMasterPoseComponent_bForceUpdate_Offset), 0, SetMasterPoseComponent_bForceUpdate_PropertyAddress.Address, bForceUpdate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMasterPoseComponent_FunctionAddress, intPtr, SetMasterPoseComponent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetForcedLOD")]
	public unsafe void SetForcedLOD(int InNewForcedLOD)
	{
		CheckDestroyed();
		if (!SetForcedLOD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetForcedLOD");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForcedLOD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForcedLOD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetForcedLOD_InNewForcedLOD_Offset), 0, SetForcedLOD_InNewForcedLOD_PropertyAddress.Address, InNewForcedLOD);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForcedLOD_FunctionAddress, intPtr, SetForcedLOD_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetCastCapsuleIndirectShadow")]
	public unsafe void SetCastCapsuleIndirectShadow(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetCastCapsuleIndirectShadow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetCastCapsuleIndirectShadow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCastCapsuleIndirectShadow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCastCapsuleIndirectShadow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCastCapsuleIndirectShadow_bNewValue_Offset), 0, SetCastCapsuleIndirectShadow_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCastCapsuleIndirectShadow_FunctionAddress, intPtr, SetCastCapsuleIndirectShadow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetCastCapsuleDirectShadow")]
	public unsafe void SetCastCapsuleDirectShadow(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetCastCapsuleDirectShadow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetCastCapsuleDirectShadow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCastCapsuleDirectShadow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCastCapsuleDirectShadow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCastCapsuleDirectShadow_bNewValue_Offset), 0, SetCastCapsuleDirectShadow_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCastCapsuleDirectShadow_FunctionAddress, intPtr, SetCastCapsuleDirectShadow_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:SetCapsuleIndirectShadowMinVisibility")]
	public unsafe void SetCapsuleIndirectShadowMinVisibility(float NewValue)
	{
		CheckDestroyed();
		if (!SetCapsuleIndirectShadowMinVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:SetCapsuleIndirectShadowMinVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCapsuleIndirectShadowMinVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCapsuleIndirectShadowMinVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCapsuleIndirectShadowMinVisibility_NewValue_Offset), 0, SetCapsuleIndirectShadowMinVisibility_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCapsuleIndirectShadowMinVisibility_FunctionAddress, intPtr, SetCapsuleIndirectShadowMinVisibility_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:IsUsingSkinWeightProfile")]
	public unsafe bool IsUsingSkinWeightProfile()
	{
		CheckDestroyed();
		if (!IsUsingSkinWeightProfile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:IsUsingSkinWeightProfile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsUsingSkinWeightProfile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsUsingSkinWeightProfile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsUsingSkinWeightProfile_FunctionAddress, intPtr, IsUsingSkinWeightProfile_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsUsingSkinWeightProfile_ReturnValue_Offset), 0, IsUsingSkinWeightProfile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:IsMaterialSectionShown")]
	public unsafe bool IsMaterialSectionShown(int MaterialID, int LODIndex)
	{
		CheckDestroyed();
		if (!IsMaterialSectionShown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:IsMaterialSectionShown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMaterialSectionShown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMaterialSectionShown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IsMaterialSectionShown_MaterialID_Offset), 0, IsMaterialSectionShown_MaterialID_PropertyAddress.Address, MaterialID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IsMaterialSectionShown_LODIndex_Offset), 0, IsMaterialSectionShown_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsMaterialSectionShown_FunctionAddress, intPtr, IsMaterialSectionShown_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMaterialSectionShown_ReturnValue_Offset), 0, IsMaterialSectionShown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:IsBoneHiddenByName")]
	public unsafe bool IsBoneHiddenByName(FName BoneName)
	{
		CheckDestroyed();
		if (!IsBoneHiddenByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:IsBoneHiddenByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsBoneHiddenByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsBoneHiddenByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsBoneHiddenByName_BoneName_Offset), 0, IsBoneHiddenByName_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsBoneHiddenByName_FunctionAddress, intPtr, IsBoneHiddenByName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsBoneHiddenByName_ReturnValue_Offset), 0, IsBoneHiddenByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:HideBoneByName")]
	public unsafe void HideBoneByName(FName BoneName, EPhysBodyOp PhysBodyOption)
	{
		CheckDestroyed();
		if (!HideBoneByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:HideBoneByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HideBoneByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HideBoneByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, HideBoneByName_BoneName_Offset), 0, HideBoneByName_BoneName_PropertyAddress.Address, BoneName);
		EnumMarshaler<EPhysBodyOp>.ToNative(IntPtr.Add(intPtr, HideBoneByName_PhysBodyOption_Offset), 0, HideBoneByName_PhysBodyOption_PropertyAddress.Address, PhysBodyOption);
		NativeReflection.InvokeFunctionOptimized(base.Address, HideBoneByName_FunctionAddress, intPtr, HideBoneByName_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:GetVertexOffsetUsage")]
	public unsafe int GetVertexOffsetUsage(int LODIndex)
	{
		CheckDestroyed();
		if (!GetVertexOffsetUsage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:GetVertexOffsetUsage");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVertexOffsetUsage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVertexOffsetUsage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVertexOffsetUsage_LODIndex_Offset), 0, GetVertexOffsetUsage_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVertexOffsetUsage_FunctionAddress, intPtr, GetVertexOffsetUsage_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetVertexOffsetUsage_ReturnValue_Offset), 0, GetVertexOffsetUsage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:GetTwistAndSwingAngleOfDeltaRotationFromRefPose")]
	public unsafe bool GetTwistAndSwingAngleOfDeltaRotationFromRefPose(FName BoneName, out float OutTwistAngle, out float OutSwingAngle)
	{
		CheckDestroyed();
		if (!GetTwistAndSwingAngleOfDeltaRotationFromRefPose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:GetTwistAndSwingAngleOfDeltaRotationFromRefPose");
			OutTwistAngle = 0f;
			OutSwingAngle = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTwistAndSwingAngleOfDeltaRotationFromRefPose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTwistAndSwingAngleOfDeltaRotationFromRefPose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTwistAndSwingAngleOfDeltaRotationFromRefPose_BoneName_Offset), 0, GetTwistAndSwingAngleOfDeltaRotationFromRefPose_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress, intPtr, GetTwistAndSwingAngleOfDeltaRotationFromRefPose_ParamsSize);
		OutTwistAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutTwistAngle_Offset), 0, GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutTwistAngle_PropertyAddress.Address);
		OutSwingAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutSwingAngle_Offset), 0, GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutSwingAngle_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTwistAndSwingAngleOfDeltaRotationFromRefPose_ReturnValue_Offset), 0, GetTwistAndSwingAngleOfDeltaRotationFromRefPose_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:GetSocketBoneName")]
	public unsafe FName GetSocketBoneName(FName InSocketName)
	{
		CheckDestroyed();
		if (!GetSocketBoneName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:GetSocketBoneName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSocketBoneName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSocketBoneName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetSocketBoneName_InSocketName_Offset), 0, GetSocketBoneName_InSocketName_PropertyAddress.Address, InSocketName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSocketBoneName_FunctionAddress, intPtr, GetSocketBoneName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetSocketBoneName_ReturnValue_Offset), 0, GetSocketBoneName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:GetRefPoseTransform")]
	public unsafe FTransform GetRefPoseTransform(int BoneIndex)
	{
		CheckDestroyed();
		if (!GetRefPoseTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:GetRefPoseTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRefPoseTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRefPoseTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetRefPoseTransform_BoneIndex_Offset), 0, GetRefPoseTransform_BoneIndex_PropertyAddress.Address, BoneIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRefPoseTransform_FunctionAddress, intPtr, GetRefPoseTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetRefPoseTransform_ReturnValue_Offset), 0, GetRefPoseTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:GetRefPosePosition")]
	public unsafe FVector GetRefPosePosition(int BoneIndex)
	{
		CheckDestroyed();
		if (!GetRefPosePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:GetRefPosePosition");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRefPosePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRefPosePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetRefPosePosition_BoneIndex_Offset), 0, GetRefPosePosition_BoneIndex_PropertyAddress.Address, BoneIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRefPosePosition_FunctionAddress, intPtr, GetRefPosePosition_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetRefPosePosition_ReturnValue_Offset), 0, GetRefPosePosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:GetParentBone")]
	public unsafe FName GetParentBone(FName BoneName)
	{
		CheckDestroyed();
		if (!GetParentBone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:GetParentBone");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentBone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentBone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetParentBone_BoneName_Offset), 0, GetParentBone_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParentBone_FunctionAddress, intPtr, GetParentBone_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetParentBone_ReturnValue_Offset), 0, GetParentBone_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:GetNumLODs")]
	public unsafe int GetNumLODs()
	{
		CheckDestroyed();
		if (!GetNumLODs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:GetNumLODs");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumLODs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumLODs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumLODs_FunctionAddress, intPtr, GetNumLODs_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumLODs_ReturnValue_Offset), 0, GetNumLODs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:GetNumBones")]
	public unsafe int GetNumBones()
	{
		CheckDestroyed();
		if (!GetNumBones_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:GetNumBones");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumBones_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumBones_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumBones_FunctionAddress, intPtr, GetNumBones_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumBones_ReturnValue_Offset), 0, GetNumBones_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:GetForcedLOD")]
	public unsafe int GetForcedLOD()
	{
		CheckDestroyed();
		if (!GetForcedLOD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:GetForcedLOD");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetForcedLOD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetForcedLOD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetForcedLOD_FunctionAddress, intPtr, GetForcedLOD_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetForcedLOD_ReturnValue_Offset), 0, GetForcedLOD_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:GetDeltaTransformFromRefPose")]
	public unsafe FTransform GetDeltaTransformFromRefPose(FName BoneName, FName BaseName)
	{
		CheckDestroyed();
		if (!GetDeltaTransformFromRefPose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:GetDeltaTransformFromRefPose");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDeltaTransformFromRefPose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDeltaTransformFromRefPose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetDeltaTransformFromRefPose_BoneName_Offset), 0, GetDeltaTransformFromRefPose_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetDeltaTransformFromRefPose_BaseName_Offset), 0, GetDeltaTransformFromRefPose_BaseName_PropertyAddress.Address, BaseName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDeltaTransformFromRefPose_FunctionAddress, intPtr, GetDeltaTransformFromRefPose_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetDeltaTransformFromRefPose_ReturnValue_Offset), 0, GetDeltaTransformFromRefPose_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:GetCurrentSkinWeightProfileName")]
	public unsafe FName GetCurrentSkinWeightProfileName()
	{
		CheckDestroyed();
		if (!GetCurrentSkinWeightProfileName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:GetCurrentSkinWeightProfileName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentSkinWeightProfileName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentSkinWeightProfileName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentSkinWeightProfileName_FunctionAddress, intPtr, GetCurrentSkinWeightProfileName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetCurrentSkinWeightProfileName_ReturnValue_Offset), 0, GetCurrentSkinWeightProfileName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:GetBoneName")]
	public unsafe FName GetBoneName(int BoneIndex)
	{
		CheckDestroyed();
		if (!GetBoneName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:GetBoneName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBoneName_BoneIndex_Offset), 0, GetBoneName_BoneIndex_PropertyAddress.Address, BoneIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoneName_FunctionAddress, intPtr, GetBoneName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetBoneName_ReturnValue_Offset), 0, GetBoneName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:GetBoneIndex")]
	public unsafe int GetBoneIndex(FName BoneName)
	{
		CheckDestroyed();
		if (!GetBoneIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:GetBoneIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBoneIndex_BoneName_Offset), 0, GetBoneIndex_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoneIndex_FunctionAddress, intPtr, GetBoneIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetBoneIndex_ReturnValue_Offset), 0, GetBoneIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:FindClosestBone_K2")]
	public unsafe FName FindClosestBone_K2(FVector TestLocation, out FVector BoneLocation, float IgnoreScale = 0f, bool bRequirePhysicsAsset = false)
	{
		CheckDestroyed();
		if (!FindClosestBone_K2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:FindClosestBone_K2");
			BoneLocation = default(FVector);
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindClosestBone_K2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindClosestBone_K2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindClosestBone_K2_TestLocation_Offset), 0, FindClosestBone_K2_TestLocation_PropertyAddress.Address, TestLocation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FindClosestBone_K2_IgnoreScale_Offset), 0, FindClosestBone_K2_IgnoreScale_PropertyAddress.Address, IgnoreScale);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FindClosestBone_K2_bRequirePhysicsAsset_Offset), 0, FindClosestBone_K2_bRequirePhysicsAsset_PropertyAddress.Address, bRequirePhysicsAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindClosestBone_K2_FunctionAddress, intPtr, FindClosestBone_K2_ParamsSize);
		BoneLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, FindClosestBone_K2_BoneLocation_Offset), 0, FindClosestBone_K2_BoneLocation_PropertyAddress.Address);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, FindClosestBone_K2_ReturnValue_Offset), 0, FindClosestBone_K2_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:ClearVertexColorOverride")]
	public unsafe void ClearVertexColorOverride(int LODIndex)
	{
		CheckDestroyed();
		if (!ClearVertexColorOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:ClearVertexColorOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearVertexColorOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearVertexColorOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ClearVertexColorOverride_LODIndex_Offset), 0, ClearVertexColorOverride_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClearVertexColorOverride_FunctionAddress, intPtr, ClearVertexColorOverride_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:ClearSkinWeightProfile")]
	public unsafe void ClearSkinWeightProfile()
	{
		CheckDestroyed();
		if (!ClearSkinWeightProfile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:ClearSkinWeightProfile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSkinWeightProfile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSkinWeightProfile_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearSkinWeightProfile_FunctionAddress, argsSize: ClearSkinWeightProfile_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:ClearSkinWeightOverride")]
	public unsafe void ClearSkinWeightOverride(int LODIndex)
	{
		CheckDestroyed();
		if (!ClearSkinWeightOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:ClearSkinWeightOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSkinWeightOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSkinWeightOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ClearSkinWeightOverride_LODIndex_Offset), 0, ClearSkinWeightOverride_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClearSkinWeightOverride_FunctionAddress, intPtr, ClearSkinWeightOverride_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SkinnedMeshComponent:BoneIsChildOf")]
	public unsafe bool BoneIsChildOf(FName BoneName, FName ParentBoneName)
	{
		CheckDestroyed();
		if (!BoneIsChildOf_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkinnedMeshComponent:BoneIsChildOf");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BoneIsChildOf_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BoneIsChildOf_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BoneIsChildOf_BoneName_Offset), 0, BoneIsChildOf_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BoneIsChildOf_ParentBoneName_Offset), 0, BoneIsChildOf_ParentBoneName_PropertyAddress.Address, ParentBoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, BoneIsChildOf_FunctionAddress, intPtr, BoneIsChildOf_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BoneIsChildOf_ReturnValue_Offset), 0, BoneIsChildOf_ReturnValue_PropertyAddress.Address);
	}

	static USkinnedMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USkinnedMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USkinnedMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SkinnedMeshComponent");
		SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkeletalMesh");
		SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkeletalMesh", Classes.FObjectProperty);
		MasterPoseComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MasterPoseComponent");
		MasterPoseComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MasterPoseComponent", Classes.FWeakObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SkinCacheUsage_PropertyAddress, intPtr, "SkinCacheUsage");
		SkinCacheUsage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkinCacheUsage");
		SkinCacheUsage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkinCacheUsage", Classes.FArrayProperty);
		MeshDeformer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshDeformer");
		MeshDeformer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshDeformer", Classes.FObjectProperty);
		PhysicsAssetOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PhysicsAssetOverride");
		PhysicsAssetOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PhysicsAssetOverride", Classes.FObjectProperty);
		ForcedLodModel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForcedLodModel");
		ForcedLodModel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForcedLodModel", Classes.FIntProperty);
		MinLodModel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinLodModel");
		MinLodModel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinLodModel", Classes.FIntProperty);
		StreamingDistanceMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StreamingDistanceMultiplier");
		StreamingDistanceMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StreamingDistanceMultiplier", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref VisibilityBasedAnimTickOption_PropertyAddress, intPtr, "VisibilityBasedAnimTickOption");
		VisibilityBasedAnimTickOption_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VisibilityBasedAnimTickOption");
		VisibilityBasedAnimTickOption_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VisibilityBasedAnimTickOption", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideMinLod_PropertyAddress, intPtr, "bOverrideMinLod");
		OverrideMinLod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideMinLod");
		OverrideMinLod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideMinLod", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseBoundsFromMasterPoseComponent_PropertyAddress, intPtr, "bUseBoundsFromMasterPoseComponent");
		UseBoundsFromMasterPoseComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseBoundsFromMasterPoseComponent");
		UseBoundsFromMasterPoseComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseBoundsFromMasterPoseComponent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableMorphTarget_PropertyAddress, intPtr, "bDisableMorphTarget");
		DisableMorphTarget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableMorphTarget");
		DisableMorphTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableMorphTarget", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PerBoneMotionBlur_PropertyAddress, intPtr, "bPerBoneMotionBlur");
		PerBoneMotionBlur_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPerBoneMotionBlur");
		PerBoneMotionBlur_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPerBoneMotionBlur", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentUseFixedSkelBounds_PropertyAddress, intPtr, "bComponentUseFixedSkelBounds");
		ComponentUseFixedSkelBounds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bComponentUseFixedSkelBounds");
		ComponentUseFixedSkelBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bComponentUseFixedSkelBounds", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ConsiderAllBodiesForBounds_PropertyAddress, intPtr, "bConsiderAllBodiesForBounds");
		ConsiderAllBodiesForBounds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bConsiderAllBodiesForBounds");
		ConsiderAllBodiesForBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bConsiderAllBodiesForBounds", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SyncAttachParentLOD_PropertyAddress, intPtr, "bSyncAttachParentLOD");
		SyncAttachParentLOD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSyncAttachParentLOD");
		SyncAttachParentLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSyncAttachParentLOD", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastCapsuleDirectShadow_PropertyAddress, intPtr, "bCastCapsuleDirectShadow");
		CastCapsuleDirectShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastCapsuleDirectShadow");
		CastCapsuleDirectShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastCapsuleDirectShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastCapsuleIndirectShadow_PropertyAddress, intPtr, "bCastCapsuleIndirectShadow");
		CastCapsuleIndirectShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastCapsuleIndirectShadow");
		CastCapsuleIndirectShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastCapsuleIndirectShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableUpdateRateOptimizations_PropertyAddress, intPtr, "bEnableUpdateRateOptimizations");
		EnableUpdateRateOptimizations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableUpdateRateOptimizations");
		EnableUpdateRateOptimizations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableUpdateRateOptimizations", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisplayDebugUpdateRateOptimizations_PropertyAddress, intPtr, "bDisplayDebugUpdateRateOptimizations");
		DisplayDebugUpdateRateOptimizations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisplayDebugUpdateRateOptimizations");
		DisplayDebugUpdateRateOptimizations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisplayDebugUpdateRateOptimizations", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderStatic_PropertyAddress, intPtr, "bRenderStatic");
		RenderStatic_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRenderStatic");
		RenderStatic_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRenderStatic", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreMasterPoseComponentLOD_PropertyAddress, intPtr, "bIgnoreMasterPoseComponentLOD");
		IgnoreMasterPoseComponentLOD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreMasterPoseComponentLOD");
		IgnoreMasterPoseComponentLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreMasterPoseComponentLOD", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClothingUseRefSkeleton_PropertyAddress, intPtr, "bClothingUseRefSkeleton");
		ClothingUseRefSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bClothingUseRefSkeleton");
		ClothingUseRefSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bClothingUseRefSkeleton", Classes.FBoolProperty);
		CapsuleIndirectShadowMinVisibility_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CapsuleIndirectShadowMinVisibility");
		CapsuleIndirectShadowMinVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CapsuleIndirectShadowMinVisibility", Classes.FFloatProperty);
		UnloadSkinWeightProfile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnloadSkinWeightProfile");
		UnloadSkinWeightProfile_ParamsSize = NativeReflection.GetFunctionParamsSize(UnloadSkinWeightProfile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnloadSkinWeightProfile_InProfileName_PropertyAddress, UnloadSkinWeightProfile_FunctionAddress, "InProfileName");
		UnloadSkinWeightProfile_InProfileName_Offset = NativeReflectionCached.GetPropertyOffset(UnloadSkinWeightProfile_FunctionAddress, "InProfileName");
		UnloadSkinWeightProfile_InProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(UnloadSkinWeightProfile_FunctionAddress, "InProfileName", Classes.FNameProperty);
		UnloadSkinWeightProfile_IsValid = UnloadSkinWeightProfile_FunctionAddress != IntPtr.Zero && UnloadSkinWeightProfile_InProfileName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:UnloadSkinWeightProfile", UnloadSkinWeightProfile_IsValid);
		UnHideBoneByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnHideBoneByName");
		UnHideBoneByName_ParamsSize = NativeReflection.GetFunctionParamsSize(UnHideBoneByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnHideBoneByName_BoneName_PropertyAddress, UnHideBoneByName_FunctionAddress, "BoneName");
		UnHideBoneByName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(UnHideBoneByName_FunctionAddress, "BoneName");
		UnHideBoneByName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(UnHideBoneByName_FunctionAddress, "BoneName", Classes.FNameProperty);
		UnHideBoneByName_IsValid = UnHideBoneByName_FunctionAddress != IntPtr.Zero && UnHideBoneByName_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:UnHideBoneByName", UnHideBoneByName_IsValid);
		TransformToBoneSpace_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TransformToBoneSpace");
		TransformToBoneSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(TransformToBoneSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TransformToBoneSpace_BoneName_PropertyAddress, TransformToBoneSpace_FunctionAddress, "BoneName");
		TransformToBoneSpace_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(TransformToBoneSpace_FunctionAddress, "BoneName");
		TransformToBoneSpace_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformToBoneSpace_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformToBoneSpace_InPosition_PropertyAddress, TransformToBoneSpace_FunctionAddress, "InPosition");
		TransformToBoneSpace_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(TransformToBoneSpace_FunctionAddress, "InPosition");
		TransformToBoneSpace_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformToBoneSpace_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformToBoneSpace_InRotation_PropertyAddress, TransformToBoneSpace_FunctionAddress, "InRotation");
		TransformToBoneSpace_InRotation_Offset = NativeReflectionCached.GetPropertyOffset(TransformToBoneSpace_FunctionAddress, "InRotation");
		TransformToBoneSpace_InRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformToBoneSpace_FunctionAddress, "InRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformToBoneSpace_OutPosition_PropertyAddress, TransformToBoneSpace_FunctionAddress, "OutPosition");
		TransformToBoneSpace_OutPosition_Offset = NativeReflectionCached.GetPropertyOffset(TransformToBoneSpace_FunctionAddress, "OutPosition");
		TransformToBoneSpace_OutPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformToBoneSpace_FunctionAddress, "OutPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformToBoneSpace_OutRotation_PropertyAddress, TransformToBoneSpace_FunctionAddress, "OutRotation");
		TransformToBoneSpace_OutRotation_Offset = NativeReflectionCached.GetPropertyOffset(TransformToBoneSpace_FunctionAddress, "OutRotation");
		TransformToBoneSpace_OutRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformToBoneSpace_FunctionAddress, "OutRotation", Classes.FStructProperty);
		TransformToBoneSpace_IsValid = TransformToBoneSpace_FunctionAddress != IntPtr.Zero && TransformToBoneSpace_BoneName_IsValid && TransformToBoneSpace_InPosition_IsValid && TransformToBoneSpace_InRotation_IsValid && TransformToBoneSpace_OutPosition_IsValid && TransformToBoneSpace_OutRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:TransformToBoneSpace", TransformToBoneSpace_IsValid);
		TransformFromBoneSpace_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TransformFromBoneSpace");
		TransformFromBoneSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(TransformFromBoneSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TransformFromBoneSpace_BoneName_PropertyAddress, TransformFromBoneSpace_FunctionAddress, "BoneName");
		TransformFromBoneSpace_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(TransformFromBoneSpace_FunctionAddress, "BoneName");
		TransformFromBoneSpace_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformFromBoneSpace_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformFromBoneSpace_InPosition_PropertyAddress, TransformFromBoneSpace_FunctionAddress, "InPosition");
		TransformFromBoneSpace_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(TransformFromBoneSpace_FunctionAddress, "InPosition");
		TransformFromBoneSpace_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformFromBoneSpace_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformFromBoneSpace_InRotation_PropertyAddress, TransformFromBoneSpace_FunctionAddress, "InRotation");
		TransformFromBoneSpace_InRotation_Offset = NativeReflectionCached.GetPropertyOffset(TransformFromBoneSpace_FunctionAddress, "InRotation");
		TransformFromBoneSpace_InRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformFromBoneSpace_FunctionAddress, "InRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformFromBoneSpace_OutPosition_PropertyAddress, TransformFromBoneSpace_FunctionAddress, "OutPosition");
		TransformFromBoneSpace_OutPosition_Offset = NativeReflectionCached.GetPropertyOffset(TransformFromBoneSpace_FunctionAddress, "OutPosition");
		TransformFromBoneSpace_OutPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformFromBoneSpace_FunctionAddress, "OutPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformFromBoneSpace_OutRotation_PropertyAddress, TransformFromBoneSpace_FunctionAddress, "OutRotation");
		TransformFromBoneSpace_OutRotation_Offset = NativeReflectionCached.GetPropertyOffset(TransformFromBoneSpace_FunctionAddress, "OutRotation");
		TransformFromBoneSpace_OutRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(TransformFromBoneSpace_FunctionAddress, "OutRotation", Classes.FStructProperty);
		TransformFromBoneSpace_IsValid = TransformFromBoneSpace_FunctionAddress != IntPtr.Zero && TransformFromBoneSpace_BoneName_IsValid && TransformFromBoneSpace_InPosition_IsValid && TransformFromBoneSpace_InRotation_IsValid && TransformFromBoneSpace_OutPosition_IsValid && TransformFromBoneSpace_OutRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:TransformFromBoneSpace", TransformFromBoneSpace_IsValid);
		ShowMaterialSection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShowMaterialSection");
		ShowMaterialSection_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowMaterialSection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowMaterialSection_MaterialID_PropertyAddress, ShowMaterialSection_FunctionAddress, "MaterialID");
		ShowMaterialSection_MaterialID_Offset = NativeReflectionCached.GetPropertyOffset(ShowMaterialSection_FunctionAddress, "MaterialID");
		ShowMaterialSection_MaterialID_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowMaterialSection_FunctionAddress, "MaterialID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowMaterialSection_SectionIndex_PropertyAddress, ShowMaterialSection_FunctionAddress, "SectionIndex");
		ShowMaterialSection_SectionIndex_Offset = NativeReflectionCached.GetPropertyOffset(ShowMaterialSection_FunctionAddress, "SectionIndex");
		ShowMaterialSection_SectionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowMaterialSection_FunctionAddress, "SectionIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowMaterialSection_bShow_PropertyAddress, ShowMaterialSection_FunctionAddress, "bShow");
		ShowMaterialSection_bShow_Offset = NativeReflectionCached.GetPropertyOffset(ShowMaterialSection_FunctionAddress, "bShow");
		ShowMaterialSection_bShow_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowMaterialSection_FunctionAddress, "bShow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowMaterialSection_LODIndex_PropertyAddress, ShowMaterialSection_FunctionAddress, "LODIndex");
		ShowMaterialSection_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(ShowMaterialSection_FunctionAddress, "LODIndex");
		ShowMaterialSection_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowMaterialSection_FunctionAddress, "LODIndex", Classes.FIntProperty);
		ShowMaterialSection_IsValid = ShowMaterialSection_FunctionAddress != IntPtr.Zero && ShowMaterialSection_MaterialID_IsValid && ShowMaterialSection_SectionIndex_IsValid && ShowMaterialSection_bShow_IsValid && ShowMaterialSection_LODIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:ShowMaterialSection", ShowMaterialSection_IsValid);
		ShowAllMaterialSections_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShowAllMaterialSections");
		ShowAllMaterialSections_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowAllMaterialSections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowAllMaterialSections_LODIndex_PropertyAddress, ShowAllMaterialSections_FunctionAddress, "LODIndex");
		ShowAllMaterialSections_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(ShowAllMaterialSections_FunctionAddress, "LODIndex");
		ShowAllMaterialSections_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowAllMaterialSections_FunctionAddress, "LODIndex", Classes.FIntProperty);
		ShowAllMaterialSections_IsValid = ShowAllMaterialSections_FunctionAddress != IntPtr.Zero && ShowAllMaterialSections_LODIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:ShowAllMaterialSections", ShowAllMaterialSections_IsValid);
		SetVertexOffsetUsage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVertexOffsetUsage");
		SetVertexOffsetUsage_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVertexOffsetUsage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVertexOffsetUsage_LODIndex_PropertyAddress, SetVertexOffsetUsage_FunctionAddress, "LODIndex");
		SetVertexOffsetUsage_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexOffsetUsage_FunctionAddress, "LODIndex");
		SetVertexOffsetUsage_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexOffsetUsage_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVertexOffsetUsage_Usage_PropertyAddress, SetVertexOffsetUsage_FunctionAddress, "Usage");
		SetVertexOffsetUsage_Usage_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexOffsetUsage_FunctionAddress, "Usage");
		SetVertexOffsetUsage_Usage_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexOffsetUsage_FunctionAddress, "Usage", Classes.FIntProperty);
		SetVertexOffsetUsage_IsValid = SetVertexOffsetUsage_FunctionAddress != IntPtr.Zero && SetVertexOffsetUsage_LODIndex_IsValid && SetVertexOffsetUsage_Usage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetVertexOffsetUsage", SetVertexOffsetUsage_IsValid);
		SetVertexColorOverride_LinearColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVertexColorOverride_LinearColor");
		SetVertexColorOverride_LinearColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVertexColorOverride_LinearColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVertexColorOverride_LinearColor_LODIndex_PropertyAddress, SetVertexColorOverride_LinearColor_FunctionAddress, "LODIndex");
		SetVertexColorOverride_LinearColor_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexColorOverride_LinearColor_FunctionAddress, "LODIndex");
		SetVertexColorOverride_LinearColor_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexColorOverride_LinearColor_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVertexColorOverride_LinearColor_VertexColors_PropertyAddress, SetVertexColorOverride_LinearColor_FunctionAddress, "VertexColors");
		SetVertexColorOverride_LinearColor_VertexColors_Offset = NativeReflectionCached.GetPropertyOffset(SetVertexColorOverride_LinearColor_FunctionAddress, "VertexColors");
		SetVertexColorOverride_LinearColor_VertexColors_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertexColorOverride_LinearColor_FunctionAddress, "VertexColors", Classes.FArrayProperty);
		SetVertexColorOverride_LinearColor_IsValid = SetVertexColorOverride_LinearColor_FunctionAddress != IntPtr.Zero && SetVertexColorOverride_LinearColor_LODIndex_IsValid && SetVertexColorOverride_LinearColor_VertexColors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetVertexColorOverride_LinearColor", SetVertexColorOverride_LinearColor_IsValid);
		SetSkinWeightProfile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSkinWeightProfile");
		SetSkinWeightProfile_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSkinWeightProfile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSkinWeightProfile_InProfileName_PropertyAddress, SetSkinWeightProfile_FunctionAddress, "InProfileName");
		SetSkinWeightProfile_InProfileName_Offset = NativeReflectionCached.GetPropertyOffset(SetSkinWeightProfile_FunctionAddress, "InProfileName");
		SetSkinWeightProfile_InProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkinWeightProfile_FunctionAddress, "InProfileName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSkinWeightProfile_ReturnValue_PropertyAddress, SetSkinWeightProfile_FunctionAddress, "ReturnValue");
		SetSkinWeightProfile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSkinWeightProfile_FunctionAddress, "ReturnValue");
		SetSkinWeightProfile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkinWeightProfile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetSkinWeightProfile_IsValid = SetSkinWeightProfile_FunctionAddress != IntPtr.Zero && SetSkinWeightProfile_InProfileName_IsValid && SetSkinWeightProfile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetSkinWeightProfile", SetSkinWeightProfile_IsValid);
		SetSkinWeightOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSkinWeightOverride");
		SetSkinWeightOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSkinWeightOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSkinWeightOverride_LODIndex_PropertyAddress, SetSkinWeightOverride_FunctionAddress, "LODIndex");
		SetSkinWeightOverride_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetSkinWeightOverride_FunctionAddress, "LODIndex");
		SetSkinWeightOverride_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkinWeightOverride_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSkinWeightOverride_SkinWeights_PropertyAddress, SetSkinWeightOverride_FunctionAddress, "SkinWeights");
		SetSkinWeightOverride_SkinWeights_Offset = NativeReflectionCached.GetPropertyOffset(SetSkinWeightOverride_FunctionAddress, "SkinWeights");
		SetSkinWeightOverride_SkinWeights_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkinWeightOverride_FunctionAddress, "SkinWeights", Classes.FArrayProperty);
		SetSkinWeightOverride_IsValid = SetSkinWeightOverride_FunctionAddress != IntPtr.Zero && SetSkinWeightOverride_LODIndex_IsValid && SetSkinWeightOverride_SkinWeights_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetSkinWeightOverride", SetSkinWeightOverride_IsValid);
		SetSkeletalMesh_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSkeletalMesh");
		SetSkeletalMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSkeletalMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSkeletalMesh_NewMesh_PropertyAddress, SetSkeletalMesh_FunctionAddress, "NewMesh");
		SetSkeletalMesh_NewMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetSkeletalMesh_FunctionAddress, "NewMesh");
		SetSkeletalMesh_NewMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkeletalMesh_FunctionAddress, "NewMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSkeletalMesh_bReinitPose_PropertyAddress, SetSkeletalMesh_FunctionAddress, "bReinitPose");
		SetSkeletalMesh_bReinitPose_Offset = NativeReflectionCached.GetPropertyOffset(SetSkeletalMesh_FunctionAddress, "bReinitPose");
		SetSkeletalMesh_bReinitPose_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkeletalMesh_FunctionAddress, "bReinitPose", Classes.FBoolProperty);
		SetSkeletalMesh_IsValid = SetSkeletalMesh_FunctionAddress != IntPtr.Zero && SetSkeletalMesh_NewMesh_IsValid && SetSkeletalMesh_bReinitPose_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetSkeletalMesh", SetSkeletalMesh_IsValid);
		SetRenderStatic_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRenderStatic");
		SetRenderStatic_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderStatic_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderStatic_bNewValue_PropertyAddress, SetRenderStatic_FunctionAddress, "bNewValue");
		SetRenderStatic_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderStatic_FunctionAddress, "bNewValue");
		SetRenderStatic_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderStatic_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetRenderStatic_IsValid = SetRenderStatic_FunctionAddress != IntPtr.Zero && SetRenderStatic_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetRenderStatic", SetRenderStatic_IsValid);
		SetPreSkinningOffsets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPreSkinningOffsets");
		SetPreSkinningOffsets_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPreSkinningOffsets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPreSkinningOffsets_LODIndex_PropertyAddress, SetPreSkinningOffsets_FunctionAddress, "LODIndex");
		SetPreSkinningOffsets_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetPreSkinningOffsets_FunctionAddress, "LODIndex");
		SetPreSkinningOffsets_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreSkinningOffsets_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPreSkinningOffsets_Offsets_PropertyAddress, SetPreSkinningOffsets_FunctionAddress, "Offsets");
		SetPreSkinningOffsets_Offsets_Offset = NativeReflectionCached.GetPropertyOffset(SetPreSkinningOffsets_FunctionAddress, "Offsets");
		SetPreSkinningOffsets_Offsets_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreSkinningOffsets_FunctionAddress, "Offsets", Classes.FArrayProperty);
		SetPreSkinningOffsets_IsValid = SetPreSkinningOffsets_FunctionAddress != IntPtr.Zero && SetPreSkinningOffsets_LODIndex_IsValid && SetPreSkinningOffsets_Offsets_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetPreSkinningOffsets", SetPreSkinningOffsets_IsValid);
		SetPostSkinningOffsets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPostSkinningOffsets");
		SetPostSkinningOffsets_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPostSkinningOffsets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPostSkinningOffsets_LODIndex_PropertyAddress, SetPostSkinningOffsets_FunctionAddress, "LODIndex");
		SetPostSkinningOffsets_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetPostSkinningOffsets_FunctionAddress, "LODIndex");
		SetPostSkinningOffsets_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPostSkinningOffsets_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPostSkinningOffsets_Offsets_PropertyAddress, SetPostSkinningOffsets_FunctionAddress, "Offsets");
		SetPostSkinningOffsets_Offsets_Offset = NativeReflectionCached.GetPropertyOffset(SetPostSkinningOffsets_FunctionAddress, "Offsets");
		SetPostSkinningOffsets_Offsets_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPostSkinningOffsets_FunctionAddress, "Offsets", Classes.FArrayProperty);
		SetPostSkinningOffsets_IsValid = SetPostSkinningOffsets_FunctionAddress != IntPtr.Zero && SetPostSkinningOffsets_LODIndex_IsValid && SetPostSkinningOffsets_Offsets_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetPostSkinningOffsets", SetPostSkinningOffsets_IsValid);
		SetPhysicsAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPhysicsAsset");
		SetPhysicsAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPhysicsAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsAsset_NewPhysicsAsset_PropertyAddress, SetPhysicsAsset_FunctionAddress, "NewPhysicsAsset");
		SetPhysicsAsset_NewPhysicsAsset_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsAsset_FunctionAddress, "NewPhysicsAsset");
		SetPhysicsAsset_NewPhysicsAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsAsset_FunctionAddress, "NewPhysicsAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPhysicsAsset_bForceReInit_PropertyAddress, SetPhysicsAsset_FunctionAddress, "bForceReInit");
		SetPhysicsAsset_bForceReInit_Offset = NativeReflectionCached.GetPropertyOffset(SetPhysicsAsset_FunctionAddress, "bForceReInit");
		SetPhysicsAsset_bForceReInit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPhysicsAsset_FunctionAddress, "bForceReInit", Classes.FBoolProperty);
		SetPhysicsAsset_IsValid = SetPhysicsAsset_FunctionAddress != IntPtr.Zero && SetPhysicsAsset_NewPhysicsAsset_IsValid && SetPhysicsAsset_bForceReInit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetPhysicsAsset", SetPhysicsAsset_IsValid);
		SetMinLOD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMinLOD");
		SetMinLOD_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinLOD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinLOD_InNewMinLOD_PropertyAddress, SetMinLOD_FunctionAddress, "InNewMinLOD");
		SetMinLOD_InNewMinLOD_Offset = NativeReflectionCached.GetPropertyOffset(SetMinLOD_FunctionAddress, "InNewMinLOD");
		SetMinLOD_InNewMinLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinLOD_FunctionAddress, "InNewMinLOD", Classes.FIntProperty);
		SetMinLOD_IsValid = SetMinLOD_FunctionAddress != IntPtr.Zero && SetMinLOD_InNewMinLOD_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetMinLOD", SetMinLOD_IsValid);
		SetMeshDeformer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMeshDeformer");
		SetMeshDeformer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMeshDeformer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMeshDeformer_InMeshDeformer_PropertyAddress, SetMeshDeformer_FunctionAddress, "InMeshDeformer");
		SetMeshDeformer_InMeshDeformer_Offset = NativeReflectionCached.GetPropertyOffset(SetMeshDeformer_FunctionAddress, "InMeshDeformer");
		SetMeshDeformer_InMeshDeformer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMeshDeformer_FunctionAddress, "InMeshDeformer", Classes.FObjectProperty);
		SetMeshDeformer_IsValid = SetMeshDeformer_FunctionAddress != IntPtr.Zero && SetMeshDeformer_InMeshDeformer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetMeshDeformer", SetMeshDeformer_IsValid);
		SetMasterPoseComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMasterPoseComponent");
		SetMasterPoseComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMasterPoseComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMasterPoseComponent_NewMasterBoneComponent_PropertyAddress, SetMasterPoseComponent_FunctionAddress, "NewMasterBoneComponent");
		SetMasterPoseComponent_NewMasterBoneComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetMasterPoseComponent_FunctionAddress, "NewMasterBoneComponent");
		SetMasterPoseComponent_NewMasterBoneComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMasterPoseComponent_FunctionAddress, "NewMasterBoneComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMasterPoseComponent_bForceUpdate_PropertyAddress, SetMasterPoseComponent_FunctionAddress, "bForceUpdate");
		SetMasterPoseComponent_bForceUpdate_Offset = NativeReflectionCached.GetPropertyOffset(SetMasterPoseComponent_FunctionAddress, "bForceUpdate");
		SetMasterPoseComponent_bForceUpdate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMasterPoseComponent_FunctionAddress, "bForceUpdate", Classes.FBoolProperty);
		SetMasterPoseComponent_IsValid = SetMasterPoseComponent_FunctionAddress != IntPtr.Zero && SetMasterPoseComponent_NewMasterBoneComponent_IsValid && SetMasterPoseComponent_bForceUpdate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetMasterPoseComponent", SetMasterPoseComponent_IsValid);
		SetForcedLOD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForcedLOD");
		SetForcedLOD_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForcedLOD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForcedLOD_InNewForcedLOD_PropertyAddress, SetForcedLOD_FunctionAddress, "InNewForcedLOD");
		SetForcedLOD_InNewForcedLOD_Offset = NativeReflectionCached.GetPropertyOffset(SetForcedLOD_FunctionAddress, "InNewForcedLOD");
		SetForcedLOD_InNewForcedLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForcedLOD_FunctionAddress, "InNewForcedLOD", Classes.FIntProperty);
		SetForcedLOD_IsValid = SetForcedLOD_FunctionAddress != IntPtr.Zero && SetForcedLOD_InNewForcedLOD_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetForcedLOD", SetForcedLOD_IsValid);
		SetCastCapsuleIndirectShadow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCastCapsuleIndirectShadow");
		SetCastCapsuleIndirectShadow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCastCapsuleIndirectShadow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCastCapsuleIndirectShadow_bNewValue_PropertyAddress, SetCastCapsuleIndirectShadow_FunctionAddress, "bNewValue");
		SetCastCapsuleIndirectShadow_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCastCapsuleIndirectShadow_FunctionAddress, "bNewValue");
		SetCastCapsuleIndirectShadow_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCastCapsuleIndirectShadow_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetCastCapsuleIndirectShadow_IsValid = SetCastCapsuleIndirectShadow_FunctionAddress != IntPtr.Zero && SetCastCapsuleIndirectShadow_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetCastCapsuleIndirectShadow", SetCastCapsuleIndirectShadow_IsValid);
		SetCastCapsuleDirectShadow_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCastCapsuleDirectShadow");
		SetCastCapsuleDirectShadow_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCastCapsuleDirectShadow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCastCapsuleDirectShadow_bNewValue_PropertyAddress, SetCastCapsuleDirectShadow_FunctionAddress, "bNewValue");
		SetCastCapsuleDirectShadow_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCastCapsuleDirectShadow_FunctionAddress, "bNewValue");
		SetCastCapsuleDirectShadow_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCastCapsuleDirectShadow_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetCastCapsuleDirectShadow_IsValid = SetCastCapsuleDirectShadow_FunctionAddress != IntPtr.Zero && SetCastCapsuleDirectShadow_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetCastCapsuleDirectShadow", SetCastCapsuleDirectShadow_IsValid);
		SetCapsuleIndirectShadowMinVisibility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCapsuleIndirectShadowMinVisibility");
		SetCapsuleIndirectShadowMinVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCapsuleIndirectShadowMinVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCapsuleIndirectShadowMinVisibility_NewValue_PropertyAddress, SetCapsuleIndirectShadowMinVisibility_FunctionAddress, "NewValue");
		SetCapsuleIndirectShadowMinVisibility_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCapsuleIndirectShadowMinVisibility_FunctionAddress, "NewValue");
		SetCapsuleIndirectShadowMinVisibility_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCapsuleIndirectShadowMinVisibility_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetCapsuleIndirectShadowMinVisibility_IsValid = SetCapsuleIndirectShadowMinVisibility_FunctionAddress != IntPtr.Zero && SetCapsuleIndirectShadowMinVisibility_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:SetCapsuleIndirectShadowMinVisibility", SetCapsuleIndirectShadowMinVisibility_IsValid);
		IsUsingSkinWeightProfile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsUsingSkinWeightProfile");
		IsUsingSkinWeightProfile_ParamsSize = NativeReflection.GetFunctionParamsSize(IsUsingSkinWeightProfile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsUsingSkinWeightProfile_ReturnValue_PropertyAddress, IsUsingSkinWeightProfile_FunctionAddress, "ReturnValue");
		IsUsingSkinWeightProfile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsUsingSkinWeightProfile_FunctionAddress, "ReturnValue");
		IsUsingSkinWeightProfile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsUsingSkinWeightProfile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsUsingSkinWeightProfile_IsValid = IsUsingSkinWeightProfile_FunctionAddress != IntPtr.Zero && IsUsingSkinWeightProfile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:IsUsingSkinWeightProfile", IsUsingSkinWeightProfile_IsValid);
		IsMaterialSectionShown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsMaterialSectionShown");
		IsMaterialSectionShown_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMaterialSectionShown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMaterialSectionShown_MaterialID_PropertyAddress, IsMaterialSectionShown_FunctionAddress, "MaterialID");
		IsMaterialSectionShown_MaterialID_Offset = NativeReflectionCached.GetPropertyOffset(IsMaterialSectionShown_FunctionAddress, "MaterialID");
		IsMaterialSectionShown_MaterialID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMaterialSectionShown_FunctionAddress, "MaterialID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsMaterialSectionShown_LODIndex_PropertyAddress, IsMaterialSectionShown_FunctionAddress, "LODIndex");
		IsMaterialSectionShown_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(IsMaterialSectionShown_FunctionAddress, "LODIndex");
		IsMaterialSectionShown_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMaterialSectionShown_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsMaterialSectionShown_ReturnValue_PropertyAddress, IsMaterialSectionShown_FunctionAddress, "ReturnValue");
		IsMaterialSectionShown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMaterialSectionShown_FunctionAddress, "ReturnValue");
		IsMaterialSectionShown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMaterialSectionShown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMaterialSectionShown_IsValid = IsMaterialSectionShown_FunctionAddress != IntPtr.Zero && IsMaterialSectionShown_MaterialID_IsValid && IsMaterialSectionShown_LODIndex_IsValid && IsMaterialSectionShown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:IsMaterialSectionShown", IsMaterialSectionShown_IsValid);
		IsBoneHiddenByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsBoneHiddenByName");
		IsBoneHiddenByName_ParamsSize = NativeReflection.GetFunctionParamsSize(IsBoneHiddenByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsBoneHiddenByName_BoneName_PropertyAddress, IsBoneHiddenByName_FunctionAddress, "BoneName");
		IsBoneHiddenByName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(IsBoneHiddenByName_FunctionAddress, "BoneName");
		IsBoneHiddenByName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBoneHiddenByName_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsBoneHiddenByName_ReturnValue_PropertyAddress, IsBoneHiddenByName_FunctionAddress, "ReturnValue");
		IsBoneHiddenByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsBoneHiddenByName_FunctionAddress, "ReturnValue");
		IsBoneHiddenByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBoneHiddenByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsBoneHiddenByName_IsValid = IsBoneHiddenByName_FunctionAddress != IntPtr.Zero && IsBoneHiddenByName_BoneName_IsValid && IsBoneHiddenByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:IsBoneHiddenByName", IsBoneHiddenByName_IsValid);
		HideBoneByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HideBoneByName");
		HideBoneByName_ParamsSize = NativeReflection.GetFunctionParamsSize(HideBoneByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HideBoneByName_BoneName_PropertyAddress, HideBoneByName_FunctionAddress, "BoneName");
		HideBoneByName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(HideBoneByName_FunctionAddress, "BoneName");
		HideBoneByName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(HideBoneByName_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref HideBoneByName_PhysBodyOption_PropertyAddress, HideBoneByName_FunctionAddress, "PhysBodyOption");
		HideBoneByName_PhysBodyOption_Offset = NativeReflectionCached.GetPropertyOffset(HideBoneByName_FunctionAddress, "PhysBodyOption");
		HideBoneByName_PhysBodyOption_IsValid = NativeReflectionCached.ValidatePropertyClass(HideBoneByName_FunctionAddress, "PhysBodyOption", Classes.FByteProperty);
		HideBoneByName_IsValid = HideBoneByName_FunctionAddress != IntPtr.Zero && HideBoneByName_BoneName_IsValid && HideBoneByName_PhysBodyOption_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:HideBoneByName", HideBoneByName_IsValid);
		GetVertexOffsetUsage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetVertexOffsetUsage");
		GetVertexOffsetUsage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVertexOffsetUsage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVertexOffsetUsage_LODIndex_PropertyAddress, GetVertexOffsetUsage_FunctionAddress, "LODIndex");
		GetVertexOffsetUsage_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexOffsetUsage_FunctionAddress, "LODIndex");
		GetVertexOffsetUsage_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexOffsetUsage_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVertexOffsetUsage_ReturnValue_PropertyAddress, GetVertexOffsetUsage_FunctionAddress, "ReturnValue");
		GetVertexOffsetUsage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVertexOffsetUsage_FunctionAddress, "ReturnValue");
		GetVertexOffsetUsage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVertexOffsetUsage_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetVertexOffsetUsage_IsValid = GetVertexOffsetUsage_FunctionAddress != IntPtr.Zero && GetVertexOffsetUsage_LODIndex_IsValid && GetVertexOffsetUsage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:GetVertexOffsetUsage", GetVertexOffsetUsage_IsValid);
		GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTwistAndSwingAngleOfDeltaRotationFromRefPose");
		GetTwistAndSwingAngleOfDeltaRotationFromRefPose_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTwistAndSwingAngleOfDeltaRotationFromRefPose_BoneName_PropertyAddress, GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress, "BoneName");
		GetTwistAndSwingAngleOfDeltaRotationFromRefPose_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress, "BoneName");
		GetTwistAndSwingAngleOfDeltaRotationFromRefPose_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutTwistAngle_PropertyAddress, GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress, "OutTwistAngle");
		GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutTwistAngle_Offset = NativeReflectionCached.GetPropertyOffset(GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress, "OutTwistAngle");
		GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutTwistAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress, "OutTwistAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutSwingAngle_PropertyAddress, GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress, "OutSwingAngle");
		GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutSwingAngle_Offset = NativeReflectionCached.GetPropertyOffset(GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress, "OutSwingAngle");
		GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutSwingAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress, "OutSwingAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTwistAndSwingAngleOfDeltaRotationFromRefPose_ReturnValue_PropertyAddress, GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress, "ReturnValue");
		GetTwistAndSwingAngleOfDeltaRotationFromRefPose_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress, "ReturnValue");
		GetTwistAndSwingAngleOfDeltaRotationFromRefPose_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetTwistAndSwingAngleOfDeltaRotationFromRefPose_IsValid = GetTwistAndSwingAngleOfDeltaRotationFromRefPose_FunctionAddress != IntPtr.Zero && GetTwistAndSwingAngleOfDeltaRotationFromRefPose_BoneName_IsValid && GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutTwistAngle_IsValid && GetTwistAndSwingAngleOfDeltaRotationFromRefPose_OutSwingAngle_IsValid && GetTwistAndSwingAngleOfDeltaRotationFromRefPose_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:GetTwistAndSwingAngleOfDeltaRotationFromRefPose", GetTwistAndSwingAngleOfDeltaRotationFromRefPose_IsValid);
		GetSocketBoneName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSocketBoneName");
		GetSocketBoneName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSocketBoneName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSocketBoneName_InSocketName_PropertyAddress, GetSocketBoneName_FunctionAddress, "InSocketName");
		GetSocketBoneName_InSocketName_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketBoneName_FunctionAddress, "InSocketName");
		GetSocketBoneName_InSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketBoneName_FunctionAddress, "InSocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSocketBoneName_ReturnValue_PropertyAddress, GetSocketBoneName_FunctionAddress, "ReturnValue");
		GetSocketBoneName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketBoneName_FunctionAddress, "ReturnValue");
		GetSocketBoneName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketBoneName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetSocketBoneName_IsValid = GetSocketBoneName_FunctionAddress != IntPtr.Zero && GetSocketBoneName_InSocketName_IsValid && GetSocketBoneName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:GetSocketBoneName", GetSocketBoneName_IsValid);
		GetRefPoseTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRefPoseTransform");
		GetRefPoseTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRefPoseTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRefPoseTransform_BoneIndex_PropertyAddress, GetRefPoseTransform_FunctionAddress, "BoneIndex");
		GetRefPoseTransform_BoneIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetRefPoseTransform_FunctionAddress, "BoneIndex");
		GetRefPoseTransform_BoneIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefPoseTransform_FunctionAddress, "BoneIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRefPoseTransform_ReturnValue_PropertyAddress, GetRefPoseTransform_FunctionAddress, "ReturnValue");
		GetRefPoseTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRefPoseTransform_FunctionAddress, "ReturnValue");
		GetRefPoseTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefPoseTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRefPoseTransform_IsValid = GetRefPoseTransform_FunctionAddress != IntPtr.Zero && GetRefPoseTransform_BoneIndex_IsValid && GetRefPoseTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:GetRefPoseTransform", GetRefPoseTransform_IsValid);
		GetRefPosePosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRefPosePosition");
		GetRefPosePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRefPosePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRefPosePosition_BoneIndex_PropertyAddress, GetRefPosePosition_FunctionAddress, "BoneIndex");
		GetRefPosePosition_BoneIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetRefPosePosition_FunctionAddress, "BoneIndex");
		GetRefPosePosition_BoneIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefPosePosition_FunctionAddress, "BoneIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRefPosePosition_ReturnValue_PropertyAddress, GetRefPosePosition_FunctionAddress, "ReturnValue");
		GetRefPosePosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRefPosePosition_FunctionAddress, "ReturnValue");
		GetRefPosePosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefPosePosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRefPosePosition_IsValid = GetRefPosePosition_FunctionAddress != IntPtr.Zero && GetRefPosePosition_BoneIndex_IsValid && GetRefPosePosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:GetRefPosePosition", GetRefPosePosition_IsValid);
		GetParentBone_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetParentBone");
		GetParentBone_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentBone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentBone_BoneName_PropertyAddress, GetParentBone_FunctionAddress, "BoneName");
		GetParentBone_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetParentBone_FunctionAddress, "BoneName");
		GetParentBone_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentBone_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentBone_ReturnValue_PropertyAddress, GetParentBone_FunctionAddress, "ReturnValue");
		GetParentBone_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentBone_FunctionAddress, "ReturnValue");
		GetParentBone_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentBone_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetParentBone_IsValid = GetParentBone_FunctionAddress != IntPtr.Zero && GetParentBone_BoneName_IsValid && GetParentBone_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:GetParentBone", GetParentBone_IsValid);
		GetNumLODs_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumLODs");
		GetNumLODs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumLODs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumLODs_ReturnValue_PropertyAddress, GetNumLODs_FunctionAddress, "ReturnValue");
		GetNumLODs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumLODs_FunctionAddress, "ReturnValue");
		GetNumLODs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumLODs_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumLODs_IsValid = GetNumLODs_FunctionAddress != IntPtr.Zero && GetNumLODs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:GetNumLODs", GetNumLODs_IsValid);
		GetNumBones_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumBones");
		GetNumBones_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumBones_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumBones_ReturnValue_PropertyAddress, GetNumBones_FunctionAddress, "ReturnValue");
		GetNumBones_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumBones_FunctionAddress, "ReturnValue");
		GetNumBones_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumBones_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumBones_IsValid = GetNumBones_FunctionAddress != IntPtr.Zero && GetNumBones_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:GetNumBones", GetNumBones_IsValid);
		GetForcedLOD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetForcedLOD");
		GetForcedLOD_ParamsSize = NativeReflection.GetFunctionParamsSize(GetForcedLOD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetForcedLOD_ReturnValue_PropertyAddress, GetForcedLOD_FunctionAddress, "ReturnValue");
		GetForcedLOD_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetForcedLOD_FunctionAddress, "ReturnValue");
		GetForcedLOD_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetForcedLOD_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetForcedLOD_IsValid = GetForcedLOD_FunctionAddress != IntPtr.Zero && GetForcedLOD_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:GetForcedLOD", GetForcedLOD_IsValid);
		GetDeltaTransformFromRefPose_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDeltaTransformFromRefPose");
		GetDeltaTransformFromRefPose_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDeltaTransformFromRefPose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDeltaTransformFromRefPose_BoneName_PropertyAddress, GetDeltaTransformFromRefPose_FunctionAddress, "BoneName");
		GetDeltaTransformFromRefPose_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetDeltaTransformFromRefPose_FunctionAddress, "BoneName");
		GetDeltaTransformFromRefPose_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDeltaTransformFromRefPose_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDeltaTransformFromRefPose_BaseName_PropertyAddress, GetDeltaTransformFromRefPose_FunctionAddress, "BaseName");
		GetDeltaTransformFromRefPose_BaseName_Offset = NativeReflectionCached.GetPropertyOffset(GetDeltaTransformFromRefPose_FunctionAddress, "BaseName");
		GetDeltaTransformFromRefPose_BaseName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDeltaTransformFromRefPose_FunctionAddress, "BaseName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDeltaTransformFromRefPose_ReturnValue_PropertyAddress, GetDeltaTransformFromRefPose_FunctionAddress, "ReturnValue");
		GetDeltaTransformFromRefPose_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDeltaTransformFromRefPose_FunctionAddress, "ReturnValue");
		GetDeltaTransformFromRefPose_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDeltaTransformFromRefPose_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDeltaTransformFromRefPose_IsValid = GetDeltaTransformFromRefPose_FunctionAddress != IntPtr.Zero && GetDeltaTransformFromRefPose_BoneName_IsValid && GetDeltaTransformFromRefPose_BaseName_IsValid && GetDeltaTransformFromRefPose_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:GetDeltaTransformFromRefPose", GetDeltaTransformFromRefPose_IsValid);
		GetCurrentSkinWeightProfileName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentSkinWeightProfileName");
		GetCurrentSkinWeightProfileName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentSkinWeightProfileName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentSkinWeightProfileName_ReturnValue_PropertyAddress, GetCurrentSkinWeightProfileName_FunctionAddress, "ReturnValue");
		GetCurrentSkinWeightProfileName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentSkinWeightProfileName_FunctionAddress, "ReturnValue");
		GetCurrentSkinWeightProfileName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentSkinWeightProfileName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetCurrentSkinWeightProfileName_IsValid = GetCurrentSkinWeightProfileName_FunctionAddress != IntPtr.Zero && GetCurrentSkinWeightProfileName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:GetCurrentSkinWeightProfileName", GetCurrentSkinWeightProfileName_IsValid);
		GetBoneName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoneName");
		GetBoneName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneName_BoneIndex_PropertyAddress, GetBoneName_FunctionAddress, "BoneIndex");
		GetBoneName_BoneIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneName_FunctionAddress, "BoneIndex");
		GetBoneName_BoneIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneName_FunctionAddress, "BoneIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneName_ReturnValue_PropertyAddress, GetBoneName_FunctionAddress, "ReturnValue");
		GetBoneName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneName_FunctionAddress, "ReturnValue");
		GetBoneName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetBoneName_IsValid = GetBoneName_FunctionAddress != IntPtr.Zero && GetBoneName_BoneIndex_IsValid && GetBoneName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:GetBoneName", GetBoneName_IsValid);
		GetBoneIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoneIndex");
		GetBoneIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneIndex_BoneName_PropertyAddress, GetBoneIndex_FunctionAddress, "BoneName");
		GetBoneIndex_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneIndex_FunctionAddress, "BoneName");
		GetBoneIndex_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneIndex_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneIndex_ReturnValue_PropertyAddress, GetBoneIndex_FunctionAddress, "ReturnValue");
		GetBoneIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneIndex_FunctionAddress, "ReturnValue");
		GetBoneIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetBoneIndex_IsValid = GetBoneIndex_FunctionAddress != IntPtr.Zero && GetBoneIndex_BoneName_IsValid && GetBoneIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:GetBoneIndex", GetBoneIndex_IsValid);
		FindClosestBone_K2_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindClosestBone_K2");
		FindClosestBone_K2_ParamsSize = NativeReflection.GetFunctionParamsSize(FindClosestBone_K2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindClosestBone_K2_TestLocation_PropertyAddress, FindClosestBone_K2_FunctionAddress, "TestLocation");
		FindClosestBone_K2_TestLocation_Offset = NativeReflectionCached.GetPropertyOffset(FindClosestBone_K2_FunctionAddress, "TestLocation");
		FindClosestBone_K2_TestLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindClosestBone_K2_FunctionAddress, "TestLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindClosestBone_K2_BoneLocation_PropertyAddress, FindClosestBone_K2_FunctionAddress, "BoneLocation");
		FindClosestBone_K2_BoneLocation_Offset = NativeReflectionCached.GetPropertyOffset(FindClosestBone_K2_FunctionAddress, "BoneLocation");
		FindClosestBone_K2_BoneLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindClosestBone_K2_FunctionAddress, "BoneLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindClosestBone_K2_IgnoreScale_PropertyAddress, FindClosestBone_K2_FunctionAddress, "IgnoreScale");
		FindClosestBone_K2_IgnoreScale_Offset = NativeReflectionCached.GetPropertyOffset(FindClosestBone_K2_FunctionAddress, "IgnoreScale");
		FindClosestBone_K2_IgnoreScale_IsValid = NativeReflectionCached.ValidatePropertyClass(FindClosestBone_K2_FunctionAddress, "IgnoreScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FindClosestBone_K2_bRequirePhysicsAsset_PropertyAddress, FindClosestBone_K2_FunctionAddress, "bRequirePhysicsAsset");
		FindClosestBone_K2_bRequirePhysicsAsset_Offset = NativeReflectionCached.GetPropertyOffset(FindClosestBone_K2_FunctionAddress, "bRequirePhysicsAsset");
		FindClosestBone_K2_bRequirePhysicsAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(FindClosestBone_K2_FunctionAddress, "bRequirePhysicsAsset", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FindClosestBone_K2_ReturnValue_PropertyAddress, FindClosestBone_K2_FunctionAddress, "ReturnValue");
		FindClosestBone_K2_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindClosestBone_K2_FunctionAddress, "ReturnValue");
		FindClosestBone_K2_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindClosestBone_K2_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		FindClosestBone_K2_IsValid = FindClosestBone_K2_FunctionAddress != IntPtr.Zero && FindClosestBone_K2_TestLocation_IsValid && FindClosestBone_K2_BoneLocation_IsValid && FindClosestBone_K2_IgnoreScale_IsValid && FindClosestBone_K2_bRequirePhysicsAsset_IsValid && FindClosestBone_K2_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:FindClosestBone_K2", FindClosestBone_K2_IsValid);
		ClearVertexColorOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearVertexColorOverride");
		ClearVertexColorOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearVertexColorOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearVertexColorOverride_LODIndex_PropertyAddress, ClearVertexColorOverride_FunctionAddress, "LODIndex");
		ClearVertexColorOverride_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(ClearVertexColorOverride_FunctionAddress, "LODIndex");
		ClearVertexColorOverride_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearVertexColorOverride_FunctionAddress, "LODIndex", Classes.FIntProperty);
		ClearVertexColorOverride_IsValid = ClearVertexColorOverride_FunctionAddress != IntPtr.Zero && ClearVertexColorOverride_LODIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:ClearVertexColorOverride", ClearVertexColorOverride_IsValid);
		ClearSkinWeightProfile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearSkinWeightProfile");
		ClearSkinWeightProfile_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSkinWeightProfile_FunctionAddress);
		ClearSkinWeightProfile_IsValid = ClearSkinWeightProfile_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:ClearSkinWeightProfile", ClearSkinWeightProfile_IsValid);
		ClearSkinWeightOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearSkinWeightOverride");
		ClearSkinWeightOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSkinWeightOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearSkinWeightOverride_LODIndex_PropertyAddress, ClearSkinWeightOverride_FunctionAddress, "LODIndex");
		ClearSkinWeightOverride_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(ClearSkinWeightOverride_FunctionAddress, "LODIndex");
		ClearSkinWeightOverride_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearSkinWeightOverride_FunctionAddress, "LODIndex", Classes.FIntProperty);
		ClearSkinWeightOverride_IsValid = ClearSkinWeightOverride_FunctionAddress != IntPtr.Zero && ClearSkinWeightOverride_LODIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:ClearSkinWeightOverride", ClearSkinWeightOverride_IsValid);
		BoneIsChildOf_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BoneIsChildOf");
		BoneIsChildOf_ParamsSize = NativeReflection.GetFunctionParamsSize(BoneIsChildOf_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BoneIsChildOf_BoneName_PropertyAddress, BoneIsChildOf_FunctionAddress, "BoneName");
		BoneIsChildOf_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(BoneIsChildOf_FunctionAddress, "BoneName");
		BoneIsChildOf_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(BoneIsChildOf_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BoneIsChildOf_ParentBoneName_PropertyAddress, BoneIsChildOf_FunctionAddress, "ParentBoneName");
		BoneIsChildOf_ParentBoneName_Offset = NativeReflectionCached.GetPropertyOffset(BoneIsChildOf_FunctionAddress, "ParentBoneName");
		BoneIsChildOf_ParentBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(BoneIsChildOf_FunctionAddress, "ParentBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BoneIsChildOf_ReturnValue_PropertyAddress, BoneIsChildOf_FunctionAddress, "ReturnValue");
		BoneIsChildOf_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BoneIsChildOf_FunctionAddress, "ReturnValue");
		BoneIsChildOf_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BoneIsChildOf_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BoneIsChildOf_IsValid = BoneIsChildOf_FunctionAddress != IntPtr.Zero && BoneIsChildOf_BoneName_IsValid && BoneIsChildOf_ParentBoneName_IsValid && BoneIsChildOf_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkinnedMeshComponent:BoneIsChildOf", BoneIsChildOf_IsValid);
	}
}
