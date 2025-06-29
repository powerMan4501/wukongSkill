using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MM.AnimationAnalyzer", "MM", UnrealModuleType.GamePlugin)]
public class UAnimationAnalyzer : UObject
{
	private static bool LastMatchedAnimIndex_IsValid;

	private static int LastMatchedAnimIndex_Offset;

	private static bool ControllerInputReactionSpeed_IsValid;

	private static int ControllerInputReactionSpeed_Offset;

	private static bool ControllerRotateReactionSpeed_IsValid;

	private static int ControllerRotateReactionSpeed_Offset;

	private static bool MMKDTree_IsValid;

	private static FFieldAddress MMKDTree_PropertyAddress;

	private static int MMKDTree_Offset;

	private TArrayReadOnlyMarshaler<FMMKDTreeNode> MMKDTree_MarshalerCached;

	private static bool AnimationReferences_IsValid;

	private static FFieldAddress AnimationReferences_PropertyAddress;

	private static int AnimationReferences_Offset;

	private TArrayReadWriteMarshaler<FMotionMatchingMath> AnimationReferences_MarshalerCached;

	private static bool ReferencedJoints_IsValid;

	private static FFieldAddress ReferencedJoints_PropertyAddress;

	private static int ReferencedJoints_Offset;

	private TArrayReadOnlyMarshaler<FName> ReferencedJoints_MarshalerCached;

	private static bool JointWeights_IsValid;

	private static FFieldAddress JointWeights_PropertyAddress;

	private static int JointWeights_Offset;

	private TMapReadOnlyMarshaler<int, float> JointWeights_MarshalerCached;

	private static bool AnimationsInMemory_IsValid;

	private static FFieldAddress AnimationsInMemory_PropertyAddress;

	private static int AnimationsInMemory_Offset;

	private TArrayReadWriteMarshaler<UAnimSequence> AnimationsInMemory_MarshalerCached;

	private static bool AnimationSeqSoftDatas_IsValid;

	private static FFieldAddress AnimationSeqSoftDatas_PropertyAddress;

	private static int AnimationSeqSoftDatas_Offset;

	private TArrayReadWriteMarshaler<FMotionMatchingAnimSeqdata> AnimationSeqSoftDatas_MarshalerCached;

	private static bool UsingAssetSoftRef_IsValid;

	private static FFieldAddress UsingAssetSoftRef_PropertyAddress;

	private static int UsingAssetSoftRef_Offset;

	private static bool TryInitFromAA_IsValid;

	private static IntPtr TryInitFromAA_FunctionAddress;

	private static int TryInitFromAA_ParamsSize;

	private static bool TryInitFromAA_OrgAA_IsValid;

	private static FFieldAddress TryInitFromAA_OrgAA_PropertyAddress;

	private static int TryInitFromAA_OrgAA_Offset;

	private static bool TryInitFromAA_ReturnValue_IsValid;

	private static FFieldAddress TryInitFromAA_ReturnValue_PropertyAddress;

	private static int TryInitFromAA_ReturnValue_Offset;

	private static bool StructureForAnimationCalculations_IsValid;

	private static IntPtr StructureForAnimationCalculations_FunctionAddress;

	private static int StructureForAnimationCalculations_ParamsSize;

	private static bool StructureForAnimationCalculations_ControllerInputReactionSpeedCustom_IsValid;

	private static FFieldAddress StructureForAnimationCalculations_ControllerInputReactionSpeedCustom_PropertyAddress;

	private static int StructureForAnimationCalculations_ControllerInputReactionSpeedCustom_Offset;

	private static bool StructureForAnimationCalculations_ControllerRotateReactionSpeedCustom_IsValid;

	private static FFieldAddress StructureForAnimationCalculations_ControllerRotateReactionSpeedCustom_PropertyAddress;

	private static int StructureForAnimationCalculations_ControllerRotateReactionSpeedCustom_Offset;

	private static bool StructureForAnimationCalculations_VelocityStrength_IsValid;

	private static FFieldAddress StructureForAnimationCalculations_VelocityStrength_PropertyAddress;

	private static int StructureForAnimationCalculations_VelocityStrength_Offset;

	private static bool StructureForAnimationCalculations_AnimationMatchPower_IsValid;

	private static FFieldAddress StructureForAnimationCalculations_AnimationMatchPower_PropertyAddress;

	private static int StructureForAnimationCalculations_AnimationMatchPower_Offset;

	private static bool StructureForAnimationCalculations_InputDirection_IsValid;

	private static FFieldAddress StructureForAnimationCalculations_InputDirection_PropertyAddress;

	private static int StructureForAnimationCalculations_InputDirection_Offset;

	private static bool StructureForAnimationCalculations_AllAnimationReferences_IsValid;

	private static FFieldAddress StructureForAnimationCalculations_AllAnimationReferences_PropertyAddress;

	private static int StructureForAnimationCalculations_AllAnimationReferences_Offset;

	private static bool StructureForAnimationCalculations_PresentVel_IsValid;

	private static FFieldAddress StructureForAnimationCalculations_PresentVel_PropertyAddress;

	private static int StructureForAnimationCalculations_PresentVel_Offset;

	private static bool StructureForAnimationCalculations_BlendTime_IsValid;

	private static FFieldAddress StructureForAnimationCalculations_BlendTime_PropertyAddress;

	private static int StructureForAnimationCalculations_BlendTime_Offset;

	private static bool StructureForAnimationCalculations_CalculatedResult_IsValid;

	private static FFieldAddress StructureForAnimationCalculations_CalculatedResult_PropertyAddress;

	private static int StructureForAnimationCalculations_CalculatedResult_Offset;

	private static bool StructureForAnimationCalculations_AnimCostData_IsValid;

	private static FFieldAddress StructureForAnimationCalculations_AnimCostData_PropertyAddress;

	private static int StructureForAnimationCalculations_AnimCostData_Offset;

	private static bool StructureForAnimationCalculations_ReturnValue_IsValid;

	private static FFieldAddress StructureForAnimationCalculations_ReturnValue_PropertyAddress;

	private static int StructureForAnimationCalculations_ReturnValue_Offset;

	private static bool SetUseLMAnim_IsValid;

	private static IntPtr SetUseLMAnim_FunctionAddress;

	private static int SetUseLMAnim_ParamsSize;

	private static bool SetUseLMAnim_bUse_IsValid;

	private static FFieldAddress SetUseLMAnim_bUse_PropertyAddress;

	private static int SetUseLMAnim_bUse_Offset;

	private static bool RequireAnimationsLoadAtDesiredReferences_IsValid;

	private IntPtr RequireAnimationsLoadAtDesiredReferences_InstanceFunctionAddress;

	private static IntPtr RequireAnimationsLoadAtDesiredReferences_FunctionAddress;

	private static int RequireAnimationsLoadAtDesiredReferences_ParamsSize;

	private static bool RequireAnimationsLoadAtDesiredReferences_Ref_IsValid;

	private static FFieldAddress RequireAnimationsLoadAtDesiredReferences_Ref_PropertyAddress;

	private static int RequireAnimationsLoadAtDesiredReferences_Ref_Offset;

	private static bool RequireAnimationsLoadAtDesiredReferences_bLoadAll_IsValid;

	private static FFieldAddress RequireAnimationsLoadAtDesiredReferences_bLoadAll_PropertyAddress;

	private static int RequireAnimationsLoadAtDesiredReferences_bLoadAll_Offset;

	private static bool RequireAnimationsLoadAtDesiredReferences_AnimInst_IsValid;

	private static FFieldAddress RequireAnimationsLoadAtDesiredReferences_AnimInst_PropertyAddress;

	private static int RequireAnimationsLoadAtDesiredReferences_AnimInst_Offset;

	private static bool RequireAnimationsLoadAtDesiredReferences_ReturnValue_IsValid;

	private static FFieldAddress RequireAnimationsLoadAtDesiredReferences_ReturnValue_PropertyAddress;

	private static int RequireAnimationsLoadAtDesiredReferences_ReturnValue_Offset;

	private static bool RemoveAnimationReference_IsValid;

	private static IntPtr RemoveAnimationReference_FunctionAddress;

	private static int RemoveAnimationReference_ParamsSize;

	private static bool RemoveAnimationReference_CurrentAnimationRef_IsValid;

	private static FFieldAddress RemoveAnimationReference_CurrentAnimationRef_PropertyAddress;

	private static int RemoveAnimationReference_CurrentAnimationRef_Offset;

	private static bool OnAnimationAssetLoadStatChange_IsValid;

	private static IntPtr OnAnimationAssetLoadStatChange_FunctionAddress;

	private static int OnAnimationAssetLoadStatChange_ParamsSize;

	private static bool OnAnimationAssetLoadStatChange_Ref_IsValid;

	private static FFieldAddress OnAnimationAssetLoadStatChange_Ref_PropertyAddress;

	private static int OnAnimationAssetLoadStatChange_Ref_Offset;

	private static bool OnAnimationAssetLoadStatChange_Stat_IsValid;

	private static FFieldAddress OnAnimationAssetLoadStatChange_Stat_PropertyAddress;

	private static int OnAnimationAssetLoadStatChange_Stat_Offset;

	private static bool OnAnimationAssetLoadStatChange_Anim_IsValid;

	private static FFieldAddress OnAnimationAssetLoadStatChange_Anim_PropertyAddress;

	private static int OnAnimationAssetLoadStatChange_Anim_Offset;

	private static bool NewAnimationReference_IsValid;

	private static IntPtr NewAnimationReference_FunctionAddress;

	private static int NewAnimationReference_ParamsSize;

	private static bool NewAnimationReference_ProvidedAnimationsByUser_IsValid;

	private static FFieldAddress NewAnimationReference_ProvidedAnimationsByUser_PropertyAddress;

	private static int NewAnimationReference_ProvidedAnimationsByUser_Offset;

	private static bool MMAnimationSeqUsingNotify_Inner_IsValid;

	private IntPtr MMAnimationSeqUsingNotify_Inner_InstanceFunctionAddress;

	private static IntPtr MMAnimationSeqUsingNotify_Inner_FunctionAddress;

	private static int MMAnimationSeqUsingNotify_Inner_ParamsSize;

	private static bool MMAnimationSeqUsingNotify_Inner_Ref_IsValid;

	private static FFieldAddress MMAnimationSeqUsingNotify_Inner_Ref_PropertyAddress;

	private static int MMAnimationSeqUsingNotify_Inner_Ref_Offset;

	private static bool MMAnimationSeqUsingNotify_Inner_owner_IsValid;

	private static FFieldAddress MMAnimationSeqUsingNotify_Inner_owner_PropertyAddress;

	private static int MMAnimationSeqUsingNotify_Inner_owner_Offset;

	private static bool MatchAnimationByKDTree_IsValid;

	private static IntPtr MatchAnimationByKDTree_FunctionAddress;

	private static int MatchAnimationByKDTree_ParamsSize;

	private static bool MatchAnimationByKDTree_VelocityStrength_IsValid;

	private static FFieldAddress MatchAnimationByKDTree_VelocityStrength_PropertyAddress;

	private static int MatchAnimationByKDTree_VelocityStrength_Offset;

	private static bool MatchAnimationByKDTree_InputDirection_IsValid;

	private static FFieldAddress MatchAnimationByKDTree_InputDirection_PropertyAddress;

	private static int MatchAnimationByKDTree_InputDirection_Offset;

	private static bool MatchAnimationByKDTree_MotionJointData_IsValid;

	private static FFieldAddress MatchAnimationByKDTree_MotionJointData_PropertyAddress;

	private static int MatchAnimationByKDTree_MotionJointData_Offset;

	private static bool MatchAnimationByKDTree_PresentVel_IsValid;

	private static FFieldAddress MatchAnimationByKDTree_PresentVel_PropertyAddress;

	private static int MatchAnimationByKDTree_PresentVel_Offset;

	private static bool MatchAnimationByKDTree_MinSquareDis_IsValid;

	private static FFieldAddress MatchAnimationByKDTree_MinSquareDis_PropertyAddress;

	private static int MatchAnimationByKDTree_MinSquareDis_Offset;

	private static bool MatchAnimationByKDTree_ReturnValue_IsValid;

	private static FFieldAddress MatchAnimationByKDTree_ReturnValue_PropertyAddress;

	private static int MatchAnimationByKDTree_ReturnValue_Offset;

	private static bool LoadAllAnimSeqFromSoftRefForCalculatingInEditor_IsValid;

	private static IntPtr LoadAllAnimSeqFromSoftRefForCalculatingInEditor_FunctionAddress;

	private static int LoadAllAnimSeqFromSoftRefForCalculatingInEditor_ParamsSize;

	private static bool IsUseLMAnim_IsValid;

	private static IntPtr IsUseLMAnim_FunctionAddress;

	private static int IsUseLMAnim_ParamsSize;

	private static bool IsUseLMAnim_ReturnValue_IsValid;

	private static FFieldAddress IsUseLMAnim_ReturnValue_PropertyAddress;

	private static int IsUseLMAnim_ReturnValue_Offset;

	private static bool IsBoneSelected_IsValid;

	private static IntPtr IsBoneSelected_FunctionAddress;

	private static int IsBoneSelected_ParamsSize;

	private static bool IsBoneSelected_boneName_IsValid;

	private static FFieldAddress IsBoneSelected_boneName_PropertyAddress;

	private static int IsBoneSelected_boneName_Offset;

	private static bool IsBoneSelected_ReturnValue_IsValid;

	private static FFieldAddress IsBoneSelected_ReturnValue_PropertyAddress;

	private static int IsBoneSelected_ReturnValue_Offset;

	private static bool IsAnimMathDataValid_IsValid;

	private static IntPtr IsAnimMathDataValid_FunctionAddress;

	private static int IsAnimMathDataValid_ParamsSize;

	private static bool IsAnimMathDataValid_ReturnValue_IsValid;

	private static FFieldAddress IsAnimMathDataValid_ReturnValue_PropertyAddress;

	private static int IsAnimMathDataValid_ReturnValue_Offset;

	private static bool IsAnimationExtracted_IsValid;

	private static IntPtr IsAnimationExtracted_FunctionAddress;

	private static int IsAnimationExtracted_ParamsSize;

	private static bool IsAnimationExtracted_AnimationRef_IsValid;

	private static FFieldAddress IsAnimationExtracted_AnimationRef_PropertyAddress;

	private static int IsAnimationExtracted_AnimationRef_Offset;

	private static bool IsAnimationExtracted_WorldTime_IsValid;

	private static FFieldAddress IsAnimationExtracted_WorldTime_PropertyAddress;

	private static int IsAnimationExtracted_WorldTime_Offset;

	private static bool IsAnimationExtracted_ReturnValue_IsValid;

	private static FFieldAddress IsAnimationExtracted_ReturnValue_PropertyAddress;

	private static int IsAnimationExtracted_ReturnValue_Offset;

	private static bool InitAnimMathDataBySerializedFeatures_IsValid;

	private static IntPtr InitAnimMathDataBySerializedFeatures_FunctionAddress;

	private static int InitAnimMathDataBySerializedFeatures_ParamsSize;

	private static bool HasSequence_IsValid;

	private static IntPtr HasSequence_FunctionAddress;

	private static int HasSequence_ParamsSize;

	private static bool HasSequence_SequenceName_IsValid;

	private static FFieldAddress HasSequence_SequenceName_PropertyAddress;

	private static int HasSequence_SequenceName_Offset;

	private static bool HasSequence_ReturnValue_IsValid;

	private static FFieldAddress HasSequence_ReturnValue_PropertyAddress;

	private static int HasSequence_ReturnValue_Offset;

	private static bool GetSoftPathByIndex_IsValid;

	private static IntPtr GetSoftPathByIndex_FunctionAddress;

	private static int GetSoftPathByIndex_ParamsSize;

	private static bool GetSoftPathByIndex_Ref_IsValid;

	private static FFieldAddress GetSoftPathByIndex_Ref_PropertyAddress;

	private static int GetSoftPathByIndex_Ref_Offset;

	private static bool GetSoftPathByIndex_ReturnValue_IsValid;

	private static FFieldAddress GetSoftPathByIndex_ReturnValue_PropertyAddress;

	private static int GetSoftPathByIndex_ReturnValue_Offset;

	private static bool GetSequenceTimeOfAnimations_IsValid;

	private static IntPtr GetSequenceTimeOfAnimations_FunctionAddress;

	private static int GetSequenceTimeOfAnimations_ParamsSize;

	private static bool GetSequenceTimeOfAnimations_CurrentAnimationKeyframe_IsValid;

	private static FFieldAddress GetSequenceTimeOfAnimations_CurrentAnimationKeyframe_PropertyAddress;

	private static int GetSequenceTimeOfAnimations_CurrentAnimationKeyframe_Offset;

	private static bool GetSequenceTimeOfAnimations_ReturnValue_IsValid;

	private static FFieldAddress GetSequenceTimeOfAnimations_ReturnValue_PropertyAddress;

	private static int GetSequenceTimeOfAnimations_ReturnValue_Offset;

	private static bool GetAnimationShowNameInEditor_IsValid;

	private static IntPtr GetAnimationShowNameInEditor_FunctionAddress;

	private static int GetAnimationShowNameInEditor_ParamsSize;

	private static bool GetAnimationShowNameInEditor_Ref_IsValid;

	private static FFieldAddress GetAnimationShowNameInEditor_Ref_PropertyAddress;

	private static int GetAnimationShowNameInEditor_Ref_Offset;

	private static bool GetAnimationShowNameInEditor_ReturnValue_IsValid;

	private static FFieldAddress GetAnimationShowNameInEditor_ReturnValue_PropertyAddress;

	private static int GetAnimationShowNameInEditor_ReturnValue_Offset;

	private static bool GetAnimationCount_IsValid;

	private static IntPtr GetAnimationCount_FunctionAddress;

	private static int GetAnimationCount_ParamsSize;

	private static bool GetAnimationCount_ReturnValue_IsValid;

	private static FFieldAddress GetAnimationCount_ReturnValue_PropertyAddress;

	private static int GetAnimationCount_ReturnValue_Offset;

	private static bool GetAnimationAnalyzerSkeleton_IsValid;

	private static IntPtr GetAnimationAnalyzerSkeleton_FunctionAddress;

	private static int GetAnimationAnalyzerSkeleton_ParamsSize;

	private static bool GetAnimationAnalyzerSkeleton_ReturnValue_IsValid;

	private static FFieldAddress GetAnimationAnalyzerSkeleton_ReturnValue_PropertyAddress;

	private static int GetAnimationAnalyzerSkeleton_ReturnValue_Offset;

	private static bool GatherSkeletonInfo_IsValid;

	private static IntPtr GatherSkeletonInfo_FunctionAddress;

	private static int GatherSkeletonInfo_ParamsSize;

	private static bool GatherSkeletonInfo_UserSkeleton_IsValid;

	private static FFieldAddress GatherSkeletonInfo_UserSkeleton_PropertyAddress;

	private static int GatherSkeletonInfo_UserSkeleton_Offset;

	private static bool GatherSkeletonInfo_SelectedJoints_IsValid;

	private static FFieldAddress GatherSkeletonInfo_SelectedJoints_PropertyAddress;

	private static int GatherSkeletonInfo_SelectedJoints_Offset;

	private static bool GatherSkeletonInfo_BoneWeights_IsValid;

	private static FFieldAddress GatherSkeletonInfo_BoneWeights_PropertyAddress;

	private static int GatherSkeletonInfo_BoneWeights_Offset;

	private static bool FindUsersSkeletonBoneNames_IsValid;

	private static IntPtr FindUsersSkeletonBoneNames_FunctionAddress;

	private static int FindUsersSkeletonBoneNames_ParamsSize;

	private static bool FindUsersSkeletonBoneNames_ReferencedBone_IsValid;

	private static FFieldAddress FindUsersSkeletonBoneNames_ReferencedBone_PropertyAddress;

	private static int FindUsersSkeletonBoneNames_ReferencedBone_Offset;

	private static bool FindUsersSkeletonBoneNames_ReturnValue_IsValid;

	private static FFieldAddress FindUsersSkeletonBoneNames_ReturnValue_PropertyAddress;

	private static int FindUsersSkeletonBoneNames_ReturnValue_Offset;

	private static bool FindUserSelectedBones_IsValid;

	private static IntPtr FindUserSelectedBones_FunctionAddress;

	private static int FindUserSelectedBones_ParamsSize;

	private static bool FindUserSelectedBones_ReturnValue_IsValid;

	private static FFieldAddress FindUserSelectedBones_ReturnValue_PropertyAddress;

	private static int FindUserSelectedBones_ReturnValue_Offset;

	private static bool FindAnimationsAtDesiredReferences_IsValid;

	private static IntPtr FindAnimationsAtDesiredReferences_FunctionAddress;

	private static int FindAnimationsAtDesiredReferences_ParamsSize;

	private static bool FindAnimationsAtDesiredReferences_Ref_IsValid;

	private static FFieldAddress FindAnimationsAtDesiredReferences_Ref_PropertyAddress;

	private static int FindAnimationsAtDesiredReferences_Ref_Offset;

	private static bool FindAnimationsAtDesiredReferences_ReturnValue_IsValid;

	private static FFieldAddress FindAnimationsAtDesiredReferences_ReturnValue_PropertyAddress;

	private static int FindAnimationsAtDesiredReferences_ReturnValue_Offset;

	private static bool FindAnimationFromSequence_IsValid;

	private static IntPtr FindAnimationFromSequence_FunctionAddress;

	private static int FindAnimationFromSequence_ParamsSize;

	private static bool FindAnimationFromSequence_CurrentAnimationRef_IsValid;

	private static FFieldAddress FindAnimationFromSequence_CurrentAnimationRef_PropertyAddress;

	private static int FindAnimationFromSequence_CurrentAnimationRef_Offset;

	private static bool FindAnimationFromSequence_ReturnValue_IsValid;

	private static FFieldAddress FindAnimationFromSequence_ReturnValue_PropertyAddress;

	private static int FindAnimationFromSequence_ReturnValue_Offset;

	private static bool CountAnimationReferences_IsValid;

	private static IntPtr CountAnimationReferences_FunctionAddress;

	private static int CountAnimationReferences_ParamsSize;

	private static bool CountAnimationReferences_ReturnValue_IsValid;

	private static FFieldAddress CountAnimationReferences_ReturnValue_PropertyAddress;

	private static int CountAnimationReferences_ReturnValue_Offset;

	private static bool ConstructSerializedFeatures_IsValid;

	private static IntPtr ConstructSerializedFeatures_FunctionAddress;

	private static int ConstructSerializedFeatures_ParamsSize;

	private static bool ConstructAnimationReferences_IsValid;

	private static IntPtr ConstructAnimationReferences_FunctionAddress;

	private static int ConstructAnimationReferences_ParamsSize;

	private static bool ConstructAnimationReferences_FromSourceAnimation_IsValid;

	private static FFieldAddress ConstructAnimationReferences_FromSourceAnimation_PropertyAddress;

	private static int ConstructAnimationReferences_FromSourceAnimation_Offset;

	private static bool ConstructAllAnimationReferences_IsValid;

	private static IntPtr ConstructAllAnimationReferences_FunctionAddress;

	private static int ConstructAllAnimationReferences_ParamsSize;

	private static bool ClearAllAnimSeqForCalculatingInEditor_IsValid;

	private static IntPtr ClearAllAnimSeqForCalculatingInEditor_FunctionAddress;

	private static int ClearAllAnimSeqForCalculatingInEditor_ParamsSize;

	private static bool CleanAnimationReferences_IsValid;

	private static IntPtr CleanAnimationReferences_FunctionAddress;

	private static int CleanAnimationReferences_ParamsSize;

	private static bool CleanAnimationReferences_CurrentReferenceAnimation_IsValid;

	private static FFieldAddress CleanAnimationReferences_CurrentReferenceAnimation_PropertyAddress;

	private static int CleanAnimationReferences_CurrentReferenceAnimation_Offset;

	private static bool CleanAllAnimationReferences_IsValid;

	private static IntPtr CleanAllAnimationReferences_FunctionAddress;

	private static int CleanAllAnimationReferences_ParamsSize;

	private static bool CheckIsFirstLoadRequireDesireAsset_IsValid;

	private IntPtr CheckIsFirstLoadRequireDesireAsset_InstanceFunctionAddress;

	private static IntPtr CheckIsFirstLoadRequireDesireAsset_FunctionAddress;

	private static int CheckIsFirstLoadRequireDesireAsset_ParamsSize;

	private static bool CheckIsFirstLoadRequireDesireAsset_Ref_IsValid;

	private static FFieldAddress CheckIsFirstLoadRequireDesireAsset_Ref_PropertyAddress;

	private static int CheckIsFirstLoadRequireDesireAsset_Ref_Offset;

	private static bool CheckIsFirstLoadRequireDesireAsset_ReturnValue_IsValid;

	private static FFieldAddress CheckIsFirstLoadRequireDesireAsset_ReturnValue_PropertyAddress;

	private static int CheckIsFirstLoadRequireDesireAsset_ReturnValue_Offset;

	private static bool AnimationReferenceIsValid_IsValid;

	private static IntPtr AnimationReferenceIsValid_FunctionAddress;

	private static int AnimationReferenceIsValid_ParamsSize;

	private static bool AnimationReferenceIsValid_CurrentAnimationRef_IsValid;

	private static FFieldAddress AnimationReferenceIsValid_CurrentAnimationRef_PropertyAddress;

	private static int AnimationReferenceIsValid_CurrentAnimationRef_Offset;

	private static bool AnimationReferenceIsValid_ReturnValue_IsValid;

	private static FFieldAddress AnimationReferenceIsValid_ReturnValue_PropertyAddress;

	private static int AnimationReferenceIsValid_ReturnValue_Offset;

	private static bool AnimationContextIsValid_IsValid;

	private static IntPtr AnimationContextIsValid_FunctionAddress;

	private static int AnimationContextIsValid_ParamsSize;

	private static bool AnimationContextIsValid_CurrentAnimationRef_IsValid;

	private static FFieldAddress AnimationContextIsValid_CurrentAnimationRef_PropertyAddress;

	private static int AnimationContextIsValid_CurrentAnimationRef_Offset;

	private static bool AnimationContextIsValid_ReturnValue_IsValid;

	private static FFieldAddress AnimationContextIsValid_ReturnValue_PropertyAddress;

	private static int AnimationContextIsValid_ReturnValue_Offset;

	private static bool AnimationCalculationsAccepted_IsValid;

	private static IntPtr AnimationCalculationsAccepted_FunctionAddress;

	private static int AnimationCalculationsAccepted_ParamsSize;

	private static bool AnimationCalculationsAccepted_Ref_IsValid;

	private static FFieldAddress AnimationCalculationsAccepted_Ref_PropertyAddress;

	private static int AnimationCalculationsAccepted_Ref_Offset;

	private static bool AnimationCalculationsAccepted_ReturnValue_IsValid;

	private static FFieldAddress AnimationCalculationsAccepted_ReturnValue_PropertyAddress;

	private static int AnimationCalculationsAccepted_ReturnValue_Offset;

	private static bool AnalyzerAnimationReferences_IsValid;

	private static IntPtr AnalyzerAnimationReferences_FunctionAddress;

	private static int AnalyzerAnimationReferences_ParamsSize;

	private static bool AnalyzerAnimationReferences_CurrentReferenceAnimation_IsValid;

	private static FFieldAddress AnalyzerAnimationReferences_CurrentReferenceAnimation_PropertyAddress;

	private static int AnalyzerAnimationReferences_CurrentReferenceAnimation_Offset;

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:LastMatchedAnimIndex")]
	public int LastMatchedAnimIndex
	{
		get
		{
			CheckDestroyed();
			if (!LastMatchedAnimIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MM.AnimationAnalyzer:LastMatchedAnimIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LastMatchedAnimIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastMatchedAnimIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MM.AnimationAnalyzer:LastMatchedAnimIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LastMatchedAnimIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:ControllerInputReactionSpeed")]
	public float ControllerInputReactionSpeed
	{
		get
		{
			CheckDestroyed();
			if (!ControllerInputReactionSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MM.AnimationAnalyzer:ControllerInputReactionSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ControllerInputReactionSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ControllerInputReactionSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MM.AnimationAnalyzer:ControllerInputReactionSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ControllerInputReactionSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:ControllerRotateReactionSpeed")]
	public float ControllerRotateReactionSpeed
	{
		get
		{
			CheckDestroyed();
			if (!ControllerRotateReactionSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MM.AnimationAnalyzer:ControllerRotateReactionSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ControllerRotateReactionSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ControllerRotateReactionSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MM.AnimationAnalyzer:ControllerRotateReactionSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ControllerRotateReactionSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371028uL)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:MMKDTree")]
	public TArrayReadOnly<FMMKDTreeNode> MMKDTree
	{
		get
		{
			CheckDestroyed();
			if (!MMKDTree_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MM.AnimationAnalyzer:MMKDTree");
				return null;
			}
			if (MMKDTree_MarshalerCached == null)
			{
				MMKDTree_MarshalerCached = new TArrayReadOnlyMarshaler<FMMKDTreeNode>(1, MMKDTree_PropertyAddress, CachedMarshalingDelegates<FMMKDTreeNode, FMMKDTreeNode>.FromNative, CachedMarshalingDelegates<FMMKDTreeNode, FMMKDTreeNode>.ToNative);
			}
			return MMKDTree_MarshalerCached.FromNative(IntPtr.Add(base.Address, MMKDTree_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:AnimationReferences")]
	public TArrayReadWrite<FMotionMatchingMath> AnimationReferences
	{
		get
		{
			CheckDestroyed();
			if (!AnimationReferences_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MM.AnimationAnalyzer:AnimationReferences");
				return null;
			}
			if (AnimationReferences_MarshalerCached == null)
			{
				AnimationReferences_MarshalerCached = new TArrayReadWriteMarshaler<FMotionMatchingMath>(1, AnimationReferences_PropertyAddress, CachedMarshalingDelegates<FMotionMatchingMath, FMotionMatchingMath>.FromNative, CachedMarshalingDelegates<FMotionMatchingMath, FMotionMatchingMath>.ToNative);
			}
			return AnimationReferences_MarshalerCached.FromNative(IntPtr.Add(base.Address, AnimationReferences_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:ReferencedJoints")]
	public TArrayReadOnly<FName> ReferencedJoints
	{
		get
		{
			CheckDestroyed();
			if (!ReferencedJoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MM.AnimationAnalyzer:ReferencedJoints");
				return null;
			}
			if (ReferencedJoints_MarshalerCached == null)
			{
				ReferencedJoints_MarshalerCached = new TArrayReadOnlyMarshaler<FName>(1, ReferencedJoints_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return ReferencedJoints_MarshalerCached.FromNative(IntPtr.Add(base.Address, ReferencedJoints_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370516uL)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:JointWeights")]
	public TMapReadOnly<int, float> JointWeights
	{
		get
		{
			CheckDestroyed();
			if (!JointWeights_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MM.AnimationAnalyzer:JointWeights");
				return null;
			}
			if (JointWeights_MarshalerCached == null)
			{
				JointWeights_MarshalerCached = new TMapReadOnlyMarshaler<int, float>(1, JointWeights_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return JointWeights_MarshalerCached.FromNative(IntPtr.Add(base.Address, JointWeights_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:AnimationsInMemory")]
	public TArrayReadWrite<UAnimSequence> AnimationsInMemory
	{
		get
		{
			CheckDestroyed();
			if (!AnimationsInMemory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MM.AnimationAnalyzer:AnimationsInMemory");
				return null;
			}
			if (AnimationsInMemory_MarshalerCached == null)
			{
				AnimationsInMemory_MarshalerCached = new TArrayReadWriteMarshaler<UAnimSequence>(1, AnimationsInMemory_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative);
			}
			return AnimationsInMemory_MarshalerCached.FromNative(IntPtr.Add(base.Address, AnimationsInMemory_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:AnimationSeqSoftDatas")]
	public TArrayReadWrite<FMotionMatchingAnimSeqdata> AnimationSeqSoftDatas
	{
		get
		{
			CheckDestroyed();
			if (!AnimationSeqSoftDatas_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MM.AnimationAnalyzer:AnimationSeqSoftDatas");
				return null;
			}
			if (AnimationSeqSoftDatas_MarshalerCached == null)
			{
				AnimationSeqSoftDatas_MarshalerCached = new TArrayReadWriteMarshaler<FMotionMatchingAnimSeqdata>(1, AnimationSeqSoftDatas_PropertyAddress, CachedMarshalingDelegates<FMotionMatchingAnimSeqdata, FMotionMatchingAnimSeqdata>.FromNative, CachedMarshalingDelegates<FMotionMatchingAnimSeqdata, FMotionMatchingAnimSeqdata>.ToNative);
			}
			return AnimationSeqSoftDatas_MarshalerCached.FromNative(IntPtr.Add(base.Address, AnimationSeqSoftDatas_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:bUsingAssetSoftRef")]
	public bool UsingAssetSoftRef
	{
		get
		{
			CheckDestroyed();
			if (!UsingAssetSoftRef_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MM.AnimationAnalyzer:bUsingAssetSoftRef");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsingAssetSoftRef_Offset), 0, UsingAssetSoftRef_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsingAssetSoftRef_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MM.AnimationAnalyzer:bUsingAssetSoftRef");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsingAssetSoftRef_Offset), 0, UsingAssetSoftRef_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:TryInitFromAA")]
	public unsafe bool TryInitFromAA(UAnimationAnalyzer OrgAA)
	{
		CheckDestroyed();
		if (!TryInitFromAA_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:TryInitFromAA");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryInitFromAA_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryInitFromAA_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimationAnalyzer>.ToNative(IntPtr.Add(intPtr, TryInitFromAA_OrgAA_Offset), 0, TryInitFromAA_OrgAA_PropertyAddress.Address, OrgAA);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryInitFromAA_FunctionAddress, intPtr, TryInitFromAA_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TryInitFromAA_ReturnValue_Offset), 0, TryInitFromAA_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:StructureForAnimationCalculations")]
	public unsafe int StructureForAnimationCalculations(float ControllerInputReactionSpeedCustom, float ControllerRotateReactionSpeedCustom, float VelocityStrength, float AnimationMatchPower, FInputPlayerDirectionData InputDirection, List<FSkeletonStructure> AllAnimationReferences, FVector PresentVel, float BlendTime, out float CalculatedResult, out FMotionMatchingCostData AnimCostData)
	{
		CheckDestroyed();
		if (!StructureForAnimationCalculations_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:StructureForAnimationCalculations");
			CalculatedResult = 0f;
			AnimCostData = default(FMotionMatchingCostData);
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StructureForAnimationCalculations_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StructureForAnimationCalculations_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StructureForAnimationCalculations_ControllerInputReactionSpeedCustom_Offset), 0, StructureForAnimationCalculations_ControllerInputReactionSpeedCustom_PropertyAddress.Address, ControllerInputReactionSpeedCustom);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StructureForAnimationCalculations_ControllerRotateReactionSpeedCustom_Offset), 0, StructureForAnimationCalculations_ControllerRotateReactionSpeedCustom_PropertyAddress.Address, ControllerRotateReactionSpeedCustom);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StructureForAnimationCalculations_VelocityStrength_Offset), 0, StructureForAnimationCalculations_VelocityStrength_PropertyAddress.Address, VelocityStrength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StructureForAnimationCalculations_AnimationMatchPower_Offset), 0, StructureForAnimationCalculations_AnimationMatchPower_PropertyAddress.Address, AnimationMatchPower);
		NativeReflection.InitializeValue_InContainer(StructureForAnimationCalculations_InputDirection_PropertyAddress.Address, intPtr);
		FInputPlayerDirectionData.ToNative(IntPtr.Add(intPtr, StructureForAnimationCalculations_InputDirection_Offset), 0, StructureForAnimationCalculations_InputDirection_PropertyAddress.Address, InputDirection);
		new TArrayCopyMarshaler<FSkeletonStructure>(1, StructureForAnimationCalculations_AllAnimationReferences_PropertyAddress, CachedMarshalingDelegates<FSkeletonStructure, FSkeletonStructure>.FromNative, CachedMarshalingDelegates<FSkeletonStructure, FSkeletonStructure>.ToNative).ToNative(IntPtr.Add(intPtr, StructureForAnimationCalculations_AllAnimationReferences_Offset), AllAnimationReferences);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, StructureForAnimationCalculations_PresentVel_Offset), 0, StructureForAnimationCalculations_PresentVel_PropertyAddress.Address, PresentVel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StructureForAnimationCalculations_BlendTime_Offset), 0, StructureForAnimationCalculations_BlendTime_PropertyAddress.Address, BlendTime);
		NativeReflection.InitializeValue_InContainer(StructureForAnimationCalculations_AnimCostData_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, StructureForAnimationCalculations_FunctionAddress, intPtr, StructureForAnimationCalculations_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StructureForAnimationCalculations_InputDirection_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StructureForAnimationCalculations_AllAnimationReferences_PropertyAddress.Address, intPtr);
		CalculatedResult = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, StructureForAnimationCalculations_CalculatedResult_Offset), 0, StructureForAnimationCalculations_CalculatedResult_PropertyAddress.Address);
		AnimCostData = FMotionMatchingCostData.FromNative(IntPtr.Add(intPtr, StructureForAnimationCalculations_AnimCostData_Offset), 0, StructureForAnimationCalculations_AnimCostData_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(StructureForAnimationCalculations_AnimCostData_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, StructureForAnimationCalculations_ReturnValue_Offset), 0, StructureForAnimationCalculations_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:SetUseLMAnim")]
	public unsafe void SetUseLMAnim(bool bUse)
	{
		CheckDestroyed();
		if (!SetUseLMAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:SetUseLMAnim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUseLMAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUseLMAnim_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetUseLMAnim_bUse_Offset), 0, SetUseLMAnim_bUse_PropertyAddress.Address, bUse);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUseLMAnim_FunctionAddress, intPtr, SetUseLMAnim_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:RequireAnimationsLoadAtDesiredReferences")]
	public unsafe int RequireAnimationsLoadAtDesiredReferences(int Ref, bool bLoadAll, UObject AnimInst)
	{
		CheckDestroyed();
		if (!RequireAnimationsLoadAtDesiredReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:RequireAnimationsLoadAtDesiredReferences");
			return 0;
		}
		if (RequireAnimationsLoadAtDesiredReferences_InstanceFunctionAddress == IntPtr.Zero)
		{
			RequireAnimationsLoadAtDesiredReferences_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "RequireAnimationsLoadAtDesiredReferences");
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequireAnimationsLoadAtDesiredReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequireAnimationsLoadAtDesiredReferences_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RequireAnimationsLoadAtDesiredReferences_Ref_Offset), 0, RequireAnimationsLoadAtDesiredReferences_Ref_PropertyAddress.Address, Ref);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequireAnimationsLoadAtDesiredReferences_bLoadAll_Offset), 0, RequireAnimationsLoadAtDesiredReferences_bLoadAll_PropertyAddress.Address, bLoadAll);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RequireAnimationsLoadAtDesiredReferences_AnimInst_Offset), 0, RequireAnimationsLoadAtDesiredReferences_AnimInst_PropertyAddress.Address, AnimInst);
		NativeReflection.InvokeFunctionOptimized(base.Address, RequireAnimationsLoadAtDesiredReferences_InstanceFunctionAddress, intPtr, RequireAnimationsLoadAtDesiredReferences_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, RequireAnimationsLoadAtDesiredReferences_ReturnValue_Offset), 0, RequireAnimationsLoadAtDesiredReferences_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int RequireAnimationsLoadAtDesiredReferences_Implementation(int Ref, bool bLoadAll, UObject AnimInst)
	{
		CheckDestroyed();
		if (!RequireAnimationsLoadAtDesiredReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:RequireAnimationsLoadAtDesiredReferences");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequireAnimationsLoadAtDesiredReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequireAnimationsLoadAtDesiredReferences_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RequireAnimationsLoadAtDesiredReferences_Ref_Offset), 0, RequireAnimationsLoadAtDesiredReferences_Ref_PropertyAddress.Address, Ref);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequireAnimationsLoadAtDesiredReferences_bLoadAll_Offset), 0, RequireAnimationsLoadAtDesiredReferences_bLoadAll_PropertyAddress.Address, bLoadAll);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RequireAnimationsLoadAtDesiredReferences_AnimInst_Offset), 0, RequireAnimationsLoadAtDesiredReferences_AnimInst_PropertyAddress.Address, AnimInst);
		NativeReflection.InvokeFunctionOptimized(base.Address, RequireAnimationsLoadAtDesiredReferences_FunctionAddress, intPtr, RequireAnimationsLoadAtDesiredReferences_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, RequireAnimationsLoadAtDesiredReferences_ReturnValue_Offset), 0, RequireAnimationsLoadAtDesiredReferences_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:RemoveAnimationReference")]
	public unsafe void RemoveAnimationReference(int CurrentAnimationRef)
	{
		CheckDestroyed();
		if (!RemoveAnimationReference_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:RemoveAnimationReference");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAnimationReference_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAnimationReference_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveAnimationReference_CurrentAnimationRef_Offset), 0, RemoveAnimationReference_CurrentAnimationRef_PropertyAddress.Address, CurrentAnimationRef);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAnimationReference_FunctionAddress, intPtr, RemoveAnimationReference_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:OnAnimationAssetLoadStatChange")]
	public unsafe void OnAnimationAssetLoadStatChange(int Ref, EAnimSeqAssetLoadStatType Stat, UAnimSequence Anim)
	{
		CheckDestroyed();
		if (!OnAnimationAssetLoadStatChange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:OnAnimationAssetLoadStatChange");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAnimationAssetLoadStatChange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAnimationAssetLoadStatChange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnAnimationAssetLoadStatChange_Ref_Offset), 0, OnAnimationAssetLoadStatChange_Ref_PropertyAddress.Address, Ref);
		EnumMarshaler<EAnimSeqAssetLoadStatType>.ToNative(IntPtr.Add(intPtr, OnAnimationAssetLoadStatChange_Stat_Offset), 0, OnAnimationAssetLoadStatChange_Stat_PropertyAddress.Address, Stat);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, OnAnimationAssetLoadStatChange_Anim_Offset), 0, OnAnimationAssetLoadStatChange_Anim_PropertyAddress.Address, Anim);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnAnimationAssetLoadStatChange_FunctionAddress, intPtr, OnAnimationAssetLoadStatChange_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:NewAnimationReference")]
	public unsafe void NewAnimationReference(List<UAnimSequence> ProvidedAnimationsByUser)
	{
		CheckDestroyed();
		if (!NewAnimationReference_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:NewAnimationReference");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NewAnimationReference_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NewAnimationReference_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UAnimSequence>(1, NewAnimationReference_ProvidedAnimationsByUser_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).ToNative(IntPtr.Add(intPtr, NewAnimationReference_ProvidedAnimationsByUser_Offset), ProvidedAnimationsByUser);
		NativeReflection.InvokeFunctionOptimized(base.Address, NewAnimationReference_FunctionAddress, intPtr, NewAnimationReference_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NewAnimationReference_ProvidedAnimationsByUser_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:MMAnimationSeqUsingNotify_Inner")]
	public unsafe void MMAnimationSeqUsingNotify_Inner(int Ref, AActor owner)
	{
		CheckDestroyed();
		if (!MMAnimationSeqUsingNotify_Inner_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:MMAnimationSeqUsingNotify_Inner");
			return;
		}
		if (MMAnimationSeqUsingNotify_Inner_InstanceFunctionAddress == IntPtr.Zero)
		{
			MMAnimationSeqUsingNotify_Inner_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "MMAnimationSeqUsingNotify_Inner");
		}
		byte* ptr = stackalloc byte[(int)(uint)(MMAnimationSeqUsingNotify_Inner_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MMAnimationSeqUsingNotify_Inner_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MMAnimationSeqUsingNotify_Inner_Ref_Offset), 0, MMAnimationSeqUsingNotify_Inner_Ref_PropertyAddress.Address, Ref);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, MMAnimationSeqUsingNotify_Inner_owner_Offset), 0, MMAnimationSeqUsingNotify_Inner_owner_PropertyAddress.Address, owner);
		NativeReflection.InvokeFunctionOptimized(base.Address, MMAnimationSeqUsingNotify_Inner_InstanceFunctionAddress, intPtr, MMAnimationSeqUsingNotify_Inner_ParamsSize);
	}

	protected unsafe virtual void MMAnimationSeqUsingNotify_Inner_Implementation(int Ref, AActor owner)
	{
		CheckDestroyed();
		if (!MMAnimationSeqUsingNotify_Inner_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:MMAnimationSeqUsingNotify_Inner");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MMAnimationSeqUsingNotify_Inner_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MMAnimationSeqUsingNotify_Inner_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MMAnimationSeqUsingNotify_Inner_Ref_Offset), 0, MMAnimationSeqUsingNotify_Inner_Ref_PropertyAddress.Address, Ref);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, MMAnimationSeqUsingNotify_Inner_owner_Offset), 0, MMAnimationSeqUsingNotify_Inner_owner_PropertyAddress.Address, owner);
		NativeReflection.InvokeFunctionOptimized(base.Address, MMAnimationSeqUsingNotify_Inner_FunctionAddress, intPtr, MMAnimationSeqUsingNotify_Inner_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:MatchAnimationByKDTree")]
	public unsafe int MatchAnimationByKDTree(float VelocityStrength, FInputPlayerDirectionData InputDirection, List<FSkeletonStructure> MotionJointData, FVector PresentVel, out float MinSquareDis)
	{
		CheckDestroyed();
		if (!MatchAnimationByKDTree_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:MatchAnimationByKDTree");
			MinSquareDis = 0f;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MatchAnimationByKDTree_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MatchAnimationByKDTree_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MatchAnimationByKDTree_VelocityStrength_Offset), 0, MatchAnimationByKDTree_VelocityStrength_PropertyAddress.Address, VelocityStrength);
		NativeReflection.InitializeValue_InContainer(MatchAnimationByKDTree_InputDirection_PropertyAddress.Address, intPtr);
		FInputPlayerDirectionData.ToNative(IntPtr.Add(intPtr, MatchAnimationByKDTree_InputDirection_Offset), 0, MatchAnimationByKDTree_InputDirection_PropertyAddress.Address, InputDirection);
		new TArrayCopyMarshaler<FSkeletonStructure>(1, MatchAnimationByKDTree_MotionJointData_PropertyAddress, CachedMarshalingDelegates<FSkeletonStructure, FSkeletonStructure>.FromNative, CachedMarshalingDelegates<FSkeletonStructure, FSkeletonStructure>.ToNative).ToNative(IntPtr.Add(intPtr, MatchAnimationByKDTree_MotionJointData_Offset), MotionJointData);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, MatchAnimationByKDTree_PresentVel_Offset), 0, MatchAnimationByKDTree_PresentVel_PropertyAddress.Address, PresentVel);
		NativeReflection.InvokeFunctionOptimized(base.Address, MatchAnimationByKDTree_FunctionAddress, intPtr, MatchAnimationByKDTree_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MatchAnimationByKDTree_InputDirection_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MatchAnimationByKDTree_MotionJointData_PropertyAddress.Address, intPtr);
		MinSquareDis = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, MatchAnimationByKDTree_MinSquareDis_Offset), 0, MatchAnimationByKDTree_MinSquareDis_PropertyAddress.Address);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, MatchAnimationByKDTree_ReturnValue_Offset), 0, MatchAnimationByKDTree_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:LoadAllAnimSeqFromSoftRefForCalculatingInEditor")]
	public unsafe void LoadAllAnimSeqFromSoftRefForCalculatingInEditor()
	{
		CheckDestroyed();
		if (!LoadAllAnimSeqFromSoftRefForCalculatingInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:LoadAllAnimSeqFromSoftRefForCalculatingInEditor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadAllAnimSeqFromSoftRefForCalculatingInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadAllAnimSeqFromSoftRefForCalculatingInEditor_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: LoadAllAnimSeqFromSoftRefForCalculatingInEditor_FunctionAddress, argsSize: LoadAllAnimSeqFromSoftRefForCalculatingInEditor_ParamsSize);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:IsUseLMAnim")]
	public unsafe bool IsUseLMAnim()
	{
		CheckDestroyed();
		if (!IsUseLMAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:IsUseLMAnim");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsUseLMAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsUseLMAnim_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsUseLMAnim_FunctionAddress, intPtr, IsUseLMAnim_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsUseLMAnim_ReturnValue_Offset), 0, IsUseLMAnim_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:IsBoneSelected")]
	public unsafe bool IsBoneSelected(FName boneName)
	{
		CheckDestroyed();
		if (!IsBoneSelected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:IsBoneSelected");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsBoneSelected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsBoneSelected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsBoneSelected_boneName_Offset), 0, IsBoneSelected_boneName_PropertyAddress.Address, boneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsBoneSelected_FunctionAddress, intPtr, IsBoneSelected_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsBoneSelected_ReturnValue_Offset), 0, IsBoneSelected_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:IsAnimMathDataValid")]
	public unsafe bool IsAnimMathDataValid()
	{
		CheckDestroyed();
		if (!IsAnimMathDataValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:IsAnimMathDataValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAnimMathDataValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAnimMathDataValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsAnimMathDataValid_FunctionAddress, intPtr, IsAnimMathDataValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAnimMathDataValid_ReturnValue_Offset), 0, IsAnimMathDataValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:IsAnimationExtracted")]
	public unsafe bool IsAnimationExtracted(FName AnimationRef, float WorldTime)
	{
		CheckDestroyed();
		if (!IsAnimationExtracted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:IsAnimationExtracted");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAnimationExtracted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAnimationExtracted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsAnimationExtracted_AnimationRef_Offset), 0, IsAnimationExtracted_AnimationRef_PropertyAddress.Address, AnimationRef);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, IsAnimationExtracted_WorldTime_Offset), 0, IsAnimationExtracted_WorldTime_PropertyAddress.Address, WorldTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsAnimationExtracted_FunctionAddress, intPtr, IsAnimationExtracted_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAnimationExtracted_ReturnValue_Offset), 0, IsAnimationExtracted_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:InitAnimMathDataBySerializedFeatures")]
	public unsafe void InitAnimMathDataBySerializedFeatures()
	{
		CheckDestroyed();
		if (!InitAnimMathDataBySerializedFeatures_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:InitAnimMathDataBySerializedFeatures");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitAnimMathDataBySerializedFeatures_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitAnimMathDataBySerializedFeatures_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitAnimMathDataBySerializedFeatures_FunctionAddress, argsSize: InitAnimMathDataBySerializedFeatures_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:HasSequence")]
	public unsafe bool HasSequence(FName SequenceName)
	{
		CheckDestroyed();
		if (!HasSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:HasSequence");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, HasSequence_SequenceName_Offset), 0, HasSequence_SequenceName_PropertyAddress.Address, SequenceName);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasSequence_FunctionAddress, intPtr, HasSequence_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasSequence_ReturnValue_Offset), 0, HasSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:GetSoftPathByIndex")]
	public unsafe FSoftObjectPath GetSoftPathByIndex(int Ref)
	{
		CheckDestroyed();
		if (!GetSoftPathByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:GetSoftPathByIndex");
			return default(FSoftObjectPath);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSoftPathByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSoftPathByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSoftPathByIndex_Ref_Offset), 0, GetSoftPathByIndex_Ref_PropertyAddress.Address, Ref);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSoftPathByIndex_FunctionAddress, intPtr, GetSoftPathByIndex_ParamsSize);
		FSoftObjectPath result = FSoftObjectPath.FromNative(IntPtr.Add(intPtr, GetSoftPathByIndex_ReturnValue_Offset), 0, GetSoftPathByIndex_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSoftPathByIndex_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:GetSequenceTimeOfAnimations")]
	public unsafe FMotionMatchingMath GetSequenceTimeOfAnimations(int CurrentAnimationKeyframe)
	{
		CheckDestroyed();
		if (!GetSequenceTimeOfAnimations_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:GetSequenceTimeOfAnimations");
			return default(FMotionMatchingMath);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequenceTimeOfAnimations_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequenceTimeOfAnimations_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSequenceTimeOfAnimations_CurrentAnimationKeyframe_Offset), 0, GetSequenceTimeOfAnimations_CurrentAnimationKeyframe_PropertyAddress.Address, CurrentAnimationKeyframe);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSequenceTimeOfAnimations_FunctionAddress, intPtr, GetSequenceTimeOfAnimations_ParamsSize);
		FMotionMatchingMath result = FMotionMatchingMath.FromNative(IntPtr.Add(intPtr, GetSequenceTimeOfAnimations_ReturnValue_Offset), 0, GetSequenceTimeOfAnimations_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSequenceTimeOfAnimations_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:GetAnimationShowNameInEditor")]
	public unsafe string GetAnimationShowNameInEditor(int Ref)
	{
		CheckDestroyed();
		if (!GetAnimationShowNameInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:GetAnimationShowNameInEditor");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationShowNameInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationShowNameInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAnimationShowNameInEditor_Ref_Offset), 0, GetAnimationShowNameInEditor_Ref_PropertyAddress.Address, Ref);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnimationShowNameInEditor_FunctionAddress, intPtr, GetAnimationShowNameInEditor_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetAnimationShowNameInEditor_ReturnValue_Offset), 0, GetAnimationShowNameInEditor_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetAnimationShowNameInEditor_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:GetAnimationCount")]
	public unsafe int GetAnimationCount()
	{
		CheckDestroyed();
		if (!GetAnimationCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:GetAnimationCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnimationCount_FunctionAddress, intPtr, GetAnimationCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetAnimationCount_ReturnValue_Offset), 0, GetAnimationCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:GetAnimationAnalyzerSkeleton")]
	public unsafe USkeleton GetAnimationAnalyzerSkeleton()
	{
		CheckDestroyed();
		if (!GetAnimationAnalyzerSkeleton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:GetAnimationAnalyzerSkeleton");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationAnalyzerSkeleton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationAnalyzerSkeleton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnimationAnalyzerSkeleton_FunctionAddress, intPtr, GetAnimationAnalyzerSkeleton_ParamsSize);
		return UObjectMarshaler<USkeleton>.FromNative(IntPtr.Add(intPtr, GetAnimationAnalyzerSkeleton_ReturnValue_Offset), 0, GetAnimationAnalyzerSkeleton_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:GatherSkeletonInfo")]
	public unsafe void GatherSkeletonInfo(USkeleton UserSkeleton, List<FName> SelectedJoints, List<float> BoneWeights)
	{
		CheckDestroyed();
		if (!GatherSkeletonInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:GatherSkeletonInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GatherSkeletonInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GatherSkeletonInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, GatherSkeletonInfo_UserSkeleton_Offset), 0, GatherSkeletonInfo_UserSkeleton_PropertyAddress.Address, UserSkeleton);
		new TArrayCopyMarshaler<FName>(1, GatherSkeletonInfo_SelectedJoints_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, GatherSkeletonInfo_SelectedJoints_Offset), SelectedJoints);
		new TArrayCopyMarshaler<float>(1, GatherSkeletonInfo_BoneWeights_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, GatherSkeletonInfo_BoneWeights_Offset), BoneWeights);
		NativeReflection.InvokeFunctionOptimized(base.Address, GatherSkeletonInfo_FunctionAddress, intPtr, GatherSkeletonInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GatherSkeletonInfo_SelectedJoints_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GatherSkeletonInfo_BoneWeights_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:FindUsersSkeletonBoneNames")]
	public unsafe FName FindUsersSkeletonBoneNames(int ReferencedBone)
	{
		CheckDestroyed();
		if (!FindUsersSkeletonBoneNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:FindUsersSkeletonBoneNames");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindUsersSkeletonBoneNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindUsersSkeletonBoneNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, FindUsersSkeletonBoneNames_ReferencedBone_Offset), 0, FindUsersSkeletonBoneNames_ReferencedBone_PropertyAddress.Address, ReferencedBone);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindUsersSkeletonBoneNames_FunctionAddress, intPtr, FindUsersSkeletonBoneNames_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, FindUsersSkeletonBoneNames_ReturnValue_Offset), 0, FindUsersSkeletonBoneNames_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:FindUserSelectedBones")]
	public unsafe int FindUserSelectedBones()
	{
		CheckDestroyed();
		if (!FindUserSelectedBones_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:FindUserSelectedBones");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindUserSelectedBones_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindUserSelectedBones_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindUserSelectedBones_FunctionAddress, intPtr, FindUserSelectedBones_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FindUserSelectedBones_ReturnValue_Offset), 0, FindUserSelectedBones_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:FindAnimationsAtDesiredReferences")]
	public unsafe UAnimSequence FindAnimationsAtDesiredReferences(int Ref)
	{
		CheckDestroyed();
		if (!FindAnimationsAtDesiredReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:FindAnimationsAtDesiredReferences");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindAnimationsAtDesiredReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindAnimationsAtDesiredReferences_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, FindAnimationsAtDesiredReferences_Ref_Offset), 0, FindAnimationsAtDesiredReferences_Ref_PropertyAddress.Address, Ref);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindAnimationsAtDesiredReferences_FunctionAddress, intPtr, FindAnimationsAtDesiredReferences_ParamsSize);
		return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(intPtr, FindAnimationsAtDesiredReferences_ReturnValue_Offset), 0, FindAnimationsAtDesiredReferences_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:FindAnimationFromSequence")]
	public unsafe UAnimSequence FindAnimationFromSequence(int CurrentAnimationRef)
	{
		CheckDestroyed();
		if (!FindAnimationFromSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:FindAnimationFromSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindAnimationFromSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindAnimationFromSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, FindAnimationFromSequence_CurrentAnimationRef_Offset), 0, FindAnimationFromSequence_CurrentAnimationRef_PropertyAddress.Address, CurrentAnimationRef);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindAnimationFromSequence_FunctionAddress, intPtr, FindAnimationFromSequence_ParamsSize);
		return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(intPtr, FindAnimationFromSequence_ReturnValue_Offset), 0, FindAnimationFromSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:CountAnimationReferences")]
	public unsafe int CountAnimationReferences()
	{
		CheckDestroyed();
		if (!CountAnimationReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:CountAnimationReferences");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CountAnimationReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CountAnimationReferences_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CountAnimationReferences_FunctionAddress, intPtr, CountAnimationReferences_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CountAnimationReferences_ReturnValue_Offset), 0, CountAnimationReferences_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67372033u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:ConstructSerializedFeatures")]
	public unsafe void ConstructSerializedFeatures()
	{
		CheckDestroyed();
		if (!ConstructSerializedFeatures_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:ConstructSerializedFeatures");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConstructSerializedFeatures_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConstructSerializedFeatures_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ConstructSerializedFeatures_FunctionAddress, argsSize: ConstructSerializedFeatures_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:ConstructAnimationReferences")]
	public unsafe void ConstructAnimationReferences(int FromSourceAnimation)
	{
		CheckDestroyed();
		if (!ConstructAnimationReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:ConstructAnimationReferences");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConstructAnimationReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConstructAnimationReferences_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConstructAnimationReferences_FromSourceAnimation_Offset), 0, ConstructAnimationReferences_FromSourceAnimation_PropertyAddress.Address, FromSourceAnimation);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConstructAnimationReferences_FunctionAddress, intPtr, ConstructAnimationReferences_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:ConstructAllAnimationReferences")]
	public unsafe void ConstructAllAnimationReferences()
	{
		CheckDestroyed();
		if (!ConstructAllAnimationReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:ConstructAllAnimationReferences");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConstructAllAnimationReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConstructAllAnimationReferences_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ConstructAllAnimationReferences_FunctionAddress, argsSize: ConstructAllAnimationReferences_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:ClearAllAnimSeqForCalculatingInEditor")]
	public unsafe void ClearAllAnimSeqForCalculatingInEditor()
	{
		CheckDestroyed();
		if (!ClearAllAnimSeqForCalculatingInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:ClearAllAnimSeqForCalculatingInEditor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAllAnimSeqForCalculatingInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAllAnimSeqForCalculatingInEditor_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearAllAnimSeqForCalculatingInEditor_FunctionAddress, argsSize: ClearAllAnimSeqForCalculatingInEditor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:CleanAnimationReferences")]
	public unsafe void CleanAnimationReferences(int CurrentReferenceAnimation)
	{
		CheckDestroyed();
		if (!CleanAnimationReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:CleanAnimationReferences");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CleanAnimationReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CleanAnimationReferences_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CleanAnimationReferences_CurrentReferenceAnimation_Offset), 0, CleanAnimationReferences_CurrentReferenceAnimation_PropertyAddress.Address, CurrentReferenceAnimation);
		NativeReflection.InvokeFunctionOptimized(base.Address, CleanAnimationReferences_FunctionAddress, intPtr, CleanAnimationReferences_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:CleanAllAnimationReferences")]
	public unsafe void CleanAllAnimationReferences()
	{
		CheckDestroyed();
		if (!CleanAllAnimationReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:CleanAllAnimationReferences");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CleanAllAnimationReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CleanAllAnimationReferences_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CleanAllAnimationReferences_FunctionAddress, argsSize: CleanAllAnimationReferences_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:CheckIsFirstLoadRequireDesireAsset")]
	public unsafe bool CheckIsFirstLoadRequireDesireAsset(int Ref)
	{
		CheckDestroyed();
		if (!CheckIsFirstLoadRequireDesireAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:CheckIsFirstLoadRequireDesireAsset");
			return false;
		}
		if (CheckIsFirstLoadRequireDesireAsset_InstanceFunctionAddress == IntPtr.Zero)
		{
			CheckIsFirstLoadRequireDesireAsset_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CheckIsFirstLoadRequireDesireAsset");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckIsFirstLoadRequireDesireAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckIsFirstLoadRequireDesireAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CheckIsFirstLoadRequireDesireAsset_Ref_Offset), 0, CheckIsFirstLoadRequireDesireAsset_Ref_PropertyAddress.Address, Ref);
		NativeReflection.InvokeFunctionOptimized(base.Address, CheckIsFirstLoadRequireDesireAsset_InstanceFunctionAddress, intPtr, CheckIsFirstLoadRequireDesireAsset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckIsFirstLoadRequireDesireAsset_ReturnValue_Offset), 0, CheckIsFirstLoadRequireDesireAsset_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool CheckIsFirstLoadRequireDesireAsset_Implementation(int Ref)
	{
		CheckDestroyed();
		if (!CheckIsFirstLoadRequireDesireAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:CheckIsFirstLoadRequireDesireAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckIsFirstLoadRequireDesireAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckIsFirstLoadRequireDesireAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CheckIsFirstLoadRequireDesireAsset_Ref_Offset), 0, CheckIsFirstLoadRequireDesireAsset_Ref_PropertyAddress.Address, Ref);
		NativeReflection.InvokeFunctionOptimized(base.Address, CheckIsFirstLoadRequireDesireAsset_FunctionAddress, intPtr, CheckIsFirstLoadRequireDesireAsset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckIsFirstLoadRequireDesireAsset_ReturnValue_Offset), 0, CheckIsFirstLoadRequireDesireAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:AnimationReferenceIsValid")]
	public unsafe bool AnimationReferenceIsValid(int CurrentAnimationRef)
	{
		CheckDestroyed();
		if (!AnimationReferenceIsValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:AnimationReferenceIsValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimationReferenceIsValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimationReferenceIsValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AnimationReferenceIsValid_CurrentAnimationRef_Offset), 0, AnimationReferenceIsValid_CurrentAnimationRef_PropertyAddress.Address, CurrentAnimationRef);
		NativeReflection.InvokeFunctionOptimized(base.Address, AnimationReferenceIsValid_FunctionAddress, intPtr, AnimationReferenceIsValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AnimationReferenceIsValid_ReturnValue_Offset), 0, AnimationReferenceIsValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:AnimationContextIsValid")]
	public unsafe bool AnimationContextIsValid(int CurrentAnimationRef)
	{
		CheckDestroyed();
		if (!AnimationContextIsValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:AnimationContextIsValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimationContextIsValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimationContextIsValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AnimationContextIsValid_CurrentAnimationRef_Offset), 0, AnimationContextIsValid_CurrentAnimationRef_PropertyAddress.Address, CurrentAnimationRef);
		NativeReflection.InvokeFunctionOptimized(base.Address, AnimationContextIsValid_FunctionAddress, intPtr, AnimationContextIsValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AnimationContextIsValid_ReturnValue_Offset), 0, AnimationContextIsValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:AnimationCalculationsAccepted")]
	public unsafe bool AnimationCalculationsAccepted(int Ref)
	{
		CheckDestroyed();
		if (!AnimationCalculationsAccepted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:AnimationCalculationsAccepted");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimationCalculationsAccepted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimationCalculationsAccepted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AnimationCalculationsAccepted_Ref_Offset), 0, AnimationCalculationsAccepted_Ref_PropertyAddress.Address, Ref);
		NativeReflection.InvokeFunctionOptimized(base.Address, AnimationCalculationsAccepted_FunctionAddress, intPtr, AnimationCalculationsAccepted_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AnimationCalculationsAccepted_ReturnValue_Offset), 0, AnimationCalculationsAccepted_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MM.AnimationAnalyzer:AnalyzerAnimationReferences")]
	public unsafe void AnalyzerAnimationReferences(int CurrentReferenceAnimation)
	{
		CheckDestroyed();
		if (!AnalyzerAnimationReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.AnimationAnalyzer:AnalyzerAnimationReferences");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnalyzerAnimationReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnalyzerAnimationReferences_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AnalyzerAnimationReferences_CurrentReferenceAnimation_Offset), 0, AnalyzerAnimationReferences_CurrentReferenceAnimation_PropertyAddress.Address, CurrentReferenceAnimation);
		NativeReflection.InvokeFunctionOptimized(base.Address, AnalyzerAnimationReferences_FunctionAddress, intPtr, AnalyzerAnimationReferences_ParamsSize);
	}

	static UAnimationAnalyzer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimationAnalyzer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimationAnalyzer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MM.AnimationAnalyzer");
		LastMatchedAnimIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LastMatchedAnimIndex");
		LastMatchedAnimIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LastMatchedAnimIndex", Classes.FIntProperty);
		ControllerInputReactionSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControllerInputReactionSpeed");
		ControllerInputReactionSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControllerInputReactionSpeed", Classes.FFloatProperty);
		ControllerRotateReactionSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControllerRotateReactionSpeed");
		ControllerRotateReactionSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControllerRotateReactionSpeed", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MMKDTree_PropertyAddress, intPtr, "MMKDTree");
		MMKDTree_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MMKDTree");
		MMKDTree_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MMKDTree", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimationReferences_PropertyAddress, intPtr, "AnimationReferences");
		AnimationReferences_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimationReferences");
		AnimationReferences_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimationReferences", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ReferencedJoints_PropertyAddress, intPtr, "ReferencedJoints");
		ReferencedJoints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReferencedJoints");
		ReferencedJoints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReferencedJoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref JointWeights_PropertyAddress, intPtr, "JointWeights");
		JointWeights_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JointWeights");
		JointWeights_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JointWeights", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimationsInMemory_PropertyAddress, intPtr, "AnimationsInMemory");
		AnimationsInMemory_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimationsInMemory");
		AnimationsInMemory_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimationsInMemory", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimationSeqSoftDatas_PropertyAddress, intPtr, "AnimationSeqSoftDatas");
		AnimationSeqSoftDatas_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimationSeqSoftDatas");
		AnimationSeqSoftDatas_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimationSeqSoftDatas", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UsingAssetSoftRef_PropertyAddress, intPtr, "bUsingAssetSoftRef");
		UsingAssetSoftRef_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUsingAssetSoftRef");
		UsingAssetSoftRef_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUsingAssetSoftRef", Classes.FBoolProperty);
		TryInitFromAA_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TryInitFromAA");
		TryInitFromAA_ParamsSize = NativeReflection.GetFunctionParamsSize(TryInitFromAA_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryInitFromAA_OrgAA_PropertyAddress, TryInitFromAA_FunctionAddress, "OrgAA");
		TryInitFromAA_OrgAA_Offset = NativeReflectionCached.GetPropertyOffset(TryInitFromAA_FunctionAddress, "OrgAA");
		TryInitFromAA_OrgAA_IsValid = NativeReflectionCached.ValidatePropertyClass(TryInitFromAA_FunctionAddress, "OrgAA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TryInitFromAA_ReturnValue_PropertyAddress, TryInitFromAA_FunctionAddress, "ReturnValue");
		TryInitFromAA_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryInitFromAA_FunctionAddress, "ReturnValue");
		TryInitFromAA_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryInitFromAA_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TryInitFromAA_IsValid = TryInitFromAA_FunctionAddress != IntPtr.Zero && TryInitFromAA_OrgAA_IsValid && TryInitFromAA_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:TryInitFromAA", TryInitFromAA_IsValid);
		StructureForAnimationCalculations_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StructureForAnimationCalculations");
		StructureForAnimationCalculations_ParamsSize = NativeReflection.GetFunctionParamsSize(StructureForAnimationCalculations_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StructureForAnimationCalculations_ControllerInputReactionSpeedCustom_PropertyAddress, StructureForAnimationCalculations_FunctionAddress, "ControllerInputReactionSpeedCustom");
		StructureForAnimationCalculations_ControllerInputReactionSpeedCustom_Offset = NativeReflectionCached.GetPropertyOffset(StructureForAnimationCalculations_FunctionAddress, "ControllerInputReactionSpeedCustom");
		StructureForAnimationCalculations_ControllerInputReactionSpeedCustom_IsValid = NativeReflectionCached.ValidatePropertyClass(StructureForAnimationCalculations_FunctionAddress, "ControllerInputReactionSpeedCustom", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StructureForAnimationCalculations_ControllerRotateReactionSpeedCustom_PropertyAddress, StructureForAnimationCalculations_FunctionAddress, "ControllerRotateReactionSpeedCustom");
		StructureForAnimationCalculations_ControllerRotateReactionSpeedCustom_Offset = NativeReflectionCached.GetPropertyOffset(StructureForAnimationCalculations_FunctionAddress, "ControllerRotateReactionSpeedCustom");
		StructureForAnimationCalculations_ControllerRotateReactionSpeedCustom_IsValid = NativeReflectionCached.ValidatePropertyClass(StructureForAnimationCalculations_FunctionAddress, "ControllerRotateReactionSpeedCustom", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StructureForAnimationCalculations_VelocityStrength_PropertyAddress, StructureForAnimationCalculations_FunctionAddress, "VelocityStrength");
		StructureForAnimationCalculations_VelocityStrength_Offset = NativeReflectionCached.GetPropertyOffset(StructureForAnimationCalculations_FunctionAddress, "VelocityStrength");
		StructureForAnimationCalculations_VelocityStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(StructureForAnimationCalculations_FunctionAddress, "VelocityStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StructureForAnimationCalculations_AnimationMatchPower_PropertyAddress, StructureForAnimationCalculations_FunctionAddress, "AnimationMatchPower");
		StructureForAnimationCalculations_AnimationMatchPower_Offset = NativeReflectionCached.GetPropertyOffset(StructureForAnimationCalculations_FunctionAddress, "AnimationMatchPower");
		StructureForAnimationCalculations_AnimationMatchPower_IsValid = NativeReflectionCached.ValidatePropertyClass(StructureForAnimationCalculations_FunctionAddress, "AnimationMatchPower", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StructureForAnimationCalculations_InputDirection_PropertyAddress, StructureForAnimationCalculations_FunctionAddress, "InputDirection");
		StructureForAnimationCalculations_InputDirection_Offset = NativeReflectionCached.GetPropertyOffset(StructureForAnimationCalculations_FunctionAddress, "InputDirection");
		StructureForAnimationCalculations_InputDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(StructureForAnimationCalculations_FunctionAddress, "InputDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StructureForAnimationCalculations_AllAnimationReferences_PropertyAddress, StructureForAnimationCalculations_FunctionAddress, "AllAnimationReferences");
		StructureForAnimationCalculations_AllAnimationReferences_Offset = NativeReflectionCached.GetPropertyOffset(StructureForAnimationCalculations_FunctionAddress, "AllAnimationReferences");
		StructureForAnimationCalculations_AllAnimationReferences_IsValid = NativeReflectionCached.ValidatePropertyClass(StructureForAnimationCalculations_FunctionAddress, "AllAnimationReferences", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref StructureForAnimationCalculations_PresentVel_PropertyAddress, StructureForAnimationCalculations_FunctionAddress, "PresentVel");
		StructureForAnimationCalculations_PresentVel_Offset = NativeReflectionCached.GetPropertyOffset(StructureForAnimationCalculations_FunctionAddress, "PresentVel");
		StructureForAnimationCalculations_PresentVel_IsValid = NativeReflectionCached.ValidatePropertyClass(StructureForAnimationCalculations_FunctionAddress, "PresentVel", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StructureForAnimationCalculations_BlendTime_PropertyAddress, StructureForAnimationCalculations_FunctionAddress, "BlendTime");
		StructureForAnimationCalculations_BlendTime_Offset = NativeReflectionCached.GetPropertyOffset(StructureForAnimationCalculations_FunctionAddress, "BlendTime");
		StructureForAnimationCalculations_BlendTime_IsValid = NativeReflectionCached.ValidatePropertyClass(StructureForAnimationCalculations_FunctionAddress, "BlendTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StructureForAnimationCalculations_CalculatedResult_PropertyAddress, StructureForAnimationCalculations_FunctionAddress, "CalculatedResult");
		StructureForAnimationCalculations_CalculatedResult_Offset = NativeReflectionCached.GetPropertyOffset(StructureForAnimationCalculations_FunctionAddress, "CalculatedResult");
		StructureForAnimationCalculations_CalculatedResult_IsValid = NativeReflectionCached.ValidatePropertyClass(StructureForAnimationCalculations_FunctionAddress, "CalculatedResult", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StructureForAnimationCalculations_AnimCostData_PropertyAddress, StructureForAnimationCalculations_FunctionAddress, "AnimCostData");
		StructureForAnimationCalculations_AnimCostData_Offset = NativeReflectionCached.GetPropertyOffset(StructureForAnimationCalculations_FunctionAddress, "AnimCostData");
		StructureForAnimationCalculations_AnimCostData_IsValid = NativeReflectionCached.ValidatePropertyClass(StructureForAnimationCalculations_FunctionAddress, "AnimCostData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StructureForAnimationCalculations_ReturnValue_PropertyAddress, StructureForAnimationCalculations_FunctionAddress, "ReturnValue");
		StructureForAnimationCalculations_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StructureForAnimationCalculations_FunctionAddress, "ReturnValue");
		StructureForAnimationCalculations_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StructureForAnimationCalculations_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		StructureForAnimationCalculations_IsValid = StructureForAnimationCalculations_FunctionAddress != IntPtr.Zero && StructureForAnimationCalculations_ControllerInputReactionSpeedCustom_IsValid && StructureForAnimationCalculations_ControllerRotateReactionSpeedCustom_IsValid && StructureForAnimationCalculations_VelocityStrength_IsValid && StructureForAnimationCalculations_AnimationMatchPower_IsValid && StructureForAnimationCalculations_InputDirection_IsValid && StructureForAnimationCalculations_AllAnimationReferences_IsValid && StructureForAnimationCalculations_PresentVel_IsValid && StructureForAnimationCalculations_BlendTime_IsValid && StructureForAnimationCalculations_CalculatedResult_IsValid && StructureForAnimationCalculations_AnimCostData_IsValid && StructureForAnimationCalculations_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:StructureForAnimationCalculations", StructureForAnimationCalculations_IsValid);
		SetUseLMAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUseLMAnim");
		SetUseLMAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUseLMAnim_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUseLMAnim_bUse_PropertyAddress, SetUseLMAnim_FunctionAddress, "bUse");
		SetUseLMAnim_bUse_Offset = NativeReflectionCached.GetPropertyOffset(SetUseLMAnim_FunctionAddress, "bUse");
		SetUseLMAnim_bUse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUseLMAnim_FunctionAddress, "bUse", Classes.FBoolProperty);
		SetUseLMAnim_IsValid = SetUseLMAnim_FunctionAddress != IntPtr.Zero && SetUseLMAnim_bUse_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:SetUseLMAnim", SetUseLMAnim_IsValid);
		RequireAnimationsLoadAtDesiredReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RequireAnimationsLoadAtDesiredReferences");
		RequireAnimationsLoadAtDesiredReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(RequireAnimationsLoadAtDesiredReferences_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequireAnimationsLoadAtDesiredReferences_Ref_PropertyAddress, RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "Ref");
		RequireAnimationsLoadAtDesiredReferences_Ref_Offset = NativeReflectionCached.GetPropertyOffset(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "Ref");
		RequireAnimationsLoadAtDesiredReferences_Ref_IsValid = NativeReflectionCached.ValidatePropertyClass(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "Ref", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RequireAnimationsLoadAtDesiredReferences_bLoadAll_PropertyAddress, RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "bLoadAll");
		RequireAnimationsLoadAtDesiredReferences_bLoadAll_Offset = NativeReflectionCached.GetPropertyOffset(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "bLoadAll");
		RequireAnimationsLoadAtDesiredReferences_bLoadAll_IsValid = NativeReflectionCached.ValidatePropertyClass(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "bLoadAll", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequireAnimationsLoadAtDesiredReferences_AnimInst_PropertyAddress, RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "AnimInst");
		RequireAnimationsLoadAtDesiredReferences_AnimInst_Offset = NativeReflectionCached.GetPropertyOffset(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "AnimInst");
		RequireAnimationsLoadAtDesiredReferences_AnimInst_IsValid = NativeReflectionCached.ValidatePropertyClass(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "AnimInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RequireAnimationsLoadAtDesiredReferences_ReturnValue_PropertyAddress, RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "ReturnValue");
		RequireAnimationsLoadAtDesiredReferences_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "ReturnValue");
		RequireAnimationsLoadAtDesiredReferences_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RequireAnimationsLoadAtDesiredReferences_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		RequireAnimationsLoadAtDesiredReferences_IsValid = RequireAnimationsLoadAtDesiredReferences_FunctionAddress != IntPtr.Zero && RequireAnimationsLoadAtDesiredReferences_Ref_IsValid && RequireAnimationsLoadAtDesiredReferences_bLoadAll_IsValid && RequireAnimationsLoadAtDesiredReferences_AnimInst_IsValid && RequireAnimationsLoadAtDesiredReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:RequireAnimationsLoadAtDesiredReferences", RequireAnimationsLoadAtDesiredReferences_IsValid);
		RemoveAnimationReference_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveAnimationReference");
		RemoveAnimationReference_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAnimationReference_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimationReference_CurrentAnimationRef_PropertyAddress, RemoveAnimationReference_FunctionAddress, "CurrentAnimationRef");
		RemoveAnimationReference_CurrentAnimationRef_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimationReference_FunctionAddress, "CurrentAnimationRef");
		RemoveAnimationReference_CurrentAnimationRef_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimationReference_FunctionAddress, "CurrentAnimationRef", Classes.FIntProperty);
		RemoveAnimationReference_IsValid = RemoveAnimationReference_FunctionAddress != IntPtr.Zero && RemoveAnimationReference_CurrentAnimationRef_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:RemoveAnimationReference", RemoveAnimationReference_IsValid);
		OnAnimationAssetLoadStatChange_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAnimationAssetLoadStatChange");
		OnAnimationAssetLoadStatChange_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAnimationAssetLoadStatChange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAnimationAssetLoadStatChange_Ref_PropertyAddress, OnAnimationAssetLoadStatChange_FunctionAddress, "Ref");
		OnAnimationAssetLoadStatChange_Ref_Offset = NativeReflectionCached.GetPropertyOffset(OnAnimationAssetLoadStatChange_FunctionAddress, "Ref");
		OnAnimationAssetLoadStatChange_Ref_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAnimationAssetLoadStatChange_FunctionAddress, "Ref", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OnAnimationAssetLoadStatChange_Stat_PropertyAddress, OnAnimationAssetLoadStatChange_FunctionAddress, "Stat");
		OnAnimationAssetLoadStatChange_Stat_Offset = NativeReflectionCached.GetPropertyOffset(OnAnimationAssetLoadStatChange_FunctionAddress, "Stat");
		OnAnimationAssetLoadStatChange_Stat_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAnimationAssetLoadStatChange_FunctionAddress, "Stat", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OnAnimationAssetLoadStatChange_Anim_PropertyAddress, OnAnimationAssetLoadStatChange_FunctionAddress, "Anim");
		OnAnimationAssetLoadStatChange_Anim_Offset = NativeReflectionCached.GetPropertyOffset(OnAnimationAssetLoadStatChange_FunctionAddress, "Anim");
		OnAnimationAssetLoadStatChange_Anim_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAnimationAssetLoadStatChange_FunctionAddress, "Anim", Classes.FObjectProperty);
		OnAnimationAssetLoadStatChange_IsValid = OnAnimationAssetLoadStatChange_FunctionAddress != IntPtr.Zero && OnAnimationAssetLoadStatChange_Ref_IsValid && OnAnimationAssetLoadStatChange_Stat_IsValid && OnAnimationAssetLoadStatChange_Anim_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:OnAnimationAssetLoadStatChange", OnAnimationAssetLoadStatChange_IsValid);
		NewAnimationReference_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NewAnimationReference");
		NewAnimationReference_ParamsSize = NativeReflection.GetFunctionParamsSize(NewAnimationReference_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NewAnimationReference_ProvidedAnimationsByUser_PropertyAddress, NewAnimationReference_FunctionAddress, "ProvidedAnimationsByUser");
		NewAnimationReference_ProvidedAnimationsByUser_Offset = NativeReflectionCached.GetPropertyOffset(NewAnimationReference_FunctionAddress, "ProvidedAnimationsByUser");
		NewAnimationReference_ProvidedAnimationsByUser_IsValid = NativeReflectionCached.ValidatePropertyClass(NewAnimationReference_FunctionAddress, "ProvidedAnimationsByUser", Classes.FArrayProperty);
		NewAnimationReference_IsValid = NewAnimationReference_FunctionAddress != IntPtr.Zero && NewAnimationReference_ProvidedAnimationsByUser_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:NewAnimationReference", NewAnimationReference_IsValid);
		MMAnimationSeqUsingNotify_Inner_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MMAnimationSeqUsingNotify_Inner");
		MMAnimationSeqUsingNotify_Inner_ParamsSize = NativeReflection.GetFunctionParamsSize(MMAnimationSeqUsingNotify_Inner_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MMAnimationSeqUsingNotify_Inner_Ref_PropertyAddress, MMAnimationSeqUsingNotify_Inner_FunctionAddress, "Ref");
		MMAnimationSeqUsingNotify_Inner_Ref_Offset = NativeReflectionCached.GetPropertyOffset(MMAnimationSeqUsingNotify_Inner_FunctionAddress, "Ref");
		MMAnimationSeqUsingNotify_Inner_Ref_IsValid = NativeReflectionCached.ValidatePropertyClass(MMAnimationSeqUsingNotify_Inner_FunctionAddress, "Ref", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MMAnimationSeqUsingNotify_Inner_owner_PropertyAddress, MMAnimationSeqUsingNotify_Inner_FunctionAddress, "owner");
		MMAnimationSeqUsingNotify_Inner_owner_Offset = NativeReflectionCached.GetPropertyOffset(MMAnimationSeqUsingNotify_Inner_FunctionAddress, "owner");
		MMAnimationSeqUsingNotify_Inner_owner_IsValid = NativeReflectionCached.ValidatePropertyClass(MMAnimationSeqUsingNotify_Inner_FunctionAddress, "owner", Classes.FObjectProperty);
		MMAnimationSeqUsingNotify_Inner_IsValid = MMAnimationSeqUsingNotify_Inner_FunctionAddress != IntPtr.Zero && MMAnimationSeqUsingNotify_Inner_Ref_IsValid && MMAnimationSeqUsingNotify_Inner_owner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:MMAnimationSeqUsingNotify_Inner", MMAnimationSeqUsingNotify_Inner_IsValid);
		MatchAnimationByKDTree_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MatchAnimationByKDTree");
		MatchAnimationByKDTree_ParamsSize = NativeReflection.GetFunctionParamsSize(MatchAnimationByKDTree_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MatchAnimationByKDTree_VelocityStrength_PropertyAddress, MatchAnimationByKDTree_FunctionAddress, "VelocityStrength");
		MatchAnimationByKDTree_VelocityStrength_Offset = NativeReflectionCached.GetPropertyOffset(MatchAnimationByKDTree_FunctionAddress, "VelocityStrength");
		MatchAnimationByKDTree_VelocityStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchAnimationByKDTree_FunctionAddress, "VelocityStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchAnimationByKDTree_InputDirection_PropertyAddress, MatchAnimationByKDTree_FunctionAddress, "InputDirection");
		MatchAnimationByKDTree_InputDirection_Offset = NativeReflectionCached.GetPropertyOffset(MatchAnimationByKDTree_FunctionAddress, "InputDirection");
		MatchAnimationByKDTree_InputDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchAnimationByKDTree_FunctionAddress, "InputDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchAnimationByKDTree_MotionJointData_PropertyAddress, MatchAnimationByKDTree_FunctionAddress, "MotionJointData");
		MatchAnimationByKDTree_MotionJointData_Offset = NativeReflectionCached.GetPropertyOffset(MatchAnimationByKDTree_FunctionAddress, "MotionJointData");
		MatchAnimationByKDTree_MotionJointData_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchAnimationByKDTree_FunctionAddress, "MotionJointData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchAnimationByKDTree_PresentVel_PropertyAddress, MatchAnimationByKDTree_FunctionAddress, "PresentVel");
		MatchAnimationByKDTree_PresentVel_Offset = NativeReflectionCached.GetPropertyOffset(MatchAnimationByKDTree_FunctionAddress, "PresentVel");
		MatchAnimationByKDTree_PresentVel_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchAnimationByKDTree_FunctionAddress, "PresentVel", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchAnimationByKDTree_MinSquareDis_PropertyAddress, MatchAnimationByKDTree_FunctionAddress, "MinSquareDis");
		MatchAnimationByKDTree_MinSquareDis_Offset = NativeReflectionCached.GetPropertyOffset(MatchAnimationByKDTree_FunctionAddress, "MinSquareDis");
		MatchAnimationByKDTree_MinSquareDis_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchAnimationByKDTree_FunctionAddress, "MinSquareDis", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchAnimationByKDTree_ReturnValue_PropertyAddress, MatchAnimationByKDTree_FunctionAddress, "ReturnValue");
		MatchAnimationByKDTree_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MatchAnimationByKDTree_FunctionAddress, "ReturnValue");
		MatchAnimationByKDTree_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchAnimationByKDTree_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		MatchAnimationByKDTree_IsValid = MatchAnimationByKDTree_FunctionAddress != IntPtr.Zero && MatchAnimationByKDTree_VelocityStrength_IsValid && MatchAnimationByKDTree_InputDirection_IsValid && MatchAnimationByKDTree_MotionJointData_IsValid && MatchAnimationByKDTree_PresentVel_IsValid && MatchAnimationByKDTree_MinSquareDis_IsValid && MatchAnimationByKDTree_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:MatchAnimationByKDTree", MatchAnimationByKDTree_IsValid);
		LoadAllAnimSeqFromSoftRefForCalculatingInEditor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LoadAllAnimSeqFromSoftRefForCalculatingInEditor");
		LoadAllAnimSeqFromSoftRefForCalculatingInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadAllAnimSeqFromSoftRefForCalculatingInEditor_FunctionAddress);
		LoadAllAnimSeqFromSoftRefForCalculatingInEditor_IsValid = LoadAllAnimSeqFromSoftRefForCalculatingInEditor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:LoadAllAnimSeqFromSoftRefForCalculatingInEditor", LoadAllAnimSeqFromSoftRefForCalculatingInEditor_IsValid);
		IsUseLMAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsUseLMAnim");
		IsUseLMAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(IsUseLMAnim_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsUseLMAnim_ReturnValue_PropertyAddress, IsUseLMAnim_FunctionAddress, "ReturnValue");
		IsUseLMAnim_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsUseLMAnim_FunctionAddress, "ReturnValue");
		IsUseLMAnim_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsUseLMAnim_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsUseLMAnim_IsValid = IsUseLMAnim_FunctionAddress != IntPtr.Zero && IsUseLMAnim_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:IsUseLMAnim", IsUseLMAnim_IsValid);
		IsBoneSelected_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsBoneSelected");
		IsBoneSelected_ParamsSize = NativeReflection.GetFunctionParamsSize(IsBoneSelected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsBoneSelected_boneName_PropertyAddress, IsBoneSelected_FunctionAddress, "boneName");
		IsBoneSelected_boneName_Offset = NativeReflectionCached.GetPropertyOffset(IsBoneSelected_FunctionAddress, "boneName");
		IsBoneSelected_boneName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBoneSelected_FunctionAddress, "boneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsBoneSelected_ReturnValue_PropertyAddress, IsBoneSelected_FunctionAddress, "ReturnValue");
		IsBoneSelected_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsBoneSelected_FunctionAddress, "ReturnValue");
		IsBoneSelected_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBoneSelected_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsBoneSelected_IsValid = IsBoneSelected_FunctionAddress != IntPtr.Zero && IsBoneSelected_boneName_IsValid && IsBoneSelected_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:IsBoneSelected", IsBoneSelected_IsValid);
		IsAnimMathDataValid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsAnimMathDataValid");
		IsAnimMathDataValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAnimMathDataValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAnimMathDataValid_ReturnValue_PropertyAddress, IsAnimMathDataValid_FunctionAddress, "ReturnValue");
		IsAnimMathDataValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAnimMathDataValid_FunctionAddress, "ReturnValue");
		IsAnimMathDataValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAnimMathDataValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAnimMathDataValid_IsValid = IsAnimMathDataValid_FunctionAddress != IntPtr.Zero && IsAnimMathDataValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:IsAnimMathDataValid", IsAnimMathDataValid_IsValid);
		IsAnimationExtracted_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsAnimationExtracted");
		IsAnimationExtracted_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAnimationExtracted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAnimationExtracted_AnimationRef_PropertyAddress, IsAnimationExtracted_FunctionAddress, "AnimationRef");
		IsAnimationExtracted_AnimationRef_Offset = NativeReflectionCached.GetPropertyOffset(IsAnimationExtracted_FunctionAddress, "AnimationRef");
		IsAnimationExtracted_AnimationRef_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAnimationExtracted_FunctionAddress, "AnimationRef", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAnimationExtracted_WorldTime_PropertyAddress, IsAnimationExtracted_FunctionAddress, "WorldTime");
		IsAnimationExtracted_WorldTime_Offset = NativeReflectionCached.GetPropertyOffset(IsAnimationExtracted_FunctionAddress, "WorldTime");
		IsAnimationExtracted_WorldTime_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAnimationExtracted_FunctionAddress, "WorldTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAnimationExtracted_ReturnValue_PropertyAddress, IsAnimationExtracted_FunctionAddress, "ReturnValue");
		IsAnimationExtracted_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAnimationExtracted_FunctionAddress, "ReturnValue");
		IsAnimationExtracted_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAnimationExtracted_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAnimationExtracted_IsValid = IsAnimationExtracted_FunctionAddress != IntPtr.Zero && IsAnimationExtracted_AnimationRef_IsValid && IsAnimationExtracted_WorldTime_IsValid && IsAnimationExtracted_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:IsAnimationExtracted", IsAnimationExtracted_IsValid);
		InitAnimMathDataBySerializedFeatures_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitAnimMathDataBySerializedFeatures");
		InitAnimMathDataBySerializedFeatures_ParamsSize = NativeReflection.GetFunctionParamsSize(InitAnimMathDataBySerializedFeatures_FunctionAddress);
		InitAnimMathDataBySerializedFeatures_IsValid = InitAnimMathDataBySerializedFeatures_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:InitAnimMathDataBySerializedFeatures", InitAnimMathDataBySerializedFeatures_IsValid);
		HasSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasSequence");
		HasSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(HasSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasSequence_SequenceName_PropertyAddress, HasSequence_FunctionAddress, "SequenceName");
		HasSequence_SequenceName_Offset = NativeReflectionCached.GetPropertyOffset(HasSequence_FunctionAddress, "SequenceName");
		HasSequence_SequenceName_IsValid = NativeReflectionCached.ValidatePropertyClass(HasSequence_FunctionAddress, "SequenceName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref HasSequence_ReturnValue_PropertyAddress, HasSequence_FunctionAddress, "ReturnValue");
		HasSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasSequence_FunctionAddress, "ReturnValue");
		HasSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasSequence_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasSequence_IsValid = HasSequence_FunctionAddress != IntPtr.Zero && HasSequence_SequenceName_IsValid && HasSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:HasSequence", HasSequence_IsValid);
		GetSoftPathByIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSoftPathByIndex");
		GetSoftPathByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftPathByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSoftPathByIndex_Ref_PropertyAddress, GetSoftPathByIndex_FunctionAddress, "Ref");
		GetSoftPathByIndex_Ref_Offset = NativeReflectionCached.GetPropertyOffset(GetSoftPathByIndex_FunctionAddress, "Ref");
		GetSoftPathByIndex_Ref_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSoftPathByIndex_FunctionAddress, "Ref", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSoftPathByIndex_ReturnValue_PropertyAddress, GetSoftPathByIndex_FunctionAddress, "ReturnValue");
		GetSoftPathByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSoftPathByIndex_FunctionAddress, "ReturnValue");
		GetSoftPathByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSoftPathByIndex_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSoftPathByIndex_IsValid = GetSoftPathByIndex_FunctionAddress != IntPtr.Zero && GetSoftPathByIndex_Ref_IsValid && GetSoftPathByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:GetSoftPathByIndex", GetSoftPathByIndex_IsValid);
		GetSequenceTimeOfAnimations_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSequenceTimeOfAnimations");
		GetSequenceTimeOfAnimations_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequenceTimeOfAnimations_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequenceTimeOfAnimations_CurrentAnimationKeyframe_PropertyAddress, GetSequenceTimeOfAnimations_FunctionAddress, "CurrentAnimationKeyframe");
		GetSequenceTimeOfAnimations_CurrentAnimationKeyframe_Offset = NativeReflectionCached.GetPropertyOffset(GetSequenceTimeOfAnimations_FunctionAddress, "CurrentAnimationKeyframe");
		GetSequenceTimeOfAnimations_CurrentAnimationKeyframe_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequenceTimeOfAnimations_FunctionAddress, "CurrentAnimationKeyframe", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSequenceTimeOfAnimations_ReturnValue_PropertyAddress, GetSequenceTimeOfAnimations_FunctionAddress, "ReturnValue");
		GetSequenceTimeOfAnimations_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequenceTimeOfAnimations_FunctionAddress, "ReturnValue");
		GetSequenceTimeOfAnimations_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequenceTimeOfAnimations_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSequenceTimeOfAnimations_IsValid = GetSequenceTimeOfAnimations_FunctionAddress != IntPtr.Zero && GetSequenceTimeOfAnimations_CurrentAnimationKeyframe_IsValid && GetSequenceTimeOfAnimations_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:GetSequenceTimeOfAnimations", GetSequenceTimeOfAnimations_IsValid);
		GetAnimationShowNameInEditor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimationShowNameInEditor");
		GetAnimationShowNameInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationShowNameInEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationShowNameInEditor_Ref_PropertyAddress, GetAnimationShowNameInEditor_FunctionAddress, "Ref");
		GetAnimationShowNameInEditor_Ref_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationShowNameInEditor_FunctionAddress, "Ref");
		GetAnimationShowNameInEditor_Ref_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationShowNameInEditor_FunctionAddress, "Ref", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationShowNameInEditor_ReturnValue_PropertyAddress, GetAnimationShowNameInEditor_FunctionAddress, "ReturnValue");
		GetAnimationShowNameInEditor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationShowNameInEditor_FunctionAddress, "ReturnValue");
		GetAnimationShowNameInEditor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationShowNameInEditor_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetAnimationShowNameInEditor_IsValid = GetAnimationShowNameInEditor_FunctionAddress != IntPtr.Zero && GetAnimationShowNameInEditor_Ref_IsValid && GetAnimationShowNameInEditor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:GetAnimationShowNameInEditor", GetAnimationShowNameInEditor_IsValid);
		GetAnimationCount_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimationCount");
		GetAnimationCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationCount_ReturnValue_PropertyAddress, GetAnimationCount_FunctionAddress, "ReturnValue");
		GetAnimationCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationCount_FunctionAddress, "ReturnValue");
		GetAnimationCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetAnimationCount_IsValid = GetAnimationCount_FunctionAddress != IntPtr.Zero && GetAnimationCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:GetAnimationCount", GetAnimationCount_IsValid);
		GetAnimationAnalyzerSkeleton_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimationAnalyzerSkeleton");
		GetAnimationAnalyzerSkeleton_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationAnalyzerSkeleton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationAnalyzerSkeleton_ReturnValue_PropertyAddress, GetAnimationAnalyzerSkeleton_FunctionAddress, "ReturnValue");
		GetAnimationAnalyzerSkeleton_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationAnalyzerSkeleton_FunctionAddress, "ReturnValue");
		GetAnimationAnalyzerSkeleton_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationAnalyzerSkeleton_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAnimationAnalyzerSkeleton_IsValid = GetAnimationAnalyzerSkeleton_FunctionAddress != IntPtr.Zero && GetAnimationAnalyzerSkeleton_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:GetAnimationAnalyzerSkeleton", GetAnimationAnalyzerSkeleton_IsValid);
		GatherSkeletonInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GatherSkeletonInfo");
		GatherSkeletonInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GatherSkeletonInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GatherSkeletonInfo_UserSkeleton_PropertyAddress, GatherSkeletonInfo_FunctionAddress, "UserSkeleton");
		GatherSkeletonInfo_UserSkeleton_Offset = NativeReflectionCached.GetPropertyOffset(GatherSkeletonInfo_FunctionAddress, "UserSkeleton");
		GatherSkeletonInfo_UserSkeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(GatherSkeletonInfo_FunctionAddress, "UserSkeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GatherSkeletonInfo_SelectedJoints_PropertyAddress, GatherSkeletonInfo_FunctionAddress, "SelectedJoints");
		GatherSkeletonInfo_SelectedJoints_Offset = NativeReflectionCached.GetPropertyOffset(GatherSkeletonInfo_FunctionAddress, "SelectedJoints");
		GatherSkeletonInfo_SelectedJoints_IsValid = NativeReflectionCached.ValidatePropertyClass(GatherSkeletonInfo_FunctionAddress, "SelectedJoints", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GatherSkeletonInfo_BoneWeights_PropertyAddress, GatherSkeletonInfo_FunctionAddress, "BoneWeights");
		GatherSkeletonInfo_BoneWeights_Offset = NativeReflectionCached.GetPropertyOffset(GatherSkeletonInfo_FunctionAddress, "BoneWeights");
		GatherSkeletonInfo_BoneWeights_IsValid = NativeReflectionCached.ValidatePropertyClass(GatherSkeletonInfo_FunctionAddress, "BoneWeights", Classes.FArrayProperty);
		GatherSkeletonInfo_IsValid = GatherSkeletonInfo_FunctionAddress != IntPtr.Zero && GatherSkeletonInfo_UserSkeleton_IsValid && GatherSkeletonInfo_SelectedJoints_IsValid && GatherSkeletonInfo_BoneWeights_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:GatherSkeletonInfo", GatherSkeletonInfo_IsValid);
		FindUsersSkeletonBoneNames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindUsersSkeletonBoneNames");
		FindUsersSkeletonBoneNames_ParamsSize = NativeReflection.GetFunctionParamsSize(FindUsersSkeletonBoneNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindUsersSkeletonBoneNames_ReferencedBone_PropertyAddress, FindUsersSkeletonBoneNames_FunctionAddress, "ReferencedBone");
		FindUsersSkeletonBoneNames_ReferencedBone_Offset = NativeReflectionCached.GetPropertyOffset(FindUsersSkeletonBoneNames_FunctionAddress, "ReferencedBone");
		FindUsersSkeletonBoneNames_ReferencedBone_IsValid = NativeReflectionCached.ValidatePropertyClass(FindUsersSkeletonBoneNames_FunctionAddress, "ReferencedBone", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FindUsersSkeletonBoneNames_ReturnValue_PropertyAddress, FindUsersSkeletonBoneNames_FunctionAddress, "ReturnValue");
		FindUsersSkeletonBoneNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindUsersSkeletonBoneNames_FunctionAddress, "ReturnValue");
		FindUsersSkeletonBoneNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindUsersSkeletonBoneNames_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		FindUsersSkeletonBoneNames_IsValid = FindUsersSkeletonBoneNames_FunctionAddress != IntPtr.Zero && FindUsersSkeletonBoneNames_ReferencedBone_IsValid && FindUsersSkeletonBoneNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:FindUsersSkeletonBoneNames", FindUsersSkeletonBoneNames_IsValid);
		FindUserSelectedBones_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindUserSelectedBones");
		FindUserSelectedBones_ParamsSize = NativeReflection.GetFunctionParamsSize(FindUserSelectedBones_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindUserSelectedBones_ReturnValue_PropertyAddress, FindUserSelectedBones_FunctionAddress, "ReturnValue");
		FindUserSelectedBones_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindUserSelectedBones_FunctionAddress, "ReturnValue");
		FindUserSelectedBones_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindUserSelectedBones_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		FindUserSelectedBones_IsValid = FindUserSelectedBones_FunctionAddress != IntPtr.Zero && FindUserSelectedBones_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:FindUserSelectedBones", FindUserSelectedBones_IsValid);
		FindAnimationsAtDesiredReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindAnimationsAtDesiredReferences");
		FindAnimationsAtDesiredReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(FindAnimationsAtDesiredReferences_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindAnimationsAtDesiredReferences_Ref_PropertyAddress, FindAnimationsAtDesiredReferences_FunctionAddress, "Ref");
		FindAnimationsAtDesiredReferences_Ref_Offset = NativeReflectionCached.GetPropertyOffset(FindAnimationsAtDesiredReferences_FunctionAddress, "Ref");
		FindAnimationsAtDesiredReferences_Ref_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAnimationsAtDesiredReferences_FunctionAddress, "Ref", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FindAnimationsAtDesiredReferences_ReturnValue_PropertyAddress, FindAnimationsAtDesiredReferences_FunctionAddress, "ReturnValue");
		FindAnimationsAtDesiredReferences_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindAnimationsAtDesiredReferences_FunctionAddress, "ReturnValue");
		FindAnimationsAtDesiredReferences_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAnimationsAtDesiredReferences_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindAnimationsAtDesiredReferences_IsValid = FindAnimationsAtDesiredReferences_FunctionAddress != IntPtr.Zero && FindAnimationsAtDesiredReferences_Ref_IsValid && FindAnimationsAtDesiredReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:FindAnimationsAtDesiredReferences", FindAnimationsAtDesiredReferences_IsValid);
		FindAnimationFromSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindAnimationFromSequence");
		FindAnimationFromSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(FindAnimationFromSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindAnimationFromSequence_CurrentAnimationRef_PropertyAddress, FindAnimationFromSequence_FunctionAddress, "CurrentAnimationRef");
		FindAnimationFromSequence_CurrentAnimationRef_Offset = NativeReflectionCached.GetPropertyOffset(FindAnimationFromSequence_FunctionAddress, "CurrentAnimationRef");
		FindAnimationFromSequence_CurrentAnimationRef_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAnimationFromSequence_FunctionAddress, "CurrentAnimationRef", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FindAnimationFromSequence_ReturnValue_PropertyAddress, FindAnimationFromSequence_FunctionAddress, "ReturnValue");
		FindAnimationFromSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindAnimationFromSequence_FunctionAddress, "ReturnValue");
		FindAnimationFromSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAnimationFromSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindAnimationFromSequence_IsValid = FindAnimationFromSequence_FunctionAddress != IntPtr.Zero && FindAnimationFromSequence_CurrentAnimationRef_IsValid && FindAnimationFromSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:FindAnimationFromSequence", FindAnimationFromSequence_IsValid);
		CountAnimationReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CountAnimationReferences");
		CountAnimationReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(CountAnimationReferences_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CountAnimationReferences_ReturnValue_PropertyAddress, CountAnimationReferences_FunctionAddress, "ReturnValue");
		CountAnimationReferences_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CountAnimationReferences_FunctionAddress, "ReturnValue");
		CountAnimationReferences_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CountAnimationReferences_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		CountAnimationReferences_IsValid = CountAnimationReferences_FunctionAddress != IntPtr.Zero && CountAnimationReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:CountAnimationReferences", CountAnimationReferences_IsValid);
		ConstructSerializedFeatures_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConstructSerializedFeatures");
		ConstructSerializedFeatures_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstructSerializedFeatures_FunctionAddress);
		ConstructSerializedFeatures_IsValid = ConstructSerializedFeatures_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:ConstructSerializedFeatures", ConstructSerializedFeatures_IsValid);
		ConstructAnimationReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConstructAnimationReferences");
		ConstructAnimationReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstructAnimationReferences_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConstructAnimationReferences_FromSourceAnimation_PropertyAddress, ConstructAnimationReferences_FunctionAddress, "FromSourceAnimation");
		ConstructAnimationReferences_FromSourceAnimation_Offset = NativeReflectionCached.GetPropertyOffset(ConstructAnimationReferences_FunctionAddress, "FromSourceAnimation");
		ConstructAnimationReferences_FromSourceAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstructAnimationReferences_FunctionAddress, "FromSourceAnimation", Classes.FIntProperty);
		ConstructAnimationReferences_IsValid = ConstructAnimationReferences_FunctionAddress != IntPtr.Zero && ConstructAnimationReferences_FromSourceAnimation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:ConstructAnimationReferences", ConstructAnimationReferences_IsValid);
		ConstructAllAnimationReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConstructAllAnimationReferences");
		ConstructAllAnimationReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstructAllAnimationReferences_FunctionAddress);
		ConstructAllAnimationReferences_IsValid = ConstructAllAnimationReferences_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:ConstructAllAnimationReferences", ConstructAllAnimationReferences_IsValid);
		ClearAllAnimSeqForCalculatingInEditor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearAllAnimSeqForCalculatingInEditor");
		ClearAllAnimSeqForCalculatingInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAllAnimSeqForCalculatingInEditor_FunctionAddress);
		ClearAllAnimSeqForCalculatingInEditor_IsValid = ClearAllAnimSeqForCalculatingInEditor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:ClearAllAnimSeqForCalculatingInEditor", ClearAllAnimSeqForCalculatingInEditor_IsValid);
		CleanAnimationReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CleanAnimationReferences");
		CleanAnimationReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanAnimationReferences_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CleanAnimationReferences_CurrentReferenceAnimation_PropertyAddress, CleanAnimationReferences_FunctionAddress, "CurrentReferenceAnimation");
		CleanAnimationReferences_CurrentReferenceAnimation_Offset = NativeReflectionCached.GetPropertyOffset(CleanAnimationReferences_FunctionAddress, "CurrentReferenceAnimation");
		CleanAnimationReferences_CurrentReferenceAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(CleanAnimationReferences_FunctionAddress, "CurrentReferenceAnimation", Classes.FIntProperty);
		CleanAnimationReferences_IsValid = CleanAnimationReferences_FunctionAddress != IntPtr.Zero && CleanAnimationReferences_CurrentReferenceAnimation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:CleanAnimationReferences", CleanAnimationReferences_IsValid);
		CleanAllAnimationReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CleanAllAnimationReferences");
		CleanAllAnimationReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanAllAnimationReferences_FunctionAddress);
		CleanAllAnimationReferences_IsValid = CleanAllAnimationReferences_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:CleanAllAnimationReferences", CleanAllAnimationReferences_IsValid);
		CheckIsFirstLoadRequireDesireAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckIsFirstLoadRequireDesireAsset");
		CheckIsFirstLoadRequireDesireAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckIsFirstLoadRequireDesireAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckIsFirstLoadRequireDesireAsset_Ref_PropertyAddress, CheckIsFirstLoadRequireDesireAsset_FunctionAddress, "Ref");
		CheckIsFirstLoadRequireDesireAsset_Ref_Offset = NativeReflectionCached.GetPropertyOffset(CheckIsFirstLoadRequireDesireAsset_FunctionAddress, "Ref");
		CheckIsFirstLoadRequireDesireAsset_Ref_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckIsFirstLoadRequireDesireAsset_FunctionAddress, "Ref", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckIsFirstLoadRequireDesireAsset_ReturnValue_PropertyAddress, CheckIsFirstLoadRequireDesireAsset_FunctionAddress, "ReturnValue");
		CheckIsFirstLoadRequireDesireAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckIsFirstLoadRequireDesireAsset_FunctionAddress, "ReturnValue");
		CheckIsFirstLoadRequireDesireAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckIsFirstLoadRequireDesireAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckIsFirstLoadRequireDesireAsset_IsValid = CheckIsFirstLoadRequireDesireAsset_FunctionAddress != IntPtr.Zero && CheckIsFirstLoadRequireDesireAsset_Ref_IsValid && CheckIsFirstLoadRequireDesireAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:CheckIsFirstLoadRequireDesireAsset", CheckIsFirstLoadRequireDesireAsset_IsValid);
		AnimationReferenceIsValid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AnimationReferenceIsValid");
		AnimationReferenceIsValid_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimationReferenceIsValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimationReferenceIsValid_CurrentAnimationRef_PropertyAddress, AnimationReferenceIsValid_FunctionAddress, "CurrentAnimationRef");
		AnimationReferenceIsValid_CurrentAnimationRef_Offset = NativeReflectionCached.GetPropertyOffset(AnimationReferenceIsValid_FunctionAddress, "CurrentAnimationRef");
		AnimationReferenceIsValid_CurrentAnimationRef_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimationReferenceIsValid_FunctionAddress, "CurrentAnimationRef", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimationReferenceIsValid_ReturnValue_PropertyAddress, AnimationReferenceIsValid_FunctionAddress, "ReturnValue");
		AnimationReferenceIsValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AnimationReferenceIsValid_FunctionAddress, "ReturnValue");
		AnimationReferenceIsValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimationReferenceIsValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AnimationReferenceIsValid_IsValid = AnimationReferenceIsValid_FunctionAddress != IntPtr.Zero && AnimationReferenceIsValid_CurrentAnimationRef_IsValid && AnimationReferenceIsValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:AnimationReferenceIsValid", AnimationReferenceIsValid_IsValid);
		AnimationContextIsValid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AnimationContextIsValid");
		AnimationContextIsValid_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimationContextIsValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimationContextIsValid_CurrentAnimationRef_PropertyAddress, AnimationContextIsValid_FunctionAddress, "CurrentAnimationRef");
		AnimationContextIsValid_CurrentAnimationRef_Offset = NativeReflectionCached.GetPropertyOffset(AnimationContextIsValid_FunctionAddress, "CurrentAnimationRef");
		AnimationContextIsValid_CurrentAnimationRef_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimationContextIsValid_FunctionAddress, "CurrentAnimationRef", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimationContextIsValid_ReturnValue_PropertyAddress, AnimationContextIsValid_FunctionAddress, "ReturnValue");
		AnimationContextIsValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AnimationContextIsValid_FunctionAddress, "ReturnValue");
		AnimationContextIsValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimationContextIsValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AnimationContextIsValid_IsValid = AnimationContextIsValid_FunctionAddress != IntPtr.Zero && AnimationContextIsValid_CurrentAnimationRef_IsValid && AnimationContextIsValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:AnimationContextIsValid", AnimationContextIsValid_IsValid);
		AnimationCalculationsAccepted_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AnimationCalculationsAccepted");
		AnimationCalculationsAccepted_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimationCalculationsAccepted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimationCalculationsAccepted_Ref_PropertyAddress, AnimationCalculationsAccepted_FunctionAddress, "Ref");
		AnimationCalculationsAccepted_Ref_Offset = NativeReflectionCached.GetPropertyOffset(AnimationCalculationsAccepted_FunctionAddress, "Ref");
		AnimationCalculationsAccepted_Ref_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimationCalculationsAccepted_FunctionAddress, "Ref", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimationCalculationsAccepted_ReturnValue_PropertyAddress, AnimationCalculationsAccepted_FunctionAddress, "ReturnValue");
		AnimationCalculationsAccepted_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AnimationCalculationsAccepted_FunctionAddress, "ReturnValue");
		AnimationCalculationsAccepted_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimationCalculationsAccepted_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AnimationCalculationsAccepted_IsValid = AnimationCalculationsAccepted_FunctionAddress != IntPtr.Zero && AnimationCalculationsAccepted_Ref_IsValid && AnimationCalculationsAccepted_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:AnimationCalculationsAccepted", AnimationCalculationsAccepted_IsValid);
		AnalyzerAnimationReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AnalyzerAnimationReferences");
		AnalyzerAnimationReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(AnalyzerAnimationReferences_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnalyzerAnimationReferences_CurrentReferenceAnimation_PropertyAddress, AnalyzerAnimationReferences_FunctionAddress, "CurrentReferenceAnimation");
		AnalyzerAnimationReferences_CurrentReferenceAnimation_Offset = NativeReflectionCached.GetPropertyOffset(AnalyzerAnimationReferences_FunctionAddress, "CurrentReferenceAnimation");
		AnalyzerAnimationReferences_CurrentReferenceAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(AnalyzerAnimationReferences_FunctionAddress, "CurrentReferenceAnimation", Classes.FIntProperty);
		AnalyzerAnimationReferences_IsValid = AnalyzerAnimationReferences_FunctionAddress != IntPtr.Zero && AnalyzerAnimationReferences_CurrentReferenceAnimation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.AnimationAnalyzer:AnalyzerAnimationReferences", AnalyzerAnimationReferences_IsValid);
	}
}
