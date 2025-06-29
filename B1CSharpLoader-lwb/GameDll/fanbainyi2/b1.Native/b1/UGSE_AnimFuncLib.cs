using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.ApexDestruction;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_AnimFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TickAnimationAndRefreshBone_SkeletalMesh_IsValid;

	private static IntPtr TickAnimationAndRefreshBone_SkeletalMesh_FunctionAddress;

	private static int TickAnimationAndRefreshBone_SkeletalMesh_ParamsSize;

	private static bool TickAnimationAndRefreshBone_SkeletalMesh_SkeletalMeshComp_IsValid;

	private static FFieldAddress TickAnimationAndRefreshBone_SkeletalMesh_SkeletalMeshComp_PropertyAddress;

	private static int TickAnimationAndRefreshBone_SkeletalMesh_SkeletalMeshComp_Offset;

	private static bool TickAnimationAndRefreshBone_IsValid;

	private static IntPtr TickAnimationAndRefreshBone_FunctionAddress;

	private static int TickAnimationAndRefreshBone_ParamsSize;

	private static bool TickAnimationAndRefreshBone_Owner_IsValid;

	private static FFieldAddress TickAnimationAndRefreshBone_Owner_PropertyAddress;

	private static int TickAnimationAndRefreshBone_Owner_Offset;

	private static bool TickAnimation_IsValid;

	private static IntPtr TickAnimation_FunctionAddress;

	private static int TickAnimation_ParamsSize;

	private static bool TickAnimation_Owner_IsValid;

	private static FFieldAddress TickAnimation_Owner_PropertyAddress;

	private static int TickAnimation_Owner_Offset;

	private static bool StopAllMontages_IsValid;

	private static IntPtr StopAllMontages_FunctionAddress;

	private static int StopAllMontages_ParamsSize;

	private static bool StopAllMontages_Owner_IsValid;

	private static FFieldAddress StopAllMontages_Owner_PropertyAddress;

	private static int StopAllMontages_Owner_Offset;

	private static bool StopAllMontages_BlendOutTime_IsValid;

	private static FFieldAddress StopAllMontages_BlendOutTime_PropertyAddress;

	private static int StopAllMontages_BlendOutTime_Offset;

	private static bool SkeletonCopySockets_IsValid;

	private static IntPtr SkeletonCopySockets_FunctionAddress;

	private static int SkeletonCopySockets_ParamsSize;

	private static bool SkeletonCopySockets_SourceSkeletal_IsValid;

	private static FFieldAddress SkeletonCopySockets_SourceSkeletal_PropertyAddress;

	private static int SkeletonCopySockets_SourceSkeletal_Offset;

	private static bool SkeletonCopySockets_DestSkeletal_IsValid;

	private static FFieldAddress SkeletonCopySockets_DestSkeletal_PropertyAddress;

	private static int SkeletonCopySockets_DestSkeletal_Offset;

	private static bool SkeletonCopySockets_LocationScaleRate_IsValid;

	private static FFieldAddress SkeletonCopySockets_LocationScaleRate_PropertyAddress;

	private static int SkeletonCopySockets_LocationScaleRate_Offset;

	private static bool SkeletonCopySockets_ReturnValue_IsValid;

	private static FFieldAddress SkeletonCopySockets_ReturnValue_PropertyAddress;

	private static int SkeletonCopySockets_ReturnValue_Offset;

	private static bool SetUV_IsValid;

	private static IntPtr SetUV_FunctionAddress;

	private static int SetUV_ParamsSize;

	private static bool SetUV_StaticMesh_IsValid;

	private static FFieldAddress SetUV_StaticMesh_PropertyAddress;

	private static int SetUV_StaticMesh_Offset;

	private static bool SetUV_LODIndex_IsValid;

	private static FFieldAddress SetUV_LODIndex_PropertyAddress;

	private static int SetUV_LODIndex_Offset;

	private static bool SetUV_UVChannelIndex_IsValid;

	private static FFieldAddress SetUV_UVChannelIndex_PropertyAddress;

	private static int SetUV_UVChannelIndex_Offset;

	private static bool SetUV_BoneWeight_IsValid;

	private static FFieldAddress SetUV_BoneWeight_PropertyAddress;

	private static int SetUV_BoneWeight_Offset;

	private static bool SetUV_ReturnValue_IsValid;

	private static FFieldAddress SetUV_ReturnValue_PropertyAddress;

	private static int SetUV_ReturnValue_Offset;

	private static bool SetRootMotionFromEverythingSwitch_IsValid;

	private static IntPtr SetRootMotionFromEverythingSwitch_FunctionAddress;

	private static int SetRootMotionFromEverythingSwitch_ParamsSize;

	private static bool SetRootMotionFromEverythingSwitch_Character_IsValid;

	private static FFieldAddress SetRootMotionFromEverythingSwitch_Character_PropertyAddress;

	private static int SetRootMotionFromEverythingSwitch_Character_Offset;

	private static bool SetRootMotionFromEverythingSwitch_IsOpen_IsValid;

	private static FFieldAddress SetRootMotionFromEverythingSwitch_IsOpen_PropertyAddress;

	private static int SetRootMotionFromEverythingSwitch_IsOpen_Offset;

	private static bool SetMaterial_IsValid;

	private static IntPtr SetMaterial_FunctionAddress;

	private static int SetMaterial_ParamsSize;

	private static bool SetMaterial_Material_IsValid;

	private static FFieldAddress SetMaterial_Material_PropertyAddress;

	private static int SetMaterial_Material_Offset;

	private static bool SetMaterial_TargetMesh_IsValid;

	private static FFieldAddress SetMaterial_TargetMesh_PropertyAddress;

	private static int SetMaterial_TargetMesh_Offset;

	private static bool SetMaterial_Index_IsValid;

	private static FFieldAddress SetMaterial_Index_PropertyAddress;

	private static int SetMaterial_Index_Offset;

	private static bool SetBlendSpaceInput_IsValid;

	private static IntPtr SetBlendSpaceInput_FunctionAddress;

	private static int SetBlendSpaceInput_ParamsSize;

	private static bool SetBlendSpaceInput_obj_IsValid;

	private static FFieldAddress SetBlendSpaceInput_obj_PropertyAddress;

	private static int SetBlendSpaceInput_obj_Offset;

	private static bool SetBlendSpaceInput_BlendParams_IsValid;

	private static FFieldAddress SetBlendSpaceInput_BlendParams_PropertyAddress;

	private static int SetBlendSpaceInput_BlendParams_Offset;

	private static bool SetAnimcurveType_IsValid;

	private static IntPtr SetAnimcurveType_FunctionAddress;

	private static int SetAnimcurveType_ParamsSize;

	private static bool SetAnimcurveType_Skeleton_IsValid;

	private static FFieldAddress SetAnimcurveType_Skeleton_PropertyAddress;

	private static int SetAnimcurveType_Skeleton_Offset;

	private static bool SetAnimcurveType_CurveName_IsValid;

	private static FFieldAddress SetAnimcurveType_CurveName_PropertyAddress;

	private static int SetAnimcurveType_CurveName_Offset;

	private static bool SetAnimcurveType_Value_IsValid;

	private static FFieldAddress SetAnimcurveType_Value_PropertyAddress;

	private static int SetAnimcurveType_Value_Offset;

	private static bool SetAnimcurveType_ReturnValue_IsValid;

	private static FFieldAddress SetAnimcurveType_ReturnValue_PropertyAddress;

	private static int SetAnimcurveType_ReturnValue_Offset;

	private static bool SetAnimationNotifyStartTime_IsValid;

	private static IntPtr SetAnimationNotifyStartTime_FunctionAddress;

	private static int SetAnimationNotifyStartTime_ParamsSize;

	private static bool SetAnimationNotifyStartTime_InAnimMontage_IsValid;

	private static FFieldAddress SetAnimationNotifyStartTime_InAnimMontage_PropertyAddress;

	private static int SetAnimationNotifyStartTime_InAnimMontage_Offset;

	private static bool SetAnimationNotifyStartTime_InGuid_IsValid;

	private static FFieldAddress SetAnimationNotifyStartTime_InGuid_PropertyAddress;

	private static int SetAnimationNotifyStartTime_InGuid_Offset;

	private static bool SetAnimationNotifyStartTime_StartTime_IsValid;

	private static FFieldAddress SetAnimationNotifyStartTime_StartTime_PropertyAddress;

	private static int SetAnimationNotifyStartTime_StartTime_Offset;

	private static bool SetAnimationNotifyStartTime_ReturnValue_IsValid;

	private static FFieldAddress SetAnimationNotifyStartTime_ReturnValue_PropertyAddress;

	private static int SetAnimationNotifyStartTime_ReturnValue_Offset;

	private static bool SetAnimationNotifyDuration_IsValid;

	private static IntPtr SetAnimationNotifyDuration_FunctionAddress;

	private static int SetAnimationNotifyDuration_ParamsSize;

	private static bool SetAnimationNotifyDuration_InAnimMontage_IsValid;

	private static FFieldAddress SetAnimationNotifyDuration_InAnimMontage_PropertyAddress;

	private static int SetAnimationNotifyDuration_InAnimMontage_Offset;

	private static bool SetAnimationNotifyDuration_InGuid_IsValid;

	private static FFieldAddress SetAnimationNotifyDuration_InGuid_PropertyAddress;

	private static int SetAnimationNotifyDuration_InGuid_Offset;

	private static bool SetAnimationNotifyDuration_Duration_IsValid;

	private static FFieldAddress SetAnimationNotifyDuration_Duration_PropertyAddress;

	private static int SetAnimationNotifyDuration_Duration_Offset;

	private static bool SetAnimationNotifyDuration_ReturnValue_IsValid;

	private static FFieldAddress SetAnimationNotifyDuration_ReturnValue_PropertyAddress;

	private static int SetAnimationNotifyDuration_ReturnValue_Offset;

	private static bool Sequence_GetRelativeBoneTransformCS_IsValid;

	private static IntPtr Sequence_GetRelativeBoneTransformCS_FunctionAddress;

	private static int Sequence_GetRelativeBoneTransformCS_ParamsSize;

	private static bool Sequence_GetRelativeBoneTransformCS_AnimSeq_IsValid;

	private static FFieldAddress Sequence_GetRelativeBoneTransformCS_AnimSeq_PropertyAddress;

	private static int Sequence_GetRelativeBoneTransformCS_AnimSeq_Offset;

	private static bool Sequence_GetRelativeBoneTransformCS_InTime_IsValid;

	private static FFieldAddress Sequence_GetRelativeBoneTransformCS_InTime_PropertyAddress;

	private static int Sequence_GetRelativeBoneTransformCS_InTime_Offset;

	private static bool Sequence_GetRelativeBoneTransformCS_BoneName_IsValid;

	private static FFieldAddress Sequence_GetRelativeBoneTransformCS_BoneName_PropertyAddress;

	private static int Sequence_GetRelativeBoneTransformCS_BoneName_Offset;

	private static bool Sequence_GetRelativeBoneTransformCS_bExtractRootMotion_IsValid;

	private static FFieldAddress Sequence_GetRelativeBoneTransformCS_bExtractRootMotion_PropertyAddress;

	private static int Sequence_GetRelativeBoneTransformCS_bExtractRootMotion_Offset;

	private static bool Sequence_GetRelativeBoneTransformCS_ReturnValue_IsValid;

	private static FFieldAddress Sequence_GetRelativeBoneTransformCS_ReturnValue_PropertyAddress;

	private static int Sequence_GetRelativeBoneTransformCS_ReturnValue_Offset;

	private static bool Sequence_GetBoneTransformCS_IsValid;

	private static IntPtr Sequence_GetBoneTransformCS_FunctionAddress;

	private static int Sequence_GetBoneTransformCS_ParamsSize;

	private static bool Sequence_GetBoneTransformCS_AnimSeq_IsValid;

	private static FFieldAddress Sequence_GetBoneTransformCS_AnimSeq_PropertyAddress;

	private static int Sequence_GetBoneTransformCS_AnimSeq_Offset;

	private static bool Sequence_GetBoneTransformCS_InTime_IsValid;

	private static FFieldAddress Sequence_GetBoneTransformCS_InTime_PropertyAddress;

	private static int Sequence_GetBoneTransformCS_InTime_Offset;

	private static bool Sequence_GetBoneTransformCS_BoneName_IsValid;

	private static FFieldAddress Sequence_GetBoneTransformCS_BoneName_PropertyAddress;

	private static int Sequence_GetBoneTransformCS_BoneName_Offset;

	private static bool Sequence_GetBoneTransformCS_bExtractRootMotion_IsValid;

	private static FFieldAddress Sequence_GetBoneTransformCS_bExtractRootMotion_PropertyAddress;

	private static int Sequence_GetBoneTransformCS_bExtractRootMotion_Offset;

	private static bool Sequence_GetBoneTransformCS_ReturnValue_IsValid;

	private static FFieldAddress Sequence_GetBoneTransformCS_ReturnValue_PropertyAddress;

	private static int Sequence_GetBoneTransformCS_ReturnValue_Offset;

	private static bool RemovePreviewAssetFromSkeleton_IsValid;

	private static IntPtr RemovePreviewAssetFromSkeleton_FunctionAddress;

	private static int RemovePreviewAssetFromSkeleton_ParamsSize;

	private static bool RemovePreviewAssetFromSkeleton_InUSkeleton_IsValid;

	private static FFieldAddress RemovePreviewAssetFromSkeleton_InUSkeleton_PropertyAddress;

	private static int RemovePreviewAssetFromSkeleton_InUSkeleton_Offset;

	private static bool RemovePreviewAssetFromSkeleton_BoneName_IsValid;

	private static FFieldAddress RemovePreviewAssetFromSkeleton_BoneName_PropertyAddress;

	private static int RemovePreviewAssetFromSkeleton_BoneName_Offset;

	private static bool RemovePreviewAssetFromSkeleton_ReturnValue_IsValid;

	private static FFieldAddress RemovePreviewAssetFromSkeleton_ReturnValue_PropertyAddress;

	private static int RemovePreviewAssetFromSkeleton_ReturnValue_Offset;

	private static bool RemoveNotifyTrackByName_IsValid;

	private static IntPtr RemoveNotifyTrackByName_FunctionAddress;

	private static int RemoveNotifyTrackByName_ParamsSize;

	private static bool RemoveNotifyTrackByName_TargetMontage_IsValid;

	private static FFieldAddress RemoveNotifyTrackByName_TargetMontage_PropertyAddress;

	private static int RemoveNotifyTrackByName_TargetMontage_Offset;

	private static bool RemoveNotifyTrackByName_Name_IsValid;

	private static FFieldAddress RemoveNotifyTrackByName_Name_PropertyAddress;

	private static int RemoveNotifyTrackByName_Name_Offset;

	private static bool RemoveNotifyEventByIndex_IsValid;

	private static IntPtr RemoveNotifyEventByIndex_FunctionAddress;

	private static int RemoveNotifyEventByIndex_ParamsSize;

	private static bool RemoveNotifyEventByIndex_TargetMontage_IsValid;

	private static FFieldAddress RemoveNotifyEventByIndex_TargetMontage_PropertyAddress;

	private static int RemoveNotifyEventByIndex_TargetMontage_Offset;

	private static bool RemoveNotifyEventByIndex_Index_IsValid;

	private static FFieldAddress RemoveNotifyEventByIndex_Index_PropertyAddress;

	private static int RemoveNotifyEventByIndex_Index_Offset;

	private static bool RemoveAnimationNotify_IsValid;

	private static IntPtr RemoveAnimationNotify_FunctionAddress;

	private static int RemoveAnimationNotify_ParamsSize;

	private static bool RemoveAnimationNotify_AnimBase_IsValid;

	private static FFieldAddress RemoveAnimationNotify_AnimBase_PropertyAddress;

	private static int RemoveAnimationNotify_AnimBase_Offset;

	private static bool RemoveAnimationNotify_Notify_IsValid;

	private static FFieldAddress RemoveAnimationNotify_Notify_PropertyAddress;

	private static int RemoveAnimationNotify_Notify_Offset;

	private static bool RemoveAnimationNotify_NotifyState_IsValid;

	private static FFieldAddress RemoveAnimationNotify_NotifyState_PropertyAddress;

	private static int RemoveAnimationNotify_NotifyState_Offset;

	private static bool RemoveAllPoints_IsValid;

	private static IntPtr RemoveAllPoints_FunctionAddress;

	private static int RemoveAllPoints_ParamsSize;

	private static bool RemoveAllPoints_BlendSpace_IsValid;

	private static FFieldAddress RemoveAllPoints_BlendSpace_PropertyAddress;

	private static int RemoveAllPoints_BlendSpace_Offset;

	private static bool RemoveAllPoints_ReturnValue_IsValid;

	private static FFieldAddress RemoveAllPoints_ReturnValue_PropertyAddress;

	private static int RemoveAllPoints_ReturnValue_Offset;

	private static bool RemoveAllAnimationNotifyStateEventInNamedTrack_IsValid;

	private static IntPtr RemoveAllAnimationNotifyStateEventInNamedTrack_FunctionAddress;

	private static int RemoveAllAnimationNotifyStateEventInNamedTrack_ParamsSize;

	private static bool RemoveAllAnimationNotifyStateEventInNamedTrack_AnimBase_IsValid;

	private static FFieldAddress RemoveAllAnimationNotifyStateEventInNamedTrack_AnimBase_PropertyAddress;

	private static int RemoveAllAnimationNotifyStateEventInNamedTrack_AnimBase_Offset;

	private static bool RemoveAllAnimationNotifyStateEventInNamedTrack_NotifyTrackName_IsValid;

	private static FFieldAddress RemoveAllAnimationNotifyStateEventInNamedTrack_NotifyTrackName_PropertyAddress;

	private static int RemoveAllAnimationNotifyStateEventInNamedTrack_NotifyTrackName_Offset;

	private static bool ReinitAnim_IsValid;

	private static IntPtr ReinitAnim_FunctionAddress;

	private static int ReinitAnim_ParamsSize;

	private static bool ReinitAnim_Owner_IsValid;

	private static FFieldAddress ReinitAnim_Owner_PropertyAddress;

	private static int ReinitAnim_Owner_Offset;

	private static bool PostLoadBlendSpace_IsValid;

	private static IntPtr PostLoadBlendSpace_FunctionAddress;

	private static int PostLoadBlendSpace_ParamsSize;

	private static bool PostLoadBlendSpace_BlendSpace_IsValid;

	private static FFieldAddress PostLoadBlendSpace_BlendSpace_PropertyAddress;

	private static int PostLoadBlendSpace_BlendSpace_Offset;

	private static bool MontageIsValidAdditive_IsValid;

	private static IntPtr MontageIsValidAdditive_FunctionAddress;

	private static int MontageIsValidAdditive_ParamsSize;

	private static bool MontageIsValidAdditive_AnimMontage_IsValid;

	private static FFieldAddress MontageIsValidAdditive_AnimMontage_PropertyAddress;

	private static int MontageIsValidAdditive_AnimMontage_Offset;

	private static bool MontageIsValidAdditive_ReturnValue_IsValid;

	private static FFieldAddress MontageIsValidAdditive_ReturnValue_PropertyAddress;

	private static int MontageIsValidAdditive_ReturnValue_Offset;

	private static bool Montage_GetBoneTransformCS_IsValid;

	private static IntPtr Montage_GetBoneTransformCS_FunctionAddress;

	private static int Montage_GetBoneTransformCS_ParamsSize;

	private static bool Montage_GetBoneTransformCS_InMontage_IsValid;

	private static FFieldAddress Montage_GetBoneTransformCS_InMontage_PropertyAddress;

	private static int Montage_GetBoneTransformCS_InMontage_Offset;

	private static bool Montage_GetBoneTransformCS_InTime_IsValid;

	private static FFieldAddress Montage_GetBoneTransformCS_InTime_PropertyAddress;

	private static int Montage_GetBoneTransformCS_InTime_Offset;

	private static bool Montage_GetBoneTransformCS_InBoneName_IsValid;

	private static FFieldAddress Montage_GetBoneTransformCS_InBoneName_PropertyAddress;

	private static int Montage_GetBoneTransformCS_InBoneName_Offset;

	private static bool Montage_GetBoneTransformCS_InSlotName_IsValid;

	private static FFieldAddress Montage_GetBoneTransformCS_InSlotName_PropertyAddress;

	private static int Montage_GetBoneTransformCS_InSlotName_Offset;

	private static bool Montage_GetBoneTransformCS_bExtractRootMotion_IsValid;

	private static FFieldAddress Montage_GetBoneTransformCS_bExtractRootMotion_PropertyAddress;

	private static int Montage_GetBoneTransformCS_bExtractRootMotion_Offset;

	private static bool Montage_GetBoneTransformCS_ReturnValue_IsValid;

	private static FFieldAddress Montage_GetBoneTransformCS_ReturnValue_PropertyAddress;

	private static int Montage_GetBoneTransformCS_ReturnValue_Offset;

	private static bool Montage_GetBoneRelativeTransformCS_IsValid;

	private static IntPtr Montage_GetBoneRelativeTransformCS_FunctionAddress;

	private static int Montage_GetBoneRelativeTransformCS_ParamsSize;

	private static bool Montage_GetBoneRelativeTransformCS_InMontage_IsValid;

	private static FFieldAddress Montage_GetBoneRelativeTransformCS_InMontage_PropertyAddress;

	private static int Montage_GetBoneRelativeTransformCS_InMontage_Offset;

	private static bool Montage_GetBoneRelativeTransformCS_InTime_IsValid;

	private static FFieldAddress Montage_GetBoneRelativeTransformCS_InTime_PropertyAddress;

	private static int Montage_GetBoneRelativeTransformCS_InTime_Offset;

	private static bool Montage_GetBoneRelativeTransformCS_InBoneName_IsValid;

	private static FFieldAddress Montage_GetBoneRelativeTransformCS_InBoneName_PropertyAddress;

	private static int Montage_GetBoneRelativeTransformCS_InBoneName_Offset;

	private static bool Montage_GetBoneRelativeTransformCS_InSlotName_IsValid;

	private static FFieldAddress Montage_GetBoneRelativeTransformCS_InSlotName_PropertyAddress;

	private static int Montage_GetBoneRelativeTransformCS_InSlotName_Offset;

	private static bool Montage_GetBoneRelativeTransformCS_bExtractRootMotion_IsValid;

	private static FFieldAddress Montage_GetBoneRelativeTransformCS_bExtractRootMotion_PropertyAddress;

	private static int Montage_GetBoneRelativeTransformCS_bExtractRootMotion_Offset;

	private static bool Montage_GetBoneRelativeTransformCS_ReturnValue_IsValid;

	private static FFieldAddress Montage_GetBoneRelativeTransformCS_ReturnValue_PropertyAddress;

	private static int Montage_GetBoneRelativeTransformCS_ReturnValue_Offset;

	private static bool MarkDirtyForANEMontageTickType_IsValid;

	private static IntPtr MarkDirtyForANEMontageTickType_FunctionAddress;

	private static int MarkDirtyForANEMontageTickType_ParamsSize;

	private static bool MarkDirtyForANEMontageTickType_ResourcePath_IsValid;

	private static FFieldAddress MarkDirtyForANEMontageTickType_ResourcePath_PropertyAddress;

	private static int MarkDirtyForANEMontageTickType_ResourcePath_Offset;

	private static bool MarkDirtyForANEMontageTickType_bToQueued_IsValid;

	private static FFieldAddress MarkDirtyForANEMontageTickType_bToQueued_PropertyAddress;

	private static int MarkDirtyForANEMontageTickType_bToQueued_Offset;

	private static bool MarkDirtyAM_IsValid;

	private static IntPtr MarkDirtyAM_FunctionAddress;

	private static int MarkDirtyAM_ParamsSize;

	private static bool MarkDirtyAM_DirtyMontage_IsValid;

	private static FFieldAddress MarkDirtyAM_DirtyMontage_PropertyAddress;

	private static int MarkDirtyAM_DirtyMontage_Offset;

	private static bool MarkDirty_IsValid;

	private static IntPtr MarkDirty_FunctionAddress;

	private static int MarkDirty_ParamsSize;

	private static bool MarkDirty_obj_IsValid;

	private static FFieldAddress MarkDirty_obj_PropertyAddress;

	private static int MarkDirty_obj_Offset;

	private static bool IsSlotPlayingMontage_IsValid;

	private static IntPtr IsSlotPlayingMontage_FunctionAddress;

	private static int IsSlotPlayingMontage_ParamsSize;

	private static bool IsSlotPlayingMontage_AnimInst_IsValid;

	private static FFieldAddress IsSlotPlayingMontage_AnimInst_PropertyAddress;

	private static int IsSlotPlayingMontage_AnimInst_Offset;

	private static bool IsSlotPlayingMontage_SlotNodeName_IsValid;

	private static FFieldAddress IsSlotPlayingMontage_SlotNodeName_PropertyAddress;

	private static int IsSlotPlayingMontage_SlotNodeName_Offset;

	private static bool IsSlotPlayingMontage_ReturnValue_IsValid;

	private static FFieldAddress IsSlotPlayingMontage_ReturnValue_PropertyAddress;

	private static int IsSlotPlayingMontage_ReturnValue_Offset;

	private static bool IsInRootMotionAM_IsValid;

	private static IntPtr IsInRootMotionAM_FunctionAddress;

	private static int IsInRootMotionAM_ParamsSize;

	private static bool IsInRootMotionAM_Character_IsValid;

	private static FFieldAddress IsInRootMotionAM_Character_PropertyAddress;

	private static int IsInRootMotionAM_Character_Offset;

	private static bool IsInRootMotionAM_ReturnValue_IsValid;

	private static FFieldAddress IsInRootMotionAM_ReturnValue_PropertyAddress;

	private static int IsInRootMotionAM_ReturnValue_Offset;

	private static bool InitAnimGraphNode_IsValid;

	private static IntPtr InitAnimGraphNode_FunctionAddress;

	private static int InitAnimGraphNode_ParamsSize;

	private static bool InitAnimGraphNode_AnimInst_IsValid;

	private static FFieldAddress InitAnimGraphNode_AnimInst_PropertyAddress;

	private static int InitAnimGraphNode_AnimInst_Offset;

	private static bool InitAnimGraphNode_Tag_IsValid;

	private static FFieldAddress InitAnimGraphNode_Tag_PropertyAddress;

	private static int InitAnimGraphNode_Tag_Offset;

	private static bool GetTrackIndexForAnimationNotifyTrackName_IsValid;

	private static IntPtr GetTrackIndexForAnimationNotifyTrackName_FunctionAddress;

	private static int GetTrackIndexForAnimationNotifyTrackName_ParamsSize;

	private static bool GetTrackIndexForAnimationNotifyTrackName_AnimBase_IsValid;

	private static FFieldAddress GetTrackIndexForAnimationNotifyTrackName_AnimBase_PropertyAddress;

	private static int GetTrackIndexForAnimationNotifyTrackName_AnimBase_Offset;

	private static bool GetTrackIndexForAnimationNotifyTrackName_NotifyTrackName_IsValid;

	private static FFieldAddress GetTrackIndexForAnimationNotifyTrackName_NotifyTrackName_PropertyAddress;

	private static int GetTrackIndexForAnimationNotifyTrackName_NotifyTrackName_Offset;

	private static bool GetTrackIndexForAnimationNotifyTrackName_ReturnValue_IsValid;

	private static FFieldAddress GetTrackIndexForAnimationNotifyTrackName_ReturnValue_PropertyAddress;

	private static int GetTrackIndexForAnimationNotifyTrackName_ReturnValue_Offset;

	private static bool GetSkeleton_IsValid;

	private static IntPtr GetSkeleton_FunctionAddress;

	private static int GetSkeleton_ParamsSize;

	private static bool GetSkeleton_AnimSequenceBase_IsValid;

	private static FFieldAddress GetSkeleton_AnimSequenceBase_PropertyAddress;

	private static int GetSkeleton_AnimSequenceBase_Offset;

	private static bool GetSkeleton_ReturnValue_IsValid;

	private static FFieldAddress GetSkeleton_ReturnValue_PropertyAddress;

	private static int GetSkeleton_ReturnValue_Offset;

	private static bool GetOneAnimAllNotifyEventIncludeAS_IsValid;

	private static IntPtr GetOneAnimAllNotifyEventIncludeAS_FunctionAddress;

	private static int GetOneAnimAllNotifyEventIncludeAS_ParamsSize;

	private static bool GetOneAnimAllNotifyEventIncludeAS_TargetAnim_IsValid;

	private static FFieldAddress GetOneAnimAllNotifyEventIncludeAS_TargetAnim_PropertyAddress;

	private static int GetOneAnimAllNotifyEventIncludeAS_TargetAnim_Offset;

	private static bool GetOneAnimAllNotifyEventIncludeAS_AnimNotifyEventList_IsValid;

	private static FFieldAddress GetOneAnimAllNotifyEventIncludeAS_AnimNotifyEventList_PropertyAddress;

	private static int GetOneAnimAllNotifyEventIncludeAS_AnimNotifyEventList_Offset;

	private static bool GetNumUVChannels_IsValid;

	private static IntPtr GetNumUVChannels_FunctionAddress;

	private static int GetNumUVChannels_ParamsSize;

	private static bool GetNumUVChannels_StaticMesh_IsValid;

	private static FFieldAddress GetNumUVChannels_StaticMesh_PropertyAddress;

	private static int GetNumUVChannels_StaticMesh_Offset;

	private static bool GetNumUVChannels_LODIndex_IsValid;

	private static FFieldAddress GetNumUVChannels_LODIndex_PropertyAddress;

	private static int GetNumUVChannels_LODIndex_Offset;

	private static bool GetNumUVChannels_ReturnValue_IsValid;

	private static FFieldAddress GetNumUVChannels_ReturnValue_PropertyAddress;

	private static int GetNumUVChannels_ReturnValue_Offset;

	private static bool GetNotifyTriggerTime_IsValid;

	private static IntPtr GetNotifyTriggerTime_FunctionAddress;

	private static int GetNotifyTriggerTime_ParamsSize;

	private static bool GetNotifyTriggerTime_AnimNotifyEvent_IsValid;

	private static FFieldAddress GetNotifyTriggerTime_AnimNotifyEvent_PropertyAddress;

	private static int GetNotifyTriggerTime_AnimNotifyEvent_Offset;

	private static bool GetNotifyTriggerTime_ReturnValue_IsValid;

	private static FFieldAddress GetNotifyTriggerTime_ReturnValue_PropertyAddress;

	private static int GetNotifyTriggerTime_ReturnValue_Offset;

	private static bool GetNotifyEndTriggerTime_IsValid;

	private static IntPtr GetNotifyEndTriggerTime_FunctionAddress;

	private static int GetNotifyEndTriggerTime_ParamsSize;

	private static bool GetNotifyEndTriggerTime_AnimNotifyEvent_IsValid;

	private static FFieldAddress GetNotifyEndTriggerTime_AnimNotifyEvent_PropertyAddress;

	private static int GetNotifyEndTriggerTime_AnimNotifyEvent_Offset;

	private static bool GetNotifyEndTriggerTime_ReturnValue_IsValid;

	private static FFieldAddress GetNotifyEndTriggerTime_ReturnValue_PropertyAddress;

	private static int GetNotifyEndTriggerTime_ReturnValue_Offset;

	private static bool GetNotifyComboEndTime_IsValid;

	private static IntPtr GetNotifyComboEndTime_FunctionAddress;

	private static int GetNotifyComboEndTime_ParamsSize;

	private static bool GetNotifyComboEndTime_AnimInst_IsValid;

	private static FFieldAddress GetNotifyComboEndTime_AnimInst_PropertyAddress;

	private static int GetNotifyComboEndTime_AnimInst_Offset;

	private static bool GetNotifyComboEndTime_index_IsValid;

	private static FFieldAddress GetNotifyComboEndTime_index_PropertyAddress;

	private static int GetNotifyComboEndTime_index_Offset;

	private static bool GetNotifyComboEndTime_ReturnValue_IsValid;

	private static FFieldAddress GetNotifyComboEndTime_ReturnValue_PropertyAddress;

	private static int GetNotifyComboEndTime_ReturnValue_Offset;

	private static bool GetMontageSlotName_IsValid;

	private static IntPtr GetMontageSlotName_FunctionAddress;

	private static int GetMontageSlotName_ParamsSize;

	private static bool GetMontageSlotName_Montage_IsValid;

	private static FFieldAddress GetMontageSlotName_Montage_PropertyAddress;

	private static int GetMontageSlotName_Montage_Offset;

	private static bool GetMontageSlotName_SlotIndex_IsValid;

	private static FFieldAddress GetMontageSlotName_SlotIndex_PropertyAddress;

	private static int GetMontageSlotName_SlotIndex_Offset;

	private static bool GetMontageSlotName_ReturnValue_IsValid;

	private static FFieldAddress GetMontageSlotName_ReturnValue_PropertyAddress;

	private static int GetMontageSlotName_ReturnValue_Offset;

	private static bool GetMontageSectionStartAndEndTime_IsValid;

	private static IntPtr GetMontageSectionStartAndEndTime_FunctionAddress;

	private static int GetMontageSectionStartAndEndTime_ParamsSize;

	private static bool GetMontageSectionStartAndEndTime_AnimMontage_IsValid;

	private static FFieldAddress GetMontageSectionStartAndEndTime_AnimMontage_PropertyAddress;

	private static int GetMontageSectionStartAndEndTime_AnimMontage_Offset;

	private static bool GetMontageSectionStartAndEndTime_SectionName_IsValid;

	private static FFieldAddress GetMontageSectionStartAndEndTime_SectionName_PropertyAddress;

	private static int GetMontageSectionStartAndEndTime_SectionName_Offset;

	private static bool GetMontageSectionStartAndEndTime_OutStartTime_IsValid;

	private static FFieldAddress GetMontageSectionStartAndEndTime_OutStartTime_PropertyAddress;

	private static int GetMontageSectionStartAndEndTime_OutStartTime_Offset;

	private static bool GetMontageSectionStartAndEndTime_OutEndTime_IsValid;

	private static FFieldAddress GetMontageSectionStartAndEndTime_OutEndTime_PropertyAddress;

	private static int GetMontageSectionStartAndEndTime_OutEndTime_Offset;

	private static bool GetMontageSectionName_IsValid;

	private static IntPtr GetMontageSectionName_FunctionAddress;

	private static int GetMontageSectionName_ParamsSize;

	private static bool GetMontageSectionName_AnimMontage_IsValid;

	private static FFieldAddress GetMontageSectionName_AnimMontage_PropertyAddress;

	private static int GetMontageSectionName_AnimMontage_Offset;

	private static bool GetMontageSectionName_index_IsValid;

	private static FFieldAddress GetMontageSectionName_index_PropertyAddress;

	private static int GetMontageSectionName_index_Offset;

	private static bool GetMontageSectionName_ReturnValue_IsValid;

	private static FFieldAddress GetMontageSectionName_ReturnValue_PropertyAddress;

	private static int GetMontageSectionName_ReturnValue_Offset;

	private static bool GetMontageNotifyTriggerTime_IsValid;

	private static IntPtr GetMontageNotifyTriggerTime_FunctionAddress;

	private static int GetMontageNotifyTriggerTime_ParamsSize;

	private static bool GetMontageNotifyTriggerTime_AnimInst_IsValid;

	private static FFieldAddress GetMontageNotifyTriggerTime_AnimInst_PropertyAddress;

	private static int GetMontageNotifyTriggerTime_AnimInst_Offset;

	private static bool GetMontageNotifyTriggerTime_FromInstanceID_IsValid;

	private static FFieldAddress GetMontageNotifyTriggerTime_FromInstanceID_PropertyAddress;

	private static int GetMontageNotifyTriggerTime_FromInstanceID_Offset;

	private static bool GetMontageNotifyTriggerTime_ReturnValue_IsValid;

	private static FFieldAddress GetMontageNotifyTriggerTime_ReturnValue_PropertyAddress;

	private static int GetMontageNotifyTriggerTime_ReturnValue_Offset;

	private static bool GetMontageNotifyName_IsValid;

	private static IntPtr GetMontageNotifyName_FunctionAddress;

	private static int GetMontageNotifyName_ParamsSize;

	private static bool GetMontageNotifyName_AnimInst_IsValid;

	private static FFieldAddress GetMontageNotifyName_AnimInst_PropertyAddress;

	private static int GetMontageNotifyName_AnimInst_Offset;

	private static bool GetMontageNotifyName_index_IsValid;

	private static FFieldAddress GetMontageNotifyName_index_PropertyAddress;

	private static int GetMontageNotifyName_index_Offset;

	private static bool GetMontageNotifyName_ReturnValue_IsValid;

	private static FFieldAddress GetMontageNotifyName_ReturnValue_PropertyAddress;

	private static int GetMontageNotifyName_ReturnValue_Offset;

	private static bool GetMontageNextSection_IsValid;

	private static IntPtr GetMontageNextSection_FunctionAddress;

	private static int GetMontageNextSection_ParamsSize;

	private static bool GetMontageNextSection_AnimInstance_IsValid;

	private static FFieldAddress GetMontageNextSection_AnimInstance_PropertyAddress;

	private static int GetMontageNextSection_AnimInstance_Offset;

	private static bool GetMontageNextSection_AnimMontage_IsValid;

	private static FFieldAddress GetMontageNextSection_AnimMontage_PropertyAddress;

	private static int GetMontageNextSection_AnimMontage_Offset;

	private static bool GetMontageNextSection_ReturnValue_IsValid;

	private static FFieldAddress GetMontageNextSection_ReturnValue_PropertyAddress;

	private static int GetMontageNextSection_ReturnValue_Offset;

	private static bool GetMontageEffectID_IsValid;

	private static IntPtr GetMontageEffectID_FunctionAddress;

	private static int GetMontageEffectID_ParamsSize;

	private static bool GetMontageEffectID_AnimInst_IsValid;

	private static FFieldAddress GetMontageEffectID_AnimInst_PropertyAddress;

	private static int GetMontageEffectID_AnimInst_Offset;

	private static bool GetMontageEffectID_index_IsValid;

	private static FFieldAddress GetMontageEffectID_index_PropertyAddress;

	private static int GetMontageEffectID_index_Offset;

	private static bool GetMontageEffectID_ReturnValue_IsValid;

	private static FFieldAddress GetMontageEffectID_ReturnValue_PropertyAddress;

	private static int GetMontageEffectID_ReturnValue_Offset;

	private static bool GetMontageComboSkillID_IsValid;

	private static IntPtr GetMontageComboSkillID_FunctionAddress;

	private static int GetMontageComboSkillID_ParamsSize;

	private static bool GetMontageComboSkillID_AnimInst_IsValid;

	private static FFieldAddress GetMontageComboSkillID_AnimInst_PropertyAddress;

	private static int GetMontageComboSkillID_AnimInst_Offset;

	private static bool GetMontageComboSkillID_index_IsValid;

	private static FFieldAddress GetMontageComboSkillID_index_PropertyAddress;

	private static int GetMontageComboSkillID_index_Offset;

	private static bool GetMontageComboSkillID_ReturnValue_IsValid;

	private static FFieldAddress GetMontageComboSkillID_ReturnValue_PropertyAddress;

	private static int GetMontageComboSkillID_ReturnValue_Offset;

	private static bool GetFolderPathFromFullPath_IsValid;

	private static IntPtr GetFolderPathFromFullPath_FunctionAddress;

	private static int GetFolderPathFromFullPath_ParamsSize;

	private static bool GetFolderPathFromFullPath_FullPath_IsValid;

	private static FFieldAddress GetFolderPathFromFullPath_FullPath_PropertyAddress;

	private static int GetFolderPathFromFullPath_FullPath_Offset;

	private static bool GetFolderPathFromFullPath_ReturnValue_IsValid;

	private static FFieldAddress GetFolderPathFromFullPath_ReturnValue_PropertyAddress;

	private static int GetFolderPathFromFullPath_ReturnValue_Offset;

	private static bool GetCurrentActiveMontageInstanceID_IsValid;

	private static IntPtr GetCurrentActiveMontageInstanceID_FunctionAddress;

	private static int GetCurrentActiveMontageInstanceID_ParamsSize;

	private static bool GetCurrentActiveMontageInstanceID_Character_IsValid;

	private static FFieldAddress GetCurrentActiveMontageInstanceID_Character_PropertyAddress;

	private static int GetCurrentActiveMontageInstanceID_Character_Offset;

	private static bool GetCurrentActiveMontageInstanceID_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentActiveMontageInstanceID_ReturnValue_PropertyAddress;

	private static int GetCurrentActiveMontageInstanceID_ReturnValue_Offset;

	private static bool GetChildSockets_IsValid;

	private static IntPtr GetChildSockets_FunctionAddress;

	private static int GetChildSockets_ParamsSize;

	private static bool GetChildSockets_SkeletalMeshComp_IsValid;

	private static FFieldAddress GetChildSockets_SkeletalMeshComp_PropertyAddress;

	private static int GetChildSockets_SkeletalMeshComp_Offset;

	private static bool GetChildSockets_BaseBoneName_IsValid;

	private static FFieldAddress GetChildSockets_BaseBoneName_PropertyAddress;

	private static int GetChildSockets_BaseBoneName_Offset;

	private static bool GetChildSockets_ChildSocketNames_IsValid;

	private static FFieldAddress GetChildSockets_ChildSocketNames_PropertyAddress;

	private static int GetChildSockets_ChildSocketNames_Offset;

	private static bool GetChildBones_IsValid;

	private static IntPtr GetChildBones_FunctionAddress;

	private static int GetChildBones_ParamsSize;

	private static bool GetChildBones_InSkeleton_IsValid;

	private static FFieldAddress GetChildBones_InSkeleton_PropertyAddress;

	private static int GetChildBones_InSkeleton_Offset;

	private static bool GetChildBones_ParentBoneName_IsValid;

	private static FFieldAddress GetChildBones_ParentBoneName_PropertyAddress;

	private static int GetChildBones_ParentBoneName_Offset;

	private static bool GetChildBones_BoneNameFilter_IsValid;

	private static FFieldAddress GetChildBones_BoneNameFilter_PropertyAddress;

	private static int GetChildBones_BoneNameFilter_Offset;

	private static bool GetChildBones_ChildBones_IsValid;

	private static FFieldAddress GetChildBones_ChildBones_PropertyAddress;

	private static int GetChildBones_ChildBones_Offset;

	private static bool GetChildBones_ReturnValue_IsValid;

	private static FFieldAddress GetChildBones_ReturnValue_PropertyAddress;

	private static int GetChildBones_ReturnValue_Offset;

	private static bool GetBoneWeight_IsValid;

	private static IntPtr GetBoneWeight_FunctionAddress;

	private static int GetBoneWeight_ParamsSize;

	private static bool GetBoneWeight_SkeletalMesh_IsValid;

	private static FFieldAddress GetBoneWeight_SkeletalMesh_PropertyAddress;

	private static int GetBoneWeight_SkeletalMesh_Offset;

	private static bool GetBoneWeight_ReturnValue_IsValid;

	private static FFieldAddress GetBoneWeight_ReturnValue_PropertyAddress;

	private static int GetBoneWeight_ReturnValue_Offset;

	private static bool GetBoneTransformByTime_IsValid;

	private static IntPtr GetBoneTransformByTime_FunctionAddress;

	private static int GetBoneTransformByTime_ParamsSize;

	private static bool GetBoneTransformByTime_AnimationSequence_IsValid;

	private static FFieldAddress GetBoneTransformByTime_AnimationSequence_PropertyAddress;

	private static int GetBoneTransformByTime_AnimationSequence_Offset;

	private static bool GetBoneTransformByTime_Time_IsValid;

	private static FFieldAddress GetBoneTransformByTime_Time_PropertyAddress;

	private static int GetBoneTransformByTime_Time_Offset;

	private static bool GetBoneTransformByTime_TrackIndex_IsValid;

	private static FFieldAddress GetBoneTransformByTime_TrackIndex_PropertyAddress;

	private static int GetBoneTransformByTime_TrackIndex_Offset;

	private static bool GetBoneTransformByTime_UseRawData_IsValid;

	private static FFieldAddress GetBoneTransformByTime_UseRawData_PropertyAddress;

	private static int GetBoneTransformByTime_UseRawData_Offset;

	private static bool GetBoneTransformByTime_ReturnValue_IsValid;

	private static FFieldAddress GetBoneTransformByTime_ReturnValue_PropertyAddress;

	private static int GetBoneTransformByTime_ReturnValue_Offset;

	private static bool GetBoneTransform_IsValid;

	private static IntPtr GetBoneTransform_FunctionAddress;

	private static int GetBoneTransform_ParamsSize;

	private static bool GetBoneTransform_Mesh_IsValid;

	private static FFieldAddress GetBoneTransform_Mesh_PropertyAddress;

	private static int GetBoneTransform_Mesh_Offset;

	private static bool GetBoneTransform_BoneIndex_IsValid;

	private static FFieldAddress GetBoneTransform_BoneIndex_PropertyAddress;

	private static int GetBoneTransform_BoneIndex_Offset;

	private static bool GetBoneTransform_ReturnValue_IsValid;

	private static FFieldAddress GetBoneTransform_ReturnValue_PropertyAddress;

	private static int GetBoneTransform_ReturnValue_Offset;

	private static bool GetBoneParentList_IsValid;

	private static IntPtr GetBoneParentList_FunctionAddress;

	private static int GetBoneParentList_ParamsSize;

	private static bool GetBoneParentList_AnimationSequence_IsValid;

	private static FFieldAddress GetBoneParentList_AnimationSequence_PropertyAddress;

	private static int GetBoneParentList_AnimationSequence_Offset;

	private static bool GetBoneParentList_ReturnValue_IsValid;

	private static FFieldAddress GetBoneParentList_ReturnValue_PropertyAddress;

	private static int GetBoneParentList_ReturnValue_Offset;

	private static bool GetAnimCurrentTime_IsValid;

	private static IntPtr GetAnimCurrentTime_FunctionAddress;

	private static int GetAnimCurrentTime_ParamsSize;

	private static bool GetAnimCurrentTime_AnimInst_IsValid;

	private static FFieldAddress GetAnimCurrentTime_AnimInst_PropertyAddress;

	private static int GetAnimCurrentTime_AnimInst_Offset;

	private static bool GetAnimCurrentTime_FromInstanceID_IsValid;

	private static FFieldAddress GetAnimCurrentTime_FromInstanceID_PropertyAddress;

	private static int GetAnimCurrentTime_FromInstanceID_Offset;

	private static bool GetAnimCurrentTime_ReturnValue_IsValid;

	private static FFieldAddress GetAnimCurrentTime_ReturnValue_PropertyAddress;

	private static int GetAnimCurrentTime_ReturnValue_Offset;

	private static bool GetAnimationTrackNames_IsValid;

	private static IntPtr GetAnimationTrackNames_FunctionAddress;

	private static int GetAnimationTrackNames_ParamsSize;

	private static bool GetAnimationTrackNames_AnimationSequence_IsValid;

	private static FFieldAddress GetAnimationTrackNames_AnimationSequence_PropertyAddress;

	private static int GetAnimationTrackNames_AnimationSequence_Offset;

	private static bool GetAnimationTrackNames_ReturnValue_IsValid;

	private static FFieldAddress GetAnimationTrackNames_ReturnValue_PropertyAddress;

	private static int GetAnimationTrackNames_ReturnValue_Offset;

	private static bool GetAnimationTrackNameByIndex_IsValid;

	private static IntPtr GetAnimationTrackNameByIndex_FunctionAddress;

	private static int GetAnimationTrackNameByIndex_ParamsSize;

	private static bool GetAnimationTrackNameByIndex_AnimSequenceBase_IsValid;

	private static FFieldAddress GetAnimationTrackNameByIndex_AnimSequenceBase_PropertyAddress;

	private static int GetAnimationTrackNameByIndex_AnimSequenceBase_Offset;

	private static bool GetAnimationTrackNameByIndex_Index_IsValid;

	private static FFieldAddress GetAnimationTrackNameByIndex_Index_PropertyAddress;

	private static int GetAnimationTrackNameByIndex_Index_Offset;

	private static bool GetAnimationTrackNameByIndex_TrackName_IsValid;

	private static FFieldAddress GetAnimationTrackNameByIndex_TrackName_PropertyAddress;

	private static int GetAnimationTrackNameByIndex_TrackName_Offset;

	private static bool GetAnimationTrackNameByIndex_ReturnValue_IsValid;

	private static FFieldAddress GetAnimationTrackNameByIndex_ReturnValue_PropertyAddress;

	private static int GetAnimationTrackNameByIndex_ReturnValue_Offset;

	private static bool GetAnimationNotifyEvents_IsValid;

	private static IntPtr GetAnimationNotifyEvents_FunctionAddress;

	private static int GetAnimationNotifyEvents_ParamsSize;

	private static bool GetAnimationNotifyEvents_AnimSequenceBase_IsValid;

	private static FFieldAddress GetAnimationNotifyEvents_AnimSequenceBase_PropertyAddress;

	private static int GetAnimationNotifyEvents_AnimSequenceBase_Offset;

	private static bool GetAnimationNotifyEvents_NotifyEvents_IsValid;

	private static FFieldAddress GetAnimationNotifyEvents_NotifyEvents_PropertyAddress;

	private static int GetAnimationNotifyEvents_NotifyEvents_Offset;

	private static bool GetAnimationNotifyEvents_ReturnValue_IsValid;

	private static FFieldAddress GetAnimationNotifyEvents_ReturnValue_PropertyAddress;

	private static int GetAnimationNotifyEvents_ReturnValue_Offset;

	private static bool GetAnimAllNotifyEventIncludeAS_IsValid;

	private static IntPtr GetAnimAllNotifyEventIncludeAS_FunctionAddress;

	private static int GetAnimAllNotifyEventIncludeAS_ParamsSize;

	private static bool GetAnimAllNotifyEventIncludeAS_AnimBases_IsValid;

	private static FFieldAddress GetAnimAllNotifyEventIncludeAS_AnimBases_PropertyAddress;

	private static int GetAnimAllNotifyEventIncludeAS_AnimBases_Offset;

	private static bool GetAnimAllNotifyEventIncludeAS_AnimNotifyEventList_IsValid;

	private static FFieldAddress GetAnimAllNotifyEventIncludeAS_AnimNotifyEventList_PropertyAddress;

	private static int GetAnimAllNotifyEventIncludeAS_AnimNotifyEventList_Offset;

	private static bool GetAllNotifyEventInAM_IsValid;

	private static IntPtr GetAllNotifyEventInAM_FunctionAddress;

	private static int GetAllNotifyEventInAM_ParamsSize;

	private static bool GetAllNotifyEventInAM_TargetMontage_IsValid;

	private static FFieldAddress GetAllNotifyEventInAM_TargetMontage_PropertyAddress;

	private static int GetAllNotifyEventInAM_TargetMontage_Offset;

	private static bool GetAllNotifyEventInAM_TimeInfoList_IsValid;

	private static FFieldAddress GetAllNotifyEventInAM_TimeInfoList_PropertyAddress;

	private static int GetAllNotifyEventInAM_TimeInfoList_Offset;

	private static bool GetAllNotifyEventInAM_ReturnValue_IsValid;

	private static FFieldAddress GetAllNotifyEventInAM_ReturnValue_PropertyAddress;

	private static int GetAllNotifyEventInAM_ReturnValue_Offset;

	private static bool GetAllNotifyEvent_IsValid;

	private static IntPtr GetAllNotifyEvent_FunctionAddress;

	private static int GetAllNotifyEvent_ParamsSize;

	private static bool GetAllNotifyEvent_TargetMontage_IsValid;

	private static FFieldAddress GetAllNotifyEvent_TargetMontage_PropertyAddress;

	private static int GetAllNotifyEvent_TargetMontage_Offset;

	private static bool GetAllNotifyEvent_AnimNotifyEventList_IsValid;

	private static FFieldAddress GetAllNotifyEvent_AnimNotifyEventList_PropertyAddress;

	private static int GetAllNotifyEvent_AnimNotifyEventList_Offset;

	private static bool GetAllAnimSyncMarkers_IsValid;

	private static IntPtr GetAllAnimSyncMarkers_FunctionAddress;

	private static int GetAllAnimSyncMarkers_ParamsSize;

	private static bool GetAllAnimSyncMarkers_AnimSequence_IsValid;

	private static FFieldAddress GetAllAnimSyncMarkers_AnimSequence_PropertyAddress;

	private static int GetAllAnimSyncMarkers_AnimSequence_Offset;

	private static bool GetAllAnimSyncMarkers_OutSyncMarkers_IsValid;

	private static FFieldAddress GetAllAnimSyncMarkers_OutSyncMarkers_PropertyAddress;

	private static int GetAllAnimSyncMarkers_OutSyncMarkers_Offset;

	private static bool GetAllAnimSyncMarkers_ReturnValue_IsValid;

	private static FFieldAddress GetAllAnimSyncMarkers_ReturnValue_PropertyAddress;

	private static int GetAllAnimSyncMarkers_ReturnValue_Offset;

	private static bool GetAllAnimNotifyEventInAMForMarkDirty_IsValid;

	private static IntPtr GetAllAnimNotifyEventInAMForMarkDirty_FunctionAddress;

	private static int GetAllAnimNotifyEventInAMForMarkDirty_ParamsSize;

	private static bool GetAllAnimNotifyEventInAMForMarkDirty_AnimMontage_IsValid;

	private static FFieldAddress GetAllAnimNotifyEventInAMForMarkDirty_AnimMontage_PropertyAddress;

	private static int GetAllAnimNotifyEventInAMForMarkDirty_AnimMontage_Offset;

	private static bool GetAllAnimNotifyEventInAMForMarkDirty_ReturnValue_IsValid;

	private static FFieldAddress GetAllAnimNotifyEventInAMForMarkDirty_ReturnValue_PropertyAddress;

	private static int GetAllAnimNotifyEventInAMForMarkDirty_ReturnValue_Offset;

	private static bool GetAllAnimNotifyEventForMarkDirty_IsValid;

	private static IntPtr GetAllAnimNotifyEventForMarkDirty_FunctionAddress;

	private static int GetAllAnimNotifyEventForMarkDirty_ParamsSize;

	private static bool GetAllAnimNotifyEventForMarkDirty_ResourcePath_IsValid;

	private static FFieldAddress GetAllAnimNotifyEventForMarkDirty_ResourcePath_PropertyAddress;

	private static int GetAllAnimNotifyEventForMarkDirty_ResourcePath_Offset;

	private static bool GetAllAnimNotifyEventForMarkDirty_ReturnValue_IsValid;

	private static FFieldAddress GetAllAnimNotifyEventForMarkDirty_ReturnValue_PropertyAddress;

	private static int GetAllAnimNotifyEventForMarkDirty_ReturnValue_Offset;

	private static bool GetAllAnimationsOfSkeleton_IsValid;

	private static IntPtr GetAllAnimationsOfSkeleton_FunctionAddress;

	private static int GetAllAnimationsOfSkeleton_ParamsSize;

	private static bool GetAllAnimationsOfSkeleton_SkeletonMesh_IsValid;

	private static FFieldAddress GetAllAnimationsOfSkeleton_SkeletonMesh_PropertyAddress;

	private static int GetAllAnimationsOfSkeleton_SkeletonMesh_Offset;

	private static bool GetAllAnimationsOfSkeleton_AnimationBasePath_IsValid;

	private static FFieldAddress GetAllAnimationsOfSkeleton_AnimationBasePath_PropertyAddress;

	private static int GetAllAnimationsOfSkeleton_AnimationBasePath_Offset;

	private static bool GetAllAnimationsOfSkeleton_ReturnValue_IsValid;

	private static FFieldAddress GetAllAnimationsOfSkeleton_ReturnValue_PropertyAddress;

	private static int GetAllAnimationsOfSkeleton_ReturnValue_Offset;

	private static bool GetActiveMontageInstanceID_IsValid;

	private static IntPtr GetActiveMontageInstanceID_FunctionAddress;

	private static int GetActiveMontageInstanceID_ParamsSize;

	private static bool GetActiveMontageInstanceID_AnimInstance_IsValid;

	private static FFieldAddress GetActiveMontageInstanceID_AnimInstance_PropertyAddress;

	private static int GetActiveMontageInstanceID_AnimInstance_Offset;

	private static bool GetActiveMontageInstanceID_ReturnValue_IsValid;

	private static FFieldAddress GetActiveMontageInstanceID_ReturnValue_PropertyAddress;

	private static int GetActiveMontageInstanceID_ReturnValue_Offset;

	private static bool GenerateDestructibleComponentFromPathWithEditor_IsValid;

	private static IntPtr GenerateDestructibleComponentFromPathWithEditor_FunctionAddress;

	private static int GenerateDestructibleComponentFromPathWithEditor_ParamsSize;

	private static bool GenerateDestructibleComponentFromPathWithEditor_FolderPath_IsValid;

	private static FFieldAddress GenerateDestructibleComponentFromPathWithEditor_FolderPath_PropertyAddress;

	private static int GenerateDestructibleComponentFromPathWithEditor_FolderPath_Offset;

	private static bool GenerateDestructibleComponentFromPathWithEditor_TargetActor_IsValid;

	private static FFieldAddress GenerateDestructibleComponentFromPathWithEditor_TargetActor_PropertyAddress;

	private static int GenerateDestructibleComponentFromPathWithEditor_TargetActor_Offset;

	private static bool GenerateDestructibleComponentFromPathWithEditor_ReturnValue_IsValid;

	private static FFieldAddress GenerateDestructibleComponentFromPathWithEditor_ReturnValue_PropertyAddress;

	private static int GenerateDestructibleComponentFromPathWithEditor_ReturnValue_Offset;

	private static bool GenerateDestructibleComponentFromPath_IsValid;

	private static IntPtr GenerateDestructibleComponentFromPath_FunctionAddress;

	private static int GenerateDestructibleComponentFromPath_ParamsSize;

	private static bool GenerateDestructibleComponentFromPath_FolderPath_IsValid;

	private static FFieldAddress GenerateDestructibleComponentFromPath_FolderPath_PropertyAddress;

	private static int GenerateDestructibleComponentFromPath_FolderPath_Offset;

	private static bool GenerateDestructibleComponentFromPath_TargetSkeletalMeshComp_IsValid;

	private static FFieldAddress GenerateDestructibleComponentFromPath_TargetSkeletalMeshComp_PropertyAddress;

	private static int GenerateDestructibleComponentFromPath_TargetSkeletalMeshComp_Offset;

	private static bool GenerateDestructibleComponentFromPath_DestructibleMeshArray_IsValid;

	private static FFieldAddress GenerateDestructibleComponentFromPath_DestructibleMeshArray_PropertyAddress;

	private static int GenerateDestructibleComponentFromPath_DestructibleMeshArray_Offset;

	private static bool GenerateDestructibleComponentFromPath_BoneNameArray_IsValid;

	private static FFieldAddress GenerateDestructibleComponentFromPath_BoneNameArray_PropertyAddress;

	private static int GenerateDestructibleComponentFromPath_BoneNameArray_Offset;

	private static bool GenerateDestructibleComponentFromPath_ReturnValue_IsValid;

	private static FFieldAddress GenerateDestructibleComponentFromPath_ReturnValue_PropertyAddress;

	private static int GenerateDestructibleComponentFromPath_ReturnValue_Offset;

	private static bool GenerateDefaultAxisParameters_IsValid;

	private static IntPtr GenerateDefaultAxisParameters_FunctionAddress;

	private static int GenerateDefaultAxisParameters_ParamsSize;

	private static bool GenerateDefaultAxisParameters_BlendSpace_IsValid;

	private static FFieldAddress GenerateDefaultAxisParameters_BlendSpace_PropertyAddress;

	private static int GenerateDefaultAxisParameters_BlendSpace_Offset;

	private static bool GenerateDefaultAxisParameters_ReturnValue_IsValid;

	private static FFieldAddress GenerateDefaultAxisParameters_ReturnValue_PropertyAddress;

	private static int GenerateDefaultAxisParameters_ReturnValue_Offset;

	private static bool GenerateAimOffsetBlendSpace_IsValid;

	private static IntPtr GenerateAimOffsetBlendSpace_FunctionAddress;

	private static int GenerateAimOffsetBlendSpace_ParamsSize;

	private static bool GenerateAimOffsetBlendSpace_AimOffset_IsValid;

	private static FFieldAddress GenerateAimOffsetBlendSpace_AimOffset_PropertyAddress;

	private static int GenerateAimOffsetBlendSpace_AimOffset_Offset;

	private static bool GenerateAimOffsetBlendSpace_Path_IsValid;

	private static FFieldAddress GenerateAimOffsetBlendSpace_Path_PropertyAddress;

	private static int GenerateAimOffsetBlendSpace_Path_Offset;

	private static bool GenerateAimOffsetBlendSpace_ExampleName_IsValid;

	private static FFieldAddress GenerateAimOffsetBlendSpace_ExampleName_PropertyAddress;

	private static int GenerateAimOffsetBlendSpace_ExampleName_Offset;

	private static bool GenerateAimOffsetBlendSpace_ReturnValue_IsValid;

	private static FFieldAddress GenerateAimOffsetBlendSpace_ReturnValue_PropertyAddress;

	private static int GenerateAimOffsetBlendSpace_ReturnValue_Offset;

	private static bool FindDestructibleMeshFromPathByBoneName_IsValid;

	private static IntPtr FindDestructibleMeshFromPathByBoneName_FunctionAddress;

	private static int FindDestructibleMeshFromPathByBoneName_ParamsSize;

	private static bool FindDestructibleMeshFromPathByBoneName_FolderPath_IsValid;

	private static FFieldAddress FindDestructibleMeshFromPathByBoneName_FolderPath_PropertyAddress;

	private static int FindDestructibleMeshFromPathByBoneName_FolderPath_Offset;

	private static bool FindDestructibleMeshFromPathByBoneName_BoneName_IsValid;

	private static FFieldAddress FindDestructibleMeshFromPathByBoneName_BoneName_PropertyAddress;

	private static int FindDestructibleMeshFromPathByBoneName_BoneName_Offset;

	private static bool FindDestructibleMeshFromPathByBoneName_ReturnValue_IsValid;

	private static FFieldAddress FindDestructibleMeshFromPathByBoneName_ReturnValue_PropertyAddress;

	private static int FindDestructibleMeshFromPathByBoneName_ReturnValue_Offset;

	private static bool FindAsset_IsValid;

	private static IntPtr FindAsset_FunctionAddress;

	private static int FindAsset_ParamsSize;

	private static bool FindAsset_Path_IsValid;

	private static FFieldAddress FindAsset_Path_PropertyAddress;

	private static int FindAsset_Path_Offset;

	private static bool FindAsset_inClass_IsValid;

	private static FFieldAddress FindAsset_inClass_PropertyAddress;

	private static int FindAsset_inClass_Offset;

	private static bool FindAsset_AssetData_IsValid;

	private static FFieldAddress FindAsset_AssetData_PropertyAddress;

	private static int FindAsset_AssetData_Offset;

	private static bool ExtractRootMotionFromAnimation_IsValid;

	private static IntPtr ExtractRootMotionFromAnimation_FunctionAddress;

	private static int ExtractRootMotionFromAnimation_ParamsSize;

	private static bool ExtractRootMotionFromAnimation_Animation_IsValid;

	private static FFieldAddress ExtractRootMotionFromAnimation_Animation_PropertyAddress;

	private static int ExtractRootMotionFromAnimation_Animation_Offset;

	private static bool ExtractRootMotionFromAnimation_StartTime_IsValid;

	private static FFieldAddress ExtractRootMotionFromAnimation_StartTime_PropertyAddress;

	private static int ExtractRootMotionFromAnimation_StartTime_Offset;

	private static bool ExtractRootMotionFromAnimation_EndTime_IsValid;

	private static FFieldAddress ExtractRootMotionFromAnimation_EndTime_PropertyAddress;

	private static int ExtractRootMotionFromAnimation_EndTime_Offset;

	private static bool ExtractRootMotionFromAnimation_ReturnValue_IsValid;

	private static FFieldAddress ExtractRootMotionFromAnimation_ReturnValue_PropertyAddress;

	private static int ExtractRootMotionFromAnimation_ReturnValue_Offset;

	private static bool DisableMontageRootMotionByInstanceID_IsValid;

	private static IntPtr DisableMontageRootMotionByInstanceID_FunctionAddress;

	private static int DisableMontageRootMotionByInstanceID_ParamsSize;

	private static bool DisableMontageRootMotionByInstanceID_Character_IsValid;

	private static FFieldAddress DisableMontageRootMotionByInstanceID_Character_PropertyAddress;

	private static int DisableMontageRootMotionByInstanceID_Character_Offset;

	private static bool DisableMontageRootMotionByInstanceID_MontageInstanceID_IsValid;

	private static FFieldAddress DisableMontageRootMotionByInstanceID_MontageInstanceID_PropertyAddress;

	private static int DisableMontageRootMotionByInstanceID_MontageInstanceID_Offset;

	private static bool CreateBlendSpace1D_IsValid;

	private static IntPtr CreateBlendSpace1D_FunctionAddress;

	private static int CreateBlendSpace1D_ParamsSize;

	private static bool CreateBlendSpace1D_Path_IsValid;

	private static FFieldAddress CreateBlendSpace1D_Path_PropertyAddress;

	private static int CreateBlendSpace1D_Path_Offset;

	private static bool CreateBlendSpace1D_Name_IsValid;

	private static FFieldAddress CreateBlendSpace1D_Name_PropertyAddress;

	private static int CreateBlendSpace1D_Name_Offset;

	private static bool CreateBlendSpace1D_TargetSkeleton_IsValid;

	private static FFieldAddress CreateBlendSpace1D_TargetSkeleton_PropertyAddress;

	private static int CreateBlendSpace1D_TargetSkeleton_Offset;

	private static bool CreateBlendSpace1D_ReturnValue_IsValid;

	private static FFieldAddress CreateBlendSpace1D_ReturnValue_PropertyAddress;

	private static int CreateBlendSpace1D_ReturnValue_Offset;

	private static bool CreateBlendSpace_IsValid;

	private static IntPtr CreateBlendSpace_FunctionAddress;

	private static int CreateBlendSpace_ParamsSize;

	private static bool CreateBlendSpace_Path_IsValid;

	private static FFieldAddress CreateBlendSpace_Path_PropertyAddress;

	private static int CreateBlendSpace_Path_Offset;

	private static bool CreateBlendSpace_Name_IsValid;

	private static FFieldAddress CreateBlendSpace_Name_PropertyAddress;

	private static int CreateBlendSpace_Name_Offset;

	private static bool CreateBlendSpace_TargetSkeleton_IsValid;

	private static FFieldAddress CreateBlendSpace_TargetSkeleton_PropertyAddress;

	private static int CreateBlendSpace_TargetSkeleton_Offset;

	private static bool CreateBlendSpace_ReturnValue_IsValid;

	private static FFieldAddress CreateBlendSpace_ReturnValue_PropertyAddress;

	private static int CreateBlendSpace_ReturnValue_Offset;

	private static bool CreateAnimMontage_IsValid;

	private static IntPtr CreateAnimMontage_FunctionAddress;

	private static int CreateAnimMontage_ParamsSize;

	private static bool CreateAnimMontage_Path_IsValid;

	private static FFieldAddress CreateAnimMontage_Path_PropertyAddress;

	private static int CreateAnimMontage_Path_Offset;

	private static bool CreateAnimMontage_Name_IsValid;

	private static FFieldAddress CreateAnimMontage_Name_PropertyAddress;

	private static int CreateAnimMontage_Name_Offset;

	private static bool CreateAnimMontage_TargetSkeleton_IsValid;

	private static FFieldAddress CreateAnimMontage_TargetSkeleton_PropertyAddress;

	private static int CreateAnimMontage_TargetSkeleton_Offset;

	private static bool CreateAnimMontage_ReturnValue_IsValid;

	private static FFieldAddress CreateAnimMontage_ReturnValue_PropertyAddress;

	private static int CreateAnimMontage_ReturnValue_Offset;

	private static bool CreateAimOffsetBlendSpace_IsValid;

	private static IntPtr CreateAimOffsetBlendSpace_FunctionAddress;

	private static int CreateAimOffsetBlendSpace_ParamsSize;

	private static bool CreateAimOffsetBlendSpace_Path_IsValid;

	private static FFieldAddress CreateAimOffsetBlendSpace_Path_PropertyAddress;

	private static int CreateAimOffsetBlendSpace_Path_Offset;

	private static bool CreateAimOffsetBlendSpace_Name_IsValid;

	private static FFieldAddress CreateAimOffsetBlendSpace_Name_PropertyAddress;

	private static int CreateAimOffsetBlendSpace_Name_Offset;

	private static bool CreateAimOffsetBlendSpace_TargetSkeleton_IsValid;

	private static FFieldAddress CreateAimOffsetBlendSpace_TargetSkeleton_PropertyAddress;

	private static int CreateAimOffsetBlendSpace_TargetSkeleton_Offset;

	private static bool CreateAimOffsetBlendSpace_ReturnValue_IsValid;

	private static FFieldAddress CreateAimOffsetBlendSpace_ReturnValue_PropertyAddress;

	private static int CreateAimOffsetBlendSpace_ReturnValue_Offset;

	private static bool ConditionallyDispatchQueuedAnimEvents_IsValid;

	private static IntPtr ConditionallyDispatchQueuedAnimEvents_FunctionAddress;

	private static int ConditionallyDispatchQueuedAnimEvents_ParamsSize;

	private static bool ConditionallyDispatchQueuedAnimEvents_SkeletalMeshComp_IsValid;

	private static FFieldAddress ConditionallyDispatchQueuedAnimEvents_SkeletalMeshComp_PropertyAddress;

	private static int ConditionallyDispatchQueuedAnimEvents_SkeletalMeshComp_Offset;

	private static bool CheckoutLoadedAssetAndSave_IsValid;

	private static IntPtr CheckoutLoadedAssetAndSave_FunctionAddress;

	private static int CheckoutLoadedAssetAndSave_ParamsSize;

	private static bool CheckoutLoadedAssetAndSave_DirtyMontage_IsValid;

	private static FFieldAddress CheckoutLoadedAssetAndSave_DirtyMontage_PropertyAddress;

	private static int CheckoutLoadedAssetAndSave_DirtyMontage_Offset;

	private static bool ChangeAnimSeqParamAndSave_IsValid;

	private static IntPtr ChangeAnimSeqParamAndSave_FunctionAddress;

	private static int ChangeAnimSeqParamAndSave_ParamsSize;

	private static bool ChangeAnimSeqParamAndSave_AnimMontage_IsValid;

	private static FFieldAddress ChangeAnimSeqParamAndSave_AnimMontage_PropertyAddress;

	private static int ChangeAnimSeqParamAndSave_AnimMontage_Offset;

	private static bool ChangeAnimSeqParamAndSave_bRootMotion_IsValid;

	private static FFieldAddress ChangeAnimSeqParamAndSave_bRootMotion_PropertyAddress;

	private static int ChangeAnimSeqParamAndSave_bRootMotion_Offset;

	private static bool ChangeAnimSeqParamAndSave_bForceRootLock_IsValid;

	private static FFieldAddress ChangeAnimSeqParamAndSave_bForceRootLock_PropertyAddress;

	private static int ChangeAnimSeqParamAndSave_bForceRootLock_Offset;

	private static bool ChangeAnimSeqParamAndSave_ReturnValue_IsValid;

	private static FFieldAddress ChangeAnimSeqParamAndSave_ReturnValue_PropertyAddress;

	private static int ChangeAnimSeqParamAndSave_ReturnValue_Offset;

	private static bool CalcSlotMontageLocalWeight_IsValid;

	private static IntPtr CalcSlotMontageLocalWeight_FunctionAddress;

	private static int CalcSlotMontageLocalWeight_ParamsSize;

	private static bool CalcSlotMontageLocalWeight_AnimInst_IsValid;

	private static FFieldAddress CalcSlotMontageLocalWeight_AnimInst_PropertyAddress;

	private static int CalcSlotMontageLocalWeight_AnimInst_Offset;

	private static bool CalcSlotMontageLocalWeight_SlotNodeName_IsValid;

	private static FFieldAddress CalcSlotMontageLocalWeight_SlotNodeName_PropertyAddress;

	private static int CalcSlotMontageLocalWeight_SlotNodeName_Offset;

	private static bool CalcSlotMontageLocalWeight_ReturnValue_IsValid;

	private static FFieldAddress CalcSlotMontageLocalWeight_ReturnValue_PropertyAddress;

	private static int CalcSlotMontageLocalWeight_ReturnValue_Offset;

	private static bool BlendSpaceValidateSampleData_IsValid;

	private static IntPtr BlendSpaceValidateSampleData_FunctionAddress;

	private static int BlendSpaceValidateSampleData_ParamsSize;

	private static bool BlendSpaceValidateSampleData_BlendSpace_IsValid;

	private static FFieldAddress BlendSpaceValidateSampleData_BlendSpace_PropertyAddress;

	private static int BlendSpaceValidateSampleData_BlendSpace_Offset;

	private static bool ASCopyNotifies_IsValid;

	private static IntPtr ASCopyNotifies_FunctionAddress;

	private static int ASCopyNotifies_ParamsSize;

	private static bool ASCopyNotifies_SourceAnimSeq_IsValid;

	private static FFieldAddress ASCopyNotifies_SourceAnimSeq_PropertyAddress;

	private static int ASCopyNotifies_SourceAnimSeq_Offset;

	private static bool ASCopyNotifies_DestAnimSeq_IsValid;

	private static FFieldAddress ASCopyNotifies_DestAnimSeq_PropertyAddress;

	private static int ASCopyNotifies_DestAnimSeq_Offset;

	private static bool ASCopyNotifies_bClearNotifiesInDestBeforeCopy_IsValid;

	private static FFieldAddress ASCopyNotifies_bClearNotifiesInDestBeforeCopy_PropertyAddress;

	private static int ASCopyNotifies_bClearNotifiesInDestBeforeCopy_Offset;

	private static bool ASCopyNotifies_bWithErrorInfo_IsValid;

	private static FFieldAddress ASCopyNotifies_bWithErrorInfo_PropertyAddress;

	private static int ASCopyNotifies_bWithErrorInfo_Offset;

	private static bool ASCopyNotifies_ReturnValue_IsValid;

	private static FFieldAddress ASCopyNotifies_ReturnValue_PropertyAddress;

	private static int ASCopyNotifies_ReturnValue_Offset;

	private static bool ApplyRadiusDamage_IsValid;

	private static IntPtr ApplyRadiusDamage_FunctionAddress;

	private static int ApplyRadiusDamage_ParamsSize;

	private static bool ApplyRadiusDamage_Destructible_IsValid;

	private static FFieldAddress ApplyRadiusDamage_Destructible_PropertyAddress;

	private static int ApplyRadiusDamage_Destructible_Offset;

	private static bool ApplyRadiusDamage_BaseDamage_IsValid;

	private static FFieldAddress ApplyRadiusDamage_BaseDamage_PropertyAddress;

	private static int ApplyRadiusDamage_BaseDamage_Offset;

	private static bool ApplyRadiusDamage_HurtOrigin_IsValid;

	private static FFieldAddress ApplyRadiusDamage_HurtOrigin_PropertyAddress;

	private static int ApplyRadiusDamage_HurtOrigin_Offset;

	private static bool ApplyRadiusDamage_DamageRadius_IsValid;

	private static FFieldAddress ApplyRadiusDamage_DamageRadius_PropertyAddress;

	private static int ApplyRadiusDamage_DamageRadius_Offset;

	private static bool ApplyRadiusDamage_ImpulseStrength_IsValid;

	private static FFieldAddress ApplyRadiusDamage_ImpulseStrength_PropertyAddress;

	private static int ApplyRadiusDamage_ImpulseStrength_Offset;

	private static bool ApplyRadiusDamage_bFullDamage_IsValid;

	private static FFieldAddress ApplyRadiusDamage_bFullDamage_PropertyAddress;

	private static int ApplyRadiusDamage_bFullDamage_Offset;

	private static bool ApplyDamage_IsValid;

	private static IntPtr ApplyDamage_FunctionAddress;

	private static int ApplyDamage_ParamsSize;

	private static bool ApplyDamage_Destructible_IsValid;

	private static FFieldAddress ApplyDamage_Destructible_PropertyAddress;

	private static int ApplyDamage_Destructible_Offset;

	private static bool ApplyDamage_DamageAmount_IsValid;

	private static FFieldAddress ApplyDamage_DamageAmount_PropertyAddress;

	private static int ApplyDamage_DamageAmount_Offset;

	private static bool ApplyDamage_HitLocation_IsValid;

	private static FFieldAddress ApplyDamage_HitLocation_PropertyAddress;

	private static int ApplyDamage_HitLocation_Offset;

	private static bool ApplyDamage_ImpulseDir_IsValid;

	private static FFieldAddress ApplyDamage_ImpulseDir_PropertyAddress;

	private static int ApplyDamage_ImpulseDir_Offset;

	private static bool ApplyDamage_ImpulseStrength_IsValid;

	private static FFieldAddress ApplyDamage_ImpulseStrength_PropertyAddress;

	private static int ApplyDamage_ImpulseStrength_Offset;

	private static bool AnimSequenceGetRootMotionRotationForScale_IsValid;

	private static IntPtr AnimSequenceGetRootMotionRotationForScale_FunctionAddress;

	private static int AnimSequenceGetRootMotionRotationForScale_ParamsSize;

	private static bool AnimSequenceGetRootMotionRotationForScale_AnimMontage_IsValid;

	private static FFieldAddress AnimSequenceGetRootMotionRotationForScale_AnimMontage_PropertyAddress;

	private static int AnimSequenceGetRootMotionRotationForScale_AnimMontage_Offset;

	private static bool AnimSequenceGetRootMotionRotationForScale_OutStartPos_IsValid;

	private static FFieldAddress AnimSequenceGetRootMotionRotationForScale_OutStartPos_PropertyAddress;

	private static int AnimSequenceGetRootMotionRotationForScale_OutStartPos_Offset;

	private static bool AnimSequenceGetRootMotionRotationForScale_OutEndPos_IsValid;

	private static FFieldAddress AnimSequenceGetRootMotionRotationForScale_OutEndPos_PropertyAddress;

	private static int AnimSequenceGetRootMotionRotationForScale_OutEndPos_Offset;

	private static bool AnimSequenceGetRootMotionRotationForScale_LeftScaleTime_IsValid;

	private static FFieldAddress AnimSequenceGetRootMotionRotationForScale_LeftScaleTime_PropertyAddress;

	private static int AnimSequenceGetRootMotionRotationForScale_LeftScaleTime_Offset;

	private static bool AnimSequenceGetRootMotionRotationForScale_RightScaleTime_IsValid;

	private static FFieldAddress AnimSequenceGetRootMotionRotationForScale_RightScaleTime_PropertyAddress;

	private static int AnimSequenceGetRootMotionRotationForScale_RightScaleTime_Offset;

	private static bool AnimSequenceGetRootMotionRotationForScale_ReturnValue_IsValid;

	private static FFieldAddress AnimSequenceGetRootMotionRotationForScale_ReturnValue_PropertyAddress;

	private static int AnimSequenceGetRootMotionRotationForScale_ReturnValue_Offset;

	private static bool AnimSequenceGetRootMotionLocationForScale_IsValid;

	private static IntPtr AnimSequenceGetRootMotionLocationForScale_FunctionAddress;

	private static int AnimSequenceGetRootMotionLocationForScale_ParamsSize;

	private static bool AnimSequenceGetRootMotionLocationForScale_AnimMontage_IsValid;

	private static FFieldAddress AnimSequenceGetRootMotionLocationForScale_AnimMontage_PropertyAddress;

	private static int AnimSequenceGetRootMotionLocationForScale_AnimMontage_Offset;

	private static bool AnimSequenceGetRootMotionLocationForScale_OutStartPos_IsValid;

	private static FFieldAddress AnimSequenceGetRootMotionLocationForScale_OutStartPos_PropertyAddress;

	private static int AnimSequenceGetRootMotionLocationForScale_OutStartPos_Offset;

	private static bool AnimSequenceGetRootMotionLocationForScale_OutEndPos_IsValid;

	private static FFieldAddress AnimSequenceGetRootMotionLocationForScale_OutEndPos_PropertyAddress;

	private static int AnimSequenceGetRootMotionLocationForScale_OutEndPos_Offset;

	private static bool AnimSequenceGetRootMotionLocationForScale_LeftScaleTime_IsValid;

	private static FFieldAddress AnimSequenceGetRootMotionLocationForScale_LeftScaleTime_PropertyAddress;

	private static int AnimSequenceGetRootMotionLocationForScale_LeftScaleTime_Offset;

	private static bool AnimSequenceGetRootMotionLocationForScale_RightScaleTime_IsValid;

	private static FFieldAddress AnimSequenceGetRootMotionLocationForScale_RightScaleTime_PropertyAddress;

	private static int AnimSequenceGetRootMotionLocationForScale_RightScaleTime_Offset;

	private static bool AnimSequenceGetRootMotionLocationForScale_ReturnValue_IsValid;

	private static FFieldAddress AnimSequenceGetRootMotionLocationForScale_ReturnValue_PropertyAddress;

	private static int AnimSequenceGetRootMotionLocationForScale_ReturnValue_Offset;

	private static bool AnimSequenceFindPosWithDistanceCurve_IsValid;

	private static IntPtr AnimSequenceFindPosWithDistanceCurve_FunctionAddress;

	private static int AnimSequenceFindPosWithDistanceCurve_ParamsSize;

	private static bool AnimSequenceFindPosWithDistanceCurve_AnimationSequence_IsValid;

	private static FFieldAddress AnimSequenceFindPosWithDistanceCurve_AnimationSequence_PropertyAddress;

	private static int AnimSequenceFindPosWithDistanceCurve_AnimationSequence_Offset;

	private static bool AnimSequenceFindPosWithDistanceCurve_CurveName_IsValid;

	private static FFieldAddress AnimSequenceFindPosWithDistanceCurve_CurveName_PropertyAddress;

	private static int AnimSequenceFindPosWithDistanceCurve_CurveName_Offset;

	private static bool AnimSequenceFindPosWithDistanceCurve_DistanceValue_IsValid;

	private static FFieldAddress AnimSequenceFindPosWithDistanceCurve_DistanceValue_PropertyAddress;

	private static int AnimSequenceFindPosWithDistanceCurve_DistanceValue_Offset;

	private static bool AnimSequenceFindPosWithDistanceCurve_ReturnValue_IsValid;

	private static FFieldAddress AnimSequenceFindPosWithDistanceCurve_ReturnValue_PropertyAddress;

	private static int AnimSequenceFindPosWithDistanceCurve_ReturnValue_Offset;

	private static bool AnimMontageGetSocketLocationForScale_IsValid;

	private static IntPtr AnimMontageGetSocketLocationForScale_FunctionAddress;

	private static int AnimMontageGetSocketLocationForScale_ParamsSize;

	private static bool AnimMontageGetSocketLocationForScale_AnimMontage_IsValid;

	private static FFieldAddress AnimMontageGetSocketLocationForScale_AnimMontage_PropertyAddress;

	private static int AnimMontageGetSocketLocationForScale_AnimMontage_Offset;

	private static bool AnimMontageGetSocketLocationForScale_OutEndPos_IsValid;

	private static FFieldAddress AnimMontageGetSocketLocationForScale_OutEndPos_PropertyAddress;

	private static int AnimMontageGetSocketLocationForScale_OutEndPos_Offset;

	private static bool AnimMontageGetSocketLocationForScale_ScaleTime_IsValid;

	private static FFieldAddress AnimMontageGetSocketLocationForScale_ScaleTime_PropertyAddress;

	private static int AnimMontageGetSocketLocationForScale_ScaleTime_Offset;

	private static bool AnimMontageGetSocketLocationForScale_SocketName_IsValid;

	private static FFieldAddress AnimMontageGetSocketLocationForScale_SocketName_PropertyAddress;

	private static int AnimMontageGetSocketLocationForScale_SocketName_Offset;

	private static bool AnimMontageGetSocketLocationForScale_ReturnValue_IsValid;

	private static FFieldAddress AnimMontageGetSocketLocationForScale_ReturnValue_PropertyAddress;

	private static int AnimMontageGetSocketLocationForScale_ReturnValue_Offset;

	private static bool AnimMontageGetRootMotionRotationForScale_IsValid;

	private static IntPtr AnimMontageGetRootMotionRotationForScale_FunctionAddress;

	private static int AnimMontageGetRootMotionRotationForScale_ParamsSize;

	private static bool AnimMontageGetRootMotionRotationForScale_AnimMontage_IsValid;

	private static FFieldAddress AnimMontageGetRootMotionRotationForScale_AnimMontage_PropertyAddress;

	private static int AnimMontageGetRootMotionRotationForScale_AnimMontage_Offset;

	private static bool AnimMontageGetRootMotionRotationForScale_OutStartRotation_IsValid;

	private static FFieldAddress AnimMontageGetRootMotionRotationForScale_OutStartRotation_PropertyAddress;

	private static int AnimMontageGetRootMotionRotationForScale_OutStartRotation_Offset;

	private static bool AnimMontageGetRootMotionRotationForScale_OutEndRotation_IsValid;

	private static FFieldAddress AnimMontageGetRootMotionRotationForScale_OutEndRotation_PropertyAddress;

	private static int AnimMontageGetRootMotionRotationForScale_OutEndRotation_Offset;

	private static bool AnimMontageGetRootMotionRotationForScale_LeftScaleTime_IsValid;

	private static FFieldAddress AnimMontageGetRootMotionRotationForScale_LeftScaleTime_PropertyAddress;

	private static int AnimMontageGetRootMotionRotationForScale_LeftScaleTime_Offset;

	private static bool AnimMontageGetRootMotionRotationForScale_RightScaleTime_IsValid;

	private static FFieldAddress AnimMontageGetRootMotionRotationForScale_RightScaleTime_PropertyAddress;

	private static int AnimMontageGetRootMotionRotationForScale_RightScaleTime_Offset;

	private static bool AnimMontageGetRootMotionRotationForScale_ReturnValue_IsValid;

	private static FFieldAddress AnimMontageGetRootMotionRotationForScale_ReturnValue_PropertyAddress;

	private static int AnimMontageGetRootMotionRotationForScale_ReturnValue_Offset;

	private static bool AnimMontageGetRootMotionLocationForScale_IsValid;

	private static IntPtr AnimMontageGetRootMotionLocationForScale_FunctionAddress;

	private static int AnimMontageGetRootMotionLocationForScale_ParamsSize;

	private static bool AnimMontageGetRootMotionLocationForScale_AnimMontage_IsValid;

	private static FFieldAddress AnimMontageGetRootMotionLocationForScale_AnimMontage_PropertyAddress;

	private static int AnimMontageGetRootMotionLocationForScale_AnimMontage_Offset;

	private static bool AnimMontageGetRootMotionLocationForScale_OutStartPos_IsValid;

	private static FFieldAddress AnimMontageGetRootMotionLocationForScale_OutStartPos_PropertyAddress;

	private static int AnimMontageGetRootMotionLocationForScale_OutStartPos_Offset;

	private static bool AnimMontageGetRootMotionLocationForScale_OutEndPos_IsValid;

	private static FFieldAddress AnimMontageGetRootMotionLocationForScale_OutEndPos_PropertyAddress;

	private static int AnimMontageGetRootMotionLocationForScale_OutEndPos_Offset;

	private static bool AnimMontageGetRootMotionLocationForScale_LeftScaleTime_IsValid;

	private static FFieldAddress AnimMontageGetRootMotionLocationForScale_LeftScaleTime_PropertyAddress;

	private static int AnimMontageGetRootMotionLocationForScale_LeftScaleTime_Offset;

	private static bool AnimMontageGetRootMotionLocationForScale_RightScaleTime_IsValid;

	private static FFieldAddress AnimMontageGetRootMotionLocationForScale_RightScaleTime_PropertyAddress;

	private static int AnimMontageGetRootMotionLocationForScale_RightScaleTime_Offset;

	private static bool AnimMontageGetRootMotionLocationForScale_ReturnValue_IsValid;

	private static FFieldAddress AnimMontageGetRootMotionLocationForScale_ReturnValue_PropertyAddress;

	private static int AnimMontageGetRootMotionLocationForScale_ReturnValue_Offset;

	private static bool AnimMontageGetQTEBoneTransform_IsValid;

	private static IntPtr AnimMontageGetQTEBoneTransform_FunctionAddress;

	private static int AnimMontageGetQTEBoneTransform_ParamsSize;

	private static bool AnimMontageGetQTEBoneTransform_AnimMontage_IsValid;

	private static FFieldAddress AnimMontageGetQTEBoneTransform_AnimMontage_PropertyAddress;

	private static int AnimMontageGetQTEBoneTransform_AnimMontage_Offset;

	private static bool AnimMontageGetQTEBoneTransform_MeshComponent_IsValid;

	private static FFieldAddress AnimMontageGetQTEBoneTransform_MeshComponent_PropertyAddress;

	private static int AnimMontageGetQTEBoneTransform_MeshComponent_Offset;

	private static bool AnimMontageGetQTEBoneTransform_BoneName_IsValid;

	private static FFieldAddress AnimMontageGetQTEBoneTransform_BoneName_PropertyAddress;

	private static int AnimMontageGetQTEBoneTransform_BoneName_Offset;

	private static bool AnimMontageGetQTEBoneTransform_Pos_IsValid;

	private static FFieldAddress AnimMontageGetQTEBoneTransform_Pos_PropertyAddress;

	private static int AnimMontageGetQTEBoneTransform_Pos_Offset;

	private static bool AnimMontageGetQTEBoneTransform_ReturnValue_IsValid;

	private static FFieldAddress AnimMontageGetQTEBoneTransform_ReturnValue_PropertyAddress;

	private static int AnimMontageGetQTEBoneTransform_ReturnValue_Offset;

	private static bool AnimMontageGetMontageEndTimeForScale_IsValid;

	private static IntPtr AnimMontageGetMontageEndTimeForScale_FunctionAddress;

	private static int AnimMontageGetMontageEndTimeForScale_ParamsSize;

	private static bool AnimMontageGetMontageEndTimeForScale_AnimMontage_IsValid;

	private static FFieldAddress AnimMontageGetMontageEndTimeForScale_AnimMontage_PropertyAddress;

	private static int AnimMontageGetMontageEndTimeForScale_AnimMontage_Offset;

	private static bool AnimMontageGetMontageEndTimeForScale_ReturnValue_IsValid;

	private static FFieldAddress AnimMontageGetMontageEndTimeForScale_ReturnValue_PropertyAddress;

	private static int AnimMontageGetMontageEndTimeForScale_ReturnValue_Offset;

	private static bool AnimMontageGetBoneTransformWS_IsValid;

	private static IntPtr AnimMontageGetBoneTransformWS_FunctionAddress;

	private static int AnimMontageGetBoneTransformWS_ParamsSize;

	private static bool AnimMontageGetBoneTransformWS_AnimMontage_IsValid;

	private static FFieldAddress AnimMontageGetBoneTransformWS_AnimMontage_PropertyAddress;

	private static int AnimMontageGetBoneTransformWS_AnimMontage_Offset;

	private static bool AnimMontageGetBoneTransformWS_MeshComponent_IsValid;

	private static FFieldAddress AnimMontageGetBoneTransformWS_MeshComponent_PropertyAddress;

	private static int AnimMontageGetBoneTransformWS_MeshComponent_Offset;

	private static bool AnimMontageGetBoneTransformWS_BoneName_IsValid;

	private static FFieldAddress AnimMontageGetBoneTransformWS_BoneName_PropertyAddress;

	private static int AnimMontageGetBoneTransformWS_BoneName_Offset;

	private static bool AnimMontageGetBoneTransformWS_Pos_IsValid;

	private static FFieldAddress AnimMontageGetBoneTransformWS_Pos_PropertyAddress;

	private static int AnimMontageGetBoneTransformWS_Pos_Offset;

	private static bool AnimMontageGetBoneTransformWS_IsNeedFixRotator_IsValid;

	private static FFieldAddress AnimMontageGetBoneTransformWS_IsNeedFixRotator_PropertyAddress;

	private static int AnimMontageGetBoneTransformWS_IsNeedFixRotator_Offset;

	private static bool AnimMontageGetBoneTransformWS_FixRotator_IsValid;

	private static FFieldAddress AnimMontageGetBoneTransformWS_FixRotator_PropertyAddress;

	private static int AnimMontageGetBoneTransformWS_FixRotator_Offset;

	private static bool AnimMontageGetBoneTransformWS_ReturnValue_IsValid;

	private static FFieldAddress AnimMontageGetBoneTransformWS_ReturnValue_PropertyAddress;

	private static int AnimMontageGetBoneTransformWS_ReturnValue_Offset;

	private static bool AnimMontageGetBlendInAndOutTime_IsValid;

	private static IntPtr AnimMontageGetBlendInAndOutTime_FunctionAddress;

	private static int AnimMontageGetBlendInAndOutTime_ParamsSize;

	private static bool AnimMontageGetBlendInAndOutTime_AnimMontage_IsValid;

	private static FFieldAddress AnimMontageGetBlendInAndOutTime_AnimMontage_PropertyAddress;

	private static int AnimMontageGetBlendInAndOutTime_AnimMontage_Offset;

	private static bool AnimMontageGetBlendInAndOutTime_BlendInTime_IsValid;

	private static FFieldAddress AnimMontageGetBlendInAndOutTime_BlendInTime_PropertyAddress;

	private static int AnimMontageGetBlendInAndOutTime_BlendInTime_Offset;

	private static bool AnimMontageGetBlendInAndOutTime_BlendOutTime_IsValid;

	private static FFieldAddress AnimMontageGetBlendInAndOutTime_BlendOutTime_PropertyAddress;

	private static int AnimMontageGetBlendInAndOutTime_BlendOutTime_Offset;

	private static bool AnimInstanceMontageSetPos_IsValid;

	private static IntPtr AnimInstanceMontageSetPos_FunctionAddress;

	private static int AnimInstanceMontageSetPos_ParamsSize;

	private static bool AnimInstanceMontageSetPos_AnimInst_IsValid;

	private static FFieldAddress AnimInstanceMontageSetPos_AnimInst_PropertyAddress;

	private static int AnimInstanceMontageSetPos_AnimInst_Offset;

	private static bool AnimInstanceMontageSetPos_MontagePos_IsValid;

	private static FFieldAddress AnimInstanceMontageSetPos_MontagePos_PropertyAddress;

	private static int AnimInstanceMontageSetPos_MontagePos_Offset;

	private static bool AMCopyNotifies_IsValid;

	private static IntPtr AMCopyNotifies_FunctionAddress;

	private static int AMCopyNotifies_ParamsSize;

	private static bool AMCopyNotifies_SourceAnimMontage_IsValid;

	private static FFieldAddress AMCopyNotifies_SourceAnimMontage_PropertyAddress;

	private static int AMCopyNotifies_SourceAnimMontage_Offset;

	private static bool AMCopyNotifies_DestAnimMontage_IsValid;

	private static FFieldAddress AMCopyNotifies_DestAnimMontage_PropertyAddress;

	private static int AMCopyNotifies_DestAnimMontage_Offset;

	private static bool AMCopyNotifies_bClearNotifiesInDestBeforeCopy_IsValid;

	private static FFieldAddress AMCopyNotifies_bClearNotifiesInDestBeforeCopy_PropertyAddress;

	private static int AMCopyNotifies_bClearNotifiesInDestBeforeCopy_Offset;

	private static bool AMCopyNotifies_bWithErrorInfo_IsValid;

	private static FFieldAddress AMCopyNotifies_bWithErrorInfo_PropertyAddress;

	private static int AMCopyNotifies_bWithErrorInfo_Offset;

	private static bool AMCopyNotifies_ReturnValue_IsValid;

	private static FFieldAddress AMCopyNotifies_ReturnValue_PropertyAddress;

	private static int AMCopyNotifies_ReturnValue_Offset;

	private static bool AMCopyBlendOption_IsValid;

	private static IntPtr AMCopyBlendOption_FunctionAddress;

	private static int AMCopyBlendOption_ParamsSize;

	private static bool AMCopyBlendOption_SourceAnimMontage_IsValid;

	private static FFieldAddress AMCopyBlendOption_SourceAnimMontage_PropertyAddress;

	private static int AMCopyBlendOption_SourceAnimMontage_Offset;

	private static bool AMCopyBlendOption_DestAnimMontage_IsValid;

	private static FFieldAddress AMCopyBlendOption_DestAnimMontage_PropertyAddress;

	private static int AMCopyBlendOption_DestAnimMontage_Offset;

	private static bool AMCopyBlendOption_ReturnValue_IsValid;

	private static FFieldAddress AMCopyBlendOption_ReturnValue_PropertyAddress;

	private static int AMCopyBlendOption_ReturnValue_Offset;

	private static bool AddUVChannel_IsValid;

	private static IntPtr AddUVChannel_FunctionAddress;

	private static int AddUVChannel_ParamsSize;

	private static bool AddUVChannel_StaticMesh_IsValid;

	private static FFieldAddress AddUVChannel_StaticMesh_PropertyAddress;

	private static int AddUVChannel_StaticMesh_Offset;

	private static bool AddUVChannel_LODIndex_IsValid;

	private static FFieldAddress AddUVChannel_LODIndex_PropertyAddress;

	private static int AddUVChannel_LODIndex_Offset;

	private static bool AddUVChannel_ReturnValue_IsValid;

	private static FFieldAddress AddUVChannel_ReturnValue_PropertyAddress;

	private static int AddUVChannel_ReturnValue_Offset;

	private static bool AddSocketToSkeleton_IsValid;

	private static IntPtr AddSocketToSkeleton_FunctionAddress;

	private static int AddSocketToSkeleton_ParamsSize;

	private static bool AddSocketToSkeleton_InUSkeleton_IsValid;

	private static FFieldAddress AddSocketToSkeleton_InUSkeleton_PropertyAddress;

	private static int AddSocketToSkeleton_InUSkeleton_Offset;

	private static bool AddSocketToSkeleton_BoneName_IsValid;

	private static FFieldAddress AddSocketToSkeleton_BoneName_PropertyAddress;

	private static int AddSocketToSkeleton_BoneName_Offset;

	private static bool AddSocketToSkeleton_SocketName_IsValid;

	private static FFieldAddress AddSocketToSkeleton_SocketName_PropertyAddress;

	private static int AddSocketToSkeleton_SocketName_Offset;

	private static bool AddSocketToSkeleton_Offset_IsValid;

	private static FFieldAddress AddSocketToSkeleton_Offset_PropertyAddress;

	private static int AddSocketToSkeleton_Offset_Offset;

	private static bool AddSocketToSkeleton_ReturnValue_IsValid;

	private static FFieldAddress AddSocketToSkeleton_ReturnValue_PropertyAddress;

	private static int AddSocketToSkeleton_ReturnValue_Offset;

	private static bool AddPreviewAssetToSkeleton_IsValid;

	private static IntPtr AddPreviewAssetToSkeleton_FunctionAddress;

	private static int AddPreviewAssetToSkeleton_ParamsSize;

	private static bool AddPreviewAssetToSkeleton_InUSkeleton_IsValid;

	private static FFieldAddress AddPreviewAssetToSkeleton_InUSkeleton_PropertyAddress;

	private static int AddPreviewAssetToSkeleton_InUSkeleton_Offset;

	private static bool AddPreviewAssetToSkeleton_BoneName_IsValid;

	private static FFieldAddress AddPreviewAssetToSkeleton_BoneName_PropertyAddress;

	private static int AddPreviewAssetToSkeleton_BoneName_Offset;

	private static bool AddPreviewAssetToSkeleton_PreviewAsset_IsValid;

	private static FFieldAddress AddPreviewAssetToSkeleton_PreviewAsset_PropertyAddress;

	private static int AddPreviewAssetToSkeleton_PreviewAsset_Offset;

	private static bool AddPreviewAssetToSkeleton_ReturnValue_IsValid;

	private static FFieldAddress AddPreviewAssetToSkeleton_ReturnValue_PropertyAddress;

	private static int AddPreviewAssetToSkeleton_ReturnValue_Offset;

	private static bool AddPoint_IsValid;

	private static IntPtr AddPoint_FunctionAddress;

	private static int AddPoint_ParamsSize;

	private static bool AddPoint_BlendSpace_IsValid;

	private static FFieldAddress AddPoint_BlendSpace_PropertyAddress;

	private static int AddPoint_BlendSpace_Offset;

	private static bool AddPoint_PointSequence_IsValid;

	private static FFieldAddress AddPoint_PointSequence_PropertyAddress;

	private static int AddPoint_PointSequence_Offset;

	private static bool AddPoint_PointValue_IsValid;

	private static FFieldAddress AddPoint_PointValue_PropertyAddress;

	private static int AddPoint_PointValue_Offset;

	private static bool AddPoint_ReturnValue_IsValid;

	private static FFieldAddress AddPoint_ReturnValue_PropertyAddress;

	private static int AddPoint_ReturnValue_Offset;

	private static bool AddAnimSequence_IsValid;

	private static IntPtr AddAnimSequence_FunctionAddress;

	private static int AddAnimSequence_ParamsSize;

	private static bool AddAnimSequence_TargetMontage_IsValid;

	private static FFieldAddress AddAnimSequence_TargetMontage_PropertyAddress;

	private static int AddAnimSequence_TargetMontage_Offset;

	private static bool AddAnimSequence_Sequence_IsValid;

	private static FFieldAddress AddAnimSequence_Sequence_PropertyAddress;

	private static int AddAnimSequence_Sequence_Offset;

	private static bool AddAnimSequence_ReturnValue_IsValid;

	private static FFieldAddress AddAnimSequence_ReturnValue_PropertyAddress;

	private static int AddAnimSequence_ReturnValue_Offset;

	private static bool AddAnimationNotifyStateEvent_IsValid;

	private static IntPtr AddAnimationNotifyStateEvent_FunctionAddress;

	private static int AddAnimationNotifyStateEvent_ParamsSize;

	private static bool AddAnimationNotifyStateEvent_AnimBase_IsValid;

	private static FFieldAddress AddAnimationNotifyStateEvent_AnimBase_PropertyAddress;

	private static int AddAnimationNotifyStateEvent_AnimBase_Offset;

	private static bool AddAnimationNotifyStateEvent_NotifyTrackName_IsValid;

	private static FFieldAddress AddAnimationNotifyStateEvent_NotifyTrackName_PropertyAddress;

	private static int AddAnimationNotifyStateEvent_NotifyTrackName_Offset;

	private static bool AddAnimationNotifyStateEvent_StartTime_IsValid;

	private static FFieldAddress AddAnimationNotifyStateEvent_StartTime_PropertyAddress;

	private static int AddAnimationNotifyStateEvent_StartTime_Offset;

	private static bool AddAnimationNotifyStateEvent_Duration_IsValid;

	private static FFieldAddress AddAnimationNotifyStateEvent_Duration_PropertyAddress;

	private static int AddAnimationNotifyStateEvent_Duration_Offset;

	private static bool AddAnimationNotifyStateEvent_NotifyStateClass_IsValid;

	private static FFieldAddress AddAnimationNotifyStateEvent_NotifyStateClass_PropertyAddress;

	private static int AddAnimationNotifyStateEvent_NotifyStateClass_Offset;

	private static bool AddAnimationNotifyStateEvent_ReturnValue_IsValid;

	private static FFieldAddress AddAnimationNotifyStateEvent_ReturnValue_PropertyAddress;

	private static int AddAnimationNotifyStateEvent_ReturnValue_Offset;

	private static bool AddAnimationNotifyEvent_IsValid;

	private static IntPtr AddAnimationNotifyEvent_FunctionAddress;

	private static int AddAnimationNotifyEvent_ParamsSize;

	private static bool AddAnimationNotifyEvent_AnimationSequenceBase_IsValid;

	private static FFieldAddress AddAnimationNotifyEvent_AnimationSequenceBase_PropertyAddress;

	private static int AddAnimationNotifyEvent_AnimationSequenceBase_Offset;

	private static bool AddAnimationNotifyEvent_NotifyTrackName_IsValid;

	private static FFieldAddress AddAnimationNotifyEvent_NotifyTrackName_PropertyAddress;

	private static int AddAnimationNotifyEvent_NotifyTrackName_Offset;

	private static bool AddAnimationNotifyEvent_StartTime_IsValid;

	private static FFieldAddress AddAnimationNotifyEvent_StartTime_PropertyAddress;

	private static int AddAnimationNotifyEvent_StartTime_Offset;

	private static bool AddAnimationNotifyEvent_NotifyClass_IsValid;

	private static FFieldAddress AddAnimationNotifyEvent_NotifyClass_PropertyAddress;

	private static int AddAnimationNotifyEvent_NotifyClass_Offset;

	private static bool AddAnimationNotifyEvent_ReturnValue_IsValid;

	private static FFieldAddress AddAnimationNotifyEvent_ReturnValue_PropertyAddress;

	private static int AddAnimationNotifyEvent_ReturnValue_Offset;

	private static bool ABPStateMachineGetGlobalWeight_IsValid;

	private static IntPtr ABPStateMachineGetGlobalWeight_FunctionAddress;

	private static int ABPStateMachineGetGlobalWeight_ParamsSize;

	private static bool ABPStateMachineGetGlobalWeight_AnimInst_IsValid;

	private static FFieldAddress ABPStateMachineGetGlobalWeight_AnimInst_PropertyAddress;

	private static int ABPStateMachineGetGlobalWeight_AnimInst_Offset;

	private static bool ABPStateMachineGetGlobalWeight_StateMachineName_IsValid;

	private static FFieldAddress ABPStateMachineGetGlobalWeight_StateMachineName_PropertyAddress;

	private static int ABPStateMachineGetGlobalWeight_StateMachineName_Offset;

	private static bool ABPStateMachineGetGlobalWeight_StateName_IsValid;

	private static FFieldAddress ABPStateMachineGetGlobalWeight_StateName_PropertyAddress;

	private static int ABPStateMachineGetGlobalWeight_StateName_Offset;

	private static bool ABPStateMachineGetGlobalWeight_ReturnValue_IsValid;

	private static FFieldAddress ABPStateMachineGetGlobalWeight_ReturnValue_PropertyAddress;

	private static int ABPStateMachineGetGlobalWeight_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:TickAnimationAndRefreshBone_SkeletalMesh")]
	public unsafe static void TickAnimationAndRefreshBone_SkeletalMesh(USkeletalMeshComponent SkeletalMeshComp)
	{
		if (!TickAnimationAndRefreshBone_SkeletalMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:TickAnimationAndRefreshBone_SkeletalMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TickAnimationAndRefreshBone_SkeletalMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TickAnimationAndRefreshBone_SkeletalMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, TickAnimationAndRefreshBone_SkeletalMesh_SkeletalMeshComp_Offset), 0, TickAnimationAndRefreshBone_SkeletalMesh_SkeletalMeshComp_PropertyAddress.Address, SkeletalMeshComp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TickAnimationAndRefreshBone_SkeletalMesh_FunctionAddress, intPtr, TickAnimationAndRefreshBone_SkeletalMesh_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:TickAnimationAndRefreshBone")]
	public unsafe static void TickAnimationAndRefreshBone(AActor Owner)
	{
		if (!TickAnimationAndRefreshBone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:TickAnimationAndRefreshBone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TickAnimationAndRefreshBone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TickAnimationAndRefreshBone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, TickAnimationAndRefreshBone_Owner_Offset), 0, TickAnimationAndRefreshBone_Owner_PropertyAddress.Address, Owner);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TickAnimationAndRefreshBone_FunctionAddress, intPtr, TickAnimationAndRefreshBone_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:TickAnimation")]
	public unsafe static void TickAnimation(AActor Owner)
	{
		if (!TickAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:TickAnimation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TickAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TickAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, TickAnimation_Owner_Offset), 0, TickAnimation_Owner_PropertyAddress.Address, Owner);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TickAnimation_FunctionAddress, intPtr, TickAnimation_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:StopAllMontages")]
	public unsafe static void StopAllMontages(AActor Owner, float BlendOutTime)
	{
		if (!StopAllMontages_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:StopAllMontages");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAllMontages_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAllMontages_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, StopAllMontages_Owner_Offset), 0, StopAllMontages_Owner_PropertyAddress.Address, Owner);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StopAllMontages_BlendOutTime_Offset), 0, StopAllMontages_BlendOutTime_PropertyAddress.Address, BlendOutTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StopAllMontages_FunctionAddress, intPtr, StopAllMontages_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:SkeletonCopySockets")]
	public unsafe static bool SkeletonCopySockets(USkeleton SourceSkeletal, USkeleton DestSkeletal, float LocationScaleRate = 1f)
	{
		if (!SkeletonCopySockets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:SkeletonCopySockets");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SkeletonCopySockets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SkeletonCopySockets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, SkeletonCopySockets_SourceSkeletal_Offset), 0, SkeletonCopySockets_SourceSkeletal_PropertyAddress.Address, SourceSkeletal);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, SkeletonCopySockets_DestSkeletal_Offset), 0, SkeletonCopySockets_DestSkeletal_PropertyAddress.Address, DestSkeletal);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SkeletonCopySockets_LocationScaleRate_Offset), 0, SkeletonCopySockets_LocationScaleRate_PropertyAddress.Address, LocationScaleRate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SkeletonCopySockets_FunctionAddress, intPtr, SkeletonCopySockets_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SkeletonCopySockets_ReturnValue_Offset), 0, SkeletonCopySockets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:SetUV")]
	public unsafe static bool SetUV(UStaticMesh StaticMesh, int LODIndex, int UVChannelIndex, List<FVector2D> BoneWeight)
	{
		if (!SetUV_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:SetUV");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUV_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUV_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetUV_StaticMesh_Offset), 0, SetUV_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetUV_LODIndex_Offset), 0, SetUV_LODIndex_PropertyAddress.Address, LODIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetUV_UVChannelIndex_Offset), 0, SetUV_UVChannelIndex_PropertyAddress.Address, UVChannelIndex);
		new TArrayCopyMarshaler<FVector2D>(1, SetUV_BoneWeight_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, SetUV_BoneWeight_Offset), BoneWeight);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetUV_FunctionAddress, intPtr, SetUV_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetUV_BoneWeight_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetUV_ReturnValue_Offset), 0, SetUV_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:SetRootMotionFromEverythingSwitch")]
	public unsafe static void SetRootMotionFromEverythingSwitch(ACharacter Character, bool IsOpen)
	{
		if (!SetRootMotionFromEverythingSwitch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:SetRootMotionFromEverythingSwitch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRootMotionFromEverythingSwitch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRootMotionFromEverythingSwitch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, SetRootMotionFromEverythingSwitch_Character_Offset), 0, SetRootMotionFromEverythingSwitch_Character_PropertyAddress.Address, Character);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRootMotionFromEverythingSwitch_IsOpen_Offset), 0, SetRootMotionFromEverythingSwitch_IsOpen_PropertyAddress.Address, IsOpen);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRootMotionFromEverythingSwitch_FunctionAddress, intPtr, SetRootMotionFromEverythingSwitch_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:SetMaterial")]
	public unsafe static void SetMaterial(UMaterialInterface Material, UDestructibleMesh TargetMesh, int Index)
	{
		if (!SetMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:SetMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetMaterial_Material_Offset), 0, SetMaterial_Material_PropertyAddress.Address, Material);
		UObjectMarshaler<UDestructibleMesh>.ToNative(IntPtr.Add(intPtr, SetMaterial_TargetMesh_Offset), 0, SetMaterial_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMaterial_Index_Offset), 0, SetMaterial_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMaterial_FunctionAddress, intPtr, SetMaterial_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:SetBlendSpaceInput")]
	public unsafe static void SetBlendSpaceInput(USkeletalMeshComponent obj, FVector BlendParams)
	{
		if (!SetBlendSpaceInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:SetBlendSpaceInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBlendSpaceInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBlendSpaceInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, SetBlendSpaceInput_obj_Offset), 0, SetBlendSpaceInput_obj_PropertyAddress.Address, obj);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetBlendSpaceInput_BlendParams_Offset), 0, SetBlendSpaceInput_BlendParams_PropertyAddress.Address, BlendParams);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBlendSpaceInput_FunctionAddress, intPtr, SetBlendSpaceInput_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:SetAnimcurveType")]
	public unsafe static bool SetAnimcurveType(USkeleton Skeleton, string CurveName, bool Value)
	{
		if (!SetAnimcurveType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:SetAnimcurveType");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimcurveType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimcurveType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, SetAnimcurveType_Skeleton_Offset), 0, SetAnimcurveType_Skeleton_PropertyAddress.Address, Skeleton);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetAnimcurveType_CurveName_Offset), 0, SetAnimcurveType_CurveName_PropertyAddress.Address, CurveName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAnimcurveType_Value_Offset), 0, SetAnimcurveType_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAnimcurveType_FunctionAddress, intPtr, SetAnimcurveType_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetAnimcurveType_CurveName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetAnimcurveType_ReturnValue_Offset), 0, SetAnimcurveType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:SetAnimationNotifyStartTime")]
	public unsafe static bool SetAnimationNotifyStartTime(UAnimMontage InAnimMontage, string InGuid, float StartTime)
	{
		if (!SetAnimationNotifyStartTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:SetAnimationNotifyStartTime");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimationNotifyStartTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimationNotifyStartTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, SetAnimationNotifyStartTime_InAnimMontage_Offset), 0, SetAnimationNotifyStartTime_InAnimMontage_PropertyAddress.Address, InAnimMontage);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetAnimationNotifyStartTime_InGuid_Offset), 0, SetAnimationNotifyStartTime_InGuid_PropertyAddress.Address, InGuid);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAnimationNotifyStartTime_StartTime_Offset), 0, SetAnimationNotifyStartTime_StartTime_PropertyAddress.Address, StartTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAnimationNotifyStartTime_FunctionAddress, intPtr, SetAnimationNotifyStartTime_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetAnimationNotifyStartTime_InGuid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetAnimationNotifyStartTime_ReturnValue_Offset), 0, SetAnimationNotifyStartTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:SetAnimationNotifyDuration")]
	public unsafe static bool SetAnimationNotifyDuration(UAnimMontage InAnimMontage, string InGuid, float Duration)
	{
		if (!SetAnimationNotifyDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:SetAnimationNotifyDuration");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimationNotifyDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimationNotifyDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, SetAnimationNotifyDuration_InAnimMontage_Offset), 0, SetAnimationNotifyDuration_InAnimMontage_PropertyAddress.Address, InAnimMontage);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetAnimationNotifyDuration_InGuid_Offset), 0, SetAnimationNotifyDuration_InGuid_PropertyAddress.Address, InGuid);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAnimationNotifyDuration_Duration_Offset), 0, SetAnimationNotifyDuration_Duration_PropertyAddress.Address, Duration);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAnimationNotifyDuration_FunctionAddress, intPtr, SetAnimationNotifyDuration_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetAnimationNotifyDuration_InGuid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetAnimationNotifyDuration_ReturnValue_Offset), 0, SetAnimationNotifyDuration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:Sequence_GetRelativeBoneTransformCS")]
	public unsafe static FTransform Sequence_GetRelativeBoneTransformCS(UAnimSequence AnimSeq, float InTime, FName BoneName, bool bExtractRootMotion = false)
	{
		if (!Sequence_GetRelativeBoneTransformCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:Sequence_GetRelativeBoneTransformCS");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Sequence_GetRelativeBoneTransformCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Sequence_GetRelativeBoneTransformCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, Sequence_GetRelativeBoneTransformCS_AnimSeq_Offset), 0, Sequence_GetRelativeBoneTransformCS_AnimSeq_PropertyAddress.Address, AnimSeq);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Sequence_GetRelativeBoneTransformCS_InTime_Offset), 0, Sequence_GetRelativeBoneTransformCS_InTime_PropertyAddress.Address, InTime);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Sequence_GetRelativeBoneTransformCS_BoneName_Offset), 0, Sequence_GetRelativeBoneTransformCS_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Sequence_GetRelativeBoneTransformCS_bExtractRootMotion_Offset), 0, Sequence_GetRelativeBoneTransformCS_bExtractRootMotion_PropertyAddress.Address, bExtractRootMotion);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Sequence_GetRelativeBoneTransformCS_FunctionAddress, intPtr, Sequence_GetRelativeBoneTransformCS_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, Sequence_GetRelativeBoneTransformCS_ReturnValue_Offset), 0, Sequence_GetRelativeBoneTransformCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:Sequence_GetBoneTransformCS")]
	public unsafe static FTransform Sequence_GetBoneTransformCS(UAnimSequence AnimSeq, float InTime, FName BoneName, bool bExtractRootMotion = false)
	{
		if (!Sequence_GetBoneTransformCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:Sequence_GetBoneTransformCS");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Sequence_GetBoneTransformCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Sequence_GetBoneTransformCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, Sequence_GetBoneTransformCS_AnimSeq_Offset), 0, Sequence_GetBoneTransformCS_AnimSeq_PropertyAddress.Address, AnimSeq);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Sequence_GetBoneTransformCS_InTime_Offset), 0, Sequence_GetBoneTransformCS_InTime_PropertyAddress.Address, InTime);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Sequence_GetBoneTransformCS_BoneName_Offset), 0, Sequence_GetBoneTransformCS_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Sequence_GetBoneTransformCS_bExtractRootMotion_Offset), 0, Sequence_GetBoneTransformCS_bExtractRootMotion_PropertyAddress.Address, bExtractRootMotion);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Sequence_GetBoneTransformCS_FunctionAddress, intPtr, Sequence_GetBoneTransformCS_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, Sequence_GetBoneTransformCS_ReturnValue_Offset), 0, Sequence_GetBoneTransformCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:RemovePreviewAssetFromSkeleton")]
	public unsafe static bool RemovePreviewAssetFromSkeleton(USkeleton InUSkeleton, string BoneName)
	{
		if (!RemovePreviewAssetFromSkeleton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:RemovePreviewAssetFromSkeleton");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemovePreviewAssetFromSkeleton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemovePreviewAssetFromSkeleton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, RemovePreviewAssetFromSkeleton_InUSkeleton_Offset), 0, RemovePreviewAssetFromSkeleton_InUSkeleton_PropertyAddress.Address, InUSkeleton);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemovePreviewAssetFromSkeleton_BoneName_Offset), 0, RemovePreviewAssetFromSkeleton_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemovePreviewAssetFromSkeleton_FunctionAddress, intPtr, RemovePreviewAssetFromSkeleton_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemovePreviewAssetFromSkeleton_BoneName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemovePreviewAssetFromSkeleton_ReturnValue_Offset), 0, RemovePreviewAssetFromSkeleton_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveNotifyTrackByName")]
	public unsafe static void RemoveNotifyTrackByName(UAnimMontage TargetMontage, FName Name)
	{
		if (!RemoveNotifyTrackByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveNotifyTrackByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveNotifyTrackByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveNotifyTrackByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, RemoveNotifyTrackByName_TargetMontage_Offset), 0, RemoveNotifyTrackByName_TargetMontage_PropertyAddress.Address, TargetMontage);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveNotifyTrackByName_Name_Offset), 0, RemoveNotifyTrackByName_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveNotifyTrackByName_FunctionAddress, intPtr, RemoveNotifyTrackByName_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveNotifyEventByIndex")]
	public unsafe static void RemoveNotifyEventByIndex(UAnimMontage TargetMontage, int Index)
	{
		if (!RemoveNotifyEventByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveNotifyEventByIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveNotifyEventByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveNotifyEventByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, RemoveNotifyEventByIndex_TargetMontage_Offset), 0, RemoveNotifyEventByIndex_TargetMontage_PropertyAddress.Address, TargetMontage);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveNotifyEventByIndex_Index_Offset), 0, RemoveNotifyEventByIndex_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveNotifyEventByIndex_FunctionAddress, intPtr, RemoveNotifyEventByIndex_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveAnimationNotify")]
	public unsafe static void RemoveAnimationNotify(UAnimSequenceBase AnimBase, UAnimNotify Notify, UAnimNotifyState NotifyState)
	{
		if (!RemoveAnimationNotify_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveAnimationNotify");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAnimationNotify_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAnimationNotify_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, RemoveAnimationNotify_AnimBase_Offset), 0, RemoveAnimationNotify_AnimBase_PropertyAddress.Address, AnimBase);
		UObjectMarshaler<UAnimNotify>.ToNative(IntPtr.Add(intPtr, RemoveAnimationNotify_Notify_Offset), 0, RemoveAnimationNotify_Notify_PropertyAddress.Address, Notify);
		UObjectMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, RemoveAnimationNotify_NotifyState_Offset), 0, RemoveAnimationNotify_NotifyState_PropertyAddress.Address, NotifyState);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAnimationNotify_FunctionAddress, intPtr, RemoveAnimationNotify_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveAllPoints")]
	public unsafe static bool RemoveAllPoints(UBlendSpace BlendSpace)
	{
		if (!RemoveAllPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveAllPoints");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(intPtr, RemoveAllPoints_BlendSpace_Offset), 0, RemoveAllPoints_BlendSpace_PropertyAddress.Address, BlendSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAllPoints_FunctionAddress, intPtr, RemoveAllPoints_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveAllPoints_ReturnValue_Offset), 0, RemoveAllPoints_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveAllAnimationNotifyStateEventInNamedTrack")]
	public unsafe static void RemoveAllAnimationNotifyStateEventInNamedTrack(UAnimSequenceBase AnimBase, FName NotifyTrackName)
	{
		if (!RemoveAllAnimationNotifyStateEventInNamedTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveAllAnimationNotifyStateEventInNamedTrack");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllAnimationNotifyStateEventInNamedTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllAnimationNotifyStateEventInNamedTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, RemoveAllAnimationNotifyStateEventInNamedTrack_AnimBase_Offset), 0, RemoveAllAnimationNotifyStateEventInNamedTrack_AnimBase_PropertyAddress.Address, AnimBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveAllAnimationNotifyStateEventInNamedTrack_NotifyTrackName_Offset), 0, RemoveAllAnimationNotifyStateEventInNamedTrack_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAllAnimationNotifyStateEventInNamedTrack_FunctionAddress, intPtr, RemoveAllAnimationNotifyStateEventInNamedTrack_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:ReinitAnim")]
	public unsafe static void ReinitAnim(AActor Owner)
	{
		if (!ReinitAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:ReinitAnim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReinitAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReinitAnim_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReinitAnim_Owner_Offset), 0, ReinitAnim_Owner_PropertyAddress.Address, Owner);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReinitAnim_FunctionAddress, intPtr, ReinitAnim_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:PostLoadBlendSpace")]
	public unsafe static void PostLoadBlendSpace(UBlendSpace BlendSpace)
	{
		if (!PostLoadBlendSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:PostLoadBlendSpace");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostLoadBlendSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostLoadBlendSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(intPtr, PostLoadBlendSpace_BlendSpace_Offset), 0, PostLoadBlendSpace_BlendSpace_PropertyAddress.Address, BlendSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PostLoadBlendSpace_FunctionAddress, intPtr, PostLoadBlendSpace_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:MontageIsValidAdditive")]
	public unsafe static bool MontageIsValidAdditive(UAnimMontage AnimMontage)
	{
		if (!MontageIsValidAdditive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:MontageIsValidAdditive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MontageIsValidAdditive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MontageIsValidAdditive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, MontageIsValidAdditive_AnimMontage_Offset), 0, MontageIsValidAdditive_AnimMontage_PropertyAddress.Address, AnimMontage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MontageIsValidAdditive_FunctionAddress, intPtr, MontageIsValidAdditive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MontageIsValidAdditive_ReturnValue_Offset), 0, MontageIsValidAdditive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:Montage_GetBoneTransformCS")]
	public unsafe static FTransform Montage_GetBoneTransformCS(UAnimMontage InMontage, float InTime, FName InBoneName, FName InSlotName, bool bExtractRootMotion)
	{
		if (!Montage_GetBoneTransformCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:Montage_GetBoneTransformCS");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Montage_GetBoneTransformCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Montage_GetBoneTransformCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, Montage_GetBoneTransformCS_InMontage_Offset), 0, Montage_GetBoneTransformCS_InMontage_PropertyAddress.Address, InMontage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Montage_GetBoneTransformCS_InTime_Offset), 0, Montage_GetBoneTransformCS_InTime_PropertyAddress.Address, InTime);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Montage_GetBoneTransformCS_InBoneName_Offset), 0, Montage_GetBoneTransformCS_InBoneName_PropertyAddress.Address, InBoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Montage_GetBoneTransformCS_InSlotName_Offset), 0, Montage_GetBoneTransformCS_InSlotName_PropertyAddress.Address, InSlotName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Montage_GetBoneTransformCS_bExtractRootMotion_Offset), 0, Montage_GetBoneTransformCS_bExtractRootMotion_PropertyAddress.Address, bExtractRootMotion);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Montage_GetBoneTransformCS_FunctionAddress, intPtr, Montage_GetBoneTransformCS_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, Montage_GetBoneTransformCS_ReturnValue_Offset), 0, Montage_GetBoneTransformCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:Montage_GetBoneRelativeTransformCS")]
	public unsafe static FTransform Montage_GetBoneRelativeTransformCS(UAnimMontage InMontage, float InTime, FName InBoneName, FName InSlotName, bool bExtractRootMotion)
	{
		if (!Montage_GetBoneRelativeTransformCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:Montage_GetBoneRelativeTransformCS");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(Montage_GetBoneRelativeTransformCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Montage_GetBoneRelativeTransformCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, Montage_GetBoneRelativeTransformCS_InMontage_Offset), 0, Montage_GetBoneRelativeTransformCS_InMontage_PropertyAddress.Address, InMontage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Montage_GetBoneRelativeTransformCS_InTime_Offset), 0, Montage_GetBoneRelativeTransformCS_InTime_PropertyAddress.Address, InTime);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Montage_GetBoneRelativeTransformCS_InBoneName_Offset), 0, Montage_GetBoneRelativeTransformCS_InBoneName_PropertyAddress.Address, InBoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Montage_GetBoneRelativeTransformCS_InSlotName_Offset), 0, Montage_GetBoneRelativeTransformCS_InSlotName_PropertyAddress.Address, InSlotName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Montage_GetBoneRelativeTransformCS_bExtractRootMotion_Offset), 0, Montage_GetBoneRelativeTransformCS_bExtractRootMotion_PropertyAddress.Address, bExtractRootMotion);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Montage_GetBoneRelativeTransformCS_FunctionAddress, intPtr, Montage_GetBoneRelativeTransformCS_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, Montage_GetBoneRelativeTransformCS_ReturnValue_Offset), 0, Montage_GetBoneRelativeTransformCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:MarkDirtyForANEMontageTickType")]
	public unsafe static void MarkDirtyForANEMontageTickType(string ResourcePath, bool bToQueued)
	{
		if (!MarkDirtyForANEMontageTickType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:MarkDirtyForANEMontageTickType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkDirtyForANEMontageTickType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkDirtyForANEMontageTickType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MarkDirtyForANEMontageTickType_ResourcePath_Offset), 0, MarkDirtyForANEMontageTickType_ResourcePath_PropertyAddress.Address, ResourcePath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MarkDirtyForANEMontageTickType_bToQueued_Offset), 0, MarkDirtyForANEMontageTickType_bToQueued_PropertyAddress.Address, bToQueued);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MarkDirtyForANEMontageTickType_FunctionAddress, intPtr, MarkDirtyForANEMontageTickType_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MarkDirtyForANEMontageTickType_ResourcePath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:MarkDirtyAM")]
	public unsafe static void MarkDirtyAM(UAnimMontage DirtyMontage)
	{
		if (!MarkDirtyAM_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:MarkDirtyAM");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkDirtyAM_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkDirtyAM_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, MarkDirtyAM_DirtyMontage_Offset), 0, MarkDirtyAM_DirtyMontage_PropertyAddress.Address, DirtyMontage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MarkDirtyAM_FunctionAddress, intPtr, MarkDirtyAM_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:MarkDirty")]
	public unsafe static void MarkDirty(UObject obj)
	{
		if (!MarkDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:MarkDirty");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, MarkDirty_obj_Offset), 0, MarkDirty_obj_PropertyAddress.Address, obj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MarkDirty_FunctionAddress, intPtr, MarkDirty_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:IsSlotPlayingMontage")]
	public unsafe static bool IsSlotPlayingMontage(UAnimInstance AnimInst, FName SlotNodeName)
	{
		if (!IsSlotPlayingMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:IsSlotPlayingMontage");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSlotPlayingMontage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSlotPlayingMontage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, IsSlotPlayingMontage_AnimInst_Offset), 0, IsSlotPlayingMontage_AnimInst_PropertyAddress.Address, AnimInst);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsSlotPlayingMontage_SlotNodeName_Offset), 0, IsSlotPlayingMontage_SlotNodeName_PropertyAddress.Address, SlotNodeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsSlotPlayingMontage_FunctionAddress, intPtr, IsSlotPlayingMontage_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSlotPlayingMontage_ReturnValue_Offset), 0, IsSlotPlayingMontage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:IsInRootMotionAM")]
	public unsafe static bool IsInRootMotionAM(ACharacter Character)
	{
		if (!IsInRootMotionAM_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:IsInRootMotionAM");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInRootMotionAM_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInRootMotionAM_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, IsInRootMotionAM_Character_Offset), 0, IsInRootMotionAM_Character_PropertyAddress.Address, Character);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsInRootMotionAM_FunctionAddress, intPtr, IsInRootMotionAM_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInRootMotionAM_ReturnValue_Offset), 0, IsInRootMotionAM_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:InitAnimGraphNode")]
	public unsafe static void InitAnimGraphNode(UAnimInstance AnimInst, FName Tag)
	{
		if (!InitAnimGraphNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:InitAnimGraphNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitAnimGraphNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitAnimGraphNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, InitAnimGraphNode_AnimInst_Offset), 0, InitAnimGraphNode_AnimInst_PropertyAddress.Address, AnimInst);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, InitAnimGraphNode_Tag_Offset), 0, InitAnimGraphNode_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InitAnimGraphNode_FunctionAddress, intPtr, InitAnimGraphNode_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetTrackIndexForAnimationNotifyTrackName")]
	public unsafe static int GetTrackIndexForAnimationNotifyTrackName(UAnimSequenceBase AnimBase, FName NotifyTrackName)
	{
		if (!GetTrackIndexForAnimationNotifyTrackName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetTrackIndexForAnimationNotifyTrackName");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTrackIndexForAnimationNotifyTrackName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTrackIndexForAnimationNotifyTrackName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetTrackIndexForAnimationNotifyTrackName_AnimBase_Offset), 0, GetTrackIndexForAnimationNotifyTrackName_AnimBase_PropertyAddress.Address, AnimBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTrackIndexForAnimationNotifyTrackName_NotifyTrackName_Offset), 0, GetTrackIndexForAnimationNotifyTrackName_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTrackIndexForAnimationNotifyTrackName_FunctionAddress, intPtr, GetTrackIndexForAnimationNotifyTrackName_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTrackIndexForAnimationNotifyTrackName_ReturnValue_Offset), 0, GetTrackIndexForAnimationNotifyTrackName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetSkeleton")]
	public unsafe static USkeleton GetSkeleton(UAnimSequenceBase AnimSequenceBase)
	{
		if (!GetSkeleton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetSkeleton");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeleton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeleton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetSkeleton_AnimSequenceBase_Offset), 0, GetSkeleton_AnimSequenceBase_PropertyAddress.Address, AnimSequenceBase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSkeleton_FunctionAddress, intPtr, GetSkeleton_ParamsSize);
		return UObjectMarshaler<USkeleton>.FromNative(IntPtr.Add(intPtr, GetSkeleton_ReturnValue_Offset), 0, GetSkeleton_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetOneAnimAllNotifyEventIncludeAS")]
	public unsafe static void GetOneAnimAllNotifyEventIncludeAS(UAnimSequenceBase TargetAnim, out List<FAnimNotifyEvent> AnimNotifyEventList)
	{
		if (!GetOneAnimAllNotifyEventIncludeAS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetOneAnimAllNotifyEventIncludeAS");
			AnimNotifyEventList = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOneAnimAllNotifyEventIncludeAS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOneAnimAllNotifyEventIncludeAS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetOneAnimAllNotifyEventIncludeAS_TargetAnim_Offset), 0, GetOneAnimAllNotifyEventIncludeAS_TargetAnim_PropertyAddress.Address, TargetAnim);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOneAnimAllNotifyEventIncludeAS_FunctionAddress, intPtr, GetOneAnimAllNotifyEventIncludeAS_ParamsSize);
		AnimNotifyEventList = new TArrayCopyMarshaler<FAnimNotifyEvent>(1, GetOneAnimAllNotifyEventIncludeAS_AnimNotifyEventList_PropertyAddress, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.FromNative, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetOneAnimAllNotifyEventIncludeAS_AnimNotifyEventList_Offset));
		NativeReflection.DestroyValue_InContainer(GetOneAnimAllNotifyEventIncludeAS_AnimNotifyEventList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetNumUVChannels")]
	public unsafe static int GetNumUVChannels(UStaticMesh StaticMesh, int LODIndex)
	{
		if (!GetNumUVChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetNumUVChannels");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumUVChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumUVChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetNumUVChannels_StaticMesh_Offset), 0, GetNumUVChannels_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNumUVChannels_LODIndex_Offset), 0, GetNumUVChannels_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumUVChannels_FunctionAddress, intPtr, GetNumUVChannels_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumUVChannels_ReturnValue_Offset), 0, GetNumUVChannels_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetNotifyTriggerTime")]
	public unsafe static float GetNotifyTriggerTime(FAnimNotifyEvent AnimNotifyEvent)
	{
		if (!GetNotifyTriggerTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetNotifyTriggerTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNotifyTriggerTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNotifyTriggerTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNotifyTriggerTime_AnimNotifyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimNotifyEvent>.ToNative(IntPtr.Add(intPtr, GetNotifyTriggerTime_AnimNotifyEvent_Offset), 0, GetNotifyTriggerTime_AnimNotifyEvent_PropertyAddress.Address, AnimNotifyEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNotifyTriggerTime_FunctionAddress, intPtr, GetNotifyTriggerTime_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetNotifyTriggerTime_AnimNotifyEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetNotifyTriggerTime_ReturnValue_Offset), 0, GetNotifyTriggerTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetNotifyEndTriggerTime")]
	public unsafe static float GetNotifyEndTriggerTime(FAnimNotifyEvent AnimNotifyEvent)
	{
		if (!GetNotifyEndTriggerTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetNotifyEndTriggerTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNotifyEndTriggerTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNotifyEndTriggerTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNotifyEndTriggerTime_AnimNotifyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimNotifyEvent>.ToNative(IntPtr.Add(intPtr, GetNotifyEndTriggerTime_AnimNotifyEvent_Offset), 0, GetNotifyEndTriggerTime_AnimNotifyEvent_PropertyAddress.Address, AnimNotifyEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNotifyEndTriggerTime_FunctionAddress, intPtr, GetNotifyEndTriggerTime_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetNotifyEndTriggerTime_AnimNotifyEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetNotifyEndTriggerTime_ReturnValue_Offset), 0, GetNotifyEndTriggerTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetNotifyComboEndTime")]
	public unsafe static float GetNotifyComboEndTime(UAnimMontage AnimInst, int index)
	{
		if (!GetNotifyComboEndTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetNotifyComboEndTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNotifyComboEndTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNotifyComboEndTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, GetNotifyComboEndTime_AnimInst_Offset), 0, GetNotifyComboEndTime_AnimInst_PropertyAddress.Address, AnimInst);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNotifyComboEndTime_index_Offset), 0, GetNotifyComboEndTime_index_PropertyAddress.Address, index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNotifyComboEndTime_FunctionAddress, intPtr, GetNotifyComboEndTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetNotifyComboEndTime_ReturnValue_Offset), 0, GetNotifyComboEndTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageSlotName")]
	public unsafe static FName GetMontageSlotName(UAnimMontage Montage, int SlotIndex)
	{
		if (!GetMontageSlotName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageSlotName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMontageSlotName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMontageSlotName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, GetMontageSlotName_Montage_Offset), 0, GetMontageSlotName_Montage_PropertyAddress.Address, Montage);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetMontageSlotName_SlotIndex_Offset), 0, GetMontageSlotName_SlotIndex_PropertyAddress.Address, SlotIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMontageSlotName_FunctionAddress, intPtr, GetMontageSlotName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetMontageSlotName_ReturnValue_Offset), 0, GetMontageSlotName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageSectionStartAndEndTime")]
	public unsafe static void GetMontageSectionStartAndEndTime(UAnimMontage AnimMontage, FName SectionName, out float OutStartTime, out float OutEndTime)
	{
		if (!GetMontageSectionStartAndEndTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageSectionStartAndEndTime");
			OutStartTime = 0f;
			OutEndTime = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMontageSectionStartAndEndTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMontageSectionStartAndEndTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, GetMontageSectionStartAndEndTime_AnimMontage_Offset), 0, GetMontageSectionStartAndEndTime_AnimMontage_PropertyAddress.Address, AnimMontage);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetMontageSectionStartAndEndTime_SectionName_Offset), 0, GetMontageSectionStartAndEndTime_SectionName_PropertyAddress.Address, SectionName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMontageSectionStartAndEndTime_FunctionAddress, intPtr, GetMontageSectionStartAndEndTime_ParamsSize);
		OutStartTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMontageSectionStartAndEndTime_OutStartTime_Offset), 0, GetMontageSectionStartAndEndTime_OutStartTime_PropertyAddress.Address);
		OutEndTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMontageSectionStartAndEndTime_OutEndTime_Offset), 0, GetMontageSectionStartAndEndTime_OutEndTime_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageSectionName")]
	public unsafe static FName GetMontageSectionName(UAnimMontage AnimMontage, int index)
	{
		if (!GetMontageSectionName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageSectionName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMontageSectionName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMontageSectionName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, GetMontageSectionName_AnimMontage_Offset), 0, GetMontageSectionName_AnimMontage_PropertyAddress.Address, AnimMontage);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetMontageSectionName_index_Offset), 0, GetMontageSectionName_index_PropertyAddress.Address, index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMontageSectionName_FunctionAddress, intPtr, GetMontageSectionName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetMontageSectionName_ReturnValue_Offset), 0, GetMontageSectionName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageNotifyTriggerTime")]
	public unsafe static float GetMontageNotifyTriggerTime(UAnimMontage AnimInst, int FromInstanceID)
	{
		if (!GetMontageNotifyTriggerTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageNotifyTriggerTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMontageNotifyTriggerTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMontageNotifyTriggerTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, GetMontageNotifyTriggerTime_AnimInst_Offset), 0, GetMontageNotifyTriggerTime_AnimInst_PropertyAddress.Address, AnimInst);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetMontageNotifyTriggerTime_FromInstanceID_Offset), 0, GetMontageNotifyTriggerTime_FromInstanceID_PropertyAddress.Address, FromInstanceID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMontageNotifyTriggerTime_FunctionAddress, intPtr, GetMontageNotifyTriggerTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMontageNotifyTriggerTime_ReturnValue_Offset), 0, GetMontageNotifyTriggerTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageNotifyName")]
	public unsafe static string GetMontageNotifyName(UAnimMontage AnimInst, int index)
	{
		if (!GetMontageNotifyName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageNotifyName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMontageNotifyName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMontageNotifyName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, GetMontageNotifyName_AnimInst_Offset), 0, GetMontageNotifyName_AnimInst_PropertyAddress.Address, AnimInst);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetMontageNotifyName_index_Offset), 0, GetMontageNotifyName_index_PropertyAddress.Address, index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMontageNotifyName_FunctionAddress, intPtr, GetMontageNotifyName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetMontageNotifyName_ReturnValue_Offset), 0, GetMontageNotifyName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMontageNotifyName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageNextSection")]
	public unsafe static FName GetMontageNextSection(UAnimInstance AnimInstance, UAnimMontage AnimMontage)
	{
		if (!GetMontageNextSection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageNextSection");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMontageNextSection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMontageNextSection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, GetMontageNextSection_AnimInstance_Offset), 0, GetMontageNextSection_AnimInstance_PropertyAddress.Address, AnimInstance);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, GetMontageNextSection_AnimMontage_Offset), 0, GetMontageNextSection_AnimMontage_PropertyAddress.Address, AnimMontage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMontageNextSection_FunctionAddress, intPtr, GetMontageNextSection_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetMontageNextSection_ReturnValue_Offset), 0, GetMontageNextSection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageEffectID")]
	public unsafe static int GetMontageEffectID(UAnimMontage AnimInst, int index)
	{
		if (!GetMontageEffectID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageEffectID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMontageEffectID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMontageEffectID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, GetMontageEffectID_AnimInst_Offset), 0, GetMontageEffectID_AnimInst_PropertyAddress.Address, AnimInst);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetMontageEffectID_index_Offset), 0, GetMontageEffectID_index_PropertyAddress.Address, index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMontageEffectID_FunctionAddress, intPtr, GetMontageEffectID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMontageEffectID_ReturnValue_Offset), 0, GetMontageEffectID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageComboSkillID")]
	public unsafe static int GetMontageComboSkillID(UAnimMontage AnimInst, int index)
	{
		if (!GetMontageComboSkillID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageComboSkillID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMontageComboSkillID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMontageComboSkillID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, GetMontageComboSkillID_AnimInst_Offset), 0, GetMontageComboSkillID_AnimInst_PropertyAddress.Address, AnimInst);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetMontageComboSkillID_index_Offset), 0, GetMontageComboSkillID_index_PropertyAddress.Address, index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMontageComboSkillID_FunctionAddress, intPtr, GetMontageComboSkillID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMontageComboSkillID_ReturnValue_Offset), 0, GetMontageComboSkillID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetFolderPathFromFullPath")]
	public unsafe static string GetFolderPathFromFullPath(string FullPath)
	{
		if (!GetFolderPathFromFullPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetFolderPathFromFullPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFolderPathFromFullPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFolderPathFromFullPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetFolderPathFromFullPath_FullPath_Offset), 0, GetFolderPathFromFullPath_FullPath_PropertyAddress.Address, FullPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFolderPathFromFullPath_FunctionAddress, intPtr, GetFolderPathFromFullPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetFolderPathFromFullPath_FullPath_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetFolderPathFromFullPath_ReturnValue_Offset), 0, GetFolderPathFromFullPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetFolderPathFromFullPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetCurrentActiveMontageInstanceID")]
	public unsafe static int GetCurrentActiveMontageInstanceID(ACharacter Character)
	{
		if (!GetCurrentActiveMontageInstanceID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetCurrentActiveMontageInstanceID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentActiveMontageInstanceID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentActiveMontageInstanceID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, GetCurrentActiveMontageInstanceID_Character_Offset), 0, GetCurrentActiveMontageInstanceID_Character_PropertyAddress.Address, Character);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentActiveMontageInstanceID_FunctionAddress, intPtr, GetCurrentActiveMontageInstanceID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCurrentActiveMontageInstanceID_ReturnValue_Offset), 0, GetCurrentActiveMontageInstanceID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetChildSockets")]
	public unsafe static void GetChildSockets(USkeletalMeshComponent SkeletalMeshComp, FName BaseBoneName, out List<FName> ChildSocketNames)
	{
		if (!GetChildSockets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetChildSockets");
			ChildSocketNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildSockets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildSockets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, GetChildSockets_SkeletalMeshComp_Offset), 0, GetChildSockets_SkeletalMeshComp_PropertyAddress.Address, SkeletalMeshComp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetChildSockets_BaseBoneName_Offset), 0, GetChildSockets_BaseBoneName_PropertyAddress.Address, BaseBoneName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetChildSockets_FunctionAddress, intPtr, GetChildSockets_ParamsSize);
		ChildSocketNames = new TArrayCopyMarshaler<FName>(1, GetChildSockets_ChildSocketNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetChildSockets_ChildSocketNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetChildSockets_ChildSocketNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetChildBones")]
	public unsafe static int GetChildBones(USkeleton InSkeleton, FName ParentBoneName, List<FName> BoneNameFilter, out HashSet<FName> ChildBones)
	{
		if (!GetChildBones_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetChildBones");
			ChildBones = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildBones_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildBones_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, GetChildBones_InSkeleton_Offset), 0, GetChildBones_InSkeleton_PropertyAddress.Address, InSkeleton);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetChildBones_ParentBoneName_Offset), 0, GetChildBones_ParentBoneName_PropertyAddress.Address, ParentBoneName);
		new TArrayCopyMarshaler<FName>(1, GetChildBones_BoneNameFilter_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, GetChildBones_BoneNameFilter_Offset), BoneNameFilter);
		NativeReflection.InitializeValue_InContainer(GetChildBones_ChildBones_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetChildBones_FunctionAddress, intPtr, GetChildBones_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetChildBones_BoneNameFilter_PropertyAddress.Address, intPtr);
		ChildBones = new TSetCopyMarshaler<FName>(1, GetChildBones_ChildBones_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetChildBones_ChildBones_Offset));
		NativeReflection.DestroyValue_InContainer(GetChildBones_ChildBones_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetChildBones_ReturnValue_Offset), 0, GetChildBones_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetBoneWeight")]
	public unsafe static List<FVector4> GetBoneWeight(USkeletalMesh SkeletalMesh)
	{
		if (!GetBoneWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetBoneWeight");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetBoneWeight_SkeletalMesh_Offset), 0, GetBoneWeight_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoneWeight_FunctionAddress, intPtr, GetBoneWeight_ParamsSize);
		List<FVector4> result = new TArrayCopyMarshaler<FVector4>(1, GetBoneWeight_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.FromNative, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBoneWeight_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetBoneWeight_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetBoneTransformByTime")]
	public unsafe static FTransform GetBoneTransformByTime(UAnimSequence AnimationSequence, float Time, int TrackIndex, bool UseRawData)
	{
		if (!GetBoneTransformByTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetBoneTransformByTime");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneTransformByTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneTransformByTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetBoneTransformByTime_AnimationSequence_Offset), 0, GetBoneTransformByTime_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetBoneTransformByTime_Time_Offset), 0, GetBoneTransformByTime_Time_PropertyAddress.Address, Time);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBoneTransformByTime_TrackIndex_Offset), 0, GetBoneTransformByTime_TrackIndex_PropertyAddress.Address, TrackIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetBoneTransformByTime_UseRawData_Offset), 0, GetBoneTransformByTime_UseRawData_PropertyAddress.Address, UseRawData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoneTransformByTime_FunctionAddress, intPtr, GetBoneTransformByTime_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetBoneTransformByTime_ReturnValue_Offset), 0, GetBoneTransformByTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetBoneTransform")]
	public unsafe static FTransform GetBoneTransform(USkeletalMeshComponent Mesh, int BoneIndex)
	{
		if (!GetBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetBoneTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, GetBoneTransform_Mesh_Offset), 0, GetBoneTransform_Mesh_PropertyAddress.Address, Mesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBoneTransform_BoneIndex_Offset), 0, GetBoneTransform_BoneIndex_PropertyAddress.Address, BoneIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoneTransform_FunctionAddress, intPtr, GetBoneTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetBoneTransform_ReturnValue_Offset), 0, GetBoneTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetBoneParentList")]
	public unsafe static List<int> GetBoneParentList(UAnimSequence AnimationSequence)
	{
		if (!GetBoneParentList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetBoneParentList");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneParentList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneParentList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetBoneParentList_AnimationSequence_Offset), 0, GetBoneParentList_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoneParentList_FunctionAddress, intPtr, GetBoneParentList_ParamsSize);
		List<int> result = new TArrayCopyMarshaler<int>(1, GetBoneParentList_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBoneParentList_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetBoneParentList_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimCurrentTime")]
	public unsafe static float GetAnimCurrentTime(UAnimInstance AnimInst, int FromInstanceID)
	{
		if (!GetAnimCurrentTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimCurrentTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimCurrentTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimCurrentTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, GetAnimCurrentTime_AnimInst_Offset), 0, GetAnimCurrentTime_AnimInst_PropertyAddress.Address, AnimInst);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAnimCurrentTime_FromInstanceID_Offset), 0, GetAnimCurrentTime_FromInstanceID_PropertyAddress.Address, FromInstanceID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimCurrentTime_FunctionAddress, intPtr, GetAnimCurrentTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAnimCurrentTime_ReturnValue_Offset), 0, GetAnimCurrentTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimationTrackNames")]
	public unsafe static List<FName> GetAnimationTrackNames(UAnimSequence AnimationSequence)
	{
		if (!GetAnimationTrackNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimationTrackNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationTrackNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationTrackNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAnimationTrackNames_AnimationSequence_Offset), 0, GetAnimationTrackNames_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationTrackNames_FunctionAddress, intPtr, GetAnimationTrackNames_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetAnimationTrackNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAnimationTrackNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAnimationTrackNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimationTrackNameByIndex")]
	public unsafe static bool GetAnimationTrackNameByIndex(UAnimSequenceBase AnimSequenceBase, int Index, out FName TrackName)
	{
		if (!GetAnimationTrackNameByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimationTrackNameByIndex");
			TrackName = default(FName);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationTrackNameByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationTrackNameByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetAnimationTrackNameByIndex_AnimSequenceBase_Offset), 0, GetAnimationTrackNameByIndex_AnimSequenceBase_PropertyAddress.Address, AnimSequenceBase);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAnimationTrackNameByIndex_Index_Offset), 0, GetAnimationTrackNameByIndex_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationTrackNameByIndex_FunctionAddress, intPtr, GetAnimationTrackNameByIndex_ParamsSize);
		TrackName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetAnimationTrackNameByIndex_TrackName_Offset), 0, GetAnimationTrackNameByIndex_TrackName_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAnimationTrackNameByIndex_ReturnValue_Offset), 0, GetAnimationTrackNameByIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimationNotifyEvents")]
	public unsafe static bool GetAnimationNotifyEvents(UAnimSequenceBase AnimSequenceBase, out List<FAnimNotifyEventSimple> NotifyEvents)
	{
		if (!GetAnimationNotifyEvents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimationNotifyEvents");
			NotifyEvents = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationNotifyEvents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationNotifyEvents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetAnimationNotifyEvents_AnimSequenceBase_Offset), 0, GetAnimationNotifyEvents_AnimSequenceBase_PropertyAddress.Address, AnimSequenceBase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationNotifyEvents_FunctionAddress, intPtr, GetAnimationNotifyEvents_ParamsSize);
		NotifyEvents = new TArrayCopyMarshaler<FAnimNotifyEventSimple>(1, GetAnimationNotifyEvents_NotifyEvents_PropertyAddress, CachedMarshalingDelegates<FAnimNotifyEventSimple, FAnimNotifyEventSimple>.FromNative, CachedMarshalingDelegates<FAnimNotifyEventSimple, FAnimNotifyEventSimple>.ToNative).FromNative(IntPtr.Add(intPtr, GetAnimationNotifyEvents_NotifyEvents_Offset));
		NativeReflection.DestroyValue_InContainer(GetAnimationNotifyEvents_NotifyEvents_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAnimationNotifyEvents_ReturnValue_Offset), 0, GetAnimationNotifyEvents_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimAllNotifyEventIncludeAS")]
	public unsafe static void GetAnimAllNotifyEventIncludeAS(List<UAnimSequenceBase> AnimBases, out List<FAnimNotifyEvent> AnimNotifyEventList)
	{
		if (!GetAnimAllNotifyEventIncludeAS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimAllNotifyEventIncludeAS");
			AnimNotifyEventList = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimAllNotifyEventIncludeAS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimAllNotifyEventIncludeAS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UAnimSequenceBase>(1, GetAnimAllNotifyEventIncludeAS_AnimBases_PropertyAddress, CachedMarshalingDelegates<UAnimSequenceBase, UObjectMarshaler<UAnimSequenceBase>>.FromNative, CachedMarshalingDelegates<UAnimSequenceBase, UObjectMarshaler<UAnimSequenceBase>>.ToNative).ToNative(IntPtr.Add(intPtr, GetAnimAllNotifyEventIncludeAS_AnimBases_Offset), AnimBases);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimAllNotifyEventIncludeAS_FunctionAddress, intPtr, GetAnimAllNotifyEventIncludeAS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAnimAllNotifyEventIncludeAS_AnimBases_PropertyAddress.Address, intPtr);
		AnimNotifyEventList = new TArrayCopyMarshaler<FAnimNotifyEvent>(1, GetAnimAllNotifyEventIncludeAS_AnimNotifyEventList_PropertyAddress, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.FromNative, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAnimAllNotifyEventIncludeAS_AnimNotifyEventList_Offset));
		NativeReflection.DestroyValue_InContainer(GetAnimAllNotifyEventIncludeAS_AnimNotifyEventList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllNotifyEventInAM")]
	public unsafe static List<FAnimNotifyEvent> GetAllNotifyEventInAM(UAnimMontage TargetMontage, out List<FGSNotifyEventTimeInfo> TimeInfoList)
	{
		if (!GetAllNotifyEventInAM_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllNotifyEventInAM");
			TimeInfoList = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllNotifyEventInAM_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllNotifyEventInAM_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, GetAllNotifyEventInAM_TargetMontage_Offset), 0, GetAllNotifyEventInAM_TargetMontage_PropertyAddress.Address, TargetMontage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllNotifyEventInAM_FunctionAddress, intPtr, GetAllNotifyEventInAM_ParamsSize);
		TimeInfoList = new TArrayCopyMarshaler<FGSNotifyEventTimeInfo>(1, GetAllNotifyEventInAM_TimeInfoList_PropertyAddress, CachedMarshalingDelegates<FGSNotifyEventTimeInfo, BlittableTypeMarshaler<FGSNotifyEventTimeInfo>>.FromNative, CachedMarshalingDelegates<FGSNotifyEventTimeInfo, BlittableTypeMarshaler<FGSNotifyEventTimeInfo>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllNotifyEventInAM_TimeInfoList_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllNotifyEventInAM_TimeInfoList_PropertyAddress.Address, intPtr);
		List<FAnimNotifyEvent> result = new TArrayCopyMarshaler<FAnimNotifyEvent>(1, GetAllNotifyEventInAM_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.FromNative, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllNotifyEventInAM_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllNotifyEventInAM_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllNotifyEvent")]
	public unsafe static void GetAllNotifyEvent(UAnimMontage TargetMontage, out List<FAnimNotifyEvent> AnimNotifyEventList)
	{
		if (!GetAllNotifyEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllNotifyEvent");
			AnimNotifyEventList = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllNotifyEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllNotifyEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, GetAllNotifyEvent_TargetMontage_Offset), 0, GetAllNotifyEvent_TargetMontage_PropertyAddress.Address, TargetMontage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllNotifyEvent_FunctionAddress, intPtr, GetAllNotifyEvent_ParamsSize);
		AnimNotifyEventList = new TArrayCopyMarshaler<FAnimNotifyEvent>(1, GetAllNotifyEvent_AnimNotifyEventList_PropertyAddress, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.FromNative, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllNotifyEvent_AnimNotifyEventList_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllNotifyEvent_AnimNotifyEventList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllAnimSyncMarkers")]
	public unsafe static bool GetAllAnimSyncMarkers(UAnimSequence AnimSequence, out List<FAnimSyncMarker> OutSyncMarkers)
	{
		if (!GetAllAnimSyncMarkers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllAnimSyncMarkers");
			OutSyncMarkers = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllAnimSyncMarkers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllAnimSyncMarkers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAllAnimSyncMarkers_AnimSequence_Offset), 0, GetAllAnimSyncMarkers_AnimSequence_PropertyAddress.Address, AnimSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllAnimSyncMarkers_FunctionAddress, intPtr, GetAllAnimSyncMarkers_ParamsSize);
		OutSyncMarkers = new TArrayCopyMarshaler<FAnimSyncMarker>(1, GetAllAnimSyncMarkers_OutSyncMarkers_PropertyAddress, CachedMarshalingDelegates<FAnimSyncMarker, FAnimSyncMarker>.FromNative, CachedMarshalingDelegates<FAnimSyncMarker, FAnimSyncMarker>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllAnimSyncMarkers_OutSyncMarkers_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllAnimSyncMarkers_OutSyncMarkers_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAllAnimSyncMarkers_ReturnValue_Offset), 0, GetAllAnimSyncMarkers_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllAnimNotifyEventInAMForMarkDirty")]
	public unsafe static List<FGSMontageAndNotifiesWarp> GetAllAnimNotifyEventInAMForMarkDirty(UAnimMontage AnimMontage)
	{
		if (!GetAllAnimNotifyEventInAMForMarkDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllAnimNotifyEventInAMForMarkDirty");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllAnimNotifyEventInAMForMarkDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllAnimNotifyEventInAMForMarkDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, GetAllAnimNotifyEventInAMForMarkDirty_AnimMontage_Offset), 0, GetAllAnimNotifyEventInAMForMarkDirty_AnimMontage_PropertyAddress.Address, AnimMontage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllAnimNotifyEventInAMForMarkDirty_FunctionAddress, intPtr, GetAllAnimNotifyEventInAMForMarkDirty_ParamsSize);
		List<FGSMontageAndNotifiesWarp> result = new TArrayCopyMarshaler<FGSMontageAndNotifiesWarp>(1, GetAllAnimNotifyEventInAMForMarkDirty_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FGSMontageAndNotifiesWarp, FGSMontageAndNotifiesWarp>.FromNative, CachedMarshalingDelegates<FGSMontageAndNotifiesWarp, FGSMontageAndNotifiesWarp>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllAnimNotifyEventInAMForMarkDirty_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllAnimNotifyEventInAMForMarkDirty_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllAnimNotifyEventForMarkDirty")]
	public unsafe static List<FGSMontageAndNotifiesWarp> GetAllAnimNotifyEventForMarkDirty(string ResourcePath)
	{
		if (!GetAllAnimNotifyEventForMarkDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllAnimNotifyEventForMarkDirty");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllAnimNotifyEventForMarkDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllAnimNotifyEventForMarkDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetAllAnimNotifyEventForMarkDirty_ResourcePath_Offset), 0, GetAllAnimNotifyEventForMarkDirty_ResourcePath_PropertyAddress.Address, ResourcePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllAnimNotifyEventForMarkDirty_FunctionAddress, intPtr, GetAllAnimNotifyEventForMarkDirty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllAnimNotifyEventForMarkDirty_ResourcePath_PropertyAddress.Address, intPtr);
		List<FGSMontageAndNotifiesWarp> result = new TArrayCopyMarshaler<FGSMontageAndNotifiesWarp>(1, GetAllAnimNotifyEventForMarkDirty_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FGSMontageAndNotifiesWarp, FGSMontageAndNotifiesWarp>.FromNative, CachedMarshalingDelegates<FGSMontageAndNotifiesWarp, FGSMontageAndNotifiesWarp>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllAnimNotifyEventForMarkDirty_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllAnimNotifyEventForMarkDirty_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllAnimationsOfSkeleton")]
	public unsafe static List<UAnimationAsset> GetAllAnimationsOfSkeleton(USkeletalMesh SkeletonMesh, string AnimationBasePath)
	{
		if (!GetAllAnimationsOfSkeleton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllAnimationsOfSkeleton");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllAnimationsOfSkeleton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllAnimationsOfSkeleton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetAllAnimationsOfSkeleton_SkeletonMesh_Offset), 0, GetAllAnimationsOfSkeleton_SkeletonMesh_PropertyAddress.Address, SkeletonMesh);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetAllAnimationsOfSkeleton_AnimationBasePath_Offset), 0, GetAllAnimationsOfSkeleton_AnimationBasePath_PropertyAddress.Address, AnimationBasePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllAnimationsOfSkeleton_FunctionAddress, intPtr, GetAllAnimationsOfSkeleton_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllAnimationsOfSkeleton_AnimationBasePath_PropertyAddress.Address, intPtr);
		List<UAnimationAsset> result = new TArrayCopyMarshaler<UAnimationAsset>(1, GetAllAnimationsOfSkeleton_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UAnimationAsset, UObjectMarshaler<UAnimationAsset>>.FromNative, CachedMarshalingDelegates<UAnimationAsset, UObjectMarshaler<UAnimationAsset>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllAnimationsOfSkeleton_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllAnimationsOfSkeleton_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GetActiveMontageInstanceID")]
	public unsafe static int GetActiveMontageInstanceID(UAnimInstance AnimInstance)
	{
		if (!GetActiveMontageInstanceID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GetActiveMontageInstanceID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActiveMontageInstanceID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActiveMontageInstanceID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, GetActiveMontageInstanceID_AnimInstance_Offset), 0, GetActiveMontageInstanceID_AnimInstance_PropertyAddress.Address, AnimInstance);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActiveMontageInstanceID_FunctionAddress, intPtr, GetActiveMontageInstanceID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetActiveMontageInstanceID_ReturnValue_Offset), 0, GetActiveMontageInstanceID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GenerateDestructibleComponentFromPathWithEditor")]
	public unsafe static bool GenerateDestructibleComponentFromPathWithEditor(string FolderPath, UObject TargetActor)
	{
		if (!GenerateDestructibleComponentFromPathWithEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GenerateDestructibleComponentFromPathWithEditor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateDestructibleComponentFromPathWithEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateDestructibleComponentFromPathWithEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GenerateDestructibleComponentFromPathWithEditor_FolderPath_Offset), 0, GenerateDestructibleComponentFromPathWithEditor_FolderPath_PropertyAddress.Address, FolderPath);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GenerateDestructibleComponentFromPathWithEditor_TargetActor_Offset), 0, GenerateDestructibleComponentFromPathWithEditor_TargetActor_PropertyAddress.Address, TargetActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GenerateDestructibleComponentFromPathWithEditor_FunctionAddress, intPtr, GenerateDestructibleComponentFromPathWithEditor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GenerateDestructibleComponentFromPathWithEditor_FolderPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GenerateDestructibleComponentFromPathWithEditor_ReturnValue_Offset), 0, GenerateDestructibleComponentFromPathWithEditor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GenerateDestructibleComponentFromPath")]
	public unsafe static bool GenerateDestructibleComponentFromPath(string FolderPath, USkeletalMeshComponent TargetSkeletalMeshComp, out List<UDestructibleComponent> DestructibleMeshArray, out List<FName> BoneNameArray)
	{
		if (!GenerateDestructibleComponentFromPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GenerateDestructibleComponentFromPath");
			DestructibleMeshArray = null;
			BoneNameArray = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateDestructibleComponentFromPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateDestructibleComponentFromPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GenerateDestructibleComponentFromPath_FolderPath_Offset), 0, GenerateDestructibleComponentFromPath_FolderPath_PropertyAddress.Address, FolderPath);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, GenerateDestructibleComponentFromPath_TargetSkeletalMeshComp_Offset), 0, GenerateDestructibleComponentFromPath_TargetSkeletalMeshComp_PropertyAddress.Address, TargetSkeletalMeshComp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GenerateDestructibleComponentFromPath_FunctionAddress, intPtr, GenerateDestructibleComponentFromPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GenerateDestructibleComponentFromPath_FolderPath_PropertyAddress.Address, intPtr);
		DestructibleMeshArray = new TArrayCopyMarshaler<UDestructibleComponent>(1, GenerateDestructibleComponentFromPath_DestructibleMeshArray_PropertyAddress, CachedMarshalingDelegates<UDestructibleComponent, UObjectMarshaler<UDestructibleComponent>>.FromNative, CachedMarshalingDelegates<UDestructibleComponent, UObjectMarshaler<UDestructibleComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GenerateDestructibleComponentFromPath_DestructibleMeshArray_Offset));
		NativeReflection.DestroyValue_InContainer(GenerateDestructibleComponentFromPath_DestructibleMeshArray_PropertyAddress.Address, intPtr);
		BoneNameArray = new TArrayCopyMarshaler<FName>(1, GenerateDestructibleComponentFromPath_BoneNameArray_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GenerateDestructibleComponentFromPath_BoneNameArray_Offset));
		NativeReflection.DestroyValue_InContainer(GenerateDestructibleComponentFromPath_BoneNameArray_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GenerateDestructibleComponentFromPath_ReturnValue_Offset), 0, GenerateDestructibleComponentFromPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GenerateDefaultAxisParameters")]
	public unsafe static bool GenerateDefaultAxisParameters(UBlendSpace BlendSpace)
	{
		if (!GenerateDefaultAxisParameters_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GenerateDefaultAxisParameters");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateDefaultAxisParameters_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateDefaultAxisParameters_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(intPtr, GenerateDefaultAxisParameters_BlendSpace_Offset), 0, GenerateDefaultAxisParameters_BlendSpace_PropertyAddress.Address, BlendSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GenerateDefaultAxisParameters_FunctionAddress, intPtr, GenerateDefaultAxisParameters_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GenerateDefaultAxisParameters_ReturnValue_Offset), 0, GenerateDefaultAxisParameters_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:GenerateAimOffsetBlendSpace")]
	public unsafe static bool GenerateAimOffsetBlendSpace(UAimOffsetBlendSpace AimOffset, string Path, string ExampleName)
	{
		if (!GenerateAimOffsetBlendSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:GenerateAimOffsetBlendSpace");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateAimOffsetBlendSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateAimOffsetBlendSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAimOffsetBlendSpace>.ToNative(IntPtr.Add(intPtr, GenerateAimOffsetBlendSpace_AimOffset_Offset), 0, GenerateAimOffsetBlendSpace_AimOffset_PropertyAddress.Address, AimOffset);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GenerateAimOffsetBlendSpace_Path_Offset), 0, GenerateAimOffsetBlendSpace_Path_PropertyAddress.Address, Path);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GenerateAimOffsetBlendSpace_ExampleName_Offset), 0, GenerateAimOffsetBlendSpace_ExampleName_PropertyAddress.Address, ExampleName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GenerateAimOffsetBlendSpace_FunctionAddress, intPtr, GenerateAimOffsetBlendSpace_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GenerateAimOffsetBlendSpace_Path_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GenerateAimOffsetBlendSpace_ExampleName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GenerateAimOffsetBlendSpace_ReturnValue_Offset), 0, GenerateAimOffsetBlendSpace_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:FindDestructibleMeshFromPathByBoneName")]
	public unsafe static UObject FindDestructibleMeshFromPathByBoneName(string FolderPath, string BoneName)
	{
		if (!FindDestructibleMeshFromPathByBoneName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:FindDestructibleMeshFromPathByBoneName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindDestructibleMeshFromPathByBoneName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindDestructibleMeshFromPathByBoneName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindDestructibleMeshFromPathByBoneName_FolderPath_Offset), 0, FindDestructibleMeshFromPathByBoneName_FolderPath_PropertyAddress.Address, FolderPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindDestructibleMeshFromPathByBoneName_BoneName_Offset), 0, FindDestructibleMeshFromPathByBoneName_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindDestructibleMeshFromPathByBoneName_FunctionAddress, intPtr, FindDestructibleMeshFromPathByBoneName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindDestructibleMeshFromPathByBoneName_FolderPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(FindDestructibleMeshFromPathByBoneName_BoneName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, FindDestructibleMeshFromPathByBoneName_ReturnValue_Offset), 0, FindDestructibleMeshFromPathByBoneName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:FindAsset")]
	public unsafe static void FindAsset(string Path, TSubclassOf<UObject> inClass, out List<FAssetData> AssetData)
	{
		if (!FindAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:FindAsset");
			AssetData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindAsset_Path_Offset), 0, FindAsset_Path_PropertyAddress.Address, Path);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FindAsset_inClass_Offset), 0, FindAsset_inClass_PropertyAddress.Address, inClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindAsset_FunctionAddress, intPtr, FindAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindAsset_Path_PropertyAddress.Address, intPtr);
		AssetData = new TArrayCopyMarshaler<FAssetData>(1, FindAsset_AssetData_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, FindAsset_AssetData_Offset));
		NativeReflection.DestroyValue_InContainer(FindAsset_AssetData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:ExtractRootMotionFromAnimation")]
	public unsafe static FTransform ExtractRootMotionFromAnimation(UAnimSequenceBase Animation, float StartTime, float EndTime)
	{
		if (!ExtractRootMotionFromAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:ExtractRootMotionFromAnimation");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExtractRootMotionFromAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExtractRootMotionFromAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, ExtractRootMotionFromAnimation_Animation_Offset), 0, ExtractRootMotionFromAnimation_Animation_PropertyAddress.Address, Animation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ExtractRootMotionFromAnimation_StartTime_Offset), 0, ExtractRootMotionFromAnimation_StartTime_PropertyAddress.Address, StartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ExtractRootMotionFromAnimation_EndTime_Offset), 0, ExtractRootMotionFromAnimation_EndTime_PropertyAddress.Address, EndTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExtractRootMotionFromAnimation_FunctionAddress, intPtr, ExtractRootMotionFromAnimation_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, ExtractRootMotionFromAnimation_ReturnValue_Offset), 0, ExtractRootMotionFromAnimation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:DisableMontageRootMotionByInstanceID")]
	public unsafe static void DisableMontageRootMotionByInstanceID(ACharacter Character, int MontageInstanceID)
	{
		if (!DisableMontageRootMotionByInstanceID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:DisableMontageRootMotionByInstanceID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableMontageRootMotionByInstanceID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableMontageRootMotionByInstanceID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, DisableMontageRootMotionByInstanceID_Character_Offset), 0, DisableMontageRootMotionByInstanceID_Character_PropertyAddress.Address, Character);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DisableMontageRootMotionByInstanceID_MontageInstanceID_Offset), 0, DisableMontageRootMotionByInstanceID_MontageInstanceID_PropertyAddress.Address, MontageInstanceID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DisableMontageRootMotionByInstanceID_FunctionAddress, intPtr, DisableMontageRootMotionByInstanceID_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:CreateBlendSpace1D")]
	public unsafe static UBlendSpace1D CreateBlendSpace1D(string Path, string Name, USkeleton TargetSkeleton)
	{
		if (!CreateBlendSpace1D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:CreateBlendSpace1D");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateBlendSpace1D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateBlendSpace1D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateBlendSpace1D_Path_Offset), 0, CreateBlendSpace1D_Path_PropertyAddress.Address, Path);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateBlendSpace1D_Name_Offset), 0, CreateBlendSpace1D_Name_PropertyAddress.Address, Name);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, CreateBlendSpace1D_TargetSkeleton_Offset), 0, CreateBlendSpace1D_TargetSkeleton_PropertyAddress.Address, TargetSkeleton);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateBlendSpace1D_FunctionAddress, intPtr, CreateBlendSpace1D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateBlendSpace1D_Path_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateBlendSpace1D_Name_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UBlendSpace1D>.FromNative(IntPtr.Add(intPtr, CreateBlendSpace1D_ReturnValue_Offset), 0, CreateBlendSpace1D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:CreateBlendSpace")]
	public unsafe static UBlendSpace CreateBlendSpace(string Path, string Name, USkeleton TargetSkeleton)
	{
		if (!CreateBlendSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:CreateBlendSpace");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateBlendSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateBlendSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateBlendSpace_Path_Offset), 0, CreateBlendSpace_Path_PropertyAddress.Address, Path);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateBlendSpace_Name_Offset), 0, CreateBlendSpace_Name_PropertyAddress.Address, Name);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, CreateBlendSpace_TargetSkeleton_Offset), 0, CreateBlendSpace_TargetSkeleton_PropertyAddress.Address, TargetSkeleton);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateBlendSpace_FunctionAddress, intPtr, CreateBlendSpace_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateBlendSpace_Path_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateBlendSpace_Name_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(intPtr, CreateBlendSpace_ReturnValue_Offset), 0, CreateBlendSpace_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:CreateAnimMontage")]
	public unsafe static UAnimMontage CreateAnimMontage(string Path, string Name, USkeleton TargetSkeleton)
	{
		if (!CreateAnimMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:CreateAnimMontage");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateAnimMontage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateAnimMontage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateAnimMontage_Path_Offset), 0, CreateAnimMontage_Path_PropertyAddress.Address, Path);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateAnimMontage_Name_Offset), 0, CreateAnimMontage_Name_PropertyAddress.Address, Name);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, CreateAnimMontage_TargetSkeleton_Offset), 0, CreateAnimMontage_TargetSkeleton_PropertyAddress.Address, TargetSkeleton);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateAnimMontage_FunctionAddress, intPtr, CreateAnimMontage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateAnimMontage_Path_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateAnimMontage_Name_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(intPtr, CreateAnimMontage_ReturnValue_Offset), 0, CreateAnimMontage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:CreateAimOffsetBlendSpace")]
	public unsafe static UAimOffsetBlendSpace CreateAimOffsetBlendSpace(string Path, string Name, USkeleton TargetSkeleton)
	{
		if (!CreateAimOffsetBlendSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:CreateAimOffsetBlendSpace");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateAimOffsetBlendSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateAimOffsetBlendSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateAimOffsetBlendSpace_Path_Offset), 0, CreateAimOffsetBlendSpace_Path_PropertyAddress.Address, Path);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateAimOffsetBlendSpace_Name_Offset), 0, CreateAimOffsetBlendSpace_Name_PropertyAddress.Address, Name);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, CreateAimOffsetBlendSpace_TargetSkeleton_Offset), 0, CreateAimOffsetBlendSpace_TargetSkeleton_PropertyAddress.Address, TargetSkeleton);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateAimOffsetBlendSpace_FunctionAddress, intPtr, CreateAimOffsetBlendSpace_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateAimOffsetBlendSpace_Path_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateAimOffsetBlendSpace_Name_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UAimOffsetBlendSpace>.FromNative(IntPtr.Add(intPtr, CreateAimOffsetBlendSpace_ReturnValue_Offset), 0, CreateAimOffsetBlendSpace_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:ConditionallyDispatchQueuedAnimEvents")]
	public unsafe static void ConditionallyDispatchQueuedAnimEvents(USkeletalMeshComponent SkeletalMeshComp)
	{
		if (!ConditionallyDispatchQueuedAnimEvents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:ConditionallyDispatchQueuedAnimEvents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConditionallyDispatchQueuedAnimEvents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConditionallyDispatchQueuedAnimEvents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, ConditionallyDispatchQueuedAnimEvents_SkeletalMeshComp_Offset), 0, ConditionallyDispatchQueuedAnimEvents_SkeletalMeshComp_PropertyAddress.Address, SkeletalMeshComp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConditionallyDispatchQueuedAnimEvents_FunctionAddress, intPtr, ConditionallyDispatchQueuedAnimEvents_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:CheckoutLoadedAssetAndSave")]
	public unsafe static void CheckoutLoadedAssetAndSave(UAnimMontage DirtyMontage)
	{
		if (!CheckoutLoadedAssetAndSave_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:CheckoutLoadedAssetAndSave");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckoutLoadedAssetAndSave_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckoutLoadedAssetAndSave_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, CheckoutLoadedAssetAndSave_DirtyMontage_Offset), 0, CheckoutLoadedAssetAndSave_DirtyMontage_PropertyAddress.Address, DirtyMontage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckoutLoadedAssetAndSave_FunctionAddress, intPtr, CheckoutLoadedAssetAndSave_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:ChangeAnimSeqParamAndSave")]
	public unsafe static bool ChangeAnimSeqParamAndSave(UAnimSequence AnimMontage, bool bRootMotion, bool bForceRootLock)
	{
		if (!ChangeAnimSeqParamAndSave_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:ChangeAnimSeqParamAndSave");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ChangeAnimSeqParamAndSave_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ChangeAnimSeqParamAndSave_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, ChangeAnimSeqParamAndSave_AnimMontage_Offset), 0, ChangeAnimSeqParamAndSave_AnimMontage_PropertyAddress.Address, AnimMontage);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ChangeAnimSeqParamAndSave_bRootMotion_Offset), 0, ChangeAnimSeqParamAndSave_bRootMotion_PropertyAddress.Address, bRootMotion);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ChangeAnimSeqParamAndSave_bForceRootLock_Offset), 0, ChangeAnimSeqParamAndSave_bForceRootLock_PropertyAddress.Address, bForceRootLock);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ChangeAnimSeqParamAndSave_FunctionAddress, intPtr, ChangeAnimSeqParamAndSave_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ChangeAnimSeqParamAndSave_ReturnValue_Offset), 0, ChangeAnimSeqParamAndSave_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:CalcSlotMontageLocalWeight")]
	public unsafe static float CalcSlotMontageLocalWeight(UAnimInstance AnimInst, FName SlotNodeName)
	{
		if (!CalcSlotMontageLocalWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:CalcSlotMontageLocalWeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalcSlotMontageLocalWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalcSlotMontageLocalWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, CalcSlotMontageLocalWeight_AnimInst_Offset), 0, CalcSlotMontageLocalWeight_AnimInst_PropertyAddress.Address, AnimInst);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CalcSlotMontageLocalWeight_SlotNodeName_Offset), 0, CalcSlotMontageLocalWeight_SlotNodeName_PropertyAddress.Address, SlotNodeName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalcSlotMontageLocalWeight_FunctionAddress, intPtr, CalcSlotMontageLocalWeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalcSlotMontageLocalWeight_ReturnValue_Offset), 0, CalcSlotMontageLocalWeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:BlendSpaceValidateSampleData")]
	public unsafe static void BlendSpaceValidateSampleData(UBlendSpace BlendSpace)
	{
		if (!BlendSpaceValidateSampleData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:BlendSpaceValidateSampleData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlendSpaceValidateSampleData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlendSpaceValidateSampleData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(intPtr, BlendSpaceValidateSampleData_BlendSpace_Offset), 0, BlendSpaceValidateSampleData_BlendSpace_PropertyAddress.Address, BlendSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BlendSpaceValidateSampleData_FunctionAddress, intPtr, BlendSpaceValidateSampleData_ParamsSize);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:ASCopyNotifies")]
	public unsafe static bool ASCopyNotifies(UAnimSequence SourceAnimSeq, UAnimSequence DestAnimSeq, bool bClearNotifiesInDestBeforeCopy, out bool bWithErrorInfo)
	{
		if (!ASCopyNotifies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:ASCopyNotifies");
			bWithErrorInfo = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ASCopyNotifies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ASCopyNotifies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, ASCopyNotifies_SourceAnimSeq_Offset), 0, ASCopyNotifies_SourceAnimSeq_PropertyAddress.Address, SourceAnimSeq);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, ASCopyNotifies_DestAnimSeq_Offset), 0, ASCopyNotifies_DestAnimSeq_PropertyAddress.Address, DestAnimSeq);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ASCopyNotifies_bClearNotifiesInDestBeforeCopy_Offset), 0, ASCopyNotifies_bClearNotifiesInDestBeforeCopy_PropertyAddress.Address, bClearNotifiesInDestBeforeCopy);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ASCopyNotifies_FunctionAddress, intPtr, ASCopyNotifies_ParamsSize);
		bWithErrorInfo = BoolMarshaler.FromNative(IntPtr.Add(intPtr, ASCopyNotifies_bWithErrorInfo_Offset), 0, ASCopyNotifies_bWithErrorInfo_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ASCopyNotifies_ReturnValue_Offset), 0, ASCopyNotifies_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:ApplyRadiusDamage")]
	public unsafe static void ApplyRadiusDamage(UDestructibleComponent Destructible, float BaseDamage, FVector HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage)
	{
		if (!ApplyRadiusDamage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:ApplyRadiusDamage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyRadiusDamage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyRadiusDamage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDestructibleComponent>.ToNative(IntPtr.Add(intPtr, ApplyRadiusDamage_Destructible_Offset), 0, ApplyRadiusDamage_Destructible_PropertyAddress.Address, Destructible);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyRadiusDamage_BaseDamage_Offset), 0, ApplyRadiusDamage_BaseDamage_PropertyAddress.Address, BaseDamage);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyRadiusDamage_HurtOrigin_Offset), 0, ApplyRadiusDamage_HurtOrigin_PropertyAddress.Address, HurtOrigin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyRadiusDamage_DamageRadius_Offset), 0, ApplyRadiusDamage_DamageRadius_PropertyAddress.Address, DamageRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyRadiusDamage_ImpulseStrength_Offset), 0, ApplyRadiusDamage_ImpulseStrength_PropertyAddress.Address, ImpulseStrength);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyRadiusDamage_bFullDamage_Offset), 0, ApplyRadiusDamage_bFullDamage_PropertyAddress.Address, bFullDamage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyRadiusDamage_FunctionAddress, intPtr, ApplyRadiusDamage_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:ApplyDamage")]
	public unsafe static void ApplyDamage(UDestructibleComponent Destructible, float DamageAmount, FVector HitLocation, FVector ImpulseDir, float ImpulseStrength)
	{
		if (!ApplyDamage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:ApplyDamage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyDamage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyDamage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDestructibleComponent>.ToNative(IntPtr.Add(intPtr, ApplyDamage_Destructible_Offset), 0, ApplyDamage_Destructible_PropertyAddress.Address, Destructible);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyDamage_DamageAmount_Offset), 0, ApplyDamage_DamageAmount_PropertyAddress.Address, DamageAmount);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyDamage_HitLocation_Offset), 0, ApplyDamage_HitLocation_PropertyAddress.Address, HitLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyDamage_ImpulseDir_Offset), 0, ApplyDamage_ImpulseDir_PropertyAddress.Address, ImpulseDir);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyDamage_ImpulseStrength_Offset), 0, ApplyDamage_ImpulseStrength_PropertyAddress.Address, ImpulseStrength);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyDamage_FunctionAddress, intPtr, ApplyDamage_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AnimSequenceGetRootMotionRotationForScale")]
	public unsafe static bool AnimSequenceGetRootMotionRotationForScale(UAnimSequence AnimMontage, out FQuat OutStartPos, out FQuat OutEndPos, float LeftScaleTime = -1f, float RightScaleTime = -1f)
	{
		if (!AnimSequenceGetRootMotionRotationForScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AnimSequenceGetRootMotionRotationForScale");
			OutStartPos = default(FQuat);
			OutEndPos = default(FQuat);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimSequenceGetRootMotionRotationForScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimSequenceGetRootMotionRotationForScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AnimSequenceGetRootMotionRotationForScale_AnimMontage_Offset), 0, AnimSequenceGetRootMotionRotationForScale_AnimMontage_PropertyAddress.Address, AnimMontage);
		NativeReflection.InitializeValue_InContainer(AnimSequenceGetRootMotionRotationForScale_OutStartPos_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(AnimSequenceGetRootMotionRotationForScale_OutEndPos_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AnimSequenceGetRootMotionRotationForScale_LeftScaleTime_Offset), 0, AnimSequenceGetRootMotionRotationForScale_LeftScaleTime_PropertyAddress.Address, LeftScaleTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AnimSequenceGetRootMotionRotationForScale_RightScaleTime_Offset), 0, AnimSequenceGetRootMotionRotationForScale_RightScaleTime_PropertyAddress.Address, RightScaleTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AnimSequenceGetRootMotionRotationForScale_FunctionAddress, intPtr, AnimSequenceGetRootMotionRotationForScale_ParamsSize);
		OutStartPos = BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(intPtr, AnimSequenceGetRootMotionRotationForScale_OutStartPos_Offset), 0, AnimSequenceGetRootMotionRotationForScale_OutStartPos_PropertyAddress.Address);
		OutEndPos = BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(intPtr, AnimSequenceGetRootMotionRotationForScale_OutEndPos_Offset), 0, AnimSequenceGetRootMotionRotationForScale_OutEndPos_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AnimSequenceGetRootMotionRotationForScale_ReturnValue_Offset), 0, AnimSequenceGetRootMotionRotationForScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AnimSequenceGetRootMotionLocationForScale")]
	public unsafe static bool AnimSequenceGetRootMotionLocationForScale(UAnimSequence AnimMontage, out FVector OutStartPos, out FVector OutEndPos, float LeftScaleTime = -1f, float RightScaleTime = -1f)
	{
		if (!AnimSequenceGetRootMotionLocationForScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AnimSequenceGetRootMotionLocationForScale");
			OutStartPos = default(FVector);
			OutEndPos = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimSequenceGetRootMotionLocationForScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimSequenceGetRootMotionLocationForScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AnimSequenceGetRootMotionLocationForScale_AnimMontage_Offset), 0, AnimSequenceGetRootMotionLocationForScale_AnimMontage_PropertyAddress.Address, AnimMontage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AnimSequenceGetRootMotionLocationForScale_LeftScaleTime_Offset), 0, AnimSequenceGetRootMotionLocationForScale_LeftScaleTime_PropertyAddress.Address, LeftScaleTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AnimSequenceGetRootMotionLocationForScale_RightScaleTime_Offset), 0, AnimSequenceGetRootMotionLocationForScale_RightScaleTime_PropertyAddress.Address, RightScaleTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AnimSequenceGetRootMotionLocationForScale_FunctionAddress, intPtr, AnimSequenceGetRootMotionLocationForScale_ParamsSize);
		OutStartPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, AnimSequenceGetRootMotionLocationForScale_OutStartPos_Offset), 0, AnimSequenceGetRootMotionLocationForScale_OutStartPos_PropertyAddress.Address);
		OutEndPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, AnimSequenceGetRootMotionLocationForScale_OutEndPos_Offset), 0, AnimSequenceGetRootMotionLocationForScale_OutEndPos_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AnimSequenceGetRootMotionLocationForScale_ReturnValue_Offset), 0, AnimSequenceGetRootMotionLocationForScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AnimSequenceFindPosWithDistanceCurve")]
	public unsafe static float AnimSequenceFindPosWithDistanceCurve(UAnimSequence AnimationSequence, FName CurveName, float DistanceValue)
	{
		if (!AnimSequenceFindPosWithDistanceCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AnimSequenceFindPosWithDistanceCurve");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimSequenceFindPosWithDistanceCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimSequenceFindPosWithDistanceCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AnimSequenceFindPosWithDistanceCurve_AnimationSequence_Offset), 0, AnimSequenceFindPosWithDistanceCurve_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AnimSequenceFindPosWithDistanceCurve_CurveName_Offset), 0, AnimSequenceFindPosWithDistanceCurve_CurveName_PropertyAddress.Address, CurveName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AnimSequenceFindPosWithDistanceCurve_DistanceValue_Offset), 0, AnimSequenceFindPosWithDistanceCurve_DistanceValue_PropertyAddress.Address, DistanceValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AnimSequenceFindPosWithDistanceCurve_FunctionAddress, intPtr, AnimSequenceFindPosWithDistanceCurve_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, AnimSequenceFindPosWithDistanceCurve_ReturnValue_Offset), 0, AnimSequenceFindPosWithDistanceCurve_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetSocketLocationForScale")]
	public unsafe static bool AnimMontageGetSocketLocationForScale(UAnimMontage AnimMontage, out FVector OutEndPos, float ScaleTime, string SocketName)
	{
		if (!AnimMontageGetSocketLocationForScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetSocketLocationForScale");
			OutEndPos = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimMontageGetSocketLocationForScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimMontageGetSocketLocationForScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, AnimMontageGetSocketLocationForScale_AnimMontage_Offset), 0, AnimMontageGetSocketLocationForScale_AnimMontage_PropertyAddress.Address, AnimMontage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AnimMontageGetSocketLocationForScale_ScaleTime_Offset), 0, AnimMontageGetSocketLocationForScale_ScaleTime_PropertyAddress.Address, ScaleTime);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AnimMontageGetSocketLocationForScale_SocketName_Offset), 0, AnimMontageGetSocketLocationForScale_SocketName_PropertyAddress.Address, SocketName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AnimMontageGetSocketLocationForScale_FunctionAddress, intPtr, AnimMontageGetSocketLocationForScale_ParamsSize);
		OutEndPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, AnimMontageGetSocketLocationForScale_OutEndPos_Offset), 0, AnimMontageGetSocketLocationForScale_OutEndPos_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AnimMontageGetSocketLocationForScale_SocketName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AnimMontageGetSocketLocationForScale_ReturnValue_Offset), 0, AnimMontageGetSocketLocationForScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetRootMotionRotationForScale")]
	public unsafe static bool AnimMontageGetRootMotionRotationForScale(UAnimMontage AnimMontage, out FRotator OutStartRotation, out FRotator OutEndRotation, float LeftScaleTime = -1f, float RightScaleTime = -1f)
	{
		if (!AnimMontageGetRootMotionRotationForScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetRootMotionRotationForScale");
			OutStartRotation = default(FRotator);
			OutEndRotation = default(FRotator);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimMontageGetRootMotionRotationForScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimMontageGetRootMotionRotationForScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, AnimMontageGetRootMotionRotationForScale_AnimMontage_Offset), 0, AnimMontageGetRootMotionRotationForScale_AnimMontage_PropertyAddress.Address, AnimMontage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AnimMontageGetRootMotionRotationForScale_LeftScaleTime_Offset), 0, AnimMontageGetRootMotionRotationForScale_LeftScaleTime_PropertyAddress.Address, LeftScaleTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AnimMontageGetRootMotionRotationForScale_RightScaleTime_Offset), 0, AnimMontageGetRootMotionRotationForScale_RightScaleTime_PropertyAddress.Address, RightScaleTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AnimMontageGetRootMotionRotationForScale_FunctionAddress, intPtr, AnimMontageGetRootMotionRotationForScale_ParamsSize);
		OutStartRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, AnimMontageGetRootMotionRotationForScale_OutStartRotation_Offset), 0, AnimMontageGetRootMotionRotationForScale_OutStartRotation_PropertyAddress.Address);
		OutEndRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, AnimMontageGetRootMotionRotationForScale_OutEndRotation_Offset), 0, AnimMontageGetRootMotionRotationForScale_OutEndRotation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AnimMontageGetRootMotionRotationForScale_ReturnValue_Offset), 0, AnimMontageGetRootMotionRotationForScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetRootMotionLocationForScale")]
	public unsafe static bool AnimMontageGetRootMotionLocationForScale(UAnimMontage AnimMontage, out FVector OutStartPos, out FVector OutEndPos, float LeftScaleTime = -1f, float RightScaleTime = -1f)
	{
		if (!AnimMontageGetRootMotionLocationForScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetRootMotionLocationForScale");
			OutStartPos = default(FVector);
			OutEndPos = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimMontageGetRootMotionLocationForScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimMontageGetRootMotionLocationForScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, AnimMontageGetRootMotionLocationForScale_AnimMontage_Offset), 0, AnimMontageGetRootMotionLocationForScale_AnimMontage_PropertyAddress.Address, AnimMontage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AnimMontageGetRootMotionLocationForScale_LeftScaleTime_Offset), 0, AnimMontageGetRootMotionLocationForScale_LeftScaleTime_PropertyAddress.Address, LeftScaleTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AnimMontageGetRootMotionLocationForScale_RightScaleTime_Offset), 0, AnimMontageGetRootMotionLocationForScale_RightScaleTime_PropertyAddress.Address, RightScaleTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AnimMontageGetRootMotionLocationForScale_FunctionAddress, intPtr, AnimMontageGetRootMotionLocationForScale_ParamsSize);
		OutStartPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, AnimMontageGetRootMotionLocationForScale_OutStartPos_Offset), 0, AnimMontageGetRootMotionLocationForScale_OutStartPos_PropertyAddress.Address);
		OutEndPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, AnimMontageGetRootMotionLocationForScale_OutEndPos_Offset), 0, AnimMontageGetRootMotionLocationForScale_OutEndPos_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AnimMontageGetRootMotionLocationForScale_ReturnValue_Offset), 0, AnimMontageGetRootMotionLocationForScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetQTEBoneTransform")]
	public unsafe static FTransform AnimMontageGetQTEBoneTransform(UAnimMontage AnimMontage, USkeletalMeshComponent MeshComponent, FName BoneName, float Pos)
	{
		if (!AnimMontageGetQTEBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetQTEBoneTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimMontageGetQTEBoneTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimMontageGetQTEBoneTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, AnimMontageGetQTEBoneTransform_AnimMontage_Offset), 0, AnimMontageGetQTEBoneTransform_AnimMontage_PropertyAddress.Address, AnimMontage);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, AnimMontageGetQTEBoneTransform_MeshComponent_Offset), 0, AnimMontageGetQTEBoneTransform_MeshComponent_PropertyAddress.Address, MeshComponent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AnimMontageGetQTEBoneTransform_BoneName_Offset), 0, AnimMontageGetQTEBoneTransform_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AnimMontageGetQTEBoneTransform_Pos_Offset), 0, AnimMontageGetQTEBoneTransform_Pos_PropertyAddress.Address, Pos);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AnimMontageGetQTEBoneTransform_FunctionAddress, intPtr, AnimMontageGetQTEBoneTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, AnimMontageGetQTEBoneTransform_ReturnValue_Offset), 0, AnimMontageGetQTEBoneTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetMontageEndTimeForScale")]
	public unsafe static float AnimMontageGetMontageEndTimeForScale(UAnimMontage AnimMontage)
	{
		if (!AnimMontageGetMontageEndTimeForScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetMontageEndTimeForScale");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimMontageGetMontageEndTimeForScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimMontageGetMontageEndTimeForScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, AnimMontageGetMontageEndTimeForScale_AnimMontage_Offset), 0, AnimMontageGetMontageEndTimeForScale_AnimMontage_PropertyAddress.Address, AnimMontage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AnimMontageGetMontageEndTimeForScale_FunctionAddress, intPtr, AnimMontageGetMontageEndTimeForScale_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, AnimMontageGetMontageEndTimeForScale_ReturnValue_Offset), 0, AnimMontageGetMontageEndTimeForScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetBoneTransformWS")]
	public unsafe static FTransform AnimMontageGetBoneTransformWS(UAnimMontage AnimMontage, USkeletalMeshComponent MeshComponent, FName BoneName, float Pos, bool IsNeedFixRotator = false, FRotator FixRotator = default(FRotator))
	{
		if (!AnimMontageGetBoneTransformWS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetBoneTransformWS");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimMontageGetBoneTransformWS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimMontageGetBoneTransformWS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, AnimMontageGetBoneTransformWS_AnimMontage_Offset), 0, AnimMontageGetBoneTransformWS_AnimMontage_PropertyAddress.Address, AnimMontage);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, AnimMontageGetBoneTransformWS_MeshComponent_Offset), 0, AnimMontageGetBoneTransformWS_MeshComponent_PropertyAddress.Address, MeshComponent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AnimMontageGetBoneTransformWS_BoneName_Offset), 0, AnimMontageGetBoneTransformWS_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AnimMontageGetBoneTransformWS_Pos_Offset), 0, AnimMontageGetBoneTransformWS_Pos_PropertyAddress.Address, Pos);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AnimMontageGetBoneTransformWS_IsNeedFixRotator_Offset), 0, AnimMontageGetBoneTransformWS_IsNeedFixRotator_PropertyAddress.Address, IsNeedFixRotator);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, AnimMontageGetBoneTransformWS_FixRotator_Offset), 0, AnimMontageGetBoneTransformWS_FixRotator_PropertyAddress.Address, FixRotator);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AnimMontageGetBoneTransformWS_FunctionAddress, intPtr, AnimMontageGetBoneTransformWS_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, AnimMontageGetBoneTransformWS_ReturnValue_Offset), 0, AnimMontageGetBoneTransformWS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetBlendInAndOutTime")]
	public unsafe static void AnimMontageGetBlendInAndOutTime(UAnimMontage AnimMontage, out float BlendInTime, out float BlendOutTime)
	{
		if (!AnimMontageGetBlendInAndOutTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetBlendInAndOutTime");
			BlendInTime = 0f;
			BlendOutTime = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimMontageGetBlendInAndOutTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimMontageGetBlendInAndOutTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, AnimMontageGetBlendInAndOutTime_AnimMontage_Offset), 0, AnimMontageGetBlendInAndOutTime_AnimMontage_PropertyAddress.Address, AnimMontage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AnimMontageGetBlendInAndOutTime_FunctionAddress, intPtr, AnimMontageGetBlendInAndOutTime_ParamsSize);
		BlendInTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, AnimMontageGetBlendInAndOutTime_BlendInTime_Offset), 0, AnimMontageGetBlendInAndOutTime_BlendInTime_PropertyAddress.Address);
		BlendOutTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, AnimMontageGetBlendInAndOutTime_BlendOutTime_Offset), 0, AnimMontageGetBlendInAndOutTime_BlendOutTime_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AnimInstanceMontageSetPos")]
	public unsafe static void AnimInstanceMontageSetPos(UAnimInstance AnimInst, float MontagePos)
	{
		if (!AnimInstanceMontageSetPos_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AnimInstanceMontageSetPos");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimInstanceMontageSetPos_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimInstanceMontageSetPos_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, AnimInstanceMontageSetPos_AnimInst_Offset), 0, AnimInstanceMontageSetPos_AnimInst_PropertyAddress.Address, AnimInst);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AnimInstanceMontageSetPos_MontagePos_Offset), 0, AnimInstanceMontageSetPos_MontagePos_PropertyAddress.Address, MontagePos);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AnimInstanceMontageSetPos_FunctionAddress, intPtr, AnimInstanceMontageSetPos_ParamsSize);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AMCopyNotifies")]
	public unsafe static bool AMCopyNotifies(UAnimMontage SourceAnimMontage, UAnimMontage DestAnimMontage, bool bClearNotifiesInDestBeforeCopy, out bool bWithErrorInfo)
	{
		if (!AMCopyNotifies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AMCopyNotifies");
			bWithErrorInfo = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AMCopyNotifies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AMCopyNotifies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, AMCopyNotifies_SourceAnimMontage_Offset), 0, AMCopyNotifies_SourceAnimMontage_PropertyAddress.Address, SourceAnimMontage);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, AMCopyNotifies_DestAnimMontage_Offset), 0, AMCopyNotifies_DestAnimMontage_PropertyAddress.Address, DestAnimMontage);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AMCopyNotifies_bClearNotifiesInDestBeforeCopy_Offset), 0, AMCopyNotifies_bClearNotifiesInDestBeforeCopy_PropertyAddress.Address, bClearNotifiesInDestBeforeCopy);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AMCopyNotifies_FunctionAddress, intPtr, AMCopyNotifies_ParamsSize);
		bWithErrorInfo = BoolMarshaler.FromNative(IntPtr.Add(intPtr, AMCopyNotifies_bWithErrorInfo_Offset), 0, AMCopyNotifies_bWithErrorInfo_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AMCopyNotifies_ReturnValue_Offset), 0, AMCopyNotifies_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AMCopyBlendOption")]
	public unsafe static bool AMCopyBlendOption(UAnimMontage SourceAnimMontage, UAnimMontage DestAnimMontage)
	{
		if (!AMCopyBlendOption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AMCopyBlendOption");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AMCopyBlendOption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AMCopyBlendOption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, AMCopyBlendOption_SourceAnimMontage_Offset), 0, AMCopyBlendOption_SourceAnimMontage_PropertyAddress.Address, SourceAnimMontage);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, AMCopyBlendOption_DestAnimMontage_Offset), 0, AMCopyBlendOption_DestAnimMontage_PropertyAddress.Address, DestAnimMontage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AMCopyBlendOption_FunctionAddress, intPtr, AMCopyBlendOption_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AMCopyBlendOption_ReturnValue_Offset), 0, AMCopyBlendOption_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AddUVChannel")]
	public unsafe static bool AddUVChannel(UStaticMesh StaticMesh, int LODIndex)
	{
		if (!AddUVChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AddUVChannel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddUVChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddUVChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, AddUVChannel_StaticMesh_Offset), 0, AddUVChannel_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddUVChannel_LODIndex_Offset), 0, AddUVChannel_LODIndex_PropertyAddress.Address, LODIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddUVChannel_FunctionAddress, intPtr, AddUVChannel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddUVChannel_ReturnValue_Offset), 0, AddUVChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AddSocketToSkeleton")]
	public unsafe static bool AddSocketToSkeleton(USkeleton InUSkeleton, string BoneName, string SocketName, FTransform Offset)
	{
		if (!AddSocketToSkeleton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AddSocketToSkeleton");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSocketToSkeleton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSocketToSkeleton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, AddSocketToSkeleton_InUSkeleton_Offset), 0, AddSocketToSkeleton_InUSkeleton_PropertyAddress.Address, InUSkeleton);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddSocketToSkeleton_BoneName_Offset), 0, AddSocketToSkeleton_BoneName_PropertyAddress.Address, BoneName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddSocketToSkeleton_SocketName_Offset), 0, AddSocketToSkeleton_SocketName_PropertyAddress.Address, SocketName);
		NativeReflection.InitializeValue_InContainer(AddSocketToSkeleton_Offset_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddSocketToSkeleton_Offset_Offset), 0, AddSocketToSkeleton_Offset_PropertyAddress.Address, Offset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddSocketToSkeleton_FunctionAddress, intPtr, AddSocketToSkeleton_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddSocketToSkeleton_BoneName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddSocketToSkeleton_SocketName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddSocketToSkeleton_ReturnValue_Offset), 0, AddSocketToSkeleton_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AddPreviewAssetToSkeleton")]
	public unsafe static bool AddPreviewAssetToSkeleton(USkeleton InUSkeleton, string BoneName, UObject PreviewAsset)
	{
		if (!AddPreviewAssetToSkeleton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AddPreviewAssetToSkeleton");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddPreviewAssetToSkeleton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddPreviewAssetToSkeleton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, AddPreviewAssetToSkeleton_InUSkeleton_Offset), 0, AddPreviewAssetToSkeleton_InUSkeleton_PropertyAddress.Address, InUSkeleton);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddPreviewAssetToSkeleton_BoneName_Offset), 0, AddPreviewAssetToSkeleton_BoneName_PropertyAddress.Address, BoneName);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddPreviewAssetToSkeleton_PreviewAsset_Offset), 0, AddPreviewAssetToSkeleton_PreviewAsset_PropertyAddress.Address, PreviewAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddPreviewAssetToSkeleton_FunctionAddress, intPtr, AddPreviewAssetToSkeleton_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddPreviewAssetToSkeleton_BoneName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddPreviewAssetToSkeleton_ReturnValue_Offset), 0, AddPreviewAssetToSkeleton_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AddPoint")]
	public unsafe static bool AddPoint(UBlendSpace BlendSpace, UAnimSequence PointSequence, FVector PointValue)
	{
		if (!AddPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AddPoint");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(intPtr, AddPoint_BlendSpace_Offset), 0, AddPoint_BlendSpace_PropertyAddress.Address, BlendSpace);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AddPoint_PointSequence_Offset), 0, AddPoint_PointSequence_PropertyAddress.Address, PointSequence);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddPoint_PointValue_Offset), 0, AddPoint_PointValue_PropertyAddress.Address, PointValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddPoint_FunctionAddress, intPtr, AddPoint_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddPoint_ReturnValue_Offset), 0, AddPoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AddAnimSequence")]
	public unsafe static bool AddAnimSequence(UAnimMontage TargetMontage, UAnimSequence Sequence)
	{
		if (!AddAnimSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AddAnimSequence");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAnimSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAnimSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, AddAnimSequence_TargetMontage_Offset), 0, AddAnimSequence_TargetMontage_PropertyAddress.Address, TargetMontage);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AddAnimSequence_Sequence_Offset), 0, AddAnimSequence_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAnimSequence_FunctionAddress, intPtr, AddAnimSequence_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddAnimSequence_ReturnValue_Offset), 0, AddAnimSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AddAnimationNotifyStateEvent")]
	public unsafe static UAnimNotifyState AddAnimationNotifyStateEvent(UAnimSequenceBase AnimBase, FName NotifyTrackName, float StartTime, float Duration, TSubclassOf<UAnimNotifyState> NotifyStateClass)
	{
		if (!AddAnimationNotifyStateEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AddAnimationNotifyStateEvent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAnimationNotifyStateEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAnimationNotifyStateEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEvent_AnimBase_Offset), 0, AddAnimationNotifyStateEvent_AnimBase_PropertyAddress.Address, AnimBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEvent_NotifyTrackName_Offset), 0, AddAnimationNotifyStateEvent_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEvent_StartTime_Offset), 0, AddAnimationNotifyStateEvent_StartTime_PropertyAddress.Address, StartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEvent_Duration_Offset), 0, AddAnimationNotifyStateEvent_Duration_PropertyAddress.Address, Duration);
		TSubclassOfMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEvent_NotifyStateClass_Offset), 0, AddAnimationNotifyStateEvent_NotifyStateClass_PropertyAddress.Address, NotifyStateClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAnimationNotifyStateEvent_FunctionAddress, intPtr, AddAnimationNotifyStateEvent_ParamsSize);
		return UObjectMarshaler<UAnimNotifyState>.FromNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEvent_ReturnValue_Offset), 0, AddAnimationNotifyStateEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:AddAnimationNotifyEvent")]
	public unsafe static UAnimNotify AddAnimationNotifyEvent(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName, float StartTime, TSubclassOf<UAnimNotify> NotifyClass)
	{
		if (!AddAnimationNotifyEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:AddAnimationNotifyEvent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAnimationNotifyEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAnimationNotifyEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyEvent_AnimationSequenceBase_Offset), 0, AddAnimationNotifyEvent_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyEvent_NotifyTrackName_Offset), 0, AddAnimationNotifyEvent_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyEvent_StartTime_Offset), 0, AddAnimationNotifyEvent_StartTime_PropertyAddress.Address, StartTime);
		TSubclassOfMarshaler<UAnimNotify>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyEvent_NotifyClass_Offset), 0, AddAnimationNotifyEvent_NotifyClass_PropertyAddress.Address, NotifyClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAnimationNotifyEvent_FunctionAddress, intPtr, AddAnimationNotifyEvent_ParamsSize);
		return UObjectMarshaler<UAnimNotify>.FromNative(IntPtr.Add(intPtr, AddAnimationNotifyEvent_ReturnValue_Offset), 0, AddAnimationNotifyEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimFuncLib:ABPStateMachineGetGlobalWeight")]
	public unsafe static float ABPStateMachineGetGlobalWeight(UAnimInstance AnimInst, FName StateMachineName, FName StateName)
	{
		if (!ABPStateMachineGetGlobalWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimFuncLib:ABPStateMachineGetGlobalWeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ABPStateMachineGetGlobalWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ABPStateMachineGetGlobalWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, ABPStateMachineGetGlobalWeight_AnimInst_Offset), 0, ABPStateMachineGetGlobalWeight_AnimInst_PropertyAddress.Address, AnimInst);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ABPStateMachineGetGlobalWeight_StateMachineName_Offset), 0, ABPStateMachineGetGlobalWeight_StateMachineName_PropertyAddress.Address, StateMachineName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ABPStateMachineGetGlobalWeight_StateName_Offset), 0, ABPStateMachineGetGlobalWeight_StateName_PropertyAddress.Address, StateName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ABPStateMachineGetGlobalWeight_FunctionAddress, intPtr, ABPStateMachineGetGlobalWeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, ABPStateMachineGetGlobalWeight_ReturnValue_Offset), 0, ABPStateMachineGetGlobalWeight_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_AnimFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_AnimFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_AnimFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_AnimFuncLib");
		TickAnimationAndRefreshBone_SkeletalMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TickAnimationAndRefreshBone_SkeletalMesh");
		TickAnimationAndRefreshBone_SkeletalMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(TickAnimationAndRefreshBone_SkeletalMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TickAnimationAndRefreshBone_SkeletalMesh_SkeletalMeshComp_PropertyAddress, TickAnimationAndRefreshBone_SkeletalMesh_FunctionAddress, "SkeletalMeshComp");
		TickAnimationAndRefreshBone_SkeletalMesh_SkeletalMeshComp_Offset = NativeReflectionCached.GetPropertyOffset(TickAnimationAndRefreshBone_SkeletalMesh_FunctionAddress, "SkeletalMeshComp");
		TickAnimationAndRefreshBone_SkeletalMesh_SkeletalMeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(TickAnimationAndRefreshBone_SkeletalMesh_FunctionAddress, "SkeletalMeshComp", Classes.FObjectProperty);
		TickAnimationAndRefreshBone_SkeletalMesh_IsValid = TickAnimationAndRefreshBone_SkeletalMesh_FunctionAddress != IntPtr.Zero && TickAnimationAndRefreshBone_SkeletalMesh_SkeletalMeshComp_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:TickAnimationAndRefreshBone_SkeletalMesh", TickAnimationAndRefreshBone_SkeletalMesh_IsValid);
		TickAnimationAndRefreshBone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TickAnimationAndRefreshBone");
		TickAnimationAndRefreshBone_ParamsSize = NativeReflection.GetFunctionParamsSize(TickAnimationAndRefreshBone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TickAnimationAndRefreshBone_Owner_PropertyAddress, TickAnimationAndRefreshBone_FunctionAddress, "Owner");
		TickAnimationAndRefreshBone_Owner_Offset = NativeReflectionCached.GetPropertyOffset(TickAnimationAndRefreshBone_FunctionAddress, "Owner");
		TickAnimationAndRefreshBone_Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(TickAnimationAndRefreshBone_FunctionAddress, "Owner", Classes.FObjectProperty);
		TickAnimationAndRefreshBone_IsValid = TickAnimationAndRefreshBone_FunctionAddress != IntPtr.Zero && TickAnimationAndRefreshBone_Owner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:TickAnimationAndRefreshBone", TickAnimationAndRefreshBone_IsValid);
		TickAnimation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TickAnimation");
		TickAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(TickAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TickAnimation_Owner_PropertyAddress, TickAnimation_FunctionAddress, "Owner");
		TickAnimation_Owner_Offset = NativeReflectionCached.GetPropertyOffset(TickAnimation_FunctionAddress, "Owner");
		TickAnimation_Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(TickAnimation_FunctionAddress, "Owner", Classes.FObjectProperty);
		TickAnimation_IsValid = TickAnimation_FunctionAddress != IntPtr.Zero && TickAnimation_Owner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:TickAnimation", TickAnimation_IsValid);
		StopAllMontages_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopAllMontages");
		StopAllMontages_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAllMontages_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAllMontages_Owner_PropertyAddress, StopAllMontages_FunctionAddress, "Owner");
		StopAllMontages_Owner_Offset = NativeReflectionCached.GetPropertyOffset(StopAllMontages_FunctionAddress, "Owner");
		StopAllMontages_Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllMontages_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StopAllMontages_BlendOutTime_PropertyAddress, StopAllMontages_FunctionAddress, "BlendOutTime");
		StopAllMontages_BlendOutTime_Offset = NativeReflectionCached.GetPropertyOffset(StopAllMontages_FunctionAddress, "BlendOutTime");
		StopAllMontages_BlendOutTime_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAllMontages_FunctionAddress, "BlendOutTime", Classes.FFloatProperty);
		StopAllMontages_IsValid = StopAllMontages_FunctionAddress != IntPtr.Zero && StopAllMontages_Owner_IsValid && StopAllMontages_BlendOutTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:StopAllMontages", StopAllMontages_IsValid);
		SkeletonCopySockets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SkeletonCopySockets");
		SkeletonCopySockets_ParamsSize = NativeReflection.GetFunctionParamsSize(SkeletonCopySockets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SkeletonCopySockets_SourceSkeletal_PropertyAddress, SkeletonCopySockets_FunctionAddress, "SourceSkeletal");
		SkeletonCopySockets_SourceSkeletal_Offset = NativeReflectionCached.GetPropertyOffset(SkeletonCopySockets_FunctionAddress, "SourceSkeletal");
		SkeletonCopySockets_SourceSkeletal_IsValid = NativeReflectionCached.ValidatePropertyClass(SkeletonCopySockets_FunctionAddress, "SourceSkeletal", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SkeletonCopySockets_DestSkeletal_PropertyAddress, SkeletonCopySockets_FunctionAddress, "DestSkeletal");
		SkeletonCopySockets_DestSkeletal_Offset = NativeReflectionCached.GetPropertyOffset(SkeletonCopySockets_FunctionAddress, "DestSkeletal");
		SkeletonCopySockets_DestSkeletal_IsValid = NativeReflectionCached.ValidatePropertyClass(SkeletonCopySockets_FunctionAddress, "DestSkeletal", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SkeletonCopySockets_LocationScaleRate_PropertyAddress, SkeletonCopySockets_FunctionAddress, "LocationScaleRate");
		SkeletonCopySockets_LocationScaleRate_Offset = NativeReflectionCached.GetPropertyOffset(SkeletonCopySockets_FunctionAddress, "LocationScaleRate");
		SkeletonCopySockets_LocationScaleRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SkeletonCopySockets_FunctionAddress, "LocationScaleRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SkeletonCopySockets_ReturnValue_PropertyAddress, SkeletonCopySockets_FunctionAddress, "ReturnValue");
		SkeletonCopySockets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SkeletonCopySockets_FunctionAddress, "ReturnValue");
		SkeletonCopySockets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SkeletonCopySockets_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SkeletonCopySockets_IsValid = SkeletonCopySockets_FunctionAddress != IntPtr.Zero && SkeletonCopySockets_SourceSkeletal_IsValid && SkeletonCopySockets_DestSkeletal_IsValid && SkeletonCopySockets_LocationScaleRate_IsValid && SkeletonCopySockets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:SkeletonCopySockets", SkeletonCopySockets_IsValid);
		SetUV_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetUV");
		SetUV_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUV_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUV_StaticMesh_PropertyAddress, SetUV_FunctionAddress, "StaticMesh");
		SetUV_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetUV_FunctionAddress, "StaticMesh");
		SetUV_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUV_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUV_LODIndex_PropertyAddress, SetUV_FunctionAddress, "LODIndex");
		SetUV_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetUV_FunctionAddress, "LODIndex");
		SetUV_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUV_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUV_UVChannelIndex_PropertyAddress, SetUV_FunctionAddress, "UVChannelIndex");
		SetUV_UVChannelIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetUV_FunctionAddress, "UVChannelIndex");
		SetUV_UVChannelIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUV_FunctionAddress, "UVChannelIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUV_BoneWeight_PropertyAddress, SetUV_FunctionAddress, "BoneWeight");
		SetUV_BoneWeight_Offset = NativeReflectionCached.GetPropertyOffset(SetUV_FunctionAddress, "BoneWeight");
		SetUV_BoneWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUV_FunctionAddress, "BoneWeight", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUV_ReturnValue_PropertyAddress, SetUV_FunctionAddress, "ReturnValue");
		SetUV_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetUV_FunctionAddress, "ReturnValue");
		SetUV_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUV_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetUV_IsValid = SetUV_FunctionAddress != IntPtr.Zero && SetUV_StaticMesh_IsValid && SetUV_LODIndex_IsValid && SetUV_UVChannelIndex_IsValid && SetUV_BoneWeight_IsValid && SetUV_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:SetUV", SetUV_IsValid);
		SetRootMotionFromEverythingSwitch_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRootMotionFromEverythingSwitch");
		SetRootMotionFromEverythingSwitch_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRootMotionFromEverythingSwitch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRootMotionFromEverythingSwitch_Character_PropertyAddress, SetRootMotionFromEverythingSwitch_FunctionAddress, "Character");
		SetRootMotionFromEverythingSwitch_Character_Offset = NativeReflectionCached.GetPropertyOffset(SetRootMotionFromEverythingSwitch_FunctionAddress, "Character");
		SetRootMotionFromEverythingSwitch_Character_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRootMotionFromEverythingSwitch_FunctionAddress, "Character", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRootMotionFromEverythingSwitch_IsOpen_PropertyAddress, SetRootMotionFromEverythingSwitch_FunctionAddress, "IsOpen");
		SetRootMotionFromEverythingSwitch_IsOpen_Offset = NativeReflectionCached.GetPropertyOffset(SetRootMotionFromEverythingSwitch_FunctionAddress, "IsOpen");
		SetRootMotionFromEverythingSwitch_IsOpen_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRootMotionFromEverythingSwitch_FunctionAddress, "IsOpen", Classes.FBoolProperty);
		SetRootMotionFromEverythingSwitch_IsValid = SetRootMotionFromEverythingSwitch_FunctionAddress != IntPtr.Zero && SetRootMotionFromEverythingSwitch_Character_IsValid && SetRootMotionFromEverythingSwitch_IsOpen_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:SetRootMotionFromEverythingSwitch", SetRootMotionFromEverythingSwitch_IsValid);
		SetMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMaterial");
		SetMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_Material_PropertyAddress, SetMaterial_FunctionAddress, "Material");
		SetMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "Material");
		SetMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_TargetMesh_PropertyAddress, SetMaterial_FunctionAddress, "TargetMesh");
		SetMaterial_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "TargetMesh");
		SetMaterial_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMaterial_Index_PropertyAddress, SetMaterial_FunctionAddress, "Index");
		SetMaterial_Index_Offset = NativeReflectionCached.GetPropertyOffset(SetMaterial_FunctionAddress, "Index");
		SetMaterial_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaterial_FunctionAddress, "Index", Classes.FIntProperty);
		SetMaterial_IsValid = SetMaterial_FunctionAddress != IntPtr.Zero && SetMaterial_Material_IsValid && SetMaterial_TargetMesh_IsValid && SetMaterial_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:SetMaterial", SetMaterial_IsValid);
		SetBlendSpaceInput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBlendSpaceInput");
		SetBlendSpaceInput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBlendSpaceInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBlendSpaceInput_obj_PropertyAddress, SetBlendSpaceInput_FunctionAddress, "obj");
		SetBlendSpaceInput_obj_Offset = NativeReflectionCached.GetPropertyOffset(SetBlendSpaceInput_FunctionAddress, "obj");
		SetBlendSpaceInput_obj_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlendSpaceInput_FunctionAddress, "obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBlendSpaceInput_BlendParams_PropertyAddress, SetBlendSpaceInput_FunctionAddress, "BlendParams");
		SetBlendSpaceInput_BlendParams_Offset = NativeReflectionCached.GetPropertyOffset(SetBlendSpaceInput_FunctionAddress, "BlendParams");
		SetBlendSpaceInput_BlendParams_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBlendSpaceInput_FunctionAddress, "BlendParams", Classes.FStructProperty);
		SetBlendSpaceInput_IsValid = SetBlendSpaceInput_FunctionAddress != IntPtr.Zero && SetBlendSpaceInput_obj_IsValid && SetBlendSpaceInput_BlendParams_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:SetBlendSpaceInput", SetBlendSpaceInput_IsValid);
		SetAnimcurveType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAnimcurveType");
		SetAnimcurveType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimcurveType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimcurveType_Skeleton_PropertyAddress, SetAnimcurveType_FunctionAddress, "Skeleton");
		SetAnimcurveType_Skeleton_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimcurveType_FunctionAddress, "Skeleton");
		SetAnimcurveType_Skeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimcurveType_FunctionAddress, "Skeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimcurveType_CurveName_PropertyAddress, SetAnimcurveType_FunctionAddress, "CurveName");
		SetAnimcurveType_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimcurveType_FunctionAddress, "CurveName");
		SetAnimcurveType_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimcurveType_FunctionAddress, "CurveName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimcurveType_Value_PropertyAddress, SetAnimcurveType_FunctionAddress, "Value");
		SetAnimcurveType_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimcurveType_FunctionAddress, "Value");
		SetAnimcurveType_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimcurveType_FunctionAddress, "Value", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimcurveType_ReturnValue_PropertyAddress, SetAnimcurveType_FunctionAddress, "ReturnValue");
		SetAnimcurveType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimcurveType_FunctionAddress, "ReturnValue");
		SetAnimcurveType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimcurveType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetAnimcurveType_IsValid = SetAnimcurveType_FunctionAddress != IntPtr.Zero && SetAnimcurveType_Skeleton_IsValid && SetAnimcurveType_CurveName_IsValid && SetAnimcurveType_Value_IsValid && SetAnimcurveType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:SetAnimcurveType", SetAnimcurveType_IsValid);
		SetAnimationNotifyStartTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAnimationNotifyStartTime");
		SetAnimationNotifyStartTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimationNotifyStartTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationNotifyStartTime_InAnimMontage_PropertyAddress, SetAnimationNotifyStartTime_FunctionAddress, "InAnimMontage");
		SetAnimationNotifyStartTime_InAnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationNotifyStartTime_FunctionAddress, "InAnimMontage");
		SetAnimationNotifyStartTime_InAnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationNotifyStartTime_FunctionAddress, "InAnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationNotifyStartTime_InGuid_PropertyAddress, SetAnimationNotifyStartTime_FunctionAddress, "InGuid");
		SetAnimationNotifyStartTime_InGuid_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationNotifyStartTime_FunctionAddress, "InGuid");
		SetAnimationNotifyStartTime_InGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationNotifyStartTime_FunctionAddress, "InGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationNotifyStartTime_StartTime_PropertyAddress, SetAnimationNotifyStartTime_FunctionAddress, "StartTime");
		SetAnimationNotifyStartTime_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationNotifyStartTime_FunctionAddress, "StartTime");
		SetAnimationNotifyStartTime_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationNotifyStartTime_FunctionAddress, "StartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationNotifyStartTime_ReturnValue_PropertyAddress, SetAnimationNotifyStartTime_FunctionAddress, "ReturnValue");
		SetAnimationNotifyStartTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationNotifyStartTime_FunctionAddress, "ReturnValue");
		SetAnimationNotifyStartTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationNotifyStartTime_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetAnimationNotifyStartTime_IsValid = SetAnimationNotifyStartTime_FunctionAddress != IntPtr.Zero && SetAnimationNotifyStartTime_InAnimMontage_IsValid && SetAnimationNotifyStartTime_InGuid_IsValid && SetAnimationNotifyStartTime_StartTime_IsValid && SetAnimationNotifyStartTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:SetAnimationNotifyStartTime", SetAnimationNotifyStartTime_IsValid);
		SetAnimationNotifyDuration_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAnimationNotifyDuration");
		SetAnimationNotifyDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimationNotifyDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationNotifyDuration_InAnimMontage_PropertyAddress, SetAnimationNotifyDuration_FunctionAddress, "InAnimMontage");
		SetAnimationNotifyDuration_InAnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationNotifyDuration_FunctionAddress, "InAnimMontage");
		SetAnimationNotifyDuration_InAnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationNotifyDuration_FunctionAddress, "InAnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationNotifyDuration_InGuid_PropertyAddress, SetAnimationNotifyDuration_FunctionAddress, "InGuid");
		SetAnimationNotifyDuration_InGuid_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationNotifyDuration_FunctionAddress, "InGuid");
		SetAnimationNotifyDuration_InGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationNotifyDuration_FunctionAddress, "InGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationNotifyDuration_Duration_PropertyAddress, SetAnimationNotifyDuration_FunctionAddress, "Duration");
		SetAnimationNotifyDuration_Duration_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationNotifyDuration_FunctionAddress, "Duration");
		SetAnimationNotifyDuration_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationNotifyDuration_FunctionAddress, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationNotifyDuration_ReturnValue_PropertyAddress, SetAnimationNotifyDuration_FunctionAddress, "ReturnValue");
		SetAnimationNotifyDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationNotifyDuration_FunctionAddress, "ReturnValue");
		SetAnimationNotifyDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationNotifyDuration_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetAnimationNotifyDuration_IsValid = SetAnimationNotifyDuration_FunctionAddress != IntPtr.Zero && SetAnimationNotifyDuration_InAnimMontage_IsValid && SetAnimationNotifyDuration_InGuid_IsValid && SetAnimationNotifyDuration_Duration_IsValid && SetAnimationNotifyDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:SetAnimationNotifyDuration", SetAnimationNotifyDuration_IsValid);
		Sequence_GetRelativeBoneTransformCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Sequence_GetRelativeBoneTransformCS");
		Sequence_GetRelativeBoneTransformCS_ParamsSize = NativeReflection.GetFunctionParamsSize(Sequence_GetRelativeBoneTransformCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Sequence_GetRelativeBoneTransformCS_AnimSeq_PropertyAddress, Sequence_GetRelativeBoneTransformCS_FunctionAddress, "AnimSeq");
		Sequence_GetRelativeBoneTransformCS_AnimSeq_Offset = NativeReflectionCached.GetPropertyOffset(Sequence_GetRelativeBoneTransformCS_FunctionAddress, "AnimSeq");
		Sequence_GetRelativeBoneTransformCS_AnimSeq_IsValid = NativeReflectionCached.ValidatePropertyClass(Sequence_GetRelativeBoneTransformCS_FunctionAddress, "AnimSeq", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Sequence_GetRelativeBoneTransformCS_InTime_PropertyAddress, Sequence_GetRelativeBoneTransformCS_FunctionAddress, "InTime");
		Sequence_GetRelativeBoneTransformCS_InTime_Offset = NativeReflectionCached.GetPropertyOffset(Sequence_GetRelativeBoneTransformCS_FunctionAddress, "InTime");
		Sequence_GetRelativeBoneTransformCS_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(Sequence_GetRelativeBoneTransformCS_FunctionAddress, "InTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Sequence_GetRelativeBoneTransformCS_BoneName_PropertyAddress, Sequence_GetRelativeBoneTransformCS_FunctionAddress, "BoneName");
		Sequence_GetRelativeBoneTransformCS_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(Sequence_GetRelativeBoneTransformCS_FunctionAddress, "BoneName");
		Sequence_GetRelativeBoneTransformCS_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(Sequence_GetRelativeBoneTransformCS_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Sequence_GetRelativeBoneTransformCS_bExtractRootMotion_PropertyAddress, Sequence_GetRelativeBoneTransformCS_FunctionAddress, "bExtractRootMotion");
		Sequence_GetRelativeBoneTransformCS_bExtractRootMotion_Offset = NativeReflectionCached.GetPropertyOffset(Sequence_GetRelativeBoneTransformCS_FunctionAddress, "bExtractRootMotion");
		Sequence_GetRelativeBoneTransformCS_bExtractRootMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(Sequence_GetRelativeBoneTransformCS_FunctionAddress, "bExtractRootMotion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Sequence_GetRelativeBoneTransformCS_ReturnValue_PropertyAddress, Sequence_GetRelativeBoneTransformCS_FunctionAddress, "ReturnValue");
		Sequence_GetRelativeBoneTransformCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Sequence_GetRelativeBoneTransformCS_FunctionAddress, "ReturnValue");
		Sequence_GetRelativeBoneTransformCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Sequence_GetRelativeBoneTransformCS_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Sequence_GetRelativeBoneTransformCS_IsValid = Sequence_GetRelativeBoneTransformCS_FunctionAddress != IntPtr.Zero && Sequence_GetRelativeBoneTransformCS_AnimSeq_IsValid && Sequence_GetRelativeBoneTransformCS_InTime_IsValid && Sequence_GetRelativeBoneTransformCS_BoneName_IsValid && Sequence_GetRelativeBoneTransformCS_bExtractRootMotion_IsValid && Sequence_GetRelativeBoneTransformCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:Sequence_GetRelativeBoneTransformCS", Sequence_GetRelativeBoneTransformCS_IsValid);
		Sequence_GetBoneTransformCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Sequence_GetBoneTransformCS");
		Sequence_GetBoneTransformCS_ParamsSize = NativeReflection.GetFunctionParamsSize(Sequence_GetBoneTransformCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Sequence_GetBoneTransformCS_AnimSeq_PropertyAddress, Sequence_GetBoneTransformCS_FunctionAddress, "AnimSeq");
		Sequence_GetBoneTransformCS_AnimSeq_Offset = NativeReflectionCached.GetPropertyOffset(Sequence_GetBoneTransformCS_FunctionAddress, "AnimSeq");
		Sequence_GetBoneTransformCS_AnimSeq_IsValid = NativeReflectionCached.ValidatePropertyClass(Sequence_GetBoneTransformCS_FunctionAddress, "AnimSeq", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Sequence_GetBoneTransformCS_InTime_PropertyAddress, Sequence_GetBoneTransformCS_FunctionAddress, "InTime");
		Sequence_GetBoneTransformCS_InTime_Offset = NativeReflectionCached.GetPropertyOffset(Sequence_GetBoneTransformCS_FunctionAddress, "InTime");
		Sequence_GetBoneTransformCS_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(Sequence_GetBoneTransformCS_FunctionAddress, "InTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Sequence_GetBoneTransformCS_BoneName_PropertyAddress, Sequence_GetBoneTransformCS_FunctionAddress, "BoneName");
		Sequence_GetBoneTransformCS_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(Sequence_GetBoneTransformCS_FunctionAddress, "BoneName");
		Sequence_GetBoneTransformCS_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(Sequence_GetBoneTransformCS_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Sequence_GetBoneTransformCS_bExtractRootMotion_PropertyAddress, Sequence_GetBoneTransformCS_FunctionAddress, "bExtractRootMotion");
		Sequence_GetBoneTransformCS_bExtractRootMotion_Offset = NativeReflectionCached.GetPropertyOffset(Sequence_GetBoneTransformCS_FunctionAddress, "bExtractRootMotion");
		Sequence_GetBoneTransformCS_bExtractRootMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(Sequence_GetBoneTransformCS_FunctionAddress, "bExtractRootMotion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Sequence_GetBoneTransformCS_ReturnValue_PropertyAddress, Sequence_GetBoneTransformCS_FunctionAddress, "ReturnValue");
		Sequence_GetBoneTransformCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Sequence_GetBoneTransformCS_FunctionAddress, "ReturnValue");
		Sequence_GetBoneTransformCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Sequence_GetBoneTransformCS_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Sequence_GetBoneTransformCS_IsValid = Sequence_GetBoneTransformCS_FunctionAddress != IntPtr.Zero && Sequence_GetBoneTransformCS_AnimSeq_IsValid && Sequence_GetBoneTransformCS_InTime_IsValid && Sequence_GetBoneTransformCS_BoneName_IsValid && Sequence_GetBoneTransformCS_bExtractRootMotion_IsValid && Sequence_GetBoneTransformCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:Sequence_GetBoneTransformCS", Sequence_GetBoneTransformCS_IsValid);
		RemovePreviewAssetFromSkeleton_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemovePreviewAssetFromSkeleton");
		RemovePreviewAssetFromSkeleton_ParamsSize = NativeReflection.GetFunctionParamsSize(RemovePreviewAssetFromSkeleton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemovePreviewAssetFromSkeleton_InUSkeleton_PropertyAddress, RemovePreviewAssetFromSkeleton_FunctionAddress, "InUSkeleton");
		RemovePreviewAssetFromSkeleton_InUSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(RemovePreviewAssetFromSkeleton_FunctionAddress, "InUSkeleton");
		RemovePreviewAssetFromSkeleton_InUSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(RemovePreviewAssetFromSkeleton_FunctionAddress, "InUSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemovePreviewAssetFromSkeleton_BoneName_PropertyAddress, RemovePreviewAssetFromSkeleton_FunctionAddress, "BoneName");
		RemovePreviewAssetFromSkeleton_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(RemovePreviewAssetFromSkeleton_FunctionAddress, "BoneName");
		RemovePreviewAssetFromSkeleton_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemovePreviewAssetFromSkeleton_FunctionAddress, "BoneName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemovePreviewAssetFromSkeleton_ReturnValue_PropertyAddress, RemovePreviewAssetFromSkeleton_FunctionAddress, "ReturnValue");
		RemovePreviewAssetFromSkeleton_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemovePreviewAssetFromSkeleton_FunctionAddress, "ReturnValue");
		RemovePreviewAssetFromSkeleton_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemovePreviewAssetFromSkeleton_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemovePreviewAssetFromSkeleton_IsValid = RemovePreviewAssetFromSkeleton_FunctionAddress != IntPtr.Zero && RemovePreviewAssetFromSkeleton_InUSkeleton_IsValid && RemovePreviewAssetFromSkeleton_BoneName_IsValid && RemovePreviewAssetFromSkeleton_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:RemovePreviewAssetFromSkeleton", RemovePreviewAssetFromSkeleton_IsValid);
		RemoveNotifyTrackByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveNotifyTrackByName");
		RemoveNotifyTrackByName_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveNotifyTrackByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveNotifyTrackByName_TargetMontage_PropertyAddress, RemoveNotifyTrackByName_FunctionAddress, "TargetMontage");
		RemoveNotifyTrackByName_TargetMontage_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNotifyTrackByName_FunctionAddress, "TargetMontage");
		RemoveNotifyTrackByName_TargetMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNotifyTrackByName_FunctionAddress, "TargetMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveNotifyTrackByName_Name_PropertyAddress, RemoveNotifyTrackByName_FunctionAddress, "Name");
		RemoveNotifyTrackByName_Name_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNotifyTrackByName_FunctionAddress, "Name");
		RemoveNotifyTrackByName_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNotifyTrackByName_FunctionAddress, "Name", Classes.FNameProperty);
		RemoveNotifyTrackByName_IsValid = RemoveNotifyTrackByName_FunctionAddress != IntPtr.Zero && RemoveNotifyTrackByName_TargetMontage_IsValid && RemoveNotifyTrackByName_Name_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveNotifyTrackByName", RemoveNotifyTrackByName_IsValid);
		RemoveNotifyEventByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveNotifyEventByIndex");
		RemoveNotifyEventByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveNotifyEventByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveNotifyEventByIndex_TargetMontage_PropertyAddress, RemoveNotifyEventByIndex_FunctionAddress, "TargetMontage");
		RemoveNotifyEventByIndex_TargetMontage_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNotifyEventByIndex_FunctionAddress, "TargetMontage");
		RemoveNotifyEventByIndex_TargetMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNotifyEventByIndex_FunctionAddress, "TargetMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveNotifyEventByIndex_Index_PropertyAddress, RemoveNotifyEventByIndex_FunctionAddress, "Index");
		RemoveNotifyEventByIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNotifyEventByIndex_FunctionAddress, "Index");
		RemoveNotifyEventByIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNotifyEventByIndex_FunctionAddress, "Index", Classes.FIntProperty);
		RemoveNotifyEventByIndex_IsValid = RemoveNotifyEventByIndex_FunctionAddress != IntPtr.Zero && RemoveNotifyEventByIndex_TargetMontage_IsValid && RemoveNotifyEventByIndex_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveNotifyEventByIndex", RemoveNotifyEventByIndex_IsValid);
		RemoveAnimationNotify_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAnimationNotify");
		RemoveAnimationNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAnimationNotify_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationNotify_AnimBase_PropertyAddress, RemoveAnimationNotify_FunctionAddress, "AnimBase");
		RemoveAnimationNotify_AnimBase_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationNotify_FunctionAddress, "AnimBase");
		RemoveAnimationNotify_AnimBase_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationNotify_FunctionAddress, "AnimBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationNotify_Notify_PropertyAddress, RemoveAnimationNotify_FunctionAddress, "Notify");
		RemoveAnimationNotify_Notify_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationNotify_FunctionAddress, "Notify");
		RemoveAnimationNotify_Notify_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationNotify_FunctionAddress, "Notify", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationNotify_NotifyState_PropertyAddress, RemoveAnimationNotify_FunctionAddress, "NotifyState");
		RemoveAnimationNotify_NotifyState_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationNotify_FunctionAddress, "NotifyState");
		RemoveAnimationNotify_NotifyState_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationNotify_FunctionAddress, "NotifyState", Classes.FObjectProperty);
		RemoveAnimationNotify_IsValid = RemoveAnimationNotify_FunctionAddress != IntPtr.Zero && RemoveAnimationNotify_AnimBase_IsValid && RemoveAnimationNotify_Notify_IsValid && RemoveAnimationNotify_NotifyState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveAnimationNotify", RemoveAnimationNotify_IsValid);
		RemoveAllPoints_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAllPoints");
		RemoveAllPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllPoints_BlendSpace_PropertyAddress, RemoveAllPoints_FunctionAddress, "BlendSpace");
		RemoveAllPoints_BlendSpace_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllPoints_FunctionAddress, "BlendSpace");
		RemoveAllPoints_BlendSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllPoints_FunctionAddress, "BlendSpace", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllPoints_ReturnValue_PropertyAddress, RemoveAllPoints_FunctionAddress, "ReturnValue");
		RemoveAllPoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllPoints_FunctionAddress, "ReturnValue");
		RemoveAllPoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllPoints_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveAllPoints_IsValid = RemoveAllPoints_FunctionAddress != IntPtr.Zero && RemoveAllPoints_BlendSpace_IsValid && RemoveAllPoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveAllPoints", RemoveAllPoints_IsValid);
		RemoveAllAnimationNotifyStateEventInNamedTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAllAnimationNotifyStateEventInNamedTrack");
		RemoveAllAnimationNotifyStateEventInNamedTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllAnimationNotifyStateEventInNamedTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllAnimationNotifyStateEventInNamedTrack_AnimBase_PropertyAddress, RemoveAllAnimationNotifyStateEventInNamedTrack_FunctionAddress, "AnimBase");
		RemoveAllAnimationNotifyStateEventInNamedTrack_AnimBase_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllAnimationNotifyStateEventInNamedTrack_FunctionAddress, "AnimBase");
		RemoveAllAnimationNotifyStateEventInNamedTrack_AnimBase_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllAnimationNotifyStateEventInNamedTrack_FunctionAddress, "AnimBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllAnimationNotifyStateEventInNamedTrack_NotifyTrackName_PropertyAddress, RemoveAllAnimationNotifyStateEventInNamedTrack_FunctionAddress, "NotifyTrackName");
		RemoveAllAnimationNotifyStateEventInNamedTrack_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllAnimationNotifyStateEventInNamedTrack_FunctionAddress, "NotifyTrackName");
		RemoveAllAnimationNotifyStateEventInNamedTrack_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllAnimationNotifyStateEventInNamedTrack_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		RemoveAllAnimationNotifyStateEventInNamedTrack_IsValid = RemoveAllAnimationNotifyStateEventInNamedTrack_FunctionAddress != IntPtr.Zero && RemoveAllAnimationNotifyStateEventInNamedTrack_AnimBase_IsValid && RemoveAllAnimationNotifyStateEventInNamedTrack_NotifyTrackName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:RemoveAllAnimationNotifyStateEventInNamedTrack", RemoveAllAnimationNotifyStateEventInNamedTrack_IsValid);
		ReinitAnim_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReinitAnim");
		ReinitAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(ReinitAnim_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReinitAnim_Owner_PropertyAddress, ReinitAnim_FunctionAddress, "Owner");
		ReinitAnim_Owner_Offset = NativeReflectionCached.GetPropertyOffset(ReinitAnim_FunctionAddress, "Owner");
		ReinitAnim_Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(ReinitAnim_FunctionAddress, "Owner", Classes.FObjectProperty);
		ReinitAnim_IsValid = ReinitAnim_FunctionAddress != IntPtr.Zero && ReinitAnim_Owner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:ReinitAnim", ReinitAnim_IsValid);
		PostLoadBlendSpace_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostLoadBlendSpace");
		PostLoadBlendSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(PostLoadBlendSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostLoadBlendSpace_BlendSpace_PropertyAddress, PostLoadBlendSpace_FunctionAddress, "BlendSpace");
		PostLoadBlendSpace_BlendSpace_Offset = NativeReflectionCached.GetPropertyOffset(PostLoadBlendSpace_FunctionAddress, "BlendSpace");
		PostLoadBlendSpace_BlendSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(PostLoadBlendSpace_FunctionAddress, "BlendSpace", Classes.FObjectProperty);
		PostLoadBlendSpace_IsValid = PostLoadBlendSpace_FunctionAddress != IntPtr.Zero && PostLoadBlendSpace_BlendSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:PostLoadBlendSpace", PostLoadBlendSpace_IsValid);
		MontageIsValidAdditive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MontageIsValidAdditive");
		MontageIsValidAdditive_ParamsSize = NativeReflection.GetFunctionParamsSize(MontageIsValidAdditive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MontageIsValidAdditive_AnimMontage_PropertyAddress, MontageIsValidAdditive_FunctionAddress, "AnimMontage");
		MontageIsValidAdditive_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(MontageIsValidAdditive_FunctionAddress, "AnimMontage");
		MontageIsValidAdditive_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageIsValidAdditive_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MontageIsValidAdditive_ReturnValue_PropertyAddress, MontageIsValidAdditive_FunctionAddress, "ReturnValue");
		MontageIsValidAdditive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MontageIsValidAdditive_FunctionAddress, "ReturnValue");
		MontageIsValidAdditive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageIsValidAdditive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MontageIsValidAdditive_IsValid = MontageIsValidAdditive_FunctionAddress != IntPtr.Zero && MontageIsValidAdditive_AnimMontage_IsValid && MontageIsValidAdditive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:MontageIsValidAdditive", MontageIsValidAdditive_IsValid);
		Montage_GetBoneTransformCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Montage_GetBoneTransformCS");
		Montage_GetBoneTransformCS_ParamsSize = NativeReflection.GetFunctionParamsSize(Montage_GetBoneTransformCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Montage_GetBoneTransformCS_InMontage_PropertyAddress, Montage_GetBoneTransformCS_FunctionAddress, "InMontage");
		Montage_GetBoneTransformCS_InMontage_Offset = NativeReflectionCached.GetPropertyOffset(Montage_GetBoneTransformCS_FunctionAddress, "InMontage");
		Montage_GetBoneTransformCS_InMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(Montage_GetBoneTransformCS_FunctionAddress, "InMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Montage_GetBoneTransformCS_InTime_PropertyAddress, Montage_GetBoneTransformCS_FunctionAddress, "InTime");
		Montage_GetBoneTransformCS_InTime_Offset = NativeReflectionCached.GetPropertyOffset(Montage_GetBoneTransformCS_FunctionAddress, "InTime");
		Montage_GetBoneTransformCS_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(Montage_GetBoneTransformCS_FunctionAddress, "InTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Montage_GetBoneTransformCS_InBoneName_PropertyAddress, Montage_GetBoneTransformCS_FunctionAddress, "InBoneName");
		Montage_GetBoneTransformCS_InBoneName_Offset = NativeReflectionCached.GetPropertyOffset(Montage_GetBoneTransformCS_FunctionAddress, "InBoneName");
		Montage_GetBoneTransformCS_InBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(Montage_GetBoneTransformCS_FunctionAddress, "InBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Montage_GetBoneTransformCS_InSlotName_PropertyAddress, Montage_GetBoneTransformCS_FunctionAddress, "InSlotName");
		Montage_GetBoneTransformCS_InSlotName_Offset = NativeReflectionCached.GetPropertyOffset(Montage_GetBoneTransformCS_FunctionAddress, "InSlotName");
		Montage_GetBoneTransformCS_InSlotName_IsValid = NativeReflectionCached.ValidatePropertyClass(Montage_GetBoneTransformCS_FunctionAddress, "InSlotName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Montage_GetBoneTransformCS_bExtractRootMotion_PropertyAddress, Montage_GetBoneTransformCS_FunctionAddress, "bExtractRootMotion");
		Montage_GetBoneTransformCS_bExtractRootMotion_Offset = NativeReflectionCached.GetPropertyOffset(Montage_GetBoneTransformCS_FunctionAddress, "bExtractRootMotion");
		Montage_GetBoneTransformCS_bExtractRootMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(Montage_GetBoneTransformCS_FunctionAddress, "bExtractRootMotion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Montage_GetBoneTransformCS_ReturnValue_PropertyAddress, Montage_GetBoneTransformCS_FunctionAddress, "ReturnValue");
		Montage_GetBoneTransformCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Montage_GetBoneTransformCS_FunctionAddress, "ReturnValue");
		Montage_GetBoneTransformCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Montage_GetBoneTransformCS_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Montage_GetBoneTransformCS_IsValid = Montage_GetBoneTransformCS_FunctionAddress != IntPtr.Zero && Montage_GetBoneTransformCS_InMontage_IsValid && Montage_GetBoneTransformCS_InTime_IsValid && Montage_GetBoneTransformCS_InBoneName_IsValid && Montage_GetBoneTransformCS_InSlotName_IsValid && Montage_GetBoneTransformCS_bExtractRootMotion_IsValid && Montage_GetBoneTransformCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:Montage_GetBoneTransformCS", Montage_GetBoneTransformCS_IsValid);
		Montage_GetBoneRelativeTransformCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Montage_GetBoneRelativeTransformCS");
		Montage_GetBoneRelativeTransformCS_ParamsSize = NativeReflection.GetFunctionParamsSize(Montage_GetBoneRelativeTransformCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Montage_GetBoneRelativeTransformCS_InMontage_PropertyAddress, Montage_GetBoneRelativeTransformCS_FunctionAddress, "InMontage");
		Montage_GetBoneRelativeTransformCS_InMontage_Offset = NativeReflectionCached.GetPropertyOffset(Montage_GetBoneRelativeTransformCS_FunctionAddress, "InMontage");
		Montage_GetBoneRelativeTransformCS_InMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(Montage_GetBoneRelativeTransformCS_FunctionAddress, "InMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Montage_GetBoneRelativeTransformCS_InTime_PropertyAddress, Montage_GetBoneRelativeTransformCS_FunctionAddress, "InTime");
		Montage_GetBoneRelativeTransformCS_InTime_Offset = NativeReflectionCached.GetPropertyOffset(Montage_GetBoneRelativeTransformCS_FunctionAddress, "InTime");
		Montage_GetBoneRelativeTransformCS_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(Montage_GetBoneRelativeTransformCS_FunctionAddress, "InTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Montage_GetBoneRelativeTransformCS_InBoneName_PropertyAddress, Montage_GetBoneRelativeTransformCS_FunctionAddress, "InBoneName");
		Montage_GetBoneRelativeTransformCS_InBoneName_Offset = NativeReflectionCached.GetPropertyOffset(Montage_GetBoneRelativeTransformCS_FunctionAddress, "InBoneName");
		Montage_GetBoneRelativeTransformCS_InBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(Montage_GetBoneRelativeTransformCS_FunctionAddress, "InBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Montage_GetBoneRelativeTransformCS_InSlotName_PropertyAddress, Montage_GetBoneRelativeTransformCS_FunctionAddress, "InSlotName");
		Montage_GetBoneRelativeTransformCS_InSlotName_Offset = NativeReflectionCached.GetPropertyOffset(Montage_GetBoneRelativeTransformCS_FunctionAddress, "InSlotName");
		Montage_GetBoneRelativeTransformCS_InSlotName_IsValid = NativeReflectionCached.ValidatePropertyClass(Montage_GetBoneRelativeTransformCS_FunctionAddress, "InSlotName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Montage_GetBoneRelativeTransformCS_bExtractRootMotion_PropertyAddress, Montage_GetBoneRelativeTransformCS_FunctionAddress, "bExtractRootMotion");
		Montage_GetBoneRelativeTransformCS_bExtractRootMotion_Offset = NativeReflectionCached.GetPropertyOffset(Montage_GetBoneRelativeTransformCS_FunctionAddress, "bExtractRootMotion");
		Montage_GetBoneRelativeTransformCS_bExtractRootMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(Montage_GetBoneRelativeTransformCS_FunctionAddress, "bExtractRootMotion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Montage_GetBoneRelativeTransformCS_ReturnValue_PropertyAddress, Montage_GetBoneRelativeTransformCS_FunctionAddress, "ReturnValue");
		Montage_GetBoneRelativeTransformCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Montage_GetBoneRelativeTransformCS_FunctionAddress, "ReturnValue");
		Montage_GetBoneRelativeTransformCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Montage_GetBoneRelativeTransformCS_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Montage_GetBoneRelativeTransformCS_IsValid = Montage_GetBoneRelativeTransformCS_FunctionAddress != IntPtr.Zero && Montage_GetBoneRelativeTransformCS_InMontage_IsValid && Montage_GetBoneRelativeTransformCS_InTime_IsValid && Montage_GetBoneRelativeTransformCS_InBoneName_IsValid && Montage_GetBoneRelativeTransformCS_InSlotName_IsValid && Montage_GetBoneRelativeTransformCS_bExtractRootMotion_IsValid && Montage_GetBoneRelativeTransformCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:Montage_GetBoneRelativeTransformCS", Montage_GetBoneRelativeTransformCS_IsValid);
		MarkDirtyForANEMontageTickType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MarkDirtyForANEMontageTickType");
		MarkDirtyForANEMontageTickType_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkDirtyForANEMontageTickType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MarkDirtyForANEMontageTickType_ResourcePath_PropertyAddress, MarkDirtyForANEMontageTickType_FunctionAddress, "ResourcePath");
		MarkDirtyForANEMontageTickType_ResourcePath_Offset = NativeReflectionCached.GetPropertyOffset(MarkDirtyForANEMontageTickType_FunctionAddress, "ResourcePath");
		MarkDirtyForANEMontageTickType_ResourcePath_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkDirtyForANEMontageTickType_FunctionAddress, "ResourcePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MarkDirtyForANEMontageTickType_bToQueued_PropertyAddress, MarkDirtyForANEMontageTickType_FunctionAddress, "bToQueued");
		MarkDirtyForANEMontageTickType_bToQueued_Offset = NativeReflectionCached.GetPropertyOffset(MarkDirtyForANEMontageTickType_FunctionAddress, "bToQueued");
		MarkDirtyForANEMontageTickType_bToQueued_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkDirtyForANEMontageTickType_FunctionAddress, "bToQueued", Classes.FBoolProperty);
		MarkDirtyForANEMontageTickType_IsValid = MarkDirtyForANEMontageTickType_FunctionAddress != IntPtr.Zero && MarkDirtyForANEMontageTickType_ResourcePath_IsValid && MarkDirtyForANEMontageTickType_bToQueued_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:MarkDirtyForANEMontageTickType", MarkDirtyForANEMontageTickType_IsValid);
		MarkDirtyAM_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MarkDirtyAM");
		MarkDirtyAM_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkDirtyAM_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MarkDirtyAM_DirtyMontage_PropertyAddress, MarkDirtyAM_FunctionAddress, "DirtyMontage");
		MarkDirtyAM_DirtyMontage_Offset = NativeReflectionCached.GetPropertyOffset(MarkDirtyAM_FunctionAddress, "DirtyMontage");
		MarkDirtyAM_DirtyMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkDirtyAM_FunctionAddress, "DirtyMontage", Classes.FObjectProperty);
		MarkDirtyAM_IsValid = MarkDirtyAM_FunctionAddress != IntPtr.Zero && MarkDirtyAM_DirtyMontage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:MarkDirtyAM", MarkDirtyAM_IsValid);
		MarkDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MarkDirty");
		MarkDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MarkDirty_obj_PropertyAddress, MarkDirty_FunctionAddress, "obj");
		MarkDirty_obj_Offset = NativeReflectionCached.GetPropertyOffset(MarkDirty_FunctionAddress, "obj");
		MarkDirty_obj_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkDirty_FunctionAddress, "obj", Classes.FObjectProperty);
		MarkDirty_IsValid = MarkDirty_FunctionAddress != IntPtr.Zero && MarkDirty_obj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:MarkDirty", MarkDirty_IsValid);
		IsSlotPlayingMontage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsSlotPlayingMontage");
		IsSlotPlayingMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSlotPlayingMontage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSlotPlayingMontage_AnimInst_PropertyAddress, IsSlotPlayingMontage_FunctionAddress, "AnimInst");
		IsSlotPlayingMontage_AnimInst_Offset = NativeReflectionCached.GetPropertyOffset(IsSlotPlayingMontage_FunctionAddress, "AnimInst");
		IsSlotPlayingMontage_AnimInst_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSlotPlayingMontage_FunctionAddress, "AnimInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSlotPlayingMontage_SlotNodeName_PropertyAddress, IsSlotPlayingMontage_FunctionAddress, "SlotNodeName");
		IsSlotPlayingMontage_SlotNodeName_Offset = NativeReflectionCached.GetPropertyOffset(IsSlotPlayingMontage_FunctionAddress, "SlotNodeName");
		IsSlotPlayingMontage_SlotNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSlotPlayingMontage_FunctionAddress, "SlotNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSlotPlayingMontage_ReturnValue_PropertyAddress, IsSlotPlayingMontage_FunctionAddress, "ReturnValue");
		IsSlotPlayingMontage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSlotPlayingMontage_FunctionAddress, "ReturnValue");
		IsSlotPlayingMontage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSlotPlayingMontage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSlotPlayingMontage_IsValid = IsSlotPlayingMontage_FunctionAddress != IntPtr.Zero && IsSlotPlayingMontage_AnimInst_IsValid && IsSlotPlayingMontage_SlotNodeName_IsValid && IsSlotPlayingMontage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:IsSlotPlayingMontage", IsSlotPlayingMontage_IsValid);
		IsInRootMotionAM_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsInRootMotionAM");
		IsInRootMotionAM_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInRootMotionAM_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInRootMotionAM_Character_PropertyAddress, IsInRootMotionAM_FunctionAddress, "Character");
		IsInRootMotionAM_Character_Offset = NativeReflectionCached.GetPropertyOffset(IsInRootMotionAM_FunctionAddress, "Character");
		IsInRootMotionAM_Character_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInRootMotionAM_FunctionAddress, "Character", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsInRootMotionAM_ReturnValue_PropertyAddress, IsInRootMotionAM_FunctionAddress, "ReturnValue");
		IsInRootMotionAM_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInRootMotionAM_FunctionAddress, "ReturnValue");
		IsInRootMotionAM_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInRootMotionAM_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInRootMotionAM_IsValid = IsInRootMotionAM_FunctionAddress != IntPtr.Zero && IsInRootMotionAM_Character_IsValid && IsInRootMotionAM_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:IsInRootMotionAM", IsInRootMotionAM_IsValid);
		InitAnimGraphNode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InitAnimGraphNode");
		InitAnimGraphNode_ParamsSize = NativeReflection.GetFunctionParamsSize(InitAnimGraphNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitAnimGraphNode_AnimInst_PropertyAddress, InitAnimGraphNode_FunctionAddress, "AnimInst");
		InitAnimGraphNode_AnimInst_Offset = NativeReflectionCached.GetPropertyOffset(InitAnimGraphNode_FunctionAddress, "AnimInst");
		InitAnimGraphNode_AnimInst_IsValid = NativeReflectionCached.ValidatePropertyClass(InitAnimGraphNode_FunctionAddress, "AnimInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InitAnimGraphNode_Tag_PropertyAddress, InitAnimGraphNode_FunctionAddress, "Tag");
		InitAnimGraphNode_Tag_Offset = NativeReflectionCached.GetPropertyOffset(InitAnimGraphNode_FunctionAddress, "Tag");
		InitAnimGraphNode_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(InitAnimGraphNode_FunctionAddress, "Tag", Classes.FNameProperty);
		InitAnimGraphNode_IsValid = InitAnimGraphNode_FunctionAddress != IntPtr.Zero && InitAnimGraphNode_AnimInst_IsValid && InitAnimGraphNode_Tag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:InitAnimGraphNode", InitAnimGraphNode_IsValid);
		GetTrackIndexForAnimationNotifyTrackName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTrackIndexForAnimationNotifyTrackName");
		GetTrackIndexForAnimationNotifyTrackName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTrackIndexForAnimationNotifyTrackName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTrackIndexForAnimationNotifyTrackName_AnimBase_PropertyAddress, GetTrackIndexForAnimationNotifyTrackName_FunctionAddress, "AnimBase");
		GetTrackIndexForAnimationNotifyTrackName_AnimBase_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackIndexForAnimationNotifyTrackName_FunctionAddress, "AnimBase");
		GetTrackIndexForAnimationNotifyTrackName_AnimBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackIndexForAnimationNotifyTrackName_FunctionAddress, "AnimBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrackIndexForAnimationNotifyTrackName_NotifyTrackName_PropertyAddress, GetTrackIndexForAnimationNotifyTrackName_FunctionAddress, "NotifyTrackName");
		GetTrackIndexForAnimationNotifyTrackName_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackIndexForAnimationNotifyTrackName_FunctionAddress, "NotifyTrackName");
		GetTrackIndexForAnimationNotifyTrackName_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackIndexForAnimationNotifyTrackName_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrackIndexForAnimationNotifyTrackName_ReturnValue_PropertyAddress, GetTrackIndexForAnimationNotifyTrackName_FunctionAddress, "ReturnValue");
		GetTrackIndexForAnimationNotifyTrackName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackIndexForAnimationNotifyTrackName_FunctionAddress, "ReturnValue");
		GetTrackIndexForAnimationNotifyTrackName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackIndexForAnimationNotifyTrackName_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTrackIndexForAnimationNotifyTrackName_IsValid = GetTrackIndexForAnimationNotifyTrackName_FunctionAddress != IntPtr.Zero && GetTrackIndexForAnimationNotifyTrackName_AnimBase_IsValid && GetTrackIndexForAnimationNotifyTrackName_NotifyTrackName_IsValid && GetTrackIndexForAnimationNotifyTrackName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetTrackIndexForAnimationNotifyTrackName", GetTrackIndexForAnimationNotifyTrackName_IsValid);
		GetSkeleton_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSkeleton");
		GetSkeleton_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeleton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeleton_AnimSequenceBase_PropertyAddress, GetSkeleton_FunctionAddress, "AnimSequenceBase");
		GetSkeleton_AnimSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeleton_FunctionAddress, "AnimSequenceBase");
		GetSkeleton_AnimSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeleton_FunctionAddress, "AnimSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSkeleton_ReturnValue_PropertyAddress, GetSkeleton_FunctionAddress, "ReturnValue");
		GetSkeleton_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeleton_FunctionAddress, "ReturnValue");
		GetSkeleton_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeleton_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSkeleton_IsValid = GetSkeleton_FunctionAddress != IntPtr.Zero && GetSkeleton_AnimSequenceBase_IsValid && GetSkeleton_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetSkeleton", GetSkeleton_IsValid);
		GetOneAnimAllNotifyEventIncludeAS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOneAnimAllNotifyEventIncludeAS");
		GetOneAnimAllNotifyEventIncludeAS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOneAnimAllNotifyEventIncludeAS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOneAnimAllNotifyEventIncludeAS_TargetAnim_PropertyAddress, GetOneAnimAllNotifyEventIncludeAS_FunctionAddress, "TargetAnim");
		GetOneAnimAllNotifyEventIncludeAS_TargetAnim_Offset = NativeReflectionCached.GetPropertyOffset(GetOneAnimAllNotifyEventIncludeAS_FunctionAddress, "TargetAnim");
		GetOneAnimAllNotifyEventIncludeAS_TargetAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOneAnimAllNotifyEventIncludeAS_FunctionAddress, "TargetAnim", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOneAnimAllNotifyEventIncludeAS_AnimNotifyEventList_PropertyAddress, GetOneAnimAllNotifyEventIncludeAS_FunctionAddress, "AnimNotifyEventList");
		GetOneAnimAllNotifyEventIncludeAS_AnimNotifyEventList_Offset = NativeReflectionCached.GetPropertyOffset(GetOneAnimAllNotifyEventIncludeAS_FunctionAddress, "AnimNotifyEventList");
		GetOneAnimAllNotifyEventIncludeAS_AnimNotifyEventList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOneAnimAllNotifyEventIncludeAS_FunctionAddress, "AnimNotifyEventList", Classes.FArrayProperty);
		GetOneAnimAllNotifyEventIncludeAS_IsValid = GetOneAnimAllNotifyEventIncludeAS_FunctionAddress != IntPtr.Zero && GetOneAnimAllNotifyEventIncludeAS_TargetAnim_IsValid && GetOneAnimAllNotifyEventIncludeAS_AnimNotifyEventList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetOneAnimAllNotifyEventIncludeAS", GetOneAnimAllNotifyEventIncludeAS_IsValid);
		GetNumUVChannels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumUVChannels");
		GetNumUVChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumUVChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumUVChannels_StaticMesh_PropertyAddress, GetNumUVChannels_FunctionAddress, "StaticMesh");
		GetNumUVChannels_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNumUVChannels_FunctionAddress, "StaticMesh");
		GetNumUVChannels_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumUVChannels_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumUVChannels_LODIndex_PropertyAddress, GetNumUVChannels_FunctionAddress, "LODIndex");
		GetNumUVChannels_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetNumUVChannels_FunctionAddress, "LODIndex");
		GetNumUVChannels_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumUVChannels_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumUVChannels_ReturnValue_PropertyAddress, GetNumUVChannels_FunctionAddress, "ReturnValue");
		GetNumUVChannels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumUVChannels_FunctionAddress, "ReturnValue");
		GetNumUVChannels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumUVChannels_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumUVChannels_IsValid = GetNumUVChannels_FunctionAddress != IntPtr.Zero && GetNumUVChannels_StaticMesh_IsValid && GetNumUVChannels_LODIndex_IsValid && GetNumUVChannels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetNumUVChannels", GetNumUVChannels_IsValid);
		GetNotifyTriggerTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNotifyTriggerTime");
		GetNotifyTriggerTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNotifyTriggerTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNotifyTriggerTime_AnimNotifyEvent_PropertyAddress, GetNotifyTriggerTime_FunctionAddress, "AnimNotifyEvent");
		GetNotifyTriggerTime_AnimNotifyEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetNotifyTriggerTime_FunctionAddress, "AnimNotifyEvent");
		GetNotifyTriggerTime_AnimNotifyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNotifyTriggerTime_FunctionAddress, "AnimNotifyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNotifyTriggerTime_ReturnValue_PropertyAddress, GetNotifyTriggerTime_FunctionAddress, "ReturnValue");
		GetNotifyTriggerTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNotifyTriggerTime_FunctionAddress, "ReturnValue");
		GetNotifyTriggerTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNotifyTriggerTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetNotifyTriggerTime_IsValid = GetNotifyTriggerTime_FunctionAddress != IntPtr.Zero && GetNotifyTriggerTime_AnimNotifyEvent_IsValid && GetNotifyTriggerTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetNotifyTriggerTime", GetNotifyTriggerTime_IsValid);
		GetNotifyEndTriggerTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNotifyEndTriggerTime");
		GetNotifyEndTriggerTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNotifyEndTriggerTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNotifyEndTriggerTime_AnimNotifyEvent_PropertyAddress, GetNotifyEndTriggerTime_FunctionAddress, "AnimNotifyEvent");
		GetNotifyEndTriggerTime_AnimNotifyEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetNotifyEndTriggerTime_FunctionAddress, "AnimNotifyEvent");
		GetNotifyEndTriggerTime_AnimNotifyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNotifyEndTriggerTime_FunctionAddress, "AnimNotifyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNotifyEndTriggerTime_ReturnValue_PropertyAddress, GetNotifyEndTriggerTime_FunctionAddress, "ReturnValue");
		GetNotifyEndTriggerTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNotifyEndTriggerTime_FunctionAddress, "ReturnValue");
		GetNotifyEndTriggerTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNotifyEndTriggerTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetNotifyEndTriggerTime_IsValid = GetNotifyEndTriggerTime_FunctionAddress != IntPtr.Zero && GetNotifyEndTriggerTime_AnimNotifyEvent_IsValid && GetNotifyEndTriggerTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetNotifyEndTriggerTime", GetNotifyEndTriggerTime_IsValid);
		GetNotifyComboEndTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNotifyComboEndTime");
		GetNotifyComboEndTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNotifyComboEndTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNotifyComboEndTime_AnimInst_PropertyAddress, GetNotifyComboEndTime_FunctionAddress, "AnimInst");
		GetNotifyComboEndTime_AnimInst_Offset = NativeReflectionCached.GetPropertyOffset(GetNotifyComboEndTime_FunctionAddress, "AnimInst");
		GetNotifyComboEndTime_AnimInst_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNotifyComboEndTime_FunctionAddress, "AnimInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNotifyComboEndTime_index_PropertyAddress, GetNotifyComboEndTime_FunctionAddress, "index");
		GetNotifyComboEndTime_index_Offset = NativeReflectionCached.GetPropertyOffset(GetNotifyComboEndTime_FunctionAddress, "index");
		GetNotifyComboEndTime_index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNotifyComboEndTime_FunctionAddress, "index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNotifyComboEndTime_ReturnValue_PropertyAddress, GetNotifyComboEndTime_FunctionAddress, "ReturnValue");
		GetNotifyComboEndTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNotifyComboEndTime_FunctionAddress, "ReturnValue");
		GetNotifyComboEndTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNotifyComboEndTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetNotifyComboEndTime_IsValid = GetNotifyComboEndTime_FunctionAddress != IntPtr.Zero && GetNotifyComboEndTime_AnimInst_IsValid && GetNotifyComboEndTime_index_IsValid && GetNotifyComboEndTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetNotifyComboEndTime", GetNotifyComboEndTime_IsValid);
		GetMontageSlotName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMontageSlotName");
		GetMontageSlotName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMontageSlotName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMontageSlotName_Montage_PropertyAddress, GetMontageSlotName_FunctionAddress, "Montage");
		GetMontageSlotName_Montage_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageSlotName_FunctionAddress, "Montage");
		GetMontageSlotName_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageSlotName_FunctionAddress, "Montage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageSlotName_SlotIndex_PropertyAddress, GetMontageSlotName_FunctionAddress, "SlotIndex");
		GetMontageSlotName_SlotIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageSlotName_FunctionAddress, "SlotIndex");
		GetMontageSlotName_SlotIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageSlotName_FunctionAddress, "SlotIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageSlotName_ReturnValue_PropertyAddress, GetMontageSlotName_FunctionAddress, "ReturnValue");
		GetMontageSlotName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageSlotName_FunctionAddress, "ReturnValue");
		GetMontageSlotName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageSlotName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetMontageSlotName_IsValid = GetMontageSlotName_FunctionAddress != IntPtr.Zero && GetMontageSlotName_Montage_IsValid && GetMontageSlotName_SlotIndex_IsValid && GetMontageSlotName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageSlotName", GetMontageSlotName_IsValid);
		GetMontageSectionStartAndEndTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMontageSectionStartAndEndTime");
		GetMontageSectionStartAndEndTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMontageSectionStartAndEndTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMontageSectionStartAndEndTime_AnimMontage_PropertyAddress, GetMontageSectionStartAndEndTime_FunctionAddress, "AnimMontage");
		GetMontageSectionStartAndEndTime_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageSectionStartAndEndTime_FunctionAddress, "AnimMontage");
		GetMontageSectionStartAndEndTime_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageSectionStartAndEndTime_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageSectionStartAndEndTime_SectionName_PropertyAddress, GetMontageSectionStartAndEndTime_FunctionAddress, "SectionName");
		GetMontageSectionStartAndEndTime_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageSectionStartAndEndTime_FunctionAddress, "SectionName");
		GetMontageSectionStartAndEndTime_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageSectionStartAndEndTime_FunctionAddress, "SectionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageSectionStartAndEndTime_OutStartTime_PropertyAddress, GetMontageSectionStartAndEndTime_FunctionAddress, "OutStartTime");
		GetMontageSectionStartAndEndTime_OutStartTime_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageSectionStartAndEndTime_FunctionAddress, "OutStartTime");
		GetMontageSectionStartAndEndTime_OutStartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageSectionStartAndEndTime_FunctionAddress, "OutStartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageSectionStartAndEndTime_OutEndTime_PropertyAddress, GetMontageSectionStartAndEndTime_FunctionAddress, "OutEndTime");
		GetMontageSectionStartAndEndTime_OutEndTime_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageSectionStartAndEndTime_FunctionAddress, "OutEndTime");
		GetMontageSectionStartAndEndTime_OutEndTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageSectionStartAndEndTime_FunctionAddress, "OutEndTime", Classes.FFloatProperty);
		GetMontageSectionStartAndEndTime_IsValid = GetMontageSectionStartAndEndTime_FunctionAddress != IntPtr.Zero && GetMontageSectionStartAndEndTime_AnimMontage_IsValid && GetMontageSectionStartAndEndTime_SectionName_IsValid && GetMontageSectionStartAndEndTime_OutStartTime_IsValid && GetMontageSectionStartAndEndTime_OutEndTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageSectionStartAndEndTime", GetMontageSectionStartAndEndTime_IsValid);
		GetMontageSectionName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMontageSectionName");
		GetMontageSectionName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMontageSectionName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMontageSectionName_AnimMontage_PropertyAddress, GetMontageSectionName_FunctionAddress, "AnimMontage");
		GetMontageSectionName_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageSectionName_FunctionAddress, "AnimMontage");
		GetMontageSectionName_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageSectionName_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageSectionName_index_PropertyAddress, GetMontageSectionName_FunctionAddress, "index");
		GetMontageSectionName_index_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageSectionName_FunctionAddress, "index");
		GetMontageSectionName_index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageSectionName_FunctionAddress, "index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageSectionName_ReturnValue_PropertyAddress, GetMontageSectionName_FunctionAddress, "ReturnValue");
		GetMontageSectionName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageSectionName_FunctionAddress, "ReturnValue");
		GetMontageSectionName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageSectionName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetMontageSectionName_IsValid = GetMontageSectionName_FunctionAddress != IntPtr.Zero && GetMontageSectionName_AnimMontage_IsValid && GetMontageSectionName_index_IsValid && GetMontageSectionName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageSectionName", GetMontageSectionName_IsValid);
		GetMontageNotifyTriggerTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMontageNotifyTriggerTime");
		GetMontageNotifyTriggerTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMontageNotifyTriggerTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMontageNotifyTriggerTime_AnimInst_PropertyAddress, GetMontageNotifyTriggerTime_FunctionAddress, "AnimInst");
		GetMontageNotifyTriggerTime_AnimInst_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageNotifyTriggerTime_FunctionAddress, "AnimInst");
		GetMontageNotifyTriggerTime_AnimInst_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageNotifyTriggerTime_FunctionAddress, "AnimInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageNotifyTriggerTime_FromInstanceID_PropertyAddress, GetMontageNotifyTriggerTime_FunctionAddress, "FromInstanceID");
		GetMontageNotifyTriggerTime_FromInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageNotifyTriggerTime_FunctionAddress, "FromInstanceID");
		GetMontageNotifyTriggerTime_FromInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageNotifyTriggerTime_FunctionAddress, "FromInstanceID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageNotifyTriggerTime_ReturnValue_PropertyAddress, GetMontageNotifyTriggerTime_FunctionAddress, "ReturnValue");
		GetMontageNotifyTriggerTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageNotifyTriggerTime_FunctionAddress, "ReturnValue");
		GetMontageNotifyTriggerTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageNotifyTriggerTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMontageNotifyTriggerTime_IsValid = GetMontageNotifyTriggerTime_FunctionAddress != IntPtr.Zero && GetMontageNotifyTriggerTime_AnimInst_IsValid && GetMontageNotifyTriggerTime_FromInstanceID_IsValid && GetMontageNotifyTriggerTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageNotifyTriggerTime", GetMontageNotifyTriggerTime_IsValid);
		GetMontageNotifyName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMontageNotifyName");
		GetMontageNotifyName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMontageNotifyName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMontageNotifyName_AnimInst_PropertyAddress, GetMontageNotifyName_FunctionAddress, "AnimInst");
		GetMontageNotifyName_AnimInst_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageNotifyName_FunctionAddress, "AnimInst");
		GetMontageNotifyName_AnimInst_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageNotifyName_FunctionAddress, "AnimInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageNotifyName_index_PropertyAddress, GetMontageNotifyName_FunctionAddress, "index");
		GetMontageNotifyName_index_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageNotifyName_FunctionAddress, "index");
		GetMontageNotifyName_index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageNotifyName_FunctionAddress, "index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageNotifyName_ReturnValue_PropertyAddress, GetMontageNotifyName_FunctionAddress, "ReturnValue");
		GetMontageNotifyName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageNotifyName_FunctionAddress, "ReturnValue");
		GetMontageNotifyName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageNotifyName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetMontageNotifyName_IsValid = GetMontageNotifyName_FunctionAddress != IntPtr.Zero && GetMontageNotifyName_AnimInst_IsValid && GetMontageNotifyName_index_IsValid && GetMontageNotifyName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageNotifyName", GetMontageNotifyName_IsValid);
		GetMontageNextSection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMontageNextSection");
		GetMontageNextSection_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMontageNextSection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMontageNextSection_AnimInstance_PropertyAddress, GetMontageNextSection_FunctionAddress, "AnimInstance");
		GetMontageNextSection_AnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageNextSection_FunctionAddress, "AnimInstance");
		GetMontageNextSection_AnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageNextSection_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageNextSection_AnimMontage_PropertyAddress, GetMontageNextSection_FunctionAddress, "AnimMontage");
		GetMontageNextSection_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageNextSection_FunctionAddress, "AnimMontage");
		GetMontageNextSection_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageNextSection_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageNextSection_ReturnValue_PropertyAddress, GetMontageNextSection_FunctionAddress, "ReturnValue");
		GetMontageNextSection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageNextSection_FunctionAddress, "ReturnValue");
		GetMontageNextSection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageNextSection_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetMontageNextSection_IsValid = GetMontageNextSection_FunctionAddress != IntPtr.Zero && GetMontageNextSection_AnimInstance_IsValid && GetMontageNextSection_AnimMontage_IsValid && GetMontageNextSection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageNextSection", GetMontageNextSection_IsValid);
		GetMontageEffectID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMontageEffectID");
		GetMontageEffectID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMontageEffectID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMontageEffectID_AnimInst_PropertyAddress, GetMontageEffectID_FunctionAddress, "AnimInst");
		GetMontageEffectID_AnimInst_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageEffectID_FunctionAddress, "AnimInst");
		GetMontageEffectID_AnimInst_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageEffectID_FunctionAddress, "AnimInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageEffectID_index_PropertyAddress, GetMontageEffectID_FunctionAddress, "index");
		GetMontageEffectID_index_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageEffectID_FunctionAddress, "index");
		GetMontageEffectID_index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageEffectID_FunctionAddress, "index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageEffectID_ReturnValue_PropertyAddress, GetMontageEffectID_FunctionAddress, "ReturnValue");
		GetMontageEffectID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageEffectID_FunctionAddress, "ReturnValue");
		GetMontageEffectID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageEffectID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMontageEffectID_IsValid = GetMontageEffectID_FunctionAddress != IntPtr.Zero && GetMontageEffectID_AnimInst_IsValid && GetMontageEffectID_index_IsValid && GetMontageEffectID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageEffectID", GetMontageEffectID_IsValid);
		GetMontageComboSkillID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMontageComboSkillID");
		GetMontageComboSkillID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMontageComboSkillID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMontageComboSkillID_AnimInst_PropertyAddress, GetMontageComboSkillID_FunctionAddress, "AnimInst");
		GetMontageComboSkillID_AnimInst_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageComboSkillID_FunctionAddress, "AnimInst");
		GetMontageComboSkillID_AnimInst_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageComboSkillID_FunctionAddress, "AnimInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageComboSkillID_index_PropertyAddress, GetMontageComboSkillID_FunctionAddress, "index");
		GetMontageComboSkillID_index_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageComboSkillID_FunctionAddress, "index");
		GetMontageComboSkillID_index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageComboSkillID_FunctionAddress, "index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMontageComboSkillID_ReturnValue_PropertyAddress, GetMontageComboSkillID_FunctionAddress, "ReturnValue");
		GetMontageComboSkillID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMontageComboSkillID_FunctionAddress, "ReturnValue");
		GetMontageComboSkillID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMontageComboSkillID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMontageComboSkillID_IsValid = GetMontageComboSkillID_FunctionAddress != IntPtr.Zero && GetMontageComboSkillID_AnimInst_IsValid && GetMontageComboSkillID_index_IsValid && GetMontageComboSkillID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetMontageComboSkillID", GetMontageComboSkillID_IsValid);
		GetFolderPathFromFullPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFolderPathFromFullPath");
		GetFolderPathFromFullPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFolderPathFromFullPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFolderPathFromFullPath_FullPath_PropertyAddress, GetFolderPathFromFullPath_FunctionAddress, "FullPath");
		GetFolderPathFromFullPath_FullPath_Offset = NativeReflectionCached.GetPropertyOffset(GetFolderPathFromFullPath_FunctionAddress, "FullPath");
		GetFolderPathFromFullPath_FullPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFolderPathFromFullPath_FunctionAddress, "FullPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFolderPathFromFullPath_ReturnValue_PropertyAddress, GetFolderPathFromFullPath_FunctionAddress, "ReturnValue");
		GetFolderPathFromFullPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFolderPathFromFullPath_FunctionAddress, "ReturnValue");
		GetFolderPathFromFullPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFolderPathFromFullPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetFolderPathFromFullPath_IsValid = GetFolderPathFromFullPath_FunctionAddress != IntPtr.Zero && GetFolderPathFromFullPath_FullPath_IsValid && GetFolderPathFromFullPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetFolderPathFromFullPath", GetFolderPathFromFullPath_IsValid);
		GetCurrentActiveMontageInstanceID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentActiveMontageInstanceID");
		GetCurrentActiveMontageInstanceID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentActiveMontageInstanceID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentActiveMontageInstanceID_Character_PropertyAddress, GetCurrentActiveMontageInstanceID_FunctionAddress, "Character");
		GetCurrentActiveMontageInstanceID_Character_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentActiveMontageInstanceID_FunctionAddress, "Character");
		GetCurrentActiveMontageInstanceID_Character_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentActiveMontageInstanceID_FunctionAddress, "Character", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentActiveMontageInstanceID_ReturnValue_PropertyAddress, GetCurrentActiveMontageInstanceID_FunctionAddress, "ReturnValue");
		GetCurrentActiveMontageInstanceID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentActiveMontageInstanceID_FunctionAddress, "ReturnValue");
		GetCurrentActiveMontageInstanceID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentActiveMontageInstanceID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCurrentActiveMontageInstanceID_IsValid = GetCurrentActiveMontageInstanceID_FunctionAddress != IntPtr.Zero && GetCurrentActiveMontageInstanceID_Character_IsValid && GetCurrentActiveMontageInstanceID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetCurrentActiveMontageInstanceID", GetCurrentActiveMontageInstanceID_IsValid);
		GetChildSockets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetChildSockets");
		GetChildSockets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildSockets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildSockets_SkeletalMeshComp_PropertyAddress, GetChildSockets_FunctionAddress, "SkeletalMeshComp");
		GetChildSockets_SkeletalMeshComp_Offset = NativeReflectionCached.GetPropertyOffset(GetChildSockets_FunctionAddress, "SkeletalMeshComp");
		GetChildSockets_SkeletalMeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildSockets_FunctionAddress, "SkeletalMeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildSockets_BaseBoneName_PropertyAddress, GetChildSockets_FunctionAddress, "BaseBoneName");
		GetChildSockets_BaseBoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetChildSockets_FunctionAddress, "BaseBoneName");
		GetChildSockets_BaseBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildSockets_FunctionAddress, "BaseBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildSockets_ChildSocketNames_PropertyAddress, GetChildSockets_FunctionAddress, "ChildSocketNames");
		GetChildSockets_ChildSocketNames_Offset = NativeReflectionCached.GetPropertyOffset(GetChildSockets_FunctionAddress, "ChildSocketNames");
		GetChildSockets_ChildSocketNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildSockets_FunctionAddress, "ChildSocketNames", Classes.FArrayProperty);
		GetChildSockets_IsValid = GetChildSockets_FunctionAddress != IntPtr.Zero && GetChildSockets_SkeletalMeshComp_IsValid && GetChildSockets_BaseBoneName_IsValid && GetChildSockets_ChildSocketNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetChildSockets", GetChildSockets_IsValid);
		GetChildBones_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetChildBones");
		GetChildBones_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildBones_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildBones_InSkeleton_PropertyAddress, GetChildBones_FunctionAddress, "InSkeleton");
		GetChildBones_InSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(GetChildBones_FunctionAddress, "InSkeleton");
		GetChildBones_InSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildBones_FunctionAddress, "InSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildBones_ParentBoneName_PropertyAddress, GetChildBones_FunctionAddress, "ParentBoneName");
		GetChildBones_ParentBoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetChildBones_FunctionAddress, "ParentBoneName");
		GetChildBones_ParentBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildBones_FunctionAddress, "ParentBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildBones_BoneNameFilter_PropertyAddress, GetChildBones_FunctionAddress, "BoneNameFilter");
		GetChildBones_BoneNameFilter_Offset = NativeReflectionCached.GetPropertyOffset(GetChildBones_FunctionAddress, "BoneNameFilter");
		GetChildBones_BoneNameFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildBones_FunctionAddress, "BoneNameFilter", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildBones_ChildBones_PropertyAddress, GetChildBones_FunctionAddress, "ChildBones");
		GetChildBones_ChildBones_Offset = NativeReflectionCached.GetPropertyOffset(GetChildBones_FunctionAddress, "ChildBones");
		GetChildBones_ChildBones_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildBones_FunctionAddress, "ChildBones", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildBones_ReturnValue_PropertyAddress, GetChildBones_FunctionAddress, "ReturnValue");
		GetChildBones_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChildBones_FunctionAddress, "ReturnValue");
		GetChildBones_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildBones_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetChildBones_IsValid = GetChildBones_FunctionAddress != IntPtr.Zero && GetChildBones_InSkeleton_IsValid && GetChildBones_ParentBoneName_IsValid && GetChildBones_BoneNameFilter_IsValid && GetChildBones_ChildBones_IsValid && GetChildBones_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetChildBones", GetChildBones_IsValid);
		GetBoneWeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoneWeight");
		GetBoneWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneWeight_SkeletalMesh_PropertyAddress, GetBoneWeight_FunctionAddress, "SkeletalMesh");
		GetBoneWeight_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneWeight_FunctionAddress, "SkeletalMesh");
		GetBoneWeight_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneWeight_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneWeight_ReturnValue_PropertyAddress, GetBoneWeight_FunctionAddress, "ReturnValue");
		GetBoneWeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneWeight_FunctionAddress, "ReturnValue");
		GetBoneWeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneWeight_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetBoneWeight_IsValid = GetBoneWeight_FunctionAddress != IntPtr.Zero && GetBoneWeight_SkeletalMesh_IsValid && GetBoneWeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetBoneWeight", GetBoneWeight_IsValid);
		GetBoneTransformByTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoneTransformByTime");
		GetBoneTransformByTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneTransformByTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransformByTime_AnimationSequence_PropertyAddress, GetBoneTransformByTime_FunctionAddress, "AnimationSequence");
		GetBoneTransformByTime_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransformByTime_FunctionAddress, "AnimationSequence");
		GetBoneTransformByTime_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransformByTime_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransformByTime_Time_PropertyAddress, GetBoneTransformByTime_FunctionAddress, "Time");
		GetBoneTransformByTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransformByTime_FunctionAddress, "Time");
		GetBoneTransformByTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransformByTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransformByTime_TrackIndex_PropertyAddress, GetBoneTransformByTime_FunctionAddress, "TrackIndex");
		GetBoneTransformByTime_TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransformByTime_FunctionAddress, "TrackIndex");
		GetBoneTransformByTime_TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransformByTime_FunctionAddress, "TrackIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransformByTime_UseRawData_PropertyAddress, GetBoneTransformByTime_FunctionAddress, "UseRawData");
		GetBoneTransformByTime_UseRawData_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransformByTime_FunctionAddress, "UseRawData");
		GetBoneTransformByTime_UseRawData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransformByTime_FunctionAddress, "UseRawData", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransformByTime_ReturnValue_PropertyAddress, GetBoneTransformByTime_FunctionAddress, "ReturnValue");
		GetBoneTransformByTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransformByTime_FunctionAddress, "ReturnValue");
		GetBoneTransformByTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransformByTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBoneTransformByTime_IsValid = GetBoneTransformByTime_FunctionAddress != IntPtr.Zero && GetBoneTransformByTime_AnimationSequence_IsValid && GetBoneTransformByTime_Time_IsValid && GetBoneTransformByTime_TrackIndex_IsValid && GetBoneTransformByTime_UseRawData_IsValid && GetBoneTransformByTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetBoneTransformByTime", GetBoneTransformByTime_IsValid);
		GetBoneTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoneTransform");
		GetBoneTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransform_Mesh_PropertyAddress, GetBoneTransform_FunctionAddress, "Mesh");
		GetBoneTransform_Mesh_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransform_FunctionAddress, "Mesh");
		GetBoneTransform_Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransform_FunctionAddress, "Mesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransform_BoneIndex_PropertyAddress, GetBoneTransform_FunctionAddress, "BoneIndex");
		GetBoneTransform_BoneIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransform_FunctionAddress, "BoneIndex");
		GetBoneTransform_BoneIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransform_FunctionAddress, "BoneIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransform_ReturnValue_PropertyAddress, GetBoneTransform_FunctionAddress, "ReturnValue");
		GetBoneTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransform_FunctionAddress, "ReturnValue");
		GetBoneTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBoneTransform_IsValid = GetBoneTransform_FunctionAddress != IntPtr.Zero && GetBoneTransform_Mesh_IsValid && GetBoneTransform_BoneIndex_IsValid && GetBoneTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetBoneTransform", GetBoneTransform_IsValid);
		GetBoneParentList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoneParentList");
		GetBoneParentList_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneParentList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneParentList_AnimationSequence_PropertyAddress, GetBoneParentList_FunctionAddress, "AnimationSequence");
		GetBoneParentList_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneParentList_FunctionAddress, "AnimationSequence");
		GetBoneParentList_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneParentList_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneParentList_ReturnValue_PropertyAddress, GetBoneParentList_FunctionAddress, "ReturnValue");
		GetBoneParentList_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneParentList_FunctionAddress, "ReturnValue");
		GetBoneParentList_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneParentList_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetBoneParentList_IsValid = GetBoneParentList_FunctionAddress != IntPtr.Zero && GetBoneParentList_AnimationSequence_IsValid && GetBoneParentList_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetBoneParentList", GetBoneParentList_IsValid);
		GetAnimCurrentTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimCurrentTime");
		GetAnimCurrentTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimCurrentTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimCurrentTime_AnimInst_PropertyAddress, GetAnimCurrentTime_FunctionAddress, "AnimInst");
		GetAnimCurrentTime_AnimInst_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimCurrentTime_FunctionAddress, "AnimInst");
		GetAnimCurrentTime_AnimInst_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimCurrentTime_FunctionAddress, "AnimInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimCurrentTime_FromInstanceID_PropertyAddress, GetAnimCurrentTime_FunctionAddress, "FromInstanceID");
		GetAnimCurrentTime_FromInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimCurrentTime_FunctionAddress, "FromInstanceID");
		GetAnimCurrentTime_FromInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimCurrentTime_FunctionAddress, "FromInstanceID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimCurrentTime_ReturnValue_PropertyAddress, GetAnimCurrentTime_FunctionAddress, "ReturnValue");
		GetAnimCurrentTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimCurrentTime_FunctionAddress, "ReturnValue");
		GetAnimCurrentTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimCurrentTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAnimCurrentTime_IsValid = GetAnimCurrentTime_FunctionAddress != IntPtr.Zero && GetAnimCurrentTime_AnimInst_IsValid && GetAnimCurrentTime_FromInstanceID_IsValid && GetAnimCurrentTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimCurrentTime", GetAnimCurrentTime_IsValid);
		GetAnimationTrackNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationTrackNames");
		GetAnimationTrackNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationTrackNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationTrackNames_AnimationSequence_PropertyAddress, GetAnimationTrackNames_FunctionAddress, "AnimationSequence");
		GetAnimationTrackNames_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationTrackNames_FunctionAddress, "AnimationSequence");
		GetAnimationTrackNames_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationTrackNames_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationTrackNames_ReturnValue_PropertyAddress, GetAnimationTrackNames_FunctionAddress, "ReturnValue");
		GetAnimationTrackNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationTrackNames_FunctionAddress, "ReturnValue");
		GetAnimationTrackNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationTrackNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAnimationTrackNames_IsValid = GetAnimationTrackNames_FunctionAddress != IntPtr.Zero && GetAnimationTrackNames_AnimationSequence_IsValid && GetAnimationTrackNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimationTrackNames", GetAnimationTrackNames_IsValid);
		GetAnimationTrackNameByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationTrackNameByIndex");
		GetAnimationTrackNameByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationTrackNameByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationTrackNameByIndex_AnimSequenceBase_PropertyAddress, GetAnimationTrackNameByIndex_FunctionAddress, "AnimSequenceBase");
		GetAnimationTrackNameByIndex_AnimSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationTrackNameByIndex_FunctionAddress, "AnimSequenceBase");
		GetAnimationTrackNameByIndex_AnimSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationTrackNameByIndex_FunctionAddress, "AnimSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationTrackNameByIndex_Index_PropertyAddress, GetAnimationTrackNameByIndex_FunctionAddress, "Index");
		GetAnimationTrackNameByIndex_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationTrackNameByIndex_FunctionAddress, "Index");
		GetAnimationTrackNameByIndex_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationTrackNameByIndex_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationTrackNameByIndex_TrackName_PropertyAddress, GetAnimationTrackNameByIndex_FunctionAddress, "TrackName");
		GetAnimationTrackNameByIndex_TrackName_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationTrackNameByIndex_FunctionAddress, "TrackName");
		GetAnimationTrackNameByIndex_TrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationTrackNameByIndex_FunctionAddress, "TrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationTrackNameByIndex_ReturnValue_PropertyAddress, GetAnimationTrackNameByIndex_FunctionAddress, "ReturnValue");
		GetAnimationTrackNameByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationTrackNameByIndex_FunctionAddress, "ReturnValue");
		GetAnimationTrackNameByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationTrackNameByIndex_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAnimationTrackNameByIndex_IsValid = GetAnimationTrackNameByIndex_FunctionAddress != IntPtr.Zero && GetAnimationTrackNameByIndex_AnimSequenceBase_IsValid && GetAnimationTrackNameByIndex_Index_IsValid && GetAnimationTrackNameByIndex_TrackName_IsValid && GetAnimationTrackNameByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimationTrackNameByIndex", GetAnimationTrackNameByIndex_IsValid);
		GetAnimationNotifyEvents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationNotifyEvents");
		GetAnimationNotifyEvents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationNotifyEvents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationNotifyEvents_AnimSequenceBase_PropertyAddress, GetAnimationNotifyEvents_FunctionAddress, "AnimSequenceBase");
		GetAnimationNotifyEvents_AnimSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationNotifyEvents_FunctionAddress, "AnimSequenceBase");
		GetAnimationNotifyEvents_AnimSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationNotifyEvents_FunctionAddress, "AnimSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationNotifyEvents_NotifyEvents_PropertyAddress, GetAnimationNotifyEvents_FunctionAddress, "NotifyEvents");
		GetAnimationNotifyEvents_NotifyEvents_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationNotifyEvents_FunctionAddress, "NotifyEvents");
		GetAnimationNotifyEvents_NotifyEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationNotifyEvents_FunctionAddress, "NotifyEvents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationNotifyEvents_ReturnValue_PropertyAddress, GetAnimationNotifyEvents_FunctionAddress, "ReturnValue");
		GetAnimationNotifyEvents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationNotifyEvents_FunctionAddress, "ReturnValue");
		GetAnimationNotifyEvents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationNotifyEvents_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAnimationNotifyEvents_IsValid = GetAnimationNotifyEvents_FunctionAddress != IntPtr.Zero && GetAnimationNotifyEvents_AnimSequenceBase_IsValid && GetAnimationNotifyEvents_NotifyEvents_IsValid && GetAnimationNotifyEvents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimationNotifyEvents", GetAnimationNotifyEvents_IsValid);
		GetAnimAllNotifyEventIncludeAS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimAllNotifyEventIncludeAS");
		GetAnimAllNotifyEventIncludeAS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimAllNotifyEventIncludeAS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimAllNotifyEventIncludeAS_AnimBases_PropertyAddress, GetAnimAllNotifyEventIncludeAS_FunctionAddress, "AnimBases");
		GetAnimAllNotifyEventIncludeAS_AnimBases_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimAllNotifyEventIncludeAS_FunctionAddress, "AnimBases");
		GetAnimAllNotifyEventIncludeAS_AnimBases_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimAllNotifyEventIncludeAS_FunctionAddress, "AnimBases", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimAllNotifyEventIncludeAS_AnimNotifyEventList_PropertyAddress, GetAnimAllNotifyEventIncludeAS_FunctionAddress, "AnimNotifyEventList");
		GetAnimAllNotifyEventIncludeAS_AnimNotifyEventList_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimAllNotifyEventIncludeAS_FunctionAddress, "AnimNotifyEventList");
		GetAnimAllNotifyEventIncludeAS_AnimNotifyEventList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimAllNotifyEventIncludeAS_FunctionAddress, "AnimNotifyEventList", Classes.FArrayProperty);
		GetAnimAllNotifyEventIncludeAS_IsValid = GetAnimAllNotifyEventIncludeAS_FunctionAddress != IntPtr.Zero && GetAnimAllNotifyEventIncludeAS_AnimBases_IsValid && GetAnimAllNotifyEventIncludeAS_AnimNotifyEventList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetAnimAllNotifyEventIncludeAS", GetAnimAllNotifyEventIncludeAS_IsValid);
		GetAllNotifyEventInAM_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllNotifyEventInAM");
		GetAllNotifyEventInAM_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllNotifyEventInAM_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllNotifyEventInAM_TargetMontage_PropertyAddress, GetAllNotifyEventInAM_FunctionAddress, "TargetMontage");
		GetAllNotifyEventInAM_TargetMontage_Offset = NativeReflectionCached.GetPropertyOffset(GetAllNotifyEventInAM_FunctionAddress, "TargetMontage");
		GetAllNotifyEventInAM_TargetMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllNotifyEventInAM_FunctionAddress, "TargetMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllNotifyEventInAM_TimeInfoList_PropertyAddress, GetAllNotifyEventInAM_FunctionAddress, "TimeInfoList");
		GetAllNotifyEventInAM_TimeInfoList_Offset = NativeReflectionCached.GetPropertyOffset(GetAllNotifyEventInAM_FunctionAddress, "TimeInfoList");
		GetAllNotifyEventInAM_TimeInfoList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllNotifyEventInAM_FunctionAddress, "TimeInfoList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllNotifyEventInAM_ReturnValue_PropertyAddress, GetAllNotifyEventInAM_FunctionAddress, "ReturnValue");
		GetAllNotifyEventInAM_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllNotifyEventInAM_FunctionAddress, "ReturnValue");
		GetAllNotifyEventInAM_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllNotifyEventInAM_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllNotifyEventInAM_IsValid = GetAllNotifyEventInAM_FunctionAddress != IntPtr.Zero && GetAllNotifyEventInAM_TargetMontage_IsValid && GetAllNotifyEventInAM_TimeInfoList_IsValid && GetAllNotifyEventInAM_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllNotifyEventInAM", GetAllNotifyEventInAM_IsValid);
		GetAllNotifyEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllNotifyEvent");
		GetAllNotifyEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllNotifyEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllNotifyEvent_TargetMontage_PropertyAddress, GetAllNotifyEvent_FunctionAddress, "TargetMontage");
		GetAllNotifyEvent_TargetMontage_Offset = NativeReflectionCached.GetPropertyOffset(GetAllNotifyEvent_FunctionAddress, "TargetMontage");
		GetAllNotifyEvent_TargetMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllNotifyEvent_FunctionAddress, "TargetMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllNotifyEvent_AnimNotifyEventList_PropertyAddress, GetAllNotifyEvent_FunctionAddress, "AnimNotifyEventList");
		GetAllNotifyEvent_AnimNotifyEventList_Offset = NativeReflectionCached.GetPropertyOffset(GetAllNotifyEvent_FunctionAddress, "AnimNotifyEventList");
		GetAllNotifyEvent_AnimNotifyEventList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllNotifyEvent_FunctionAddress, "AnimNotifyEventList", Classes.FArrayProperty);
		GetAllNotifyEvent_IsValid = GetAllNotifyEvent_FunctionAddress != IntPtr.Zero && GetAllNotifyEvent_TargetMontage_IsValid && GetAllNotifyEvent_AnimNotifyEventList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllNotifyEvent", GetAllNotifyEvent_IsValid);
		GetAllAnimSyncMarkers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllAnimSyncMarkers");
		GetAllAnimSyncMarkers_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllAnimSyncMarkers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllAnimSyncMarkers_AnimSequence_PropertyAddress, GetAllAnimSyncMarkers_FunctionAddress, "AnimSequence");
		GetAllAnimSyncMarkers_AnimSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAnimSyncMarkers_FunctionAddress, "AnimSequence");
		GetAllAnimSyncMarkers_AnimSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAnimSyncMarkers_FunctionAddress, "AnimSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllAnimSyncMarkers_OutSyncMarkers_PropertyAddress, GetAllAnimSyncMarkers_FunctionAddress, "OutSyncMarkers");
		GetAllAnimSyncMarkers_OutSyncMarkers_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAnimSyncMarkers_FunctionAddress, "OutSyncMarkers");
		GetAllAnimSyncMarkers_OutSyncMarkers_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAnimSyncMarkers_FunctionAddress, "OutSyncMarkers", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllAnimSyncMarkers_ReturnValue_PropertyAddress, GetAllAnimSyncMarkers_FunctionAddress, "ReturnValue");
		GetAllAnimSyncMarkers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAnimSyncMarkers_FunctionAddress, "ReturnValue");
		GetAllAnimSyncMarkers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAnimSyncMarkers_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAllAnimSyncMarkers_IsValid = GetAllAnimSyncMarkers_FunctionAddress != IntPtr.Zero && GetAllAnimSyncMarkers_AnimSequence_IsValid && GetAllAnimSyncMarkers_OutSyncMarkers_IsValid && GetAllAnimSyncMarkers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllAnimSyncMarkers", GetAllAnimSyncMarkers_IsValid);
		GetAllAnimNotifyEventInAMForMarkDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllAnimNotifyEventInAMForMarkDirty");
		GetAllAnimNotifyEventInAMForMarkDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllAnimNotifyEventInAMForMarkDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllAnimNotifyEventInAMForMarkDirty_AnimMontage_PropertyAddress, GetAllAnimNotifyEventInAMForMarkDirty_FunctionAddress, "AnimMontage");
		GetAllAnimNotifyEventInAMForMarkDirty_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAnimNotifyEventInAMForMarkDirty_FunctionAddress, "AnimMontage");
		GetAllAnimNotifyEventInAMForMarkDirty_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAnimNotifyEventInAMForMarkDirty_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllAnimNotifyEventInAMForMarkDirty_ReturnValue_PropertyAddress, GetAllAnimNotifyEventInAMForMarkDirty_FunctionAddress, "ReturnValue");
		GetAllAnimNotifyEventInAMForMarkDirty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAnimNotifyEventInAMForMarkDirty_FunctionAddress, "ReturnValue");
		GetAllAnimNotifyEventInAMForMarkDirty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAnimNotifyEventInAMForMarkDirty_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllAnimNotifyEventInAMForMarkDirty_IsValid = GetAllAnimNotifyEventInAMForMarkDirty_FunctionAddress != IntPtr.Zero && GetAllAnimNotifyEventInAMForMarkDirty_AnimMontage_IsValid && GetAllAnimNotifyEventInAMForMarkDirty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllAnimNotifyEventInAMForMarkDirty", GetAllAnimNotifyEventInAMForMarkDirty_IsValid);
		GetAllAnimNotifyEventForMarkDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllAnimNotifyEventForMarkDirty");
		GetAllAnimNotifyEventForMarkDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllAnimNotifyEventForMarkDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllAnimNotifyEventForMarkDirty_ResourcePath_PropertyAddress, GetAllAnimNotifyEventForMarkDirty_FunctionAddress, "ResourcePath");
		GetAllAnimNotifyEventForMarkDirty_ResourcePath_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAnimNotifyEventForMarkDirty_FunctionAddress, "ResourcePath");
		GetAllAnimNotifyEventForMarkDirty_ResourcePath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAnimNotifyEventForMarkDirty_FunctionAddress, "ResourcePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllAnimNotifyEventForMarkDirty_ReturnValue_PropertyAddress, GetAllAnimNotifyEventForMarkDirty_FunctionAddress, "ReturnValue");
		GetAllAnimNotifyEventForMarkDirty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAnimNotifyEventForMarkDirty_FunctionAddress, "ReturnValue");
		GetAllAnimNotifyEventForMarkDirty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAnimNotifyEventForMarkDirty_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllAnimNotifyEventForMarkDirty_IsValid = GetAllAnimNotifyEventForMarkDirty_FunctionAddress != IntPtr.Zero && GetAllAnimNotifyEventForMarkDirty_ResourcePath_IsValid && GetAllAnimNotifyEventForMarkDirty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllAnimNotifyEventForMarkDirty", GetAllAnimNotifyEventForMarkDirty_IsValid);
		GetAllAnimationsOfSkeleton_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllAnimationsOfSkeleton");
		GetAllAnimationsOfSkeleton_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllAnimationsOfSkeleton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllAnimationsOfSkeleton_SkeletonMesh_PropertyAddress, GetAllAnimationsOfSkeleton_FunctionAddress, "SkeletonMesh");
		GetAllAnimationsOfSkeleton_SkeletonMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAnimationsOfSkeleton_FunctionAddress, "SkeletonMesh");
		GetAllAnimationsOfSkeleton_SkeletonMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAnimationsOfSkeleton_FunctionAddress, "SkeletonMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllAnimationsOfSkeleton_AnimationBasePath_PropertyAddress, GetAllAnimationsOfSkeleton_FunctionAddress, "AnimationBasePath");
		GetAllAnimationsOfSkeleton_AnimationBasePath_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAnimationsOfSkeleton_FunctionAddress, "AnimationBasePath");
		GetAllAnimationsOfSkeleton_AnimationBasePath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAnimationsOfSkeleton_FunctionAddress, "AnimationBasePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllAnimationsOfSkeleton_ReturnValue_PropertyAddress, GetAllAnimationsOfSkeleton_FunctionAddress, "ReturnValue");
		GetAllAnimationsOfSkeleton_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAnimationsOfSkeleton_FunctionAddress, "ReturnValue");
		GetAllAnimationsOfSkeleton_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAnimationsOfSkeleton_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllAnimationsOfSkeleton_IsValid = GetAllAnimationsOfSkeleton_FunctionAddress != IntPtr.Zero && GetAllAnimationsOfSkeleton_SkeletonMesh_IsValid && GetAllAnimationsOfSkeleton_AnimationBasePath_IsValid && GetAllAnimationsOfSkeleton_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetAllAnimationsOfSkeleton", GetAllAnimationsOfSkeleton_IsValid);
		GetActiveMontageInstanceID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActiveMontageInstanceID");
		GetActiveMontageInstanceID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActiveMontageInstanceID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActiveMontageInstanceID_AnimInstance_PropertyAddress, GetActiveMontageInstanceID_FunctionAddress, "AnimInstance");
		GetActiveMontageInstanceID_AnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(GetActiveMontageInstanceID_FunctionAddress, "AnimInstance");
		GetActiveMontageInstanceID_AnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActiveMontageInstanceID_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActiveMontageInstanceID_ReturnValue_PropertyAddress, GetActiveMontageInstanceID_FunctionAddress, "ReturnValue");
		GetActiveMontageInstanceID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActiveMontageInstanceID_FunctionAddress, "ReturnValue");
		GetActiveMontageInstanceID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActiveMontageInstanceID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetActiveMontageInstanceID_IsValid = GetActiveMontageInstanceID_FunctionAddress != IntPtr.Zero && GetActiveMontageInstanceID_AnimInstance_IsValid && GetActiveMontageInstanceID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GetActiveMontageInstanceID", GetActiveMontageInstanceID_IsValid);
		GenerateDestructibleComponentFromPathWithEditor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GenerateDestructibleComponentFromPathWithEditor");
		GenerateDestructibleComponentFromPathWithEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateDestructibleComponentFromPathWithEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateDestructibleComponentFromPathWithEditor_FolderPath_PropertyAddress, GenerateDestructibleComponentFromPathWithEditor_FunctionAddress, "FolderPath");
		GenerateDestructibleComponentFromPathWithEditor_FolderPath_Offset = NativeReflectionCached.GetPropertyOffset(GenerateDestructibleComponentFromPathWithEditor_FunctionAddress, "FolderPath");
		GenerateDestructibleComponentFromPathWithEditor_FolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateDestructibleComponentFromPathWithEditor_FunctionAddress, "FolderPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateDestructibleComponentFromPathWithEditor_TargetActor_PropertyAddress, GenerateDestructibleComponentFromPathWithEditor_FunctionAddress, "TargetActor");
		GenerateDestructibleComponentFromPathWithEditor_TargetActor_Offset = NativeReflectionCached.GetPropertyOffset(GenerateDestructibleComponentFromPathWithEditor_FunctionAddress, "TargetActor");
		GenerateDestructibleComponentFromPathWithEditor_TargetActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateDestructibleComponentFromPathWithEditor_FunctionAddress, "TargetActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateDestructibleComponentFromPathWithEditor_ReturnValue_PropertyAddress, GenerateDestructibleComponentFromPathWithEditor_FunctionAddress, "ReturnValue");
		GenerateDestructibleComponentFromPathWithEditor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateDestructibleComponentFromPathWithEditor_FunctionAddress, "ReturnValue");
		GenerateDestructibleComponentFromPathWithEditor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateDestructibleComponentFromPathWithEditor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GenerateDestructibleComponentFromPathWithEditor_IsValid = GenerateDestructibleComponentFromPathWithEditor_FunctionAddress != IntPtr.Zero && GenerateDestructibleComponentFromPathWithEditor_FolderPath_IsValid && GenerateDestructibleComponentFromPathWithEditor_TargetActor_IsValid && GenerateDestructibleComponentFromPathWithEditor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GenerateDestructibleComponentFromPathWithEditor", GenerateDestructibleComponentFromPathWithEditor_IsValid);
		GenerateDestructibleComponentFromPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GenerateDestructibleComponentFromPath");
		GenerateDestructibleComponentFromPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateDestructibleComponentFromPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateDestructibleComponentFromPath_FolderPath_PropertyAddress, GenerateDestructibleComponentFromPath_FunctionAddress, "FolderPath");
		GenerateDestructibleComponentFromPath_FolderPath_Offset = NativeReflectionCached.GetPropertyOffset(GenerateDestructibleComponentFromPath_FunctionAddress, "FolderPath");
		GenerateDestructibleComponentFromPath_FolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateDestructibleComponentFromPath_FunctionAddress, "FolderPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateDestructibleComponentFromPath_TargetSkeletalMeshComp_PropertyAddress, GenerateDestructibleComponentFromPath_FunctionAddress, "TargetSkeletalMeshComp");
		GenerateDestructibleComponentFromPath_TargetSkeletalMeshComp_Offset = NativeReflectionCached.GetPropertyOffset(GenerateDestructibleComponentFromPath_FunctionAddress, "TargetSkeletalMeshComp");
		GenerateDestructibleComponentFromPath_TargetSkeletalMeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateDestructibleComponentFromPath_FunctionAddress, "TargetSkeletalMeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateDestructibleComponentFromPath_DestructibleMeshArray_PropertyAddress, GenerateDestructibleComponentFromPath_FunctionAddress, "DestructibleMeshArray");
		GenerateDestructibleComponentFromPath_DestructibleMeshArray_Offset = NativeReflectionCached.GetPropertyOffset(GenerateDestructibleComponentFromPath_FunctionAddress, "DestructibleMeshArray");
		GenerateDestructibleComponentFromPath_DestructibleMeshArray_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateDestructibleComponentFromPath_FunctionAddress, "DestructibleMeshArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateDestructibleComponentFromPath_BoneNameArray_PropertyAddress, GenerateDestructibleComponentFromPath_FunctionAddress, "BoneNameArray");
		GenerateDestructibleComponentFromPath_BoneNameArray_Offset = NativeReflectionCached.GetPropertyOffset(GenerateDestructibleComponentFromPath_FunctionAddress, "BoneNameArray");
		GenerateDestructibleComponentFromPath_BoneNameArray_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateDestructibleComponentFromPath_FunctionAddress, "BoneNameArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateDestructibleComponentFromPath_ReturnValue_PropertyAddress, GenerateDestructibleComponentFromPath_FunctionAddress, "ReturnValue");
		GenerateDestructibleComponentFromPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateDestructibleComponentFromPath_FunctionAddress, "ReturnValue");
		GenerateDestructibleComponentFromPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateDestructibleComponentFromPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GenerateDestructibleComponentFromPath_IsValid = GenerateDestructibleComponentFromPath_FunctionAddress != IntPtr.Zero && GenerateDestructibleComponentFromPath_FolderPath_IsValid && GenerateDestructibleComponentFromPath_TargetSkeletalMeshComp_IsValid && GenerateDestructibleComponentFromPath_DestructibleMeshArray_IsValid && GenerateDestructibleComponentFromPath_BoneNameArray_IsValid && GenerateDestructibleComponentFromPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GenerateDestructibleComponentFromPath", GenerateDestructibleComponentFromPath_IsValid);
		GenerateDefaultAxisParameters_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GenerateDefaultAxisParameters");
		GenerateDefaultAxisParameters_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateDefaultAxisParameters_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateDefaultAxisParameters_BlendSpace_PropertyAddress, GenerateDefaultAxisParameters_FunctionAddress, "BlendSpace");
		GenerateDefaultAxisParameters_BlendSpace_Offset = NativeReflectionCached.GetPropertyOffset(GenerateDefaultAxisParameters_FunctionAddress, "BlendSpace");
		GenerateDefaultAxisParameters_BlendSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateDefaultAxisParameters_FunctionAddress, "BlendSpace", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateDefaultAxisParameters_ReturnValue_PropertyAddress, GenerateDefaultAxisParameters_FunctionAddress, "ReturnValue");
		GenerateDefaultAxisParameters_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateDefaultAxisParameters_FunctionAddress, "ReturnValue");
		GenerateDefaultAxisParameters_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateDefaultAxisParameters_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GenerateDefaultAxisParameters_IsValid = GenerateDefaultAxisParameters_FunctionAddress != IntPtr.Zero && GenerateDefaultAxisParameters_BlendSpace_IsValid && GenerateDefaultAxisParameters_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GenerateDefaultAxisParameters", GenerateDefaultAxisParameters_IsValid);
		GenerateAimOffsetBlendSpace_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GenerateAimOffsetBlendSpace");
		GenerateAimOffsetBlendSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateAimOffsetBlendSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateAimOffsetBlendSpace_AimOffset_PropertyAddress, GenerateAimOffsetBlendSpace_FunctionAddress, "AimOffset");
		GenerateAimOffsetBlendSpace_AimOffset_Offset = NativeReflectionCached.GetPropertyOffset(GenerateAimOffsetBlendSpace_FunctionAddress, "AimOffset");
		GenerateAimOffsetBlendSpace_AimOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateAimOffsetBlendSpace_FunctionAddress, "AimOffset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateAimOffsetBlendSpace_Path_PropertyAddress, GenerateAimOffsetBlendSpace_FunctionAddress, "Path");
		GenerateAimOffsetBlendSpace_Path_Offset = NativeReflectionCached.GetPropertyOffset(GenerateAimOffsetBlendSpace_FunctionAddress, "Path");
		GenerateAimOffsetBlendSpace_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateAimOffsetBlendSpace_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateAimOffsetBlendSpace_ExampleName_PropertyAddress, GenerateAimOffsetBlendSpace_FunctionAddress, "ExampleName");
		GenerateAimOffsetBlendSpace_ExampleName_Offset = NativeReflectionCached.GetPropertyOffset(GenerateAimOffsetBlendSpace_FunctionAddress, "ExampleName");
		GenerateAimOffsetBlendSpace_ExampleName_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateAimOffsetBlendSpace_FunctionAddress, "ExampleName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateAimOffsetBlendSpace_ReturnValue_PropertyAddress, GenerateAimOffsetBlendSpace_FunctionAddress, "ReturnValue");
		GenerateAimOffsetBlendSpace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateAimOffsetBlendSpace_FunctionAddress, "ReturnValue");
		GenerateAimOffsetBlendSpace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateAimOffsetBlendSpace_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GenerateAimOffsetBlendSpace_IsValid = GenerateAimOffsetBlendSpace_FunctionAddress != IntPtr.Zero && GenerateAimOffsetBlendSpace_AimOffset_IsValid && GenerateAimOffsetBlendSpace_Path_IsValid && GenerateAimOffsetBlendSpace_ExampleName_IsValid && GenerateAimOffsetBlendSpace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:GenerateAimOffsetBlendSpace", GenerateAimOffsetBlendSpace_IsValid);
		FindDestructibleMeshFromPathByBoneName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindDestructibleMeshFromPathByBoneName");
		FindDestructibleMeshFromPathByBoneName_ParamsSize = NativeReflection.GetFunctionParamsSize(FindDestructibleMeshFromPathByBoneName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindDestructibleMeshFromPathByBoneName_FolderPath_PropertyAddress, FindDestructibleMeshFromPathByBoneName_FunctionAddress, "FolderPath");
		FindDestructibleMeshFromPathByBoneName_FolderPath_Offset = NativeReflectionCached.GetPropertyOffset(FindDestructibleMeshFromPathByBoneName_FunctionAddress, "FolderPath");
		FindDestructibleMeshFromPathByBoneName_FolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(FindDestructibleMeshFromPathByBoneName_FunctionAddress, "FolderPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindDestructibleMeshFromPathByBoneName_BoneName_PropertyAddress, FindDestructibleMeshFromPathByBoneName_FunctionAddress, "BoneName");
		FindDestructibleMeshFromPathByBoneName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(FindDestructibleMeshFromPathByBoneName_FunctionAddress, "BoneName");
		FindDestructibleMeshFromPathByBoneName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindDestructibleMeshFromPathByBoneName_FunctionAddress, "BoneName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindDestructibleMeshFromPathByBoneName_ReturnValue_PropertyAddress, FindDestructibleMeshFromPathByBoneName_FunctionAddress, "ReturnValue");
		FindDestructibleMeshFromPathByBoneName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindDestructibleMeshFromPathByBoneName_FunctionAddress, "ReturnValue");
		FindDestructibleMeshFromPathByBoneName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindDestructibleMeshFromPathByBoneName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindDestructibleMeshFromPathByBoneName_IsValid = FindDestructibleMeshFromPathByBoneName_FunctionAddress != IntPtr.Zero && FindDestructibleMeshFromPathByBoneName_FolderPath_IsValid && FindDestructibleMeshFromPathByBoneName_BoneName_IsValid && FindDestructibleMeshFromPathByBoneName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:FindDestructibleMeshFromPathByBoneName", FindDestructibleMeshFromPathByBoneName_IsValid);
		FindAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindAsset");
		FindAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(FindAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindAsset_Path_PropertyAddress, FindAsset_FunctionAddress, "Path");
		FindAsset_Path_Offset = NativeReflectionCached.GetPropertyOffset(FindAsset_FunctionAddress, "Path");
		FindAsset_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAsset_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindAsset_inClass_PropertyAddress, FindAsset_FunctionAddress, "inClass");
		FindAsset_inClass_Offset = NativeReflectionCached.GetPropertyOffset(FindAsset_FunctionAddress, "inClass");
		FindAsset_inClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAsset_FunctionAddress, "inClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindAsset_AssetData_PropertyAddress, FindAsset_FunctionAddress, "AssetData");
		FindAsset_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(FindAsset_FunctionAddress, "AssetData");
		FindAsset_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAsset_FunctionAddress, "AssetData", Classes.FArrayProperty);
		FindAsset_IsValid = FindAsset_FunctionAddress != IntPtr.Zero && FindAsset_Path_IsValid && FindAsset_inClass_IsValid && FindAsset_AssetData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:FindAsset", FindAsset_IsValid);
		ExtractRootMotionFromAnimation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExtractRootMotionFromAnimation");
		ExtractRootMotionFromAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(ExtractRootMotionFromAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExtractRootMotionFromAnimation_Animation_PropertyAddress, ExtractRootMotionFromAnimation_FunctionAddress, "Animation");
		ExtractRootMotionFromAnimation_Animation_Offset = NativeReflectionCached.GetPropertyOffset(ExtractRootMotionFromAnimation_FunctionAddress, "Animation");
		ExtractRootMotionFromAnimation_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractRootMotionFromAnimation_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractRootMotionFromAnimation_StartTime_PropertyAddress, ExtractRootMotionFromAnimation_FunctionAddress, "StartTime");
		ExtractRootMotionFromAnimation_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(ExtractRootMotionFromAnimation_FunctionAddress, "StartTime");
		ExtractRootMotionFromAnimation_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractRootMotionFromAnimation_FunctionAddress, "StartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractRootMotionFromAnimation_EndTime_PropertyAddress, ExtractRootMotionFromAnimation_FunctionAddress, "EndTime");
		ExtractRootMotionFromAnimation_EndTime_Offset = NativeReflectionCached.GetPropertyOffset(ExtractRootMotionFromAnimation_FunctionAddress, "EndTime");
		ExtractRootMotionFromAnimation_EndTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractRootMotionFromAnimation_FunctionAddress, "EndTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractRootMotionFromAnimation_ReturnValue_PropertyAddress, ExtractRootMotionFromAnimation_FunctionAddress, "ReturnValue");
		ExtractRootMotionFromAnimation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExtractRootMotionFromAnimation_FunctionAddress, "ReturnValue");
		ExtractRootMotionFromAnimation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractRootMotionFromAnimation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ExtractRootMotionFromAnimation_IsValid = ExtractRootMotionFromAnimation_FunctionAddress != IntPtr.Zero && ExtractRootMotionFromAnimation_Animation_IsValid && ExtractRootMotionFromAnimation_StartTime_IsValid && ExtractRootMotionFromAnimation_EndTime_IsValid && ExtractRootMotionFromAnimation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:ExtractRootMotionFromAnimation", ExtractRootMotionFromAnimation_IsValid);
		DisableMontageRootMotionByInstanceID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DisableMontageRootMotionByInstanceID");
		DisableMontageRootMotionByInstanceID_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableMontageRootMotionByInstanceID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisableMontageRootMotionByInstanceID_Character_PropertyAddress, DisableMontageRootMotionByInstanceID_FunctionAddress, "Character");
		DisableMontageRootMotionByInstanceID_Character_Offset = NativeReflectionCached.GetPropertyOffset(DisableMontageRootMotionByInstanceID_FunctionAddress, "Character");
		DisableMontageRootMotionByInstanceID_Character_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableMontageRootMotionByInstanceID_FunctionAddress, "Character", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableMontageRootMotionByInstanceID_MontageInstanceID_PropertyAddress, DisableMontageRootMotionByInstanceID_FunctionAddress, "MontageInstanceID");
		DisableMontageRootMotionByInstanceID_MontageInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(DisableMontageRootMotionByInstanceID_FunctionAddress, "MontageInstanceID");
		DisableMontageRootMotionByInstanceID_MontageInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableMontageRootMotionByInstanceID_FunctionAddress, "MontageInstanceID", Classes.FIntProperty);
		DisableMontageRootMotionByInstanceID_IsValid = DisableMontageRootMotionByInstanceID_FunctionAddress != IntPtr.Zero && DisableMontageRootMotionByInstanceID_Character_IsValid && DisableMontageRootMotionByInstanceID_MontageInstanceID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:DisableMontageRootMotionByInstanceID", DisableMontageRootMotionByInstanceID_IsValid);
		CreateBlendSpace1D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateBlendSpace1D");
		CreateBlendSpace1D_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateBlendSpace1D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateBlendSpace1D_Path_PropertyAddress, CreateBlendSpace1D_FunctionAddress, "Path");
		CreateBlendSpace1D_Path_Offset = NativeReflectionCached.GetPropertyOffset(CreateBlendSpace1D_FunctionAddress, "Path");
		CreateBlendSpace1D_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBlendSpace1D_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBlendSpace1D_Name_PropertyAddress, CreateBlendSpace1D_FunctionAddress, "Name");
		CreateBlendSpace1D_Name_Offset = NativeReflectionCached.GetPropertyOffset(CreateBlendSpace1D_FunctionAddress, "Name");
		CreateBlendSpace1D_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBlendSpace1D_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBlendSpace1D_TargetSkeleton_PropertyAddress, CreateBlendSpace1D_FunctionAddress, "TargetSkeleton");
		CreateBlendSpace1D_TargetSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(CreateBlendSpace1D_FunctionAddress, "TargetSkeleton");
		CreateBlendSpace1D_TargetSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBlendSpace1D_FunctionAddress, "TargetSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBlendSpace1D_ReturnValue_PropertyAddress, CreateBlendSpace1D_FunctionAddress, "ReturnValue");
		CreateBlendSpace1D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateBlendSpace1D_FunctionAddress, "ReturnValue");
		CreateBlendSpace1D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBlendSpace1D_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateBlendSpace1D_IsValid = CreateBlendSpace1D_FunctionAddress != IntPtr.Zero && CreateBlendSpace1D_Path_IsValid && CreateBlendSpace1D_Name_IsValid && CreateBlendSpace1D_TargetSkeleton_IsValid && CreateBlendSpace1D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:CreateBlendSpace1D", CreateBlendSpace1D_IsValid);
		CreateBlendSpace_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateBlendSpace");
		CreateBlendSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateBlendSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateBlendSpace_Path_PropertyAddress, CreateBlendSpace_FunctionAddress, "Path");
		CreateBlendSpace_Path_Offset = NativeReflectionCached.GetPropertyOffset(CreateBlendSpace_FunctionAddress, "Path");
		CreateBlendSpace_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBlendSpace_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBlendSpace_Name_PropertyAddress, CreateBlendSpace_FunctionAddress, "Name");
		CreateBlendSpace_Name_Offset = NativeReflectionCached.GetPropertyOffset(CreateBlendSpace_FunctionAddress, "Name");
		CreateBlendSpace_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBlendSpace_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBlendSpace_TargetSkeleton_PropertyAddress, CreateBlendSpace_FunctionAddress, "TargetSkeleton");
		CreateBlendSpace_TargetSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(CreateBlendSpace_FunctionAddress, "TargetSkeleton");
		CreateBlendSpace_TargetSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBlendSpace_FunctionAddress, "TargetSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBlendSpace_ReturnValue_PropertyAddress, CreateBlendSpace_FunctionAddress, "ReturnValue");
		CreateBlendSpace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateBlendSpace_FunctionAddress, "ReturnValue");
		CreateBlendSpace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBlendSpace_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateBlendSpace_IsValid = CreateBlendSpace_FunctionAddress != IntPtr.Zero && CreateBlendSpace_Path_IsValid && CreateBlendSpace_Name_IsValid && CreateBlendSpace_TargetSkeleton_IsValid && CreateBlendSpace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:CreateBlendSpace", CreateBlendSpace_IsValid);
		CreateAnimMontage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateAnimMontage");
		CreateAnimMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateAnimMontage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateAnimMontage_Path_PropertyAddress, CreateAnimMontage_FunctionAddress, "Path");
		CreateAnimMontage_Path_Offset = NativeReflectionCached.GetPropertyOffset(CreateAnimMontage_FunctionAddress, "Path");
		CreateAnimMontage_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAnimMontage_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAnimMontage_Name_PropertyAddress, CreateAnimMontage_FunctionAddress, "Name");
		CreateAnimMontage_Name_Offset = NativeReflectionCached.GetPropertyOffset(CreateAnimMontage_FunctionAddress, "Name");
		CreateAnimMontage_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAnimMontage_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAnimMontage_TargetSkeleton_PropertyAddress, CreateAnimMontage_FunctionAddress, "TargetSkeleton");
		CreateAnimMontage_TargetSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(CreateAnimMontage_FunctionAddress, "TargetSkeleton");
		CreateAnimMontage_TargetSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAnimMontage_FunctionAddress, "TargetSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAnimMontage_ReturnValue_PropertyAddress, CreateAnimMontage_FunctionAddress, "ReturnValue");
		CreateAnimMontage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateAnimMontage_FunctionAddress, "ReturnValue");
		CreateAnimMontage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAnimMontage_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateAnimMontage_IsValid = CreateAnimMontage_FunctionAddress != IntPtr.Zero && CreateAnimMontage_Path_IsValid && CreateAnimMontage_Name_IsValid && CreateAnimMontage_TargetSkeleton_IsValid && CreateAnimMontage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:CreateAnimMontage", CreateAnimMontage_IsValid);
		CreateAimOffsetBlendSpace_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateAimOffsetBlendSpace");
		CreateAimOffsetBlendSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateAimOffsetBlendSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateAimOffsetBlendSpace_Path_PropertyAddress, CreateAimOffsetBlendSpace_FunctionAddress, "Path");
		CreateAimOffsetBlendSpace_Path_Offset = NativeReflectionCached.GetPropertyOffset(CreateAimOffsetBlendSpace_FunctionAddress, "Path");
		CreateAimOffsetBlendSpace_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAimOffsetBlendSpace_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAimOffsetBlendSpace_Name_PropertyAddress, CreateAimOffsetBlendSpace_FunctionAddress, "Name");
		CreateAimOffsetBlendSpace_Name_Offset = NativeReflectionCached.GetPropertyOffset(CreateAimOffsetBlendSpace_FunctionAddress, "Name");
		CreateAimOffsetBlendSpace_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAimOffsetBlendSpace_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAimOffsetBlendSpace_TargetSkeleton_PropertyAddress, CreateAimOffsetBlendSpace_FunctionAddress, "TargetSkeleton");
		CreateAimOffsetBlendSpace_TargetSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(CreateAimOffsetBlendSpace_FunctionAddress, "TargetSkeleton");
		CreateAimOffsetBlendSpace_TargetSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAimOffsetBlendSpace_FunctionAddress, "TargetSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAimOffsetBlendSpace_ReturnValue_PropertyAddress, CreateAimOffsetBlendSpace_FunctionAddress, "ReturnValue");
		CreateAimOffsetBlendSpace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateAimOffsetBlendSpace_FunctionAddress, "ReturnValue");
		CreateAimOffsetBlendSpace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAimOffsetBlendSpace_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateAimOffsetBlendSpace_IsValid = CreateAimOffsetBlendSpace_FunctionAddress != IntPtr.Zero && CreateAimOffsetBlendSpace_Path_IsValid && CreateAimOffsetBlendSpace_Name_IsValid && CreateAimOffsetBlendSpace_TargetSkeleton_IsValid && CreateAimOffsetBlendSpace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:CreateAimOffsetBlendSpace", CreateAimOffsetBlendSpace_IsValid);
		ConditionallyDispatchQueuedAnimEvents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConditionallyDispatchQueuedAnimEvents");
		ConditionallyDispatchQueuedAnimEvents_ParamsSize = NativeReflection.GetFunctionParamsSize(ConditionallyDispatchQueuedAnimEvents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConditionallyDispatchQueuedAnimEvents_SkeletalMeshComp_PropertyAddress, ConditionallyDispatchQueuedAnimEvents_FunctionAddress, "SkeletalMeshComp");
		ConditionallyDispatchQueuedAnimEvents_SkeletalMeshComp_Offset = NativeReflectionCached.GetPropertyOffset(ConditionallyDispatchQueuedAnimEvents_FunctionAddress, "SkeletalMeshComp");
		ConditionallyDispatchQueuedAnimEvents_SkeletalMeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(ConditionallyDispatchQueuedAnimEvents_FunctionAddress, "SkeletalMeshComp", Classes.FObjectProperty);
		ConditionallyDispatchQueuedAnimEvents_IsValid = ConditionallyDispatchQueuedAnimEvents_FunctionAddress != IntPtr.Zero && ConditionallyDispatchQueuedAnimEvents_SkeletalMeshComp_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:ConditionallyDispatchQueuedAnimEvents", ConditionallyDispatchQueuedAnimEvents_IsValid);
		CheckoutLoadedAssetAndSave_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckoutLoadedAssetAndSave");
		CheckoutLoadedAssetAndSave_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckoutLoadedAssetAndSave_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckoutLoadedAssetAndSave_DirtyMontage_PropertyAddress, CheckoutLoadedAssetAndSave_FunctionAddress, "DirtyMontage");
		CheckoutLoadedAssetAndSave_DirtyMontage_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutLoadedAssetAndSave_FunctionAddress, "DirtyMontage");
		CheckoutLoadedAssetAndSave_DirtyMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutLoadedAssetAndSave_FunctionAddress, "DirtyMontage", Classes.FObjectProperty);
		CheckoutLoadedAssetAndSave_IsValid = CheckoutLoadedAssetAndSave_FunctionAddress != IntPtr.Zero && CheckoutLoadedAssetAndSave_DirtyMontage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:CheckoutLoadedAssetAndSave", CheckoutLoadedAssetAndSave_IsValid);
		ChangeAnimSeqParamAndSave_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ChangeAnimSeqParamAndSave");
		ChangeAnimSeqParamAndSave_ParamsSize = NativeReflection.GetFunctionParamsSize(ChangeAnimSeqParamAndSave_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ChangeAnimSeqParamAndSave_AnimMontage_PropertyAddress, ChangeAnimSeqParamAndSave_FunctionAddress, "AnimMontage");
		ChangeAnimSeqParamAndSave_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(ChangeAnimSeqParamAndSave_FunctionAddress, "AnimMontage");
		ChangeAnimSeqParamAndSave_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeAnimSeqParamAndSave_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeAnimSeqParamAndSave_bRootMotion_PropertyAddress, ChangeAnimSeqParamAndSave_FunctionAddress, "bRootMotion");
		ChangeAnimSeqParamAndSave_bRootMotion_Offset = NativeReflectionCached.GetPropertyOffset(ChangeAnimSeqParamAndSave_FunctionAddress, "bRootMotion");
		ChangeAnimSeqParamAndSave_bRootMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeAnimSeqParamAndSave_FunctionAddress, "bRootMotion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeAnimSeqParamAndSave_bForceRootLock_PropertyAddress, ChangeAnimSeqParamAndSave_FunctionAddress, "bForceRootLock");
		ChangeAnimSeqParamAndSave_bForceRootLock_Offset = NativeReflectionCached.GetPropertyOffset(ChangeAnimSeqParamAndSave_FunctionAddress, "bForceRootLock");
		ChangeAnimSeqParamAndSave_bForceRootLock_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeAnimSeqParamAndSave_FunctionAddress, "bForceRootLock", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeAnimSeqParamAndSave_ReturnValue_PropertyAddress, ChangeAnimSeqParamAndSave_FunctionAddress, "ReturnValue");
		ChangeAnimSeqParamAndSave_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ChangeAnimSeqParamAndSave_FunctionAddress, "ReturnValue");
		ChangeAnimSeqParamAndSave_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeAnimSeqParamAndSave_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ChangeAnimSeqParamAndSave_IsValid = ChangeAnimSeqParamAndSave_FunctionAddress != IntPtr.Zero && ChangeAnimSeqParamAndSave_AnimMontage_IsValid && ChangeAnimSeqParamAndSave_bRootMotion_IsValid && ChangeAnimSeqParamAndSave_bForceRootLock_IsValid && ChangeAnimSeqParamAndSave_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:ChangeAnimSeqParamAndSave", ChangeAnimSeqParamAndSave_IsValid);
		CalcSlotMontageLocalWeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalcSlotMontageLocalWeight");
		CalcSlotMontageLocalWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcSlotMontageLocalWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalcSlotMontageLocalWeight_AnimInst_PropertyAddress, CalcSlotMontageLocalWeight_FunctionAddress, "AnimInst");
		CalcSlotMontageLocalWeight_AnimInst_Offset = NativeReflectionCached.GetPropertyOffset(CalcSlotMontageLocalWeight_FunctionAddress, "AnimInst");
		CalcSlotMontageLocalWeight_AnimInst_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcSlotMontageLocalWeight_FunctionAddress, "AnimInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcSlotMontageLocalWeight_SlotNodeName_PropertyAddress, CalcSlotMontageLocalWeight_FunctionAddress, "SlotNodeName");
		CalcSlotMontageLocalWeight_SlotNodeName_Offset = NativeReflectionCached.GetPropertyOffset(CalcSlotMontageLocalWeight_FunctionAddress, "SlotNodeName");
		CalcSlotMontageLocalWeight_SlotNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcSlotMontageLocalWeight_FunctionAddress, "SlotNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcSlotMontageLocalWeight_ReturnValue_PropertyAddress, CalcSlotMontageLocalWeight_FunctionAddress, "ReturnValue");
		CalcSlotMontageLocalWeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalcSlotMontageLocalWeight_FunctionAddress, "ReturnValue");
		CalcSlotMontageLocalWeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcSlotMontageLocalWeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CalcSlotMontageLocalWeight_IsValid = CalcSlotMontageLocalWeight_FunctionAddress != IntPtr.Zero && CalcSlotMontageLocalWeight_AnimInst_IsValid && CalcSlotMontageLocalWeight_SlotNodeName_IsValid && CalcSlotMontageLocalWeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:CalcSlotMontageLocalWeight", CalcSlotMontageLocalWeight_IsValid);
		BlendSpaceValidateSampleData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BlendSpaceValidateSampleData");
		BlendSpaceValidateSampleData_ParamsSize = NativeReflection.GetFunctionParamsSize(BlendSpaceValidateSampleData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BlendSpaceValidateSampleData_BlendSpace_PropertyAddress, BlendSpaceValidateSampleData_FunctionAddress, "BlendSpace");
		BlendSpaceValidateSampleData_BlendSpace_Offset = NativeReflectionCached.GetPropertyOffset(BlendSpaceValidateSampleData_FunctionAddress, "BlendSpace");
		BlendSpaceValidateSampleData_BlendSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(BlendSpaceValidateSampleData_FunctionAddress, "BlendSpace", Classes.FObjectProperty);
		BlendSpaceValidateSampleData_IsValid = BlendSpaceValidateSampleData_FunctionAddress != IntPtr.Zero && BlendSpaceValidateSampleData_BlendSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:BlendSpaceValidateSampleData", BlendSpaceValidateSampleData_IsValid);
		ASCopyNotifies_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ASCopyNotifies");
		ASCopyNotifies_ParamsSize = NativeReflection.GetFunctionParamsSize(ASCopyNotifies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ASCopyNotifies_SourceAnimSeq_PropertyAddress, ASCopyNotifies_FunctionAddress, "SourceAnimSeq");
		ASCopyNotifies_SourceAnimSeq_Offset = NativeReflectionCached.GetPropertyOffset(ASCopyNotifies_FunctionAddress, "SourceAnimSeq");
		ASCopyNotifies_SourceAnimSeq_IsValid = NativeReflectionCached.ValidatePropertyClass(ASCopyNotifies_FunctionAddress, "SourceAnimSeq", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ASCopyNotifies_DestAnimSeq_PropertyAddress, ASCopyNotifies_FunctionAddress, "DestAnimSeq");
		ASCopyNotifies_DestAnimSeq_Offset = NativeReflectionCached.GetPropertyOffset(ASCopyNotifies_FunctionAddress, "DestAnimSeq");
		ASCopyNotifies_DestAnimSeq_IsValid = NativeReflectionCached.ValidatePropertyClass(ASCopyNotifies_FunctionAddress, "DestAnimSeq", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ASCopyNotifies_bClearNotifiesInDestBeforeCopy_PropertyAddress, ASCopyNotifies_FunctionAddress, "bClearNotifiesInDestBeforeCopy");
		ASCopyNotifies_bClearNotifiesInDestBeforeCopy_Offset = NativeReflectionCached.GetPropertyOffset(ASCopyNotifies_FunctionAddress, "bClearNotifiesInDestBeforeCopy");
		ASCopyNotifies_bClearNotifiesInDestBeforeCopy_IsValid = NativeReflectionCached.ValidatePropertyClass(ASCopyNotifies_FunctionAddress, "bClearNotifiesInDestBeforeCopy", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ASCopyNotifies_bWithErrorInfo_PropertyAddress, ASCopyNotifies_FunctionAddress, "bWithErrorInfo");
		ASCopyNotifies_bWithErrorInfo_Offset = NativeReflectionCached.GetPropertyOffset(ASCopyNotifies_FunctionAddress, "bWithErrorInfo");
		ASCopyNotifies_bWithErrorInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(ASCopyNotifies_FunctionAddress, "bWithErrorInfo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ASCopyNotifies_ReturnValue_PropertyAddress, ASCopyNotifies_FunctionAddress, "ReturnValue");
		ASCopyNotifies_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ASCopyNotifies_FunctionAddress, "ReturnValue");
		ASCopyNotifies_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ASCopyNotifies_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ASCopyNotifies_IsValid = ASCopyNotifies_FunctionAddress != IntPtr.Zero && ASCopyNotifies_SourceAnimSeq_IsValid && ASCopyNotifies_DestAnimSeq_IsValid && ASCopyNotifies_bClearNotifiesInDestBeforeCopy_IsValid && ASCopyNotifies_bWithErrorInfo_IsValid && ASCopyNotifies_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:ASCopyNotifies", ASCopyNotifies_IsValid);
		ApplyRadiusDamage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyRadiusDamage");
		ApplyRadiusDamage_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyRadiusDamage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadiusDamage_Destructible_PropertyAddress, ApplyRadiusDamage_FunctionAddress, "Destructible");
		ApplyRadiusDamage_Destructible_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadiusDamage_FunctionAddress, "Destructible");
		ApplyRadiusDamage_Destructible_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadiusDamage_FunctionAddress, "Destructible", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadiusDamage_BaseDamage_PropertyAddress, ApplyRadiusDamage_FunctionAddress, "BaseDamage");
		ApplyRadiusDamage_BaseDamage_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadiusDamage_FunctionAddress, "BaseDamage");
		ApplyRadiusDamage_BaseDamage_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadiusDamage_FunctionAddress, "BaseDamage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadiusDamage_HurtOrigin_PropertyAddress, ApplyRadiusDamage_FunctionAddress, "HurtOrigin");
		ApplyRadiusDamage_HurtOrigin_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadiusDamage_FunctionAddress, "HurtOrigin");
		ApplyRadiusDamage_HurtOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadiusDamage_FunctionAddress, "HurtOrigin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadiusDamage_DamageRadius_PropertyAddress, ApplyRadiusDamage_FunctionAddress, "DamageRadius");
		ApplyRadiusDamage_DamageRadius_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadiusDamage_FunctionAddress, "DamageRadius");
		ApplyRadiusDamage_DamageRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadiusDamage_FunctionAddress, "DamageRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadiusDamage_ImpulseStrength_PropertyAddress, ApplyRadiusDamage_FunctionAddress, "ImpulseStrength");
		ApplyRadiusDamage_ImpulseStrength_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadiusDamage_FunctionAddress, "ImpulseStrength");
		ApplyRadiusDamage_ImpulseStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadiusDamage_FunctionAddress, "ImpulseStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadiusDamage_bFullDamage_PropertyAddress, ApplyRadiusDamage_FunctionAddress, "bFullDamage");
		ApplyRadiusDamage_bFullDamage_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadiusDamage_FunctionAddress, "bFullDamage");
		ApplyRadiusDamage_bFullDamage_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadiusDamage_FunctionAddress, "bFullDamage", Classes.FBoolProperty);
		ApplyRadiusDamage_IsValid = ApplyRadiusDamage_FunctionAddress != IntPtr.Zero && ApplyRadiusDamage_Destructible_IsValid && ApplyRadiusDamage_BaseDamage_IsValid && ApplyRadiusDamage_HurtOrigin_IsValid && ApplyRadiusDamage_DamageRadius_IsValid && ApplyRadiusDamage_ImpulseStrength_IsValid && ApplyRadiusDamage_bFullDamage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:ApplyRadiusDamage", ApplyRadiusDamage_IsValid);
		ApplyDamage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyDamage");
		ApplyDamage_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyDamage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyDamage_Destructible_PropertyAddress, ApplyDamage_FunctionAddress, "Destructible");
		ApplyDamage_Destructible_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDamage_FunctionAddress, "Destructible");
		ApplyDamage_Destructible_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDamage_FunctionAddress, "Destructible", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyDamage_DamageAmount_PropertyAddress, ApplyDamage_FunctionAddress, "DamageAmount");
		ApplyDamage_DamageAmount_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDamage_FunctionAddress, "DamageAmount");
		ApplyDamage_DamageAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDamage_FunctionAddress, "DamageAmount", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyDamage_HitLocation_PropertyAddress, ApplyDamage_FunctionAddress, "HitLocation");
		ApplyDamage_HitLocation_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDamage_FunctionAddress, "HitLocation");
		ApplyDamage_HitLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDamage_FunctionAddress, "HitLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyDamage_ImpulseDir_PropertyAddress, ApplyDamage_FunctionAddress, "ImpulseDir");
		ApplyDamage_ImpulseDir_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDamage_FunctionAddress, "ImpulseDir");
		ApplyDamage_ImpulseDir_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDamage_FunctionAddress, "ImpulseDir", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyDamage_ImpulseStrength_PropertyAddress, ApplyDamage_FunctionAddress, "ImpulseStrength");
		ApplyDamage_ImpulseStrength_Offset = NativeReflectionCached.GetPropertyOffset(ApplyDamage_FunctionAddress, "ImpulseStrength");
		ApplyDamage_ImpulseStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyDamage_FunctionAddress, "ImpulseStrength", Classes.FFloatProperty);
		ApplyDamage_IsValid = ApplyDamage_FunctionAddress != IntPtr.Zero && ApplyDamage_Destructible_IsValid && ApplyDamage_DamageAmount_IsValid && ApplyDamage_HitLocation_IsValid && ApplyDamage_ImpulseDir_IsValid && ApplyDamage_ImpulseStrength_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:ApplyDamage", ApplyDamage_IsValid);
		AnimSequenceGetRootMotionRotationForScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AnimSequenceGetRootMotionRotationForScale");
		AnimSequenceGetRootMotionRotationForScale_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimSequenceGetRootMotionRotationForScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceGetRootMotionRotationForScale_AnimMontage_PropertyAddress, AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "AnimMontage");
		AnimSequenceGetRootMotionRotationForScale_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "AnimMontage");
		AnimSequenceGetRootMotionRotationForScale_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceGetRootMotionRotationForScale_OutStartPos_PropertyAddress, AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "OutStartPos");
		AnimSequenceGetRootMotionRotationForScale_OutStartPos_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "OutStartPos");
		AnimSequenceGetRootMotionRotationForScale_OutStartPos_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "OutStartPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceGetRootMotionRotationForScale_OutEndPos_PropertyAddress, AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "OutEndPos");
		AnimSequenceGetRootMotionRotationForScale_OutEndPos_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "OutEndPos");
		AnimSequenceGetRootMotionRotationForScale_OutEndPos_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "OutEndPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceGetRootMotionRotationForScale_LeftScaleTime_PropertyAddress, AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "LeftScaleTime");
		AnimSequenceGetRootMotionRotationForScale_LeftScaleTime_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "LeftScaleTime");
		AnimSequenceGetRootMotionRotationForScale_LeftScaleTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "LeftScaleTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceGetRootMotionRotationForScale_RightScaleTime_PropertyAddress, AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "RightScaleTime");
		AnimSequenceGetRootMotionRotationForScale_RightScaleTime_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "RightScaleTime");
		AnimSequenceGetRootMotionRotationForScale_RightScaleTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "RightScaleTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceGetRootMotionRotationForScale_ReturnValue_PropertyAddress, AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "ReturnValue");
		AnimSequenceGetRootMotionRotationForScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "ReturnValue");
		AnimSequenceGetRootMotionRotationForScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceGetRootMotionRotationForScale_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AnimSequenceGetRootMotionRotationForScale_IsValid = AnimSequenceGetRootMotionRotationForScale_FunctionAddress != IntPtr.Zero && AnimSequenceGetRootMotionRotationForScale_AnimMontage_IsValid && AnimSequenceGetRootMotionRotationForScale_OutStartPos_IsValid && AnimSequenceGetRootMotionRotationForScale_OutEndPos_IsValid && AnimSequenceGetRootMotionRotationForScale_LeftScaleTime_IsValid && AnimSequenceGetRootMotionRotationForScale_RightScaleTime_IsValid && AnimSequenceGetRootMotionRotationForScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AnimSequenceGetRootMotionRotationForScale", AnimSequenceGetRootMotionRotationForScale_IsValid);
		AnimSequenceGetRootMotionLocationForScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AnimSequenceGetRootMotionLocationForScale");
		AnimSequenceGetRootMotionLocationForScale_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimSequenceGetRootMotionLocationForScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceGetRootMotionLocationForScale_AnimMontage_PropertyAddress, AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "AnimMontage");
		AnimSequenceGetRootMotionLocationForScale_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "AnimMontage");
		AnimSequenceGetRootMotionLocationForScale_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceGetRootMotionLocationForScale_OutStartPos_PropertyAddress, AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "OutStartPos");
		AnimSequenceGetRootMotionLocationForScale_OutStartPos_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "OutStartPos");
		AnimSequenceGetRootMotionLocationForScale_OutStartPos_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "OutStartPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceGetRootMotionLocationForScale_OutEndPos_PropertyAddress, AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "OutEndPos");
		AnimSequenceGetRootMotionLocationForScale_OutEndPos_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "OutEndPos");
		AnimSequenceGetRootMotionLocationForScale_OutEndPos_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "OutEndPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceGetRootMotionLocationForScale_LeftScaleTime_PropertyAddress, AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "LeftScaleTime");
		AnimSequenceGetRootMotionLocationForScale_LeftScaleTime_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "LeftScaleTime");
		AnimSequenceGetRootMotionLocationForScale_LeftScaleTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "LeftScaleTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceGetRootMotionLocationForScale_RightScaleTime_PropertyAddress, AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "RightScaleTime");
		AnimSequenceGetRootMotionLocationForScale_RightScaleTime_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "RightScaleTime");
		AnimSequenceGetRootMotionLocationForScale_RightScaleTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "RightScaleTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceGetRootMotionLocationForScale_ReturnValue_PropertyAddress, AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "ReturnValue");
		AnimSequenceGetRootMotionLocationForScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "ReturnValue");
		AnimSequenceGetRootMotionLocationForScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceGetRootMotionLocationForScale_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AnimSequenceGetRootMotionLocationForScale_IsValid = AnimSequenceGetRootMotionLocationForScale_FunctionAddress != IntPtr.Zero && AnimSequenceGetRootMotionLocationForScale_AnimMontage_IsValid && AnimSequenceGetRootMotionLocationForScale_OutStartPos_IsValid && AnimSequenceGetRootMotionLocationForScale_OutEndPos_IsValid && AnimSequenceGetRootMotionLocationForScale_LeftScaleTime_IsValid && AnimSequenceGetRootMotionLocationForScale_RightScaleTime_IsValid && AnimSequenceGetRootMotionLocationForScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AnimSequenceGetRootMotionLocationForScale", AnimSequenceGetRootMotionLocationForScale_IsValid);
		AnimSequenceFindPosWithDistanceCurve_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AnimSequenceFindPosWithDistanceCurve");
		AnimSequenceFindPosWithDistanceCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimSequenceFindPosWithDistanceCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceFindPosWithDistanceCurve_AnimationSequence_PropertyAddress, AnimSequenceFindPosWithDistanceCurve_FunctionAddress, "AnimationSequence");
		AnimSequenceFindPosWithDistanceCurve_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceFindPosWithDistanceCurve_FunctionAddress, "AnimationSequence");
		AnimSequenceFindPosWithDistanceCurve_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceFindPosWithDistanceCurve_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceFindPosWithDistanceCurve_CurveName_PropertyAddress, AnimSequenceFindPosWithDistanceCurve_FunctionAddress, "CurveName");
		AnimSequenceFindPosWithDistanceCurve_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceFindPosWithDistanceCurve_FunctionAddress, "CurveName");
		AnimSequenceFindPosWithDistanceCurve_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceFindPosWithDistanceCurve_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceFindPosWithDistanceCurve_DistanceValue_PropertyAddress, AnimSequenceFindPosWithDistanceCurve_FunctionAddress, "DistanceValue");
		AnimSequenceFindPosWithDistanceCurve_DistanceValue_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceFindPosWithDistanceCurve_FunctionAddress, "DistanceValue");
		AnimSequenceFindPosWithDistanceCurve_DistanceValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceFindPosWithDistanceCurve_FunctionAddress, "DistanceValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimSequenceFindPosWithDistanceCurve_ReturnValue_PropertyAddress, AnimSequenceFindPosWithDistanceCurve_FunctionAddress, "ReturnValue");
		AnimSequenceFindPosWithDistanceCurve_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AnimSequenceFindPosWithDistanceCurve_FunctionAddress, "ReturnValue");
		AnimSequenceFindPosWithDistanceCurve_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimSequenceFindPosWithDistanceCurve_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		AnimSequenceFindPosWithDistanceCurve_IsValid = AnimSequenceFindPosWithDistanceCurve_FunctionAddress != IntPtr.Zero && AnimSequenceFindPosWithDistanceCurve_AnimationSequence_IsValid && AnimSequenceFindPosWithDistanceCurve_CurveName_IsValid && AnimSequenceFindPosWithDistanceCurve_DistanceValue_IsValid && AnimSequenceFindPosWithDistanceCurve_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AnimSequenceFindPosWithDistanceCurve", AnimSequenceFindPosWithDistanceCurve_IsValid);
		AnimMontageGetSocketLocationForScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AnimMontageGetSocketLocationForScale");
		AnimMontageGetSocketLocationForScale_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimMontageGetSocketLocationForScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetSocketLocationForScale_AnimMontage_PropertyAddress, AnimMontageGetSocketLocationForScale_FunctionAddress, "AnimMontage");
		AnimMontageGetSocketLocationForScale_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetSocketLocationForScale_FunctionAddress, "AnimMontage");
		AnimMontageGetSocketLocationForScale_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetSocketLocationForScale_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetSocketLocationForScale_OutEndPos_PropertyAddress, AnimMontageGetSocketLocationForScale_FunctionAddress, "OutEndPos");
		AnimMontageGetSocketLocationForScale_OutEndPos_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetSocketLocationForScale_FunctionAddress, "OutEndPos");
		AnimMontageGetSocketLocationForScale_OutEndPos_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetSocketLocationForScale_FunctionAddress, "OutEndPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetSocketLocationForScale_ScaleTime_PropertyAddress, AnimMontageGetSocketLocationForScale_FunctionAddress, "ScaleTime");
		AnimMontageGetSocketLocationForScale_ScaleTime_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetSocketLocationForScale_FunctionAddress, "ScaleTime");
		AnimMontageGetSocketLocationForScale_ScaleTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetSocketLocationForScale_FunctionAddress, "ScaleTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetSocketLocationForScale_SocketName_PropertyAddress, AnimMontageGetSocketLocationForScale_FunctionAddress, "SocketName");
		AnimMontageGetSocketLocationForScale_SocketName_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetSocketLocationForScale_FunctionAddress, "SocketName");
		AnimMontageGetSocketLocationForScale_SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetSocketLocationForScale_FunctionAddress, "SocketName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetSocketLocationForScale_ReturnValue_PropertyAddress, AnimMontageGetSocketLocationForScale_FunctionAddress, "ReturnValue");
		AnimMontageGetSocketLocationForScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetSocketLocationForScale_FunctionAddress, "ReturnValue");
		AnimMontageGetSocketLocationForScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetSocketLocationForScale_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AnimMontageGetSocketLocationForScale_IsValid = AnimMontageGetSocketLocationForScale_FunctionAddress != IntPtr.Zero && AnimMontageGetSocketLocationForScale_AnimMontage_IsValid && AnimMontageGetSocketLocationForScale_OutEndPos_IsValid && AnimMontageGetSocketLocationForScale_ScaleTime_IsValid && AnimMontageGetSocketLocationForScale_SocketName_IsValid && AnimMontageGetSocketLocationForScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetSocketLocationForScale", AnimMontageGetSocketLocationForScale_IsValid);
		AnimMontageGetRootMotionRotationForScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AnimMontageGetRootMotionRotationForScale");
		AnimMontageGetRootMotionRotationForScale_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimMontageGetRootMotionRotationForScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetRootMotionRotationForScale_AnimMontage_PropertyAddress, AnimMontageGetRootMotionRotationForScale_FunctionAddress, "AnimMontage");
		AnimMontageGetRootMotionRotationForScale_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetRootMotionRotationForScale_FunctionAddress, "AnimMontage");
		AnimMontageGetRootMotionRotationForScale_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetRootMotionRotationForScale_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetRootMotionRotationForScale_OutStartRotation_PropertyAddress, AnimMontageGetRootMotionRotationForScale_FunctionAddress, "OutStartRotation");
		AnimMontageGetRootMotionRotationForScale_OutStartRotation_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetRootMotionRotationForScale_FunctionAddress, "OutStartRotation");
		AnimMontageGetRootMotionRotationForScale_OutStartRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetRootMotionRotationForScale_FunctionAddress, "OutStartRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetRootMotionRotationForScale_OutEndRotation_PropertyAddress, AnimMontageGetRootMotionRotationForScale_FunctionAddress, "OutEndRotation");
		AnimMontageGetRootMotionRotationForScale_OutEndRotation_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetRootMotionRotationForScale_FunctionAddress, "OutEndRotation");
		AnimMontageGetRootMotionRotationForScale_OutEndRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetRootMotionRotationForScale_FunctionAddress, "OutEndRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetRootMotionRotationForScale_LeftScaleTime_PropertyAddress, AnimMontageGetRootMotionRotationForScale_FunctionAddress, "LeftScaleTime");
		AnimMontageGetRootMotionRotationForScale_LeftScaleTime_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetRootMotionRotationForScale_FunctionAddress, "LeftScaleTime");
		AnimMontageGetRootMotionRotationForScale_LeftScaleTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetRootMotionRotationForScale_FunctionAddress, "LeftScaleTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetRootMotionRotationForScale_RightScaleTime_PropertyAddress, AnimMontageGetRootMotionRotationForScale_FunctionAddress, "RightScaleTime");
		AnimMontageGetRootMotionRotationForScale_RightScaleTime_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetRootMotionRotationForScale_FunctionAddress, "RightScaleTime");
		AnimMontageGetRootMotionRotationForScale_RightScaleTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetRootMotionRotationForScale_FunctionAddress, "RightScaleTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetRootMotionRotationForScale_ReturnValue_PropertyAddress, AnimMontageGetRootMotionRotationForScale_FunctionAddress, "ReturnValue");
		AnimMontageGetRootMotionRotationForScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetRootMotionRotationForScale_FunctionAddress, "ReturnValue");
		AnimMontageGetRootMotionRotationForScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetRootMotionRotationForScale_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AnimMontageGetRootMotionRotationForScale_IsValid = AnimMontageGetRootMotionRotationForScale_FunctionAddress != IntPtr.Zero && AnimMontageGetRootMotionRotationForScale_AnimMontage_IsValid && AnimMontageGetRootMotionRotationForScale_OutStartRotation_IsValid && AnimMontageGetRootMotionRotationForScale_OutEndRotation_IsValid && AnimMontageGetRootMotionRotationForScale_LeftScaleTime_IsValid && AnimMontageGetRootMotionRotationForScale_RightScaleTime_IsValid && AnimMontageGetRootMotionRotationForScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetRootMotionRotationForScale", AnimMontageGetRootMotionRotationForScale_IsValid);
		AnimMontageGetRootMotionLocationForScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AnimMontageGetRootMotionLocationForScale");
		AnimMontageGetRootMotionLocationForScale_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimMontageGetRootMotionLocationForScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetRootMotionLocationForScale_AnimMontage_PropertyAddress, AnimMontageGetRootMotionLocationForScale_FunctionAddress, "AnimMontage");
		AnimMontageGetRootMotionLocationForScale_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetRootMotionLocationForScale_FunctionAddress, "AnimMontage");
		AnimMontageGetRootMotionLocationForScale_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetRootMotionLocationForScale_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetRootMotionLocationForScale_OutStartPos_PropertyAddress, AnimMontageGetRootMotionLocationForScale_FunctionAddress, "OutStartPos");
		AnimMontageGetRootMotionLocationForScale_OutStartPos_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetRootMotionLocationForScale_FunctionAddress, "OutStartPos");
		AnimMontageGetRootMotionLocationForScale_OutStartPos_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetRootMotionLocationForScale_FunctionAddress, "OutStartPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetRootMotionLocationForScale_OutEndPos_PropertyAddress, AnimMontageGetRootMotionLocationForScale_FunctionAddress, "OutEndPos");
		AnimMontageGetRootMotionLocationForScale_OutEndPos_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetRootMotionLocationForScale_FunctionAddress, "OutEndPos");
		AnimMontageGetRootMotionLocationForScale_OutEndPos_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetRootMotionLocationForScale_FunctionAddress, "OutEndPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetRootMotionLocationForScale_LeftScaleTime_PropertyAddress, AnimMontageGetRootMotionLocationForScale_FunctionAddress, "LeftScaleTime");
		AnimMontageGetRootMotionLocationForScale_LeftScaleTime_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetRootMotionLocationForScale_FunctionAddress, "LeftScaleTime");
		AnimMontageGetRootMotionLocationForScale_LeftScaleTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetRootMotionLocationForScale_FunctionAddress, "LeftScaleTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetRootMotionLocationForScale_RightScaleTime_PropertyAddress, AnimMontageGetRootMotionLocationForScale_FunctionAddress, "RightScaleTime");
		AnimMontageGetRootMotionLocationForScale_RightScaleTime_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetRootMotionLocationForScale_FunctionAddress, "RightScaleTime");
		AnimMontageGetRootMotionLocationForScale_RightScaleTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetRootMotionLocationForScale_FunctionAddress, "RightScaleTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetRootMotionLocationForScale_ReturnValue_PropertyAddress, AnimMontageGetRootMotionLocationForScale_FunctionAddress, "ReturnValue");
		AnimMontageGetRootMotionLocationForScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetRootMotionLocationForScale_FunctionAddress, "ReturnValue");
		AnimMontageGetRootMotionLocationForScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetRootMotionLocationForScale_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AnimMontageGetRootMotionLocationForScale_IsValid = AnimMontageGetRootMotionLocationForScale_FunctionAddress != IntPtr.Zero && AnimMontageGetRootMotionLocationForScale_AnimMontage_IsValid && AnimMontageGetRootMotionLocationForScale_OutStartPos_IsValid && AnimMontageGetRootMotionLocationForScale_OutEndPos_IsValid && AnimMontageGetRootMotionLocationForScale_LeftScaleTime_IsValid && AnimMontageGetRootMotionLocationForScale_RightScaleTime_IsValid && AnimMontageGetRootMotionLocationForScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetRootMotionLocationForScale", AnimMontageGetRootMotionLocationForScale_IsValid);
		AnimMontageGetQTEBoneTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AnimMontageGetQTEBoneTransform");
		AnimMontageGetQTEBoneTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimMontageGetQTEBoneTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetQTEBoneTransform_AnimMontage_PropertyAddress, AnimMontageGetQTEBoneTransform_FunctionAddress, "AnimMontage");
		AnimMontageGetQTEBoneTransform_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetQTEBoneTransform_FunctionAddress, "AnimMontage");
		AnimMontageGetQTEBoneTransform_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetQTEBoneTransform_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetQTEBoneTransform_MeshComponent_PropertyAddress, AnimMontageGetQTEBoneTransform_FunctionAddress, "MeshComponent");
		AnimMontageGetQTEBoneTransform_MeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetQTEBoneTransform_FunctionAddress, "MeshComponent");
		AnimMontageGetQTEBoneTransform_MeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetQTEBoneTransform_FunctionAddress, "MeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetQTEBoneTransform_BoneName_PropertyAddress, AnimMontageGetQTEBoneTransform_FunctionAddress, "BoneName");
		AnimMontageGetQTEBoneTransform_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetQTEBoneTransform_FunctionAddress, "BoneName");
		AnimMontageGetQTEBoneTransform_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetQTEBoneTransform_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetQTEBoneTransform_Pos_PropertyAddress, AnimMontageGetQTEBoneTransform_FunctionAddress, "Pos");
		AnimMontageGetQTEBoneTransform_Pos_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetQTEBoneTransform_FunctionAddress, "Pos");
		AnimMontageGetQTEBoneTransform_Pos_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetQTEBoneTransform_FunctionAddress, "Pos", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetQTEBoneTransform_ReturnValue_PropertyAddress, AnimMontageGetQTEBoneTransform_FunctionAddress, "ReturnValue");
		AnimMontageGetQTEBoneTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetQTEBoneTransform_FunctionAddress, "ReturnValue");
		AnimMontageGetQTEBoneTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetQTEBoneTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AnimMontageGetQTEBoneTransform_IsValid = AnimMontageGetQTEBoneTransform_FunctionAddress != IntPtr.Zero && AnimMontageGetQTEBoneTransform_AnimMontage_IsValid && AnimMontageGetQTEBoneTransform_MeshComponent_IsValid && AnimMontageGetQTEBoneTransform_BoneName_IsValid && AnimMontageGetQTEBoneTransform_Pos_IsValid && AnimMontageGetQTEBoneTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetQTEBoneTransform", AnimMontageGetQTEBoneTransform_IsValid);
		AnimMontageGetMontageEndTimeForScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AnimMontageGetMontageEndTimeForScale");
		AnimMontageGetMontageEndTimeForScale_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimMontageGetMontageEndTimeForScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetMontageEndTimeForScale_AnimMontage_PropertyAddress, AnimMontageGetMontageEndTimeForScale_FunctionAddress, "AnimMontage");
		AnimMontageGetMontageEndTimeForScale_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetMontageEndTimeForScale_FunctionAddress, "AnimMontage");
		AnimMontageGetMontageEndTimeForScale_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetMontageEndTimeForScale_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetMontageEndTimeForScale_ReturnValue_PropertyAddress, AnimMontageGetMontageEndTimeForScale_FunctionAddress, "ReturnValue");
		AnimMontageGetMontageEndTimeForScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetMontageEndTimeForScale_FunctionAddress, "ReturnValue");
		AnimMontageGetMontageEndTimeForScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetMontageEndTimeForScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		AnimMontageGetMontageEndTimeForScale_IsValid = AnimMontageGetMontageEndTimeForScale_FunctionAddress != IntPtr.Zero && AnimMontageGetMontageEndTimeForScale_AnimMontage_IsValid && AnimMontageGetMontageEndTimeForScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetMontageEndTimeForScale", AnimMontageGetMontageEndTimeForScale_IsValid);
		AnimMontageGetBoneTransformWS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AnimMontageGetBoneTransformWS");
		AnimMontageGetBoneTransformWS_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimMontageGetBoneTransformWS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetBoneTransformWS_AnimMontage_PropertyAddress, AnimMontageGetBoneTransformWS_FunctionAddress, "AnimMontage");
		AnimMontageGetBoneTransformWS_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetBoneTransformWS_FunctionAddress, "AnimMontage");
		AnimMontageGetBoneTransformWS_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetBoneTransformWS_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetBoneTransformWS_MeshComponent_PropertyAddress, AnimMontageGetBoneTransformWS_FunctionAddress, "MeshComponent");
		AnimMontageGetBoneTransformWS_MeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetBoneTransformWS_FunctionAddress, "MeshComponent");
		AnimMontageGetBoneTransformWS_MeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetBoneTransformWS_FunctionAddress, "MeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetBoneTransformWS_BoneName_PropertyAddress, AnimMontageGetBoneTransformWS_FunctionAddress, "BoneName");
		AnimMontageGetBoneTransformWS_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetBoneTransformWS_FunctionAddress, "BoneName");
		AnimMontageGetBoneTransformWS_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetBoneTransformWS_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetBoneTransformWS_Pos_PropertyAddress, AnimMontageGetBoneTransformWS_FunctionAddress, "Pos");
		AnimMontageGetBoneTransformWS_Pos_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetBoneTransformWS_FunctionAddress, "Pos");
		AnimMontageGetBoneTransformWS_Pos_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetBoneTransformWS_FunctionAddress, "Pos", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetBoneTransformWS_IsNeedFixRotator_PropertyAddress, AnimMontageGetBoneTransformWS_FunctionAddress, "IsNeedFixRotator");
		AnimMontageGetBoneTransformWS_IsNeedFixRotator_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetBoneTransformWS_FunctionAddress, "IsNeedFixRotator");
		AnimMontageGetBoneTransformWS_IsNeedFixRotator_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetBoneTransformWS_FunctionAddress, "IsNeedFixRotator", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetBoneTransformWS_FixRotator_PropertyAddress, AnimMontageGetBoneTransformWS_FunctionAddress, "FixRotator");
		AnimMontageGetBoneTransformWS_FixRotator_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetBoneTransformWS_FunctionAddress, "FixRotator");
		AnimMontageGetBoneTransformWS_FixRotator_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetBoneTransformWS_FunctionAddress, "FixRotator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetBoneTransformWS_ReturnValue_PropertyAddress, AnimMontageGetBoneTransformWS_FunctionAddress, "ReturnValue");
		AnimMontageGetBoneTransformWS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetBoneTransformWS_FunctionAddress, "ReturnValue");
		AnimMontageGetBoneTransformWS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetBoneTransformWS_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AnimMontageGetBoneTransformWS_IsValid = AnimMontageGetBoneTransformWS_FunctionAddress != IntPtr.Zero && AnimMontageGetBoneTransformWS_AnimMontage_IsValid && AnimMontageGetBoneTransformWS_MeshComponent_IsValid && AnimMontageGetBoneTransformWS_BoneName_IsValid && AnimMontageGetBoneTransformWS_Pos_IsValid && AnimMontageGetBoneTransformWS_IsNeedFixRotator_IsValid && AnimMontageGetBoneTransformWS_FixRotator_IsValid && AnimMontageGetBoneTransformWS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetBoneTransformWS", AnimMontageGetBoneTransformWS_IsValid);
		AnimMontageGetBlendInAndOutTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AnimMontageGetBlendInAndOutTime");
		AnimMontageGetBlendInAndOutTime_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimMontageGetBlendInAndOutTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetBlendInAndOutTime_AnimMontage_PropertyAddress, AnimMontageGetBlendInAndOutTime_FunctionAddress, "AnimMontage");
		AnimMontageGetBlendInAndOutTime_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetBlendInAndOutTime_FunctionAddress, "AnimMontage");
		AnimMontageGetBlendInAndOutTime_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetBlendInAndOutTime_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetBlendInAndOutTime_BlendInTime_PropertyAddress, AnimMontageGetBlendInAndOutTime_FunctionAddress, "BlendInTime");
		AnimMontageGetBlendInAndOutTime_BlendInTime_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetBlendInAndOutTime_FunctionAddress, "BlendInTime");
		AnimMontageGetBlendInAndOutTime_BlendInTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetBlendInAndOutTime_FunctionAddress, "BlendInTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimMontageGetBlendInAndOutTime_BlendOutTime_PropertyAddress, AnimMontageGetBlendInAndOutTime_FunctionAddress, "BlendOutTime");
		AnimMontageGetBlendInAndOutTime_BlendOutTime_Offset = NativeReflectionCached.GetPropertyOffset(AnimMontageGetBlendInAndOutTime_FunctionAddress, "BlendOutTime");
		AnimMontageGetBlendInAndOutTime_BlendOutTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimMontageGetBlendInAndOutTime_FunctionAddress, "BlendOutTime", Classes.FFloatProperty);
		AnimMontageGetBlendInAndOutTime_IsValid = AnimMontageGetBlendInAndOutTime_FunctionAddress != IntPtr.Zero && AnimMontageGetBlendInAndOutTime_AnimMontage_IsValid && AnimMontageGetBlendInAndOutTime_BlendInTime_IsValid && AnimMontageGetBlendInAndOutTime_BlendOutTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AnimMontageGetBlendInAndOutTime", AnimMontageGetBlendInAndOutTime_IsValid);
		AnimInstanceMontageSetPos_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AnimInstanceMontageSetPos");
		AnimInstanceMontageSetPos_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimInstanceMontageSetPos_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimInstanceMontageSetPos_AnimInst_PropertyAddress, AnimInstanceMontageSetPos_FunctionAddress, "AnimInst");
		AnimInstanceMontageSetPos_AnimInst_Offset = NativeReflectionCached.GetPropertyOffset(AnimInstanceMontageSetPos_FunctionAddress, "AnimInst");
		AnimInstanceMontageSetPos_AnimInst_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimInstanceMontageSetPos_FunctionAddress, "AnimInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimInstanceMontageSetPos_MontagePos_PropertyAddress, AnimInstanceMontageSetPos_FunctionAddress, "MontagePos");
		AnimInstanceMontageSetPos_MontagePos_Offset = NativeReflectionCached.GetPropertyOffset(AnimInstanceMontageSetPos_FunctionAddress, "MontagePos");
		AnimInstanceMontageSetPos_MontagePos_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimInstanceMontageSetPos_FunctionAddress, "MontagePos", Classes.FFloatProperty);
		AnimInstanceMontageSetPos_IsValid = AnimInstanceMontageSetPos_FunctionAddress != IntPtr.Zero && AnimInstanceMontageSetPos_AnimInst_IsValid && AnimInstanceMontageSetPos_MontagePos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AnimInstanceMontageSetPos", AnimInstanceMontageSetPos_IsValid);
		AMCopyNotifies_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AMCopyNotifies");
		AMCopyNotifies_ParamsSize = NativeReflection.GetFunctionParamsSize(AMCopyNotifies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AMCopyNotifies_SourceAnimMontage_PropertyAddress, AMCopyNotifies_FunctionAddress, "SourceAnimMontage");
		AMCopyNotifies_SourceAnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(AMCopyNotifies_FunctionAddress, "SourceAnimMontage");
		AMCopyNotifies_SourceAnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(AMCopyNotifies_FunctionAddress, "SourceAnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AMCopyNotifies_DestAnimMontage_PropertyAddress, AMCopyNotifies_FunctionAddress, "DestAnimMontage");
		AMCopyNotifies_DestAnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(AMCopyNotifies_FunctionAddress, "DestAnimMontage");
		AMCopyNotifies_DestAnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(AMCopyNotifies_FunctionAddress, "DestAnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AMCopyNotifies_bClearNotifiesInDestBeforeCopy_PropertyAddress, AMCopyNotifies_FunctionAddress, "bClearNotifiesInDestBeforeCopy");
		AMCopyNotifies_bClearNotifiesInDestBeforeCopy_Offset = NativeReflectionCached.GetPropertyOffset(AMCopyNotifies_FunctionAddress, "bClearNotifiesInDestBeforeCopy");
		AMCopyNotifies_bClearNotifiesInDestBeforeCopy_IsValid = NativeReflectionCached.ValidatePropertyClass(AMCopyNotifies_FunctionAddress, "bClearNotifiesInDestBeforeCopy", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AMCopyNotifies_bWithErrorInfo_PropertyAddress, AMCopyNotifies_FunctionAddress, "bWithErrorInfo");
		AMCopyNotifies_bWithErrorInfo_Offset = NativeReflectionCached.GetPropertyOffset(AMCopyNotifies_FunctionAddress, "bWithErrorInfo");
		AMCopyNotifies_bWithErrorInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(AMCopyNotifies_FunctionAddress, "bWithErrorInfo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AMCopyNotifies_ReturnValue_PropertyAddress, AMCopyNotifies_FunctionAddress, "ReturnValue");
		AMCopyNotifies_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AMCopyNotifies_FunctionAddress, "ReturnValue");
		AMCopyNotifies_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AMCopyNotifies_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AMCopyNotifies_IsValid = AMCopyNotifies_FunctionAddress != IntPtr.Zero && AMCopyNotifies_SourceAnimMontage_IsValid && AMCopyNotifies_DestAnimMontage_IsValid && AMCopyNotifies_bClearNotifiesInDestBeforeCopy_IsValid && AMCopyNotifies_bWithErrorInfo_IsValid && AMCopyNotifies_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AMCopyNotifies", AMCopyNotifies_IsValid);
		AMCopyBlendOption_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AMCopyBlendOption");
		AMCopyBlendOption_ParamsSize = NativeReflection.GetFunctionParamsSize(AMCopyBlendOption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AMCopyBlendOption_SourceAnimMontage_PropertyAddress, AMCopyBlendOption_FunctionAddress, "SourceAnimMontage");
		AMCopyBlendOption_SourceAnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(AMCopyBlendOption_FunctionAddress, "SourceAnimMontage");
		AMCopyBlendOption_SourceAnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(AMCopyBlendOption_FunctionAddress, "SourceAnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AMCopyBlendOption_DestAnimMontage_PropertyAddress, AMCopyBlendOption_FunctionAddress, "DestAnimMontage");
		AMCopyBlendOption_DestAnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(AMCopyBlendOption_FunctionAddress, "DestAnimMontage");
		AMCopyBlendOption_DestAnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(AMCopyBlendOption_FunctionAddress, "DestAnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AMCopyBlendOption_ReturnValue_PropertyAddress, AMCopyBlendOption_FunctionAddress, "ReturnValue");
		AMCopyBlendOption_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AMCopyBlendOption_FunctionAddress, "ReturnValue");
		AMCopyBlendOption_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AMCopyBlendOption_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AMCopyBlendOption_IsValid = AMCopyBlendOption_FunctionAddress != IntPtr.Zero && AMCopyBlendOption_SourceAnimMontage_IsValid && AMCopyBlendOption_DestAnimMontage_IsValid && AMCopyBlendOption_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AMCopyBlendOption", AMCopyBlendOption_IsValid);
		AddUVChannel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddUVChannel");
		AddUVChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(AddUVChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddUVChannel_StaticMesh_PropertyAddress, AddUVChannel_FunctionAddress, "StaticMesh");
		AddUVChannel_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(AddUVChannel_FunctionAddress, "StaticMesh");
		AddUVChannel_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUVChannel_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUVChannel_LODIndex_PropertyAddress, AddUVChannel_FunctionAddress, "LODIndex");
		AddUVChannel_LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(AddUVChannel_FunctionAddress, "LODIndex");
		AddUVChannel_LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUVChannel_FunctionAddress, "LODIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUVChannel_ReturnValue_PropertyAddress, AddUVChannel_FunctionAddress, "ReturnValue");
		AddUVChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddUVChannel_FunctionAddress, "ReturnValue");
		AddUVChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUVChannel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddUVChannel_IsValid = AddUVChannel_FunctionAddress != IntPtr.Zero && AddUVChannel_StaticMesh_IsValid && AddUVChannel_LODIndex_IsValid && AddUVChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AddUVChannel", AddUVChannel_IsValid);
		AddSocketToSkeleton_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddSocketToSkeleton");
		AddSocketToSkeleton_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSocketToSkeleton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSocketToSkeleton_InUSkeleton_PropertyAddress, AddSocketToSkeleton_FunctionAddress, "InUSkeleton");
		AddSocketToSkeleton_InUSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(AddSocketToSkeleton_FunctionAddress, "InUSkeleton");
		AddSocketToSkeleton_InUSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSocketToSkeleton_FunctionAddress, "InUSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSocketToSkeleton_BoneName_PropertyAddress, AddSocketToSkeleton_FunctionAddress, "BoneName");
		AddSocketToSkeleton_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddSocketToSkeleton_FunctionAddress, "BoneName");
		AddSocketToSkeleton_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSocketToSkeleton_FunctionAddress, "BoneName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSocketToSkeleton_SocketName_PropertyAddress, AddSocketToSkeleton_FunctionAddress, "SocketName");
		AddSocketToSkeleton_SocketName_Offset = NativeReflectionCached.GetPropertyOffset(AddSocketToSkeleton_FunctionAddress, "SocketName");
		AddSocketToSkeleton_SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSocketToSkeleton_FunctionAddress, "SocketName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSocketToSkeleton_Offset_PropertyAddress, AddSocketToSkeleton_FunctionAddress, "Offset");
		AddSocketToSkeleton_Offset_Offset = NativeReflectionCached.GetPropertyOffset(AddSocketToSkeleton_FunctionAddress, "Offset");
		AddSocketToSkeleton_Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSocketToSkeleton_FunctionAddress, "Offset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSocketToSkeleton_ReturnValue_PropertyAddress, AddSocketToSkeleton_FunctionAddress, "ReturnValue");
		AddSocketToSkeleton_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddSocketToSkeleton_FunctionAddress, "ReturnValue");
		AddSocketToSkeleton_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSocketToSkeleton_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddSocketToSkeleton_IsValid = AddSocketToSkeleton_FunctionAddress != IntPtr.Zero && AddSocketToSkeleton_InUSkeleton_IsValid && AddSocketToSkeleton_BoneName_IsValid && AddSocketToSkeleton_SocketName_IsValid && AddSocketToSkeleton_Offset_IsValid && AddSocketToSkeleton_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AddSocketToSkeleton", AddSocketToSkeleton_IsValid);
		AddPreviewAssetToSkeleton_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddPreviewAssetToSkeleton");
		AddPreviewAssetToSkeleton_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPreviewAssetToSkeleton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddPreviewAssetToSkeleton_InUSkeleton_PropertyAddress, AddPreviewAssetToSkeleton_FunctionAddress, "InUSkeleton");
		AddPreviewAssetToSkeleton_InUSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(AddPreviewAssetToSkeleton_FunctionAddress, "InUSkeleton");
		AddPreviewAssetToSkeleton_InUSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPreviewAssetToSkeleton_FunctionAddress, "InUSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPreviewAssetToSkeleton_BoneName_PropertyAddress, AddPreviewAssetToSkeleton_FunctionAddress, "BoneName");
		AddPreviewAssetToSkeleton_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddPreviewAssetToSkeleton_FunctionAddress, "BoneName");
		AddPreviewAssetToSkeleton_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPreviewAssetToSkeleton_FunctionAddress, "BoneName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPreviewAssetToSkeleton_PreviewAsset_PropertyAddress, AddPreviewAssetToSkeleton_FunctionAddress, "PreviewAsset");
		AddPreviewAssetToSkeleton_PreviewAsset_Offset = NativeReflectionCached.GetPropertyOffset(AddPreviewAssetToSkeleton_FunctionAddress, "PreviewAsset");
		AddPreviewAssetToSkeleton_PreviewAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPreviewAssetToSkeleton_FunctionAddress, "PreviewAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPreviewAssetToSkeleton_ReturnValue_PropertyAddress, AddPreviewAssetToSkeleton_FunctionAddress, "ReturnValue");
		AddPreviewAssetToSkeleton_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddPreviewAssetToSkeleton_FunctionAddress, "ReturnValue");
		AddPreviewAssetToSkeleton_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPreviewAssetToSkeleton_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddPreviewAssetToSkeleton_IsValid = AddPreviewAssetToSkeleton_FunctionAddress != IntPtr.Zero && AddPreviewAssetToSkeleton_InUSkeleton_IsValid && AddPreviewAssetToSkeleton_BoneName_IsValid && AddPreviewAssetToSkeleton_PreviewAsset_IsValid && AddPreviewAssetToSkeleton_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AddPreviewAssetToSkeleton", AddPreviewAssetToSkeleton_IsValid);
		AddPoint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddPoint");
		AddPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddPoint_BlendSpace_PropertyAddress, AddPoint_FunctionAddress, "BlendSpace");
		AddPoint_BlendSpace_Offset = NativeReflectionCached.GetPropertyOffset(AddPoint_FunctionAddress, "BlendSpace");
		AddPoint_BlendSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPoint_FunctionAddress, "BlendSpace", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPoint_PointSequence_PropertyAddress, AddPoint_FunctionAddress, "PointSequence");
		AddPoint_PointSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddPoint_FunctionAddress, "PointSequence");
		AddPoint_PointSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPoint_FunctionAddress, "PointSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPoint_PointValue_PropertyAddress, AddPoint_FunctionAddress, "PointValue");
		AddPoint_PointValue_Offset = NativeReflectionCached.GetPropertyOffset(AddPoint_FunctionAddress, "PointValue");
		AddPoint_PointValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPoint_FunctionAddress, "PointValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPoint_ReturnValue_PropertyAddress, AddPoint_FunctionAddress, "ReturnValue");
		AddPoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddPoint_FunctionAddress, "ReturnValue");
		AddPoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPoint_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddPoint_IsValid = AddPoint_FunctionAddress != IntPtr.Zero && AddPoint_BlendSpace_IsValid && AddPoint_PointSequence_IsValid && AddPoint_PointValue_IsValid && AddPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AddPoint", AddPoint_IsValid);
		AddAnimSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAnimSequence");
		AddAnimSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAnimSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAnimSequence_TargetMontage_PropertyAddress, AddAnimSequence_FunctionAddress, "TargetMontage");
		AddAnimSequence_TargetMontage_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimSequence_FunctionAddress, "TargetMontage");
		AddAnimSequence_TargetMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimSequence_FunctionAddress, "TargetMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimSequence_Sequence_PropertyAddress, AddAnimSequence_FunctionAddress, "Sequence");
		AddAnimSequence_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimSequence_FunctionAddress, "Sequence");
		AddAnimSequence_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimSequence_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimSequence_ReturnValue_PropertyAddress, AddAnimSequence_FunctionAddress, "ReturnValue");
		AddAnimSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimSequence_FunctionAddress, "ReturnValue");
		AddAnimSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimSequence_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddAnimSequence_IsValid = AddAnimSequence_FunctionAddress != IntPtr.Zero && AddAnimSequence_TargetMontage_IsValid && AddAnimSequence_Sequence_IsValid && AddAnimSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AddAnimSequence", AddAnimSequence_IsValid);
		AddAnimationNotifyStateEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAnimationNotifyStateEvent");
		AddAnimationNotifyStateEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAnimationNotifyStateEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyStateEvent_AnimBase_PropertyAddress, AddAnimationNotifyStateEvent_FunctionAddress, "AnimBase");
		AddAnimationNotifyStateEvent_AnimBase_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyStateEvent_FunctionAddress, "AnimBase");
		AddAnimationNotifyStateEvent_AnimBase_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyStateEvent_FunctionAddress, "AnimBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyStateEvent_NotifyTrackName_PropertyAddress, AddAnimationNotifyStateEvent_FunctionAddress, "NotifyTrackName");
		AddAnimationNotifyStateEvent_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyStateEvent_FunctionAddress, "NotifyTrackName");
		AddAnimationNotifyStateEvent_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyStateEvent_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyStateEvent_StartTime_PropertyAddress, AddAnimationNotifyStateEvent_FunctionAddress, "StartTime");
		AddAnimationNotifyStateEvent_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyStateEvent_FunctionAddress, "StartTime");
		AddAnimationNotifyStateEvent_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyStateEvent_FunctionAddress, "StartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyStateEvent_Duration_PropertyAddress, AddAnimationNotifyStateEvent_FunctionAddress, "Duration");
		AddAnimationNotifyStateEvent_Duration_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyStateEvent_FunctionAddress, "Duration");
		AddAnimationNotifyStateEvent_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyStateEvent_FunctionAddress, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyStateEvent_NotifyStateClass_PropertyAddress, AddAnimationNotifyStateEvent_FunctionAddress, "NotifyStateClass");
		AddAnimationNotifyStateEvent_NotifyStateClass_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyStateEvent_FunctionAddress, "NotifyStateClass");
		AddAnimationNotifyStateEvent_NotifyStateClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyStateEvent_FunctionAddress, "NotifyStateClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyStateEvent_ReturnValue_PropertyAddress, AddAnimationNotifyStateEvent_FunctionAddress, "ReturnValue");
		AddAnimationNotifyStateEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyStateEvent_FunctionAddress, "ReturnValue");
		AddAnimationNotifyStateEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyStateEvent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddAnimationNotifyStateEvent_IsValid = AddAnimationNotifyStateEvent_FunctionAddress != IntPtr.Zero && AddAnimationNotifyStateEvent_AnimBase_IsValid && AddAnimationNotifyStateEvent_NotifyTrackName_IsValid && AddAnimationNotifyStateEvent_StartTime_IsValid && AddAnimationNotifyStateEvent_Duration_IsValid && AddAnimationNotifyStateEvent_NotifyStateClass_IsValid && AddAnimationNotifyStateEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AddAnimationNotifyStateEvent", AddAnimationNotifyStateEvent_IsValid);
		AddAnimationNotifyEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAnimationNotifyEvent");
		AddAnimationNotifyEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAnimationNotifyEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyEvent_AnimationSequenceBase_PropertyAddress, AddAnimationNotifyEvent_FunctionAddress, "AnimationSequenceBase");
		AddAnimationNotifyEvent_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyEvent_FunctionAddress, "AnimationSequenceBase");
		AddAnimationNotifyEvent_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyEvent_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyEvent_NotifyTrackName_PropertyAddress, AddAnimationNotifyEvent_FunctionAddress, "NotifyTrackName");
		AddAnimationNotifyEvent_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyEvent_FunctionAddress, "NotifyTrackName");
		AddAnimationNotifyEvent_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyEvent_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyEvent_StartTime_PropertyAddress, AddAnimationNotifyEvent_FunctionAddress, "StartTime");
		AddAnimationNotifyEvent_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyEvent_FunctionAddress, "StartTime");
		AddAnimationNotifyEvent_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyEvent_FunctionAddress, "StartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyEvent_NotifyClass_PropertyAddress, AddAnimationNotifyEvent_FunctionAddress, "NotifyClass");
		AddAnimationNotifyEvent_NotifyClass_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyEvent_FunctionAddress, "NotifyClass");
		AddAnimationNotifyEvent_NotifyClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyEvent_FunctionAddress, "NotifyClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyEvent_ReturnValue_PropertyAddress, AddAnimationNotifyEvent_FunctionAddress, "ReturnValue");
		AddAnimationNotifyEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyEvent_FunctionAddress, "ReturnValue");
		AddAnimationNotifyEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyEvent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddAnimationNotifyEvent_IsValid = AddAnimationNotifyEvent_FunctionAddress != IntPtr.Zero && AddAnimationNotifyEvent_AnimationSequenceBase_IsValid && AddAnimationNotifyEvent_NotifyTrackName_IsValid && AddAnimationNotifyEvent_StartTime_IsValid && AddAnimationNotifyEvent_NotifyClass_IsValid && AddAnimationNotifyEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:AddAnimationNotifyEvent", AddAnimationNotifyEvent_IsValid);
		ABPStateMachineGetGlobalWeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ABPStateMachineGetGlobalWeight");
		ABPStateMachineGetGlobalWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(ABPStateMachineGetGlobalWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ABPStateMachineGetGlobalWeight_AnimInst_PropertyAddress, ABPStateMachineGetGlobalWeight_FunctionAddress, "AnimInst");
		ABPStateMachineGetGlobalWeight_AnimInst_Offset = NativeReflectionCached.GetPropertyOffset(ABPStateMachineGetGlobalWeight_FunctionAddress, "AnimInst");
		ABPStateMachineGetGlobalWeight_AnimInst_IsValid = NativeReflectionCached.ValidatePropertyClass(ABPStateMachineGetGlobalWeight_FunctionAddress, "AnimInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ABPStateMachineGetGlobalWeight_StateMachineName_PropertyAddress, ABPStateMachineGetGlobalWeight_FunctionAddress, "StateMachineName");
		ABPStateMachineGetGlobalWeight_StateMachineName_Offset = NativeReflectionCached.GetPropertyOffset(ABPStateMachineGetGlobalWeight_FunctionAddress, "StateMachineName");
		ABPStateMachineGetGlobalWeight_StateMachineName_IsValid = NativeReflectionCached.ValidatePropertyClass(ABPStateMachineGetGlobalWeight_FunctionAddress, "StateMachineName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ABPStateMachineGetGlobalWeight_StateName_PropertyAddress, ABPStateMachineGetGlobalWeight_FunctionAddress, "StateName");
		ABPStateMachineGetGlobalWeight_StateName_Offset = NativeReflectionCached.GetPropertyOffset(ABPStateMachineGetGlobalWeight_FunctionAddress, "StateName");
		ABPStateMachineGetGlobalWeight_StateName_IsValid = NativeReflectionCached.ValidatePropertyClass(ABPStateMachineGetGlobalWeight_FunctionAddress, "StateName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ABPStateMachineGetGlobalWeight_ReturnValue_PropertyAddress, ABPStateMachineGetGlobalWeight_FunctionAddress, "ReturnValue");
		ABPStateMachineGetGlobalWeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ABPStateMachineGetGlobalWeight_FunctionAddress, "ReturnValue");
		ABPStateMachineGetGlobalWeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ABPStateMachineGetGlobalWeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		ABPStateMachineGetGlobalWeight_IsValid = ABPStateMachineGetGlobalWeight_FunctionAddress != IntPtr.Zero && ABPStateMachineGetGlobalWeight_AnimInst_IsValid && ABPStateMachineGetGlobalWeight_StateMachineName_IsValid && ABPStateMachineGetGlobalWeight_StateName_IsValid && ABPStateMachineGetGlobalWeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimFuncLib:ABPStateMachineGetGlobalWeight", ABPStateMachineGetGlobalWeight_IsValid);
	}
}
