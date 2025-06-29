using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.RigVM;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[Abstract]
[UClass(Flags = (ClassFlags)818942113uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/ControlRig.ControlRig", "ControlRig", UnrealModuleType.EnginePlugin)]
public class UControlRig : UObject, INodeMappingProviderInterface, IInterface, IInterface_AssetUserData
{
	private static IntPtr classAddress;

	private static bool SupportsEvent_IsValid;

	private static IntPtr SupportsEvent_FunctionAddress;

	private static int SupportsEvent_ParamsSize;

	private static bool SupportsEvent_InEventName_IsValid;

	private static FFieldAddress SupportsEvent_InEventName_PropertyAddress;

	private static int SupportsEvent_InEventName_Offset;

	private static bool SupportsEvent_ReturnValue_IsValid;

	private static FFieldAddress SupportsEvent_ReturnValue_PropertyAddress;

	private static int SupportsEvent_ReturnValue_Offset;

	private static bool SetVariableFromString_IsValid;

	private static IntPtr SetVariableFromString_FunctionAddress;

	private static int SetVariableFromString_ParamsSize;

	private static bool SetVariableFromString_InVariableName_IsValid;

	private static FFieldAddress SetVariableFromString_InVariableName_PropertyAddress;

	private static int SetVariableFromString_InVariableName_Offset;

	private static bool SetVariableFromString_InValue_IsValid;

	private static FFieldAddress SetVariableFromString_InValue_PropertyAddress;

	private static int SetVariableFromString_InValue_Offset;

	private static bool SetVariableFromString_ReturnValue_IsValid;

	private static FFieldAddress SetVariableFromString_ReturnValue_PropertyAddress;

	private static int SetVariableFromString_ReturnValue_Offset;

	private static bool SetInteractionRigClass_IsValid;

	private static IntPtr SetInteractionRigClass_FunctionAddress;

	private static int SetInteractionRigClass_ParamsSize;

	private static bool SetInteractionRigClass_InInteractionRigClass_IsValid;

	private static FFieldAddress SetInteractionRigClass_InInteractionRigClass_PropertyAddress;

	private static int SetInteractionRigClass_InInteractionRigClass_Offset;

	private static bool SetInteractionRig_IsValid;

	private static IntPtr SetInteractionRig_FunctionAddress;

	private static int SetInteractionRig_ParamsSize;

	private static bool SetInteractionRig_InInteractionRig_IsValid;

	private static FFieldAddress SetInteractionRig_InInteractionRig_PropertyAddress;

	private static int SetInteractionRig_InInteractionRig_Offset;

	private static bool SetFramesPerSecond_IsValid;

	private static IntPtr SetFramesPerSecond_FunctionAddress;

	private static int SetFramesPerSecond_ParamsSize;

	private static bool SetFramesPerSecond_InFramesPerSecond_IsValid;

	private static FFieldAddress SetFramesPerSecond_InFramesPerSecond_PropertyAddress;

	private static int SetFramesPerSecond_InFramesPerSecond_Offset;

	private static bool SetDeltaTime_IsValid;

	private static IntPtr SetDeltaTime_FunctionAddress;

	private static int SetDeltaTime_ParamsSize;

	private static bool SetDeltaTime_InDeltaTime_IsValid;

	private static FFieldAddress SetDeltaTime_InDeltaTime_PropertyAddress;

	private static int SetDeltaTime_InDeltaTime_Offset;

	private static bool SetAbsoluteTime_IsValid;

	private static IntPtr SetAbsoluteTime_FunctionAddress;

	private static int SetAbsoluteTime_ParamsSize;

	private static bool SetAbsoluteTime_InAbsoluteTime_IsValid;

	private static FFieldAddress SetAbsoluteTime_InAbsoluteTime_PropertyAddress;

	private static int SetAbsoluteTime_InAbsoluteTime_Offset;

	private static bool SetAbsoluteTime_InSetDeltaTimeZero_IsValid;

	private static FFieldAddress SetAbsoluteTime_InSetDeltaTimeZero_PropertyAddress;

	private static int SetAbsoluteTime_InSetDeltaTimeZero_Offset;

	private static bool SetAbsoluteAndDeltaTime_IsValid;

	private static IntPtr SetAbsoluteAndDeltaTime_FunctionAddress;

	private static int SetAbsoluteAndDeltaTime_ParamsSize;

	private static bool SetAbsoluteAndDeltaTime_InAbsoluteTime_IsValid;

	private static FFieldAddress SetAbsoluteAndDeltaTime_InAbsoluteTime_PropertyAddress;

	private static int SetAbsoluteAndDeltaTime_InAbsoluteTime_Offset;

	private static bool SetAbsoluteAndDeltaTime_InDeltaTime_IsValid;

	private static FFieldAddress SetAbsoluteAndDeltaTime_InDeltaTime_PropertyAddress;

	private static int SetAbsoluteAndDeltaTime_InDeltaTime_Offset;

	private static bool SelectControl_IsValid;

	private static IntPtr SelectControl_FunctionAddress;

	private static int SelectControl_ParamsSize;

	private static bool SelectControl_InControlName_IsValid;

	private static FFieldAddress SelectControl_InControlName_PropertyAddress;

	private static int SelectControl_InControlName_Offset;

	private static bool SelectControl_bSelect_IsValid;

	private static FFieldAddress SelectControl_bSelect_PropertyAddress;

	private static int SelectControl_bSelect_Offset;

	private static bool RequestSetup_IsValid;

	private static IntPtr RequestSetup_FunctionAddress;

	private static int RequestSetup_ParamsSize;

	private static bool RequestInit_IsValid;

	private static IntPtr RequestInit_FunctionAddress;

	private static int RequestInit_ParamsSize;

	private static bool IsControlSelected_IsValid;

	private static IntPtr IsControlSelected_FunctionAddress;

	private static int IsControlSelected_ParamsSize;

	private static bool IsControlSelected_InControlName_IsValid;

	private static FFieldAddress IsControlSelected_InControlName_PropertyAddress;

	private static int IsControlSelected_InControlName_Offset;

	private static bool IsControlSelected_ReturnValue_IsValid;

	private static FFieldAddress IsControlSelected_ReturnValue_PropertyAddress;

	private static int IsControlSelected_ReturnValue_Offset;

	private static bool GetVM_IsValid;

	private static IntPtr GetVM_FunctionAddress;

	private static int GetVM_ParamsSize;

	private static bool GetVM_ReturnValue_IsValid;

	private static FFieldAddress GetVM_ReturnValue_PropertyAddress;

	private static int GetVM_ReturnValue_Offset;

	private static bool GetVariableType_IsValid;

	private static IntPtr GetVariableType_FunctionAddress;

	private static int GetVariableType_ParamsSize;

	private static bool GetVariableType_InVariableName_IsValid;

	private static FFieldAddress GetVariableType_InVariableName_PropertyAddress;

	private static int GetVariableType_InVariableName_Offset;

	private static bool GetVariableType_ReturnValue_IsValid;

	private static FFieldAddress GetVariableType_ReturnValue_PropertyAddress;

	private static int GetVariableType_ReturnValue_Offset;

	private static bool GetVariableAsString_IsValid;

	private static IntPtr GetVariableAsString_FunctionAddress;

	private static int GetVariableAsString_ParamsSize;

	private static bool GetVariableAsString_InVariableName_IsValid;

	private static FFieldAddress GetVariableAsString_InVariableName_PropertyAddress;

	private static int GetVariableAsString_InVariableName_Offset;

	private static bool GetVariableAsString_ReturnValue_IsValid;

	private static FFieldAddress GetVariableAsString_ReturnValue_PropertyAddress;

	private static int GetVariableAsString_ReturnValue_Offset;

	private static bool GetSupportedEvents_IsValid;

	private static IntPtr GetSupportedEvents_FunctionAddress;

	private static int GetSupportedEvents_ParamsSize;

	private static bool GetSupportedEvents_ReturnValue_IsValid;

	private static FFieldAddress GetSupportedEvents_ReturnValue_PropertyAddress;

	private static int GetSupportedEvents_ReturnValue_Offset;

	private static bool GetScriptAccessibleVariables_IsValid;

	private static IntPtr GetScriptAccessibleVariables_FunctionAddress;

	private static int GetScriptAccessibleVariables_ParamsSize;

	private static bool GetScriptAccessibleVariables_ReturnValue_IsValid;

	private static FFieldAddress GetScriptAccessibleVariables_ReturnValue_PropertyAddress;

	private static int GetScriptAccessibleVariables_ReturnValue_Offset;

	private static bool GetInteractionRigClass_IsValid;

	private static IntPtr GetInteractionRigClass_FunctionAddress;

	private static int GetInteractionRigClass_ParamsSize;

	private static bool GetInteractionRigClass_ReturnValue_IsValid;

	private static FFieldAddress GetInteractionRigClass_ReturnValue_PropertyAddress;

	private static int GetInteractionRigClass_ReturnValue_Offset;

	private static bool GetInteractionRig_IsValid;

	private static IntPtr GetInteractionRig_FunctionAddress;

	private static int GetInteractionRig_ParamsSize;

	private static bool GetInteractionRig_ReturnValue_IsValid;

	private static FFieldAddress GetInteractionRig_ReturnValue_PropertyAddress;

	private static int GetInteractionRig_ReturnValue_Offset;

	private static bool GetHierarchy_IsValid;

	private static IntPtr GetHierarchy_FunctionAddress;

	private static int GetHierarchy_ParamsSize;

	private static bool GetHierarchy_ReturnValue_IsValid;

	private static FFieldAddress GetHierarchy_ReturnValue_PropertyAddress;

	private static int GetHierarchy_ReturnValue_Offset;

	private static bool GetCurrentFramesPerSecond_IsValid;

	private static IntPtr GetCurrentFramesPerSecond_FunctionAddress;

	private static int GetCurrentFramesPerSecond_ParamsSize;

	private static bool GetCurrentFramesPerSecond_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentFramesPerSecond_ReturnValue_PropertyAddress;

	private static int GetCurrentFramesPerSecond_ReturnValue_Offset;

	private static bool GetAbsoluteTime_IsValid;

	private static IntPtr GetAbsoluteTime_FunctionAddress;

	private static int GetAbsoluteTime_ParamsSize;

	private static bool GetAbsoluteTime_ReturnValue_IsValid;

	private static FFieldAddress GetAbsoluteTime_ReturnValue_PropertyAddress;

	private static int GetAbsoluteTime_ReturnValue_Offset;

	private static bool FindControlRigs_IsValid;

	private static IntPtr FindControlRigs_FunctionAddress;

	private static int FindControlRigs_ParamsSize;

	private static bool FindControlRigs_Outer_IsValid;

	private static FFieldAddress FindControlRigs_Outer_PropertyAddress;

	private static int FindControlRigs_Outer_Offset;

	private static bool FindControlRigs_OptionalClass_IsValid;

	private static FFieldAddress FindControlRigs_OptionalClass_PropertyAddress;

	private static int FindControlRigs_OptionalClass_Offset;

	private static bool FindControlRigs_ReturnValue_IsValid;

	private static FFieldAddress FindControlRigs_ReturnValue_PropertyAddress;

	private static int FindControlRigs_ReturnValue_Offset;

	private static bool Execute_IsValid;

	private static IntPtr Execute_FunctionAddress;

	private static int Execute_ParamsSize;

	private static bool Execute_State_IsValid;

	private static FFieldAddress Execute_State_PropertyAddress;

	private static int Execute_State_Offset;

	private static bool Execute_InEventName_IsValid;

	private static FFieldAddress Execute_InEventName_PropertyAddress;

	private static int Execute_InEventName_Offset;

	private static bool CurrentControlSelection_IsValid;

	private static IntPtr CurrentControlSelection_FunctionAddress;

	private static int CurrentControlSelection_ParamsSize;

	private static bool CurrentControlSelection_ReturnValue_IsValid;

	private static FFieldAddress CurrentControlSelection_ReturnValue_PropertyAddress;

	private static int CurrentControlSelection_ReturnValue_Offset;

	private static bool ClearControlSelection_IsValid;

	private static IntPtr ClearControlSelection_FunctionAddress;

	private static int ClearControlSelection_ParamsSize;

	private static bool ClearControlSelection_ReturnValue_IsValid;

	private static FFieldAddress ClearControlSelection_ReturnValue_PropertyAddress;

	private static int ClearControlSelection_ReturnValue_Offset;

	private static bool CanExecute_IsValid;

	private static IntPtr CanExecute_FunctionAddress;

	private static int CanExecute_ParamsSize;

	private static bool CanExecute_ReturnValue_IsValid;

	private static FFieldAddress CanExecute_ReturnValue_PropertyAddress;

	private static int CanExecute_ReturnValue_Offset;

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/ControlRig.ControlRig:SupportsEvent")]
	public unsafe bool SupportsEvent(FName InEventName)
	{
		CheckDestroyed();
		if (!SupportsEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:SupportsEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SupportsEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SupportsEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SupportsEvent_InEventName_Offset), 0, SupportsEvent_InEventName_PropertyAddress.Address, InEventName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SupportsEvent_FunctionAddress, intPtr, SupportsEvent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SupportsEvent_ReturnValue_Offset), 0, SupportsEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/ControlRig.ControlRig:SetVariableFromString")]
	public unsafe bool SetVariableFromString(FName InVariableName, string InValue)
	{
		CheckDestroyed();
		if (!SetVariableFromString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:SetVariableFromString");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVariableFromString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVariableFromString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVariableFromString_InVariableName_Offset), 0, SetVariableFromString_InVariableName_PropertyAddress.Address, InVariableName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVariableFromString_InValue_Offset), 0, SetVariableFromString_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVariableFromString_FunctionAddress, intPtr, SetVariableFromString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetVariableFromString_InValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetVariableFromString_ReturnValue_Offset), 0, SetVariableFromString_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRig:SetInteractionRigClass")]
	public unsafe void SetInteractionRigClass(TSubclassOf<UControlRig> InInteractionRigClass)
	{
		CheckDestroyed();
		if (!SetInteractionRigClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:SetInteractionRigClass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInteractionRigClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInteractionRigClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UControlRig>.ToNative(IntPtr.Add(intPtr, SetInteractionRigClass_InInteractionRigClass_Offset), 0, SetInteractionRigClass_InInteractionRigClass_PropertyAddress.Address, InInteractionRigClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInteractionRigClass_FunctionAddress, intPtr, SetInteractionRigClass_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRig:SetInteractionRig")]
	public unsafe void SetInteractionRig(UControlRig InInteractionRig)
	{
		CheckDestroyed();
		if (!SetInteractionRig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:SetInteractionRig");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInteractionRig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInteractionRig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRig>.ToNative(IntPtr.Add(intPtr, SetInteractionRig_InInteractionRig_Offset), 0, SetInteractionRig_InInteractionRig_PropertyAddress.Address, InInteractionRig);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInteractionRig_FunctionAddress, intPtr, SetInteractionRig_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRig:SetFramesPerSecond")]
	public unsafe void SetFramesPerSecond(float InFramesPerSecond)
	{
		CheckDestroyed();
		if (!SetFramesPerSecond_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:SetFramesPerSecond");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFramesPerSecond_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFramesPerSecond_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFramesPerSecond_InFramesPerSecond_Offset), 0, SetFramesPerSecond_InFramesPerSecond_PropertyAddress.Address, InFramesPerSecond);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFramesPerSecond_FunctionAddress, intPtr, SetFramesPerSecond_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRig:SetDeltaTime")]
	public unsafe void SetDeltaTime(float InDeltaTime)
	{
		CheckDestroyed();
		if (!SetDeltaTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:SetDeltaTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDeltaTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDeltaTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDeltaTime_InDeltaTime_Offset), 0, SetDeltaTime_InDeltaTime_PropertyAddress.Address, InDeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDeltaTime_FunctionAddress, intPtr, SetDeltaTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRig:SetAbsoluteTime")]
	public unsafe void SetAbsoluteTime(float InAbsoluteTime, bool InSetDeltaTimeZero = false)
	{
		CheckDestroyed();
		if (!SetAbsoluteTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:SetAbsoluteTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAbsoluteTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAbsoluteTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAbsoluteTime_InAbsoluteTime_Offset), 0, SetAbsoluteTime_InAbsoluteTime_PropertyAddress.Address, InAbsoluteTime);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAbsoluteTime_InSetDeltaTimeZero_Offset), 0, SetAbsoluteTime_InSetDeltaTimeZero_PropertyAddress.Address, InSetDeltaTimeZero);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAbsoluteTime_FunctionAddress, intPtr, SetAbsoluteTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRig:SetAbsoluteAndDeltaTime")]
	public unsafe void SetAbsoluteAndDeltaTime(float InAbsoluteTime, float InDeltaTime)
	{
		CheckDestroyed();
		if (!SetAbsoluteAndDeltaTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:SetAbsoluteAndDeltaTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAbsoluteAndDeltaTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAbsoluteAndDeltaTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAbsoluteAndDeltaTime_InAbsoluteTime_Offset), 0, SetAbsoluteAndDeltaTime_InAbsoluteTime_PropertyAddress.Address, InAbsoluteTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAbsoluteAndDeltaTime_InDeltaTime_Offset), 0, SetAbsoluteAndDeltaTime_InDeltaTime_PropertyAddress.Address, InDeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAbsoluteAndDeltaTime_FunctionAddress, intPtr, SetAbsoluteAndDeltaTime_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/ControlRig.ControlRig:SelectControl")]
	public unsafe void SelectControl(FName InControlName, bool bSelect = true)
	{
		CheckDestroyed();
		if (!SelectControl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:SelectControl");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectControl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectControl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SelectControl_InControlName_Offset), 0, SelectControl_InControlName_PropertyAddress.Address, InControlName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectControl_bSelect_Offset), 0, SelectControl_bSelect_PropertyAddress.Address, bSelect);
		NativeReflection.InvokeFunctionOptimized(base.Address, SelectControl_FunctionAddress, intPtr, SelectControl_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRig:RequestSetup")]
	public unsafe void RequestSetup()
	{
		CheckDestroyed();
		if (!RequestSetup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:RequestSetup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestSetup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestSetup_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestSetup_FunctionAddress, argsSize: RequestSetup_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRig:RequestInit")]
	public unsafe void RequestInit()
	{
		CheckDestroyed();
		if (!RequestInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:RequestInit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestInit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestInit_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RequestInit_FunctionAddress, argsSize: RequestInit_ParamsSize);
	}

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/ControlRig.ControlRig:IsControlSelected")]
	public unsafe bool IsControlSelected(FName InControlName)
	{
		CheckDestroyed();
		if (!IsControlSelected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:IsControlSelected");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsControlSelected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsControlSelected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsControlSelected_InControlName_Offset), 0, IsControlSelected_InControlName_PropertyAddress.Address, InControlName);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsControlSelected_FunctionAddress, intPtr, IsControlSelected_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsControlSelected_ReturnValue_Offset), 0, IsControlSelected_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/ControlRig.ControlRig:GetVM")]
	public unsafe URigVM GetVM()
	{
		CheckDestroyed();
		if (!GetVM_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:GetVM");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVM_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVM_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVM_FunctionAddress, intPtr, GetVM_ParamsSize);
		return UObjectMarshaler<URigVM>.FromNative(IntPtr.Add(intPtr, GetVM_ReturnValue_Offset), 0, GetVM_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/ControlRig.ControlRig:GetVariableType")]
	public unsafe FName GetVariableType(FName InVariableName)
	{
		CheckDestroyed();
		if (!GetVariableType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:GetVariableType");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVariableType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVariableType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVariableType_InVariableName_Offset), 0, GetVariableType_InVariableName_PropertyAddress.Address, InVariableName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVariableType_FunctionAddress, intPtr, GetVariableType_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetVariableType_ReturnValue_Offset), 0, GetVariableType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/ControlRig.ControlRig:GetVariableAsString")]
	public unsafe string GetVariableAsString(FName InVariableName)
	{
		CheckDestroyed();
		if (!GetVariableAsString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:GetVariableAsString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVariableAsString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVariableAsString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVariableAsString_InVariableName_Offset), 0, GetVariableAsString_InVariableName_PropertyAddress.Address, InVariableName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVariableAsString_FunctionAddress, intPtr, GetVariableAsString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetVariableAsString_ReturnValue_Offset), 0, GetVariableAsString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetVariableAsString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.ControlRig:GetSupportedEvents")]
	public unsafe List<FName> GetSupportedEvents()
	{
		CheckDestroyed();
		if (!GetSupportedEvents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:GetSupportedEvents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSupportedEvents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSupportedEvents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSupportedEvents_FunctionAddress, intPtr, GetSupportedEvents_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetSupportedEvents_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSupportedEvents_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSupportedEvents_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.ControlRig:GetScriptAccessibleVariables")]
	public unsafe List<FName> GetScriptAccessibleVariables()
	{
		CheckDestroyed();
		if (!GetScriptAccessibleVariables_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:GetScriptAccessibleVariables");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScriptAccessibleVariables_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScriptAccessibleVariables_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScriptAccessibleVariables_FunctionAddress, intPtr, GetScriptAccessibleVariables_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetScriptAccessibleVariables_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetScriptAccessibleVariables_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetScriptAccessibleVariables_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.ControlRig:GetInteractionRigClass")]
	public unsafe TSubclassOf<UControlRig> GetInteractionRigClass()
	{
		CheckDestroyed();
		if (!GetInteractionRigClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:GetInteractionRigClass");
			return default(TSubclassOf<UControlRig>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInteractionRigClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInteractionRigClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInteractionRigClass_FunctionAddress, intPtr, GetInteractionRigClass_ParamsSize);
		return TSubclassOfMarshaler<UControlRig>.FromNative(IntPtr.Add(intPtr, GetInteractionRigClass_ReturnValue_Offset), 0, GetInteractionRigClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.ControlRig:GetInteractionRig")]
	public unsafe UControlRig GetInteractionRig()
	{
		CheckDestroyed();
		if (!GetInteractionRig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:GetInteractionRig");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInteractionRig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInteractionRig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInteractionRig_FunctionAddress, intPtr, GetInteractionRig_ParamsSize);
		return UObjectMarshaler<UControlRig>.FromNative(IntPtr.Add(intPtr, GetInteractionRig_ReturnValue_Offset), 0, GetInteractionRig_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/ControlRig.ControlRig:GetHierarchy")]
	public unsafe URigHierarchy GetHierarchy()
	{
		CheckDestroyed();
		if (!GetHierarchy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:GetHierarchy");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHierarchy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHierarchy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHierarchy_FunctionAddress, intPtr, GetHierarchy_ParamsSize);
		return UObjectMarshaler<URigHierarchy>.FromNative(IntPtr.Add(intPtr, GetHierarchy_ReturnValue_Offset), 0, GetHierarchy_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.ControlRig:GetCurrentFramesPerSecond")]
	public unsafe float GetCurrentFramesPerSecond()
	{
		CheckDestroyed();
		if (!GetCurrentFramesPerSecond_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:GetCurrentFramesPerSecond");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentFramesPerSecond_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentFramesPerSecond_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentFramesPerSecond_FunctionAddress, intPtr, GetCurrentFramesPerSecond_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurrentFramesPerSecond_ReturnValue_Offset), 0, GetCurrentFramesPerSecond_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.ControlRig:GetAbsoluteTime")]
	public unsafe float GetAbsoluteTime()
	{
		CheckDestroyed();
		if (!GetAbsoluteTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:GetAbsoluteTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAbsoluteTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAbsoluteTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAbsoluteTime_FunctionAddress, intPtr, GetAbsoluteTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAbsoluteTime_ReturnValue_Offset), 0, GetAbsoluteTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRig.ControlRig:FindControlRigs")]
	public unsafe static List<UControlRig> FindControlRigs(UObject Outer, TSubclassOf<UControlRig> OptionalClass)
	{
		if (!FindControlRigs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:FindControlRigs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindControlRigs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindControlRigs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, FindControlRigs_Outer_Offset), 0, FindControlRigs_Outer_PropertyAddress.Address, Outer);
		TSubclassOfMarshaler<UControlRig>.ToNative(IntPtr.Add(intPtr, FindControlRigs_OptionalClass_Offset), 0, FindControlRigs_OptionalClass_PropertyAddress.Address, OptionalClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindControlRigs_FunctionAddress, intPtr, FindControlRigs_ParamsSize);
		List<UControlRig> result = new TArrayCopyMarshaler<UControlRig>(1, FindControlRigs_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UControlRig, UObjectMarshaler<UControlRig>>.FromNative, CachedMarshalingDelegates<UControlRig, UObjectMarshaler<UControlRig>>.ToNative).FromNative(IntPtr.Add(intPtr, FindControlRigs_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FindControlRigs_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/ControlRig.ControlRig:Execute")]
	public unsafe void Execute(EControlRigState State, FName InEventName)
	{
		CheckDestroyed();
		if (!Execute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:Execute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Execute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Execute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EControlRigState>.ToNative(IntPtr.Add(intPtr, Execute_State_Offset), 0, Execute_State_PropertyAddress.Address, State);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Execute_InEventName_Offset), 0, Execute_InEventName_PropertyAddress.Address, InEventName);
		NativeReflection.InvokeFunctionOptimized(base.Address, Execute_FunctionAddress, intPtr, Execute_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/ControlRig.ControlRig:CurrentControlSelection")]
	public unsafe List<FName> CurrentControlSelection()
	{
		CheckDestroyed();
		if (!CurrentControlSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:CurrentControlSelection");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CurrentControlSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CurrentControlSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CurrentControlSelection_FunctionAddress, intPtr, CurrentControlSelection_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, CurrentControlSelection_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, CurrentControlSelection_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CurrentControlSelection_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/ControlRig.ControlRig:ClearControlSelection")]
	public unsafe bool ClearControlSelection()
	{
		CheckDestroyed();
		if (!ClearControlSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:ClearControlSelection");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearControlSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearControlSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClearControlSelection_FunctionAddress, intPtr, ClearControlSelection_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ClearControlSelection_ReturnValue_Offset), 0, ClearControlSelection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/ControlRig.ControlRig:CanExecute")]
	public unsafe bool CanExecute()
	{
		CheckDestroyed();
		if (!CanExecute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRig:CanExecute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanExecute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanExecute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanExecute_FunctionAddress, intPtr, CanExecute_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanExecute_ReturnValue_Offset), 0, CanExecute_ReturnValue_PropertyAddress.Address);
	}

	static UControlRig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UControlRig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UControlRig));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/ControlRig.ControlRig");
		SupportsEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SupportsEvent");
		SupportsEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(SupportsEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SupportsEvent_InEventName_PropertyAddress, SupportsEvent_FunctionAddress, "InEventName");
		SupportsEvent_InEventName_Offset = NativeReflectionCached.GetPropertyOffset(SupportsEvent_FunctionAddress, "InEventName");
		SupportsEvent_InEventName_IsValid = NativeReflectionCached.ValidatePropertyClass(SupportsEvent_FunctionAddress, "InEventName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SupportsEvent_ReturnValue_PropertyAddress, SupportsEvent_FunctionAddress, "ReturnValue");
		SupportsEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SupportsEvent_FunctionAddress, "ReturnValue");
		SupportsEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SupportsEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SupportsEvent_IsValid = SupportsEvent_FunctionAddress != IntPtr.Zero && SupportsEvent_InEventName_IsValid && SupportsEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:SupportsEvent", SupportsEvent_IsValid);
		SetVariableFromString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVariableFromString");
		SetVariableFromString_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVariableFromString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVariableFromString_InVariableName_PropertyAddress, SetVariableFromString_FunctionAddress, "InVariableName");
		SetVariableFromString_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableFromString_FunctionAddress, "InVariableName");
		SetVariableFromString_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableFromString_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableFromString_InValue_PropertyAddress, SetVariableFromString_FunctionAddress, "InValue");
		SetVariableFromString_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableFromString_FunctionAddress, "InValue");
		SetVariableFromString_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableFromString_FunctionAddress, "InValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVariableFromString_ReturnValue_PropertyAddress, SetVariableFromString_FunctionAddress, "ReturnValue");
		SetVariableFromString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetVariableFromString_FunctionAddress, "ReturnValue");
		SetVariableFromString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVariableFromString_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetVariableFromString_IsValid = SetVariableFromString_FunctionAddress != IntPtr.Zero && SetVariableFromString_InVariableName_IsValid && SetVariableFromString_InValue_IsValid && SetVariableFromString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:SetVariableFromString", SetVariableFromString_IsValid);
		SetInteractionRigClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInteractionRigClass");
		SetInteractionRigClass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInteractionRigClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInteractionRigClass_InInteractionRigClass_PropertyAddress, SetInteractionRigClass_FunctionAddress, "InInteractionRigClass");
		SetInteractionRigClass_InInteractionRigClass_Offset = NativeReflectionCached.GetPropertyOffset(SetInteractionRigClass_FunctionAddress, "InInteractionRigClass");
		SetInteractionRigClass_InInteractionRigClass_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteractionRigClass_FunctionAddress, "InInteractionRigClass", Classes.FClassProperty);
		SetInteractionRigClass_IsValid = SetInteractionRigClass_FunctionAddress != IntPtr.Zero && SetInteractionRigClass_InInteractionRigClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:SetInteractionRigClass", SetInteractionRigClass_IsValid);
		SetInteractionRig_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInteractionRig");
		SetInteractionRig_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInteractionRig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInteractionRig_InInteractionRig_PropertyAddress, SetInteractionRig_FunctionAddress, "InInteractionRig");
		SetInteractionRig_InInteractionRig_Offset = NativeReflectionCached.GetPropertyOffset(SetInteractionRig_FunctionAddress, "InInteractionRig");
		SetInteractionRig_InInteractionRig_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInteractionRig_FunctionAddress, "InInteractionRig", Classes.FObjectProperty);
		SetInteractionRig_IsValid = SetInteractionRig_FunctionAddress != IntPtr.Zero && SetInteractionRig_InInteractionRig_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:SetInteractionRig", SetInteractionRig_IsValid);
		SetFramesPerSecond_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFramesPerSecond");
		SetFramesPerSecond_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFramesPerSecond_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFramesPerSecond_InFramesPerSecond_PropertyAddress, SetFramesPerSecond_FunctionAddress, "InFramesPerSecond");
		SetFramesPerSecond_InFramesPerSecond_Offset = NativeReflectionCached.GetPropertyOffset(SetFramesPerSecond_FunctionAddress, "InFramesPerSecond");
		SetFramesPerSecond_InFramesPerSecond_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFramesPerSecond_FunctionAddress, "InFramesPerSecond", Classes.FFloatProperty);
		SetFramesPerSecond_IsValid = SetFramesPerSecond_FunctionAddress != IntPtr.Zero && SetFramesPerSecond_InFramesPerSecond_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:SetFramesPerSecond", SetFramesPerSecond_IsValid);
		SetDeltaTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDeltaTime");
		SetDeltaTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDeltaTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDeltaTime_InDeltaTime_PropertyAddress, SetDeltaTime_FunctionAddress, "InDeltaTime");
		SetDeltaTime_InDeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(SetDeltaTime_FunctionAddress, "InDeltaTime");
		SetDeltaTime_InDeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDeltaTime_FunctionAddress, "InDeltaTime", Classes.FFloatProperty);
		SetDeltaTime_IsValid = SetDeltaTime_FunctionAddress != IntPtr.Zero && SetDeltaTime_InDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:SetDeltaTime", SetDeltaTime_IsValid);
		SetAbsoluteTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAbsoluteTime");
		SetAbsoluteTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAbsoluteTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAbsoluteTime_InAbsoluteTime_PropertyAddress, SetAbsoluteTime_FunctionAddress, "InAbsoluteTime");
		SetAbsoluteTime_InAbsoluteTime_Offset = NativeReflectionCached.GetPropertyOffset(SetAbsoluteTime_FunctionAddress, "InAbsoluteTime");
		SetAbsoluteTime_InAbsoluteTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAbsoluteTime_FunctionAddress, "InAbsoluteTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAbsoluteTime_InSetDeltaTimeZero_PropertyAddress, SetAbsoluteTime_FunctionAddress, "InSetDeltaTimeZero");
		SetAbsoluteTime_InSetDeltaTimeZero_Offset = NativeReflectionCached.GetPropertyOffset(SetAbsoluteTime_FunctionAddress, "InSetDeltaTimeZero");
		SetAbsoluteTime_InSetDeltaTimeZero_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAbsoluteTime_FunctionAddress, "InSetDeltaTimeZero", Classes.FBoolProperty);
		SetAbsoluteTime_IsValid = SetAbsoluteTime_FunctionAddress != IntPtr.Zero && SetAbsoluteTime_InAbsoluteTime_IsValid && SetAbsoluteTime_InSetDeltaTimeZero_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:SetAbsoluteTime", SetAbsoluteTime_IsValid);
		SetAbsoluteAndDeltaTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAbsoluteAndDeltaTime");
		SetAbsoluteAndDeltaTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAbsoluteAndDeltaTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAbsoluteAndDeltaTime_InAbsoluteTime_PropertyAddress, SetAbsoluteAndDeltaTime_FunctionAddress, "InAbsoluteTime");
		SetAbsoluteAndDeltaTime_InAbsoluteTime_Offset = NativeReflectionCached.GetPropertyOffset(SetAbsoluteAndDeltaTime_FunctionAddress, "InAbsoluteTime");
		SetAbsoluteAndDeltaTime_InAbsoluteTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAbsoluteAndDeltaTime_FunctionAddress, "InAbsoluteTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAbsoluteAndDeltaTime_InDeltaTime_PropertyAddress, SetAbsoluteAndDeltaTime_FunctionAddress, "InDeltaTime");
		SetAbsoluteAndDeltaTime_InDeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(SetAbsoluteAndDeltaTime_FunctionAddress, "InDeltaTime");
		SetAbsoluteAndDeltaTime_InDeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAbsoluteAndDeltaTime_FunctionAddress, "InDeltaTime", Classes.FFloatProperty);
		SetAbsoluteAndDeltaTime_IsValid = SetAbsoluteAndDeltaTime_FunctionAddress != IntPtr.Zero && SetAbsoluteAndDeltaTime_InAbsoluteTime_IsValid && SetAbsoluteAndDeltaTime_InDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:SetAbsoluteAndDeltaTime", SetAbsoluteAndDeltaTime_IsValid);
		SelectControl_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectControl");
		SelectControl_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectControl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectControl_InControlName_PropertyAddress, SelectControl_FunctionAddress, "InControlName");
		SelectControl_InControlName_Offset = NativeReflectionCached.GetPropertyOffset(SelectControl_FunctionAddress, "InControlName");
		SelectControl_InControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectControl_FunctionAddress, "InControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectControl_bSelect_PropertyAddress, SelectControl_FunctionAddress, "bSelect");
		SelectControl_bSelect_Offset = NativeReflectionCached.GetPropertyOffset(SelectControl_FunctionAddress, "bSelect");
		SelectControl_bSelect_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectControl_FunctionAddress, "bSelect", Classes.FBoolProperty);
		SelectControl_IsValid = SelectControl_FunctionAddress != IntPtr.Zero && SelectControl_InControlName_IsValid && SelectControl_bSelect_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:SelectControl", SelectControl_IsValid);
		RequestSetup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestSetup");
		RequestSetup_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestSetup_FunctionAddress);
		RequestSetup_IsValid = RequestSetup_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:RequestSetup", RequestSetup_IsValid);
		RequestInit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestInit");
		RequestInit_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestInit_FunctionAddress);
		RequestInit_IsValid = RequestInit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:RequestInit", RequestInit_IsValid);
		IsControlSelected_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsControlSelected");
		IsControlSelected_ParamsSize = NativeReflection.GetFunctionParamsSize(IsControlSelected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsControlSelected_InControlName_PropertyAddress, IsControlSelected_FunctionAddress, "InControlName");
		IsControlSelected_InControlName_Offset = NativeReflectionCached.GetPropertyOffset(IsControlSelected_FunctionAddress, "InControlName");
		IsControlSelected_InControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsControlSelected_FunctionAddress, "InControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsControlSelected_ReturnValue_PropertyAddress, IsControlSelected_FunctionAddress, "ReturnValue");
		IsControlSelected_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsControlSelected_FunctionAddress, "ReturnValue");
		IsControlSelected_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsControlSelected_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsControlSelected_IsValid = IsControlSelected_FunctionAddress != IntPtr.Zero && IsControlSelected_InControlName_IsValid && IsControlSelected_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:IsControlSelected", IsControlSelected_IsValid);
		GetVM_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVM");
		GetVM_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVM_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVM_ReturnValue_PropertyAddress, GetVM_FunctionAddress, "ReturnValue");
		GetVM_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVM_FunctionAddress, "ReturnValue");
		GetVM_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVM_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetVM_IsValid = GetVM_FunctionAddress != IntPtr.Zero && GetVM_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:GetVM", GetVM_IsValid);
		GetVariableType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVariableType");
		GetVariableType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVariableType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVariableType_InVariableName_PropertyAddress, GetVariableType_FunctionAddress, "InVariableName");
		GetVariableType_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(GetVariableType_FunctionAddress, "InVariableName");
		GetVariableType_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariableType_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVariableType_ReturnValue_PropertyAddress, GetVariableType_FunctionAddress, "ReturnValue");
		GetVariableType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVariableType_FunctionAddress, "ReturnValue");
		GetVariableType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariableType_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetVariableType_IsValid = GetVariableType_FunctionAddress != IntPtr.Zero && GetVariableType_InVariableName_IsValid && GetVariableType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:GetVariableType", GetVariableType_IsValid);
		GetVariableAsString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVariableAsString");
		GetVariableAsString_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVariableAsString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVariableAsString_InVariableName_PropertyAddress, GetVariableAsString_FunctionAddress, "InVariableName");
		GetVariableAsString_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(GetVariableAsString_FunctionAddress, "InVariableName");
		GetVariableAsString_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariableAsString_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVariableAsString_ReturnValue_PropertyAddress, GetVariableAsString_FunctionAddress, "ReturnValue");
		GetVariableAsString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVariableAsString_FunctionAddress, "ReturnValue");
		GetVariableAsString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariableAsString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetVariableAsString_IsValid = GetVariableAsString_FunctionAddress != IntPtr.Zero && GetVariableAsString_InVariableName_IsValid && GetVariableAsString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:GetVariableAsString", GetVariableAsString_IsValid);
		GetSupportedEvents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSupportedEvents");
		GetSupportedEvents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSupportedEvents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSupportedEvents_ReturnValue_PropertyAddress, GetSupportedEvents_FunctionAddress, "ReturnValue");
		GetSupportedEvents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSupportedEvents_FunctionAddress, "ReturnValue");
		GetSupportedEvents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSupportedEvents_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSupportedEvents_IsValid = GetSupportedEvents_FunctionAddress != IntPtr.Zero && GetSupportedEvents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:GetSupportedEvents", GetSupportedEvents_IsValid);
		GetScriptAccessibleVariables_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetScriptAccessibleVariables");
		GetScriptAccessibleVariables_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScriptAccessibleVariables_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScriptAccessibleVariables_ReturnValue_PropertyAddress, GetScriptAccessibleVariables_FunctionAddress, "ReturnValue");
		GetScriptAccessibleVariables_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScriptAccessibleVariables_FunctionAddress, "ReturnValue");
		GetScriptAccessibleVariables_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScriptAccessibleVariables_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetScriptAccessibleVariables_IsValid = GetScriptAccessibleVariables_FunctionAddress != IntPtr.Zero && GetScriptAccessibleVariables_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:GetScriptAccessibleVariables", GetScriptAccessibleVariables_IsValid);
		GetInteractionRigClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInteractionRigClass");
		GetInteractionRigClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInteractionRigClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInteractionRigClass_ReturnValue_PropertyAddress, GetInteractionRigClass_FunctionAddress, "ReturnValue");
		GetInteractionRigClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInteractionRigClass_FunctionAddress, "ReturnValue");
		GetInteractionRigClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteractionRigClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetInteractionRigClass_IsValid = GetInteractionRigClass_FunctionAddress != IntPtr.Zero && GetInteractionRigClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:GetInteractionRigClass", GetInteractionRigClass_IsValid);
		GetInteractionRig_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInteractionRig");
		GetInteractionRig_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInteractionRig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInteractionRig_ReturnValue_PropertyAddress, GetInteractionRig_FunctionAddress, "ReturnValue");
		GetInteractionRig_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInteractionRig_FunctionAddress, "ReturnValue");
		GetInteractionRig_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteractionRig_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetInteractionRig_IsValid = GetInteractionRig_FunctionAddress != IntPtr.Zero && GetInteractionRig_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:GetInteractionRig", GetInteractionRig_IsValid);
		GetHierarchy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetHierarchy");
		GetHierarchy_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHierarchy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHierarchy_ReturnValue_PropertyAddress, GetHierarchy_FunctionAddress, "ReturnValue");
		GetHierarchy_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHierarchy_FunctionAddress, "ReturnValue");
		GetHierarchy_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHierarchy_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetHierarchy_IsValid = GetHierarchy_FunctionAddress != IntPtr.Zero && GetHierarchy_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:GetHierarchy", GetHierarchy_IsValid);
		GetCurrentFramesPerSecond_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentFramesPerSecond");
		GetCurrentFramesPerSecond_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentFramesPerSecond_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentFramesPerSecond_ReturnValue_PropertyAddress, GetCurrentFramesPerSecond_FunctionAddress, "ReturnValue");
		GetCurrentFramesPerSecond_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentFramesPerSecond_FunctionAddress, "ReturnValue");
		GetCurrentFramesPerSecond_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentFramesPerSecond_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurrentFramesPerSecond_IsValid = GetCurrentFramesPerSecond_FunctionAddress != IntPtr.Zero && GetCurrentFramesPerSecond_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:GetCurrentFramesPerSecond", GetCurrentFramesPerSecond_IsValid);
		GetAbsoluteTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAbsoluteTime");
		GetAbsoluteTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAbsoluteTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAbsoluteTime_ReturnValue_PropertyAddress, GetAbsoluteTime_FunctionAddress, "ReturnValue");
		GetAbsoluteTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAbsoluteTime_FunctionAddress, "ReturnValue");
		GetAbsoluteTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAbsoluteTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAbsoluteTime_IsValid = GetAbsoluteTime_FunctionAddress != IntPtr.Zero && GetAbsoluteTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:GetAbsoluteTime", GetAbsoluteTime_IsValid);
		FindControlRigs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindControlRigs");
		FindControlRigs_ParamsSize = NativeReflection.GetFunctionParamsSize(FindControlRigs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindControlRigs_Outer_PropertyAddress, FindControlRigs_FunctionAddress, "Outer");
		FindControlRigs_Outer_Offset = NativeReflectionCached.GetPropertyOffset(FindControlRigs_FunctionAddress, "Outer");
		FindControlRigs_Outer_IsValid = NativeReflectionCached.ValidatePropertyClass(FindControlRigs_FunctionAddress, "Outer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindControlRigs_OptionalClass_PropertyAddress, FindControlRigs_FunctionAddress, "OptionalClass");
		FindControlRigs_OptionalClass_Offset = NativeReflectionCached.GetPropertyOffset(FindControlRigs_FunctionAddress, "OptionalClass");
		FindControlRigs_OptionalClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FindControlRigs_FunctionAddress, "OptionalClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindControlRigs_ReturnValue_PropertyAddress, FindControlRigs_FunctionAddress, "ReturnValue");
		FindControlRigs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindControlRigs_FunctionAddress, "ReturnValue");
		FindControlRigs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindControlRigs_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FindControlRigs_IsValid = FindControlRigs_FunctionAddress != IntPtr.Zero && FindControlRigs_Outer_IsValid && FindControlRigs_OptionalClass_IsValid && FindControlRigs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:FindControlRigs", FindControlRigs_IsValid);
		Execute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Execute");
		Execute_ParamsSize = NativeReflection.GetFunctionParamsSize(Execute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Execute_State_PropertyAddress, Execute_FunctionAddress, "State");
		Execute_State_Offset = NativeReflectionCached.GetPropertyOffset(Execute_FunctionAddress, "State");
		Execute_State_IsValid = NativeReflectionCached.ValidatePropertyClass(Execute_FunctionAddress, "State", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref Execute_InEventName_PropertyAddress, Execute_FunctionAddress, "InEventName");
		Execute_InEventName_Offset = NativeReflectionCached.GetPropertyOffset(Execute_FunctionAddress, "InEventName");
		Execute_InEventName_IsValid = NativeReflectionCached.ValidatePropertyClass(Execute_FunctionAddress, "InEventName", Classes.FNameProperty);
		Execute_IsValid = Execute_FunctionAddress != IntPtr.Zero && Execute_State_IsValid && Execute_InEventName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:Execute", Execute_IsValid);
		CurrentControlSelection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CurrentControlSelection");
		CurrentControlSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(CurrentControlSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CurrentControlSelection_ReturnValue_PropertyAddress, CurrentControlSelection_FunctionAddress, "ReturnValue");
		CurrentControlSelection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CurrentControlSelection_FunctionAddress, "ReturnValue");
		CurrentControlSelection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CurrentControlSelection_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CurrentControlSelection_IsValid = CurrentControlSelection_FunctionAddress != IntPtr.Zero && CurrentControlSelection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:CurrentControlSelection", CurrentControlSelection_IsValid);
		ClearControlSelection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearControlSelection");
		ClearControlSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearControlSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearControlSelection_ReturnValue_PropertyAddress, ClearControlSelection_FunctionAddress, "ReturnValue");
		ClearControlSelection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClearControlSelection_FunctionAddress, "ReturnValue");
		ClearControlSelection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearControlSelection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ClearControlSelection_IsValid = ClearControlSelection_FunctionAddress != IntPtr.Zero && ClearControlSelection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:ClearControlSelection", ClearControlSelection_IsValid);
		CanExecute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CanExecute");
		CanExecute_ParamsSize = NativeReflection.GetFunctionParamsSize(CanExecute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanExecute_ReturnValue_PropertyAddress, CanExecute_FunctionAddress, "ReturnValue");
		CanExecute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanExecute_FunctionAddress, "ReturnValue");
		CanExecute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanExecute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanExecute_IsValid = CanExecute_FunctionAddress != IntPtr.Zero && CanExecute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRig:CanExecute", CanExecute_IsValid);
	}
}
