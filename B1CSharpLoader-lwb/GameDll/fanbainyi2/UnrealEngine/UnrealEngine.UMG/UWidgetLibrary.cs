using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UMG.WidgetBlueprintLibrary", "UMG", UnrealModuleType.Engine)]
public class UWidgetLibrary : UBlueprintFunctionLibrary
{
	[UDelegate]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:OnGameWindowCloseButtonClickedDelegate__DelegateSignature")]
	public class FOnGameWindowCloseButtonClickedDelegate : FDelegate<FOnGameWindowCloseButtonClickedDelegate.Signature>
	{
		public delegate void Signature();

		private static bool OnGameWindowCloseButtonClickedDelegate__DelegateSignature_IsValid;

		private static IntPtr OnGameWindowCloseButtonClickedDelegate__DelegateSignature_FunctionAddress;

		private static int OnGameWindowCloseButtonClickedDelegate__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnGameWindowCloseButtonClickedDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnGameWindowCloseButtonClickedDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.WidgetBlueprintLibrary:OnGameWindowCloseButtonClickedDelegate__DelegateSignature");
			OnGameWindowCloseButtonClickedDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGameWindowCloseButtonClickedDelegate__DelegateSignature_FunctionAddress);
			OnGameWindowCloseButtonClickedDelegate__DelegateSignature_IsValid = OnGameWindowCloseButtonClickedDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:OnGameWindowCloseButtonClickedDelegate__DelegateSignature", OnGameWindowCloseButtonClickedDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!OnGameWindowCloseButtonClickedDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:OnGameWindowCloseButtonClickedDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnGameWindowCloseButtonClickedDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGameWindowCloseButtonClickedDelegate__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static IntPtr classAddress;

	private static bool UnlockMouse_IsValid;

	private static IntPtr UnlockMouse_FunctionAddress;

	private static int UnlockMouse_ParamsSize;

	private static bool UnlockMouse_Reply_IsValid;

	private static FFieldAddress UnlockMouse_Reply_PropertyAddress;

	private static int UnlockMouse_Reply_Offset;

	private static bool UnlockMouse_ReturnValue_IsValid;

	private static FFieldAddress UnlockMouse_ReturnValue_PropertyAddress;

	private static int UnlockMouse_ReturnValue_Offset;

	private static bool Unhandled_IsValid;

	private static IntPtr Unhandled_FunctionAddress;

	private static int Unhandled_ParamsSize;

	private static bool Unhandled_ReturnValue_IsValid;

	private static FFieldAddress Unhandled_ReturnValue_PropertyAddress;

	private static int Unhandled_ReturnValue_Offset;

	private static bool SetWindowTitleBarState_IsValid;

	private static IntPtr SetWindowTitleBarState_FunctionAddress;

	private static int SetWindowTitleBarState_ParamsSize;

	private static bool SetWindowTitleBarState_TitleBarContent_IsValid;

	private static FFieldAddress SetWindowTitleBarState_TitleBarContent_PropertyAddress;

	private static int SetWindowTitleBarState_TitleBarContent_Offset;

	private static bool SetWindowTitleBarState_Mode_IsValid;

	private static FFieldAddress SetWindowTitleBarState_Mode_PropertyAddress;

	private static int SetWindowTitleBarState_Mode_Offset;

	private static bool SetWindowTitleBarState_bTitleBarDragEnabled_IsValid;

	private static FFieldAddress SetWindowTitleBarState_bTitleBarDragEnabled_PropertyAddress;

	private static int SetWindowTitleBarState_bTitleBarDragEnabled_Offset;

	private static bool SetWindowTitleBarState_bWindowButtonsVisible_IsValid;

	private static FFieldAddress SetWindowTitleBarState_bWindowButtonsVisible_PropertyAddress;

	private static int SetWindowTitleBarState_bWindowButtonsVisible_Offset;

	private static bool SetWindowTitleBarState_bTitleBarVisible_IsValid;

	private static FFieldAddress SetWindowTitleBarState_bTitleBarVisible_PropertyAddress;

	private static int SetWindowTitleBarState_bTitleBarVisible_Offset;

	private static bool SetWindowTitleBarOnCloseClickedDelegate_IsValid;

	private static IntPtr SetWindowTitleBarOnCloseClickedDelegate_FunctionAddress;

	private static int SetWindowTitleBarOnCloseClickedDelegate_ParamsSize;

	private static bool SetWindowTitleBarOnCloseClickedDelegate_Delegate_IsValid;

	private static FFieldAddress SetWindowTitleBarOnCloseClickedDelegate_Delegate_PropertyAddress;

	private static int SetWindowTitleBarOnCloseClickedDelegate_Delegate_Offset;

	private static bool SetWindowTitleBarCloseButtonActive_IsValid;

	private static IntPtr SetWindowTitleBarCloseButtonActive_FunctionAddress;

	private static int SetWindowTitleBarCloseButtonActive_ParamsSize;

	private static bool SetWindowTitleBarCloseButtonActive_bActive_IsValid;

	private static FFieldAddress SetWindowTitleBarCloseButtonActive_bActive_PropertyAddress;

	private static int SetWindowTitleBarCloseButtonActive_bActive_Offset;

	private static bool SetUserFocus_IsValid;

	private static IntPtr SetUserFocus_FunctionAddress;

	private static int SetUserFocus_ParamsSize;

	private static bool SetUserFocus_Reply_IsValid;

	private static FFieldAddress SetUserFocus_Reply_PropertyAddress;

	private static int SetUserFocus_Reply_Offset;

	private static bool SetUserFocus_FocusWidget_IsValid;

	private static FFieldAddress SetUserFocus_FocusWidget_PropertyAddress;

	private static int SetUserFocus_FocusWidget_Offset;

	private static bool SetUserFocus_bInAllUsers_IsValid;

	private static FFieldAddress SetUserFocus_bInAllUsers_PropertyAddress;

	private static int SetUserFocus_bInAllUsers_Offset;

	private static bool SetUserFocus_ReturnValue_IsValid;

	private static FFieldAddress SetUserFocus_ReturnValue_PropertyAddress;

	private static int SetUserFocus_ReturnValue_Offset;

	private static bool SetMousePosition_IsValid;

	private static IntPtr SetMousePosition_FunctionAddress;

	private static int SetMousePosition_ParamsSize;

	private static bool SetMousePosition_Reply_IsValid;

	private static FFieldAddress SetMousePosition_Reply_PropertyAddress;

	private static int SetMousePosition_Reply_Offset;

	private static bool SetMousePosition_NewMousePosition_IsValid;

	private static FFieldAddress SetMousePosition_NewMousePosition_PropertyAddress;

	private static int SetMousePosition_NewMousePosition_Offset;

	private static bool SetMousePosition_ReturnValue_IsValid;

	private static FFieldAddress SetMousePosition_ReturnValue_PropertyAddress;

	private static int SetMousePosition_ReturnValue_Offset;

	private static bool SetInputMode_UIOnlyEx_IsValid;

	private static IntPtr SetInputMode_UIOnlyEx_FunctionAddress;

	private static int SetInputMode_UIOnlyEx_ParamsSize;

	private static bool SetInputMode_UIOnlyEx_PlayerController_IsValid;

	private static FFieldAddress SetInputMode_UIOnlyEx_PlayerController_PropertyAddress;

	private static int SetInputMode_UIOnlyEx_PlayerController_Offset;

	private static bool SetInputMode_UIOnlyEx_InWidgetToFocus_IsValid;

	private static FFieldAddress SetInputMode_UIOnlyEx_InWidgetToFocus_PropertyAddress;

	private static int SetInputMode_UIOnlyEx_InWidgetToFocus_Offset;

	private static bool SetInputMode_UIOnlyEx_InMouseLockMode_IsValid;

	private static FFieldAddress SetInputMode_UIOnlyEx_InMouseLockMode_PropertyAddress;

	private static int SetInputMode_UIOnlyEx_InMouseLockMode_Offset;

	private static bool SetInputMode_GameOnly_IsValid;

	private static IntPtr SetInputMode_GameOnly_FunctionAddress;

	private static int SetInputMode_GameOnly_ParamsSize;

	private static bool SetInputMode_GameOnly_PlayerController_IsValid;

	private static FFieldAddress SetInputMode_GameOnly_PlayerController_PropertyAddress;

	private static int SetInputMode_GameOnly_PlayerController_Offset;

	private static bool SetInputMode_GameAndUIEx_IsValid;

	private static IntPtr SetInputMode_GameAndUIEx_FunctionAddress;

	private static int SetInputMode_GameAndUIEx_ParamsSize;

	private static bool SetInputMode_GameAndUIEx_PlayerController_IsValid;

	private static FFieldAddress SetInputMode_GameAndUIEx_PlayerController_PropertyAddress;

	private static int SetInputMode_GameAndUIEx_PlayerController_Offset;

	private static bool SetInputMode_GameAndUIEx_InWidgetToFocus_IsValid;

	private static FFieldAddress SetInputMode_GameAndUIEx_InWidgetToFocus_PropertyAddress;

	private static int SetInputMode_GameAndUIEx_InWidgetToFocus_Offset;

	private static bool SetInputMode_GameAndUIEx_InMouseLockMode_IsValid;

	private static FFieldAddress SetInputMode_GameAndUIEx_InMouseLockMode_PropertyAddress;

	private static int SetInputMode_GameAndUIEx_InMouseLockMode_Offset;

	private static bool SetInputMode_GameAndUIEx_bHideCursorDuringCapture_IsValid;

	private static FFieldAddress SetInputMode_GameAndUIEx_bHideCursorDuringCapture_PropertyAddress;

	private static int SetInputMode_GameAndUIEx_bHideCursorDuringCapture_Offset;

	private static bool SetHardwareCursor_IsValid;

	private static IntPtr SetHardwareCursor_FunctionAddress;

	private static int SetHardwareCursor_ParamsSize;

	private static bool SetHardwareCursor_WorldContextObject_IsValid;

	private static FFieldAddress SetHardwareCursor_WorldContextObject_PropertyAddress;

	private static int SetHardwareCursor_WorldContextObject_Offset;

	private static bool SetHardwareCursor_CursorShape_IsValid;

	private static FFieldAddress SetHardwareCursor_CursorShape_PropertyAddress;

	private static int SetHardwareCursor_CursorShape_Offset;

	private static bool SetHardwareCursor_CursorName_IsValid;

	private static FFieldAddress SetHardwareCursor_CursorName_PropertyAddress;

	private static int SetHardwareCursor_CursorName_Offset;

	private static bool SetHardwareCursor_HotSpot_IsValid;

	private static FFieldAddress SetHardwareCursor_HotSpot_PropertyAddress;

	private static int SetHardwareCursor_HotSpot_Offset;

	private static bool SetHardwareCursor_ReturnValue_IsValid;

	private static FFieldAddress SetHardwareCursor_ReturnValue_PropertyAddress;

	private static int SetHardwareCursor_ReturnValue_Offset;

	private static bool SetFocusToGameViewport_IsValid;

	private static IntPtr SetFocusToGameViewport_FunctionAddress;

	private static int SetFocusToGameViewport_ParamsSize;

	private static bool SetColorVisionDeficiencyType_IsValid;

	private static IntPtr SetColorVisionDeficiencyType_FunctionAddress;

	private static int SetColorVisionDeficiencyType_ParamsSize;

	private static bool SetColorVisionDeficiencyType_Type_IsValid;

	private static FFieldAddress SetColorVisionDeficiencyType_Type_PropertyAddress;

	private static int SetColorVisionDeficiencyType_Type_Offset;

	private static bool SetColorVisionDeficiencyType_Severity_IsValid;

	private static FFieldAddress SetColorVisionDeficiencyType_Severity_PropertyAddress;

	private static int SetColorVisionDeficiencyType_Severity_Offset;

	private static bool SetColorVisionDeficiencyType_CorrectDeficiency_IsValid;

	private static FFieldAddress SetColorVisionDeficiencyType_CorrectDeficiency_PropertyAddress;

	private static int SetColorVisionDeficiencyType_CorrectDeficiency_Offset;

	private static bool SetColorVisionDeficiencyType_ShowCorrectionWithDeficiency_IsValid;

	private static FFieldAddress SetColorVisionDeficiencyType_ShowCorrectionWithDeficiency_PropertyAddress;

	private static int SetColorVisionDeficiencyType_ShowCorrectionWithDeficiency_Offset;

	private static bool SetBrushResourceToTexture_IsValid;

	private static IntPtr SetBrushResourceToTexture_FunctionAddress;

	private static int SetBrushResourceToTexture_ParamsSize;

	private static bool SetBrushResourceToTexture_Brush_IsValid;

	private static FFieldAddress SetBrushResourceToTexture_Brush_PropertyAddress;

	private static int SetBrushResourceToTexture_Brush_Offset;

	private static bool SetBrushResourceToTexture_Texture_IsValid;

	private static FFieldAddress SetBrushResourceToTexture_Texture_PropertyAddress;

	private static int SetBrushResourceToTexture_Texture_Offset;

	private static bool SetBrushResourceToMaterial_IsValid;

	private static IntPtr SetBrushResourceToMaterial_FunctionAddress;

	private static int SetBrushResourceToMaterial_ParamsSize;

	private static bool SetBrushResourceToMaterial_Brush_IsValid;

	private static FFieldAddress SetBrushResourceToMaterial_Brush_PropertyAddress;

	private static int SetBrushResourceToMaterial_Brush_Offset;

	private static bool SetBrushResourceToMaterial_Material_IsValid;

	private static FFieldAddress SetBrushResourceToMaterial_Material_PropertyAddress;

	private static int SetBrushResourceToMaterial_Material_Offset;

	private static bool RestorePreviousWindowTitleBarState_IsValid;

	private static IntPtr RestorePreviousWindowTitleBarState_FunctionAddress;

	private static int RestorePreviousWindowTitleBarState_ParamsSize;

	private static bool ReleaseMouseCapture_IsValid;

	private static IntPtr ReleaseMouseCapture_FunctionAddress;

	private static int ReleaseMouseCapture_ParamsSize;

	private static bool ReleaseMouseCapture_Reply_IsValid;

	private static FFieldAddress ReleaseMouseCapture_Reply_PropertyAddress;

	private static int ReleaseMouseCapture_Reply_Offset;

	private static bool ReleaseMouseCapture_ReturnValue_IsValid;

	private static FFieldAddress ReleaseMouseCapture_ReturnValue_PropertyAddress;

	private static int ReleaseMouseCapture_ReturnValue_Offset;

	private static bool NoResourceBrush_IsValid;

	private static IntPtr NoResourceBrush_FunctionAddress;

	private static int NoResourceBrush_ParamsSize;

	private static bool NoResourceBrush_ReturnValue_IsValid;

	private static FFieldAddress NoResourceBrush_ReturnValue_PropertyAddress;

	private static int NoResourceBrush_ReturnValue_Offset;

	private static bool MakeBrushFromTexture_IsValid;

	private static IntPtr MakeBrushFromTexture_FunctionAddress;

	private static int MakeBrushFromTexture_ParamsSize;

	private static bool MakeBrushFromTexture_Texture_IsValid;

	private static FFieldAddress MakeBrushFromTexture_Texture_PropertyAddress;

	private static int MakeBrushFromTexture_Texture_Offset;

	private static bool MakeBrushFromTexture_Width_IsValid;

	private static FFieldAddress MakeBrushFromTexture_Width_PropertyAddress;

	private static int MakeBrushFromTexture_Width_Offset;

	private static bool MakeBrushFromTexture_Height_IsValid;

	private static FFieldAddress MakeBrushFromTexture_Height_PropertyAddress;

	private static int MakeBrushFromTexture_Height_Offset;

	private static bool MakeBrushFromTexture_ReturnValue_IsValid;

	private static FFieldAddress MakeBrushFromTexture_ReturnValue_PropertyAddress;

	private static int MakeBrushFromTexture_ReturnValue_Offset;

	private static bool MakeBrushFromMaterial_IsValid;

	private static IntPtr MakeBrushFromMaterial_FunctionAddress;

	private static int MakeBrushFromMaterial_ParamsSize;

	private static bool MakeBrushFromMaterial_Material_IsValid;

	private static FFieldAddress MakeBrushFromMaterial_Material_PropertyAddress;

	private static int MakeBrushFromMaterial_Material_Offset;

	private static bool MakeBrushFromMaterial_Width_IsValid;

	private static FFieldAddress MakeBrushFromMaterial_Width_PropertyAddress;

	private static int MakeBrushFromMaterial_Width_Offset;

	private static bool MakeBrushFromMaterial_Height_IsValid;

	private static FFieldAddress MakeBrushFromMaterial_Height_PropertyAddress;

	private static int MakeBrushFromMaterial_Height_Offset;

	private static bool MakeBrushFromMaterial_ReturnValue_IsValid;

	private static FFieldAddress MakeBrushFromMaterial_ReturnValue_PropertyAddress;

	private static int MakeBrushFromMaterial_ReturnValue_Offset;

	private static bool MakeBrushFromAsset_IsValid;

	private static IntPtr MakeBrushFromAsset_FunctionAddress;

	private static int MakeBrushFromAsset_ParamsSize;

	private static bool MakeBrushFromAsset_BrushAsset_IsValid;

	private static FFieldAddress MakeBrushFromAsset_BrushAsset_PropertyAddress;

	private static int MakeBrushFromAsset_BrushAsset_Offset;

	private static bool MakeBrushFromAsset_ReturnValue_IsValid;

	private static FFieldAddress MakeBrushFromAsset_ReturnValue_PropertyAddress;

	private static int MakeBrushFromAsset_ReturnValue_Offset;

	private static bool LockMouse_IsValid;

	private static IntPtr LockMouse_FunctionAddress;

	private static int LockMouse_ParamsSize;

	private static bool LockMouse_Reply_IsValid;

	private static FFieldAddress LockMouse_Reply_PropertyAddress;

	private static int LockMouse_Reply_Offset;

	private static bool LockMouse_CapturingWidget_IsValid;

	private static FFieldAddress LockMouse_CapturingWidget_PropertyAddress;

	private static int LockMouse_CapturingWidget_Offset;

	private static bool LockMouse_ReturnValue_IsValid;

	private static FFieldAddress LockMouse_ReturnValue_PropertyAddress;

	private static int LockMouse_ReturnValue_Offset;

	private static bool IsDragDropping_IsValid;

	private static IntPtr IsDragDropping_FunctionAddress;

	private static int IsDragDropping_ParamsSize;

	private static bool IsDragDropping_ReturnValue_IsValid;

	private static FFieldAddress IsDragDropping_ReturnValue_PropertyAddress;

	private static int IsDragDropping_ReturnValue_Offset;

	private static bool Handled_IsValid;

	private static IntPtr Handled_FunctionAddress;

	private static int Handled_ParamsSize;

	private static bool Handled_ReturnValue_IsValid;

	private static FFieldAddress Handled_ReturnValue_PropertyAddress;

	private static int Handled_ReturnValue_Offset;

	private static bool GetSafeZonePadding_IsValid;

	private static IntPtr GetSafeZonePadding_FunctionAddress;

	private static int GetSafeZonePadding_ParamsSize;

	private static bool GetSafeZonePadding_WorldContextObject_IsValid;

	private static FFieldAddress GetSafeZonePadding_WorldContextObject_PropertyAddress;

	private static int GetSafeZonePadding_WorldContextObject_Offset;

	private static bool GetSafeZonePadding_SafePadding_IsValid;

	private static FFieldAddress GetSafeZonePadding_SafePadding_PropertyAddress;

	private static int GetSafeZonePadding_SafePadding_Offset;

	private static bool GetSafeZonePadding_SafePaddingScale_IsValid;

	private static FFieldAddress GetSafeZonePadding_SafePaddingScale_PropertyAddress;

	private static int GetSafeZonePadding_SafePaddingScale_Offset;

	private static bool GetSafeZonePadding_SpillOverPadding_IsValid;

	private static FFieldAddress GetSafeZonePadding_SpillOverPadding_PropertyAddress;

	private static int GetSafeZonePadding_SpillOverPadding_Offset;

	private static bool GetKeyEventFromAnalogInputEvent_IsValid;

	private static IntPtr GetKeyEventFromAnalogInputEvent_FunctionAddress;

	private static int GetKeyEventFromAnalogInputEvent_ParamsSize;

	private static bool GetKeyEventFromAnalogInputEvent_Event_IsValid;

	private static FFieldAddress GetKeyEventFromAnalogInputEvent_Event_PropertyAddress;

	private static int GetKeyEventFromAnalogInputEvent_Event_Offset;

	private static bool GetKeyEventFromAnalogInputEvent_ReturnValue_IsValid;

	private static FFieldAddress GetKeyEventFromAnalogInputEvent_ReturnValue_PropertyAddress;

	private static int GetKeyEventFromAnalogInputEvent_ReturnValue_Offset;

	private static bool GetInputEventFromPointerEvent_IsValid;

	private static IntPtr GetInputEventFromPointerEvent_FunctionAddress;

	private static int GetInputEventFromPointerEvent_ParamsSize;

	private static bool GetInputEventFromPointerEvent_Event_IsValid;

	private static FFieldAddress GetInputEventFromPointerEvent_Event_PropertyAddress;

	private static int GetInputEventFromPointerEvent_Event_Offset;

	private static bool GetInputEventFromPointerEvent_ReturnValue_IsValid;

	private static FFieldAddress GetInputEventFromPointerEvent_ReturnValue_PropertyAddress;

	private static int GetInputEventFromPointerEvent_ReturnValue_Offset;

	private static bool GetInputEventFromNavigationEvent_IsValid;

	private static IntPtr GetInputEventFromNavigationEvent_FunctionAddress;

	private static int GetInputEventFromNavigationEvent_ParamsSize;

	private static bool GetInputEventFromNavigationEvent_Event_IsValid;

	private static FFieldAddress GetInputEventFromNavigationEvent_Event_PropertyAddress;

	private static int GetInputEventFromNavigationEvent_Event_Offset;

	private static bool GetInputEventFromNavigationEvent_ReturnValue_IsValid;

	private static FFieldAddress GetInputEventFromNavigationEvent_ReturnValue_PropertyAddress;

	private static int GetInputEventFromNavigationEvent_ReturnValue_Offset;

	private static bool GetInputEventFromKeyEvent_IsValid;

	private static IntPtr GetInputEventFromKeyEvent_FunctionAddress;

	private static int GetInputEventFromKeyEvent_ParamsSize;

	private static bool GetInputEventFromKeyEvent_Event_IsValid;

	private static FFieldAddress GetInputEventFromKeyEvent_Event_PropertyAddress;

	private static int GetInputEventFromKeyEvent_Event_Offset;

	private static bool GetInputEventFromKeyEvent_ReturnValue_IsValid;

	private static FFieldAddress GetInputEventFromKeyEvent_ReturnValue_PropertyAddress;

	private static int GetInputEventFromKeyEvent_ReturnValue_Offset;

	private static bool GetInputEventFromCharacterEvent_IsValid;

	private static IntPtr GetInputEventFromCharacterEvent_FunctionAddress;

	private static int GetInputEventFromCharacterEvent_ParamsSize;

	private static bool GetInputEventFromCharacterEvent_Event_IsValid;

	private static FFieldAddress GetInputEventFromCharacterEvent_Event_PropertyAddress;

	private static int GetInputEventFromCharacterEvent_Event_Offset;

	private static bool GetInputEventFromCharacterEvent_ReturnValue_IsValid;

	private static FFieldAddress GetInputEventFromCharacterEvent_ReturnValue_PropertyAddress;

	private static int GetInputEventFromCharacterEvent_ReturnValue_Offset;

	private static bool GetDynamicMaterial_IsValid;

	private static IntPtr GetDynamicMaterial_FunctionAddress;

	private static int GetDynamicMaterial_ParamsSize;

	private static bool GetDynamicMaterial_Brush_IsValid;

	private static FFieldAddress GetDynamicMaterial_Brush_PropertyAddress;

	private static int GetDynamicMaterial_Brush_Offset;

	private static bool GetDynamicMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetDynamicMaterial_ReturnValue_PropertyAddress;

	private static int GetDynamicMaterial_ReturnValue_Offset;

	private static bool GetDragDroppingContent_IsValid;

	private static IntPtr GetDragDroppingContent_FunctionAddress;

	private static int GetDragDroppingContent_ParamsSize;

	private static bool GetDragDroppingContent_ReturnValue_IsValid;

	private static FFieldAddress GetDragDroppingContent_ReturnValue_PropertyAddress;

	private static int GetDragDroppingContent_ReturnValue_Offset;

	private static bool GetBrushResourceAsTexture2D_IsValid;

	private static IntPtr GetBrushResourceAsTexture2D_FunctionAddress;

	private static int GetBrushResourceAsTexture2D_ParamsSize;

	private static bool GetBrushResourceAsTexture2D_Brush_IsValid;

	private static FFieldAddress GetBrushResourceAsTexture2D_Brush_PropertyAddress;

	private static int GetBrushResourceAsTexture2D_Brush_Offset;

	private static bool GetBrushResourceAsTexture2D_ReturnValue_IsValid;

	private static FFieldAddress GetBrushResourceAsTexture2D_ReturnValue_PropertyAddress;

	private static int GetBrushResourceAsTexture2D_ReturnValue_Offset;

	private static bool GetBrushResourceAsMaterial_IsValid;

	private static IntPtr GetBrushResourceAsMaterial_FunctionAddress;

	private static int GetBrushResourceAsMaterial_ParamsSize;

	private static bool GetBrushResourceAsMaterial_Brush_IsValid;

	private static FFieldAddress GetBrushResourceAsMaterial_Brush_PropertyAddress;

	private static int GetBrushResourceAsMaterial_Brush_Offset;

	private static bool GetBrushResourceAsMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetBrushResourceAsMaterial_ReturnValue_PropertyAddress;

	private static int GetBrushResourceAsMaterial_ReturnValue_Offset;

	private static bool GetBrushResource_IsValid;

	private static IntPtr GetBrushResource_FunctionAddress;

	private static int GetBrushResource_ParamsSize;

	private static bool GetBrushResource_Brush_IsValid;

	private static FFieldAddress GetBrushResource_Brush_PropertyAddress;

	private static int GetBrushResource_Brush_Offset;

	private static bool GetBrushResource_ReturnValue_IsValid;

	private static FFieldAddress GetBrushResource_ReturnValue_PropertyAddress;

	private static int GetBrushResource_ReturnValue_Offset;

	private static bool GetAllWidgetsWithInterface_IsValid;

	private static IntPtr GetAllWidgetsWithInterface_FunctionAddress;

	private static int GetAllWidgetsWithInterface_ParamsSize;

	private static bool GetAllWidgetsWithInterface_WorldContextObject_IsValid;

	private static FFieldAddress GetAllWidgetsWithInterface_WorldContextObject_PropertyAddress;

	private static int GetAllWidgetsWithInterface_WorldContextObject_Offset;

	private static bool GetAllWidgetsWithInterface_FoundWidgets_IsValid;

	private static FFieldAddress GetAllWidgetsWithInterface_FoundWidgets_PropertyAddress;

	private static int GetAllWidgetsWithInterface_FoundWidgets_Offset;

	private static bool GetAllWidgetsWithInterface_Interface_IsValid;

	private static FFieldAddress GetAllWidgetsWithInterface_Interface_PropertyAddress;

	private static int GetAllWidgetsWithInterface_Interface_Offset;

	private static bool GetAllWidgetsWithInterface_TopLevelOnly_IsValid;

	private static FFieldAddress GetAllWidgetsWithInterface_TopLevelOnly_PropertyAddress;

	private static int GetAllWidgetsWithInterface_TopLevelOnly_Offset;

	private static bool GetAllWidgetsOfClass_IsValid;

	private static IntPtr GetAllWidgetsOfClass_FunctionAddress;

	private static int GetAllWidgetsOfClass_ParamsSize;

	private static bool GetAllWidgetsOfClass_WorldContextObject_IsValid;

	private static FFieldAddress GetAllWidgetsOfClass_WorldContextObject_PropertyAddress;

	private static int GetAllWidgetsOfClass_WorldContextObject_Offset;

	private static bool GetAllWidgetsOfClass_FoundWidgets_IsValid;

	private static FFieldAddress GetAllWidgetsOfClass_FoundWidgets_PropertyAddress;

	private static int GetAllWidgetsOfClass_FoundWidgets_Offset;

	private static bool GetAllWidgetsOfClass_WidgetClass_IsValid;

	private static FFieldAddress GetAllWidgetsOfClass_WidgetClass_PropertyAddress;

	private static int GetAllWidgetsOfClass_WidgetClass_Offset;

	private static bool GetAllWidgetsOfClass_TopLevelOnly_IsValid;

	private static FFieldAddress GetAllWidgetsOfClass_TopLevelOnly_PropertyAddress;

	private static int GetAllWidgetsOfClass_TopLevelOnly_Offset;

	private static bool EndDragDrop_IsValid;

	private static IntPtr EndDragDrop_FunctionAddress;

	private static int EndDragDrop_ParamsSize;

	private static bool EndDragDrop_Reply_IsValid;

	private static FFieldAddress EndDragDrop_Reply_PropertyAddress;

	private static int EndDragDrop_Reply_Offset;

	private static bool EndDragDrop_ReturnValue_IsValid;

	private static FFieldAddress EndDragDrop_ReturnValue_PropertyAddress;

	private static int EndDragDrop_ReturnValue_Offset;

	private static bool DrawTextFormatted_IsValid;

	private static IntPtr DrawTextFormatted_FunctionAddress;

	private static int DrawTextFormatted_ParamsSize;

	private static bool DrawTextFormatted_Context_IsValid;

	private static FFieldAddress DrawTextFormatted_Context_PropertyAddress;

	private static int DrawTextFormatted_Context_Offset;

	private static bool DrawTextFormatted_Text_IsValid;

	private static FFieldAddress DrawTextFormatted_Text_PropertyAddress;

	private static int DrawTextFormatted_Text_Offset;

	private static bool DrawTextFormatted_Position_IsValid;

	private static FFieldAddress DrawTextFormatted_Position_PropertyAddress;

	private static int DrawTextFormatted_Position_Offset;

	private static bool DrawTextFormatted_Font_IsValid;

	private static FFieldAddress DrawTextFormatted_Font_PropertyAddress;

	private static int DrawTextFormatted_Font_Offset;

	private static bool DrawTextFormatted_FontSize_IsValid;

	private static FFieldAddress DrawTextFormatted_FontSize_PropertyAddress;

	private static int DrawTextFormatted_FontSize_Offset;

	private static bool DrawTextFormatted_FontTypeFace_IsValid;

	private static FFieldAddress DrawTextFormatted_FontTypeFace_PropertyAddress;

	private static int DrawTextFormatted_FontTypeFace_Offset;

	private static bool DrawTextFormatted_Tint_IsValid;

	private static FFieldAddress DrawTextFormatted_Tint_PropertyAddress;

	private static int DrawTextFormatted_Tint_Offset;

	private static bool DrawLines_IsValid;

	private static IntPtr DrawLines_FunctionAddress;

	private static int DrawLines_ParamsSize;

	private static bool DrawLines_Context_IsValid;

	private static FFieldAddress DrawLines_Context_PropertyAddress;

	private static int DrawLines_Context_Offset;

	private static bool DrawLines_Points_IsValid;

	private static FFieldAddress DrawLines_Points_PropertyAddress;

	private static int DrawLines_Points_Offset;

	private static bool DrawLines_Tint_IsValid;

	private static FFieldAddress DrawLines_Tint_PropertyAddress;

	private static int DrawLines_Tint_Offset;

	private static bool DrawLines_bAntiAlias_IsValid;

	private static FFieldAddress DrawLines_bAntiAlias_PropertyAddress;

	private static int DrawLines_bAntiAlias_Offset;

	private static bool DrawLines_Thickness_IsValid;

	private static FFieldAddress DrawLines_Thickness_PropertyAddress;

	private static int DrawLines_Thickness_Offset;

	private static bool DrawLine_IsValid;

	private static IntPtr DrawLine_FunctionAddress;

	private static int DrawLine_ParamsSize;

	private static bool DrawLine_Context_IsValid;

	private static FFieldAddress DrawLine_Context_PropertyAddress;

	private static int DrawLine_Context_Offset;

	private static bool DrawLine_PositionA_IsValid;

	private static FFieldAddress DrawLine_PositionA_PropertyAddress;

	private static int DrawLine_PositionA_Offset;

	private static bool DrawLine_PositionB_IsValid;

	private static FFieldAddress DrawLine_PositionB_PropertyAddress;

	private static int DrawLine_PositionB_Offset;

	private static bool DrawLine_Tint_IsValid;

	private static FFieldAddress DrawLine_Tint_PropertyAddress;

	private static int DrawLine_Tint_Offset;

	private static bool DrawLine_bAntiAlias_IsValid;

	private static FFieldAddress DrawLine_bAntiAlias_PropertyAddress;

	private static int DrawLine_bAntiAlias_Offset;

	private static bool DrawLine_Thickness_IsValid;

	private static FFieldAddress DrawLine_Thickness_PropertyAddress;

	private static int DrawLine_Thickness_Offset;

	private static bool DrawBox_IsValid;

	private static IntPtr DrawBox_FunctionAddress;

	private static int DrawBox_ParamsSize;

	private static bool DrawBox_Context_IsValid;

	private static FFieldAddress DrawBox_Context_PropertyAddress;

	private static int DrawBox_Context_Offset;

	private static bool DrawBox_Position_IsValid;

	private static FFieldAddress DrawBox_Position_PropertyAddress;

	private static int DrawBox_Position_Offset;

	private static bool DrawBox_Size_IsValid;

	private static FFieldAddress DrawBox_Size_PropertyAddress;

	private static int DrawBox_Size_Offset;

	private static bool DrawBox_Brush_IsValid;

	private static FFieldAddress DrawBox_Brush_PropertyAddress;

	private static int DrawBox_Brush_Offset;

	private static bool DrawBox_Tint_IsValid;

	private static FFieldAddress DrawBox_Tint_PropertyAddress;

	private static int DrawBox_Tint_Offset;

	private static bool DismissAllMenus_IsValid;

	private static IntPtr DismissAllMenus_FunctionAddress;

	private static int DismissAllMenus_ParamsSize;

	private static bool DetectDragIfPressed_IsValid;

	private static IntPtr DetectDragIfPressed_FunctionAddress;

	private static int DetectDragIfPressed_ParamsSize;

	private static bool DetectDragIfPressed_PointerEvent_IsValid;

	private static FFieldAddress DetectDragIfPressed_PointerEvent_PropertyAddress;

	private static int DetectDragIfPressed_PointerEvent_Offset;

	private static bool DetectDragIfPressed_WidgetDetectingDrag_IsValid;

	private static FFieldAddress DetectDragIfPressed_WidgetDetectingDrag_PropertyAddress;

	private static int DetectDragIfPressed_WidgetDetectingDrag_Offset;

	private static bool DetectDragIfPressed_DragKey_IsValid;

	private static FFieldAddress DetectDragIfPressed_DragKey_PropertyAddress;

	private static int DetectDragIfPressed_DragKey_Offset;

	private static bool DetectDragIfPressed_ReturnValue_IsValid;

	private static FFieldAddress DetectDragIfPressed_ReturnValue_PropertyAddress;

	private static int DetectDragIfPressed_ReturnValue_Offset;

	private static bool DetectDrag_IsValid;

	private static IntPtr DetectDrag_FunctionAddress;

	private static int DetectDrag_ParamsSize;

	private static bool DetectDrag_Reply_IsValid;

	private static FFieldAddress DetectDrag_Reply_PropertyAddress;

	private static int DetectDrag_Reply_Offset;

	private static bool DetectDrag_WidgetDetectingDrag_IsValid;

	private static FFieldAddress DetectDrag_WidgetDetectingDrag_PropertyAddress;

	private static int DetectDrag_WidgetDetectingDrag_Offset;

	private static bool DetectDrag_DragKey_IsValid;

	private static FFieldAddress DetectDrag_DragKey_PropertyAddress;

	private static int DetectDrag_DragKey_Offset;

	private static bool DetectDrag_ReturnValue_IsValid;

	private static FFieldAddress DetectDrag_ReturnValue_PropertyAddress;

	private static int DetectDrag_ReturnValue_Offset;

	private static bool ClearUserFocus_IsValid;

	private static IntPtr ClearUserFocus_FunctionAddress;

	private static int ClearUserFocus_ParamsSize;

	private static bool ClearUserFocus_Reply_IsValid;

	private static FFieldAddress ClearUserFocus_Reply_PropertyAddress;

	private static int ClearUserFocus_Reply_Offset;

	private static bool ClearUserFocus_bInAllUsers_IsValid;

	private static FFieldAddress ClearUserFocus_bInAllUsers_PropertyAddress;

	private static int ClearUserFocus_bInAllUsers_Offset;

	private static bool ClearUserFocus_ReturnValue_IsValid;

	private static FFieldAddress ClearUserFocus_ReturnValue_PropertyAddress;

	private static int ClearUserFocus_ReturnValue_Offset;

	private static bool CaptureMouse_IsValid;

	private static IntPtr CaptureMouse_FunctionAddress;

	private static int CaptureMouse_ParamsSize;

	private static bool CaptureMouse_Reply_IsValid;

	private static FFieldAddress CaptureMouse_Reply_PropertyAddress;

	private static int CaptureMouse_Reply_Offset;

	private static bool CaptureMouse_CapturingWidget_IsValid;

	private static FFieldAddress CaptureMouse_CapturingWidget_PropertyAddress;

	private static int CaptureMouse_CapturingWidget_Offset;

	private static bool CaptureMouse_ReturnValue_IsValid;

	private static FFieldAddress CaptureMouse_ReturnValue_PropertyAddress;

	private static int CaptureMouse_ReturnValue_Offset;

	private static bool CancelDragDrop_IsValid;

	private static IntPtr CancelDragDrop_FunctionAddress;

	private static int CancelDragDrop_ParamsSize;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:UnlockMouse")]
	public unsafe static FEventReply UnlockMouse(ref FEventReply Reply)
	{
		if (!UnlockMouse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:UnlockMouse");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnlockMouse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnlockMouse_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(UnlockMouse_Reply_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(intPtr, UnlockMouse_Reply_Offset), 0, UnlockMouse_Reply_PropertyAddress.Address, Reply);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UnlockMouse_FunctionAddress, intPtr, UnlockMouse_ParamsSize);
		Reply = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, UnlockMouse_Reply_Offset), 0, UnlockMouse_Reply_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(UnlockMouse_Reply_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, UnlockMouse_ReturnValue_Offset), 0, UnlockMouse_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(UnlockMouse_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:Unhandled")]
	public unsafe static FEventReply Unhandled()
	{
		if (!Unhandled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:Unhandled");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Unhandled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Unhandled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Unhandled_FunctionAddress, intPtr, Unhandled_ParamsSize);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, Unhandled_ReturnValue_Offset), 0, Unhandled_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Unhandled_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:SetWindowTitleBarState")]
	public unsafe static void SetWindowTitleBarState(UWidget TitleBarContent, EWindowTitleBarMode Mode, bool bTitleBarDragEnabled, bool bWindowButtonsVisible, bool bTitleBarVisible)
	{
		if (!SetWindowTitleBarState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:SetWindowTitleBarState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWindowTitleBarState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWindowTitleBarState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SetWindowTitleBarState_TitleBarContent_Offset), 0, SetWindowTitleBarState_TitleBarContent_PropertyAddress.Address, TitleBarContent);
		EnumMarshaler<EWindowTitleBarMode>.ToNative(IntPtr.Add(intPtr, SetWindowTitleBarState_Mode_Offset), 0, SetWindowTitleBarState_Mode_PropertyAddress.Address, Mode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWindowTitleBarState_bTitleBarDragEnabled_Offset), 0, SetWindowTitleBarState_bTitleBarDragEnabled_PropertyAddress.Address, bTitleBarDragEnabled);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWindowTitleBarState_bWindowButtonsVisible_Offset), 0, SetWindowTitleBarState_bWindowButtonsVisible_PropertyAddress.Address, bWindowButtonsVisible);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWindowTitleBarState_bTitleBarVisible_Offset), 0, SetWindowTitleBarState_bTitleBarVisible_PropertyAddress.Address, bTitleBarVisible);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetWindowTitleBarState_FunctionAddress, intPtr, SetWindowTitleBarState_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:SetWindowTitleBarOnCloseClickedDelegate")]
	public unsafe static void SetWindowTitleBarOnCloseClickedDelegate(FOnGameWindowCloseButtonClickedDelegate Delegate)
	{
		if (!SetWindowTitleBarOnCloseClickedDelegate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:SetWindowTitleBarOnCloseClickedDelegate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWindowTitleBarOnCloseClickedDelegate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWindowTitleBarOnCloseClickedDelegate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDelegateMarshaler<FOnGameWindowCloseButtonClickedDelegate>.ToNative(IntPtr.Add(intPtr, SetWindowTitleBarOnCloseClickedDelegate_Delegate_Offset), 0, SetWindowTitleBarOnCloseClickedDelegate_Delegate_PropertyAddress.Address, Delegate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetWindowTitleBarOnCloseClickedDelegate_FunctionAddress, intPtr, SetWindowTitleBarOnCloseClickedDelegate_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:SetWindowTitleBarCloseButtonActive")]
	public unsafe static void SetWindowTitleBarCloseButtonActive(bool bActive)
	{
		if (!SetWindowTitleBarCloseButtonActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:SetWindowTitleBarCloseButtonActive");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWindowTitleBarCloseButtonActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWindowTitleBarCloseButtonActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWindowTitleBarCloseButtonActive_bActive_Offset), 0, SetWindowTitleBarCloseButtonActive_bActive_PropertyAddress.Address, bActive);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetWindowTitleBarCloseButtonActive_FunctionAddress, intPtr, SetWindowTitleBarCloseButtonActive_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:SetUserFocus")]
	public unsafe static FEventReply SetUserFocus(ref FEventReply Reply, UWidget FocusWidget, bool bInAllUsers = false)
	{
		if (!SetUserFocus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:SetUserFocus");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUserFocus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUserFocus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetUserFocus_Reply_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(intPtr, SetUserFocus_Reply_Offset), 0, SetUserFocus_Reply_PropertyAddress.Address, Reply);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SetUserFocus_FocusWidget_Offset), 0, SetUserFocus_FocusWidget_PropertyAddress.Address, FocusWidget);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetUserFocus_bInAllUsers_Offset), 0, SetUserFocus_bInAllUsers_PropertyAddress.Address, bInAllUsers);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetUserFocus_FunctionAddress, intPtr, SetUserFocus_ParamsSize);
		Reply = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, SetUserFocus_Reply_Offset), 0, SetUserFocus_Reply_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetUserFocus_Reply_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, SetUserFocus_ReturnValue_Offset), 0, SetUserFocus_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetUserFocus_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:SetMousePosition")]
	public unsafe static FEventReply SetMousePosition(ref FEventReply Reply, FVector2D NewMousePosition)
	{
		if (!SetMousePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:SetMousePosition");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMousePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMousePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetMousePosition_Reply_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(intPtr, SetMousePosition_Reply_Offset), 0, SetMousePosition_Reply_PropertyAddress.Address, Reply);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetMousePosition_NewMousePosition_Offset), 0, SetMousePosition_NewMousePosition_PropertyAddress.Address, NewMousePosition);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMousePosition_FunctionAddress, intPtr, SetMousePosition_ParamsSize);
		Reply = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, SetMousePosition_Reply_Offset), 0, SetMousePosition_Reply_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetMousePosition_Reply_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, SetMousePosition_ReturnValue_Offset), 0, SetMousePosition_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetMousePosition_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:SetInputMode_UIOnlyEx")]
	public unsafe static void SetInputMode_UIOnlyEx(APlayerController PlayerController, UWidget InWidgetToFocus, EMouseLockMode InMouseLockMode)
	{
		if (!SetInputMode_UIOnlyEx_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:SetInputMode_UIOnlyEx");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInputMode_UIOnlyEx_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInputMode_UIOnlyEx_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, SetInputMode_UIOnlyEx_PlayerController_Offset), 0, SetInputMode_UIOnlyEx_PlayerController_PropertyAddress.Address, PlayerController);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SetInputMode_UIOnlyEx_InWidgetToFocus_Offset), 0, SetInputMode_UIOnlyEx_InWidgetToFocus_PropertyAddress.Address, InWidgetToFocus);
		EnumMarshaler<EMouseLockMode>.ToNative(IntPtr.Add(intPtr, SetInputMode_UIOnlyEx_InMouseLockMode_Offset), 0, SetInputMode_UIOnlyEx_InMouseLockMode_PropertyAddress.Address, InMouseLockMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInputMode_UIOnlyEx_FunctionAddress, intPtr, SetInputMode_UIOnlyEx_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:SetInputMode_GameOnly")]
	public unsafe static void SetInputMode_GameOnly(APlayerController PlayerController)
	{
		if (!SetInputMode_GameOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:SetInputMode_GameOnly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInputMode_GameOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInputMode_GameOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, SetInputMode_GameOnly_PlayerController_Offset), 0, SetInputMode_GameOnly_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInputMode_GameOnly_FunctionAddress, intPtr, SetInputMode_GameOnly_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:SetInputMode_GameAndUIEx")]
	public unsafe static void SetInputMode_GameAndUIEx(APlayerController PlayerController, UWidget InWidgetToFocus, EMouseLockMode InMouseLockMode, bool bHideCursorDuringCapture)
	{
		if (!SetInputMode_GameAndUIEx_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:SetInputMode_GameAndUIEx");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInputMode_GameAndUIEx_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInputMode_GameAndUIEx_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, SetInputMode_GameAndUIEx_PlayerController_Offset), 0, SetInputMode_GameAndUIEx_PlayerController_PropertyAddress.Address, PlayerController);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SetInputMode_GameAndUIEx_InWidgetToFocus_Offset), 0, SetInputMode_GameAndUIEx_InWidgetToFocus_PropertyAddress.Address, InWidgetToFocus);
		EnumMarshaler<EMouseLockMode>.ToNative(IntPtr.Add(intPtr, SetInputMode_GameAndUIEx_InMouseLockMode_Offset), 0, SetInputMode_GameAndUIEx_InMouseLockMode_PropertyAddress.Address, InMouseLockMode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetInputMode_GameAndUIEx_bHideCursorDuringCapture_Offset), 0, SetInputMode_GameAndUIEx_bHideCursorDuringCapture_PropertyAddress.Address, bHideCursorDuringCapture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInputMode_GameAndUIEx_FunctionAddress, intPtr, SetInputMode_GameAndUIEx_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:SetHardwareCursor")]
	public unsafe static bool SetHardwareCursor(UObject WorldContextObject, EMouseCursor CursorShape, FName CursorName, FVector2D HotSpot)
	{
		if (!SetHardwareCursor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:SetHardwareCursor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHardwareCursor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHardwareCursor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetHardwareCursor_WorldContextObject_Offset), 0, SetHardwareCursor_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		EnumMarshaler<EMouseCursor>.ToNative(IntPtr.Add(intPtr, SetHardwareCursor_CursorShape_Offset), 0, SetHardwareCursor_CursorShape_PropertyAddress.Address, CursorShape);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetHardwareCursor_CursorName_Offset), 0, SetHardwareCursor_CursorName_PropertyAddress.Address, CursorName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetHardwareCursor_HotSpot_Offset), 0, SetHardwareCursor_HotSpot_PropertyAddress.Address, HotSpot);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetHardwareCursor_FunctionAddress, intPtr, SetHardwareCursor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetHardwareCursor_ReturnValue_Offset), 0, SetHardwareCursor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:SetFocusToGameViewport")]
	public unsafe static void SetFocusToGameViewport()
	{
		if (!SetFocusToGameViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:SetFocusToGameViewport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFocusToGameViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFocusToGameViewport_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: SetFocusToGameViewport_FunctionAddress, argsSize: SetFocusToGameViewport_ParamsSize);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:SetColorVisionDeficiencyType")]
	public unsafe static void SetColorVisionDeficiencyType(EColorVisionDeficiency Type, float Severity, bool CorrectDeficiency, bool ShowCorrectionWithDeficiency)
	{
		if (!SetColorVisionDeficiencyType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:SetColorVisionDeficiencyType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetColorVisionDeficiencyType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetColorVisionDeficiencyType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EColorVisionDeficiency>.ToNative(IntPtr.Add(intPtr, SetColorVisionDeficiencyType_Type_Offset), 0, SetColorVisionDeficiencyType_Type_PropertyAddress.Address, Type);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetColorVisionDeficiencyType_Severity_Offset), 0, SetColorVisionDeficiencyType_Severity_PropertyAddress.Address, Severity);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetColorVisionDeficiencyType_CorrectDeficiency_Offset), 0, SetColorVisionDeficiencyType_CorrectDeficiency_PropertyAddress.Address, CorrectDeficiency);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetColorVisionDeficiencyType_ShowCorrectionWithDeficiency_Offset), 0, SetColorVisionDeficiencyType_ShowCorrectionWithDeficiency_PropertyAddress.Address, ShowCorrectionWithDeficiency);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetColorVisionDeficiencyType_FunctionAddress, intPtr, SetColorVisionDeficiencyType_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:SetBrushResourceToTexture")]
	public unsafe static void SetBrushResourceToTexture(ref FSlateBrush Brush, UTexture2D Texture)
	{
		if (!SetBrushResourceToTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:SetBrushResourceToTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBrushResourceToTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBrushResourceToTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetBrushResourceToTexture_Brush_PropertyAddress.Address, intPtr);
		FSlateBrush.ToNative(IntPtr.Add(intPtr, SetBrushResourceToTexture_Brush_Offset), 0, SetBrushResourceToTexture_Brush_PropertyAddress.Address, Brush);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, SetBrushResourceToTexture_Texture_Offset), 0, SetBrushResourceToTexture_Texture_PropertyAddress.Address, Texture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBrushResourceToTexture_FunctionAddress, intPtr, SetBrushResourceToTexture_ParamsSize);
		Brush = FSlateBrush.FromNative(IntPtr.Add(intPtr, SetBrushResourceToTexture_Brush_Offset), 0, SetBrushResourceToTexture_Brush_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetBrushResourceToTexture_Brush_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:SetBrushResourceToMaterial")]
	public unsafe static void SetBrushResourceToMaterial(ref FSlateBrush Brush, UMaterialInterface Material)
	{
		if (!SetBrushResourceToMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:SetBrushResourceToMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBrushResourceToMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBrushResourceToMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetBrushResourceToMaterial_Brush_PropertyAddress.Address, intPtr);
		FSlateBrush.ToNative(IntPtr.Add(intPtr, SetBrushResourceToMaterial_Brush_Offset), 0, SetBrushResourceToMaterial_Brush_PropertyAddress.Address, Brush);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetBrushResourceToMaterial_Material_Offset), 0, SetBrushResourceToMaterial_Material_PropertyAddress.Address, Material);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBrushResourceToMaterial_FunctionAddress, intPtr, SetBrushResourceToMaterial_ParamsSize);
		Brush = FSlateBrush.FromNative(IntPtr.Add(intPtr, SetBrushResourceToMaterial_Brush_Offset), 0, SetBrushResourceToMaterial_Brush_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetBrushResourceToMaterial_Brush_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:RestorePreviousWindowTitleBarState")]
	public unsafe static void RestorePreviousWindowTitleBarState()
	{
		if (!RestorePreviousWindowTitleBarState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:RestorePreviousWindowTitleBarState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestorePreviousWindowTitleBarState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestorePreviousWindowTitleBarState_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: RestorePreviousWindowTitleBarState_FunctionAddress, argsSize: RestorePreviousWindowTitleBarState_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:ReleaseMouseCapture")]
	public unsafe static FEventReply ReleaseMouseCapture(ref FEventReply Reply)
	{
		if (!ReleaseMouseCapture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:ReleaseMouseCapture");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReleaseMouseCapture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReleaseMouseCapture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ReleaseMouseCapture_Reply_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(intPtr, ReleaseMouseCapture_Reply_Offset), 0, ReleaseMouseCapture_Reply_PropertyAddress.Address, Reply);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReleaseMouseCapture_FunctionAddress, intPtr, ReleaseMouseCapture_ParamsSize);
		Reply = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, ReleaseMouseCapture_Reply_Offset), 0, ReleaseMouseCapture_Reply_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ReleaseMouseCapture_Reply_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, ReleaseMouseCapture_ReturnValue_Offset), 0, ReleaseMouseCapture_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ReleaseMouseCapture_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:NoResourceBrush")]
	public unsafe static FSlateBrush NoResourceBrush()
	{
		if (!NoResourceBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:NoResourceBrush");
			return default(FSlateBrush);
		}
		byte* ptr = stackalloc byte[(int)(uint)(NoResourceBrush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NoResourceBrush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NoResourceBrush_FunctionAddress, intPtr, NoResourceBrush_ParamsSize);
		FSlateBrush result = FSlateBrush.FromNative(IntPtr.Add(intPtr, NoResourceBrush_ReturnValue_Offset), 0, NoResourceBrush_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(NoResourceBrush_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:MakeBrushFromTexture")]
	public unsafe static FSlateBrush MakeBrushFromTexture(UTexture2D Texture, int Width = 0, int Height = 0)
	{
		if (!MakeBrushFromTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:MakeBrushFromTexture");
			return default(FSlateBrush);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeBrushFromTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeBrushFromTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, MakeBrushFromTexture_Texture_Offset), 0, MakeBrushFromTexture_Texture_PropertyAddress.Address, Texture);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeBrushFromTexture_Width_Offset), 0, MakeBrushFromTexture_Width_PropertyAddress.Address, Width);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeBrushFromTexture_Height_Offset), 0, MakeBrushFromTexture_Height_PropertyAddress.Address, Height);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeBrushFromTexture_FunctionAddress, intPtr, MakeBrushFromTexture_ParamsSize);
		FSlateBrush result = FSlateBrush.FromNative(IntPtr.Add(intPtr, MakeBrushFromTexture_ReturnValue_Offset), 0, MakeBrushFromTexture_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakeBrushFromTexture_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:MakeBrushFromMaterial")]
	public unsafe static FSlateBrush MakeBrushFromMaterial(UMaterialInterface Material, int Width = 32, int Height = 32)
	{
		if (!MakeBrushFromMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:MakeBrushFromMaterial");
			return default(FSlateBrush);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeBrushFromMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeBrushFromMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, MakeBrushFromMaterial_Material_Offset), 0, MakeBrushFromMaterial_Material_PropertyAddress.Address, Material);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeBrushFromMaterial_Width_Offset), 0, MakeBrushFromMaterial_Width_PropertyAddress.Address, Width);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeBrushFromMaterial_Height_Offset), 0, MakeBrushFromMaterial_Height_PropertyAddress.Address, Height);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeBrushFromMaterial_FunctionAddress, intPtr, MakeBrushFromMaterial_ParamsSize);
		FSlateBrush result = FSlateBrush.FromNative(IntPtr.Add(intPtr, MakeBrushFromMaterial_ReturnValue_Offset), 0, MakeBrushFromMaterial_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakeBrushFromMaterial_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:MakeBrushFromAsset")]
	public unsafe static FSlateBrush MakeBrushFromAsset(USlateBrushAsset BrushAsset)
	{
		if (!MakeBrushFromAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:MakeBrushFromAsset");
			return default(FSlateBrush);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeBrushFromAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeBrushFromAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USlateBrushAsset>.ToNative(IntPtr.Add(intPtr, MakeBrushFromAsset_BrushAsset_Offset), 0, MakeBrushFromAsset_BrushAsset_PropertyAddress.Address, BrushAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeBrushFromAsset_FunctionAddress, intPtr, MakeBrushFromAsset_ParamsSize);
		FSlateBrush result = FSlateBrush.FromNative(IntPtr.Add(intPtr, MakeBrushFromAsset_ReturnValue_Offset), 0, MakeBrushFromAsset_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakeBrushFromAsset_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:LockMouse")]
	public unsafe static FEventReply LockMouse(ref FEventReply Reply, UWidget CapturingWidget)
	{
		if (!LockMouse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:LockMouse");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LockMouse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LockMouse_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(LockMouse_Reply_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(intPtr, LockMouse_Reply_Offset), 0, LockMouse_Reply_PropertyAddress.Address, Reply);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, LockMouse_CapturingWidget_Offset), 0, LockMouse_CapturingWidget_PropertyAddress.Address, CapturingWidget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LockMouse_FunctionAddress, intPtr, LockMouse_ParamsSize);
		Reply = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, LockMouse_Reply_Offset), 0, LockMouse_Reply_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(LockMouse_Reply_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, LockMouse_ReturnValue_Offset), 0, LockMouse_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(LockMouse_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684617u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:IsDragDropping")]
	public unsafe static bool IsDragDropping()
	{
		if (!IsDragDropping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:IsDragDropping");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDragDropping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDragDropping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsDragDropping_FunctionAddress, intPtr, IsDragDropping_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDragDropping_ReturnValue_Offset), 0, IsDragDropping_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:Handled")]
	public unsafe static FEventReply Handled()
	{
		if (!Handled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:Handled");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Handled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Handled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Handled_FunctionAddress, intPtr, Handled_ParamsSize);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, Handled_ReturnValue_Offset), 0, Handled_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Handled_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:GetSafeZonePadding")]
	public unsafe static void GetSafeZonePadding(UObject WorldContextObject, out FVector4 SafePadding, out FVector2D SafePaddingScale, out FVector4 SpillOverPadding)
	{
		if (!GetSafeZonePadding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:GetSafeZonePadding");
			SafePadding = default(FVector4);
			SafePaddingScale = default(FVector2D);
			SpillOverPadding = default(FVector4);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSafeZonePadding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSafeZonePadding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetSafeZonePadding_WorldContextObject_Offset), 0, GetSafeZonePadding_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSafeZonePadding_FunctionAddress, intPtr, GetSafeZonePadding_ParamsSize);
		SafePadding = BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(intPtr, GetSafeZonePadding_SafePadding_Offset), 0, GetSafeZonePadding_SafePadding_PropertyAddress.Address);
		SafePaddingScale = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetSafeZonePadding_SafePaddingScale_Offset), 0, GetSafeZonePadding_SafePaddingScale_PropertyAddress.Address);
		SpillOverPadding = BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(intPtr, GetSafeZonePadding_SpillOverPadding_Offset), 0, GetSafeZonePadding_SpillOverPadding_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:GetKeyEventFromAnalogInputEvent")]
	public unsafe static FKeyEvent GetKeyEventFromAnalogInputEvent(FAnalogInputEvent Event)
	{
		if (!GetKeyEventFromAnalogInputEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:GetKeyEventFromAnalogInputEvent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKeyEventFromAnalogInputEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKeyEventFromAnalogInputEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetKeyEventFromAnalogInputEvent_Event_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnalogInputEvent>.ToNative(IntPtr.Add(intPtr, GetKeyEventFromAnalogInputEvent_Event_Offset), 0, GetKeyEventFromAnalogInputEvent_Event_PropertyAddress.Address, Event);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetKeyEventFromAnalogInputEvent_FunctionAddress, intPtr, GetKeyEventFromAnalogInputEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetKeyEventFromAnalogInputEvent_Event_PropertyAddress.Address, intPtr);
		FKeyEvent result = StructAsClassMarshaler<FKeyEvent>.FromNative(IntPtr.Add(intPtr, GetKeyEventFromAnalogInputEvent_ReturnValue_Offset), 0, GetKeyEventFromAnalogInputEvent_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetKeyEventFromAnalogInputEvent_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:GetInputEventFromPointerEvent")]
	public unsafe static FInputEvent GetInputEventFromPointerEvent(FPointerEvent Event)
	{
		if (!GetInputEventFromPointerEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:GetInputEventFromPointerEvent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputEventFromPointerEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputEventFromPointerEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInputEventFromPointerEvent_Event_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, GetInputEventFromPointerEvent_Event_Offset), 0, GetInputEventFromPointerEvent_Event_PropertyAddress.Address, Event);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputEventFromPointerEvent_FunctionAddress, intPtr, GetInputEventFromPointerEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInputEventFromPointerEvent_Event_PropertyAddress.Address, intPtr);
		FInputEvent result = StructAsClassMarshaler<FInputEvent>.FromNative(IntPtr.Add(intPtr, GetInputEventFromPointerEvent_ReturnValue_Offset), 0, GetInputEventFromPointerEvent_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetInputEventFromPointerEvent_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:GetInputEventFromNavigationEvent")]
	public unsafe static FInputEvent GetInputEventFromNavigationEvent(FNavigationEvent Event)
	{
		if (!GetInputEventFromNavigationEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:GetInputEventFromNavigationEvent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputEventFromNavigationEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputEventFromNavigationEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInputEventFromNavigationEvent_Event_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FNavigationEvent>.ToNative(IntPtr.Add(intPtr, GetInputEventFromNavigationEvent_Event_Offset), 0, GetInputEventFromNavigationEvent_Event_PropertyAddress.Address, Event);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputEventFromNavigationEvent_FunctionAddress, intPtr, GetInputEventFromNavigationEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInputEventFromNavigationEvent_Event_PropertyAddress.Address, intPtr);
		FInputEvent result = StructAsClassMarshaler<FInputEvent>.FromNative(IntPtr.Add(intPtr, GetInputEventFromNavigationEvent_ReturnValue_Offset), 0, GetInputEventFromNavigationEvent_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetInputEventFromNavigationEvent_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:GetInputEventFromKeyEvent")]
	public unsafe static FInputEvent GetInputEventFromKeyEvent(FKeyEvent Event)
	{
		if (!GetInputEventFromKeyEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:GetInputEventFromKeyEvent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputEventFromKeyEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputEventFromKeyEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInputEventFromKeyEvent_Event_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, GetInputEventFromKeyEvent_Event_Offset), 0, GetInputEventFromKeyEvent_Event_PropertyAddress.Address, Event);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputEventFromKeyEvent_FunctionAddress, intPtr, GetInputEventFromKeyEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInputEventFromKeyEvent_Event_PropertyAddress.Address, intPtr);
		FInputEvent result = StructAsClassMarshaler<FInputEvent>.FromNative(IntPtr.Add(intPtr, GetInputEventFromKeyEvent_ReturnValue_Offset), 0, GetInputEventFromKeyEvent_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetInputEventFromKeyEvent_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:GetInputEventFromCharacterEvent")]
	public unsafe static FInputEvent GetInputEventFromCharacterEvent(FCharacterEvent Event)
	{
		if (!GetInputEventFromCharacterEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:GetInputEventFromCharacterEvent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputEventFromCharacterEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputEventFromCharacterEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInputEventFromCharacterEvent_Event_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FCharacterEvent>.ToNative(IntPtr.Add(intPtr, GetInputEventFromCharacterEvent_Event_Offset), 0, GetInputEventFromCharacterEvent_Event_PropertyAddress.Address, Event);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputEventFromCharacterEvent_FunctionAddress, intPtr, GetInputEventFromCharacterEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInputEventFromCharacterEvent_Event_PropertyAddress.Address, intPtr);
		FInputEvent result = StructAsClassMarshaler<FInputEvent>.FromNative(IntPtr.Add(intPtr, GetInputEventFromCharacterEvent_ReturnValue_Offset), 0, GetInputEventFromCharacterEvent_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetInputEventFromCharacterEvent_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:GetDynamicMaterial")]
	public unsafe static UMaterialInstanceDynamic GetDynamicMaterial(ref FSlateBrush Brush)
	{
		if (!GetDynamicMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:GetDynamicMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDynamicMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDynamicMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetDynamicMaterial_Brush_PropertyAddress.Address, intPtr);
		FSlateBrush.ToNative(IntPtr.Add(intPtr, GetDynamicMaterial_Brush_Offset), 0, GetDynamicMaterial_Brush_PropertyAddress.Address, Brush);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDynamicMaterial_FunctionAddress, intPtr, GetDynamicMaterial_ParamsSize);
		Brush = FSlateBrush.FromNative(IntPtr.Add(intPtr, GetDynamicMaterial_Brush_Offset), 0, GetDynamicMaterial_Brush_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDynamicMaterial_Brush_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GetDynamicMaterial_ReturnValue_Offset), 0, GetDynamicMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684617u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:GetDragDroppingContent")]
	public unsafe static UDragDropOperation GetDragDroppingContent()
	{
		if (!GetDragDroppingContent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:GetDragDroppingContent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDragDroppingContent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDragDroppingContent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDragDroppingContent_FunctionAddress, intPtr, GetDragDroppingContent_ParamsSize);
		return UObjectMarshaler<UDragDropOperation>.FromNative(IntPtr.Add(intPtr, GetDragDroppingContent_ReturnValue_Offset), 0, GetDragDroppingContent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:GetBrushResourceAsTexture2D")]
	public unsafe static UTexture2D GetBrushResourceAsTexture2D(FSlateBrush Brush)
	{
		if (!GetBrushResourceAsTexture2D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:GetBrushResourceAsTexture2D");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBrushResourceAsTexture2D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBrushResourceAsTexture2D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBrushResourceAsTexture2D_Brush_PropertyAddress.Address, intPtr);
		FSlateBrush.ToNative(IntPtr.Add(intPtr, GetBrushResourceAsTexture2D_Brush_Offset), 0, GetBrushResourceAsTexture2D_Brush_PropertyAddress.Address, Brush);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBrushResourceAsTexture2D_FunctionAddress, intPtr, GetBrushResourceAsTexture2D_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBrushResourceAsTexture2D_Brush_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, GetBrushResourceAsTexture2D_ReturnValue_Offset), 0, GetBrushResourceAsTexture2D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:GetBrushResourceAsMaterial")]
	public unsafe static UMaterialInterface GetBrushResourceAsMaterial(FSlateBrush Brush)
	{
		if (!GetBrushResourceAsMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:GetBrushResourceAsMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBrushResourceAsMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBrushResourceAsMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBrushResourceAsMaterial_Brush_PropertyAddress.Address, intPtr);
		FSlateBrush.ToNative(IntPtr.Add(intPtr, GetBrushResourceAsMaterial_Brush_Offset), 0, GetBrushResourceAsMaterial_Brush_PropertyAddress.Address, Brush);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBrushResourceAsMaterial_FunctionAddress, intPtr, GetBrushResourceAsMaterial_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBrushResourceAsMaterial_Brush_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(intPtr, GetBrushResourceAsMaterial_ReturnValue_Offset), 0, GetBrushResourceAsMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:GetBrushResource")]
	public unsafe static UObject GetBrushResource(FSlateBrush Brush)
	{
		if (!GetBrushResource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:GetBrushResource");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBrushResource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBrushResource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBrushResource_Brush_PropertyAddress.Address, intPtr);
		FSlateBrush.ToNative(IntPtr.Add(intPtr, GetBrushResource_Brush_Offset), 0, GetBrushResource_Brush_PropertyAddress.Address, Brush);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBrushResource_FunctionAddress, intPtr, GetBrushResource_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBrushResource_Brush_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetBrushResource_ReturnValue_Offset), 0, GetBrushResource_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443465u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:GetAllWidgetsWithInterface")]
	public unsafe static void GetAllWidgetsWithInterface(UObject WorldContextObject, out List<UUserWidget> FoundWidgets, TSubclassOfInterface<IInterface> Interface, bool TopLevelOnly)
	{
		if (!GetAllWidgetsWithInterface_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:GetAllWidgetsWithInterface");
			FoundWidgets = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllWidgetsWithInterface_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllWidgetsWithInterface_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetAllWidgetsWithInterface_WorldContextObject_Offset), 0, GetAllWidgetsWithInterface_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		TSubclassOfInterfaceMarshaler<IInterface>.ToNative(IntPtr.Add(intPtr, GetAllWidgetsWithInterface_Interface_Offset), 0, GetAllWidgetsWithInterface_Interface_PropertyAddress.Address, Interface);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAllWidgetsWithInterface_TopLevelOnly_Offset), 0, GetAllWidgetsWithInterface_TopLevelOnly_PropertyAddress.Address, TopLevelOnly);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllWidgetsWithInterface_FunctionAddress, intPtr, GetAllWidgetsWithInterface_ParamsSize);
		FoundWidgets = new TArrayCopyMarshaler<UUserWidget>(1, GetAllWidgetsWithInterface_FoundWidgets_PropertyAddress, CachedMarshalingDelegates<UUserWidget, UObjectMarshaler<UUserWidget>>.FromNative, CachedMarshalingDelegates<UUserWidget, UObjectMarshaler<UUserWidget>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllWidgetsWithInterface_FoundWidgets_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllWidgetsWithInterface_FoundWidgets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443465u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:GetAllWidgetsOfClass")]
	public unsafe static void GetAllWidgetsOfClass(UObject WorldContextObject, out List<UUserWidget> FoundWidgets, TSubclassOf<UUserWidget> WidgetClass, bool TopLevelOnly = true)
	{
		if (!GetAllWidgetsOfClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:GetAllWidgetsOfClass");
			FoundWidgets = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllWidgetsOfClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllWidgetsOfClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetAllWidgetsOfClass_WorldContextObject_Offset), 0, GetAllWidgetsOfClass_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, GetAllWidgetsOfClass_WidgetClass_Offset), 0, GetAllWidgetsOfClass_WidgetClass_PropertyAddress.Address, WidgetClass);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAllWidgetsOfClass_TopLevelOnly_Offset), 0, GetAllWidgetsOfClass_TopLevelOnly_PropertyAddress.Address, TopLevelOnly);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllWidgetsOfClass_FunctionAddress, intPtr, GetAllWidgetsOfClass_ParamsSize);
		FoundWidgets = new TArrayCopyMarshaler<UUserWidget>(1, GetAllWidgetsOfClass_FoundWidgets_PropertyAddress, CachedMarshalingDelegates<UUserWidget, UObjectMarshaler<UUserWidget>>.FromNative, CachedMarshalingDelegates<UUserWidget, UObjectMarshaler<UUserWidget>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllWidgetsOfClass_FoundWidgets_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllWidgetsOfClass_FoundWidgets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:EndDragDrop")]
	public unsafe static FEventReply EndDragDrop(ref FEventReply Reply)
	{
		if (!EndDragDrop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:EndDragDrop");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndDragDrop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndDragDrop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(EndDragDrop_Reply_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(intPtr, EndDragDrop_Reply_Offset), 0, EndDragDrop_Reply_PropertyAddress.Address, Reply);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EndDragDrop_FunctionAddress, intPtr, EndDragDrop_ParamsSize);
		Reply = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, EndDragDrop_Reply_Offset), 0, EndDragDrop_Reply_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EndDragDrop_Reply_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, EndDragDrop_ReturnValue_Offset), 0, EndDragDrop_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(EndDragDrop_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:DrawTextFormatted")]
	public unsafe static void DrawTextFormatted(ref FPaintContext Context, FText Text, FVector2D Position, UFont Font, int FontSize, FName FontTypeFace, FLinearColor Tint)
	{
		if (!DrawTextFormatted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:DrawTextFormatted");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawTextFormatted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawTextFormatted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DrawTextFormatted_Context_PropertyAddress.Address, intPtr);
		FPaintContext.ToNative(IntPtr.Add(intPtr, DrawTextFormatted_Context_Offset), 0, DrawTextFormatted_Context_PropertyAddress.Address, Context);
		NativeReflection.InitializeValue_InContainer(DrawTextFormatted_Text_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, DrawTextFormatted_Text_Offset), 0, DrawTextFormatted_Text_PropertyAddress.Address, Text);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawTextFormatted_Position_Offset), 0, DrawTextFormatted_Position_PropertyAddress.Address, Position);
		UObjectMarshaler<UFont>.ToNative(IntPtr.Add(intPtr, DrawTextFormatted_Font_Offset), 0, DrawTextFormatted_Font_PropertyAddress.Address, Font);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawTextFormatted_FontSize_Offset), 0, DrawTextFormatted_FontSize_PropertyAddress.Address, FontSize);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DrawTextFormatted_FontTypeFace_Offset), 0, DrawTextFormatted_FontTypeFace_PropertyAddress.Address, FontTypeFace);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawTextFormatted_Tint_Offset), 0, DrawTextFormatted_Tint_PropertyAddress.Address, Tint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawTextFormatted_FunctionAddress, intPtr, DrawTextFormatted_ParamsSize);
		Context = FPaintContext.FromNative(IntPtr.Add(intPtr, DrawTextFormatted_Context_Offset), 0, DrawTextFormatted_Context_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(DrawTextFormatted_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:DrawLines")]
	public unsafe static void DrawLines(ref FPaintContext Context, List<FVector2D> Points, FLinearColor Tint, bool bAntiAlias, float Thickness)
	{
		if (!DrawLines_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:DrawLines");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawLines_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawLines_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DrawLines_Context_PropertyAddress.Address, intPtr);
		FPaintContext.ToNative(IntPtr.Add(intPtr, DrawLines_Context_Offset), 0, DrawLines_Context_PropertyAddress.Address, Context);
		new TArrayCopyMarshaler<FVector2D>(1, DrawLines_Points_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(intPtr, DrawLines_Points_Offset), Points);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawLines_Tint_Offset), 0, DrawLines_Tint_PropertyAddress.Address, Tint);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawLines_bAntiAlias_Offset), 0, DrawLines_bAntiAlias_PropertyAddress.Address, bAntiAlias);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawLines_Thickness_Offset), 0, DrawLines_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawLines_FunctionAddress, intPtr, DrawLines_ParamsSize);
		Context = FPaintContext.FromNative(IntPtr.Add(intPtr, DrawLines_Context_Offset), 0, DrawLines_Context_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(DrawLines_Points_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:DrawLine")]
	public unsafe static void DrawLine(ref FPaintContext Context, FVector2D PositionA, FVector2D PositionB, FLinearColor Tint, bool bAntiAlias, float Thickness)
	{
		if (!DrawLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:DrawLine");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DrawLine_Context_PropertyAddress.Address, intPtr);
		FPaintContext.ToNative(IntPtr.Add(intPtr, DrawLine_Context_Offset), 0, DrawLine_Context_PropertyAddress.Address, Context);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawLine_PositionA_Offset), 0, DrawLine_PositionA_PropertyAddress.Address, PositionA);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawLine_PositionB_Offset), 0, DrawLine_PositionB_PropertyAddress.Address, PositionB);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawLine_Tint_Offset), 0, DrawLine_Tint_PropertyAddress.Address, Tint);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawLine_bAntiAlias_Offset), 0, DrawLine_bAntiAlias_PropertyAddress.Address, bAntiAlias);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawLine_Thickness_Offset), 0, DrawLine_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawLine_FunctionAddress, intPtr, DrawLine_ParamsSize);
		Context = FPaintContext.FromNative(IntPtr.Add(intPtr, DrawLine_Context_Offset), 0, DrawLine_Context_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:DrawBox")]
	public unsafe static void DrawBox(ref FPaintContext Context, FVector2D Position, FVector2D Size, USlateBrushAsset Brush, FLinearColor Tint)
	{
		if (!DrawBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:DrawBox");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DrawBox_Context_PropertyAddress.Address, intPtr);
		FPaintContext.ToNative(IntPtr.Add(intPtr, DrawBox_Context_Offset), 0, DrawBox_Context_PropertyAddress.Address, Context);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawBox_Position_Offset), 0, DrawBox_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawBox_Size_Offset), 0, DrawBox_Size_PropertyAddress.Address, Size);
		UObjectMarshaler<USlateBrushAsset>.ToNative(IntPtr.Add(intPtr, DrawBox_Brush_Offset), 0, DrawBox_Brush_PropertyAddress.Address, Brush);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawBox_Tint_Offset), 0, DrawBox_Tint_PropertyAddress.Address, Tint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawBox_FunctionAddress, intPtr, DrawBox_ParamsSize);
		Context = FPaintContext.FromNative(IntPtr.Add(intPtr, DrawBox_Context_Offset), 0, DrawBox_Context_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:DismissAllMenus")]
	public unsafe static void DismissAllMenus()
	{
		if (!DismissAllMenus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:DismissAllMenus");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DismissAllMenus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DismissAllMenus_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: DismissAllMenus_FunctionAddress, argsSize: DismissAllMenus_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:DetectDragIfPressed")]
	public unsafe static FEventReply DetectDragIfPressed(FPointerEvent PointerEvent, UWidget WidgetDetectingDrag, FKey DragKey)
	{
		if (!DetectDragIfPressed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:DetectDragIfPressed");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DetectDragIfPressed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DetectDragIfPressed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DetectDragIfPressed_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, DetectDragIfPressed_PointerEvent_Offset), 0, DetectDragIfPressed_PointerEvent_PropertyAddress.Address, PointerEvent);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, DetectDragIfPressed_WidgetDetectingDrag_Offset), 0, DetectDragIfPressed_WidgetDetectingDrag_PropertyAddress.Address, WidgetDetectingDrag);
		NativeReflection.InitializeValue_InContainer(DetectDragIfPressed_DragKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, DetectDragIfPressed_DragKey_Offset), 0, DetectDragIfPressed_DragKey_PropertyAddress.Address, DragKey);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DetectDragIfPressed_FunctionAddress, intPtr, DetectDragIfPressed_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DetectDragIfPressed_PointerEvent_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DetectDragIfPressed_DragKey_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, DetectDragIfPressed_ReturnValue_Offset), 0, DetectDragIfPressed_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(DetectDragIfPressed_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:DetectDrag")]
	public unsafe static FEventReply DetectDrag(ref FEventReply Reply, UWidget WidgetDetectingDrag, FKey DragKey)
	{
		if (!DetectDrag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:DetectDrag");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DetectDrag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DetectDrag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DetectDrag_Reply_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(intPtr, DetectDrag_Reply_Offset), 0, DetectDrag_Reply_PropertyAddress.Address, Reply);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, DetectDrag_WidgetDetectingDrag_Offset), 0, DetectDrag_WidgetDetectingDrag_PropertyAddress.Address, WidgetDetectingDrag);
		NativeReflection.InitializeValue_InContainer(DetectDrag_DragKey_PropertyAddress.Address, intPtr);
		FKey.ToNative(IntPtr.Add(intPtr, DetectDrag_DragKey_Offset), 0, DetectDrag_DragKey_PropertyAddress.Address, DragKey);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DetectDrag_FunctionAddress, intPtr, DetectDrag_ParamsSize);
		Reply = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, DetectDrag_Reply_Offset), 0, DetectDrag_Reply_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(DetectDrag_Reply_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DetectDrag_DragKey_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, DetectDrag_ReturnValue_Offset), 0, DetectDrag_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(DetectDrag_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:ClearUserFocus")]
	public unsafe static FEventReply ClearUserFocus(ref FEventReply Reply, bool bInAllUsers = false)
	{
		if (!ClearUserFocus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:ClearUserFocus");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearUserFocus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearUserFocus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ClearUserFocus_Reply_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(intPtr, ClearUserFocus_Reply_Offset), 0, ClearUserFocus_Reply_PropertyAddress.Address, Reply);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ClearUserFocus_bInAllUsers_Offset), 0, ClearUserFocus_bInAllUsers_PropertyAddress.Address, bInAllUsers);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearUserFocus_FunctionAddress, intPtr, ClearUserFocus_ParamsSize);
		Reply = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, ClearUserFocus_Reply_Offset), 0, ClearUserFocus_Reply_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ClearUserFocus_Reply_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, ClearUserFocus_ReturnValue_Offset), 0, ClearUserFocus_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ClearUserFocus_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:CaptureMouse")]
	public unsafe static FEventReply CaptureMouse(ref FEventReply Reply, UWidget CapturingWidget)
	{
		if (!CaptureMouse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:CaptureMouse");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CaptureMouse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CaptureMouse_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CaptureMouse_Reply_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(intPtr, CaptureMouse_Reply_Offset), 0, CaptureMouse_Reply_PropertyAddress.Address, Reply);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, CaptureMouse_CapturingWidget_Offset), 0, CaptureMouse_CapturingWidget_PropertyAddress.Address, CapturingWidget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CaptureMouse_FunctionAddress, intPtr, CaptureMouse_ParamsSize);
		Reply = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, CaptureMouse_Reply_Offset), 0, CaptureMouse_Reply_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CaptureMouse_Reply_PropertyAddress.Address, intPtr);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, CaptureMouse_ReturnValue_Offset), 0, CaptureMouse_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CaptureMouse_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UMG.WidgetBlueprintLibrary:CancelDragDrop")]
	public unsafe static void CancelDragDrop()
	{
		if (!CancelDragDrop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetBlueprintLibrary:CancelDragDrop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CancelDragDrop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CancelDragDrop_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CancelDragDrop_FunctionAddress, argsSize: CancelDragDrop_ParamsSize);
	}

	static UWidgetLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWidgetLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWidgetLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UMG.WidgetBlueprintLibrary");
		UnlockMouse_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnlockMouse");
		UnlockMouse_ParamsSize = NativeReflection.GetFunctionParamsSize(UnlockMouse_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnlockMouse_Reply_PropertyAddress, UnlockMouse_FunctionAddress, "Reply");
		UnlockMouse_Reply_Offset = NativeReflectionCached.GetPropertyOffset(UnlockMouse_FunctionAddress, "Reply");
		UnlockMouse_Reply_IsValid = NativeReflectionCached.ValidatePropertyClass(UnlockMouse_FunctionAddress, "Reply", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UnlockMouse_ReturnValue_PropertyAddress, UnlockMouse_FunctionAddress, "ReturnValue");
		UnlockMouse_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(UnlockMouse_FunctionAddress, "ReturnValue");
		UnlockMouse_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UnlockMouse_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		UnlockMouse_IsValid = UnlockMouse_FunctionAddress != IntPtr.Zero && UnlockMouse_Reply_IsValid && UnlockMouse_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:UnlockMouse", UnlockMouse_IsValid);
		Unhandled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Unhandled");
		Unhandled_ParamsSize = NativeReflection.GetFunctionParamsSize(Unhandled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Unhandled_ReturnValue_PropertyAddress, Unhandled_FunctionAddress, "ReturnValue");
		Unhandled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Unhandled_FunctionAddress, "ReturnValue");
		Unhandled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Unhandled_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Unhandled_IsValid = Unhandled_FunctionAddress != IntPtr.Zero && Unhandled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:Unhandled", Unhandled_IsValid);
		SetWindowTitleBarState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetWindowTitleBarState");
		SetWindowTitleBarState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWindowTitleBarState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWindowTitleBarState_TitleBarContent_PropertyAddress, SetWindowTitleBarState_FunctionAddress, "TitleBarContent");
		SetWindowTitleBarState_TitleBarContent_Offset = NativeReflectionCached.GetPropertyOffset(SetWindowTitleBarState_FunctionAddress, "TitleBarContent");
		SetWindowTitleBarState_TitleBarContent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWindowTitleBarState_FunctionAddress, "TitleBarContent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWindowTitleBarState_Mode_PropertyAddress, SetWindowTitleBarState_FunctionAddress, "Mode");
		SetWindowTitleBarState_Mode_Offset = NativeReflectionCached.GetPropertyOffset(SetWindowTitleBarState_FunctionAddress, "Mode");
		SetWindowTitleBarState_Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWindowTitleBarState_FunctionAddress, "Mode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWindowTitleBarState_bTitleBarDragEnabled_PropertyAddress, SetWindowTitleBarState_FunctionAddress, "bTitleBarDragEnabled");
		SetWindowTitleBarState_bTitleBarDragEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetWindowTitleBarState_FunctionAddress, "bTitleBarDragEnabled");
		SetWindowTitleBarState_bTitleBarDragEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWindowTitleBarState_FunctionAddress, "bTitleBarDragEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWindowTitleBarState_bWindowButtonsVisible_PropertyAddress, SetWindowTitleBarState_FunctionAddress, "bWindowButtonsVisible");
		SetWindowTitleBarState_bWindowButtonsVisible_Offset = NativeReflectionCached.GetPropertyOffset(SetWindowTitleBarState_FunctionAddress, "bWindowButtonsVisible");
		SetWindowTitleBarState_bWindowButtonsVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWindowTitleBarState_FunctionAddress, "bWindowButtonsVisible", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWindowTitleBarState_bTitleBarVisible_PropertyAddress, SetWindowTitleBarState_FunctionAddress, "bTitleBarVisible");
		SetWindowTitleBarState_bTitleBarVisible_Offset = NativeReflectionCached.GetPropertyOffset(SetWindowTitleBarState_FunctionAddress, "bTitleBarVisible");
		SetWindowTitleBarState_bTitleBarVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWindowTitleBarState_FunctionAddress, "bTitleBarVisible", Classes.FBoolProperty);
		SetWindowTitleBarState_IsValid = SetWindowTitleBarState_FunctionAddress != IntPtr.Zero && SetWindowTitleBarState_TitleBarContent_IsValid && SetWindowTitleBarState_Mode_IsValid && SetWindowTitleBarState_bTitleBarDragEnabled_IsValid && SetWindowTitleBarState_bWindowButtonsVisible_IsValid && SetWindowTitleBarState_bTitleBarVisible_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:SetWindowTitleBarState", SetWindowTitleBarState_IsValid);
		SetWindowTitleBarOnCloseClickedDelegate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetWindowTitleBarOnCloseClickedDelegate");
		SetWindowTitleBarOnCloseClickedDelegate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWindowTitleBarOnCloseClickedDelegate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWindowTitleBarOnCloseClickedDelegate_Delegate_PropertyAddress, SetWindowTitleBarOnCloseClickedDelegate_FunctionAddress, "Delegate");
		SetWindowTitleBarOnCloseClickedDelegate_Delegate_Offset = NativeReflectionCached.GetPropertyOffset(SetWindowTitleBarOnCloseClickedDelegate_FunctionAddress, "Delegate");
		SetWindowTitleBarOnCloseClickedDelegate_Delegate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWindowTitleBarOnCloseClickedDelegate_FunctionAddress, "Delegate", Classes.FDelegateProperty);
		SetWindowTitleBarOnCloseClickedDelegate_IsValid = SetWindowTitleBarOnCloseClickedDelegate_FunctionAddress != IntPtr.Zero && SetWindowTitleBarOnCloseClickedDelegate_Delegate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:SetWindowTitleBarOnCloseClickedDelegate", SetWindowTitleBarOnCloseClickedDelegate_IsValid);
		SetWindowTitleBarCloseButtonActive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetWindowTitleBarCloseButtonActive");
		SetWindowTitleBarCloseButtonActive_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWindowTitleBarCloseButtonActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWindowTitleBarCloseButtonActive_bActive_PropertyAddress, SetWindowTitleBarCloseButtonActive_FunctionAddress, "bActive");
		SetWindowTitleBarCloseButtonActive_bActive_Offset = NativeReflectionCached.GetPropertyOffset(SetWindowTitleBarCloseButtonActive_FunctionAddress, "bActive");
		SetWindowTitleBarCloseButtonActive_bActive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWindowTitleBarCloseButtonActive_FunctionAddress, "bActive", Classes.FBoolProperty);
		SetWindowTitleBarCloseButtonActive_IsValid = SetWindowTitleBarCloseButtonActive_FunctionAddress != IntPtr.Zero && SetWindowTitleBarCloseButtonActive_bActive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:SetWindowTitleBarCloseButtonActive", SetWindowTitleBarCloseButtonActive_IsValid);
		SetUserFocus_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetUserFocus");
		SetUserFocus_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUserFocus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUserFocus_Reply_PropertyAddress, SetUserFocus_FunctionAddress, "Reply");
		SetUserFocus_Reply_Offset = NativeReflectionCached.GetPropertyOffset(SetUserFocus_FunctionAddress, "Reply");
		SetUserFocus_Reply_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUserFocus_FunctionAddress, "Reply", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUserFocus_FocusWidget_PropertyAddress, SetUserFocus_FunctionAddress, "FocusWidget");
		SetUserFocus_FocusWidget_Offset = NativeReflectionCached.GetPropertyOffset(SetUserFocus_FunctionAddress, "FocusWidget");
		SetUserFocus_FocusWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUserFocus_FunctionAddress, "FocusWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUserFocus_bInAllUsers_PropertyAddress, SetUserFocus_FunctionAddress, "bInAllUsers");
		SetUserFocus_bInAllUsers_Offset = NativeReflectionCached.GetPropertyOffset(SetUserFocus_FunctionAddress, "bInAllUsers");
		SetUserFocus_bInAllUsers_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUserFocus_FunctionAddress, "bInAllUsers", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUserFocus_ReturnValue_PropertyAddress, SetUserFocus_FunctionAddress, "ReturnValue");
		SetUserFocus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetUserFocus_FunctionAddress, "ReturnValue");
		SetUserFocus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUserFocus_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetUserFocus_IsValid = SetUserFocus_FunctionAddress != IntPtr.Zero && SetUserFocus_Reply_IsValid && SetUserFocus_FocusWidget_IsValid && SetUserFocus_bInAllUsers_IsValid && SetUserFocus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:SetUserFocus", SetUserFocus_IsValid);
		SetMousePosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMousePosition");
		SetMousePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMousePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMousePosition_Reply_PropertyAddress, SetMousePosition_FunctionAddress, "Reply");
		SetMousePosition_Reply_Offset = NativeReflectionCached.GetPropertyOffset(SetMousePosition_FunctionAddress, "Reply");
		SetMousePosition_Reply_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMousePosition_FunctionAddress, "Reply", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMousePosition_NewMousePosition_PropertyAddress, SetMousePosition_FunctionAddress, "NewMousePosition");
		SetMousePosition_NewMousePosition_Offset = NativeReflectionCached.GetPropertyOffset(SetMousePosition_FunctionAddress, "NewMousePosition");
		SetMousePosition_NewMousePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMousePosition_FunctionAddress, "NewMousePosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMousePosition_ReturnValue_PropertyAddress, SetMousePosition_FunctionAddress, "ReturnValue");
		SetMousePosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetMousePosition_FunctionAddress, "ReturnValue");
		SetMousePosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMousePosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetMousePosition_IsValid = SetMousePosition_FunctionAddress != IntPtr.Zero && SetMousePosition_Reply_IsValid && SetMousePosition_NewMousePosition_IsValid && SetMousePosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:SetMousePosition", SetMousePosition_IsValid);
		SetInputMode_UIOnlyEx_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInputMode_UIOnlyEx");
		SetInputMode_UIOnlyEx_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInputMode_UIOnlyEx_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInputMode_UIOnlyEx_PlayerController_PropertyAddress, SetInputMode_UIOnlyEx_FunctionAddress, "PlayerController");
		SetInputMode_UIOnlyEx_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(SetInputMode_UIOnlyEx_FunctionAddress, "PlayerController");
		SetInputMode_UIOnlyEx_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputMode_UIOnlyEx_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInputMode_UIOnlyEx_InWidgetToFocus_PropertyAddress, SetInputMode_UIOnlyEx_FunctionAddress, "InWidgetToFocus");
		SetInputMode_UIOnlyEx_InWidgetToFocus_Offset = NativeReflectionCached.GetPropertyOffset(SetInputMode_UIOnlyEx_FunctionAddress, "InWidgetToFocus");
		SetInputMode_UIOnlyEx_InWidgetToFocus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputMode_UIOnlyEx_FunctionAddress, "InWidgetToFocus", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInputMode_UIOnlyEx_InMouseLockMode_PropertyAddress, SetInputMode_UIOnlyEx_FunctionAddress, "InMouseLockMode");
		SetInputMode_UIOnlyEx_InMouseLockMode_Offset = NativeReflectionCached.GetPropertyOffset(SetInputMode_UIOnlyEx_FunctionAddress, "InMouseLockMode");
		SetInputMode_UIOnlyEx_InMouseLockMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputMode_UIOnlyEx_FunctionAddress, "InMouseLockMode", Classes.FEnumProperty);
		SetInputMode_UIOnlyEx_IsValid = SetInputMode_UIOnlyEx_FunctionAddress != IntPtr.Zero && SetInputMode_UIOnlyEx_PlayerController_IsValid && SetInputMode_UIOnlyEx_InWidgetToFocus_IsValid && SetInputMode_UIOnlyEx_InMouseLockMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:SetInputMode_UIOnlyEx", SetInputMode_UIOnlyEx_IsValid);
		SetInputMode_GameOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInputMode_GameOnly");
		SetInputMode_GameOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInputMode_GameOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInputMode_GameOnly_PlayerController_PropertyAddress, SetInputMode_GameOnly_FunctionAddress, "PlayerController");
		SetInputMode_GameOnly_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(SetInputMode_GameOnly_FunctionAddress, "PlayerController");
		SetInputMode_GameOnly_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputMode_GameOnly_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		SetInputMode_GameOnly_IsValid = SetInputMode_GameOnly_FunctionAddress != IntPtr.Zero && SetInputMode_GameOnly_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:SetInputMode_GameOnly", SetInputMode_GameOnly_IsValid);
		SetInputMode_GameAndUIEx_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInputMode_GameAndUIEx");
		SetInputMode_GameAndUIEx_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInputMode_GameAndUIEx_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInputMode_GameAndUIEx_PlayerController_PropertyAddress, SetInputMode_GameAndUIEx_FunctionAddress, "PlayerController");
		SetInputMode_GameAndUIEx_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(SetInputMode_GameAndUIEx_FunctionAddress, "PlayerController");
		SetInputMode_GameAndUIEx_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputMode_GameAndUIEx_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInputMode_GameAndUIEx_InWidgetToFocus_PropertyAddress, SetInputMode_GameAndUIEx_FunctionAddress, "InWidgetToFocus");
		SetInputMode_GameAndUIEx_InWidgetToFocus_Offset = NativeReflectionCached.GetPropertyOffset(SetInputMode_GameAndUIEx_FunctionAddress, "InWidgetToFocus");
		SetInputMode_GameAndUIEx_InWidgetToFocus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputMode_GameAndUIEx_FunctionAddress, "InWidgetToFocus", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInputMode_GameAndUIEx_InMouseLockMode_PropertyAddress, SetInputMode_GameAndUIEx_FunctionAddress, "InMouseLockMode");
		SetInputMode_GameAndUIEx_InMouseLockMode_Offset = NativeReflectionCached.GetPropertyOffset(SetInputMode_GameAndUIEx_FunctionAddress, "InMouseLockMode");
		SetInputMode_GameAndUIEx_InMouseLockMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputMode_GameAndUIEx_FunctionAddress, "InMouseLockMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInputMode_GameAndUIEx_bHideCursorDuringCapture_PropertyAddress, SetInputMode_GameAndUIEx_FunctionAddress, "bHideCursorDuringCapture");
		SetInputMode_GameAndUIEx_bHideCursorDuringCapture_Offset = NativeReflectionCached.GetPropertyOffset(SetInputMode_GameAndUIEx_FunctionAddress, "bHideCursorDuringCapture");
		SetInputMode_GameAndUIEx_bHideCursorDuringCapture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputMode_GameAndUIEx_FunctionAddress, "bHideCursorDuringCapture", Classes.FBoolProperty);
		SetInputMode_GameAndUIEx_IsValid = SetInputMode_GameAndUIEx_FunctionAddress != IntPtr.Zero && SetInputMode_GameAndUIEx_PlayerController_IsValid && SetInputMode_GameAndUIEx_InWidgetToFocus_IsValid && SetInputMode_GameAndUIEx_InMouseLockMode_IsValid && SetInputMode_GameAndUIEx_bHideCursorDuringCapture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:SetInputMode_GameAndUIEx", SetInputMode_GameAndUIEx_IsValid);
		SetHardwareCursor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetHardwareCursor");
		SetHardwareCursor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHardwareCursor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHardwareCursor_WorldContextObject_PropertyAddress, SetHardwareCursor_FunctionAddress, "WorldContextObject");
		SetHardwareCursor_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetHardwareCursor_FunctionAddress, "WorldContextObject");
		SetHardwareCursor_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHardwareCursor_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHardwareCursor_CursorShape_PropertyAddress, SetHardwareCursor_FunctionAddress, "CursorShape");
		SetHardwareCursor_CursorShape_Offset = NativeReflectionCached.GetPropertyOffset(SetHardwareCursor_FunctionAddress, "CursorShape");
		SetHardwareCursor_CursorShape_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHardwareCursor_FunctionAddress, "CursorShape", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHardwareCursor_CursorName_PropertyAddress, SetHardwareCursor_FunctionAddress, "CursorName");
		SetHardwareCursor_CursorName_Offset = NativeReflectionCached.GetPropertyOffset(SetHardwareCursor_FunctionAddress, "CursorName");
		SetHardwareCursor_CursorName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHardwareCursor_FunctionAddress, "CursorName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHardwareCursor_HotSpot_PropertyAddress, SetHardwareCursor_FunctionAddress, "HotSpot");
		SetHardwareCursor_HotSpot_Offset = NativeReflectionCached.GetPropertyOffset(SetHardwareCursor_FunctionAddress, "HotSpot");
		SetHardwareCursor_HotSpot_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHardwareCursor_FunctionAddress, "HotSpot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHardwareCursor_ReturnValue_PropertyAddress, SetHardwareCursor_FunctionAddress, "ReturnValue");
		SetHardwareCursor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetHardwareCursor_FunctionAddress, "ReturnValue");
		SetHardwareCursor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHardwareCursor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetHardwareCursor_IsValid = SetHardwareCursor_FunctionAddress != IntPtr.Zero && SetHardwareCursor_WorldContextObject_IsValid && SetHardwareCursor_CursorShape_IsValid && SetHardwareCursor_CursorName_IsValid && SetHardwareCursor_HotSpot_IsValid && SetHardwareCursor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:SetHardwareCursor", SetHardwareCursor_IsValid);
		SetFocusToGameViewport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFocusToGameViewport");
		SetFocusToGameViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFocusToGameViewport_FunctionAddress);
		SetFocusToGameViewport_IsValid = SetFocusToGameViewport_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:SetFocusToGameViewport", SetFocusToGameViewport_IsValid);
		SetColorVisionDeficiencyType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetColorVisionDeficiencyType");
		SetColorVisionDeficiencyType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetColorVisionDeficiencyType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetColorVisionDeficiencyType_Type_PropertyAddress, SetColorVisionDeficiencyType_FunctionAddress, "Type");
		SetColorVisionDeficiencyType_Type_Offset = NativeReflectionCached.GetPropertyOffset(SetColorVisionDeficiencyType_FunctionAddress, "Type");
		SetColorVisionDeficiencyType_Type_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorVisionDeficiencyType_FunctionAddress, "Type", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetColorVisionDeficiencyType_Severity_PropertyAddress, SetColorVisionDeficiencyType_FunctionAddress, "Severity");
		SetColorVisionDeficiencyType_Severity_Offset = NativeReflectionCached.GetPropertyOffset(SetColorVisionDeficiencyType_FunctionAddress, "Severity");
		SetColorVisionDeficiencyType_Severity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorVisionDeficiencyType_FunctionAddress, "Severity", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetColorVisionDeficiencyType_CorrectDeficiency_PropertyAddress, SetColorVisionDeficiencyType_FunctionAddress, "CorrectDeficiency");
		SetColorVisionDeficiencyType_CorrectDeficiency_Offset = NativeReflectionCached.GetPropertyOffset(SetColorVisionDeficiencyType_FunctionAddress, "CorrectDeficiency");
		SetColorVisionDeficiencyType_CorrectDeficiency_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorVisionDeficiencyType_FunctionAddress, "CorrectDeficiency", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetColorVisionDeficiencyType_ShowCorrectionWithDeficiency_PropertyAddress, SetColorVisionDeficiencyType_FunctionAddress, "ShowCorrectionWithDeficiency");
		SetColorVisionDeficiencyType_ShowCorrectionWithDeficiency_Offset = NativeReflectionCached.GetPropertyOffset(SetColorVisionDeficiencyType_FunctionAddress, "ShowCorrectionWithDeficiency");
		SetColorVisionDeficiencyType_ShowCorrectionWithDeficiency_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorVisionDeficiencyType_FunctionAddress, "ShowCorrectionWithDeficiency", Classes.FBoolProperty);
		SetColorVisionDeficiencyType_IsValid = SetColorVisionDeficiencyType_FunctionAddress != IntPtr.Zero && SetColorVisionDeficiencyType_Type_IsValid && SetColorVisionDeficiencyType_Severity_IsValid && SetColorVisionDeficiencyType_CorrectDeficiency_IsValid && SetColorVisionDeficiencyType_ShowCorrectionWithDeficiency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:SetColorVisionDeficiencyType", SetColorVisionDeficiencyType_IsValid);
		SetBrushResourceToTexture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBrushResourceToTexture");
		SetBrushResourceToTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushResourceToTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushResourceToTexture_Brush_PropertyAddress, SetBrushResourceToTexture_FunctionAddress, "Brush");
		SetBrushResourceToTexture_Brush_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushResourceToTexture_FunctionAddress, "Brush");
		SetBrushResourceToTexture_Brush_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushResourceToTexture_FunctionAddress, "Brush", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBrushResourceToTexture_Texture_PropertyAddress, SetBrushResourceToTexture_FunctionAddress, "Texture");
		SetBrushResourceToTexture_Texture_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushResourceToTexture_FunctionAddress, "Texture");
		SetBrushResourceToTexture_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushResourceToTexture_FunctionAddress, "Texture", Classes.FObjectProperty);
		SetBrushResourceToTexture_IsValid = SetBrushResourceToTexture_FunctionAddress != IntPtr.Zero && SetBrushResourceToTexture_Brush_IsValid && SetBrushResourceToTexture_Texture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:SetBrushResourceToTexture", SetBrushResourceToTexture_IsValid);
		SetBrushResourceToMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBrushResourceToMaterial");
		SetBrushResourceToMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBrushResourceToMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBrushResourceToMaterial_Brush_PropertyAddress, SetBrushResourceToMaterial_FunctionAddress, "Brush");
		SetBrushResourceToMaterial_Brush_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushResourceToMaterial_FunctionAddress, "Brush");
		SetBrushResourceToMaterial_Brush_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushResourceToMaterial_FunctionAddress, "Brush", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBrushResourceToMaterial_Material_PropertyAddress, SetBrushResourceToMaterial_FunctionAddress, "Material");
		SetBrushResourceToMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetBrushResourceToMaterial_FunctionAddress, "Material");
		SetBrushResourceToMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBrushResourceToMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		SetBrushResourceToMaterial_IsValid = SetBrushResourceToMaterial_FunctionAddress != IntPtr.Zero && SetBrushResourceToMaterial_Brush_IsValid && SetBrushResourceToMaterial_Material_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:SetBrushResourceToMaterial", SetBrushResourceToMaterial_IsValid);
		RestorePreviousWindowTitleBarState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RestorePreviousWindowTitleBarState");
		RestorePreviousWindowTitleBarState_ParamsSize = NativeReflection.GetFunctionParamsSize(RestorePreviousWindowTitleBarState_FunctionAddress);
		RestorePreviousWindowTitleBarState_IsValid = RestorePreviousWindowTitleBarState_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:RestorePreviousWindowTitleBarState", RestorePreviousWindowTitleBarState_IsValid);
		ReleaseMouseCapture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReleaseMouseCapture");
		ReleaseMouseCapture_ParamsSize = NativeReflection.GetFunctionParamsSize(ReleaseMouseCapture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReleaseMouseCapture_Reply_PropertyAddress, ReleaseMouseCapture_FunctionAddress, "Reply");
		ReleaseMouseCapture_Reply_Offset = NativeReflectionCached.GetPropertyOffset(ReleaseMouseCapture_FunctionAddress, "Reply");
		ReleaseMouseCapture_Reply_IsValid = NativeReflectionCached.ValidatePropertyClass(ReleaseMouseCapture_FunctionAddress, "Reply", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReleaseMouseCapture_ReturnValue_PropertyAddress, ReleaseMouseCapture_FunctionAddress, "ReturnValue");
		ReleaseMouseCapture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReleaseMouseCapture_FunctionAddress, "ReturnValue");
		ReleaseMouseCapture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReleaseMouseCapture_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ReleaseMouseCapture_IsValid = ReleaseMouseCapture_FunctionAddress != IntPtr.Zero && ReleaseMouseCapture_Reply_IsValid && ReleaseMouseCapture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:ReleaseMouseCapture", ReleaseMouseCapture_IsValid);
		NoResourceBrush_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NoResourceBrush");
		NoResourceBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(NoResourceBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NoResourceBrush_ReturnValue_PropertyAddress, NoResourceBrush_FunctionAddress, "ReturnValue");
		NoResourceBrush_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NoResourceBrush_FunctionAddress, "ReturnValue");
		NoResourceBrush_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NoResourceBrush_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		NoResourceBrush_IsValid = NoResourceBrush_FunctionAddress != IntPtr.Zero && NoResourceBrush_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:NoResourceBrush", NoResourceBrush_IsValid);
		MakeBrushFromTexture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeBrushFromTexture");
		MakeBrushFromTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeBrushFromTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeBrushFromTexture_Texture_PropertyAddress, MakeBrushFromTexture_FunctionAddress, "Texture");
		MakeBrushFromTexture_Texture_Offset = NativeReflectionCached.GetPropertyOffset(MakeBrushFromTexture_FunctionAddress, "Texture");
		MakeBrushFromTexture_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBrushFromTexture_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeBrushFromTexture_Width_PropertyAddress, MakeBrushFromTexture_FunctionAddress, "Width");
		MakeBrushFromTexture_Width_Offset = NativeReflectionCached.GetPropertyOffset(MakeBrushFromTexture_FunctionAddress, "Width");
		MakeBrushFromTexture_Width_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBrushFromTexture_FunctionAddress, "Width", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeBrushFromTexture_Height_PropertyAddress, MakeBrushFromTexture_FunctionAddress, "Height");
		MakeBrushFromTexture_Height_Offset = NativeReflectionCached.GetPropertyOffset(MakeBrushFromTexture_FunctionAddress, "Height");
		MakeBrushFromTexture_Height_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBrushFromTexture_FunctionAddress, "Height", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeBrushFromTexture_ReturnValue_PropertyAddress, MakeBrushFromTexture_FunctionAddress, "ReturnValue");
		MakeBrushFromTexture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeBrushFromTexture_FunctionAddress, "ReturnValue");
		MakeBrushFromTexture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBrushFromTexture_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeBrushFromTexture_IsValid = MakeBrushFromTexture_FunctionAddress != IntPtr.Zero && MakeBrushFromTexture_Texture_IsValid && MakeBrushFromTexture_Width_IsValid && MakeBrushFromTexture_Height_IsValid && MakeBrushFromTexture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:MakeBrushFromTexture", MakeBrushFromTexture_IsValid);
		MakeBrushFromMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeBrushFromMaterial");
		MakeBrushFromMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeBrushFromMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeBrushFromMaterial_Material_PropertyAddress, MakeBrushFromMaterial_FunctionAddress, "Material");
		MakeBrushFromMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(MakeBrushFromMaterial_FunctionAddress, "Material");
		MakeBrushFromMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBrushFromMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeBrushFromMaterial_Width_PropertyAddress, MakeBrushFromMaterial_FunctionAddress, "Width");
		MakeBrushFromMaterial_Width_Offset = NativeReflectionCached.GetPropertyOffset(MakeBrushFromMaterial_FunctionAddress, "Width");
		MakeBrushFromMaterial_Width_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBrushFromMaterial_FunctionAddress, "Width", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeBrushFromMaterial_Height_PropertyAddress, MakeBrushFromMaterial_FunctionAddress, "Height");
		MakeBrushFromMaterial_Height_Offset = NativeReflectionCached.GetPropertyOffset(MakeBrushFromMaterial_FunctionAddress, "Height");
		MakeBrushFromMaterial_Height_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBrushFromMaterial_FunctionAddress, "Height", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeBrushFromMaterial_ReturnValue_PropertyAddress, MakeBrushFromMaterial_FunctionAddress, "ReturnValue");
		MakeBrushFromMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeBrushFromMaterial_FunctionAddress, "ReturnValue");
		MakeBrushFromMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBrushFromMaterial_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeBrushFromMaterial_IsValid = MakeBrushFromMaterial_FunctionAddress != IntPtr.Zero && MakeBrushFromMaterial_Material_IsValid && MakeBrushFromMaterial_Width_IsValid && MakeBrushFromMaterial_Height_IsValid && MakeBrushFromMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:MakeBrushFromMaterial", MakeBrushFromMaterial_IsValid);
		MakeBrushFromAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeBrushFromAsset");
		MakeBrushFromAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeBrushFromAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeBrushFromAsset_BrushAsset_PropertyAddress, MakeBrushFromAsset_FunctionAddress, "BrushAsset");
		MakeBrushFromAsset_BrushAsset_Offset = NativeReflectionCached.GetPropertyOffset(MakeBrushFromAsset_FunctionAddress, "BrushAsset");
		MakeBrushFromAsset_BrushAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBrushFromAsset_FunctionAddress, "BrushAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeBrushFromAsset_ReturnValue_PropertyAddress, MakeBrushFromAsset_FunctionAddress, "ReturnValue");
		MakeBrushFromAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeBrushFromAsset_FunctionAddress, "ReturnValue");
		MakeBrushFromAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBrushFromAsset_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeBrushFromAsset_IsValid = MakeBrushFromAsset_FunctionAddress != IntPtr.Zero && MakeBrushFromAsset_BrushAsset_IsValid && MakeBrushFromAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:MakeBrushFromAsset", MakeBrushFromAsset_IsValid);
		LockMouse_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LockMouse");
		LockMouse_ParamsSize = NativeReflection.GetFunctionParamsSize(LockMouse_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LockMouse_Reply_PropertyAddress, LockMouse_FunctionAddress, "Reply");
		LockMouse_Reply_Offset = NativeReflectionCached.GetPropertyOffset(LockMouse_FunctionAddress, "Reply");
		LockMouse_Reply_IsValid = NativeReflectionCached.ValidatePropertyClass(LockMouse_FunctionAddress, "Reply", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LockMouse_CapturingWidget_PropertyAddress, LockMouse_FunctionAddress, "CapturingWidget");
		LockMouse_CapturingWidget_Offset = NativeReflectionCached.GetPropertyOffset(LockMouse_FunctionAddress, "CapturingWidget");
		LockMouse_CapturingWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(LockMouse_FunctionAddress, "CapturingWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LockMouse_ReturnValue_PropertyAddress, LockMouse_FunctionAddress, "ReturnValue");
		LockMouse_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LockMouse_FunctionAddress, "ReturnValue");
		LockMouse_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LockMouse_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		LockMouse_IsValid = LockMouse_FunctionAddress != IntPtr.Zero && LockMouse_Reply_IsValid && LockMouse_CapturingWidget_IsValid && LockMouse_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:LockMouse", LockMouse_IsValid);
		IsDragDropping_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsDragDropping");
		IsDragDropping_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDragDropping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDragDropping_ReturnValue_PropertyAddress, IsDragDropping_FunctionAddress, "ReturnValue");
		IsDragDropping_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDragDropping_FunctionAddress, "ReturnValue");
		IsDragDropping_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDragDropping_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDragDropping_IsValid = IsDragDropping_FunctionAddress != IntPtr.Zero && IsDragDropping_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:IsDragDropping", IsDragDropping_IsValid);
		Handled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Handled");
		Handled_ParamsSize = NativeReflection.GetFunctionParamsSize(Handled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Handled_ReturnValue_PropertyAddress, Handled_FunctionAddress, "ReturnValue");
		Handled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Handled_FunctionAddress, "ReturnValue");
		Handled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Handled_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		Handled_IsValid = Handled_FunctionAddress != IntPtr.Zero && Handled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:Handled", Handled_IsValid);
		GetSafeZonePadding_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSafeZonePadding");
		GetSafeZonePadding_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSafeZonePadding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSafeZonePadding_WorldContextObject_PropertyAddress, GetSafeZonePadding_FunctionAddress, "WorldContextObject");
		GetSafeZonePadding_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetSafeZonePadding_FunctionAddress, "WorldContextObject");
		GetSafeZonePadding_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSafeZonePadding_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSafeZonePadding_SafePadding_PropertyAddress, GetSafeZonePadding_FunctionAddress, "SafePadding");
		GetSafeZonePadding_SafePadding_Offset = NativeReflectionCached.GetPropertyOffset(GetSafeZonePadding_FunctionAddress, "SafePadding");
		GetSafeZonePadding_SafePadding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSafeZonePadding_FunctionAddress, "SafePadding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSafeZonePadding_SafePaddingScale_PropertyAddress, GetSafeZonePadding_FunctionAddress, "SafePaddingScale");
		GetSafeZonePadding_SafePaddingScale_Offset = NativeReflectionCached.GetPropertyOffset(GetSafeZonePadding_FunctionAddress, "SafePaddingScale");
		GetSafeZonePadding_SafePaddingScale_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSafeZonePadding_FunctionAddress, "SafePaddingScale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSafeZonePadding_SpillOverPadding_PropertyAddress, GetSafeZonePadding_FunctionAddress, "SpillOverPadding");
		GetSafeZonePadding_SpillOverPadding_Offset = NativeReflectionCached.GetPropertyOffset(GetSafeZonePadding_FunctionAddress, "SpillOverPadding");
		GetSafeZonePadding_SpillOverPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSafeZonePadding_FunctionAddress, "SpillOverPadding", Classes.FStructProperty);
		GetSafeZonePadding_IsValid = GetSafeZonePadding_FunctionAddress != IntPtr.Zero && GetSafeZonePadding_WorldContextObject_IsValid && GetSafeZonePadding_SafePadding_IsValid && GetSafeZonePadding_SafePaddingScale_IsValid && GetSafeZonePadding_SpillOverPadding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:GetSafeZonePadding", GetSafeZonePadding_IsValid);
		GetKeyEventFromAnalogInputEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetKeyEventFromAnalogInputEvent");
		GetKeyEventFromAnalogInputEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKeyEventFromAnalogInputEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKeyEventFromAnalogInputEvent_Event_PropertyAddress, GetKeyEventFromAnalogInputEvent_FunctionAddress, "Event");
		GetKeyEventFromAnalogInputEvent_Event_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyEventFromAnalogInputEvent_FunctionAddress, "Event");
		GetKeyEventFromAnalogInputEvent_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyEventFromAnalogInputEvent_FunctionAddress, "Event", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKeyEventFromAnalogInputEvent_ReturnValue_PropertyAddress, GetKeyEventFromAnalogInputEvent_FunctionAddress, "ReturnValue");
		GetKeyEventFromAnalogInputEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyEventFromAnalogInputEvent_FunctionAddress, "ReturnValue");
		GetKeyEventFromAnalogInputEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyEventFromAnalogInputEvent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetKeyEventFromAnalogInputEvent_IsValid = GetKeyEventFromAnalogInputEvent_FunctionAddress != IntPtr.Zero && GetKeyEventFromAnalogInputEvent_Event_IsValid && GetKeyEventFromAnalogInputEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:GetKeyEventFromAnalogInputEvent", GetKeyEventFromAnalogInputEvent_IsValid);
		GetInputEventFromPointerEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputEventFromPointerEvent");
		GetInputEventFromPointerEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputEventFromPointerEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputEventFromPointerEvent_Event_PropertyAddress, GetInputEventFromPointerEvent_FunctionAddress, "Event");
		GetInputEventFromPointerEvent_Event_Offset = NativeReflectionCached.GetPropertyOffset(GetInputEventFromPointerEvent_FunctionAddress, "Event");
		GetInputEventFromPointerEvent_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputEventFromPointerEvent_FunctionAddress, "Event", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputEventFromPointerEvent_ReturnValue_PropertyAddress, GetInputEventFromPointerEvent_FunctionAddress, "ReturnValue");
		GetInputEventFromPointerEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputEventFromPointerEvent_FunctionAddress, "ReturnValue");
		GetInputEventFromPointerEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputEventFromPointerEvent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetInputEventFromPointerEvent_IsValid = GetInputEventFromPointerEvent_FunctionAddress != IntPtr.Zero && GetInputEventFromPointerEvent_Event_IsValid && GetInputEventFromPointerEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:GetInputEventFromPointerEvent", GetInputEventFromPointerEvent_IsValid);
		GetInputEventFromNavigationEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputEventFromNavigationEvent");
		GetInputEventFromNavigationEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputEventFromNavigationEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputEventFromNavigationEvent_Event_PropertyAddress, GetInputEventFromNavigationEvent_FunctionAddress, "Event");
		GetInputEventFromNavigationEvent_Event_Offset = NativeReflectionCached.GetPropertyOffset(GetInputEventFromNavigationEvent_FunctionAddress, "Event");
		GetInputEventFromNavigationEvent_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputEventFromNavigationEvent_FunctionAddress, "Event", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputEventFromNavigationEvent_ReturnValue_PropertyAddress, GetInputEventFromNavigationEvent_FunctionAddress, "ReturnValue");
		GetInputEventFromNavigationEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputEventFromNavigationEvent_FunctionAddress, "ReturnValue");
		GetInputEventFromNavigationEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputEventFromNavigationEvent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetInputEventFromNavigationEvent_IsValid = GetInputEventFromNavigationEvent_FunctionAddress != IntPtr.Zero && GetInputEventFromNavigationEvent_Event_IsValid && GetInputEventFromNavigationEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:GetInputEventFromNavigationEvent", GetInputEventFromNavigationEvent_IsValid);
		GetInputEventFromKeyEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputEventFromKeyEvent");
		GetInputEventFromKeyEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputEventFromKeyEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputEventFromKeyEvent_Event_PropertyAddress, GetInputEventFromKeyEvent_FunctionAddress, "Event");
		GetInputEventFromKeyEvent_Event_Offset = NativeReflectionCached.GetPropertyOffset(GetInputEventFromKeyEvent_FunctionAddress, "Event");
		GetInputEventFromKeyEvent_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputEventFromKeyEvent_FunctionAddress, "Event", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputEventFromKeyEvent_ReturnValue_PropertyAddress, GetInputEventFromKeyEvent_FunctionAddress, "ReturnValue");
		GetInputEventFromKeyEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputEventFromKeyEvent_FunctionAddress, "ReturnValue");
		GetInputEventFromKeyEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputEventFromKeyEvent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetInputEventFromKeyEvent_IsValid = GetInputEventFromKeyEvent_FunctionAddress != IntPtr.Zero && GetInputEventFromKeyEvent_Event_IsValid && GetInputEventFromKeyEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:GetInputEventFromKeyEvent", GetInputEventFromKeyEvent_IsValid);
		GetInputEventFromCharacterEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputEventFromCharacterEvent");
		GetInputEventFromCharacterEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputEventFromCharacterEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputEventFromCharacterEvent_Event_PropertyAddress, GetInputEventFromCharacterEvent_FunctionAddress, "Event");
		GetInputEventFromCharacterEvent_Event_Offset = NativeReflectionCached.GetPropertyOffset(GetInputEventFromCharacterEvent_FunctionAddress, "Event");
		GetInputEventFromCharacterEvent_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputEventFromCharacterEvent_FunctionAddress, "Event", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputEventFromCharacterEvent_ReturnValue_PropertyAddress, GetInputEventFromCharacterEvent_FunctionAddress, "ReturnValue");
		GetInputEventFromCharacterEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputEventFromCharacterEvent_FunctionAddress, "ReturnValue");
		GetInputEventFromCharacterEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputEventFromCharacterEvent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetInputEventFromCharacterEvent_IsValid = GetInputEventFromCharacterEvent_FunctionAddress != IntPtr.Zero && GetInputEventFromCharacterEvent_Event_IsValid && GetInputEventFromCharacterEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:GetInputEventFromCharacterEvent", GetInputEventFromCharacterEvent_IsValid);
		GetDynamicMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDynamicMaterial");
		GetDynamicMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDynamicMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDynamicMaterial_Brush_PropertyAddress, GetDynamicMaterial_FunctionAddress, "Brush");
		GetDynamicMaterial_Brush_Offset = NativeReflectionCached.GetPropertyOffset(GetDynamicMaterial_FunctionAddress, "Brush");
		GetDynamicMaterial_Brush_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDynamicMaterial_FunctionAddress, "Brush", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDynamicMaterial_ReturnValue_PropertyAddress, GetDynamicMaterial_FunctionAddress, "ReturnValue");
		GetDynamicMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDynamicMaterial_FunctionAddress, "ReturnValue");
		GetDynamicMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDynamicMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDynamicMaterial_IsValid = GetDynamicMaterial_FunctionAddress != IntPtr.Zero && GetDynamicMaterial_Brush_IsValid && GetDynamicMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:GetDynamicMaterial", GetDynamicMaterial_IsValid);
		GetDragDroppingContent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDragDroppingContent");
		GetDragDroppingContent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDragDroppingContent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDragDroppingContent_ReturnValue_PropertyAddress, GetDragDroppingContent_FunctionAddress, "ReturnValue");
		GetDragDroppingContent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDragDroppingContent_FunctionAddress, "ReturnValue");
		GetDragDroppingContent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDragDroppingContent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDragDroppingContent_IsValid = GetDragDroppingContent_FunctionAddress != IntPtr.Zero && GetDragDroppingContent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:GetDragDroppingContent", GetDragDroppingContent_IsValid);
		GetBrushResourceAsTexture2D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBrushResourceAsTexture2D");
		GetBrushResourceAsTexture2D_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBrushResourceAsTexture2D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBrushResourceAsTexture2D_Brush_PropertyAddress, GetBrushResourceAsTexture2D_FunctionAddress, "Brush");
		GetBrushResourceAsTexture2D_Brush_Offset = NativeReflectionCached.GetPropertyOffset(GetBrushResourceAsTexture2D_FunctionAddress, "Brush");
		GetBrushResourceAsTexture2D_Brush_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBrushResourceAsTexture2D_FunctionAddress, "Brush", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBrushResourceAsTexture2D_ReturnValue_PropertyAddress, GetBrushResourceAsTexture2D_FunctionAddress, "ReturnValue");
		GetBrushResourceAsTexture2D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBrushResourceAsTexture2D_FunctionAddress, "ReturnValue");
		GetBrushResourceAsTexture2D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBrushResourceAsTexture2D_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBrushResourceAsTexture2D_IsValid = GetBrushResourceAsTexture2D_FunctionAddress != IntPtr.Zero && GetBrushResourceAsTexture2D_Brush_IsValid && GetBrushResourceAsTexture2D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:GetBrushResourceAsTexture2D", GetBrushResourceAsTexture2D_IsValid);
		GetBrushResourceAsMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBrushResourceAsMaterial");
		GetBrushResourceAsMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBrushResourceAsMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBrushResourceAsMaterial_Brush_PropertyAddress, GetBrushResourceAsMaterial_FunctionAddress, "Brush");
		GetBrushResourceAsMaterial_Brush_Offset = NativeReflectionCached.GetPropertyOffset(GetBrushResourceAsMaterial_FunctionAddress, "Brush");
		GetBrushResourceAsMaterial_Brush_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBrushResourceAsMaterial_FunctionAddress, "Brush", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBrushResourceAsMaterial_ReturnValue_PropertyAddress, GetBrushResourceAsMaterial_FunctionAddress, "ReturnValue");
		GetBrushResourceAsMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBrushResourceAsMaterial_FunctionAddress, "ReturnValue");
		GetBrushResourceAsMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBrushResourceAsMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBrushResourceAsMaterial_IsValid = GetBrushResourceAsMaterial_FunctionAddress != IntPtr.Zero && GetBrushResourceAsMaterial_Brush_IsValid && GetBrushResourceAsMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:GetBrushResourceAsMaterial", GetBrushResourceAsMaterial_IsValid);
		GetBrushResource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBrushResource");
		GetBrushResource_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBrushResource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBrushResource_Brush_PropertyAddress, GetBrushResource_FunctionAddress, "Brush");
		GetBrushResource_Brush_Offset = NativeReflectionCached.GetPropertyOffset(GetBrushResource_FunctionAddress, "Brush");
		GetBrushResource_Brush_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBrushResource_FunctionAddress, "Brush", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBrushResource_ReturnValue_PropertyAddress, GetBrushResource_FunctionAddress, "ReturnValue");
		GetBrushResource_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBrushResource_FunctionAddress, "ReturnValue");
		GetBrushResource_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBrushResource_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBrushResource_IsValid = GetBrushResource_FunctionAddress != IntPtr.Zero && GetBrushResource_Brush_IsValid && GetBrushResource_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:GetBrushResource", GetBrushResource_IsValid);
		GetAllWidgetsWithInterface_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllWidgetsWithInterface");
		GetAllWidgetsWithInterface_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllWidgetsWithInterface_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllWidgetsWithInterface_WorldContextObject_PropertyAddress, GetAllWidgetsWithInterface_FunctionAddress, "WorldContextObject");
		GetAllWidgetsWithInterface_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetAllWidgetsWithInterface_FunctionAddress, "WorldContextObject");
		GetAllWidgetsWithInterface_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllWidgetsWithInterface_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllWidgetsWithInterface_FoundWidgets_PropertyAddress, GetAllWidgetsWithInterface_FunctionAddress, "FoundWidgets");
		GetAllWidgetsWithInterface_FoundWidgets_Offset = NativeReflectionCached.GetPropertyOffset(GetAllWidgetsWithInterface_FunctionAddress, "FoundWidgets");
		GetAllWidgetsWithInterface_FoundWidgets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllWidgetsWithInterface_FunctionAddress, "FoundWidgets", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllWidgetsWithInterface_Interface_PropertyAddress, GetAllWidgetsWithInterface_FunctionAddress, "Interface");
		GetAllWidgetsWithInterface_Interface_Offset = NativeReflectionCached.GetPropertyOffset(GetAllWidgetsWithInterface_FunctionAddress, "Interface");
		GetAllWidgetsWithInterface_Interface_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllWidgetsWithInterface_FunctionAddress, "Interface", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllWidgetsWithInterface_TopLevelOnly_PropertyAddress, GetAllWidgetsWithInterface_FunctionAddress, "TopLevelOnly");
		GetAllWidgetsWithInterface_TopLevelOnly_Offset = NativeReflectionCached.GetPropertyOffset(GetAllWidgetsWithInterface_FunctionAddress, "TopLevelOnly");
		GetAllWidgetsWithInterface_TopLevelOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllWidgetsWithInterface_FunctionAddress, "TopLevelOnly", Classes.FBoolProperty);
		GetAllWidgetsWithInterface_IsValid = GetAllWidgetsWithInterface_FunctionAddress != IntPtr.Zero && GetAllWidgetsWithInterface_WorldContextObject_IsValid && GetAllWidgetsWithInterface_FoundWidgets_IsValid && GetAllWidgetsWithInterface_Interface_IsValid && GetAllWidgetsWithInterface_TopLevelOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:GetAllWidgetsWithInterface", GetAllWidgetsWithInterface_IsValid);
		GetAllWidgetsOfClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllWidgetsOfClass");
		GetAllWidgetsOfClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllWidgetsOfClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllWidgetsOfClass_WorldContextObject_PropertyAddress, GetAllWidgetsOfClass_FunctionAddress, "WorldContextObject");
		GetAllWidgetsOfClass_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetAllWidgetsOfClass_FunctionAddress, "WorldContextObject");
		GetAllWidgetsOfClass_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllWidgetsOfClass_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllWidgetsOfClass_FoundWidgets_PropertyAddress, GetAllWidgetsOfClass_FunctionAddress, "FoundWidgets");
		GetAllWidgetsOfClass_FoundWidgets_Offset = NativeReflectionCached.GetPropertyOffset(GetAllWidgetsOfClass_FunctionAddress, "FoundWidgets");
		GetAllWidgetsOfClass_FoundWidgets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllWidgetsOfClass_FunctionAddress, "FoundWidgets", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllWidgetsOfClass_WidgetClass_PropertyAddress, GetAllWidgetsOfClass_FunctionAddress, "WidgetClass");
		GetAllWidgetsOfClass_WidgetClass_Offset = NativeReflectionCached.GetPropertyOffset(GetAllWidgetsOfClass_FunctionAddress, "WidgetClass");
		GetAllWidgetsOfClass_WidgetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllWidgetsOfClass_FunctionAddress, "WidgetClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllWidgetsOfClass_TopLevelOnly_PropertyAddress, GetAllWidgetsOfClass_FunctionAddress, "TopLevelOnly");
		GetAllWidgetsOfClass_TopLevelOnly_Offset = NativeReflectionCached.GetPropertyOffset(GetAllWidgetsOfClass_FunctionAddress, "TopLevelOnly");
		GetAllWidgetsOfClass_TopLevelOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllWidgetsOfClass_FunctionAddress, "TopLevelOnly", Classes.FBoolProperty);
		GetAllWidgetsOfClass_IsValid = GetAllWidgetsOfClass_FunctionAddress != IntPtr.Zero && GetAllWidgetsOfClass_WorldContextObject_IsValid && GetAllWidgetsOfClass_FoundWidgets_IsValid && GetAllWidgetsOfClass_WidgetClass_IsValid && GetAllWidgetsOfClass_TopLevelOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:GetAllWidgetsOfClass", GetAllWidgetsOfClass_IsValid);
		EndDragDrop_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EndDragDrop");
		EndDragDrop_ParamsSize = NativeReflection.GetFunctionParamsSize(EndDragDrop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EndDragDrop_Reply_PropertyAddress, EndDragDrop_FunctionAddress, "Reply");
		EndDragDrop_Reply_Offset = NativeReflectionCached.GetPropertyOffset(EndDragDrop_FunctionAddress, "Reply");
		EndDragDrop_Reply_IsValid = NativeReflectionCached.ValidatePropertyClass(EndDragDrop_FunctionAddress, "Reply", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EndDragDrop_ReturnValue_PropertyAddress, EndDragDrop_FunctionAddress, "ReturnValue");
		EndDragDrop_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EndDragDrop_FunctionAddress, "ReturnValue");
		EndDragDrop_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EndDragDrop_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		EndDragDrop_IsValid = EndDragDrop_FunctionAddress != IntPtr.Zero && EndDragDrop_Reply_IsValid && EndDragDrop_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:EndDragDrop", EndDragDrop_IsValid);
		DrawTextFormatted_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawTextFormatted");
		DrawTextFormatted_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawTextFormatted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawTextFormatted_Context_PropertyAddress, DrawTextFormatted_FunctionAddress, "Context");
		DrawTextFormatted_Context_Offset = NativeReflectionCached.GetPropertyOffset(DrawTextFormatted_FunctionAddress, "Context");
		DrawTextFormatted_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTextFormatted_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTextFormatted_Text_PropertyAddress, DrawTextFormatted_FunctionAddress, "Text");
		DrawTextFormatted_Text_Offset = NativeReflectionCached.GetPropertyOffset(DrawTextFormatted_FunctionAddress, "Text");
		DrawTextFormatted_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTextFormatted_FunctionAddress, "Text", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTextFormatted_Position_PropertyAddress, DrawTextFormatted_FunctionAddress, "Position");
		DrawTextFormatted_Position_Offset = NativeReflectionCached.GetPropertyOffset(DrawTextFormatted_FunctionAddress, "Position");
		DrawTextFormatted_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTextFormatted_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTextFormatted_Font_PropertyAddress, DrawTextFormatted_FunctionAddress, "Font");
		DrawTextFormatted_Font_Offset = NativeReflectionCached.GetPropertyOffset(DrawTextFormatted_FunctionAddress, "Font");
		DrawTextFormatted_Font_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTextFormatted_FunctionAddress, "Font", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTextFormatted_FontSize_PropertyAddress, DrawTextFormatted_FunctionAddress, "FontSize");
		DrawTextFormatted_FontSize_Offset = NativeReflectionCached.GetPropertyOffset(DrawTextFormatted_FunctionAddress, "FontSize");
		DrawTextFormatted_FontSize_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTextFormatted_FunctionAddress, "FontSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTextFormatted_FontTypeFace_PropertyAddress, DrawTextFormatted_FunctionAddress, "FontTypeFace");
		DrawTextFormatted_FontTypeFace_Offset = NativeReflectionCached.GetPropertyOffset(DrawTextFormatted_FunctionAddress, "FontTypeFace");
		DrawTextFormatted_FontTypeFace_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTextFormatted_FunctionAddress, "FontTypeFace", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawTextFormatted_Tint_PropertyAddress, DrawTextFormatted_FunctionAddress, "Tint");
		DrawTextFormatted_Tint_Offset = NativeReflectionCached.GetPropertyOffset(DrawTextFormatted_FunctionAddress, "Tint");
		DrawTextFormatted_Tint_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawTextFormatted_FunctionAddress, "Tint", Classes.FStructProperty);
		DrawTextFormatted_IsValid = DrawTextFormatted_FunctionAddress != IntPtr.Zero && DrawTextFormatted_Context_IsValid && DrawTextFormatted_Text_IsValid && DrawTextFormatted_Position_IsValid && DrawTextFormatted_Font_IsValid && DrawTextFormatted_FontSize_IsValid && DrawTextFormatted_FontTypeFace_IsValid && DrawTextFormatted_Tint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:DrawTextFormatted", DrawTextFormatted_IsValid);
		DrawLines_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawLines");
		DrawLines_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawLines_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawLines_Context_PropertyAddress, DrawLines_FunctionAddress, "Context");
		DrawLines_Context_Offset = NativeReflectionCached.GetPropertyOffset(DrawLines_FunctionAddress, "Context");
		DrawLines_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLines_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLines_Points_PropertyAddress, DrawLines_FunctionAddress, "Points");
		DrawLines_Points_Offset = NativeReflectionCached.GetPropertyOffset(DrawLines_FunctionAddress, "Points");
		DrawLines_Points_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLines_FunctionAddress, "Points", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLines_Tint_PropertyAddress, DrawLines_FunctionAddress, "Tint");
		DrawLines_Tint_Offset = NativeReflectionCached.GetPropertyOffset(DrawLines_FunctionAddress, "Tint");
		DrawLines_Tint_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLines_FunctionAddress, "Tint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLines_bAntiAlias_PropertyAddress, DrawLines_FunctionAddress, "bAntiAlias");
		DrawLines_bAntiAlias_Offset = NativeReflectionCached.GetPropertyOffset(DrawLines_FunctionAddress, "bAntiAlias");
		DrawLines_bAntiAlias_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLines_FunctionAddress, "bAntiAlias", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLines_Thickness_PropertyAddress, DrawLines_FunctionAddress, "Thickness");
		DrawLines_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawLines_FunctionAddress, "Thickness");
		DrawLines_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLines_FunctionAddress, "Thickness", Classes.FFloatProperty);
		DrawLines_IsValid = DrawLines_FunctionAddress != IntPtr.Zero && DrawLines_Context_IsValid && DrawLines_Points_IsValid && DrawLines_Tint_IsValid && DrawLines_bAntiAlias_IsValid && DrawLines_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:DrawLines", DrawLines_IsValid);
		DrawLine_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawLine");
		DrawLine_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_Context_PropertyAddress, DrawLine_FunctionAddress, "Context");
		DrawLine_Context_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "Context");
		DrawLine_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_PositionA_PropertyAddress, DrawLine_FunctionAddress, "PositionA");
		DrawLine_PositionA_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "PositionA");
		DrawLine_PositionA_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "PositionA", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_PositionB_PropertyAddress, DrawLine_FunctionAddress, "PositionB");
		DrawLine_PositionB_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "PositionB");
		DrawLine_PositionB_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "PositionB", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_Tint_PropertyAddress, DrawLine_FunctionAddress, "Tint");
		DrawLine_Tint_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "Tint");
		DrawLine_Tint_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "Tint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_bAntiAlias_PropertyAddress, DrawLine_FunctionAddress, "bAntiAlias");
		DrawLine_bAntiAlias_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "bAntiAlias");
		DrawLine_bAntiAlias_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "bAntiAlias", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawLine_Thickness_PropertyAddress, DrawLine_FunctionAddress, "Thickness");
		DrawLine_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawLine_FunctionAddress, "Thickness");
		DrawLine_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawLine_FunctionAddress, "Thickness", Classes.FFloatProperty);
		DrawLine_IsValid = DrawLine_FunctionAddress != IntPtr.Zero && DrawLine_Context_IsValid && DrawLine_PositionA_IsValid && DrawLine_PositionB_IsValid && DrawLine_Tint_IsValid && DrawLine_bAntiAlias_IsValid && DrawLine_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:DrawLine", DrawLine_IsValid);
		DrawBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawBox");
		DrawBox_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawBox_Context_PropertyAddress, DrawBox_FunctionAddress, "Context");
		DrawBox_Context_Offset = NativeReflectionCached.GetPropertyOffset(DrawBox_FunctionAddress, "Context");
		DrawBox_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBox_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBox_Position_PropertyAddress, DrawBox_FunctionAddress, "Position");
		DrawBox_Position_Offset = NativeReflectionCached.GetPropertyOffset(DrawBox_FunctionAddress, "Position");
		DrawBox_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBox_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBox_Size_PropertyAddress, DrawBox_FunctionAddress, "Size");
		DrawBox_Size_Offset = NativeReflectionCached.GetPropertyOffset(DrawBox_FunctionAddress, "Size");
		DrawBox_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBox_FunctionAddress, "Size", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBox_Brush_PropertyAddress, DrawBox_FunctionAddress, "Brush");
		DrawBox_Brush_Offset = NativeReflectionCached.GetPropertyOffset(DrawBox_FunctionAddress, "Brush");
		DrawBox_Brush_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBox_FunctionAddress, "Brush", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawBox_Tint_PropertyAddress, DrawBox_FunctionAddress, "Tint");
		DrawBox_Tint_Offset = NativeReflectionCached.GetPropertyOffset(DrawBox_FunctionAddress, "Tint");
		DrawBox_Tint_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawBox_FunctionAddress, "Tint", Classes.FStructProperty);
		DrawBox_IsValid = DrawBox_FunctionAddress != IntPtr.Zero && DrawBox_Context_IsValid && DrawBox_Position_IsValid && DrawBox_Size_IsValid && DrawBox_Brush_IsValid && DrawBox_Tint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:DrawBox", DrawBox_IsValid);
		DismissAllMenus_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DismissAllMenus");
		DismissAllMenus_ParamsSize = NativeReflection.GetFunctionParamsSize(DismissAllMenus_FunctionAddress);
		DismissAllMenus_IsValid = DismissAllMenus_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:DismissAllMenus", DismissAllMenus_IsValid);
		DetectDragIfPressed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DetectDragIfPressed");
		DetectDragIfPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(DetectDragIfPressed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DetectDragIfPressed_PointerEvent_PropertyAddress, DetectDragIfPressed_FunctionAddress, "PointerEvent");
		DetectDragIfPressed_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(DetectDragIfPressed_FunctionAddress, "PointerEvent");
		DetectDragIfPressed_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectDragIfPressed_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectDragIfPressed_WidgetDetectingDrag_PropertyAddress, DetectDragIfPressed_FunctionAddress, "WidgetDetectingDrag");
		DetectDragIfPressed_WidgetDetectingDrag_Offset = NativeReflectionCached.GetPropertyOffset(DetectDragIfPressed_FunctionAddress, "WidgetDetectingDrag");
		DetectDragIfPressed_WidgetDetectingDrag_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectDragIfPressed_FunctionAddress, "WidgetDetectingDrag", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectDragIfPressed_DragKey_PropertyAddress, DetectDragIfPressed_FunctionAddress, "DragKey");
		DetectDragIfPressed_DragKey_Offset = NativeReflectionCached.GetPropertyOffset(DetectDragIfPressed_FunctionAddress, "DragKey");
		DetectDragIfPressed_DragKey_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectDragIfPressed_FunctionAddress, "DragKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectDragIfPressed_ReturnValue_PropertyAddress, DetectDragIfPressed_FunctionAddress, "ReturnValue");
		DetectDragIfPressed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DetectDragIfPressed_FunctionAddress, "ReturnValue");
		DetectDragIfPressed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectDragIfPressed_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		DetectDragIfPressed_IsValid = DetectDragIfPressed_FunctionAddress != IntPtr.Zero && DetectDragIfPressed_PointerEvent_IsValid && DetectDragIfPressed_WidgetDetectingDrag_IsValid && DetectDragIfPressed_DragKey_IsValid && DetectDragIfPressed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:DetectDragIfPressed", DetectDragIfPressed_IsValid);
		DetectDrag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DetectDrag");
		DetectDrag_ParamsSize = NativeReflection.GetFunctionParamsSize(DetectDrag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DetectDrag_Reply_PropertyAddress, DetectDrag_FunctionAddress, "Reply");
		DetectDrag_Reply_Offset = NativeReflectionCached.GetPropertyOffset(DetectDrag_FunctionAddress, "Reply");
		DetectDrag_Reply_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectDrag_FunctionAddress, "Reply", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectDrag_WidgetDetectingDrag_PropertyAddress, DetectDrag_FunctionAddress, "WidgetDetectingDrag");
		DetectDrag_WidgetDetectingDrag_Offset = NativeReflectionCached.GetPropertyOffset(DetectDrag_FunctionAddress, "WidgetDetectingDrag");
		DetectDrag_WidgetDetectingDrag_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectDrag_FunctionAddress, "WidgetDetectingDrag", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectDrag_DragKey_PropertyAddress, DetectDrag_FunctionAddress, "DragKey");
		DetectDrag_DragKey_Offset = NativeReflectionCached.GetPropertyOffset(DetectDrag_FunctionAddress, "DragKey");
		DetectDrag_DragKey_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectDrag_FunctionAddress, "DragKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DetectDrag_ReturnValue_PropertyAddress, DetectDrag_FunctionAddress, "ReturnValue");
		DetectDrag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DetectDrag_FunctionAddress, "ReturnValue");
		DetectDrag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DetectDrag_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		DetectDrag_IsValid = DetectDrag_FunctionAddress != IntPtr.Zero && DetectDrag_Reply_IsValid && DetectDrag_WidgetDetectingDrag_IsValid && DetectDrag_DragKey_IsValid && DetectDrag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:DetectDrag", DetectDrag_IsValid);
		ClearUserFocus_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearUserFocus");
		ClearUserFocus_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearUserFocus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearUserFocus_Reply_PropertyAddress, ClearUserFocus_FunctionAddress, "Reply");
		ClearUserFocus_Reply_Offset = NativeReflectionCached.GetPropertyOffset(ClearUserFocus_FunctionAddress, "Reply");
		ClearUserFocus_Reply_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearUserFocus_FunctionAddress, "Reply", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearUserFocus_bInAllUsers_PropertyAddress, ClearUserFocus_FunctionAddress, "bInAllUsers");
		ClearUserFocus_bInAllUsers_Offset = NativeReflectionCached.GetPropertyOffset(ClearUserFocus_FunctionAddress, "bInAllUsers");
		ClearUserFocus_bInAllUsers_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearUserFocus_FunctionAddress, "bInAllUsers", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearUserFocus_ReturnValue_PropertyAddress, ClearUserFocus_FunctionAddress, "ReturnValue");
		ClearUserFocus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClearUserFocus_FunctionAddress, "ReturnValue");
		ClearUserFocus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearUserFocus_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ClearUserFocus_IsValid = ClearUserFocus_FunctionAddress != IntPtr.Zero && ClearUserFocus_Reply_IsValid && ClearUserFocus_bInAllUsers_IsValid && ClearUserFocus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:ClearUserFocus", ClearUserFocus_IsValid);
		CaptureMouse_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CaptureMouse");
		CaptureMouse_ParamsSize = NativeReflection.GetFunctionParamsSize(CaptureMouse_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CaptureMouse_Reply_PropertyAddress, CaptureMouse_FunctionAddress, "Reply");
		CaptureMouse_Reply_Offset = NativeReflectionCached.GetPropertyOffset(CaptureMouse_FunctionAddress, "Reply");
		CaptureMouse_Reply_IsValid = NativeReflectionCached.ValidatePropertyClass(CaptureMouse_FunctionAddress, "Reply", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CaptureMouse_CapturingWidget_PropertyAddress, CaptureMouse_FunctionAddress, "CapturingWidget");
		CaptureMouse_CapturingWidget_Offset = NativeReflectionCached.GetPropertyOffset(CaptureMouse_FunctionAddress, "CapturingWidget");
		CaptureMouse_CapturingWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(CaptureMouse_FunctionAddress, "CapturingWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CaptureMouse_ReturnValue_PropertyAddress, CaptureMouse_FunctionAddress, "ReturnValue");
		CaptureMouse_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CaptureMouse_FunctionAddress, "ReturnValue");
		CaptureMouse_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CaptureMouse_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CaptureMouse_IsValid = CaptureMouse_FunctionAddress != IntPtr.Zero && CaptureMouse_Reply_IsValid && CaptureMouse_CapturingWidget_IsValid && CaptureMouse_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:CaptureMouse", CaptureMouse_IsValid);
		CancelDragDrop_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CancelDragDrop");
		CancelDragDrop_ParamsSize = NativeReflection.GetFunctionParamsSize(CancelDragDrop_FunctionAddress);
		CancelDragDrop_IsValid = CancelDragDrop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetBlueprintLibrary:CancelDragDrop", CancelDragDrop_IsValid);
	}
}
