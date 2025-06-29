using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AnimGraph;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationBlueprintLibrary;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary", "AnimationBlueprintLibrary", UnrealModuleType.Engine)]
public class UAnimationLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetRootMotionLockType_IsValid;

	private static IntPtr SetRootMotionLockType_FunctionAddress;

	private static int SetRootMotionLockType_ParamsSize;

	private static bool SetRootMotionLockType_AnimationSequence_IsValid;

	private static FFieldAddress SetRootMotionLockType_AnimationSequence_PropertyAddress;

	private static int SetRootMotionLockType_AnimationSequence_Offset;

	private static bool SetRootMotionLockType_RootMotionLockType_IsValid;

	private static FFieldAddress SetRootMotionLockType_RootMotionLockType_PropertyAddress;

	private static int SetRootMotionLockType_RootMotionLockType_Offset;

	private static bool SetRootMotionEnabled_IsValid;

	private static IntPtr SetRootMotionEnabled_FunctionAddress;

	private static int SetRootMotionEnabled_ParamsSize;

	private static bool SetRootMotionEnabled_AnimationSequence_IsValid;

	private static FFieldAddress SetRootMotionEnabled_AnimationSequence_PropertyAddress;

	private static int SetRootMotionEnabled_AnimationSequence_Offset;

	private static bool SetRootMotionEnabled_bEnabled_IsValid;

	private static FFieldAddress SetRootMotionEnabled_bEnabled_PropertyAddress;

	private static int SetRootMotionEnabled_bEnabled_Offset;

	private static bool SetRateScale_IsValid;

	private static IntPtr SetRateScale_FunctionAddress;

	private static int SetRateScale_ParamsSize;

	private static bool SetRateScale_AnimationSequenceBase_IsValid;

	private static FFieldAddress SetRateScale_AnimationSequenceBase_PropertyAddress;

	private static int SetRateScale_AnimationSequenceBase_Offset;

	private static bool SetRateScale_RateScale_IsValid;

	private static FFieldAddress SetRateScale_RateScale_PropertyAddress;

	private static int SetRateScale_RateScale_Offset;

	private static bool SetIsRootMotionLockForced_IsValid;

	private static IntPtr SetIsRootMotionLockForced_FunctionAddress;

	private static int SetIsRootMotionLockForced_ParamsSize;

	private static bool SetIsRootMotionLockForced_AnimationSequence_IsValid;

	private static FFieldAddress SetIsRootMotionLockForced_AnimationSequence_PropertyAddress;

	private static int SetIsRootMotionLockForced_AnimationSequence_Offset;

	private static bool SetIsRootMotionLockForced_bForced_IsValid;

	private static FFieldAddress SetIsRootMotionLockForced_bForced_PropertyAddress;

	private static int SetIsRootMotionLockForced_bForced_Offset;

	private static bool SetCurveCompressionSettings_IsValid;

	private static IntPtr SetCurveCompressionSettings_FunctionAddress;

	private static int SetCurveCompressionSettings_ParamsSize;

	private static bool SetCurveCompressionSettings_AnimationSequence_IsValid;

	private static FFieldAddress SetCurveCompressionSettings_AnimationSequence_PropertyAddress;

	private static int SetCurveCompressionSettings_AnimationSequence_Offset;

	private static bool SetCurveCompressionSettings_CompressionSettings_IsValid;

	private static FFieldAddress SetCurveCompressionSettings_CompressionSettings_PropertyAddress;

	private static int SetCurveCompressionSettings_CompressionSettings_Offset;

	private static bool SetBoneCompressionSettings_IsValid;

	private static IntPtr SetBoneCompressionSettings_FunctionAddress;

	private static int SetBoneCompressionSettings_ParamsSize;

	private static bool SetBoneCompressionSettings_AnimationSequence_IsValid;

	private static FFieldAddress SetBoneCompressionSettings_AnimationSequence_PropertyAddress;

	private static int SetBoneCompressionSettings_AnimationSequence_Offset;

	private static bool SetBoneCompressionSettings_CompressionSettings_IsValid;

	private static FFieldAddress SetBoneCompressionSettings_CompressionSettings_PropertyAddress;

	private static int SetBoneCompressionSettings_CompressionSettings_Offset;

	private static bool SetAnimationInterpolationType_IsValid;

	private static IntPtr SetAnimationInterpolationType_FunctionAddress;

	private static int SetAnimationInterpolationType_ParamsSize;

	private static bool SetAnimationInterpolationType_AnimationSequence_IsValid;

	private static FFieldAddress SetAnimationInterpolationType_AnimationSequence_PropertyAddress;

	private static int SetAnimationInterpolationType_AnimationSequence_Offset;

	private static bool SetAnimationInterpolationType_InterpolationType_IsValid;

	private static FFieldAddress SetAnimationInterpolationType_InterpolationType_PropertyAddress;

	private static int SetAnimationInterpolationType_InterpolationType_Offset;

	private static bool SetAdditiveBasePoseType_IsValid;

	private static IntPtr SetAdditiveBasePoseType_FunctionAddress;

	private static int SetAdditiveBasePoseType_ParamsSize;

	private static bool SetAdditiveBasePoseType_AnimationSequence_IsValid;

	private static FFieldAddress SetAdditiveBasePoseType_AnimationSequence_PropertyAddress;

	private static int SetAdditiveBasePoseType_AnimationSequence_Offset;

	private static bool SetAdditiveBasePoseType_AdditiveBasePoseType_IsValid;

	private static FFieldAddress SetAdditiveBasePoseType_AdditiveBasePoseType_PropertyAddress;

	private static int SetAdditiveBasePoseType_AdditiveBasePoseType_Offset;

	private static bool SetAdditiveAnimationType_IsValid;

	private static IntPtr SetAdditiveAnimationType_FunctionAddress;

	private static int SetAdditiveAnimationType_ParamsSize;

	private static bool SetAdditiveAnimationType_AnimationSequence_IsValid;

	private static FFieldAddress SetAdditiveAnimationType_AnimationSequence_PropertyAddress;

	private static int SetAdditiveAnimationType_AnimationSequence_Offset;

	private static bool SetAdditiveAnimationType_AdditiveAnimationType_IsValid;

	private static FFieldAddress SetAdditiveAnimationType_AdditiveAnimationType_PropertyAddress;

	private static int SetAdditiveAnimationType_AdditiveAnimationType_Offset;

	private static bool ReplaceAnimNotifyStates_IsValid;

	private static IntPtr ReplaceAnimNotifyStates_FunctionAddress;

	private static int ReplaceAnimNotifyStates_ParamsSize;

	private static bool ReplaceAnimNotifyStates_AnimationSequenceBase_IsValid;

	private static FFieldAddress ReplaceAnimNotifyStates_AnimationSequenceBase_PropertyAddress;

	private static int ReplaceAnimNotifyStates_AnimationSequenceBase_Offset;

	private static bool ReplaceAnimNotifyStates_OldNotifyClass_IsValid;

	private static FFieldAddress ReplaceAnimNotifyStates_OldNotifyClass_PropertyAddress;

	private static int ReplaceAnimNotifyStates_OldNotifyClass_Offset;

	private static bool ReplaceAnimNotifyStates_NewNotifyClass_IsValid;

	private static FFieldAddress ReplaceAnimNotifyStates_NewNotifyClass_PropertyAddress;

	private static int ReplaceAnimNotifyStates_NewNotifyClass_Offset;

	private static bool ReplaceAnimNotifyStates_OnNotifyStateReplaced_IsValid;

	private static FFieldAddress ReplaceAnimNotifyStates_OnNotifyStateReplaced_PropertyAddress;

	private static int ReplaceAnimNotifyStates_OnNotifyStateReplaced_Offset;

	private static bool ReplaceAnimNotifies_IsValid;

	private static IntPtr ReplaceAnimNotifies_FunctionAddress;

	private static int ReplaceAnimNotifies_ParamsSize;

	private static bool ReplaceAnimNotifies_AnimationSequenceBase_IsValid;

	private static FFieldAddress ReplaceAnimNotifies_AnimationSequenceBase_PropertyAddress;

	private static int ReplaceAnimNotifies_AnimationSequenceBase_Offset;

	private static bool ReplaceAnimNotifies_OldNotifyClass_IsValid;

	private static FFieldAddress ReplaceAnimNotifies_OldNotifyClass_PropertyAddress;

	private static int ReplaceAnimNotifies_OldNotifyClass_Offset;

	private static bool ReplaceAnimNotifies_NewNotifyClass_IsValid;

	private static FFieldAddress ReplaceAnimNotifies_NewNotifyClass_PropertyAddress;

	private static int ReplaceAnimNotifies_NewNotifyClass_Offset;

	private static bool ReplaceAnimNotifies_OnNotifyReplaced_IsValid;

	private static FFieldAddress ReplaceAnimNotifies_OnNotifyReplaced_PropertyAddress;

	private static int ReplaceAnimNotifies_OnNotifyReplaced_Offset;

	private static bool RemoveVirtualBones_IsValid;

	private static IntPtr RemoveVirtualBones_FunctionAddress;

	private static int RemoveVirtualBones_ParamsSize;

	private static bool RemoveVirtualBones_AnimationSequence_IsValid;

	private static FFieldAddress RemoveVirtualBones_AnimationSequence_PropertyAddress;

	private static int RemoveVirtualBones_AnimationSequence_Offset;

	private static bool RemoveVirtualBones_VirtualBoneNames_IsValid;

	private static FFieldAddress RemoveVirtualBones_VirtualBoneNames_PropertyAddress;

	private static int RemoveVirtualBones_VirtualBoneNames_Offset;

	private static bool RemoveVirtualBone_IsValid;

	private static IntPtr RemoveVirtualBone_FunctionAddress;

	private static int RemoveVirtualBone_ParamsSize;

	private static bool RemoveVirtualBone_AnimationSequence_IsValid;

	private static FFieldAddress RemoveVirtualBone_AnimationSequence_PropertyAddress;

	private static int RemoveVirtualBone_AnimationSequence_Offset;

	private static bool RemoveVirtualBone_VirtualBoneName_IsValid;

	private static FFieldAddress RemoveVirtualBone_VirtualBoneName_PropertyAddress;

	private static int RemoveVirtualBone_VirtualBoneName_Offset;

	private static bool RemoveMetaDataOfClass_IsValid;

	private static IntPtr RemoveMetaDataOfClass_FunctionAddress;

	private static int RemoveMetaDataOfClass_ParamsSize;

	private static bool RemoveMetaDataOfClass_AnimationAsset_IsValid;

	private static FFieldAddress RemoveMetaDataOfClass_AnimationAsset_PropertyAddress;

	private static int RemoveMetaDataOfClass_AnimationAsset_Offset;

	private static bool RemoveMetaDataOfClass_MetaDataClass_IsValid;

	private static FFieldAddress RemoveMetaDataOfClass_MetaDataClass_PropertyAddress;

	private static int RemoveMetaDataOfClass_MetaDataClass_Offset;

	private static bool RemoveMetaData_IsValid;

	private static IntPtr RemoveMetaData_FunctionAddress;

	private static int RemoveMetaData_ParamsSize;

	private static bool RemoveMetaData_AnimationAsset_IsValid;

	private static FFieldAddress RemoveMetaData_AnimationAsset_PropertyAddress;

	private static int RemoveMetaData_AnimationAsset_Offset;

	private static bool RemoveMetaData_MetaDataObject_IsValid;

	private static FFieldAddress RemoveMetaData_MetaDataObject_PropertyAddress;

	private static int RemoveMetaData_MetaDataObject_Offset;

	private static bool RemoveCurve_IsValid;

	private static IntPtr RemoveCurve_FunctionAddress;

	private static int RemoveCurve_ParamsSize;

	private static bool RemoveCurve_AnimationSequence_IsValid;

	private static FFieldAddress RemoveCurve_AnimationSequence_PropertyAddress;

	private static int RemoveCurve_AnimationSequence_Offset;

	private static bool RemoveCurve_CurveName_IsValid;

	private static FFieldAddress RemoveCurve_CurveName_PropertyAddress;

	private static int RemoveCurve_CurveName_Offset;

	private static bool RemoveCurve_bRemoveNameFromSkeleton_IsValid;

	private static FFieldAddress RemoveCurve_bRemoveNameFromSkeleton_PropertyAddress;

	private static int RemoveCurve_bRemoveNameFromSkeleton_Offset;

	private static bool RemoveBoneAnimation_IsValid;

	private static IntPtr RemoveBoneAnimation_FunctionAddress;

	private static int RemoveBoneAnimation_ParamsSize;

	private static bool RemoveBoneAnimation_AnimationSequence_IsValid;

	private static FFieldAddress RemoveBoneAnimation_AnimationSequence_PropertyAddress;

	private static int RemoveBoneAnimation_AnimationSequence_Offset;

	private static bool RemoveBoneAnimation_BoneName_IsValid;

	private static FFieldAddress RemoveBoneAnimation_BoneName_PropertyAddress;

	private static int RemoveBoneAnimation_BoneName_Offset;

	private static bool RemoveBoneAnimation_bIncludeChildren_IsValid;

	private static FFieldAddress RemoveBoneAnimation_bIncludeChildren_PropertyAddress;

	private static int RemoveBoneAnimation_bIncludeChildren_Offset;

	private static bool RemoveBoneAnimation_bFinalize_IsValid;

	private static FFieldAddress RemoveBoneAnimation_bFinalize_PropertyAddress;

	private static int RemoveBoneAnimation_bFinalize_Offset;

	private static bool RemoveAnimationSyncMarkersByTrack_IsValid;

	private static IntPtr RemoveAnimationSyncMarkersByTrack_FunctionAddress;

	private static int RemoveAnimationSyncMarkersByTrack_ParamsSize;

	private static bool RemoveAnimationSyncMarkersByTrack_AnimationSequence_IsValid;

	private static FFieldAddress RemoveAnimationSyncMarkersByTrack_AnimationSequence_PropertyAddress;

	private static int RemoveAnimationSyncMarkersByTrack_AnimationSequence_Offset;

	private static bool RemoveAnimationSyncMarkersByTrack_NotifyTrackName_IsValid;

	private static FFieldAddress RemoveAnimationSyncMarkersByTrack_NotifyTrackName_PropertyAddress;

	private static int RemoveAnimationSyncMarkersByTrack_NotifyTrackName_Offset;

	private static bool RemoveAnimationSyncMarkersByTrack_ReturnValue_IsValid;

	private static FFieldAddress RemoveAnimationSyncMarkersByTrack_ReturnValue_PropertyAddress;

	private static int RemoveAnimationSyncMarkersByTrack_ReturnValue_Offset;

	private static bool RemoveAnimationSyncMarkersByName_IsValid;

	private static IntPtr RemoveAnimationSyncMarkersByName_FunctionAddress;

	private static int RemoveAnimationSyncMarkersByName_ParamsSize;

	private static bool RemoveAnimationSyncMarkersByName_AnimationSequence_IsValid;

	private static FFieldAddress RemoveAnimationSyncMarkersByName_AnimationSequence_PropertyAddress;

	private static int RemoveAnimationSyncMarkersByName_AnimationSequence_Offset;

	private static bool RemoveAnimationSyncMarkersByName_MarkerName_IsValid;

	private static FFieldAddress RemoveAnimationSyncMarkersByName_MarkerName_PropertyAddress;

	private static int RemoveAnimationSyncMarkersByName_MarkerName_Offset;

	private static bool RemoveAnimationSyncMarkersByName_ReturnValue_IsValid;

	private static FFieldAddress RemoveAnimationSyncMarkersByName_ReturnValue_PropertyAddress;

	private static int RemoveAnimationSyncMarkersByName_ReturnValue_Offset;

	private static bool RemoveAnimationNotifyTrack_IsValid;

	private static IntPtr RemoveAnimationNotifyTrack_FunctionAddress;

	private static int RemoveAnimationNotifyTrack_ParamsSize;

	private static bool RemoveAnimationNotifyTrack_AnimationSequenceBase_IsValid;

	private static FFieldAddress RemoveAnimationNotifyTrack_AnimationSequenceBase_PropertyAddress;

	private static int RemoveAnimationNotifyTrack_AnimationSequenceBase_Offset;

	private static bool RemoveAnimationNotifyTrack_NotifyTrackName_IsValid;

	private static FFieldAddress RemoveAnimationNotifyTrack_NotifyTrackName_PropertyAddress;

	private static int RemoveAnimationNotifyTrack_NotifyTrackName_Offset;

	private static bool RemoveAnimationNotifyEventsByTrack_IsValid;

	private static IntPtr RemoveAnimationNotifyEventsByTrack_FunctionAddress;

	private static int RemoveAnimationNotifyEventsByTrack_ParamsSize;

	private static bool RemoveAnimationNotifyEventsByTrack_AnimationSequenceBase_IsValid;

	private static FFieldAddress RemoveAnimationNotifyEventsByTrack_AnimationSequenceBase_PropertyAddress;

	private static int RemoveAnimationNotifyEventsByTrack_AnimationSequenceBase_Offset;

	private static bool RemoveAnimationNotifyEventsByTrack_NotifyTrackName_IsValid;

	private static FFieldAddress RemoveAnimationNotifyEventsByTrack_NotifyTrackName_PropertyAddress;

	private static int RemoveAnimationNotifyEventsByTrack_NotifyTrackName_Offset;

	private static bool RemoveAnimationNotifyEventsByTrack_ReturnValue_IsValid;

	private static FFieldAddress RemoveAnimationNotifyEventsByTrack_ReturnValue_PropertyAddress;

	private static int RemoveAnimationNotifyEventsByTrack_ReturnValue_Offset;

	private static bool RemoveAnimationNotifyEventsByName_IsValid;

	private static IntPtr RemoveAnimationNotifyEventsByName_FunctionAddress;

	private static int RemoveAnimationNotifyEventsByName_ParamsSize;

	private static bool RemoveAnimationNotifyEventsByName_AnimationSequenceBase_IsValid;

	private static FFieldAddress RemoveAnimationNotifyEventsByName_AnimationSequenceBase_PropertyAddress;

	private static int RemoveAnimationNotifyEventsByName_AnimationSequenceBase_Offset;

	private static bool RemoveAnimationNotifyEventsByName_NotifyName_IsValid;

	private static FFieldAddress RemoveAnimationNotifyEventsByName_NotifyName_PropertyAddress;

	private static int RemoveAnimationNotifyEventsByName_NotifyName_Offset;

	private static bool RemoveAnimationNotifyEventsByName_ReturnValue_IsValid;

	private static FFieldAddress RemoveAnimationNotifyEventsByName_ReturnValue_PropertyAddress;

	private static int RemoveAnimationNotifyEventsByName_ReturnValue_Offset;

	private static bool RemoveAllVirtualBones_IsValid;

	private static IntPtr RemoveAllVirtualBones_FunctionAddress;

	private static int RemoveAllVirtualBones_ParamsSize;

	private static bool RemoveAllVirtualBones_AnimationSequence_IsValid;

	private static FFieldAddress RemoveAllVirtualBones_AnimationSequence_PropertyAddress;

	private static int RemoveAllVirtualBones_AnimationSequence_Offset;

	private static bool RemoveAllMetaData_IsValid;

	private static IntPtr RemoveAllMetaData_FunctionAddress;

	private static int RemoveAllMetaData_ParamsSize;

	private static bool RemoveAllMetaData_AnimationAsset_IsValid;

	private static FFieldAddress RemoveAllMetaData_AnimationAsset_PropertyAddress;

	private static int RemoveAllMetaData_AnimationAsset_Offset;

	private static bool RemoveAllCurveData_IsValid;

	private static IntPtr RemoveAllCurveData_FunctionAddress;

	private static int RemoveAllCurveData_ParamsSize;

	private static bool RemoveAllCurveData_AnimationSequence_IsValid;

	private static FFieldAddress RemoveAllCurveData_AnimationSequence_PropertyAddress;

	private static int RemoveAllCurveData_AnimationSequence_Offset;

	private static bool RemoveAllBoneAnimation_IsValid;

	private static IntPtr RemoveAllBoneAnimation_FunctionAddress;

	private static int RemoveAllBoneAnimation_ParamsSize;

	private static bool RemoveAllBoneAnimation_AnimationSequence_IsValid;

	private static FFieldAddress RemoveAllBoneAnimation_AnimationSequence_PropertyAddress;

	private static int RemoveAllBoneAnimation_AnimationSequence_Offset;

	private static bool RemoveAllAnimationSyncMarkers_IsValid;

	private static IntPtr RemoveAllAnimationSyncMarkers_FunctionAddress;

	private static int RemoveAllAnimationSyncMarkers_ParamsSize;

	private static bool RemoveAllAnimationSyncMarkers_AnimationSequence_IsValid;

	private static FFieldAddress RemoveAllAnimationSyncMarkers_AnimationSequence_PropertyAddress;

	private static int RemoveAllAnimationSyncMarkers_AnimationSequence_Offset;

	private static bool RemoveAllAnimationNotifyTracks_IsValid;

	private static IntPtr RemoveAllAnimationNotifyTracks_FunctionAddress;

	private static int RemoveAllAnimationNotifyTracks_ParamsSize;

	private static bool RemoveAllAnimationNotifyTracks_AnimationSequenceBase_IsValid;

	private static FFieldAddress RemoveAllAnimationNotifyTracks_AnimationSequenceBase_PropertyAddress;

	private static int RemoveAllAnimationNotifyTracks_AnimationSequenceBase_Offset;

	private static bool IsValidTime_IsValid;

	private static IntPtr IsValidTime_FunctionAddress;

	private static int IsValidTime_ParamsSize;

	private static bool IsValidTime_AnimationSequenceBase_IsValid;

	private static FFieldAddress IsValidTime_AnimationSequenceBase_PropertyAddress;

	private static int IsValidTime_AnimationSequenceBase_Offset;

	private static bool IsValidTime_Time_IsValid;

	private static FFieldAddress IsValidTime_Time_PropertyAddress;

	private static int IsValidTime_Time_Offset;

	private static bool IsValidTime_IsValid_IsValid;

	private static FFieldAddress IsValidTime_IsValid_PropertyAddress;

	private static int IsValidTime_IsValid_Offset;

	private static bool IsValidRawAnimationTrackName_IsValid;

	private static IntPtr IsValidRawAnimationTrackName_FunctionAddress;

	private static int IsValidRawAnimationTrackName_ParamsSize;

	private static bool IsValidRawAnimationTrackName_AnimationSequenceBase_IsValid;

	private static FFieldAddress IsValidRawAnimationTrackName_AnimationSequenceBase_PropertyAddress;

	private static int IsValidRawAnimationTrackName_AnimationSequenceBase_Offset;

	private static bool IsValidRawAnimationTrackName_TrackName_IsValid;

	private static FFieldAddress IsValidRawAnimationTrackName_TrackName_PropertyAddress;

	private static int IsValidRawAnimationTrackName_TrackName_Offset;

	private static bool IsValidRawAnimationTrackName_ReturnValue_IsValid;

	private static FFieldAddress IsValidRawAnimationTrackName_ReturnValue_PropertyAddress;

	private static int IsValidRawAnimationTrackName_ReturnValue_Offset;

	private static bool IsValidAnimNotifyTrackName_IsValid;

	private static IntPtr IsValidAnimNotifyTrackName_FunctionAddress;

	private static int IsValidAnimNotifyTrackName_ParamsSize;

	private static bool IsValidAnimNotifyTrackName_AnimationSequenceBase_IsValid;

	private static FFieldAddress IsValidAnimNotifyTrackName_AnimationSequenceBase_PropertyAddress;

	private static int IsValidAnimNotifyTrackName_AnimationSequenceBase_Offset;

	private static bool IsValidAnimNotifyTrackName_NotifyTrackName_IsValid;

	private static FFieldAddress IsValidAnimNotifyTrackName_NotifyTrackName_PropertyAddress;

	private static int IsValidAnimNotifyTrackName_NotifyTrackName_Offset;

	private static bool IsValidAnimNotifyTrackName_ReturnValue_IsValid;

	private static FFieldAddress IsValidAnimNotifyTrackName_ReturnValue_PropertyAddress;

	private static int IsValidAnimNotifyTrackName_ReturnValue_Offset;

	private static bool IsValidAnimationSyncMarkerName_IsValid;

	private static IntPtr IsValidAnimationSyncMarkerName_FunctionAddress;

	private static int IsValidAnimationSyncMarkerName_ParamsSize;

	private static bool IsValidAnimationSyncMarkerName_AnimationSequence_IsValid;

	private static FFieldAddress IsValidAnimationSyncMarkerName_AnimationSequence_PropertyAddress;

	private static int IsValidAnimationSyncMarkerName_AnimationSequence_Offset;

	private static bool IsValidAnimationSyncMarkerName_MarkerName_IsValid;

	private static FFieldAddress IsValidAnimationSyncMarkerName_MarkerName_PropertyAddress;

	private static int IsValidAnimationSyncMarkerName_MarkerName_Offset;

	private static bool IsValidAnimationSyncMarkerName_ReturnValue_IsValid;

	private static FFieldAddress IsValidAnimationSyncMarkerName_ReturnValue_PropertyAddress;

	private static int IsValidAnimationSyncMarkerName_ReturnValue_Offset;

	private static bool IsRootMotionLockForced_IsValid;

	private static IntPtr IsRootMotionLockForced_FunctionAddress;

	private static int IsRootMotionLockForced_ParamsSize;

	private static bool IsRootMotionLockForced_AnimationSequence_IsValid;

	private static FFieldAddress IsRootMotionLockForced_AnimationSequence_PropertyAddress;

	private static int IsRootMotionLockForced_AnimationSequence_Offset;

	private static bool IsRootMotionLockForced_ReturnValue_IsValid;

	private static FFieldAddress IsRootMotionLockForced_ReturnValue_PropertyAddress;

	private static int IsRootMotionLockForced_ReturnValue_Offset;

	private static bool IsRootMotionEnabled_IsValid;

	private static IntPtr IsRootMotionEnabled_FunctionAddress;

	private static int IsRootMotionEnabled_ParamsSize;

	private static bool IsRootMotionEnabled_AnimationSequence_IsValid;

	private static FFieldAddress IsRootMotionEnabled_AnimationSequence_PropertyAddress;

	private static int IsRootMotionEnabled_AnimationSequence_Offset;

	private static bool IsRootMotionEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsRootMotionEnabled_ReturnValue_PropertyAddress;

	private static int IsRootMotionEnabled_ReturnValue_Offset;

	private static bool GetVectorKeys_IsValid;

	private static IntPtr GetVectorKeys_FunctionAddress;

	private static int GetVectorKeys_ParamsSize;

	private static bool GetVectorKeys_AnimationSequence_IsValid;

	private static FFieldAddress GetVectorKeys_AnimationSequence_PropertyAddress;

	private static int GetVectorKeys_AnimationSequence_Offset;

	private static bool GetVectorKeys_CurveName_IsValid;

	private static FFieldAddress GetVectorKeys_CurveName_PropertyAddress;

	private static int GetVectorKeys_CurveName_Offset;

	private static bool GetVectorKeys_Times_IsValid;

	private static FFieldAddress GetVectorKeys_Times_PropertyAddress;

	private static int GetVectorKeys_Times_Offset;

	private static bool GetVectorKeys_Values_IsValid;

	private static FFieldAddress GetVectorKeys_Values_PropertyAddress;

	private static int GetVectorKeys_Values_Offset;

	private static bool GetUniqueMarkerNames_IsValid;

	private static IntPtr GetUniqueMarkerNames_FunctionAddress;

	private static int GetUniqueMarkerNames_ParamsSize;

	private static bool GetUniqueMarkerNames_AnimationSequence_IsValid;

	private static FFieldAddress GetUniqueMarkerNames_AnimationSequence_PropertyAddress;

	private static int GetUniqueMarkerNames_AnimationSequence_Offset;

	private static bool GetUniqueMarkerNames_MarkerNames_IsValid;

	private static FFieldAddress GetUniqueMarkerNames_MarkerNames_PropertyAddress;

	private static int GetUniqueMarkerNames_MarkerNames_Offset;

	private static bool GetTransformationKeys_IsValid;

	private static IntPtr GetTransformationKeys_FunctionAddress;

	private static int GetTransformationKeys_ParamsSize;

	private static bool GetTransformationKeys_AnimationSequence_IsValid;

	private static FFieldAddress GetTransformationKeys_AnimationSequence_PropertyAddress;

	private static int GetTransformationKeys_AnimationSequence_Offset;

	private static bool GetTransformationKeys_CurveName_IsValid;

	private static FFieldAddress GetTransformationKeys_CurveName_PropertyAddress;

	private static int GetTransformationKeys_CurveName_Offset;

	private static bool GetTransformationKeys_Times_IsValid;

	private static FFieldAddress GetTransformationKeys_Times_PropertyAddress;

	private static int GetTransformationKeys_Times_Offset;

	private static bool GetTransformationKeys_Values_IsValid;

	private static FFieldAddress GetTransformationKeys_Values_PropertyAddress;

	private static int GetTransformationKeys_Values_Offset;

	private static bool GetTimeAtFrame_IsValid;

	private static IntPtr GetTimeAtFrame_FunctionAddress;

	private static int GetTimeAtFrame_ParamsSize;

	private static bool GetTimeAtFrame_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetTimeAtFrame_AnimationSequenceBase_PropertyAddress;

	private static int GetTimeAtFrame_AnimationSequenceBase_Offset;

	private static bool GetTimeAtFrame_Frame_IsValid;

	private static FFieldAddress GetTimeAtFrame_Frame_PropertyAddress;

	private static int GetTimeAtFrame_Frame_Offset;

	private static bool GetTimeAtFrame_Time_IsValid;

	private static FFieldAddress GetTimeAtFrame_Time_PropertyAddress;

	private static int GetTimeAtFrame_Time_Offset;

	private static bool GetSequenceLength_IsValid;

	private static IntPtr GetSequenceLength_FunctionAddress;

	private static int GetSequenceLength_ParamsSize;

	private static bool GetSequenceLength_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetSequenceLength_AnimationSequenceBase_PropertyAddress;

	private static int GetSequenceLength_AnimationSequenceBase_Offset;

	private static bool GetSequenceLength_Length_IsValid;

	private static FFieldAddress GetSequenceLength_Length_PropertyAddress;

	private static int GetSequenceLength_Length_Offset;

	private static bool GetRootMotionLockType_IsValid;

	private static IntPtr GetRootMotionLockType_FunctionAddress;

	private static int GetRootMotionLockType_ParamsSize;

	private static bool GetRootMotionLockType_AnimationSequence_IsValid;

	private static FFieldAddress GetRootMotionLockType_AnimationSequence_PropertyAddress;

	private static int GetRootMotionLockType_AnimationSequence_Offset;

	private static bool GetRootMotionLockType_LockType_IsValid;

	private static FFieldAddress GetRootMotionLockType_LockType_PropertyAddress;

	private static int GetRootMotionLockType_LockType_Offset;

	private static bool GetRawTrackScaleData_IsValid;

	private static IntPtr GetRawTrackScaleData_FunctionAddress;

	private static int GetRawTrackScaleData_ParamsSize;

	private static bool GetRawTrackScaleData_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetRawTrackScaleData_AnimationSequenceBase_PropertyAddress;

	private static int GetRawTrackScaleData_AnimationSequenceBase_Offset;

	private static bool GetRawTrackScaleData_TrackName_IsValid;

	private static FFieldAddress GetRawTrackScaleData_TrackName_PropertyAddress;

	private static int GetRawTrackScaleData_TrackName_Offset;

	private static bool GetRawTrackScaleData_ScaleData_IsValid;

	private static FFieldAddress GetRawTrackScaleData_ScaleData_PropertyAddress;

	private static int GetRawTrackScaleData_ScaleData_Offset;

	private static bool GetRawTrackRotationData_IsValid;

	private static IntPtr GetRawTrackRotationData_FunctionAddress;

	private static int GetRawTrackRotationData_ParamsSize;

	private static bool GetRawTrackRotationData_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetRawTrackRotationData_AnimationSequenceBase_PropertyAddress;

	private static int GetRawTrackRotationData_AnimationSequenceBase_Offset;

	private static bool GetRawTrackRotationData_TrackName_IsValid;

	private static FFieldAddress GetRawTrackRotationData_TrackName_PropertyAddress;

	private static int GetRawTrackRotationData_TrackName_Offset;

	private static bool GetRawTrackRotationData_RotationData_IsValid;

	private static FFieldAddress GetRawTrackRotationData_RotationData_PropertyAddress;

	private static int GetRawTrackRotationData_RotationData_Offset;

	private static bool GetRawTrackPositionData_IsValid;

	private static IntPtr GetRawTrackPositionData_FunctionAddress;

	private static int GetRawTrackPositionData_ParamsSize;

	private static bool GetRawTrackPositionData_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetRawTrackPositionData_AnimationSequenceBase_PropertyAddress;

	private static int GetRawTrackPositionData_AnimationSequenceBase_Offset;

	private static bool GetRawTrackPositionData_TrackName_IsValid;

	private static FFieldAddress GetRawTrackPositionData_TrackName_PropertyAddress;

	private static int GetRawTrackPositionData_TrackName_Offset;

	private static bool GetRawTrackPositionData_PositionData_IsValid;

	private static FFieldAddress GetRawTrackPositionData_PositionData_PropertyAddress;

	private static int GetRawTrackPositionData_PositionData_Offset;

	private static bool GetRawTrackData_IsValid;

	private static IntPtr GetRawTrackData_FunctionAddress;

	private static int GetRawTrackData_ParamsSize;

	private static bool GetRawTrackData_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetRawTrackData_AnimationSequenceBase_PropertyAddress;

	private static int GetRawTrackData_AnimationSequenceBase_Offset;

	private static bool GetRawTrackData_TrackName_IsValid;

	private static FFieldAddress GetRawTrackData_TrackName_PropertyAddress;

	private static int GetRawTrackData_TrackName_Offset;

	private static bool GetRawTrackData_PositionKeys_IsValid;

	private static FFieldAddress GetRawTrackData_PositionKeys_PropertyAddress;

	private static int GetRawTrackData_PositionKeys_Offset;

	private static bool GetRawTrackData_RotationKeys_IsValid;

	private static FFieldAddress GetRawTrackData_RotationKeys_PropertyAddress;

	private static int GetRawTrackData_RotationKeys_Offset;

	private static bool GetRawTrackData_ScalingKeys_IsValid;

	private static FFieldAddress GetRawTrackData_ScalingKeys_PropertyAddress;

	private static int GetRawTrackData_ScalingKeys_Offset;

	private static bool GetRateScale_IsValid;

	private static IntPtr GetRateScale_FunctionAddress;

	private static int GetRateScale_ParamsSize;

	private static bool GetRateScale_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetRateScale_AnimationSequenceBase_PropertyAddress;

	private static int GetRateScale_AnimationSequenceBase_Offset;

	private static bool GetRateScale_RateScale_IsValid;

	private static FFieldAddress GetRateScale_RateScale_PropertyAddress;

	private static int GetRateScale_RateScale_Offset;

	private static bool GetNumKeys_IsValid;

	private static IntPtr GetNumKeys_FunctionAddress;

	private static int GetNumKeys_ParamsSize;

	private static bool GetNumKeys_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetNumKeys_AnimationSequenceBase_PropertyAddress;

	private static int GetNumKeys_AnimationSequenceBase_Offset;

	private static bool GetNumKeys_NumKeys_IsValid;

	private static FFieldAddress GetNumKeys_NumKeys_PropertyAddress;

	private static int GetNumKeys_NumKeys_Offset;

	private static bool GetNumFrames_IsValid;

	private static IntPtr GetNumFrames_FunctionAddress;

	private static int GetNumFrames_ParamsSize;

	private static bool GetNumFrames_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetNumFrames_AnimationSequenceBase_PropertyAddress;

	private static int GetNumFrames_AnimationSequenceBase_Offset;

	private static bool GetNumFrames_NumFrames_IsValid;

	private static FFieldAddress GetNumFrames_NumFrames_PropertyAddress;

	private static int GetNumFrames_NumFrames_Offset;

	private static bool GetNodesOfClass_IsValid;

	private static IntPtr GetNodesOfClass_FunctionAddress;

	private static int GetNodesOfClass_ParamsSize;

	private static bool GetNodesOfClass_AnimationBlueprint_IsValid;

	private static FFieldAddress GetNodesOfClass_AnimationBlueprint_PropertyAddress;

	private static int GetNodesOfClass_AnimationBlueprint_Offset;

	private static bool GetNodesOfClass_NodeClass_IsValid;

	private static FFieldAddress GetNodesOfClass_NodeClass_PropertyAddress;

	private static int GetNodesOfClass_NodeClass_Offset;

	private static bool GetNodesOfClass_GraphNodes_IsValid;

	private static FFieldAddress GetNodesOfClass_GraphNodes_PropertyAddress;

	private static int GetNodesOfClass_GraphNodes_Offset;

	private static bool GetNodesOfClass_bIncludeChildClasses_IsValid;

	private static FFieldAddress GetNodesOfClass_bIncludeChildClasses_PropertyAddress;

	private static int GetNodesOfClass_bIncludeChildClasses_Offset;

	private static bool GetMetaDataOfClass_IsValid;

	private static IntPtr GetMetaDataOfClass_FunctionAddress;

	private static int GetMetaDataOfClass_ParamsSize;

	private static bool GetMetaDataOfClass_AnimationAsset_IsValid;

	private static FFieldAddress GetMetaDataOfClass_AnimationAsset_PropertyAddress;

	private static int GetMetaDataOfClass_AnimationAsset_Offset;

	private static bool GetMetaDataOfClass_MetaDataClass_IsValid;

	private static FFieldAddress GetMetaDataOfClass_MetaDataClass_PropertyAddress;

	private static int GetMetaDataOfClass_MetaDataClass_Offset;

	private static bool GetMetaDataOfClass_MetaDataOfClass_IsValid;

	private static FFieldAddress GetMetaDataOfClass_MetaDataOfClass_PropertyAddress;

	private static int GetMetaDataOfClass_MetaDataOfClass_Offset;

	private static bool GetMetaData_IsValid;

	private static IntPtr GetMetaData_FunctionAddress;

	private static int GetMetaData_ParamsSize;

	private static bool GetMetaData_AnimationAsset_IsValid;

	private static FFieldAddress GetMetaData_AnimationAsset_PropertyAddress;

	private static int GetMetaData_AnimationAsset_Offset;

	private static bool GetMetaData_MetaData_IsValid;

	private static FFieldAddress GetMetaData_MetaData_PropertyAddress;

	private static int GetMetaData_MetaData_Offset;

	private static bool GetFrameAtTime_IsValid;

	private static IntPtr GetFrameAtTime_FunctionAddress;

	private static int GetFrameAtTime_ParamsSize;

	private static bool GetFrameAtTime_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetFrameAtTime_AnimationSequenceBase_PropertyAddress;

	private static int GetFrameAtTime_AnimationSequenceBase_Offset;

	private static bool GetFrameAtTime_Time_IsValid;

	private static FFieldAddress GetFrameAtTime_Time_PropertyAddress;

	private static int GetFrameAtTime_Time_Offset;

	private static bool GetFrameAtTime_Frame_IsValid;

	private static FFieldAddress GetFrameAtTime_Frame_PropertyAddress;

	private static int GetFrameAtTime_Frame_Offset;

	private static bool GetFloatKeys_IsValid;

	private static IntPtr GetFloatKeys_FunctionAddress;

	private static int GetFloatKeys_ParamsSize;

	private static bool GetFloatKeys_AnimationSequence_IsValid;

	private static FFieldAddress GetFloatKeys_AnimationSequence_PropertyAddress;

	private static int GetFloatKeys_AnimationSequence_Offset;

	private static bool GetFloatKeys_CurveName_IsValid;

	private static FFieldAddress GetFloatKeys_CurveName_PropertyAddress;

	private static int GetFloatKeys_CurveName_Offset;

	private static bool GetFloatKeys_Times_IsValid;

	private static FFieldAddress GetFloatKeys_Times_PropertyAddress;

	private static int GetFloatKeys_Times_Offset;

	private static bool GetFloatKeys_Values_IsValid;

	private static FFieldAddress GetFloatKeys_Values_PropertyAddress;

	private static int GetFloatKeys_Values_Offset;

	private static bool GetCurveCompressionSettings_IsValid;

	private static IntPtr GetCurveCompressionSettings_FunctionAddress;

	private static int GetCurveCompressionSettings_ParamsSize;

	private static bool GetCurveCompressionSettings_AnimationSequence_IsValid;

	private static FFieldAddress GetCurveCompressionSettings_AnimationSequence_PropertyAddress;

	private static int GetCurveCompressionSettings_AnimationSequence_Offset;

	private static bool GetCurveCompressionSettings_CompressionSettings_IsValid;

	private static FFieldAddress GetCurveCompressionSettings_CompressionSettings_PropertyAddress;

	private static int GetCurveCompressionSettings_CompressionSettings_Offset;

	private static bool GetBonePosesForTime_IsValid;

	private static IntPtr GetBonePosesForTime_FunctionAddress;

	private static int GetBonePosesForTime_ParamsSize;

	private static bool GetBonePosesForTime_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetBonePosesForTime_AnimationSequenceBase_PropertyAddress;

	private static int GetBonePosesForTime_AnimationSequenceBase_Offset;

	private static bool GetBonePosesForTime_BoneNames_IsValid;

	private static FFieldAddress GetBonePosesForTime_BoneNames_PropertyAddress;

	private static int GetBonePosesForTime_BoneNames_Offset;

	private static bool GetBonePosesForTime_Time_IsValid;

	private static FFieldAddress GetBonePosesForTime_Time_PropertyAddress;

	private static int GetBonePosesForTime_Time_Offset;

	private static bool GetBonePosesForTime_bExtractRootMotion_IsValid;

	private static FFieldAddress GetBonePosesForTime_bExtractRootMotion_PropertyAddress;

	private static int GetBonePosesForTime_bExtractRootMotion_Offset;

	private static bool GetBonePosesForTime_Poses_IsValid;

	private static FFieldAddress GetBonePosesForTime_Poses_PropertyAddress;

	private static int GetBonePosesForTime_Poses_Offset;

	private static bool GetBonePosesForTime_PreviewMesh_IsValid;

	private static FFieldAddress GetBonePosesForTime_PreviewMesh_PropertyAddress;

	private static int GetBonePosesForTime_PreviewMesh_Offset;

	private static bool GetBonePosesForFrame_IsValid;

	private static IntPtr GetBonePosesForFrame_FunctionAddress;

	private static int GetBonePosesForFrame_ParamsSize;

	private static bool GetBonePosesForFrame_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetBonePosesForFrame_AnimationSequenceBase_PropertyAddress;

	private static int GetBonePosesForFrame_AnimationSequenceBase_Offset;

	private static bool GetBonePosesForFrame_BoneNames_IsValid;

	private static FFieldAddress GetBonePosesForFrame_BoneNames_PropertyAddress;

	private static int GetBonePosesForFrame_BoneNames_Offset;

	private static bool GetBonePosesForFrame_Frame_IsValid;

	private static FFieldAddress GetBonePosesForFrame_Frame_PropertyAddress;

	private static int GetBonePosesForFrame_Frame_Offset;

	private static bool GetBonePosesForFrame_bExtractRootMotion_IsValid;

	private static FFieldAddress GetBonePosesForFrame_bExtractRootMotion_PropertyAddress;

	private static int GetBonePosesForFrame_bExtractRootMotion_Offset;

	private static bool GetBonePosesForFrame_Poses_IsValid;

	private static FFieldAddress GetBonePosesForFrame_Poses_PropertyAddress;

	private static int GetBonePosesForFrame_Poses_Offset;

	private static bool GetBonePosesForFrame_PreviewMesh_IsValid;

	private static FFieldAddress GetBonePosesForFrame_PreviewMesh_PropertyAddress;

	private static int GetBonePosesForFrame_PreviewMesh_Offset;

	private static bool GetBonePoseForTime_IsValid;

	private static IntPtr GetBonePoseForTime_FunctionAddress;

	private static int GetBonePoseForTime_ParamsSize;

	private static bool GetBonePoseForTime_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetBonePoseForTime_AnimationSequenceBase_PropertyAddress;

	private static int GetBonePoseForTime_AnimationSequenceBase_Offset;

	private static bool GetBonePoseForTime_BoneName_IsValid;

	private static FFieldAddress GetBonePoseForTime_BoneName_PropertyAddress;

	private static int GetBonePoseForTime_BoneName_Offset;

	private static bool GetBonePoseForTime_Time_IsValid;

	private static FFieldAddress GetBonePoseForTime_Time_PropertyAddress;

	private static int GetBonePoseForTime_Time_Offset;

	private static bool GetBonePoseForTime_bExtractRootMotion_IsValid;

	private static FFieldAddress GetBonePoseForTime_bExtractRootMotion_PropertyAddress;

	private static int GetBonePoseForTime_bExtractRootMotion_Offset;

	private static bool GetBonePoseForTime_Pose_IsValid;

	private static FFieldAddress GetBonePoseForTime_Pose_PropertyAddress;

	private static int GetBonePoseForTime_Pose_Offset;

	private static bool GetBonePoseForFrame_IsValid;

	private static IntPtr GetBonePoseForFrame_FunctionAddress;

	private static int GetBonePoseForFrame_ParamsSize;

	private static bool GetBonePoseForFrame_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetBonePoseForFrame_AnimationSequenceBase_PropertyAddress;

	private static int GetBonePoseForFrame_AnimationSequenceBase_Offset;

	private static bool GetBonePoseForFrame_BoneName_IsValid;

	private static FFieldAddress GetBonePoseForFrame_BoneName_PropertyAddress;

	private static int GetBonePoseForFrame_BoneName_Offset;

	private static bool GetBonePoseForFrame_Frame_IsValid;

	private static FFieldAddress GetBonePoseForFrame_Frame_PropertyAddress;

	private static int GetBonePoseForFrame_Frame_Offset;

	private static bool GetBonePoseForFrame_bExtractRootMotion_IsValid;

	private static FFieldAddress GetBonePoseForFrame_bExtractRootMotion_PropertyAddress;

	private static int GetBonePoseForFrame_bExtractRootMotion_Offset;

	private static bool GetBonePoseForFrame_Pose_IsValid;

	private static FFieldAddress GetBonePoseForFrame_Pose_PropertyAddress;

	private static int GetBonePoseForFrame_Pose_Offset;

	private static bool GetBoneCompressionSettings_IsValid;

	private static IntPtr GetBoneCompressionSettings_FunctionAddress;

	private static int GetBoneCompressionSettings_ParamsSize;

	private static bool GetBoneCompressionSettings_AnimationSequence_IsValid;

	private static FFieldAddress GetBoneCompressionSettings_AnimationSequence_PropertyAddress;

	private static int GetBoneCompressionSettings_AnimationSequence_Offset;

	private static bool GetBoneCompressionSettings_CompressionSettings_IsValid;

	private static FFieldAddress GetBoneCompressionSettings_CompressionSettings_PropertyAddress;

	private static int GetBoneCompressionSettings_CompressionSettings_Offset;

	private static bool GetAnimNotifyEventTriggerTime_IsValid;

	private static IntPtr GetAnimNotifyEventTriggerTime_FunctionAddress;

	private static int GetAnimNotifyEventTriggerTime_ParamsSize;

	private static bool GetAnimNotifyEventTriggerTime_NotifyEvent_IsValid;

	private static FFieldAddress GetAnimNotifyEventTriggerTime_NotifyEvent_PropertyAddress;

	private static int GetAnimNotifyEventTriggerTime_NotifyEvent_Offset;

	private static bool GetAnimNotifyEventTriggerTime_ReturnValue_IsValid;

	private static FFieldAddress GetAnimNotifyEventTriggerTime_ReturnValue_PropertyAddress;

	private static int GetAnimNotifyEventTriggerTime_ReturnValue_Offset;

	private static bool GetAnimNotifyEventDuration_IsValid;

	private static IntPtr GetAnimNotifyEventDuration_FunctionAddress;

	private static int GetAnimNotifyEventDuration_ParamsSize;

	private static bool GetAnimNotifyEventDuration_NotifyEvent_IsValid;

	private static FFieldAddress GetAnimNotifyEventDuration_NotifyEvent_PropertyAddress;

	private static int GetAnimNotifyEventDuration_NotifyEvent_Offset;

	private static bool GetAnimNotifyEventDuration_ReturnValue_IsValid;

	private static FFieldAddress GetAnimNotifyEventDuration_ReturnValue_PropertyAddress;

	private static int GetAnimNotifyEventDuration_ReturnValue_Offset;

	private static bool GetAnimationTrackNames_IsValid;

	private static IntPtr GetAnimationTrackNames_FunctionAddress;

	private static int GetAnimationTrackNames_ParamsSize;

	private static bool GetAnimationTrackNames_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetAnimationTrackNames_AnimationSequenceBase_PropertyAddress;

	private static int GetAnimationTrackNames_AnimationSequenceBase_Offset;

	private static bool GetAnimationTrackNames_TrackNames_IsValid;

	private static FFieldAddress GetAnimationTrackNames_TrackNames_PropertyAddress;

	private static int GetAnimationTrackNames_TrackNames_Offset;

	private static bool GetAnimationSyncMarkersForTrack_IsValid;

	private static IntPtr GetAnimationSyncMarkersForTrack_FunctionAddress;

	private static int GetAnimationSyncMarkersForTrack_ParamsSize;

	private static bool GetAnimationSyncMarkersForTrack_AnimationSequence_IsValid;

	private static FFieldAddress GetAnimationSyncMarkersForTrack_AnimationSequence_PropertyAddress;

	private static int GetAnimationSyncMarkersForTrack_AnimationSequence_Offset;

	private static bool GetAnimationSyncMarkersForTrack_NotifyTrackName_IsValid;

	private static FFieldAddress GetAnimationSyncMarkersForTrack_NotifyTrackName_PropertyAddress;

	private static int GetAnimationSyncMarkersForTrack_NotifyTrackName_Offset;

	private static bool GetAnimationSyncMarkersForTrack_Markers_IsValid;

	private static FFieldAddress GetAnimationSyncMarkersForTrack_Markers_PropertyAddress;

	private static int GetAnimationSyncMarkersForTrack_Markers_Offset;

	private static bool GetAnimationSyncMarkers_IsValid;

	private static IntPtr GetAnimationSyncMarkers_FunctionAddress;

	private static int GetAnimationSyncMarkers_ParamsSize;

	private static bool GetAnimationSyncMarkers_AnimationSequence_IsValid;

	private static FFieldAddress GetAnimationSyncMarkers_AnimationSequence_PropertyAddress;

	private static int GetAnimationSyncMarkers_AnimationSequence_Offset;

	private static bool GetAnimationSyncMarkers_Markers_IsValid;

	private static FFieldAddress GetAnimationSyncMarkers_Markers_PropertyAddress;

	private static int GetAnimationSyncMarkers_Markers_Offset;

	private static bool GetAnimationNotifyTrackNames_IsValid;

	private static IntPtr GetAnimationNotifyTrackNames_FunctionAddress;

	private static int GetAnimationNotifyTrackNames_ParamsSize;

	private static bool GetAnimationNotifyTrackNames_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetAnimationNotifyTrackNames_AnimationSequenceBase_PropertyAddress;

	private static int GetAnimationNotifyTrackNames_AnimationSequenceBase_Offset;

	private static bool GetAnimationNotifyTrackNames_TrackNames_IsValid;

	private static FFieldAddress GetAnimationNotifyTrackNames_TrackNames_PropertyAddress;

	private static int GetAnimationNotifyTrackNames_TrackNames_Offset;

	private static bool GetAnimationNotifyEventsForTrack_IsValid;

	private static IntPtr GetAnimationNotifyEventsForTrack_FunctionAddress;

	private static int GetAnimationNotifyEventsForTrack_ParamsSize;

	private static bool GetAnimationNotifyEventsForTrack_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetAnimationNotifyEventsForTrack_AnimationSequenceBase_PropertyAddress;

	private static int GetAnimationNotifyEventsForTrack_AnimationSequenceBase_Offset;

	private static bool GetAnimationNotifyEventsForTrack_NotifyTrackName_IsValid;

	private static FFieldAddress GetAnimationNotifyEventsForTrack_NotifyTrackName_PropertyAddress;

	private static int GetAnimationNotifyEventsForTrack_NotifyTrackName_Offset;

	private static bool GetAnimationNotifyEventsForTrack_Events_IsValid;

	private static FFieldAddress GetAnimationNotifyEventsForTrack_Events_PropertyAddress;

	private static int GetAnimationNotifyEventsForTrack_Events_Offset;

	private static bool GetAnimationNotifyEvents_IsValid;

	private static IntPtr GetAnimationNotifyEvents_FunctionAddress;

	private static int GetAnimationNotifyEvents_ParamsSize;

	private static bool GetAnimationNotifyEvents_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetAnimationNotifyEvents_AnimationSequenceBase_PropertyAddress;

	private static int GetAnimationNotifyEvents_AnimationSequenceBase_Offset;

	private static bool GetAnimationNotifyEvents_NotifyEvents_IsValid;

	private static FFieldAddress GetAnimationNotifyEvents_NotifyEvents_PropertyAddress;

	private static int GetAnimationNotifyEvents_NotifyEvents_Offset;

	private static bool GetAnimationNotifyEventNames_IsValid;

	private static IntPtr GetAnimationNotifyEventNames_FunctionAddress;

	private static int GetAnimationNotifyEventNames_ParamsSize;

	private static bool GetAnimationNotifyEventNames_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetAnimationNotifyEventNames_AnimationSequenceBase_PropertyAddress;

	private static int GetAnimationNotifyEventNames_AnimationSequenceBase_Offset;

	private static bool GetAnimationNotifyEventNames_EventNames_IsValid;

	private static FFieldAddress GetAnimationNotifyEventNames_EventNames_PropertyAddress;

	private static int GetAnimationNotifyEventNames_EventNames_Offset;

	private static bool GetAnimationInterpolationType_IsValid;

	private static IntPtr GetAnimationInterpolationType_FunctionAddress;

	private static int GetAnimationInterpolationType_ParamsSize;

	private static bool GetAnimationInterpolationType_AnimationSequence_IsValid;

	private static FFieldAddress GetAnimationInterpolationType_AnimationSequence_PropertyAddress;

	private static int GetAnimationInterpolationType_AnimationSequence_Offset;

	private static bool GetAnimationInterpolationType_InterpolationType_IsValid;

	private static FFieldAddress GetAnimationInterpolationType_InterpolationType_PropertyAddress;

	private static int GetAnimationInterpolationType_InterpolationType_Offset;

	private static bool GetAnimationGraphs_IsValid;

	private static IntPtr GetAnimationGraphs_FunctionAddress;

	private static int GetAnimationGraphs_ParamsSize;

	private static bool GetAnimationGraphs_AnimationBlueprint_IsValid;

	private static FFieldAddress GetAnimationGraphs_AnimationBlueprint_PropertyAddress;

	private static int GetAnimationGraphs_AnimationBlueprint_Offset;

	private static bool GetAnimationGraphs_AnimationGraphs_IsValid;

	private static FFieldAddress GetAnimationGraphs_AnimationGraphs_PropertyAddress;

	private static int GetAnimationGraphs_AnimationGraphs_Offset;

	private static bool GetAnimationCurveNames_IsValid;

	private static IntPtr GetAnimationCurveNames_FunctionAddress;

	private static int GetAnimationCurveNames_ParamsSize;

	private static bool GetAnimationCurveNames_AnimationSequence_IsValid;

	private static FFieldAddress GetAnimationCurveNames_AnimationSequence_PropertyAddress;

	private static int GetAnimationCurveNames_AnimationSequence_Offset;

	private static bool GetAnimationCurveNames_CurveType_IsValid;

	private static FFieldAddress GetAnimationCurveNames_CurveType_PropertyAddress;

	private static int GetAnimationCurveNames_CurveType_Offset;

	private static bool GetAnimationCurveNames_CurveNames_IsValid;

	private static FFieldAddress GetAnimationCurveNames_CurveNames_PropertyAddress;

	private static int GetAnimationCurveNames_CurveNames_Offset;

	private static bool GetAdditiveBasePoseType_IsValid;

	private static IntPtr GetAdditiveBasePoseType_FunctionAddress;

	private static int GetAdditiveBasePoseType_ParamsSize;

	private static bool GetAdditiveBasePoseType_AnimationSequence_IsValid;

	private static FFieldAddress GetAdditiveBasePoseType_AnimationSequence_PropertyAddress;

	private static int GetAdditiveBasePoseType_AnimationSequence_Offset;

	private static bool GetAdditiveBasePoseType_AdditiveBasePoseType_IsValid;

	private static FFieldAddress GetAdditiveBasePoseType_AdditiveBasePoseType_PropertyAddress;

	private static int GetAdditiveBasePoseType_AdditiveBasePoseType_Offset;

	private static bool GetAdditiveAnimationType_IsValid;

	private static IntPtr GetAdditiveAnimationType_FunctionAddress;

	private static int GetAdditiveAnimationType_ParamsSize;

	private static bool GetAdditiveAnimationType_AnimationSequence_IsValid;

	private static FFieldAddress GetAdditiveAnimationType_AnimationSequence_PropertyAddress;

	private static int GetAdditiveAnimationType_AnimationSequence_Offset;

	private static bool GetAdditiveAnimationType_AdditiveAnimationType_IsValid;

	private static FFieldAddress GetAdditiveAnimationType_AdditiveAnimationType_PropertyAddress;

	private static int GetAdditiveAnimationType_AdditiveAnimationType_Offset;

	private static bool FindBonePathToRoot_IsValid;

	private static IntPtr FindBonePathToRoot_FunctionAddress;

	private static int FindBonePathToRoot_ParamsSize;

	private static bool FindBonePathToRoot_AnimationSequenceBase_IsValid;

	private static FFieldAddress FindBonePathToRoot_AnimationSequenceBase_PropertyAddress;

	private static int FindBonePathToRoot_AnimationSequenceBase_Offset;

	private static bool FindBonePathToRoot_BoneName_IsValid;

	private static FFieldAddress FindBonePathToRoot_BoneName_PropertyAddress;

	private static int FindBonePathToRoot_BoneName_Offset;

	private static bool FindBonePathToRoot_BonePath_IsValid;

	private static FFieldAddress FindBonePathToRoot_BonePath_PropertyAddress;

	private static int FindBonePathToRoot_BonePath_Offset;

	private static bool EvaluateRootBoneTimecodeAttributesAtTime_IsValid;

	private static IntPtr EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress;

	private static int EvaluateRootBoneTimecodeAttributesAtTime_ParamsSize;

	private static bool EvaluateRootBoneTimecodeAttributesAtTime_AnimationSequenceBase_IsValid;

	private static FFieldAddress EvaluateRootBoneTimecodeAttributesAtTime_AnimationSequenceBase_PropertyAddress;

	private static int EvaluateRootBoneTimecodeAttributesAtTime_AnimationSequenceBase_Offset;

	private static bool EvaluateRootBoneTimecodeAttributesAtTime_EvalTime_IsValid;

	private static FFieldAddress EvaluateRootBoneTimecodeAttributesAtTime_EvalTime_PropertyAddress;

	private static int EvaluateRootBoneTimecodeAttributesAtTime_EvalTime_Offset;

	private static bool EvaluateRootBoneTimecodeAttributesAtTime_OutQualifiedFrameTime_IsValid;

	private static FFieldAddress EvaluateRootBoneTimecodeAttributesAtTime_OutQualifiedFrameTime_PropertyAddress;

	private static int EvaluateRootBoneTimecodeAttributesAtTime_OutQualifiedFrameTime_Offset;

	private static bool EvaluateRootBoneTimecodeAttributesAtTime_ReturnValue_IsValid;

	private static FFieldAddress EvaluateRootBoneTimecodeAttributesAtTime_ReturnValue_PropertyAddress;

	private static int EvaluateRootBoneTimecodeAttributesAtTime_ReturnValue_Offset;

	private static bool DoesCurveExist_IsValid;

	private static IntPtr DoesCurveExist_FunctionAddress;

	private static int DoesCurveExist_ParamsSize;

	private static bool DoesCurveExist_AnimationSequence_IsValid;

	private static FFieldAddress DoesCurveExist_AnimationSequence_PropertyAddress;

	private static int DoesCurveExist_AnimationSequence_Offset;

	private static bool DoesCurveExist_CurveName_IsValid;

	private static FFieldAddress DoesCurveExist_CurveName_PropertyAddress;

	private static int DoesCurveExist_CurveName_Offset;

	private static bool DoesCurveExist_CurveType_IsValid;

	private static FFieldAddress DoesCurveExist_CurveType_PropertyAddress;

	private static int DoesCurveExist_CurveType_Offset;

	private static bool DoesCurveExist_ReturnValue_IsValid;

	private static FFieldAddress DoesCurveExist_ReturnValue_PropertyAddress;

	private static int DoesCurveExist_ReturnValue_Offset;

	private static bool DoesBoneNameExist_IsValid;

	private static IntPtr DoesBoneNameExist_FunctionAddress;

	private static int DoesBoneNameExist_ParamsSize;

	private static bool DoesBoneNameExist_AnimationSequence_IsValid;

	private static FFieldAddress DoesBoneNameExist_AnimationSequence_PropertyAddress;

	private static int DoesBoneNameExist_AnimationSequence_Offset;

	private static bool DoesBoneNameExist_BoneName_IsValid;

	private static FFieldAddress DoesBoneNameExist_BoneName_PropertyAddress;

	private static int DoesBoneNameExist_BoneName_Offset;

	private static bool DoesBoneNameExist_bExists_IsValid;

	private static FFieldAddress DoesBoneNameExist_bExists_PropertyAddress;

	private static int DoesBoneNameExist_bExists_Offset;

	private static bool CopyAnimNotifiesFromSequence_IsValid;

	private static IntPtr CopyAnimNotifiesFromSequence_FunctionAddress;

	private static int CopyAnimNotifiesFromSequence_ParamsSize;

	private static bool CopyAnimNotifiesFromSequence_SourceAnimationSequenceBase_IsValid;

	private static FFieldAddress CopyAnimNotifiesFromSequence_SourceAnimationSequenceBase_PropertyAddress;

	private static int CopyAnimNotifiesFromSequence_SourceAnimationSequenceBase_Offset;

	private static bool CopyAnimNotifiesFromSequence_DestinationAnimationSequenceBase_IsValid;

	private static FFieldAddress CopyAnimNotifiesFromSequence_DestinationAnimationSequenceBase_PropertyAddress;

	private static int CopyAnimNotifiesFromSequence_DestinationAnimationSequenceBase_Offset;

	private static bool CopyAnimNotifiesFromSequence_bDeleteExistingNotifies_IsValid;

	private static FFieldAddress CopyAnimNotifiesFromSequence_bDeleteExistingNotifies_PropertyAddress;

	private static int CopyAnimNotifiesFromSequence_bDeleteExistingNotifies_Offset;

	private static bool CopyAnimationCurveNamesToSkeleton_IsValid;

	private static IntPtr CopyAnimationCurveNamesToSkeleton_FunctionAddress;

	private static int CopyAnimationCurveNamesToSkeleton_ParamsSize;

	private static bool CopyAnimationCurveNamesToSkeleton_OldSkeleton_IsValid;

	private static FFieldAddress CopyAnimationCurveNamesToSkeleton_OldSkeleton_PropertyAddress;

	private static int CopyAnimationCurveNamesToSkeleton_OldSkeleton_Offset;

	private static bool CopyAnimationCurveNamesToSkeleton_NewSkeleton_IsValid;

	private static FFieldAddress CopyAnimationCurveNamesToSkeleton_NewSkeleton_PropertyAddress;

	private static int CopyAnimationCurveNamesToSkeleton_NewSkeleton_Offset;

	private static bool CopyAnimationCurveNamesToSkeleton_SequenceBase_IsValid;

	private static FFieldAddress CopyAnimationCurveNamesToSkeleton_SequenceBase_PropertyAddress;

	private static int CopyAnimationCurveNamesToSkeleton_SequenceBase_Offset;

	private static bool CopyAnimationCurveNamesToSkeleton_CurveType_IsValid;

	private static FFieldAddress CopyAnimationCurveNamesToSkeleton_CurveType_PropertyAddress;

	private static int CopyAnimationCurveNamesToSkeleton_CurveType_Offset;

	private static bool ContainsMetaDataOfClass_IsValid;

	private static IntPtr ContainsMetaDataOfClass_FunctionAddress;

	private static int ContainsMetaDataOfClass_ParamsSize;

	private static bool ContainsMetaDataOfClass_AnimationAsset_IsValid;

	private static FFieldAddress ContainsMetaDataOfClass_AnimationAsset_PropertyAddress;

	private static int ContainsMetaDataOfClass_AnimationAsset_Offset;

	private static bool ContainsMetaDataOfClass_MetaDataClass_IsValid;

	private static FFieldAddress ContainsMetaDataOfClass_MetaDataClass_PropertyAddress;

	private static int ContainsMetaDataOfClass_MetaDataClass_Offset;

	private static bool ContainsMetaDataOfClass_ReturnValue_IsValid;

	private static FFieldAddress ContainsMetaDataOfClass_ReturnValue_PropertyAddress;

	private static int ContainsMetaDataOfClass_ReturnValue_Offset;

	private static bool AddVirtualBone_IsValid;

	private static IntPtr AddVirtualBone_FunctionAddress;

	private static int AddVirtualBone_ParamsSize;

	private static bool AddVirtualBone_AnimationSequence_IsValid;

	private static FFieldAddress AddVirtualBone_AnimationSequence_PropertyAddress;

	private static int AddVirtualBone_AnimationSequence_Offset;

	private static bool AddVirtualBone_SourceBoneName_IsValid;

	private static FFieldAddress AddVirtualBone_SourceBoneName_PropertyAddress;

	private static int AddVirtualBone_SourceBoneName_Offset;

	private static bool AddVirtualBone_TargetBoneName_IsValid;

	private static FFieldAddress AddVirtualBone_TargetBoneName_PropertyAddress;

	private static int AddVirtualBone_TargetBoneName_Offset;

	private static bool AddVirtualBone_VirtualBoneName_IsValid;

	private static FFieldAddress AddVirtualBone_VirtualBoneName_PropertyAddress;

	private static int AddVirtualBone_VirtualBoneName_Offset;

	private static bool AddVectorCurveKeys_IsValid;

	private static IntPtr AddVectorCurveKeys_FunctionAddress;

	private static int AddVectorCurveKeys_ParamsSize;

	private static bool AddVectorCurveKeys_AnimationSequence_IsValid;

	private static FFieldAddress AddVectorCurveKeys_AnimationSequence_PropertyAddress;

	private static int AddVectorCurveKeys_AnimationSequence_Offset;

	private static bool AddVectorCurveKeys_CurveName_IsValid;

	private static FFieldAddress AddVectorCurveKeys_CurveName_PropertyAddress;

	private static int AddVectorCurveKeys_CurveName_Offset;

	private static bool AddVectorCurveKeys_Times_IsValid;

	private static FFieldAddress AddVectorCurveKeys_Times_PropertyAddress;

	private static int AddVectorCurveKeys_Times_Offset;

	private static bool AddVectorCurveKeys_Vectors_IsValid;

	private static FFieldAddress AddVectorCurveKeys_Vectors_PropertyAddress;

	private static int AddVectorCurveKeys_Vectors_Offset;

	private static bool AddVectorCurveKey_IsValid;

	private static IntPtr AddVectorCurveKey_FunctionAddress;

	private static int AddVectorCurveKey_ParamsSize;

	private static bool AddVectorCurveKey_AnimationSequence_IsValid;

	private static FFieldAddress AddVectorCurveKey_AnimationSequence_PropertyAddress;

	private static int AddVectorCurveKey_AnimationSequence_Offset;

	private static bool AddVectorCurveKey_CurveName_IsValid;

	private static FFieldAddress AddVectorCurveKey_CurveName_PropertyAddress;

	private static int AddVectorCurveKey_CurveName_Offset;

	private static bool AddVectorCurveKey_Time_IsValid;

	private static FFieldAddress AddVectorCurveKey_Time_PropertyAddress;

	private static int AddVectorCurveKey_Time_Offset;

	private static bool AddVectorCurveKey_Vector_IsValid;

	private static FFieldAddress AddVectorCurveKey_Vector_PropertyAddress;

	private static int AddVectorCurveKey_Vector_Offset;

	private static bool AddTransformationCurveKeys_IsValid;

	private static IntPtr AddTransformationCurveKeys_FunctionAddress;

	private static int AddTransformationCurveKeys_ParamsSize;

	private static bool AddTransformationCurveKeys_AnimationSequence_IsValid;

	private static FFieldAddress AddTransformationCurveKeys_AnimationSequence_PropertyAddress;

	private static int AddTransformationCurveKeys_AnimationSequence_Offset;

	private static bool AddTransformationCurveKeys_CurveName_IsValid;

	private static FFieldAddress AddTransformationCurveKeys_CurveName_PropertyAddress;

	private static int AddTransformationCurveKeys_CurveName_Offset;

	private static bool AddTransformationCurveKeys_Times_IsValid;

	private static FFieldAddress AddTransformationCurveKeys_Times_PropertyAddress;

	private static int AddTransformationCurveKeys_Times_Offset;

	private static bool AddTransformationCurveKeys_Transforms_IsValid;

	private static FFieldAddress AddTransformationCurveKeys_Transforms_PropertyAddress;

	private static int AddTransformationCurveKeys_Transforms_Offset;

	private static bool AddTransformationCurveKey_IsValid;

	private static IntPtr AddTransformationCurveKey_FunctionAddress;

	private static int AddTransformationCurveKey_ParamsSize;

	private static bool AddTransformationCurveKey_AnimationSequence_IsValid;

	private static FFieldAddress AddTransformationCurveKey_AnimationSequence_PropertyAddress;

	private static int AddTransformationCurveKey_AnimationSequence_Offset;

	private static bool AddTransformationCurveKey_CurveName_IsValid;

	private static FFieldAddress AddTransformationCurveKey_CurveName_PropertyAddress;

	private static int AddTransformationCurveKey_CurveName_Offset;

	private static bool AddTransformationCurveKey_Time_IsValid;

	private static FFieldAddress AddTransformationCurveKey_Time_PropertyAddress;

	private static int AddTransformationCurveKey_Time_Offset;

	private static bool AddTransformationCurveKey_Transform_IsValid;

	private static FFieldAddress AddTransformationCurveKey_Transform_PropertyAddress;

	private static int AddTransformationCurveKey_Transform_Offset;

	private static bool AddMetaDataObject_IsValid;

	private static IntPtr AddMetaDataObject_FunctionAddress;

	private static int AddMetaDataObject_ParamsSize;

	private static bool AddMetaDataObject_AnimationAsset_IsValid;

	private static FFieldAddress AddMetaDataObject_AnimationAsset_PropertyAddress;

	private static int AddMetaDataObject_AnimationAsset_Offset;

	private static bool AddMetaDataObject_MetaDataObject_IsValid;

	private static FFieldAddress AddMetaDataObject_MetaDataObject_PropertyAddress;

	private static int AddMetaDataObject_MetaDataObject_Offset;

	private static bool AddMetaData_IsValid;

	private static IntPtr AddMetaData_FunctionAddress;

	private static int AddMetaData_ParamsSize;

	private static bool AddMetaData_AnimationAsset_IsValid;

	private static FFieldAddress AddMetaData_AnimationAsset_PropertyAddress;

	private static int AddMetaData_AnimationAsset_Offset;

	private static bool AddMetaData_MetaDataClass_IsValid;

	private static FFieldAddress AddMetaData_MetaDataClass_PropertyAddress;

	private static int AddMetaData_MetaDataClass_Offset;

	private static bool AddMetaData_MetaDataInstance_IsValid;

	private static FFieldAddress AddMetaData_MetaDataInstance_PropertyAddress;

	private static int AddMetaData_MetaDataInstance_Offset;

	private static bool AddFloatCurveKeys_IsValid;

	private static IntPtr AddFloatCurveKeys_FunctionAddress;

	private static int AddFloatCurveKeys_ParamsSize;

	private static bool AddFloatCurveKeys_AnimationSequence_IsValid;

	private static FFieldAddress AddFloatCurveKeys_AnimationSequence_PropertyAddress;

	private static int AddFloatCurveKeys_AnimationSequence_Offset;

	private static bool AddFloatCurveKeys_CurveName_IsValid;

	private static FFieldAddress AddFloatCurveKeys_CurveName_PropertyAddress;

	private static int AddFloatCurveKeys_CurveName_Offset;

	private static bool AddFloatCurveKeys_Times_IsValid;

	private static FFieldAddress AddFloatCurveKeys_Times_PropertyAddress;

	private static int AddFloatCurveKeys_Times_Offset;

	private static bool AddFloatCurveKeys_Values_IsValid;

	private static FFieldAddress AddFloatCurveKeys_Values_PropertyAddress;

	private static int AddFloatCurveKeys_Values_Offset;

	private static bool AddFloatCurveKey_IsValid;

	private static IntPtr AddFloatCurveKey_FunctionAddress;

	private static int AddFloatCurveKey_ParamsSize;

	private static bool AddFloatCurveKey_AnimationSequence_IsValid;

	private static FFieldAddress AddFloatCurveKey_AnimationSequence_PropertyAddress;

	private static int AddFloatCurveKey_AnimationSequence_Offset;

	private static bool AddFloatCurveKey_CurveName_IsValid;

	private static FFieldAddress AddFloatCurveKey_CurveName_PropertyAddress;

	private static int AddFloatCurveKey_CurveName_Offset;

	private static bool AddFloatCurveKey_Time_IsValid;

	private static FFieldAddress AddFloatCurveKey_Time_PropertyAddress;

	private static int AddFloatCurveKey_Time_Offset;

	private static bool AddFloatCurveKey_Value_IsValid;

	private static FFieldAddress AddFloatCurveKey_Value_PropertyAddress;

	private static int AddFloatCurveKey_Value_Offset;

	private static bool AddCurve_IsValid;

	private static IntPtr AddCurve_FunctionAddress;

	private static int AddCurve_ParamsSize;

	private static bool AddCurve_AnimationSequence_IsValid;

	private static FFieldAddress AddCurve_AnimationSequence_PropertyAddress;

	private static int AddCurve_AnimationSequence_Offset;

	private static bool AddCurve_CurveName_IsValid;

	private static FFieldAddress AddCurve_CurveName_PropertyAddress;

	private static int AddCurve_CurveName_Offset;

	private static bool AddCurve_CurveType_IsValid;

	private static FFieldAddress AddCurve_CurveType_PropertyAddress;

	private static int AddCurve_CurveType_Offset;

	private static bool AddCurve_bMetaDataCurve_IsValid;

	private static FFieldAddress AddCurve_bMetaDataCurve_PropertyAddress;

	private static int AddCurve_bMetaDataCurve_Offset;

	private static bool AddAnimationSyncMarker_IsValid;

	private static IntPtr AddAnimationSyncMarker_FunctionAddress;

	private static int AddAnimationSyncMarker_ParamsSize;

	private static bool AddAnimationSyncMarker_AnimationSequence_IsValid;

	private static FFieldAddress AddAnimationSyncMarker_AnimationSequence_PropertyAddress;

	private static int AddAnimationSyncMarker_AnimationSequence_Offset;

	private static bool AddAnimationSyncMarker_MarkerName_IsValid;

	private static FFieldAddress AddAnimationSyncMarker_MarkerName_PropertyAddress;

	private static int AddAnimationSyncMarker_MarkerName_Offset;

	private static bool AddAnimationSyncMarker_Time_IsValid;

	private static FFieldAddress AddAnimationSyncMarker_Time_PropertyAddress;

	private static int AddAnimationSyncMarker_Time_Offset;

	private static bool AddAnimationSyncMarker_NotifyTrackName_IsValid;

	private static FFieldAddress AddAnimationSyncMarker_NotifyTrackName_PropertyAddress;

	private static int AddAnimationSyncMarker_NotifyTrackName_Offset;

	private static bool AddAnimationNotifyTrack_IsValid;

	private static IntPtr AddAnimationNotifyTrack_FunctionAddress;

	private static int AddAnimationNotifyTrack_ParamsSize;

	private static bool AddAnimationNotifyTrack_AnimationSequenceBase_IsValid;

	private static FFieldAddress AddAnimationNotifyTrack_AnimationSequenceBase_PropertyAddress;

	private static int AddAnimationNotifyTrack_AnimationSequenceBase_Offset;

	private static bool AddAnimationNotifyTrack_NotifyTrackName_IsValid;

	private static FFieldAddress AddAnimationNotifyTrack_NotifyTrackName_PropertyAddress;

	private static int AddAnimationNotifyTrack_NotifyTrackName_Offset;

	private static bool AddAnimationNotifyTrack_TrackColor_IsValid;

	private static FFieldAddress AddAnimationNotifyTrack_TrackColor_PropertyAddress;

	private static int AddAnimationNotifyTrack_TrackColor_Offset;

	private static bool AddAnimationNotifyStateEventObject_IsValid;

	private static IntPtr AddAnimationNotifyStateEventObject_FunctionAddress;

	private static int AddAnimationNotifyStateEventObject_ParamsSize;

	private static bool AddAnimationNotifyStateEventObject_AnimationSequenceBase_IsValid;

	private static FFieldAddress AddAnimationNotifyStateEventObject_AnimationSequenceBase_PropertyAddress;

	private static int AddAnimationNotifyStateEventObject_AnimationSequenceBase_Offset;

	private static bool AddAnimationNotifyStateEventObject_StartTime_IsValid;

	private static FFieldAddress AddAnimationNotifyStateEventObject_StartTime_PropertyAddress;

	private static int AddAnimationNotifyStateEventObject_StartTime_Offset;

	private static bool AddAnimationNotifyStateEventObject_Duration_IsValid;

	private static FFieldAddress AddAnimationNotifyStateEventObject_Duration_PropertyAddress;

	private static int AddAnimationNotifyStateEventObject_Duration_Offset;

	private static bool AddAnimationNotifyStateEventObject_NotifyState_IsValid;

	private static FFieldAddress AddAnimationNotifyStateEventObject_NotifyState_PropertyAddress;

	private static int AddAnimationNotifyStateEventObject_NotifyState_Offset;

	private static bool AddAnimationNotifyStateEventObject_NotifyTrackName_IsValid;

	private static FFieldAddress AddAnimationNotifyStateEventObject_NotifyTrackName_PropertyAddress;

	private static int AddAnimationNotifyStateEventObject_NotifyTrackName_Offset;

	private static bool AddAnimationNotifyStateEvent_IsValid;

	private static IntPtr AddAnimationNotifyStateEvent_FunctionAddress;

	private static int AddAnimationNotifyStateEvent_ParamsSize;

	private static bool AddAnimationNotifyStateEvent_AnimationSequenceBase_IsValid;

	private static FFieldAddress AddAnimationNotifyStateEvent_AnimationSequenceBase_PropertyAddress;

	private static int AddAnimationNotifyStateEvent_AnimationSequenceBase_Offset;

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

	private static bool AddAnimationNotifyEventObject_IsValid;

	private static IntPtr AddAnimationNotifyEventObject_FunctionAddress;

	private static int AddAnimationNotifyEventObject_ParamsSize;

	private static bool AddAnimationNotifyEventObject_AnimationSequenceBase_IsValid;

	private static FFieldAddress AddAnimationNotifyEventObject_AnimationSequenceBase_PropertyAddress;

	private static int AddAnimationNotifyEventObject_AnimationSequenceBase_Offset;

	private static bool AddAnimationNotifyEventObject_StartTime_IsValid;

	private static FFieldAddress AddAnimationNotifyEventObject_StartTime_PropertyAddress;

	private static int AddAnimationNotifyEventObject_StartTime_Offset;

	private static bool AddAnimationNotifyEventObject_Notify_IsValid;

	private static FFieldAddress AddAnimationNotifyEventObject_Notify_PropertyAddress;

	private static int AddAnimationNotifyEventObject_Notify_Offset;

	private static bool AddAnimationNotifyEventObject_NotifyTrackName_IsValid;

	private static FFieldAddress AddAnimationNotifyEventObject_NotifyTrackName_PropertyAddress;

	private static int AddAnimationNotifyEventObject_NotifyTrackName_Offset;

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

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetRootMotionLockType")]
	public unsafe static void SetRootMotionLockType(UAnimSequence AnimationSequence, ERootMotionRootLock RootMotionLockType)
	{
		if (!SetRootMotionLockType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetRootMotionLockType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRootMotionLockType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRootMotionLockType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, SetRootMotionLockType_AnimationSequence_Offset), 0, SetRootMotionLockType_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		EnumMarshaler<ERootMotionRootLock>.ToNative(IntPtr.Add(intPtr, SetRootMotionLockType_RootMotionLockType_Offset), 0, SetRootMotionLockType_RootMotionLockType_PropertyAddress.Address, RootMotionLockType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRootMotionLockType_FunctionAddress, intPtr, SetRootMotionLockType_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetRootMotionEnabled")]
	public unsafe static void SetRootMotionEnabled(UAnimSequence AnimationSequence, bool bEnabled)
	{
		if (!SetRootMotionEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetRootMotionEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRootMotionEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRootMotionEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, SetRootMotionEnabled_AnimationSequence_Offset), 0, SetRootMotionEnabled_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRootMotionEnabled_bEnabled_Offset), 0, SetRootMotionEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRootMotionEnabled_FunctionAddress, intPtr, SetRootMotionEnabled_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetRateScale")]
	public unsafe static void SetRateScale(UAnimSequenceBase AnimationSequenceBase, float RateScale)
	{
		if (!SetRateScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetRateScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRateScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRateScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, SetRateScale_AnimationSequenceBase_Offset), 0, SetRateScale_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRateScale_RateScale_Offset), 0, SetRateScale_RateScale_PropertyAddress.Address, RateScale);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRateScale_FunctionAddress, intPtr, SetRateScale_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetIsRootMotionLockForced")]
	public unsafe static void SetIsRootMotionLockForced(UAnimSequence AnimationSequence, bool bForced)
	{
		if (!SetIsRootMotionLockForced_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetIsRootMotionLockForced");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsRootMotionLockForced_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsRootMotionLockForced_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, SetIsRootMotionLockForced_AnimationSequence_Offset), 0, SetIsRootMotionLockForced_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsRootMotionLockForced_bForced_Offset), 0, SetIsRootMotionLockForced_bForced_PropertyAddress.Address, bForced);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetIsRootMotionLockForced_FunctionAddress, intPtr, SetIsRootMotionLockForced_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetCurveCompressionSettings")]
	public unsafe static void SetCurveCompressionSettings(UAnimSequence AnimationSequence, UAnimCurveCompressionSettings CompressionSettings)
	{
		if (!SetCurveCompressionSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetCurveCompressionSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurveCompressionSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurveCompressionSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, SetCurveCompressionSettings_AnimationSequence_Offset), 0, SetCurveCompressionSettings_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		UObjectMarshaler<UAnimCurveCompressionSettings>.ToNative(IntPtr.Add(intPtr, SetCurveCompressionSettings_CompressionSettings_Offset), 0, SetCurveCompressionSettings_CompressionSettings_PropertyAddress.Address, CompressionSettings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCurveCompressionSettings_FunctionAddress, intPtr, SetCurveCompressionSettings_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetBoneCompressionSettings")]
	public unsafe static void SetBoneCompressionSettings(UAnimSequence AnimationSequence, UAnimBoneCompressionSettings CompressionSettings)
	{
		if (!SetBoneCompressionSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetBoneCompressionSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoneCompressionSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoneCompressionSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, SetBoneCompressionSettings_AnimationSequence_Offset), 0, SetBoneCompressionSettings_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		UObjectMarshaler<UAnimBoneCompressionSettings>.ToNative(IntPtr.Add(intPtr, SetBoneCompressionSettings_CompressionSettings_Offset), 0, SetBoneCompressionSettings_CompressionSettings_PropertyAddress.Address, CompressionSettings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBoneCompressionSettings_FunctionAddress, intPtr, SetBoneCompressionSettings_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetAnimationInterpolationType")]
	public unsafe static void SetAnimationInterpolationType(UAnimSequence AnimationSequence, EAnimInterpolationType InterpolationType)
	{
		if (!SetAnimationInterpolationType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetAnimationInterpolationType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimationInterpolationType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimationInterpolationType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, SetAnimationInterpolationType_AnimationSequence_Offset), 0, SetAnimationInterpolationType_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		EnumMarshaler<EAnimInterpolationType>.ToNative(IntPtr.Add(intPtr, SetAnimationInterpolationType_InterpolationType_Offset), 0, SetAnimationInterpolationType_InterpolationType_PropertyAddress.Address, InterpolationType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAnimationInterpolationType_FunctionAddress, intPtr, SetAnimationInterpolationType_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetAdditiveBasePoseType")]
	public unsafe static void SetAdditiveBasePoseType(UAnimSequence AnimationSequence, EAdditiveBasePoseType AdditiveBasePoseType)
	{
		if (!SetAdditiveBasePoseType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetAdditiveBasePoseType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAdditiveBasePoseType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAdditiveBasePoseType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, SetAdditiveBasePoseType_AnimationSequence_Offset), 0, SetAdditiveBasePoseType_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		EnumMarshaler<EAdditiveBasePoseType>.ToNative(IntPtr.Add(intPtr, SetAdditiveBasePoseType_AdditiveBasePoseType_Offset), 0, SetAdditiveBasePoseType_AdditiveBasePoseType_PropertyAddress.Address, AdditiveBasePoseType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAdditiveBasePoseType_FunctionAddress, intPtr, SetAdditiveBasePoseType_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetAdditiveAnimationType")]
	public unsafe static void SetAdditiveAnimationType(UAnimSequence AnimationSequence, EAdditiveAnimationType AdditiveAnimationType)
	{
		if (!SetAdditiveAnimationType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetAdditiveAnimationType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAdditiveAnimationType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAdditiveAnimationType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, SetAdditiveAnimationType_AnimationSequence_Offset), 0, SetAdditiveAnimationType_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		EnumMarshaler<EAdditiveAnimationType>.ToNative(IntPtr.Add(intPtr, SetAdditiveAnimationType_AdditiveAnimationType_Offset), 0, SetAdditiveAnimationType_AdditiveAnimationType_PropertyAddress.Address, AdditiveAnimationType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAdditiveAnimationType_FunctionAddress, intPtr, SetAdditiveAnimationType_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:ReplaceAnimNotifyStates")]
	public unsafe static void ReplaceAnimNotifyStates(UAnimSequenceBase AnimationSequenceBase, TSubclassOf<UAnimNotifyState> OldNotifyClass, TSubclassOf<UAnimNotifyState> NewNotifyClass, FOnNotifyStateReplaced OnNotifyStateReplaced)
	{
		if (!ReplaceAnimNotifyStates_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:ReplaceAnimNotifyStates");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceAnimNotifyStates_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceAnimNotifyStates_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, ReplaceAnimNotifyStates_AnimationSequenceBase_Offset), 0, ReplaceAnimNotifyStates_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		TSubclassOfMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, ReplaceAnimNotifyStates_OldNotifyClass_Offset), 0, ReplaceAnimNotifyStates_OldNotifyClass_PropertyAddress.Address, OldNotifyClass);
		TSubclassOfMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, ReplaceAnimNotifyStates_NewNotifyClass_Offset), 0, ReplaceAnimNotifyStates_NewNotifyClass_PropertyAddress.Address, NewNotifyClass);
		FDelegateMarshaler<FOnNotifyStateReplaced>.ToNative(IntPtr.Add(intPtr, ReplaceAnimNotifyStates_OnNotifyStateReplaced_Offset), 0, ReplaceAnimNotifyStates_OnNotifyStateReplaced_PropertyAddress.Address, OnNotifyStateReplaced);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceAnimNotifyStates_FunctionAddress, intPtr, ReplaceAnimNotifyStates_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:ReplaceAnimNotifies")]
	public unsafe static void ReplaceAnimNotifies(UAnimSequenceBase AnimationSequenceBase, TSubclassOf<UAnimNotify> OldNotifyClass, TSubclassOf<UAnimNotify> NewNotifyClass, FOnNotifyReplaced OnNotifyReplaced)
	{
		if (!ReplaceAnimNotifies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:ReplaceAnimNotifies");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceAnimNotifies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceAnimNotifies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, ReplaceAnimNotifies_AnimationSequenceBase_Offset), 0, ReplaceAnimNotifies_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		TSubclassOfMarshaler<UAnimNotify>.ToNative(IntPtr.Add(intPtr, ReplaceAnimNotifies_OldNotifyClass_Offset), 0, ReplaceAnimNotifies_OldNotifyClass_PropertyAddress.Address, OldNotifyClass);
		TSubclassOfMarshaler<UAnimNotify>.ToNative(IntPtr.Add(intPtr, ReplaceAnimNotifies_NewNotifyClass_Offset), 0, ReplaceAnimNotifies_NewNotifyClass_PropertyAddress.Address, NewNotifyClass);
		FDelegateMarshaler<FOnNotifyReplaced>.ToNative(IntPtr.Add(intPtr, ReplaceAnimNotifies_OnNotifyReplaced_Offset), 0, ReplaceAnimNotifies_OnNotifyReplaced_PropertyAddress.Address, OnNotifyReplaced);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceAnimNotifies_FunctionAddress, intPtr, ReplaceAnimNotifies_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveVirtualBones")]
	public unsafe static void RemoveVirtualBones(UAnimSequence AnimationSequence, List<FName> VirtualBoneNames)
	{
		if (!RemoveVirtualBones_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveVirtualBones");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveVirtualBones_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveVirtualBones_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, RemoveVirtualBones_AnimationSequence_Offset), 0, RemoveVirtualBones_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		new TArrayCopyMarshaler<FName>(1, RemoveVirtualBones_VirtualBoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, RemoveVirtualBones_VirtualBoneNames_Offset), VirtualBoneNames);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveVirtualBones_FunctionAddress, intPtr, RemoveVirtualBones_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveVirtualBones_VirtualBoneNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveVirtualBone")]
	public unsafe static void RemoveVirtualBone(UAnimSequence AnimationSequence, FName VirtualBoneName)
	{
		if (!RemoveVirtualBone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveVirtualBone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveVirtualBone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveVirtualBone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, RemoveVirtualBone_AnimationSequence_Offset), 0, RemoveVirtualBone_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveVirtualBone_VirtualBoneName_Offset), 0, RemoveVirtualBone_VirtualBoneName_PropertyAddress.Address, VirtualBoneName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveVirtualBone_FunctionAddress, intPtr, RemoveVirtualBone_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveMetaDataOfClass")]
	public unsafe static void RemoveMetaDataOfClass(UAnimationAsset AnimationAsset, TSubclassOf<UAnimMetaData> MetaDataClass)
	{
		if (!RemoveMetaDataOfClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveMetaDataOfClass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveMetaDataOfClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveMetaDataOfClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(intPtr, RemoveMetaDataOfClass_AnimationAsset_Offset), 0, RemoveMetaDataOfClass_AnimationAsset_PropertyAddress.Address, AnimationAsset);
		TSubclassOfMarshaler<UAnimMetaData>.ToNative(IntPtr.Add(intPtr, RemoveMetaDataOfClass_MetaDataClass_Offset), 0, RemoveMetaDataOfClass_MetaDataClass_PropertyAddress.Address, MetaDataClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveMetaDataOfClass_FunctionAddress, intPtr, RemoveMetaDataOfClass_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveMetaData")]
	public unsafe static void RemoveMetaData(UAnimationAsset AnimationAsset, UAnimMetaData MetaDataObject)
	{
		if (!RemoveMetaData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveMetaData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveMetaData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveMetaData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(intPtr, RemoveMetaData_AnimationAsset_Offset), 0, RemoveMetaData_AnimationAsset_PropertyAddress.Address, AnimationAsset);
		UObjectMarshaler<UAnimMetaData>.ToNative(IntPtr.Add(intPtr, RemoveMetaData_MetaDataObject_Offset), 0, RemoveMetaData_MetaDataObject_PropertyAddress.Address, MetaDataObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveMetaData_FunctionAddress, intPtr, RemoveMetaData_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveCurve")]
	public unsafe static void RemoveCurve(UAnimSequence AnimationSequence, FName CurveName, bool bRemoveNameFromSkeleton = false)
	{
		if (!RemoveCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveCurve");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, RemoveCurve_AnimationSequence_Offset), 0, RemoveCurve_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveCurve_CurveName_Offset), 0, RemoveCurve_CurveName_PropertyAddress.Address, CurveName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveCurve_bRemoveNameFromSkeleton_Offset), 0, RemoveCurve_bRemoveNameFromSkeleton_PropertyAddress.Address, bRemoveNameFromSkeleton);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveCurve_FunctionAddress, intPtr, RemoveCurve_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveBoneAnimation")]
	public unsafe static void RemoveBoneAnimation(UAnimSequence AnimationSequence, FName BoneName, bool bIncludeChildren = true, bool bFinalize = true)
	{
		if (!RemoveBoneAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveBoneAnimation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveBoneAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveBoneAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, RemoveBoneAnimation_AnimationSequence_Offset), 0, RemoveBoneAnimation_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveBoneAnimation_BoneName_Offset), 0, RemoveBoneAnimation_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveBoneAnimation_bIncludeChildren_Offset), 0, RemoveBoneAnimation_bIncludeChildren_PropertyAddress.Address, bIncludeChildren);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveBoneAnimation_bFinalize_Offset), 0, RemoveBoneAnimation_bFinalize_PropertyAddress.Address, bFinalize);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveBoneAnimation_FunctionAddress, intPtr, RemoveBoneAnimation_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationSyncMarkersByTrack")]
	public unsafe static int RemoveAnimationSyncMarkersByTrack(UAnimSequence AnimationSequence, FName NotifyTrackName)
	{
		if (!RemoveAnimationSyncMarkersByTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationSyncMarkersByTrack");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAnimationSyncMarkersByTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAnimationSyncMarkersByTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, RemoveAnimationSyncMarkersByTrack_AnimationSequence_Offset), 0, RemoveAnimationSyncMarkersByTrack_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveAnimationSyncMarkersByTrack_NotifyTrackName_Offset), 0, RemoveAnimationSyncMarkersByTrack_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAnimationSyncMarkersByTrack_FunctionAddress, intPtr, RemoveAnimationSyncMarkersByTrack_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, RemoveAnimationSyncMarkersByTrack_ReturnValue_Offset), 0, RemoveAnimationSyncMarkersByTrack_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationSyncMarkersByName")]
	public unsafe static int RemoveAnimationSyncMarkersByName(UAnimSequence AnimationSequence, FName MarkerName)
	{
		if (!RemoveAnimationSyncMarkersByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationSyncMarkersByName");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAnimationSyncMarkersByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAnimationSyncMarkersByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, RemoveAnimationSyncMarkersByName_AnimationSequence_Offset), 0, RemoveAnimationSyncMarkersByName_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveAnimationSyncMarkersByName_MarkerName_Offset), 0, RemoveAnimationSyncMarkersByName_MarkerName_PropertyAddress.Address, MarkerName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAnimationSyncMarkersByName_FunctionAddress, intPtr, RemoveAnimationSyncMarkersByName_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, RemoveAnimationSyncMarkersByName_ReturnValue_Offset), 0, RemoveAnimationSyncMarkersByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationNotifyTrack")]
	public unsafe static void RemoveAnimationNotifyTrack(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName)
	{
		if (!RemoveAnimationNotifyTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationNotifyTrack");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAnimationNotifyTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAnimationNotifyTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, RemoveAnimationNotifyTrack_AnimationSequenceBase_Offset), 0, RemoveAnimationNotifyTrack_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveAnimationNotifyTrack_NotifyTrackName_Offset), 0, RemoveAnimationNotifyTrack_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAnimationNotifyTrack_FunctionAddress, intPtr, RemoveAnimationNotifyTrack_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationNotifyEventsByTrack")]
	public unsafe static int RemoveAnimationNotifyEventsByTrack(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName)
	{
		if (!RemoveAnimationNotifyEventsByTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationNotifyEventsByTrack");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAnimationNotifyEventsByTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAnimationNotifyEventsByTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, RemoveAnimationNotifyEventsByTrack_AnimationSequenceBase_Offset), 0, RemoveAnimationNotifyEventsByTrack_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveAnimationNotifyEventsByTrack_NotifyTrackName_Offset), 0, RemoveAnimationNotifyEventsByTrack_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAnimationNotifyEventsByTrack_FunctionAddress, intPtr, RemoveAnimationNotifyEventsByTrack_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, RemoveAnimationNotifyEventsByTrack_ReturnValue_Offset), 0, RemoveAnimationNotifyEventsByTrack_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationNotifyEventsByName")]
	public unsafe static int RemoveAnimationNotifyEventsByName(UAnimSequenceBase AnimationSequenceBase, FName NotifyName)
	{
		if (!RemoveAnimationNotifyEventsByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationNotifyEventsByName");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAnimationNotifyEventsByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAnimationNotifyEventsByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, RemoveAnimationNotifyEventsByName_AnimationSequenceBase_Offset), 0, RemoveAnimationNotifyEventsByName_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveAnimationNotifyEventsByName_NotifyName_Offset), 0, RemoveAnimationNotifyEventsByName_NotifyName_PropertyAddress.Address, NotifyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAnimationNotifyEventsByName_FunctionAddress, intPtr, RemoveAnimationNotifyEventsByName_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, RemoveAnimationNotifyEventsByName_ReturnValue_Offset), 0, RemoveAnimationNotifyEventsByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllVirtualBones")]
	public unsafe static void RemoveAllVirtualBones(UAnimSequence AnimationSequence)
	{
		if (!RemoveAllVirtualBones_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllVirtualBones");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllVirtualBones_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllVirtualBones_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, RemoveAllVirtualBones_AnimationSequence_Offset), 0, RemoveAllVirtualBones_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAllVirtualBones_FunctionAddress, intPtr, RemoveAllVirtualBones_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllMetaData")]
	public unsafe static void RemoveAllMetaData(UAnimationAsset AnimationAsset)
	{
		if (!RemoveAllMetaData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllMetaData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllMetaData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllMetaData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(intPtr, RemoveAllMetaData_AnimationAsset_Offset), 0, RemoveAllMetaData_AnimationAsset_PropertyAddress.Address, AnimationAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAllMetaData_FunctionAddress, intPtr, RemoveAllMetaData_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllCurveData")]
	public unsafe static void RemoveAllCurveData(UAnimSequence AnimationSequence)
	{
		if (!RemoveAllCurveData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllCurveData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllCurveData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllCurveData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, RemoveAllCurveData_AnimationSequence_Offset), 0, RemoveAllCurveData_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAllCurveData_FunctionAddress, intPtr, RemoveAllCurveData_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllBoneAnimation")]
	public unsafe static void RemoveAllBoneAnimation(UAnimSequence AnimationSequence)
	{
		if (!RemoveAllBoneAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllBoneAnimation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllBoneAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllBoneAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, RemoveAllBoneAnimation_AnimationSequence_Offset), 0, RemoveAllBoneAnimation_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAllBoneAnimation_FunctionAddress, intPtr, RemoveAllBoneAnimation_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllAnimationSyncMarkers")]
	public unsafe static void RemoveAllAnimationSyncMarkers(UAnimSequence AnimationSequence)
	{
		if (!RemoveAllAnimationSyncMarkers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllAnimationSyncMarkers");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllAnimationSyncMarkers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllAnimationSyncMarkers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, RemoveAllAnimationSyncMarkers_AnimationSequence_Offset), 0, RemoveAllAnimationSyncMarkers_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAllAnimationSyncMarkers_FunctionAddress, intPtr, RemoveAllAnimationSyncMarkers_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllAnimationNotifyTracks")]
	public unsafe static void RemoveAllAnimationNotifyTracks(UAnimSequenceBase AnimationSequenceBase)
	{
		if (!RemoveAllAnimationNotifyTracks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllAnimationNotifyTracks");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllAnimationNotifyTracks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllAnimationNotifyTracks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, RemoveAllAnimationNotifyTracks_AnimationSequenceBase_Offset), 0, RemoveAllAnimationNotifyTracks_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAllAnimationNotifyTracks_FunctionAddress, intPtr, RemoveAllAnimationNotifyTracks_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsValidTime")]
	public unsafe static void IsValidTime(UAnimSequenceBase AnimationSequenceBase, float Time, out bool IsValid)
	{
		if (!IsValidTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsValidTime");
			IsValid = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, IsValidTime_AnimationSequenceBase_Offset), 0, IsValidTime_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, IsValidTime_Time_Offset), 0, IsValidTime_Time_PropertyAddress.Address, Time);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValidTime_FunctionAddress, intPtr, IsValidTime_ParamsSize);
		IsValid = BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidTime_IsValid_Offset), 0, IsValidTime_IsValid_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsValidRawAnimationTrackName")]
	public unsafe static bool IsValidRawAnimationTrackName(UAnimSequenceBase AnimationSequenceBase, FName TrackName)
	{
		if (!IsValidRawAnimationTrackName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsValidRawAnimationTrackName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidRawAnimationTrackName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidRawAnimationTrackName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, IsValidRawAnimationTrackName_AnimationSequenceBase_Offset), 0, IsValidRawAnimationTrackName_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsValidRawAnimationTrackName_TrackName_Offset), 0, IsValidRawAnimationTrackName_TrackName_PropertyAddress.Address, TrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValidRawAnimationTrackName_FunctionAddress, intPtr, IsValidRawAnimationTrackName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidRawAnimationTrackName_ReturnValue_Offset), 0, IsValidRawAnimationTrackName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsValidAnimNotifyTrackName")]
	public unsafe static bool IsValidAnimNotifyTrackName(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName)
	{
		if (!IsValidAnimNotifyTrackName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsValidAnimNotifyTrackName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidAnimNotifyTrackName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidAnimNotifyTrackName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, IsValidAnimNotifyTrackName_AnimationSequenceBase_Offset), 0, IsValidAnimNotifyTrackName_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsValidAnimNotifyTrackName_NotifyTrackName_Offset), 0, IsValidAnimNotifyTrackName_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValidAnimNotifyTrackName_FunctionAddress, intPtr, IsValidAnimNotifyTrackName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidAnimNotifyTrackName_ReturnValue_Offset), 0, IsValidAnimNotifyTrackName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsValidAnimationSyncMarkerName")]
	public unsafe static bool IsValidAnimationSyncMarkerName(UAnimSequence AnimationSequence, FName MarkerName)
	{
		if (!IsValidAnimationSyncMarkerName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsValidAnimationSyncMarkerName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidAnimationSyncMarkerName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidAnimationSyncMarkerName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, IsValidAnimationSyncMarkerName_AnimationSequence_Offset), 0, IsValidAnimationSyncMarkerName_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsValidAnimationSyncMarkerName_MarkerName_Offset), 0, IsValidAnimationSyncMarkerName_MarkerName_PropertyAddress.Address, MarkerName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValidAnimationSyncMarkerName_FunctionAddress, intPtr, IsValidAnimationSyncMarkerName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidAnimationSyncMarkerName_ReturnValue_Offset), 0, IsValidAnimationSyncMarkerName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsRootMotionLockForced")]
	public unsafe static bool IsRootMotionLockForced(UAnimSequence AnimationSequence)
	{
		if (!IsRootMotionLockForced_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsRootMotionLockForced");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRootMotionLockForced_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRootMotionLockForced_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, IsRootMotionLockForced_AnimationSequence_Offset), 0, IsRootMotionLockForced_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRootMotionLockForced_FunctionAddress, intPtr, IsRootMotionLockForced_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRootMotionLockForced_ReturnValue_Offset), 0, IsRootMotionLockForced_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsRootMotionEnabled")]
	public unsafe static bool IsRootMotionEnabled(UAnimSequence AnimationSequence)
	{
		if (!IsRootMotionEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsRootMotionEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRootMotionEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRootMotionEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, IsRootMotionEnabled_AnimationSequence_Offset), 0, IsRootMotionEnabled_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRootMotionEnabled_FunctionAddress, intPtr, IsRootMotionEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRootMotionEnabled_ReturnValue_Offset), 0, IsRootMotionEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetVectorKeys")]
	public unsafe static void GetVectorKeys(UAnimSequence AnimationSequence, FName CurveName, out List<float> Times, out List<FVector> Values)
	{
		if (!GetVectorKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetVectorKeys");
			Times = null;
			Values = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetVectorKeys_AnimationSequence_Offset), 0, GetVectorKeys_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVectorKeys_CurveName_Offset), 0, GetVectorKeys_CurveName_PropertyAddress.Address, CurveName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVectorKeys_FunctionAddress, intPtr, GetVectorKeys_ParamsSize);
		Times = new TArrayCopyMarshaler<float>(1, GetVectorKeys_Times_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetVectorKeys_Times_Offset));
		NativeReflection.DestroyValue_InContainer(GetVectorKeys_Times_PropertyAddress.Address, intPtr);
		Values = new TArrayCopyMarshaler<FVector>(1, GetVectorKeys_Values_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetVectorKeys_Values_Offset));
		NativeReflection.DestroyValue_InContainer(GetVectorKeys_Values_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetUniqueMarkerNames")]
	public unsafe static void GetUniqueMarkerNames(UAnimSequence AnimationSequence, out List<FName> MarkerNames)
	{
		if (!GetUniqueMarkerNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetUniqueMarkerNames");
			MarkerNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUniqueMarkerNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUniqueMarkerNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetUniqueMarkerNames_AnimationSequence_Offset), 0, GetUniqueMarkerNames_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUniqueMarkerNames_FunctionAddress, intPtr, GetUniqueMarkerNames_ParamsSize);
		MarkerNames = new TArrayCopyMarshaler<FName>(1, GetUniqueMarkerNames_MarkerNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetUniqueMarkerNames_MarkerNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetUniqueMarkerNames_MarkerNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetTransformationKeys")]
	public unsafe static void GetTransformationKeys(UAnimSequence AnimationSequence, FName CurveName, out List<float> Times, out List<FTransform> Values)
	{
		if (!GetTransformationKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetTransformationKeys");
			Times = null;
			Values = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransformationKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransformationKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetTransformationKeys_AnimationSequence_Offset), 0, GetTransformationKeys_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTransformationKeys_CurveName_Offset), 0, GetTransformationKeys_CurveName_PropertyAddress.Address, CurveName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTransformationKeys_FunctionAddress, intPtr, GetTransformationKeys_ParamsSize);
		Times = new TArrayCopyMarshaler<float>(1, GetTransformationKeys_Times_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetTransformationKeys_Times_Offset));
		NativeReflection.DestroyValue_InContainer(GetTransformationKeys_Times_PropertyAddress.Address, intPtr);
		Values = new TArrayCopyMarshaler<FTransform>(1, GetTransformationKeys_Values_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(intPtr, GetTransformationKeys_Values_Offset));
		NativeReflection.DestroyValue_InContainer(GetTransformationKeys_Values_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetTimeAtFrame")]
	public unsafe static void GetTimeAtFrame(UAnimSequenceBase AnimationSequenceBase, int Frame, out float Time)
	{
		if (!GetTimeAtFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetTimeAtFrame");
			Time = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTimeAtFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTimeAtFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetTimeAtFrame_AnimationSequenceBase_Offset), 0, GetTimeAtFrame_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTimeAtFrame_Frame_Offset), 0, GetTimeAtFrame_Frame_PropertyAddress.Address, Frame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTimeAtFrame_FunctionAddress, intPtr, GetTimeAtFrame_ParamsSize);
		Time = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTimeAtFrame_Time_Offset), 0, GetTimeAtFrame_Time_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetSequenceLength")]
	public unsafe static void GetSequenceLength(UAnimSequenceBase AnimationSequenceBase, out float Length)
	{
		if (!GetSequenceLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetSequenceLength");
			Length = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequenceLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequenceLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetSequenceLength_AnimationSequenceBase_Offset), 0, GetSequenceLength_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSequenceLength_FunctionAddress, intPtr, GetSequenceLength_ParamsSize);
		Length = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSequenceLength_Length_Offset), 0, GetSequenceLength_Length_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRootMotionLockType")]
	public unsafe static void GetRootMotionLockType(UAnimSequence AnimationSequence, out ERootMotionRootLock LockType)
	{
		if (!GetRootMotionLockType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRootMotionLockType");
			LockType = ERootMotionRootLock.RefPose;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRootMotionLockType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRootMotionLockType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetRootMotionLockType_AnimationSequence_Offset), 0, GetRootMotionLockType_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRootMotionLockType_FunctionAddress, intPtr, GetRootMotionLockType_ParamsSize);
		LockType = EnumMarshaler<ERootMotionRootLock>.FromNative(IntPtr.Add(intPtr, GetRootMotionLockType_LockType_Offset), 0, GetRootMotionLockType_LockType_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRawTrackScaleData")]
	public unsafe static void GetRawTrackScaleData(UAnimSequenceBase AnimationSequenceBase, FName TrackName, out List<FVector> ScaleData)
	{
		if (!GetRawTrackScaleData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRawTrackScaleData");
			ScaleData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRawTrackScaleData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRawTrackScaleData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetRawTrackScaleData_AnimationSequenceBase_Offset), 0, GetRawTrackScaleData_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRawTrackScaleData_TrackName_Offset), 0, GetRawTrackScaleData_TrackName_PropertyAddress.Address, TrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRawTrackScaleData_FunctionAddress, intPtr, GetRawTrackScaleData_ParamsSize);
		ScaleData = new TArrayCopyMarshaler<FVector>(1, GetRawTrackScaleData_ScaleData_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetRawTrackScaleData_ScaleData_Offset));
		NativeReflection.DestroyValue_InContainer(GetRawTrackScaleData_ScaleData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRawTrackRotationData")]
	public unsafe static void GetRawTrackRotationData(UAnimSequenceBase AnimationSequenceBase, FName TrackName, out List<FQuat> RotationData)
	{
		if (!GetRawTrackRotationData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRawTrackRotationData");
			RotationData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRawTrackRotationData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRawTrackRotationData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetRawTrackRotationData_AnimationSequenceBase_Offset), 0, GetRawTrackRotationData_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRawTrackRotationData_TrackName_Offset), 0, GetRawTrackRotationData_TrackName_PropertyAddress.Address, TrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRawTrackRotationData_FunctionAddress, intPtr, GetRawTrackRotationData_ParamsSize);
		RotationData = new TArrayCopyMarshaler<FQuat>(1, GetRawTrackRotationData_RotationData_PropertyAddress, CachedMarshalingDelegates<FQuat, BlittableTypeMarshaler<FQuat>>.FromNative, CachedMarshalingDelegates<FQuat, BlittableTypeMarshaler<FQuat>>.ToNative).FromNative(IntPtr.Add(intPtr, GetRawTrackRotationData_RotationData_Offset));
		NativeReflection.DestroyValue_InContainer(GetRawTrackRotationData_RotationData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRawTrackPositionData")]
	public unsafe static void GetRawTrackPositionData(UAnimSequenceBase AnimationSequenceBase, FName TrackName, out List<FVector> PositionData)
	{
		if (!GetRawTrackPositionData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRawTrackPositionData");
			PositionData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRawTrackPositionData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRawTrackPositionData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetRawTrackPositionData_AnimationSequenceBase_Offset), 0, GetRawTrackPositionData_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRawTrackPositionData_TrackName_Offset), 0, GetRawTrackPositionData_TrackName_PropertyAddress.Address, TrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRawTrackPositionData_FunctionAddress, intPtr, GetRawTrackPositionData_ParamsSize);
		PositionData = new TArrayCopyMarshaler<FVector>(1, GetRawTrackPositionData_PositionData_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetRawTrackPositionData_PositionData_Offset));
		NativeReflection.DestroyValue_InContainer(GetRawTrackPositionData_PositionData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRawTrackData")]
	public unsafe static void GetRawTrackData(UAnimSequenceBase AnimationSequenceBase, FName TrackName, out List<FVector> PositionKeys, out List<FQuat> RotationKeys, out List<FVector> ScalingKeys)
	{
		if (!GetRawTrackData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRawTrackData");
			PositionKeys = null;
			RotationKeys = null;
			ScalingKeys = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRawTrackData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRawTrackData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetRawTrackData_AnimationSequenceBase_Offset), 0, GetRawTrackData_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRawTrackData_TrackName_Offset), 0, GetRawTrackData_TrackName_PropertyAddress.Address, TrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRawTrackData_FunctionAddress, intPtr, GetRawTrackData_ParamsSize);
		PositionKeys = new TArrayCopyMarshaler<FVector>(1, GetRawTrackData_PositionKeys_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetRawTrackData_PositionKeys_Offset));
		NativeReflection.DestroyValue_InContainer(GetRawTrackData_PositionKeys_PropertyAddress.Address, intPtr);
		RotationKeys = new TArrayCopyMarshaler<FQuat>(1, GetRawTrackData_RotationKeys_PropertyAddress, CachedMarshalingDelegates<FQuat, BlittableTypeMarshaler<FQuat>>.FromNative, CachedMarshalingDelegates<FQuat, BlittableTypeMarshaler<FQuat>>.ToNative).FromNative(IntPtr.Add(intPtr, GetRawTrackData_RotationKeys_Offset));
		NativeReflection.DestroyValue_InContainer(GetRawTrackData_RotationKeys_PropertyAddress.Address, intPtr);
		ScalingKeys = new TArrayCopyMarshaler<FVector>(1, GetRawTrackData_ScalingKeys_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetRawTrackData_ScalingKeys_Offset));
		NativeReflection.DestroyValue_InContainer(GetRawTrackData_ScalingKeys_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRateScale")]
	public unsafe static void GetRateScale(UAnimSequenceBase AnimationSequenceBase, out float RateScale)
	{
		if (!GetRateScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRateScale");
			RateScale = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRateScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRateScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetRateScale_AnimationSequenceBase_Offset), 0, GetRateScale_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRateScale_FunctionAddress, intPtr, GetRateScale_ParamsSize);
		RateScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRateScale_RateScale_Offset), 0, GetRateScale_RateScale_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetNumKeys")]
	public unsafe static void GetNumKeys(UAnimSequenceBase AnimationSequenceBase, out int NumKeys)
	{
		if (!GetNumKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetNumKeys");
			NumKeys = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetNumKeys_AnimationSequenceBase_Offset), 0, GetNumKeys_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumKeys_FunctionAddress, intPtr, GetNumKeys_ParamsSize);
		NumKeys = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumKeys_NumKeys_Offset), 0, GetNumKeys_NumKeys_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetNumFrames")]
	public unsafe static void GetNumFrames(UAnimSequenceBase AnimationSequenceBase, out int NumFrames)
	{
		if (!GetNumFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetNumFrames");
			NumFrames = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetNumFrames_AnimationSequenceBase_Offset), 0, GetNumFrames_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumFrames_FunctionAddress, intPtr, GetNumFrames_ParamsSize);
		NumFrames = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumFrames_NumFrames_Offset), 0, GetNumFrames_NumFrames_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetNodesOfClass")]
	public unsafe static void GetNodesOfClass(UAnimBlueprint AnimationBlueprint, TSubclassOf<UAnimGraphNode_Base> NodeClass, out List<UAnimGraphNode_Base> GraphNodes, bool bIncludeChildClasses = true)
	{
		if (!GetNodesOfClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetNodesOfClass");
			GraphNodes = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodesOfClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodesOfClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimBlueprint>.ToNative(IntPtr.Add(intPtr, GetNodesOfClass_AnimationBlueprint_Offset), 0, GetNodesOfClass_AnimationBlueprint_PropertyAddress.Address, AnimationBlueprint);
		TSubclassOfMarshaler<UAnimGraphNode_Base>.ToNative(IntPtr.Add(intPtr, GetNodesOfClass_NodeClass_Offset), 0, GetNodesOfClass_NodeClass_PropertyAddress.Address, NodeClass);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetNodesOfClass_bIncludeChildClasses_Offset), 0, GetNodesOfClass_bIncludeChildClasses_PropertyAddress.Address, bIncludeChildClasses);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNodesOfClass_FunctionAddress, intPtr, GetNodesOfClass_ParamsSize);
		GraphNodes = new TArrayCopyMarshaler<UAnimGraphNode_Base>(1, GetNodesOfClass_GraphNodes_PropertyAddress, CachedMarshalingDelegates<UAnimGraphNode_Base, UObjectMarshaler<UAnimGraphNode_Base>>.FromNative, CachedMarshalingDelegates<UAnimGraphNode_Base, UObjectMarshaler<UAnimGraphNode_Base>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNodesOfClass_GraphNodes_Offset));
		NativeReflection.DestroyValue_InContainer(GetNodesOfClass_GraphNodes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetMetaDataOfClass")]
	public unsafe static void GetMetaDataOfClass(UAnimationAsset AnimationAsset, TSubclassOf<UAnimMetaData> MetaDataClass, out List<UAnimMetaData> MetaDataOfClass)
	{
		if (!GetMetaDataOfClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetMetaDataOfClass");
			MetaDataOfClass = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMetaDataOfClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMetaDataOfClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(intPtr, GetMetaDataOfClass_AnimationAsset_Offset), 0, GetMetaDataOfClass_AnimationAsset_PropertyAddress.Address, AnimationAsset);
		TSubclassOfMarshaler<UAnimMetaData>.ToNative(IntPtr.Add(intPtr, GetMetaDataOfClass_MetaDataClass_Offset), 0, GetMetaDataOfClass_MetaDataClass_PropertyAddress.Address, MetaDataClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMetaDataOfClass_FunctionAddress, intPtr, GetMetaDataOfClass_ParamsSize);
		MetaDataOfClass = new TArrayCopyMarshaler<UAnimMetaData>(1, GetMetaDataOfClass_MetaDataOfClass_PropertyAddress, CachedMarshalingDelegates<UAnimMetaData, UObjectMarshaler<UAnimMetaData>>.FromNative, CachedMarshalingDelegates<UAnimMetaData, UObjectMarshaler<UAnimMetaData>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMetaDataOfClass_MetaDataOfClass_Offset));
		NativeReflection.DestroyValue_InContainer(GetMetaDataOfClass_MetaDataOfClass_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetMetaData")]
	public unsafe static void GetMetaData(UAnimationAsset AnimationAsset, out List<UAnimMetaData> MetaData)
	{
		if (!GetMetaData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetMetaData");
			MetaData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMetaData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMetaData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(intPtr, GetMetaData_AnimationAsset_Offset), 0, GetMetaData_AnimationAsset_PropertyAddress.Address, AnimationAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMetaData_FunctionAddress, intPtr, GetMetaData_ParamsSize);
		MetaData = new TArrayCopyMarshaler<UAnimMetaData>(1, GetMetaData_MetaData_PropertyAddress, CachedMarshalingDelegates<UAnimMetaData, UObjectMarshaler<UAnimMetaData>>.FromNative, CachedMarshalingDelegates<UAnimMetaData, UObjectMarshaler<UAnimMetaData>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMetaData_MetaData_Offset));
		NativeReflection.DestroyValue_InContainer(GetMetaData_MetaData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetFrameAtTime")]
	public unsafe static void GetFrameAtTime(UAnimSequenceBase AnimationSequenceBase, float Time, out int Frame)
	{
		if (!GetFrameAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetFrameAtTime");
			Frame = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFrameAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFrameAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetFrameAtTime_AnimationSequenceBase_Offset), 0, GetFrameAtTime_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetFrameAtTime_Time_Offset), 0, GetFrameAtTime_Time_PropertyAddress.Address, Time);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFrameAtTime_FunctionAddress, intPtr, GetFrameAtTime_ParamsSize);
		Frame = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetFrameAtTime_Frame_Offset), 0, GetFrameAtTime_Frame_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetFloatKeys")]
	public unsafe static void GetFloatKeys(UAnimSequence AnimationSequence, FName CurveName, out List<float> Times, out List<float> Values)
	{
		if (!GetFloatKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetFloatKeys");
			Times = null;
			Values = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloatKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloatKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetFloatKeys_AnimationSequence_Offset), 0, GetFloatKeys_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetFloatKeys_CurveName_Offset), 0, GetFloatKeys_CurveName_PropertyAddress.Address, CurveName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFloatKeys_FunctionAddress, intPtr, GetFloatKeys_ParamsSize);
		Times = new TArrayCopyMarshaler<float>(1, GetFloatKeys_Times_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetFloatKeys_Times_Offset));
		NativeReflection.DestroyValue_InContainer(GetFloatKeys_Times_PropertyAddress.Address, intPtr);
		Values = new TArrayCopyMarshaler<float>(1, GetFloatKeys_Values_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetFloatKeys_Values_Offset));
		NativeReflection.DestroyValue_InContainer(GetFloatKeys_Values_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetCurveCompressionSettings")]
	public unsafe static void GetCurveCompressionSettings(UAnimSequence AnimationSequence, out UAnimCurveCompressionSettings CompressionSettings)
	{
		if (!GetCurveCompressionSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetCurveCompressionSettings");
			CompressionSettings = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurveCompressionSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurveCompressionSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetCurveCompressionSettings_AnimationSequence_Offset), 0, GetCurveCompressionSettings_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurveCompressionSettings_FunctionAddress, intPtr, GetCurveCompressionSettings_ParamsSize);
		CompressionSettings = UObjectMarshaler<UAnimCurveCompressionSettings>.FromNative(IntPtr.Add(intPtr, GetCurveCompressionSettings_CompressionSettings_Offset), 0, GetCurveCompressionSettings_CompressionSettings_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBonePosesForTime")]
	public unsafe static void GetBonePosesForTime(UAnimSequenceBase AnimationSequenceBase, List<FName> BoneNames, float Time, bool bExtractRootMotion, out List<FTransform> Poses, USkeletalMesh PreviewMesh)
	{
		if (!GetBonePosesForTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBonePosesForTime");
			Poses = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBonePosesForTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBonePosesForTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetBonePosesForTime_AnimationSequenceBase_Offset), 0, GetBonePosesForTime_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		new TArrayCopyMarshaler<FName>(1, GetBonePosesForTime_BoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, GetBonePosesForTime_BoneNames_Offset), BoneNames);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetBonePosesForTime_Time_Offset), 0, GetBonePosesForTime_Time_PropertyAddress.Address, Time);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetBonePosesForTime_bExtractRootMotion_Offset), 0, GetBonePosesForTime_bExtractRootMotion_PropertyAddress.Address, bExtractRootMotion);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetBonePosesForTime_PreviewMesh_Offset), 0, GetBonePosesForTime_PreviewMesh_PropertyAddress.Address, PreviewMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBonePosesForTime_FunctionAddress, intPtr, GetBonePosesForTime_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBonePosesForTime_BoneNames_PropertyAddress.Address, intPtr);
		Poses = new TArrayCopyMarshaler<FTransform>(1, GetBonePosesForTime_Poses_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBonePosesForTime_Poses_Offset));
		NativeReflection.DestroyValue_InContainer(GetBonePosesForTime_Poses_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBonePosesForFrame")]
	public unsafe static void GetBonePosesForFrame(UAnimSequenceBase AnimationSequenceBase, List<FName> BoneNames, int Frame, bool bExtractRootMotion, out List<FTransform> Poses, USkeletalMesh PreviewMesh)
	{
		if (!GetBonePosesForFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBonePosesForFrame");
			Poses = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBonePosesForFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBonePosesForFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetBonePosesForFrame_AnimationSequenceBase_Offset), 0, GetBonePosesForFrame_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		new TArrayCopyMarshaler<FName>(1, GetBonePosesForFrame_BoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, GetBonePosesForFrame_BoneNames_Offset), BoneNames);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBonePosesForFrame_Frame_Offset), 0, GetBonePosesForFrame_Frame_PropertyAddress.Address, Frame);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetBonePosesForFrame_bExtractRootMotion_Offset), 0, GetBonePosesForFrame_bExtractRootMotion_PropertyAddress.Address, bExtractRootMotion);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, GetBonePosesForFrame_PreviewMesh_Offset), 0, GetBonePosesForFrame_PreviewMesh_PropertyAddress.Address, PreviewMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBonePosesForFrame_FunctionAddress, intPtr, GetBonePosesForFrame_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBonePosesForFrame_BoneNames_PropertyAddress.Address, intPtr);
		Poses = new TArrayCopyMarshaler<FTransform>(1, GetBonePosesForFrame_Poses_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBonePosesForFrame_Poses_Offset));
		NativeReflection.DestroyValue_InContainer(GetBonePosesForFrame_Poses_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBonePoseForTime")]
	public unsafe static void GetBonePoseForTime(UAnimSequenceBase AnimationSequenceBase, FName BoneName, float Time, bool bExtractRootMotion, out FTransform Pose)
	{
		if (!GetBonePoseForTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBonePoseForTime");
			Pose = default(FTransform);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBonePoseForTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBonePoseForTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetBonePoseForTime_AnimationSequenceBase_Offset), 0, GetBonePoseForTime_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBonePoseForTime_BoneName_Offset), 0, GetBonePoseForTime_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetBonePoseForTime_Time_Offset), 0, GetBonePoseForTime_Time_PropertyAddress.Address, Time);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetBonePoseForTime_bExtractRootMotion_Offset), 0, GetBonePoseForTime_bExtractRootMotion_PropertyAddress.Address, bExtractRootMotion);
		NativeReflection.InitializeValue_InContainer(GetBonePoseForTime_Pose_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBonePoseForTime_FunctionAddress, intPtr, GetBonePoseForTime_ParamsSize);
		Pose = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetBonePoseForTime_Pose_Offset), 0, GetBonePoseForTime_Pose_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBonePoseForFrame")]
	public unsafe static void GetBonePoseForFrame(UAnimSequenceBase AnimationSequenceBase, FName BoneName, int Frame, bool bExtractRootMotion, out FTransform Pose)
	{
		if (!GetBonePoseForFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBonePoseForFrame");
			Pose = default(FTransform);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBonePoseForFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBonePoseForFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetBonePoseForFrame_AnimationSequenceBase_Offset), 0, GetBonePoseForFrame_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBonePoseForFrame_BoneName_Offset), 0, GetBonePoseForFrame_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBonePoseForFrame_Frame_Offset), 0, GetBonePoseForFrame_Frame_PropertyAddress.Address, Frame);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetBonePoseForFrame_bExtractRootMotion_Offset), 0, GetBonePoseForFrame_bExtractRootMotion_PropertyAddress.Address, bExtractRootMotion);
		NativeReflection.InitializeValue_InContainer(GetBonePoseForFrame_Pose_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBonePoseForFrame_FunctionAddress, intPtr, GetBonePoseForFrame_ParamsSize);
		Pose = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetBonePoseForFrame_Pose_Offset), 0, GetBonePoseForFrame_Pose_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBoneCompressionSettings")]
	public unsafe static void GetBoneCompressionSettings(UAnimSequence AnimationSequence, out UAnimBoneCompressionSettings CompressionSettings)
	{
		if (!GetBoneCompressionSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBoneCompressionSettings");
			CompressionSettings = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneCompressionSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneCompressionSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetBoneCompressionSettings_AnimationSequence_Offset), 0, GetBoneCompressionSettings_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoneCompressionSettings_FunctionAddress, intPtr, GetBoneCompressionSettings_ParamsSize);
		CompressionSettings = UObjectMarshaler<UAnimBoneCompressionSettings>.FromNative(IntPtr.Add(intPtr, GetBoneCompressionSettings_CompressionSettings_Offset), 0, GetBoneCompressionSettings_CompressionSettings_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimNotifyEventTriggerTime")]
	public unsafe static float GetAnimNotifyEventTriggerTime(FAnimNotifyEvent NotifyEvent)
	{
		if (!GetAnimNotifyEventTriggerTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimNotifyEventTriggerTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimNotifyEventTriggerTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimNotifyEventTriggerTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAnimNotifyEventTriggerTime_NotifyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimNotifyEvent>.ToNative(IntPtr.Add(intPtr, GetAnimNotifyEventTriggerTime_NotifyEvent_Offset), 0, GetAnimNotifyEventTriggerTime_NotifyEvent_PropertyAddress.Address, NotifyEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimNotifyEventTriggerTime_FunctionAddress, intPtr, GetAnimNotifyEventTriggerTime_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAnimNotifyEventTriggerTime_NotifyEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAnimNotifyEventTriggerTime_ReturnValue_Offset), 0, GetAnimNotifyEventTriggerTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimNotifyEventDuration")]
	public unsafe static float GetAnimNotifyEventDuration(FAnimNotifyEvent NotifyEvent)
	{
		if (!GetAnimNotifyEventDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimNotifyEventDuration");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimNotifyEventDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimNotifyEventDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAnimNotifyEventDuration_NotifyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimNotifyEvent>.ToNative(IntPtr.Add(intPtr, GetAnimNotifyEventDuration_NotifyEvent_Offset), 0, GetAnimNotifyEventDuration_NotifyEvent_PropertyAddress.Address, NotifyEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimNotifyEventDuration_FunctionAddress, intPtr, GetAnimNotifyEventDuration_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAnimNotifyEventDuration_NotifyEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAnimNotifyEventDuration_ReturnValue_Offset), 0, GetAnimNotifyEventDuration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationTrackNames")]
	public unsafe static void GetAnimationTrackNames(UAnimSequenceBase AnimationSequenceBase, out List<FName> TrackNames)
	{
		if (!GetAnimationTrackNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationTrackNames");
			TrackNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationTrackNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationTrackNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetAnimationTrackNames_AnimationSequenceBase_Offset), 0, GetAnimationTrackNames_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationTrackNames_FunctionAddress, intPtr, GetAnimationTrackNames_ParamsSize);
		TrackNames = new TArrayCopyMarshaler<FName>(1, GetAnimationTrackNames_TrackNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAnimationTrackNames_TrackNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetAnimationTrackNames_TrackNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationSyncMarkersForTrack")]
	public unsafe static void GetAnimationSyncMarkersForTrack(UAnimSequence AnimationSequence, FName NotifyTrackName, out List<FAnimSyncMarker> Markers)
	{
		if (!GetAnimationSyncMarkersForTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationSyncMarkersForTrack");
			Markers = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationSyncMarkersForTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationSyncMarkersForTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAnimationSyncMarkersForTrack_AnimationSequence_Offset), 0, GetAnimationSyncMarkersForTrack_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAnimationSyncMarkersForTrack_NotifyTrackName_Offset), 0, GetAnimationSyncMarkersForTrack_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationSyncMarkersForTrack_FunctionAddress, intPtr, GetAnimationSyncMarkersForTrack_ParamsSize);
		Markers = new TArrayCopyMarshaler<FAnimSyncMarker>(1, GetAnimationSyncMarkersForTrack_Markers_PropertyAddress, CachedMarshalingDelegates<FAnimSyncMarker, FAnimSyncMarker>.FromNative, CachedMarshalingDelegates<FAnimSyncMarker, FAnimSyncMarker>.ToNative).FromNative(IntPtr.Add(intPtr, GetAnimationSyncMarkersForTrack_Markers_Offset));
		NativeReflection.DestroyValue_InContainer(GetAnimationSyncMarkersForTrack_Markers_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationSyncMarkers")]
	public unsafe static void GetAnimationSyncMarkers(UAnimSequence AnimationSequence, out List<FAnimSyncMarker> Markers)
	{
		if (!GetAnimationSyncMarkers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationSyncMarkers");
			Markers = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationSyncMarkers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationSyncMarkers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAnimationSyncMarkers_AnimationSequence_Offset), 0, GetAnimationSyncMarkers_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationSyncMarkers_FunctionAddress, intPtr, GetAnimationSyncMarkers_ParamsSize);
		Markers = new TArrayCopyMarshaler<FAnimSyncMarker>(1, GetAnimationSyncMarkers_Markers_PropertyAddress, CachedMarshalingDelegates<FAnimSyncMarker, FAnimSyncMarker>.FromNative, CachedMarshalingDelegates<FAnimSyncMarker, FAnimSyncMarker>.ToNative).FromNative(IntPtr.Add(intPtr, GetAnimationSyncMarkers_Markers_Offset));
		NativeReflection.DestroyValue_InContainer(GetAnimationSyncMarkers_Markers_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationNotifyTrackNames")]
	public unsafe static void GetAnimationNotifyTrackNames(UAnimSequenceBase AnimationSequenceBase, out List<FName> TrackNames)
	{
		if (!GetAnimationNotifyTrackNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationNotifyTrackNames");
			TrackNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationNotifyTrackNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationNotifyTrackNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetAnimationNotifyTrackNames_AnimationSequenceBase_Offset), 0, GetAnimationNotifyTrackNames_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationNotifyTrackNames_FunctionAddress, intPtr, GetAnimationNotifyTrackNames_ParamsSize);
		TrackNames = new TArrayCopyMarshaler<FName>(1, GetAnimationNotifyTrackNames_TrackNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAnimationNotifyTrackNames_TrackNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetAnimationNotifyTrackNames_TrackNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationNotifyEventsForTrack")]
	public unsafe static void GetAnimationNotifyEventsForTrack(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName, out List<FAnimNotifyEvent> Events)
	{
		if (!GetAnimationNotifyEventsForTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationNotifyEventsForTrack");
			Events = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationNotifyEventsForTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationNotifyEventsForTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetAnimationNotifyEventsForTrack_AnimationSequenceBase_Offset), 0, GetAnimationNotifyEventsForTrack_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAnimationNotifyEventsForTrack_NotifyTrackName_Offset), 0, GetAnimationNotifyEventsForTrack_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationNotifyEventsForTrack_FunctionAddress, intPtr, GetAnimationNotifyEventsForTrack_ParamsSize);
		Events = new TArrayCopyMarshaler<FAnimNotifyEvent>(1, GetAnimationNotifyEventsForTrack_Events_PropertyAddress, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.FromNative, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAnimationNotifyEventsForTrack_Events_Offset));
		NativeReflection.DestroyValue_InContainer(GetAnimationNotifyEventsForTrack_Events_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationNotifyEvents")]
	public unsafe static void GetAnimationNotifyEvents(UAnimSequenceBase AnimationSequenceBase, out List<FAnimNotifyEvent> NotifyEvents)
	{
		if (!GetAnimationNotifyEvents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationNotifyEvents");
			NotifyEvents = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationNotifyEvents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationNotifyEvents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetAnimationNotifyEvents_AnimationSequenceBase_Offset), 0, GetAnimationNotifyEvents_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationNotifyEvents_FunctionAddress, intPtr, GetAnimationNotifyEvents_ParamsSize);
		NotifyEvents = new TArrayCopyMarshaler<FAnimNotifyEvent>(1, GetAnimationNotifyEvents_NotifyEvents_PropertyAddress, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.FromNative, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAnimationNotifyEvents_NotifyEvents_Offset));
		NativeReflection.DestroyValue_InContainer(GetAnimationNotifyEvents_NotifyEvents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationNotifyEventNames")]
	public unsafe static void GetAnimationNotifyEventNames(UAnimSequenceBase AnimationSequenceBase, out List<FName> EventNames)
	{
		if (!GetAnimationNotifyEventNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationNotifyEventNames");
			EventNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationNotifyEventNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationNotifyEventNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetAnimationNotifyEventNames_AnimationSequenceBase_Offset), 0, GetAnimationNotifyEventNames_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationNotifyEventNames_FunctionAddress, intPtr, GetAnimationNotifyEventNames_ParamsSize);
		EventNames = new TArrayCopyMarshaler<FName>(1, GetAnimationNotifyEventNames_EventNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAnimationNotifyEventNames_EventNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetAnimationNotifyEventNames_EventNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationInterpolationType")]
	public unsafe static void GetAnimationInterpolationType(UAnimSequence AnimationSequence, out EAnimInterpolationType InterpolationType)
	{
		if (!GetAnimationInterpolationType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationInterpolationType");
			InterpolationType = EAnimInterpolationType.Linear;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationInterpolationType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationInterpolationType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAnimationInterpolationType_AnimationSequence_Offset), 0, GetAnimationInterpolationType_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationInterpolationType_FunctionAddress, intPtr, GetAnimationInterpolationType_ParamsSize);
		InterpolationType = EnumMarshaler<EAnimInterpolationType>.FromNative(IntPtr.Add(intPtr, GetAnimationInterpolationType_InterpolationType_Offset), 0, GetAnimationInterpolationType_InterpolationType_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationGraphs")]
	public unsafe static void GetAnimationGraphs(UAnimBlueprint AnimationBlueprint, out List<UAnimationGraph> AnimationGraphs)
	{
		if (!GetAnimationGraphs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationGraphs");
			AnimationGraphs = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationGraphs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationGraphs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimBlueprint>.ToNative(IntPtr.Add(intPtr, GetAnimationGraphs_AnimationBlueprint_Offset), 0, GetAnimationGraphs_AnimationBlueprint_PropertyAddress.Address, AnimationBlueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationGraphs_FunctionAddress, intPtr, GetAnimationGraphs_ParamsSize);
		AnimationGraphs = new TArrayCopyMarshaler<UAnimationGraph>(1, GetAnimationGraphs_AnimationGraphs_PropertyAddress, CachedMarshalingDelegates<UAnimationGraph, UObjectMarshaler<UAnimationGraph>>.FromNative, CachedMarshalingDelegates<UAnimationGraph, UObjectMarshaler<UAnimationGraph>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAnimationGraphs_AnimationGraphs_Offset));
		NativeReflection.DestroyValue_InContainer(GetAnimationGraphs_AnimationGraphs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationCurveNames")]
	public unsafe static void GetAnimationCurveNames(UAnimSequence AnimationSequence, ERawCurveTrackTypes CurveType, out List<FName> CurveNames)
	{
		if (!GetAnimationCurveNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationCurveNames");
			CurveNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationCurveNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationCurveNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAnimationCurveNames_AnimationSequence_Offset), 0, GetAnimationCurveNames_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		EnumMarshaler<ERawCurveTrackTypes>.ToNative(IntPtr.Add(intPtr, GetAnimationCurveNames_CurveType_Offset), 0, GetAnimationCurveNames_CurveType_PropertyAddress.Address, CurveType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationCurveNames_FunctionAddress, intPtr, GetAnimationCurveNames_ParamsSize);
		CurveNames = new TArrayCopyMarshaler<FName>(1, GetAnimationCurveNames_CurveNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAnimationCurveNames_CurveNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetAnimationCurveNames_CurveNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAdditiveBasePoseType")]
	public unsafe static void GetAdditiveBasePoseType(UAnimSequence AnimationSequence, out EAdditiveBasePoseType AdditiveBasePoseType)
	{
		if (!GetAdditiveBasePoseType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAdditiveBasePoseType");
			AdditiveBasePoseType = EAdditiveBasePoseType.ABPT_None;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAdditiveBasePoseType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAdditiveBasePoseType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAdditiveBasePoseType_AnimationSequence_Offset), 0, GetAdditiveBasePoseType_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAdditiveBasePoseType_FunctionAddress, intPtr, GetAdditiveBasePoseType_ParamsSize);
		AdditiveBasePoseType = EnumMarshaler<EAdditiveBasePoseType>.FromNative(IntPtr.Add(intPtr, GetAdditiveBasePoseType_AdditiveBasePoseType_Offset), 0, GetAdditiveBasePoseType_AdditiveBasePoseType_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAdditiveAnimationType")]
	public unsafe static void GetAdditiveAnimationType(UAnimSequence AnimationSequence, out EAdditiveAnimationType AdditiveAnimationType)
	{
		if (!GetAdditiveAnimationType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAdditiveAnimationType");
			AdditiveAnimationType = EAdditiveAnimationType.AAT_None;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAdditiveAnimationType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAdditiveAnimationType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAdditiveAnimationType_AnimationSequence_Offset), 0, GetAdditiveAnimationType_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAdditiveAnimationType_FunctionAddress, intPtr, GetAdditiveAnimationType_ParamsSize);
		AdditiveAnimationType = EnumMarshaler<EAdditiveAnimationType>.FromNative(IntPtr.Add(intPtr, GetAdditiveAnimationType_AdditiveAnimationType_Offset), 0, GetAdditiveAnimationType_AdditiveAnimationType_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:FindBonePathToRoot")]
	public unsafe static void FindBonePathToRoot(UAnimSequenceBase AnimationSequenceBase, FName BoneName, out List<FName> BonePath)
	{
		if (!FindBonePathToRoot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:FindBonePathToRoot");
			BonePath = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindBonePathToRoot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindBonePathToRoot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, FindBonePathToRoot_AnimationSequenceBase_Offset), 0, FindBonePathToRoot_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindBonePathToRoot_BoneName_Offset), 0, FindBonePathToRoot_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindBonePathToRoot_FunctionAddress, intPtr, FindBonePathToRoot_ParamsSize);
		BonePath = new TArrayCopyMarshaler<FName>(1, FindBonePathToRoot_BonePath_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, FindBonePathToRoot_BonePath_Offset));
		NativeReflection.DestroyValue_InContainer(FindBonePathToRoot_BonePath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:EvaluateRootBoneTimecodeAttributesAtTime")]
	public unsafe static bool EvaluateRootBoneTimecodeAttributesAtTime(UAnimSequenceBase AnimationSequenceBase, float EvalTime, out FQualifiedTime OutQualifiedFrameTime)
	{
		if (!EvaluateRootBoneTimecodeAttributesAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:EvaluateRootBoneTimecodeAttributesAtTime");
			OutQualifiedFrameTime = default(FQualifiedTime);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EvaluateRootBoneTimecodeAttributesAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EvaluateRootBoneTimecodeAttributesAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, EvaluateRootBoneTimecodeAttributesAtTime_AnimationSequenceBase_Offset), 0, EvaluateRootBoneTimecodeAttributesAtTime_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EvaluateRootBoneTimecodeAttributesAtTime_EvalTime_Offset), 0, EvaluateRootBoneTimecodeAttributesAtTime_EvalTime_PropertyAddress.Address, EvalTime);
		NativeReflection.InitializeValue_InContainer(EvaluateRootBoneTimecodeAttributesAtTime_OutQualifiedFrameTime_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress, intPtr, EvaluateRootBoneTimecodeAttributesAtTime_ParamsSize);
		OutQualifiedFrameTime = FQualifiedTime.FromNative(IntPtr.Add(intPtr, EvaluateRootBoneTimecodeAttributesAtTime_OutQualifiedFrameTime_Offset), 0, EvaluateRootBoneTimecodeAttributesAtTime_OutQualifiedFrameTime_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EvaluateRootBoneTimecodeAttributesAtTime_ReturnValue_Offset), 0, EvaluateRootBoneTimecodeAttributesAtTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:DoesCurveExist")]
	public unsafe static bool DoesCurveExist(UAnimSequence AnimationSequence, FName CurveName, ERawCurveTrackTypes CurveType)
	{
		if (!DoesCurveExist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:DoesCurveExist");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoesCurveExist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoesCurveExist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, DoesCurveExist_AnimationSequence_Offset), 0, DoesCurveExist_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DoesCurveExist_CurveName_Offset), 0, DoesCurveExist_CurveName_PropertyAddress.Address, CurveName);
		EnumMarshaler<ERawCurveTrackTypes>.ToNative(IntPtr.Add(intPtr, DoesCurveExist_CurveType_Offset), 0, DoesCurveExist_CurveType_PropertyAddress.Address, CurveType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DoesCurveExist_FunctionAddress, intPtr, DoesCurveExist_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoesCurveExist_ReturnValue_Offset), 0, DoesCurveExist_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:DoesBoneNameExist")]
	public unsafe static void DoesBoneNameExist(UAnimSequence AnimationSequence, FName BoneName, out bool bExists)
	{
		if (!DoesBoneNameExist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:DoesBoneNameExist");
			bExists = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoesBoneNameExist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoesBoneNameExist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, DoesBoneNameExist_AnimationSequence_Offset), 0, DoesBoneNameExist_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DoesBoneNameExist_BoneName_Offset), 0, DoesBoneNameExist_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DoesBoneNameExist_FunctionAddress, intPtr, DoesBoneNameExist_ParamsSize);
		bExists = BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoesBoneNameExist_bExists_Offset), 0, DoesBoneNameExist_bExists_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:CopyAnimNotifiesFromSequence")]
	public unsafe static void CopyAnimNotifiesFromSequence(UAnimSequenceBase SourceAnimationSequenceBase, UAnimSequenceBase DestinationAnimationSequenceBase, bool bDeleteExistingNotifies = false)
	{
		if (!CopyAnimNotifiesFromSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:CopyAnimNotifiesFromSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyAnimNotifiesFromSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyAnimNotifiesFromSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, CopyAnimNotifiesFromSequence_SourceAnimationSequenceBase_Offset), 0, CopyAnimNotifiesFromSequence_SourceAnimationSequenceBase_PropertyAddress.Address, SourceAnimationSequenceBase);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, CopyAnimNotifiesFromSequence_DestinationAnimationSequenceBase_Offset), 0, CopyAnimNotifiesFromSequence_DestinationAnimationSequenceBase_PropertyAddress.Address, DestinationAnimationSequenceBase);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CopyAnimNotifiesFromSequence_bDeleteExistingNotifies_Offset), 0, CopyAnimNotifiesFromSequence_bDeleteExistingNotifies_PropertyAddress.Address, bDeleteExistingNotifies);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyAnimNotifiesFromSequence_FunctionAddress, intPtr, CopyAnimNotifiesFromSequence_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:CopyAnimationCurveNamesToSkeleton")]
	public unsafe static void CopyAnimationCurveNamesToSkeleton(USkeleton OldSkeleton, USkeleton NewSkeleton, UAnimSequenceBase SequenceBase, ERawCurveTrackTypes CurveType)
	{
		if (!CopyAnimationCurveNamesToSkeleton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:CopyAnimationCurveNamesToSkeleton");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyAnimationCurveNamesToSkeleton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyAnimationCurveNamesToSkeleton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, CopyAnimationCurveNamesToSkeleton_OldSkeleton_Offset), 0, CopyAnimationCurveNamesToSkeleton_OldSkeleton_PropertyAddress.Address, OldSkeleton);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, CopyAnimationCurveNamesToSkeleton_NewSkeleton_Offset), 0, CopyAnimationCurveNamesToSkeleton_NewSkeleton_PropertyAddress.Address, NewSkeleton);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, CopyAnimationCurveNamesToSkeleton_SequenceBase_Offset), 0, CopyAnimationCurveNamesToSkeleton_SequenceBase_PropertyAddress.Address, SequenceBase);
		EnumMarshaler<ERawCurveTrackTypes>.ToNative(IntPtr.Add(intPtr, CopyAnimationCurveNamesToSkeleton_CurveType_Offset), 0, CopyAnimationCurveNamesToSkeleton_CurveType_PropertyAddress.Address, CurveType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyAnimationCurveNamesToSkeleton_FunctionAddress, intPtr, CopyAnimationCurveNamesToSkeleton_ParamsSize);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:ContainsMetaDataOfClass")]
	public unsafe static bool ContainsMetaDataOfClass(UAnimationAsset AnimationAsset, TSubclassOf<UAnimMetaData> MetaDataClass)
	{
		if (!ContainsMetaDataOfClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:ContainsMetaDataOfClass");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ContainsMetaDataOfClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ContainsMetaDataOfClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(intPtr, ContainsMetaDataOfClass_AnimationAsset_Offset), 0, ContainsMetaDataOfClass_AnimationAsset_PropertyAddress.Address, AnimationAsset);
		TSubclassOfMarshaler<UAnimMetaData>.ToNative(IntPtr.Add(intPtr, ContainsMetaDataOfClass_MetaDataClass_Offset), 0, ContainsMetaDataOfClass_MetaDataClass_PropertyAddress.Address, MetaDataClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ContainsMetaDataOfClass_FunctionAddress, intPtr, ContainsMetaDataOfClass_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ContainsMetaDataOfClass_ReturnValue_Offset), 0, ContainsMetaDataOfClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddVirtualBone")]
	public unsafe static void AddVirtualBone(UAnimSequence AnimationSequence, FName SourceBoneName, FName TargetBoneName, out FName VirtualBoneName)
	{
		if (!AddVirtualBone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddVirtualBone");
			VirtualBoneName = default(FName);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddVirtualBone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddVirtualBone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AddVirtualBone_AnimationSequence_Offset), 0, AddVirtualBone_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddVirtualBone_SourceBoneName_Offset), 0, AddVirtualBone_SourceBoneName_PropertyAddress.Address, SourceBoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddVirtualBone_TargetBoneName_Offset), 0, AddVirtualBone_TargetBoneName_PropertyAddress.Address, TargetBoneName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddVirtualBone_FunctionAddress, intPtr, AddVirtualBone_ParamsSize);
		VirtualBoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, AddVirtualBone_VirtualBoneName_Offset), 0, AddVirtualBone_VirtualBoneName_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddVectorCurveKeys")]
	public unsafe static void AddVectorCurveKeys(UAnimSequence AnimationSequence, FName CurveName, List<float> Times, List<FVector> Vectors)
	{
		if (!AddVectorCurveKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddVectorCurveKeys");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddVectorCurveKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddVectorCurveKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AddVectorCurveKeys_AnimationSequence_Offset), 0, AddVectorCurveKeys_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddVectorCurveKeys_CurveName_Offset), 0, AddVectorCurveKeys_CurveName_PropertyAddress.Address, CurveName);
		new TArrayCopyMarshaler<float>(1, AddVectorCurveKeys_Times_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, AddVectorCurveKeys_Times_Offset), Times);
		new TArrayCopyMarshaler<FVector>(1, AddVectorCurveKeys_Vectors_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, AddVectorCurveKeys_Vectors_Offset), Vectors);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddVectorCurveKeys_FunctionAddress, intPtr, AddVectorCurveKeys_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddVectorCurveKeys_Times_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddVectorCurveKeys_Vectors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddVectorCurveKey")]
	public unsafe static void AddVectorCurveKey(UAnimSequence AnimationSequence, FName CurveName, float Time, FVector Vector)
	{
		if (!AddVectorCurveKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddVectorCurveKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddVectorCurveKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddVectorCurveKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AddVectorCurveKey_AnimationSequence_Offset), 0, AddVectorCurveKey_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddVectorCurveKey_CurveName_Offset), 0, AddVectorCurveKey_CurveName_PropertyAddress.Address, CurveName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddVectorCurveKey_Time_Offset), 0, AddVectorCurveKey_Time_PropertyAddress.Address, Time);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddVectorCurveKey_Vector_Offset), 0, AddVectorCurveKey_Vector_PropertyAddress.Address, Vector);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddVectorCurveKey_FunctionAddress, intPtr, AddVectorCurveKey_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddTransformationCurveKeys")]
	public unsafe static void AddTransformationCurveKeys(UAnimSequence AnimationSequence, FName CurveName, List<float> Times, List<FTransform> Transforms)
	{
		if (!AddTransformationCurveKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddTransformationCurveKeys");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTransformationCurveKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTransformationCurveKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AddTransformationCurveKeys_AnimationSequence_Offset), 0, AddTransformationCurveKeys_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddTransformationCurveKeys_CurveName_Offset), 0, AddTransformationCurveKeys_CurveName_PropertyAddress.Address, CurveName);
		new TArrayCopyMarshaler<float>(1, AddTransformationCurveKeys_Times_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, AddTransformationCurveKeys_Times_Offset), Times);
		new TArrayCopyMarshaler<FTransform>(1, AddTransformationCurveKeys_Transforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(intPtr, AddTransformationCurveKeys_Transforms_Offset), Transforms);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddTransformationCurveKeys_FunctionAddress, intPtr, AddTransformationCurveKeys_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddTransformationCurveKeys_Times_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddTransformationCurveKeys_Transforms_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddTransformationCurveKey")]
	public unsafe static void AddTransformationCurveKey(UAnimSequence AnimationSequence, FName CurveName, float Time, FTransform Transform)
	{
		if (!AddTransformationCurveKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddTransformationCurveKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTransformationCurveKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTransformationCurveKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AddTransformationCurveKey_AnimationSequence_Offset), 0, AddTransformationCurveKey_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddTransformationCurveKey_CurveName_Offset), 0, AddTransformationCurveKey_CurveName_PropertyAddress.Address, CurveName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddTransformationCurveKey_Time_Offset), 0, AddTransformationCurveKey_Time_PropertyAddress.Address, Time);
		NativeReflection.InitializeValue_InContainer(AddTransformationCurveKey_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, AddTransformationCurveKey_Transform_Offset), 0, AddTransformationCurveKey_Transform_PropertyAddress.Address, Transform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddTransformationCurveKey_FunctionAddress, intPtr, AddTransformationCurveKey_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddMetaDataObject")]
	public unsafe static void AddMetaDataObject(UAnimationAsset AnimationAsset, UAnimMetaData MetaDataObject)
	{
		if (!AddMetaDataObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddMetaDataObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMetaDataObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMetaDataObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(intPtr, AddMetaDataObject_AnimationAsset_Offset), 0, AddMetaDataObject_AnimationAsset_PropertyAddress.Address, AnimationAsset);
		UObjectMarshaler<UAnimMetaData>.ToNative(IntPtr.Add(intPtr, AddMetaDataObject_MetaDataObject_Offset), 0, AddMetaDataObject_MetaDataObject_PropertyAddress.Address, MetaDataObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddMetaDataObject_FunctionAddress, intPtr, AddMetaDataObject_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddMetaData")]
	public unsafe static void AddMetaData(UAnimationAsset AnimationAsset, TSubclassOf<UAnimMetaData> MetaDataClass, out UAnimMetaData MetaDataInstance)
	{
		if (!AddMetaData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddMetaData");
			MetaDataInstance = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMetaData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMetaData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(intPtr, AddMetaData_AnimationAsset_Offset), 0, AddMetaData_AnimationAsset_PropertyAddress.Address, AnimationAsset);
		TSubclassOfMarshaler<UAnimMetaData>.ToNative(IntPtr.Add(intPtr, AddMetaData_MetaDataClass_Offset), 0, AddMetaData_MetaDataClass_PropertyAddress.Address, MetaDataClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddMetaData_FunctionAddress, intPtr, AddMetaData_ParamsSize);
		MetaDataInstance = UObjectMarshaler<UAnimMetaData>.FromNative(IntPtr.Add(intPtr, AddMetaData_MetaDataInstance_Offset), 0, AddMetaData_MetaDataInstance_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddFloatCurveKeys")]
	public unsafe static void AddFloatCurveKeys(UAnimSequence AnimationSequence, FName CurveName, List<float> Times, List<float> Values)
	{
		if (!AddFloatCurveKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddFloatCurveKeys");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFloatCurveKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFloatCurveKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AddFloatCurveKeys_AnimationSequence_Offset), 0, AddFloatCurveKeys_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddFloatCurveKeys_CurveName_Offset), 0, AddFloatCurveKeys_CurveName_PropertyAddress.Address, CurveName);
		new TArrayCopyMarshaler<float>(1, AddFloatCurveKeys_Times_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, AddFloatCurveKeys_Times_Offset), Times);
		new TArrayCopyMarshaler<float>(1, AddFloatCurveKeys_Values_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, AddFloatCurveKeys_Values_Offset), Values);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddFloatCurveKeys_FunctionAddress, intPtr, AddFloatCurveKeys_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddFloatCurveKeys_Times_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddFloatCurveKeys_Values_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddFloatCurveKey")]
	public unsafe static void AddFloatCurveKey(UAnimSequence AnimationSequence, FName CurveName, float Time, float Value)
	{
		if (!AddFloatCurveKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddFloatCurveKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFloatCurveKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFloatCurveKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AddFloatCurveKey_AnimationSequence_Offset), 0, AddFloatCurveKey_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddFloatCurveKey_CurveName_Offset), 0, AddFloatCurveKey_CurveName_PropertyAddress.Address, CurveName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddFloatCurveKey_Time_Offset), 0, AddFloatCurveKey_Time_PropertyAddress.Address, Time);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddFloatCurveKey_Value_Offset), 0, AddFloatCurveKey_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddFloatCurveKey_FunctionAddress, intPtr, AddFloatCurveKey_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddCurve")]
	public unsafe static void AddCurve(UAnimSequence AnimationSequence, FName CurveName, ERawCurveTrackTypes CurveType = ERawCurveTrackTypes.RCT_Float, bool bMetaDataCurve = false)
	{
		if (!AddCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddCurve");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AddCurve_AnimationSequence_Offset), 0, AddCurve_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddCurve_CurveName_Offset), 0, AddCurve_CurveName_PropertyAddress.Address, CurveName);
		EnumMarshaler<ERawCurveTrackTypes>.ToNative(IntPtr.Add(intPtr, AddCurve_CurveType_Offset), 0, AddCurve_CurveType_PropertyAddress.Address, CurveType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddCurve_bMetaDataCurve_Offset), 0, AddCurve_bMetaDataCurve_PropertyAddress.Address, bMetaDataCurve);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddCurve_FunctionAddress, intPtr, AddCurve_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationSyncMarker")]
	public unsafe static void AddAnimationSyncMarker(UAnimSequence AnimationSequence, FName MarkerName, float Time, FName NotifyTrackName)
	{
		if (!AddAnimationSyncMarker_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationSyncMarker");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAnimationSyncMarker_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAnimationSyncMarker_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, AddAnimationSyncMarker_AnimationSequence_Offset), 0, AddAnimationSyncMarker_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddAnimationSyncMarker_MarkerName_Offset), 0, AddAnimationSyncMarker_MarkerName_PropertyAddress.Address, MarkerName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddAnimationSyncMarker_Time_Offset), 0, AddAnimationSyncMarker_Time_PropertyAddress.Address, Time);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddAnimationSyncMarker_NotifyTrackName_Offset), 0, AddAnimationSyncMarker_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAnimationSyncMarker_FunctionAddress, intPtr, AddAnimationSyncMarker_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyTrack")]
	public unsafe static void AddAnimationNotifyTrack(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName, FLinearColor TrackColor)
	{
		if (!AddAnimationNotifyTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyTrack");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAnimationNotifyTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAnimationNotifyTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyTrack_AnimationSequenceBase_Offset), 0, AddAnimationNotifyTrack_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyTrack_NotifyTrackName_Offset), 0, AddAnimationNotifyTrack_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyTrack_TrackColor_Offset), 0, AddAnimationNotifyTrack_TrackColor_PropertyAddress.Address, TrackColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAnimationNotifyTrack_FunctionAddress, intPtr, AddAnimationNotifyTrack_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyStateEventObject")]
	public unsafe static void AddAnimationNotifyStateEventObject(UAnimSequenceBase AnimationSequenceBase, float StartTime, float Duration, UAnimNotifyState NotifyState, FName NotifyTrackName)
	{
		if (!AddAnimationNotifyStateEventObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyStateEventObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAnimationNotifyStateEventObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAnimationNotifyStateEventObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEventObject_AnimationSequenceBase_Offset), 0, AddAnimationNotifyStateEventObject_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEventObject_StartTime_Offset), 0, AddAnimationNotifyStateEventObject_StartTime_PropertyAddress.Address, StartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEventObject_Duration_Offset), 0, AddAnimationNotifyStateEventObject_Duration_PropertyAddress.Address, Duration);
		UObjectMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEventObject_NotifyState_Offset), 0, AddAnimationNotifyStateEventObject_NotifyState_PropertyAddress.Address, NotifyState);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEventObject_NotifyTrackName_Offset), 0, AddAnimationNotifyStateEventObject_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAnimationNotifyStateEventObject_FunctionAddress, intPtr, AddAnimationNotifyStateEventObject_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyStateEvent")]
	public unsafe static UAnimNotifyState AddAnimationNotifyStateEvent(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName, float StartTime, float Duration, TSubclassOf<UAnimNotifyState> NotifyStateClass)
	{
		if (!AddAnimationNotifyStateEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyStateEvent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAnimationNotifyStateEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAnimationNotifyStateEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEvent_AnimationSequenceBase_Offset), 0, AddAnimationNotifyStateEvent_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEvent_NotifyTrackName_Offset), 0, AddAnimationNotifyStateEvent_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEvent_StartTime_Offset), 0, AddAnimationNotifyStateEvent_StartTime_PropertyAddress.Address, StartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEvent_Duration_Offset), 0, AddAnimationNotifyStateEvent_Duration_PropertyAddress.Address, Duration);
		TSubclassOfMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEvent_NotifyStateClass_Offset), 0, AddAnimationNotifyStateEvent_NotifyStateClass_PropertyAddress.Address, NotifyStateClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAnimationNotifyStateEvent_FunctionAddress, intPtr, AddAnimationNotifyStateEvent_ParamsSize);
		return UObjectMarshaler<UAnimNotifyState>.FromNative(IntPtr.Add(intPtr, AddAnimationNotifyStateEvent_ReturnValue_Offset), 0, AddAnimationNotifyStateEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyEventObject")]
	public unsafe static void AddAnimationNotifyEventObject(UAnimSequenceBase AnimationSequenceBase, float StartTime, UAnimNotify Notify, FName NotifyTrackName)
	{
		if (!AddAnimationNotifyEventObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyEventObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAnimationNotifyEventObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAnimationNotifyEventObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyEventObject_AnimationSequenceBase_Offset), 0, AddAnimationNotifyEventObject_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyEventObject_StartTime_Offset), 0, AddAnimationNotifyEventObject_StartTime_PropertyAddress.Address, StartTime);
		UObjectMarshaler<UAnimNotify>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyEventObject_Notify_Offset), 0, AddAnimationNotifyEventObject_Notify_PropertyAddress.Address, Notify);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddAnimationNotifyEventObject_NotifyTrackName_Offset), 0, AddAnimationNotifyEventObject_NotifyTrackName_PropertyAddress.Address, NotifyTrackName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAnimationNotifyEventObject_FunctionAddress, intPtr, AddAnimationNotifyEventObject_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyEvent")]
	public unsafe static UAnimNotify AddAnimationNotifyEvent(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName, float StartTime, TSubclassOf<UAnimNotify> NotifyClass)
	{
		if (!AddAnimationNotifyEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyEvent");
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

	static UAnimationLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimationLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimationLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary");
		SetRootMotionLockType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRootMotionLockType");
		SetRootMotionLockType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRootMotionLockType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRootMotionLockType_AnimationSequence_PropertyAddress, SetRootMotionLockType_FunctionAddress, "AnimationSequence");
		SetRootMotionLockType_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetRootMotionLockType_FunctionAddress, "AnimationSequence");
		SetRootMotionLockType_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRootMotionLockType_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRootMotionLockType_RootMotionLockType_PropertyAddress, SetRootMotionLockType_FunctionAddress, "RootMotionLockType");
		SetRootMotionLockType_RootMotionLockType_Offset = NativeReflectionCached.GetPropertyOffset(SetRootMotionLockType_FunctionAddress, "RootMotionLockType");
		SetRootMotionLockType_RootMotionLockType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRootMotionLockType_FunctionAddress, "RootMotionLockType", Classes.FByteProperty);
		SetRootMotionLockType_IsValid = SetRootMotionLockType_FunctionAddress != IntPtr.Zero && SetRootMotionLockType_AnimationSequence_IsValid && SetRootMotionLockType_RootMotionLockType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetRootMotionLockType", SetRootMotionLockType_IsValid);
		SetRootMotionEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRootMotionEnabled");
		SetRootMotionEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRootMotionEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRootMotionEnabled_AnimationSequence_PropertyAddress, SetRootMotionEnabled_FunctionAddress, "AnimationSequence");
		SetRootMotionEnabled_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetRootMotionEnabled_FunctionAddress, "AnimationSequence");
		SetRootMotionEnabled_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRootMotionEnabled_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRootMotionEnabled_bEnabled_PropertyAddress, SetRootMotionEnabled_FunctionAddress, "bEnabled");
		SetRootMotionEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetRootMotionEnabled_FunctionAddress, "bEnabled");
		SetRootMotionEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRootMotionEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		SetRootMotionEnabled_IsValid = SetRootMotionEnabled_FunctionAddress != IntPtr.Zero && SetRootMotionEnabled_AnimationSequence_IsValid && SetRootMotionEnabled_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetRootMotionEnabled", SetRootMotionEnabled_IsValid);
		SetRateScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRateScale");
		SetRateScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRateScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRateScale_AnimationSequenceBase_PropertyAddress, SetRateScale_FunctionAddress, "AnimationSequenceBase");
		SetRateScale_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(SetRateScale_FunctionAddress, "AnimationSequenceBase");
		SetRateScale_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRateScale_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRateScale_RateScale_PropertyAddress, SetRateScale_FunctionAddress, "RateScale");
		SetRateScale_RateScale_Offset = NativeReflectionCached.GetPropertyOffset(SetRateScale_FunctionAddress, "RateScale");
		SetRateScale_RateScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRateScale_FunctionAddress, "RateScale", Classes.FFloatProperty);
		SetRateScale_IsValid = SetRateScale_FunctionAddress != IntPtr.Zero && SetRateScale_AnimationSequenceBase_IsValid && SetRateScale_RateScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetRateScale", SetRateScale_IsValid);
		SetIsRootMotionLockForced_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetIsRootMotionLockForced");
		SetIsRootMotionLockForced_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsRootMotionLockForced_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsRootMotionLockForced_AnimationSequence_PropertyAddress, SetIsRootMotionLockForced_FunctionAddress, "AnimationSequence");
		SetIsRootMotionLockForced_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetIsRootMotionLockForced_FunctionAddress, "AnimationSequence");
		SetIsRootMotionLockForced_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsRootMotionLockForced_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIsRootMotionLockForced_bForced_PropertyAddress, SetIsRootMotionLockForced_FunctionAddress, "bForced");
		SetIsRootMotionLockForced_bForced_Offset = NativeReflectionCached.GetPropertyOffset(SetIsRootMotionLockForced_FunctionAddress, "bForced");
		SetIsRootMotionLockForced_bForced_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsRootMotionLockForced_FunctionAddress, "bForced", Classes.FBoolProperty);
		SetIsRootMotionLockForced_IsValid = SetIsRootMotionLockForced_FunctionAddress != IntPtr.Zero && SetIsRootMotionLockForced_AnimationSequence_IsValid && SetIsRootMotionLockForced_bForced_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetIsRootMotionLockForced", SetIsRootMotionLockForced_IsValid);
		SetCurveCompressionSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurveCompressionSettings");
		SetCurveCompressionSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurveCompressionSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurveCompressionSettings_AnimationSequence_PropertyAddress, SetCurveCompressionSettings_FunctionAddress, "AnimationSequence");
		SetCurveCompressionSettings_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveCompressionSettings_FunctionAddress, "AnimationSequence");
		SetCurveCompressionSettings_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveCompressionSettings_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveCompressionSettings_CompressionSettings_PropertyAddress, SetCurveCompressionSettings_FunctionAddress, "CompressionSettings");
		SetCurveCompressionSettings_CompressionSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveCompressionSettings_FunctionAddress, "CompressionSettings");
		SetCurveCompressionSettings_CompressionSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveCompressionSettings_FunctionAddress, "CompressionSettings", Classes.FObjectProperty);
		SetCurveCompressionSettings_IsValid = SetCurveCompressionSettings_FunctionAddress != IntPtr.Zero && SetCurveCompressionSettings_AnimationSequence_IsValid && SetCurveCompressionSettings_CompressionSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetCurveCompressionSettings", SetCurveCompressionSettings_IsValid);
		SetBoneCompressionSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBoneCompressionSettings");
		SetBoneCompressionSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoneCompressionSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoneCompressionSettings_AnimationSequence_PropertyAddress, SetBoneCompressionSettings_FunctionAddress, "AnimationSequence");
		SetBoneCompressionSettings_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneCompressionSettings_FunctionAddress, "AnimationSequence");
		SetBoneCompressionSettings_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneCompressionSettings_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneCompressionSettings_CompressionSettings_PropertyAddress, SetBoneCompressionSettings_FunctionAddress, "CompressionSettings");
		SetBoneCompressionSettings_CompressionSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneCompressionSettings_FunctionAddress, "CompressionSettings");
		SetBoneCompressionSettings_CompressionSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneCompressionSettings_FunctionAddress, "CompressionSettings", Classes.FObjectProperty);
		SetBoneCompressionSettings_IsValid = SetBoneCompressionSettings_FunctionAddress != IntPtr.Zero && SetBoneCompressionSettings_AnimationSequence_IsValid && SetBoneCompressionSettings_CompressionSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetBoneCompressionSettings", SetBoneCompressionSettings_IsValid);
		SetAnimationInterpolationType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAnimationInterpolationType");
		SetAnimationInterpolationType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimationInterpolationType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationInterpolationType_AnimationSequence_PropertyAddress, SetAnimationInterpolationType_FunctionAddress, "AnimationSequence");
		SetAnimationInterpolationType_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationInterpolationType_FunctionAddress, "AnimationSequence");
		SetAnimationInterpolationType_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationInterpolationType_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationInterpolationType_InterpolationType_PropertyAddress, SetAnimationInterpolationType_FunctionAddress, "InterpolationType");
		SetAnimationInterpolationType_InterpolationType_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationInterpolationType_FunctionAddress, "InterpolationType");
		SetAnimationInterpolationType_InterpolationType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationInterpolationType_FunctionAddress, "InterpolationType", Classes.FEnumProperty);
		SetAnimationInterpolationType_IsValid = SetAnimationInterpolationType_FunctionAddress != IntPtr.Zero && SetAnimationInterpolationType_AnimationSequence_IsValid && SetAnimationInterpolationType_InterpolationType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetAnimationInterpolationType", SetAnimationInterpolationType_IsValid);
		SetAdditiveBasePoseType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAdditiveBasePoseType");
		SetAdditiveBasePoseType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAdditiveBasePoseType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAdditiveBasePoseType_AnimationSequence_PropertyAddress, SetAdditiveBasePoseType_FunctionAddress, "AnimationSequence");
		SetAdditiveBasePoseType_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetAdditiveBasePoseType_FunctionAddress, "AnimationSequence");
		SetAdditiveBasePoseType_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAdditiveBasePoseType_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAdditiveBasePoseType_AdditiveBasePoseType_PropertyAddress, SetAdditiveBasePoseType_FunctionAddress, "AdditiveBasePoseType");
		SetAdditiveBasePoseType_AdditiveBasePoseType_Offset = NativeReflectionCached.GetPropertyOffset(SetAdditiveBasePoseType_FunctionAddress, "AdditiveBasePoseType");
		SetAdditiveBasePoseType_AdditiveBasePoseType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAdditiveBasePoseType_FunctionAddress, "AdditiveBasePoseType", Classes.FByteProperty);
		SetAdditiveBasePoseType_IsValid = SetAdditiveBasePoseType_FunctionAddress != IntPtr.Zero && SetAdditiveBasePoseType_AnimationSequence_IsValid && SetAdditiveBasePoseType_AdditiveBasePoseType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetAdditiveBasePoseType", SetAdditiveBasePoseType_IsValid);
		SetAdditiveAnimationType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAdditiveAnimationType");
		SetAdditiveAnimationType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAdditiveAnimationType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAdditiveAnimationType_AnimationSequence_PropertyAddress, SetAdditiveAnimationType_FunctionAddress, "AnimationSequence");
		SetAdditiveAnimationType_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(SetAdditiveAnimationType_FunctionAddress, "AnimationSequence");
		SetAdditiveAnimationType_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAdditiveAnimationType_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAdditiveAnimationType_AdditiveAnimationType_PropertyAddress, SetAdditiveAnimationType_FunctionAddress, "AdditiveAnimationType");
		SetAdditiveAnimationType_AdditiveAnimationType_Offset = NativeReflectionCached.GetPropertyOffset(SetAdditiveAnimationType_FunctionAddress, "AdditiveAnimationType");
		SetAdditiveAnimationType_AdditiveAnimationType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAdditiveAnimationType_FunctionAddress, "AdditiveAnimationType", Classes.FByteProperty);
		SetAdditiveAnimationType_IsValid = SetAdditiveAnimationType_FunctionAddress != IntPtr.Zero && SetAdditiveAnimationType_AnimationSequence_IsValid && SetAdditiveAnimationType_AdditiveAnimationType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:SetAdditiveAnimationType", SetAdditiveAnimationType_IsValid);
		ReplaceAnimNotifyStates_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceAnimNotifyStates");
		ReplaceAnimNotifyStates_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceAnimNotifyStates_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAnimNotifyStates_AnimationSequenceBase_PropertyAddress, ReplaceAnimNotifyStates_FunctionAddress, "AnimationSequenceBase");
		ReplaceAnimNotifyStates_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAnimNotifyStates_FunctionAddress, "AnimationSequenceBase");
		ReplaceAnimNotifyStates_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAnimNotifyStates_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAnimNotifyStates_OldNotifyClass_PropertyAddress, ReplaceAnimNotifyStates_FunctionAddress, "OldNotifyClass");
		ReplaceAnimNotifyStates_OldNotifyClass_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAnimNotifyStates_FunctionAddress, "OldNotifyClass");
		ReplaceAnimNotifyStates_OldNotifyClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAnimNotifyStates_FunctionAddress, "OldNotifyClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAnimNotifyStates_NewNotifyClass_PropertyAddress, ReplaceAnimNotifyStates_FunctionAddress, "NewNotifyClass");
		ReplaceAnimNotifyStates_NewNotifyClass_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAnimNotifyStates_FunctionAddress, "NewNotifyClass");
		ReplaceAnimNotifyStates_NewNotifyClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAnimNotifyStates_FunctionAddress, "NewNotifyClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAnimNotifyStates_OnNotifyStateReplaced_PropertyAddress, ReplaceAnimNotifyStates_FunctionAddress, "OnNotifyStateReplaced");
		ReplaceAnimNotifyStates_OnNotifyStateReplaced_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAnimNotifyStates_FunctionAddress, "OnNotifyStateReplaced");
		ReplaceAnimNotifyStates_OnNotifyStateReplaced_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAnimNotifyStates_FunctionAddress, "OnNotifyStateReplaced", Classes.FDelegateProperty);
		ReplaceAnimNotifyStates_IsValid = ReplaceAnimNotifyStates_FunctionAddress != IntPtr.Zero && ReplaceAnimNotifyStates_AnimationSequenceBase_IsValid && ReplaceAnimNotifyStates_OldNotifyClass_IsValid && ReplaceAnimNotifyStates_NewNotifyClass_IsValid && ReplaceAnimNotifyStates_OnNotifyStateReplaced_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:ReplaceAnimNotifyStates", ReplaceAnimNotifyStates_IsValid);
		ReplaceAnimNotifies_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceAnimNotifies");
		ReplaceAnimNotifies_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceAnimNotifies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAnimNotifies_AnimationSequenceBase_PropertyAddress, ReplaceAnimNotifies_FunctionAddress, "AnimationSequenceBase");
		ReplaceAnimNotifies_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAnimNotifies_FunctionAddress, "AnimationSequenceBase");
		ReplaceAnimNotifies_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAnimNotifies_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAnimNotifies_OldNotifyClass_PropertyAddress, ReplaceAnimNotifies_FunctionAddress, "OldNotifyClass");
		ReplaceAnimNotifies_OldNotifyClass_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAnimNotifies_FunctionAddress, "OldNotifyClass");
		ReplaceAnimNotifies_OldNotifyClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAnimNotifies_FunctionAddress, "OldNotifyClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAnimNotifies_NewNotifyClass_PropertyAddress, ReplaceAnimNotifies_FunctionAddress, "NewNotifyClass");
		ReplaceAnimNotifies_NewNotifyClass_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAnimNotifies_FunctionAddress, "NewNotifyClass");
		ReplaceAnimNotifies_NewNotifyClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAnimNotifies_FunctionAddress, "NewNotifyClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAnimNotifies_OnNotifyReplaced_PropertyAddress, ReplaceAnimNotifies_FunctionAddress, "OnNotifyReplaced");
		ReplaceAnimNotifies_OnNotifyReplaced_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAnimNotifies_FunctionAddress, "OnNotifyReplaced");
		ReplaceAnimNotifies_OnNotifyReplaced_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAnimNotifies_FunctionAddress, "OnNotifyReplaced", Classes.FDelegateProperty);
		ReplaceAnimNotifies_IsValid = ReplaceAnimNotifies_FunctionAddress != IntPtr.Zero && ReplaceAnimNotifies_AnimationSequenceBase_IsValid && ReplaceAnimNotifies_OldNotifyClass_IsValid && ReplaceAnimNotifies_NewNotifyClass_IsValid && ReplaceAnimNotifies_OnNotifyReplaced_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:ReplaceAnimNotifies", ReplaceAnimNotifies_IsValid);
		RemoveVirtualBones_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveVirtualBones");
		RemoveVirtualBones_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveVirtualBones_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveVirtualBones_AnimationSequence_PropertyAddress, RemoveVirtualBones_FunctionAddress, "AnimationSequence");
		RemoveVirtualBones_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(RemoveVirtualBones_FunctionAddress, "AnimationSequence");
		RemoveVirtualBones_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveVirtualBones_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveVirtualBones_VirtualBoneNames_PropertyAddress, RemoveVirtualBones_FunctionAddress, "VirtualBoneNames");
		RemoveVirtualBones_VirtualBoneNames_Offset = NativeReflectionCached.GetPropertyOffset(RemoveVirtualBones_FunctionAddress, "VirtualBoneNames");
		RemoveVirtualBones_VirtualBoneNames_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveVirtualBones_FunctionAddress, "VirtualBoneNames", Classes.FArrayProperty);
		RemoveVirtualBones_IsValid = RemoveVirtualBones_FunctionAddress != IntPtr.Zero && RemoveVirtualBones_AnimationSequence_IsValid && RemoveVirtualBones_VirtualBoneNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveVirtualBones", RemoveVirtualBones_IsValid);
		RemoveVirtualBone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveVirtualBone");
		RemoveVirtualBone_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveVirtualBone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveVirtualBone_AnimationSequence_PropertyAddress, RemoveVirtualBone_FunctionAddress, "AnimationSequence");
		RemoveVirtualBone_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(RemoveVirtualBone_FunctionAddress, "AnimationSequence");
		RemoveVirtualBone_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveVirtualBone_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveVirtualBone_VirtualBoneName_PropertyAddress, RemoveVirtualBone_FunctionAddress, "VirtualBoneName");
		RemoveVirtualBone_VirtualBoneName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveVirtualBone_FunctionAddress, "VirtualBoneName");
		RemoveVirtualBone_VirtualBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveVirtualBone_FunctionAddress, "VirtualBoneName", Classes.FNameProperty);
		RemoveVirtualBone_IsValid = RemoveVirtualBone_FunctionAddress != IntPtr.Zero && RemoveVirtualBone_AnimationSequence_IsValid && RemoveVirtualBone_VirtualBoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveVirtualBone", RemoveVirtualBone_IsValid);
		RemoveMetaDataOfClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveMetaDataOfClass");
		RemoveMetaDataOfClass_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveMetaDataOfClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveMetaDataOfClass_AnimationAsset_PropertyAddress, RemoveMetaDataOfClass_FunctionAddress, "AnimationAsset");
		RemoveMetaDataOfClass_AnimationAsset_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMetaDataOfClass_FunctionAddress, "AnimationAsset");
		RemoveMetaDataOfClass_AnimationAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMetaDataOfClass_FunctionAddress, "AnimationAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveMetaDataOfClass_MetaDataClass_PropertyAddress, RemoveMetaDataOfClass_FunctionAddress, "MetaDataClass");
		RemoveMetaDataOfClass_MetaDataClass_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMetaDataOfClass_FunctionAddress, "MetaDataClass");
		RemoveMetaDataOfClass_MetaDataClass_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMetaDataOfClass_FunctionAddress, "MetaDataClass", Classes.FClassProperty);
		RemoveMetaDataOfClass_IsValid = RemoveMetaDataOfClass_FunctionAddress != IntPtr.Zero && RemoveMetaDataOfClass_AnimationAsset_IsValid && RemoveMetaDataOfClass_MetaDataClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveMetaDataOfClass", RemoveMetaDataOfClass_IsValid);
		RemoveMetaData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveMetaData");
		RemoveMetaData_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveMetaData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveMetaData_AnimationAsset_PropertyAddress, RemoveMetaData_FunctionAddress, "AnimationAsset");
		RemoveMetaData_AnimationAsset_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMetaData_FunctionAddress, "AnimationAsset");
		RemoveMetaData_AnimationAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMetaData_FunctionAddress, "AnimationAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveMetaData_MetaDataObject_PropertyAddress, RemoveMetaData_FunctionAddress, "MetaDataObject");
		RemoveMetaData_MetaDataObject_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMetaData_FunctionAddress, "MetaDataObject");
		RemoveMetaData_MetaDataObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMetaData_FunctionAddress, "MetaDataObject", Classes.FObjectProperty);
		RemoveMetaData_IsValid = RemoveMetaData_FunctionAddress != IntPtr.Zero && RemoveMetaData_AnimationAsset_IsValid && RemoveMetaData_MetaDataObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveMetaData", RemoveMetaData_IsValid);
		RemoveCurve_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveCurve");
		RemoveCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveCurve_AnimationSequence_PropertyAddress, RemoveCurve_FunctionAddress, "AnimationSequence");
		RemoveCurve_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCurve_FunctionAddress, "AnimationSequence");
		RemoveCurve_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCurve_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveCurve_CurveName_PropertyAddress, RemoveCurve_FunctionAddress, "CurveName");
		RemoveCurve_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCurve_FunctionAddress, "CurveName");
		RemoveCurve_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCurve_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveCurve_bRemoveNameFromSkeleton_PropertyAddress, RemoveCurve_FunctionAddress, "bRemoveNameFromSkeleton");
		RemoveCurve_bRemoveNameFromSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCurve_FunctionAddress, "bRemoveNameFromSkeleton");
		RemoveCurve_bRemoveNameFromSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCurve_FunctionAddress, "bRemoveNameFromSkeleton", Classes.FBoolProperty);
		RemoveCurve_IsValid = RemoveCurve_FunctionAddress != IntPtr.Zero && RemoveCurve_AnimationSequence_IsValid && RemoveCurve_CurveName_IsValid && RemoveCurve_bRemoveNameFromSkeleton_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveCurve", RemoveCurve_IsValid);
		RemoveBoneAnimation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveBoneAnimation");
		RemoveBoneAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveBoneAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveBoneAnimation_AnimationSequence_PropertyAddress, RemoveBoneAnimation_FunctionAddress, "AnimationSequence");
		RemoveBoneAnimation_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBoneAnimation_FunctionAddress, "AnimationSequence");
		RemoveBoneAnimation_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBoneAnimation_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveBoneAnimation_BoneName_PropertyAddress, RemoveBoneAnimation_FunctionAddress, "BoneName");
		RemoveBoneAnimation_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBoneAnimation_FunctionAddress, "BoneName");
		RemoveBoneAnimation_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBoneAnimation_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveBoneAnimation_bIncludeChildren_PropertyAddress, RemoveBoneAnimation_FunctionAddress, "bIncludeChildren");
		RemoveBoneAnimation_bIncludeChildren_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBoneAnimation_FunctionAddress, "bIncludeChildren");
		RemoveBoneAnimation_bIncludeChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBoneAnimation_FunctionAddress, "bIncludeChildren", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveBoneAnimation_bFinalize_PropertyAddress, RemoveBoneAnimation_FunctionAddress, "bFinalize");
		RemoveBoneAnimation_bFinalize_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBoneAnimation_FunctionAddress, "bFinalize");
		RemoveBoneAnimation_bFinalize_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBoneAnimation_FunctionAddress, "bFinalize", Classes.FBoolProperty);
		RemoveBoneAnimation_IsValid = RemoveBoneAnimation_FunctionAddress != IntPtr.Zero && RemoveBoneAnimation_AnimationSequence_IsValid && RemoveBoneAnimation_BoneName_IsValid && RemoveBoneAnimation_bIncludeChildren_IsValid && RemoveBoneAnimation_bFinalize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveBoneAnimation", RemoveBoneAnimation_IsValid);
		RemoveAnimationSyncMarkersByTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAnimationSyncMarkersByTrack");
		RemoveAnimationSyncMarkersByTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAnimationSyncMarkersByTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationSyncMarkersByTrack_AnimationSequence_PropertyAddress, RemoveAnimationSyncMarkersByTrack_FunctionAddress, "AnimationSequence");
		RemoveAnimationSyncMarkersByTrack_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationSyncMarkersByTrack_FunctionAddress, "AnimationSequence");
		RemoveAnimationSyncMarkersByTrack_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationSyncMarkersByTrack_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationSyncMarkersByTrack_NotifyTrackName_PropertyAddress, RemoveAnimationSyncMarkersByTrack_FunctionAddress, "NotifyTrackName");
		RemoveAnimationSyncMarkersByTrack_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationSyncMarkersByTrack_FunctionAddress, "NotifyTrackName");
		RemoveAnimationSyncMarkersByTrack_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationSyncMarkersByTrack_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationSyncMarkersByTrack_ReturnValue_PropertyAddress, RemoveAnimationSyncMarkersByTrack_FunctionAddress, "ReturnValue");
		RemoveAnimationSyncMarkersByTrack_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationSyncMarkersByTrack_FunctionAddress, "ReturnValue");
		RemoveAnimationSyncMarkersByTrack_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationSyncMarkersByTrack_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		RemoveAnimationSyncMarkersByTrack_IsValid = RemoveAnimationSyncMarkersByTrack_FunctionAddress != IntPtr.Zero && RemoveAnimationSyncMarkersByTrack_AnimationSequence_IsValid && RemoveAnimationSyncMarkersByTrack_NotifyTrackName_IsValid && RemoveAnimationSyncMarkersByTrack_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationSyncMarkersByTrack", RemoveAnimationSyncMarkersByTrack_IsValid);
		RemoveAnimationSyncMarkersByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAnimationSyncMarkersByName");
		RemoveAnimationSyncMarkersByName_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAnimationSyncMarkersByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationSyncMarkersByName_AnimationSequence_PropertyAddress, RemoveAnimationSyncMarkersByName_FunctionAddress, "AnimationSequence");
		RemoveAnimationSyncMarkersByName_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationSyncMarkersByName_FunctionAddress, "AnimationSequence");
		RemoveAnimationSyncMarkersByName_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationSyncMarkersByName_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationSyncMarkersByName_MarkerName_PropertyAddress, RemoveAnimationSyncMarkersByName_FunctionAddress, "MarkerName");
		RemoveAnimationSyncMarkersByName_MarkerName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationSyncMarkersByName_FunctionAddress, "MarkerName");
		RemoveAnimationSyncMarkersByName_MarkerName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationSyncMarkersByName_FunctionAddress, "MarkerName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationSyncMarkersByName_ReturnValue_PropertyAddress, RemoveAnimationSyncMarkersByName_FunctionAddress, "ReturnValue");
		RemoveAnimationSyncMarkersByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationSyncMarkersByName_FunctionAddress, "ReturnValue");
		RemoveAnimationSyncMarkersByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationSyncMarkersByName_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		RemoveAnimationSyncMarkersByName_IsValid = RemoveAnimationSyncMarkersByName_FunctionAddress != IntPtr.Zero && RemoveAnimationSyncMarkersByName_AnimationSequence_IsValid && RemoveAnimationSyncMarkersByName_MarkerName_IsValid && RemoveAnimationSyncMarkersByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationSyncMarkersByName", RemoveAnimationSyncMarkersByName_IsValid);
		RemoveAnimationNotifyTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAnimationNotifyTrack");
		RemoveAnimationNotifyTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAnimationNotifyTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationNotifyTrack_AnimationSequenceBase_PropertyAddress, RemoveAnimationNotifyTrack_FunctionAddress, "AnimationSequenceBase");
		RemoveAnimationNotifyTrack_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationNotifyTrack_FunctionAddress, "AnimationSequenceBase");
		RemoveAnimationNotifyTrack_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationNotifyTrack_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationNotifyTrack_NotifyTrackName_PropertyAddress, RemoveAnimationNotifyTrack_FunctionAddress, "NotifyTrackName");
		RemoveAnimationNotifyTrack_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationNotifyTrack_FunctionAddress, "NotifyTrackName");
		RemoveAnimationNotifyTrack_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationNotifyTrack_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		RemoveAnimationNotifyTrack_IsValid = RemoveAnimationNotifyTrack_FunctionAddress != IntPtr.Zero && RemoveAnimationNotifyTrack_AnimationSequenceBase_IsValid && RemoveAnimationNotifyTrack_NotifyTrackName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationNotifyTrack", RemoveAnimationNotifyTrack_IsValid);
		RemoveAnimationNotifyEventsByTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAnimationNotifyEventsByTrack");
		RemoveAnimationNotifyEventsByTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAnimationNotifyEventsByTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationNotifyEventsByTrack_AnimationSequenceBase_PropertyAddress, RemoveAnimationNotifyEventsByTrack_FunctionAddress, "AnimationSequenceBase");
		RemoveAnimationNotifyEventsByTrack_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationNotifyEventsByTrack_FunctionAddress, "AnimationSequenceBase");
		RemoveAnimationNotifyEventsByTrack_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationNotifyEventsByTrack_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationNotifyEventsByTrack_NotifyTrackName_PropertyAddress, RemoveAnimationNotifyEventsByTrack_FunctionAddress, "NotifyTrackName");
		RemoveAnimationNotifyEventsByTrack_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationNotifyEventsByTrack_FunctionAddress, "NotifyTrackName");
		RemoveAnimationNotifyEventsByTrack_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationNotifyEventsByTrack_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationNotifyEventsByTrack_ReturnValue_PropertyAddress, RemoveAnimationNotifyEventsByTrack_FunctionAddress, "ReturnValue");
		RemoveAnimationNotifyEventsByTrack_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationNotifyEventsByTrack_FunctionAddress, "ReturnValue");
		RemoveAnimationNotifyEventsByTrack_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationNotifyEventsByTrack_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		RemoveAnimationNotifyEventsByTrack_IsValid = RemoveAnimationNotifyEventsByTrack_FunctionAddress != IntPtr.Zero && RemoveAnimationNotifyEventsByTrack_AnimationSequenceBase_IsValid && RemoveAnimationNotifyEventsByTrack_NotifyTrackName_IsValid && RemoveAnimationNotifyEventsByTrack_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationNotifyEventsByTrack", RemoveAnimationNotifyEventsByTrack_IsValid);
		RemoveAnimationNotifyEventsByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAnimationNotifyEventsByName");
		RemoveAnimationNotifyEventsByName_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAnimationNotifyEventsByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationNotifyEventsByName_AnimationSequenceBase_PropertyAddress, RemoveAnimationNotifyEventsByName_FunctionAddress, "AnimationSequenceBase");
		RemoveAnimationNotifyEventsByName_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationNotifyEventsByName_FunctionAddress, "AnimationSequenceBase");
		RemoveAnimationNotifyEventsByName_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationNotifyEventsByName_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationNotifyEventsByName_NotifyName_PropertyAddress, RemoveAnimationNotifyEventsByName_FunctionAddress, "NotifyName");
		RemoveAnimationNotifyEventsByName_NotifyName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationNotifyEventsByName_FunctionAddress, "NotifyName");
		RemoveAnimationNotifyEventsByName_NotifyName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationNotifyEventsByName_FunctionAddress, "NotifyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationNotifyEventsByName_ReturnValue_PropertyAddress, RemoveAnimationNotifyEventsByName_FunctionAddress, "ReturnValue");
		RemoveAnimationNotifyEventsByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationNotifyEventsByName_FunctionAddress, "ReturnValue");
		RemoveAnimationNotifyEventsByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationNotifyEventsByName_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		RemoveAnimationNotifyEventsByName_IsValid = RemoveAnimationNotifyEventsByName_FunctionAddress != IntPtr.Zero && RemoveAnimationNotifyEventsByName_AnimationSequenceBase_IsValid && RemoveAnimationNotifyEventsByName_NotifyName_IsValid && RemoveAnimationNotifyEventsByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAnimationNotifyEventsByName", RemoveAnimationNotifyEventsByName_IsValid);
		RemoveAllVirtualBones_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAllVirtualBones");
		RemoveAllVirtualBones_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllVirtualBones_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllVirtualBones_AnimationSequence_PropertyAddress, RemoveAllVirtualBones_FunctionAddress, "AnimationSequence");
		RemoveAllVirtualBones_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllVirtualBones_FunctionAddress, "AnimationSequence");
		RemoveAllVirtualBones_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllVirtualBones_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		RemoveAllVirtualBones_IsValid = RemoveAllVirtualBones_FunctionAddress != IntPtr.Zero && RemoveAllVirtualBones_AnimationSequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllVirtualBones", RemoveAllVirtualBones_IsValid);
		RemoveAllMetaData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAllMetaData");
		RemoveAllMetaData_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllMetaData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllMetaData_AnimationAsset_PropertyAddress, RemoveAllMetaData_FunctionAddress, "AnimationAsset");
		RemoveAllMetaData_AnimationAsset_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllMetaData_FunctionAddress, "AnimationAsset");
		RemoveAllMetaData_AnimationAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllMetaData_FunctionAddress, "AnimationAsset", Classes.FObjectProperty);
		RemoveAllMetaData_IsValid = RemoveAllMetaData_FunctionAddress != IntPtr.Zero && RemoveAllMetaData_AnimationAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllMetaData", RemoveAllMetaData_IsValid);
		RemoveAllCurveData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAllCurveData");
		RemoveAllCurveData_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllCurveData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllCurveData_AnimationSequence_PropertyAddress, RemoveAllCurveData_FunctionAddress, "AnimationSequence");
		RemoveAllCurveData_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllCurveData_FunctionAddress, "AnimationSequence");
		RemoveAllCurveData_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllCurveData_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		RemoveAllCurveData_IsValid = RemoveAllCurveData_FunctionAddress != IntPtr.Zero && RemoveAllCurveData_AnimationSequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllCurveData", RemoveAllCurveData_IsValid);
		RemoveAllBoneAnimation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAllBoneAnimation");
		RemoveAllBoneAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllBoneAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllBoneAnimation_AnimationSequence_PropertyAddress, RemoveAllBoneAnimation_FunctionAddress, "AnimationSequence");
		RemoveAllBoneAnimation_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllBoneAnimation_FunctionAddress, "AnimationSequence");
		RemoveAllBoneAnimation_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllBoneAnimation_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		RemoveAllBoneAnimation_IsValid = RemoveAllBoneAnimation_FunctionAddress != IntPtr.Zero && RemoveAllBoneAnimation_AnimationSequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllBoneAnimation", RemoveAllBoneAnimation_IsValid);
		RemoveAllAnimationSyncMarkers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAllAnimationSyncMarkers");
		RemoveAllAnimationSyncMarkers_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllAnimationSyncMarkers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllAnimationSyncMarkers_AnimationSequence_PropertyAddress, RemoveAllAnimationSyncMarkers_FunctionAddress, "AnimationSequence");
		RemoveAllAnimationSyncMarkers_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllAnimationSyncMarkers_FunctionAddress, "AnimationSequence");
		RemoveAllAnimationSyncMarkers_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllAnimationSyncMarkers_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		RemoveAllAnimationSyncMarkers_IsValid = RemoveAllAnimationSyncMarkers_FunctionAddress != IntPtr.Zero && RemoveAllAnimationSyncMarkers_AnimationSequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllAnimationSyncMarkers", RemoveAllAnimationSyncMarkers_IsValid);
		RemoveAllAnimationNotifyTracks_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAllAnimationNotifyTracks");
		RemoveAllAnimationNotifyTracks_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllAnimationNotifyTracks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllAnimationNotifyTracks_AnimationSequenceBase_PropertyAddress, RemoveAllAnimationNotifyTracks_FunctionAddress, "AnimationSequenceBase");
		RemoveAllAnimationNotifyTracks_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllAnimationNotifyTracks_FunctionAddress, "AnimationSequenceBase");
		RemoveAllAnimationNotifyTracks_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllAnimationNotifyTracks_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		RemoveAllAnimationNotifyTracks_IsValid = RemoveAllAnimationNotifyTracks_FunctionAddress != IntPtr.Zero && RemoveAllAnimationNotifyTracks_AnimationSequenceBase_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:RemoveAllAnimationNotifyTracks", RemoveAllAnimationNotifyTracks_IsValid);
		IsValidTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidTime");
		IsValidTime_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidTime_AnimationSequenceBase_PropertyAddress, IsValidTime_FunctionAddress, "AnimationSequenceBase");
		IsValidTime_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(IsValidTime_FunctionAddress, "AnimationSequenceBase");
		IsValidTime_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidTime_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidTime_Time_PropertyAddress, IsValidTime_FunctionAddress, "Time");
		IsValidTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(IsValidTime_FunctionAddress, "Time");
		IsValidTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidTime_IsValid_PropertyAddress, IsValidTime_FunctionAddress, "IsValid");
		IsValidTime_IsValid_Offset = NativeReflectionCached.GetPropertyOffset(IsValidTime_FunctionAddress, "IsValid");
		IsValidTime_IsValid_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidTime_FunctionAddress, "IsValid", Classes.FBoolProperty);
		IsValidTime_IsValid = IsValidTime_FunctionAddress != IntPtr.Zero && IsValidTime_AnimationSequenceBase_IsValid && IsValidTime_Time_IsValid && IsValidTime_IsValid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsValidTime", IsValidTime_IsValid);
		IsValidRawAnimationTrackName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidRawAnimationTrackName");
		IsValidRawAnimationTrackName_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidRawAnimationTrackName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidRawAnimationTrackName_AnimationSequenceBase_PropertyAddress, IsValidRawAnimationTrackName_FunctionAddress, "AnimationSequenceBase");
		IsValidRawAnimationTrackName_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(IsValidRawAnimationTrackName_FunctionAddress, "AnimationSequenceBase");
		IsValidRawAnimationTrackName_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidRawAnimationTrackName_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidRawAnimationTrackName_TrackName_PropertyAddress, IsValidRawAnimationTrackName_FunctionAddress, "TrackName");
		IsValidRawAnimationTrackName_TrackName_Offset = NativeReflectionCached.GetPropertyOffset(IsValidRawAnimationTrackName_FunctionAddress, "TrackName");
		IsValidRawAnimationTrackName_TrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidRawAnimationTrackName_FunctionAddress, "TrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidRawAnimationTrackName_ReturnValue_PropertyAddress, IsValidRawAnimationTrackName_FunctionAddress, "ReturnValue");
		IsValidRawAnimationTrackName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidRawAnimationTrackName_FunctionAddress, "ReturnValue");
		IsValidRawAnimationTrackName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidRawAnimationTrackName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidRawAnimationTrackName_IsValid = IsValidRawAnimationTrackName_FunctionAddress != IntPtr.Zero && IsValidRawAnimationTrackName_AnimationSequenceBase_IsValid && IsValidRawAnimationTrackName_TrackName_IsValid && IsValidRawAnimationTrackName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsValidRawAnimationTrackName", IsValidRawAnimationTrackName_IsValid);
		IsValidAnimNotifyTrackName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidAnimNotifyTrackName");
		IsValidAnimNotifyTrackName_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidAnimNotifyTrackName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidAnimNotifyTrackName_AnimationSequenceBase_PropertyAddress, IsValidAnimNotifyTrackName_FunctionAddress, "AnimationSequenceBase");
		IsValidAnimNotifyTrackName_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAnimNotifyTrackName_FunctionAddress, "AnimationSequenceBase");
		IsValidAnimNotifyTrackName_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAnimNotifyTrackName_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidAnimNotifyTrackName_NotifyTrackName_PropertyAddress, IsValidAnimNotifyTrackName_FunctionAddress, "NotifyTrackName");
		IsValidAnimNotifyTrackName_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAnimNotifyTrackName_FunctionAddress, "NotifyTrackName");
		IsValidAnimNotifyTrackName_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAnimNotifyTrackName_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidAnimNotifyTrackName_ReturnValue_PropertyAddress, IsValidAnimNotifyTrackName_FunctionAddress, "ReturnValue");
		IsValidAnimNotifyTrackName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAnimNotifyTrackName_FunctionAddress, "ReturnValue");
		IsValidAnimNotifyTrackName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAnimNotifyTrackName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidAnimNotifyTrackName_IsValid = IsValidAnimNotifyTrackName_FunctionAddress != IntPtr.Zero && IsValidAnimNotifyTrackName_AnimationSequenceBase_IsValid && IsValidAnimNotifyTrackName_NotifyTrackName_IsValid && IsValidAnimNotifyTrackName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsValidAnimNotifyTrackName", IsValidAnimNotifyTrackName_IsValid);
		IsValidAnimationSyncMarkerName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidAnimationSyncMarkerName");
		IsValidAnimationSyncMarkerName_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidAnimationSyncMarkerName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidAnimationSyncMarkerName_AnimationSequence_PropertyAddress, IsValidAnimationSyncMarkerName_FunctionAddress, "AnimationSequence");
		IsValidAnimationSyncMarkerName_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAnimationSyncMarkerName_FunctionAddress, "AnimationSequence");
		IsValidAnimationSyncMarkerName_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAnimationSyncMarkerName_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidAnimationSyncMarkerName_MarkerName_PropertyAddress, IsValidAnimationSyncMarkerName_FunctionAddress, "MarkerName");
		IsValidAnimationSyncMarkerName_MarkerName_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAnimationSyncMarkerName_FunctionAddress, "MarkerName");
		IsValidAnimationSyncMarkerName_MarkerName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAnimationSyncMarkerName_FunctionAddress, "MarkerName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidAnimationSyncMarkerName_ReturnValue_PropertyAddress, IsValidAnimationSyncMarkerName_FunctionAddress, "ReturnValue");
		IsValidAnimationSyncMarkerName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAnimationSyncMarkerName_FunctionAddress, "ReturnValue");
		IsValidAnimationSyncMarkerName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAnimationSyncMarkerName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidAnimationSyncMarkerName_IsValid = IsValidAnimationSyncMarkerName_FunctionAddress != IntPtr.Zero && IsValidAnimationSyncMarkerName_AnimationSequence_IsValid && IsValidAnimationSyncMarkerName_MarkerName_IsValid && IsValidAnimationSyncMarkerName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsValidAnimationSyncMarkerName", IsValidAnimationSyncMarkerName_IsValid);
		IsRootMotionLockForced_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRootMotionLockForced");
		IsRootMotionLockForced_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRootMotionLockForced_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRootMotionLockForced_AnimationSequence_PropertyAddress, IsRootMotionLockForced_FunctionAddress, "AnimationSequence");
		IsRootMotionLockForced_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(IsRootMotionLockForced_FunctionAddress, "AnimationSequence");
		IsRootMotionLockForced_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRootMotionLockForced_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRootMotionLockForced_ReturnValue_PropertyAddress, IsRootMotionLockForced_FunctionAddress, "ReturnValue");
		IsRootMotionLockForced_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRootMotionLockForced_FunctionAddress, "ReturnValue");
		IsRootMotionLockForced_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRootMotionLockForced_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRootMotionLockForced_IsValid = IsRootMotionLockForced_FunctionAddress != IntPtr.Zero && IsRootMotionLockForced_AnimationSequence_IsValid && IsRootMotionLockForced_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsRootMotionLockForced", IsRootMotionLockForced_IsValid);
		IsRootMotionEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRootMotionEnabled");
		IsRootMotionEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRootMotionEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRootMotionEnabled_AnimationSequence_PropertyAddress, IsRootMotionEnabled_FunctionAddress, "AnimationSequence");
		IsRootMotionEnabled_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(IsRootMotionEnabled_FunctionAddress, "AnimationSequence");
		IsRootMotionEnabled_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRootMotionEnabled_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRootMotionEnabled_ReturnValue_PropertyAddress, IsRootMotionEnabled_FunctionAddress, "ReturnValue");
		IsRootMotionEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRootMotionEnabled_FunctionAddress, "ReturnValue");
		IsRootMotionEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRootMotionEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRootMotionEnabled_IsValid = IsRootMotionEnabled_FunctionAddress != IntPtr.Zero && IsRootMotionEnabled_AnimationSequence_IsValid && IsRootMotionEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:IsRootMotionEnabled", IsRootMotionEnabled_IsValid);
		GetVectorKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVectorKeys");
		GetVectorKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorKeys_AnimationSequence_PropertyAddress, GetVectorKeys_FunctionAddress, "AnimationSequence");
		GetVectorKeys_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorKeys_FunctionAddress, "AnimationSequence");
		GetVectorKeys_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorKeys_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorKeys_CurveName_PropertyAddress, GetVectorKeys_FunctionAddress, "CurveName");
		GetVectorKeys_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorKeys_FunctionAddress, "CurveName");
		GetVectorKeys_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorKeys_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorKeys_Times_PropertyAddress, GetVectorKeys_FunctionAddress, "Times");
		GetVectorKeys_Times_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorKeys_FunctionAddress, "Times");
		GetVectorKeys_Times_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorKeys_FunctionAddress, "Times", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorKeys_Values_PropertyAddress, GetVectorKeys_FunctionAddress, "Values");
		GetVectorKeys_Values_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorKeys_FunctionAddress, "Values");
		GetVectorKeys_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorKeys_FunctionAddress, "Values", Classes.FArrayProperty);
		GetVectorKeys_IsValid = GetVectorKeys_FunctionAddress != IntPtr.Zero && GetVectorKeys_AnimationSequence_IsValid && GetVectorKeys_CurveName_IsValid && GetVectorKeys_Times_IsValid && GetVectorKeys_Values_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetVectorKeys", GetVectorKeys_IsValid);
		GetUniqueMarkerNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUniqueMarkerNames");
		GetUniqueMarkerNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUniqueMarkerNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUniqueMarkerNames_AnimationSequence_PropertyAddress, GetUniqueMarkerNames_FunctionAddress, "AnimationSequence");
		GetUniqueMarkerNames_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetUniqueMarkerNames_FunctionAddress, "AnimationSequence");
		GetUniqueMarkerNames_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUniqueMarkerNames_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUniqueMarkerNames_MarkerNames_PropertyAddress, GetUniqueMarkerNames_FunctionAddress, "MarkerNames");
		GetUniqueMarkerNames_MarkerNames_Offset = NativeReflectionCached.GetPropertyOffset(GetUniqueMarkerNames_FunctionAddress, "MarkerNames");
		GetUniqueMarkerNames_MarkerNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUniqueMarkerNames_FunctionAddress, "MarkerNames", Classes.FArrayProperty);
		GetUniqueMarkerNames_IsValid = GetUniqueMarkerNames_FunctionAddress != IntPtr.Zero && GetUniqueMarkerNames_AnimationSequence_IsValid && GetUniqueMarkerNames_MarkerNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetUniqueMarkerNames", GetUniqueMarkerNames_IsValid);
		GetTransformationKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTransformationKeys");
		GetTransformationKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransformationKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransformationKeys_AnimationSequence_PropertyAddress, GetTransformationKeys_FunctionAddress, "AnimationSequence");
		GetTransformationKeys_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformationKeys_FunctionAddress, "AnimationSequence");
		GetTransformationKeys_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformationKeys_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformationKeys_CurveName_PropertyAddress, GetTransformationKeys_FunctionAddress, "CurveName");
		GetTransformationKeys_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformationKeys_FunctionAddress, "CurveName");
		GetTransformationKeys_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformationKeys_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformationKeys_Times_PropertyAddress, GetTransformationKeys_FunctionAddress, "Times");
		GetTransformationKeys_Times_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformationKeys_FunctionAddress, "Times");
		GetTransformationKeys_Times_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformationKeys_FunctionAddress, "Times", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformationKeys_Values_PropertyAddress, GetTransformationKeys_FunctionAddress, "Values");
		GetTransformationKeys_Values_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformationKeys_FunctionAddress, "Values");
		GetTransformationKeys_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformationKeys_FunctionAddress, "Values", Classes.FArrayProperty);
		GetTransformationKeys_IsValid = GetTransformationKeys_FunctionAddress != IntPtr.Zero && GetTransformationKeys_AnimationSequence_IsValid && GetTransformationKeys_CurveName_IsValid && GetTransformationKeys_Times_IsValid && GetTransformationKeys_Values_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetTransformationKeys", GetTransformationKeys_IsValid);
		GetTimeAtFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTimeAtFrame");
		GetTimeAtFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTimeAtFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTimeAtFrame_AnimationSequenceBase_PropertyAddress, GetTimeAtFrame_FunctionAddress, "AnimationSequenceBase");
		GetTimeAtFrame_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetTimeAtFrame_FunctionAddress, "AnimationSequenceBase");
		GetTimeAtFrame_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimeAtFrame_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTimeAtFrame_Frame_PropertyAddress, GetTimeAtFrame_FunctionAddress, "Frame");
		GetTimeAtFrame_Frame_Offset = NativeReflectionCached.GetPropertyOffset(GetTimeAtFrame_FunctionAddress, "Frame");
		GetTimeAtFrame_Frame_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimeAtFrame_FunctionAddress, "Frame", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTimeAtFrame_Time_PropertyAddress, GetTimeAtFrame_FunctionAddress, "Time");
		GetTimeAtFrame_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetTimeAtFrame_FunctionAddress, "Time");
		GetTimeAtFrame_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimeAtFrame_FunctionAddress, "Time", Classes.FFloatProperty);
		GetTimeAtFrame_IsValid = GetTimeAtFrame_FunctionAddress != IntPtr.Zero && GetTimeAtFrame_AnimationSequenceBase_IsValid && GetTimeAtFrame_Frame_IsValid && GetTimeAtFrame_Time_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetTimeAtFrame", GetTimeAtFrame_IsValid);
		GetSequenceLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSequenceLength");
		GetSequenceLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequenceLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequenceLength_AnimationSequenceBase_PropertyAddress, GetSequenceLength_FunctionAddress, "AnimationSequenceBase");
		GetSequenceLength_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetSequenceLength_FunctionAddress, "AnimationSequenceBase");
		GetSequenceLength_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequenceLength_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSequenceLength_Length_PropertyAddress, GetSequenceLength_FunctionAddress, "Length");
		GetSequenceLength_Length_Offset = NativeReflectionCached.GetPropertyOffset(GetSequenceLength_FunctionAddress, "Length");
		GetSequenceLength_Length_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequenceLength_FunctionAddress, "Length", Classes.FFloatProperty);
		GetSequenceLength_IsValid = GetSequenceLength_FunctionAddress != IntPtr.Zero && GetSequenceLength_AnimationSequenceBase_IsValid && GetSequenceLength_Length_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetSequenceLength", GetSequenceLength_IsValid);
		GetRootMotionLockType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRootMotionLockType");
		GetRootMotionLockType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRootMotionLockType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRootMotionLockType_AnimationSequence_PropertyAddress, GetRootMotionLockType_FunctionAddress, "AnimationSequence");
		GetRootMotionLockType_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetRootMotionLockType_FunctionAddress, "AnimationSequence");
		GetRootMotionLockType_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRootMotionLockType_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRootMotionLockType_LockType_PropertyAddress, GetRootMotionLockType_FunctionAddress, "LockType");
		GetRootMotionLockType_LockType_Offset = NativeReflectionCached.GetPropertyOffset(GetRootMotionLockType_FunctionAddress, "LockType");
		GetRootMotionLockType_LockType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRootMotionLockType_FunctionAddress, "LockType", Classes.FByteProperty);
		GetRootMotionLockType_IsValid = GetRootMotionLockType_FunctionAddress != IntPtr.Zero && GetRootMotionLockType_AnimationSequence_IsValid && GetRootMotionLockType_LockType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRootMotionLockType", GetRootMotionLockType_IsValid);
		GetRawTrackScaleData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRawTrackScaleData");
		GetRawTrackScaleData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRawTrackScaleData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRawTrackScaleData_AnimationSequenceBase_PropertyAddress, GetRawTrackScaleData_FunctionAddress, "AnimationSequenceBase");
		GetRawTrackScaleData_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTrackScaleData_FunctionAddress, "AnimationSequenceBase");
		GetRawTrackScaleData_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTrackScaleData_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRawTrackScaleData_TrackName_PropertyAddress, GetRawTrackScaleData_FunctionAddress, "TrackName");
		GetRawTrackScaleData_TrackName_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTrackScaleData_FunctionAddress, "TrackName");
		GetRawTrackScaleData_TrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTrackScaleData_FunctionAddress, "TrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRawTrackScaleData_ScaleData_PropertyAddress, GetRawTrackScaleData_FunctionAddress, "ScaleData");
		GetRawTrackScaleData_ScaleData_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTrackScaleData_FunctionAddress, "ScaleData");
		GetRawTrackScaleData_ScaleData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTrackScaleData_FunctionAddress, "ScaleData", Classes.FArrayProperty);
		GetRawTrackScaleData_IsValid = GetRawTrackScaleData_FunctionAddress != IntPtr.Zero && GetRawTrackScaleData_AnimationSequenceBase_IsValid && GetRawTrackScaleData_TrackName_IsValid && GetRawTrackScaleData_ScaleData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRawTrackScaleData", GetRawTrackScaleData_IsValid);
		GetRawTrackRotationData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRawTrackRotationData");
		GetRawTrackRotationData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRawTrackRotationData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRawTrackRotationData_AnimationSequenceBase_PropertyAddress, GetRawTrackRotationData_FunctionAddress, "AnimationSequenceBase");
		GetRawTrackRotationData_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTrackRotationData_FunctionAddress, "AnimationSequenceBase");
		GetRawTrackRotationData_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTrackRotationData_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRawTrackRotationData_TrackName_PropertyAddress, GetRawTrackRotationData_FunctionAddress, "TrackName");
		GetRawTrackRotationData_TrackName_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTrackRotationData_FunctionAddress, "TrackName");
		GetRawTrackRotationData_TrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTrackRotationData_FunctionAddress, "TrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRawTrackRotationData_RotationData_PropertyAddress, GetRawTrackRotationData_FunctionAddress, "RotationData");
		GetRawTrackRotationData_RotationData_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTrackRotationData_FunctionAddress, "RotationData");
		GetRawTrackRotationData_RotationData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTrackRotationData_FunctionAddress, "RotationData", Classes.FArrayProperty);
		GetRawTrackRotationData_IsValid = GetRawTrackRotationData_FunctionAddress != IntPtr.Zero && GetRawTrackRotationData_AnimationSequenceBase_IsValid && GetRawTrackRotationData_TrackName_IsValid && GetRawTrackRotationData_RotationData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRawTrackRotationData", GetRawTrackRotationData_IsValid);
		GetRawTrackPositionData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRawTrackPositionData");
		GetRawTrackPositionData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRawTrackPositionData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRawTrackPositionData_AnimationSequenceBase_PropertyAddress, GetRawTrackPositionData_FunctionAddress, "AnimationSequenceBase");
		GetRawTrackPositionData_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTrackPositionData_FunctionAddress, "AnimationSequenceBase");
		GetRawTrackPositionData_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTrackPositionData_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRawTrackPositionData_TrackName_PropertyAddress, GetRawTrackPositionData_FunctionAddress, "TrackName");
		GetRawTrackPositionData_TrackName_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTrackPositionData_FunctionAddress, "TrackName");
		GetRawTrackPositionData_TrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTrackPositionData_FunctionAddress, "TrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRawTrackPositionData_PositionData_PropertyAddress, GetRawTrackPositionData_FunctionAddress, "PositionData");
		GetRawTrackPositionData_PositionData_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTrackPositionData_FunctionAddress, "PositionData");
		GetRawTrackPositionData_PositionData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTrackPositionData_FunctionAddress, "PositionData", Classes.FArrayProperty);
		GetRawTrackPositionData_IsValid = GetRawTrackPositionData_FunctionAddress != IntPtr.Zero && GetRawTrackPositionData_AnimationSequenceBase_IsValid && GetRawTrackPositionData_TrackName_IsValid && GetRawTrackPositionData_PositionData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRawTrackPositionData", GetRawTrackPositionData_IsValid);
		GetRawTrackData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRawTrackData");
		GetRawTrackData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRawTrackData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRawTrackData_AnimationSequenceBase_PropertyAddress, GetRawTrackData_FunctionAddress, "AnimationSequenceBase");
		GetRawTrackData_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTrackData_FunctionAddress, "AnimationSequenceBase");
		GetRawTrackData_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTrackData_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRawTrackData_TrackName_PropertyAddress, GetRawTrackData_FunctionAddress, "TrackName");
		GetRawTrackData_TrackName_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTrackData_FunctionAddress, "TrackName");
		GetRawTrackData_TrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTrackData_FunctionAddress, "TrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRawTrackData_PositionKeys_PropertyAddress, GetRawTrackData_FunctionAddress, "PositionKeys");
		GetRawTrackData_PositionKeys_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTrackData_FunctionAddress, "PositionKeys");
		GetRawTrackData_PositionKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTrackData_FunctionAddress, "PositionKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRawTrackData_RotationKeys_PropertyAddress, GetRawTrackData_FunctionAddress, "RotationKeys");
		GetRawTrackData_RotationKeys_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTrackData_FunctionAddress, "RotationKeys");
		GetRawTrackData_RotationKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTrackData_FunctionAddress, "RotationKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRawTrackData_ScalingKeys_PropertyAddress, GetRawTrackData_FunctionAddress, "ScalingKeys");
		GetRawTrackData_ScalingKeys_Offset = NativeReflectionCached.GetPropertyOffset(GetRawTrackData_FunctionAddress, "ScalingKeys");
		GetRawTrackData_ScalingKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRawTrackData_FunctionAddress, "ScalingKeys", Classes.FArrayProperty);
		GetRawTrackData_IsValid = GetRawTrackData_FunctionAddress != IntPtr.Zero && GetRawTrackData_AnimationSequenceBase_IsValid && GetRawTrackData_TrackName_IsValid && GetRawTrackData_PositionKeys_IsValid && GetRawTrackData_RotationKeys_IsValid && GetRawTrackData_ScalingKeys_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRawTrackData", GetRawTrackData_IsValid);
		GetRateScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRateScale");
		GetRateScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRateScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRateScale_AnimationSequenceBase_PropertyAddress, GetRateScale_FunctionAddress, "AnimationSequenceBase");
		GetRateScale_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetRateScale_FunctionAddress, "AnimationSequenceBase");
		GetRateScale_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRateScale_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRateScale_RateScale_PropertyAddress, GetRateScale_FunctionAddress, "RateScale");
		GetRateScale_RateScale_Offset = NativeReflectionCached.GetPropertyOffset(GetRateScale_FunctionAddress, "RateScale");
		GetRateScale_RateScale_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRateScale_FunctionAddress, "RateScale", Classes.FFloatProperty);
		GetRateScale_IsValid = GetRateScale_FunctionAddress != IntPtr.Zero && GetRateScale_AnimationSequenceBase_IsValid && GetRateScale_RateScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetRateScale", GetRateScale_IsValid);
		GetNumKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumKeys");
		GetNumKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumKeys_AnimationSequenceBase_PropertyAddress, GetNumKeys_FunctionAddress, "AnimationSequenceBase");
		GetNumKeys_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetNumKeys_FunctionAddress, "AnimationSequenceBase");
		GetNumKeys_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumKeys_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumKeys_NumKeys_PropertyAddress, GetNumKeys_FunctionAddress, "NumKeys");
		GetNumKeys_NumKeys_Offset = NativeReflectionCached.GetPropertyOffset(GetNumKeys_FunctionAddress, "NumKeys");
		GetNumKeys_NumKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumKeys_FunctionAddress, "NumKeys", Classes.FIntProperty);
		GetNumKeys_IsValid = GetNumKeys_FunctionAddress != IntPtr.Zero && GetNumKeys_AnimationSequenceBase_IsValid && GetNumKeys_NumKeys_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetNumKeys", GetNumKeys_IsValid);
		GetNumFrames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumFrames");
		GetNumFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumFrames_AnimationSequenceBase_PropertyAddress, GetNumFrames_FunctionAddress, "AnimationSequenceBase");
		GetNumFrames_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetNumFrames_FunctionAddress, "AnimationSequenceBase");
		GetNumFrames_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumFrames_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumFrames_NumFrames_PropertyAddress, GetNumFrames_FunctionAddress, "NumFrames");
		GetNumFrames_NumFrames_Offset = NativeReflectionCached.GetPropertyOffset(GetNumFrames_FunctionAddress, "NumFrames");
		GetNumFrames_NumFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumFrames_FunctionAddress, "NumFrames", Classes.FIntProperty);
		GetNumFrames_IsValid = GetNumFrames_FunctionAddress != IntPtr.Zero && GetNumFrames_AnimationSequenceBase_IsValid && GetNumFrames_NumFrames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetNumFrames", GetNumFrames_IsValid);
		GetNodesOfClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNodesOfClass");
		GetNodesOfClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodesOfClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodesOfClass_AnimationBlueprint_PropertyAddress, GetNodesOfClass_FunctionAddress, "AnimationBlueprint");
		GetNodesOfClass_AnimationBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(GetNodesOfClass_FunctionAddress, "AnimationBlueprint");
		GetNodesOfClass_AnimationBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodesOfClass_FunctionAddress, "AnimationBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNodesOfClass_NodeClass_PropertyAddress, GetNodesOfClass_FunctionAddress, "NodeClass");
		GetNodesOfClass_NodeClass_Offset = NativeReflectionCached.GetPropertyOffset(GetNodesOfClass_FunctionAddress, "NodeClass");
		GetNodesOfClass_NodeClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodesOfClass_FunctionAddress, "NodeClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNodesOfClass_GraphNodes_PropertyAddress, GetNodesOfClass_FunctionAddress, "GraphNodes");
		GetNodesOfClass_GraphNodes_Offset = NativeReflectionCached.GetPropertyOffset(GetNodesOfClass_FunctionAddress, "GraphNodes");
		GetNodesOfClass_GraphNodes_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodesOfClass_FunctionAddress, "GraphNodes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNodesOfClass_bIncludeChildClasses_PropertyAddress, GetNodesOfClass_FunctionAddress, "bIncludeChildClasses");
		GetNodesOfClass_bIncludeChildClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetNodesOfClass_FunctionAddress, "bIncludeChildClasses");
		GetNodesOfClass_bIncludeChildClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodesOfClass_FunctionAddress, "bIncludeChildClasses", Classes.FBoolProperty);
		GetNodesOfClass_IsValid = GetNodesOfClass_FunctionAddress != IntPtr.Zero && GetNodesOfClass_AnimationBlueprint_IsValid && GetNodesOfClass_NodeClass_IsValid && GetNodesOfClass_GraphNodes_IsValid && GetNodesOfClass_bIncludeChildClasses_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetNodesOfClass", GetNodesOfClass_IsValid);
		GetMetaDataOfClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMetaDataOfClass");
		GetMetaDataOfClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMetaDataOfClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMetaDataOfClass_AnimationAsset_PropertyAddress, GetMetaDataOfClass_FunctionAddress, "AnimationAsset");
		GetMetaDataOfClass_AnimationAsset_Offset = NativeReflectionCached.GetPropertyOffset(GetMetaDataOfClass_FunctionAddress, "AnimationAsset");
		GetMetaDataOfClass_AnimationAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetaDataOfClass_FunctionAddress, "AnimationAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMetaDataOfClass_MetaDataClass_PropertyAddress, GetMetaDataOfClass_FunctionAddress, "MetaDataClass");
		GetMetaDataOfClass_MetaDataClass_Offset = NativeReflectionCached.GetPropertyOffset(GetMetaDataOfClass_FunctionAddress, "MetaDataClass");
		GetMetaDataOfClass_MetaDataClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetaDataOfClass_FunctionAddress, "MetaDataClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMetaDataOfClass_MetaDataOfClass_PropertyAddress, GetMetaDataOfClass_FunctionAddress, "MetaDataOfClass");
		GetMetaDataOfClass_MetaDataOfClass_Offset = NativeReflectionCached.GetPropertyOffset(GetMetaDataOfClass_FunctionAddress, "MetaDataOfClass");
		GetMetaDataOfClass_MetaDataOfClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetaDataOfClass_FunctionAddress, "MetaDataOfClass", Classes.FArrayProperty);
		GetMetaDataOfClass_IsValid = GetMetaDataOfClass_FunctionAddress != IntPtr.Zero && GetMetaDataOfClass_AnimationAsset_IsValid && GetMetaDataOfClass_MetaDataClass_IsValid && GetMetaDataOfClass_MetaDataOfClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetMetaDataOfClass", GetMetaDataOfClass_IsValid);
		GetMetaData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMetaData");
		GetMetaData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMetaData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMetaData_AnimationAsset_PropertyAddress, GetMetaData_FunctionAddress, "AnimationAsset");
		GetMetaData_AnimationAsset_Offset = NativeReflectionCached.GetPropertyOffset(GetMetaData_FunctionAddress, "AnimationAsset");
		GetMetaData_AnimationAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetaData_FunctionAddress, "AnimationAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMetaData_MetaData_PropertyAddress, GetMetaData_FunctionAddress, "MetaData");
		GetMetaData_MetaData_Offset = NativeReflectionCached.GetPropertyOffset(GetMetaData_FunctionAddress, "MetaData");
		GetMetaData_MetaData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetaData_FunctionAddress, "MetaData", Classes.FArrayProperty);
		GetMetaData_IsValid = GetMetaData_FunctionAddress != IntPtr.Zero && GetMetaData_AnimationAsset_IsValid && GetMetaData_MetaData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetMetaData", GetMetaData_IsValid);
		GetFrameAtTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFrameAtTime");
		GetFrameAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFrameAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFrameAtTime_AnimationSequenceBase_PropertyAddress, GetFrameAtTime_FunctionAddress, "AnimationSequenceBase");
		GetFrameAtTime_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetFrameAtTime_FunctionAddress, "AnimationSequenceBase");
		GetFrameAtTime_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFrameAtTime_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFrameAtTime_Time_PropertyAddress, GetFrameAtTime_FunctionAddress, "Time");
		GetFrameAtTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetFrameAtTime_FunctionAddress, "Time");
		GetFrameAtTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFrameAtTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFrameAtTime_Frame_PropertyAddress, GetFrameAtTime_FunctionAddress, "Frame");
		GetFrameAtTime_Frame_Offset = NativeReflectionCached.GetPropertyOffset(GetFrameAtTime_FunctionAddress, "Frame");
		GetFrameAtTime_Frame_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFrameAtTime_FunctionAddress, "Frame", Classes.FIntProperty);
		GetFrameAtTime_IsValid = GetFrameAtTime_FunctionAddress != IntPtr.Zero && GetFrameAtTime_AnimationSequenceBase_IsValid && GetFrameAtTime_Time_IsValid && GetFrameAtTime_Frame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetFrameAtTime", GetFrameAtTime_IsValid);
		GetFloatKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFloatKeys");
		GetFloatKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloatKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloatKeys_AnimationSequence_PropertyAddress, GetFloatKeys_FunctionAddress, "AnimationSequence");
		GetFloatKeys_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatKeys_FunctionAddress, "AnimationSequence");
		GetFloatKeys_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatKeys_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatKeys_CurveName_PropertyAddress, GetFloatKeys_FunctionAddress, "CurveName");
		GetFloatKeys_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatKeys_FunctionAddress, "CurveName");
		GetFloatKeys_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatKeys_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatKeys_Times_PropertyAddress, GetFloatKeys_FunctionAddress, "Times");
		GetFloatKeys_Times_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatKeys_FunctionAddress, "Times");
		GetFloatKeys_Times_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatKeys_FunctionAddress, "Times", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatKeys_Values_PropertyAddress, GetFloatKeys_FunctionAddress, "Values");
		GetFloatKeys_Values_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatKeys_FunctionAddress, "Values");
		GetFloatKeys_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatKeys_FunctionAddress, "Values", Classes.FArrayProperty);
		GetFloatKeys_IsValid = GetFloatKeys_FunctionAddress != IntPtr.Zero && GetFloatKeys_AnimationSequence_IsValid && GetFloatKeys_CurveName_IsValid && GetFloatKeys_Times_IsValid && GetFloatKeys_Values_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetFloatKeys", GetFloatKeys_IsValid);
		GetCurveCompressionSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurveCompressionSettings");
		GetCurveCompressionSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurveCompressionSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurveCompressionSettings_AnimationSequence_PropertyAddress, GetCurveCompressionSettings_FunctionAddress, "AnimationSequence");
		GetCurveCompressionSettings_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveCompressionSettings_FunctionAddress, "AnimationSequence");
		GetCurveCompressionSettings_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveCompressionSettings_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurveCompressionSettings_CompressionSettings_PropertyAddress, GetCurveCompressionSettings_FunctionAddress, "CompressionSettings");
		GetCurveCompressionSettings_CompressionSettings_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveCompressionSettings_FunctionAddress, "CompressionSettings");
		GetCurveCompressionSettings_CompressionSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveCompressionSettings_FunctionAddress, "CompressionSettings", Classes.FObjectProperty);
		GetCurveCompressionSettings_IsValid = GetCurveCompressionSettings_FunctionAddress != IntPtr.Zero && GetCurveCompressionSettings_AnimationSequence_IsValid && GetCurveCompressionSettings_CompressionSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetCurveCompressionSettings", GetCurveCompressionSettings_IsValid);
		GetBonePosesForTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBonePosesForTime");
		GetBonePosesForTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBonePosesForTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBonePosesForTime_AnimationSequenceBase_PropertyAddress, GetBonePosesForTime_FunctionAddress, "AnimationSequenceBase");
		GetBonePosesForTime_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePosesForTime_FunctionAddress, "AnimationSequenceBase");
		GetBonePosesForTime_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePosesForTime_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePosesForTime_BoneNames_PropertyAddress, GetBonePosesForTime_FunctionAddress, "BoneNames");
		GetBonePosesForTime_BoneNames_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePosesForTime_FunctionAddress, "BoneNames");
		GetBonePosesForTime_BoneNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePosesForTime_FunctionAddress, "BoneNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePosesForTime_Time_PropertyAddress, GetBonePosesForTime_FunctionAddress, "Time");
		GetBonePosesForTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePosesForTime_FunctionAddress, "Time");
		GetBonePosesForTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePosesForTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePosesForTime_bExtractRootMotion_PropertyAddress, GetBonePosesForTime_FunctionAddress, "bExtractRootMotion");
		GetBonePosesForTime_bExtractRootMotion_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePosesForTime_FunctionAddress, "bExtractRootMotion");
		GetBonePosesForTime_bExtractRootMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePosesForTime_FunctionAddress, "bExtractRootMotion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePosesForTime_Poses_PropertyAddress, GetBonePosesForTime_FunctionAddress, "Poses");
		GetBonePosesForTime_Poses_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePosesForTime_FunctionAddress, "Poses");
		GetBonePosesForTime_Poses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePosesForTime_FunctionAddress, "Poses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePosesForTime_PreviewMesh_PropertyAddress, GetBonePosesForTime_FunctionAddress, "PreviewMesh");
		GetBonePosesForTime_PreviewMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePosesForTime_FunctionAddress, "PreviewMesh");
		GetBonePosesForTime_PreviewMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePosesForTime_FunctionAddress, "PreviewMesh", Classes.FObjectProperty);
		GetBonePosesForTime_IsValid = GetBonePosesForTime_FunctionAddress != IntPtr.Zero && GetBonePosesForTime_AnimationSequenceBase_IsValid && GetBonePosesForTime_BoneNames_IsValid && GetBonePosesForTime_Time_IsValid && GetBonePosesForTime_bExtractRootMotion_IsValid && GetBonePosesForTime_Poses_IsValid && GetBonePosesForTime_PreviewMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBonePosesForTime", GetBonePosesForTime_IsValid);
		GetBonePosesForFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBonePosesForFrame");
		GetBonePosesForFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBonePosesForFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBonePosesForFrame_AnimationSequenceBase_PropertyAddress, GetBonePosesForFrame_FunctionAddress, "AnimationSequenceBase");
		GetBonePosesForFrame_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePosesForFrame_FunctionAddress, "AnimationSequenceBase");
		GetBonePosesForFrame_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePosesForFrame_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePosesForFrame_BoneNames_PropertyAddress, GetBonePosesForFrame_FunctionAddress, "BoneNames");
		GetBonePosesForFrame_BoneNames_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePosesForFrame_FunctionAddress, "BoneNames");
		GetBonePosesForFrame_BoneNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePosesForFrame_FunctionAddress, "BoneNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePosesForFrame_Frame_PropertyAddress, GetBonePosesForFrame_FunctionAddress, "Frame");
		GetBonePosesForFrame_Frame_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePosesForFrame_FunctionAddress, "Frame");
		GetBonePosesForFrame_Frame_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePosesForFrame_FunctionAddress, "Frame", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePosesForFrame_bExtractRootMotion_PropertyAddress, GetBonePosesForFrame_FunctionAddress, "bExtractRootMotion");
		GetBonePosesForFrame_bExtractRootMotion_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePosesForFrame_FunctionAddress, "bExtractRootMotion");
		GetBonePosesForFrame_bExtractRootMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePosesForFrame_FunctionAddress, "bExtractRootMotion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePosesForFrame_Poses_PropertyAddress, GetBonePosesForFrame_FunctionAddress, "Poses");
		GetBonePosesForFrame_Poses_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePosesForFrame_FunctionAddress, "Poses");
		GetBonePosesForFrame_Poses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePosesForFrame_FunctionAddress, "Poses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePosesForFrame_PreviewMesh_PropertyAddress, GetBonePosesForFrame_FunctionAddress, "PreviewMesh");
		GetBonePosesForFrame_PreviewMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePosesForFrame_FunctionAddress, "PreviewMesh");
		GetBonePosesForFrame_PreviewMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePosesForFrame_FunctionAddress, "PreviewMesh", Classes.FObjectProperty);
		GetBonePosesForFrame_IsValid = GetBonePosesForFrame_FunctionAddress != IntPtr.Zero && GetBonePosesForFrame_AnimationSequenceBase_IsValid && GetBonePosesForFrame_BoneNames_IsValid && GetBonePosesForFrame_Frame_IsValid && GetBonePosesForFrame_bExtractRootMotion_IsValid && GetBonePosesForFrame_Poses_IsValid && GetBonePosesForFrame_PreviewMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBonePosesForFrame", GetBonePosesForFrame_IsValid);
		GetBonePoseForTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBonePoseForTime");
		GetBonePoseForTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBonePoseForTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBonePoseForTime_AnimationSequenceBase_PropertyAddress, GetBonePoseForTime_FunctionAddress, "AnimationSequenceBase");
		GetBonePoseForTime_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePoseForTime_FunctionAddress, "AnimationSequenceBase");
		GetBonePoseForTime_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePoseForTime_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePoseForTime_BoneName_PropertyAddress, GetBonePoseForTime_FunctionAddress, "BoneName");
		GetBonePoseForTime_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePoseForTime_FunctionAddress, "BoneName");
		GetBonePoseForTime_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePoseForTime_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePoseForTime_Time_PropertyAddress, GetBonePoseForTime_FunctionAddress, "Time");
		GetBonePoseForTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePoseForTime_FunctionAddress, "Time");
		GetBonePoseForTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePoseForTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePoseForTime_bExtractRootMotion_PropertyAddress, GetBonePoseForTime_FunctionAddress, "bExtractRootMotion");
		GetBonePoseForTime_bExtractRootMotion_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePoseForTime_FunctionAddress, "bExtractRootMotion");
		GetBonePoseForTime_bExtractRootMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePoseForTime_FunctionAddress, "bExtractRootMotion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePoseForTime_Pose_PropertyAddress, GetBonePoseForTime_FunctionAddress, "Pose");
		GetBonePoseForTime_Pose_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePoseForTime_FunctionAddress, "Pose");
		GetBonePoseForTime_Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePoseForTime_FunctionAddress, "Pose", Classes.FStructProperty);
		GetBonePoseForTime_IsValid = GetBonePoseForTime_FunctionAddress != IntPtr.Zero && GetBonePoseForTime_AnimationSequenceBase_IsValid && GetBonePoseForTime_BoneName_IsValid && GetBonePoseForTime_Time_IsValid && GetBonePoseForTime_bExtractRootMotion_IsValid && GetBonePoseForTime_Pose_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBonePoseForTime", GetBonePoseForTime_IsValid);
		GetBonePoseForFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBonePoseForFrame");
		GetBonePoseForFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBonePoseForFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBonePoseForFrame_AnimationSequenceBase_PropertyAddress, GetBonePoseForFrame_FunctionAddress, "AnimationSequenceBase");
		GetBonePoseForFrame_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePoseForFrame_FunctionAddress, "AnimationSequenceBase");
		GetBonePoseForFrame_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePoseForFrame_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePoseForFrame_BoneName_PropertyAddress, GetBonePoseForFrame_FunctionAddress, "BoneName");
		GetBonePoseForFrame_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePoseForFrame_FunctionAddress, "BoneName");
		GetBonePoseForFrame_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePoseForFrame_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePoseForFrame_Frame_PropertyAddress, GetBonePoseForFrame_FunctionAddress, "Frame");
		GetBonePoseForFrame_Frame_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePoseForFrame_FunctionAddress, "Frame");
		GetBonePoseForFrame_Frame_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePoseForFrame_FunctionAddress, "Frame", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePoseForFrame_bExtractRootMotion_PropertyAddress, GetBonePoseForFrame_FunctionAddress, "bExtractRootMotion");
		GetBonePoseForFrame_bExtractRootMotion_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePoseForFrame_FunctionAddress, "bExtractRootMotion");
		GetBonePoseForFrame_bExtractRootMotion_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePoseForFrame_FunctionAddress, "bExtractRootMotion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePoseForFrame_Pose_PropertyAddress, GetBonePoseForFrame_FunctionAddress, "Pose");
		GetBonePoseForFrame_Pose_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePoseForFrame_FunctionAddress, "Pose");
		GetBonePoseForFrame_Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePoseForFrame_FunctionAddress, "Pose", Classes.FStructProperty);
		GetBonePoseForFrame_IsValid = GetBonePoseForFrame_FunctionAddress != IntPtr.Zero && GetBonePoseForFrame_AnimationSequenceBase_IsValid && GetBonePoseForFrame_BoneName_IsValid && GetBonePoseForFrame_Frame_IsValid && GetBonePoseForFrame_bExtractRootMotion_IsValid && GetBonePoseForFrame_Pose_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBonePoseForFrame", GetBonePoseForFrame_IsValid);
		GetBoneCompressionSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoneCompressionSettings");
		GetBoneCompressionSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneCompressionSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneCompressionSettings_AnimationSequence_PropertyAddress, GetBoneCompressionSettings_FunctionAddress, "AnimationSequence");
		GetBoneCompressionSettings_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneCompressionSettings_FunctionAddress, "AnimationSequence");
		GetBoneCompressionSettings_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneCompressionSettings_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneCompressionSettings_CompressionSettings_PropertyAddress, GetBoneCompressionSettings_FunctionAddress, "CompressionSettings");
		GetBoneCompressionSettings_CompressionSettings_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneCompressionSettings_FunctionAddress, "CompressionSettings");
		GetBoneCompressionSettings_CompressionSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneCompressionSettings_FunctionAddress, "CompressionSettings", Classes.FObjectProperty);
		GetBoneCompressionSettings_IsValid = GetBoneCompressionSettings_FunctionAddress != IntPtr.Zero && GetBoneCompressionSettings_AnimationSequence_IsValid && GetBoneCompressionSettings_CompressionSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetBoneCompressionSettings", GetBoneCompressionSettings_IsValid);
		GetAnimNotifyEventTriggerTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimNotifyEventTriggerTime");
		GetAnimNotifyEventTriggerTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNotifyEventTriggerTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimNotifyEventTriggerTime_NotifyEvent_PropertyAddress, GetAnimNotifyEventTriggerTime_FunctionAddress, "NotifyEvent");
		GetAnimNotifyEventTriggerTime_NotifyEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimNotifyEventTriggerTime_FunctionAddress, "NotifyEvent");
		GetAnimNotifyEventTriggerTime_NotifyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimNotifyEventTriggerTime_FunctionAddress, "NotifyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimNotifyEventTriggerTime_ReturnValue_PropertyAddress, GetAnimNotifyEventTriggerTime_FunctionAddress, "ReturnValue");
		GetAnimNotifyEventTriggerTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimNotifyEventTriggerTime_FunctionAddress, "ReturnValue");
		GetAnimNotifyEventTriggerTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimNotifyEventTriggerTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAnimNotifyEventTriggerTime_IsValid = GetAnimNotifyEventTriggerTime_FunctionAddress != IntPtr.Zero && GetAnimNotifyEventTriggerTime_NotifyEvent_IsValid && GetAnimNotifyEventTriggerTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimNotifyEventTriggerTime", GetAnimNotifyEventTriggerTime_IsValid);
		GetAnimNotifyEventDuration_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimNotifyEventDuration");
		GetAnimNotifyEventDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNotifyEventDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimNotifyEventDuration_NotifyEvent_PropertyAddress, GetAnimNotifyEventDuration_FunctionAddress, "NotifyEvent");
		GetAnimNotifyEventDuration_NotifyEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimNotifyEventDuration_FunctionAddress, "NotifyEvent");
		GetAnimNotifyEventDuration_NotifyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimNotifyEventDuration_FunctionAddress, "NotifyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimNotifyEventDuration_ReturnValue_PropertyAddress, GetAnimNotifyEventDuration_FunctionAddress, "ReturnValue");
		GetAnimNotifyEventDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimNotifyEventDuration_FunctionAddress, "ReturnValue");
		GetAnimNotifyEventDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimNotifyEventDuration_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAnimNotifyEventDuration_IsValid = GetAnimNotifyEventDuration_FunctionAddress != IntPtr.Zero && GetAnimNotifyEventDuration_NotifyEvent_IsValid && GetAnimNotifyEventDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimNotifyEventDuration", GetAnimNotifyEventDuration_IsValid);
		GetAnimationTrackNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationTrackNames");
		GetAnimationTrackNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationTrackNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationTrackNames_AnimationSequenceBase_PropertyAddress, GetAnimationTrackNames_FunctionAddress, "AnimationSequenceBase");
		GetAnimationTrackNames_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationTrackNames_FunctionAddress, "AnimationSequenceBase");
		GetAnimationTrackNames_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationTrackNames_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationTrackNames_TrackNames_PropertyAddress, GetAnimationTrackNames_FunctionAddress, "TrackNames");
		GetAnimationTrackNames_TrackNames_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationTrackNames_FunctionAddress, "TrackNames");
		GetAnimationTrackNames_TrackNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationTrackNames_FunctionAddress, "TrackNames", Classes.FArrayProperty);
		GetAnimationTrackNames_IsValid = GetAnimationTrackNames_FunctionAddress != IntPtr.Zero && GetAnimationTrackNames_AnimationSequenceBase_IsValid && GetAnimationTrackNames_TrackNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationTrackNames", GetAnimationTrackNames_IsValid);
		GetAnimationSyncMarkersForTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationSyncMarkersForTrack");
		GetAnimationSyncMarkersForTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationSyncMarkersForTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationSyncMarkersForTrack_AnimationSequence_PropertyAddress, GetAnimationSyncMarkersForTrack_FunctionAddress, "AnimationSequence");
		GetAnimationSyncMarkersForTrack_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationSyncMarkersForTrack_FunctionAddress, "AnimationSequence");
		GetAnimationSyncMarkersForTrack_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationSyncMarkersForTrack_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationSyncMarkersForTrack_NotifyTrackName_PropertyAddress, GetAnimationSyncMarkersForTrack_FunctionAddress, "NotifyTrackName");
		GetAnimationSyncMarkersForTrack_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationSyncMarkersForTrack_FunctionAddress, "NotifyTrackName");
		GetAnimationSyncMarkersForTrack_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationSyncMarkersForTrack_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationSyncMarkersForTrack_Markers_PropertyAddress, GetAnimationSyncMarkersForTrack_FunctionAddress, "Markers");
		GetAnimationSyncMarkersForTrack_Markers_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationSyncMarkersForTrack_FunctionAddress, "Markers");
		GetAnimationSyncMarkersForTrack_Markers_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationSyncMarkersForTrack_FunctionAddress, "Markers", Classes.FArrayProperty);
		GetAnimationSyncMarkersForTrack_IsValid = GetAnimationSyncMarkersForTrack_FunctionAddress != IntPtr.Zero && GetAnimationSyncMarkersForTrack_AnimationSequence_IsValid && GetAnimationSyncMarkersForTrack_NotifyTrackName_IsValid && GetAnimationSyncMarkersForTrack_Markers_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationSyncMarkersForTrack", GetAnimationSyncMarkersForTrack_IsValid);
		GetAnimationSyncMarkers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationSyncMarkers");
		GetAnimationSyncMarkers_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationSyncMarkers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationSyncMarkers_AnimationSequence_PropertyAddress, GetAnimationSyncMarkers_FunctionAddress, "AnimationSequence");
		GetAnimationSyncMarkers_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationSyncMarkers_FunctionAddress, "AnimationSequence");
		GetAnimationSyncMarkers_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationSyncMarkers_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationSyncMarkers_Markers_PropertyAddress, GetAnimationSyncMarkers_FunctionAddress, "Markers");
		GetAnimationSyncMarkers_Markers_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationSyncMarkers_FunctionAddress, "Markers");
		GetAnimationSyncMarkers_Markers_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationSyncMarkers_FunctionAddress, "Markers", Classes.FArrayProperty);
		GetAnimationSyncMarkers_IsValid = GetAnimationSyncMarkers_FunctionAddress != IntPtr.Zero && GetAnimationSyncMarkers_AnimationSequence_IsValid && GetAnimationSyncMarkers_Markers_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationSyncMarkers", GetAnimationSyncMarkers_IsValid);
		GetAnimationNotifyTrackNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationNotifyTrackNames");
		GetAnimationNotifyTrackNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationNotifyTrackNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationNotifyTrackNames_AnimationSequenceBase_PropertyAddress, GetAnimationNotifyTrackNames_FunctionAddress, "AnimationSequenceBase");
		GetAnimationNotifyTrackNames_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationNotifyTrackNames_FunctionAddress, "AnimationSequenceBase");
		GetAnimationNotifyTrackNames_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationNotifyTrackNames_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationNotifyTrackNames_TrackNames_PropertyAddress, GetAnimationNotifyTrackNames_FunctionAddress, "TrackNames");
		GetAnimationNotifyTrackNames_TrackNames_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationNotifyTrackNames_FunctionAddress, "TrackNames");
		GetAnimationNotifyTrackNames_TrackNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationNotifyTrackNames_FunctionAddress, "TrackNames", Classes.FArrayProperty);
		GetAnimationNotifyTrackNames_IsValid = GetAnimationNotifyTrackNames_FunctionAddress != IntPtr.Zero && GetAnimationNotifyTrackNames_AnimationSequenceBase_IsValid && GetAnimationNotifyTrackNames_TrackNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationNotifyTrackNames", GetAnimationNotifyTrackNames_IsValid);
		GetAnimationNotifyEventsForTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationNotifyEventsForTrack");
		GetAnimationNotifyEventsForTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationNotifyEventsForTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationNotifyEventsForTrack_AnimationSequenceBase_PropertyAddress, GetAnimationNotifyEventsForTrack_FunctionAddress, "AnimationSequenceBase");
		GetAnimationNotifyEventsForTrack_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationNotifyEventsForTrack_FunctionAddress, "AnimationSequenceBase");
		GetAnimationNotifyEventsForTrack_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationNotifyEventsForTrack_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationNotifyEventsForTrack_NotifyTrackName_PropertyAddress, GetAnimationNotifyEventsForTrack_FunctionAddress, "NotifyTrackName");
		GetAnimationNotifyEventsForTrack_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationNotifyEventsForTrack_FunctionAddress, "NotifyTrackName");
		GetAnimationNotifyEventsForTrack_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationNotifyEventsForTrack_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationNotifyEventsForTrack_Events_PropertyAddress, GetAnimationNotifyEventsForTrack_FunctionAddress, "Events");
		GetAnimationNotifyEventsForTrack_Events_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationNotifyEventsForTrack_FunctionAddress, "Events");
		GetAnimationNotifyEventsForTrack_Events_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationNotifyEventsForTrack_FunctionAddress, "Events", Classes.FArrayProperty);
		GetAnimationNotifyEventsForTrack_IsValid = GetAnimationNotifyEventsForTrack_FunctionAddress != IntPtr.Zero && GetAnimationNotifyEventsForTrack_AnimationSequenceBase_IsValid && GetAnimationNotifyEventsForTrack_NotifyTrackName_IsValid && GetAnimationNotifyEventsForTrack_Events_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationNotifyEventsForTrack", GetAnimationNotifyEventsForTrack_IsValid);
		GetAnimationNotifyEvents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationNotifyEvents");
		GetAnimationNotifyEvents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationNotifyEvents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationNotifyEvents_AnimationSequenceBase_PropertyAddress, GetAnimationNotifyEvents_FunctionAddress, "AnimationSequenceBase");
		GetAnimationNotifyEvents_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationNotifyEvents_FunctionAddress, "AnimationSequenceBase");
		GetAnimationNotifyEvents_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationNotifyEvents_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationNotifyEvents_NotifyEvents_PropertyAddress, GetAnimationNotifyEvents_FunctionAddress, "NotifyEvents");
		GetAnimationNotifyEvents_NotifyEvents_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationNotifyEvents_FunctionAddress, "NotifyEvents");
		GetAnimationNotifyEvents_NotifyEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationNotifyEvents_FunctionAddress, "NotifyEvents", Classes.FArrayProperty);
		GetAnimationNotifyEvents_IsValid = GetAnimationNotifyEvents_FunctionAddress != IntPtr.Zero && GetAnimationNotifyEvents_AnimationSequenceBase_IsValid && GetAnimationNotifyEvents_NotifyEvents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationNotifyEvents", GetAnimationNotifyEvents_IsValid);
		GetAnimationNotifyEventNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationNotifyEventNames");
		GetAnimationNotifyEventNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationNotifyEventNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationNotifyEventNames_AnimationSequenceBase_PropertyAddress, GetAnimationNotifyEventNames_FunctionAddress, "AnimationSequenceBase");
		GetAnimationNotifyEventNames_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationNotifyEventNames_FunctionAddress, "AnimationSequenceBase");
		GetAnimationNotifyEventNames_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationNotifyEventNames_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationNotifyEventNames_EventNames_PropertyAddress, GetAnimationNotifyEventNames_FunctionAddress, "EventNames");
		GetAnimationNotifyEventNames_EventNames_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationNotifyEventNames_FunctionAddress, "EventNames");
		GetAnimationNotifyEventNames_EventNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationNotifyEventNames_FunctionAddress, "EventNames", Classes.FArrayProperty);
		GetAnimationNotifyEventNames_IsValid = GetAnimationNotifyEventNames_FunctionAddress != IntPtr.Zero && GetAnimationNotifyEventNames_AnimationSequenceBase_IsValid && GetAnimationNotifyEventNames_EventNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationNotifyEventNames", GetAnimationNotifyEventNames_IsValid);
		GetAnimationInterpolationType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationInterpolationType");
		GetAnimationInterpolationType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationInterpolationType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationInterpolationType_AnimationSequence_PropertyAddress, GetAnimationInterpolationType_FunctionAddress, "AnimationSequence");
		GetAnimationInterpolationType_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationInterpolationType_FunctionAddress, "AnimationSequence");
		GetAnimationInterpolationType_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationInterpolationType_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationInterpolationType_InterpolationType_PropertyAddress, GetAnimationInterpolationType_FunctionAddress, "InterpolationType");
		GetAnimationInterpolationType_InterpolationType_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationInterpolationType_FunctionAddress, "InterpolationType");
		GetAnimationInterpolationType_InterpolationType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationInterpolationType_FunctionAddress, "InterpolationType", Classes.FEnumProperty);
		GetAnimationInterpolationType_IsValid = GetAnimationInterpolationType_FunctionAddress != IntPtr.Zero && GetAnimationInterpolationType_AnimationSequence_IsValid && GetAnimationInterpolationType_InterpolationType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationInterpolationType", GetAnimationInterpolationType_IsValid);
		GetAnimationGraphs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationGraphs");
		GetAnimationGraphs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationGraphs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationGraphs_AnimationBlueprint_PropertyAddress, GetAnimationGraphs_FunctionAddress, "AnimationBlueprint");
		GetAnimationGraphs_AnimationBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationGraphs_FunctionAddress, "AnimationBlueprint");
		GetAnimationGraphs_AnimationBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationGraphs_FunctionAddress, "AnimationBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationGraphs_AnimationGraphs_PropertyAddress, GetAnimationGraphs_FunctionAddress, "AnimationGraphs");
		GetAnimationGraphs_AnimationGraphs_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationGraphs_FunctionAddress, "AnimationGraphs");
		GetAnimationGraphs_AnimationGraphs_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationGraphs_FunctionAddress, "AnimationGraphs", Classes.FArrayProperty);
		GetAnimationGraphs_IsValid = GetAnimationGraphs_FunctionAddress != IntPtr.Zero && GetAnimationGraphs_AnimationBlueprint_IsValid && GetAnimationGraphs_AnimationGraphs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationGraphs", GetAnimationGraphs_IsValid);
		GetAnimationCurveNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationCurveNames");
		GetAnimationCurveNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationCurveNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationCurveNames_AnimationSequence_PropertyAddress, GetAnimationCurveNames_FunctionAddress, "AnimationSequence");
		GetAnimationCurveNames_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationCurveNames_FunctionAddress, "AnimationSequence");
		GetAnimationCurveNames_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationCurveNames_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationCurveNames_CurveType_PropertyAddress, GetAnimationCurveNames_FunctionAddress, "CurveType");
		GetAnimationCurveNames_CurveType_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationCurveNames_FunctionAddress, "CurveType");
		GetAnimationCurveNames_CurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationCurveNames_FunctionAddress, "CurveType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationCurveNames_CurveNames_PropertyAddress, GetAnimationCurveNames_FunctionAddress, "CurveNames");
		GetAnimationCurveNames_CurveNames_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationCurveNames_FunctionAddress, "CurveNames");
		GetAnimationCurveNames_CurveNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationCurveNames_FunctionAddress, "CurveNames", Classes.FArrayProperty);
		GetAnimationCurveNames_IsValid = GetAnimationCurveNames_FunctionAddress != IntPtr.Zero && GetAnimationCurveNames_AnimationSequence_IsValid && GetAnimationCurveNames_CurveType_IsValid && GetAnimationCurveNames_CurveNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAnimationCurveNames", GetAnimationCurveNames_IsValid);
		GetAdditiveBasePoseType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAdditiveBasePoseType");
		GetAdditiveBasePoseType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAdditiveBasePoseType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAdditiveBasePoseType_AnimationSequence_PropertyAddress, GetAdditiveBasePoseType_FunctionAddress, "AnimationSequence");
		GetAdditiveBasePoseType_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAdditiveBasePoseType_FunctionAddress, "AnimationSequence");
		GetAdditiveBasePoseType_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAdditiveBasePoseType_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAdditiveBasePoseType_AdditiveBasePoseType_PropertyAddress, GetAdditiveBasePoseType_FunctionAddress, "AdditiveBasePoseType");
		GetAdditiveBasePoseType_AdditiveBasePoseType_Offset = NativeReflectionCached.GetPropertyOffset(GetAdditiveBasePoseType_FunctionAddress, "AdditiveBasePoseType");
		GetAdditiveBasePoseType_AdditiveBasePoseType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAdditiveBasePoseType_FunctionAddress, "AdditiveBasePoseType", Classes.FByteProperty);
		GetAdditiveBasePoseType_IsValid = GetAdditiveBasePoseType_FunctionAddress != IntPtr.Zero && GetAdditiveBasePoseType_AnimationSequence_IsValid && GetAdditiveBasePoseType_AdditiveBasePoseType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAdditiveBasePoseType", GetAdditiveBasePoseType_IsValid);
		GetAdditiveAnimationType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAdditiveAnimationType");
		GetAdditiveAnimationType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAdditiveAnimationType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAdditiveAnimationType_AnimationSequence_PropertyAddress, GetAdditiveAnimationType_FunctionAddress, "AnimationSequence");
		GetAdditiveAnimationType_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAdditiveAnimationType_FunctionAddress, "AnimationSequence");
		GetAdditiveAnimationType_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAdditiveAnimationType_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAdditiveAnimationType_AdditiveAnimationType_PropertyAddress, GetAdditiveAnimationType_FunctionAddress, "AdditiveAnimationType");
		GetAdditiveAnimationType_AdditiveAnimationType_Offset = NativeReflectionCached.GetPropertyOffset(GetAdditiveAnimationType_FunctionAddress, "AdditiveAnimationType");
		GetAdditiveAnimationType_AdditiveAnimationType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAdditiveAnimationType_FunctionAddress, "AdditiveAnimationType", Classes.FByteProperty);
		GetAdditiveAnimationType_IsValid = GetAdditiveAnimationType_FunctionAddress != IntPtr.Zero && GetAdditiveAnimationType_AnimationSequence_IsValid && GetAdditiveAnimationType_AdditiveAnimationType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:GetAdditiveAnimationType", GetAdditiveAnimationType_IsValid);
		FindBonePathToRoot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindBonePathToRoot");
		FindBonePathToRoot_ParamsSize = NativeReflection.GetFunctionParamsSize(FindBonePathToRoot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindBonePathToRoot_AnimationSequenceBase_PropertyAddress, FindBonePathToRoot_FunctionAddress, "AnimationSequenceBase");
		FindBonePathToRoot_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(FindBonePathToRoot_FunctionAddress, "AnimationSequenceBase");
		FindBonePathToRoot_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBonePathToRoot_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindBonePathToRoot_BoneName_PropertyAddress, FindBonePathToRoot_FunctionAddress, "BoneName");
		FindBonePathToRoot_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(FindBonePathToRoot_FunctionAddress, "BoneName");
		FindBonePathToRoot_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBonePathToRoot_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindBonePathToRoot_BonePath_PropertyAddress, FindBonePathToRoot_FunctionAddress, "BonePath");
		FindBonePathToRoot_BonePath_Offset = NativeReflectionCached.GetPropertyOffset(FindBonePathToRoot_FunctionAddress, "BonePath");
		FindBonePathToRoot_BonePath_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBonePathToRoot_FunctionAddress, "BonePath", Classes.FArrayProperty);
		FindBonePathToRoot_IsValid = FindBonePathToRoot_FunctionAddress != IntPtr.Zero && FindBonePathToRoot_AnimationSequenceBase_IsValid && FindBonePathToRoot_BoneName_IsValid && FindBonePathToRoot_BonePath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:FindBonePathToRoot", FindBonePathToRoot_IsValid);
		EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EvaluateRootBoneTimecodeAttributesAtTime");
		EvaluateRootBoneTimecodeAttributesAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EvaluateRootBoneTimecodeAttributesAtTime_AnimationSequenceBase_PropertyAddress, EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress, "AnimationSequenceBase");
		EvaluateRootBoneTimecodeAttributesAtTime_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress, "AnimationSequenceBase");
		EvaluateRootBoneTimecodeAttributesAtTime_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateRootBoneTimecodeAttributesAtTime_EvalTime_PropertyAddress, EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress, "EvalTime");
		EvaluateRootBoneTimecodeAttributesAtTime_EvalTime_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress, "EvalTime");
		EvaluateRootBoneTimecodeAttributesAtTime_EvalTime_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress, "EvalTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateRootBoneTimecodeAttributesAtTime_OutQualifiedFrameTime_PropertyAddress, EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress, "OutQualifiedFrameTime");
		EvaluateRootBoneTimecodeAttributesAtTime_OutQualifiedFrameTime_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress, "OutQualifiedFrameTime");
		EvaluateRootBoneTimecodeAttributesAtTime_OutQualifiedFrameTime_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress, "OutQualifiedFrameTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateRootBoneTimecodeAttributesAtTime_ReturnValue_PropertyAddress, EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress, "ReturnValue");
		EvaluateRootBoneTimecodeAttributesAtTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress, "ReturnValue");
		EvaluateRootBoneTimecodeAttributesAtTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EvaluateRootBoneTimecodeAttributesAtTime_IsValid = EvaluateRootBoneTimecodeAttributesAtTime_FunctionAddress != IntPtr.Zero && EvaluateRootBoneTimecodeAttributesAtTime_AnimationSequenceBase_IsValid && EvaluateRootBoneTimecodeAttributesAtTime_EvalTime_IsValid && EvaluateRootBoneTimecodeAttributesAtTime_OutQualifiedFrameTime_IsValid && EvaluateRootBoneTimecodeAttributesAtTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:EvaluateRootBoneTimecodeAttributesAtTime", EvaluateRootBoneTimecodeAttributesAtTime_IsValid);
		DoesCurveExist_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DoesCurveExist");
		DoesCurveExist_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesCurveExist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoesCurveExist_AnimationSequence_PropertyAddress, DoesCurveExist_FunctionAddress, "AnimationSequence");
		DoesCurveExist_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(DoesCurveExist_FunctionAddress, "AnimationSequence");
		DoesCurveExist_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesCurveExist_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesCurveExist_CurveName_PropertyAddress, DoesCurveExist_FunctionAddress, "CurveName");
		DoesCurveExist_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(DoesCurveExist_FunctionAddress, "CurveName");
		DoesCurveExist_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesCurveExist_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesCurveExist_CurveType_PropertyAddress, DoesCurveExist_FunctionAddress, "CurveType");
		DoesCurveExist_CurveType_Offset = NativeReflectionCached.GetPropertyOffset(DoesCurveExist_FunctionAddress, "CurveType");
		DoesCurveExist_CurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesCurveExist_FunctionAddress, "CurveType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesCurveExist_ReturnValue_PropertyAddress, DoesCurveExist_FunctionAddress, "ReturnValue");
		DoesCurveExist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DoesCurveExist_FunctionAddress, "ReturnValue");
		DoesCurveExist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesCurveExist_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoesCurveExist_IsValid = DoesCurveExist_FunctionAddress != IntPtr.Zero && DoesCurveExist_AnimationSequence_IsValid && DoesCurveExist_CurveName_IsValid && DoesCurveExist_CurveType_IsValid && DoesCurveExist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:DoesCurveExist", DoesCurveExist_IsValid);
		DoesBoneNameExist_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DoesBoneNameExist");
		DoesBoneNameExist_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesBoneNameExist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoesBoneNameExist_AnimationSequence_PropertyAddress, DoesBoneNameExist_FunctionAddress, "AnimationSequence");
		DoesBoneNameExist_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(DoesBoneNameExist_FunctionAddress, "AnimationSequence");
		DoesBoneNameExist_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesBoneNameExist_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesBoneNameExist_BoneName_PropertyAddress, DoesBoneNameExist_FunctionAddress, "BoneName");
		DoesBoneNameExist_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(DoesBoneNameExist_FunctionAddress, "BoneName");
		DoesBoneNameExist_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesBoneNameExist_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesBoneNameExist_bExists_PropertyAddress, DoesBoneNameExist_FunctionAddress, "bExists");
		DoesBoneNameExist_bExists_Offset = NativeReflectionCached.GetPropertyOffset(DoesBoneNameExist_FunctionAddress, "bExists");
		DoesBoneNameExist_bExists_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesBoneNameExist_FunctionAddress, "bExists", Classes.FBoolProperty);
		DoesBoneNameExist_IsValid = DoesBoneNameExist_FunctionAddress != IntPtr.Zero && DoesBoneNameExist_AnimationSequence_IsValid && DoesBoneNameExist_BoneName_IsValid && DoesBoneNameExist_bExists_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:DoesBoneNameExist", DoesBoneNameExist_IsValid);
		CopyAnimNotifiesFromSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyAnimNotifiesFromSequence");
		CopyAnimNotifiesFromSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyAnimNotifiesFromSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimNotifiesFromSequence_SourceAnimationSequenceBase_PropertyAddress, CopyAnimNotifiesFromSequence_FunctionAddress, "SourceAnimationSequenceBase");
		CopyAnimNotifiesFromSequence_SourceAnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimNotifiesFromSequence_FunctionAddress, "SourceAnimationSequenceBase");
		CopyAnimNotifiesFromSequence_SourceAnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimNotifiesFromSequence_FunctionAddress, "SourceAnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimNotifiesFromSequence_DestinationAnimationSequenceBase_PropertyAddress, CopyAnimNotifiesFromSequence_FunctionAddress, "DestinationAnimationSequenceBase");
		CopyAnimNotifiesFromSequence_DestinationAnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimNotifiesFromSequence_FunctionAddress, "DestinationAnimationSequenceBase");
		CopyAnimNotifiesFromSequence_DestinationAnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimNotifiesFromSequence_FunctionAddress, "DestinationAnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimNotifiesFromSequence_bDeleteExistingNotifies_PropertyAddress, CopyAnimNotifiesFromSequence_FunctionAddress, "bDeleteExistingNotifies");
		CopyAnimNotifiesFromSequence_bDeleteExistingNotifies_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimNotifiesFromSequence_FunctionAddress, "bDeleteExistingNotifies");
		CopyAnimNotifiesFromSequence_bDeleteExistingNotifies_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimNotifiesFromSequence_FunctionAddress, "bDeleteExistingNotifies", Classes.FBoolProperty);
		CopyAnimNotifiesFromSequence_IsValid = CopyAnimNotifiesFromSequence_FunctionAddress != IntPtr.Zero && CopyAnimNotifiesFromSequence_SourceAnimationSequenceBase_IsValid && CopyAnimNotifiesFromSequence_DestinationAnimationSequenceBase_IsValid && CopyAnimNotifiesFromSequence_bDeleteExistingNotifies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:CopyAnimNotifiesFromSequence", CopyAnimNotifiesFromSequence_IsValid);
		CopyAnimationCurveNamesToSkeleton_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyAnimationCurveNamesToSkeleton");
		CopyAnimationCurveNamesToSkeleton_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyAnimationCurveNamesToSkeleton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimationCurveNamesToSkeleton_OldSkeleton_PropertyAddress, CopyAnimationCurveNamesToSkeleton_FunctionAddress, "OldSkeleton");
		CopyAnimationCurveNamesToSkeleton_OldSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimationCurveNamesToSkeleton_FunctionAddress, "OldSkeleton");
		CopyAnimationCurveNamesToSkeleton_OldSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimationCurveNamesToSkeleton_FunctionAddress, "OldSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimationCurveNamesToSkeleton_NewSkeleton_PropertyAddress, CopyAnimationCurveNamesToSkeleton_FunctionAddress, "NewSkeleton");
		CopyAnimationCurveNamesToSkeleton_NewSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimationCurveNamesToSkeleton_FunctionAddress, "NewSkeleton");
		CopyAnimationCurveNamesToSkeleton_NewSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimationCurveNamesToSkeleton_FunctionAddress, "NewSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimationCurveNamesToSkeleton_SequenceBase_PropertyAddress, CopyAnimationCurveNamesToSkeleton_FunctionAddress, "SequenceBase");
		CopyAnimationCurveNamesToSkeleton_SequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimationCurveNamesToSkeleton_FunctionAddress, "SequenceBase");
		CopyAnimationCurveNamesToSkeleton_SequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimationCurveNamesToSkeleton_FunctionAddress, "SequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyAnimationCurveNamesToSkeleton_CurveType_PropertyAddress, CopyAnimationCurveNamesToSkeleton_FunctionAddress, "CurveType");
		CopyAnimationCurveNamesToSkeleton_CurveType_Offset = NativeReflectionCached.GetPropertyOffset(CopyAnimationCurveNamesToSkeleton_FunctionAddress, "CurveType");
		CopyAnimationCurveNamesToSkeleton_CurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyAnimationCurveNamesToSkeleton_FunctionAddress, "CurveType", Classes.FEnumProperty);
		CopyAnimationCurveNamesToSkeleton_IsValid = CopyAnimationCurveNamesToSkeleton_FunctionAddress != IntPtr.Zero && CopyAnimationCurveNamesToSkeleton_OldSkeleton_IsValid && CopyAnimationCurveNamesToSkeleton_NewSkeleton_IsValid && CopyAnimationCurveNamesToSkeleton_SequenceBase_IsValid && CopyAnimationCurveNamesToSkeleton_CurveType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:CopyAnimationCurveNamesToSkeleton", CopyAnimationCurveNamesToSkeleton_IsValid);
		ContainsMetaDataOfClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ContainsMetaDataOfClass");
		ContainsMetaDataOfClass_ParamsSize = NativeReflection.GetFunctionParamsSize(ContainsMetaDataOfClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ContainsMetaDataOfClass_AnimationAsset_PropertyAddress, ContainsMetaDataOfClass_FunctionAddress, "AnimationAsset");
		ContainsMetaDataOfClass_AnimationAsset_Offset = NativeReflectionCached.GetPropertyOffset(ContainsMetaDataOfClass_FunctionAddress, "AnimationAsset");
		ContainsMetaDataOfClass_AnimationAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(ContainsMetaDataOfClass_FunctionAddress, "AnimationAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ContainsMetaDataOfClass_MetaDataClass_PropertyAddress, ContainsMetaDataOfClass_FunctionAddress, "MetaDataClass");
		ContainsMetaDataOfClass_MetaDataClass_Offset = NativeReflectionCached.GetPropertyOffset(ContainsMetaDataOfClass_FunctionAddress, "MetaDataClass");
		ContainsMetaDataOfClass_MetaDataClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ContainsMetaDataOfClass_FunctionAddress, "MetaDataClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ContainsMetaDataOfClass_ReturnValue_PropertyAddress, ContainsMetaDataOfClass_FunctionAddress, "ReturnValue");
		ContainsMetaDataOfClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ContainsMetaDataOfClass_FunctionAddress, "ReturnValue");
		ContainsMetaDataOfClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ContainsMetaDataOfClass_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ContainsMetaDataOfClass_IsValid = ContainsMetaDataOfClass_FunctionAddress != IntPtr.Zero && ContainsMetaDataOfClass_AnimationAsset_IsValid && ContainsMetaDataOfClass_MetaDataClass_IsValid && ContainsMetaDataOfClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:ContainsMetaDataOfClass", ContainsMetaDataOfClass_IsValid);
		AddVirtualBone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddVirtualBone");
		AddVirtualBone_ParamsSize = NativeReflection.GetFunctionParamsSize(AddVirtualBone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddVirtualBone_AnimationSequence_PropertyAddress, AddVirtualBone_FunctionAddress, "AnimationSequence");
		AddVirtualBone_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddVirtualBone_FunctionAddress, "AnimationSequence");
		AddVirtualBone_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVirtualBone_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVirtualBone_SourceBoneName_PropertyAddress, AddVirtualBone_FunctionAddress, "SourceBoneName");
		AddVirtualBone_SourceBoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddVirtualBone_FunctionAddress, "SourceBoneName");
		AddVirtualBone_SourceBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVirtualBone_FunctionAddress, "SourceBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVirtualBone_TargetBoneName_PropertyAddress, AddVirtualBone_FunctionAddress, "TargetBoneName");
		AddVirtualBone_TargetBoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddVirtualBone_FunctionAddress, "TargetBoneName");
		AddVirtualBone_TargetBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVirtualBone_FunctionAddress, "TargetBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVirtualBone_VirtualBoneName_PropertyAddress, AddVirtualBone_FunctionAddress, "VirtualBoneName");
		AddVirtualBone_VirtualBoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddVirtualBone_FunctionAddress, "VirtualBoneName");
		AddVirtualBone_VirtualBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVirtualBone_FunctionAddress, "VirtualBoneName", Classes.FNameProperty);
		AddVirtualBone_IsValid = AddVirtualBone_FunctionAddress != IntPtr.Zero && AddVirtualBone_AnimationSequence_IsValid && AddVirtualBone_SourceBoneName_IsValid && AddVirtualBone_TargetBoneName_IsValid && AddVirtualBone_VirtualBoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddVirtualBone", AddVirtualBone_IsValid);
		AddVectorCurveKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddVectorCurveKeys");
		AddVectorCurveKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(AddVectorCurveKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddVectorCurveKeys_AnimationSequence_PropertyAddress, AddVectorCurveKeys_FunctionAddress, "AnimationSequence");
		AddVectorCurveKeys_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorCurveKeys_FunctionAddress, "AnimationSequence");
		AddVectorCurveKeys_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorCurveKeys_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVectorCurveKeys_CurveName_PropertyAddress, AddVectorCurveKeys_FunctionAddress, "CurveName");
		AddVectorCurveKeys_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorCurveKeys_FunctionAddress, "CurveName");
		AddVectorCurveKeys_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorCurveKeys_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVectorCurveKeys_Times_PropertyAddress, AddVectorCurveKeys_FunctionAddress, "Times");
		AddVectorCurveKeys_Times_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorCurveKeys_FunctionAddress, "Times");
		AddVectorCurveKeys_Times_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorCurveKeys_FunctionAddress, "Times", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVectorCurveKeys_Vectors_PropertyAddress, AddVectorCurveKeys_FunctionAddress, "Vectors");
		AddVectorCurveKeys_Vectors_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorCurveKeys_FunctionAddress, "Vectors");
		AddVectorCurveKeys_Vectors_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorCurveKeys_FunctionAddress, "Vectors", Classes.FArrayProperty);
		AddVectorCurveKeys_IsValid = AddVectorCurveKeys_FunctionAddress != IntPtr.Zero && AddVectorCurveKeys_AnimationSequence_IsValid && AddVectorCurveKeys_CurveName_IsValid && AddVectorCurveKeys_Times_IsValid && AddVectorCurveKeys_Vectors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddVectorCurveKeys", AddVectorCurveKeys_IsValid);
		AddVectorCurveKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddVectorCurveKey");
		AddVectorCurveKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddVectorCurveKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddVectorCurveKey_AnimationSequence_PropertyAddress, AddVectorCurveKey_FunctionAddress, "AnimationSequence");
		AddVectorCurveKey_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorCurveKey_FunctionAddress, "AnimationSequence");
		AddVectorCurveKey_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorCurveKey_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVectorCurveKey_CurveName_PropertyAddress, AddVectorCurveKey_FunctionAddress, "CurveName");
		AddVectorCurveKey_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorCurveKey_FunctionAddress, "CurveName");
		AddVectorCurveKey_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorCurveKey_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVectorCurveKey_Time_PropertyAddress, AddVectorCurveKey_FunctionAddress, "Time");
		AddVectorCurveKey_Time_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorCurveKey_FunctionAddress, "Time");
		AddVectorCurveKey_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorCurveKey_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVectorCurveKey_Vector_PropertyAddress, AddVectorCurveKey_FunctionAddress, "Vector");
		AddVectorCurveKey_Vector_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorCurveKey_FunctionAddress, "Vector");
		AddVectorCurveKey_Vector_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorCurveKey_FunctionAddress, "Vector", Classes.FStructProperty);
		AddVectorCurveKey_IsValid = AddVectorCurveKey_FunctionAddress != IntPtr.Zero && AddVectorCurveKey_AnimationSequence_IsValid && AddVectorCurveKey_CurveName_IsValid && AddVectorCurveKey_Time_IsValid && AddVectorCurveKey_Vector_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddVectorCurveKey", AddVectorCurveKey_IsValid);
		AddTransformationCurveKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddTransformationCurveKeys");
		AddTransformationCurveKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTransformationCurveKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTransformationCurveKeys_AnimationSequence_PropertyAddress, AddTransformationCurveKeys_FunctionAddress, "AnimationSequence");
		AddTransformationCurveKeys_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformationCurveKeys_FunctionAddress, "AnimationSequence");
		AddTransformationCurveKeys_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformationCurveKeys_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTransformationCurveKeys_CurveName_PropertyAddress, AddTransformationCurveKeys_FunctionAddress, "CurveName");
		AddTransformationCurveKeys_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformationCurveKeys_FunctionAddress, "CurveName");
		AddTransformationCurveKeys_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformationCurveKeys_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTransformationCurveKeys_Times_PropertyAddress, AddTransformationCurveKeys_FunctionAddress, "Times");
		AddTransformationCurveKeys_Times_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformationCurveKeys_FunctionAddress, "Times");
		AddTransformationCurveKeys_Times_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformationCurveKeys_FunctionAddress, "Times", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTransformationCurveKeys_Transforms_PropertyAddress, AddTransformationCurveKeys_FunctionAddress, "Transforms");
		AddTransformationCurveKeys_Transforms_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformationCurveKeys_FunctionAddress, "Transforms");
		AddTransformationCurveKeys_Transforms_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformationCurveKeys_FunctionAddress, "Transforms", Classes.FArrayProperty);
		AddTransformationCurveKeys_IsValid = AddTransformationCurveKeys_FunctionAddress != IntPtr.Zero && AddTransformationCurveKeys_AnimationSequence_IsValid && AddTransformationCurveKeys_CurveName_IsValid && AddTransformationCurveKeys_Times_IsValid && AddTransformationCurveKeys_Transforms_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddTransformationCurveKeys", AddTransformationCurveKeys_IsValid);
		AddTransformationCurveKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddTransformationCurveKey");
		AddTransformationCurveKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTransformationCurveKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTransformationCurveKey_AnimationSequence_PropertyAddress, AddTransformationCurveKey_FunctionAddress, "AnimationSequence");
		AddTransformationCurveKey_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformationCurveKey_FunctionAddress, "AnimationSequence");
		AddTransformationCurveKey_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformationCurveKey_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTransformationCurveKey_CurveName_PropertyAddress, AddTransformationCurveKey_FunctionAddress, "CurveName");
		AddTransformationCurveKey_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformationCurveKey_FunctionAddress, "CurveName");
		AddTransformationCurveKey_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformationCurveKey_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTransformationCurveKey_Time_PropertyAddress, AddTransformationCurveKey_FunctionAddress, "Time");
		AddTransformationCurveKey_Time_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformationCurveKey_FunctionAddress, "Time");
		AddTransformationCurveKey_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformationCurveKey_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTransformationCurveKey_Transform_PropertyAddress, AddTransformationCurveKey_FunctionAddress, "Transform");
		AddTransformationCurveKey_Transform_Offset = NativeReflectionCached.GetPropertyOffset(AddTransformationCurveKey_FunctionAddress, "Transform");
		AddTransformationCurveKey_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTransformationCurveKey_FunctionAddress, "Transform", Classes.FStructProperty);
		AddTransformationCurveKey_IsValid = AddTransformationCurveKey_FunctionAddress != IntPtr.Zero && AddTransformationCurveKey_AnimationSequence_IsValid && AddTransformationCurveKey_CurveName_IsValid && AddTransformationCurveKey_Time_IsValid && AddTransformationCurveKey_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddTransformationCurveKey", AddTransformationCurveKey_IsValid);
		AddMetaDataObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMetaDataObject");
		AddMetaDataObject_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMetaDataObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMetaDataObject_AnimationAsset_PropertyAddress, AddMetaDataObject_FunctionAddress, "AnimationAsset");
		AddMetaDataObject_AnimationAsset_Offset = NativeReflectionCached.GetPropertyOffset(AddMetaDataObject_FunctionAddress, "AnimationAsset");
		AddMetaDataObject_AnimationAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMetaDataObject_FunctionAddress, "AnimationAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMetaDataObject_MetaDataObject_PropertyAddress, AddMetaDataObject_FunctionAddress, "MetaDataObject");
		AddMetaDataObject_MetaDataObject_Offset = NativeReflectionCached.GetPropertyOffset(AddMetaDataObject_FunctionAddress, "MetaDataObject");
		AddMetaDataObject_MetaDataObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMetaDataObject_FunctionAddress, "MetaDataObject", Classes.FObjectProperty);
		AddMetaDataObject_IsValid = AddMetaDataObject_FunctionAddress != IntPtr.Zero && AddMetaDataObject_AnimationAsset_IsValid && AddMetaDataObject_MetaDataObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddMetaDataObject", AddMetaDataObject_IsValid);
		AddMetaData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMetaData");
		AddMetaData_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMetaData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMetaData_AnimationAsset_PropertyAddress, AddMetaData_FunctionAddress, "AnimationAsset");
		AddMetaData_AnimationAsset_Offset = NativeReflectionCached.GetPropertyOffset(AddMetaData_FunctionAddress, "AnimationAsset");
		AddMetaData_AnimationAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMetaData_FunctionAddress, "AnimationAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMetaData_MetaDataClass_PropertyAddress, AddMetaData_FunctionAddress, "MetaDataClass");
		AddMetaData_MetaDataClass_Offset = NativeReflectionCached.GetPropertyOffset(AddMetaData_FunctionAddress, "MetaDataClass");
		AddMetaData_MetaDataClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMetaData_FunctionAddress, "MetaDataClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMetaData_MetaDataInstance_PropertyAddress, AddMetaData_FunctionAddress, "MetaDataInstance");
		AddMetaData_MetaDataInstance_Offset = NativeReflectionCached.GetPropertyOffset(AddMetaData_FunctionAddress, "MetaDataInstance");
		AddMetaData_MetaDataInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMetaData_FunctionAddress, "MetaDataInstance", Classes.FObjectProperty);
		AddMetaData_IsValid = AddMetaData_FunctionAddress != IntPtr.Zero && AddMetaData_AnimationAsset_IsValid && AddMetaData_MetaDataClass_IsValid && AddMetaData_MetaDataInstance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddMetaData", AddMetaData_IsValid);
		AddFloatCurveKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddFloatCurveKeys");
		AddFloatCurveKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFloatCurveKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFloatCurveKeys_AnimationSequence_PropertyAddress, AddFloatCurveKeys_FunctionAddress, "AnimationSequence");
		AddFloatCurveKeys_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatCurveKeys_FunctionAddress, "AnimationSequence");
		AddFloatCurveKeys_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatCurveKeys_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFloatCurveKeys_CurveName_PropertyAddress, AddFloatCurveKeys_FunctionAddress, "CurveName");
		AddFloatCurveKeys_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatCurveKeys_FunctionAddress, "CurveName");
		AddFloatCurveKeys_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatCurveKeys_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFloatCurveKeys_Times_PropertyAddress, AddFloatCurveKeys_FunctionAddress, "Times");
		AddFloatCurveKeys_Times_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatCurveKeys_FunctionAddress, "Times");
		AddFloatCurveKeys_Times_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatCurveKeys_FunctionAddress, "Times", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFloatCurveKeys_Values_PropertyAddress, AddFloatCurveKeys_FunctionAddress, "Values");
		AddFloatCurveKeys_Values_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatCurveKeys_FunctionAddress, "Values");
		AddFloatCurveKeys_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatCurveKeys_FunctionAddress, "Values", Classes.FArrayProperty);
		AddFloatCurveKeys_IsValid = AddFloatCurveKeys_FunctionAddress != IntPtr.Zero && AddFloatCurveKeys_AnimationSequence_IsValid && AddFloatCurveKeys_CurveName_IsValid && AddFloatCurveKeys_Times_IsValid && AddFloatCurveKeys_Values_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddFloatCurveKeys", AddFloatCurveKeys_IsValid);
		AddFloatCurveKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddFloatCurveKey");
		AddFloatCurveKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFloatCurveKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFloatCurveKey_AnimationSequence_PropertyAddress, AddFloatCurveKey_FunctionAddress, "AnimationSequence");
		AddFloatCurveKey_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatCurveKey_FunctionAddress, "AnimationSequence");
		AddFloatCurveKey_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatCurveKey_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFloatCurveKey_CurveName_PropertyAddress, AddFloatCurveKey_FunctionAddress, "CurveName");
		AddFloatCurveKey_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatCurveKey_FunctionAddress, "CurveName");
		AddFloatCurveKey_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatCurveKey_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFloatCurveKey_Time_PropertyAddress, AddFloatCurveKey_FunctionAddress, "Time");
		AddFloatCurveKey_Time_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatCurveKey_FunctionAddress, "Time");
		AddFloatCurveKey_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatCurveKey_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFloatCurveKey_Value_PropertyAddress, AddFloatCurveKey_FunctionAddress, "Value");
		AddFloatCurveKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatCurveKey_FunctionAddress, "Value");
		AddFloatCurveKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatCurveKey_FunctionAddress, "Value", Classes.FFloatProperty);
		AddFloatCurveKey_IsValid = AddFloatCurveKey_FunctionAddress != IntPtr.Zero && AddFloatCurveKey_AnimationSequence_IsValid && AddFloatCurveKey_CurveName_IsValid && AddFloatCurveKey_Time_IsValid && AddFloatCurveKey_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddFloatCurveKey", AddFloatCurveKey_IsValid);
		AddCurve_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddCurve");
		AddCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(AddCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_AnimationSequence_PropertyAddress, AddCurve_FunctionAddress, "AnimationSequence");
		AddCurve_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "AnimationSequence");
		AddCurve_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_CurveName_PropertyAddress, AddCurve_FunctionAddress, "CurveName");
		AddCurve_CurveName_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "CurveName");
		AddCurve_CurveName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "CurveName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_CurveType_PropertyAddress, AddCurve_FunctionAddress, "CurveType");
		AddCurve_CurveType_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "CurveType");
		AddCurve_CurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "CurveType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_bMetaDataCurve_PropertyAddress, AddCurve_FunctionAddress, "bMetaDataCurve");
		AddCurve_bMetaDataCurve_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "bMetaDataCurve");
		AddCurve_bMetaDataCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "bMetaDataCurve", Classes.FBoolProperty);
		AddCurve_IsValid = AddCurve_FunctionAddress != IntPtr.Zero && AddCurve_AnimationSequence_IsValid && AddCurve_CurveName_IsValid && AddCurve_CurveType_IsValid && AddCurve_bMetaDataCurve_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddCurve", AddCurve_IsValid);
		AddAnimationSyncMarker_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAnimationSyncMarker");
		AddAnimationSyncMarker_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAnimationSyncMarker_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationSyncMarker_AnimationSequence_PropertyAddress, AddAnimationSyncMarker_FunctionAddress, "AnimationSequence");
		AddAnimationSyncMarker_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationSyncMarker_FunctionAddress, "AnimationSequence");
		AddAnimationSyncMarker_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationSyncMarker_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationSyncMarker_MarkerName_PropertyAddress, AddAnimationSyncMarker_FunctionAddress, "MarkerName");
		AddAnimationSyncMarker_MarkerName_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationSyncMarker_FunctionAddress, "MarkerName");
		AddAnimationSyncMarker_MarkerName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationSyncMarker_FunctionAddress, "MarkerName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationSyncMarker_Time_PropertyAddress, AddAnimationSyncMarker_FunctionAddress, "Time");
		AddAnimationSyncMarker_Time_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationSyncMarker_FunctionAddress, "Time");
		AddAnimationSyncMarker_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationSyncMarker_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationSyncMarker_NotifyTrackName_PropertyAddress, AddAnimationSyncMarker_FunctionAddress, "NotifyTrackName");
		AddAnimationSyncMarker_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationSyncMarker_FunctionAddress, "NotifyTrackName");
		AddAnimationSyncMarker_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationSyncMarker_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		AddAnimationSyncMarker_IsValid = AddAnimationSyncMarker_FunctionAddress != IntPtr.Zero && AddAnimationSyncMarker_AnimationSequence_IsValid && AddAnimationSyncMarker_MarkerName_IsValid && AddAnimationSyncMarker_Time_IsValid && AddAnimationSyncMarker_NotifyTrackName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationSyncMarker", AddAnimationSyncMarker_IsValid);
		AddAnimationNotifyTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAnimationNotifyTrack");
		AddAnimationNotifyTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAnimationNotifyTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyTrack_AnimationSequenceBase_PropertyAddress, AddAnimationNotifyTrack_FunctionAddress, "AnimationSequenceBase");
		AddAnimationNotifyTrack_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyTrack_FunctionAddress, "AnimationSequenceBase");
		AddAnimationNotifyTrack_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyTrack_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyTrack_NotifyTrackName_PropertyAddress, AddAnimationNotifyTrack_FunctionAddress, "NotifyTrackName");
		AddAnimationNotifyTrack_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyTrack_FunctionAddress, "NotifyTrackName");
		AddAnimationNotifyTrack_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyTrack_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyTrack_TrackColor_PropertyAddress, AddAnimationNotifyTrack_FunctionAddress, "TrackColor");
		AddAnimationNotifyTrack_TrackColor_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyTrack_FunctionAddress, "TrackColor");
		AddAnimationNotifyTrack_TrackColor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyTrack_FunctionAddress, "TrackColor", Classes.FStructProperty);
		AddAnimationNotifyTrack_IsValid = AddAnimationNotifyTrack_FunctionAddress != IntPtr.Zero && AddAnimationNotifyTrack_AnimationSequenceBase_IsValid && AddAnimationNotifyTrack_NotifyTrackName_IsValid && AddAnimationNotifyTrack_TrackColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyTrack", AddAnimationNotifyTrack_IsValid);
		AddAnimationNotifyStateEventObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAnimationNotifyStateEventObject");
		AddAnimationNotifyStateEventObject_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAnimationNotifyStateEventObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyStateEventObject_AnimationSequenceBase_PropertyAddress, AddAnimationNotifyStateEventObject_FunctionAddress, "AnimationSequenceBase");
		AddAnimationNotifyStateEventObject_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyStateEventObject_FunctionAddress, "AnimationSequenceBase");
		AddAnimationNotifyStateEventObject_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyStateEventObject_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyStateEventObject_StartTime_PropertyAddress, AddAnimationNotifyStateEventObject_FunctionAddress, "StartTime");
		AddAnimationNotifyStateEventObject_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyStateEventObject_FunctionAddress, "StartTime");
		AddAnimationNotifyStateEventObject_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyStateEventObject_FunctionAddress, "StartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyStateEventObject_Duration_PropertyAddress, AddAnimationNotifyStateEventObject_FunctionAddress, "Duration");
		AddAnimationNotifyStateEventObject_Duration_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyStateEventObject_FunctionAddress, "Duration");
		AddAnimationNotifyStateEventObject_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyStateEventObject_FunctionAddress, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyStateEventObject_NotifyState_PropertyAddress, AddAnimationNotifyStateEventObject_FunctionAddress, "NotifyState");
		AddAnimationNotifyStateEventObject_NotifyState_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyStateEventObject_FunctionAddress, "NotifyState");
		AddAnimationNotifyStateEventObject_NotifyState_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyStateEventObject_FunctionAddress, "NotifyState", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyStateEventObject_NotifyTrackName_PropertyAddress, AddAnimationNotifyStateEventObject_FunctionAddress, "NotifyTrackName");
		AddAnimationNotifyStateEventObject_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyStateEventObject_FunctionAddress, "NotifyTrackName");
		AddAnimationNotifyStateEventObject_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyStateEventObject_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		AddAnimationNotifyStateEventObject_IsValid = AddAnimationNotifyStateEventObject_FunctionAddress != IntPtr.Zero && AddAnimationNotifyStateEventObject_AnimationSequenceBase_IsValid && AddAnimationNotifyStateEventObject_StartTime_IsValid && AddAnimationNotifyStateEventObject_Duration_IsValid && AddAnimationNotifyStateEventObject_NotifyState_IsValid && AddAnimationNotifyStateEventObject_NotifyTrackName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyStateEventObject", AddAnimationNotifyStateEventObject_IsValid);
		AddAnimationNotifyStateEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAnimationNotifyStateEvent");
		AddAnimationNotifyStateEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAnimationNotifyStateEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyStateEvent_AnimationSequenceBase_PropertyAddress, AddAnimationNotifyStateEvent_FunctionAddress, "AnimationSequenceBase");
		AddAnimationNotifyStateEvent_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyStateEvent_FunctionAddress, "AnimationSequenceBase");
		AddAnimationNotifyStateEvent_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyStateEvent_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
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
		AddAnimationNotifyStateEvent_IsValid = AddAnimationNotifyStateEvent_FunctionAddress != IntPtr.Zero && AddAnimationNotifyStateEvent_AnimationSequenceBase_IsValid && AddAnimationNotifyStateEvent_NotifyTrackName_IsValid && AddAnimationNotifyStateEvent_StartTime_IsValid && AddAnimationNotifyStateEvent_Duration_IsValid && AddAnimationNotifyStateEvent_NotifyStateClass_IsValid && AddAnimationNotifyStateEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyStateEvent", AddAnimationNotifyStateEvent_IsValid);
		AddAnimationNotifyEventObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAnimationNotifyEventObject");
		AddAnimationNotifyEventObject_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAnimationNotifyEventObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyEventObject_AnimationSequenceBase_PropertyAddress, AddAnimationNotifyEventObject_FunctionAddress, "AnimationSequenceBase");
		AddAnimationNotifyEventObject_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyEventObject_FunctionAddress, "AnimationSequenceBase");
		AddAnimationNotifyEventObject_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyEventObject_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyEventObject_StartTime_PropertyAddress, AddAnimationNotifyEventObject_FunctionAddress, "StartTime");
		AddAnimationNotifyEventObject_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyEventObject_FunctionAddress, "StartTime");
		AddAnimationNotifyEventObject_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyEventObject_FunctionAddress, "StartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyEventObject_Notify_PropertyAddress, AddAnimationNotifyEventObject_FunctionAddress, "Notify");
		AddAnimationNotifyEventObject_Notify_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyEventObject_FunctionAddress, "Notify");
		AddAnimationNotifyEventObject_Notify_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyEventObject_FunctionAddress, "Notify", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAnimationNotifyEventObject_NotifyTrackName_PropertyAddress, AddAnimationNotifyEventObject_FunctionAddress, "NotifyTrackName");
		AddAnimationNotifyEventObject_NotifyTrackName_Offset = NativeReflectionCached.GetPropertyOffset(AddAnimationNotifyEventObject_FunctionAddress, "NotifyTrackName");
		AddAnimationNotifyEventObject_NotifyTrackName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAnimationNotifyEventObject_FunctionAddress, "NotifyTrackName", Classes.FNameProperty);
		AddAnimationNotifyEventObject_IsValid = AddAnimationNotifyEventObject_FunctionAddress != IntPtr.Zero && AddAnimationNotifyEventObject_AnimationSequenceBase_IsValid && AddAnimationNotifyEventObject_StartTime_IsValid && AddAnimationNotifyEventObject_Notify_IsValid && AddAnimationNotifyEventObject_NotifyTrackName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyEventObject", AddAnimationNotifyEventObject_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary:AddAnimationNotifyEvent", AddAnimationNotifyEvent_IsValid);
	}
}
