using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AnimationCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigHierarchy", "ControlRig", UnrealModuleType.EnginePlugin)]
public class URigHierarchy : UObject
{
	private static IntPtr classAddress;

	private static bool SwitchToWorldSpace_IsValid;

	private static IntPtr SwitchToWorldSpace_FunctionAddress;

	private static int SwitchToWorldSpace_ParamsSize;

	private static bool SwitchToWorldSpace_InChild_IsValid;

	private static FFieldAddress SwitchToWorldSpace_InChild_PropertyAddress;

	private static int SwitchToWorldSpace_InChild_Offset;

	private static bool SwitchToWorldSpace_bInitial_IsValid;

	private static FFieldAddress SwitchToWorldSpace_bInitial_PropertyAddress;

	private static int SwitchToWorldSpace_bInitial_Offset;

	private static bool SwitchToWorldSpace_bAffectChildren_IsValid;

	private static FFieldAddress SwitchToWorldSpace_bAffectChildren_PropertyAddress;

	private static int SwitchToWorldSpace_bAffectChildren_Offset;

	private static bool SwitchToWorldSpace_ReturnValue_IsValid;

	private static FFieldAddress SwitchToWorldSpace_ReturnValue_PropertyAddress;

	private static int SwitchToWorldSpace_ReturnValue_Offset;

	private static bool SwitchToParent_IsValid;

	private static IntPtr SwitchToParent_FunctionAddress;

	private static int SwitchToParent_ParamsSize;

	private static bool SwitchToParent_InChild_IsValid;

	private static FFieldAddress SwitchToParent_InChild_PropertyAddress;

	private static int SwitchToParent_InChild_Offset;

	private static bool SwitchToParent_InParent_IsValid;

	private static FFieldAddress SwitchToParent_InParent_PropertyAddress;

	private static int SwitchToParent_InParent_Offset;

	private static bool SwitchToParent_bInitial_IsValid;

	private static FFieldAddress SwitchToParent_bInitial_PropertyAddress;

	private static int SwitchToParent_bInitial_Offset;

	private static bool SwitchToParent_bAffectChildren_IsValid;

	private static FFieldAddress SwitchToParent_bAffectChildren_PropertyAddress;

	private static int SwitchToParent_bAffectChildren_Offset;

	private static bool SwitchToParent_ReturnValue_IsValid;

	private static FFieldAddress SwitchToParent_ReturnValue_PropertyAddress;

	private static int SwitchToParent_ReturnValue_Offset;

	private static bool SwitchToDefaultParent_IsValid;

	private static IntPtr SwitchToDefaultParent_FunctionAddress;

	private static int SwitchToDefaultParent_ParamsSize;

	private static bool SwitchToDefaultParent_InChild_IsValid;

	private static FFieldAddress SwitchToDefaultParent_InChild_PropertyAddress;

	private static int SwitchToDefaultParent_InChild_Offset;

	private static bool SwitchToDefaultParent_bInitial_IsValid;

	private static FFieldAddress SwitchToDefaultParent_bInitial_PropertyAddress;

	private static int SwitchToDefaultParent_bInitial_Offset;

	private static bool SwitchToDefaultParent_bAffectChildren_IsValid;

	private static FFieldAddress SwitchToDefaultParent_bAffectChildren_PropertyAddress;

	private static int SwitchToDefaultParent_bAffectChildren_Offset;

	private static bool SwitchToDefaultParent_ReturnValue_IsValid;

	private static FFieldAddress SwitchToDefaultParent_ReturnValue_PropertyAddress;

	private static int SwitchToDefaultParent_ReturnValue_Offset;

	private static bool SortKeys_IsValid;

	private static IntPtr SortKeys_FunctionAddress;

	private static int SortKeys_ParamsSize;

	private static bool SortKeys_InKeys_IsValid;

	private static FFieldAddress SortKeys_InKeys_PropertyAddress;

	private static int SortKeys_InKeys_Offset;

	private static bool SortKeys_ReturnValue_IsValid;

	private static FFieldAddress SortKeys_ReturnValue_PropertyAddress;

	private static int SortKeys_ReturnValue_Offset;

	private static bool SetPose_IsValid;

	private static IntPtr SetPose_FunctionAddress;

	private static int SetPose_ParamsSize;

	private static bool SetPose_InPose_IsValid;

	private static FFieldAddress SetPose_InPose_PropertyAddress;

	private static int SetPose_InPose_Offset;

	private static bool SetParentWeightArray_IsValid;

	private static IntPtr SetParentWeightArray_FunctionAddress;

	private static int SetParentWeightArray_ParamsSize;

	private static bool SetParentWeightArray_InChild_IsValid;

	private static FFieldAddress SetParentWeightArray_InChild_PropertyAddress;

	private static int SetParentWeightArray_InChild_Offset;

	private static bool SetParentWeightArray_InWeights_IsValid;

	private static FFieldAddress SetParentWeightArray_InWeights_PropertyAddress;

	private static int SetParentWeightArray_InWeights_Offset;

	private static bool SetParentWeightArray_bInitial_IsValid;

	private static FFieldAddress SetParentWeightArray_bInitial_PropertyAddress;

	private static int SetParentWeightArray_bInitial_Offset;

	private static bool SetParentWeightArray_bAffectChildren_IsValid;

	private static FFieldAddress SetParentWeightArray_bAffectChildren_PropertyAddress;

	private static int SetParentWeightArray_bAffectChildren_Offset;

	private static bool SetParentWeightArray_ReturnValue_IsValid;

	private static FFieldAddress SetParentWeightArray_ReturnValue_PropertyAddress;

	private static int SetParentWeightArray_ReturnValue_Offset;

	private static bool SetParentWeight_IsValid;

	private static IntPtr SetParentWeight_FunctionAddress;

	private static int SetParentWeight_ParamsSize;

	private static bool SetParentWeight_InChild_IsValid;

	private static FFieldAddress SetParentWeight_InChild_PropertyAddress;

	private static int SetParentWeight_InChild_Offset;

	private static bool SetParentWeight_InParent_IsValid;

	private static FFieldAddress SetParentWeight_InParent_PropertyAddress;

	private static int SetParentWeight_InParent_Offset;

	private static bool SetParentWeight_InWeight_IsValid;

	private static FFieldAddress SetParentWeight_InWeight_PropertyAddress;

	private static int SetParentWeight_InWeight_Offset;

	private static bool SetParentWeight_bInitial_IsValid;

	private static FFieldAddress SetParentWeight_bInitial_PropertyAddress;

	private static int SetParentWeight_bInitial_Offset;

	private static bool SetParentWeight_bAffectChildren_IsValid;

	private static FFieldAddress SetParentWeight_bAffectChildren_PropertyAddress;

	private static int SetParentWeight_bAffectChildren_Offset;

	private static bool SetParentWeight_ReturnValue_IsValid;

	private static FFieldAddress SetParentWeight_ReturnValue_PropertyAddress;

	private static int SetParentWeight_ReturnValue_Offset;

	private static bool SetLocalTransformByIndex_IsValid;

	private static IntPtr SetLocalTransformByIndex_FunctionAddress;

	private static int SetLocalTransformByIndex_ParamsSize;

	private static bool SetLocalTransformByIndex_InElementIndex_IsValid;

	private static FFieldAddress SetLocalTransformByIndex_InElementIndex_PropertyAddress;

	private static int SetLocalTransformByIndex_InElementIndex_Offset;

	private static bool SetLocalTransformByIndex_InTransform_IsValid;

	private static FFieldAddress SetLocalTransformByIndex_InTransform_PropertyAddress;

	private static int SetLocalTransformByIndex_InTransform_Offset;

	private static bool SetLocalTransformByIndex_bInitial_IsValid;

	private static FFieldAddress SetLocalTransformByIndex_bInitial_PropertyAddress;

	private static int SetLocalTransformByIndex_bInitial_Offset;

	private static bool SetLocalTransformByIndex_bAffectChildren_IsValid;

	private static FFieldAddress SetLocalTransformByIndex_bAffectChildren_PropertyAddress;

	private static int SetLocalTransformByIndex_bAffectChildren_Offset;

	private static bool SetLocalTransformByIndex_bSetupUndo_IsValid;

	private static FFieldAddress SetLocalTransformByIndex_bSetupUndo_PropertyAddress;

	private static int SetLocalTransformByIndex_bSetupUndo_Offset;

	private static bool SetLocalTransformByIndex_bPrintPythonCommands_IsValid;

	private static FFieldAddress SetLocalTransformByIndex_bPrintPythonCommands_PropertyAddress;

	private static int SetLocalTransformByIndex_bPrintPythonCommands_Offset;

	private static bool SetLocalTransform_IsValid;

	private static IntPtr SetLocalTransform_FunctionAddress;

	private static int SetLocalTransform_ParamsSize;

	private static bool SetLocalTransform_InKey_IsValid;

	private static FFieldAddress SetLocalTransform_InKey_PropertyAddress;

	private static int SetLocalTransform_InKey_Offset;

	private static bool SetLocalTransform_InTransform_IsValid;

	private static FFieldAddress SetLocalTransform_InTransform_PropertyAddress;

	private static int SetLocalTransform_InTransform_Offset;

	private static bool SetLocalTransform_bInitial_IsValid;

	private static FFieldAddress SetLocalTransform_bInitial_PropertyAddress;

	private static int SetLocalTransform_bInitial_Offset;

	private static bool SetLocalTransform_bAffectChildren_IsValid;

	private static FFieldAddress SetLocalTransform_bAffectChildren_PropertyAddress;

	private static int SetLocalTransform_bAffectChildren_Offset;

	private static bool SetLocalTransform_bSetupUndo_IsValid;

	private static FFieldAddress SetLocalTransform_bSetupUndo_PropertyAddress;

	private static int SetLocalTransform_bSetupUndo_Offset;

	private static bool SetLocalTransform_bPrintPythonCommands_IsValid;

	private static FFieldAddress SetLocalTransform_bPrintPythonCommands_PropertyAddress;

	private static int SetLocalTransform_bPrintPythonCommands_Offset;

	private static bool SetGlobalTransformByIndex_IsValid;

	private static IntPtr SetGlobalTransformByIndex_FunctionAddress;

	private static int SetGlobalTransformByIndex_ParamsSize;

	private static bool SetGlobalTransformByIndex_InElementIndex_IsValid;

	private static FFieldAddress SetGlobalTransformByIndex_InElementIndex_PropertyAddress;

	private static int SetGlobalTransformByIndex_InElementIndex_Offset;

	private static bool SetGlobalTransformByIndex_InTransform_IsValid;

	private static FFieldAddress SetGlobalTransformByIndex_InTransform_PropertyAddress;

	private static int SetGlobalTransformByIndex_InTransform_Offset;

	private static bool SetGlobalTransformByIndex_bInitial_IsValid;

	private static FFieldAddress SetGlobalTransformByIndex_bInitial_PropertyAddress;

	private static int SetGlobalTransformByIndex_bInitial_Offset;

	private static bool SetGlobalTransformByIndex_bAffectChildren_IsValid;

	private static FFieldAddress SetGlobalTransformByIndex_bAffectChildren_PropertyAddress;

	private static int SetGlobalTransformByIndex_bAffectChildren_Offset;

	private static bool SetGlobalTransformByIndex_bSetupUndo_IsValid;

	private static FFieldAddress SetGlobalTransformByIndex_bSetupUndo_PropertyAddress;

	private static int SetGlobalTransformByIndex_bSetupUndo_Offset;

	private static bool SetGlobalTransform_IsValid;

	private static IntPtr SetGlobalTransform_FunctionAddress;

	private static int SetGlobalTransform_ParamsSize;

	private static bool SetGlobalTransform_InKey_IsValid;

	private static FFieldAddress SetGlobalTransform_InKey_PropertyAddress;

	private static int SetGlobalTransform_InKey_Offset;

	private static bool SetGlobalTransform_InTransform_IsValid;

	private static FFieldAddress SetGlobalTransform_InTransform_PropertyAddress;

	private static int SetGlobalTransform_InTransform_Offset;

	private static bool SetGlobalTransform_bInitial_IsValid;

	private static FFieldAddress SetGlobalTransform_bInitial_PropertyAddress;

	private static int SetGlobalTransform_bInitial_Offset;

	private static bool SetGlobalTransform_bAffectChildren_IsValid;

	private static FFieldAddress SetGlobalTransform_bAffectChildren_PropertyAddress;

	private static int SetGlobalTransform_bAffectChildren_Offset;

	private static bool SetGlobalTransform_bSetupUndo_IsValid;

	private static FFieldAddress SetGlobalTransform_bSetupUndo_PropertyAddress;

	private static int SetGlobalTransform_bSetupUndo_Offset;

	private static bool SetCurveValueByIndex_IsValid;

	private static IntPtr SetCurveValueByIndex_FunctionAddress;

	private static int SetCurveValueByIndex_ParamsSize;

	private static bool SetCurveValueByIndex_InElementIndex_IsValid;

	private static FFieldAddress SetCurveValueByIndex_InElementIndex_PropertyAddress;

	private static int SetCurveValueByIndex_InElementIndex_Offset;

	private static bool SetCurveValueByIndex_InValue_IsValid;

	private static FFieldAddress SetCurveValueByIndex_InValue_PropertyAddress;

	private static int SetCurveValueByIndex_InValue_Offset;

	private static bool SetCurveValueByIndex_bSetupUndo_IsValid;

	private static FFieldAddress SetCurveValueByIndex_bSetupUndo_PropertyAddress;

	private static int SetCurveValueByIndex_bSetupUndo_Offset;

	private static bool SetCurveValue_IsValid;

	private static IntPtr SetCurveValue_FunctionAddress;

	private static int SetCurveValue_ParamsSize;

	private static bool SetCurveValue_InKey_IsValid;

	private static FFieldAddress SetCurveValue_InKey_PropertyAddress;

	private static int SetCurveValue_InKey_Offset;

	private static bool SetCurveValue_InValue_IsValid;

	private static FFieldAddress SetCurveValue_InValue_PropertyAddress;

	private static int SetCurveValue_InValue_Offset;

	private static bool SetCurveValue_bSetupUndo_IsValid;

	private static FFieldAddress SetCurveValue_bSetupUndo_PropertyAddress;

	private static int SetCurveValue_bSetupUndo_Offset;

	private static bool SetControlVisibilityByIndex_IsValid;

	private static IntPtr SetControlVisibilityByIndex_FunctionAddress;

	private static int SetControlVisibilityByIndex_ParamsSize;

	private static bool SetControlVisibilityByIndex_InElementIndex_IsValid;

	private static FFieldAddress SetControlVisibilityByIndex_InElementIndex_PropertyAddress;

	private static int SetControlVisibilityByIndex_InElementIndex_Offset;

	private static bool SetControlVisibilityByIndex_bVisibility_IsValid;

	private static FFieldAddress SetControlVisibilityByIndex_bVisibility_PropertyAddress;

	private static int SetControlVisibilityByIndex_bVisibility_Offset;

	private static bool SetControlVisibility_IsValid;

	private static IntPtr SetControlVisibility_FunctionAddress;

	private static int SetControlVisibility_ParamsSize;

	private static bool SetControlVisibility_InKey_IsValid;

	private static FFieldAddress SetControlVisibility_InKey_PropertyAddress;

	private static int SetControlVisibility_InKey_Offset;

	private static bool SetControlVisibility_bVisibility_IsValid;

	private static FFieldAddress SetControlVisibility_bVisibility_PropertyAddress;

	private static int SetControlVisibility_bVisibility_Offset;

	private static bool SetControlValueByIndex_IsValid;

	private static IntPtr SetControlValueByIndex_FunctionAddress;

	private static int SetControlValueByIndex_ParamsSize;

	private static bool SetControlValueByIndex_InElementIndex_IsValid;

	private static FFieldAddress SetControlValueByIndex_InElementIndex_PropertyAddress;

	private static int SetControlValueByIndex_InElementIndex_Offset;

	private static bool SetControlValueByIndex_InValue_IsValid;

	private static FFieldAddress SetControlValueByIndex_InValue_PropertyAddress;

	private static int SetControlValueByIndex_InValue_Offset;

	private static bool SetControlValueByIndex_InValueType_IsValid;

	private static FFieldAddress SetControlValueByIndex_InValueType_PropertyAddress;

	private static int SetControlValueByIndex_InValueType_Offset;

	private static bool SetControlValueByIndex_bSetupUndo_IsValid;

	private static FFieldAddress SetControlValueByIndex_bSetupUndo_PropertyAddress;

	private static int SetControlValueByIndex_bSetupUndo_Offset;

	private static bool SetControlValueByIndex_bPrintPythonCommands_IsValid;

	private static FFieldAddress SetControlValueByIndex_bPrintPythonCommands_PropertyAddress;

	private static int SetControlValueByIndex_bPrintPythonCommands_Offset;

	private static bool SetControlValue_IsValid;

	private static IntPtr SetControlValue_FunctionAddress;

	private static int SetControlValue_ParamsSize;

	private static bool SetControlValue_InKey_IsValid;

	private static FFieldAddress SetControlValue_InKey_PropertyAddress;

	private static int SetControlValue_InKey_Offset;

	private static bool SetControlValue_InValue_IsValid;

	private static FFieldAddress SetControlValue_InValue_PropertyAddress;

	private static int SetControlValue_InValue_Offset;

	private static bool SetControlValue_InValueType_IsValid;

	private static FFieldAddress SetControlValue_InValueType_PropertyAddress;

	private static int SetControlValue_InValueType_Offset;

	private static bool SetControlValue_bSetupUndo_IsValid;

	private static FFieldAddress SetControlValue_bSetupUndo_PropertyAddress;

	private static int SetControlValue_bSetupUndo_Offset;

	private static bool SetControlValue_bPrintPythonCommands_IsValid;

	private static FFieldAddress SetControlValue_bPrintPythonCommands_PropertyAddress;

	private static int SetControlValue_bPrintPythonCommands_Offset;

	private static bool SetControlShapeTransformByIndex_IsValid;

	private static IntPtr SetControlShapeTransformByIndex_FunctionAddress;

	private static int SetControlShapeTransformByIndex_ParamsSize;

	private static bool SetControlShapeTransformByIndex_InElementIndex_IsValid;

	private static FFieldAddress SetControlShapeTransformByIndex_InElementIndex_PropertyAddress;

	private static int SetControlShapeTransformByIndex_InElementIndex_Offset;

	private static bool SetControlShapeTransformByIndex_InTransform_IsValid;

	private static FFieldAddress SetControlShapeTransformByIndex_InTransform_PropertyAddress;

	private static int SetControlShapeTransformByIndex_InTransform_Offset;

	private static bool SetControlShapeTransformByIndex_bInitial_IsValid;

	private static FFieldAddress SetControlShapeTransformByIndex_bInitial_PropertyAddress;

	private static int SetControlShapeTransformByIndex_bInitial_Offset;

	private static bool SetControlShapeTransformByIndex_bSetupUndo_IsValid;

	private static FFieldAddress SetControlShapeTransformByIndex_bSetupUndo_PropertyAddress;

	private static int SetControlShapeTransformByIndex_bSetupUndo_Offset;

	private static bool SetControlShapeTransform_IsValid;

	private static IntPtr SetControlShapeTransform_FunctionAddress;

	private static int SetControlShapeTransform_ParamsSize;

	private static bool SetControlShapeTransform_InKey_IsValid;

	private static FFieldAddress SetControlShapeTransform_InKey_PropertyAddress;

	private static int SetControlShapeTransform_InKey_Offset;

	private static bool SetControlShapeTransform_InTransform_IsValid;

	private static FFieldAddress SetControlShapeTransform_InTransform_PropertyAddress;

	private static int SetControlShapeTransform_InTransform_Offset;

	private static bool SetControlShapeTransform_bInitial_IsValid;

	private static FFieldAddress SetControlShapeTransform_bInitial_PropertyAddress;

	private static int SetControlShapeTransform_bInitial_Offset;

	private static bool SetControlShapeTransform_bSetupUndo_IsValid;

	private static FFieldAddress SetControlShapeTransform_bSetupUndo_PropertyAddress;

	private static int SetControlShapeTransform_bSetupUndo_Offset;

	private static bool SetControlSettingsByIndex_IsValid;

	private static IntPtr SetControlSettingsByIndex_FunctionAddress;

	private static int SetControlSettingsByIndex_ParamsSize;

	private static bool SetControlSettingsByIndex_InElementIndex_IsValid;

	private static FFieldAddress SetControlSettingsByIndex_InElementIndex_PropertyAddress;

	private static int SetControlSettingsByIndex_InElementIndex_Offset;

	private static bool SetControlSettingsByIndex_InSettings_IsValid;

	private static FFieldAddress SetControlSettingsByIndex_InSettings_PropertyAddress;

	private static int SetControlSettingsByIndex_InSettings_Offset;

	private static bool SetControlSettingsByIndex_bSetupUndo_IsValid;

	private static FFieldAddress SetControlSettingsByIndex_bSetupUndo_PropertyAddress;

	private static int SetControlSettingsByIndex_bSetupUndo_Offset;

	private static bool SetControlSettingsByIndex_bForce_IsValid;

	private static FFieldAddress SetControlSettingsByIndex_bForce_PropertyAddress;

	private static int SetControlSettingsByIndex_bForce_Offset;

	private static bool SetControlSettingsByIndex_bPrintPythonCommands_IsValid;

	private static FFieldAddress SetControlSettingsByIndex_bPrintPythonCommands_PropertyAddress;

	private static int SetControlSettingsByIndex_bPrintPythonCommands_Offset;

	private static bool SetControlSettings_IsValid;

	private static IntPtr SetControlSettings_FunctionAddress;

	private static int SetControlSettings_ParamsSize;

	private static bool SetControlSettings_InKey_IsValid;

	private static FFieldAddress SetControlSettings_InKey_PropertyAddress;

	private static int SetControlSettings_InKey_Offset;

	private static bool SetControlSettings_InSettings_IsValid;

	private static FFieldAddress SetControlSettings_InSettings_PropertyAddress;

	private static int SetControlSettings_InSettings_Offset;

	private static bool SetControlSettings_bSetupUndo_IsValid;

	private static FFieldAddress SetControlSettings_bSetupUndo_PropertyAddress;

	private static int SetControlSettings_bSetupUndo_Offset;

	private static bool SetControlSettings_bForce_IsValid;

	private static FFieldAddress SetControlSettings_bForce_PropertyAddress;

	private static int SetControlSettings_bForce_Offset;

	private static bool SetControlSettings_bPrintPythonCommands_IsValid;

	private static FFieldAddress SetControlSettings_bPrintPythonCommands_PropertyAddress;

	private static int SetControlSettings_bPrintPythonCommands_Offset;

	private static bool SetControlOffsetTransformByIndex_IsValid;

	private static IntPtr SetControlOffsetTransformByIndex_FunctionAddress;

	private static int SetControlOffsetTransformByIndex_ParamsSize;

	private static bool SetControlOffsetTransformByIndex_InElementIndex_IsValid;

	private static FFieldAddress SetControlOffsetTransformByIndex_InElementIndex_PropertyAddress;

	private static int SetControlOffsetTransformByIndex_InElementIndex_Offset;

	private static bool SetControlOffsetTransformByIndex_InTransform_IsValid;

	private static FFieldAddress SetControlOffsetTransformByIndex_InTransform_PropertyAddress;

	private static int SetControlOffsetTransformByIndex_InTransform_Offset;

	private static bool SetControlOffsetTransformByIndex_bInitial_IsValid;

	private static FFieldAddress SetControlOffsetTransformByIndex_bInitial_PropertyAddress;

	private static int SetControlOffsetTransformByIndex_bInitial_Offset;

	private static bool SetControlOffsetTransformByIndex_bAffectChildren_IsValid;

	private static FFieldAddress SetControlOffsetTransformByIndex_bAffectChildren_PropertyAddress;

	private static int SetControlOffsetTransformByIndex_bAffectChildren_Offset;

	private static bool SetControlOffsetTransformByIndex_bSetupUndo_IsValid;

	private static FFieldAddress SetControlOffsetTransformByIndex_bSetupUndo_PropertyAddress;

	private static int SetControlOffsetTransformByIndex_bSetupUndo_Offset;

	private static bool SetControlOffsetTransformByIndex_bPrintPythonCommands_IsValid;

	private static FFieldAddress SetControlOffsetTransformByIndex_bPrintPythonCommands_PropertyAddress;

	private static int SetControlOffsetTransformByIndex_bPrintPythonCommands_Offset;

	private static bool SetControlOffsetTransform_IsValid;

	private static IntPtr SetControlOffsetTransform_FunctionAddress;

	private static int SetControlOffsetTransform_ParamsSize;

	private static bool SetControlOffsetTransform_InKey_IsValid;

	private static FFieldAddress SetControlOffsetTransform_InKey_PropertyAddress;

	private static int SetControlOffsetTransform_InKey_Offset;

	private static bool SetControlOffsetTransform_InTransform_IsValid;

	private static FFieldAddress SetControlOffsetTransform_InTransform_PropertyAddress;

	private static int SetControlOffsetTransform_InTransform_Offset;

	private static bool SetControlOffsetTransform_bInitial_IsValid;

	private static FFieldAddress SetControlOffsetTransform_bInitial_PropertyAddress;

	private static int SetControlOffsetTransform_bInitial_Offset;

	private static bool SetControlOffsetTransform_bAffectChildren_IsValid;

	private static FFieldAddress SetControlOffsetTransform_bAffectChildren_PropertyAddress;

	private static int SetControlOffsetTransform_bAffectChildren_Offset;

	private static bool SetControlOffsetTransform_bSetupUndo_IsValid;

	private static FFieldAddress SetControlOffsetTransform_bSetupUndo_PropertyAddress;

	private static int SetControlOffsetTransform_bSetupUndo_Offset;

	private static bool SetControlOffsetTransform_bPrintPythonCommands_IsValid;

	private static FFieldAddress SetControlOffsetTransform_bPrintPythonCommands_PropertyAddress;

	private static int SetControlOffsetTransform_bPrintPythonCommands_Offset;

	private static bool SendAutoKeyEvent_IsValid;

	private static IntPtr SendAutoKeyEvent_FunctionAddress;

	private static int SendAutoKeyEvent_ParamsSize;

	private static bool SendAutoKeyEvent_InElement_IsValid;

	private static FFieldAddress SendAutoKeyEvent_InElement_PropertyAddress;

	private static int SendAutoKeyEvent_InElement_Offset;

	private static bool SendAutoKeyEvent_InOffsetInSeconds_IsValid;

	private static FFieldAddress SendAutoKeyEvent_InOffsetInSeconds_PropertyAddress;

	private static int SendAutoKeyEvent_InOffsetInSeconds_Offset;

	private static bool SendAutoKeyEvent_bAsynchronous_IsValid;

	private static FFieldAddress SendAutoKeyEvent_bAsynchronous_PropertyAddress;

	private static int SendAutoKeyEvent_bAsynchronous_Offset;

	private static bool ResetPoseToInitial_IsValid;

	private static IntPtr ResetPoseToInitial_FunctionAddress;

	private static int ResetPoseToInitial_ParamsSize;

	private static bool ResetPoseToInitial_InTypeFilter_IsValid;

	private static FFieldAddress ResetPoseToInitial_InTypeFilter_PropertyAddress;

	private static int ResetPoseToInitial_InTypeFilter_Offset;

	private static bool ResetCurveValues_IsValid;

	private static IntPtr ResetCurveValues_FunctionAddress;

	private static int ResetCurveValues_ParamsSize;

	private static bool Reset_IsValid;

	private static IntPtr Reset_FunctionAddress;

	private static int Reset_ParamsSize;

	private static bool Num_IsValid;

	private static IntPtr Num_FunctionAddress;

	private static int Num_ParamsSize;

	private static bool Num_ReturnValue_IsValid;

	private static FFieldAddress Num_ReturnValue_PropertyAddress;

	private static int Num_ReturnValue_Offset;

	private static bool MakeControlValueFromVector2D_IsValid;

	private static IntPtr MakeControlValueFromVector2D_FunctionAddress;

	private static int MakeControlValueFromVector2D_ParamsSize;

	private static bool MakeControlValueFromVector2D_InValue_IsValid;

	private static FFieldAddress MakeControlValueFromVector2D_InValue_PropertyAddress;

	private static int MakeControlValueFromVector2D_InValue_Offset;

	private static bool MakeControlValueFromVector2D_ReturnValue_IsValid;

	private static FFieldAddress MakeControlValueFromVector2D_ReturnValue_PropertyAddress;

	private static int MakeControlValueFromVector2D_ReturnValue_Offset;

	private static bool MakeControlValueFromVector_IsValid;

	private static IntPtr MakeControlValueFromVector_FunctionAddress;

	private static int MakeControlValueFromVector_ParamsSize;

	private static bool MakeControlValueFromVector_InValue_IsValid;

	private static FFieldAddress MakeControlValueFromVector_InValue_PropertyAddress;

	private static int MakeControlValueFromVector_InValue_Offset;

	private static bool MakeControlValueFromVector_ReturnValue_IsValid;

	private static FFieldAddress MakeControlValueFromVector_ReturnValue_PropertyAddress;

	private static int MakeControlValueFromVector_ReturnValue_Offset;

	private static bool MakeControlValueFromTransformNoScale_IsValid;

	private static IntPtr MakeControlValueFromTransformNoScale_FunctionAddress;

	private static int MakeControlValueFromTransformNoScale_ParamsSize;

	private static bool MakeControlValueFromTransformNoScale_InValue_IsValid;

	private static FFieldAddress MakeControlValueFromTransformNoScale_InValue_PropertyAddress;

	private static int MakeControlValueFromTransformNoScale_InValue_Offset;

	private static bool MakeControlValueFromTransformNoScale_ReturnValue_IsValid;

	private static FFieldAddress MakeControlValueFromTransformNoScale_ReturnValue_PropertyAddress;

	private static int MakeControlValueFromTransformNoScale_ReturnValue_Offset;

	private static bool MakeControlValueFromTransform_IsValid;

	private static IntPtr MakeControlValueFromTransform_FunctionAddress;

	private static int MakeControlValueFromTransform_ParamsSize;

	private static bool MakeControlValueFromTransform_InValue_IsValid;

	private static FFieldAddress MakeControlValueFromTransform_InValue_PropertyAddress;

	private static int MakeControlValueFromTransform_InValue_Offset;

	private static bool MakeControlValueFromTransform_ReturnValue_IsValid;

	private static FFieldAddress MakeControlValueFromTransform_ReturnValue_PropertyAddress;

	private static int MakeControlValueFromTransform_ReturnValue_Offset;

	private static bool MakeControlValueFromRotator_IsValid;

	private static IntPtr MakeControlValueFromRotator_FunctionAddress;

	private static int MakeControlValueFromRotator_ParamsSize;

	private static bool MakeControlValueFromRotator_InValue_IsValid;

	private static FFieldAddress MakeControlValueFromRotator_InValue_PropertyAddress;

	private static int MakeControlValueFromRotator_InValue_Offset;

	private static bool MakeControlValueFromRotator_ReturnValue_IsValid;

	private static FFieldAddress MakeControlValueFromRotator_ReturnValue_PropertyAddress;

	private static int MakeControlValueFromRotator_ReturnValue_Offset;

	private static bool MakeControlValueFromInt_IsValid;

	private static IntPtr MakeControlValueFromInt_FunctionAddress;

	private static int MakeControlValueFromInt_ParamsSize;

	private static bool MakeControlValueFromInt_InValue_IsValid;

	private static FFieldAddress MakeControlValueFromInt_InValue_PropertyAddress;

	private static int MakeControlValueFromInt_InValue_Offset;

	private static bool MakeControlValueFromInt_ReturnValue_IsValid;

	private static FFieldAddress MakeControlValueFromInt_ReturnValue_PropertyAddress;

	private static int MakeControlValueFromInt_ReturnValue_Offset;

	private static bool MakeControlValueFromFloat_IsValid;

	private static IntPtr MakeControlValueFromFloat_FunctionAddress;

	private static int MakeControlValueFromFloat_ParamsSize;

	private static bool MakeControlValueFromFloat_InValue_IsValid;

	private static FFieldAddress MakeControlValueFromFloat_InValue_PropertyAddress;

	private static int MakeControlValueFromFloat_InValue_Offset;

	private static bool MakeControlValueFromFloat_ReturnValue_IsValid;

	private static FFieldAddress MakeControlValueFromFloat_ReturnValue_PropertyAddress;

	private static int MakeControlValueFromFloat_ReturnValue_Offset;

	private static bool MakeControlValueFromEulerTransform_IsValid;

	private static IntPtr MakeControlValueFromEulerTransform_FunctionAddress;

	private static int MakeControlValueFromEulerTransform_ParamsSize;

	private static bool MakeControlValueFromEulerTransform_InValue_IsValid;

	private static FFieldAddress MakeControlValueFromEulerTransform_InValue_PropertyAddress;

	private static int MakeControlValueFromEulerTransform_InValue_Offset;

	private static bool MakeControlValueFromEulerTransform_ReturnValue_IsValid;

	private static FFieldAddress MakeControlValueFromEulerTransform_ReturnValue_PropertyAddress;

	private static int MakeControlValueFromEulerTransform_ReturnValue_Offset;

	private static bool MakeControlValueFromBool_IsValid;

	private static IntPtr MakeControlValueFromBool_FunctionAddress;

	private static int MakeControlValueFromBool_ParamsSize;

	private static bool MakeControlValueFromBool_InValue_IsValid;

	private static FFieldAddress MakeControlValueFromBool_InValue_PropertyAddress;

	private static int MakeControlValueFromBool_InValue_Offset;

	private static bool MakeControlValueFromBool_ReturnValue_IsValid;

	private static FFieldAddress MakeControlValueFromBool_ReturnValue_PropertyAddress;

	private static int MakeControlValueFromBool_ReturnValue_Offset;

	private static bool IsValidIndex_IsValid;

	private static IntPtr IsValidIndex_FunctionAddress;

	private static int IsValidIndex_ParamsSize;

	private static bool IsValidIndex_InElementIndex_IsValid;

	private static FFieldAddress IsValidIndex_InElementIndex_PropertyAddress;

	private static int IsValidIndex_InElementIndex_Offset;

	private static bool IsValidIndex_ReturnValue_IsValid;

	private static FFieldAddress IsValidIndex_ReturnValue_PropertyAddress;

	private static int IsValidIndex_ReturnValue_Offset;

	private static bool IsSelectedByIndex_IsValid;

	private static IntPtr IsSelectedByIndex_FunctionAddress;

	private static int IsSelectedByIndex_ParamsSize;

	private static bool IsSelectedByIndex_InIndex_IsValid;

	private static FFieldAddress IsSelectedByIndex_InIndex_PropertyAddress;

	private static int IsSelectedByIndex_InIndex_Offset;

	private static bool IsSelectedByIndex_ReturnValue_IsValid;

	private static FFieldAddress IsSelectedByIndex_ReturnValue_PropertyAddress;

	private static int IsSelectedByIndex_ReturnValue_Offset;

	private static bool IsSelected_IsValid;

	private static IntPtr IsSelected_FunctionAddress;

	private static int IsSelected_ParamsSize;

	private static bool IsSelected_InKey_IsValid;

	private static FFieldAddress IsSelected_InKey_PropertyAddress;

	private static int IsSelected_InKey_Offset;

	private static bool IsSelected_ReturnValue_IsValid;

	private static FFieldAddress IsSelected_ReturnValue_PropertyAddress;

	private static int IsSelected_ReturnValue_Offset;

	private static bool IsParentedTo_IsValid;

	private static IntPtr IsParentedTo_FunctionAddress;

	private static int IsParentedTo_ParamsSize;

	private static bool IsParentedTo_InChild_IsValid;

	private static FFieldAddress IsParentedTo_InChild_PropertyAddress;

	private static int IsParentedTo_InChild_Offset;

	private static bool IsParentedTo_InParent_IsValid;

	private static FFieldAddress IsParentedTo_InParent_PropertyAddress;

	private static int IsParentedTo_InParent_Offset;

	private static bool IsParentedTo_ReturnValue_IsValid;

	private static FFieldAddress IsParentedTo_ReturnValue_PropertyAddress;

	private static int IsParentedTo_ReturnValue_Offset;

	private static bool GetVectorFromControlValue_IsValid;

	private static IntPtr GetVectorFromControlValue_FunctionAddress;

	private static int GetVectorFromControlValue_ParamsSize;

	private static bool GetVectorFromControlValue_InValue_IsValid;

	private static FFieldAddress GetVectorFromControlValue_InValue_PropertyAddress;

	private static int GetVectorFromControlValue_InValue_Offset;

	private static bool GetVectorFromControlValue_ReturnValue_IsValid;

	private static FFieldAddress GetVectorFromControlValue_ReturnValue_PropertyAddress;

	private static int GetVectorFromControlValue_ReturnValue_Offset;

	private static bool GetVector2DFromControlValue_IsValid;

	private static IntPtr GetVector2DFromControlValue_FunctionAddress;

	private static int GetVector2DFromControlValue_ParamsSize;

	private static bool GetVector2DFromControlValue_InValue_IsValid;

	private static FFieldAddress GetVector2DFromControlValue_InValue_PropertyAddress;

	private static int GetVector2DFromControlValue_InValue_Offset;

	private static bool GetVector2DFromControlValue_ReturnValue_IsValid;

	private static FFieldAddress GetVector2DFromControlValue_ReturnValue_PropertyAddress;

	private static int GetVector2DFromControlValue_ReturnValue_Offset;

	private static bool GetTransformNoScaleFromControlValue_IsValid;

	private static IntPtr GetTransformNoScaleFromControlValue_FunctionAddress;

	private static int GetTransformNoScaleFromControlValue_ParamsSize;

	private static bool GetTransformNoScaleFromControlValue_InValue_IsValid;

	private static FFieldAddress GetTransformNoScaleFromControlValue_InValue_PropertyAddress;

	private static int GetTransformNoScaleFromControlValue_InValue_Offset;

	private static bool GetTransformNoScaleFromControlValue_ReturnValue_IsValid;

	private static FFieldAddress GetTransformNoScaleFromControlValue_ReturnValue_PropertyAddress;

	private static int GetTransformNoScaleFromControlValue_ReturnValue_Offset;

	private static bool GetTransformFromControlValue_IsValid;

	private static IntPtr GetTransformFromControlValue_FunctionAddress;

	private static int GetTransformFromControlValue_ParamsSize;

	private static bool GetTransformFromControlValue_InValue_IsValid;

	private static FFieldAddress GetTransformFromControlValue_InValue_PropertyAddress;

	private static int GetTransformFromControlValue_InValue_Offset;

	private static bool GetTransformFromControlValue_ReturnValue_IsValid;

	private static FFieldAddress GetTransformFromControlValue_ReturnValue_PropertyAddress;

	private static int GetTransformFromControlValue_ReturnValue_Offset;

	private static bool GetSelectedKeys_IsValid;

	private static IntPtr GetSelectedKeys_FunctionAddress;

	private static int GetSelectedKeys_ParamsSize;

	private static bool GetSelectedKeys_InTypeFilter_IsValid;

	private static FFieldAddress GetSelectedKeys_InTypeFilter_PropertyAddress;

	private static int GetSelectedKeys_InTypeFilter_Offset;

	private static bool GetSelectedKeys_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedKeys_ReturnValue_PropertyAddress;

	private static int GetSelectedKeys_ReturnValue_Offset;

	private static bool GetRotatorFromControlValue_IsValid;

	private static IntPtr GetRotatorFromControlValue_FunctionAddress;

	private static int GetRotatorFromControlValue_ParamsSize;

	private static bool GetRotatorFromControlValue_InValue_IsValid;

	private static FFieldAddress GetRotatorFromControlValue_InValue_PropertyAddress;

	private static int GetRotatorFromControlValue_InValue_Offset;

	private static bool GetRotatorFromControlValue_ReturnValue_IsValid;

	private static FFieldAddress GetRotatorFromControlValue_ReturnValue_PropertyAddress;

	private static int GetRotatorFromControlValue_ReturnValue_Offset;

	private static bool GetRigidBodies_IsValid;

	private static IntPtr GetRigidBodies_FunctionAddress;

	private static int GetRigidBodies_ParamsSize;

	private static bool GetRigidBodies_bTraverse_IsValid;

	private static FFieldAddress GetRigidBodies_bTraverse_PropertyAddress;

	private static int GetRigidBodies_bTraverse_Offset;

	private static bool GetRigidBodies_ReturnValue_IsValid;

	private static FFieldAddress GetRigidBodies_ReturnValue_PropertyAddress;

	private static int GetRigidBodies_ReturnValue_Offset;

	private static bool GetReferences_IsValid;

	private static IntPtr GetReferences_FunctionAddress;

	private static int GetReferences_ParamsSize;

	private static bool GetReferences_bTraverse_IsValid;

	private static FFieldAddress GetReferences_bTraverse_PropertyAddress;

	private static int GetReferences_bTraverse_Offset;

	private static bool GetReferences_ReturnValue_IsValid;

	private static FFieldAddress GetReferences_ReturnValue_PropertyAddress;

	private static int GetReferences_ReturnValue_Offset;

	private static bool GetPreviousParent_IsValid;

	private static IntPtr GetPreviousParent_FunctionAddress;

	private static int GetPreviousParent_ParamsSize;

	private static bool GetPreviousParent_InKey_IsValid;

	private static FFieldAddress GetPreviousParent_InKey_PropertyAddress;

	private static int GetPreviousParent_InKey_Offset;

	private static bool GetPreviousParent_ReturnValue_IsValid;

	private static FFieldAddress GetPreviousParent_ReturnValue_PropertyAddress;

	private static int GetPreviousParent_ReturnValue_Offset;

	private static bool GetPreviousName_IsValid;

	private static IntPtr GetPreviousName_FunctionAddress;

	private static int GetPreviousName_ParamsSize;

	private static bool GetPreviousName_InKey_IsValid;

	private static FFieldAddress GetPreviousName_InKey_PropertyAddress;

	private static int GetPreviousName_InKey_Offset;

	private static bool GetPreviousName_ReturnValue_IsValid;

	private static FFieldAddress GetPreviousName_ReturnValue_PropertyAddress;

	private static int GetPreviousName_ReturnValue_Offset;

	private static bool GetPose_IsValid;

	private static IntPtr GetPose_FunctionAddress;

	private static int GetPose_ParamsSize;

	private static bool GetPose_bInitial_IsValid;

	private static FFieldAddress GetPose_bInitial_PropertyAddress;

	private static int GetPose_bInitial_Offset;

	private static bool GetPose_ReturnValue_IsValid;

	private static FFieldAddress GetPose_ReturnValue_PropertyAddress;

	private static int GetPose_ReturnValue_Offset;

	private static bool GetParentWeightArray_IsValid;

	private static IntPtr GetParentWeightArray_FunctionAddress;

	private static int GetParentWeightArray_ParamsSize;

	private static bool GetParentWeightArray_InChild_IsValid;

	private static FFieldAddress GetParentWeightArray_InChild_PropertyAddress;

	private static int GetParentWeightArray_InChild_Offset;

	private static bool GetParentWeightArray_bInitial_IsValid;

	private static FFieldAddress GetParentWeightArray_bInitial_PropertyAddress;

	private static int GetParentWeightArray_bInitial_Offset;

	private static bool GetParentWeightArray_ReturnValue_IsValid;

	private static FFieldAddress GetParentWeightArray_ReturnValue_PropertyAddress;

	private static int GetParentWeightArray_ReturnValue_Offset;

	private static bool GetParentWeight_IsValid;

	private static IntPtr GetParentWeight_FunctionAddress;

	private static int GetParentWeight_ParamsSize;

	private static bool GetParentWeight_InChild_IsValid;

	private static FFieldAddress GetParentWeight_InChild_PropertyAddress;

	private static int GetParentWeight_InChild_Offset;

	private static bool GetParentWeight_InParent_IsValid;

	private static FFieldAddress GetParentWeight_InParent_PropertyAddress;

	private static int GetParentWeight_InParent_Offset;

	private static bool GetParentWeight_bInitial_IsValid;

	private static FFieldAddress GetParentWeight_bInitial_PropertyAddress;

	private static int GetParentWeight_bInitial_Offset;

	private static bool GetParentWeight_ReturnValue_IsValid;

	private static FFieldAddress GetParentWeight_ReturnValue_PropertyAddress;

	private static int GetParentWeight_ReturnValue_Offset;

	private static bool GetParentTransformByIndex_IsValid;

	private static IntPtr GetParentTransformByIndex_FunctionAddress;

	private static int GetParentTransformByIndex_ParamsSize;

	private static bool GetParentTransformByIndex_InElementIndex_IsValid;

	private static FFieldAddress GetParentTransformByIndex_InElementIndex_PropertyAddress;

	private static int GetParentTransformByIndex_InElementIndex_Offset;

	private static bool GetParentTransformByIndex_bInitial_IsValid;

	private static FFieldAddress GetParentTransformByIndex_bInitial_PropertyAddress;

	private static int GetParentTransformByIndex_bInitial_Offset;

	private static bool GetParentTransformByIndex_ReturnValue_IsValid;

	private static FFieldAddress GetParentTransformByIndex_ReturnValue_PropertyAddress;

	private static int GetParentTransformByIndex_ReturnValue_Offset;

	private static bool GetParentTransform_IsValid;

	private static IntPtr GetParentTransform_FunctionAddress;

	private static int GetParentTransform_ParamsSize;

	private static bool GetParentTransform_InKey_IsValid;

	private static FFieldAddress GetParentTransform_InKey_PropertyAddress;

	private static int GetParentTransform_InKey_Offset;

	private static bool GetParentTransform_bInitial_IsValid;

	private static FFieldAddress GetParentTransform_bInitial_PropertyAddress;

	private static int GetParentTransform_bInitial_Offset;

	private static bool GetParentTransform_ReturnValue_IsValid;

	private static FFieldAddress GetParentTransform_ReturnValue_PropertyAddress;

	private static int GetParentTransform_ReturnValue_Offset;

	private static bool GetParents_IsValid;

	private static IntPtr GetParents_FunctionAddress;

	private static int GetParents_ParamsSize;

	private static bool GetParents_InKey_IsValid;

	private static FFieldAddress GetParents_InKey_PropertyAddress;

	private static int GetParents_InKey_Offset;

	private static bool GetParents_bRecursive_IsValid;

	private static FFieldAddress GetParents_bRecursive_PropertyAddress;

	private static int GetParents_bRecursive_Offset;

	private static bool GetParents_ReturnValue_IsValid;

	private static FFieldAddress GetParents_ReturnValue_PropertyAddress;

	private static int GetParents_ReturnValue_Offset;

	private static bool GetNumberOfParents_IsValid;

	private static IntPtr GetNumberOfParents_FunctionAddress;

	private static int GetNumberOfParents_ParamsSize;

	private static bool GetNumberOfParents_InKey_IsValid;

	private static FFieldAddress GetNumberOfParents_InKey_PropertyAddress;

	private static int GetNumberOfParents_InKey_Offset;

	private static bool GetNumberOfParents_ReturnValue_IsValid;

	private static FFieldAddress GetNumberOfParents_ReturnValue_PropertyAddress;

	private static int GetNumberOfParents_ReturnValue_Offset;

	private static bool GetNulls_IsValid;

	private static IntPtr GetNulls_FunctionAddress;

	private static int GetNulls_ParamsSize;

	private static bool GetNulls_bTraverse_IsValid;

	private static FFieldAddress GetNulls_bTraverse_PropertyAddress;

	private static int GetNulls_bTraverse_Offset;

	private static bool GetNulls_ReturnValue_IsValid;

	private static FFieldAddress GetNulls_ReturnValue_PropertyAddress;

	private static int GetNulls_ReturnValue_Offset;

	private static bool GetLocalTransformByIndex_IsValid;

	private static IntPtr GetLocalTransformByIndex_FunctionAddress;

	private static int GetLocalTransformByIndex_ParamsSize;

	private static bool GetLocalTransformByIndex_InElementIndex_IsValid;

	private static FFieldAddress GetLocalTransformByIndex_InElementIndex_PropertyAddress;

	private static int GetLocalTransformByIndex_InElementIndex_Offset;

	private static bool GetLocalTransformByIndex_bInitial_IsValid;

	private static FFieldAddress GetLocalTransformByIndex_bInitial_PropertyAddress;

	private static int GetLocalTransformByIndex_bInitial_Offset;

	private static bool GetLocalTransformByIndex_ReturnValue_IsValid;

	private static FFieldAddress GetLocalTransformByIndex_ReturnValue_PropertyAddress;

	private static int GetLocalTransformByIndex_ReturnValue_Offset;

	private static bool GetLocalTransform_IsValid;

	private static IntPtr GetLocalTransform_FunctionAddress;

	private static int GetLocalTransform_ParamsSize;

	private static bool GetLocalTransform_InKey_IsValid;

	private static FFieldAddress GetLocalTransform_InKey_PropertyAddress;

	private static int GetLocalTransform_InKey_Offset;

	private static bool GetLocalTransform_bInitial_IsValid;

	private static FFieldAddress GetLocalTransform_bInitial_PropertyAddress;

	private static int GetLocalTransform_bInitial_Offset;

	private static bool GetLocalTransform_ReturnValue_IsValid;

	private static FFieldAddress GetLocalTransform_ReturnValue_PropertyAddress;

	private static int GetLocalTransform_ReturnValue_Offset;

	private static bool GetKey_IsValid;

	private static IntPtr GetKey_FunctionAddress;

	private static int GetKey_ParamsSize;

	private static bool GetKey_InElementIndex_IsValid;

	private static FFieldAddress GetKey_InElementIndex_PropertyAddress;

	private static int GetKey_InElementIndex_Offset;

	private static bool GetKey_ReturnValue_IsValid;

	private static FFieldAddress GetKey_ReturnValue_PropertyAddress;

	private static int GetKey_ReturnValue_Offset;

	private static bool GetIntFromControlValue_IsValid;

	private static IntPtr GetIntFromControlValue_FunctionAddress;

	private static int GetIntFromControlValue_ParamsSize;

	private static bool GetIntFromControlValue_InValue_IsValid;

	private static FFieldAddress GetIntFromControlValue_InValue_PropertyAddress;

	private static int GetIntFromControlValue_InValue_Offset;

	private static bool GetIntFromControlValue_ReturnValue_IsValid;

	private static FFieldAddress GetIntFromControlValue_ReturnValue_PropertyAddress;

	private static int GetIntFromControlValue_ReturnValue_Offset;

	private static bool GetIndex_IsValid;

	private static IntPtr GetIndex_FunctionAddress;

	private static int GetIndex_ParamsSize;

	private static bool GetIndex_InKey_IsValid;

	private static FFieldAddress GetIndex_InKey_PropertyAddress;

	private static int GetIndex_InKey_Offset;

	private static bool GetIndex_ReturnValue_IsValid;

	private static FFieldAddress GetIndex_ReturnValue_PropertyAddress;

	private static int GetIndex_ReturnValue_Offset;

	private static bool GetGlobalTransformByIndex_IsValid;

	private static IntPtr GetGlobalTransformByIndex_FunctionAddress;

	private static int GetGlobalTransformByIndex_ParamsSize;

	private static bool GetGlobalTransformByIndex_InElementIndex_IsValid;

	private static FFieldAddress GetGlobalTransformByIndex_InElementIndex_PropertyAddress;

	private static int GetGlobalTransformByIndex_InElementIndex_Offset;

	private static bool GetGlobalTransformByIndex_bInitial_IsValid;

	private static FFieldAddress GetGlobalTransformByIndex_bInitial_PropertyAddress;

	private static int GetGlobalTransformByIndex_bInitial_Offset;

	private static bool GetGlobalTransformByIndex_ReturnValue_IsValid;

	private static FFieldAddress GetGlobalTransformByIndex_ReturnValue_PropertyAddress;

	private static int GetGlobalTransformByIndex_ReturnValue_Offset;

	private static bool GetGlobalTransform_IsValid;

	private static IntPtr GetGlobalTransform_FunctionAddress;

	private static int GetGlobalTransform_ParamsSize;

	private static bool GetGlobalTransform_InKey_IsValid;

	private static FFieldAddress GetGlobalTransform_InKey_PropertyAddress;

	private static int GetGlobalTransform_InKey_Offset;

	private static bool GetGlobalTransform_bInitial_IsValid;

	private static FFieldAddress GetGlobalTransform_bInitial_PropertyAddress;

	private static int GetGlobalTransform_bInitial_Offset;

	private static bool GetGlobalTransform_ReturnValue_IsValid;

	private static FFieldAddress GetGlobalTransform_ReturnValue_PropertyAddress;

	private static int GetGlobalTransform_ReturnValue_Offset;

	private static bool GetGlobalControlShapeTransformByIndex_IsValid;

	private static IntPtr GetGlobalControlShapeTransformByIndex_FunctionAddress;

	private static int GetGlobalControlShapeTransformByIndex_ParamsSize;

	private static bool GetGlobalControlShapeTransformByIndex_InElementIndex_IsValid;

	private static FFieldAddress GetGlobalControlShapeTransformByIndex_InElementIndex_PropertyAddress;

	private static int GetGlobalControlShapeTransformByIndex_InElementIndex_Offset;

	private static bool GetGlobalControlShapeTransformByIndex_bInitial_IsValid;

	private static FFieldAddress GetGlobalControlShapeTransformByIndex_bInitial_PropertyAddress;

	private static int GetGlobalControlShapeTransformByIndex_bInitial_Offset;

	private static bool GetGlobalControlShapeTransformByIndex_ReturnValue_IsValid;

	private static FFieldAddress GetGlobalControlShapeTransformByIndex_ReturnValue_PropertyAddress;

	private static int GetGlobalControlShapeTransformByIndex_ReturnValue_Offset;

	private static bool GetGlobalControlShapeTransform_IsValid;

	private static IntPtr GetGlobalControlShapeTransform_FunctionAddress;

	private static int GetGlobalControlShapeTransform_ParamsSize;

	private static bool GetGlobalControlShapeTransform_InKey_IsValid;

	private static FFieldAddress GetGlobalControlShapeTransform_InKey_PropertyAddress;

	private static int GetGlobalControlShapeTransform_InKey_Offset;

	private static bool GetGlobalControlShapeTransform_bInitial_IsValid;

	private static FFieldAddress GetGlobalControlShapeTransform_bInitial_PropertyAddress;

	private static int GetGlobalControlShapeTransform_bInitial_Offset;

	private static bool GetGlobalControlShapeTransform_ReturnValue_IsValid;

	private static FFieldAddress GetGlobalControlShapeTransform_ReturnValue_PropertyAddress;

	private static int GetGlobalControlShapeTransform_ReturnValue_Offset;

	private static bool GetGlobalControlOffsetTransformByIndex_IsValid;

	private static IntPtr GetGlobalControlOffsetTransformByIndex_FunctionAddress;

	private static int GetGlobalControlOffsetTransformByIndex_ParamsSize;

	private static bool GetGlobalControlOffsetTransformByIndex_InElementIndex_IsValid;

	private static FFieldAddress GetGlobalControlOffsetTransformByIndex_InElementIndex_PropertyAddress;

	private static int GetGlobalControlOffsetTransformByIndex_InElementIndex_Offset;

	private static bool GetGlobalControlOffsetTransformByIndex_bInitial_IsValid;

	private static FFieldAddress GetGlobalControlOffsetTransformByIndex_bInitial_PropertyAddress;

	private static int GetGlobalControlOffsetTransformByIndex_bInitial_Offset;

	private static bool GetGlobalControlOffsetTransformByIndex_ReturnValue_IsValid;

	private static FFieldAddress GetGlobalControlOffsetTransformByIndex_ReturnValue_PropertyAddress;

	private static int GetGlobalControlOffsetTransformByIndex_ReturnValue_Offset;

	private static bool GetGlobalControlOffsetTransform_IsValid;

	private static IntPtr GetGlobalControlOffsetTransform_FunctionAddress;

	private static int GetGlobalControlOffsetTransform_ParamsSize;

	private static bool GetGlobalControlOffsetTransform_InKey_IsValid;

	private static FFieldAddress GetGlobalControlOffsetTransform_InKey_PropertyAddress;

	private static int GetGlobalControlOffsetTransform_InKey_Offset;

	private static bool GetGlobalControlOffsetTransform_bInitial_IsValid;

	private static FFieldAddress GetGlobalControlOffsetTransform_bInitial_PropertyAddress;

	private static int GetGlobalControlOffsetTransform_bInitial_Offset;

	private static bool GetGlobalControlOffsetTransform_ReturnValue_IsValid;

	private static FFieldAddress GetGlobalControlOffsetTransform_ReturnValue_PropertyAddress;

	private static int GetGlobalControlOffsetTransform_ReturnValue_Offset;

	private static bool GetFloatFromControlValue_IsValid;

	private static IntPtr GetFloatFromControlValue_FunctionAddress;

	private static int GetFloatFromControlValue_ParamsSize;

	private static bool GetFloatFromControlValue_InValue_IsValid;

	private static FFieldAddress GetFloatFromControlValue_InValue_PropertyAddress;

	private static int GetFloatFromControlValue_InValue_Offset;

	private static bool GetFloatFromControlValue_ReturnValue_IsValid;

	private static FFieldAddress GetFloatFromControlValue_ReturnValue_PropertyAddress;

	private static int GetFloatFromControlValue_ReturnValue_Offset;

	private static bool GetFirstParent_IsValid;

	private static IntPtr GetFirstParent_FunctionAddress;

	private static int GetFirstParent_ParamsSize;

	private static bool GetFirstParent_InKey_IsValid;

	private static FFieldAddress GetFirstParent_InKey_PropertyAddress;

	private static int GetFirstParent_InKey_Offset;

	private static bool GetFirstParent_ReturnValue_IsValid;

	private static FFieldAddress GetFirstParent_ReturnValue_PropertyAddress;

	private static int GetFirstParent_ReturnValue_Offset;

	private static bool GetEulerTransformFromControlValue_IsValid;

	private static IntPtr GetEulerTransformFromControlValue_FunctionAddress;

	private static int GetEulerTransformFromControlValue_ParamsSize;

	private static bool GetEulerTransformFromControlValue_InValue_IsValid;

	private static FFieldAddress GetEulerTransformFromControlValue_InValue_PropertyAddress;

	private static int GetEulerTransformFromControlValue_InValue_Offset;

	private static bool GetEulerTransformFromControlValue_ReturnValue_IsValid;

	private static FFieldAddress GetEulerTransformFromControlValue_ReturnValue_PropertyAddress;

	private static int GetEulerTransformFromControlValue_ReturnValue_Offset;

	private static bool GetCurveValueByIndex_IsValid;

	private static IntPtr GetCurveValueByIndex_FunctionAddress;

	private static int GetCurveValueByIndex_ParamsSize;

	private static bool GetCurveValueByIndex_InElementIndex_IsValid;

	private static FFieldAddress GetCurveValueByIndex_InElementIndex_PropertyAddress;

	private static int GetCurveValueByIndex_InElementIndex_Offset;

	private static bool GetCurveValueByIndex_ReturnValue_IsValid;

	private static FFieldAddress GetCurveValueByIndex_ReturnValue_PropertyAddress;

	private static int GetCurveValueByIndex_ReturnValue_Offset;

	private static bool GetCurveValue_IsValid;

	private static IntPtr GetCurveValue_FunctionAddress;

	private static int GetCurveValue_ParamsSize;

	private static bool GetCurveValue_InKey_IsValid;

	private static FFieldAddress GetCurveValue_InKey_PropertyAddress;

	private static int GetCurveValue_InKey_Offset;

	private static bool GetCurveValue_ReturnValue_IsValid;

	private static FFieldAddress GetCurveValue_ReturnValue_PropertyAddress;

	private static int GetCurveValue_ReturnValue_Offset;

	private static bool GetCurves_IsValid;

	private static IntPtr GetCurves_FunctionAddress;

	private static int GetCurves_ParamsSize;

	private static bool GetCurves_ReturnValue_IsValid;

	private static FFieldAddress GetCurves_ReturnValue_PropertyAddress;

	private static int GetCurves_ReturnValue_Offset;

	private static bool GetControlValueByIndex_IsValid;

	private static IntPtr GetControlValueByIndex_FunctionAddress;

	private static int GetControlValueByIndex_ParamsSize;

	private static bool GetControlValueByIndex_InElementIndex_IsValid;

	private static FFieldAddress GetControlValueByIndex_InElementIndex_PropertyAddress;

	private static int GetControlValueByIndex_InElementIndex_Offset;

	private static bool GetControlValueByIndex_InValueType_IsValid;

	private static FFieldAddress GetControlValueByIndex_InValueType_PropertyAddress;

	private static int GetControlValueByIndex_InValueType_Offset;

	private static bool GetControlValueByIndex_ReturnValue_IsValid;

	private static FFieldAddress GetControlValueByIndex_ReturnValue_PropertyAddress;

	private static int GetControlValueByIndex_ReturnValue_Offset;

	private static bool GetControlValue_IsValid;

	private static IntPtr GetControlValue_FunctionAddress;

	private static int GetControlValue_ParamsSize;

	private static bool GetControlValue_InKey_IsValid;

	private static FFieldAddress GetControlValue_InKey_PropertyAddress;

	private static int GetControlValue_InKey_Offset;

	private static bool GetControlValue_InValueType_IsValid;

	private static FFieldAddress GetControlValue_InValueType_PropertyAddress;

	private static int GetControlValue_InValueType_Offset;

	private static bool GetControlValue_ReturnValue_IsValid;

	private static FFieldAddress GetControlValue_ReturnValue_PropertyAddress;

	private static int GetControlValue_ReturnValue_Offset;

	private static bool GetController_IsValid;

	private static IntPtr GetController_FunctionAddress;

	private static int GetController_ParamsSize;

	private static bool GetController_bCreateIfNeeded_IsValid;

	private static FFieldAddress GetController_bCreateIfNeeded_PropertyAddress;

	private static int GetController_bCreateIfNeeded_Offset;

	private static bool GetController_ReturnValue_IsValid;

	private static FFieldAddress GetController_ReturnValue_PropertyAddress;

	private static int GetController_ReturnValue_Offset;

	private static bool GetControls_IsValid;

	private static IntPtr GetControls_FunctionAddress;

	private static int GetControls_ParamsSize;

	private static bool GetControls_bTraverse_IsValid;

	private static FFieldAddress GetControls_bTraverse_PropertyAddress;

	private static int GetControls_bTraverse_Offset;

	private static bool GetControls_ReturnValue_IsValid;

	private static FFieldAddress GetControls_ReturnValue_PropertyAddress;

	private static int GetControls_ReturnValue_Offset;

	private static bool GetChildren_IsValid;

	private static IntPtr GetChildren_FunctionAddress;

	private static int GetChildren_ParamsSize;

	private static bool GetChildren_InKey_IsValid;

	private static FFieldAddress GetChildren_InKey_PropertyAddress;

	private static int GetChildren_InKey_Offset;

	private static bool GetChildren_bRecursive_IsValid;

	private static FFieldAddress GetChildren_bRecursive_PropertyAddress;

	private static int GetChildren_bRecursive_Offset;

	private static bool GetChildren_ReturnValue_IsValid;

	private static FFieldAddress GetChildren_ReturnValue_PropertyAddress;

	private static int GetChildren_ReturnValue_Offset;

	private static bool GetBones_IsValid;

	private static IntPtr GetBones_FunctionAddress;

	private static int GetBones_ParamsSize;

	private static bool GetBones_bTraverse_IsValid;

	private static FFieldAddress GetBones_bTraverse_PropertyAddress;

	private static int GetBones_bTraverse_Offset;

	private static bool GetBones_ReturnValue_IsValid;

	private static FFieldAddress GetBones_ReturnValue_PropertyAddress;

	private static int GetBones_ReturnValue_Offset;

	private static bool GetAllKeys_IsValid;

	private static IntPtr GetAllKeys_FunctionAddress;

	private static int GetAllKeys_ParamsSize;

	private static bool GetAllKeys_bTraverse_IsValid;

	private static FFieldAddress GetAllKeys_bTraverse_PropertyAddress;

	private static int GetAllKeys_bTraverse_Offset;

	private static bool GetAllKeys_ReturnValue_IsValid;

	private static FFieldAddress GetAllKeys_ReturnValue_PropertyAddress;

	private static int GetAllKeys_ReturnValue_Offset;

	private static bool FindNull_IsValid;

	private static IntPtr FindNull_FunctionAddress;

	private static int FindNull_ParamsSize;

	private static bool FindNull_InKey_IsValid;

	private static FFieldAddress FindNull_InKey_PropertyAddress;

	private static int FindNull_InKey_Offset;

	private static bool FindNull_ReturnValue_IsValid;

	private static FFieldAddress FindNull_ReturnValue_PropertyAddress;

	private static int FindNull_ReturnValue_Offset;

	private static bool FindControl_IsValid;

	private static IntPtr FindControl_FunctionAddress;

	private static int FindControl_ParamsSize;

	private static bool FindControl_InKey_IsValid;

	private static FFieldAddress FindControl_InKey_PropertyAddress;

	private static int FindControl_InKey_Offset;

	private static bool FindControl_ReturnValue_IsValid;

	private static FFieldAddress FindControl_ReturnValue_PropertyAddress;

	private static int FindControl_ReturnValue_Offset;

	private static bool FindBone_IsValid;

	private static IntPtr FindBone_FunctionAddress;

	private static int FindBone_ParamsSize;

	private static bool FindBone_InKey_IsValid;

	private static FFieldAddress FindBone_InKey_PropertyAddress;

	private static int FindBone_InKey_Offset;

	private static bool FindBone_ReturnValue_IsValid;

	private static FFieldAddress FindBone_ReturnValue_PropertyAddress;

	private static int FindBone_ReturnValue_Offset;

	private static bool CopyPose_IsValid;

	private static IntPtr CopyPose_FunctionAddress;

	private static int CopyPose_ParamsSize;

	private static bool CopyPose_InHierarchy_IsValid;

	private static FFieldAddress CopyPose_InHierarchy_PropertyAddress;

	private static int CopyPose_InHierarchy_Offset;

	private static bool CopyPose_bCurrent_IsValid;

	private static FFieldAddress CopyPose_bCurrent_PropertyAddress;

	private static int CopyPose_bCurrent_Offset;

	private static bool CopyPose_bInitial_IsValid;

	private static FFieldAddress CopyPose_bInitial_PropertyAddress;

	private static int CopyPose_bInitial_Offset;

	private static bool CopyHierarchy_IsValid;

	private static IntPtr CopyHierarchy_FunctionAddress;

	private static int CopyHierarchy_ParamsSize;

	private static bool CopyHierarchy_InHierarchy_IsValid;

	private static FFieldAddress CopyHierarchy_InHierarchy_PropertyAddress;

	private static int CopyHierarchy_InHierarchy_Offset;

	private static bool Contains_IsValid;

	private static IntPtr Contains_FunctionAddress;

	private static int Contains_ParamsSize;

	private static bool Contains_InKey_IsValid;

	private static FFieldAddress Contains_InKey_PropertyAddress;

	private static int Contains_InKey_Offset;

	private static bool Contains_ReturnValue_IsValid;

	private static FFieldAddress Contains_ReturnValue_PropertyAddress;

	private static int Contains_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SwitchToWorldSpace")]
	public unsafe bool SwitchToWorldSpace(FRigElementKey InChild, bool bInitial = false, bool bAffectChildren = true)
	{
		CheckDestroyed();
		if (!SwitchToWorldSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SwitchToWorldSpace");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchToWorldSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchToWorldSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SwitchToWorldSpace_InChild_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SwitchToWorldSpace_InChild_Offset), 0, SwitchToWorldSpace_InChild_PropertyAddress.Address, InChild);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SwitchToWorldSpace_bInitial_Offset), 0, SwitchToWorldSpace_bInitial_PropertyAddress.Address, bInitial);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SwitchToWorldSpace_bAffectChildren_Offset), 0, SwitchToWorldSpace_bAffectChildren_PropertyAddress.Address, bAffectChildren);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchToWorldSpace_FunctionAddress, intPtr, SwitchToWorldSpace_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SwitchToWorldSpace_ReturnValue_Offset), 0, SwitchToWorldSpace_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SwitchToParent")]
	public unsafe bool SwitchToParent(FRigElementKey InChild, FRigElementKey InParent, bool bInitial = false, bool bAffectChildren = true)
	{
		CheckDestroyed();
		if (!SwitchToParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SwitchToParent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchToParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchToParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SwitchToParent_InChild_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SwitchToParent_InChild_Offset), 0, SwitchToParent_InChild_PropertyAddress.Address, InChild);
		NativeReflection.InitializeValue_InContainer(SwitchToParent_InParent_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SwitchToParent_InParent_Offset), 0, SwitchToParent_InParent_PropertyAddress.Address, InParent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SwitchToParent_bInitial_Offset), 0, SwitchToParent_bInitial_PropertyAddress.Address, bInitial);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SwitchToParent_bAffectChildren_Offset), 0, SwitchToParent_bAffectChildren_PropertyAddress.Address, bAffectChildren);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchToParent_FunctionAddress, intPtr, SwitchToParent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SwitchToParent_ReturnValue_Offset), 0, SwitchToParent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SwitchToDefaultParent")]
	public unsafe bool SwitchToDefaultParent(FRigElementKey InChild, bool bInitial = false, bool bAffectChildren = true)
	{
		CheckDestroyed();
		if (!SwitchToDefaultParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SwitchToDefaultParent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchToDefaultParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchToDefaultParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SwitchToDefaultParent_InChild_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SwitchToDefaultParent_InChild_Offset), 0, SwitchToDefaultParent_InChild_PropertyAddress.Address, InChild);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SwitchToDefaultParent_bInitial_Offset), 0, SwitchToDefaultParent_bInitial_PropertyAddress.Address, bInitial);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SwitchToDefaultParent_bAffectChildren_Offset), 0, SwitchToDefaultParent_bAffectChildren_PropertyAddress.Address, bAffectChildren);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchToDefaultParent_FunctionAddress, intPtr, SwitchToDefaultParent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SwitchToDefaultParent_ReturnValue_Offset), 0, SwitchToDefaultParent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SortKeys")]
	public unsafe List<FRigElementKey> SortKeys(List<FRigElementKey> InKeys)
	{
		CheckDestroyed();
		if (!SortKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SortKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SortKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SortKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FRigElementKey>(1, SortKeys_InKeys_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).ToNative(IntPtr.Add(intPtr, SortKeys_InKeys_Offset), InKeys);
		NativeReflection.InvokeFunctionOptimized(base.Address, SortKeys_FunctionAddress, intPtr, SortKeys_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SortKeys_InKeys_PropertyAddress.Address, intPtr);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, SortKeys_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, SortKeys_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(SortKeys_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u, OriginalName = "SetPose_ForBlueprint")]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetPose_ForBlueprint")]
	public unsafe void SetPose(FRigPose InPose)
	{
		CheckDestroyed();
		if (!SetPose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetPose_ForBlueprint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetPose_InPose_PropertyAddress.Address, intPtr);
		FRigPose.ToNative(IntPtr.Add(intPtr, SetPose_InPose_Offset), 0, SetPose_InPose_PropertyAddress.Address, InPose);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPose_FunctionAddress, intPtr, SetPose_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPose_InPose_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetParentWeightArray")]
	public unsafe bool SetParentWeightArray(FRigElementKey InChild, List<FRigElementWeight> InWeights, bool bInitial = false, bool bAffectChildren = true)
	{
		CheckDestroyed();
		if (!SetParentWeightArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetParentWeightArray");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParentWeightArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParentWeightArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetParentWeightArray_InChild_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SetParentWeightArray_InChild_Offset), 0, SetParentWeightArray_InChild_PropertyAddress.Address, InChild);
		new TArrayCopyMarshaler<FRigElementWeight>(1, SetParentWeightArray_InWeights_PropertyAddress, CachedMarshalingDelegates<FRigElementWeight, FRigElementWeight>.FromNative, CachedMarshalingDelegates<FRigElementWeight, FRigElementWeight>.ToNative).ToNative(IntPtr.Add(intPtr, SetParentWeightArray_InWeights_Offset), InWeights);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetParentWeightArray_bInitial_Offset), 0, SetParentWeightArray_bInitial_PropertyAddress.Address, bInitial);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetParentWeightArray_bAffectChildren_Offset), 0, SetParentWeightArray_bAffectChildren_PropertyAddress.Address, bAffectChildren);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParentWeightArray_FunctionAddress, intPtr, SetParentWeightArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetParentWeightArray_InWeights_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetParentWeightArray_ReturnValue_Offset), 0, SetParentWeightArray_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetParentWeight")]
	public unsafe bool SetParentWeight(FRigElementKey InChild, FRigElementKey InParent, FRigElementWeight InWeight, bool bInitial = false, bool bAffectChildren = true)
	{
		CheckDestroyed();
		if (!SetParentWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetParentWeight");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParentWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParentWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetParentWeight_InChild_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SetParentWeight_InChild_Offset), 0, SetParentWeight_InChild_PropertyAddress.Address, InChild);
		NativeReflection.InitializeValue_InContainer(SetParentWeight_InParent_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SetParentWeight_InParent_Offset), 0, SetParentWeight_InParent_PropertyAddress.Address, InParent);
		NativeReflection.InitializeValue_InContainer(SetParentWeight_InWeight_PropertyAddress.Address, intPtr);
		FRigElementWeight.ToNative(IntPtr.Add(intPtr, SetParentWeight_InWeight_Offset), 0, SetParentWeight_InWeight_PropertyAddress.Address, InWeight);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetParentWeight_bInitial_Offset), 0, SetParentWeight_bInitial_PropertyAddress.Address, bInitial);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetParentWeight_bAffectChildren_Offset), 0, SetParentWeight_bAffectChildren_PropertyAddress.Address, bAffectChildren);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParentWeight_FunctionAddress, intPtr, SetParentWeight_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetParentWeight_ReturnValue_Offset), 0, SetParentWeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetLocalTransformByIndex")]
	public unsafe void SetLocalTransformByIndex(int InElementIndex, FTransform InTransform, bool bInitial = false, bool bAffectChildren = true, bool bSetupUndo = false, bool bPrintPythonCommands = false)
	{
		CheckDestroyed();
		if (!SetLocalTransformByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetLocalTransformByIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocalTransformByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocalTransformByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLocalTransformByIndex_InElementIndex_Offset), 0, SetLocalTransformByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		NativeReflection.InitializeValue_InContainer(SetLocalTransformByIndex_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetLocalTransformByIndex_InTransform_Offset), 0, SetLocalTransformByIndex_InTransform_PropertyAddress.Address, InTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalTransformByIndex_bInitial_Offset), 0, SetLocalTransformByIndex_bInitial_PropertyAddress.Address, bInitial);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalTransformByIndex_bAffectChildren_Offset), 0, SetLocalTransformByIndex_bAffectChildren_PropertyAddress.Address, bAffectChildren);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalTransformByIndex_bSetupUndo_Offset), 0, SetLocalTransformByIndex_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalTransformByIndex_bPrintPythonCommands_Offset), 0, SetLocalTransformByIndex_bPrintPythonCommands_PropertyAddress.Address, bPrintPythonCommands);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLocalTransformByIndex_FunctionAddress, intPtr, SetLocalTransformByIndex_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetLocalTransform")]
	public unsafe void SetLocalTransform(FRigElementKey InKey, FTransform InTransform, bool bInitial = false, bool bAffectChildren = true, bool bSetupUndo = false, bool bPrintPythonCommands = false)
	{
		CheckDestroyed();
		if (!SetLocalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetLocalTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLocalTransform_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SetLocalTransform_InKey_Offset), 0, SetLocalTransform_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InitializeValue_InContainer(SetLocalTransform_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetLocalTransform_InTransform_Offset), 0, SetLocalTransform_InTransform_PropertyAddress.Address, InTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalTransform_bInitial_Offset), 0, SetLocalTransform_bInitial_PropertyAddress.Address, bInitial);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalTransform_bAffectChildren_Offset), 0, SetLocalTransform_bAffectChildren_PropertyAddress.Address, bAffectChildren);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalTransform_bSetupUndo_Offset), 0, SetLocalTransform_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalTransform_bPrintPythonCommands_Offset), 0, SetLocalTransform_bPrintPythonCommands_PropertyAddress.Address, bPrintPythonCommands);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLocalTransform_FunctionAddress, intPtr, SetLocalTransform_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetGlobalTransformByIndex")]
	public unsafe void SetGlobalTransformByIndex(int InElementIndex, FTransform InTransform, bool bInitial = false, bool bAffectChildren = true, bool bSetupUndo = false)
	{
		CheckDestroyed();
		if (!SetGlobalTransformByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetGlobalTransformByIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGlobalTransformByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGlobalTransformByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetGlobalTransformByIndex_InElementIndex_Offset), 0, SetGlobalTransformByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		NativeReflection.InitializeValue_InContainer(SetGlobalTransformByIndex_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetGlobalTransformByIndex_InTransform_Offset), 0, SetGlobalTransformByIndex_InTransform_PropertyAddress.Address, InTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetGlobalTransformByIndex_bInitial_Offset), 0, SetGlobalTransformByIndex_bInitial_PropertyAddress.Address, bInitial);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetGlobalTransformByIndex_bAffectChildren_Offset), 0, SetGlobalTransformByIndex_bAffectChildren_PropertyAddress.Address, bAffectChildren);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetGlobalTransformByIndex_bSetupUndo_Offset), 0, SetGlobalTransformByIndex_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGlobalTransformByIndex_FunctionAddress, intPtr, SetGlobalTransformByIndex_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetGlobalTransform")]
	public unsafe void SetGlobalTransform(FRigElementKey InKey, FTransform InTransform, bool bInitial = false, bool bAffectChildren = true, bool bSetupUndo = false)
	{
		CheckDestroyed();
		if (!SetGlobalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetGlobalTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGlobalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGlobalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetGlobalTransform_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SetGlobalTransform_InKey_Offset), 0, SetGlobalTransform_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InitializeValue_InContainer(SetGlobalTransform_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetGlobalTransform_InTransform_Offset), 0, SetGlobalTransform_InTransform_PropertyAddress.Address, InTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetGlobalTransform_bInitial_Offset), 0, SetGlobalTransform_bInitial_PropertyAddress.Address, bInitial);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetGlobalTransform_bAffectChildren_Offset), 0, SetGlobalTransform_bAffectChildren_PropertyAddress.Address, bAffectChildren);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetGlobalTransform_bSetupUndo_Offset), 0, SetGlobalTransform_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGlobalTransform_FunctionAddress, intPtr, SetGlobalTransform_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetCurveValueByIndex")]
	public unsafe void SetCurveValueByIndex(int InElementIndex, float InValue, bool bSetupUndo = false)
	{
		CheckDestroyed();
		if (!SetCurveValueByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetCurveValueByIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurveValueByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurveValueByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCurveValueByIndex_InElementIndex_Offset), 0, SetCurveValueByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCurveValueByIndex_InValue_Offset), 0, SetCurveValueByIndex_InValue_PropertyAddress.Address, InValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCurveValueByIndex_bSetupUndo_Offset), 0, SetCurveValueByIndex_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCurveValueByIndex_FunctionAddress, intPtr, SetCurveValueByIndex_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetCurveValue")]
	public unsafe void SetCurveValue(FRigElementKey InKey, float InValue, bool bSetupUndo = false)
	{
		CheckDestroyed();
		if (!SetCurveValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetCurveValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurveValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurveValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetCurveValue_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SetCurveValue_InKey_Offset), 0, SetCurveValue_InKey_PropertyAddress.Address, InKey);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCurveValue_InValue_Offset), 0, SetCurveValue_InValue_PropertyAddress.Address, InValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCurveValue_bSetupUndo_Offset), 0, SetCurveValue_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCurveValue_FunctionAddress, intPtr, SetCurveValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetControlVisibilityByIndex")]
	public unsafe void SetControlVisibilityByIndex(int InElementIndex, bool bVisibility)
	{
		CheckDestroyed();
		if (!SetControlVisibilityByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetControlVisibilityByIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlVisibilityByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlVisibilityByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetControlVisibilityByIndex_InElementIndex_Offset), 0, SetControlVisibilityByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlVisibilityByIndex_bVisibility_Offset), 0, SetControlVisibilityByIndex_bVisibility_PropertyAddress.Address, bVisibility);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlVisibilityByIndex_FunctionAddress, intPtr, SetControlVisibilityByIndex_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetControlVisibility")]
	public unsafe void SetControlVisibility(FRigElementKey InKey, bool bVisibility)
	{
		CheckDestroyed();
		if (!SetControlVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetControlVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetControlVisibility_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SetControlVisibility_InKey_Offset), 0, SetControlVisibility_InKey_PropertyAddress.Address, InKey);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlVisibility_bVisibility_Offset), 0, SetControlVisibility_bVisibility_PropertyAddress.Address, bVisibility);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlVisibility_FunctionAddress, intPtr, SetControlVisibility_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetControlValueByIndex")]
	public unsafe void SetControlValueByIndex(int InElementIndex, FRigControlValue InValue, ERigControlValueType InValueType = ERigControlValueType.Current, bool bSetupUndo = false, bool bPrintPythonCommands = false)
	{
		CheckDestroyed();
		if (!SetControlValueByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetControlValueByIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlValueByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlValueByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetControlValueByIndex_InElementIndex_Offset), 0, SetControlValueByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		NativeReflection.InitializeValue_InContainer(SetControlValueByIndex_InValue_PropertyAddress.Address, intPtr);
		FRigControlValue.ToNative(IntPtr.Add(intPtr, SetControlValueByIndex_InValue_Offset), 0, SetControlValueByIndex_InValue_PropertyAddress.Address, InValue);
		EnumMarshaler<ERigControlValueType>.ToNative(IntPtr.Add(intPtr, SetControlValueByIndex_InValueType_Offset), 0, SetControlValueByIndex_InValueType_PropertyAddress.Address, InValueType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlValueByIndex_bSetupUndo_Offset), 0, SetControlValueByIndex_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlValueByIndex_bPrintPythonCommands_Offset), 0, SetControlValueByIndex_bPrintPythonCommands_PropertyAddress.Address, bPrintPythonCommands);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlValueByIndex_FunctionAddress, intPtr, SetControlValueByIndex_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetControlValue")]
	public unsafe void SetControlValue(FRigElementKey InKey, FRigControlValue InValue, ERigControlValueType InValueType = ERigControlValueType.Current, bool bSetupUndo = false, bool bPrintPythonCommands = false)
	{
		CheckDestroyed();
		if (!SetControlValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetControlValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetControlValue_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SetControlValue_InKey_Offset), 0, SetControlValue_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InitializeValue_InContainer(SetControlValue_InValue_PropertyAddress.Address, intPtr);
		FRigControlValue.ToNative(IntPtr.Add(intPtr, SetControlValue_InValue_Offset), 0, SetControlValue_InValue_PropertyAddress.Address, InValue);
		EnumMarshaler<ERigControlValueType>.ToNative(IntPtr.Add(intPtr, SetControlValue_InValueType_Offset), 0, SetControlValue_InValueType_PropertyAddress.Address, InValueType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlValue_bSetupUndo_Offset), 0, SetControlValue_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlValue_bPrintPythonCommands_Offset), 0, SetControlValue_bPrintPythonCommands_PropertyAddress.Address, bPrintPythonCommands);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlValue_FunctionAddress, intPtr, SetControlValue_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetControlShapeTransformByIndex")]
	public unsafe void SetControlShapeTransformByIndex(int InElementIndex, FTransform InTransform, bool bInitial = false, bool bSetupUndo = false)
	{
		CheckDestroyed();
		if (!SetControlShapeTransformByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetControlShapeTransformByIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlShapeTransformByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlShapeTransformByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetControlShapeTransformByIndex_InElementIndex_Offset), 0, SetControlShapeTransformByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		NativeReflection.InitializeValue_InContainer(SetControlShapeTransformByIndex_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetControlShapeTransformByIndex_InTransform_Offset), 0, SetControlShapeTransformByIndex_InTransform_PropertyAddress.Address, InTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlShapeTransformByIndex_bInitial_Offset), 0, SetControlShapeTransformByIndex_bInitial_PropertyAddress.Address, bInitial);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlShapeTransformByIndex_bSetupUndo_Offset), 0, SetControlShapeTransformByIndex_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlShapeTransformByIndex_FunctionAddress, intPtr, SetControlShapeTransformByIndex_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetControlShapeTransform")]
	public unsafe void SetControlShapeTransform(FRigElementKey InKey, FTransform InTransform, bool bInitial = false, bool bSetupUndo = false)
	{
		CheckDestroyed();
		if (!SetControlShapeTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetControlShapeTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlShapeTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlShapeTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetControlShapeTransform_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SetControlShapeTransform_InKey_Offset), 0, SetControlShapeTransform_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InitializeValue_InContainer(SetControlShapeTransform_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetControlShapeTransform_InTransform_Offset), 0, SetControlShapeTransform_InTransform_PropertyAddress.Address, InTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlShapeTransform_bInitial_Offset), 0, SetControlShapeTransform_bInitial_PropertyAddress.Address, bInitial);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlShapeTransform_bSetupUndo_Offset), 0, SetControlShapeTransform_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlShapeTransform_FunctionAddress, intPtr, SetControlShapeTransform_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetControlSettingsByIndex")]
	public unsafe void SetControlSettingsByIndex(int InElementIndex, FRigControlSettings InSettings, bool bSetupUndo = false, bool bForce = false, bool bPrintPythonCommands = false)
	{
		CheckDestroyed();
		if (!SetControlSettingsByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetControlSettingsByIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlSettingsByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlSettingsByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetControlSettingsByIndex_InElementIndex_Offset), 0, SetControlSettingsByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		NativeReflection.InitializeValue_InContainer(SetControlSettingsByIndex_InSettings_PropertyAddress.Address, intPtr);
		FRigControlSettings.ToNative(IntPtr.Add(intPtr, SetControlSettingsByIndex_InSettings_Offset), 0, SetControlSettingsByIndex_InSettings_PropertyAddress.Address, InSettings);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlSettingsByIndex_bSetupUndo_Offset), 0, SetControlSettingsByIndex_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlSettingsByIndex_bForce_Offset), 0, SetControlSettingsByIndex_bForce_PropertyAddress.Address, bForce);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlSettingsByIndex_bPrintPythonCommands_Offset), 0, SetControlSettingsByIndex_bPrintPythonCommands_PropertyAddress.Address, bPrintPythonCommands);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlSettingsByIndex_FunctionAddress, intPtr, SetControlSettingsByIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetControlSettingsByIndex_InSettings_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetControlSettings")]
	public unsafe void SetControlSettings(FRigElementKey InKey, FRigControlSettings InSettings, bool bSetupUndo = false, bool bForce = false, bool bPrintPythonCommands = false)
	{
		CheckDestroyed();
		if (!SetControlSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetControlSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetControlSettings_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SetControlSettings_InKey_Offset), 0, SetControlSettings_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InitializeValue_InContainer(SetControlSettings_InSettings_PropertyAddress.Address, intPtr);
		FRigControlSettings.ToNative(IntPtr.Add(intPtr, SetControlSettings_InSettings_Offset), 0, SetControlSettings_InSettings_PropertyAddress.Address, InSettings);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlSettings_bSetupUndo_Offset), 0, SetControlSettings_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlSettings_bForce_Offset), 0, SetControlSettings_bForce_PropertyAddress.Address, bForce);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlSettings_bPrintPythonCommands_Offset), 0, SetControlSettings_bPrintPythonCommands_PropertyAddress.Address, bPrintPythonCommands);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlSettings_FunctionAddress, intPtr, SetControlSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetControlSettings_InSettings_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetControlOffsetTransformByIndex")]
	public unsafe void SetControlOffsetTransformByIndex(int InElementIndex, FTransform InTransform, bool bInitial = false, bool bAffectChildren = true, bool bSetupUndo = false, bool bPrintPythonCommands = false)
	{
		CheckDestroyed();
		if (!SetControlOffsetTransformByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetControlOffsetTransformByIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlOffsetTransformByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlOffsetTransformByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetControlOffsetTransformByIndex_InElementIndex_Offset), 0, SetControlOffsetTransformByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		NativeReflection.InitializeValue_InContainer(SetControlOffsetTransformByIndex_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetControlOffsetTransformByIndex_InTransform_Offset), 0, SetControlOffsetTransformByIndex_InTransform_PropertyAddress.Address, InTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlOffsetTransformByIndex_bInitial_Offset), 0, SetControlOffsetTransformByIndex_bInitial_PropertyAddress.Address, bInitial);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlOffsetTransformByIndex_bAffectChildren_Offset), 0, SetControlOffsetTransformByIndex_bAffectChildren_PropertyAddress.Address, bAffectChildren);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlOffsetTransformByIndex_bSetupUndo_Offset), 0, SetControlOffsetTransformByIndex_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlOffsetTransformByIndex_bPrintPythonCommands_Offset), 0, SetControlOffsetTransformByIndex_bPrintPythonCommands_PropertyAddress.Address, bPrintPythonCommands);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlOffsetTransformByIndex_FunctionAddress, intPtr, SetControlOffsetTransformByIndex_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SetControlOffsetTransform")]
	public unsafe void SetControlOffsetTransform(FRigElementKey InKey, FTransform InTransform, bool bInitial = false, bool bAffectChildren = true, bool bSetupUndo = false, bool bPrintPythonCommands = false)
	{
		CheckDestroyed();
		if (!SetControlOffsetTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SetControlOffsetTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlOffsetTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlOffsetTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetControlOffsetTransform_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SetControlOffsetTransform_InKey_Offset), 0, SetControlOffsetTransform_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InitializeValue_InContainer(SetControlOffsetTransform_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetControlOffsetTransform_InTransform_Offset), 0, SetControlOffsetTransform_InTransform_PropertyAddress.Address, InTransform);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlOffsetTransform_bInitial_Offset), 0, SetControlOffsetTransform_bInitial_PropertyAddress.Address, bInitial);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlOffsetTransform_bAffectChildren_Offset), 0, SetControlOffsetTransform_bAffectChildren_PropertyAddress.Address, bAffectChildren);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlOffsetTransform_bSetupUndo_Offset), 0, SetControlOffsetTransform_bSetupUndo_PropertyAddress.Address, bSetupUndo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetControlOffsetTransform_bPrintPythonCommands_Offset), 0, SetControlOffsetTransform_bPrintPythonCommands_PropertyAddress.Address, bPrintPythonCommands);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlOffsetTransform_FunctionAddress, intPtr, SetControlOffsetTransform_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:SendAutoKeyEvent")]
	public unsafe void SendAutoKeyEvent(FRigElementKey InElement, float InOffsetInSeconds = 0f, bool bAsynchronous = true)
	{
		CheckDestroyed();
		if (!SendAutoKeyEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:SendAutoKeyEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SendAutoKeyEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SendAutoKeyEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SendAutoKeyEvent_InElement_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, SendAutoKeyEvent_InElement_Offset), 0, SendAutoKeyEvent_InElement_PropertyAddress.Address, InElement);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SendAutoKeyEvent_InOffsetInSeconds_Offset), 0, SendAutoKeyEvent_InOffsetInSeconds_PropertyAddress.Address, InOffsetInSeconds);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SendAutoKeyEvent_bAsynchronous_Offset), 0, SendAutoKeyEvent_bAsynchronous_PropertyAddress.Address, bAsynchronous);
		NativeReflection.InvokeFunctionOptimized(base.Address, SendAutoKeyEvent_FunctionAddress, intPtr, SendAutoKeyEvent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:ResetPoseToInitial")]
	public unsafe void ResetPoseToInitial(ERigElementType InTypeFilter)
	{
		CheckDestroyed();
		if (!ResetPoseToInitial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:ResetPoseToInitial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetPoseToInitial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetPoseToInitial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERigElementType>.ToNative(IntPtr.Add(intPtr, ResetPoseToInitial_InTypeFilter_Offset), 0, ResetPoseToInitial_InTypeFilter_PropertyAddress.Address, InTypeFilter);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResetPoseToInitial_FunctionAddress, intPtr, ResetPoseToInitial_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:ResetCurveValues")]
	public unsafe void ResetCurveValues()
	{
		CheckDestroyed();
		if (!ResetCurveValues_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:ResetCurveValues");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetCurveValues_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetCurveValues_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetCurveValues_FunctionAddress, argsSize: ResetCurveValues_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:Reset")]
	public unsafe void Reset()
	{
		CheckDestroyed();
		if (!Reset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:Reset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Reset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Reset_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Reset_FunctionAddress, argsSize: Reset_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:Num")]
	public unsafe int Num()
	{
		CheckDestroyed();
		if (!Num_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:Num");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Num_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Num_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Num_FunctionAddress, intPtr, Num_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Num_ReturnValue_Offset), 0, Num_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:MakeControlValueFromVector2D")]
	public unsafe static FRigControlValue MakeControlValueFromVector2D(FVector2D InValue)
	{
		if (!MakeControlValueFromVector2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:MakeControlValueFromVector2D");
			return default(FRigControlValue);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeControlValueFromVector2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeControlValueFromVector2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, MakeControlValueFromVector2D_InValue_Offset), 0, MakeControlValueFromVector2D_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeControlValueFromVector2D_FunctionAddress, intPtr, MakeControlValueFromVector2D_ParamsSize);
		return FRigControlValue.FromNative(IntPtr.Add(intPtr, MakeControlValueFromVector2D_ReturnValue_Offset), 0, MakeControlValueFromVector2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:MakeControlValueFromVector")]
	public unsafe static FRigControlValue MakeControlValueFromVector(FVector InValue)
	{
		if (!MakeControlValueFromVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:MakeControlValueFromVector");
			return default(FRigControlValue);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeControlValueFromVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeControlValueFromVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, MakeControlValueFromVector_InValue_Offset), 0, MakeControlValueFromVector_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeControlValueFromVector_FunctionAddress, intPtr, MakeControlValueFromVector_ParamsSize);
		return FRigControlValue.FromNative(IntPtr.Add(intPtr, MakeControlValueFromVector_ReturnValue_Offset), 0, MakeControlValueFromVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:MakeControlValueFromTransformNoScale")]
	public unsafe static FRigControlValue MakeControlValueFromTransformNoScale(FTransformNoScale InValue)
	{
		if (!MakeControlValueFromTransformNoScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:MakeControlValueFromTransformNoScale");
			return default(FRigControlValue);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeControlValueFromTransformNoScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeControlValueFromTransformNoScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MakeControlValueFromTransformNoScale_InValue_PropertyAddress.Address, intPtr);
		FTransformNoScale.ToNative(IntPtr.Add(intPtr, MakeControlValueFromTransformNoScale_InValue_Offset), 0, MakeControlValueFromTransformNoScale_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeControlValueFromTransformNoScale_FunctionAddress, intPtr, MakeControlValueFromTransformNoScale_ParamsSize);
		return FRigControlValue.FromNative(IntPtr.Add(intPtr, MakeControlValueFromTransformNoScale_ReturnValue_Offset), 0, MakeControlValueFromTransformNoScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:MakeControlValueFromTransform")]
	public unsafe static FRigControlValue MakeControlValueFromTransform(FTransform InValue)
	{
		if (!MakeControlValueFromTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:MakeControlValueFromTransform");
			return default(FRigControlValue);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeControlValueFromTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeControlValueFromTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MakeControlValueFromTransform_InValue_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, MakeControlValueFromTransform_InValue_Offset), 0, MakeControlValueFromTransform_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeControlValueFromTransform_FunctionAddress, intPtr, MakeControlValueFromTransform_ParamsSize);
		return FRigControlValue.FromNative(IntPtr.Add(intPtr, MakeControlValueFromTransform_ReturnValue_Offset), 0, MakeControlValueFromTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:MakeControlValueFromRotator")]
	public unsafe static FRigControlValue MakeControlValueFromRotator(FRotator InValue)
	{
		if (!MakeControlValueFromRotator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:MakeControlValueFromRotator");
			return default(FRigControlValue);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeControlValueFromRotator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeControlValueFromRotator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, MakeControlValueFromRotator_InValue_Offset), 0, MakeControlValueFromRotator_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeControlValueFromRotator_FunctionAddress, intPtr, MakeControlValueFromRotator_ParamsSize);
		return FRigControlValue.FromNative(IntPtr.Add(intPtr, MakeControlValueFromRotator_ReturnValue_Offset), 0, MakeControlValueFromRotator_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:MakeControlValueFromInt")]
	public unsafe static FRigControlValue MakeControlValueFromInt(int InValue)
	{
		if (!MakeControlValueFromInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:MakeControlValueFromInt");
			return default(FRigControlValue);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeControlValueFromInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeControlValueFromInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeControlValueFromInt_InValue_Offset), 0, MakeControlValueFromInt_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeControlValueFromInt_FunctionAddress, intPtr, MakeControlValueFromInt_ParamsSize);
		return FRigControlValue.FromNative(IntPtr.Add(intPtr, MakeControlValueFromInt_ReturnValue_Offset), 0, MakeControlValueFromInt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:MakeControlValueFromFloat")]
	public unsafe static FRigControlValue MakeControlValueFromFloat(float InValue)
	{
		if (!MakeControlValueFromFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:MakeControlValueFromFloat");
			return default(FRigControlValue);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeControlValueFromFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeControlValueFromFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeControlValueFromFloat_InValue_Offset), 0, MakeControlValueFromFloat_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeControlValueFromFloat_FunctionAddress, intPtr, MakeControlValueFromFloat_ParamsSize);
		return FRigControlValue.FromNative(IntPtr.Add(intPtr, MakeControlValueFromFloat_ReturnValue_Offset), 0, MakeControlValueFromFloat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:MakeControlValueFromEulerTransform")]
	public unsafe static FRigControlValue MakeControlValueFromEulerTransform(FEulerTransform InValue)
	{
		if (!MakeControlValueFromEulerTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:MakeControlValueFromEulerTransform");
			return default(FRigControlValue);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeControlValueFromEulerTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeControlValueFromEulerTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MakeControlValueFromEulerTransform_InValue_PropertyAddress.Address, intPtr);
		FEulerTransform.ToNative(IntPtr.Add(intPtr, MakeControlValueFromEulerTransform_InValue_Offset), 0, MakeControlValueFromEulerTransform_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeControlValueFromEulerTransform_FunctionAddress, intPtr, MakeControlValueFromEulerTransform_ParamsSize);
		return FRigControlValue.FromNative(IntPtr.Add(intPtr, MakeControlValueFromEulerTransform_ReturnValue_Offset), 0, MakeControlValueFromEulerTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:MakeControlValueFromBool")]
	public unsafe static FRigControlValue MakeControlValueFromBool(bool InValue)
	{
		if (!MakeControlValueFromBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:MakeControlValueFromBool");
			return default(FRigControlValue);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeControlValueFromBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeControlValueFromBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MakeControlValueFromBool_InValue_Offset), 0, MakeControlValueFromBool_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeControlValueFromBool_FunctionAddress, intPtr, MakeControlValueFromBool_ParamsSize);
		return FRigControlValue.FromNative(IntPtr.Add(intPtr, MakeControlValueFromBool_ReturnValue_Offset), 0, MakeControlValueFromBool_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:IsValidIndex")]
	public unsafe bool IsValidIndex(int InElementIndex)
	{
		CheckDestroyed();
		if (!IsValidIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:IsValidIndex");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IsValidIndex_InElementIndex_Offset), 0, IsValidIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsValidIndex_FunctionAddress, intPtr, IsValidIndex_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidIndex_ReturnValue_Offset), 0, IsValidIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:IsSelectedByIndex")]
	public unsafe bool IsSelectedByIndex(int InIndex)
	{
		CheckDestroyed();
		if (!IsSelectedByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:IsSelectedByIndex");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSelectedByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSelectedByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, IsSelectedByIndex_InIndex_Offset), 0, IsSelectedByIndex_InIndex_PropertyAddress.Address, InIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSelectedByIndex_FunctionAddress, intPtr, IsSelectedByIndex_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSelectedByIndex_ReturnValue_Offset), 0, IsSelectedByIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:IsSelected")]
	public unsafe bool IsSelected(FRigElementKey InKey)
	{
		CheckDestroyed();
		if (!IsSelected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:IsSelected");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSelected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSelected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsSelected_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, IsSelected_InKey_Offset), 0, IsSelected_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSelected_FunctionAddress, intPtr, IsSelected_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSelected_ReturnValue_Offset), 0, IsSelected_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:IsParentedTo")]
	public unsafe bool IsParentedTo(FRigElementKey InChild, FRigElementKey InParent)
	{
		CheckDestroyed();
		if (!IsParentedTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:IsParentedTo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsParentedTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsParentedTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsParentedTo_InChild_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, IsParentedTo_InChild_Offset), 0, IsParentedTo_InChild_PropertyAddress.Address, InChild);
		NativeReflection.InitializeValue_InContainer(IsParentedTo_InParent_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, IsParentedTo_InParent_Offset), 0, IsParentedTo_InParent_PropertyAddress.Address, InParent);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsParentedTo_FunctionAddress, intPtr, IsParentedTo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsParentedTo_ReturnValue_Offset), 0, IsParentedTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetVectorFromControlValue")]
	public unsafe static FVector GetVectorFromControlValue(FRigControlValue InValue)
	{
		if (!GetVectorFromControlValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetVectorFromControlValue");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorFromControlValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorFromControlValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVectorFromControlValue_InValue_PropertyAddress.Address, intPtr);
		FRigControlValue.ToNative(IntPtr.Add(intPtr, GetVectorFromControlValue_InValue_Offset), 0, GetVectorFromControlValue_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVectorFromControlValue_FunctionAddress, intPtr, GetVectorFromControlValue_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVectorFromControlValue_ReturnValue_Offset), 0, GetVectorFromControlValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetVector2DFromControlValue")]
	public unsafe static FVector2D GetVector2DFromControlValue(FRigControlValue InValue)
	{
		if (!GetVector2DFromControlValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetVector2DFromControlValue");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVector2DFromControlValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVector2DFromControlValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVector2DFromControlValue_InValue_PropertyAddress.Address, intPtr);
		FRigControlValue.ToNative(IntPtr.Add(intPtr, GetVector2DFromControlValue_InValue_Offset), 0, GetVector2DFromControlValue_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVector2DFromControlValue_FunctionAddress, intPtr, GetVector2DFromControlValue_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetVector2DFromControlValue_ReturnValue_Offset), 0, GetVector2DFromControlValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetTransformNoScaleFromControlValue")]
	public unsafe static FTransformNoScale GetTransformNoScaleFromControlValue(FRigControlValue InValue)
	{
		if (!GetTransformNoScaleFromControlValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetTransformNoScaleFromControlValue");
			return default(FTransformNoScale);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransformNoScaleFromControlValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransformNoScaleFromControlValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTransformNoScaleFromControlValue_InValue_PropertyAddress.Address, intPtr);
		FRigControlValue.ToNative(IntPtr.Add(intPtr, GetTransformNoScaleFromControlValue_InValue_Offset), 0, GetTransformNoScaleFromControlValue_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTransformNoScaleFromControlValue_FunctionAddress, intPtr, GetTransformNoScaleFromControlValue_ParamsSize);
		return FTransformNoScale.FromNative(IntPtr.Add(intPtr, GetTransformNoScaleFromControlValue_ReturnValue_Offset), 0, GetTransformNoScaleFromControlValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetTransformFromControlValue")]
	public unsafe static FTransform GetTransformFromControlValue(FRigControlValue InValue)
	{
		if (!GetTransformFromControlValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetTransformFromControlValue");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransformFromControlValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransformFromControlValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTransformFromControlValue_InValue_PropertyAddress.Address, intPtr);
		FRigControlValue.ToNative(IntPtr.Add(intPtr, GetTransformFromControlValue_InValue_Offset), 0, GetTransformFromControlValue_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTransformFromControlValue_FunctionAddress, intPtr, GetTransformFromControlValue_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetTransformFromControlValue_ReturnValue_Offset), 0, GetTransformFromControlValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetSelectedKeys")]
	public unsafe List<FRigElementKey> GetSelectedKeys(ERigElementType InTypeFilter = ERigElementType.All)
	{
		CheckDestroyed();
		if (!GetSelectedKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetSelectedKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERigElementType>.ToNative(IntPtr.Add(intPtr, GetSelectedKeys_InTypeFilter_Offset), 0, GetSelectedKeys_InTypeFilter_PropertyAddress.Address, InTypeFilter);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedKeys_FunctionAddress, intPtr, GetSelectedKeys_ParamsSize);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, GetSelectedKeys_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedKeys_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedKeys_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetRotatorFromControlValue")]
	public unsafe static FRotator GetRotatorFromControlValue(FRigControlValue InValue)
	{
		if (!GetRotatorFromControlValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetRotatorFromControlValue");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRotatorFromControlValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRotatorFromControlValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetRotatorFromControlValue_InValue_PropertyAddress.Address, intPtr);
		FRigControlValue.ToNative(IntPtr.Add(intPtr, GetRotatorFromControlValue_InValue_Offset), 0, GetRotatorFromControlValue_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRotatorFromControlValue_FunctionAddress, intPtr, GetRotatorFromControlValue_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetRotatorFromControlValue_ReturnValue_Offset), 0, GetRotatorFromControlValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "GetRigidBodyKeys")]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetRigidBodyKeys")]
	public unsafe List<FRigElementKey> GetRigidBodies(bool bTraverse = true)
	{
		CheckDestroyed();
		if (!GetRigidBodies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetRigidBodyKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRigidBodies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRigidBodies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetRigidBodies_bTraverse_Offset), 0, GetRigidBodies_bTraverse_PropertyAddress.Address, bTraverse);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRigidBodies_FunctionAddress, intPtr, GetRigidBodies_ParamsSize);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, GetRigidBodies_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, GetRigidBodies_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetRigidBodies_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u, OriginalName = "GetReferenceKeys")]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetReferenceKeys")]
	public unsafe List<FRigElementKey> GetReferences(bool bTraverse = true)
	{
		CheckDestroyed();
		if (!GetReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetReferenceKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReferences_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetReferences_bTraverse_Offset), 0, GetReferences_bTraverse_PropertyAddress.Address, bTraverse);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetReferences_FunctionAddress, intPtr, GetReferences_ParamsSize);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, GetReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, GetReferences_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetReferences_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetPreviousParent")]
	public unsafe FRigElementKey GetPreviousParent(FRigElementKey InKey)
	{
		CheckDestroyed();
		if (!GetPreviousParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetPreviousParent");
			return default(FRigElementKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreviousParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreviousParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPreviousParent_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetPreviousParent_InKey_Offset), 0, GetPreviousParent_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreviousParent_FunctionAddress, intPtr, GetPreviousParent_ParamsSize);
		return FRigElementKey.FromNative(IntPtr.Add(intPtr, GetPreviousParent_ReturnValue_Offset), 0, GetPreviousParent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetPreviousName")]
	public unsafe FName GetPreviousName(FRigElementKey InKey)
	{
		CheckDestroyed();
		if (!GetPreviousName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetPreviousName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreviousName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreviousName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPreviousName_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetPreviousName_InKey_Offset), 0, GetPreviousName_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreviousName_FunctionAddress, intPtr, GetPreviousName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetPreviousName_ReturnValue_Offset), 0, GetPreviousName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetPose")]
	public unsafe FRigPose GetPose(bool bInitial = false)
	{
		CheckDestroyed();
		if (!GetPose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetPose");
			return default(FRigPose);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetPose_bInitial_Offset), 0, GetPose_bInitial_PropertyAddress.Address, bInitial);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPose_FunctionAddress, intPtr, GetPose_ParamsSize);
		FRigPose result = FRigPose.FromNative(IntPtr.Add(intPtr, GetPose_ReturnValue_Offset), 0, GetPose_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPose_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetParentWeightArray")]
	public unsafe List<FRigElementWeight> GetParentWeightArray(FRigElementKey InChild, bool bInitial = false)
	{
		CheckDestroyed();
		if (!GetParentWeightArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetParentWeightArray");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentWeightArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentWeightArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParentWeightArray_InChild_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetParentWeightArray_InChild_Offset), 0, GetParentWeightArray_InChild_PropertyAddress.Address, InChild);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetParentWeightArray_bInitial_Offset), 0, GetParentWeightArray_bInitial_PropertyAddress.Address, bInitial);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParentWeightArray_FunctionAddress, intPtr, GetParentWeightArray_ParamsSize);
		List<FRigElementWeight> result = new TArrayCopyMarshaler<FRigElementWeight>(1, GetParentWeightArray_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementWeight, FRigElementWeight>.FromNative, CachedMarshalingDelegates<FRigElementWeight, FRigElementWeight>.ToNative).FromNative(IntPtr.Add(intPtr, GetParentWeightArray_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetParentWeightArray_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetParentWeight")]
	public unsafe FRigElementWeight GetParentWeight(FRigElementKey InChild, FRigElementKey InParent, bool bInitial = false)
	{
		CheckDestroyed();
		if (!GetParentWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetParentWeight");
			return default(FRigElementWeight);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParentWeight_InChild_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetParentWeight_InChild_Offset), 0, GetParentWeight_InChild_PropertyAddress.Address, InChild);
		NativeReflection.InitializeValue_InContainer(GetParentWeight_InParent_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetParentWeight_InParent_Offset), 0, GetParentWeight_InParent_PropertyAddress.Address, InParent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetParentWeight_bInitial_Offset), 0, GetParentWeight_bInitial_PropertyAddress.Address, bInitial);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParentWeight_FunctionAddress, intPtr, GetParentWeight_ParamsSize);
		return FRigElementWeight.FromNative(IntPtr.Add(intPtr, GetParentWeight_ReturnValue_Offset), 0, GetParentWeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetParentTransformByIndex")]
	public unsafe FTransform GetParentTransformByIndex(int InElementIndex, bool bInitial = false)
	{
		CheckDestroyed();
		if (!GetParentTransformByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetParentTransformByIndex");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentTransformByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentTransformByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetParentTransformByIndex_InElementIndex_Offset), 0, GetParentTransformByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetParentTransformByIndex_bInitial_Offset), 0, GetParentTransformByIndex_bInitial_PropertyAddress.Address, bInitial);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParentTransformByIndex_FunctionAddress, intPtr, GetParentTransformByIndex_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetParentTransformByIndex_ReturnValue_Offset), 0, GetParentTransformByIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetParentTransform")]
	public unsafe FTransform GetParentTransform(FRigElementKey InKey, bool bInitial = false)
	{
		CheckDestroyed();
		if (!GetParentTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetParentTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParentTransform_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetParentTransform_InKey_Offset), 0, GetParentTransform_InKey_PropertyAddress.Address, InKey);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetParentTransform_bInitial_Offset), 0, GetParentTransform_bInitial_PropertyAddress.Address, bInitial);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParentTransform_FunctionAddress, intPtr, GetParentTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetParentTransform_ReturnValue_Offset), 0, GetParentTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetParents")]
	public unsafe List<FRigElementKey> GetParents(FRigElementKey InKey, bool bRecursive = false)
	{
		CheckDestroyed();
		if (!GetParents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetParents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParents_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetParents_InKey_Offset), 0, GetParents_InKey_PropertyAddress.Address, InKey);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetParents_bRecursive_Offset), 0, GetParents_bRecursive_PropertyAddress.Address, bRecursive);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParents_FunctionAddress, intPtr, GetParents_ParamsSize);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, GetParents_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, GetParents_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetParents_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetNumberOfParents")]
	public unsafe int GetNumberOfParents(FRigElementKey InKey)
	{
		CheckDestroyed();
		if (!GetNumberOfParents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetNumberOfParents");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumberOfParents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumberOfParents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumberOfParents_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetNumberOfParents_InKey_Offset), 0, GetNumberOfParents_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumberOfParents_FunctionAddress, intPtr, GetNumberOfParents_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumberOfParents_ReturnValue_Offset), 0, GetNumberOfParents_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "GetNullKeys")]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetNullKeys")]
	public unsafe List<FRigElementKey> GetNulls(bool bTraverse = true)
	{
		CheckDestroyed();
		if (!GetNulls_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetNullKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNulls_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNulls_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetNulls_bTraverse_Offset), 0, GetNulls_bTraverse_PropertyAddress.Address, bTraverse);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNulls_FunctionAddress, intPtr, GetNulls_ParamsSize);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, GetNulls_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, GetNulls_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNulls_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetLocalTransformByIndex")]
	public unsafe FTransform GetLocalTransformByIndex(int InElementIndex, bool bInitial = false)
	{
		CheckDestroyed();
		if (!GetLocalTransformByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetLocalTransformByIndex");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalTransformByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalTransformByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetLocalTransformByIndex_InElementIndex_Offset), 0, GetLocalTransformByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetLocalTransformByIndex_bInitial_Offset), 0, GetLocalTransformByIndex_bInitial_PropertyAddress.Address, bInitial);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocalTransformByIndex_FunctionAddress, intPtr, GetLocalTransformByIndex_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetLocalTransformByIndex_ReturnValue_Offset), 0, GetLocalTransformByIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetLocalTransform")]
	public unsafe FTransform GetLocalTransform(FRigElementKey InKey, bool bInitial = false)
	{
		CheckDestroyed();
		if (!GetLocalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetLocalTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLocalTransform_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetLocalTransform_InKey_Offset), 0, GetLocalTransform_InKey_PropertyAddress.Address, InKey);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetLocalTransform_bInitial_Offset), 0, GetLocalTransform_bInitial_PropertyAddress.Address, bInitial);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocalTransform_FunctionAddress, intPtr, GetLocalTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetLocalTransform_ReturnValue_Offset), 0, GetLocalTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetKey")]
	public unsafe FRigElementKey GetKey(int InElementIndex)
	{
		CheckDestroyed();
		if (!GetKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetKey");
			return default(FRigElementKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetKey_InElementIndex_Offset), 0, GetKey_InElementIndex_PropertyAddress.Address, InElementIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetKey_FunctionAddress, intPtr, GetKey_ParamsSize);
		return FRigElementKey.FromNative(IntPtr.Add(intPtr, GetKey_ReturnValue_Offset), 0, GetKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetIntFromControlValue")]
	public unsafe static int GetIntFromControlValue(FRigControlValue InValue)
	{
		if (!GetIntFromControlValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetIntFromControlValue");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIntFromControlValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIntFromControlValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetIntFromControlValue_InValue_PropertyAddress.Address, intPtr);
		FRigControlValue.ToNative(IntPtr.Add(intPtr, GetIntFromControlValue_InValue_Offset), 0, GetIntFromControlValue_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIntFromControlValue_FunctionAddress, intPtr, GetIntFromControlValue_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetIntFromControlValue_ReturnValue_Offset), 0, GetIntFromControlValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "GetIndex_ForBlueprint")]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetIndex_ForBlueprint")]
	public unsafe int GetIndex(FRigElementKey InKey)
	{
		CheckDestroyed();
		if (!GetIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetIndex_ForBlueprint");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetIndex_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetIndex_InKey_Offset), 0, GetIndex_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIndex_FunctionAddress, intPtr, GetIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetIndex_ReturnValue_Offset), 0, GetIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetGlobalTransformByIndex")]
	public unsafe FTransform GetGlobalTransformByIndex(int InElementIndex, bool bInitial = false)
	{
		CheckDestroyed();
		if (!GetGlobalTransformByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetGlobalTransformByIndex");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGlobalTransformByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGlobalTransformByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetGlobalTransformByIndex_InElementIndex_Offset), 0, GetGlobalTransformByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetGlobalTransformByIndex_bInitial_Offset), 0, GetGlobalTransformByIndex_bInitial_PropertyAddress.Address, bInitial);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGlobalTransformByIndex_FunctionAddress, intPtr, GetGlobalTransformByIndex_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetGlobalTransformByIndex_ReturnValue_Offset), 0, GetGlobalTransformByIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetGlobalTransform")]
	public unsafe FTransform GetGlobalTransform(FRigElementKey InKey, bool bInitial = false)
	{
		CheckDestroyed();
		if (!GetGlobalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetGlobalTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGlobalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGlobalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetGlobalTransform_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetGlobalTransform_InKey_Offset), 0, GetGlobalTransform_InKey_PropertyAddress.Address, InKey);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetGlobalTransform_bInitial_Offset), 0, GetGlobalTransform_bInitial_PropertyAddress.Address, bInitial);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGlobalTransform_FunctionAddress, intPtr, GetGlobalTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetGlobalTransform_ReturnValue_Offset), 0, GetGlobalTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetGlobalControlShapeTransformByIndex")]
	public unsafe FTransform GetGlobalControlShapeTransformByIndex(int InElementIndex, bool bInitial = false)
	{
		CheckDestroyed();
		if (!GetGlobalControlShapeTransformByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetGlobalControlShapeTransformByIndex");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGlobalControlShapeTransformByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGlobalControlShapeTransformByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetGlobalControlShapeTransformByIndex_InElementIndex_Offset), 0, GetGlobalControlShapeTransformByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetGlobalControlShapeTransformByIndex_bInitial_Offset), 0, GetGlobalControlShapeTransformByIndex_bInitial_PropertyAddress.Address, bInitial);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGlobalControlShapeTransformByIndex_FunctionAddress, intPtr, GetGlobalControlShapeTransformByIndex_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetGlobalControlShapeTransformByIndex_ReturnValue_Offset), 0, GetGlobalControlShapeTransformByIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetGlobalControlShapeTransform")]
	public unsafe FTransform GetGlobalControlShapeTransform(FRigElementKey InKey, bool bInitial = false)
	{
		CheckDestroyed();
		if (!GetGlobalControlShapeTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetGlobalControlShapeTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGlobalControlShapeTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGlobalControlShapeTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetGlobalControlShapeTransform_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetGlobalControlShapeTransform_InKey_Offset), 0, GetGlobalControlShapeTransform_InKey_PropertyAddress.Address, InKey);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetGlobalControlShapeTransform_bInitial_Offset), 0, GetGlobalControlShapeTransform_bInitial_PropertyAddress.Address, bInitial);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGlobalControlShapeTransform_FunctionAddress, intPtr, GetGlobalControlShapeTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetGlobalControlShapeTransform_ReturnValue_Offset), 0, GetGlobalControlShapeTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetGlobalControlOffsetTransformByIndex")]
	public unsafe FTransform GetGlobalControlOffsetTransformByIndex(int InElementIndex, bool bInitial = false)
	{
		CheckDestroyed();
		if (!GetGlobalControlOffsetTransformByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetGlobalControlOffsetTransformByIndex");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGlobalControlOffsetTransformByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGlobalControlOffsetTransformByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetGlobalControlOffsetTransformByIndex_InElementIndex_Offset), 0, GetGlobalControlOffsetTransformByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetGlobalControlOffsetTransformByIndex_bInitial_Offset), 0, GetGlobalControlOffsetTransformByIndex_bInitial_PropertyAddress.Address, bInitial);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGlobalControlOffsetTransformByIndex_FunctionAddress, intPtr, GetGlobalControlOffsetTransformByIndex_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetGlobalControlOffsetTransformByIndex_ReturnValue_Offset), 0, GetGlobalControlOffsetTransformByIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetGlobalControlOffsetTransform")]
	public unsafe FTransform GetGlobalControlOffsetTransform(FRigElementKey InKey, bool bInitial = false)
	{
		CheckDestroyed();
		if (!GetGlobalControlOffsetTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetGlobalControlOffsetTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGlobalControlOffsetTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGlobalControlOffsetTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetGlobalControlOffsetTransform_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetGlobalControlOffsetTransform_InKey_Offset), 0, GetGlobalControlOffsetTransform_InKey_PropertyAddress.Address, InKey);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetGlobalControlOffsetTransform_bInitial_Offset), 0, GetGlobalControlOffsetTransform_bInitial_PropertyAddress.Address, bInitial);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGlobalControlOffsetTransform_FunctionAddress, intPtr, GetGlobalControlOffsetTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetGlobalControlOffsetTransform_ReturnValue_Offset), 0, GetGlobalControlOffsetTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetFloatFromControlValue")]
	public unsafe static float GetFloatFromControlValue(FRigControlValue InValue)
	{
		if (!GetFloatFromControlValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetFloatFromControlValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloatFromControlValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloatFromControlValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetFloatFromControlValue_InValue_PropertyAddress.Address, intPtr);
		FRigControlValue.ToNative(IntPtr.Add(intPtr, GetFloatFromControlValue_InValue_Offset), 0, GetFloatFromControlValue_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFloatFromControlValue_FunctionAddress, intPtr, GetFloatFromControlValue_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFloatFromControlValue_ReturnValue_Offset), 0, GetFloatFromControlValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetFirstParent")]
	public unsafe FRigElementKey GetFirstParent(FRigElementKey InKey)
	{
		CheckDestroyed();
		if (!GetFirstParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetFirstParent");
			return default(FRigElementKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFirstParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFirstParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetFirstParent_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetFirstParent_InKey_Offset), 0, GetFirstParent_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFirstParent_FunctionAddress, intPtr, GetFirstParent_ParamsSize);
		return FRigElementKey.FromNative(IntPtr.Add(intPtr, GetFirstParent_ReturnValue_Offset), 0, GetFirstParent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetEulerTransformFromControlValue")]
	public unsafe static FEulerTransform GetEulerTransformFromControlValue(FRigControlValue InValue)
	{
		if (!GetEulerTransformFromControlValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetEulerTransformFromControlValue");
			return default(FEulerTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEulerTransformFromControlValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEulerTransformFromControlValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetEulerTransformFromControlValue_InValue_PropertyAddress.Address, intPtr);
		FRigControlValue.ToNative(IntPtr.Add(intPtr, GetEulerTransformFromControlValue_InValue_Offset), 0, GetEulerTransformFromControlValue_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEulerTransformFromControlValue_FunctionAddress, intPtr, GetEulerTransformFromControlValue_ParamsSize);
		return FEulerTransform.FromNative(IntPtr.Add(intPtr, GetEulerTransformFromControlValue_ReturnValue_Offset), 0, GetEulerTransformFromControlValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetCurveValueByIndex")]
	public unsafe float GetCurveValueByIndex(int InElementIndex)
	{
		CheckDestroyed();
		if (!GetCurveValueByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetCurveValueByIndex");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurveValueByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurveValueByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetCurveValueByIndex_InElementIndex_Offset), 0, GetCurveValueByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurveValueByIndex_FunctionAddress, intPtr, GetCurveValueByIndex_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurveValueByIndex_ReturnValue_Offset), 0, GetCurveValueByIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetCurveValue")]
	public unsafe float GetCurveValue(FRigElementKey InKey)
	{
		CheckDestroyed();
		if (!GetCurveValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetCurveValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurveValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurveValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetCurveValue_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetCurveValue_InKey_Offset), 0, GetCurveValue_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurveValue_FunctionAddress, intPtr, GetCurveValue_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurveValue_ReturnValue_Offset), 0, GetCurveValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "GetCurveKeys")]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetCurveKeys")]
	public unsafe List<FRigElementKey> GetCurves()
	{
		CheckDestroyed();
		if (!GetCurves_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetCurveKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurves_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurves_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurves_FunctionAddress, intPtr, GetCurves_ParamsSize);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, GetCurves_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, GetCurves_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCurves_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetControlValueByIndex")]
	public unsafe FRigControlValue GetControlValueByIndex(int InElementIndex, ERigControlValueType InValueType = ERigControlValueType.Current)
	{
		CheckDestroyed();
		if (!GetControlValueByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetControlValueByIndex");
			return default(FRigControlValue);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlValueByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlValueByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetControlValueByIndex_InElementIndex_Offset), 0, GetControlValueByIndex_InElementIndex_PropertyAddress.Address, InElementIndex);
		EnumMarshaler<ERigControlValueType>.ToNative(IntPtr.Add(intPtr, GetControlValueByIndex_InValueType_Offset), 0, GetControlValueByIndex_InValueType_PropertyAddress.Address, InValueType);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlValueByIndex_FunctionAddress, intPtr, GetControlValueByIndex_ParamsSize);
		return FRigControlValue.FromNative(IntPtr.Add(intPtr, GetControlValueByIndex_ReturnValue_Offset), 0, GetControlValueByIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetControlValue")]
	public unsafe FRigControlValue GetControlValue(FRigElementKey InKey, ERigControlValueType InValueType = ERigControlValueType.Current)
	{
		CheckDestroyed();
		if (!GetControlValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetControlValue");
			return default(FRigControlValue);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetControlValue_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetControlValue_InKey_Offset), 0, GetControlValue_InKey_PropertyAddress.Address, InKey);
		EnumMarshaler<ERigControlValueType>.ToNative(IntPtr.Add(intPtr, GetControlValue_InValueType_Offset), 0, GetControlValue_InValueType_PropertyAddress.Address, InValueType);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlValue_FunctionAddress, intPtr, GetControlValue_ParamsSize);
		return FRigControlValue.FromNative(IntPtr.Add(intPtr, GetControlValue_ReturnValue_Offset), 0, GetControlValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetController")]
	public unsafe URigHierarchyController GetController(bool bCreateIfNeeded = true)
	{
		CheckDestroyed();
		if (!GetController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetController_bCreateIfNeeded_Offset), 0, GetController_bCreateIfNeeded_PropertyAddress.Address, bCreateIfNeeded);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetController_FunctionAddress, intPtr, GetController_ParamsSize);
		return UObjectMarshaler<URigHierarchyController>.FromNative(IntPtr.Add(intPtr, GetController_ReturnValue_Offset), 0, GetController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "GetControlKeys")]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetControlKeys")]
	public unsafe List<FRigElementKey> GetControls(bool bTraverse = true)
	{
		CheckDestroyed();
		if (!GetControls_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetControlKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControls_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControls_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetControls_bTraverse_Offset), 0, GetControls_bTraverse_PropertyAddress.Address, bTraverse);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControls_FunctionAddress, intPtr, GetControls_ParamsSize);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, GetControls_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, GetControls_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetControls_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetChildren")]
	public unsafe List<FRigElementKey> GetChildren(FRigElementKey InKey, bool bRecursive = false)
	{
		CheckDestroyed();
		if (!GetChildren_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetChildren");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildren_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildren_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetChildren_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, GetChildren_InKey_Offset), 0, GetChildren_InKey_PropertyAddress.Address, InKey);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetChildren_bRecursive_Offset), 0, GetChildren_bRecursive_PropertyAddress.Address, bRecursive);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetChildren_FunctionAddress, intPtr, GetChildren_ParamsSize);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, GetChildren_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, GetChildren_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetChildren_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u, OriginalName = "GetBoneKeys")]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetBoneKeys")]
	public unsafe List<FRigElementKey> GetBones(bool bTraverse = true)
	{
		CheckDestroyed();
		if (!GetBones_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetBoneKeys");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBones_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBones_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetBones_bTraverse_Offset), 0, GetBones_bTraverse_PropertyAddress.Address, bTraverse);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBones_FunctionAddress, intPtr, GetBones_ParamsSize);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, GetBones_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, GetBones_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetBones_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u, OriginalName = "GetAllKeys_ForBlueprint")]
	[UMetaPath("/Script/ControlRig.RigHierarchy:GetAllKeys_ForBlueprint")]
	public unsafe List<FRigElementKey> GetAllKeys(bool bTraverse = true)
	{
		CheckDestroyed();
		if (!GetAllKeys_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:GetAllKeys_ForBlueprint");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllKeys_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllKeys_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAllKeys_bTraverse_Offset), 0, GetAllKeys_bTraverse_PropertyAddress.Address, bTraverse);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllKeys_FunctionAddress, intPtr, GetAllKeys_ParamsSize);
		List<FRigElementKey> result = new TArrayCopyMarshaler<FRigElementKey>(1, GetAllKeys_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.FromNative, CachedMarshalingDelegates<FRigElementKey, FRigElementKey>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllKeys_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllKeys_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1413743617u, OriginalName = "FindNull_ForBlueprintOnly")]
	[UMetaPath("/Script/ControlRig.RigHierarchy:FindNull_ForBlueprintOnly")]
	public unsafe FRigNullElement FindNull(FRigElementKey InKey)
	{
		CheckDestroyed();
		if (!FindNull_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:FindNull_ForBlueprintOnly");
			return default(FRigNullElement);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindNull_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindNull_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FindNull_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, FindNull_InKey_Offset), 0, FindNull_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindNull_FunctionAddress, intPtr, FindNull_ParamsSize);
		FRigNullElement result = FRigNullElement.FromNative(IntPtr.Add(intPtr, FindNull_ReturnValue_Offset), 0, FindNull_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FindNull_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1413743617u, OriginalName = "FindControl_ForBlueprintOnly")]
	[UMetaPath("/Script/ControlRig.RigHierarchy:FindControl_ForBlueprintOnly")]
	public unsafe FRigControlElement FindControl(FRigElementKey InKey)
	{
		CheckDestroyed();
		if (!FindControl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:FindControl_ForBlueprintOnly");
			return default(FRigControlElement);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindControl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindControl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FindControl_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, FindControl_InKey_Offset), 0, FindControl_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindControl_FunctionAddress, intPtr, FindControl_ParamsSize);
		FRigControlElement result = FRigControlElement.FromNative(IntPtr.Add(intPtr, FindControl_ReturnValue_Offset), 0, FindControl_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FindControl_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1413743617u, OriginalName = "FindBone_ForBlueprintOnly")]
	[UMetaPath("/Script/ControlRig.RigHierarchy:FindBone_ForBlueprintOnly")]
	public unsafe FRigBoneElement FindBone(FRigElementKey InKey)
	{
		CheckDestroyed();
		if (!FindBone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:FindBone_ForBlueprintOnly");
			return default(FRigBoneElement);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindBone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindBone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FindBone_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, FindBone_InKey_Offset), 0, FindBone_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindBone_FunctionAddress, intPtr, FindBone_ParamsSize);
		FRigBoneElement result = FRigBoneElement.FromNative(IntPtr.Add(intPtr, FindBone_ReturnValue_Offset), 0, FindBone_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FindBone_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:CopyPose")]
	public unsafe void CopyPose(URigHierarchy InHierarchy, bool bCurrent, bool bInitial)
	{
		CheckDestroyed();
		if (!CopyPose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:CopyPose");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyPose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyPose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigHierarchy>.ToNative(IntPtr.Add(intPtr, CopyPose_InHierarchy_Offset), 0, CopyPose_InHierarchy_PropertyAddress.Address, InHierarchy);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CopyPose_bCurrent_Offset), 0, CopyPose_bCurrent_PropertyAddress.Address, bCurrent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CopyPose_bInitial_Offset), 0, CopyPose_bInitial_PropertyAddress.Address, bInitial);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyPose_FunctionAddress, intPtr, CopyPose_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.RigHierarchy:CopyHierarchy")]
	public unsafe void CopyHierarchy(URigHierarchy InHierarchy)
	{
		CheckDestroyed();
		if (!CopyHierarchy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:CopyHierarchy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyHierarchy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyHierarchy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigHierarchy>.ToNative(IntPtr.Add(intPtr, CopyHierarchy_InHierarchy_Offset), 0, CopyHierarchy_InHierarchy_PropertyAddress.Address, InHierarchy);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyHierarchy_FunctionAddress, intPtr, CopyHierarchy_ParamsSize);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "Contains_ForBlueprint")]
	[UMetaPath("/Script/ControlRig.RigHierarchy:Contains_ForBlueprint")]
	public unsafe bool Contains(FRigElementKey InKey)
	{
		CheckDestroyed();
		if (!Contains_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.RigHierarchy:Contains_ForBlueprint");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Contains_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Contains_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Contains_InKey_PropertyAddress.Address, intPtr);
		FRigElementKey.ToNative(IntPtr.Add(intPtr, Contains_InKey_Offset), 0, Contains_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, Contains_FunctionAddress, intPtr, Contains_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Contains_ReturnValue_Offset), 0, Contains_ReturnValue_PropertyAddress.Address);
	}

	static URigHierarchy()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigHierarchy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigHierarchy));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/ControlRig.RigHierarchy");
		SwitchToWorldSpace_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SwitchToWorldSpace");
		SwitchToWorldSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchToWorldSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchToWorldSpace_InChild_PropertyAddress, SwitchToWorldSpace_FunctionAddress, "InChild");
		SwitchToWorldSpace_InChild_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToWorldSpace_FunctionAddress, "InChild");
		SwitchToWorldSpace_InChild_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToWorldSpace_FunctionAddress, "InChild", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchToWorldSpace_bInitial_PropertyAddress, SwitchToWorldSpace_FunctionAddress, "bInitial");
		SwitchToWorldSpace_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToWorldSpace_FunctionAddress, "bInitial");
		SwitchToWorldSpace_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToWorldSpace_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchToWorldSpace_bAffectChildren_PropertyAddress, SwitchToWorldSpace_FunctionAddress, "bAffectChildren");
		SwitchToWorldSpace_bAffectChildren_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToWorldSpace_FunctionAddress, "bAffectChildren");
		SwitchToWorldSpace_bAffectChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToWorldSpace_FunctionAddress, "bAffectChildren", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchToWorldSpace_ReturnValue_PropertyAddress, SwitchToWorldSpace_FunctionAddress, "ReturnValue");
		SwitchToWorldSpace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToWorldSpace_FunctionAddress, "ReturnValue");
		SwitchToWorldSpace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToWorldSpace_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SwitchToWorldSpace_IsValid = SwitchToWorldSpace_FunctionAddress != IntPtr.Zero && SwitchToWorldSpace_InChild_IsValid && SwitchToWorldSpace_bInitial_IsValid && SwitchToWorldSpace_bAffectChildren_IsValid && SwitchToWorldSpace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SwitchToWorldSpace", SwitchToWorldSpace_IsValid);
		SwitchToParent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SwitchToParent");
		SwitchToParent_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchToParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchToParent_InChild_PropertyAddress, SwitchToParent_FunctionAddress, "InChild");
		SwitchToParent_InChild_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToParent_FunctionAddress, "InChild");
		SwitchToParent_InChild_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToParent_FunctionAddress, "InChild", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchToParent_InParent_PropertyAddress, SwitchToParent_FunctionAddress, "InParent");
		SwitchToParent_InParent_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToParent_FunctionAddress, "InParent");
		SwitchToParent_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToParent_FunctionAddress, "InParent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchToParent_bInitial_PropertyAddress, SwitchToParent_FunctionAddress, "bInitial");
		SwitchToParent_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToParent_FunctionAddress, "bInitial");
		SwitchToParent_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToParent_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchToParent_bAffectChildren_PropertyAddress, SwitchToParent_FunctionAddress, "bAffectChildren");
		SwitchToParent_bAffectChildren_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToParent_FunctionAddress, "bAffectChildren");
		SwitchToParent_bAffectChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToParent_FunctionAddress, "bAffectChildren", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchToParent_ReturnValue_PropertyAddress, SwitchToParent_FunctionAddress, "ReturnValue");
		SwitchToParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToParent_FunctionAddress, "ReturnValue");
		SwitchToParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToParent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SwitchToParent_IsValid = SwitchToParent_FunctionAddress != IntPtr.Zero && SwitchToParent_InChild_IsValid && SwitchToParent_InParent_IsValid && SwitchToParent_bInitial_IsValid && SwitchToParent_bAffectChildren_IsValid && SwitchToParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SwitchToParent", SwitchToParent_IsValid);
		SwitchToDefaultParent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SwitchToDefaultParent");
		SwitchToDefaultParent_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchToDefaultParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchToDefaultParent_InChild_PropertyAddress, SwitchToDefaultParent_FunctionAddress, "InChild");
		SwitchToDefaultParent_InChild_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToDefaultParent_FunctionAddress, "InChild");
		SwitchToDefaultParent_InChild_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToDefaultParent_FunctionAddress, "InChild", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchToDefaultParent_bInitial_PropertyAddress, SwitchToDefaultParent_FunctionAddress, "bInitial");
		SwitchToDefaultParent_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToDefaultParent_FunctionAddress, "bInitial");
		SwitchToDefaultParent_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToDefaultParent_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchToDefaultParent_bAffectChildren_PropertyAddress, SwitchToDefaultParent_FunctionAddress, "bAffectChildren");
		SwitchToDefaultParent_bAffectChildren_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToDefaultParent_FunctionAddress, "bAffectChildren");
		SwitchToDefaultParent_bAffectChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToDefaultParent_FunctionAddress, "bAffectChildren", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SwitchToDefaultParent_ReturnValue_PropertyAddress, SwitchToDefaultParent_FunctionAddress, "ReturnValue");
		SwitchToDefaultParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SwitchToDefaultParent_FunctionAddress, "ReturnValue");
		SwitchToDefaultParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchToDefaultParent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SwitchToDefaultParent_IsValid = SwitchToDefaultParent_FunctionAddress != IntPtr.Zero && SwitchToDefaultParent_InChild_IsValid && SwitchToDefaultParent_bInitial_IsValid && SwitchToDefaultParent_bAffectChildren_IsValid && SwitchToDefaultParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SwitchToDefaultParent", SwitchToDefaultParent_IsValid);
		SortKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SortKeys");
		SortKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(SortKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SortKeys_InKeys_PropertyAddress, SortKeys_FunctionAddress, "InKeys");
		SortKeys_InKeys_Offset = NativeReflectionCached.GetPropertyOffset(SortKeys_FunctionAddress, "InKeys");
		SortKeys_InKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(SortKeys_FunctionAddress, "InKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SortKeys_ReturnValue_PropertyAddress, SortKeys_FunctionAddress, "ReturnValue");
		SortKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SortKeys_FunctionAddress, "ReturnValue");
		SortKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SortKeys_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		SortKeys_IsValid = SortKeys_FunctionAddress != IntPtr.Zero && SortKeys_InKeys_IsValid && SortKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SortKeys", SortKeys_IsValid);
		SetPose_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPose_ForBlueprint");
		SetPose_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPose_InPose_PropertyAddress, SetPose_FunctionAddress, "InPose");
		SetPose_InPose_Offset = NativeReflectionCached.GetPropertyOffset(SetPose_FunctionAddress, "InPose");
		SetPose_InPose_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPose_FunctionAddress, "InPose", Classes.FStructProperty);
		SetPose_IsValid = SetPose_FunctionAddress != IntPtr.Zero && SetPose_InPose_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetPose_ForBlueprint", SetPose_IsValid);
		SetParentWeightArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetParentWeightArray");
		SetParentWeightArray_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParentWeightArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParentWeightArray_InChild_PropertyAddress, SetParentWeightArray_FunctionAddress, "InChild");
		SetParentWeightArray_InChild_Offset = NativeReflectionCached.GetPropertyOffset(SetParentWeightArray_FunctionAddress, "InChild");
		SetParentWeightArray_InChild_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentWeightArray_FunctionAddress, "InChild", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParentWeightArray_InWeights_PropertyAddress, SetParentWeightArray_FunctionAddress, "InWeights");
		SetParentWeightArray_InWeights_Offset = NativeReflectionCached.GetPropertyOffset(SetParentWeightArray_FunctionAddress, "InWeights");
		SetParentWeightArray_InWeights_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentWeightArray_FunctionAddress, "InWeights", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParentWeightArray_bInitial_PropertyAddress, SetParentWeightArray_FunctionAddress, "bInitial");
		SetParentWeightArray_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(SetParentWeightArray_FunctionAddress, "bInitial");
		SetParentWeightArray_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentWeightArray_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParentWeightArray_bAffectChildren_PropertyAddress, SetParentWeightArray_FunctionAddress, "bAffectChildren");
		SetParentWeightArray_bAffectChildren_Offset = NativeReflectionCached.GetPropertyOffset(SetParentWeightArray_FunctionAddress, "bAffectChildren");
		SetParentWeightArray_bAffectChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentWeightArray_FunctionAddress, "bAffectChildren", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParentWeightArray_ReturnValue_PropertyAddress, SetParentWeightArray_FunctionAddress, "ReturnValue");
		SetParentWeightArray_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetParentWeightArray_FunctionAddress, "ReturnValue");
		SetParentWeightArray_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentWeightArray_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetParentWeightArray_IsValid = SetParentWeightArray_FunctionAddress != IntPtr.Zero && SetParentWeightArray_InChild_IsValid && SetParentWeightArray_InWeights_IsValid && SetParentWeightArray_bInitial_IsValid && SetParentWeightArray_bAffectChildren_IsValid && SetParentWeightArray_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetParentWeightArray", SetParentWeightArray_IsValid);
		SetParentWeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetParentWeight");
		SetParentWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParentWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParentWeight_InChild_PropertyAddress, SetParentWeight_FunctionAddress, "InChild");
		SetParentWeight_InChild_Offset = NativeReflectionCached.GetPropertyOffset(SetParentWeight_FunctionAddress, "InChild");
		SetParentWeight_InChild_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentWeight_FunctionAddress, "InChild", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParentWeight_InParent_PropertyAddress, SetParentWeight_FunctionAddress, "InParent");
		SetParentWeight_InParent_Offset = NativeReflectionCached.GetPropertyOffset(SetParentWeight_FunctionAddress, "InParent");
		SetParentWeight_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentWeight_FunctionAddress, "InParent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParentWeight_InWeight_PropertyAddress, SetParentWeight_FunctionAddress, "InWeight");
		SetParentWeight_InWeight_Offset = NativeReflectionCached.GetPropertyOffset(SetParentWeight_FunctionAddress, "InWeight");
		SetParentWeight_InWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentWeight_FunctionAddress, "InWeight", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParentWeight_bInitial_PropertyAddress, SetParentWeight_FunctionAddress, "bInitial");
		SetParentWeight_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(SetParentWeight_FunctionAddress, "bInitial");
		SetParentWeight_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentWeight_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParentWeight_bAffectChildren_PropertyAddress, SetParentWeight_FunctionAddress, "bAffectChildren");
		SetParentWeight_bAffectChildren_Offset = NativeReflectionCached.GetPropertyOffset(SetParentWeight_FunctionAddress, "bAffectChildren");
		SetParentWeight_bAffectChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentWeight_FunctionAddress, "bAffectChildren", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParentWeight_ReturnValue_PropertyAddress, SetParentWeight_FunctionAddress, "ReturnValue");
		SetParentWeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetParentWeight_FunctionAddress, "ReturnValue");
		SetParentWeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentWeight_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetParentWeight_IsValid = SetParentWeight_FunctionAddress != IntPtr.Zero && SetParentWeight_InChild_IsValid && SetParentWeight_InParent_IsValid && SetParentWeight_InWeight_IsValid && SetParentWeight_bInitial_IsValid && SetParentWeight_bAffectChildren_IsValid && SetParentWeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetParentWeight", SetParentWeight_IsValid);
		SetLocalTransformByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLocalTransformByIndex");
		SetLocalTransformByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocalTransformByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocalTransformByIndex_InElementIndex_PropertyAddress, SetLocalTransformByIndex_FunctionAddress, "InElementIndex");
		SetLocalTransformByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalTransformByIndex_FunctionAddress, "InElementIndex");
		SetLocalTransformByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalTransformByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalTransformByIndex_InTransform_PropertyAddress, SetLocalTransformByIndex_FunctionAddress, "InTransform");
		SetLocalTransformByIndex_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalTransformByIndex_FunctionAddress, "InTransform");
		SetLocalTransformByIndex_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalTransformByIndex_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalTransformByIndex_bInitial_PropertyAddress, SetLocalTransformByIndex_FunctionAddress, "bInitial");
		SetLocalTransformByIndex_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalTransformByIndex_FunctionAddress, "bInitial");
		SetLocalTransformByIndex_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalTransformByIndex_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalTransformByIndex_bAffectChildren_PropertyAddress, SetLocalTransformByIndex_FunctionAddress, "bAffectChildren");
		SetLocalTransformByIndex_bAffectChildren_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalTransformByIndex_FunctionAddress, "bAffectChildren");
		SetLocalTransformByIndex_bAffectChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalTransformByIndex_FunctionAddress, "bAffectChildren", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalTransformByIndex_bSetupUndo_PropertyAddress, SetLocalTransformByIndex_FunctionAddress, "bSetupUndo");
		SetLocalTransformByIndex_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalTransformByIndex_FunctionAddress, "bSetupUndo");
		SetLocalTransformByIndex_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalTransformByIndex_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalTransformByIndex_bPrintPythonCommands_PropertyAddress, SetLocalTransformByIndex_FunctionAddress, "bPrintPythonCommands");
		SetLocalTransformByIndex_bPrintPythonCommands_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalTransformByIndex_FunctionAddress, "bPrintPythonCommands");
		SetLocalTransformByIndex_bPrintPythonCommands_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalTransformByIndex_FunctionAddress, "bPrintPythonCommands", Classes.FBoolProperty);
		SetLocalTransformByIndex_IsValid = SetLocalTransformByIndex_FunctionAddress != IntPtr.Zero && SetLocalTransformByIndex_InElementIndex_IsValid && SetLocalTransformByIndex_InTransform_IsValid && SetLocalTransformByIndex_bInitial_IsValid && SetLocalTransformByIndex_bAffectChildren_IsValid && SetLocalTransformByIndex_bSetupUndo_IsValid && SetLocalTransformByIndex_bPrintPythonCommands_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetLocalTransformByIndex", SetLocalTransformByIndex_IsValid);
		SetLocalTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLocalTransform");
		SetLocalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocalTransform_InKey_PropertyAddress, SetLocalTransform_FunctionAddress, "InKey");
		SetLocalTransform_InKey_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalTransform_FunctionAddress, "InKey");
		SetLocalTransform_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalTransform_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalTransform_InTransform_PropertyAddress, SetLocalTransform_FunctionAddress, "InTransform");
		SetLocalTransform_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalTransform_FunctionAddress, "InTransform");
		SetLocalTransform_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalTransform_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalTransform_bInitial_PropertyAddress, SetLocalTransform_FunctionAddress, "bInitial");
		SetLocalTransform_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalTransform_FunctionAddress, "bInitial");
		SetLocalTransform_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalTransform_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalTransform_bAffectChildren_PropertyAddress, SetLocalTransform_FunctionAddress, "bAffectChildren");
		SetLocalTransform_bAffectChildren_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalTransform_FunctionAddress, "bAffectChildren");
		SetLocalTransform_bAffectChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalTransform_FunctionAddress, "bAffectChildren", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalTransform_bSetupUndo_PropertyAddress, SetLocalTransform_FunctionAddress, "bSetupUndo");
		SetLocalTransform_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalTransform_FunctionAddress, "bSetupUndo");
		SetLocalTransform_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalTransform_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalTransform_bPrintPythonCommands_PropertyAddress, SetLocalTransform_FunctionAddress, "bPrintPythonCommands");
		SetLocalTransform_bPrintPythonCommands_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalTransform_FunctionAddress, "bPrintPythonCommands");
		SetLocalTransform_bPrintPythonCommands_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalTransform_FunctionAddress, "bPrintPythonCommands", Classes.FBoolProperty);
		SetLocalTransform_IsValid = SetLocalTransform_FunctionAddress != IntPtr.Zero && SetLocalTransform_InKey_IsValid && SetLocalTransform_InTransform_IsValid && SetLocalTransform_bInitial_IsValid && SetLocalTransform_bAffectChildren_IsValid && SetLocalTransform_bSetupUndo_IsValid && SetLocalTransform_bPrintPythonCommands_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetLocalTransform", SetLocalTransform_IsValid);
		SetGlobalTransformByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetGlobalTransformByIndex");
		SetGlobalTransformByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGlobalTransformByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalTransformByIndex_InElementIndex_PropertyAddress, SetGlobalTransformByIndex_FunctionAddress, "InElementIndex");
		SetGlobalTransformByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalTransformByIndex_FunctionAddress, "InElementIndex");
		SetGlobalTransformByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalTransformByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalTransformByIndex_InTransform_PropertyAddress, SetGlobalTransformByIndex_FunctionAddress, "InTransform");
		SetGlobalTransformByIndex_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalTransformByIndex_FunctionAddress, "InTransform");
		SetGlobalTransformByIndex_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalTransformByIndex_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalTransformByIndex_bInitial_PropertyAddress, SetGlobalTransformByIndex_FunctionAddress, "bInitial");
		SetGlobalTransformByIndex_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalTransformByIndex_FunctionAddress, "bInitial");
		SetGlobalTransformByIndex_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalTransformByIndex_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalTransformByIndex_bAffectChildren_PropertyAddress, SetGlobalTransformByIndex_FunctionAddress, "bAffectChildren");
		SetGlobalTransformByIndex_bAffectChildren_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalTransformByIndex_FunctionAddress, "bAffectChildren");
		SetGlobalTransformByIndex_bAffectChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalTransformByIndex_FunctionAddress, "bAffectChildren", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalTransformByIndex_bSetupUndo_PropertyAddress, SetGlobalTransformByIndex_FunctionAddress, "bSetupUndo");
		SetGlobalTransformByIndex_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalTransformByIndex_FunctionAddress, "bSetupUndo");
		SetGlobalTransformByIndex_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalTransformByIndex_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		SetGlobalTransformByIndex_IsValid = SetGlobalTransformByIndex_FunctionAddress != IntPtr.Zero && SetGlobalTransformByIndex_InElementIndex_IsValid && SetGlobalTransformByIndex_InTransform_IsValid && SetGlobalTransformByIndex_bInitial_IsValid && SetGlobalTransformByIndex_bAffectChildren_IsValid && SetGlobalTransformByIndex_bSetupUndo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetGlobalTransformByIndex", SetGlobalTransformByIndex_IsValid);
		SetGlobalTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetGlobalTransform");
		SetGlobalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGlobalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalTransform_InKey_PropertyAddress, SetGlobalTransform_FunctionAddress, "InKey");
		SetGlobalTransform_InKey_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalTransform_FunctionAddress, "InKey");
		SetGlobalTransform_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalTransform_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalTransform_InTransform_PropertyAddress, SetGlobalTransform_FunctionAddress, "InTransform");
		SetGlobalTransform_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalTransform_FunctionAddress, "InTransform");
		SetGlobalTransform_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalTransform_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalTransform_bInitial_PropertyAddress, SetGlobalTransform_FunctionAddress, "bInitial");
		SetGlobalTransform_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalTransform_FunctionAddress, "bInitial");
		SetGlobalTransform_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalTransform_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalTransform_bAffectChildren_PropertyAddress, SetGlobalTransform_FunctionAddress, "bAffectChildren");
		SetGlobalTransform_bAffectChildren_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalTransform_FunctionAddress, "bAffectChildren");
		SetGlobalTransform_bAffectChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalTransform_FunctionAddress, "bAffectChildren", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGlobalTransform_bSetupUndo_PropertyAddress, SetGlobalTransform_FunctionAddress, "bSetupUndo");
		SetGlobalTransform_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetGlobalTransform_FunctionAddress, "bSetupUndo");
		SetGlobalTransform_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGlobalTransform_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		SetGlobalTransform_IsValid = SetGlobalTransform_FunctionAddress != IntPtr.Zero && SetGlobalTransform_InKey_IsValid && SetGlobalTransform_InTransform_IsValid && SetGlobalTransform_bInitial_IsValid && SetGlobalTransform_bAffectChildren_IsValid && SetGlobalTransform_bSetupUndo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetGlobalTransform", SetGlobalTransform_IsValid);
		SetCurveValueByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurveValueByIndex");
		SetCurveValueByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurveValueByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurveValueByIndex_InElementIndex_PropertyAddress, SetCurveValueByIndex_FunctionAddress, "InElementIndex");
		SetCurveValueByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveValueByIndex_FunctionAddress, "InElementIndex");
		SetCurveValueByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveValueByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveValueByIndex_InValue_PropertyAddress, SetCurveValueByIndex_FunctionAddress, "InValue");
		SetCurveValueByIndex_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveValueByIndex_FunctionAddress, "InValue");
		SetCurveValueByIndex_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveValueByIndex_FunctionAddress, "InValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveValueByIndex_bSetupUndo_PropertyAddress, SetCurveValueByIndex_FunctionAddress, "bSetupUndo");
		SetCurveValueByIndex_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveValueByIndex_FunctionAddress, "bSetupUndo");
		SetCurveValueByIndex_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveValueByIndex_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		SetCurveValueByIndex_IsValid = SetCurveValueByIndex_FunctionAddress != IntPtr.Zero && SetCurveValueByIndex_InElementIndex_IsValid && SetCurveValueByIndex_InValue_IsValid && SetCurveValueByIndex_bSetupUndo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetCurveValueByIndex", SetCurveValueByIndex_IsValid);
		SetCurveValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurveValue");
		SetCurveValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurveValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurveValue_InKey_PropertyAddress, SetCurveValue_FunctionAddress, "InKey");
		SetCurveValue_InKey_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveValue_FunctionAddress, "InKey");
		SetCurveValue_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveValue_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveValue_InValue_PropertyAddress, SetCurveValue_FunctionAddress, "InValue");
		SetCurveValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveValue_FunctionAddress, "InValue");
		SetCurveValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveValue_FunctionAddress, "InValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveValue_bSetupUndo_PropertyAddress, SetCurveValue_FunctionAddress, "bSetupUndo");
		SetCurveValue_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveValue_FunctionAddress, "bSetupUndo");
		SetCurveValue_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveValue_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		SetCurveValue_IsValid = SetCurveValue_FunctionAddress != IntPtr.Zero && SetCurveValue_InKey_IsValid && SetCurveValue_InValue_IsValid && SetCurveValue_bSetupUndo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetCurveValue", SetCurveValue_IsValid);
		SetControlVisibilityByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetControlVisibilityByIndex");
		SetControlVisibilityByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlVisibilityByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlVisibilityByIndex_InElementIndex_PropertyAddress, SetControlVisibilityByIndex_FunctionAddress, "InElementIndex");
		SetControlVisibilityByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetControlVisibilityByIndex_FunctionAddress, "InElementIndex");
		SetControlVisibilityByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlVisibilityByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlVisibilityByIndex_bVisibility_PropertyAddress, SetControlVisibilityByIndex_FunctionAddress, "bVisibility");
		SetControlVisibilityByIndex_bVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetControlVisibilityByIndex_FunctionAddress, "bVisibility");
		SetControlVisibilityByIndex_bVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlVisibilityByIndex_FunctionAddress, "bVisibility", Classes.FBoolProperty);
		SetControlVisibilityByIndex_IsValid = SetControlVisibilityByIndex_FunctionAddress != IntPtr.Zero && SetControlVisibilityByIndex_InElementIndex_IsValid && SetControlVisibilityByIndex_bVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetControlVisibilityByIndex", SetControlVisibilityByIndex_IsValid);
		SetControlVisibility_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetControlVisibility");
		SetControlVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlVisibility_InKey_PropertyAddress, SetControlVisibility_FunctionAddress, "InKey");
		SetControlVisibility_InKey_Offset = NativeReflectionCached.GetPropertyOffset(SetControlVisibility_FunctionAddress, "InKey");
		SetControlVisibility_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlVisibility_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlVisibility_bVisibility_PropertyAddress, SetControlVisibility_FunctionAddress, "bVisibility");
		SetControlVisibility_bVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetControlVisibility_FunctionAddress, "bVisibility");
		SetControlVisibility_bVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlVisibility_FunctionAddress, "bVisibility", Classes.FBoolProperty);
		SetControlVisibility_IsValid = SetControlVisibility_FunctionAddress != IntPtr.Zero && SetControlVisibility_InKey_IsValid && SetControlVisibility_bVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetControlVisibility", SetControlVisibility_IsValid);
		SetControlValueByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetControlValueByIndex");
		SetControlValueByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlValueByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlValueByIndex_InElementIndex_PropertyAddress, SetControlValueByIndex_FunctionAddress, "InElementIndex");
		SetControlValueByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetControlValueByIndex_FunctionAddress, "InElementIndex");
		SetControlValueByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlValueByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlValueByIndex_InValue_PropertyAddress, SetControlValueByIndex_FunctionAddress, "InValue");
		SetControlValueByIndex_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetControlValueByIndex_FunctionAddress, "InValue");
		SetControlValueByIndex_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlValueByIndex_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlValueByIndex_InValueType_PropertyAddress, SetControlValueByIndex_FunctionAddress, "InValueType");
		SetControlValueByIndex_InValueType_Offset = NativeReflectionCached.GetPropertyOffset(SetControlValueByIndex_FunctionAddress, "InValueType");
		SetControlValueByIndex_InValueType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlValueByIndex_FunctionAddress, "InValueType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlValueByIndex_bSetupUndo_PropertyAddress, SetControlValueByIndex_FunctionAddress, "bSetupUndo");
		SetControlValueByIndex_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetControlValueByIndex_FunctionAddress, "bSetupUndo");
		SetControlValueByIndex_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlValueByIndex_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlValueByIndex_bPrintPythonCommands_PropertyAddress, SetControlValueByIndex_FunctionAddress, "bPrintPythonCommands");
		SetControlValueByIndex_bPrintPythonCommands_Offset = NativeReflectionCached.GetPropertyOffset(SetControlValueByIndex_FunctionAddress, "bPrintPythonCommands");
		SetControlValueByIndex_bPrintPythonCommands_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlValueByIndex_FunctionAddress, "bPrintPythonCommands", Classes.FBoolProperty);
		SetControlValueByIndex_IsValid = SetControlValueByIndex_FunctionAddress != IntPtr.Zero && SetControlValueByIndex_InElementIndex_IsValid && SetControlValueByIndex_InValue_IsValid && SetControlValueByIndex_InValueType_IsValid && SetControlValueByIndex_bSetupUndo_IsValid && SetControlValueByIndex_bPrintPythonCommands_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetControlValueByIndex", SetControlValueByIndex_IsValid);
		SetControlValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetControlValue");
		SetControlValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlValue_InKey_PropertyAddress, SetControlValue_FunctionAddress, "InKey");
		SetControlValue_InKey_Offset = NativeReflectionCached.GetPropertyOffset(SetControlValue_FunctionAddress, "InKey");
		SetControlValue_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlValue_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlValue_InValue_PropertyAddress, SetControlValue_FunctionAddress, "InValue");
		SetControlValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetControlValue_FunctionAddress, "InValue");
		SetControlValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlValue_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlValue_InValueType_PropertyAddress, SetControlValue_FunctionAddress, "InValueType");
		SetControlValue_InValueType_Offset = NativeReflectionCached.GetPropertyOffset(SetControlValue_FunctionAddress, "InValueType");
		SetControlValue_InValueType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlValue_FunctionAddress, "InValueType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlValue_bSetupUndo_PropertyAddress, SetControlValue_FunctionAddress, "bSetupUndo");
		SetControlValue_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetControlValue_FunctionAddress, "bSetupUndo");
		SetControlValue_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlValue_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlValue_bPrintPythonCommands_PropertyAddress, SetControlValue_FunctionAddress, "bPrintPythonCommands");
		SetControlValue_bPrintPythonCommands_Offset = NativeReflectionCached.GetPropertyOffset(SetControlValue_FunctionAddress, "bPrintPythonCommands");
		SetControlValue_bPrintPythonCommands_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlValue_FunctionAddress, "bPrintPythonCommands", Classes.FBoolProperty);
		SetControlValue_IsValid = SetControlValue_FunctionAddress != IntPtr.Zero && SetControlValue_InKey_IsValid && SetControlValue_InValue_IsValid && SetControlValue_InValueType_IsValid && SetControlValue_bSetupUndo_IsValid && SetControlValue_bPrintPythonCommands_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetControlValue", SetControlValue_IsValid);
		SetControlShapeTransformByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetControlShapeTransformByIndex");
		SetControlShapeTransformByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlShapeTransformByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlShapeTransformByIndex_InElementIndex_PropertyAddress, SetControlShapeTransformByIndex_FunctionAddress, "InElementIndex");
		SetControlShapeTransformByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetControlShapeTransformByIndex_FunctionAddress, "InElementIndex");
		SetControlShapeTransformByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlShapeTransformByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlShapeTransformByIndex_InTransform_PropertyAddress, SetControlShapeTransformByIndex_FunctionAddress, "InTransform");
		SetControlShapeTransformByIndex_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetControlShapeTransformByIndex_FunctionAddress, "InTransform");
		SetControlShapeTransformByIndex_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlShapeTransformByIndex_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlShapeTransformByIndex_bInitial_PropertyAddress, SetControlShapeTransformByIndex_FunctionAddress, "bInitial");
		SetControlShapeTransformByIndex_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(SetControlShapeTransformByIndex_FunctionAddress, "bInitial");
		SetControlShapeTransformByIndex_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlShapeTransformByIndex_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlShapeTransformByIndex_bSetupUndo_PropertyAddress, SetControlShapeTransformByIndex_FunctionAddress, "bSetupUndo");
		SetControlShapeTransformByIndex_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetControlShapeTransformByIndex_FunctionAddress, "bSetupUndo");
		SetControlShapeTransformByIndex_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlShapeTransformByIndex_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		SetControlShapeTransformByIndex_IsValid = SetControlShapeTransformByIndex_FunctionAddress != IntPtr.Zero && SetControlShapeTransformByIndex_InElementIndex_IsValid && SetControlShapeTransformByIndex_InTransform_IsValid && SetControlShapeTransformByIndex_bInitial_IsValid && SetControlShapeTransformByIndex_bSetupUndo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetControlShapeTransformByIndex", SetControlShapeTransformByIndex_IsValid);
		SetControlShapeTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetControlShapeTransform");
		SetControlShapeTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlShapeTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlShapeTransform_InKey_PropertyAddress, SetControlShapeTransform_FunctionAddress, "InKey");
		SetControlShapeTransform_InKey_Offset = NativeReflectionCached.GetPropertyOffset(SetControlShapeTransform_FunctionAddress, "InKey");
		SetControlShapeTransform_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlShapeTransform_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlShapeTransform_InTransform_PropertyAddress, SetControlShapeTransform_FunctionAddress, "InTransform");
		SetControlShapeTransform_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetControlShapeTransform_FunctionAddress, "InTransform");
		SetControlShapeTransform_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlShapeTransform_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlShapeTransform_bInitial_PropertyAddress, SetControlShapeTransform_FunctionAddress, "bInitial");
		SetControlShapeTransform_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(SetControlShapeTransform_FunctionAddress, "bInitial");
		SetControlShapeTransform_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlShapeTransform_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlShapeTransform_bSetupUndo_PropertyAddress, SetControlShapeTransform_FunctionAddress, "bSetupUndo");
		SetControlShapeTransform_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetControlShapeTransform_FunctionAddress, "bSetupUndo");
		SetControlShapeTransform_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlShapeTransform_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		SetControlShapeTransform_IsValid = SetControlShapeTransform_FunctionAddress != IntPtr.Zero && SetControlShapeTransform_InKey_IsValid && SetControlShapeTransform_InTransform_IsValid && SetControlShapeTransform_bInitial_IsValid && SetControlShapeTransform_bSetupUndo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetControlShapeTransform", SetControlShapeTransform_IsValid);
		SetControlSettingsByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetControlSettingsByIndex");
		SetControlSettingsByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlSettingsByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlSettingsByIndex_InElementIndex_PropertyAddress, SetControlSettingsByIndex_FunctionAddress, "InElementIndex");
		SetControlSettingsByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetControlSettingsByIndex_FunctionAddress, "InElementIndex");
		SetControlSettingsByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlSettingsByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlSettingsByIndex_InSettings_PropertyAddress, SetControlSettingsByIndex_FunctionAddress, "InSettings");
		SetControlSettingsByIndex_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetControlSettingsByIndex_FunctionAddress, "InSettings");
		SetControlSettingsByIndex_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlSettingsByIndex_FunctionAddress, "InSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlSettingsByIndex_bSetupUndo_PropertyAddress, SetControlSettingsByIndex_FunctionAddress, "bSetupUndo");
		SetControlSettingsByIndex_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetControlSettingsByIndex_FunctionAddress, "bSetupUndo");
		SetControlSettingsByIndex_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlSettingsByIndex_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlSettingsByIndex_bForce_PropertyAddress, SetControlSettingsByIndex_FunctionAddress, "bForce");
		SetControlSettingsByIndex_bForce_Offset = NativeReflectionCached.GetPropertyOffset(SetControlSettingsByIndex_FunctionAddress, "bForce");
		SetControlSettingsByIndex_bForce_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlSettingsByIndex_FunctionAddress, "bForce", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlSettingsByIndex_bPrintPythonCommands_PropertyAddress, SetControlSettingsByIndex_FunctionAddress, "bPrintPythonCommands");
		SetControlSettingsByIndex_bPrintPythonCommands_Offset = NativeReflectionCached.GetPropertyOffset(SetControlSettingsByIndex_FunctionAddress, "bPrintPythonCommands");
		SetControlSettingsByIndex_bPrintPythonCommands_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlSettingsByIndex_FunctionAddress, "bPrintPythonCommands", Classes.FBoolProperty);
		SetControlSettingsByIndex_IsValid = SetControlSettingsByIndex_FunctionAddress != IntPtr.Zero && SetControlSettingsByIndex_InElementIndex_IsValid && SetControlSettingsByIndex_InSettings_IsValid && SetControlSettingsByIndex_bSetupUndo_IsValid && SetControlSettingsByIndex_bForce_IsValid && SetControlSettingsByIndex_bPrintPythonCommands_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetControlSettingsByIndex", SetControlSettingsByIndex_IsValid);
		SetControlSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetControlSettings");
		SetControlSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlSettings_InKey_PropertyAddress, SetControlSettings_FunctionAddress, "InKey");
		SetControlSettings_InKey_Offset = NativeReflectionCached.GetPropertyOffset(SetControlSettings_FunctionAddress, "InKey");
		SetControlSettings_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlSettings_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlSettings_InSettings_PropertyAddress, SetControlSettings_FunctionAddress, "InSettings");
		SetControlSettings_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetControlSettings_FunctionAddress, "InSettings");
		SetControlSettings_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlSettings_FunctionAddress, "InSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlSettings_bSetupUndo_PropertyAddress, SetControlSettings_FunctionAddress, "bSetupUndo");
		SetControlSettings_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetControlSettings_FunctionAddress, "bSetupUndo");
		SetControlSettings_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlSettings_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlSettings_bForce_PropertyAddress, SetControlSettings_FunctionAddress, "bForce");
		SetControlSettings_bForce_Offset = NativeReflectionCached.GetPropertyOffset(SetControlSettings_FunctionAddress, "bForce");
		SetControlSettings_bForce_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlSettings_FunctionAddress, "bForce", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlSettings_bPrintPythonCommands_PropertyAddress, SetControlSettings_FunctionAddress, "bPrintPythonCommands");
		SetControlSettings_bPrintPythonCommands_Offset = NativeReflectionCached.GetPropertyOffset(SetControlSettings_FunctionAddress, "bPrintPythonCommands");
		SetControlSettings_bPrintPythonCommands_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlSettings_FunctionAddress, "bPrintPythonCommands", Classes.FBoolProperty);
		SetControlSettings_IsValid = SetControlSettings_FunctionAddress != IntPtr.Zero && SetControlSettings_InKey_IsValid && SetControlSettings_InSettings_IsValid && SetControlSettings_bSetupUndo_IsValid && SetControlSettings_bForce_IsValid && SetControlSettings_bPrintPythonCommands_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetControlSettings", SetControlSettings_IsValid);
		SetControlOffsetTransformByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetControlOffsetTransformByIndex");
		SetControlOffsetTransformByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlOffsetTransformByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffsetTransformByIndex_InElementIndex_PropertyAddress, SetControlOffsetTransformByIndex_FunctionAddress, "InElementIndex");
		SetControlOffsetTransformByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffsetTransformByIndex_FunctionAddress, "InElementIndex");
		SetControlOffsetTransformByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffsetTransformByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffsetTransformByIndex_InTransform_PropertyAddress, SetControlOffsetTransformByIndex_FunctionAddress, "InTransform");
		SetControlOffsetTransformByIndex_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffsetTransformByIndex_FunctionAddress, "InTransform");
		SetControlOffsetTransformByIndex_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffsetTransformByIndex_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffsetTransformByIndex_bInitial_PropertyAddress, SetControlOffsetTransformByIndex_FunctionAddress, "bInitial");
		SetControlOffsetTransformByIndex_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffsetTransformByIndex_FunctionAddress, "bInitial");
		SetControlOffsetTransformByIndex_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffsetTransformByIndex_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffsetTransformByIndex_bAffectChildren_PropertyAddress, SetControlOffsetTransformByIndex_FunctionAddress, "bAffectChildren");
		SetControlOffsetTransformByIndex_bAffectChildren_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffsetTransformByIndex_FunctionAddress, "bAffectChildren");
		SetControlOffsetTransformByIndex_bAffectChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffsetTransformByIndex_FunctionAddress, "bAffectChildren", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffsetTransformByIndex_bSetupUndo_PropertyAddress, SetControlOffsetTransformByIndex_FunctionAddress, "bSetupUndo");
		SetControlOffsetTransformByIndex_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffsetTransformByIndex_FunctionAddress, "bSetupUndo");
		SetControlOffsetTransformByIndex_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffsetTransformByIndex_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffsetTransformByIndex_bPrintPythonCommands_PropertyAddress, SetControlOffsetTransformByIndex_FunctionAddress, "bPrintPythonCommands");
		SetControlOffsetTransformByIndex_bPrintPythonCommands_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffsetTransformByIndex_FunctionAddress, "bPrintPythonCommands");
		SetControlOffsetTransformByIndex_bPrintPythonCommands_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffsetTransformByIndex_FunctionAddress, "bPrintPythonCommands", Classes.FBoolProperty);
		SetControlOffsetTransformByIndex_IsValid = SetControlOffsetTransformByIndex_FunctionAddress != IntPtr.Zero && SetControlOffsetTransformByIndex_InElementIndex_IsValid && SetControlOffsetTransformByIndex_InTransform_IsValid && SetControlOffsetTransformByIndex_bInitial_IsValid && SetControlOffsetTransformByIndex_bAffectChildren_IsValid && SetControlOffsetTransformByIndex_bSetupUndo_IsValid && SetControlOffsetTransformByIndex_bPrintPythonCommands_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetControlOffsetTransformByIndex", SetControlOffsetTransformByIndex_IsValid);
		SetControlOffsetTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetControlOffsetTransform");
		SetControlOffsetTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlOffsetTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffsetTransform_InKey_PropertyAddress, SetControlOffsetTransform_FunctionAddress, "InKey");
		SetControlOffsetTransform_InKey_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffsetTransform_FunctionAddress, "InKey");
		SetControlOffsetTransform_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffsetTransform_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffsetTransform_InTransform_PropertyAddress, SetControlOffsetTransform_FunctionAddress, "InTransform");
		SetControlOffsetTransform_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffsetTransform_FunctionAddress, "InTransform");
		SetControlOffsetTransform_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffsetTransform_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffsetTransform_bInitial_PropertyAddress, SetControlOffsetTransform_FunctionAddress, "bInitial");
		SetControlOffsetTransform_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffsetTransform_FunctionAddress, "bInitial");
		SetControlOffsetTransform_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffsetTransform_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffsetTransform_bAffectChildren_PropertyAddress, SetControlOffsetTransform_FunctionAddress, "bAffectChildren");
		SetControlOffsetTransform_bAffectChildren_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffsetTransform_FunctionAddress, "bAffectChildren");
		SetControlOffsetTransform_bAffectChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffsetTransform_FunctionAddress, "bAffectChildren", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffsetTransform_bSetupUndo_PropertyAddress, SetControlOffsetTransform_FunctionAddress, "bSetupUndo");
		SetControlOffsetTransform_bSetupUndo_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffsetTransform_FunctionAddress, "bSetupUndo");
		SetControlOffsetTransform_bSetupUndo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffsetTransform_FunctionAddress, "bSetupUndo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlOffsetTransform_bPrintPythonCommands_PropertyAddress, SetControlOffsetTransform_FunctionAddress, "bPrintPythonCommands");
		SetControlOffsetTransform_bPrintPythonCommands_Offset = NativeReflectionCached.GetPropertyOffset(SetControlOffsetTransform_FunctionAddress, "bPrintPythonCommands");
		SetControlOffsetTransform_bPrintPythonCommands_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlOffsetTransform_FunctionAddress, "bPrintPythonCommands", Classes.FBoolProperty);
		SetControlOffsetTransform_IsValid = SetControlOffsetTransform_FunctionAddress != IntPtr.Zero && SetControlOffsetTransform_InKey_IsValid && SetControlOffsetTransform_InTransform_IsValid && SetControlOffsetTransform_bInitial_IsValid && SetControlOffsetTransform_bAffectChildren_IsValid && SetControlOffsetTransform_bSetupUndo_IsValid && SetControlOffsetTransform_bPrintPythonCommands_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SetControlOffsetTransform", SetControlOffsetTransform_IsValid);
		SendAutoKeyEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SendAutoKeyEvent");
		SendAutoKeyEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(SendAutoKeyEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SendAutoKeyEvent_InElement_PropertyAddress, SendAutoKeyEvent_FunctionAddress, "InElement");
		SendAutoKeyEvent_InElement_Offset = NativeReflectionCached.GetPropertyOffset(SendAutoKeyEvent_FunctionAddress, "InElement");
		SendAutoKeyEvent_InElement_IsValid = NativeReflectionCached.ValidatePropertyClass(SendAutoKeyEvent_FunctionAddress, "InElement", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SendAutoKeyEvent_InOffsetInSeconds_PropertyAddress, SendAutoKeyEvent_FunctionAddress, "InOffsetInSeconds");
		SendAutoKeyEvent_InOffsetInSeconds_Offset = NativeReflectionCached.GetPropertyOffset(SendAutoKeyEvent_FunctionAddress, "InOffsetInSeconds");
		SendAutoKeyEvent_InOffsetInSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(SendAutoKeyEvent_FunctionAddress, "InOffsetInSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SendAutoKeyEvent_bAsynchronous_PropertyAddress, SendAutoKeyEvent_FunctionAddress, "bAsynchronous");
		SendAutoKeyEvent_bAsynchronous_Offset = NativeReflectionCached.GetPropertyOffset(SendAutoKeyEvent_FunctionAddress, "bAsynchronous");
		SendAutoKeyEvent_bAsynchronous_IsValid = NativeReflectionCached.ValidatePropertyClass(SendAutoKeyEvent_FunctionAddress, "bAsynchronous", Classes.FBoolProperty);
		SendAutoKeyEvent_IsValid = SendAutoKeyEvent_FunctionAddress != IntPtr.Zero && SendAutoKeyEvent_InElement_IsValid && SendAutoKeyEvent_InOffsetInSeconds_IsValid && SendAutoKeyEvent_bAsynchronous_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:SendAutoKeyEvent", SendAutoKeyEvent_IsValid);
		ResetPoseToInitial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResetPoseToInitial");
		ResetPoseToInitial_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetPoseToInitial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetPoseToInitial_InTypeFilter_PropertyAddress, ResetPoseToInitial_FunctionAddress, "InTypeFilter");
		ResetPoseToInitial_InTypeFilter_Offset = NativeReflectionCached.GetPropertyOffset(ResetPoseToInitial_FunctionAddress, "InTypeFilter");
		ResetPoseToInitial_InTypeFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetPoseToInitial_FunctionAddress, "InTypeFilter", Classes.FEnumProperty);
		ResetPoseToInitial_IsValid = ResetPoseToInitial_FunctionAddress != IntPtr.Zero && ResetPoseToInitial_InTypeFilter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:ResetPoseToInitial", ResetPoseToInitial_IsValid);
		ResetCurveValues_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResetCurveValues");
		ResetCurveValues_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetCurveValues_FunctionAddress);
		ResetCurveValues_IsValid = ResetCurveValues_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:ResetCurveValues", ResetCurveValues_IsValid);
		Reset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Reset");
		Reset_ParamsSize = NativeReflection.GetFunctionParamsSize(Reset_FunctionAddress);
		Reset_IsValid = Reset_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:Reset", Reset_IsValid);
		Num_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Num");
		Num_ParamsSize = NativeReflection.GetFunctionParamsSize(Num_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Num_ReturnValue_PropertyAddress, Num_FunctionAddress, "ReturnValue");
		Num_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Num_FunctionAddress, "ReturnValue");
		Num_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Num_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Num_IsValid = Num_FunctionAddress != IntPtr.Zero && Num_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:Num", Num_IsValid);
		MakeControlValueFromVector2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeControlValueFromVector2D");
		MakeControlValueFromVector2D_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeControlValueFromVector2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromVector2D_InValue_PropertyAddress, MakeControlValueFromVector2D_FunctionAddress, "InValue");
		MakeControlValueFromVector2D_InValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromVector2D_FunctionAddress, "InValue");
		MakeControlValueFromVector2D_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromVector2D_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromVector2D_ReturnValue_PropertyAddress, MakeControlValueFromVector2D_FunctionAddress, "ReturnValue");
		MakeControlValueFromVector2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromVector2D_FunctionAddress, "ReturnValue");
		MakeControlValueFromVector2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromVector2D_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeControlValueFromVector2D_IsValid = MakeControlValueFromVector2D_FunctionAddress != IntPtr.Zero && MakeControlValueFromVector2D_InValue_IsValid && MakeControlValueFromVector2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:MakeControlValueFromVector2D", MakeControlValueFromVector2D_IsValid);
		MakeControlValueFromVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeControlValueFromVector");
		MakeControlValueFromVector_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeControlValueFromVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromVector_InValue_PropertyAddress, MakeControlValueFromVector_FunctionAddress, "InValue");
		MakeControlValueFromVector_InValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromVector_FunctionAddress, "InValue");
		MakeControlValueFromVector_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromVector_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromVector_ReturnValue_PropertyAddress, MakeControlValueFromVector_FunctionAddress, "ReturnValue");
		MakeControlValueFromVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromVector_FunctionAddress, "ReturnValue");
		MakeControlValueFromVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeControlValueFromVector_IsValid = MakeControlValueFromVector_FunctionAddress != IntPtr.Zero && MakeControlValueFromVector_InValue_IsValid && MakeControlValueFromVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:MakeControlValueFromVector", MakeControlValueFromVector_IsValid);
		MakeControlValueFromTransformNoScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeControlValueFromTransformNoScale");
		MakeControlValueFromTransformNoScale_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeControlValueFromTransformNoScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromTransformNoScale_InValue_PropertyAddress, MakeControlValueFromTransformNoScale_FunctionAddress, "InValue");
		MakeControlValueFromTransformNoScale_InValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromTransformNoScale_FunctionAddress, "InValue");
		MakeControlValueFromTransformNoScale_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromTransformNoScale_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromTransformNoScale_ReturnValue_PropertyAddress, MakeControlValueFromTransformNoScale_FunctionAddress, "ReturnValue");
		MakeControlValueFromTransformNoScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromTransformNoScale_FunctionAddress, "ReturnValue");
		MakeControlValueFromTransformNoScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromTransformNoScale_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeControlValueFromTransformNoScale_IsValid = MakeControlValueFromTransformNoScale_FunctionAddress != IntPtr.Zero && MakeControlValueFromTransformNoScale_InValue_IsValid && MakeControlValueFromTransformNoScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:MakeControlValueFromTransformNoScale", MakeControlValueFromTransformNoScale_IsValid);
		MakeControlValueFromTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeControlValueFromTransform");
		MakeControlValueFromTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeControlValueFromTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromTransform_InValue_PropertyAddress, MakeControlValueFromTransform_FunctionAddress, "InValue");
		MakeControlValueFromTransform_InValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromTransform_FunctionAddress, "InValue");
		MakeControlValueFromTransform_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromTransform_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromTransform_ReturnValue_PropertyAddress, MakeControlValueFromTransform_FunctionAddress, "ReturnValue");
		MakeControlValueFromTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromTransform_FunctionAddress, "ReturnValue");
		MakeControlValueFromTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeControlValueFromTransform_IsValid = MakeControlValueFromTransform_FunctionAddress != IntPtr.Zero && MakeControlValueFromTransform_InValue_IsValid && MakeControlValueFromTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:MakeControlValueFromTransform", MakeControlValueFromTransform_IsValid);
		MakeControlValueFromRotator_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeControlValueFromRotator");
		MakeControlValueFromRotator_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeControlValueFromRotator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromRotator_InValue_PropertyAddress, MakeControlValueFromRotator_FunctionAddress, "InValue");
		MakeControlValueFromRotator_InValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromRotator_FunctionAddress, "InValue");
		MakeControlValueFromRotator_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromRotator_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromRotator_ReturnValue_PropertyAddress, MakeControlValueFromRotator_FunctionAddress, "ReturnValue");
		MakeControlValueFromRotator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromRotator_FunctionAddress, "ReturnValue");
		MakeControlValueFromRotator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromRotator_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeControlValueFromRotator_IsValid = MakeControlValueFromRotator_FunctionAddress != IntPtr.Zero && MakeControlValueFromRotator_InValue_IsValid && MakeControlValueFromRotator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:MakeControlValueFromRotator", MakeControlValueFromRotator_IsValid);
		MakeControlValueFromInt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeControlValueFromInt");
		MakeControlValueFromInt_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeControlValueFromInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromInt_InValue_PropertyAddress, MakeControlValueFromInt_FunctionAddress, "InValue");
		MakeControlValueFromInt_InValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromInt_FunctionAddress, "InValue");
		MakeControlValueFromInt_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromInt_FunctionAddress, "InValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromInt_ReturnValue_PropertyAddress, MakeControlValueFromInt_FunctionAddress, "ReturnValue");
		MakeControlValueFromInt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromInt_FunctionAddress, "ReturnValue");
		MakeControlValueFromInt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromInt_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeControlValueFromInt_IsValid = MakeControlValueFromInt_FunctionAddress != IntPtr.Zero && MakeControlValueFromInt_InValue_IsValid && MakeControlValueFromInt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:MakeControlValueFromInt", MakeControlValueFromInt_IsValid);
		MakeControlValueFromFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeControlValueFromFloat");
		MakeControlValueFromFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeControlValueFromFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromFloat_InValue_PropertyAddress, MakeControlValueFromFloat_FunctionAddress, "InValue");
		MakeControlValueFromFloat_InValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromFloat_FunctionAddress, "InValue");
		MakeControlValueFromFloat_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromFloat_FunctionAddress, "InValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromFloat_ReturnValue_PropertyAddress, MakeControlValueFromFloat_FunctionAddress, "ReturnValue");
		MakeControlValueFromFloat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromFloat_FunctionAddress, "ReturnValue");
		MakeControlValueFromFloat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromFloat_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeControlValueFromFloat_IsValid = MakeControlValueFromFloat_FunctionAddress != IntPtr.Zero && MakeControlValueFromFloat_InValue_IsValid && MakeControlValueFromFloat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:MakeControlValueFromFloat", MakeControlValueFromFloat_IsValid);
		MakeControlValueFromEulerTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeControlValueFromEulerTransform");
		MakeControlValueFromEulerTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeControlValueFromEulerTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromEulerTransform_InValue_PropertyAddress, MakeControlValueFromEulerTransform_FunctionAddress, "InValue");
		MakeControlValueFromEulerTransform_InValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromEulerTransform_FunctionAddress, "InValue");
		MakeControlValueFromEulerTransform_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromEulerTransform_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromEulerTransform_ReturnValue_PropertyAddress, MakeControlValueFromEulerTransform_FunctionAddress, "ReturnValue");
		MakeControlValueFromEulerTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromEulerTransform_FunctionAddress, "ReturnValue");
		MakeControlValueFromEulerTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromEulerTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeControlValueFromEulerTransform_IsValid = MakeControlValueFromEulerTransform_FunctionAddress != IntPtr.Zero && MakeControlValueFromEulerTransform_InValue_IsValid && MakeControlValueFromEulerTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:MakeControlValueFromEulerTransform", MakeControlValueFromEulerTransform_IsValid);
		MakeControlValueFromBool_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeControlValueFromBool");
		MakeControlValueFromBool_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeControlValueFromBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromBool_InValue_PropertyAddress, MakeControlValueFromBool_FunctionAddress, "InValue");
		MakeControlValueFromBool_InValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromBool_FunctionAddress, "InValue");
		MakeControlValueFromBool_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromBool_FunctionAddress, "InValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeControlValueFromBool_ReturnValue_PropertyAddress, MakeControlValueFromBool_FunctionAddress, "ReturnValue");
		MakeControlValueFromBool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeControlValueFromBool_FunctionAddress, "ReturnValue");
		MakeControlValueFromBool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeControlValueFromBool_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeControlValueFromBool_IsValid = MakeControlValueFromBool_FunctionAddress != IntPtr.Zero && MakeControlValueFromBool_InValue_IsValid && MakeControlValueFromBool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:MakeControlValueFromBool", MakeControlValueFromBool_IsValid);
		IsValidIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidIndex");
		IsValidIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidIndex_InElementIndex_PropertyAddress, IsValidIndex_FunctionAddress, "InElementIndex");
		IsValidIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(IsValidIndex_FunctionAddress, "InElementIndex");
		IsValidIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidIndex_ReturnValue_PropertyAddress, IsValidIndex_FunctionAddress, "ReturnValue");
		IsValidIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidIndex_FunctionAddress, "ReturnValue");
		IsValidIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidIndex_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidIndex_IsValid = IsValidIndex_FunctionAddress != IntPtr.Zero && IsValidIndex_InElementIndex_IsValid && IsValidIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:IsValidIndex", IsValidIndex_IsValid);
		IsSelectedByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsSelectedByIndex");
		IsSelectedByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSelectedByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSelectedByIndex_InIndex_PropertyAddress, IsSelectedByIndex_FunctionAddress, "InIndex");
		IsSelectedByIndex_InIndex_Offset = NativeReflectionCached.GetPropertyOffset(IsSelectedByIndex_FunctionAddress, "InIndex");
		IsSelectedByIndex_InIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSelectedByIndex_FunctionAddress, "InIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSelectedByIndex_ReturnValue_PropertyAddress, IsSelectedByIndex_FunctionAddress, "ReturnValue");
		IsSelectedByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSelectedByIndex_FunctionAddress, "ReturnValue");
		IsSelectedByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSelectedByIndex_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSelectedByIndex_IsValid = IsSelectedByIndex_FunctionAddress != IntPtr.Zero && IsSelectedByIndex_InIndex_IsValid && IsSelectedByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:IsSelectedByIndex", IsSelectedByIndex_IsValid);
		IsSelected_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsSelected");
		IsSelected_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSelected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSelected_InKey_PropertyAddress, IsSelected_FunctionAddress, "InKey");
		IsSelected_InKey_Offset = NativeReflectionCached.GetPropertyOffset(IsSelected_FunctionAddress, "InKey");
		IsSelected_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSelected_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSelected_ReturnValue_PropertyAddress, IsSelected_FunctionAddress, "ReturnValue");
		IsSelected_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSelected_FunctionAddress, "ReturnValue");
		IsSelected_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSelected_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSelected_IsValid = IsSelected_FunctionAddress != IntPtr.Zero && IsSelected_InKey_IsValid && IsSelected_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:IsSelected", IsSelected_IsValid);
		IsParentedTo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsParentedTo");
		IsParentedTo_ParamsSize = NativeReflection.GetFunctionParamsSize(IsParentedTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsParentedTo_InChild_PropertyAddress, IsParentedTo_FunctionAddress, "InChild");
		IsParentedTo_InChild_Offset = NativeReflectionCached.GetPropertyOffset(IsParentedTo_FunctionAddress, "InChild");
		IsParentedTo_InChild_IsValid = NativeReflectionCached.ValidatePropertyClass(IsParentedTo_FunctionAddress, "InChild", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsParentedTo_InParent_PropertyAddress, IsParentedTo_FunctionAddress, "InParent");
		IsParentedTo_InParent_Offset = NativeReflectionCached.GetPropertyOffset(IsParentedTo_FunctionAddress, "InParent");
		IsParentedTo_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsParentedTo_FunctionAddress, "InParent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsParentedTo_ReturnValue_PropertyAddress, IsParentedTo_FunctionAddress, "ReturnValue");
		IsParentedTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsParentedTo_FunctionAddress, "ReturnValue");
		IsParentedTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsParentedTo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsParentedTo_IsValid = IsParentedTo_FunctionAddress != IntPtr.Zero && IsParentedTo_InChild_IsValid && IsParentedTo_InParent_IsValid && IsParentedTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:IsParentedTo", IsParentedTo_IsValid);
		GetVectorFromControlValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVectorFromControlValue");
		GetVectorFromControlValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorFromControlValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorFromControlValue_InValue_PropertyAddress, GetVectorFromControlValue_FunctionAddress, "InValue");
		GetVectorFromControlValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorFromControlValue_FunctionAddress, "InValue");
		GetVectorFromControlValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorFromControlValue_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorFromControlValue_ReturnValue_PropertyAddress, GetVectorFromControlValue_FunctionAddress, "ReturnValue");
		GetVectorFromControlValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorFromControlValue_FunctionAddress, "ReturnValue");
		GetVectorFromControlValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorFromControlValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVectorFromControlValue_IsValid = GetVectorFromControlValue_FunctionAddress != IntPtr.Zero && GetVectorFromControlValue_InValue_IsValid && GetVectorFromControlValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetVectorFromControlValue", GetVectorFromControlValue_IsValid);
		GetVector2DFromControlValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVector2DFromControlValue");
		GetVector2DFromControlValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVector2DFromControlValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVector2DFromControlValue_InValue_PropertyAddress, GetVector2DFromControlValue_FunctionAddress, "InValue");
		GetVector2DFromControlValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2DFromControlValue_FunctionAddress, "InValue");
		GetVector2DFromControlValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2DFromControlValue_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVector2DFromControlValue_ReturnValue_PropertyAddress, GetVector2DFromControlValue_FunctionAddress, "ReturnValue");
		GetVector2DFromControlValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVector2DFromControlValue_FunctionAddress, "ReturnValue");
		GetVector2DFromControlValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVector2DFromControlValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVector2DFromControlValue_IsValid = GetVector2DFromControlValue_FunctionAddress != IntPtr.Zero && GetVector2DFromControlValue_InValue_IsValid && GetVector2DFromControlValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetVector2DFromControlValue", GetVector2DFromControlValue_IsValid);
		GetTransformNoScaleFromControlValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTransformNoScaleFromControlValue");
		GetTransformNoScaleFromControlValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransformNoScaleFromControlValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransformNoScaleFromControlValue_InValue_PropertyAddress, GetTransformNoScaleFromControlValue_FunctionAddress, "InValue");
		GetTransformNoScaleFromControlValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformNoScaleFromControlValue_FunctionAddress, "InValue");
		GetTransformNoScaleFromControlValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformNoScaleFromControlValue_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformNoScaleFromControlValue_ReturnValue_PropertyAddress, GetTransformNoScaleFromControlValue_FunctionAddress, "ReturnValue");
		GetTransformNoScaleFromControlValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformNoScaleFromControlValue_FunctionAddress, "ReturnValue");
		GetTransformNoScaleFromControlValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformNoScaleFromControlValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTransformNoScaleFromControlValue_IsValid = GetTransformNoScaleFromControlValue_FunctionAddress != IntPtr.Zero && GetTransformNoScaleFromControlValue_InValue_IsValid && GetTransformNoScaleFromControlValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetTransformNoScaleFromControlValue", GetTransformNoScaleFromControlValue_IsValid);
		GetTransformFromControlValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTransformFromControlValue");
		GetTransformFromControlValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransformFromControlValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransformFromControlValue_InValue_PropertyAddress, GetTransformFromControlValue_FunctionAddress, "InValue");
		GetTransformFromControlValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformFromControlValue_FunctionAddress, "InValue");
		GetTransformFromControlValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformFromControlValue_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformFromControlValue_ReturnValue_PropertyAddress, GetTransformFromControlValue_FunctionAddress, "ReturnValue");
		GetTransformFromControlValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformFromControlValue_FunctionAddress, "ReturnValue");
		GetTransformFromControlValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformFromControlValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTransformFromControlValue_IsValid = GetTransformFromControlValue_FunctionAddress != IntPtr.Zero && GetTransformFromControlValue_InValue_IsValid && GetTransformFromControlValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetTransformFromControlValue", GetTransformFromControlValue_IsValid);
		GetSelectedKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedKeys");
		GetSelectedKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedKeys_InTypeFilter_PropertyAddress, GetSelectedKeys_FunctionAddress, "InTypeFilter");
		GetSelectedKeys_InTypeFilter_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedKeys_FunctionAddress, "InTypeFilter");
		GetSelectedKeys_InTypeFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedKeys_FunctionAddress, "InTypeFilter", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedKeys_ReturnValue_PropertyAddress, GetSelectedKeys_FunctionAddress, "ReturnValue");
		GetSelectedKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedKeys_FunctionAddress, "ReturnValue");
		GetSelectedKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedKeys_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedKeys_IsValid = GetSelectedKeys_FunctionAddress != IntPtr.Zero && GetSelectedKeys_InTypeFilter_IsValid && GetSelectedKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetSelectedKeys", GetSelectedKeys_IsValid);
		GetRotatorFromControlValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRotatorFromControlValue");
		GetRotatorFromControlValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRotatorFromControlValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRotatorFromControlValue_InValue_PropertyAddress, GetRotatorFromControlValue_FunctionAddress, "InValue");
		GetRotatorFromControlValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotatorFromControlValue_FunctionAddress, "InValue");
		GetRotatorFromControlValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotatorFromControlValue_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRotatorFromControlValue_ReturnValue_PropertyAddress, GetRotatorFromControlValue_FunctionAddress, "ReturnValue");
		GetRotatorFromControlValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRotatorFromControlValue_FunctionAddress, "ReturnValue");
		GetRotatorFromControlValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRotatorFromControlValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRotatorFromControlValue_IsValid = GetRotatorFromControlValue_FunctionAddress != IntPtr.Zero && GetRotatorFromControlValue_InValue_IsValid && GetRotatorFromControlValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetRotatorFromControlValue", GetRotatorFromControlValue_IsValid);
		GetRigidBodies_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRigidBodyKeys");
		GetRigidBodies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRigidBodies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRigidBodies_bTraverse_PropertyAddress, GetRigidBodies_FunctionAddress, "bTraverse");
		GetRigidBodies_bTraverse_Offset = NativeReflectionCached.GetPropertyOffset(GetRigidBodies_FunctionAddress, "bTraverse");
		GetRigidBodies_bTraverse_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRigidBodies_FunctionAddress, "bTraverse", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRigidBodies_ReturnValue_PropertyAddress, GetRigidBodies_FunctionAddress, "ReturnValue");
		GetRigidBodies_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRigidBodies_FunctionAddress, "ReturnValue");
		GetRigidBodies_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRigidBodies_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetRigidBodies_IsValid = GetRigidBodies_FunctionAddress != IntPtr.Zero && GetRigidBodies_bTraverse_IsValid && GetRigidBodies_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetRigidBodyKeys", GetRigidBodies_IsValid);
		GetReferences_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetReferenceKeys");
		GetReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReferences_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReferences_bTraverse_PropertyAddress, GetReferences_FunctionAddress, "bTraverse");
		GetReferences_bTraverse_Offset = NativeReflectionCached.GetPropertyOffset(GetReferences_FunctionAddress, "bTraverse");
		GetReferences_bTraverse_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferences_FunctionAddress, "bTraverse", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReferences_ReturnValue_PropertyAddress, GetReferences_FunctionAddress, "ReturnValue");
		GetReferences_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetReferences_FunctionAddress, "ReturnValue");
		GetReferences_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetReferences_IsValid = GetReferences_FunctionAddress != IntPtr.Zero && GetReferences_bTraverse_IsValid && GetReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetReferenceKeys", GetReferences_IsValid);
		GetPreviousParent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPreviousParent");
		GetPreviousParent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreviousParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreviousParent_InKey_PropertyAddress, GetPreviousParent_FunctionAddress, "InKey");
		GetPreviousParent_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviousParent_FunctionAddress, "InKey");
		GetPreviousParent_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviousParent_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPreviousParent_ReturnValue_PropertyAddress, GetPreviousParent_FunctionAddress, "ReturnValue");
		GetPreviousParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviousParent_FunctionAddress, "ReturnValue");
		GetPreviousParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviousParent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPreviousParent_IsValid = GetPreviousParent_FunctionAddress != IntPtr.Zero && GetPreviousParent_InKey_IsValid && GetPreviousParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetPreviousParent", GetPreviousParent_IsValid);
		GetPreviousName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPreviousName");
		GetPreviousName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreviousName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreviousName_InKey_PropertyAddress, GetPreviousName_FunctionAddress, "InKey");
		GetPreviousName_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviousName_FunctionAddress, "InKey");
		GetPreviousName_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviousName_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPreviousName_ReturnValue_PropertyAddress, GetPreviousName_FunctionAddress, "ReturnValue");
		GetPreviousName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviousName_FunctionAddress, "ReturnValue");
		GetPreviousName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviousName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetPreviousName_IsValid = GetPreviousName_FunctionAddress != IntPtr.Zero && GetPreviousName_InKey_IsValid && GetPreviousName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetPreviousName", GetPreviousName_IsValid);
		GetPose_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPose");
		GetPose_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPose_bInitial_PropertyAddress, GetPose_FunctionAddress, "bInitial");
		GetPose_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(GetPose_FunctionAddress, "bInitial");
		GetPose_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPose_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPose_ReturnValue_PropertyAddress, GetPose_FunctionAddress, "ReturnValue");
		GetPose_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPose_FunctionAddress, "ReturnValue");
		GetPose_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPose_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPose_IsValid = GetPose_FunctionAddress != IntPtr.Zero && GetPose_bInitial_IsValid && GetPose_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetPose", GetPose_IsValid);
		GetParentWeightArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParentWeightArray");
		GetParentWeightArray_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentWeightArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentWeightArray_InChild_PropertyAddress, GetParentWeightArray_FunctionAddress, "InChild");
		GetParentWeightArray_InChild_Offset = NativeReflectionCached.GetPropertyOffset(GetParentWeightArray_FunctionAddress, "InChild");
		GetParentWeightArray_InChild_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentWeightArray_FunctionAddress, "InChild", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentWeightArray_bInitial_PropertyAddress, GetParentWeightArray_FunctionAddress, "bInitial");
		GetParentWeightArray_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(GetParentWeightArray_FunctionAddress, "bInitial");
		GetParentWeightArray_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentWeightArray_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentWeightArray_ReturnValue_PropertyAddress, GetParentWeightArray_FunctionAddress, "ReturnValue");
		GetParentWeightArray_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentWeightArray_FunctionAddress, "ReturnValue");
		GetParentWeightArray_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentWeightArray_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetParentWeightArray_IsValid = GetParentWeightArray_FunctionAddress != IntPtr.Zero && GetParentWeightArray_InChild_IsValid && GetParentWeightArray_bInitial_IsValid && GetParentWeightArray_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetParentWeightArray", GetParentWeightArray_IsValid);
		GetParentWeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParentWeight");
		GetParentWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentWeight_InChild_PropertyAddress, GetParentWeight_FunctionAddress, "InChild");
		GetParentWeight_InChild_Offset = NativeReflectionCached.GetPropertyOffset(GetParentWeight_FunctionAddress, "InChild");
		GetParentWeight_InChild_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentWeight_FunctionAddress, "InChild", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentWeight_InParent_PropertyAddress, GetParentWeight_FunctionAddress, "InParent");
		GetParentWeight_InParent_Offset = NativeReflectionCached.GetPropertyOffset(GetParentWeight_FunctionAddress, "InParent");
		GetParentWeight_InParent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentWeight_FunctionAddress, "InParent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentWeight_bInitial_PropertyAddress, GetParentWeight_FunctionAddress, "bInitial");
		GetParentWeight_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(GetParentWeight_FunctionAddress, "bInitial");
		GetParentWeight_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentWeight_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentWeight_ReturnValue_PropertyAddress, GetParentWeight_FunctionAddress, "ReturnValue");
		GetParentWeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentWeight_FunctionAddress, "ReturnValue");
		GetParentWeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentWeight_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetParentWeight_IsValid = GetParentWeight_FunctionAddress != IntPtr.Zero && GetParentWeight_InChild_IsValid && GetParentWeight_InParent_IsValid && GetParentWeight_bInitial_IsValid && GetParentWeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetParentWeight", GetParentWeight_IsValid);
		GetParentTransformByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParentTransformByIndex");
		GetParentTransformByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentTransformByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentTransformByIndex_InElementIndex_PropertyAddress, GetParentTransformByIndex_FunctionAddress, "InElementIndex");
		GetParentTransformByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetParentTransformByIndex_FunctionAddress, "InElementIndex");
		GetParentTransformByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentTransformByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentTransformByIndex_bInitial_PropertyAddress, GetParentTransformByIndex_FunctionAddress, "bInitial");
		GetParentTransformByIndex_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(GetParentTransformByIndex_FunctionAddress, "bInitial");
		GetParentTransformByIndex_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentTransformByIndex_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentTransformByIndex_ReturnValue_PropertyAddress, GetParentTransformByIndex_FunctionAddress, "ReturnValue");
		GetParentTransformByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentTransformByIndex_FunctionAddress, "ReturnValue");
		GetParentTransformByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentTransformByIndex_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetParentTransformByIndex_IsValid = GetParentTransformByIndex_FunctionAddress != IntPtr.Zero && GetParentTransformByIndex_InElementIndex_IsValid && GetParentTransformByIndex_bInitial_IsValid && GetParentTransformByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetParentTransformByIndex", GetParentTransformByIndex_IsValid);
		GetParentTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParentTransform");
		GetParentTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentTransform_InKey_PropertyAddress, GetParentTransform_FunctionAddress, "InKey");
		GetParentTransform_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetParentTransform_FunctionAddress, "InKey");
		GetParentTransform_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentTransform_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentTransform_bInitial_PropertyAddress, GetParentTransform_FunctionAddress, "bInitial");
		GetParentTransform_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(GetParentTransform_FunctionAddress, "bInitial");
		GetParentTransform_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentTransform_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentTransform_ReturnValue_PropertyAddress, GetParentTransform_FunctionAddress, "ReturnValue");
		GetParentTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentTransform_FunctionAddress, "ReturnValue");
		GetParentTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetParentTransform_IsValid = GetParentTransform_FunctionAddress != IntPtr.Zero && GetParentTransform_InKey_IsValid && GetParentTransform_bInitial_IsValid && GetParentTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetParentTransform", GetParentTransform_IsValid);
		GetParents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParents");
		GetParents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParents_InKey_PropertyAddress, GetParents_FunctionAddress, "InKey");
		GetParents_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetParents_FunctionAddress, "InKey");
		GetParents_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParents_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParents_bRecursive_PropertyAddress, GetParents_FunctionAddress, "bRecursive");
		GetParents_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(GetParents_FunctionAddress, "bRecursive");
		GetParents_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParents_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParents_ReturnValue_PropertyAddress, GetParents_FunctionAddress, "ReturnValue");
		GetParents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParents_FunctionAddress, "ReturnValue");
		GetParents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParents_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetParents_IsValid = GetParents_FunctionAddress != IntPtr.Zero && GetParents_InKey_IsValid && GetParents_bRecursive_IsValid && GetParents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetParents", GetParents_IsValid);
		GetNumberOfParents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumberOfParents");
		GetNumberOfParents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumberOfParents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumberOfParents_InKey_PropertyAddress, GetNumberOfParents_FunctionAddress, "InKey");
		GetNumberOfParents_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberOfParents_FunctionAddress, "InKey");
		GetNumberOfParents_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberOfParents_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumberOfParents_ReturnValue_PropertyAddress, GetNumberOfParents_FunctionAddress, "ReturnValue");
		GetNumberOfParents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberOfParents_FunctionAddress, "ReturnValue");
		GetNumberOfParents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberOfParents_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumberOfParents_IsValid = GetNumberOfParents_FunctionAddress != IntPtr.Zero && GetNumberOfParents_InKey_IsValid && GetNumberOfParents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetNumberOfParents", GetNumberOfParents_IsValid);
		GetNulls_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNullKeys");
		GetNulls_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNulls_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNulls_bTraverse_PropertyAddress, GetNulls_FunctionAddress, "bTraverse");
		GetNulls_bTraverse_Offset = NativeReflectionCached.GetPropertyOffset(GetNulls_FunctionAddress, "bTraverse");
		GetNulls_bTraverse_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNulls_FunctionAddress, "bTraverse", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNulls_ReturnValue_PropertyAddress, GetNulls_FunctionAddress, "ReturnValue");
		GetNulls_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNulls_FunctionAddress, "ReturnValue");
		GetNulls_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNulls_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNulls_IsValid = GetNulls_FunctionAddress != IntPtr.Zero && GetNulls_bTraverse_IsValid && GetNulls_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetNullKeys", GetNulls_IsValid);
		GetLocalTransformByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalTransformByIndex");
		GetLocalTransformByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalTransformByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalTransformByIndex_InElementIndex_PropertyAddress, GetLocalTransformByIndex_FunctionAddress, "InElementIndex");
		GetLocalTransformByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalTransformByIndex_FunctionAddress, "InElementIndex");
		GetLocalTransformByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalTransformByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalTransformByIndex_bInitial_PropertyAddress, GetLocalTransformByIndex_FunctionAddress, "bInitial");
		GetLocalTransformByIndex_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalTransformByIndex_FunctionAddress, "bInitial");
		GetLocalTransformByIndex_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalTransformByIndex_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalTransformByIndex_ReturnValue_PropertyAddress, GetLocalTransformByIndex_FunctionAddress, "ReturnValue");
		GetLocalTransformByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalTransformByIndex_FunctionAddress, "ReturnValue");
		GetLocalTransformByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalTransformByIndex_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLocalTransformByIndex_IsValid = GetLocalTransformByIndex_FunctionAddress != IntPtr.Zero && GetLocalTransformByIndex_InElementIndex_IsValid && GetLocalTransformByIndex_bInitial_IsValid && GetLocalTransformByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetLocalTransformByIndex", GetLocalTransformByIndex_IsValid);
		GetLocalTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalTransform");
		GetLocalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalTransform_InKey_PropertyAddress, GetLocalTransform_FunctionAddress, "InKey");
		GetLocalTransform_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalTransform_FunctionAddress, "InKey");
		GetLocalTransform_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalTransform_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalTransform_bInitial_PropertyAddress, GetLocalTransform_FunctionAddress, "bInitial");
		GetLocalTransform_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalTransform_FunctionAddress, "bInitial");
		GetLocalTransform_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalTransform_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalTransform_ReturnValue_PropertyAddress, GetLocalTransform_FunctionAddress, "ReturnValue");
		GetLocalTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalTransform_FunctionAddress, "ReturnValue");
		GetLocalTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLocalTransform_IsValid = GetLocalTransform_FunctionAddress != IntPtr.Zero && GetLocalTransform_InKey_IsValid && GetLocalTransform_bInitial_IsValid && GetLocalTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetLocalTransform", GetLocalTransform_IsValid);
		GetKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetKey");
		GetKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKey_InElementIndex_PropertyAddress, GetKey_FunctionAddress, "InElementIndex");
		GetKey_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetKey_FunctionAddress, "InElementIndex");
		GetKey_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKey_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKey_ReturnValue_PropertyAddress, GetKey_FunctionAddress, "ReturnValue");
		GetKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKey_FunctionAddress, "ReturnValue");
		GetKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetKey_IsValid = GetKey_FunctionAddress != IntPtr.Zero && GetKey_InElementIndex_IsValid && GetKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetKey", GetKey_IsValid);
		GetIntFromControlValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIntFromControlValue");
		GetIntFromControlValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIntFromControlValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIntFromControlValue_InValue_PropertyAddress, GetIntFromControlValue_FunctionAddress, "InValue");
		GetIntFromControlValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIntFromControlValue_FunctionAddress, "InValue");
		GetIntFromControlValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIntFromControlValue_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIntFromControlValue_ReturnValue_PropertyAddress, GetIntFromControlValue_FunctionAddress, "ReturnValue");
		GetIntFromControlValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIntFromControlValue_FunctionAddress, "ReturnValue");
		GetIntFromControlValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIntFromControlValue_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetIntFromControlValue_IsValid = GetIntFromControlValue_FunctionAddress != IntPtr.Zero && GetIntFromControlValue_InValue_IsValid && GetIntFromControlValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetIntFromControlValue", GetIntFromControlValue_IsValid);
		GetIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIndex_ForBlueprint");
		GetIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIndex_InKey_PropertyAddress, GetIndex_FunctionAddress, "InKey");
		GetIndex_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetIndex_FunctionAddress, "InKey");
		GetIndex_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIndex_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIndex_ReturnValue_PropertyAddress, GetIndex_FunctionAddress, "ReturnValue");
		GetIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIndex_FunctionAddress, "ReturnValue");
		GetIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetIndex_IsValid = GetIndex_FunctionAddress != IntPtr.Zero && GetIndex_InKey_IsValid && GetIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetIndex_ForBlueprint", GetIndex_IsValid);
		GetGlobalTransformByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGlobalTransformByIndex");
		GetGlobalTransformByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGlobalTransformByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalTransformByIndex_InElementIndex_PropertyAddress, GetGlobalTransformByIndex_FunctionAddress, "InElementIndex");
		GetGlobalTransformByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalTransformByIndex_FunctionAddress, "InElementIndex");
		GetGlobalTransformByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalTransformByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalTransformByIndex_bInitial_PropertyAddress, GetGlobalTransformByIndex_FunctionAddress, "bInitial");
		GetGlobalTransformByIndex_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalTransformByIndex_FunctionAddress, "bInitial");
		GetGlobalTransformByIndex_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalTransformByIndex_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalTransformByIndex_ReturnValue_PropertyAddress, GetGlobalTransformByIndex_FunctionAddress, "ReturnValue");
		GetGlobalTransformByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalTransformByIndex_FunctionAddress, "ReturnValue");
		GetGlobalTransformByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalTransformByIndex_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetGlobalTransformByIndex_IsValid = GetGlobalTransformByIndex_FunctionAddress != IntPtr.Zero && GetGlobalTransformByIndex_InElementIndex_IsValid && GetGlobalTransformByIndex_bInitial_IsValid && GetGlobalTransformByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetGlobalTransformByIndex", GetGlobalTransformByIndex_IsValid);
		GetGlobalTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGlobalTransform");
		GetGlobalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGlobalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalTransform_InKey_PropertyAddress, GetGlobalTransform_FunctionAddress, "InKey");
		GetGlobalTransform_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalTransform_FunctionAddress, "InKey");
		GetGlobalTransform_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalTransform_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalTransform_bInitial_PropertyAddress, GetGlobalTransform_FunctionAddress, "bInitial");
		GetGlobalTransform_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalTransform_FunctionAddress, "bInitial");
		GetGlobalTransform_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalTransform_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalTransform_ReturnValue_PropertyAddress, GetGlobalTransform_FunctionAddress, "ReturnValue");
		GetGlobalTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalTransform_FunctionAddress, "ReturnValue");
		GetGlobalTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetGlobalTransform_IsValid = GetGlobalTransform_FunctionAddress != IntPtr.Zero && GetGlobalTransform_InKey_IsValid && GetGlobalTransform_bInitial_IsValid && GetGlobalTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetGlobalTransform", GetGlobalTransform_IsValid);
		GetGlobalControlShapeTransformByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGlobalControlShapeTransformByIndex");
		GetGlobalControlShapeTransformByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGlobalControlShapeTransformByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalControlShapeTransformByIndex_InElementIndex_PropertyAddress, GetGlobalControlShapeTransformByIndex_FunctionAddress, "InElementIndex");
		GetGlobalControlShapeTransformByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalControlShapeTransformByIndex_FunctionAddress, "InElementIndex");
		GetGlobalControlShapeTransformByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalControlShapeTransformByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalControlShapeTransformByIndex_bInitial_PropertyAddress, GetGlobalControlShapeTransformByIndex_FunctionAddress, "bInitial");
		GetGlobalControlShapeTransformByIndex_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalControlShapeTransformByIndex_FunctionAddress, "bInitial");
		GetGlobalControlShapeTransformByIndex_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalControlShapeTransformByIndex_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalControlShapeTransformByIndex_ReturnValue_PropertyAddress, GetGlobalControlShapeTransformByIndex_FunctionAddress, "ReturnValue");
		GetGlobalControlShapeTransformByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalControlShapeTransformByIndex_FunctionAddress, "ReturnValue");
		GetGlobalControlShapeTransformByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalControlShapeTransformByIndex_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetGlobalControlShapeTransformByIndex_IsValid = GetGlobalControlShapeTransformByIndex_FunctionAddress != IntPtr.Zero && GetGlobalControlShapeTransformByIndex_InElementIndex_IsValid && GetGlobalControlShapeTransformByIndex_bInitial_IsValid && GetGlobalControlShapeTransformByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetGlobalControlShapeTransformByIndex", GetGlobalControlShapeTransformByIndex_IsValid);
		GetGlobalControlShapeTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGlobalControlShapeTransform");
		GetGlobalControlShapeTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGlobalControlShapeTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalControlShapeTransform_InKey_PropertyAddress, GetGlobalControlShapeTransform_FunctionAddress, "InKey");
		GetGlobalControlShapeTransform_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalControlShapeTransform_FunctionAddress, "InKey");
		GetGlobalControlShapeTransform_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalControlShapeTransform_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalControlShapeTransform_bInitial_PropertyAddress, GetGlobalControlShapeTransform_FunctionAddress, "bInitial");
		GetGlobalControlShapeTransform_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalControlShapeTransform_FunctionAddress, "bInitial");
		GetGlobalControlShapeTransform_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalControlShapeTransform_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalControlShapeTransform_ReturnValue_PropertyAddress, GetGlobalControlShapeTransform_FunctionAddress, "ReturnValue");
		GetGlobalControlShapeTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalControlShapeTransform_FunctionAddress, "ReturnValue");
		GetGlobalControlShapeTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalControlShapeTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetGlobalControlShapeTransform_IsValid = GetGlobalControlShapeTransform_FunctionAddress != IntPtr.Zero && GetGlobalControlShapeTransform_InKey_IsValid && GetGlobalControlShapeTransform_bInitial_IsValid && GetGlobalControlShapeTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetGlobalControlShapeTransform", GetGlobalControlShapeTransform_IsValid);
		GetGlobalControlOffsetTransformByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGlobalControlOffsetTransformByIndex");
		GetGlobalControlOffsetTransformByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGlobalControlOffsetTransformByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalControlOffsetTransformByIndex_InElementIndex_PropertyAddress, GetGlobalControlOffsetTransformByIndex_FunctionAddress, "InElementIndex");
		GetGlobalControlOffsetTransformByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalControlOffsetTransformByIndex_FunctionAddress, "InElementIndex");
		GetGlobalControlOffsetTransformByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalControlOffsetTransformByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalControlOffsetTransformByIndex_bInitial_PropertyAddress, GetGlobalControlOffsetTransformByIndex_FunctionAddress, "bInitial");
		GetGlobalControlOffsetTransformByIndex_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalControlOffsetTransformByIndex_FunctionAddress, "bInitial");
		GetGlobalControlOffsetTransformByIndex_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalControlOffsetTransformByIndex_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalControlOffsetTransformByIndex_ReturnValue_PropertyAddress, GetGlobalControlOffsetTransformByIndex_FunctionAddress, "ReturnValue");
		GetGlobalControlOffsetTransformByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalControlOffsetTransformByIndex_FunctionAddress, "ReturnValue");
		GetGlobalControlOffsetTransformByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalControlOffsetTransformByIndex_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetGlobalControlOffsetTransformByIndex_IsValid = GetGlobalControlOffsetTransformByIndex_FunctionAddress != IntPtr.Zero && GetGlobalControlOffsetTransformByIndex_InElementIndex_IsValid && GetGlobalControlOffsetTransformByIndex_bInitial_IsValid && GetGlobalControlOffsetTransformByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetGlobalControlOffsetTransformByIndex", GetGlobalControlOffsetTransformByIndex_IsValid);
		GetGlobalControlOffsetTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGlobalControlOffsetTransform");
		GetGlobalControlOffsetTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGlobalControlOffsetTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalControlOffsetTransform_InKey_PropertyAddress, GetGlobalControlOffsetTransform_FunctionAddress, "InKey");
		GetGlobalControlOffsetTransform_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalControlOffsetTransform_FunctionAddress, "InKey");
		GetGlobalControlOffsetTransform_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalControlOffsetTransform_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalControlOffsetTransform_bInitial_PropertyAddress, GetGlobalControlOffsetTransform_FunctionAddress, "bInitial");
		GetGlobalControlOffsetTransform_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalControlOffsetTransform_FunctionAddress, "bInitial");
		GetGlobalControlOffsetTransform_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalControlOffsetTransform_FunctionAddress, "bInitial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGlobalControlOffsetTransform_ReturnValue_PropertyAddress, GetGlobalControlOffsetTransform_FunctionAddress, "ReturnValue");
		GetGlobalControlOffsetTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGlobalControlOffsetTransform_FunctionAddress, "ReturnValue");
		GetGlobalControlOffsetTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGlobalControlOffsetTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetGlobalControlOffsetTransform_IsValid = GetGlobalControlOffsetTransform_FunctionAddress != IntPtr.Zero && GetGlobalControlOffsetTransform_InKey_IsValid && GetGlobalControlOffsetTransform_bInitial_IsValid && GetGlobalControlOffsetTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetGlobalControlOffsetTransform", GetGlobalControlOffsetTransform_IsValid);
		GetFloatFromControlValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFloatFromControlValue");
		GetFloatFromControlValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloatFromControlValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloatFromControlValue_InValue_PropertyAddress, GetFloatFromControlValue_FunctionAddress, "InValue");
		GetFloatFromControlValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatFromControlValue_FunctionAddress, "InValue");
		GetFloatFromControlValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatFromControlValue_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatFromControlValue_ReturnValue_PropertyAddress, GetFloatFromControlValue_FunctionAddress, "ReturnValue");
		GetFloatFromControlValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatFromControlValue_FunctionAddress, "ReturnValue");
		GetFloatFromControlValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatFromControlValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFloatFromControlValue_IsValid = GetFloatFromControlValue_FunctionAddress != IntPtr.Zero && GetFloatFromControlValue_InValue_IsValid && GetFloatFromControlValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetFloatFromControlValue", GetFloatFromControlValue_IsValid);
		GetFirstParent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFirstParent");
		GetFirstParent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFirstParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFirstParent_InKey_PropertyAddress, GetFirstParent_FunctionAddress, "InKey");
		GetFirstParent_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetFirstParent_FunctionAddress, "InKey");
		GetFirstParent_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFirstParent_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFirstParent_ReturnValue_PropertyAddress, GetFirstParent_FunctionAddress, "ReturnValue");
		GetFirstParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFirstParent_FunctionAddress, "ReturnValue");
		GetFirstParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFirstParent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetFirstParent_IsValid = GetFirstParent_FunctionAddress != IntPtr.Zero && GetFirstParent_InKey_IsValid && GetFirstParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetFirstParent", GetFirstParent_IsValid);
		GetEulerTransformFromControlValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEulerTransformFromControlValue");
		GetEulerTransformFromControlValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEulerTransformFromControlValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEulerTransformFromControlValue_InValue_PropertyAddress, GetEulerTransformFromControlValue_FunctionAddress, "InValue");
		GetEulerTransformFromControlValue_InValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEulerTransformFromControlValue_FunctionAddress, "InValue");
		GetEulerTransformFromControlValue_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEulerTransformFromControlValue_FunctionAddress, "InValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEulerTransformFromControlValue_ReturnValue_PropertyAddress, GetEulerTransformFromControlValue_FunctionAddress, "ReturnValue");
		GetEulerTransformFromControlValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEulerTransformFromControlValue_FunctionAddress, "ReturnValue");
		GetEulerTransformFromControlValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEulerTransformFromControlValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetEulerTransformFromControlValue_IsValid = GetEulerTransformFromControlValue_FunctionAddress != IntPtr.Zero && GetEulerTransformFromControlValue_InValue_IsValid && GetEulerTransformFromControlValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetEulerTransformFromControlValue", GetEulerTransformFromControlValue_IsValid);
		GetCurveValueByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurveValueByIndex");
		GetCurveValueByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurveValueByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurveValueByIndex_InElementIndex_PropertyAddress, GetCurveValueByIndex_FunctionAddress, "InElementIndex");
		GetCurveValueByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveValueByIndex_FunctionAddress, "InElementIndex");
		GetCurveValueByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveValueByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurveValueByIndex_ReturnValue_PropertyAddress, GetCurveValueByIndex_FunctionAddress, "ReturnValue");
		GetCurveValueByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveValueByIndex_FunctionAddress, "ReturnValue");
		GetCurveValueByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveValueByIndex_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurveValueByIndex_IsValid = GetCurveValueByIndex_FunctionAddress != IntPtr.Zero && GetCurveValueByIndex_InElementIndex_IsValid && GetCurveValueByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetCurveValueByIndex", GetCurveValueByIndex_IsValid);
		GetCurveValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurveValue");
		GetCurveValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurveValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurveValue_InKey_PropertyAddress, GetCurveValue_FunctionAddress, "InKey");
		GetCurveValue_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveValue_FunctionAddress, "InKey");
		GetCurveValue_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveValue_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurveValue_ReturnValue_PropertyAddress, GetCurveValue_FunctionAddress, "ReturnValue");
		GetCurveValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveValue_FunctionAddress, "ReturnValue");
		GetCurveValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurveValue_IsValid = GetCurveValue_FunctionAddress != IntPtr.Zero && GetCurveValue_InKey_IsValid && GetCurveValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetCurveValue", GetCurveValue_IsValid);
		GetCurves_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurveKeys");
		GetCurves_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurves_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurves_ReturnValue_PropertyAddress, GetCurves_FunctionAddress, "ReturnValue");
		GetCurves_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurves_FunctionAddress, "ReturnValue");
		GetCurves_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurves_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCurves_IsValid = GetCurves_FunctionAddress != IntPtr.Zero && GetCurves_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetCurveKeys", GetCurves_IsValid);
		GetControlValueByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetControlValueByIndex");
		GetControlValueByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlValueByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlValueByIndex_InElementIndex_PropertyAddress, GetControlValueByIndex_FunctionAddress, "InElementIndex");
		GetControlValueByIndex_InElementIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetControlValueByIndex_FunctionAddress, "InElementIndex");
		GetControlValueByIndex_InElementIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlValueByIndex_FunctionAddress, "InElementIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlValueByIndex_InValueType_PropertyAddress, GetControlValueByIndex_FunctionAddress, "InValueType");
		GetControlValueByIndex_InValueType_Offset = NativeReflectionCached.GetPropertyOffset(GetControlValueByIndex_FunctionAddress, "InValueType");
		GetControlValueByIndex_InValueType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlValueByIndex_FunctionAddress, "InValueType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlValueByIndex_ReturnValue_PropertyAddress, GetControlValueByIndex_FunctionAddress, "ReturnValue");
		GetControlValueByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlValueByIndex_FunctionAddress, "ReturnValue");
		GetControlValueByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlValueByIndex_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetControlValueByIndex_IsValid = GetControlValueByIndex_FunctionAddress != IntPtr.Zero && GetControlValueByIndex_InElementIndex_IsValid && GetControlValueByIndex_InValueType_IsValid && GetControlValueByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetControlValueByIndex", GetControlValueByIndex_IsValid);
		GetControlValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetControlValue");
		GetControlValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlValue_InKey_PropertyAddress, GetControlValue_FunctionAddress, "InKey");
		GetControlValue_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetControlValue_FunctionAddress, "InKey");
		GetControlValue_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlValue_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlValue_InValueType_PropertyAddress, GetControlValue_FunctionAddress, "InValueType");
		GetControlValue_InValueType_Offset = NativeReflectionCached.GetPropertyOffset(GetControlValue_FunctionAddress, "InValueType");
		GetControlValue_InValueType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlValue_FunctionAddress, "InValueType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControlValue_ReturnValue_PropertyAddress, GetControlValue_FunctionAddress, "ReturnValue");
		GetControlValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlValue_FunctionAddress, "ReturnValue");
		GetControlValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetControlValue_IsValid = GetControlValue_FunctionAddress != IntPtr.Zero && GetControlValue_InKey_IsValid && GetControlValue_InValueType_IsValid && GetControlValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetControlValue", GetControlValue_IsValid);
		GetController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetController");
		GetController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetController_bCreateIfNeeded_PropertyAddress, GetController_FunctionAddress, "bCreateIfNeeded");
		GetController_bCreateIfNeeded_Offset = NativeReflectionCached.GetPropertyOffset(GetController_FunctionAddress, "bCreateIfNeeded");
		GetController_bCreateIfNeeded_IsValid = NativeReflectionCached.ValidatePropertyClass(GetController_FunctionAddress, "bCreateIfNeeded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetController_ReturnValue_PropertyAddress, GetController_FunctionAddress, "ReturnValue");
		GetController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetController_FunctionAddress, "ReturnValue");
		GetController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetController_IsValid = GetController_FunctionAddress != IntPtr.Zero && GetController_bCreateIfNeeded_IsValid && GetController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetController", GetController_IsValid);
		GetControls_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetControlKeys");
		GetControls_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControls_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControls_bTraverse_PropertyAddress, GetControls_FunctionAddress, "bTraverse");
		GetControls_bTraverse_Offset = NativeReflectionCached.GetPropertyOffset(GetControls_FunctionAddress, "bTraverse");
		GetControls_bTraverse_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControls_FunctionAddress, "bTraverse", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetControls_ReturnValue_PropertyAddress, GetControls_FunctionAddress, "ReturnValue");
		GetControls_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControls_FunctionAddress, "ReturnValue");
		GetControls_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControls_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetControls_IsValid = GetControls_FunctionAddress != IntPtr.Zero && GetControls_bTraverse_IsValid && GetControls_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetControlKeys", GetControls_IsValid);
		GetChildren_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetChildren");
		GetChildren_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildren_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildren_InKey_PropertyAddress, GetChildren_FunctionAddress, "InKey");
		GetChildren_InKey_Offset = NativeReflectionCached.GetPropertyOffset(GetChildren_FunctionAddress, "InKey");
		GetChildren_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildren_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildren_bRecursive_PropertyAddress, GetChildren_FunctionAddress, "bRecursive");
		GetChildren_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(GetChildren_FunctionAddress, "bRecursive");
		GetChildren_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildren_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildren_ReturnValue_PropertyAddress, GetChildren_FunctionAddress, "ReturnValue");
		GetChildren_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChildren_FunctionAddress, "ReturnValue");
		GetChildren_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildren_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetChildren_IsValid = GetChildren_FunctionAddress != IntPtr.Zero && GetChildren_InKey_IsValid && GetChildren_bRecursive_IsValid && GetChildren_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetChildren", GetChildren_IsValid);
		GetBones_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoneKeys");
		GetBones_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBones_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBones_bTraverse_PropertyAddress, GetBones_FunctionAddress, "bTraverse");
		GetBones_bTraverse_Offset = NativeReflectionCached.GetPropertyOffset(GetBones_FunctionAddress, "bTraverse");
		GetBones_bTraverse_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBones_FunctionAddress, "bTraverse", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBones_ReturnValue_PropertyAddress, GetBones_FunctionAddress, "ReturnValue");
		GetBones_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBones_FunctionAddress, "ReturnValue");
		GetBones_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBones_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetBones_IsValid = GetBones_FunctionAddress != IntPtr.Zero && GetBones_bTraverse_IsValid && GetBones_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetBoneKeys", GetBones_IsValid);
		GetAllKeys_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllKeys_ForBlueprint");
		GetAllKeys_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllKeys_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllKeys_bTraverse_PropertyAddress, GetAllKeys_FunctionAddress, "bTraverse");
		GetAllKeys_bTraverse_Offset = NativeReflectionCached.GetPropertyOffset(GetAllKeys_FunctionAddress, "bTraverse");
		GetAllKeys_bTraverse_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllKeys_FunctionAddress, "bTraverse", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllKeys_ReturnValue_PropertyAddress, GetAllKeys_FunctionAddress, "ReturnValue");
		GetAllKeys_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllKeys_FunctionAddress, "ReturnValue");
		GetAllKeys_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllKeys_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllKeys_IsValid = GetAllKeys_FunctionAddress != IntPtr.Zero && GetAllKeys_bTraverse_IsValid && GetAllKeys_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:GetAllKeys_ForBlueprint", GetAllKeys_IsValid);
		FindNull_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindNull_ForBlueprintOnly");
		FindNull_ParamsSize = NativeReflection.GetFunctionParamsSize(FindNull_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindNull_InKey_PropertyAddress, FindNull_FunctionAddress, "InKey");
		FindNull_InKey_Offset = NativeReflectionCached.GetPropertyOffset(FindNull_FunctionAddress, "InKey");
		FindNull_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNull_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNull_ReturnValue_PropertyAddress, FindNull_FunctionAddress, "ReturnValue");
		FindNull_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindNull_FunctionAddress, "ReturnValue");
		FindNull_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNull_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindNull_IsValid = FindNull_FunctionAddress != IntPtr.Zero && FindNull_InKey_IsValid && FindNull_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:FindNull_ForBlueprintOnly", FindNull_IsValid);
		FindControl_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindControl_ForBlueprintOnly");
		FindControl_ParamsSize = NativeReflection.GetFunctionParamsSize(FindControl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindControl_InKey_PropertyAddress, FindControl_FunctionAddress, "InKey");
		FindControl_InKey_Offset = NativeReflectionCached.GetPropertyOffset(FindControl_FunctionAddress, "InKey");
		FindControl_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(FindControl_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindControl_ReturnValue_PropertyAddress, FindControl_FunctionAddress, "ReturnValue");
		FindControl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindControl_FunctionAddress, "ReturnValue");
		FindControl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindControl_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindControl_IsValid = FindControl_FunctionAddress != IntPtr.Zero && FindControl_InKey_IsValid && FindControl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:FindControl_ForBlueprintOnly", FindControl_IsValid);
		FindBone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindBone_ForBlueprintOnly");
		FindBone_ParamsSize = NativeReflection.GetFunctionParamsSize(FindBone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindBone_InKey_PropertyAddress, FindBone_FunctionAddress, "InKey");
		FindBone_InKey_Offset = NativeReflectionCached.GetPropertyOffset(FindBone_FunctionAddress, "InKey");
		FindBone_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBone_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindBone_ReturnValue_PropertyAddress, FindBone_FunctionAddress, "ReturnValue");
		FindBone_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindBone_FunctionAddress, "ReturnValue");
		FindBone_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindBone_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindBone_IsValid = FindBone_FunctionAddress != IntPtr.Zero && FindBone_InKey_IsValid && FindBone_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:FindBone_ForBlueprintOnly", FindBone_IsValid);
		CopyPose_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyPose");
		CopyPose_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyPose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyPose_InHierarchy_PropertyAddress, CopyPose_FunctionAddress, "InHierarchy");
		CopyPose_InHierarchy_Offset = NativeReflectionCached.GetPropertyOffset(CopyPose_FunctionAddress, "InHierarchy");
		CopyPose_InHierarchy_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPose_FunctionAddress, "InHierarchy", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPose_bCurrent_PropertyAddress, CopyPose_FunctionAddress, "bCurrent");
		CopyPose_bCurrent_Offset = NativeReflectionCached.GetPropertyOffset(CopyPose_FunctionAddress, "bCurrent");
		CopyPose_bCurrent_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPose_FunctionAddress, "bCurrent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyPose_bInitial_PropertyAddress, CopyPose_FunctionAddress, "bInitial");
		CopyPose_bInitial_Offset = NativeReflectionCached.GetPropertyOffset(CopyPose_FunctionAddress, "bInitial");
		CopyPose_bInitial_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPose_FunctionAddress, "bInitial", Classes.FBoolProperty);
		CopyPose_IsValid = CopyPose_FunctionAddress != IntPtr.Zero && CopyPose_InHierarchy_IsValid && CopyPose_bCurrent_IsValid && CopyPose_bInitial_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:CopyPose", CopyPose_IsValid);
		CopyHierarchy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyHierarchy");
		CopyHierarchy_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyHierarchy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyHierarchy_InHierarchy_PropertyAddress, CopyHierarchy_FunctionAddress, "InHierarchy");
		CopyHierarchy_InHierarchy_Offset = NativeReflectionCached.GetPropertyOffset(CopyHierarchy_FunctionAddress, "InHierarchy");
		CopyHierarchy_InHierarchy_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyHierarchy_FunctionAddress, "InHierarchy", Classes.FObjectProperty);
		CopyHierarchy_IsValid = CopyHierarchy_FunctionAddress != IntPtr.Zero && CopyHierarchy_InHierarchy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:CopyHierarchy", CopyHierarchy_IsValid);
		Contains_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Contains_ForBlueprint");
		Contains_ParamsSize = NativeReflection.GetFunctionParamsSize(Contains_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Contains_InKey_PropertyAddress, Contains_FunctionAddress, "InKey");
		Contains_InKey_Offset = NativeReflectionCached.GetPropertyOffset(Contains_FunctionAddress, "InKey");
		Contains_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(Contains_FunctionAddress, "InKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Contains_ReturnValue_PropertyAddress, Contains_FunctionAddress, "ReturnValue");
		Contains_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Contains_FunctionAddress, "ReturnValue");
		Contains_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Contains_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Contains_IsValid = Contains_FunctionAddress != IntPtr.Zero && Contains_InKey_IsValid && Contains_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.RigHierarchy:Contains_ForBlueprint", Contains_IsValid);
	}
}
