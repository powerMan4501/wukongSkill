using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_UINavigationFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetRepeatFactor_IsValid;

	private static IntPtr SetRepeatFactor_FunctionAddress;

	private static int SetRepeatFactor_ParamsSize;

	private static bool SetRepeatFactor_RepeatFactorInDefault_IsValid;

	private static FFieldAddress SetRepeatFactor_RepeatFactorInDefault_PropertyAddress;

	private static int SetRepeatFactor_RepeatFactorInDefault_Offset;

	private static bool SetRepeatFactor_RepeatFactorInPressure_IsValid;

	private static FFieldAddress SetRepeatFactor_RepeatFactorInPressure_PropertyAddress;

	private static int SetRepeatFactor_RepeatFactorInPressure_Offset;

	private static bool SetRepeatFactor_RepeatPressureFactor_IsValid;

	private static FFieldAddress SetRepeatFactor_RepeatPressureFactor_PropertyAddress;

	private static int SetRepeatFactor_RepeatPressureFactor_Offset;

	private static bool SetRepeatFactor_RepeatPressureCondition_IsValid;

	private static FFieldAddress SetRepeatFactor_RepeatPressureCondition_PropertyAddress;

	private static int SetRepeatFactor_RepeatPressureCondition_Offset;

	private static bool SetNeedTabKeyNavigation_IsValid;

	private static IntPtr SetNeedTabKeyNavigation_FunctionAddress;

	private static int SetNeedTabKeyNavigation_ParamsSize;

	private static bool SetNeedTabKeyNavigation_IsNeed_IsValid;

	private static FFieldAddress SetNeedTabKeyNavigation_IsNeed_PropertyAddress;

	private static int SetNeedTabKeyNavigation_IsNeed_Offset;

	private static bool SetNeedNavigationAction_IsValid;

	private static IntPtr SetNeedNavigationAction_FunctionAddress;

	private static int SetNeedNavigationAction_ParamsSize;

	private static bool SetNeedNavigationAction_IsNeed_IsValid;

	private static FFieldAddress SetNeedNavigationAction_IsNeed_PropertyAddress;

	private static int SetNeedNavigationAction_IsNeed_Offset;

	private static bool SetNeedKeyNavigation_IsValid;

	private static IntPtr SetNeedKeyNavigation_FunctionAddress;

	private static int SetNeedKeyNavigation_ParamsSize;

	private static bool SetNeedKeyNavigation_IsNeed_IsValid;

	private static FFieldAddress SetNeedKeyNavigation_IsNeed_PropertyAddress;

	private static int SetNeedKeyNavigation_IsNeed_Offset;

	private static bool SetNeedAnalogNavigation_IsValid;

	private static IntPtr SetNeedAnalogNavigation_FunctionAddress;

	private static int SetNeedAnalogNavigation_ParamsSize;

	private static bool SetNeedAnalogNavigation_IsNeed_IsValid;

	private static FFieldAddress SetNeedAnalogNavigation_IsNeed_PropertyAddress;

	private static int SetNeedAnalogNavigation_IsNeed_Offset;

	private static bool SetAnalogNavigationVerticalThreshold_IsValid;

	private static IntPtr SetAnalogNavigationVerticalThreshold_FunctionAddress;

	private static int SetAnalogNavigationVerticalThreshold_ParamsSize;

	private static bool SetAnalogNavigationVerticalThreshold_TargetThreshold_IsValid;

	private static FFieldAddress SetAnalogNavigationVerticalThreshold_TargetThreshold_PropertyAddress;

	private static int SetAnalogNavigationVerticalThreshold_TargetThreshold_Offset;

	private static bool SetAnalogNavigationHorizontalThreshold_IsValid;

	private static IntPtr SetAnalogNavigationHorizontalThreshold_FunctionAddress;

	private static int SetAnalogNavigationHorizontalThreshold_ParamsSize;

	private static bool SetAnalogNavigationHorizontalThreshold_TargetThreshold_IsValid;

	private static FFieldAddress SetAnalogNavigationHorizontalThreshold_TargetThreshold_PropertyAddress;

	private static int SetAnalogNavigationHorizontalThreshold_TargetThreshold_Offset;

	private static bool IsRepeatAction_IsValid;

	private static IntPtr IsRepeatAction_FunctionAddress;

	private static int IsRepeatAction_ParamsSize;

	private static bool IsRepeatAction_InKeyEvent_IsValid;

	private static FFieldAddress IsRepeatAction_InKeyEvent_PropertyAddress;

	private static int IsRepeatAction_InKeyEvent_Offset;

	private static bool IsRepeatAction_ReturnValue_IsValid;

	private static FFieldAddress IsRepeatAction_ReturnValue_PropertyAddress;

	private static int IsRepeatAction_ReturnValue_Offset;

	private static bool InitSetWorkingGSUINavigation_IsValid;

	private static IntPtr InitSetWorkingGSUINavigation_FunctionAddress;

	private static int InitSetWorkingGSUINavigation_ParamsSize;

	private static bool GetNavigationDirectionFromKey_IsValid;

	private static IntPtr GetNavigationDirectionFromKey_FunctionAddress;

	private static int GetNavigationDirectionFromKey_ParamsSize;

	private static bool GetNavigationDirectionFromKey_InKeyEvent_IsValid;

	private static FFieldAddress GetNavigationDirectionFromKey_InKeyEvent_PropertyAddress;

	private static int GetNavigationDirectionFromKey_InKeyEvent_Offset;

	private static bool GetNavigationDirectionFromKey_ReturnValue_IsValid;

	private static FFieldAddress GetNavigationDirectionFromKey_ReturnValue_PropertyAddress;

	private static int GetNavigationDirectionFromKey_ReturnValue_Offset;

	private static bool GetNavigationDirectionFromAnalogForOP_IsValid;

	private static IntPtr GetNavigationDirectionFromAnalogForOP_FunctionAddress;

	private static int GetNavigationDirectionFromAnalogForOP_ParamsSize;

	private static bool GetNavigationDirectionFromAnalogForOP_InAnalogEvent_IsValid;

	private static FFieldAddress GetNavigationDirectionFromAnalogForOP_InAnalogEvent_PropertyAddress;

	private static int GetNavigationDirectionFromAnalogForOP_InAnalogEvent_Offset;

	private static bool GetNavigationDirectionFromAnalogForOP_ReturnValue_IsValid;

	private static FFieldAddress GetNavigationDirectionFromAnalogForOP_ReturnValue_PropertyAddress;

	private static int GetNavigationDirectionFromAnalogForOP_ReturnValue_Offset;

	private static bool GetNavigationActionFromKey_IsValid;

	private static IntPtr GetNavigationActionFromKey_FunctionAddress;

	private static int GetNavigationActionFromKey_ParamsSize;

	private static bool GetNavigationActionFromKey_InKeyEvent_IsValid;

	private static FFieldAddress GetNavigationActionFromKey_InKeyEvent_PropertyAddress;

	private static int GetNavigationActionFromKey_InKeyEvent_Offset;

	private static bool GetNavigationActionFromKey_ReturnValue_IsValid;

	private static FFieldAddress GetNavigationActionFromKey_ReturnValue_PropertyAddress;

	private static int GetNavigationActionFromKey_ReturnValue_Offset;

	private static bool GetIsNeedTabKeyNavigation_IsValid;

	private static IntPtr GetIsNeedTabKeyNavigation_FunctionAddress;

	private static int GetIsNeedTabKeyNavigation_ParamsSize;

	private static bool GetIsNeedTabKeyNavigation_ReturnValue_IsValid;

	private static FFieldAddress GetIsNeedTabKeyNavigation_ReturnValue_PropertyAddress;

	private static int GetIsNeedTabKeyNavigation_ReturnValue_Offset;

	private static bool GetIsNeedNavigationAction_IsValid;

	private static IntPtr GetIsNeedNavigationAction_FunctionAddress;

	private static int GetIsNeedNavigationAction_ParamsSize;

	private static bool GetIsNeedNavigationAction_ReturnValue_IsValid;

	private static FFieldAddress GetIsNeedNavigationAction_ReturnValue_PropertyAddress;

	private static int GetIsNeedNavigationAction_ReturnValue_Offset;

	private static bool GetIsNeedKeyNavigation_IsValid;

	private static IntPtr GetIsNeedKeyNavigation_FunctionAddress;

	private static int GetIsNeedKeyNavigation_ParamsSize;

	private static bool GetIsNeedKeyNavigation_ReturnValue_IsValid;

	private static FFieldAddress GetIsNeedKeyNavigation_ReturnValue_PropertyAddress;

	private static int GetIsNeedKeyNavigation_ReturnValue_Offset;

	private static bool GetIsNeedAnalogNavigation_IsValid;

	private static IntPtr GetIsNeedAnalogNavigation_FunctionAddress;

	private static int GetIsNeedAnalogNavigation_ParamsSize;

	private static bool GetIsNeedAnalogNavigation_ReturnValue_IsValid;

	private static FFieldAddress GetIsNeedAnalogNavigation_ReturnValue_PropertyAddress;

	private static int GetIsNeedAnalogNavigation_ReturnValue_Offset;

	private static bool ClearNavigationKeyByNavigation_IsValid;

	private static IntPtr ClearNavigationKeyByNavigation_FunctionAddress;

	private static int ClearNavigationKeyByNavigation_ParamsSize;

	private static bool ClearNavigationKeyByNavigation_TargetNavigation_IsValid;

	private static FFieldAddress ClearNavigationKeyByNavigation_TargetNavigation_PropertyAddress;

	private static int ClearNavigationKeyByNavigation_TargetNavigation_Offset;

	private static bool ClearNavigationKey_IsValid;

	private static IntPtr ClearNavigationKey_FunctionAddress;

	private static int ClearNavigationKey_ParamsSize;

	private static bool ClearNavigationKey_KeyName_IsValid;

	private static FFieldAddress ClearNavigationKey_KeyName_PropertyAddress;

	private static int ClearNavigationKey_KeyName_Offset;

	private static bool ClearNavigationActionKeyByAction_IsValid;

	private static IntPtr ClearNavigationActionKeyByAction_FunctionAddress;

	private static int ClearNavigationActionKeyByAction_ParamsSize;

	private static bool ClearNavigationActionKeyByAction_TargetNavigationAction_IsValid;

	private static FFieldAddress ClearNavigationActionKeyByAction_TargetNavigationAction_PropertyAddress;

	private static int ClearNavigationActionKeyByAction_TargetNavigationAction_Offset;

	private static bool ClearNavigationActionKey_IsValid;

	private static IntPtr ClearNavigationActionKey_FunctionAddress;

	private static int ClearNavigationActionKey_ParamsSize;

	private static bool ClearNavigationActionKey_KeyName_IsValid;

	private static FFieldAddress ClearNavigationActionKey_KeyName_PropertyAddress;

	private static int ClearNavigationActionKey_KeyName_Offset;

	private static bool ClearAllNavigationKey_IsValid;

	private static IntPtr ClearAllNavigationKey_FunctionAddress;

	private static int ClearAllNavigationKey_ParamsSize;

	private static bool ClearAllNavigationActionKey_IsValid;

	private static IntPtr ClearAllNavigationActionKey_FunctionAddress;

	private static int ClearAllNavigationActionKey_ParamsSize;

	private static bool BlockConflictNavigation_IsValid;

	private static IntPtr BlockConflictNavigation_FunctionAddress;

	private static int BlockConflictNavigation_ParamsSize;

	private static bool BlockConflictNavigation_ConflictNavigationType_IsValid;

	private static FFieldAddress BlockConflictNavigation_ConflictNavigationType_PropertyAddress;

	private static int BlockConflictNavigation_ConflictNavigationType_Offset;

	private static bool BlockConflictNavigation_bBlock_IsValid;

	private static FFieldAddress BlockConflictNavigation_bBlock_PropertyAddress;

	private static int BlockConflictNavigation_bBlock_Offset;

	private static bool BlockConflictNavigation_NotBlockNavigations_IsValid;

	private static FFieldAddress BlockConflictNavigation_NotBlockNavigations_PropertyAddress;

	private static int BlockConflictNavigation_NotBlockNavigations_Offset;

	private static bool AddNavigationKey_IsValid;

	private static IntPtr AddNavigationKey_FunctionAddress;

	private static int AddNavigationKey_ParamsSize;

	private static bool AddNavigationKey_TargetNavigation_IsValid;

	private static FFieldAddress AddNavigationKey_TargetNavigation_PropertyAddress;

	private static int AddNavigationKey_TargetNavigation_Offset;

	private static bool AddNavigationKey_KeyName_IsValid;

	private static FFieldAddress AddNavigationKey_KeyName_PropertyAddress;

	private static int AddNavigationKey_KeyName_Offset;

	private static bool AddNavigationActionKey_IsValid;

	private static IntPtr AddNavigationActionKey_FunctionAddress;

	private static int AddNavigationActionKey_ParamsSize;

	private static bool AddNavigationActionKey_TargetNavigationAction_IsValid;

	private static FFieldAddress AddNavigationActionKey_TargetNavigationAction_PropertyAddress;

	private static int AddNavigationActionKey_TargetNavigationAction_Offset;

	private static bool AddNavigationActionKey_KeyName_IsValid;

	private static FFieldAddress AddNavigationActionKey_KeyName_PropertyAddress;

	private static int AddNavigationActionKey_KeyName_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetRepeatFactor")]
	public unsafe static void SetRepeatFactor(float RepeatFactorInDefault, float RepeatFactorInPressure, float RepeatPressureFactor, float RepeatPressureCondition)
	{
		if (!SetRepeatFactor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetRepeatFactor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRepeatFactor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRepeatFactor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRepeatFactor_RepeatFactorInDefault_Offset), 0, SetRepeatFactor_RepeatFactorInDefault_PropertyAddress.Address, RepeatFactorInDefault);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRepeatFactor_RepeatFactorInPressure_Offset), 0, SetRepeatFactor_RepeatFactorInPressure_PropertyAddress.Address, RepeatFactorInPressure);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRepeatFactor_RepeatPressureFactor_Offset), 0, SetRepeatFactor_RepeatPressureFactor_PropertyAddress.Address, RepeatPressureFactor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRepeatFactor_RepeatPressureCondition_Offset), 0, SetRepeatFactor_RepeatPressureCondition_PropertyAddress.Address, RepeatPressureCondition);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRepeatFactor_FunctionAddress, intPtr, SetRepeatFactor_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetNeedTabKeyNavigation")]
	public unsafe static void SetNeedTabKeyNavigation(bool IsNeed)
	{
		if (!SetNeedTabKeyNavigation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetNeedTabKeyNavigation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNeedTabKeyNavigation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNeedTabKeyNavigation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNeedTabKeyNavigation_IsNeed_Offset), 0, SetNeedTabKeyNavigation_IsNeed_PropertyAddress.Address, IsNeed);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNeedTabKeyNavigation_FunctionAddress, intPtr, SetNeedTabKeyNavigation_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetNeedNavigationAction")]
	public unsafe static void SetNeedNavigationAction(bool IsNeed)
	{
		if (!SetNeedNavigationAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetNeedNavigationAction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNeedNavigationAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNeedNavigationAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNeedNavigationAction_IsNeed_Offset), 0, SetNeedNavigationAction_IsNeed_PropertyAddress.Address, IsNeed);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNeedNavigationAction_FunctionAddress, intPtr, SetNeedNavigationAction_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetNeedKeyNavigation")]
	public unsafe static void SetNeedKeyNavigation(bool IsNeed)
	{
		if (!SetNeedKeyNavigation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetNeedKeyNavigation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNeedKeyNavigation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNeedKeyNavigation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNeedKeyNavigation_IsNeed_Offset), 0, SetNeedKeyNavigation_IsNeed_PropertyAddress.Address, IsNeed);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNeedKeyNavigation_FunctionAddress, intPtr, SetNeedKeyNavigation_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetNeedAnalogNavigation")]
	public unsafe static void SetNeedAnalogNavigation(bool IsNeed)
	{
		if (!SetNeedAnalogNavigation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetNeedAnalogNavigation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNeedAnalogNavigation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNeedAnalogNavigation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNeedAnalogNavigation_IsNeed_Offset), 0, SetNeedAnalogNavigation_IsNeed_PropertyAddress.Address, IsNeed);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNeedAnalogNavigation_FunctionAddress, intPtr, SetNeedAnalogNavigation_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetAnalogNavigationVerticalThreshold")]
	public unsafe static void SetAnalogNavigationVerticalThreshold(float TargetThreshold)
	{
		if (!SetAnalogNavigationVerticalThreshold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetAnalogNavigationVerticalThreshold");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnalogNavigationVerticalThreshold_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnalogNavigationVerticalThreshold_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAnalogNavigationVerticalThreshold_TargetThreshold_Offset), 0, SetAnalogNavigationVerticalThreshold_TargetThreshold_PropertyAddress.Address, TargetThreshold);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAnalogNavigationVerticalThreshold_FunctionAddress, intPtr, SetAnalogNavigationVerticalThreshold_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetAnalogNavigationHorizontalThreshold")]
	public unsafe static void SetAnalogNavigationHorizontalThreshold(float TargetThreshold)
	{
		if (!SetAnalogNavigationHorizontalThreshold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetAnalogNavigationHorizontalThreshold");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnalogNavigationHorizontalThreshold_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnalogNavigationHorizontalThreshold_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAnalogNavigationHorizontalThreshold_TargetThreshold_Offset), 0, SetAnalogNavigationHorizontalThreshold_TargetThreshold_PropertyAddress.Address, TargetThreshold);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAnalogNavigationHorizontalThreshold_FunctionAddress, intPtr, SetAnalogNavigationHorizontalThreshold_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:IsRepeatAction")]
	public unsafe static bool IsRepeatAction(FKeyEvent InKeyEvent)
	{
		if (!IsRepeatAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:IsRepeatAction");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRepeatAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRepeatAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsRepeatAction_InKeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, IsRepeatAction_InKeyEvent_Offset), 0, IsRepeatAction_InKeyEvent_PropertyAddress.Address, InKeyEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsRepeatAction_FunctionAddress, intPtr, IsRepeatAction_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsRepeatAction_InKeyEvent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRepeatAction_ReturnValue_Offset), 0, IsRepeatAction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:InitSetWorkingGSUINavigation")]
	public unsafe static void InitSetWorkingGSUINavigation()
	{
		if (!InitSetWorkingGSUINavigation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:InitSetWorkingGSUINavigation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitSetWorkingGSUINavigation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitSetWorkingGSUINavigation_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: InitSetWorkingGSUINavigation_FunctionAddress, argsSize: InitSetWorkingGSUINavigation_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetNavigationDirectionFromKey")]
	public unsafe static EUINavigation GetNavigationDirectionFromKey(FKeyEvent InKeyEvent)
	{
		if (!GetNavigationDirectionFromKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetNavigationDirectionFromKey");
			return EUINavigation.Left;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNavigationDirectionFromKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNavigationDirectionFromKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNavigationDirectionFromKey_InKeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, GetNavigationDirectionFromKey_InKeyEvent_Offset), 0, GetNavigationDirectionFromKey_InKeyEvent_PropertyAddress.Address, InKeyEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNavigationDirectionFromKey_FunctionAddress, intPtr, GetNavigationDirectionFromKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetNavigationDirectionFromKey_InKeyEvent_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EUINavigation>.FromNative(IntPtr.Add(intPtr, GetNavigationDirectionFromKey_ReturnValue_Offset), 0, GetNavigationDirectionFromKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetNavigationDirectionFromAnalogForOP")]
	public unsafe static EUINavigation GetNavigationDirectionFromAnalogForOP(FAnalogInputEvent InAnalogEvent)
	{
		if (!GetNavigationDirectionFromAnalogForOP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetNavigationDirectionFromAnalogForOP");
			return EUINavigation.Left;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNavigationDirectionFromAnalogForOP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNavigationDirectionFromAnalogForOP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNavigationDirectionFromAnalogForOP_InAnalogEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnalogInputEvent>.ToNative(IntPtr.Add(intPtr, GetNavigationDirectionFromAnalogForOP_InAnalogEvent_Offset), 0, GetNavigationDirectionFromAnalogForOP_InAnalogEvent_PropertyAddress.Address, InAnalogEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNavigationDirectionFromAnalogForOP_FunctionAddress, intPtr, GetNavigationDirectionFromAnalogForOP_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetNavigationDirectionFromAnalogForOP_InAnalogEvent_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EUINavigation>.FromNative(IntPtr.Add(intPtr, GetNavigationDirectionFromAnalogForOP_ReturnValue_Offset), 0, GetNavigationDirectionFromAnalogForOP_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetNavigationActionFromKey")]
	public unsafe static EUINavigationAction GetNavigationActionFromKey(FKeyEvent InKeyEvent)
	{
		if (!GetNavigationActionFromKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetNavigationActionFromKey");
			return EUINavigationAction.Accept;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNavigationActionFromKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNavigationActionFromKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNavigationActionFromKey_InKeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, GetNavigationActionFromKey_InKeyEvent_Offset), 0, GetNavigationActionFromKey_InKeyEvent_PropertyAddress.Address, InKeyEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNavigationActionFromKey_FunctionAddress, intPtr, GetNavigationActionFromKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetNavigationActionFromKey_InKeyEvent_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EUINavigationAction>.FromNative(IntPtr.Add(intPtr, GetNavigationActionFromKey_ReturnValue_Offset), 0, GetNavigationActionFromKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetIsNeedTabKeyNavigation")]
	public unsafe static bool GetIsNeedTabKeyNavigation()
	{
		if (!GetIsNeedTabKeyNavigation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetIsNeedTabKeyNavigation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsNeedTabKeyNavigation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsNeedTabKeyNavigation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsNeedTabKeyNavigation_FunctionAddress, intPtr, GetIsNeedTabKeyNavigation_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsNeedTabKeyNavigation_ReturnValue_Offset), 0, GetIsNeedTabKeyNavigation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetIsNeedNavigationAction")]
	public unsafe static bool GetIsNeedNavigationAction()
	{
		if (!GetIsNeedNavigationAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetIsNeedNavigationAction");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsNeedNavigationAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsNeedNavigationAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsNeedNavigationAction_FunctionAddress, intPtr, GetIsNeedNavigationAction_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsNeedNavigationAction_ReturnValue_Offset), 0, GetIsNeedNavigationAction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetIsNeedKeyNavigation")]
	public unsafe static bool GetIsNeedKeyNavigation()
	{
		if (!GetIsNeedKeyNavigation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetIsNeedKeyNavigation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsNeedKeyNavigation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsNeedKeyNavigation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsNeedKeyNavigation_FunctionAddress, intPtr, GetIsNeedKeyNavigation_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsNeedKeyNavigation_ReturnValue_Offset), 0, GetIsNeedKeyNavigation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetIsNeedAnalogNavigation")]
	public unsafe static bool GetIsNeedAnalogNavigation()
	{
		if (!GetIsNeedAnalogNavigation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetIsNeedAnalogNavigation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsNeedAnalogNavigation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsNeedAnalogNavigation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsNeedAnalogNavigation_FunctionAddress, intPtr, GetIsNeedAnalogNavigation_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsNeedAnalogNavigation_ReturnValue_Offset), 0, GetIsNeedAnalogNavigation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearNavigationKeyByNavigation")]
	public unsafe static void ClearNavigationKeyByNavigation(EUINavigation TargetNavigation)
	{
		if (!ClearNavigationKeyByNavigation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearNavigationKeyByNavigation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearNavigationKeyByNavigation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearNavigationKeyByNavigation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUINavigation>.ToNative(IntPtr.Add(intPtr, ClearNavigationKeyByNavigation_TargetNavigation_Offset), 0, ClearNavigationKeyByNavigation_TargetNavigation_PropertyAddress.Address, TargetNavigation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearNavigationKeyByNavigation_FunctionAddress, intPtr, ClearNavigationKeyByNavigation_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearNavigationKey")]
	public unsafe static void ClearNavigationKey(FName KeyName)
	{
		if (!ClearNavigationKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearNavigationKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearNavigationKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearNavigationKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ClearNavigationKey_KeyName_Offset), 0, ClearNavigationKey_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearNavigationKey_FunctionAddress, intPtr, ClearNavigationKey_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearNavigationActionKeyByAction")]
	public unsafe static void ClearNavigationActionKeyByAction(EUINavigationAction TargetNavigationAction)
	{
		if (!ClearNavigationActionKeyByAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearNavigationActionKeyByAction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearNavigationActionKeyByAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearNavigationActionKeyByAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUINavigationAction>.ToNative(IntPtr.Add(intPtr, ClearNavigationActionKeyByAction_TargetNavigationAction_Offset), 0, ClearNavigationActionKeyByAction_TargetNavigationAction_PropertyAddress.Address, TargetNavigationAction);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearNavigationActionKeyByAction_FunctionAddress, intPtr, ClearNavigationActionKeyByAction_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearNavigationActionKey")]
	public unsafe static void ClearNavigationActionKey(FName KeyName)
	{
		if (!ClearNavigationActionKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearNavigationActionKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearNavigationActionKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearNavigationActionKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ClearNavigationActionKey_KeyName_Offset), 0, ClearNavigationActionKey_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearNavigationActionKey_FunctionAddress, intPtr, ClearNavigationActionKey_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearAllNavigationKey")]
	public unsafe static void ClearAllNavigationKey()
	{
		if (!ClearAllNavigationKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearAllNavigationKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAllNavigationKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAllNavigationKey_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: ClearAllNavigationKey_FunctionAddress, argsSize: ClearAllNavigationKey_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearAllNavigationActionKey")]
	public unsafe static void ClearAllNavigationActionKey()
	{
		if (!ClearAllNavigationActionKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearAllNavigationActionKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAllNavigationActionKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAllNavigationActionKey_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: ClearAllNavigationActionKey_FunctionAddress, argsSize: ClearAllNavigationActionKey_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:BlockConflictNavigation")]
	public unsafe static void BlockConflictNavigation(EGSUIConflictNavigationType ConflictNavigationType, bool bBlock, List<EUINavigation> NotBlockNavigations)
	{
		if (!BlockConflictNavigation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:BlockConflictNavigation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BlockConflictNavigation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BlockConflictNavigation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EGSUIConflictNavigationType>.ToNative(IntPtr.Add(intPtr, BlockConflictNavigation_ConflictNavigationType_Offset), 0, BlockConflictNavigation_ConflictNavigationType_PropertyAddress.Address, ConflictNavigationType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BlockConflictNavigation_bBlock_Offset), 0, BlockConflictNavigation_bBlock_PropertyAddress.Address, bBlock);
		new TArrayCopyMarshaler<EUINavigation>(1, BlockConflictNavigation_NotBlockNavigations_PropertyAddress, CachedMarshalingDelegates<EUINavigation, EnumMarshaler<EUINavigation>>.FromNative, CachedMarshalingDelegates<EUINavigation, EnumMarshaler<EUINavigation>>.ToNative).ToNative(IntPtr.Add(intPtr, BlockConflictNavigation_NotBlockNavigations_Offset), NotBlockNavigations);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BlockConflictNavigation_FunctionAddress, intPtr, BlockConflictNavigation_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BlockConflictNavigation_NotBlockNavigations_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:AddNavigationKey")]
	public unsafe static void AddNavigationKey(EUINavigation TargetNavigation, FName KeyName)
	{
		if (!AddNavigationKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:AddNavigationKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNavigationKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNavigationKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUINavigation>.ToNative(IntPtr.Add(intPtr, AddNavigationKey_TargetNavigation_Offset), 0, AddNavigationKey_TargetNavigation_PropertyAddress.Address, TargetNavigation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddNavigationKey_KeyName_Offset), 0, AddNavigationKey_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddNavigationKey_FunctionAddress, intPtr, AddNavigationKey_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UINavigationFuncLib:AddNavigationActionKey")]
	public unsafe static void AddNavigationActionKey(EUINavigationAction TargetNavigationAction, FName KeyName)
	{
		if (!AddNavigationActionKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UINavigationFuncLib:AddNavigationActionKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNavigationActionKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNavigationActionKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUINavigationAction>.ToNative(IntPtr.Add(intPtr, AddNavigationActionKey_TargetNavigationAction_Offset), 0, AddNavigationActionKey_TargetNavigationAction_PropertyAddress.Address, TargetNavigationAction);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddNavigationActionKey_KeyName_Offset), 0, AddNavigationActionKey_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddNavigationActionKey_FunctionAddress, intPtr, AddNavigationActionKey_ParamsSize);
	}

	static UGSE_UINavigationFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_UINavigationFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_UINavigationFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_UINavigationFuncLib");
		SetRepeatFactor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRepeatFactor");
		SetRepeatFactor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRepeatFactor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRepeatFactor_RepeatFactorInDefault_PropertyAddress, SetRepeatFactor_FunctionAddress, "RepeatFactorInDefault");
		SetRepeatFactor_RepeatFactorInDefault_Offset = NativeReflectionCached.GetPropertyOffset(SetRepeatFactor_FunctionAddress, "RepeatFactorInDefault");
		SetRepeatFactor_RepeatFactorInDefault_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRepeatFactor_FunctionAddress, "RepeatFactorInDefault", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRepeatFactor_RepeatFactorInPressure_PropertyAddress, SetRepeatFactor_FunctionAddress, "RepeatFactorInPressure");
		SetRepeatFactor_RepeatFactorInPressure_Offset = NativeReflectionCached.GetPropertyOffset(SetRepeatFactor_FunctionAddress, "RepeatFactorInPressure");
		SetRepeatFactor_RepeatFactorInPressure_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRepeatFactor_FunctionAddress, "RepeatFactorInPressure", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRepeatFactor_RepeatPressureFactor_PropertyAddress, SetRepeatFactor_FunctionAddress, "RepeatPressureFactor");
		SetRepeatFactor_RepeatPressureFactor_Offset = NativeReflectionCached.GetPropertyOffset(SetRepeatFactor_FunctionAddress, "RepeatPressureFactor");
		SetRepeatFactor_RepeatPressureFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRepeatFactor_FunctionAddress, "RepeatPressureFactor", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRepeatFactor_RepeatPressureCondition_PropertyAddress, SetRepeatFactor_FunctionAddress, "RepeatPressureCondition");
		SetRepeatFactor_RepeatPressureCondition_Offset = NativeReflectionCached.GetPropertyOffset(SetRepeatFactor_FunctionAddress, "RepeatPressureCondition");
		SetRepeatFactor_RepeatPressureCondition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRepeatFactor_FunctionAddress, "RepeatPressureCondition", Classes.FFloatProperty);
		SetRepeatFactor_IsValid = SetRepeatFactor_FunctionAddress != IntPtr.Zero && SetRepeatFactor_RepeatFactorInDefault_IsValid && SetRepeatFactor_RepeatFactorInPressure_IsValid && SetRepeatFactor_RepeatPressureFactor_IsValid && SetRepeatFactor_RepeatPressureCondition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetRepeatFactor", SetRepeatFactor_IsValid);
		SetNeedTabKeyNavigation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNeedTabKeyNavigation");
		SetNeedTabKeyNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNeedTabKeyNavigation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNeedTabKeyNavigation_IsNeed_PropertyAddress, SetNeedTabKeyNavigation_FunctionAddress, "IsNeed");
		SetNeedTabKeyNavigation_IsNeed_Offset = NativeReflectionCached.GetPropertyOffset(SetNeedTabKeyNavigation_FunctionAddress, "IsNeed");
		SetNeedTabKeyNavigation_IsNeed_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNeedTabKeyNavigation_FunctionAddress, "IsNeed", Classes.FBoolProperty);
		SetNeedTabKeyNavigation_IsValid = SetNeedTabKeyNavigation_FunctionAddress != IntPtr.Zero && SetNeedTabKeyNavigation_IsNeed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetNeedTabKeyNavigation", SetNeedTabKeyNavigation_IsValid);
		SetNeedNavigationAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNeedNavigationAction");
		SetNeedNavigationAction_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNeedNavigationAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNeedNavigationAction_IsNeed_PropertyAddress, SetNeedNavigationAction_FunctionAddress, "IsNeed");
		SetNeedNavigationAction_IsNeed_Offset = NativeReflectionCached.GetPropertyOffset(SetNeedNavigationAction_FunctionAddress, "IsNeed");
		SetNeedNavigationAction_IsNeed_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNeedNavigationAction_FunctionAddress, "IsNeed", Classes.FBoolProperty);
		SetNeedNavigationAction_IsValid = SetNeedNavigationAction_FunctionAddress != IntPtr.Zero && SetNeedNavigationAction_IsNeed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetNeedNavigationAction", SetNeedNavigationAction_IsValid);
		SetNeedKeyNavigation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNeedKeyNavigation");
		SetNeedKeyNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNeedKeyNavigation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNeedKeyNavigation_IsNeed_PropertyAddress, SetNeedKeyNavigation_FunctionAddress, "IsNeed");
		SetNeedKeyNavigation_IsNeed_Offset = NativeReflectionCached.GetPropertyOffset(SetNeedKeyNavigation_FunctionAddress, "IsNeed");
		SetNeedKeyNavigation_IsNeed_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNeedKeyNavigation_FunctionAddress, "IsNeed", Classes.FBoolProperty);
		SetNeedKeyNavigation_IsValid = SetNeedKeyNavigation_FunctionAddress != IntPtr.Zero && SetNeedKeyNavigation_IsNeed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetNeedKeyNavigation", SetNeedKeyNavigation_IsValid);
		SetNeedAnalogNavigation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNeedAnalogNavigation");
		SetNeedAnalogNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNeedAnalogNavigation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNeedAnalogNavigation_IsNeed_PropertyAddress, SetNeedAnalogNavigation_FunctionAddress, "IsNeed");
		SetNeedAnalogNavigation_IsNeed_Offset = NativeReflectionCached.GetPropertyOffset(SetNeedAnalogNavigation_FunctionAddress, "IsNeed");
		SetNeedAnalogNavigation_IsNeed_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNeedAnalogNavigation_FunctionAddress, "IsNeed", Classes.FBoolProperty);
		SetNeedAnalogNavigation_IsValid = SetNeedAnalogNavigation_FunctionAddress != IntPtr.Zero && SetNeedAnalogNavigation_IsNeed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetNeedAnalogNavigation", SetNeedAnalogNavigation_IsValid);
		SetAnalogNavigationVerticalThreshold_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAnalogNavigationVerticalThreshold");
		SetAnalogNavigationVerticalThreshold_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnalogNavigationVerticalThreshold_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnalogNavigationVerticalThreshold_TargetThreshold_PropertyAddress, SetAnalogNavigationVerticalThreshold_FunctionAddress, "TargetThreshold");
		SetAnalogNavigationVerticalThreshold_TargetThreshold_Offset = NativeReflectionCached.GetPropertyOffset(SetAnalogNavigationVerticalThreshold_FunctionAddress, "TargetThreshold");
		SetAnalogNavigationVerticalThreshold_TargetThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnalogNavigationVerticalThreshold_FunctionAddress, "TargetThreshold", Classes.FFloatProperty);
		SetAnalogNavigationVerticalThreshold_IsValid = SetAnalogNavigationVerticalThreshold_FunctionAddress != IntPtr.Zero && SetAnalogNavigationVerticalThreshold_TargetThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetAnalogNavigationVerticalThreshold", SetAnalogNavigationVerticalThreshold_IsValid);
		SetAnalogNavigationHorizontalThreshold_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAnalogNavigationHorizontalThreshold");
		SetAnalogNavigationHorizontalThreshold_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnalogNavigationHorizontalThreshold_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnalogNavigationHorizontalThreshold_TargetThreshold_PropertyAddress, SetAnalogNavigationHorizontalThreshold_FunctionAddress, "TargetThreshold");
		SetAnalogNavigationHorizontalThreshold_TargetThreshold_Offset = NativeReflectionCached.GetPropertyOffset(SetAnalogNavigationHorizontalThreshold_FunctionAddress, "TargetThreshold");
		SetAnalogNavigationHorizontalThreshold_TargetThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnalogNavigationHorizontalThreshold_FunctionAddress, "TargetThreshold", Classes.FFloatProperty);
		SetAnalogNavigationHorizontalThreshold_IsValid = SetAnalogNavigationHorizontalThreshold_FunctionAddress != IntPtr.Zero && SetAnalogNavigationHorizontalThreshold_TargetThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:SetAnalogNavigationHorizontalThreshold", SetAnalogNavigationHorizontalThreshold_IsValid);
		IsRepeatAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsRepeatAction");
		IsRepeatAction_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRepeatAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRepeatAction_InKeyEvent_PropertyAddress, IsRepeatAction_FunctionAddress, "InKeyEvent");
		IsRepeatAction_InKeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(IsRepeatAction_FunctionAddress, "InKeyEvent");
		IsRepeatAction_InKeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRepeatAction_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRepeatAction_ReturnValue_PropertyAddress, IsRepeatAction_FunctionAddress, "ReturnValue");
		IsRepeatAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRepeatAction_FunctionAddress, "ReturnValue");
		IsRepeatAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRepeatAction_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRepeatAction_IsValid = IsRepeatAction_FunctionAddress != IntPtr.Zero && IsRepeatAction_InKeyEvent_IsValid && IsRepeatAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:IsRepeatAction", IsRepeatAction_IsValid);
		InitSetWorkingGSUINavigation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InitSetWorkingGSUINavigation");
		InitSetWorkingGSUINavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(InitSetWorkingGSUINavigation_FunctionAddress);
		InitSetWorkingGSUINavigation_IsValid = InitSetWorkingGSUINavigation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:InitSetWorkingGSUINavigation", InitSetWorkingGSUINavigation_IsValid);
		GetNavigationDirectionFromKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNavigationDirectionFromKey");
		GetNavigationDirectionFromKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNavigationDirectionFromKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNavigationDirectionFromKey_InKeyEvent_PropertyAddress, GetNavigationDirectionFromKey_FunctionAddress, "InKeyEvent");
		GetNavigationDirectionFromKey_InKeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetNavigationDirectionFromKey_FunctionAddress, "InKeyEvent");
		GetNavigationDirectionFromKey_InKeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNavigationDirectionFromKey_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNavigationDirectionFromKey_ReturnValue_PropertyAddress, GetNavigationDirectionFromKey_FunctionAddress, "ReturnValue");
		GetNavigationDirectionFromKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNavigationDirectionFromKey_FunctionAddress, "ReturnValue");
		GetNavigationDirectionFromKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNavigationDirectionFromKey_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetNavigationDirectionFromKey_IsValid = GetNavigationDirectionFromKey_FunctionAddress != IntPtr.Zero && GetNavigationDirectionFromKey_InKeyEvent_IsValid && GetNavigationDirectionFromKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetNavigationDirectionFromKey", GetNavigationDirectionFromKey_IsValid);
		GetNavigationDirectionFromAnalogForOP_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNavigationDirectionFromAnalogForOP");
		GetNavigationDirectionFromAnalogForOP_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNavigationDirectionFromAnalogForOP_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNavigationDirectionFromAnalogForOP_InAnalogEvent_PropertyAddress, GetNavigationDirectionFromAnalogForOP_FunctionAddress, "InAnalogEvent");
		GetNavigationDirectionFromAnalogForOP_InAnalogEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetNavigationDirectionFromAnalogForOP_FunctionAddress, "InAnalogEvent");
		GetNavigationDirectionFromAnalogForOP_InAnalogEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNavigationDirectionFromAnalogForOP_FunctionAddress, "InAnalogEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNavigationDirectionFromAnalogForOP_ReturnValue_PropertyAddress, GetNavigationDirectionFromAnalogForOP_FunctionAddress, "ReturnValue");
		GetNavigationDirectionFromAnalogForOP_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNavigationDirectionFromAnalogForOP_FunctionAddress, "ReturnValue");
		GetNavigationDirectionFromAnalogForOP_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNavigationDirectionFromAnalogForOP_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetNavigationDirectionFromAnalogForOP_IsValid = GetNavigationDirectionFromAnalogForOP_FunctionAddress != IntPtr.Zero && GetNavigationDirectionFromAnalogForOP_InAnalogEvent_IsValid && GetNavigationDirectionFromAnalogForOP_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetNavigationDirectionFromAnalogForOP", GetNavigationDirectionFromAnalogForOP_IsValid);
		GetNavigationActionFromKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNavigationActionFromKey");
		GetNavigationActionFromKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNavigationActionFromKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNavigationActionFromKey_InKeyEvent_PropertyAddress, GetNavigationActionFromKey_FunctionAddress, "InKeyEvent");
		GetNavigationActionFromKey_InKeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetNavigationActionFromKey_FunctionAddress, "InKeyEvent");
		GetNavigationActionFromKey_InKeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNavigationActionFromKey_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNavigationActionFromKey_ReturnValue_PropertyAddress, GetNavigationActionFromKey_FunctionAddress, "ReturnValue");
		GetNavigationActionFromKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNavigationActionFromKey_FunctionAddress, "ReturnValue");
		GetNavigationActionFromKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNavigationActionFromKey_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetNavigationActionFromKey_IsValid = GetNavigationActionFromKey_FunctionAddress != IntPtr.Zero && GetNavigationActionFromKey_InKeyEvent_IsValid && GetNavigationActionFromKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetNavigationActionFromKey", GetNavigationActionFromKey_IsValid);
		GetIsNeedTabKeyNavigation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsNeedTabKeyNavigation");
		GetIsNeedTabKeyNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsNeedTabKeyNavigation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsNeedTabKeyNavigation_ReturnValue_PropertyAddress, GetIsNeedTabKeyNavigation_FunctionAddress, "ReturnValue");
		GetIsNeedTabKeyNavigation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsNeedTabKeyNavigation_FunctionAddress, "ReturnValue");
		GetIsNeedTabKeyNavigation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsNeedTabKeyNavigation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsNeedTabKeyNavigation_IsValid = GetIsNeedTabKeyNavigation_FunctionAddress != IntPtr.Zero && GetIsNeedTabKeyNavigation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetIsNeedTabKeyNavigation", GetIsNeedTabKeyNavigation_IsValid);
		GetIsNeedNavigationAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsNeedNavigationAction");
		GetIsNeedNavigationAction_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsNeedNavigationAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsNeedNavigationAction_ReturnValue_PropertyAddress, GetIsNeedNavigationAction_FunctionAddress, "ReturnValue");
		GetIsNeedNavigationAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsNeedNavigationAction_FunctionAddress, "ReturnValue");
		GetIsNeedNavigationAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsNeedNavigationAction_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsNeedNavigationAction_IsValid = GetIsNeedNavigationAction_FunctionAddress != IntPtr.Zero && GetIsNeedNavigationAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetIsNeedNavigationAction", GetIsNeedNavigationAction_IsValid);
		GetIsNeedKeyNavigation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsNeedKeyNavigation");
		GetIsNeedKeyNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsNeedKeyNavigation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsNeedKeyNavigation_ReturnValue_PropertyAddress, GetIsNeedKeyNavigation_FunctionAddress, "ReturnValue");
		GetIsNeedKeyNavigation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsNeedKeyNavigation_FunctionAddress, "ReturnValue");
		GetIsNeedKeyNavigation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsNeedKeyNavigation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsNeedKeyNavigation_IsValid = GetIsNeedKeyNavigation_FunctionAddress != IntPtr.Zero && GetIsNeedKeyNavigation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetIsNeedKeyNavigation", GetIsNeedKeyNavigation_IsValid);
		GetIsNeedAnalogNavigation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsNeedAnalogNavigation");
		GetIsNeedAnalogNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsNeedAnalogNavigation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsNeedAnalogNavigation_ReturnValue_PropertyAddress, GetIsNeedAnalogNavigation_FunctionAddress, "ReturnValue");
		GetIsNeedAnalogNavigation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsNeedAnalogNavigation_FunctionAddress, "ReturnValue");
		GetIsNeedAnalogNavigation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsNeedAnalogNavigation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsNeedAnalogNavigation_IsValid = GetIsNeedAnalogNavigation_FunctionAddress != IntPtr.Zero && GetIsNeedAnalogNavigation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:GetIsNeedAnalogNavigation", GetIsNeedAnalogNavigation_IsValid);
		ClearNavigationKeyByNavigation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearNavigationKeyByNavigation");
		ClearNavigationKeyByNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearNavigationKeyByNavigation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearNavigationKeyByNavigation_TargetNavigation_PropertyAddress, ClearNavigationKeyByNavigation_FunctionAddress, "TargetNavigation");
		ClearNavigationKeyByNavigation_TargetNavigation_Offset = NativeReflectionCached.GetPropertyOffset(ClearNavigationKeyByNavigation_FunctionAddress, "TargetNavigation");
		ClearNavigationKeyByNavigation_TargetNavigation_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearNavigationKeyByNavigation_FunctionAddress, "TargetNavigation", Classes.FEnumProperty);
		ClearNavigationKeyByNavigation_IsValid = ClearNavigationKeyByNavigation_FunctionAddress != IntPtr.Zero && ClearNavigationKeyByNavigation_TargetNavigation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearNavigationKeyByNavigation", ClearNavigationKeyByNavigation_IsValid);
		ClearNavigationKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearNavigationKey");
		ClearNavigationKey_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearNavigationKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearNavigationKey_KeyName_PropertyAddress, ClearNavigationKey_FunctionAddress, "KeyName");
		ClearNavigationKey_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(ClearNavigationKey_FunctionAddress, "KeyName");
		ClearNavigationKey_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearNavigationKey_FunctionAddress, "KeyName", Classes.FNameProperty);
		ClearNavigationKey_IsValid = ClearNavigationKey_FunctionAddress != IntPtr.Zero && ClearNavigationKey_KeyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearNavigationKey", ClearNavigationKey_IsValid);
		ClearNavigationActionKeyByAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearNavigationActionKeyByAction");
		ClearNavigationActionKeyByAction_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearNavigationActionKeyByAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearNavigationActionKeyByAction_TargetNavigationAction_PropertyAddress, ClearNavigationActionKeyByAction_FunctionAddress, "TargetNavigationAction");
		ClearNavigationActionKeyByAction_TargetNavigationAction_Offset = NativeReflectionCached.GetPropertyOffset(ClearNavigationActionKeyByAction_FunctionAddress, "TargetNavigationAction");
		ClearNavigationActionKeyByAction_TargetNavigationAction_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearNavigationActionKeyByAction_FunctionAddress, "TargetNavigationAction", Classes.FEnumProperty);
		ClearNavigationActionKeyByAction_IsValid = ClearNavigationActionKeyByAction_FunctionAddress != IntPtr.Zero && ClearNavigationActionKeyByAction_TargetNavigationAction_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearNavigationActionKeyByAction", ClearNavigationActionKeyByAction_IsValid);
		ClearNavigationActionKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearNavigationActionKey");
		ClearNavigationActionKey_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearNavigationActionKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearNavigationActionKey_KeyName_PropertyAddress, ClearNavigationActionKey_FunctionAddress, "KeyName");
		ClearNavigationActionKey_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(ClearNavigationActionKey_FunctionAddress, "KeyName");
		ClearNavigationActionKey_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearNavigationActionKey_FunctionAddress, "KeyName", Classes.FNameProperty);
		ClearNavigationActionKey_IsValid = ClearNavigationActionKey_FunctionAddress != IntPtr.Zero && ClearNavigationActionKey_KeyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearNavigationActionKey", ClearNavigationActionKey_IsValid);
		ClearAllNavigationKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearAllNavigationKey");
		ClearAllNavigationKey_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAllNavigationKey_FunctionAddress);
		ClearAllNavigationKey_IsValid = ClearAllNavigationKey_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearAllNavigationKey", ClearAllNavigationKey_IsValid);
		ClearAllNavigationActionKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearAllNavigationActionKey");
		ClearAllNavigationActionKey_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAllNavigationActionKey_FunctionAddress);
		ClearAllNavigationActionKey_IsValid = ClearAllNavigationActionKey_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:ClearAllNavigationActionKey", ClearAllNavigationActionKey_IsValid);
		BlockConflictNavigation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BlockConflictNavigation");
		BlockConflictNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlockConflictNavigation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BlockConflictNavigation_ConflictNavigationType_PropertyAddress, BlockConflictNavigation_FunctionAddress, "ConflictNavigationType");
		BlockConflictNavigation_ConflictNavigationType_Offset = NativeReflectionCached.GetPropertyOffset(BlockConflictNavigation_FunctionAddress, "ConflictNavigationType");
		BlockConflictNavigation_ConflictNavigationType_IsValid = NativeReflectionCached.ValidatePropertyClass(BlockConflictNavigation_FunctionAddress, "ConflictNavigationType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref BlockConflictNavigation_bBlock_PropertyAddress, BlockConflictNavigation_FunctionAddress, "bBlock");
		BlockConflictNavigation_bBlock_Offset = NativeReflectionCached.GetPropertyOffset(BlockConflictNavigation_FunctionAddress, "bBlock");
		BlockConflictNavigation_bBlock_IsValid = NativeReflectionCached.ValidatePropertyClass(BlockConflictNavigation_FunctionAddress, "bBlock", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BlockConflictNavigation_NotBlockNavigations_PropertyAddress, BlockConflictNavigation_FunctionAddress, "NotBlockNavigations");
		BlockConflictNavigation_NotBlockNavigations_Offset = NativeReflectionCached.GetPropertyOffset(BlockConflictNavigation_FunctionAddress, "NotBlockNavigations");
		BlockConflictNavigation_NotBlockNavigations_IsValid = NativeReflectionCached.ValidatePropertyClass(BlockConflictNavigation_FunctionAddress, "NotBlockNavigations", Classes.FArrayProperty);
		BlockConflictNavigation_IsValid = BlockConflictNavigation_FunctionAddress != IntPtr.Zero && BlockConflictNavigation_ConflictNavigationType_IsValid && BlockConflictNavigation_bBlock_IsValid && BlockConflictNavigation_NotBlockNavigations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:BlockConflictNavigation", BlockConflictNavigation_IsValid);
		AddNavigationKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddNavigationKey");
		AddNavigationKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNavigationKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNavigationKey_TargetNavigation_PropertyAddress, AddNavigationKey_FunctionAddress, "TargetNavigation");
		AddNavigationKey_TargetNavigation_Offset = NativeReflectionCached.GetPropertyOffset(AddNavigationKey_FunctionAddress, "TargetNavigation");
		AddNavigationKey_TargetNavigation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNavigationKey_FunctionAddress, "TargetNavigation", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNavigationKey_KeyName_PropertyAddress, AddNavigationKey_FunctionAddress, "KeyName");
		AddNavigationKey_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(AddNavigationKey_FunctionAddress, "KeyName");
		AddNavigationKey_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNavigationKey_FunctionAddress, "KeyName", Classes.FNameProperty);
		AddNavigationKey_IsValid = AddNavigationKey_FunctionAddress != IntPtr.Zero && AddNavigationKey_TargetNavigation_IsValid && AddNavigationKey_KeyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:AddNavigationKey", AddNavigationKey_IsValid);
		AddNavigationActionKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddNavigationActionKey");
		AddNavigationActionKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNavigationActionKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNavigationActionKey_TargetNavigationAction_PropertyAddress, AddNavigationActionKey_FunctionAddress, "TargetNavigationAction");
		AddNavigationActionKey_TargetNavigationAction_Offset = NativeReflectionCached.GetPropertyOffset(AddNavigationActionKey_FunctionAddress, "TargetNavigationAction");
		AddNavigationActionKey_TargetNavigationAction_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNavigationActionKey_FunctionAddress, "TargetNavigationAction", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNavigationActionKey_KeyName_PropertyAddress, AddNavigationActionKey_FunctionAddress, "KeyName");
		AddNavigationActionKey_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(AddNavigationActionKey_FunctionAddress, "KeyName");
		AddNavigationActionKey_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNavigationActionKey_FunctionAddress, "KeyName", Classes.FNameProperty);
		AddNavigationActionKey_IsValid = AddNavigationActionKey_FunctionAddress != IntPtr.Zero && AddNavigationActionKey_TargetNavigationAction_IsValid && AddNavigationActionKey_KeyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UINavigationFuncLib:AddNavigationActionKey", AddNavigationActionKey_IsValid);
	}
}
