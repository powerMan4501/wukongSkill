using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MM.MotionMatchingHelpers", "MM", UnrealModuleType.GamePlugin)]
public class UMotionMatchingHelpers : UObject
{
	private static IntPtr classAddress;

	private static bool MakeInputDirectionData_IsValid;

	private static IntPtr MakeInputDirectionData_FunctionAddress;

	private static int MakeInputDirectionData_ParamsSize;

	private static bool MakeInputDirectionData_OutInputDirection_IsValid;

	private static FFieldAddress MakeInputDirectionData_OutInputDirection_PropertyAddress;

	private static int MakeInputDirectionData_OutInputDirection_Offset;

	private static bool MakeInputDirectionData_VectorsWeHaveLeftBehind_IsValid;

	private static FFieldAddress MakeInputDirectionData_VectorsWeHaveLeftBehind_PropertyAddress;

	private static int MakeInputDirectionData_VectorsWeHaveLeftBehind_Offset;

	private static bool MakeInputDirectionData_CheckTheseAgainstVWHLB_IsValid;

	private static FFieldAddress MakeInputDirectionData_CheckTheseAgainstVWHLB_PropertyAddress;

	private static int MakeInputDirectionData_CheckTheseAgainstVWHLB_Offset;

	private static bool MakeInputDirectionData_ReturnValue_IsValid;

	private static FFieldAddress MakeInputDirectionData_ReturnValue_PropertyAddress;

	private static int MakeInputDirectionData_ReturnValue_Offset;

	private static bool GetMMAnimDataRecordFilePath_IsValid;

	private static IntPtr GetMMAnimDataRecordFilePath_FunctionAddress;

	private static int GetMMAnimDataRecordFilePath_ParamsSize;

	private static bool GetMMAnimDataRecordFilePath_ReturnValue_IsValid;

	private static FFieldAddress GetMMAnimDataRecordFilePath_ReturnValue_PropertyAddress;

	private static int GetMMAnimDataRecordFilePath_ReturnValue_Offset;

	private static bool GetLMAnimVelocityReferenceClock_IsValid;

	private static IntPtr GetLMAnimVelocityReferenceClock_FunctionAddress;

	private static int GetLMAnimVelocityReferenceClock_ParamsSize;

	private static bool GetLMAnimVelocityReferenceClock_InSequence_IsValid;

	private static FFieldAddress GetLMAnimVelocityReferenceClock_InSequence_PropertyAddress;

	private static int GetLMAnimVelocityReferenceClock_InSequence_Offset;

	private static bool GetLMAnimVelocityReferenceClock_ReferenceClock_IsValid;

	private static FFieldAddress GetLMAnimVelocityReferenceClock_ReferenceClock_PropertyAddress;

	private static int GetLMAnimVelocityReferenceClock_ReferenceClock_Offset;

	private static bool GetLMAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_IsValid;

	private static FFieldAddress GetLMAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_PropertyAddress;

	private static int GetLMAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_Offset;

	private static bool GetLastInputDirectionTransform_IsValid;

	private static IntPtr GetLastInputDirectionTransform_FunctionAddress;

	private static int GetLastInputDirectionTransform_ParamsSize;

	private static bool GetLastInputDirectionTransform_InputDirection_IsValid;

	private static FFieldAddress GetLastInputDirectionTransform_InputDirection_PropertyAddress;

	private static int GetLastInputDirectionTransform_InputDirection_Offset;

	private static bool GetLastInputDirectionTransform_ReturnValue_IsValid;

	private static FFieldAddress GetLastInputDirectionTransform_ReturnValue_PropertyAddress;

	private static int GetLastInputDirectionTransform_ReturnValue_Offset;

	private static bool GetKeyPoseDataFromAnim_IsValid;

	private static IntPtr GetKeyPoseDataFromAnim_FunctionAddress;

	private static int GetKeyPoseDataFromAnim_ParamsSize;

	private static bool GetKeyPoseDataFromAnim_InSequence_IsValid;

	private static FFieldAddress GetKeyPoseDataFromAnim_InSequence_PropertyAddress;

	private static int GetKeyPoseDataFromAnim_InSequence_Offset;

	private static bool GetKeyPoseDataFromAnim_ReferenceClock_IsValid;

	private static FFieldAddress GetKeyPoseDataFromAnim_ReferenceClock_PropertyAddress;

	private static int GetKeyPoseDataFromAnim_ReferenceClock_Offset;

	private static bool GetKeyPoseDataFromAnim_ToBeRefAgainst_IsValid;

	private static FFieldAddress GetKeyPoseDataFromAnim_ToBeRefAgainst_PropertyAddress;

	private static int GetKeyPoseDataFromAnim_ToBeRefAgainst_Offset;

	private static bool GetKeyPoseDataFromAnim_CalculatedMMData_IsValid;

	private static FFieldAddress GetKeyPoseDataFromAnim_CalculatedMMData_PropertyAddress;

	private static int GetKeyPoseDataFromAnim_CalculatedMMData_Offset;

	private static bool GetDataFromAnimation_IsValid;

	private static IntPtr GetDataFromAnimation_FunctionAddress;

	private static int GetDataFromAnimation_ParamsSize;

	private static bool GetDataFromAnimation_InSequence_IsValid;

	private static FFieldAddress GetDataFromAnimation_InSequence_PropertyAddress;

	private static int GetDataFromAnimation_InSequence_Offset;

	private static bool GetDataFromAnimation_ReferenceClock_IsValid;

	private static FFieldAddress GetDataFromAnimation_ReferenceClock_PropertyAddress;

	private static int GetDataFromAnimation_ReferenceClock_Offset;

	private static bool GetDataFromAnimation_SkeletonRuntimeName_IsValid;

	private static FFieldAddress GetDataFromAnimation_SkeletonRuntimeName_PropertyAddress;

	private static int GetDataFromAnimation_SkeletonRuntimeName_Offset;

	private static bool GetDataFromAnimation_OutPresentInputDirection_IsValid;

	private static FFieldAddress GetDataFromAnimation_OutPresentInputDirection_PropertyAddress;

	private static int GetDataFromAnimation_OutPresentInputDirection_Offset;

	private static bool GetDataFromAnimation_OutFutureInputDirection_IsValid;

	private static FFieldAddress GetDataFromAnimation_OutFutureInputDirection_PropertyAddress;

	private static int GetDataFromAnimation_OutFutureInputDirection_Offset;

	private static bool GetDataFromAnimation_DeliveredAnimationReferencesForSkelRef_IsValid;

	private static FFieldAddress GetDataFromAnimation_DeliveredAnimationReferencesForSkelRef_PropertyAddress;

	private static int GetDataFromAnimation_DeliveredAnimationReferencesForSkelRef_Offset;

	private static bool GetAnimVelocityReferenceClock_IsValid;

	private static IntPtr GetAnimVelocityReferenceClock_FunctionAddress;

	private static int GetAnimVelocityReferenceClock_ParamsSize;

	private static bool GetAnimVelocityReferenceClock_InSequence_IsValid;

	private static FFieldAddress GetAnimVelocityReferenceClock_InSequence_PropertyAddress;

	private static int GetAnimVelocityReferenceClock_InSequence_Offset;

	private static bool GetAnimVelocityReferenceClock_ReferenceClock_IsValid;

	private static FFieldAddress GetAnimVelocityReferenceClock_ReferenceClock_PropertyAddress;

	private static int GetAnimVelocityReferenceClock_ReferenceClock_Offset;

	private static bool GetAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_IsValid;

	private static FFieldAddress GetAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_PropertyAddress;

	private static int GetAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_Offset;

	private static bool GetAnimJointData_IsValid;

	private static IntPtr GetAnimJointData_FunctionAddress;

	private static int GetAnimJointData_ParamsSize;

	private static bool GetAnimJointData_InSequence_IsValid;

	private static FFieldAddress GetAnimJointData_InSequence_PropertyAddress;

	private static int GetAnimJointData_InSequence_Offset;

	private static bool GetAnimJointData_ReferenceClock_IsValid;

	private static FFieldAddress GetAnimJointData_ReferenceClock_PropertyAddress;

	private static int GetAnimJointData_ReferenceClock_Offset;

	private static bool GetAnimJointData_BoneName_IsValid;

	private static FFieldAddress GetAnimJointData_BoneName_PropertyAddress;

	private static int GetAnimJointData_BoneName_Offset;

	private static bool GetAnimJointData_DeliveredAnimationReferencesForSkelRef_IsValid;

	private static FFieldAddress GetAnimJointData_DeliveredAnimationReferencesForSkelRef_PropertyAddress;

	private static int GetAnimJointData_DeliveredAnimationReferencesForSkelRef_Offset;

	private static bool GetAnimJointData_InDeltaTime_IsValid;

	private static FFieldAddress GetAnimJointData_InDeltaTime_PropertyAddress;

	private static int GetAnimJointData_InDeltaTime_Offset;

	private static bool GetAnimBoneWorldTransform_IsValid;

	private static IntPtr GetAnimBoneWorldTransform_FunctionAddress;

	private static int GetAnimBoneWorldTransform_ParamsSize;

	private static bool GetAnimBoneWorldTransform_InSequence_IsValid;

	private static FFieldAddress GetAnimBoneWorldTransform_InSequence_PropertyAddress;

	private static int GetAnimBoneWorldTransform_InSequence_Offset;

	private static bool GetAnimBoneWorldTransform_ReferenceClock_IsValid;

	private static FFieldAddress GetAnimBoneWorldTransform_ReferenceClock_PropertyAddress;

	private static int GetAnimBoneWorldTransform_ReferenceClock_Offset;

	private static bool GetAnimBoneWorldTransform_CurrentSkeletonPartInReference_IsValid;

	private static FFieldAddress GetAnimBoneWorldTransform_CurrentSkeletonPartInReference_PropertyAddress;

	private static int GetAnimBoneWorldTransform_CurrentSkeletonPartInReference_Offset;

	private static bool GetAnimBoneWorldTransform_SkelIdx2TrackIdx_IsValid;

	private static FFieldAddress GetAnimBoneWorldTransform_SkelIdx2TrackIdx_PropertyAddress;

	private static int GetAnimBoneWorldTransform_SkelIdx2TrackIdx_Offset;

	private static bool GetAnimBoneWorldTransform_CalculatedTransformMM_IsValid;

	private static FFieldAddress GetAnimBoneWorldTransform_CalculatedTransformMM_PropertyAddress;

	private static int GetAnimBoneWorldTransform_CalculatedTransformMM_Offset;

	private static bool GetAnimBoneLocalVel_IsValid;

	private static IntPtr GetAnimBoneLocalVel_FunctionAddress;

	private static int GetAnimBoneLocalVel_ParamsSize;

	private static bool GetAnimBoneLocalVel_InSequence_IsValid;

	private static FFieldAddress GetAnimBoneLocalVel_InSequence_PropertyAddress;

	private static int GetAnimBoneLocalVel_InSequence_Offset;

	private static bool GetAnimBoneLocalVel_ReferenceClock_IsValid;

	private static FFieldAddress GetAnimBoneLocalVel_ReferenceClock_PropertyAddress;

	private static int GetAnimBoneLocalVel_ReferenceClock_Offset;

	private static bool GetAnimBoneLocalVel_CurrentSkeletonPartInReference_IsValid;

	private static FFieldAddress GetAnimBoneLocalVel_CurrentSkeletonPartInReference_PropertyAddress;

	private static int GetAnimBoneLocalVel_CurrentSkeletonPartInReference_Offset;

	private static bool GetAnimBoneLocalVel_SkelIdx2TrackIdx_IsValid;

	private static FFieldAddress GetAnimBoneLocalVel_SkelIdx2TrackIdx_PropertyAddress;

	private static int GetAnimBoneLocalVel_SkelIdx2TrackIdx_Offset;

	private static bool GetAnimBoneLocalVel_DeliveredVelocityViaAnimBonesLocalVel_IsValid;

	private static FFieldAddress GetAnimBoneLocalVel_DeliveredVelocityViaAnimBonesLocalVel_PropertyAddress;

	private static int GetAnimBoneLocalVel_DeliveredVelocityViaAnimBonesLocalVel_Offset;

	private static bool GetAnimBoneLocalTransform_IsValid;

	private static IntPtr GetAnimBoneLocalTransform_FunctionAddress;

	private static int GetAnimBoneLocalTransform_ParamsSize;

	private static bool GetAnimBoneLocalTransform_InSequence_IsValid;

	private static FFieldAddress GetAnimBoneLocalTransform_InSequence_PropertyAddress;

	private static int GetAnimBoneLocalTransform_InSequence_Offset;

	private static bool GetAnimBoneLocalTransform_ReferenceClock_IsValid;

	private static FFieldAddress GetAnimBoneLocalTransform_ReferenceClock_PropertyAddress;

	private static int GetAnimBoneLocalTransform_ReferenceClock_Offset;

	private static bool GetAnimBoneLocalTransform_CurrentSkeletonPartInReference_IsValid;

	private static FFieldAddress GetAnimBoneLocalTransform_CurrentSkeletonPartInReference_PropertyAddress;

	private static int GetAnimBoneLocalTransform_CurrentSkeletonPartInReference_Offset;

	private static bool GetAnimBoneLocalTransform_SkelIdx2TrackIdx_IsValid;

	private static FFieldAddress GetAnimBoneLocalTransform_SkelIdx2TrackIdx_PropertyAddress;

	private static int GetAnimBoneLocalTransform_SkelIdx2TrackIdx_Offset;

	private static bool GetAnimBoneLocalTransform_CalculatedTransformMM_IsValid;

	private static FFieldAddress GetAnimBoneLocalTransform_CalculatedTransformMM_PropertyAddress;

	private static int GetAnimBoneLocalTransform_CalculatedTransformMM_Offset;

	private static bool ExtractLMAnimInputDirection_IsValid;

	private static IntPtr ExtractLMAnimInputDirection_FunctionAddress;

	private static int ExtractLMAnimInputDirection_ParamsSize;

	private static bool ExtractLMAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_IsValid;

	private static FFieldAddress ExtractLMAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_PropertyAddress;

	private static int ExtractLMAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_Offset;

	private static bool ExtractLMAnimInputDirection_InSequence_IsValid;

	private static FFieldAddress ExtractLMAnimInputDirection_InSequence_PropertyAddress;

	private static int ExtractLMAnimInputDirection_InSequence_Offset;

	private static bool ExtractLMAnimInputDirection_ClockInGame_IsValid;

	private static FFieldAddress ExtractLMAnimInputDirection_ClockInGame_PropertyAddress;

	private static int ExtractLMAnimInputDirection_ClockInGame_Offset;

	private static bool ExtractAnimSmoothedRotation_IsValid;

	private static IntPtr ExtractAnimSmoothedRotation_FunctionAddress;

	private static int ExtractAnimSmoothedRotation_ParamsSize;

	private static bool ExtractAnimSmoothedRotation_DeliveredRotation_IsValid;

	private static FFieldAddress ExtractAnimSmoothedRotation_DeliveredRotation_PropertyAddress;

	private static int ExtractAnimSmoothedRotation_DeliveredRotation_Offset;

	private static bool ExtractAnimSmoothedRotation_InSequence_IsValid;

	private static FFieldAddress ExtractAnimSmoothedRotation_InSequence_PropertyAddress;

	private static int ExtractAnimSmoothedRotation_InSequence_Offset;

	private static bool ExtractAnimSmoothedRotation_ClockInGame_IsValid;

	private static FFieldAddress ExtractAnimSmoothedRotation_ClockInGame_PropertyAddress;

	private static int ExtractAnimSmoothedRotation_ClockInGame_Offset;

	private static bool ExtractAnimInputDirection_IsValid;

	private static IntPtr ExtractAnimInputDirection_FunctionAddress;

	private static int ExtractAnimInputDirection_ParamsSize;

	private static bool ExtractAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_IsValid;

	private static FFieldAddress ExtractAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_PropertyAddress;

	private static int ExtractAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_Offset;

	private static bool ExtractAnimInputDirection_InSequence_IsValid;

	private static FFieldAddress ExtractAnimInputDirection_InSequence_PropertyAddress;

	private static int ExtractAnimInputDirection_InSequence_Offset;

	private static bool ExtractAnimInputDirection_ClockInGame_IsValid;

	private static FFieldAddress ExtractAnimInputDirection_ClockInGame_PropertyAddress;

	private static int ExtractAnimInputDirection_ClockInGame_Offset;

	private static bool CreateInputDirection_IsValid;

	private static IntPtr CreateInputDirection_FunctionAddress;

	private static int CreateInputDirection_ParamsSize;

	private static bool CreateInputDirection_OutConstructTargetDirection_IsValid;

	private static FFieldAddress CreateInputDirection_OutConstructTargetDirection_PropertyAddress;

	private static int CreateInputDirection_OutConstructTargetDirection_Offset;

	private static bool CreateInputDirection_DesiredTransform_IsValid;

	private static FFieldAddress CreateInputDirection_DesiredTransform_PropertyAddress;

	private static int CreateInputDirection_DesiredTransform_Offset;

	private static bool CreateInputDirection_RootWorldTransform_IsValid;

	private static FFieldAddress CreateInputDirection_RootWorldTransform_PropertyAddress;

	private static int CreateInputDirection_RootWorldTransform_Offset;

	private static bool CreateInputDirection_TargetDirectionInputStrength_IsValid;

	private static FFieldAddress CreateInputDirection_TargetDirectionInputStrength_PropertyAddress;

	private static int CreateInputDirection_TargetDirectionInputStrength_Offset;

	private static bool CompareTrajectories_IsValid;

	private static IntPtr CompareTrajectories_FunctionAddress;

	private static int CompareTrajectories_ParamsSize;

	private static bool CompareTrajectories_InputDirectionData_A_IsValid;

	private static FFieldAddress CompareTrajectories_InputDirectionData_A_PropertyAddress;

	private static int CompareTrajectories_InputDirectionData_A_Offset;

	private static bool CompareTrajectories_InputDirectionData_B_IsValid;

	private static FFieldAddress CompareTrajectories_InputDirectionData_B_PropertyAddress;

	private static int CompareTrajectories_InputDirectionData_B_Offset;

	private static bool CompareTrajectories_ReturnValue_IsValid;

	private static FFieldAddress CompareTrajectories_ReturnValue_PropertyAddress;

	private static int CompareTrajectories_ReturnValue_Offset;

	private static bool CompareJointDatas_IsValid;

	private static IntPtr CompareJointDatas_FunctionAddress;

	private static int CompareJointDatas_ParamsSize;

	private static bool CompareJointDatas_JointData_A_IsValid;

	private static FFieldAddress CompareJointDatas_JointData_A_PropertyAddress;

	private static int CompareJointDatas_JointData_A_Offset;

	private static bool CompareJointDatas_JointData_B_IsValid;

	private static FFieldAddress CompareJointDatas_JointData_B_PropertyAddress;

	private static int CompareJointDatas_JointData_B_Offset;

	private static bool CompareJointDatas_ReturnValue_IsValid;

	private static FFieldAddress CompareJointDatas_ReturnValue_PropertyAddress;

	private static int CompareJointDatas_ReturnValue_Offset;

	private static bool BlendKeyPoses_IsValid;

	private static IntPtr BlendKeyPoses_FunctionAddress;

	private static int BlendKeyPoses_ParamsSize;

	private static bool BlendKeyPoses_PoseA_IsValid;

	private static FFieldAddress BlendKeyPoses_PoseA_PropertyAddress;

	private static int BlendKeyPoses_PoseA_Offset;

	private static bool BlendKeyPoses_PoseB_IsValid;

	private static FFieldAddress BlendKeyPoses_PoseB_PropertyAddress;

	private static int BlendKeyPoses_PoseB_Offset;

	private static bool BlendKeyPoses_Alpha_IsValid;

	private static FFieldAddress BlendKeyPoses_Alpha_PropertyAddress;

	private static int BlendKeyPoses_Alpha_Offset;

	private static bool BlendKeyPoses_OutBlendedKeyPose_IsValid;

	private static FFieldAddress BlendKeyPoses_OutBlendedKeyPose_PropertyAddress;

	private static int BlendKeyPoses_OutBlendedKeyPose_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:MakeInputDirectionData")]
	public unsafe static bool MakeInputDirectionData(out FInputPlayerDirectionData OutInputDirection, List<FTransform> VectorsWeHaveLeftBehind, List<FVector> CheckTheseAgainstVWHLB)
	{
		if (!MakeInputDirectionData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:MakeInputDirectionData");
			OutInputDirection = default(FInputPlayerDirectionData);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeInputDirectionData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeInputDirectionData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MakeInputDirectionData_OutInputDirection_PropertyAddress.Address, intPtr);
		new TArrayCopyMarshaler<FTransform>(1, MakeInputDirectionData_VectorsWeHaveLeftBehind_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(intPtr, MakeInputDirectionData_VectorsWeHaveLeftBehind_Offset), VectorsWeHaveLeftBehind);
		new TArrayCopyMarshaler<FVector>(1, MakeInputDirectionData_CheckTheseAgainstVWHLB_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, MakeInputDirectionData_CheckTheseAgainstVWHLB_Offset), CheckTheseAgainstVWHLB);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeInputDirectionData_FunctionAddress, intPtr, MakeInputDirectionData_ParamsSize);
		OutInputDirection = FInputPlayerDirectionData.FromNative(IntPtr.Add(intPtr, MakeInputDirectionData_OutInputDirection_Offset), 0, MakeInputDirectionData_OutInputDirection_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakeInputDirectionData_OutInputDirection_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MakeInputDirectionData_VectorsWeHaveLeftBehind_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MakeInputDirectionData_CheckTheseAgainstVWHLB_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MakeInputDirectionData_ReturnValue_Offset), 0, MakeInputDirectionData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:GetMMAnimDataRecordFilePath")]
	public unsafe static string GetMMAnimDataRecordFilePath()
	{
		if (!GetMMAnimDataRecordFilePath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:GetMMAnimDataRecordFilePath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMMAnimDataRecordFilePath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMMAnimDataRecordFilePath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMMAnimDataRecordFilePath_FunctionAddress, intPtr, GetMMAnimDataRecordFilePath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetMMAnimDataRecordFilePath_ReturnValue_Offset), 0, GetMMAnimDataRecordFilePath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMMAnimDataRecordFilePath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:GetLMAnimVelocityReferenceClock")]
	public unsafe static void GetLMAnimVelocityReferenceClock(UAnimSequence InSequence, float ReferenceClock, out FVector DeliveredVelocityViaAnimBonesLocalVelocity)
	{
		if (!GetLMAnimVelocityReferenceClock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:GetLMAnimVelocityReferenceClock");
			DeliveredVelocityViaAnimBonesLocalVelocity = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLMAnimVelocityReferenceClock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLMAnimVelocityReferenceClock_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetLMAnimVelocityReferenceClock_InSequence_Offset), 0, GetLMAnimVelocityReferenceClock_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLMAnimVelocityReferenceClock_ReferenceClock_Offset), 0, GetLMAnimVelocityReferenceClock_ReferenceClock_PropertyAddress.Address, ReferenceClock);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLMAnimVelocityReferenceClock_FunctionAddress, intPtr, GetLMAnimVelocityReferenceClock_ParamsSize);
		DeliveredVelocityViaAnimBonesLocalVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLMAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_Offset), 0, GetLMAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:GetLastInputDirectionTransform")]
	public unsafe static FTransform GetLastInputDirectionTransform(FInputPlayerDirectionData InputDirection)
	{
		if (!GetLastInputDirectionTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:GetLastInputDirectionTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastInputDirectionTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastInputDirectionTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLastInputDirectionTransform_InputDirection_PropertyAddress.Address, intPtr);
		FInputPlayerDirectionData.ToNative(IntPtr.Add(intPtr, GetLastInputDirectionTransform_InputDirection_Offset), 0, GetLastInputDirectionTransform_InputDirection_PropertyAddress.Address, InputDirection);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLastInputDirectionTransform_FunctionAddress, intPtr, GetLastInputDirectionTransform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetLastInputDirectionTransform_InputDirection_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetLastInputDirectionTransform_ReturnValue_Offset), 0, GetLastInputDirectionTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:GetKeyPoseDataFromAnim")]
	public unsafe static void GetKeyPoseDataFromAnim(UAnimSequence InSequence, float ReferenceClock, List<FName> ToBeRefAgainst, out FMotionMatchData CalculatedMMData)
	{
		if (!GetKeyPoseDataFromAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:GetKeyPoseDataFromAnim");
			CalculatedMMData = default(FMotionMatchData);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKeyPoseDataFromAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKeyPoseDataFromAnim_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetKeyPoseDataFromAnim_InSequence_Offset), 0, GetKeyPoseDataFromAnim_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetKeyPoseDataFromAnim_ReferenceClock_Offset), 0, GetKeyPoseDataFromAnim_ReferenceClock_PropertyAddress.Address, ReferenceClock);
		new TArrayCopyMarshaler<FName>(1, GetKeyPoseDataFromAnim_ToBeRefAgainst_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, GetKeyPoseDataFromAnim_ToBeRefAgainst_Offset), ToBeRefAgainst);
		NativeReflection.InitializeValue_InContainer(GetKeyPoseDataFromAnim_CalculatedMMData_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetKeyPoseDataFromAnim_FunctionAddress, intPtr, GetKeyPoseDataFromAnim_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetKeyPoseDataFromAnim_ToBeRefAgainst_PropertyAddress.Address, intPtr);
		CalculatedMMData = FMotionMatchData.FromNative(IntPtr.Add(intPtr, GetKeyPoseDataFromAnim_CalculatedMMData_Offset), 0, GetKeyPoseDataFromAnim_CalculatedMMData_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetKeyPoseDataFromAnim_CalculatedMMData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:GetDataFromAnimation")]
	public unsafe static void GetDataFromAnimation(UAnimSequence InSequence, float ReferenceClock, List<FName> SkeletonRuntimeName, out FInputPlayerDirectionData OutPresentInputDirection, out FInputPlayerDirectionData OutFutureInputDirection, out List<FSkeletonStructure> DeliveredAnimationReferencesForSkelRef)
	{
		if (!GetDataFromAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:GetDataFromAnimation");
			OutPresentInputDirection = default(FInputPlayerDirectionData);
			OutFutureInputDirection = default(FInputPlayerDirectionData);
			DeliveredAnimationReferencesForSkelRef = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDataFromAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDataFromAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetDataFromAnimation_InSequence_Offset), 0, GetDataFromAnimation_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetDataFromAnimation_ReferenceClock_Offset), 0, GetDataFromAnimation_ReferenceClock_PropertyAddress.Address, ReferenceClock);
		new TArrayCopyMarshaler<FName>(1, GetDataFromAnimation_SkeletonRuntimeName_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, GetDataFromAnimation_SkeletonRuntimeName_Offset), SkeletonRuntimeName);
		NativeReflection.InitializeValue_InContainer(GetDataFromAnimation_OutPresentInputDirection_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(GetDataFromAnimation_OutFutureInputDirection_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDataFromAnimation_FunctionAddress, intPtr, GetDataFromAnimation_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetDataFromAnimation_SkeletonRuntimeName_PropertyAddress.Address, intPtr);
		OutPresentInputDirection = FInputPlayerDirectionData.FromNative(IntPtr.Add(intPtr, GetDataFromAnimation_OutPresentInputDirection_Offset), 0, GetDataFromAnimation_OutPresentInputDirection_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDataFromAnimation_OutPresentInputDirection_PropertyAddress.Address, intPtr);
		OutFutureInputDirection = FInputPlayerDirectionData.FromNative(IntPtr.Add(intPtr, GetDataFromAnimation_OutFutureInputDirection_Offset), 0, GetDataFromAnimation_OutFutureInputDirection_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDataFromAnimation_OutFutureInputDirection_PropertyAddress.Address, intPtr);
		DeliveredAnimationReferencesForSkelRef = new TArrayCopyMarshaler<FSkeletonStructure>(1, GetDataFromAnimation_DeliveredAnimationReferencesForSkelRef_PropertyAddress, CachedMarshalingDelegates<FSkeletonStructure, FSkeletonStructure>.FromNative, CachedMarshalingDelegates<FSkeletonStructure, FSkeletonStructure>.ToNative).FromNative(IntPtr.Add(intPtr, GetDataFromAnimation_DeliveredAnimationReferencesForSkelRef_Offset));
		NativeReflection.DestroyValue_InContainer(GetDataFromAnimation_DeliveredAnimationReferencesForSkelRef_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:GetAnimVelocityReferenceClock")]
	public unsafe static void GetAnimVelocityReferenceClock(UAnimSequence InSequence, float ReferenceClock, out FVector DeliveredVelocityViaAnimBonesLocalVelocity)
	{
		if (!GetAnimVelocityReferenceClock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:GetAnimVelocityReferenceClock");
			DeliveredVelocityViaAnimBonesLocalVelocity = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimVelocityReferenceClock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimVelocityReferenceClock_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAnimVelocityReferenceClock_InSequence_Offset), 0, GetAnimVelocityReferenceClock_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetAnimVelocityReferenceClock_ReferenceClock_Offset), 0, GetAnimVelocityReferenceClock_ReferenceClock_PropertyAddress.Address, ReferenceClock);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimVelocityReferenceClock_FunctionAddress, intPtr, GetAnimVelocityReferenceClock_ParamsSize);
		DeliveredVelocityViaAnimBonesLocalVelocity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_Offset), 0, GetAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:GetAnimJointData")]
	public unsafe static void GetAnimJointData(UAnimSequence InSequence, float ReferenceClock, FName BoneName, out FSkeletonStructure DeliveredAnimationReferencesForSkelRef, float InDeltaTime = 0f)
	{
		if (!GetAnimJointData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:GetAnimJointData");
			DeliveredAnimationReferencesForSkelRef = default(FSkeletonStructure);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimJointData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimJointData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAnimJointData_InSequence_Offset), 0, GetAnimJointData_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetAnimJointData_ReferenceClock_Offset), 0, GetAnimJointData_ReferenceClock_PropertyAddress.Address, ReferenceClock);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAnimJointData_BoneName_Offset), 0, GetAnimJointData_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InitializeValue_InContainer(GetAnimJointData_DeliveredAnimationReferencesForSkelRef_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetAnimJointData_InDeltaTime_Offset), 0, GetAnimJointData_InDeltaTime_PropertyAddress.Address, InDeltaTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimJointData_FunctionAddress, intPtr, GetAnimJointData_ParamsSize);
		DeliveredAnimationReferencesForSkelRef = FSkeletonStructure.FromNative(IntPtr.Add(intPtr, GetAnimJointData_DeliveredAnimationReferencesForSkelRef_Offset), 0, GetAnimJointData_DeliveredAnimationReferencesForSkelRef_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:GetAnimBoneWorldTransform")]
	public unsafe static void GetAnimBoneWorldTransform(UAnimSequence InSequence, float ReferenceClock, int CurrentSkeletonPartInReference, Dictionary<int, int> SkelIdx2TrackIdx, out FTransform CalculatedTransformMM)
	{
		if (!GetAnimBoneWorldTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:GetAnimBoneWorldTransform");
			CalculatedTransformMM = default(FTransform);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimBoneWorldTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimBoneWorldTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAnimBoneWorldTransform_InSequence_Offset), 0, GetAnimBoneWorldTransform_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetAnimBoneWorldTransform_ReferenceClock_Offset), 0, GetAnimBoneWorldTransform_ReferenceClock_PropertyAddress.Address, ReferenceClock);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAnimBoneWorldTransform_CurrentSkeletonPartInReference_Offset), 0, GetAnimBoneWorldTransform_CurrentSkeletonPartInReference_PropertyAddress.Address, CurrentSkeletonPartInReference);
		NativeReflection.InitializeValue_InContainer(GetAnimBoneWorldTransform_SkelIdx2TrackIdx_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, int>(1, GetAnimBoneWorldTransform_SkelIdx2TrackIdx_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, GetAnimBoneWorldTransform_SkelIdx2TrackIdx_Offset), SkelIdx2TrackIdx);
		NativeReflection.InitializeValue_InContainer(GetAnimBoneWorldTransform_CalculatedTransformMM_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimBoneWorldTransform_FunctionAddress, intPtr, GetAnimBoneWorldTransform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAnimBoneWorldTransform_SkelIdx2TrackIdx_PropertyAddress.Address, intPtr);
		CalculatedTransformMM = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetAnimBoneWorldTransform_CalculatedTransformMM_Offset), 0, GetAnimBoneWorldTransform_CalculatedTransformMM_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:GetAnimBoneLocalVel")]
	public unsafe static void GetAnimBoneLocalVel(UAnimSequence InSequence, float ReferenceClock, int CurrentSkeletonPartInReference, Dictionary<int, int> SkelIdx2TrackIdx, out FVector DeliveredVelocityViaAnimBonesLocalVel)
	{
		if (!GetAnimBoneLocalVel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:GetAnimBoneLocalVel");
			DeliveredVelocityViaAnimBonesLocalVel = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimBoneLocalVel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimBoneLocalVel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAnimBoneLocalVel_InSequence_Offset), 0, GetAnimBoneLocalVel_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetAnimBoneLocalVel_ReferenceClock_Offset), 0, GetAnimBoneLocalVel_ReferenceClock_PropertyAddress.Address, ReferenceClock);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAnimBoneLocalVel_CurrentSkeletonPartInReference_Offset), 0, GetAnimBoneLocalVel_CurrentSkeletonPartInReference_PropertyAddress.Address, CurrentSkeletonPartInReference);
		NativeReflection.InitializeValue_InContainer(GetAnimBoneLocalVel_SkelIdx2TrackIdx_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, int>(1, GetAnimBoneLocalVel_SkelIdx2TrackIdx_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, GetAnimBoneLocalVel_SkelIdx2TrackIdx_Offset), SkelIdx2TrackIdx);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimBoneLocalVel_FunctionAddress, intPtr, GetAnimBoneLocalVel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAnimBoneLocalVel_SkelIdx2TrackIdx_PropertyAddress.Address, intPtr);
		DeliveredVelocityViaAnimBonesLocalVel = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetAnimBoneLocalVel_DeliveredVelocityViaAnimBonesLocalVel_Offset), 0, GetAnimBoneLocalVel_DeliveredVelocityViaAnimBonesLocalVel_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:GetAnimBoneLocalTransform")]
	public unsafe static void GetAnimBoneLocalTransform(UAnimSequence InSequence, float ReferenceClock, int CurrentSkeletonPartInReference, Dictionary<int, int> SkelIdx2TrackIdx, out FTransform CalculatedTransformMM)
	{
		if (!GetAnimBoneLocalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:GetAnimBoneLocalTransform");
			CalculatedTransformMM = default(FTransform);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimBoneLocalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimBoneLocalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, GetAnimBoneLocalTransform_InSequence_Offset), 0, GetAnimBoneLocalTransform_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetAnimBoneLocalTransform_ReferenceClock_Offset), 0, GetAnimBoneLocalTransform_ReferenceClock_PropertyAddress.Address, ReferenceClock);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAnimBoneLocalTransform_CurrentSkeletonPartInReference_Offset), 0, GetAnimBoneLocalTransform_CurrentSkeletonPartInReference_PropertyAddress.Address, CurrentSkeletonPartInReference);
		NativeReflection.InitializeValue_InContainer(GetAnimBoneLocalTransform_SkelIdx2TrackIdx_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<int, int>(1, GetAnimBoneLocalTransform_SkelIdx2TrackIdx_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, GetAnimBoneLocalTransform_SkelIdx2TrackIdx_Offset), SkelIdx2TrackIdx);
		NativeReflection.InitializeValue_InContainer(GetAnimBoneLocalTransform_CalculatedTransformMM_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimBoneLocalTransform_FunctionAddress, intPtr, GetAnimBoneLocalTransform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAnimBoneLocalTransform_SkelIdx2TrackIdx_PropertyAddress.Address, intPtr);
		CalculatedTransformMM = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetAnimBoneLocalTransform_CalculatedTransformMM_Offset), 0, GetAnimBoneLocalTransform_CalculatedTransformMM_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:ExtractLMAnimInputDirection")]
	public unsafe static void ExtractLMAnimInputDirection(out FInputPlayerDirectionData DeliveredVelocityViaAnimBonesLocalVelocityData, UAnimSequence InSequence, float ClockInGame)
	{
		if (!ExtractLMAnimInputDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:ExtractLMAnimInputDirection");
			DeliveredVelocityViaAnimBonesLocalVelocityData = default(FInputPlayerDirectionData);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExtractLMAnimInputDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExtractLMAnimInputDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ExtractLMAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, ExtractLMAnimInputDirection_InSequence_Offset), 0, ExtractLMAnimInputDirection_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ExtractLMAnimInputDirection_ClockInGame_Offset), 0, ExtractLMAnimInputDirection_ClockInGame_PropertyAddress.Address, ClockInGame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExtractLMAnimInputDirection_FunctionAddress, intPtr, ExtractLMAnimInputDirection_ParamsSize);
		DeliveredVelocityViaAnimBonesLocalVelocityData = FInputPlayerDirectionData.FromNative(IntPtr.Add(intPtr, ExtractLMAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_Offset), 0, ExtractLMAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExtractLMAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:ExtractAnimSmoothedRotation")]
	public unsafe static void ExtractAnimSmoothedRotation(out FQuat DeliveredRotation, UAnimSequence InSequence, float ClockInGame)
	{
		if (!ExtractAnimSmoothedRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:ExtractAnimSmoothedRotation");
			DeliveredRotation = default(FQuat);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExtractAnimSmoothedRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExtractAnimSmoothedRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ExtractAnimSmoothedRotation_DeliveredRotation_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, ExtractAnimSmoothedRotation_InSequence_Offset), 0, ExtractAnimSmoothedRotation_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ExtractAnimSmoothedRotation_ClockInGame_Offset), 0, ExtractAnimSmoothedRotation_ClockInGame_PropertyAddress.Address, ClockInGame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExtractAnimSmoothedRotation_FunctionAddress, intPtr, ExtractAnimSmoothedRotation_ParamsSize);
		DeliveredRotation = BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(intPtr, ExtractAnimSmoothedRotation_DeliveredRotation_Offset), 0, ExtractAnimSmoothedRotation_DeliveredRotation_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:ExtractAnimInputDirection")]
	public unsafe static void ExtractAnimInputDirection(out FInputPlayerDirectionData DeliveredVelocityViaAnimBonesLocalVelocityData, UAnimSequence InSequence, float ClockInGame)
	{
		if (!ExtractAnimInputDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:ExtractAnimInputDirection");
			DeliveredVelocityViaAnimBonesLocalVelocityData = default(FInputPlayerDirectionData);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExtractAnimInputDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExtractAnimInputDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ExtractAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, ExtractAnimInputDirection_InSequence_Offset), 0, ExtractAnimInputDirection_InSequence_PropertyAddress.Address, InSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ExtractAnimInputDirection_ClockInGame_Offset), 0, ExtractAnimInputDirection_ClockInGame_PropertyAddress.Address, ClockInGame);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExtractAnimInputDirection_FunctionAddress, intPtr, ExtractAnimInputDirection_ParamsSize);
		DeliveredVelocityViaAnimBonesLocalVelocityData = FInputPlayerDirectionData.FromNative(IntPtr.Add(intPtr, ExtractAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_Offset), 0, ExtractAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExtractAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:CreateInputDirection")]
	public unsafe static void CreateInputDirection(out FInputPlayerDirectionData OutConstructTargetDirection, FTransform DesiredTransform, FTransform RootWorldTransform, float TargetDirectionInputStrength)
	{
		if (!CreateInputDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:CreateInputDirection");
			OutConstructTargetDirection = default(FInputPlayerDirectionData);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateInputDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateInputDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateInputDirection_OutConstructTargetDirection_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(CreateInputDirection_DesiredTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, CreateInputDirection_DesiredTransform_Offset), 0, CreateInputDirection_DesiredTransform_PropertyAddress.Address, DesiredTransform);
		NativeReflection.InitializeValue_InContainer(CreateInputDirection_RootWorldTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, CreateInputDirection_RootWorldTransform_Offset), 0, CreateInputDirection_RootWorldTransform_PropertyAddress.Address, RootWorldTransform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CreateInputDirection_TargetDirectionInputStrength_Offset), 0, CreateInputDirection_TargetDirectionInputStrength_PropertyAddress.Address, TargetDirectionInputStrength);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateInputDirection_FunctionAddress, intPtr, CreateInputDirection_ParamsSize);
		OutConstructTargetDirection = FInputPlayerDirectionData.FromNative(IntPtr.Add(intPtr, CreateInputDirection_OutConstructTargetDirection_Offset), 0, CreateInputDirection_OutConstructTargetDirection_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateInputDirection_OutConstructTargetDirection_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:CompareTrajectories")]
	public unsafe static float CompareTrajectories(FInputPlayerDirectionData InputDirectionData_A, FInputPlayerDirectionData InputDirectionData_B)
	{
		if (!CompareTrajectories_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:CompareTrajectories");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CompareTrajectories_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CompareTrajectories_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CompareTrajectories_InputDirectionData_A_PropertyAddress.Address, intPtr);
		FInputPlayerDirectionData.ToNative(IntPtr.Add(intPtr, CompareTrajectories_InputDirectionData_A_Offset), 0, CompareTrajectories_InputDirectionData_A_PropertyAddress.Address, InputDirectionData_A);
		NativeReflection.InitializeValue_InContainer(CompareTrajectories_InputDirectionData_B_PropertyAddress.Address, intPtr);
		FInputPlayerDirectionData.ToNative(IntPtr.Add(intPtr, CompareTrajectories_InputDirectionData_B_Offset), 0, CompareTrajectories_InputDirectionData_B_PropertyAddress.Address, InputDirectionData_B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CompareTrajectories_FunctionAddress, intPtr, CompareTrajectories_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CompareTrajectories_InputDirectionData_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CompareTrajectories_InputDirectionData_B_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CompareTrajectories_ReturnValue_Offset), 0, CompareTrajectories_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:CompareJointDatas")]
	public unsafe static float CompareJointDatas(List<FSkeletonStructure> JointData_A, List<FSkeletonStructure> JointData_B)
	{
		if (!CompareJointDatas_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:CompareJointDatas");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CompareJointDatas_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CompareJointDatas_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FSkeletonStructure>(1, CompareJointDatas_JointData_A_PropertyAddress, CachedMarshalingDelegates<FSkeletonStructure, FSkeletonStructure>.FromNative, CachedMarshalingDelegates<FSkeletonStructure, FSkeletonStructure>.ToNative).ToNative(IntPtr.Add(intPtr, CompareJointDatas_JointData_A_Offset), JointData_A);
		new TArrayCopyMarshaler<FSkeletonStructure>(1, CompareJointDatas_JointData_B_PropertyAddress, CachedMarshalingDelegates<FSkeletonStructure, FSkeletonStructure>.FromNative, CachedMarshalingDelegates<FSkeletonStructure, FSkeletonStructure>.ToNative).ToNative(IntPtr.Add(intPtr, CompareJointDatas_JointData_B_Offset), JointData_B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CompareJointDatas_FunctionAddress, intPtr, CompareJointDatas_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CompareJointDatas_JointData_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CompareJointDatas_JointData_B_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CompareJointDatas_ReturnValue_Offset), 0, CompareJointDatas_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/MM.MotionMatchingHelpers:BlendKeyPoses")]
	public unsafe static void BlendKeyPoses(FMotionMatchData PoseA, FMotionMatchData PoseB, float Alpha, out FMotionMatchData OutBlendedKeyPose)
	{
		if (!BlendKeyPoses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MM.MotionMatchingHelpers:BlendKeyPoses");
			OutBlendedKeyPose = default(FMotionMatchData);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlendKeyPoses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlendKeyPoses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(BlendKeyPoses_PoseA_PropertyAddress.Address, intPtr);
		FMotionMatchData.ToNative(IntPtr.Add(intPtr, BlendKeyPoses_PoseA_Offset), 0, BlendKeyPoses_PoseA_PropertyAddress.Address, PoseA);
		NativeReflection.InitializeValue_InContainer(BlendKeyPoses_PoseB_PropertyAddress.Address, intPtr);
		FMotionMatchData.ToNative(IntPtr.Add(intPtr, BlendKeyPoses_PoseB_Offset), 0, BlendKeyPoses_PoseB_PropertyAddress.Address, PoseB);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BlendKeyPoses_Alpha_Offset), 0, BlendKeyPoses_Alpha_PropertyAddress.Address, Alpha);
		NativeReflection.InitializeValue_InContainer(BlendKeyPoses_OutBlendedKeyPose_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BlendKeyPoses_FunctionAddress, intPtr, BlendKeyPoses_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BlendKeyPoses_PoseA_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BlendKeyPoses_PoseB_PropertyAddress.Address, intPtr);
		OutBlendedKeyPose = FMotionMatchData.FromNative(IntPtr.Add(intPtr, BlendKeyPoses_OutBlendedKeyPose_Offset), 0, BlendKeyPoses_OutBlendedKeyPose_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BlendKeyPoses_OutBlendedKeyPose_PropertyAddress.Address, intPtr);
	}

	static UMotionMatchingHelpers()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMotionMatchingHelpers)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMotionMatchingHelpers));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/MM.MotionMatchingHelpers");
		MakeInputDirectionData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeInputDirectionData");
		MakeInputDirectionData_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeInputDirectionData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeInputDirectionData_OutInputDirection_PropertyAddress, MakeInputDirectionData_FunctionAddress, "OutInputDirection");
		MakeInputDirectionData_OutInputDirection_Offset = NativeReflectionCached.GetPropertyOffset(MakeInputDirectionData_FunctionAddress, "OutInputDirection");
		MakeInputDirectionData_OutInputDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeInputDirectionData_FunctionAddress, "OutInputDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeInputDirectionData_VectorsWeHaveLeftBehind_PropertyAddress, MakeInputDirectionData_FunctionAddress, "VectorsWeHaveLeftBehind");
		MakeInputDirectionData_VectorsWeHaveLeftBehind_Offset = NativeReflectionCached.GetPropertyOffset(MakeInputDirectionData_FunctionAddress, "VectorsWeHaveLeftBehind");
		MakeInputDirectionData_VectorsWeHaveLeftBehind_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeInputDirectionData_FunctionAddress, "VectorsWeHaveLeftBehind", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeInputDirectionData_CheckTheseAgainstVWHLB_PropertyAddress, MakeInputDirectionData_FunctionAddress, "CheckTheseAgainstVWHLB");
		MakeInputDirectionData_CheckTheseAgainstVWHLB_Offset = NativeReflectionCached.GetPropertyOffset(MakeInputDirectionData_FunctionAddress, "CheckTheseAgainstVWHLB");
		MakeInputDirectionData_CheckTheseAgainstVWHLB_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeInputDirectionData_FunctionAddress, "CheckTheseAgainstVWHLB", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeInputDirectionData_ReturnValue_PropertyAddress, MakeInputDirectionData_FunctionAddress, "ReturnValue");
		MakeInputDirectionData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeInputDirectionData_FunctionAddress, "ReturnValue");
		MakeInputDirectionData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeInputDirectionData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MakeInputDirectionData_IsValid = MakeInputDirectionData_FunctionAddress != IntPtr.Zero && MakeInputDirectionData_OutInputDirection_IsValid && MakeInputDirectionData_VectorsWeHaveLeftBehind_IsValid && MakeInputDirectionData_CheckTheseAgainstVWHLB_IsValid && MakeInputDirectionData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:MakeInputDirectionData", MakeInputDirectionData_IsValid);
		GetMMAnimDataRecordFilePath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMMAnimDataRecordFilePath");
		GetMMAnimDataRecordFilePath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMMAnimDataRecordFilePath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMMAnimDataRecordFilePath_ReturnValue_PropertyAddress, GetMMAnimDataRecordFilePath_FunctionAddress, "ReturnValue");
		GetMMAnimDataRecordFilePath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMMAnimDataRecordFilePath_FunctionAddress, "ReturnValue");
		GetMMAnimDataRecordFilePath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMMAnimDataRecordFilePath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetMMAnimDataRecordFilePath_IsValid = GetMMAnimDataRecordFilePath_FunctionAddress != IntPtr.Zero && GetMMAnimDataRecordFilePath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:GetMMAnimDataRecordFilePath", GetMMAnimDataRecordFilePath_IsValid);
		GetLMAnimVelocityReferenceClock_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLMAnimVelocityReferenceClock");
		GetLMAnimVelocityReferenceClock_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLMAnimVelocityReferenceClock_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLMAnimVelocityReferenceClock_InSequence_PropertyAddress, GetLMAnimVelocityReferenceClock_FunctionAddress, "InSequence");
		GetLMAnimVelocityReferenceClock_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetLMAnimVelocityReferenceClock_FunctionAddress, "InSequence");
		GetLMAnimVelocityReferenceClock_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLMAnimVelocityReferenceClock_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLMAnimVelocityReferenceClock_ReferenceClock_PropertyAddress, GetLMAnimVelocityReferenceClock_FunctionAddress, "ReferenceClock");
		GetLMAnimVelocityReferenceClock_ReferenceClock_Offset = NativeReflectionCached.GetPropertyOffset(GetLMAnimVelocityReferenceClock_FunctionAddress, "ReferenceClock");
		GetLMAnimVelocityReferenceClock_ReferenceClock_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLMAnimVelocityReferenceClock_FunctionAddress, "ReferenceClock", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLMAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_PropertyAddress, GetLMAnimVelocityReferenceClock_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVelocity");
		GetLMAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GetLMAnimVelocityReferenceClock_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVelocity");
		GetLMAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLMAnimVelocityReferenceClock_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVelocity", Classes.FStructProperty);
		GetLMAnimVelocityReferenceClock_IsValid = GetLMAnimVelocityReferenceClock_FunctionAddress != IntPtr.Zero && GetLMAnimVelocityReferenceClock_InSequence_IsValid && GetLMAnimVelocityReferenceClock_ReferenceClock_IsValid && GetLMAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:GetLMAnimVelocityReferenceClock", GetLMAnimVelocityReferenceClock_IsValid);
		GetLastInputDirectionTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLastInputDirectionTransform");
		GetLastInputDirectionTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastInputDirectionTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastInputDirectionTransform_InputDirection_PropertyAddress, GetLastInputDirectionTransform_FunctionAddress, "InputDirection");
		GetLastInputDirectionTransform_InputDirection_Offset = NativeReflectionCached.GetPropertyOffset(GetLastInputDirectionTransform_FunctionAddress, "InputDirection");
		GetLastInputDirectionTransform_InputDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastInputDirectionTransform_FunctionAddress, "InputDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLastInputDirectionTransform_ReturnValue_PropertyAddress, GetLastInputDirectionTransform_FunctionAddress, "ReturnValue");
		GetLastInputDirectionTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastInputDirectionTransform_FunctionAddress, "ReturnValue");
		GetLastInputDirectionTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastInputDirectionTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLastInputDirectionTransform_IsValid = GetLastInputDirectionTransform_FunctionAddress != IntPtr.Zero && GetLastInputDirectionTransform_InputDirection_IsValid && GetLastInputDirectionTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:GetLastInputDirectionTransform", GetLastInputDirectionTransform_IsValid);
		GetKeyPoseDataFromAnim_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetKeyPoseDataFromAnim");
		GetKeyPoseDataFromAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKeyPoseDataFromAnim_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKeyPoseDataFromAnim_InSequence_PropertyAddress, GetKeyPoseDataFromAnim_FunctionAddress, "InSequence");
		GetKeyPoseDataFromAnim_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyPoseDataFromAnim_FunctionAddress, "InSequence");
		GetKeyPoseDataFromAnim_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyPoseDataFromAnim_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKeyPoseDataFromAnim_ReferenceClock_PropertyAddress, GetKeyPoseDataFromAnim_FunctionAddress, "ReferenceClock");
		GetKeyPoseDataFromAnim_ReferenceClock_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyPoseDataFromAnim_FunctionAddress, "ReferenceClock");
		GetKeyPoseDataFromAnim_ReferenceClock_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyPoseDataFromAnim_FunctionAddress, "ReferenceClock", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKeyPoseDataFromAnim_ToBeRefAgainst_PropertyAddress, GetKeyPoseDataFromAnim_FunctionAddress, "ToBeRefAgainst");
		GetKeyPoseDataFromAnim_ToBeRefAgainst_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyPoseDataFromAnim_FunctionAddress, "ToBeRefAgainst");
		GetKeyPoseDataFromAnim_ToBeRefAgainst_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyPoseDataFromAnim_FunctionAddress, "ToBeRefAgainst", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKeyPoseDataFromAnim_CalculatedMMData_PropertyAddress, GetKeyPoseDataFromAnim_FunctionAddress, "CalculatedMMData");
		GetKeyPoseDataFromAnim_CalculatedMMData_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyPoseDataFromAnim_FunctionAddress, "CalculatedMMData");
		GetKeyPoseDataFromAnim_CalculatedMMData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyPoseDataFromAnim_FunctionAddress, "CalculatedMMData", Classes.FStructProperty);
		GetKeyPoseDataFromAnim_IsValid = GetKeyPoseDataFromAnim_FunctionAddress != IntPtr.Zero && GetKeyPoseDataFromAnim_InSequence_IsValid && GetKeyPoseDataFromAnim_ReferenceClock_IsValid && GetKeyPoseDataFromAnim_ToBeRefAgainst_IsValid && GetKeyPoseDataFromAnim_CalculatedMMData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:GetKeyPoseDataFromAnim", GetKeyPoseDataFromAnim_IsValid);
		GetDataFromAnimation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDataFromAnimation");
		GetDataFromAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDataFromAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDataFromAnimation_InSequence_PropertyAddress, GetDataFromAnimation_FunctionAddress, "InSequence");
		GetDataFromAnimation_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetDataFromAnimation_FunctionAddress, "InSequence");
		GetDataFromAnimation_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataFromAnimation_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDataFromAnimation_ReferenceClock_PropertyAddress, GetDataFromAnimation_FunctionAddress, "ReferenceClock");
		GetDataFromAnimation_ReferenceClock_Offset = NativeReflectionCached.GetPropertyOffset(GetDataFromAnimation_FunctionAddress, "ReferenceClock");
		GetDataFromAnimation_ReferenceClock_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataFromAnimation_FunctionAddress, "ReferenceClock", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDataFromAnimation_SkeletonRuntimeName_PropertyAddress, GetDataFromAnimation_FunctionAddress, "SkeletonRuntimeName");
		GetDataFromAnimation_SkeletonRuntimeName_Offset = NativeReflectionCached.GetPropertyOffset(GetDataFromAnimation_FunctionAddress, "SkeletonRuntimeName");
		GetDataFromAnimation_SkeletonRuntimeName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataFromAnimation_FunctionAddress, "SkeletonRuntimeName", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDataFromAnimation_OutPresentInputDirection_PropertyAddress, GetDataFromAnimation_FunctionAddress, "OutPresentInputDirection");
		GetDataFromAnimation_OutPresentInputDirection_Offset = NativeReflectionCached.GetPropertyOffset(GetDataFromAnimation_FunctionAddress, "OutPresentInputDirection");
		GetDataFromAnimation_OutPresentInputDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataFromAnimation_FunctionAddress, "OutPresentInputDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDataFromAnimation_OutFutureInputDirection_PropertyAddress, GetDataFromAnimation_FunctionAddress, "OutFutureInputDirection");
		GetDataFromAnimation_OutFutureInputDirection_Offset = NativeReflectionCached.GetPropertyOffset(GetDataFromAnimation_FunctionAddress, "OutFutureInputDirection");
		GetDataFromAnimation_OutFutureInputDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataFromAnimation_FunctionAddress, "OutFutureInputDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDataFromAnimation_DeliveredAnimationReferencesForSkelRef_PropertyAddress, GetDataFromAnimation_FunctionAddress, "DeliveredAnimationReferencesForSkelRef");
		GetDataFromAnimation_DeliveredAnimationReferencesForSkelRef_Offset = NativeReflectionCached.GetPropertyOffset(GetDataFromAnimation_FunctionAddress, "DeliveredAnimationReferencesForSkelRef");
		GetDataFromAnimation_DeliveredAnimationReferencesForSkelRef_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataFromAnimation_FunctionAddress, "DeliveredAnimationReferencesForSkelRef", Classes.FArrayProperty);
		GetDataFromAnimation_IsValid = GetDataFromAnimation_FunctionAddress != IntPtr.Zero && GetDataFromAnimation_InSequence_IsValid && GetDataFromAnimation_ReferenceClock_IsValid && GetDataFromAnimation_SkeletonRuntimeName_IsValid && GetDataFromAnimation_OutPresentInputDirection_IsValid && GetDataFromAnimation_OutFutureInputDirection_IsValid && GetDataFromAnimation_DeliveredAnimationReferencesForSkelRef_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:GetDataFromAnimation", GetDataFromAnimation_IsValid);
		GetAnimVelocityReferenceClock_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimVelocityReferenceClock");
		GetAnimVelocityReferenceClock_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimVelocityReferenceClock_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimVelocityReferenceClock_InSequence_PropertyAddress, GetAnimVelocityReferenceClock_FunctionAddress, "InSequence");
		GetAnimVelocityReferenceClock_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimVelocityReferenceClock_FunctionAddress, "InSequence");
		GetAnimVelocityReferenceClock_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimVelocityReferenceClock_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimVelocityReferenceClock_ReferenceClock_PropertyAddress, GetAnimVelocityReferenceClock_FunctionAddress, "ReferenceClock");
		GetAnimVelocityReferenceClock_ReferenceClock_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimVelocityReferenceClock_FunctionAddress, "ReferenceClock");
		GetAnimVelocityReferenceClock_ReferenceClock_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimVelocityReferenceClock_FunctionAddress, "ReferenceClock", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_PropertyAddress, GetAnimVelocityReferenceClock_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVelocity");
		GetAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimVelocityReferenceClock_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVelocity");
		GetAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimVelocityReferenceClock_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVelocity", Classes.FStructProperty);
		GetAnimVelocityReferenceClock_IsValid = GetAnimVelocityReferenceClock_FunctionAddress != IntPtr.Zero && GetAnimVelocityReferenceClock_InSequence_IsValid && GetAnimVelocityReferenceClock_ReferenceClock_IsValid && GetAnimVelocityReferenceClock_DeliveredVelocityViaAnimBonesLocalVelocity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:GetAnimVelocityReferenceClock", GetAnimVelocityReferenceClock_IsValid);
		GetAnimJointData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimJointData");
		GetAnimJointData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimJointData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimJointData_InSequence_PropertyAddress, GetAnimJointData_FunctionAddress, "InSequence");
		GetAnimJointData_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimJointData_FunctionAddress, "InSequence");
		GetAnimJointData_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimJointData_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimJointData_ReferenceClock_PropertyAddress, GetAnimJointData_FunctionAddress, "ReferenceClock");
		GetAnimJointData_ReferenceClock_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimJointData_FunctionAddress, "ReferenceClock");
		GetAnimJointData_ReferenceClock_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimJointData_FunctionAddress, "ReferenceClock", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimJointData_BoneName_PropertyAddress, GetAnimJointData_FunctionAddress, "BoneName");
		GetAnimJointData_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimJointData_FunctionAddress, "BoneName");
		GetAnimJointData_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimJointData_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimJointData_DeliveredAnimationReferencesForSkelRef_PropertyAddress, GetAnimJointData_FunctionAddress, "DeliveredAnimationReferencesForSkelRef");
		GetAnimJointData_DeliveredAnimationReferencesForSkelRef_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimJointData_FunctionAddress, "DeliveredAnimationReferencesForSkelRef");
		GetAnimJointData_DeliveredAnimationReferencesForSkelRef_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimJointData_FunctionAddress, "DeliveredAnimationReferencesForSkelRef", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimJointData_InDeltaTime_PropertyAddress, GetAnimJointData_FunctionAddress, "InDeltaTime");
		GetAnimJointData_InDeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimJointData_FunctionAddress, "InDeltaTime");
		GetAnimJointData_InDeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimJointData_FunctionAddress, "InDeltaTime", Classes.FFloatProperty);
		GetAnimJointData_IsValid = GetAnimJointData_FunctionAddress != IntPtr.Zero && GetAnimJointData_InSequence_IsValid && GetAnimJointData_ReferenceClock_IsValid && GetAnimJointData_BoneName_IsValid && GetAnimJointData_DeliveredAnimationReferencesForSkelRef_IsValid && GetAnimJointData_InDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:GetAnimJointData", GetAnimJointData_IsValid);
		GetAnimBoneWorldTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimBoneWorldTransform");
		GetAnimBoneWorldTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimBoneWorldTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneWorldTransform_InSequence_PropertyAddress, GetAnimBoneWorldTransform_FunctionAddress, "InSequence");
		GetAnimBoneWorldTransform_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneWorldTransform_FunctionAddress, "InSequence");
		GetAnimBoneWorldTransform_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneWorldTransform_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneWorldTransform_ReferenceClock_PropertyAddress, GetAnimBoneWorldTransform_FunctionAddress, "ReferenceClock");
		GetAnimBoneWorldTransform_ReferenceClock_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneWorldTransform_FunctionAddress, "ReferenceClock");
		GetAnimBoneWorldTransform_ReferenceClock_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneWorldTransform_FunctionAddress, "ReferenceClock", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneWorldTransform_CurrentSkeletonPartInReference_PropertyAddress, GetAnimBoneWorldTransform_FunctionAddress, "CurrentSkeletonPartInReference");
		GetAnimBoneWorldTransform_CurrentSkeletonPartInReference_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneWorldTransform_FunctionAddress, "CurrentSkeletonPartInReference");
		GetAnimBoneWorldTransform_CurrentSkeletonPartInReference_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneWorldTransform_FunctionAddress, "CurrentSkeletonPartInReference", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneWorldTransform_SkelIdx2TrackIdx_PropertyAddress, GetAnimBoneWorldTransform_FunctionAddress, "SkelIdx2TrackIdx");
		GetAnimBoneWorldTransform_SkelIdx2TrackIdx_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneWorldTransform_FunctionAddress, "SkelIdx2TrackIdx");
		GetAnimBoneWorldTransform_SkelIdx2TrackIdx_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneWorldTransform_FunctionAddress, "SkelIdx2TrackIdx", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneWorldTransform_CalculatedTransformMM_PropertyAddress, GetAnimBoneWorldTransform_FunctionAddress, "CalculatedTransformMM");
		GetAnimBoneWorldTransform_CalculatedTransformMM_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneWorldTransform_FunctionAddress, "CalculatedTransformMM");
		GetAnimBoneWorldTransform_CalculatedTransformMM_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneWorldTransform_FunctionAddress, "CalculatedTransformMM", Classes.FStructProperty);
		GetAnimBoneWorldTransform_IsValid = GetAnimBoneWorldTransform_FunctionAddress != IntPtr.Zero && GetAnimBoneWorldTransform_InSequence_IsValid && GetAnimBoneWorldTransform_ReferenceClock_IsValid && GetAnimBoneWorldTransform_CurrentSkeletonPartInReference_IsValid && GetAnimBoneWorldTransform_SkelIdx2TrackIdx_IsValid && GetAnimBoneWorldTransform_CalculatedTransformMM_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:GetAnimBoneWorldTransform", GetAnimBoneWorldTransform_IsValid);
		GetAnimBoneLocalVel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimBoneLocalVel");
		GetAnimBoneLocalVel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimBoneLocalVel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneLocalVel_InSequence_PropertyAddress, GetAnimBoneLocalVel_FunctionAddress, "InSequence");
		GetAnimBoneLocalVel_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneLocalVel_FunctionAddress, "InSequence");
		GetAnimBoneLocalVel_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneLocalVel_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneLocalVel_ReferenceClock_PropertyAddress, GetAnimBoneLocalVel_FunctionAddress, "ReferenceClock");
		GetAnimBoneLocalVel_ReferenceClock_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneLocalVel_FunctionAddress, "ReferenceClock");
		GetAnimBoneLocalVel_ReferenceClock_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneLocalVel_FunctionAddress, "ReferenceClock", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneLocalVel_CurrentSkeletonPartInReference_PropertyAddress, GetAnimBoneLocalVel_FunctionAddress, "CurrentSkeletonPartInReference");
		GetAnimBoneLocalVel_CurrentSkeletonPartInReference_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneLocalVel_FunctionAddress, "CurrentSkeletonPartInReference");
		GetAnimBoneLocalVel_CurrentSkeletonPartInReference_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneLocalVel_FunctionAddress, "CurrentSkeletonPartInReference", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneLocalVel_SkelIdx2TrackIdx_PropertyAddress, GetAnimBoneLocalVel_FunctionAddress, "SkelIdx2TrackIdx");
		GetAnimBoneLocalVel_SkelIdx2TrackIdx_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneLocalVel_FunctionAddress, "SkelIdx2TrackIdx");
		GetAnimBoneLocalVel_SkelIdx2TrackIdx_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneLocalVel_FunctionAddress, "SkelIdx2TrackIdx", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneLocalVel_DeliveredVelocityViaAnimBonesLocalVel_PropertyAddress, GetAnimBoneLocalVel_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVel");
		GetAnimBoneLocalVel_DeliveredVelocityViaAnimBonesLocalVel_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneLocalVel_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVel");
		GetAnimBoneLocalVel_DeliveredVelocityViaAnimBonesLocalVel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneLocalVel_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVel", Classes.FStructProperty);
		GetAnimBoneLocalVel_IsValid = GetAnimBoneLocalVel_FunctionAddress != IntPtr.Zero && GetAnimBoneLocalVel_InSequence_IsValid && GetAnimBoneLocalVel_ReferenceClock_IsValid && GetAnimBoneLocalVel_CurrentSkeletonPartInReference_IsValid && GetAnimBoneLocalVel_SkelIdx2TrackIdx_IsValid && GetAnimBoneLocalVel_DeliveredVelocityViaAnimBonesLocalVel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:GetAnimBoneLocalVel", GetAnimBoneLocalVel_IsValid);
		GetAnimBoneLocalTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimBoneLocalTransform");
		GetAnimBoneLocalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimBoneLocalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneLocalTransform_InSequence_PropertyAddress, GetAnimBoneLocalTransform_FunctionAddress, "InSequence");
		GetAnimBoneLocalTransform_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneLocalTransform_FunctionAddress, "InSequence");
		GetAnimBoneLocalTransform_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneLocalTransform_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneLocalTransform_ReferenceClock_PropertyAddress, GetAnimBoneLocalTransform_FunctionAddress, "ReferenceClock");
		GetAnimBoneLocalTransform_ReferenceClock_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneLocalTransform_FunctionAddress, "ReferenceClock");
		GetAnimBoneLocalTransform_ReferenceClock_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneLocalTransform_FunctionAddress, "ReferenceClock", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneLocalTransform_CurrentSkeletonPartInReference_PropertyAddress, GetAnimBoneLocalTransform_FunctionAddress, "CurrentSkeletonPartInReference");
		GetAnimBoneLocalTransform_CurrentSkeletonPartInReference_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneLocalTransform_FunctionAddress, "CurrentSkeletonPartInReference");
		GetAnimBoneLocalTransform_CurrentSkeletonPartInReference_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneLocalTransform_FunctionAddress, "CurrentSkeletonPartInReference", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneLocalTransform_SkelIdx2TrackIdx_PropertyAddress, GetAnimBoneLocalTransform_FunctionAddress, "SkelIdx2TrackIdx");
		GetAnimBoneLocalTransform_SkelIdx2TrackIdx_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneLocalTransform_FunctionAddress, "SkelIdx2TrackIdx");
		GetAnimBoneLocalTransform_SkelIdx2TrackIdx_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneLocalTransform_FunctionAddress, "SkelIdx2TrackIdx", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBoneLocalTransform_CalculatedTransformMM_PropertyAddress, GetAnimBoneLocalTransform_FunctionAddress, "CalculatedTransformMM");
		GetAnimBoneLocalTransform_CalculatedTransformMM_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBoneLocalTransform_FunctionAddress, "CalculatedTransformMM");
		GetAnimBoneLocalTransform_CalculatedTransformMM_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBoneLocalTransform_FunctionAddress, "CalculatedTransformMM", Classes.FStructProperty);
		GetAnimBoneLocalTransform_IsValid = GetAnimBoneLocalTransform_FunctionAddress != IntPtr.Zero && GetAnimBoneLocalTransform_InSequence_IsValid && GetAnimBoneLocalTransform_ReferenceClock_IsValid && GetAnimBoneLocalTransform_CurrentSkeletonPartInReference_IsValid && GetAnimBoneLocalTransform_SkelIdx2TrackIdx_IsValid && GetAnimBoneLocalTransform_CalculatedTransformMM_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:GetAnimBoneLocalTransform", GetAnimBoneLocalTransform_IsValid);
		ExtractLMAnimInputDirection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExtractLMAnimInputDirection");
		ExtractLMAnimInputDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(ExtractLMAnimInputDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExtractLMAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_PropertyAddress, ExtractLMAnimInputDirection_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVelocityData");
		ExtractLMAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_Offset = NativeReflectionCached.GetPropertyOffset(ExtractLMAnimInputDirection_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVelocityData");
		ExtractLMAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractLMAnimInputDirection_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVelocityData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractLMAnimInputDirection_InSequence_PropertyAddress, ExtractLMAnimInputDirection_FunctionAddress, "InSequence");
		ExtractLMAnimInputDirection_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(ExtractLMAnimInputDirection_FunctionAddress, "InSequence");
		ExtractLMAnimInputDirection_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractLMAnimInputDirection_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractLMAnimInputDirection_ClockInGame_PropertyAddress, ExtractLMAnimInputDirection_FunctionAddress, "ClockInGame");
		ExtractLMAnimInputDirection_ClockInGame_Offset = NativeReflectionCached.GetPropertyOffset(ExtractLMAnimInputDirection_FunctionAddress, "ClockInGame");
		ExtractLMAnimInputDirection_ClockInGame_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractLMAnimInputDirection_FunctionAddress, "ClockInGame", Classes.FFloatProperty);
		ExtractLMAnimInputDirection_IsValid = ExtractLMAnimInputDirection_FunctionAddress != IntPtr.Zero && ExtractLMAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_IsValid && ExtractLMAnimInputDirection_InSequence_IsValid && ExtractLMAnimInputDirection_ClockInGame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:ExtractLMAnimInputDirection", ExtractLMAnimInputDirection_IsValid);
		ExtractAnimSmoothedRotation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExtractAnimSmoothedRotation");
		ExtractAnimSmoothedRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(ExtractAnimSmoothedRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExtractAnimSmoothedRotation_DeliveredRotation_PropertyAddress, ExtractAnimSmoothedRotation_FunctionAddress, "DeliveredRotation");
		ExtractAnimSmoothedRotation_DeliveredRotation_Offset = NativeReflectionCached.GetPropertyOffset(ExtractAnimSmoothedRotation_FunctionAddress, "DeliveredRotation");
		ExtractAnimSmoothedRotation_DeliveredRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractAnimSmoothedRotation_FunctionAddress, "DeliveredRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractAnimSmoothedRotation_InSequence_PropertyAddress, ExtractAnimSmoothedRotation_FunctionAddress, "InSequence");
		ExtractAnimSmoothedRotation_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(ExtractAnimSmoothedRotation_FunctionAddress, "InSequence");
		ExtractAnimSmoothedRotation_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractAnimSmoothedRotation_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractAnimSmoothedRotation_ClockInGame_PropertyAddress, ExtractAnimSmoothedRotation_FunctionAddress, "ClockInGame");
		ExtractAnimSmoothedRotation_ClockInGame_Offset = NativeReflectionCached.GetPropertyOffset(ExtractAnimSmoothedRotation_FunctionAddress, "ClockInGame");
		ExtractAnimSmoothedRotation_ClockInGame_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractAnimSmoothedRotation_FunctionAddress, "ClockInGame", Classes.FFloatProperty);
		ExtractAnimSmoothedRotation_IsValid = ExtractAnimSmoothedRotation_FunctionAddress != IntPtr.Zero && ExtractAnimSmoothedRotation_DeliveredRotation_IsValid && ExtractAnimSmoothedRotation_InSequence_IsValid && ExtractAnimSmoothedRotation_ClockInGame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:ExtractAnimSmoothedRotation", ExtractAnimSmoothedRotation_IsValid);
		ExtractAnimInputDirection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExtractAnimInputDirection");
		ExtractAnimInputDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(ExtractAnimInputDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExtractAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_PropertyAddress, ExtractAnimInputDirection_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVelocityData");
		ExtractAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_Offset = NativeReflectionCached.GetPropertyOffset(ExtractAnimInputDirection_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVelocityData");
		ExtractAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractAnimInputDirection_FunctionAddress, "DeliveredVelocityViaAnimBonesLocalVelocityData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractAnimInputDirection_InSequence_PropertyAddress, ExtractAnimInputDirection_FunctionAddress, "InSequence");
		ExtractAnimInputDirection_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(ExtractAnimInputDirection_FunctionAddress, "InSequence");
		ExtractAnimInputDirection_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractAnimInputDirection_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractAnimInputDirection_ClockInGame_PropertyAddress, ExtractAnimInputDirection_FunctionAddress, "ClockInGame");
		ExtractAnimInputDirection_ClockInGame_Offset = NativeReflectionCached.GetPropertyOffset(ExtractAnimInputDirection_FunctionAddress, "ClockInGame");
		ExtractAnimInputDirection_ClockInGame_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractAnimInputDirection_FunctionAddress, "ClockInGame", Classes.FFloatProperty);
		ExtractAnimInputDirection_IsValid = ExtractAnimInputDirection_FunctionAddress != IntPtr.Zero && ExtractAnimInputDirection_DeliveredVelocityViaAnimBonesLocalVelocityData_IsValid && ExtractAnimInputDirection_InSequence_IsValid && ExtractAnimInputDirection_ClockInGame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:ExtractAnimInputDirection", ExtractAnimInputDirection_IsValid);
		CreateInputDirection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateInputDirection");
		CreateInputDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateInputDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateInputDirection_OutConstructTargetDirection_PropertyAddress, CreateInputDirection_FunctionAddress, "OutConstructTargetDirection");
		CreateInputDirection_OutConstructTargetDirection_Offset = NativeReflectionCached.GetPropertyOffset(CreateInputDirection_FunctionAddress, "OutConstructTargetDirection");
		CreateInputDirection_OutConstructTargetDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInputDirection_FunctionAddress, "OutConstructTargetDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateInputDirection_DesiredTransform_PropertyAddress, CreateInputDirection_FunctionAddress, "DesiredTransform");
		CreateInputDirection_DesiredTransform_Offset = NativeReflectionCached.GetPropertyOffset(CreateInputDirection_FunctionAddress, "DesiredTransform");
		CreateInputDirection_DesiredTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInputDirection_FunctionAddress, "DesiredTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateInputDirection_RootWorldTransform_PropertyAddress, CreateInputDirection_FunctionAddress, "RootWorldTransform");
		CreateInputDirection_RootWorldTransform_Offset = NativeReflectionCached.GetPropertyOffset(CreateInputDirection_FunctionAddress, "RootWorldTransform");
		CreateInputDirection_RootWorldTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInputDirection_FunctionAddress, "RootWorldTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateInputDirection_TargetDirectionInputStrength_PropertyAddress, CreateInputDirection_FunctionAddress, "TargetDirectionInputStrength");
		CreateInputDirection_TargetDirectionInputStrength_Offset = NativeReflectionCached.GetPropertyOffset(CreateInputDirection_FunctionAddress, "TargetDirectionInputStrength");
		CreateInputDirection_TargetDirectionInputStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInputDirection_FunctionAddress, "TargetDirectionInputStrength", Classes.FFloatProperty);
		CreateInputDirection_IsValid = CreateInputDirection_FunctionAddress != IntPtr.Zero && CreateInputDirection_OutConstructTargetDirection_IsValid && CreateInputDirection_DesiredTransform_IsValid && CreateInputDirection_RootWorldTransform_IsValid && CreateInputDirection_TargetDirectionInputStrength_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:CreateInputDirection", CreateInputDirection_IsValid);
		CompareTrajectories_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CompareTrajectories");
		CompareTrajectories_ParamsSize = NativeReflection.GetFunctionParamsSize(CompareTrajectories_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CompareTrajectories_InputDirectionData_A_PropertyAddress, CompareTrajectories_FunctionAddress, "InputDirectionData_A");
		CompareTrajectories_InputDirectionData_A_Offset = NativeReflectionCached.GetPropertyOffset(CompareTrajectories_FunctionAddress, "InputDirectionData_A");
		CompareTrajectories_InputDirectionData_A_IsValid = NativeReflectionCached.ValidatePropertyClass(CompareTrajectories_FunctionAddress, "InputDirectionData_A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CompareTrajectories_InputDirectionData_B_PropertyAddress, CompareTrajectories_FunctionAddress, "InputDirectionData_B");
		CompareTrajectories_InputDirectionData_B_Offset = NativeReflectionCached.GetPropertyOffset(CompareTrajectories_FunctionAddress, "InputDirectionData_B");
		CompareTrajectories_InputDirectionData_B_IsValid = NativeReflectionCached.ValidatePropertyClass(CompareTrajectories_FunctionAddress, "InputDirectionData_B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CompareTrajectories_ReturnValue_PropertyAddress, CompareTrajectories_FunctionAddress, "ReturnValue");
		CompareTrajectories_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CompareTrajectories_FunctionAddress, "ReturnValue");
		CompareTrajectories_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CompareTrajectories_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CompareTrajectories_IsValid = CompareTrajectories_FunctionAddress != IntPtr.Zero && CompareTrajectories_InputDirectionData_A_IsValid && CompareTrajectories_InputDirectionData_B_IsValid && CompareTrajectories_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:CompareTrajectories", CompareTrajectories_IsValid);
		CompareJointDatas_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CompareJointDatas");
		CompareJointDatas_ParamsSize = NativeReflection.GetFunctionParamsSize(CompareJointDatas_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CompareJointDatas_JointData_A_PropertyAddress, CompareJointDatas_FunctionAddress, "JointData_A");
		CompareJointDatas_JointData_A_Offset = NativeReflectionCached.GetPropertyOffset(CompareJointDatas_FunctionAddress, "JointData_A");
		CompareJointDatas_JointData_A_IsValid = NativeReflectionCached.ValidatePropertyClass(CompareJointDatas_FunctionAddress, "JointData_A", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CompareJointDatas_JointData_B_PropertyAddress, CompareJointDatas_FunctionAddress, "JointData_B");
		CompareJointDatas_JointData_B_Offset = NativeReflectionCached.GetPropertyOffset(CompareJointDatas_FunctionAddress, "JointData_B");
		CompareJointDatas_JointData_B_IsValid = NativeReflectionCached.ValidatePropertyClass(CompareJointDatas_FunctionAddress, "JointData_B", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CompareJointDatas_ReturnValue_PropertyAddress, CompareJointDatas_FunctionAddress, "ReturnValue");
		CompareJointDatas_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CompareJointDatas_FunctionAddress, "ReturnValue");
		CompareJointDatas_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CompareJointDatas_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CompareJointDatas_IsValid = CompareJointDatas_FunctionAddress != IntPtr.Zero && CompareJointDatas_JointData_A_IsValid && CompareJointDatas_JointData_B_IsValid && CompareJointDatas_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:CompareJointDatas", CompareJointDatas_IsValid);
		BlendKeyPoses_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BlendKeyPoses");
		BlendKeyPoses_ParamsSize = NativeReflection.GetFunctionParamsSize(BlendKeyPoses_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BlendKeyPoses_PoseA_PropertyAddress, BlendKeyPoses_FunctionAddress, "PoseA");
		BlendKeyPoses_PoseA_Offset = NativeReflectionCached.GetPropertyOffset(BlendKeyPoses_FunctionAddress, "PoseA");
		BlendKeyPoses_PoseA_IsValid = NativeReflectionCached.ValidatePropertyClass(BlendKeyPoses_FunctionAddress, "PoseA", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendKeyPoses_PoseB_PropertyAddress, BlendKeyPoses_FunctionAddress, "PoseB");
		BlendKeyPoses_PoseB_Offset = NativeReflectionCached.GetPropertyOffset(BlendKeyPoses_FunctionAddress, "PoseB");
		BlendKeyPoses_PoseB_IsValid = NativeReflectionCached.ValidatePropertyClass(BlendKeyPoses_FunctionAddress, "PoseB", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendKeyPoses_Alpha_PropertyAddress, BlendKeyPoses_FunctionAddress, "Alpha");
		BlendKeyPoses_Alpha_Offset = NativeReflectionCached.GetPropertyOffset(BlendKeyPoses_FunctionAddress, "Alpha");
		BlendKeyPoses_Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(BlendKeyPoses_FunctionAddress, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendKeyPoses_OutBlendedKeyPose_PropertyAddress, BlendKeyPoses_FunctionAddress, "OutBlendedKeyPose");
		BlendKeyPoses_OutBlendedKeyPose_Offset = NativeReflectionCached.GetPropertyOffset(BlendKeyPoses_FunctionAddress, "OutBlendedKeyPose");
		BlendKeyPoses_OutBlendedKeyPose_IsValid = NativeReflectionCached.ValidatePropertyClass(BlendKeyPoses_FunctionAddress, "OutBlendedKeyPose", Classes.FStructProperty);
		BlendKeyPoses_IsValid = BlendKeyPoses_FunctionAddress != IntPtr.Zero && BlendKeyPoses_PoseA_IsValid && BlendKeyPoses_PoseB_IsValid && BlendKeyPoses_Alpha_IsValid && BlendKeyPoses_OutBlendedKeyPose_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MM.MotionMatchingHelpers:BlendKeyPoses", BlendKeyPoses_IsValid);
	}
}
