using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraDataInterfaceArrayFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetNiagaraArrayVectorValue_IsValid;

	private static IntPtr SetNiagaraArrayVectorValue_FunctionAddress;

	private static int SetNiagaraArrayVectorValue_ParamsSize;

	private static bool SetNiagaraArrayVectorValue_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayVectorValue_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayVectorValue_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayVectorValue_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayVectorValue_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayVectorValue_OverrideName_Offset;

	private static bool SetNiagaraArrayVectorValue_Index_IsValid;

	private static FFieldAddress SetNiagaraArrayVectorValue_Index_PropertyAddress;

	private static int SetNiagaraArrayVectorValue_Index_Offset;

	private static bool SetNiagaraArrayVectorValue_Value_IsValid;

	private static FFieldAddress SetNiagaraArrayVectorValue_Value_PropertyAddress;

	private static int SetNiagaraArrayVectorValue_Value_Offset;

	private static bool SetNiagaraArrayVectorValue_bSizeToFit_IsValid;

	private static FFieldAddress SetNiagaraArrayVectorValue_bSizeToFit_PropertyAddress;

	private static int SetNiagaraArrayVectorValue_bSizeToFit_Offset;

	private static bool SetNiagaraArrayVector4Value_IsValid;

	private static IntPtr SetNiagaraArrayVector4Value_FunctionAddress;

	private static int SetNiagaraArrayVector4Value_ParamsSize;

	private static bool SetNiagaraArrayVector4Value_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayVector4Value_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayVector4Value_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayVector4Value_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayVector4Value_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayVector4Value_OverrideName_Offset;

	private static bool SetNiagaraArrayVector4Value_Index_IsValid;

	private static FFieldAddress SetNiagaraArrayVector4Value_Index_PropertyAddress;

	private static int SetNiagaraArrayVector4Value_Index_Offset;

	private static bool SetNiagaraArrayVector4Value_Value_IsValid;

	private static FFieldAddress SetNiagaraArrayVector4Value_Value_PropertyAddress;

	private static int SetNiagaraArrayVector4Value_Value_Offset;

	private static bool SetNiagaraArrayVector4Value_bSizeToFit_IsValid;

	private static FFieldAddress SetNiagaraArrayVector4Value_bSizeToFit_PropertyAddress;

	private static int SetNiagaraArrayVector4Value_bSizeToFit_Offset;

	private static bool SetNiagaraArrayVector4_IsValid;

	private static IntPtr SetNiagaraArrayVector4_FunctionAddress;

	private static int SetNiagaraArrayVector4_ParamsSize;

	private static bool SetNiagaraArrayVector4_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayVector4_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayVector4_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayVector4_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayVector4_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayVector4_OverrideName_Offset;

	private static bool SetNiagaraArrayVector4_ArrayData_IsValid;

	private static FFieldAddress SetNiagaraArrayVector4_ArrayData_PropertyAddress;

	private static int SetNiagaraArrayVector4_ArrayData_Offset;

	private static bool SetNiagaraArrayVector2DValue_IsValid;

	private static IntPtr SetNiagaraArrayVector2DValue_FunctionAddress;

	private static int SetNiagaraArrayVector2DValue_ParamsSize;

	private static bool SetNiagaraArrayVector2DValue_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayVector2DValue_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayVector2DValue_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayVector2DValue_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayVector2DValue_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayVector2DValue_OverrideName_Offset;

	private static bool SetNiagaraArrayVector2DValue_Index_IsValid;

	private static FFieldAddress SetNiagaraArrayVector2DValue_Index_PropertyAddress;

	private static int SetNiagaraArrayVector2DValue_Index_Offset;

	private static bool SetNiagaraArrayVector2DValue_Value_IsValid;

	private static FFieldAddress SetNiagaraArrayVector2DValue_Value_PropertyAddress;

	private static int SetNiagaraArrayVector2DValue_Value_Offset;

	private static bool SetNiagaraArrayVector2DValue_bSizeToFit_IsValid;

	private static FFieldAddress SetNiagaraArrayVector2DValue_bSizeToFit_PropertyAddress;

	private static int SetNiagaraArrayVector2DValue_bSizeToFit_Offset;

	private static bool SetNiagaraArrayVector2D_IsValid;

	private static IntPtr SetNiagaraArrayVector2D_FunctionAddress;

	private static int SetNiagaraArrayVector2D_ParamsSize;

	private static bool SetNiagaraArrayVector2D_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayVector2D_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayVector2D_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayVector2D_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayVector2D_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayVector2D_OverrideName_Offset;

	private static bool SetNiagaraArrayVector2D_ArrayData_IsValid;

	private static FFieldAddress SetNiagaraArrayVector2D_ArrayData_PropertyAddress;

	private static int SetNiagaraArrayVector2D_ArrayData_Offset;

	private static bool SetNiagaraArrayVector_IsValid;

	private static IntPtr SetNiagaraArrayVector_FunctionAddress;

	private static int SetNiagaraArrayVector_ParamsSize;

	private static bool SetNiagaraArrayVector_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayVector_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayVector_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayVector_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayVector_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayVector_OverrideName_Offset;

	private static bool SetNiagaraArrayVector_ArrayData_IsValid;

	private static FFieldAddress SetNiagaraArrayVector_ArrayData_PropertyAddress;

	private static int SetNiagaraArrayVector_ArrayData_Offset;

	private static bool SetNiagaraArrayQuatValue_IsValid;

	private static IntPtr SetNiagaraArrayQuatValue_FunctionAddress;

	private static int SetNiagaraArrayQuatValue_ParamsSize;

	private static bool SetNiagaraArrayQuatValue_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayQuatValue_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayQuatValue_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayQuatValue_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayQuatValue_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayQuatValue_OverrideName_Offset;

	private static bool SetNiagaraArrayQuatValue_Index_IsValid;

	private static FFieldAddress SetNiagaraArrayQuatValue_Index_PropertyAddress;

	private static int SetNiagaraArrayQuatValue_Index_Offset;

	private static bool SetNiagaraArrayQuatValue_Value_IsValid;

	private static FFieldAddress SetNiagaraArrayQuatValue_Value_PropertyAddress;

	private static int SetNiagaraArrayQuatValue_Value_Offset;

	private static bool SetNiagaraArrayQuatValue_bSizeToFit_IsValid;

	private static FFieldAddress SetNiagaraArrayQuatValue_bSizeToFit_PropertyAddress;

	private static int SetNiagaraArrayQuatValue_bSizeToFit_Offset;

	private static bool SetNiagaraArrayQuat_IsValid;

	private static IntPtr SetNiagaraArrayQuat_FunctionAddress;

	private static int SetNiagaraArrayQuat_ParamsSize;

	private static bool SetNiagaraArrayQuat_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayQuat_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayQuat_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayQuat_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayQuat_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayQuat_OverrideName_Offset;

	private static bool SetNiagaraArrayQuat_ArrayData_IsValid;

	private static FFieldAddress SetNiagaraArrayQuat_ArrayData_PropertyAddress;

	private static int SetNiagaraArrayQuat_ArrayData_Offset;

	private static bool SetNiagaraArrayPositionValue_IsValid;

	private static IntPtr SetNiagaraArrayPositionValue_FunctionAddress;

	private static int SetNiagaraArrayPositionValue_ParamsSize;

	private static bool SetNiagaraArrayPositionValue_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayPositionValue_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayPositionValue_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayPositionValue_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayPositionValue_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayPositionValue_OverrideName_Offset;

	private static bool SetNiagaraArrayPositionValue_Index_IsValid;

	private static FFieldAddress SetNiagaraArrayPositionValue_Index_PropertyAddress;

	private static int SetNiagaraArrayPositionValue_Index_Offset;

	private static bool SetNiagaraArrayPositionValue_Value_IsValid;

	private static FFieldAddress SetNiagaraArrayPositionValue_Value_PropertyAddress;

	private static int SetNiagaraArrayPositionValue_Value_Offset;

	private static bool SetNiagaraArrayPositionValue_bSizeToFit_IsValid;

	private static FFieldAddress SetNiagaraArrayPositionValue_bSizeToFit_PropertyAddress;

	private static int SetNiagaraArrayPositionValue_bSizeToFit_Offset;

	private static bool SetNiagaraArrayPosition_IsValid;

	private static IntPtr SetNiagaraArrayPosition_FunctionAddress;

	private static int SetNiagaraArrayPosition_ParamsSize;

	private static bool SetNiagaraArrayPosition_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayPosition_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayPosition_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayPosition_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayPosition_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayPosition_OverrideName_Offset;

	private static bool SetNiagaraArrayPosition_ArrayData_IsValid;

	private static FFieldAddress SetNiagaraArrayPosition_ArrayData_PropertyAddress;

	private static int SetNiagaraArrayPosition_ArrayData_Offset;

	private static bool SetNiagaraArrayInt32Value_IsValid;

	private static IntPtr SetNiagaraArrayInt32Value_FunctionAddress;

	private static int SetNiagaraArrayInt32Value_ParamsSize;

	private static bool SetNiagaraArrayInt32Value_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayInt32Value_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayInt32Value_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayInt32Value_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayInt32Value_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayInt32Value_OverrideName_Offset;

	private static bool SetNiagaraArrayInt32Value_Index_IsValid;

	private static FFieldAddress SetNiagaraArrayInt32Value_Index_PropertyAddress;

	private static int SetNiagaraArrayInt32Value_Index_Offset;

	private static bool SetNiagaraArrayInt32Value_Value_IsValid;

	private static FFieldAddress SetNiagaraArrayInt32Value_Value_PropertyAddress;

	private static int SetNiagaraArrayInt32Value_Value_Offset;

	private static bool SetNiagaraArrayInt32Value_bSizeToFit_IsValid;

	private static FFieldAddress SetNiagaraArrayInt32Value_bSizeToFit_PropertyAddress;

	private static int SetNiagaraArrayInt32Value_bSizeToFit_Offset;

	private static bool SetNiagaraArrayInt32_IsValid;

	private static IntPtr SetNiagaraArrayInt32_FunctionAddress;

	private static int SetNiagaraArrayInt32_ParamsSize;

	private static bool SetNiagaraArrayInt32_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayInt32_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayInt32_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayInt32_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayInt32_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayInt32_OverrideName_Offset;

	private static bool SetNiagaraArrayInt32_ArrayData_IsValid;

	private static FFieldAddress SetNiagaraArrayInt32_ArrayData_PropertyAddress;

	private static int SetNiagaraArrayInt32_ArrayData_Offset;

	private static bool SetNiagaraArrayFloatValue_IsValid;

	private static IntPtr SetNiagaraArrayFloatValue_FunctionAddress;

	private static int SetNiagaraArrayFloatValue_ParamsSize;

	private static bool SetNiagaraArrayFloatValue_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayFloatValue_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayFloatValue_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayFloatValue_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayFloatValue_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayFloatValue_OverrideName_Offset;

	private static bool SetNiagaraArrayFloatValue_Index_IsValid;

	private static FFieldAddress SetNiagaraArrayFloatValue_Index_PropertyAddress;

	private static int SetNiagaraArrayFloatValue_Index_Offset;

	private static bool SetNiagaraArrayFloatValue_Value_IsValid;

	private static FFieldAddress SetNiagaraArrayFloatValue_Value_PropertyAddress;

	private static int SetNiagaraArrayFloatValue_Value_Offset;

	private static bool SetNiagaraArrayFloatValue_bSizeToFit_IsValid;

	private static FFieldAddress SetNiagaraArrayFloatValue_bSizeToFit_PropertyAddress;

	private static int SetNiagaraArrayFloatValue_bSizeToFit_Offset;

	private static bool SetNiagaraArrayFloat_IsValid;

	private static IntPtr SetNiagaraArrayFloat_FunctionAddress;

	private static int SetNiagaraArrayFloat_ParamsSize;

	private static bool SetNiagaraArrayFloat_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayFloat_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayFloat_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayFloat_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayFloat_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayFloat_OverrideName_Offset;

	private static bool SetNiagaraArrayFloat_ArrayData_IsValid;

	private static FFieldAddress SetNiagaraArrayFloat_ArrayData_PropertyAddress;

	private static int SetNiagaraArrayFloat_ArrayData_Offset;

	private static bool SetNiagaraArrayColorValue_IsValid;

	private static IntPtr SetNiagaraArrayColorValue_FunctionAddress;

	private static int SetNiagaraArrayColorValue_ParamsSize;

	private static bool SetNiagaraArrayColorValue_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayColorValue_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayColorValue_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayColorValue_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayColorValue_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayColorValue_OverrideName_Offset;

	private static bool SetNiagaraArrayColorValue_Index_IsValid;

	private static FFieldAddress SetNiagaraArrayColorValue_Index_PropertyAddress;

	private static int SetNiagaraArrayColorValue_Index_Offset;

	private static bool SetNiagaraArrayColorValue_Value_IsValid;

	private static FFieldAddress SetNiagaraArrayColorValue_Value_PropertyAddress;

	private static int SetNiagaraArrayColorValue_Value_Offset;

	private static bool SetNiagaraArrayColorValue_bSizeToFit_IsValid;

	private static FFieldAddress SetNiagaraArrayColorValue_bSizeToFit_PropertyAddress;

	private static int SetNiagaraArrayColorValue_bSizeToFit_Offset;

	private static bool SetNiagaraArrayColor_IsValid;

	private static IntPtr SetNiagaraArrayColor_FunctionAddress;

	private static int SetNiagaraArrayColor_ParamsSize;

	private static bool SetNiagaraArrayColor_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayColor_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayColor_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayColor_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayColor_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayColor_OverrideName_Offset;

	private static bool SetNiagaraArrayColor_ArrayData_IsValid;

	private static FFieldAddress SetNiagaraArrayColor_ArrayData_PropertyAddress;

	private static int SetNiagaraArrayColor_ArrayData_Offset;

	private static bool SetNiagaraArrayBoolValue_IsValid;

	private static IntPtr SetNiagaraArrayBoolValue_FunctionAddress;

	private static int SetNiagaraArrayBoolValue_ParamsSize;

	private static bool SetNiagaraArrayBoolValue_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayBoolValue_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayBoolValue_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayBoolValue_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayBoolValue_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayBoolValue_OverrideName_Offset;

	private static bool SetNiagaraArrayBoolValue_Index_IsValid;

	private static FFieldAddress SetNiagaraArrayBoolValue_Index_PropertyAddress;

	private static int SetNiagaraArrayBoolValue_Index_Offset;

	private static bool SetNiagaraArrayBoolValue_Value_IsValid;

	private static FFieldAddress SetNiagaraArrayBoolValue_Value_PropertyAddress;

	private static int SetNiagaraArrayBoolValue_Value_Offset;

	private static bool SetNiagaraArrayBoolValue_bSizeToFit_IsValid;

	private static FFieldAddress SetNiagaraArrayBoolValue_bSizeToFit_PropertyAddress;

	private static int SetNiagaraArrayBoolValue_bSizeToFit_Offset;

	private static bool SetNiagaraArrayBool_IsValid;

	private static IntPtr SetNiagaraArrayBool_FunctionAddress;

	private static int SetNiagaraArrayBool_ParamsSize;

	private static bool SetNiagaraArrayBool_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraArrayBool_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraArrayBool_NiagaraSystem_Offset;

	private static bool SetNiagaraArrayBool_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraArrayBool_OverrideName_PropertyAddress;

	private static int SetNiagaraArrayBool_OverrideName_Offset;

	private static bool SetNiagaraArrayBool_ArrayData_IsValid;

	private static FFieldAddress SetNiagaraArrayBool_ArrayData_PropertyAddress;

	private static int SetNiagaraArrayBool_ArrayData_Offset;

	private static bool GetNiagaraArrayVectorValue_IsValid;

	private static IntPtr GetNiagaraArrayVectorValue_FunctionAddress;

	private static int GetNiagaraArrayVectorValue_ParamsSize;

	private static bool GetNiagaraArrayVectorValue_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayVectorValue_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayVectorValue_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayVectorValue_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayVectorValue_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayVectorValue_OverrideName_Offset;

	private static bool GetNiagaraArrayVectorValue_Index_IsValid;

	private static FFieldAddress GetNiagaraArrayVectorValue_Index_PropertyAddress;

	private static int GetNiagaraArrayVectorValue_Index_Offset;

	private static bool GetNiagaraArrayVectorValue_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayVectorValue_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayVectorValue_ReturnValue_Offset;

	private static bool GetNiagaraArrayVector4Value_IsValid;

	private static IntPtr GetNiagaraArrayVector4Value_FunctionAddress;

	private static int GetNiagaraArrayVector4Value_ParamsSize;

	private static bool GetNiagaraArrayVector4Value_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayVector4Value_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayVector4Value_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayVector4Value_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayVector4Value_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayVector4Value_OverrideName_Offset;

	private static bool GetNiagaraArrayVector4Value_Index_IsValid;

	private static FFieldAddress GetNiagaraArrayVector4Value_Index_PropertyAddress;

	private static int GetNiagaraArrayVector4Value_Index_Offset;

	private static bool GetNiagaraArrayVector4Value_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayVector4Value_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayVector4Value_ReturnValue_Offset;

	private static bool GetNiagaraArrayVector4_IsValid;

	private static IntPtr GetNiagaraArrayVector4_FunctionAddress;

	private static int GetNiagaraArrayVector4_ParamsSize;

	private static bool GetNiagaraArrayVector4_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayVector4_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayVector4_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayVector4_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayVector4_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayVector4_OverrideName_Offset;

	private static bool GetNiagaraArrayVector4_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayVector4_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayVector4_ReturnValue_Offset;

	private static bool GetNiagaraArrayVector2DValue_IsValid;

	private static IntPtr GetNiagaraArrayVector2DValue_FunctionAddress;

	private static int GetNiagaraArrayVector2DValue_ParamsSize;

	private static bool GetNiagaraArrayVector2DValue_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayVector2DValue_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayVector2DValue_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayVector2DValue_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayVector2DValue_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayVector2DValue_OverrideName_Offset;

	private static bool GetNiagaraArrayVector2DValue_Index_IsValid;

	private static FFieldAddress GetNiagaraArrayVector2DValue_Index_PropertyAddress;

	private static int GetNiagaraArrayVector2DValue_Index_Offset;

	private static bool GetNiagaraArrayVector2DValue_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayVector2DValue_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayVector2DValue_ReturnValue_Offset;

	private static bool GetNiagaraArrayVector2D_IsValid;

	private static IntPtr GetNiagaraArrayVector2D_FunctionAddress;

	private static int GetNiagaraArrayVector2D_ParamsSize;

	private static bool GetNiagaraArrayVector2D_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayVector2D_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayVector2D_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayVector2D_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayVector2D_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayVector2D_OverrideName_Offset;

	private static bool GetNiagaraArrayVector2D_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayVector2D_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayVector2D_ReturnValue_Offset;

	private static bool GetNiagaraArrayVector_IsValid;

	private static IntPtr GetNiagaraArrayVector_FunctionAddress;

	private static int GetNiagaraArrayVector_ParamsSize;

	private static bool GetNiagaraArrayVector_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayVector_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayVector_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayVector_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayVector_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayVector_OverrideName_Offset;

	private static bool GetNiagaraArrayVector_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayVector_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayVector_ReturnValue_Offset;

	private static bool GetNiagaraArrayQuatValue_IsValid;

	private static IntPtr GetNiagaraArrayQuatValue_FunctionAddress;

	private static int GetNiagaraArrayQuatValue_ParamsSize;

	private static bool GetNiagaraArrayQuatValue_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayQuatValue_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayQuatValue_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayQuatValue_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayQuatValue_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayQuatValue_OverrideName_Offset;

	private static bool GetNiagaraArrayQuatValue_Index_IsValid;

	private static FFieldAddress GetNiagaraArrayQuatValue_Index_PropertyAddress;

	private static int GetNiagaraArrayQuatValue_Index_Offset;

	private static bool GetNiagaraArrayQuatValue_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayQuatValue_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayQuatValue_ReturnValue_Offset;

	private static bool GetNiagaraArrayQuat_IsValid;

	private static IntPtr GetNiagaraArrayQuat_FunctionAddress;

	private static int GetNiagaraArrayQuat_ParamsSize;

	private static bool GetNiagaraArrayQuat_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayQuat_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayQuat_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayQuat_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayQuat_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayQuat_OverrideName_Offset;

	private static bool GetNiagaraArrayQuat_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayQuat_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayQuat_ReturnValue_Offset;

	private static bool GetNiagaraArrayPositionValue_IsValid;

	private static IntPtr GetNiagaraArrayPositionValue_FunctionAddress;

	private static int GetNiagaraArrayPositionValue_ParamsSize;

	private static bool GetNiagaraArrayPositionValue_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayPositionValue_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayPositionValue_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayPositionValue_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayPositionValue_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayPositionValue_OverrideName_Offset;

	private static bool GetNiagaraArrayPositionValue_Index_IsValid;

	private static FFieldAddress GetNiagaraArrayPositionValue_Index_PropertyAddress;

	private static int GetNiagaraArrayPositionValue_Index_Offset;

	private static bool GetNiagaraArrayPositionValue_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayPositionValue_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayPositionValue_ReturnValue_Offset;

	private static bool GetNiagaraArrayPosition_IsValid;

	private static IntPtr GetNiagaraArrayPosition_FunctionAddress;

	private static int GetNiagaraArrayPosition_ParamsSize;

	private static bool GetNiagaraArrayPosition_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayPosition_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayPosition_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayPosition_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayPosition_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayPosition_OverrideName_Offset;

	private static bool GetNiagaraArrayPosition_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayPosition_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayPosition_ReturnValue_Offset;

	private static bool GetNiagaraArrayInt32Value_IsValid;

	private static IntPtr GetNiagaraArrayInt32Value_FunctionAddress;

	private static int GetNiagaraArrayInt32Value_ParamsSize;

	private static bool GetNiagaraArrayInt32Value_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayInt32Value_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayInt32Value_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayInt32Value_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayInt32Value_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayInt32Value_OverrideName_Offset;

	private static bool GetNiagaraArrayInt32Value_Index_IsValid;

	private static FFieldAddress GetNiagaraArrayInt32Value_Index_PropertyAddress;

	private static int GetNiagaraArrayInt32Value_Index_Offset;

	private static bool GetNiagaraArrayInt32Value_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayInt32Value_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayInt32Value_ReturnValue_Offset;

	private static bool GetNiagaraArrayInt32_IsValid;

	private static IntPtr GetNiagaraArrayInt32_FunctionAddress;

	private static int GetNiagaraArrayInt32_ParamsSize;

	private static bool GetNiagaraArrayInt32_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayInt32_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayInt32_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayInt32_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayInt32_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayInt32_OverrideName_Offset;

	private static bool GetNiagaraArrayInt32_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayInt32_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayInt32_ReturnValue_Offset;

	private static bool GetNiagaraArrayFloatValue_IsValid;

	private static IntPtr GetNiagaraArrayFloatValue_FunctionAddress;

	private static int GetNiagaraArrayFloatValue_ParamsSize;

	private static bool GetNiagaraArrayFloatValue_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayFloatValue_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayFloatValue_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayFloatValue_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayFloatValue_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayFloatValue_OverrideName_Offset;

	private static bool GetNiagaraArrayFloatValue_Index_IsValid;

	private static FFieldAddress GetNiagaraArrayFloatValue_Index_PropertyAddress;

	private static int GetNiagaraArrayFloatValue_Index_Offset;

	private static bool GetNiagaraArrayFloatValue_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayFloatValue_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayFloatValue_ReturnValue_Offset;

	private static bool GetNiagaraArrayFloat_IsValid;

	private static IntPtr GetNiagaraArrayFloat_FunctionAddress;

	private static int GetNiagaraArrayFloat_ParamsSize;

	private static bool GetNiagaraArrayFloat_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayFloat_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayFloat_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayFloat_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayFloat_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayFloat_OverrideName_Offset;

	private static bool GetNiagaraArrayFloat_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayFloat_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayFloat_ReturnValue_Offset;

	private static bool GetNiagaraArrayColorValue_IsValid;

	private static IntPtr GetNiagaraArrayColorValue_FunctionAddress;

	private static int GetNiagaraArrayColorValue_ParamsSize;

	private static bool GetNiagaraArrayColorValue_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayColorValue_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayColorValue_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayColorValue_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayColorValue_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayColorValue_OverrideName_Offset;

	private static bool GetNiagaraArrayColorValue_Index_IsValid;

	private static FFieldAddress GetNiagaraArrayColorValue_Index_PropertyAddress;

	private static int GetNiagaraArrayColorValue_Index_Offset;

	private static bool GetNiagaraArrayColorValue_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayColorValue_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayColorValue_ReturnValue_Offset;

	private static bool GetNiagaraArrayColor_IsValid;

	private static IntPtr GetNiagaraArrayColor_FunctionAddress;

	private static int GetNiagaraArrayColor_ParamsSize;

	private static bool GetNiagaraArrayColor_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayColor_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayColor_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayColor_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayColor_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayColor_OverrideName_Offset;

	private static bool GetNiagaraArrayColor_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayColor_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayColor_ReturnValue_Offset;

	private static bool GetNiagaraArrayBoolValue_IsValid;

	private static IntPtr GetNiagaraArrayBoolValue_FunctionAddress;

	private static int GetNiagaraArrayBoolValue_ParamsSize;

	private static bool GetNiagaraArrayBoolValue_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayBoolValue_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayBoolValue_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayBoolValue_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayBoolValue_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayBoolValue_OverrideName_Offset;

	private static bool GetNiagaraArrayBoolValue_Index_IsValid;

	private static FFieldAddress GetNiagaraArrayBoolValue_Index_PropertyAddress;

	private static int GetNiagaraArrayBoolValue_Index_Offset;

	private static bool GetNiagaraArrayBoolValue_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayBoolValue_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayBoolValue_ReturnValue_Offset;

	private static bool GetNiagaraArrayBool_IsValid;

	private static IntPtr GetNiagaraArrayBool_FunctionAddress;

	private static int GetNiagaraArrayBool_ParamsSize;

	private static bool GetNiagaraArrayBool_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraArrayBool_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraArrayBool_NiagaraSystem_Offset;

	private static bool GetNiagaraArrayBool_OverrideName_IsValid;

	private static FFieldAddress GetNiagaraArrayBool_OverrideName_PropertyAddress;

	private static int GetNiagaraArrayBool_OverrideName_Offset;

	private static bool GetNiagaraArrayBool_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraArrayBool_ReturnValue_PropertyAddress;

	private static int GetNiagaraArrayBool_ReturnValue_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVectorValue")]
	public unsafe static void SetNiagaraArrayVectorValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, FVector Value, bool bSizeToFit)
	{
		if (!SetNiagaraArrayVectorValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVectorValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayVectorValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayVectorValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVectorValue_NiagaraSystem_Offset), 0, SetNiagaraArrayVectorValue_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVectorValue_OverrideName_Offset), 0, SetNiagaraArrayVectorValue_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVectorValue_Index_Offset), 0, SetNiagaraArrayVectorValue_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVectorValue_Value_Offset), 0, SetNiagaraArrayVectorValue_Value_PropertyAddress.Address, Value);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVectorValue_bSizeToFit_Offset), 0, SetNiagaraArrayVectorValue_bSizeToFit_PropertyAddress.Address, bSizeToFit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayVectorValue_FunctionAddress, intPtr, SetNiagaraArrayVectorValue_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector4Value")]
	public unsafe static void SetNiagaraArrayVector4Value(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, FVector4 Value, bool bSizeToFit)
	{
		if (!SetNiagaraArrayVector4Value_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector4Value");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayVector4Value_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayVector4Value_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector4Value_NiagaraSystem_Offset), 0, SetNiagaraArrayVector4Value_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector4Value_OverrideName_Offset), 0, SetNiagaraArrayVector4Value_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector4Value_Index_Offset), 0, SetNiagaraArrayVector4Value_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector4Value_Value_Offset), 0, SetNiagaraArrayVector4Value_Value_PropertyAddress.Address, Value);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector4Value_bSizeToFit_Offset), 0, SetNiagaraArrayVector4Value_bSizeToFit_PropertyAddress.Address, bSizeToFit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayVector4Value_FunctionAddress, intPtr, SetNiagaraArrayVector4Value_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector4")]
	public unsafe static void SetNiagaraArrayVector4(UNiagaraComponent NiagaraSystem, FName OverrideName, List<FVector4> ArrayData)
	{
		if (!SetNiagaraArrayVector4_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector4");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayVector4_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayVector4_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector4_NiagaraSystem_Offset), 0, SetNiagaraArrayVector4_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector4_OverrideName_Offset), 0, SetNiagaraArrayVector4_OverrideName_PropertyAddress.Address, OverrideName);
		new TArrayCopyMarshaler<FVector4>(1, SetNiagaraArrayVector4_ArrayData_PropertyAddress, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.FromNative, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.ToNative).ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector4_ArrayData_Offset), ArrayData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayVector4_FunctionAddress, intPtr, SetNiagaraArrayVector4_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraArrayVector4_ArrayData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector2DValue")]
	public unsafe static void SetNiagaraArrayVector2DValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, FVector2D Value, bool bSizeToFit)
	{
		if (!SetNiagaraArrayVector2DValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector2DValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayVector2DValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayVector2DValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector2DValue_NiagaraSystem_Offset), 0, SetNiagaraArrayVector2DValue_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector2DValue_OverrideName_Offset), 0, SetNiagaraArrayVector2DValue_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector2DValue_Index_Offset), 0, SetNiagaraArrayVector2DValue_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector2DValue_Value_Offset), 0, SetNiagaraArrayVector2DValue_Value_PropertyAddress.Address, Value);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector2DValue_bSizeToFit_Offset), 0, SetNiagaraArrayVector2DValue_bSizeToFit_PropertyAddress.Address, bSizeToFit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayVector2DValue_FunctionAddress, intPtr, SetNiagaraArrayVector2DValue_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector2D")]
	public unsafe static void SetNiagaraArrayVector2D(UNiagaraComponent NiagaraSystem, FName OverrideName, List<FVector2D> ArrayData)
	{
		if (!SetNiagaraArrayVector2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector2D");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayVector2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayVector2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector2D_NiagaraSystem_Offset), 0, SetNiagaraArrayVector2D_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector2D_OverrideName_Offset), 0, SetNiagaraArrayVector2D_OverrideName_PropertyAddress.Address, OverrideName);
		new TArrayCopyMarshaler<FVector2D>(1, SetNiagaraArrayVector2D_ArrayData_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector2D_ArrayData_Offset), ArrayData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayVector2D_FunctionAddress, intPtr, SetNiagaraArrayVector2D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraArrayVector2D_ArrayData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector")]
	public unsafe static void SetNiagaraArrayVector(UNiagaraComponent NiagaraSystem, FName OverrideName, List<FVector> ArrayData)
	{
		if (!SetNiagaraArrayVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector_NiagaraSystem_Offset), 0, SetNiagaraArrayVector_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector_OverrideName_Offset), 0, SetNiagaraArrayVector_OverrideName_PropertyAddress.Address, OverrideName);
		new TArrayCopyMarshaler<FVector>(1, SetNiagaraArrayVector_ArrayData_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, SetNiagaraArrayVector_ArrayData_Offset), ArrayData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayVector_FunctionAddress, intPtr, SetNiagaraArrayVector_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraArrayVector_ArrayData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayQuatValue")]
	public unsafe static void SetNiagaraArrayQuatValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, FQuat Value, bool bSizeToFit)
	{
		if (!SetNiagaraArrayQuatValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayQuatValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayQuatValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayQuatValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayQuatValue_NiagaraSystem_Offset), 0, SetNiagaraArrayQuatValue_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayQuatValue_OverrideName_Offset), 0, SetNiagaraArrayQuatValue_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayQuatValue_Index_Offset), 0, SetNiagaraArrayQuatValue_Index_PropertyAddress.Address, Index);
		NativeReflection.InitializeValue_InContainer(SetNiagaraArrayQuatValue_Value_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayQuatValue_Value_Offset), 0, SetNiagaraArrayQuatValue_Value_PropertyAddress.Address, Value);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayQuatValue_bSizeToFit_Offset), 0, SetNiagaraArrayQuatValue_bSizeToFit_PropertyAddress.Address, bSizeToFit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayQuatValue_FunctionAddress, intPtr, SetNiagaraArrayQuatValue_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayQuat")]
	public unsafe static void SetNiagaraArrayQuat(UNiagaraComponent NiagaraSystem, FName OverrideName, List<FQuat> ArrayData)
	{
		if (!SetNiagaraArrayQuat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayQuat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayQuat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayQuat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayQuat_NiagaraSystem_Offset), 0, SetNiagaraArrayQuat_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayQuat_OverrideName_Offset), 0, SetNiagaraArrayQuat_OverrideName_PropertyAddress.Address, OverrideName);
		new TArrayCopyMarshaler<FQuat>(1, SetNiagaraArrayQuat_ArrayData_PropertyAddress, CachedMarshalingDelegates<FQuat, BlittableTypeMarshaler<FQuat>>.FromNative, CachedMarshalingDelegates<FQuat, BlittableTypeMarshaler<FQuat>>.ToNative).ToNative(IntPtr.Add(intPtr, SetNiagaraArrayQuat_ArrayData_Offset), ArrayData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayQuat_FunctionAddress, intPtr, SetNiagaraArrayQuat_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraArrayQuat_ArrayData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayPositionValue")]
	public unsafe static void SetNiagaraArrayPositionValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, FVector Value, bool bSizeToFit)
	{
		if (!SetNiagaraArrayPositionValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayPositionValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayPositionValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayPositionValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayPositionValue_NiagaraSystem_Offset), 0, SetNiagaraArrayPositionValue_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayPositionValue_OverrideName_Offset), 0, SetNiagaraArrayPositionValue_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayPositionValue_Index_Offset), 0, SetNiagaraArrayPositionValue_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayPositionValue_Value_Offset), 0, SetNiagaraArrayPositionValue_Value_PropertyAddress.Address, Value);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayPositionValue_bSizeToFit_Offset), 0, SetNiagaraArrayPositionValue_bSizeToFit_PropertyAddress.Address, bSizeToFit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayPositionValue_FunctionAddress, intPtr, SetNiagaraArrayPositionValue_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayPosition")]
	public unsafe static void SetNiagaraArrayPosition(UNiagaraComponent NiagaraSystem, FName OverrideName, List<FVector> ArrayData)
	{
		if (!SetNiagaraArrayPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayPosition_NiagaraSystem_Offset), 0, SetNiagaraArrayPosition_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayPosition_OverrideName_Offset), 0, SetNiagaraArrayPosition_OverrideName_PropertyAddress.Address, OverrideName);
		new TArrayCopyMarshaler<FVector>(1, SetNiagaraArrayPosition_ArrayData_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, SetNiagaraArrayPosition_ArrayData_Offset), ArrayData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayPosition_FunctionAddress, intPtr, SetNiagaraArrayPosition_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraArrayPosition_ArrayData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayInt32Value")]
	public unsafe static void SetNiagaraArrayInt32Value(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, int Value, bool bSizeToFit)
	{
		if (!SetNiagaraArrayInt32Value_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayInt32Value");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayInt32Value_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayInt32Value_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayInt32Value_NiagaraSystem_Offset), 0, SetNiagaraArrayInt32Value_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayInt32Value_OverrideName_Offset), 0, SetNiagaraArrayInt32Value_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayInt32Value_Index_Offset), 0, SetNiagaraArrayInt32Value_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayInt32Value_Value_Offset), 0, SetNiagaraArrayInt32Value_Value_PropertyAddress.Address, Value);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayInt32Value_bSizeToFit_Offset), 0, SetNiagaraArrayInt32Value_bSizeToFit_PropertyAddress.Address, bSizeToFit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayInt32Value_FunctionAddress, intPtr, SetNiagaraArrayInt32Value_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayInt32")]
	public unsafe static void SetNiagaraArrayInt32(UNiagaraComponent NiagaraSystem, FName OverrideName, List<int> ArrayData)
	{
		if (!SetNiagaraArrayInt32_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayInt32");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayInt32_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayInt32_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayInt32_NiagaraSystem_Offset), 0, SetNiagaraArrayInt32_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayInt32_OverrideName_Offset), 0, SetNiagaraArrayInt32_OverrideName_PropertyAddress.Address, OverrideName);
		new TArrayCopyMarshaler<int>(1, SetNiagaraArrayInt32_ArrayData_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, SetNiagaraArrayInt32_ArrayData_Offset), ArrayData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayInt32_FunctionAddress, intPtr, SetNiagaraArrayInt32_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraArrayInt32_ArrayData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayFloatValue")]
	public unsafe static void SetNiagaraArrayFloatValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, float Value, bool bSizeToFit)
	{
		if (!SetNiagaraArrayFloatValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayFloatValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayFloatValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayFloatValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayFloatValue_NiagaraSystem_Offset), 0, SetNiagaraArrayFloatValue_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayFloatValue_OverrideName_Offset), 0, SetNiagaraArrayFloatValue_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayFloatValue_Index_Offset), 0, SetNiagaraArrayFloatValue_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayFloatValue_Value_Offset), 0, SetNiagaraArrayFloatValue_Value_PropertyAddress.Address, Value);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayFloatValue_bSizeToFit_Offset), 0, SetNiagaraArrayFloatValue_bSizeToFit_PropertyAddress.Address, bSizeToFit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayFloatValue_FunctionAddress, intPtr, SetNiagaraArrayFloatValue_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayFloat")]
	public unsafe static void SetNiagaraArrayFloat(UNiagaraComponent NiagaraSystem, FName OverrideName, List<float> ArrayData)
	{
		if (!SetNiagaraArrayFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayFloat_NiagaraSystem_Offset), 0, SetNiagaraArrayFloat_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayFloat_OverrideName_Offset), 0, SetNiagaraArrayFloat_OverrideName_PropertyAddress.Address, OverrideName);
		new TArrayCopyMarshaler<float>(1, SetNiagaraArrayFloat_ArrayData_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, SetNiagaraArrayFloat_ArrayData_Offset), ArrayData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayFloat_FunctionAddress, intPtr, SetNiagaraArrayFloat_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraArrayFloat_ArrayData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayColorValue")]
	public unsafe static void SetNiagaraArrayColorValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, FLinearColor Value, bool bSizeToFit)
	{
		if (!SetNiagaraArrayColorValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayColorValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayColorValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayColorValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayColorValue_NiagaraSystem_Offset), 0, SetNiagaraArrayColorValue_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayColorValue_OverrideName_Offset), 0, SetNiagaraArrayColorValue_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayColorValue_Index_Offset), 0, SetNiagaraArrayColorValue_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayColorValue_Value_Offset), 0, SetNiagaraArrayColorValue_Value_PropertyAddress.Address, Value);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayColorValue_bSizeToFit_Offset), 0, SetNiagaraArrayColorValue_bSizeToFit_PropertyAddress.Address, bSizeToFit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayColorValue_FunctionAddress, intPtr, SetNiagaraArrayColorValue_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayColor")]
	public unsafe static void SetNiagaraArrayColor(UNiagaraComponent NiagaraSystem, FName OverrideName, List<FLinearColor> ArrayData)
	{
		if (!SetNiagaraArrayColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayColor_NiagaraSystem_Offset), 0, SetNiagaraArrayColor_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayColor_OverrideName_Offset), 0, SetNiagaraArrayColor_OverrideName_PropertyAddress.Address, OverrideName);
		new TArrayCopyMarshaler<FLinearColor>(1, SetNiagaraArrayColor_ArrayData_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).ToNative(IntPtr.Add(intPtr, SetNiagaraArrayColor_ArrayData_Offset), ArrayData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayColor_FunctionAddress, intPtr, SetNiagaraArrayColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraArrayColor_ArrayData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayBoolValue")]
	public unsafe static void SetNiagaraArrayBoolValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, bool Value, bool bSizeToFit)
	{
		if (!SetNiagaraArrayBoolValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayBoolValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayBoolValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayBoolValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayBoolValue_NiagaraSystem_Offset), 0, SetNiagaraArrayBoolValue_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayBoolValue_OverrideName_Offset), 0, SetNiagaraArrayBoolValue_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayBoolValue_Index_Offset), 0, SetNiagaraArrayBoolValue_Index_PropertyAddress.Address, Index);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayBoolValue_Value_Offset), 0, SetNiagaraArrayBoolValue_Value_PropertyAddress.Address, Value);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayBoolValue_bSizeToFit_Offset), 0, SetNiagaraArrayBoolValue_bSizeToFit_PropertyAddress.Address, bSizeToFit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayBoolValue_FunctionAddress, intPtr, SetNiagaraArrayBoolValue_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayBool")]
	public unsafe static void SetNiagaraArrayBool(UNiagaraComponent NiagaraSystem, FName OverrideName, List<bool> ArrayData)
	{
		if (!SetNiagaraArrayBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayBool");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraArrayBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraArrayBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayBool_NiagaraSystem_Offset), 0, SetNiagaraArrayBool_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraArrayBool_OverrideName_Offset), 0, SetNiagaraArrayBool_OverrideName_PropertyAddress.Address, OverrideName);
		new TArrayCopyMarshaler<bool>(1, SetNiagaraArrayBool_ArrayData_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetNiagaraArrayBool_ArrayData_Offset), ArrayData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraArrayBool_FunctionAddress, intPtr, SetNiagaraArrayBool_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraArrayBool_ArrayData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVectorValue")]
	public unsafe static FVector GetNiagaraArrayVectorValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
	{
		if (!GetNiagaraArrayVectorValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVectorValue");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayVectorValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayVectorValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVectorValue_NiagaraSystem_Offset), 0, GetNiagaraArrayVectorValue_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVectorValue_OverrideName_Offset), 0, GetNiagaraArrayVectorValue_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVectorValue_Index_Offset), 0, GetNiagaraArrayVectorValue_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayVectorValue_FunctionAddress, intPtr, GetNiagaraArrayVectorValue_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetNiagaraArrayVectorValue_ReturnValue_Offset), 0, GetNiagaraArrayVectorValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector4Value")]
	public unsafe static FVector4 GetNiagaraArrayVector4Value(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
	{
		if (!GetNiagaraArrayVector4Value_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector4Value");
			return default(FVector4);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayVector4Value_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayVector4Value_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVector4Value_NiagaraSystem_Offset), 0, GetNiagaraArrayVector4Value_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVector4Value_OverrideName_Offset), 0, GetNiagaraArrayVector4Value_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVector4Value_Index_Offset), 0, GetNiagaraArrayVector4Value_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayVector4Value_FunctionAddress, intPtr, GetNiagaraArrayVector4Value_ParamsSize);
		return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(intPtr, GetNiagaraArrayVector4Value_ReturnValue_Offset), 0, GetNiagaraArrayVector4Value_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector4")]
	public unsafe static List<FVector4> GetNiagaraArrayVector4(UNiagaraComponent NiagaraSystem, FName OverrideName)
	{
		if (!GetNiagaraArrayVector4_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector4");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayVector4_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayVector4_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVector4_NiagaraSystem_Offset), 0, GetNiagaraArrayVector4_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVector4_OverrideName_Offset), 0, GetNiagaraArrayVector4_OverrideName_PropertyAddress.Address, OverrideName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayVector4_FunctionAddress, intPtr, GetNiagaraArrayVector4_ParamsSize);
		List<FVector4> result = new TArrayCopyMarshaler<FVector4>(1, GetNiagaraArrayVector4_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.FromNative, CachedMarshalingDelegates<FVector4, BlittableTypeMarshaler<FVector4>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNiagaraArrayVector4_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNiagaraArrayVector4_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector2DValue")]
	public unsafe static FVector2D GetNiagaraArrayVector2DValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
	{
		if (!GetNiagaraArrayVector2DValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector2DValue");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayVector2DValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayVector2DValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVector2DValue_NiagaraSystem_Offset), 0, GetNiagaraArrayVector2DValue_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVector2DValue_OverrideName_Offset), 0, GetNiagaraArrayVector2DValue_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVector2DValue_Index_Offset), 0, GetNiagaraArrayVector2DValue_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayVector2DValue_FunctionAddress, intPtr, GetNiagaraArrayVector2DValue_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetNiagaraArrayVector2DValue_ReturnValue_Offset), 0, GetNiagaraArrayVector2DValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector2D")]
	public unsafe static List<FVector2D> GetNiagaraArrayVector2D(UNiagaraComponent NiagaraSystem, FName OverrideName)
	{
		if (!GetNiagaraArrayVector2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector2D");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayVector2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayVector2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVector2D_NiagaraSystem_Offset), 0, GetNiagaraArrayVector2D_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVector2D_OverrideName_Offset), 0, GetNiagaraArrayVector2D_OverrideName_PropertyAddress.Address, OverrideName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayVector2D_FunctionAddress, intPtr, GetNiagaraArrayVector2D_ParamsSize);
		List<FVector2D> result = new TArrayCopyMarshaler<FVector2D>(1, GetNiagaraArrayVector2D_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNiagaraArrayVector2D_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNiagaraArrayVector2D_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector")]
	public unsafe static List<FVector> GetNiagaraArrayVector(UNiagaraComponent NiagaraSystem, FName OverrideName)
	{
		if (!GetNiagaraArrayVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVector_NiagaraSystem_Offset), 0, GetNiagaraArrayVector_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayVector_OverrideName_Offset), 0, GetNiagaraArrayVector_OverrideName_PropertyAddress.Address, OverrideName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayVector_FunctionAddress, intPtr, GetNiagaraArrayVector_ParamsSize);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, GetNiagaraArrayVector_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNiagaraArrayVector_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNiagaraArrayVector_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayQuatValue")]
	public unsafe static FQuat GetNiagaraArrayQuatValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
	{
		if (!GetNiagaraArrayQuatValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayQuatValue");
			return default(FQuat);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayQuatValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayQuatValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayQuatValue_NiagaraSystem_Offset), 0, GetNiagaraArrayQuatValue_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayQuatValue_OverrideName_Offset), 0, GetNiagaraArrayQuatValue_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayQuatValue_Index_Offset), 0, GetNiagaraArrayQuatValue_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayQuatValue_FunctionAddress, intPtr, GetNiagaraArrayQuatValue_ParamsSize);
		return BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(intPtr, GetNiagaraArrayQuatValue_ReturnValue_Offset), 0, GetNiagaraArrayQuatValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayQuat")]
	public unsafe static List<FQuat> GetNiagaraArrayQuat(UNiagaraComponent NiagaraSystem, FName OverrideName)
	{
		if (!GetNiagaraArrayQuat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayQuat");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayQuat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayQuat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayQuat_NiagaraSystem_Offset), 0, GetNiagaraArrayQuat_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayQuat_OverrideName_Offset), 0, GetNiagaraArrayQuat_OverrideName_PropertyAddress.Address, OverrideName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayQuat_FunctionAddress, intPtr, GetNiagaraArrayQuat_ParamsSize);
		List<FQuat> result = new TArrayCopyMarshaler<FQuat>(1, GetNiagaraArrayQuat_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FQuat, BlittableTypeMarshaler<FQuat>>.FromNative, CachedMarshalingDelegates<FQuat, BlittableTypeMarshaler<FQuat>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNiagaraArrayQuat_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNiagaraArrayQuat_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayPositionValue")]
	public unsafe static FVector GetNiagaraArrayPositionValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
	{
		if (!GetNiagaraArrayPositionValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayPositionValue");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayPositionValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayPositionValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayPositionValue_NiagaraSystem_Offset), 0, GetNiagaraArrayPositionValue_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayPositionValue_OverrideName_Offset), 0, GetNiagaraArrayPositionValue_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayPositionValue_Index_Offset), 0, GetNiagaraArrayPositionValue_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayPositionValue_FunctionAddress, intPtr, GetNiagaraArrayPositionValue_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetNiagaraArrayPositionValue_ReturnValue_Offset), 0, GetNiagaraArrayPositionValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayPosition")]
	public unsafe static List<FVector> GetNiagaraArrayPosition(UNiagaraComponent NiagaraSystem, FName OverrideName)
	{
		if (!GetNiagaraArrayPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayPosition");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayPosition_NiagaraSystem_Offset), 0, GetNiagaraArrayPosition_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayPosition_OverrideName_Offset), 0, GetNiagaraArrayPosition_OverrideName_PropertyAddress.Address, OverrideName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayPosition_FunctionAddress, intPtr, GetNiagaraArrayPosition_ParamsSize);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, GetNiagaraArrayPosition_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNiagaraArrayPosition_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNiagaraArrayPosition_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayInt32Value")]
	public unsafe static int GetNiagaraArrayInt32Value(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
	{
		if (!GetNiagaraArrayInt32Value_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayInt32Value");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayInt32Value_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayInt32Value_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayInt32Value_NiagaraSystem_Offset), 0, GetNiagaraArrayInt32Value_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayInt32Value_OverrideName_Offset), 0, GetNiagaraArrayInt32Value_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayInt32Value_Index_Offset), 0, GetNiagaraArrayInt32Value_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayInt32Value_FunctionAddress, intPtr, GetNiagaraArrayInt32Value_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNiagaraArrayInt32Value_ReturnValue_Offset), 0, GetNiagaraArrayInt32Value_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayInt32")]
	public unsafe static List<int> GetNiagaraArrayInt32(UNiagaraComponent NiagaraSystem, FName OverrideName)
	{
		if (!GetNiagaraArrayInt32_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayInt32");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayInt32_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayInt32_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayInt32_NiagaraSystem_Offset), 0, GetNiagaraArrayInt32_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayInt32_OverrideName_Offset), 0, GetNiagaraArrayInt32_OverrideName_PropertyAddress.Address, OverrideName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayInt32_FunctionAddress, intPtr, GetNiagaraArrayInt32_ParamsSize);
		List<int> result = new TArrayCopyMarshaler<int>(1, GetNiagaraArrayInt32_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNiagaraArrayInt32_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNiagaraArrayInt32_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayFloatValue")]
	public unsafe static float GetNiagaraArrayFloatValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
	{
		if (!GetNiagaraArrayFloatValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayFloatValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayFloatValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayFloatValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayFloatValue_NiagaraSystem_Offset), 0, GetNiagaraArrayFloatValue_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayFloatValue_OverrideName_Offset), 0, GetNiagaraArrayFloatValue_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayFloatValue_Index_Offset), 0, GetNiagaraArrayFloatValue_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayFloatValue_FunctionAddress, intPtr, GetNiagaraArrayFloatValue_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetNiagaraArrayFloatValue_ReturnValue_Offset), 0, GetNiagaraArrayFloatValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayFloat")]
	public unsafe static List<float> GetNiagaraArrayFloat(UNiagaraComponent NiagaraSystem, FName OverrideName)
	{
		if (!GetNiagaraArrayFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayFloat");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayFloat_NiagaraSystem_Offset), 0, GetNiagaraArrayFloat_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayFloat_OverrideName_Offset), 0, GetNiagaraArrayFloat_OverrideName_PropertyAddress.Address, OverrideName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayFloat_FunctionAddress, intPtr, GetNiagaraArrayFloat_ParamsSize);
		List<float> result = new TArrayCopyMarshaler<float>(1, GetNiagaraArrayFloat_ReturnValue_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNiagaraArrayFloat_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNiagaraArrayFloat_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayColorValue")]
	public unsafe static FLinearColor GetNiagaraArrayColorValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
	{
		if (!GetNiagaraArrayColorValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayColorValue");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayColorValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayColorValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayColorValue_NiagaraSystem_Offset), 0, GetNiagaraArrayColorValue_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayColorValue_OverrideName_Offset), 0, GetNiagaraArrayColorValue_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayColorValue_Index_Offset), 0, GetNiagaraArrayColorValue_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayColorValue_FunctionAddress, intPtr, GetNiagaraArrayColorValue_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetNiagaraArrayColorValue_ReturnValue_Offset), 0, GetNiagaraArrayColorValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayColor")]
	public unsafe static List<FLinearColor> GetNiagaraArrayColor(UNiagaraComponent NiagaraSystem, FName OverrideName)
	{
		if (!GetNiagaraArrayColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayColor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayColor_NiagaraSystem_Offset), 0, GetNiagaraArrayColor_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayColor_OverrideName_Offset), 0, GetNiagaraArrayColor_OverrideName_PropertyAddress.Address, OverrideName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayColor_FunctionAddress, intPtr, GetNiagaraArrayColor_ParamsSize);
		List<FLinearColor> result = new TArrayCopyMarshaler<FLinearColor>(1, GetNiagaraArrayColor_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.FromNative, CachedMarshalingDelegates<FLinearColor, BlittableTypeMarshaler<FLinearColor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNiagaraArrayColor_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNiagaraArrayColor_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayBoolValue")]
	public unsafe static bool GetNiagaraArrayBoolValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
	{
		if (!GetNiagaraArrayBoolValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayBoolValue");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayBoolValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayBoolValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayBoolValue_NiagaraSystem_Offset), 0, GetNiagaraArrayBoolValue_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayBoolValue_OverrideName_Offset), 0, GetNiagaraArrayBoolValue_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayBoolValue_Index_Offset), 0, GetNiagaraArrayBoolValue_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayBoolValue_FunctionAddress, intPtr, GetNiagaraArrayBoolValue_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetNiagaraArrayBoolValue_ReturnValue_Offset), 0, GetNiagaraArrayBoolValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayBool")]
	public unsafe static List<bool> GetNiagaraArrayBool(UNiagaraComponent NiagaraSystem, FName OverrideName)
	{
		if (!GetNiagaraArrayBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayBool");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraArrayBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraArrayBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayBool_NiagaraSystem_Offset), 0, GetNiagaraArrayBool_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetNiagaraArrayBool_OverrideName_Offset), 0, GetNiagaraArrayBool_OverrideName_PropertyAddress.Address, OverrideName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraArrayBool_FunctionAddress, intPtr, GetNiagaraArrayBool_ParamsSize);
		List<bool> result = new TArrayCopyMarshaler<bool>(1, GetNiagaraArrayBool_ReturnValue_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetNiagaraArrayBool_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNiagaraArrayBool_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UNiagaraDataInterfaceArrayFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraDataInterfaceArrayFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraDataInterfaceArrayFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary");
		SetNiagaraArrayVectorValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayVectorValue");
		SetNiagaraArrayVectorValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayVectorValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVectorValue_NiagaraSystem_PropertyAddress, SetNiagaraArrayVectorValue_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayVectorValue_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVectorValue_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayVectorValue_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVectorValue_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVectorValue_OverrideName_PropertyAddress, SetNiagaraArrayVectorValue_FunctionAddress, "OverrideName");
		SetNiagaraArrayVectorValue_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVectorValue_FunctionAddress, "OverrideName");
		SetNiagaraArrayVectorValue_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVectorValue_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVectorValue_Index_PropertyAddress, SetNiagaraArrayVectorValue_FunctionAddress, "Index");
		SetNiagaraArrayVectorValue_Index_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVectorValue_FunctionAddress, "Index");
		SetNiagaraArrayVectorValue_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVectorValue_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVectorValue_Value_PropertyAddress, SetNiagaraArrayVectorValue_FunctionAddress, "Value");
		SetNiagaraArrayVectorValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVectorValue_FunctionAddress, "Value");
		SetNiagaraArrayVectorValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVectorValue_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVectorValue_bSizeToFit_PropertyAddress, SetNiagaraArrayVectorValue_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayVectorValue_bSizeToFit_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVectorValue_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayVectorValue_bSizeToFit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVectorValue_FunctionAddress, "bSizeToFit", Classes.FBoolProperty);
		SetNiagaraArrayVectorValue_IsValid = SetNiagaraArrayVectorValue_FunctionAddress != IntPtr.Zero && SetNiagaraArrayVectorValue_NiagaraSystem_IsValid && SetNiagaraArrayVectorValue_OverrideName_IsValid && SetNiagaraArrayVectorValue_Index_IsValid && SetNiagaraArrayVectorValue_Value_IsValid && SetNiagaraArrayVectorValue_bSizeToFit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVectorValue", SetNiagaraArrayVectorValue_IsValid);
		SetNiagaraArrayVector4Value_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayVector4Value");
		SetNiagaraArrayVector4Value_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayVector4Value_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector4Value_NiagaraSystem_PropertyAddress, SetNiagaraArrayVector4Value_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayVector4Value_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector4Value_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayVector4Value_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector4Value_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector4Value_OverrideName_PropertyAddress, SetNiagaraArrayVector4Value_FunctionAddress, "OverrideName");
		SetNiagaraArrayVector4Value_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector4Value_FunctionAddress, "OverrideName");
		SetNiagaraArrayVector4Value_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector4Value_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector4Value_Index_PropertyAddress, SetNiagaraArrayVector4Value_FunctionAddress, "Index");
		SetNiagaraArrayVector4Value_Index_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector4Value_FunctionAddress, "Index");
		SetNiagaraArrayVector4Value_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector4Value_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector4Value_Value_PropertyAddress, SetNiagaraArrayVector4Value_FunctionAddress, "Value");
		SetNiagaraArrayVector4Value_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector4Value_FunctionAddress, "Value");
		SetNiagaraArrayVector4Value_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector4Value_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector4Value_bSizeToFit_PropertyAddress, SetNiagaraArrayVector4Value_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayVector4Value_bSizeToFit_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector4Value_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayVector4Value_bSizeToFit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector4Value_FunctionAddress, "bSizeToFit", Classes.FBoolProperty);
		SetNiagaraArrayVector4Value_IsValid = SetNiagaraArrayVector4Value_FunctionAddress != IntPtr.Zero && SetNiagaraArrayVector4Value_NiagaraSystem_IsValid && SetNiagaraArrayVector4Value_OverrideName_IsValid && SetNiagaraArrayVector4Value_Index_IsValid && SetNiagaraArrayVector4Value_Value_IsValid && SetNiagaraArrayVector4Value_bSizeToFit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector4Value", SetNiagaraArrayVector4Value_IsValid);
		SetNiagaraArrayVector4_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayVector4");
		SetNiagaraArrayVector4_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayVector4_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector4_NiagaraSystem_PropertyAddress, SetNiagaraArrayVector4_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayVector4_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector4_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayVector4_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector4_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector4_OverrideName_PropertyAddress, SetNiagaraArrayVector4_FunctionAddress, "OverrideName");
		SetNiagaraArrayVector4_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector4_FunctionAddress, "OverrideName");
		SetNiagaraArrayVector4_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector4_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector4_ArrayData_PropertyAddress, SetNiagaraArrayVector4_FunctionAddress, "ArrayData");
		SetNiagaraArrayVector4_ArrayData_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector4_FunctionAddress, "ArrayData");
		SetNiagaraArrayVector4_ArrayData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector4_FunctionAddress, "ArrayData", Classes.FArrayProperty);
		SetNiagaraArrayVector4_IsValid = SetNiagaraArrayVector4_FunctionAddress != IntPtr.Zero && SetNiagaraArrayVector4_NiagaraSystem_IsValid && SetNiagaraArrayVector4_OverrideName_IsValid && SetNiagaraArrayVector4_ArrayData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector4", SetNiagaraArrayVector4_IsValid);
		SetNiagaraArrayVector2DValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayVector2DValue");
		SetNiagaraArrayVector2DValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayVector2DValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector2DValue_NiagaraSystem_PropertyAddress, SetNiagaraArrayVector2DValue_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayVector2DValue_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector2DValue_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayVector2DValue_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector2DValue_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector2DValue_OverrideName_PropertyAddress, SetNiagaraArrayVector2DValue_FunctionAddress, "OverrideName");
		SetNiagaraArrayVector2DValue_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector2DValue_FunctionAddress, "OverrideName");
		SetNiagaraArrayVector2DValue_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector2DValue_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector2DValue_Index_PropertyAddress, SetNiagaraArrayVector2DValue_FunctionAddress, "Index");
		SetNiagaraArrayVector2DValue_Index_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector2DValue_FunctionAddress, "Index");
		SetNiagaraArrayVector2DValue_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector2DValue_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector2DValue_Value_PropertyAddress, SetNiagaraArrayVector2DValue_FunctionAddress, "Value");
		SetNiagaraArrayVector2DValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector2DValue_FunctionAddress, "Value");
		SetNiagaraArrayVector2DValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector2DValue_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector2DValue_bSizeToFit_PropertyAddress, SetNiagaraArrayVector2DValue_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayVector2DValue_bSizeToFit_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector2DValue_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayVector2DValue_bSizeToFit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector2DValue_FunctionAddress, "bSizeToFit", Classes.FBoolProperty);
		SetNiagaraArrayVector2DValue_IsValid = SetNiagaraArrayVector2DValue_FunctionAddress != IntPtr.Zero && SetNiagaraArrayVector2DValue_NiagaraSystem_IsValid && SetNiagaraArrayVector2DValue_OverrideName_IsValid && SetNiagaraArrayVector2DValue_Index_IsValid && SetNiagaraArrayVector2DValue_Value_IsValid && SetNiagaraArrayVector2DValue_bSizeToFit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector2DValue", SetNiagaraArrayVector2DValue_IsValid);
		SetNiagaraArrayVector2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayVector2D");
		SetNiagaraArrayVector2D_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayVector2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector2D_NiagaraSystem_PropertyAddress, SetNiagaraArrayVector2D_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayVector2D_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector2D_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayVector2D_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector2D_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector2D_OverrideName_PropertyAddress, SetNiagaraArrayVector2D_FunctionAddress, "OverrideName");
		SetNiagaraArrayVector2D_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector2D_FunctionAddress, "OverrideName");
		SetNiagaraArrayVector2D_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector2D_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector2D_ArrayData_PropertyAddress, SetNiagaraArrayVector2D_FunctionAddress, "ArrayData");
		SetNiagaraArrayVector2D_ArrayData_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector2D_FunctionAddress, "ArrayData");
		SetNiagaraArrayVector2D_ArrayData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector2D_FunctionAddress, "ArrayData", Classes.FArrayProperty);
		SetNiagaraArrayVector2D_IsValid = SetNiagaraArrayVector2D_FunctionAddress != IntPtr.Zero && SetNiagaraArrayVector2D_NiagaraSystem_IsValid && SetNiagaraArrayVector2D_OverrideName_IsValid && SetNiagaraArrayVector2D_ArrayData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector2D", SetNiagaraArrayVector2D_IsValid);
		SetNiagaraArrayVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayVector");
		SetNiagaraArrayVector_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector_NiagaraSystem_PropertyAddress, SetNiagaraArrayVector_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayVector_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayVector_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector_OverrideName_PropertyAddress, SetNiagaraArrayVector_FunctionAddress, "OverrideName");
		SetNiagaraArrayVector_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector_FunctionAddress, "OverrideName");
		SetNiagaraArrayVector_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayVector_ArrayData_PropertyAddress, SetNiagaraArrayVector_FunctionAddress, "ArrayData");
		SetNiagaraArrayVector_ArrayData_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayVector_FunctionAddress, "ArrayData");
		SetNiagaraArrayVector_ArrayData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayVector_FunctionAddress, "ArrayData", Classes.FArrayProperty);
		SetNiagaraArrayVector_IsValid = SetNiagaraArrayVector_FunctionAddress != IntPtr.Zero && SetNiagaraArrayVector_NiagaraSystem_IsValid && SetNiagaraArrayVector_OverrideName_IsValid && SetNiagaraArrayVector_ArrayData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayVector", SetNiagaraArrayVector_IsValid);
		SetNiagaraArrayQuatValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayQuatValue");
		SetNiagaraArrayQuatValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayQuatValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayQuatValue_NiagaraSystem_PropertyAddress, SetNiagaraArrayQuatValue_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayQuatValue_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayQuatValue_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayQuatValue_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayQuatValue_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayQuatValue_OverrideName_PropertyAddress, SetNiagaraArrayQuatValue_FunctionAddress, "OverrideName");
		SetNiagaraArrayQuatValue_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayQuatValue_FunctionAddress, "OverrideName");
		SetNiagaraArrayQuatValue_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayQuatValue_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayQuatValue_Index_PropertyAddress, SetNiagaraArrayQuatValue_FunctionAddress, "Index");
		SetNiagaraArrayQuatValue_Index_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayQuatValue_FunctionAddress, "Index");
		SetNiagaraArrayQuatValue_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayQuatValue_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayQuatValue_Value_PropertyAddress, SetNiagaraArrayQuatValue_FunctionAddress, "Value");
		SetNiagaraArrayQuatValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayQuatValue_FunctionAddress, "Value");
		SetNiagaraArrayQuatValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayQuatValue_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayQuatValue_bSizeToFit_PropertyAddress, SetNiagaraArrayQuatValue_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayQuatValue_bSizeToFit_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayQuatValue_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayQuatValue_bSizeToFit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayQuatValue_FunctionAddress, "bSizeToFit", Classes.FBoolProperty);
		SetNiagaraArrayQuatValue_IsValid = SetNiagaraArrayQuatValue_FunctionAddress != IntPtr.Zero && SetNiagaraArrayQuatValue_NiagaraSystem_IsValid && SetNiagaraArrayQuatValue_OverrideName_IsValid && SetNiagaraArrayQuatValue_Index_IsValid && SetNiagaraArrayQuatValue_Value_IsValid && SetNiagaraArrayQuatValue_bSizeToFit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayQuatValue", SetNiagaraArrayQuatValue_IsValid);
		SetNiagaraArrayQuat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayQuat");
		SetNiagaraArrayQuat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayQuat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayQuat_NiagaraSystem_PropertyAddress, SetNiagaraArrayQuat_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayQuat_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayQuat_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayQuat_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayQuat_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayQuat_OverrideName_PropertyAddress, SetNiagaraArrayQuat_FunctionAddress, "OverrideName");
		SetNiagaraArrayQuat_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayQuat_FunctionAddress, "OverrideName");
		SetNiagaraArrayQuat_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayQuat_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayQuat_ArrayData_PropertyAddress, SetNiagaraArrayQuat_FunctionAddress, "ArrayData");
		SetNiagaraArrayQuat_ArrayData_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayQuat_FunctionAddress, "ArrayData");
		SetNiagaraArrayQuat_ArrayData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayQuat_FunctionAddress, "ArrayData", Classes.FArrayProperty);
		SetNiagaraArrayQuat_IsValid = SetNiagaraArrayQuat_FunctionAddress != IntPtr.Zero && SetNiagaraArrayQuat_NiagaraSystem_IsValid && SetNiagaraArrayQuat_OverrideName_IsValid && SetNiagaraArrayQuat_ArrayData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayQuat", SetNiagaraArrayQuat_IsValid);
		SetNiagaraArrayPositionValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayPositionValue");
		SetNiagaraArrayPositionValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayPositionValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayPositionValue_NiagaraSystem_PropertyAddress, SetNiagaraArrayPositionValue_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayPositionValue_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayPositionValue_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayPositionValue_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayPositionValue_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayPositionValue_OverrideName_PropertyAddress, SetNiagaraArrayPositionValue_FunctionAddress, "OverrideName");
		SetNiagaraArrayPositionValue_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayPositionValue_FunctionAddress, "OverrideName");
		SetNiagaraArrayPositionValue_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayPositionValue_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayPositionValue_Index_PropertyAddress, SetNiagaraArrayPositionValue_FunctionAddress, "Index");
		SetNiagaraArrayPositionValue_Index_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayPositionValue_FunctionAddress, "Index");
		SetNiagaraArrayPositionValue_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayPositionValue_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayPositionValue_Value_PropertyAddress, SetNiagaraArrayPositionValue_FunctionAddress, "Value");
		SetNiagaraArrayPositionValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayPositionValue_FunctionAddress, "Value");
		SetNiagaraArrayPositionValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayPositionValue_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayPositionValue_bSizeToFit_PropertyAddress, SetNiagaraArrayPositionValue_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayPositionValue_bSizeToFit_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayPositionValue_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayPositionValue_bSizeToFit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayPositionValue_FunctionAddress, "bSizeToFit", Classes.FBoolProperty);
		SetNiagaraArrayPositionValue_IsValid = SetNiagaraArrayPositionValue_FunctionAddress != IntPtr.Zero && SetNiagaraArrayPositionValue_NiagaraSystem_IsValid && SetNiagaraArrayPositionValue_OverrideName_IsValid && SetNiagaraArrayPositionValue_Index_IsValid && SetNiagaraArrayPositionValue_Value_IsValid && SetNiagaraArrayPositionValue_bSizeToFit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayPositionValue", SetNiagaraArrayPositionValue_IsValid);
		SetNiagaraArrayPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayPosition");
		SetNiagaraArrayPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayPosition_NiagaraSystem_PropertyAddress, SetNiagaraArrayPosition_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayPosition_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayPosition_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayPosition_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayPosition_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayPosition_OverrideName_PropertyAddress, SetNiagaraArrayPosition_FunctionAddress, "OverrideName");
		SetNiagaraArrayPosition_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayPosition_FunctionAddress, "OverrideName");
		SetNiagaraArrayPosition_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayPosition_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayPosition_ArrayData_PropertyAddress, SetNiagaraArrayPosition_FunctionAddress, "ArrayData");
		SetNiagaraArrayPosition_ArrayData_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayPosition_FunctionAddress, "ArrayData");
		SetNiagaraArrayPosition_ArrayData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayPosition_FunctionAddress, "ArrayData", Classes.FArrayProperty);
		SetNiagaraArrayPosition_IsValid = SetNiagaraArrayPosition_FunctionAddress != IntPtr.Zero && SetNiagaraArrayPosition_NiagaraSystem_IsValid && SetNiagaraArrayPosition_OverrideName_IsValid && SetNiagaraArrayPosition_ArrayData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayPosition", SetNiagaraArrayPosition_IsValid);
		SetNiagaraArrayInt32Value_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayInt32Value");
		SetNiagaraArrayInt32Value_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayInt32Value_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayInt32Value_NiagaraSystem_PropertyAddress, SetNiagaraArrayInt32Value_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayInt32Value_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayInt32Value_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayInt32Value_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayInt32Value_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayInt32Value_OverrideName_PropertyAddress, SetNiagaraArrayInt32Value_FunctionAddress, "OverrideName");
		SetNiagaraArrayInt32Value_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayInt32Value_FunctionAddress, "OverrideName");
		SetNiagaraArrayInt32Value_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayInt32Value_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayInt32Value_Index_PropertyAddress, SetNiagaraArrayInt32Value_FunctionAddress, "Index");
		SetNiagaraArrayInt32Value_Index_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayInt32Value_FunctionAddress, "Index");
		SetNiagaraArrayInt32Value_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayInt32Value_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayInt32Value_Value_PropertyAddress, SetNiagaraArrayInt32Value_FunctionAddress, "Value");
		SetNiagaraArrayInt32Value_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayInt32Value_FunctionAddress, "Value");
		SetNiagaraArrayInt32Value_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayInt32Value_FunctionAddress, "Value", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayInt32Value_bSizeToFit_PropertyAddress, SetNiagaraArrayInt32Value_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayInt32Value_bSizeToFit_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayInt32Value_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayInt32Value_bSizeToFit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayInt32Value_FunctionAddress, "bSizeToFit", Classes.FBoolProperty);
		SetNiagaraArrayInt32Value_IsValid = SetNiagaraArrayInt32Value_FunctionAddress != IntPtr.Zero && SetNiagaraArrayInt32Value_NiagaraSystem_IsValid && SetNiagaraArrayInt32Value_OverrideName_IsValid && SetNiagaraArrayInt32Value_Index_IsValid && SetNiagaraArrayInt32Value_Value_IsValid && SetNiagaraArrayInt32Value_bSizeToFit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayInt32Value", SetNiagaraArrayInt32Value_IsValid);
		SetNiagaraArrayInt32_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayInt32");
		SetNiagaraArrayInt32_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayInt32_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayInt32_NiagaraSystem_PropertyAddress, SetNiagaraArrayInt32_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayInt32_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayInt32_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayInt32_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayInt32_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayInt32_OverrideName_PropertyAddress, SetNiagaraArrayInt32_FunctionAddress, "OverrideName");
		SetNiagaraArrayInt32_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayInt32_FunctionAddress, "OverrideName");
		SetNiagaraArrayInt32_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayInt32_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayInt32_ArrayData_PropertyAddress, SetNiagaraArrayInt32_FunctionAddress, "ArrayData");
		SetNiagaraArrayInt32_ArrayData_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayInt32_FunctionAddress, "ArrayData");
		SetNiagaraArrayInt32_ArrayData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayInt32_FunctionAddress, "ArrayData", Classes.FArrayProperty);
		SetNiagaraArrayInt32_IsValid = SetNiagaraArrayInt32_FunctionAddress != IntPtr.Zero && SetNiagaraArrayInt32_NiagaraSystem_IsValid && SetNiagaraArrayInt32_OverrideName_IsValid && SetNiagaraArrayInt32_ArrayData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayInt32", SetNiagaraArrayInt32_IsValid);
		SetNiagaraArrayFloatValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayFloatValue");
		SetNiagaraArrayFloatValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayFloatValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayFloatValue_NiagaraSystem_PropertyAddress, SetNiagaraArrayFloatValue_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayFloatValue_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayFloatValue_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayFloatValue_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayFloatValue_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayFloatValue_OverrideName_PropertyAddress, SetNiagaraArrayFloatValue_FunctionAddress, "OverrideName");
		SetNiagaraArrayFloatValue_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayFloatValue_FunctionAddress, "OverrideName");
		SetNiagaraArrayFloatValue_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayFloatValue_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayFloatValue_Index_PropertyAddress, SetNiagaraArrayFloatValue_FunctionAddress, "Index");
		SetNiagaraArrayFloatValue_Index_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayFloatValue_FunctionAddress, "Index");
		SetNiagaraArrayFloatValue_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayFloatValue_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayFloatValue_Value_PropertyAddress, SetNiagaraArrayFloatValue_FunctionAddress, "Value");
		SetNiagaraArrayFloatValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayFloatValue_FunctionAddress, "Value");
		SetNiagaraArrayFloatValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayFloatValue_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayFloatValue_bSizeToFit_PropertyAddress, SetNiagaraArrayFloatValue_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayFloatValue_bSizeToFit_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayFloatValue_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayFloatValue_bSizeToFit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayFloatValue_FunctionAddress, "bSizeToFit", Classes.FBoolProperty);
		SetNiagaraArrayFloatValue_IsValid = SetNiagaraArrayFloatValue_FunctionAddress != IntPtr.Zero && SetNiagaraArrayFloatValue_NiagaraSystem_IsValid && SetNiagaraArrayFloatValue_OverrideName_IsValid && SetNiagaraArrayFloatValue_Index_IsValid && SetNiagaraArrayFloatValue_Value_IsValid && SetNiagaraArrayFloatValue_bSizeToFit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayFloatValue", SetNiagaraArrayFloatValue_IsValid);
		SetNiagaraArrayFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayFloat");
		SetNiagaraArrayFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayFloat_NiagaraSystem_PropertyAddress, SetNiagaraArrayFloat_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayFloat_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayFloat_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayFloat_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayFloat_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayFloat_OverrideName_PropertyAddress, SetNiagaraArrayFloat_FunctionAddress, "OverrideName");
		SetNiagaraArrayFloat_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayFloat_FunctionAddress, "OverrideName");
		SetNiagaraArrayFloat_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayFloat_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayFloat_ArrayData_PropertyAddress, SetNiagaraArrayFloat_FunctionAddress, "ArrayData");
		SetNiagaraArrayFloat_ArrayData_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayFloat_FunctionAddress, "ArrayData");
		SetNiagaraArrayFloat_ArrayData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayFloat_FunctionAddress, "ArrayData", Classes.FArrayProperty);
		SetNiagaraArrayFloat_IsValid = SetNiagaraArrayFloat_FunctionAddress != IntPtr.Zero && SetNiagaraArrayFloat_NiagaraSystem_IsValid && SetNiagaraArrayFloat_OverrideName_IsValid && SetNiagaraArrayFloat_ArrayData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayFloat", SetNiagaraArrayFloat_IsValid);
		SetNiagaraArrayColorValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayColorValue");
		SetNiagaraArrayColorValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayColorValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayColorValue_NiagaraSystem_PropertyAddress, SetNiagaraArrayColorValue_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayColorValue_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayColorValue_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayColorValue_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayColorValue_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayColorValue_OverrideName_PropertyAddress, SetNiagaraArrayColorValue_FunctionAddress, "OverrideName");
		SetNiagaraArrayColorValue_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayColorValue_FunctionAddress, "OverrideName");
		SetNiagaraArrayColorValue_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayColorValue_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayColorValue_Index_PropertyAddress, SetNiagaraArrayColorValue_FunctionAddress, "Index");
		SetNiagaraArrayColorValue_Index_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayColorValue_FunctionAddress, "Index");
		SetNiagaraArrayColorValue_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayColorValue_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayColorValue_Value_PropertyAddress, SetNiagaraArrayColorValue_FunctionAddress, "Value");
		SetNiagaraArrayColorValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayColorValue_FunctionAddress, "Value");
		SetNiagaraArrayColorValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayColorValue_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayColorValue_bSizeToFit_PropertyAddress, SetNiagaraArrayColorValue_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayColorValue_bSizeToFit_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayColorValue_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayColorValue_bSizeToFit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayColorValue_FunctionAddress, "bSizeToFit", Classes.FBoolProperty);
		SetNiagaraArrayColorValue_IsValid = SetNiagaraArrayColorValue_FunctionAddress != IntPtr.Zero && SetNiagaraArrayColorValue_NiagaraSystem_IsValid && SetNiagaraArrayColorValue_OverrideName_IsValid && SetNiagaraArrayColorValue_Index_IsValid && SetNiagaraArrayColorValue_Value_IsValid && SetNiagaraArrayColorValue_bSizeToFit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayColorValue", SetNiagaraArrayColorValue_IsValid);
		SetNiagaraArrayColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayColor");
		SetNiagaraArrayColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayColor_NiagaraSystem_PropertyAddress, SetNiagaraArrayColor_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayColor_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayColor_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayColor_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayColor_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayColor_OverrideName_PropertyAddress, SetNiagaraArrayColor_FunctionAddress, "OverrideName");
		SetNiagaraArrayColor_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayColor_FunctionAddress, "OverrideName");
		SetNiagaraArrayColor_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayColor_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayColor_ArrayData_PropertyAddress, SetNiagaraArrayColor_FunctionAddress, "ArrayData");
		SetNiagaraArrayColor_ArrayData_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayColor_FunctionAddress, "ArrayData");
		SetNiagaraArrayColor_ArrayData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayColor_FunctionAddress, "ArrayData", Classes.FArrayProperty);
		SetNiagaraArrayColor_IsValid = SetNiagaraArrayColor_FunctionAddress != IntPtr.Zero && SetNiagaraArrayColor_NiagaraSystem_IsValid && SetNiagaraArrayColor_OverrideName_IsValid && SetNiagaraArrayColor_ArrayData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayColor", SetNiagaraArrayColor_IsValid);
		SetNiagaraArrayBoolValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayBoolValue");
		SetNiagaraArrayBoolValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayBoolValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayBoolValue_NiagaraSystem_PropertyAddress, SetNiagaraArrayBoolValue_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayBoolValue_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayBoolValue_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayBoolValue_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayBoolValue_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayBoolValue_OverrideName_PropertyAddress, SetNiagaraArrayBoolValue_FunctionAddress, "OverrideName");
		SetNiagaraArrayBoolValue_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayBoolValue_FunctionAddress, "OverrideName");
		SetNiagaraArrayBoolValue_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayBoolValue_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayBoolValue_Index_PropertyAddress, SetNiagaraArrayBoolValue_FunctionAddress, "Index");
		SetNiagaraArrayBoolValue_Index_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayBoolValue_FunctionAddress, "Index");
		SetNiagaraArrayBoolValue_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayBoolValue_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayBoolValue_Value_PropertyAddress, SetNiagaraArrayBoolValue_FunctionAddress, "Value");
		SetNiagaraArrayBoolValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayBoolValue_FunctionAddress, "Value");
		SetNiagaraArrayBoolValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayBoolValue_FunctionAddress, "Value", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayBoolValue_bSizeToFit_PropertyAddress, SetNiagaraArrayBoolValue_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayBoolValue_bSizeToFit_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayBoolValue_FunctionAddress, "bSizeToFit");
		SetNiagaraArrayBoolValue_bSizeToFit_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayBoolValue_FunctionAddress, "bSizeToFit", Classes.FBoolProperty);
		SetNiagaraArrayBoolValue_IsValid = SetNiagaraArrayBoolValue_FunctionAddress != IntPtr.Zero && SetNiagaraArrayBoolValue_NiagaraSystem_IsValid && SetNiagaraArrayBoolValue_OverrideName_IsValid && SetNiagaraArrayBoolValue_Index_IsValid && SetNiagaraArrayBoolValue_Value_IsValid && SetNiagaraArrayBoolValue_bSizeToFit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayBoolValue", SetNiagaraArrayBoolValue_IsValid);
		SetNiagaraArrayBool_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraArrayBool");
		SetNiagaraArrayBool_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraArrayBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayBool_NiagaraSystem_PropertyAddress, SetNiagaraArrayBool_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayBool_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayBool_FunctionAddress, "NiagaraSystem");
		SetNiagaraArrayBool_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayBool_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayBool_OverrideName_PropertyAddress, SetNiagaraArrayBool_FunctionAddress, "OverrideName");
		SetNiagaraArrayBool_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayBool_FunctionAddress, "OverrideName");
		SetNiagaraArrayBool_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayBool_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraArrayBool_ArrayData_PropertyAddress, SetNiagaraArrayBool_FunctionAddress, "ArrayData");
		SetNiagaraArrayBool_ArrayData_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraArrayBool_FunctionAddress, "ArrayData");
		SetNiagaraArrayBool_ArrayData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraArrayBool_FunctionAddress, "ArrayData", Classes.FArrayProperty);
		SetNiagaraArrayBool_IsValid = SetNiagaraArrayBool_FunctionAddress != IntPtr.Zero && SetNiagaraArrayBool_NiagaraSystem_IsValid && SetNiagaraArrayBool_OverrideName_IsValid && SetNiagaraArrayBool_ArrayData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:SetNiagaraArrayBool", SetNiagaraArrayBool_IsValid);
		GetNiagaraArrayVectorValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayVectorValue");
		GetNiagaraArrayVectorValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayVectorValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVectorValue_NiagaraSystem_PropertyAddress, GetNiagaraArrayVectorValue_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayVectorValue_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVectorValue_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayVectorValue_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVectorValue_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVectorValue_OverrideName_PropertyAddress, GetNiagaraArrayVectorValue_FunctionAddress, "OverrideName");
		GetNiagaraArrayVectorValue_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVectorValue_FunctionAddress, "OverrideName");
		GetNiagaraArrayVectorValue_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVectorValue_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVectorValue_Index_PropertyAddress, GetNiagaraArrayVectorValue_FunctionAddress, "Index");
		GetNiagaraArrayVectorValue_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVectorValue_FunctionAddress, "Index");
		GetNiagaraArrayVectorValue_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVectorValue_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVectorValue_ReturnValue_PropertyAddress, GetNiagaraArrayVectorValue_FunctionAddress, "ReturnValue");
		GetNiagaraArrayVectorValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVectorValue_FunctionAddress, "ReturnValue");
		GetNiagaraArrayVectorValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVectorValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetNiagaraArrayVectorValue_IsValid = GetNiagaraArrayVectorValue_FunctionAddress != IntPtr.Zero && GetNiagaraArrayVectorValue_NiagaraSystem_IsValid && GetNiagaraArrayVectorValue_OverrideName_IsValid && GetNiagaraArrayVectorValue_Index_IsValid && GetNiagaraArrayVectorValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVectorValue", GetNiagaraArrayVectorValue_IsValid);
		GetNiagaraArrayVector4Value_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayVector4Value");
		GetNiagaraArrayVector4Value_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayVector4Value_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector4Value_NiagaraSystem_PropertyAddress, GetNiagaraArrayVector4Value_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayVector4Value_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector4Value_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayVector4Value_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector4Value_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector4Value_OverrideName_PropertyAddress, GetNiagaraArrayVector4Value_FunctionAddress, "OverrideName");
		GetNiagaraArrayVector4Value_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector4Value_FunctionAddress, "OverrideName");
		GetNiagaraArrayVector4Value_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector4Value_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector4Value_Index_PropertyAddress, GetNiagaraArrayVector4Value_FunctionAddress, "Index");
		GetNiagaraArrayVector4Value_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector4Value_FunctionAddress, "Index");
		GetNiagaraArrayVector4Value_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector4Value_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector4Value_ReturnValue_PropertyAddress, GetNiagaraArrayVector4Value_FunctionAddress, "ReturnValue");
		GetNiagaraArrayVector4Value_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector4Value_FunctionAddress, "ReturnValue");
		GetNiagaraArrayVector4Value_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector4Value_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetNiagaraArrayVector4Value_IsValid = GetNiagaraArrayVector4Value_FunctionAddress != IntPtr.Zero && GetNiagaraArrayVector4Value_NiagaraSystem_IsValid && GetNiagaraArrayVector4Value_OverrideName_IsValid && GetNiagaraArrayVector4Value_Index_IsValid && GetNiagaraArrayVector4Value_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector4Value", GetNiagaraArrayVector4Value_IsValid);
		GetNiagaraArrayVector4_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayVector4");
		GetNiagaraArrayVector4_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayVector4_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector4_NiagaraSystem_PropertyAddress, GetNiagaraArrayVector4_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayVector4_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector4_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayVector4_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector4_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector4_OverrideName_PropertyAddress, GetNiagaraArrayVector4_FunctionAddress, "OverrideName");
		GetNiagaraArrayVector4_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector4_FunctionAddress, "OverrideName");
		GetNiagaraArrayVector4_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector4_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector4_ReturnValue_PropertyAddress, GetNiagaraArrayVector4_FunctionAddress, "ReturnValue");
		GetNiagaraArrayVector4_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector4_FunctionAddress, "ReturnValue");
		GetNiagaraArrayVector4_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector4_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNiagaraArrayVector4_IsValid = GetNiagaraArrayVector4_FunctionAddress != IntPtr.Zero && GetNiagaraArrayVector4_NiagaraSystem_IsValid && GetNiagaraArrayVector4_OverrideName_IsValid && GetNiagaraArrayVector4_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector4", GetNiagaraArrayVector4_IsValid);
		GetNiagaraArrayVector2DValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayVector2DValue");
		GetNiagaraArrayVector2DValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayVector2DValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector2DValue_NiagaraSystem_PropertyAddress, GetNiagaraArrayVector2DValue_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayVector2DValue_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector2DValue_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayVector2DValue_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector2DValue_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector2DValue_OverrideName_PropertyAddress, GetNiagaraArrayVector2DValue_FunctionAddress, "OverrideName");
		GetNiagaraArrayVector2DValue_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector2DValue_FunctionAddress, "OverrideName");
		GetNiagaraArrayVector2DValue_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector2DValue_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector2DValue_Index_PropertyAddress, GetNiagaraArrayVector2DValue_FunctionAddress, "Index");
		GetNiagaraArrayVector2DValue_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector2DValue_FunctionAddress, "Index");
		GetNiagaraArrayVector2DValue_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector2DValue_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector2DValue_ReturnValue_PropertyAddress, GetNiagaraArrayVector2DValue_FunctionAddress, "ReturnValue");
		GetNiagaraArrayVector2DValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector2DValue_FunctionAddress, "ReturnValue");
		GetNiagaraArrayVector2DValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector2DValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetNiagaraArrayVector2DValue_IsValid = GetNiagaraArrayVector2DValue_FunctionAddress != IntPtr.Zero && GetNiagaraArrayVector2DValue_NiagaraSystem_IsValid && GetNiagaraArrayVector2DValue_OverrideName_IsValid && GetNiagaraArrayVector2DValue_Index_IsValid && GetNiagaraArrayVector2DValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector2DValue", GetNiagaraArrayVector2DValue_IsValid);
		GetNiagaraArrayVector2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayVector2D");
		GetNiagaraArrayVector2D_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayVector2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector2D_NiagaraSystem_PropertyAddress, GetNiagaraArrayVector2D_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayVector2D_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector2D_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayVector2D_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector2D_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector2D_OverrideName_PropertyAddress, GetNiagaraArrayVector2D_FunctionAddress, "OverrideName");
		GetNiagaraArrayVector2D_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector2D_FunctionAddress, "OverrideName");
		GetNiagaraArrayVector2D_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector2D_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector2D_ReturnValue_PropertyAddress, GetNiagaraArrayVector2D_FunctionAddress, "ReturnValue");
		GetNiagaraArrayVector2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector2D_FunctionAddress, "ReturnValue");
		GetNiagaraArrayVector2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector2D_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNiagaraArrayVector2D_IsValid = GetNiagaraArrayVector2D_FunctionAddress != IntPtr.Zero && GetNiagaraArrayVector2D_NiagaraSystem_IsValid && GetNiagaraArrayVector2D_OverrideName_IsValid && GetNiagaraArrayVector2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector2D", GetNiagaraArrayVector2D_IsValid);
		GetNiagaraArrayVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayVector");
		GetNiagaraArrayVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector_NiagaraSystem_PropertyAddress, GetNiagaraArrayVector_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayVector_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayVector_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector_OverrideName_PropertyAddress, GetNiagaraArrayVector_FunctionAddress, "OverrideName");
		GetNiagaraArrayVector_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector_FunctionAddress, "OverrideName");
		GetNiagaraArrayVector_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayVector_ReturnValue_PropertyAddress, GetNiagaraArrayVector_FunctionAddress, "ReturnValue");
		GetNiagaraArrayVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayVector_FunctionAddress, "ReturnValue");
		GetNiagaraArrayVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayVector_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNiagaraArrayVector_IsValid = GetNiagaraArrayVector_FunctionAddress != IntPtr.Zero && GetNiagaraArrayVector_NiagaraSystem_IsValid && GetNiagaraArrayVector_OverrideName_IsValid && GetNiagaraArrayVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayVector", GetNiagaraArrayVector_IsValid);
		GetNiagaraArrayQuatValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayQuatValue");
		GetNiagaraArrayQuatValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayQuatValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayQuatValue_NiagaraSystem_PropertyAddress, GetNiagaraArrayQuatValue_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayQuatValue_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayQuatValue_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayQuatValue_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayQuatValue_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayQuatValue_OverrideName_PropertyAddress, GetNiagaraArrayQuatValue_FunctionAddress, "OverrideName");
		GetNiagaraArrayQuatValue_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayQuatValue_FunctionAddress, "OverrideName");
		GetNiagaraArrayQuatValue_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayQuatValue_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayQuatValue_Index_PropertyAddress, GetNiagaraArrayQuatValue_FunctionAddress, "Index");
		GetNiagaraArrayQuatValue_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayQuatValue_FunctionAddress, "Index");
		GetNiagaraArrayQuatValue_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayQuatValue_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayQuatValue_ReturnValue_PropertyAddress, GetNiagaraArrayQuatValue_FunctionAddress, "ReturnValue");
		GetNiagaraArrayQuatValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayQuatValue_FunctionAddress, "ReturnValue");
		GetNiagaraArrayQuatValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayQuatValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetNiagaraArrayQuatValue_IsValid = GetNiagaraArrayQuatValue_FunctionAddress != IntPtr.Zero && GetNiagaraArrayQuatValue_NiagaraSystem_IsValid && GetNiagaraArrayQuatValue_OverrideName_IsValid && GetNiagaraArrayQuatValue_Index_IsValid && GetNiagaraArrayQuatValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayQuatValue", GetNiagaraArrayQuatValue_IsValid);
		GetNiagaraArrayQuat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayQuat");
		GetNiagaraArrayQuat_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayQuat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayQuat_NiagaraSystem_PropertyAddress, GetNiagaraArrayQuat_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayQuat_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayQuat_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayQuat_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayQuat_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayQuat_OverrideName_PropertyAddress, GetNiagaraArrayQuat_FunctionAddress, "OverrideName");
		GetNiagaraArrayQuat_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayQuat_FunctionAddress, "OverrideName");
		GetNiagaraArrayQuat_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayQuat_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayQuat_ReturnValue_PropertyAddress, GetNiagaraArrayQuat_FunctionAddress, "ReturnValue");
		GetNiagaraArrayQuat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayQuat_FunctionAddress, "ReturnValue");
		GetNiagaraArrayQuat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayQuat_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNiagaraArrayQuat_IsValid = GetNiagaraArrayQuat_FunctionAddress != IntPtr.Zero && GetNiagaraArrayQuat_NiagaraSystem_IsValid && GetNiagaraArrayQuat_OverrideName_IsValid && GetNiagaraArrayQuat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayQuat", GetNiagaraArrayQuat_IsValid);
		GetNiagaraArrayPositionValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayPositionValue");
		GetNiagaraArrayPositionValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayPositionValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayPositionValue_NiagaraSystem_PropertyAddress, GetNiagaraArrayPositionValue_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayPositionValue_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayPositionValue_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayPositionValue_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayPositionValue_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayPositionValue_OverrideName_PropertyAddress, GetNiagaraArrayPositionValue_FunctionAddress, "OverrideName");
		GetNiagaraArrayPositionValue_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayPositionValue_FunctionAddress, "OverrideName");
		GetNiagaraArrayPositionValue_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayPositionValue_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayPositionValue_Index_PropertyAddress, GetNiagaraArrayPositionValue_FunctionAddress, "Index");
		GetNiagaraArrayPositionValue_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayPositionValue_FunctionAddress, "Index");
		GetNiagaraArrayPositionValue_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayPositionValue_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayPositionValue_ReturnValue_PropertyAddress, GetNiagaraArrayPositionValue_FunctionAddress, "ReturnValue");
		GetNiagaraArrayPositionValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayPositionValue_FunctionAddress, "ReturnValue");
		GetNiagaraArrayPositionValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayPositionValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetNiagaraArrayPositionValue_IsValid = GetNiagaraArrayPositionValue_FunctionAddress != IntPtr.Zero && GetNiagaraArrayPositionValue_NiagaraSystem_IsValid && GetNiagaraArrayPositionValue_OverrideName_IsValid && GetNiagaraArrayPositionValue_Index_IsValid && GetNiagaraArrayPositionValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayPositionValue", GetNiagaraArrayPositionValue_IsValid);
		GetNiagaraArrayPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayPosition");
		GetNiagaraArrayPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayPosition_NiagaraSystem_PropertyAddress, GetNiagaraArrayPosition_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayPosition_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayPosition_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayPosition_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayPosition_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayPosition_OverrideName_PropertyAddress, GetNiagaraArrayPosition_FunctionAddress, "OverrideName");
		GetNiagaraArrayPosition_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayPosition_FunctionAddress, "OverrideName");
		GetNiagaraArrayPosition_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayPosition_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayPosition_ReturnValue_PropertyAddress, GetNiagaraArrayPosition_FunctionAddress, "ReturnValue");
		GetNiagaraArrayPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayPosition_FunctionAddress, "ReturnValue");
		GetNiagaraArrayPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayPosition_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNiagaraArrayPosition_IsValid = GetNiagaraArrayPosition_FunctionAddress != IntPtr.Zero && GetNiagaraArrayPosition_NiagaraSystem_IsValid && GetNiagaraArrayPosition_OverrideName_IsValid && GetNiagaraArrayPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayPosition", GetNiagaraArrayPosition_IsValid);
		GetNiagaraArrayInt32Value_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayInt32Value");
		GetNiagaraArrayInt32Value_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayInt32Value_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayInt32Value_NiagaraSystem_PropertyAddress, GetNiagaraArrayInt32Value_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayInt32Value_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayInt32Value_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayInt32Value_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayInt32Value_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayInt32Value_OverrideName_PropertyAddress, GetNiagaraArrayInt32Value_FunctionAddress, "OverrideName");
		GetNiagaraArrayInt32Value_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayInt32Value_FunctionAddress, "OverrideName");
		GetNiagaraArrayInt32Value_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayInt32Value_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayInt32Value_Index_PropertyAddress, GetNiagaraArrayInt32Value_FunctionAddress, "Index");
		GetNiagaraArrayInt32Value_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayInt32Value_FunctionAddress, "Index");
		GetNiagaraArrayInt32Value_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayInt32Value_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayInt32Value_ReturnValue_PropertyAddress, GetNiagaraArrayInt32Value_FunctionAddress, "ReturnValue");
		GetNiagaraArrayInt32Value_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayInt32Value_FunctionAddress, "ReturnValue");
		GetNiagaraArrayInt32Value_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayInt32Value_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNiagaraArrayInt32Value_IsValid = GetNiagaraArrayInt32Value_FunctionAddress != IntPtr.Zero && GetNiagaraArrayInt32Value_NiagaraSystem_IsValid && GetNiagaraArrayInt32Value_OverrideName_IsValid && GetNiagaraArrayInt32Value_Index_IsValid && GetNiagaraArrayInt32Value_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayInt32Value", GetNiagaraArrayInt32Value_IsValid);
		GetNiagaraArrayInt32_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayInt32");
		GetNiagaraArrayInt32_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayInt32_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayInt32_NiagaraSystem_PropertyAddress, GetNiagaraArrayInt32_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayInt32_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayInt32_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayInt32_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayInt32_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayInt32_OverrideName_PropertyAddress, GetNiagaraArrayInt32_FunctionAddress, "OverrideName");
		GetNiagaraArrayInt32_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayInt32_FunctionAddress, "OverrideName");
		GetNiagaraArrayInt32_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayInt32_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayInt32_ReturnValue_PropertyAddress, GetNiagaraArrayInt32_FunctionAddress, "ReturnValue");
		GetNiagaraArrayInt32_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayInt32_FunctionAddress, "ReturnValue");
		GetNiagaraArrayInt32_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayInt32_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNiagaraArrayInt32_IsValid = GetNiagaraArrayInt32_FunctionAddress != IntPtr.Zero && GetNiagaraArrayInt32_NiagaraSystem_IsValid && GetNiagaraArrayInt32_OverrideName_IsValid && GetNiagaraArrayInt32_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayInt32", GetNiagaraArrayInt32_IsValid);
		GetNiagaraArrayFloatValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayFloatValue");
		GetNiagaraArrayFloatValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayFloatValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayFloatValue_NiagaraSystem_PropertyAddress, GetNiagaraArrayFloatValue_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayFloatValue_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayFloatValue_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayFloatValue_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayFloatValue_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayFloatValue_OverrideName_PropertyAddress, GetNiagaraArrayFloatValue_FunctionAddress, "OverrideName");
		GetNiagaraArrayFloatValue_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayFloatValue_FunctionAddress, "OverrideName");
		GetNiagaraArrayFloatValue_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayFloatValue_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayFloatValue_Index_PropertyAddress, GetNiagaraArrayFloatValue_FunctionAddress, "Index");
		GetNiagaraArrayFloatValue_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayFloatValue_FunctionAddress, "Index");
		GetNiagaraArrayFloatValue_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayFloatValue_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayFloatValue_ReturnValue_PropertyAddress, GetNiagaraArrayFloatValue_FunctionAddress, "ReturnValue");
		GetNiagaraArrayFloatValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayFloatValue_FunctionAddress, "ReturnValue");
		GetNiagaraArrayFloatValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayFloatValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetNiagaraArrayFloatValue_IsValid = GetNiagaraArrayFloatValue_FunctionAddress != IntPtr.Zero && GetNiagaraArrayFloatValue_NiagaraSystem_IsValid && GetNiagaraArrayFloatValue_OverrideName_IsValid && GetNiagaraArrayFloatValue_Index_IsValid && GetNiagaraArrayFloatValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayFloatValue", GetNiagaraArrayFloatValue_IsValid);
		GetNiagaraArrayFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayFloat");
		GetNiagaraArrayFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayFloat_NiagaraSystem_PropertyAddress, GetNiagaraArrayFloat_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayFloat_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayFloat_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayFloat_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayFloat_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayFloat_OverrideName_PropertyAddress, GetNiagaraArrayFloat_FunctionAddress, "OverrideName");
		GetNiagaraArrayFloat_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayFloat_FunctionAddress, "OverrideName");
		GetNiagaraArrayFloat_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayFloat_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayFloat_ReturnValue_PropertyAddress, GetNiagaraArrayFloat_FunctionAddress, "ReturnValue");
		GetNiagaraArrayFloat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayFloat_FunctionAddress, "ReturnValue");
		GetNiagaraArrayFloat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayFloat_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNiagaraArrayFloat_IsValid = GetNiagaraArrayFloat_FunctionAddress != IntPtr.Zero && GetNiagaraArrayFloat_NiagaraSystem_IsValid && GetNiagaraArrayFloat_OverrideName_IsValid && GetNiagaraArrayFloat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayFloat", GetNiagaraArrayFloat_IsValid);
		GetNiagaraArrayColorValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayColorValue");
		GetNiagaraArrayColorValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayColorValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayColorValue_NiagaraSystem_PropertyAddress, GetNiagaraArrayColorValue_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayColorValue_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayColorValue_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayColorValue_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayColorValue_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayColorValue_OverrideName_PropertyAddress, GetNiagaraArrayColorValue_FunctionAddress, "OverrideName");
		GetNiagaraArrayColorValue_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayColorValue_FunctionAddress, "OverrideName");
		GetNiagaraArrayColorValue_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayColorValue_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayColorValue_Index_PropertyAddress, GetNiagaraArrayColorValue_FunctionAddress, "Index");
		GetNiagaraArrayColorValue_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayColorValue_FunctionAddress, "Index");
		GetNiagaraArrayColorValue_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayColorValue_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayColorValue_ReturnValue_PropertyAddress, GetNiagaraArrayColorValue_FunctionAddress, "ReturnValue");
		GetNiagaraArrayColorValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayColorValue_FunctionAddress, "ReturnValue");
		GetNiagaraArrayColorValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayColorValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetNiagaraArrayColorValue_IsValid = GetNiagaraArrayColorValue_FunctionAddress != IntPtr.Zero && GetNiagaraArrayColorValue_NiagaraSystem_IsValid && GetNiagaraArrayColorValue_OverrideName_IsValid && GetNiagaraArrayColorValue_Index_IsValid && GetNiagaraArrayColorValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayColorValue", GetNiagaraArrayColorValue_IsValid);
		GetNiagaraArrayColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayColor");
		GetNiagaraArrayColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayColor_NiagaraSystem_PropertyAddress, GetNiagaraArrayColor_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayColor_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayColor_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayColor_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayColor_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayColor_OverrideName_PropertyAddress, GetNiagaraArrayColor_FunctionAddress, "OverrideName");
		GetNiagaraArrayColor_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayColor_FunctionAddress, "OverrideName");
		GetNiagaraArrayColor_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayColor_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayColor_ReturnValue_PropertyAddress, GetNiagaraArrayColor_FunctionAddress, "ReturnValue");
		GetNiagaraArrayColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayColor_FunctionAddress, "ReturnValue");
		GetNiagaraArrayColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayColor_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNiagaraArrayColor_IsValid = GetNiagaraArrayColor_FunctionAddress != IntPtr.Zero && GetNiagaraArrayColor_NiagaraSystem_IsValid && GetNiagaraArrayColor_OverrideName_IsValid && GetNiagaraArrayColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayColor", GetNiagaraArrayColor_IsValid);
		GetNiagaraArrayBoolValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayBoolValue");
		GetNiagaraArrayBoolValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayBoolValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayBoolValue_NiagaraSystem_PropertyAddress, GetNiagaraArrayBoolValue_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayBoolValue_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayBoolValue_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayBoolValue_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayBoolValue_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayBoolValue_OverrideName_PropertyAddress, GetNiagaraArrayBoolValue_FunctionAddress, "OverrideName");
		GetNiagaraArrayBoolValue_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayBoolValue_FunctionAddress, "OverrideName");
		GetNiagaraArrayBoolValue_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayBoolValue_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayBoolValue_Index_PropertyAddress, GetNiagaraArrayBoolValue_FunctionAddress, "Index");
		GetNiagaraArrayBoolValue_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayBoolValue_FunctionAddress, "Index");
		GetNiagaraArrayBoolValue_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayBoolValue_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayBoolValue_ReturnValue_PropertyAddress, GetNiagaraArrayBoolValue_FunctionAddress, "ReturnValue");
		GetNiagaraArrayBoolValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayBoolValue_FunctionAddress, "ReturnValue");
		GetNiagaraArrayBoolValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayBoolValue_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetNiagaraArrayBoolValue_IsValid = GetNiagaraArrayBoolValue_FunctionAddress != IntPtr.Zero && GetNiagaraArrayBoolValue_NiagaraSystem_IsValid && GetNiagaraArrayBoolValue_OverrideName_IsValid && GetNiagaraArrayBoolValue_Index_IsValid && GetNiagaraArrayBoolValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayBoolValue", GetNiagaraArrayBoolValue_IsValid);
		GetNiagaraArrayBool_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraArrayBool");
		GetNiagaraArrayBool_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraArrayBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayBool_NiagaraSystem_PropertyAddress, GetNiagaraArrayBool_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayBool_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayBool_FunctionAddress, "NiagaraSystem");
		GetNiagaraArrayBool_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayBool_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayBool_OverrideName_PropertyAddress, GetNiagaraArrayBool_FunctionAddress, "OverrideName");
		GetNiagaraArrayBool_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayBool_FunctionAddress, "OverrideName");
		GetNiagaraArrayBool_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayBool_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraArrayBool_ReturnValue_PropertyAddress, GetNiagaraArrayBool_FunctionAddress, "ReturnValue");
		GetNiagaraArrayBool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraArrayBool_FunctionAddress, "ReturnValue");
		GetNiagaraArrayBool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraArrayBool_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNiagaraArrayBool_IsValid = GetNiagaraArrayBool_FunctionAddress != IntPtr.Zero && GetNiagaraArrayBool_NiagaraSystem_IsValid && GetNiagaraArrayBool_OverrideName_IsValid && GetNiagaraArrayBool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary:GetNiagaraArrayBool", GetNiagaraArrayBool_IsValid);
	}
}
