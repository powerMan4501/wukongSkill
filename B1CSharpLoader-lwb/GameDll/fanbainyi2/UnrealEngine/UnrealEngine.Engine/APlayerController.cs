using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.PlayerController", "Engine", UnrealModuleType.Engine)]
public class APlayerController : AController
{
	private static bool PlayerCameraManager_IsValid;

	private static int PlayerCameraManager_Offset;

	private static bool PlayerCameraManagerClass_IsValid;

	private static int PlayerCameraManagerClass_Offset;

	private static bool SmoothTargetViewRotationSpeed_IsValid;

	private static int SmoothTargetViewRotationSpeed_Offset;

	private static bool CheatManager_IsValid;

	private static int CheatManager_Offset;

	private static bool CheatClass_IsValid;

	private static int CheatClass_Offset;

	private static bool PlayerIsWaiting_IsValid;

	private static FFieldAddress PlayerIsWaiting_PropertyAddress;

	private static int PlayerIsWaiting_Offset;

	private static bool ShowMouseCursor_IsValid;

	private static FFieldAddress ShowMouseCursor_PropertyAddress;

	private static int ShowMouseCursor_Offset;

	private static bool EnableClickEvents_IsValid;

	private static FFieldAddress EnableClickEvents_PropertyAddress;

	private static int EnableClickEvents_Offset;

	private static bool EnableTouchEvents_IsValid;

	private static FFieldAddress EnableTouchEvents_PropertyAddress;

	private static int EnableTouchEvents_Offset;

	private static bool EnableMouseOverEvents_IsValid;

	private static FFieldAddress EnableMouseOverEvents_PropertyAddress;

	private static int EnableMouseOverEvents_Offset;

	private static bool EnableTouchOverEvents_IsValid;

	private static FFieldAddress EnableTouchOverEvents_PropertyAddress;

	private static int EnableTouchOverEvents_Offset;

	private static bool ForceFeedbackEnabled_IsValid;

	private static FFieldAddress ForceFeedbackEnabled_PropertyAddress;

	private static int ForceFeedbackEnabled_Offset;

	private static bool EnableStreamingSource_IsValid;

	private static FFieldAddress EnableStreamingSource_PropertyAddress;

	private static int EnableStreamingSource_Offset;

	private static bool StreamingSourceShouldActivate_IsValid;

	private static FFieldAddress StreamingSourceShouldActivate_PropertyAddress;

	private static int StreamingSourceShouldActivate_Offset;

	private static bool StreamingSourceShouldBlockOnSlowStreaming_IsValid;

	private static FFieldAddress StreamingSourceShouldBlockOnSlowStreaming_PropertyAddress;

	private static int StreamingSourceShouldBlockOnSlowStreaming_Offset;

	private static bool ClickEventKeys_IsValid;

	private static FFieldAddress ClickEventKeys_PropertyAddress;

	private static int ClickEventKeys_Offset;

	private TArrayReadWriteMarshaler<FKey> ClickEventKeys_MarshalerCached;

	private static bool DefaultMouseCursor_IsValid;

	private static FFieldAddress DefaultMouseCursor_PropertyAddress;

	private static int DefaultMouseCursor_Offset;

	private static bool CurrentMouseCursor_IsValid;

	private static FFieldAddress CurrentMouseCursor_PropertyAddress;

	private static int CurrentMouseCursor_Offset;

	private static bool DefaultClickTraceChannel_IsValid;

	private static FFieldAddress DefaultClickTraceChannel_PropertyAddress;

	private static int DefaultClickTraceChannel_Offset;

	private static bool CurrentClickTraceChannel_IsValid;

	private static FFieldAddress CurrentClickTraceChannel_PropertyAddress;

	private static int CurrentClickTraceChannel_Offset;

	private static bool HitResultTraceDistance_IsValid;

	private static int HitResultTraceDistance_Offset;

	private static bool ShouldPerformFullTickWhenPaused_IsValid;

	private static FFieldAddress ShouldPerformFullTickWhenPaused_PropertyAddress;

	private static int ShouldPerformFullTickWhenPaused_Offset;

	private static bool WasInputKeyJustReleased_IsValid;

	private static IntPtr WasInputKeyJustReleased_FunctionAddress;

	private static int WasInputKeyJustReleased_ParamsSize;

	private static bool WasInputKeyJustReleased_Key_IsValid;

	private static FFieldAddress WasInputKeyJustReleased_Key_PropertyAddress;

	private static int WasInputKeyJustReleased_Key_Offset;

	private static bool WasInputKeyJustReleased_ReturnValue_IsValid;

	private static FFieldAddress WasInputKeyJustReleased_ReturnValue_PropertyAddress;

	private static int WasInputKeyJustReleased_ReturnValue_Offset;

	private static bool WasInputKeyJustPressed_IsValid;

	private static IntPtr WasInputKeyJustPressed_FunctionAddress;

	private static int WasInputKeyJustPressed_ParamsSize;

	private static bool WasInputKeyJustPressed_Key_IsValid;

	private static FFieldAddress WasInputKeyJustPressed_Key_PropertyAddress;

	private static int WasInputKeyJustPressed_Key_Offset;

	private static bool WasInputKeyJustPressed_ReturnValue_IsValid;

	private static FFieldAddress WasInputKeyJustPressed_ReturnValue_PropertyAddress;

	private static int WasInputKeyJustPressed_ReturnValue_Offset;

	private static bool StreamingSourceShouldBlockOnSlowStreaming_C5C07849_IsValid;

	private static IntPtr StreamingSourceShouldBlockOnSlowStreaming_C5C07849_FunctionAddress;

	private static int StreamingSourceShouldBlockOnSlowStreaming_C5C07849_ParamsSize;

	private static bool StreamingSourceShouldBlockOnSlowStreaming_C5C07849_ReturnValue_IsValid;

	private static FFieldAddress StreamingSourceShouldBlockOnSlowStreaming_C5C07849_ReturnValue_PropertyAddress;

	private static int StreamingSourceShouldBlockOnSlowStreaming_C5C07849_ReturnValue_Offset;

	private static bool StreamingSourceShouldActivate_E1011EAF_IsValid;

	private static IntPtr StreamingSourceShouldActivate_E1011EAF_FunctionAddress;

	private static int StreamingSourceShouldActivate_E1011EAF_ParamsSize;

	private static bool StreamingSourceShouldActivate_E1011EAF_ReturnValue_IsValid;

	private static FFieldAddress StreamingSourceShouldActivate_E1011EAF_ReturnValue_PropertyAddress;

	private static int StreamingSourceShouldActivate_E1011EAF_ReturnValue_Offset;

	private static bool StopHapticEffect_IsValid;

	private static IntPtr StopHapticEffect_FunctionAddress;

	private static int StopHapticEffect_ParamsSize;

	private static bool StopHapticEffect_Hand_IsValid;

	private static FFieldAddress StopHapticEffect_Hand_PropertyAddress;

	private static int StopHapticEffect_Hand_Offset;

	private static bool SetVirtualJoystickVisibility_IsValid;

	private static IntPtr SetVirtualJoystickVisibility_FunctionAddress;

	private static int SetVirtualJoystickVisibility_ParamsSize;

	private static bool SetVirtualJoystickVisibility_bVisible_IsValid;

	private static FFieldAddress SetVirtualJoystickVisibility_bVisible_PropertyAddress;

	private static int SetVirtualJoystickVisibility_bVisible_Offset;

	private static bool SetViewTargetWithBlend_IsValid;

	private static IntPtr SetViewTargetWithBlend_FunctionAddress;

	private static int SetViewTargetWithBlend_ParamsSize;

	private static bool SetViewTargetWithBlend_NewViewTarget_IsValid;

	private static FFieldAddress SetViewTargetWithBlend_NewViewTarget_PropertyAddress;

	private static int SetViewTargetWithBlend_NewViewTarget_Offset;

	private static bool SetViewTargetWithBlend_BlendTime_IsValid;

	private static FFieldAddress SetViewTargetWithBlend_BlendTime_PropertyAddress;

	private static int SetViewTargetWithBlend_BlendTime_Offset;

	private static bool SetViewTargetWithBlend_BlendFunc_IsValid;

	private static FFieldAddress SetViewTargetWithBlend_BlendFunc_PropertyAddress;

	private static int SetViewTargetWithBlend_BlendFunc_Offset;

	private static bool SetViewTargetWithBlend_BlendExp_IsValid;

	private static FFieldAddress SetViewTargetWithBlend_BlendExp_PropertyAddress;

	private static int SetViewTargetWithBlend_BlendExp_Offset;

	private static bool SetViewTargetWithBlend_bLockOutgoing_IsValid;

	private static FFieldAddress SetViewTargetWithBlend_bLockOutgoing_PropertyAddress;

	private static int SetViewTargetWithBlend_bLockOutgoing_Offset;

	private static bool SetMouseLocation_IsValid;

	private static IntPtr SetMouseLocation_FunctionAddress;

	private static int SetMouseLocation_ParamsSize;

	private static bool SetMouseLocation_X_IsValid;

	private static FFieldAddress SetMouseLocation_X_PropertyAddress;

	private static int SetMouseLocation_X_Offset;

	private static bool SetMouseLocation_Y_IsValid;

	private static FFieldAddress SetMouseLocation_Y_PropertyAddress;

	private static int SetMouseLocation_Y_Offset;

	private static bool SetMouseCursorWidget_IsValid;

	private static IntPtr SetMouseCursorWidget_FunctionAddress;

	private static int SetMouseCursorWidget_ParamsSize;

	private static bool SetMouseCursorWidget_Cursor_IsValid;

	private static FFieldAddress SetMouseCursorWidget_Cursor_PropertyAddress;

	private static int SetMouseCursorWidget_Cursor_Offset;

	private static bool SetMouseCursorWidget_CursorWidget_IsValid;

	private static FFieldAddress SetMouseCursorWidget_CursorWidget_PropertyAddress;

	private static int SetMouseCursorWidget_CursorWidget_Offset;

	private static bool SetHapticsByValue_IsValid;

	private static IntPtr SetHapticsByValue_FunctionAddress;

	private static int SetHapticsByValue_ParamsSize;

	private static bool SetHapticsByValue_Frequency_IsValid;

	private static FFieldAddress SetHapticsByValue_Frequency_PropertyAddress;

	private static int SetHapticsByValue_Frequency_Offset;

	private static bool SetHapticsByValue_Amplitude_IsValid;

	private static FFieldAddress SetHapticsByValue_Amplitude_PropertyAddress;

	private static int SetHapticsByValue_Amplitude_Offset;

	private static bool SetHapticsByValue_Hand_IsValid;

	private static FFieldAddress SetHapticsByValue_Hand_PropertyAddress;

	private static int SetHapticsByValue_Hand_Offset;

	private static bool SetDisableHaptics_IsValid;

	private static IntPtr SetDisableHaptics_FunctionAddress;

	private static int SetDisableHaptics_ParamsSize;

	private static bool SetDisableHaptics_bNewDisabled_IsValid;

	private static FFieldAddress SetDisableHaptics_bNewDisabled_PropertyAddress;

	private static int SetDisableHaptics_bNewDisabled_Offset;

	private static bool SetDeprecatedInputYawScale_IsValid;

	private static IntPtr SetDeprecatedInputYawScale_FunctionAddress;

	private static int SetDeprecatedInputYawScale_ParamsSize;

	private static bool SetDeprecatedInputYawScale_NewValue_IsValid;

	private static FFieldAddress SetDeprecatedInputYawScale_NewValue_PropertyAddress;

	private static int SetDeprecatedInputYawScale_NewValue_Offset;

	private static bool SetDeprecatedInputRollScale_IsValid;

	private static IntPtr SetDeprecatedInputRollScale_FunctionAddress;

	private static int SetDeprecatedInputRollScale_ParamsSize;

	private static bool SetDeprecatedInputRollScale_NewValue_IsValid;

	private static FFieldAddress SetDeprecatedInputRollScale_NewValue_PropertyAddress;

	private static int SetDeprecatedInputRollScale_NewValue_Offset;

	private static bool SetDeprecatedInputPitchScale_IsValid;

	private static IntPtr SetDeprecatedInputPitchScale_FunctionAddress;

	private static int SetDeprecatedInputPitchScale_ParamsSize;

	private static bool SetDeprecatedInputPitchScale_NewValue_IsValid;

	private static FFieldAddress SetDeprecatedInputPitchScale_NewValue_PropertyAddress;

	private static int SetDeprecatedInputPitchScale_NewValue_Offset;

	private static bool SetControllerLightColor_IsValid;

	private static IntPtr SetControllerLightColor_FunctionAddress;

	private static int SetControllerLightColor_ParamsSize;

	private static bool SetControllerLightColor_Color_IsValid;

	private static FFieldAddress SetControllerLightColor_Color_PropertyAddress;

	private static int SetControllerLightColor_Color_Offset;

	private static bool SetCinematicMode_IsValid;

	private static IntPtr SetCinematicMode_FunctionAddress;

	private static int SetCinematicMode_ParamsSize;

	private static bool SetCinematicMode_bInCinematicMode_IsValid;

	private static FFieldAddress SetCinematicMode_bInCinematicMode_PropertyAddress;

	private static int SetCinematicMode_bInCinematicMode_Offset;

	private static bool SetCinematicMode_bHidePlayer_IsValid;

	private static FFieldAddress SetCinematicMode_bHidePlayer_PropertyAddress;

	private static int SetCinematicMode_bHidePlayer_Offset;

	private static bool SetCinematicMode_bAffectsHUD_IsValid;

	private static FFieldAddress SetCinematicMode_bAffectsHUD_PropertyAddress;

	private static int SetCinematicMode_bAffectsHUD_Offset;

	private static bool SetCinematicMode_bAffectsMovement_IsValid;

	private static FFieldAddress SetCinematicMode_bAffectsMovement_PropertyAddress;

	private static int SetCinematicMode_bAffectsMovement_Offset;

	private static bool SetCinematicMode_bAffectsTurning_IsValid;

	private static FFieldAddress SetCinematicMode_bAffectsTurning_PropertyAddress;

	private static int SetCinematicMode_bAffectsTurning_Offset;

	private static bool SetAudioListenerOverride_IsValid;

	private static IntPtr SetAudioListenerOverride_FunctionAddress;

	private static int SetAudioListenerOverride_ParamsSize;

	private static bool SetAudioListenerOverride_AttachToComponent_IsValid;

	private static FFieldAddress SetAudioListenerOverride_AttachToComponent_PropertyAddress;

	private static int SetAudioListenerOverride_AttachToComponent_Offset;

	private static bool SetAudioListenerOverride_Location_IsValid;

	private static FFieldAddress SetAudioListenerOverride_Location_PropertyAddress;

	private static int SetAudioListenerOverride_Location_Offset;

	private static bool SetAudioListenerOverride_Rotation_IsValid;

	private static FFieldAddress SetAudioListenerOverride_Rotation_PropertyAddress;

	private static int SetAudioListenerOverride_Rotation_Offset;

	private static bool SetAudioListenerAttenuationOverride_IsValid;

	private static IntPtr SetAudioListenerAttenuationOverride_FunctionAddress;

	private static int SetAudioListenerAttenuationOverride_ParamsSize;

	private static bool SetAudioListenerAttenuationOverride_AttachToComponent_IsValid;

	private static FFieldAddress SetAudioListenerAttenuationOverride_AttachToComponent_PropertyAddress;

	private static int SetAudioListenerAttenuationOverride_AttachToComponent_Offset;

	private static bool SetAudioListenerAttenuationOverride_AttenuationLocationOVerride_IsValid;

	private static FFieldAddress SetAudioListenerAttenuationOverride_AttenuationLocationOVerride_PropertyAddress;

	private static int SetAudioListenerAttenuationOverride_AttenuationLocationOVerride_Offset;

	private static bool ResetControllerLightColor_IsValid;

	private static IntPtr ResetControllerLightColor_FunctionAddress;

	private static int ResetControllerLightColor_ParamsSize;

	private static bool ProjectWorldLocationToScreen_IsValid;

	private static IntPtr ProjectWorldLocationToScreen_FunctionAddress;

	private static int ProjectWorldLocationToScreen_ParamsSize;

	private static bool ProjectWorldLocationToScreen_WorldLocation_IsValid;

	private static FFieldAddress ProjectWorldLocationToScreen_WorldLocation_PropertyAddress;

	private static int ProjectWorldLocationToScreen_WorldLocation_Offset;

	private static bool ProjectWorldLocationToScreen_ScreenLocation_IsValid;

	private static FFieldAddress ProjectWorldLocationToScreen_ScreenLocation_PropertyAddress;

	private static int ProjectWorldLocationToScreen_ScreenLocation_Offset;

	private static bool ProjectWorldLocationToScreen_bPlayerViewportRelative_IsValid;

	private static FFieldAddress ProjectWorldLocationToScreen_bPlayerViewportRelative_PropertyAddress;

	private static int ProjectWorldLocationToScreen_bPlayerViewportRelative_Offset;

	private static bool ProjectWorldLocationToScreen_ReturnValue_IsValid;

	private static FFieldAddress ProjectWorldLocationToScreen_ReturnValue_PropertyAddress;

	private static int ProjectWorldLocationToScreen_ReturnValue_Offset;

	private static bool PlayHapticEffect_IsValid;

	private static IntPtr PlayHapticEffect_FunctionAddress;

	private static int PlayHapticEffect_ParamsSize;

	private static bool PlayHapticEffect_HapticEffect_IsValid;

	private static FFieldAddress PlayHapticEffect_HapticEffect_PropertyAddress;

	private static int PlayHapticEffect_HapticEffect_Offset;

	private static bool PlayHapticEffect_Hand_IsValid;

	private static FFieldAddress PlayHapticEffect_Hand_PropertyAddress;

	private static int PlayHapticEffect_Hand_Offset;

	private static bool PlayHapticEffect_Scale_IsValid;

	private static FFieldAddress PlayHapticEffect_Scale_PropertyAddress;

	private static int PlayHapticEffect_Scale_Offset;

	private static bool PlayHapticEffect_bLoop_IsValid;

	private static FFieldAddress PlayHapticEffect_bLoop_PropertyAddress;

	private static int PlayHapticEffect_bLoop_Offset;

	private static bool PlayDynamicForceFeedback_IsValid;

	private static IntPtr PlayDynamicForceFeedback_FunctionAddress;

	private static int PlayDynamicForceFeedback_ParamsSize;

	private static bool PlayDynamicForceFeedback_Intensity_IsValid;

	private static FFieldAddress PlayDynamicForceFeedback_Intensity_PropertyAddress;

	private static int PlayDynamicForceFeedback_Intensity_Offset;

	private static bool PlayDynamicForceFeedback_Duration_IsValid;

	private static FFieldAddress PlayDynamicForceFeedback_Duration_PropertyAddress;

	private static int PlayDynamicForceFeedback_Duration_Offset;

	private static bool PlayDynamicForceFeedback_bAffectsLeftLarge_IsValid;

	private static FFieldAddress PlayDynamicForceFeedback_bAffectsLeftLarge_PropertyAddress;

	private static int PlayDynamicForceFeedback_bAffectsLeftLarge_Offset;

	private static bool PlayDynamicForceFeedback_bAffectsLeftSmall_IsValid;

	private static FFieldAddress PlayDynamicForceFeedback_bAffectsLeftSmall_PropertyAddress;

	private static int PlayDynamicForceFeedback_bAffectsLeftSmall_Offset;

	private static bool PlayDynamicForceFeedback_bAffectsRightLarge_IsValid;

	private static FFieldAddress PlayDynamicForceFeedback_bAffectsRightLarge_PropertyAddress;

	private static int PlayDynamicForceFeedback_bAffectsRightLarge_Offset;

	private static bool PlayDynamicForceFeedback_bAffectsRightSmall_IsValid;

	private static FFieldAddress PlayDynamicForceFeedback_bAffectsRightSmall_PropertyAddress;

	private static int PlayDynamicForceFeedback_bAffectsRightSmall_Offset;

	private static bool PlayDynamicForceFeedback_Action_IsValid;

	private static FFieldAddress PlayDynamicForceFeedback_Action_PropertyAddress;

	private static int PlayDynamicForceFeedback_Action_Offset;

	private static bool PlayDynamicForceFeedback_LatentInfo_IsValid;

	private static FFieldAddress PlayDynamicForceFeedback_LatentInfo_PropertyAddress;

	private static int PlayDynamicForceFeedback_LatentInfo_Offset;

	private static bool ClientPlayForceFeedback_IsValid;

	private static IntPtr ClientPlayForceFeedback_FunctionAddress;

	private static int ClientPlayForceFeedback_ParamsSize;

	private static bool ClientPlayForceFeedback_ForceFeedbackEffect_IsValid;

	private static FFieldAddress ClientPlayForceFeedback_ForceFeedbackEffect_PropertyAddress;

	private static int ClientPlayForceFeedback_ForceFeedbackEffect_Offset;

	private static bool ClientPlayForceFeedback_Tag_IsValid;

	private static FFieldAddress ClientPlayForceFeedback_Tag_PropertyAddress;

	private static int ClientPlayForceFeedback_Tag_Offset;

	private static bool ClientPlayForceFeedback_bLooping_IsValid;

	private static FFieldAddress ClientPlayForceFeedback_bLooping_PropertyAddress;

	private static int ClientPlayForceFeedback_bLooping_Offset;

	private static bool ClientPlayForceFeedback_bIgnoreTimeDilation_IsValid;

	private static FFieldAddress ClientPlayForceFeedback_bIgnoreTimeDilation_PropertyAddress;

	private static int ClientPlayForceFeedback_bIgnoreTimeDilation_Offset;

	private static bool ClientPlayForceFeedback_bPlayWhilePaused_IsValid;

	private static FFieldAddress ClientPlayForceFeedback_bPlayWhilePaused_PropertyAddress;

	private static int ClientPlayForceFeedback_bPlayWhilePaused_Offset;

	private static bool IsStreamingSourceEnabled_IsValid;

	private static IntPtr IsStreamingSourceEnabled_FunctionAddress;

	private static int IsStreamingSourceEnabled_ParamsSize;

	private static bool IsStreamingSourceEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsStreamingSourceEnabled_ReturnValue_PropertyAddress;

	private static int IsStreamingSourceEnabled_ReturnValue_Offset;

	private static bool IsInputKeyDown_IsValid;

	private static IntPtr IsInputKeyDown_FunctionAddress;

	private static int IsInputKeyDown_ParamsSize;

	private static bool IsInputKeyDown_Key_IsValid;

	private static FFieldAddress IsInputKeyDown_Key_PropertyAddress;

	private static int IsInputKeyDown_Key_Offset;

	private static bool IsInputKeyDown_ReturnValue_IsValid;

	private static FFieldAddress IsInputKeyDown_ReturnValue_PropertyAddress;

	private static int IsInputKeyDown_ReturnValue_Offset;

	private static bool GetViewportSize_IsValid;

	private static IntPtr GetViewportSize_FunctionAddress;

	private static int GetViewportSize_ParamsSize;

	private static bool GetViewportSize_SizeX_IsValid;

	private static FFieldAddress GetViewportSize_SizeX_PropertyAddress;

	private static int GetViewportSize_SizeX_Offset;

	private static bool GetViewportSize_SizeY_IsValid;

	private static FFieldAddress GetViewportSize_SizeY_PropertyAddress;

	private static int GetViewportSize_SizeY_Offset;

	private static bool GetSpectatorPawn_IsValid;

	private static IntPtr GetSpectatorPawn_FunctionAddress;

	private static int GetSpectatorPawn_ParamsSize;

	private static bool GetSpectatorPawn_ReturnValue_IsValid;

	private static FFieldAddress GetSpectatorPawn_ReturnValue_PropertyAddress;

	private static int GetSpectatorPawn_ReturnValue_Offset;

	private static bool GetMousePosition_IsValid;

	private static IntPtr GetMousePosition_FunctionAddress;

	private static int GetMousePosition_ParamsSize;

	private static bool GetMousePosition_LocationX_IsValid;

	private static FFieldAddress GetMousePosition_LocationX_PropertyAddress;

	private static int GetMousePosition_LocationX_Offset;

	private static bool GetMousePosition_LocationY_IsValid;

	private static FFieldAddress GetMousePosition_LocationY_PropertyAddress;

	private static int GetMousePosition_LocationY_Offset;

	private static bool GetMousePosition_ReturnValue_IsValid;

	private static FFieldAddress GetMousePosition_ReturnValue_PropertyAddress;

	private static int GetMousePosition_ReturnValue_Offset;

	private static bool GetInputVectorKeyState_IsValid;

	private static IntPtr GetInputVectorKeyState_FunctionAddress;

	private static int GetInputVectorKeyState_ParamsSize;

	private static bool GetInputVectorKeyState_Key_IsValid;

	private static FFieldAddress GetInputVectorKeyState_Key_PropertyAddress;

	private static int GetInputVectorKeyState_Key_Offset;

	private static bool GetInputVectorKeyState_ReturnValue_IsValid;

	private static FFieldAddress GetInputVectorKeyState_ReturnValue_PropertyAddress;

	private static int GetInputVectorKeyState_ReturnValue_Offset;

	private static bool GetInputTouchState_IsValid;

	private static IntPtr GetInputTouchState_FunctionAddress;

	private static int GetInputTouchState_ParamsSize;

	private static bool GetInputTouchState_FingerIndex_IsValid;

	private static FFieldAddress GetInputTouchState_FingerIndex_PropertyAddress;

	private static int GetInputTouchState_FingerIndex_Offset;

	private static bool GetInputTouchState_LocationX_IsValid;

	private static FFieldAddress GetInputTouchState_LocationX_PropertyAddress;

	private static int GetInputTouchState_LocationX_Offset;

	private static bool GetInputTouchState_LocationY_IsValid;

	private static FFieldAddress GetInputTouchState_LocationY_PropertyAddress;

	private static int GetInputTouchState_LocationY_Offset;

	private static bool GetInputTouchState_bIsCurrentlyPressed_IsValid;

	private static FFieldAddress GetInputTouchState_bIsCurrentlyPressed_PropertyAddress;

	private static int GetInputTouchState_bIsCurrentlyPressed_Offset;

	private static bool GetInputMouseDelta_IsValid;

	private static IntPtr GetInputMouseDelta_FunctionAddress;

	private static int GetInputMouseDelta_ParamsSize;

	private static bool GetInputMouseDelta_DeltaX_IsValid;

	private static FFieldAddress GetInputMouseDelta_DeltaX_PropertyAddress;

	private static int GetInputMouseDelta_DeltaX_Offset;

	private static bool GetInputMouseDelta_DeltaY_IsValid;

	private static FFieldAddress GetInputMouseDelta_DeltaY_PropertyAddress;

	private static int GetInputMouseDelta_DeltaY_Offset;

	private static bool GetInputMotionState_IsValid;

	private static IntPtr GetInputMotionState_FunctionAddress;

	private static int GetInputMotionState_ParamsSize;

	private static bool GetInputMotionState_Tilt_IsValid;

	private static FFieldAddress GetInputMotionState_Tilt_PropertyAddress;

	private static int GetInputMotionState_Tilt_Offset;

	private static bool GetInputMotionState_RotationRate_IsValid;

	private static FFieldAddress GetInputMotionState_RotationRate_PropertyAddress;

	private static int GetInputMotionState_RotationRate_Offset;

	private static bool GetInputMotionState_Gravity_IsValid;

	private static FFieldAddress GetInputMotionState_Gravity_PropertyAddress;

	private static int GetInputMotionState_Gravity_Offset;

	private static bool GetInputMotionState_Acceleration_IsValid;

	private static FFieldAddress GetInputMotionState_Acceleration_PropertyAddress;

	private static int GetInputMotionState_Acceleration_Offset;

	private static bool GetInputKeyTimeDown_IsValid;

	private static IntPtr GetInputKeyTimeDown_FunctionAddress;

	private static int GetInputKeyTimeDown_ParamsSize;

	private static bool GetInputKeyTimeDown_Key_IsValid;

	private static FFieldAddress GetInputKeyTimeDown_Key_PropertyAddress;

	private static int GetInputKeyTimeDown_Key_Offset;

	private static bool GetInputKeyTimeDown_ReturnValue_IsValid;

	private static FFieldAddress GetInputKeyTimeDown_ReturnValue_PropertyAddress;

	private static int GetInputKeyTimeDown_ReturnValue_Offset;

	private static bool GetInputAnalogStickState_IsValid;

	private static IntPtr GetInputAnalogStickState_FunctionAddress;

	private static int GetInputAnalogStickState_ParamsSize;

	private static bool GetInputAnalogStickState_WhichStick_IsValid;

	private static FFieldAddress GetInputAnalogStickState_WhichStick_PropertyAddress;

	private static int GetInputAnalogStickState_WhichStick_Offset;

	private static bool GetInputAnalogStickState_StickX_IsValid;

	private static FFieldAddress GetInputAnalogStickState_StickX_PropertyAddress;

	private static int GetInputAnalogStickState_StickX_Offset;

	private static bool GetInputAnalogStickState_StickY_IsValid;

	private static FFieldAddress GetInputAnalogStickState_StickY_PropertyAddress;

	private static int GetInputAnalogStickState_StickY_Offset;

	private static bool GetInputAnalogKeyState_IsValid;

	private static IntPtr GetInputAnalogKeyState_FunctionAddress;

	private static int GetInputAnalogKeyState_ParamsSize;

	private static bool GetInputAnalogKeyState_Key_IsValid;

	private static FFieldAddress GetInputAnalogKeyState_Key_PropertyAddress;

	private static int GetInputAnalogKeyState_Key_Offset;

	private static bool GetInputAnalogKeyState_ReturnValue_IsValid;

	private static FFieldAddress GetInputAnalogKeyState_ReturnValue_PropertyAddress;

	private static int GetInputAnalogKeyState_ReturnValue_Offset;

	private static bool GetHUD_IsValid;

	private static IntPtr GetHUD_FunctionAddress;

	private static int GetHUD_ParamsSize;

	private static bool GetHUD_ReturnValue_IsValid;

	private static FFieldAddress GetHUD_ReturnValue_PropertyAddress;

	private static int GetHUD_ReturnValue_Offset;

	private static bool GetHitResultUnderFingerForObjects_IsValid;

	private static IntPtr GetHitResultUnderFingerForObjects_FunctionAddress;

	private static int GetHitResultUnderFingerForObjects_ParamsSize;

	private static bool GetHitResultUnderFingerForObjects_FingerIndex_IsValid;

	private static FFieldAddress GetHitResultUnderFingerForObjects_FingerIndex_PropertyAddress;

	private static int GetHitResultUnderFingerForObjects_FingerIndex_Offset;

	private static bool GetHitResultUnderFingerForObjects_ObjectTypes_IsValid;

	private static FFieldAddress GetHitResultUnderFingerForObjects_ObjectTypes_PropertyAddress;

	private static int GetHitResultUnderFingerForObjects_ObjectTypes_Offset;

	private static bool GetHitResultUnderFingerForObjects_bTraceComplex_IsValid;

	private static FFieldAddress GetHitResultUnderFingerForObjects_bTraceComplex_PropertyAddress;

	private static int GetHitResultUnderFingerForObjects_bTraceComplex_Offset;

	private static bool GetHitResultUnderFingerForObjects_HitResult_IsValid;

	private static FFieldAddress GetHitResultUnderFingerForObjects_HitResult_PropertyAddress;

	private static int GetHitResultUnderFingerForObjects_HitResult_Offset;

	private static bool GetHitResultUnderFingerForObjects_ReturnValue_IsValid;

	private static FFieldAddress GetHitResultUnderFingerForObjects_ReturnValue_PropertyAddress;

	private static int GetHitResultUnderFingerForObjects_ReturnValue_Offset;

	private static bool GetHitResultUnderFingerByChannel_IsValid;

	private static IntPtr GetHitResultUnderFingerByChannel_FunctionAddress;

	private static int GetHitResultUnderFingerByChannel_ParamsSize;

	private static bool GetHitResultUnderFingerByChannel_FingerIndex_IsValid;

	private static FFieldAddress GetHitResultUnderFingerByChannel_FingerIndex_PropertyAddress;

	private static int GetHitResultUnderFingerByChannel_FingerIndex_Offset;

	private static bool GetHitResultUnderFingerByChannel_TraceChannel_IsValid;

	private static FFieldAddress GetHitResultUnderFingerByChannel_TraceChannel_PropertyAddress;

	private static int GetHitResultUnderFingerByChannel_TraceChannel_Offset;

	private static bool GetHitResultUnderFingerByChannel_bTraceComplex_IsValid;

	private static FFieldAddress GetHitResultUnderFingerByChannel_bTraceComplex_PropertyAddress;

	private static int GetHitResultUnderFingerByChannel_bTraceComplex_Offset;

	private static bool GetHitResultUnderFingerByChannel_HitResult_IsValid;

	private static FFieldAddress GetHitResultUnderFingerByChannel_HitResult_PropertyAddress;

	private static int GetHitResultUnderFingerByChannel_HitResult_Offset;

	private static bool GetHitResultUnderFingerByChannel_ReturnValue_IsValid;

	private static FFieldAddress GetHitResultUnderFingerByChannel_ReturnValue_PropertyAddress;

	private static int GetHitResultUnderFingerByChannel_ReturnValue_Offset;

	private static bool GetHitResultUnderCursorForObjects_IsValid;

	private static IntPtr GetHitResultUnderCursorForObjects_FunctionAddress;

	private static int GetHitResultUnderCursorForObjects_ParamsSize;

	private static bool GetHitResultUnderCursorForObjects_ObjectTypes_IsValid;

	private static FFieldAddress GetHitResultUnderCursorForObjects_ObjectTypes_PropertyAddress;

	private static int GetHitResultUnderCursorForObjects_ObjectTypes_Offset;

	private static bool GetHitResultUnderCursorForObjects_bTraceComplex_IsValid;

	private static FFieldAddress GetHitResultUnderCursorForObjects_bTraceComplex_PropertyAddress;

	private static int GetHitResultUnderCursorForObjects_bTraceComplex_Offset;

	private static bool GetHitResultUnderCursorForObjects_HitResult_IsValid;

	private static FFieldAddress GetHitResultUnderCursorForObjects_HitResult_PropertyAddress;

	private static int GetHitResultUnderCursorForObjects_HitResult_Offset;

	private static bool GetHitResultUnderCursorForObjects_ReturnValue_IsValid;

	private static FFieldAddress GetHitResultUnderCursorForObjects_ReturnValue_PropertyAddress;

	private static int GetHitResultUnderCursorForObjects_ReturnValue_Offset;

	private static bool GetHitResultUnderCursorByChannel_IsValid;

	private static IntPtr GetHitResultUnderCursorByChannel_FunctionAddress;

	private static int GetHitResultUnderCursorByChannel_ParamsSize;

	private static bool GetHitResultUnderCursorByChannel_TraceChannel_IsValid;

	private static FFieldAddress GetHitResultUnderCursorByChannel_TraceChannel_PropertyAddress;

	private static int GetHitResultUnderCursorByChannel_TraceChannel_Offset;

	private static bool GetHitResultUnderCursorByChannel_bTraceComplex_IsValid;

	private static FFieldAddress GetHitResultUnderCursorByChannel_bTraceComplex_PropertyAddress;

	private static int GetHitResultUnderCursorByChannel_bTraceComplex_Offset;

	private static bool GetHitResultUnderCursorByChannel_HitResult_IsValid;

	private static FFieldAddress GetHitResultUnderCursorByChannel_HitResult_PropertyAddress;

	private static int GetHitResultUnderCursorByChannel_HitResult_Offset;

	private static bool GetHitResultUnderCursorByChannel_ReturnValue_IsValid;

	private static FFieldAddress GetHitResultUnderCursorByChannel_ReturnValue_PropertyAddress;

	private static int GetHitResultUnderCursorByChannel_ReturnValue_Offset;

	private static bool GetFocalLocation_IsValid;

	private static IntPtr GetFocalLocation_FunctionAddress;

	private static int GetFocalLocation_ParamsSize;

	private static bool GetFocalLocation_ReturnValue_IsValid;

	private static FFieldAddress GetFocalLocation_ReturnValue_PropertyAddress;

	private static int GetFocalLocation_ReturnValue_Offset;

	private static bool GetDeprecatedInputYawScale_IsValid;

	private static IntPtr GetDeprecatedInputYawScale_FunctionAddress;

	private static int GetDeprecatedInputYawScale_ParamsSize;

	private static bool GetDeprecatedInputYawScale_ReturnValue_IsValid;

	private static FFieldAddress GetDeprecatedInputYawScale_ReturnValue_PropertyAddress;

	private static int GetDeprecatedInputYawScale_ReturnValue_Offset;

	private static bool GetDeprecatedInputRollScale_IsValid;

	private static IntPtr GetDeprecatedInputRollScale_FunctionAddress;

	private static int GetDeprecatedInputRollScale_ParamsSize;

	private static bool GetDeprecatedInputRollScale_ReturnValue_IsValid;

	private static FFieldAddress GetDeprecatedInputRollScale_ReturnValue_PropertyAddress;

	private static int GetDeprecatedInputRollScale_ReturnValue_Offset;

	private static bool GetDeprecatedInputPitchScale_IsValid;

	private static IntPtr GetDeprecatedInputPitchScale_FunctionAddress;

	private static int GetDeprecatedInputPitchScale_ParamsSize;

	private static bool GetDeprecatedInputPitchScale_ReturnValue_IsValid;

	private static FFieldAddress GetDeprecatedInputPitchScale_ReturnValue_PropertyAddress;

	private static int GetDeprecatedInputPitchScale_ReturnValue_Offset;

	private static bool DeprojectScreenPositionToWorld_IsValid;

	private static IntPtr DeprojectScreenPositionToWorld_FunctionAddress;

	private static int DeprojectScreenPositionToWorld_ParamsSize;

	private static bool DeprojectScreenPositionToWorld_ScreenX_IsValid;

	private static FFieldAddress DeprojectScreenPositionToWorld_ScreenX_PropertyAddress;

	private static int DeprojectScreenPositionToWorld_ScreenX_Offset;

	private static bool DeprojectScreenPositionToWorld_ScreenY_IsValid;

	private static FFieldAddress DeprojectScreenPositionToWorld_ScreenY_PropertyAddress;

	private static int DeprojectScreenPositionToWorld_ScreenY_Offset;

	private static bool DeprojectScreenPositionToWorld_WorldLocation_IsValid;

	private static FFieldAddress DeprojectScreenPositionToWorld_WorldLocation_PropertyAddress;

	private static int DeprojectScreenPositionToWorld_WorldLocation_Offset;

	private static bool DeprojectScreenPositionToWorld_WorldDirection_IsValid;

	private static FFieldAddress DeprojectScreenPositionToWorld_WorldDirection_PropertyAddress;

	private static int DeprojectScreenPositionToWorld_WorldDirection_Offset;

	private static bool DeprojectScreenPositionToWorld_ReturnValue_IsValid;

	private static FFieldAddress DeprojectScreenPositionToWorld_ReturnValue_PropertyAddress;

	private static int DeprojectScreenPositionToWorld_ReturnValue_Offset;

	private static bool DeprojectMousePositionToWorld_IsValid;

	private static IntPtr DeprojectMousePositionToWorld_FunctionAddress;

	private static int DeprojectMousePositionToWorld_ParamsSize;

	private static bool DeprojectMousePositionToWorld_WorldLocation_IsValid;

	private static FFieldAddress DeprojectMousePositionToWorld_WorldLocation_PropertyAddress;

	private static int DeprojectMousePositionToWorld_WorldLocation_Offset;

	private static bool DeprojectMousePositionToWorld_WorldDirection_IsValid;

	private static FFieldAddress DeprojectMousePositionToWorld_WorldDirection_PropertyAddress;

	private static int DeprojectMousePositionToWorld_WorldDirection_Offset;

	private static bool DeprojectMousePositionToWorld_ReturnValue_IsValid;

	private static FFieldAddress DeprojectMousePositionToWorld_ReturnValue_PropertyAddress;

	private static int DeprojectMousePositionToWorld_ReturnValue_Offset;

	private static bool ClientStopForceFeedback_IsValid;

	private static IntPtr ClientStopForceFeedback_FunctionAddress;

	private static int ClientStopForceFeedback_ParamsSize;

	private static bool ClientStopForceFeedback_ForceFeedbackEffect_IsValid;

	private static FFieldAddress ClientStopForceFeedback_ForceFeedbackEffect_PropertyAddress;

	private static int ClientStopForceFeedback_ForceFeedbackEffect_Offset;

	private static bool ClientStopForceFeedback_Tag_IsValid;

	private static FFieldAddress ClientStopForceFeedback_Tag_PropertyAddress;

	private static int ClientStopForceFeedback_Tag_Offset;

	private static bool ClientStopCameraShakesFromSource_IsValid;

	private static IntPtr ClientStopCameraShakesFromSource_FunctionAddress;

	private static int ClientStopCameraShakesFromSource_ParamsSize;

	private static bool ClientStopCameraShakesFromSource_SourceComponent_IsValid;

	private static FFieldAddress ClientStopCameraShakesFromSource_SourceComponent_PropertyAddress;

	private static int ClientStopCameraShakesFromSource_SourceComponent_Offset;

	private static bool ClientStopCameraShakesFromSource_bImmediately_IsValid;

	private static FFieldAddress ClientStopCameraShakesFromSource_bImmediately_PropertyAddress;

	private static int ClientStopCameraShakesFromSource_bImmediately_Offset;

	private static bool ClientStopCameraShake_IsValid;

	private static IntPtr ClientStopCameraShake_FunctionAddress;

	private static int ClientStopCameraShake_ParamsSize;

	private static bool ClientStopCameraShake_Shake_IsValid;

	private static FFieldAddress ClientStopCameraShake_Shake_PropertyAddress;

	private static int ClientStopCameraShake_Shake_Offset;

	private static bool ClientStopCameraShake_bImmediately_IsValid;

	private static FFieldAddress ClientStopCameraShake_bImmediately_PropertyAddress;

	private static int ClientStopCameraShake_bImmediately_Offset;

	private static bool ClientStartCameraShakeFromSource_IsValid;

	private static IntPtr ClientStartCameraShakeFromSource_FunctionAddress;

	private static int ClientStartCameraShakeFromSource_ParamsSize;

	private static bool ClientStartCameraShakeFromSource_Shake_IsValid;

	private static FFieldAddress ClientStartCameraShakeFromSource_Shake_PropertyAddress;

	private static int ClientStartCameraShakeFromSource_Shake_Offset;

	private static bool ClientStartCameraShakeFromSource_SourceComponent_IsValid;

	private static FFieldAddress ClientStartCameraShakeFromSource_SourceComponent_PropertyAddress;

	private static int ClientStartCameraShakeFromSource_SourceComponent_Offset;

	private static bool ClientStartCameraShake_IsValid;

	private static IntPtr ClientStartCameraShake_FunctionAddress;

	private static int ClientStartCameraShake_ParamsSize;

	private static bool ClientStartCameraShake_Shake_IsValid;

	private static FFieldAddress ClientStartCameraShake_Shake_PropertyAddress;

	private static int ClientStartCameraShake_Shake_Offset;

	private static bool ClientStartCameraShake_Scale_IsValid;

	private static FFieldAddress ClientStartCameraShake_Scale_PropertyAddress;

	private static int ClientStartCameraShake_Scale_Offset;

	private static bool ClientStartCameraShake_PlaySpace_IsValid;

	private static FFieldAddress ClientStartCameraShake_PlaySpace_PropertyAddress;

	private static int ClientStartCameraShake_PlaySpace_Offset;

	private static bool ClientStartCameraShake_UserPlaySpaceRot_IsValid;

	private static FFieldAddress ClientStartCameraShake_UserPlaySpaceRot_PropertyAddress;

	private static int ClientStartCameraShake_UserPlaySpaceRot_Offset;

	private static bool ClientSpawnGenericCameraLensEffect_IsValid;

	private static IntPtr ClientSpawnGenericCameraLensEffect_FunctionAddress;

	private static int ClientSpawnGenericCameraLensEffect_ParamsSize;

	private static bool ClientSpawnGenericCameraLensEffect_LensEffectEmitterClass_IsValid;

	private static FFieldAddress ClientSpawnGenericCameraLensEffect_LensEffectEmitterClass_PropertyAddress;

	private static int ClientSpawnGenericCameraLensEffect_LensEffectEmitterClass_Offset;

	private static bool ClientSetHUD_IsValid;

	private static IntPtr ClientSetHUD_FunctionAddress;

	private static int ClientSetHUD_ParamsSize;

	private static bool ClientSetHUD_NewHUDClass_IsValid;

	private static FFieldAddress ClientSetHUD_NewHUDClass_PropertyAddress;

	private static int ClientSetHUD_NewHUDClass_Offset;

	private static bool ClientPlayCameraAnim_IsValid;

	private static IntPtr ClientPlayCameraAnim_FunctionAddress;

	private static int ClientPlayCameraAnim_ParamsSize;

	private static bool ClientPlayCameraAnim_AnimToPlay_IsValid;

	private static FFieldAddress ClientPlayCameraAnim_AnimToPlay_PropertyAddress;

	private static int ClientPlayCameraAnim_AnimToPlay_Offset;

	private static bool ClientPlayCameraAnim_Scale_IsValid;

	private static FFieldAddress ClientPlayCameraAnim_Scale_PropertyAddress;

	private static int ClientPlayCameraAnim_Scale_Offset;

	private static bool ClientPlayCameraAnim_Rate_IsValid;

	private static FFieldAddress ClientPlayCameraAnim_Rate_PropertyAddress;

	private static int ClientPlayCameraAnim_Rate_Offset;

	private static bool ClientPlayCameraAnim_BlendInTime_IsValid;

	private static FFieldAddress ClientPlayCameraAnim_BlendInTime_PropertyAddress;

	private static int ClientPlayCameraAnim_BlendInTime_Offset;

	private static bool ClientPlayCameraAnim_BlendOutTime_IsValid;

	private static FFieldAddress ClientPlayCameraAnim_BlendOutTime_PropertyAddress;

	private static int ClientPlayCameraAnim_BlendOutTime_Offset;

	private static bool ClientPlayCameraAnim_bLoop_IsValid;

	private static FFieldAddress ClientPlayCameraAnim_bLoop_PropertyAddress;

	private static int ClientPlayCameraAnim_bLoop_Offset;

	private static bool ClientPlayCameraAnim_bRandomStartTime_IsValid;

	private static FFieldAddress ClientPlayCameraAnim_bRandomStartTime_PropertyAddress;

	private static int ClientPlayCameraAnim_bRandomStartTime_Offset;

	private static bool ClientPlayCameraAnim_Space_IsValid;

	private static FFieldAddress ClientPlayCameraAnim_Space_PropertyAddress;

	private static int ClientPlayCameraAnim_Space_Offset;

	private static bool ClientPlayCameraAnim_CustomPlaySpace_IsValid;

	private static FFieldAddress ClientPlayCameraAnim_CustomPlaySpace_PropertyAddress;

	private static int ClientPlayCameraAnim_CustomPlaySpace_Offset;

	private static bool ClientClearCameraLensEffects_IsValid;

	private static IntPtr ClientClearCameraLensEffects_FunctionAddress;

	private static int ClientClearCameraLensEffects_ParamsSize;

	private static bool ClearAudioListenerOverride_IsValid;

	private static IntPtr ClearAudioListenerOverride_FunctionAddress;

	private static int ClearAudioListenerOverride_ParamsSize;

	private static bool ClearAudioListenerAttenuationOverride_IsValid;

	private static IntPtr ClearAudioListenerAttenuationOverride_FunctionAddress;

	private static int ClearAudioListenerAttenuationOverride_ParamsSize;

	private static bool CanRestartPlayer_IsValid;

	private static IntPtr CanRestartPlayer_FunctionAddress;

	private static int CanRestartPlayer_ParamsSize;

	private static bool CanRestartPlayer_ReturnValue_IsValid;

	private static FFieldAddress CanRestartPlayer_ReturnValue_PropertyAddress;

	private static int CanRestartPlayer_ReturnValue_Offset;

	private static bool AddYawInput_IsValid;

	private static IntPtr AddYawInput_FunctionAddress;

	private static int AddYawInput_ParamsSize;

	private static bool AddYawInput_Val_IsValid;

	private static FFieldAddress AddYawInput_Val_PropertyAddress;

	private static int AddYawInput_Val_Offset;

	private static bool AddRollInput_IsValid;

	private static IntPtr AddRollInput_FunctionAddress;

	private static int AddRollInput_ParamsSize;

	private static bool AddRollInput_Val_IsValid;

	private static FFieldAddress AddRollInput_Val_PropertyAddress;

	private static int AddRollInput_Val_Offset;

	private static bool AddPitchInput_IsValid;

	private static IntPtr AddPitchInput_FunctionAddress;

	private static int AddPitchInput_ParamsSize;

	private static bool AddPitchInput_Val_IsValid;

	private static FFieldAddress AddPitchInput_Val_PropertyAddress;

	private static int AddPitchInput_Val_Offset;

	private static bool ActivateTouchInterface_IsValid;

	private static IntPtr ActivateTouchInterface_FunctionAddress;

	private static int ActivateTouchInterface_ParamsSize;

	private static bool ActivateTouchInterface_NewTouchInterface_IsValid;

	private static FFieldAddress ActivateTouchInterface_NewTouchInterface_PropertyAddress;

	private static int ActivateTouchInterface_NewTouchInterface_Offset;

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/Engine.PlayerController:PlayerCameraManager")]
	public APlayerCameraManager PlayerCameraManager
	{
		get
		{
			CheckDestroyed();
			if (!PlayerCameraManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:PlayerCameraManager");
				return null;
			}
			return UObjectMarshaler<APlayerCameraManager>.FromNative(IntPtr.Add(base.Address, PlayerCameraManager_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerCameraManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:PlayerCameraManager");
			}
			else
			{
				UObjectMarshaler<APlayerCameraManager>.ToNative(IntPtr.Add(base.Address, PlayerCameraManager_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.PlayerController:PlayerCameraManagerClass")]
	public TSubclassOf<APlayerCameraManager> PlayerCameraManagerClass
	{
		get
		{
			CheckDestroyed();
			if (!PlayerCameraManagerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:PlayerCameraManagerClass");
				return default(TSubclassOf<APlayerCameraManager>);
			}
			return TSubclassOfMarshaler<APlayerCameraManager>.FromNative(IntPtr.Add(base.Address, PlayerCameraManagerClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerCameraManagerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:PlayerCameraManagerClass");
			}
			else
			{
				TSubclassOfMarshaler<APlayerCameraManager>.ToNative(IntPtr.Add(base.Address, PlayerCameraManagerClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerController:SmoothTargetViewRotationSpeed")]
	public float SmoothTargetViewRotationSpeed
	{
		get
		{
			CheckDestroyed();
			if (!SmoothTargetViewRotationSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:SmoothTargetViewRotationSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SmoothTargetViewRotationSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SmoothTargetViewRotationSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:SmoothTargetViewRotationSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SmoothTargetViewRotationSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141125652uL)]
	[UMetaPath("/Script/Engine.PlayerController:CheatManager")]
	public UCheatManager CheatManager
	{
		get
		{
			CheckDestroyed();
			if (!CheatManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:CheatManager");
				return null;
			}
			return UObjectMarshaler<UCheatManager>.FromNative(IntPtr.Add(base.Address, CheatManager_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheatManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:CheatManager");
			}
			else
			{
				UObjectMarshaler<UCheatManager>.ToNative(IntPtr.Add(base.Address, CheatManager_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141182997uL)]
	[UMetaPath("/Script/Engine.PlayerController:CheatClass")]
	protected TSubclassOf<UCheatManager> CheatClass
	{
		get
		{
			CheckDestroyed();
			if (!CheatClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:CheatClass");
				return default(TSubclassOf<UCheatManager>);
			}
			return TSubclassOfMarshaler<UCheatManager>.FromNative(IntPtr.Add(base.Address, CheatClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheatClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:CheatClass");
			}
			else
			{
				TSubclassOfMarshaler<UCheatManager>.ToNative(IntPtr.Add(base.Address, CheatClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160665621uL)]
	[UMetaPath("/Script/Engine.PlayerController:bPlayerIsWaiting")]
	public bool PlayerIsWaiting
	{
		get
		{
			CheckDestroyed();
			if (!PlayerIsWaiting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bPlayerIsWaiting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PlayerIsWaiting_Offset), 0, PlayerIsWaiting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PlayerIsWaiting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bPlayerIsWaiting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PlayerIsWaiting_Offset), 0, PlayerIsWaiting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PlayerController:bShowMouseCursor")]
	public bool ShowMouseCursor
	{
		get
		{
			CheckDestroyed();
			if (!ShowMouseCursor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bShowMouseCursor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowMouseCursor_Offset), 0, ShowMouseCursor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowMouseCursor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bShowMouseCursor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowMouseCursor_Offset), 0, ShowMouseCursor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PlayerController:bEnableClickEvents")]
	public bool EnableClickEvents
	{
		get
		{
			CheckDestroyed();
			if (!EnableClickEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bEnableClickEvents");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableClickEvents_Offset), 0, EnableClickEvents_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableClickEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bEnableClickEvents");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableClickEvents_Offset), 0, EnableClickEvents_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PlayerController:bEnableTouchEvents")]
	public bool EnableTouchEvents
	{
		get
		{
			CheckDestroyed();
			if (!EnableTouchEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bEnableTouchEvents");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableTouchEvents_Offset), 0, EnableTouchEvents_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableTouchEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bEnableTouchEvents");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableTouchEvents_Offset), 0, EnableTouchEvents_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PlayerController:bEnableMouseOverEvents")]
	public bool EnableMouseOverEvents
	{
		get
		{
			CheckDestroyed();
			if (!EnableMouseOverEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bEnableMouseOverEvents");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableMouseOverEvents_Offset), 0, EnableMouseOverEvents_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableMouseOverEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bEnableMouseOverEvents");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableMouseOverEvents_Offset), 0, EnableMouseOverEvents_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PlayerController:bEnableTouchOverEvents")]
	public bool EnableTouchOverEvents
	{
		get
		{
			CheckDestroyed();
			if (!EnableTouchOverEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bEnableTouchOverEvents");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableTouchOverEvents_Offset), 0, EnableTouchOverEvents_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableTouchOverEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bEnableTouchOverEvents");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableTouchOverEvents_Offset), 0, EnableTouchOverEvents_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PlayerController:bForceFeedbackEnabled")]
	public bool ForceFeedbackEnabled
	{
		get
		{
			CheckDestroyed();
			if (!ForceFeedbackEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bForceFeedbackEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceFeedbackEnabled_Offset), 0, ForceFeedbackEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceFeedbackEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bForceFeedbackEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceFeedbackEnabled_Offset), 0, ForceFeedbackEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PlayerController:bEnableStreamingSource")]
	public bool EnableStreamingSource
	{
		get
		{
			CheckDestroyed();
			if (!EnableStreamingSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bEnableStreamingSource");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableStreamingSource_Offset), 0, EnableStreamingSource_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableStreamingSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bEnableStreamingSource");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableStreamingSource_Offset), 0, EnableStreamingSource_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PlayerController:bStreamingSourceShouldActivate")]
	public bool StreamingSourceShouldActivate
	{
		get
		{
			CheckDestroyed();
			if (!StreamingSourceShouldActivate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bStreamingSourceShouldActivate");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StreamingSourceShouldActivate_Offset), 0, StreamingSourceShouldActivate_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StreamingSourceShouldActivate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bStreamingSourceShouldActivate");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StreamingSourceShouldActivate_Offset), 0, StreamingSourceShouldActivate_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PlayerController:bStreamingSourceShouldBlockOnSlowStreaming")]
	public bool StreamingSourceShouldBlockOnSlowStreaming
	{
		get
		{
			CheckDestroyed();
			if (!StreamingSourceShouldBlockOnSlowStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bStreamingSourceShouldBlockOnSlowStreaming");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StreamingSourceShouldBlockOnSlowStreaming_Offset), 0, StreamingSourceShouldBlockOnSlowStreaming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StreamingSourceShouldBlockOnSlowStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bStreamingSourceShouldBlockOnSlowStreaming");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StreamingSourceShouldBlockOnSlowStreaming_Offset), 0, StreamingSourceShouldBlockOnSlowStreaming_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.PlayerController:ClickEventKeys")]
	public TArrayReadWrite<FKey> ClickEventKeys
	{
		get
		{
			CheckDestroyed();
			if (!ClickEventKeys_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:ClickEventKeys");
				return null;
			}
			if (ClickEventKeys_MarshalerCached == null)
			{
				ClickEventKeys_MarshalerCached = new TArrayReadWriteMarshaler<FKey>(1, ClickEventKeys_PropertyAddress, CachedMarshalingDelegates<FKey, FKey>.FromNative, CachedMarshalingDelegates<FKey, FKey>.ToNative);
			}
			return ClickEventKeys_MarshalerCached.FromNative(IntPtr.Add(base.Address, ClickEventKeys_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.PlayerController:DefaultMouseCursor")]
	public EMouseCursor DefaultMouseCursor
	{
		get
		{
			CheckDestroyed();
			if (!DefaultMouseCursor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:DefaultMouseCursor");
				return EMouseCursor.None;
			}
			return EnumMarshaler<EMouseCursor>.FromNative(IntPtr.Add(base.Address, DefaultMouseCursor_Offset), 0, DefaultMouseCursor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DefaultMouseCursor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:DefaultMouseCursor");
			}
			else
			{
				EnumMarshaler<EMouseCursor>.ToNative(IntPtr.Add(base.Address, DefaultMouseCursor_Offset), 0, DefaultMouseCursor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.PlayerController:CurrentMouseCursor")]
	public EMouseCursor CurrentMouseCursor
	{
		get
		{
			CheckDestroyed();
			if (!CurrentMouseCursor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:CurrentMouseCursor");
				return EMouseCursor.None;
			}
			return EnumMarshaler<EMouseCursor>.FromNative(IntPtr.Add(base.Address, CurrentMouseCursor_Offset), 0, CurrentMouseCursor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CurrentMouseCursor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:CurrentMouseCursor");
			}
			else
			{
				EnumMarshaler<EMouseCursor>.ToNative(IntPtr.Add(base.Address, CurrentMouseCursor_Offset), 0, CurrentMouseCursor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.PlayerController:DefaultClickTraceChannel")]
	public ECollisionChannel DefaultClickTraceChannel
	{
		get
		{
			CheckDestroyed();
			if (!DefaultClickTraceChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:DefaultClickTraceChannel");
				return ECollisionChannel.ECC_WorldStatic;
			}
			return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(base.Address, DefaultClickTraceChannel_Offset), 0, DefaultClickTraceChannel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DefaultClickTraceChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:DefaultClickTraceChannel");
			}
			else
			{
				EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(base.Address, DefaultClickTraceChannel_Offset), 0, DefaultClickTraceChannel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.PlayerController:CurrentClickTraceChannel")]
	public ECollisionChannel CurrentClickTraceChannel
	{
		get
		{
			CheckDestroyed();
			if (!CurrentClickTraceChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:CurrentClickTraceChannel");
				return ECollisionChannel.ECC_WorldStatic;
			}
			return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(base.Address, CurrentClickTraceChannel_Offset), 0, CurrentClickTraceChannel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CurrentClickTraceChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:CurrentClickTraceChannel");
			}
			else
			{
				EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(base.Address, CurrentClickTraceChannel_Offset), 0, CurrentClickTraceChannel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PlayerController:HitResultTraceDistance")]
	public float HitResultTraceDistance
	{
		get
		{
			CheckDestroyed();
			if (!HitResultTraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:HitResultTraceDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HitResultTraceDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitResultTraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:HitResultTraceDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HitResultTraceDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880925189uL)]
	[UMetaPath("/Script/Engine.PlayerController:bShouldPerformFullTickWhenPaused")]
	protected bool ShouldPerformFullTickWhenPaused
	{
		get
		{
			CheckDestroyed();
			if (!ShouldPerformFullTickWhenPaused_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bShouldPerformFullTickWhenPaused");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldPerformFullTickWhenPaused_Offset), 0, ShouldPerformFullTickWhenPaused_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldPerformFullTickWhenPaused_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlayerController:bShouldPerformFullTickWhenPaused");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldPerformFullTickWhenPaused_Offset), 0, ShouldPerformFullTickWhenPaused_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerController:WasInputKeyJustReleased")]
	public unsafe bool WasInputKeyJustReleased(FKey Key)
	{
		CheckDestroyed();
		if (!WasInputKeyJustReleased_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:WasInputKeyJustReleased");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WasInputKeyJustReleased_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WasInputKeyJustReleased_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(WasInputKeyJustReleased_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, WasInputKeyJustReleased_Key_Offset), 0, WasInputKeyJustReleased_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeFunctionOptimized(base.Address, WasInputKeyJustReleased_FunctionAddress, intPtr, WasInputKeyJustReleased_ParamsSize);
		NativeReflection.DestroyValue_InContainer(WasInputKeyJustReleased_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WasInputKeyJustReleased_ReturnValue_Offset), 0, WasInputKeyJustReleased_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerController:WasInputKeyJustPressed")]
	public unsafe bool WasInputKeyJustPressed(FKey Key)
	{
		CheckDestroyed();
		if (!WasInputKeyJustPressed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:WasInputKeyJustPressed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WasInputKeyJustPressed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WasInputKeyJustPressed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(WasInputKeyJustPressed_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, WasInputKeyJustPressed_Key_Offset), 0, WasInputKeyJustPressed_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeFunctionOptimized(base.Address, WasInputKeyJustPressed_FunctionAddress, intPtr, WasInputKeyJustPressed_ParamsSize);
		NativeReflection.DestroyValue_InContainer(WasInputKeyJustPressed_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WasInputKeyJustPressed_ReturnValue_Offset), 0, WasInputKeyJustPressed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PlayerController:StreamingSourceShouldBlockOnSlowStreaming")]
	public unsafe bool StreamingSourceShouldBlockOnSlowStreaming_C5C07849()
	{
		CheckDestroyed();
		if (!StreamingSourceShouldBlockOnSlowStreaming_C5C07849_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:StreamingSourceShouldBlockOnSlowStreaming");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StreamingSourceShouldBlockOnSlowStreaming_C5C07849_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StreamingSourceShouldBlockOnSlowStreaming_C5C07849_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, StreamingSourceShouldBlockOnSlowStreaming_C5C07849_FunctionAddress, intPtr, StreamingSourceShouldBlockOnSlowStreaming_C5C07849_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, StreamingSourceShouldBlockOnSlowStreaming_C5C07849_ReturnValue_Offset), 0, StreamingSourceShouldBlockOnSlowStreaming_C5C07849_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PlayerController:StreamingSourceShouldActivate")]
	public unsafe bool StreamingSourceShouldActivate_E1011EAF()
	{
		CheckDestroyed();
		if (!StreamingSourceShouldActivate_E1011EAF_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:StreamingSourceShouldActivate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StreamingSourceShouldActivate_E1011EAF_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StreamingSourceShouldActivate_E1011EAF_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, StreamingSourceShouldActivate_E1011EAF_FunctionAddress, intPtr, StreamingSourceShouldActivate_E1011EAF_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, StreamingSourceShouldActivate_E1011EAF_ReturnValue_Offset), 0, StreamingSourceShouldActivate_E1011EAF_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlayerController:StopHapticEffect")]
	public unsafe void StopHapticEffect(EControllerHand Hand)
	{
		CheckDestroyed();
		if (!StopHapticEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:StopHapticEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopHapticEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopHapticEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EControllerHand>.ToNative(IntPtr.Add(intPtr, StopHapticEffect_Hand_Offset), 0, StopHapticEffect_Hand_PropertyAddress.Address, Hand);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopHapticEffect_FunctionAddress, intPtr, StopHapticEffect_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerController:SetVirtualJoystickVisibility")]
	public unsafe void SetVirtualJoystickVisibility(bool bVisible)
	{
		CheckDestroyed();
		if (!SetVirtualJoystickVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:SetVirtualJoystickVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVirtualJoystickVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVirtualJoystickVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetVirtualJoystickVisibility_bVisible_Offset), 0, SetVirtualJoystickVisibility_bVisible_PropertyAddress.Address, bVisible);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVirtualJoystickVisibility_FunctionAddress, intPtr, SetVirtualJoystickVisibility_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerController:SetViewTargetWithBlend")]
	public unsafe void SetViewTargetWithBlend(AActor NewViewTarget, float BlendTime = 0f, EViewTargetBlendFunction BlendFunc = EViewTargetBlendFunction.VTBlend_Linear, float BlendExp = 0f, bool bLockOutgoing = false)
	{
		CheckDestroyed();
		if (!SetViewTargetWithBlend_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:SetViewTargetWithBlend");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewTargetWithBlend_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewTargetWithBlend_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetViewTargetWithBlend_NewViewTarget_Offset), 0, SetViewTargetWithBlend_NewViewTarget_PropertyAddress.Address, NewViewTarget);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetViewTargetWithBlend_BlendTime_Offset), 0, SetViewTargetWithBlend_BlendTime_PropertyAddress.Address, BlendTime);
		EnumMarshaler<EViewTargetBlendFunction>.ToNative(IntPtr.Add(intPtr, SetViewTargetWithBlend_BlendFunc_Offset), 0, SetViewTargetWithBlend_BlendFunc_PropertyAddress.Address, BlendFunc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetViewTargetWithBlend_BlendExp_Offset), 0, SetViewTargetWithBlend_BlendExp_PropertyAddress.Address, BlendExp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetViewTargetWithBlend_bLockOutgoing_Offset), 0, SetViewTargetWithBlend_bLockOutgoing_PropertyAddress.Address, bLockOutgoing);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewTargetWithBlend_FunctionAddress, intPtr, SetViewTargetWithBlend_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlayerController:SetMouseLocation")]
	public unsafe void SetMouseLocation(int X, int Y)
	{
		CheckDestroyed();
		if (!SetMouseLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:SetMouseLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMouseLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMouseLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMouseLocation_X_Offset), 0, SetMouseLocation_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetMouseLocation_Y_Offset), 0, SetMouseLocation_Y_PropertyAddress.Address, Y);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMouseLocation_FunctionAddress, intPtr, SetMouseLocation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlayerController:SetMouseCursorWidget")]
	public unsafe void SetMouseCursorWidget(EMouseCursor Cursor, UUserWidget CursorWidget)
	{
		CheckDestroyed();
		if (!SetMouseCursorWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:SetMouseCursorWidget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMouseCursorWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMouseCursorWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMouseCursor>.ToNative(IntPtr.Add(intPtr, SetMouseCursorWidget_Cursor_Offset), 0, SetMouseCursorWidget_Cursor_PropertyAddress.Address, Cursor);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, SetMouseCursorWidget_CursorWidget_Offset), 0, SetMouseCursorWidget_CursorWidget_PropertyAddress.Address, CursorWidget);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMouseCursorWidget_FunctionAddress, intPtr, SetMouseCursorWidget_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlayerController:SetHapticsByValue")]
	public unsafe void SetHapticsByValue(float Frequency, float Amplitude, EControllerHand Hand)
	{
		CheckDestroyed();
		if (!SetHapticsByValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:SetHapticsByValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHapticsByValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHapticsByValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetHapticsByValue_Frequency_Offset), 0, SetHapticsByValue_Frequency_PropertyAddress.Address, Frequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetHapticsByValue_Amplitude_Offset), 0, SetHapticsByValue_Amplitude_PropertyAddress.Address, Amplitude);
		EnumMarshaler<EControllerHand>.ToNative(IntPtr.Add(intPtr, SetHapticsByValue_Hand_Offset), 0, SetHapticsByValue_Hand_PropertyAddress.Address, Hand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHapticsByValue_FunctionAddress, intPtr, SetHapticsByValue_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerController:SetDisableHaptics")]
	public unsafe void SetDisableHaptics(bool bNewDisabled)
	{
		CheckDestroyed();
		if (!SetDisableHaptics_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:SetDisableHaptics");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDisableHaptics_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDisableHaptics_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDisableHaptics_bNewDisabled_Offset), 0, SetDisableHaptics_bNewDisabled_PropertyAddress.Address, bNewDisabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDisableHaptics_FunctionAddress, intPtr, SetDisableHaptics_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlayerController:SetDeprecatedInputYawScale")]
	public unsafe void SetDeprecatedInputYawScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetDeprecatedInputYawScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:SetDeprecatedInputYawScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDeprecatedInputYawScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDeprecatedInputYawScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDeprecatedInputYawScale_NewValue_Offset), 0, SetDeprecatedInputYawScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDeprecatedInputYawScale_FunctionAddress, intPtr, SetDeprecatedInputYawScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlayerController:SetDeprecatedInputRollScale")]
	public unsafe void SetDeprecatedInputRollScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetDeprecatedInputRollScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:SetDeprecatedInputRollScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDeprecatedInputRollScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDeprecatedInputRollScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDeprecatedInputRollScale_NewValue_Offset), 0, SetDeprecatedInputRollScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDeprecatedInputRollScale_FunctionAddress, intPtr, SetDeprecatedInputRollScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlayerController:SetDeprecatedInputPitchScale")]
	public unsafe void SetDeprecatedInputPitchScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetDeprecatedInputPitchScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:SetDeprecatedInputPitchScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDeprecatedInputPitchScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDeprecatedInputPitchScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDeprecatedInputPitchScale_NewValue_Offset), 0, SetDeprecatedInputPitchScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDeprecatedInputPitchScale_FunctionAddress, intPtr, SetDeprecatedInputPitchScale_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PlayerController:SetControllerLightColor")]
	public unsafe void SetControllerLightColor(FColor Color)
	{
		CheckDestroyed();
		if (!SetControllerLightColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:SetControllerLightColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControllerLightColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControllerLightColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, SetControllerLightColor_Color_Offset), 0, SetControllerLightColor_Color_PropertyAddress.Address, Color);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControllerLightColor_FunctionAddress, intPtr, SetControllerLightColor_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerController:SetCinematicMode")]
	public unsafe void SetCinematicMode(bool bInCinematicMode, bool bHidePlayer, bool bAffectsHUD, bool bAffectsMovement, bool bAffectsTurning)
	{
		CheckDestroyed();
		if (!SetCinematicMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:SetCinematicMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCinematicMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCinematicMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCinematicMode_bInCinematicMode_Offset), 0, SetCinematicMode_bInCinematicMode_PropertyAddress.Address, bInCinematicMode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCinematicMode_bHidePlayer_Offset), 0, SetCinematicMode_bHidePlayer_PropertyAddress.Address, bHidePlayer);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCinematicMode_bAffectsHUD_Offset), 0, SetCinematicMode_bAffectsHUD_PropertyAddress.Address, bAffectsHUD);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCinematicMode_bAffectsMovement_Offset), 0, SetCinematicMode_bAffectsMovement_PropertyAddress.Address, bAffectsMovement);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCinematicMode_bAffectsTurning_Offset), 0, SetCinematicMode_bAffectsTurning_PropertyAddress.Address, bAffectsTurning);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCinematicMode_FunctionAddress, intPtr, SetCinematicMode_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PlayerController:SetAudioListenerOverride")]
	public unsafe void SetAudioListenerOverride(USceneComponent AttachToComponent, FVector Location, FRotator Rotation)
	{
		CheckDestroyed();
		if (!SetAudioListenerOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:SetAudioListenerOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAudioListenerOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAudioListenerOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, SetAudioListenerOverride_AttachToComponent_Offset), 0, SetAudioListenerOverride_AttachToComponent_PropertyAddress.Address, AttachToComponent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetAudioListenerOverride_Location_Offset), 0, SetAudioListenerOverride_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetAudioListenerOverride_Rotation_Offset), 0, SetAudioListenerOverride_Rotation_PropertyAddress.Address, Rotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAudioListenerOverride_FunctionAddress, intPtr, SetAudioListenerOverride_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PlayerController:SetAudioListenerAttenuationOverride")]
	public unsafe void SetAudioListenerAttenuationOverride(USceneComponent AttachToComponent, FVector AttenuationLocationOVerride)
	{
		CheckDestroyed();
		if (!SetAudioListenerAttenuationOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:SetAudioListenerAttenuationOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAudioListenerAttenuationOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAudioListenerAttenuationOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, SetAudioListenerAttenuationOverride_AttachToComponent_Offset), 0, SetAudioListenerAttenuationOverride_AttachToComponent_PropertyAddress.Address, AttachToComponent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetAudioListenerAttenuationOverride_AttenuationLocationOVerride_Offset), 0, SetAudioListenerAttenuationOverride_AttenuationLocationOVerride_PropertyAddress.Address, AttenuationLocationOVerride);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAudioListenerAttenuationOverride_FunctionAddress, intPtr, SetAudioListenerAttenuationOverride_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlayerController:ResetControllerLightColor")]
	public unsafe void ResetControllerLightColor()
	{
		CheckDestroyed();
		if (!ResetControllerLightColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:ResetControllerLightColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetControllerLightColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetControllerLightColor_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetControllerLightColor_FunctionAddress, argsSize: ResetControllerLightColor_ParamsSize);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.PlayerController:ProjectWorldLocationToScreen")]
	public unsafe bool ProjectWorldLocationToScreen(FVector WorldLocation, out FVector2D ScreenLocation, bool bPlayerViewportRelative = false)
	{
		CheckDestroyed();
		if (!ProjectWorldLocationToScreen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:ProjectWorldLocationToScreen");
			ScreenLocation = default(FVector2D);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectWorldLocationToScreen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectWorldLocationToScreen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ProjectWorldLocationToScreen_WorldLocation_Offset), 0, ProjectWorldLocationToScreen_WorldLocation_PropertyAddress.Address, WorldLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ProjectWorldLocationToScreen_bPlayerViewportRelative_Offset), 0, ProjectWorldLocationToScreen_bPlayerViewportRelative_PropertyAddress.Address, bPlayerViewportRelative);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProjectWorldLocationToScreen_FunctionAddress, intPtr, ProjectWorldLocationToScreen_ParamsSize);
		ScreenLocation = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, ProjectWorldLocationToScreen_ScreenLocation_Offset), 0, ProjectWorldLocationToScreen_ScreenLocation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ProjectWorldLocationToScreen_ReturnValue_Offset), 0, ProjectWorldLocationToScreen_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlayerController:PlayHapticEffect")]
	public unsafe void PlayHapticEffect(UHapticFeedbackEffect_Base HapticEffect, EControllerHand Hand, float Scale = 1f, bool bLoop = false)
	{
		CheckDestroyed();
		if (!PlayHapticEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:PlayHapticEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayHapticEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayHapticEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UHapticFeedbackEffect_Base>.ToNative(IntPtr.Add(intPtr, PlayHapticEffect_HapticEffect_Offset), 0, PlayHapticEffect_HapticEffect_PropertyAddress.Address, HapticEffect);
		EnumMarshaler<EControllerHand>.ToNative(IntPtr.Add(intPtr, PlayHapticEffect_Hand_Offset), 0, PlayHapticEffect_Hand_PropertyAddress.Address, Hand);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayHapticEffect_Scale_Offset), 0, PlayHapticEffect_Scale_PropertyAddress.Address, Scale);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PlayHapticEffect_bLoop_Offset), 0, PlayHapticEffect_bLoop_PropertyAddress.Address, bLoop);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayHapticEffect_FunctionAddress, intPtr, PlayHapticEffect_ParamsSize);
	}

	[UFunction(Flags = 67372033u)]
	[UMetaPath("/Script/Engine.PlayerController:PlayDynamicForceFeedback")]
	public unsafe void PlayDynamicForceFeedback(float Intensity, float Duration, bool bAffectsLeftLarge, bool bAffectsLeftSmall, bool bAffectsRightLarge, bool bAffectsRightSmall, EDynamicForceFeedbackAction Action, FLatentActionInfo LatentInfo)
	{
		CheckDestroyed();
		if (!PlayDynamicForceFeedback_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:PlayDynamicForceFeedback");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayDynamicForceFeedback_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayDynamicForceFeedback_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayDynamicForceFeedback_Intensity_Offset), 0, PlayDynamicForceFeedback_Intensity_PropertyAddress.Address, Intensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayDynamicForceFeedback_Duration_Offset), 0, PlayDynamicForceFeedback_Duration_PropertyAddress.Address, Duration);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PlayDynamicForceFeedback_bAffectsLeftLarge_Offset), 0, PlayDynamicForceFeedback_bAffectsLeftLarge_PropertyAddress.Address, bAffectsLeftLarge);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PlayDynamicForceFeedback_bAffectsLeftSmall_Offset), 0, PlayDynamicForceFeedback_bAffectsLeftSmall_PropertyAddress.Address, bAffectsLeftSmall);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PlayDynamicForceFeedback_bAffectsRightLarge_Offset), 0, PlayDynamicForceFeedback_bAffectsRightLarge_PropertyAddress.Address, bAffectsRightLarge);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PlayDynamicForceFeedback_bAffectsRightSmall_Offset), 0, PlayDynamicForceFeedback_bAffectsRightSmall_PropertyAddress.Address, bAffectsRightSmall);
		EnumMarshaler<EDynamicForceFeedbackAction>.ToNative(IntPtr.Add(intPtr, PlayDynamicForceFeedback_Action_Offset), 0, PlayDynamicForceFeedback_Action_PropertyAddress.Address, Action);
		NativeReflection.InitializeValue_InContainer(PlayDynamicForceFeedback_LatentInfo_PropertyAddress.Address, intPtr);
		FLatentActionInfo.ToNative(IntPtr.Add(intPtr, PlayDynamicForceFeedback_LatentInfo_Offset), 0, PlayDynamicForceFeedback_LatentInfo_PropertyAddress.Address, LatentInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayDynamicForceFeedback_FunctionAddress, intPtr, PlayDynamicForceFeedback_ParamsSize);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_ClientPlayForceFeedback")]
	[UMetaPath("/Script/Engine.PlayerController:K2_ClientPlayForceFeedback")]
	public unsafe void ClientPlayForceFeedback(UForceFeedbackEffect ForceFeedbackEffect, FName Tag, bool bLooping, bool bIgnoreTimeDilation, bool bPlayWhilePaused)
	{
		CheckDestroyed();
		if (!ClientPlayForceFeedback_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:K2_ClientPlayForceFeedback");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClientPlayForceFeedback_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClientPlayForceFeedback_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UForceFeedbackEffect>.ToNative(IntPtr.Add(intPtr, ClientPlayForceFeedback_ForceFeedbackEffect_Offset), 0, ClientPlayForceFeedback_ForceFeedbackEffect_PropertyAddress.Address, ForceFeedbackEffect);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ClientPlayForceFeedback_Tag_Offset), 0, ClientPlayForceFeedback_Tag_PropertyAddress.Address, Tag);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ClientPlayForceFeedback_bLooping_Offset), 0, ClientPlayForceFeedback_bLooping_PropertyAddress.Address, bLooping);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ClientPlayForceFeedback_bIgnoreTimeDilation_Offset), 0, ClientPlayForceFeedback_bIgnoreTimeDilation_PropertyAddress.Address, bIgnoreTimeDilation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ClientPlayForceFeedback_bPlayWhilePaused_Offset), 0, ClientPlayForceFeedback_bPlayWhilePaused_PropertyAddress.Address, bPlayWhilePaused);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClientPlayForceFeedback_FunctionAddress, intPtr, ClientPlayForceFeedback_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.PlayerController:IsStreamingSourceEnabled")]
	public unsafe bool IsStreamingSourceEnabled()
	{
		CheckDestroyed();
		if (!IsStreamingSourceEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:IsStreamingSourceEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsStreamingSourceEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsStreamingSourceEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsStreamingSourceEnabled_FunctionAddress, intPtr, IsStreamingSourceEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsStreamingSourceEnabled_ReturnValue_Offset), 0, IsStreamingSourceEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerController:IsInputKeyDown")]
	public unsafe bool IsInputKeyDown(FKey Key)
	{
		CheckDestroyed();
		if (!IsInputKeyDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:IsInputKeyDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInputKeyDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInputKeyDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsInputKeyDown_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, IsInputKeyDown_Key_Offset), 0, IsInputKeyDown_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInputKeyDown_FunctionAddress, intPtr, IsInputKeyDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsInputKeyDown_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInputKeyDown_ReturnValue_Offset), 0, IsInputKeyDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.PlayerController:GetViewportSize")]
	public unsafe void GetViewportSize(out int SizeX, out int SizeY)
	{
		CheckDestroyed();
		if (!GetViewportSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetViewportSize");
			SizeX = 0;
			SizeY = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewportSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewportSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewportSize_FunctionAddress, intPtr, GetViewportSize_ParamsSize);
		SizeX = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetViewportSize_SizeX_Offset), 0, GetViewportSize_SizeX_PropertyAddress.Address);
		SizeY = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetViewportSize_SizeY_Offset), 0, GetViewportSize_SizeY_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerController:GetSpectatorPawn")]
	public unsafe ASpectatorPawn GetSpectatorPawn()
	{
		CheckDestroyed();
		if (!GetSpectatorPawn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetSpectatorPawn");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpectatorPawn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpectatorPawn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpectatorPawn_FunctionAddress, intPtr, GetSpectatorPawn_ParamsSize);
		return UObjectMarshaler<ASpectatorPawn>.FromNative(IntPtr.Add(intPtr, GetSpectatorPawn_ReturnValue_Offset), 0, GetSpectatorPawn_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.PlayerController:GetMousePosition")]
	public unsafe bool GetMousePosition(out float LocationX, out float LocationY)
	{
		CheckDestroyed();
		if (!GetMousePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetMousePosition");
			LocationX = 0f;
			LocationY = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMousePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMousePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMousePosition_FunctionAddress, intPtr, GetMousePosition_ParamsSize);
		LocationX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMousePosition_LocationX_Offset), 0, GetMousePosition_LocationX_PropertyAddress.Address);
		LocationY = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMousePosition_LocationY_Offset), 0, GetMousePosition_LocationY_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetMousePosition_ReturnValue_Offset), 0, GetMousePosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.PlayerController:GetInputVectorKeyState")]
	public unsafe FVector GetInputVectorKeyState(FKey Key)
	{
		CheckDestroyed();
		if (!GetInputVectorKeyState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetInputVectorKeyState");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputVectorKeyState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputVectorKeyState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInputVectorKeyState_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, GetInputVectorKeyState_Key_Offset), 0, GetInputVectorKeyState_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputVectorKeyState_FunctionAddress, intPtr, GetInputVectorKeyState_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInputVectorKeyState_Key_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetInputVectorKeyState_ReturnValue_Offset), 0, GetInputVectorKeyState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.PlayerController:GetInputTouchState")]
	public unsafe void GetInputTouchState(ETouchIndex FingerIndex, out float LocationX, out float LocationY, out bool bIsCurrentlyPressed)
	{
		CheckDestroyed();
		if (!GetInputTouchState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetInputTouchState");
			LocationX = 0f;
			LocationY = 0f;
			bIsCurrentlyPressed = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputTouchState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputTouchState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, GetInputTouchState_FingerIndex_Offset), 0, GetInputTouchState_FingerIndex_PropertyAddress.Address, FingerIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputTouchState_FunctionAddress, intPtr, GetInputTouchState_ParamsSize);
		LocationX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetInputTouchState_LocationX_Offset), 0, GetInputTouchState_LocationX_PropertyAddress.Address);
		LocationY = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetInputTouchState_LocationY_Offset), 0, GetInputTouchState_LocationY_PropertyAddress.Address);
		bIsCurrentlyPressed = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetInputTouchState_bIsCurrentlyPressed_Offset), 0, GetInputTouchState_bIsCurrentlyPressed_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.PlayerController:GetInputMouseDelta")]
	public unsafe void GetInputMouseDelta(out float DeltaX, out float DeltaY)
	{
		CheckDestroyed();
		if (!GetInputMouseDelta_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetInputMouseDelta");
			DeltaX = 0f;
			DeltaY = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputMouseDelta_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputMouseDelta_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputMouseDelta_FunctionAddress, intPtr, GetInputMouseDelta_ParamsSize);
		DeltaX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetInputMouseDelta_DeltaX_Offset), 0, GetInputMouseDelta_DeltaX_PropertyAddress.Address);
		DeltaY = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetInputMouseDelta_DeltaY_Offset), 0, GetInputMouseDelta_DeltaY_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.PlayerController:GetInputMotionState")]
	public unsafe void GetInputMotionState(out FVector Tilt, out FVector RotationRate, out FVector Gravity, out FVector Acceleration)
	{
		CheckDestroyed();
		if (!GetInputMotionState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetInputMotionState");
			Tilt = default(FVector);
			RotationRate = default(FVector);
			Gravity = default(FVector);
			Acceleration = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputMotionState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputMotionState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputMotionState_FunctionAddress, intPtr, GetInputMotionState_ParamsSize);
		Tilt = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetInputMotionState_Tilt_Offset), 0, GetInputMotionState_Tilt_PropertyAddress.Address);
		RotationRate = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetInputMotionState_RotationRate_Offset), 0, GetInputMotionState_RotationRate_PropertyAddress.Address);
		Gravity = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetInputMotionState_Gravity_Offset), 0, GetInputMotionState_Gravity_PropertyAddress.Address);
		Acceleration = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetInputMotionState_Acceleration_Offset), 0, GetInputMotionState_Acceleration_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerController:GetInputKeyTimeDown")]
	public unsafe float GetInputKeyTimeDown(FKey Key)
	{
		CheckDestroyed();
		if (!GetInputKeyTimeDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetInputKeyTimeDown");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputKeyTimeDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputKeyTimeDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInputKeyTimeDown_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, GetInputKeyTimeDown_Key_Offset), 0, GetInputKeyTimeDown_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputKeyTimeDown_FunctionAddress, intPtr, GetInputKeyTimeDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInputKeyTimeDown_Key_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetInputKeyTimeDown_ReturnValue_Offset), 0, GetInputKeyTimeDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.PlayerController:GetInputAnalogStickState")]
	public unsafe void GetInputAnalogStickState(EControllerAnalogStick WhichStick, out float StickX, out float StickY)
	{
		CheckDestroyed();
		if (!GetInputAnalogStickState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetInputAnalogStickState");
			StickX = 0f;
			StickY = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputAnalogStickState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputAnalogStickState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EControllerAnalogStick>.ToNative(IntPtr.Add(intPtr, GetInputAnalogStickState_WhichStick_Offset), 0, GetInputAnalogStickState_WhichStick_PropertyAddress.Address, WhichStick);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputAnalogStickState_FunctionAddress, intPtr, GetInputAnalogStickState_ParamsSize);
		StickX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetInputAnalogStickState_StickX_Offset), 0, GetInputAnalogStickState_StickX_PropertyAddress.Address);
		StickY = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetInputAnalogStickState_StickY_Offset), 0, GetInputAnalogStickState_StickY_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerController:GetInputAnalogKeyState")]
	public unsafe float GetInputAnalogKeyState(FKey Key)
	{
		CheckDestroyed();
		if (!GetInputAnalogKeyState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetInputAnalogKeyState");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputAnalogKeyState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputAnalogKeyState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInputAnalogKeyState_Key_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, GetInputAnalogKeyState_Key_Offset), 0, GetInputAnalogKeyState_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputAnalogKeyState_FunctionAddress, intPtr, GetInputAnalogKeyState_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInputAnalogKeyState_Key_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetInputAnalogKeyState_ReturnValue_Offset), 0, GetInputAnalogKeyState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerController:GetHUD")]
	public unsafe AHUD GetHUD()
	{
		CheckDestroyed();
		if (!GetHUD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetHUD");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHUD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHUD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHUD_FunctionAddress, intPtr, GetHUD_ParamsSize);
		return UObjectMarshaler<AHUD>.FromNative(IntPtr.Add(intPtr, GetHUD_ReturnValue_Offset), 0, GetHUD_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.PlayerController:GetHitResultUnderFingerForObjects")]
	public unsafe bool GetHitResultUnderFingerForObjects(ETouchIndex FingerIndex, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, out FHitResult HitResult)
	{
		CheckDestroyed();
		if (!GetHitResultUnderFingerForObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetHitResultUnderFingerForObjects");
			HitResult = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHitResultUnderFingerForObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHitResultUnderFingerForObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, GetHitResultUnderFingerForObjects_FingerIndex_Offset), 0, GetHitResultUnderFingerForObjects_FingerIndex_PropertyAddress.Address, FingerIndex);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, GetHitResultUnderFingerForObjects_ObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(intPtr, GetHitResultUnderFingerForObjects_ObjectTypes_Offset), ObjectTypes);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetHitResultUnderFingerForObjects_bTraceComplex_Offset), 0, GetHitResultUnderFingerForObjects_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		NativeReflection.InitializeValue_InContainer(GetHitResultUnderFingerForObjects_HitResult_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHitResultUnderFingerForObjects_FunctionAddress, intPtr, GetHitResultUnderFingerForObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetHitResultUnderFingerForObjects_ObjectTypes_PropertyAddress.Address, intPtr);
		HitResult = FHitResult.FromNative(IntPtr.Add(intPtr, GetHitResultUnderFingerForObjects_HitResult_Offset), 0, GetHitResultUnderFingerForObjects_HitResult_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetHitResultUnderFingerForObjects_ReturnValue_Offset), 0, GetHitResultUnderFingerForObjects_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.PlayerController:GetHitResultUnderFingerByChannel")]
	public unsafe bool GetHitResultUnderFingerByChannel(ETouchIndex FingerIndex, ETraceTypeQuery TraceChannel, bool bTraceComplex, out FHitResult HitResult)
	{
		CheckDestroyed();
		if (!GetHitResultUnderFingerByChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetHitResultUnderFingerByChannel");
			HitResult = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHitResultUnderFingerByChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHitResultUnderFingerByChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETouchIndex>.ToNative(IntPtr.Add(intPtr, GetHitResultUnderFingerByChannel_FingerIndex_Offset), 0, GetHitResultUnderFingerByChannel_FingerIndex_PropertyAddress.Address, FingerIndex);
		EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(intPtr, GetHitResultUnderFingerByChannel_TraceChannel_Offset), 0, GetHitResultUnderFingerByChannel_TraceChannel_PropertyAddress.Address, TraceChannel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetHitResultUnderFingerByChannel_bTraceComplex_Offset), 0, GetHitResultUnderFingerByChannel_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		NativeReflection.InitializeValue_InContainer(GetHitResultUnderFingerByChannel_HitResult_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHitResultUnderFingerByChannel_FunctionAddress, intPtr, GetHitResultUnderFingerByChannel_ParamsSize);
		HitResult = FHitResult.FromNative(IntPtr.Add(intPtr, GetHitResultUnderFingerByChannel_HitResult_Offset), 0, GetHitResultUnderFingerByChannel_HitResult_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetHitResultUnderFingerByChannel_ReturnValue_Offset), 0, GetHitResultUnderFingerByChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.PlayerController:GetHitResultUnderCursorForObjects")]
	public unsafe bool GetHitResultUnderCursorForObjects(List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, out FHitResult HitResult)
	{
		CheckDestroyed();
		if (!GetHitResultUnderCursorForObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetHitResultUnderCursorForObjects");
			HitResult = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHitResultUnderCursorForObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHitResultUnderCursorForObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, GetHitResultUnderCursorForObjects_ObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(intPtr, GetHitResultUnderCursorForObjects_ObjectTypes_Offset), ObjectTypes);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetHitResultUnderCursorForObjects_bTraceComplex_Offset), 0, GetHitResultUnderCursorForObjects_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		NativeReflection.InitializeValue_InContainer(GetHitResultUnderCursorForObjects_HitResult_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHitResultUnderCursorForObjects_FunctionAddress, intPtr, GetHitResultUnderCursorForObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetHitResultUnderCursorForObjects_ObjectTypes_PropertyAddress.Address, intPtr);
		HitResult = FHitResult.FromNative(IntPtr.Add(intPtr, GetHitResultUnderCursorForObjects_HitResult_Offset), 0, GetHitResultUnderCursorForObjects_HitResult_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetHitResultUnderCursorForObjects_ReturnValue_Offset), 0, GetHitResultUnderCursorForObjects_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.PlayerController:GetHitResultUnderCursorByChannel")]
	public unsafe bool GetHitResultUnderCursorByChannel(ETraceTypeQuery TraceChannel, bool bTraceComplex, out FHitResult HitResult)
	{
		CheckDestroyed();
		if (!GetHitResultUnderCursorByChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetHitResultUnderCursorByChannel");
			HitResult = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHitResultUnderCursorByChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHitResultUnderCursorByChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(intPtr, GetHitResultUnderCursorByChannel_TraceChannel_Offset), 0, GetHitResultUnderCursorByChannel_TraceChannel_PropertyAddress.Address, TraceChannel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetHitResultUnderCursorByChannel_bTraceComplex_Offset), 0, GetHitResultUnderCursorByChannel_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		NativeReflection.InitializeValue_InContainer(GetHitResultUnderCursorByChannel_HitResult_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHitResultUnderCursorByChannel_FunctionAddress, intPtr, GetHitResultUnderCursorByChannel_ParamsSize);
		HitResult = FHitResult.FromNative(IntPtr.Add(intPtr, GetHitResultUnderCursorByChannel_HitResult_Offset), 0, GetHitResultUnderCursorByChannel_HitResult_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetHitResultUnderCursorByChannel_ReturnValue_Offset), 0, GetHitResultUnderCursorByChannel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.PlayerController:GetFocalLocation")]
	public unsafe FVector GetFocalLocation()
	{
		CheckDestroyed();
		if (!GetFocalLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetFocalLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFocalLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFocalLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFocalLocation_FunctionAddress, intPtr, GetFocalLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetFocalLocation_ReturnValue_Offset), 0, GetFocalLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerController:GetDeprecatedInputYawScale")]
	public unsafe float GetDeprecatedInputYawScale()
	{
		CheckDestroyed();
		if (!GetDeprecatedInputYawScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetDeprecatedInputYawScale");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDeprecatedInputYawScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDeprecatedInputYawScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDeprecatedInputYawScale_FunctionAddress, intPtr, GetDeprecatedInputYawScale_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDeprecatedInputYawScale_ReturnValue_Offset), 0, GetDeprecatedInputYawScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerController:GetDeprecatedInputRollScale")]
	public unsafe float GetDeprecatedInputRollScale()
	{
		CheckDestroyed();
		if (!GetDeprecatedInputRollScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetDeprecatedInputRollScale");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDeprecatedInputRollScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDeprecatedInputRollScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDeprecatedInputRollScale_FunctionAddress, intPtr, GetDeprecatedInputRollScale_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDeprecatedInputRollScale_ReturnValue_Offset), 0, GetDeprecatedInputRollScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PlayerController:GetDeprecatedInputPitchScale")]
	public unsafe float GetDeprecatedInputPitchScale()
	{
		CheckDestroyed();
		if (!GetDeprecatedInputPitchScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:GetDeprecatedInputPitchScale");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDeprecatedInputPitchScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDeprecatedInputPitchScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDeprecatedInputPitchScale_FunctionAddress, intPtr, GetDeprecatedInputPitchScale_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDeprecatedInputPitchScale_ReturnValue_Offset), 0, GetDeprecatedInputPitchScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.PlayerController:DeprojectScreenPositionToWorld")]
	public unsafe bool DeprojectScreenPositionToWorld(float ScreenX, float ScreenY, out FVector WorldLocation, out FVector WorldDirection)
	{
		CheckDestroyed();
		if (!DeprojectScreenPositionToWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:DeprojectScreenPositionToWorld");
			WorldLocation = default(FVector);
			WorldDirection = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeprojectScreenPositionToWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeprojectScreenPositionToWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DeprojectScreenPositionToWorld_ScreenX_Offset), 0, DeprojectScreenPositionToWorld_ScreenX_PropertyAddress.Address, ScreenX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DeprojectScreenPositionToWorld_ScreenY_Offset), 0, DeprojectScreenPositionToWorld_ScreenY_PropertyAddress.Address, ScreenY);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeprojectScreenPositionToWorld_FunctionAddress, intPtr, DeprojectScreenPositionToWorld_ParamsSize);
		WorldLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, DeprojectScreenPositionToWorld_WorldLocation_Offset), 0, DeprojectScreenPositionToWorld_WorldLocation_PropertyAddress.Address);
		WorldDirection = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, DeprojectScreenPositionToWorld_WorldDirection_Offset), 0, DeprojectScreenPositionToWorld_WorldDirection_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeprojectScreenPositionToWorld_ReturnValue_Offset), 0, DeprojectScreenPositionToWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.PlayerController:DeprojectMousePositionToWorld")]
	public unsafe bool DeprojectMousePositionToWorld(out FVector WorldLocation, out FVector WorldDirection)
	{
		CheckDestroyed();
		if (!DeprojectMousePositionToWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:DeprojectMousePositionToWorld");
			WorldLocation = default(FVector);
			WorldDirection = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeprojectMousePositionToWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeprojectMousePositionToWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeprojectMousePositionToWorld_FunctionAddress, intPtr, DeprojectMousePositionToWorld_ParamsSize);
		WorldLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, DeprojectMousePositionToWorld_WorldLocation_Offset), 0, DeprojectMousePositionToWorld_WorldLocation_PropertyAddress.Address);
		WorldDirection = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, DeprojectMousePositionToWorld_WorldDirection_Offset), 0, DeprojectMousePositionToWorld_WorldDirection_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeprojectMousePositionToWorld_ReturnValue_Offset), 0, DeprojectMousePositionToWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 84020416u)]
	[UMetaPath("/Script/Engine.PlayerController:ClientStopForceFeedback")]
	public unsafe void ClientStopForceFeedback(UForceFeedbackEffect ForceFeedbackEffect, FName Tag)
	{
		CheckDestroyed();
		if (!ClientStopForceFeedback_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:ClientStopForceFeedback");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClientStopForceFeedback_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClientStopForceFeedback_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UForceFeedbackEffect>.ToNative(IntPtr.Add(intPtr, ClientStopForceFeedback_ForceFeedbackEffect_Offset), 0, ClientStopForceFeedback_ForceFeedbackEffect_PropertyAddress.Address, ForceFeedbackEffect);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ClientStopForceFeedback_Tag_Offset), 0, ClientStopForceFeedback_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClientStopForceFeedback_FunctionAddress, intPtr, ClientStopForceFeedback_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlayerController:ClientStopCameraShakesFromSource")]
	public unsafe void ClientStopCameraShakesFromSource(UCameraShakeSourceComponent SourceComponent, bool bImmediately = true)
	{
		CheckDestroyed();
		if (!ClientStopCameraShakesFromSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:ClientStopCameraShakesFromSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClientStopCameraShakesFromSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClientStopCameraShakesFromSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraShakeSourceComponent>.ToNative(IntPtr.Add(intPtr, ClientStopCameraShakesFromSource_SourceComponent_Offset), 0, ClientStopCameraShakesFromSource_SourceComponent_PropertyAddress.Address, SourceComponent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ClientStopCameraShakesFromSource_bImmediately_Offset), 0, ClientStopCameraShakesFromSource_bImmediately_PropertyAddress.Address, bImmediately);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClientStopCameraShakesFromSource_FunctionAddress, intPtr, ClientStopCameraShakesFromSource_ParamsSize);
	}

	[UFunction(Flags = 84020416u)]
	[UMetaPath("/Script/Engine.PlayerController:ClientStopCameraShake")]
	public unsafe void ClientStopCameraShake(TSubclassOf<UCameraShakeBase> Shake, bool bImmediately = true)
	{
		CheckDestroyed();
		if (!ClientStopCameraShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:ClientStopCameraShake");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClientStopCameraShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClientStopCameraShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UCameraShakeBase>.ToNative(IntPtr.Add(intPtr, ClientStopCameraShake_Shake_Offset), 0, ClientStopCameraShake_Shake_PropertyAddress.Address, Shake);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ClientStopCameraShake_bImmediately_Offset), 0, ClientStopCameraShake_bImmediately_PropertyAddress.Address, bImmediately);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClientStopCameraShake_FunctionAddress, intPtr, ClientStopCameraShake_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlayerController:ClientStartCameraShakeFromSource")]
	public unsafe void ClientStartCameraShakeFromSource(TSubclassOf<UCameraShakeBase> Shake, UCameraShakeSourceComponent SourceComponent)
	{
		CheckDestroyed();
		if (!ClientStartCameraShakeFromSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:ClientStartCameraShakeFromSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClientStartCameraShakeFromSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClientStartCameraShakeFromSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UCameraShakeBase>.ToNative(IntPtr.Add(intPtr, ClientStartCameraShakeFromSource_Shake_Offset), 0, ClientStartCameraShakeFromSource_Shake_PropertyAddress.Address, Shake);
		UObjectMarshaler<UCameraShakeSourceComponent>.ToNative(IntPtr.Add(intPtr, ClientStartCameraShakeFromSource_SourceComponent_Offset), 0, ClientStartCameraShakeFromSource_SourceComponent_PropertyAddress.Address, SourceComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClientStartCameraShakeFromSource_FunctionAddress, intPtr, ClientStartCameraShakeFromSource_ParamsSize);
	}

	[UFunction(Flags = 92408896u)]
	[UMetaPath("/Script/Engine.PlayerController:ClientStartCameraShake")]
	public unsafe void ClientStartCameraShake(TSubclassOf<UCameraShakeBase> Shake, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator))
	{
		CheckDestroyed();
		if (!ClientStartCameraShake_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:ClientStartCameraShake");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClientStartCameraShake_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClientStartCameraShake_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UCameraShakeBase>.ToNative(IntPtr.Add(intPtr, ClientStartCameraShake_Shake_Offset), 0, ClientStartCameraShake_Shake_PropertyAddress.Address, Shake);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ClientStartCameraShake_Scale_Offset), 0, ClientStartCameraShake_Scale_PropertyAddress.Address, Scale);
		EnumMarshaler<ECameraShakePlaySpace>.ToNative(IntPtr.Add(intPtr, ClientStartCameraShake_PlaySpace_Offset), 0, ClientStartCameraShake_PlaySpace_PropertyAddress.Address, PlaySpace);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, ClientStartCameraShake_UserPlaySpaceRot_Offset), 0, ClientStartCameraShake_UserPlaySpaceRot_PropertyAddress.Address, UserPlaySpaceRot);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClientStartCameraShake_FunctionAddress, intPtr, ClientStartCameraShake_ParamsSize);
	}

	[UFunction(Flags = 84020288u)]
	[UMetaPath("/Script/Engine.PlayerController:ClientSpawnGenericCameraLensEffect")]
	public unsafe void ClientSpawnGenericCameraLensEffect(TSubclassOf<AActor> LensEffectEmitterClass)
	{
		CheckDestroyed();
		if (!ClientSpawnGenericCameraLensEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:ClientSpawnGenericCameraLensEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClientSpawnGenericCameraLensEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClientSpawnGenericCameraLensEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ClientSpawnGenericCameraLensEffect_LensEffectEmitterClass_Offset), 0, ClientSpawnGenericCameraLensEffect_LensEffectEmitterClass_PropertyAddress.Address, LensEffectEmitterClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClientSpawnGenericCameraLensEffect_FunctionAddress, intPtr, ClientSpawnGenericCameraLensEffect_ParamsSize);
	}

	[UFunction(Flags = 84020416u)]
	[UMetaPath("/Script/Engine.PlayerController:ClientSetHUD")]
	public unsafe void ClientSetHUD(TSubclassOf<AHUD> NewHUDClass)
	{
		CheckDestroyed();
		if (!ClientSetHUD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:ClientSetHUD");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClientSetHUD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClientSetHUD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<AHUD>.ToNative(IntPtr.Add(intPtr, ClientSetHUD_NewHUDClass_Offset), 0, ClientSetHUD_NewHUDClass_PropertyAddress.Address, NewHUDClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClientSetHUD_FunctionAddress, intPtr, ClientSetHUD_ParamsSize);
	}

	[UFunction(Flags = 92408896u)]
	[UMetaPath("/Script/Engine.PlayerController:ClientPlayCameraAnim")]
	public unsafe void ClientPlayCameraAnim(UCameraAnim AnimToPlay, float Scale = 1f, float Rate = 1f, float BlendInTime = 0f, float BlendOutTime = 0f, bool bLoop = false, bool bRandomStartTime = false, ECameraShakePlaySpace Space = ECameraShakePlaySpace.CameraLocal, FRotator CustomPlaySpace = default(FRotator))
	{
		CheckDestroyed();
		if (!ClientPlayCameraAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:ClientPlayCameraAnim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClientPlayCameraAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClientPlayCameraAnim_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCameraAnim>.ToNative(IntPtr.Add(intPtr, ClientPlayCameraAnim_AnimToPlay_Offset), 0, ClientPlayCameraAnim_AnimToPlay_PropertyAddress.Address, AnimToPlay);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ClientPlayCameraAnim_Scale_Offset), 0, ClientPlayCameraAnim_Scale_PropertyAddress.Address, Scale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ClientPlayCameraAnim_Rate_Offset), 0, ClientPlayCameraAnim_Rate_PropertyAddress.Address, Rate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ClientPlayCameraAnim_BlendInTime_Offset), 0, ClientPlayCameraAnim_BlendInTime_PropertyAddress.Address, BlendInTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ClientPlayCameraAnim_BlendOutTime_Offset), 0, ClientPlayCameraAnim_BlendOutTime_PropertyAddress.Address, BlendOutTime);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ClientPlayCameraAnim_bLoop_Offset), 0, ClientPlayCameraAnim_bLoop_PropertyAddress.Address, bLoop);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ClientPlayCameraAnim_bRandomStartTime_Offset), 0, ClientPlayCameraAnim_bRandomStartTime_PropertyAddress.Address, bRandomStartTime);
		EnumMarshaler<ECameraShakePlaySpace>.ToNative(IntPtr.Add(intPtr, ClientPlayCameraAnim_Space_Offset), 0, ClientPlayCameraAnim_Space_PropertyAddress.Address, Space);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, ClientPlayCameraAnim_CustomPlaySpace_Offset), 0, ClientPlayCameraAnim_CustomPlaySpace_PropertyAddress.Address, CustomPlaySpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClientPlayCameraAnim_FunctionAddress, intPtr, ClientPlayCameraAnim_ParamsSize);
	}

	[UFunction(Flags = 84020416u)]
	[UMetaPath("/Script/Engine.PlayerController:ClientClearCameraLensEffects")]
	public unsafe void ClientClearCameraLensEffects()
	{
		CheckDestroyed();
		if (!ClientClearCameraLensEffects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:ClientClearCameraLensEffects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClientClearCameraLensEffects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClientClearCameraLensEffects_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClientClearCameraLensEffects_FunctionAddress, argsSize: ClientClearCameraLensEffects_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlayerController:ClearAudioListenerOverride")]
	public unsafe void ClearAudioListenerOverride()
	{
		CheckDestroyed();
		if (!ClearAudioListenerOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:ClearAudioListenerOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAudioListenerOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAudioListenerOverride_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearAudioListenerOverride_FunctionAddress, argsSize: ClearAudioListenerOverride_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlayerController:ClearAudioListenerAttenuationOverride")]
	public unsafe void ClearAudioListenerAttenuationOverride()
	{
		CheckDestroyed();
		if (!ClearAudioListenerAttenuationOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:ClearAudioListenerAttenuationOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAudioListenerAttenuationOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAudioListenerAttenuationOverride_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearAudioListenerAttenuationOverride_FunctionAddress, argsSize: ClearAudioListenerAttenuationOverride_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerController:CanRestartPlayer")]
	public unsafe bool CanRestartPlayer()
	{
		CheckDestroyed();
		if (!CanRestartPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:CanRestartPlayer");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanRestartPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanRestartPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanRestartPlayer_FunctionAddress, intPtr, CanRestartPlayer_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanRestartPlayer_ReturnValue_Offset), 0, CanRestartPlayer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerController:AddYawInput")]
	public unsafe void AddYawInput(float Val)
	{
		CheckDestroyed();
		if (!AddYawInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:AddYawInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddYawInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddYawInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddYawInput_Val_Offset), 0, AddYawInput_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddYawInput_FunctionAddress, intPtr, AddYawInput_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerController:AddRollInput")]
	public unsafe void AddRollInput(float Val)
	{
		CheckDestroyed();
		if (!AddRollInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:AddRollInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddRollInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddRollInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddRollInput_Val_Offset), 0, AddRollInput_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddRollInput_FunctionAddress, intPtr, AddRollInput_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerController:AddPitchInput")]
	public unsafe void AddPitchInput(float Val)
	{
		CheckDestroyed();
		if (!AddPitchInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:AddPitchInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddPitchInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddPitchInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddPitchInput_Val_Offset), 0, AddPitchInput_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddPitchInput_FunctionAddress, intPtr, AddPitchInput_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PlayerController:ActivateTouchInterface")]
	public unsafe void ActivateTouchInterface(UTouchInterface NewTouchInterface)
	{
		CheckDestroyed();
		if (!ActivateTouchInterface_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlayerController:ActivateTouchInterface");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActivateTouchInterface_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActivateTouchInterface_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTouchInterface>.ToNative(IntPtr.Add(intPtr, ActivateTouchInterface_NewTouchInterface_Offset), 0, ActivateTouchInterface_NewTouchInterface_PropertyAddress.Address, NewTouchInterface);
		NativeReflection.InvokeFunctionOptimized(base.Address, ActivateTouchInterface_FunctionAddress, intPtr, ActivateTouchInterface_ParamsSize);
	}

	static APlayerController()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APlayerController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APlayerController));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PlayerController");
		PlayerCameraManager_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayerCameraManager");
		PlayerCameraManager_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayerCameraManager", Classes.FObjectProperty);
		PlayerCameraManagerClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayerCameraManagerClass");
		PlayerCameraManagerClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayerCameraManagerClass", Classes.FClassProperty);
		SmoothTargetViewRotationSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SmoothTargetViewRotationSpeed");
		SmoothTargetViewRotationSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SmoothTargetViewRotationSpeed", Classes.FFloatProperty);
		CheatManager_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CheatManager");
		CheatManager_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CheatManager", Classes.FObjectProperty);
		CheatClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CheatClass");
		CheatClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CheatClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayerIsWaiting_PropertyAddress, intPtr, "bPlayerIsWaiting");
		PlayerIsWaiting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPlayerIsWaiting");
		PlayerIsWaiting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPlayerIsWaiting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowMouseCursor_PropertyAddress, intPtr, "bShowMouseCursor");
		ShowMouseCursor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShowMouseCursor");
		ShowMouseCursor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShowMouseCursor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableClickEvents_PropertyAddress, intPtr, "bEnableClickEvents");
		EnableClickEvents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableClickEvents");
		EnableClickEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableClickEvents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableTouchEvents_PropertyAddress, intPtr, "bEnableTouchEvents");
		EnableTouchEvents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableTouchEvents");
		EnableTouchEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableTouchEvents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableMouseOverEvents_PropertyAddress, intPtr, "bEnableMouseOverEvents");
		EnableMouseOverEvents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableMouseOverEvents");
		EnableMouseOverEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableMouseOverEvents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableTouchOverEvents_PropertyAddress, intPtr, "bEnableTouchOverEvents");
		EnableTouchOverEvents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableTouchOverEvents");
		EnableTouchOverEvents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableTouchOverEvents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceFeedbackEnabled_PropertyAddress, intPtr, "bForceFeedbackEnabled");
		ForceFeedbackEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceFeedbackEnabled");
		ForceFeedbackEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceFeedbackEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableStreamingSource_PropertyAddress, intPtr, "bEnableStreamingSource");
		EnableStreamingSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableStreamingSource");
		EnableStreamingSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableStreamingSource", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StreamingSourceShouldActivate_PropertyAddress, intPtr, "bStreamingSourceShouldActivate");
		StreamingSourceShouldActivate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStreamingSourceShouldActivate");
		StreamingSourceShouldActivate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStreamingSourceShouldActivate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StreamingSourceShouldBlockOnSlowStreaming_PropertyAddress, intPtr, "bStreamingSourceShouldBlockOnSlowStreaming");
		StreamingSourceShouldBlockOnSlowStreaming_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStreamingSourceShouldBlockOnSlowStreaming");
		StreamingSourceShouldBlockOnSlowStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStreamingSourceShouldBlockOnSlowStreaming", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClickEventKeys_PropertyAddress, intPtr, "ClickEventKeys");
		ClickEventKeys_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClickEventKeys");
		ClickEventKeys_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClickEventKeys", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DefaultMouseCursor_PropertyAddress, intPtr, "DefaultMouseCursor");
		DefaultMouseCursor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultMouseCursor");
		DefaultMouseCursor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultMouseCursor", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CurrentMouseCursor_PropertyAddress, intPtr, "CurrentMouseCursor");
		CurrentMouseCursor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentMouseCursor");
		CurrentMouseCursor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentMouseCursor", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DefaultClickTraceChannel_PropertyAddress, intPtr, "DefaultClickTraceChannel");
		DefaultClickTraceChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultClickTraceChannel");
		DefaultClickTraceChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultClickTraceChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref CurrentClickTraceChannel_PropertyAddress, intPtr, "CurrentClickTraceChannel");
		CurrentClickTraceChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentClickTraceChannel");
		CurrentClickTraceChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentClickTraceChannel", Classes.FByteProperty);
		HitResultTraceDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitResultTraceDistance");
		HitResultTraceDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitResultTraceDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldPerformFullTickWhenPaused_PropertyAddress, intPtr, "bShouldPerformFullTickWhenPaused");
		ShouldPerformFullTickWhenPaused_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldPerformFullTickWhenPaused");
		ShouldPerformFullTickWhenPaused_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldPerformFullTickWhenPaused", Classes.FBoolProperty);
		WasInputKeyJustReleased_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "WasInputKeyJustReleased");
		WasInputKeyJustReleased_ParamsSize = NativeReflection.GetFunctionParamsSize(WasInputKeyJustReleased_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WasInputKeyJustReleased_Key_PropertyAddress, WasInputKeyJustReleased_FunctionAddress, "Key");
		WasInputKeyJustReleased_Key_Offset = NativeReflectionCached.GetPropertyOffset(WasInputKeyJustReleased_FunctionAddress, "Key");
		WasInputKeyJustReleased_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(WasInputKeyJustReleased_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref WasInputKeyJustReleased_ReturnValue_PropertyAddress, WasInputKeyJustReleased_FunctionAddress, "ReturnValue");
		WasInputKeyJustReleased_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WasInputKeyJustReleased_FunctionAddress, "ReturnValue");
		WasInputKeyJustReleased_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WasInputKeyJustReleased_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WasInputKeyJustReleased_IsValid = WasInputKeyJustReleased_FunctionAddress != IntPtr.Zero && WasInputKeyJustReleased_Key_IsValid && WasInputKeyJustReleased_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:WasInputKeyJustReleased", WasInputKeyJustReleased_IsValid);
		WasInputKeyJustPressed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "WasInputKeyJustPressed");
		WasInputKeyJustPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(WasInputKeyJustPressed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WasInputKeyJustPressed_Key_PropertyAddress, WasInputKeyJustPressed_FunctionAddress, "Key");
		WasInputKeyJustPressed_Key_Offset = NativeReflectionCached.GetPropertyOffset(WasInputKeyJustPressed_FunctionAddress, "Key");
		WasInputKeyJustPressed_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(WasInputKeyJustPressed_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref WasInputKeyJustPressed_ReturnValue_PropertyAddress, WasInputKeyJustPressed_FunctionAddress, "ReturnValue");
		WasInputKeyJustPressed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WasInputKeyJustPressed_FunctionAddress, "ReturnValue");
		WasInputKeyJustPressed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WasInputKeyJustPressed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WasInputKeyJustPressed_IsValid = WasInputKeyJustPressed_FunctionAddress != IntPtr.Zero && WasInputKeyJustPressed_Key_IsValid && WasInputKeyJustPressed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:WasInputKeyJustPressed", WasInputKeyJustPressed_IsValid);
		StreamingSourceShouldBlockOnSlowStreaming_C5C07849_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StreamingSourceShouldBlockOnSlowStreaming");
		StreamingSourceShouldBlockOnSlowStreaming_C5C07849_ParamsSize = NativeReflection.GetFunctionParamsSize(StreamingSourceShouldBlockOnSlowStreaming_C5C07849_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StreamingSourceShouldBlockOnSlowStreaming_C5C07849_ReturnValue_PropertyAddress, StreamingSourceShouldBlockOnSlowStreaming_C5C07849_FunctionAddress, "ReturnValue");
		StreamingSourceShouldBlockOnSlowStreaming_C5C07849_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StreamingSourceShouldBlockOnSlowStreaming_C5C07849_FunctionAddress, "ReturnValue");
		StreamingSourceShouldBlockOnSlowStreaming_C5C07849_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StreamingSourceShouldBlockOnSlowStreaming_C5C07849_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		StreamingSourceShouldBlockOnSlowStreaming_C5C07849_IsValid = StreamingSourceShouldBlockOnSlowStreaming_C5C07849_FunctionAddress != IntPtr.Zero && StreamingSourceShouldBlockOnSlowStreaming_C5C07849_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:StreamingSourceShouldBlockOnSlowStreaming", StreamingSourceShouldBlockOnSlowStreaming_C5C07849_IsValid);
		StreamingSourceShouldActivate_E1011EAF_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StreamingSourceShouldActivate");
		StreamingSourceShouldActivate_E1011EAF_ParamsSize = NativeReflection.GetFunctionParamsSize(StreamingSourceShouldActivate_E1011EAF_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StreamingSourceShouldActivate_E1011EAF_ReturnValue_PropertyAddress, StreamingSourceShouldActivate_E1011EAF_FunctionAddress, "ReturnValue");
		StreamingSourceShouldActivate_E1011EAF_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StreamingSourceShouldActivate_E1011EAF_FunctionAddress, "ReturnValue");
		StreamingSourceShouldActivate_E1011EAF_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StreamingSourceShouldActivate_E1011EAF_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		StreamingSourceShouldActivate_E1011EAF_IsValid = StreamingSourceShouldActivate_E1011EAF_FunctionAddress != IntPtr.Zero && StreamingSourceShouldActivate_E1011EAF_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:StreamingSourceShouldActivate", StreamingSourceShouldActivate_E1011EAF_IsValid);
		StopHapticEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopHapticEffect");
		StopHapticEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(StopHapticEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopHapticEffect_Hand_PropertyAddress, StopHapticEffect_FunctionAddress, "Hand");
		StopHapticEffect_Hand_Offset = NativeReflectionCached.GetPropertyOffset(StopHapticEffect_FunctionAddress, "Hand");
		StopHapticEffect_Hand_IsValid = NativeReflectionCached.ValidatePropertyClass(StopHapticEffect_FunctionAddress, "Hand", Classes.FEnumProperty);
		StopHapticEffect_IsValid = StopHapticEffect_FunctionAddress != IntPtr.Zero && StopHapticEffect_Hand_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:StopHapticEffect", StopHapticEffect_IsValid);
		SetVirtualJoystickVisibility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVirtualJoystickVisibility");
		SetVirtualJoystickVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVirtualJoystickVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVirtualJoystickVisibility_bVisible_PropertyAddress, SetVirtualJoystickVisibility_FunctionAddress, "bVisible");
		SetVirtualJoystickVisibility_bVisible_Offset = NativeReflectionCached.GetPropertyOffset(SetVirtualJoystickVisibility_FunctionAddress, "bVisible");
		SetVirtualJoystickVisibility_bVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVirtualJoystickVisibility_FunctionAddress, "bVisible", Classes.FBoolProperty);
		SetVirtualJoystickVisibility_IsValid = SetVirtualJoystickVisibility_FunctionAddress != IntPtr.Zero && SetVirtualJoystickVisibility_bVisible_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:SetVirtualJoystickVisibility", SetVirtualJoystickVisibility_IsValid);
		SetViewTargetWithBlend_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetViewTargetWithBlend");
		SetViewTargetWithBlend_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewTargetWithBlend_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewTargetWithBlend_NewViewTarget_PropertyAddress, SetViewTargetWithBlend_FunctionAddress, "NewViewTarget");
		SetViewTargetWithBlend_NewViewTarget_Offset = NativeReflectionCached.GetPropertyOffset(SetViewTargetWithBlend_FunctionAddress, "NewViewTarget");
		SetViewTargetWithBlend_NewViewTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewTargetWithBlend_FunctionAddress, "NewViewTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetViewTargetWithBlend_BlendTime_PropertyAddress, SetViewTargetWithBlend_FunctionAddress, "BlendTime");
		SetViewTargetWithBlend_BlendTime_Offset = NativeReflectionCached.GetPropertyOffset(SetViewTargetWithBlend_FunctionAddress, "BlendTime");
		SetViewTargetWithBlend_BlendTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewTargetWithBlend_FunctionAddress, "BlendTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetViewTargetWithBlend_BlendFunc_PropertyAddress, SetViewTargetWithBlend_FunctionAddress, "BlendFunc");
		SetViewTargetWithBlend_BlendFunc_Offset = NativeReflectionCached.GetPropertyOffset(SetViewTargetWithBlend_FunctionAddress, "BlendFunc");
		SetViewTargetWithBlend_BlendFunc_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewTargetWithBlend_FunctionAddress, "BlendFunc", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetViewTargetWithBlend_BlendExp_PropertyAddress, SetViewTargetWithBlend_FunctionAddress, "BlendExp");
		SetViewTargetWithBlend_BlendExp_Offset = NativeReflectionCached.GetPropertyOffset(SetViewTargetWithBlend_FunctionAddress, "BlendExp");
		SetViewTargetWithBlend_BlendExp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewTargetWithBlend_FunctionAddress, "BlendExp", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetViewTargetWithBlend_bLockOutgoing_PropertyAddress, SetViewTargetWithBlend_FunctionAddress, "bLockOutgoing");
		SetViewTargetWithBlend_bLockOutgoing_Offset = NativeReflectionCached.GetPropertyOffset(SetViewTargetWithBlend_FunctionAddress, "bLockOutgoing");
		SetViewTargetWithBlend_bLockOutgoing_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewTargetWithBlend_FunctionAddress, "bLockOutgoing", Classes.FBoolProperty);
		SetViewTargetWithBlend_IsValid = SetViewTargetWithBlend_FunctionAddress != IntPtr.Zero && SetViewTargetWithBlend_NewViewTarget_IsValid && SetViewTargetWithBlend_BlendTime_IsValid && SetViewTargetWithBlend_BlendFunc_IsValid && SetViewTargetWithBlend_BlendExp_IsValid && SetViewTargetWithBlend_bLockOutgoing_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:SetViewTargetWithBlend", SetViewTargetWithBlend_IsValid);
		SetMouseLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMouseLocation");
		SetMouseLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMouseLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMouseLocation_X_PropertyAddress, SetMouseLocation_FunctionAddress, "X");
		SetMouseLocation_X_Offset = NativeReflectionCached.GetPropertyOffset(SetMouseLocation_FunctionAddress, "X");
		SetMouseLocation_X_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMouseLocation_FunctionAddress, "X", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMouseLocation_Y_PropertyAddress, SetMouseLocation_FunctionAddress, "Y");
		SetMouseLocation_Y_Offset = NativeReflectionCached.GetPropertyOffset(SetMouseLocation_FunctionAddress, "Y");
		SetMouseLocation_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMouseLocation_FunctionAddress, "Y", Classes.FIntProperty);
		SetMouseLocation_IsValid = SetMouseLocation_FunctionAddress != IntPtr.Zero && SetMouseLocation_X_IsValid && SetMouseLocation_Y_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:SetMouseLocation", SetMouseLocation_IsValid);
		SetMouseCursorWidget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMouseCursorWidget");
		SetMouseCursorWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMouseCursorWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMouseCursorWidget_Cursor_PropertyAddress, SetMouseCursorWidget_FunctionAddress, "Cursor");
		SetMouseCursorWidget_Cursor_Offset = NativeReflectionCached.GetPropertyOffset(SetMouseCursorWidget_FunctionAddress, "Cursor");
		SetMouseCursorWidget_Cursor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMouseCursorWidget_FunctionAddress, "Cursor", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMouseCursorWidget_CursorWidget_PropertyAddress, SetMouseCursorWidget_FunctionAddress, "CursorWidget");
		SetMouseCursorWidget_CursorWidget_Offset = NativeReflectionCached.GetPropertyOffset(SetMouseCursorWidget_FunctionAddress, "CursorWidget");
		SetMouseCursorWidget_CursorWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMouseCursorWidget_FunctionAddress, "CursorWidget", Classes.FObjectProperty);
		SetMouseCursorWidget_IsValid = SetMouseCursorWidget_FunctionAddress != IntPtr.Zero && SetMouseCursorWidget_Cursor_IsValid && SetMouseCursorWidget_CursorWidget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:SetMouseCursorWidget", SetMouseCursorWidget_IsValid);
		SetHapticsByValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHapticsByValue");
		SetHapticsByValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHapticsByValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHapticsByValue_Frequency_PropertyAddress, SetHapticsByValue_FunctionAddress, "Frequency");
		SetHapticsByValue_Frequency_Offset = NativeReflectionCached.GetPropertyOffset(SetHapticsByValue_FunctionAddress, "Frequency");
		SetHapticsByValue_Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHapticsByValue_FunctionAddress, "Frequency", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHapticsByValue_Amplitude_PropertyAddress, SetHapticsByValue_FunctionAddress, "Amplitude");
		SetHapticsByValue_Amplitude_Offset = NativeReflectionCached.GetPropertyOffset(SetHapticsByValue_FunctionAddress, "Amplitude");
		SetHapticsByValue_Amplitude_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHapticsByValue_FunctionAddress, "Amplitude", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHapticsByValue_Hand_PropertyAddress, SetHapticsByValue_FunctionAddress, "Hand");
		SetHapticsByValue_Hand_Offset = NativeReflectionCached.GetPropertyOffset(SetHapticsByValue_FunctionAddress, "Hand");
		SetHapticsByValue_Hand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHapticsByValue_FunctionAddress, "Hand", Classes.FEnumProperty);
		SetHapticsByValue_IsValid = SetHapticsByValue_FunctionAddress != IntPtr.Zero && SetHapticsByValue_Frequency_IsValid && SetHapticsByValue_Amplitude_IsValid && SetHapticsByValue_Hand_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:SetHapticsByValue", SetHapticsByValue_IsValid);
		SetDisableHaptics_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDisableHaptics");
		SetDisableHaptics_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDisableHaptics_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDisableHaptics_bNewDisabled_PropertyAddress, SetDisableHaptics_FunctionAddress, "bNewDisabled");
		SetDisableHaptics_bNewDisabled_Offset = NativeReflectionCached.GetPropertyOffset(SetDisableHaptics_FunctionAddress, "bNewDisabled");
		SetDisableHaptics_bNewDisabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisableHaptics_FunctionAddress, "bNewDisabled", Classes.FBoolProperty);
		SetDisableHaptics_IsValid = SetDisableHaptics_FunctionAddress != IntPtr.Zero && SetDisableHaptics_bNewDisabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:SetDisableHaptics", SetDisableHaptics_IsValid);
		SetDeprecatedInputYawScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDeprecatedInputYawScale");
		SetDeprecatedInputYawScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDeprecatedInputYawScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDeprecatedInputYawScale_NewValue_PropertyAddress, SetDeprecatedInputYawScale_FunctionAddress, "NewValue");
		SetDeprecatedInputYawScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetDeprecatedInputYawScale_FunctionAddress, "NewValue");
		SetDeprecatedInputYawScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDeprecatedInputYawScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetDeprecatedInputYawScale_IsValid = SetDeprecatedInputYawScale_FunctionAddress != IntPtr.Zero && SetDeprecatedInputYawScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:SetDeprecatedInputYawScale", SetDeprecatedInputYawScale_IsValid);
		SetDeprecatedInputRollScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDeprecatedInputRollScale");
		SetDeprecatedInputRollScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDeprecatedInputRollScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDeprecatedInputRollScale_NewValue_PropertyAddress, SetDeprecatedInputRollScale_FunctionAddress, "NewValue");
		SetDeprecatedInputRollScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetDeprecatedInputRollScale_FunctionAddress, "NewValue");
		SetDeprecatedInputRollScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDeprecatedInputRollScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetDeprecatedInputRollScale_IsValid = SetDeprecatedInputRollScale_FunctionAddress != IntPtr.Zero && SetDeprecatedInputRollScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:SetDeprecatedInputRollScale", SetDeprecatedInputRollScale_IsValid);
		SetDeprecatedInputPitchScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDeprecatedInputPitchScale");
		SetDeprecatedInputPitchScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDeprecatedInputPitchScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDeprecatedInputPitchScale_NewValue_PropertyAddress, SetDeprecatedInputPitchScale_FunctionAddress, "NewValue");
		SetDeprecatedInputPitchScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetDeprecatedInputPitchScale_FunctionAddress, "NewValue");
		SetDeprecatedInputPitchScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDeprecatedInputPitchScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetDeprecatedInputPitchScale_IsValid = SetDeprecatedInputPitchScale_FunctionAddress != IntPtr.Zero && SetDeprecatedInputPitchScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:SetDeprecatedInputPitchScale", SetDeprecatedInputPitchScale_IsValid);
		SetControllerLightColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetControllerLightColor");
		SetControllerLightColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControllerLightColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControllerLightColor_Color_PropertyAddress, SetControllerLightColor_FunctionAddress, "Color");
		SetControllerLightColor_Color_Offset = NativeReflectionCached.GetPropertyOffset(SetControllerLightColor_FunctionAddress, "Color");
		SetControllerLightColor_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControllerLightColor_FunctionAddress, "Color", Classes.FStructProperty);
		SetControllerLightColor_IsValid = SetControllerLightColor_FunctionAddress != IntPtr.Zero && SetControllerLightColor_Color_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:SetControllerLightColor", SetControllerLightColor_IsValid);
		SetCinematicMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCinematicMode");
		SetCinematicMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCinematicMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCinematicMode_bInCinematicMode_PropertyAddress, SetCinematicMode_FunctionAddress, "bInCinematicMode");
		SetCinematicMode_bInCinematicMode_Offset = NativeReflectionCached.GetPropertyOffset(SetCinematicMode_FunctionAddress, "bInCinematicMode");
		SetCinematicMode_bInCinematicMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCinematicMode_FunctionAddress, "bInCinematicMode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCinematicMode_bHidePlayer_PropertyAddress, SetCinematicMode_FunctionAddress, "bHidePlayer");
		SetCinematicMode_bHidePlayer_Offset = NativeReflectionCached.GetPropertyOffset(SetCinematicMode_FunctionAddress, "bHidePlayer");
		SetCinematicMode_bHidePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCinematicMode_FunctionAddress, "bHidePlayer", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCinematicMode_bAffectsHUD_PropertyAddress, SetCinematicMode_FunctionAddress, "bAffectsHUD");
		SetCinematicMode_bAffectsHUD_Offset = NativeReflectionCached.GetPropertyOffset(SetCinematicMode_FunctionAddress, "bAffectsHUD");
		SetCinematicMode_bAffectsHUD_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCinematicMode_FunctionAddress, "bAffectsHUD", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCinematicMode_bAffectsMovement_PropertyAddress, SetCinematicMode_FunctionAddress, "bAffectsMovement");
		SetCinematicMode_bAffectsMovement_Offset = NativeReflectionCached.GetPropertyOffset(SetCinematicMode_FunctionAddress, "bAffectsMovement");
		SetCinematicMode_bAffectsMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCinematicMode_FunctionAddress, "bAffectsMovement", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCinematicMode_bAffectsTurning_PropertyAddress, SetCinematicMode_FunctionAddress, "bAffectsTurning");
		SetCinematicMode_bAffectsTurning_Offset = NativeReflectionCached.GetPropertyOffset(SetCinematicMode_FunctionAddress, "bAffectsTurning");
		SetCinematicMode_bAffectsTurning_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCinematicMode_FunctionAddress, "bAffectsTurning", Classes.FBoolProperty);
		SetCinematicMode_IsValid = SetCinematicMode_FunctionAddress != IntPtr.Zero && SetCinematicMode_bInCinematicMode_IsValid && SetCinematicMode_bHidePlayer_IsValid && SetCinematicMode_bAffectsHUD_IsValid && SetCinematicMode_bAffectsMovement_IsValid && SetCinematicMode_bAffectsTurning_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:SetCinematicMode", SetCinematicMode_IsValid);
		SetAudioListenerOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAudioListenerOverride");
		SetAudioListenerOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAudioListenerOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAudioListenerOverride_AttachToComponent_PropertyAddress, SetAudioListenerOverride_FunctionAddress, "AttachToComponent");
		SetAudioListenerOverride_AttachToComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioListenerOverride_FunctionAddress, "AttachToComponent");
		SetAudioListenerOverride_AttachToComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioListenerOverride_FunctionAddress, "AttachToComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAudioListenerOverride_Location_PropertyAddress, SetAudioListenerOverride_FunctionAddress, "Location");
		SetAudioListenerOverride_Location_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioListenerOverride_FunctionAddress, "Location");
		SetAudioListenerOverride_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioListenerOverride_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAudioListenerOverride_Rotation_PropertyAddress, SetAudioListenerOverride_FunctionAddress, "Rotation");
		SetAudioListenerOverride_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioListenerOverride_FunctionAddress, "Rotation");
		SetAudioListenerOverride_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioListenerOverride_FunctionAddress, "Rotation", Classes.FStructProperty);
		SetAudioListenerOverride_IsValid = SetAudioListenerOverride_FunctionAddress != IntPtr.Zero && SetAudioListenerOverride_AttachToComponent_IsValid && SetAudioListenerOverride_Location_IsValid && SetAudioListenerOverride_Rotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:SetAudioListenerOverride", SetAudioListenerOverride_IsValid);
		SetAudioListenerAttenuationOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAudioListenerAttenuationOverride");
		SetAudioListenerAttenuationOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAudioListenerAttenuationOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAudioListenerAttenuationOverride_AttachToComponent_PropertyAddress, SetAudioListenerAttenuationOverride_FunctionAddress, "AttachToComponent");
		SetAudioListenerAttenuationOverride_AttachToComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioListenerAttenuationOverride_FunctionAddress, "AttachToComponent");
		SetAudioListenerAttenuationOverride_AttachToComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioListenerAttenuationOverride_FunctionAddress, "AttachToComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAudioListenerAttenuationOverride_AttenuationLocationOVerride_PropertyAddress, SetAudioListenerAttenuationOverride_FunctionAddress, "AttenuationLocationOVerride");
		SetAudioListenerAttenuationOverride_AttenuationLocationOVerride_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioListenerAttenuationOverride_FunctionAddress, "AttenuationLocationOVerride");
		SetAudioListenerAttenuationOverride_AttenuationLocationOVerride_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioListenerAttenuationOverride_FunctionAddress, "AttenuationLocationOVerride", Classes.FStructProperty);
		SetAudioListenerAttenuationOverride_IsValid = SetAudioListenerAttenuationOverride_FunctionAddress != IntPtr.Zero && SetAudioListenerAttenuationOverride_AttachToComponent_IsValid && SetAudioListenerAttenuationOverride_AttenuationLocationOVerride_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:SetAudioListenerAttenuationOverride", SetAudioListenerAttenuationOverride_IsValid);
		ResetControllerLightColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetControllerLightColor");
		ResetControllerLightColor_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetControllerLightColor_FunctionAddress);
		ResetControllerLightColor_IsValid = ResetControllerLightColor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:ResetControllerLightColor", ResetControllerLightColor_IsValid);
		ProjectWorldLocationToScreen_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProjectWorldLocationToScreen");
		ProjectWorldLocationToScreen_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectWorldLocationToScreen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectWorldLocationToScreen_WorldLocation_PropertyAddress, ProjectWorldLocationToScreen_FunctionAddress, "WorldLocation");
		ProjectWorldLocationToScreen_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(ProjectWorldLocationToScreen_FunctionAddress, "WorldLocation");
		ProjectWorldLocationToScreen_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectWorldLocationToScreen_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectWorldLocationToScreen_ScreenLocation_PropertyAddress, ProjectWorldLocationToScreen_FunctionAddress, "ScreenLocation");
		ProjectWorldLocationToScreen_ScreenLocation_Offset = NativeReflectionCached.GetPropertyOffset(ProjectWorldLocationToScreen_FunctionAddress, "ScreenLocation");
		ProjectWorldLocationToScreen_ScreenLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectWorldLocationToScreen_FunctionAddress, "ScreenLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectWorldLocationToScreen_bPlayerViewportRelative_PropertyAddress, ProjectWorldLocationToScreen_FunctionAddress, "bPlayerViewportRelative");
		ProjectWorldLocationToScreen_bPlayerViewportRelative_Offset = NativeReflectionCached.GetPropertyOffset(ProjectWorldLocationToScreen_FunctionAddress, "bPlayerViewportRelative");
		ProjectWorldLocationToScreen_bPlayerViewportRelative_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectWorldLocationToScreen_FunctionAddress, "bPlayerViewportRelative", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectWorldLocationToScreen_ReturnValue_PropertyAddress, ProjectWorldLocationToScreen_FunctionAddress, "ReturnValue");
		ProjectWorldLocationToScreen_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectWorldLocationToScreen_FunctionAddress, "ReturnValue");
		ProjectWorldLocationToScreen_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectWorldLocationToScreen_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ProjectWorldLocationToScreen_IsValid = ProjectWorldLocationToScreen_FunctionAddress != IntPtr.Zero && ProjectWorldLocationToScreen_WorldLocation_IsValid && ProjectWorldLocationToScreen_ScreenLocation_IsValid && ProjectWorldLocationToScreen_bPlayerViewportRelative_IsValid && ProjectWorldLocationToScreen_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:ProjectWorldLocationToScreen", ProjectWorldLocationToScreen_IsValid);
		PlayHapticEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayHapticEffect");
		PlayHapticEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayHapticEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayHapticEffect_HapticEffect_PropertyAddress, PlayHapticEffect_FunctionAddress, "HapticEffect");
		PlayHapticEffect_HapticEffect_Offset = NativeReflectionCached.GetPropertyOffset(PlayHapticEffect_FunctionAddress, "HapticEffect");
		PlayHapticEffect_HapticEffect_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayHapticEffect_FunctionAddress, "HapticEffect", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayHapticEffect_Hand_PropertyAddress, PlayHapticEffect_FunctionAddress, "Hand");
		PlayHapticEffect_Hand_Offset = NativeReflectionCached.GetPropertyOffset(PlayHapticEffect_FunctionAddress, "Hand");
		PlayHapticEffect_Hand_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayHapticEffect_FunctionAddress, "Hand", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayHapticEffect_Scale_PropertyAddress, PlayHapticEffect_FunctionAddress, "Scale");
		PlayHapticEffect_Scale_Offset = NativeReflectionCached.GetPropertyOffset(PlayHapticEffect_FunctionAddress, "Scale");
		PlayHapticEffect_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayHapticEffect_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayHapticEffect_bLoop_PropertyAddress, PlayHapticEffect_FunctionAddress, "bLoop");
		PlayHapticEffect_bLoop_Offset = NativeReflectionCached.GetPropertyOffset(PlayHapticEffect_FunctionAddress, "bLoop");
		PlayHapticEffect_bLoop_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayHapticEffect_FunctionAddress, "bLoop", Classes.FBoolProperty);
		PlayHapticEffect_IsValid = PlayHapticEffect_FunctionAddress != IntPtr.Zero && PlayHapticEffect_HapticEffect_IsValid && PlayHapticEffect_Hand_IsValid && PlayHapticEffect_Scale_IsValid && PlayHapticEffect_bLoop_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:PlayHapticEffect", PlayHapticEffect_IsValid);
		PlayDynamicForceFeedback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayDynamicForceFeedback");
		PlayDynamicForceFeedback_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayDynamicForceFeedback_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayDynamicForceFeedback_Intensity_PropertyAddress, PlayDynamicForceFeedback_FunctionAddress, "Intensity");
		PlayDynamicForceFeedback_Intensity_Offset = NativeReflectionCached.GetPropertyOffset(PlayDynamicForceFeedback_FunctionAddress, "Intensity");
		PlayDynamicForceFeedback_Intensity_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayDynamicForceFeedback_FunctionAddress, "Intensity", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayDynamicForceFeedback_Duration_PropertyAddress, PlayDynamicForceFeedback_FunctionAddress, "Duration");
		PlayDynamicForceFeedback_Duration_Offset = NativeReflectionCached.GetPropertyOffset(PlayDynamicForceFeedback_FunctionAddress, "Duration");
		PlayDynamicForceFeedback_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayDynamicForceFeedback_FunctionAddress, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayDynamicForceFeedback_bAffectsLeftLarge_PropertyAddress, PlayDynamicForceFeedback_FunctionAddress, "bAffectsLeftLarge");
		PlayDynamicForceFeedback_bAffectsLeftLarge_Offset = NativeReflectionCached.GetPropertyOffset(PlayDynamicForceFeedback_FunctionAddress, "bAffectsLeftLarge");
		PlayDynamicForceFeedback_bAffectsLeftLarge_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayDynamicForceFeedback_FunctionAddress, "bAffectsLeftLarge", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayDynamicForceFeedback_bAffectsLeftSmall_PropertyAddress, PlayDynamicForceFeedback_FunctionAddress, "bAffectsLeftSmall");
		PlayDynamicForceFeedback_bAffectsLeftSmall_Offset = NativeReflectionCached.GetPropertyOffset(PlayDynamicForceFeedback_FunctionAddress, "bAffectsLeftSmall");
		PlayDynamicForceFeedback_bAffectsLeftSmall_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayDynamicForceFeedback_FunctionAddress, "bAffectsLeftSmall", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayDynamicForceFeedback_bAffectsRightLarge_PropertyAddress, PlayDynamicForceFeedback_FunctionAddress, "bAffectsRightLarge");
		PlayDynamicForceFeedback_bAffectsRightLarge_Offset = NativeReflectionCached.GetPropertyOffset(PlayDynamicForceFeedback_FunctionAddress, "bAffectsRightLarge");
		PlayDynamicForceFeedback_bAffectsRightLarge_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayDynamicForceFeedback_FunctionAddress, "bAffectsRightLarge", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayDynamicForceFeedback_bAffectsRightSmall_PropertyAddress, PlayDynamicForceFeedback_FunctionAddress, "bAffectsRightSmall");
		PlayDynamicForceFeedback_bAffectsRightSmall_Offset = NativeReflectionCached.GetPropertyOffset(PlayDynamicForceFeedback_FunctionAddress, "bAffectsRightSmall");
		PlayDynamicForceFeedback_bAffectsRightSmall_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayDynamicForceFeedback_FunctionAddress, "bAffectsRightSmall", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayDynamicForceFeedback_Action_PropertyAddress, PlayDynamicForceFeedback_FunctionAddress, "Action");
		PlayDynamicForceFeedback_Action_Offset = NativeReflectionCached.GetPropertyOffset(PlayDynamicForceFeedback_FunctionAddress, "Action");
		PlayDynamicForceFeedback_Action_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayDynamicForceFeedback_FunctionAddress, "Action", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayDynamicForceFeedback_LatentInfo_PropertyAddress, PlayDynamicForceFeedback_FunctionAddress, "LatentInfo");
		PlayDynamicForceFeedback_LatentInfo_Offset = NativeReflectionCached.GetPropertyOffset(PlayDynamicForceFeedback_FunctionAddress, "LatentInfo");
		PlayDynamicForceFeedback_LatentInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayDynamicForceFeedback_FunctionAddress, "LatentInfo", Classes.FStructProperty);
		PlayDynamicForceFeedback_IsValid = PlayDynamicForceFeedback_FunctionAddress != IntPtr.Zero && PlayDynamicForceFeedback_Intensity_IsValid && PlayDynamicForceFeedback_Duration_IsValid && PlayDynamicForceFeedback_bAffectsLeftLarge_IsValid && PlayDynamicForceFeedback_bAffectsLeftSmall_IsValid && PlayDynamicForceFeedback_bAffectsRightLarge_IsValid && PlayDynamicForceFeedback_bAffectsRightSmall_IsValid && PlayDynamicForceFeedback_Action_IsValid && PlayDynamicForceFeedback_LatentInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:PlayDynamicForceFeedback", PlayDynamicForceFeedback_IsValid);
		ClientPlayForceFeedback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_ClientPlayForceFeedback");
		ClientPlayForceFeedback_ParamsSize = NativeReflection.GetFunctionParamsSize(ClientPlayForceFeedback_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClientPlayForceFeedback_ForceFeedbackEffect_PropertyAddress, ClientPlayForceFeedback_FunctionAddress, "ForceFeedbackEffect");
		ClientPlayForceFeedback_ForceFeedbackEffect_Offset = NativeReflectionCached.GetPropertyOffset(ClientPlayForceFeedback_FunctionAddress, "ForceFeedbackEffect");
		ClientPlayForceFeedback_ForceFeedbackEffect_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientPlayForceFeedback_FunctionAddress, "ForceFeedbackEffect", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientPlayForceFeedback_Tag_PropertyAddress, ClientPlayForceFeedback_FunctionAddress, "Tag");
		ClientPlayForceFeedback_Tag_Offset = NativeReflectionCached.GetPropertyOffset(ClientPlayForceFeedback_FunctionAddress, "Tag");
		ClientPlayForceFeedback_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientPlayForceFeedback_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientPlayForceFeedback_bLooping_PropertyAddress, ClientPlayForceFeedback_FunctionAddress, "bLooping");
		ClientPlayForceFeedback_bLooping_Offset = NativeReflectionCached.GetPropertyOffset(ClientPlayForceFeedback_FunctionAddress, "bLooping");
		ClientPlayForceFeedback_bLooping_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientPlayForceFeedback_FunctionAddress, "bLooping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientPlayForceFeedback_bIgnoreTimeDilation_PropertyAddress, ClientPlayForceFeedback_FunctionAddress, "bIgnoreTimeDilation");
		ClientPlayForceFeedback_bIgnoreTimeDilation_Offset = NativeReflectionCached.GetPropertyOffset(ClientPlayForceFeedback_FunctionAddress, "bIgnoreTimeDilation");
		ClientPlayForceFeedback_bIgnoreTimeDilation_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientPlayForceFeedback_FunctionAddress, "bIgnoreTimeDilation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientPlayForceFeedback_bPlayWhilePaused_PropertyAddress, ClientPlayForceFeedback_FunctionAddress, "bPlayWhilePaused");
		ClientPlayForceFeedback_bPlayWhilePaused_Offset = NativeReflectionCached.GetPropertyOffset(ClientPlayForceFeedback_FunctionAddress, "bPlayWhilePaused");
		ClientPlayForceFeedback_bPlayWhilePaused_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientPlayForceFeedback_FunctionAddress, "bPlayWhilePaused", Classes.FBoolProperty);
		ClientPlayForceFeedback_IsValid = ClientPlayForceFeedback_FunctionAddress != IntPtr.Zero && ClientPlayForceFeedback_ForceFeedbackEffect_IsValid && ClientPlayForceFeedback_Tag_IsValid && ClientPlayForceFeedback_bLooping_IsValid && ClientPlayForceFeedback_bIgnoreTimeDilation_IsValid && ClientPlayForceFeedback_bPlayWhilePaused_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:K2_ClientPlayForceFeedback", ClientPlayForceFeedback_IsValid);
		IsStreamingSourceEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsStreamingSourceEnabled");
		IsStreamingSourceEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsStreamingSourceEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsStreamingSourceEnabled_ReturnValue_PropertyAddress, IsStreamingSourceEnabled_FunctionAddress, "ReturnValue");
		IsStreamingSourceEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsStreamingSourceEnabled_FunctionAddress, "ReturnValue");
		IsStreamingSourceEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStreamingSourceEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsStreamingSourceEnabled_IsValid = IsStreamingSourceEnabled_FunctionAddress != IntPtr.Zero && IsStreamingSourceEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:IsStreamingSourceEnabled", IsStreamingSourceEnabled_IsValid);
		IsInputKeyDown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsInputKeyDown");
		IsInputKeyDown_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInputKeyDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInputKeyDown_Key_PropertyAddress, IsInputKeyDown_FunctionAddress, "Key");
		IsInputKeyDown_Key_Offset = NativeReflectionCached.GetPropertyOffset(IsInputKeyDown_FunctionAddress, "Key");
		IsInputKeyDown_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInputKeyDown_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsInputKeyDown_ReturnValue_PropertyAddress, IsInputKeyDown_FunctionAddress, "ReturnValue");
		IsInputKeyDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInputKeyDown_FunctionAddress, "ReturnValue");
		IsInputKeyDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInputKeyDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInputKeyDown_IsValid = IsInputKeyDown_FunctionAddress != IntPtr.Zero && IsInputKeyDown_Key_IsValid && IsInputKeyDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:IsInputKeyDown", IsInputKeyDown_IsValid);
		GetViewportSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewportSize");
		GetViewportSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewportSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewportSize_SizeX_PropertyAddress, GetViewportSize_FunctionAddress, "SizeX");
		GetViewportSize_SizeX_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportSize_FunctionAddress, "SizeX");
		GetViewportSize_SizeX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportSize_FunctionAddress, "SizeX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetViewportSize_SizeY_PropertyAddress, GetViewportSize_FunctionAddress, "SizeY");
		GetViewportSize_SizeY_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportSize_FunctionAddress, "SizeY");
		GetViewportSize_SizeY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportSize_FunctionAddress, "SizeY", Classes.FIntProperty);
		GetViewportSize_IsValid = GetViewportSize_FunctionAddress != IntPtr.Zero && GetViewportSize_SizeX_IsValid && GetViewportSize_SizeY_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetViewportSize", GetViewportSize_IsValid);
		GetSpectatorPawn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSpectatorPawn");
		GetSpectatorPawn_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpectatorPawn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpectatorPawn_ReturnValue_PropertyAddress, GetSpectatorPawn_FunctionAddress, "ReturnValue");
		GetSpectatorPawn_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSpectatorPawn_FunctionAddress, "ReturnValue");
		GetSpectatorPawn_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpectatorPawn_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSpectatorPawn_IsValid = GetSpectatorPawn_FunctionAddress != IntPtr.Zero && GetSpectatorPawn_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetSpectatorPawn", GetSpectatorPawn_IsValid);
		GetMousePosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMousePosition");
		GetMousePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMousePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMousePosition_LocationX_PropertyAddress, GetMousePosition_FunctionAddress, "LocationX");
		GetMousePosition_LocationX_Offset = NativeReflectionCached.GetPropertyOffset(GetMousePosition_FunctionAddress, "LocationX");
		GetMousePosition_LocationX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMousePosition_FunctionAddress, "LocationX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMousePosition_LocationY_PropertyAddress, GetMousePosition_FunctionAddress, "LocationY");
		GetMousePosition_LocationY_Offset = NativeReflectionCached.GetPropertyOffset(GetMousePosition_FunctionAddress, "LocationY");
		GetMousePosition_LocationY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMousePosition_FunctionAddress, "LocationY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMousePosition_ReturnValue_PropertyAddress, GetMousePosition_FunctionAddress, "ReturnValue");
		GetMousePosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMousePosition_FunctionAddress, "ReturnValue");
		GetMousePosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMousePosition_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetMousePosition_IsValid = GetMousePosition_FunctionAddress != IntPtr.Zero && GetMousePosition_LocationX_IsValid && GetMousePosition_LocationY_IsValid && GetMousePosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetMousePosition", GetMousePosition_IsValid);
		GetInputVectorKeyState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInputVectorKeyState");
		GetInputVectorKeyState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputVectorKeyState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputVectorKeyState_Key_PropertyAddress, GetInputVectorKeyState_FunctionAddress, "Key");
		GetInputVectorKeyState_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetInputVectorKeyState_FunctionAddress, "Key");
		GetInputVectorKeyState_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputVectorKeyState_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputVectorKeyState_ReturnValue_PropertyAddress, GetInputVectorKeyState_FunctionAddress, "ReturnValue");
		GetInputVectorKeyState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputVectorKeyState_FunctionAddress, "ReturnValue");
		GetInputVectorKeyState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputVectorKeyState_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetInputVectorKeyState_IsValid = GetInputVectorKeyState_FunctionAddress != IntPtr.Zero && GetInputVectorKeyState_Key_IsValid && GetInputVectorKeyState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetInputVectorKeyState", GetInputVectorKeyState_IsValid);
		GetInputTouchState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInputTouchState");
		GetInputTouchState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputTouchState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputTouchState_FingerIndex_PropertyAddress, GetInputTouchState_FunctionAddress, "FingerIndex");
		GetInputTouchState_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetInputTouchState_FunctionAddress, "FingerIndex");
		GetInputTouchState_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputTouchState_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputTouchState_LocationX_PropertyAddress, GetInputTouchState_FunctionAddress, "LocationX");
		GetInputTouchState_LocationX_Offset = NativeReflectionCached.GetPropertyOffset(GetInputTouchState_FunctionAddress, "LocationX");
		GetInputTouchState_LocationX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputTouchState_FunctionAddress, "LocationX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputTouchState_LocationY_PropertyAddress, GetInputTouchState_FunctionAddress, "LocationY");
		GetInputTouchState_LocationY_Offset = NativeReflectionCached.GetPropertyOffset(GetInputTouchState_FunctionAddress, "LocationY");
		GetInputTouchState_LocationY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputTouchState_FunctionAddress, "LocationY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputTouchState_bIsCurrentlyPressed_PropertyAddress, GetInputTouchState_FunctionAddress, "bIsCurrentlyPressed");
		GetInputTouchState_bIsCurrentlyPressed_Offset = NativeReflectionCached.GetPropertyOffset(GetInputTouchState_FunctionAddress, "bIsCurrentlyPressed");
		GetInputTouchState_bIsCurrentlyPressed_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputTouchState_FunctionAddress, "bIsCurrentlyPressed", Classes.FBoolProperty);
		GetInputTouchState_IsValid = GetInputTouchState_FunctionAddress != IntPtr.Zero && GetInputTouchState_FingerIndex_IsValid && GetInputTouchState_LocationX_IsValid && GetInputTouchState_LocationY_IsValid && GetInputTouchState_bIsCurrentlyPressed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetInputTouchState", GetInputTouchState_IsValid);
		GetInputMouseDelta_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInputMouseDelta");
		GetInputMouseDelta_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputMouseDelta_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputMouseDelta_DeltaX_PropertyAddress, GetInputMouseDelta_FunctionAddress, "DeltaX");
		GetInputMouseDelta_DeltaX_Offset = NativeReflectionCached.GetPropertyOffset(GetInputMouseDelta_FunctionAddress, "DeltaX");
		GetInputMouseDelta_DeltaX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputMouseDelta_FunctionAddress, "DeltaX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputMouseDelta_DeltaY_PropertyAddress, GetInputMouseDelta_FunctionAddress, "DeltaY");
		GetInputMouseDelta_DeltaY_Offset = NativeReflectionCached.GetPropertyOffset(GetInputMouseDelta_FunctionAddress, "DeltaY");
		GetInputMouseDelta_DeltaY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputMouseDelta_FunctionAddress, "DeltaY", Classes.FFloatProperty);
		GetInputMouseDelta_IsValid = GetInputMouseDelta_FunctionAddress != IntPtr.Zero && GetInputMouseDelta_DeltaX_IsValid && GetInputMouseDelta_DeltaY_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetInputMouseDelta", GetInputMouseDelta_IsValid);
		GetInputMotionState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInputMotionState");
		GetInputMotionState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputMotionState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputMotionState_Tilt_PropertyAddress, GetInputMotionState_FunctionAddress, "Tilt");
		GetInputMotionState_Tilt_Offset = NativeReflectionCached.GetPropertyOffset(GetInputMotionState_FunctionAddress, "Tilt");
		GetInputMotionState_Tilt_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputMotionState_FunctionAddress, "Tilt", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputMotionState_RotationRate_PropertyAddress, GetInputMotionState_FunctionAddress, "RotationRate");
		GetInputMotionState_RotationRate_Offset = NativeReflectionCached.GetPropertyOffset(GetInputMotionState_FunctionAddress, "RotationRate");
		GetInputMotionState_RotationRate_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputMotionState_FunctionAddress, "RotationRate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputMotionState_Gravity_PropertyAddress, GetInputMotionState_FunctionAddress, "Gravity");
		GetInputMotionState_Gravity_Offset = NativeReflectionCached.GetPropertyOffset(GetInputMotionState_FunctionAddress, "Gravity");
		GetInputMotionState_Gravity_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputMotionState_FunctionAddress, "Gravity", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputMotionState_Acceleration_PropertyAddress, GetInputMotionState_FunctionAddress, "Acceleration");
		GetInputMotionState_Acceleration_Offset = NativeReflectionCached.GetPropertyOffset(GetInputMotionState_FunctionAddress, "Acceleration");
		GetInputMotionState_Acceleration_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputMotionState_FunctionAddress, "Acceleration", Classes.FStructProperty);
		GetInputMotionState_IsValid = GetInputMotionState_FunctionAddress != IntPtr.Zero && GetInputMotionState_Tilt_IsValid && GetInputMotionState_RotationRate_IsValid && GetInputMotionState_Gravity_IsValid && GetInputMotionState_Acceleration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetInputMotionState", GetInputMotionState_IsValid);
		GetInputKeyTimeDown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInputKeyTimeDown");
		GetInputKeyTimeDown_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputKeyTimeDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputKeyTimeDown_Key_PropertyAddress, GetInputKeyTimeDown_FunctionAddress, "Key");
		GetInputKeyTimeDown_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetInputKeyTimeDown_FunctionAddress, "Key");
		GetInputKeyTimeDown_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputKeyTimeDown_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputKeyTimeDown_ReturnValue_PropertyAddress, GetInputKeyTimeDown_FunctionAddress, "ReturnValue");
		GetInputKeyTimeDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputKeyTimeDown_FunctionAddress, "ReturnValue");
		GetInputKeyTimeDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputKeyTimeDown_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetInputKeyTimeDown_IsValid = GetInputKeyTimeDown_FunctionAddress != IntPtr.Zero && GetInputKeyTimeDown_Key_IsValid && GetInputKeyTimeDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetInputKeyTimeDown", GetInputKeyTimeDown_IsValid);
		GetInputAnalogStickState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInputAnalogStickState");
		GetInputAnalogStickState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputAnalogStickState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputAnalogStickState_WhichStick_PropertyAddress, GetInputAnalogStickState_FunctionAddress, "WhichStick");
		GetInputAnalogStickState_WhichStick_Offset = NativeReflectionCached.GetPropertyOffset(GetInputAnalogStickState_FunctionAddress, "WhichStick");
		GetInputAnalogStickState_WhichStick_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputAnalogStickState_FunctionAddress, "WhichStick", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputAnalogStickState_StickX_PropertyAddress, GetInputAnalogStickState_FunctionAddress, "StickX");
		GetInputAnalogStickState_StickX_Offset = NativeReflectionCached.GetPropertyOffset(GetInputAnalogStickState_FunctionAddress, "StickX");
		GetInputAnalogStickState_StickX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputAnalogStickState_FunctionAddress, "StickX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputAnalogStickState_StickY_PropertyAddress, GetInputAnalogStickState_FunctionAddress, "StickY");
		GetInputAnalogStickState_StickY_Offset = NativeReflectionCached.GetPropertyOffset(GetInputAnalogStickState_FunctionAddress, "StickY");
		GetInputAnalogStickState_StickY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputAnalogStickState_FunctionAddress, "StickY", Classes.FFloatProperty);
		GetInputAnalogStickState_IsValid = GetInputAnalogStickState_FunctionAddress != IntPtr.Zero && GetInputAnalogStickState_WhichStick_IsValid && GetInputAnalogStickState_StickX_IsValid && GetInputAnalogStickState_StickY_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetInputAnalogStickState", GetInputAnalogStickState_IsValid);
		GetInputAnalogKeyState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInputAnalogKeyState");
		GetInputAnalogKeyState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputAnalogKeyState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputAnalogKeyState_Key_PropertyAddress, GetInputAnalogKeyState_FunctionAddress, "Key");
		GetInputAnalogKeyState_Key_Offset = NativeReflectionCached.GetPropertyOffset(GetInputAnalogKeyState_FunctionAddress, "Key");
		GetInputAnalogKeyState_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputAnalogKeyState_FunctionAddress, "Key", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputAnalogKeyState_ReturnValue_PropertyAddress, GetInputAnalogKeyState_FunctionAddress, "ReturnValue");
		GetInputAnalogKeyState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputAnalogKeyState_FunctionAddress, "ReturnValue");
		GetInputAnalogKeyState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputAnalogKeyState_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetInputAnalogKeyState_IsValid = GetInputAnalogKeyState_FunctionAddress != IntPtr.Zero && GetInputAnalogKeyState_Key_IsValid && GetInputAnalogKeyState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetInputAnalogKeyState", GetInputAnalogKeyState_IsValid);
		GetHUD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHUD");
		GetHUD_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHUD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHUD_ReturnValue_PropertyAddress, GetHUD_FunctionAddress, "ReturnValue");
		GetHUD_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHUD_FunctionAddress, "ReturnValue");
		GetHUD_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHUD_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetHUD_IsValid = GetHUD_FunctionAddress != IntPtr.Zero && GetHUD_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetHUD", GetHUD_IsValid);
		GetHitResultUnderFingerForObjects_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHitResultUnderFingerForObjects");
		GetHitResultUnderFingerForObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHitResultUnderFingerForObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderFingerForObjects_FingerIndex_PropertyAddress, GetHitResultUnderFingerForObjects_FunctionAddress, "FingerIndex");
		GetHitResultUnderFingerForObjects_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderFingerForObjects_FunctionAddress, "FingerIndex");
		GetHitResultUnderFingerForObjects_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderFingerForObjects_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderFingerForObjects_ObjectTypes_PropertyAddress, GetHitResultUnderFingerForObjects_FunctionAddress, "ObjectTypes");
		GetHitResultUnderFingerForObjects_ObjectTypes_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderFingerForObjects_FunctionAddress, "ObjectTypes");
		GetHitResultUnderFingerForObjects_ObjectTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderFingerForObjects_FunctionAddress, "ObjectTypes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderFingerForObjects_bTraceComplex_PropertyAddress, GetHitResultUnderFingerForObjects_FunctionAddress, "bTraceComplex");
		GetHitResultUnderFingerForObjects_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderFingerForObjects_FunctionAddress, "bTraceComplex");
		GetHitResultUnderFingerForObjects_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderFingerForObjects_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderFingerForObjects_HitResult_PropertyAddress, GetHitResultUnderFingerForObjects_FunctionAddress, "HitResult");
		GetHitResultUnderFingerForObjects_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderFingerForObjects_FunctionAddress, "HitResult");
		GetHitResultUnderFingerForObjects_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderFingerForObjects_FunctionAddress, "HitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderFingerForObjects_ReturnValue_PropertyAddress, GetHitResultUnderFingerForObjects_FunctionAddress, "ReturnValue");
		GetHitResultUnderFingerForObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderFingerForObjects_FunctionAddress, "ReturnValue");
		GetHitResultUnderFingerForObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderFingerForObjects_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetHitResultUnderFingerForObjects_IsValid = GetHitResultUnderFingerForObjects_FunctionAddress != IntPtr.Zero && GetHitResultUnderFingerForObjects_FingerIndex_IsValid && GetHitResultUnderFingerForObjects_ObjectTypes_IsValid && GetHitResultUnderFingerForObjects_bTraceComplex_IsValid && GetHitResultUnderFingerForObjects_HitResult_IsValid && GetHitResultUnderFingerForObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetHitResultUnderFingerForObjects", GetHitResultUnderFingerForObjects_IsValid);
		GetHitResultUnderFingerByChannel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHitResultUnderFingerByChannel");
		GetHitResultUnderFingerByChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHitResultUnderFingerByChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderFingerByChannel_FingerIndex_PropertyAddress, GetHitResultUnderFingerByChannel_FunctionAddress, "FingerIndex");
		GetHitResultUnderFingerByChannel_FingerIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderFingerByChannel_FunctionAddress, "FingerIndex");
		GetHitResultUnderFingerByChannel_FingerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderFingerByChannel_FunctionAddress, "FingerIndex", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderFingerByChannel_TraceChannel_PropertyAddress, GetHitResultUnderFingerByChannel_FunctionAddress, "TraceChannel");
		GetHitResultUnderFingerByChannel_TraceChannel_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderFingerByChannel_FunctionAddress, "TraceChannel");
		GetHitResultUnderFingerByChannel_TraceChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderFingerByChannel_FunctionAddress, "TraceChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderFingerByChannel_bTraceComplex_PropertyAddress, GetHitResultUnderFingerByChannel_FunctionAddress, "bTraceComplex");
		GetHitResultUnderFingerByChannel_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderFingerByChannel_FunctionAddress, "bTraceComplex");
		GetHitResultUnderFingerByChannel_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderFingerByChannel_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderFingerByChannel_HitResult_PropertyAddress, GetHitResultUnderFingerByChannel_FunctionAddress, "HitResult");
		GetHitResultUnderFingerByChannel_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderFingerByChannel_FunctionAddress, "HitResult");
		GetHitResultUnderFingerByChannel_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderFingerByChannel_FunctionAddress, "HitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderFingerByChannel_ReturnValue_PropertyAddress, GetHitResultUnderFingerByChannel_FunctionAddress, "ReturnValue");
		GetHitResultUnderFingerByChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderFingerByChannel_FunctionAddress, "ReturnValue");
		GetHitResultUnderFingerByChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderFingerByChannel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetHitResultUnderFingerByChannel_IsValid = GetHitResultUnderFingerByChannel_FunctionAddress != IntPtr.Zero && GetHitResultUnderFingerByChannel_FingerIndex_IsValid && GetHitResultUnderFingerByChannel_TraceChannel_IsValid && GetHitResultUnderFingerByChannel_bTraceComplex_IsValid && GetHitResultUnderFingerByChannel_HitResult_IsValid && GetHitResultUnderFingerByChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetHitResultUnderFingerByChannel", GetHitResultUnderFingerByChannel_IsValid);
		GetHitResultUnderCursorForObjects_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHitResultUnderCursorForObjects");
		GetHitResultUnderCursorForObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHitResultUnderCursorForObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderCursorForObjects_ObjectTypes_PropertyAddress, GetHitResultUnderCursorForObjects_FunctionAddress, "ObjectTypes");
		GetHitResultUnderCursorForObjects_ObjectTypes_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderCursorForObjects_FunctionAddress, "ObjectTypes");
		GetHitResultUnderCursorForObjects_ObjectTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderCursorForObjects_FunctionAddress, "ObjectTypes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderCursorForObjects_bTraceComplex_PropertyAddress, GetHitResultUnderCursorForObjects_FunctionAddress, "bTraceComplex");
		GetHitResultUnderCursorForObjects_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderCursorForObjects_FunctionAddress, "bTraceComplex");
		GetHitResultUnderCursorForObjects_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderCursorForObjects_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderCursorForObjects_HitResult_PropertyAddress, GetHitResultUnderCursorForObjects_FunctionAddress, "HitResult");
		GetHitResultUnderCursorForObjects_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderCursorForObjects_FunctionAddress, "HitResult");
		GetHitResultUnderCursorForObjects_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderCursorForObjects_FunctionAddress, "HitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderCursorForObjects_ReturnValue_PropertyAddress, GetHitResultUnderCursorForObjects_FunctionAddress, "ReturnValue");
		GetHitResultUnderCursorForObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderCursorForObjects_FunctionAddress, "ReturnValue");
		GetHitResultUnderCursorForObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderCursorForObjects_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetHitResultUnderCursorForObjects_IsValid = GetHitResultUnderCursorForObjects_FunctionAddress != IntPtr.Zero && GetHitResultUnderCursorForObjects_ObjectTypes_IsValid && GetHitResultUnderCursorForObjects_bTraceComplex_IsValid && GetHitResultUnderCursorForObjects_HitResult_IsValid && GetHitResultUnderCursorForObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetHitResultUnderCursorForObjects", GetHitResultUnderCursorForObjects_IsValid);
		GetHitResultUnderCursorByChannel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHitResultUnderCursorByChannel");
		GetHitResultUnderCursorByChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHitResultUnderCursorByChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderCursorByChannel_TraceChannel_PropertyAddress, GetHitResultUnderCursorByChannel_FunctionAddress, "TraceChannel");
		GetHitResultUnderCursorByChannel_TraceChannel_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderCursorByChannel_FunctionAddress, "TraceChannel");
		GetHitResultUnderCursorByChannel_TraceChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderCursorByChannel_FunctionAddress, "TraceChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderCursorByChannel_bTraceComplex_PropertyAddress, GetHitResultUnderCursorByChannel_FunctionAddress, "bTraceComplex");
		GetHitResultUnderCursorByChannel_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderCursorByChannel_FunctionAddress, "bTraceComplex");
		GetHitResultUnderCursorByChannel_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderCursorByChannel_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderCursorByChannel_HitResult_PropertyAddress, GetHitResultUnderCursorByChannel_FunctionAddress, "HitResult");
		GetHitResultUnderCursorByChannel_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderCursorByChannel_FunctionAddress, "HitResult");
		GetHitResultUnderCursorByChannel_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderCursorByChannel_FunctionAddress, "HitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHitResultUnderCursorByChannel_ReturnValue_PropertyAddress, GetHitResultUnderCursorByChannel_FunctionAddress, "ReturnValue");
		GetHitResultUnderCursorByChannel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHitResultUnderCursorByChannel_FunctionAddress, "ReturnValue");
		GetHitResultUnderCursorByChannel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHitResultUnderCursorByChannel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetHitResultUnderCursorByChannel_IsValid = GetHitResultUnderCursorByChannel_FunctionAddress != IntPtr.Zero && GetHitResultUnderCursorByChannel_TraceChannel_IsValid && GetHitResultUnderCursorByChannel_bTraceComplex_IsValid && GetHitResultUnderCursorByChannel_HitResult_IsValid && GetHitResultUnderCursorByChannel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetHitResultUnderCursorByChannel", GetHitResultUnderCursorByChannel_IsValid);
		GetFocalLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFocalLocation");
		GetFocalLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFocalLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFocalLocation_ReturnValue_PropertyAddress, GetFocalLocation_FunctionAddress, "ReturnValue");
		GetFocalLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFocalLocation_FunctionAddress, "ReturnValue");
		GetFocalLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFocalLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetFocalLocation_IsValid = GetFocalLocation_FunctionAddress != IntPtr.Zero && GetFocalLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetFocalLocation", GetFocalLocation_IsValid);
		GetDeprecatedInputYawScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDeprecatedInputYawScale");
		GetDeprecatedInputYawScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDeprecatedInputYawScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDeprecatedInputYawScale_ReturnValue_PropertyAddress, GetDeprecatedInputYawScale_FunctionAddress, "ReturnValue");
		GetDeprecatedInputYawScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDeprecatedInputYawScale_FunctionAddress, "ReturnValue");
		GetDeprecatedInputYawScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDeprecatedInputYawScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDeprecatedInputYawScale_IsValid = GetDeprecatedInputYawScale_FunctionAddress != IntPtr.Zero && GetDeprecatedInputYawScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetDeprecatedInputYawScale", GetDeprecatedInputYawScale_IsValid);
		GetDeprecatedInputRollScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDeprecatedInputRollScale");
		GetDeprecatedInputRollScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDeprecatedInputRollScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDeprecatedInputRollScale_ReturnValue_PropertyAddress, GetDeprecatedInputRollScale_FunctionAddress, "ReturnValue");
		GetDeprecatedInputRollScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDeprecatedInputRollScale_FunctionAddress, "ReturnValue");
		GetDeprecatedInputRollScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDeprecatedInputRollScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDeprecatedInputRollScale_IsValid = GetDeprecatedInputRollScale_FunctionAddress != IntPtr.Zero && GetDeprecatedInputRollScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetDeprecatedInputRollScale", GetDeprecatedInputRollScale_IsValid);
		GetDeprecatedInputPitchScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDeprecatedInputPitchScale");
		GetDeprecatedInputPitchScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDeprecatedInputPitchScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDeprecatedInputPitchScale_ReturnValue_PropertyAddress, GetDeprecatedInputPitchScale_FunctionAddress, "ReturnValue");
		GetDeprecatedInputPitchScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDeprecatedInputPitchScale_FunctionAddress, "ReturnValue");
		GetDeprecatedInputPitchScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDeprecatedInputPitchScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDeprecatedInputPitchScale_IsValid = GetDeprecatedInputPitchScale_FunctionAddress != IntPtr.Zero && GetDeprecatedInputPitchScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:GetDeprecatedInputPitchScale", GetDeprecatedInputPitchScale_IsValid);
		DeprojectScreenPositionToWorld_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DeprojectScreenPositionToWorld");
		DeprojectScreenPositionToWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(DeprojectScreenPositionToWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeprojectScreenPositionToWorld_ScreenX_PropertyAddress, DeprojectScreenPositionToWorld_FunctionAddress, "ScreenX");
		DeprojectScreenPositionToWorld_ScreenX_Offset = NativeReflectionCached.GetPropertyOffset(DeprojectScreenPositionToWorld_FunctionAddress, "ScreenX");
		DeprojectScreenPositionToWorld_ScreenX_IsValid = NativeReflectionCached.ValidatePropertyClass(DeprojectScreenPositionToWorld_FunctionAddress, "ScreenX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DeprojectScreenPositionToWorld_ScreenY_PropertyAddress, DeprojectScreenPositionToWorld_FunctionAddress, "ScreenY");
		DeprojectScreenPositionToWorld_ScreenY_Offset = NativeReflectionCached.GetPropertyOffset(DeprojectScreenPositionToWorld_FunctionAddress, "ScreenY");
		DeprojectScreenPositionToWorld_ScreenY_IsValid = NativeReflectionCached.ValidatePropertyClass(DeprojectScreenPositionToWorld_FunctionAddress, "ScreenY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DeprojectScreenPositionToWorld_WorldLocation_PropertyAddress, DeprojectScreenPositionToWorld_FunctionAddress, "WorldLocation");
		DeprojectScreenPositionToWorld_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(DeprojectScreenPositionToWorld_FunctionAddress, "WorldLocation");
		DeprojectScreenPositionToWorld_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(DeprojectScreenPositionToWorld_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeprojectScreenPositionToWorld_WorldDirection_PropertyAddress, DeprojectScreenPositionToWorld_FunctionAddress, "WorldDirection");
		DeprojectScreenPositionToWorld_WorldDirection_Offset = NativeReflectionCached.GetPropertyOffset(DeprojectScreenPositionToWorld_FunctionAddress, "WorldDirection");
		DeprojectScreenPositionToWorld_WorldDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(DeprojectScreenPositionToWorld_FunctionAddress, "WorldDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeprojectScreenPositionToWorld_ReturnValue_PropertyAddress, DeprojectScreenPositionToWorld_FunctionAddress, "ReturnValue");
		DeprojectScreenPositionToWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeprojectScreenPositionToWorld_FunctionAddress, "ReturnValue");
		DeprojectScreenPositionToWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeprojectScreenPositionToWorld_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DeprojectScreenPositionToWorld_IsValid = DeprojectScreenPositionToWorld_FunctionAddress != IntPtr.Zero && DeprojectScreenPositionToWorld_ScreenX_IsValid && DeprojectScreenPositionToWorld_ScreenY_IsValid && DeprojectScreenPositionToWorld_WorldLocation_IsValid && DeprojectScreenPositionToWorld_WorldDirection_IsValid && DeprojectScreenPositionToWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:DeprojectScreenPositionToWorld", DeprojectScreenPositionToWorld_IsValid);
		DeprojectMousePositionToWorld_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DeprojectMousePositionToWorld");
		DeprojectMousePositionToWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(DeprojectMousePositionToWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeprojectMousePositionToWorld_WorldLocation_PropertyAddress, DeprojectMousePositionToWorld_FunctionAddress, "WorldLocation");
		DeprojectMousePositionToWorld_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(DeprojectMousePositionToWorld_FunctionAddress, "WorldLocation");
		DeprojectMousePositionToWorld_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(DeprojectMousePositionToWorld_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeprojectMousePositionToWorld_WorldDirection_PropertyAddress, DeprojectMousePositionToWorld_FunctionAddress, "WorldDirection");
		DeprojectMousePositionToWorld_WorldDirection_Offset = NativeReflectionCached.GetPropertyOffset(DeprojectMousePositionToWorld_FunctionAddress, "WorldDirection");
		DeprojectMousePositionToWorld_WorldDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(DeprojectMousePositionToWorld_FunctionAddress, "WorldDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeprojectMousePositionToWorld_ReturnValue_PropertyAddress, DeprojectMousePositionToWorld_FunctionAddress, "ReturnValue");
		DeprojectMousePositionToWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeprojectMousePositionToWorld_FunctionAddress, "ReturnValue");
		DeprojectMousePositionToWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeprojectMousePositionToWorld_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DeprojectMousePositionToWorld_IsValid = DeprojectMousePositionToWorld_FunctionAddress != IntPtr.Zero && DeprojectMousePositionToWorld_WorldLocation_IsValid && DeprojectMousePositionToWorld_WorldDirection_IsValid && DeprojectMousePositionToWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:DeprojectMousePositionToWorld", DeprojectMousePositionToWorld_IsValid);
		ClientStopForceFeedback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClientStopForceFeedback");
		ClientStopForceFeedback_ParamsSize = NativeReflection.GetFunctionParamsSize(ClientStopForceFeedback_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClientStopForceFeedback_ForceFeedbackEffect_PropertyAddress, ClientStopForceFeedback_FunctionAddress, "ForceFeedbackEffect");
		ClientStopForceFeedback_ForceFeedbackEffect_Offset = NativeReflectionCached.GetPropertyOffset(ClientStopForceFeedback_FunctionAddress, "ForceFeedbackEffect");
		ClientStopForceFeedback_ForceFeedbackEffect_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientStopForceFeedback_FunctionAddress, "ForceFeedbackEffect", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientStopForceFeedback_Tag_PropertyAddress, ClientStopForceFeedback_FunctionAddress, "Tag");
		ClientStopForceFeedback_Tag_Offset = NativeReflectionCached.GetPropertyOffset(ClientStopForceFeedback_FunctionAddress, "Tag");
		ClientStopForceFeedback_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientStopForceFeedback_FunctionAddress, "Tag", Classes.FNameProperty);
		ClientStopForceFeedback_IsValid = ClientStopForceFeedback_FunctionAddress != IntPtr.Zero && ClientStopForceFeedback_ForceFeedbackEffect_IsValid && ClientStopForceFeedback_Tag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:ClientStopForceFeedback", ClientStopForceFeedback_IsValid);
		ClientStopCameraShakesFromSource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClientStopCameraShakesFromSource");
		ClientStopCameraShakesFromSource_ParamsSize = NativeReflection.GetFunctionParamsSize(ClientStopCameraShakesFromSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClientStopCameraShakesFromSource_SourceComponent_PropertyAddress, ClientStopCameraShakesFromSource_FunctionAddress, "SourceComponent");
		ClientStopCameraShakesFromSource_SourceComponent_Offset = NativeReflectionCached.GetPropertyOffset(ClientStopCameraShakesFromSource_FunctionAddress, "SourceComponent");
		ClientStopCameraShakesFromSource_SourceComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientStopCameraShakesFromSource_FunctionAddress, "SourceComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientStopCameraShakesFromSource_bImmediately_PropertyAddress, ClientStopCameraShakesFromSource_FunctionAddress, "bImmediately");
		ClientStopCameraShakesFromSource_bImmediately_Offset = NativeReflectionCached.GetPropertyOffset(ClientStopCameraShakesFromSource_FunctionAddress, "bImmediately");
		ClientStopCameraShakesFromSource_bImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientStopCameraShakesFromSource_FunctionAddress, "bImmediately", Classes.FBoolProperty);
		ClientStopCameraShakesFromSource_IsValid = ClientStopCameraShakesFromSource_FunctionAddress != IntPtr.Zero && ClientStopCameraShakesFromSource_SourceComponent_IsValid && ClientStopCameraShakesFromSource_bImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:ClientStopCameraShakesFromSource", ClientStopCameraShakesFromSource_IsValid);
		ClientStopCameraShake_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClientStopCameraShake");
		ClientStopCameraShake_ParamsSize = NativeReflection.GetFunctionParamsSize(ClientStopCameraShake_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClientStopCameraShake_Shake_PropertyAddress, ClientStopCameraShake_FunctionAddress, "Shake");
		ClientStopCameraShake_Shake_Offset = NativeReflectionCached.GetPropertyOffset(ClientStopCameraShake_FunctionAddress, "Shake");
		ClientStopCameraShake_Shake_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientStopCameraShake_FunctionAddress, "Shake", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientStopCameraShake_bImmediately_PropertyAddress, ClientStopCameraShake_FunctionAddress, "bImmediately");
		ClientStopCameraShake_bImmediately_Offset = NativeReflectionCached.GetPropertyOffset(ClientStopCameraShake_FunctionAddress, "bImmediately");
		ClientStopCameraShake_bImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientStopCameraShake_FunctionAddress, "bImmediately", Classes.FBoolProperty);
		ClientStopCameraShake_IsValid = ClientStopCameraShake_FunctionAddress != IntPtr.Zero && ClientStopCameraShake_Shake_IsValid && ClientStopCameraShake_bImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:ClientStopCameraShake", ClientStopCameraShake_IsValid);
		ClientStartCameraShakeFromSource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClientStartCameraShakeFromSource");
		ClientStartCameraShakeFromSource_ParamsSize = NativeReflection.GetFunctionParamsSize(ClientStartCameraShakeFromSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClientStartCameraShakeFromSource_Shake_PropertyAddress, ClientStartCameraShakeFromSource_FunctionAddress, "Shake");
		ClientStartCameraShakeFromSource_Shake_Offset = NativeReflectionCached.GetPropertyOffset(ClientStartCameraShakeFromSource_FunctionAddress, "Shake");
		ClientStartCameraShakeFromSource_Shake_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientStartCameraShakeFromSource_FunctionAddress, "Shake", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientStartCameraShakeFromSource_SourceComponent_PropertyAddress, ClientStartCameraShakeFromSource_FunctionAddress, "SourceComponent");
		ClientStartCameraShakeFromSource_SourceComponent_Offset = NativeReflectionCached.GetPropertyOffset(ClientStartCameraShakeFromSource_FunctionAddress, "SourceComponent");
		ClientStartCameraShakeFromSource_SourceComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientStartCameraShakeFromSource_FunctionAddress, "SourceComponent", Classes.FObjectProperty);
		ClientStartCameraShakeFromSource_IsValid = ClientStartCameraShakeFromSource_FunctionAddress != IntPtr.Zero && ClientStartCameraShakeFromSource_Shake_IsValid && ClientStartCameraShakeFromSource_SourceComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:ClientStartCameraShakeFromSource", ClientStartCameraShakeFromSource_IsValid);
		ClientStartCameraShake_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClientStartCameraShake");
		ClientStartCameraShake_ParamsSize = NativeReflection.GetFunctionParamsSize(ClientStartCameraShake_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClientStartCameraShake_Shake_PropertyAddress, ClientStartCameraShake_FunctionAddress, "Shake");
		ClientStartCameraShake_Shake_Offset = NativeReflectionCached.GetPropertyOffset(ClientStartCameraShake_FunctionAddress, "Shake");
		ClientStartCameraShake_Shake_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientStartCameraShake_FunctionAddress, "Shake", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientStartCameraShake_Scale_PropertyAddress, ClientStartCameraShake_FunctionAddress, "Scale");
		ClientStartCameraShake_Scale_Offset = NativeReflectionCached.GetPropertyOffset(ClientStartCameraShake_FunctionAddress, "Scale");
		ClientStartCameraShake_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientStartCameraShake_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientStartCameraShake_PlaySpace_PropertyAddress, ClientStartCameraShake_FunctionAddress, "PlaySpace");
		ClientStartCameraShake_PlaySpace_Offset = NativeReflectionCached.GetPropertyOffset(ClientStartCameraShake_FunctionAddress, "PlaySpace");
		ClientStartCameraShake_PlaySpace_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientStartCameraShake_FunctionAddress, "PlaySpace", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientStartCameraShake_UserPlaySpaceRot_PropertyAddress, ClientStartCameraShake_FunctionAddress, "UserPlaySpaceRot");
		ClientStartCameraShake_UserPlaySpaceRot_Offset = NativeReflectionCached.GetPropertyOffset(ClientStartCameraShake_FunctionAddress, "UserPlaySpaceRot");
		ClientStartCameraShake_UserPlaySpaceRot_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientStartCameraShake_FunctionAddress, "UserPlaySpaceRot", Classes.FStructProperty);
		ClientStartCameraShake_IsValid = ClientStartCameraShake_FunctionAddress != IntPtr.Zero && ClientStartCameraShake_Shake_IsValid && ClientStartCameraShake_Scale_IsValid && ClientStartCameraShake_PlaySpace_IsValid && ClientStartCameraShake_UserPlaySpaceRot_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:ClientStartCameraShake", ClientStartCameraShake_IsValid);
		ClientSpawnGenericCameraLensEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClientSpawnGenericCameraLensEffect");
		ClientSpawnGenericCameraLensEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(ClientSpawnGenericCameraLensEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClientSpawnGenericCameraLensEffect_LensEffectEmitterClass_PropertyAddress, ClientSpawnGenericCameraLensEffect_FunctionAddress, "LensEffectEmitterClass");
		ClientSpawnGenericCameraLensEffect_LensEffectEmitterClass_Offset = NativeReflectionCached.GetPropertyOffset(ClientSpawnGenericCameraLensEffect_FunctionAddress, "LensEffectEmitterClass");
		ClientSpawnGenericCameraLensEffect_LensEffectEmitterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientSpawnGenericCameraLensEffect_FunctionAddress, "LensEffectEmitterClass", Classes.FClassProperty);
		ClientSpawnGenericCameraLensEffect_IsValid = ClientSpawnGenericCameraLensEffect_FunctionAddress != IntPtr.Zero && ClientSpawnGenericCameraLensEffect_LensEffectEmitterClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:ClientSpawnGenericCameraLensEffect", ClientSpawnGenericCameraLensEffect_IsValid);
		ClientSetHUD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClientSetHUD");
		ClientSetHUD_ParamsSize = NativeReflection.GetFunctionParamsSize(ClientSetHUD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClientSetHUD_NewHUDClass_PropertyAddress, ClientSetHUD_FunctionAddress, "NewHUDClass");
		ClientSetHUD_NewHUDClass_Offset = NativeReflectionCached.GetPropertyOffset(ClientSetHUD_FunctionAddress, "NewHUDClass");
		ClientSetHUD_NewHUDClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientSetHUD_FunctionAddress, "NewHUDClass", Classes.FClassProperty);
		ClientSetHUD_IsValid = ClientSetHUD_FunctionAddress != IntPtr.Zero && ClientSetHUD_NewHUDClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:ClientSetHUD", ClientSetHUD_IsValid);
		ClientPlayCameraAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClientPlayCameraAnim");
		ClientPlayCameraAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(ClientPlayCameraAnim_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClientPlayCameraAnim_AnimToPlay_PropertyAddress, ClientPlayCameraAnim_FunctionAddress, "AnimToPlay");
		ClientPlayCameraAnim_AnimToPlay_Offset = NativeReflectionCached.GetPropertyOffset(ClientPlayCameraAnim_FunctionAddress, "AnimToPlay");
		ClientPlayCameraAnim_AnimToPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientPlayCameraAnim_FunctionAddress, "AnimToPlay", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientPlayCameraAnim_Scale_PropertyAddress, ClientPlayCameraAnim_FunctionAddress, "Scale");
		ClientPlayCameraAnim_Scale_Offset = NativeReflectionCached.GetPropertyOffset(ClientPlayCameraAnim_FunctionAddress, "Scale");
		ClientPlayCameraAnim_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientPlayCameraAnim_FunctionAddress, "Scale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientPlayCameraAnim_Rate_PropertyAddress, ClientPlayCameraAnim_FunctionAddress, "Rate");
		ClientPlayCameraAnim_Rate_Offset = NativeReflectionCached.GetPropertyOffset(ClientPlayCameraAnim_FunctionAddress, "Rate");
		ClientPlayCameraAnim_Rate_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientPlayCameraAnim_FunctionAddress, "Rate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientPlayCameraAnim_BlendInTime_PropertyAddress, ClientPlayCameraAnim_FunctionAddress, "BlendInTime");
		ClientPlayCameraAnim_BlendInTime_Offset = NativeReflectionCached.GetPropertyOffset(ClientPlayCameraAnim_FunctionAddress, "BlendInTime");
		ClientPlayCameraAnim_BlendInTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientPlayCameraAnim_FunctionAddress, "BlendInTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientPlayCameraAnim_BlendOutTime_PropertyAddress, ClientPlayCameraAnim_FunctionAddress, "BlendOutTime");
		ClientPlayCameraAnim_BlendOutTime_Offset = NativeReflectionCached.GetPropertyOffset(ClientPlayCameraAnim_FunctionAddress, "BlendOutTime");
		ClientPlayCameraAnim_BlendOutTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientPlayCameraAnim_FunctionAddress, "BlendOutTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientPlayCameraAnim_bLoop_PropertyAddress, ClientPlayCameraAnim_FunctionAddress, "bLoop");
		ClientPlayCameraAnim_bLoop_Offset = NativeReflectionCached.GetPropertyOffset(ClientPlayCameraAnim_FunctionAddress, "bLoop");
		ClientPlayCameraAnim_bLoop_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientPlayCameraAnim_FunctionAddress, "bLoop", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientPlayCameraAnim_bRandomStartTime_PropertyAddress, ClientPlayCameraAnim_FunctionAddress, "bRandomStartTime");
		ClientPlayCameraAnim_bRandomStartTime_Offset = NativeReflectionCached.GetPropertyOffset(ClientPlayCameraAnim_FunctionAddress, "bRandomStartTime");
		ClientPlayCameraAnim_bRandomStartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientPlayCameraAnim_FunctionAddress, "bRandomStartTime", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientPlayCameraAnim_Space_PropertyAddress, ClientPlayCameraAnim_FunctionAddress, "Space");
		ClientPlayCameraAnim_Space_Offset = NativeReflectionCached.GetPropertyOffset(ClientPlayCameraAnim_FunctionAddress, "Space");
		ClientPlayCameraAnim_Space_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientPlayCameraAnim_FunctionAddress, "Space", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ClientPlayCameraAnim_CustomPlaySpace_PropertyAddress, ClientPlayCameraAnim_FunctionAddress, "CustomPlaySpace");
		ClientPlayCameraAnim_CustomPlaySpace_Offset = NativeReflectionCached.GetPropertyOffset(ClientPlayCameraAnim_FunctionAddress, "CustomPlaySpace");
		ClientPlayCameraAnim_CustomPlaySpace_IsValid = NativeReflectionCached.ValidatePropertyClass(ClientPlayCameraAnim_FunctionAddress, "CustomPlaySpace", Classes.FStructProperty);
		ClientPlayCameraAnim_IsValid = ClientPlayCameraAnim_FunctionAddress != IntPtr.Zero && ClientPlayCameraAnim_AnimToPlay_IsValid && ClientPlayCameraAnim_Scale_IsValid && ClientPlayCameraAnim_Rate_IsValid && ClientPlayCameraAnim_BlendInTime_IsValid && ClientPlayCameraAnim_BlendOutTime_IsValid && ClientPlayCameraAnim_bLoop_IsValid && ClientPlayCameraAnim_bRandomStartTime_IsValid && ClientPlayCameraAnim_Space_IsValid && ClientPlayCameraAnim_CustomPlaySpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:ClientPlayCameraAnim", ClientPlayCameraAnim_IsValid);
		ClientClearCameraLensEffects_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClientClearCameraLensEffects");
		ClientClearCameraLensEffects_ParamsSize = NativeReflection.GetFunctionParamsSize(ClientClearCameraLensEffects_FunctionAddress);
		ClientClearCameraLensEffects_IsValid = ClientClearCameraLensEffects_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:ClientClearCameraLensEffects", ClientClearCameraLensEffects_IsValid);
		ClearAudioListenerOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearAudioListenerOverride");
		ClearAudioListenerOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAudioListenerOverride_FunctionAddress);
		ClearAudioListenerOverride_IsValid = ClearAudioListenerOverride_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:ClearAudioListenerOverride", ClearAudioListenerOverride_IsValid);
		ClearAudioListenerAttenuationOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearAudioListenerAttenuationOverride");
		ClearAudioListenerAttenuationOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAudioListenerAttenuationOverride_FunctionAddress);
		ClearAudioListenerAttenuationOverride_IsValid = ClearAudioListenerAttenuationOverride_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:ClearAudioListenerAttenuationOverride", ClearAudioListenerAttenuationOverride_IsValid);
		CanRestartPlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanRestartPlayer");
		CanRestartPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(CanRestartPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanRestartPlayer_ReturnValue_PropertyAddress, CanRestartPlayer_FunctionAddress, "ReturnValue");
		CanRestartPlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanRestartPlayer_FunctionAddress, "ReturnValue");
		CanRestartPlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanRestartPlayer_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanRestartPlayer_IsValid = CanRestartPlayer_FunctionAddress != IntPtr.Zero && CanRestartPlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:CanRestartPlayer", CanRestartPlayer_IsValid);
		AddYawInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddYawInput");
		AddYawInput_ParamsSize = NativeReflection.GetFunctionParamsSize(AddYawInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddYawInput_Val_PropertyAddress, AddYawInput_FunctionAddress, "Val");
		AddYawInput_Val_Offset = NativeReflectionCached.GetPropertyOffset(AddYawInput_FunctionAddress, "Val");
		AddYawInput_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(AddYawInput_FunctionAddress, "Val", Classes.FFloatProperty);
		AddYawInput_IsValid = AddYawInput_FunctionAddress != IntPtr.Zero && AddYawInput_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:AddYawInput", AddYawInput_IsValid);
		AddRollInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddRollInput");
		AddRollInput_ParamsSize = NativeReflection.GetFunctionParamsSize(AddRollInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddRollInput_Val_PropertyAddress, AddRollInput_FunctionAddress, "Val");
		AddRollInput_Val_Offset = NativeReflectionCached.GetPropertyOffset(AddRollInput_FunctionAddress, "Val");
		AddRollInput_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRollInput_FunctionAddress, "Val", Classes.FFloatProperty);
		AddRollInput_IsValid = AddRollInput_FunctionAddress != IntPtr.Zero && AddRollInput_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:AddRollInput", AddRollInput_IsValid);
		AddPitchInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddPitchInput");
		AddPitchInput_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPitchInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddPitchInput_Val_PropertyAddress, AddPitchInput_FunctionAddress, "Val");
		AddPitchInput_Val_Offset = NativeReflectionCached.GetPropertyOffset(AddPitchInput_FunctionAddress, "Val");
		AddPitchInput_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPitchInput_FunctionAddress, "Val", Classes.FFloatProperty);
		AddPitchInput_IsValid = AddPitchInput_FunctionAddress != IntPtr.Zero && AddPitchInput_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:AddPitchInput", AddPitchInput_IsValid);
		ActivateTouchInterface_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ActivateTouchInterface");
		ActivateTouchInterface_ParamsSize = NativeReflection.GetFunctionParamsSize(ActivateTouchInterface_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActivateTouchInterface_NewTouchInterface_PropertyAddress, ActivateTouchInterface_FunctionAddress, "NewTouchInterface");
		ActivateTouchInterface_NewTouchInterface_Offset = NativeReflectionCached.GetPropertyOffset(ActivateTouchInterface_FunctionAddress, "NewTouchInterface");
		ActivateTouchInterface_NewTouchInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(ActivateTouchInterface_FunctionAddress, "NewTouchInterface", Classes.FObjectProperty);
		ActivateTouchInterface_IsValid = ActivateTouchInterface_FunctionAddress != IntPtr.Zero && ActivateTouchInterface_NewTouchInterface_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlayerController:ActivateTouchInterface", ActivateTouchInterface_IsValid);
	}
}
