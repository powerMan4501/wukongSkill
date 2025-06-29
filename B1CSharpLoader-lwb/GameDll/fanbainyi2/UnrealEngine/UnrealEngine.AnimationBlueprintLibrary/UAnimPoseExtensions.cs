using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationBlueprintLibrary;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseExtensions", "AnimationBlueprintLibrary", UnrealModuleType.Engine)]
public class UAnimPoseExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetBonePose_IsValid;

	private static IntPtr SetBonePose_FunctionAddress;

	private static int SetBonePose_ParamsSize;

	private static bool SetBonePose_Pose_IsValid;

	private static FFieldAddress SetBonePose_Pose_PropertyAddress;

	private static int SetBonePose_Pose_Offset;

	private static bool SetBonePose_Transform_IsValid;

	private static FFieldAddress SetBonePose_Transform_PropertyAddress;

	private static int SetBonePose_Transform_Offset;

	private static bool SetBonePose_BoneName_IsValid;

	private static FFieldAddress SetBonePose_BoneName_PropertyAddress;

	private static int SetBonePose_BoneName_Offset;

	private static bool SetBonePose_Space_IsValid;

	private static FFieldAddress SetBonePose_Space_PropertyAddress;

	private static int SetBonePose_Space_Offset;

	private static bool IsValid_IsValid;

	private static IntPtr IsValid_FunctionAddress;

	private static int IsValid_ParamsSize;

	private static bool IsValid_Pose_IsValid;

	private static FFieldAddress IsValid_Pose_PropertyAddress;

	private static int IsValid_Pose_Offset;

	private static bool IsValid_ReturnValue_IsValid;

	private static FFieldAddress IsValid_ReturnValue_PropertyAddress;

	private static int IsValid_ReturnValue_Offset;

	private static bool GetRelativeTransform_IsValid;

	private static IntPtr GetRelativeTransform_FunctionAddress;

	private static int GetRelativeTransform_ParamsSize;

	private static bool GetRelativeTransform_Pose_IsValid;

	private static FFieldAddress GetRelativeTransform_Pose_PropertyAddress;

	private static int GetRelativeTransform_Pose_Offset;

	private static bool GetRelativeTransform_FromBoneName_IsValid;

	private static FFieldAddress GetRelativeTransform_FromBoneName_PropertyAddress;

	private static int GetRelativeTransform_FromBoneName_Offset;

	private static bool GetRelativeTransform_ToBoneName_IsValid;

	private static FFieldAddress GetRelativeTransform_ToBoneName_PropertyAddress;

	private static int GetRelativeTransform_ToBoneName_Offset;

	private static bool GetRelativeTransform_Space_IsValid;

	private static FFieldAddress GetRelativeTransform_Space_PropertyAddress;

	private static int GetRelativeTransform_Space_Offset;

	private static bool GetRelativeTransform_ReturnValue_IsValid;

	private static FFieldAddress GetRelativeTransform_ReturnValue_PropertyAddress;

	private static int GetRelativeTransform_ReturnValue_Offset;

	private static bool GetRelativeToRefPoseTransform_IsValid;

	private static IntPtr GetRelativeToRefPoseTransform_FunctionAddress;

	private static int GetRelativeToRefPoseTransform_ParamsSize;

	private static bool GetRelativeToRefPoseTransform_Pose_IsValid;

	private static FFieldAddress GetRelativeToRefPoseTransform_Pose_PropertyAddress;

	private static int GetRelativeToRefPoseTransform_Pose_Offset;

	private static bool GetRelativeToRefPoseTransform_BoneName_IsValid;

	private static FFieldAddress GetRelativeToRefPoseTransform_BoneName_PropertyAddress;

	private static int GetRelativeToRefPoseTransform_BoneName_Offset;

	private static bool GetRelativeToRefPoseTransform_Space_IsValid;

	private static FFieldAddress GetRelativeToRefPoseTransform_Space_PropertyAddress;

	private static int GetRelativeToRefPoseTransform_Space_Offset;

	private static bool GetRelativeToRefPoseTransform_ReturnValue_IsValid;

	private static FFieldAddress GetRelativeToRefPoseTransform_ReturnValue_PropertyAddress;

	private static int GetRelativeToRefPoseTransform_ReturnValue_Offset;

	private static bool GetRefPoseRelativeTransform_IsValid;

	private static IntPtr GetRefPoseRelativeTransform_FunctionAddress;

	private static int GetRefPoseRelativeTransform_ParamsSize;

	private static bool GetRefPoseRelativeTransform_Pose_IsValid;

	private static FFieldAddress GetRefPoseRelativeTransform_Pose_PropertyAddress;

	private static int GetRefPoseRelativeTransform_Pose_Offset;

	private static bool GetRefPoseRelativeTransform_FromBoneName_IsValid;

	private static FFieldAddress GetRefPoseRelativeTransform_FromBoneName_PropertyAddress;

	private static int GetRefPoseRelativeTransform_FromBoneName_Offset;

	private static bool GetRefPoseRelativeTransform_ToBoneName_IsValid;

	private static FFieldAddress GetRefPoseRelativeTransform_ToBoneName_PropertyAddress;

	private static int GetRefPoseRelativeTransform_ToBoneName_Offset;

	private static bool GetRefPoseRelativeTransform_Space_IsValid;

	private static FFieldAddress GetRefPoseRelativeTransform_Space_PropertyAddress;

	private static int GetRefPoseRelativeTransform_Space_Offset;

	private static bool GetRefPoseRelativeTransform_ReturnValue_IsValid;

	private static FFieldAddress GetRefPoseRelativeTransform_ReturnValue_PropertyAddress;

	private static int GetRefPoseRelativeTransform_ReturnValue_Offset;

	private static bool GetReferencePose_IsValid;

	private static IntPtr GetReferencePose_FunctionAddress;

	private static int GetReferencePose_ParamsSize;

	private static bool GetReferencePose_Skeleton_IsValid;

	private static FFieldAddress GetReferencePose_Skeleton_PropertyAddress;

	private static int GetReferencePose_Skeleton_Offset;

	private static bool GetReferencePose_OutPose_IsValid;

	private static FFieldAddress GetReferencePose_OutPose_PropertyAddress;

	private static int GetReferencePose_OutPose_Offset;

	private static bool GetRefBonePose_IsValid;

	private static IntPtr GetRefBonePose_FunctionAddress;

	private static int GetRefBonePose_ParamsSize;

	private static bool GetRefBonePose_Pose_IsValid;

	private static FFieldAddress GetRefBonePose_Pose_PropertyAddress;

	private static int GetRefBonePose_Pose_Offset;

	private static bool GetRefBonePose_BoneName_IsValid;

	private static FFieldAddress GetRefBonePose_BoneName_PropertyAddress;

	private static int GetRefBonePose_BoneName_Offset;

	private static bool GetRefBonePose_Space_IsValid;

	private static FFieldAddress GetRefBonePose_Space_PropertyAddress;

	private static int GetRefBonePose_Space_Offset;

	private static bool GetRefBonePose_ReturnValue_IsValid;

	private static FFieldAddress GetRefBonePose_ReturnValue_PropertyAddress;

	private static int GetRefBonePose_ReturnValue_Offset;

	private static bool GetBonePose_IsValid;

	private static IntPtr GetBonePose_FunctionAddress;

	private static int GetBonePose_ParamsSize;

	private static bool GetBonePose_Pose_IsValid;

	private static FFieldAddress GetBonePose_Pose_PropertyAddress;

	private static int GetBonePose_Pose_Offset;

	private static bool GetBonePose_BoneName_IsValid;

	private static FFieldAddress GetBonePose_BoneName_PropertyAddress;

	private static int GetBonePose_BoneName_Offset;

	private static bool GetBonePose_Space_IsValid;

	private static FFieldAddress GetBonePose_Space_PropertyAddress;

	private static int GetBonePose_Space_Offset;

	private static bool GetBonePose_ReturnValue_IsValid;

	private static FFieldAddress GetBonePose_ReturnValue_PropertyAddress;

	private static int GetBonePose_ReturnValue_Offset;

	private static bool GetBoneNames_IsValid;

	private static IntPtr GetBoneNames_FunctionAddress;

	private static int GetBoneNames_ParamsSize;

	private static bool GetBoneNames_Pose_IsValid;

	private static FFieldAddress GetBoneNames_Pose_PropertyAddress;

	private static int GetBoneNames_Pose_Offset;

	private static bool GetBoneNames_Bones_IsValid;

	private static FFieldAddress GetBoneNames_Bones_PropertyAddress;

	private static int GetBoneNames_Bones_Offset;

	private static bool GetAnimPoseAtTime_IsValid;

	private static IntPtr GetAnimPoseAtTime_FunctionAddress;

	private static int GetAnimPoseAtTime_ParamsSize;

	private static bool GetAnimPoseAtTime_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetAnimPoseAtTime_AnimationSequenceBase_PropertyAddress;

	private static int GetAnimPoseAtTime_AnimationSequenceBase_Offset;

	private static bool GetAnimPoseAtTime_Time_IsValid;

	private static FFieldAddress GetAnimPoseAtTime_Time_PropertyAddress;

	private static int GetAnimPoseAtTime_Time_Offset;

	private static bool GetAnimPoseAtTime_EvaluationOptions_IsValid;

	private static FFieldAddress GetAnimPoseAtTime_EvaluationOptions_PropertyAddress;

	private static int GetAnimPoseAtTime_EvaluationOptions_Offset;

	private static bool GetAnimPoseAtTime_Pose_IsValid;

	private static FFieldAddress GetAnimPoseAtTime_Pose_PropertyAddress;

	private static int GetAnimPoseAtTime_Pose_Offset;

	private static bool GetAnimPoseAtFrame_IsValid;

	private static IntPtr GetAnimPoseAtFrame_FunctionAddress;

	private static int GetAnimPoseAtFrame_ParamsSize;

	private static bool GetAnimPoseAtFrame_AnimationSequenceBase_IsValid;

	private static FFieldAddress GetAnimPoseAtFrame_AnimationSequenceBase_PropertyAddress;

	private static int GetAnimPoseAtFrame_AnimationSequenceBase_Offset;

	private static bool GetAnimPoseAtFrame_FrameIndex_IsValid;

	private static FFieldAddress GetAnimPoseAtFrame_FrameIndex_PropertyAddress;

	private static int GetAnimPoseAtFrame_FrameIndex_Offset;

	private static bool GetAnimPoseAtFrame_EvaluationOptions_IsValid;

	private static FFieldAddress GetAnimPoseAtFrame_EvaluationOptions_PropertyAddress;

	private static int GetAnimPoseAtFrame_EvaluationOptions_Offset;

	private static bool GetAnimPoseAtFrame_Pose_IsValid;

	private static FFieldAddress GetAnimPoseAtFrame_Pose_PropertyAddress;

	private static int GetAnimPoseAtFrame_Pose_Offset;

	private static bool EvaluateAnimationBlueprintWithInputPose_IsValid;

	private static IntPtr EvaluateAnimationBlueprintWithInputPose_FunctionAddress;

	private static int EvaluateAnimationBlueprintWithInputPose_ParamsSize;

	private static bool EvaluateAnimationBlueprintWithInputPose_InputPose_IsValid;

	private static FFieldAddress EvaluateAnimationBlueprintWithInputPose_InputPose_PropertyAddress;

	private static int EvaluateAnimationBlueprintWithInputPose_InputPose_Offset;

	private static bool EvaluateAnimationBlueprintWithInputPose_TargetSkeletalMesh_IsValid;

	private static FFieldAddress EvaluateAnimationBlueprintWithInputPose_TargetSkeletalMesh_PropertyAddress;

	private static int EvaluateAnimationBlueprintWithInputPose_TargetSkeletalMesh_Offset;

	private static bool EvaluateAnimationBlueprintWithInputPose_AnimationBlueprint_IsValid;

	private static FFieldAddress EvaluateAnimationBlueprintWithInputPose_AnimationBlueprint_PropertyAddress;

	private static int EvaluateAnimationBlueprintWithInputPose_AnimationBlueprint_Offset;

	private static bool EvaluateAnimationBlueprintWithInputPose_OutPose_IsValid;

	private static FFieldAddress EvaluateAnimationBlueprintWithInputPose_OutPose_PropertyAddress;

	private static int EvaluateAnimationBlueprintWithInputPose_OutPose_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:SetBonePose")]
	public unsafe static void SetBonePose(ref FAnimPose Pose, FTransform Transform, FName BoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
	{
		if (!SetBonePose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:SetBonePose");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBonePose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBonePose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetBonePose_Pose_PropertyAddress.Address, intPtr);
		FAnimPose.ToNative(IntPtr.Add(intPtr, SetBonePose_Pose_Offset), 0, SetBonePose_Pose_PropertyAddress.Address, Pose);
		NativeReflection.InitializeValue_InContainer(SetBonePose_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetBonePose_Transform_Offset), 0, SetBonePose_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBonePose_BoneName_Offset), 0, SetBonePose_BoneName_PropertyAddress.Address, BoneName);
		EnumMarshaler<EAnimPoseSpaces>.ToNative(IntPtr.Add(intPtr, SetBonePose_Space_Offset), 0, SetBonePose_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBonePose_FunctionAddress, intPtr, SetBonePose_ParamsSize);
		Pose = FAnimPose.FromNative(IntPtr.Add(intPtr, SetBonePose_Pose_Offset), 0, SetBonePose_Pose_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetBonePose_Pose_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:IsValid")]
	public unsafe static bool IsValid(FAnimPose Pose)
	{
		if (!IsValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:IsValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsValid_Pose_PropertyAddress.Address, intPtr);
		FAnimPose.ToNative(IntPtr.Add(intPtr, IsValid_Pose_Offset), 0, IsValid_Pose_PropertyAddress.Address, Pose);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValid_FunctionAddress, intPtr, IsValid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsValid_Pose_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValid_ReturnValue_Offset), 0, IsValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetRelativeTransform")]
	public unsafe static FTransform GetRelativeTransform(FAnimPose Pose, FName FromBoneName, FName ToBoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
	{
		if (!GetRelativeTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetRelativeTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRelativeTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRelativeTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetRelativeTransform_Pose_PropertyAddress.Address, intPtr);
		FAnimPose.ToNative(IntPtr.Add(intPtr, GetRelativeTransform_Pose_Offset), 0, GetRelativeTransform_Pose_PropertyAddress.Address, Pose);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRelativeTransform_FromBoneName_Offset), 0, GetRelativeTransform_FromBoneName_PropertyAddress.Address, FromBoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRelativeTransform_ToBoneName_Offset), 0, GetRelativeTransform_ToBoneName_PropertyAddress.Address, ToBoneName);
		EnumMarshaler<EAnimPoseSpaces>.ToNative(IntPtr.Add(intPtr, GetRelativeTransform_Space_Offset), 0, GetRelativeTransform_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRelativeTransform_FunctionAddress, intPtr, GetRelativeTransform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetRelativeTransform_Pose_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetRelativeTransform_ReturnValue_Offset), 0, GetRelativeTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetRelativeToRefPoseTransform")]
	public unsafe static FTransform GetRelativeToRefPoseTransform(FAnimPose Pose, FName BoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
	{
		if (!GetRelativeToRefPoseTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetRelativeToRefPoseTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRelativeToRefPoseTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRelativeToRefPoseTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetRelativeToRefPoseTransform_Pose_PropertyAddress.Address, intPtr);
		FAnimPose.ToNative(IntPtr.Add(intPtr, GetRelativeToRefPoseTransform_Pose_Offset), 0, GetRelativeToRefPoseTransform_Pose_PropertyAddress.Address, Pose);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRelativeToRefPoseTransform_BoneName_Offset), 0, GetRelativeToRefPoseTransform_BoneName_PropertyAddress.Address, BoneName);
		EnumMarshaler<EAnimPoseSpaces>.ToNative(IntPtr.Add(intPtr, GetRelativeToRefPoseTransform_Space_Offset), 0, GetRelativeToRefPoseTransform_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRelativeToRefPoseTransform_FunctionAddress, intPtr, GetRelativeToRefPoseTransform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetRelativeToRefPoseTransform_Pose_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetRelativeToRefPoseTransform_ReturnValue_Offset), 0, GetRelativeToRefPoseTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetRefPoseRelativeTransform")]
	public unsafe static FTransform GetRefPoseRelativeTransform(FAnimPose Pose, FName FromBoneName, FName ToBoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
	{
		if (!GetRefPoseRelativeTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetRefPoseRelativeTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRefPoseRelativeTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRefPoseRelativeTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetRefPoseRelativeTransform_Pose_PropertyAddress.Address, intPtr);
		FAnimPose.ToNative(IntPtr.Add(intPtr, GetRefPoseRelativeTransform_Pose_Offset), 0, GetRefPoseRelativeTransform_Pose_PropertyAddress.Address, Pose);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRefPoseRelativeTransform_FromBoneName_Offset), 0, GetRefPoseRelativeTransform_FromBoneName_PropertyAddress.Address, FromBoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRefPoseRelativeTransform_ToBoneName_Offset), 0, GetRefPoseRelativeTransform_ToBoneName_PropertyAddress.Address, ToBoneName);
		EnumMarshaler<EAnimPoseSpaces>.ToNative(IntPtr.Add(intPtr, GetRefPoseRelativeTransform_Space_Offset), 0, GetRefPoseRelativeTransform_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRefPoseRelativeTransform_FunctionAddress, intPtr, GetRefPoseRelativeTransform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetRefPoseRelativeTransform_Pose_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetRefPoseRelativeTransform_ReturnValue_Offset), 0, GetRefPoseRelativeTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetReferencePose")]
	public unsafe static void GetReferencePose(USkeleton Skeleton, out FAnimPose OutPose)
	{
		if (!GetReferencePose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetReferencePose");
			OutPose = default(FAnimPose);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReferencePose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReferencePose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, GetReferencePose_Skeleton_Offset), 0, GetReferencePose_Skeleton_PropertyAddress.Address, Skeleton);
		NativeReflection.InitializeValue_InContainer(GetReferencePose_OutPose_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetReferencePose_FunctionAddress, intPtr, GetReferencePose_ParamsSize);
		OutPose = FAnimPose.FromNative(IntPtr.Add(intPtr, GetReferencePose_OutPose_Offset), 0, GetReferencePose_OutPose_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetReferencePose_OutPose_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetRefBonePose")]
	public unsafe static FTransform GetRefBonePose(FAnimPose Pose, FName BoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
	{
		if (!GetRefBonePose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetRefBonePose");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRefBonePose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRefBonePose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetRefBonePose_Pose_PropertyAddress.Address, intPtr);
		FAnimPose.ToNative(IntPtr.Add(intPtr, GetRefBonePose_Pose_Offset), 0, GetRefBonePose_Pose_PropertyAddress.Address, Pose);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetRefBonePose_BoneName_Offset), 0, GetRefBonePose_BoneName_PropertyAddress.Address, BoneName);
		EnumMarshaler<EAnimPoseSpaces>.ToNative(IntPtr.Add(intPtr, GetRefBonePose_Space_Offset), 0, GetRefBonePose_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRefBonePose_FunctionAddress, intPtr, GetRefBonePose_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetRefBonePose_Pose_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetRefBonePose_ReturnValue_Offset), 0, GetRefBonePose_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetBonePose")]
	public unsafe static FTransform GetBonePose(FAnimPose Pose, FName BoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
	{
		if (!GetBonePose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetBonePose");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBonePose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBonePose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBonePose_Pose_PropertyAddress.Address, intPtr);
		FAnimPose.ToNative(IntPtr.Add(intPtr, GetBonePose_Pose_Offset), 0, GetBonePose_Pose_PropertyAddress.Address, Pose);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBonePose_BoneName_Offset), 0, GetBonePose_BoneName_PropertyAddress.Address, BoneName);
		EnumMarshaler<EAnimPoseSpaces>.ToNative(IntPtr.Add(intPtr, GetBonePose_Space_Offset), 0, GetBonePose_Space_PropertyAddress.Address, Space);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBonePose_FunctionAddress, intPtr, GetBonePose_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBonePose_Pose_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetBonePose_ReturnValue_Offset), 0, GetBonePose_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetBoneNames")]
	public unsafe static void GetBoneNames(FAnimPose Pose, out List<FName> Bones)
	{
		if (!GetBoneNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetBoneNames");
			Bones = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBoneNames_Pose_PropertyAddress.Address, intPtr);
		FAnimPose.ToNative(IntPtr.Add(intPtr, GetBoneNames_Pose_Offset), 0, GetBoneNames_Pose_PropertyAddress.Address, Pose);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoneNames_FunctionAddress, intPtr, GetBoneNames_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBoneNames_Pose_PropertyAddress.Address, intPtr);
		Bones = new TArrayCopyMarshaler<FName>(1, GetBoneNames_Bones_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBoneNames_Bones_Offset));
		NativeReflection.DestroyValue_InContainer(GetBoneNames_Bones_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetAnimPoseAtTime")]
	public unsafe static void GetAnimPoseAtTime(UAnimSequenceBase AnimationSequenceBase, float Time, FAnimPoseEvaluationOptions EvaluationOptions, out FAnimPose Pose)
	{
		if (!GetAnimPoseAtTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetAnimPoseAtTime");
			Pose = default(FAnimPose);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimPoseAtTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimPoseAtTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetAnimPoseAtTime_AnimationSequenceBase_Offset), 0, GetAnimPoseAtTime_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetAnimPoseAtTime_Time_Offset), 0, GetAnimPoseAtTime_Time_PropertyAddress.Address, Time);
		NativeReflection.InitializeValue_InContainer(GetAnimPoseAtTime_EvaluationOptions_PropertyAddress.Address, intPtr);
		FAnimPoseEvaluationOptions.ToNative(IntPtr.Add(intPtr, GetAnimPoseAtTime_EvaluationOptions_Offset), 0, GetAnimPoseAtTime_EvaluationOptions_PropertyAddress.Address, EvaluationOptions);
		NativeReflection.InitializeValue_InContainer(GetAnimPoseAtTime_Pose_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimPoseAtTime_FunctionAddress, intPtr, GetAnimPoseAtTime_ParamsSize);
		Pose = FAnimPose.FromNative(IntPtr.Add(intPtr, GetAnimPoseAtTime_Pose_Offset), 0, GetAnimPoseAtTime_Pose_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAnimPoseAtTime_Pose_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetAnimPoseAtFrame")]
	public unsafe static void GetAnimPoseAtFrame(UAnimSequenceBase AnimationSequenceBase, int FrameIndex, FAnimPoseEvaluationOptions EvaluationOptions, out FAnimPose Pose)
	{
		if (!GetAnimPoseAtFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetAnimPoseAtFrame");
			Pose = default(FAnimPose);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimPoseAtFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimPoseAtFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, GetAnimPoseAtFrame_AnimationSequenceBase_Offset), 0, GetAnimPoseAtFrame_AnimationSequenceBase_PropertyAddress.Address, AnimationSequenceBase);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAnimPoseAtFrame_FrameIndex_Offset), 0, GetAnimPoseAtFrame_FrameIndex_PropertyAddress.Address, FrameIndex);
		NativeReflection.InitializeValue_InContainer(GetAnimPoseAtFrame_EvaluationOptions_PropertyAddress.Address, intPtr);
		FAnimPoseEvaluationOptions.ToNative(IntPtr.Add(intPtr, GetAnimPoseAtFrame_EvaluationOptions_Offset), 0, GetAnimPoseAtFrame_EvaluationOptions_PropertyAddress.Address, EvaluationOptions);
		NativeReflection.InitializeValue_InContainer(GetAnimPoseAtFrame_Pose_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimPoseAtFrame_FunctionAddress, intPtr, GetAnimPoseAtFrame_ParamsSize);
		Pose = FAnimPose.FromNative(IntPtr.Add(intPtr, GetAnimPoseAtFrame_Pose_Offset), 0, GetAnimPoseAtFrame_Pose_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAnimPoseAtFrame_Pose_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:EvaluateAnimationBlueprintWithInputPose")]
	public unsafe static void EvaluateAnimationBlueprintWithInputPose(FAnimPose InputPose, USkeletalMesh TargetSkeletalMesh, UAnimBlueprint AnimationBlueprint, out FAnimPose OutPose)
	{
		if (!EvaluateAnimationBlueprintWithInputPose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:EvaluateAnimationBlueprintWithInputPose");
			OutPose = default(FAnimPose);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EvaluateAnimationBlueprintWithInputPose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EvaluateAnimationBlueprintWithInputPose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(EvaluateAnimationBlueprintWithInputPose_InputPose_PropertyAddress.Address, intPtr);
		FAnimPose.ToNative(IntPtr.Add(intPtr, EvaluateAnimationBlueprintWithInputPose_InputPose_Offset), 0, EvaluateAnimationBlueprintWithInputPose_InputPose_PropertyAddress.Address, InputPose);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, EvaluateAnimationBlueprintWithInputPose_TargetSkeletalMesh_Offset), 0, EvaluateAnimationBlueprintWithInputPose_TargetSkeletalMesh_PropertyAddress.Address, TargetSkeletalMesh);
		UObjectMarshaler<UAnimBlueprint>.ToNative(IntPtr.Add(intPtr, EvaluateAnimationBlueprintWithInputPose_AnimationBlueprint_Offset), 0, EvaluateAnimationBlueprintWithInputPose_AnimationBlueprint_PropertyAddress.Address, AnimationBlueprint);
		NativeReflection.InitializeValue_InContainer(EvaluateAnimationBlueprintWithInputPose_OutPose_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EvaluateAnimationBlueprintWithInputPose_FunctionAddress, intPtr, EvaluateAnimationBlueprintWithInputPose_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EvaluateAnimationBlueprintWithInputPose_InputPose_PropertyAddress.Address, intPtr);
		OutPose = FAnimPose.FromNative(IntPtr.Add(intPtr, EvaluateAnimationBlueprintWithInputPose_OutPose_Offset), 0, EvaluateAnimationBlueprintWithInputPose_OutPose_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EvaluateAnimationBlueprintWithInputPose_OutPose_PropertyAddress.Address, intPtr);
	}

	static UAnimPoseExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimPoseExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimPoseExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AnimationBlueprintLibrary.AnimPoseExtensions");
		SetBonePose_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBonePose");
		SetBonePose_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBonePose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBonePose_Pose_PropertyAddress, SetBonePose_FunctionAddress, "Pose");
		SetBonePose_Pose_Offset = NativeReflectionCached.GetPropertyOffset(SetBonePose_FunctionAddress, "Pose");
		SetBonePose_Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBonePose_FunctionAddress, "Pose", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBonePose_Transform_PropertyAddress, SetBonePose_FunctionAddress, "Transform");
		SetBonePose_Transform_Offset = NativeReflectionCached.GetPropertyOffset(SetBonePose_FunctionAddress, "Transform");
		SetBonePose_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBonePose_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBonePose_BoneName_PropertyAddress, SetBonePose_FunctionAddress, "BoneName");
		SetBonePose_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetBonePose_FunctionAddress, "BoneName");
		SetBonePose_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBonePose_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBonePose_Space_PropertyAddress, SetBonePose_FunctionAddress, "Space");
		SetBonePose_Space_Offset = NativeReflectionCached.GetPropertyOffset(SetBonePose_FunctionAddress, "Space");
		SetBonePose_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBonePose_FunctionAddress, "Space", Classes.FEnumProperty);
		SetBonePose_IsValid = SetBonePose_FunctionAddress != IntPtr.Zero && SetBonePose_Pose_IsValid && SetBonePose_Transform_IsValid && SetBonePose_BoneName_IsValid && SetBonePose_Space_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:SetBonePose", SetBonePose_IsValid);
		IsValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValid");
		IsValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValid_Pose_PropertyAddress, IsValid_FunctionAddress, "Pose");
		IsValid_Pose_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "Pose");
		IsValid_Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "Pose", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_ReturnValue_PropertyAddress, IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValid_IsValid = IsValid_FunctionAddress != IntPtr.Zero && IsValid_Pose_IsValid && IsValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:IsValid", IsValid_IsValid);
		GetRelativeTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRelativeTransform");
		GetRelativeTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRelativeTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRelativeTransform_Pose_PropertyAddress, GetRelativeTransform_FunctionAddress, "Pose");
		GetRelativeTransform_Pose_Offset = NativeReflectionCached.GetPropertyOffset(GetRelativeTransform_FunctionAddress, "Pose");
		GetRelativeTransform_Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRelativeTransform_FunctionAddress, "Pose", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRelativeTransform_FromBoneName_PropertyAddress, GetRelativeTransform_FunctionAddress, "FromBoneName");
		GetRelativeTransform_FromBoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetRelativeTransform_FunctionAddress, "FromBoneName");
		GetRelativeTransform_FromBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRelativeTransform_FunctionAddress, "FromBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRelativeTransform_ToBoneName_PropertyAddress, GetRelativeTransform_FunctionAddress, "ToBoneName");
		GetRelativeTransform_ToBoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetRelativeTransform_FunctionAddress, "ToBoneName");
		GetRelativeTransform_ToBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRelativeTransform_FunctionAddress, "ToBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRelativeTransform_Space_PropertyAddress, GetRelativeTransform_FunctionAddress, "Space");
		GetRelativeTransform_Space_Offset = NativeReflectionCached.GetPropertyOffset(GetRelativeTransform_FunctionAddress, "Space");
		GetRelativeTransform_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRelativeTransform_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRelativeTransform_ReturnValue_PropertyAddress, GetRelativeTransform_FunctionAddress, "ReturnValue");
		GetRelativeTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRelativeTransform_FunctionAddress, "ReturnValue");
		GetRelativeTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRelativeTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRelativeTransform_IsValid = GetRelativeTransform_FunctionAddress != IntPtr.Zero && GetRelativeTransform_Pose_IsValid && GetRelativeTransform_FromBoneName_IsValid && GetRelativeTransform_ToBoneName_IsValid && GetRelativeTransform_Space_IsValid && GetRelativeTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetRelativeTransform", GetRelativeTransform_IsValid);
		GetRelativeToRefPoseTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRelativeToRefPoseTransform");
		GetRelativeToRefPoseTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRelativeToRefPoseTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRelativeToRefPoseTransform_Pose_PropertyAddress, GetRelativeToRefPoseTransform_FunctionAddress, "Pose");
		GetRelativeToRefPoseTransform_Pose_Offset = NativeReflectionCached.GetPropertyOffset(GetRelativeToRefPoseTransform_FunctionAddress, "Pose");
		GetRelativeToRefPoseTransform_Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRelativeToRefPoseTransform_FunctionAddress, "Pose", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRelativeToRefPoseTransform_BoneName_PropertyAddress, GetRelativeToRefPoseTransform_FunctionAddress, "BoneName");
		GetRelativeToRefPoseTransform_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetRelativeToRefPoseTransform_FunctionAddress, "BoneName");
		GetRelativeToRefPoseTransform_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRelativeToRefPoseTransform_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRelativeToRefPoseTransform_Space_PropertyAddress, GetRelativeToRefPoseTransform_FunctionAddress, "Space");
		GetRelativeToRefPoseTransform_Space_Offset = NativeReflectionCached.GetPropertyOffset(GetRelativeToRefPoseTransform_FunctionAddress, "Space");
		GetRelativeToRefPoseTransform_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRelativeToRefPoseTransform_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRelativeToRefPoseTransform_ReturnValue_PropertyAddress, GetRelativeToRefPoseTransform_FunctionAddress, "ReturnValue");
		GetRelativeToRefPoseTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRelativeToRefPoseTransform_FunctionAddress, "ReturnValue");
		GetRelativeToRefPoseTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRelativeToRefPoseTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRelativeToRefPoseTransform_IsValid = GetRelativeToRefPoseTransform_FunctionAddress != IntPtr.Zero && GetRelativeToRefPoseTransform_Pose_IsValid && GetRelativeToRefPoseTransform_BoneName_IsValid && GetRelativeToRefPoseTransform_Space_IsValid && GetRelativeToRefPoseTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetRelativeToRefPoseTransform", GetRelativeToRefPoseTransform_IsValid);
		GetRefPoseRelativeTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRefPoseRelativeTransform");
		GetRefPoseRelativeTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRefPoseRelativeTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRefPoseRelativeTransform_Pose_PropertyAddress, GetRefPoseRelativeTransform_FunctionAddress, "Pose");
		GetRefPoseRelativeTransform_Pose_Offset = NativeReflectionCached.GetPropertyOffset(GetRefPoseRelativeTransform_FunctionAddress, "Pose");
		GetRefPoseRelativeTransform_Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefPoseRelativeTransform_FunctionAddress, "Pose", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRefPoseRelativeTransform_FromBoneName_PropertyAddress, GetRefPoseRelativeTransform_FunctionAddress, "FromBoneName");
		GetRefPoseRelativeTransform_FromBoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetRefPoseRelativeTransform_FunctionAddress, "FromBoneName");
		GetRefPoseRelativeTransform_FromBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefPoseRelativeTransform_FunctionAddress, "FromBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRefPoseRelativeTransform_ToBoneName_PropertyAddress, GetRefPoseRelativeTransform_FunctionAddress, "ToBoneName");
		GetRefPoseRelativeTransform_ToBoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetRefPoseRelativeTransform_FunctionAddress, "ToBoneName");
		GetRefPoseRelativeTransform_ToBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefPoseRelativeTransform_FunctionAddress, "ToBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRefPoseRelativeTransform_Space_PropertyAddress, GetRefPoseRelativeTransform_FunctionAddress, "Space");
		GetRefPoseRelativeTransform_Space_Offset = NativeReflectionCached.GetPropertyOffset(GetRefPoseRelativeTransform_FunctionAddress, "Space");
		GetRefPoseRelativeTransform_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefPoseRelativeTransform_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRefPoseRelativeTransform_ReturnValue_PropertyAddress, GetRefPoseRelativeTransform_FunctionAddress, "ReturnValue");
		GetRefPoseRelativeTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRefPoseRelativeTransform_FunctionAddress, "ReturnValue");
		GetRefPoseRelativeTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefPoseRelativeTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRefPoseRelativeTransform_IsValid = GetRefPoseRelativeTransform_FunctionAddress != IntPtr.Zero && GetRefPoseRelativeTransform_Pose_IsValid && GetRefPoseRelativeTransform_FromBoneName_IsValid && GetRefPoseRelativeTransform_ToBoneName_IsValid && GetRefPoseRelativeTransform_Space_IsValid && GetRefPoseRelativeTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetRefPoseRelativeTransform", GetRefPoseRelativeTransform_IsValid);
		GetReferencePose_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetReferencePose");
		GetReferencePose_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReferencePose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReferencePose_Skeleton_PropertyAddress, GetReferencePose_FunctionAddress, "Skeleton");
		GetReferencePose_Skeleton_Offset = NativeReflectionCached.GetPropertyOffset(GetReferencePose_FunctionAddress, "Skeleton");
		GetReferencePose_Skeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferencePose_FunctionAddress, "Skeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReferencePose_OutPose_PropertyAddress, GetReferencePose_FunctionAddress, "OutPose");
		GetReferencePose_OutPose_Offset = NativeReflectionCached.GetPropertyOffset(GetReferencePose_FunctionAddress, "OutPose");
		GetReferencePose_OutPose_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferencePose_FunctionAddress, "OutPose", Classes.FStructProperty);
		GetReferencePose_IsValid = GetReferencePose_FunctionAddress != IntPtr.Zero && GetReferencePose_Skeleton_IsValid && GetReferencePose_OutPose_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetReferencePose", GetReferencePose_IsValid);
		GetRefBonePose_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRefBonePose");
		GetRefBonePose_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRefBonePose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRefBonePose_Pose_PropertyAddress, GetRefBonePose_FunctionAddress, "Pose");
		GetRefBonePose_Pose_Offset = NativeReflectionCached.GetPropertyOffset(GetRefBonePose_FunctionAddress, "Pose");
		GetRefBonePose_Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefBonePose_FunctionAddress, "Pose", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRefBonePose_BoneName_PropertyAddress, GetRefBonePose_FunctionAddress, "BoneName");
		GetRefBonePose_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetRefBonePose_FunctionAddress, "BoneName");
		GetRefBonePose_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefBonePose_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRefBonePose_Space_PropertyAddress, GetRefBonePose_FunctionAddress, "Space");
		GetRefBonePose_Space_Offset = NativeReflectionCached.GetPropertyOffset(GetRefBonePose_FunctionAddress, "Space");
		GetRefBonePose_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefBonePose_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRefBonePose_ReturnValue_PropertyAddress, GetRefBonePose_FunctionAddress, "ReturnValue");
		GetRefBonePose_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRefBonePose_FunctionAddress, "ReturnValue");
		GetRefBonePose_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefBonePose_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRefBonePose_IsValid = GetRefBonePose_FunctionAddress != IntPtr.Zero && GetRefBonePose_Pose_IsValid && GetRefBonePose_BoneName_IsValid && GetRefBonePose_Space_IsValid && GetRefBonePose_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetRefBonePose", GetRefBonePose_IsValid);
		GetBonePose_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBonePose");
		GetBonePose_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBonePose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBonePose_Pose_PropertyAddress, GetBonePose_FunctionAddress, "Pose");
		GetBonePose_Pose_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePose_FunctionAddress, "Pose");
		GetBonePose_Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePose_FunctionAddress, "Pose", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePose_BoneName_PropertyAddress, GetBonePose_FunctionAddress, "BoneName");
		GetBonePose_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePose_FunctionAddress, "BoneName");
		GetBonePose_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePose_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePose_Space_PropertyAddress, GetBonePose_FunctionAddress, "Space");
		GetBonePose_Space_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePose_FunctionAddress, "Space");
		GetBonePose_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePose_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBonePose_ReturnValue_PropertyAddress, GetBonePose_FunctionAddress, "ReturnValue");
		GetBonePose_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBonePose_FunctionAddress, "ReturnValue");
		GetBonePose_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBonePose_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBonePose_IsValid = GetBonePose_FunctionAddress != IntPtr.Zero && GetBonePose_Pose_IsValid && GetBonePose_BoneName_IsValid && GetBonePose_Space_IsValid && GetBonePose_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetBonePose", GetBonePose_IsValid);
		GetBoneNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoneNames");
		GetBoneNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneNames_Pose_PropertyAddress, GetBoneNames_FunctionAddress, "Pose");
		GetBoneNames_Pose_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneNames_FunctionAddress, "Pose");
		GetBoneNames_Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneNames_FunctionAddress, "Pose", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneNames_Bones_PropertyAddress, GetBoneNames_FunctionAddress, "Bones");
		GetBoneNames_Bones_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneNames_FunctionAddress, "Bones");
		GetBoneNames_Bones_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneNames_FunctionAddress, "Bones", Classes.FArrayProperty);
		GetBoneNames_IsValid = GetBoneNames_FunctionAddress != IntPtr.Zero && GetBoneNames_Pose_IsValid && GetBoneNames_Bones_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetBoneNames", GetBoneNames_IsValid);
		GetAnimPoseAtTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimPoseAtTime");
		GetAnimPoseAtTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimPoseAtTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimPoseAtTime_AnimationSequenceBase_PropertyAddress, GetAnimPoseAtTime_FunctionAddress, "AnimationSequenceBase");
		GetAnimPoseAtTime_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimPoseAtTime_FunctionAddress, "AnimationSequenceBase");
		GetAnimPoseAtTime_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimPoseAtTime_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimPoseAtTime_Time_PropertyAddress, GetAnimPoseAtTime_FunctionAddress, "Time");
		GetAnimPoseAtTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimPoseAtTime_FunctionAddress, "Time");
		GetAnimPoseAtTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimPoseAtTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimPoseAtTime_EvaluationOptions_PropertyAddress, GetAnimPoseAtTime_FunctionAddress, "EvaluationOptions");
		GetAnimPoseAtTime_EvaluationOptions_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimPoseAtTime_FunctionAddress, "EvaluationOptions");
		GetAnimPoseAtTime_EvaluationOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimPoseAtTime_FunctionAddress, "EvaluationOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimPoseAtTime_Pose_PropertyAddress, GetAnimPoseAtTime_FunctionAddress, "Pose");
		GetAnimPoseAtTime_Pose_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimPoseAtTime_FunctionAddress, "Pose");
		GetAnimPoseAtTime_Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimPoseAtTime_FunctionAddress, "Pose", Classes.FStructProperty);
		GetAnimPoseAtTime_IsValid = GetAnimPoseAtTime_FunctionAddress != IntPtr.Zero && GetAnimPoseAtTime_AnimationSequenceBase_IsValid && GetAnimPoseAtTime_Time_IsValid && GetAnimPoseAtTime_EvaluationOptions_IsValid && GetAnimPoseAtTime_Pose_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetAnimPoseAtTime", GetAnimPoseAtTime_IsValid);
		GetAnimPoseAtFrame_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimPoseAtFrame");
		GetAnimPoseAtFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimPoseAtFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimPoseAtFrame_AnimationSequenceBase_PropertyAddress, GetAnimPoseAtFrame_FunctionAddress, "AnimationSequenceBase");
		GetAnimPoseAtFrame_AnimationSequenceBase_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimPoseAtFrame_FunctionAddress, "AnimationSequenceBase");
		GetAnimPoseAtFrame_AnimationSequenceBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimPoseAtFrame_FunctionAddress, "AnimationSequenceBase", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimPoseAtFrame_FrameIndex_PropertyAddress, GetAnimPoseAtFrame_FunctionAddress, "FrameIndex");
		GetAnimPoseAtFrame_FrameIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimPoseAtFrame_FunctionAddress, "FrameIndex");
		GetAnimPoseAtFrame_FrameIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimPoseAtFrame_FunctionAddress, "FrameIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimPoseAtFrame_EvaluationOptions_PropertyAddress, GetAnimPoseAtFrame_FunctionAddress, "EvaluationOptions");
		GetAnimPoseAtFrame_EvaluationOptions_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimPoseAtFrame_FunctionAddress, "EvaluationOptions");
		GetAnimPoseAtFrame_EvaluationOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimPoseAtFrame_FunctionAddress, "EvaluationOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimPoseAtFrame_Pose_PropertyAddress, GetAnimPoseAtFrame_FunctionAddress, "Pose");
		GetAnimPoseAtFrame_Pose_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimPoseAtFrame_FunctionAddress, "Pose");
		GetAnimPoseAtFrame_Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimPoseAtFrame_FunctionAddress, "Pose", Classes.FStructProperty);
		GetAnimPoseAtFrame_IsValid = GetAnimPoseAtFrame_FunctionAddress != IntPtr.Zero && GetAnimPoseAtFrame_AnimationSequenceBase_IsValid && GetAnimPoseAtFrame_FrameIndex_IsValid && GetAnimPoseAtFrame_EvaluationOptions_IsValid && GetAnimPoseAtFrame_Pose_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:GetAnimPoseAtFrame", GetAnimPoseAtFrame_IsValid);
		EvaluateAnimationBlueprintWithInputPose_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EvaluateAnimationBlueprintWithInputPose");
		EvaluateAnimationBlueprintWithInputPose_ParamsSize = NativeReflection.GetFunctionParamsSize(EvaluateAnimationBlueprintWithInputPose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EvaluateAnimationBlueprintWithInputPose_InputPose_PropertyAddress, EvaluateAnimationBlueprintWithInputPose_FunctionAddress, "InputPose");
		EvaluateAnimationBlueprintWithInputPose_InputPose_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateAnimationBlueprintWithInputPose_FunctionAddress, "InputPose");
		EvaluateAnimationBlueprintWithInputPose_InputPose_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateAnimationBlueprintWithInputPose_FunctionAddress, "InputPose", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateAnimationBlueprintWithInputPose_TargetSkeletalMesh_PropertyAddress, EvaluateAnimationBlueprintWithInputPose_FunctionAddress, "TargetSkeletalMesh");
		EvaluateAnimationBlueprintWithInputPose_TargetSkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateAnimationBlueprintWithInputPose_FunctionAddress, "TargetSkeletalMesh");
		EvaluateAnimationBlueprintWithInputPose_TargetSkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateAnimationBlueprintWithInputPose_FunctionAddress, "TargetSkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateAnimationBlueprintWithInputPose_AnimationBlueprint_PropertyAddress, EvaluateAnimationBlueprintWithInputPose_FunctionAddress, "AnimationBlueprint");
		EvaluateAnimationBlueprintWithInputPose_AnimationBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateAnimationBlueprintWithInputPose_FunctionAddress, "AnimationBlueprint");
		EvaluateAnimationBlueprintWithInputPose_AnimationBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateAnimationBlueprintWithInputPose_FunctionAddress, "AnimationBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EvaluateAnimationBlueprintWithInputPose_OutPose_PropertyAddress, EvaluateAnimationBlueprintWithInputPose_FunctionAddress, "OutPose");
		EvaluateAnimationBlueprintWithInputPose_OutPose_Offset = NativeReflectionCached.GetPropertyOffset(EvaluateAnimationBlueprintWithInputPose_FunctionAddress, "OutPose");
		EvaluateAnimationBlueprintWithInputPose_OutPose_IsValid = NativeReflectionCached.ValidatePropertyClass(EvaluateAnimationBlueprintWithInputPose_FunctionAddress, "OutPose", Classes.FStructProperty);
		EvaluateAnimationBlueprintWithInputPose_IsValid = EvaluateAnimationBlueprintWithInputPose_FunctionAddress != IntPtr.Zero && EvaluateAnimationBlueprintWithInputPose_InputPose_IsValid && EvaluateAnimationBlueprintWithInputPose_TargetSkeletalMesh_IsValid && EvaluateAnimationBlueprintWithInputPose_AnimationBlueprint_IsValid && EvaluateAnimationBlueprintWithInputPose_OutPose_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationBlueprintLibrary.AnimPoseExtensions:EvaluateAnimationBlueprintWithInputPose", EvaluateAnimationBlueprintWithInputPose_IsValid);
	}
}
