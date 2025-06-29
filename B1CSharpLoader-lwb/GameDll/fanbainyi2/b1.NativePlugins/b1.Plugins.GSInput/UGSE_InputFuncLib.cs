using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GSInput.GSE_InputFuncLib", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSE_InputFuncLib : UObject
{
	private static IntPtr classAddress;

	private static bool UpdateAllInputIcon_IsValid;

	private static IntPtr UpdateAllInputIcon_FunctionAddress;

	private static int UpdateAllInputIcon_ParamsSize;

	private static bool UnRegisterInputTargetBinding_IsValid;

	private static IntPtr UnRegisterInputTargetBinding_FunctionAddress;

	private static int UnRegisterInputTargetBinding_ParamsSize;

	private static bool UnRegisterInputTargetBinding_InputTargetBindingObj_IsValid;

	private static FFieldAddress UnRegisterInputTargetBinding_InputTargetBindingObj_PropertyAddress;

	private static int UnRegisterInputTargetBinding_InputTargetBindingObj_Offset;

	private static bool UnRegisterGSInputProc_IsValid;

	private static IntPtr UnRegisterGSInputProc_FunctionAddress;

	private static int UnRegisterGSInputProc_ParamsSize;

	private static bool UnRegisterGSInputProc_WorldContext_IsValid;

	private static FFieldAddress UnRegisterGSInputProc_WorldContext_PropertyAddress;

	private static int UnRegisterGSInputProc_WorldContext_Offset;

	private static bool UnRegisterGSInputProc_Order_IsValid;

	private static FFieldAddress UnRegisterGSInputProc_Order_PropertyAddress;

	private static int UnRegisterGSInputProc_Order_Offset;

	private static bool TryToSetContextNewPriority_IsValid;

	private static IntPtr TryToSetContextNewPriority_FunctionAddress;

	private static int TryToSetContextNewPriority_ParamsSize;

	private static bool TryToSetContextNewPriority_PlayerController_IsValid;

	private static FFieldAddress TryToSetContextNewPriority_PlayerController_PropertyAddress;

	private static int TryToSetContextNewPriority_PlayerController_Offset;

	private static bool TryToSetContextNewPriority_Context_IsValid;

	private static FFieldAddress TryToSetContextNewPriority_Context_PropertyAddress;

	private static int TryToSetContextNewPriority_Context_Offset;

	private static bool TryToSetContextNewPriority_NewPriority_IsValid;

	private static FFieldAddress TryToSetContextNewPriority_NewPriority_PropertyAddress;

	private static int TryToSetContextNewPriority_NewPriority_Offset;

	private static bool TryToSetContextNewPriority_ReturnValue_IsValid;

	private static FFieldAddress TryToSetContextNewPriority_ReturnValue_PropertyAddress;

	private static int TryToSetContextNewPriority_ReturnValue_Offset;

	private static bool SetUIOnly_IsValid;

	private static IntPtr SetUIOnly_FunctionAddress;

	private static int SetUIOnly_ParamsSize;

	private static bool SetUIOnly_PlayerController_IsValid;

	private static FFieldAddress SetUIOnly_PlayerController_PropertyAddress;

	private static int SetUIOnly_PlayerController_Offset;

	private static bool SetUIOnly_bNeedMouseCapture_IsValid;

	private static FFieldAddress SetUIOnly_bNeedMouseCapture_PropertyAddress;

	private static int SetUIOnly_bNeedMouseCapture_Offset;

	private static bool SetMouseCursorPosition_IsValid;

	private static IntPtr SetMouseCursorPosition_FunctionAddress;

	private static int SetMouseCursorPosition_ParamsSize;

	private static bool SetMouseCursorPosition_Position_IsValid;

	private static FFieldAddress SetMouseCursorPosition_Position_PropertyAddress;

	private static int SetMouseCursorPosition_Position_Offset;

	private static bool SetIgnoreAllButtonKeyInput_IsValid;

	private static IntPtr SetIgnoreAllButtonKeyInput_FunctionAddress;

	private static int SetIgnoreAllButtonKeyInput_ParamsSize;

	private static bool SetIgnoreAllButtonKeyInput_WorldContext_IsValid;

	private static FFieldAddress SetIgnoreAllButtonKeyInput_WorldContext_PropertyAddress;

	private static int SetIgnoreAllButtonKeyInput_WorldContext_Offset;

	private static bool SetIgnoreAllButtonKeyInput_IsIgnore_IsValid;

	private static FFieldAddress SetIgnoreAllButtonKeyInput_IsIgnore_PropertyAddress;

	private static int SetIgnoreAllButtonKeyInput_IsIgnore_Offset;

	private static bool SetGameOnly_IsValid;

	private static IntPtr SetGameOnly_FunctionAddress;

	private static int SetGameOnly_ParamsSize;

	private static bool SetGameOnly_PlayerController_IsValid;

	private static FFieldAddress SetGameOnly_PlayerController_PropertyAddress;

	private static int SetGameOnly_PlayerController_Offset;

	private static bool SetCursorVisibility_IsValid;

	private static IntPtr SetCursorVisibility_FunctionAddress;

	private static int SetCursorVisibility_ParamsSize;

	private static bool SetCursorVisibility_bDrawCursor_IsValid;

	private static FFieldAddress SetCursorVisibility_bDrawCursor_PropertyAddress;

	private static int SetCursorVisibility_bDrawCursor_Offset;

	private static bool RequestRebuildControlMappings_IsValid;

	private static IntPtr RequestRebuildControlMappings_FunctionAddress;

	private static int RequestRebuildControlMappings_ParamsSize;

	private static bool RequestRebuildControlMappings_PlayerController_IsValid;

	private static FFieldAddress RequestRebuildControlMappings_PlayerController_PropertyAddress;

	private static int RequestRebuildControlMappings_PlayerController_Offset;

	private static bool RequestRebuildControlMappings_bForceImmediately_IsValid;

	private static FFieldAddress RequestRebuildControlMappings_bForceImmediately_PropertyAddress;

	private static int RequestRebuildControlMappings_bForceImmediately_Offset;

	private static bool RequestRebuildControlMappings_bIgnoreAllPressedKeysUntilRelease_IsValid;

	private static FFieldAddress RequestRebuildControlMappings_bIgnoreAllPressedKeysUntilRelease_PropertyAddress;

	private static int RequestRebuildControlMappings_bIgnoreAllPressedKeysUntilRelease_Offset;

	private static bool RemoveInputMappingContext_IsValid;

	private static IntPtr RemoveInputMappingContext_FunctionAddress;

	private static int RemoveInputMappingContext_ParamsSize;

	private static bool RemoveInputMappingContext_PlayerController_IsValid;

	private static FFieldAddress RemoveInputMappingContext_PlayerController_PropertyAddress;

	private static int RemoveInputMappingContext_PlayerController_Offset;

	private static bool RemoveInputMappingContext_InputMappingContext_IsValid;

	private static FFieldAddress RemoveInputMappingContext_InputMappingContext_PropertyAddress;

	private static int RemoveInputMappingContext_InputMappingContext_Offset;

	private static bool RemoveInputMappingContext_bIgnoreAllPressedKeysUntilRelease_IsValid;

	private static FFieldAddress RemoveInputMappingContext_bIgnoreAllPressedKeysUntilRelease_PropertyAddress;

	private static int RemoveInputMappingContext_bIgnoreAllPressedKeysUntilRelease_Offset;

	private static bool RemoveInputMappingContext_bForceImmediately_IsValid;

	private static FFieldAddress RemoveInputMappingContext_bForceImmediately_PropertyAddress;

	private static int RemoveInputMappingContext_bForceImmediately_Offset;

	private static bool RegisterInputTargetBinding_IsValid;

	private static IntPtr RegisterInputTargetBinding_FunctionAddress;

	private static int RegisterInputTargetBinding_ParamsSize;

	private static bool RegisterInputTargetBinding_InputTargetBindingObj_IsValid;

	private static FFieldAddress RegisterInputTargetBinding_InputTargetBindingObj_PropertyAddress;

	private static int RegisterInputTargetBinding_InputTargetBindingObj_Offset;

	private static bool RegisterGSInputProc_IsValid;

	private static IntPtr RegisterGSInputProc_FunctionAddress;

	private static int RegisterGSInputProc_ParamsSize;

	private static bool RegisterGSInputProc_WorldContext_IsValid;

	private static FFieldAddress RegisterGSInputProc_WorldContext_PropertyAddress;

	private static int RegisterGSInputProc_WorldContext_Offset;

	private static bool RegisterGSInputProc_Order_IsValid;

	private static FFieldAddress RegisterGSInputProc_Order_PropertyAddress;

	private static int RegisterGSInputProc_Order_Offset;

	private static bool QueryKeysMappedToAction_IsValid;

	private static IntPtr QueryKeysMappedToAction_FunctionAddress;

	private static int QueryKeysMappedToAction_ParamsSize;

	private static bool QueryKeysMappedToAction_PlayerController_IsValid;

	private static FFieldAddress QueryKeysMappedToAction_PlayerController_PropertyAddress;

	private static int QueryKeysMappedToAction_PlayerController_Offset;

	private static bool QueryKeysMappedToAction_Action_IsValid;

	private static FFieldAddress QueryKeysMappedToAction_Action_PropertyAddress;

	private static int QueryKeysMappedToAction_Action_Offset;

	private static bool QueryKeysMappedToAction_ReturnValue_IsValid;

	private static FFieldAddress QueryKeysMappedToAction_ReturnValue_PropertyAddress;

	private static int QueryKeysMappedToAction_ReturnValue_Offset;

	private static bool QueryKeysByInputAction_IsValid;

	private static IntPtr QueryKeysByInputAction_FunctionAddress;

	private static int QueryKeysByInputAction_ParamsSize;

	private static bool QueryKeysByInputAction_MappingContext_IsValid;

	private static FFieldAddress QueryKeysByInputAction_MappingContext_PropertyAddress;

	private static int QueryKeysByInputAction_MappingContext_Offset;

	private static bool QueryKeysByInputAction_Action_IsValid;

	private static FFieldAddress QueryKeysByInputAction_Action_PropertyAddress;

	private static int QueryKeysByInputAction_Action_Offset;

	private static bool QueryKeysByInputAction_ReturnValue_IsValid;

	private static FFieldAddress QueryKeysByInputAction_ReturnValue_PropertyAddress;

	private static int QueryKeysByInputAction_ReturnValue_Offset;

	private static bool IsConsoleActive_IsValid;

	private static IntPtr IsConsoleActive_FunctionAddress;

	private static int IsConsoleActive_ParamsSize;

	private static bool IsConsoleActive_WorldContext_IsValid;

	private static FFieldAddress IsConsoleActive_WorldContext_PropertyAddress;

	private static int IsConsoleActive_WorldContext_Offset;

	private static bool IsConsoleActive_ReturnValue_IsValid;

	private static FFieldAddress IsConsoleActive_ReturnValue_PropertyAddress;

	private static int IsConsoleActive_ReturnValue_Offset;

	private static bool IsAppActive_IsValid;

	private static IntPtr IsAppActive_FunctionAddress;

	private static int IsAppActive_ParamsSize;

	private static bool IsAppActive_ReturnValue_IsValid;

	private static FFieldAddress IsAppActive_ReturnValue_PropertyAddress;

	private static int IsAppActive_ReturnValue_Offset;

	private static bool GetProductStringList_IsValid;

	private static IntPtr GetProductStringList_FunctionAddress;

	private static int GetProductStringList_ParamsSize;

	private static bool GetProductStringList_ReturnValue_IsValid;

	private static FFieldAddress GetProductStringList_ReturnValue_PropertyAddress;

	private static int GetProductStringList_ReturnValue_Offset;

	private static bool GetMappingsInfo_IsValid;

	private static IntPtr GetMappingsInfo_FunctionAddress;

	private static int GetMappingsInfo_ParamsSize;

	private static bool GetMappingsInfo_MappingContext_IsValid;

	private static FFieldAddress GetMappingsInfo_MappingContext_PropertyAddress;

	private static int GetMappingsInfo_MappingContext_Offset;

	private static bool GetMappingsInfo_Actions_IsValid;

	private static FFieldAddress GetMappingsInfo_Actions_PropertyAddress;

	private static int GetMappingsInfo_Actions_Offset;

	private static bool GetMappingsInfo_Keys_IsValid;

	private static FFieldAddress GetMappingsInfo_Keys_PropertyAddress;

	private static int GetMappingsInfo_Keys_Offset;

	private static bool GetMappingsInfo_ChordActions_IsValid;

	private static FFieldAddress GetMappingsInfo_ChordActions_PropertyAddress;

	private static int GetMappingsInfo_ChordActions_Offset;

	private static bool GetMappableKey_IsValid;

	private static IntPtr GetMappableKey_FunctionAddress;

	private static int GetMappableKey_ParamsSize;

	private static bool GetMappableKey_MappingContext_IsValid;

	private static FFieldAddress GetMappableKey_MappingContext_PropertyAddress;

	private static int GetMappableKey_MappingContext_Offset;

	private static bool GetMappableKey_ReturnValue_IsValid;

	private static FFieldAddress GetMappableKey_ReturnValue_PropertyAddress;

	private static int GetMappableKey_ReturnValue_Offset;

	private static bool GetLastInputType_IsValid;

	private static IntPtr GetLastInputType_FunctionAddress;

	private static int GetLastInputType_ParamsSize;

	private static bool GetLastInputType_WorldContext_IsValid;

	private static FFieldAddress GetLastInputType_WorldContext_PropertyAddress;

	private static int GetLastInputType_WorldContext_Offset;

	private static bool GetLastInputType_ReturnValue_IsValid;

	private static FFieldAddress GetLastInputType_ReturnValue_PropertyAddress;

	private static int GetLastInputType_ReturnValue_Offset;

	private static bool GetKeyByPointerEvent_IsValid;

	private static IntPtr GetKeyByPointerEvent_FunctionAddress;

	private static int GetKeyByPointerEvent_ParamsSize;

	private static bool GetKeyByPointerEvent_PointerEvent_IsValid;

	private static FFieldAddress GetKeyByPointerEvent_PointerEvent_PropertyAddress;

	private static int GetKeyByPointerEvent_PointerEvent_Offset;

	private static bool GetKeyByPointerEvent_ReturnValue_IsValid;

	private static FFieldAddress GetKeyByPointerEvent_ReturnValue_PropertyAddress;

	private static int GetKeyByPointerEvent_ReturnValue_Offset;

	private static bool GetKeyByKeyEvent_IsValid;

	private static IntPtr GetKeyByKeyEvent_FunctionAddress;

	private static int GetKeyByKeyEvent_ParamsSize;

	private static bool GetKeyByKeyEvent_KeyEvent_IsValid;

	private static FFieldAddress GetKeyByKeyEvent_KeyEvent_PropertyAddress;

	private static int GetKeyByKeyEvent_KeyEvent_Offset;

	private static bool GetKeyByKeyEvent_ReturnValue_IsValid;

	private static FFieldAddress GetKeyByKeyEvent_ReturnValue_PropertyAddress;

	private static int GetKeyByKeyEvent_ReturnValue_Offset;

	private static bool GetKeyByAnalogInputEvent_IsValid;

	private static IntPtr GetKeyByAnalogInputEvent_FunctionAddress;

	private static int GetKeyByAnalogInputEvent_ParamsSize;

	private static bool GetKeyByAnalogInputEvent_AnalogInputEvent_IsValid;

	private static FFieldAddress GetKeyByAnalogInputEvent_AnalogInputEvent_PropertyAddress;

	private static int GetKeyByAnalogInputEvent_AnalogInputEvent_Offset;

	private static bool GetKeyByAnalogInputEvent_ReturnValue_IsValid;

	private static FFieldAddress GetKeyByAnalogInputEvent_ReturnValue_PropertyAddress;

	private static int GetKeyByAnalogInputEvent_ReturnValue_Offset;

	private static bool GetInputSettingPreProc_IsValid;

	private static IntPtr GetInputSettingPreProc_FunctionAddress;

	private static int GetInputSettingPreProc_ParamsSize;

	private static bool GetInputSettingPreProc_WorldContext_IsValid;

	private static FFieldAddress GetInputSettingPreProc_WorldContext_PropertyAddress;

	private static int GetInputSettingPreProc_WorldContext_Offset;

	private static bool GetInputSettingPreProc_ReturnValue_IsValid;

	private static FFieldAddress GetInputSettingPreProc_ReturnValue_PropertyAddress;

	private static int GetInputSettingPreProc_ReturnValue_Offset;

	private static bool GetInputPreProc_IsValid;

	private static IntPtr GetInputPreProc_FunctionAddress;

	private static int GetInputPreProc_ParamsSize;

	private static bool GetInputPreProc_WorldContext_IsValid;

	private static FFieldAddress GetInputPreProc_WorldContext_PropertyAddress;

	private static int GetInputPreProc_WorldContext_Offset;

	private static bool GetInputPreProc_ReturnValue_IsValid;

	private static FFieldAddress GetInputPreProc_ReturnValue_PropertyAddress;

	private static int GetInputPreProc_ReturnValue_Offset;

	private static bool GetInputDeviceTypes_IsValid;

	private static IntPtr GetInputDeviceTypes_FunctionAddress;

	private static int GetInputDeviceTypes_ParamsSize;

	private static bool GetInputDeviceTypes_ReturnValue_IsValid;

	private static FFieldAddress GetInputDeviceTypes_ReturnValue_PropertyAddress;

	private static int GetInputDeviceTypes_ReturnValue_Offset;

	private static bool GetInputActionValue_IsValid;

	private static IntPtr GetInputActionValue_FunctionAddress;

	private static int GetInputActionValue_ParamsSize;

	private static bool GetInputActionValue_PlayerController_IsValid;

	private static FFieldAddress GetInputActionValue_PlayerController_PropertyAddress;

	private static int GetInputActionValue_PlayerController_Offset;

	private static bool GetInputActionValue_Action_IsValid;

	private static FFieldAddress GetInputActionValue_Action_PropertyAddress;

	private static int GetInputActionValue_Action_Offset;

	private static bool GetInputActionValue_ReturnValue_IsValid;

	private static FFieldAddress GetInputActionValue_ReturnValue_PropertyAddress;

	private static int GetInputActionValue_ReturnValue_Offset;

	private static bool GetGamepadDeadZoneThreshold_IsValid;

	private static IntPtr GetGamepadDeadZoneThreshold_FunctionAddress;

	private static int GetGamepadDeadZoneThreshold_ParamsSize;

	private static bool GetGamepadDeadZoneThreshold_ReturnValue_IsValid;

	private static FFieldAddress GetGamepadDeadZoneThreshold_ReturnValue_PropertyAddress;

	private static int GetGamepadDeadZoneThreshold_ReturnValue_Offset;

	private static bool GetGamepadControllerName_IsValid;

	private static IntPtr GetGamepadControllerName_FunctionAddress;

	private static int GetGamepadControllerName_ParamsSize;

	private static bool GetGamepadControllerName_ControllerId_IsValid;

	private static FFieldAddress GetGamepadControllerName_ControllerId_PropertyAddress;

	private static int GetGamepadControllerName_ControllerId_Offset;

	private static bool GetGamepadControllerName_ReturnValue_IsValid;

	private static FFieldAddress GetGamepadControllerName_ReturnValue_PropertyAddress;

	private static int GetGamepadControllerName_ReturnValue_Offset;

	private static bool GetDebugEventAccumulatorThisTick_IsValid;

	private static IntPtr GetDebugEventAccumulatorThisTick_FunctionAddress;

	private static int GetDebugEventAccumulatorThisTick_ParamsSize;

	private static bool GetDebugEventAccumulatorThisTick_PlayerController_IsValid;

	private static FFieldAddress GetDebugEventAccumulatorThisTick_PlayerController_PropertyAddress;

	private static int GetDebugEventAccumulatorThisTick_PlayerController_Offset;

	private static bool GetDebugEventAccumulatorThisTick_Action_IsValid;

	private static FFieldAddress GetDebugEventAccumulatorThisTick_Action_PropertyAddress;

	private static int GetDebugEventAccumulatorThisTick_Action_Offset;

	private static bool GetDebugEventAccumulatorThisTick_IsReleasedEvent_IsValid;

	private static FFieldAddress GetDebugEventAccumulatorThisTick_IsReleasedEvent_PropertyAddress;

	private static int GetDebugEventAccumulatorThisTick_IsReleasedEvent_Offset;

	private static bool GetDebugEventAccumulatorThisTick_ReturnValue_IsValid;

	private static FFieldAddress GetDebugEventAccumulatorThisTick_ReturnValue_PropertyAddress;

	private static int GetDebugEventAccumulatorThisTick_ReturnValue_Offset;

	private static bool GetConflictChordInputAction_IsValid;

	private static IntPtr GetConflictChordInputAction_FunctionAddress;

	private static int GetConflictChordInputAction_ParamsSize;

	private static bool GetConflictChordInputAction_PrimaryChordAction_IsValid;

	private static FFieldAddress GetConflictChordInputAction_PrimaryChordAction_PropertyAddress;

	private static int GetConflictChordInputAction_PrimaryChordAction_Offset;

	private static bool GetConflictChordInputAction_Contexts_IsValid;

	private static FFieldAddress GetConflictChordInputAction_Contexts_PropertyAddress;

	private static int GetConflictChordInputAction_Contexts_Offset;

	private static bool GetConflictChordInputAction_PrimaryConflictActions_IsValid;

	private static FFieldAddress GetConflictChordInputAction_PrimaryConflictActions_PropertyAddress;

	private static int GetConflictChordInputAction_PrimaryConflictActions_Offset;

	private static bool GetConflictChordInputAction_SecondaryConflictActions_IsValid;

	private static FFieldAddress GetConflictChordInputAction_SecondaryConflictActions_PropertyAddress;

	private static int GetConflictChordInputAction_SecondaryConflictActions_Offset;

	private static bool GetChordInputAction_IsValid;

	private static IntPtr GetChordInputAction_FunctionAddress;

	private static int GetChordInputAction_ParamsSize;

	private static bool GetChordInputAction_InputMappingContext_IsValid;

	private static FFieldAddress GetChordInputAction_InputMappingContext_PropertyAddress;

	private static int GetChordInputAction_InputMappingContext_Offset;

	private static bool GetChordInputAction_ReturnValue_IsValid;

	private static FFieldAddress GetChordInputAction_ReturnValue_PropertyAddress;

	private static int GetChordInputAction_ReturnValue_Offset;

	private static bool GetActionNamesFromInputMappingContext_IsValid;

	private static IntPtr GetActionNamesFromInputMappingContext_FunctionAddress;

	private static int GetActionNamesFromInputMappingContext_ParamsSize;

	private static bool GetActionNamesFromInputMappingContext_InputMappingContext_IsValid;

	private static FFieldAddress GetActionNamesFromInputMappingContext_InputMappingContext_PropertyAddress;

	private static int GetActionNamesFromInputMappingContext_InputMappingContext_Offset;

	private static bool GetActionNamesFromInputMappingContext_ReturnValue_IsValid;

	private static FFieldAddress GetActionNamesFromInputMappingContext_ReturnValue_PropertyAddress;

	private static int GetActionNamesFromInputMappingContext_ReturnValue_Offset;

	private static bool FlushPressedInput_IsValid;

	private static IntPtr FlushPressedInput_FunctionAddress;

	private static int FlushPressedInput_ParamsSize;

	private static bool FlushPressedInput_PlayerController_IsValid;

	private static FFieldAddress FlushPressedInput_PlayerController_PropertyAddress;

	private static int FlushPressedInput_PlayerController_Offset;

	private static bool FindKeyByName_IsValid;

	private static IntPtr FindKeyByName_FunctionAddress;

	private static int FindKeyByName_ParamsSize;

	private static bool FindKeyByName_KeyName_IsValid;

	private static FFieldAddress FindKeyByName_KeyName_PropertyAddress;

	private static int FindKeyByName_KeyName_Offset;

	private static bool FindKeyByName_ReturnValue_IsValid;

	private static FFieldAddress FindKeyByName_ReturnValue_PropertyAddress;

	private static int FindKeyByName_ReturnValue_Offset;

	private static bool CustomizeInputMappingContext_IsValid;

	private static IntPtr CustomizeInputMappingContext_FunctionAddress;

	private static int CustomizeInputMappingContext_ParamsSize;

	private static bool CustomizeInputMappingContext_MappingContext_IsValid;

	private static FFieldAddress CustomizeInputMappingContext_MappingContext_PropertyAddress;

	private static int CustomizeInputMappingContext_MappingContext_Offset;

	private static bool CustomizeInputMappingContext_MappableName_IsValid;

	private static FFieldAddress CustomizeInputMappingContext_MappableName_PropertyAddress;

	private static int CustomizeInputMappingContext_MappableName_Offset;

	private static bool CustomizeInputMappingContext_KeyName_IsValid;

	private static FFieldAddress CustomizeInputMappingContext_KeyName_PropertyAddress;

	private static int CustomizeInputMappingContext_KeyName_Offset;

	private static bool ClearAllInputMappingContext_IsValid;

	private static IntPtr ClearAllInputMappingContext_FunctionAddress;

	private static int ClearAllInputMappingContext_ParamsSize;

	private static bool ClearAllInputMappingContext_PlayerController_IsValid;

	private static FFieldAddress ClearAllInputMappingContext_PlayerController_PropertyAddress;

	private static int ClearAllInputMappingContext_PlayerController_Offset;

	private static bool BindAction_IsValid;

	private static IntPtr BindAction_FunctionAddress;

	private static int BindAction_ParamsSize;

	private static bool BindAction_InputComponent_IsValid;

	private static FFieldAddress BindAction_InputComponent_PropertyAddress;

	private static int BindAction_InputComponent_Offset;

	private static bool BindAction_InputAction_IsValid;

	private static FFieldAddress BindAction_InputAction_PropertyAddress;

	private static int BindAction_InputAction_Offset;

	private static bool BindAction_TriggerEvent_IsValid;

	private static FFieldAddress BindAction_TriggerEvent_PropertyAddress;

	private static int BindAction_TriggerEvent_Offset;

	private static bool AddPlayerMappedKey_IsValid;

	private static IntPtr AddPlayerMappedKey_FunctionAddress;

	private static int AddPlayerMappedKey_ParamsSize;

	private static bool AddPlayerMappedKey_PlayerController_IsValid;

	private static FFieldAddress AddPlayerMappedKey_PlayerController_PropertyAddress;

	private static int AddPlayerMappedKey_PlayerController_Offset;

	private static bool AddPlayerMappedKey_MappingName_IsValid;

	private static FFieldAddress AddPlayerMappedKey_MappingName_PropertyAddress;

	private static int AddPlayerMappedKey_MappingName_Offset;

	private static bool AddPlayerMappedKey_NewKey_IsValid;

	private static FFieldAddress AddPlayerMappedKey_NewKey_PropertyAddress;

	private static int AddPlayerMappedKey_NewKey_Offset;

	private static bool AddPlayerMappedKey_Options_IsValid;

	private static FFieldAddress AddPlayerMappedKey_Options_PropertyAddress;

	private static int AddPlayerMappedKey_Options_Offset;

	private static bool AddInputMappingContext_IsValid;

	private static IntPtr AddInputMappingContext_FunctionAddress;

	private static int AddInputMappingContext_ParamsSize;

	private static bool AddInputMappingContext_PlayerController_IsValid;

	private static FFieldAddress AddInputMappingContext_PlayerController_PropertyAddress;

	private static int AddInputMappingContext_PlayerController_Offset;

	private static bool AddInputMappingContext_InputMappingContext_IsValid;

	private static FFieldAddress AddInputMappingContext_InputMappingContext_PropertyAddress;

	private static int AddInputMappingContext_InputMappingContext_Offset;

	private static bool AddInputMappingContext_Priority_IsValid;

	private static FFieldAddress AddInputMappingContext_Priority_PropertyAddress;

	private static int AddInputMappingContext_Priority_Offset;

	private static bool AddInputMappingContext_bIgnoreAllPressedKeysUntilRelease_IsValid;

	private static FFieldAddress AddInputMappingContext_bIgnoreAllPressedKeysUntilRelease_PropertyAddress;

	private static int AddInputMappingContext_bIgnoreAllPressedKeysUntilRelease_Offset;

	private static bool AddInputMappingContext_bForceImmediately_IsValid;

	private static FFieldAddress AddInputMappingContext_bForceImmediately_PropertyAddress;

	private static int AddInputMappingContext_bForceImmediately_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:UpdateAllInputIcon")]
	public unsafe static void UpdateAllInputIcon()
	{
		if (!UpdateAllInputIcon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:UpdateAllInputIcon");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateAllInputIcon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateAllInputIcon_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: UpdateAllInputIcon_FunctionAddress, argsSize: UpdateAllInputIcon_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:UnRegisterInputTargetBinding")]
	public unsafe static void UnRegisterInputTargetBinding(UGSInputTargetBinding InputTargetBindingObj)
	{
		if (!UnRegisterInputTargetBinding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:UnRegisterInputTargetBinding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnRegisterInputTargetBinding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnRegisterInputTargetBinding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGSInputTargetBinding>.ToNative(IntPtr.Add(intPtr, UnRegisterInputTargetBinding_InputTargetBindingObj_Offset), 0, UnRegisterInputTargetBinding_InputTargetBindingObj_PropertyAddress.Address, InputTargetBindingObj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UnRegisterInputTargetBinding_FunctionAddress, intPtr, UnRegisterInputTargetBinding_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:UnRegisterGSInputProc")]
	public unsafe static void UnRegisterGSInputProc(UObject WorldContext, EGSInputProcOrder Order)
	{
		if (!UnRegisterGSInputProc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:UnRegisterGSInputProc");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnRegisterGSInputProc_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnRegisterGSInputProc_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, UnRegisterGSInputProc_WorldContext_Offset), 0, UnRegisterGSInputProc_WorldContext_PropertyAddress.Address, WorldContext);
		EnumMarshaler<EGSInputProcOrder>.ToNative(IntPtr.Add(intPtr, UnRegisterGSInputProc_Order_Offset), 0, UnRegisterGSInputProc_Order_PropertyAddress.Address, Order);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UnRegisterGSInputProc_FunctionAddress, intPtr, UnRegisterGSInputProc_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:TryToSetContextNewPriority")]
	public unsafe static bool TryToSetContextNewPriority(APlayerController PlayerController, UInputMappingContext Context, int NewPriority)
	{
		if (!TryToSetContextNewPriority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:TryToSetContextNewPriority");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryToSetContextNewPriority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryToSetContextNewPriority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, TryToSetContextNewPriority_PlayerController_Offset), 0, TryToSetContextNewPriority_PlayerController_PropertyAddress.Address, PlayerController);
		UObjectMarshaler<UInputMappingContext>.ToNative(IntPtr.Add(intPtr, TryToSetContextNewPriority_Context_Offset), 0, TryToSetContextNewPriority_Context_PropertyAddress.Address, Context);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, TryToSetContextNewPriority_NewPriority_Offset), 0, TryToSetContextNewPriority_NewPriority_PropertyAddress.Address, NewPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TryToSetContextNewPriority_FunctionAddress, intPtr, TryToSetContextNewPriority_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TryToSetContextNewPriority_ReturnValue_Offset), 0, TryToSetContextNewPriority_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:SetUIOnly")]
	public unsafe static void SetUIOnly(APlayerController PlayerController, bool bNeedMouseCapture = true)
	{
		if (!SetUIOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:SetUIOnly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUIOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUIOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, SetUIOnly_PlayerController_Offset), 0, SetUIOnly_PlayerController_PropertyAddress.Address, PlayerController);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetUIOnly_bNeedMouseCapture_Offset), 0, SetUIOnly_bNeedMouseCapture_PropertyAddress.Address, bNeedMouseCapture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetUIOnly_FunctionAddress, intPtr, SetUIOnly_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:SetMouseCursorPosition")]
	public unsafe static void SetMouseCursorPosition(FVector2D Position)
	{
		if (!SetMouseCursorPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:SetMouseCursorPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMouseCursorPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMouseCursorPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetMouseCursorPosition_Position_Offset), 0, SetMouseCursorPosition_Position_PropertyAddress.Address, Position);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMouseCursorPosition_FunctionAddress, intPtr, SetMouseCursorPosition_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:SetIgnoreAllButtonKeyInput")]
	public unsafe static void SetIgnoreAllButtonKeyInput(UObject WorldContext, bool IsIgnore)
	{
		if (!SetIgnoreAllButtonKeyInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:SetIgnoreAllButtonKeyInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIgnoreAllButtonKeyInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIgnoreAllButtonKeyInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetIgnoreAllButtonKeyInput_WorldContext_Offset), 0, SetIgnoreAllButtonKeyInput_WorldContext_PropertyAddress.Address, WorldContext);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIgnoreAllButtonKeyInput_IsIgnore_Offset), 0, SetIgnoreAllButtonKeyInput_IsIgnore_PropertyAddress.Address, IsIgnore);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetIgnoreAllButtonKeyInput_FunctionAddress, intPtr, SetIgnoreAllButtonKeyInput_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:SetGameOnly")]
	public unsafe static void SetGameOnly(APlayerController PlayerController)
	{
		if (!SetGameOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:SetGameOnly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGameOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGameOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, SetGameOnly_PlayerController_Offset), 0, SetGameOnly_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetGameOnly_FunctionAddress, intPtr, SetGameOnly_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:SetCursorVisibility")]
	public unsafe static void SetCursorVisibility(bool bDrawCursor)
	{
		if (!SetCursorVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:SetCursorVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCursorVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCursorVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCursorVisibility_bDrawCursor_Offset), 0, SetCursorVisibility_bDrawCursor_PropertyAddress.Address, bDrawCursor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCursorVisibility_FunctionAddress, intPtr, SetCursorVisibility_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:RequestRebuildControlMappings")]
	public unsafe static void RequestRebuildControlMappings(APlayerController PlayerController, bool bForceImmediately = true, bool bIgnoreAllPressedKeysUntilRelease = false)
	{
		if (!RequestRebuildControlMappings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:RequestRebuildControlMappings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestRebuildControlMappings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestRebuildControlMappings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, RequestRebuildControlMappings_PlayerController_Offset), 0, RequestRebuildControlMappings_PlayerController_PropertyAddress.Address, PlayerController);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestRebuildControlMappings_bForceImmediately_Offset), 0, RequestRebuildControlMappings_bForceImmediately_PropertyAddress.Address, bForceImmediately);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestRebuildControlMappings_bIgnoreAllPressedKeysUntilRelease_Offset), 0, RequestRebuildControlMappings_bIgnoreAllPressedKeysUntilRelease_PropertyAddress.Address, bIgnoreAllPressedKeysUntilRelease);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestRebuildControlMappings_FunctionAddress, intPtr, RequestRebuildControlMappings_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:RemoveInputMappingContext")]
	public unsafe static void RemoveInputMappingContext(APlayerController PlayerController, UInputMappingContext InputMappingContext, bool bIgnoreAllPressedKeysUntilRelease = true, bool bForceImmediately = false)
	{
		if (!RemoveInputMappingContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:RemoveInputMappingContext");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveInputMappingContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveInputMappingContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, RemoveInputMappingContext_PlayerController_Offset), 0, RemoveInputMappingContext_PlayerController_PropertyAddress.Address, PlayerController);
		UObjectMarshaler<UInputMappingContext>.ToNative(IntPtr.Add(intPtr, RemoveInputMappingContext_InputMappingContext_Offset), 0, RemoveInputMappingContext_InputMappingContext_PropertyAddress.Address, InputMappingContext);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveInputMappingContext_bIgnoreAllPressedKeysUntilRelease_Offset), 0, RemoveInputMappingContext_bIgnoreAllPressedKeysUntilRelease_PropertyAddress.Address, bIgnoreAllPressedKeysUntilRelease);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveInputMappingContext_bForceImmediately_Offset), 0, RemoveInputMappingContext_bForceImmediately_PropertyAddress.Address, bForceImmediately);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveInputMappingContext_FunctionAddress, intPtr, RemoveInputMappingContext_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:RegisterInputTargetBinding")]
	public unsafe static void RegisterInputTargetBinding(UGSInputTargetBinding InputTargetBindingObj)
	{
		if (!RegisterInputTargetBinding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:RegisterInputTargetBinding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterInputTargetBinding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterInputTargetBinding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGSInputTargetBinding>.ToNative(IntPtr.Add(intPtr, RegisterInputTargetBinding_InputTargetBindingObj_Offset), 0, RegisterInputTargetBinding_InputTargetBindingObj_PropertyAddress.Address, InputTargetBindingObj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisterInputTargetBinding_FunctionAddress, intPtr, RegisterInputTargetBinding_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:RegisterGSInputProc")]
	public unsafe static void RegisterGSInputProc(UObject WorldContext, EGSInputProcOrder Order)
	{
		if (!RegisterGSInputProc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:RegisterGSInputProc");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterGSInputProc_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterGSInputProc_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RegisterGSInputProc_WorldContext_Offset), 0, RegisterGSInputProc_WorldContext_PropertyAddress.Address, WorldContext);
		EnumMarshaler<EGSInputProcOrder>.ToNative(IntPtr.Add(intPtr, RegisterGSInputProc_Order_Offset), 0, RegisterGSInputProc_Order_PropertyAddress.Address, Order);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisterGSInputProc_FunctionAddress, intPtr, RegisterGSInputProc_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:QueryKeysMappedToAction")]
	public unsafe static List<FKey> QueryKeysMappedToAction(APlayerController PlayerController, UInputAction Action)
	{
		if (!QueryKeysMappedToAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:QueryKeysMappedToAction");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QueryKeysMappedToAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QueryKeysMappedToAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, QueryKeysMappedToAction_PlayerController_Offset), 0, QueryKeysMappedToAction_PlayerController_PropertyAddress.Address, PlayerController);
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(intPtr, QueryKeysMappedToAction_Action_Offset), 0, QueryKeysMappedToAction_Action_PropertyAddress.Address, Action);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QueryKeysMappedToAction_FunctionAddress, intPtr, QueryKeysMappedToAction_ParamsSize);
		List<FKey> result = new TArrayCopyMarshaler<FKey>(1, QueryKeysMappedToAction_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FKey, FKey>.FromNative, CachedMarshalingDelegates<FKey, FKey>.ToNative).FromNative(IntPtr.Add(intPtr, QueryKeysMappedToAction_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(QueryKeysMappedToAction_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:QueryKeysByInputAction")]
	public unsafe static List<FKey> QueryKeysByInputAction(UInputMappingContext MappingContext, UInputAction Action)
	{
		if (!QueryKeysByInputAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:QueryKeysByInputAction");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QueryKeysByInputAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QueryKeysByInputAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputMappingContext>.ToNative(IntPtr.Add(intPtr, QueryKeysByInputAction_MappingContext_Offset), 0, QueryKeysByInputAction_MappingContext_PropertyAddress.Address, MappingContext);
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(intPtr, QueryKeysByInputAction_Action_Offset), 0, QueryKeysByInputAction_Action_PropertyAddress.Address, Action);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QueryKeysByInputAction_FunctionAddress, intPtr, QueryKeysByInputAction_ParamsSize);
		List<FKey> result = new TArrayCopyMarshaler<FKey>(1, QueryKeysByInputAction_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FKey, FKey>.FromNative, CachedMarshalingDelegates<FKey, FKey>.ToNative).FromNative(IntPtr.Add(intPtr, QueryKeysByInputAction_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(QueryKeysByInputAction_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:IsConsoleActive")]
	public unsafe static bool IsConsoleActive(UObject WorldContext)
	{
		if (!IsConsoleActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:IsConsoleActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsConsoleActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsConsoleActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsConsoleActive_WorldContext_Offset), 0, IsConsoleActive_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsConsoleActive_FunctionAddress, intPtr, IsConsoleActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsConsoleActive_ReturnValue_Offset), 0, IsConsoleActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:IsAppActive")]
	public unsafe static bool IsAppActive()
	{
		if (!IsAppActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:IsAppActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAppActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAppActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsAppActive_FunctionAddress, intPtr, IsAppActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAppActive_ReturnValue_Offset), 0, IsAppActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetProductStringList")]
	public unsafe static List<string> GetProductStringList()
	{
		if (!GetProductStringList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetProductStringList");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetProductStringList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetProductStringList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetProductStringList_FunctionAddress, intPtr, GetProductStringList_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetProductStringList_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetProductStringList_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetProductStringList_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetMappingsInfo")]
	public unsafe static void GetMappingsInfo(UInputMappingContext MappingContext, out List<UInputAction> Actions, out List<FKey> Keys, out List<UInputAction> ChordActions)
	{
		if (!GetMappingsInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetMappingsInfo");
			Actions = null;
			Keys = null;
			ChordActions = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMappingsInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMappingsInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputMappingContext>.ToNative(IntPtr.Add(intPtr, GetMappingsInfo_MappingContext_Offset), 0, GetMappingsInfo_MappingContext_PropertyAddress.Address, MappingContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMappingsInfo_FunctionAddress, intPtr, GetMappingsInfo_ParamsSize);
		Actions = new TArrayCopyMarshaler<UInputAction>(1, GetMappingsInfo_Actions_PropertyAddress, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.FromNative, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMappingsInfo_Actions_Offset));
		NativeReflection.DestroyValue_InContainer(GetMappingsInfo_Actions_PropertyAddress.Address, intPtr);
		Keys = new TArrayCopyMarshaler<FKey>(1, GetMappingsInfo_Keys_PropertyAddress, CachedMarshalingDelegates<FKey, FKey>.FromNative, CachedMarshalingDelegates<FKey, FKey>.ToNative).FromNative(IntPtr.Add(intPtr, GetMappingsInfo_Keys_Offset));
		NativeReflection.DestroyValue_InContainer(GetMappingsInfo_Keys_PropertyAddress.Address, intPtr);
		ChordActions = new TArrayCopyMarshaler<UInputAction>(1, GetMappingsInfo_ChordActions_PropertyAddress, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.FromNative, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMappingsInfo_ChordActions_Offset));
		NativeReflection.DestroyValue_InContainer(GetMappingsInfo_ChordActions_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetMappableKey")]
	public unsafe static Dictionary<FName, FKey> GetMappableKey(UInputMappingContext MappingContext)
	{
		if (!GetMappableKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetMappableKey");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMappableKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMappableKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputMappingContext>.ToNative(IntPtr.Add(intPtr, GetMappableKey_MappingContext_Offset), 0, GetMappableKey_MappingContext_PropertyAddress.Address, MappingContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMappableKey_FunctionAddress, intPtr, GetMappableKey_ParamsSize);
		Dictionary<FName, FKey> result = new TMapCopyMarshaler<FName, FKey>(1, GetMappableKey_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FKey, FKey>.FromNative, CachedMarshalingDelegates<FKey, FKey>.ToNative).FromNative(IntPtr.Add(intPtr, GetMappableKey_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetMappableKey_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetLastInputType")]
	public unsafe static EGSInputType GetLastInputType(UObject WorldContext)
	{
		if (!GetLastInputType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetLastInputType");
			return EGSInputType.None;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastInputType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastInputType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetLastInputType_WorldContext_Offset), 0, GetLastInputType_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLastInputType_FunctionAddress, intPtr, GetLastInputType_ParamsSize);
		return EnumMarshaler<EGSInputType>.FromNative(IntPtr.Add(intPtr, GetLastInputType_ReturnValue_Offset), 0, GetLastInputType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetKeyByPointerEvent")]
	public unsafe static FName GetKeyByPointerEvent(FPointerEvent PointerEvent)
	{
		if (!GetKeyByPointerEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetKeyByPointerEvent");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKeyByPointerEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKeyByPointerEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetKeyByPointerEvent_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, GetKeyByPointerEvent_PointerEvent_Offset), 0, GetKeyByPointerEvent_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetKeyByPointerEvent_FunctionAddress, intPtr, GetKeyByPointerEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetKeyByPointerEvent_PointerEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetKeyByPointerEvent_ReturnValue_Offset), 0, GetKeyByPointerEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetKeyByKeyEvent")]
	public unsafe static FName GetKeyByKeyEvent(FKeyEvent KeyEvent)
	{
		if (!GetKeyByKeyEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetKeyByKeyEvent");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKeyByKeyEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKeyByKeyEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetKeyByKeyEvent_KeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, GetKeyByKeyEvent_KeyEvent_Offset), 0, GetKeyByKeyEvent_KeyEvent_PropertyAddress.Address, KeyEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetKeyByKeyEvent_FunctionAddress, intPtr, GetKeyByKeyEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetKeyByKeyEvent_KeyEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetKeyByKeyEvent_ReturnValue_Offset), 0, GetKeyByKeyEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetKeyByAnalogInputEvent")]
	public unsafe static FName GetKeyByAnalogInputEvent(FAnalogInputEvent AnalogInputEvent)
	{
		if (!GetKeyByAnalogInputEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetKeyByAnalogInputEvent");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKeyByAnalogInputEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKeyByAnalogInputEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetKeyByAnalogInputEvent_AnalogInputEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnalogInputEvent>.ToNative(IntPtr.Add(intPtr, GetKeyByAnalogInputEvent_AnalogInputEvent_Offset), 0, GetKeyByAnalogInputEvent_AnalogInputEvent_PropertyAddress.Address, AnalogInputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetKeyByAnalogInputEvent_FunctionAddress, intPtr, GetKeyByAnalogInputEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetKeyByAnalogInputEvent_AnalogInputEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetKeyByAnalogInputEvent_ReturnValue_Offset), 0, GetKeyByAnalogInputEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetInputSettingPreProc")]
	public unsafe static UGSInputSettingPreProc GetInputSettingPreProc(UObject WorldContext)
	{
		if (!GetInputSettingPreProc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetInputSettingPreProc");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputSettingPreProc_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputSettingPreProc_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetInputSettingPreProc_WorldContext_Offset), 0, GetInputSettingPreProc_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputSettingPreProc_FunctionAddress, intPtr, GetInputSettingPreProc_ParamsSize);
		return UObjectMarshaler<UGSInputSettingPreProc>.FromNative(IntPtr.Add(intPtr, GetInputSettingPreProc_ReturnValue_Offset), 0, GetInputSettingPreProc_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetInputPreProc")]
	public unsafe static UGSInputPreProc GetInputPreProc(UObject WorldContext)
	{
		if (!GetInputPreProc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetInputPreProc");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputPreProc_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputPreProc_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetInputPreProc_WorldContext_Offset), 0, GetInputPreProc_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputPreProc_FunctionAddress, intPtr, GetInputPreProc_ParamsSize);
		return UObjectMarshaler<UGSInputPreProc>.FromNative(IntPtr.Add(intPtr, GetInputPreProc_ReturnValue_Offset), 0, GetInputPreProc_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetInputDeviceTypes")]
	public unsafe static List<EGSInputDeviceType> GetInputDeviceTypes()
	{
		if (!GetInputDeviceTypes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetInputDeviceTypes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputDeviceTypes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputDeviceTypes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputDeviceTypes_FunctionAddress, intPtr, GetInputDeviceTypes_ParamsSize);
		List<EGSInputDeviceType> result = new TArrayCopyMarshaler<EGSInputDeviceType>(1, GetInputDeviceTypes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<EGSInputDeviceType, EnumMarshaler<EGSInputDeviceType>>.FromNative, CachedMarshalingDelegates<EGSInputDeviceType, EnumMarshaler<EGSInputDeviceType>>.ToNative).FromNative(IntPtr.Add(intPtr, GetInputDeviceTypes_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetInputDeviceTypes_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetInputActionValue")]
	public unsafe static FVector GetInputActionValue(APlayerController PlayerController, UInputAction Action)
	{
		if (!GetInputActionValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetInputActionValue");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputActionValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputActionValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetInputActionValue_PlayerController_Offset), 0, GetInputActionValue_PlayerController_PropertyAddress.Address, PlayerController);
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(intPtr, GetInputActionValue_Action_Offset), 0, GetInputActionValue_Action_PropertyAddress.Address, Action);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputActionValue_FunctionAddress, intPtr, GetInputActionValue_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetInputActionValue_ReturnValue_Offset), 0, GetInputActionValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetGamepadDeadZoneThreshold")]
	public unsafe static float GetGamepadDeadZoneThreshold()
	{
		if (!GetGamepadDeadZoneThreshold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetGamepadDeadZoneThreshold");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGamepadDeadZoneThreshold_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGamepadDeadZoneThreshold_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGamepadDeadZoneThreshold_FunctionAddress, intPtr, GetGamepadDeadZoneThreshold_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetGamepadDeadZoneThreshold_ReturnValue_Offset), 0, GetGamepadDeadZoneThreshold_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetGamepadControllerName")]
	public unsafe static string GetGamepadControllerName(int ControllerId)
	{
		if (!GetGamepadControllerName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetGamepadControllerName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGamepadControllerName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGamepadControllerName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetGamepadControllerName_ControllerId_Offset), 0, GetGamepadControllerName_ControllerId_PropertyAddress.Address, ControllerId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGamepadControllerName_FunctionAddress, intPtr, GetGamepadControllerName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetGamepadControllerName_ReturnValue_Offset), 0, GetGamepadControllerName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetGamepadControllerName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetDebugEventAccumulatorThisTick")]
	public unsafe static int GetDebugEventAccumulatorThisTick(APlayerController PlayerController, UInputAction Action, bool IsReleasedEvent = false)
	{
		if (!GetDebugEventAccumulatorThisTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetDebugEventAccumulatorThisTick");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDebugEventAccumulatorThisTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDebugEventAccumulatorThisTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetDebugEventAccumulatorThisTick_PlayerController_Offset), 0, GetDebugEventAccumulatorThisTick_PlayerController_PropertyAddress.Address, PlayerController);
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(intPtr, GetDebugEventAccumulatorThisTick_Action_Offset), 0, GetDebugEventAccumulatorThisTick_Action_PropertyAddress.Address, Action);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetDebugEventAccumulatorThisTick_IsReleasedEvent_Offset), 0, GetDebugEventAccumulatorThisTick_IsReleasedEvent_PropertyAddress.Address, IsReleasedEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDebugEventAccumulatorThisTick_FunctionAddress, intPtr, GetDebugEventAccumulatorThisTick_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetDebugEventAccumulatorThisTick_ReturnValue_Offset), 0, GetDebugEventAccumulatorThisTick_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetConflictChordInputAction")]
	public unsafe static void GetConflictChordInputAction(UInputAction PrimaryChordAction, List<UInputMappingContext> Contexts, out List<UInputAction> PrimaryConflictActions, out List<UInputAction> SecondaryConflictActions)
	{
		if (!GetConflictChordInputAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetConflictChordInputAction");
			PrimaryConflictActions = null;
			SecondaryConflictActions = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConflictChordInputAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConflictChordInputAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(intPtr, GetConflictChordInputAction_PrimaryChordAction_Offset), 0, GetConflictChordInputAction_PrimaryChordAction_PropertyAddress.Address, PrimaryChordAction);
		new TArrayCopyMarshaler<UInputMappingContext>(1, GetConflictChordInputAction_Contexts_PropertyAddress, CachedMarshalingDelegates<UInputMappingContext, UObjectMarshaler<UInputMappingContext>>.FromNative, CachedMarshalingDelegates<UInputMappingContext, UObjectMarshaler<UInputMappingContext>>.ToNative).ToNative(IntPtr.Add(intPtr, GetConflictChordInputAction_Contexts_Offset), Contexts);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetConflictChordInputAction_FunctionAddress, intPtr, GetConflictChordInputAction_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetConflictChordInputAction_Contexts_PropertyAddress.Address, intPtr);
		PrimaryConflictActions = new TArrayCopyMarshaler<UInputAction>(1, GetConflictChordInputAction_PrimaryConflictActions_PropertyAddress, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.FromNative, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.ToNative).FromNative(IntPtr.Add(intPtr, GetConflictChordInputAction_PrimaryConflictActions_Offset));
		NativeReflection.DestroyValue_InContainer(GetConflictChordInputAction_PrimaryConflictActions_PropertyAddress.Address, intPtr);
		SecondaryConflictActions = new TArrayCopyMarshaler<UInputAction>(1, GetConflictChordInputAction_SecondaryConflictActions_PropertyAddress, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.FromNative, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.ToNative).FromNative(IntPtr.Add(intPtr, GetConflictChordInputAction_SecondaryConflictActions_Offset));
		NativeReflection.DestroyValue_InContainer(GetConflictChordInputAction_SecondaryConflictActions_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetChordInputAction")]
	public unsafe static List<UInputAction> GetChordInputAction(UInputMappingContext InputMappingContext)
	{
		if (!GetChordInputAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetChordInputAction");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChordInputAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChordInputAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputMappingContext>.ToNative(IntPtr.Add(intPtr, GetChordInputAction_InputMappingContext_Offset), 0, GetChordInputAction_InputMappingContext_PropertyAddress.Address, InputMappingContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetChordInputAction_FunctionAddress, intPtr, GetChordInputAction_ParamsSize);
		List<UInputAction> result = new TArrayCopyMarshaler<UInputAction>(1, GetChordInputAction_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.FromNative, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.ToNative).FromNative(IntPtr.Add(intPtr, GetChordInputAction_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetChordInputAction_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:GetActionNamesFromInputMappingContext")]
	public unsafe static List<string> GetActionNamesFromInputMappingContext(UInputMappingContext InputMappingContext)
	{
		if (!GetActionNamesFromInputMappingContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:GetActionNamesFromInputMappingContext");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActionNamesFromInputMappingContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActionNamesFromInputMappingContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputMappingContext>.ToNative(IntPtr.Add(intPtr, GetActionNamesFromInputMappingContext_InputMappingContext_Offset), 0, GetActionNamesFromInputMappingContext_InputMappingContext_PropertyAddress.Address, InputMappingContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActionNamesFromInputMappingContext_FunctionAddress, intPtr, GetActionNamesFromInputMappingContext_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetActionNamesFromInputMappingContext_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetActionNamesFromInputMappingContext_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetActionNamesFromInputMappingContext_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:FlushPressedInput")]
	public unsafe static void FlushPressedInput(APlayerController PlayerController)
	{
		if (!FlushPressedInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:FlushPressedInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FlushPressedInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FlushPressedInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, FlushPressedInput_PlayerController_Offset), 0, FlushPressedInput_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FlushPressedInput_FunctionAddress, intPtr, FlushPressedInput_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:FindKeyByName")]
	public unsafe static FKey FindKeyByName(FName KeyName)
	{
		if (!FindKeyByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:FindKeyByName");
			return default(FKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindKeyByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindKeyByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindKeyByName_KeyName_Offset), 0, FindKeyByName_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindKeyByName_FunctionAddress, intPtr, FindKeyByName_ParamsSize);
		FKey result = FKey.FromNative(IntPtr.Add(intPtr, FindKeyByName_ReturnValue_Offset), 0, FindKeyByName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FindKeyByName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:CustomizeInputMappingContext")]
	public unsafe static void CustomizeInputMappingContext(UInputMappingContext MappingContext, FName MappableName, FName KeyName)
	{
		if (!CustomizeInputMappingContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:CustomizeInputMappingContext");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CustomizeInputMappingContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CustomizeInputMappingContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputMappingContext>.ToNative(IntPtr.Add(intPtr, CustomizeInputMappingContext_MappingContext_Offset), 0, CustomizeInputMappingContext_MappingContext_PropertyAddress.Address, MappingContext);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CustomizeInputMappingContext_MappableName_Offset), 0, CustomizeInputMappingContext_MappableName_PropertyAddress.Address, MappableName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CustomizeInputMappingContext_KeyName_Offset), 0, CustomizeInputMappingContext_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CustomizeInputMappingContext_FunctionAddress, intPtr, CustomizeInputMappingContext_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:ClearAllInputMappingContext")]
	public unsafe static void ClearAllInputMappingContext(APlayerController PlayerController)
	{
		if (!ClearAllInputMappingContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:ClearAllInputMappingContext");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAllInputMappingContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAllInputMappingContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, ClearAllInputMappingContext_PlayerController_Offset), 0, ClearAllInputMappingContext_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearAllInputMappingContext_FunctionAddress, intPtr, ClearAllInputMappingContext_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:BindAction")]
	public unsafe static void BindAction(UGSInputComponent InputComponent, UInputAction InputAction, ETriggerEvent TriggerEvent)
	{
		if (!BindAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:BindAction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BindAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BindAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGSInputComponent>.ToNative(IntPtr.Add(intPtr, BindAction_InputComponent_Offset), 0, BindAction_InputComponent_PropertyAddress.Address, InputComponent);
		UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(intPtr, BindAction_InputAction_Offset), 0, BindAction_InputAction_PropertyAddress.Address, InputAction);
		EnumMarshaler<ETriggerEvent>.ToNative(IntPtr.Add(intPtr, BindAction_TriggerEvent_Offset), 0, BindAction_TriggerEvent_PropertyAddress.Address, TriggerEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BindAction_FunctionAddress, intPtr, BindAction_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:AddPlayerMappedKey")]
	public unsafe static void AddPlayerMappedKey(APlayerController PlayerController, FName MappingName, FKey NewKey, FModifyContextOptions Options)
	{
		if (!AddPlayerMappedKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:AddPlayerMappedKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddPlayerMappedKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddPlayerMappedKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, AddPlayerMappedKey_PlayerController_Offset), 0, AddPlayerMappedKey_PlayerController_PropertyAddress.Address, PlayerController);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddPlayerMappedKey_MappingName_Offset), 0, AddPlayerMappedKey_MappingName_PropertyAddress.Address, MappingName);
		NativeReflection.InitializeValue_InContainer(AddPlayerMappedKey_NewKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, AddPlayerMappedKey_NewKey_Offset), 0, AddPlayerMappedKey_NewKey_PropertyAddress.Address, NewKey);
		NativeReflection.InitializeValue_InContainer(AddPlayerMappedKey_Options_PropertyAddress.Address, intPtr);
		FModifyContextOptions.ToNative(IntPtr.Add(intPtr, AddPlayerMappedKey_Options_Offset), 0, AddPlayerMappedKey_Options_PropertyAddress.Address, Options);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddPlayerMappedKey_FunctionAddress, intPtr, AddPlayerMappedKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddPlayerMappedKey_NewKey_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSInput.GSE_InputFuncLib:AddInputMappingContext")]
	public unsafe static void AddInputMappingContext(APlayerController PlayerController, UInputMappingContext InputMappingContext, int Priority, bool bIgnoreAllPressedKeysUntilRelease = true, bool bForceImmediately = false)
	{
		if (!AddInputMappingContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSInput.GSE_InputFuncLib:AddInputMappingContext");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddInputMappingContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddInputMappingContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, AddInputMappingContext_PlayerController_Offset), 0, AddInputMappingContext_PlayerController_PropertyAddress.Address, PlayerController);
		UObjectMarshaler<UInputMappingContext>.ToNative(IntPtr.Add(intPtr, AddInputMappingContext_InputMappingContext_Offset), 0, AddInputMappingContext_InputMappingContext_PropertyAddress.Address, InputMappingContext);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddInputMappingContext_Priority_Offset), 0, AddInputMappingContext_Priority_PropertyAddress.Address, Priority);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddInputMappingContext_bIgnoreAllPressedKeysUntilRelease_Offset), 0, AddInputMappingContext_bIgnoreAllPressedKeysUntilRelease_PropertyAddress.Address, bIgnoreAllPressedKeysUntilRelease);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddInputMappingContext_bForceImmediately_Offset), 0, AddInputMappingContext_bForceImmediately_PropertyAddress.Address, bForceImmediately);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddInputMappingContext_FunctionAddress, intPtr, AddInputMappingContext_ParamsSize);
	}

	static UGSE_InputFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_InputFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_InputFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GSInput.GSE_InputFuncLib");
		UpdateAllInputIcon_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateAllInputIcon");
		UpdateAllInputIcon_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateAllInputIcon_FunctionAddress);
		UpdateAllInputIcon_IsValid = UpdateAllInputIcon_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:UpdateAllInputIcon", UpdateAllInputIcon_IsValid);
		UnRegisterInputTargetBinding_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnRegisterInputTargetBinding");
		UnRegisterInputTargetBinding_ParamsSize = NativeReflection.GetFunctionParamsSize(UnRegisterInputTargetBinding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnRegisterInputTargetBinding_InputTargetBindingObj_PropertyAddress, UnRegisterInputTargetBinding_FunctionAddress, "InputTargetBindingObj");
		UnRegisterInputTargetBinding_InputTargetBindingObj_Offset = NativeReflectionCached.GetPropertyOffset(UnRegisterInputTargetBinding_FunctionAddress, "InputTargetBindingObj");
		UnRegisterInputTargetBinding_InputTargetBindingObj_IsValid = NativeReflectionCached.ValidatePropertyClass(UnRegisterInputTargetBinding_FunctionAddress, "InputTargetBindingObj", Classes.FObjectProperty);
		UnRegisterInputTargetBinding_IsValid = UnRegisterInputTargetBinding_FunctionAddress != IntPtr.Zero && UnRegisterInputTargetBinding_InputTargetBindingObj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:UnRegisterInputTargetBinding", UnRegisterInputTargetBinding_IsValid);
		UnRegisterGSInputProc_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnRegisterGSInputProc");
		UnRegisterGSInputProc_ParamsSize = NativeReflection.GetFunctionParamsSize(UnRegisterGSInputProc_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnRegisterGSInputProc_WorldContext_PropertyAddress, UnRegisterGSInputProc_FunctionAddress, "WorldContext");
		UnRegisterGSInputProc_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(UnRegisterGSInputProc_FunctionAddress, "WorldContext");
		UnRegisterGSInputProc_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(UnRegisterGSInputProc_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UnRegisterGSInputProc_Order_PropertyAddress, UnRegisterGSInputProc_FunctionAddress, "Order");
		UnRegisterGSInputProc_Order_Offset = NativeReflectionCached.GetPropertyOffset(UnRegisterGSInputProc_FunctionAddress, "Order");
		UnRegisterGSInputProc_Order_IsValid = NativeReflectionCached.ValidatePropertyClass(UnRegisterGSInputProc_FunctionAddress, "Order", Classes.FEnumProperty);
		UnRegisterGSInputProc_IsValid = UnRegisterGSInputProc_FunctionAddress != IntPtr.Zero && UnRegisterGSInputProc_WorldContext_IsValid && UnRegisterGSInputProc_Order_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:UnRegisterGSInputProc", UnRegisterGSInputProc_IsValid);
		TryToSetContextNewPriority_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TryToSetContextNewPriority");
		TryToSetContextNewPriority_ParamsSize = NativeReflection.GetFunctionParamsSize(TryToSetContextNewPriority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryToSetContextNewPriority_PlayerController_PropertyAddress, TryToSetContextNewPriority_FunctionAddress, "PlayerController");
		TryToSetContextNewPriority_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(TryToSetContextNewPriority_FunctionAddress, "PlayerController");
		TryToSetContextNewPriority_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(TryToSetContextNewPriority_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TryToSetContextNewPriority_Context_PropertyAddress, TryToSetContextNewPriority_FunctionAddress, "Context");
		TryToSetContextNewPriority_Context_Offset = NativeReflectionCached.GetPropertyOffset(TryToSetContextNewPriority_FunctionAddress, "Context");
		TryToSetContextNewPriority_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(TryToSetContextNewPriority_FunctionAddress, "Context", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TryToSetContextNewPriority_NewPriority_PropertyAddress, TryToSetContextNewPriority_FunctionAddress, "NewPriority");
		TryToSetContextNewPriority_NewPriority_Offset = NativeReflectionCached.GetPropertyOffset(TryToSetContextNewPriority_FunctionAddress, "NewPriority");
		TryToSetContextNewPriority_NewPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(TryToSetContextNewPriority_FunctionAddress, "NewPriority", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref TryToSetContextNewPriority_ReturnValue_PropertyAddress, TryToSetContextNewPriority_FunctionAddress, "ReturnValue");
		TryToSetContextNewPriority_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryToSetContextNewPriority_FunctionAddress, "ReturnValue");
		TryToSetContextNewPriority_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryToSetContextNewPriority_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TryToSetContextNewPriority_IsValid = TryToSetContextNewPriority_FunctionAddress != IntPtr.Zero && TryToSetContextNewPriority_PlayerController_IsValid && TryToSetContextNewPriority_Context_IsValid && TryToSetContextNewPriority_NewPriority_IsValid && TryToSetContextNewPriority_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:TryToSetContextNewPriority", TryToSetContextNewPriority_IsValid);
		SetUIOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetUIOnly");
		SetUIOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUIOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUIOnly_PlayerController_PropertyAddress, SetUIOnly_FunctionAddress, "PlayerController");
		SetUIOnly_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(SetUIOnly_FunctionAddress, "PlayerController");
		SetUIOnly_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUIOnly_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUIOnly_bNeedMouseCapture_PropertyAddress, SetUIOnly_FunctionAddress, "bNeedMouseCapture");
		SetUIOnly_bNeedMouseCapture_Offset = NativeReflectionCached.GetPropertyOffset(SetUIOnly_FunctionAddress, "bNeedMouseCapture");
		SetUIOnly_bNeedMouseCapture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUIOnly_FunctionAddress, "bNeedMouseCapture", Classes.FBoolProperty);
		SetUIOnly_IsValid = SetUIOnly_FunctionAddress != IntPtr.Zero && SetUIOnly_PlayerController_IsValid && SetUIOnly_bNeedMouseCapture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:SetUIOnly", SetUIOnly_IsValid);
		SetMouseCursorPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMouseCursorPosition");
		SetMouseCursorPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMouseCursorPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMouseCursorPosition_Position_PropertyAddress, SetMouseCursorPosition_FunctionAddress, "Position");
		SetMouseCursorPosition_Position_Offset = NativeReflectionCached.GetPropertyOffset(SetMouseCursorPosition_FunctionAddress, "Position");
		SetMouseCursorPosition_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMouseCursorPosition_FunctionAddress, "Position", Classes.FStructProperty);
		SetMouseCursorPosition_IsValid = SetMouseCursorPosition_FunctionAddress != IntPtr.Zero && SetMouseCursorPosition_Position_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:SetMouseCursorPosition", SetMouseCursorPosition_IsValid);
		SetIgnoreAllButtonKeyInput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetIgnoreAllButtonKeyInput");
		SetIgnoreAllButtonKeyInput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIgnoreAllButtonKeyInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIgnoreAllButtonKeyInput_WorldContext_PropertyAddress, SetIgnoreAllButtonKeyInput_FunctionAddress, "WorldContext");
		SetIgnoreAllButtonKeyInput_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(SetIgnoreAllButtonKeyInput_FunctionAddress, "WorldContext");
		SetIgnoreAllButtonKeyInput_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIgnoreAllButtonKeyInput_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIgnoreAllButtonKeyInput_IsIgnore_PropertyAddress, SetIgnoreAllButtonKeyInput_FunctionAddress, "IsIgnore");
		SetIgnoreAllButtonKeyInput_IsIgnore_Offset = NativeReflectionCached.GetPropertyOffset(SetIgnoreAllButtonKeyInput_FunctionAddress, "IsIgnore");
		SetIgnoreAllButtonKeyInput_IsIgnore_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIgnoreAllButtonKeyInput_FunctionAddress, "IsIgnore", Classes.FBoolProperty);
		SetIgnoreAllButtonKeyInput_IsValid = SetIgnoreAllButtonKeyInput_FunctionAddress != IntPtr.Zero && SetIgnoreAllButtonKeyInput_WorldContext_IsValid && SetIgnoreAllButtonKeyInput_IsIgnore_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:SetIgnoreAllButtonKeyInput", SetIgnoreAllButtonKeyInput_IsValid);
		SetGameOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetGameOnly");
		SetGameOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGameOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGameOnly_PlayerController_PropertyAddress, SetGameOnly_FunctionAddress, "PlayerController");
		SetGameOnly_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(SetGameOnly_FunctionAddress, "PlayerController");
		SetGameOnly_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGameOnly_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		SetGameOnly_IsValid = SetGameOnly_FunctionAddress != IntPtr.Zero && SetGameOnly_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:SetGameOnly", SetGameOnly_IsValid);
		SetCursorVisibility_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCursorVisibility");
		SetCursorVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCursorVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCursorVisibility_bDrawCursor_PropertyAddress, SetCursorVisibility_FunctionAddress, "bDrawCursor");
		SetCursorVisibility_bDrawCursor_Offset = NativeReflectionCached.GetPropertyOffset(SetCursorVisibility_FunctionAddress, "bDrawCursor");
		SetCursorVisibility_bDrawCursor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCursorVisibility_FunctionAddress, "bDrawCursor", Classes.FBoolProperty);
		SetCursorVisibility_IsValid = SetCursorVisibility_FunctionAddress != IntPtr.Zero && SetCursorVisibility_bDrawCursor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:SetCursorVisibility", SetCursorVisibility_IsValid);
		RequestRebuildControlMappings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestRebuildControlMappings");
		RequestRebuildControlMappings_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestRebuildControlMappings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestRebuildControlMappings_PlayerController_PropertyAddress, RequestRebuildControlMappings_FunctionAddress, "PlayerController");
		RequestRebuildControlMappings_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(RequestRebuildControlMappings_FunctionAddress, "PlayerController");
		RequestRebuildControlMappings_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestRebuildControlMappings_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestRebuildControlMappings_bForceImmediately_PropertyAddress, RequestRebuildControlMappings_FunctionAddress, "bForceImmediately");
		RequestRebuildControlMappings_bForceImmediately_Offset = NativeReflectionCached.GetPropertyOffset(RequestRebuildControlMappings_FunctionAddress, "bForceImmediately");
		RequestRebuildControlMappings_bForceImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestRebuildControlMappings_FunctionAddress, "bForceImmediately", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestRebuildControlMappings_bIgnoreAllPressedKeysUntilRelease_PropertyAddress, RequestRebuildControlMappings_FunctionAddress, "bIgnoreAllPressedKeysUntilRelease");
		RequestRebuildControlMappings_bIgnoreAllPressedKeysUntilRelease_Offset = NativeReflectionCached.GetPropertyOffset(RequestRebuildControlMappings_FunctionAddress, "bIgnoreAllPressedKeysUntilRelease");
		RequestRebuildControlMappings_bIgnoreAllPressedKeysUntilRelease_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestRebuildControlMappings_FunctionAddress, "bIgnoreAllPressedKeysUntilRelease", Classes.FBoolProperty);
		RequestRebuildControlMappings_IsValid = RequestRebuildControlMappings_FunctionAddress != IntPtr.Zero && RequestRebuildControlMappings_PlayerController_IsValid && RequestRebuildControlMappings_bForceImmediately_IsValid && RequestRebuildControlMappings_bIgnoreAllPressedKeysUntilRelease_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:RequestRebuildControlMappings", RequestRebuildControlMappings_IsValid);
		RemoveInputMappingContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveInputMappingContext");
		RemoveInputMappingContext_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveInputMappingContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveInputMappingContext_PlayerController_PropertyAddress, RemoveInputMappingContext_FunctionAddress, "PlayerController");
		RemoveInputMappingContext_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInputMappingContext_FunctionAddress, "PlayerController");
		RemoveInputMappingContext_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInputMappingContext_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveInputMappingContext_InputMappingContext_PropertyAddress, RemoveInputMappingContext_FunctionAddress, "InputMappingContext");
		RemoveInputMappingContext_InputMappingContext_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInputMappingContext_FunctionAddress, "InputMappingContext");
		RemoveInputMappingContext_InputMappingContext_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInputMappingContext_FunctionAddress, "InputMappingContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveInputMappingContext_bIgnoreAllPressedKeysUntilRelease_PropertyAddress, RemoveInputMappingContext_FunctionAddress, "bIgnoreAllPressedKeysUntilRelease");
		RemoveInputMappingContext_bIgnoreAllPressedKeysUntilRelease_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInputMappingContext_FunctionAddress, "bIgnoreAllPressedKeysUntilRelease");
		RemoveInputMappingContext_bIgnoreAllPressedKeysUntilRelease_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInputMappingContext_FunctionAddress, "bIgnoreAllPressedKeysUntilRelease", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveInputMappingContext_bForceImmediately_PropertyAddress, RemoveInputMappingContext_FunctionAddress, "bForceImmediately");
		RemoveInputMappingContext_bForceImmediately_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInputMappingContext_FunctionAddress, "bForceImmediately");
		RemoveInputMappingContext_bForceImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInputMappingContext_FunctionAddress, "bForceImmediately", Classes.FBoolProperty);
		RemoveInputMappingContext_IsValid = RemoveInputMappingContext_FunctionAddress != IntPtr.Zero && RemoveInputMappingContext_PlayerController_IsValid && RemoveInputMappingContext_InputMappingContext_IsValid && RemoveInputMappingContext_bIgnoreAllPressedKeysUntilRelease_IsValid && RemoveInputMappingContext_bForceImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:RemoveInputMappingContext", RemoveInputMappingContext_IsValid);
		RegisterInputTargetBinding_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterInputTargetBinding");
		RegisterInputTargetBinding_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterInputTargetBinding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterInputTargetBinding_InputTargetBindingObj_PropertyAddress, RegisterInputTargetBinding_FunctionAddress, "InputTargetBindingObj");
		RegisterInputTargetBinding_InputTargetBindingObj_Offset = NativeReflectionCached.GetPropertyOffset(RegisterInputTargetBinding_FunctionAddress, "InputTargetBindingObj");
		RegisterInputTargetBinding_InputTargetBindingObj_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterInputTargetBinding_FunctionAddress, "InputTargetBindingObj", Classes.FObjectProperty);
		RegisterInputTargetBinding_IsValid = RegisterInputTargetBinding_FunctionAddress != IntPtr.Zero && RegisterInputTargetBinding_InputTargetBindingObj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:RegisterInputTargetBinding", RegisterInputTargetBinding_IsValid);
		RegisterGSInputProc_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterGSInputProc");
		RegisterGSInputProc_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterGSInputProc_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterGSInputProc_WorldContext_PropertyAddress, RegisterGSInputProc_FunctionAddress, "WorldContext");
		RegisterGSInputProc_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(RegisterGSInputProc_FunctionAddress, "WorldContext");
		RegisterGSInputProc_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterGSInputProc_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterGSInputProc_Order_PropertyAddress, RegisterGSInputProc_FunctionAddress, "Order");
		RegisterGSInputProc_Order_Offset = NativeReflectionCached.GetPropertyOffset(RegisterGSInputProc_FunctionAddress, "Order");
		RegisterGSInputProc_Order_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterGSInputProc_FunctionAddress, "Order", Classes.FEnumProperty);
		RegisterGSInputProc_IsValid = RegisterGSInputProc_FunctionAddress != IntPtr.Zero && RegisterGSInputProc_WorldContext_IsValid && RegisterGSInputProc_Order_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:RegisterGSInputProc", RegisterGSInputProc_IsValid);
		QueryKeysMappedToAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QueryKeysMappedToAction");
		QueryKeysMappedToAction_ParamsSize = NativeReflection.GetFunctionParamsSize(QueryKeysMappedToAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QueryKeysMappedToAction_PlayerController_PropertyAddress, QueryKeysMappedToAction_FunctionAddress, "PlayerController");
		QueryKeysMappedToAction_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(QueryKeysMappedToAction_FunctionAddress, "PlayerController");
		QueryKeysMappedToAction_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryKeysMappedToAction_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryKeysMappedToAction_Action_PropertyAddress, QueryKeysMappedToAction_FunctionAddress, "Action");
		QueryKeysMappedToAction_Action_Offset = NativeReflectionCached.GetPropertyOffset(QueryKeysMappedToAction_FunctionAddress, "Action");
		QueryKeysMappedToAction_Action_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryKeysMappedToAction_FunctionAddress, "Action", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryKeysMappedToAction_ReturnValue_PropertyAddress, QueryKeysMappedToAction_FunctionAddress, "ReturnValue");
		QueryKeysMappedToAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QueryKeysMappedToAction_FunctionAddress, "ReturnValue");
		QueryKeysMappedToAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryKeysMappedToAction_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		QueryKeysMappedToAction_IsValid = QueryKeysMappedToAction_FunctionAddress != IntPtr.Zero && QueryKeysMappedToAction_PlayerController_IsValid && QueryKeysMappedToAction_Action_IsValid && QueryKeysMappedToAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:QueryKeysMappedToAction", QueryKeysMappedToAction_IsValid);
		QueryKeysByInputAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QueryKeysByInputAction");
		QueryKeysByInputAction_ParamsSize = NativeReflection.GetFunctionParamsSize(QueryKeysByInputAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QueryKeysByInputAction_MappingContext_PropertyAddress, QueryKeysByInputAction_FunctionAddress, "MappingContext");
		QueryKeysByInputAction_MappingContext_Offset = NativeReflectionCached.GetPropertyOffset(QueryKeysByInputAction_FunctionAddress, "MappingContext");
		QueryKeysByInputAction_MappingContext_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryKeysByInputAction_FunctionAddress, "MappingContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryKeysByInputAction_Action_PropertyAddress, QueryKeysByInputAction_FunctionAddress, "Action");
		QueryKeysByInputAction_Action_Offset = NativeReflectionCached.GetPropertyOffset(QueryKeysByInputAction_FunctionAddress, "Action");
		QueryKeysByInputAction_Action_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryKeysByInputAction_FunctionAddress, "Action", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryKeysByInputAction_ReturnValue_PropertyAddress, QueryKeysByInputAction_FunctionAddress, "ReturnValue");
		QueryKeysByInputAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QueryKeysByInputAction_FunctionAddress, "ReturnValue");
		QueryKeysByInputAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryKeysByInputAction_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		QueryKeysByInputAction_IsValid = QueryKeysByInputAction_FunctionAddress != IntPtr.Zero && QueryKeysByInputAction_MappingContext_IsValid && QueryKeysByInputAction_Action_IsValid && QueryKeysByInputAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:QueryKeysByInputAction", QueryKeysByInputAction_IsValid);
		IsConsoleActive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsConsoleActive");
		IsConsoleActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsConsoleActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsConsoleActive_WorldContext_PropertyAddress, IsConsoleActive_FunctionAddress, "WorldContext");
		IsConsoleActive_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(IsConsoleActive_FunctionAddress, "WorldContext");
		IsConsoleActive_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(IsConsoleActive_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsConsoleActive_ReturnValue_PropertyAddress, IsConsoleActive_FunctionAddress, "ReturnValue");
		IsConsoleActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsConsoleActive_FunctionAddress, "ReturnValue");
		IsConsoleActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsConsoleActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsConsoleActive_IsValid = IsConsoleActive_FunctionAddress != IntPtr.Zero && IsConsoleActive_WorldContext_IsValid && IsConsoleActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:IsConsoleActive", IsConsoleActive_IsValid);
		IsAppActive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsAppActive");
		IsAppActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAppActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAppActive_ReturnValue_PropertyAddress, IsAppActive_FunctionAddress, "ReturnValue");
		IsAppActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAppActive_FunctionAddress, "ReturnValue");
		IsAppActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAppActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAppActive_IsValid = IsAppActive_FunctionAddress != IntPtr.Zero && IsAppActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:IsAppActive", IsAppActive_IsValid);
		GetProductStringList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetProductStringList");
		GetProductStringList_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProductStringList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetProductStringList_ReturnValue_PropertyAddress, GetProductStringList_FunctionAddress, "ReturnValue");
		GetProductStringList_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetProductStringList_FunctionAddress, "ReturnValue");
		GetProductStringList_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProductStringList_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetProductStringList_IsValid = GetProductStringList_FunctionAddress != IntPtr.Zero && GetProductStringList_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetProductStringList", GetProductStringList_IsValid);
		GetMappingsInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMappingsInfo");
		GetMappingsInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMappingsInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMappingsInfo_MappingContext_PropertyAddress, GetMappingsInfo_FunctionAddress, "MappingContext");
		GetMappingsInfo_MappingContext_Offset = NativeReflectionCached.GetPropertyOffset(GetMappingsInfo_FunctionAddress, "MappingContext");
		GetMappingsInfo_MappingContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMappingsInfo_FunctionAddress, "MappingContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMappingsInfo_Actions_PropertyAddress, GetMappingsInfo_FunctionAddress, "Actions");
		GetMappingsInfo_Actions_Offset = NativeReflectionCached.GetPropertyOffset(GetMappingsInfo_FunctionAddress, "Actions");
		GetMappingsInfo_Actions_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMappingsInfo_FunctionAddress, "Actions", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMappingsInfo_Keys_PropertyAddress, GetMappingsInfo_FunctionAddress, "Keys");
		GetMappingsInfo_Keys_Offset = NativeReflectionCached.GetPropertyOffset(GetMappingsInfo_FunctionAddress, "Keys");
		GetMappingsInfo_Keys_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMappingsInfo_FunctionAddress, "Keys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMappingsInfo_ChordActions_PropertyAddress, GetMappingsInfo_FunctionAddress, "ChordActions");
		GetMappingsInfo_ChordActions_Offset = NativeReflectionCached.GetPropertyOffset(GetMappingsInfo_FunctionAddress, "ChordActions");
		GetMappingsInfo_ChordActions_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMappingsInfo_FunctionAddress, "ChordActions", Classes.FArrayProperty);
		GetMappingsInfo_IsValid = GetMappingsInfo_FunctionAddress != IntPtr.Zero && GetMappingsInfo_MappingContext_IsValid && GetMappingsInfo_Actions_IsValid && GetMappingsInfo_Keys_IsValid && GetMappingsInfo_ChordActions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetMappingsInfo", GetMappingsInfo_IsValid);
		GetMappableKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMappableKey");
		GetMappableKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMappableKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMappableKey_MappingContext_PropertyAddress, GetMappableKey_FunctionAddress, "MappingContext");
		GetMappableKey_MappingContext_Offset = NativeReflectionCached.GetPropertyOffset(GetMappableKey_FunctionAddress, "MappingContext");
		GetMappableKey_MappingContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMappableKey_FunctionAddress, "MappingContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMappableKey_ReturnValue_PropertyAddress, GetMappableKey_FunctionAddress, "ReturnValue");
		GetMappableKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMappableKey_FunctionAddress, "ReturnValue");
		GetMappableKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMappableKey_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetMappableKey_IsValid = GetMappableKey_FunctionAddress != IntPtr.Zero && GetMappableKey_MappingContext_IsValid && GetMappableKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetMappableKey", GetMappableKey_IsValid);
		GetLastInputType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLastInputType");
		GetLastInputType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastInputType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastInputType_WorldContext_PropertyAddress, GetLastInputType_FunctionAddress, "WorldContext");
		GetLastInputType_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetLastInputType_FunctionAddress, "WorldContext");
		GetLastInputType_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastInputType_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLastInputType_ReturnValue_PropertyAddress, GetLastInputType_FunctionAddress, "ReturnValue");
		GetLastInputType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastInputType_FunctionAddress, "ReturnValue");
		GetLastInputType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastInputType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetLastInputType_IsValid = GetLastInputType_FunctionAddress != IntPtr.Zero && GetLastInputType_WorldContext_IsValid && GetLastInputType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetLastInputType", GetLastInputType_IsValid);
		GetKeyByPointerEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetKeyByPointerEvent");
		GetKeyByPointerEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKeyByPointerEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKeyByPointerEvent_PointerEvent_PropertyAddress, GetKeyByPointerEvent_FunctionAddress, "PointerEvent");
		GetKeyByPointerEvent_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyByPointerEvent_FunctionAddress, "PointerEvent");
		GetKeyByPointerEvent_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyByPointerEvent_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKeyByPointerEvent_ReturnValue_PropertyAddress, GetKeyByPointerEvent_FunctionAddress, "ReturnValue");
		GetKeyByPointerEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyByPointerEvent_FunctionAddress, "ReturnValue");
		GetKeyByPointerEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyByPointerEvent_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetKeyByPointerEvent_IsValid = GetKeyByPointerEvent_FunctionAddress != IntPtr.Zero && GetKeyByPointerEvent_PointerEvent_IsValid && GetKeyByPointerEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetKeyByPointerEvent", GetKeyByPointerEvent_IsValid);
		GetKeyByKeyEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetKeyByKeyEvent");
		GetKeyByKeyEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKeyByKeyEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKeyByKeyEvent_KeyEvent_PropertyAddress, GetKeyByKeyEvent_FunctionAddress, "KeyEvent");
		GetKeyByKeyEvent_KeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyByKeyEvent_FunctionAddress, "KeyEvent");
		GetKeyByKeyEvent_KeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyByKeyEvent_FunctionAddress, "KeyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKeyByKeyEvent_ReturnValue_PropertyAddress, GetKeyByKeyEvent_FunctionAddress, "ReturnValue");
		GetKeyByKeyEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyByKeyEvent_FunctionAddress, "ReturnValue");
		GetKeyByKeyEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyByKeyEvent_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetKeyByKeyEvent_IsValid = GetKeyByKeyEvent_FunctionAddress != IntPtr.Zero && GetKeyByKeyEvent_KeyEvent_IsValid && GetKeyByKeyEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetKeyByKeyEvent", GetKeyByKeyEvent_IsValid);
		GetKeyByAnalogInputEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetKeyByAnalogInputEvent");
		GetKeyByAnalogInputEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKeyByAnalogInputEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKeyByAnalogInputEvent_AnalogInputEvent_PropertyAddress, GetKeyByAnalogInputEvent_FunctionAddress, "AnalogInputEvent");
		GetKeyByAnalogInputEvent_AnalogInputEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyByAnalogInputEvent_FunctionAddress, "AnalogInputEvent");
		GetKeyByAnalogInputEvent_AnalogInputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyByAnalogInputEvent_FunctionAddress, "AnalogInputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKeyByAnalogInputEvent_ReturnValue_PropertyAddress, GetKeyByAnalogInputEvent_FunctionAddress, "ReturnValue");
		GetKeyByAnalogInputEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyByAnalogInputEvent_FunctionAddress, "ReturnValue");
		GetKeyByAnalogInputEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyByAnalogInputEvent_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetKeyByAnalogInputEvent_IsValid = GetKeyByAnalogInputEvent_FunctionAddress != IntPtr.Zero && GetKeyByAnalogInputEvent_AnalogInputEvent_IsValid && GetKeyByAnalogInputEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetKeyByAnalogInputEvent", GetKeyByAnalogInputEvent_IsValid);
		GetInputSettingPreProc_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputSettingPreProc");
		GetInputSettingPreProc_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputSettingPreProc_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputSettingPreProc_WorldContext_PropertyAddress, GetInputSettingPreProc_FunctionAddress, "WorldContext");
		GetInputSettingPreProc_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetInputSettingPreProc_FunctionAddress, "WorldContext");
		GetInputSettingPreProc_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputSettingPreProc_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputSettingPreProc_ReturnValue_PropertyAddress, GetInputSettingPreProc_FunctionAddress, "ReturnValue");
		GetInputSettingPreProc_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputSettingPreProc_FunctionAddress, "ReturnValue");
		GetInputSettingPreProc_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputSettingPreProc_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetInputSettingPreProc_IsValid = GetInputSettingPreProc_FunctionAddress != IntPtr.Zero && GetInputSettingPreProc_WorldContext_IsValid && GetInputSettingPreProc_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetInputSettingPreProc", GetInputSettingPreProc_IsValid);
		GetInputPreProc_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputPreProc");
		GetInputPreProc_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputPreProc_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputPreProc_WorldContext_PropertyAddress, GetInputPreProc_FunctionAddress, "WorldContext");
		GetInputPreProc_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(GetInputPreProc_FunctionAddress, "WorldContext");
		GetInputPreProc_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputPreProc_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputPreProc_ReturnValue_PropertyAddress, GetInputPreProc_FunctionAddress, "ReturnValue");
		GetInputPreProc_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputPreProc_FunctionAddress, "ReturnValue");
		GetInputPreProc_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputPreProc_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetInputPreProc_IsValid = GetInputPreProc_FunctionAddress != IntPtr.Zero && GetInputPreProc_WorldContext_IsValid && GetInputPreProc_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetInputPreProc", GetInputPreProc_IsValid);
		GetInputDeviceTypes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputDeviceTypes");
		GetInputDeviceTypes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputDeviceTypes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputDeviceTypes_ReturnValue_PropertyAddress, GetInputDeviceTypes_FunctionAddress, "ReturnValue");
		GetInputDeviceTypes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputDeviceTypes_FunctionAddress, "ReturnValue");
		GetInputDeviceTypes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputDeviceTypes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetInputDeviceTypes_IsValid = GetInputDeviceTypes_FunctionAddress != IntPtr.Zero && GetInputDeviceTypes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetInputDeviceTypes", GetInputDeviceTypes_IsValid);
		GetInputActionValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputActionValue");
		GetInputActionValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputActionValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputActionValue_PlayerController_PropertyAddress, GetInputActionValue_FunctionAddress, "PlayerController");
		GetInputActionValue_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetInputActionValue_FunctionAddress, "PlayerController");
		GetInputActionValue_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputActionValue_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputActionValue_Action_PropertyAddress, GetInputActionValue_FunctionAddress, "Action");
		GetInputActionValue_Action_Offset = NativeReflectionCached.GetPropertyOffset(GetInputActionValue_FunctionAddress, "Action");
		GetInputActionValue_Action_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputActionValue_FunctionAddress, "Action", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputActionValue_ReturnValue_PropertyAddress, GetInputActionValue_FunctionAddress, "ReturnValue");
		GetInputActionValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputActionValue_FunctionAddress, "ReturnValue");
		GetInputActionValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputActionValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetInputActionValue_IsValid = GetInputActionValue_FunctionAddress != IntPtr.Zero && GetInputActionValue_PlayerController_IsValid && GetInputActionValue_Action_IsValid && GetInputActionValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetInputActionValue", GetInputActionValue_IsValid);
		GetGamepadDeadZoneThreshold_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGamepadDeadZoneThreshold");
		GetGamepadDeadZoneThreshold_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGamepadDeadZoneThreshold_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGamepadDeadZoneThreshold_ReturnValue_PropertyAddress, GetGamepadDeadZoneThreshold_FunctionAddress, "ReturnValue");
		GetGamepadDeadZoneThreshold_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGamepadDeadZoneThreshold_FunctionAddress, "ReturnValue");
		GetGamepadDeadZoneThreshold_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGamepadDeadZoneThreshold_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetGamepadDeadZoneThreshold_IsValid = GetGamepadDeadZoneThreshold_FunctionAddress != IntPtr.Zero && GetGamepadDeadZoneThreshold_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetGamepadDeadZoneThreshold", GetGamepadDeadZoneThreshold_IsValid);
		GetGamepadControllerName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGamepadControllerName");
		GetGamepadControllerName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGamepadControllerName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGamepadControllerName_ControllerId_PropertyAddress, GetGamepadControllerName_FunctionAddress, "ControllerId");
		GetGamepadControllerName_ControllerId_Offset = NativeReflectionCached.GetPropertyOffset(GetGamepadControllerName_FunctionAddress, "ControllerId");
		GetGamepadControllerName_ControllerId_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGamepadControllerName_FunctionAddress, "ControllerId", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGamepadControllerName_ReturnValue_PropertyAddress, GetGamepadControllerName_FunctionAddress, "ReturnValue");
		GetGamepadControllerName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGamepadControllerName_FunctionAddress, "ReturnValue");
		GetGamepadControllerName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGamepadControllerName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetGamepadControllerName_IsValid = GetGamepadControllerName_FunctionAddress != IntPtr.Zero && GetGamepadControllerName_ControllerId_IsValid && GetGamepadControllerName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetGamepadControllerName", GetGamepadControllerName_IsValid);
		GetDebugEventAccumulatorThisTick_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDebugEventAccumulatorThisTick");
		GetDebugEventAccumulatorThisTick_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDebugEventAccumulatorThisTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDebugEventAccumulatorThisTick_PlayerController_PropertyAddress, GetDebugEventAccumulatorThisTick_FunctionAddress, "PlayerController");
		GetDebugEventAccumulatorThisTick_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetDebugEventAccumulatorThisTick_FunctionAddress, "PlayerController");
		GetDebugEventAccumulatorThisTick_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDebugEventAccumulatorThisTick_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDebugEventAccumulatorThisTick_Action_PropertyAddress, GetDebugEventAccumulatorThisTick_FunctionAddress, "Action");
		GetDebugEventAccumulatorThisTick_Action_Offset = NativeReflectionCached.GetPropertyOffset(GetDebugEventAccumulatorThisTick_FunctionAddress, "Action");
		GetDebugEventAccumulatorThisTick_Action_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDebugEventAccumulatorThisTick_FunctionAddress, "Action", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDebugEventAccumulatorThisTick_IsReleasedEvent_PropertyAddress, GetDebugEventAccumulatorThisTick_FunctionAddress, "IsReleasedEvent");
		GetDebugEventAccumulatorThisTick_IsReleasedEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetDebugEventAccumulatorThisTick_FunctionAddress, "IsReleasedEvent");
		GetDebugEventAccumulatorThisTick_IsReleasedEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDebugEventAccumulatorThisTick_FunctionAddress, "IsReleasedEvent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDebugEventAccumulatorThisTick_ReturnValue_PropertyAddress, GetDebugEventAccumulatorThisTick_FunctionAddress, "ReturnValue");
		GetDebugEventAccumulatorThisTick_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDebugEventAccumulatorThisTick_FunctionAddress, "ReturnValue");
		GetDebugEventAccumulatorThisTick_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDebugEventAccumulatorThisTick_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetDebugEventAccumulatorThisTick_IsValid = GetDebugEventAccumulatorThisTick_FunctionAddress != IntPtr.Zero && GetDebugEventAccumulatorThisTick_PlayerController_IsValid && GetDebugEventAccumulatorThisTick_Action_IsValid && GetDebugEventAccumulatorThisTick_IsReleasedEvent_IsValid && GetDebugEventAccumulatorThisTick_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetDebugEventAccumulatorThisTick", GetDebugEventAccumulatorThisTick_IsValid);
		GetConflictChordInputAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetConflictChordInputAction");
		GetConflictChordInputAction_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConflictChordInputAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConflictChordInputAction_PrimaryChordAction_PropertyAddress, GetConflictChordInputAction_FunctionAddress, "PrimaryChordAction");
		GetConflictChordInputAction_PrimaryChordAction_Offset = NativeReflectionCached.GetPropertyOffset(GetConflictChordInputAction_FunctionAddress, "PrimaryChordAction");
		GetConflictChordInputAction_PrimaryChordAction_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConflictChordInputAction_FunctionAddress, "PrimaryChordAction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConflictChordInputAction_Contexts_PropertyAddress, GetConflictChordInputAction_FunctionAddress, "Contexts");
		GetConflictChordInputAction_Contexts_Offset = NativeReflectionCached.GetPropertyOffset(GetConflictChordInputAction_FunctionAddress, "Contexts");
		GetConflictChordInputAction_Contexts_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConflictChordInputAction_FunctionAddress, "Contexts", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConflictChordInputAction_PrimaryConflictActions_PropertyAddress, GetConflictChordInputAction_FunctionAddress, "PrimaryConflictActions");
		GetConflictChordInputAction_PrimaryConflictActions_Offset = NativeReflectionCached.GetPropertyOffset(GetConflictChordInputAction_FunctionAddress, "PrimaryConflictActions");
		GetConflictChordInputAction_PrimaryConflictActions_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConflictChordInputAction_FunctionAddress, "PrimaryConflictActions", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConflictChordInputAction_SecondaryConflictActions_PropertyAddress, GetConflictChordInputAction_FunctionAddress, "SecondaryConflictActions");
		GetConflictChordInputAction_SecondaryConflictActions_Offset = NativeReflectionCached.GetPropertyOffset(GetConflictChordInputAction_FunctionAddress, "SecondaryConflictActions");
		GetConflictChordInputAction_SecondaryConflictActions_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConflictChordInputAction_FunctionAddress, "SecondaryConflictActions", Classes.FArrayProperty);
		GetConflictChordInputAction_IsValid = GetConflictChordInputAction_FunctionAddress != IntPtr.Zero && GetConflictChordInputAction_PrimaryChordAction_IsValid && GetConflictChordInputAction_Contexts_IsValid && GetConflictChordInputAction_PrimaryConflictActions_IsValid && GetConflictChordInputAction_SecondaryConflictActions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetConflictChordInputAction", GetConflictChordInputAction_IsValid);
		GetChordInputAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetChordInputAction");
		GetChordInputAction_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChordInputAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChordInputAction_InputMappingContext_PropertyAddress, GetChordInputAction_FunctionAddress, "InputMappingContext");
		GetChordInputAction_InputMappingContext_Offset = NativeReflectionCached.GetPropertyOffset(GetChordInputAction_FunctionAddress, "InputMappingContext");
		GetChordInputAction_InputMappingContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChordInputAction_FunctionAddress, "InputMappingContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChordInputAction_ReturnValue_PropertyAddress, GetChordInputAction_FunctionAddress, "ReturnValue");
		GetChordInputAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChordInputAction_FunctionAddress, "ReturnValue");
		GetChordInputAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChordInputAction_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetChordInputAction_IsValid = GetChordInputAction_FunctionAddress != IntPtr.Zero && GetChordInputAction_InputMappingContext_IsValid && GetChordInputAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetChordInputAction", GetChordInputAction_IsValid);
		GetActionNamesFromInputMappingContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActionNamesFromInputMappingContext");
		GetActionNamesFromInputMappingContext_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActionNamesFromInputMappingContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActionNamesFromInputMappingContext_InputMappingContext_PropertyAddress, GetActionNamesFromInputMappingContext_FunctionAddress, "InputMappingContext");
		GetActionNamesFromInputMappingContext_InputMappingContext_Offset = NativeReflectionCached.GetPropertyOffset(GetActionNamesFromInputMappingContext_FunctionAddress, "InputMappingContext");
		GetActionNamesFromInputMappingContext_InputMappingContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActionNamesFromInputMappingContext_FunctionAddress, "InputMappingContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActionNamesFromInputMappingContext_ReturnValue_PropertyAddress, GetActionNamesFromInputMappingContext_FunctionAddress, "ReturnValue");
		GetActionNamesFromInputMappingContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActionNamesFromInputMappingContext_FunctionAddress, "ReturnValue");
		GetActionNamesFromInputMappingContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActionNamesFromInputMappingContext_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetActionNamesFromInputMappingContext_IsValid = GetActionNamesFromInputMappingContext_FunctionAddress != IntPtr.Zero && GetActionNamesFromInputMappingContext_InputMappingContext_IsValid && GetActionNamesFromInputMappingContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:GetActionNamesFromInputMappingContext", GetActionNamesFromInputMappingContext_IsValid);
		FlushPressedInput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FlushPressedInput");
		FlushPressedInput_ParamsSize = NativeReflection.GetFunctionParamsSize(FlushPressedInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FlushPressedInput_PlayerController_PropertyAddress, FlushPressedInput_FunctionAddress, "PlayerController");
		FlushPressedInput_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(FlushPressedInput_FunctionAddress, "PlayerController");
		FlushPressedInput_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(FlushPressedInput_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		FlushPressedInput_IsValid = FlushPressedInput_FunctionAddress != IntPtr.Zero && FlushPressedInput_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:FlushPressedInput", FlushPressedInput_IsValid);
		FindKeyByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindKeyByName");
		FindKeyByName_ParamsSize = NativeReflection.GetFunctionParamsSize(FindKeyByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindKeyByName_KeyName_PropertyAddress, FindKeyByName_FunctionAddress, "KeyName");
		FindKeyByName_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(FindKeyByName_FunctionAddress, "KeyName");
		FindKeyByName_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindKeyByName_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindKeyByName_ReturnValue_PropertyAddress, FindKeyByName_FunctionAddress, "ReturnValue");
		FindKeyByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindKeyByName_FunctionAddress, "ReturnValue");
		FindKeyByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindKeyByName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindKeyByName_IsValid = FindKeyByName_FunctionAddress != IntPtr.Zero && FindKeyByName_KeyName_IsValid && FindKeyByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:FindKeyByName", FindKeyByName_IsValid);
		CustomizeInputMappingContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CustomizeInputMappingContext");
		CustomizeInputMappingContext_ParamsSize = NativeReflection.GetFunctionParamsSize(CustomizeInputMappingContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CustomizeInputMappingContext_MappingContext_PropertyAddress, CustomizeInputMappingContext_FunctionAddress, "MappingContext");
		CustomizeInputMappingContext_MappingContext_Offset = NativeReflectionCached.GetPropertyOffset(CustomizeInputMappingContext_FunctionAddress, "MappingContext");
		CustomizeInputMappingContext_MappingContext_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomizeInputMappingContext_FunctionAddress, "MappingContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomizeInputMappingContext_MappableName_PropertyAddress, CustomizeInputMappingContext_FunctionAddress, "MappableName");
		CustomizeInputMappingContext_MappableName_Offset = NativeReflectionCached.GetPropertyOffset(CustomizeInputMappingContext_FunctionAddress, "MappableName");
		CustomizeInputMappingContext_MappableName_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomizeInputMappingContext_FunctionAddress, "MappableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomizeInputMappingContext_KeyName_PropertyAddress, CustomizeInputMappingContext_FunctionAddress, "KeyName");
		CustomizeInputMappingContext_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(CustomizeInputMappingContext_FunctionAddress, "KeyName");
		CustomizeInputMappingContext_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomizeInputMappingContext_FunctionAddress, "KeyName", Classes.FNameProperty);
		CustomizeInputMappingContext_IsValid = CustomizeInputMappingContext_FunctionAddress != IntPtr.Zero && CustomizeInputMappingContext_MappingContext_IsValid && CustomizeInputMappingContext_MappableName_IsValid && CustomizeInputMappingContext_KeyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:CustomizeInputMappingContext", CustomizeInputMappingContext_IsValid);
		ClearAllInputMappingContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearAllInputMappingContext");
		ClearAllInputMappingContext_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAllInputMappingContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearAllInputMappingContext_PlayerController_PropertyAddress, ClearAllInputMappingContext_FunctionAddress, "PlayerController");
		ClearAllInputMappingContext_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(ClearAllInputMappingContext_FunctionAddress, "PlayerController");
		ClearAllInputMappingContext_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearAllInputMappingContext_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		ClearAllInputMappingContext_IsValid = ClearAllInputMappingContext_FunctionAddress != IntPtr.Zero && ClearAllInputMappingContext_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:ClearAllInputMappingContext", ClearAllInputMappingContext_IsValid);
		BindAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BindAction");
		BindAction_ParamsSize = NativeReflection.GetFunctionParamsSize(BindAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BindAction_InputComponent_PropertyAddress, BindAction_FunctionAddress, "InputComponent");
		BindAction_InputComponent_Offset = NativeReflectionCached.GetPropertyOffset(BindAction_FunctionAddress, "InputComponent");
		BindAction_InputComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(BindAction_FunctionAddress, "InputComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BindAction_InputAction_PropertyAddress, BindAction_FunctionAddress, "InputAction");
		BindAction_InputAction_Offset = NativeReflectionCached.GetPropertyOffset(BindAction_FunctionAddress, "InputAction");
		BindAction_InputAction_IsValid = NativeReflectionCached.ValidatePropertyClass(BindAction_FunctionAddress, "InputAction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BindAction_TriggerEvent_PropertyAddress, BindAction_FunctionAddress, "TriggerEvent");
		BindAction_TriggerEvent_Offset = NativeReflectionCached.GetPropertyOffset(BindAction_FunctionAddress, "TriggerEvent");
		BindAction_TriggerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(BindAction_FunctionAddress, "TriggerEvent", Classes.FEnumProperty);
		BindAction_IsValid = BindAction_FunctionAddress != IntPtr.Zero && BindAction_InputComponent_IsValid && BindAction_InputAction_IsValid && BindAction_TriggerEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:BindAction", BindAction_IsValid);
		AddPlayerMappedKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddPlayerMappedKey");
		AddPlayerMappedKey_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPlayerMappedKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddPlayerMappedKey_PlayerController_PropertyAddress, AddPlayerMappedKey_FunctionAddress, "PlayerController");
		AddPlayerMappedKey_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(AddPlayerMappedKey_FunctionAddress, "PlayerController");
		AddPlayerMappedKey_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPlayerMappedKey_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPlayerMappedKey_MappingName_PropertyAddress, AddPlayerMappedKey_FunctionAddress, "MappingName");
		AddPlayerMappedKey_MappingName_Offset = NativeReflectionCached.GetPropertyOffset(AddPlayerMappedKey_FunctionAddress, "MappingName");
		AddPlayerMappedKey_MappingName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPlayerMappedKey_FunctionAddress, "MappingName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPlayerMappedKey_NewKey_PropertyAddress, AddPlayerMappedKey_FunctionAddress, "NewKey");
		AddPlayerMappedKey_NewKey_Offset = NativeReflectionCached.GetPropertyOffset(AddPlayerMappedKey_FunctionAddress, "NewKey");
		AddPlayerMappedKey_NewKey_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPlayerMappedKey_FunctionAddress, "NewKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPlayerMappedKey_Options_PropertyAddress, AddPlayerMappedKey_FunctionAddress, "Options");
		AddPlayerMappedKey_Options_Offset = NativeReflectionCached.GetPropertyOffset(AddPlayerMappedKey_FunctionAddress, "Options");
		AddPlayerMappedKey_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPlayerMappedKey_FunctionAddress, "Options", Classes.FStructProperty);
		AddPlayerMappedKey_IsValid = AddPlayerMappedKey_FunctionAddress != IntPtr.Zero && AddPlayerMappedKey_PlayerController_IsValid && AddPlayerMappedKey_MappingName_IsValid && AddPlayerMappedKey_NewKey_IsValid && AddPlayerMappedKey_Options_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:AddPlayerMappedKey", AddPlayerMappedKey_IsValid);
		AddInputMappingContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddInputMappingContext");
		AddInputMappingContext_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInputMappingContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddInputMappingContext_PlayerController_PropertyAddress, AddInputMappingContext_FunctionAddress, "PlayerController");
		AddInputMappingContext_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(AddInputMappingContext_FunctionAddress, "PlayerController");
		AddInputMappingContext_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInputMappingContext_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInputMappingContext_InputMappingContext_PropertyAddress, AddInputMappingContext_FunctionAddress, "InputMappingContext");
		AddInputMappingContext_InputMappingContext_Offset = NativeReflectionCached.GetPropertyOffset(AddInputMappingContext_FunctionAddress, "InputMappingContext");
		AddInputMappingContext_InputMappingContext_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInputMappingContext_FunctionAddress, "InputMappingContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInputMappingContext_Priority_PropertyAddress, AddInputMappingContext_FunctionAddress, "Priority");
		AddInputMappingContext_Priority_Offset = NativeReflectionCached.GetPropertyOffset(AddInputMappingContext_FunctionAddress, "Priority");
		AddInputMappingContext_Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInputMappingContext_FunctionAddress, "Priority", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInputMappingContext_bIgnoreAllPressedKeysUntilRelease_PropertyAddress, AddInputMappingContext_FunctionAddress, "bIgnoreAllPressedKeysUntilRelease");
		AddInputMappingContext_bIgnoreAllPressedKeysUntilRelease_Offset = NativeReflectionCached.GetPropertyOffset(AddInputMappingContext_FunctionAddress, "bIgnoreAllPressedKeysUntilRelease");
		AddInputMappingContext_bIgnoreAllPressedKeysUntilRelease_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInputMappingContext_FunctionAddress, "bIgnoreAllPressedKeysUntilRelease", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInputMappingContext_bForceImmediately_PropertyAddress, AddInputMappingContext_FunctionAddress, "bForceImmediately");
		AddInputMappingContext_bForceImmediately_Offset = NativeReflectionCached.GetPropertyOffset(AddInputMappingContext_FunctionAddress, "bForceImmediately");
		AddInputMappingContext_bForceImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInputMappingContext_FunctionAddress, "bForceImmediately", Classes.FBoolProperty);
		AddInputMappingContext_IsValid = AddInputMappingContext_FunctionAddress != IntPtr.Zero && AddInputMappingContext_PlayerController_IsValid && AddInputMappingContext_InputMappingContext_IsValid && AddInputMappingContext_Priority_IsValid && AddInputMappingContext_bIgnoreAllPressedKeysUntilRelease_IsValid && AddInputMappingContext_bForceImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSInput.GSE_InputFuncLib:AddInputMappingContext", AddInputMappingContext_IsValid);
	}
}
