using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[Abstract]
[UClass(Flags = (ClassFlags)821039265uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.UserWidget", "UMG", UnrealModuleType.Engine)]
public class UUserWidget : UWidget, INamedSlotInterface, IInterface
{
	private static bool ColorAndOpacity_IsValid;

	private static int ColorAndOpacity_Offset;

	private static bool ForegroundColor_IsValid;

	private static int ForegroundColor_Offset;

	private static bool OnVisibilityChanged_IsValid;

	private static int OnVisibilityChanged_Offset;

	private FOnVisibilityChangedEvent OnVisibilityChanged_DelegateCached;

	private static bool Padding_IsValid;

	private static int Padding_Offset;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool IsFocusable_IsValid;

	private static FFieldAddress IsFocusable_PropertyAddress;

	private static int IsFocusable_Offset;

	private static bool StopAction_IsValid;

	private static FFieldAddress StopAction_PropertyAddress;

	private static int StopAction_Offset;

	private static bool TickFrequency_IsValid;

	private static FFieldAddress TickFrequency_PropertyAddress;

	private static int TickFrequency_Offset;

	private static bool UnregisterInputComponent_IsValid;

	private static IntPtr UnregisterInputComponent_FunctionAddress;

	private static int UnregisterInputComponent_ParamsSize;

	private static bool UnbindFromAnimationStarted_IsValid;

	private static IntPtr UnbindFromAnimationStarted_FunctionAddress;

	private static int UnbindFromAnimationStarted_ParamsSize;

	private static bool UnbindFromAnimationStarted_Animation_IsValid;

	private static FFieldAddress UnbindFromAnimationStarted_Animation_PropertyAddress;

	private static int UnbindFromAnimationStarted_Animation_Offset;

	private static bool UnbindFromAnimationStarted_Delegate_IsValid;

	private static FFieldAddress UnbindFromAnimationStarted_Delegate_PropertyAddress;

	private static int UnbindFromAnimationStarted_Delegate_Offset;

	private static bool UnbindFromAnimationFinished_IsValid;

	private static IntPtr UnbindFromAnimationFinished_FunctionAddress;

	private static int UnbindFromAnimationFinished_ParamsSize;

	private static bool UnbindFromAnimationFinished_Animation_IsValid;

	private static FFieldAddress UnbindFromAnimationFinished_Animation_PropertyAddress;

	private static int UnbindFromAnimationFinished_Animation_Offset;

	private static bool UnbindFromAnimationFinished_Delegate_IsValid;

	private static FFieldAddress UnbindFromAnimationFinished_Delegate_PropertyAddress;

	private static int UnbindFromAnimationFinished_Delegate_Offset;

	private static bool UnbindAllFromAnimationStarted_IsValid;

	private static IntPtr UnbindAllFromAnimationStarted_FunctionAddress;

	private static int UnbindAllFromAnimationStarted_ParamsSize;

	private static bool UnbindAllFromAnimationStarted_Animation_IsValid;

	private static FFieldAddress UnbindAllFromAnimationStarted_Animation_PropertyAddress;

	private static int UnbindAllFromAnimationStarted_Animation_Offset;

	private static bool UnbindAllFromAnimationFinished_IsValid;

	private static IntPtr UnbindAllFromAnimationFinished_FunctionAddress;

	private static int UnbindAllFromAnimationFinished_ParamsSize;

	private static bool UnbindAllFromAnimationFinished_Animation_IsValid;

	private static FFieldAddress UnbindAllFromAnimationFinished_Animation_PropertyAddress;

	private static int UnbindAllFromAnimationFinished_Animation_Offset;

	private static bool Tick_IsValid;

	private IntPtr Tick_InstanceFunctionAddress;

	private static IntPtr Tick_FunctionAddress;

	private static int Tick_ParamsSize;

	private static bool Tick_MyGeometry_IsValid;

	private static FFieldAddress Tick_MyGeometry_PropertyAddress;

	private static int Tick_MyGeometry_Offset;

	private static bool Tick_InDeltaTime_IsValid;

	private static FFieldAddress Tick_InDeltaTime_PropertyAddress;

	private static int Tick_InDeltaTime_Offset;

	private static bool StopListeningForInputAction_IsValid;

	private static IntPtr StopListeningForInputAction_FunctionAddress;

	private static int StopListeningForInputAction_ParamsSize;

	private static bool StopListeningForInputAction_ActionName_IsValid;

	private static FFieldAddress StopListeningForInputAction_ActionName_PropertyAddress;

	private static int StopListeningForInputAction_ActionName_Offset;

	private static bool StopListeningForInputAction_EventType_IsValid;

	private static FFieldAddress StopListeningForInputAction_EventType_PropertyAddress;

	private static int StopListeningForInputAction_EventType_Offset;

	private static bool StopListeningForAllInputActions_IsValid;

	private static IntPtr StopListeningForAllInputActions_FunctionAddress;

	private static int StopListeningForAllInputActions_ParamsSize;

	private static bool StopAnimationsAndLatentActions_IsValid;

	private static IntPtr StopAnimationsAndLatentActions_FunctionAddress;

	private static int StopAnimationsAndLatentActions_ParamsSize;

	private static bool StopAnimation_IsValid;

	private static IntPtr StopAnimation_FunctionAddress;

	private static int StopAnimation_ParamsSize;

	private static bool StopAnimation_InAnimation_IsValid;

	private static FFieldAddress StopAnimation_InAnimation_PropertyAddress;

	private static int StopAnimation_InAnimation_Offset;

	private static bool StopAllAnimations_IsValid;

	private static IntPtr StopAllAnimations_FunctionAddress;

	private static int StopAllAnimations_ParamsSize;

	private static bool SetPositionInViewport_IsValid;

	private static IntPtr SetPositionInViewport_FunctionAddress;

	private static int SetPositionInViewport_ParamsSize;

	private static bool SetPositionInViewport_Position_IsValid;

	private static FFieldAddress SetPositionInViewport_Position_PropertyAddress;

	private static int SetPositionInViewport_Position_Offset;

	private static bool SetPositionInViewport_bRemoveDPIScale_IsValid;

	private static FFieldAddress SetPositionInViewport_bRemoveDPIScale_PropertyAddress;

	private static int SetPositionInViewport_bRemoveDPIScale_Offset;

	private static bool SetPlaybackSpeed_IsValid;

	private static IntPtr SetPlaybackSpeed_FunctionAddress;

	private static int SetPlaybackSpeed_ParamsSize;

	private static bool SetPlaybackSpeed_InAnimation_IsValid;

	private static FFieldAddress SetPlaybackSpeed_InAnimation_PropertyAddress;

	private static int SetPlaybackSpeed_InAnimation_Offset;

	private static bool SetPlaybackSpeed_PlaybackSpeed_IsValid;

	private static FFieldAddress SetPlaybackSpeed_PlaybackSpeed_PropertyAddress;

	private static int SetPlaybackSpeed_PlaybackSpeed_Offset;

	private static bool SetPadding_IsValid;

	private static IntPtr SetPadding_FunctionAddress;

	private static int SetPadding_ParamsSize;

	private static bool SetPadding_InPadding_IsValid;

	private static FFieldAddress SetPadding_InPadding_PropertyAddress;

	private static int SetPadding_InPadding_Offset;

	private static bool SetOwningPlayer_IsValid;

	private static IntPtr SetOwningPlayer_FunctionAddress;

	private static int SetOwningPlayer_ParamsSize;

	private static bool SetOwningPlayer_LocalPlayerController_IsValid;

	private static FFieldAddress SetOwningPlayer_LocalPlayerController_PropertyAddress;

	private static int SetOwningPlayer_LocalPlayerController_Offset;

	private static bool SetNumLoopsToPlay_IsValid;

	private static IntPtr SetNumLoopsToPlay_FunctionAddress;

	private static int SetNumLoopsToPlay_ParamsSize;

	private static bool SetNumLoopsToPlay_InAnimation_IsValid;

	private static FFieldAddress SetNumLoopsToPlay_InAnimation_PropertyAddress;

	private static int SetNumLoopsToPlay_InAnimation_Offset;

	private static bool SetNumLoopsToPlay_NumLoopsToPlay_IsValid;

	private static FFieldAddress SetNumLoopsToPlay_NumLoopsToPlay_PropertyAddress;

	private static int SetNumLoopsToPlay_NumLoopsToPlay_Offset;

	private static bool SetInputActionPriority_IsValid;

	private static IntPtr SetInputActionPriority_FunctionAddress;

	private static int SetInputActionPriority_ParamsSize;

	private static bool SetInputActionPriority_NewPriority_IsValid;

	private static FFieldAddress SetInputActionPriority_NewPriority_PropertyAddress;

	private static int SetInputActionPriority_NewPriority_Offset;

	private static bool SetInputActionBlocking_IsValid;

	private static IntPtr SetInputActionBlocking_FunctionAddress;

	private static int SetInputActionBlocking_ParamsSize;

	private static bool SetInputActionBlocking_bShouldBlock_IsValid;

	private static FFieldAddress SetInputActionBlocking_bShouldBlock_PropertyAddress;

	private static int SetInputActionBlocking_bShouldBlock_Offset;

	private static bool SetForegroundColor_IsValid;

	private static IntPtr SetForegroundColor_FunctionAddress;

	private static int SetForegroundColor_ParamsSize;

	private static bool SetForegroundColor_InForegroundColor_IsValid;

	private static FFieldAddress SetForegroundColor_InForegroundColor_PropertyAddress;

	private static int SetForegroundColor_InForegroundColor_Offset;

	private static bool SetDesiredSizeInViewport_IsValid;

	private static IntPtr SetDesiredSizeInViewport_FunctionAddress;

	private static int SetDesiredSizeInViewport_ParamsSize;

	private static bool SetDesiredSizeInViewport_Size_IsValid;

	private static FFieldAddress SetDesiredSizeInViewport_Size_PropertyAddress;

	private static int SetDesiredSizeInViewport_Size_Offset;

	private static bool SetColorAndOpacity_IsValid;

	private static IntPtr SetColorAndOpacity_FunctionAddress;

	private static int SetColorAndOpacity_ParamsSize;

	private static bool SetColorAndOpacity_InColorAndOpacity_IsValid;

	private static FFieldAddress SetColorAndOpacity_InColorAndOpacity_PropertyAddress;

	private static int SetColorAndOpacity_InColorAndOpacity_Offset;

	private static bool SetAnimationCurrentTime_IsValid;

	private static IntPtr SetAnimationCurrentTime_FunctionAddress;

	private static int SetAnimationCurrentTime_ParamsSize;

	private static bool SetAnimationCurrentTime_InAnimation_IsValid;

	private static FFieldAddress SetAnimationCurrentTime_InAnimation_PropertyAddress;

	private static int SetAnimationCurrentTime_InAnimation_Offset;

	private static bool SetAnimationCurrentTime_InTime_IsValid;

	private static FFieldAddress SetAnimationCurrentTime_InTime_PropertyAddress;

	private static int SetAnimationCurrentTime_InTime_Offset;

	private static bool SetAnchorsInViewport_IsValid;

	private static IntPtr SetAnchorsInViewport_FunctionAddress;

	private static int SetAnchorsInViewport_ParamsSize;

	private static bool SetAnchorsInViewport_Anchors_IsValid;

	private static FFieldAddress SetAnchorsInViewport_Anchors_PropertyAddress;

	private static int SetAnchorsInViewport_Anchors_Offset;

	private static bool SetAlignmentInViewport_IsValid;

	private static IntPtr SetAlignmentInViewport_FunctionAddress;

	private static int SetAlignmentInViewport_ParamsSize;

	private static bool SetAlignmentInViewport_Alignment_IsValid;

	private static FFieldAddress SetAlignmentInViewport_Alignment_PropertyAddress;

	private static int SetAlignmentInViewport_Alignment_Offset;

	private static bool ReverseAnimation_IsValid;

	private static IntPtr ReverseAnimation_FunctionAddress;

	private static int ReverseAnimation_ParamsSize;

	private static bool ReverseAnimation_InAnimation_IsValid;

	private static FFieldAddress ReverseAnimation_InAnimation_PropertyAddress;

	private static int ReverseAnimation_InAnimation_Offset;

	private static bool RegisterInputComponent_IsValid;

	private static IntPtr RegisterInputComponent_FunctionAddress;

	private static int RegisterInputComponent_ParamsSize;

	private static bool PreConstruct_IsValid;

	private IntPtr PreConstruct_InstanceFunctionAddress;

	private static IntPtr PreConstruct_FunctionAddress;

	private static int PreConstruct_ParamsSize;

	private static bool PreConstruct_IsDesignTime_IsValid;

	private static FFieldAddress PreConstruct_IsDesignTime_PropertyAddress;

	private static int PreConstruct_IsDesignTime_Offset;

	private static bool PlayAnimationTimeRange_IsValid;

	private static IntPtr PlayAnimationTimeRange_FunctionAddress;

	private static int PlayAnimationTimeRange_ParamsSize;

	private static bool PlayAnimationTimeRange_InAnimation_IsValid;

	private static FFieldAddress PlayAnimationTimeRange_InAnimation_PropertyAddress;

	private static int PlayAnimationTimeRange_InAnimation_Offset;

	private static bool PlayAnimationTimeRange_StartAtTime_IsValid;

	private static FFieldAddress PlayAnimationTimeRange_StartAtTime_PropertyAddress;

	private static int PlayAnimationTimeRange_StartAtTime_Offset;

	private static bool PlayAnimationTimeRange_EndAtTime_IsValid;

	private static FFieldAddress PlayAnimationTimeRange_EndAtTime_PropertyAddress;

	private static int PlayAnimationTimeRange_EndAtTime_Offset;

	private static bool PlayAnimationTimeRange_NumLoopsToPlay_IsValid;

	private static FFieldAddress PlayAnimationTimeRange_NumLoopsToPlay_PropertyAddress;

	private static int PlayAnimationTimeRange_NumLoopsToPlay_Offset;

	private static bool PlayAnimationTimeRange_PlayMode_IsValid;

	private static FFieldAddress PlayAnimationTimeRange_PlayMode_PropertyAddress;

	private static int PlayAnimationTimeRange_PlayMode_Offset;

	private static bool PlayAnimationTimeRange_PlaybackSpeed_IsValid;

	private static FFieldAddress PlayAnimationTimeRange_PlaybackSpeed_PropertyAddress;

	private static int PlayAnimationTimeRange_PlaybackSpeed_Offset;

	private static bool PlayAnimationTimeRange_bRestoreState_IsValid;

	private static FFieldAddress PlayAnimationTimeRange_bRestoreState_PropertyAddress;

	private static int PlayAnimationTimeRange_bRestoreState_Offset;

	private static bool PlayAnimationTimeRange_ReturnValue_IsValid;

	private static FFieldAddress PlayAnimationTimeRange_ReturnValue_PropertyAddress;

	private static int PlayAnimationTimeRange_ReturnValue_Offset;

	private static bool PlayAnimationReverse_IsValid;

	private static IntPtr PlayAnimationReverse_FunctionAddress;

	private static int PlayAnimationReverse_ParamsSize;

	private static bool PlayAnimationReverse_InAnimation_IsValid;

	private static FFieldAddress PlayAnimationReverse_InAnimation_PropertyAddress;

	private static int PlayAnimationReverse_InAnimation_Offset;

	private static bool PlayAnimationReverse_PlaybackSpeed_IsValid;

	private static FFieldAddress PlayAnimationReverse_PlaybackSpeed_PropertyAddress;

	private static int PlayAnimationReverse_PlaybackSpeed_Offset;

	private static bool PlayAnimationReverse_bRestoreState_IsValid;

	private static FFieldAddress PlayAnimationReverse_bRestoreState_PropertyAddress;

	private static int PlayAnimationReverse_bRestoreState_Offset;

	private static bool PlayAnimationReverse_ReturnValue_IsValid;

	private static FFieldAddress PlayAnimationReverse_ReturnValue_PropertyAddress;

	private static int PlayAnimationReverse_ReturnValue_Offset;

	private static bool PlayAnimationForward_IsValid;

	private static IntPtr PlayAnimationForward_FunctionAddress;

	private static int PlayAnimationForward_ParamsSize;

	private static bool PlayAnimationForward_InAnimation_IsValid;

	private static FFieldAddress PlayAnimationForward_InAnimation_PropertyAddress;

	private static int PlayAnimationForward_InAnimation_Offset;

	private static bool PlayAnimationForward_PlaybackSpeed_IsValid;

	private static FFieldAddress PlayAnimationForward_PlaybackSpeed_PropertyAddress;

	private static int PlayAnimationForward_PlaybackSpeed_Offset;

	private static bool PlayAnimationForward_bRestoreState_IsValid;

	private static FFieldAddress PlayAnimationForward_bRestoreState_PropertyAddress;

	private static int PlayAnimationForward_bRestoreState_Offset;

	private static bool PlayAnimationForward_ReturnValue_IsValid;

	private static FFieldAddress PlayAnimationForward_ReturnValue_PropertyAddress;

	private static int PlayAnimationForward_ReturnValue_Offset;

	private static bool PlayAnimation_IsValid;

	private static IntPtr PlayAnimation_FunctionAddress;

	private static int PlayAnimation_ParamsSize;

	private static bool PlayAnimation_InAnimation_IsValid;

	private static FFieldAddress PlayAnimation_InAnimation_PropertyAddress;

	private static int PlayAnimation_InAnimation_Offset;

	private static bool PlayAnimation_StartAtTime_IsValid;

	private static FFieldAddress PlayAnimation_StartAtTime_PropertyAddress;

	private static int PlayAnimation_StartAtTime_Offset;

	private static bool PlayAnimation_NumLoopsToPlay_IsValid;

	private static FFieldAddress PlayAnimation_NumLoopsToPlay_PropertyAddress;

	private static int PlayAnimation_NumLoopsToPlay_Offset;

	private static bool PlayAnimation_PlayMode_IsValid;

	private static FFieldAddress PlayAnimation_PlayMode_PropertyAddress;

	private static int PlayAnimation_PlayMode_Offset;

	private static bool PlayAnimation_PlaybackSpeed_IsValid;

	private static FFieldAddress PlayAnimation_PlaybackSpeed_PropertyAddress;

	private static int PlayAnimation_PlaybackSpeed_Offset;

	private static bool PlayAnimation_bRestoreState_IsValid;

	private static FFieldAddress PlayAnimation_bRestoreState_PropertyAddress;

	private static int PlayAnimation_bRestoreState_Offset;

	private static bool PlayAnimation_ReturnValue_IsValid;

	private static FFieldAddress PlayAnimation_ReturnValue_PropertyAddress;

	private static int PlayAnimation_ReturnValue_Offset;

	private static bool PauseAnimation_IsValid;

	private static IntPtr PauseAnimation_FunctionAddress;

	private static int PauseAnimation_ParamsSize;

	private static bool PauseAnimation_InAnimation_IsValid;

	private static FFieldAddress PauseAnimation_InAnimation_PropertyAddress;

	private static int PauseAnimation_InAnimation_Offset;

	private static bool PauseAnimation_ReturnValue_IsValid;

	private static FFieldAddress PauseAnimation_ReturnValue_PropertyAddress;

	private static int PauseAnimation_ReturnValue_Offset;

	private static bool OnTouchStarted_IsValid;

	private IntPtr OnTouchStarted_InstanceFunctionAddress;

	private static IntPtr OnTouchStarted_FunctionAddress;

	private static int OnTouchStarted_ParamsSize;

	private static bool OnTouchStarted_MyGeometry_IsValid;

	private static FFieldAddress OnTouchStarted_MyGeometry_PropertyAddress;

	private static int OnTouchStarted_MyGeometry_Offset;

	private static bool OnTouchStarted_InTouchEvent_IsValid;

	private static FFieldAddress OnTouchStarted_InTouchEvent_PropertyAddress;

	private static int OnTouchStarted_InTouchEvent_Offset;

	private static bool OnTouchStarted_ReturnValue_IsValid;

	private static FFieldAddress OnTouchStarted_ReturnValue_PropertyAddress;

	private static int OnTouchStarted_ReturnValue_Offset;

	private static bool OnTouchMoved_IsValid;

	private IntPtr OnTouchMoved_InstanceFunctionAddress;

	private static IntPtr OnTouchMoved_FunctionAddress;

	private static int OnTouchMoved_ParamsSize;

	private static bool OnTouchMoved_MyGeometry_IsValid;

	private static FFieldAddress OnTouchMoved_MyGeometry_PropertyAddress;

	private static int OnTouchMoved_MyGeometry_Offset;

	private static bool OnTouchMoved_InTouchEvent_IsValid;

	private static FFieldAddress OnTouchMoved_InTouchEvent_PropertyAddress;

	private static int OnTouchMoved_InTouchEvent_Offset;

	private static bool OnTouchMoved_ReturnValue_IsValid;

	private static FFieldAddress OnTouchMoved_ReturnValue_PropertyAddress;

	private static int OnTouchMoved_ReturnValue_Offset;

	private static bool OnTouchGesture_IsValid;

	private IntPtr OnTouchGesture_InstanceFunctionAddress;

	private static IntPtr OnTouchGesture_FunctionAddress;

	private static int OnTouchGesture_ParamsSize;

	private static bool OnTouchGesture_MyGeometry_IsValid;

	private static FFieldAddress OnTouchGesture_MyGeometry_PropertyAddress;

	private static int OnTouchGesture_MyGeometry_Offset;

	private static bool OnTouchGesture_GestureEvent_IsValid;

	private static FFieldAddress OnTouchGesture_GestureEvent_PropertyAddress;

	private static int OnTouchGesture_GestureEvent_Offset;

	private static bool OnTouchGesture_ReturnValue_IsValid;

	private static FFieldAddress OnTouchGesture_ReturnValue_PropertyAddress;

	private static int OnTouchGesture_ReturnValue_Offset;

	private static bool OnTouchForceChanged_IsValid;

	private IntPtr OnTouchForceChanged_InstanceFunctionAddress;

	private static IntPtr OnTouchForceChanged_FunctionAddress;

	private static int OnTouchForceChanged_ParamsSize;

	private static bool OnTouchForceChanged_MyGeometry_IsValid;

	private static FFieldAddress OnTouchForceChanged_MyGeometry_PropertyAddress;

	private static int OnTouchForceChanged_MyGeometry_Offset;

	private static bool OnTouchForceChanged_InTouchEvent_IsValid;

	private static FFieldAddress OnTouchForceChanged_InTouchEvent_PropertyAddress;

	private static int OnTouchForceChanged_InTouchEvent_Offset;

	private static bool OnTouchForceChanged_ReturnValue_IsValid;

	private static FFieldAddress OnTouchForceChanged_ReturnValue_PropertyAddress;

	private static int OnTouchForceChanged_ReturnValue_Offset;

	private static bool OnTouchEnded_IsValid;

	private IntPtr OnTouchEnded_InstanceFunctionAddress;

	private static IntPtr OnTouchEnded_FunctionAddress;

	private static int OnTouchEnded_ParamsSize;

	private static bool OnTouchEnded_MyGeometry_IsValid;

	private static FFieldAddress OnTouchEnded_MyGeometry_PropertyAddress;

	private static int OnTouchEnded_MyGeometry_Offset;

	private static bool OnTouchEnded_InTouchEvent_IsValid;

	private static FFieldAddress OnTouchEnded_InTouchEvent_PropertyAddress;

	private static int OnTouchEnded_InTouchEvent_Offset;

	private static bool OnTouchEnded_ReturnValue_IsValid;

	private static FFieldAddress OnTouchEnded_ReturnValue_PropertyAddress;

	private static int OnTouchEnded_ReturnValue_Offset;

	private static bool OnRemovedFromFocusPath_IsValid;

	private IntPtr OnRemovedFromFocusPath_InstanceFunctionAddress;

	private static IntPtr OnRemovedFromFocusPath_FunctionAddress;

	private static int OnRemovedFromFocusPath_ParamsSize;

	private static bool OnRemovedFromFocusPath_InFocusEvent_IsValid;

	private static FFieldAddress OnRemovedFromFocusPath_InFocusEvent_PropertyAddress;

	private static int OnRemovedFromFocusPath_InFocusEvent_Offset;

	private static bool OnPreviewMouseButtonDown_IsValid;

	private IntPtr OnPreviewMouseButtonDown_InstanceFunctionAddress;

	private static IntPtr OnPreviewMouseButtonDown_FunctionAddress;

	private static int OnPreviewMouseButtonDown_ParamsSize;

	private static bool OnPreviewMouseButtonDown_MyGeometry_IsValid;

	private static FFieldAddress OnPreviewMouseButtonDown_MyGeometry_PropertyAddress;

	private static int OnPreviewMouseButtonDown_MyGeometry_Offset;

	private static bool OnPreviewMouseButtonDown_MouseEvent_IsValid;

	private static FFieldAddress OnPreviewMouseButtonDown_MouseEvent_PropertyAddress;

	private static int OnPreviewMouseButtonDown_MouseEvent_Offset;

	private static bool OnPreviewMouseButtonDown_ReturnValue_IsValid;

	private static FFieldAddress OnPreviewMouseButtonDown_ReturnValue_PropertyAddress;

	private static int OnPreviewMouseButtonDown_ReturnValue_Offset;

	private static bool OnPreviewKeyDown_IsValid;

	private IntPtr OnPreviewKeyDown_InstanceFunctionAddress;

	private static IntPtr OnPreviewKeyDown_FunctionAddress;

	private static int OnPreviewKeyDown_ParamsSize;

	private static bool OnPreviewKeyDown_MyGeometry_IsValid;

	private static FFieldAddress OnPreviewKeyDown_MyGeometry_PropertyAddress;

	private static int OnPreviewKeyDown_MyGeometry_Offset;

	private static bool OnPreviewKeyDown_InKeyEvent_IsValid;

	private static FFieldAddress OnPreviewKeyDown_InKeyEvent_PropertyAddress;

	private static int OnPreviewKeyDown_InKeyEvent_Offset;

	private static bool OnPreviewKeyDown_ReturnValue_IsValid;

	private static FFieldAddress OnPreviewKeyDown_ReturnValue_PropertyAddress;

	private static int OnPreviewKeyDown_ReturnValue_Offset;

	private static bool OnPaint_IsValid;

	private IntPtr OnPaint_InstanceFunctionAddress;

	private static IntPtr OnPaint_FunctionAddress;

	private static int OnPaint_ParamsSize;

	private static bool OnPaint_Context_IsValid;

	private static FFieldAddress OnPaint_Context_PropertyAddress;

	private static int OnPaint_Context_Offset;

	private static bool OnMouseWheel_IsValid;

	private IntPtr OnMouseWheel_InstanceFunctionAddress;

	private static IntPtr OnMouseWheel_FunctionAddress;

	private static int OnMouseWheel_ParamsSize;

	private static bool OnMouseWheel_MyGeometry_IsValid;

	private static FFieldAddress OnMouseWheel_MyGeometry_PropertyAddress;

	private static int OnMouseWheel_MyGeometry_Offset;

	private static bool OnMouseWheel_MouseEvent_IsValid;

	private static FFieldAddress OnMouseWheel_MouseEvent_PropertyAddress;

	private static int OnMouseWheel_MouseEvent_Offset;

	private static bool OnMouseWheel_ReturnValue_IsValid;

	private static FFieldAddress OnMouseWheel_ReturnValue_PropertyAddress;

	private static int OnMouseWheel_ReturnValue_Offset;

	private static bool OnMouseMove_IsValid;

	private IntPtr OnMouseMove_InstanceFunctionAddress;

	private static IntPtr OnMouseMove_FunctionAddress;

	private static int OnMouseMove_ParamsSize;

	private static bool OnMouseMove_MyGeometry_IsValid;

	private static FFieldAddress OnMouseMove_MyGeometry_PropertyAddress;

	private static int OnMouseMove_MyGeometry_Offset;

	private static bool OnMouseMove_MouseEvent_IsValid;

	private static FFieldAddress OnMouseMove_MouseEvent_PropertyAddress;

	private static int OnMouseMove_MouseEvent_Offset;

	private static bool OnMouseMove_ReturnValue_IsValid;

	private static FFieldAddress OnMouseMove_ReturnValue_PropertyAddress;

	private static int OnMouseMove_ReturnValue_Offset;

	private static bool OnMouseLeave_IsValid;

	private IntPtr OnMouseLeave_InstanceFunctionAddress;

	private static IntPtr OnMouseLeave_FunctionAddress;

	private static int OnMouseLeave_ParamsSize;

	private static bool OnMouseLeave_MouseEvent_IsValid;

	private static FFieldAddress OnMouseLeave_MouseEvent_PropertyAddress;

	private static int OnMouseLeave_MouseEvent_Offset;

	private static bool OnMouseEnter_IsValid;

	private IntPtr OnMouseEnter_InstanceFunctionAddress;

	private static IntPtr OnMouseEnter_FunctionAddress;

	private static int OnMouseEnter_ParamsSize;

	private static bool OnMouseEnter_MyGeometry_IsValid;

	private static FFieldAddress OnMouseEnter_MyGeometry_PropertyAddress;

	private static int OnMouseEnter_MyGeometry_Offset;

	private static bool OnMouseEnter_MouseEvent_IsValid;

	private static FFieldAddress OnMouseEnter_MouseEvent_PropertyAddress;

	private static int OnMouseEnter_MouseEvent_Offset;

	private static bool OnMouseCaptureLost_IsValid;

	private IntPtr OnMouseCaptureLost_InstanceFunctionAddress;

	private static IntPtr OnMouseCaptureLost_FunctionAddress;

	private static int OnMouseCaptureLost_ParamsSize;

	private static bool OnMouseButtonUp_IsValid;

	private IntPtr OnMouseButtonUp_InstanceFunctionAddress;

	private static IntPtr OnMouseButtonUp_FunctionAddress;

	private static int OnMouseButtonUp_ParamsSize;

	private static bool OnMouseButtonUp_MyGeometry_IsValid;

	private static FFieldAddress OnMouseButtonUp_MyGeometry_PropertyAddress;

	private static int OnMouseButtonUp_MyGeometry_Offset;

	private static bool OnMouseButtonUp_MouseEvent_IsValid;

	private static FFieldAddress OnMouseButtonUp_MouseEvent_PropertyAddress;

	private static int OnMouseButtonUp_MouseEvent_Offset;

	private static bool OnMouseButtonUp_ReturnValue_IsValid;

	private static FFieldAddress OnMouseButtonUp_ReturnValue_PropertyAddress;

	private static int OnMouseButtonUp_ReturnValue_Offset;

	private static bool OnMouseButtonDown_IsValid;

	private IntPtr OnMouseButtonDown_InstanceFunctionAddress;

	private static IntPtr OnMouseButtonDown_FunctionAddress;

	private static int OnMouseButtonDown_ParamsSize;

	private static bool OnMouseButtonDown_MyGeometry_IsValid;

	private static FFieldAddress OnMouseButtonDown_MyGeometry_PropertyAddress;

	private static int OnMouseButtonDown_MyGeometry_Offset;

	private static bool OnMouseButtonDown_MouseEvent_IsValid;

	private static FFieldAddress OnMouseButtonDown_MouseEvent_PropertyAddress;

	private static int OnMouseButtonDown_MouseEvent_Offset;

	private static bool OnMouseButtonDown_ReturnValue_IsValid;

	private static FFieldAddress OnMouseButtonDown_ReturnValue_PropertyAddress;

	private static int OnMouseButtonDown_ReturnValue_Offset;

	private static bool OnMouseButtonDoubleClick_IsValid;

	private IntPtr OnMouseButtonDoubleClick_InstanceFunctionAddress;

	private static IntPtr OnMouseButtonDoubleClick_FunctionAddress;

	private static int OnMouseButtonDoubleClick_ParamsSize;

	private static bool OnMouseButtonDoubleClick_InMyGeometry_IsValid;

	private static FFieldAddress OnMouseButtonDoubleClick_InMyGeometry_PropertyAddress;

	private static int OnMouseButtonDoubleClick_InMyGeometry_Offset;

	private static bool OnMouseButtonDoubleClick_InMouseEvent_IsValid;

	private static FFieldAddress OnMouseButtonDoubleClick_InMouseEvent_PropertyAddress;

	private static int OnMouseButtonDoubleClick_InMouseEvent_Offset;

	private static bool OnMouseButtonDoubleClick_ReturnValue_IsValid;

	private static FFieldAddress OnMouseButtonDoubleClick_ReturnValue_PropertyAddress;

	private static int OnMouseButtonDoubleClick_ReturnValue_Offset;

	private static bool OnMotionDetected_IsValid;

	private IntPtr OnMotionDetected_InstanceFunctionAddress;

	private static IntPtr OnMotionDetected_FunctionAddress;

	private static int OnMotionDetected_ParamsSize;

	private static bool OnMotionDetected_MyGeometry_IsValid;

	private static FFieldAddress OnMotionDetected_MyGeometry_PropertyAddress;

	private static int OnMotionDetected_MyGeometry_Offset;

	private static bool OnMotionDetected_InMotionEvent_IsValid;

	private static FFieldAddress OnMotionDetected_InMotionEvent_PropertyAddress;

	private static int OnMotionDetected_InMotionEvent_Offset;

	private static bool OnMotionDetected_ReturnValue_IsValid;

	private static FFieldAddress OnMotionDetected_ReturnValue_PropertyAddress;

	private static int OnMotionDetected_ReturnValue_Offset;

	private static bool OnKeyUp_IsValid;

	private IntPtr OnKeyUp_InstanceFunctionAddress;

	private static IntPtr OnKeyUp_FunctionAddress;

	private static int OnKeyUp_ParamsSize;

	private static bool OnKeyUp_MyGeometry_IsValid;

	private static FFieldAddress OnKeyUp_MyGeometry_PropertyAddress;

	private static int OnKeyUp_MyGeometry_Offset;

	private static bool OnKeyUp_InKeyEvent_IsValid;

	private static FFieldAddress OnKeyUp_InKeyEvent_PropertyAddress;

	private static int OnKeyUp_InKeyEvent_Offset;

	private static bool OnKeyUp_ReturnValue_IsValid;

	private static FFieldAddress OnKeyUp_ReturnValue_PropertyAddress;

	private static int OnKeyUp_ReturnValue_Offset;

	private static bool OnKeyDown_IsValid;

	private IntPtr OnKeyDown_InstanceFunctionAddress;

	private static IntPtr OnKeyDown_FunctionAddress;

	private static int OnKeyDown_ParamsSize;

	private static bool OnKeyDown_MyGeometry_IsValid;

	private static FFieldAddress OnKeyDown_MyGeometry_PropertyAddress;

	private static int OnKeyDown_MyGeometry_Offset;

	private static bool OnKeyDown_InKeyEvent_IsValid;

	private static FFieldAddress OnKeyDown_InKeyEvent_PropertyAddress;

	private static int OnKeyDown_InKeyEvent_Offset;

	private static bool OnKeyDown_ReturnValue_IsValid;

	private static FFieldAddress OnKeyDown_ReturnValue_PropertyAddress;

	private static int OnKeyDown_ReturnValue_Offset;

	private static bool OnKeyChar_IsValid;

	private IntPtr OnKeyChar_InstanceFunctionAddress;

	private static IntPtr OnKeyChar_FunctionAddress;

	private static int OnKeyChar_ParamsSize;

	private static bool OnKeyChar_MyGeometry_IsValid;

	private static FFieldAddress OnKeyChar_MyGeometry_PropertyAddress;

	private static int OnKeyChar_MyGeometry_Offset;

	private static bool OnKeyChar_InCharacterEvent_IsValid;

	private static FFieldAddress OnKeyChar_InCharacterEvent_PropertyAddress;

	private static int OnKeyChar_InCharacterEvent_Offset;

	private static bool OnKeyChar_ReturnValue_IsValid;

	private static FFieldAddress OnKeyChar_ReturnValue_PropertyAddress;

	private static int OnKeyChar_ReturnValue_Offset;

	private static bool OnInitialized_IsValid;

	private IntPtr OnInitialized_InstanceFunctionAddress;

	private static IntPtr OnInitialized_FunctionAddress;

	private static int OnInitialized_ParamsSize;

	private static bool OnFocusReceived_IsValid;

	private IntPtr OnFocusReceived_InstanceFunctionAddress;

	private static IntPtr OnFocusReceived_FunctionAddress;

	private static int OnFocusReceived_ParamsSize;

	private static bool OnFocusReceived_MyGeometry_IsValid;

	private static FFieldAddress OnFocusReceived_MyGeometry_PropertyAddress;

	private static int OnFocusReceived_MyGeometry_Offset;

	private static bool OnFocusReceived_InFocusEvent_IsValid;

	private static FFieldAddress OnFocusReceived_InFocusEvent_PropertyAddress;

	private static int OnFocusReceived_InFocusEvent_Offset;

	private static bool OnFocusReceived_ReturnValue_IsValid;

	private static FFieldAddress OnFocusReceived_ReturnValue_PropertyAddress;

	private static int OnFocusReceived_ReturnValue_Offset;

	private static bool OnFocusLost_IsValid;

	private IntPtr OnFocusLost_InstanceFunctionAddress;

	private static IntPtr OnFocusLost_FunctionAddress;

	private static int OnFocusLost_ParamsSize;

	private static bool OnFocusLost_InFocusEvent_IsValid;

	private static FFieldAddress OnFocusLost_InFocusEvent_PropertyAddress;

	private static int OnFocusLost_InFocusEvent_Offset;

	private static bool OnDrop_IsValid;

	private IntPtr OnDrop_InstanceFunctionAddress;

	private static IntPtr OnDrop_FunctionAddress;

	private static int OnDrop_ParamsSize;

	private static bool OnDrop_MyGeometry_IsValid;

	private static FFieldAddress OnDrop_MyGeometry_PropertyAddress;

	private static int OnDrop_MyGeometry_Offset;

	private static bool OnDrop_PointerEvent_IsValid;

	private static FFieldAddress OnDrop_PointerEvent_PropertyAddress;

	private static int OnDrop_PointerEvent_Offset;

	private static bool OnDrop_Operation_IsValid;

	private static FFieldAddress OnDrop_Operation_PropertyAddress;

	private static int OnDrop_Operation_Offset;

	private static bool OnDrop_ReturnValue_IsValid;

	private static FFieldAddress OnDrop_ReturnValue_PropertyAddress;

	private static int OnDrop_ReturnValue_Offset;

	private static bool OnDragOver_IsValid;

	private IntPtr OnDragOver_InstanceFunctionAddress;

	private static IntPtr OnDragOver_FunctionAddress;

	private static int OnDragOver_ParamsSize;

	private static bool OnDragOver_MyGeometry_IsValid;

	private static FFieldAddress OnDragOver_MyGeometry_PropertyAddress;

	private static int OnDragOver_MyGeometry_Offset;

	private static bool OnDragOver_PointerEvent_IsValid;

	private static FFieldAddress OnDragOver_PointerEvent_PropertyAddress;

	private static int OnDragOver_PointerEvent_Offset;

	private static bool OnDragOver_Operation_IsValid;

	private static FFieldAddress OnDragOver_Operation_PropertyAddress;

	private static int OnDragOver_Operation_Offset;

	private static bool OnDragOver_ReturnValue_IsValid;

	private static FFieldAddress OnDragOver_ReturnValue_PropertyAddress;

	private static int OnDragOver_ReturnValue_Offset;

	private static bool OnDragLeave_IsValid;

	private IntPtr OnDragLeave_InstanceFunctionAddress;

	private static IntPtr OnDragLeave_FunctionAddress;

	private static int OnDragLeave_ParamsSize;

	private static bool OnDragLeave_PointerEvent_IsValid;

	private static FFieldAddress OnDragLeave_PointerEvent_PropertyAddress;

	private static int OnDragLeave_PointerEvent_Offset;

	private static bool OnDragLeave_Operation_IsValid;

	private static FFieldAddress OnDragLeave_Operation_PropertyAddress;

	private static int OnDragLeave_Operation_Offset;

	private static bool OnDragEnter_IsValid;

	private IntPtr OnDragEnter_InstanceFunctionAddress;

	private static IntPtr OnDragEnter_FunctionAddress;

	private static int OnDragEnter_ParamsSize;

	private static bool OnDragEnter_MyGeometry_IsValid;

	private static FFieldAddress OnDragEnter_MyGeometry_PropertyAddress;

	private static int OnDragEnter_MyGeometry_Offset;

	private static bool OnDragEnter_PointerEvent_IsValid;

	private static FFieldAddress OnDragEnter_PointerEvent_PropertyAddress;

	private static int OnDragEnter_PointerEvent_Offset;

	private static bool OnDragEnter_Operation_IsValid;

	private static FFieldAddress OnDragEnter_Operation_PropertyAddress;

	private static int OnDragEnter_Operation_Offset;

	private static bool OnDragDetected_IsValid;

	private IntPtr OnDragDetected_InstanceFunctionAddress;

	private static IntPtr OnDragDetected_FunctionAddress;

	private static int OnDragDetected_ParamsSize;

	private static bool OnDragDetected_MyGeometry_IsValid;

	private static FFieldAddress OnDragDetected_MyGeometry_PropertyAddress;

	private static int OnDragDetected_MyGeometry_Offset;

	private static bool OnDragDetected_PointerEvent_IsValid;

	private static FFieldAddress OnDragDetected_PointerEvent_PropertyAddress;

	private static int OnDragDetected_PointerEvent_Offset;

	private static bool OnDragDetected_Operation_IsValid;

	private static FFieldAddress OnDragDetected_Operation_PropertyAddress;

	private static int OnDragDetected_Operation_Offset;

	private static bool OnDragCancelled_IsValid;

	private IntPtr OnDragCancelled_InstanceFunctionAddress;

	private static IntPtr OnDragCancelled_FunctionAddress;

	private static int OnDragCancelled_ParamsSize;

	private static bool OnDragCancelled_PointerEvent_IsValid;

	private static FFieldAddress OnDragCancelled_PointerEvent_PropertyAddress;

	private static int OnDragCancelled_PointerEvent_Offset;

	private static bool OnDragCancelled_Operation_IsValid;

	private static FFieldAddress OnDragCancelled_Operation_PropertyAddress;

	private static int OnDragCancelled_Operation_Offset;

	private static bool OnAnimationStarted_IsValid;

	private IntPtr OnAnimationStarted_InstanceFunctionAddress;

	private static IntPtr OnAnimationStarted_FunctionAddress;

	private static int OnAnimationStarted_ParamsSize;

	private static bool OnAnimationStarted_Animation_IsValid;

	private static FFieldAddress OnAnimationStarted_Animation_PropertyAddress;

	private static int OnAnimationStarted_Animation_Offset;

	private static bool OnAnimationFinished_IsValid;

	private IntPtr OnAnimationFinished_InstanceFunctionAddress;

	private static IntPtr OnAnimationFinished_FunctionAddress;

	private static int OnAnimationFinished_ParamsSize;

	private static bool OnAnimationFinished_Animation_IsValid;

	private static FFieldAddress OnAnimationFinished_Animation_PropertyAddress;

	private static int OnAnimationFinished_Animation_Offset;

	private static bool OnAnalogValueChanged_IsValid;

	private IntPtr OnAnalogValueChanged_InstanceFunctionAddress;

	private static IntPtr OnAnalogValueChanged_FunctionAddress;

	private static int OnAnalogValueChanged_ParamsSize;

	private static bool OnAnalogValueChanged_MyGeometry_IsValid;

	private static FFieldAddress OnAnalogValueChanged_MyGeometry_PropertyAddress;

	private static int OnAnalogValueChanged_MyGeometry_Offset;

	private static bool OnAnalogValueChanged_InAnalogInputEvent_IsValid;

	private static FFieldAddress OnAnalogValueChanged_InAnalogInputEvent_PropertyAddress;

	private static int OnAnalogValueChanged_InAnalogInputEvent_Offset;

	private static bool OnAnalogValueChanged_ReturnValue_IsValid;

	private static FFieldAddress OnAnalogValueChanged_ReturnValue_PropertyAddress;

	private static int OnAnalogValueChanged_ReturnValue_Offset;

	private static bool OnAddedToFocusPath_IsValid;

	private IntPtr OnAddedToFocusPath_InstanceFunctionAddress;

	private static IntPtr OnAddedToFocusPath_FunctionAddress;

	private static int OnAddedToFocusPath_ParamsSize;

	private static bool OnAddedToFocusPath_InFocusEvent_IsValid;

	private static FFieldAddress OnAddedToFocusPath_InFocusEvent_PropertyAddress;

	private static int OnAddedToFocusPath_InFocusEvent_Offset;

	private static bool ListenForInputAction_IsValid;

	private static IntPtr ListenForInputAction_FunctionAddress;

	private static int ListenForInputAction_ParamsSize;

	private static bool ListenForInputAction_ActionName_IsValid;

	private static FFieldAddress ListenForInputAction_ActionName_PropertyAddress;

	private static int ListenForInputAction_ActionName_Offset;

	private static bool ListenForInputAction_EventType_IsValid;

	private static FFieldAddress ListenForInputAction_EventType_PropertyAddress;

	private static int ListenForInputAction_EventType_Offset;

	private static bool ListenForInputAction_bConsume_IsValid;

	private static FFieldAddress ListenForInputAction_bConsume_PropertyAddress;

	private static int ListenForInputAction_bConsume_Offset;

	private static bool ListenForInputAction_Callback_IsValid;

	private static FFieldAddress ListenForInputAction_Callback_PropertyAddress;

	private static int ListenForInputAction_Callback_Offset;

	private static bool IsPlayingAnimation_IsValid;

	private static IntPtr IsPlayingAnimation_FunctionAddress;

	private static int IsPlayingAnimation_ParamsSize;

	private static bool IsPlayingAnimation_ReturnValue_IsValid;

	private static FFieldAddress IsPlayingAnimation_ReturnValue_PropertyAddress;

	private static int IsPlayingAnimation_ReturnValue_Offset;

	private static bool IsListeningForInputAction_IsValid;

	private static IntPtr IsListeningForInputAction_FunctionAddress;

	private static int IsListeningForInputAction_ParamsSize;

	private static bool IsListeningForInputAction_ActionName_IsValid;

	private static FFieldAddress IsListeningForInputAction_ActionName_PropertyAddress;

	private static int IsListeningForInputAction_ActionName_Offset;

	private static bool IsListeningForInputAction_ReturnValue_IsValid;

	private static FFieldAddress IsListeningForInputAction_ReturnValue_PropertyAddress;

	private static int IsListeningForInputAction_ReturnValue_Offset;

	private static bool IsInViewport_IsValid;

	private static IntPtr IsInViewport_FunctionAddress;

	private static int IsInViewport_ParamsSize;

	private static bool IsInViewport_ReturnValue_IsValid;

	private static FFieldAddress IsInViewport_ReturnValue_PropertyAddress;

	private static int IsInViewport_ReturnValue_Offset;

	private static bool IsInteractable_IsValid;

	private IntPtr IsInteractable_InstanceFunctionAddress;

	private static IntPtr IsInteractable_FunctionAddress;

	private static int IsInteractable_ParamsSize;

	private static bool IsInteractable_ReturnValue_IsValid;

	private static FFieldAddress IsInteractable_ReturnValue_PropertyAddress;

	private static int IsInteractable_ReturnValue_Offset;

	private static bool IsAnyAnimationPlaying_IsValid;

	private static IntPtr IsAnyAnimationPlaying_FunctionAddress;

	private static int IsAnyAnimationPlaying_ParamsSize;

	private static bool IsAnyAnimationPlaying_ReturnValue_IsValid;

	private static FFieldAddress IsAnyAnimationPlaying_ReturnValue_PropertyAddress;

	private static int IsAnyAnimationPlaying_ReturnValue_Offset;

	private static bool IsAnimationPlayingForward_IsValid;

	private static IntPtr IsAnimationPlayingForward_FunctionAddress;

	private static int IsAnimationPlayingForward_ParamsSize;

	private static bool IsAnimationPlayingForward_InAnimation_IsValid;

	private static FFieldAddress IsAnimationPlayingForward_InAnimation_PropertyAddress;

	private static int IsAnimationPlayingForward_InAnimation_Offset;

	private static bool IsAnimationPlayingForward_ReturnValue_IsValid;

	private static FFieldAddress IsAnimationPlayingForward_ReturnValue_PropertyAddress;

	private static int IsAnimationPlayingForward_ReturnValue_Offset;

	private static bool IsAnimationPlaying_IsValid;

	private static IntPtr IsAnimationPlaying_FunctionAddress;

	private static int IsAnimationPlaying_ParamsSize;

	private static bool IsAnimationPlaying_InAnimation_IsValid;

	private static FFieldAddress IsAnimationPlaying_InAnimation_PropertyAddress;

	private static int IsAnimationPlaying_InAnimation_Offset;

	private static bool IsAnimationPlaying_ReturnValue_IsValid;

	private static FFieldAddress IsAnimationPlaying_ReturnValue_PropertyAddress;

	private static int IsAnimationPlaying_ReturnValue_Offset;

	private static bool GetOwningPlayerPawn_IsValid;

	private static IntPtr GetOwningPlayerPawn_FunctionAddress;

	private static int GetOwningPlayerPawn_ParamsSize;

	private static bool GetOwningPlayerPawn_ReturnValue_IsValid;

	private static FFieldAddress GetOwningPlayerPawn_ReturnValue_PropertyAddress;

	private static int GetOwningPlayerPawn_ReturnValue_Offset;

	private static bool GetOwningPlayerCameraManager_IsValid;

	private static IntPtr GetOwningPlayerCameraManager_FunctionAddress;

	private static int GetOwningPlayerCameraManager_ParamsSize;

	private static bool GetOwningPlayerCameraManager_ReturnValue_IsValid;

	private static FFieldAddress GetOwningPlayerCameraManager_ReturnValue_PropertyAddress;

	private static int GetOwningPlayerCameraManager_ReturnValue_Offset;

	private static bool GetAnimationCurrentTime_IsValid;

	private static IntPtr GetAnimationCurrentTime_FunctionAddress;

	private static int GetAnimationCurrentTime_ParamsSize;

	private static bool GetAnimationCurrentTime_InAnimation_IsValid;

	private static FFieldAddress GetAnimationCurrentTime_InAnimation_PropertyAddress;

	private static int GetAnimationCurrentTime_InAnimation_Offset;

	private static bool GetAnimationCurrentTime_ReturnValue_IsValid;

	private static FFieldAddress GetAnimationCurrentTime_ReturnValue_PropertyAddress;

	private static int GetAnimationCurrentTime_ReturnValue_Offset;

	private static bool GetAnchorsInViewport_IsValid;

	private static IntPtr GetAnchorsInViewport_FunctionAddress;

	private static int GetAnchorsInViewport_ParamsSize;

	private static bool GetAnchorsInViewport_ReturnValue_IsValid;

	private static FFieldAddress GetAnchorsInViewport_ReturnValue_PropertyAddress;

	private static int GetAnchorsInViewport_ReturnValue_Offset;

	private static bool GetAlignmentInViewport_IsValid;

	private static IntPtr GetAlignmentInViewport_FunctionAddress;

	private static int GetAlignmentInViewport_ParamsSize;

	private static bool GetAlignmentInViewport_ReturnValue_IsValid;

	private static FFieldAddress GetAlignmentInViewport_ReturnValue_PropertyAddress;

	private static int GetAlignmentInViewport_ReturnValue_Offset;

	private static bool FlushAnimations_IsValid;

	private static IntPtr FlushAnimations_FunctionAddress;

	private static int FlushAnimations_ParamsSize;

	private static bool Destruct_IsValid;

	private IntPtr Destruct_InstanceFunctionAddress;

	private static IntPtr Destruct_FunctionAddress;

	private static int Destruct_ParamsSize;

	private static bool Construct_IsValid;

	private IntPtr Construct_InstanceFunctionAddress;

	private static IntPtr Construct_FunctionAddress;

	private static int Construct_ParamsSize;

	private static bool CancelLatentActions_IsValid;

	private static IntPtr CancelLatentActions_FunctionAddress;

	private static int CancelLatentActions_ParamsSize;

	private static bool BindToAnimationStarted_IsValid;

	private static IntPtr BindToAnimationStarted_FunctionAddress;

	private static int BindToAnimationStarted_ParamsSize;

	private static bool BindToAnimationStarted_Animation_IsValid;

	private static FFieldAddress BindToAnimationStarted_Animation_PropertyAddress;

	private static int BindToAnimationStarted_Animation_Offset;

	private static bool BindToAnimationStarted_Delegate_IsValid;

	private static FFieldAddress BindToAnimationStarted_Delegate_PropertyAddress;

	private static int BindToAnimationStarted_Delegate_Offset;

	private static bool BindToAnimationFinished_IsValid;

	private static IntPtr BindToAnimationFinished_FunctionAddress;

	private static int BindToAnimationFinished_ParamsSize;

	private static bool BindToAnimationFinished_Animation_IsValid;

	private static FFieldAddress BindToAnimationFinished_Animation_PropertyAddress;

	private static int BindToAnimationFinished_Animation_Offset;

	private static bool BindToAnimationFinished_Delegate_IsValid;

	private static FFieldAddress BindToAnimationFinished_Delegate_PropertyAddress;

	private static int BindToAnimationFinished_Delegate_Offset;

	private static bool BindToAnimationEvent_IsValid;

	private static IntPtr BindToAnimationEvent_FunctionAddress;

	private static int BindToAnimationEvent_ParamsSize;

	private static bool BindToAnimationEvent_Animation_IsValid;

	private static FFieldAddress BindToAnimationEvent_Animation_PropertyAddress;

	private static int BindToAnimationEvent_Animation_Offset;

	private static bool BindToAnimationEvent_Delegate_IsValid;

	private static FFieldAddress BindToAnimationEvent_Delegate_PropertyAddress;

	private static int BindToAnimationEvent_Delegate_Offset;

	private static bool BindToAnimationEvent_AnimationEvent_IsValid;

	private static FFieldAddress BindToAnimationEvent_AnimationEvent_PropertyAddress;

	private static int BindToAnimationEvent_AnimationEvent_Offset;

	private static bool BindToAnimationEvent_UserTag_IsValid;

	private static FFieldAddress BindToAnimationEvent_UserTag_PropertyAddress;

	private static int BindToAnimationEvent_UserTag_Offset;

	private static bool AddToViewport_IsValid;

	private static IntPtr AddToViewport_FunctionAddress;

	private static int AddToViewport_ParamsSize;

	private static bool AddToViewport_ZOrder_IsValid;

	private static FFieldAddress AddToViewport_ZOrder_PropertyAddress;

	private static int AddToViewport_ZOrder_Offset;

	private static bool AddToPlayerScreen_IsValid;

	private static IntPtr AddToPlayerScreen_FunctionAddress;

	private static int AddToPlayerScreen_ParamsSize;

	private static bool AddToPlayerScreen_ZOrder_IsValid;

	private static FFieldAddress AddToPlayerScreen_ZOrder_PropertyAddress;

	private static int AddToPlayerScreen_ZOrder_Offset;

	private static bool AddToPlayerScreen_ReturnValue_IsValid;

	private static FFieldAddress AddToPlayerScreen_ReturnValue_PropertyAddress;

	private static int AddToPlayerScreen_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.UserWidget:ColorAndOpacity")]
	public FLinearColor ColorAndOpacity
	{
		get
		{
			CheckDestroyed();
			if (!ColorAndOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:ColorAndOpacity");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, ColorAndOpacity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ColorAndOpacity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:ColorAndOpacity");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, ColorAndOpacity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.UserWidget:ForegroundColor")]
	public FSlateColor ForegroundColor
	{
		get
		{
			CheckDestroyed();
			if (!ForegroundColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:ForegroundColor");
				return default(FSlateColor);
			}
			return FSlateColor.FromNative(IntPtr.Add(base.Address, ForegroundColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForegroundColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:ForegroundColor");
			}
			else
			{
				FSlateColor.ToNative(IntPtr.Add(base.Address, ForegroundColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.UserWidget:OnVisibilityChanged")]
	public FOnVisibilityChangedEvent OnVisibilityChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnVisibilityChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:OnVisibilityChanged");
				return new FOnVisibilityChangedEvent();
			}
			if (OnVisibilityChanged_DelegateCached == null)
			{
				OnVisibilityChanged_DelegateCached = new FOnVisibilityChangedEvent();
				OnVisibilityChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnVisibilityChanged_Offset));
			}
			return OnVisibilityChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/UMG.UserWidget:Padding")]
	public FMargin Padding
	{
		get
		{
			CheckDestroyed();
			if (!Padding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:Padding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, Padding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Padding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:Padding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, Padding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.UserWidget:Priority")]
	public int Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:Priority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:Priority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/UMG.UserWidget:bIsFocusable")]
	public bool IsFocusable
	{
		get
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:bIsFocusable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:bIsFocusable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/UMG.UserWidget:bStopAction")]
	public bool StopAction
	{
		get
		{
			CheckDestroyed();
			if (!StopAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:bStopAction");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StopAction_Offset), 0, StopAction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StopAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:bStopAction");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StopAction_Offset), 0, StopAction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)20266268116451861uL)]
	[UMetaPath("/Script/UMG.UserWidget:TickFrequency")]
	public EWidgetTickFrequency TickFrequency
	{
		get
		{
			CheckDestroyed();
			if (!TickFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:TickFrequency");
				return EWidgetTickFrequency.Never;
			}
			return EnumMarshaler<EWidgetTickFrequency>.FromNative(IntPtr.Add(base.Address, TickFrequency_Offset), 0, TickFrequency_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TickFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.UserWidget:TickFrequency");
			}
			else
			{
				EnumMarshaler<EWidgetTickFrequency>.ToNative(IntPtr.Add(base.Address, TickFrequency_Offset), 0, TickFrequency_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/UMG.UserWidget:UnregisterInputComponent")]
	protected unsafe void UnregisterInputComponent()
	{
		CheckDestroyed();
		if (!UnregisterInputComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:UnregisterInputComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterInputComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterInputComponent_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UnregisterInputComponent_FunctionAddress, argsSize: UnregisterInputComponent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UserWidget:UnbindFromAnimationStarted")]
	public unsafe void UnbindFromAnimationStarted(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate)
	{
		CheckDestroyed();
		if (!UnbindFromAnimationStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:UnbindFromAnimationStarted");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnbindFromAnimationStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnbindFromAnimationStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, UnbindFromAnimationStarted_Animation_Offset), 0, UnbindFromAnimationStarted_Animation_PropertyAddress.Address, Animation);
		FDelegateMarshaler<FWidgetAnimationDynamicEvent>.ToNative(IntPtr.Add(intPtr, UnbindFromAnimationStarted_Delegate_Offset), 0, UnbindFromAnimationStarted_Delegate_PropertyAddress.Address, Delegate);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnbindFromAnimationStarted_FunctionAddress, intPtr, UnbindFromAnimationStarted_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UserWidget:UnbindFromAnimationFinished")]
	public unsafe void UnbindFromAnimationFinished(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate)
	{
		CheckDestroyed();
		if (!UnbindFromAnimationFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:UnbindFromAnimationFinished");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnbindFromAnimationFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnbindFromAnimationFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, UnbindFromAnimationFinished_Animation_Offset), 0, UnbindFromAnimationFinished_Animation_PropertyAddress.Address, Animation);
		FDelegateMarshaler<FWidgetAnimationDynamicEvent>.ToNative(IntPtr.Add(intPtr, UnbindFromAnimationFinished_Delegate_Offset), 0, UnbindFromAnimationFinished_Delegate_PropertyAddress.Address, Delegate);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnbindFromAnimationFinished_FunctionAddress, intPtr, UnbindFromAnimationFinished_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UserWidget:UnbindAllFromAnimationStarted")]
	public unsafe void UnbindAllFromAnimationStarted(UWidgetAnimation Animation)
	{
		CheckDestroyed();
		if (!UnbindAllFromAnimationStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:UnbindAllFromAnimationStarted");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnbindAllFromAnimationStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnbindAllFromAnimationStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, UnbindAllFromAnimationStarted_Animation_Offset), 0, UnbindAllFromAnimationStarted_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnbindAllFromAnimationStarted_FunctionAddress, intPtr, UnbindAllFromAnimationStarted_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UserWidget:UnbindAllFromAnimationFinished")]
	public unsafe void UnbindAllFromAnimationFinished(UWidgetAnimation Animation)
	{
		CheckDestroyed();
		if (!UnbindAllFromAnimationFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:UnbindAllFromAnimationFinished");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnbindAllFromAnimationFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnbindAllFromAnimationFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, UnbindAllFromAnimationFinished_Animation_Offset), 0, UnbindAllFromAnimationFinished_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnbindAllFromAnimationFinished_FunctionAddress, intPtr, UnbindAllFromAnimationFinished_ParamsSize);
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:Tick")]
	public unsafe void Tick(FGeometry MyGeometry, float InDeltaTime)
	{
		CheckDestroyed();
		if (!Tick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:Tick");
			return;
		}
		if (Tick_InstanceFunctionAddress == IntPtr.Zero)
		{
			Tick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Tick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Tick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Tick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Tick_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, Tick_MyGeometry_Offset), 0, Tick_MyGeometry_PropertyAddress.Address, MyGeometry);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Tick_InDeltaTime_Offset), 0, Tick_InDeltaTime_PropertyAddress.Address, InDeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, Tick_InstanceFunctionAddress, intPtr, Tick_ParamsSize);
	}

	protected unsafe virtual void Tick_Implementation(FGeometry MyGeometry, float InDeltaTime)
	{
		CheckDestroyed();
		if (!Tick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:Tick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Tick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Tick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Tick_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, Tick_MyGeometry_Offset), 0, Tick_MyGeometry_PropertyAddress.Address, MyGeometry);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Tick_InDeltaTime_Offset), 0, Tick_InDeltaTime_PropertyAddress.Address, InDeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, Tick_FunctionAddress, intPtr, Tick_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/UMG.UserWidget:StopListeningForInputAction")]
	protected unsafe void StopListeningForInputAction(FName ActionName, EInputEventType EventType)
	{
		CheckDestroyed();
		if (!StopListeningForInputAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:StopListeningForInputAction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopListeningForInputAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopListeningForInputAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, StopListeningForInputAction_ActionName_Offset), 0, StopListeningForInputAction_ActionName_PropertyAddress.Address, ActionName);
		EnumMarshaler<EInputEventType>.ToNative(IntPtr.Add(intPtr, StopListeningForInputAction_EventType_Offset), 0, StopListeningForInputAction_EventType_PropertyAddress.Address, EventType);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopListeningForInputAction_FunctionAddress, intPtr, StopListeningForInputAction_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/UMG.UserWidget:StopListeningForAllInputActions")]
	protected unsafe void StopListeningForAllInputActions()
	{
		CheckDestroyed();
		if (!StopListeningForAllInputActions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:StopListeningForAllInputActions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopListeningForAllInputActions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopListeningForAllInputActions_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopListeningForAllInputActions_FunctionAddress, argsSize: StopListeningForAllInputActions_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UserWidget:StopAnimationsAndLatentActions")]
	public unsafe void StopAnimationsAndLatentActions()
	{
		CheckDestroyed();
		if (!StopAnimationsAndLatentActions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:StopAnimationsAndLatentActions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAnimationsAndLatentActions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAnimationsAndLatentActions_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopAnimationsAndLatentActions_FunctionAddress, argsSize: StopAnimationsAndLatentActions_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UserWidget:StopAnimation")]
	public unsafe void StopAnimation(UWidgetAnimation InAnimation)
	{
		CheckDestroyed();
		if (!StopAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:StopAnimation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, StopAnimation_InAnimation_Offset), 0, StopAnimation_InAnimation_PropertyAddress.Address, InAnimation);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopAnimation_FunctionAddress, intPtr, StopAnimation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UserWidget:StopAllAnimations")]
	public unsafe void StopAllAnimations()
	{
		CheckDestroyed();
		if (!StopAllAnimations_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:StopAllAnimations");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAllAnimations_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAllAnimations_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopAllAnimations_FunctionAddress, argsSize: StopAllAnimations_ParamsSize);
	}

	[UFunction(Flags = 75629577u)]
	[UMetaPath("/Script/UMG.UserWidget:SetPositionInViewport")]
	public unsafe void SetPositionInViewport(FVector2D Position, bool bRemoveDPIScale = true)
	{
		CheckDestroyed();
		if (!SetPositionInViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:SetPositionInViewport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPositionInViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPositionInViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetPositionInViewport_Position_Offset), 0, SetPositionInViewport_Position_PropertyAddress.Address, Position);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPositionInViewport_bRemoveDPIScale_Offset), 0, SetPositionInViewport_bRemoveDPIScale_PropertyAddress.Address, bRemoveDPIScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPositionInViewport_FunctionAddress, intPtr, SetPositionInViewport_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:SetPlaybackSpeed")]
	public unsafe void SetPlaybackSpeed(UWidgetAnimation InAnimation, float PlaybackSpeed = 1f)
	{
		CheckDestroyed();
		if (!SetPlaybackSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:SetPlaybackSpeed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaybackSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaybackSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, SetPlaybackSpeed_InAnimation_Offset), 0, SetPlaybackSpeed_InAnimation_PropertyAddress.Address, InAnimation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlaybackSpeed_PlaybackSpeed_Offset), 0, SetPlaybackSpeed_PlaybackSpeed_PropertyAddress.Address, PlaybackSpeed);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaybackSpeed_FunctionAddress, intPtr, SetPlaybackSpeed_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:SetPadding")]
	public unsafe void SetPadding(FMargin InPadding)
	{
		CheckDestroyed();
		if (!SetPadding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:SetPadding");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPadding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPadding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(intPtr, SetPadding_InPadding_Offset), 0, SetPadding_InPadding_PropertyAddress.Address, InPadding);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPadding_FunctionAddress, intPtr, SetPadding_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:SetOwningPlayer")]
	public unsafe void SetOwningPlayer(APlayerController LocalPlayerController)
	{
		CheckDestroyed();
		if (!SetOwningPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:SetOwningPlayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOwningPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOwningPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, SetOwningPlayer_LocalPlayerController_Offset), 0, SetOwningPlayer_LocalPlayerController_PropertyAddress.Address, LocalPlayerController);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOwningPlayer_FunctionAddress, intPtr, SetOwningPlayer_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:SetNumLoopsToPlay")]
	public unsafe void SetNumLoopsToPlay(UWidgetAnimation InAnimation, int NumLoopsToPlay)
	{
		CheckDestroyed();
		if (!SetNumLoopsToPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:SetNumLoopsToPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNumLoopsToPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNumLoopsToPlay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, SetNumLoopsToPlay_InAnimation_Offset), 0, SetNumLoopsToPlay_InAnimation_PropertyAddress.Address, InAnimation);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNumLoopsToPlay_NumLoopsToPlay_Offset), 0, SetNumLoopsToPlay_NumLoopsToPlay_PropertyAddress.Address, NumLoopsToPlay);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNumLoopsToPlay_FunctionAddress, intPtr, SetNumLoopsToPlay_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/UMG.UserWidget:SetInputActionPriority")]
	protected unsafe void SetInputActionPriority(int NewPriority)
	{
		CheckDestroyed();
		if (!SetInputActionPriority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:SetInputActionPriority");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInputActionPriority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInputActionPriority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetInputActionPriority_NewPriority_Offset), 0, SetInputActionPriority_NewPriority_PropertyAddress.Address, NewPriority);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInputActionPriority_FunctionAddress, intPtr, SetInputActionPriority_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/UMG.UserWidget:SetInputActionBlocking")]
	protected unsafe void SetInputActionBlocking(bool bShouldBlock)
	{
		CheckDestroyed();
		if (!SetInputActionBlocking_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:SetInputActionBlocking");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInputActionBlocking_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInputActionBlocking_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetInputActionBlocking_bShouldBlock_Offset), 0, SetInputActionBlocking_bShouldBlock_PropertyAddress.Address, bShouldBlock);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInputActionBlocking_FunctionAddress, intPtr, SetInputActionBlocking_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:SetForegroundColor")]
	public unsafe void SetForegroundColor(FSlateColor InForegroundColor)
	{
		CheckDestroyed();
		if (!SetForegroundColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:SetForegroundColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForegroundColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForegroundColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetForegroundColor_InForegroundColor_PropertyAddress.Address, intPtr);
		FSlateColor.ToNative(IntPtr.Add(intPtr, SetForegroundColor_InForegroundColor_Offset), 0, SetForegroundColor_InForegroundColor_PropertyAddress.Address, InForegroundColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForegroundColor_FunctionAddress, intPtr, SetForegroundColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetForegroundColor_InForegroundColor_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629577u)]
	[UMetaPath("/Script/UMG.UserWidget:SetDesiredSizeInViewport")]
	public unsafe void SetDesiredSizeInViewport(FVector2D Size)
	{
		CheckDestroyed();
		if (!SetDesiredSizeInViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:SetDesiredSizeInViewport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDesiredSizeInViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDesiredSizeInViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetDesiredSizeInViewport_Size_Offset), 0, SetDesiredSizeInViewport_Size_PropertyAddress.Address, Size);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDesiredSizeInViewport_FunctionAddress, intPtr, SetDesiredSizeInViewport_ParamsSize);
	}

	[UFunction(Flags = 75629577u)]
	[UMetaPath("/Script/UMG.UserWidget:SetColorAndOpacity")]
	public unsafe void SetColorAndOpacity(FLinearColor InColorAndOpacity)
	{
		CheckDestroyed();
		if (!SetColorAndOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:SetColorAndOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetColorAndOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetColorAndOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetColorAndOpacity_InColorAndOpacity_Offset), 0, SetColorAndOpacity_InColorAndOpacity_PropertyAddress.Address, InColorAndOpacity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetColorAndOpacity_FunctionAddress, intPtr, SetColorAndOpacity_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:SetAnimationCurrentTime")]
	public unsafe void SetAnimationCurrentTime(UWidgetAnimation InAnimation, float InTime)
	{
		CheckDestroyed();
		if (!SetAnimationCurrentTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:SetAnimationCurrentTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimationCurrentTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimationCurrentTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, SetAnimationCurrentTime_InAnimation_Offset), 0, SetAnimationCurrentTime_InAnimation_PropertyAddress.Address, InAnimation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAnimationCurrentTime_InTime_Offset), 0, SetAnimationCurrentTime_InTime_PropertyAddress.Address, InTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAnimationCurrentTime_FunctionAddress, intPtr, SetAnimationCurrentTime_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:SetAnchorsInViewport")]
	public unsafe void SetAnchorsInViewport(FAnchors Anchors)
	{
		CheckDestroyed();
		if (!SetAnchorsInViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:SetAnchorsInViewport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnchorsInViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnchorsInViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAnchorsInViewport_Anchors_PropertyAddress.Address, intPtr);
		FAnchors.ToNative(IntPtr.Add(intPtr, SetAnchorsInViewport_Anchors_Offset), 0, SetAnchorsInViewport_Anchors_PropertyAddress.Address, Anchors);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAnchorsInViewport_FunctionAddress, intPtr, SetAnchorsInViewport_ParamsSize);
	}

	[UFunction(Flags = 75629577u)]
	[UMetaPath("/Script/UMG.UserWidget:SetAlignmentInViewport")]
	public unsafe void SetAlignmentInViewport(FVector2D Alignment)
	{
		CheckDestroyed();
		if (!SetAlignmentInViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:SetAlignmentInViewport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAlignmentInViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAlignmentInViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetAlignmentInViewport_Alignment_Offset), 0, SetAlignmentInViewport_Alignment_PropertyAddress.Address, Alignment);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAlignmentInViewport_FunctionAddress, intPtr, SetAlignmentInViewport_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:ReverseAnimation")]
	public unsafe void ReverseAnimation(UWidgetAnimation InAnimation)
	{
		CheckDestroyed();
		if (!ReverseAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:ReverseAnimation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReverseAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReverseAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, ReverseAnimation_InAnimation_Offset), 0, ReverseAnimation_InAnimation_PropertyAddress.Address, InAnimation);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReverseAnimation_FunctionAddress, intPtr, ReverseAnimation_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/UMG.UserWidget:RegisterInputComponent")]
	protected unsafe void RegisterInputComponent()
	{
		CheckDestroyed();
		if (!RegisterInputComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:RegisterInputComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterInputComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterInputComponent_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RegisterInputComponent_FunctionAddress, argsSize: RegisterInputComponent_ParamsSize);
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:PreConstruct")]
	public unsafe void PreConstruct(bool IsDesignTime)
	{
		CheckDestroyed();
		if (!PreConstruct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:PreConstruct");
			return;
		}
		if (PreConstruct_InstanceFunctionAddress == IntPtr.Zero)
		{
			PreConstruct_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PreConstruct");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreConstruct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreConstruct_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PreConstruct_IsDesignTime_Offset), 0, PreConstruct_IsDesignTime_PropertyAddress.Address, IsDesignTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, PreConstruct_InstanceFunctionAddress, intPtr, PreConstruct_ParamsSize);
	}

	protected unsafe virtual void PreConstruct_Implementation(bool IsDesignTime)
	{
		CheckDestroyed();
		if (!PreConstruct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:PreConstruct");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreConstruct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreConstruct_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PreConstruct_IsDesignTime_Offset), 0, PreConstruct_IsDesignTime_PropertyAddress.Address, IsDesignTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, PreConstruct_FunctionAddress, intPtr, PreConstruct_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:PlayAnimationTimeRange")]
	public unsafe UMGSequencePlayer PlayAnimationTimeRange(UWidgetAnimation InAnimation, float StartAtTime = 0f, float EndAtTime = 0f, int NumLoopsToPlay = 1, EUMGSequencePlayMode PlayMode = EUMGSequencePlayMode.Forward, float PlaybackSpeed = 1f, bool bRestoreState = false)
	{
		CheckDestroyed();
		if (!PlayAnimationTimeRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:PlayAnimationTimeRange");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayAnimationTimeRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayAnimationTimeRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, PlayAnimationTimeRange_InAnimation_Offset), 0, PlayAnimationTimeRange_InAnimation_PropertyAddress.Address, InAnimation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayAnimationTimeRange_StartAtTime_Offset), 0, PlayAnimationTimeRange_StartAtTime_PropertyAddress.Address, StartAtTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayAnimationTimeRange_EndAtTime_Offset), 0, PlayAnimationTimeRange_EndAtTime_PropertyAddress.Address, EndAtTime);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PlayAnimationTimeRange_NumLoopsToPlay_Offset), 0, PlayAnimationTimeRange_NumLoopsToPlay_PropertyAddress.Address, NumLoopsToPlay);
		EnumMarshaler<EUMGSequencePlayMode>.ToNative(IntPtr.Add(intPtr, PlayAnimationTimeRange_PlayMode_Offset), 0, PlayAnimationTimeRange_PlayMode_PropertyAddress.Address, PlayMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayAnimationTimeRange_PlaybackSpeed_Offset), 0, PlayAnimationTimeRange_PlaybackSpeed_PropertyAddress.Address, PlaybackSpeed);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PlayAnimationTimeRange_bRestoreState_Offset), 0, PlayAnimationTimeRange_bRestoreState_PropertyAddress.Address, bRestoreState);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayAnimationTimeRange_FunctionAddress, intPtr, PlayAnimationTimeRange_ParamsSize);
		return UObjectMarshaler<UMGSequencePlayer>.FromNative(IntPtr.Add(intPtr, PlayAnimationTimeRange_ReturnValue_Offset), 0, PlayAnimationTimeRange_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:PlayAnimationReverse")]
	public unsafe UMGSequencePlayer PlayAnimationReverse(UWidgetAnimation InAnimation, float PlaybackSpeed = 1f, bool bRestoreState = false)
	{
		CheckDestroyed();
		if (!PlayAnimationReverse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:PlayAnimationReverse");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayAnimationReverse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayAnimationReverse_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, PlayAnimationReverse_InAnimation_Offset), 0, PlayAnimationReverse_InAnimation_PropertyAddress.Address, InAnimation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayAnimationReverse_PlaybackSpeed_Offset), 0, PlayAnimationReverse_PlaybackSpeed_PropertyAddress.Address, PlaybackSpeed);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PlayAnimationReverse_bRestoreState_Offset), 0, PlayAnimationReverse_bRestoreState_PropertyAddress.Address, bRestoreState);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayAnimationReverse_FunctionAddress, intPtr, PlayAnimationReverse_ParamsSize);
		return UObjectMarshaler<UMGSequencePlayer>.FromNative(IntPtr.Add(intPtr, PlayAnimationReverse_ReturnValue_Offset), 0, PlayAnimationReverse_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:PlayAnimationForward")]
	public unsafe UMGSequencePlayer PlayAnimationForward(UWidgetAnimation InAnimation, float PlaybackSpeed = 1f, bool bRestoreState = false)
	{
		CheckDestroyed();
		if (!PlayAnimationForward_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:PlayAnimationForward");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayAnimationForward_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayAnimationForward_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, PlayAnimationForward_InAnimation_Offset), 0, PlayAnimationForward_InAnimation_PropertyAddress.Address, InAnimation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayAnimationForward_PlaybackSpeed_Offset), 0, PlayAnimationForward_PlaybackSpeed_PropertyAddress.Address, PlaybackSpeed);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PlayAnimationForward_bRestoreState_Offset), 0, PlayAnimationForward_bRestoreState_PropertyAddress.Address, bRestoreState);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayAnimationForward_FunctionAddress, intPtr, PlayAnimationForward_ParamsSize);
		return UObjectMarshaler<UMGSequencePlayer>.FromNative(IntPtr.Add(intPtr, PlayAnimationForward_ReturnValue_Offset), 0, PlayAnimationForward_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:PlayAnimation")]
	public unsafe UMGSequencePlayer PlayAnimation(UWidgetAnimation InAnimation, float StartAtTime = 0f, int NumLoopsToPlay = 1, EUMGSequencePlayMode PlayMode = EUMGSequencePlayMode.Forward, float PlaybackSpeed = 1f, bool bRestoreState = false)
	{
		CheckDestroyed();
		if (!PlayAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:PlayAnimation");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, PlayAnimation_InAnimation_Offset), 0, PlayAnimation_InAnimation_PropertyAddress.Address, InAnimation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayAnimation_StartAtTime_Offset), 0, PlayAnimation_StartAtTime_PropertyAddress.Address, StartAtTime);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PlayAnimation_NumLoopsToPlay_Offset), 0, PlayAnimation_NumLoopsToPlay_PropertyAddress.Address, NumLoopsToPlay);
		EnumMarshaler<EUMGSequencePlayMode>.ToNative(IntPtr.Add(intPtr, PlayAnimation_PlayMode_Offset), 0, PlayAnimation_PlayMode_PropertyAddress.Address, PlayMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayAnimation_PlaybackSpeed_Offset), 0, PlayAnimation_PlaybackSpeed_PropertyAddress.Address, PlaybackSpeed);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PlayAnimation_bRestoreState_Offset), 0, PlayAnimation_bRestoreState_PropertyAddress.Address, bRestoreState);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayAnimation_FunctionAddress, intPtr, PlayAnimation_ParamsSize);
		return UObjectMarshaler<UMGSequencePlayer>.FromNative(IntPtr.Add(intPtr, PlayAnimation_ReturnValue_Offset), 0, PlayAnimation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:PauseAnimation")]
	public unsafe float PauseAnimation(UWidgetAnimation InAnimation)
	{
		CheckDestroyed();
		if (!PauseAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:PauseAnimation");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PauseAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PauseAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, PauseAnimation_InAnimation_Offset), 0, PauseAnimation_InAnimation_PropertyAddress.Address, InAnimation);
		NativeReflection.InvokeFunctionOptimized(base.Address, PauseAnimation_FunctionAddress, intPtr, PauseAnimation_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, PauseAnimation_ReturnValue_Offset), 0, PauseAnimation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnTouchStarted")]
	public unsafe FEventReply OnTouchStarted(FGeometry MyGeometry, FPointerEvent InTouchEvent)
	{
		CheckDestroyed();
		if (!OnTouchStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnTouchStarted");
			return null;
		}
		if (OnTouchStarted_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnTouchStarted_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnTouchStarted");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTouchStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTouchStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnTouchStarted_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnTouchStarted_MyGeometry_Offset), 0, OnTouchStarted_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnTouchStarted_InTouchEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnTouchStarted_InTouchEvent_Offset), 0, OnTouchStarted_InTouchEvent_PropertyAddress.Address, InTouchEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTouchStarted_InstanceFunctionAddress, intPtr, OnTouchStarted_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnTouchStarted_InTouchEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnTouchStarted_ReturnValue_Offset), 0, OnTouchStarted_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnTouchStarted_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnTouchStarted_Implementation(FGeometry MyGeometry, FPointerEvent InTouchEvent)
	{
		CheckDestroyed();
		if (!OnTouchStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnTouchStarted");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTouchStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTouchStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnTouchStarted_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnTouchStarted_MyGeometry_Offset), 0, OnTouchStarted_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnTouchStarted_InTouchEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnTouchStarted_InTouchEvent_Offset), 0, OnTouchStarted_InTouchEvent_PropertyAddress.Address, InTouchEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTouchStarted_FunctionAddress, intPtr, OnTouchStarted_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnTouchStarted_InTouchEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnTouchStarted_ReturnValue_Offset), 0, OnTouchStarted_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnTouchStarted_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnTouchMoved")]
	public unsafe FEventReply OnTouchMoved(FGeometry MyGeometry, FPointerEvent InTouchEvent)
	{
		CheckDestroyed();
		if (!OnTouchMoved_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnTouchMoved");
			return null;
		}
		if (OnTouchMoved_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnTouchMoved_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnTouchMoved");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTouchMoved_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTouchMoved_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnTouchMoved_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnTouchMoved_MyGeometry_Offset), 0, OnTouchMoved_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnTouchMoved_InTouchEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnTouchMoved_InTouchEvent_Offset), 0, OnTouchMoved_InTouchEvent_PropertyAddress.Address, InTouchEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTouchMoved_InstanceFunctionAddress, intPtr, OnTouchMoved_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnTouchMoved_InTouchEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnTouchMoved_ReturnValue_Offset), 0, OnTouchMoved_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnTouchMoved_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnTouchMoved_Implementation(FGeometry MyGeometry, FPointerEvent InTouchEvent)
	{
		CheckDestroyed();
		if (!OnTouchMoved_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnTouchMoved");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTouchMoved_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTouchMoved_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnTouchMoved_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnTouchMoved_MyGeometry_Offset), 0, OnTouchMoved_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnTouchMoved_InTouchEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnTouchMoved_InTouchEvent_Offset), 0, OnTouchMoved_InTouchEvent_PropertyAddress.Address, InTouchEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTouchMoved_FunctionAddress, intPtr, OnTouchMoved_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnTouchMoved_InTouchEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnTouchMoved_ReturnValue_Offset), 0, OnTouchMoved_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnTouchMoved_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnTouchGesture")]
	public unsafe FEventReply OnTouchGesture(FGeometry MyGeometry, FPointerEvent GestureEvent)
	{
		CheckDestroyed();
		if (!OnTouchGesture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnTouchGesture");
			return null;
		}
		if (OnTouchGesture_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnTouchGesture_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnTouchGesture");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTouchGesture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTouchGesture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnTouchGesture_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnTouchGesture_MyGeometry_Offset), 0, OnTouchGesture_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnTouchGesture_GestureEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnTouchGesture_GestureEvent_Offset), 0, OnTouchGesture_GestureEvent_PropertyAddress.Address, GestureEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTouchGesture_InstanceFunctionAddress, intPtr, OnTouchGesture_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnTouchGesture_GestureEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnTouchGesture_ReturnValue_Offset), 0, OnTouchGesture_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnTouchGesture_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnTouchGesture_Implementation(FGeometry MyGeometry, FPointerEvent GestureEvent)
	{
		CheckDestroyed();
		if (!OnTouchGesture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnTouchGesture");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTouchGesture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTouchGesture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnTouchGesture_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnTouchGesture_MyGeometry_Offset), 0, OnTouchGesture_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnTouchGesture_GestureEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnTouchGesture_GestureEvent_Offset), 0, OnTouchGesture_GestureEvent_PropertyAddress.Address, GestureEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTouchGesture_FunctionAddress, intPtr, OnTouchGesture_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnTouchGesture_GestureEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnTouchGesture_ReturnValue_Offset), 0, OnTouchGesture_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnTouchGesture_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnTouchForceChanged")]
	public unsafe FEventReply OnTouchForceChanged(FGeometry MyGeometry, FPointerEvent InTouchEvent)
	{
		CheckDestroyed();
		if (!OnTouchForceChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnTouchForceChanged");
			return null;
		}
		if (OnTouchForceChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnTouchForceChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnTouchForceChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTouchForceChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTouchForceChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnTouchForceChanged_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnTouchForceChanged_MyGeometry_Offset), 0, OnTouchForceChanged_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnTouchForceChanged_InTouchEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnTouchForceChanged_InTouchEvent_Offset), 0, OnTouchForceChanged_InTouchEvent_PropertyAddress.Address, InTouchEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTouchForceChanged_InstanceFunctionAddress, intPtr, OnTouchForceChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnTouchForceChanged_InTouchEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnTouchForceChanged_ReturnValue_Offset), 0, OnTouchForceChanged_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnTouchForceChanged_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnTouchForceChanged_Implementation(FGeometry MyGeometry, FPointerEvent InTouchEvent)
	{
		CheckDestroyed();
		if (!OnTouchForceChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnTouchForceChanged");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTouchForceChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTouchForceChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnTouchForceChanged_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnTouchForceChanged_MyGeometry_Offset), 0, OnTouchForceChanged_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnTouchForceChanged_InTouchEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnTouchForceChanged_InTouchEvent_Offset), 0, OnTouchForceChanged_InTouchEvent_PropertyAddress.Address, InTouchEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTouchForceChanged_FunctionAddress, intPtr, OnTouchForceChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnTouchForceChanged_InTouchEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnTouchForceChanged_ReturnValue_Offset), 0, OnTouchForceChanged_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnTouchForceChanged_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnTouchEnded")]
	public unsafe FEventReply OnTouchEnded(FGeometry MyGeometry, FPointerEvent InTouchEvent)
	{
		CheckDestroyed();
		if (!OnTouchEnded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnTouchEnded");
			return null;
		}
		if (OnTouchEnded_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnTouchEnded_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnTouchEnded");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTouchEnded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTouchEnded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnTouchEnded_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnTouchEnded_MyGeometry_Offset), 0, OnTouchEnded_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnTouchEnded_InTouchEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnTouchEnded_InTouchEvent_Offset), 0, OnTouchEnded_InTouchEvent_PropertyAddress.Address, InTouchEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTouchEnded_InstanceFunctionAddress, intPtr, OnTouchEnded_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnTouchEnded_InTouchEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnTouchEnded_ReturnValue_Offset), 0, OnTouchEnded_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnTouchEnded_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnTouchEnded_Implementation(FGeometry MyGeometry, FPointerEvent InTouchEvent)
	{
		CheckDestroyed();
		if (!OnTouchEnded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnTouchEnded");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTouchEnded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTouchEnded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnTouchEnded_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnTouchEnded_MyGeometry_Offset), 0, OnTouchEnded_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnTouchEnded_InTouchEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnTouchEnded_InTouchEvent_Offset), 0, OnTouchEnded_InTouchEvent_PropertyAddress.Address, InTouchEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTouchEnded_FunctionAddress, intPtr, OnTouchEnded_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnTouchEnded_InTouchEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnTouchEnded_ReturnValue_Offset), 0, OnTouchEnded_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnTouchEnded_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:OnRemovedFromFocusPath")]
	public unsafe void OnRemovedFromFocusPath(FFocusEvent InFocusEvent)
	{
		CheckDestroyed();
		if (!OnRemovedFromFocusPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnRemovedFromFocusPath");
			return;
		}
		if (OnRemovedFromFocusPath_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnRemovedFromFocusPath_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnRemovedFromFocusPath");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRemovedFromFocusPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRemovedFromFocusPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnRemovedFromFocusPath_InFocusEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FFocusEvent>.ToNative(IntPtr.Add(intPtr, OnRemovedFromFocusPath_InFocusEvent_Offset), 0, OnRemovedFromFocusPath_InFocusEvent_PropertyAddress.Address, InFocusEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnRemovedFromFocusPath_InstanceFunctionAddress, intPtr, OnRemovedFromFocusPath_ParamsSize);
	}

	protected unsafe virtual void OnRemovedFromFocusPath_Implementation(FFocusEvent InFocusEvent)
	{
		CheckDestroyed();
		if (!OnRemovedFromFocusPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnRemovedFromFocusPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRemovedFromFocusPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRemovedFromFocusPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnRemovedFromFocusPath_InFocusEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FFocusEvent>.ToNative(IntPtr.Add(intPtr, OnRemovedFromFocusPath_InFocusEvent_Offset), 0, OnRemovedFromFocusPath_InFocusEvent_PropertyAddress.Address, InFocusEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnRemovedFromFocusPath_FunctionAddress, intPtr, OnRemovedFromFocusPath_ParamsSize);
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnPreviewMouseButtonDown")]
	public unsafe FEventReply OnPreviewMouseButtonDown(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		CheckDestroyed();
		if (!OnPreviewMouseButtonDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnPreviewMouseButtonDown");
			return null;
		}
		if (OnPreviewMouseButtonDown_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPreviewMouseButtonDown_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPreviewMouseButtonDown");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreviewMouseButtonDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreviewMouseButtonDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnPreviewMouseButtonDown_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnPreviewMouseButtonDown_MyGeometry_Offset), 0, OnPreviewMouseButtonDown_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnPreviewMouseButtonDown_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnPreviewMouseButtonDown_MouseEvent_Offset), 0, OnPreviewMouseButtonDown_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreviewMouseButtonDown_InstanceFunctionAddress, intPtr, OnPreviewMouseButtonDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPreviewMouseButtonDown_MouseEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnPreviewMouseButtonDown_ReturnValue_Offset), 0, OnPreviewMouseButtonDown_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnPreviewMouseButtonDown_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnPreviewMouseButtonDown_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		CheckDestroyed();
		if (!OnPreviewMouseButtonDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnPreviewMouseButtonDown");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreviewMouseButtonDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreviewMouseButtonDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnPreviewMouseButtonDown_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnPreviewMouseButtonDown_MyGeometry_Offset), 0, OnPreviewMouseButtonDown_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnPreviewMouseButtonDown_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnPreviewMouseButtonDown_MouseEvent_Offset), 0, OnPreviewMouseButtonDown_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreviewMouseButtonDown_FunctionAddress, intPtr, OnPreviewMouseButtonDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPreviewMouseButtonDown_MouseEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnPreviewMouseButtonDown_ReturnValue_Offset), 0, OnPreviewMouseButtonDown_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnPreviewMouseButtonDown_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/UMG.UserWidget:OnPreviewKeyDown")]
	public unsafe FEventReply OnPreviewKeyDown(FGeometry MyGeometry, FKeyEvent InKeyEvent)
	{
		CheckDestroyed();
		if (!OnPreviewKeyDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnPreviewKeyDown");
			return null;
		}
		if (OnPreviewKeyDown_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPreviewKeyDown_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPreviewKeyDown");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreviewKeyDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreviewKeyDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnPreviewKeyDown_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnPreviewKeyDown_MyGeometry_Offset), 0, OnPreviewKeyDown_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnPreviewKeyDown_InKeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, OnPreviewKeyDown_InKeyEvent_Offset), 0, OnPreviewKeyDown_InKeyEvent_PropertyAddress.Address, InKeyEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreviewKeyDown_InstanceFunctionAddress, intPtr, OnPreviewKeyDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPreviewKeyDown_InKeyEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnPreviewKeyDown_ReturnValue_Offset), 0, OnPreviewKeyDown_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnPreviewKeyDown_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnPreviewKeyDown_Implementation(FGeometry MyGeometry, FKeyEvent InKeyEvent)
	{
		CheckDestroyed();
		if (!OnPreviewKeyDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnPreviewKeyDown");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPreviewKeyDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPreviewKeyDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnPreviewKeyDown_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnPreviewKeyDown_MyGeometry_Offset), 0, OnPreviewKeyDown_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnPreviewKeyDown_InKeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, OnPreviewKeyDown_InKeyEvent_Offset), 0, OnPreviewKeyDown_InKeyEvent_PropertyAddress.Address, InKeyEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPreviewKeyDown_FunctionAddress, intPtr, OnPreviewKeyDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPreviewKeyDown_InKeyEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnPreviewKeyDown_ReturnValue_Offset), 0, OnPreviewKeyDown_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnPreviewKeyDown_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1212286984u)]
	[UMetaPath("/Script/UMG.UserWidget:OnPaint")]
	public unsafe void OnPaint(ref FPaintContext Context)
	{
		CheckDestroyed();
		if (!OnPaint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnPaint");
			return;
		}
		if (OnPaint_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPaint_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPaint");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPaint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPaint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnPaint_Context_PropertyAddress.Address, intPtr);
		FPaintContext.ToNative(IntPtr.Add(intPtr, OnPaint_Context_Offset), 0, OnPaint_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPaint_InstanceFunctionAddress, intPtr, OnPaint_ParamsSize);
		Context = FPaintContext.FromNative(IntPtr.Add(intPtr, OnPaint_Context_Offset), 0, OnPaint_Context_PropertyAddress.Address);
	}

	protected unsafe virtual void OnPaint_Implementation(ref FPaintContext Context)
	{
		CheckDestroyed();
		if (!OnPaint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnPaint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPaint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPaint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnPaint_Context_PropertyAddress.Address, intPtr);
		FPaintContext.ToNative(IntPtr.Add(intPtr, OnPaint_Context_Offset), 0, OnPaint_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPaint_FunctionAddress, intPtr, OnPaint_ParamsSize);
		Context = FPaintContext.FromNative(IntPtr.Add(intPtr, OnPaint_Context_Offset), 0, OnPaint_Context_PropertyAddress.Address);
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnMouseWheel")]
	public unsafe FEventReply OnMouseWheel(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		CheckDestroyed();
		if (!OnMouseWheel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseWheel");
			return null;
		}
		if (OnMouseWheel_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnMouseWheel_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnMouseWheel");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseWheel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseWheel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMouseWheel_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnMouseWheel_MyGeometry_Offset), 0, OnMouseWheel_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnMouseWheel_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnMouseWheel_MouseEvent_Offset), 0, OnMouseWheel_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMouseWheel_InstanceFunctionAddress, intPtr, OnMouseWheel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMouseWheel_MouseEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnMouseWheel_ReturnValue_Offset), 0, OnMouseWheel_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnMouseWheel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnMouseWheel_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		CheckDestroyed();
		if (!OnMouseWheel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseWheel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseWheel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseWheel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMouseWheel_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnMouseWheel_MyGeometry_Offset), 0, OnMouseWheel_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnMouseWheel_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnMouseWheel_MouseEvent_Offset), 0, OnMouseWheel_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMouseWheel_FunctionAddress, intPtr, OnMouseWheel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMouseWheel_MouseEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnMouseWheel_ReturnValue_Offset), 0, OnMouseWheel_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnMouseWheel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnMouseMove")]
	public unsafe FEventReply OnMouseMove(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		CheckDestroyed();
		if (!OnMouseMove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseMove");
			return null;
		}
		if (OnMouseMove_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnMouseMove_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnMouseMove");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseMove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseMove_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMouseMove_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnMouseMove_MyGeometry_Offset), 0, OnMouseMove_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnMouseMove_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnMouseMove_MouseEvent_Offset), 0, OnMouseMove_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMouseMove_InstanceFunctionAddress, intPtr, OnMouseMove_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMouseMove_MouseEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnMouseMove_ReturnValue_Offset), 0, OnMouseMove_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnMouseMove_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnMouseMove_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		CheckDestroyed();
		if (!OnMouseMove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseMove");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseMove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseMove_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMouseMove_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnMouseMove_MyGeometry_Offset), 0, OnMouseMove_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnMouseMove_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnMouseMove_MouseEvent_Offset), 0, OnMouseMove_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMouseMove_FunctionAddress, intPtr, OnMouseMove_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMouseMove_MouseEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnMouseMove_ReturnValue_Offset), 0, OnMouseMove_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnMouseMove_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnMouseLeave")]
	public unsafe void OnMouseLeave(FPointerEvent MouseEvent)
	{
		CheckDestroyed();
		if (!OnMouseLeave_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseLeave");
			return;
		}
		if (OnMouseLeave_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnMouseLeave_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnMouseLeave");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseLeave_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseLeave_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMouseLeave_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnMouseLeave_MouseEvent_Offset), 0, OnMouseLeave_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMouseLeave_InstanceFunctionAddress, intPtr, OnMouseLeave_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMouseLeave_MouseEvent_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnMouseLeave_Implementation(FPointerEvent MouseEvent)
	{
		CheckDestroyed();
		if (!OnMouseLeave_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseLeave");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseLeave_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseLeave_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMouseLeave_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnMouseLeave_MouseEvent_Offset), 0, OnMouseLeave_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMouseLeave_FunctionAddress, intPtr, OnMouseLeave_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMouseLeave_MouseEvent_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnMouseEnter")]
	public unsafe void OnMouseEnter(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		CheckDestroyed();
		if (!OnMouseEnter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseEnter");
			return;
		}
		if (OnMouseEnter_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnMouseEnter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnMouseEnter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseEnter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseEnter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMouseEnter_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnMouseEnter_MyGeometry_Offset), 0, OnMouseEnter_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnMouseEnter_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnMouseEnter_MouseEvent_Offset), 0, OnMouseEnter_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMouseEnter_InstanceFunctionAddress, intPtr, OnMouseEnter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMouseEnter_MouseEvent_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnMouseEnter_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		CheckDestroyed();
		if (!OnMouseEnter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseEnter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseEnter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseEnter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMouseEnter_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnMouseEnter_MyGeometry_Offset), 0, OnMouseEnter_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnMouseEnter_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnMouseEnter_MouseEvent_Offset), 0, OnMouseEnter_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMouseEnter_FunctionAddress, intPtr, OnMouseEnter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMouseEnter_MouseEvent_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:OnMouseCaptureLost")]
	public unsafe void OnMouseCaptureLost()
	{
		CheckDestroyed();
		if (!OnMouseCaptureLost_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseCaptureLost");
			return;
		}
		if (OnMouseCaptureLost_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnMouseCaptureLost_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnMouseCaptureLost");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseCaptureLost_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseCaptureLost_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnMouseCaptureLost_InstanceFunctionAddress, argsSize: OnMouseCaptureLost_ParamsSize);
	}

	protected unsafe virtual void OnMouseCaptureLost_Implementation()
	{
		CheckDestroyed();
		if (!OnMouseCaptureLost_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseCaptureLost");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseCaptureLost_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseCaptureLost_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnMouseCaptureLost_FunctionAddress, argsSize: OnMouseCaptureLost_ParamsSize);
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnMouseButtonUp")]
	public unsafe FEventReply OnMouseButtonUp(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		CheckDestroyed();
		if (!OnMouseButtonUp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseButtonUp");
			return null;
		}
		if (OnMouseButtonUp_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnMouseButtonUp_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnMouseButtonUp");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseButtonUp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseButtonUp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMouseButtonUp_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnMouseButtonUp_MyGeometry_Offset), 0, OnMouseButtonUp_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnMouseButtonUp_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnMouseButtonUp_MouseEvent_Offset), 0, OnMouseButtonUp_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMouseButtonUp_InstanceFunctionAddress, intPtr, OnMouseButtonUp_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMouseButtonUp_MouseEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnMouseButtonUp_ReturnValue_Offset), 0, OnMouseButtonUp_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnMouseButtonUp_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnMouseButtonUp_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		CheckDestroyed();
		if (!OnMouseButtonUp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseButtonUp");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseButtonUp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseButtonUp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMouseButtonUp_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnMouseButtonUp_MyGeometry_Offset), 0, OnMouseButtonUp_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnMouseButtonUp_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnMouseButtonUp_MouseEvent_Offset), 0, OnMouseButtonUp_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMouseButtonUp_FunctionAddress, intPtr, OnMouseButtonUp_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMouseButtonUp_MouseEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnMouseButtonUp_ReturnValue_Offset), 0, OnMouseButtonUp_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnMouseButtonUp_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnMouseButtonDown")]
	public unsafe FEventReply OnMouseButtonDown(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		CheckDestroyed();
		if (!OnMouseButtonDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseButtonDown");
			return null;
		}
		if (OnMouseButtonDown_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnMouseButtonDown_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnMouseButtonDown");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseButtonDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseButtonDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMouseButtonDown_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnMouseButtonDown_MyGeometry_Offset), 0, OnMouseButtonDown_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnMouseButtonDown_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnMouseButtonDown_MouseEvent_Offset), 0, OnMouseButtonDown_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMouseButtonDown_InstanceFunctionAddress, intPtr, OnMouseButtonDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMouseButtonDown_MouseEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnMouseButtonDown_ReturnValue_Offset), 0, OnMouseButtonDown_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnMouseButtonDown_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnMouseButtonDown_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		CheckDestroyed();
		if (!OnMouseButtonDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseButtonDown");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseButtonDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseButtonDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMouseButtonDown_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnMouseButtonDown_MyGeometry_Offset), 0, OnMouseButtonDown_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnMouseButtonDown_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnMouseButtonDown_MouseEvent_Offset), 0, OnMouseButtonDown_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMouseButtonDown_FunctionAddress, intPtr, OnMouseButtonDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMouseButtonDown_MouseEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnMouseButtonDown_ReturnValue_Offset), 0, OnMouseButtonDown_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnMouseButtonDown_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnMouseButtonDoubleClick")]
	public unsafe FEventReply OnMouseButtonDoubleClick(FGeometry InMyGeometry, FPointerEvent InMouseEvent)
	{
		CheckDestroyed();
		if (!OnMouseButtonDoubleClick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseButtonDoubleClick");
			return null;
		}
		if (OnMouseButtonDoubleClick_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnMouseButtonDoubleClick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnMouseButtonDoubleClick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseButtonDoubleClick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseButtonDoubleClick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMouseButtonDoubleClick_InMyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnMouseButtonDoubleClick_InMyGeometry_Offset), 0, OnMouseButtonDoubleClick_InMyGeometry_PropertyAddress.Address, InMyGeometry);
		NativeReflection.InitializeValue_InContainer(OnMouseButtonDoubleClick_InMouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnMouseButtonDoubleClick_InMouseEvent_Offset), 0, OnMouseButtonDoubleClick_InMouseEvent_PropertyAddress.Address, InMouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMouseButtonDoubleClick_InstanceFunctionAddress, intPtr, OnMouseButtonDoubleClick_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMouseButtonDoubleClick_InMouseEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnMouseButtonDoubleClick_ReturnValue_Offset), 0, OnMouseButtonDoubleClick_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnMouseButtonDoubleClick_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnMouseButtonDoubleClick_Implementation(FGeometry InMyGeometry, FPointerEvent InMouseEvent)
	{
		CheckDestroyed();
		if (!OnMouseButtonDoubleClick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMouseButtonDoubleClick");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMouseButtonDoubleClick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseButtonDoubleClick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMouseButtonDoubleClick_InMyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnMouseButtonDoubleClick_InMyGeometry_Offset), 0, OnMouseButtonDoubleClick_InMyGeometry_PropertyAddress.Address, InMyGeometry);
		NativeReflection.InitializeValue_InContainer(OnMouseButtonDoubleClick_InMouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnMouseButtonDoubleClick_InMouseEvent_Offset), 0, OnMouseButtonDoubleClick_InMouseEvent_PropertyAddress.Address, InMouseEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMouseButtonDoubleClick_FunctionAddress, intPtr, OnMouseButtonDoubleClick_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMouseButtonDoubleClick_InMouseEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnMouseButtonDoubleClick_ReturnValue_Offset), 0, OnMouseButtonDoubleClick_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnMouseButtonDoubleClick_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:OnMotionDetected")]
	public unsafe FEventReply OnMotionDetected(FGeometry MyGeometry, FMotionEvent InMotionEvent)
	{
		CheckDestroyed();
		if (!OnMotionDetected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMotionDetected");
			return null;
		}
		if (OnMotionDetected_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnMotionDetected_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnMotionDetected");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMotionDetected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMotionDetected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMotionDetected_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnMotionDetected_MyGeometry_Offset), 0, OnMotionDetected_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnMotionDetected_InMotionEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FMotionEvent>.ToNative(IntPtr.Add(intPtr, OnMotionDetected_InMotionEvent_Offset), 0, OnMotionDetected_InMotionEvent_PropertyAddress.Address, InMotionEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMotionDetected_InstanceFunctionAddress, intPtr, OnMotionDetected_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMotionDetected_InMotionEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnMotionDetected_ReturnValue_Offset), 0, OnMotionDetected_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnMotionDetected_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnMotionDetected_Implementation(FGeometry MyGeometry, FMotionEvent InMotionEvent)
	{
		CheckDestroyed();
		if (!OnMotionDetected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnMotionDetected");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMotionDetected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMotionDetected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnMotionDetected_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnMotionDetected_MyGeometry_Offset), 0, OnMotionDetected_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnMotionDetected_InMotionEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FMotionEvent>.ToNative(IntPtr.Add(intPtr, OnMotionDetected_InMotionEvent_Offset), 0, OnMotionDetected_InMotionEvent_PropertyAddress.Address, InMotionEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMotionDetected_FunctionAddress, intPtr, OnMotionDetected_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnMotionDetected_InMotionEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnMotionDetected_ReturnValue_Offset), 0, OnMotionDetected_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnMotionDetected_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:OnKeyUp")]
	public unsafe FEventReply OnKeyUp(FGeometry MyGeometry, FKeyEvent InKeyEvent)
	{
		CheckDestroyed();
		if (!OnKeyUp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnKeyUp");
			return null;
		}
		if (OnKeyUp_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnKeyUp_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnKeyUp");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnKeyUp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnKeyUp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnKeyUp_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnKeyUp_MyGeometry_Offset), 0, OnKeyUp_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnKeyUp_InKeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, OnKeyUp_InKeyEvent_Offset), 0, OnKeyUp_InKeyEvent_PropertyAddress.Address, InKeyEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnKeyUp_InstanceFunctionAddress, intPtr, OnKeyUp_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnKeyUp_InKeyEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnKeyUp_ReturnValue_Offset), 0, OnKeyUp_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnKeyUp_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnKeyUp_Implementation(FGeometry MyGeometry, FKeyEvent InKeyEvent)
	{
		CheckDestroyed();
		if (!OnKeyUp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnKeyUp");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnKeyUp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnKeyUp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnKeyUp_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnKeyUp_MyGeometry_Offset), 0, OnKeyUp_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnKeyUp_InKeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, OnKeyUp_InKeyEvent_Offset), 0, OnKeyUp_InKeyEvent_PropertyAddress.Address, InKeyEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnKeyUp_FunctionAddress, intPtr, OnKeyUp_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnKeyUp_InKeyEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnKeyUp_ReturnValue_Offset), 0, OnKeyUp_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnKeyUp_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:OnKeyDown")]
	public unsafe FEventReply OnKeyDown(FGeometry MyGeometry, FKeyEvent InKeyEvent)
	{
		CheckDestroyed();
		if (!OnKeyDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnKeyDown");
			return null;
		}
		if (OnKeyDown_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnKeyDown_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnKeyDown");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnKeyDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnKeyDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnKeyDown_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnKeyDown_MyGeometry_Offset), 0, OnKeyDown_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnKeyDown_InKeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, OnKeyDown_InKeyEvent_Offset), 0, OnKeyDown_InKeyEvent_PropertyAddress.Address, InKeyEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnKeyDown_InstanceFunctionAddress, intPtr, OnKeyDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnKeyDown_InKeyEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnKeyDown_ReturnValue_Offset), 0, OnKeyDown_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnKeyDown_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnKeyDown_Implementation(FGeometry MyGeometry, FKeyEvent InKeyEvent)
	{
		CheckDestroyed();
		if (!OnKeyDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnKeyDown");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnKeyDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnKeyDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnKeyDown_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnKeyDown_MyGeometry_Offset), 0, OnKeyDown_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnKeyDown_InKeyEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, OnKeyDown_InKeyEvent_Offset), 0, OnKeyDown_InKeyEvent_PropertyAddress.Address, InKeyEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnKeyDown_FunctionAddress, intPtr, OnKeyDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnKeyDown_InKeyEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnKeyDown_ReturnValue_Offset), 0, OnKeyDown_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnKeyDown_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:OnKeyChar")]
	public unsafe FEventReply OnKeyChar(FGeometry MyGeometry, FCharacterEvent InCharacterEvent)
	{
		CheckDestroyed();
		if (!OnKeyChar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnKeyChar");
			return null;
		}
		if (OnKeyChar_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnKeyChar_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnKeyChar");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnKeyChar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnKeyChar_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnKeyChar_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnKeyChar_MyGeometry_Offset), 0, OnKeyChar_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnKeyChar_InCharacterEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FCharacterEvent>.ToNative(IntPtr.Add(intPtr, OnKeyChar_InCharacterEvent_Offset), 0, OnKeyChar_InCharacterEvent_PropertyAddress.Address, InCharacterEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnKeyChar_InstanceFunctionAddress, intPtr, OnKeyChar_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnKeyChar_InCharacterEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnKeyChar_ReturnValue_Offset), 0, OnKeyChar_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnKeyChar_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnKeyChar_Implementation(FGeometry MyGeometry, FCharacterEvent InCharacterEvent)
	{
		CheckDestroyed();
		if (!OnKeyChar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnKeyChar");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnKeyChar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnKeyChar_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnKeyChar_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnKeyChar_MyGeometry_Offset), 0, OnKeyChar_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnKeyChar_InCharacterEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FCharacterEvent>.ToNative(IntPtr.Add(intPtr, OnKeyChar_InCharacterEvent_Offset), 0, OnKeyChar_InCharacterEvent_PropertyAddress.Address, InCharacterEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnKeyChar_FunctionAddress, intPtr, OnKeyChar_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnKeyChar_InCharacterEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnKeyChar_ReturnValue_Offset), 0, OnKeyChar_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnKeyChar_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:OnInitialized")]
	public unsafe void OnInitialized()
	{
		CheckDestroyed();
		if (!OnInitialized_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnInitialized");
			return;
		}
		if (OnInitialized_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnInitialized_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnInitialized");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInitialized_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInitialized_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnInitialized_InstanceFunctionAddress, argsSize: OnInitialized_ParamsSize);
	}

	protected unsafe virtual void OnInitialized_Implementation()
	{
		CheckDestroyed();
		if (!OnInitialized_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnInitialized");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnInitialized_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInitialized_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnInitialized_FunctionAddress, argsSize: OnInitialized_ParamsSize);
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:OnFocusReceived")]
	public unsafe FEventReply OnFocusReceived(FGeometry MyGeometry, FFocusEvent InFocusEvent)
	{
		CheckDestroyed();
		if (!OnFocusReceived_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnFocusReceived");
			return null;
		}
		if (OnFocusReceived_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnFocusReceived_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnFocusReceived");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFocusReceived_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFocusReceived_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnFocusReceived_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnFocusReceived_MyGeometry_Offset), 0, OnFocusReceived_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnFocusReceived_InFocusEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FFocusEvent>.ToNative(IntPtr.Add(intPtr, OnFocusReceived_InFocusEvent_Offset), 0, OnFocusReceived_InFocusEvent_PropertyAddress.Address, InFocusEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnFocusReceived_InstanceFunctionAddress, intPtr, OnFocusReceived_ParamsSize);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnFocusReceived_ReturnValue_Offset), 0, OnFocusReceived_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnFocusReceived_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnFocusReceived_Implementation(FGeometry MyGeometry, FFocusEvent InFocusEvent)
	{
		CheckDestroyed();
		if (!OnFocusReceived_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnFocusReceived");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFocusReceived_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFocusReceived_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnFocusReceived_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnFocusReceived_MyGeometry_Offset), 0, OnFocusReceived_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnFocusReceived_InFocusEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FFocusEvent>.ToNative(IntPtr.Add(intPtr, OnFocusReceived_InFocusEvent_Offset), 0, OnFocusReceived_InFocusEvent_PropertyAddress.Address, InFocusEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnFocusReceived_FunctionAddress, intPtr, OnFocusReceived_ParamsSize);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnFocusReceived_ReturnValue_Offset), 0, OnFocusReceived_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnFocusReceived_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:OnFocusLost")]
	public unsafe void OnFocusLost(FFocusEvent InFocusEvent)
	{
		CheckDestroyed();
		if (!OnFocusLost_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnFocusLost");
			return;
		}
		if (OnFocusLost_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnFocusLost_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnFocusLost");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFocusLost_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFocusLost_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnFocusLost_InFocusEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FFocusEvent>.ToNative(IntPtr.Add(intPtr, OnFocusLost_InFocusEvent_Offset), 0, OnFocusLost_InFocusEvent_PropertyAddress.Address, InFocusEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnFocusLost_InstanceFunctionAddress, intPtr, OnFocusLost_ParamsSize);
	}

	protected unsafe virtual void OnFocusLost_Implementation(FFocusEvent InFocusEvent)
	{
		CheckDestroyed();
		if (!OnFocusLost_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnFocusLost");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnFocusLost_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnFocusLost_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnFocusLost_InFocusEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FFocusEvent>.ToNative(IntPtr.Add(intPtr, OnFocusLost_InFocusEvent_Offset), 0, OnFocusLost_InFocusEvent_PropertyAddress.Address, InFocusEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnFocusLost_FunctionAddress, intPtr, OnFocusLost_ParamsSize);
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:OnDrop")]
	public unsafe bool OnDrop(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation Operation)
	{
		CheckDestroyed();
		if (!OnDrop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnDrop");
			return false;
		}
		if (OnDrop_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnDrop_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnDrop");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDrop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDrop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnDrop_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnDrop_MyGeometry_Offset), 0, OnDrop_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnDrop_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnDrop_PointerEvent_Offset), 0, OnDrop_PointerEvent_PropertyAddress.Address, PointerEvent);
		UObjectMarshaler<UDragDropOperation>.ToNative(IntPtr.Add(intPtr, OnDrop_Operation_Offset), 0, OnDrop_Operation_PropertyAddress.Address, Operation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDrop_InstanceFunctionAddress, intPtr, OnDrop_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDrop_PointerEvent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnDrop_ReturnValue_Offset), 0, OnDrop_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool OnDrop_Implementation(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation Operation)
	{
		CheckDestroyed();
		if (!OnDrop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnDrop");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDrop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDrop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnDrop_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnDrop_MyGeometry_Offset), 0, OnDrop_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnDrop_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnDrop_PointerEvent_Offset), 0, OnDrop_PointerEvent_PropertyAddress.Address, PointerEvent);
		UObjectMarshaler<UDragDropOperation>.ToNative(IntPtr.Add(intPtr, OnDrop_Operation_Offset), 0, OnDrop_Operation_PropertyAddress.Address, Operation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDrop_FunctionAddress, intPtr, OnDrop_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDrop_PointerEvent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnDrop_ReturnValue_Offset), 0, OnDrop_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:OnDragOver")]
	public unsafe bool OnDragOver(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation Operation)
	{
		CheckDestroyed();
		if (!OnDragOver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnDragOver");
			return false;
		}
		if (OnDragOver_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnDragOver_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnDragOver");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDragOver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDragOver_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnDragOver_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnDragOver_MyGeometry_Offset), 0, OnDragOver_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnDragOver_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnDragOver_PointerEvent_Offset), 0, OnDragOver_PointerEvent_PropertyAddress.Address, PointerEvent);
		UObjectMarshaler<UDragDropOperation>.ToNative(IntPtr.Add(intPtr, OnDragOver_Operation_Offset), 0, OnDragOver_Operation_PropertyAddress.Address, Operation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDragOver_InstanceFunctionAddress, intPtr, OnDragOver_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDragOver_PointerEvent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnDragOver_ReturnValue_Offset), 0, OnDragOver_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool OnDragOver_Implementation(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation Operation)
	{
		CheckDestroyed();
		if (!OnDragOver_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnDragOver");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDragOver_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDragOver_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnDragOver_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnDragOver_MyGeometry_Offset), 0, OnDragOver_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnDragOver_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnDragOver_PointerEvent_Offset), 0, OnDragOver_PointerEvent_PropertyAddress.Address, PointerEvent);
		UObjectMarshaler<UDragDropOperation>.ToNative(IntPtr.Add(intPtr, OnDragOver_Operation_Offset), 0, OnDragOver_Operation_PropertyAddress.Address, Operation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDragOver_FunctionAddress, intPtr, OnDragOver_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDragOver_PointerEvent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnDragOver_ReturnValue_Offset), 0, OnDragOver_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:OnDragLeave")]
	public unsafe void OnDragLeave(FPointerEvent PointerEvent, UDragDropOperation Operation)
	{
		CheckDestroyed();
		if (!OnDragLeave_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnDragLeave");
			return;
		}
		if (OnDragLeave_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnDragLeave_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnDragLeave");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDragLeave_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDragLeave_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnDragLeave_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnDragLeave_PointerEvent_Offset), 0, OnDragLeave_PointerEvent_PropertyAddress.Address, PointerEvent);
		UObjectMarshaler<UDragDropOperation>.ToNative(IntPtr.Add(intPtr, OnDragLeave_Operation_Offset), 0, OnDragLeave_Operation_PropertyAddress.Address, Operation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDragLeave_InstanceFunctionAddress, intPtr, OnDragLeave_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDragLeave_PointerEvent_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnDragLeave_Implementation(FPointerEvent PointerEvent, UDragDropOperation Operation)
	{
		CheckDestroyed();
		if (!OnDragLeave_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnDragLeave");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDragLeave_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDragLeave_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnDragLeave_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnDragLeave_PointerEvent_Offset), 0, OnDragLeave_PointerEvent_PropertyAddress.Address, PointerEvent);
		UObjectMarshaler<UDragDropOperation>.ToNative(IntPtr.Add(intPtr, OnDragLeave_Operation_Offset), 0, OnDragLeave_Operation_PropertyAddress.Address, Operation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDragLeave_FunctionAddress, intPtr, OnDragLeave_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDragLeave_PointerEvent_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:OnDragEnter")]
	public unsafe void OnDragEnter(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation Operation)
	{
		CheckDestroyed();
		if (!OnDragEnter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnDragEnter");
			return;
		}
		if (OnDragEnter_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnDragEnter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnDragEnter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDragEnter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDragEnter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnDragEnter_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnDragEnter_MyGeometry_Offset), 0, OnDragEnter_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnDragEnter_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnDragEnter_PointerEvent_Offset), 0, OnDragEnter_PointerEvent_PropertyAddress.Address, PointerEvent);
		UObjectMarshaler<UDragDropOperation>.ToNative(IntPtr.Add(intPtr, OnDragEnter_Operation_Offset), 0, OnDragEnter_Operation_PropertyAddress.Address, Operation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDragEnter_InstanceFunctionAddress, intPtr, OnDragEnter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDragEnter_PointerEvent_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnDragEnter_Implementation(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation Operation)
	{
		CheckDestroyed();
		if (!OnDragEnter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnDragEnter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDragEnter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDragEnter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnDragEnter_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnDragEnter_MyGeometry_Offset), 0, OnDragEnter_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnDragEnter_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnDragEnter_PointerEvent_Offset), 0, OnDragEnter_PointerEvent_PropertyAddress.Address, PointerEvent);
		UObjectMarshaler<UDragDropOperation>.ToNative(IntPtr.Add(intPtr, OnDragEnter_Operation_Offset), 0, OnDragEnter_Operation_PropertyAddress.Address, Operation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDragEnter_FunctionAddress, intPtr, OnDragEnter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDragEnter_PointerEvent_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnDragDetected")]
	public unsafe void OnDragDetected(FGeometry MyGeometry, FPointerEvent PointerEvent, out UDragDropOperation Operation)
	{
		CheckDestroyed();
		if (!OnDragDetected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnDragDetected");
			Operation = null;
			return;
		}
		if (OnDragDetected_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnDragDetected_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnDragDetected");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDragDetected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDragDetected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnDragDetected_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnDragDetected_MyGeometry_Offset), 0, OnDragDetected_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnDragDetected_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnDragDetected_PointerEvent_Offset), 0, OnDragDetected_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDragDetected_InstanceFunctionAddress, intPtr, OnDragDetected_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDragDetected_PointerEvent_PropertyAddress.Address, intPtr);
		Operation = UObjectMarshaler<UDragDropOperation>.FromNative(IntPtr.Add(intPtr, OnDragDetected_Operation_Offset), 0, OnDragDetected_Operation_PropertyAddress.Address);
	}

	protected unsafe virtual void OnDragDetected_Implementation(FGeometry MyGeometry, FPointerEvent PointerEvent, out UDragDropOperation Operation)
	{
		CheckDestroyed();
		if (!OnDragDetected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnDragDetected");
			Operation = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDragDetected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDragDetected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnDragDetected_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnDragDetected_MyGeometry_Offset), 0, OnDragDetected_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnDragDetected_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnDragDetected_PointerEvent_Offset), 0, OnDragDetected_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDragDetected_FunctionAddress, intPtr, OnDragDetected_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDragDetected_PointerEvent_PropertyAddress.Address, intPtr);
		Operation = UObjectMarshaler<UDragDropOperation>.FromNative(IntPtr.Add(intPtr, OnDragDetected_Operation_Offset), 0, OnDragDetected_Operation_PropertyAddress.Address);
	}

	[UFunction(Flags = 138545160u)]
	[UMetaPath("/Script/UMG.UserWidget:OnDragCancelled")]
	public unsafe void OnDragCancelled(FPointerEvent PointerEvent, UDragDropOperation Operation)
	{
		CheckDestroyed();
		if (!OnDragCancelled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnDragCancelled");
			return;
		}
		if (OnDragCancelled_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnDragCancelled_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnDragCancelled");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDragCancelled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDragCancelled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnDragCancelled_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnDragCancelled_PointerEvent_Offset), 0, OnDragCancelled_PointerEvent_PropertyAddress.Address, PointerEvent);
		UObjectMarshaler<UDragDropOperation>.ToNative(IntPtr.Add(intPtr, OnDragCancelled_Operation_Offset), 0, OnDragCancelled_Operation_PropertyAddress.Address, Operation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDragCancelled_InstanceFunctionAddress, intPtr, OnDragCancelled_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDragCancelled_PointerEvent_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnDragCancelled_Implementation(FPointerEvent PointerEvent, UDragDropOperation Operation)
	{
		CheckDestroyed();
		if (!OnDragCancelled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnDragCancelled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDragCancelled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDragCancelled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnDragCancelled_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnDragCancelled_PointerEvent_Offset), 0, OnDragCancelled_PointerEvent_PropertyAddress.Address, PointerEvent);
		UObjectMarshaler<UDragDropOperation>.ToNative(IntPtr.Add(intPtr, OnDragCancelled_Operation_Offset), 0, OnDragCancelled_Operation_PropertyAddress.Address, Operation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnDragCancelled_FunctionAddress, intPtr, OnDragCancelled_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnDragCancelled_PointerEvent_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134745096u)]
	[UMetaPath("/Script/UMG.UserWidget:OnAnimationStarted")]
	protected unsafe void OnAnimationStarted(UWidgetAnimation Animation)
	{
		CheckDestroyed();
		if (!OnAnimationStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnAnimationStarted");
			return;
		}
		if (OnAnimationStarted_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnAnimationStarted_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnAnimationStarted");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAnimationStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAnimationStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, OnAnimationStarted_Animation_Offset), 0, OnAnimationStarted_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnAnimationStarted_InstanceFunctionAddress, intPtr, OnAnimationStarted_ParamsSize);
	}

	protected unsafe virtual void OnAnimationStarted_Implementation(UWidgetAnimation Animation)
	{
		CheckDestroyed();
		if (!OnAnimationStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnAnimationStarted");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAnimationStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAnimationStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, OnAnimationStarted_Animation_Offset), 0, OnAnimationStarted_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnAnimationStarted_FunctionAddress, intPtr, OnAnimationStarted_ParamsSize);
	}

	[UFunction(Flags = 134745096u)]
	[UMetaPath("/Script/UMG.UserWidget:OnAnimationFinished")]
	protected unsafe void OnAnimationFinished(UWidgetAnimation Animation)
	{
		CheckDestroyed();
		if (!OnAnimationFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnAnimationFinished");
			return;
		}
		if (OnAnimationFinished_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnAnimationFinished_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnAnimationFinished");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAnimationFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAnimationFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, OnAnimationFinished_Animation_Offset), 0, OnAnimationFinished_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnAnimationFinished_InstanceFunctionAddress, intPtr, OnAnimationFinished_ParamsSize);
	}

	protected unsafe virtual void OnAnimationFinished_Implementation(UWidgetAnimation Animation)
	{
		CheckDestroyed();
		if (!OnAnimationFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnAnimationFinished");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAnimationFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAnimationFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, OnAnimationFinished_Animation_Offset), 0, OnAnimationFinished_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnAnimationFinished_FunctionAddress, intPtr, OnAnimationFinished_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/UMG.UserWidget:OnAnalogValueChanged")]
	public unsafe FEventReply OnAnalogValueChanged(FGeometry MyGeometry, FAnalogInputEvent InAnalogInputEvent)
	{
		CheckDestroyed();
		if (!OnAnalogValueChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnAnalogValueChanged");
			return null;
		}
		if (OnAnalogValueChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnAnalogValueChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnAnalogValueChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAnalogValueChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAnalogValueChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnAnalogValueChanged_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnAnalogValueChanged_MyGeometry_Offset), 0, OnAnalogValueChanged_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnAnalogValueChanged_InAnalogInputEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnalogInputEvent>.ToNative(IntPtr.Add(intPtr, OnAnalogValueChanged_InAnalogInputEvent_Offset), 0, OnAnalogValueChanged_InAnalogInputEvent_PropertyAddress.Address, InAnalogInputEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnAnalogValueChanged_InstanceFunctionAddress, intPtr, OnAnalogValueChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnAnalogValueChanged_InAnalogInputEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnAnalogValueChanged_ReturnValue_Offset), 0, OnAnalogValueChanged_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnAnalogValueChanged_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual FEventReply OnAnalogValueChanged_Implementation(FGeometry MyGeometry, FAnalogInputEvent InAnalogInputEvent)
	{
		CheckDestroyed();
		if (!OnAnalogValueChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnAnalogValueChanged");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAnalogValueChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAnalogValueChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnAnalogValueChanged_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnAnalogValueChanged_MyGeometry_Offset), 0, OnAnalogValueChanged_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(OnAnalogValueChanged_InAnalogInputEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnalogInputEvent>.ToNative(IntPtr.Add(intPtr, OnAnalogValueChanged_InAnalogInputEvent_Offset), 0, OnAnalogValueChanged_InAnalogInputEvent_PropertyAddress.Address, InAnalogInputEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnAnalogValueChanged_FunctionAddress, intPtr, OnAnalogValueChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnAnalogValueChanged_InAnalogInputEvent_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnAnalogValueChanged_ReturnValue_Offset), 0, OnAnalogValueChanged_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OnAnalogValueChanged_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:OnAddedToFocusPath")]
	public unsafe void OnAddedToFocusPath(FFocusEvent InFocusEvent)
	{
		CheckDestroyed();
		if (!OnAddedToFocusPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnAddedToFocusPath");
			return;
		}
		if (OnAddedToFocusPath_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnAddedToFocusPath_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnAddedToFocusPath");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAddedToFocusPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAddedToFocusPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnAddedToFocusPath_InFocusEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FFocusEvent>.ToNative(IntPtr.Add(intPtr, OnAddedToFocusPath_InFocusEvent_Offset), 0, OnAddedToFocusPath_InFocusEvent_PropertyAddress.Address, InFocusEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnAddedToFocusPath_InstanceFunctionAddress, intPtr, OnAddedToFocusPath_ParamsSize);
	}

	protected unsafe virtual void OnAddedToFocusPath_Implementation(FFocusEvent InFocusEvent)
	{
		CheckDestroyed();
		if (!OnAddedToFocusPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:OnAddedToFocusPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAddedToFocusPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAddedToFocusPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnAddedToFocusPath_InFocusEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FFocusEvent>.ToNative(IntPtr.Add(intPtr, OnAddedToFocusPath_InFocusEvent_Offset), 0, OnAddedToFocusPath_InFocusEvent_PropertyAddress.Address, InFocusEvent);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnAddedToFocusPath_FunctionAddress, intPtr, OnAddedToFocusPath_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/UMG.UserWidget:ListenForInputAction")]
	protected unsafe void ListenForInputAction(FName ActionName, EInputEventType EventType, bool bConsume, FOnInputAction Callback)
	{
		CheckDestroyed();
		if (!ListenForInputAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:ListenForInputAction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ListenForInputAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ListenForInputAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ListenForInputAction_ActionName_Offset), 0, ListenForInputAction_ActionName_PropertyAddress.Address, ActionName);
		EnumMarshaler<EInputEventType>.ToNative(IntPtr.Add(intPtr, ListenForInputAction_EventType_Offset), 0, ListenForInputAction_EventType_PropertyAddress.Address, EventType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ListenForInputAction_bConsume_Offset), 0, ListenForInputAction_bConsume_PropertyAddress.Address, bConsume);
		FDelegateMarshaler<FOnInputAction>.ToNative(IntPtr.Add(intPtr, ListenForInputAction_Callback_Offset), 0, ListenForInputAction_Callback_PropertyAddress.Address, Callback);
		NativeReflection.InvokeFunctionOptimized(base.Address, ListenForInputAction_FunctionAddress, intPtr, ListenForInputAction_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.UserWidget:IsPlayingAnimation")]
	public unsafe bool IsPlayingAnimation()
	{
		CheckDestroyed();
		if (!IsPlayingAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:IsPlayingAnimation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlayingAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlayingAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlayingAnimation_FunctionAddress, intPtr, IsPlayingAnimation_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlayingAnimation_ReturnValue_Offset), 0, IsPlayingAnimation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409811457u)]
	[UMetaPath("/Script/UMG.UserWidget:IsListeningForInputAction")]
	protected unsafe bool IsListeningForInputAction(FName ActionName)
	{
		CheckDestroyed();
		if (!IsListeningForInputAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:IsListeningForInputAction");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsListeningForInputAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsListeningForInputAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsListeningForInputAction_ActionName_Offset), 0, IsListeningForInputAction_ActionName_PropertyAddress.Address, ActionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsListeningForInputAction_FunctionAddress, intPtr, IsListeningForInputAction_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsListeningForInputAction_ReturnValue_Offset), 0, IsListeningForInputAction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418249u)]
	[UMetaPath("/Script/UMG.UserWidget:IsInViewport")]
	public unsafe bool IsInViewport()
	{
		CheckDestroyed();
		if (!IsInViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:IsInViewport");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInViewport_FunctionAddress, intPtr, IsInViewport_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInViewport_ReturnValue_Offset), 0, IsInViewport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092680u)]
	[UMetaPath("/Script/UMG.UserWidget:IsInteractable")]
	public unsafe bool IsInteractable()
	{
		CheckDestroyed();
		if (!IsInteractable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:IsInteractable");
			return false;
		}
		if (IsInteractable_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsInteractable_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsInteractable");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInteractable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInteractable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInteractable_InstanceFunctionAddress, intPtr, IsInteractable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInteractable_ReturnValue_Offset), 0, IsInteractable_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsInteractable_Implementation()
	{
		CheckDestroyed();
		if (!IsInteractable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:IsInteractable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInteractable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInteractable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInteractable_FunctionAddress, intPtr, IsInteractable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInteractable_ReturnValue_Offset), 0, IsInteractable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418249u)]
	[UMetaPath("/Script/UMG.UserWidget:IsAnyAnimationPlaying")]
	public unsafe bool IsAnyAnimationPlaying()
	{
		CheckDestroyed();
		if (!IsAnyAnimationPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:IsAnyAnimationPlaying");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAnyAnimationPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAnyAnimationPlaying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsAnyAnimationPlaying_FunctionAddress, intPtr, IsAnyAnimationPlaying_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAnyAnimationPlaying_ReturnValue_Offset), 0, IsAnyAnimationPlaying_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:IsAnimationPlayingForward")]
	public unsafe bool IsAnimationPlayingForward(UWidgetAnimation InAnimation)
	{
		CheckDestroyed();
		if (!IsAnimationPlayingForward_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:IsAnimationPlayingForward");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAnimationPlayingForward_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAnimationPlayingForward_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, IsAnimationPlayingForward_InAnimation_Offset), 0, IsAnimationPlayingForward_InAnimation_PropertyAddress.Address, InAnimation);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsAnimationPlayingForward_FunctionAddress, intPtr, IsAnimationPlayingForward_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAnimationPlayingForward_ReturnValue_Offset), 0, IsAnimationPlayingForward_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418249u)]
	[UMetaPath("/Script/UMG.UserWidget:IsAnimationPlaying")]
	public unsafe bool IsAnimationPlaying(UWidgetAnimation InAnimation)
	{
		CheckDestroyed();
		if (!IsAnimationPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:IsAnimationPlaying");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAnimationPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAnimationPlaying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, IsAnimationPlaying_InAnimation_Offset), 0, IsAnimationPlaying_InAnimation_PropertyAddress.Address, InAnimation);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsAnimationPlaying_FunctionAddress, intPtr, IsAnimationPlaying_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAnimationPlaying_ReturnValue_Offset), 0, IsAnimationPlaying_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418249u)]
	[UMetaPath("/Script/UMG.UserWidget:GetOwningPlayerPawn")]
	public unsafe APawn GetOwningPlayerPawn()
	{
		CheckDestroyed();
		if (!GetOwningPlayerPawn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:GetOwningPlayerPawn");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwningPlayerPawn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwningPlayerPawn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOwningPlayerPawn_FunctionAddress, intPtr, GetOwningPlayerPawn_ParamsSize);
		return UObjectMarshaler<APawn>.FromNative(IntPtr.Add(intPtr, GetOwningPlayerPawn_ReturnValue_Offset), 0, GetOwningPlayerPawn_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418249u)]
	[UMetaPath("/Script/UMG.UserWidget:GetOwningPlayerCameraManager")]
	public unsafe APlayerCameraManager GetOwningPlayerCameraManager()
	{
		CheckDestroyed();
		if (!GetOwningPlayerCameraManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:GetOwningPlayerCameraManager");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwningPlayerCameraManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwningPlayerCameraManager_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOwningPlayerCameraManager_FunctionAddress, intPtr, GetOwningPlayerCameraManager_ParamsSize);
		return UObjectMarshaler<APlayerCameraManager>.FromNative(IntPtr.Add(intPtr, GetOwningPlayerCameraManager_ReturnValue_Offset), 0, GetOwningPlayerCameraManager_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418249u)]
	[UMetaPath("/Script/UMG.UserWidget:GetAnimationCurrentTime")]
	public unsafe float GetAnimationCurrentTime(UWidgetAnimation InAnimation)
	{
		CheckDestroyed();
		if (!GetAnimationCurrentTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:GetAnimationCurrentTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationCurrentTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationCurrentTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, GetAnimationCurrentTime_InAnimation_Offset), 0, GetAnimationCurrentTime_InAnimation_PropertyAddress.Address, InAnimation);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnimationCurrentTime_FunctionAddress, intPtr, GetAnimationCurrentTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAnimationCurrentTime_ReturnValue_Offset), 0, GetAnimationCurrentTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418249u)]
	[UMetaPath("/Script/UMG.UserWidget:GetAnchorsInViewport")]
	public unsafe FAnchors GetAnchorsInViewport()
	{
		CheckDestroyed();
		if (!GetAnchorsInViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:GetAnchorsInViewport");
			return default(FAnchors);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnchorsInViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnchorsInViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnchorsInViewport_FunctionAddress, intPtr, GetAnchorsInViewport_ParamsSize);
		return FAnchors.FromNative(IntPtr.Add(intPtr, GetAnchorsInViewport_ReturnValue_Offset), 0, GetAnchorsInViewport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806857u)]
	[UMetaPath("/Script/UMG.UserWidget:GetAlignmentInViewport")]
	public unsafe FVector2D GetAlignmentInViewport()
	{
		CheckDestroyed();
		if (!GetAlignmentInViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:GetAlignmentInViewport");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAlignmentInViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAlignmentInViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAlignmentInViewport_FunctionAddress, intPtr, GetAlignmentInViewport_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetAlignmentInViewport_ReturnValue_Offset), 0, GetAlignmentInViewport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:FlushAnimations")]
	public unsafe void FlushAnimations()
	{
		CheckDestroyed();
		if (!FlushAnimations_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:FlushAnimations");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FlushAnimations_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FlushAnimations_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FlushAnimations_FunctionAddress, argsSize: FlushAnimations_ParamsSize);
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:Destruct")]
	public unsafe void Destruct()
	{
		CheckDestroyed();
		if (!Destruct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:Destruct");
			return;
		}
		if (Destruct_InstanceFunctionAddress == IntPtr.Zero)
		{
			Destruct_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Destruct");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destruct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destruct_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destruct_InstanceFunctionAddress, argsSize: Destruct_ParamsSize);
	}

	protected unsafe virtual void Destruct_Implementation()
	{
		CheckDestroyed();
		if (!Destruct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:Destruct");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Destruct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Destruct_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Destruct_FunctionAddress, argsSize: Destruct_ParamsSize);
	}

	[UFunction(Flags = 134350856u)]
	[UMetaPath("/Script/UMG.UserWidget:Construct")]
	public unsafe void Construct()
	{
		CheckDestroyed();
		if (!Construct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:Construct");
			return;
		}
		if (Construct_InstanceFunctionAddress == IntPtr.Zero)
		{
			Construct_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Construct");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Construct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Construct_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Construct_InstanceFunctionAddress, argsSize: Construct_ParamsSize);
	}

	protected unsafe virtual void Construct_Implementation()
	{
		CheckDestroyed();
		if (!Construct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:Construct");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Construct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Construct_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Construct_FunctionAddress, argsSize: Construct_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UserWidget:CancelLatentActions")]
	public unsafe void CancelLatentActions()
	{
		CheckDestroyed();
		if (!CancelLatentActions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:CancelLatentActions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CancelLatentActions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CancelLatentActions_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CancelLatentActions_FunctionAddress, argsSize: CancelLatentActions_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UserWidget:BindToAnimationStarted")]
	public unsafe void BindToAnimationStarted(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate)
	{
		CheckDestroyed();
		if (!BindToAnimationStarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:BindToAnimationStarted");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BindToAnimationStarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BindToAnimationStarted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, BindToAnimationStarted_Animation_Offset), 0, BindToAnimationStarted_Animation_PropertyAddress.Address, Animation);
		FDelegateMarshaler<FWidgetAnimationDynamicEvent>.ToNative(IntPtr.Add(intPtr, BindToAnimationStarted_Delegate_Offset), 0, BindToAnimationStarted_Delegate_PropertyAddress.Address, Delegate);
		NativeReflection.InvokeFunctionOptimized(base.Address, BindToAnimationStarted_FunctionAddress, intPtr, BindToAnimationStarted_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UserWidget:BindToAnimationFinished")]
	public unsafe void BindToAnimationFinished(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate)
	{
		CheckDestroyed();
		if (!BindToAnimationFinished_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:BindToAnimationFinished");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BindToAnimationFinished_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BindToAnimationFinished_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, BindToAnimationFinished_Animation_Offset), 0, BindToAnimationFinished_Animation_PropertyAddress.Address, Animation);
		FDelegateMarshaler<FWidgetAnimationDynamicEvent>.ToNative(IntPtr.Add(intPtr, BindToAnimationFinished_Delegate_Offset), 0, BindToAnimationFinished_Delegate_PropertyAddress.Address, Delegate);
		NativeReflection.InvokeFunctionOptimized(base.Address, BindToAnimationFinished_FunctionAddress, intPtr, BindToAnimationFinished_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UserWidget:BindToAnimationEvent")]
	public unsafe void BindToAnimationEvent(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate, EWidgetAnimationEvent AnimationEvent, FName UserTag)
	{
		CheckDestroyed();
		if (!BindToAnimationEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:BindToAnimationEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BindToAnimationEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BindToAnimationEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, BindToAnimationEvent_Animation_Offset), 0, BindToAnimationEvent_Animation_PropertyAddress.Address, Animation);
		FDelegateMarshaler<FWidgetAnimationDynamicEvent>.ToNative(IntPtr.Add(intPtr, BindToAnimationEvent_Delegate_Offset), 0, BindToAnimationEvent_Delegate_PropertyAddress.Address, Delegate);
		EnumMarshaler<EWidgetAnimationEvent>.ToNative(IntPtr.Add(intPtr, BindToAnimationEvent_AnimationEvent_Offset), 0, BindToAnimationEvent_AnimationEvent_PropertyAddress.Address, AnimationEvent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BindToAnimationEvent_UserTag_Offset), 0, BindToAnimationEvent_UserTag_PropertyAddress.Address, UserTag);
		NativeReflection.InvokeFunctionOptimized(base.Address, BindToAnimationEvent_FunctionAddress, intPtr, BindToAnimationEvent_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:AddToViewport")]
	public unsafe void AddToViewport(int ZOrder = 0)
	{
		CheckDestroyed();
		if (!AddToViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:AddToViewport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddToViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddToViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddToViewport_ZOrder_Offset), 0, AddToViewport_ZOrder_PropertyAddress.Address, ZOrder);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddToViewport_FunctionAddress, intPtr, AddToViewport_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/UMG.UserWidget:AddToPlayerScreen")]
	public unsafe bool AddToPlayerScreen(int ZOrder = 0)
	{
		CheckDestroyed();
		if (!AddToPlayerScreen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UserWidget:AddToPlayerScreen");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddToPlayerScreen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddToPlayerScreen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddToPlayerScreen_ZOrder_Offset), 0, AddToPlayerScreen_ZOrder_PropertyAddress.Address, ZOrder);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddToPlayerScreen_FunctionAddress, intPtr, AddToPlayerScreen_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddToPlayerScreen_ReturnValue_Offset), 0, AddToPlayerScreen_ReturnValue_PropertyAddress.Address);
	}

	static UUserWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UUserWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UUserWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.UserWidget");
		ColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColorAndOpacity");
		ColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColorAndOpacity", Classes.FStructProperty);
		ForegroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForegroundColor");
		ForegroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForegroundColor", Classes.FStructProperty);
		OnVisibilityChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnVisibilityChanged");
		OnVisibilityChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnVisibilityChanged", Classes.FMulticastDelegateProperty);
		Padding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Padding");
		Padding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Padding", Classes.FStructProperty);
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Priority", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref IsFocusable_PropertyAddress, intPtr, "bIsFocusable");
		IsFocusable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsFocusable");
		IsFocusable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsFocusable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StopAction_PropertyAddress, intPtr, "bStopAction");
		StopAction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStopAction");
		StopAction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStopAction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TickFrequency_PropertyAddress, intPtr, "TickFrequency");
		TickFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TickFrequency");
		TickFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TickFrequency", Classes.FEnumProperty);
		UnregisterInputComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnregisterInputComponent");
		UnregisterInputComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterInputComponent_FunctionAddress);
		UnregisterInputComponent_IsValid = UnregisterInputComponent_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:UnregisterInputComponent", UnregisterInputComponent_IsValid);
		UnbindFromAnimationStarted_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnbindFromAnimationStarted");
		UnbindFromAnimationStarted_ParamsSize = NativeReflection.GetFunctionParamsSize(UnbindFromAnimationStarted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnbindFromAnimationStarted_Animation_PropertyAddress, UnbindFromAnimationStarted_FunctionAddress, "Animation");
		UnbindFromAnimationStarted_Animation_Offset = NativeReflectionCached.GetPropertyOffset(UnbindFromAnimationStarted_FunctionAddress, "Animation");
		UnbindFromAnimationStarted_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(UnbindFromAnimationStarted_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UnbindFromAnimationStarted_Delegate_PropertyAddress, UnbindFromAnimationStarted_FunctionAddress, "Delegate");
		UnbindFromAnimationStarted_Delegate_Offset = NativeReflectionCached.GetPropertyOffset(UnbindFromAnimationStarted_FunctionAddress, "Delegate");
		UnbindFromAnimationStarted_Delegate_IsValid = NativeReflectionCached.ValidatePropertyClass(UnbindFromAnimationStarted_FunctionAddress, "Delegate", Classes.FDelegateProperty);
		UnbindFromAnimationStarted_IsValid = UnbindFromAnimationStarted_FunctionAddress != IntPtr.Zero && UnbindFromAnimationStarted_Animation_IsValid && UnbindFromAnimationStarted_Delegate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:UnbindFromAnimationStarted", UnbindFromAnimationStarted_IsValid);
		UnbindFromAnimationFinished_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnbindFromAnimationFinished");
		UnbindFromAnimationFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(UnbindFromAnimationFinished_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnbindFromAnimationFinished_Animation_PropertyAddress, UnbindFromAnimationFinished_FunctionAddress, "Animation");
		UnbindFromAnimationFinished_Animation_Offset = NativeReflectionCached.GetPropertyOffset(UnbindFromAnimationFinished_FunctionAddress, "Animation");
		UnbindFromAnimationFinished_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(UnbindFromAnimationFinished_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UnbindFromAnimationFinished_Delegate_PropertyAddress, UnbindFromAnimationFinished_FunctionAddress, "Delegate");
		UnbindFromAnimationFinished_Delegate_Offset = NativeReflectionCached.GetPropertyOffset(UnbindFromAnimationFinished_FunctionAddress, "Delegate");
		UnbindFromAnimationFinished_Delegate_IsValid = NativeReflectionCached.ValidatePropertyClass(UnbindFromAnimationFinished_FunctionAddress, "Delegate", Classes.FDelegateProperty);
		UnbindFromAnimationFinished_IsValid = UnbindFromAnimationFinished_FunctionAddress != IntPtr.Zero && UnbindFromAnimationFinished_Animation_IsValid && UnbindFromAnimationFinished_Delegate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:UnbindFromAnimationFinished", UnbindFromAnimationFinished_IsValid);
		UnbindAllFromAnimationStarted_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnbindAllFromAnimationStarted");
		UnbindAllFromAnimationStarted_ParamsSize = NativeReflection.GetFunctionParamsSize(UnbindAllFromAnimationStarted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnbindAllFromAnimationStarted_Animation_PropertyAddress, UnbindAllFromAnimationStarted_FunctionAddress, "Animation");
		UnbindAllFromAnimationStarted_Animation_Offset = NativeReflectionCached.GetPropertyOffset(UnbindAllFromAnimationStarted_FunctionAddress, "Animation");
		UnbindAllFromAnimationStarted_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(UnbindAllFromAnimationStarted_FunctionAddress, "Animation", Classes.FObjectProperty);
		UnbindAllFromAnimationStarted_IsValid = UnbindAllFromAnimationStarted_FunctionAddress != IntPtr.Zero && UnbindAllFromAnimationStarted_Animation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:UnbindAllFromAnimationStarted", UnbindAllFromAnimationStarted_IsValid);
		UnbindAllFromAnimationFinished_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnbindAllFromAnimationFinished");
		UnbindAllFromAnimationFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(UnbindAllFromAnimationFinished_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnbindAllFromAnimationFinished_Animation_PropertyAddress, UnbindAllFromAnimationFinished_FunctionAddress, "Animation");
		UnbindAllFromAnimationFinished_Animation_Offset = NativeReflectionCached.GetPropertyOffset(UnbindAllFromAnimationFinished_FunctionAddress, "Animation");
		UnbindAllFromAnimationFinished_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(UnbindAllFromAnimationFinished_FunctionAddress, "Animation", Classes.FObjectProperty);
		UnbindAllFromAnimationFinished_IsValid = UnbindAllFromAnimationFinished_FunctionAddress != IntPtr.Zero && UnbindAllFromAnimationFinished_Animation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:UnbindAllFromAnimationFinished", UnbindAllFromAnimationFinished_IsValid);
		Tick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Tick");
		Tick_ParamsSize = NativeReflection.GetFunctionParamsSize(Tick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Tick_MyGeometry_PropertyAddress, Tick_FunctionAddress, "MyGeometry");
		Tick_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(Tick_FunctionAddress, "MyGeometry");
		Tick_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(Tick_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Tick_InDeltaTime_PropertyAddress, Tick_FunctionAddress, "InDeltaTime");
		Tick_InDeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(Tick_FunctionAddress, "InDeltaTime");
		Tick_InDeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(Tick_FunctionAddress, "InDeltaTime", Classes.FFloatProperty);
		Tick_IsValid = Tick_FunctionAddress != IntPtr.Zero && Tick_MyGeometry_IsValid && Tick_InDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:Tick", Tick_IsValid);
		StopListeningForInputAction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopListeningForInputAction");
		StopListeningForInputAction_ParamsSize = NativeReflection.GetFunctionParamsSize(StopListeningForInputAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopListeningForInputAction_ActionName_PropertyAddress, StopListeningForInputAction_FunctionAddress, "ActionName");
		StopListeningForInputAction_ActionName_Offset = NativeReflectionCached.GetPropertyOffset(StopListeningForInputAction_FunctionAddress, "ActionName");
		StopListeningForInputAction_ActionName_IsValid = NativeReflectionCached.ValidatePropertyClass(StopListeningForInputAction_FunctionAddress, "ActionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref StopListeningForInputAction_EventType_PropertyAddress, StopListeningForInputAction_FunctionAddress, "EventType");
		StopListeningForInputAction_EventType_Offset = NativeReflectionCached.GetPropertyOffset(StopListeningForInputAction_FunctionAddress, "EventType");
		StopListeningForInputAction_EventType_IsValid = NativeReflectionCached.ValidatePropertyClass(StopListeningForInputAction_FunctionAddress, "EventType", Classes.FByteProperty);
		StopListeningForInputAction_IsValid = StopListeningForInputAction_FunctionAddress != IntPtr.Zero && StopListeningForInputAction_ActionName_IsValid && StopListeningForInputAction_EventType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:StopListeningForInputAction", StopListeningForInputAction_IsValid);
		StopListeningForAllInputActions_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopListeningForAllInputActions");
		StopListeningForAllInputActions_ParamsSize = NativeReflection.GetFunctionParamsSize(StopListeningForAllInputActions_FunctionAddress);
		StopListeningForAllInputActions_IsValid = StopListeningForAllInputActions_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:StopListeningForAllInputActions", StopListeningForAllInputActions_IsValid);
		StopAnimationsAndLatentActions_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAnimationsAndLatentActions");
		StopAnimationsAndLatentActions_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAnimationsAndLatentActions_FunctionAddress);
		StopAnimationsAndLatentActions_IsValid = StopAnimationsAndLatentActions_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:StopAnimationsAndLatentActions", StopAnimationsAndLatentActions_IsValid);
		StopAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAnimation");
		StopAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAnimation_InAnimation_PropertyAddress, StopAnimation_FunctionAddress, "InAnimation");
		StopAnimation_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(StopAnimation_FunctionAddress, "InAnimation");
		StopAnimation_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAnimation_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		StopAnimation_IsValid = StopAnimation_FunctionAddress != IntPtr.Zero && StopAnimation_InAnimation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:StopAnimation", StopAnimation_IsValid);
		StopAllAnimations_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAllAnimations");
		StopAllAnimations_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAllAnimations_FunctionAddress);
		StopAllAnimations_IsValid = StopAllAnimations_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:StopAllAnimations", StopAllAnimations_IsValid);
		SetPositionInViewport_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPositionInViewport");
		SetPositionInViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPositionInViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPositionInViewport_Position_PropertyAddress, SetPositionInViewport_FunctionAddress, "Position");
		SetPositionInViewport_Position_Offset = NativeReflectionCached.GetPropertyOffset(SetPositionInViewport_FunctionAddress, "Position");
		SetPositionInViewport_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPositionInViewport_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPositionInViewport_bRemoveDPIScale_PropertyAddress, SetPositionInViewport_FunctionAddress, "bRemoveDPIScale");
		SetPositionInViewport_bRemoveDPIScale_Offset = NativeReflectionCached.GetPropertyOffset(SetPositionInViewport_FunctionAddress, "bRemoveDPIScale");
		SetPositionInViewport_bRemoveDPIScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPositionInViewport_FunctionAddress, "bRemoveDPIScale", Classes.FBoolProperty);
		SetPositionInViewport_IsValid = SetPositionInViewport_FunctionAddress != IntPtr.Zero && SetPositionInViewport_Position_IsValid && SetPositionInViewport_bRemoveDPIScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:SetPositionInViewport", SetPositionInViewport_IsValid);
		SetPlaybackSpeed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlaybackSpeed");
		SetPlaybackSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaybackSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackSpeed_InAnimation_PropertyAddress, SetPlaybackSpeed_FunctionAddress, "InAnimation");
		SetPlaybackSpeed_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackSpeed_FunctionAddress, "InAnimation");
		SetPlaybackSpeed_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackSpeed_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackSpeed_PlaybackSpeed_PropertyAddress, SetPlaybackSpeed_FunctionAddress, "PlaybackSpeed");
		SetPlaybackSpeed_PlaybackSpeed_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackSpeed_FunctionAddress, "PlaybackSpeed");
		SetPlaybackSpeed_PlaybackSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackSpeed_FunctionAddress, "PlaybackSpeed", Classes.FFloatProperty);
		SetPlaybackSpeed_IsValid = SetPlaybackSpeed_FunctionAddress != IntPtr.Zero && SetPlaybackSpeed_InAnimation_IsValid && SetPlaybackSpeed_PlaybackSpeed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:SetPlaybackSpeed", SetPlaybackSpeed_IsValid);
		SetPadding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPadding");
		SetPadding_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPadding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPadding_InPadding_PropertyAddress, SetPadding_FunctionAddress, "InPadding");
		SetPadding_InPadding_Offset = NativeReflectionCached.GetPropertyOffset(SetPadding_FunctionAddress, "InPadding");
		SetPadding_InPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPadding_FunctionAddress, "InPadding", Classes.FStructProperty);
		SetPadding_IsValid = SetPadding_FunctionAddress != IntPtr.Zero && SetPadding_InPadding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:SetPadding", SetPadding_IsValid);
		SetOwningPlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOwningPlayer");
		SetOwningPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOwningPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOwningPlayer_LocalPlayerController_PropertyAddress, SetOwningPlayer_FunctionAddress, "LocalPlayerController");
		SetOwningPlayer_LocalPlayerController_Offset = NativeReflectionCached.GetPropertyOffset(SetOwningPlayer_FunctionAddress, "LocalPlayerController");
		SetOwningPlayer_LocalPlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOwningPlayer_FunctionAddress, "LocalPlayerController", Classes.FObjectProperty);
		SetOwningPlayer_IsValid = SetOwningPlayer_FunctionAddress != IntPtr.Zero && SetOwningPlayer_LocalPlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:SetOwningPlayer", SetOwningPlayer_IsValid);
		SetNumLoopsToPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNumLoopsToPlay");
		SetNumLoopsToPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNumLoopsToPlay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNumLoopsToPlay_InAnimation_PropertyAddress, SetNumLoopsToPlay_FunctionAddress, "InAnimation");
		SetNumLoopsToPlay_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(SetNumLoopsToPlay_FunctionAddress, "InAnimation");
		SetNumLoopsToPlay_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumLoopsToPlay_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNumLoopsToPlay_NumLoopsToPlay_PropertyAddress, SetNumLoopsToPlay_FunctionAddress, "NumLoopsToPlay");
		SetNumLoopsToPlay_NumLoopsToPlay_Offset = NativeReflectionCached.GetPropertyOffset(SetNumLoopsToPlay_FunctionAddress, "NumLoopsToPlay");
		SetNumLoopsToPlay_NumLoopsToPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumLoopsToPlay_FunctionAddress, "NumLoopsToPlay", Classes.FIntProperty);
		SetNumLoopsToPlay_IsValid = SetNumLoopsToPlay_FunctionAddress != IntPtr.Zero && SetNumLoopsToPlay_InAnimation_IsValid && SetNumLoopsToPlay_NumLoopsToPlay_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:SetNumLoopsToPlay", SetNumLoopsToPlay_IsValid);
		SetInputActionPriority_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInputActionPriority");
		SetInputActionPriority_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInputActionPriority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInputActionPriority_NewPriority_PropertyAddress, SetInputActionPriority_FunctionAddress, "NewPriority");
		SetInputActionPriority_NewPriority_Offset = NativeReflectionCached.GetPropertyOffset(SetInputActionPriority_FunctionAddress, "NewPriority");
		SetInputActionPriority_NewPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputActionPriority_FunctionAddress, "NewPriority", Classes.FIntProperty);
		SetInputActionPriority_IsValid = SetInputActionPriority_FunctionAddress != IntPtr.Zero && SetInputActionPriority_NewPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:SetInputActionPriority", SetInputActionPriority_IsValid);
		SetInputActionBlocking_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInputActionBlocking");
		SetInputActionBlocking_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInputActionBlocking_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInputActionBlocking_bShouldBlock_PropertyAddress, SetInputActionBlocking_FunctionAddress, "bShouldBlock");
		SetInputActionBlocking_bShouldBlock_Offset = NativeReflectionCached.GetPropertyOffset(SetInputActionBlocking_FunctionAddress, "bShouldBlock");
		SetInputActionBlocking_bShouldBlock_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputActionBlocking_FunctionAddress, "bShouldBlock", Classes.FBoolProperty);
		SetInputActionBlocking_IsValid = SetInputActionBlocking_FunctionAddress != IntPtr.Zero && SetInputActionBlocking_bShouldBlock_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:SetInputActionBlocking", SetInputActionBlocking_IsValid);
		SetForegroundColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForegroundColor");
		SetForegroundColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForegroundColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForegroundColor_InForegroundColor_PropertyAddress, SetForegroundColor_FunctionAddress, "InForegroundColor");
		SetForegroundColor_InForegroundColor_Offset = NativeReflectionCached.GetPropertyOffset(SetForegroundColor_FunctionAddress, "InForegroundColor");
		SetForegroundColor_InForegroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForegroundColor_FunctionAddress, "InForegroundColor", Classes.FStructProperty);
		SetForegroundColor_IsValid = SetForegroundColor_FunctionAddress != IntPtr.Zero && SetForegroundColor_InForegroundColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:SetForegroundColor", SetForegroundColor_IsValid);
		SetDesiredSizeInViewport_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDesiredSizeInViewport");
		SetDesiredSizeInViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDesiredSizeInViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDesiredSizeInViewport_Size_PropertyAddress, SetDesiredSizeInViewport_FunctionAddress, "Size");
		SetDesiredSizeInViewport_Size_Offset = NativeReflectionCached.GetPropertyOffset(SetDesiredSizeInViewport_FunctionAddress, "Size");
		SetDesiredSizeInViewport_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDesiredSizeInViewport_FunctionAddress, "Size", Classes.FStructProperty);
		SetDesiredSizeInViewport_IsValid = SetDesiredSizeInViewport_FunctionAddress != IntPtr.Zero && SetDesiredSizeInViewport_Size_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:SetDesiredSizeInViewport", SetDesiredSizeInViewport_IsValid);
		SetColorAndOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetColorAndOpacity");
		SetColorAndOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetColorAndOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetColorAndOpacity_InColorAndOpacity_PropertyAddress, SetColorAndOpacity_FunctionAddress, "InColorAndOpacity");
		SetColorAndOpacity_InColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(SetColorAndOpacity_FunctionAddress, "InColorAndOpacity");
		SetColorAndOpacity_InColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorAndOpacity_FunctionAddress, "InColorAndOpacity", Classes.FStructProperty);
		SetColorAndOpacity_IsValid = SetColorAndOpacity_FunctionAddress != IntPtr.Zero && SetColorAndOpacity_InColorAndOpacity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:SetColorAndOpacity", SetColorAndOpacity_IsValid);
		SetAnimationCurrentTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAnimationCurrentTime");
		SetAnimationCurrentTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimationCurrentTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationCurrentTime_InAnimation_PropertyAddress, SetAnimationCurrentTime_FunctionAddress, "InAnimation");
		SetAnimationCurrentTime_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationCurrentTime_FunctionAddress, "InAnimation");
		SetAnimationCurrentTime_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationCurrentTime_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimationCurrentTime_InTime_PropertyAddress, SetAnimationCurrentTime_FunctionAddress, "InTime");
		SetAnimationCurrentTime_InTime_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimationCurrentTime_FunctionAddress, "InTime");
		SetAnimationCurrentTime_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimationCurrentTime_FunctionAddress, "InTime", Classes.FFloatProperty);
		SetAnimationCurrentTime_IsValid = SetAnimationCurrentTime_FunctionAddress != IntPtr.Zero && SetAnimationCurrentTime_InAnimation_IsValid && SetAnimationCurrentTime_InTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:SetAnimationCurrentTime", SetAnimationCurrentTime_IsValid);
		SetAnchorsInViewport_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAnchorsInViewport");
		SetAnchorsInViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnchorsInViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnchorsInViewport_Anchors_PropertyAddress, SetAnchorsInViewport_FunctionAddress, "Anchors");
		SetAnchorsInViewport_Anchors_Offset = NativeReflectionCached.GetPropertyOffset(SetAnchorsInViewport_FunctionAddress, "Anchors");
		SetAnchorsInViewport_Anchors_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnchorsInViewport_FunctionAddress, "Anchors", Classes.FStructProperty);
		SetAnchorsInViewport_IsValid = SetAnchorsInViewport_FunctionAddress != IntPtr.Zero && SetAnchorsInViewport_Anchors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:SetAnchorsInViewport", SetAnchorsInViewport_IsValid);
		SetAlignmentInViewport_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAlignmentInViewport");
		SetAlignmentInViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAlignmentInViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAlignmentInViewport_Alignment_PropertyAddress, SetAlignmentInViewport_FunctionAddress, "Alignment");
		SetAlignmentInViewport_Alignment_Offset = NativeReflectionCached.GetPropertyOffset(SetAlignmentInViewport_FunctionAddress, "Alignment");
		SetAlignmentInViewport_Alignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlignmentInViewport_FunctionAddress, "Alignment", Classes.FStructProperty);
		SetAlignmentInViewport_IsValid = SetAlignmentInViewport_FunctionAddress != IntPtr.Zero && SetAlignmentInViewport_Alignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:SetAlignmentInViewport", SetAlignmentInViewport_IsValid);
		ReverseAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReverseAnimation");
		ReverseAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(ReverseAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReverseAnimation_InAnimation_PropertyAddress, ReverseAnimation_FunctionAddress, "InAnimation");
		ReverseAnimation_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(ReverseAnimation_FunctionAddress, "InAnimation");
		ReverseAnimation_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(ReverseAnimation_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		ReverseAnimation_IsValid = ReverseAnimation_FunctionAddress != IntPtr.Zero && ReverseAnimation_InAnimation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:ReverseAnimation", ReverseAnimation_IsValid);
		RegisterInputComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RegisterInputComponent");
		RegisterInputComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterInputComponent_FunctionAddress);
		RegisterInputComponent_IsValid = RegisterInputComponent_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:RegisterInputComponent", RegisterInputComponent_IsValid);
		PreConstruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreConstruct");
		PreConstruct_ParamsSize = NativeReflection.GetFunctionParamsSize(PreConstruct_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PreConstruct_IsDesignTime_PropertyAddress, PreConstruct_FunctionAddress, "IsDesignTime");
		PreConstruct_IsDesignTime_Offset = NativeReflectionCached.GetPropertyOffset(PreConstruct_FunctionAddress, "IsDesignTime");
		PreConstruct_IsDesignTime_IsValid = NativeReflectionCached.ValidatePropertyClass(PreConstruct_FunctionAddress, "IsDesignTime", Classes.FBoolProperty);
		PreConstruct_IsValid = PreConstruct_FunctionAddress != IntPtr.Zero && PreConstruct_IsDesignTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:PreConstruct", PreConstruct_IsValid);
		PlayAnimationTimeRange_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayAnimationTimeRange");
		PlayAnimationTimeRange_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayAnimationTimeRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationTimeRange_InAnimation_PropertyAddress, PlayAnimationTimeRange_FunctionAddress, "InAnimation");
		PlayAnimationTimeRange_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationTimeRange_FunctionAddress, "InAnimation");
		PlayAnimationTimeRange_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationTimeRange_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationTimeRange_StartAtTime_PropertyAddress, PlayAnimationTimeRange_FunctionAddress, "StartAtTime");
		PlayAnimationTimeRange_StartAtTime_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationTimeRange_FunctionAddress, "StartAtTime");
		PlayAnimationTimeRange_StartAtTime_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationTimeRange_FunctionAddress, "StartAtTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationTimeRange_EndAtTime_PropertyAddress, PlayAnimationTimeRange_FunctionAddress, "EndAtTime");
		PlayAnimationTimeRange_EndAtTime_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationTimeRange_FunctionAddress, "EndAtTime");
		PlayAnimationTimeRange_EndAtTime_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationTimeRange_FunctionAddress, "EndAtTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationTimeRange_NumLoopsToPlay_PropertyAddress, PlayAnimationTimeRange_FunctionAddress, "NumLoopsToPlay");
		PlayAnimationTimeRange_NumLoopsToPlay_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationTimeRange_FunctionAddress, "NumLoopsToPlay");
		PlayAnimationTimeRange_NumLoopsToPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationTimeRange_FunctionAddress, "NumLoopsToPlay", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationTimeRange_PlayMode_PropertyAddress, PlayAnimationTimeRange_FunctionAddress, "PlayMode");
		PlayAnimationTimeRange_PlayMode_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationTimeRange_FunctionAddress, "PlayMode");
		PlayAnimationTimeRange_PlayMode_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationTimeRange_FunctionAddress, "PlayMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationTimeRange_PlaybackSpeed_PropertyAddress, PlayAnimationTimeRange_FunctionAddress, "PlaybackSpeed");
		PlayAnimationTimeRange_PlaybackSpeed_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationTimeRange_FunctionAddress, "PlaybackSpeed");
		PlayAnimationTimeRange_PlaybackSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationTimeRange_FunctionAddress, "PlaybackSpeed", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationTimeRange_bRestoreState_PropertyAddress, PlayAnimationTimeRange_FunctionAddress, "bRestoreState");
		PlayAnimationTimeRange_bRestoreState_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationTimeRange_FunctionAddress, "bRestoreState");
		PlayAnimationTimeRange_bRestoreState_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationTimeRange_FunctionAddress, "bRestoreState", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationTimeRange_ReturnValue_PropertyAddress, PlayAnimationTimeRange_FunctionAddress, "ReturnValue");
		PlayAnimationTimeRange_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationTimeRange_FunctionAddress, "ReturnValue");
		PlayAnimationTimeRange_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationTimeRange_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		PlayAnimationTimeRange_IsValid = PlayAnimationTimeRange_FunctionAddress != IntPtr.Zero && PlayAnimationTimeRange_InAnimation_IsValid && PlayAnimationTimeRange_StartAtTime_IsValid && PlayAnimationTimeRange_EndAtTime_IsValid && PlayAnimationTimeRange_NumLoopsToPlay_IsValid && PlayAnimationTimeRange_PlayMode_IsValid && PlayAnimationTimeRange_PlaybackSpeed_IsValid && PlayAnimationTimeRange_bRestoreState_IsValid && PlayAnimationTimeRange_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:PlayAnimationTimeRange", PlayAnimationTimeRange_IsValid);
		PlayAnimationReverse_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayAnimationReverse");
		PlayAnimationReverse_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayAnimationReverse_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationReverse_InAnimation_PropertyAddress, PlayAnimationReverse_FunctionAddress, "InAnimation");
		PlayAnimationReverse_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationReverse_FunctionAddress, "InAnimation");
		PlayAnimationReverse_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationReverse_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationReverse_PlaybackSpeed_PropertyAddress, PlayAnimationReverse_FunctionAddress, "PlaybackSpeed");
		PlayAnimationReverse_PlaybackSpeed_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationReverse_FunctionAddress, "PlaybackSpeed");
		PlayAnimationReverse_PlaybackSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationReverse_FunctionAddress, "PlaybackSpeed", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationReverse_bRestoreState_PropertyAddress, PlayAnimationReverse_FunctionAddress, "bRestoreState");
		PlayAnimationReverse_bRestoreState_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationReverse_FunctionAddress, "bRestoreState");
		PlayAnimationReverse_bRestoreState_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationReverse_FunctionAddress, "bRestoreState", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationReverse_ReturnValue_PropertyAddress, PlayAnimationReverse_FunctionAddress, "ReturnValue");
		PlayAnimationReverse_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationReverse_FunctionAddress, "ReturnValue");
		PlayAnimationReverse_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationReverse_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		PlayAnimationReverse_IsValid = PlayAnimationReverse_FunctionAddress != IntPtr.Zero && PlayAnimationReverse_InAnimation_IsValid && PlayAnimationReverse_PlaybackSpeed_IsValid && PlayAnimationReverse_bRestoreState_IsValid && PlayAnimationReverse_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:PlayAnimationReverse", PlayAnimationReverse_IsValid);
		PlayAnimationForward_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayAnimationForward");
		PlayAnimationForward_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayAnimationForward_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationForward_InAnimation_PropertyAddress, PlayAnimationForward_FunctionAddress, "InAnimation");
		PlayAnimationForward_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationForward_FunctionAddress, "InAnimation");
		PlayAnimationForward_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationForward_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationForward_PlaybackSpeed_PropertyAddress, PlayAnimationForward_FunctionAddress, "PlaybackSpeed");
		PlayAnimationForward_PlaybackSpeed_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationForward_FunctionAddress, "PlaybackSpeed");
		PlayAnimationForward_PlaybackSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationForward_FunctionAddress, "PlaybackSpeed", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationForward_bRestoreState_PropertyAddress, PlayAnimationForward_FunctionAddress, "bRestoreState");
		PlayAnimationForward_bRestoreState_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationForward_FunctionAddress, "bRestoreState");
		PlayAnimationForward_bRestoreState_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationForward_FunctionAddress, "bRestoreState", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimationForward_ReturnValue_PropertyAddress, PlayAnimationForward_FunctionAddress, "ReturnValue");
		PlayAnimationForward_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimationForward_FunctionAddress, "ReturnValue");
		PlayAnimationForward_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimationForward_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		PlayAnimationForward_IsValid = PlayAnimationForward_FunctionAddress != IntPtr.Zero && PlayAnimationForward_InAnimation_IsValid && PlayAnimationForward_PlaybackSpeed_IsValid && PlayAnimationForward_bRestoreState_IsValid && PlayAnimationForward_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:PlayAnimationForward", PlayAnimationForward_IsValid);
		PlayAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayAnimation");
		PlayAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimation_InAnimation_PropertyAddress, PlayAnimation_FunctionAddress, "InAnimation");
		PlayAnimation_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimation_FunctionAddress, "InAnimation");
		PlayAnimation_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimation_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimation_StartAtTime_PropertyAddress, PlayAnimation_FunctionAddress, "StartAtTime");
		PlayAnimation_StartAtTime_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimation_FunctionAddress, "StartAtTime");
		PlayAnimation_StartAtTime_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimation_FunctionAddress, "StartAtTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimation_NumLoopsToPlay_PropertyAddress, PlayAnimation_FunctionAddress, "NumLoopsToPlay");
		PlayAnimation_NumLoopsToPlay_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimation_FunctionAddress, "NumLoopsToPlay");
		PlayAnimation_NumLoopsToPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimation_FunctionAddress, "NumLoopsToPlay", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimation_PlayMode_PropertyAddress, PlayAnimation_FunctionAddress, "PlayMode");
		PlayAnimation_PlayMode_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimation_FunctionAddress, "PlayMode");
		PlayAnimation_PlayMode_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimation_FunctionAddress, "PlayMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimation_PlaybackSpeed_PropertyAddress, PlayAnimation_FunctionAddress, "PlaybackSpeed");
		PlayAnimation_PlaybackSpeed_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimation_FunctionAddress, "PlaybackSpeed");
		PlayAnimation_PlaybackSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimation_FunctionAddress, "PlaybackSpeed", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimation_bRestoreState_PropertyAddress, PlayAnimation_FunctionAddress, "bRestoreState");
		PlayAnimation_bRestoreState_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimation_FunctionAddress, "bRestoreState");
		PlayAnimation_bRestoreState_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimation_FunctionAddress, "bRestoreState", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimation_ReturnValue_PropertyAddress, PlayAnimation_FunctionAddress, "ReturnValue");
		PlayAnimation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimation_FunctionAddress, "ReturnValue");
		PlayAnimation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimation_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		PlayAnimation_IsValid = PlayAnimation_FunctionAddress != IntPtr.Zero && PlayAnimation_InAnimation_IsValid && PlayAnimation_StartAtTime_IsValid && PlayAnimation_NumLoopsToPlay_IsValid && PlayAnimation_PlayMode_IsValid && PlayAnimation_PlaybackSpeed_IsValid && PlayAnimation_bRestoreState_IsValid && PlayAnimation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:PlayAnimation", PlayAnimation_IsValid);
		PauseAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PauseAnimation");
		PauseAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(PauseAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PauseAnimation_InAnimation_PropertyAddress, PauseAnimation_FunctionAddress, "InAnimation");
		PauseAnimation_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(PauseAnimation_FunctionAddress, "InAnimation");
		PauseAnimation_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(PauseAnimation_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PauseAnimation_ReturnValue_PropertyAddress, PauseAnimation_FunctionAddress, "ReturnValue");
		PauseAnimation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PauseAnimation_FunctionAddress, "ReturnValue");
		PauseAnimation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PauseAnimation_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		PauseAnimation_IsValid = PauseAnimation_FunctionAddress != IntPtr.Zero && PauseAnimation_InAnimation_IsValid && PauseAnimation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:PauseAnimation", PauseAnimation_IsValid);
		OnTouchStarted_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTouchStarted");
		OnTouchStarted_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTouchStarted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTouchStarted_MyGeometry_PropertyAddress, OnTouchStarted_FunctionAddress, "MyGeometry");
		OnTouchStarted_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchStarted_FunctionAddress, "MyGeometry");
		OnTouchStarted_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchStarted_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnTouchStarted_InTouchEvent_PropertyAddress, OnTouchStarted_FunctionAddress, "InTouchEvent");
		OnTouchStarted_InTouchEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchStarted_FunctionAddress, "InTouchEvent");
		OnTouchStarted_InTouchEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchStarted_FunctionAddress, "InTouchEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnTouchStarted_ReturnValue_PropertyAddress, OnTouchStarted_FunctionAddress, "ReturnValue");
		OnTouchStarted_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchStarted_FunctionAddress, "ReturnValue");
		OnTouchStarted_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchStarted_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnTouchStarted_IsValid = OnTouchStarted_FunctionAddress != IntPtr.Zero && OnTouchStarted_MyGeometry_IsValid && OnTouchStarted_InTouchEvent_IsValid && OnTouchStarted_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnTouchStarted", OnTouchStarted_IsValid);
		OnTouchMoved_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTouchMoved");
		OnTouchMoved_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTouchMoved_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTouchMoved_MyGeometry_PropertyAddress, OnTouchMoved_FunctionAddress, "MyGeometry");
		OnTouchMoved_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchMoved_FunctionAddress, "MyGeometry");
		OnTouchMoved_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchMoved_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnTouchMoved_InTouchEvent_PropertyAddress, OnTouchMoved_FunctionAddress, "InTouchEvent");
		OnTouchMoved_InTouchEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchMoved_FunctionAddress, "InTouchEvent");
		OnTouchMoved_InTouchEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchMoved_FunctionAddress, "InTouchEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnTouchMoved_ReturnValue_PropertyAddress, OnTouchMoved_FunctionAddress, "ReturnValue");
		OnTouchMoved_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchMoved_FunctionAddress, "ReturnValue");
		OnTouchMoved_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchMoved_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnTouchMoved_IsValid = OnTouchMoved_FunctionAddress != IntPtr.Zero && OnTouchMoved_MyGeometry_IsValid && OnTouchMoved_InTouchEvent_IsValid && OnTouchMoved_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnTouchMoved", OnTouchMoved_IsValid);
		OnTouchGesture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTouchGesture");
		OnTouchGesture_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTouchGesture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTouchGesture_MyGeometry_PropertyAddress, OnTouchGesture_FunctionAddress, "MyGeometry");
		OnTouchGesture_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchGesture_FunctionAddress, "MyGeometry");
		OnTouchGesture_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchGesture_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnTouchGesture_GestureEvent_PropertyAddress, OnTouchGesture_FunctionAddress, "GestureEvent");
		OnTouchGesture_GestureEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchGesture_FunctionAddress, "GestureEvent");
		OnTouchGesture_GestureEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchGesture_FunctionAddress, "GestureEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnTouchGesture_ReturnValue_PropertyAddress, OnTouchGesture_FunctionAddress, "ReturnValue");
		OnTouchGesture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchGesture_FunctionAddress, "ReturnValue");
		OnTouchGesture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchGesture_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnTouchGesture_IsValid = OnTouchGesture_FunctionAddress != IntPtr.Zero && OnTouchGesture_MyGeometry_IsValid && OnTouchGesture_GestureEvent_IsValid && OnTouchGesture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnTouchGesture", OnTouchGesture_IsValid);
		OnTouchForceChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTouchForceChanged");
		OnTouchForceChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTouchForceChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTouchForceChanged_MyGeometry_PropertyAddress, OnTouchForceChanged_FunctionAddress, "MyGeometry");
		OnTouchForceChanged_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchForceChanged_FunctionAddress, "MyGeometry");
		OnTouchForceChanged_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchForceChanged_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnTouchForceChanged_InTouchEvent_PropertyAddress, OnTouchForceChanged_FunctionAddress, "InTouchEvent");
		OnTouchForceChanged_InTouchEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchForceChanged_FunctionAddress, "InTouchEvent");
		OnTouchForceChanged_InTouchEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchForceChanged_FunctionAddress, "InTouchEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnTouchForceChanged_ReturnValue_PropertyAddress, OnTouchForceChanged_FunctionAddress, "ReturnValue");
		OnTouchForceChanged_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchForceChanged_FunctionAddress, "ReturnValue");
		OnTouchForceChanged_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchForceChanged_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnTouchForceChanged_IsValid = OnTouchForceChanged_FunctionAddress != IntPtr.Zero && OnTouchForceChanged_MyGeometry_IsValid && OnTouchForceChanged_InTouchEvent_IsValid && OnTouchForceChanged_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnTouchForceChanged", OnTouchForceChanged_IsValid);
		OnTouchEnded_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTouchEnded");
		OnTouchEnded_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTouchEnded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTouchEnded_MyGeometry_PropertyAddress, OnTouchEnded_FunctionAddress, "MyGeometry");
		OnTouchEnded_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchEnded_FunctionAddress, "MyGeometry");
		OnTouchEnded_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchEnded_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnTouchEnded_InTouchEvent_PropertyAddress, OnTouchEnded_FunctionAddress, "InTouchEvent");
		OnTouchEnded_InTouchEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchEnded_FunctionAddress, "InTouchEvent");
		OnTouchEnded_InTouchEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchEnded_FunctionAddress, "InTouchEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnTouchEnded_ReturnValue_PropertyAddress, OnTouchEnded_FunctionAddress, "ReturnValue");
		OnTouchEnded_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnTouchEnded_FunctionAddress, "ReturnValue");
		OnTouchEnded_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTouchEnded_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnTouchEnded_IsValid = OnTouchEnded_FunctionAddress != IntPtr.Zero && OnTouchEnded_MyGeometry_IsValid && OnTouchEnded_InTouchEvent_IsValid && OnTouchEnded_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnTouchEnded", OnTouchEnded_IsValid);
		OnRemovedFromFocusPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRemovedFromFocusPath");
		OnRemovedFromFocusPath_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRemovedFromFocusPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnRemovedFromFocusPath_InFocusEvent_PropertyAddress, OnRemovedFromFocusPath_FunctionAddress, "InFocusEvent");
		OnRemovedFromFocusPath_InFocusEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnRemovedFromFocusPath_FunctionAddress, "InFocusEvent");
		OnRemovedFromFocusPath_InFocusEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnRemovedFromFocusPath_FunctionAddress, "InFocusEvent", Classes.FStructProperty);
		OnRemovedFromFocusPath_IsValid = OnRemovedFromFocusPath_FunctionAddress != IntPtr.Zero && OnRemovedFromFocusPath_InFocusEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnRemovedFromFocusPath", OnRemovedFromFocusPath_IsValid);
		OnPreviewMouseButtonDown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreviewMouseButtonDown");
		OnPreviewMouseButtonDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreviewMouseButtonDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewMouseButtonDown_MyGeometry_PropertyAddress, OnPreviewMouseButtonDown_FunctionAddress, "MyGeometry");
		OnPreviewMouseButtonDown_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewMouseButtonDown_FunctionAddress, "MyGeometry");
		OnPreviewMouseButtonDown_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewMouseButtonDown_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewMouseButtonDown_MouseEvent_PropertyAddress, OnPreviewMouseButtonDown_FunctionAddress, "MouseEvent");
		OnPreviewMouseButtonDown_MouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewMouseButtonDown_FunctionAddress, "MouseEvent");
		OnPreviewMouseButtonDown_MouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewMouseButtonDown_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewMouseButtonDown_ReturnValue_PropertyAddress, OnPreviewMouseButtonDown_FunctionAddress, "ReturnValue");
		OnPreviewMouseButtonDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewMouseButtonDown_FunctionAddress, "ReturnValue");
		OnPreviewMouseButtonDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewMouseButtonDown_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnPreviewMouseButtonDown_IsValid = OnPreviewMouseButtonDown_FunctionAddress != IntPtr.Zero && OnPreviewMouseButtonDown_MyGeometry_IsValid && OnPreviewMouseButtonDown_MouseEvent_IsValid && OnPreviewMouseButtonDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnPreviewMouseButtonDown", OnPreviewMouseButtonDown_IsValid);
		OnPreviewKeyDown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPreviewKeyDown");
		OnPreviewKeyDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPreviewKeyDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewKeyDown_MyGeometry_PropertyAddress, OnPreviewKeyDown_FunctionAddress, "MyGeometry");
		OnPreviewKeyDown_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewKeyDown_FunctionAddress, "MyGeometry");
		OnPreviewKeyDown_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewKeyDown_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewKeyDown_InKeyEvent_PropertyAddress, OnPreviewKeyDown_FunctionAddress, "InKeyEvent");
		OnPreviewKeyDown_InKeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewKeyDown_FunctionAddress, "InKeyEvent");
		OnPreviewKeyDown_InKeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewKeyDown_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPreviewKeyDown_ReturnValue_PropertyAddress, OnPreviewKeyDown_FunctionAddress, "ReturnValue");
		OnPreviewKeyDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnPreviewKeyDown_FunctionAddress, "ReturnValue");
		OnPreviewKeyDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPreviewKeyDown_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnPreviewKeyDown_IsValid = OnPreviewKeyDown_FunctionAddress != IntPtr.Zero && OnPreviewKeyDown_MyGeometry_IsValid && OnPreviewKeyDown_InKeyEvent_IsValid && OnPreviewKeyDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnPreviewKeyDown", OnPreviewKeyDown_IsValid);
		OnPaint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPaint");
		OnPaint_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPaint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPaint_Context_PropertyAddress, OnPaint_FunctionAddress, "Context");
		OnPaint_Context_Offset = NativeReflectionCached.GetPropertyOffset(OnPaint_FunctionAddress, "Context");
		OnPaint_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPaint_FunctionAddress, "Context", Classes.FStructProperty);
		OnPaint_IsValid = OnPaint_FunctionAddress != IntPtr.Zero && OnPaint_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnPaint", OnPaint_IsValid);
		OnMouseWheel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseWheel");
		OnMouseWheel_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseWheel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMouseWheel_MyGeometry_PropertyAddress, OnMouseWheel_FunctionAddress, "MyGeometry");
		OnMouseWheel_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseWheel_FunctionAddress, "MyGeometry");
		OnMouseWheel_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseWheel_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMouseWheel_MouseEvent_PropertyAddress, OnMouseWheel_FunctionAddress, "MouseEvent");
		OnMouseWheel_MouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseWheel_FunctionAddress, "MouseEvent");
		OnMouseWheel_MouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseWheel_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMouseWheel_ReturnValue_PropertyAddress, OnMouseWheel_FunctionAddress, "ReturnValue");
		OnMouseWheel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseWheel_FunctionAddress, "ReturnValue");
		OnMouseWheel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseWheel_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseWheel_IsValid = OnMouseWheel_FunctionAddress != IntPtr.Zero && OnMouseWheel_MyGeometry_IsValid && OnMouseWheel_MouseEvent_IsValid && OnMouseWheel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnMouseWheel", OnMouseWheel_IsValid);
		OnMouseMove_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseMove");
		OnMouseMove_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseMove_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMouseMove_MyGeometry_PropertyAddress, OnMouseMove_FunctionAddress, "MyGeometry");
		OnMouseMove_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseMove_FunctionAddress, "MyGeometry");
		OnMouseMove_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseMove_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMouseMove_MouseEvent_PropertyAddress, OnMouseMove_FunctionAddress, "MouseEvent");
		OnMouseMove_MouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseMove_FunctionAddress, "MouseEvent");
		OnMouseMove_MouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseMove_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMouseMove_ReturnValue_PropertyAddress, OnMouseMove_FunctionAddress, "ReturnValue");
		OnMouseMove_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseMove_FunctionAddress, "ReturnValue");
		OnMouseMove_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseMove_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseMove_IsValid = OnMouseMove_FunctionAddress != IntPtr.Zero && OnMouseMove_MyGeometry_IsValid && OnMouseMove_MouseEvent_IsValid && OnMouseMove_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnMouseMove", OnMouseMove_IsValid);
		OnMouseLeave_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseLeave");
		OnMouseLeave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseLeave_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMouseLeave_MouseEvent_PropertyAddress, OnMouseLeave_FunctionAddress, "MouseEvent");
		OnMouseLeave_MouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseLeave_FunctionAddress, "MouseEvent");
		OnMouseLeave_MouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseLeave_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		OnMouseLeave_IsValid = OnMouseLeave_FunctionAddress != IntPtr.Zero && OnMouseLeave_MouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnMouseLeave", OnMouseLeave_IsValid);
		OnMouseEnter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseEnter");
		OnMouseEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseEnter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMouseEnter_MyGeometry_PropertyAddress, OnMouseEnter_FunctionAddress, "MyGeometry");
		OnMouseEnter_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseEnter_FunctionAddress, "MyGeometry");
		OnMouseEnter_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseEnter_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMouseEnter_MouseEvent_PropertyAddress, OnMouseEnter_FunctionAddress, "MouseEvent");
		OnMouseEnter_MouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseEnter_FunctionAddress, "MouseEvent");
		OnMouseEnter_MouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseEnter_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		OnMouseEnter_IsValid = OnMouseEnter_FunctionAddress != IntPtr.Zero && OnMouseEnter_MyGeometry_IsValid && OnMouseEnter_MouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnMouseEnter", OnMouseEnter_IsValid);
		OnMouseCaptureLost_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseCaptureLost");
		OnMouseCaptureLost_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseCaptureLost_FunctionAddress);
		OnMouseCaptureLost_IsValid = OnMouseCaptureLost_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnMouseCaptureLost", OnMouseCaptureLost_IsValid);
		OnMouseButtonUp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseButtonUp");
		OnMouseButtonUp_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonUp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMouseButtonUp_MyGeometry_PropertyAddress, OnMouseButtonUp_FunctionAddress, "MyGeometry");
		OnMouseButtonUp_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseButtonUp_FunctionAddress, "MyGeometry");
		OnMouseButtonUp_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseButtonUp_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMouseButtonUp_MouseEvent_PropertyAddress, OnMouseButtonUp_FunctionAddress, "MouseEvent");
		OnMouseButtonUp_MouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseButtonUp_FunctionAddress, "MouseEvent");
		OnMouseButtonUp_MouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseButtonUp_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMouseButtonUp_ReturnValue_PropertyAddress, OnMouseButtonUp_FunctionAddress, "ReturnValue");
		OnMouseButtonUp_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseButtonUp_FunctionAddress, "ReturnValue");
		OnMouseButtonUp_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseButtonUp_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseButtonUp_IsValid = OnMouseButtonUp_FunctionAddress != IntPtr.Zero && OnMouseButtonUp_MyGeometry_IsValid && OnMouseButtonUp_MouseEvent_IsValid && OnMouseButtonUp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnMouseButtonUp", OnMouseButtonUp_IsValid);
		OnMouseButtonDown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseButtonDown");
		OnMouseButtonDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMouseButtonDown_MyGeometry_PropertyAddress, OnMouseButtonDown_FunctionAddress, "MyGeometry");
		OnMouseButtonDown_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseButtonDown_FunctionAddress, "MyGeometry");
		OnMouseButtonDown_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseButtonDown_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMouseButtonDown_MouseEvent_PropertyAddress, OnMouseButtonDown_FunctionAddress, "MouseEvent");
		OnMouseButtonDown_MouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseButtonDown_FunctionAddress, "MouseEvent");
		OnMouseButtonDown_MouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseButtonDown_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMouseButtonDown_ReturnValue_PropertyAddress, OnMouseButtonDown_FunctionAddress, "ReturnValue");
		OnMouseButtonDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseButtonDown_FunctionAddress, "ReturnValue");
		OnMouseButtonDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseButtonDown_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseButtonDown_IsValid = OnMouseButtonDown_FunctionAddress != IntPtr.Zero && OnMouseButtonDown_MyGeometry_IsValid && OnMouseButtonDown_MouseEvent_IsValid && OnMouseButtonDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnMouseButtonDown", OnMouseButtonDown_IsValid);
		OnMouseButtonDoubleClick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMouseButtonDoubleClick");
		OnMouseButtonDoubleClick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonDoubleClick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMouseButtonDoubleClick_InMyGeometry_PropertyAddress, OnMouseButtonDoubleClick_FunctionAddress, "InMyGeometry");
		OnMouseButtonDoubleClick_InMyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseButtonDoubleClick_FunctionAddress, "InMyGeometry");
		OnMouseButtonDoubleClick_InMyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseButtonDoubleClick_FunctionAddress, "InMyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMouseButtonDoubleClick_InMouseEvent_PropertyAddress, OnMouseButtonDoubleClick_FunctionAddress, "InMouseEvent");
		OnMouseButtonDoubleClick_InMouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseButtonDoubleClick_FunctionAddress, "InMouseEvent");
		OnMouseButtonDoubleClick_InMouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseButtonDoubleClick_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMouseButtonDoubleClick_ReturnValue_PropertyAddress, OnMouseButtonDoubleClick_FunctionAddress, "ReturnValue");
		OnMouseButtonDoubleClick_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseButtonDoubleClick_FunctionAddress, "ReturnValue");
		OnMouseButtonDoubleClick_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseButtonDoubleClick_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseButtonDoubleClick_IsValid = OnMouseButtonDoubleClick_FunctionAddress != IntPtr.Zero && OnMouseButtonDoubleClick_InMyGeometry_IsValid && OnMouseButtonDoubleClick_InMouseEvent_IsValid && OnMouseButtonDoubleClick_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnMouseButtonDoubleClick", OnMouseButtonDoubleClick_IsValid);
		OnMotionDetected_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMotionDetected");
		OnMotionDetected_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMotionDetected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMotionDetected_MyGeometry_PropertyAddress, OnMotionDetected_FunctionAddress, "MyGeometry");
		OnMotionDetected_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnMotionDetected_FunctionAddress, "MyGeometry");
		OnMotionDetected_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMotionDetected_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMotionDetected_InMotionEvent_PropertyAddress, OnMotionDetected_FunctionAddress, "InMotionEvent");
		OnMotionDetected_InMotionEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnMotionDetected_FunctionAddress, "InMotionEvent");
		OnMotionDetected_InMotionEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMotionDetected_FunctionAddress, "InMotionEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMotionDetected_ReturnValue_PropertyAddress, OnMotionDetected_FunctionAddress, "ReturnValue");
		OnMotionDetected_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnMotionDetected_FunctionAddress, "ReturnValue");
		OnMotionDetected_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMotionDetected_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMotionDetected_IsValid = OnMotionDetected_FunctionAddress != IntPtr.Zero && OnMotionDetected_MyGeometry_IsValid && OnMotionDetected_InMotionEvent_IsValid && OnMotionDetected_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnMotionDetected", OnMotionDetected_IsValid);
		OnKeyUp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnKeyUp");
		OnKeyUp_ParamsSize = NativeReflection.GetFunctionParamsSize(OnKeyUp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnKeyUp_MyGeometry_PropertyAddress, OnKeyUp_FunctionAddress, "MyGeometry");
		OnKeyUp_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnKeyUp_FunctionAddress, "MyGeometry");
		OnKeyUp_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnKeyUp_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnKeyUp_InKeyEvent_PropertyAddress, OnKeyUp_FunctionAddress, "InKeyEvent");
		OnKeyUp_InKeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnKeyUp_FunctionAddress, "InKeyEvent");
		OnKeyUp_InKeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnKeyUp_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnKeyUp_ReturnValue_PropertyAddress, OnKeyUp_FunctionAddress, "ReturnValue");
		OnKeyUp_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnKeyUp_FunctionAddress, "ReturnValue");
		OnKeyUp_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnKeyUp_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnKeyUp_IsValid = OnKeyUp_FunctionAddress != IntPtr.Zero && OnKeyUp_MyGeometry_IsValid && OnKeyUp_InKeyEvent_IsValid && OnKeyUp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnKeyUp", OnKeyUp_IsValid);
		OnKeyDown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnKeyDown");
		OnKeyDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnKeyDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnKeyDown_MyGeometry_PropertyAddress, OnKeyDown_FunctionAddress, "MyGeometry");
		OnKeyDown_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnKeyDown_FunctionAddress, "MyGeometry");
		OnKeyDown_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnKeyDown_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnKeyDown_InKeyEvent_PropertyAddress, OnKeyDown_FunctionAddress, "InKeyEvent");
		OnKeyDown_InKeyEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnKeyDown_FunctionAddress, "InKeyEvent");
		OnKeyDown_InKeyEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnKeyDown_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnKeyDown_ReturnValue_PropertyAddress, OnKeyDown_FunctionAddress, "ReturnValue");
		OnKeyDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnKeyDown_FunctionAddress, "ReturnValue");
		OnKeyDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnKeyDown_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnKeyDown_IsValid = OnKeyDown_FunctionAddress != IntPtr.Zero && OnKeyDown_MyGeometry_IsValid && OnKeyDown_InKeyEvent_IsValid && OnKeyDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnKeyDown", OnKeyDown_IsValid);
		OnKeyChar_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnKeyChar");
		OnKeyChar_ParamsSize = NativeReflection.GetFunctionParamsSize(OnKeyChar_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnKeyChar_MyGeometry_PropertyAddress, OnKeyChar_FunctionAddress, "MyGeometry");
		OnKeyChar_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnKeyChar_FunctionAddress, "MyGeometry");
		OnKeyChar_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnKeyChar_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnKeyChar_InCharacterEvent_PropertyAddress, OnKeyChar_FunctionAddress, "InCharacterEvent");
		OnKeyChar_InCharacterEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnKeyChar_FunctionAddress, "InCharacterEvent");
		OnKeyChar_InCharacterEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnKeyChar_FunctionAddress, "InCharacterEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnKeyChar_ReturnValue_PropertyAddress, OnKeyChar_FunctionAddress, "ReturnValue");
		OnKeyChar_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnKeyChar_FunctionAddress, "ReturnValue");
		OnKeyChar_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnKeyChar_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnKeyChar_IsValid = OnKeyChar_FunctionAddress != IntPtr.Zero && OnKeyChar_MyGeometry_IsValid && OnKeyChar_InCharacterEvent_IsValid && OnKeyChar_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnKeyChar", OnKeyChar_IsValid);
		OnInitialized_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnInitialized");
		OnInitialized_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInitialized_FunctionAddress);
		OnInitialized_IsValid = OnInitialized_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnInitialized", OnInitialized_IsValid);
		OnFocusReceived_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnFocusReceived");
		OnFocusReceived_ParamsSize = NativeReflection.GetFunctionParamsSize(OnFocusReceived_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnFocusReceived_MyGeometry_PropertyAddress, OnFocusReceived_FunctionAddress, "MyGeometry");
		OnFocusReceived_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnFocusReceived_FunctionAddress, "MyGeometry");
		OnFocusReceived_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnFocusReceived_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnFocusReceived_InFocusEvent_PropertyAddress, OnFocusReceived_FunctionAddress, "InFocusEvent");
		OnFocusReceived_InFocusEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnFocusReceived_FunctionAddress, "InFocusEvent");
		OnFocusReceived_InFocusEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnFocusReceived_FunctionAddress, "InFocusEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnFocusReceived_ReturnValue_PropertyAddress, OnFocusReceived_FunctionAddress, "ReturnValue");
		OnFocusReceived_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnFocusReceived_FunctionAddress, "ReturnValue");
		OnFocusReceived_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnFocusReceived_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnFocusReceived_IsValid = OnFocusReceived_FunctionAddress != IntPtr.Zero && OnFocusReceived_MyGeometry_IsValid && OnFocusReceived_InFocusEvent_IsValid && OnFocusReceived_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnFocusReceived", OnFocusReceived_IsValid);
		OnFocusLost_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnFocusLost");
		OnFocusLost_ParamsSize = NativeReflection.GetFunctionParamsSize(OnFocusLost_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnFocusLost_InFocusEvent_PropertyAddress, OnFocusLost_FunctionAddress, "InFocusEvent");
		OnFocusLost_InFocusEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnFocusLost_FunctionAddress, "InFocusEvent");
		OnFocusLost_InFocusEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnFocusLost_FunctionAddress, "InFocusEvent", Classes.FStructProperty);
		OnFocusLost_IsValid = OnFocusLost_FunctionAddress != IntPtr.Zero && OnFocusLost_InFocusEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnFocusLost", OnFocusLost_IsValid);
		OnDrop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDrop");
		OnDrop_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDrop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDrop_MyGeometry_PropertyAddress, OnDrop_FunctionAddress, "MyGeometry");
		OnDrop_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnDrop_FunctionAddress, "MyGeometry");
		OnDrop_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDrop_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDrop_PointerEvent_PropertyAddress, OnDrop_FunctionAddress, "PointerEvent");
		OnDrop_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnDrop_FunctionAddress, "PointerEvent");
		OnDrop_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDrop_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDrop_Operation_PropertyAddress, OnDrop_FunctionAddress, "Operation");
		OnDrop_Operation_Offset = NativeReflectionCached.GetPropertyOffset(OnDrop_FunctionAddress, "Operation");
		OnDrop_Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDrop_FunctionAddress, "Operation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDrop_ReturnValue_PropertyAddress, OnDrop_FunctionAddress, "ReturnValue");
		OnDrop_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnDrop_FunctionAddress, "ReturnValue");
		OnDrop_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDrop_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OnDrop_IsValid = OnDrop_FunctionAddress != IntPtr.Zero && OnDrop_MyGeometry_IsValid && OnDrop_PointerEvent_IsValid && OnDrop_Operation_IsValid && OnDrop_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnDrop", OnDrop_IsValid);
		OnDragOver_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDragOver");
		OnDragOver_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDragOver_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDragOver_MyGeometry_PropertyAddress, OnDragOver_FunctionAddress, "MyGeometry");
		OnDragOver_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnDragOver_FunctionAddress, "MyGeometry");
		OnDragOver_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragOver_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDragOver_PointerEvent_PropertyAddress, OnDragOver_FunctionAddress, "PointerEvent");
		OnDragOver_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnDragOver_FunctionAddress, "PointerEvent");
		OnDragOver_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragOver_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDragOver_Operation_PropertyAddress, OnDragOver_FunctionAddress, "Operation");
		OnDragOver_Operation_Offset = NativeReflectionCached.GetPropertyOffset(OnDragOver_FunctionAddress, "Operation");
		OnDragOver_Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragOver_FunctionAddress, "Operation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDragOver_ReturnValue_PropertyAddress, OnDragOver_FunctionAddress, "ReturnValue");
		OnDragOver_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnDragOver_FunctionAddress, "ReturnValue");
		OnDragOver_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragOver_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OnDragOver_IsValid = OnDragOver_FunctionAddress != IntPtr.Zero && OnDragOver_MyGeometry_IsValid && OnDragOver_PointerEvent_IsValid && OnDragOver_Operation_IsValid && OnDragOver_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnDragOver", OnDragOver_IsValid);
		OnDragLeave_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDragLeave");
		OnDragLeave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDragLeave_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDragLeave_PointerEvent_PropertyAddress, OnDragLeave_FunctionAddress, "PointerEvent");
		OnDragLeave_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnDragLeave_FunctionAddress, "PointerEvent");
		OnDragLeave_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragLeave_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDragLeave_Operation_PropertyAddress, OnDragLeave_FunctionAddress, "Operation");
		OnDragLeave_Operation_Offset = NativeReflectionCached.GetPropertyOffset(OnDragLeave_FunctionAddress, "Operation");
		OnDragLeave_Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragLeave_FunctionAddress, "Operation", Classes.FObjectProperty);
		OnDragLeave_IsValid = OnDragLeave_FunctionAddress != IntPtr.Zero && OnDragLeave_PointerEvent_IsValid && OnDragLeave_Operation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnDragLeave", OnDragLeave_IsValid);
		OnDragEnter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDragEnter");
		OnDragEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDragEnter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDragEnter_MyGeometry_PropertyAddress, OnDragEnter_FunctionAddress, "MyGeometry");
		OnDragEnter_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnDragEnter_FunctionAddress, "MyGeometry");
		OnDragEnter_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragEnter_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDragEnter_PointerEvent_PropertyAddress, OnDragEnter_FunctionAddress, "PointerEvent");
		OnDragEnter_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnDragEnter_FunctionAddress, "PointerEvent");
		OnDragEnter_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragEnter_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDragEnter_Operation_PropertyAddress, OnDragEnter_FunctionAddress, "Operation");
		OnDragEnter_Operation_Offset = NativeReflectionCached.GetPropertyOffset(OnDragEnter_FunctionAddress, "Operation");
		OnDragEnter_Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragEnter_FunctionAddress, "Operation", Classes.FObjectProperty);
		OnDragEnter_IsValid = OnDragEnter_FunctionAddress != IntPtr.Zero && OnDragEnter_MyGeometry_IsValid && OnDragEnter_PointerEvent_IsValid && OnDragEnter_Operation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnDragEnter", OnDragEnter_IsValid);
		OnDragDetected_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDragDetected");
		OnDragDetected_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDragDetected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDragDetected_MyGeometry_PropertyAddress, OnDragDetected_FunctionAddress, "MyGeometry");
		OnDragDetected_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnDragDetected_FunctionAddress, "MyGeometry");
		OnDragDetected_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragDetected_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDragDetected_PointerEvent_PropertyAddress, OnDragDetected_FunctionAddress, "PointerEvent");
		OnDragDetected_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnDragDetected_FunctionAddress, "PointerEvent");
		OnDragDetected_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragDetected_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDragDetected_Operation_PropertyAddress, OnDragDetected_FunctionAddress, "Operation");
		OnDragDetected_Operation_Offset = NativeReflectionCached.GetPropertyOffset(OnDragDetected_FunctionAddress, "Operation");
		OnDragDetected_Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragDetected_FunctionAddress, "Operation", Classes.FObjectProperty);
		OnDragDetected_IsValid = OnDragDetected_FunctionAddress != IntPtr.Zero && OnDragDetected_MyGeometry_IsValid && OnDragDetected_PointerEvent_IsValid && OnDragDetected_Operation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnDragDetected", OnDragDetected_IsValid);
		OnDragCancelled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDragCancelled");
		OnDragCancelled_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDragCancelled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnDragCancelled_PointerEvent_PropertyAddress, OnDragCancelled_FunctionAddress, "PointerEvent");
		OnDragCancelled_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnDragCancelled_FunctionAddress, "PointerEvent");
		OnDragCancelled_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragCancelled_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnDragCancelled_Operation_PropertyAddress, OnDragCancelled_FunctionAddress, "Operation");
		OnDragCancelled_Operation_Offset = NativeReflectionCached.GetPropertyOffset(OnDragCancelled_FunctionAddress, "Operation");
		OnDragCancelled_Operation_IsValid = NativeReflectionCached.ValidatePropertyClass(OnDragCancelled_FunctionAddress, "Operation", Classes.FObjectProperty);
		OnDragCancelled_IsValid = OnDragCancelled_FunctionAddress != IntPtr.Zero && OnDragCancelled_PointerEvent_IsValid && OnDragCancelled_Operation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnDragCancelled", OnDragCancelled_IsValid);
		OnAnimationStarted_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAnimationStarted");
		OnAnimationStarted_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAnimationStarted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAnimationStarted_Animation_PropertyAddress, OnAnimationStarted_FunctionAddress, "Animation");
		OnAnimationStarted_Animation_Offset = NativeReflectionCached.GetPropertyOffset(OnAnimationStarted_FunctionAddress, "Animation");
		OnAnimationStarted_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAnimationStarted_FunctionAddress, "Animation", Classes.FObjectProperty);
		OnAnimationStarted_IsValid = OnAnimationStarted_FunctionAddress != IntPtr.Zero && OnAnimationStarted_Animation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnAnimationStarted", OnAnimationStarted_IsValid);
		OnAnimationFinished_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAnimationFinished");
		OnAnimationFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAnimationFinished_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAnimationFinished_Animation_PropertyAddress, OnAnimationFinished_FunctionAddress, "Animation");
		OnAnimationFinished_Animation_Offset = NativeReflectionCached.GetPropertyOffset(OnAnimationFinished_FunctionAddress, "Animation");
		OnAnimationFinished_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAnimationFinished_FunctionAddress, "Animation", Classes.FObjectProperty);
		OnAnimationFinished_IsValid = OnAnimationFinished_FunctionAddress != IntPtr.Zero && OnAnimationFinished_Animation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnAnimationFinished", OnAnimationFinished_IsValid);
		OnAnalogValueChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAnalogValueChanged");
		OnAnalogValueChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAnalogValueChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAnalogValueChanged_MyGeometry_PropertyAddress, OnAnalogValueChanged_FunctionAddress, "MyGeometry");
		OnAnalogValueChanged_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnAnalogValueChanged_FunctionAddress, "MyGeometry");
		OnAnalogValueChanged_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAnalogValueChanged_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnAnalogValueChanged_InAnalogInputEvent_PropertyAddress, OnAnalogValueChanged_FunctionAddress, "InAnalogInputEvent");
		OnAnalogValueChanged_InAnalogInputEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnAnalogValueChanged_FunctionAddress, "InAnalogInputEvent");
		OnAnalogValueChanged_InAnalogInputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAnalogValueChanged_FunctionAddress, "InAnalogInputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnAnalogValueChanged_ReturnValue_PropertyAddress, OnAnalogValueChanged_FunctionAddress, "ReturnValue");
		OnAnalogValueChanged_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnAnalogValueChanged_FunctionAddress, "ReturnValue");
		OnAnalogValueChanged_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAnalogValueChanged_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnAnalogValueChanged_IsValid = OnAnalogValueChanged_FunctionAddress != IntPtr.Zero && OnAnalogValueChanged_MyGeometry_IsValid && OnAnalogValueChanged_InAnalogInputEvent_IsValid && OnAnalogValueChanged_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnAnalogValueChanged", OnAnalogValueChanged_IsValid);
		OnAddedToFocusPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAddedToFocusPath");
		OnAddedToFocusPath_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAddedToFocusPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAddedToFocusPath_InFocusEvent_PropertyAddress, OnAddedToFocusPath_FunctionAddress, "InFocusEvent");
		OnAddedToFocusPath_InFocusEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnAddedToFocusPath_FunctionAddress, "InFocusEvent");
		OnAddedToFocusPath_InFocusEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAddedToFocusPath_FunctionAddress, "InFocusEvent", Classes.FStructProperty);
		OnAddedToFocusPath_IsValid = OnAddedToFocusPath_FunctionAddress != IntPtr.Zero && OnAddedToFocusPath_InFocusEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:OnAddedToFocusPath", OnAddedToFocusPath_IsValid);
		ListenForInputAction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ListenForInputAction");
		ListenForInputAction_ParamsSize = NativeReflection.GetFunctionParamsSize(ListenForInputAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ListenForInputAction_ActionName_PropertyAddress, ListenForInputAction_FunctionAddress, "ActionName");
		ListenForInputAction_ActionName_Offset = NativeReflectionCached.GetPropertyOffset(ListenForInputAction_FunctionAddress, "ActionName");
		ListenForInputAction_ActionName_IsValid = NativeReflectionCached.ValidatePropertyClass(ListenForInputAction_FunctionAddress, "ActionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ListenForInputAction_EventType_PropertyAddress, ListenForInputAction_FunctionAddress, "EventType");
		ListenForInputAction_EventType_Offset = NativeReflectionCached.GetPropertyOffset(ListenForInputAction_FunctionAddress, "EventType");
		ListenForInputAction_EventType_IsValid = NativeReflectionCached.ValidatePropertyClass(ListenForInputAction_FunctionAddress, "EventType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ListenForInputAction_bConsume_PropertyAddress, ListenForInputAction_FunctionAddress, "bConsume");
		ListenForInputAction_bConsume_Offset = NativeReflectionCached.GetPropertyOffset(ListenForInputAction_FunctionAddress, "bConsume");
		ListenForInputAction_bConsume_IsValid = NativeReflectionCached.ValidatePropertyClass(ListenForInputAction_FunctionAddress, "bConsume", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ListenForInputAction_Callback_PropertyAddress, ListenForInputAction_FunctionAddress, "Callback");
		ListenForInputAction_Callback_Offset = NativeReflectionCached.GetPropertyOffset(ListenForInputAction_FunctionAddress, "Callback");
		ListenForInputAction_Callback_IsValid = NativeReflectionCached.ValidatePropertyClass(ListenForInputAction_FunctionAddress, "Callback", Classes.FDelegateProperty);
		ListenForInputAction_IsValid = ListenForInputAction_FunctionAddress != IntPtr.Zero && ListenForInputAction_ActionName_IsValid && ListenForInputAction_EventType_IsValid && ListenForInputAction_bConsume_IsValid && ListenForInputAction_Callback_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:ListenForInputAction", ListenForInputAction_IsValid);
		IsPlayingAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlayingAnimation");
		IsPlayingAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayingAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlayingAnimation_ReturnValue_PropertyAddress, IsPlayingAnimation_FunctionAddress, "ReturnValue");
		IsPlayingAnimation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayingAnimation_FunctionAddress, "ReturnValue");
		IsPlayingAnimation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayingAnimation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayingAnimation_IsValid = IsPlayingAnimation_FunctionAddress != IntPtr.Zero && IsPlayingAnimation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:IsPlayingAnimation", IsPlayingAnimation_IsValid);
		IsListeningForInputAction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsListeningForInputAction");
		IsListeningForInputAction_ParamsSize = NativeReflection.GetFunctionParamsSize(IsListeningForInputAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsListeningForInputAction_ActionName_PropertyAddress, IsListeningForInputAction_FunctionAddress, "ActionName");
		IsListeningForInputAction_ActionName_Offset = NativeReflectionCached.GetPropertyOffset(IsListeningForInputAction_FunctionAddress, "ActionName");
		IsListeningForInputAction_ActionName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsListeningForInputAction_FunctionAddress, "ActionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsListeningForInputAction_ReturnValue_PropertyAddress, IsListeningForInputAction_FunctionAddress, "ReturnValue");
		IsListeningForInputAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsListeningForInputAction_FunctionAddress, "ReturnValue");
		IsListeningForInputAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsListeningForInputAction_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsListeningForInputAction_IsValid = IsListeningForInputAction_FunctionAddress != IntPtr.Zero && IsListeningForInputAction_ActionName_IsValid && IsListeningForInputAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:IsListeningForInputAction", IsListeningForInputAction_IsValid);
		IsInViewport_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsInViewport");
		IsInViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInViewport_ReturnValue_PropertyAddress, IsInViewport_FunctionAddress, "ReturnValue");
		IsInViewport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInViewport_FunctionAddress, "ReturnValue");
		IsInViewport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInViewport_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInViewport_IsValid = IsInViewport_FunctionAddress != IntPtr.Zero && IsInViewport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:IsInViewport", IsInViewport_IsValid);
		IsInteractable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsInteractable");
		IsInteractable_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInteractable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInteractable_ReturnValue_PropertyAddress, IsInteractable_FunctionAddress, "ReturnValue");
		IsInteractable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInteractable_FunctionAddress, "ReturnValue");
		IsInteractable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInteractable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInteractable_IsValid = IsInteractable_FunctionAddress != IntPtr.Zero && IsInteractable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:IsInteractable", IsInteractable_IsValid);
		IsAnyAnimationPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsAnyAnimationPlaying");
		IsAnyAnimationPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAnyAnimationPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAnyAnimationPlaying_ReturnValue_PropertyAddress, IsAnyAnimationPlaying_FunctionAddress, "ReturnValue");
		IsAnyAnimationPlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAnyAnimationPlaying_FunctionAddress, "ReturnValue");
		IsAnyAnimationPlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAnyAnimationPlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAnyAnimationPlaying_IsValid = IsAnyAnimationPlaying_FunctionAddress != IntPtr.Zero && IsAnyAnimationPlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:IsAnyAnimationPlaying", IsAnyAnimationPlaying_IsValid);
		IsAnimationPlayingForward_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsAnimationPlayingForward");
		IsAnimationPlayingForward_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAnimationPlayingForward_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAnimationPlayingForward_InAnimation_PropertyAddress, IsAnimationPlayingForward_FunctionAddress, "InAnimation");
		IsAnimationPlayingForward_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(IsAnimationPlayingForward_FunctionAddress, "InAnimation");
		IsAnimationPlayingForward_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAnimationPlayingForward_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAnimationPlayingForward_ReturnValue_PropertyAddress, IsAnimationPlayingForward_FunctionAddress, "ReturnValue");
		IsAnimationPlayingForward_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAnimationPlayingForward_FunctionAddress, "ReturnValue");
		IsAnimationPlayingForward_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAnimationPlayingForward_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAnimationPlayingForward_IsValid = IsAnimationPlayingForward_FunctionAddress != IntPtr.Zero && IsAnimationPlayingForward_InAnimation_IsValid && IsAnimationPlayingForward_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:IsAnimationPlayingForward", IsAnimationPlayingForward_IsValid);
		IsAnimationPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsAnimationPlaying");
		IsAnimationPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAnimationPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAnimationPlaying_InAnimation_PropertyAddress, IsAnimationPlaying_FunctionAddress, "InAnimation");
		IsAnimationPlaying_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(IsAnimationPlaying_FunctionAddress, "InAnimation");
		IsAnimationPlaying_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAnimationPlaying_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAnimationPlaying_ReturnValue_PropertyAddress, IsAnimationPlaying_FunctionAddress, "ReturnValue");
		IsAnimationPlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAnimationPlaying_FunctionAddress, "ReturnValue");
		IsAnimationPlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAnimationPlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAnimationPlaying_IsValid = IsAnimationPlaying_FunctionAddress != IntPtr.Zero && IsAnimationPlaying_InAnimation_IsValid && IsAnimationPlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:IsAnimationPlaying", IsAnimationPlaying_IsValid);
		GetOwningPlayerPawn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOwningPlayerPawn");
		GetOwningPlayerPawn_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwningPlayerPawn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwningPlayerPawn_ReturnValue_PropertyAddress, GetOwningPlayerPawn_FunctionAddress, "ReturnValue");
		GetOwningPlayerPawn_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwningPlayerPawn_FunctionAddress, "ReturnValue");
		GetOwningPlayerPawn_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwningPlayerPawn_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwningPlayerPawn_IsValid = GetOwningPlayerPawn_FunctionAddress != IntPtr.Zero && GetOwningPlayerPawn_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:GetOwningPlayerPawn", GetOwningPlayerPawn_IsValid);
		GetOwningPlayerCameraManager_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOwningPlayerCameraManager");
		GetOwningPlayerCameraManager_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwningPlayerCameraManager_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwningPlayerCameraManager_ReturnValue_PropertyAddress, GetOwningPlayerCameraManager_FunctionAddress, "ReturnValue");
		GetOwningPlayerCameraManager_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwningPlayerCameraManager_FunctionAddress, "ReturnValue");
		GetOwningPlayerCameraManager_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwningPlayerCameraManager_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwningPlayerCameraManager_IsValid = GetOwningPlayerCameraManager_FunctionAddress != IntPtr.Zero && GetOwningPlayerCameraManager_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:GetOwningPlayerCameraManager", GetOwningPlayerCameraManager_IsValid);
		GetAnimationCurrentTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimationCurrentTime");
		GetAnimationCurrentTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationCurrentTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationCurrentTime_InAnimation_PropertyAddress, GetAnimationCurrentTime_FunctionAddress, "InAnimation");
		GetAnimationCurrentTime_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationCurrentTime_FunctionAddress, "InAnimation");
		GetAnimationCurrentTime_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationCurrentTime_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationCurrentTime_ReturnValue_PropertyAddress, GetAnimationCurrentTime_FunctionAddress, "ReturnValue");
		GetAnimationCurrentTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationCurrentTime_FunctionAddress, "ReturnValue");
		GetAnimationCurrentTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationCurrentTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAnimationCurrentTime_IsValid = GetAnimationCurrentTime_FunctionAddress != IntPtr.Zero && GetAnimationCurrentTime_InAnimation_IsValid && GetAnimationCurrentTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:GetAnimationCurrentTime", GetAnimationCurrentTime_IsValid);
		GetAnchorsInViewport_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnchorsInViewport");
		GetAnchorsInViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnchorsInViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnchorsInViewport_ReturnValue_PropertyAddress, GetAnchorsInViewport_FunctionAddress, "ReturnValue");
		GetAnchorsInViewport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnchorsInViewport_FunctionAddress, "ReturnValue");
		GetAnchorsInViewport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnchorsInViewport_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAnchorsInViewport_IsValid = GetAnchorsInViewport_FunctionAddress != IntPtr.Zero && GetAnchorsInViewport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:GetAnchorsInViewport", GetAnchorsInViewport_IsValid);
		GetAlignmentInViewport_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAlignmentInViewport");
		GetAlignmentInViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAlignmentInViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAlignmentInViewport_ReturnValue_PropertyAddress, GetAlignmentInViewport_FunctionAddress, "ReturnValue");
		GetAlignmentInViewport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAlignmentInViewport_FunctionAddress, "ReturnValue");
		GetAlignmentInViewport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAlignmentInViewport_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAlignmentInViewport_IsValid = GetAlignmentInViewport_FunctionAddress != IntPtr.Zero && GetAlignmentInViewport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:GetAlignmentInViewport", GetAlignmentInViewport_IsValid);
		FlushAnimations_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FlushAnimations");
		FlushAnimations_ParamsSize = NativeReflection.GetFunctionParamsSize(FlushAnimations_FunctionAddress);
		FlushAnimations_IsValid = FlushAnimations_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:FlushAnimations", FlushAnimations_IsValid);
		Destruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Destruct");
		Destruct_ParamsSize = NativeReflection.GetFunctionParamsSize(Destruct_FunctionAddress);
		Destruct_IsValid = Destruct_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:Destruct", Destruct_IsValid);
		Construct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Construct");
		Construct_ParamsSize = NativeReflection.GetFunctionParamsSize(Construct_FunctionAddress);
		Construct_IsValid = Construct_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:Construct", Construct_IsValid);
		CancelLatentActions_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CancelLatentActions");
		CancelLatentActions_ParamsSize = NativeReflection.GetFunctionParamsSize(CancelLatentActions_FunctionAddress);
		CancelLatentActions_IsValid = CancelLatentActions_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:CancelLatentActions", CancelLatentActions_IsValid);
		BindToAnimationStarted_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BindToAnimationStarted");
		BindToAnimationStarted_ParamsSize = NativeReflection.GetFunctionParamsSize(BindToAnimationStarted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BindToAnimationStarted_Animation_PropertyAddress, BindToAnimationStarted_FunctionAddress, "Animation");
		BindToAnimationStarted_Animation_Offset = NativeReflectionCached.GetPropertyOffset(BindToAnimationStarted_FunctionAddress, "Animation");
		BindToAnimationStarted_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(BindToAnimationStarted_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BindToAnimationStarted_Delegate_PropertyAddress, BindToAnimationStarted_FunctionAddress, "Delegate");
		BindToAnimationStarted_Delegate_Offset = NativeReflectionCached.GetPropertyOffset(BindToAnimationStarted_FunctionAddress, "Delegate");
		BindToAnimationStarted_Delegate_IsValid = NativeReflectionCached.ValidatePropertyClass(BindToAnimationStarted_FunctionAddress, "Delegate", Classes.FDelegateProperty);
		BindToAnimationStarted_IsValid = BindToAnimationStarted_FunctionAddress != IntPtr.Zero && BindToAnimationStarted_Animation_IsValid && BindToAnimationStarted_Delegate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:BindToAnimationStarted", BindToAnimationStarted_IsValid);
		BindToAnimationFinished_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BindToAnimationFinished");
		BindToAnimationFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(BindToAnimationFinished_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BindToAnimationFinished_Animation_PropertyAddress, BindToAnimationFinished_FunctionAddress, "Animation");
		BindToAnimationFinished_Animation_Offset = NativeReflectionCached.GetPropertyOffset(BindToAnimationFinished_FunctionAddress, "Animation");
		BindToAnimationFinished_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(BindToAnimationFinished_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BindToAnimationFinished_Delegate_PropertyAddress, BindToAnimationFinished_FunctionAddress, "Delegate");
		BindToAnimationFinished_Delegate_Offset = NativeReflectionCached.GetPropertyOffset(BindToAnimationFinished_FunctionAddress, "Delegate");
		BindToAnimationFinished_Delegate_IsValid = NativeReflectionCached.ValidatePropertyClass(BindToAnimationFinished_FunctionAddress, "Delegate", Classes.FDelegateProperty);
		BindToAnimationFinished_IsValid = BindToAnimationFinished_FunctionAddress != IntPtr.Zero && BindToAnimationFinished_Animation_IsValid && BindToAnimationFinished_Delegate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:BindToAnimationFinished", BindToAnimationFinished_IsValid);
		BindToAnimationEvent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BindToAnimationEvent");
		BindToAnimationEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BindToAnimationEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BindToAnimationEvent_Animation_PropertyAddress, BindToAnimationEvent_FunctionAddress, "Animation");
		BindToAnimationEvent_Animation_Offset = NativeReflectionCached.GetPropertyOffset(BindToAnimationEvent_FunctionAddress, "Animation");
		BindToAnimationEvent_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(BindToAnimationEvent_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BindToAnimationEvent_Delegate_PropertyAddress, BindToAnimationEvent_FunctionAddress, "Delegate");
		BindToAnimationEvent_Delegate_Offset = NativeReflectionCached.GetPropertyOffset(BindToAnimationEvent_FunctionAddress, "Delegate");
		BindToAnimationEvent_Delegate_IsValid = NativeReflectionCached.ValidatePropertyClass(BindToAnimationEvent_FunctionAddress, "Delegate", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref BindToAnimationEvent_AnimationEvent_PropertyAddress, BindToAnimationEvent_FunctionAddress, "AnimationEvent");
		BindToAnimationEvent_AnimationEvent_Offset = NativeReflectionCached.GetPropertyOffset(BindToAnimationEvent_FunctionAddress, "AnimationEvent");
		BindToAnimationEvent_AnimationEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(BindToAnimationEvent_FunctionAddress, "AnimationEvent", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref BindToAnimationEvent_UserTag_PropertyAddress, BindToAnimationEvent_FunctionAddress, "UserTag");
		BindToAnimationEvent_UserTag_Offset = NativeReflectionCached.GetPropertyOffset(BindToAnimationEvent_FunctionAddress, "UserTag");
		BindToAnimationEvent_UserTag_IsValid = NativeReflectionCached.ValidatePropertyClass(BindToAnimationEvent_FunctionAddress, "UserTag", Classes.FNameProperty);
		BindToAnimationEvent_IsValid = BindToAnimationEvent_FunctionAddress != IntPtr.Zero && BindToAnimationEvent_Animation_IsValid && BindToAnimationEvent_Delegate_IsValid && BindToAnimationEvent_AnimationEvent_IsValid && BindToAnimationEvent_UserTag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:BindToAnimationEvent", BindToAnimationEvent_IsValid);
		AddToViewport_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddToViewport");
		AddToViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(AddToViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddToViewport_ZOrder_PropertyAddress, AddToViewport_FunctionAddress, "ZOrder");
		AddToViewport_ZOrder_Offset = NativeReflectionCached.GetPropertyOffset(AddToViewport_FunctionAddress, "ZOrder");
		AddToViewport_ZOrder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToViewport_FunctionAddress, "ZOrder", Classes.FIntProperty);
		AddToViewport_IsValid = AddToViewport_FunctionAddress != IntPtr.Zero && AddToViewport_ZOrder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:AddToViewport", AddToViewport_IsValid);
		AddToPlayerScreen_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddToPlayerScreen");
		AddToPlayerScreen_ParamsSize = NativeReflection.GetFunctionParamsSize(AddToPlayerScreen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddToPlayerScreen_ZOrder_PropertyAddress, AddToPlayerScreen_FunctionAddress, "ZOrder");
		AddToPlayerScreen_ZOrder_Offset = NativeReflectionCached.GetPropertyOffset(AddToPlayerScreen_FunctionAddress, "ZOrder");
		AddToPlayerScreen_ZOrder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToPlayerScreen_FunctionAddress, "ZOrder", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddToPlayerScreen_ReturnValue_PropertyAddress, AddToPlayerScreen_FunctionAddress, "ReturnValue");
		AddToPlayerScreen_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddToPlayerScreen_FunctionAddress, "ReturnValue");
		AddToPlayerScreen_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddToPlayerScreen_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddToPlayerScreen_IsValid = AddToPlayerScreen_FunctionAddress != IntPtr.Zero && AddToPlayerScreen_ZOrder_IsValid && AddToPlayerScreen_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UserWidget:AddToPlayerScreen", AddToPlayerScreen_IsValid);
	}
}
