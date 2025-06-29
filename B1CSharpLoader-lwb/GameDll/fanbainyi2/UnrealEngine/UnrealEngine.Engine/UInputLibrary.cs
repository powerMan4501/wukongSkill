using System;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.KismetInputLibrary", "Engine", UnrealModuleType.Engine)]
public class UInputLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool PointerEvent_IsTouchEvent_IsValid;

	private static IntPtr PointerEvent_IsTouchEvent_FunctionAddress;

	private static int PointerEvent_IsTouchEvent_ParamsSize;

	private static bool PointerEvent_IsTouchEvent_Input_IsValid;

	private static FFieldAddress PointerEvent_IsTouchEvent_Input_PropertyAddress;

	private static int PointerEvent_IsTouchEvent_Input_Offset;

	private static bool PointerEvent_IsTouchEvent_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_IsTouchEvent_ReturnValue_PropertyAddress;

	private static int PointerEvent_IsTouchEvent_ReturnValue_Offset;

	private static bool PointerEvent_IsMouseButtonDown_IsValid;

	private static IntPtr PointerEvent_IsMouseButtonDown_FunctionAddress;

	private static int PointerEvent_IsMouseButtonDown_ParamsSize;

	private static bool PointerEvent_IsMouseButtonDown_Input_IsValid;

	private static FFieldAddress PointerEvent_IsMouseButtonDown_Input_PropertyAddress;

	private static int PointerEvent_IsMouseButtonDown_Input_Offset;

	private static bool PointerEvent_IsMouseButtonDown_MouseButton_IsValid;

	private static FFieldAddress PointerEvent_IsMouseButtonDown_MouseButton_PropertyAddress;

	private static int PointerEvent_IsMouseButtonDown_MouseButton_Offset;

	private static bool PointerEvent_IsMouseButtonDown_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_IsMouseButtonDown_ReturnValue_PropertyAddress;

	private static int PointerEvent_IsMouseButtonDown_ReturnValue_Offset;

	private static bool PointerEvent_GetWheelDelta_IsValid;

	private static IntPtr PointerEvent_GetWheelDelta_FunctionAddress;

	private static int PointerEvent_GetWheelDelta_ParamsSize;

	private static bool PointerEvent_GetWheelDelta_Input_IsValid;

	private static FFieldAddress PointerEvent_GetWheelDelta_Input_PropertyAddress;

	private static int PointerEvent_GetWheelDelta_Input_Offset;

	private static bool PointerEvent_GetWheelDelta_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_GetWheelDelta_ReturnValue_PropertyAddress;

	private static int PointerEvent_GetWheelDelta_ReturnValue_Offset;

	private static bool PointerEvent_GetUserIndex_IsValid;

	private static IntPtr PointerEvent_GetUserIndex_FunctionAddress;

	private static int PointerEvent_GetUserIndex_ParamsSize;

	private static bool PointerEvent_GetUserIndex_Input_IsValid;

	private static FFieldAddress PointerEvent_GetUserIndex_Input_PropertyAddress;

	private static int PointerEvent_GetUserIndex_Input_Offset;

	private static bool PointerEvent_GetUserIndex_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_GetUserIndex_ReturnValue_PropertyAddress;

	private static int PointerEvent_GetUserIndex_ReturnValue_Offset;

	private static bool PointerEvent_GetTouchpadIndex_IsValid;

	private static IntPtr PointerEvent_GetTouchpadIndex_FunctionAddress;

	private static int PointerEvent_GetTouchpadIndex_ParamsSize;

	private static bool PointerEvent_GetTouchpadIndex_Input_IsValid;

	private static FFieldAddress PointerEvent_GetTouchpadIndex_Input_PropertyAddress;

	private static int PointerEvent_GetTouchpadIndex_Input_Offset;

	private static bool PointerEvent_GetTouchpadIndex_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_GetTouchpadIndex_ReturnValue_PropertyAddress;

	private static int PointerEvent_GetTouchpadIndex_ReturnValue_Offset;

	private static bool PointerEvent_GetScreenSpacePosition_IsValid;

	private static IntPtr PointerEvent_GetScreenSpacePosition_FunctionAddress;

	private static int PointerEvent_GetScreenSpacePosition_ParamsSize;

	private static bool PointerEvent_GetScreenSpacePosition_Input_IsValid;

	private static FFieldAddress PointerEvent_GetScreenSpacePosition_Input_PropertyAddress;

	private static int PointerEvent_GetScreenSpacePosition_Input_Offset;

	private static bool PointerEvent_GetScreenSpacePosition_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_GetScreenSpacePosition_ReturnValue_PropertyAddress;

	private static int PointerEvent_GetScreenSpacePosition_ReturnValue_Offset;

	private static bool PointerEvent_GetPointerIndex_IsValid;

	private static IntPtr PointerEvent_GetPointerIndex_FunctionAddress;

	private static int PointerEvent_GetPointerIndex_ParamsSize;

	private static bool PointerEvent_GetPointerIndex_Input_IsValid;

	private static FFieldAddress PointerEvent_GetPointerIndex_Input_PropertyAddress;

	private static int PointerEvent_GetPointerIndex_Input_Offset;

	private static bool PointerEvent_GetPointerIndex_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_GetPointerIndex_ReturnValue_PropertyAddress;

	private static int PointerEvent_GetPointerIndex_ReturnValue_Offset;

	private static bool PointerEvent_GetLastScreenSpacePosition_IsValid;

	private static IntPtr PointerEvent_GetLastScreenSpacePosition_FunctionAddress;

	private static int PointerEvent_GetLastScreenSpacePosition_ParamsSize;

	private static bool PointerEvent_GetLastScreenSpacePosition_Input_IsValid;

	private static FFieldAddress PointerEvent_GetLastScreenSpacePosition_Input_PropertyAddress;

	private static int PointerEvent_GetLastScreenSpacePosition_Input_Offset;

	private static bool PointerEvent_GetLastScreenSpacePosition_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_GetLastScreenSpacePosition_ReturnValue_PropertyAddress;

	private static int PointerEvent_GetLastScreenSpacePosition_ReturnValue_Offset;

	private static bool PointerEvent_GetGestureType_IsValid;

	private static IntPtr PointerEvent_GetGestureType_FunctionAddress;

	private static int PointerEvent_GetGestureType_ParamsSize;

	private static bool PointerEvent_GetGestureType_Input_IsValid;

	private static FFieldAddress PointerEvent_GetGestureType_Input_PropertyAddress;

	private static int PointerEvent_GetGestureType_Input_Offset;

	private static bool PointerEvent_GetGestureType_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_GetGestureType_ReturnValue_PropertyAddress;

	private static int PointerEvent_GetGestureType_ReturnValue_Offset;

	private static bool PointerEvent_GetGestureDelta_IsValid;

	private static IntPtr PointerEvent_GetGestureDelta_FunctionAddress;

	private static int PointerEvent_GetGestureDelta_ParamsSize;

	private static bool PointerEvent_GetGestureDelta_Input_IsValid;

	private static FFieldAddress PointerEvent_GetGestureDelta_Input_PropertyAddress;

	private static int PointerEvent_GetGestureDelta_Input_Offset;

	private static bool PointerEvent_GetGestureDelta_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_GetGestureDelta_ReturnValue_PropertyAddress;

	private static int PointerEvent_GetGestureDelta_ReturnValue_Offset;

	private static bool PointerEvent_GetEffectingButton_IsValid;

	private static IntPtr PointerEvent_GetEffectingButton_FunctionAddress;

	private static int PointerEvent_GetEffectingButton_ParamsSize;

	private static bool PointerEvent_GetEffectingButton_Input_IsValid;

	private static FFieldAddress PointerEvent_GetEffectingButton_Input_PropertyAddress;

	private static int PointerEvent_GetEffectingButton_Input_Offset;

	private static bool PointerEvent_GetEffectingButton_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_GetEffectingButton_ReturnValue_PropertyAddress;

	private static int PointerEvent_GetEffectingButton_ReturnValue_Offset;

	private static bool PointerEvent_GetCursorDelta_IsValid;

	private static IntPtr PointerEvent_GetCursorDelta_FunctionAddress;

	private static int PointerEvent_GetCursorDelta_ParamsSize;

	private static bool PointerEvent_GetCursorDelta_Input_IsValid;

	private static FFieldAddress PointerEvent_GetCursorDelta_Input_PropertyAddress;

	private static int PointerEvent_GetCursorDelta_Input_Offset;

	private static bool PointerEvent_GetCursorDelta_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_GetCursorDelta_ReturnValue_PropertyAddress;

	private static int PointerEvent_GetCursorDelta_ReturnValue_Offset;

	private static bool Key_IsValid_IsValid;

	private static IntPtr Key_IsValid_FunctionAddress;

	private static int Key_IsValid_ParamsSize;

	private static bool Key_IsValid_Key_IsValid;

	private static FFieldAddress Key_IsValid_Key_PropertyAddress;

	private static int Key_IsValid_Key_Offset;

	private static bool Key_IsValid_ReturnValue_IsValid;

	private static FFieldAddress Key_IsValid_ReturnValue_PropertyAddress;

	private static int Key_IsValid_ReturnValue_Offset;

	private static bool Key_IsMouseButton_IsValid;

	private static IntPtr Key_IsMouseButton_FunctionAddress;

	private static int Key_IsMouseButton_ParamsSize;

	private static bool Key_IsMouseButton_Key_IsValid;

	private static FFieldAddress Key_IsMouseButton_Key_PropertyAddress;

	private static int Key_IsMouseButton_Key_Offset;

	private static bool Key_IsMouseButton_ReturnValue_IsValid;

	private static FFieldAddress Key_IsMouseButton_ReturnValue_PropertyAddress;

	private static int Key_IsMouseButton_ReturnValue_Offset;

	private static bool Key_IsModifierKey_IsValid;

	private static IntPtr Key_IsModifierKey_FunctionAddress;

	private static int Key_IsModifierKey_ParamsSize;

	private static bool Key_IsModifierKey_Key_IsValid;

	private static FFieldAddress Key_IsModifierKey_Key_PropertyAddress;

	private static int Key_IsModifierKey_Key_Offset;

	private static bool Key_IsModifierKey_ReturnValue_IsValid;

	private static FFieldAddress Key_IsModifierKey_ReturnValue_PropertyAddress;

	private static int Key_IsModifierKey_ReturnValue_Offset;

	private static bool Key_IsKeyboardKey_IsValid;

	private static IntPtr Key_IsKeyboardKey_FunctionAddress;

	private static int Key_IsKeyboardKey_ParamsSize;

	private static bool Key_IsKeyboardKey_Key_IsValid;

	private static FFieldAddress Key_IsKeyboardKey_Key_PropertyAddress;

	private static int Key_IsKeyboardKey_Key_Offset;

	private static bool Key_IsKeyboardKey_ReturnValue_IsValid;

	private static FFieldAddress Key_IsKeyboardKey_ReturnValue_PropertyAddress;

	private static int Key_IsKeyboardKey_ReturnValue_Offset;

	private static bool Key_IsGamepadKey_IsValid;

	private static IntPtr Key_IsGamepadKey_FunctionAddress;

	private static int Key_IsGamepadKey_ParamsSize;

	private static bool Key_IsGamepadKey_Key_IsValid;

	private static FFieldAddress Key_IsGamepadKey_Key_PropertyAddress;

	private static int Key_IsGamepadKey_Key_Offset;

	private static bool Key_IsGamepadKey_ReturnValue_IsValid;

	private static FFieldAddress Key_IsGamepadKey_ReturnValue_PropertyAddress;

	private static int Key_IsGamepadKey_ReturnValue_Offset;

	private static bool Key_IsDigital_IsValid;

	private static IntPtr Key_IsDigital_FunctionAddress;

	private static int Key_IsDigital_ParamsSize;

	private static bool Key_IsDigital_Key_IsValid;

	private static FFieldAddress Key_IsDigital_Key_PropertyAddress;

	private static int Key_IsDigital_Key_Offset;

	private static bool Key_IsDigital_ReturnValue_IsValid;

	private static FFieldAddress Key_IsDigital_ReturnValue_PropertyAddress;

	private static int Key_IsDigital_ReturnValue_Offset;

	private static bool Key_IsButtonAxis_IsValid;

	private static IntPtr Key_IsButtonAxis_FunctionAddress;

	private static int Key_IsButtonAxis_ParamsSize;

	private static bool Key_IsButtonAxis_Key_IsValid;

	private static FFieldAddress Key_IsButtonAxis_Key_PropertyAddress;

	private static int Key_IsButtonAxis_Key_Offset;

	private static bool Key_IsButtonAxis_ReturnValue_IsValid;

	private static FFieldAddress Key_IsButtonAxis_ReturnValue_PropertyAddress;

	private static int Key_IsButtonAxis_ReturnValue_Offset;

	private static bool Key_IsAxis3D_IsValid;

	private static IntPtr Key_IsAxis3D_FunctionAddress;

	private static int Key_IsAxis3D_ParamsSize;

	private static bool Key_IsAxis3D_Key_IsValid;

	private static FFieldAddress Key_IsAxis3D_Key_PropertyAddress;

	private static int Key_IsAxis3D_Key_Offset;

	private static bool Key_IsAxis3D_ReturnValue_IsValid;

	private static FFieldAddress Key_IsAxis3D_ReturnValue_PropertyAddress;

	private static int Key_IsAxis3D_ReturnValue_Offset;

	private static bool Key_IsAxis2D_IsValid;

	private static IntPtr Key_IsAxis2D_FunctionAddress;

	private static int Key_IsAxis2D_ParamsSize;

	private static bool Key_IsAxis2D_Key_IsValid;

	private static FFieldAddress Key_IsAxis2D_Key_PropertyAddress;

	private static int Key_IsAxis2D_Key_Offset;

	private static bool Key_IsAxis2D_ReturnValue_IsValid;

	private static FFieldAddress Key_IsAxis2D_ReturnValue_PropertyAddress;

	private static int Key_IsAxis2D_ReturnValue_Offset;

	private static bool Key_IsAxis1D_IsValid;

	private static IntPtr Key_IsAxis1D_FunctionAddress;

	private static int Key_IsAxis1D_ParamsSize;

	private static bool Key_IsAxis1D_Key_IsValid;

	private static FFieldAddress Key_IsAxis1D_Key_PropertyAddress;

	private static int Key_IsAxis1D_Key_Offset;

	private static bool Key_IsAxis1D_ReturnValue_IsValid;

	private static FFieldAddress Key_IsAxis1D_ReturnValue_PropertyAddress;

	private static int Key_IsAxis1D_ReturnValue_Offset;

	private static bool Key_IsAnalog_IsValid;

	private static IntPtr Key_IsAnalog_FunctionAddress;

	private static int Key_IsAnalog_ParamsSize;

	private static bool Key_IsAnalog_Key_IsValid;

	private static FFieldAddress Key_IsAnalog_Key_PropertyAddress;

	private static int Key_IsAnalog_Key_Offset;

	private static bool Key_IsAnalog_ReturnValue_IsValid;

	private static FFieldAddress Key_IsAnalog_ReturnValue_PropertyAddress;

	private static int Key_IsAnalog_ReturnValue_Offset;

	private static bool Key_GetNavigationDirectionFromKey_IsValid;

	private static IntPtr Key_GetNavigationDirectionFromKey_FunctionAddress;

	private static int Key_GetNavigationDirectionFromKey_ParamsSize;

	private static bool Key_GetNavigationDirectionFromKey_InKeyEvent_IsValid;

	private static FFieldAddress Key_GetNavigationDirectionFromKey_InKeyEvent_PropertyAddress;

	private static int Key_GetNavigationDirectionFromKey_InKeyEvent_Offset;

	private static bool Key_GetNavigationDirectionFromKey_ReturnValue_IsValid;

	private static FFieldAddress Key_GetNavigationDirectionFromKey_ReturnValue_PropertyAddress;

	private static int Key_GetNavigationDirectionFromKey_ReturnValue_Offset;

	private static bool Key_GetNavigationDirectionFromAnalog_IsValid;

	private static IntPtr Key_GetNavigationDirectionFromAnalog_FunctionAddress;

	private static int Key_GetNavigationDirectionFromAnalog_ParamsSize;

	private static bool Key_GetNavigationDirectionFromAnalog_InAnalogEvent_IsValid;

	private static FFieldAddress Key_GetNavigationDirectionFromAnalog_InAnalogEvent_PropertyAddress;

	private static int Key_GetNavigationDirectionFromAnalog_InAnalogEvent_Offset;

	private static bool Key_GetNavigationDirectionFromAnalog_ReturnValue_IsValid;

	private static FFieldAddress Key_GetNavigationDirectionFromAnalog_ReturnValue_PropertyAddress;

	private static int Key_GetNavigationDirectionFromAnalog_ReturnValue_Offset;

	private static bool Key_GetNavigationActionFromKey_IsValid;

	private static IntPtr Key_GetNavigationActionFromKey_FunctionAddress;

	private static int Key_GetNavigationActionFromKey_ParamsSize;

	private static bool Key_GetNavigationActionFromKey_InKeyEvent_IsValid;

	private static FFieldAddress Key_GetNavigationActionFromKey_InKeyEvent_PropertyAddress;

	private static int Key_GetNavigationActionFromKey_InKeyEvent_Offset;

	private static bool Key_GetNavigationActionFromKey_ReturnValue_IsValid;

	private static FFieldAddress Key_GetNavigationActionFromKey_ReturnValue_PropertyAddress;

	private static int Key_GetNavigationActionFromKey_ReturnValue_Offset;

	private static bool Key_GetDisplayName_IsValid;

	private static IntPtr Key_GetDisplayName_FunctionAddress;

	private static int Key_GetDisplayName_ParamsSize;

	private static bool Key_GetDisplayName_Key_IsValid;

	private static FFieldAddress Key_GetDisplayName_Key_PropertyAddress;

	private static int Key_GetDisplayName_Key_Offset;

	private static bool Key_GetDisplayName_ReturnValue_IsValid;

	private static FFieldAddress Key_GetDisplayName_ReturnValue_PropertyAddress;

	private static int Key_GetDisplayName_ReturnValue_Offset;

	private static bool InputEvent_IsShiftDown_IsValid;

	private static IntPtr InputEvent_IsShiftDown_FunctionAddress;

	private static int InputEvent_IsShiftDown_ParamsSize;

	private static bool InputEvent_IsShiftDown_Input_IsValid;

	private static FFieldAddress InputEvent_IsShiftDown_Input_PropertyAddress;

	private static int InputEvent_IsShiftDown_Input_Offset;

	private static bool InputEvent_IsShiftDown_ReturnValue_IsValid;

	private static FFieldAddress InputEvent_IsShiftDown_ReturnValue_PropertyAddress;

	private static int InputEvent_IsShiftDown_ReturnValue_Offset;

	private static bool InputEvent_IsRightShiftDown_IsValid;

	private static IntPtr InputEvent_IsRightShiftDown_FunctionAddress;

	private static int InputEvent_IsRightShiftDown_ParamsSize;

	private static bool InputEvent_IsRightShiftDown_Input_IsValid;

	private static FFieldAddress InputEvent_IsRightShiftDown_Input_PropertyAddress;

	private static int InputEvent_IsRightShiftDown_Input_Offset;

	private static bool InputEvent_IsRightShiftDown_ReturnValue_IsValid;

	private static FFieldAddress InputEvent_IsRightShiftDown_ReturnValue_PropertyAddress;

	private static int InputEvent_IsRightShiftDown_ReturnValue_Offset;

	private static bool InputEvent_IsRightControlDown_IsValid;

	private static IntPtr InputEvent_IsRightControlDown_FunctionAddress;

	private static int InputEvent_IsRightControlDown_ParamsSize;

	private static bool InputEvent_IsRightControlDown_Input_IsValid;

	private static FFieldAddress InputEvent_IsRightControlDown_Input_PropertyAddress;

	private static int InputEvent_IsRightControlDown_Input_Offset;

	private static bool InputEvent_IsRightControlDown_ReturnValue_IsValid;

	private static FFieldAddress InputEvent_IsRightControlDown_ReturnValue_PropertyAddress;

	private static int InputEvent_IsRightControlDown_ReturnValue_Offset;

	private static bool InputEvent_IsRightCommandDown_IsValid;

	private static IntPtr InputEvent_IsRightCommandDown_FunctionAddress;

	private static int InputEvent_IsRightCommandDown_ParamsSize;

	private static bool InputEvent_IsRightCommandDown_Input_IsValid;

	private static FFieldAddress InputEvent_IsRightCommandDown_Input_PropertyAddress;

	private static int InputEvent_IsRightCommandDown_Input_Offset;

	private static bool InputEvent_IsRightCommandDown_ReturnValue_IsValid;

	private static FFieldAddress InputEvent_IsRightCommandDown_ReturnValue_PropertyAddress;

	private static int InputEvent_IsRightCommandDown_ReturnValue_Offset;

	private static bool InputEvent_IsRightAltDown_IsValid;

	private static IntPtr InputEvent_IsRightAltDown_FunctionAddress;

	private static int InputEvent_IsRightAltDown_ParamsSize;

	private static bool InputEvent_IsRightAltDown_Input_IsValid;

	private static FFieldAddress InputEvent_IsRightAltDown_Input_PropertyAddress;

	private static int InputEvent_IsRightAltDown_Input_Offset;

	private static bool InputEvent_IsRightAltDown_ReturnValue_IsValid;

	private static FFieldAddress InputEvent_IsRightAltDown_ReturnValue_PropertyAddress;

	private static int InputEvent_IsRightAltDown_ReturnValue_Offset;

	private static bool InputEvent_IsRepeat_IsValid;

	private static IntPtr InputEvent_IsRepeat_FunctionAddress;

	private static int InputEvent_IsRepeat_ParamsSize;

	private static bool InputEvent_IsRepeat_Input_IsValid;

	private static FFieldAddress InputEvent_IsRepeat_Input_PropertyAddress;

	private static int InputEvent_IsRepeat_Input_Offset;

	private static bool InputEvent_IsRepeat_ReturnValue_IsValid;

	private static FFieldAddress InputEvent_IsRepeat_ReturnValue_PropertyAddress;

	private static int InputEvent_IsRepeat_ReturnValue_Offset;

	private static bool InputEvent_IsLeftShiftDown_IsValid;

	private static IntPtr InputEvent_IsLeftShiftDown_FunctionAddress;

	private static int InputEvent_IsLeftShiftDown_ParamsSize;

	private static bool InputEvent_IsLeftShiftDown_Input_IsValid;

	private static FFieldAddress InputEvent_IsLeftShiftDown_Input_PropertyAddress;

	private static int InputEvent_IsLeftShiftDown_Input_Offset;

	private static bool InputEvent_IsLeftShiftDown_ReturnValue_IsValid;

	private static FFieldAddress InputEvent_IsLeftShiftDown_ReturnValue_PropertyAddress;

	private static int InputEvent_IsLeftShiftDown_ReturnValue_Offset;

	private static bool InputEvent_IsLeftControlDown_IsValid;

	private static IntPtr InputEvent_IsLeftControlDown_FunctionAddress;

	private static int InputEvent_IsLeftControlDown_ParamsSize;

	private static bool InputEvent_IsLeftControlDown_Input_IsValid;

	private static FFieldAddress InputEvent_IsLeftControlDown_Input_PropertyAddress;

	private static int InputEvent_IsLeftControlDown_Input_Offset;

	private static bool InputEvent_IsLeftControlDown_ReturnValue_IsValid;

	private static FFieldAddress InputEvent_IsLeftControlDown_ReturnValue_PropertyAddress;

	private static int InputEvent_IsLeftControlDown_ReturnValue_Offset;

	private static bool InputEvent_IsLeftCommandDown_IsValid;

	private static IntPtr InputEvent_IsLeftCommandDown_FunctionAddress;

	private static int InputEvent_IsLeftCommandDown_ParamsSize;

	private static bool InputEvent_IsLeftCommandDown_Input_IsValid;

	private static FFieldAddress InputEvent_IsLeftCommandDown_Input_PropertyAddress;

	private static int InputEvent_IsLeftCommandDown_Input_Offset;

	private static bool InputEvent_IsLeftCommandDown_ReturnValue_IsValid;

	private static FFieldAddress InputEvent_IsLeftCommandDown_ReturnValue_PropertyAddress;

	private static int InputEvent_IsLeftCommandDown_ReturnValue_Offset;

	private static bool InputEvent_IsLeftAltDown_IsValid;

	private static IntPtr InputEvent_IsLeftAltDown_FunctionAddress;

	private static int InputEvent_IsLeftAltDown_ParamsSize;

	private static bool InputEvent_IsLeftAltDown_Input_IsValid;

	private static FFieldAddress InputEvent_IsLeftAltDown_Input_PropertyAddress;

	private static int InputEvent_IsLeftAltDown_Input_Offset;

	private static bool InputEvent_IsLeftAltDown_ReturnValue_IsValid;

	private static FFieldAddress InputEvent_IsLeftAltDown_ReturnValue_PropertyAddress;

	private static int InputEvent_IsLeftAltDown_ReturnValue_Offset;

	private static bool InputEvent_IsControlDown_IsValid;

	private static IntPtr InputEvent_IsControlDown_FunctionAddress;

	private static int InputEvent_IsControlDown_ParamsSize;

	private static bool InputEvent_IsControlDown_Input_IsValid;

	private static FFieldAddress InputEvent_IsControlDown_Input_PropertyAddress;

	private static int InputEvent_IsControlDown_Input_Offset;

	private static bool InputEvent_IsControlDown_ReturnValue_IsValid;

	private static FFieldAddress InputEvent_IsControlDown_ReturnValue_PropertyAddress;

	private static int InputEvent_IsControlDown_ReturnValue_Offset;

	private static bool InputEvent_IsCommandDown_IsValid;

	private static IntPtr InputEvent_IsCommandDown_FunctionAddress;

	private static int InputEvent_IsCommandDown_ParamsSize;

	private static bool InputEvent_IsCommandDown_Input_IsValid;

	private static FFieldAddress InputEvent_IsCommandDown_Input_PropertyAddress;

	private static int InputEvent_IsCommandDown_Input_Offset;

	private static bool InputEvent_IsCommandDown_ReturnValue_IsValid;

	private static FFieldAddress InputEvent_IsCommandDown_ReturnValue_PropertyAddress;

	private static int InputEvent_IsCommandDown_ReturnValue_Offset;

	private static bool InputEvent_IsAltDown_IsValid;

	private static IntPtr InputEvent_IsAltDown_FunctionAddress;

	private static int InputEvent_IsAltDown_ParamsSize;

	private static bool InputEvent_IsAltDown_Input_IsValid;

	private static FFieldAddress InputEvent_IsAltDown_Input_PropertyAddress;

	private static int InputEvent_IsAltDown_Input_Offset;

	private static bool InputEvent_IsAltDown_ReturnValue_IsValid;

	private static FFieldAddress InputEvent_IsAltDown_ReturnValue_PropertyAddress;

	private static int InputEvent_IsAltDown_ReturnValue_Offset;

	private static bool InputChord_GetDisplayName_IsValid;

	private static IntPtr InputChord_GetDisplayName_FunctionAddress;

	private static int InputChord_GetDisplayName_ParamsSize;

	private static bool InputChord_GetDisplayName_Key_IsValid;

	private static FFieldAddress InputChord_GetDisplayName_Key_PropertyAddress;

	private static int InputChord_GetDisplayName_Key_Offset;

	private static bool InputChord_GetDisplayName_ReturnValue_IsValid;

	private static FFieldAddress InputChord_GetDisplayName_ReturnValue_PropertyAddress;

	private static int InputChord_GetDisplayName_ReturnValue_Offset;

	private static bool GetUserIndex_IsValid;

	private static IntPtr GetUserIndex_FunctionAddress;

	private static int GetUserIndex_ParamsSize;

	private static bool GetUserIndex_Input_IsValid;

	private static FFieldAddress GetUserIndex_Input_PropertyAddress;

	private static int GetUserIndex_Input_Offset;

	private static bool GetUserIndex_ReturnValue_IsValid;

	private static FFieldAddress GetUserIndex_ReturnValue_PropertyAddress;

	private static int GetUserIndex_ReturnValue_Offset;

	private static bool GetKey_IsValid;

	private static IntPtr GetKey_FunctionAddress;

	private static int GetKey_ParamsSize;

	private static bool GetKey_Input_IsValid;

	private static FFieldAddress GetKey_Input_PropertyAddress;

	private static int GetKey_Input_Offset;

	private static bool GetKey_ReturnValue_IsValid;

	private static FFieldAddress GetKey_ReturnValue_PropertyAddress;

	private static int GetKey_ReturnValue_Offset;

	private static bool GetAnalogValue_IsValid;

	private static IntPtr GetAnalogValue_FunctionAddress;

	private static int GetAnalogValue_ParamsSize;

	private static bool GetAnalogValue_Input_IsValid;

	private static FFieldAddress GetAnalogValue_Input_PropertyAddress;

	private static int GetAnalogValue_Input_Offset;

	private static bool GetAnalogValue_ReturnValue_IsValid;

	private static FFieldAddress GetAnalogValue_ReturnValue_PropertyAddress;

	private static int GetAnalogValue_ReturnValue_Offset;

	private static bool EqualEqual_KeyKey_IsValid;

	private static IntPtr EqualEqual_KeyKey_FunctionAddress;

	private static int EqualEqual_KeyKey_ParamsSize;

	private static bool EqualEqual_KeyKey_A_IsValid;

	private static FFieldAddress EqualEqual_KeyKey_A_PropertyAddress;

	private static int EqualEqual_KeyKey_A_Offset;

	private static bool EqualEqual_KeyKey_B_IsValid;

	private static FFieldAddress EqualEqual_KeyKey_B_PropertyAddress;

	private static int EqualEqual_KeyKey_B_Offset;

	private static bool EqualEqual_KeyKey_ReturnValue_IsValid;

	private static FFieldAddress EqualEqual_KeyKey_ReturnValue_PropertyAddress;

	private static int EqualEqual_KeyKey_ReturnValue_Offset;

	private static bool EqualEqual_InputChordInputChord_IsValid;

	private static IntPtr EqualEqual_InputChordInputChord_FunctionAddress;

	private static int EqualEqual_InputChordInputChord_ParamsSize;

	private static bool EqualEqual_InputChordInputChord_A_IsValid;

	private static FFieldAddress EqualEqual_InputChordInputChord_A_PropertyAddress;

	private static int EqualEqual_InputChordInputChord_A_Offset;

	private static bool EqualEqual_InputChordInputChord_B_IsValid;

	private static FFieldAddress EqualEqual_InputChordInputChord_B_PropertyAddress;

	private static int EqualEqual_InputChordInputChord_B_Offset;

	private static bool EqualEqual_InputChordInputChord_ReturnValue_IsValid;

	private static FFieldAddress EqualEqual_InputChordInputChord_ReturnValue_PropertyAddress;

	private static int EqualEqual_InputChordInputChord_ReturnValue_Offset;

	private static bool CalibrateTilt_IsValid;

	private static IntPtr CalibrateTilt_FunctionAddress;

	private static int CalibrateTilt_ParamsSize;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:PointerEvent_IsTouchEvent")]
	public unsafe static bool PointerEvent_IsTouchEvent(FPointerEvent Input)
	{
		if (!PointerEvent_IsTouchEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:PointerEvent_IsTouchEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_IsTouchEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_IsTouchEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_IsTouchEvent_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_IsTouchEvent_Input_Offset), 0, PointerEvent_IsTouchEvent_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_IsTouchEvent_FunctionAddress, intPtr, PointerEvent_IsTouchEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_IsTouchEvent_Input_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PointerEvent_IsTouchEvent_ReturnValue_Offset), 0, PointerEvent_IsTouchEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:PointerEvent_IsMouseButtonDown")]
	public unsafe static bool PointerEvent_IsMouseButtonDown(FPointerEvent Input, FKey MouseButton)
	{
		if (!PointerEvent_IsMouseButtonDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:PointerEvent_IsMouseButtonDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_IsMouseButtonDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_IsMouseButtonDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_IsMouseButtonDown_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_IsMouseButtonDown_Input_Offset), 0, PointerEvent_IsMouseButtonDown_Input_PropertyAddress.Address, Input);
		NativeReflection.InitializeValue_InContainer(PointerEvent_IsMouseButtonDown_MouseButton_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, PointerEvent_IsMouseButtonDown_MouseButton_Offset), 0, PointerEvent_IsMouseButtonDown_MouseButton_PropertyAddress.Address, MouseButton);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_IsMouseButtonDown_FunctionAddress, intPtr, PointerEvent_IsMouseButtonDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_IsMouseButtonDown_Input_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PointerEvent_IsMouseButtonDown_MouseButton_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PointerEvent_IsMouseButtonDown_ReturnValue_Offset), 0, PointerEvent_IsMouseButtonDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:PointerEvent_GetWheelDelta")]
	public unsafe static float PointerEvent_GetWheelDelta(FPointerEvent Input)
	{
		if (!PointerEvent_GetWheelDelta_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:PointerEvent_GetWheelDelta");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_GetWheelDelta_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_GetWheelDelta_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_GetWheelDelta_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_GetWheelDelta_Input_Offset), 0, PointerEvent_GetWheelDelta_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_GetWheelDelta_FunctionAddress, intPtr, PointerEvent_GetWheelDelta_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_GetWheelDelta_Input_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, PointerEvent_GetWheelDelta_ReturnValue_Offset), 0, PointerEvent_GetWheelDelta_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:PointerEvent_GetUserIndex")]
	public unsafe static int PointerEvent_GetUserIndex(FPointerEvent Input)
	{
		if (!PointerEvent_GetUserIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:PointerEvent_GetUserIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_GetUserIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_GetUserIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_GetUserIndex_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_GetUserIndex_Input_Offset), 0, PointerEvent_GetUserIndex_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_GetUserIndex_FunctionAddress, intPtr, PointerEvent_GetUserIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_GetUserIndex_Input_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PointerEvent_GetUserIndex_ReturnValue_Offset), 0, PointerEvent_GetUserIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:PointerEvent_GetTouchpadIndex")]
	public unsafe static int PointerEvent_GetTouchpadIndex(FPointerEvent Input)
	{
		if (!PointerEvent_GetTouchpadIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:PointerEvent_GetTouchpadIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_GetTouchpadIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_GetTouchpadIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_GetTouchpadIndex_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_GetTouchpadIndex_Input_Offset), 0, PointerEvent_GetTouchpadIndex_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_GetTouchpadIndex_FunctionAddress, intPtr, PointerEvent_GetTouchpadIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_GetTouchpadIndex_Input_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PointerEvent_GetTouchpadIndex_ReturnValue_Offset), 0, PointerEvent_GetTouchpadIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:PointerEvent_GetScreenSpacePosition")]
	public unsafe static FVector2D PointerEvent_GetScreenSpacePosition(FPointerEvent Input)
	{
		if (!PointerEvent_GetScreenSpacePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:PointerEvent_GetScreenSpacePosition");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_GetScreenSpacePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_GetScreenSpacePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_GetScreenSpacePosition_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_GetScreenSpacePosition_Input_Offset), 0, PointerEvent_GetScreenSpacePosition_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_GetScreenSpacePosition_FunctionAddress, intPtr, PointerEvent_GetScreenSpacePosition_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_GetScreenSpacePosition_Input_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, PointerEvent_GetScreenSpacePosition_ReturnValue_Offset), 0, PointerEvent_GetScreenSpacePosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:PointerEvent_GetPointerIndex")]
	public unsafe static int PointerEvent_GetPointerIndex(FPointerEvent Input)
	{
		if (!PointerEvent_GetPointerIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:PointerEvent_GetPointerIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_GetPointerIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_GetPointerIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_GetPointerIndex_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_GetPointerIndex_Input_Offset), 0, PointerEvent_GetPointerIndex_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_GetPointerIndex_FunctionAddress, intPtr, PointerEvent_GetPointerIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_GetPointerIndex_Input_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PointerEvent_GetPointerIndex_ReturnValue_Offset), 0, PointerEvent_GetPointerIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:PointerEvent_GetLastScreenSpacePosition")]
	public unsafe static FVector2D PointerEvent_GetLastScreenSpacePosition(FPointerEvent Input)
	{
		if (!PointerEvent_GetLastScreenSpacePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:PointerEvent_GetLastScreenSpacePosition");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_GetLastScreenSpacePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_GetLastScreenSpacePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_GetLastScreenSpacePosition_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_GetLastScreenSpacePosition_Input_Offset), 0, PointerEvent_GetLastScreenSpacePosition_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_GetLastScreenSpacePosition_FunctionAddress, intPtr, PointerEvent_GetLastScreenSpacePosition_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_GetLastScreenSpacePosition_Input_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, PointerEvent_GetLastScreenSpacePosition_ReturnValue_Offset), 0, PointerEvent_GetLastScreenSpacePosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:PointerEvent_GetGestureType")]
	public unsafe static ESlateGesture PointerEvent_GetGestureType(FPointerEvent Input)
	{
		if (!PointerEvent_GetGestureType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:PointerEvent_GetGestureType");
			return ESlateGesture.None;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_GetGestureType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_GetGestureType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_GetGestureType_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_GetGestureType_Input_Offset), 0, PointerEvent_GetGestureType_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_GetGestureType_FunctionAddress, intPtr, PointerEvent_GetGestureType_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_GetGestureType_Input_PropertyAddress.Address, intPtr);
		return EnumMarshaler<ESlateGesture>.FromNative(IntPtr.Add(intPtr, PointerEvent_GetGestureType_ReturnValue_Offset), 0, PointerEvent_GetGestureType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:PointerEvent_GetGestureDelta")]
	public unsafe static FVector2D PointerEvent_GetGestureDelta(FPointerEvent Input)
	{
		if (!PointerEvent_GetGestureDelta_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:PointerEvent_GetGestureDelta");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_GetGestureDelta_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_GetGestureDelta_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_GetGestureDelta_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_GetGestureDelta_Input_Offset), 0, PointerEvent_GetGestureDelta_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_GetGestureDelta_FunctionAddress, intPtr, PointerEvent_GetGestureDelta_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_GetGestureDelta_Input_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, PointerEvent_GetGestureDelta_ReturnValue_Offset), 0, PointerEvent_GetGestureDelta_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:PointerEvent_GetEffectingButton")]
	public unsafe static FKey PointerEvent_GetEffectingButton(FPointerEvent Input)
	{
		if (!PointerEvent_GetEffectingButton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:PointerEvent_GetEffectingButton");
			return default(FKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_GetEffectingButton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_GetEffectingButton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_GetEffectingButton_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_GetEffectingButton_Input_Offset), 0, PointerEvent_GetEffectingButton_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_GetEffectingButton_FunctionAddress, intPtr, PointerEvent_GetEffectingButton_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_GetEffectingButton_Input_PropertyAddress.Address, intPtr);
		FKey result = FKey.FromNative(IntPtr.Add(intPtr, PointerEvent_GetEffectingButton_ReturnValue_Offset), 0, PointerEvent_GetEffectingButton_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(PointerEvent_GetEffectingButton_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:PointerEvent_GetCursorDelta")]
	public unsafe static FVector2D PointerEvent_GetCursorDelta(FPointerEvent Input)
	{
		if (!PointerEvent_GetCursorDelta_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:PointerEvent_GetCursorDelta");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_GetCursorDelta_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_GetCursorDelta_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_GetCursorDelta_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_GetCursorDelta_Input_Offset), 0, PointerEvent_GetCursorDelta_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_GetCursorDelta_FunctionAddress, intPtr, PointerEvent_GetCursorDelta_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_GetCursorDelta_Input_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, PointerEvent_GetCursorDelta_ReturnValue_Offset), 0, PointerEvent_GetCursorDelta_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_IsValid")]
	public unsafe static bool Key_IsValid(FKey Key)
	{
		if (!Key_IsValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_IsValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_IsValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_IsValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_IsValid_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, Key_IsValid_Key_Offset), 0, Key_IsValid_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_IsValid_FunctionAddress, intPtr, Key_IsValid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_IsValid_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Key_IsValid_ReturnValue_Offset), 0, Key_IsValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_IsMouseButton")]
	public unsafe static bool Key_IsMouseButton(FKey Key)
	{
		if (!Key_IsMouseButton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_IsMouseButton");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_IsMouseButton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_IsMouseButton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_IsMouseButton_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, Key_IsMouseButton_Key_Offset), 0, Key_IsMouseButton_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_IsMouseButton_FunctionAddress, intPtr, Key_IsMouseButton_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_IsMouseButton_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Key_IsMouseButton_ReturnValue_Offset), 0, Key_IsMouseButton_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_IsModifierKey")]
	public unsafe static bool Key_IsModifierKey(FKey Key)
	{
		if (!Key_IsModifierKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_IsModifierKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_IsModifierKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_IsModifierKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_IsModifierKey_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, Key_IsModifierKey_Key_Offset), 0, Key_IsModifierKey_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_IsModifierKey_FunctionAddress, intPtr, Key_IsModifierKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_IsModifierKey_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Key_IsModifierKey_ReturnValue_Offset), 0, Key_IsModifierKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_IsKeyboardKey")]
	public unsafe static bool Key_IsKeyboardKey(FKey Key)
	{
		if (!Key_IsKeyboardKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_IsKeyboardKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_IsKeyboardKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_IsKeyboardKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_IsKeyboardKey_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, Key_IsKeyboardKey_Key_Offset), 0, Key_IsKeyboardKey_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_IsKeyboardKey_FunctionAddress, intPtr, Key_IsKeyboardKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_IsKeyboardKey_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Key_IsKeyboardKey_ReturnValue_Offset), 0, Key_IsKeyboardKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_IsGamepadKey")]
	public unsafe static bool Key_IsGamepadKey(FKey Key)
	{
		if (!Key_IsGamepadKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_IsGamepadKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_IsGamepadKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_IsGamepadKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_IsGamepadKey_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, Key_IsGamepadKey_Key_Offset), 0, Key_IsGamepadKey_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_IsGamepadKey_FunctionAddress, intPtr, Key_IsGamepadKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_IsGamepadKey_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Key_IsGamepadKey_ReturnValue_Offset), 0, Key_IsGamepadKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_IsDigital")]
	public unsafe static bool Key_IsDigital(FKey Key)
	{
		if (!Key_IsDigital_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_IsDigital");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_IsDigital_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_IsDigital_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_IsDigital_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, Key_IsDigital_Key_Offset), 0, Key_IsDigital_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_IsDigital_FunctionAddress, intPtr, Key_IsDigital_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_IsDigital_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Key_IsDigital_ReturnValue_Offset), 0, Key_IsDigital_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_IsButtonAxis")]
	public unsafe static bool Key_IsButtonAxis(FKey Key)
	{
		if (!Key_IsButtonAxis_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_IsButtonAxis");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_IsButtonAxis_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_IsButtonAxis_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_IsButtonAxis_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, Key_IsButtonAxis_Key_Offset), 0, Key_IsButtonAxis_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_IsButtonAxis_FunctionAddress, intPtr, Key_IsButtonAxis_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_IsButtonAxis_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Key_IsButtonAxis_ReturnValue_Offset), 0, Key_IsButtonAxis_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_IsAxis3D")]
	public unsafe static bool Key_IsAxis3D(FKey Key)
	{
		if (!Key_IsAxis3D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_IsAxis3D");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_IsAxis3D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_IsAxis3D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_IsAxis3D_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, Key_IsAxis3D_Key_Offset), 0, Key_IsAxis3D_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_IsAxis3D_FunctionAddress, intPtr, Key_IsAxis3D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_IsAxis3D_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Key_IsAxis3D_ReturnValue_Offset), 0, Key_IsAxis3D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_IsAxis2D")]
	public unsafe static bool Key_IsAxis2D(FKey Key)
	{
		if (!Key_IsAxis2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_IsAxis2D");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_IsAxis2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_IsAxis2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_IsAxis2D_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, Key_IsAxis2D_Key_Offset), 0, Key_IsAxis2D_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_IsAxis2D_FunctionAddress, intPtr, Key_IsAxis2D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_IsAxis2D_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Key_IsAxis2D_ReturnValue_Offset), 0, Key_IsAxis2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_IsAxis1D")]
	public unsafe static bool Key_IsAxis1D(FKey Key)
	{
		if (!Key_IsAxis1D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_IsAxis1D");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_IsAxis1D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_IsAxis1D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_IsAxis1D_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, Key_IsAxis1D_Key_Offset), 0, Key_IsAxis1D_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_IsAxis1D_FunctionAddress, intPtr, Key_IsAxis1D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_IsAxis1D_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Key_IsAxis1D_ReturnValue_Offset), 0, Key_IsAxis1D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_IsAnalog")]
	public unsafe static bool Key_IsAnalog(FKey Key)
	{
		if (!Key_IsAnalog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_IsAnalog");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_IsAnalog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_IsAnalog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_IsAnalog_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, Key_IsAnalog_Key_Offset), 0, Key_IsAnalog_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_IsAnalog_FunctionAddress, intPtr, Key_IsAnalog_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_IsAnalog_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Key_IsAnalog_ReturnValue_Offset), 0, Key_IsAnalog_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_GetNavigationDirectionFromKey")]
	public unsafe static EUINavigation Key_GetNavigationDirectionFromKey(FKeyEvent InKeyEvent)
	{
		if (!Key_GetNavigationDirectionFromKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_GetNavigationDirectionFromKey");
			return EUINavigation.Left;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_GetNavigationDirectionFromKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_GetNavigationDirectionFromKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_GetNavigationDirectionFromKey_InKeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, Key_GetNavigationDirectionFromKey_InKeyEvent_Offset), 0, Key_GetNavigationDirectionFromKey_InKeyEvent_PropertyAddress.Address, InKeyEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_GetNavigationDirectionFromKey_FunctionAddress, intPtr, Key_GetNavigationDirectionFromKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_GetNavigationDirectionFromKey_InKeyEvent_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EUINavigation>.FromNative(IntPtr.Add(intPtr, Key_GetNavigationDirectionFromKey_ReturnValue_Offset), 0, Key_GetNavigationDirectionFromKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_GetNavigationDirectionFromAnalog")]
	public unsafe static EUINavigation Key_GetNavigationDirectionFromAnalog(FAnalogInputEvent InAnalogEvent)
	{
		if (!Key_GetNavigationDirectionFromAnalog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_GetNavigationDirectionFromAnalog");
			return EUINavigation.Left;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_GetNavigationDirectionFromAnalog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_GetNavigationDirectionFromAnalog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_GetNavigationDirectionFromAnalog_InAnalogEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnalogInputEvent>.ToNative(IntPtr.Add(intPtr, Key_GetNavigationDirectionFromAnalog_InAnalogEvent_Offset), 0, Key_GetNavigationDirectionFromAnalog_InAnalogEvent_PropertyAddress.Address, InAnalogEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_GetNavigationDirectionFromAnalog_FunctionAddress, intPtr, Key_GetNavigationDirectionFromAnalog_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_GetNavigationDirectionFromAnalog_InAnalogEvent_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EUINavigation>.FromNative(IntPtr.Add(intPtr, Key_GetNavigationDirectionFromAnalog_ReturnValue_Offset), 0, Key_GetNavigationDirectionFromAnalog_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_GetNavigationActionFromKey")]
	public unsafe static EUINavigationAction Key_GetNavigationActionFromKey(FKeyEvent InKeyEvent)
	{
		if (!Key_GetNavigationActionFromKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_GetNavigationActionFromKey");
			return EUINavigationAction.Accept;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_GetNavigationActionFromKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_GetNavigationActionFromKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_GetNavigationActionFromKey_InKeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, Key_GetNavigationActionFromKey_InKeyEvent_Offset), 0, Key_GetNavigationActionFromKey_InKeyEvent_PropertyAddress.Address, InKeyEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_GetNavigationActionFromKey_FunctionAddress, intPtr, Key_GetNavigationActionFromKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_GetNavigationActionFromKey_InKeyEvent_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EUINavigationAction>.FromNative(IntPtr.Add(intPtr, Key_GetNavigationActionFromKey_ReturnValue_Offset), 0, Key_GetNavigationActionFromKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:Key_GetDisplayName")]
	public unsafe static string Key_GetDisplayName(FKey Key)
	{
		if (!Key_GetDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:Key_GetDisplayName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Key_GetDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Key_GetDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Key_GetDisplayName_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, Key_GetDisplayName_Key_Offset), 0, Key_GetDisplayName_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Key_GetDisplayName_FunctionAddress, intPtr, Key_GetDisplayName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Key_GetDisplayName_Key_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Key_GetDisplayName_ReturnValue_Offset), 0, Key_GetDisplayName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Key_GetDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:InputEvent_IsShiftDown")]
	public unsafe static bool InputEvent_IsShiftDown(FInputEvent Input)
	{
		if (!InputEvent_IsShiftDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:InputEvent_IsShiftDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputEvent_IsShiftDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputEvent_IsShiftDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InputEvent_IsShiftDown_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FInputEvent>.ToNative(IntPtr.Add(intPtr, InputEvent_IsShiftDown_Input_Offset), 0, InputEvent_IsShiftDown_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InputEvent_IsShiftDown_FunctionAddress, intPtr, InputEvent_IsShiftDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputEvent_IsShiftDown_Input_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InputEvent_IsShiftDown_ReturnValue_Offset), 0, InputEvent_IsShiftDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:InputEvent_IsRightShiftDown")]
	public unsafe static bool InputEvent_IsRightShiftDown(FInputEvent Input)
	{
		if (!InputEvent_IsRightShiftDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:InputEvent_IsRightShiftDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputEvent_IsRightShiftDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputEvent_IsRightShiftDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InputEvent_IsRightShiftDown_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FInputEvent>.ToNative(IntPtr.Add(intPtr, InputEvent_IsRightShiftDown_Input_Offset), 0, InputEvent_IsRightShiftDown_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InputEvent_IsRightShiftDown_FunctionAddress, intPtr, InputEvent_IsRightShiftDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputEvent_IsRightShiftDown_Input_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InputEvent_IsRightShiftDown_ReturnValue_Offset), 0, InputEvent_IsRightShiftDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:InputEvent_IsRightControlDown")]
	public unsafe static bool InputEvent_IsRightControlDown(FInputEvent Input)
	{
		if (!InputEvent_IsRightControlDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:InputEvent_IsRightControlDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputEvent_IsRightControlDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputEvent_IsRightControlDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InputEvent_IsRightControlDown_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FInputEvent>.ToNative(IntPtr.Add(intPtr, InputEvent_IsRightControlDown_Input_Offset), 0, InputEvent_IsRightControlDown_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InputEvent_IsRightControlDown_FunctionAddress, intPtr, InputEvent_IsRightControlDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputEvent_IsRightControlDown_Input_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InputEvent_IsRightControlDown_ReturnValue_Offset), 0, InputEvent_IsRightControlDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:InputEvent_IsRightCommandDown")]
	public unsafe static bool InputEvent_IsRightCommandDown(FInputEvent Input)
	{
		if (!InputEvent_IsRightCommandDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:InputEvent_IsRightCommandDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputEvent_IsRightCommandDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputEvent_IsRightCommandDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InputEvent_IsRightCommandDown_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FInputEvent>.ToNative(IntPtr.Add(intPtr, InputEvent_IsRightCommandDown_Input_Offset), 0, InputEvent_IsRightCommandDown_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InputEvent_IsRightCommandDown_FunctionAddress, intPtr, InputEvent_IsRightCommandDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputEvent_IsRightCommandDown_Input_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InputEvent_IsRightCommandDown_ReturnValue_Offset), 0, InputEvent_IsRightCommandDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:InputEvent_IsRightAltDown")]
	public unsafe static bool InputEvent_IsRightAltDown(FInputEvent Input)
	{
		if (!InputEvent_IsRightAltDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:InputEvent_IsRightAltDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputEvent_IsRightAltDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputEvent_IsRightAltDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InputEvent_IsRightAltDown_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FInputEvent>.ToNative(IntPtr.Add(intPtr, InputEvent_IsRightAltDown_Input_Offset), 0, InputEvent_IsRightAltDown_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InputEvent_IsRightAltDown_FunctionAddress, intPtr, InputEvent_IsRightAltDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputEvent_IsRightAltDown_Input_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InputEvent_IsRightAltDown_ReturnValue_Offset), 0, InputEvent_IsRightAltDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:InputEvent_IsRepeat")]
	public unsafe static bool InputEvent_IsRepeat(FInputEvent Input)
	{
		if (!InputEvent_IsRepeat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:InputEvent_IsRepeat");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputEvent_IsRepeat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputEvent_IsRepeat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InputEvent_IsRepeat_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FInputEvent>.ToNative(IntPtr.Add(intPtr, InputEvent_IsRepeat_Input_Offset), 0, InputEvent_IsRepeat_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InputEvent_IsRepeat_FunctionAddress, intPtr, InputEvent_IsRepeat_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputEvent_IsRepeat_Input_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InputEvent_IsRepeat_ReturnValue_Offset), 0, InputEvent_IsRepeat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:InputEvent_IsLeftShiftDown")]
	public unsafe static bool InputEvent_IsLeftShiftDown(FInputEvent Input)
	{
		if (!InputEvent_IsLeftShiftDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:InputEvent_IsLeftShiftDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputEvent_IsLeftShiftDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputEvent_IsLeftShiftDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InputEvent_IsLeftShiftDown_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FInputEvent>.ToNative(IntPtr.Add(intPtr, InputEvent_IsLeftShiftDown_Input_Offset), 0, InputEvent_IsLeftShiftDown_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InputEvent_IsLeftShiftDown_FunctionAddress, intPtr, InputEvent_IsLeftShiftDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputEvent_IsLeftShiftDown_Input_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InputEvent_IsLeftShiftDown_ReturnValue_Offset), 0, InputEvent_IsLeftShiftDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:InputEvent_IsLeftControlDown")]
	public unsafe static bool InputEvent_IsLeftControlDown(FInputEvent Input)
	{
		if (!InputEvent_IsLeftControlDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:InputEvent_IsLeftControlDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputEvent_IsLeftControlDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputEvent_IsLeftControlDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InputEvent_IsLeftControlDown_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FInputEvent>.ToNative(IntPtr.Add(intPtr, InputEvent_IsLeftControlDown_Input_Offset), 0, InputEvent_IsLeftControlDown_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InputEvent_IsLeftControlDown_FunctionAddress, intPtr, InputEvent_IsLeftControlDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputEvent_IsLeftControlDown_Input_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InputEvent_IsLeftControlDown_ReturnValue_Offset), 0, InputEvent_IsLeftControlDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:InputEvent_IsLeftCommandDown")]
	public unsafe static bool InputEvent_IsLeftCommandDown(FInputEvent Input)
	{
		if (!InputEvent_IsLeftCommandDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:InputEvent_IsLeftCommandDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputEvent_IsLeftCommandDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputEvent_IsLeftCommandDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InputEvent_IsLeftCommandDown_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FInputEvent>.ToNative(IntPtr.Add(intPtr, InputEvent_IsLeftCommandDown_Input_Offset), 0, InputEvent_IsLeftCommandDown_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InputEvent_IsLeftCommandDown_FunctionAddress, intPtr, InputEvent_IsLeftCommandDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputEvent_IsLeftCommandDown_Input_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InputEvent_IsLeftCommandDown_ReturnValue_Offset), 0, InputEvent_IsLeftCommandDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:InputEvent_IsLeftAltDown")]
	public unsafe static bool InputEvent_IsLeftAltDown(FInputEvent Input)
	{
		if (!InputEvent_IsLeftAltDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:InputEvent_IsLeftAltDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputEvent_IsLeftAltDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputEvent_IsLeftAltDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InputEvent_IsLeftAltDown_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FInputEvent>.ToNative(IntPtr.Add(intPtr, InputEvent_IsLeftAltDown_Input_Offset), 0, InputEvent_IsLeftAltDown_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InputEvent_IsLeftAltDown_FunctionAddress, intPtr, InputEvent_IsLeftAltDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputEvent_IsLeftAltDown_Input_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InputEvent_IsLeftAltDown_ReturnValue_Offset), 0, InputEvent_IsLeftAltDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:InputEvent_IsControlDown")]
	public unsafe static bool InputEvent_IsControlDown(FInputEvent Input)
	{
		if (!InputEvent_IsControlDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:InputEvent_IsControlDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputEvent_IsControlDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputEvent_IsControlDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InputEvent_IsControlDown_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FInputEvent>.ToNative(IntPtr.Add(intPtr, InputEvent_IsControlDown_Input_Offset), 0, InputEvent_IsControlDown_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InputEvent_IsControlDown_FunctionAddress, intPtr, InputEvent_IsControlDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputEvent_IsControlDown_Input_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InputEvent_IsControlDown_ReturnValue_Offset), 0, InputEvent_IsControlDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:InputEvent_IsCommandDown")]
	public unsafe static bool InputEvent_IsCommandDown(FInputEvent Input)
	{
		if (!InputEvent_IsCommandDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:InputEvent_IsCommandDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputEvent_IsCommandDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputEvent_IsCommandDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InputEvent_IsCommandDown_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FInputEvent>.ToNative(IntPtr.Add(intPtr, InputEvent_IsCommandDown_Input_Offset), 0, InputEvent_IsCommandDown_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InputEvent_IsCommandDown_FunctionAddress, intPtr, InputEvent_IsCommandDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputEvent_IsCommandDown_Input_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InputEvent_IsCommandDown_ReturnValue_Offset), 0, InputEvent_IsCommandDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:InputEvent_IsAltDown")]
	public unsafe static bool InputEvent_IsAltDown(FInputEvent Input)
	{
		if (!InputEvent_IsAltDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:InputEvent_IsAltDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputEvent_IsAltDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputEvent_IsAltDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InputEvent_IsAltDown_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FInputEvent>.ToNative(IntPtr.Add(intPtr, InputEvent_IsAltDown_Input_Offset), 0, InputEvent_IsAltDown_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InputEvent_IsAltDown_FunctionAddress, intPtr, InputEvent_IsAltDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputEvent_IsAltDown_Input_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, InputEvent_IsAltDown_ReturnValue_Offset), 0, InputEvent_IsAltDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:InputChord_GetDisplayName")]
	public unsafe static string InputChord_GetDisplayName(FInputChord Key)
	{
		if (!InputChord_GetDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:InputChord_GetDisplayName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InputChord_GetDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InputChord_GetDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(InputChord_GetDisplayName_Key_PropertyAddress.Address, intPtr);
		FInputChord.ToNative(IntPtr.Add(intPtr, InputChord_GetDisplayName_Key_Offset), 0, InputChord_GetDisplayName_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InputChord_GetDisplayName_FunctionAddress, intPtr, InputChord_GetDisplayName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InputChord_GetDisplayName_Key_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, InputChord_GetDisplayName_ReturnValue_Offset), 0, InputChord_GetDisplayName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(InputChord_GetDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:GetUserIndex")]
	public unsafe static int GetUserIndex(FKeyEvent Input)
	{
		if (!GetUserIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:GetUserIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUserIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUserIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetUserIndex_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, GetUserIndex_Input_Offset), 0, GetUserIndex_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUserIndex_FunctionAddress, intPtr, GetUserIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetUserIndex_Input_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetUserIndex_ReturnValue_Offset), 0, GetUserIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:GetKey")]
	public unsafe static FKey GetKey(FKeyEvent Input)
	{
		if (!GetKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:GetKey");
			return default(FKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetKey_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, GetKey_Input_Offset), 0, GetKey_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetKey_FunctionAddress, intPtr, GetKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetKey_Input_PropertyAddress.Address, intPtr);
		FKey result = FKey.FromNative(IntPtr.Add(intPtr, GetKey_ReturnValue_Offset), 0, GetKey_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetKey_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:GetAnalogValue")]
	public unsafe static float GetAnalogValue(FAnalogInputEvent Input)
	{
		if (!GetAnalogValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:GetAnalogValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnalogValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnalogValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAnalogValue_Input_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnalogInputEvent>.ToNative(IntPtr.Add(intPtr, GetAnalogValue_Input_Offset), 0, GetAnalogValue_Input_PropertyAddress.Address, Input);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnalogValue_FunctionAddress, intPtr, GetAnalogValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAnalogValue_Input_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAnalogValue_ReturnValue_Offset), 0, GetAnalogValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:EqualEqual_KeyKey")]
	public unsafe static bool EqualEqual_KeyKey(FKey A, FKey B)
	{
		if (!EqualEqual_KeyKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:EqualEqual_KeyKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EqualEqual_KeyKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EqualEqual_KeyKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(EqualEqual_KeyKey_A_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, EqualEqual_KeyKey_A_Offset), 0, EqualEqual_KeyKey_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(EqualEqual_KeyKey_B_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, EqualEqual_KeyKey_B_Offset), 0, EqualEqual_KeyKey_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EqualEqual_KeyKey_FunctionAddress, intPtr, EqualEqual_KeyKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EqualEqual_KeyKey_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(EqualEqual_KeyKey_B_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EqualEqual_KeyKey_ReturnValue_Offset), 0, EqualEqual_KeyKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:EqualEqual_InputChordInputChord")]
	public unsafe static bool EqualEqual_InputChordInputChord(FInputChord A, FInputChord B)
	{
		if (!EqualEqual_InputChordInputChord_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:EqualEqual_InputChordInputChord");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EqualEqual_InputChordInputChord_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EqualEqual_InputChordInputChord_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(EqualEqual_InputChordInputChord_A_PropertyAddress.Address, intPtr);
		FInputChord.ToNative(IntPtr.Add(intPtr, EqualEqual_InputChordInputChord_A_Offset), 0, EqualEqual_InputChordInputChord_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(EqualEqual_InputChordInputChord_B_PropertyAddress.Address, intPtr);
		FInputChord.ToNative(IntPtr.Add(intPtr, EqualEqual_InputChordInputChord_B_Offset), 0, EqualEqual_InputChordInputChord_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EqualEqual_InputChordInputChord_FunctionAddress, intPtr, EqualEqual_InputChordInputChord_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EqualEqual_InputChordInputChord_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(EqualEqual_InputChordInputChord_B_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EqualEqual_InputChordInputChord_ReturnValue_Offset), 0, EqualEqual_InputChordInputChord_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.KismetInputLibrary:CalibrateTilt")]
	public unsafe static void CalibrateTilt()
	{
		if (!CalibrateTilt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.KismetInputLibrary:CalibrateTilt");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalibrateTilt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalibrateTilt_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CalibrateTilt_FunctionAddress, argsSize: CalibrateTilt_ParamsSize);
	}

	static UInputLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.KismetInputLibrary");
		PointerEvent_IsTouchEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_IsTouchEvent");
		PointerEvent_IsTouchEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_IsTouchEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_IsTouchEvent_Input_PropertyAddress, PointerEvent_IsTouchEvent_FunctionAddress, "Input");
		PointerEvent_IsTouchEvent_Input_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_IsTouchEvent_FunctionAddress, "Input");
		PointerEvent_IsTouchEvent_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_IsTouchEvent_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_IsTouchEvent_ReturnValue_PropertyAddress, PointerEvent_IsTouchEvent_FunctionAddress, "ReturnValue");
		PointerEvent_IsTouchEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_IsTouchEvent_FunctionAddress, "ReturnValue");
		PointerEvent_IsTouchEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_IsTouchEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PointerEvent_IsTouchEvent_IsValid = PointerEvent_IsTouchEvent_FunctionAddress != IntPtr.Zero && PointerEvent_IsTouchEvent_Input_IsValid && PointerEvent_IsTouchEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:PointerEvent_IsTouchEvent", PointerEvent_IsTouchEvent_IsValid);
		PointerEvent_IsMouseButtonDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_IsMouseButtonDown");
		PointerEvent_IsMouseButtonDown_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_IsMouseButtonDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_IsMouseButtonDown_Input_PropertyAddress, PointerEvent_IsMouseButtonDown_FunctionAddress, "Input");
		PointerEvent_IsMouseButtonDown_Input_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_IsMouseButtonDown_FunctionAddress, "Input");
		PointerEvent_IsMouseButtonDown_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_IsMouseButtonDown_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_IsMouseButtonDown_MouseButton_PropertyAddress, PointerEvent_IsMouseButtonDown_FunctionAddress, "MouseButton");
		PointerEvent_IsMouseButtonDown_MouseButton_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_IsMouseButtonDown_FunctionAddress, "MouseButton");
		PointerEvent_IsMouseButtonDown_MouseButton_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_IsMouseButtonDown_FunctionAddress, "MouseButton", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_IsMouseButtonDown_ReturnValue_PropertyAddress, PointerEvent_IsMouseButtonDown_FunctionAddress, "ReturnValue");
		PointerEvent_IsMouseButtonDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_IsMouseButtonDown_FunctionAddress, "ReturnValue");
		PointerEvent_IsMouseButtonDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_IsMouseButtonDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PointerEvent_IsMouseButtonDown_IsValid = PointerEvent_IsMouseButtonDown_FunctionAddress != IntPtr.Zero && PointerEvent_IsMouseButtonDown_Input_IsValid && PointerEvent_IsMouseButtonDown_MouseButton_IsValid && PointerEvent_IsMouseButtonDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:PointerEvent_IsMouseButtonDown", PointerEvent_IsMouseButtonDown_IsValid);
		PointerEvent_GetWheelDelta_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_GetWheelDelta");
		PointerEvent_GetWheelDelta_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_GetWheelDelta_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetWheelDelta_Input_PropertyAddress, PointerEvent_GetWheelDelta_FunctionAddress, "Input");
		PointerEvent_GetWheelDelta_Input_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetWheelDelta_FunctionAddress, "Input");
		PointerEvent_GetWheelDelta_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetWheelDelta_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetWheelDelta_ReturnValue_PropertyAddress, PointerEvent_GetWheelDelta_FunctionAddress, "ReturnValue");
		PointerEvent_GetWheelDelta_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetWheelDelta_FunctionAddress, "ReturnValue");
		PointerEvent_GetWheelDelta_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetWheelDelta_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		PointerEvent_GetWheelDelta_IsValid = PointerEvent_GetWheelDelta_FunctionAddress != IntPtr.Zero && PointerEvent_GetWheelDelta_Input_IsValid && PointerEvent_GetWheelDelta_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:PointerEvent_GetWheelDelta", PointerEvent_GetWheelDelta_IsValid);
		PointerEvent_GetUserIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_GetUserIndex");
		PointerEvent_GetUserIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_GetUserIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetUserIndex_Input_PropertyAddress, PointerEvent_GetUserIndex_FunctionAddress, "Input");
		PointerEvent_GetUserIndex_Input_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetUserIndex_FunctionAddress, "Input");
		PointerEvent_GetUserIndex_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetUserIndex_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetUserIndex_ReturnValue_PropertyAddress, PointerEvent_GetUserIndex_FunctionAddress, "ReturnValue");
		PointerEvent_GetUserIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetUserIndex_FunctionAddress, "ReturnValue");
		PointerEvent_GetUserIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetUserIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PointerEvent_GetUserIndex_IsValid = PointerEvent_GetUserIndex_FunctionAddress != IntPtr.Zero && PointerEvent_GetUserIndex_Input_IsValid && PointerEvent_GetUserIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:PointerEvent_GetUserIndex", PointerEvent_GetUserIndex_IsValid);
		PointerEvent_GetTouchpadIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_GetTouchpadIndex");
		PointerEvent_GetTouchpadIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_GetTouchpadIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetTouchpadIndex_Input_PropertyAddress, PointerEvent_GetTouchpadIndex_FunctionAddress, "Input");
		PointerEvent_GetTouchpadIndex_Input_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetTouchpadIndex_FunctionAddress, "Input");
		PointerEvent_GetTouchpadIndex_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetTouchpadIndex_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetTouchpadIndex_ReturnValue_PropertyAddress, PointerEvent_GetTouchpadIndex_FunctionAddress, "ReturnValue");
		PointerEvent_GetTouchpadIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetTouchpadIndex_FunctionAddress, "ReturnValue");
		PointerEvent_GetTouchpadIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetTouchpadIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PointerEvent_GetTouchpadIndex_IsValid = PointerEvent_GetTouchpadIndex_FunctionAddress != IntPtr.Zero && PointerEvent_GetTouchpadIndex_Input_IsValid && PointerEvent_GetTouchpadIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:PointerEvent_GetTouchpadIndex", PointerEvent_GetTouchpadIndex_IsValid);
		PointerEvent_GetScreenSpacePosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_GetScreenSpacePosition");
		PointerEvent_GetScreenSpacePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_GetScreenSpacePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetScreenSpacePosition_Input_PropertyAddress, PointerEvent_GetScreenSpacePosition_FunctionAddress, "Input");
		PointerEvent_GetScreenSpacePosition_Input_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetScreenSpacePosition_FunctionAddress, "Input");
		PointerEvent_GetScreenSpacePosition_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetScreenSpacePosition_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetScreenSpacePosition_ReturnValue_PropertyAddress, PointerEvent_GetScreenSpacePosition_FunctionAddress, "ReturnValue");
		PointerEvent_GetScreenSpacePosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetScreenSpacePosition_FunctionAddress, "ReturnValue");
		PointerEvent_GetScreenSpacePosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetScreenSpacePosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		PointerEvent_GetScreenSpacePosition_IsValid = PointerEvent_GetScreenSpacePosition_FunctionAddress != IntPtr.Zero && PointerEvent_GetScreenSpacePosition_Input_IsValid && PointerEvent_GetScreenSpacePosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:PointerEvent_GetScreenSpacePosition", PointerEvent_GetScreenSpacePosition_IsValid);
		PointerEvent_GetPointerIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_GetPointerIndex");
		PointerEvent_GetPointerIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_GetPointerIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetPointerIndex_Input_PropertyAddress, PointerEvent_GetPointerIndex_FunctionAddress, "Input");
		PointerEvent_GetPointerIndex_Input_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetPointerIndex_FunctionAddress, "Input");
		PointerEvent_GetPointerIndex_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetPointerIndex_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetPointerIndex_ReturnValue_PropertyAddress, PointerEvent_GetPointerIndex_FunctionAddress, "ReturnValue");
		PointerEvent_GetPointerIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetPointerIndex_FunctionAddress, "ReturnValue");
		PointerEvent_GetPointerIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetPointerIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PointerEvent_GetPointerIndex_IsValid = PointerEvent_GetPointerIndex_FunctionAddress != IntPtr.Zero && PointerEvent_GetPointerIndex_Input_IsValid && PointerEvent_GetPointerIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:PointerEvent_GetPointerIndex", PointerEvent_GetPointerIndex_IsValid);
		PointerEvent_GetLastScreenSpacePosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_GetLastScreenSpacePosition");
		PointerEvent_GetLastScreenSpacePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_GetLastScreenSpacePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetLastScreenSpacePosition_Input_PropertyAddress, PointerEvent_GetLastScreenSpacePosition_FunctionAddress, "Input");
		PointerEvent_GetLastScreenSpacePosition_Input_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetLastScreenSpacePosition_FunctionAddress, "Input");
		PointerEvent_GetLastScreenSpacePosition_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetLastScreenSpacePosition_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetLastScreenSpacePosition_ReturnValue_PropertyAddress, PointerEvent_GetLastScreenSpacePosition_FunctionAddress, "ReturnValue");
		PointerEvent_GetLastScreenSpacePosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetLastScreenSpacePosition_FunctionAddress, "ReturnValue");
		PointerEvent_GetLastScreenSpacePosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetLastScreenSpacePosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		PointerEvent_GetLastScreenSpacePosition_IsValid = PointerEvent_GetLastScreenSpacePosition_FunctionAddress != IntPtr.Zero && PointerEvent_GetLastScreenSpacePosition_Input_IsValid && PointerEvent_GetLastScreenSpacePosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:PointerEvent_GetLastScreenSpacePosition", PointerEvent_GetLastScreenSpacePosition_IsValid);
		PointerEvent_GetGestureType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_GetGestureType");
		PointerEvent_GetGestureType_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_GetGestureType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetGestureType_Input_PropertyAddress, PointerEvent_GetGestureType_FunctionAddress, "Input");
		PointerEvent_GetGestureType_Input_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetGestureType_FunctionAddress, "Input");
		PointerEvent_GetGestureType_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetGestureType_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetGestureType_ReturnValue_PropertyAddress, PointerEvent_GetGestureType_FunctionAddress, "ReturnValue");
		PointerEvent_GetGestureType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetGestureType_FunctionAddress, "ReturnValue");
		PointerEvent_GetGestureType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetGestureType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		PointerEvent_GetGestureType_IsValid = PointerEvent_GetGestureType_FunctionAddress != IntPtr.Zero && PointerEvent_GetGestureType_Input_IsValid && PointerEvent_GetGestureType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:PointerEvent_GetGestureType", PointerEvent_GetGestureType_IsValid);
		PointerEvent_GetGestureDelta_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_GetGestureDelta");
		PointerEvent_GetGestureDelta_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_GetGestureDelta_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetGestureDelta_Input_PropertyAddress, PointerEvent_GetGestureDelta_FunctionAddress, "Input");
		PointerEvent_GetGestureDelta_Input_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetGestureDelta_FunctionAddress, "Input");
		PointerEvent_GetGestureDelta_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetGestureDelta_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetGestureDelta_ReturnValue_PropertyAddress, PointerEvent_GetGestureDelta_FunctionAddress, "ReturnValue");
		PointerEvent_GetGestureDelta_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetGestureDelta_FunctionAddress, "ReturnValue");
		PointerEvent_GetGestureDelta_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetGestureDelta_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		PointerEvent_GetGestureDelta_IsValid = PointerEvent_GetGestureDelta_FunctionAddress != IntPtr.Zero && PointerEvent_GetGestureDelta_Input_IsValid && PointerEvent_GetGestureDelta_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:PointerEvent_GetGestureDelta", PointerEvent_GetGestureDelta_IsValid);
		PointerEvent_GetEffectingButton_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_GetEffectingButton");
		PointerEvent_GetEffectingButton_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_GetEffectingButton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetEffectingButton_Input_PropertyAddress, PointerEvent_GetEffectingButton_FunctionAddress, "Input");
		PointerEvent_GetEffectingButton_Input_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetEffectingButton_FunctionAddress, "Input");
		PointerEvent_GetEffectingButton_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetEffectingButton_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetEffectingButton_ReturnValue_PropertyAddress, PointerEvent_GetEffectingButton_FunctionAddress, "ReturnValue");
		PointerEvent_GetEffectingButton_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetEffectingButton_FunctionAddress, "ReturnValue");
		PointerEvent_GetEffectingButton_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetEffectingButton_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		PointerEvent_GetEffectingButton_IsValid = PointerEvent_GetEffectingButton_FunctionAddress != IntPtr.Zero && PointerEvent_GetEffectingButton_Input_IsValid && PointerEvent_GetEffectingButton_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:PointerEvent_GetEffectingButton", PointerEvent_GetEffectingButton_IsValid);
		PointerEvent_GetCursorDelta_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_GetCursorDelta");
		PointerEvent_GetCursorDelta_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_GetCursorDelta_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetCursorDelta_Input_PropertyAddress, PointerEvent_GetCursorDelta_FunctionAddress, "Input");
		PointerEvent_GetCursorDelta_Input_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetCursorDelta_FunctionAddress, "Input");
		PointerEvent_GetCursorDelta_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetCursorDelta_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetCursorDelta_ReturnValue_PropertyAddress, PointerEvent_GetCursorDelta_FunctionAddress, "ReturnValue");
		PointerEvent_GetCursorDelta_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetCursorDelta_FunctionAddress, "ReturnValue");
		PointerEvent_GetCursorDelta_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetCursorDelta_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		PointerEvent_GetCursorDelta_IsValid = PointerEvent_GetCursorDelta_FunctionAddress != IntPtr.Zero && PointerEvent_GetCursorDelta_Input_IsValid && PointerEvent_GetCursorDelta_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:PointerEvent_GetCursorDelta", PointerEvent_GetCursorDelta_IsValid);
		Key_IsValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_IsValid");
		Key_IsValid_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_IsValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_IsValid_Key_PropertyAddress, Key_IsValid_FunctionAddress, "Key");
		Key_IsValid_Key_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsValid_FunctionAddress, "Key");
		Key_IsValid_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsValid_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_IsValid_ReturnValue_PropertyAddress, Key_IsValid_FunctionAddress, "ReturnValue");
		Key_IsValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsValid_FunctionAddress, "ReturnValue");
		Key_IsValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Key_IsValid_IsValid = Key_IsValid_FunctionAddress != IntPtr.Zero && Key_IsValid_Key_IsValid && Key_IsValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_IsValid", Key_IsValid_IsValid);
		Key_IsMouseButton_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_IsMouseButton");
		Key_IsMouseButton_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_IsMouseButton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_IsMouseButton_Key_PropertyAddress, Key_IsMouseButton_FunctionAddress, "Key");
		Key_IsMouseButton_Key_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsMouseButton_FunctionAddress, "Key");
		Key_IsMouseButton_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsMouseButton_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_IsMouseButton_ReturnValue_PropertyAddress, Key_IsMouseButton_FunctionAddress, "ReturnValue");
		Key_IsMouseButton_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsMouseButton_FunctionAddress, "ReturnValue");
		Key_IsMouseButton_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsMouseButton_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Key_IsMouseButton_IsValid = Key_IsMouseButton_FunctionAddress != IntPtr.Zero && Key_IsMouseButton_Key_IsValid && Key_IsMouseButton_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_IsMouseButton", Key_IsMouseButton_IsValid);
		Key_IsModifierKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_IsModifierKey");
		Key_IsModifierKey_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_IsModifierKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_IsModifierKey_Key_PropertyAddress, Key_IsModifierKey_FunctionAddress, "Key");
		Key_IsModifierKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsModifierKey_FunctionAddress, "Key");
		Key_IsModifierKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsModifierKey_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_IsModifierKey_ReturnValue_PropertyAddress, Key_IsModifierKey_FunctionAddress, "ReturnValue");
		Key_IsModifierKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsModifierKey_FunctionAddress, "ReturnValue");
		Key_IsModifierKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsModifierKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Key_IsModifierKey_IsValid = Key_IsModifierKey_FunctionAddress != IntPtr.Zero && Key_IsModifierKey_Key_IsValid && Key_IsModifierKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_IsModifierKey", Key_IsModifierKey_IsValid);
		Key_IsKeyboardKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_IsKeyboardKey");
		Key_IsKeyboardKey_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_IsKeyboardKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_IsKeyboardKey_Key_PropertyAddress, Key_IsKeyboardKey_FunctionAddress, "Key");
		Key_IsKeyboardKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsKeyboardKey_FunctionAddress, "Key");
		Key_IsKeyboardKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsKeyboardKey_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_IsKeyboardKey_ReturnValue_PropertyAddress, Key_IsKeyboardKey_FunctionAddress, "ReturnValue");
		Key_IsKeyboardKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsKeyboardKey_FunctionAddress, "ReturnValue");
		Key_IsKeyboardKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsKeyboardKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Key_IsKeyboardKey_IsValid = Key_IsKeyboardKey_FunctionAddress != IntPtr.Zero && Key_IsKeyboardKey_Key_IsValid && Key_IsKeyboardKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_IsKeyboardKey", Key_IsKeyboardKey_IsValid);
		Key_IsGamepadKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_IsGamepadKey");
		Key_IsGamepadKey_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_IsGamepadKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_IsGamepadKey_Key_PropertyAddress, Key_IsGamepadKey_FunctionAddress, "Key");
		Key_IsGamepadKey_Key_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsGamepadKey_FunctionAddress, "Key");
		Key_IsGamepadKey_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsGamepadKey_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_IsGamepadKey_ReturnValue_PropertyAddress, Key_IsGamepadKey_FunctionAddress, "ReturnValue");
		Key_IsGamepadKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsGamepadKey_FunctionAddress, "ReturnValue");
		Key_IsGamepadKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsGamepadKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Key_IsGamepadKey_IsValid = Key_IsGamepadKey_FunctionAddress != IntPtr.Zero && Key_IsGamepadKey_Key_IsValid && Key_IsGamepadKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_IsGamepadKey", Key_IsGamepadKey_IsValid);
		Key_IsDigital_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_IsDigital");
		Key_IsDigital_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_IsDigital_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_IsDigital_Key_PropertyAddress, Key_IsDigital_FunctionAddress, "Key");
		Key_IsDigital_Key_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsDigital_FunctionAddress, "Key");
		Key_IsDigital_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsDigital_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_IsDigital_ReturnValue_PropertyAddress, Key_IsDigital_FunctionAddress, "ReturnValue");
		Key_IsDigital_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsDigital_FunctionAddress, "ReturnValue");
		Key_IsDigital_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsDigital_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Key_IsDigital_IsValid = Key_IsDigital_FunctionAddress != IntPtr.Zero && Key_IsDigital_Key_IsValid && Key_IsDigital_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_IsDigital", Key_IsDigital_IsValid);
		Key_IsButtonAxis_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_IsButtonAxis");
		Key_IsButtonAxis_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_IsButtonAxis_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_IsButtonAxis_Key_PropertyAddress, Key_IsButtonAxis_FunctionAddress, "Key");
		Key_IsButtonAxis_Key_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsButtonAxis_FunctionAddress, "Key");
		Key_IsButtonAxis_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsButtonAxis_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_IsButtonAxis_ReturnValue_PropertyAddress, Key_IsButtonAxis_FunctionAddress, "ReturnValue");
		Key_IsButtonAxis_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsButtonAxis_FunctionAddress, "ReturnValue");
		Key_IsButtonAxis_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsButtonAxis_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Key_IsButtonAxis_IsValid = Key_IsButtonAxis_FunctionAddress != IntPtr.Zero && Key_IsButtonAxis_Key_IsValid && Key_IsButtonAxis_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_IsButtonAxis", Key_IsButtonAxis_IsValid);
		Key_IsAxis3D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_IsAxis3D");
		Key_IsAxis3D_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_IsAxis3D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_IsAxis3D_Key_PropertyAddress, Key_IsAxis3D_FunctionAddress, "Key");
		Key_IsAxis3D_Key_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsAxis3D_FunctionAddress, "Key");
		Key_IsAxis3D_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsAxis3D_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_IsAxis3D_ReturnValue_PropertyAddress, Key_IsAxis3D_FunctionAddress, "ReturnValue");
		Key_IsAxis3D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsAxis3D_FunctionAddress, "ReturnValue");
		Key_IsAxis3D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsAxis3D_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Key_IsAxis3D_IsValid = Key_IsAxis3D_FunctionAddress != IntPtr.Zero && Key_IsAxis3D_Key_IsValid && Key_IsAxis3D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_IsAxis3D", Key_IsAxis3D_IsValid);
		Key_IsAxis2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_IsAxis2D");
		Key_IsAxis2D_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_IsAxis2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_IsAxis2D_Key_PropertyAddress, Key_IsAxis2D_FunctionAddress, "Key");
		Key_IsAxis2D_Key_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsAxis2D_FunctionAddress, "Key");
		Key_IsAxis2D_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsAxis2D_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_IsAxis2D_ReturnValue_PropertyAddress, Key_IsAxis2D_FunctionAddress, "ReturnValue");
		Key_IsAxis2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsAxis2D_FunctionAddress, "ReturnValue");
		Key_IsAxis2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsAxis2D_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Key_IsAxis2D_IsValid = Key_IsAxis2D_FunctionAddress != IntPtr.Zero && Key_IsAxis2D_Key_IsValid && Key_IsAxis2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_IsAxis2D", Key_IsAxis2D_IsValid);
		Key_IsAxis1D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_IsAxis1D");
		Key_IsAxis1D_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_IsAxis1D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_IsAxis1D_Key_PropertyAddress, Key_IsAxis1D_FunctionAddress, "Key");
		Key_IsAxis1D_Key_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsAxis1D_FunctionAddress, "Key");
		Key_IsAxis1D_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsAxis1D_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_IsAxis1D_ReturnValue_PropertyAddress, Key_IsAxis1D_FunctionAddress, "ReturnValue");
		Key_IsAxis1D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsAxis1D_FunctionAddress, "ReturnValue");
		Key_IsAxis1D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsAxis1D_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Key_IsAxis1D_IsValid = Key_IsAxis1D_FunctionAddress != IntPtr.Zero && Key_IsAxis1D_Key_IsValid && Key_IsAxis1D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_IsAxis1D", Key_IsAxis1D_IsValid);
		Key_IsAnalog_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_IsAnalog");
		Key_IsAnalog_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_IsAnalog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_IsAnalog_Key_PropertyAddress, Key_IsAnalog_FunctionAddress, "Key");
		Key_IsAnalog_Key_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsAnalog_FunctionAddress, "Key");
		Key_IsAnalog_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsAnalog_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_IsAnalog_ReturnValue_PropertyAddress, Key_IsAnalog_FunctionAddress, "ReturnValue");
		Key_IsAnalog_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_IsAnalog_FunctionAddress, "ReturnValue");
		Key_IsAnalog_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_IsAnalog_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Key_IsAnalog_IsValid = Key_IsAnalog_FunctionAddress != IntPtr.Zero && Key_IsAnalog_Key_IsValid && Key_IsAnalog_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_IsAnalog", Key_IsAnalog_IsValid);
		Key_GetNavigationDirectionFromKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_GetNavigationDirectionFromKey");
		Key_GetNavigationDirectionFromKey_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_GetNavigationDirectionFromKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_GetNavigationDirectionFromKey_InKeyEvent_PropertyAddress, Key_GetNavigationDirectionFromKey_FunctionAddress, "InKeyEvent");
		Key_GetNavigationDirectionFromKey_InKeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(Key_GetNavigationDirectionFromKey_FunctionAddress, "InKeyEvent");
		Key_GetNavigationDirectionFromKey_InKeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_GetNavigationDirectionFromKey_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_GetNavigationDirectionFromKey_ReturnValue_PropertyAddress, Key_GetNavigationDirectionFromKey_FunctionAddress, "ReturnValue");
		Key_GetNavigationDirectionFromKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_GetNavigationDirectionFromKey_FunctionAddress, "ReturnValue");
		Key_GetNavigationDirectionFromKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_GetNavigationDirectionFromKey_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		Key_GetNavigationDirectionFromKey_IsValid = Key_GetNavigationDirectionFromKey_FunctionAddress != IntPtr.Zero && Key_GetNavigationDirectionFromKey_InKeyEvent_IsValid && Key_GetNavigationDirectionFromKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_GetNavigationDirectionFromKey", Key_GetNavigationDirectionFromKey_IsValid);
		Key_GetNavigationDirectionFromAnalog_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_GetNavigationDirectionFromAnalog");
		Key_GetNavigationDirectionFromAnalog_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_GetNavigationDirectionFromAnalog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_GetNavigationDirectionFromAnalog_InAnalogEvent_PropertyAddress, Key_GetNavigationDirectionFromAnalog_FunctionAddress, "InAnalogEvent");
		Key_GetNavigationDirectionFromAnalog_InAnalogEvent_Offset = NativeReflectionCached.GetPropertyOffset(Key_GetNavigationDirectionFromAnalog_FunctionAddress, "InAnalogEvent");
		Key_GetNavigationDirectionFromAnalog_InAnalogEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_GetNavigationDirectionFromAnalog_FunctionAddress, "InAnalogEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_GetNavigationDirectionFromAnalog_ReturnValue_PropertyAddress, Key_GetNavigationDirectionFromAnalog_FunctionAddress, "ReturnValue");
		Key_GetNavigationDirectionFromAnalog_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_GetNavigationDirectionFromAnalog_FunctionAddress, "ReturnValue");
		Key_GetNavigationDirectionFromAnalog_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_GetNavigationDirectionFromAnalog_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		Key_GetNavigationDirectionFromAnalog_IsValid = Key_GetNavigationDirectionFromAnalog_FunctionAddress != IntPtr.Zero && Key_GetNavigationDirectionFromAnalog_InAnalogEvent_IsValid && Key_GetNavigationDirectionFromAnalog_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_GetNavigationDirectionFromAnalog", Key_GetNavigationDirectionFromAnalog_IsValid);
		Key_GetNavigationActionFromKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_GetNavigationActionFromKey");
		Key_GetNavigationActionFromKey_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_GetNavigationActionFromKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_GetNavigationActionFromKey_InKeyEvent_PropertyAddress, Key_GetNavigationActionFromKey_FunctionAddress, "InKeyEvent");
		Key_GetNavigationActionFromKey_InKeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(Key_GetNavigationActionFromKey_FunctionAddress, "InKeyEvent");
		Key_GetNavigationActionFromKey_InKeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_GetNavigationActionFromKey_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_GetNavigationActionFromKey_ReturnValue_PropertyAddress, Key_GetNavigationActionFromKey_FunctionAddress, "ReturnValue");
		Key_GetNavigationActionFromKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_GetNavigationActionFromKey_FunctionAddress, "ReturnValue");
		Key_GetNavigationActionFromKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_GetNavigationActionFromKey_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		Key_GetNavigationActionFromKey_IsValid = Key_GetNavigationActionFromKey_FunctionAddress != IntPtr.Zero && Key_GetNavigationActionFromKey_InKeyEvent_IsValid && Key_GetNavigationActionFromKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_GetNavigationActionFromKey", Key_GetNavigationActionFromKey_IsValid);
		Key_GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Key_GetDisplayName");
		Key_GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(Key_GetDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Key_GetDisplayName_Key_PropertyAddress, Key_GetDisplayName_FunctionAddress, "Key");
		Key_GetDisplayName_Key_Offset = NativeReflectionCached.GetPropertyOffset(Key_GetDisplayName_FunctionAddress, "Key");
		Key_GetDisplayName_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_GetDisplayName_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Key_GetDisplayName_ReturnValue_PropertyAddress, Key_GetDisplayName_FunctionAddress, "ReturnValue");
		Key_GetDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Key_GetDisplayName_FunctionAddress, "ReturnValue");
		Key_GetDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Key_GetDisplayName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Key_GetDisplayName_IsValid = Key_GetDisplayName_FunctionAddress != IntPtr.Zero && Key_GetDisplayName_Key_IsValid && Key_GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:Key_GetDisplayName", Key_GetDisplayName_IsValid);
		InputEvent_IsShiftDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InputEvent_IsShiftDown");
		InputEvent_IsShiftDown_ParamsSize = NativeReflection.GetFunctionParamsSize(InputEvent_IsShiftDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsShiftDown_Input_PropertyAddress, InputEvent_IsShiftDown_FunctionAddress, "Input");
		InputEvent_IsShiftDown_Input_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsShiftDown_FunctionAddress, "Input");
		InputEvent_IsShiftDown_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsShiftDown_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsShiftDown_ReturnValue_PropertyAddress, InputEvent_IsShiftDown_FunctionAddress, "ReturnValue");
		InputEvent_IsShiftDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsShiftDown_FunctionAddress, "ReturnValue");
		InputEvent_IsShiftDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsShiftDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InputEvent_IsShiftDown_IsValid = InputEvent_IsShiftDown_FunctionAddress != IntPtr.Zero && InputEvent_IsShiftDown_Input_IsValid && InputEvent_IsShiftDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:InputEvent_IsShiftDown", InputEvent_IsShiftDown_IsValid);
		InputEvent_IsRightShiftDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InputEvent_IsRightShiftDown");
		InputEvent_IsRightShiftDown_ParamsSize = NativeReflection.GetFunctionParamsSize(InputEvent_IsRightShiftDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsRightShiftDown_Input_PropertyAddress, InputEvent_IsRightShiftDown_FunctionAddress, "Input");
		InputEvent_IsRightShiftDown_Input_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsRightShiftDown_FunctionAddress, "Input");
		InputEvent_IsRightShiftDown_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsRightShiftDown_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsRightShiftDown_ReturnValue_PropertyAddress, InputEvent_IsRightShiftDown_FunctionAddress, "ReturnValue");
		InputEvent_IsRightShiftDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsRightShiftDown_FunctionAddress, "ReturnValue");
		InputEvent_IsRightShiftDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsRightShiftDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InputEvent_IsRightShiftDown_IsValid = InputEvent_IsRightShiftDown_FunctionAddress != IntPtr.Zero && InputEvent_IsRightShiftDown_Input_IsValid && InputEvent_IsRightShiftDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:InputEvent_IsRightShiftDown", InputEvent_IsRightShiftDown_IsValid);
		InputEvent_IsRightControlDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InputEvent_IsRightControlDown");
		InputEvent_IsRightControlDown_ParamsSize = NativeReflection.GetFunctionParamsSize(InputEvent_IsRightControlDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsRightControlDown_Input_PropertyAddress, InputEvent_IsRightControlDown_FunctionAddress, "Input");
		InputEvent_IsRightControlDown_Input_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsRightControlDown_FunctionAddress, "Input");
		InputEvent_IsRightControlDown_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsRightControlDown_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsRightControlDown_ReturnValue_PropertyAddress, InputEvent_IsRightControlDown_FunctionAddress, "ReturnValue");
		InputEvent_IsRightControlDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsRightControlDown_FunctionAddress, "ReturnValue");
		InputEvent_IsRightControlDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsRightControlDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InputEvent_IsRightControlDown_IsValid = InputEvent_IsRightControlDown_FunctionAddress != IntPtr.Zero && InputEvent_IsRightControlDown_Input_IsValid && InputEvent_IsRightControlDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:InputEvent_IsRightControlDown", InputEvent_IsRightControlDown_IsValid);
		InputEvent_IsRightCommandDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InputEvent_IsRightCommandDown");
		InputEvent_IsRightCommandDown_ParamsSize = NativeReflection.GetFunctionParamsSize(InputEvent_IsRightCommandDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsRightCommandDown_Input_PropertyAddress, InputEvent_IsRightCommandDown_FunctionAddress, "Input");
		InputEvent_IsRightCommandDown_Input_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsRightCommandDown_FunctionAddress, "Input");
		InputEvent_IsRightCommandDown_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsRightCommandDown_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsRightCommandDown_ReturnValue_PropertyAddress, InputEvent_IsRightCommandDown_FunctionAddress, "ReturnValue");
		InputEvent_IsRightCommandDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsRightCommandDown_FunctionAddress, "ReturnValue");
		InputEvent_IsRightCommandDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsRightCommandDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InputEvent_IsRightCommandDown_IsValid = InputEvent_IsRightCommandDown_FunctionAddress != IntPtr.Zero && InputEvent_IsRightCommandDown_Input_IsValid && InputEvent_IsRightCommandDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:InputEvent_IsRightCommandDown", InputEvent_IsRightCommandDown_IsValid);
		InputEvent_IsRightAltDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InputEvent_IsRightAltDown");
		InputEvent_IsRightAltDown_ParamsSize = NativeReflection.GetFunctionParamsSize(InputEvent_IsRightAltDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsRightAltDown_Input_PropertyAddress, InputEvent_IsRightAltDown_FunctionAddress, "Input");
		InputEvent_IsRightAltDown_Input_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsRightAltDown_FunctionAddress, "Input");
		InputEvent_IsRightAltDown_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsRightAltDown_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsRightAltDown_ReturnValue_PropertyAddress, InputEvent_IsRightAltDown_FunctionAddress, "ReturnValue");
		InputEvent_IsRightAltDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsRightAltDown_FunctionAddress, "ReturnValue");
		InputEvent_IsRightAltDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsRightAltDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InputEvent_IsRightAltDown_IsValid = InputEvent_IsRightAltDown_FunctionAddress != IntPtr.Zero && InputEvent_IsRightAltDown_Input_IsValid && InputEvent_IsRightAltDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:InputEvent_IsRightAltDown", InputEvent_IsRightAltDown_IsValid);
		InputEvent_IsRepeat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InputEvent_IsRepeat");
		InputEvent_IsRepeat_ParamsSize = NativeReflection.GetFunctionParamsSize(InputEvent_IsRepeat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsRepeat_Input_PropertyAddress, InputEvent_IsRepeat_FunctionAddress, "Input");
		InputEvent_IsRepeat_Input_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsRepeat_FunctionAddress, "Input");
		InputEvent_IsRepeat_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsRepeat_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsRepeat_ReturnValue_PropertyAddress, InputEvent_IsRepeat_FunctionAddress, "ReturnValue");
		InputEvent_IsRepeat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsRepeat_FunctionAddress, "ReturnValue");
		InputEvent_IsRepeat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsRepeat_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InputEvent_IsRepeat_IsValid = InputEvent_IsRepeat_FunctionAddress != IntPtr.Zero && InputEvent_IsRepeat_Input_IsValid && InputEvent_IsRepeat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:InputEvent_IsRepeat", InputEvent_IsRepeat_IsValid);
		InputEvent_IsLeftShiftDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InputEvent_IsLeftShiftDown");
		InputEvent_IsLeftShiftDown_ParamsSize = NativeReflection.GetFunctionParamsSize(InputEvent_IsLeftShiftDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsLeftShiftDown_Input_PropertyAddress, InputEvent_IsLeftShiftDown_FunctionAddress, "Input");
		InputEvent_IsLeftShiftDown_Input_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsLeftShiftDown_FunctionAddress, "Input");
		InputEvent_IsLeftShiftDown_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsLeftShiftDown_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsLeftShiftDown_ReturnValue_PropertyAddress, InputEvent_IsLeftShiftDown_FunctionAddress, "ReturnValue");
		InputEvent_IsLeftShiftDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsLeftShiftDown_FunctionAddress, "ReturnValue");
		InputEvent_IsLeftShiftDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsLeftShiftDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InputEvent_IsLeftShiftDown_IsValid = InputEvent_IsLeftShiftDown_FunctionAddress != IntPtr.Zero && InputEvent_IsLeftShiftDown_Input_IsValid && InputEvent_IsLeftShiftDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:InputEvent_IsLeftShiftDown", InputEvent_IsLeftShiftDown_IsValid);
		InputEvent_IsLeftControlDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InputEvent_IsLeftControlDown");
		InputEvent_IsLeftControlDown_ParamsSize = NativeReflection.GetFunctionParamsSize(InputEvent_IsLeftControlDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsLeftControlDown_Input_PropertyAddress, InputEvent_IsLeftControlDown_FunctionAddress, "Input");
		InputEvent_IsLeftControlDown_Input_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsLeftControlDown_FunctionAddress, "Input");
		InputEvent_IsLeftControlDown_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsLeftControlDown_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsLeftControlDown_ReturnValue_PropertyAddress, InputEvent_IsLeftControlDown_FunctionAddress, "ReturnValue");
		InputEvent_IsLeftControlDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsLeftControlDown_FunctionAddress, "ReturnValue");
		InputEvent_IsLeftControlDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsLeftControlDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InputEvent_IsLeftControlDown_IsValid = InputEvent_IsLeftControlDown_FunctionAddress != IntPtr.Zero && InputEvent_IsLeftControlDown_Input_IsValid && InputEvent_IsLeftControlDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:InputEvent_IsLeftControlDown", InputEvent_IsLeftControlDown_IsValid);
		InputEvent_IsLeftCommandDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InputEvent_IsLeftCommandDown");
		InputEvent_IsLeftCommandDown_ParamsSize = NativeReflection.GetFunctionParamsSize(InputEvent_IsLeftCommandDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsLeftCommandDown_Input_PropertyAddress, InputEvent_IsLeftCommandDown_FunctionAddress, "Input");
		InputEvent_IsLeftCommandDown_Input_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsLeftCommandDown_FunctionAddress, "Input");
		InputEvent_IsLeftCommandDown_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsLeftCommandDown_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsLeftCommandDown_ReturnValue_PropertyAddress, InputEvent_IsLeftCommandDown_FunctionAddress, "ReturnValue");
		InputEvent_IsLeftCommandDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsLeftCommandDown_FunctionAddress, "ReturnValue");
		InputEvent_IsLeftCommandDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsLeftCommandDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InputEvent_IsLeftCommandDown_IsValid = InputEvent_IsLeftCommandDown_FunctionAddress != IntPtr.Zero && InputEvent_IsLeftCommandDown_Input_IsValid && InputEvent_IsLeftCommandDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:InputEvent_IsLeftCommandDown", InputEvent_IsLeftCommandDown_IsValid);
		InputEvent_IsLeftAltDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InputEvent_IsLeftAltDown");
		InputEvent_IsLeftAltDown_ParamsSize = NativeReflection.GetFunctionParamsSize(InputEvent_IsLeftAltDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsLeftAltDown_Input_PropertyAddress, InputEvent_IsLeftAltDown_FunctionAddress, "Input");
		InputEvent_IsLeftAltDown_Input_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsLeftAltDown_FunctionAddress, "Input");
		InputEvent_IsLeftAltDown_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsLeftAltDown_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsLeftAltDown_ReturnValue_PropertyAddress, InputEvent_IsLeftAltDown_FunctionAddress, "ReturnValue");
		InputEvent_IsLeftAltDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsLeftAltDown_FunctionAddress, "ReturnValue");
		InputEvent_IsLeftAltDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsLeftAltDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InputEvent_IsLeftAltDown_IsValid = InputEvent_IsLeftAltDown_FunctionAddress != IntPtr.Zero && InputEvent_IsLeftAltDown_Input_IsValid && InputEvent_IsLeftAltDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:InputEvent_IsLeftAltDown", InputEvent_IsLeftAltDown_IsValid);
		InputEvent_IsControlDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InputEvent_IsControlDown");
		InputEvent_IsControlDown_ParamsSize = NativeReflection.GetFunctionParamsSize(InputEvent_IsControlDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsControlDown_Input_PropertyAddress, InputEvent_IsControlDown_FunctionAddress, "Input");
		InputEvent_IsControlDown_Input_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsControlDown_FunctionAddress, "Input");
		InputEvent_IsControlDown_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsControlDown_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsControlDown_ReturnValue_PropertyAddress, InputEvent_IsControlDown_FunctionAddress, "ReturnValue");
		InputEvent_IsControlDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsControlDown_FunctionAddress, "ReturnValue");
		InputEvent_IsControlDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsControlDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InputEvent_IsControlDown_IsValid = InputEvent_IsControlDown_FunctionAddress != IntPtr.Zero && InputEvent_IsControlDown_Input_IsValid && InputEvent_IsControlDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:InputEvent_IsControlDown", InputEvent_IsControlDown_IsValid);
		InputEvent_IsCommandDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InputEvent_IsCommandDown");
		InputEvent_IsCommandDown_ParamsSize = NativeReflection.GetFunctionParamsSize(InputEvent_IsCommandDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsCommandDown_Input_PropertyAddress, InputEvent_IsCommandDown_FunctionAddress, "Input");
		InputEvent_IsCommandDown_Input_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsCommandDown_FunctionAddress, "Input");
		InputEvent_IsCommandDown_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsCommandDown_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsCommandDown_ReturnValue_PropertyAddress, InputEvent_IsCommandDown_FunctionAddress, "ReturnValue");
		InputEvent_IsCommandDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsCommandDown_FunctionAddress, "ReturnValue");
		InputEvent_IsCommandDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsCommandDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InputEvent_IsCommandDown_IsValid = InputEvent_IsCommandDown_FunctionAddress != IntPtr.Zero && InputEvent_IsCommandDown_Input_IsValid && InputEvent_IsCommandDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:InputEvent_IsCommandDown", InputEvent_IsCommandDown_IsValid);
		InputEvent_IsAltDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InputEvent_IsAltDown");
		InputEvent_IsAltDown_ParamsSize = NativeReflection.GetFunctionParamsSize(InputEvent_IsAltDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsAltDown_Input_PropertyAddress, InputEvent_IsAltDown_FunctionAddress, "Input");
		InputEvent_IsAltDown_Input_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsAltDown_FunctionAddress, "Input");
		InputEvent_IsAltDown_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsAltDown_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputEvent_IsAltDown_ReturnValue_PropertyAddress, InputEvent_IsAltDown_FunctionAddress, "ReturnValue");
		InputEvent_IsAltDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InputEvent_IsAltDown_FunctionAddress, "ReturnValue");
		InputEvent_IsAltDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputEvent_IsAltDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		InputEvent_IsAltDown_IsValid = InputEvent_IsAltDown_FunctionAddress != IntPtr.Zero && InputEvent_IsAltDown_Input_IsValid && InputEvent_IsAltDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:InputEvent_IsAltDown", InputEvent_IsAltDown_IsValid);
		InputChord_GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InputChord_GetDisplayName");
		InputChord_GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(InputChord_GetDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InputChord_GetDisplayName_Key_PropertyAddress, InputChord_GetDisplayName_FunctionAddress, "Key");
		InputChord_GetDisplayName_Key_Offset = NativeReflectionCached.GetPropertyOffset(InputChord_GetDisplayName_FunctionAddress, "Key");
		InputChord_GetDisplayName_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(InputChord_GetDisplayName_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InputChord_GetDisplayName_ReturnValue_PropertyAddress, InputChord_GetDisplayName_FunctionAddress, "ReturnValue");
		InputChord_GetDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InputChord_GetDisplayName_FunctionAddress, "ReturnValue");
		InputChord_GetDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InputChord_GetDisplayName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		InputChord_GetDisplayName_IsValid = InputChord_GetDisplayName_FunctionAddress != IntPtr.Zero && InputChord_GetDisplayName_Key_IsValid && InputChord_GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:InputChord_GetDisplayName", InputChord_GetDisplayName_IsValid);
		GetUserIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUserIndex");
		GetUserIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUserIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUserIndex_Input_PropertyAddress, GetUserIndex_FunctionAddress, "Input");
		GetUserIndex_Input_Offset = NativeReflectionCached.GetPropertyOffset(GetUserIndex_FunctionAddress, "Input");
		GetUserIndex_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUserIndex_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUserIndex_ReturnValue_PropertyAddress, GetUserIndex_FunctionAddress, "ReturnValue");
		GetUserIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUserIndex_FunctionAddress, "ReturnValue");
		GetUserIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUserIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetUserIndex_IsValid = GetUserIndex_FunctionAddress != IntPtr.Zero && GetUserIndex_Input_IsValid && GetUserIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:GetUserIndex", GetUserIndex_IsValid);
		GetKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetKey");
		GetKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKey_Input_PropertyAddress, GetKey_FunctionAddress, "Input");
		GetKey_Input_Offset = NativeReflectionCached.GetPropertyOffset(GetKey_FunctionAddress, "Input");
		GetKey_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKey_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKey_ReturnValue_PropertyAddress, GetKey_FunctionAddress, "ReturnValue");
		GetKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKey_FunctionAddress, "ReturnValue");
		GetKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetKey_IsValid = GetKey_FunctionAddress != IntPtr.Zero && GetKey_Input_IsValid && GetKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:GetKey", GetKey_IsValid);
		GetAnalogValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnalogValue");
		GetAnalogValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnalogValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnalogValue_Input_PropertyAddress, GetAnalogValue_FunctionAddress, "Input");
		GetAnalogValue_Input_Offset = NativeReflectionCached.GetPropertyOffset(GetAnalogValue_FunctionAddress, "Input");
		GetAnalogValue_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnalogValue_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnalogValue_ReturnValue_PropertyAddress, GetAnalogValue_FunctionAddress, "ReturnValue");
		GetAnalogValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnalogValue_FunctionAddress, "ReturnValue");
		GetAnalogValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnalogValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAnalogValue_IsValid = GetAnalogValue_FunctionAddress != IntPtr.Zero && GetAnalogValue_Input_IsValid && GetAnalogValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:GetAnalogValue", GetAnalogValue_IsValid);
		EqualEqual_KeyKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EqualEqual_KeyKey");
		EqualEqual_KeyKey_ParamsSize = NativeReflection.GetFunctionParamsSize(EqualEqual_KeyKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_KeyKey_A_PropertyAddress, EqualEqual_KeyKey_FunctionAddress, "A");
		EqualEqual_KeyKey_A_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_KeyKey_FunctionAddress, "A");
		EqualEqual_KeyKey_A_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_KeyKey_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_KeyKey_B_PropertyAddress, EqualEqual_KeyKey_FunctionAddress, "B");
		EqualEqual_KeyKey_B_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_KeyKey_FunctionAddress, "B");
		EqualEqual_KeyKey_B_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_KeyKey_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_KeyKey_ReturnValue_PropertyAddress, EqualEqual_KeyKey_FunctionAddress, "ReturnValue");
		EqualEqual_KeyKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_KeyKey_FunctionAddress, "ReturnValue");
		EqualEqual_KeyKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_KeyKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EqualEqual_KeyKey_IsValid = EqualEqual_KeyKey_FunctionAddress != IntPtr.Zero && EqualEqual_KeyKey_A_IsValid && EqualEqual_KeyKey_B_IsValid && EqualEqual_KeyKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:EqualEqual_KeyKey", EqualEqual_KeyKey_IsValid);
		EqualEqual_InputChordInputChord_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EqualEqual_InputChordInputChord");
		EqualEqual_InputChordInputChord_ParamsSize = NativeReflection.GetFunctionParamsSize(EqualEqual_InputChordInputChord_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_InputChordInputChord_A_PropertyAddress, EqualEqual_InputChordInputChord_FunctionAddress, "A");
		EqualEqual_InputChordInputChord_A_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_InputChordInputChord_FunctionAddress, "A");
		EqualEqual_InputChordInputChord_A_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_InputChordInputChord_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_InputChordInputChord_B_PropertyAddress, EqualEqual_InputChordInputChord_FunctionAddress, "B");
		EqualEqual_InputChordInputChord_B_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_InputChordInputChord_FunctionAddress, "B");
		EqualEqual_InputChordInputChord_B_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_InputChordInputChord_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_InputChordInputChord_ReturnValue_PropertyAddress, EqualEqual_InputChordInputChord_FunctionAddress, "ReturnValue");
		EqualEqual_InputChordInputChord_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_InputChordInputChord_FunctionAddress, "ReturnValue");
		EqualEqual_InputChordInputChord_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_InputChordInputChord_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EqualEqual_InputChordInputChord_IsValid = EqualEqual_InputChordInputChord_FunctionAddress != IntPtr.Zero && EqualEqual_InputChordInputChord_A_IsValid && EqualEqual_InputChordInputChord_B_IsValid && EqualEqual_InputChordInputChord_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:EqualEqual_InputChordInputChord", EqualEqual_InputChordInputChord_IsValid);
		CalibrateTilt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalibrateTilt");
		CalibrateTilt_ParamsSize = NativeReflection.GetFunctionParamsSize(CalibrateTilt_FunctionAddress);
		CalibrateTilt_IsValid = CalibrateTilt_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.KismetInputLibrary:CalibrateTilt", CalibrateTilt_IsValid);
	}
}
