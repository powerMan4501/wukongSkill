using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGUFuncLibSkill", "b1", UnrealModuleType.Game)]
public class UBGUFuncLibSkill : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool MontageInstanceUnBindUFunctionToMontegeEndDel_IsValid;

	private static IntPtr MontageInstanceUnBindUFunctionToMontegeEndDel_FunctionAddress;

	private static int MontageInstanceUnBindUFunctionToMontegeEndDel_ParamsSize;

	private static bool MontageInstanceUnBindUFunctionToMontegeEndDel_AnimInstance_IsValid;

	private static FFieldAddress MontageInstanceUnBindUFunctionToMontegeEndDel_AnimInstance_PropertyAddress;

	private static int MontageInstanceUnBindUFunctionToMontegeEndDel_AnimInstance_Offset;

	private static bool MontageInstanceUnBindUFunctionToMontegeEndDel_Montage_IsValid;

	private static FFieldAddress MontageInstanceUnBindUFunctionToMontegeEndDel_Montage_PropertyAddress;

	private static int MontageInstanceUnBindUFunctionToMontegeEndDel_Montage_Offset;

	private static bool MontageInstanceUnBindUFunctionToMontegeEndDel_ReturnValue_IsValid;

	private static FFieldAddress MontageInstanceUnBindUFunctionToMontegeEndDel_ReturnValue_PropertyAddress;

	private static int MontageInstanceUnBindUFunctionToMontegeEndDel_ReturnValue_Offset;

	private static bool MontageInstanceUnBindUFunctionToMontageBlendOutDel_IsValid;

	private static IntPtr MontageInstanceUnBindUFunctionToMontageBlendOutDel_FunctionAddress;

	private static int MontageInstanceUnBindUFunctionToMontageBlendOutDel_ParamsSize;

	private static bool MontageInstanceUnBindUFunctionToMontageBlendOutDel_AnimInstance_IsValid;

	private static FFieldAddress MontageInstanceUnBindUFunctionToMontageBlendOutDel_AnimInstance_PropertyAddress;

	private static int MontageInstanceUnBindUFunctionToMontageBlendOutDel_AnimInstance_Offset;

	private static bool MontageInstanceUnBindUFunctionToMontageBlendOutDel_Montage_IsValid;

	private static FFieldAddress MontageInstanceUnBindUFunctionToMontageBlendOutDel_Montage_PropertyAddress;

	private static int MontageInstanceUnBindUFunctionToMontageBlendOutDel_Montage_Offset;

	private static bool MontageInstanceUnBindUFunctionToMontageBlendOutDel_ReturnValue_IsValid;

	private static FFieldAddress MontageInstanceUnBindUFunctionToMontageBlendOutDel_ReturnValue_PropertyAddress;

	private static int MontageInstanceUnBindUFunctionToMontageBlendOutDel_ReturnValue_Offset;

	private static bool MontageInstanceBindUFunctionToMontegeEndDel_IsValid;

	private static IntPtr MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress;

	private static int MontageInstanceBindUFunctionToMontegeEndDel_ParamsSize;

	private static bool MontageInstanceBindUFunctionToMontegeEndDel_AnimInstance_IsValid;

	private static FFieldAddress MontageInstanceBindUFunctionToMontegeEndDel_AnimInstance_PropertyAddress;

	private static int MontageInstanceBindUFunctionToMontegeEndDel_AnimInstance_Offset;

	private static bool MontageInstanceBindUFunctionToMontegeEndDel_Montage_IsValid;

	private static FFieldAddress MontageInstanceBindUFunctionToMontegeEndDel_Montage_PropertyAddress;

	private static int MontageInstanceBindUFunctionToMontegeEndDel_Montage_Offset;

	private static bool MontageInstanceBindUFunctionToMontegeEndDel_Object_IsValid;

	private static FFieldAddress MontageInstanceBindUFunctionToMontegeEndDel_Object_PropertyAddress;

	private static int MontageInstanceBindUFunctionToMontegeEndDel_Object_Offset;

	private static bool MontageInstanceBindUFunctionToMontegeEndDel_FunctionName_IsValid;

	private static FFieldAddress MontageInstanceBindUFunctionToMontegeEndDel_FunctionName_PropertyAddress;

	private static int MontageInstanceBindUFunctionToMontegeEndDel_FunctionName_Offset;

	private static bool MontageInstanceBindUFunctionToMontegeEndDel_ReturnValue_IsValid;

	private static FFieldAddress MontageInstanceBindUFunctionToMontegeEndDel_ReturnValue_PropertyAddress;

	private static int MontageInstanceBindUFunctionToMontegeEndDel_ReturnValue_Offset;

	private static bool MontageInstanceBindUFunctionToMontageBlendOutDel_IsValid;

	private static IntPtr MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress;

	private static int MontageInstanceBindUFunctionToMontageBlendOutDel_ParamsSize;

	private static bool MontageInstanceBindUFunctionToMontageBlendOutDel_AnimInstance_IsValid;

	private static FFieldAddress MontageInstanceBindUFunctionToMontageBlendOutDel_AnimInstance_PropertyAddress;

	private static int MontageInstanceBindUFunctionToMontageBlendOutDel_AnimInstance_Offset;

	private static bool MontageInstanceBindUFunctionToMontageBlendOutDel_Montage_IsValid;

	private static FFieldAddress MontageInstanceBindUFunctionToMontageBlendOutDel_Montage_PropertyAddress;

	private static int MontageInstanceBindUFunctionToMontageBlendOutDel_Montage_Offset;

	private static bool MontageInstanceBindUFunctionToMontageBlendOutDel_Object_IsValid;

	private static FFieldAddress MontageInstanceBindUFunctionToMontageBlendOutDel_Object_PropertyAddress;

	private static int MontageInstanceBindUFunctionToMontageBlendOutDel_Object_Offset;

	private static bool MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionName_IsValid;

	private static FFieldAddress MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionName_PropertyAddress;

	private static int MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionName_Offset;

	private static bool MontageInstanceBindUFunctionToMontageBlendOutDel_ReturnValue_IsValid;

	private static FFieldAddress MontageInstanceBindUFunctionToMontageBlendOutDel_ReturnValue_PropertyAddress;

	private static int MontageInstanceBindUFunctionToMontageBlendOutDel_ReturnValue_Offset;

	private static bool BGUGetMotionDirFromSkill_IsValid;

	private static IntPtr BGUGetMotionDirFromSkill_FunctionAddress;

	private static int BGUGetMotionDirFromSkill_ParamsSize;

	private static bool BGUGetMotionDirFromSkill_SkillID_IsValid;

	private static FFieldAddress BGUGetMotionDirFromSkill_SkillID_PropertyAddress;

	private static int BGUGetMotionDirFromSkill_SkillID_Offset;

	private static bool BGUGetMotionDirFromSkill_ReturnValue_IsValid;

	private static FFieldAddress BGUGetMotionDirFromSkill_ReturnValue_PropertyAddress;

	private static int BGUGetMotionDirFromSkill_ReturnValue_Offset;

	private static bool BGUGetMontageNotifies_IsValid;

	private static IntPtr BGUGetMontageNotifies_FunctionAddress;

	private static int BGUGetMontageNotifies_ParamsSize;

	private static bool BGUGetMontageNotifies_Montage_IsValid;

	private static FFieldAddress BGUGetMontageNotifies_Montage_PropertyAddress;

	private static int BGUGetMontageNotifies_Montage_Offset;

	private static bool BGUGetMontageNotifies_OutActiveNotifies_IsValid;

	private static FFieldAddress BGUGetMontageNotifies_OutActiveNotifies_PropertyAddress;

	private static int BGUGetMontageNotifies_OutActiveNotifies_Offset;

	private static bool BGUGetMontageHasRootMotion_IsValid;

	private static IntPtr BGUGetMontageHasRootMotion_FunctionAddress;

	private static int BGUGetMontageHasRootMotion_ParamsSize;

	private static bool BGUGetMontageHasRootMotion_Montage_IsValid;

	private static FFieldAddress BGUGetMontageHasRootMotion_Montage_PropertyAddress;

	private static int BGUGetMontageHasRootMotion_Montage_Offset;

	private static bool BGUGetMontageHasRootMotion_ReturnValue_IsValid;

	private static FFieldAddress BGUGetMontageHasRootMotion_ReturnValue_PropertyAddress;

	private static int BGUGetMontageHasRootMotion_ReturnValue_Offset;

	private static bool BGUGetActiveInstanceIDForMontage_IsValid;

	private static IntPtr BGUGetActiveInstanceIDForMontage_FunctionAddress;

	private static int BGUGetActiveInstanceIDForMontage_ParamsSize;

	private static bool BGUGetActiveInstanceIDForMontage_AnimInstance_IsValid;

	private static FFieldAddress BGUGetActiveInstanceIDForMontage_AnimInstance_PropertyAddress;

	private static int BGUGetActiveInstanceIDForMontage_AnimInstance_Offset;

	private static bool BGUGetActiveInstanceIDForMontage_Montage_IsValid;

	private static FFieldAddress BGUGetActiveInstanceIDForMontage_Montage_PropertyAddress;

	private static int BGUGetActiveInstanceIDForMontage_Montage_Offset;

	private static bool BGUGetActiveInstanceIDForMontage_ReturnValue_IsValid;

	private static FFieldAddress BGUGetActiveInstanceIDForMontage_ReturnValue_PropertyAddress;

	private static int BGUGetActiveInstanceIDForMontage_ReturnValue_Offset;

	private static bool BGUCalcNotifyNeedModifyTotalTime_IsValid;

	private static IntPtr BGUCalcNotifyNeedModifyTotalTime_FunctionAddress;

	private static int BGUCalcNotifyNeedModifyTotalTime_ParamsSize;

	private static bool BGUCalcNotifyNeedModifyTotalTime_Unit_IsValid;

	private static FFieldAddress BGUCalcNotifyNeedModifyTotalTime_Unit_PropertyAddress;

	private static int BGUCalcNotifyNeedModifyTotalTime_Unit_Offset;

	private static bool BGUCalcNotifyNeedModifyTotalTime_NotifyEvent_IsValid;

	private static FFieldAddress BGUCalcNotifyNeedModifyTotalTime_NotifyEvent_PropertyAddress;

	private static int BGUCalcNotifyNeedModifyTotalTime_NotifyEvent_Offset;

	private static bool BGUCalcNotifyNeedModifyTotalTime_FromAMInstanceID_IsValid;

	private static FFieldAddress BGUCalcNotifyNeedModifyTotalTime_FromAMInstanceID_PropertyAddress;

	private static int BGUCalcNotifyNeedModifyTotalTime_FromAMInstanceID_Offset;

	private static bool BGUCalcNotifyNeedModifyTotalTime_CurNSLeftTime_IsValid;

	private static FFieldAddress BGUCalcNotifyNeedModifyTotalTime_CurNSLeftTime_PropertyAddress;

	private static int BGUCalcNotifyNeedModifyTotalTime_CurNSLeftTime_Offset;

	private static bool BGUCalcNotifyNeedModifyTotalTime_CurNSRightTime_IsValid;

	private static FFieldAddress BGUCalcNotifyNeedModifyTotalTime_CurNSRightTime_PropertyAddress;

	private static int BGUCalcNotifyNeedModifyTotalTime_CurNSRightTime_Offset;

	private static bool BGUCalcNotifyNeedModifyTotalTime_ReturnValue_IsValid;

	private static FFieldAddress BGUCalcNotifyNeedModifyTotalTime_ReturnValue_PropertyAddress;

	private static int BGUCalcNotifyNeedModifyTotalTime_ReturnValue_Offset;

	private static bool BGUCalcMontageSpecificRangeTime_IsValid;

	private static IntPtr BGUCalcMontageSpecificRangeTime_FunctionAddress;

	private static int BGUCalcMontageSpecificRangeTime_ParamsSize;

	private static bool BGUCalcMontageSpecificRangeTime_Unit_IsValid;

	private static FFieldAddress BGUCalcMontageSpecificRangeTime_Unit_PropertyAddress;

	private static int BGUCalcMontageSpecificRangeTime_Unit_Offset;

	private static bool BGUCalcMontageSpecificRangeTime_FromAMInstanceID_IsValid;

	private static FFieldAddress BGUCalcMontageSpecificRangeTime_FromAMInstanceID_PropertyAddress;

	private static int BGUCalcMontageSpecificRangeTime_FromAMInstanceID_Offset;

	private static bool BGUCalcMontageSpecificRangeTime_LeftTime_IsValid;

	private static FFieldAddress BGUCalcMontageSpecificRangeTime_LeftTime_PropertyAddress;

	private static int BGUCalcMontageSpecificRangeTime_LeftTime_Offset;

	private static bool BGUCalcMontageSpecificRangeTime_RightTime_IsValid;

	private static FFieldAddress BGUCalcMontageSpecificRangeTime_RightTime_PropertyAddress;

	private static int BGUCalcMontageSpecificRangeTime_RightTime_Offset;

	private static bool BGUCalcMontageSpecificRangeTime_CurMontage_IsValid;

	private static FFieldAddress BGUCalcMontageSpecificRangeTime_CurMontage_PropertyAddress;

	private static int BGUCalcMontageSpecificRangeTime_CurMontage_Offset;

	private static bool BGUCalcMontageSpecificRangeTime_ReturnValue_IsValid;

	private static FFieldAddress BGUCalcMontageSpecificRangeTime_ReturnValue_PropertyAddress;

	private static int BGUCalcMontageSpecificRangeTime_ReturnValue_Offset;

	private static bool BGUCalcMontageNeedModifyTotalTime_IsValid;

	private static IntPtr BGUCalcMontageNeedModifyTotalTime_FunctionAddress;

	private static int BGUCalcMontageNeedModifyTotalTime_ParamsSize;

	private static bool BGUCalcMontageNeedModifyTotalTime_Unit_IsValid;

	private static FFieldAddress BGUCalcMontageNeedModifyTotalTime_Unit_PropertyAddress;

	private static int BGUCalcMontageNeedModifyTotalTime_Unit_Offset;

	private static bool BGUCalcMontageNeedModifyTotalTime_FromAMInstanceID_IsValid;

	private static FFieldAddress BGUCalcMontageNeedModifyTotalTime_FromAMInstanceID_PropertyAddress;

	private static int BGUCalcMontageNeedModifyTotalTime_FromAMInstanceID_Offset;

	private static bool BGUCalcMontageNeedModifyTotalTime_ReturnValue_IsValid;

	private static FFieldAddress BGUCalcMontageNeedModifyTotalTime_ReturnValue_PropertyAddress;

	private static int BGUCalcMontageNeedModifyTotalTime_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFuncLibSkill:MontageInstanceUnBindUFunctionToMontegeEndDel")]
	public unsafe static bool MontageInstanceUnBindUFunctionToMontegeEndDel(UAnimInstance AnimInstance, UAnimMontage Montage)
	{
		if (!MontageInstanceUnBindUFunctionToMontegeEndDel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibSkill:MontageInstanceUnBindUFunctionToMontegeEndDel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MontageInstanceUnBindUFunctionToMontegeEndDel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MontageInstanceUnBindUFunctionToMontegeEndDel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, MontageInstanceUnBindUFunctionToMontegeEndDel_AnimInstance_Offset), 0, MontageInstanceUnBindUFunctionToMontegeEndDel_AnimInstance_PropertyAddress.Address, AnimInstance);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, MontageInstanceUnBindUFunctionToMontegeEndDel_Montage_Offset), 0, MontageInstanceUnBindUFunctionToMontegeEndDel_Montage_PropertyAddress.Address, Montage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MontageInstanceUnBindUFunctionToMontegeEndDel_FunctionAddress, intPtr, MontageInstanceUnBindUFunctionToMontegeEndDel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MontageInstanceUnBindUFunctionToMontegeEndDel_ReturnValue_Offset), 0, MontageInstanceUnBindUFunctionToMontegeEndDel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFuncLibSkill:MontageInstanceUnBindUFunctionToMontageBlendOutDel")]
	public unsafe static bool MontageInstanceUnBindUFunctionToMontageBlendOutDel(UAnimInstance AnimInstance, UAnimMontage Montage)
	{
		if (!MontageInstanceUnBindUFunctionToMontageBlendOutDel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibSkill:MontageInstanceUnBindUFunctionToMontageBlendOutDel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MontageInstanceUnBindUFunctionToMontageBlendOutDel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MontageInstanceUnBindUFunctionToMontageBlendOutDel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, MontageInstanceUnBindUFunctionToMontageBlendOutDel_AnimInstance_Offset), 0, MontageInstanceUnBindUFunctionToMontageBlendOutDel_AnimInstance_PropertyAddress.Address, AnimInstance);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, MontageInstanceUnBindUFunctionToMontageBlendOutDel_Montage_Offset), 0, MontageInstanceUnBindUFunctionToMontageBlendOutDel_Montage_PropertyAddress.Address, Montage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MontageInstanceUnBindUFunctionToMontageBlendOutDel_FunctionAddress, intPtr, MontageInstanceUnBindUFunctionToMontageBlendOutDel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MontageInstanceUnBindUFunctionToMontageBlendOutDel_ReturnValue_Offset), 0, MontageInstanceUnBindUFunctionToMontageBlendOutDel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFuncLibSkill:MontageInstanceBindUFunctionToMontegeEndDel")]
	public unsafe static bool MontageInstanceBindUFunctionToMontegeEndDel(UAnimInstance AnimInstance, UAnimMontage Montage, UObject Object, FName FunctionName)
	{
		if (!MontageInstanceBindUFunctionToMontegeEndDel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibSkill:MontageInstanceBindUFunctionToMontegeEndDel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MontageInstanceBindUFunctionToMontegeEndDel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MontageInstanceBindUFunctionToMontegeEndDel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, MontageInstanceBindUFunctionToMontegeEndDel_AnimInstance_Offset), 0, MontageInstanceBindUFunctionToMontegeEndDel_AnimInstance_PropertyAddress.Address, AnimInstance);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, MontageInstanceBindUFunctionToMontegeEndDel_Montage_Offset), 0, MontageInstanceBindUFunctionToMontegeEndDel_Montage_PropertyAddress.Address, Montage);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, MontageInstanceBindUFunctionToMontegeEndDel_Object_Offset), 0, MontageInstanceBindUFunctionToMontegeEndDel_Object_PropertyAddress.Address, Object);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, MontageInstanceBindUFunctionToMontegeEndDel_FunctionName_Offset), 0, MontageInstanceBindUFunctionToMontegeEndDel_FunctionName_PropertyAddress.Address, FunctionName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, intPtr, MontageInstanceBindUFunctionToMontegeEndDel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MontageInstanceBindUFunctionToMontegeEndDel_ReturnValue_Offset), 0, MontageInstanceBindUFunctionToMontegeEndDel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFuncLibSkill:MontageInstanceBindUFunctionToMontageBlendOutDel")]
	public unsafe static bool MontageInstanceBindUFunctionToMontageBlendOutDel(UAnimInstance AnimInstance, UAnimMontage Montage, UObject Object, FName FunctionName)
	{
		if (!MontageInstanceBindUFunctionToMontageBlendOutDel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibSkill:MontageInstanceBindUFunctionToMontageBlendOutDel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MontageInstanceBindUFunctionToMontageBlendOutDel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MontageInstanceBindUFunctionToMontageBlendOutDel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, MontageInstanceBindUFunctionToMontageBlendOutDel_AnimInstance_Offset), 0, MontageInstanceBindUFunctionToMontageBlendOutDel_AnimInstance_PropertyAddress.Address, AnimInstance);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, MontageInstanceBindUFunctionToMontageBlendOutDel_Montage_Offset), 0, MontageInstanceBindUFunctionToMontageBlendOutDel_Montage_PropertyAddress.Address, Montage);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, MontageInstanceBindUFunctionToMontageBlendOutDel_Object_Offset), 0, MontageInstanceBindUFunctionToMontageBlendOutDel_Object_PropertyAddress.Address, Object);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionName_Offset), 0, MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionName_PropertyAddress.Address, FunctionName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, intPtr, MontageInstanceBindUFunctionToMontageBlendOutDel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MontageInstanceBindUFunctionToMontageBlendOutDel_ReturnValue_Offset), 0, MontageInstanceBindUFunctionToMontageBlendOutDel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BGUFuncLibSkill:BGUGetMotionDirFromSkill")]
	public unsafe static FVector BGUGetMotionDirFromSkill(int SkillID)
	{
		if (!BGUGetMotionDirFromSkill_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibSkill:BGUGetMotionDirFromSkill");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetMotionDirFromSkill_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetMotionDirFromSkill_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUGetMotionDirFromSkill_SkillID_Offset), 0, BGUGetMotionDirFromSkill_SkillID_PropertyAddress.Address, SkillID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetMotionDirFromSkill_FunctionAddress, intPtr, BGUGetMotionDirFromSkill_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGUGetMotionDirFromSkill_ReturnValue_Offset), 0, BGUGetMotionDirFromSkill_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFuncLibSkill:BGUGetMontageNotifies")]
	public unsafe static void BGUGetMontageNotifies(UAnimMontage Montage, out List<FAnimNotifyEvent> OutActiveNotifies)
	{
		if (!BGUGetMontageNotifies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibSkill:BGUGetMontageNotifies");
			OutActiveNotifies = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetMontageNotifies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetMontageNotifies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, BGUGetMontageNotifies_Montage_Offset), 0, BGUGetMontageNotifies_Montage_PropertyAddress.Address, Montage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetMontageNotifies_FunctionAddress, intPtr, BGUGetMontageNotifies_ParamsSize);
		OutActiveNotifies = new TArrayCopyMarshaler<FAnimNotifyEvent>(1, BGUGetMontageNotifies_OutActiveNotifies_PropertyAddress, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.FromNative, CachedMarshalingDelegates<FAnimNotifyEvent, StructAsClassMarshaler<FAnimNotifyEvent>>.ToNative).FromNative(IntPtr.Add(intPtr, BGUGetMontageNotifies_OutActiveNotifies_Offset));
		NativeReflection.DestroyValue_InContainer(BGUGetMontageNotifies_OutActiveNotifies_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFuncLibSkill:BGUGetMontageHasRootMotion")]
	public unsafe static bool BGUGetMontageHasRootMotion(UAnimMontage Montage)
	{
		if (!BGUGetMontageHasRootMotion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibSkill:BGUGetMontageHasRootMotion");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetMontageHasRootMotion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetMontageHasRootMotion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, BGUGetMontageHasRootMotion_Montage_Offset), 0, BGUGetMontageHasRootMotion_Montage_PropertyAddress.Address, Montage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetMontageHasRootMotion_FunctionAddress, intPtr, BGUGetMontageHasRootMotion_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetMontageHasRootMotion_ReturnValue_Offset), 0, BGUGetMontageHasRootMotion_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFuncLibSkill:BGUGetActiveInstanceIDForMontage")]
	public unsafe static int BGUGetActiveInstanceIDForMontage(UAnimInstance AnimInstance, UAnimMontage Montage)
	{
		if (!BGUGetActiveInstanceIDForMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibSkill:BGUGetActiveInstanceIDForMontage");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetActiveInstanceIDForMontage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetActiveInstanceIDForMontage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, BGUGetActiveInstanceIDForMontage_AnimInstance_Offset), 0, BGUGetActiveInstanceIDForMontage_AnimInstance_PropertyAddress.Address, AnimInstance);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, BGUGetActiveInstanceIDForMontage_Montage_Offset), 0, BGUGetActiveInstanceIDForMontage_Montage_PropertyAddress.Address, Montage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetActiveInstanceIDForMontage_FunctionAddress, intPtr, BGUGetActiveInstanceIDForMontage_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BGUGetActiveInstanceIDForMontage_ReturnValue_Offset), 0, BGUGetActiveInstanceIDForMontage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFuncLibSkill:BGUCalcNotifyNeedModifyTotalTime")]
	public unsafe static float BGUCalcNotifyNeedModifyTotalTime(ACharacter Unit, UAnimNotifyState NotifyEvent, int FromAMInstanceID, float CurNSLeftTime, float CurNSRightTime)
	{
		if (!BGUCalcNotifyNeedModifyTotalTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibSkill:BGUCalcNotifyNeedModifyTotalTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUCalcNotifyNeedModifyTotalTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUCalcNotifyNeedModifyTotalTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, BGUCalcNotifyNeedModifyTotalTime_Unit_Offset), 0, BGUCalcNotifyNeedModifyTotalTime_Unit_PropertyAddress.Address, Unit);
		UObjectMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, BGUCalcNotifyNeedModifyTotalTime_NotifyEvent_Offset), 0, BGUCalcNotifyNeedModifyTotalTime_NotifyEvent_PropertyAddress.Address, NotifyEvent);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUCalcNotifyNeedModifyTotalTime_FromAMInstanceID_Offset), 0, BGUCalcNotifyNeedModifyTotalTime_FromAMInstanceID_PropertyAddress.Address, FromAMInstanceID);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUCalcNotifyNeedModifyTotalTime_CurNSLeftTime_Offset), 0, BGUCalcNotifyNeedModifyTotalTime_CurNSLeftTime_PropertyAddress.Address, CurNSLeftTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUCalcNotifyNeedModifyTotalTime_CurNSRightTime_Offset), 0, BGUCalcNotifyNeedModifyTotalTime_CurNSRightTime_PropertyAddress.Address, CurNSRightTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, intPtr, BGUCalcNotifyNeedModifyTotalTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUCalcNotifyNeedModifyTotalTime_ReturnValue_Offset), 0, BGUCalcNotifyNeedModifyTotalTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFuncLibSkill:BGUCalcMontageSpecificRangeTime")]
	public unsafe static float BGUCalcMontageSpecificRangeTime(AActor Unit, int FromAMInstanceID, float LeftTime, float RightTime, UAnimMontage CurMontage)
	{
		if (!BGUCalcMontageSpecificRangeTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibSkill:BGUCalcMontageSpecificRangeTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUCalcMontageSpecificRangeTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUCalcMontageSpecificRangeTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUCalcMontageSpecificRangeTime_Unit_Offset), 0, BGUCalcMontageSpecificRangeTime_Unit_PropertyAddress.Address, Unit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUCalcMontageSpecificRangeTime_FromAMInstanceID_Offset), 0, BGUCalcMontageSpecificRangeTime_FromAMInstanceID_PropertyAddress.Address, FromAMInstanceID);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUCalcMontageSpecificRangeTime_LeftTime_Offset), 0, BGUCalcMontageSpecificRangeTime_LeftTime_PropertyAddress.Address, LeftTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUCalcMontageSpecificRangeTime_RightTime_Offset), 0, BGUCalcMontageSpecificRangeTime_RightTime_PropertyAddress.Address, RightTime);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, BGUCalcMontageSpecificRangeTime_CurMontage_Offset), 0, BGUCalcMontageSpecificRangeTime_CurMontage_PropertyAddress.Address, CurMontage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUCalcMontageSpecificRangeTime_FunctionAddress, intPtr, BGUCalcMontageSpecificRangeTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUCalcMontageSpecificRangeTime_ReturnValue_Offset), 0, BGUCalcMontageSpecificRangeTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFuncLibSkill:BGUCalcMontageNeedModifyTotalTime")]
	public unsafe static float BGUCalcMontageNeedModifyTotalTime(ACharacter Unit, int FromAMInstanceID)
	{
		if (!BGUCalcMontageNeedModifyTotalTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFuncLibSkill:BGUCalcMontageNeedModifyTotalTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUCalcMontageNeedModifyTotalTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUCalcMontageNeedModifyTotalTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, BGUCalcMontageNeedModifyTotalTime_Unit_Offset), 0, BGUCalcMontageNeedModifyTotalTime_Unit_PropertyAddress.Address, Unit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUCalcMontageNeedModifyTotalTime_FromAMInstanceID_Offset), 0, BGUCalcMontageNeedModifyTotalTime_FromAMInstanceID_PropertyAddress.Address, FromAMInstanceID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUCalcMontageNeedModifyTotalTime_FunctionAddress, intPtr, BGUCalcMontageNeedModifyTotalTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUCalcMontageNeedModifyTotalTime_ReturnValue_Offset), 0, BGUCalcMontageNeedModifyTotalTime_ReturnValue_PropertyAddress.Address);
	}

	static UBGUFuncLibSkill()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUFuncLibSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUFuncLibSkill));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGUFuncLibSkill");
		MontageInstanceUnBindUFunctionToMontegeEndDel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MontageInstanceUnBindUFunctionToMontegeEndDel");
		MontageInstanceUnBindUFunctionToMontegeEndDel_ParamsSize = NativeReflection.GetFunctionParamsSize(MontageInstanceUnBindUFunctionToMontegeEndDel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceUnBindUFunctionToMontegeEndDel_AnimInstance_PropertyAddress, MontageInstanceUnBindUFunctionToMontegeEndDel_FunctionAddress, "AnimInstance");
		MontageInstanceUnBindUFunctionToMontegeEndDel_AnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceUnBindUFunctionToMontegeEndDel_FunctionAddress, "AnimInstance");
		MontageInstanceUnBindUFunctionToMontegeEndDel_AnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceUnBindUFunctionToMontegeEndDel_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceUnBindUFunctionToMontegeEndDel_Montage_PropertyAddress, MontageInstanceUnBindUFunctionToMontegeEndDel_FunctionAddress, "Montage");
		MontageInstanceUnBindUFunctionToMontegeEndDel_Montage_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceUnBindUFunctionToMontegeEndDel_FunctionAddress, "Montage");
		MontageInstanceUnBindUFunctionToMontegeEndDel_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceUnBindUFunctionToMontegeEndDel_FunctionAddress, "Montage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceUnBindUFunctionToMontegeEndDel_ReturnValue_PropertyAddress, MontageInstanceUnBindUFunctionToMontegeEndDel_FunctionAddress, "ReturnValue");
		MontageInstanceUnBindUFunctionToMontegeEndDel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceUnBindUFunctionToMontegeEndDel_FunctionAddress, "ReturnValue");
		MontageInstanceUnBindUFunctionToMontegeEndDel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceUnBindUFunctionToMontegeEndDel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MontageInstanceUnBindUFunctionToMontegeEndDel_IsValid = MontageInstanceUnBindUFunctionToMontegeEndDel_FunctionAddress != IntPtr.Zero && MontageInstanceUnBindUFunctionToMontegeEndDel_AnimInstance_IsValid && MontageInstanceUnBindUFunctionToMontegeEndDel_Montage_IsValid && MontageInstanceUnBindUFunctionToMontegeEndDel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibSkill:MontageInstanceUnBindUFunctionToMontegeEndDel", MontageInstanceUnBindUFunctionToMontegeEndDel_IsValid);
		MontageInstanceUnBindUFunctionToMontageBlendOutDel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MontageInstanceUnBindUFunctionToMontageBlendOutDel");
		MontageInstanceUnBindUFunctionToMontageBlendOutDel_ParamsSize = NativeReflection.GetFunctionParamsSize(MontageInstanceUnBindUFunctionToMontageBlendOutDel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceUnBindUFunctionToMontageBlendOutDel_AnimInstance_PropertyAddress, MontageInstanceUnBindUFunctionToMontageBlendOutDel_FunctionAddress, "AnimInstance");
		MontageInstanceUnBindUFunctionToMontageBlendOutDel_AnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceUnBindUFunctionToMontageBlendOutDel_FunctionAddress, "AnimInstance");
		MontageInstanceUnBindUFunctionToMontageBlendOutDel_AnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceUnBindUFunctionToMontageBlendOutDel_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceUnBindUFunctionToMontageBlendOutDel_Montage_PropertyAddress, MontageInstanceUnBindUFunctionToMontageBlendOutDel_FunctionAddress, "Montage");
		MontageInstanceUnBindUFunctionToMontageBlendOutDel_Montage_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceUnBindUFunctionToMontageBlendOutDel_FunctionAddress, "Montage");
		MontageInstanceUnBindUFunctionToMontageBlendOutDel_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceUnBindUFunctionToMontageBlendOutDel_FunctionAddress, "Montage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceUnBindUFunctionToMontageBlendOutDel_ReturnValue_PropertyAddress, MontageInstanceUnBindUFunctionToMontageBlendOutDel_FunctionAddress, "ReturnValue");
		MontageInstanceUnBindUFunctionToMontageBlendOutDel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceUnBindUFunctionToMontageBlendOutDel_FunctionAddress, "ReturnValue");
		MontageInstanceUnBindUFunctionToMontageBlendOutDel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceUnBindUFunctionToMontageBlendOutDel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MontageInstanceUnBindUFunctionToMontageBlendOutDel_IsValid = MontageInstanceUnBindUFunctionToMontageBlendOutDel_FunctionAddress != IntPtr.Zero && MontageInstanceUnBindUFunctionToMontageBlendOutDel_AnimInstance_IsValid && MontageInstanceUnBindUFunctionToMontageBlendOutDel_Montage_IsValid && MontageInstanceUnBindUFunctionToMontageBlendOutDel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibSkill:MontageInstanceUnBindUFunctionToMontageBlendOutDel", MontageInstanceUnBindUFunctionToMontageBlendOutDel_IsValid);
		MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MontageInstanceBindUFunctionToMontegeEndDel");
		MontageInstanceBindUFunctionToMontegeEndDel_ParamsSize = NativeReflection.GetFunctionParamsSize(MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceBindUFunctionToMontegeEndDel_AnimInstance_PropertyAddress, MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "AnimInstance");
		MontageInstanceBindUFunctionToMontegeEndDel_AnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "AnimInstance");
		MontageInstanceBindUFunctionToMontegeEndDel_AnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceBindUFunctionToMontegeEndDel_Montage_PropertyAddress, MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "Montage");
		MontageInstanceBindUFunctionToMontegeEndDel_Montage_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "Montage");
		MontageInstanceBindUFunctionToMontegeEndDel_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "Montage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceBindUFunctionToMontegeEndDel_Object_PropertyAddress, MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "Object");
		MontageInstanceBindUFunctionToMontegeEndDel_Object_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "Object");
		MontageInstanceBindUFunctionToMontegeEndDel_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceBindUFunctionToMontegeEndDel_FunctionName_PropertyAddress, MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "FunctionName");
		MontageInstanceBindUFunctionToMontegeEndDel_FunctionName_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "FunctionName");
		MontageInstanceBindUFunctionToMontegeEndDel_FunctionName_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "FunctionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceBindUFunctionToMontegeEndDel_ReturnValue_PropertyAddress, MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "ReturnValue");
		MontageInstanceBindUFunctionToMontegeEndDel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "ReturnValue");
		MontageInstanceBindUFunctionToMontegeEndDel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MontageInstanceBindUFunctionToMontegeEndDel_IsValid = MontageInstanceBindUFunctionToMontegeEndDel_FunctionAddress != IntPtr.Zero && MontageInstanceBindUFunctionToMontegeEndDel_AnimInstance_IsValid && MontageInstanceBindUFunctionToMontegeEndDel_Montage_IsValid && MontageInstanceBindUFunctionToMontegeEndDel_Object_IsValid && MontageInstanceBindUFunctionToMontegeEndDel_FunctionName_IsValid && MontageInstanceBindUFunctionToMontegeEndDel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibSkill:MontageInstanceBindUFunctionToMontegeEndDel", MontageInstanceBindUFunctionToMontegeEndDel_IsValid);
		MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MontageInstanceBindUFunctionToMontageBlendOutDel");
		MontageInstanceBindUFunctionToMontageBlendOutDel_ParamsSize = NativeReflection.GetFunctionParamsSize(MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceBindUFunctionToMontageBlendOutDel_AnimInstance_PropertyAddress, MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "AnimInstance");
		MontageInstanceBindUFunctionToMontageBlendOutDel_AnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "AnimInstance");
		MontageInstanceBindUFunctionToMontageBlendOutDel_AnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceBindUFunctionToMontageBlendOutDel_Montage_PropertyAddress, MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "Montage");
		MontageInstanceBindUFunctionToMontageBlendOutDel_Montage_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "Montage");
		MontageInstanceBindUFunctionToMontageBlendOutDel_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "Montage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceBindUFunctionToMontageBlendOutDel_Object_PropertyAddress, MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "Object");
		MontageInstanceBindUFunctionToMontageBlendOutDel_Object_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "Object");
		MontageInstanceBindUFunctionToMontageBlendOutDel_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionName_PropertyAddress, MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "FunctionName");
		MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionName_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "FunctionName");
		MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionName_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "FunctionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref MontageInstanceBindUFunctionToMontageBlendOutDel_ReturnValue_PropertyAddress, MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "ReturnValue");
		MontageInstanceBindUFunctionToMontageBlendOutDel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "ReturnValue");
		MontageInstanceBindUFunctionToMontageBlendOutDel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MontageInstanceBindUFunctionToMontageBlendOutDel_IsValid = MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionAddress != IntPtr.Zero && MontageInstanceBindUFunctionToMontageBlendOutDel_AnimInstance_IsValid && MontageInstanceBindUFunctionToMontageBlendOutDel_Montage_IsValid && MontageInstanceBindUFunctionToMontageBlendOutDel_Object_IsValid && MontageInstanceBindUFunctionToMontageBlendOutDel_FunctionName_IsValid && MontageInstanceBindUFunctionToMontageBlendOutDel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibSkill:MontageInstanceBindUFunctionToMontageBlendOutDel", MontageInstanceBindUFunctionToMontageBlendOutDel_IsValid);
		BGUGetMotionDirFromSkill_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetMotionDirFromSkill");
		BGUGetMotionDirFromSkill_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetMotionDirFromSkill_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMotionDirFromSkill_SkillID_PropertyAddress, BGUGetMotionDirFromSkill_FunctionAddress, "SkillID");
		BGUGetMotionDirFromSkill_SkillID_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMotionDirFromSkill_FunctionAddress, "SkillID");
		BGUGetMotionDirFromSkill_SkillID_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMotionDirFromSkill_FunctionAddress, "SkillID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMotionDirFromSkill_ReturnValue_PropertyAddress, BGUGetMotionDirFromSkill_FunctionAddress, "ReturnValue");
		BGUGetMotionDirFromSkill_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMotionDirFromSkill_FunctionAddress, "ReturnValue");
		BGUGetMotionDirFromSkill_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMotionDirFromSkill_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		BGUGetMotionDirFromSkill_IsValid = BGUGetMotionDirFromSkill_FunctionAddress != IntPtr.Zero && BGUGetMotionDirFromSkill_SkillID_IsValid && BGUGetMotionDirFromSkill_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibSkill:BGUGetMotionDirFromSkill", BGUGetMotionDirFromSkill_IsValid);
		BGUGetMontageNotifies_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetMontageNotifies");
		BGUGetMontageNotifies_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetMontageNotifies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageNotifies_Montage_PropertyAddress, BGUGetMontageNotifies_FunctionAddress, "Montage");
		BGUGetMontageNotifies_Montage_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageNotifies_FunctionAddress, "Montage");
		BGUGetMontageNotifies_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageNotifies_FunctionAddress, "Montage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageNotifies_OutActiveNotifies_PropertyAddress, BGUGetMontageNotifies_FunctionAddress, "OutActiveNotifies");
		BGUGetMontageNotifies_OutActiveNotifies_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageNotifies_FunctionAddress, "OutActiveNotifies");
		BGUGetMontageNotifies_OutActiveNotifies_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageNotifies_FunctionAddress, "OutActiveNotifies", Classes.FArrayProperty);
		BGUGetMontageNotifies_IsValid = BGUGetMontageNotifies_FunctionAddress != IntPtr.Zero && BGUGetMontageNotifies_Montage_IsValid && BGUGetMontageNotifies_OutActiveNotifies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibSkill:BGUGetMontageNotifies", BGUGetMontageNotifies_IsValid);
		BGUGetMontageHasRootMotion_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetMontageHasRootMotion");
		BGUGetMontageHasRootMotion_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetMontageHasRootMotion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageHasRootMotion_Montage_PropertyAddress, BGUGetMontageHasRootMotion_FunctionAddress, "Montage");
		BGUGetMontageHasRootMotion_Montage_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageHasRootMotion_FunctionAddress, "Montage");
		BGUGetMontageHasRootMotion_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageHasRootMotion_FunctionAddress, "Montage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageHasRootMotion_ReturnValue_PropertyAddress, BGUGetMontageHasRootMotion_FunctionAddress, "ReturnValue");
		BGUGetMontageHasRootMotion_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageHasRootMotion_FunctionAddress, "ReturnValue");
		BGUGetMontageHasRootMotion_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageHasRootMotion_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUGetMontageHasRootMotion_IsValid = BGUGetMontageHasRootMotion_FunctionAddress != IntPtr.Zero && BGUGetMontageHasRootMotion_Montage_IsValid && BGUGetMontageHasRootMotion_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibSkill:BGUGetMontageHasRootMotion", BGUGetMontageHasRootMotion_IsValid);
		BGUGetActiveInstanceIDForMontage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetActiveInstanceIDForMontage");
		BGUGetActiveInstanceIDForMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetActiveInstanceIDForMontage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetActiveInstanceIDForMontage_AnimInstance_PropertyAddress, BGUGetActiveInstanceIDForMontage_FunctionAddress, "AnimInstance");
		BGUGetActiveInstanceIDForMontage_AnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetActiveInstanceIDForMontage_FunctionAddress, "AnimInstance");
		BGUGetActiveInstanceIDForMontage_AnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetActiveInstanceIDForMontage_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetActiveInstanceIDForMontage_Montage_PropertyAddress, BGUGetActiveInstanceIDForMontage_FunctionAddress, "Montage");
		BGUGetActiveInstanceIDForMontage_Montage_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetActiveInstanceIDForMontage_FunctionAddress, "Montage");
		BGUGetActiveInstanceIDForMontage_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetActiveInstanceIDForMontage_FunctionAddress, "Montage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetActiveInstanceIDForMontage_ReturnValue_PropertyAddress, BGUGetActiveInstanceIDForMontage_FunctionAddress, "ReturnValue");
		BGUGetActiveInstanceIDForMontage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetActiveInstanceIDForMontage_FunctionAddress, "ReturnValue");
		BGUGetActiveInstanceIDForMontage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetActiveInstanceIDForMontage_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUGetActiveInstanceIDForMontage_IsValid = BGUGetActiveInstanceIDForMontage_FunctionAddress != IntPtr.Zero && BGUGetActiveInstanceIDForMontage_AnimInstance_IsValid && BGUGetActiveInstanceIDForMontage_Montage_IsValid && BGUGetActiveInstanceIDForMontage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibSkill:BGUGetActiveInstanceIDForMontage", BGUGetActiveInstanceIDForMontage_IsValid);
		BGUCalcNotifyNeedModifyTotalTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUCalcNotifyNeedModifyTotalTime");
		BGUCalcNotifyNeedModifyTotalTime_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCalcNotifyNeedModifyTotalTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcNotifyNeedModifyTotalTime_Unit_PropertyAddress, BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "Unit");
		BGUCalcNotifyNeedModifyTotalTime_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "Unit");
		BGUCalcNotifyNeedModifyTotalTime_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcNotifyNeedModifyTotalTime_NotifyEvent_PropertyAddress, BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "NotifyEvent");
		BGUCalcNotifyNeedModifyTotalTime_NotifyEvent_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "NotifyEvent");
		BGUCalcNotifyNeedModifyTotalTime_NotifyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "NotifyEvent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcNotifyNeedModifyTotalTime_FromAMInstanceID_PropertyAddress, BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "FromAMInstanceID");
		BGUCalcNotifyNeedModifyTotalTime_FromAMInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "FromAMInstanceID");
		BGUCalcNotifyNeedModifyTotalTime_FromAMInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "FromAMInstanceID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcNotifyNeedModifyTotalTime_CurNSLeftTime_PropertyAddress, BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "CurNSLeftTime");
		BGUCalcNotifyNeedModifyTotalTime_CurNSLeftTime_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "CurNSLeftTime");
		BGUCalcNotifyNeedModifyTotalTime_CurNSLeftTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "CurNSLeftTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcNotifyNeedModifyTotalTime_CurNSRightTime_PropertyAddress, BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "CurNSRightTime");
		BGUCalcNotifyNeedModifyTotalTime_CurNSRightTime_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "CurNSRightTime");
		BGUCalcNotifyNeedModifyTotalTime_CurNSRightTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "CurNSRightTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcNotifyNeedModifyTotalTime_ReturnValue_PropertyAddress, BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "ReturnValue");
		BGUCalcNotifyNeedModifyTotalTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "ReturnValue");
		BGUCalcNotifyNeedModifyTotalTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcNotifyNeedModifyTotalTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUCalcNotifyNeedModifyTotalTime_IsValid = BGUCalcNotifyNeedModifyTotalTime_FunctionAddress != IntPtr.Zero && BGUCalcNotifyNeedModifyTotalTime_Unit_IsValid && BGUCalcNotifyNeedModifyTotalTime_NotifyEvent_IsValid && BGUCalcNotifyNeedModifyTotalTime_FromAMInstanceID_IsValid && BGUCalcNotifyNeedModifyTotalTime_CurNSLeftTime_IsValid && BGUCalcNotifyNeedModifyTotalTime_CurNSRightTime_IsValid && BGUCalcNotifyNeedModifyTotalTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibSkill:BGUCalcNotifyNeedModifyTotalTime", BGUCalcNotifyNeedModifyTotalTime_IsValid);
		BGUCalcMontageSpecificRangeTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUCalcMontageSpecificRangeTime");
		BGUCalcMontageSpecificRangeTime_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCalcMontageSpecificRangeTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcMontageSpecificRangeTime_Unit_PropertyAddress, BGUCalcMontageSpecificRangeTime_FunctionAddress, "Unit");
		BGUCalcMontageSpecificRangeTime_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcMontageSpecificRangeTime_FunctionAddress, "Unit");
		BGUCalcMontageSpecificRangeTime_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcMontageSpecificRangeTime_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcMontageSpecificRangeTime_FromAMInstanceID_PropertyAddress, BGUCalcMontageSpecificRangeTime_FunctionAddress, "FromAMInstanceID");
		BGUCalcMontageSpecificRangeTime_FromAMInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcMontageSpecificRangeTime_FunctionAddress, "FromAMInstanceID");
		BGUCalcMontageSpecificRangeTime_FromAMInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcMontageSpecificRangeTime_FunctionAddress, "FromAMInstanceID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcMontageSpecificRangeTime_LeftTime_PropertyAddress, BGUCalcMontageSpecificRangeTime_FunctionAddress, "LeftTime");
		BGUCalcMontageSpecificRangeTime_LeftTime_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcMontageSpecificRangeTime_FunctionAddress, "LeftTime");
		BGUCalcMontageSpecificRangeTime_LeftTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcMontageSpecificRangeTime_FunctionAddress, "LeftTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcMontageSpecificRangeTime_RightTime_PropertyAddress, BGUCalcMontageSpecificRangeTime_FunctionAddress, "RightTime");
		BGUCalcMontageSpecificRangeTime_RightTime_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcMontageSpecificRangeTime_FunctionAddress, "RightTime");
		BGUCalcMontageSpecificRangeTime_RightTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcMontageSpecificRangeTime_FunctionAddress, "RightTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcMontageSpecificRangeTime_CurMontage_PropertyAddress, BGUCalcMontageSpecificRangeTime_FunctionAddress, "CurMontage");
		BGUCalcMontageSpecificRangeTime_CurMontage_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcMontageSpecificRangeTime_FunctionAddress, "CurMontage");
		BGUCalcMontageSpecificRangeTime_CurMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcMontageSpecificRangeTime_FunctionAddress, "CurMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcMontageSpecificRangeTime_ReturnValue_PropertyAddress, BGUCalcMontageSpecificRangeTime_FunctionAddress, "ReturnValue");
		BGUCalcMontageSpecificRangeTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcMontageSpecificRangeTime_FunctionAddress, "ReturnValue");
		BGUCalcMontageSpecificRangeTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcMontageSpecificRangeTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUCalcMontageSpecificRangeTime_IsValid = BGUCalcMontageSpecificRangeTime_FunctionAddress != IntPtr.Zero && BGUCalcMontageSpecificRangeTime_Unit_IsValid && BGUCalcMontageSpecificRangeTime_FromAMInstanceID_IsValid && BGUCalcMontageSpecificRangeTime_LeftTime_IsValid && BGUCalcMontageSpecificRangeTime_RightTime_IsValid && BGUCalcMontageSpecificRangeTime_CurMontage_IsValid && BGUCalcMontageSpecificRangeTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibSkill:BGUCalcMontageSpecificRangeTime", BGUCalcMontageSpecificRangeTime_IsValid);
		BGUCalcMontageNeedModifyTotalTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUCalcMontageNeedModifyTotalTime");
		BGUCalcMontageNeedModifyTotalTime_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCalcMontageNeedModifyTotalTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcMontageNeedModifyTotalTime_Unit_PropertyAddress, BGUCalcMontageNeedModifyTotalTime_FunctionAddress, "Unit");
		BGUCalcMontageNeedModifyTotalTime_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcMontageNeedModifyTotalTime_FunctionAddress, "Unit");
		BGUCalcMontageNeedModifyTotalTime_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcMontageNeedModifyTotalTime_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcMontageNeedModifyTotalTime_FromAMInstanceID_PropertyAddress, BGUCalcMontageNeedModifyTotalTime_FunctionAddress, "FromAMInstanceID");
		BGUCalcMontageNeedModifyTotalTime_FromAMInstanceID_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcMontageNeedModifyTotalTime_FunctionAddress, "FromAMInstanceID");
		BGUCalcMontageNeedModifyTotalTime_FromAMInstanceID_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcMontageNeedModifyTotalTime_FunctionAddress, "FromAMInstanceID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcMontageNeedModifyTotalTime_ReturnValue_PropertyAddress, BGUCalcMontageNeedModifyTotalTime_FunctionAddress, "ReturnValue");
		BGUCalcMontageNeedModifyTotalTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcMontageNeedModifyTotalTime_FunctionAddress, "ReturnValue");
		BGUCalcMontageNeedModifyTotalTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcMontageNeedModifyTotalTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUCalcMontageNeedModifyTotalTime_IsValid = BGUCalcMontageNeedModifyTotalTime_FunctionAddress != IntPtr.Zero && BGUCalcMontageNeedModifyTotalTime_Unit_IsValid && BGUCalcMontageNeedModifyTotalTime_FromAMInstanceID_IsValid && BGUCalcMontageNeedModifyTotalTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFuncLibSkill:BGUCalcMontageNeedModifyTotalTime", BGUCalcMontageNeedModifyTotalTime_IsValid);
	}
}
