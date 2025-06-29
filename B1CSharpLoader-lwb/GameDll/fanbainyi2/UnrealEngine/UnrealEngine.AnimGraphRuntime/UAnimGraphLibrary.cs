using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AnimGraphRuntime.KismetAnimationLibrary", "AnimGraphRuntime", UnrealModuleType.Engine)]
public class UAnimGraphLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TwoBoneIK_IsValid;

	private static IntPtr TwoBoneIK_FunctionAddress;

	private static int TwoBoneIK_ParamsSize;

	private static bool TwoBoneIK_RootPos_IsValid;

	private static FFieldAddress TwoBoneIK_RootPos_PropertyAddress;

	private static int TwoBoneIK_RootPos_Offset;

	private static bool TwoBoneIK_JointPos_IsValid;

	private static FFieldAddress TwoBoneIK_JointPos_PropertyAddress;

	private static int TwoBoneIK_JointPos_Offset;

	private static bool TwoBoneIK_EndPos_IsValid;

	private static FFieldAddress TwoBoneIK_EndPos_PropertyAddress;

	private static int TwoBoneIK_EndPos_Offset;

	private static bool TwoBoneIK_JointTarget_IsValid;

	private static FFieldAddress TwoBoneIK_JointTarget_PropertyAddress;

	private static int TwoBoneIK_JointTarget_Offset;

	private static bool TwoBoneIK_Effector_IsValid;

	private static FFieldAddress TwoBoneIK_Effector_PropertyAddress;

	private static int TwoBoneIK_Effector_Offset;

	private static bool TwoBoneIK_OutJointPos_IsValid;

	private static FFieldAddress TwoBoneIK_OutJointPos_PropertyAddress;

	private static int TwoBoneIK_OutJointPos_Offset;

	private static bool TwoBoneIK_OutEndPos_IsValid;

	private static FFieldAddress TwoBoneIK_OutEndPos_PropertyAddress;

	private static int TwoBoneIK_OutEndPos_Offset;

	private static bool TwoBoneIK_bAllowStretching_IsValid;

	private static FFieldAddress TwoBoneIK_bAllowStretching_PropertyAddress;

	private static int TwoBoneIK_bAllowStretching_Offset;

	private static bool TwoBoneIK_StartStretchRatio_IsValid;

	private static FFieldAddress TwoBoneIK_StartStretchRatio_PropertyAddress;

	private static int TwoBoneIK_StartStretchRatio_Offset;

	private static bool TwoBoneIK_MaxStretchScale_IsValid;

	private static FFieldAddress TwoBoneIK_MaxStretchScale_PropertyAddress;

	private static int TwoBoneIK_MaxStretchScale_Offset;

	private static bool StartProfilingTimer_IsValid;

	private static IntPtr StartProfilingTimer_FunctionAddress;

	private static int StartProfilingTimer_ParamsSize;

	private static bool MakeVectorFromPerlinNoise_IsValid;

	private static IntPtr MakeVectorFromPerlinNoise_FunctionAddress;

	private static int MakeVectorFromPerlinNoise_ParamsSize;

	private static bool MakeVectorFromPerlinNoise_X_IsValid;

	private static FFieldAddress MakeVectorFromPerlinNoise_X_PropertyAddress;

	private static int MakeVectorFromPerlinNoise_X_Offset;

	private static bool MakeVectorFromPerlinNoise_Y_IsValid;

	private static FFieldAddress MakeVectorFromPerlinNoise_Y_PropertyAddress;

	private static int MakeVectorFromPerlinNoise_Y_Offset;

	private static bool MakeVectorFromPerlinNoise_Z_IsValid;

	private static FFieldAddress MakeVectorFromPerlinNoise_Z_PropertyAddress;

	private static int MakeVectorFromPerlinNoise_Z_Offset;

	private static bool MakeVectorFromPerlinNoise_RangeOutMinX_IsValid;

	private static FFieldAddress MakeVectorFromPerlinNoise_RangeOutMinX_PropertyAddress;

	private static int MakeVectorFromPerlinNoise_RangeOutMinX_Offset;

	private static bool MakeVectorFromPerlinNoise_RangeOutMaxX_IsValid;

	private static FFieldAddress MakeVectorFromPerlinNoise_RangeOutMaxX_PropertyAddress;

	private static int MakeVectorFromPerlinNoise_RangeOutMaxX_Offset;

	private static bool MakeVectorFromPerlinNoise_RangeOutMinY_IsValid;

	private static FFieldAddress MakeVectorFromPerlinNoise_RangeOutMinY_PropertyAddress;

	private static int MakeVectorFromPerlinNoise_RangeOutMinY_Offset;

	private static bool MakeVectorFromPerlinNoise_RangeOutMaxY_IsValid;

	private static FFieldAddress MakeVectorFromPerlinNoise_RangeOutMaxY_PropertyAddress;

	private static int MakeVectorFromPerlinNoise_RangeOutMaxY_Offset;

	private static bool MakeVectorFromPerlinNoise_RangeOutMinZ_IsValid;

	private static FFieldAddress MakeVectorFromPerlinNoise_RangeOutMinZ_PropertyAddress;

	private static int MakeVectorFromPerlinNoise_RangeOutMinZ_Offset;

	private static bool MakeVectorFromPerlinNoise_RangeOutMaxZ_IsValid;

	private static FFieldAddress MakeVectorFromPerlinNoise_RangeOutMaxZ_PropertyAddress;

	private static int MakeVectorFromPerlinNoise_RangeOutMaxZ_Offset;

	private static bool MakeVectorFromPerlinNoise_ReturnValue_IsValid;

	private static FFieldAddress MakeVectorFromPerlinNoise_ReturnValue_PropertyAddress;

	private static int MakeVectorFromPerlinNoise_ReturnValue_Offset;

	private static bool MakeFloatFromPerlinNoise_IsValid;

	private static IntPtr MakeFloatFromPerlinNoise_FunctionAddress;

	private static int MakeFloatFromPerlinNoise_ParamsSize;

	private static bool MakeFloatFromPerlinNoise_Value_IsValid;

	private static FFieldAddress MakeFloatFromPerlinNoise_Value_PropertyAddress;

	private static int MakeFloatFromPerlinNoise_Value_Offset;

	private static bool MakeFloatFromPerlinNoise_RangeOutMin_IsValid;

	private static FFieldAddress MakeFloatFromPerlinNoise_RangeOutMin_PropertyAddress;

	private static int MakeFloatFromPerlinNoise_RangeOutMin_Offset;

	private static bool MakeFloatFromPerlinNoise_RangeOutMax_IsValid;

	private static FFieldAddress MakeFloatFromPerlinNoise_RangeOutMax_PropertyAddress;

	private static int MakeFloatFromPerlinNoise_RangeOutMax_Offset;

	private static bool MakeFloatFromPerlinNoise_ReturnValue_IsValid;

	private static FFieldAddress MakeFloatFromPerlinNoise_ReturnValue_PropertyAddress;

	private static int MakeFloatFromPerlinNoise_ReturnValue_Offset;

	private static bool LookAt_IsValid;

	private static IntPtr LookAt_FunctionAddress;

	private static int LookAt_ParamsSize;

	private static bool LookAt_CurrentTransform_IsValid;

	private static FFieldAddress LookAt_CurrentTransform_PropertyAddress;

	private static int LookAt_CurrentTransform_Offset;

	private static bool LookAt_TargetPosition_IsValid;

	private static FFieldAddress LookAt_TargetPosition_PropertyAddress;

	private static int LookAt_TargetPosition_Offset;

	private static bool LookAt_LookAtVector_IsValid;

	private static FFieldAddress LookAt_LookAtVector_PropertyAddress;

	private static int LookAt_LookAtVector_Offset;

	private static bool LookAt_bUseUpVector_IsValid;

	private static FFieldAddress LookAt_bUseUpVector_PropertyAddress;

	private static int LookAt_bUseUpVector_Offset;

	private static bool LookAt_UpVector_IsValid;

	private static FFieldAddress LookAt_UpVector_PropertyAddress;

	private static int LookAt_UpVector_Offset;

	private static bool LookAt_ClampConeInDegree_IsValid;

	private static FFieldAddress LookAt_ClampConeInDegree_PropertyAddress;

	private static int LookAt_ClampConeInDegree_Offset;

	private static bool LookAt_ReturnValue_IsValid;

	private static FFieldAddress LookAt_ReturnValue_PropertyAddress;

	private static int LookAt_ReturnValue_Offset;

	private static bool EndProfilingTimer_IsValid;

	private static IntPtr EndProfilingTimer_FunctionAddress;

	private static int EndProfilingTimer_ParamsSize;

	private static bool EndProfilingTimer_bLog_IsValid;

	private static FFieldAddress EndProfilingTimer_bLog_PropertyAddress;

	private static int EndProfilingTimer_bLog_Offset;

	private static bool EndProfilingTimer_LogPrefix_IsValid;

	private static FFieldAddress EndProfilingTimer_LogPrefix_PropertyAddress;

	private static int EndProfilingTimer_LogPrefix_Offset;

	private static bool EndProfilingTimer_ReturnValue_IsValid;

	private static FFieldAddress EndProfilingTimer_ReturnValue_PropertyAddress;

	private static int EndProfilingTimer_ReturnValue_Offset;

	private static bool DistanceBetweenSockets_IsValid;

	private static IntPtr DistanceBetweenSockets_FunctionAddress;

	private static int DistanceBetweenSockets_ParamsSize;

	private static bool DistanceBetweenSockets_Component_IsValid;

	private static FFieldAddress DistanceBetweenSockets_Component_PropertyAddress;

	private static int DistanceBetweenSockets_Component_Offset;

	private static bool DistanceBetweenSockets_SocketOrBoneNameA_IsValid;

	private static FFieldAddress DistanceBetweenSockets_SocketOrBoneNameA_PropertyAddress;

	private static int DistanceBetweenSockets_SocketOrBoneNameA_Offset;

	private static bool DistanceBetweenSockets_SocketSpaceA_IsValid;

	private static FFieldAddress DistanceBetweenSockets_SocketSpaceA_PropertyAddress;

	private static int DistanceBetweenSockets_SocketSpaceA_Offset;

	private static bool DistanceBetweenSockets_SocketOrBoneNameB_IsValid;

	private static FFieldAddress DistanceBetweenSockets_SocketOrBoneNameB_PropertyAddress;

	private static int DistanceBetweenSockets_SocketOrBoneNameB_Offset;

	private static bool DistanceBetweenSockets_SocketSpaceB_IsValid;

	private static FFieldAddress DistanceBetweenSockets_SocketSpaceB_PropertyAddress;

	private static int DistanceBetweenSockets_SocketSpaceB_Offset;

	private static bool DistanceBetweenSockets_bRemapRange_IsValid;

	private static FFieldAddress DistanceBetweenSockets_bRemapRange_PropertyAddress;

	private static int DistanceBetweenSockets_bRemapRange_Offset;

	private static bool DistanceBetweenSockets_InRangeMin_IsValid;

	private static FFieldAddress DistanceBetweenSockets_InRangeMin_PropertyAddress;

	private static int DistanceBetweenSockets_InRangeMin_Offset;

	private static bool DistanceBetweenSockets_InRangeMax_IsValid;

	private static FFieldAddress DistanceBetweenSockets_InRangeMax_PropertyAddress;

	private static int DistanceBetweenSockets_InRangeMax_Offset;

	private static bool DistanceBetweenSockets_OutRangeMin_IsValid;

	private static FFieldAddress DistanceBetweenSockets_OutRangeMin_PropertyAddress;

	private static int DistanceBetweenSockets_OutRangeMin_Offset;

	private static bool DistanceBetweenSockets_OutRangeMax_IsValid;

	private static FFieldAddress DistanceBetweenSockets_OutRangeMax_PropertyAddress;

	private static int DistanceBetweenSockets_OutRangeMax_Offset;

	private static bool DistanceBetweenSockets_ReturnValue_IsValid;

	private static FFieldAddress DistanceBetweenSockets_ReturnValue_PropertyAddress;

	private static int DistanceBetweenSockets_ReturnValue_Offset;

	private static bool DirectionBetweenSockets_IsValid;

	private static IntPtr DirectionBetweenSockets_FunctionAddress;

	private static int DirectionBetweenSockets_ParamsSize;

	private static bool DirectionBetweenSockets_Component_IsValid;

	private static FFieldAddress DirectionBetweenSockets_Component_PropertyAddress;

	private static int DirectionBetweenSockets_Component_Offset;

	private static bool DirectionBetweenSockets_SocketOrBoneNameFrom_IsValid;

	private static FFieldAddress DirectionBetweenSockets_SocketOrBoneNameFrom_PropertyAddress;

	private static int DirectionBetweenSockets_SocketOrBoneNameFrom_Offset;

	private static bool DirectionBetweenSockets_SocketOrBoneNameTo_IsValid;

	private static FFieldAddress DirectionBetweenSockets_SocketOrBoneNameTo_PropertyAddress;

	private static int DirectionBetweenSockets_SocketOrBoneNameTo_Offset;

	private static bool DirectionBetweenSockets_ReturnValue_IsValid;

	private static FFieldAddress DirectionBetweenSockets_ReturnValue_PropertyAddress;

	private static int DirectionBetweenSockets_ReturnValue_Offset;

	private static bool CalculateVelocityFromSockets_IsValid;

	private static IntPtr CalculateVelocityFromSockets_FunctionAddress;

	private static int CalculateVelocityFromSockets_ParamsSize;

	private static bool CalculateVelocityFromSockets_DeltaSeconds_IsValid;

	private static FFieldAddress CalculateVelocityFromSockets_DeltaSeconds_PropertyAddress;

	private static int CalculateVelocityFromSockets_DeltaSeconds_Offset;

	private static bool CalculateVelocityFromSockets_Component_IsValid;

	private static FFieldAddress CalculateVelocityFromSockets_Component_PropertyAddress;

	private static int CalculateVelocityFromSockets_Component_Offset;

	private static bool CalculateVelocityFromSockets_SocketOrBoneName_IsValid;

	private static FFieldAddress CalculateVelocityFromSockets_SocketOrBoneName_PropertyAddress;

	private static int CalculateVelocityFromSockets_SocketOrBoneName_Offset;

	private static bool CalculateVelocityFromSockets_ReferenceSocketOrBone_IsValid;

	private static FFieldAddress CalculateVelocityFromSockets_ReferenceSocketOrBone_PropertyAddress;

	private static int CalculateVelocityFromSockets_ReferenceSocketOrBone_Offset;

	private static bool CalculateVelocityFromSockets_SocketSpace_IsValid;

	private static FFieldAddress CalculateVelocityFromSockets_SocketSpace_PropertyAddress;

	private static int CalculateVelocityFromSockets_SocketSpace_Offset;

	private static bool CalculateVelocityFromSockets_OffsetInBoneSpace_IsValid;

	private static FFieldAddress CalculateVelocityFromSockets_OffsetInBoneSpace_PropertyAddress;

	private static int CalculateVelocityFromSockets_OffsetInBoneSpace_Offset;

	private static bool CalculateVelocityFromSockets_History_IsValid;

	private static FFieldAddress CalculateVelocityFromSockets_History_PropertyAddress;

	private static int CalculateVelocityFromSockets_History_Offset;

	private static bool CalculateVelocityFromSockets_NumberOfSamples_IsValid;

	private static FFieldAddress CalculateVelocityFromSockets_NumberOfSamples_PropertyAddress;

	private static int CalculateVelocityFromSockets_NumberOfSamples_Offset;

	private static bool CalculateVelocityFromSockets_VelocityMin_IsValid;

	private static FFieldAddress CalculateVelocityFromSockets_VelocityMin_PropertyAddress;

	private static int CalculateVelocityFromSockets_VelocityMin_Offset;

	private static bool CalculateVelocityFromSockets_VelocityMax_IsValid;

	private static FFieldAddress CalculateVelocityFromSockets_VelocityMax_PropertyAddress;

	private static int CalculateVelocityFromSockets_VelocityMax_Offset;

	private static bool CalculateVelocityFromSockets_EasingType_IsValid;

	private static FFieldAddress CalculateVelocityFromSockets_EasingType_PropertyAddress;

	private static int CalculateVelocityFromSockets_EasingType_Offset;

	private static bool CalculateVelocityFromSockets_CustomCurve_IsValid;

	private static FFieldAddress CalculateVelocityFromSockets_CustomCurve_PropertyAddress;

	private static int CalculateVelocityFromSockets_CustomCurve_Offset;

	private static bool CalculateVelocityFromSockets_ReturnValue_IsValid;

	private static FFieldAddress CalculateVelocityFromSockets_ReturnValue_PropertyAddress;

	private static int CalculateVelocityFromSockets_ReturnValue_Offset;

	private static bool CalculateVelocityFromPositionHistory_IsValid;

	private static IntPtr CalculateVelocityFromPositionHistory_FunctionAddress;

	private static int CalculateVelocityFromPositionHistory_ParamsSize;

	private static bool CalculateVelocityFromPositionHistory_DeltaSeconds_IsValid;

	private static FFieldAddress CalculateVelocityFromPositionHistory_DeltaSeconds_PropertyAddress;

	private static int CalculateVelocityFromPositionHistory_DeltaSeconds_Offset;

	private static bool CalculateVelocityFromPositionHistory_Position_IsValid;

	private static FFieldAddress CalculateVelocityFromPositionHistory_Position_PropertyAddress;

	private static int CalculateVelocityFromPositionHistory_Position_Offset;

	private static bool CalculateVelocityFromPositionHistory_History_IsValid;

	private static FFieldAddress CalculateVelocityFromPositionHistory_History_PropertyAddress;

	private static int CalculateVelocityFromPositionHistory_History_Offset;

	private static bool CalculateVelocityFromPositionHistory_NumberOfSamples_IsValid;

	private static FFieldAddress CalculateVelocityFromPositionHistory_NumberOfSamples_PropertyAddress;

	private static int CalculateVelocityFromPositionHistory_NumberOfSamples_Offset;

	private static bool CalculateVelocityFromPositionHistory_VelocityMin_IsValid;

	private static FFieldAddress CalculateVelocityFromPositionHistory_VelocityMin_PropertyAddress;

	private static int CalculateVelocityFromPositionHistory_VelocityMin_Offset;

	private static bool CalculateVelocityFromPositionHistory_VelocityMax_IsValid;

	private static FFieldAddress CalculateVelocityFromPositionHistory_VelocityMax_PropertyAddress;

	private static int CalculateVelocityFromPositionHistory_VelocityMax_Offset;

	private static bool CalculateVelocityFromPositionHistory_ReturnValue_IsValid;

	private static FFieldAddress CalculateVelocityFromPositionHistory_ReturnValue_PropertyAddress;

	private static int CalculateVelocityFromPositionHistory_ReturnValue_Offset;

	private static bool CalculateDirection_IsValid;

	private static IntPtr CalculateDirection_FunctionAddress;

	private static int CalculateDirection_ParamsSize;

	private static bool CalculateDirection_Velocity_IsValid;

	private static FFieldAddress CalculateDirection_Velocity_PropertyAddress;

	private static int CalculateDirection_Velocity_Offset;

	private static bool CalculateDirection_BaseRotation_IsValid;

	private static FFieldAddress CalculateDirection_BaseRotation_PropertyAddress;

	private static int CalculateDirection_BaseRotation_Offset;

	private static bool CalculateDirection_ReturnValue_IsValid;

	private static FFieldAddress CalculateDirection_ReturnValue_PropertyAddress;

	private static int CalculateDirection_ReturnValue_Offset;

	[UFunction(Flags = 348267521u, OriginalName = "K2_TwoBoneIK")]
	[UMetaPath("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_TwoBoneIK")]
	public unsafe static void TwoBoneIK(FVector RootPos, FVector JointPos, FVector EndPos, FVector JointTarget, FVector Effector, out FVector OutJointPos, out FVector OutEndPos, bool bAllowStretching, float StartStretchRatio, float MaxStretchScale)
	{
		if (!TwoBoneIK_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_TwoBoneIK");
			OutJointPos = default(FVector);
			OutEndPos = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TwoBoneIK_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TwoBoneIK_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TwoBoneIK_RootPos_Offset), 0, TwoBoneIK_RootPos_PropertyAddress.Address, RootPos);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TwoBoneIK_JointPos_Offset), 0, TwoBoneIK_JointPos_PropertyAddress.Address, JointPos);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TwoBoneIK_EndPos_Offset), 0, TwoBoneIK_EndPos_PropertyAddress.Address, EndPos);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TwoBoneIK_JointTarget_Offset), 0, TwoBoneIK_JointTarget_PropertyAddress.Address, JointTarget);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TwoBoneIK_Effector_Offset), 0, TwoBoneIK_Effector_PropertyAddress.Address, Effector);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TwoBoneIK_bAllowStretching_Offset), 0, TwoBoneIK_bAllowStretching_PropertyAddress.Address, bAllowStretching);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TwoBoneIK_StartStretchRatio_Offset), 0, TwoBoneIK_StartStretchRatio_PropertyAddress.Address, StartStretchRatio);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TwoBoneIK_MaxStretchScale_Offset), 0, TwoBoneIK_MaxStretchScale_PropertyAddress.Address, MaxStretchScale);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TwoBoneIK_FunctionAddress, intPtr, TwoBoneIK_ParamsSize);
		OutJointPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, TwoBoneIK_OutJointPos_Offset), 0, TwoBoneIK_OutJointPos_PropertyAddress.Address);
		OutEndPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, TwoBoneIK_OutEndPos_Offset), 0, TwoBoneIK_OutEndPos_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u, OriginalName = "K2_StartProfilingTimer")]
	[UMetaPath("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_StartProfilingTimer")]
	public unsafe static void StartProfilingTimer()
	{
		if (!StartProfilingTimer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_StartProfilingTimer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartProfilingTimer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartProfilingTimer_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: StartProfilingTimer_FunctionAddress, argsSize: StartProfilingTimer_ParamsSize);
	}

	[UFunction(Flags = 344073217u, OriginalName = "K2_MakePerlinNoiseVectorAndRemap")]
	[UMetaPath("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_MakePerlinNoiseVectorAndRemap")]
	public unsafe static FVector MakeVectorFromPerlinNoise(float X, float Y, float Z, float RangeOutMinX, float RangeOutMaxX, float RangeOutMinY, float RangeOutMaxY, float RangeOutMinZ, float RangeOutMaxZ)
	{
		if (!MakeVectorFromPerlinNoise_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_MakePerlinNoiseVectorAndRemap");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeVectorFromPerlinNoise_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeVectorFromPerlinNoise_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeVectorFromPerlinNoise_X_Offset), 0, MakeVectorFromPerlinNoise_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeVectorFromPerlinNoise_Y_Offset), 0, MakeVectorFromPerlinNoise_Y_PropertyAddress.Address, Y);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeVectorFromPerlinNoise_Z_Offset), 0, MakeVectorFromPerlinNoise_Z_PropertyAddress.Address, Z);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeVectorFromPerlinNoise_RangeOutMinX_Offset), 0, MakeVectorFromPerlinNoise_RangeOutMinX_PropertyAddress.Address, RangeOutMinX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeVectorFromPerlinNoise_RangeOutMaxX_Offset), 0, MakeVectorFromPerlinNoise_RangeOutMaxX_PropertyAddress.Address, RangeOutMaxX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeVectorFromPerlinNoise_RangeOutMinY_Offset), 0, MakeVectorFromPerlinNoise_RangeOutMinY_PropertyAddress.Address, RangeOutMinY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeVectorFromPerlinNoise_RangeOutMaxY_Offset), 0, MakeVectorFromPerlinNoise_RangeOutMaxY_PropertyAddress.Address, RangeOutMaxY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeVectorFromPerlinNoise_RangeOutMinZ_Offset), 0, MakeVectorFromPerlinNoise_RangeOutMinZ_PropertyAddress.Address, RangeOutMinZ);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeVectorFromPerlinNoise_RangeOutMaxZ_Offset), 0, MakeVectorFromPerlinNoise_RangeOutMaxZ_PropertyAddress.Address, RangeOutMaxZ);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeVectorFromPerlinNoise_FunctionAddress, intPtr, MakeVectorFromPerlinNoise_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, MakeVectorFromPerlinNoise_ReturnValue_Offset), 0, MakeVectorFromPerlinNoise_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u, OriginalName = "K2_MakePerlinNoiseAndRemap")]
	[UMetaPath("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_MakePerlinNoiseAndRemap")]
	public unsafe static float MakeFloatFromPerlinNoise(float Value, float RangeOutMin, float RangeOutMax)
	{
		if (!MakeFloatFromPerlinNoise_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_MakePerlinNoiseAndRemap");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeFloatFromPerlinNoise_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeFloatFromPerlinNoise_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeFloatFromPerlinNoise_Value_Offset), 0, MakeFloatFromPerlinNoise_Value_PropertyAddress.Address, Value);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeFloatFromPerlinNoise_RangeOutMin_Offset), 0, MakeFloatFromPerlinNoise_RangeOutMin_PropertyAddress.Address, RangeOutMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeFloatFromPerlinNoise_RangeOutMax_Offset), 0, MakeFloatFromPerlinNoise_RangeOutMax_PropertyAddress.Address, RangeOutMax);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeFloatFromPerlinNoise_FunctionAddress, intPtr, MakeFloatFromPerlinNoise_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, MakeFloatFromPerlinNoise_ReturnValue_Offset), 0, MakeFloatFromPerlinNoise_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u, OriginalName = "K2_LookAt")]
	[UMetaPath("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_LookAt")]
	public unsafe static FTransform LookAt(FTransform CurrentTransform, FVector TargetPosition, FVector LookAtVector, bool bUseUpVector, FVector UpVector, float ClampConeInDegree)
	{
		if (!LookAt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_LookAt");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(LookAt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LookAt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(LookAt_CurrentTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, LookAt_CurrentTransform_Offset), 0, LookAt_CurrentTransform_PropertyAddress.Address, CurrentTransform);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LookAt_TargetPosition_Offset), 0, LookAt_TargetPosition_PropertyAddress.Address, TargetPosition);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LookAt_LookAtVector_Offset), 0, LookAt_LookAtVector_PropertyAddress.Address, LookAtVector);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LookAt_bUseUpVector_Offset), 0, LookAt_bUseUpVector_PropertyAddress.Address, bUseUpVector);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LookAt_UpVector_Offset), 0, LookAt_UpVector_PropertyAddress.Address, UpVector);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, LookAt_ClampConeInDegree_Offset), 0, LookAt_ClampConeInDegree_PropertyAddress.Address, ClampConeInDegree);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LookAt_FunctionAddress, intPtr, LookAt_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, LookAt_ReturnValue_Offset), 0, LookAt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u, OriginalName = "K2_EndProfilingTimer")]
	[UMetaPath("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_EndProfilingTimer")]
	public unsafe static float EndProfilingTimer(bool bLog = true, string LogPrefix = null)
	{
		if (!EndProfilingTimer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_EndProfilingTimer");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndProfilingTimer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndProfilingTimer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EndProfilingTimer_bLog_Offset), 0, EndProfilingTimer_bLog_PropertyAddress.Address, bLog);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EndProfilingTimer_LogPrefix_Offset), 0, EndProfilingTimer_LogPrefix_PropertyAddress.Address, LogPrefix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EndProfilingTimer_FunctionAddress, intPtr, EndProfilingTimer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EndProfilingTimer_LogPrefix_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, EndProfilingTimer_ReturnValue_Offset), 0, EndProfilingTimer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u, OriginalName = "K2_DistanceBetweenTwoSocketsAndMapRange")]
	[UMetaPath("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_DistanceBetweenTwoSocketsAndMapRange")]
	public unsafe static float DistanceBetweenSockets(USkeletalMeshComponent Component, FName SocketOrBoneNameA, ERelativeTransformSpace SocketSpaceA, FName SocketOrBoneNameB, ERelativeTransformSpace SocketSpaceB, bool bRemapRange, float InRangeMin, float InRangeMax, float OutRangeMin, float OutRangeMax)
	{
		if (!DistanceBetweenSockets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_DistanceBetweenTwoSocketsAndMapRange");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DistanceBetweenSockets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DistanceBetweenSockets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, DistanceBetweenSockets_Component_Offset), 0, DistanceBetweenSockets_Component_PropertyAddress.Address, Component);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DistanceBetweenSockets_SocketOrBoneNameA_Offset), 0, DistanceBetweenSockets_SocketOrBoneNameA_PropertyAddress.Address, SocketOrBoneNameA);
		EnumMarshaler<ERelativeTransformSpace>.ToNative(IntPtr.Add(intPtr, DistanceBetweenSockets_SocketSpaceA_Offset), 0, DistanceBetweenSockets_SocketSpaceA_PropertyAddress.Address, SocketSpaceA);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DistanceBetweenSockets_SocketOrBoneNameB_Offset), 0, DistanceBetweenSockets_SocketOrBoneNameB_PropertyAddress.Address, SocketOrBoneNameB);
		EnumMarshaler<ERelativeTransformSpace>.ToNative(IntPtr.Add(intPtr, DistanceBetweenSockets_SocketSpaceB_Offset), 0, DistanceBetweenSockets_SocketSpaceB_PropertyAddress.Address, SocketSpaceB);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DistanceBetweenSockets_bRemapRange_Offset), 0, DistanceBetweenSockets_bRemapRange_PropertyAddress.Address, bRemapRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DistanceBetweenSockets_InRangeMin_Offset), 0, DistanceBetweenSockets_InRangeMin_PropertyAddress.Address, InRangeMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DistanceBetweenSockets_InRangeMax_Offset), 0, DistanceBetweenSockets_InRangeMax_PropertyAddress.Address, InRangeMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DistanceBetweenSockets_OutRangeMin_Offset), 0, DistanceBetweenSockets_OutRangeMin_PropertyAddress.Address, OutRangeMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DistanceBetweenSockets_OutRangeMax_Offset), 0, DistanceBetweenSockets_OutRangeMax_PropertyAddress.Address, OutRangeMax);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DistanceBetweenSockets_FunctionAddress, intPtr, DistanceBetweenSockets_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, DistanceBetweenSockets_ReturnValue_Offset), 0, DistanceBetweenSockets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u, OriginalName = "K2_DirectionBetweenSockets")]
	[UMetaPath("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_DirectionBetweenSockets")]
	public unsafe static FVector DirectionBetweenSockets(USkeletalMeshComponent Component, FName SocketOrBoneNameFrom, FName SocketOrBoneNameTo)
	{
		if (!DirectionBetweenSockets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_DirectionBetweenSockets");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(DirectionBetweenSockets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DirectionBetweenSockets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, DirectionBetweenSockets_Component_Offset), 0, DirectionBetweenSockets_Component_PropertyAddress.Address, Component);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DirectionBetweenSockets_SocketOrBoneNameFrom_Offset), 0, DirectionBetweenSockets_SocketOrBoneNameFrom_PropertyAddress.Address, SocketOrBoneNameFrom);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DirectionBetweenSockets_SocketOrBoneNameTo_Offset), 0, DirectionBetweenSockets_SocketOrBoneNameTo_PropertyAddress.Address, SocketOrBoneNameTo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DirectionBetweenSockets_FunctionAddress, intPtr, DirectionBetweenSockets_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, DirectionBetweenSockets_ReturnValue_Offset), 0, DirectionBetweenSockets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u, OriginalName = "K2_CalculateVelocityFromSockets")]
	[UMetaPath("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_CalculateVelocityFromSockets")]
	public unsafe static float CalculateVelocityFromSockets(float DeltaSeconds, USkeletalMeshComponent Component, FName SocketOrBoneName, FName ReferenceSocketOrBone, ERelativeTransformSpace SocketSpace, FVector OffsetInBoneSpace, ref FPositionHistory History, int NumberOfSamples, float VelocityMin, float VelocityMax, EEasingFuncType EasingType, FRuntimeFloatCurve CustomCurve)
	{
		if (!CalculateVelocityFromSockets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_CalculateVelocityFromSockets");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalculateVelocityFromSockets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalculateVelocityFromSockets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromSockets_DeltaSeconds_Offset), 0, CalculateVelocityFromSockets_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromSockets_Component_Offset), 0, CalculateVelocityFromSockets_Component_PropertyAddress.Address, Component);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromSockets_SocketOrBoneName_Offset), 0, CalculateVelocityFromSockets_SocketOrBoneName_PropertyAddress.Address, SocketOrBoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromSockets_ReferenceSocketOrBone_Offset), 0, CalculateVelocityFromSockets_ReferenceSocketOrBone_PropertyAddress.Address, ReferenceSocketOrBone);
		EnumMarshaler<ERelativeTransformSpace>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromSockets_SocketSpace_Offset), 0, CalculateVelocityFromSockets_SocketSpace_PropertyAddress.Address, SocketSpace);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromSockets_OffsetInBoneSpace_Offset), 0, CalculateVelocityFromSockets_OffsetInBoneSpace_PropertyAddress.Address, OffsetInBoneSpace);
		NativeReflection.InitializeValue_InContainer(CalculateVelocityFromSockets_History_PropertyAddress.Address, intPtr);
		FPositionHistory.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromSockets_History_Offset), 0, CalculateVelocityFromSockets_History_PropertyAddress.Address, History);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromSockets_NumberOfSamples_Offset), 0, CalculateVelocityFromSockets_NumberOfSamples_PropertyAddress.Address, NumberOfSamples);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromSockets_VelocityMin_Offset), 0, CalculateVelocityFromSockets_VelocityMin_PropertyAddress.Address, VelocityMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromSockets_VelocityMax_Offset), 0, CalculateVelocityFromSockets_VelocityMax_PropertyAddress.Address, VelocityMax);
		EnumMarshaler<EEasingFuncType>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromSockets_EasingType_Offset), 0, CalculateVelocityFromSockets_EasingType_PropertyAddress.Address, EasingType);
		NativeReflection.InitializeValue_InContainer(CalculateVelocityFromSockets_CustomCurve_PropertyAddress.Address, intPtr);
		FRuntimeFloatCurve.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromSockets_CustomCurve_Offset), 0, CalculateVelocityFromSockets_CustomCurve_PropertyAddress.Address, CustomCurve);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalculateVelocityFromSockets_FunctionAddress, intPtr, CalculateVelocityFromSockets_ParamsSize);
		History = FPositionHistory.FromNative(IntPtr.Add(intPtr, CalculateVelocityFromSockets_History_Offset), 0, CalculateVelocityFromSockets_History_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CalculateVelocityFromSockets_History_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CalculateVelocityFromSockets_CustomCurve_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalculateVelocityFromSockets_ReturnValue_Offset), 0, CalculateVelocityFromSockets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u, OriginalName = "K2_CalculateVelocityFromPositionHistory")]
	[UMetaPath("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_CalculateVelocityFromPositionHistory")]
	public unsafe static float CalculateVelocityFromPositionHistory(float DeltaSeconds, FVector Position, ref FPositionHistory History, int NumberOfSamples, float VelocityMin, float VelocityMax)
	{
		if (!CalculateVelocityFromPositionHistory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_CalculateVelocityFromPositionHistory");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalculateVelocityFromPositionHistory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalculateVelocityFromPositionHistory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromPositionHistory_DeltaSeconds_Offset), 0, CalculateVelocityFromPositionHistory_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromPositionHistory_Position_Offset), 0, CalculateVelocityFromPositionHistory_Position_PropertyAddress.Address, Position);
		NativeReflection.InitializeValue_InContainer(CalculateVelocityFromPositionHistory_History_PropertyAddress.Address, intPtr);
		FPositionHistory.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromPositionHistory_History_Offset), 0, CalculateVelocityFromPositionHistory_History_PropertyAddress.Address, History);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromPositionHistory_NumberOfSamples_Offset), 0, CalculateVelocityFromPositionHistory_NumberOfSamples_PropertyAddress.Address, NumberOfSamples);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromPositionHistory_VelocityMin_Offset), 0, CalculateVelocityFromPositionHistory_VelocityMin_PropertyAddress.Address, VelocityMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CalculateVelocityFromPositionHistory_VelocityMax_Offset), 0, CalculateVelocityFromPositionHistory_VelocityMax_PropertyAddress.Address, VelocityMax);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalculateVelocityFromPositionHistory_FunctionAddress, intPtr, CalculateVelocityFromPositionHistory_ParamsSize);
		History = FPositionHistory.FromNative(IntPtr.Add(intPtr, CalculateVelocityFromPositionHistory_History_Offset), 0, CalculateVelocityFromPositionHistory_History_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CalculateVelocityFromPositionHistory_History_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalculateVelocityFromPositionHistory_ReturnValue_Offset), 0, CalculateVelocityFromPositionHistory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AnimGraphRuntime.KismetAnimationLibrary:CalculateDirection")]
	public unsafe static float CalculateDirection(FVector Velocity, FRotator BaseRotation)
	{
		if (!CalculateDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.KismetAnimationLibrary:CalculateDirection");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalculateDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalculateDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CalculateDirection_Velocity_Offset), 0, CalculateDirection_Velocity_PropertyAddress.Address, Velocity);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, CalculateDirection_BaseRotation_Offset), 0, CalculateDirection_BaseRotation_PropertyAddress.Address, BaseRotation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalculateDirection_FunctionAddress, intPtr, CalculateDirection_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalculateDirection_ReturnValue_Offset), 0, CalculateDirection_ReturnValue_PropertyAddress.Address);
	}

	static UAnimGraphLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimGraphLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimGraphLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AnimGraphRuntime.KismetAnimationLibrary");
		TwoBoneIK_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_TwoBoneIK");
		TwoBoneIK_ParamsSize = NativeReflection.GetFunctionParamsSize(TwoBoneIK_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TwoBoneIK_RootPos_PropertyAddress, TwoBoneIK_FunctionAddress, "RootPos");
		TwoBoneIK_RootPos_Offset = NativeReflectionCached.GetPropertyOffset(TwoBoneIK_FunctionAddress, "RootPos");
		TwoBoneIK_RootPos_IsValid = NativeReflectionCached.ValidatePropertyClass(TwoBoneIK_FunctionAddress, "RootPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TwoBoneIK_JointPos_PropertyAddress, TwoBoneIK_FunctionAddress, "JointPos");
		TwoBoneIK_JointPos_Offset = NativeReflectionCached.GetPropertyOffset(TwoBoneIK_FunctionAddress, "JointPos");
		TwoBoneIK_JointPos_IsValid = NativeReflectionCached.ValidatePropertyClass(TwoBoneIK_FunctionAddress, "JointPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TwoBoneIK_EndPos_PropertyAddress, TwoBoneIK_FunctionAddress, "EndPos");
		TwoBoneIK_EndPos_Offset = NativeReflectionCached.GetPropertyOffset(TwoBoneIK_FunctionAddress, "EndPos");
		TwoBoneIK_EndPos_IsValid = NativeReflectionCached.ValidatePropertyClass(TwoBoneIK_FunctionAddress, "EndPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TwoBoneIK_JointTarget_PropertyAddress, TwoBoneIK_FunctionAddress, "JointTarget");
		TwoBoneIK_JointTarget_Offset = NativeReflectionCached.GetPropertyOffset(TwoBoneIK_FunctionAddress, "JointTarget");
		TwoBoneIK_JointTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(TwoBoneIK_FunctionAddress, "JointTarget", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TwoBoneIK_Effector_PropertyAddress, TwoBoneIK_FunctionAddress, "Effector");
		TwoBoneIK_Effector_Offset = NativeReflectionCached.GetPropertyOffset(TwoBoneIK_FunctionAddress, "Effector");
		TwoBoneIK_Effector_IsValid = NativeReflectionCached.ValidatePropertyClass(TwoBoneIK_FunctionAddress, "Effector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TwoBoneIK_OutJointPos_PropertyAddress, TwoBoneIK_FunctionAddress, "OutJointPos");
		TwoBoneIK_OutJointPos_Offset = NativeReflectionCached.GetPropertyOffset(TwoBoneIK_FunctionAddress, "OutJointPos");
		TwoBoneIK_OutJointPos_IsValid = NativeReflectionCached.ValidatePropertyClass(TwoBoneIK_FunctionAddress, "OutJointPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TwoBoneIK_OutEndPos_PropertyAddress, TwoBoneIK_FunctionAddress, "OutEndPos");
		TwoBoneIK_OutEndPos_Offset = NativeReflectionCached.GetPropertyOffset(TwoBoneIK_FunctionAddress, "OutEndPos");
		TwoBoneIK_OutEndPos_IsValid = NativeReflectionCached.ValidatePropertyClass(TwoBoneIK_FunctionAddress, "OutEndPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TwoBoneIK_bAllowStretching_PropertyAddress, TwoBoneIK_FunctionAddress, "bAllowStretching");
		TwoBoneIK_bAllowStretching_Offset = NativeReflectionCached.GetPropertyOffset(TwoBoneIK_FunctionAddress, "bAllowStretching");
		TwoBoneIK_bAllowStretching_IsValid = NativeReflectionCached.ValidatePropertyClass(TwoBoneIK_FunctionAddress, "bAllowStretching", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TwoBoneIK_StartStretchRatio_PropertyAddress, TwoBoneIK_FunctionAddress, "StartStretchRatio");
		TwoBoneIK_StartStretchRatio_Offset = NativeReflectionCached.GetPropertyOffset(TwoBoneIK_FunctionAddress, "StartStretchRatio");
		TwoBoneIK_StartStretchRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(TwoBoneIK_FunctionAddress, "StartStretchRatio", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TwoBoneIK_MaxStretchScale_PropertyAddress, TwoBoneIK_FunctionAddress, "MaxStretchScale");
		TwoBoneIK_MaxStretchScale_Offset = NativeReflectionCached.GetPropertyOffset(TwoBoneIK_FunctionAddress, "MaxStretchScale");
		TwoBoneIK_MaxStretchScale_IsValid = NativeReflectionCached.ValidatePropertyClass(TwoBoneIK_FunctionAddress, "MaxStretchScale", Classes.FFloatProperty);
		TwoBoneIK_IsValid = TwoBoneIK_FunctionAddress != IntPtr.Zero && TwoBoneIK_RootPos_IsValid && TwoBoneIK_JointPos_IsValid && TwoBoneIK_EndPos_IsValid && TwoBoneIK_JointTarget_IsValid && TwoBoneIK_Effector_IsValid && TwoBoneIK_OutJointPos_IsValid && TwoBoneIK_OutEndPos_IsValid && TwoBoneIK_bAllowStretching_IsValid && TwoBoneIK_StartStretchRatio_IsValid && TwoBoneIK_MaxStretchScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_TwoBoneIK", TwoBoneIK_IsValid);
		StartProfilingTimer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_StartProfilingTimer");
		StartProfilingTimer_ParamsSize = NativeReflection.GetFunctionParamsSize(StartProfilingTimer_FunctionAddress);
		StartProfilingTimer_IsValid = StartProfilingTimer_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_StartProfilingTimer", StartProfilingTimer_IsValid);
		MakeVectorFromPerlinNoise_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_MakePerlinNoiseVectorAndRemap");
		MakeVectorFromPerlinNoise_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeVectorFromPerlinNoise_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeVectorFromPerlinNoise_X_PropertyAddress, MakeVectorFromPerlinNoise_FunctionAddress, "X");
		MakeVectorFromPerlinNoise_X_Offset = NativeReflectionCached.GetPropertyOffset(MakeVectorFromPerlinNoise_FunctionAddress, "X");
		MakeVectorFromPerlinNoise_X_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVectorFromPerlinNoise_FunctionAddress, "X", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVectorFromPerlinNoise_Y_PropertyAddress, MakeVectorFromPerlinNoise_FunctionAddress, "Y");
		MakeVectorFromPerlinNoise_Y_Offset = NativeReflectionCached.GetPropertyOffset(MakeVectorFromPerlinNoise_FunctionAddress, "Y");
		MakeVectorFromPerlinNoise_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVectorFromPerlinNoise_FunctionAddress, "Y", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVectorFromPerlinNoise_Z_PropertyAddress, MakeVectorFromPerlinNoise_FunctionAddress, "Z");
		MakeVectorFromPerlinNoise_Z_Offset = NativeReflectionCached.GetPropertyOffset(MakeVectorFromPerlinNoise_FunctionAddress, "Z");
		MakeVectorFromPerlinNoise_Z_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVectorFromPerlinNoise_FunctionAddress, "Z", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVectorFromPerlinNoise_RangeOutMinX_PropertyAddress, MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMinX");
		MakeVectorFromPerlinNoise_RangeOutMinX_Offset = NativeReflectionCached.GetPropertyOffset(MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMinX");
		MakeVectorFromPerlinNoise_RangeOutMinX_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMinX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVectorFromPerlinNoise_RangeOutMaxX_PropertyAddress, MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMaxX");
		MakeVectorFromPerlinNoise_RangeOutMaxX_Offset = NativeReflectionCached.GetPropertyOffset(MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMaxX");
		MakeVectorFromPerlinNoise_RangeOutMaxX_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMaxX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVectorFromPerlinNoise_RangeOutMinY_PropertyAddress, MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMinY");
		MakeVectorFromPerlinNoise_RangeOutMinY_Offset = NativeReflectionCached.GetPropertyOffset(MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMinY");
		MakeVectorFromPerlinNoise_RangeOutMinY_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMinY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVectorFromPerlinNoise_RangeOutMaxY_PropertyAddress, MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMaxY");
		MakeVectorFromPerlinNoise_RangeOutMaxY_Offset = NativeReflectionCached.GetPropertyOffset(MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMaxY");
		MakeVectorFromPerlinNoise_RangeOutMaxY_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMaxY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVectorFromPerlinNoise_RangeOutMinZ_PropertyAddress, MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMinZ");
		MakeVectorFromPerlinNoise_RangeOutMinZ_Offset = NativeReflectionCached.GetPropertyOffset(MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMinZ");
		MakeVectorFromPerlinNoise_RangeOutMinZ_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMinZ", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVectorFromPerlinNoise_RangeOutMaxZ_PropertyAddress, MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMaxZ");
		MakeVectorFromPerlinNoise_RangeOutMaxZ_Offset = NativeReflectionCached.GetPropertyOffset(MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMaxZ");
		MakeVectorFromPerlinNoise_RangeOutMaxZ_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVectorFromPerlinNoise_FunctionAddress, "RangeOutMaxZ", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVectorFromPerlinNoise_ReturnValue_PropertyAddress, MakeVectorFromPerlinNoise_FunctionAddress, "ReturnValue");
		MakeVectorFromPerlinNoise_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeVectorFromPerlinNoise_FunctionAddress, "ReturnValue");
		MakeVectorFromPerlinNoise_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVectorFromPerlinNoise_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeVectorFromPerlinNoise_IsValid = MakeVectorFromPerlinNoise_FunctionAddress != IntPtr.Zero && MakeVectorFromPerlinNoise_X_IsValid && MakeVectorFromPerlinNoise_Y_IsValid && MakeVectorFromPerlinNoise_Z_IsValid && MakeVectorFromPerlinNoise_RangeOutMinX_IsValid && MakeVectorFromPerlinNoise_RangeOutMaxX_IsValid && MakeVectorFromPerlinNoise_RangeOutMinY_IsValid && MakeVectorFromPerlinNoise_RangeOutMaxY_IsValid && MakeVectorFromPerlinNoise_RangeOutMinZ_IsValid && MakeVectorFromPerlinNoise_RangeOutMaxZ_IsValid && MakeVectorFromPerlinNoise_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_MakePerlinNoiseVectorAndRemap", MakeVectorFromPerlinNoise_IsValid);
		MakeFloatFromPerlinNoise_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_MakePerlinNoiseAndRemap");
		MakeFloatFromPerlinNoise_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeFloatFromPerlinNoise_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeFloatFromPerlinNoise_Value_PropertyAddress, MakeFloatFromPerlinNoise_FunctionAddress, "Value");
		MakeFloatFromPerlinNoise_Value_Offset = NativeReflectionCached.GetPropertyOffset(MakeFloatFromPerlinNoise_FunctionAddress, "Value");
		MakeFloatFromPerlinNoise_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeFloatFromPerlinNoise_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeFloatFromPerlinNoise_RangeOutMin_PropertyAddress, MakeFloatFromPerlinNoise_FunctionAddress, "RangeOutMin");
		MakeFloatFromPerlinNoise_RangeOutMin_Offset = NativeReflectionCached.GetPropertyOffset(MakeFloatFromPerlinNoise_FunctionAddress, "RangeOutMin");
		MakeFloatFromPerlinNoise_RangeOutMin_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeFloatFromPerlinNoise_FunctionAddress, "RangeOutMin", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeFloatFromPerlinNoise_RangeOutMax_PropertyAddress, MakeFloatFromPerlinNoise_FunctionAddress, "RangeOutMax");
		MakeFloatFromPerlinNoise_RangeOutMax_Offset = NativeReflectionCached.GetPropertyOffset(MakeFloatFromPerlinNoise_FunctionAddress, "RangeOutMax");
		MakeFloatFromPerlinNoise_RangeOutMax_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeFloatFromPerlinNoise_FunctionAddress, "RangeOutMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeFloatFromPerlinNoise_ReturnValue_PropertyAddress, MakeFloatFromPerlinNoise_FunctionAddress, "ReturnValue");
		MakeFloatFromPerlinNoise_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeFloatFromPerlinNoise_FunctionAddress, "ReturnValue");
		MakeFloatFromPerlinNoise_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeFloatFromPerlinNoise_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		MakeFloatFromPerlinNoise_IsValid = MakeFloatFromPerlinNoise_FunctionAddress != IntPtr.Zero && MakeFloatFromPerlinNoise_Value_IsValid && MakeFloatFromPerlinNoise_RangeOutMin_IsValid && MakeFloatFromPerlinNoise_RangeOutMax_IsValid && MakeFloatFromPerlinNoise_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_MakePerlinNoiseAndRemap", MakeFloatFromPerlinNoise_IsValid);
		LookAt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_LookAt");
		LookAt_ParamsSize = NativeReflection.GetFunctionParamsSize(LookAt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LookAt_CurrentTransform_PropertyAddress, LookAt_FunctionAddress, "CurrentTransform");
		LookAt_CurrentTransform_Offset = NativeReflectionCached.GetPropertyOffset(LookAt_FunctionAddress, "CurrentTransform");
		LookAt_CurrentTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(LookAt_FunctionAddress, "CurrentTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LookAt_TargetPosition_PropertyAddress, LookAt_FunctionAddress, "TargetPosition");
		LookAt_TargetPosition_Offset = NativeReflectionCached.GetPropertyOffset(LookAt_FunctionAddress, "TargetPosition");
		LookAt_TargetPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(LookAt_FunctionAddress, "TargetPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LookAt_LookAtVector_PropertyAddress, LookAt_FunctionAddress, "LookAtVector");
		LookAt_LookAtVector_Offset = NativeReflectionCached.GetPropertyOffset(LookAt_FunctionAddress, "LookAtVector");
		LookAt_LookAtVector_IsValid = NativeReflectionCached.ValidatePropertyClass(LookAt_FunctionAddress, "LookAtVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LookAt_bUseUpVector_PropertyAddress, LookAt_FunctionAddress, "bUseUpVector");
		LookAt_bUseUpVector_Offset = NativeReflectionCached.GetPropertyOffset(LookAt_FunctionAddress, "bUseUpVector");
		LookAt_bUseUpVector_IsValid = NativeReflectionCached.ValidatePropertyClass(LookAt_FunctionAddress, "bUseUpVector", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LookAt_UpVector_PropertyAddress, LookAt_FunctionAddress, "UpVector");
		LookAt_UpVector_Offset = NativeReflectionCached.GetPropertyOffset(LookAt_FunctionAddress, "UpVector");
		LookAt_UpVector_IsValid = NativeReflectionCached.ValidatePropertyClass(LookAt_FunctionAddress, "UpVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LookAt_ClampConeInDegree_PropertyAddress, LookAt_FunctionAddress, "ClampConeInDegree");
		LookAt_ClampConeInDegree_Offset = NativeReflectionCached.GetPropertyOffset(LookAt_FunctionAddress, "ClampConeInDegree");
		LookAt_ClampConeInDegree_IsValid = NativeReflectionCached.ValidatePropertyClass(LookAt_FunctionAddress, "ClampConeInDegree", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LookAt_ReturnValue_PropertyAddress, LookAt_FunctionAddress, "ReturnValue");
		LookAt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LookAt_FunctionAddress, "ReturnValue");
		LookAt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LookAt_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		LookAt_IsValid = LookAt_FunctionAddress != IntPtr.Zero && LookAt_CurrentTransform_IsValid && LookAt_TargetPosition_IsValid && LookAt_LookAtVector_IsValid && LookAt_bUseUpVector_IsValid && LookAt_UpVector_IsValid && LookAt_ClampConeInDegree_IsValid && LookAt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_LookAt", LookAt_IsValid);
		EndProfilingTimer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_EndProfilingTimer");
		EndProfilingTimer_ParamsSize = NativeReflection.GetFunctionParamsSize(EndProfilingTimer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EndProfilingTimer_bLog_PropertyAddress, EndProfilingTimer_FunctionAddress, "bLog");
		EndProfilingTimer_bLog_Offset = NativeReflectionCached.GetPropertyOffset(EndProfilingTimer_FunctionAddress, "bLog");
		EndProfilingTimer_bLog_IsValid = NativeReflectionCached.ValidatePropertyClass(EndProfilingTimer_FunctionAddress, "bLog", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EndProfilingTimer_LogPrefix_PropertyAddress, EndProfilingTimer_FunctionAddress, "LogPrefix");
		EndProfilingTimer_LogPrefix_Offset = NativeReflectionCached.GetPropertyOffset(EndProfilingTimer_FunctionAddress, "LogPrefix");
		EndProfilingTimer_LogPrefix_IsValid = NativeReflectionCached.ValidatePropertyClass(EndProfilingTimer_FunctionAddress, "LogPrefix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EndProfilingTimer_ReturnValue_PropertyAddress, EndProfilingTimer_FunctionAddress, "ReturnValue");
		EndProfilingTimer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EndProfilingTimer_FunctionAddress, "ReturnValue");
		EndProfilingTimer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EndProfilingTimer_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		EndProfilingTimer_IsValid = EndProfilingTimer_FunctionAddress != IntPtr.Zero && EndProfilingTimer_bLog_IsValid && EndProfilingTimer_LogPrefix_IsValid && EndProfilingTimer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_EndProfilingTimer", EndProfilingTimer_IsValid);
		DistanceBetweenSockets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_DistanceBetweenTwoSocketsAndMapRange");
		DistanceBetweenSockets_ParamsSize = NativeReflection.GetFunctionParamsSize(DistanceBetweenSockets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DistanceBetweenSockets_Component_PropertyAddress, DistanceBetweenSockets_FunctionAddress, "Component");
		DistanceBetweenSockets_Component_Offset = NativeReflectionCached.GetPropertyOffset(DistanceBetweenSockets_FunctionAddress, "Component");
		DistanceBetweenSockets_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceBetweenSockets_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DistanceBetweenSockets_SocketOrBoneNameA_PropertyAddress, DistanceBetweenSockets_FunctionAddress, "SocketOrBoneNameA");
		DistanceBetweenSockets_SocketOrBoneNameA_Offset = NativeReflectionCached.GetPropertyOffset(DistanceBetweenSockets_FunctionAddress, "SocketOrBoneNameA");
		DistanceBetweenSockets_SocketOrBoneNameA_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceBetweenSockets_FunctionAddress, "SocketOrBoneNameA", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DistanceBetweenSockets_SocketSpaceA_PropertyAddress, DistanceBetweenSockets_FunctionAddress, "SocketSpaceA");
		DistanceBetweenSockets_SocketSpaceA_Offset = NativeReflectionCached.GetPropertyOffset(DistanceBetweenSockets_FunctionAddress, "SocketSpaceA");
		DistanceBetweenSockets_SocketSpaceA_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceBetweenSockets_FunctionAddress, "SocketSpaceA", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DistanceBetweenSockets_SocketOrBoneNameB_PropertyAddress, DistanceBetweenSockets_FunctionAddress, "SocketOrBoneNameB");
		DistanceBetweenSockets_SocketOrBoneNameB_Offset = NativeReflectionCached.GetPropertyOffset(DistanceBetweenSockets_FunctionAddress, "SocketOrBoneNameB");
		DistanceBetweenSockets_SocketOrBoneNameB_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceBetweenSockets_FunctionAddress, "SocketOrBoneNameB", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DistanceBetweenSockets_SocketSpaceB_PropertyAddress, DistanceBetweenSockets_FunctionAddress, "SocketSpaceB");
		DistanceBetweenSockets_SocketSpaceB_Offset = NativeReflectionCached.GetPropertyOffset(DistanceBetweenSockets_FunctionAddress, "SocketSpaceB");
		DistanceBetweenSockets_SocketSpaceB_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceBetweenSockets_FunctionAddress, "SocketSpaceB", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DistanceBetweenSockets_bRemapRange_PropertyAddress, DistanceBetweenSockets_FunctionAddress, "bRemapRange");
		DistanceBetweenSockets_bRemapRange_Offset = NativeReflectionCached.GetPropertyOffset(DistanceBetweenSockets_FunctionAddress, "bRemapRange");
		DistanceBetweenSockets_bRemapRange_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceBetweenSockets_FunctionAddress, "bRemapRange", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DistanceBetweenSockets_InRangeMin_PropertyAddress, DistanceBetweenSockets_FunctionAddress, "InRangeMin");
		DistanceBetweenSockets_InRangeMin_Offset = NativeReflectionCached.GetPropertyOffset(DistanceBetweenSockets_FunctionAddress, "InRangeMin");
		DistanceBetweenSockets_InRangeMin_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceBetweenSockets_FunctionAddress, "InRangeMin", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DistanceBetweenSockets_InRangeMax_PropertyAddress, DistanceBetweenSockets_FunctionAddress, "InRangeMax");
		DistanceBetweenSockets_InRangeMax_Offset = NativeReflectionCached.GetPropertyOffset(DistanceBetweenSockets_FunctionAddress, "InRangeMax");
		DistanceBetweenSockets_InRangeMax_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceBetweenSockets_FunctionAddress, "InRangeMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DistanceBetweenSockets_OutRangeMin_PropertyAddress, DistanceBetweenSockets_FunctionAddress, "OutRangeMin");
		DistanceBetweenSockets_OutRangeMin_Offset = NativeReflectionCached.GetPropertyOffset(DistanceBetweenSockets_FunctionAddress, "OutRangeMin");
		DistanceBetweenSockets_OutRangeMin_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceBetweenSockets_FunctionAddress, "OutRangeMin", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DistanceBetweenSockets_OutRangeMax_PropertyAddress, DistanceBetweenSockets_FunctionAddress, "OutRangeMax");
		DistanceBetweenSockets_OutRangeMax_Offset = NativeReflectionCached.GetPropertyOffset(DistanceBetweenSockets_FunctionAddress, "OutRangeMax");
		DistanceBetweenSockets_OutRangeMax_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceBetweenSockets_FunctionAddress, "OutRangeMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DistanceBetweenSockets_ReturnValue_PropertyAddress, DistanceBetweenSockets_FunctionAddress, "ReturnValue");
		DistanceBetweenSockets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DistanceBetweenSockets_FunctionAddress, "ReturnValue");
		DistanceBetweenSockets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DistanceBetweenSockets_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		DistanceBetweenSockets_IsValid = DistanceBetweenSockets_FunctionAddress != IntPtr.Zero && DistanceBetweenSockets_Component_IsValid && DistanceBetweenSockets_SocketOrBoneNameA_IsValid && DistanceBetweenSockets_SocketSpaceA_IsValid && DistanceBetweenSockets_SocketOrBoneNameB_IsValid && DistanceBetweenSockets_SocketSpaceB_IsValid && DistanceBetweenSockets_bRemapRange_IsValid && DistanceBetweenSockets_InRangeMin_IsValid && DistanceBetweenSockets_InRangeMax_IsValid && DistanceBetweenSockets_OutRangeMin_IsValid && DistanceBetweenSockets_OutRangeMax_IsValid && DistanceBetweenSockets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_DistanceBetweenTwoSocketsAndMapRange", DistanceBetweenSockets_IsValid);
		DirectionBetweenSockets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_DirectionBetweenSockets");
		DirectionBetweenSockets_ParamsSize = NativeReflection.GetFunctionParamsSize(DirectionBetweenSockets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DirectionBetweenSockets_Component_PropertyAddress, DirectionBetweenSockets_FunctionAddress, "Component");
		DirectionBetweenSockets_Component_Offset = NativeReflectionCached.GetPropertyOffset(DirectionBetweenSockets_FunctionAddress, "Component");
		DirectionBetweenSockets_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(DirectionBetweenSockets_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DirectionBetweenSockets_SocketOrBoneNameFrom_PropertyAddress, DirectionBetweenSockets_FunctionAddress, "SocketOrBoneNameFrom");
		DirectionBetweenSockets_SocketOrBoneNameFrom_Offset = NativeReflectionCached.GetPropertyOffset(DirectionBetweenSockets_FunctionAddress, "SocketOrBoneNameFrom");
		DirectionBetweenSockets_SocketOrBoneNameFrom_IsValid = NativeReflectionCached.ValidatePropertyClass(DirectionBetweenSockets_FunctionAddress, "SocketOrBoneNameFrom", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DirectionBetweenSockets_SocketOrBoneNameTo_PropertyAddress, DirectionBetweenSockets_FunctionAddress, "SocketOrBoneNameTo");
		DirectionBetweenSockets_SocketOrBoneNameTo_Offset = NativeReflectionCached.GetPropertyOffset(DirectionBetweenSockets_FunctionAddress, "SocketOrBoneNameTo");
		DirectionBetweenSockets_SocketOrBoneNameTo_IsValid = NativeReflectionCached.ValidatePropertyClass(DirectionBetweenSockets_FunctionAddress, "SocketOrBoneNameTo", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DirectionBetweenSockets_ReturnValue_PropertyAddress, DirectionBetweenSockets_FunctionAddress, "ReturnValue");
		DirectionBetweenSockets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DirectionBetweenSockets_FunctionAddress, "ReturnValue");
		DirectionBetweenSockets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DirectionBetweenSockets_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		DirectionBetweenSockets_IsValid = DirectionBetweenSockets_FunctionAddress != IntPtr.Zero && DirectionBetweenSockets_Component_IsValid && DirectionBetweenSockets_SocketOrBoneNameFrom_IsValid && DirectionBetweenSockets_SocketOrBoneNameTo_IsValid && DirectionBetweenSockets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_DirectionBetweenSockets", DirectionBetweenSockets_IsValid);
		CalculateVelocityFromSockets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_CalculateVelocityFromSockets");
		CalculateVelocityFromSockets_ParamsSize = NativeReflection.GetFunctionParamsSize(CalculateVelocityFromSockets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromSockets_DeltaSeconds_PropertyAddress, CalculateVelocityFromSockets_FunctionAddress, "DeltaSeconds");
		CalculateVelocityFromSockets_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromSockets_FunctionAddress, "DeltaSeconds");
		CalculateVelocityFromSockets_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromSockets_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromSockets_Component_PropertyAddress, CalculateVelocityFromSockets_FunctionAddress, "Component");
		CalculateVelocityFromSockets_Component_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromSockets_FunctionAddress, "Component");
		CalculateVelocityFromSockets_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromSockets_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromSockets_SocketOrBoneName_PropertyAddress, CalculateVelocityFromSockets_FunctionAddress, "SocketOrBoneName");
		CalculateVelocityFromSockets_SocketOrBoneName_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromSockets_FunctionAddress, "SocketOrBoneName");
		CalculateVelocityFromSockets_SocketOrBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromSockets_FunctionAddress, "SocketOrBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromSockets_ReferenceSocketOrBone_PropertyAddress, CalculateVelocityFromSockets_FunctionAddress, "ReferenceSocketOrBone");
		CalculateVelocityFromSockets_ReferenceSocketOrBone_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromSockets_FunctionAddress, "ReferenceSocketOrBone");
		CalculateVelocityFromSockets_ReferenceSocketOrBone_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromSockets_FunctionAddress, "ReferenceSocketOrBone", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromSockets_SocketSpace_PropertyAddress, CalculateVelocityFromSockets_FunctionAddress, "SocketSpace");
		CalculateVelocityFromSockets_SocketSpace_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromSockets_FunctionAddress, "SocketSpace");
		CalculateVelocityFromSockets_SocketSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromSockets_FunctionAddress, "SocketSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromSockets_OffsetInBoneSpace_PropertyAddress, CalculateVelocityFromSockets_FunctionAddress, "OffsetInBoneSpace");
		CalculateVelocityFromSockets_OffsetInBoneSpace_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromSockets_FunctionAddress, "OffsetInBoneSpace");
		CalculateVelocityFromSockets_OffsetInBoneSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromSockets_FunctionAddress, "OffsetInBoneSpace", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromSockets_History_PropertyAddress, CalculateVelocityFromSockets_FunctionAddress, "History");
		CalculateVelocityFromSockets_History_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromSockets_FunctionAddress, "History");
		CalculateVelocityFromSockets_History_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromSockets_FunctionAddress, "History", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromSockets_NumberOfSamples_PropertyAddress, CalculateVelocityFromSockets_FunctionAddress, "NumberOfSamples");
		CalculateVelocityFromSockets_NumberOfSamples_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromSockets_FunctionAddress, "NumberOfSamples");
		CalculateVelocityFromSockets_NumberOfSamples_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromSockets_FunctionAddress, "NumberOfSamples", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromSockets_VelocityMin_PropertyAddress, CalculateVelocityFromSockets_FunctionAddress, "VelocityMin");
		CalculateVelocityFromSockets_VelocityMin_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromSockets_FunctionAddress, "VelocityMin");
		CalculateVelocityFromSockets_VelocityMin_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromSockets_FunctionAddress, "VelocityMin", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromSockets_VelocityMax_PropertyAddress, CalculateVelocityFromSockets_FunctionAddress, "VelocityMax");
		CalculateVelocityFromSockets_VelocityMax_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromSockets_FunctionAddress, "VelocityMax");
		CalculateVelocityFromSockets_VelocityMax_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromSockets_FunctionAddress, "VelocityMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromSockets_EasingType_PropertyAddress, CalculateVelocityFromSockets_FunctionAddress, "EasingType");
		CalculateVelocityFromSockets_EasingType_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromSockets_FunctionAddress, "EasingType");
		CalculateVelocityFromSockets_EasingType_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromSockets_FunctionAddress, "EasingType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromSockets_CustomCurve_PropertyAddress, CalculateVelocityFromSockets_FunctionAddress, "CustomCurve");
		CalculateVelocityFromSockets_CustomCurve_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromSockets_FunctionAddress, "CustomCurve");
		CalculateVelocityFromSockets_CustomCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromSockets_FunctionAddress, "CustomCurve", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromSockets_ReturnValue_PropertyAddress, CalculateVelocityFromSockets_FunctionAddress, "ReturnValue");
		CalculateVelocityFromSockets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromSockets_FunctionAddress, "ReturnValue");
		CalculateVelocityFromSockets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromSockets_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CalculateVelocityFromSockets_IsValid = CalculateVelocityFromSockets_FunctionAddress != IntPtr.Zero && CalculateVelocityFromSockets_DeltaSeconds_IsValid && CalculateVelocityFromSockets_Component_IsValid && CalculateVelocityFromSockets_SocketOrBoneName_IsValid && CalculateVelocityFromSockets_ReferenceSocketOrBone_IsValid && CalculateVelocityFromSockets_SocketSpace_IsValid && CalculateVelocityFromSockets_OffsetInBoneSpace_IsValid && CalculateVelocityFromSockets_History_IsValid && CalculateVelocityFromSockets_NumberOfSamples_IsValid && CalculateVelocityFromSockets_VelocityMin_IsValid && CalculateVelocityFromSockets_VelocityMax_IsValid && CalculateVelocityFromSockets_EasingType_IsValid && CalculateVelocityFromSockets_CustomCurve_IsValid && CalculateVelocityFromSockets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_CalculateVelocityFromSockets", CalculateVelocityFromSockets_IsValid);
		CalculateVelocityFromPositionHistory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_CalculateVelocityFromPositionHistory");
		CalculateVelocityFromPositionHistory_ParamsSize = NativeReflection.GetFunctionParamsSize(CalculateVelocityFromPositionHistory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromPositionHistory_DeltaSeconds_PropertyAddress, CalculateVelocityFromPositionHistory_FunctionAddress, "DeltaSeconds");
		CalculateVelocityFromPositionHistory_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromPositionHistory_FunctionAddress, "DeltaSeconds");
		CalculateVelocityFromPositionHistory_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromPositionHistory_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromPositionHistory_Position_PropertyAddress, CalculateVelocityFromPositionHistory_FunctionAddress, "Position");
		CalculateVelocityFromPositionHistory_Position_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromPositionHistory_FunctionAddress, "Position");
		CalculateVelocityFromPositionHistory_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromPositionHistory_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromPositionHistory_History_PropertyAddress, CalculateVelocityFromPositionHistory_FunctionAddress, "History");
		CalculateVelocityFromPositionHistory_History_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromPositionHistory_FunctionAddress, "History");
		CalculateVelocityFromPositionHistory_History_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromPositionHistory_FunctionAddress, "History", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromPositionHistory_NumberOfSamples_PropertyAddress, CalculateVelocityFromPositionHistory_FunctionAddress, "NumberOfSamples");
		CalculateVelocityFromPositionHistory_NumberOfSamples_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromPositionHistory_FunctionAddress, "NumberOfSamples");
		CalculateVelocityFromPositionHistory_NumberOfSamples_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromPositionHistory_FunctionAddress, "NumberOfSamples", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromPositionHistory_VelocityMin_PropertyAddress, CalculateVelocityFromPositionHistory_FunctionAddress, "VelocityMin");
		CalculateVelocityFromPositionHistory_VelocityMin_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromPositionHistory_FunctionAddress, "VelocityMin");
		CalculateVelocityFromPositionHistory_VelocityMin_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromPositionHistory_FunctionAddress, "VelocityMin", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromPositionHistory_VelocityMax_PropertyAddress, CalculateVelocityFromPositionHistory_FunctionAddress, "VelocityMax");
		CalculateVelocityFromPositionHistory_VelocityMax_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromPositionHistory_FunctionAddress, "VelocityMax");
		CalculateVelocityFromPositionHistory_VelocityMax_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromPositionHistory_FunctionAddress, "VelocityMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateVelocityFromPositionHistory_ReturnValue_PropertyAddress, CalculateVelocityFromPositionHistory_FunctionAddress, "ReturnValue");
		CalculateVelocityFromPositionHistory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalculateVelocityFromPositionHistory_FunctionAddress, "ReturnValue");
		CalculateVelocityFromPositionHistory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateVelocityFromPositionHistory_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CalculateVelocityFromPositionHistory_IsValid = CalculateVelocityFromPositionHistory_FunctionAddress != IntPtr.Zero && CalculateVelocityFromPositionHistory_DeltaSeconds_IsValid && CalculateVelocityFromPositionHistory_Position_IsValid && CalculateVelocityFromPositionHistory_History_IsValid && CalculateVelocityFromPositionHistory_NumberOfSamples_IsValid && CalculateVelocityFromPositionHistory_VelocityMin_IsValid && CalculateVelocityFromPositionHistory_VelocityMax_IsValid && CalculateVelocityFromPositionHistory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.KismetAnimationLibrary:K2_CalculateVelocityFromPositionHistory", CalculateVelocityFromPositionHistory_IsValid);
		CalculateDirection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalculateDirection");
		CalculateDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(CalculateDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalculateDirection_Velocity_PropertyAddress, CalculateDirection_FunctionAddress, "Velocity");
		CalculateDirection_Velocity_Offset = NativeReflectionCached.GetPropertyOffset(CalculateDirection_FunctionAddress, "Velocity");
		CalculateDirection_Velocity_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateDirection_FunctionAddress, "Velocity", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateDirection_BaseRotation_PropertyAddress, CalculateDirection_FunctionAddress, "BaseRotation");
		CalculateDirection_BaseRotation_Offset = NativeReflectionCached.GetPropertyOffset(CalculateDirection_FunctionAddress, "BaseRotation");
		CalculateDirection_BaseRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateDirection_FunctionAddress, "BaseRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateDirection_ReturnValue_PropertyAddress, CalculateDirection_FunctionAddress, "ReturnValue");
		CalculateDirection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalculateDirection_FunctionAddress, "ReturnValue");
		CalculateDirection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateDirection_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CalculateDirection_IsValid = CalculateDirection_FunctionAddress != IntPtr.Zero && CalculateDirection_Velocity_IsValid && CalculateDirection_BaseRotation_IsValid && CalculateDirection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.KismetAnimationLibrary:CalculateDirection", CalculateDirection_IsValid);
	}
}
