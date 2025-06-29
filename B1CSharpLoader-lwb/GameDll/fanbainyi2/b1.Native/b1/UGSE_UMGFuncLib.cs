using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using b1.Plugins.GSAnimationKeyBlender;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.MediaAssets;
using UnrealEngine.Plugins.BinkMediaPlayer;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_UMGFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool WidgetLocalToRoundedLocal_IsValid;

	private static IntPtr WidgetLocalToRoundedLocal_FunctionAddress;

	private static int WidgetLocalToRoundedLocal_ParamsSize;

	private static bool WidgetLocalToRoundedLocal_widget_IsValid;

	private static FFieldAddress WidgetLocalToRoundedLocal_widget_PropertyAddress;

	private static int WidgetLocalToRoundedLocal_widget_Offset;

	private static bool WidgetLocalToRoundedLocal_LocalCoordinates_IsValid;

	private static FFieldAddress WidgetLocalToRoundedLocal_LocalCoordinates_PropertyAddress;

	private static int WidgetLocalToRoundedLocal_LocalCoordinates_Offset;

	private static bool WidgetLocalToRoundedLocal_ReturnValue_IsValid;

	private static FFieldAddress WidgetLocalToRoundedLocal_ReturnValue_PropertyAddress;

	private static int WidgetLocalToRoundedLocal_ReturnValue_Offset;

	private static bool WidgetLocalToAbsolute_IsValid;

	private static IntPtr WidgetLocalToAbsolute_FunctionAddress;

	private static int WidgetLocalToAbsolute_ParamsSize;

	private static bool WidgetLocalToAbsolute_widget_IsValid;

	private static FFieldAddress WidgetLocalToAbsolute_widget_PropertyAddress;

	private static int WidgetLocalToAbsolute_widget_Offset;

	private static bool WidgetLocalToAbsolute_LocalCoordinates_IsValid;

	private static FFieldAddress WidgetLocalToAbsolute_LocalCoordinates_PropertyAddress;

	private static int WidgetLocalToAbsolute_LocalCoordinates_Offset;

	private static bool WidgetLocalToAbsolute_ReturnValue_IsValid;

	private static FFieldAddress WidgetLocalToAbsolute_ReturnValue_PropertyAddress;

	private static int WidgetLocalToAbsolute_ReturnValue_Offset;

	private static bool WidgetAbsoluteToLocal_IsValid;

	private static IntPtr WidgetAbsoluteToLocal_FunctionAddress;

	private static int WidgetAbsoluteToLocal_ParamsSize;

	private static bool WidgetAbsoluteToLocal_widget_IsValid;

	private static FFieldAddress WidgetAbsoluteToLocal_widget_PropertyAddress;

	private static int WidgetAbsoluteToLocal_widget_Offset;

	private static bool WidgetAbsoluteToLocal_AbsoluteCoordinates_IsValid;

	private static FFieldAddress WidgetAbsoluteToLocal_AbsoluteCoordinates_PropertyAddress;

	private static int WidgetAbsoluteToLocal_AbsoluteCoordinates_Offset;

	private static bool WidgetAbsoluteToLocal_ReturnValue_IsValid;

	private static FFieldAddress WidgetAbsoluteToLocal_ReturnValue_PropertyAddress;

	private static int WidgetAbsoluteToLocal_ReturnValue_Offset;

	private static bool SlateLocalToAbsolute_IsValid;

	private static IntPtr SlateLocalToAbsolute_FunctionAddress;

	private static int SlateLocalToAbsolute_ParamsSize;

	private static bool SlateLocalToAbsolute_Geometry_IsValid;

	private static FFieldAddress SlateLocalToAbsolute_Geometry_PropertyAddress;

	private static int SlateLocalToAbsolute_Geometry_Offset;

	private static bool SlateLocalToAbsolute_LocalPos_IsValid;

	private static FFieldAddress SlateLocalToAbsolute_LocalPos_PropertyAddress;

	private static int SlateLocalToAbsolute_LocalPos_Offset;

	private static bool SlateLocalToAbsolute_ReturnValue_IsValid;

	private static FFieldAddress SlateLocalToAbsolute_ReturnValue_PropertyAddress;

	private static int SlateLocalToAbsolute_ReturnValue_Offset;

	private static bool SlateAbsoluteToLocal_IsValid;

	private static IntPtr SlateAbsoluteToLocal_FunctionAddress;

	private static int SlateAbsoluteToLocal_ParamsSize;

	private static bool SlateAbsoluteToLocal_Geometry_IsValid;

	private static FFieldAddress SlateAbsoluteToLocal_Geometry_PropertyAddress;

	private static int SlateAbsoluteToLocal_Geometry_Offset;

	private static bool SlateAbsoluteToLocal_AbsolutePos_IsValid;

	private static FFieldAddress SlateAbsoluteToLocal_AbsolutePos_PropertyAddress;

	private static int SlateAbsoluteToLocal_AbsolutePos_Offset;

	private static bool SlateAbsoluteToLocal_ReturnValue_IsValid;

	private static FFieldAddress SlateAbsoluteToLocal_ReturnValue_PropertyAddress;

	private static int SlateAbsoluteToLocal_ReturnValue_Offset;

	private static bool SetWidgetEnable_IsValid;

	private static IntPtr SetWidgetEnable_FunctionAddress;

	private static int SetWidgetEnable_ParamsSize;

	private static bool SetWidgetEnable_Widget_IsValid;

	private static FFieldAddress SetWidgetEnable_Widget_PropertyAddress;

	private static int SetWidgetEnable_Widget_Offset;

	private static bool SetWidgetEnable_Enable_IsValid;

	private static FFieldAddress SetWidgetEnable_Enable_PropertyAddress;

	private static int SetWidgetEnable_Enable_Offset;

	private static bool SetUserFocusWithCause_IsValid;

	private static IntPtr SetUserFocusWithCause_FunctionAddress;

	private static int SetUserFocusWithCause_ParamsSize;

	private static bool SetUserFocusWithCause_PlayerController_IsValid;

	private static FFieldAddress SetUserFocusWithCause_PlayerController_PropertyAddress;

	private static int SetUserFocusWithCause_PlayerController_Offset;

	private static bool SetUserFocusWithCause_Widget_IsValid;

	private static FFieldAddress SetUserFocusWithCause_Widget_PropertyAddress;

	private static int SetUserFocusWithCause_Widget_Offset;

	private static bool SetUserFocusWithCause_Cause_IsValid;

	private static FFieldAddress SetUserFocusWithCause_Cause_PropertyAddress;

	private static int SetUserFocusWithCause_Cause_Offset;

	private static bool SetTextToBitmapFontBox_IsValid;

	private static IntPtr SetTextToBitmapFontBox_FunctionAddress;

	private static int SetTextToBitmapFontBox_ParamsSize;

	private static bool SetTextToBitmapFontBox_Widget_IsValid;

	private static FFieldAddress SetTextToBitmapFontBox_Widget_PropertyAddress;

	private static int SetTextToBitmapFontBox_Widget_Offset;

	private static bool SetTextToBitmapFontBox_Text_IsValid;

	private static FFieldAddress SetTextToBitmapFontBox_Text_PropertyAddress;

	private static int SetTextToBitmapFontBox_Text_Offset;

	private static bool SetLocalStringTableEntry_IsValid;

	private static IntPtr SetLocalStringTableEntry_FunctionAddress;

	private static int SetLocalStringTableEntry_ParamsSize;

	private static bool SetLocalStringTableEntry_ID_IsValid;

	private static FFieldAddress SetLocalStringTableEntry_ID_PropertyAddress;

	private static int SetLocalStringTableEntry_ID_Offset;

	private static bool SetLocalStringTableEntry_Key_IsValid;

	private static FFieldAddress SetLocalStringTableEntry_Key_PropertyAddress;

	private static int SetLocalStringTableEntry_Key_Offset;

	private static bool SetLocalStringTableEntry_Src_IsValid;

	private static FFieldAddress SetLocalStringTableEntry_Src_PropertyAddress;

	private static int SetLocalStringTableEntry_Src_Offset;

	private static bool SetLocalStringTableEntry_ReturnValue_IsValid;

	private static FFieldAddress SetLocalStringTableEntry_ReturnValue_PropertyAddress;

	private static int SetLocalStringTableEntry_ReturnValue_Offset;

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

	private static bool SetCurrentCulture_IsValid;

	private static IntPtr SetCurrentCulture_FunctionAddress;

	private static int SetCurrentCulture_ParamsSize;

	private static bool SetCurrentCulture_CultureName_IsValid;

	private static FFieldAddress SetCurrentCulture_CultureName_PropertyAddress;

	private static int SetCurrentCulture_CultureName_Offset;

	private static bool SetCurrentCulture_ReturnValue_IsValid;

	private static FFieldAddress SetCurrentCulture_ReturnValue_PropertyAddress;

	private static int SetCurrentCulture_ReturnValue_Offset;

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

	private static bool RemoveUserWidgetAsSlateFromViewport_IsValid;

	private static IntPtr RemoveUserWidgetAsSlateFromViewport_FunctionAddress;

	private static int RemoveUserWidgetAsSlateFromViewport_ParamsSize;

	private static bool RemoveUserWidgetAsSlateFromViewport_Widget_IsValid;

	private static FFieldAddress RemoveUserWidgetAsSlateFromViewport_Widget_PropertyAddress;

	private static int RemoveUserWidgetAsSlateFromViewport_Widget_Offset;

	private static bool RefreshRichTextDefaultStyle_IsValid;

	private static IntPtr RefreshRichTextDefaultStyle_FunctionAddress;

	private static int RefreshRichTextDefaultStyle_ParamsSize;

	private static bool RefreshRichTextDefaultStyle_RichTextBlock_IsValid;

	private static FFieldAddress RefreshRichTextDefaultStyle_RichTextBlock_PropertyAddress;

	private static int RefreshRichTextDefaultStyle_RichTextBlock_Offset;

	private static bool RefreshDPIScale_IsValid;

	private static IntPtr RefreshDPIScale_FunctionAddress;

	private static int RefreshDPIScale_ParamsSize;

	private static bool RefreshDPIScale_WorldContext_IsValid;

	private static FFieldAddress RefreshDPIScale_WorldContext_PropertyAddress;

	private static int RefreshDPIScale_WorldContext_Offset;

	private static bool QAGetWidgetWithText_IsValid;

	private static IntPtr QAGetWidgetWithText_FunctionAddress;

	private static int QAGetWidgetWithText_ParamsSize;

	private static bool QAGetWidgetWithText_WorldContextObject_IsValid;

	private static FFieldAddress QAGetWidgetWithText_WorldContextObject_PropertyAddress;

	private static int QAGetWidgetWithText_WorldContextObject_Offset;

	private static bool QAGetWidgetWithText_FoundWidgets_IsValid;

	private static FFieldAddress QAGetWidgetWithText_FoundWidgets_PropertyAddress;

	private static int QAGetWidgetWithText_FoundWidgets_Offset;

	private static bool QAGetWidgetWithText_Text_IsValid;

	private static FFieldAddress QAGetWidgetWithText_Text_PropertyAddress;

	private static int QAGetWidgetWithText_Text_Offset;

	private static bool QAGetWidgetCenterPosition_IsValid;

	private static IntPtr QAGetWidgetCenterPosition_FunctionAddress;

	private static int QAGetWidgetCenterPosition_ParamsSize;

	private static bool QAGetWidgetCenterPosition_widget_IsValid;

	private static FFieldAddress QAGetWidgetCenterPosition_widget_PropertyAddress;

	private static int QAGetWidgetCenterPosition_widget_Offset;

	private static bool QAGetWidgetCenterPosition_WidgetPosition_IsValid;

	private static FFieldAddress QAGetWidgetCenterPosition_WidgetPosition_PropertyAddress;

	private static int QAGetWidgetCenterPosition_WidgetPosition_Offset;

	private static bool QAGetWidgetCenterPosition_CenterPosition_IsValid;

	private static FFieldAddress QAGetWidgetCenterPosition_CenterPosition_PropertyAddress;

	private static int QAGetWidgetCenterPosition_CenterPosition_Offset;

	private static bool QAGetWidgetCenterPosition_WidgetSize_IsValid;

	private static FFieldAddress QAGetWidgetCenterPosition_WidgetSize_PropertyAddress;

	private static int QAGetWidgetCenterPosition_WidgetSize_Offset;

	private static bool QAGetAllWidgetsOfClass_IsValid;

	private static IntPtr QAGetAllWidgetsOfClass_FunctionAddress;

	private static int QAGetAllWidgetsOfClass_ParamsSize;

	private static bool QAGetAllWidgetsOfClass_WorldContextObject_IsValid;

	private static FFieldAddress QAGetAllWidgetsOfClass_WorldContextObject_PropertyAddress;

	private static int QAGetAllWidgetsOfClass_WorldContextObject_Offset;

	private static bool QAGetAllWidgetsOfClass_FoundWidgets_IsValid;

	private static FFieldAddress QAGetAllWidgetsOfClass_FoundWidgets_PropertyAddress;

	private static int QAGetAllWidgetsOfClass_FoundWidgets_Offset;

	private static bool QAGetAllWidgetsOfClass_WidgetClass_IsValid;

	private static FFieldAddress QAGetAllWidgetsOfClass_WidgetClass_PropertyAddress;

	private static int QAGetAllWidgetsOfClass_WidgetClass_Offset;

	private static bool PointerEvent_IsTouchFirstMove_IsValid;

	private static IntPtr PointerEvent_IsTouchFirstMove_FunctionAddress;

	private static int PointerEvent_IsTouchFirstMove_ParamsSize;

	private static bool PointerEvent_IsTouchFirstMove_PointerEvent_IsValid;

	private static FFieldAddress PointerEvent_IsTouchFirstMove_PointerEvent_PropertyAddress;

	private static int PointerEvent_IsTouchFirstMove_PointerEvent_Offset;

	private static bool PointerEvent_IsTouchFirstMove_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_IsTouchFirstMove_ReturnValue_PropertyAddress;

	private static int PointerEvent_IsTouchFirstMove_ReturnValue_Offset;

	private static bool PointerEvent_IsMouseTouchEvent_IsValid;

	private static IntPtr PointerEvent_IsMouseTouchEvent_FunctionAddress;

	private static int PointerEvent_IsMouseTouchEvent_ParamsSize;

	private static bool PointerEvent_IsMouseTouchEvent_PointerEvent_IsValid;

	private static FFieldAddress PointerEvent_IsMouseTouchEvent_PointerEvent_PropertyAddress;

	private static int PointerEvent_IsMouseTouchEvent_PointerEvent_Offset;

	private static bool PointerEvent_IsMouseTouchEvent_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_IsMouseTouchEvent_ReturnValue_PropertyAddress;

	private static int PointerEvent_IsMouseTouchEvent_ReturnValue_Offset;

	private static bool PointerEvent_IsMouseButtonDown_IsValid;

	private static IntPtr PointerEvent_IsMouseButtonDown_FunctionAddress;

	private static int PointerEvent_IsMouseButtonDown_ParamsSize;

	private static bool PointerEvent_IsMouseButtonDown_PointerEvent_IsValid;

	private static FFieldAddress PointerEvent_IsMouseButtonDown_PointerEvent_PropertyAddress;

	private static int PointerEvent_IsMouseButtonDown_PointerEvent_Offset;

	private static bool PointerEvent_IsMouseButtonDown_MouseButtonName_IsValid;

	private static FFieldAddress PointerEvent_IsMouseButtonDown_MouseButtonName_PropertyAddress;

	private static int PointerEvent_IsMouseButtonDown_MouseButtonName_Offset;

	private static bool PointerEvent_IsMouseButtonDown_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_IsMouseButtonDown_ReturnValue_PropertyAddress;

	private static int PointerEvent_IsMouseButtonDown_ReturnValue_Offset;

	private static bool PointerEvent_GetScreenSpacePosition_IsValid;

	private static IntPtr PointerEvent_GetScreenSpacePosition_FunctionAddress;

	private static int PointerEvent_GetScreenSpacePosition_ParamsSize;

	private static bool PointerEvent_GetScreenSpacePosition_PointerEvent_IsValid;

	private static FFieldAddress PointerEvent_GetScreenSpacePosition_PointerEvent_PropertyAddress;

	private static int PointerEvent_GetScreenSpacePosition_PointerEvent_Offset;

	private static bool PointerEvent_GetScreenSpacePosition_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_GetScreenSpacePosition_ReturnValue_PropertyAddress;

	private static int PointerEvent_GetScreenSpacePosition_ReturnValue_Offset;

	private static bool PointerEvent_GetPositionInGeometry_IsValid;

	private static IntPtr PointerEvent_GetPositionInGeometry_FunctionAddress;

	private static int PointerEvent_GetPositionInGeometry_ParamsSize;

	private static bool PointerEvent_GetPositionInGeometry_Geometry_IsValid;

	private static FFieldAddress PointerEvent_GetPositionInGeometry_Geometry_PropertyAddress;

	private static int PointerEvent_GetPositionInGeometry_Geometry_Offset;

	private static bool PointerEvent_GetPositionInGeometry_PointerEvent_IsValid;

	private static FFieldAddress PointerEvent_GetPositionInGeometry_PointerEvent_PropertyAddress;

	private static int PointerEvent_GetPositionInGeometry_PointerEvent_Offset;

	private static bool PointerEvent_GetPositionInGeometry_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_GetPositionInGeometry_ReturnValue_PropertyAddress;

	private static int PointerEvent_GetPositionInGeometry_ReturnValue_Offset;

	private static bool PointerEvent_GetPointerIndex_IsValid;

	private static IntPtr PointerEvent_GetPointerIndex_FunctionAddress;

	private static int PointerEvent_GetPointerIndex_ParamsSize;

	private static bool PointerEvent_GetPointerIndex_PointerEvent_IsValid;

	private static FFieldAddress PointerEvent_GetPointerIndex_PointerEvent_PropertyAddress;

	private static int PointerEvent_GetPointerIndex_PointerEvent_Offset;

	private static bool PointerEvent_GetPointerIndex_ReturnValue_IsValid;

	private static FFieldAddress PointerEvent_GetPointerIndex_ReturnValue_PropertyAddress;

	private static int PointerEvent_GetPointerIndex_ReturnValue_Offset;

	private static bool NewLocalStringTable_IsValid;

	private static IntPtr NewLocalStringTable_FunctionAddress;

	private static int NewLocalStringTable_ParamsSize;

	private static bool NewLocalStringTable_ID_IsValid;

	private static FFieldAddress NewLocalStringTable_ID_PropertyAddress;

	private static int NewLocalStringTable_ID_Offset;

	private static bool NewLocalStringTable_NameSpace_IsValid;

	private static FFieldAddress NewLocalStringTable_NameSpace_PropertyAddress;

	private static int NewLocalStringTable_NameSpace_Offset;

	private static bool NewLocalStringTable_ReturnValue_IsValid;

	private static FFieldAddress NewLocalStringTable_ReturnValue_PropertyAddress;

	private static int NewLocalStringTable_ReturnValue_Offset;

	private static bool NeedExecuteActionWithDA_IsValid;

	private static IntPtr NeedExecuteActionWithDA_FunctionAddress;

	private static int NeedExecuteActionWithDA_ParamsSize;

	private static bool NeedExecuteActionWithDA_MyGeometry_IsValid;

	private static FFieldAddress NeedExecuteActionWithDA_MyGeometry_PropertyAddress;

	private static int NeedExecuteActionWithDA_MyGeometry_Offset;

	private static bool NeedExecuteActionWithDA_MouseEvent_IsValid;

	private static FFieldAddress NeedExecuteActionWithDA_MouseEvent_PropertyAddress;

	private static int NeedExecuteActionWithDA_MouseEvent_Offset;

	private static bool NeedExecuteActionWithDA_HitAreaDA_IsValid;

	private static FFieldAddress NeedExecuteActionWithDA_HitAreaDA_PropertyAddress;

	private static int NeedExecuteActionWithDA_HitAreaDA_Offset;

	private static bool NeedExecuteActionWithDA_AdvancedHitAlpha_IsValid;

	private static FFieldAddress NeedExecuteActionWithDA_AdvancedHitAlpha_PropertyAddress;

	private static int NeedExecuteActionWithDA_AdvancedHitAlpha_Offset;

	private static bool NeedExecuteActionWithDA_ReturnValue_IsValid;

	private static FFieldAddress NeedExecuteActionWithDA_ReturnValue_PropertyAddress;

	private static int NeedExecuteActionWithDA_ReturnValue_Offset;

	private static bool NeedExecuteAction_IsValid;

	private static IntPtr NeedExecuteAction_FunctionAddress;

	private static int NeedExecuteAction_ParamsSize;

	private static bool NeedExecuteAction_MyGeometry_IsValid;

	private static FFieldAddress NeedExecuteAction_MyGeometry_PropertyAddress;

	private static int NeedExecuteAction_MyGeometry_Offset;

	private static bool NeedExecuteAction_MouseEvent_IsValid;

	private static FFieldAddress NeedExecuteAction_MouseEvent_PropertyAddress;

	private static int NeedExecuteAction_MouseEvent_Offset;

	private static bool NeedExecuteAction_AdvancedHitTexture_IsValid;

	private static FFieldAddress NeedExecuteAction_AdvancedHitTexture_PropertyAddress;

	private static int NeedExecuteAction_AdvancedHitTexture_Offset;

	private static bool NeedExecuteAction_AdvancedHitAlpha_IsValid;

	private static FFieldAddress NeedExecuteAction_AdvancedHitAlpha_PropertyAddress;

	private static int NeedExecuteAction_AdvancedHitAlpha_Offset;

	private static bool NeedExecuteAction_ReturnValue_IsValid;

	private static FFieldAddress NeedExecuteAction_ReturnValue_PropertyAddress;

	private static int NeedExecuteAction_ReturnValue_Offset;

	private static bool MakeEventReply_IsValid;

	private static IntPtr MakeEventReply_FunctionAddress;

	private static int MakeEventReply_ParamsSize;

	private static bool MakeEventReply_IsHandled_IsValid;

	private static FFieldAddress MakeEventReply_IsHandled_PropertyAddress;

	private static int MakeEventReply_IsHandled_Offset;

	private static bool MakeEventReply_ReturnValue_IsValid;

	private static FFieldAddress MakeEventReply_ReturnValue_PropertyAddress;

	private static int MakeEventReply_ReturnValue_Offset;

	private static bool LogHittestGrid_IsValid;

	private static IntPtr LogHittestGrid_FunctionAddress;

	private static int LogHittestGrid_ParamsSize;

	private static bool LocalToViewPortPos_IsValid;

	private static IntPtr LocalToViewPortPos_FunctionAddress;

	private static int LocalToViewPortPos_ParamsSize;

	private static bool LocalToViewPortPos_WorldContextObject_IsValid;

	private static FFieldAddress LocalToViewPortPos_WorldContextObject_PropertyAddress;

	private static int LocalToViewPortPos_WorldContextObject_Offset;

	private static bool LocalToViewPortPos_Geometry_IsValid;

	private static FFieldAddress LocalToViewPortPos_Geometry_PropertyAddress;

	private static int LocalToViewPortPos_Geometry_Offset;

	private static bool LocalToViewPortPos_ReturnValue_IsValid;

	private static FFieldAddress LocalToViewPortPos_ReturnValue_PropertyAddress;

	private static int LocalToViewPortPos_ReturnValue_Offset;

	private static bool LocalToViewPortPixelPos_IsValid;

	private static IntPtr LocalToViewPortPixelPos_FunctionAddress;

	private static int LocalToViewPortPixelPos_ParamsSize;

	private static bool LocalToViewPortPixelPos_WorldContextObject_IsValid;

	private static FFieldAddress LocalToViewPortPixelPos_WorldContextObject_PropertyAddress;

	private static int LocalToViewPortPixelPos_WorldContextObject_Offset;

	private static bool LocalToViewPortPixelPos_Geometry_IsValid;

	private static FFieldAddress LocalToViewPortPixelPos_Geometry_PropertyAddress;

	private static int LocalToViewPortPixelPos_Geometry_Offset;

	private static bool LocalToViewPortPixelPos_ReturnValue_IsValid;

	private static FFieldAddress LocalToViewPortPixelPos_ReturnValue_PropertyAddress;

	private static int LocalToViewPortPixelPos_ReturnValue_Offset;

	private static bool LoadTexture2DToAreaIDArray_IsValid;

	private static IntPtr LoadTexture2DToAreaIDArray_FunctionAddress;

	private static int LoadTexture2DToAreaIDArray_ParamsSize;

	private static bool LoadTexture2DToAreaIDArray_TargetTexture_IsValid;

	private static FFieldAddress LoadTexture2DToAreaIDArray_TargetTexture_PropertyAddress;

	private static int LoadTexture2DToAreaIDArray_TargetTexture_Offset;

	private static bool LoadTexture2DToAreaIDArray_AreaColorIDMap_IsValid;

	private static FFieldAddress LoadTexture2DToAreaIDArray_AreaColorIDMap_PropertyAddress;

	private static int LoadTexture2DToAreaIDArray_AreaColorIDMap_Offset;

	private static bool LoadTexture2DToAreaIDArray_AreaData_IsValid;

	private static FFieldAddress LoadTexture2DToAreaIDArray_AreaData_PropertyAddress;

	private static int LoadTexture2DToAreaIDArray_AreaData_Offset;

	private static bool LoadTexture2DToAreaIDArray_OutOriginPos_IsValid;

	private static FFieldAddress LoadTexture2DToAreaIDArray_OutOriginPos_PropertyAddress;

	private static int LoadTexture2DToAreaIDArray_OutOriginPos_Offset;

	private static bool LoadTexture2DToAreaIDArray_OutMapSize_IsValid;

	private static FFieldAddress LoadTexture2DToAreaIDArray_OutMapSize_PropertyAddress;

	private static int LoadTexture2DToAreaIDArray_OutMapSize_Offset;

	private static bool LoadTexture2DToAreaIDArray_ErrMsg_IsValid;

	private static FFieldAddress LoadTexture2DToAreaIDArray_ErrMsg_PropertyAddress;

	private static int LoadTexture2DToAreaIDArray_ErrMsg_Offset;

	private static bool LoadTexture2DToAreaIDArray_ReturnValue_IsValid;

	private static FFieldAddress LoadTexture2DToAreaIDArray_ReturnValue_PropertyAddress;

	private static int LoadTexture2DToAreaIDArray_ReturnValue_Offset;

	private static bool IsWidgetVisiableWithParentInList_IsValid;

	private static IntPtr IsWidgetVisiableWithParentInList_FunctionAddress;

	private static int IsWidgetVisiableWithParentInList_ParamsSize;

	private static bool IsWidgetVisiableWithParentInList_InWidgetList_IsValid;

	private static FFieldAddress IsWidgetVisiableWithParentInList_InWidgetList_PropertyAddress;

	private static int IsWidgetVisiableWithParentInList_InWidgetList_Offset;

	private static bool IsWidgetVisiableWithParentInList_OutWidgetList_IsValid;

	private static FFieldAddress IsWidgetVisiableWithParentInList_OutWidgetList_PropertyAddress;

	private static int IsWidgetVisiableWithParentInList_OutWidgetList_Offset;

	private static bool IsWidgetVisiableWithParent_IsValid;

	private static IntPtr IsWidgetVisiableWithParent_FunctionAddress;

	private static int IsWidgetVisiableWithParent_ParamsSize;

	private static bool IsWidgetVisiableWithParent_TargetWidget_IsValid;

	private static FFieldAddress IsWidgetVisiableWithParent_TargetWidget_PropertyAddress;

	private static int IsWidgetVisiableWithParent_TargetWidget_Offset;

	private static bool IsWidgetVisiableWithParent_ReturnValue_IsValid;

	private static FFieldAddress IsWidgetVisiableWithParent_ReturnValue_PropertyAddress;

	private static int IsWidgetVisiableWithParent_ReturnValue_Offset;

	private static bool IsMediaBeginPlay_IsValid;

	private static IntPtr IsMediaBeginPlay_FunctionAddress;

	private static int IsMediaBeginPlay_ParamsSize;

	private static bool IsMediaBeginPlay_MediaPlayer_IsValid;

	private static FFieldAddress IsMediaBeginPlay_MediaPlayer_PropertyAddress;

	private static int IsMediaBeginPlay_MediaPlayer_Offset;

	private static bool IsMediaBeginPlay_ReturnValue_IsValid;

	private static FFieldAddress IsMediaBeginPlay_ReturnValue_PropertyAddress;

	private static int IsMediaBeginPlay_ReturnValue_Offset;

	private static bool IsBinkMediaBeginPlay_IsValid;

	private static IntPtr IsBinkMediaBeginPlay_FunctionAddress;

	private static int IsBinkMediaBeginPlay_ParamsSize;

	private static bool IsBinkMediaBeginPlay_BinkMediaPlayer_IsValid;

	private static FFieldAddress IsBinkMediaBeginPlay_BinkMediaPlayer_PropertyAddress;

	private static int IsBinkMediaBeginPlay_BinkMediaPlayer_Offset;

	private static bool IsBinkMediaBeginPlay_ReturnValue_IsValid;

	private static FFieldAddress IsBinkMediaBeginPlay_ReturnValue_PropertyAddress;

	private static int IsBinkMediaBeginPlay_ReturnValue_Offset;

	private static bool InvokeWidgetInputEvent_IsValid;

	private static IntPtr InvokeWidgetInputEvent_FunctionAddress;

	private static int InvokeWidgetInputEvent_ParamsSize;

	private static bool InvokeWidgetInputEvent_uWidget_IsValid;

	private static FFieldAddress InvokeWidgetInputEvent_uWidget_PropertyAddress;

	private static int InvokeWidgetInputEvent_uWidget_Offset;

	private static bool InvokeWidgetInputEvent_inputType_IsValid;

	private static FFieldAddress InvokeWidgetInputEvent_inputType_PropertyAddress;

	private static int InvokeWidgetInputEvent_inputType_Offset;

	private static bool InvokeWidgetInputEvent_MyGeometry_IsValid;

	private static FFieldAddress InvokeWidgetInputEvent_MyGeometry_PropertyAddress;

	private static int InvokeWidgetInputEvent_MyGeometry_Offset;

	private static bool InvokeWidgetInputEvent_MouseEvent_IsValid;

	private static FFieldAddress InvokeWidgetInputEvent_MouseEvent_PropertyAddress;

	private static int InvokeWidgetInputEvent_MouseEvent_Offset;

	private static bool GSProjectWorldLocationToWidgetPosition_IsValid;

	private static IntPtr GSProjectWorldLocationToWidgetPosition_FunctionAddress;

	private static int GSProjectWorldLocationToWidgetPosition_ParamsSize;

	private static bool GSProjectWorldLocationToWidgetPosition_PlayerController_IsValid;

	private static FFieldAddress GSProjectWorldLocationToWidgetPosition_PlayerController_PropertyAddress;

	private static int GSProjectWorldLocationToWidgetPosition_PlayerController_Offset;

	private static bool GSProjectWorldLocationToWidgetPosition_WorldLocation_IsValid;

	private static FFieldAddress GSProjectWorldLocationToWidgetPosition_WorldLocation_PropertyAddress;

	private static int GSProjectWorldLocationToWidgetPosition_WorldLocation_Offset;

	private static bool GSProjectWorldLocationToWidgetPosition_ViewportPosition_IsValid;

	private static FFieldAddress GSProjectWorldLocationToWidgetPosition_ViewportPosition_PropertyAddress;

	private static int GSProjectWorldLocationToWidgetPosition_ViewportPosition_Offset;

	private static bool GSProjectWorldLocationToWidgetPosition_bIsInFront_IsValid;

	private static FFieldAddress GSProjectWorldLocationToWidgetPosition_bIsInFront_PropertyAddress;

	private static int GSProjectWorldLocationToWidgetPosition_bIsInFront_Offset;

	private static bool GSProjectWorldLocationToWidgetPosition_ReturnValue_IsValid;

	private static FFieldAddress GSProjectWorldLocationToWidgetPosition_ReturnValue_PropertyAddress;

	private static int GSProjectWorldLocationToWidgetPosition_ReturnValue_Offset;

	private static bool GSProjectWidgetList_IsValid;

	private static IntPtr GSProjectWidgetList_FunctionAddress;

	private static int GSProjectWidgetList_ParamsSize;

	private static bool GSProjectWidgetList_PlayerController_IsValid;

	private static FFieldAddress GSProjectWidgetList_PlayerController_PropertyAddress;

	private static int GSProjectWidgetList_PlayerController_Offset;

	private static bool GSProjectWidgetList_Canvas_IsValid;

	private static FFieldAddress GSProjectWidgetList_Canvas_PropertyAddress;

	private static int GSProjectWidgetList_Canvas_Offset;

	private static bool GSProjectWidgetList_ProjWidgetInfos_IsValid;

	private static FFieldAddress GSProjectWidgetList_ProjWidgetInfos_PropertyAddress;

	private static int GSProjectWidgetList_ProjWidgetInfos_Offset;

	private static bool GSProjectWidgetList_Results_IsValid;

	private static FFieldAddress GSProjectWidgetList_Results_PropertyAddress;

	private static int GSProjectWidgetList_Results_Offset;

	private static bool GetWidgetPositionSizeRefViewPort_IsValid;

	private static IntPtr GetWidgetPositionSizeRefViewPort_FunctionAddress;

	private static int GetWidgetPositionSizeRefViewPort_ParamsSize;

	private static bool GetWidgetPositionSizeRefViewPort_widget_IsValid;

	private static FFieldAddress GetWidgetPositionSizeRefViewPort_widget_PropertyAddress;

	private static int GetWidgetPositionSizeRefViewPort_widget_Offset;

	private static bool GetWidgetPositionSizeRefViewPort_Position_IsValid;

	private static FFieldAddress GetWidgetPositionSizeRefViewPort_Position_PropertyAddress;

	private static int GetWidgetPositionSizeRefViewPort_Position_Offset;

	private static bool GetWidgetPositionSizeRefViewPort_WidgetSize_IsValid;

	private static FFieldAddress GetWidgetPositionSizeRefViewPort_WidgetSize_PropertyAddress;

	private static int GetWidgetPositionSizeRefViewPort_WidgetSize_Offset;

	private static bool GetWidgetLocalSize_IsValid;

	private static IntPtr GetWidgetLocalSize_FunctionAddress;

	private static int GetWidgetLocalSize_ParamsSize;

	private static bool GetWidgetLocalSize_widget_IsValid;

	private static FFieldAddress GetWidgetLocalSize_widget_PropertyAddress;

	private static int GetWidgetLocalSize_widget_Offset;

	private static bool GetWidgetLocalSize_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetLocalSize_ReturnValue_PropertyAddress;

	private static int GetWidgetLocalSize_ReturnValue_Offset;

	private static bool GetWidgetLocalPositionAtCoordinatesWithPaintSpace_IsValid;

	private static IntPtr GetWidgetLocalPositionAtCoordinatesWithPaintSpace_FunctionAddress;

	private static int GetWidgetLocalPositionAtCoordinatesWithPaintSpace_ParamsSize;

	private static bool GetWidgetLocalPositionAtCoordinatesWithPaintSpace_widget_IsValid;

	private static FFieldAddress GetWidgetLocalPositionAtCoordinatesWithPaintSpace_widget_PropertyAddress;

	private static int GetWidgetLocalPositionAtCoordinatesWithPaintSpace_widget_Offset;

	private static bool GetWidgetLocalPositionAtCoordinatesWithPaintSpace_NormalCoordinates_IsValid;

	private static FFieldAddress GetWidgetLocalPositionAtCoordinatesWithPaintSpace_NormalCoordinates_PropertyAddress;

	private static int GetWidgetLocalPositionAtCoordinatesWithPaintSpace_NormalCoordinates_Offset;

	private static bool GetWidgetLocalPositionAtCoordinatesWithPaintSpace_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetLocalPositionAtCoordinatesWithPaintSpace_ReturnValue_PropertyAddress;

	private static int GetWidgetLocalPositionAtCoordinatesWithPaintSpace_ReturnValue_Offset;

	private static bool GetWidgetLocalPositionAtCoordinates_IsValid;

	private static IntPtr GetWidgetLocalPositionAtCoordinates_FunctionAddress;

	private static int GetWidgetLocalPositionAtCoordinates_ParamsSize;

	private static bool GetWidgetLocalPositionAtCoordinates_widget_IsValid;

	private static FFieldAddress GetWidgetLocalPositionAtCoordinates_widget_PropertyAddress;

	private static int GetWidgetLocalPositionAtCoordinates_widget_Offset;

	private static bool GetWidgetLocalPositionAtCoordinates_NormalCoordinates_IsValid;

	private static FFieldAddress GetWidgetLocalPositionAtCoordinates_NormalCoordinates_PropertyAddress;

	private static int GetWidgetLocalPositionAtCoordinates_NormalCoordinates_Offset;

	private static bool GetWidgetLocalPositionAtCoordinates_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetLocalPositionAtCoordinates_ReturnValue_PropertyAddress;

	private static int GetWidgetLocalPositionAtCoordinates_ReturnValue_Offset;

	private static bool GetWidgetIsVariable_IsValid;

	private static IntPtr GetWidgetIsVariable_FunctionAddress;

	private static int GetWidgetIsVariable_ParamsSize;

	private static bool GetWidgetIsVariable_Widget_IsValid;

	private static FFieldAddress GetWidgetIsVariable_Widget_PropertyAddress;

	private static int GetWidgetIsVariable_Widget_Offset;

	private static bool GetWidgetIsVariable_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetIsVariable_ReturnValue_PropertyAddress;

	private static int GetWidgetIsVariable_ReturnValue_Offset;

	private static bool GetWidgetFromName_IsValid;

	private static IntPtr GetWidgetFromName_FunctionAddress;

	private static int GetWidgetFromName_ParamsSize;

	private static bool GetWidgetFromName_Widget_IsValid;

	private static FFieldAddress GetWidgetFromName_Widget_PropertyAddress;

	private static int GetWidgetFromName_Widget_Offset;

	private static bool GetWidgetFromName_Name_IsValid;

	private static FFieldAddress GetWidgetFromName_Name_PropertyAddress;

	private static int GetWidgetFromName_Name_Offset;

	private static bool GetWidgetFromName_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetFromName_ReturnValue_PropertyAddress;

	private static int GetWidgetFromName_ReturnValue_Offset;

	private static bool GetWidgetAnimationName_IsValid;

	private static IntPtr GetWidgetAnimationName_FunctionAddress;

	private static int GetWidgetAnimationName_ParamsSize;

	private static bool GetWidgetAnimationName_Animation_IsValid;

	private static FFieldAddress GetWidgetAnimationName_Animation_PropertyAddress;

	private static int GetWidgetAnimationName_Animation_Offset;

	private static bool GetWidgetAnimationName_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetAnimationName_ReturnValue_PropertyAddress;

	private static int GetWidgetAnimationName_ReturnValue_Offset;

	private static bool GetWidgetAnimationByName_IsValid;

	private static IntPtr GetWidgetAnimationByName_FunctionAddress;

	private static int GetWidgetAnimationByName_ParamsSize;

	private static bool GetWidgetAnimationByName_Widget_IsValid;

	private static FFieldAddress GetWidgetAnimationByName_Widget_PropertyAddress;

	private static int GetWidgetAnimationByName_Widget_Offset;

	private static bool GetWidgetAnimationByName_Name_IsValid;

	private static FFieldAddress GetWidgetAnimationByName_Name_PropertyAddress;

	private static int GetWidgetAnimationByName_Name_Offset;

	private static bool GetWidgetAnimationByName_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetAnimationByName_ReturnValue_PropertyAddress;

	private static int GetWidgetAnimationByName_ReturnValue_Offset;

	private static bool GetWidgetAbsScale_IsValid;

	private static IntPtr GetWidgetAbsScale_FunctionAddress;

	private static int GetWidgetAbsScale_ParamsSize;

	private static bool GetWidgetAbsScale_widget_IsValid;

	private static FFieldAddress GetWidgetAbsScale_widget_PropertyAddress;

	private static int GetWidgetAbsScale_widget_Offset;

	private static bool GetWidgetAbsScale_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetAbsScale_ReturnValue_PropertyAddress;

	private static int GetWidgetAbsScale_ReturnValue_Offset;

	private static bool GetWidgetAbsoluteSize_IsValid;

	private static IntPtr GetWidgetAbsoluteSize_FunctionAddress;

	private static int GetWidgetAbsoluteSize_ParamsSize;

	private static bool GetWidgetAbsoluteSize_widget_IsValid;

	private static FFieldAddress GetWidgetAbsoluteSize_widget_PropertyAddress;

	private static int GetWidgetAbsoluteSize_widget_Offset;

	private static bool GetWidgetAbsoluteSize_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetAbsoluteSize_ReturnValue_PropertyAddress;

	private static int GetWidgetAbsoluteSize_ReturnValue_Offset;

	private static bool GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_IsValid;

	private static IntPtr GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_FunctionAddress;

	private static int GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_ParamsSize;

	private static bool GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_widget_IsValid;

	private static FFieldAddress GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_widget_PropertyAddress;

	private static int GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_widget_Offset;

	private static bool GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_NormalCoordinates_IsValid;

	private static FFieldAddress GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_NormalCoordinates_PropertyAddress;

	private static int GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_NormalCoordinates_Offset;

	private static bool GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_ReturnValue_PropertyAddress;

	private static int GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_ReturnValue_Offset;

	private static bool GetWidgetAbsolutePositionAtCoordinates_IsValid;

	private static IntPtr GetWidgetAbsolutePositionAtCoordinates_FunctionAddress;

	private static int GetWidgetAbsolutePositionAtCoordinates_ParamsSize;

	private static bool GetWidgetAbsolutePositionAtCoordinates_widget_IsValid;

	private static FFieldAddress GetWidgetAbsolutePositionAtCoordinates_widget_PropertyAddress;

	private static int GetWidgetAbsolutePositionAtCoordinates_widget_Offset;

	private static bool GetWidgetAbsolutePositionAtCoordinates_NormalCoordinates_IsValid;

	private static FFieldAddress GetWidgetAbsolutePositionAtCoordinates_NormalCoordinates_PropertyAddress;

	private static int GetWidgetAbsolutePositionAtCoordinates_NormalCoordinates_Offset;

	private static bool GetWidgetAbsolutePositionAtCoordinates_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetAbsolutePositionAtCoordinates_ReturnValue_PropertyAddress;

	private static int GetWidgetAbsolutePositionAtCoordinates_ReturnValue_Offset;

	private static bool GetWidgetAbsolutePosition_IsValid;

	private static IntPtr GetWidgetAbsolutePosition_FunctionAddress;

	private static int GetWidgetAbsolutePosition_ParamsSize;

	private static bool GetWidgetAbsolutePosition_widget_IsValid;

	private static FFieldAddress GetWidgetAbsolutePosition_widget_PropertyAddress;

	private static int GetWidgetAbsolutePosition_widget_Offset;

	private static bool GetWidgetAbsolutePosition_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetAbsolutePosition_ReturnValue_PropertyAddress;

	private static int GetWidgetAbsolutePosition_ReturnValue_Offset;

	private static bool GetViewportSizeXY_IsValid;

	private static IntPtr GetViewportSizeXY_FunctionAddress;

	private static int GetViewportSizeXY_ParamsSize;

	private static bool GetViewportSizeXY_ReturnValue_IsValid;

	private static FFieldAddress GetViewportSizeXY_ReturnValue_PropertyAddress;

	private static int GetViewportSizeXY_ReturnValue_Offset;

	private static bool GetViewPortSize_IsValid;

	private static IntPtr GetViewPortSize_FunctionAddress;

	private static int GetViewPortSize_ParamsSize;

	private static bool GetViewPortSize_WorldContextObject_IsValid;

	private static FFieldAddress GetViewPortSize_WorldContextObject_PropertyAddress;

	private static int GetViewPortSize_WorldContextObject_Offset;

	private static bool GetViewPortSize_ReturnValue_IsValid;

	private static FFieldAddress GetViewPortSize_ReturnValue_PropertyAddress;

	private static int GetViewPortSize_ReturnValue_Offset;

	private static bool GetViewPortScale_IsValid;

	private static IntPtr GetViewPortScale_FunctionAddress;

	private static int GetViewPortScale_ParamsSize;

	private static bool GetViewPortScale_WorldContextObject_IsValid;

	private static FFieldAddress GetViewPortScale_WorldContextObject_PropertyAddress;

	private static int GetViewPortScale_WorldContextObject_Offset;

	private static bool GetViewPortScale_ReturnValue_IsValid;

	private static FFieldAddress GetViewPortScale_ReturnValue_PropertyAddress;

	private static int GetViewPortScale_ReturnValue_Offset;

	private static bool GetViewPortAbsPosition_IsValid;

	private static IntPtr GetViewPortAbsPosition_FunctionAddress;

	private static int GetViewPortAbsPosition_ParamsSize;

	private static bool GetViewPortAbsPosition_WorldContextObject_IsValid;

	private static FFieldAddress GetViewPortAbsPosition_WorldContextObject_PropertyAddress;

	private static int GetViewPortAbsPosition_WorldContextObject_Offset;

	private static bool GetViewPortAbsPosition_ReturnValue_IsValid;

	private static FFieldAddress GetViewPortAbsPosition_ReturnValue_PropertyAddress;

	private static int GetViewPortAbsPosition_ReturnValue_Offset;

	private static bool GetTextBlockOutlineDynamicMaterial_IsValid;

	private static IntPtr GetTextBlockOutlineDynamicMaterial_FunctionAddress;

	private static int GetTextBlockOutlineDynamicMaterial_ParamsSize;

	private static bool GetTextBlockOutlineDynamicMaterial_TextBlock_IsValid;

	private static FFieldAddress GetTextBlockOutlineDynamicMaterial_TextBlock_PropertyAddress;

	private static int GetTextBlockOutlineDynamicMaterial_TextBlock_Offset;

	private static bool GetTextBlockOutlineDynamicMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetTextBlockOutlineDynamicMaterial_ReturnValue_PropertyAddress;

	private static int GetTextBlockOutlineDynamicMaterial_ReturnValue_Offset;

	private static bool GetTexDAColor_IsValid;

	private static IntPtr GetTexDAColor_FunctionAddress;

	private static int GetTexDAColor_ParamsSize;

	private static bool GetTexDAColor_HitAreaDA_IsValid;

	private static FFieldAddress GetTexDAColor_HitAreaDA_PropertyAddress;

	private static int GetTexDAColor_HitAreaDA_Offset;

	private static bool GetTexDAColor_X_IsValid;

	private static FFieldAddress GetTexDAColor_X_PropertyAddress;

	private static int GetTexDAColor_X_Offset;

	private static bool GetTexDAColor_Y_IsValid;

	private static FFieldAddress GetTexDAColor_Y_PropertyAddress;

	private static int GetTexDAColor_Y_Offset;

	private static bool GetTexDAColor_OutColor_IsValid;

	private static FFieldAddress GetTexDAColor_OutColor_PropertyAddress;

	private static int GetTexDAColor_OutColor_Offset;

	private static bool GetTexDAColor_ReturnValue_IsValid;

	private static FFieldAddress GetTexDAColor_ReturnValue_PropertyAddress;

	private static int GetTexDAColor_ReturnValue_Offset;

	private static bool GetSafeZonePaddingSize_IsValid;

	private static IntPtr GetSafeZonePaddingSize_FunctionAddress;

	private static int GetSafeZonePaddingSize_ParamsSize;

	private static bool GetSafeZonePaddingSize_WorldContextObject_IsValid;

	private static FFieldAddress GetSafeZonePaddingSize_WorldContextObject_PropertyAddress;

	private static int GetSafeZonePaddingSize_WorldContextObject_Offset;

	private static bool GetSafeZonePaddingSize_ReturnValue_IsValid;

	private static FFieldAddress GetSafeZonePaddingSize_ReturnValue_PropertyAddress;

	private static int GetSafeZonePaddingSize_ReturnValue_Offset;

	private static bool GetRootWidget_IsValid;

	private static IntPtr GetRootWidget_FunctionAddress;

	private static int GetRootWidget_ParamsSize;

	private static bool GetRootWidget_Widget_IsValid;

	private static FFieldAddress GetRootWidget_Widget_PropertyAddress;

	private static int GetRootWidget_Widget_Offset;

	private static bool GetRootWidget_ReturnValue_IsValid;

	private static FFieldAddress GetRootWidget_ReturnValue_PropertyAddress;

	private static int GetRootWidget_ReturnValue_Offset;

	private static bool GetMouseWheelDelta_IsValid;

	private static IntPtr GetMouseWheelDelta_FunctionAddress;

	private static int GetMouseWheelDelta_ParamsSize;

	private static bool GetMouseWheelDelta_PointerEvent_IsValid;

	private static FFieldAddress GetMouseWheelDelta_PointerEvent_PropertyAddress;

	private static int GetMouseWheelDelta_PointerEvent_Offset;

	private static bool GetMouseWheelDelta_ReturnValue_IsValid;

	private static FFieldAddress GetMouseWheelDelta_ReturnValue_PropertyAddress;

	private static int GetMouseWheelDelta_ReturnValue_Offset;

	private static bool GetMousePositionFromViewport_IsValid;

	private static IntPtr GetMousePositionFromViewport_FunctionAddress;

	private static int GetMousePositionFromViewport_ParamsSize;

	private static bool GetMousePositionFromViewport_OutPosition_IsValid;

	private static FFieldAddress GetMousePositionFromViewport_OutPosition_PropertyAddress;

	private static int GetMousePositionFromViewport_OutPosition_Offset;

	private static bool GetMousePositionFromViewport_ReturnValue_IsValid;

	private static FFieldAddress GetMousePositionFromViewport_ReturnValue_PropertyAddress;

	private static int GetMousePositionFromViewport_ReturnValue_Offset;

	private static bool GetMouseKey_IsValid;

	private static IntPtr GetMouseKey_FunctionAddress;

	private static int GetMouseKey_ParamsSize;

	private static bool GetMouseKey_PointerEvent_IsValid;

	private static FFieldAddress GetMouseKey_PointerEvent_PropertyAddress;

	private static int GetMouseKey_PointerEvent_Offset;

	private static bool GetMouseKey_ReturnValue_IsValid;

	private static FFieldAddress GetMouseKey_ReturnValue_PropertyAddress;

	private static int GetMouseKey_ReturnValue_Offset;

	private static bool GetMediaPlayerTimer_IsValid;

	private static IntPtr GetMediaPlayerTimer_FunctionAddress;

	private static int GetMediaPlayerTimer_ParamsSize;

	private static bool GetMediaPlayerTimer_MediaPlayer_IsValid;

	private static FFieldAddress GetMediaPlayerTimer_MediaPlayer_PropertyAddress;

	private static int GetMediaPlayerTimer_MediaPlayer_Offset;

	private static bool GetMediaPlayerTimer_ReturnValue_IsValid;

	private static FFieldAddress GetMediaPlayerTimer_ReturnValue_PropertyAddress;

	private static int GetMediaPlayerTimer_ReturnValue_Offset;

	private static bool GetKeyWithName_IsValid;

	private static IntPtr GetKeyWithName_FunctionAddress;

	private static int GetKeyWithName_ParamsSize;

	private static bool GetKeyWithName_KeyName_IsValid;

	private static FFieldAddress GetKeyWithName_KeyName_PropertyAddress;

	private static int GetKeyWithName_KeyName_Offset;

	private static bool GetKeyWithName_ReturnValue_IsValid;

	private static FFieldAddress GetKeyWithName_ReturnValue_PropertyAddress;

	private static int GetKeyWithName_ReturnValue_Offset;

	private static bool GetIsGamepadKey_IsValid;

	private static IntPtr GetIsGamepadKey_FunctionAddress;

	private static int GetIsGamepadKey_ParamsSize;

	private static bool GetIsGamepadKey_KeyName_IsValid;

	private static FFieldAddress GetIsGamepadKey_KeyName_PropertyAddress;

	private static int GetIsGamepadKey_KeyName_Offset;

	private static bool GetIsGamepadKey_ReturnValue_IsValid;

	private static FFieldAddress GetIsGamepadKey_ReturnValue_PropertyAddress;

	private static int GetIsGamepadKey_ReturnValue_Offset;

	private static bool GetIsAxis1DKey_IsValid;

	private static IntPtr GetIsAxis1DKey_FunctionAddress;

	private static int GetIsAxis1DKey_ParamsSize;

	private static bool GetIsAxis1DKey_KeyName_IsValid;

	private static FFieldAddress GetIsAxis1DKey_KeyName_PropertyAddress;

	private static int GetIsAxis1DKey_KeyName_Offset;

	private static bool GetIsAxis1DKey_ReturnValue_IsValid;

	private static FFieldAddress GetIsAxis1DKey_ReturnValue_PropertyAddress;

	private static int GetIsAxis1DKey_ReturnValue_Offset;

	private static bool GetFocusEventUser_IsValid;

	private static IntPtr GetFocusEventUser_FunctionAddress;

	private static int GetFocusEventUser_ParamsSize;

	private static bool GetFocusEventUser_FocusEvent_IsValid;

	private static FFieldAddress GetFocusEventUser_FocusEvent_PropertyAddress;

	private static int GetFocusEventUser_FocusEvent_Offset;

	private static bool GetFocusEventUser_ReturnValue_IsValid;

	private static FFieldAddress GetFocusEventUser_ReturnValue_PropertyAddress;

	private static int GetFocusEventUser_ReturnValue_Offset;

	private static bool GetFocusEventCause_IsValid;

	private static IntPtr GetFocusEventCause_FunctionAddress;

	private static int GetFocusEventCause_ParamsSize;

	private static bool GetFocusEventCause_FocusEvent_IsValid;

	private static FFieldAddress GetFocusEventCause_FocusEvent_PropertyAddress;

	private static int GetFocusEventCause_FocusEvent_Offset;

	private static bool GetFocusEventCause_ReturnValue_IsValid;

	private static FFieldAddress GetFocusEventCause_ReturnValue_PropertyAddress;

	private static int GetFocusEventCause_ReturnValue_Offset;

	private static bool GetCurrentCulture_IsValid;

	private static IntPtr GetCurrentCulture_FunctionAddress;

	private static int GetCurrentCulture_ParamsSize;

	private static bool GetCurrentCulture_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentCulture_ReturnValue_PropertyAddress;

	private static int GetCurrentCulture_ReturnValue_Offset;

	private static bool GetChildWidgetAt_IsValid;

	private static IntPtr GetChildWidgetAt_FunctionAddress;

	private static int GetChildWidgetAt_ParamsSize;

	private static bool GetChildWidgetAt_ParentWidget_IsValid;

	private static FFieldAddress GetChildWidgetAt_ParentWidget_PropertyAddress;

	private static int GetChildWidgetAt_ParentWidget_Offset;

	private static bool GetChildWidgetAt_ChildIndex_IsValid;

	private static FFieldAddress GetChildWidgetAt_ChildIndex_PropertyAddress;

	private static int GetChildWidgetAt_ChildIndex_Offset;

	private static bool GetChildWidgetAt_ReturnValue_IsValid;

	private static FFieldAddress GetChildWidgetAt_ReturnValue_PropertyAddress;

	private static int GetChildWidgetAt_ReturnValue_Offset;

	private static bool GetAnalogValue_IsValid;

	private static IntPtr GetAnalogValue_FunctionAddress;

	private static int GetAnalogValue_ParamsSize;

	private static bool GetAnalogValue_AnalogInputEvent_IsValid;

	private static FFieldAddress GetAnalogValue_AnalogInputEvent_PropertyAddress;

	private static int GetAnalogValue_AnalogInputEvent_Offset;

	private static bool GetAnalogValue_ReturnValue_IsValid;

	private static FFieldAddress GetAnalogValue_ReturnValue_PropertyAddress;

	private static int GetAnalogValue_ReturnValue_Offset;

	private static bool GetAnalogKeyIsRepeat_IsValid;

	private static IntPtr GetAnalogKeyIsRepeat_FunctionAddress;

	private static int GetAnalogKeyIsRepeat_ParamsSize;

	private static bool GetAnalogKeyIsRepeat_AnalogInputEvent_IsValid;

	private static FFieldAddress GetAnalogKeyIsRepeat_AnalogInputEvent_PropertyAddress;

	private static int GetAnalogKeyIsRepeat_AnalogInputEvent_Offset;

	private static bool GetAnalogKeyIsRepeat_ReturnValue_IsValid;

	private static FFieldAddress GetAnalogKeyIsRepeat_ReturnValue_PropertyAddress;

	private static int GetAnalogKeyIsRepeat_ReturnValue_Offset;

	private static bool GetAnalogKey_IsValid;

	private static IntPtr GetAnalogKey_FunctionAddress;

	private static int GetAnalogKey_ParamsSize;

	private static bool GetAnalogKey_AnalogInputEvent_IsValid;

	private static FFieldAddress GetAnalogKey_AnalogInputEvent_PropertyAddress;

	private static int GetAnalogKey_AnalogInputEvent_Offset;

	private static bool GetAnalogKey_ReturnValue_IsValid;

	private static FFieldAddress GetAnalogKey_ReturnValue_PropertyAddress;

	private static int GetAnalogKey_ReturnValue_Offset;

	private static bool GetAllChildWidgetWithClass_IsValid;

	private static IntPtr GetAllChildWidgetWithClass_FunctionAddress;

	private static int GetAllChildWidgetWithClass_ParamsSize;

	private static bool GetAllChildWidgetWithClass_UserWidget_IsValid;

	private static FFieldAddress GetAllChildWidgetWithClass_UserWidget_PropertyAddress;

	private static int GetAllChildWidgetWithClass_UserWidget_Offset;

	private static bool GetAllChildWidgetWithClass_WidgetClass_IsValid;

	private static FFieldAddress GetAllChildWidgetWithClass_WidgetClass_PropertyAddress;

	private static int GetAllChildWidgetWithClass_WidgetClass_Offset;

	private static bool GetAllChildWidgetWithClass_ReturnValue_IsValid;

	private static FFieldAddress GetAllChildWidgetWithClass_ReturnValue_PropertyAddress;

	private static int GetAllChildWidgetWithClass_ReturnValue_Offset;

	private static bool GetAllChildWidget_IsValid;

	private static IntPtr GetAllChildWidget_FunctionAddress;

	private static int GetAllChildWidget_ParamsSize;

	private static bool GetAllChildWidget_UserWidget_IsValid;

	private static FFieldAddress GetAllChildWidget_UserWidget_PropertyAddress;

	private static int GetAllChildWidget_UserWidget_Offset;

	private static bool GetAllChildWidget_ReturnValue_IsValid;

	private static FFieldAddress GetAllChildWidget_ReturnValue_PropertyAddress;

	private static int GetAllChildWidget_ReturnValue_Offset;

	private static bool GetAllChildUserWidgetWithClass_IsValid;

	private static IntPtr GetAllChildUserWidgetWithClass_FunctionAddress;

	private static int GetAllChildUserWidgetWithClass_ParamsSize;

	private static bool GetAllChildUserWidgetWithClass_UserWidget_IsValid;

	private static FFieldAddress GetAllChildUserWidgetWithClass_UserWidget_PropertyAddress;

	private static int GetAllChildUserWidgetWithClass_UserWidget_Offset;

	private static bool GetAllChildUserWidgetWithClass_WidgetClass_IsValid;

	private static FFieldAddress GetAllChildUserWidgetWithClass_WidgetClass_PropertyAddress;

	private static int GetAllChildUserWidgetWithClass_WidgetClass_Offset;

	private static bool GetAllChildUserWidgetWithClass_ReturnValue_IsValid;

	private static FFieldAddress GetAllChildUserWidgetWithClass_ReturnValue_PropertyAddress;

	private static int GetAllChildUserWidgetWithClass_ReturnValue_Offset;

	private static bool GetAllChildUserWidget_IsValid;

	private static IntPtr GetAllChildUserWidget_FunctionAddress;

	private static int GetAllChildUserWidget_ParamsSize;

	private static bool GetAllChildUserWidget_ParentWidget_IsValid;

	private static FFieldAddress GetAllChildUserWidget_ParentWidget_PropertyAddress;

	private static int GetAllChildUserWidget_ParentWidget_Offset;

	private static bool GetAllChildUserWidget_ReturnValue_IsValid;

	private static FFieldAddress GetAllChildUserWidget_ReturnValue_PropertyAddress;

	private static int GetAllChildUserWidget_ReturnValue_Offset;

	private static bool FoldTextContent_IsValid;

	private static IntPtr FoldTextContent_FunctionAddress;

	private static int FoldTextContent_ParamsSize;

	private static bool FoldTextContent_InTextBlock_IsValid;

	private static FFieldAddress FoldTextContent_InTextBlock_PropertyAddress;

	private static int FoldTextContent_InTextBlock_Offset;

	private static bool FoldTextContent_InFoldingConfig_IsValid;

	private static FFieldAddress FoldTextContent_InFoldingConfig_PropertyAddress;

	private static int FoldTextContent_InFoldingConfig_Offset;

	private static bool FlushFontCache_IsValid;

	private static IntPtr FlushFontCache_FunctionAddress;

	private static int FlushFontCache_ParamsSize;

	private static bool FindChildWidgetIndex_IsValid;

	private static IntPtr FindChildWidgetIndex_FunctionAddress;

	private static int FindChildWidgetIndex_ParamsSize;

	private static bool FindChildWidgetIndex_UserWidget_IsValid;

	private static FFieldAddress FindChildWidgetIndex_UserWidget_PropertyAddress;

	private static int FindChildWidgetIndex_UserWidget_Offset;

	private static bool FindChildWidgetIndex_ParentWidget_IsValid;

	private static FFieldAddress FindChildWidgetIndex_ParentWidget_PropertyAddress;

	private static int FindChildWidgetIndex_ParentWidget_Offset;

	private static bool FindChildWidgetIndex_ChildWidgetName_IsValid;

	private static FFieldAddress FindChildWidgetIndex_ChildWidgetName_PropertyAddress;

	private static int FindChildWidgetIndex_ChildWidgetName_Offset;

	private static bool FindChildWidgetIndex_ReturnValue_IsValid;

	private static FFieldAddress FindChildWidgetIndex_ReturnValue_PropertyAddress;

	private static int FindChildWidgetIndex_ReturnValue_Offset;

	private static bool FindChildWidget_IsValid;

	private static IntPtr FindChildWidget_FunctionAddress;

	private static int FindChildWidget_ParamsSize;

	private static bool FindChildWidget_UserWidget_IsValid;

	private static FFieldAddress FindChildWidget_UserWidget_PropertyAddress;

	private static int FindChildWidget_UserWidget_Offset;

	private static bool FindChildWidget_ParentWidget_IsValid;

	private static FFieldAddress FindChildWidget_ParentWidget_PropertyAddress;

	private static int FindChildWidget_ParentWidget_Offset;

	private static bool FindChildWidget_ChildWidgetName_IsValid;

	private static FFieldAddress FindChildWidget_ChildWidgetName_PropertyAddress;

	private static int FindChildWidget_ChildWidgetName_Offset;

	private static bool FindChildWidget_ReturnValue_IsValid;

	private static FFieldAddress FindChildWidget_ReturnValue_PropertyAddress;

	private static int FindChildWidget_ReturnValue_Offset;

	private static bool CreateUserWidgetWithClass_IsValid;

	private static IntPtr CreateUserWidgetWithClass_FunctionAddress;

	private static int CreateUserWidgetWithClass_ParamsSize;

	private static bool CreateUserWidgetWithClass_WorldContext_IsValid;

	private static FFieldAddress CreateUserWidgetWithClass_WorldContext_PropertyAddress;

	private static int CreateUserWidgetWithClass_WorldContext_Offset;

	private static bool CreateUserWidgetWithClass_WidgetClass_IsValid;

	private static FFieldAddress CreateUserWidgetWithClass_WidgetClass_PropertyAddress;

	private static int CreateUserWidgetWithClass_WidgetClass_Offset;

	private static bool CreateUserWidgetWithClass_ReturnValue_IsValid;

	private static FFieldAddress CreateUserWidgetWithClass_ReturnValue_PropertyAddress;

	private static int CreateUserWidgetWithClass_ReturnValue_Offset;

	private static bool CreateUserWidget_IsValid;

	private static IntPtr CreateUserWidget_FunctionAddress;

	private static int CreateUserWidget_ParamsSize;

	private static bool CreateUserWidget_WorldContext_IsValid;

	private static FFieldAddress CreateUserWidget_WorldContext_PropertyAddress;

	private static int CreateUserWidget_WorldContext_Offset;

	private static bool CreateUserWidget_ResPath_IsValid;

	private static FFieldAddress CreateUserWidget_ResPath_PropertyAddress;

	private static int CreateUserWidget_ResPath_Offset;

	private static bool CreateUserWidget_ReturnValue_IsValid;

	private static FFieldAddress CreateUserWidget_ReturnValue_PropertyAddress;

	private static int CreateUserWidget_ReturnValue_Offset;

	private static bool CreateGSViewPortHelper_IsValid;

	private static IntPtr CreateGSViewPortHelper_FunctionAddress;

	private static int CreateGSViewPortHelper_ParamsSize;

	private static bool CreateGSViewPortHelper_WorldContext_IsValid;

	private static FFieldAddress CreateGSViewPortHelper_WorldContext_PropertyAddress;

	private static int CreateGSViewPortHelper_WorldContext_Offset;

	private static bool CreateGSViewPortHelper_ReturnValue_IsValid;

	private static FFieldAddress CreateGSViewPortHelper_ReturnValue_PropertyAddress;

	private static int CreateGSViewPortHelper_ReturnValue_Offset;

	private static bool CreateGSAnimKeyStateBlender_IsValid;

	private static IntPtr CreateGSAnimKeyStateBlender_FunctionAddress;

	private static int CreateGSAnimKeyStateBlender_ParamsSize;

	private static bool CreateGSAnimKeyStateBlender_WorldContext_IsValid;

	private static FFieldAddress CreateGSAnimKeyStateBlender_WorldContext_PropertyAddress;

	private static int CreateGSAnimKeyStateBlender_WorldContext_Offset;

	private static bool CreateGSAnimKeyStateBlender_ReturnValue_IsValid;

	private static FFieldAddress CreateGSAnimKeyStateBlender_ReturnValue_PropertyAddress;

	private static int CreateGSAnimKeyStateBlender_ReturnValue_Offset;

	private static bool CreateEditorStandaloneWidget_IsValid;

	private static IntPtr CreateEditorStandaloneWidget_FunctionAddress;

	private static int CreateEditorStandaloneWidget_ParamsSize;

	private static bool CreateEditorStandaloneWidget_OwningWidget_IsValid;

	private static FFieldAddress CreateEditorStandaloneWidget_OwningWidget_PropertyAddress;

	private static int CreateEditorStandaloneWidget_OwningWidget_Offset;

	private static bool CreateEditorStandaloneWidget_ResPath_IsValid;

	private static FFieldAddress CreateEditorStandaloneWidget_ResPath_PropertyAddress;

	private static int CreateEditorStandaloneWidget_ResPath_Offset;

	private static bool CreateEditorStandaloneWidget_Name_IsValid;

	private static FFieldAddress CreateEditorStandaloneWidget_Name_PropertyAddress;

	private static int CreateEditorStandaloneWidget_Name_Offset;

	private static bool CreateEditorStandaloneWidget_ReturnValue_IsValid;

	private static FFieldAddress CreateEditorStandaloneWidget_ReturnValue_PropertyAddress;

	private static int CreateEditorStandaloneWidget_ReturnValue_Offset;

	private static bool ConvertToTimeText_IsValid;

	private static IntPtr ConvertToTimeText_FunctionAddress;

	private static int ConvertToTimeText_ParamsSize;

	private static bool ConvertToTimeText_Year_IsValid;

	private static FFieldAddress ConvertToTimeText_Year_PropertyAddress;

	private static int ConvertToTimeText_Year_Offset;

	private static bool ConvertToTimeText_Month_IsValid;

	private static FFieldAddress ConvertToTimeText_Month_PropertyAddress;

	private static int ConvertToTimeText_Month_Offset;

	private static bool ConvertToTimeText_Day_IsValid;

	private static FFieldAddress ConvertToTimeText_Day_PropertyAddress;

	private static int ConvertToTimeText_Day_Offset;

	private static bool ConvertToTimeText_Hour_IsValid;

	private static FFieldAddress ConvertToTimeText_Hour_PropertyAddress;

	private static int ConvertToTimeText_Hour_Offset;

	private static bool ConvertToTimeText_Minute_IsValid;

	private static FFieldAddress ConvertToTimeText_Minute_PropertyAddress;

	private static int ConvertToTimeText_Minute_Offset;

	private static bool ConvertToTimeText_Second_IsValid;

	private static FFieldAddress ConvertToTimeText_Second_PropertyAddress;

	private static int ConvertToTimeText_Second_Offset;

	private static bool ConvertToTimeText_ReturnValue_IsValid;

	private static FFieldAddress ConvertToTimeText_ReturnValue_PropertyAddress;

	private static int ConvertToTimeText_ReturnValue_Offset;

	private static bool ConvertToDateText_IsValid;

	private static IntPtr ConvertToDateText_FunctionAddress;

	private static int ConvertToDateText_ParamsSize;

	private static bool ConvertToDateText_Year_IsValid;

	private static FFieldAddress ConvertToDateText_Year_PropertyAddress;

	private static int ConvertToDateText_Year_Offset;

	private static bool ConvertToDateText_Month_IsValid;

	private static FFieldAddress ConvertToDateText_Month_PropertyAddress;

	private static int ConvertToDateText_Month_Offset;

	private static bool ConvertToDateText_Day_IsValid;

	private static FFieldAddress ConvertToDateText_Day_PropertyAddress;

	private static int ConvertToDateText_Day_Offset;

	private static bool ConvertToDateText_Hour_IsValid;

	private static FFieldAddress ConvertToDateText_Hour_PropertyAddress;

	private static int ConvertToDateText_Hour_Offset;

	private static bool ConvertToDateText_Minute_IsValid;

	private static FFieldAddress ConvertToDateText_Minute_PropertyAddress;

	private static int ConvertToDateText_Minute_Offset;

	private static bool ConvertToDateText_Second_IsValid;

	private static FFieldAddress ConvertToDateText_Second_PropertyAddress;

	private static int ConvertToDateText_Second_Offset;

	private static bool ConvertToDateText_ReturnValue_IsValid;

	private static FFieldAddress ConvertToDateText_ReturnValue_PropertyAddress;

	private static int ConvertToDateText_ReturnValue_Offset;

	private static bool ConstructUWidgetWithClass_IsValid;

	private static IntPtr ConstructUWidgetWithClass_FunctionAddress;

	private static int ConstructUWidgetWithClass_ParamsSize;

	private static bool ConstructUWidgetWithClass_FromWidget_IsValid;

	private static FFieldAddress ConstructUWidgetWithClass_FromWidget_PropertyAddress;

	private static int ConstructUWidgetWithClass_FromWidget_Offset;

	private static bool ConstructUWidgetWithClass_WidgetClass_IsValid;

	private static FFieldAddress ConstructUWidgetWithClass_WidgetClass_PropertyAddress;

	private static int ConstructUWidgetWithClass_WidgetClass_Offset;

	private static bool ConstructUWidgetWithClass_ReturnValue_IsValid;

	private static FFieldAddress ConstructUWidgetWithClass_ReturnValue_PropertyAddress;

	private static int ConstructUWidgetWithClass_ReturnValue_Offset;

	private static bool CloneUserWidget_IsValid;

	private static IntPtr CloneUserWidget_FunctionAddress;

	private static int CloneUserWidget_ParamsSize;

	private static bool CloneUserWidget_BaseWidget_IsValid;

	private static FFieldAddress CloneUserWidget_BaseWidget_PropertyAddress;

	private static int CloneUserWidget_BaseWidget_Offset;

	private static bool CloneUserWidget_Name_IsValid;

	private static FFieldAddress CloneUserWidget_Name_PropertyAddress;

	private static int CloneUserWidget_Name_Offset;

	private static bool CloneUserWidget_ReturnValue_IsValid;

	private static FFieldAddress CloneUserWidget_ReturnValue_PropertyAddress;

	private static int CloneUserWidget_ReturnValue_Offset;

	private static bool CalcImageTexture_IsValid;

	private static IntPtr CalcImageTexture_FunctionAddress;

	private static int CalcImageTexture_ParamsSize;

	private static bool CalcImageTexture_InImage_IsValid;

	private static FFieldAddress CalcImageTexture_InImage_PropertyAddress;

	private static int CalcImageTexture_InImage_Offset;

	private static bool CalcImageTexture_OutColorArray_IsValid;

	private static FFieldAddress CalcImageTexture_OutColorArray_PropertyAddress;

	private static int CalcImageTexture_OutColorArray_Offset;

	private static bool CalcImageTexture_OutPosArray_IsValid;

	private static FFieldAddress CalcImageTexture_OutPosArray_PropertyAddress;

	private static int CalcImageTexture_OutPosArray_Offset;

	private static bool BindImageOnMouseDownEvent_IsValid;

	private static IntPtr BindImageOnMouseDownEvent_FunctionAddress;

	private static int BindImageOnMouseDownEvent_ParamsSize;

	private static bool BindImageOnMouseDownEvent_Image_IsValid;

	private static FFieldAddress BindImageOnMouseDownEvent_Image_PropertyAddress;

	private static int BindImageOnMouseDownEvent_Image_Offset;

	private static bool BindImageOnMouseDownEvent_TargetObj_IsValid;

	private static FFieldAddress BindImageOnMouseDownEvent_TargetObj_PropertyAddress;

	private static int BindImageOnMouseDownEvent_TargetObj_Offset;

	private static bool BindImageOnMouseDownEvent_Name_IsValid;

	private static FFieldAddress BindImageOnMouseDownEvent_Name_PropertyAddress;

	private static int BindImageOnMouseDownEvent_Name_Offset;

	private static bool BindImageOnMouseDownEvent_ReturnValue_IsValid;

	private static FFieldAddress BindImageOnMouseDownEvent_ReturnValue_PropertyAddress;

	private static int BindImageOnMouseDownEvent_ReturnValue_Offset;

	private static bool BindBorderOnMouseDownEvent_IsValid;

	private static IntPtr BindBorderOnMouseDownEvent_FunctionAddress;

	private static int BindBorderOnMouseDownEvent_ParamsSize;

	private static bool BindBorderOnMouseDownEvent_Border_IsValid;

	private static FFieldAddress BindBorderOnMouseDownEvent_Border_PropertyAddress;

	private static int BindBorderOnMouseDownEvent_Border_Offset;

	private static bool BindBorderOnMouseDownEvent_TargetObj_IsValid;

	private static FFieldAddress BindBorderOnMouseDownEvent_TargetObj_PropertyAddress;

	private static int BindBorderOnMouseDownEvent_TargetObj_Offset;

	private static bool BindBorderOnMouseDownEvent_Name_IsValid;

	private static FFieldAddress BindBorderOnMouseDownEvent_Name_PropertyAddress;

	private static int BindBorderOnMouseDownEvent_Name_Offset;

	private static bool BindBorderOnMouseDownEvent_ReturnValue_IsValid;

	private static FFieldAddress BindBorderOnMouseDownEvent_ReturnValue_PropertyAddress;

	private static int BindBorderOnMouseDownEvent_ReturnValue_Offset;

	private static bool AddUserWidgetAsSlateToViewport_IsValid;

	private static IntPtr AddUserWidgetAsSlateToViewport_FunctionAddress;

	private static int AddUserWidgetAsSlateToViewport_ParamsSize;

	private static bool AddUserWidgetAsSlateToViewport_Widget_IsValid;

	private static FFieldAddress AddUserWidgetAsSlateToViewport_Widget_PropertyAddress;

	private static int AddUserWidgetAsSlateToViewport_Widget_Offset;

	private static bool AddUserWidgetAsSlateToViewport_ZOrder_IsValid;

	private static FFieldAddress AddUserWidgetAsSlateToViewport_ZOrder_PropertyAddress;

	private static int AddUserWidgetAsSlateToViewport_ZOrder_Offset;

	private static bool ActiveVirtualKeyboard_IsValid;

	private static IntPtr ActiveVirtualKeyboard_FunctionAddress;

	private static int ActiveVirtualKeyboard_ParamsSize;

	private static bool ActiveVirtualKeyboard_IsActive_IsValid;

	private static FFieldAddress ActiveVirtualKeyboard_IsActive_PropertyAddress;

	private static int ActiveVirtualKeyboard_IsActive_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:WidgetLocalToRoundedLocal")]
	public unsafe static FVector2D WidgetLocalToRoundedLocal(UWidget widget, FVector2D LocalCoordinates)
	{
		if (!WidgetLocalToRoundedLocal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:WidgetLocalToRoundedLocal");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(WidgetLocalToRoundedLocal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WidgetLocalToRoundedLocal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, WidgetLocalToRoundedLocal_widget_Offset), 0, WidgetLocalToRoundedLocal_widget_PropertyAddress.Address, widget);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, WidgetLocalToRoundedLocal_LocalCoordinates_Offset), 0, WidgetLocalToRoundedLocal_LocalCoordinates_PropertyAddress.Address, LocalCoordinates);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WidgetLocalToRoundedLocal_FunctionAddress, intPtr, WidgetLocalToRoundedLocal_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, WidgetLocalToRoundedLocal_ReturnValue_Offset), 0, WidgetLocalToRoundedLocal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:WidgetLocalToAbsolute")]
	public unsafe static FVector2D WidgetLocalToAbsolute(UWidget widget, FVector2D LocalCoordinates)
	{
		if (!WidgetLocalToAbsolute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:WidgetLocalToAbsolute");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(WidgetLocalToAbsolute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WidgetLocalToAbsolute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, WidgetLocalToAbsolute_widget_Offset), 0, WidgetLocalToAbsolute_widget_PropertyAddress.Address, widget);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, WidgetLocalToAbsolute_LocalCoordinates_Offset), 0, WidgetLocalToAbsolute_LocalCoordinates_PropertyAddress.Address, LocalCoordinates);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WidgetLocalToAbsolute_FunctionAddress, intPtr, WidgetLocalToAbsolute_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, WidgetLocalToAbsolute_ReturnValue_Offset), 0, WidgetLocalToAbsolute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:WidgetAbsoluteToLocal")]
	public unsafe static FVector2D WidgetAbsoluteToLocal(UWidget widget, FVector2D AbsoluteCoordinates)
	{
		if (!WidgetAbsoluteToLocal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:WidgetAbsoluteToLocal");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(WidgetAbsoluteToLocal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WidgetAbsoluteToLocal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, WidgetAbsoluteToLocal_widget_Offset), 0, WidgetAbsoluteToLocal_widget_PropertyAddress.Address, widget);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, WidgetAbsoluteToLocal_AbsoluteCoordinates_Offset), 0, WidgetAbsoluteToLocal_AbsoluteCoordinates_PropertyAddress.Address, AbsoluteCoordinates);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WidgetAbsoluteToLocal_FunctionAddress, intPtr, WidgetAbsoluteToLocal_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, WidgetAbsoluteToLocal_ReturnValue_Offset), 0, WidgetAbsoluteToLocal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:SlateLocalToAbsolute")]
	public unsafe static FVector2D SlateLocalToAbsolute(FGeometry Geometry, FVector2D LocalPos)
	{
		if (!SlateLocalToAbsolute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:SlateLocalToAbsolute");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlateLocalToAbsolute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlateLocalToAbsolute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SlateLocalToAbsolute_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, SlateLocalToAbsolute_Geometry_Offset), 0, SlateLocalToAbsolute_Geometry_PropertyAddress.Address, Geometry);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SlateLocalToAbsolute_LocalPos_Offset), 0, SlateLocalToAbsolute_LocalPos_PropertyAddress.Address, LocalPos);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlateLocalToAbsolute_FunctionAddress, intPtr, SlateLocalToAbsolute_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, SlateLocalToAbsolute_ReturnValue_Offset), 0, SlateLocalToAbsolute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:SlateAbsoluteToLocal")]
	public unsafe static FVector2D SlateAbsoluteToLocal(FGeometry Geometry, FVector2D AbsolutePos)
	{
		if (!SlateAbsoluteToLocal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:SlateAbsoluteToLocal");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SlateAbsoluteToLocal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SlateAbsoluteToLocal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SlateAbsoluteToLocal_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, SlateAbsoluteToLocal_Geometry_Offset), 0, SlateAbsoluteToLocal_Geometry_PropertyAddress.Address, Geometry);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SlateAbsoluteToLocal_AbsolutePos_Offset), 0, SlateAbsoluteToLocal_AbsolutePos_PropertyAddress.Address, AbsolutePos);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SlateAbsoluteToLocal_FunctionAddress, intPtr, SlateAbsoluteToLocal_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, SlateAbsoluteToLocal_ReturnValue_Offset), 0, SlateAbsoluteToLocal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:SetWidgetEnable")]
	public unsafe static void SetWidgetEnable(UWidget Widget, bool Enable)
	{
		if (!SetWidgetEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:SetWidgetEnable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWidgetEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWidgetEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SetWidgetEnable_Widget_Offset), 0, SetWidgetEnable_Widget_PropertyAddress.Address, Widget);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWidgetEnable_Enable_Offset), 0, SetWidgetEnable_Enable_PropertyAddress.Address, Enable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetWidgetEnable_FunctionAddress, intPtr, SetWidgetEnable_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:SetUserFocusWithCause")]
	public unsafe static void SetUserFocusWithCause(APlayerController PlayerController, UWidget Widget, EFocusCause Cause)
	{
		if (!SetUserFocusWithCause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:SetUserFocusWithCause");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUserFocusWithCause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUserFocusWithCause_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, SetUserFocusWithCause_PlayerController_Offset), 0, SetUserFocusWithCause_PlayerController_PropertyAddress.Address, PlayerController);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SetUserFocusWithCause_Widget_Offset), 0, SetUserFocusWithCause_Widget_PropertyAddress.Address, Widget);
		EnumMarshaler<EFocusCause>.ToNative(IntPtr.Add(intPtr, SetUserFocusWithCause_Cause_Offset), 0, SetUserFocusWithCause_Cause_PropertyAddress.Address, Cause);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetUserFocusWithCause_FunctionAddress, intPtr, SetUserFocusWithCause_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:SetTextToBitmapFontBox")]
	public unsafe static void SetTextToBitmapFontBox(UWidget Widget, FText Text)
	{
		if (!SetTextToBitmapFontBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:SetTextToBitmapFontBox");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextToBitmapFontBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextToBitmapFontBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SetTextToBitmapFontBox_Widget_Offset), 0, SetTextToBitmapFontBox_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InitializeValue_InContainer(SetTextToBitmapFontBox_Text_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetTextToBitmapFontBox_Text_Offset), 0, SetTextToBitmapFontBox_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTextToBitmapFontBox_FunctionAddress, intPtr, SetTextToBitmapFontBox_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTextToBitmapFontBox_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:SetLocalStringTableEntry")]
	public unsafe static bool SetLocalStringTableEntry(FName ID, string Key, string Src)
	{
		if (!SetLocalStringTableEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:SetLocalStringTableEntry");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocalStringTableEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocalStringTableEntry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetLocalStringTableEntry_ID_Offset), 0, SetLocalStringTableEntry_ID_PropertyAddress.Address, ID);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalStringTableEntry_Key_Offset), 0, SetLocalStringTableEntry_Key_PropertyAddress.Address, Key);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalStringTableEntry_Src_Offset), 0, SetLocalStringTableEntry_Src_PropertyAddress.Address, Src);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLocalStringTableEntry_FunctionAddress, intPtr, SetLocalStringTableEntry_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLocalStringTableEntry_Key_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetLocalStringTableEntry_Src_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetLocalStringTableEntry_ReturnValue_Offset), 0, SetLocalStringTableEntry_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:SetHardwareCursor")]
	public unsafe static bool SetHardwareCursor(UObject WorldContextObject, EMouseCursor CursorShape, FName CursorName, FVector2D HotSpot)
	{
		if (!SetHardwareCursor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:SetHardwareCursor");
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

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:SetCurrentCulture")]
	public unsafe static bool SetCurrentCulture(string CultureName)
	{
		if (!SetCurrentCulture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:SetCurrentCulture");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurrentCulture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurrentCulture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCurrentCulture_CultureName_Offset), 0, SetCurrentCulture_CultureName_PropertyAddress.Address, CultureName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCurrentCulture_FunctionAddress, intPtr, SetCurrentCulture_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCurrentCulture_CultureName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurrentCulture_ReturnValue_Offset), 0, SetCurrentCulture_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:SetColorVisionDeficiencyType")]
	public unsafe static void SetColorVisionDeficiencyType(EColorVisionDeficiency Type, float Severity, bool CorrectDeficiency, bool ShowCorrectionWithDeficiency)
	{
		if (!SetColorVisionDeficiencyType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:SetColorVisionDeficiencyType");
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

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:RemoveUserWidgetAsSlateFromViewport")]
	public unsafe static void RemoveUserWidgetAsSlateFromViewport(UUserWidget Widget)
	{
		if (!RemoveUserWidgetAsSlateFromViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:RemoveUserWidgetAsSlateFromViewport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveUserWidgetAsSlateFromViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveUserWidgetAsSlateFromViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, RemoveUserWidgetAsSlateFromViewport_Widget_Offset), 0, RemoveUserWidgetAsSlateFromViewport_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveUserWidgetAsSlateFromViewport_FunctionAddress, intPtr, RemoveUserWidgetAsSlateFromViewport_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:RefreshRichTextDefaultStyle")]
	public unsafe static void RefreshRichTextDefaultStyle(URichTextBlock RichTextBlock)
	{
		if (!RefreshRichTextDefaultStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:RefreshRichTextDefaultStyle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshRichTextDefaultStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshRichTextDefaultStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URichTextBlock>.ToNative(IntPtr.Add(intPtr, RefreshRichTextDefaultStyle_RichTextBlock_Offset), 0, RefreshRichTextDefaultStyle_RichTextBlock_PropertyAddress.Address, RichTextBlock);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RefreshRichTextDefaultStyle_FunctionAddress, intPtr, RefreshRichTextDefaultStyle_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:RefreshDPIScale")]
	public unsafe static void RefreshDPIScale(UObject WorldContext)
	{
		if (!RefreshDPIScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:RefreshDPIScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshDPIScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshDPIScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RefreshDPIScale_WorldContext_Offset), 0, RefreshDPIScale_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RefreshDPIScale_FunctionAddress, intPtr, RefreshDPIScale_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:QAGetWidgetWithText")]
	public unsafe static void QAGetWidgetWithText(UObject WorldContextObject, out List<UWidget> FoundWidgets, string Text)
	{
		if (!QAGetWidgetWithText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:QAGetWidgetWithText");
			FoundWidgets = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QAGetWidgetWithText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QAGetWidgetWithText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, QAGetWidgetWithText_WorldContextObject_Offset), 0, QAGetWidgetWithText_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, QAGetWidgetWithText_Text_Offset), 0, QAGetWidgetWithText_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QAGetWidgetWithText_FunctionAddress, intPtr, QAGetWidgetWithText_ParamsSize);
		FoundWidgets = new TArrayCopyMarshaler<UWidget>(1, QAGetWidgetWithText_FoundWidgets_PropertyAddress, CachedMarshalingDelegates<UWidget, UObjectMarshaler<UWidget>>.FromNative, CachedMarshalingDelegates<UWidget, UObjectMarshaler<UWidget>>.ToNative).FromNative(IntPtr.Add(intPtr, QAGetWidgetWithText_FoundWidgets_Offset));
		NativeReflection.DestroyValue_InContainer(QAGetWidgetWithText_FoundWidgets_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(QAGetWidgetWithText_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:QAGetWidgetCenterPosition")]
	public unsafe static void QAGetWidgetCenterPosition(UWidget widget, out FVector2D WidgetPosition, out FVector2D CenterPosition, out FVector2D WidgetSize)
	{
		if (!QAGetWidgetCenterPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:QAGetWidgetCenterPosition");
			WidgetPosition = default(FVector2D);
			CenterPosition = default(FVector2D);
			WidgetSize = default(FVector2D);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QAGetWidgetCenterPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QAGetWidgetCenterPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, QAGetWidgetCenterPosition_widget_Offset), 0, QAGetWidgetCenterPosition_widget_PropertyAddress.Address, widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QAGetWidgetCenterPosition_FunctionAddress, intPtr, QAGetWidgetCenterPosition_ParamsSize);
		WidgetPosition = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, QAGetWidgetCenterPosition_WidgetPosition_Offset), 0, QAGetWidgetCenterPosition_WidgetPosition_PropertyAddress.Address);
		CenterPosition = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, QAGetWidgetCenterPosition_CenterPosition_Offset), 0, QAGetWidgetCenterPosition_CenterPosition_PropertyAddress.Address);
		WidgetSize = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, QAGetWidgetCenterPosition_WidgetSize_Offset), 0, QAGetWidgetCenterPosition_WidgetSize_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:QAGetAllWidgetsOfClass")]
	public unsafe static void QAGetAllWidgetsOfClass(UObject WorldContextObject, out List<UWidget> FoundWidgets, TSubclassOf<UWidget> WidgetClass)
	{
		if (!QAGetAllWidgetsOfClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:QAGetAllWidgetsOfClass");
			FoundWidgets = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QAGetAllWidgetsOfClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QAGetAllWidgetsOfClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, QAGetAllWidgetsOfClass_WorldContextObject_Offset), 0, QAGetAllWidgetsOfClass_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		TSubclassOfMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, QAGetAllWidgetsOfClass_WidgetClass_Offset), 0, QAGetAllWidgetsOfClass_WidgetClass_PropertyAddress.Address, WidgetClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QAGetAllWidgetsOfClass_FunctionAddress, intPtr, QAGetAllWidgetsOfClass_ParamsSize);
		FoundWidgets = new TArrayCopyMarshaler<UWidget>(1, QAGetAllWidgetsOfClass_FoundWidgets_PropertyAddress, CachedMarshalingDelegates<UWidget, UObjectMarshaler<UWidget>>.FromNative, CachedMarshalingDelegates<UWidget, UObjectMarshaler<UWidget>>.ToNative).FromNative(IntPtr.Add(intPtr, QAGetAllWidgetsOfClass_FoundWidgets_Offset));
		NativeReflection.DestroyValue_InContainer(QAGetAllWidgetsOfClass_FoundWidgets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_IsTouchFirstMove")]
	public unsafe static bool PointerEvent_IsTouchFirstMove(FPointerEvent PointerEvent)
	{
		if (!PointerEvent_IsTouchFirstMove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_IsTouchFirstMove");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_IsTouchFirstMove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_IsTouchFirstMove_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_IsTouchFirstMove_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_IsTouchFirstMove_PointerEvent_Offset), 0, PointerEvent_IsTouchFirstMove_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_IsTouchFirstMove_FunctionAddress, intPtr, PointerEvent_IsTouchFirstMove_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_IsTouchFirstMove_PointerEvent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PointerEvent_IsTouchFirstMove_ReturnValue_Offset), 0, PointerEvent_IsTouchFirstMove_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_IsMouseTouchEvent")]
	public unsafe static bool PointerEvent_IsMouseTouchEvent(FPointerEvent PointerEvent)
	{
		if (!PointerEvent_IsMouseTouchEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_IsMouseTouchEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_IsMouseTouchEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_IsMouseTouchEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_IsMouseTouchEvent_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_IsMouseTouchEvent_PointerEvent_Offset), 0, PointerEvent_IsMouseTouchEvent_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_IsMouseTouchEvent_FunctionAddress, intPtr, PointerEvent_IsMouseTouchEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_IsMouseTouchEvent_PointerEvent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PointerEvent_IsMouseTouchEvent_ReturnValue_Offset), 0, PointerEvent_IsMouseTouchEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_IsMouseButtonDown")]
	public unsafe static bool PointerEvent_IsMouseButtonDown(FPointerEvent PointerEvent, FName MouseButtonName)
	{
		if (!PointerEvent_IsMouseButtonDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_IsMouseButtonDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_IsMouseButtonDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_IsMouseButtonDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_IsMouseButtonDown_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_IsMouseButtonDown_PointerEvent_Offset), 0, PointerEvent_IsMouseButtonDown_PointerEvent_PropertyAddress.Address, PointerEvent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PointerEvent_IsMouseButtonDown_MouseButtonName_Offset), 0, PointerEvent_IsMouseButtonDown_MouseButtonName_PropertyAddress.Address, MouseButtonName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_IsMouseButtonDown_FunctionAddress, intPtr, PointerEvent_IsMouseButtonDown_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_IsMouseButtonDown_PointerEvent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PointerEvent_IsMouseButtonDown_ReturnValue_Offset), 0, PointerEvent_IsMouseButtonDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_GetScreenSpacePosition")]
	public unsafe static FVector2D PointerEvent_GetScreenSpacePosition(FPointerEvent PointerEvent)
	{
		if (!PointerEvent_GetScreenSpacePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_GetScreenSpacePosition");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_GetScreenSpacePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_GetScreenSpacePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_GetScreenSpacePosition_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_GetScreenSpacePosition_PointerEvent_Offset), 0, PointerEvent_GetScreenSpacePosition_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_GetScreenSpacePosition_FunctionAddress, intPtr, PointerEvent_GetScreenSpacePosition_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_GetScreenSpacePosition_PointerEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, PointerEvent_GetScreenSpacePosition_ReturnValue_Offset), 0, PointerEvent_GetScreenSpacePosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_GetPositionInGeometry")]
	public unsafe static FVector2D PointerEvent_GetPositionInGeometry(FGeometry Geometry, FPointerEvent PointerEvent)
	{
		if (!PointerEvent_GetPositionInGeometry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_GetPositionInGeometry");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_GetPositionInGeometry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_GetPositionInGeometry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_GetPositionInGeometry_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, PointerEvent_GetPositionInGeometry_Geometry_Offset), 0, PointerEvent_GetPositionInGeometry_Geometry_PropertyAddress.Address, Geometry);
		NativeReflection.InitializeValue_InContainer(PointerEvent_GetPositionInGeometry_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_GetPositionInGeometry_PointerEvent_Offset), 0, PointerEvent_GetPositionInGeometry_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_GetPositionInGeometry_FunctionAddress, intPtr, PointerEvent_GetPositionInGeometry_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_GetPositionInGeometry_PointerEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, PointerEvent_GetPositionInGeometry_ReturnValue_Offset), 0, PointerEvent_GetPositionInGeometry_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_GetPointerIndex")]
	public unsafe static int PointerEvent_GetPointerIndex(FPointerEvent PointerEvent)
	{
		if (!PointerEvent_GetPointerIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_GetPointerIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointerEvent_GetPointerIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointerEvent_GetPointerIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointerEvent_GetPointerIndex_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, PointerEvent_GetPointerIndex_PointerEvent_Offset), 0, PointerEvent_GetPointerIndex_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PointerEvent_GetPointerIndex_FunctionAddress, intPtr, PointerEvent_GetPointerIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointerEvent_GetPointerIndex_PointerEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, PointerEvent_GetPointerIndex_ReturnValue_Offset), 0, PointerEvent_GetPointerIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:NewLocalStringTable")]
	public unsafe static bool NewLocalStringTable(FName ID, string NameSpace)
	{
		if (!NewLocalStringTable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:NewLocalStringTable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NewLocalStringTable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NewLocalStringTable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, NewLocalStringTable_ID_Offset), 0, NewLocalStringTable_ID_PropertyAddress.Address, ID);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, NewLocalStringTable_NameSpace_Offset), 0, NewLocalStringTable_NameSpace_PropertyAddress.Address, NameSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NewLocalStringTable_FunctionAddress, intPtr, NewLocalStringTable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NewLocalStringTable_NameSpace_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NewLocalStringTable_ReturnValue_Offset), 0, NewLocalStringTable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:NeedExecuteActionWithDA")]
	public unsafe static bool NeedExecuteActionWithDA(FGeometry MyGeometry, FPointerEvent MouseEvent, UDataAsset HitAreaDA, float AdvancedHitAlpha)
	{
		if (!NeedExecuteActionWithDA_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:NeedExecuteActionWithDA");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NeedExecuteActionWithDA_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NeedExecuteActionWithDA_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(NeedExecuteActionWithDA_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, NeedExecuteActionWithDA_MyGeometry_Offset), 0, NeedExecuteActionWithDA_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(NeedExecuteActionWithDA_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, NeedExecuteActionWithDA_MouseEvent_Offset), 0, NeedExecuteActionWithDA_MouseEvent_PropertyAddress.Address, MouseEvent);
		UObjectMarshaler<UDataAsset>.ToNative(IntPtr.Add(intPtr, NeedExecuteActionWithDA_HitAreaDA_Offset), 0, NeedExecuteActionWithDA_HitAreaDA_PropertyAddress.Address, HitAreaDA);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, NeedExecuteActionWithDA_AdvancedHitAlpha_Offset), 0, NeedExecuteActionWithDA_AdvancedHitAlpha_PropertyAddress.Address, AdvancedHitAlpha);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NeedExecuteActionWithDA_FunctionAddress, intPtr, NeedExecuteActionWithDA_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NeedExecuteActionWithDA_MouseEvent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NeedExecuteActionWithDA_ReturnValue_Offset), 0, NeedExecuteActionWithDA_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:NeedExecuteAction")]
	public unsafe static bool NeedExecuteAction(FGeometry MyGeometry, FPointerEvent MouseEvent, UTexture2D AdvancedHitTexture, float AdvancedHitAlpha)
	{
		if (!NeedExecuteAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:NeedExecuteAction");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NeedExecuteAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NeedExecuteAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(NeedExecuteAction_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, NeedExecuteAction_MyGeometry_Offset), 0, NeedExecuteAction_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(NeedExecuteAction_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, NeedExecuteAction_MouseEvent_Offset), 0, NeedExecuteAction_MouseEvent_PropertyAddress.Address, MouseEvent);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, NeedExecuteAction_AdvancedHitTexture_Offset), 0, NeedExecuteAction_AdvancedHitTexture_PropertyAddress.Address, AdvancedHitTexture);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, NeedExecuteAction_AdvancedHitAlpha_Offset), 0, NeedExecuteAction_AdvancedHitAlpha_PropertyAddress.Address, AdvancedHitAlpha);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NeedExecuteAction_FunctionAddress, intPtr, NeedExecuteAction_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NeedExecuteAction_MouseEvent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NeedExecuteAction_ReturnValue_Offset), 0, NeedExecuteAction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:MakeEventReply")]
	public unsafe static FEventReply MakeEventReply(bool IsHandled)
	{
		if (!MakeEventReply_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:MakeEventReply");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeEventReply_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeEventReply_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MakeEventReply_IsHandled_Offset), 0, MakeEventReply_IsHandled_PropertyAddress.Address, IsHandled);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeEventReply_FunctionAddress, intPtr, MakeEventReply_ParamsSize);
		FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, MakeEventReply_ReturnValue_Offset), 0, MakeEventReply_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakeEventReply_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:LogHittestGrid")]
	public unsafe static void LogHittestGrid()
	{
		if (!LogHittestGrid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:LogHittestGrid");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogHittestGrid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogHittestGrid_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: LogHittestGrid_FunctionAddress, argsSize: LogHittestGrid_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:LocalToViewPortPos")]
	public unsafe static FVector2D LocalToViewPortPos(UObject WorldContextObject, FGeometry Geometry)
	{
		if (!LocalToViewPortPos_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:LocalToViewPortPos");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(LocalToViewPortPos_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LocalToViewPortPos_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LocalToViewPortPos_WorldContextObject_Offset), 0, LocalToViewPortPos_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(LocalToViewPortPos_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, LocalToViewPortPos_Geometry_Offset), 0, LocalToViewPortPos_Geometry_PropertyAddress.Address, Geometry);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LocalToViewPortPos_FunctionAddress, intPtr, LocalToViewPortPos_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, LocalToViewPortPos_ReturnValue_Offset), 0, LocalToViewPortPos_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:LocalToViewPortPixelPos")]
	public unsafe static FVector2D LocalToViewPortPixelPos(UObject WorldContextObject, FGeometry Geometry)
	{
		if (!LocalToViewPortPixelPos_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:LocalToViewPortPixelPos");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(LocalToViewPortPixelPos_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LocalToViewPortPixelPos_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LocalToViewPortPixelPos_WorldContextObject_Offset), 0, LocalToViewPortPixelPos_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(LocalToViewPortPixelPos_Geometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, LocalToViewPortPixelPos_Geometry_Offset), 0, LocalToViewPortPixelPos_Geometry_PropertyAddress.Address, Geometry);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LocalToViewPortPixelPos_FunctionAddress, intPtr, LocalToViewPortPixelPos_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, LocalToViewPortPixelPos_ReturnValue_Offset), 0, LocalToViewPortPixelPos_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:LoadTexture2DToAreaIDArray")]
	public unsafe static int LoadTexture2DToAreaIDArray(UTexture2D TargetTexture, Dictionary<FColor, int> AreaColorIDMap, out Dictionary<int, byte> AreaData, out FVector2D OutOriginPos, out FVector2D OutMapSize, out string ErrMsg)
	{
		if (!LoadTexture2DToAreaIDArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:LoadTexture2DToAreaIDArray");
			AreaData = null;
			OutOriginPos = default(FVector2D);
			OutMapSize = default(FVector2D);
			ErrMsg = FStringMarshaler.DefaultString;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadTexture2DToAreaIDArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadTexture2DToAreaIDArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, LoadTexture2DToAreaIDArray_TargetTexture_Offset), 0, LoadTexture2DToAreaIDArray_TargetTexture_PropertyAddress.Address, TargetTexture);
		NativeReflection.InitializeValue_InContainer(LoadTexture2DToAreaIDArray_AreaColorIDMap_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<FColor, int>(1, LoadTexture2DToAreaIDArray_AreaColorIDMap_PropertyAddress, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.FromNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, LoadTexture2DToAreaIDArray_AreaColorIDMap_Offset), AreaColorIDMap);
		NativeReflection.InitializeValue_InContainer(LoadTexture2DToAreaIDArray_AreaData_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadTexture2DToAreaIDArray_FunctionAddress, intPtr, LoadTexture2DToAreaIDArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadTexture2DToAreaIDArray_AreaColorIDMap_PropertyAddress.Address, intPtr);
		AreaData = new TMapCopyMarshaler<int, byte>(1, LoadTexture2DToAreaIDArray_AreaData_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(intPtr, LoadTexture2DToAreaIDArray_AreaData_Offset));
		NativeReflection.DestroyValue_InContainer(LoadTexture2DToAreaIDArray_AreaData_PropertyAddress.Address, intPtr);
		OutOriginPos = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, LoadTexture2DToAreaIDArray_OutOriginPos_Offset), 0, LoadTexture2DToAreaIDArray_OutOriginPos_PropertyAddress.Address);
		OutMapSize = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, LoadTexture2DToAreaIDArray_OutMapSize_Offset), 0, LoadTexture2DToAreaIDArray_OutMapSize_PropertyAddress.Address);
		ErrMsg = FStringMarshaler.FromNative(IntPtr.Add(intPtr, LoadTexture2DToAreaIDArray_ErrMsg_Offset), 0, LoadTexture2DToAreaIDArray_ErrMsg_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(LoadTexture2DToAreaIDArray_ErrMsg_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, LoadTexture2DToAreaIDArray_ReturnValue_Offset), 0, LoadTexture2DToAreaIDArray_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:IsWidgetVisiableWithParentInList")]
	public unsafe static void IsWidgetVisiableWithParentInList(List<UUserWidget> InWidgetList, out List<UUserWidget> OutWidgetList)
	{
		if (!IsWidgetVisiableWithParentInList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:IsWidgetVisiableWithParentInList");
			OutWidgetList = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsWidgetVisiableWithParentInList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsWidgetVisiableWithParentInList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UUserWidget>(1, IsWidgetVisiableWithParentInList_InWidgetList_PropertyAddress, CachedMarshalingDelegates<UUserWidget, UObjectMarshaler<UUserWidget>>.FromNative, CachedMarshalingDelegates<UUserWidget, UObjectMarshaler<UUserWidget>>.ToNative).ToNative(IntPtr.Add(intPtr, IsWidgetVisiableWithParentInList_InWidgetList_Offset), InWidgetList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsWidgetVisiableWithParentInList_FunctionAddress, intPtr, IsWidgetVisiableWithParentInList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsWidgetVisiableWithParentInList_InWidgetList_PropertyAddress.Address, intPtr);
		OutWidgetList = new TArrayCopyMarshaler<UUserWidget>(1, IsWidgetVisiableWithParentInList_OutWidgetList_PropertyAddress, CachedMarshalingDelegates<UUserWidget, UObjectMarshaler<UUserWidget>>.FromNative, CachedMarshalingDelegates<UUserWidget, UObjectMarshaler<UUserWidget>>.ToNative).FromNative(IntPtr.Add(intPtr, IsWidgetVisiableWithParentInList_OutWidgetList_Offset));
		NativeReflection.DestroyValue_InContainer(IsWidgetVisiableWithParentInList_OutWidgetList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:IsWidgetVisiableWithParent")]
	public unsafe static bool IsWidgetVisiableWithParent(UWidget TargetWidget)
	{
		if (!IsWidgetVisiableWithParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:IsWidgetVisiableWithParent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsWidgetVisiableWithParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsWidgetVisiableWithParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, IsWidgetVisiableWithParent_TargetWidget_Offset), 0, IsWidgetVisiableWithParent_TargetWidget_PropertyAddress.Address, TargetWidget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsWidgetVisiableWithParent_FunctionAddress, intPtr, IsWidgetVisiableWithParent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsWidgetVisiableWithParent_ReturnValue_Offset), 0, IsWidgetVisiableWithParent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:IsMediaBeginPlay")]
	public unsafe static bool IsMediaBeginPlay(UMediaPlayer MediaPlayer)
	{
		if (!IsMediaBeginPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:IsMediaBeginPlay");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMediaBeginPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMediaBeginPlay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaPlayer>.ToNative(IntPtr.Add(intPtr, IsMediaBeginPlay_MediaPlayer_Offset), 0, IsMediaBeginPlay_MediaPlayer_PropertyAddress.Address, MediaPlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsMediaBeginPlay_FunctionAddress, intPtr, IsMediaBeginPlay_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMediaBeginPlay_ReturnValue_Offset), 0, IsMediaBeginPlay_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:IsBinkMediaBeginPlay")]
	public unsafe static bool IsBinkMediaBeginPlay(UBinkMediaPlayer BinkMediaPlayer)
	{
		if (!IsBinkMediaBeginPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:IsBinkMediaBeginPlay");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsBinkMediaBeginPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsBinkMediaBeginPlay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBinkMediaPlayer>.ToNative(IntPtr.Add(intPtr, IsBinkMediaBeginPlay_BinkMediaPlayer_Offset), 0, IsBinkMediaBeginPlay_BinkMediaPlayer_PropertyAddress.Address, BinkMediaPlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsBinkMediaBeginPlay_FunctionAddress, intPtr, IsBinkMediaBeginPlay_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsBinkMediaBeginPlay_ReturnValue_Offset), 0, IsBinkMediaBeginPlay_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:InvokeWidgetInputEvent")]
	public unsafe static void InvokeWidgetInputEvent(UWidget uWidget, int inputType, FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		if (!InvokeWidgetInputEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:InvokeWidgetInputEvent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InvokeWidgetInputEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InvokeWidgetInputEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, InvokeWidgetInputEvent_uWidget_Offset), 0, InvokeWidgetInputEvent_uWidget_PropertyAddress.Address, uWidget);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InvokeWidgetInputEvent_inputType_Offset), 0, InvokeWidgetInputEvent_inputType_PropertyAddress.Address, inputType);
		NativeReflection.InitializeValue_InContainer(InvokeWidgetInputEvent_MyGeometry_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, InvokeWidgetInputEvent_MyGeometry_Offset), 0, InvokeWidgetInputEvent_MyGeometry_PropertyAddress.Address, MyGeometry);
		NativeReflection.InitializeValue_InContainer(InvokeWidgetInputEvent_MouseEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, InvokeWidgetInputEvent_MouseEvent_Offset), 0, InvokeWidgetInputEvent_MouseEvent_PropertyAddress.Address, MouseEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InvokeWidgetInputEvent_FunctionAddress, intPtr, InvokeWidgetInputEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InvokeWidgetInputEvent_MouseEvent_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GSProjectWorldLocationToWidgetPosition")]
	public unsafe static bool GSProjectWorldLocationToWidgetPosition(APlayerController PlayerController, FVector WorldLocation, out FVector2D ViewportPosition, out bool bIsInFront)
	{
		if (!GSProjectWorldLocationToWidgetPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GSProjectWorldLocationToWidgetPosition");
			ViewportPosition = default(FVector2D);
			bIsInFront = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSProjectWorldLocationToWidgetPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSProjectWorldLocationToWidgetPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GSProjectWorldLocationToWidgetPosition_PlayerController_Offset), 0, GSProjectWorldLocationToWidgetPosition_PlayerController_PropertyAddress.Address, PlayerController);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GSProjectWorldLocationToWidgetPosition_WorldLocation_Offset), 0, GSProjectWorldLocationToWidgetPosition_WorldLocation_PropertyAddress.Address, WorldLocation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GSProjectWorldLocationToWidgetPosition_FunctionAddress, intPtr, GSProjectWorldLocationToWidgetPosition_ParamsSize);
		ViewportPosition = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GSProjectWorldLocationToWidgetPosition_ViewportPosition_Offset), 0, GSProjectWorldLocationToWidgetPosition_ViewportPosition_PropertyAddress.Address);
		bIsInFront = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GSProjectWorldLocationToWidgetPosition_bIsInFront_Offset), 0, GSProjectWorldLocationToWidgetPosition_bIsInFront_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GSProjectWorldLocationToWidgetPosition_ReturnValue_Offset), 0, GSProjectWorldLocationToWidgetPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GSProjectWidgetList")]
	public unsafe static void GSProjectWidgetList(APlayerController PlayerController, UWidget Canvas, List<FProjWidgetInfo> ProjWidgetInfos, out List<FProjResult> Results)
	{
		if (!GSProjectWidgetList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GSProjectWidgetList");
			Results = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSProjectWidgetList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSProjectWidgetList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GSProjectWidgetList_PlayerController_Offset), 0, GSProjectWidgetList_PlayerController_PropertyAddress.Address, PlayerController);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, GSProjectWidgetList_Canvas_Offset), 0, GSProjectWidgetList_Canvas_PropertyAddress.Address, Canvas);
		new TArrayCopyMarshaler<FProjWidgetInfo>(1, GSProjectWidgetList_ProjWidgetInfos_PropertyAddress, CachedMarshalingDelegates<FProjWidgetInfo, FProjWidgetInfo>.FromNative, CachedMarshalingDelegates<FProjWidgetInfo, FProjWidgetInfo>.ToNative).ToNative(IntPtr.Add(intPtr, GSProjectWidgetList_ProjWidgetInfos_Offset), ProjWidgetInfos);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GSProjectWidgetList_FunctionAddress, intPtr, GSProjectWidgetList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSProjectWidgetList_ProjWidgetInfos_PropertyAddress.Address, intPtr);
		Results = new TArrayCopyMarshaler<FProjResult>(1, GSProjectWidgetList_Results_PropertyAddress, CachedMarshalingDelegates<FProjResult, FProjResult>.FromNative, CachedMarshalingDelegates<FProjResult, FProjResult>.ToNative).FromNative(IntPtr.Add(intPtr, GSProjectWidgetList_Results_Offset));
		NativeReflection.DestroyValue_InContainer(GSProjectWidgetList_Results_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetPositionSizeRefViewPort")]
	public unsafe static void GetWidgetPositionSizeRefViewPort(UWidget widget, out FVector2D Position, out FVector2D WidgetSize)
	{
		if (!GetWidgetPositionSizeRefViewPort_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetPositionSizeRefViewPort");
			Position = default(FVector2D);
			WidgetSize = default(FVector2D);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetPositionSizeRefViewPort_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetPositionSizeRefViewPort_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, GetWidgetPositionSizeRefViewPort_widget_Offset), 0, GetWidgetPositionSizeRefViewPort_widget_PropertyAddress.Address, widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWidgetPositionSizeRefViewPort_FunctionAddress, intPtr, GetWidgetPositionSizeRefViewPort_ParamsSize);
		Position = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetWidgetPositionSizeRefViewPort_Position_Offset), 0, GetWidgetPositionSizeRefViewPort_Position_PropertyAddress.Address);
		WidgetSize = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetWidgetPositionSizeRefViewPort_WidgetSize_Offset), 0, GetWidgetPositionSizeRefViewPort_WidgetSize_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetLocalSize")]
	public unsafe static FVector2D GetWidgetLocalSize(UWidget widget)
	{
		if (!GetWidgetLocalSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetLocalSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetLocalSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetLocalSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, GetWidgetLocalSize_widget_Offset), 0, GetWidgetLocalSize_widget_PropertyAddress.Address, widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWidgetLocalSize_FunctionAddress, intPtr, GetWidgetLocalSize_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetWidgetLocalSize_ReturnValue_Offset), 0, GetWidgetLocalSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetLocalPositionAtCoordinatesWithPaintSpace")]
	public unsafe static FVector2D GetWidgetLocalPositionAtCoordinatesWithPaintSpace(UWidget widget, FVector2D NormalCoordinates)
	{
		if (!GetWidgetLocalPositionAtCoordinatesWithPaintSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetLocalPositionAtCoordinatesWithPaintSpace");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetLocalPositionAtCoordinatesWithPaintSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetLocalPositionAtCoordinatesWithPaintSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, GetWidgetLocalPositionAtCoordinatesWithPaintSpace_widget_Offset), 0, GetWidgetLocalPositionAtCoordinatesWithPaintSpace_widget_PropertyAddress.Address, widget);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, GetWidgetLocalPositionAtCoordinatesWithPaintSpace_NormalCoordinates_Offset), 0, GetWidgetLocalPositionAtCoordinatesWithPaintSpace_NormalCoordinates_PropertyAddress.Address, NormalCoordinates);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWidgetLocalPositionAtCoordinatesWithPaintSpace_FunctionAddress, intPtr, GetWidgetLocalPositionAtCoordinatesWithPaintSpace_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetWidgetLocalPositionAtCoordinatesWithPaintSpace_ReturnValue_Offset), 0, GetWidgetLocalPositionAtCoordinatesWithPaintSpace_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetLocalPositionAtCoordinates")]
	public unsafe static FVector2D GetWidgetLocalPositionAtCoordinates(UWidget widget, FVector2D NormalCoordinates)
	{
		if (!GetWidgetLocalPositionAtCoordinates_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetLocalPositionAtCoordinates");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetLocalPositionAtCoordinates_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetLocalPositionAtCoordinates_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, GetWidgetLocalPositionAtCoordinates_widget_Offset), 0, GetWidgetLocalPositionAtCoordinates_widget_PropertyAddress.Address, widget);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, GetWidgetLocalPositionAtCoordinates_NormalCoordinates_Offset), 0, GetWidgetLocalPositionAtCoordinates_NormalCoordinates_PropertyAddress.Address, NormalCoordinates);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWidgetLocalPositionAtCoordinates_FunctionAddress, intPtr, GetWidgetLocalPositionAtCoordinates_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetWidgetLocalPositionAtCoordinates_ReturnValue_Offset), 0, GetWidgetLocalPositionAtCoordinates_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetIsVariable")]
	public unsafe static bool GetWidgetIsVariable(UWidget Widget)
	{
		if (!GetWidgetIsVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetIsVariable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetIsVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetIsVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, GetWidgetIsVariable_Widget_Offset), 0, GetWidgetIsVariable_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWidgetIsVariable_FunctionAddress, intPtr, GetWidgetIsVariable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetWidgetIsVariable_ReturnValue_Offset), 0, GetWidgetIsVariable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetFromName")]
	public unsafe static UWidget GetWidgetFromName(UUserWidget Widget, FName Name)
	{
		if (!GetWidgetFromName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetFromName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetFromName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetFromName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, GetWidgetFromName_Widget_Offset), 0, GetWidgetFromName_Widget_PropertyAddress.Address, Widget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetWidgetFromName_Name_Offset), 0, GetWidgetFromName_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWidgetFromName_FunctionAddress, intPtr, GetWidgetFromName_ParamsSize);
		return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, GetWidgetFromName_ReturnValue_Offset), 0, GetWidgetFromName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAnimationName")]
	public unsafe static string GetWidgetAnimationName(UWidgetAnimation Animation)
	{
		if (!GetWidgetAnimationName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAnimationName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetAnimationName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetAnimationName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, GetWidgetAnimationName_Animation_Offset), 0, GetWidgetAnimationName_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWidgetAnimationName_FunctionAddress, intPtr, GetWidgetAnimationName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetWidgetAnimationName_ReturnValue_Offset), 0, GetWidgetAnimationName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetWidgetAnimationName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAnimationByName")]
	public unsafe static UWidgetAnimation GetWidgetAnimationByName(UUserWidget Widget, string Name)
	{
		if (!GetWidgetAnimationByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAnimationByName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetAnimationByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetAnimationByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, GetWidgetAnimationByName_Widget_Offset), 0, GetWidgetAnimationByName_Widget_PropertyAddress.Address, Widget);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetWidgetAnimationByName_Name_Offset), 0, GetWidgetAnimationByName_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWidgetAnimationByName_FunctionAddress, intPtr, GetWidgetAnimationByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetWidgetAnimationByName_Name_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UWidgetAnimation>.FromNative(IntPtr.Add(intPtr, GetWidgetAnimationByName_ReturnValue_Offset), 0, GetWidgetAnimationByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsScale")]
	public unsafe static float GetWidgetAbsScale(UWidget widget)
	{
		if (!GetWidgetAbsScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsScale");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetAbsScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetAbsScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, GetWidgetAbsScale_widget_Offset), 0, GetWidgetAbsScale_widget_PropertyAddress.Address, widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWidgetAbsScale_FunctionAddress, intPtr, GetWidgetAbsScale_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetWidgetAbsScale_ReturnValue_Offset), 0, GetWidgetAbsScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsoluteSize")]
	public unsafe static FVector2D GetWidgetAbsoluteSize(UWidget widget)
	{
		if (!GetWidgetAbsoluteSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsoluteSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetAbsoluteSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetAbsoluteSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, GetWidgetAbsoluteSize_widget_Offset), 0, GetWidgetAbsoluteSize_widget_PropertyAddress.Address, widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWidgetAbsoluteSize_FunctionAddress, intPtr, GetWidgetAbsoluteSize_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetWidgetAbsoluteSize_ReturnValue_Offset), 0, GetWidgetAbsoluteSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace")]
	public unsafe static FVector2D GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace(UWidget widget, FVector2D NormalCoordinates)
	{
		if (!GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_widget_Offset), 0, GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_widget_PropertyAddress.Address, widget);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_NormalCoordinates_Offset), 0, GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_NormalCoordinates_PropertyAddress.Address, NormalCoordinates);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_FunctionAddress, intPtr, GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_ReturnValue_Offset), 0, GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsolutePositionAtCoordinates")]
	public unsafe static FVector2D GetWidgetAbsolutePositionAtCoordinates(UWidget widget, FVector2D NormalCoordinates)
	{
		if (!GetWidgetAbsolutePositionAtCoordinates_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsolutePositionAtCoordinates");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetAbsolutePositionAtCoordinates_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetAbsolutePositionAtCoordinates_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, GetWidgetAbsolutePositionAtCoordinates_widget_Offset), 0, GetWidgetAbsolutePositionAtCoordinates_widget_PropertyAddress.Address, widget);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, GetWidgetAbsolutePositionAtCoordinates_NormalCoordinates_Offset), 0, GetWidgetAbsolutePositionAtCoordinates_NormalCoordinates_PropertyAddress.Address, NormalCoordinates);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWidgetAbsolutePositionAtCoordinates_FunctionAddress, intPtr, GetWidgetAbsolutePositionAtCoordinates_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetWidgetAbsolutePositionAtCoordinates_ReturnValue_Offset), 0, GetWidgetAbsolutePositionAtCoordinates_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsolutePosition")]
	public unsafe static FVector2D GetWidgetAbsolutePosition(UWidget widget)
	{
		if (!GetWidgetAbsolutePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsolutePosition");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetAbsolutePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetAbsolutePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, GetWidgetAbsolutePosition_widget_Offset), 0, GetWidgetAbsolutePosition_widget_PropertyAddress.Address, widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWidgetAbsolutePosition_FunctionAddress, intPtr, GetWidgetAbsolutePosition_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetWidgetAbsolutePosition_ReturnValue_Offset), 0, GetWidgetAbsolutePosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetViewportSizeXY")]
	public unsafe static FIntPoint GetViewportSizeXY()
	{
		if (!GetViewportSizeXY_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetViewportSizeXY");
			return default(FIntPoint);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewportSizeXY_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewportSizeXY_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetViewportSizeXY_FunctionAddress, intPtr, GetViewportSizeXY_ParamsSize);
		return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(intPtr, GetViewportSizeXY_ReturnValue_Offset), 0, GetViewportSizeXY_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetViewPortSize")]
	public unsafe static FVector2D GetViewPortSize(UObject WorldContextObject)
	{
		if (!GetViewPortSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetViewPortSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewPortSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewPortSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetViewPortSize_WorldContextObject_Offset), 0, GetViewPortSize_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetViewPortSize_FunctionAddress, intPtr, GetViewPortSize_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetViewPortSize_ReturnValue_Offset), 0, GetViewPortSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetViewPortScale")]
	public unsafe static float GetViewPortScale(UObject WorldContextObject)
	{
		if (!GetViewPortScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetViewPortScale");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewPortScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewPortScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetViewPortScale_WorldContextObject_Offset), 0, GetViewPortScale_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetViewPortScale_FunctionAddress, intPtr, GetViewPortScale_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetViewPortScale_ReturnValue_Offset), 0, GetViewPortScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetViewPortAbsPosition")]
	public unsafe static FVector2D GetViewPortAbsPosition(UObject WorldContextObject)
	{
		if (!GetViewPortAbsPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetViewPortAbsPosition");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewPortAbsPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewPortAbsPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetViewPortAbsPosition_WorldContextObject_Offset), 0, GetViewPortAbsPosition_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetViewPortAbsPosition_FunctionAddress, intPtr, GetViewPortAbsPosition_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetViewPortAbsPosition_ReturnValue_Offset), 0, GetViewPortAbsPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetTextBlockOutlineDynamicMaterial")]
	public unsafe static UMaterialInstanceDynamic GetTextBlockOutlineDynamicMaterial(UTextBlock TextBlock)
	{
		if (!GetTextBlockOutlineDynamicMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetTextBlockOutlineDynamicMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextBlockOutlineDynamicMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextBlockOutlineDynamicMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextBlock>.ToNative(IntPtr.Add(intPtr, GetTextBlockOutlineDynamicMaterial_TextBlock_Offset), 0, GetTextBlockOutlineDynamicMaterial_TextBlock_PropertyAddress.Address, TextBlock);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTextBlockOutlineDynamicMaterial_FunctionAddress, intPtr, GetTextBlockOutlineDynamicMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GetTextBlockOutlineDynamicMaterial_ReturnValue_Offset), 0, GetTextBlockOutlineDynamicMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetTexDAColor")]
	public unsafe static bool GetTexDAColor(UDataAsset HitAreaDA, int X, int Y, out FLinearColor OutColor)
	{
		if (!GetTexDAColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetTexDAColor");
			OutColor = default(FLinearColor);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTexDAColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTexDAColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataAsset>.ToNative(IntPtr.Add(intPtr, GetTexDAColor_HitAreaDA_Offset), 0, GetTexDAColor_HitAreaDA_PropertyAddress.Address, HitAreaDA);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTexDAColor_X_Offset), 0, GetTexDAColor_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTexDAColor_Y_Offset), 0, GetTexDAColor_Y_PropertyAddress.Address, Y);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTexDAColor_FunctionAddress, intPtr, GetTexDAColor_ParamsSize);
		OutColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetTexDAColor_OutColor_Offset), 0, GetTexDAColor_OutColor_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTexDAColor_ReturnValue_Offset), 0, GetTexDAColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetSafeZonePaddingSize")]
	public unsafe static FMargin GetSafeZonePaddingSize(UObject WorldContextObject)
	{
		if (!GetSafeZonePaddingSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetSafeZonePaddingSize");
			return default(FMargin);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSafeZonePaddingSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSafeZonePaddingSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetSafeZonePaddingSize_WorldContextObject_Offset), 0, GetSafeZonePaddingSize_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSafeZonePaddingSize_FunctionAddress, intPtr, GetSafeZonePaddingSize_ParamsSize);
		return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(intPtr, GetSafeZonePaddingSize_ReturnValue_Offset), 0, GetSafeZonePaddingSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetRootWidget")]
	public unsafe static UWidget GetRootWidget(UUserWidget Widget)
	{
		if (!GetRootWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetRootWidget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRootWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRootWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, GetRootWidget_Widget_Offset), 0, GetRootWidget_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRootWidget_FunctionAddress, intPtr, GetRootWidget_ParamsSize);
		return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, GetRootWidget_ReturnValue_Offset), 0, GetRootWidget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetMouseWheelDelta")]
	public unsafe static float GetMouseWheelDelta(FPointerEvent PointerEvent)
	{
		if (!GetMouseWheelDelta_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetMouseWheelDelta");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMouseWheelDelta_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMouseWheelDelta_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetMouseWheelDelta_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, GetMouseWheelDelta_PointerEvent_Offset), 0, GetMouseWheelDelta_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMouseWheelDelta_FunctionAddress, intPtr, GetMouseWheelDelta_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetMouseWheelDelta_PointerEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMouseWheelDelta_ReturnValue_Offset), 0, GetMouseWheelDelta_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetMousePositionFromViewport")]
	public unsafe static bool GetMousePositionFromViewport(out FVector2D OutPosition)
	{
		if (!GetMousePositionFromViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetMousePositionFromViewport");
			OutPosition = default(FVector2D);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMousePositionFromViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMousePositionFromViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMousePositionFromViewport_FunctionAddress, intPtr, GetMousePositionFromViewport_ParamsSize);
		OutPosition = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetMousePositionFromViewport_OutPosition_Offset), 0, GetMousePositionFromViewport_OutPosition_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetMousePositionFromViewport_ReturnValue_Offset), 0, GetMousePositionFromViewport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetMouseKey")]
	public unsafe static FKey GetMouseKey(FPointerEvent PointerEvent)
	{
		if (!GetMouseKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetMouseKey");
			return default(FKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMouseKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMouseKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetMouseKey_PointerEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, GetMouseKey_PointerEvent_Offset), 0, GetMouseKey_PointerEvent_PropertyAddress.Address, PointerEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMouseKey_FunctionAddress, intPtr, GetMouseKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetMouseKey_PointerEvent_PropertyAddress.Address, intPtr);
		FKey result = FKey.FromNative(IntPtr.Add(intPtr, GetMouseKey_ReturnValue_Offset), 0, GetMouseKey_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMouseKey_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetMediaPlayerTimer")]
	public unsafe static double GetMediaPlayerTimer(UMediaPlayer MediaPlayer)
	{
		if (!GetMediaPlayerTimer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetMediaPlayerTimer");
			return 0.0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMediaPlayerTimer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMediaPlayerTimer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMediaPlayer>.ToNative(IntPtr.Add(intPtr, GetMediaPlayerTimer_MediaPlayer_Offset), 0, GetMediaPlayerTimer_MediaPlayer_PropertyAddress.Address, MediaPlayer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMediaPlayerTimer_FunctionAddress, intPtr, GetMediaPlayerTimer_ParamsSize);
		return BlittableTypeMarshaler<double>.FromNative(IntPtr.Add(intPtr, GetMediaPlayerTimer_ReturnValue_Offset), 0, GetMediaPlayerTimer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetKeyWithName")]
	public unsafe static FKey GetKeyWithName(FName KeyName)
	{
		if (!GetKeyWithName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetKeyWithName");
			return default(FKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKeyWithName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKeyWithName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetKeyWithName_KeyName_Offset), 0, GetKeyWithName_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetKeyWithName_FunctionAddress, intPtr, GetKeyWithName_ParamsSize);
		FKey result = FKey.FromNative(IntPtr.Add(intPtr, GetKeyWithName_ReturnValue_Offset), 0, GetKeyWithName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetKeyWithName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetIsGamepadKey")]
	public unsafe static bool GetIsGamepadKey(FName KeyName)
	{
		if (!GetIsGamepadKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetIsGamepadKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsGamepadKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsGamepadKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetIsGamepadKey_KeyName_Offset), 0, GetIsGamepadKey_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsGamepadKey_FunctionAddress, intPtr, GetIsGamepadKey_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsGamepadKey_ReturnValue_Offset), 0, GetIsGamepadKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetIsAxis1DKey")]
	public unsafe static bool GetIsAxis1DKey(FName KeyName)
	{
		if (!GetIsAxis1DKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetIsAxis1DKey");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsAxis1DKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsAxis1DKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetIsAxis1DKey_KeyName_Offset), 0, GetIsAxis1DKey_KeyName_PropertyAddress.Address, KeyName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsAxis1DKey_FunctionAddress, intPtr, GetIsAxis1DKey_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsAxis1DKey_ReturnValue_Offset), 0, GetIsAxis1DKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetFocusEventUser")]
	public unsafe static int GetFocusEventUser(FFocusEvent FocusEvent)
	{
		if (!GetFocusEventUser_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetFocusEventUser");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFocusEventUser_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFocusEventUser_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetFocusEventUser_FocusEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FFocusEvent>.ToNative(IntPtr.Add(intPtr, GetFocusEventUser_FocusEvent_Offset), 0, GetFocusEventUser_FocusEvent_PropertyAddress.Address, FocusEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFocusEventUser_FunctionAddress, intPtr, GetFocusEventUser_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetFocusEventUser_ReturnValue_Offset), 0, GetFocusEventUser_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetFocusEventCause")]
	public unsafe static EFocusCause GetFocusEventCause(FFocusEvent FocusEvent)
	{
		if (!GetFocusEventCause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetFocusEventCause");
			return EFocusCause.Mouse;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFocusEventCause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFocusEventCause_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetFocusEventCause_FocusEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FFocusEvent>.ToNative(IntPtr.Add(intPtr, GetFocusEventCause_FocusEvent_Offset), 0, GetFocusEventCause_FocusEvent_PropertyAddress.Address, FocusEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFocusEventCause_FunctionAddress, intPtr, GetFocusEventCause_ParamsSize);
		return EnumMarshaler<EFocusCause>.FromNative(IntPtr.Add(intPtr, GetFocusEventCause_ReturnValue_Offset), 0, GetFocusEventCause_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetCurrentCulture")]
	public unsafe static string GetCurrentCulture()
	{
		if (!GetCurrentCulture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetCurrentCulture");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentCulture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentCulture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentCulture_FunctionAddress, intPtr, GetCurrentCulture_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCurrentCulture_ReturnValue_Offset), 0, GetCurrentCulture_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCurrentCulture_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetChildWidgetAt")]
	public unsafe static UWidget GetChildWidgetAt(UPanelWidget ParentWidget, int ChildIndex)
	{
		if (!GetChildWidgetAt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetChildWidgetAt");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildWidgetAt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildWidgetAt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPanelWidget>.ToNative(IntPtr.Add(intPtr, GetChildWidgetAt_ParentWidget_Offset), 0, GetChildWidgetAt_ParentWidget_PropertyAddress.Address, ParentWidget);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetChildWidgetAt_ChildIndex_Offset), 0, GetChildWidgetAt_ChildIndex_PropertyAddress.Address, ChildIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetChildWidgetAt_FunctionAddress, intPtr, GetChildWidgetAt_ParamsSize);
		return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, GetChildWidgetAt_ReturnValue_Offset), 0, GetChildWidgetAt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetAnalogValue")]
	public unsafe static float GetAnalogValue(FAnalogInputEvent AnalogInputEvent)
	{
		if (!GetAnalogValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetAnalogValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnalogValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnalogValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAnalogValue_AnalogInputEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnalogInputEvent>.ToNative(IntPtr.Add(intPtr, GetAnalogValue_AnalogInputEvent_Offset), 0, GetAnalogValue_AnalogInputEvent_PropertyAddress.Address, AnalogInputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnalogValue_FunctionAddress, intPtr, GetAnalogValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAnalogValue_AnalogInputEvent_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAnalogValue_ReturnValue_Offset), 0, GetAnalogValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetAnalogKeyIsRepeat")]
	public unsafe static bool GetAnalogKeyIsRepeat(FAnalogInputEvent AnalogInputEvent)
	{
		if (!GetAnalogKeyIsRepeat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetAnalogKeyIsRepeat");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnalogKeyIsRepeat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnalogKeyIsRepeat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAnalogKeyIsRepeat_AnalogInputEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnalogInputEvent>.ToNative(IntPtr.Add(intPtr, GetAnalogKeyIsRepeat_AnalogInputEvent_Offset), 0, GetAnalogKeyIsRepeat_AnalogInputEvent_PropertyAddress.Address, AnalogInputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnalogKeyIsRepeat_FunctionAddress, intPtr, GetAnalogKeyIsRepeat_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAnalogKeyIsRepeat_AnalogInputEvent_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAnalogKeyIsRepeat_ReturnValue_Offset), 0, GetAnalogKeyIsRepeat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetAnalogKey")]
	public unsafe static FKey GetAnalogKey(FAnalogInputEvent AnalogInputEvent)
	{
		if (!GetAnalogKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetAnalogKey");
			return default(FKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnalogKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnalogKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAnalogKey_AnalogInputEvent_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnalogInputEvent>.ToNative(IntPtr.Add(intPtr, GetAnalogKey_AnalogInputEvent_Offset), 0, GetAnalogKey_AnalogInputEvent_PropertyAddress.Address, AnalogInputEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnalogKey_FunctionAddress, intPtr, GetAnalogKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAnalogKey_AnalogInputEvent_PropertyAddress.Address, intPtr);
		FKey result = FKey.FromNative(IntPtr.Add(intPtr, GetAnalogKey_ReturnValue_Offset), 0, GetAnalogKey_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAnalogKey_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetAllChildWidgetWithClass")]
	public unsafe static List<UWidget> GetAllChildWidgetWithClass(UUserWidget UserWidget, TSubclassOf<UObject> WidgetClass)
	{
		if (!GetAllChildWidgetWithClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetAllChildWidgetWithClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllChildWidgetWithClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllChildWidgetWithClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, GetAllChildWidgetWithClass_UserWidget_Offset), 0, GetAllChildWidgetWithClass_UserWidget_PropertyAddress.Address, UserWidget);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetAllChildWidgetWithClass_WidgetClass_Offset), 0, GetAllChildWidgetWithClass_WidgetClass_PropertyAddress.Address, WidgetClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllChildWidgetWithClass_FunctionAddress, intPtr, GetAllChildWidgetWithClass_ParamsSize);
		List<UWidget> result = new TArrayCopyMarshaler<UWidget>(1, GetAllChildWidgetWithClass_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UWidget, UObjectMarshaler<UWidget>>.FromNative, CachedMarshalingDelegates<UWidget, UObjectMarshaler<UWidget>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllChildWidgetWithClass_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllChildWidgetWithClass_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetAllChildWidget")]
	public unsafe static List<UWidget> GetAllChildWidget(UUserWidget UserWidget)
	{
		if (!GetAllChildWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetAllChildWidget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllChildWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllChildWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, GetAllChildWidget_UserWidget_Offset), 0, GetAllChildWidget_UserWidget_PropertyAddress.Address, UserWidget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllChildWidget_FunctionAddress, intPtr, GetAllChildWidget_ParamsSize);
		List<UWidget> result = new TArrayCopyMarshaler<UWidget>(1, GetAllChildWidget_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UWidget, UObjectMarshaler<UWidget>>.FromNative, CachedMarshalingDelegates<UWidget, UObjectMarshaler<UWidget>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllChildWidget_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllChildWidget_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetAllChildUserWidgetWithClass")]
	public unsafe static List<UWidget> GetAllChildUserWidgetWithClass(UUserWidget UserWidget, TSubclassOf<UObject> WidgetClass)
	{
		if (!GetAllChildUserWidgetWithClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetAllChildUserWidgetWithClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllChildUserWidgetWithClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllChildUserWidgetWithClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, GetAllChildUserWidgetWithClass_UserWidget_Offset), 0, GetAllChildUserWidgetWithClass_UserWidget_PropertyAddress.Address, UserWidget);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetAllChildUserWidgetWithClass_WidgetClass_Offset), 0, GetAllChildUserWidgetWithClass_WidgetClass_PropertyAddress.Address, WidgetClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllChildUserWidgetWithClass_FunctionAddress, intPtr, GetAllChildUserWidgetWithClass_ParamsSize);
		List<UWidget> result = new TArrayCopyMarshaler<UWidget>(1, GetAllChildUserWidgetWithClass_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UWidget, UObjectMarshaler<UWidget>>.FromNative, CachedMarshalingDelegates<UWidget, UObjectMarshaler<UWidget>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllChildUserWidgetWithClass_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllChildUserWidgetWithClass_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:GetAllChildUserWidget")]
	public unsafe static List<UUserWidget> GetAllChildUserWidget(UPanelWidget ParentWidget)
	{
		if (!GetAllChildUserWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:GetAllChildUserWidget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllChildUserWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllChildUserWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPanelWidget>.ToNative(IntPtr.Add(intPtr, GetAllChildUserWidget_ParentWidget_Offset), 0, GetAllChildUserWidget_ParentWidget_PropertyAddress.Address, ParentWidget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllChildUserWidget_FunctionAddress, intPtr, GetAllChildUserWidget_ParamsSize);
		List<UUserWidget> result = new TArrayCopyMarshaler<UUserWidget>(1, GetAllChildUserWidget_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UUserWidget, UObjectMarshaler<UUserWidget>>.FromNative, CachedMarshalingDelegates<UUserWidget, UObjectMarshaler<UUserWidget>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllChildUserWidget_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllChildUserWidget_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:FoldTextContent")]
	public unsafe static void FoldTextContent(UTextBlock InTextBlock, FTextFoldingConfig InFoldingConfig)
	{
		if (!FoldTextContent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:FoldTextContent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FoldTextContent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FoldTextContent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextBlock>.ToNative(IntPtr.Add(intPtr, FoldTextContent_InTextBlock_Offset), 0, FoldTextContent_InTextBlock_PropertyAddress.Address, InTextBlock);
		NativeReflection.InitializeValue_InContainer(FoldTextContent_InFoldingConfig_PropertyAddress.Address, intPtr);
		FTextFoldingConfig.ToNative(IntPtr.Add(intPtr, FoldTextContent_InFoldingConfig_Offset), 0, FoldTextContent_InFoldingConfig_PropertyAddress.Address, InFoldingConfig);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FoldTextContent_FunctionAddress, intPtr, FoldTextContent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FoldTextContent_InFoldingConfig_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:FlushFontCache")]
	public unsafe static void FlushFontCache()
	{
		if (!FlushFontCache_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:FlushFontCache");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FlushFontCache_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FlushFontCache_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: FlushFontCache_FunctionAddress, argsSize: FlushFontCache_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:FindChildWidgetIndex")]
	public unsafe static int FindChildWidgetIndex(UUserWidget UserWidget, UPanelWidget ParentWidget, FName ChildWidgetName)
	{
		if (!FindChildWidgetIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:FindChildWidgetIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindChildWidgetIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindChildWidgetIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, FindChildWidgetIndex_UserWidget_Offset), 0, FindChildWidgetIndex_UserWidget_PropertyAddress.Address, UserWidget);
		UObjectMarshaler<UPanelWidget>.ToNative(IntPtr.Add(intPtr, FindChildWidgetIndex_ParentWidget_Offset), 0, FindChildWidgetIndex_ParentWidget_PropertyAddress.Address, ParentWidget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindChildWidgetIndex_ChildWidgetName_Offset), 0, FindChildWidgetIndex_ChildWidgetName_PropertyAddress.Address, ChildWidgetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindChildWidgetIndex_FunctionAddress, intPtr, FindChildWidgetIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, FindChildWidgetIndex_ReturnValue_Offset), 0, FindChildWidgetIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:FindChildWidget")]
	public unsafe static UWidget FindChildWidget(UUserWidget UserWidget, UPanelWidget ParentWidget, FName ChildWidgetName)
	{
		if (!FindChildWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:FindChildWidget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindChildWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindChildWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, FindChildWidget_UserWidget_Offset), 0, FindChildWidget_UserWidget_PropertyAddress.Address, UserWidget);
		UObjectMarshaler<UPanelWidget>.ToNative(IntPtr.Add(intPtr, FindChildWidget_ParentWidget_Offset), 0, FindChildWidget_ParentWidget_PropertyAddress.Address, ParentWidget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindChildWidget_ChildWidgetName_Offset), 0, FindChildWidget_ChildWidgetName_PropertyAddress.Address, ChildWidgetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindChildWidget_FunctionAddress, intPtr, FindChildWidget_ParamsSize);
		return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, FindChildWidget_ReturnValue_Offset), 0, FindChildWidget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:CreateUserWidgetWithClass")]
	public unsafe static UUserWidget CreateUserWidgetWithClass(UObject WorldContext, TSubclassOf<UObject> WidgetClass)
	{
		if (!CreateUserWidgetWithClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:CreateUserWidgetWithClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateUserWidgetWithClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateUserWidgetWithClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateUserWidgetWithClass_WorldContext_Offset), 0, CreateUserWidgetWithClass_WorldContext_PropertyAddress.Address, WorldContext);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateUserWidgetWithClass_WidgetClass_Offset), 0, CreateUserWidgetWithClass_WidgetClass_PropertyAddress.Address, WidgetClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateUserWidgetWithClass_FunctionAddress, intPtr, CreateUserWidgetWithClass_ParamsSize);
		return UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(intPtr, CreateUserWidgetWithClass_ReturnValue_Offset), 0, CreateUserWidgetWithClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:CreateUserWidget")]
	public unsafe static UUserWidget CreateUserWidget(UObject WorldContext, string ResPath)
	{
		if (!CreateUserWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:CreateUserWidget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateUserWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateUserWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateUserWidget_WorldContext_Offset), 0, CreateUserWidget_WorldContext_PropertyAddress.Address, WorldContext);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateUserWidget_ResPath_Offset), 0, CreateUserWidget_ResPath_PropertyAddress.Address, ResPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateUserWidget_FunctionAddress, intPtr, CreateUserWidget_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateUserWidget_ResPath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(intPtr, CreateUserWidget_ReturnValue_Offset), 0, CreateUserWidget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:CreateGSViewPortHelper")]
	public unsafe static UGSViewPortHelper CreateGSViewPortHelper(UObject WorldContext)
	{
		if (!CreateGSViewPortHelper_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:CreateGSViewPortHelper");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateGSViewPortHelper_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateGSViewPortHelper_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateGSViewPortHelper_WorldContext_Offset), 0, CreateGSViewPortHelper_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateGSViewPortHelper_FunctionAddress, intPtr, CreateGSViewPortHelper_ParamsSize);
		return UObjectMarshaler<UGSViewPortHelper>.FromNative(IntPtr.Add(intPtr, CreateGSViewPortHelper_ReturnValue_Offset), 0, CreateGSViewPortHelper_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:CreateGSAnimKeyStateBlender")]
	public unsafe static UGSAnimKeyStateBlender CreateGSAnimKeyStateBlender(UObject WorldContext)
	{
		if (!CreateGSAnimKeyStateBlender_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:CreateGSAnimKeyStateBlender");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateGSAnimKeyStateBlender_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateGSAnimKeyStateBlender_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateGSAnimKeyStateBlender_WorldContext_Offset), 0, CreateGSAnimKeyStateBlender_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateGSAnimKeyStateBlender_FunctionAddress, intPtr, CreateGSAnimKeyStateBlender_ParamsSize);
		return UObjectMarshaler<UGSAnimKeyStateBlender>.FromNative(IntPtr.Add(intPtr, CreateGSAnimKeyStateBlender_ReturnValue_Offset), 0, CreateGSAnimKeyStateBlender_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:CreateEditorStandaloneWidget")]
	public unsafe static UUserWidget CreateEditorStandaloneWidget(UWidget OwningWidget, string ResPath, FName Name)
	{
		if (!CreateEditorStandaloneWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:CreateEditorStandaloneWidget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateEditorStandaloneWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateEditorStandaloneWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, CreateEditorStandaloneWidget_OwningWidget_Offset), 0, CreateEditorStandaloneWidget_OwningWidget_PropertyAddress.Address, OwningWidget);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateEditorStandaloneWidget_ResPath_Offset), 0, CreateEditorStandaloneWidget_ResPath_PropertyAddress.Address, ResPath);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateEditorStandaloneWidget_Name_Offset), 0, CreateEditorStandaloneWidget_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateEditorStandaloneWidget_FunctionAddress, intPtr, CreateEditorStandaloneWidget_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateEditorStandaloneWidget_ResPath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(intPtr, CreateEditorStandaloneWidget_ReturnValue_Offset), 0, CreateEditorStandaloneWidget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:ConvertToTimeText")]
	public unsafe static string ConvertToTimeText(int Year, int Month, int Day, int Hour, int Minute, int Second)
	{
		if (!ConvertToTimeText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:ConvertToTimeText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToTimeText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToTimeText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertToTimeText_Year_Offset), 0, ConvertToTimeText_Year_PropertyAddress.Address, Year);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertToTimeText_Month_Offset), 0, ConvertToTimeText_Month_PropertyAddress.Address, Month);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertToTimeText_Day_Offset), 0, ConvertToTimeText_Day_PropertyAddress.Address, Day);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertToTimeText_Hour_Offset), 0, ConvertToTimeText_Hour_PropertyAddress.Address, Hour);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertToTimeText_Minute_Offset), 0, ConvertToTimeText_Minute_PropertyAddress.Address, Minute);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertToTimeText_Second_Offset), 0, ConvertToTimeText_Second_PropertyAddress.Address, Second);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToTimeText_FunctionAddress, intPtr, ConvertToTimeText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, ConvertToTimeText_ReturnValue_Offset), 0, ConvertToTimeText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(ConvertToTimeText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:ConvertToDateText")]
	public unsafe static string ConvertToDateText(int Year, int Month, int Day, int Hour, int Minute, int Second)
	{
		if (!ConvertToDateText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:ConvertToDateText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToDateText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToDateText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertToDateText_Year_Offset), 0, ConvertToDateText_Year_PropertyAddress.Address, Year);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertToDateText_Month_Offset), 0, ConvertToDateText_Month_PropertyAddress.Address, Month);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertToDateText_Day_Offset), 0, ConvertToDateText_Day_PropertyAddress.Address, Day);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertToDateText_Hour_Offset), 0, ConvertToDateText_Hour_PropertyAddress.Address, Hour);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertToDateText_Minute_Offset), 0, ConvertToDateText_Minute_PropertyAddress.Address, Minute);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertToDateText_Second_Offset), 0, ConvertToDateText_Second_PropertyAddress.Address, Second);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToDateText_FunctionAddress, intPtr, ConvertToDateText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, ConvertToDateText_ReturnValue_Offset), 0, ConvertToDateText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(ConvertToDateText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:ConstructUWidgetWithClass")]
	public unsafe static UWidget ConstructUWidgetWithClass(UUserWidget FromWidget, TSubclassOf<UObject> WidgetClass)
	{
		if (!ConstructUWidgetWithClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:ConstructUWidgetWithClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConstructUWidgetWithClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConstructUWidgetWithClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, ConstructUWidgetWithClass_FromWidget_Offset), 0, ConstructUWidgetWithClass_FromWidget_PropertyAddress.Address, FromWidget);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ConstructUWidgetWithClass_WidgetClass_Offset), 0, ConstructUWidgetWithClass_WidgetClass_PropertyAddress.Address, WidgetClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConstructUWidgetWithClass_FunctionAddress, intPtr, ConstructUWidgetWithClass_ParamsSize);
		return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, ConstructUWidgetWithClass_ReturnValue_Offset), 0, ConstructUWidgetWithClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:CloneUserWidget")]
	public unsafe static UUserWidget CloneUserWidget(UUserWidget BaseWidget, FName Name)
	{
		if (!CloneUserWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:CloneUserWidget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloneUserWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloneUserWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, CloneUserWidget_BaseWidget_Offset), 0, CloneUserWidget_BaseWidget_PropertyAddress.Address, BaseWidget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CloneUserWidget_Name_Offset), 0, CloneUserWidget_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CloneUserWidget_FunctionAddress, intPtr, CloneUserWidget_ParamsSize);
		return UObjectMarshaler<UUserWidget>.FromNative(IntPtr.Add(intPtr, CloneUserWidget_ReturnValue_Offset), 0, CloneUserWidget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:CalcImageTexture")]
	public unsafe static void CalcImageTexture(UImage InImage, out List<FColor> OutColorArray, out List<FVector2D> OutPosArray)
	{
		if (!CalcImageTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:CalcImageTexture");
			OutColorArray = null;
			OutPosArray = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalcImageTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalcImageTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UImage>.ToNative(IntPtr.Add(intPtr, CalcImageTexture_InImage_Offset), 0, CalcImageTexture_InImage_PropertyAddress.Address, InImage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalcImageTexture_FunctionAddress, intPtr, CalcImageTexture_ParamsSize);
		OutColorArray = new TArrayCopyMarshaler<FColor>(1, CalcImageTexture_OutColorArray_PropertyAddress, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.FromNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.ToNative).FromNative(IntPtr.Add(intPtr, CalcImageTexture_OutColorArray_Offset));
		NativeReflection.DestroyValue_InContainer(CalcImageTexture_OutColorArray_PropertyAddress.Address, intPtr);
		OutPosArray = new TArrayCopyMarshaler<FVector2D>(1, CalcImageTexture_OutPosArray_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(intPtr, CalcImageTexture_OutPosArray_Offset));
		NativeReflection.DestroyValue_InContainer(CalcImageTexture_OutPosArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:BindImageOnMouseDownEvent")]
	public unsafe static bool BindImageOnMouseDownEvent(UImage Image, UObject TargetObj, FName Name)
	{
		if (!BindImageOnMouseDownEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:BindImageOnMouseDownEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BindImageOnMouseDownEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BindImageOnMouseDownEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UImage>.ToNative(IntPtr.Add(intPtr, BindImageOnMouseDownEvent_Image_Offset), 0, BindImageOnMouseDownEvent_Image_PropertyAddress.Address, Image);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BindImageOnMouseDownEvent_TargetObj_Offset), 0, BindImageOnMouseDownEvent_TargetObj_PropertyAddress.Address, TargetObj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BindImageOnMouseDownEvent_Name_Offset), 0, BindImageOnMouseDownEvent_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BindImageOnMouseDownEvent_FunctionAddress, intPtr, BindImageOnMouseDownEvent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BindImageOnMouseDownEvent_ReturnValue_Offset), 0, BindImageOnMouseDownEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:BindBorderOnMouseDownEvent")]
	public unsafe static bool BindBorderOnMouseDownEvent(UBorder Border, UObject TargetObj, FName Name)
	{
		if (!BindBorderOnMouseDownEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:BindBorderOnMouseDownEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BindBorderOnMouseDownEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BindBorderOnMouseDownEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBorder>.ToNative(IntPtr.Add(intPtr, BindBorderOnMouseDownEvent_Border_Offset), 0, BindBorderOnMouseDownEvent_Border_PropertyAddress.Address, Border);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BindBorderOnMouseDownEvent_TargetObj_Offset), 0, BindBorderOnMouseDownEvent_TargetObj_PropertyAddress.Address, TargetObj);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BindBorderOnMouseDownEvent_Name_Offset), 0, BindBorderOnMouseDownEvent_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BindBorderOnMouseDownEvent_FunctionAddress, intPtr, BindBorderOnMouseDownEvent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BindBorderOnMouseDownEvent_ReturnValue_Offset), 0, BindBorderOnMouseDownEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:AddUserWidgetAsSlateToViewport")]
	public unsafe static void AddUserWidgetAsSlateToViewport(UUserWidget Widget, int ZOrder = 0)
	{
		if (!AddUserWidgetAsSlateToViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:AddUserWidgetAsSlateToViewport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddUserWidgetAsSlateToViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddUserWidgetAsSlateToViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, AddUserWidgetAsSlateToViewport_Widget_Offset), 0, AddUserWidgetAsSlateToViewport_Widget_PropertyAddress.Address, Widget);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddUserWidgetAsSlateToViewport_ZOrder_Offset), 0, AddUserWidgetAsSlateToViewport_ZOrder_PropertyAddress.Address, ZOrder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddUserWidgetAsSlateToViewport_FunctionAddress, intPtr, AddUserWidgetAsSlateToViewport_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_UMGFuncLib:ActiveVirtualKeyboard")]
	public unsafe static void ActiveVirtualKeyboard(bool IsActive)
	{
		if (!ActiveVirtualKeyboard_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_UMGFuncLib:ActiveVirtualKeyboard");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActiveVirtualKeyboard_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActiveVirtualKeyboard_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ActiveVirtualKeyboard_IsActive_Offset), 0, ActiveVirtualKeyboard_IsActive_PropertyAddress.Address, IsActive);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ActiveVirtualKeyboard_FunctionAddress, intPtr, ActiveVirtualKeyboard_ParamsSize);
	}

	static UGSE_UMGFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_UMGFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_UMGFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_UMGFuncLib");
		WidgetLocalToRoundedLocal_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WidgetLocalToRoundedLocal");
		WidgetLocalToRoundedLocal_ParamsSize = NativeReflection.GetFunctionParamsSize(WidgetLocalToRoundedLocal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WidgetLocalToRoundedLocal_widget_PropertyAddress, WidgetLocalToRoundedLocal_FunctionAddress, "widget");
		WidgetLocalToRoundedLocal_widget_Offset = NativeReflectionCached.GetPropertyOffset(WidgetLocalToRoundedLocal_FunctionAddress, "widget");
		WidgetLocalToRoundedLocal_widget_IsValid = NativeReflectionCached.ValidatePropertyClass(WidgetLocalToRoundedLocal_FunctionAddress, "widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WidgetLocalToRoundedLocal_LocalCoordinates_PropertyAddress, WidgetLocalToRoundedLocal_FunctionAddress, "LocalCoordinates");
		WidgetLocalToRoundedLocal_LocalCoordinates_Offset = NativeReflectionCached.GetPropertyOffset(WidgetLocalToRoundedLocal_FunctionAddress, "LocalCoordinates");
		WidgetLocalToRoundedLocal_LocalCoordinates_IsValid = NativeReflectionCached.ValidatePropertyClass(WidgetLocalToRoundedLocal_FunctionAddress, "LocalCoordinates", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref WidgetLocalToRoundedLocal_ReturnValue_PropertyAddress, WidgetLocalToRoundedLocal_FunctionAddress, "ReturnValue");
		WidgetLocalToRoundedLocal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WidgetLocalToRoundedLocal_FunctionAddress, "ReturnValue");
		WidgetLocalToRoundedLocal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WidgetLocalToRoundedLocal_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		WidgetLocalToRoundedLocal_IsValid = WidgetLocalToRoundedLocal_FunctionAddress != IntPtr.Zero && WidgetLocalToRoundedLocal_widget_IsValid && WidgetLocalToRoundedLocal_LocalCoordinates_IsValid && WidgetLocalToRoundedLocal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:WidgetLocalToRoundedLocal", WidgetLocalToRoundedLocal_IsValid);
		WidgetLocalToAbsolute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WidgetLocalToAbsolute");
		WidgetLocalToAbsolute_ParamsSize = NativeReflection.GetFunctionParamsSize(WidgetLocalToAbsolute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WidgetLocalToAbsolute_widget_PropertyAddress, WidgetLocalToAbsolute_FunctionAddress, "widget");
		WidgetLocalToAbsolute_widget_Offset = NativeReflectionCached.GetPropertyOffset(WidgetLocalToAbsolute_FunctionAddress, "widget");
		WidgetLocalToAbsolute_widget_IsValid = NativeReflectionCached.ValidatePropertyClass(WidgetLocalToAbsolute_FunctionAddress, "widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WidgetLocalToAbsolute_LocalCoordinates_PropertyAddress, WidgetLocalToAbsolute_FunctionAddress, "LocalCoordinates");
		WidgetLocalToAbsolute_LocalCoordinates_Offset = NativeReflectionCached.GetPropertyOffset(WidgetLocalToAbsolute_FunctionAddress, "LocalCoordinates");
		WidgetLocalToAbsolute_LocalCoordinates_IsValid = NativeReflectionCached.ValidatePropertyClass(WidgetLocalToAbsolute_FunctionAddress, "LocalCoordinates", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref WidgetLocalToAbsolute_ReturnValue_PropertyAddress, WidgetLocalToAbsolute_FunctionAddress, "ReturnValue");
		WidgetLocalToAbsolute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WidgetLocalToAbsolute_FunctionAddress, "ReturnValue");
		WidgetLocalToAbsolute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WidgetLocalToAbsolute_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		WidgetLocalToAbsolute_IsValid = WidgetLocalToAbsolute_FunctionAddress != IntPtr.Zero && WidgetLocalToAbsolute_widget_IsValid && WidgetLocalToAbsolute_LocalCoordinates_IsValid && WidgetLocalToAbsolute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:WidgetLocalToAbsolute", WidgetLocalToAbsolute_IsValid);
		WidgetAbsoluteToLocal_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WidgetAbsoluteToLocal");
		WidgetAbsoluteToLocal_ParamsSize = NativeReflection.GetFunctionParamsSize(WidgetAbsoluteToLocal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WidgetAbsoluteToLocal_widget_PropertyAddress, WidgetAbsoluteToLocal_FunctionAddress, "widget");
		WidgetAbsoluteToLocal_widget_Offset = NativeReflectionCached.GetPropertyOffset(WidgetAbsoluteToLocal_FunctionAddress, "widget");
		WidgetAbsoluteToLocal_widget_IsValid = NativeReflectionCached.ValidatePropertyClass(WidgetAbsoluteToLocal_FunctionAddress, "widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WidgetAbsoluteToLocal_AbsoluteCoordinates_PropertyAddress, WidgetAbsoluteToLocal_FunctionAddress, "AbsoluteCoordinates");
		WidgetAbsoluteToLocal_AbsoluteCoordinates_Offset = NativeReflectionCached.GetPropertyOffset(WidgetAbsoluteToLocal_FunctionAddress, "AbsoluteCoordinates");
		WidgetAbsoluteToLocal_AbsoluteCoordinates_IsValid = NativeReflectionCached.ValidatePropertyClass(WidgetAbsoluteToLocal_FunctionAddress, "AbsoluteCoordinates", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref WidgetAbsoluteToLocal_ReturnValue_PropertyAddress, WidgetAbsoluteToLocal_FunctionAddress, "ReturnValue");
		WidgetAbsoluteToLocal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WidgetAbsoluteToLocal_FunctionAddress, "ReturnValue");
		WidgetAbsoluteToLocal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WidgetAbsoluteToLocal_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		WidgetAbsoluteToLocal_IsValid = WidgetAbsoluteToLocal_FunctionAddress != IntPtr.Zero && WidgetAbsoluteToLocal_widget_IsValid && WidgetAbsoluteToLocal_AbsoluteCoordinates_IsValid && WidgetAbsoluteToLocal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:WidgetAbsoluteToLocal", WidgetAbsoluteToLocal_IsValid);
		SlateLocalToAbsolute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlateLocalToAbsolute");
		SlateLocalToAbsolute_ParamsSize = NativeReflection.GetFunctionParamsSize(SlateLocalToAbsolute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlateLocalToAbsolute_Geometry_PropertyAddress, SlateLocalToAbsolute_FunctionAddress, "Geometry");
		SlateLocalToAbsolute_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(SlateLocalToAbsolute_FunctionAddress, "Geometry");
		SlateLocalToAbsolute_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(SlateLocalToAbsolute_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SlateLocalToAbsolute_LocalPos_PropertyAddress, SlateLocalToAbsolute_FunctionAddress, "LocalPos");
		SlateLocalToAbsolute_LocalPos_Offset = NativeReflectionCached.GetPropertyOffset(SlateLocalToAbsolute_FunctionAddress, "LocalPos");
		SlateLocalToAbsolute_LocalPos_IsValid = NativeReflectionCached.ValidatePropertyClass(SlateLocalToAbsolute_FunctionAddress, "LocalPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SlateLocalToAbsolute_ReturnValue_PropertyAddress, SlateLocalToAbsolute_FunctionAddress, "ReturnValue");
		SlateLocalToAbsolute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlateLocalToAbsolute_FunctionAddress, "ReturnValue");
		SlateLocalToAbsolute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlateLocalToAbsolute_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SlateLocalToAbsolute_IsValid = SlateLocalToAbsolute_FunctionAddress != IntPtr.Zero && SlateLocalToAbsolute_Geometry_IsValid && SlateLocalToAbsolute_LocalPos_IsValid && SlateLocalToAbsolute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:SlateLocalToAbsolute", SlateLocalToAbsolute_IsValid);
		SlateAbsoluteToLocal_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SlateAbsoluteToLocal");
		SlateAbsoluteToLocal_ParamsSize = NativeReflection.GetFunctionParamsSize(SlateAbsoluteToLocal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SlateAbsoluteToLocal_Geometry_PropertyAddress, SlateAbsoluteToLocal_FunctionAddress, "Geometry");
		SlateAbsoluteToLocal_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(SlateAbsoluteToLocal_FunctionAddress, "Geometry");
		SlateAbsoluteToLocal_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(SlateAbsoluteToLocal_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SlateAbsoluteToLocal_AbsolutePos_PropertyAddress, SlateAbsoluteToLocal_FunctionAddress, "AbsolutePos");
		SlateAbsoluteToLocal_AbsolutePos_Offset = NativeReflectionCached.GetPropertyOffset(SlateAbsoluteToLocal_FunctionAddress, "AbsolutePos");
		SlateAbsoluteToLocal_AbsolutePos_IsValid = NativeReflectionCached.ValidatePropertyClass(SlateAbsoluteToLocal_FunctionAddress, "AbsolutePos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SlateAbsoluteToLocal_ReturnValue_PropertyAddress, SlateAbsoluteToLocal_FunctionAddress, "ReturnValue");
		SlateAbsoluteToLocal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SlateAbsoluteToLocal_FunctionAddress, "ReturnValue");
		SlateAbsoluteToLocal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SlateAbsoluteToLocal_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SlateAbsoluteToLocal_IsValid = SlateAbsoluteToLocal_FunctionAddress != IntPtr.Zero && SlateAbsoluteToLocal_Geometry_IsValid && SlateAbsoluteToLocal_AbsolutePos_IsValid && SlateAbsoluteToLocal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:SlateAbsoluteToLocal", SlateAbsoluteToLocal_IsValid);
		SetWidgetEnable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetWidgetEnable");
		SetWidgetEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWidgetEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWidgetEnable_Widget_PropertyAddress, SetWidgetEnable_FunctionAddress, "Widget");
		SetWidgetEnable_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SetWidgetEnable_FunctionAddress, "Widget");
		SetWidgetEnable_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWidgetEnable_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWidgetEnable_Enable_PropertyAddress, SetWidgetEnable_FunctionAddress, "Enable");
		SetWidgetEnable_Enable_Offset = NativeReflectionCached.GetPropertyOffset(SetWidgetEnable_FunctionAddress, "Enable");
		SetWidgetEnable_Enable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWidgetEnable_FunctionAddress, "Enable", Classes.FBoolProperty);
		SetWidgetEnable_IsValid = SetWidgetEnable_FunctionAddress != IntPtr.Zero && SetWidgetEnable_Widget_IsValid && SetWidgetEnable_Enable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:SetWidgetEnable", SetWidgetEnable_IsValid);
		SetUserFocusWithCause_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetUserFocusWithCause");
		SetUserFocusWithCause_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUserFocusWithCause_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUserFocusWithCause_PlayerController_PropertyAddress, SetUserFocusWithCause_FunctionAddress, "PlayerController");
		SetUserFocusWithCause_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(SetUserFocusWithCause_FunctionAddress, "PlayerController");
		SetUserFocusWithCause_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUserFocusWithCause_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUserFocusWithCause_Widget_PropertyAddress, SetUserFocusWithCause_FunctionAddress, "Widget");
		SetUserFocusWithCause_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SetUserFocusWithCause_FunctionAddress, "Widget");
		SetUserFocusWithCause_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUserFocusWithCause_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUserFocusWithCause_Cause_PropertyAddress, SetUserFocusWithCause_FunctionAddress, "Cause");
		SetUserFocusWithCause_Cause_Offset = NativeReflectionCached.GetPropertyOffset(SetUserFocusWithCause_FunctionAddress, "Cause");
		SetUserFocusWithCause_Cause_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUserFocusWithCause_FunctionAddress, "Cause", Classes.FEnumProperty);
		SetUserFocusWithCause_IsValid = SetUserFocusWithCause_FunctionAddress != IntPtr.Zero && SetUserFocusWithCause_PlayerController_IsValid && SetUserFocusWithCause_Widget_IsValid && SetUserFocusWithCause_Cause_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:SetUserFocusWithCause", SetUserFocusWithCause_IsValid);
		SetTextToBitmapFontBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTextToBitmapFontBox");
		SetTextToBitmapFontBox_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextToBitmapFontBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextToBitmapFontBox_Widget_PropertyAddress, SetTextToBitmapFontBox_FunctionAddress, "Widget");
		SetTextToBitmapFontBox_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SetTextToBitmapFontBox_FunctionAddress, "Widget");
		SetTextToBitmapFontBox_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextToBitmapFontBox_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTextToBitmapFontBox_Text_PropertyAddress, SetTextToBitmapFontBox_FunctionAddress, "Text");
		SetTextToBitmapFontBox_Text_Offset = NativeReflectionCached.GetPropertyOffset(SetTextToBitmapFontBox_FunctionAddress, "Text");
		SetTextToBitmapFontBox_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextToBitmapFontBox_FunctionAddress, "Text", Classes.FTextProperty);
		SetTextToBitmapFontBox_IsValid = SetTextToBitmapFontBox_FunctionAddress != IntPtr.Zero && SetTextToBitmapFontBox_Widget_IsValid && SetTextToBitmapFontBox_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:SetTextToBitmapFontBox", SetTextToBitmapFontBox_IsValid);
		SetLocalStringTableEntry_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLocalStringTableEntry");
		SetLocalStringTableEntry_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocalStringTableEntry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocalStringTableEntry_ID_PropertyAddress, SetLocalStringTableEntry_FunctionAddress, "ID");
		SetLocalStringTableEntry_ID_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalStringTableEntry_FunctionAddress, "ID");
		SetLocalStringTableEntry_ID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalStringTableEntry_FunctionAddress, "ID", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalStringTableEntry_Key_PropertyAddress, SetLocalStringTableEntry_FunctionAddress, "Key");
		SetLocalStringTableEntry_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalStringTableEntry_FunctionAddress, "Key");
		SetLocalStringTableEntry_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalStringTableEntry_FunctionAddress, "Key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalStringTableEntry_Src_PropertyAddress, SetLocalStringTableEntry_FunctionAddress, "Src");
		SetLocalStringTableEntry_Src_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalStringTableEntry_FunctionAddress, "Src");
		SetLocalStringTableEntry_Src_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalStringTableEntry_FunctionAddress, "Src", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalStringTableEntry_ReturnValue_PropertyAddress, SetLocalStringTableEntry_FunctionAddress, "ReturnValue");
		SetLocalStringTableEntry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalStringTableEntry_FunctionAddress, "ReturnValue");
		SetLocalStringTableEntry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalStringTableEntry_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetLocalStringTableEntry_IsValid = SetLocalStringTableEntry_FunctionAddress != IntPtr.Zero && SetLocalStringTableEntry_ID_IsValid && SetLocalStringTableEntry_Key_IsValid && SetLocalStringTableEntry_Src_IsValid && SetLocalStringTableEntry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:SetLocalStringTableEntry", SetLocalStringTableEntry_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:SetHardwareCursor", SetHardwareCursor_IsValid);
		SetCurrentCulture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurrentCulture");
		SetCurrentCulture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentCulture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentCulture_CultureName_PropertyAddress, SetCurrentCulture_FunctionAddress, "CultureName");
		SetCurrentCulture_CultureName_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentCulture_FunctionAddress, "CultureName");
		SetCurrentCulture_CultureName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentCulture_FunctionAddress, "CultureName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentCulture_ReturnValue_PropertyAddress, SetCurrentCulture_FunctionAddress, "ReturnValue");
		SetCurrentCulture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentCulture_FunctionAddress, "ReturnValue");
		SetCurrentCulture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentCulture_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurrentCulture_IsValid = SetCurrentCulture_FunctionAddress != IntPtr.Zero && SetCurrentCulture_CultureName_IsValid && SetCurrentCulture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:SetCurrentCulture", SetCurrentCulture_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:SetColorVisionDeficiencyType", SetColorVisionDeficiencyType_IsValid);
		RemoveUserWidgetAsSlateFromViewport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveUserWidgetAsSlateFromViewport");
		RemoveUserWidgetAsSlateFromViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveUserWidgetAsSlateFromViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveUserWidgetAsSlateFromViewport_Widget_PropertyAddress, RemoveUserWidgetAsSlateFromViewport_FunctionAddress, "Widget");
		RemoveUserWidgetAsSlateFromViewport_Widget_Offset = NativeReflectionCached.GetPropertyOffset(RemoveUserWidgetAsSlateFromViewport_FunctionAddress, "Widget");
		RemoveUserWidgetAsSlateFromViewport_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveUserWidgetAsSlateFromViewport_FunctionAddress, "Widget", Classes.FObjectProperty);
		RemoveUserWidgetAsSlateFromViewport_IsValid = RemoveUserWidgetAsSlateFromViewport_FunctionAddress != IntPtr.Zero && RemoveUserWidgetAsSlateFromViewport_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:RemoveUserWidgetAsSlateFromViewport", RemoveUserWidgetAsSlateFromViewport_IsValid);
		RefreshRichTextDefaultStyle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RefreshRichTextDefaultStyle");
		RefreshRichTextDefaultStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshRichTextDefaultStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RefreshRichTextDefaultStyle_RichTextBlock_PropertyAddress, RefreshRichTextDefaultStyle_FunctionAddress, "RichTextBlock");
		RefreshRichTextDefaultStyle_RichTextBlock_Offset = NativeReflectionCached.GetPropertyOffset(RefreshRichTextDefaultStyle_FunctionAddress, "RichTextBlock");
		RefreshRichTextDefaultStyle_RichTextBlock_IsValid = NativeReflectionCached.ValidatePropertyClass(RefreshRichTextDefaultStyle_FunctionAddress, "RichTextBlock", Classes.FObjectProperty);
		RefreshRichTextDefaultStyle_IsValid = RefreshRichTextDefaultStyle_FunctionAddress != IntPtr.Zero && RefreshRichTextDefaultStyle_RichTextBlock_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:RefreshRichTextDefaultStyle", RefreshRichTextDefaultStyle_IsValid);
		RefreshDPIScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RefreshDPIScale");
		RefreshDPIScale_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshDPIScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RefreshDPIScale_WorldContext_PropertyAddress, RefreshDPIScale_FunctionAddress, "WorldContext");
		RefreshDPIScale_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(RefreshDPIScale_FunctionAddress, "WorldContext");
		RefreshDPIScale_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(RefreshDPIScale_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		RefreshDPIScale_IsValid = RefreshDPIScale_FunctionAddress != IntPtr.Zero && RefreshDPIScale_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:RefreshDPIScale", RefreshDPIScale_IsValid);
		QAGetWidgetWithText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QAGetWidgetWithText");
		QAGetWidgetWithText_ParamsSize = NativeReflection.GetFunctionParamsSize(QAGetWidgetWithText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QAGetWidgetWithText_WorldContextObject_PropertyAddress, QAGetWidgetWithText_FunctionAddress, "WorldContextObject");
		QAGetWidgetWithText_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(QAGetWidgetWithText_FunctionAddress, "WorldContextObject");
		QAGetWidgetWithText_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(QAGetWidgetWithText_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref QAGetWidgetWithText_FoundWidgets_PropertyAddress, QAGetWidgetWithText_FunctionAddress, "FoundWidgets");
		QAGetWidgetWithText_FoundWidgets_Offset = NativeReflectionCached.GetPropertyOffset(QAGetWidgetWithText_FunctionAddress, "FoundWidgets");
		QAGetWidgetWithText_FoundWidgets_IsValid = NativeReflectionCached.ValidatePropertyClass(QAGetWidgetWithText_FunctionAddress, "FoundWidgets", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref QAGetWidgetWithText_Text_PropertyAddress, QAGetWidgetWithText_FunctionAddress, "Text");
		QAGetWidgetWithText_Text_Offset = NativeReflectionCached.GetPropertyOffset(QAGetWidgetWithText_FunctionAddress, "Text");
		QAGetWidgetWithText_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(QAGetWidgetWithText_FunctionAddress, "Text", Classes.FStrProperty);
		QAGetWidgetWithText_IsValid = QAGetWidgetWithText_FunctionAddress != IntPtr.Zero && QAGetWidgetWithText_WorldContextObject_IsValid && QAGetWidgetWithText_FoundWidgets_IsValid && QAGetWidgetWithText_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:QAGetWidgetWithText", QAGetWidgetWithText_IsValid);
		QAGetWidgetCenterPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QAGetWidgetCenterPosition");
		QAGetWidgetCenterPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(QAGetWidgetCenterPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QAGetWidgetCenterPosition_widget_PropertyAddress, QAGetWidgetCenterPosition_FunctionAddress, "widget");
		QAGetWidgetCenterPosition_widget_Offset = NativeReflectionCached.GetPropertyOffset(QAGetWidgetCenterPosition_FunctionAddress, "widget");
		QAGetWidgetCenterPosition_widget_IsValid = NativeReflectionCached.ValidatePropertyClass(QAGetWidgetCenterPosition_FunctionAddress, "widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref QAGetWidgetCenterPosition_WidgetPosition_PropertyAddress, QAGetWidgetCenterPosition_FunctionAddress, "WidgetPosition");
		QAGetWidgetCenterPosition_WidgetPosition_Offset = NativeReflectionCached.GetPropertyOffset(QAGetWidgetCenterPosition_FunctionAddress, "WidgetPosition");
		QAGetWidgetCenterPosition_WidgetPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(QAGetWidgetCenterPosition_FunctionAddress, "WidgetPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref QAGetWidgetCenterPosition_CenterPosition_PropertyAddress, QAGetWidgetCenterPosition_FunctionAddress, "CenterPosition");
		QAGetWidgetCenterPosition_CenterPosition_Offset = NativeReflectionCached.GetPropertyOffset(QAGetWidgetCenterPosition_FunctionAddress, "CenterPosition");
		QAGetWidgetCenterPosition_CenterPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(QAGetWidgetCenterPosition_FunctionAddress, "CenterPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref QAGetWidgetCenterPosition_WidgetSize_PropertyAddress, QAGetWidgetCenterPosition_FunctionAddress, "WidgetSize");
		QAGetWidgetCenterPosition_WidgetSize_Offset = NativeReflectionCached.GetPropertyOffset(QAGetWidgetCenterPosition_FunctionAddress, "WidgetSize");
		QAGetWidgetCenterPosition_WidgetSize_IsValid = NativeReflectionCached.ValidatePropertyClass(QAGetWidgetCenterPosition_FunctionAddress, "WidgetSize", Classes.FStructProperty);
		QAGetWidgetCenterPosition_IsValid = QAGetWidgetCenterPosition_FunctionAddress != IntPtr.Zero && QAGetWidgetCenterPosition_widget_IsValid && QAGetWidgetCenterPosition_WidgetPosition_IsValid && QAGetWidgetCenterPosition_CenterPosition_IsValid && QAGetWidgetCenterPosition_WidgetSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:QAGetWidgetCenterPosition", QAGetWidgetCenterPosition_IsValid);
		QAGetAllWidgetsOfClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QAGetAllWidgetsOfClass");
		QAGetAllWidgetsOfClass_ParamsSize = NativeReflection.GetFunctionParamsSize(QAGetAllWidgetsOfClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QAGetAllWidgetsOfClass_WorldContextObject_PropertyAddress, QAGetAllWidgetsOfClass_FunctionAddress, "WorldContextObject");
		QAGetAllWidgetsOfClass_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(QAGetAllWidgetsOfClass_FunctionAddress, "WorldContextObject");
		QAGetAllWidgetsOfClass_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(QAGetAllWidgetsOfClass_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref QAGetAllWidgetsOfClass_FoundWidgets_PropertyAddress, QAGetAllWidgetsOfClass_FunctionAddress, "FoundWidgets");
		QAGetAllWidgetsOfClass_FoundWidgets_Offset = NativeReflectionCached.GetPropertyOffset(QAGetAllWidgetsOfClass_FunctionAddress, "FoundWidgets");
		QAGetAllWidgetsOfClass_FoundWidgets_IsValid = NativeReflectionCached.ValidatePropertyClass(QAGetAllWidgetsOfClass_FunctionAddress, "FoundWidgets", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref QAGetAllWidgetsOfClass_WidgetClass_PropertyAddress, QAGetAllWidgetsOfClass_FunctionAddress, "WidgetClass");
		QAGetAllWidgetsOfClass_WidgetClass_Offset = NativeReflectionCached.GetPropertyOffset(QAGetAllWidgetsOfClass_FunctionAddress, "WidgetClass");
		QAGetAllWidgetsOfClass_WidgetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(QAGetAllWidgetsOfClass_FunctionAddress, "WidgetClass", Classes.FClassProperty);
		QAGetAllWidgetsOfClass_IsValid = QAGetAllWidgetsOfClass_FunctionAddress != IntPtr.Zero && QAGetAllWidgetsOfClass_WorldContextObject_IsValid && QAGetAllWidgetsOfClass_FoundWidgets_IsValid && QAGetAllWidgetsOfClass_WidgetClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:QAGetAllWidgetsOfClass", QAGetAllWidgetsOfClass_IsValid);
		PointerEvent_IsTouchFirstMove_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_IsTouchFirstMove");
		PointerEvent_IsTouchFirstMove_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_IsTouchFirstMove_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_IsTouchFirstMove_PointerEvent_PropertyAddress, PointerEvent_IsTouchFirstMove_FunctionAddress, "PointerEvent");
		PointerEvent_IsTouchFirstMove_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_IsTouchFirstMove_FunctionAddress, "PointerEvent");
		PointerEvent_IsTouchFirstMove_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_IsTouchFirstMove_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_IsTouchFirstMove_ReturnValue_PropertyAddress, PointerEvent_IsTouchFirstMove_FunctionAddress, "ReturnValue");
		PointerEvent_IsTouchFirstMove_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_IsTouchFirstMove_FunctionAddress, "ReturnValue");
		PointerEvent_IsTouchFirstMove_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_IsTouchFirstMove_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PointerEvent_IsTouchFirstMove_IsValid = PointerEvent_IsTouchFirstMove_FunctionAddress != IntPtr.Zero && PointerEvent_IsTouchFirstMove_PointerEvent_IsValid && PointerEvent_IsTouchFirstMove_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_IsTouchFirstMove", PointerEvent_IsTouchFirstMove_IsValid);
		PointerEvent_IsMouseTouchEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_IsMouseTouchEvent");
		PointerEvent_IsMouseTouchEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_IsMouseTouchEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_IsMouseTouchEvent_PointerEvent_PropertyAddress, PointerEvent_IsMouseTouchEvent_FunctionAddress, "PointerEvent");
		PointerEvent_IsMouseTouchEvent_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_IsMouseTouchEvent_FunctionAddress, "PointerEvent");
		PointerEvent_IsMouseTouchEvent_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_IsMouseTouchEvent_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_IsMouseTouchEvent_ReturnValue_PropertyAddress, PointerEvent_IsMouseTouchEvent_FunctionAddress, "ReturnValue");
		PointerEvent_IsMouseTouchEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_IsMouseTouchEvent_FunctionAddress, "ReturnValue");
		PointerEvent_IsMouseTouchEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_IsMouseTouchEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PointerEvent_IsMouseTouchEvent_IsValid = PointerEvent_IsMouseTouchEvent_FunctionAddress != IntPtr.Zero && PointerEvent_IsMouseTouchEvent_PointerEvent_IsValid && PointerEvent_IsMouseTouchEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_IsMouseTouchEvent", PointerEvent_IsMouseTouchEvent_IsValid);
		PointerEvent_IsMouseButtonDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_IsMouseButtonDown");
		PointerEvent_IsMouseButtonDown_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_IsMouseButtonDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_IsMouseButtonDown_PointerEvent_PropertyAddress, PointerEvent_IsMouseButtonDown_FunctionAddress, "PointerEvent");
		PointerEvent_IsMouseButtonDown_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_IsMouseButtonDown_FunctionAddress, "PointerEvent");
		PointerEvent_IsMouseButtonDown_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_IsMouseButtonDown_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_IsMouseButtonDown_MouseButtonName_PropertyAddress, PointerEvent_IsMouseButtonDown_FunctionAddress, "MouseButtonName");
		PointerEvent_IsMouseButtonDown_MouseButtonName_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_IsMouseButtonDown_FunctionAddress, "MouseButtonName");
		PointerEvent_IsMouseButtonDown_MouseButtonName_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_IsMouseButtonDown_FunctionAddress, "MouseButtonName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_IsMouseButtonDown_ReturnValue_PropertyAddress, PointerEvent_IsMouseButtonDown_FunctionAddress, "ReturnValue");
		PointerEvent_IsMouseButtonDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_IsMouseButtonDown_FunctionAddress, "ReturnValue");
		PointerEvent_IsMouseButtonDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_IsMouseButtonDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PointerEvent_IsMouseButtonDown_IsValid = PointerEvent_IsMouseButtonDown_FunctionAddress != IntPtr.Zero && PointerEvent_IsMouseButtonDown_PointerEvent_IsValid && PointerEvent_IsMouseButtonDown_MouseButtonName_IsValid && PointerEvent_IsMouseButtonDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_IsMouseButtonDown", PointerEvent_IsMouseButtonDown_IsValid);
		PointerEvent_GetScreenSpacePosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_GetScreenSpacePosition");
		PointerEvent_GetScreenSpacePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_GetScreenSpacePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetScreenSpacePosition_PointerEvent_PropertyAddress, PointerEvent_GetScreenSpacePosition_FunctionAddress, "PointerEvent");
		PointerEvent_GetScreenSpacePosition_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetScreenSpacePosition_FunctionAddress, "PointerEvent");
		PointerEvent_GetScreenSpacePosition_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetScreenSpacePosition_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetScreenSpacePosition_ReturnValue_PropertyAddress, PointerEvent_GetScreenSpacePosition_FunctionAddress, "ReturnValue");
		PointerEvent_GetScreenSpacePosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetScreenSpacePosition_FunctionAddress, "ReturnValue");
		PointerEvent_GetScreenSpacePosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetScreenSpacePosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		PointerEvent_GetScreenSpacePosition_IsValid = PointerEvent_GetScreenSpacePosition_FunctionAddress != IntPtr.Zero && PointerEvent_GetScreenSpacePosition_PointerEvent_IsValid && PointerEvent_GetScreenSpacePosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_GetScreenSpacePosition", PointerEvent_GetScreenSpacePosition_IsValid);
		PointerEvent_GetPositionInGeometry_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_GetPositionInGeometry");
		PointerEvent_GetPositionInGeometry_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_GetPositionInGeometry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetPositionInGeometry_Geometry_PropertyAddress, PointerEvent_GetPositionInGeometry_FunctionAddress, "Geometry");
		PointerEvent_GetPositionInGeometry_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetPositionInGeometry_FunctionAddress, "Geometry");
		PointerEvent_GetPositionInGeometry_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetPositionInGeometry_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetPositionInGeometry_PointerEvent_PropertyAddress, PointerEvent_GetPositionInGeometry_FunctionAddress, "PointerEvent");
		PointerEvent_GetPositionInGeometry_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetPositionInGeometry_FunctionAddress, "PointerEvent");
		PointerEvent_GetPositionInGeometry_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetPositionInGeometry_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetPositionInGeometry_ReturnValue_PropertyAddress, PointerEvent_GetPositionInGeometry_FunctionAddress, "ReturnValue");
		PointerEvent_GetPositionInGeometry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetPositionInGeometry_FunctionAddress, "ReturnValue");
		PointerEvent_GetPositionInGeometry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetPositionInGeometry_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		PointerEvent_GetPositionInGeometry_IsValid = PointerEvent_GetPositionInGeometry_FunctionAddress != IntPtr.Zero && PointerEvent_GetPositionInGeometry_Geometry_IsValid && PointerEvent_GetPositionInGeometry_PointerEvent_IsValid && PointerEvent_GetPositionInGeometry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_GetPositionInGeometry", PointerEvent_GetPositionInGeometry_IsValid);
		PointerEvent_GetPointerIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PointerEvent_GetPointerIndex");
		PointerEvent_GetPointerIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(PointerEvent_GetPointerIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetPointerIndex_PointerEvent_PropertyAddress, PointerEvent_GetPointerIndex_FunctionAddress, "PointerEvent");
		PointerEvent_GetPointerIndex_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetPointerIndex_FunctionAddress, "PointerEvent");
		PointerEvent_GetPointerIndex_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetPointerIndex_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointerEvent_GetPointerIndex_ReturnValue_PropertyAddress, PointerEvent_GetPointerIndex_FunctionAddress, "ReturnValue");
		PointerEvent_GetPointerIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointerEvent_GetPointerIndex_FunctionAddress, "ReturnValue");
		PointerEvent_GetPointerIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointerEvent_GetPointerIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PointerEvent_GetPointerIndex_IsValid = PointerEvent_GetPointerIndex_FunctionAddress != IntPtr.Zero && PointerEvent_GetPointerIndex_PointerEvent_IsValid && PointerEvent_GetPointerIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:PointerEvent_GetPointerIndex", PointerEvent_GetPointerIndex_IsValid);
		NewLocalStringTable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NewLocalStringTable");
		NewLocalStringTable_ParamsSize = NativeReflection.GetFunctionParamsSize(NewLocalStringTable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NewLocalStringTable_ID_PropertyAddress, NewLocalStringTable_FunctionAddress, "ID");
		NewLocalStringTable_ID_Offset = NativeReflectionCached.GetPropertyOffset(NewLocalStringTable_FunctionAddress, "ID");
		NewLocalStringTable_ID_IsValid = NativeReflectionCached.ValidatePropertyClass(NewLocalStringTable_FunctionAddress, "ID", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref NewLocalStringTable_NameSpace_PropertyAddress, NewLocalStringTable_FunctionAddress, "NameSpace");
		NewLocalStringTable_NameSpace_Offset = NativeReflectionCached.GetPropertyOffset(NewLocalStringTable_FunctionAddress, "NameSpace");
		NewLocalStringTable_NameSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(NewLocalStringTable_FunctionAddress, "NameSpace", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NewLocalStringTable_ReturnValue_PropertyAddress, NewLocalStringTable_FunctionAddress, "ReturnValue");
		NewLocalStringTable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NewLocalStringTable_FunctionAddress, "ReturnValue");
		NewLocalStringTable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NewLocalStringTable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NewLocalStringTable_IsValid = NewLocalStringTable_FunctionAddress != IntPtr.Zero && NewLocalStringTable_ID_IsValid && NewLocalStringTable_NameSpace_IsValid && NewLocalStringTable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:NewLocalStringTable", NewLocalStringTable_IsValid);
		NeedExecuteActionWithDA_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NeedExecuteActionWithDA");
		NeedExecuteActionWithDA_ParamsSize = NativeReflection.GetFunctionParamsSize(NeedExecuteActionWithDA_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NeedExecuteActionWithDA_MyGeometry_PropertyAddress, NeedExecuteActionWithDA_FunctionAddress, "MyGeometry");
		NeedExecuteActionWithDA_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(NeedExecuteActionWithDA_FunctionAddress, "MyGeometry");
		NeedExecuteActionWithDA_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(NeedExecuteActionWithDA_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NeedExecuteActionWithDA_MouseEvent_PropertyAddress, NeedExecuteActionWithDA_FunctionAddress, "MouseEvent");
		NeedExecuteActionWithDA_MouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(NeedExecuteActionWithDA_FunctionAddress, "MouseEvent");
		NeedExecuteActionWithDA_MouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(NeedExecuteActionWithDA_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NeedExecuteActionWithDA_HitAreaDA_PropertyAddress, NeedExecuteActionWithDA_FunctionAddress, "HitAreaDA");
		NeedExecuteActionWithDA_HitAreaDA_Offset = NativeReflectionCached.GetPropertyOffset(NeedExecuteActionWithDA_FunctionAddress, "HitAreaDA");
		NeedExecuteActionWithDA_HitAreaDA_IsValid = NativeReflectionCached.ValidatePropertyClass(NeedExecuteActionWithDA_FunctionAddress, "HitAreaDA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NeedExecuteActionWithDA_AdvancedHitAlpha_PropertyAddress, NeedExecuteActionWithDA_FunctionAddress, "AdvancedHitAlpha");
		NeedExecuteActionWithDA_AdvancedHitAlpha_Offset = NativeReflectionCached.GetPropertyOffset(NeedExecuteActionWithDA_FunctionAddress, "AdvancedHitAlpha");
		NeedExecuteActionWithDA_AdvancedHitAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(NeedExecuteActionWithDA_FunctionAddress, "AdvancedHitAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref NeedExecuteActionWithDA_ReturnValue_PropertyAddress, NeedExecuteActionWithDA_FunctionAddress, "ReturnValue");
		NeedExecuteActionWithDA_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NeedExecuteActionWithDA_FunctionAddress, "ReturnValue");
		NeedExecuteActionWithDA_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NeedExecuteActionWithDA_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NeedExecuteActionWithDA_IsValid = NeedExecuteActionWithDA_FunctionAddress != IntPtr.Zero && NeedExecuteActionWithDA_MyGeometry_IsValid && NeedExecuteActionWithDA_MouseEvent_IsValid && NeedExecuteActionWithDA_HitAreaDA_IsValid && NeedExecuteActionWithDA_AdvancedHitAlpha_IsValid && NeedExecuteActionWithDA_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:NeedExecuteActionWithDA", NeedExecuteActionWithDA_IsValid);
		NeedExecuteAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NeedExecuteAction");
		NeedExecuteAction_ParamsSize = NativeReflection.GetFunctionParamsSize(NeedExecuteAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NeedExecuteAction_MyGeometry_PropertyAddress, NeedExecuteAction_FunctionAddress, "MyGeometry");
		NeedExecuteAction_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(NeedExecuteAction_FunctionAddress, "MyGeometry");
		NeedExecuteAction_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(NeedExecuteAction_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NeedExecuteAction_MouseEvent_PropertyAddress, NeedExecuteAction_FunctionAddress, "MouseEvent");
		NeedExecuteAction_MouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(NeedExecuteAction_FunctionAddress, "MouseEvent");
		NeedExecuteAction_MouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(NeedExecuteAction_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NeedExecuteAction_AdvancedHitTexture_PropertyAddress, NeedExecuteAction_FunctionAddress, "AdvancedHitTexture");
		NeedExecuteAction_AdvancedHitTexture_Offset = NativeReflectionCached.GetPropertyOffset(NeedExecuteAction_FunctionAddress, "AdvancedHitTexture");
		NeedExecuteAction_AdvancedHitTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(NeedExecuteAction_FunctionAddress, "AdvancedHitTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NeedExecuteAction_AdvancedHitAlpha_PropertyAddress, NeedExecuteAction_FunctionAddress, "AdvancedHitAlpha");
		NeedExecuteAction_AdvancedHitAlpha_Offset = NativeReflectionCached.GetPropertyOffset(NeedExecuteAction_FunctionAddress, "AdvancedHitAlpha");
		NeedExecuteAction_AdvancedHitAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(NeedExecuteAction_FunctionAddress, "AdvancedHitAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref NeedExecuteAction_ReturnValue_PropertyAddress, NeedExecuteAction_FunctionAddress, "ReturnValue");
		NeedExecuteAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NeedExecuteAction_FunctionAddress, "ReturnValue");
		NeedExecuteAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NeedExecuteAction_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NeedExecuteAction_IsValid = NeedExecuteAction_FunctionAddress != IntPtr.Zero && NeedExecuteAction_MyGeometry_IsValid && NeedExecuteAction_MouseEvent_IsValid && NeedExecuteAction_AdvancedHitTexture_IsValid && NeedExecuteAction_AdvancedHitAlpha_IsValid && NeedExecuteAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:NeedExecuteAction", NeedExecuteAction_IsValid);
		MakeEventReply_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeEventReply");
		MakeEventReply_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeEventReply_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeEventReply_IsHandled_PropertyAddress, MakeEventReply_FunctionAddress, "IsHandled");
		MakeEventReply_IsHandled_Offset = NativeReflectionCached.GetPropertyOffset(MakeEventReply_FunctionAddress, "IsHandled");
		MakeEventReply_IsHandled_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeEventReply_FunctionAddress, "IsHandled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeEventReply_ReturnValue_PropertyAddress, MakeEventReply_FunctionAddress, "ReturnValue");
		MakeEventReply_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeEventReply_FunctionAddress, "ReturnValue");
		MakeEventReply_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeEventReply_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeEventReply_IsValid = MakeEventReply_FunctionAddress != IntPtr.Zero && MakeEventReply_IsHandled_IsValid && MakeEventReply_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:MakeEventReply", MakeEventReply_IsValid);
		LogHittestGrid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LogHittestGrid");
		LogHittestGrid_ParamsSize = NativeReflection.GetFunctionParamsSize(LogHittestGrid_FunctionAddress);
		LogHittestGrid_IsValid = LogHittestGrid_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:LogHittestGrid", LogHittestGrid_IsValid);
		LocalToViewPortPos_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LocalToViewPortPos");
		LocalToViewPortPos_ParamsSize = NativeReflection.GetFunctionParamsSize(LocalToViewPortPos_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LocalToViewPortPos_WorldContextObject_PropertyAddress, LocalToViewPortPos_FunctionAddress, "WorldContextObject");
		LocalToViewPortPos_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LocalToViewPortPos_FunctionAddress, "WorldContextObject");
		LocalToViewPortPos_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalToViewPortPos_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalToViewPortPos_Geometry_PropertyAddress, LocalToViewPortPos_FunctionAddress, "Geometry");
		LocalToViewPortPos_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(LocalToViewPortPos_FunctionAddress, "Geometry");
		LocalToViewPortPos_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalToViewPortPos_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalToViewPortPos_ReturnValue_PropertyAddress, LocalToViewPortPos_FunctionAddress, "ReturnValue");
		LocalToViewPortPos_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LocalToViewPortPos_FunctionAddress, "ReturnValue");
		LocalToViewPortPos_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalToViewPortPos_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		LocalToViewPortPos_IsValid = LocalToViewPortPos_FunctionAddress != IntPtr.Zero && LocalToViewPortPos_WorldContextObject_IsValid && LocalToViewPortPos_Geometry_IsValid && LocalToViewPortPos_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:LocalToViewPortPos", LocalToViewPortPos_IsValid);
		LocalToViewPortPixelPos_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LocalToViewPortPixelPos");
		LocalToViewPortPixelPos_ParamsSize = NativeReflection.GetFunctionParamsSize(LocalToViewPortPixelPos_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LocalToViewPortPixelPos_WorldContextObject_PropertyAddress, LocalToViewPortPixelPos_FunctionAddress, "WorldContextObject");
		LocalToViewPortPixelPos_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(LocalToViewPortPixelPos_FunctionAddress, "WorldContextObject");
		LocalToViewPortPixelPos_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalToViewPortPixelPos_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalToViewPortPixelPos_Geometry_PropertyAddress, LocalToViewPortPixelPos_FunctionAddress, "Geometry");
		LocalToViewPortPixelPos_Geometry_Offset = NativeReflectionCached.GetPropertyOffset(LocalToViewPortPixelPos_FunctionAddress, "Geometry");
		LocalToViewPortPixelPos_Geometry_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalToViewPortPixelPos_FunctionAddress, "Geometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalToViewPortPixelPos_ReturnValue_PropertyAddress, LocalToViewPortPixelPos_FunctionAddress, "ReturnValue");
		LocalToViewPortPixelPos_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LocalToViewPortPixelPos_FunctionAddress, "ReturnValue");
		LocalToViewPortPixelPos_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalToViewPortPixelPos_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		LocalToViewPortPixelPos_IsValid = LocalToViewPortPixelPos_FunctionAddress != IntPtr.Zero && LocalToViewPortPixelPos_WorldContextObject_IsValid && LocalToViewPortPixelPos_Geometry_IsValid && LocalToViewPortPixelPos_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:LocalToViewPortPixelPos", LocalToViewPortPixelPos_IsValid);
		LoadTexture2DToAreaIDArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadTexture2DToAreaIDArray");
		LoadTexture2DToAreaIDArray_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadTexture2DToAreaIDArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadTexture2DToAreaIDArray_TargetTexture_PropertyAddress, LoadTexture2DToAreaIDArray_FunctionAddress, "TargetTexture");
		LoadTexture2DToAreaIDArray_TargetTexture_Offset = NativeReflectionCached.GetPropertyOffset(LoadTexture2DToAreaIDArray_FunctionAddress, "TargetTexture");
		LoadTexture2DToAreaIDArray_TargetTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadTexture2DToAreaIDArray_FunctionAddress, "TargetTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadTexture2DToAreaIDArray_AreaColorIDMap_PropertyAddress, LoadTexture2DToAreaIDArray_FunctionAddress, "AreaColorIDMap");
		LoadTexture2DToAreaIDArray_AreaColorIDMap_Offset = NativeReflectionCached.GetPropertyOffset(LoadTexture2DToAreaIDArray_FunctionAddress, "AreaColorIDMap");
		LoadTexture2DToAreaIDArray_AreaColorIDMap_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadTexture2DToAreaIDArray_FunctionAddress, "AreaColorIDMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadTexture2DToAreaIDArray_AreaData_PropertyAddress, LoadTexture2DToAreaIDArray_FunctionAddress, "AreaData");
		LoadTexture2DToAreaIDArray_AreaData_Offset = NativeReflectionCached.GetPropertyOffset(LoadTexture2DToAreaIDArray_FunctionAddress, "AreaData");
		LoadTexture2DToAreaIDArray_AreaData_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadTexture2DToAreaIDArray_FunctionAddress, "AreaData", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadTexture2DToAreaIDArray_OutOriginPos_PropertyAddress, LoadTexture2DToAreaIDArray_FunctionAddress, "OutOriginPos");
		LoadTexture2DToAreaIDArray_OutOriginPos_Offset = NativeReflectionCached.GetPropertyOffset(LoadTexture2DToAreaIDArray_FunctionAddress, "OutOriginPos");
		LoadTexture2DToAreaIDArray_OutOriginPos_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadTexture2DToAreaIDArray_FunctionAddress, "OutOriginPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadTexture2DToAreaIDArray_OutMapSize_PropertyAddress, LoadTexture2DToAreaIDArray_FunctionAddress, "OutMapSize");
		LoadTexture2DToAreaIDArray_OutMapSize_Offset = NativeReflectionCached.GetPropertyOffset(LoadTexture2DToAreaIDArray_FunctionAddress, "OutMapSize");
		LoadTexture2DToAreaIDArray_OutMapSize_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadTexture2DToAreaIDArray_FunctionAddress, "OutMapSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadTexture2DToAreaIDArray_ErrMsg_PropertyAddress, LoadTexture2DToAreaIDArray_FunctionAddress, "ErrMsg");
		LoadTexture2DToAreaIDArray_ErrMsg_Offset = NativeReflectionCached.GetPropertyOffset(LoadTexture2DToAreaIDArray_FunctionAddress, "ErrMsg");
		LoadTexture2DToAreaIDArray_ErrMsg_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadTexture2DToAreaIDArray_FunctionAddress, "ErrMsg", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadTexture2DToAreaIDArray_ReturnValue_PropertyAddress, LoadTexture2DToAreaIDArray_FunctionAddress, "ReturnValue");
		LoadTexture2DToAreaIDArray_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadTexture2DToAreaIDArray_FunctionAddress, "ReturnValue");
		LoadTexture2DToAreaIDArray_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadTexture2DToAreaIDArray_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		LoadTexture2DToAreaIDArray_IsValid = LoadTexture2DToAreaIDArray_FunctionAddress != IntPtr.Zero && LoadTexture2DToAreaIDArray_TargetTexture_IsValid && LoadTexture2DToAreaIDArray_AreaColorIDMap_IsValid && LoadTexture2DToAreaIDArray_AreaData_IsValid && LoadTexture2DToAreaIDArray_OutOriginPos_IsValid && LoadTexture2DToAreaIDArray_OutMapSize_IsValid && LoadTexture2DToAreaIDArray_ErrMsg_IsValid && LoadTexture2DToAreaIDArray_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:LoadTexture2DToAreaIDArray", LoadTexture2DToAreaIDArray_IsValid);
		IsWidgetVisiableWithParentInList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsWidgetVisiableWithParentInList");
		IsWidgetVisiableWithParentInList_ParamsSize = NativeReflection.GetFunctionParamsSize(IsWidgetVisiableWithParentInList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsWidgetVisiableWithParentInList_InWidgetList_PropertyAddress, IsWidgetVisiableWithParentInList_FunctionAddress, "InWidgetList");
		IsWidgetVisiableWithParentInList_InWidgetList_Offset = NativeReflectionCached.GetPropertyOffset(IsWidgetVisiableWithParentInList_FunctionAddress, "InWidgetList");
		IsWidgetVisiableWithParentInList_InWidgetList_IsValid = NativeReflectionCached.ValidatePropertyClass(IsWidgetVisiableWithParentInList_FunctionAddress, "InWidgetList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsWidgetVisiableWithParentInList_OutWidgetList_PropertyAddress, IsWidgetVisiableWithParentInList_FunctionAddress, "OutWidgetList");
		IsWidgetVisiableWithParentInList_OutWidgetList_Offset = NativeReflectionCached.GetPropertyOffset(IsWidgetVisiableWithParentInList_FunctionAddress, "OutWidgetList");
		IsWidgetVisiableWithParentInList_OutWidgetList_IsValid = NativeReflectionCached.ValidatePropertyClass(IsWidgetVisiableWithParentInList_FunctionAddress, "OutWidgetList", Classes.FArrayProperty);
		IsWidgetVisiableWithParentInList_IsValid = IsWidgetVisiableWithParentInList_FunctionAddress != IntPtr.Zero && IsWidgetVisiableWithParentInList_InWidgetList_IsValid && IsWidgetVisiableWithParentInList_OutWidgetList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:IsWidgetVisiableWithParentInList", IsWidgetVisiableWithParentInList_IsValid);
		IsWidgetVisiableWithParent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsWidgetVisiableWithParent");
		IsWidgetVisiableWithParent_ParamsSize = NativeReflection.GetFunctionParamsSize(IsWidgetVisiableWithParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsWidgetVisiableWithParent_TargetWidget_PropertyAddress, IsWidgetVisiableWithParent_FunctionAddress, "TargetWidget");
		IsWidgetVisiableWithParent_TargetWidget_Offset = NativeReflectionCached.GetPropertyOffset(IsWidgetVisiableWithParent_FunctionAddress, "TargetWidget");
		IsWidgetVisiableWithParent_TargetWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(IsWidgetVisiableWithParent_FunctionAddress, "TargetWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsWidgetVisiableWithParent_ReturnValue_PropertyAddress, IsWidgetVisiableWithParent_FunctionAddress, "ReturnValue");
		IsWidgetVisiableWithParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsWidgetVisiableWithParent_FunctionAddress, "ReturnValue");
		IsWidgetVisiableWithParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsWidgetVisiableWithParent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsWidgetVisiableWithParent_IsValid = IsWidgetVisiableWithParent_FunctionAddress != IntPtr.Zero && IsWidgetVisiableWithParent_TargetWidget_IsValid && IsWidgetVisiableWithParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:IsWidgetVisiableWithParent", IsWidgetVisiableWithParent_IsValid);
		IsMediaBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsMediaBeginPlay");
		IsMediaBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMediaBeginPlay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMediaBeginPlay_MediaPlayer_PropertyAddress, IsMediaBeginPlay_FunctionAddress, "MediaPlayer");
		IsMediaBeginPlay_MediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(IsMediaBeginPlay_FunctionAddress, "MediaPlayer");
		IsMediaBeginPlay_MediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMediaBeginPlay_FunctionAddress, "MediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsMediaBeginPlay_ReturnValue_PropertyAddress, IsMediaBeginPlay_FunctionAddress, "ReturnValue");
		IsMediaBeginPlay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMediaBeginPlay_FunctionAddress, "ReturnValue");
		IsMediaBeginPlay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMediaBeginPlay_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMediaBeginPlay_IsValid = IsMediaBeginPlay_FunctionAddress != IntPtr.Zero && IsMediaBeginPlay_MediaPlayer_IsValid && IsMediaBeginPlay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:IsMediaBeginPlay", IsMediaBeginPlay_IsValid);
		IsBinkMediaBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsBinkMediaBeginPlay");
		IsBinkMediaBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(IsBinkMediaBeginPlay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsBinkMediaBeginPlay_BinkMediaPlayer_PropertyAddress, IsBinkMediaBeginPlay_FunctionAddress, "BinkMediaPlayer");
		IsBinkMediaBeginPlay_BinkMediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(IsBinkMediaBeginPlay_FunctionAddress, "BinkMediaPlayer");
		IsBinkMediaBeginPlay_BinkMediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBinkMediaBeginPlay_FunctionAddress, "BinkMediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsBinkMediaBeginPlay_ReturnValue_PropertyAddress, IsBinkMediaBeginPlay_FunctionAddress, "ReturnValue");
		IsBinkMediaBeginPlay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsBinkMediaBeginPlay_FunctionAddress, "ReturnValue");
		IsBinkMediaBeginPlay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBinkMediaBeginPlay_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsBinkMediaBeginPlay_IsValid = IsBinkMediaBeginPlay_FunctionAddress != IntPtr.Zero && IsBinkMediaBeginPlay_BinkMediaPlayer_IsValid && IsBinkMediaBeginPlay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:IsBinkMediaBeginPlay", IsBinkMediaBeginPlay_IsValid);
		InvokeWidgetInputEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InvokeWidgetInputEvent");
		InvokeWidgetInputEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(InvokeWidgetInputEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InvokeWidgetInputEvent_uWidget_PropertyAddress, InvokeWidgetInputEvent_FunctionAddress, "uWidget");
		InvokeWidgetInputEvent_uWidget_Offset = NativeReflectionCached.GetPropertyOffset(InvokeWidgetInputEvent_FunctionAddress, "uWidget");
		InvokeWidgetInputEvent_uWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(InvokeWidgetInputEvent_FunctionAddress, "uWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InvokeWidgetInputEvent_inputType_PropertyAddress, InvokeWidgetInputEvent_FunctionAddress, "inputType");
		InvokeWidgetInputEvent_inputType_Offset = NativeReflectionCached.GetPropertyOffset(InvokeWidgetInputEvent_FunctionAddress, "inputType");
		InvokeWidgetInputEvent_inputType_IsValid = NativeReflectionCached.ValidatePropertyClass(InvokeWidgetInputEvent_FunctionAddress, "inputType", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InvokeWidgetInputEvent_MyGeometry_PropertyAddress, InvokeWidgetInputEvent_FunctionAddress, "MyGeometry");
		InvokeWidgetInputEvent_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(InvokeWidgetInputEvent_FunctionAddress, "MyGeometry");
		InvokeWidgetInputEvent_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(InvokeWidgetInputEvent_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InvokeWidgetInputEvent_MouseEvent_PropertyAddress, InvokeWidgetInputEvent_FunctionAddress, "MouseEvent");
		InvokeWidgetInputEvent_MouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(InvokeWidgetInputEvent_FunctionAddress, "MouseEvent");
		InvokeWidgetInputEvent_MouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(InvokeWidgetInputEvent_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		InvokeWidgetInputEvent_IsValid = InvokeWidgetInputEvent_FunctionAddress != IntPtr.Zero && InvokeWidgetInputEvent_uWidget_IsValid && InvokeWidgetInputEvent_inputType_IsValid && InvokeWidgetInputEvent_MyGeometry_IsValid && InvokeWidgetInputEvent_MouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:InvokeWidgetInputEvent", InvokeWidgetInputEvent_IsValid);
		GSProjectWorldLocationToWidgetPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GSProjectWorldLocationToWidgetPosition");
		GSProjectWorldLocationToWidgetPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GSProjectWorldLocationToWidgetPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSProjectWorldLocationToWidgetPosition_PlayerController_PropertyAddress, GSProjectWorldLocationToWidgetPosition_FunctionAddress, "PlayerController");
		GSProjectWorldLocationToWidgetPosition_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GSProjectWorldLocationToWidgetPosition_FunctionAddress, "PlayerController");
		GSProjectWorldLocationToWidgetPosition_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GSProjectWorldLocationToWidgetPosition_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GSProjectWorldLocationToWidgetPosition_WorldLocation_PropertyAddress, GSProjectWorldLocationToWidgetPosition_FunctionAddress, "WorldLocation");
		GSProjectWorldLocationToWidgetPosition_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(GSProjectWorldLocationToWidgetPosition_FunctionAddress, "WorldLocation");
		GSProjectWorldLocationToWidgetPosition_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GSProjectWorldLocationToWidgetPosition_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSProjectWorldLocationToWidgetPosition_ViewportPosition_PropertyAddress, GSProjectWorldLocationToWidgetPosition_FunctionAddress, "ViewportPosition");
		GSProjectWorldLocationToWidgetPosition_ViewportPosition_Offset = NativeReflectionCached.GetPropertyOffset(GSProjectWorldLocationToWidgetPosition_FunctionAddress, "ViewportPosition");
		GSProjectWorldLocationToWidgetPosition_ViewportPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(GSProjectWorldLocationToWidgetPosition_FunctionAddress, "ViewportPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSProjectWorldLocationToWidgetPosition_bIsInFront_PropertyAddress, GSProjectWorldLocationToWidgetPosition_FunctionAddress, "bIsInFront");
		GSProjectWorldLocationToWidgetPosition_bIsInFront_Offset = NativeReflectionCached.GetPropertyOffset(GSProjectWorldLocationToWidgetPosition_FunctionAddress, "bIsInFront");
		GSProjectWorldLocationToWidgetPosition_bIsInFront_IsValid = NativeReflectionCached.ValidatePropertyClass(GSProjectWorldLocationToWidgetPosition_FunctionAddress, "bIsInFront", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GSProjectWorldLocationToWidgetPosition_ReturnValue_PropertyAddress, GSProjectWorldLocationToWidgetPosition_FunctionAddress, "ReturnValue");
		GSProjectWorldLocationToWidgetPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GSProjectWorldLocationToWidgetPosition_FunctionAddress, "ReturnValue");
		GSProjectWorldLocationToWidgetPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GSProjectWorldLocationToWidgetPosition_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GSProjectWorldLocationToWidgetPosition_IsValid = GSProjectWorldLocationToWidgetPosition_FunctionAddress != IntPtr.Zero && GSProjectWorldLocationToWidgetPosition_PlayerController_IsValid && GSProjectWorldLocationToWidgetPosition_WorldLocation_IsValid && GSProjectWorldLocationToWidgetPosition_ViewportPosition_IsValid && GSProjectWorldLocationToWidgetPosition_bIsInFront_IsValid && GSProjectWorldLocationToWidgetPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GSProjectWorldLocationToWidgetPosition", GSProjectWorldLocationToWidgetPosition_IsValid);
		GSProjectWidgetList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GSProjectWidgetList");
		GSProjectWidgetList_ParamsSize = NativeReflection.GetFunctionParamsSize(GSProjectWidgetList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSProjectWidgetList_PlayerController_PropertyAddress, GSProjectWidgetList_FunctionAddress, "PlayerController");
		GSProjectWidgetList_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GSProjectWidgetList_FunctionAddress, "PlayerController");
		GSProjectWidgetList_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GSProjectWidgetList_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GSProjectWidgetList_Canvas_PropertyAddress, GSProjectWidgetList_FunctionAddress, "Canvas");
		GSProjectWidgetList_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(GSProjectWidgetList_FunctionAddress, "Canvas");
		GSProjectWidgetList_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(GSProjectWidgetList_FunctionAddress, "Canvas", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GSProjectWidgetList_ProjWidgetInfos_PropertyAddress, GSProjectWidgetList_FunctionAddress, "ProjWidgetInfos");
		GSProjectWidgetList_ProjWidgetInfos_Offset = NativeReflectionCached.GetPropertyOffset(GSProjectWidgetList_FunctionAddress, "ProjWidgetInfos");
		GSProjectWidgetList_ProjWidgetInfos_IsValid = NativeReflectionCached.ValidatePropertyClass(GSProjectWidgetList_FunctionAddress, "ProjWidgetInfos", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GSProjectWidgetList_Results_PropertyAddress, GSProjectWidgetList_FunctionAddress, "Results");
		GSProjectWidgetList_Results_Offset = NativeReflectionCached.GetPropertyOffset(GSProjectWidgetList_FunctionAddress, "Results");
		GSProjectWidgetList_Results_IsValid = NativeReflectionCached.ValidatePropertyClass(GSProjectWidgetList_FunctionAddress, "Results", Classes.FArrayProperty);
		GSProjectWidgetList_IsValid = GSProjectWidgetList_FunctionAddress != IntPtr.Zero && GSProjectWidgetList_PlayerController_IsValid && GSProjectWidgetList_Canvas_IsValid && GSProjectWidgetList_ProjWidgetInfos_IsValid && GSProjectWidgetList_Results_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GSProjectWidgetList", GSProjectWidgetList_IsValid);
		GetWidgetPositionSizeRefViewPort_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWidgetPositionSizeRefViewPort");
		GetWidgetPositionSizeRefViewPort_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetPositionSizeRefViewPort_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetPositionSizeRefViewPort_widget_PropertyAddress, GetWidgetPositionSizeRefViewPort_FunctionAddress, "widget");
		GetWidgetPositionSizeRefViewPort_widget_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetPositionSizeRefViewPort_FunctionAddress, "widget");
		GetWidgetPositionSizeRefViewPort_widget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetPositionSizeRefViewPort_FunctionAddress, "widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetPositionSizeRefViewPort_Position_PropertyAddress, GetWidgetPositionSizeRefViewPort_FunctionAddress, "Position");
		GetWidgetPositionSizeRefViewPort_Position_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetPositionSizeRefViewPort_FunctionAddress, "Position");
		GetWidgetPositionSizeRefViewPort_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetPositionSizeRefViewPort_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetPositionSizeRefViewPort_WidgetSize_PropertyAddress, GetWidgetPositionSizeRefViewPort_FunctionAddress, "WidgetSize");
		GetWidgetPositionSizeRefViewPort_WidgetSize_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetPositionSizeRefViewPort_FunctionAddress, "WidgetSize");
		GetWidgetPositionSizeRefViewPort_WidgetSize_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetPositionSizeRefViewPort_FunctionAddress, "WidgetSize", Classes.FStructProperty);
		GetWidgetPositionSizeRefViewPort_IsValid = GetWidgetPositionSizeRefViewPort_FunctionAddress != IntPtr.Zero && GetWidgetPositionSizeRefViewPort_widget_IsValid && GetWidgetPositionSizeRefViewPort_Position_IsValid && GetWidgetPositionSizeRefViewPort_WidgetSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetPositionSizeRefViewPort", GetWidgetPositionSizeRefViewPort_IsValid);
		GetWidgetLocalSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWidgetLocalSize");
		GetWidgetLocalSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetLocalSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetLocalSize_widget_PropertyAddress, GetWidgetLocalSize_FunctionAddress, "widget");
		GetWidgetLocalSize_widget_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetLocalSize_FunctionAddress, "widget");
		GetWidgetLocalSize_widget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetLocalSize_FunctionAddress, "widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetLocalSize_ReturnValue_PropertyAddress, GetWidgetLocalSize_FunctionAddress, "ReturnValue");
		GetWidgetLocalSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetLocalSize_FunctionAddress, "ReturnValue");
		GetWidgetLocalSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetLocalSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWidgetLocalSize_IsValid = GetWidgetLocalSize_FunctionAddress != IntPtr.Zero && GetWidgetLocalSize_widget_IsValid && GetWidgetLocalSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetLocalSize", GetWidgetLocalSize_IsValid);
		GetWidgetLocalPositionAtCoordinatesWithPaintSpace_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWidgetLocalPositionAtCoordinatesWithPaintSpace");
		GetWidgetLocalPositionAtCoordinatesWithPaintSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetLocalPositionAtCoordinatesWithPaintSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetLocalPositionAtCoordinatesWithPaintSpace_widget_PropertyAddress, GetWidgetLocalPositionAtCoordinatesWithPaintSpace_FunctionAddress, "widget");
		GetWidgetLocalPositionAtCoordinatesWithPaintSpace_widget_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetLocalPositionAtCoordinatesWithPaintSpace_FunctionAddress, "widget");
		GetWidgetLocalPositionAtCoordinatesWithPaintSpace_widget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetLocalPositionAtCoordinatesWithPaintSpace_FunctionAddress, "widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetLocalPositionAtCoordinatesWithPaintSpace_NormalCoordinates_PropertyAddress, GetWidgetLocalPositionAtCoordinatesWithPaintSpace_FunctionAddress, "NormalCoordinates");
		GetWidgetLocalPositionAtCoordinatesWithPaintSpace_NormalCoordinates_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetLocalPositionAtCoordinatesWithPaintSpace_FunctionAddress, "NormalCoordinates");
		GetWidgetLocalPositionAtCoordinatesWithPaintSpace_NormalCoordinates_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetLocalPositionAtCoordinatesWithPaintSpace_FunctionAddress, "NormalCoordinates", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetLocalPositionAtCoordinatesWithPaintSpace_ReturnValue_PropertyAddress, GetWidgetLocalPositionAtCoordinatesWithPaintSpace_FunctionAddress, "ReturnValue");
		GetWidgetLocalPositionAtCoordinatesWithPaintSpace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetLocalPositionAtCoordinatesWithPaintSpace_FunctionAddress, "ReturnValue");
		GetWidgetLocalPositionAtCoordinatesWithPaintSpace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetLocalPositionAtCoordinatesWithPaintSpace_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWidgetLocalPositionAtCoordinatesWithPaintSpace_IsValid = GetWidgetLocalPositionAtCoordinatesWithPaintSpace_FunctionAddress != IntPtr.Zero && GetWidgetLocalPositionAtCoordinatesWithPaintSpace_widget_IsValid && GetWidgetLocalPositionAtCoordinatesWithPaintSpace_NormalCoordinates_IsValid && GetWidgetLocalPositionAtCoordinatesWithPaintSpace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetLocalPositionAtCoordinatesWithPaintSpace", GetWidgetLocalPositionAtCoordinatesWithPaintSpace_IsValid);
		GetWidgetLocalPositionAtCoordinates_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWidgetLocalPositionAtCoordinates");
		GetWidgetLocalPositionAtCoordinates_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetLocalPositionAtCoordinates_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetLocalPositionAtCoordinates_widget_PropertyAddress, GetWidgetLocalPositionAtCoordinates_FunctionAddress, "widget");
		GetWidgetLocalPositionAtCoordinates_widget_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetLocalPositionAtCoordinates_FunctionAddress, "widget");
		GetWidgetLocalPositionAtCoordinates_widget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetLocalPositionAtCoordinates_FunctionAddress, "widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetLocalPositionAtCoordinates_NormalCoordinates_PropertyAddress, GetWidgetLocalPositionAtCoordinates_FunctionAddress, "NormalCoordinates");
		GetWidgetLocalPositionAtCoordinates_NormalCoordinates_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetLocalPositionAtCoordinates_FunctionAddress, "NormalCoordinates");
		GetWidgetLocalPositionAtCoordinates_NormalCoordinates_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetLocalPositionAtCoordinates_FunctionAddress, "NormalCoordinates", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetLocalPositionAtCoordinates_ReturnValue_PropertyAddress, GetWidgetLocalPositionAtCoordinates_FunctionAddress, "ReturnValue");
		GetWidgetLocalPositionAtCoordinates_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetLocalPositionAtCoordinates_FunctionAddress, "ReturnValue");
		GetWidgetLocalPositionAtCoordinates_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetLocalPositionAtCoordinates_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWidgetLocalPositionAtCoordinates_IsValid = GetWidgetLocalPositionAtCoordinates_FunctionAddress != IntPtr.Zero && GetWidgetLocalPositionAtCoordinates_widget_IsValid && GetWidgetLocalPositionAtCoordinates_NormalCoordinates_IsValid && GetWidgetLocalPositionAtCoordinates_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetLocalPositionAtCoordinates", GetWidgetLocalPositionAtCoordinates_IsValid);
		GetWidgetIsVariable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWidgetIsVariable");
		GetWidgetIsVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetIsVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetIsVariable_Widget_PropertyAddress, GetWidgetIsVariable_FunctionAddress, "Widget");
		GetWidgetIsVariable_Widget_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetIsVariable_FunctionAddress, "Widget");
		GetWidgetIsVariable_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetIsVariable_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetIsVariable_ReturnValue_PropertyAddress, GetWidgetIsVariable_FunctionAddress, "ReturnValue");
		GetWidgetIsVariable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetIsVariable_FunctionAddress, "ReturnValue");
		GetWidgetIsVariable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetIsVariable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetWidgetIsVariable_IsValid = GetWidgetIsVariable_FunctionAddress != IntPtr.Zero && GetWidgetIsVariable_Widget_IsValid && GetWidgetIsVariable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetIsVariable", GetWidgetIsVariable_IsValid);
		GetWidgetFromName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWidgetFromName");
		GetWidgetFromName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetFromName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetFromName_Widget_PropertyAddress, GetWidgetFromName_FunctionAddress, "Widget");
		GetWidgetFromName_Widget_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetFromName_FunctionAddress, "Widget");
		GetWidgetFromName_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetFromName_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetFromName_Name_PropertyAddress, GetWidgetFromName_FunctionAddress, "Name");
		GetWidgetFromName_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetFromName_FunctionAddress, "Name");
		GetWidgetFromName_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetFromName_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetFromName_ReturnValue_PropertyAddress, GetWidgetFromName_FunctionAddress, "ReturnValue");
		GetWidgetFromName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetFromName_FunctionAddress, "ReturnValue");
		GetWidgetFromName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetFromName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWidgetFromName_IsValid = GetWidgetFromName_FunctionAddress != IntPtr.Zero && GetWidgetFromName_Widget_IsValid && GetWidgetFromName_Name_IsValid && GetWidgetFromName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetFromName", GetWidgetFromName_IsValid);
		GetWidgetAnimationName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWidgetAnimationName");
		GetWidgetAnimationName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetAnimationName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAnimationName_Animation_PropertyAddress, GetWidgetAnimationName_FunctionAddress, "Animation");
		GetWidgetAnimationName_Animation_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAnimationName_FunctionAddress, "Animation");
		GetWidgetAnimationName_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAnimationName_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAnimationName_ReturnValue_PropertyAddress, GetWidgetAnimationName_FunctionAddress, "ReturnValue");
		GetWidgetAnimationName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAnimationName_FunctionAddress, "ReturnValue");
		GetWidgetAnimationName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAnimationName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetWidgetAnimationName_IsValid = GetWidgetAnimationName_FunctionAddress != IntPtr.Zero && GetWidgetAnimationName_Animation_IsValid && GetWidgetAnimationName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAnimationName", GetWidgetAnimationName_IsValid);
		GetWidgetAnimationByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWidgetAnimationByName");
		GetWidgetAnimationByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetAnimationByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAnimationByName_Widget_PropertyAddress, GetWidgetAnimationByName_FunctionAddress, "Widget");
		GetWidgetAnimationByName_Widget_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAnimationByName_FunctionAddress, "Widget");
		GetWidgetAnimationByName_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAnimationByName_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAnimationByName_Name_PropertyAddress, GetWidgetAnimationByName_FunctionAddress, "Name");
		GetWidgetAnimationByName_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAnimationByName_FunctionAddress, "Name");
		GetWidgetAnimationByName_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAnimationByName_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAnimationByName_ReturnValue_PropertyAddress, GetWidgetAnimationByName_FunctionAddress, "ReturnValue");
		GetWidgetAnimationByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAnimationByName_FunctionAddress, "ReturnValue");
		GetWidgetAnimationByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAnimationByName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWidgetAnimationByName_IsValid = GetWidgetAnimationByName_FunctionAddress != IntPtr.Zero && GetWidgetAnimationByName_Widget_IsValid && GetWidgetAnimationByName_Name_IsValid && GetWidgetAnimationByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAnimationByName", GetWidgetAnimationByName_IsValid);
		GetWidgetAbsScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWidgetAbsScale");
		GetWidgetAbsScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetAbsScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAbsScale_widget_PropertyAddress, GetWidgetAbsScale_FunctionAddress, "widget");
		GetWidgetAbsScale_widget_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAbsScale_FunctionAddress, "widget");
		GetWidgetAbsScale_widget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAbsScale_FunctionAddress, "widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAbsScale_ReturnValue_PropertyAddress, GetWidgetAbsScale_FunctionAddress, "ReturnValue");
		GetWidgetAbsScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAbsScale_FunctionAddress, "ReturnValue");
		GetWidgetAbsScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAbsScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetWidgetAbsScale_IsValid = GetWidgetAbsScale_FunctionAddress != IntPtr.Zero && GetWidgetAbsScale_widget_IsValid && GetWidgetAbsScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsScale", GetWidgetAbsScale_IsValid);
		GetWidgetAbsoluteSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWidgetAbsoluteSize");
		GetWidgetAbsoluteSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetAbsoluteSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAbsoluteSize_widget_PropertyAddress, GetWidgetAbsoluteSize_FunctionAddress, "widget");
		GetWidgetAbsoluteSize_widget_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAbsoluteSize_FunctionAddress, "widget");
		GetWidgetAbsoluteSize_widget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAbsoluteSize_FunctionAddress, "widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAbsoluteSize_ReturnValue_PropertyAddress, GetWidgetAbsoluteSize_FunctionAddress, "ReturnValue");
		GetWidgetAbsoluteSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAbsoluteSize_FunctionAddress, "ReturnValue");
		GetWidgetAbsoluteSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAbsoluteSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWidgetAbsoluteSize_IsValid = GetWidgetAbsoluteSize_FunctionAddress != IntPtr.Zero && GetWidgetAbsoluteSize_widget_IsValid && GetWidgetAbsoluteSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsoluteSize", GetWidgetAbsoluteSize_IsValid);
		GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace");
		GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_widget_PropertyAddress, GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_FunctionAddress, "widget");
		GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_widget_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_FunctionAddress, "widget");
		GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_widget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_FunctionAddress, "widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_NormalCoordinates_PropertyAddress, GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_FunctionAddress, "NormalCoordinates");
		GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_NormalCoordinates_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_FunctionAddress, "NormalCoordinates");
		GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_NormalCoordinates_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_FunctionAddress, "NormalCoordinates", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_ReturnValue_PropertyAddress, GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_FunctionAddress, "ReturnValue");
		GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_FunctionAddress, "ReturnValue");
		GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_IsValid = GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_FunctionAddress != IntPtr.Zero && GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_widget_IsValid && GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_NormalCoordinates_IsValid && GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace", GetWidgetAbsolutePositionAtCoordinatesWithPaintSpace_IsValid);
		GetWidgetAbsolutePositionAtCoordinates_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWidgetAbsolutePositionAtCoordinates");
		GetWidgetAbsolutePositionAtCoordinates_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetAbsolutePositionAtCoordinates_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAbsolutePositionAtCoordinates_widget_PropertyAddress, GetWidgetAbsolutePositionAtCoordinates_FunctionAddress, "widget");
		GetWidgetAbsolutePositionAtCoordinates_widget_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAbsolutePositionAtCoordinates_FunctionAddress, "widget");
		GetWidgetAbsolutePositionAtCoordinates_widget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAbsolutePositionAtCoordinates_FunctionAddress, "widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAbsolutePositionAtCoordinates_NormalCoordinates_PropertyAddress, GetWidgetAbsolutePositionAtCoordinates_FunctionAddress, "NormalCoordinates");
		GetWidgetAbsolutePositionAtCoordinates_NormalCoordinates_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAbsolutePositionAtCoordinates_FunctionAddress, "NormalCoordinates");
		GetWidgetAbsolutePositionAtCoordinates_NormalCoordinates_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAbsolutePositionAtCoordinates_FunctionAddress, "NormalCoordinates", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAbsolutePositionAtCoordinates_ReturnValue_PropertyAddress, GetWidgetAbsolutePositionAtCoordinates_FunctionAddress, "ReturnValue");
		GetWidgetAbsolutePositionAtCoordinates_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAbsolutePositionAtCoordinates_FunctionAddress, "ReturnValue");
		GetWidgetAbsolutePositionAtCoordinates_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAbsolutePositionAtCoordinates_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWidgetAbsolutePositionAtCoordinates_IsValid = GetWidgetAbsolutePositionAtCoordinates_FunctionAddress != IntPtr.Zero && GetWidgetAbsolutePositionAtCoordinates_widget_IsValid && GetWidgetAbsolutePositionAtCoordinates_NormalCoordinates_IsValid && GetWidgetAbsolutePositionAtCoordinates_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsolutePositionAtCoordinates", GetWidgetAbsolutePositionAtCoordinates_IsValid);
		GetWidgetAbsolutePosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWidgetAbsolutePosition");
		GetWidgetAbsolutePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetAbsolutePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAbsolutePosition_widget_PropertyAddress, GetWidgetAbsolutePosition_FunctionAddress, "widget");
		GetWidgetAbsolutePosition_widget_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAbsolutePosition_FunctionAddress, "widget");
		GetWidgetAbsolutePosition_widget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAbsolutePosition_FunctionAddress, "widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetAbsolutePosition_ReturnValue_PropertyAddress, GetWidgetAbsolutePosition_FunctionAddress, "ReturnValue");
		GetWidgetAbsolutePosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetAbsolutePosition_FunctionAddress, "ReturnValue");
		GetWidgetAbsolutePosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetAbsolutePosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetWidgetAbsolutePosition_IsValid = GetWidgetAbsolutePosition_FunctionAddress != IntPtr.Zero && GetWidgetAbsolutePosition_widget_IsValid && GetWidgetAbsolutePosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetWidgetAbsolutePosition", GetWidgetAbsolutePosition_IsValid);
		GetViewportSizeXY_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetViewportSizeXY");
		GetViewportSizeXY_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewportSizeXY_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewportSizeXY_ReturnValue_PropertyAddress, GetViewportSizeXY_FunctionAddress, "ReturnValue");
		GetViewportSizeXY_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportSizeXY_FunctionAddress, "ReturnValue");
		GetViewportSizeXY_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportSizeXY_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetViewportSizeXY_IsValid = GetViewportSizeXY_FunctionAddress != IntPtr.Zero && GetViewportSizeXY_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetViewportSizeXY", GetViewportSizeXY_IsValid);
		GetViewPortSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetViewPortSize");
		GetViewPortSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewPortSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewPortSize_WorldContextObject_PropertyAddress, GetViewPortSize_FunctionAddress, "WorldContextObject");
		GetViewPortSize_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetViewPortSize_FunctionAddress, "WorldContextObject");
		GetViewPortSize_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewPortSize_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetViewPortSize_ReturnValue_PropertyAddress, GetViewPortSize_FunctionAddress, "ReturnValue");
		GetViewPortSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewPortSize_FunctionAddress, "ReturnValue");
		GetViewPortSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewPortSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetViewPortSize_IsValid = GetViewPortSize_FunctionAddress != IntPtr.Zero && GetViewPortSize_WorldContextObject_IsValid && GetViewPortSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetViewPortSize", GetViewPortSize_IsValid);
		GetViewPortScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetViewPortScale");
		GetViewPortScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewPortScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewPortScale_WorldContextObject_PropertyAddress, GetViewPortScale_FunctionAddress, "WorldContextObject");
		GetViewPortScale_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetViewPortScale_FunctionAddress, "WorldContextObject");
		GetViewPortScale_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewPortScale_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetViewPortScale_ReturnValue_PropertyAddress, GetViewPortScale_FunctionAddress, "ReturnValue");
		GetViewPortScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewPortScale_FunctionAddress, "ReturnValue");
		GetViewPortScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewPortScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetViewPortScale_IsValid = GetViewPortScale_FunctionAddress != IntPtr.Zero && GetViewPortScale_WorldContextObject_IsValid && GetViewPortScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetViewPortScale", GetViewPortScale_IsValid);
		GetViewPortAbsPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetViewPortAbsPosition");
		GetViewPortAbsPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewPortAbsPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewPortAbsPosition_WorldContextObject_PropertyAddress, GetViewPortAbsPosition_FunctionAddress, "WorldContextObject");
		GetViewPortAbsPosition_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetViewPortAbsPosition_FunctionAddress, "WorldContextObject");
		GetViewPortAbsPosition_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewPortAbsPosition_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetViewPortAbsPosition_ReturnValue_PropertyAddress, GetViewPortAbsPosition_FunctionAddress, "ReturnValue");
		GetViewPortAbsPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewPortAbsPosition_FunctionAddress, "ReturnValue");
		GetViewPortAbsPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewPortAbsPosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetViewPortAbsPosition_IsValid = GetViewPortAbsPosition_FunctionAddress != IntPtr.Zero && GetViewPortAbsPosition_WorldContextObject_IsValid && GetViewPortAbsPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetViewPortAbsPosition", GetViewPortAbsPosition_IsValid);
		GetTextBlockOutlineDynamicMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTextBlockOutlineDynamicMaterial");
		GetTextBlockOutlineDynamicMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextBlockOutlineDynamicMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextBlockOutlineDynamicMaterial_TextBlock_PropertyAddress, GetTextBlockOutlineDynamicMaterial_FunctionAddress, "TextBlock");
		GetTextBlockOutlineDynamicMaterial_TextBlock_Offset = NativeReflectionCached.GetPropertyOffset(GetTextBlockOutlineDynamicMaterial_FunctionAddress, "TextBlock");
		GetTextBlockOutlineDynamicMaterial_TextBlock_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextBlockOutlineDynamicMaterial_FunctionAddress, "TextBlock", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextBlockOutlineDynamicMaterial_ReturnValue_PropertyAddress, GetTextBlockOutlineDynamicMaterial_FunctionAddress, "ReturnValue");
		GetTextBlockOutlineDynamicMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextBlockOutlineDynamicMaterial_FunctionAddress, "ReturnValue");
		GetTextBlockOutlineDynamicMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextBlockOutlineDynamicMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetTextBlockOutlineDynamicMaterial_IsValid = GetTextBlockOutlineDynamicMaterial_FunctionAddress != IntPtr.Zero && GetTextBlockOutlineDynamicMaterial_TextBlock_IsValid && GetTextBlockOutlineDynamicMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetTextBlockOutlineDynamicMaterial", GetTextBlockOutlineDynamicMaterial_IsValid);
		GetTexDAColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTexDAColor");
		GetTexDAColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTexDAColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTexDAColor_HitAreaDA_PropertyAddress, GetTexDAColor_FunctionAddress, "HitAreaDA");
		GetTexDAColor_HitAreaDA_Offset = NativeReflectionCached.GetPropertyOffset(GetTexDAColor_FunctionAddress, "HitAreaDA");
		GetTexDAColor_HitAreaDA_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTexDAColor_FunctionAddress, "HitAreaDA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTexDAColor_X_PropertyAddress, GetTexDAColor_FunctionAddress, "X");
		GetTexDAColor_X_Offset = NativeReflectionCached.GetPropertyOffset(GetTexDAColor_FunctionAddress, "X");
		GetTexDAColor_X_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTexDAColor_FunctionAddress, "X", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTexDAColor_Y_PropertyAddress, GetTexDAColor_FunctionAddress, "Y");
		GetTexDAColor_Y_Offset = NativeReflectionCached.GetPropertyOffset(GetTexDAColor_FunctionAddress, "Y");
		GetTexDAColor_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTexDAColor_FunctionAddress, "Y", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTexDAColor_OutColor_PropertyAddress, GetTexDAColor_FunctionAddress, "OutColor");
		GetTexDAColor_OutColor_Offset = NativeReflectionCached.GetPropertyOffset(GetTexDAColor_FunctionAddress, "OutColor");
		GetTexDAColor_OutColor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTexDAColor_FunctionAddress, "OutColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTexDAColor_ReturnValue_PropertyAddress, GetTexDAColor_FunctionAddress, "ReturnValue");
		GetTexDAColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTexDAColor_FunctionAddress, "ReturnValue");
		GetTexDAColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTexDAColor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetTexDAColor_IsValid = GetTexDAColor_FunctionAddress != IntPtr.Zero && GetTexDAColor_HitAreaDA_IsValid && GetTexDAColor_X_IsValid && GetTexDAColor_Y_IsValid && GetTexDAColor_OutColor_IsValid && GetTexDAColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetTexDAColor", GetTexDAColor_IsValid);
		GetSafeZonePaddingSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSafeZonePaddingSize");
		GetSafeZonePaddingSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSafeZonePaddingSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSafeZonePaddingSize_WorldContextObject_PropertyAddress, GetSafeZonePaddingSize_FunctionAddress, "WorldContextObject");
		GetSafeZonePaddingSize_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetSafeZonePaddingSize_FunctionAddress, "WorldContextObject");
		GetSafeZonePaddingSize_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSafeZonePaddingSize_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSafeZonePaddingSize_ReturnValue_PropertyAddress, GetSafeZonePaddingSize_FunctionAddress, "ReturnValue");
		GetSafeZonePaddingSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSafeZonePaddingSize_FunctionAddress, "ReturnValue");
		GetSafeZonePaddingSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSafeZonePaddingSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSafeZonePaddingSize_IsValid = GetSafeZonePaddingSize_FunctionAddress != IntPtr.Zero && GetSafeZonePaddingSize_WorldContextObject_IsValid && GetSafeZonePaddingSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetSafeZonePaddingSize", GetSafeZonePaddingSize_IsValid);
		GetRootWidget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRootWidget");
		GetRootWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRootWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRootWidget_Widget_PropertyAddress, GetRootWidget_FunctionAddress, "Widget");
		GetRootWidget_Widget_Offset = NativeReflectionCached.GetPropertyOffset(GetRootWidget_FunctionAddress, "Widget");
		GetRootWidget_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRootWidget_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRootWidget_ReturnValue_PropertyAddress, GetRootWidget_FunctionAddress, "ReturnValue");
		GetRootWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRootWidget_FunctionAddress, "ReturnValue");
		GetRootWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRootWidget_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetRootWidget_IsValid = GetRootWidget_FunctionAddress != IntPtr.Zero && GetRootWidget_Widget_IsValid && GetRootWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetRootWidget", GetRootWidget_IsValid);
		GetMouseWheelDelta_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMouseWheelDelta");
		GetMouseWheelDelta_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMouseWheelDelta_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMouseWheelDelta_PointerEvent_PropertyAddress, GetMouseWheelDelta_FunctionAddress, "PointerEvent");
		GetMouseWheelDelta_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetMouseWheelDelta_FunctionAddress, "PointerEvent");
		GetMouseWheelDelta_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMouseWheelDelta_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMouseWheelDelta_ReturnValue_PropertyAddress, GetMouseWheelDelta_FunctionAddress, "ReturnValue");
		GetMouseWheelDelta_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMouseWheelDelta_FunctionAddress, "ReturnValue");
		GetMouseWheelDelta_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMouseWheelDelta_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMouseWheelDelta_IsValid = GetMouseWheelDelta_FunctionAddress != IntPtr.Zero && GetMouseWheelDelta_PointerEvent_IsValid && GetMouseWheelDelta_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetMouseWheelDelta", GetMouseWheelDelta_IsValid);
		GetMousePositionFromViewport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMousePositionFromViewport");
		GetMousePositionFromViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMousePositionFromViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMousePositionFromViewport_OutPosition_PropertyAddress, GetMousePositionFromViewport_FunctionAddress, "OutPosition");
		GetMousePositionFromViewport_OutPosition_Offset = NativeReflectionCached.GetPropertyOffset(GetMousePositionFromViewport_FunctionAddress, "OutPosition");
		GetMousePositionFromViewport_OutPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMousePositionFromViewport_FunctionAddress, "OutPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMousePositionFromViewport_ReturnValue_PropertyAddress, GetMousePositionFromViewport_FunctionAddress, "ReturnValue");
		GetMousePositionFromViewport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMousePositionFromViewport_FunctionAddress, "ReturnValue");
		GetMousePositionFromViewport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMousePositionFromViewport_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetMousePositionFromViewport_IsValid = GetMousePositionFromViewport_FunctionAddress != IntPtr.Zero && GetMousePositionFromViewport_OutPosition_IsValid && GetMousePositionFromViewport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetMousePositionFromViewport", GetMousePositionFromViewport_IsValid);
		GetMouseKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMouseKey");
		GetMouseKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMouseKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMouseKey_PointerEvent_PropertyAddress, GetMouseKey_FunctionAddress, "PointerEvent");
		GetMouseKey_PointerEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetMouseKey_FunctionAddress, "PointerEvent");
		GetMouseKey_PointerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMouseKey_FunctionAddress, "PointerEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMouseKey_ReturnValue_PropertyAddress, GetMouseKey_FunctionAddress, "ReturnValue");
		GetMouseKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMouseKey_FunctionAddress, "ReturnValue");
		GetMouseKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMouseKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetMouseKey_IsValid = GetMouseKey_FunctionAddress != IntPtr.Zero && GetMouseKey_PointerEvent_IsValid && GetMouseKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetMouseKey", GetMouseKey_IsValid);
		GetMediaPlayerTimer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMediaPlayerTimer");
		GetMediaPlayerTimer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMediaPlayerTimer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMediaPlayerTimer_MediaPlayer_PropertyAddress, GetMediaPlayerTimer_FunctionAddress, "MediaPlayer");
		GetMediaPlayerTimer_MediaPlayer_Offset = NativeReflectionCached.GetPropertyOffset(GetMediaPlayerTimer_FunctionAddress, "MediaPlayer");
		GetMediaPlayerTimer_MediaPlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMediaPlayerTimer_FunctionAddress, "MediaPlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMediaPlayerTimer_ReturnValue_PropertyAddress, GetMediaPlayerTimer_FunctionAddress, "ReturnValue");
		GetMediaPlayerTimer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMediaPlayerTimer_FunctionAddress, "ReturnValue");
		GetMediaPlayerTimer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMediaPlayerTimer_FunctionAddress, "ReturnValue", Classes.FDoubleProperty);
		GetMediaPlayerTimer_IsValid = GetMediaPlayerTimer_FunctionAddress != IntPtr.Zero && GetMediaPlayerTimer_MediaPlayer_IsValid && GetMediaPlayerTimer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetMediaPlayerTimer", GetMediaPlayerTimer_IsValid);
		GetKeyWithName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetKeyWithName");
		GetKeyWithName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKeyWithName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKeyWithName_KeyName_PropertyAddress, GetKeyWithName_FunctionAddress, "KeyName");
		GetKeyWithName_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyWithName_FunctionAddress, "KeyName");
		GetKeyWithName_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyWithName_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKeyWithName_ReturnValue_PropertyAddress, GetKeyWithName_FunctionAddress, "ReturnValue");
		GetKeyWithName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyWithName_FunctionAddress, "ReturnValue");
		GetKeyWithName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyWithName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetKeyWithName_IsValid = GetKeyWithName_FunctionAddress != IntPtr.Zero && GetKeyWithName_KeyName_IsValid && GetKeyWithName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetKeyWithName", GetKeyWithName_IsValid);
		GetIsGamepadKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsGamepadKey");
		GetIsGamepadKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsGamepadKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsGamepadKey_KeyName_PropertyAddress, GetIsGamepadKey_FunctionAddress, "KeyName");
		GetIsGamepadKey_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetIsGamepadKey_FunctionAddress, "KeyName");
		GetIsGamepadKey_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsGamepadKey_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIsGamepadKey_ReturnValue_PropertyAddress, GetIsGamepadKey_FunctionAddress, "ReturnValue");
		GetIsGamepadKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsGamepadKey_FunctionAddress, "ReturnValue");
		GetIsGamepadKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsGamepadKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsGamepadKey_IsValid = GetIsGamepadKey_FunctionAddress != IntPtr.Zero && GetIsGamepadKey_KeyName_IsValid && GetIsGamepadKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetIsGamepadKey", GetIsGamepadKey_IsValid);
		GetIsAxis1DKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsAxis1DKey");
		GetIsAxis1DKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsAxis1DKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsAxis1DKey_KeyName_PropertyAddress, GetIsAxis1DKey_FunctionAddress, "KeyName");
		GetIsAxis1DKey_KeyName_Offset = NativeReflectionCached.GetPropertyOffset(GetIsAxis1DKey_FunctionAddress, "KeyName");
		GetIsAxis1DKey_KeyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsAxis1DKey_FunctionAddress, "KeyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIsAxis1DKey_ReturnValue_PropertyAddress, GetIsAxis1DKey_FunctionAddress, "ReturnValue");
		GetIsAxis1DKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsAxis1DKey_FunctionAddress, "ReturnValue");
		GetIsAxis1DKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsAxis1DKey_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsAxis1DKey_IsValid = GetIsAxis1DKey_FunctionAddress != IntPtr.Zero && GetIsAxis1DKey_KeyName_IsValid && GetIsAxis1DKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetIsAxis1DKey", GetIsAxis1DKey_IsValid);
		GetFocusEventUser_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFocusEventUser");
		GetFocusEventUser_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFocusEventUser_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFocusEventUser_FocusEvent_PropertyAddress, GetFocusEventUser_FunctionAddress, "FocusEvent");
		GetFocusEventUser_FocusEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetFocusEventUser_FunctionAddress, "FocusEvent");
		GetFocusEventUser_FocusEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFocusEventUser_FunctionAddress, "FocusEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFocusEventUser_ReturnValue_PropertyAddress, GetFocusEventUser_FunctionAddress, "ReturnValue");
		GetFocusEventUser_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFocusEventUser_FunctionAddress, "ReturnValue");
		GetFocusEventUser_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFocusEventUser_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetFocusEventUser_IsValid = GetFocusEventUser_FunctionAddress != IntPtr.Zero && GetFocusEventUser_FocusEvent_IsValid && GetFocusEventUser_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetFocusEventUser", GetFocusEventUser_IsValid);
		GetFocusEventCause_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFocusEventCause");
		GetFocusEventCause_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFocusEventCause_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFocusEventCause_FocusEvent_PropertyAddress, GetFocusEventCause_FunctionAddress, "FocusEvent");
		GetFocusEventCause_FocusEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetFocusEventCause_FunctionAddress, "FocusEvent");
		GetFocusEventCause_FocusEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFocusEventCause_FunctionAddress, "FocusEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFocusEventCause_ReturnValue_PropertyAddress, GetFocusEventCause_FunctionAddress, "ReturnValue");
		GetFocusEventCause_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFocusEventCause_FunctionAddress, "ReturnValue");
		GetFocusEventCause_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFocusEventCause_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetFocusEventCause_IsValid = GetFocusEventCause_FunctionAddress != IntPtr.Zero && GetFocusEventCause_FocusEvent_IsValid && GetFocusEventCause_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetFocusEventCause", GetFocusEventCause_IsValid);
		GetCurrentCulture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentCulture");
		GetCurrentCulture_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentCulture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentCulture_ReturnValue_PropertyAddress, GetCurrentCulture_FunctionAddress, "ReturnValue");
		GetCurrentCulture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentCulture_FunctionAddress, "ReturnValue");
		GetCurrentCulture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentCulture_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCurrentCulture_IsValid = GetCurrentCulture_FunctionAddress != IntPtr.Zero && GetCurrentCulture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetCurrentCulture", GetCurrentCulture_IsValid);
		GetChildWidgetAt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetChildWidgetAt");
		GetChildWidgetAt_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildWidgetAt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildWidgetAt_ParentWidget_PropertyAddress, GetChildWidgetAt_FunctionAddress, "ParentWidget");
		GetChildWidgetAt_ParentWidget_Offset = NativeReflectionCached.GetPropertyOffset(GetChildWidgetAt_FunctionAddress, "ParentWidget");
		GetChildWidgetAt_ParentWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildWidgetAt_FunctionAddress, "ParentWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildWidgetAt_ChildIndex_PropertyAddress, GetChildWidgetAt_FunctionAddress, "ChildIndex");
		GetChildWidgetAt_ChildIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetChildWidgetAt_FunctionAddress, "ChildIndex");
		GetChildWidgetAt_ChildIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildWidgetAt_FunctionAddress, "ChildIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildWidgetAt_ReturnValue_PropertyAddress, GetChildWidgetAt_FunctionAddress, "ReturnValue");
		GetChildWidgetAt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChildWidgetAt_FunctionAddress, "ReturnValue");
		GetChildWidgetAt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildWidgetAt_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetChildWidgetAt_IsValid = GetChildWidgetAt_FunctionAddress != IntPtr.Zero && GetChildWidgetAt_ParentWidget_IsValid && GetChildWidgetAt_ChildIndex_IsValid && GetChildWidgetAt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetChildWidgetAt", GetChildWidgetAt_IsValid);
		GetAnalogValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnalogValue");
		GetAnalogValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnalogValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnalogValue_AnalogInputEvent_PropertyAddress, GetAnalogValue_FunctionAddress, "AnalogInputEvent");
		GetAnalogValue_AnalogInputEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetAnalogValue_FunctionAddress, "AnalogInputEvent");
		GetAnalogValue_AnalogInputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnalogValue_FunctionAddress, "AnalogInputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnalogValue_ReturnValue_PropertyAddress, GetAnalogValue_FunctionAddress, "ReturnValue");
		GetAnalogValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnalogValue_FunctionAddress, "ReturnValue");
		GetAnalogValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnalogValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAnalogValue_IsValid = GetAnalogValue_FunctionAddress != IntPtr.Zero && GetAnalogValue_AnalogInputEvent_IsValid && GetAnalogValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetAnalogValue", GetAnalogValue_IsValid);
		GetAnalogKeyIsRepeat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnalogKeyIsRepeat");
		GetAnalogKeyIsRepeat_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnalogKeyIsRepeat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnalogKeyIsRepeat_AnalogInputEvent_PropertyAddress, GetAnalogKeyIsRepeat_FunctionAddress, "AnalogInputEvent");
		GetAnalogKeyIsRepeat_AnalogInputEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetAnalogKeyIsRepeat_FunctionAddress, "AnalogInputEvent");
		GetAnalogKeyIsRepeat_AnalogInputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnalogKeyIsRepeat_FunctionAddress, "AnalogInputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnalogKeyIsRepeat_ReturnValue_PropertyAddress, GetAnalogKeyIsRepeat_FunctionAddress, "ReturnValue");
		GetAnalogKeyIsRepeat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnalogKeyIsRepeat_FunctionAddress, "ReturnValue");
		GetAnalogKeyIsRepeat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnalogKeyIsRepeat_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAnalogKeyIsRepeat_IsValid = GetAnalogKeyIsRepeat_FunctionAddress != IntPtr.Zero && GetAnalogKeyIsRepeat_AnalogInputEvent_IsValid && GetAnalogKeyIsRepeat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetAnalogKeyIsRepeat", GetAnalogKeyIsRepeat_IsValid);
		GetAnalogKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnalogKey");
		GetAnalogKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnalogKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnalogKey_AnalogInputEvent_PropertyAddress, GetAnalogKey_FunctionAddress, "AnalogInputEvent");
		GetAnalogKey_AnalogInputEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetAnalogKey_FunctionAddress, "AnalogInputEvent");
		GetAnalogKey_AnalogInputEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnalogKey_FunctionAddress, "AnalogInputEvent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnalogKey_ReturnValue_PropertyAddress, GetAnalogKey_FunctionAddress, "ReturnValue");
		GetAnalogKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnalogKey_FunctionAddress, "ReturnValue");
		GetAnalogKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnalogKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAnalogKey_IsValid = GetAnalogKey_FunctionAddress != IntPtr.Zero && GetAnalogKey_AnalogInputEvent_IsValid && GetAnalogKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetAnalogKey", GetAnalogKey_IsValid);
		GetAllChildWidgetWithClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllChildWidgetWithClass");
		GetAllChildWidgetWithClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllChildWidgetWithClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllChildWidgetWithClass_UserWidget_PropertyAddress, GetAllChildWidgetWithClass_FunctionAddress, "UserWidget");
		GetAllChildWidgetWithClass_UserWidget_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChildWidgetWithClass_FunctionAddress, "UserWidget");
		GetAllChildWidgetWithClass_UserWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChildWidgetWithClass_FunctionAddress, "UserWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllChildWidgetWithClass_WidgetClass_PropertyAddress, GetAllChildWidgetWithClass_FunctionAddress, "WidgetClass");
		GetAllChildWidgetWithClass_WidgetClass_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChildWidgetWithClass_FunctionAddress, "WidgetClass");
		GetAllChildWidgetWithClass_WidgetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChildWidgetWithClass_FunctionAddress, "WidgetClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllChildWidgetWithClass_ReturnValue_PropertyAddress, GetAllChildWidgetWithClass_FunctionAddress, "ReturnValue");
		GetAllChildWidgetWithClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChildWidgetWithClass_FunctionAddress, "ReturnValue");
		GetAllChildWidgetWithClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChildWidgetWithClass_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllChildWidgetWithClass_IsValid = GetAllChildWidgetWithClass_FunctionAddress != IntPtr.Zero && GetAllChildWidgetWithClass_UserWidget_IsValid && GetAllChildWidgetWithClass_WidgetClass_IsValid && GetAllChildWidgetWithClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetAllChildWidgetWithClass", GetAllChildWidgetWithClass_IsValid);
		GetAllChildWidget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllChildWidget");
		GetAllChildWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllChildWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllChildWidget_UserWidget_PropertyAddress, GetAllChildWidget_FunctionAddress, "UserWidget");
		GetAllChildWidget_UserWidget_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChildWidget_FunctionAddress, "UserWidget");
		GetAllChildWidget_UserWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChildWidget_FunctionAddress, "UserWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllChildWidget_ReturnValue_PropertyAddress, GetAllChildWidget_FunctionAddress, "ReturnValue");
		GetAllChildWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChildWidget_FunctionAddress, "ReturnValue");
		GetAllChildWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChildWidget_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllChildWidget_IsValid = GetAllChildWidget_FunctionAddress != IntPtr.Zero && GetAllChildWidget_UserWidget_IsValid && GetAllChildWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetAllChildWidget", GetAllChildWidget_IsValid);
		GetAllChildUserWidgetWithClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllChildUserWidgetWithClass");
		GetAllChildUserWidgetWithClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllChildUserWidgetWithClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllChildUserWidgetWithClass_UserWidget_PropertyAddress, GetAllChildUserWidgetWithClass_FunctionAddress, "UserWidget");
		GetAllChildUserWidgetWithClass_UserWidget_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChildUserWidgetWithClass_FunctionAddress, "UserWidget");
		GetAllChildUserWidgetWithClass_UserWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChildUserWidgetWithClass_FunctionAddress, "UserWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllChildUserWidgetWithClass_WidgetClass_PropertyAddress, GetAllChildUserWidgetWithClass_FunctionAddress, "WidgetClass");
		GetAllChildUserWidgetWithClass_WidgetClass_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChildUserWidgetWithClass_FunctionAddress, "WidgetClass");
		GetAllChildUserWidgetWithClass_WidgetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChildUserWidgetWithClass_FunctionAddress, "WidgetClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllChildUserWidgetWithClass_ReturnValue_PropertyAddress, GetAllChildUserWidgetWithClass_FunctionAddress, "ReturnValue");
		GetAllChildUserWidgetWithClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChildUserWidgetWithClass_FunctionAddress, "ReturnValue");
		GetAllChildUserWidgetWithClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChildUserWidgetWithClass_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllChildUserWidgetWithClass_IsValid = GetAllChildUserWidgetWithClass_FunctionAddress != IntPtr.Zero && GetAllChildUserWidgetWithClass_UserWidget_IsValid && GetAllChildUserWidgetWithClass_WidgetClass_IsValid && GetAllChildUserWidgetWithClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetAllChildUserWidgetWithClass", GetAllChildUserWidgetWithClass_IsValid);
		GetAllChildUserWidget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllChildUserWidget");
		GetAllChildUserWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllChildUserWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllChildUserWidget_ParentWidget_PropertyAddress, GetAllChildUserWidget_FunctionAddress, "ParentWidget");
		GetAllChildUserWidget_ParentWidget_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChildUserWidget_FunctionAddress, "ParentWidget");
		GetAllChildUserWidget_ParentWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChildUserWidget_FunctionAddress, "ParentWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllChildUserWidget_ReturnValue_PropertyAddress, GetAllChildUserWidget_FunctionAddress, "ReturnValue");
		GetAllChildUserWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllChildUserWidget_FunctionAddress, "ReturnValue");
		GetAllChildUserWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllChildUserWidget_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllChildUserWidget_IsValid = GetAllChildUserWidget_FunctionAddress != IntPtr.Zero && GetAllChildUserWidget_ParentWidget_IsValid && GetAllChildUserWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:GetAllChildUserWidget", GetAllChildUserWidget_IsValid);
		FoldTextContent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FoldTextContent");
		FoldTextContent_ParamsSize = NativeReflection.GetFunctionParamsSize(FoldTextContent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FoldTextContent_InTextBlock_PropertyAddress, FoldTextContent_FunctionAddress, "InTextBlock");
		FoldTextContent_InTextBlock_Offset = NativeReflectionCached.GetPropertyOffset(FoldTextContent_FunctionAddress, "InTextBlock");
		FoldTextContent_InTextBlock_IsValid = NativeReflectionCached.ValidatePropertyClass(FoldTextContent_FunctionAddress, "InTextBlock", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FoldTextContent_InFoldingConfig_PropertyAddress, FoldTextContent_FunctionAddress, "InFoldingConfig");
		FoldTextContent_InFoldingConfig_Offset = NativeReflectionCached.GetPropertyOffset(FoldTextContent_FunctionAddress, "InFoldingConfig");
		FoldTextContent_InFoldingConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(FoldTextContent_FunctionAddress, "InFoldingConfig", Classes.FStructProperty);
		FoldTextContent_IsValid = FoldTextContent_FunctionAddress != IntPtr.Zero && FoldTextContent_InTextBlock_IsValid && FoldTextContent_InFoldingConfig_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:FoldTextContent", FoldTextContent_IsValid);
		FlushFontCache_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FlushFontCache");
		FlushFontCache_ParamsSize = NativeReflection.GetFunctionParamsSize(FlushFontCache_FunctionAddress);
		FlushFontCache_IsValid = FlushFontCache_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:FlushFontCache", FlushFontCache_IsValid);
		FindChildWidgetIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindChildWidgetIndex");
		FindChildWidgetIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(FindChildWidgetIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindChildWidgetIndex_UserWidget_PropertyAddress, FindChildWidgetIndex_FunctionAddress, "UserWidget");
		FindChildWidgetIndex_UserWidget_Offset = NativeReflectionCached.GetPropertyOffset(FindChildWidgetIndex_FunctionAddress, "UserWidget");
		FindChildWidgetIndex_UserWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(FindChildWidgetIndex_FunctionAddress, "UserWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindChildWidgetIndex_ParentWidget_PropertyAddress, FindChildWidgetIndex_FunctionAddress, "ParentWidget");
		FindChildWidgetIndex_ParentWidget_Offset = NativeReflectionCached.GetPropertyOffset(FindChildWidgetIndex_FunctionAddress, "ParentWidget");
		FindChildWidgetIndex_ParentWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(FindChildWidgetIndex_FunctionAddress, "ParentWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindChildWidgetIndex_ChildWidgetName_PropertyAddress, FindChildWidgetIndex_FunctionAddress, "ChildWidgetName");
		FindChildWidgetIndex_ChildWidgetName_Offset = NativeReflectionCached.GetPropertyOffset(FindChildWidgetIndex_FunctionAddress, "ChildWidgetName");
		FindChildWidgetIndex_ChildWidgetName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindChildWidgetIndex_FunctionAddress, "ChildWidgetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindChildWidgetIndex_ReturnValue_PropertyAddress, FindChildWidgetIndex_FunctionAddress, "ReturnValue");
		FindChildWidgetIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindChildWidgetIndex_FunctionAddress, "ReturnValue");
		FindChildWidgetIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindChildWidgetIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		FindChildWidgetIndex_IsValid = FindChildWidgetIndex_FunctionAddress != IntPtr.Zero && FindChildWidgetIndex_UserWidget_IsValid && FindChildWidgetIndex_ParentWidget_IsValid && FindChildWidgetIndex_ChildWidgetName_IsValid && FindChildWidgetIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:FindChildWidgetIndex", FindChildWidgetIndex_IsValid);
		FindChildWidget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindChildWidget");
		FindChildWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(FindChildWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindChildWidget_UserWidget_PropertyAddress, FindChildWidget_FunctionAddress, "UserWidget");
		FindChildWidget_UserWidget_Offset = NativeReflectionCached.GetPropertyOffset(FindChildWidget_FunctionAddress, "UserWidget");
		FindChildWidget_UserWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(FindChildWidget_FunctionAddress, "UserWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindChildWidget_ParentWidget_PropertyAddress, FindChildWidget_FunctionAddress, "ParentWidget");
		FindChildWidget_ParentWidget_Offset = NativeReflectionCached.GetPropertyOffset(FindChildWidget_FunctionAddress, "ParentWidget");
		FindChildWidget_ParentWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(FindChildWidget_FunctionAddress, "ParentWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindChildWidget_ChildWidgetName_PropertyAddress, FindChildWidget_FunctionAddress, "ChildWidgetName");
		FindChildWidget_ChildWidgetName_Offset = NativeReflectionCached.GetPropertyOffset(FindChildWidget_FunctionAddress, "ChildWidgetName");
		FindChildWidget_ChildWidgetName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindChildWidget_FunctionAddress, "ChildWidgetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindChildWidget_ReturnValue_PropertyAddress, FindChildWidget_FunctionAddress, "ReturnValue");
		FindChildWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindChildWidget_FunctionAddress, "ReturnValue");
		FindChildWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindChildWidget_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindChildWidget_IsValid = FindChildWidget_FunctionAddress != IntPtr.Zero && FindChildWidget_UserWidget_IsValid && FindChildWidget_ParentWidget_IsValid && FindChildWidget_ChildWidgetName_IsValid && FindChildWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:FindChildWidget", FindChildWidget_IsValid);
		CreateUserWidgetWithClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateUserWidgetWithClass");
		CreateUserWidgetWithClass_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateUserWidgetWithClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateUserWidgetWithClass_WorldContext_PropertyAddress, CreateUserWidgetWithClass_FunctionAddress, "WorldContext");
		CreateUserWidgetWithClass_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(CreateUserWidgetWithClass_FunctionAddress, "WorldContext");
		CreateUserWidgetWithClass_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUserWidgetWithClass_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateUserWidgetWithClass_WidgetClass_PropertyAddress, CreateUserWidgetWithClass_FunctionAddress, "WidgetClass");
		CreateUserWidgetWithClass_WidgetClass_Offset = NativeReflectionCached.GetPropertyOffset(CreateUserWidgetWithClass_FunctionAddress, "WidgetClass");
		CreateUserWidgetWithClass_WidgetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUserWidgetWithClass_FunctionAddress, "WidgetClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateUserWidgetWithClass_ReturnValue_PropertyAddress, CreateUserWidgetWithClass_FunctionAddress, "ReturnValue");
		CreateUserWidgetWithClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateUserWidgetWithClass_FunctionAddress, "ReturnValue");
		CreateUserWidgetWithClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUserWidgetWithClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateUserWidgetWithClass_IsValid = CreateUserWidgetWithClass_FunctionAddress != IntPtr.Zero && CreateUserWidgetWithClass_WorldContext_IsValid && CreateUserWidgetWithClass_WidgetClass_IsValid && CreateUserWidgetWithClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:CreateUserWidgetWithClass", CreateUserWidgetWithClass_IsValid);
		CreateUserWidget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateUserWidget");
		CreateUserWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateUserWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateUserWidget_WorldContext_PropertyAddress, CreateUserWidget_FunctionAddress, "WorldContext");
		CreateUserWidget_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(CreateUserWidget_FunctionAddress, "WorldContext");
		CreateUserWidget_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUserWidget_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateUserWidget_ResPath_PropertyAddress, CreateUserWidget_FunctionAddress, "ResPath");
		CreateUserWidget_ResPath_Offset = NativeReflectionCached.GetPropertyOffset(CreateUserWidget_FunctionAddress, "ResPath");
		CreateUserWidget_ResPath_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUserWidget_FunctionAddress, "ResPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateUserWidget_ReturnValue_PropertyAddress, CreateUserWidget_FunctionAddress, "ReturnValue");
		CreateUserWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateUserWidget_FunctionAddress, "ReturnValue");
		CreateUserWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUserWidget_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateUserWidget_IsValid = CreateUserWidget_FunctionAddress != IntPtr.Zero && CreateUserWidget_WorldContext_IsValid && CreateUserWidget_ResPath_IsValid && CreateUserWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:CreateUserWidget", CreateUserWidget_IsValid);
		CreateGSViewPortHelper_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateGSViewPortHelper");
		CreateGSViewPortHelper_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateGSViewPortHelper_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateGSViewPortHelper_WorldContext_PropertyAddress, CreateGSViewPortHelper_FunctionAddress, "WorldContext");
		CreateGSViewPortHelper_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(CreateGSViewPortHelper_FunctionAddress, "WorldContext");
		CreateGSViewPortHelper_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGSViewPortHelper_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGSViewPortHelper_ReturnValue_PropertyAddress, CreateGSViewPortHelper_FunctionAddress, "ReturnValue");
		CreateGSViewPortHelper_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateGSViewPortHelper_FunctionAddress, "ReturnValue");
		CreateGSViewPortHelper_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGSViewPortHelper_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateGSViewPortHelper_IsValid = CreateGSViewPortHelper_FunctionAddress != IntPtr.Zero && CreateGSViewPortHelper_WorldContext_IsValid && CreateGSViewPortHelper_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:CreateGSViewPortHelper", CreateGSViewPortHelper_IsValid);
		CreateGSAnimKeyStateBlender_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateGSAnimKeyStateBlender");
		CreateGSAnimKeyStateBlender_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateGSAnimKeyStateBlender_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateGSAnimKeyStateBlender_WorldContext_PropertyAddress, CreateGSAnimKeyStateBlender_FunctionAddress, "WorldContext");
		CreateGSAnimKeyStateBlender_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(CreateGSAnimKeyStateBlender_FunctionAddress, "WorldContext");
		CreateGSAnimKeyStateBlender_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGSAnimKeyStateBlender_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateGSAnimKeyStateBlender_ReturnValue_PropertyAddress, CreateGSAnimKeyStateBlender_FunctionAddress, "ReturnValue");
		CreateGSAnimKeyStateBlender_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateGSAnimKeyStateBlender_FunctionAddress, "ReturnValue");
		CreateGSAnimKeyStateBlender_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateGSAnimKeyStateBlender_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateGSAnimKeyStateBlender_IsValid = CreateGSAnimKeyStateBlender_FunctionAddress != IntPtr.Zero && CreateGSAnimKeyStateBlender_WorldContext_IsValid && CreateGSAnimKeyStateBlender_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:CreateGSAnimKeyStateBlender", CreateGSAnimKeyStateBlender_IsValid);
		CreateEditorStandaloneWidget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateEditorStandaloneWidget");
		CreateEditorStandaloneWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateEditorStandaloneWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateEditorStandaloneWidget_OwningWidget_PropertyAddress, CreateEditorStandaloneWidget_FunctionAddress, "OwningWidget");
		CreateEditorStandaloneWidget_OwningWidget_Offset = NativeReflectionCached.GetPropertyOffset(CreateEditorStandaloneWidget_FunctionAddress, "OwningWidget");
		CreateEditorStandaloneWidget_OwningWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEditorStandaloneWidget_FunctionAddress, "OwningWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateEditorStandaloneWidget_ResPath_PropertyAddress, CreateEditorStandaloneWidget_FunctionAddress, "ResPath");
		CreateEditorStandaloneWidget_ResPath_Offset = NativeReflectionCached.GetPropertyOffset(CreateEditorStandaloneWidget_FunctionAddress, "ResPath");
		CreateEditorStandaloneWidget_ResPath_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEditorStandaloneWidget_FunctionAddress, "ResPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateEditorStandaloneWidget_Name_PropertyAddress, CreateEditorStandaloneWidget_FunctionAddress, "Name");
		CreateEditorStandaloneWidget_Name_Offset = NativeReflectionCached.GetPropertyOffset(CreateEditorStandaloneWidget_FunctionAddress, "Name");
		CreateEditorStandaloneWidget_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEditorStandaloneWidget_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateEditorStandaloneWidget_ReturnValue_PropertyAddress, CreateEditorStandaloneWidget_FunctionAddress, "ReturnValue");
		CreateEditorStandaloneWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateEditorStandaloneWidget_FunctionAddress, "ReturnValue");
		CreateEditorStandaloneWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateEditorStandaloneWidget_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateEditorStandaloneWidget_IsValid = CreateEditorStandaloneWidget_FunctionAddress != IntPtr.Zero && CreateEditorStandaloneWidget_OwningWidget_IsValid && CreateEditorStandaloneWidget_ResPath_IsValid && CreateEditorStandaloneWidget_Name_IsValid && CreateEditorStandaloneWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:CreateEditorStandaloneWidget", CreateEditorStandaloneWidget_IsValid);
		ConvertToTimeText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToTimeText");
		ConvertToTimeText_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToTimeText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToTimeText_Year_PropertyAddress, ConvertToTimeText_FunctionAddress, "Year");
		ConvertToTimeText_Year_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToTimeText_FunctionAddress, "Year");
		ConvertToTimeText_Year_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToTimeText_FunctionAddress, "Year", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToTimeText_Month_PropertyAddress, ConvertToTimeText_FunctionAddress, "Month");
		ConvertToTimeText_Month_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToTimeText_FunctionAddress, "Month");
		ConvertToTimeText_Month_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToTimeText_FunctionAddress, "Month", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToTimeText_Day_PropertyAddress, ConvertToTimeText_FunctionAddress, "Day");
		ConvertToTimeText_Day_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToTimeText_FunctionAddress, "Day");
		ConvertToTimeText_Day_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToTimeText_FunctionAddress, "Day", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToTimeText_Hour_PropertyAddress, ConvertToTimeText_FunctionAddress, "Hour");
		ConvertToTimeText_Hour_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToTimeText_FunctionAddress, "Hour");
		ConvertToTimeText_Hour_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToTimeText_FunctionAddress, "Hour", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToTimeText_Minute_PropertyAddress, ConvertToTimeText_FunctionAddress, "Minute");
		ConvertToTimeText_Minute_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToTimeText_FunctionAddress, "Minute");
		ConvertToTimeText_Minute_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToTimeText_FunctionAddress, "Minute", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToTimeText_Second_PropertyAddress, ConvertToTimeText_FunctionAddress, "Second");
		ConvertToTimeText_Second_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToTimeText_FunctionAddress, "Second");
		ConvertToTimeText_Second_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToTimeText_FunctionAddress, "Second", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToTimeText_ReturnValue_PropertyAddress, ConvertToTimeText_FunctionAddress, "ReturnValue");
		ConvertToTimeText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToTimeText_FunctionAddress, "ReturnValue");
		ConvertToTimeText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToTimeText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		ConvertToTimeText_IsValid = ConvertToTimeText_FunctionAddress != IntPtr.Zero && ConvertToTimeText_Year_IsValid && ConvertToTimeText_Month_IsValid && ConvertToTimeText_Day_IsValid && ConvertToTimeText_Hour_IsValid && ConvertToTimeText_Minute_IsValid && ConvertToTimeText_Second_IsValid && ConvertToTimeText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:ConvertToTimeText", ConvertToTimeText_IsValid);
		ConvertToDateText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToDateText");
		ConvertToDateText_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToDateText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToDateText_Year_PropertyAddress, ConvertToDateText_FunctionAddress, "Year");
		ConvertToDateText_Year_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToDateText_FunctionAddress, "Year");
		ConvertToDateText_Year_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToDateText_FunctionAddress, "Year", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToDateText_Month_PropertyAddress, ConvertToDateText_FunctionAddress, "Month");
		ConvertToDateText_Month_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToDateText_FunctionAddress, "Month");
		ConvertToDateText_Month_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToDateText_FunctionAddress, "Month", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToDateText_Day_PropertyAddress, ConvertToDateText_FunctionAddress, "Day");
		ConvertToDateText_Day_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToDateText_FunctionAddress, "Day");
		ConvertToDateText_Day_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToDateText_FunctionAddress, "Day", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToDateText_Hour_PropertyAddress, ConvertToDateText_FunctionAddress, "Hour");
		ConvertToDateText_Hour_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToDateText_FunctionAddress, "Hour");
		ConvertToDateText_Hour_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToDateText_FunctionAddress, "Hour", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToDateText_Minute_PropertyAddress, ConvertToDateText_FunctionAddress, "Minute");
		ConvertToDateText_Minute_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToDateText_FunctionAddress, "Minute");
		ConvertToDateText_Minute_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToDateText_FunctionAddress, "Minute", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToDateText_Second_PropertyAddress, ConvertToDateText_FunctionAddress, "Second");
		ConvertToDateText_Second_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToDateText_FunctionAddress, "Second");
		ConvertToDateText_Second_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToDateText_FunctionAddress, "Second", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToDateText_ReturnValue_PropertyAddress, ConvertToDateText_FunctionAddress, "ReturnValue");
		ConvertToDateText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToDateText_FunctionAddress, "ReturnValue");
		ConvertToDateText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToDateText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		ConvertToDateText_IsValid = ConvertToDateText_FunctionAddress != IntPtr.Zero && ConvertToDateText_Year_IsValid && ConvertToDateText_Month_IsValid && ConvertToDateText_Day_IsValid && ConvertToDateText_Hour_IsValid && ConvertToDateText_Minute_IsValid && ConvertToDateText_Second_IsValid && ConvertToDateText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:ConvertToDateText", ConvertToDateText_IsValid);
		ConstructUWidgetWithClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConstructUWidgetWithClass");
		ConstructUWidgetWithClass_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstructUWidgetWithClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConstructUWidgetWithClass_FromWidget_PropertyAddress, ConstructUWidgetWithClass_FunctionAddress, "FromWidget");
		ConstructUWidgetWithClass_FromWidget_Offset = NativeReflectionCached.GetPropertyOffset(ConstructUWidgetWithClass_FunctionAddress, "FromWidget");
		ConstructUWidgetWithClass_FromWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstructUWidgetWithClass_FunctionAddress, "FromWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConstructUWidgetWithClass_WidgetClass_PropertyAddress, ConstructUWidgetWithClass_FunctionAddress, "WidgetClass");
		ConstructUWidgetWithClass_WidgetClass_Offset = NativeReflectionCached.GetPropertyOffset(ConstructUWidgetWithClass_FunctionAddress, "WidgetClass");
		ConstructUWidgetWithClass_WidgetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstructUWidgetWithClass_FunctionAddress, "WidgetClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ConstructUWidgetWithClass_ReturnValue_PropertyAddress, ConstructUWidgetWithClass_FunctionAddress, "ReturnValue");
		ConstructUWidgetWithClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConstructUWidgetWithClass_FunctionAddress, "ReturnValue");
		ConstructUWidgetWithClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstructUWidgetWithClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ConstructUWidgetWithClass_IsValid = ConstructUWidgetWithClass_FunctionAddress != IntPtr.Zero && ConstructUWidgetWithClass_FromWidget_IsValid && ConstructUWidgetWithClass_WidgetClass_IsValid && ConstructUWidgetWithClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:ConstructUWidgetWithClass", ConstructUWidgetWithClass_IsValid);
		CloneUserWidget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CloneUserWidget");
		CloneUserWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(CloneUserWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CloneUserWidget_BaseWidget_PropertyAddress, CloneUserWidget_FunctionAddress, "BaseWidget");
		CloneUserWidget_BaseWidget_Offset = NativeReflectionCached.GetPropertyOffset(CloneUserWidget_FunctionAddress, "BaseWidget");
		CloneUserWidget_BaseWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(CloneUserWidget_FunctionAddress, "BaseWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CloneUserWidget_Name_PropertyAddress, CloneUserWidget_FunctionAddress, "Name");
		CloneUserWidget_Name_Offset = NativeReflectionCached.GetPropertyOffset(CloneUserWidget_FunctionAddress, "Name");
		CloneUserWidget_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(CloneUserWidget_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CloneUserWidget_ReturnValue_PropertyAddress, CloneUserWidget_FunctionAddress, "ReturnValue");
		CloneUserWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CloneUserWidget_FunctionAddress, "ReturnValue");
		CloneUserWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CloneUserWidget_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CloneUserWidget_IsValid = CloneUserWidget_FunctionAddress != IntPtr.Zero && CloneUserWidget_BaseWidget_IsValid && CloneUserWidget_Name_IsValid && CloneUserWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:CloneUserWidget", CloneUserWidget_IsValid);
		CalcImageTexture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalcImageTexture");
		CalcImageTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcImageTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalcImageTexture_InImage_PropertyAddress, CalcImageTexture_FunctionAddress, "InImage");
		CalcImageTexture_InImage_Offset = NativeReflectionCached.GetPropertyOffset(CalcImageTexture_FunctionAddress, "InImage");
		CalcImageTexture_InImage_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcImageTexture_FunctionAddress, "InImage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcImageTexture_OutColorArray_PropertyAddress, CalcImageTexture_FunctionAddress, "OutColorArray");
		CalcImageTexture_OutColorArray_Offset = NativeReflectionCached.GetPropertyOffset(CalcImageTexture_FunctionAddress, "OutColorArray");
		CalcImageTexture_OutColorArray_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcImageTexture_FunctionAddress, "OutColorArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcImageTexture_OutPosArray_PropertyAddress, CalcImageTexture_FunctionAddress, "OutPosArray");
		CalcImageTexture_OutPosArray_Offset = NativeReflectionCached.GetPropertyOffset(CalcImageTexture_FunctionAddress, "OutPosArray");
		CalcImageTexture_OutPosArray_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcImageTexture_FunctionAddress, "OutPosArray", Classes.FArrayProperty);
		CalcImageTexture_IsValid = CalcImageTexture_FunctionAddress != IntPtr.Zero && CalcImageTexture_InImage_IsValid && CalcImageTexture_OutColorArray_IsValid && CalcImageTexture_OutPosArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:CalcImageTexture", CalcImageTexture_IsValid);
		BindImageOnMouseDownEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BindImageOnMouseDownEvent");
		BindImageOnMouseDownEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BindImageOnMouseDownEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BindImageOnMouseDownEvent_Image_PropertyAddress, BindImageOnMouseDownEvent_FunctionAddress, "Image");
		BindImageOnMouseDownEvent_Image_Offset = NativeReflectionCached.GetPropertyOffset(BindImageOnMouseDownEvent_FunctionAddress, "Image");
		BindImageOnMouseDownEvent_Image_IsValid = NativeReflectionCached.ValidatePropertyClass(BindImageOnMouseDownEvent_FunctionAddress, "Image", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BindImageOnMouseDownEvent_TargetObj_PropertyAddress, BindImageOnMouseDownEvent_FunctionAddress, "TargetObj");
		BindImageOnMouseDownEvent_TargetObj_Offset = NativeReflectionCached.GetPropertyOffset(BindImageOnMouseDownEvent_FunctionAddress, "TargetObj");
		BindImageOnMouseDownEvent_TargetObj_IsValid = NativeReflectionCached.ValidatePropertyClass(BindImageOnMouseDownEvent_FunctionAddress, "TargetObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BindImageOnMouseDownEvent_Name_PropertyAddress, BindImageOnMouseDownEvent_FunctionAddress, "Name");
		BindImageOnMouseDownEvent_Name_Offset = NativeReflectionCached.GetPropertyOffset(BindImageOnMouseDownEvent_FunctionAddress, "Name");
		BindImageOnMouseDownEvent_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(BindImageOnMouseDownEvent_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BindImageOnMouseDownEvent_ReturnValue_PropertyAddress, BindImageOnMouseDownEvent_FunctionAddress, "ReturnValue");
		BindImageOnMouseDownEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BindImageOnMouseDownEvent_FunctionAddress, "ReturnValue");
		BindImageOnMouseDownEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BindImageOnMouseDownEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BindImageOnMouseDownEvent_IsValid = BindImageOnMouseDownEvent_FunctionAddress != IntPtr.Zero && BindImageOnMouseDownEvent_Image_IsValid && BindImageOnMouseDownEvent_TargetObj_IsValid && BindImageOnMouseDownEvent_Name_IsValid && BindImageOnMouseDownEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:BindImageOnMouseDownEvent", BindImageOnMouseDownEvent_IsValid);
		BindBorderOnMouseDownEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BindBorderOnMouseDownEvent");
		BindBorderOnMouseDownEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(BindBorderOnMouseDownEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BindBorderOnMouseDownEvent_Border_PropertyAddress, BindBorderOnMouseDownEvent_FunctionAddress, "Border");
		BindBorderOnMouseDownEvent_Border_Offset = NativeReflectionCached.GetPropertyOffset(BindBorderOnMouseDownEvent_FunctionAddress, "Border");
		BindBorderOnMouseDownEvent_Border_IsValid = NativeReflectionCached.ValidatePropertyClass(BindBorderOnMouseDownEvent_FunctionAddress, "Border", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BindBorderOnMouseDownEvent_TargetObj_PropertyAddress, BindBorderOnMouseDownEvent_FunctionAddress, "TargetObj");
		BindBorderOnMouseDownEvent_TargetObj_Offset = NativeReflectionCached.GetPropertyOffset(BindBorderOnMouseDownEvent_FunctionAddress, "TargetObj");
		BindBorderOnMouseDownEvent_TargetObj_IsValid = NativeReflectionCached.ValidatePropertyClass(BindBorderOnMouseDownEvent_FunctionAddress, "TargetObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BindBorderOnMouseDownEvent_Name_PropertyAddress, BindBorderOnMouseDownEvent_FunctionAddress, "Name");
		BindBorderOnMouseDownEvent_Name_Offset = NativeReflectionCached.GetPropertyOffset(BindBorderOnMouseDownEvent_FunctionAddress, "Name");
		BindBorderOnMouseDownEvent_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(BindBorderOnMouseDownEvent_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BindBorderOnMouseDownEvent_ReturnValue_PropertyAddress, BindBorderOnMouseDownEvent_FunctionAddress, "ReturnValue");
		BindBorderOnMouseDownEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BindBorderOnMouseDownEvent_FunctionAddress, "ReturnValue");
		BindBorderOnMouseDownEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BindBorderOnMouseDownEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BindBorderOnMouseDownEvent_IsValid = BindBorderOnMouseDownEvent_FunctionAddress != IntPtr.Zero && BindBorderOnMouseDownEvent_Border_IsValid && BindBorderOnMouseDownEvent_TargetObj_IsValid && BindBorderOnMouseDownEvent_Name_IsValid && BindBorderOnMouseDownEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:BindBorderOnMouseDownEvent", BindBorderOnMouseDownEvent_IsValid);
		AddUserWidgetAsSlateToViewport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddUserWidgetAsSlateToViewport");
		AddUserWidgetAsSlateToViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(AddUserWidgetAsSlateToViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddUserWidgetAsSlateToViewport_Widget_PropertyAddress, AddUserWidgetAsSlateToViewport_FunctionAddress, "Widget");
		AddUserWidgetAsSlateToViewport_Widget_Offset = NativeReflectionCached.GetPropertyOffset(AddUserWidgetAsSlateToViewport_FunctionAddress, "Widget");
		AddUserWidgetAsSlateToViewport_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUserWidgetAsSlateToViewport_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUserWidgetAsSlateToViewport_ZOrder_PropertyAddress, AddUserWidgetAsSlateToViewport_FunctionAddress, "ZOrder");
		AddUserWidgetAsSlateToViewport_ZOrder_Offset = NativeReflectionCached.GetPropertyOffset(AddUserWidgetAsSlateToViewport_FunctionAddress, "ZOrder");
		AddUserWidgetAsSlateToViewport_ZOrder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUserWidgetAsSlateToViewport_FunctionAddress, "ZOrder", Classes.FIntProperty);
		AddUserWidgetAsSlateToViewport_IsValid = AddUserWidgetAsSlateToViewport_FunctionAddress != IntPtr.Zero && AddUserWidgetAsSlateToViewport_Widget_IsValid && AddUserWidgetAsSlateToViewport_ZOrder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:AddUserWidgetAsSlateToViewport", AddUserWidgetAsSlateToViewport_IsValid);
		ActiveVirtualKeyboard_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ActiveVirtualKeyboard");
		ActiveVirtualKeyboard_ParamsSize = NativeReflection.GetFunctionParamsSize(ActiveVirtualKeyboard_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActiveVirtualKeyboard_IsActive_PropertyAddress, ActiveVirtualKeyboard_FunctionAddress, "IsActive");
		ActiveVirtualKeyboard_IsActive_Offset = NativeReflectionCached.GetPropertyOffset(ActiveVirtualKeyboard_FunctionAddress, "IsActive");
		ActiveVirtualKeyboard_IsActive_IsValid = NativeReflectionCached.ValidatePropertyClass(ActiveVirtualKeyboard_FunctionAddress, "IsActive", Classes.FBoolProperty);
		ActiveVirtualKeyboard_IsValid = ActiveVirtualKeyboard_FunctionAddress != IntPtr.Zero && ActiveVirtualKeyboard_IsActive_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_UMGFuncLib:ActiveVirtualKeyboard", ActiveVirtualKeyboard_IsValid);
	}
}
