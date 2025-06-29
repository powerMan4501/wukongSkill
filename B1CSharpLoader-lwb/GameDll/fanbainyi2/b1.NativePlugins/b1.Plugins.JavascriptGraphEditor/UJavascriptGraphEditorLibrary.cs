using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using b1.Plugins.JavascriptUMG;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.JavascriptGraphEditor;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptGraphEditorLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TryConnection_IsValid;

	private static IntPtr TryConnection_FunctionAddress;

	private static int TryConnection_ParamsSize;

	private static bool TryConnection_Schema_IsValid;

	private static FFieldAddress TryConnection_Schema_PropertyAddress;

	private static int TryConnection_Schema_Offset;

	private static bool TryConnection_A_IsValid;

	private static FFieldAddress TryConnection_A_PropertyAddress;

	private static int TryConnection_A_Offset;

	private static bool TryConnection_B_IsValid;

	private static FFieldAddress TryConnection_B_PropertyAddress;

	private static int TryConnection_B_Offset;

	private static bool SetPinInfo_IsValid;

	private static IntPtr SetPinInfo_FunctionAddress;

	private static int SetPinInfo_ParamsSize;

	private static bool SetPinInfo_A_IsValid;

	private static FFieldAddress SetPinInfo_A_PropertyAddress;

	private static int SetPinInfo_A_Offset;

	private static bool SetPinInfo_InPinName_IsValid;

	private static FFieldAddress SetPinInfo_InPinName_PropertyAddress;

	private static int SetPinInfo_InPinName_Offset;

	private static bool SetPinInfo_InPinToolTip_IsValid;

	private static FFieldAddress SetPinInfo_InPinToolTip_PropertyAddress;

	private static int SetPinInfo_InPinToolTip_Offset;

	private static bool SetPinHidden_IsValid;

	private static IntPtr SetPinHidden_FunctionAddress;

	private static int SetPinHidden_ParamsSize;

	private static bool SetPinHidden_A_IsValid;

	private static FFieldAddress SetPinHidden_A_PropertyAddress;

	private static int SetPinHidden_A_Offset;

	private static bool SetPinHidden_bHidden_IsValid;

	private static FFieldAddress SetPinHidden_bHidden_PropertyAddress;

	private static int SetPinHidden_bHidden_Offset;

	private static bool SetPinContainerType_IsValid;

	private static IntPtr SetPinContainerType_FunctionAddress;

	private static int SetPinContainerType_ParamsSize;

	private static bool SetPinContainerType_A_IsValid;

	private static FFieldAddress SetPinContainerType_A_PropertyAddress;

	private static int SetPinContainerType_A_Offset;

	private static bool SetPinContainerType_ContainerType_IsValid;

	private static FFieldAddress SetPinContainerType_ContainerType_PropertyAddress;

	private static int SetPinContainerType_ContainerType_Offset;

	private static bool SetParentPin_IsValid;

	private static IntPtr SetParentPin_FunctionAddress;

	private static int SetParentPin_ParamsSize;

	private static bool SetParentPin_A_IsValid;

	private static FFieldAddress SetParentPin_A_PropertyAddress;

	private static int SetParentPin_A_Offset;

	private static bool SetParentPin_Parent_IsValid;

	private static FFieldAddress SetParentPin_Parent_PropertyAddress;

	private static int SetParentPin_Parent_Offset;

	private static bool SetNodeMetaData_IsValid;

	private static IntPtr SetNodeMetaData_FunctionAddress;

	private static int SetNodeMetaData_ParamsSize;

	private static bool SetNodeMetaData_Schema_IsValid;

	private static FFieldAddress SetNodeMetaData_Schema_PropertyAddress;

	private static int SetNodeMetaData_Schema_Offset;

	private static bool SetNodeMetaData_Node_IsValid;

	private static FFieldAddress SetNodeMetaData_Node_PropertyAddress;

	private static int SetNodeMetaData_Node_Offset;

	private static bool SetNodeMetaData_KeyValue_IsValid;

	private static FFieldAddress SetNodeMetaData_KeyValue_PropertyAddress;

	private static int SetNodeMetaData_KeyValue_Offset;

	private static bool SetNodeMetaData_ReturnValue_IsValid;

	private static FFieldAddress SetNodeMetaData_ReturnValue_PropertyAddress;

	private static int SetNodeMetaData_ReturnValue_Offset;

	private static bool ResizeNode_IsValid;

	private static IntPtr ResizeNode_FunctionAddress;

	private static int ResizeNode_ParamsSize;

	private static bool ResizeNode_Node_IsValid;

	private static FFieldAddress ResizeNode_Node_PropertyAddress;

	private static int ResizeNode_Node_Offset;

	private static bool ResizeNode_NewSize_IsValid;

	private static FFieldAddress ResizeNode_NewSize_PropertyAddress;

	private static int ResizeNode_NewSize_Offset;

	private static bool RemovePinFromHoverSet_IsValid;

	private static IntPtr RemovePinFromHoverSet_FunctionAddress;

	private static int RemovePinFromHoverSet_ParamsSize;

	private static bool RemovePinFromHoverSet_InSlateNode_IsValid;

	private static FFieldAddress RemovePinFromHoverSet_InSlateNode_PropertyAddress;

	private static int RemovePinFromHoverSet_InSlateNode_Offset;

	private static bool RemovePinFromHoverSet_Pin_IsValid;

	private static FFieldAddress RemovePinFromHoverSet_Pin_PropertyAddress;

	private static int RemovePinFromHoverSet_Pin_Offset;

	private static bool NodeCreator_IsValid;

	private static IntPtr NodeCreator_FunctionAddress;

	private static int NodeCreator_ParamsSize;

	private static bool NodeCreator_Graph_IsValid;

	private static FFieldAddress NodeCreator_Graph_PropertyAddress;

	private static int NodeCreator_Graph_Offset;

	private static bool NodeCreator_bSelectNewNode_IsValid;

	private static FFieldAddress NodeCreator_bSelectNewNode_PropertyAddress;

	private static int NodeCreator_bSelectNewNode_Offset;

	private static bool NodeCreator_ReturnValue_IsValid;

	private static FFieldAddress NodeCreator_ReturnValue_PropertyAddress;

	private static int NodeCreator_ReturnValue_Offset;

	private static bool MakeRotatedBox_IsValid;

	private static IntPtr MakeRotatedBox_FunctionAddress;

	private static int MakeRotatedBox_ParamsSize;

	private static bool MakeRotatedBox_Container_IsValid;

	private static FFieldAddress MakeRotatedBox_Container_PropertyAddress;

	private static int MakeRotatedBox_Container_Offset;

	private static bool MakeRotatedBox_ArrowDrawPos_IsValid;

	private static FFieldAddress MakeRotatedBox_ArrowDrawPos_PropertyAddress;

	private static int MakeRotatedBox_ArrowDrawPos_Offset;

	private static bool MakeRotatedBox_AngleInRadians_IsValid;

	private static FFieldAddress MakeRotatedBox_AngleInRadians_PropertyAddress;

	private static int MakeRotatedBox_AngleInRadians_Offset;

	private static bool MakeRotatedBox_WireColor_IsValid;

	private static FFieldAddress MakeRotatedBox_WireColor_PropertyAddress;

	private static int MakeRotatedBox_WireColor_Offset;

	private static bool MakeLinkTo_IsValid;

	private static IntPtr MakeLinkTo_FunctionAddress;

	private static int MakeLinkTo_ParamsSize;

	private static bool MakeLinkTo_A_IsValid;

	private static FFieldAddress MakeLinkTo_A_PropertyAddress;

	private static int MakeLinkTo_A_Offset;

	private static bool MakeLinkTo_B_IsValid;

	private static FFieldAddress MakeLinkTo_B_PropertyAddress;

	private static int MakeLinkTo_B_Offset;

	private static bool IsValid_IsValid;

	private static IntPtr IsValid_FunctionAddress;

	private static int IsValid_ParamsSize;

	private static bool IsValid_A_IsValid;

	private static FFieldAddress IsValid_A_PropertyAddress;

	private static int IsValid_A_Offset;

	private static bool IsValid_ReturnValue_IsValid;

	private static FFieldAddress IsValid_ReturnValue_PropertyAddress;

	private static int IsValid_ReturnValue_Offset;

	private static bool IsPinHidden_IsValid;

	private static IntPtr IsPinHidden_FunctionAddress;

	private static int IsPinHidden_ParamsSize;

	private static bool IsPinHidden_A_IsValid;

	private static FFieldAddress IsPinHidden_A_PropertyAddress;

	private static int IsPinHidden_A_Offset;

	private static bool IsPinHidden_ReturnValue_IsValid;

	private static FFieldAddress IsPinHidden_ReturnValue_PropertyAddress;

	private static int IsPinHidden_ReturnValue_Offset;

	private static bool IsContainedHoveredPins_IsValid;

	private static IntPtr IsContainedHoveredPins_FunctionAddress;

	private static int IsContainedHoveredPins_ParamsSize;

	private static bool IsContainedHoveredPins_Container_IsValid;

	private static FFieldAddress IsContainedHoveredPins_Container_PropertyAddress;

	private static int IsContainedHoveredPins_Container_Offset;

	private static bool IsContainedHoveredPins_Pin_IsValid;

	private static FFieldAddress IsContainedHoveredPins_Pin_PropertyAddress;

	private static int IsContainedHoveredPins_Pin_Offset;

	private static bool IsContainedHoveredPins_ReturnValue_IsValid;

	private static FFieldAddress IsContainedHoveredPins_ReturnValue_PropertyAddress;

	private static int IsContainedHoveredPins_ReturnValue_Offset;

	private static bool GetSubPins_IsValid;

	private static IntPtr GetSubPins_FunctionAddress;

	private static int GetSubPins_ParamsSize;

	private static bool GetSubPins_A_IsValid;

	private static FFieldAddress GetSubPins_A_PropertyAddress;

	private static int GetSubPins_A_Offset;

	private static bool GetSubPins_ReturnValue_IsValid;

	private static FFieldAddress GetSubPins_ReturnValue_PropertyAddress;

	private static int GetSubPins_ReturnValue_Offset;

	private static bool GetPins_IsValid;

	private static IntPtr GetPins_FunctionAddress;

	private static int GetPins_ParamsSize;

	private static bool GetPins_Node_IsValid;

	private static FFieldAddress GetPins_Node_PropertyAddress;

	private static int GetPins_Node_Offset;

	private static bool GetPins_ReturnValue_IsValid;

	private static FFieldAddress GetPins_ReturnValue_PropertyAddress;

	private static int GetPins_ReturnValue_Offset;

	private static bool GetPinName_IsValid;

	private static IntPtr GetPinName_FunctionAddress;

	private static int GetPinName_ParamsSize;

	private static bool GetPinName_A_IsValid;

	private static FFieldAddress GetPinName_A_PropertyAddress;

	private static int GetPinName_A_Offset;

	private static bool GetPinName_ReturnValue_IsValid;

	private static FFieldAddress GetPinName_ReturnValue_PropertyAddress;

	private static int GetPinName_ReturnValue_Offset;

	private static bool GetPinIndex_IsValid;

	private static IntPtr GetPinIndex_FunctionAddress;

	private static int GetPinIndex_ParamsSize;

	private static bool GetPinIndex_A_IsValid;

	private static FFieldAddress GetPinIndex_A_PropertyAddress;

	private static int GetPinIndex_A_Offset;

	private static bool GetPinIndex_ReturnValue_IsValid;

	private static FFieldAddress GetPinIndex_ReturnValue_PropertyAddress;

	private static int GetPinIndex_ReturnValue_Offset;

	private static bool GetPinGUID_IsValid;

	private static IntPtr GetPinGUID_FunctionAddress;

	private static int GetPinGUID_ParamsSize;

	private static bool GetPinGUID_A_IsValid;

	private static FFieldAddress GetPinGUID_A_PropertyAddress;

	private static int GetPinGUID_A_Offset;

	private static bool GetPinGUID_ReturnValue_IsValid;

	private static FFieldAddress GetPinGUID_ReturnValue_PropertyAddress;

	private static int GetPinGUID_ReturnValue_Offset;

	private static bool GetPinContainerType_IsValid;

	private static IntPtr GetPinContainerType_FunctionAddress;

	private static int GetPinContainerType_ParamsSize;

	private static bool GetPinContainerType_A_IsValid;

	private static FFieldAddress GetPinContainerType_A_PropertyAddress;

	private static int GetPinContainerType_A_Offset;

	private static bool GetPinContainerType_ReturnValue_IsValid;

	private static FFieldAddress GetPinContainerType_ReturnValue_PropertyAddress;

	private static int GetPinContainerType_ReturnValue_Offset;

	private static bool GetParentPin_IsValid;

	private static IntPtr GetParentPin_FunctionAddress;

	private static int GetParentPin_ParamsSize;

	private static bool GetParentPin_A_IsValid;

	private static FFieldAddress GetParentPin_A_PropertyAddress;

	private static int GetParentPin_A_Offset;

	private static bool GetParentPin_ReturnValue_IsValid;

	private static FFieldAddress GetParentPin_ReturnValue_PropertyAddress;

	private static int GetParentPin_ReturnValue_Offset;

	private static bool GetOwningNode_IsValid;

	private static IntPtr GetOwningNode_FunctionAddress;

	private static int GetOwningNode_ParamsSize;

	private static bool GetOwningNode_A_IsValid;

	private static FFieldAddress GetOwningNode_A_PropertyAddress;

	private static int GetOwningNode_A_Offset;

	private static bool GetOwningNode_ReturnValue_IsValid;

	private static FFieldAddress GetOwningNode_ReturnValue_PropertyAddress;

	private static int GetOwningNode_ReturnValue_Offset;

	private static bool GetOwnerPanel_IsValid;

	private static IntPtr GetOwnerPanel_FunctionAddress;

	private static int GetOwnerPanel_ParamsSize;

	private static bool GetOwnerPanel_Node_IsValid;

	private static FFieldAddress GetOwnerPanel_Node_PropertyAddress;

	private static int GetOwnerPanel_Node_Offset;

	private static bool GetOwnerPanel_ReturnValue_IsValid;

	private static FFieldAddress GetOwnerPanel_ReturnValue_PropertyAddress;

	private static int GetOwnerPanel_ReturnValue_Offset;

	private static bool GetOutputPinWidget_IsValid;

	private static IntPtr GetOutputPinWidget_FunctionAddress;

	private static int GetOutputPinWidget_ParamsSize;

	private static bool GetOutputPinWidget_Container_IsValid;

	private static FFieldAddress GetOutputPinWidget_Container_PropertyAddress;

	private static int GetOutputPinWidget_Container_Offset;

	private static bool GetOutputPinWidget_ReturnValue_IsValid;

	private static FFieldAddress GetOutputPinWidget_ReturnValue_PropertyAddress;

	private static int GetOutputPinWidget_ReturnValue_Offset;

	private static bool GetLinkedTo_IsValid;

	private static IntPtr GetLinkedTo_FunctionAddress;

	private static int GetLinkedTo_ParamsSize;

	private static bool GetLinkedTo_A_IsValid;

	private static FFieldAddress GetLinkedTo_A_PropertyAddress;

	private static int GetLinkedTo_A_Offset;

	private static bool GetLinkedTo_ReturnValue_IsValid;

	private static FFieldAddress GetLinkedTo_ReturnValue_PropertyAddress;

	private static int GetLinkedTo_ReturnValue_Offset;

	private static bool GetLinkedPinNum_IsValid;

	private static IntPtr GetLinkedPinNum_FunctionAddress;

	private static int GetLinkedPinNum_ParamsSize;

	private static bool GetLinkedPinNum_A_IsValid;

	private static FFieldAddress GetLinkedPinNum_A_PropertyAddress;

	private static int GetLinkedPinNum_A_Offset;

	private static bool GetLinkedPinNum_ReturnValue_IsValid;

	private static FFieldAddress GetLinkedPinNum_ReturnValue_PropertyAddress;

	private static int GetLinkedPinNum_ReturnValue_Offset;

	private static bool GetHorveredPinNum_IsValid;

	private static IntPtr GetHorveredPinNum_FunctionAddress;

	private static int GetHorveredPinNum_ParamsSize;

	private static bool GetHorveredPinNum_Container_IsValid;

	private static FFieldAddress GetHorveredPinNum_Container_PropertyAddress;

	private static int GetHorveredPinNum_Container_Offset;

	private static bool GetHorveredPinNum_ReturnValue_IsValid;

	private static FFieldAddress GetHorveredPinNum_ReturnValue_PropertyAddress;

	private static int GetHorveredPinNum_ReturnValue_Offset;

	private static bool GetDirection_IsValid;

	private static IntPtr GetDirection_FunctionAddress;

	private static int GetDirection_ParamsSize;

	private static bool GetDirection_A_IsValid;

	private static FFieldAddress GetDirection_A_PropertyAddress;

	private static int GetDirection_A_Offset;

	private static bool GetDirection_ReturnValue_IsValid;

	private static FFieldAddress GetDirection_ReturnValue_PropertyAddress;

	private static int GetDirection_ReturnValue_Offset;

	private static bool GetDefaultObject_IsValid;

	private static IntPtr GetDefaultObject_FunctionAddress;

	private static int GetDefaultObject_ParamsSize;

	private static bool GetDefaultObject_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultObject_ReturnValue_PropertyAddress;

	private static int GetDefaultObject_ReturnValue_Offset;

	private static bool GetArrangedNodes_IsValid;

	private static IntPtr GetArrangedNodes_FunctionAddress;

	private static int GetArrangedNodes_ParamsSize;

	private static bool GetArrangedNodes_Container_IsValid;

	private static FFieldAddress GetArrangedNodes_Container_PropertyAddress;

	private static int GetArrangedNodes_Container_Offset;

	private static bool GetArrangedNodes_Node_IsValid;

	private static FFieldAddress GetArrangedNodes_Node_PropertyAddress;

	private static int GetArrangedNodes_Node_Offset;

	private static bool GetArrangedNodes_ReturnValue_IsValid;

	private static FFieldAddress GetArrangedNodes_ReturnValue_PropertyAddress;

	private static int GetArrangedNodes_ReturnValue_Offset;

	private static bool FindPinToPinWidgetMap_IsValid;

	private static IntPtr FindPinToPinWidgetMap_FunctionAddress;

	private static int FindPinToPinWidgetMap_ParamsSize;

	private static bool FindPinToPinWidgetMap_Container_IsValid;

	private static FFieldAddress FindPinToPinWidgetMap_Container_PropertyAddress;

	private static int FindPinToPinWidgetMap_Container_Offset;

	private static bool FindPinToPinWidgetMap_Pin_IsValid;

	private static FFieldAddress FindPinToPinWidgetMap_Pin_PropertyAddress;

	private static int FindPinToPinWidgetMap_Pin_Offset;

	private static bool FindPinToPinWidgetMap_ReturnValue_IsValid;

	private static FFieldAddress FindPinToPinWidgetMap_ReturnValue_PropertyAddress;

	private static int FindPinToPinWidgetMap_ReturnValue_Offset;

	private static bool FindPinGeometries_IsValid;

	private static IntPtr FindPinGeometries_FunctionAddress;

	private static int FindPinGeometries_ParamsSize;

	private static bool FindPinGeometries_Container_IsValid;

	private static FFieldAddress FindPinGeometries_Container_PropertyAddress;

	private static int FindPinGeometries_Container_Offset;

	private static bool FindPinGeometries_PinWidget_IsValid;

	private static FFieldAddress FindPinGeometries_PinWidget_PropertyAddress;

	private static int FindPinGeometries_PinWidget_Offset;

	private static bool FindPinGeometries_ReturnValue_IsValid;

	private static FFieldAddress FindPinGeometries_ReturnValue_PropertyAddress;

	private static int FindPinGeometries_ReturnValue_Offset;

	private static bool FindPin_IsValid;

	private static IntPtr FindPin_FunctionAddress;

	private static int FindPin_ParamsSize;

	private static bool FindPin_Node_IsValid;

	private static FFieldAddress FindPin_Node_PropertyAddress;

	private static int FindPin_Node_Offset;

	private static bool FindPin_PinName_IsValid;

	private static FFieldAddress FindPin_PinName_PropertyAddress;

	private static int FindPin_PinName_Offset;

	private static bool FindPin_Direction_IsValid;

	private static FFieldAddress FindPin_Direction_PropertyAddress;

	private static int FindPin_Direction_Offset;

	private static bool FindPin_ReturnValue_IsValid;

	private static FFieldAddress FindPin_ReturnValue_PropertyAddress;

	private static int FindPin_ReturnValue_Offset;

	private static bool FindClosestPointOnGeom_IsValid;

	private static IntPtr FindClosestPointOnGeom_FunctionAddress;

	private static int FindClosestPointOnGeom_ParamsSize;

	private static bool FindClosestPointOnGeom_Geom_IsValid;

	private static FFieldAddress FindClosestPointOnGeom_Geom_PropertyAddress;

	private static int FindClosestPointOnGeom_Geom_Offset;

	private static bool FindClosestPointOnGeom_TestPoint_IsValid;

	private static FFieldAddress FindClosestPointOnGeom_TestPoint_PropertyAddress;

	private static int FindClosestPointOnGeom_TestPoint_Offset;

	private static bool FindClosestPointOnGeom_ReturnValue_IsValid;

	private static FFieldAddress FindClosestPointOnGeom_ReturnValue_PropertyAddress;

	private static int FindClosestPointOnGeom_ReturnValue_Offset;

	private static bool Finalize_IsValid;

	private static IntPtr Finalize_FunctionAddress;

	private static int Finalize_ParamsSize;

	private static bool Finalize_Creator_IsValid;

	private static FFieldAddress Finalize_Creator_PropertyAddress;

	private static int Finalize_Creator_Offset;

	private static bool DrawSplineWithArrow_IsValid;

	private static IntPtr DrawSplineWithArrow_FunctionAddress;

	private static int DrawSplineWithArrow_ParamsSize;

	private static bool DrawSplineWithArrow_Container_IsValid;

	private static FFieldAddress DrawSplineWithArrow_Container_PropertyAddress;

	private static int DrawSplineWithArrow_Container_Offset;

	private static bool DrawSplineWithArrow_StartAnchorPoint_IsValid;

	private static FFieldAddress DrawSplineWithArrow_StartAnchorPoint_PropertyAddress;

	private static int DrawSplineWithArrow_StartAnchorPoint_Offset;

	private static bool DrawSplineWithArrow_EndAnchorPoint_IsValid;

	private static FFieldAddress DrawSplineWithArrow_EndAnchorPoint_PropertyAddress;

	private static int DrawSplineWithArrow_EndAnchorPoint_Offset;

	private static bool DrawSplineWithArrow_Params_IsValid;

	private static FFieldAddress DrawSplineWithArrow_Params_PropertyAddress;

	private static int DrawSplineWithArrow_Params_Offset;

	private static bool DrawConnection_IsValid;

	private static IntPtr DrawConnection_FunctionAddress;

	private static int DrawConnection_ParamsSize;

	private static bool DrawConnection_Container_IsValid;

	private static FFieldAddress DrawConnection_Container_PropertyAddress;

	private static int DrawConnection_Container_Offset;

	private static bool DrawConnection_A_IsValid;

	private static FFieldAddress DrawConnection_A_PropertyAddress;

	private static int DrawConnection_A_Offset;

	private static bool DrawConnection_B_IsValid;

	private static FFieldAddress DrawConnection_B_PropertyAddress;

	private static int DrawConnection_B_Offset;

	private static bool DrawConnection_Params_IsValid;

	private static FFieldAddress DrawConnection_Params_PropertyAddress;

	private static int DrawConnection_Params_Offset;

	private static bool DetermineWiringStyle_IsValid;

	private static IntPtr DetermineWiringStyle_FunctionAddress;

	private static int DetermineWiringStyle_ParamsSize;

	private static bool DetermineWiringStyle_Container_IsValid;

	private static FFieldAddress DetermineWiringStyle_Container_PropertyAddress;

	private static int DetermineWiringStyle_Container_Offset;

	private static bool DetermineWiringStyle_OutputPin_IsValid;

	private static FFieldAddress DetermineWiringStyle_OutputPin_PropertyAddress;

	private static int DetermineWiringStyle_OutputPin_Offset;

	private static bool DetermineWiringStyle_InputPin_IsValid;

	private static FFieldAddress DetermineWiringStyle_InputPin_PropertyAddress;

	private static int DetermineWiringStyle_InputPin_Offset;

	private static bool DetermineWiringStyle_Params_IsValid;

	private static FFieldAddress DetermineWiringStyle_Params_PropertyAddress;

	private static int DetermineWiringStyle_Params_Offset;

	private static bool DestroyNode_IsValid;

	private static IntPtr DestroyNode_FunctionAddress;

	private static int DestroyNode_ParamsSize;

	private static bool DestroyNode_Node_IsValid;

	private static FFieldAddress DestroyNode_Node_PropertyAddress;

	private static int DestroyNode_Node_Offset;

	private static bool CustomNodeCreator_IsValid;

	private static IntPtr CustomNodeCreator_FunctionAddress;

	private static int CustomNodeCreator_ParamsSize;

	private static bool CustomNodeCreator_Graph_IsValid;

	private static FFieldAddress CustomNodeCreator_Graph_PropertyAddress;

	private static int CustomNodeCreator_Graph_Offset;

	private static bool CustomNodeCreator_ReturnValue_IsValid;

	private static FFieldAddress CustomNodeCreator_ReturnValue_PropertyAddress;

	private static int CustomNodeCreator_ReturnValue_Offset;

	private static bool CenterOf_IsValid;

	private static IntPtr CenterOf_FunctionAddress;

	private static int CenterOf_ParamsSize;

	private static bool CenterOf_Geom_IsValid;

	private static FFieldAddress CenterOf_Geom_PropertyAddress;

	private static int CenterOf_Geom_Offset;

	private static bool CenterOf_ReturnValue_IsValid;

	private static FFieldAddress CenterOf_ReturnValue_PropertyAddress;

	private static int CenterOf_ReturnValue_Offset;

	private static bool CanUserDeleteNode_IsValid;

	private static IntPtr CanUserDeleteNode_FunctionAddress;

	private static int CanUserDeleteNode_ParamsSize;

	private static bool CanUserDeleteNode_Node_IsValid;

	private static FFieldAddress CanUserDeleteNode_Node_PropertyAddress;

	private static int CanUserDeleteNode_Node_Offset;

	private static bool CanUserDeleteNode_ReturnValue_IsValid;

	private static FFieldAddress CanUserDeleteNode_ReturnValue_PropertyAddress;

	private static int CanUserDeleteNode_ReturnValue_Offset;

	private static bool CanDuplicateNode_IsValid;

	private static IntPtr CanDuplicateNode_FunctionAddress;

	private static int CanDuplicateNode_ParamsSize;

	private static bool CanDuplicateNode_Node_IsValid;

	private static FFieldAddress CanDuplicateNode_Node_PropertyAddress;

	private static int CanDuplicateNode_Node_Offset;

	private static bool CanDuplicateNode_ReturnValue_IsValid;

	private static FFieldAddress CanDuplicateNode_ReturnValue_PropertyAddress;

	private static int CanDuplicateNode_ReturnValue_Offset;

	private static bool BreakLinkTo_IsValid;

	private static IntPtr BreakLinkTo_FunctionAddress;

	private static int BreakLinkTo_ParamsSize;

	private static bool BreakLinkTo_A_IsValid;

	private static FFieldAddress BreakLinkTo_A_PropertyAddress;

	private static int BreakLinkTo_A_Offset;

	private static bool BreakLinkTo_B_IsValid;

	private static FFieldAddress BreakLinkTo_B_PropertyAddress;

	private static int BreakLinkTo_B_Offset;

	private static bool BreakAllPinLinks_IsValid;

	private static IntPtr BreakAllPinLinks_FunctionAddress;

	private static int BreakAllPinLinks_ParamsSize;

	private static bool BreakAllPinLinks_A_IsValid;

	private static FFieldAddress BreakAllPinLinks_A_PropertyAddress;

	private static int BreakAllPinLinks_A_Offset;

	private static bool AutowireNewNode_IsValid;

	private static IntPtr AutowireNewNode_FunctionAddress;

	private static int AutowireNewNode_ParamsSize;

	private static bool AutowireNewNode_Node_IsValid;

	private static FFieldAddress AutowireNewNode_Node_PropertyAddress;

	private static int AutowireNewNode_Node_Offset;

	private static bool AutowireNewNode_FromPin_IsValid;

	private static FFieldAddress AutowireNewNode_FromPin_PropertyAddress;

	private static int AutowireNewNode_FromPin_Offset;

	private static bool ApplyHoverDeemphasis_IsValid;

	private static IntPtr ApplyHoverDeemphasis_FunctionAddress;

	private static int ApplyHoverDeemphasis_ParamsSize;

	private static bool ApplyHoverDeemphasis_Container_IsValid;

	private static FFieldAddress ApplyHoverDeemphasis_Container_PropertyAddress;

	private static int ApplyHoverDeemphasis_Container_Offset;

	private static bool ApplyHoverDeemphasis_OutputPin_IsValid;

	private static FFieldAddress ApplyHoverDeemphasis_OutputPin_PropertyAddress;

	private static int ApplyHoverDeemphasis_OutputPin_Offset;

	private static bool ApplyHoverDeemphasis_InputPin_IsValid;

	private static FFieldAddress ApplyHoverDeemphasis_InputPin_PropertyAddress;

	private static int ApplyHoverDeemphasis_InputPin_Offset;

	private static bool ApplyHoverDeemphasis_Thickness_IsValid;

	private static FFieldAddress ApplyHoverDeemphasis_Thickness_PropertyAddress;

	private static int ApplyHoverDeemphasis_Thickness_Offset;

	private static bool ApplyHoverDeemphasis_WireColor_IsValid;

	private static FFieldAddress ApplyHoverDeemphasis_WireColor_PropertyAddress;

	private static int ApplyHoverDeemphasis_WireColor_Offset;

	private static bool AddPinToHoverSet_IsValid;

	private static IntPtr AddPinToHoverSet_FunctionAddress;

	private static int AddPinToHoverSet_ParamsSize;

	private static bool AddPinToHoverSet_InSlateEdNode_IsValid;

	private static FFieldAddress AddPinToHoverSet_InSlateEdNode_PropertyAddress;

	private static int AddPinToHoverSet_InSlateEdNode_Offset;

	private static bool AddPinToHoverSet_Pin_IsValid;

	private static FFieldAddress AddPinToHoverSet_Pin_PropertyAddress;

	private static int AddPinToHoverSet_Pin_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:TryConnection")]
	public unsafe static void TryConnection(UEdGraphSchema Schema, FJavascriptEdGraphPin A, FJavascriptEdGraphPin B)
	{
		if (!TryConnection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:TryConnection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryConnection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryConnection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEdGraphSchema>.ToNative(IntPtr.Add(intPtr, TryConnection_Schema_Offset), 0, TryConnection_Schema_PropertyAddress.Address, Schema);
		NativeReflection.InitializeValue_InContainer(TryConnection_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, TryConnection_A_Offset), 0, TryConnection_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(TryConnection_B_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, TryConnection_B_Offset), 0, TryConnection_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TryConnection_FunctionAddress, intPtr, TryConnection_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetPinInfo")]
	public unsafe static void SetPinInfo(FJavascriptEdGraphPin A, FName InPinName, string InPinToolTip)
	{
		if (!SetPinInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetPinInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPinInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPinInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetPinInfo_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, SetPinInfo_A_Offset), 0, SetPinInfo_A_PropertyAddress.Address, A);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetPinInfo_InPinName_Offset), 0, SetPinInfo_InPinName_PropertyAddress.Address, InPinName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetPinInfo_InPinToolTip_Offset), 0, SetPinInfo_InPinToolTip_PropertyAddress.Address, InPinToolTip);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPinInfo_FunctionAddress, intPtr, SetPinInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPinInfo_InPinToolTip_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetPinHidden")]
	public unsafe static void SetPinHidden(FJavascriptEdGraphPin A, bool bHidden)
	{
		if (!SetPinHidden_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetPinHidden");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPinHidden_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPinHidden_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetPinHidden_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, SetPinHidden_A_Offset), 0, SetPinHidden_A_PropertyAddress.Address, A);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPinHidden_bHidden_Offset), 0, SetPinHidden_bHidden_PropertyAddress.Address, bHidden);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPinHidden_FunctionAddress, intPtr, SetPinHidden_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetPinContainerType")]
	public unsafe static void SetPinContainerType(FJavascriptEdGraphPin A, EJavascriptPinContainerType ContainerType)
	{
		if (!SetPinContainerType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetPinContainerType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPinContainerType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPinContainerType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetPinContainerType_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, SetPinContainerType_A_Offset), 0, SetPinContainerType_A_PropertyAddress.Address, A);
		EnumMarshaler<EJavascriptPinContainerType>.ToNative(IntPtr.Add(intPtr, SetPinContainerType_ContainerType_Offset), 0, SetPinContainerType_ContainerType_PropertyAddress.Address, ContainerType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPinContainerType_FunctionAddress, intPtr, SetPinContainerType_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetParentPin")]
	public unsafe static void SetParentPin(FJavascriptEdGraphPin A, FJavascriptEdGraphPin Parent)
	{
		if (!SetParentPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetParentPin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParentPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParentPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetParentPin_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, SetParentPin_A_Offset), 0, SetParentPin_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(SetParentPin_Parent_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, SetParentPin_Parent_Offset), 0, SetParentPin_Parent_PropertyAddress.Address, Parent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetParentPin_FunctionAddress, intPtr, SetParentPin_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetNodeMetaData")]
	public unsafe static bool SetNodeMetaData(UEdGraphSchema Schema, UEdGraphNode Node, FName KeyValue)
	{
		if (!SetNodeMetaData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetNodeMetaData");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeMetaData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeMetaData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEdGraphSchema>.ToNative(IntPtr.Add(intPtr, SetNodeMetaData_Schema_Offset), 0, SetNodeMetaData_Schema_PropertyAddress.Address, Schema);
		UObjectMarshaler<UEdGraphNode>.ToNative(IntPtr.Add(intPtr, SetNodeMetaData_Node_Offset), 0, SetNodeMetaData_Node_PropertyAddress.Address, Node);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNodeMetaData_KeyValue_Offset), 0, SetNodeMetaData_KeyValue_PropertyAddress.Address, KeyValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNodeMetaData_FunctionAddress, intPtr, SetNodeMetaData_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodeMetaData_ReturnValue_Offset), 0, SetNodeMetaData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:ResizeNode")]
	public unsafe static void ResizeNode(UEdGraphNode Node, FVector2D NewSize)
	{
		if (!ResizeNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:ResizeNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResizeNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResizeNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEdGraphNode>.ToNative(IntPtr.Add(intPtr, ResizeNode_Node_Offset), 0, ResizeNode_Node_PropertyAddress.Address, Node);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, ResizeNode_NewSize_Offset), 0, ResizeNode_NewSize_PropertyAddress.Address, NewSize);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResizeNode_FunctionAddress, intPtr, ResizeNode_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:RemovePinFromHoverSet")]
	public unsafe static void RemovePinFromHoverSet(FJavascriptSlateEdNode InSlateNode, FJavascriptEdGraphPin Pin)
	{
		if (!RemovePinFromHoverSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:RemovePinFromHoverSet");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemovePinFromHoverSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemovePinFromHoverSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemovePinFromHoverSet_InSlateNode_PropertyAddress.Address, intPtr);
		FJavascriptSlateEdNode.ToNative(IntPtr.Add(intPtr, RemovePinFromHoverSet_InSlateNode_Offset), 0, RemovePinFromHoverSet_InSlateNode_PropertyAddress.Address, InSlateNode);
		NativeReflection.InitializeValue_InContainer(RemovePinFromHoverSet_Pin_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, RemovePinFromHoverSet_Pin_Offset), 0, RemovePinFromHoverSet_Pin_PropertyAddress.Address, Pin);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemovePinFromHoverSet_FunctionAddress, intPtr, RemovePinFromHoverSet_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:NodeCreator")]
	public unsafe static FJavascriptNodeCreator NodeCreator(UJavascriptGraphEdGraph Graph, bool bSelectNewNode = true)
	{
		if (!NodeCreator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:NodeCreator");
			return default(FJavascriptNodeCreator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(NodeCreator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NodeCreator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UJavascriptGraphEdGraph>.ToNative(IntPtr.Add(intPtr, NodeCreator_Graph_Offset), 0, NodeCreator_Graph_PropertyAddress.Address, Graph);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, NodeCreator_bSelectNewNode_Offset), 0, NodeCreator_bSelectNewNode_PropertyAddress.Address, bSelectNewNode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NodeCreator_FunctionAddress, intPtr, NodeCreator_ParamsSize);
		FJavascriptNodeCreator result = FJavascriptNodeCreator.FromNative(IntPtr.Add(intPtr, NodeCreator_ReturnValue_Offset), 0, NodeCreator_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(NodeCreator_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:MakeRotatedBox")]
	public unsafe static void MakeRotatedBox(FJavascriptGraphConnectionDrawingPolicyContainer Container, FVector2D ArrowDrawPos, float AngleInRadians, FLinearColor WireColor)
	{
		if (!MakeRotatedBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:MakeRotatedBox");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeRotatedBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeRotatedBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MakeRotatedBox_Container_PropertyAddress.Address, intPtr);
		FJavascriptGraphConnectionDrawingPolicyContainer.ToNative(IntPtr.Add(intPtr, MakeRotatedBox_Container_Offset), 0, MakeRotatedBox_Container_PropertyAddress.Address, Container);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, MakeRotatedBox_ArrowDrawPos_Offset), 0, MakeRotatedBox_ArrowDrawPos_PropertyAddress.Address, ArrowDrawPos);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeRotatedBox_AngleInRadians_Offset), 0, MakeRotatedBox_AngleInRadians_PropertyAddress.Address, AngleInRadians);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, MakeRotatedBox_WireColor_Offset), 0, MakeRotatedBox_WireColor_PropertyAddress.Address, WireColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeRotatedBox_FunctionAddress, intPtr, MakeRotatedBox_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:MakeLinkTo")]
	public unsafe static void MakeLinkTo(FJavascriptEdGraphPin A, FJavascriptEdGraphPin B)
	{
		if (!MakeLinkTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:MakeLinkTo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeLinkTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeLinkTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MakeLinkTo_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, MakeLinkTo_A_Offset), 0, MakeLinkTo_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(MakeLinkTo_B_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, MakeLinkTo_B_Offset), 0, MakeLinkTo_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeLinkTo_FunctionAddress, intPtr, MakeLinkTo_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:IsValid")]
	public unsafe static bool IsValid(FJavascriptEdGraphPin A)
	{
		if (!IsValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:IsValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsValid_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, IsValid_A_Offset), 0, IsValid_A_PropertyAddress.Address, A);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValid_FunctionAddress, intPtr, IsValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValid_ReturnValue_Offset), 0, IsValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:IsPinHidden")]
	public unsafe static bool IsPinHidden(FJavascriptEdGraphPin A)
	{
		if (!IsPinHidden_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:IsPinHidden");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPinHidden_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPinHidden_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsPinHidden_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, IsPinHidden_A_Offset), 0, IsPinHidden_A_PropertyAddress.Address, A);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsPinHidden_FunctionAddress, intPtr, IsPinHidden_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPinHidden_ReturnValue_Offset), 0, IsPinHidden_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:IsContainedHoveredPins")]
	public unsafe static bool IsContainedHoveredPins(FJavascriptGraphConnectionDrawingPolicyContainer Container, FJavascriptEdGraphPin Pin)
	{
		if (!IsContainedHoveredPins_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:IsContainedHoveredPins");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsContainedHoveredPins_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsContainedHoveredPins_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsContainedHoveredPins_Container_PropertyAddress.Address, intPtr);
		FJavascriptGraphConnectionDrawingPolicyContainer.ToNative(IntPtr.Add(intPtr, IsContainedHoveredPins_Container_Offset), 0, IsContainedHoveredPins_Container_PropertyAddress.Address, Container);
		NativeReflection.InitializeValue_InContainer(IsContainedHoveredPins_Pin_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, IsContainedHoveredPins_Pin_Offset), 0, IsContainedHoveredPins_Pin_PropertyAddress.Address, Pin);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsContainedHoveredPins_FunctionAddress, intPtr, IsContainedHoveredPins_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsContainedHoveredPins_ReturnValue_Offset), 0, IsContainedHoveredPins_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetSubPins")]
	public unsafe static List<FJavascriptEdGraphPin> GetSubPins(FJavascriptEdGraphPin A)
	{
		if (!GetSubPins_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetSubPins");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSubPins_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSubPins_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetSubPins_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, GetSubPins_A_Offset), 0, GetSubPins_A_PropertyAddress.Address, A);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSubPins_FunctionAddress, intPtr, GetSubPins_ParamsSize);
		List<FJavascriptEdGraphPin> result = new TArrayCopyMarshaler<FJavascriptEdGraphPin>(1, GetSubPins_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FJavascriptEdGraphPin, FJavascriptEdGraphPin>.FromNative, CachedMarshalingDelegates<FJavascriptEdGraphPin, FJavascriptEdGraphPin>.ToNative).FromNative(IntPtr.Add(intPtr, GetSubPins_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSubPins_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPins")]
	public unsafe static List<FJavascriptEdGraphPin> GetPins(UEdGraphNode Node)
	{
		if (!GetPins_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPins");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPins_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPins_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEdGraphNode>.ToNative(IntPtr.Add(intPtr, GetPins_Node_Offset), 0, GetPins_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPins_FunctionAddress, intPtr, GetPins_ParamsSize);
		List<FJavascriptEdGraphPin> result = new TArrayCopyMarshaler<FJavascriptEdGraphPin>(1, GetPins_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FJavascriptEdGraphPin, FJavascriptEdGraphPin>.FromNative, CachedMarshalingDelegates<FJavascriptEdGraphPin, FJavascriptEdGraphPin>.ToNative).FromNative(IntPtr.Add(intPtr, GetPins_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetPins_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPinName")]
	public unsafe static FName GetPinName(FJavascriptEdGraphPin A)
	{
		if (!GetPinName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPinName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPinName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPinName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPinName_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, GetPinName_A_Offset), 0, GetPinName_A_PropertyAddress.Address, A);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPinName_FunctionAddress, intPtr, GetPinName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetPinName_ReturnValue_Offset), 0, GetPinName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPinIndex")]
	public unsafe static int GetPinIndex(FJavascriptEdGraphPin A)
	{
		if (!GetPinIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPinIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPinIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPinIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPinIndex_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, GetPinIndex_A_Offset), 0, GetPinIndex_A_PropertyAddress.Address, A);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPinIndex_FunctionAddress, intPtr, GetPinIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPinIndex_ReturnValue_Offset), 0, GetPinIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPinGUID")]
	public unsafe static Guid GetPinGUID(FJavascriptEdGraphPin A)
	{
		if (!GetPinGUID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPinGUID");
			return default(Guid);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPinGUID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPinGUID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPinGUID_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, GetPinGUID_A_Offset), 0, GetPinGUID_A_PropertyAddress.Address, A);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPinGUID_FunctionAddress, intPtr, GetPinGUID_ParamsSize);
		return BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(intPtr, GetPinGUID_ReturnValue_Offset), 0, GetPinGUID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPinContainerType")]
	public unsafe static EJavascriptPinContainerType GetPinContainerType(FJavascriptEdGraphPin A)
	{
		if (!GetPinContainerType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPinContainerType");
			return EJavascriptPinContainerType.None;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPinContainerType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPinContainerType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPinContainerType_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, GetPinContainerType_A_Offset), 0, GetPinContainerType_A_PropertyAddress.Address, A);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPinContainerType_FunctionAddress, intPtr, GetPinContainerType_ParamsSize);
		return EnumMarshaler<EJavascriptPinContainerType>.FromNative(IntPtr.Add(intPtr, GetPinContainerType_ReturnValue_Offset), 0, GetPinContainerType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetParentPin")]
	public unsafe static FJavascriptEdGraphPin GetParentPin(FJavascriptEdGraphPin A)
	{
		if (!GetParentPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetParentPin");
			return default(FJavascriptEdGraphPin);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParentPin_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, GetParentPin_A_Offset), 0, GetParentPin_A_PropertyAddress.Address, A);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetParentPin_FunctionAddress, intPtr, GetParentPin_ParamsSize);
		return FJavascriptEdGraphPin.FromNative(IntPtr.Add(intPtr, GetParentPin_ReturnValue_Offset), 0, GetParentPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetOwningNode")]
	public unsafe static UEdGraphNode GetOwningNode(FJavascriptEdGraphPin A)
	{
		if (!GetOwningNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetOwningNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwningNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwningNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetOwningNode_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, GetOwningNode_A_Offset), 0, GetOwningNode_A_PropertyAddress.Address, A);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOwningNode_FunctionAddress, intPtr, GetOwningNode_ParamsSize);
		return UObjectMarshaler<UEdGraphNode>.FromNative(IntPtr.Add(intPtr, GetOwningNode_ReturnValue_Offset), 0, GetOwningNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetOwnerPanel")]
	public unsafe static FJavascriptSlateWidget GetOwnerPanel(UJavascriptGraphEdNode Node)
	{
		if (!GetOwnerPanel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetOwnerPanel");
			return default(FJavascriptSlateWidget);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwnerPanel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwnerPanel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UJavascriptGraphEdNode>.ToNative(IntPtr.Add(intPtr, GetOwnerPanel_Node_Offset), 0, GetOwnerPanel_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOwnerPanel_FunctionAddress, intPtr, GetOwnerPanel_ParamsSize);
		FJavascriptSlateWidget result = FJavascriptSlateWidget.FromNative(IntPtr.Add(intPtr, GetOwnerPanel_ReturnValue_Offset), 0, GetOwnerPanel_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetOwnerPanel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetOutputPinWidget")]
	public unsafe static FJavascriptPinWidget GetOutputPinWidget(FJavascriptDetermineLinkGeometryContainer Container)
	{
		if (!GetOutputPinWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetOutputPinWidget");
			return default(FJavascriptPinWidget);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOutputPinWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOutputPinWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetOutputPinWidget_Container_PropertyAddress.Address, intPtr);
		FJavascriptDetermineLinkGeometryContainer.ToNative(IntPtr.Add(intPtr, GetOutputPinWidget_Container_Offset), 0, GetOutputPinWidget_Container_PropertyAddress.Address, Container);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOutputPinWidget_FunctionAddress, intPtr, GetOutputPinWidget_ParamsSize);
		return BlittableTypeMarshaler<FJavascriptPinWidget>.FromNative(IntPtr.Add(intPtr, GetOutputPinWidget_ReturnValue_Offset), 0, GetOutputPinWidget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetLinkedTo")]
	public unsafe static List<FJavascriptEdGraphPin> GetLinkedTo(FJavascriptEdGraphPin A)
	{
		if (!GetLinkedTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetLinkedTo");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinkedTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinkedTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLinkedTo_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, GetLinkedTo_A_Offset), 0, GetLinkedTo_A_PropertyAddress.Address, A);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLinkedTo_FunctionAddress, intPtr, GetLinkedTo_ParamsSize);
		List<FJavascriptEdGraphPin> result = new TArrayCopyMarshaler<FJavascriptEdGraphPin>(1, GetLinkedTo_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FJavascriptEdGraphPin, FJavascriptEdGraphPin>.FromNative, CachedMarshalingDelegates<FJavascriptEdGraphPin, FJavascriptEdGraphPin>.ToNative).FromNative(IntPtr.Add(intPtr, GetLinkedTo_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLinkedTo_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetLinkedPinNum")]
	public unsafe static int GetLinkedPinNum(FJavascriptEdGraphPin A)
	{
		if (!GetLinkedPinNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetLinkedPinNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinkedPinNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinkedPinNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLinkedPinNum_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, GetLinkedPinNum_A_Offset), 0, GetLinkedPinNum_A_PropertyAddress.Address, A);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLinkedPinNum_FunctionAddress, intPtr, GetLinkedPinNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLinkedPinNum_ReturnValue_Offset), 0, GetLinkedPinNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetHorveredPinNum")]
	public unsafe static int GetHorveredPinNum(FJavascriptGraphConnectionDrawingPolicyContainer Container)
	{
		if (!GetHorveredPinNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetHorveredPinNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHorveredPinNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHorveredPinNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetHorveredPinNum_Container_PropertyAddress.Address, intPtr);
		FJavascriptGraphConnectionDrawingPolicyContainer.ToNative(IntPtr.Add(intPtr, GetHorveredPinNum_Container_Offset), 0, GetHorveredPinNum_Container_PropertyAddress.Address, Container);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetHorveredPinNum_FunctionAddress, intPtr, GetHorveredPinNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetHorveredPinNum_ReturnValue_Offset), 0, GetHorveredPinNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetDirection")]
	public unsafe static EEdGraphPinDirection GetDirection(FJavascriptEdGraphPin A)
	{
		if (!GetDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetDirection");
			return EEdGraphPinDirection.EGPD_Input;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetDirection_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, GetDirection_A_Offset), 0, GetDirection_A_PropertyAddress.Address, A);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDirection_FunctionAddress, intPtr, GetDirection_ParamsSize);
		return EnumMarshaler<EEdGraphPinDirection>.FromNative(IntPtr.Add(intPtr, GetDirection_ReturnValue_Offset), 0, GetDirection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetDefaultObject")]
	public unsafe static FJavascriptEdGraphPin GetDefaultObject()
	{
		if (!GetDefaultObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetDefaultObject");
			return default(FJavascriptEdGraphPin);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDefaultObject_FunctionAddress, intPtr, GetDefaultObject_ParamsSize);
		return FJavascriptEdGraphPin.FromNative(IntPtr.Add(intPtr, GetDefaultObject_ReturnValue_Offset), 0, GetDefaultObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetArrangedNodes")]
	public unsafe static FJavascriptArrangedWidget GetArrangedNodes(FJavascriptDetermineLinkGeometryContainer Container, UEdGraphNode Node)
	{
		if (!GetArrangedNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetArrangedNodes");
			return default(FJavascriptArrangedWidget);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetArrangedNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetArrangedNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetArrangedNodes_Container_PropertyAddress.Address, intPtr);
		FJavascriptDetermineLinkGeometryContainer.ToNative(IntPtr.Add(intPtr, GetArrangedNodes_Container_Offset), 0, GetArrangedNodes_Container_PropertyAddress.Address, Container);
		UObjectMarshaler<UEdGraphNode>.ToNative(IntPtr.Add(intPtr, GetArrangedNodes_Node_Offset), 0, GetArrangedNodes_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetArrangedNodes_FunctionAddress, intPtr, GetArrangedNodes_ParamsSize);
		return FJavascriptArrangedWidget.FromNative(IntPtr.Add(intPtr, GetArrangedNodes_ReturnValue_Offset), 0, GetArrangedNodes_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:FindPinToPinWidgetMap")]
	public unsafe static FJavascriptPinWidget FindPinToPinWidgetMap(FJavascriptDetermineLinkGeometryContainer Container, FJavascriptEdGraphPin Pin)
	{
		if (!FindPinToPinWidgetMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:FindPinToPinWidgetMap");
			return default(FJavascriptPinWidget);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindPinToPinWidgetMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindPinToPinWidgetMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FindPinToPinWidgetMap_Container_PropertyAddress.Address, intPtr);
		FJavascriptDetermineLinkGeometryContainer.ToNative(IntPtr.Add(intPtr, FindPinToPinWidgetMap_Container_Offset), 0, FindPinToPinWidgetMap_Container_PropertyAddress.Address, Container);
		NativeReflection.InitializeValue_InContainer(FindPinToPinWidgetMap_Pin_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, FindPinToPinWidgetMap_Pin_Offset), 0, FindPinToPinWidgetMap_Pin_PropertyAddress.Address, Pin);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindPinToPinWidgetMap_FunctionAddress, intPtr, FindPinToPinWidgetMap_ParamsSize);
		return BlittableTypeMarshaler<FJavascriptPinWidget>.FromNative(IntPtr.Add(intPtr, FindPinToPinWidgetMap_ReturnValue_Offset), 0, FindPinToPinWidgetMap_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:FindPinGeometries")]
	public unsafe static FJavascriptArrangedWidget FindPinGeometries(FJavascriptDetermineLinkGeometryContainer Container, FJavascriptPinWidget PinWidget)
	{
		if (!FindPinGeometries_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:FindPinGeometries");
			return default(FJavascriptArrangedWidget);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindPinGeometries_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindPinGeometries_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FindPinGeometries_Container_PropertyAddress.Address, intPtr);
		FJavascriptDetermineLinkGeometryContainer.ToNative(IntPtr.Add(intPtr, FindPinGeometries_Container_Offset), 0, FindPinGeometries_Container_PropertyAddress.Address, Container);
		BlittableTypeMarshaler<FJavascriptPinWidget>.ToNative(IntPtr.Add(intPtr, FindPinGeometries_PinWidget_Offset), 0, FindPinGeometries_PinWidget_PropertyAddress.Address, PinWidget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindPinGeometries_FunctionAddress, intPtr, FindPinGeometries_ParamsSize);
		return FJavascriptArrangedWidget.FromNative(IntPtr.Add(intPtr, FindPinGeometries_ReturnValue_Offset), 0, FindPinGeometries_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:FindPin")]
	public unsafe static FJavascriptEdGraphPin FindPin(UEdGraphNode Node, string PinName, EEdGraphPinDirection Direction)
	{
		if (!FindPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:FindPin");
			return default(FJavascriptEdGraphPin);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEdGraphNode>.ToNative(IntPtr.Add(intPtr, FindPin_Node_Offset), 0, FindPin_Node_PropertyAddress.Address, Node);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindPin_PinName_Offset), 0, FindPin_PinName_PropertyAddress.Address, PinName);
		EnumMarshaler<EEdGraphPinDirection>.ToNative(IntPtr.Add(intPtr, FindPin_Direction_Offset), 0, FindPin_Direction_PropertyAddress.Address, Direction);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindPin_FunctionAddress, intPtr, FindPin_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindPin_PinName_PropertyAddress.Address, intPtr);
		return FJavascriptEdGraphPin.FromNative(IntPtr.Add(intPtr, FindPin_ReturnValue_Offset), 0, FindPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:FindClosestPointOnGeom")]
	public unsafe static FVector2D FindClosestPointOnGeom(FGeometry Geom, FVector2D TestPoint)
	{
		if (!FindClosestPointOnGeom_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:FindClosestPointOnGeom");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindClosestPointOnGeom_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindClosestPointOnGeom_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FindClosestPointOnGeom_Geom_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, FindClosestPointOnGeom_Geom_Offset), 0, FindClosestPointOnGeom_Geom_PropertyAddress.Address, Geom);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, FindClosestPointOnGeom_TestPoint_Offset), 0, FindClosestPointOnGeom_TestPoint_PropertyAddress.Address, TestPoint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindClosestPointOnGeom_FunctionAddress, intPtr, FindClosestPointOnGeom_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, FindClosestPointOnGeom_ReturnValue_Offset), 0, FindClosestPointOnGeom_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:Finalize")]
	public unsafe static void Finalize(out FJavascriptNodeCreator Creator)
	{
		if (!Finalize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:Finalize");
			Creator = default(FJavascriptNodeCreator);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Finalize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Finalize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Finalize_Creator_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Finalize_FunctionAddress, intPtr, Finalize_ParamsSize);
		Creator = FJavascriptNodeCreator.FromNative(IntPtr.Add(intPtr, Finalize_Creator_Offset), 0, Finalize_Creator_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Finalize_Creator_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:DrawSplineWithArrow")]
	public unsafe static void DrawSplineWithArrow(FJavascriptGraphConnectionDrawingPolicyContainer Container, FVector2D StartAnchorPoint, FVector2D EndAnchorPoint, FJavascriptConnectionParams Params)
	{
		if (!DrawSplineWithArrow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:DrawSplineWithArrow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawSplineWithArrow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawSplineWithArrow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DrawSplineWithArrow_Container_PropertyAddress.Address, intPtr);
		FJavascriptGraphConnectionDrawingPolicyContainer.ToNative(IntPtr.Add(intPtr, DrawSplineWithArrow_Container_Offset), 0, DrawSplineWithArrow_Container_PropertyAddress.Address, Container);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawSplineWithArrow_StartAnchorPoint_Offset), 0, DrawSplineWithArrow_StartAnchorPoint_PropertyAddress.Address, StartAnchorPoint);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawSplineWithArrow_EndAnchorPoint_Offset), 0, DrawSplineWithArrow_EndAnchorPoint_PropertyAddress.Address, EndAnchorPoint);
		NativeReflection.InitializeValue_InContainer(DrawSplineWithArrow_Params_PropertyAddress.Address, intPtr);
		FJavascriptConnectionParams.ToNative(IntPtr.Add(intPtr, DrawSplineWithArrow_Params_Offset), 0, DrawSplineWithArrow_Params_PropertyAddress.Address, Params);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawSplineWithArrow_FunctionAddress, intPtr, DrawSplineWithArrow_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:DrawConnection")]
	public unsafe static void DrawConnection(FJavascriptGraphConnectionDrawingPolicyContainer Container, FVector2D A, FVector2D B, FJavascriptConnectionParams Params)
	{
		if (!DrawConnection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:DrawConnection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawConnection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawConnection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DrawConnection_Container_PropertyAddress.Address, intPtr);
		FJavascriptGraphConnectionDrawingPolicyContainer.ToNative(IntPtr.Add(intPtr, DrawConnection_Container_Offset), 0, DrawConnection_Container_PropertyAddress.Address, Container);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawConnection_A_Offset), 0, DrawConnection_A_PropertyAddress.Address, A);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DrawConnection_B_Offset), 0, DrawConnection_B_PropertyAddress.Address, B);
		NativeReflection.InitializeValue_InContainer(DrawConnection_Params_PropertyAddress.Address, intPtr);
		FJavascriptConnectionParams.ToNative(IntPtr.Add(intPtr, DrawConnection_Params_Offset), 0, DrawConnection_Params_PropertyAddress.Address, Params);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawConnection_FunctionAddress, intPtr, DrawConnection_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:DetermineWiringStyle")]
	public unsafe static void DetermineWiringStyle(FJavascriptGraphConnectionDrawingPolicyContainer Container, FJavascriptEdGraphPin OutputPin, FJavascriptEdGraphPin InputPin, out FJavascriptConnectionParams Params)
	{
		if (!DetermineWiringStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:DetermineWiringStyle");
			Params = default(FJavascriptConnectionParams);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DetermineWiringStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DetermineWiringStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DetermineWiringStyle_Container_PropertyAddress.Address, intPtr);
		FJavascriptGraphConnectionDrawingPolicyContainer.ToNative(IntPtr.Add(intPtr, DetermineWiringStyle_Container_Offset), 0, DetermineWiringStyle_Container_PropertyAddress.Address, Container);
		NativeReflection.InitializeValue_InContainer(DetermineWiringStyle_OutputPin_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, DetermineWiringStyle_OutputPin_Offset), 0, DetermineWiringStyle_OutputPin_PropertyAddress.Address, OutputPin);
		NativeReflection.InitializeValue_InContainer(DetermineWiringStyle_InputPin_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, DetermineWiringStyle_InputPin_Offset), 0, DetermineWiringStyle_InputPin_PropertyAddress.Address, InputPin);
		NativeReflection.InitializeValue_InContainer(DetermineWiringStyle_Params_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DetermineWiringStyle_FunctionAddress, intPtr, DetermineWiringStyle_ParamsSize);
		Params = FJavascriptConnectionParams.FromNative(IntPtr.Add(intPtr, DetermineWiringStyle_Params_Offset), 0, DetermineWiringStyle_Params_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:DestroyNode")]
	public unsafe static void DestroyNode(UEdGraphNode Node)
	{
		if (!DestroyNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:DestroyNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestroyNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestroyNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEdGraphNode>.ToNative(IntPtr.Add(intPtr, DestroyNode_Node_Offset), 0, DestroyNode_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DestroyNode_FunctionAddress, intPtr, DestroyNode_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:CustomNodeCreator")]
	public unsafe static FJavascriptNodeCreator CustomNodeCreator(UJavascriptGraphEdGraph Graph)
	{
		if (!CustomNodeCreator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:CustomNodeCreator");
			return default(FJavascriptNodeCreator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CustomNodeCreator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CustomNodeCreator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UJavascriptGraphEdGraph>.ToNative(IntPtr.Add(intPtr, CustomNodeCreator_Graph_Offset), 0, CustomNodeCreator_Graph_PropertyAddress.Address, Graph);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CustomNodeCreator_FunctionAddress, intPtr, CustomNodeCreator_ParamsSize);
		FJavascriptNodeCreator result = FJavascriptNodeCreator.FromNative(IntPtr.Add(intPtr, CustomNodeCreator_ReturnValue_Offset), 0, CustomNodeCreator_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CustomNodeCreator_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:CenterOf")]
	public unsafe static FVector2D CenterOf(FGeometry Geom)
	{
		if (!CenterOf_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:CenterOf");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CenterOf_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CenterOf_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CenterOf_Geom_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, CenterOf_Geom_Offset), 0, CenterOf_Geom_PropertyAddress.Address, Geom);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CenterOf_FunctionAddress, intPtr, CenterOf_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, CenterOf_ReturnValue_Offset), 0, CenterOf_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:CanUserDeleteNode")]
	public unsafe static bool CanUserDeleteNode(UEdGraphNode Node)
	{
		if (!CanUserDeleteNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:CanUserDeleteNode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanUserDeleteNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanUserDeleteNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEdGraphNode>.ToNative(IntPtr.Add(intPtr, CanUserDeleteNode_Node_Offset), 0, CanUserDeleteNode_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CanUserDeleteNode_FunctionAddress, intPtr, CanUserDeleteNode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanUserDeleteNode_ReturnValue_Offset), 0, CanUserDeleteNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:CanDuplicateNode")]
	public unsafe static bool CanDuplicateNode(UEdGraphNode Node)
	{
		if (!CanDuplicateNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:CanDuplicateNode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanDuplicateNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanDuplicateNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEdGraphNode>.ToNative(IntPtr.Add(intPtr, CanDuplicateNode_Node_Offset), 0, CanDuplicateNode_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CanDuplicateNode_FunctionAddress, intPtr, CanDuplicateNode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanDuplicateNode_ReturnValue_Offset), 0, CanDuplicateNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:BreakLinkTo")]
	public unsafe static void BreakLinkTo(FJavascriptEdGraphPin A, FJavascriptEdGraphPin B)
	{
		if (!BreakLinkTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:BreakLinkTo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BreakLinkTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BreakLinkTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(BreakLinkTo_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, BreakLinkTo_A_Offset), 0, BreakLinkTo_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(BreakLinkTo_B_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, BreakLinkTo_B_Offset), 0, BreakLinkTo_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BreakLinkTo_FunctionAddress, intPtr, BreakLinkTo_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:BreakAllPinLinks")]
	public unsafe static void BreakAllPinLinks(FJavascriptEdGraphPin A)
	{
		if (!BreakAllPinLinks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:BreakAllPinLinks");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BreakAllPinLinks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BreakAllPinLinks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(BreakAllPinLinks_A_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, BreakAllPinLinks_A_Offset), 0, BreakAllPinLinks_A_PropertyAddress.Address, A);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BreakAllPinLinks_FunctionAddress, intPtr, BreakAllPinLinks_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:AutowireNewNode")]
	public unsafe static void AutowireNewNode(UEdGraphNode Node, FJavascriptEdGraphPin FromPin)
	{
		if (!AutowireNewNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:AutowireNewNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AutowireNewNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AutowireNewNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UEdGraphNode>.ToNative(IntPtr.Add(intPtr, AutowireNewNode_Node_Offset), 0, AutowireNewNode_Node_PropertyAddress.Address, Node);
		NativeReflection.InitializeValue_InContainer(AutowireNewNode_FromPin_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, AutowireNewNode_FromPin_Offset), 0, AutowireNewNode_FromPin_PropertyAddress.Address, FromPin);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AutowireNewNode_FunctionAddress, intPtr, AutowireNewNode_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:ApplyHoverDeemphasis")]
	public unsafe static void ApplyHoverDeemphasis(FJavascriptGraphConnectionDrawingPolicyContainer Container, FJavascriptEdGraphPin OutputPin, FJavascriptEdGraphPin InputPin, float Thickness, FLinearColor WireColor)
	{
		if (!ApplyHoverDeemphasis_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:ApplyHoverDeemphasis");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyHoverDeemphasis_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyHoverDeemphasis_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ApplyHoverDeemphasis_Container_PropertyAddress.Address, intPtr);
		FJavascriptGraphConnectionDrawingPolicyContainer.ToNative(IntPtr.Add(intPtr, ApplyHoverDeemphasis_Container_Offset), 0, ApplyHoverDeemphasis_Container_PropertyAddress.Address, Container);
		NativeReflection.InitializeValue_InContainer(ApplyHoverDeemphasis_OutputPin_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, ApplyHoverDeemphasis_OutputPin_Offset), 0, ApplyHoverDeemphasis_OutputPin_PropertyAddress.Address, OutputPin);
		NativeReflection.InitializeValue_InContainer(ApplyHoverDeemphasis_InputPin_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, ApplyHoverDeemphasis_InputPin_Offset), 0, ApplyHoverDeemphasis_InputPin_PropertyAddress.Address, InputPin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyHoverDeemphasis_Thickness_Offset), 0, ApplyHoverDeemphasis_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, ApplyHoverDeemphasis_WireColor_Offset), 0, ApplyHoverDeemphasis_WireColor_PropertyAddress.Address, WireColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyHoverDeemphasis_FunctionAddress, intPtr, ApplyHoverDeemphasis_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:AddPinToHoverSet")]
	public unsafe static void AddPinToHoverSet(FJavascriptSlateEdNode InSlateEdNode, FJavascriptEdGraphPin Pin)
	{
		if (!AddPinToHoverSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:AddPinToHoverSet");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddPinToHoverSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddPinToHoverSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddPinToHoverSet_InSlateEdNode_PropertyAddress.Address, intPtr);
		FJavascriptSlateEdNode.ToNative(IntPtr.Add(intPtr, AddPinToHoverSet_InSlateEdNode_Offset), 0, AddPinToHoverSet_InSlateEdNode_PropertyAddress.Address, InSlateEdNode);
		NativeReflection.InitializeValue_InContainer(AddPinToHoverSet_Pin_PropertyAddress.Address, intPtr);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(intPtr, AddPinToHoverSet_Pin_Offset), 0, AddPinToHoverSet_Pin_PropertyAddress.Address, Pin);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddPinToHoverSet_FunctionAddress, intPtr, AddPinToHoverSet_ParamsSize);
	}

	static UJavascriptGraphEditorLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptGraphEditorLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptGraphEditorLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary");
		TryConnection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TryConnection");
		TryConnection_ParamsSize = NativeReflection.GetFunctionParamsSize(TryConnection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryConnection_Schema_PropertyAddress, TryConnection_FunctionAddress, "Schema");
		TryConnection_Schema_Offset = NativeReflectionCached.GetPropertyOffset(TryConnection_FunctionAddress, "Schema");
		TryConnection_Schema_IsValid = NativeReflectionCached.ValidatePropertyClass(TryConnection_FunctionAddress, "Schema", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TryConnection_A_PropertyAddress, TryConnection_FunctionAddress, "A");
		TryConnection_A_Offset = NativeReflectionCached.GetPropertyOffset(TryConnection_FunctionAddress, "A");
		TryConnection_A_IsValid = NativeReflectionCached.ValidatePropertyClass(TryConnection_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TryConnection_B_PropertyAddress, TryConnection_FunctionAddress, "B");
		TryConnection_B_Offset = NativeReflectionCached.GetPropertyOffset(TryConnection_FunctionAddress, "B");
		TryConnection_B_IsValid = NativeReflectionCached.ValidatePropertyClass(TryConnection_FunctionAddress, "B", Classes.FStructProperty);
		TryConnection_IsValid = TryConnection_FunctionAddress != IntPtr.Zero && TryConnection_Schema_IsValid && TryConnection_A_IsValid && TryConnection_B_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:TryConnection", TryConnection_IsValid);
		SetPinInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPinInfo");
		SetPinInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPinInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPinInfo_A_PropertyAddress, SetPinInfo_FunctionAddress, "A");
		SetPinInfo_A_Offset = NativeReflectionCached.GetPropertyOffset(SetPinInfo_FunctionAddress, "A");
		SetPinInfo_A_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinInfo_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinInfo_InPinName_PropertyAddress, SetPinInfo_FunctionAddress, "InPinName");
		SetPinInfo_InPinName_Offset = NativeReflectionCached.GetPropertyOffset(SetPinInfo_FunctionAddress, "InPinName");
		SetPinInfo_InPinName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinInfo_FunctionAddress, "InPinName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinInfo_InPinToolTip_PropertyAddress, SetPinInfo_FunctionAddress, "InPinToolTip");
		SetPinInfo_InPinToolTip_Offset = NativeReflectionCached.GetPropertyOffset(SetPinInfo_FunctionAddress, "InPinToolTip");
		SetPinInfo_InPinToolTip_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinInfo_FunctionAddress, "InPinToolTip", Classes.FStrProperty);
		SetPinInfo_IsValid = SetPinInfo_FunctionAddress != IntPtr.Zero && SetPinInfo_A_IsValid && SetPinInfo_InPinName_IsValid && SetPinInfo_InPinToolTip_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetPinInfo", SetPinInfo_IsValid);
		SetPinHidden_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPinHidden");
		SetPinHidden_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPinHidden_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPinHidden_A_PropertyAddress, SetPinHidden_FunctionAddress, "A");
		SetPinHidden_A_Offset = NativeReflectionCached.GetPropertyOffset(SetPinHidden_FunctionAddress, "A");
		SetPinHidden_A_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinHidden_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinHidden_bHidden_PropertyAddress, SetPinHidden_FunctionAddress, "bHidden");
		SetPinHidden_bHidden_Offset = NativeReflectionCached.GetPropertyOffset(SetPinHidden_FunctionAddress, "bHidden");
		SetPinHidden_bHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinHidden_FunctionAddress, "bHidden", Classes.FBoolProperty);
		SetPinHidden_IsValid = SetPinHidden_FunctionAddress != IntPtr.Zero && SetPinHidden_A_IsValid && SetPinHidden_bHidden_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetPinHidden", SetPinHidden_IsValid);
		SetPinContainerType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPinContainerType");
		SetPinContainerType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPinContainerType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPinContainerType_A_PropertyAddress, SetPinContainerType_FunctionAddress, "A");
		SetPinContainerType_A_Offset = NativeReflectionCached.GetPropertyOffset(SetPinContainerType_FunctionAddress, "A");
		SetPinContainerType_A_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinContainerType_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinContainerType_ContainerType_PropertyAddress, SetPinContainerType_FunctionAddress, "ContainerType");
		SetPinContainerType_ContainerType_Offset = NativeReflectionCached.GetPropertyOffset(SetPinContainerType_FunctionAddress, "ContainerType");
		SetPinContainerType_ContainerType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinContainerType_FunctionAddress, "ContainerType", Classes.FByteProperty);
		SetPinContainerType_IsValid = SetPinContainerType_FunctionAddress != IntPtr.Zero && SetPinContainerType_A_IsValid && SetPinContainerType_ContainerType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetPinContainerType", SetPinContainerType_IsValid);
		SetParentPin_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetParentPin");
		SetParentPin_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParentPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParentPin_A_PropertyAddress, SetParentPin_FunctionAddress, "A");
		SetParentPin_A_Offset = NativeReflectionCached.GetPropertyOffset(SetParentPin_FunctionAddress, "A");
		SetParentPin_A_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentPin_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParentPin_Parent_PropertyAddress, SetParentPin_FunctionAddress, "Parent");
		SetParentPin_Parent_Offset = NativeReflectionCached.GetPropertyOffset(SetParentPin_FunctionAddress, "Parent");
		SetParentPin_Parent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentPin_FunctionAddress, "Parent", Classes.FStructProperty);
		SetParentPin_IsValid = SetParentPin_FunctionAddress != IntPtr.Zero && SetParentPin_A_IsValid && SetParentPin_Parent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetParentPin", SetParentPin_IsValid);
		SetNodeMetaData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNodeMetaData");
		SetNodeMetaData_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeMetaData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeMetaData_Schema_PropertyAddress, SetNodeMetaData_FunctionAddress, "Schema");
		SetNodeMetaData_Schema_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeMetaData_FunctionAddress, "Schema");
		SetNodeMetaData_Schema_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeMetaData_FunctionAddress, "Schema", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeMetaData_Node_PropertyAddress, SetNodeMetaData_FunctionAddress, "Node");
		SetNodeMetaData_Node_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeMetaData_FunctionAddress, "Node");
		SetNodeMetaData_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeMetaData_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeMetaData_KeyValue_PropertyAddress, SetNodeMetaData_FunctionAddress, "KeyValue");
		SetNodeMetaData_KeyValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeMetaData_FunctionAddress, "KeyValue");
		SetNodeMetaData_KeyValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeMetaData_FunctionAddress, "KeyValue", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeMetaData_ReturnValue_PropertyAddress, SetNodeMetaData_FunctionAddress, "ReturnValue");
		SetNodeMetaData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeMetaData_FunctionAddress, "ReturnValue");
		SetNodeMetaData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeMetaData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodeMetaData_IsValid = SetNodeMetaData_FunctionAddress != IntPtr.Zero && SetNodeMetaData_Schema_IsValid && SetNodeMetaData_Node_IsValid && SetNodeMetaData_KeyValue_IsValid && SetNodeMetaData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:SetNodeMetaData", SetNodeMetaData_IsValid);
		ResizeNode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResizeNode");
		ResizeNode_ParamsSize = NativeReflection.GetFunctionParamsSize(ResizeNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResizeNode_Node_PropertyAddress, ResizeNode_FunctionAddress, "Node");
		ResizeNode_Node_Offset = NativeReflectionCached.GetPropertyOffset(ResizeNode_FunctionAddress, "Node");
		ResizeNode_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(ResizeNode_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ResizeNode_NewSize_PropertyAddress, ResizeNode_FunctionAddress, "NewSize");
		ResizeNode_NewSize_Offset = NativeReflectionCached.GetPropertyOffset(ResizeNode_FunctionAddress, "NewSize");
		ResizeNode_NewSize_IsValid = NativeReflectionCached.ValidatePropertyClass(ResizeNode_FunctionAddress, "NewSize", Classes.FStructProperty);
		ResizeNode_IsValid = ResizeNode_FunctionAddress != IntPtr.Zero && ResizeNode_Node_IsValid && ResizeNode_NewSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:ResizeNode", ResizeNode_IsValid);
		RemovePinFromHoverSet_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemovePinFromHoverSet");
		RemovePinFromHoverSet_ParamsSize = NativeReflection.GetFunctionParamsSize(RemovePinFromHoverSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemovePinFromHoverSet_InSlateNode_PropertyAddress, RemovePinFromHoverSet_FunctionAddress, "InSlateNode");
		RemovePinFromHoverSet_InSlateNode_Offset = NativeReflectionCached.GetPropertyOffset(RemovePinFromHoverSet_FunctionAddress, "InSlateNode");
		RemovePinFromHoverSet_InSlateNode_IsValid = NativeReflectionCached.ValidatePropertyClass(RemovePinFromHoverSet_FunctionAddress, "InSlateNode", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemovePinFromHoverSet_Pin_PropertyAddress, RemovePinFromHoverSet_FunctionAddress, "Pin");
		RemovePinFromHoverSet_Pin_Offset = NativeReflectionCached.GetPropertyOffset(RemovePinFromHoverSet_FunctionAddress, "Pin");
		RemovePinFromHoverSet_Pin_IsValid = NativeReflectionCached.ValidatePropertyClass(RemovePinFromHoverSet_FunctionAddress, "Pin", Classes.FStructProperty);
		RemovePinFromHoverSet_IsValid = RemovePinFromHoverSet_FunctionAddress != IntPtr.Zero && RemovePinFromHoverSet_InSlateNode_IsValid && RemovePinFromHoverSet_Pin_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:RemovePinFromHoverSet", RemovePinFromHoverSet_IsValid);
		NodeCreator_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NodeCreator");
		NodeCreator_ParamsSize = NativeReflection.GetFunctionParamsSize(NodeCreator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NodeCreator_Graph_PropertyAddress, NodeCreator_FunctionAddress, "Graph");
		NodeCreator_Graph_Offset = NativeReflectionCached.GetPropertyOffset(NodeCreator_FunctionAddress, "Graph");
		NodeCreator_Graph_IsValid = NativeReflectionCached.ValidatePropertyClass(NodeCreator_FunctionAddress, "Graph", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NodeCreator_bSelectNewNode_PropertyAddress, NodeCreator_FunctionAddress, "bSelectNewNode");
		NodeCreator_bSelectNewNode_Offset = NativeReflectionCached.GetPropertyOffset(NodeCreator_FunctionAddress, "bSelectNewNode");
		NodeCreator_bSelectNewNode_IsValid = NativeReflectionCached.ValidatePropertyClass(NodeCreator_FunctionAddress, "bSelectNewNode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NodeCreator_ReturnValue_PropertyAddress, NodeCreator_FunctionAddress, "ReturnValue");
		NodeCreator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NodeCreator_FunctionAddress, "ReturnValue");
		NodeCreator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NodeCreator_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		NodeCreator_IsValid = NodeCreator_FunctionAddress != IntPtr.Zero && NodeCreator_Graph_IsValid && NodeCreator_bSelectNewNode_IsValid && NodeCreator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:NodeCreator", NodeCreator_IsValid);
		MakeRotatedBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeRotatedBox");
		MakeRotatedBox_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeRotatedBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeRotatedBox_Container_PropertyAddress, MakeRotatedBox_FunctionAddress, "Container");
		MakeRotatedBox_Container_Offset = NativeReflectionCached.GetPropertyOffset(MakeRotatedBox_FunctionAddress, "Container");
		MakeRotatedBox_Container_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeRotatedBox_FunctionAddress, "Container", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeRotatedBox_ArrowDrawPos_PropertyAddress, MakeRotatedBox_FunctionAddress, "ArrowDrawPos");
		MakeRotatedBox_ArrowDrawPos_Offset = NativeReflectionCached.GetPropertyOffset(MakeRotatedBox_FunctionAddress, "ArrowDrawPos");
		MakeRotatedBox_ArrowDrawPos_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeRotatedBox_FunctionAddress, "ArrowDrawPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeRotatedBox_AngleInRadians_PropertyAddress, MakeRotatedBox_FunctionAddress, "AngleInRadians");
		MakeRotatedBox_AngleInRadians_Offset = NativeReflectionCached.GetPropertyOffset(MakeRotatedBox_FunctionAddress, "AngleInRadians");
		MakeRotatedBox_AngleInRadians_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeRotatedBox_FunctionAddress, "AngleInRadians", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeRotatedBox_WireColor_PropertyAddress, MakeRotatedBox_FunctionAddress, "WireColor");
		MakeRotatedBox_WireColor_Offset = NativeReflectionCached.GetPropertyOffset(MakeRotatedBox_FunctionAddress, "WireColor");
		MakeRotatedBox_WireColor_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeRotatedBox_FunctionAddress, "WireColor", Classes.FStructProperty);
		MakeRotatedBox_IsValid = MakeRotatedBox_FunctionAddress != IntPtr.Zero && MakeRotatedBox_Container_IsValid && MakeRotatedBox_ArrowDrawPos_IsValid && MakeRotatedBox_AngleInRadians_IsValid && MakeRotatedBox_WireColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:MakeRotatedBox", MakeRotatedBox_IsValid);
		MakeLinkTo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeLinkTo");
		MakeLinkTo_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeLinkTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeLinkTo_A_PropertyAddress, MakeLinkTo_FunctionAddress, "A");
		MakeLinkTo_A_Offset = NativeReflectionCached.GetPropertyOffset(MakeLinkTo_FunctionAddress, "A");
		MakeLinkTo_A_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeLinkTo_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeLinkTo_B_PropertyAddress, MakeLinkTo_FunctionAddress, "B");
		MakeLinkTo_B_Offset = NativeReflectionCached.GetPropertyOffset(MakeLinkTo_FunctionAddress, "B");
		MakeLinkTo_B_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeLinkTo_FunctionAddress, "B", Classes.FStructProperty);
		MakeLinkTo_IsValid = MakeLinkTo_FunctionAddress != IntPtr.Zero && MakeLinkTo_A_IsValid && MakeLinkTo_B_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:MakeLinkTo", MakeLinkTo_IsValid);
		IsValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValid");
		IsValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValid_A_PropertyAddress, IsValid_FunctionAddress, "A");
		IsValid_A_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "A");
		IsValid_A_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_ReturnValue_PropertyAddress, IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValid_IsValid = IsValid_FunctionAddress != IntPtr.Zero && IsValid_A_IsValid && IsValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:IsValid", IsValid_IsValid);
		IsPinHidden_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPinHidden");
		IsPinHidden_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPinHidden_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPinHidden_A_PropertyAddress, IsPinHidden_FunctionAddress, "A");
		IsPinHidden_A_Offset = NativeReflectionCached.GetPropertyOffset(IsPinHidden_FunctionAddress, "A");
		IsPinHidden_A_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPinHidden_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPinHidden_ReturnValue_PropertyAddress, IsPinHidden_FunctionAddress, "ReturnValue");
		IsPinHidden_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPinHidden_FunctionAddress, "ReturnValue");
		IsPinHidden_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPinHidden_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPinHidden_IsValid = IsPinHidden_FunctionAddress != IntPtr.Zero && IsPinHidden_A_IsValid && IsPinHidden_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:IsPinHidden", IsPinHidden_IsValid);
		IsContainedHoveredPins_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsContainedHoveredPins");
		IsContainedHoveredPins_ParamsSize = NativeReflection.GetFunctionParamsSize(IsContainedHoveredPins_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsContainedHoveredPins_Container_PropertyAddress, IsContainedHoveredPins_FunctionAddress, "Container");
		IsContainedHoveredPins_Container_Offset = NativeReflectionCached.GetPropertyOffset(IsContainedHoveredPins_FunctionAddress, "Container");
		IsContainedHoveredPins_Container_IsValid = NativeReflectionCached.ValidatePropertyClass(IsContainedHoveredPins_FunctionAddress, "Container", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsContainedHoveredPins_Pin_PropertyAddress, IsContainedHoveredPins_FunctionAddress, "Pin");
		IsContainedHoveredPins_Pin_Offset = NativeReflectionCached.GetPropertyOffset(IsContainedHoveredPins_FunctionAddress, "Pin");
		IsContainedHoveredPins_Pin_IsValid = NativeReflectionCached.ValidatePropertyClass(IsContainedHoveredPins_FunctionAddress, "Pin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsContainedHoveredPins_ReturnValue_PropertyAddress, IsContainedHoveredPins_FunctionAddress, "ReturnValue");
		IsContainedHoveredPins_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsContainedHoveredPins_FunctionAddress, "ReturnValue");
		IsContainedHoveredPins_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsContainedHoveredPins_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsContainedHoveredPins_IsValid = IsContainedHoveredPins_FunctionAddress != IntPtr.Zero && IsContainedHoveredPins_Container_IsValid && IsContainedHoveredPins_Pin_IsValid && IsContainedHoveredPins_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:IsContainedHoveredPins", IsContainedHoveredPins_IsValid);
		GetSubPins_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSubPins");
		GetSubPins_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSubPins_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSubPins_A_PropertyAddress, GetSubPins_FunctionAddress, "A");
		GetSubPins_A_Offset = NativeReflectionCached.GetPropertyOffset(GetSubPins_FunctionAddress, "A");
		GetSubPins_A_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubPins_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSubPins_ReturnValue_PropertyAddress, GetSubPins_FunctionAddress, "ReturnValue");
		GetSubPins_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSubPins_FunctionAddress, "ReturnValue");
		GetSubPins_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubPins_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSubPins_IsValid = GetSubPins_FunctionAddress != IntPtr.Zero && GetSubPins_A_IsValid && GetSubPins_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetSubPins", GetSubPins_IsValid);
		GetPins_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPins");
		GetPins_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPins_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPins_Node_PropertyAddress, GetPins_FunctionAddress, "Node");
		GetPins_Node_Offset = NativeReflectionCached.GetPropertyOffset(GetPins_FunctionAddress, "Node");
		GetPins_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPins_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPins_ReturnValue_PropertyAddress, GetPins_FunctionAddress, "ReturnValue");
		GetPins_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPins_FunctionAddress, "ReturnValue");
		GetPins_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPins_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetPins_IsValid = GetPins_FunctionAddress != IntPtr.Zero && GetPins_Node_IsValid && GetPins_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPins", GetPins_IsValid);
		GetPinName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPinName");
		GetPinName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPinName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPinName_A_PropertyAddress, GetPinName_FunctionAddress, "A");
		GetPinName_A_Offset = NativeReflectionCached.GetPropertyOffset(GetPinName_FunctionAddress, "A");
		GetPinName_A_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPinName_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPinName_ReturnValue_PropertyAddress, GetPinName_FunctionAddress, "ReturnValue");
		GetPinName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPinName_FunctionAddress, "ReturnValue");
		GetPinName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPinName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetPinName_IsValid = GetPinName_FunctionAddress != IntPtr.Zero && GetPinName_A_IsValid && GetPinName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPinName", GetPinName_IsValid);
		GetPinIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPinIndex");
		GetPinIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPinIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPinIndex_A_PropertyAddress, GetPinIndex_FunctionAddress, "A");
		GetPinIndex_A_Offset = NativeReflectionCached.GetPropertyOffset(GetPinIndex_FunctionAddress, "A");
		GetPinIndex_A_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPinIndex_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPinIndex_ReturnValue_PropertyAddress, GetPinIndex_FunctionAddress, "ReturnValue");
		GetPinIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPinIndex_FunctionAddress, "ReturnValue");
		GetPinIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPinIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPinIndex_IsValid = GetPinIndex_FunctionAddress != IntPtr.Zero && GetPinIndex_A_IsValid && GetPinIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPinIndex", GetPinIndex_IsValid);
		GetPinGUID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPinGUID");
		GetPinGUID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPinGUID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPinGUID_A_PropertyAddress, GetPinGUID_FunctionAddress, "A");
		GetPinGUID_A_Offset = NativeReflectionCached.GetPropertyOffset(GetPinGUID_FunctionAddress, "A");
		GetPinGUID_A_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPinGUID_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPinGUID_ReturnValue_PropertyAddress, GetPinGUID_FunctionAddress, "ReturnValue");
		GetPinGUID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPinGUID_FunctionAddress, "ReturnValue");
		GetPinGUID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPinGUID_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPinGUID_IsValid = GetPinGUID_FunctionAddress != IntPtr.Zero && GetPinGUID_A_IsValid && GetPinGUID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPinGUID", GetPinGUID_IsValid);
		GetPinContainerType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPinContainerType");
		GetPinContainerType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPinContainerType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPinContainerType_A_PropertyAddress, GetPinContainerType_FunctionAddress, "A");
		GetPinContainerType_A_Offset = NativeReflectionCached.GetPropertyOffset(GetPinContainerType_FunctionAddress, "A");
		GetPinContainerType_A_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPinContainerType_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPinContainerType_ReturnValue_PropertyAddress, GetPinContainerType_FunctionAddress, "ReturnValue");
		GetPinContainerType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPinContainerType_FunctionAddress, "ReturnValue");
		GetPinContainerType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPinContainerType_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetPinContainerType_IsValid = GetPinContainerType_FunctionAddress != IntPtr.Zero && GetPinContainerType_A_IsValid && GetPinContainerType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetPinContainerType", GetPinContainerType_IsValid);
		GetParentPin_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParentPin");
		GetParentPin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentPin_A_PropertyAddress, GetParentPin_FunctionAddress, "A");
		GetParentPin_A_Offset = NativeReflectionCached.GetPropertyOffset(GetParentPin_FunctionAddress, "A");
		GetParentPin_A_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentPin_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentPin_ReturnValue_PropertyAddress, GetParentPin_FunctionAddress, "ReturnValue");
		GetParentPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentPin_FunctionAddress, "ReturnValue");
		GetParentPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentPin_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetParentPin_IsValid = GetParentPin_FunctionAddress != IntPtr.Zero && GetParentPin_A_IsValid && GetParentPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetParentPin", GetParentPin_IsValid);
		GetOwningNode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOwningNode");
		GetOwningNode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwningNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwningNode_A_PropertyAddress, GetOwningNode_FunctionAddress, "A");
		GetOwningNode_A_Offset = NativeReflectionCached.GetPropertyOffset(GetOwningNode_FunctionAddress, "A");
		GetOwningNode_A_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwningNode_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOwningNode_ReturnValue_PropertyAddress, GetOwningNode_FunctionAddress, "ReturnValue");
		GetOwningNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwningNode_FunctionAddress, "ReturnValue");
		GetOwningNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwningNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwningNode_IsValid = GetOwningNode_FunctionAddress != IntPtr.Zero && GetOwningNode_A_IsValid && GetOwningNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetOwningNode", GetOwningNode_IsValid);
		GetOwnerPanel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOwnerPanel");
		GetOwnerPanel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwnerPanel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwnerPanel_Node_PropertyAddress, GetOwnerPanel_FunctionAddress, "Node");
		GetOwnerPanel_Node_Offset = NativeReflectionCached.GetPropertyOffset(GetOwnerPanel_FunctionAddress, "Node");
		GetOwnerPanel_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwnerPanel_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOwnerPanel_ReturnValue_PropertyAddress, GetOwnerPanel_FunctionAddress, "ReturnValue");
		GetOwnerPanel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwnerPanel_FunctionAddress, "ReturnValue");
		GetOwnerPanel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwnerPanel_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetOwnerPanel_IsValid = GetOwnerPanel_FunctionAddress != IntPtr.Zero && GetOwnerPanel_Node_IsValid && GetOwnerPanel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetOwnerPanel", GetOwnerPanel_IsValid);
		GetOutputPinWidget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOutputPinWidget");
		GetOutputPinWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOutputPinWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOutputPinWidget_Container_PropertyAddress, GetOutputPinWidget_FunctionAddress, "Container");
		GetOutputPinWidget_Container_Offset = NativeReflectionCached.GetPropertyOffset(GetOutputPinWidget_FunctionAddress, "Container");
		GetOutputPinWidget_Container_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOutputPinWidget_FunctionAddress, "Container", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOutputPinWidget_ReturnValue_PropertyAddress, GetOutputPinWidget_FunctionAddress, "ReturnValue");
		GetOutputPinWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOutputPinWidget_FunctionAddress, "ReturnValue");
		GetOutputPinWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOutputPinWidget_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetOutputPinWidget_IsValid = GetOutputPinWidget_FunctionAddress != IntPtr.Zero && GetOutputPinWidget_Container_IsValid && GetOutputPinWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetOutputPinWidget", GetOutputPinWidget_IsValid);
		GetLinkedTo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLinkedTo");
		GetLinkedTo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinkedTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinkedTo_A_PropertyAddress, GetLinkedTo_FunctionAddress, "A");
		GetLinkedTo_A_Offset = NativeReflectionCached.GetPropertyOffset(GetLinkedTo_FunctionAddress, "A");
		GetLinkedTo_A_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinkedTo_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinkedTo_ReturnValue_PropertyAddress, GetLinkedTo_FunctionAddress, "ReturnValue");
		GetLinkedTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinkedTo_FunctionAddress, "ReturnValue");
		GetLinkedTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinkedTo_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLinkedTo_IsValid = GetLinkedTo_FunctionAddress != IntPtr.Zero && GetLinkedTo_A_IsValid && GetLinkedTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetLinkedTo", GetLinkedTo_IsValid);
		GetLinkedPinNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLinkedPinNum");
		GetLinkedPinNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinkedPinNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinkedPinNum_A_PropertyAddress, GetLinkedPinNum_FunctionAddress, "A");
		GetLinkedPinNum_A_Offset = NativeReflectionCached.GetPropertyOffset(GetLinkedPinNum_FunctionAddress, "A");
		GetLinkedPinNum_A_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinkedPinNum_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinkedPinNum_ReturnValue_PropertyAddress, GetLinkedPinNum_FunctionAddress, "ReturnValue");
		GetLinkedPinNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinkedPinNum_FunctionAddress, "ReturnValue");
		GetLinkedPinNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinkedPinNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetLinkedPinNum_IsValid = GetLinkedPinNum_FunctionAddress != IntPtr.Zero && GetLinkedPinNum_A_IsValid && GetLinkedPinNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetLinkedPinNum", GetLinkedPinNum_IsValid);
		GetHorveredPinNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetHorveredPinNum");
		GetHorveredPinNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHorveredPinNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHorveredPinNum_Container_PropertyAddress, GetHorveredPinNum_FunctionAddress, "Container");
		GetHorveredPinNum_Container_Offset = NativeReflectionCached.GetPropertyOffset(GetHorveredPinNum_FunctionAddress, "Container");
		GetHorveredPinNum_Container_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHorveredPinNum_FunctionAddress, "Container", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHorveredPinNum_ReturnValue_PropertyAddress, GetHorveredPinNum_FunctionAddress, "ReturnValue");
		GetHorveredPinNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHorveredPinNum_FunctionAddress, "ReturnValue");
		GetHorveredPinNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHorveredPinNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetHorveredPinNum_IsValid = GetHorveredPinNum_FunctionAddress != IntPtr.Zero && GetHorveredPinNum_Container_IsValid && GetHorveredPinNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetHorveredPinNum", GetHorveredPinNum_IsValid);
		GetDirection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDirection");
		GetDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDirection_A_PropertyAddress, GetDirection_FunctionAddress, "A");
		GetDirection_A_Offset = NativeReflectionCached.GetPropertyOffset(GetDirection_FunctionAddress, "A");
		GetDirection_A_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirection_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirection_ReturnValue_PropertyAddress, GetDirection_FunctionAddress, "ReturnValue");
		GetDirection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDirection_FunctionAddress, "ReturnValue");
		GetDirection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirection_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetDirection_IsValid = GetDirection_FunctionAddress != IntPtr.Zero && GetDirection_A_IsValid && GetDirection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetDirection", GetDirection_IsValid);
		GetDefaultObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultObject");
		GetDefaultObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultObject_ReturnValue_PropertyAddress, GetDefaultObject_FunctionAddress, "ReturnValue");
		GetDefaultObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultObject_FunctionAddress, "ReturnValue");
		GetDefaultObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultObject_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDefaultObject_IsValid = GetDefaultObject_FunctionAddress != IntPtr.Zero && GetDefaultObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetDefaultObject", GetDefaultObject_IsValid);
		GetArrangedNodes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetArrangedNodes");
		GetArrangedNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetArrangedNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetArrangedNodes_Container_PropertyAddress, GetArrangedNodes_FunctionAddress, "Container");
		GetArrangedNodes_Container_Offset = NativeReflectionCached.GetPropertyOffset(GetArrangedNodes_FunctionAddress, "Container");
		GetArrangedNodes_Container_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArrangedNodes_FunctionAddress, "Container", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetArrangedNodes_Node_PropertyAddress, GetArrangedNodes_FunctionAddress, "Node");
		GetArrangedNodes_Node_Offset = NativeReflectionCached.GetPropertyOffset(GetArrangedNodes_FunctionAddress, "Node");
		GetArrangedNodes_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArrangedNodes_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetArrangedNodes_ReturnValue_PropertyAddress, GetArrangedNodes_FunctionAddress, "ReturnValue");
		GetArrangedNodes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetArrangedNodes_FunctionAddress, "ReturnValue");
		GetArrangedNodes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArrangedNodes_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetArrangedNodes_IsValid = GetArrangedNodes_FunctionAddress != IntPtr.Zero && GetArrangedNodes_Container_IsValid && GetArrangedNodes_Node_IsValid && GetArrangedNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:GetArrangedNodes", GetArrangedNodes_IsValid);
		FindPinToPinWidgetMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindPinToPinWidgetMap");
		FindPinToPinWidgetMap_ParamsSize = NativeReflection.GetFunctionParamsSize(FindPinToPinWidgetMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindPinToPinWidgetMap_Container_PropertyAddress, FindPinToPinWidgetMap_FunctionAddress, "Container");
		FindPinToPinWidgetMap_Container_Offset = NativeReflectionCached.GetPropertyOffset(FindPinToPinWidgetMap_FunctionAddress, "Container");
		FindPinToPinWidgetMap_Container_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPinToPinWidgetMap_FunctionAddress, "Container", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPinToPinWidgetMap_Pin_PropertyAddress, FindPinToPinWidgetMap_FunctionAddress, "Pin");
		FindPinToPinWidgetMap_Pin_Offset = NativeReflectionCached.GetPropertyOffset(FindPinToPinWidgetMap_FunctionAddress, "Pin");
		FindPinToPinWidgetMap_Pin_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPinToPinWidgetMap_FunctionAddress, "Pin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPinToPinWidgetMap_ReturnValue_PropertyAddress, FindPinToPinWidgetMap_FunctionAddress, "ReturnValue");
		FindPinToPinWidgetMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindPinToPinWidgetMap_FunctionAddress, "ReturnValue");
		FindPinToPinWidgetMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPinToPinWidgetMap_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindPinToPinWidgetMap_IsValid = FindPinToPinWidgetMap_FunctionAddress != IntPtr.Zero && FindPinToPinWidgetMap_Container_IsValid && FindPinToPinWidgetMap_Pin_IsValid && FindPinToPinWidgetMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:FindPinToPinWidgetMap", FindPinToPinWidgetMap_IsValid);
		FindPinGeometries_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindPinGeometries");
		FindPinGeometries_ParamsSize = NativeReflection.GetFunctionParamsSize(FindPinGeometries_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindPinGeometries_Container_PropertyAddress, FindPinGeometries_FunctionAddress, "Container");
		FindPinGeometries_Container_Offset = NativeReflectionCached.GetPropertyOffset(FindPinGeometries_FunctionAddress, "Container");
		FindPinGeometries_Container_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPinGeometries_FunctionAddress, "Container", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPinGeometries_PinWidget_PropertyAddress, FindPinGeometries_FunctionAddress, "PinWidget");
		FindPinGeometries_PinWidget_Offset = NativeReflectionCached.GetPropertyOffset(FindPinGeometries_FunctionAddress, "PinWidget");
		FindPinGeometries_PinWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPinGeometries_FunctionAddress, "PinWidget", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPinGeometries_ReturnValue_PropertyAddress, FindPinGeometries_FunctionAddress, "ReturnValue");
		FindPinGeometries_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindPinGeometries_FunctionAddress, "ReturnValue");
		FindPinGeometries_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPinGeometries_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindPinGeometries_IsValid = FindPinGeometries_FunctionAddress != IntPtr.Zero && FindPinGeometries_Container_IsValid && FindPinGeometries_PinWidget_IsValid && FindPinGeometries_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:FindPinGeometries", FindPinGeometries_IsValid);
		FindPin_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindPin");
		FindPin_ParamsSize = NativeReflection.GetFunctionParamsSize(FindPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindPin_Node_PropertyAddress, FindPin_FunctionAddress, "Node");
		FindPin_Node_Offset = NativeReflectionCached.GetPropertyOffset(FindPin_FunctionAddress, "Node");
		FindPin_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPin_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPin_PinName_PropertyAddress, FindPin_FunctionAddress, "PinName");
		FindPin_PinName_Offset = NativeReflectionCached.GetPropertyOffset(FindPin_FunctionAddress, "PinName");
		FindPin_PinName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPin_FunctionAddress, "PinName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPin_Direction_PropertyAddress, FindPin_FunctionAddress, "Direction");
		FindPin_Direction_Offset = NativeReflectionCached.GetPropertyOffset(FindPin_FunctionAddress, "Direction");
		FindPin_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPin_FunctionAddress, "Direction", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPin_ReturnValue_PropertyAddress, FindPin_FunctionAddress, "ReturnValue");
		FindPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindPin_FunctionAddress, "ReturnValue");
		FindPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPin_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindPin_IsValid = FindPin_FunctionAddress != IntPtr.Zero && FindPin_Node_IsValid && FindPin_PinName_IsValid && FindPin_Direction_IsValid && FindPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:FindPin", FindPin_IsValid);
		FindClosestPointOnGeom_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindClosestPointOnGeom");
		FindClosestPointOnGeom_ParamsSize = NativeReflection.GetFunctionParamsSize(FindClosestPointOnGeom_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindClosestPointOnGeom_Geom_PropertyAddress, FindClosestPointOnGeom_FunctionAddress, "Geom");
		FindClosestPointOnGeom_Geom_Offset = NativeReflectionCached.GetPropertyOffset(FindClosestPointOnGeom_FunctionAddress, "Geom");
		FindClosestPointOnGeom_Geom_IsValid = NativeReflectionCached.ValidatePropertyClass(FindClosestPointOnGeom_FunctionAddress, "Geom", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindClosestPointOnGeom_TestPoint_PropertyAddress, FindClosestPointOnGeom_FunctionAddress, "TestPoint");
		FindClosestPointOnGeom_TestPoint_Offset = NativeReflectionCached.GetPropertyOffset(FindClosestPointOnGeom_FunctionAddress, "TestPoint");
		FindClosestPointOnGeom_TestPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(FindClosestPointOnGeom_FunctionAddress, "TestPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindClosestPointOnGeom_ReturnValue_PropertyAddress, FindClosestPointOnGeom_FunctionAddress, "ReturnValue");
		FindClosestPointOnGeom_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindClosestPointOnGeom_FunctionAddress, "ReturnValue");
		FindClosestPointOnGeom_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindClosestPointOnGeom_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindClosestPointOnGeom_IsValid = FindClosestPointOnGeom_FunctionAddress != IntPtr.Zero && FindClosestPointOnGeom_Geom_IsValid && FindClosestPointOnGeom_TestPoint_IsValid && FindClosestPointOnGeom_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:FindClosestPointOnGeom", FindClosestPointOnGeom_IsValid);
		Finalize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Finalize");
		Finalize_ParamsSize = NativeReflection.GetFunctionParamsSize(Finalize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Finalize_Creator_PropertyAddress, Finalize_FunctionAddress, "Creator");
		Finalize_Creator_Offset = NativeReflectionCached.GetPropertyOffset(Finalize_FunctionAddress, "Creator");
		Finalize_Creator_IsValid = NativeReflectionCached.ValidatePropertyClass(Finalize_FunctionAddress, "Creator", Classes.FStructProperty);
		Finalize_IsValid = Finalize_FunctionAddress != IntPtr.Zero && Finalize_Creator_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:Finalize", Finalize_IsValid);
		DrawSplineWithArrow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawSplineWithArrow");
		DrawSplineWithArrow_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawSplineWithArrow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawSplineWithArrow_Container_PropertyAddress, DrawSplineWithArrow_FunctionAddress, "Container");
		DrawSplineWithArrow_Container_Offset = NativeReflectionCached.GetPropertyOffset(DrawSplineWithArrow_FunctionAddress, "Container");
		DrawSplineWithArrow_Container_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawSplineWithArrow_FunctionAddress, "Container", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawSplineWithArrow_StartAnchorPoint_PropertyAddress, DrawSplineWithArrow_FunctionAddress, "StartAnchorPoint");
		DrawSplineWithArrow_StartAnchorPoint_Offset = NativeReflectionCached.GetPropertyOffset(DrawSplineWithArrow_FunctionAddress, "StartAnchorPoint");
		DrawSplineWithArrow_StartAnchorPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawSplineWithArrow_FunctionAddress, "StartAnchorPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawSplineWithArrow_EndAnchorPoint_PropertyAddress, DrawSplineWithArrow_FunctionAddress, "EndAnchorPoint");
		DrawSplineWithArrow_EndAnchorPoint_Offset = NativeReflectionCached.GetPropertyOffset(DrawSplineWithArrow_FunctionAddress, "EndAnchorPoint");
		DrawSplineWithArrow_EndAnchorPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawSplineWithArrow_FunctionAddress, "EndAnchorPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawSplineWithArrow_Params_PropertyAddress, DrawSplineWithArrow_FunctionAddress, "Params");
		DrawSplineWithArrow_Params_Offset = NativeReflectionCached.GetPropertyOffset(DrawSplineWithArrow_FunctionAddress, "Params");
		DrawSplineWithArrow_Params_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawSplineWithArrow_FunctionAddress, "Params", Classes.FStructProperty);
		DrawSplineWithArrow_IsValid = DrawSplineWithArrow_FunctionAddress != IntPtr.Zero && DrawSplineWithArrow_Container_IsValid && DrawSplineWithArrow_StartAnchorPoint_IsValid && DrawSplineWithArrow_EndAnchorPoint_IsValid && DrawSplineWithArrow_Params_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:DrawSplineWithArrow", DrawSplineWithArrow_IsValid);
		DrawConnection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawConnection");
		DrawConnection_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawConnection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawConnection_Container_PropertyAddress, DrawConnection_FunctionAddress, "Container");
		DrawConnection_Container_Offset = NativeReflectionCached.GetPropertyOffset(DrawConnection_FunctionAddress, "Container");
		DrawConnection_Container_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawConnection_FunctionAddress, "Container", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawConnection_A_PropertyAddress, DrawConnection_FunctionAddress, "A");
		DrawConnection_A_Offset = NativeReflectionCached.GetPropertyOffset(DrawConnection_FunctionAddress, "A");
		DrawConnection_A_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawConnection_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawConnection_B_PropertyAddress, DrawConnection_FunctionAddress, "B");
		DrawConnection_B_Offset = NativeReflectionCached.GetPropertyOffset(DrawConnection_FunctionAddress, "B");
		DrawConnection_B_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawConnection_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawConnection_Params_PropertyAddress, DrawConnection_FunctionAddress, "Params");
		DrawConnection_Params_Offset = NativeReflectionCached.GetPropertyOffset(DrawConnection_FunctionAddress, "Params");
		DrawConnection_Params_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawConnection_FunctionAddress, "Params", Classes.FStructProperty);
		DrawConnection_IsValid = DrawConnection_FunctionAddress != IntPtr.Zero && DrawConnection_Container_IsValid && DrawConnection_A_IsValid && DrawConnection_B_IsValid && DrawConnection_Params_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:DrawConnection", DrawConnection_IsValid);
		DetermineWiringStyle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DetermineWiringStyle");
		DetermineWiringStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(DetermineWiringStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DetermineWiringStyle_Container_PropertyAddress, DetermineWiringStyle_FunctionAddress, "Container");
		DetermineWiringStyle_Container_Offset = NativeReflectionCached.GetPropertyOffset(DetermineWiringStyle_FunctionAddress, "Container");
		DetermineWiringStyle_Container_IsValid = NativeReflectionCached.ValidatePropertyClass(DetermineWiringStyle_FunctionAddress, "Container", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DetermineWiringStyle_OutputPin_PropertyAddress, DetermineWiringStyle_FunctionAddress, "OutputPin");
		DetermineWiringStyle_OutputPin_Offset = NativeReflectionCached.GetPropertyOffset(DetermineWiringStyle_FunctionAddress, "OutputPin");
		DetermineWiringStyle_OutputPin_IsValid = NativeReflectionCached.ValidatePropertyClass(DetermineWiringStyle_FunctionAddress, "OutputPin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DetermineWiringStyle_InputPin_PropertyAddress, DetermineWiringStyle_FunctionAddress, "InputPin");
		DetermineWiringStyle_InputPin_Offset = NativeReflectionCached.GetPropertyOffset(DetermineWiringStyle_FunctionAddress, "InputPin");
		DetermineWiringStyle_InputPin_IsValid = NativeReflectionCached.ValidatePropertyClass(DetermineWiringStyle_FunctionAddress, "InputPin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DetermineWiringStyle_Params_PropertyAddress, DetermineWiringStyle_FunctionAddress, "Params");
		DetermineWiringStyle_Params_Offset = NativeReflectionCached.GetPropertyOffset(DetermineWiringStyle_FunctionAddress, "Params");
		DetermineWiringStyle_Params_IsValid = NativeReflectionCached.ValidatePropertyClass(DetermineWiringStyle_FunctionAddress, "Params", Classes.FStructProperty);
		DetermineWiringStyle_IsValid = DetermineWiringStyle_FunctionAddress != IntPtr.Zero && DetermineWiringStyle_Container_IsValid && DetermineWiringStyle_OutputPin_IsValid && DetermineWiringStyle_InputPin_IsValid && DetermineWiringStyle_Params_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:DetermineWiringStyle", DetermineWiringStyle_IsValid);
		DestroyNode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DestroyNode");
		DestroyNode_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DestroyNode_Node_PropertyAddress, DestroyNode_FunctionAddress, "Node");
		DestroyNode_Node_Offset = NativeReflectionCached.GetPropertyOffset(DestroyNode_FunctionAddress, "Node");
		DestroyNode_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(DestroyNode_FunctionAddress, "Node", Classes.FObjectProperty);
		DestroyNode_IsValid = DestroyNode_FunctionAddress != IntPtr.Zero && DestroyNode_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:DestroyNode", DestroyNode_IsValid);
		CustomNodeCreator_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CustomNodeCreator");
		CustomNodeCreator_ParamsSize = NativeReflection.GetFunctionParamsSize(CustomNodeCreator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CustomNodeCreator_Graph_PropertyAddress, CustomNodeCreator_FunctionAddress, "Graph");
		CustomNodeCreator_Graph_Offset = NativeReflectionCached.GetPropertyOffset(CustomNodeCreator_FunctionAddress, "Graph");
		CustomNodeCreator_Graph_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomNodeCreator_FunctionAddress, "Graph", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomNodeCreator_ReturnValue_PropertyAddress, CustomNodeCreator_FunctionAddress, "ReturnValue");
		CustomNodeCreator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CustomNodeCreator_FunctionAddress, "ReturnValue");
		CustomNodeCreator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomNodeCreator_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CustomNodeCreator_IsValid = CustomNodeCreator_FunctionAddress != IntPtr.Zero && CustomNodeCreator_Graph_IsValid && CustomNodeCreator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:CustomNodeCreator", CustomNodeCreator_IsValid);
		CenterOf_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CenterOf");
		CenterOf_ParamsSize = NativeReflection.GetFunctionParamsSize(CenterOf_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CenterOf_Geom_PropertyAddress, CenterOf_FunctionAddress, "Geom");
		CenterOf_Geom_Offset = NativeReflectionCached.GetPropertyOffset(CenterOf_FunctionAddress, "Geom");
		CenterOf_Geom_IsValid = NativeReflectionCached.ValidatePropertyClass(CenterOf_FunctionAddress, "Geom", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CenterOf_ReturnValue_PropertyAddress, CenterOf_FunctionAddress, "ReturnValue");
		CenterOf_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CenterOf_FunctionAddress, "ReturnValue");
		CenterOf_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CenterOf_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CenterOf_IsValid = CenterOf_FunctionAddress != IntPtr.Zero && CenterOf_Geom_IsValid && CenterOf_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:CenterOf", CenterOf_IsValid);
		CanUserDeleteNode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CanUserDeleteNode");
		CanUserDeleteNode_ParamsSize = NativeReflection.GetFunctionParamsSize(CanUserDeleteNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanUserDeleteNode_Node_PropertyAddress, CanUserDeleteNode_FunctionAddress, "Node");
		CanUserDeleteNode_Node_Offset = NativeReflectionCached.GetPropertyOffset(CanUserDeleteNode_FunctionAddress, "Node");
		CanUserDeleteNode_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(CanUserDeleteNode_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CanUserDeleteNode_ReturnValue_PropertyAddress, CanUserDeleteNode_FunctionAddress, "ReturnValue");
		CanUserDeleteNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanUserDeleteNode_FunctionAddress, "ReturnValue");
		CanUserDeleteNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanUserDeleteNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanUserDeleteNode_IsValid = CanUserDeleteNode_FunctionAddress != IntPtr.Zero && CanUserDeleteNode_Node_IsValid && CanUserDeleteNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:CanUserDeleteNode", CanUserDeleteNode_IsValid);
		CanDuplicateNode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CanDuplicateNode");
		CanDuplicateNode_ParamsSize = NativeReflection.GetFunctionParamsSize(CanDuplicateNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanDuplicateNode_Node_PropertyAddress, CanDuplicateNode_FunctionAddress, "Node");
		CanDuplicateNode_Node_Offset = NativeReflectionCached.GetPropertyOffset(CanDuplicateNode_FunctionAddress, "Node");
		CanDuplicateNode_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(CanDuplicateNode_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CanDuplicateNode_ReturnValue_PropertyAddress, CanDuplicateNode_FunctionAddress, "ReturnValue");
		CanDuplicateNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanDuplicateNode_FunctionAddress, "ReturnValue");
		CanDuplicateNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanDuplicateNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanDuplicateNode_IsValid = CanDuplicateNode_FunctionAddress != IntPtr.Zero && CanDuplicateNode_Node_IsValid && CanDuplicateNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:CanDuplicateNode", CanDuplicateNode_IsValid);
		BreakLinkTo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BreakLinkTo");
		BreakLinkTo_ParamsSize = NativeReflection.GetFunctionParamsSize(BreakLinkTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BreakLinkTo_A_PropertyAddress, BreakLinkTo_FunctionAddress, "A");
		BreakLinkTo_A_Offset = NativeReflectionCached.GetPropertyOffset(BreakLinkTo_FunctionAddress, "A");
		BreakLinkTo_A_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakLinkTo_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakLinkTo_B_PropertyAddress, BreakLinkTo_FunctionAddress, "B");
		BreakLinkTo_B_Offset = NativeReflectionCached.GetPropertyOffset(BreakLinkTo_FunctionAddress, "B");
		BreakLinkTo_B_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakLinkTo_FunctionAddress, "B", Classes.FStructProperty);
		BreakLinkTo_IsValid = BreakLinkTo_FunctionAddress != IntPtr.Zero && BreakLinkTo_A_IsValid && BreakLinkTo_B_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:BreakLinkTo", BreakLinkTo_IsValid);
		BreakAllPinLinks_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BreakAllPinLinks");
		BreakAllPinLinks_ParamsSize = NativeReflection.GetFunctionParamsSize(BreakAllPinLinks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BreakAllPinLinks_A_PropertyAddress, BreakAllPinLinks_FunctionAddress, "A");
		BreakAllPinLinks_A_Offset = NativeReflectionCached.GetPropertyOffset(BreakAllPinLinks_FunctionAddress, "A");
		BreakAllPinLinks_A_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakAllPinLinks_FunctionAddress, "A", Classes.FStructProperty);
		BreakAllPinLinks_IsValid = BreakAllPinLinks_FunctionAddress != IntPtr.Zero && BreakAllPinLinks_A_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:BreakAllPinLinks", BreakAllPinLinks_IsValid);
		AutowireNewNode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AutowireNewNode");
		AutowireNewNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AutowireNewNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AutowireNewNode_Node_PropertyAddress, AutowireNewNode_FunctionAddress, "Node");
		AutowireNewNode_Node_Offset = NativeReflectionCached.GetPropertyOffset(AutowireNewNode_FunctionAddress, "Node");
		AutowireNewNode_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(AutowireNewNode_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AutowireNewNode_FromPin_PropertyAddress, AutowireNewNode_FunctionAddress, "FromPin");
		AutowireNewNode_FromPin_Offset = NativeReflectionCached.GetPropertyOffset(AutowireNewNode_FunctionAddress, "FromPin");
		AutowireNewNode_FromPin_IsValid = NativeReflectionCached.ValidatePropertyClass(AutowireNewNode_FunctionAddress, "FromPin", Classes.FStructProperty);
		AutowireNewNode_IsValid = AutowireNewNode_FunctionAddress != IntPtr.Zero && AutowireNewNode_Node_IsValid && AutowireNewNode_FromPin_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:AutowireNewNode", AutowireNewNode_IsValid);
		ApplyHoverDeemphasis_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyHoverDeemphasis");
		ApplyHoverDeemphasis_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyHoverDeemphasis_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyHoverDeemphasis_Container_PropertyAddress, ApplyHoverDeemphasis_FunctionAddress, "Container");
		ApplyHoverDeemphasis_Container_Offset = NativeReflectionCached.GetPropertyOffset(ApplyHoverDeemphasis_FunctionAddress, "Container");
		ApplyHoverDeemphasis_Container_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyHoverDeemphasis_FunctionAddress, "Container", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyHoverDeemphasis_OutputPin_PropertyAddress, ApplyHoverDeemphasis_FunctionAddress, "OutputPin");
		ApplyHoverDeemphasis_OutputPin_Offset = NativeReflectionCached.GetPropertyOffset(ApplyHoverDeemphasis_FunctionAddress, "OutputPin");
		ApplyHoverDeemphasis_OutputPin_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyHoverDeemphasis_FunctionAddress, "OutputPin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyHoverDeemphasis_InputPin_PropertyAddress, ApplyHoverDeemphasis_FunctionAddress, "InputPin");
		ApplyHoverDeemphasis_InputPin_Offset = NativeReflectionCached.GetPropertyOffset(ApplyHoverDeemphasis_FunctionAddress, "InputPin");
		ApplyHoverDeemphasis_InputPin_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyHoverDeemphasis_FunctionAddress, "InputPin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyHoverDeemphasis_Thickness_PropertyAddress, ApplyHoverDeemphasis_FunctionAddress, "Thickness");
		ApplyHoverDeemphasis_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(ApplyHoverDeemphasis_FunctionAddress, "Thickness");
		ApplyHoverDeemphasis_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyHoverDeemphasis_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyHoverDeemphasis_WireColor_PropertyAddress, ApplyHoverDeemphasis_FunctionAddress, "WireColor");
		ApplyHoverDeemphasis_WireColor_Offset = NativeReflectionCached.GetPropertyOffset(ApplyHoverDeemphasis_FunctionAddress, "WireColor");
		ApplyHoverDeemphasis_WireColor_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyHoverDeemphasis_FunctionAddress, "WireColor", Classes.FStructProperty);
		ApplyHoverDeemphasis_IsValid = ApplyHoverDeemphasis_FunctionAddress != IntPtr.Zero && ApplyHoverDeemphasis_Container_IsValid && ApplyHoverDeemphasis_OutputPin_IsValid && ApplyHoverDeemphasis_InputPin_IsValid && ApplyHoverDeemphasis_Thickness_IsValid && ApplyHoverDeemphasis_WireColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:ApplyHoverDeemphasis", ApplyHoverDeemphasis_IsValid);
		AddPinToHoverSet_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddPinToHoverSet");
		AddPinToHoverSet_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPinToHoverSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddPinToHoverSet_InSlateEdNode_PropertyAddress, AddPinToHoverSet_FunctionAddress, "InSlateEdNode");
		AddPinToHoverSet_InSlateEdNode_Offset = NativeReflectionCached.GetPropertyOffset(AddPinToHoverSet_FunctionAddress, "InSlateEdNode");
		AddPinToHoverSet_InSlateEdNode_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPinToHoverSet_FunctionAddress, "InSlateEdNode", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPinToHoverSet_Pin_PropertyAddress, AddPinToHoverSet_FunctionAddress, "Pin");
		AddPinToHoverSet_Pin_Offset = NativeReflectionCached.GetPropertyOffset(AddPinToHoverSet_FunctionAddress, "Pin");
		AddPinToHoverSet_Pin_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPinToHoverSet_FunctionAddress, "Pin", Classes.FStructProperty);
		AddPinToHoverSet_IsValid = AddPinToHoverSet_FunctionAddress != IntPtr.Zero && AddPinToHoverSet_InSlateEdNode_IsValid && AddPinToHoverSet_Pin_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptGraphEditor.JavascriptGraphEditorLibrary:AddPinToHoverSet", AddPinToHoverSet_IsValid);
	}
}
