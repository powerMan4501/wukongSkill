using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationDataController;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AnimationDataController.AnimDataController", "AnimationDataController", UnrealModuleType.Engine)]
public class UAnimDataController : UObject, IAnimationDataController, IInterface
{
	private static bool UpdateCurveNamesFromSkeleton_IsValid;

	private IntPtr UpdateCurveNamesFromSkeleton_InstanceFunctionAddress;

	private static IntPtr UpdateCurveNamesFromSkeleton_FunctionAddress;

	private static int UpdateCurveNamesFromSkeleton_ParamsSize;

	private static bool UpdateCurveNamesFromSkeleton_Skeleton_IsValid;

	private static FFieldAddress UpdateCurveNamesFromSkeleton_Skeleton_PropertyAddress;

	private static int UpdateCurveNamesFromSkeleton_Skeleton_Offset;

	private static bool UpdateCurveNamesFromSkeleton_SupportedCurveType_IsValid;

	private static FFieldAddress UpdateCurveNamesFromSkeleton_SupportedCurveType_PropertyAddress;

	private static int UpdateCurveNamesFromSkeleton_SupportedCurveType_Offset;

	private static bool UpdateCurveNamesFromSkeleton_bShouldTransact_IsValid;

	private static FFieldAddress UpdateCurveNamesFromSkeleton_bShouldTransact_PropertyAddress;

	private static int UpdateCurveNamesFromSkeleton_bShouldTransact_Offset;

	private static bool SetTransformCurveKeys_IsValid;

	private IntPtr SetTransformCurveKeys_InstanceFunctionAddress;

	private static IntPtr SetTransformCurveKeys_FunctionAddress;

	private static int SetTransformCurveKeys_ParamsSize;

	private static bool SetTransformCurveKeys_CurveId_IsValid;

	private static FFieldAddress SetTransformCurveKeys_CurveId_PropertyAddress;

	private static int SetTransformCurveKeys_CurveId_Offset;

	private static bool SetTransformCurveKeys_TransformValues_IsValid;

	private static FFieldAddress SetTransformCurveKeys_TransformValues_PropertyAddress;

	private static int SetTransformCurveKeys_TransformValues_Offset;

	private static bool SetTransformCurveKeys_TimeKeys_IsValid;

	private static FFieldAddress SetTransformCurveKeys_TimeKeys_PropertyAddress;

	private static int SetTransformCurveKeys_TimeKeys_Offset;

	private static bool SetTransformCurveKeys_bShouldTransact_IsValid;

	private static FFieldAddress SetTransformCurveKeys_bShouldTransact_PropertyAddress;

	private static int SetTransformCurveKeys_bShouldTransact_Offset;

	private static bool SetTransformCurveKeys_ReturnValue_IsValid;

	private static FFieldAddress SetTransformCurveKeys_ReturnValue_PropertyAddress;

	private static int SetTransformCurveKeys_ReturnValue_Offset;

	private static bool SetTransformCurveKey_IsValid;

	private IntPtr SetTransformCurveKey_InstanceFunctionAddress;

	private static IntPtr SetTransformCurveKey_FunctionAddress;

	private static int SetTransformCurveKey_ParamsSize;

	private static bool SetTransformCurveKey_CurveId_IsValid;

	private static FFieldAddress SetTransformCurveKey_CurveId_PropertyAddress;

	private static int SetTransformCurveKey_CurveId_Offset;

	private static bool SetTransformCurveKey_Time_IsValid;

	private static FFieldAddress SetTransformCurveKey_Time_PropertyAddress;

	private static int SetTransformCurveKey_Time_Offset;

	private static bool SetTransformCurveKey_Value_IsValid;

	private static FFieldAddress SetTransformCurveKey_Value_PropertyAddress;

	private static int SetTransformCurveKey_Value_Offset;

	private static bool SetTransformCurveKey_bShouldTransact_IsValid;

	private static FFieldAddress SetTransformCurveKey_bShouldTransact_PropertyAddress;

	private static int SetTransformCurveKey_bShouldTransact_Offset;

	private static bool SetTransformCurveKey_ReturnValue_IsValid;

	private static FFieldAddress SetTransformCurveKey_ReturnValue_PropertyAddress;

	private static int SetTransformCurveKey_ReturnValue_Offset;

	private static bool SetPlayLength_IsValid;

	private IntPtr SetPlayLength_InstanceFunctionAddress;

	private static IntPtr SetPlayLength_FunctionAddress;

	private static int SetPlayLength_ParamsSize;

	private static bool SetPlayLength_Length_IsValid;

	private static FFieldAddress SetPlayLength_Length_PropertyAddress;

	private static int SetPlayLength_Length_Offset;

	private static bool SetPlayLength_bShouldTransact_IsValid;

	private static FFieldAddress SetPlayLength_bShouldTransact_PropertyAddress;

	private static int SetPlayLength_bShouldTransact_Offset;

	private static bool SetModel_IsValid;

	private IntPtr SetModel_InstanceFunctionAddress;

	private static IntPtr SetModel_FunctionAddress;

	private static int SetModel_ParamsSize;

	private static bool SetModel_InModel_IsValid;

	private static FFieldAddress SetModel_InModel_PropertyAddress;

	private static int SetModel_InModel_Offset;

	private static bool SetFrameRate_IsValid;

	private IntPtr SetFrameRate_InstanceFunctionAddress;

	private static IntPtr SetFrameRate_FunctionAddress;

	private static int SetFrameRate_ParamsSize;

	private static bool SetFrameRate_FrameRate_IsValid;

	private static FFieldAddress SetFrameRate_FrameRate_PropertyAddress;

	private static int SetFrameRate_FrameRate_Offset;

	private static bool SetFrameRate_bShouldTransact_IsValid;

	private static FFieldAddress SetFrameRate_bShouldTransact_PropertyAddress;

	private static int SetFrameRate_bShouldTransact_Offset;

	private static bool SetCurveKeys_IsValid;

	private IntPtr SetCurveKeys_InstanceFunctionAddress;

	private static IntPtr SetCurveKeys_FunctionAddress;

	private static int SetCurveKeys_ParamsSize;

	private static bool SetCurveKeys_CurveId_IsValid;

	private static FFieldAddress SetCurveKeys_CurveId_PropertyAddress;

	private static int SetCurveKeys_CurveId_Offset;

	private static bool SetCurveKeys_CurveKeys_IsValid;

	private static FFieldAddress SetCurveKeys_CurveKeys_PropertyAddress;

	private static int SetCurveKeys_CurveKeys_Offset;

	private static bool SetCurveKeys_bShouldTransact_IsValid;

	private static FFieldAddress SetCurveKeys_bShouldTransact_PropertyAddress;

	private static int SetCurveKeys_bShouldTransact_Offset;

	private static bool SetCurveKeys_ReturnValue_IsValid;

	private static FFieldAddress SetCurveKeys_ReturnValue_PropertyAddress;

	private static int SetCurveKeys_ReturnValue_Offset;

	private static bool SetCurveKey_IsValid;

	private IntPtr SetCurveKey_InstanceFunctionAddress;

	private static IntPtr SetCurveKey_FunctionAddress;

	private static int SetCurveKey_ParamsSize;

	private static bool SetCurveKey_CurveId_IsValid;

	private static FFieldAddress SetCurveKey_CurveId_PropertyAddress;

	private static int SetCurveKey_CurveId_Offset;

	private static bool SetCurveKey_Key_IsValid;

	private static FFieldAddress SetCurveKey_Key_PropertyAddress;

	private static int SetCurveKey_Key_Offset;

	private static bool SetCurveKey_bShouldTransact_IsValid;

	private static FFieldAddress SetCurveKey_bShouldTransact_PropertyAddress;

	private static int SetCurveKey_bShouldTransact_Offset;

	private static bool SetCurveKey_ReturnValue_IsValid;

	private static FFieldAddress SetCurveKey_ReturnValue_PropertyAddress;

	private static int SetCurveKey_ReturnValue_Offset;

	private static bool SetCurveFlags_IsValid;

	private IntPtr SetCurveFlags_InstanceFunctionAddress;

	private static IntPtr SetCurveFlags_FunctionAddress;

	private static int SetCurveFlags_ParamsSize;

	private static bool SetCurveFlags_CurveId_IsValid;

	private static FFieldAddress SetCurveFlags_CurveId_PropertyAddress;

	private static int SetCurveFlags_CurveId_Offset;

	private static bool SetCurveFlags_Flags_IsValid;

	private static FFieldAddress SetCurveFlags_Flags_PropertyAddress;

	private static int SetCurveFlags_Flags_Offset;

	private static bool SetCurveFlags_bShouldTransact_IsValid;

	private static FFieldAddress SetCurveFlags_bShouldTransact_PropertyAddress;

	private static int SetCurveFlags_bShouldTransact_Offset;

	private static bool SetCurveFlags_ReturnValue_IsValid;

	private static FFieldAddress SetCurveFlags_ReturnValue_PropertyAddress;

	private static int SetCurveFlags_ReturnValue_Offset;

	private static bool SetCurveFlag_IsValid;

	private IntPtr SetCurveFlag_InstanceFunctionAddress;

	private static IntPtr SetCurveFlag_FunctionAddress;

	private static int SetCurveFlag_ParamsSize;

	private static bool SetCurveFlag_CurveId_IsValid;

	private static FFieldAddress SetCurveFlag_CurveId_PropertyAddress;

	private static int SetCurveFlag_CurveId_Offset;

	private static bool SetCurveFlag_Flag_IsValid;

	private static FFieldAddress SetCurveFlag_Flag_PropertyAddress;

	private static int SetCurveFlag_Flag_Offset;

	private static bool SetCurveFlag_bState_IsValid;

	private static FFieldAddress SetCurveFlag_bState_PropertyAddress;

	private static int SetCurveFlag_bState_Offset;

	private static bool SetCurveFlag_bShouldTransact_IsValid;

	private static FFieldAddress SetCurveFlag_bShouldTransact_PropertyAddress;

	private static int SetCurveFlag_bShouldTransact_Offset;

	private static bool SetCurveFlag_ReturnValue_IsValid;

	private static FFieldAddress SetCurveFlag_ReturnValue_PropertyAddress;

	private static int SetCurveFlag_ReturnValue_Offset;

	private static bool SetCurveColor_IsValid;

	private IntPtr SetCurveColor_InstanceFunctionAddress;

	private static IntPtr SetCurveColor_FunctionAddress;

	private static int SetCurveColor_ParamsSize;

	private static bool SetCurveColor_CurveId_IsValid;

	private static FFieldAddress SetCurveColor_CurveId_PropertyAddress;

	private static int SetCurveColor_CurveId_Offset;

	private static bool SetCurveColor_Color_IsValid;

	private static FFieldAddress SetCurveColor_Color_PropertyAddress;

	private static int SetCurveColor_Color_Offset;

	private static bool SetCurveColor_bShouldTransact_IsValid;

	private static FFieldAddress SetCurveColor_bShouldTransact_PropertyAddress;

	private static int SetCurveColor_bShouldTransact_Offset;

	private static bool SetCurveColor_ReturnValue_IsValid;

	private static FFieldAddress SetCurveColor_ReturnValue_PropertyAddress;

	private static int SetCurveColor_ReturnValue_Offset;

	private static bool SetBoneTrackKeys_IsValid;

	private IntPtr SetBoneTrackKeys_InstanceFunctionAddress;

	private static IntPtr SetBoneTrackKeys_FunctionAddress;

	private static int SetBoneTrackKeys_ParamsSize;

	private static bool SetBoneTrackKeys_BoneName_IsValid;

	private static FFieldAddress SetBoneTrackKeys_BoneName_PropertyAddress;

	private static int SetBoneTrackKeys_BoneName_Offset;

	private static bool SetBoneTrackKeys_PositionalKeys_IsValid;

	private static FFieldAddress SetBoneTrackKeys_PositionalKeys_PropertyAddress;

	private static int SetBoneTrackKeys_PositionalKeys_Offset;

	private static bool SetBoneTrackKeys_RotationalKeys_IsValid;

	private static FFieldAddress SetBoneTrackKeys_RotationalKeys_PropertyAddress;

	private static int SetBoneTrackKeys_RotationalKeys_Offset;

	private static bool SetBoneTrackKeys_ScalingKeys_IsValid;

	private static FFieldAddress SetBoneTrackKeys_ScalingKeys_PropertyAddress;

	private static int SetBoneTrackKeys_ScalingKeys_Offset;

	private static bool SetBoneTrackKeys_bShouldTransact_IsValid;

	private static FFieldAddress SetBoneTrackKeys_bShouldTransact_PropertyAddress;

	private static int SetBoneTrackKeys_bShouldTransact_Offset;

	private static bool SetBoneTrackKeys_ReturnValue_IsValid;

	private static FFieldAddress SetBoneTrackKeys_ReturnValue_PropertyAddress;

	private static int SetBoneTrackKeys_ReturnValue_Offset;

	private static bool ScaleCurve_IsValid;

	private IntPtr ScaleCurve_InstanceFunctionAddress;

	private static IntPtr ScaleCurve_FunctionAddress;

	private static int ScaleCurve_ParamsSize;

	private static bool ScaleCurve_CurveId_IsValid;

	private static FFieldAddress ScaleCurve_CurveId_PropertyAddress;

	private static int ScaleCurve_CurveId_Offset;

	private static bool ScaleCurve_Origin_IsValid;

	private static FFieldAddress ScaleCurve_Origin_PropertyAddress;

	private static int ScaleCurve_Origin_Offset;

	private static bool ScaleCurve_Factor_IsValid;

	private static FFieldAddress ScaleCurve_Factor_PropertyAddress;

	private static int ScaleCurve_Factor_Offset;

	private static bool ScaleCurve_bShouldTransact_IsValid;

	private static FFieldAddress ScaleCurve_bShouldTransact_PropertyAddress;

	private static int ScaleCurve_bShouldTransact_Offset;

	private static bool ScaleCurve_ReturnValue_IsValid;

	private static FFieldAddress ScaleCurve_ReturnValue_PropertyAddress;

	private static int ScaleCurve_ReturnValue_Offset;

	private static bool ResizePlayLength_IsValid;

	private IntPtr ResizePlayLength_InstanceFunctionAddress;

	private static IntPtr ResizePlayLength_FunctionAddress;

	private static int ResizePlayLength_ParamsSize;

	private static bool ResizePlayLength_NewLength_IsValid;

	private static FFieldAddress ResizePlayLength_NewLength_PropertyAddress;

	private static int ResizePlayLength_NewLength_Offset;

	private static bool ResizePlayLength_T0_IsValid;

	private static FFieldAddress ResizePlayLength_T0_PropertyAddress;

	private static int ResizePlayLength_T0_Offset;

	private static bool ResizePlayLength_T1_IsValid;

	private static FFieldAddress ResizePlayLength_T1_PropertyAddress;

	private static int ResizePlayLength_T1_Offset;

	private static bool ResizePlayLength_bShouldTransact_IsValid;

	private static FFieldAddress ResizePlayLength_bShouldTransact_PropertyAddress;

	private static int ResizePlayLength_bShouldTransact_Offset;

	private static bool Resize_IsValid;

	private IntPtr Resize_InstanceFunctionAddress;

	private static IntPtr Resize_FunctionAddress;

	private static int Resize_ParamsSize;

	private static bool Resize_Length_IsValid;

	private static FFieldAddress Resize_Length_PropertyAddress;

	private static int Resize_Length_Offset;

	private static bool Resize_T0_IsValid;

	private static FFieldAddress Resize_T0_PropertyAddress;

	private static int Resize_T0_Offset;

	private static bool Resize_T1_IsValid;

	private static FFieldAddress Resize_T1_PropertyAddress;

	private static int Resize_T1_Offset;

	private static bool Resize_bShouldTransact_IsValid;

	private static FFieldAddress Resize_bShouldTransact_PropertyAddress;

	private static int Resize_bShouldTransact_Offset;

	private static bool RenameCurve_IsValid;

	private IntPtr RenameCurve_InstanceFunctionAddress;

	private static IntPtr RenameCurve_FunctionAddress;

	private static int RenameCurve_ParamsSize;

	private static bool RenameCurve_CurveToRenameId_IsValid;

	private static FFieldAddress RenameCurve_CurveToRenameId_PropertyAddress;

	private static int RenameCurve_CurveToRenameId_Offset;

	private static bool RenameCurve_NewCurveId_IsValid;

	private static FFieldAddress RenameCurve_NewCurveId_PropertyAddress;

	private static int RenameCurve_NewCurveId_Offset;

	private static bool RenameCurve_bShouldTransact_IsValid;

	private static FFieldAddress RenameCurve_bShouldTransact_PropertyAddress;

	private static int RenameCurve_bShouldTransact_Offset;

	private static bool RenameCurve_ReturnValue_IsValid;

	private static FFieldAddress RenameCurve_ReturnValue_PropertyAddress;

	private static int RenameCurve_ReturnValue_Offset;

	private static bool RemoveTransformCurveKey_IsValid;

	private IntPtr RemoveTransformCurveKey_InstanceFunctionAddress;

	private static IntPtr RemoveTransformCurveKey_FunctionAddress;

	private static int RemoveTransformCurveKey_ParamsSize;

	private static bool RemoveTransformCurveKey_CurveId_IsValid;

	private static FFieldAddress RemoveTransformCurveKey_CurveId_PropertyAddress;

	private static int RemoveTransformCurveKey_CurveId_Offset;

	private static bool RemoveTransformCurveKey_Time_IsValid;

	private static FFieldAddress RemoveTransformCurveKey_Time_PropertyAddress;

	private static int RemoveTransformCurveKey_Time_Offset;

	private static bool RemoveTransformCurveKey_bShouldTransact_IsValid;

	private static FFieldAddress RemoveTransformCurveKey_bShouldTransact_PropertyAddress;

	private static int RemoveTransformCurveKey_bShouldTransact_Offset;

	private static bool RemoveTransformCurveKey_ReturnValue_IsValid;

	private static FFieldAddress RemoveTransformCurveKey_ReturnValue_PropertyAddress;

	private static int RemoveTransformCurveKey_ReturnValue_Offset;

	private static bool RemoveCurveKey_IsValid;

	private IntPtr RemoveCurveKey_InstanceFunctionAddress;

	private static IntPtr RemoveCurveKey_FunctionAddress;

	private static int RemoveCurveKey_ParamsSize;

	private static bool RemoveCurveKey_CurveId_IsValid;

	private static FFieldAddress RemoveCurveKey_CurveId_PropertyAddress;

	private static int RemoveCurveKey_CurveId_Offset;

	private static bool RemoveCurveKey_Time_IsValid;

	private static FFieldAddress RemoveCurveKey_Time_PropertyAddress;

	private static int RemoveCurveKey_Time_Offset;

	private static bool RemoveCurveKey_bShouldTransact_IsValid;

	private static FFieldAddress RemoveCurveKey_bShouldTransact_PropertyAddress;

	private static int RemoveCurveKey_bShouldTransact_Offset;

	private static bool RemoveCurveKey_ReturnValue_IsValid;

	private static FFieldAddress RemoveCurveKey_ReturnValue_PropertyAddress;

	private static int RemoveCurveKey_ReturnValue_Offset;

	private static bool RemoveCurve_IsValid;

	private IntPtr RemoveCurve_InstanceFunctionAddress;

	private static IntPtr RemoveCurve_FunctionAddress;

	private static int RemoveCurve_ParamsSize;

	private static bool RemoveCurve_CurveId_IsValid;

	private static FFieldAddress RemoveCurve_CurveId_PropertyAddress;

	private static int RemoveCurve_CurveId_Offset;

	private static bool RemoveCurve_bShouldTransact_IsValid;

	private static FFieldAddress RemoveCurve_bShouldTransact_PropertyAddress;

	private static int RemoveCurve_bShouldTransact_Offset;

	private static bool RemoveCurve_ReturnValue_IsValid;

	private static FFieldAddress RemoveCurve_ReturnValue_PropertyAddress;

	private static int RemoveCurve_ReturnValue_Offset;

	private static bool RemoveBoneTrack_IsValid;

	private IntPtr RemoveBoneTrack_InstanceFunctionAddress;

	private static IntPtr RemoveBoneTrack_FunctionAddress;

	private static int RemoveBoneTrack_ParamsSize;

	private static bool RemoveBoneTrack_BoneName_IsValid;

	private static FFieldAddress RemoveBoneTrack_BoneName_PropertyAddress;

	private static int RemoveBoneTrack_BoneName_Offset;

	private static bool RemoveBoneTrack_bShouldTransact_IsValid;

	private static FFieldAddress RemoveBoneTrack_bShouldTransact_PropertyAddress;

	private static int RemoveBoneTrack_bShouldTransact_Offset;

	private static bool RemoveBoneTrack_ReturnValue_IsValid;

	private static FFieldAddress RemoveBoneTrack_ReturnValue_PropertyAddress;

	private static int RemoveBoneTrack_ReturnValue_Offset;

	private static bool RemoveAttributeKey_IsValid;

	private IntPtr RemoveAttributeKey_InstanceFunctionAddress;

	private static IntPtr RemoveAttributeKey_FunctionAddress;

	private static int RemoveAttributeKey_ParamsSize;

	private static bool RemoveAttributeKey_AttributeIdentifier_IsValid;

	private static FFieldAddress RemoveAttributeKey_AttributeIdentifier_PropertyAddress;

	private static int RemoveAttributeKey_AttributeIdentifier_Offset;

	private static bool RemoveAttributeKey_Time_IsValid;

	private static FFieldAddress RemoveAttributeKey_Time_PropertyAddress;

	private static int RemoveAttributeKey_Time_Offset;

	private static bool RemoveAttributeKey_bShouldTransact_IsValid;

	private static FFieldAddress RemoveAttributeKey_bShouldTransact_PropertyAddress;

	private static int RemoveAttributeKey_bShouldTransact_Offset;

	private static bool RemoveAttributeKey_ReturnValue_IsValid;

	private static FFieldAddress RemoveAttributeKey_ReturnValue_PropertyAddress;

	private static int RemoveAttributeKey_ReturnValue_Offset;

	private static bool RemoveAttribute_IsValid;

	private IntPtr RemoveAttribute_InstanceFunctionAddress;

	private static IntPtr RemoveAttribute_FunctionAddress;

	private static int RemoveAttribute_ParamsSize;

	private static bool RemoveAttribute_AttributeIdentifier_IsValid;

	private static FFieldAddress RemoveAttribute_AttributeIdentifier_PropertyAddress;

	private static int RemoveAttribute_AttributeIdentifier_Offset;

	private static bool RemoveAttribute_bShouldTransact_IsValid;

	private static FFieldAddress RemoveAttribute_bShouldTransact_PropertyAddress;

	private static int RemoveAttribute_bShouldTransact_Offset;

	private static bool RemoveAttribute_ReturnValue_IsValid;

	private static FFieldAddress RemoveAttribute_ReturnValue_PropertyAddress;

	private static int RemoveAttribute_ReturnValue_Offset;

	private static bool RemoveAllCurvesOfType_IsValid;

	private IntPtr RemoveAllCurvesOfType_InstanceFunctionAddress;

	private static IntPtr RemoveAllCurvesOfType_FunctionAddress;

	private static int RemoveAllCurvesOfType_ParamsSize;

	private static bool RemoveAllCurvesOfType_SupportedCurveType_IsValid;

	private static FFieldAddress RemoveAllCurvesOfType_SupportedCurveType_PropertyAddress;

	private static int RemoveAllCurvesOfType_SupportedCurveType_Offset;

	private static bool RemoveAllCurvesOfType_bShouldTransact_IsValid;

	private static FFieldAddress RemoveAllCurvesOfType_bShouldTransact_PropertyAddress;

	private static int RemoveAllCurvesOfType_bShouldTransact_Offset;

	private static bool RemoveAllBoneTracks_IsValid;

	private IntPtr RemoveAllBoneTracks_InstanceFunctionAddress;

	private static IntPtr RemoveAllBoneTracks_FunctionAddress;

	private static int RemoveAllBoneTracks_ParamsSize;

	private static bool RemoveAllBoneTracks_bShouldTransact_IsValid;

	private static FFieldAddress RemoveAllBoneTracks_bShouldTransact_PropertyAddress;

	private static int RemoveAllBoneTracks_bShouldTransact_Offset;

	private static bool RemoveAllAttributesForBone_IsValid;

	private IntPtr RemoveAllAttributesForBone_InstanceFunctionAddress;

	private static IntPtr RemoveAllAttributesForBone_FunctionAddress;

	private static int RemoveAllAttributesForBone_ParamsSize;

	private static bool RemoveAllAttributesForBone_BoneName_IsValid;

	private static FFieldAddress RemoveAllAttributesForBone_BoneName_PropertyAddress;

	private static int RemoveAllAttributesForBone_BoneName_Offset;

	private static bool RemoveAllAttributesForBone_bShouldTransact_IsValid;

	private static FFieldAddress RemoveAllAttributesForBone_bShouldTransact_PropertyAddress;

	private static int RemoveAllAttributesForBone_bShouldTransact_Offset;

	private static bool RemoveAllAttributesForBone_ReturnValue_IsValid;

	private static FFieldAddress RemoveAllAttributesForBone_ReturnValue_PropertyAddress;

	private static int RemoveAllAttributesForBone_ReturnValue_Offset;

	private static bool RemoveAllAttributes_IsValid;

	private IntPtr RemoveAllAttributes_InstanceFunctionAddress;

	private static IntPtr RemoveAllAttributes_FunctionAddress;

	private static int RemoveAllAttributes_ParamsSize;

	private static bool RemoveAllAttributes_bShouldTransact_IsValid;

	private static FFieldAddress RemoveAllAttributes_bShouldTransact_PropertyAddress;

	private static int RemoveAllAttributes_bShouldTransact_Offset;

	private static bool RemoveAllAttributes_ReturnValue_IsValid;

	private static FFieldAddress RemoveAllAttributes_ReturnValue_PropertyAddress;

	private static int RemoveAllAttributes_ReturnValue_Offset;

	private static bool OpenBracket_IsValid;

	private IntPtr OpenBracket_InstanceFunctionAddress;

	private static IntPtr OpenBracket_FunctionAddress;

	private static int OpenBracket_ParamsSize;

	private static bool OpenBracket_InTitle_IsValid;

	private static FFieldAddress OpenBracket_InTitle_PropertyAddress;

	private static int OpenBracket_InTitle_Offset;

	private static bool OpenBracket_bShouldTransact_IsValid;

	private static FFieldAddress OpenBracket_bShouldTransact_PropertyAddress;

	private static int OpenBracket_bShouldTransact_Offset;

	private static bool InsertBoneTrack_IsValid;

	private IntPtr InsertBoneTrack_InstanceFunctionAddress;

	private static IntPtr InsertBoneTrack_FunctionAddress;

	private static int InsertBoneTrack_ParamsSize;

	private static bool InsertBoneTrack_BoneName_IsValid;

	private static FFieldAddress InsertBoneTrack_BoneName_PropertyAddress;

	private static int InsertBoneTrack_BoneName_Offset;

	private static bool InsertBoneTrack_DesiredIndex_IsValid;

	private static FFieldAddress InsertBoneTrack_DesiredIndex_PropertyAddress;

	private static int InsertBoneTrack_DesiredIndex_Offset;

	private static bool InsertBoneTrack_bShouldTransact_IsValid;

	private static FFieldAddress InsertBoneTrack_bShouldTransact_PropertyAddress;

	private static int InsertBoneTrack_bShouldTransact_Offset;

	private static bool InsertBoneTrack_ReturnValue_IsValid;

	private static FFieldAddress InsertBoneTrack_ReturnValue_PropertyAddress;

	private static int InsertBoneTrack_ReturnValue_Offset;

	private static bool GetModel_IsValid;

	private IntPtr GetModel_InstanceFunctionAddress;

	private static IntPtr GetModel_FunctionAddress;

	private static int GetModel_ParamsSize;

	private static bool GetModel_ReturnValue_IsValid;

	private static FFieldAddress GetModel_ReturnValue_PropertyAddress;

	private static int GetModel_ReturnValue_Offset;

	private static bool FindOrAddCurveNamesOnSkeleton_IsValid;

	private IntPtr FindOrAddCurveNamesOnSkeleton_InstanceFunctionAddress;

	private static IntPtr FindOrAddCurveNamesOnSkeleton_FunctionAddress;

	private static int FindOrAddCurveNamesOnSkeleton_ParamsSize;

	private static bool FindOrAddCurveNamesOnSkeleton_Skeleton_IsValid;

	private static FFieldAddress FindOrAddCurveNamesOnSkeleton_Skeleton_PropertyAddress;

	private static int FindOrAddCurveNamesOnSkeleton_Skeleton_Offset;

	private static bool FindOrAddCurveNamesOnSkeleton_SupportedCurveType_IsValid;

	private static FFieldAddress FindOrAddCurveNamesOnSkeleton_SupportedCurveType_PropertyAddress;

	private static int FindOrAddCurveNamesOnSkeleton_SupportedCurveType_Offset;

	private static bool FindOrAddCurveNamesOnSkeleton_bShouldTransact_IsValid;

	private static FFieldAddress FindOrAddCurveNamesOnSkeleton_bShouldTransact_PropertyAddress;

	private static int FindOrAddCurveNamesOnSkeleton_bShouldTransact_Offset;

	private static bool DuplicateCurve_IsValid;

	private IntPtr DuplicateCurve_InstanceFunctionAddress;

	private static IntPtr DuplicateCurve_FunctionAddress;

	private static int DuplicateCurve_ParamsSize;

	private static bool DuplicateCurve_CopyCurveId_IsValid;

	private static FFieldAddress DuplicateCurve_CopyCurveId_PropertyAddress;

	private static int DuplicateCurve_CopyCurveId_Offset;

	private static bool DuplicateCurve_NewCurveId_IsValid;

	private static FFieldAddress DuplicateCurve_NewCurveId_PropertyAddress;

	private static int DuplicateCurve_NewCurveId_Offset;

	private static bool DuplicateCurve_bShouldTransact_IsValid;

	private static FFieldAddress DuplicateCurve_bShouldTransact_PropertyAddress;

	private static int DuplicateCurve_bShouldTransact_Offset;

	private static bool DuplicateCurve_ReturnValue_IsValid;

	private static FFieldAddress DuplicateCurve_ReturnValue_PropertyAddress;

	private static int DuplicateCurve_ReturnValue_Offset;

	private static bool DuplicateAttribute_IsValid;

	private IntPtr DuplicateAttribute_InstanceFunctionAddress;

	private static IntPtr DuplicateAttribute_FunctionAddress;

	private static int DuplicateAttribute_ParamsSize;

	private static bool DuplicateAttribute_AttributeIdentifier_IsValid;

	private static FFieldAddress DuplicateAttribute_AttributeIdentifier_PropertyAddress;

	private static int DuplicateAttribute_AttributeIdentifier_Offset;

	private static bool DuplicateAttribute_NewAttributeIdentifier_IsValid;

	private static FFieldAddress DuplicateAttribute_NewAttributeIdentifier_PropertyAddress;

	private static int DuplicateAttribute_NewAttributeIdentifier_Offset;

	private static bool DuplicateAttribute_bShouldTransact_IsValid;

	private static FFieldAddress DuplicateAttribute_bShouldTransact_PropertyAddress;

	private static int DuplicateAttribute_bShouldTransact_Offset;

	private static bool DuplicateAttribute_ReturnValue_IsValid;

	private static FFieldAddress DuplicateAttribute_ReturnValue_PropertyAddress;

	private static int DuplicateAttribute_ReturnValue_Offset;

	private static bool CloseBracket_IsValid;

	private IntPtr CloseBracket_InstanceFunctionAddress;

	private static IntPtr CloseBracket_FunctionAddress;

	private static int CloseBracket_ParamsSize;

	private static bool CloseBracket_bShouldTransact_IsValid;

	private static FFieldAddress CloseBracket_bShouldTransact_PropertyAddress;

	private static int CloseBracket_bShouldTransact_Offset;

	private static bool AddCurve_IsValid;

	private IntPtr AddCurve_InstanceFunctionAddress;

	private static IntPtr AddCurve_FunctionAddress;

	private static int AddCurve_ParamsSize;

	private static bool AddCurve_CurveId_IsValid;

	private static FFieldAddress AddCurve_CurveId_PropertyAddress;

	private static int AddCurve_CurveId_Offset;

	private static bool AddCurve_CurveFlags_IsValid;

	private static FFieldAddress AddCurve_CurveFlags_PropertyAddress;

	private static int AddCurve_CurveFlags_Offset;

	private static bool AddCurve_bShouldTransact_IsValid;

	private static FFieldAddress AddCurve_bShouldTransact_PropertyAddress;

	private static int AddCurve_bShouldTransact_Offset;

	private static bool AddCurve_ReturnValue_IsValid;

	private static FFieldAddress AddCurve_ReturnValue_PropertyAddress;

	private static int AddCurve_ReturnValue_Offset;

	private static bool AddBoneTrack_IsValid;

	private IntPtr AddBoneTrack_InstanceFunctionAddress;

	private static IntPtr AddBoneTrack_FunctionAddress;

	private static int AddBoneTrack_ParamsSize;

	private static bool AddBoneTrack_BoneName_IsValid;

	private static FFieldAddress AddBoneTrack_BoneName_PropertyAddress;

	private static int AddBoneTrack_BoneName_Offset;

	private static bool AddBoneTrack_bShouldTransact_IsValid;

	private static FFieldAddress AddBoneTrack_bShouldTransact_PropertyAddress;

	private static int AddBoneTrack_bShouldTransact_Offset;

	private static bool AddBoneTrack_ReturnValue_IsValid;

	private static FFieldAddress AddBoneTrack_ReturnValue_PropertyAddress;

	private static int AddBoneTrack_ReturnValue_Offset;

	private static bool AddAttribute_IsValid;

	private IntPtr AddAttribute_InstanceFunctionAddress;

	private static IntPtr AddAttribute_FunctionAddress;

	private static int AddAttribute_ParamsSize;

	private static bool AddAttribute_AttributeIdentifier_IsValid;

	private static FFieldAddress AddAttribute_AttributeIdentifier_PropertyAddress;

	private static int AddAttribute_AttributeIdentifier_Offset;

	private static bool AddAttribute_bShouldTransact_IsValid;

	private static FFieldAddress AddAttribute_bShouldTransact_PropertyAddress;

	private static int AddAttribute_bShouldTransact_Offset;

	private static bool AddAttribute_ReturnValue_IsValid;

	private static FFieldAddress AddAttribute_ReturnValue_PropertyAddress;

	private static int AddAttribute_ReturnValue_Offset;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:UpdateCurveNamesFromSkeleton")]
	public unsafe void UpdateCurveNamesFromSkeleton(USkeleton Skeleton, ERawCurveTrackTypes SupportedCurveType, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!UpdateCurveNamesFromSkeleton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:UpdateCurveNamesFromSkeleton");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateCurveNamesFromSkeleton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateCurveNamesFromSkeleton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, UpdateCurveNamesFromSkeleton_Skeleton_Offset), 0, UpdateCurveNamesFromSkeleton_Skeleton_PropertyAddress.Address, Skeleton);
		EnumMarshaler<ERawCurveTrackTypes>.ToNative(IntPtr.Add(intPtr, UpdateCurveNamesFromSkeleton_SupportedCurveType_Offset), 0, UpdateCurveNamesFromSkeleton_SupportedCurveType_PropertyAddress.Address, SupportedCurveType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UpdateCurveNamesFromSkeleton_bShouldTransact_Offset), 0, UpdateCurveNamesFromSkeleton_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateCurveNamesFromSkeleton_FunctionAddress, intPtr, UpdateCurveNamesFromSkeleton_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetTransformCurveKeys")]
	public unsafe bool SetTransformCurveKeys(FAnimationCurveIdentifier CurveId, List<FTransform> TransformValues, List<float> TimeKeys, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!SetTransformCurveKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:SetTransformCurveKeys");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTransformCurveKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTransformCurveKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetTransformCurveKeys_CurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, SetTransformCurveKeys_CurveId_Offset), 0, SetTransformCurveKeys_CurveId_PropertyAddress.Address, CurveId);
		new TArrayCopyMarshaler<FTransform>(1, SetTransformCurveKeys_TransformValues_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(intPtr, SetTransformCurveKeys_TransformValues_Offset), TransformValues);
		new TArrayCopyMarshaler<float>(1, SetTransformCurveKeys_TimeKeys_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, SetTransformCurveKeys_TimeKeys_Offset), TimeKeys);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTransformCurveKeys_bShouldTransact_Offset), 0, SetTransformCurveKeys_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTransformCurveKeys_FunctionAddress, intPtr, SetTransformCurveKeys_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTransformCurveKeys_TransformValues_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetTransformCurveKeys_TimeKeys_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetTransformCurveKeys_ReturnValue_Offset), 0, SetTransformCurveKeys_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetTransformCurveKey")]
	public unsafe bool SetTransformCurveKey(FAnimationCurveIdentifier CurveId, float Time, FTransform Value, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!SetTransformCurveKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:SetTransformCurveKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTransformCurveKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTransformCurveKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetTransformCurveKey_CurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, SetTransformCurveKey_CurveId_Offset), 0, SetTransformCurveKey_CurveId_PropertyAddress.Address, CurveId);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTransformCurveKey_Time_Offset), 0, SetTransformCurveKey_Time_PropertyAddress.Address, Time);
		NativeReflection.InitializeValue_InContainer(SetTransformCurveKey_Value_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetTransformCurveKey_Value_Offset), 0, SetTransformCurveKey_Value_PropertyAddress.Address, Value);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTransformCurveKey_bShouldTransact_Offset), 0, SetTransformCurveKey_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTransformCurveKey_FunctionAddress, intPtr, SetTransformCurveKey_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetTransformCurveKey_ReturnValue_Offset), 0, SetTransformCurveKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetPlayLength")]
	public unsafe void SetPlayLength(float Length, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!SetPlayLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:SetPlayLength");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlayLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlayLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlayLength_Length_Offset), 0, SetPlayLength_Length_PropertyAddress.Address, Length);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPlayLength_bShouldTransact_Offset), 0, SetPlayLength_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlayLength_FunctionAddress, intPtr, SetPlayLength_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetModel")]
	public unsafe void SetModel(UAnimDataModel InModel)
	{
		CheckDestroyed();
		if (!SetModel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:SetModel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetModel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetModel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimDataModel>.ToNative(IntPtr.Add(intPtr, SetModel_InModel_Offset), 0, SetModel_InModel_PropertyAddress.Address, InModel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetModel_FunctionAddress, intPtr, SetModel_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetFrameRate")]
	public unsafe void SetFrameRate(FFrameRate FrameRate, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!SetFrameRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:SetFrameRate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFrameRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFrameRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, SetFrameRate_FrameRate_Offset), 0, SetFrameRate_FrameRate_PropertyAddress.Address, FrameRate);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetFrameRate_bShouldTransact_Offset), 0, SetFrameRate_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFrameRate_FunctionAddress, intPtr, SetFrameRate_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetCurveKeys")]
	public unsafe bool SetCurveKeys(FAnimationCurveIdentifier CurveId, List<FRichCurveKey> CurveKeys, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!SetCurveKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:SetCurveKeys");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurveKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurveKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetCurveKeys_CurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, SetCurveKeys_CurveId_Offset), 0, SetCurveKeys_CurveId_PropertyAddress.Address, CurveId);
		new TArrayCopyMarshaler<FRichCurveKey>(1, SetCurveKeys_CurveKeys_PropertyAddress, CachedMarshalingDelegates<FRichCurveKey, FRichCurveKey>.FromNative, CachedMarshalingDelegates<FRichCurveKey, FRichCurveKey>.ToNative).ToNative(IntPtr.Add(intPtr, SetCurveKeys_CurveKeys_Offset), CurveKeys);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCurveKeys_bShouldTransact_Offset), 0, SetCurveKeys_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCurveKeys_FunctionAddress, intPtr, SetCurveKeys_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCurveKeys_CurveKeys_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurveKeys_ReturnValue_Offset), 0, SetCurveKeys_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetCurveKey")]
	public unsafe bool SetCurveKey(FAnimationCurveIdentifier CurveId, FRichCurveKey Key, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!SetCurveKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:SetCurveKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurveKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurveKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetCurveKey_CurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, SetCurveKey_CurveId_Offset), 0, SetCurveKey_CurveId_PropertyAddress.Address, CurveId);
		FRichCurveKey.ToNative(IntPtr.Add(intPtr, SetCurveKey_Key_Offset), 0, SetCurveKey_Key_PropertyAddress.Address, Key);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCurveKey_bShouldTransact_Offset), 0, SetCurveKey_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCurveKey_FunctionAddress, intPtr, SetCurveKey_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurveKey_ReturnValue_Offset), 0, SetCurveKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetCurveFlags")]
	public unsafe bool SetCurveFlags(FAnimationCurveIdentifier CurveId, int Flags, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!SetCurveFlags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:SetCurveFlags");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurveFlags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurveFlags_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetCurveFlags_CurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, SetCurveFlags_CurveId_Offset), 0, SetCurveFlags_CurveId_PropertyAddress.Address, CurveId);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCurveFlags_Flags_Offset), 0, SetCurveFlags_Flags_PropertyAddress.Address, Flags);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCurveFlags_bShouldTransact_Offset), 0, SetCurveFlags_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCurveFlags_FunctionAddress, intPtr, SetCurveFlags_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurveFlags_ReturnValue_Offset), 0, SetCurveFlags_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetCurveFlag")]
	public unsafe bool SetCurveFlag(FAnimationCurveIdentifier CurveId, EAnimAssetCurveFlags Flag, bool bState = true, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!SetCurveFlag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:SetCurveFlag");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurveFlag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurveFlag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetCurveFlag_CurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, SetCurveFlag_CurveId_Offset), 0, SetCurveFlag_CurveId_PropertyAddress.Address, CurveId);
		EnumMarshaler<EAnimAssetCurveFlags>.ToNative(IntPtr.Add(intPtr, SetCurveFlag_Flag_Offset), 0, SetCurveFlag_Flag_PropertyAddress.Address, Flag);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCurveFlag_bState_Offset), 0, SetCurveFlag_bState_PropertyAddress.Address, bState);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCurveFlag_bShouldTransact_Offset), 0, SetCurveFlag_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCurveFlag_FunctionAddress, intPtr, SetCurveFlag_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurveFlag_ReturnValue_Offset), 0, SetCurveFlag_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetCurveColor")]
	public unsafe bool SetCurveColor(FAnimationCurveIdentifier CurveId, FLinearColor Color, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!SetCurveColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:SetCurveColor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurveColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurveColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetCurveColor_CurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, SetCurveColor_CurveId_Offset), 0, SetCurveColor_CurveId_PropertyAddress.Address, CurveId);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetCurveColor_Color_Offset), 0, SetCurveColor_Color_PropertyAddress.Address, Color);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCurveColor_bShouldTransact_Offset), 0, SetCurveColor_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCurveColor_FunctionAddress, intPtr, SetCurveColor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurveColor_ReturnValue_Offset), 0, SetCurveColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:SetBoneTrackKeys")]
	public unsafe bool SetBoneTrackKeys(FName BoneName, List<FVector> PositionalKeys, List<FQuat> RotationalKeys, List<FVector> ScalingKeys, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!SetBoneTrackKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:SetBoneTrackKeys");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoneTrackKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoneTrackKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBoneTrackKeys_BoneName_Offset), 0, SetBoneTrackKeys_BoneName_PropertyAddress.Address, BoneName);
		new TArrayCopyMarshaler<FVector>(1, SetBoneTrackKeys_PositionalKeys_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, SetBoneTrackKeys_PositionalKeys_Offset), PositionalKeys);
		new TArrayCopyMarshaler<FQuat>(1, SetBoneTrackKeys_RotationalKeys_PropertyAddress, CachedMarshalingDelegates<FQuat, BlittableTypeMarshaler<FQuat>>.FromNative, CachedMarshalingDelegates<FQuat, BlittableTypeMarshaler<FQuat>>.ToNative).ToNative(IntPtr.Add(intPtr, SetBoneTrackKeys_RotationalKeys_Offset), RotationalKeys);
		new TArrayCopyMarshaler<FVector>(1, SetBoneTrackKeys_ScalingKeys_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, SetBoneTrackKeys_ScalingKeys_Offset), ScalingKeys);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBoneTrackKeys_bShouldTransact_Offset), 0, SetBoneTrackKeys_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoneTrackKeys_FunctionAddress, intPtr, SetBoneTrackKeys_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBoneTrackKeys_PositionalKeys_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetBoneTrackKeys_RotationalKeys_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetBoneTrackKeys_ScalingKeys_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetBoneTrackKeys_ReturnValue_Offset), 0, SetBoneTrackKeys_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:ScaleCurve")]
	public unsafe bool ScaleCurve(FAnimationCurveIdentifier CurveId, float Origin, float Factor, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!ScaleCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:ScaleCurve");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScaleCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScaleCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ScaleCurve_CurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, ScaleCurve_CurveId_Offset), 0, ScaleCurve_CurveId_PropertyAddress.Address, CurveId);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ScaleCurve_Origin_Offset), 0, ScaleCurve_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ScaleCurve_Factor_Offset), 0, ScaleCurve_Factor_PropertyAddress.Address, Factor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScaleCurve_bShouldTransact_Offset), 0, ScaleCurve_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScaleCurve_FunctionAddress, intPtr, ScaleCurve_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScaleCurve_ReturnValue_Offset), 0, ScaleCurve_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:ResizePlayLength")]
	public unsafe void ResizePlayLength(float NewLength, float T0, float T1, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!ResizePlayLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:ResizePlayLength");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResizePlayLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResizePlayLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ResizePlayLength_NewLength_Offset), 0, ResizePlayLength_NewLength_PropertyAddress.Address, NewLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ResizePlayLength_T0_Offset), 0, ResizePlayLength_T0_PropertyAddress.Address, T0);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ResizePlayLength_T1_Offset), 0, ResizePlayLength_T1_PropertyAddress.Address, T1);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ResizePlayLength_bShouldTransact_Offset), 0, ResizePlayLength_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResizePlayLength_FunctionAddress, intPtr, ResizePlayLength_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:Resize")]
	public unsafe void Resize(float Length, float T0, float T1, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!Resize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:Resize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Resize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Resize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Resize_Length_Offset), 0, Resize_Length_PropertyAddress.Address, Length);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Resize_T0_Offset), 0, Resize_T0_PropertyAddress.Address, T0);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Resize_T1_Offset), 0, Resize_T1_PropertyAddress.Address, T1);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Resize_bShouldTransact_Offset), 0, Resize_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, Resize_FunctionAddress, intPtr, Resize_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RenameCurve")]
	public unsafe bool RenameCurve(FAnimationCurveIdentifier CurveToRenameId, FAnimationCurveIdentifier NewCurveId, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!RenameCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:RenameCurve");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RenameCurve_CurveToRenameId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, RenameCurve_CurveToRenameId_Offset), 0, RenameCurve_CurveToRenameId_PropertyAddress.Address, CurveToRenameId);
		NativeReflection.InitializeValue_InContainer(RenameCurve_NewCurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, RenameCurve_NewCurveId_Offset), 0, RenameCurve_NewCurveId_PropertyAddress.Address, NewCurveId);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RenameCurve_bShouldTransact_Offset), 0, RenameCurve_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenameCurve_FunctionAddress, intPtr, RenameCurve_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenameCurve_ReturnValue_Offset), 0, RenameCurve_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveTransformCurveKey")]
	public unsafe bool RemoveTransformCurveKey(FAnimationCurveIdentifier CurveId, float Time, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!RemoveTransformCurveKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:RemoveTransformCurveKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveTransformCurveKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveTransformCurveKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveTransformCurveKey_CurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, RemoveTransformCurveKey_CurveId_Offset), 0, RemoveTransformCurveKey_CurveId_PropertyAddress.Address, CurveId);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, RemoveTransformCurveKey_Time_Offset), 0, RemoveTransformCurveKey_Time_PropertyAddress.Address, Time);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveTransformCurveKey_bShouldTransact_Offset), 0, RemoveTransformCurveKey_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveTransformCurveKey_FunctionAddress, intPtr, RemoveTransformCurveKey_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveTransformCurveKey_ReturnValue_Offset), 0, RemoveTransformCurveKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveCurveKey")]
	public unsafe bool RemoveCurveKey(FAnimationCurveIdentifier CurveId, float Time, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!RemoveCurveKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:RemoveCurveKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveCurveKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveCurveKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveCurveKey_CurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, RemoveCurveKey_CurveId_Offset), 0, RemoveCurveKey_CurveId_PropertyAddress.Address, CurveId);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, RemoveCurveKey_Time_Offset), 0, RemoveCurveKey_Time_PropertyAddress.Address, Time);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveCurveKey_bShouldTransact_Offset), 0, RemoveCurveKey_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveCurveKey_FunctionAddress, intPtr, RemoveCurveKey_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveCurveKey_ReturnValue_Offset), 0, RemoveCurveKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveCurve")]
	public unsafe bool RemoveCurve(FAnimationCurveIdentifier CurveId, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!RemoveCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:RemoveCurve");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveCurve_CurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, RemoveCurve_CurveId_Offset), 0, RemoveCurve_CurveId_PropertyAddress.Address, CurveId);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveCurve_bShouldTransact_Offset), 0, RemoveCurve_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveCurve_FunctionAddress, intPtr, RemoveCurve_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveCurve_ReturnValue_Offset), 0, RemoveCurve_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveBoneTrack")]
	public unsafe bool RemoveBoneTrack(FName BoneName, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!RemoveBoneTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:RemoveBoneTrack");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveBoneTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveBoneTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveBoneTrack_BoneName_Offset), 0, RemoveBoneTrack_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveBoneTrack_bShouldTransact_Offset), 0, RemoveBoneTrack_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveBoneTrack_FunctionAddress, intPtr, RemoveBoneTrack_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveBoneTrack_ReturnValue_Offset), 0, RemoveBoneTrack_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveAttributeKey")]
	public unsafe bool RemoveAttributeKey(FAnimationAttributeIdentifier AttributeIdentifier, float Time, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!RemoveAttributeKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:RemoveAttributeKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAttributeKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAttributeKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveAttributeKey_AttributeIdentifier_PropertyAddress.Address, intPtr);
		FAnimationAttributeIdentifier.ToNative(IntPtr.Add(intPtr, RemoveAttributeKey_AttributeIdentifier_Offset), 0, RemoveAttributeKey_AttributeIdentifier_PropertyAddress.Address, AttributeIdentifier);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, RemoveAttributeKey_Time_Offset), 0, RemoveAttributeKey_Time_PropertyAddress.Address, Time);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveAttributeKey_bShouldTransact_Offset), 0, RemoveAttributeKey_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAttributeKey_FunctionAddress, intPtr, RemoveAttributeKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveAttributeKey_AttributeIdentifier_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveAttributeKey_ReturnValue_Offset), 0, RemoveAttributeKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveAttribute")]
	public unsafe bool RemoveAttribute(FAnimationAttributeIdentifier AttributeIdentifier, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!RemoveAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:RemoveAttribute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveAttribute_AttributeIdentifier_PropertyAddress.Address, intPtr);
		FAnimationAttributeIdentifier.ToNative(IntPtr.Add(intPtr, RemoveAttribute_AttributeIdentifier_Offset), 0, RemoveAttribute_AttributeIdentifier_PropertyAddress.Address, AttributeIdentifier);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveAttribute_bShouldTransact_Offset), 0, RemoveAttribute_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAttribute_FunctionAddress, intPtr, RemoveAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveAttribute_AttributeIdentifier_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveAttribute_ReturnValue_Offset), 0, RemoveAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveAllCurvesOfType")]
	public unsafe void RemoveAllCurvesOfType(ERawCurveTrackTypes SupportedCurveType, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!RemoveAllCurvesOfType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:RemoveAllCurvesOfType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllCurvesOfType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllCurvesOfType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERawCurveTrackTypes>.ToNative(IntPtr.Add(intPtr, RemoveAllCurvesOfType_SupportedCurveType_Offset), 0, RemoveAllCurvesOfType_SupportedCurveType_PropertyAddress.Address, SupportedCurveType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveAllCurvesOfType_bShouldTransact_Offset), 0, RemoveAllCurvesOfType_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAllCurvesOfType_FunctionAddress, intPtr, RemoveAllCurvesOfType_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveAllBoneTracks")]
	public unsafe void RemoveAllBoneTracks(bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!RemoveAllBoneTracks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:RemoveAllBoneTracks");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllBoneTracks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllBoneTracks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveAllBoneTracks_bShouldTransact_Offset), 0, RemoveAllBoneTracks_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAllBoneTracks_FunctionAddress, intPtr, RemoveAllBoneTracks_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveAllAttributesForBone")]
	public unsafe int RemoveAllAttributesForBone(FName BoneName, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!RemoveAllAttributesForBone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:RemoveAllAttributesForBone");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllAttributesForBone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllAttributesForBone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveAllAttributesForBone_BoneName_Offset), 0, RemoveAllAttributesForBone_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveAllAttributesForBone_bShouldTransact_Offset), 0, RemoveAllAttributesForBone_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAllAttributesForBone_FunctionAddress, intPtr, RemoveAllAttributesForBone_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, RemoveAllAttributesForBone_ReturnValue_Offset), 0, RemoveAllAttributesForBone_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:RemoveAllAttributes")]
	public unsafe int RemoveAllAttributes(bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!RemoveAllAttributes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:RemoveAllAttributes");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllAttributes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllAttributes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveAllAttributes_bShouldTransact_Offset), 0, RemoveAllAttributes_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAllAttributes_FunctionAddress, intPtr, RemoveAllAttributes_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, RemoveAllAttributes_ReturnValue_Offset), 0, RemoveAllAttributes_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:OpenBracket")]
	public unsafe void OpenBracket(FText InTitle, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!OpenBracket_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:OpenBracket");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenBracket_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenBracket_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OpenBracket_InTitle_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, OpenBracket_InTitle_Offset), 0, OpenBracket_InTitle_PropertyAddress.Address, InTitle);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OpenBracket_bShouldTransact_Offset), 0, OpenBracket_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, OpenBracket_FunctionAddress, intPtr, OpenBracket_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OpenBracket_InTitle_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:InsertBoneTrack")]
	public unsafe int InsertBoneTrack(FName BoneName, int DesiredIndex, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!InsertBoneTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:InsertBoneTrack");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InsertBoneTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InsertBoneTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, InsertBoneTrack_BoneName_Offset), 0, InsertBoneTrack_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InsertBoneTrack_DesiredIndex_Offset), 0, InsertBoneTrack_DesiredIndex_PropertyAddress.Address, DesiredIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, InsertBoneTrack_bShouldTransact_Offset), 0, InsertBoneTrack_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, InsertBoneTrack_FunctionAddress, intPtr, InsertBoneTrack_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, InsertBoneTrack_ReturnValue_Offset), 0, InsertBoneTrack_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:GetModel")]
	public unsafe UAnimDataModel GetModel()
	{
		CheckDestroyed();
		if (!GetModel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:GetModel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetModel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetModel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetModel_FunctionAddress, intPtr, GetModel_ParamsSize);
		return UObjectMarshaler<UAnimDataModel>.FromNative(IntPtr.Add(intPtr, GetModel_ReturnValue_Offset), 0, GetModel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:FindOrAddCurveNamesOnSkeleton")]
	public unsafe void FindOrAddCurveNamesOnSkeleton(USkeleton Skeleton, ERawCurveTrackTypes SupportedCurveType, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!FindOrAddCurveNamesOnSkeleton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:FindOrAddCurveNamesOnSkeleton");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindOrAddCurveNamesOnSkeleton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindOrAddCurveNamesOnSkeleton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, FindOrAddCurveNamesOnSkeleton_Skeleton_Offset), 0, FindOrAddCurveNamesOnSkeleton_Skeleton_PropertyAddress.Address, Skeleton);
		EnumMarshaler<ERawCurveTrackTypes>.ToNative(IntPtr.Add(intPtr, FindOrAddCurveNamesOnSkeleton_SupportedCurveType_Offset), 0, FindOrAddCurveNamesOnSkeleton_SupportedCurveType_PropertyAddress.Address, SupportedCurveType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FindOrAddCurveNamesOnSkeleton_bShouldTransact_Offset), 0, FindOrAddCurveNamesOnSkeleton_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindOrAddCurveNamesOnSkeleton_FunctionAddress, intPtr, FindOrAddCurveNamesOnSkeleton_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:DuplicateCurve")]
	public unsafe bool DuplicateCurve(FAnimationCurveIdentifier CopyCurveId, FAnimationCurveIdentifier NewCurveId, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!DuplicateCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:DuplicateCurve");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DuplicateCurve_CopyCurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, DuplicateCurve_CopyCurveId_Offset), 0, DuplicateCurve_CopyCurveId_PropertyAddress.Address, CopyCurveId);
		NativeReflection.InitializeValue_InContainer(DuplicateCurve_NewCurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, DuplicateCurve_NewCurveId_Offset), 0, DuplicateCurve_NewCurveId_PropertyAddress.Address, NewCurveId);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateCurve_bShouldTransact_Offset), 0, DuplicateCurve_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, DuplicateCurve_FunctionAddress, intPtr, DuplicateCurve_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DuplicateCurve_ReturnValue_Offset), 0, DuplicateCurve_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:DuplicateAttribute")]
	public unsafe bool DuplicateAttribute(FAnimationAttributeIdentifier AttributeIdentifier, FAnimationAttributeIdentifier NewAttributeIdentifier, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!DuplicateAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:DuplicateAttribute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DuplicateAttribute_AttributeIdentifier_PropertyAddress.Address, intPtr);
		FAnimationAttributeIdentifier.ToNative(IntPtr.Add(intPtr, DuplicateAttribute_AttributeIdentifier_Offset), 0, DuplicateAttribute_AttributeIdentifier_PropertyAddress.Address, AttributeIdentifier);
		NativeReflection.InitializeValue_InContainer(DuplicateAttribute_NewAttributeIdentifier_PropertyAddress.Address, intPtr);
		FAnimationAttributeIdentifier.ToNative(IntPtr.Add(intPtr, DuplicateAttribute_NewAttributeIdentifier_Offset), 0, DuplicateAttribute_NewAttributeIdentifier_PropertyAddress.Address, NewAttributeIdentifier);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAttribute_bShouldTransact_Offset), 0, DuplicateAttribute_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, DuplicateAttribute_FunctionAddress, intPtr, DuplicateAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateAttribute_AttributeIdentifier_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateAttribute_NewAttributeIdentifier_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DuplicateAttribute_ReturnValue_Offset), 0, DuplicateAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:CloseBracket")]
	public unsafe void CloseBracket(bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!CloseBracket_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:CloseBracket");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloseBracket_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseBracket_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CloseBracket_bShouldTransact_Offset), 0, CloseBracket_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, CloseBracket_FunctionAddress, intPtr, CloseBracket_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:AddCurve")]
	public unsafe bool AddCurve(FAnimationCurveIdentifier CurveId, int CurveFlags = 4, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!AddCurve_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:AddCurve");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddCurve_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddCurve_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddCurve_CurveId_PropertyAddress.Address, intPtr);
		FAnimationCurveIdentifier.ToNative(IntPtr.Add(intPtr, AddCurve_CurveId_Offset), 0, AddCurve_CurveId_PropertyAddress.Address, CurveId);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddCurve_CurveFlags_Offset), 0, AddCurve_CurveFlags_PropertyAddress.Address, CurveFlags);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddCurve_bShouldTransact_Offset), 0, AddCurve_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddCurve_FunctionAddress, intPtr, AddCurve_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddCurve_ReturnValue_Offset), 0, AddCurve_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AnimationDataController:AddBoneTrack")]
	public unsafe int AddBoneTrack(FName BoneName, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!AddBoneTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:AddBoneTrack");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBoneTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBoneTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddBoneTrack_BoneName_Offset), 0, AddBoneTrack_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddBoneTrack_bShouldTransact_Offset), 0, AddBoneTrack_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddBoneTrack_FunctionAddress, intPtr, AddBoneTrack_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, AddBoneTrack_ReturnValue_Offset), 0, AddBoneTrack_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AnimationDataController:AddAttribute")]
	public unsafe bool AddAttribute(FAnimationAttributeIdentifier AttributeIdentifier, bool bShouldTransact = true)
	{
		CheckDestroyed();
		if (!AddAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimationDataController:AddAttribute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddAttribute_AttributeIdentifier_PropertyAddress.Address, intPtr);
		FAnimationAttributeIdentifier.ToNative(IntPtr.Add(intPtr, AddAttribute_AttributeIdentifier_Offset), 0, AddAttribute_AttributeIdentifier_PropertyAddress.Address, AttributeIdentifier);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddAttribute_bShouldTransact_Offset), 0, AddAttribute_bShouldTransact_PropertyAddress.Address, bShouldTransact);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddAttribute_FunctionAddress, intPtr, AddAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddAttribute_AttributeIdentifier_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddAttribute_ReturnValue_Offset), 0, AddAttribute_ReturnValue_PropertyAddress.Address);
	}

	static UAnimDataController()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimDataController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimDataController));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AnimationDataController.AnimDataController");
		UpdateCurveNamesFromSkeleton_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateCurveNamesFromSkeleton");
		UpdateCurveNamesFromSkeleton_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateCurveNamesFromSkeleton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateCurveNamesFromSkeleton_Skeleton_PropertyAddress, UpdateCurveNamesFromSkeleton_FunctionAddress, "Skeleton");
		UpdateCurveNamesFromSkeleton_Skeleton_Offset = NativeReflectionCached.GetPropertyOffset(UpdateCurveNamesFromSkeleton_FunctionAddress, "Skeleton");
		UpdateCurveNamesFromSkeleton_Skeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateCurveNamesFromSkeleton_FunctionAddress, "Skeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateCurveNamesFromSkeleton_SupportedCurveType_PropertyAddress, UpdateCurveNamesFromSkeleton_FunctionAddress, "SupportedCurveType");
		UpdateCurveNamesFromSkeleton_SupportedCurveType_Offset = NativeReflectionCached.GetPropertyOffset(UpdateCurveNamesFromSkeleton_FunctionAddress, "SupportedCurveType");
		UpdateCurveNamesFromSkeleton_SupportedCurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateCurveNamesFromSkeleton_FunctionAddress, "SupportedCurveType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateCurveNamesFromSkeleton_bShouldTransact_PropertyAddress, UpdateCurveNamesFromSkeleton_FunctionAddress, "bShouldTransact");
		UpdateCurveNamesFromSkeleton_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(UpdateCurveNamesFromSkeleton_FunctionAddress, "bShouldTransact");
		UpdateCurveNamesFromSkeleton_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateCurveNamesFromSkeleton_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		UpdateCurveNamesFromSkeleton_IsValid = UpdateCurveNamesFromSkeleton_FunctionAddress != IntPtr.Zero && UpdateCurveNamesFromSkeleton_Skeleton_IsValid && UpdateCurveNamesFromSkeleton_SupportedCurveType_IsValid && UpdateCurveNamesFromSkeleton_bShouldTransact_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:UpdateCurveNamesFromSkeleton", UpdateCurveNamesFromSkeleton_IsValid);
		SetTransformCurveKeys_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTransformCurveKeys");
		SetTransformCurveKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTransformCurveKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTransformCurveKeys_CurveId_PropertyAddress, SetTransformCurveKeys_FunctionAddress, "CurveId");
		SetTransformCurveKeys_CurveId_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformCurveKeys_FunctionAddress, "CurveId");
		SetTransformCurveKeys_CurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformCurveKeys_FunctionAddress, "CurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformCurveKeys_TransformValues_PropertyAddress, SetTransformCurveKeys_FunctionAddress, "TransformValues");
		SetTransformCurveKeys_TransformValues_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformCurveKeys_FunctionAddress, "TransformValues");
		SetTransformCurveKeys_TransformValues_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformCurveKeys_FunctionAddress, "TransformValues", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformCurveKeys_TimeKeys_PropertyAddress, SetTransformCurveKeys_FunctionAddress, "TimeKeys");
		SetTransformCurveKeys_TimeKeys_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformCurveKeys_FunctionAddress, "TimeKeys");
		SetTransformCurveKeys_TimeKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformCurveKeys_FunctionAddress, "TimeKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformCurveKeys_bShouldTransact_PropertyAddress, SetTransformCurveKeys_FunctionAddress, "bShouldTransact");
		SetTransformCurveKeys_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformCurveKeys_FunctionAddress, "bShouldTransact");
		SetTransformCurveKeys_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformCurveKeys_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformCurveKeys_ReturnValue_PropertyAddress, SetTransformCurveKeys_FunctionAddress, "ReturnValue");
		SetTransformCurveKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformCurveKeys_FunctionAddress, "ReturnValue");
		SetTransformCurveKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformCurveKeys_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetTransformCurveKeys_IsValid = SetTransformCurveKeys_FunctionAddress != IntPtr.Zero && SetTransformCurveKeys_CurveId_IsValid && SetTransformCurveKeys_TransformValues_IsValid && SetTransformCurveKeys_TimeKeys_IsValid && SetTransformCurveKeys_bShouldTransact_IsValid && SetTransformCurveKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:SetTransformCurveKeys", SetTransformCurveKeys_IsValid);
		SetTransformCurveKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTransformCurveKey");
		SetTransformCurveKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTransformCurveKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTransformCurveKey_CurveId_PropertyAddress, SetTransformCurveKey_FunctionAddress, "CurveId");
		SetTransformCurveKey_CurveId_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformCurveKey_FunctionAddress, "CurveId");
		SetTransformCurveKey_CurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformCurveKey_FunctionAddress, "CurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformCurveKey_Time_PropertyAddress, SetTransformCurveKey_FunctionAddress, "Time");
		SetTransformCurveKey_Time_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformCurveKey_FunctionAddress, "Time");
		SetTransformCurveKey_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformCurveKey_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformCurveKey_Value_PropertyAddress, SetTransformCurveKey_FunctionAddress, "Value");
		SetTransformCurveKey_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformCurveKey_FunctionAddress, "Value");
		SetTransformCurveKey_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformCurveKey_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformCurveKey_bShouldTransact_PropertyAddress, SetTransformCurveKey_FunctionAddress, "bShouldTransact");
		SetTransformCurveKey_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformCurveKey_FunctionAddress, "bShouldTransact");
		SetTransformCurveKey_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformCurveKey_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTransformCurveKey_ReturnValue_PropertyAddress, SetTransformCurveKey_FunctionAddress, "ReturnValue");
		SetTransformCurveKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTransformCurveKey_FunctionAddress, "ReturnValue");
		SetTransformCurveKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransformCurveKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetTransformCurveKey_IsValid = SetTransformCurveKey_FunctionAddress != IntPtr.Zero && SetTransformCurveKey_CurveId_IsValid && SetTransformCurveKey_Time_IsValid && SetTransformCurveKey_Value_IsValid && SetTransformCurveKey_bShouldTransact_IsValid && SetTransformCurveKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:SetTransformCurveKey", SetTransformCurveKey_IsValid);
		SetPlayLength_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPlayLength");
		SetPlayLength_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlayLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlayLength_Length_PropertyAddress, SetPlayLength_FunctionAddress, "Length");
		SetPlayLength_Length_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayLength_FunctionAddress, "Length");
		SetPlayLength_Length_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayLength_FunctionAddress, "Length", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlayLength_bShouldTransact_PropertyAddress, SetPlayLength_FunctionAddress, "bShouldTransact");
		SetPlayLength_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayLength_FunctionAddress, "bShouldTransact");
		SetPlayLength_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayLength_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		SetPlayLength_IsValid = SetPlayLength_FunctionAddress != IntPtr.Zero && SetPlayLength_Length_IsValid && SetPlayLength_bShouldTransact_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:SetPlayLength", SetPlayLength_IsValid);
		SetModel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetModel");
		SetModel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetModel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetModel_InModel_PropertyAddress, SetModel_FunctionAddress, "InModel");
		SetModel_InModel_Offset = NativeReflectionCached.GetPropertyOffset(SetModel_FunctionAddress, "InModel");
		SetModel_InModel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetModel_FunctionAddress, "InModel", Classes.FObjectProperty);
		SetModel_IsValid = SetModel_FunctionAddress != IntPtr.Zero && SetModel_InModel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:SetModel", SetModel_IsValid);
		SetFrameRate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetFrameRate");
		SetFrameRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFrameRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFrameRate_FrameRate_PropertyAddress, SetFrameRate_FunctionAddress, "FrameRate");
		SetFrameRate_FrameRate_Offset = NativeReflectionCached.GetPropertyOffset(SetFrameRate_FunctionAddress, "FrameRate");
		SetFrameRate_FrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrameRate_FunctionAddress, "FrameRate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFrameRate_bShouldTransact_PropertyAddress, SetFrameRate_FunctionAddress, "bShouldTransact");
		SetFrameRate_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(SetFrameRate_FunctionAddress, "bShouldTransact");
		SetFrameRate_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrameRate_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		SetFrameRate_IsValid = SetFrameRate_FunctionAddress != IntPtr.Zero && SetFrameRate_FrameRate_IsValid && SetFrameRate_bShouldTransact_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:SetFrameRate", SetFrameRate_IsValid);
		SetCurveKeys_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCurveKeys");
		SetCurveKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurveKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurveKeys_CurveId_PropertyAddress, SetCurveKeys_FunctionAddress, "CurveId");
		SetCurveKeys_CurveId_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveKeys_FunctionAddress, "CurveId");
		SetCurveKeys_CurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveKeys_FunctionAddress, "CurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveKeys_CurveKeys_PropertyAddress, SetCurveKeys_FunctionAddress, "CurveKeys");
		SetCurveKeys_CurveKeys_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveKeys_FunctionAddress, "CurveKeys");
		SetCurveKeys_CurveKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveKeys_FunctionAddress, "CurveKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveKeys_bShouldTransact_PropertyAddress, SetCurveKeys_FunctionAddress, "bShouldTransact");
		SetCurveKeys_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveKeys_FunctionAddress, "bShouldTransact");
		SetCurveKeys_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveKeys_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveKeys_ReturnValue_PropertyAddress, SetCurveKeys_FunctionAddress, "ReturnValue");
		SetCurveKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveKeys_FunctionAddress, "ReturnValue");
		SetCurveKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveKeys_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurveKeys_IsValid = SetCurveKeys_FunctionAddress != IntPtr.Zero && SetCurveKeys_CurveId_IsValid && SetCurveKeys_CurveKeys_IsValid && SetCurveKeys_bShouldTransact_IsValid && SetCurveKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:SetCurveKeys", SetCurveKeys_IsValid);
		SetCurveKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCurveKey");
		SetCurveKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurveKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurveKey_CurveId_PropertyAddress, SetCurveKey_FunctionAddress, "CurveId");
		SetCurveKey_CurveId_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveKey_FunctionAddress, "CurveId");
		SetCurveKey_CurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveKey_FunctionAddress, "CurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveKey_Key_PropertyAddress, SetCurveKey_FunctionAddress, "Key");
		SetCurveKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveKey_FunctionAddress, "Key");
		SetCurveKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveKey_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveKey_bShouldTransact_PropertyAddress, SetCurveKey_FunctionAddress, "bShouldTransact");
		SetCurveKey_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveKey_FunctionAddress, "bShouldTransact");
		SetCurveKey_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveKey_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveKey_ReturnValue_PropertyAddress, SetCurveKey_FunctionAddress, "ReturnValue");
		SetCurveKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveKey_FunctionAddress, "ReturnValue");
		SetCurveKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurveKey_IsValid = SetCurveKey_FunctionAddress != IntPtr.Zero && SetCurveKey_CurveId_IsValid && SetCurveKey_Key_IsValid && SetCurveKey_bShouldTransact_IsValid && SetCurveKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:SetCurveKey", SetCurveKey_IsValid);
		SetCurveFlags_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCurveFlags");
		SetCurveFlags_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurveFlags_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurveFlags_CurveId_PropertyAddress, SetCurveFlags_FunctionAddress, "CurveId");
		SetCurveFlags_CurveId_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveFlags_FunctionAddress, "CurveId");
		SetCurveFlags_CurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveFlags_FunctionAddress, "CurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveFlags_Flags_PropertyAddress, SetCurveFlags_FunctionAddress, "Flags");
		SetCurveFlags_Flags_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveFlags_FunctionAddress, "Flags");
		SetCurveFlags_Flags_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveFlags_FunctionAddress, "Flags", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveFlags_bShouldTransact_PropertyAddress, SetCurveFlags_FunctionAddress, "bShouldTransact");
		SetCurveFlags_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveFlags_FunctionAddress, "bShouldTransact");
		SetCurveFlags_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveFlags_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveFlags_ReturnValue_PropertyAddress, SetCurveFlags_FunctionAddress, "ReturnValue");
		SetCurveFlags_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveFlags_FunctionAddress, "ReturnValue");
		SetCurveFlags_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveFlags_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurveFlags_IsValid = SetCurveFlags_FunctionAddress != IntPtr.Zero && SetCurveFlags_CurveId_IsValid && SetCurveFlags_Flags_IsValid && SetCurveFlags_bShouldTransact_IsValid && SetCurveFlags_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:SetCurveFlags", SetCurveFlags_IsValid);
		SetCurveFlag_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCurveFlag");
		SetCurveFlag_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurveFlag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurveFlag_CurveId_PropertyAddress, SetCurveFlag_FunctionAddress, "CurveId");
		SetCurveFlag_CurveId_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveFlag_FunctionAddress, "CurveId");
		SetCurveFlag_CurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveFlag_FunctionAddress, "CurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveFlag_Flag_PropertyAddress, SetCurveFlag_FunctionAddress, "Flag");
		SetCurveFlag_Flag_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveFlag_FunctionAddress, "Flag");
		SetCurveFlag_Flag_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveFlag_FunctionAddress, "Flag", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveFlag_bState_PropertyAddress, SetCurveFlag_FunctionAddress, "bState");
		SetCurveFlag_bState_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveFlag_FunctionAddress, "bState");
		SetCurveFlag_bState_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveFlag_FunctionAddress, "bState", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveFlag_bShouldTransact_PropertyAddress, SetCurveFlag_FunctionAddress, "bShouldTransact");
		SetCurveFlag_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveFlag_FunctionAddress, "bShouldTransact");
		SetCurveFlag_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveFlag_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveFlag_ReturnValue_PropertyAddress, SetCurveFlag_FunctionAddress, "ReturnValue");
		SetCurveFlag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveFlag_FunctionAddress, "ReturnValue");
		SetCurveFlag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveFlag_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurveFlag_IsValid = SetCurveFlag_FunctionAddress != IntPtr.Zero && SetCurveFlag_CurveId_IsValid && SetCurveFlag_Flag_IsValid && SetCurveFlag_bState_IsValid && SetCurveFlag_bShouldTransact_IsValid && SetCurveFlag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:SetCurveFlag", SetCurveFlag_IsValid);
		SetCurveColor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCurveColor");
		SetCurveColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurveColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurveColor_CurveId_PropertyAddress, SetCurveColor_FunctionAddress, "CurveId");
		SetCurveColor_CurveId_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveColor_FunctionAddress, "CurveId");
		SetCurveColor_CurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveColor_FunctionAddress, "CurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveColor_Color_PropertyAddress, SetCurveColor_FunctionAddress, "Color");
		SetCurveColor_Color_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveColor_FunctionAddress, "Color");
		SetCurveColor_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveColor_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveColor_bShouldTransact_PropertyAddress, SetCurveColor_FunctionAddress, "bShouldTransact");
		SetCurveColor_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveColor_FunctionAddress, "bShouldTransact");
		SetCurveColor_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveColor_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveColor_ReturnValue_PropertyAddress, SetCurveColor_FunctionAddress, "ReturnValue");
		SetCurveColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveColor_FunctionAddress, "ReturnValue");
		SetCurveColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveColor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurveColor_IsValid = SetCurveColor_FunctionAddress != IntPtr.Zero && SetCurveColor_CurveId_IsValid && SetCurveColor_Color_IsValid && SetCurveColor_bShouldTransact_IsValid && SetCurveColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:SetCurveColor", SetCurveColor_IsValid);
		SetBoneTrackKeys_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBoneTrackKeys");
		SetBoneTrackKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoneTrackKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoneTrackKeys_BoneName_PropertyAddress, SetBoneTrackKeys_FunctionAddress, "BoneName");
		SetBoneTrackKeys_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneTrackKeys_FunctionAddress, "BoneName");
		SetBoneTrackKeys_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneTrackKeys_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneTrackKeys_PositionalKeys_PropertyAddress, SetBoneTrackKeys_FunctionAddress, "PositionalKeys");
		SetBoneTrackKeys_PositionalKeys_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneTrackKeys_FunctionAddress, "PositionalKeys");
		SetBoneTrackKeys_PositionalKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneTrackKeys_FunctionAddress, "PositionalKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneTrackKeys_RotationalKeys_PropertyAddress, SetBoneTrackKeys_FunctionAddress, "RotationalKeys");
		SetBoneTrackKeys_RotationalKeys_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneTrackKeys_FunctionAddress, "RotationalKeys");
		SetBoneTrackKeys_RotationalKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneTrackKeys_FunctionAddress, "RotationalKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneTrackKeys_ScalingKeys_PropertyAddress, SetBoneTrackKeys_FunctionAddress, "ScalingKeys");
		SetBoneTrackKeys_ScalingKeys_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneTrackKeys_FunctionAddress, "ScalingKeys");
		SetBoneTrackKeys_ScalingKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneTrackKeys_FunctionAddress, "ScalingKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneTrackKeys_bShouldTransact_PropertyAddress, SetBoneTrackKeys_FunctionAddress, "bShouldTransact");
		SetBoneTrackKeys_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneTrackKeys_FunctionAddress, "bShouldTransact");
		SetBoneTrackKeys_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneTrackKeys_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneTrackKeys_ReturnValue_PropertyAddress, SetBoneTrackKeys_FunctionAddress, "ReturnValue");
		SetBoneTrackKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneTrackKeys_FunctionAddress, "ReturnValue");
		SetBoneTrackKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneTrackKeys_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetBoneTrackKeys_IsValid = SetBoneTrackKeys_FunctionAddress != IntPtr.Zero && SetBoneTrackKeys_BoneName_IsValid && SetBoneTrackKeys_PositionalKeys_IsValid && SetBoneTrackKeys_RotationalKeys_IsValid && SetBoneTrackKeys_ScalingKeys_IsValid && SetBoneTrackKeys_bShouldTransact_IsValid && SetBoneTrackKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:SetBoneTrackKeys", SetBoneTrackKeys_IsValid);
		ScaleCurve_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScaleCurve");
		ScaleCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(ScaleCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScaleCurve_CurveId_PropertyAddress, ScaleCurve_FunctionAddress, "CurveId");
		ScaleCurve_CurveId_Offset = NativeReflectionCached.GetPropertyOffset(ScaleCurve_FunctionAddress, "CurveId");
		ScaleCurve_CurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleCurve_FunctionAddress, "CurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleCurve_Origin_PropertyAddress, ScaleCurve_FunctionAddress, "Origin");
		ScaleCurve_Origin_Offset = NativeReflectionCached.GetPropertyOffset(ScaleCurve_FunctionAddress, "Origin");
		ScaleCurve_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleCurve_FunctionAddress, "Origin", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleCurve_Factor_PropertyAddress, ScaleCurve_FunctionAddress, "Factor");
		ScaleCurve_Factor_Offset = NativeReflectionCached.GetPropertyOffset(ScaleCurve_FunctionAddress, "Factor");
		ScaleCurve_Factor_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleCurve_FunctionAddress, "Factor", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleCurve_bShouldTransact_PropertyAddress, ScaleCurve_FunctionAddress, "bShouldTransact");
		ScaleCurve_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(ScaleCurve_FunctionAddress, "bShouldTransact");
		ScaleCurve_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleCurve_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleCurve_ReturnValue_PropertyAddress, ScaleCurve_FunctionAddress, "ReturnValue");
		ScaleCurve_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScaleCurve_FunctionAddress, "ReturnValue");
		ScaleCurve_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScaleCurve_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ScaleCurve_IsValid = ScaleCurve_FunctionAddress != IntPtr.Zero && ScaleCurve_CurveId_IsValid && ScaleCurve_Origin_IsValid && ScaleCurve_Factor_IsValid && ScaleCurve_bShouldTransact_IsValid && ScaleCurve_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:ScaleCurve", ScaleCurve_IsValid);
		ResizePlayLength_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResizePlayLength");
		ResizePlayLength_ParamsSize = NativeReflection.GetFunctionParamsSize(ResizePlayLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResizePlayLength_NewLength_PropertyAddress, ResizePlayLength_FunctionAddress, "NewLength");
		ResizePlayLength_NewLength_Offset = NativeReflectionCached.GetPropertyOffset(ResizePlayLength_FunctionAddress, "NewLength");
		ResizePlayLength_NewLength_IsValid = NativeReflectionCached.ValidatePropertyClass(ResizePlayLength_FunctionAddress, "NewLength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ResizePlayLength_T0_PropertyAddress, ResizePlayLength_FunctionAddress, "T0");
		ResizePlayLength_T0_Offset = NativeReflectionCached.GetPropertyOffset(ResizePlayLength_FunctionAddress, "T0");
		ResizePlayLength_T0_IsValid = NativeReflectionCached.ValidatePropertyClass(ResizePlayLength_FunctionAddress, "T0", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ResizePlayLength_T1_PropertyAddress, ResizePlayLength_FunctionAddress, "T1");
		ResizePlayLength_T1_Offset = NativeReflectionCached.GetPropertyOffset(ResizePlayLength_FunctionAddress, "T1");
		ResizePlayLength_T1_IsValid = NativeReflectionCached.ValidatePropertyClass(ResizePlayLength_FunctionAddress, "T1", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ResizePlayLength_bShouldTransact_PropertyAddress, ResizePlayLength_FunctionAddress, "bShouldTransact");
		ResizePlayLength_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(ResizePlayLength_FunctionAddress, "bShouldTransact");
		ResizePlayLength_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(ResizePlayLength_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		ResizePlayLength_IsValid = ResizePlayLength_FunctionAddress != IntPtr.Zero && ResizePlayLength_NewLength_IsValid && ResizePlayLength_T0_IsValid && ResizePlayLength_T1_IsValid && ResizePlayLength_bShouldTransact_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:ResizePlayLength", ResizePlayLength_IsValid);
		Resize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Resize");
		Resize_ParamsSize = NativeReflection.GetFunctionParamsSize(Resize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Resize_Length_PropertyAddress, Resize_FunctionAddress, "Length");
		Resize_Length_Offset = NativeReflectionCached.GetPropertyOffset(Resize_FunctionAddress, "Length");
		Resize_Length_IsValid = NativeReflectionCached.ValidatePropertyClass(Resize_FunctionAddress, "Length", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Resize_T0_PropertyAddress, Resize_FunctionAddress, "T0");
		Resize_T0_Offset = NativeReflectionCached.GetPropertyOffset(Resize_FunctionAddress, "T0");
		Resize_T0_IsValid = NativeReflectionCached.ValidatePropertyClass(Resize_FunctionAddress, "T0", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Resize_T1_PropertyAddress, Resize_FunctionAddress, "T1");
		Resize_T1_Offset = NativeReflectionCached.GetPropertyOffset(Resize_FunctionAddress, "T1");
		Resize_T1_IsValid = NativeReflectionCached.ValidatePropertyClass(Resize_FunctionAddress, "T1", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Resize_bShouldTransact_PropertyAddress, Resize_FunctionAddress, "bShouldTransact");
		Resize_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(Resize_FunctionAddress, "bShouldTransact");
		Resize_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(Resize_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		Resize_IsValid = Resize_FunctionAddress != IntPtr.Zero && Resize_Length_IsValid && Resize_T0_IsValid && Resize_T1_IsValid && Resize_bShouldTransact_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:Resize", Resize_IsValid);
		RenameCurve_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RenameCurve");
		RenameCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameCurve_CurveToRenameId_PropertyAddress, RenameCurve_FunctionAddress, "CurveToRenameId");
		RenameCurve_CurveToRenameId_Offset = NativeReflectionCached.GetPropertyOffset(RenameCurve_FunctionAddress, "CurveToRenameId");
		RenameCurve_CurveToRenameId_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameCurve_FunctionAddress, "CurveToRenameId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameCurve_NewCurveId_PropertyAddress, RenameCurve_FunctionAddress, "NewCurveId");
		RenameCurve_NewCurveId_Offset = NativeReflectionCached.GetPropertyOffset(RenameCurve_FunctionAddress, "NewCurveId");
		RenameCurve_NewCurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameCurve_FunctionAddress, "NewCurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameCurve_bShouldTransact_PropertyAddress, RenameCurve_FunctionAddress, "bShouldTransact");
		RenameCurve_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(RenameCurve_FunctionAddress, "bShouldTransact");
		RenameCurve_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameCurve_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameCurve_ReturnValue_PropertyAddress, RenameCurve_FunctionAddress, "ReturnValue");
		RenameCurve_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameCurve_FunctionAddress, "ReturnValue");
		RenameCurve_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameCurve_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenameCurve_IsValid = RenameCurve_FunctionAddress != IntPtr.Zero && RenameCurve_CurveToRenameId_IsValid && RenameCurve_NewCurveId_IsValid && RenameCurve_bShouldTransact_IsValid && RenameCurve_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:RenameCurve", RenameCurve_IsValid);
		RemoveTransformCurveKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveTransformCurveKey");
		RemoveTransformCurveKey_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveTransformCurveKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveTransformCurveKey_CurveId_PropertyAddress, RemoveTransformCurveKey_FunctionAddress, "CurveId");
		RemoveTransformCurveKey_CurveId_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTransformCurveKey_FunctionAddress, "CurveId");
		RemoveTransformCurveKey_CurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTransformCurveKey_FunctionAddress, "CurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveTransformCurveKey_Time_PropertyAddress, RemoveTransformCurveKey_FunctionAddress, "Time");
		RemoveTransformCurveKey_Time_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTransformCurveKey_FunctionAddress, "Time");
		RemoveTransformCurveKey_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTransformCurveKey_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveTransformCurveKey_bShouldTransact_PropertyAddress, RemoveTransformCurveKey_FunctionAddress, "bShouldTransact");
		RemoveTransformCurveKey_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTransformCurveKey_FunctionAddress, "bShouldTransact");
		RemoveTransformCurveKey_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTransformCurveKey_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveTransformCurveKey_ReturnValue_PropertyAddress, RemoveTransformCurveKey_FunctionAddress, "ReturnValue");
		RemoveTransformCurveKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTransformCurveKey_FunctionAddress, "ReturnValue");
		RemoveTransformCurveKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTransformCurveKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveTransformCurveKey_IsValid = RemoveTransformCurveKey_FunctionAddress != IntPtr.Zero && RemoveTransformCurveKey_CurveId_IsValid && RemoveTransformCurveKey_Time_IsValid && RemoveTransformCurveKey_bShouldTransact_IsValid && RemoveTransformCurveKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:RemoveTransformCurveKey", RemoveTransformCurveKey_IsValid);
		RemoveCurveKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveCurveKey");
		RemoveCurveKey_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveCurveKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveCurveKey_CurveId_PropertyAddress, RemoveCurveKey_FunctionAddress, "CurveId");
		RemoveCurveKey_CurveId_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCurveKey_FunctionAddress, "CurveId");
		RemoveCurveKey_CurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCurveKey_FunctionAddress, "CurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveCurveKey_Time_PropertyAddress, RemoveCurveKey_FunctionAddress, "Time");
		RemoveCurveKey_Time_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCurveKey_FunctionAddress, "Time");
		RemoveCurveKey_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCurveKey_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveCurveKey_bShouldTransact_PropertyAddress, RemoveCurveKey_FunctionAddress, "bShouldTransact");
		RemoveCurveKey_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCurveKey_FunctionAddress, "bShouldTransact");
		RemoveCurveKey_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCurveKey_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveCurveKey_ReturnValue_PropertyAddress, RemoveCurveKey_FunctionAddress, "ReturnValue");
		RemoveCurveKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCurveKey_FunctionAddress, "ReturnValue");
		RemoveCurveKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCurveKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveCurveKey_IsValid = RemoveCurveKey_FunctionAddress != IntPtr.Zero && RemoveCurveKey_CurveId_IsValid && RemoveCurveKey_Time_IsValid && RemoveCurveKey_bShouldTransact_IsValid && RemoveCurveKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:RemoveCurveKey", RemoveCurveKey_IsValid);
		RemoveCurve_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveCurve");
		RemoveCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveCurve_CurveId_PropertyAddress, RemoveCurve_FunctionAddress, "CurveId");
		RemoveCurve_CurveId_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCurve_FunctionAddress, "CurveId");
		RemoveCurve_CurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCurve_FunctionAddress, "CurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveCurve_bShouldTransact_PropertyAddress, RemoveCurve_FunctionAddress, "bShouldTransact");
		RemoveCurve_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCurve_FunctionAddress, "bShouldTransact");
		RemoveCurve_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCurve_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveCurve_ReturnValue_PropertyAddress, RemoveCurve_FunctionAddress, "ReturnValue");
		RemoveCurve_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCurve_FunctionAddress, "ReturnValue");
		RemoveCurve_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCurve_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveCurve_IsValid = RemoveCurve_FunctionAddress != IntPtr.Zero && RemoveCurve_CurveId_IsValid && RemoveCurve_bShouldTransact_IsValid && RemoveCurve_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:RemoveCurve", RemoveCurve_IsValid);
		RemoveBoneTrack_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveBoneTrack");
		RemoveBoneTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveBoneTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveBoneTrack_BoneName_PropertyAddress, RemoveBoneTrack_FunctionAddress, "BoneName");
		RemoveBoneTrack_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBoneTrack_FunctionAddress, "BoneName");
		RemoveBoneTrack_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBoneTrack_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveBoneTrack_bShouldTransact_PropertyAddress, RemoveBoneTrack_FunctionAddress, "bShouldTransact");
		RemoveBoneTrack_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBoneTrack_FunctionAddress, "bShouldTransact");
		RemoveBoneTrack_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBoneTrack_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveBoneTrack_ReturnValue_PropertyAddress, RemoveBoneTrack_FunctionAddress, "ReturnValue");
		RemoveBoneTrack_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBoneTrack_FunctionAddress, "ReturnValue");
		RemoveBoneTrack_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBoneTrack_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveBoneTrack_IsValid = RemoveBoneTrack_FunctionAddress != IntPtr.Zero && RemoveBoneTrack_BoneName_IsValid && RemoveBoneTrack_bShouldTransact_IsValid && RemoveBoneTrack_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:RemoveBoneTrack", RemoveBoneTrack_IsValid);
		RemoveAttributeKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveAttributeKey");
		RemoveAttributeKey_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAttributeKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAttributeKey_AttributeIdentifier_PropertyAddress, RemoveAttributeKey_FunctionAddress, "AttributeIdentifier");
		RemoveAttributeKey_AttributeIdentifier_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAttributeKey_FunctionAddress, "AttributeIdentifier");
		RemoveAttributeKey_AttributeIdentifier_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAttributeKey_FunctionAddress, "AttributeIdentifier", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAttributeKey_Time_PropertyAddress, RemoveAttributeKey_FunctionAddress, "Time");
		RemoveAttributeKey_Time_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAttributeKey_FunctionAddress, "Time");
		RemoveAttributeKey_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAttributeKey_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAttributeKey_bShouldTransact_PropertyAddress, RemoveAttributeKey_FunctionAddress, "bShouldTransact");
		RemoveAttributeKey_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAttributeKey_FunctionAddress, "bShouldTransact");
		RemoveAttributeKey_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAttributeKey_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAttributeKey_ReturnValue_PropertyAddress, RemoveAttributeKey_FunctionAddress, "ReturnValue");
		RemoveAttributeKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAttributeKey_FunctionAddress, "ReturnValue");
		RemoveAttributeKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAttributeKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveAttributeKey_IsValid = RemoveAttributeKey_FunctionAddress != IntPtr.Zero && RemoveAttributeKey_AttributeIdentifier_IsValid && RemoveAttributeKey_Time_IsValid && RemoveAttributeKey_bShouldTransact_IsValid && RemoveAttributeKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:RemoveAttributeKey", RemoveAttributeKey_IsValid);
		RemoveAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveAttribute");
		RemoveAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAttribute_AttributeIdentifier_PropertyAddress, RemoveAttribute_FunctionAddress, "AttributeIdentifier");
		RemoveAttribute_AttributeIdentifier_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAttribute_FunctionAddress, "AttributeIdentifier");
		RemoveAttribute_AttributeIdentifier_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAttribute_FunctionAddress, "AttributeIdentifier", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAttribute_bShouldTransact_PropertyAddress, RemoveAttribute_FunctionAddress, "bShouldTransact");
		RemoveAttribute_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAttribute_FunctionAddress, "bShouldTransact");
		RemoveAttribute_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAttribute_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAttribute_ReturnValue_PropertyAddress, RemoveAttribute_FunctionAddress, "ReturnValue");
		RemoveAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAttribute_FunctionAddress, "ReturnValue");
		RemoveAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveAttribute_IsValid = RemoveAttribute_FunctionAddress != IntPtr.Zero && RemoveAttribute_AttributeIdentifier_IsValid && RemoveAttribute_bShouldTransact_IsValid && RemoveAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:RemoveAttribute", RemoveAttribute_IsValid);
		RemoveAllCurvesOfType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveAllCurvesOfType");
		RemoveAllCurvesOfType_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllCurvesOfType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllCurvesOfType_SupportedCurveType_PropertyAddress, RemoveAllCurvesOfType_FunctionAddress, "SupportedCurveType");
		RemoveAllCurvesOfType_SupportedCurveType_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllCurvesOfType_FunctionAddress, "SupportedCurveType");
		RemoveAllCurvesOfType_SupportedCurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllCurvesOfType_FunctionAddress, "SupportedCurveType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllCurvesOfType_bShouldTransact_PropertyAddress, RemoveAllCurvesOfType_FunctionAddress, "bShouldTransact");
		RemoveAllCurvesOfType_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllCurvesOfType_FunctionAddress, "bShouldTransact");
		RemoveAllCurvesOfType_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllCurvesOfType_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		RemoveAllCurvesOfType_IsValid = RemoveAllCurvesOfType_FunctionAddress != IntPtr.Zero && RemoveAllCurvesOfType_SupportedCurveType_IsValid && RemoveAllCurvesOfType_bShouldTransact_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:RemoveAllCurvesOfType", RemoveAllCurvesOfType_IsValid);
		RemoveAllBoneTracks_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveAllBoneTracks");
		RemoveAllBoneTracks_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllBoneTracks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllBoneTracks_bShouldTransact_PropertyAddress, RemoveAllBoneTracks_FunctionAddress, "bShouldTransact");
		RemoveAllBoneTracks_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllBoneTracks_FunctionAddress, "bShouldTransact");
		RemoveAllBoneTracks_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllBoneTracks_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		RemoveAllBoneTracks_IsValid = RemoveAllBoneTracks_FunctionAddress != IntPtr.Zero && RemoveAllBoneTracks_bShouldTransact_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:RemoveAllBoneTracks", RemoveAllBoneTracks_IsValid);
		RemoveAllAttributesForBone_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveAllAttributesForBone");
		RemoveAllAttributesForBone_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllAttributesForBone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllAttributesForBone_BoneName_PropertyAddress, RemoveAllAttributesForBone_FunctionAddress, "BoneName");
		RemoveAllAttributesForBone_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllAttributesForBone_FunctionAddress, "BoneName");
		RemoveAllAttributesForBone_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllAttributesForBone_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllAttributesForBone_bShouldTransact_PropertyAddress, RemoveAllAttributesForBone_FunctionAddress, "bShouldTransact");
		RemoveAllAttributesForBone_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllAttributesForBone_FunctionAddress, "bShouldTransact");
		RemoveAllAttributesForBone_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllAttributesForBone_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllAttributesForBone_ReturnValue_PropertyAddress, RemoveAllAttributesForBone_FunctionAddress, "ReturnValue");
		RemoveAllAttributesForBone_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllAttributesForBone_FunctionAddress, "ReturnValue");
		RemoveAllAttributesForBone_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllAttributesForBone_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		RemoveAllAttributesForBone_IsValid = RemoveAllAttributesForBone_FunctionAddress != IntPtr.Zero && RemoveAllAttributesForBone_BoneName_IsValid && RemoveAllAttributesForBone_bShouldTransact_IsValid && RemoveAllAttributesForBone_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:RemoveAllAttributesForBone", RemoveAllAttributesForBone_IsValid);
		RemoveAllAttributes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveAllAttributes");
		RemoveAllAttributes_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllAttributes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllAttributes_bShouldTransact_PropertyAddress, RemoveAllAttributes_FunctionAddress, "bShouldTransact");
		RemoveAllAttributes_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllAttributes_FunctionAddress, "bShouldTransact");
		RemoveAllAttributes_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllAttributes_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllAttributes_ReturnValue_PropertyAddress, RemoveAllAttributes_FunctionAddress, "ReturnValue");
		RemoveAllAttributes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllAttributes_FunctionAddress, "ReturnValue");
		RemoveAllAttributes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllAttributes_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		RemoveAllAttributes_IsValid = RemoveAllAttributes_FunctionAddress != IntPtr.Zero && RemoveAllAttributes_bShouldTransact_IsValid && RemoveAllAttributes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:RemoveAllAttributes", RemoveAllAttributes_IsValid);
		OpenBracket_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OpenBracket");
		OpenBracket_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenBracket_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenBracket_InTitle_PropertyAddress, OpenBracket_FunctionAddress, "InTitle");
		OpenBracket_InTitle_Offset = NativeReflectionCached.GetPropertyOffset(OpenBracket_FunctionAddress, "InTitle");
		OpenBracket_InTitle_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenBracket_FunctionAddress, "InTitle", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenBracket_bShouldTransact_PropertyAddress, OpenBracket_FunctionAddress, "bShouldTransact");
		OpenBracket_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(OpenBracket_FunctionAddress, "bShouldTransact");
		OpenBracket_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenBracket_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		OpenBracket_IsValid = OpenBracket_FunctionAddress != IntPtr.Zero && OpenBracket_InTitle_IsValid && OpenBracket_bShouldTransact_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:OpenBracket", OpenBracket_IsValid);
		InsertBoneTrack_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InsertBoneTrack");
		InsertBoneTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(InsertBoneTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InsertBoneTrack_BoneName_PropertyAddress, InsertBoneTrack_FunctionAddress, "BoneName");
		InsertBoneTrack_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(InsertBoneTrack_FunctionAddress, "BoneName");
		InsertBoneTrack_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertBoneTrack_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertBoneTrack_DesiredIndex_PropertyAddress, InsertBoneTrack_FunctionAddress, "DesiredIndex");
		InsertBoneTrack_DesiredIndex_Offset = NativeReflectionCached.GetPropertyOffset(InsertBoneTrack_FunctionAddress, "DesiredIndex");
		InsertBoneTrack_DesiredIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertBoneTrack_FunctionAddress, "DesiredIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertBoneTrack_bShouldTransact_PropertyAddress, InsertBoneTrack_FunctionAddress, "bShouldTransact");
		InsertBoneTrack_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(InsertBoneTrack_FunctionAddress, "bShouldTransact");
		InsertBoneTrack_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertBoneTrack_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertBoneTrack_ReturnValue_PropertyAddress, InsertBoneTrack_FunctionAddress, "ReturnValue");
		InsertBoneTrack_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InsertBoneTrack_FunctionAddress, "ReturnValue");
		InsertBoneTrack_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertBoneTrack_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		InsertBoneTrack_IsValid = InsertBoneTrack_FunctionAddress != IntPtr.Zero && InsertBoneTrack_BoneName_IsValid && InsertBoneTrack_DesiredIndex_IsValid && InsertBoneTrack_bShouldTransact_IsValid && InsertBoneTrack_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:InsertBoneTrack", InsertBoneTrack_IsValid);
		GetModel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetModel");
		GetModel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetModel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetModel_ReturnValue_PropertyAddress, GetModel_FunctionAddress, "ReturnValue");
		GetModel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetModel_FunctionAddress, "ReturnValue");
		GetModel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetModel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetModel_IsValid = GetModel_FunctionAddress != IntPtr.Zero && GetModel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:GetModel", GetModel_IsValid);
		FindOrAddCurveNamesOnSkeleton_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindOrAddCurveNamesOnSkeleton");
		FindOrAddCurveNamesOnSkeleton_ParamsSize = NativeReflection.GetFunctionParamsSize(FindOrAddCurveNamesOnSkeleton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindOrAddCurveNamesOnSkeleton_Skeleton_PropertyAddress, FindOrAddCurveNamesOnSkeleton_FunctionAddress, "Skeleton");
		FindOrAddCurveNamesOnSkeleton_Skeleton_Offset = NativeReflectionCached.GetPropertyOffset(FindOrAddCurveNamesOnSkeleton_FunctionAddress, "Skeleton");
		FindOrAddCurveNamesOnSkeleton_Skeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOrAddCurveNamesOnSkeleton_FunctionAddress, "Skeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindOrAddCurveNamesOnSkeleton_SupportedCurveType_PropertyAddress, FindOrAddCurveNamesOnSkeleton_FunctionAddress, "SupportedCurveType");
		FindOrAddCurveNamesOnSkeleton_SupportedCurveType_Offset = NativeReflectionCached.GetPropertyOffset(FindOrAddCurveNamesOnSkeleton_FunctionAddress, "SupportedCurveType");
		FindOrAddCurveNamesOnSkeleton_SupportedCurveType_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOrAddCurveNamesOnSkeleton_FunctionAddress, "SupportedCurveType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FindOrAddCurveNamesOnSkeleton_bShouldTransact_PropertyAddress, FindOrAddCurveNamesOnSkeleton_FunctionAddress, "bShouldTransact");
		FindOrAddCurveNamesOnSkeleton_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(FindOrAddCurveNamesOnSkeleton_FunctionAddress, "bShouldTransact");
		FindOrAddCurveNamesOnSkeleton_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOrAddCurveNamesOnSkeleton_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		FindOrAddCurveNamesOnSkeleton_IsValid = FindOrAddCurveNamesOnSkeleton_FunctionAddress != IntPtr.Zero && FindOrAddCurveNamesOnSkeleton_Skeleton_IsValid && FindOrAddCurveNamesOnSkeleton_SupportedCurveType_IsValid && FindOrAddCurveNamesOnSkeleton_bShouldTransact_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:FindOrAddCurveNamesOnSkeleton", FindOrAddCurveNamesOnSkeleton_IsValid);
		DuplicateCurve_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DuplicateCurve");
		DuplicateCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateCurve_CopyCurveId_PropertyAddress, DuplicateCurve_FunctionAddress, "CopyCurveId");
		DuplicateCurve_CopyCurveId_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateCurve_FunctionAddress, "CopyCurveId");
		DuplicateCurve_CopyCurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateCurve_FunctionAddress, "CopyCurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateCurve_NewCurveId_PropertyAddress, DuplicateCurve_FunctionAddress, "NewCurveId");
		DuplicateCurve_NewCurveId_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateCurve_FunctionAddress, "NewCurveId");
		DuplicateCurve_NewCurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateCurve_FunctionAddress, "NewCurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateCurve_bShouldTransact_PropertyAddress, DuplicateCurve_FunctionAddress, "bShouldTransact");
		DuplicateCurve_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateCurve_FunctionAddress, "bShouldTransact");
		DuplicateCurve_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateCurve_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateCurve_ReturnValue_PropertyAddress, DuplicateCurve_FunctionAddress, "ReturnValue");
		DuplicateCurve_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateCurve_FunctionAddress, "ReturnValue");
		DuplicateCurve_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateCurve_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DuplicateCurve_IsValid = DuplicateCurve_FunctionAddress != IntPtr.Zero && DuplicateCurve_CopyCurveId_IsValid && DuplicateCurve_NewCurveId_IsValid && DuplicateCurve_bShouldTransact_IsValid && DuplicateCurve_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:DuplicateCurve", DuplicateCurve_IsValid);
		DuplicateAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DuplicateAttribute");
		DuplicateAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAttribute_AttributeIdentifier_PropertyAddress, DuplicateAttribute_FunctionAddress, "AttributeIdentifier");
		DuplicateAttribute_AttributeIdentifier_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAttribute_FunctionAddress, "AttributeIdentifier");
		DuplicateAttribute_AttributeIdentifier_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAttribute_FunctionAddress, "AttributeIdentifier", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAttribute_NewAttributeIdentifier_PropertyAddress, DuplicateAttribute_FunctionAddress, "NewAttributeIdentifier");
		DuplicateAttribute_NewAttributeIdentifier_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAttribute_FunctionAddress, "NewAttributeIdentifier");
		DuplicateAttribute_NewAttributeIdentifier_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAttribute_FunctionAddress, "NewAttributeIdentifier", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAttribute_bShouldTransact_PropertyAddress, DuplicateAttribute_FunctionAddress, "bShouldTransact");
		DuplicateAttribute_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAttribute_FunctionAddress, "bShouldTransact");
		DuplicateAttribute_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAttribute_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAttribute_ReturnValue_PropertyAddress, DuplicateAttribute_FunctionAddress, "ReturnValue");
		DuplicateAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAttribute_FunctionAddress, "ReturnValue");
		DuplicateAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DuplicateAttribute_IsValid = DuplicateAttribute_FunctionAddress != IntPtr.Zero && DuplicateAttribute_AttributeIdentifier_IsValid && DuplicateAttribute_NewAttributeIdentifier_IsValid && DuplicateAttribute_bShouldTransact_IsValid && DuplicateAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:DuplicateAttribute", DuplicateAttribute_IsValid);
		CloseBracket_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CloseBracket");
		CloseBracket_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseBracket_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CloseBracket_bShouldTransact_PropertyAddress, CloseBracket_FunctionAddress, "bShouldTransact");
		CloseBracket_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(CloseBracket_FunctionAddress, "bShouldTransact");
		CloseBracket_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseBracket_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		CloseBracket_IsValid = CloseBracket_FunctionAddress != IntPtr.Zero && CloseBracket_bShouldTransact_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:CloseBracket", CloseBracket_IsValid);
		AddCurve_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddCurve");
		AddCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(AddCurve_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_CurveId_PropertyAddress, AddCurve_FunctionAddress, "CurveId");
		AddCurve_CurveId_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "CurveId");
		AddCurve_CurveId_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "CurveId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_CurveFlags_PropertyAddress, AddCurve_FunctionAddress, "CurveFlags");
		AddCurve_CurveFlags_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "CurveFlags");
		AddCurve_CurveFlags_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "CurveFlags", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_bShouldTransact_PropertyAddress, AddCurve_FunctionAddress, "bShouldTransact");
		AddCurve_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "bShouldTransact");
		AddCurve_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCurve_ReturnValue_PropertyAddress, AddCurve_FunctionAddress, "ReturnValue");
		AddCurve_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddCurve_FunctionAddress, "ReturnValue");
		AddCurve_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCurve_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddCurve_IsValid = AddCurve_FunctionAddress != IntPtr.Zero && AddCurve_CurveId_IsValid && AddCurve_CurveFlags_IsValid && AddCurve_bShouldTransact_IsValid && AddCurve_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:AddCurve", AddCurve_IsValid);
		AddBoneTrack_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddBoneTrack");
		AddBoneTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBoneTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBoneTrack_BoneName_PropertyAddress, AddBoneTrack_FunctionAddress, "BoneName");
		AddBoneTrack_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneTrack_FunctionAddress, "BoneName");
		AddBoneTrack_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneTrack_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoneTrack_bShouldTransact_PropertyAddress, AddBoneTrack_FunctionAddress, "bShouldTransact");
		AddBoneTrack_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneTrack_FunctionAddress, "bShouldTransact");
		AddBoneTrack_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneTrack_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBoneTrack_ReturnValue_PropertyAddress, AddBoneTrack_FunctionAddress, "ReturnValue");
		AddBoneTrack_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddBoneTrack_FunctionAddress, "ReturnValue");
		AddBoneTrack_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBoneTrack_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		AddBoneTrack_IsValid = AddBoneTrack_FunctionAddress != IntPtr.Zero && AddBoneTrack_BoneName_IsValid && AddBoneTrack_bShouldTransact_IsValid && AddBoneTrack_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:AddBoneTrack", AddBoneTrack_IsValid);
		AddAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddAttribute");
		AddAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAttribute_AttributeIdentifier_PropertyAddress, AddAttribute_FunctionAddress, "AttributeIdentifier");
		AddAttribute_AttributeIdentifier_Offset = NativeReflectionCached.GetPropertyOffset(AddAttribute_FunctionAddress, "AttributeIdentifier");
		AddAttribute_AttributeIdentifier_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAttribute_FunctionAddress, "AttributeIdentifier", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAttribute_bShouldTransact_PropertyAddress, AddAttribute_FunctionAddress, "bShouldTransact");
		AddAttribute_bShouldTransact_Offset = NativeReflectionCached.GetPropertyOffset(AddAttribute_FunctionAddress, "bShouldTransact");
		AddAttribute_bShouldTransact_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAttribute_FunctionAddress, "bShouldTransact", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAttribute_ReturnValue_PropertyAddress, AddAttribute_FunctionAddress, "ReturnValue");
		AddAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddAttribute_FunctionAddress, "ReturnValue");
		AddAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddAttribute_IsValid = AddAttribute_FunctionAddress != IntPtr.Zero && AddAttribute_AttributeIdentifier_IsValid && AddAttribute_bShouldTransact_IsValid && AddAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimationDataController:AddAttribute", AddAttribute_IsValid);
	}
}
