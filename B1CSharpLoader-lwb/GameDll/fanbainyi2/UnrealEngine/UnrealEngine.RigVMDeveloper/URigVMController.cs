using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.RigVM;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMController", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMController : UObject
{
	private static bool ModifiedEvent_IsValid;

	private static int ModifiedEvent_Offset;

	private FRigVMGraphModifiedDynamicEvent ModifiedEvent_DelegateCached;

	private static bool Undo_IsValid;

	private static IntPtr Undo_FunctionAddress;

	private static int Undo_ParamsSize;

	private static bool Undo_ReturnValue_IsValid;

	private static FFieldAddress Undo_ReturnValue_PropertyAddress;

	private static int Undo_ReturnValue_Offset;

	private static bool UnbindPinFromVariable_IsValid;

	private static IntPtr UnbindPinFromVariable_FunctionAddress;

	private static int UnbindPinFromVariable_ParamsSize;

	private static bool UnbindPinFromVariable_InPinPath_IsValid;

	private static FFieldAddress UnbindPinFromVariable_InPinPath_PropertyAddress;

	private static int UnbindPinFromVariable_InPinPath_Offset;

	private static bool UnbindPinFromVariable_bSetupUndoRedo_IsValid;

	private static FFieldAddress UnbindPinFromVariable_bSetupUndoRedo_PropertyAddress;

	private static int UnbindPinFromVariable_bSetupUndoRedo_Offset;

	private static bool UnbindPinFromVariable_bPrintPythonCommand_IsValid;

	private static FFieldAddress UnbindPinFromVariable_bPrintPythonCommand_PropertyAddress;

	private static int UnbindPinFromVariable_bPrintPythonCommand_Offset;

	private static bool UnbindPinFromVariable_ReturnValue_IsValid;

	private static FFieldAddress UnbindPinFromVariable_ReturnValue_PropertyAddress;

	private static int UnbindPinFromVariable_ReturnValue_Offset;

	private static bool SetRerouteCompactnessByName_IsValid;

	private static IntPtr SetRerouteCompactnessByName_FunctionAddress;

	private static int SetRerouteCompactnessByName_ParamsSize;

	private static bool SetRerouteCompactnessByName_InNodeName_IsValid;

	private static FFieldAddress SetRerouteCompactnessByName_InNodeName_PropertyAddress;

	private static int SetRerouteCompactnessByName_InNodeName_Offset;

	private static bool SetRerouteCompactnessByName_bShowAsFullNode_IsValid;

	private static FFieldAddress SetRerouteCompactnessByName_bShowAsFullNode_PropertyAddress;

	private static int SetRerouteCompactnessByName_bShowAsFullNode_Offset;

	private static bool SetRerouteCompactnessByName_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetRerouteCompactnessByName_bSetupUndoRedo_PropertyAddress;

	private static int SetRerouteCompactnessByName_bSetupUndoRedo_Offset;

	private static bool SetRerouteCompactnessByName_ReturnValue_IsValid;

	private static FFieldAddress SetRerouteCompactnessByName_ReturnValue_PropertyAddress;

	private static int SetRerouteCompactnessByName_ReturnValue_Offset;

	private static bool SetRerouteCompactness_IsValid;

	private static IntPtr SetRerouteCompactness_FunctionAddress;

	private static int SetRerouteCompactness_ParamsSize;

	private static bool SetRerouteCompactness_InNode_IsValid;

	private static FFieldAddress SetRerouteCompactness_InNode_PropertyAddress;

	private static int SetRerouteCompactness_InNode_Offset;

	private static bool SetRerouteCompactness_bShowAsFullNode_IsValid;

	private static FFieldAddress SetRerouteCompactness_bShowAsFullNode_PropertyAddress;

	private static int SetRerouteCompactness_bShowAsFullNode_Offset;

	private static bool SetRerouteCompactness_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetRerouteCompactness_bSetupUndoRedo_PropertyAddress;

	private static int SetRerouteCompactness_bSetupUndoRedo_Offset;

	private static bool SetRerouteCompactness_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetRerouteCompactness_bPrintPythonCommand_PropertyAddress;

	private static int SetRerouteCompactness_bPrintPythonCommand_Offset;

	private static bool SetRerouteCompactness_ReturnValue_IsValid;

	private static FFieldAddress SetRerouteCompactness_ReturnValue_PropertyAddress;

	private static int SetRerouteCompactness_ReturnValue_Offset;

	private static bool SetRemappedVariable_IsValid;

	private static IntPtr SetRemappedVariable_FunctionAddress;

	private static int SetRemappedVariable_ParamsSize;

	private static bool SetRemappedVariable_InFunctionRefNode_IsValid;

	private static FFieldAddress SetRemappedVariable_InFunctionRefNode_PropertyAddress;

	private static int SetRemappedVariable_InFunctionRefNode_Offset;

	private static bool SetRemappedVariable_InInnerVariableName_IsValid;

	private static FFieldAddress SetRemappedVariable_InInnerVariableName_PropertyAddress;

	private static int SetRemappedVariable_InInnerVariableName_Offset;

	private static bool SetRemappedVariable_InOuterVariableName_IsValid;

	private static FFieldAddress SetRemappedVariable_InOuterVariableName_PropertyAddress;

	private static int SetRemappedVariable_InOuterVariableName_Offset;

	private static bool SetRemappedVariable_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetRemappedVariable_bSetupUndoRedo_PropertyAddress;

	private static int SetRemappedVariable_bSetupUndoRedo_Offset;

	private static bool SetRemappedVariable_ReturnValue_IsValid;

	private static FFieldAddress SetRemappedVariable_ReturnValue_PropertyAddress;

	private static int SetRemappedVariable_ReturnValue_Offset;

	private static bool SetPinIsWatched_IsValid;

	private static IntPtr SetPinIsWatched_FunctionAddress;

	private static int SetPinIsWatched_ParamsSize;

	private static bool SetPinIsWatched_InPinPath_IsValid;

	private static FFieldAddress SetPinIsWatched_InPinPath_PropertyAddress;

	private static int SetPinIsWatched_InPinPath_Offset;

	private static bool SetPinIsWatched_bIsWatched_IsValid;

	private static FFieldAddress SetPinIsWatched_bIsWatched_PropertyAddress;

	private static int SetPinIsWatched_bIsWatched_Offset;

	private static bool SetPinIsWatched_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetPinIsWatched_bSetupUndoRedo_PropertyAddress;

	private static int SetPinIsWatched_bSetupUndoRedo_Offset;

	private static bool SetPinIsWatched_ReturnValue_IsValid;

	private static FFieldAddress SetPinIsWatched_ReturnValue_PropertyAddress;

	private static int SetPinIsWatched_ReturnValue_Offset;

	private static bool SetPinExpansion_IsValid;

	private static IntPtr SetPinExpansion_FunctionAddress;

	private static int SetPinExpansion_ParamsSize;

	private static bool SetPinExpansion_InPinPath_IsValid;

	private static FFieldAddress SetPinExpansion_InPinPath_PropertyAddress;

	private static int SetPinExpansion_InPinPath_Offset;

	private static bool SetPinExpansion_bIsExpanded_IsValid;

	private static FFieldAddress SetPinExpansion_bIsExpanded_PropertyAddress;

	private static int SetPinExpansion_bIsExpanded_Offset;

	private static bool SetPinExpansion_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetPinExpansion_bSetupUndoRedo_PropertyAddress;

	private static int SetPinExpansion_bSetupUndoRedo_Offset;

	private static bool SetPinExpansion_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetPinExpansion_bPrintPythonCommand_PropertyAddress;

	private static int SetPinExpansion_bPrintPythonCommand_Offset;

	private static bool SetPinExpansion_ReturnValue_IsValid;

	private static FFieldAddress SetPinExpansion_ReturnValue_PropertyAddress;

	private static int SetPinExpansion_ReturnValue_Offset;

	private static bool SetPinDefaultValue_IsValid;

	private static IntPtr SetPinDefaultValue_FunctionAddress;

	private static int SetPinDefaultValue_ParamsSize;

	private static bool SetPinDefaultValue_InPinPath_IsValid;

	private static FFieldAddress SetPinDefaultValue_InPinPath_PropertyAddress;

	private static int SetPinDefaultValue_InPinPath_Offset;

	private static bool SetPinDefaultValue_InDefaultValue_IsValid;

	private static FFieldAddress SetPinDefaultValue_InDefaultValue_PropertyAddress;

	private static int SetPinDefaultValue_InDefaultValue_Offset;

	private static bool SetPinDefaultValue_bResizeArrays_IsValid;

	private static FFieldAddress SetPinDefaultValue_bResizeArrays_PropertyAddress;

	private static int SetPinDefaultValue_bResizeArrays_Offset;

	private static bool SetPinDefaultValue_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetPinDefaultValue_bSetupUndoRedo_PropertyAddress;

	private static int SetPinDefaultValue_bSetupUndoRedo_Offset;

	private static bool SetPinDefaultValue_bMergeUndoAction_IsValid;

	private static FFieldAddress SetPinDefaultValue_bMergeUndoAction_PropertyAddress;

	private static int SetPinDefaultValue_bMergeUndoAction_Offset;

	private static bool SetPinDefaultValue_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetPinDefaultValue_bPrintPythonCommand_PropertyAddress;

	private static int SetPinDefaultValue_bPrintPythonCommand_Offset;

	private static bool SetPinDefaultValue_ReturnValue_IsValid;

	private static FFieldAddress SetPinDefaultValue_ReturnValue_PropertyAddress;

	private static int SetPinDefaultValue_ReturnValue_Offset;

	private static bool SetNodeSizeByName_IsValid;

	private static IntPtr SetNodeSizeByName_FunctionAddress;

	private static int SetNodeSizeByName_ParamsSize;

	private static bool SetNodeSizeByName_InNodeName_IsValid;

	private static FFieldAddress SetNodeSizeByName_InNodeName_PropertyAddress;

	private static int SetNodeSizeByName_InNodeName_Offset;

	private static bool SetNodeSizeByName_InSize_IsValid;

	private static FFieldAddress SetNodeSizeByName_InSize_PropertyAddress;

	private static int SetNodeSizeByName_InSize_Offset;

	private static bool SetNodeSizeByName_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetNodeSizeByName_bSetupUndoRedo_PropertyAddress;

	private static int SetNodeSizeByName_bSetupUndoRedo_Offset;

	private static bool SetNodeSizeByName_bMergeUndoAction_IsValid;

	private static FFieldAddress SetNodeSizeByName_bMergeUndoAction_PropertyAddress;

	private static int SetNodeSizeByName_bMergeUndoAction_Offset;

	private static bool SetNodeSizeByName_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetNodeSizeByName_bPrintPythonCommand_PropertyAddress;

	private static int SetNodeSizeByName_bPrintPythonCommand_Offset;

	private static bool SetNodeSizeByName_ReturnValue_IsValid;

	private static FFieldAddress SetNodeSizeByName_ReturnValue_PropertyAddress;

	private static int SetNodeSizeByName_ReturnValue_Offset;

	private static bool SetNodeSize_IsValid;

	private static IntPtr SetNodeSize_FunctionAddress;

	private static int SetNodeSize_ParamsSize;

	private static bool SetNodeSize_InNode_IsValid;

	private static FFieldAddress SetNodeSize_InNode_PropertyAddress;

	private static int SetNodeSize_InNode_Offset;

	private static bool SetNodeSize_InSize_IsValid;

	private static FFieldAddress SetNodeSize_InSize_PropertyAddress;

	private static int SetNodeSize_InSize_Offset;

	private static bool SetNodeSize_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetNodeSize_bSetupUndoRedo_PropertyAddress;

	private static int SetNodeSize_bSetupUndoRedo_Offset;

	private static bool SetNodeSize_bMergeUndoAction_IsValid;

	private static FFieldAddress SetNodeSize_bMergeUndoAction_PropertyAddress;

	private static int SetNodeSize_bMergeUndoAction_Offset;

	private static bool SetNodeSize_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetNodeSize_bPrintPythonCommand_PropertyAddress;

	private static int SetNodeSize_bPrintPythonCommand_Offset;

	private static bool SetNodeSize_ReturnValue_IsValid;

	private static FFieldAddress SetNodeSize_ReturnValue_PropertyAddress;

	private static int SetNodeSize_ReturnValue_Offset;

	private static bool SetNodeSelection_IsValid;

	private static IntPtr SetNodeSelection_FunctionAddress;

	private static int SetNodeSelection_ParamsSize;

	private static bool SetNodeSelection_InNodeNames_IsValid;

	private static FFieldAddress SetNodeSelection_InNodeNames_PropertyAddress;

	private static int SetNodeSelection_InNodeNames_Offset;

	private static bool SetNodeSelection_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetNodeSelection_bSetupUndoRedo_PropertyAddress;

	private static int SetNodeSelection_bSetupUndoRedo_Offset;

	private static bool SetNodeSelection_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetNodeSelection_bPrintPythonCommand_PropertyAddress;

	private static int SetNodeSelection_bPrintPythonCommand_Offset;

	private static bool SetNodeSelection_ReturnValue_IsValid;

	private static FFieldAddress SetNodeSelection_ReturnValue_PropertyAddress;

	private static int SetNodeSelection_ReturnValue_Offset;

	private static bool SetNodePositionByName_IsValid;

	private static IntPtr SetNodePositionByName_FunctionAddress;

	private static int SetNodePositionByName_ParamsSize;

	private static bool SetNodePositionByName_InNodeName_IsValid;

	private static FFieldAddress SetNodePositionByName_InNodeName_PropertyAddress;

	private static int SetNodePositionByName_InNodeName_Offset;

	private static bool SetNodePositionByName_InPosition_IsValid;

	private static FFieldAddress SetNodePositionByName_InPosition_PropertyAddress;

	private static int SetNodePositionByName_InPosition_Offset;

	private static bool SetNodePositionByName_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetNodePositionByName_bSetupUndoRedo_PropertyAddress;

	private static int SetNodePositionByName_bSetupUndoRedo_Offset;

	private static bool SetNodePositionByName_bMergeUndoAction_IsValid;

	private static FFieldAddress SetNodePositionByName_bMergeUndoAction_PropertyAddress;

	private static int SetNodePositionByName_bMergeUndoAction_Offset;

	private static bool SetNodePositionByName_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetNodePositionByName_bPrintPythonCommand_PropertyAddress;

	private static int SetNodePositionByName_bPrintPythonCommand_Offset;

	private static bool SetNodePositionByName_ReturnValue_IsValid;

	private static FFieldAddress SetNodePositionByName_ReturnValue_PropertyAddress;

	private static int SetNodePositionByName_ReturnValue_Offset;

	private static bool SetNodePosition_IsValid;

	private static IntPtr SetNodePosition_FunctionAddress;

	private static int SetNodePosition_ParamsSize;

	private static bool SetNodePosition_InNode_IsValid;

	private static FFieldAddress SetNodePosition_InNode_PropertyAddress;

	private static int SetNodePosition_InNode_Offset;

	private static bool SetNodePosition_InPosition_IsValid;

	private static FFieldAddress SetNodePosition_InPosition_PropertyAddress;

	private static int SetNodePosition_InPosition_Offset;

	private static bool SetNodePosition_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetNodePosition_bSetupUndoRedo_PropertyAddress;

	private static int SetNodePosition_bSetupUndoRedo_Offset;

	private static bool SetNodePosition_bMergeUndoAction_IsValid;

	private static FFieldAddress SetNodePosition_bMergeUndoAction_PropertyAddress;

	private static int SetNodePosition_bMergeUndoAction_Offset;

	private static bool SetNodePosition_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetNodePosition_bPrintPythonCommand_PropertyAddress;

	private static int SetNodePosition_bPrintPythonCommand_Offset;

	private static bool SetNodePosition_ReturnValue_IsValid;

	private static FFieldAddress SetNodePosition_ReturnValue_PropertyAddress;

	private static int SetNodePosition_ReturnValue_Offset;

	private static bool SetNodeKeywordsByName_IsValid;

	private static IntPtr SetNodeKeywordsByName_FunctionAddress;

	private static int SetNodeKeywordsByName_ParamsSize;

	private static bool SetNodeKeywordsByName_InNodeName_IsValid;

	private static FFieldAddress SetNodeKeywordsByName_InNodeName_PropertyAddress;

	private static int SetNodeKeywordsByName_InNodeName_Offset;

	private static bool SetNodeKeywordsByName_InKeywords_IsValid;

	private static FFieldAddress SetNodeKeywordsByName_InKeywords_PropertyAddress;

	private static int SetNodeKeywordsByName_InKeywords_Offset;

	private static bool SetNodeKeywordsByName_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetNodeKeywordsByName_bSetupUndoRedo_PropertyAddress;

	private static int SetNodeKeywordsByName_bSetupUndoRedo_Offset;

	private static bool SetNodeKeywordsByName_bMergeUndoAction_IsValid;

	private static FFieldAddress SetNodeKeywordsByName_bMergeUndoAction_PropertyAddress;

	private static int SetNodeKeywordsByName_bMergeUndoAction_Offset;

	private static bool SetNodeKeywordsByName_ReturnValue_IsValid;

	private static FFieldAddress SetNodeKeywordsByName_ReturnValue_PropertyAddress;

	private static int SetNodeKeywordsByName_ReturnValue_Offset;

	private static bool SetNodeKeywords_IsValid;

	private static IntPtr SetNodeKeywords_FunctionAddress;

	private static int SetNodeKeywords_ParamsSize;

	private static bool SetNodeKeywords_InNode_IsValid;

	private static FFieldAddress SetNodeKeywords_InNode_PropertyAddress;

	private static int SetNodeKeywords_InNode_Offset;

	private static bool SetNodeKeywords_InKeywords_IsValid;

	private static FFieldAddress SetNodeKeywords_InKeywords_PropertyAddress;

	private static int SetNodeKeywords_InKeywords_Offset;

	private static bool SetNodeKeywords_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetNodeKeywords_bSetupUndoRedo_PropertyAddress;

	private static int SetNodeKeywords_bSetupUndoRedo_Offset;

	private static bool SetNodeKeywords_bMergeUndoAction_IsValid;

	private static FFieldAddress SetNodeKeywords_bMergeUndoAction_PropertyAddress;

	private static int SetNodeKeywords_bMergeUndoAction_Offset;

	private static bool SetNodeKeywords_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetNodeKeywords_bPrintPythonCommand_PropertyAddress;

	private static int SetNodeKeywords_bPrintPythonCommand_Offset;

	private static bool SetNodeKeywords_ReturnValue_IsValid;

	private static FFieldAddress SetNodeKeywords_ReturnValue_PropertyAddress;

	private static int SetNodeKeywords_ReturnValue_Offset;

	private static bool SetNodeDescriptionByName_IsValid;

	private static IntPtr SetNodeDescriptionByName_FunctionAddress;

	private static int SetNodeDescriptionByName_ParamsSize;

	private static bool SetNodeDescriptionByName_InNodeName_IsValid;

	private static FFieldAddress SetNodeDescriptionByName_InNodeName_PropertyAddress;

	private static int SetNodeDescriptionByName_InNodeName_Offset;

	private static bool SetNodeDescriptionByName_InDescription_IsValid;

	private static FFieldAddress SetNodeDescriptionByName_InDescription_PropertyAddress;

	private static int SetNodeDescriptionByName_InDescription_Offset;

	private static bool SetNodeDescriptionByName_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetNodeDescriptionByName_bSetupUndoRedo_PropertyAddress;

	private static int SetNodeDescriptionByName_bSetupUndoRedo_Offset;

	private static bool SetNodeDescriptionByName_bMergeUndoAction_IsValid;

	private static FFieldAddress SetNodeDescriptionByName_bMergeUndoAction_PropertyAddress;

	private static int SetNodeDescriptionByName_bMergeUndoAction_Offset;

	private static bool SetNodeDescriptionByName_ReturnValue_IsValid;

	private static FFieldAddress SetNodeDescriptionByName_ReturnValue_PropertyAddress;

	private static int SetNodeDescriptionByName_ReturnValue_Offset;

	private static bool SetNodeDescription_IsValid;

	private static IntPtr SetNodeDescription_FunctionAddress;

	private static int SetNodeDescription_ParamsSize;

	private static bool SetNodeDescription_InNode_IsValid;

	private static FFieldAddress SetNodeDescription_InNode_PropertyAddress;

	private static int SetNodeDescription_InNode_Offset;

	private static bool SetNodeDescription_InDescription_IsValid;

	private static FFieldAddress SetNodeDescription_InDescription_PropertyAddress;

	private static int SetNodeDescription_InDescription_Offset;

	private static bool SetNodeDescription_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetNodeDescription_bSetupUndoRedo_PropertyAddress;

	private static int SetNodeDescription_bSetupUndoRedo_Offset;

	private static bool SetNodeDescription_bMergeUndoAction_IsValid;

	private static FFieldAddress SetNodeDescription_bMergeUndoAction_PropertyAddress;

	private static int SetNodeDescription_bMergeUndoAction_Offset;

	private static bool SetNodeDescription_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetNodeDescription_bPrintPythonCommand_PropertyAddress;

	private static int SetNodeDescription_bPrintPythonCommand_Offset;

	private static bool SetNodeDescription_ReturnValue_IsValid;

	private static FFieldAddress SetNodeDescription_ReturnValue_PropertyAddress;

	private static int SetNodeDescription_ReturnValue_Offset;

	private static bool SetNodeColorByName_IsValid;

	private static IntPtr SetNodeColorByName_FunctionAddress;

	private static int SetNodeColorByName_ParamsSize;

	private static bool SetNodeColorByName_InNodeName_IsValid;

	private static FFieldAddress SetNodeColorByName_InNodeName_PropertyAddress;

	private static int SetNodeColorByName_InNodeName_Offset;

	private static bool SetNodeColorByName_InColor_IsValid;

	private static FFieldAddress SetNodeColorByName_InColor_PropertyAddress;

	private static int SetNodeColorByName_InColor_Offset;

	private static bool SetNodeColorByName_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetNodeColorByName_bSetupUndoRedo_PropertyAddress;

	private static int SetNodeColorByName_bSetupUndoRedo_Offset;

	private static bool SetNodeColorByName_bMergeUndoAction_IsValid;

	private static FFieldAddress SetNodeColorByName_bMergeUndoAction_PropertyAddress;

	private static int SetNodeColorByName_bMergeUndoAction_Offset;

	private static bool SetNodeColorByName_ReturnValue_IsValid;

	private static FFieldAddress SetNodeColorByName_ReturnValue_PropertyAddress;

	private static int SetNodeColorByName_ReturnValue_Offset;

	private static bool SetNodeColor_IsValid;

	private static IntPtr SetNodeColor_FunctionAddress;

	private static int SetNodeColor_ParamsSize;

	private static bool SetNodeColor_InNode_IsValid;

	private static FFieldAddress SetNodeColor_InNode_PropertyAddress;

	private static int SetNodeColor_InNode_Offset;

	private static bool SetNodeColor_InColor_IsValid;

	private static FFieldAddress SetNodeColor_InColor_PropertyAddress;

	private static int SetNodeColor_InColor_Offset;

	private static bool SetNodeColor_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetNodeColor_bSetupUndoRedo_PropertyAddress;

	private static int SetNodeColor_bSetupUndoRedo_Offset;

	private static bool SetNodeColor_bMergeUndoAction_IsValid;

	private static FFieldAddress SetNodeColor_bMergeUndoAction_PropertyAddress;

	private static int SetNodeColor_bMergeUndoAction_Offset;

	private static bool SetNodeColor_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetNodeColor_bPrintPythonCommand_PropertyAddress;

	private static int SetNodeColor_bPrintPythonCommand_Offset;

	private static bool SetNodeColor_ReturnValue_IsValid;

	private static FFieldAddress SetNodeColor_ReturnValue_PropertyAddress;

	private static int SetNodeColor_ReturnValue_Offset;

	private static bool SetNodeCategoryByName_IsValid;

	private static IntPtr SetNodeCategoryByName_FunctionAddress;

	private static int SetNodeCategoryByName_ParamsSize;

	private static bool SetNodeCategoryByName_InNodeName_IsValid;

	private static FFieldAddress SetNodeCategoryByName_InNodeName_PropertyAddress;

	private static int SetNodeCategoryByName_InNodeName_Offset;

	private static bool SetNodeCategoryByName_InCategory_IsValid;

	private static FFieldAddress SetNodeCategoryByName_InCategory_PropertyAddress;

	private static int SetNodeCategoryByName_InCategory_Offset;

	private static bool SetNodeCategoryByName_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetNodeCategoryByName_bSetupUndoRedo_PropertyAddress;

	private static int SetNodeCategoryByName_bSetupUndoRedo_Offset;

	private static bool SetNodeCategoryByName_bMergeUndoAction_IsValid;

	private static FFieldAddress SetNodeCategoryByName_bMergeUndoAction_PropertyAddress;

	private static int SetNodeCategoryByName_bMergeUndoAction_Offset;

	private static bool SetNodeCategoryByName_ReturnValue_IsValid;

	private static FFieldAddress SetNodeCategoryByName_ReturnValue_PropertyAddress;

	private static int SetNodeCategoryByName_ReturnValue_Offset;

	private static bool SetNodeCategory_IsValid;

	private static IntPtr SetNodeCategory_FunctionAddress;

	private static int SetNodeCategory_ParamsSize;

	private static bool SetNodeCategory_InNode_IsValid;

	private static FFieldAddress SetNodeCategory_InNode_PropertyAddress;

	private static int SetNodeCategory_InNode_Offset;

	private static bool SetNodeCategory_InCategory_IsValid;

	private static FFieldAddress SetNodeCategory_InCategory_PropertyAddress;

	private static int SetNodeCategory_InCategory_Offset;

	private static bool SetNodeCategory_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetNodeCategory_bSetupUndoRedo_PropertyAddress;

	private static int SetNodeCategory_bSetupUndoRedo_Offset;

	private static bool SetNodeCategory_bMergeUndoAction_IsValid;

	private static FFieldAddress SetNodeCategory_bMergeUndoAction_PropertyAddress;

	private static int SetNodeCategory_bMergeUndoAction_Offset;

	private static bool SetNodeCategory_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetNodeCategory_bPrintPythonCommand_PropertyAddress;

	private static int SetNodeCategory_bPrintPythonCommand_Offset;

	private static bool SetNodeCategory_ReturnValue_IsValid;

	private static FFieldAddress SetNodeCategory_ReturnValue_PropertyAddress;

	private static int SetNodeCategory_ReturnValue_Offset;

	private static bool SetLocalVariableTypeFromObjectPath_IsValid;

	private static IntPtr SetLocalVariableTypeFromObjectPath_FunctionAddress;

	private static int SetLocalVariableTypeFromObjectPath_ParamsSize;

	private static bool SetLocalVariableTypeFromObjectPath_InVariableName_IsValid;

	private static FFieldAddress SetLocalVariableTypeFromObjectPath_InVariableName_PropertyAddress;

	private static int SetLocalVariableTypeFromObjectPath_InVariableName_Offset;

	private static bool SetLocalVariableTypeFromObjectPath_InCPPType_IsValid;

	private static FFieldAddress SetLocalVariableTypeFromObjectPath_InCPPType_PropertyAddress;

	private static int SetLocalVariableTypeFromObjectPath_InCPPType_Offset;

	private static bool SetLocalVariableTypeFromObjectPath_InCPPTypeObjectPath_IsValid;

	private static FFieldAddress SetLocalVariableTypeFromObjectPath_InCPPTypeObjectPath_PropertyAddress;

	private static int SetLocalVariableTypeFromObjectPath_InCPPTypeObjectPath_Offset;

	private static bool SetLocalVariableTypeFromObjectPath_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetLocalVariableTypeFromObjectPath_bSetupUndoRedo_PropertyAddress;

	private static int SetLocalVariableTypeFromObjectPath_bSetupUndoRedo_Offset;

	private static bool SetLocalVariableTypeFromObjectPath_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetLocalVariableTypeFromObjectPath_bPrintPythonCommand_PropertyAddress;

	private static int SetLocalVariableTypeFromObjectPath_bPrintPythonCommand_Offset;

	private static bool SetLocalVariableTypeFromObjectPath_ReturnValue_IsValid;

	private static FFieldAddress SetLocalVariableTypeFromObjectPath_ReturnValue_PropertyAddress;

	private static int SetLocalVariableTypeFromObjectPath_ReturnValue_Offset;

	private static bool SetLocalVariableType_IsValid;

	private static IntPtr SetLocalVariableType_FunctionAddress;

	private static int SetLocalVariableType_ParamsSize;

	private static bool SetLocalVariableType_InVariableName_IsValid;

	private static FFieldAddress SetLocalVariableType_InVariableName_PropertyAddress;

	private static int SetLocalVariableType_InVariableName_Offset;

	private static bool SetLocalVariableType_InCPPType_IsValid;

	private static FFieldAddress SetLocalVariableType_InCPPType_PropertyAddress;

	private static int SetLocalVariableType_InCPPType_Offset;

	private static bool SetLocalVariableType_InCPPTypeObject_IsValid;

	private static FFieldAddress SetLocalVariableType_InCPPTypeObject_PropertyAddress;

	private static int SetLocalVariableType_InCPPTypeObject_Offset;

	private static bool SetLocalVariableType_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetLocalVariableType_bSetupUndoRedo_PropertyAddress;

	private static int SetLocalVariableType_bSetupUndoRedo_Offset;

	private static bool SetLocalVariableType_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetLocalVariableType_bPrintPythonCommand_PropertyAddress;

	private static int SetLocalVariableType_bPrintPythonCommand_Offset;

	private static bool SetLocalVariableType_ReturnValue_IsValid;

	private static FFieldAddress SetLocalVariableType_ReturnValue_PropertyAddress;

	private static int SetLocalVariableType_ReturnValue_Offset;

	private static bool SetLocalVariableDefaultValue_IsValid;

	private static IntPtr SetLocalVariableDefaultValue_FunctionAddress;

	private static int SetLocalVariableDefaultValue_ParamsSize;

	private static bool SetLocalVariableDefaultValue_InVariableName_IsValid;

	private static FFieldAddress SetLocalVariableDefaultValue_InVariableName_PropertyAddress;

	private static int SetLocalVariableDefaultValue_InVariableName_Offset;

	private static bool SetLocalVariableDefaultValue_InDefaultValue_IsValid;

	private static FFieldAddress SetLocalVariableDefaultValue_InDefaultValue_PropertyAddress;

	private static int SetLocalVariableDefaultValue_InDefaultValue_Offset;

	private static bool SetLocalVariableDefaultValue_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetLocalVariableDefaultValue_bSetupUndoRedo_PropertyAddress;

	private static int SetLocalVariableDefaultValue_bSetupUndoRedo_Offset;

	private static bool SetLocalVariableDefaultValue_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetLocalVariableDefaultValue_bPrintPythonCommand_PropertyAddress;

	private static int SetLocalVariableDefaultValue_bPrintPythonCommand_Offset;

	private static bool SetLocalVariableDefaultValue_bNotify_IsValid;

	private static FFieldAddress SetLocalVariableDefaultValue_bNotify_PropertyAddress;

	private static int SetLocalVariableDefaultValue_bNotify_Offset;

	private static bool SetLocalVariableDefaultValue_ReturnValue_IsValid;

	private static FFieldAddress SetLocalVariableDefaultValue_ReturnValue_PropertyAddress;

	private static int SetLocalVariableDefaultValue_ReturnValue_Offset;

	private static bool SetIsRunningUnitTest_IsValid;

	private static IntPtr SetIsRunningUnitTest_FunctionAddress;

	private static int SetIsRunningUnitTest_ParamsSize;

	private static bool SetIsRunningUnitTest_bIsRunning_IsValid;

	private static FFieldAddress SetIsRunningUnitTest_bIsRunning_PropertyAddress;

	private static int SetIsRunningUnitTest_bIsRunning_Offset;

	private static bool SetGraph_IsValid;

	private static IntPtr SetGraph_FunctionAddress;

	private static int SetGraph_ParamsSize;

	private static bool SetGraph_InGraph_IsValid;

	private static FFieldAddress SetGraph_InGraph_PropertyAddress;

	private static int SetGraph_InGraph_Offset;

	private static bool SetExposedPinIndex_IsValid;

	private static IntPtr SetExposedPinIndex_FunctionAddress;

	private static int SetExposedPinIndex_ParamsSize;

	private static bool SetExposedPinIndex_InPinName_IsValid;

	private static FFieldAddress SetExposedPinIndex_InPinName_PropertyAddress;

	private static int SetExposedPinIndex_InPinName_Offset;

	private static bool SetExposedPinIndex_InNewIndex_IsValid;

	private static FFieldAddress SetExposedPinIndex_InNewIndex_PropertyAddress;

	private static int SetExposedPinIndex_InNewIndex_Offset;

	private static bool SetExposedPinIndex_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetExposedPinIndex_bSetupUndoRedo_PropertyAddress;

	private static int SetExposedPinIndex_bSetupUndoRedo_Offset;

	private static bool SetExposedPinIndex_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetExposedPinIndex_bPrintPythonCommand_PropertyAddress;

	private static int SetExposedPinIndex_bPrintPythonCommand_Offset;

	private static bool SetExposedPinIndex_ReturnValue_IsValid;

	private static FFieldAddress SetExposedPinIndex_ReturnValue_PropertyAddress;

	private static int SetExposedPinIndex_ReturnValue_Offset;

	private static bool SetCommentTextByName_IsValid;

	private static IntPtr SetCommentTextByName_FunctionAddress;

	private static int SetCommentTextByName_ParamsSize;

	private static bool SetCommentTextByName_InNodeName_IsValid;

	private static FFieldAddress SetCommentTextByName_InNodeName_PropertyAddress;

	private static int SetCommentTextByName_InNodeName_Offset;

	private static bool SetCommentTextByName_InCommentText_IsValid;

	private static FFieldAddress SetCommentTextByName_InCommentText_PropertyAddress;

	private static int SetCommentTextByName_InCommentText_Offset;

	private static bool SetCommentTextByName_InCommentFontSize_IsValid;

	private static FFieldAddress SetCommentTextByName_InCommentFontSize_PropertyAddress;

	private static int SetCommentTextByName_InCommentFontSize_Offset;

	private static bool SetCommentTextByName_bInCommentBubbleVisible_IsValid;

	private static FFieldAddress SetCommentTextByName_bInCommentBubbleVisible_PropertyAddress;

	private static int SetCommentTextByName_bInCommentBubbleVisible_Offset;

	private static bool SetCommentTextByName_bInCommentColorBubble_IsValid;

	private static FFieldAddress SetCommentTextByName_bInCommentColorBubble_PropertyAddress;

	private static int SetCommentTextByName_bInCommentColorBubble_Offset;

	private static bool SetCommentTextByName_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetCommentTextByName_bSetupUndoRedo_PropertyAddress;

	private static int SetCommentTextByName_bSetupUndoRedo_Offset;

	private static bool SetCommentTextByName_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetCommentTextByName_bPrintPythonCommand_PropertyAddress;

	private static int SetCommentTextByName_bPrintPythonCommand_Offset;

	private static bool SetCommentTextByName_ReturnValue_IsValid;

	private static FFieldAddress SetCommentTextByName_ReturnValue_PropertyAddress;

	private static int SetCommentTextByName_ReturnValue_Offset;

	private static bool SetCommentText_IsValid;

	private static IntPtr SetCommentText_FunctionAddress;

	private static int SetCommentText_ParamsSize;

	private static bool SetCommentText_InNode_IsValid;

	private static FFieldAddress SetCommentText_InNode_PropertyAddress;

	private static int SetCommentText_InNode_Offset;

	private static bool SetCommentText_InCommentText_IsValid;

	private static FFieldAddress SetCommentText_InCommentText_PropertyAddress;

	private static int SetCommentText_InCommentText_Offset;

	private static bool SetCommentText_InCommentFontSize_IsValid;

	private static FFieldAddress SetCommentText_InCommentFontSize_PropertyAddress;

	private static int SetCommentText_InCommentFontSize_Offset;

	private static bool SetCommentText_bInCommentBubbleVisible_IsValid;

	private static FFieldAddress SetCommentText_bInCommentBubbleVisible_PropertyAddress;

	private static int SetCommentText_bInCommentBubbleVisible_Offset;

	private static bool SetCommentText_bInCommentColorBubble_IsValid;

	private static FFieldAddress SetCommentText_bInCommentColorBubble_PropertyAddress;

	private static int SetCommentText_bInCommentColorBubble_Offset;

	private static bool SetCommentText_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetCommentText_bSetupUndoRedo_PropertyAddress;

	private static int SetCommentText_bSetupUndoRedo_Offset;

	private static bool SetCommentText_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetCommentText_bPrintPythonCommand_PropertyAddress;

	private static int SetCommentText_bPrintPythonCommand_Offset;

	private static bool SetCommentText_ReturnValue_IsValid;

	private static FFieldAddress SetCommentText_ReturnValue_PropertyAddress;

	private static int SetCommentText_ReturnValue_Offset;

	private static bool SetArrayPinSize_IsValid;

	private static IntPtr SetArrayPinSize_FunctionAddress;

	private static int SetArrayPinSize_ParamsSize;

	private static bool SetArrayPinSize_InArrayPinPath_IsValid;

	private static FFieldAddress SetArrayPinSize_InArrayPinPath_PropertyAddress;

	private static int SetArrayPinSize_InArrayPinPath_Offset;

	private static bool SetArrayPinSize_InSize_IsValid;

	private static FFieldAddress SetArrayPinSize_InSize_PropertyAddress;

	private static int SetArrayPinSize_InSize_Offset;

	private static bool SetArrayPinSize_InDefaultValue_IsValid;

	private static FFieldAddress SetArrayPinSize_InDefaultValue_PropertyAddress;

	private static int SetArrayPinSize_InDefaultValue_Offset;

	private static bool SetArrayPinSize_bSetupUndoRedo_IsValid;

	private static FFieldAddress SetArrayPinSize_bSetupUndoRedo_PropertyAddress;

	private static int SetArrayPinSize_bSetupUndoRedo_Offset;

	private static bool SetArrayPinSize_bPrintPythonCommand_IsValid;

	private static FFieldAddress SetArrayPinSize_bPrintPythonCommand_PropertyAddress;

	private static int SetArrayPinSize_bPrintPythonCommand_Offset;

	private static bool SetArrayPinSize_ReturnValue_IsValid;

	private static FFieldAddress SetArrayPinSize_ReturnValue_PropertyAddress;

	private static int SetArrayPinSize_ReturnValue_Offset;

	private static bool SelectNodeByName_IsValid;

	private static IntPtr SelectNodeByName_FunctionAddress;

	private static int SelectNodeByName_ParamsSize;

	private static bool SelectNodeByName_InNodeName_IsValid;

	private static FFieldAddress SelectNodeByName_InNodeName_PropertyAddress;

	private static int SelectNodeByName_InNodeName_Offset;

	private static bool SelectNodeByName_bSelect_IsValid;

	private static FFieldAddress SelectNodeByName_bSelect_PropertyAddress;

	private static int SelectNodeByName_bSelect_Offset;

	private static bool SelectNodeByName_bSetupUndoRedo_IsValid;

	private static FFieldAddress SelectNodeByName_bSetupUndoRedo_PropertyAddress;

	private static int SelectNodeByName_bSetupUndoRedo_Offset;

	private static bool SelectNodeByName_ReturnValue_IsValid;

	private static FFieldAddress SelectNodeByName_ReturnValue_PropertyAddress;

	private static int SelectNodeByName_ReturnValue_Offset;

	private static bool SelectNode_IsValid;

	private static IntPtr SelectNode_FunctionAddress;

	private static int SelectNode_ParamsSize;

	private static bool SelectNode_InNode_IsValid;

	private static FFieldAddress SelectNode_InNode_PropertyAddress;

	private static int SelectNode_InNode_Offset;

	private static bool SelectNode_bSelect_IsValid;

	private static FFieldAddress SelectNode_bSelect_PropertyAddress;

	private static int SelectNode_bSelect_Offset;

	private static bool SelectNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress SelectNode_bSetupUndoRedo_PropertyAddress;

	private static int SelectNode_bSetupUndoRedo_Offset;

	private static bool SelectNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress SelectNode_bPrintPythonCommand_PropertyAddress;

	private static int SelectNode_bPrintPythonCommand_Offset;

	private static bool SelectNode_ReturnValue_IsValid;

	private static FFieldAddress SelectNode_ReturnValue_PropertyAddress;

	private static int SelectNode_ReturnValue_Offset;

	private static bool ResetPinDefaultValue_IsValid;

	private static IntPtr ResetPinDefaultValue_FunctionAddress;

	private static int ResetPinDefaultValue_ParamsSize;

	private static bool ResetPinDefaultValue_InPinPath_IsValid;

	private static FFieldAddress ResetPinDefaultValue_InPinPath_PropertyAddress;

	private static int ResetPinDefaultValue_InPinPath_Offset;

	private static bool ResetPinDefaultValue_bSetupUndoRedo_IsValid;

	private static FFieldAddress ResetPinDefaultValue_bSetupUndoRedo_PropertyAddress;

	private static int ResetPinDefaultValue_bSetupUndoRedo_Offset;

	private static bool ResetPinDefaultValue_bPrintPythonCommand_IsValid;

	private static FFieldAddress ResetPinDefaultValue_bPrintPythonCommand_PropertyAddress;

	private static int ResetPinDefaultValue_bPrintPythonCommand_Offset;

	private static bool ResetPinDefaultValue_ReturnValue_IsValid;

	private static FFieldAddress ResetPinDefaultValue_ReturnValue_PropertyAddress;

	private static int ResetPinDefaultValue_ReturnValue_Offset;

	private static bool ReplaceParameterNodeWithVariable_IsValid;

	private static IntPtr ReplaceParameterNodeWithVariable_FunctionAddress;

	private static int ReplaceParameterNodeWithVariable_ParamsSize;

	private static bool ReplaceParameterNodeWithVariable_InNodeName_IsValid;

	private static FFieldAddress ReplaceParameterNodeWithVariable_InNodeName_PropertyAddress;

	private static int ReplaceParameterNodeWithVariable_InNodeName_Offset;

	private static bool ReplaceParameterNodeWithVariable_InVariableName_IsValid;

	private static FFieldAddress ReplaceParameterNodeWithVariable_InVariableName_PropertyAddress;

	private static int ReplaceParameterNodeWithVariable_InVariableName_Offset;

	private static bool ReplaceParameterNodeWithVariable_InCPPType_IsValid;

	private static FFieldAddress ReplaceParameterNodeWithVariable_InCPPType_PropertyAddress;

	private static int ReplaceParameterNodeWithVariable_InCPPType_Offset;

	private static bool ReplaceParameterNodeWithVariable_InCPPTypeObject_IsValid;

	private static FFieldAddress ReplaceParameterNodeWithVariable_InCPPTypeObject_PropertyAddress;

	private static int ReplaceParameterNodeWithVariable_InCPPTypeObject_Offset;

	private static bool ReplaceParameterNodeWithVariable_bSetupUndoRedo_IsValid;

	private static FFieldAddress ReplaceParameterNodeWithVariable_bSetupUndoRedo_PropertyAddress;

	private static int ReplaceParameterNodeWithVariable_bSetupUndoRedo_Offset;

	private static bool ReplaceParameterNodeWithVariable_ReturnValue_IsValid;

	private static FFieldAddress ReplaceParameterNodeWithVariable_ReturnValue_PropertyAddress;

	private static int ReplaceParameterNodeWithVariable_ReturnValue_Offset;

	private static bool RenameVariable_IsValid;

	private static IntPtr RenameVariable_FunctionAddress;

	private static int RenameVariable_ParamsSize;

	private static bool RenameVariable_InOldName_IsValid;

	private static FFieldAddress RenameVariable_InOldName_PropertyAddress;

	private static int RenameVariable_InOldName_Offset;

	private static bool RenameVariable_InNewName_IsValid;

	private static FFieldAddress RenameVariable_InNewName_PropertyAddress;

	private static int RenameVariable_InNewName_Offset;

	private static bool RenameVariable_bSetupUndoRedo_IsValid;

	private static FFieldAddress RenameVariable_bSetupUndoRedo_PropertyAddress;

	private static int RenameVariable_bSetupUndoRedo_Offset;

	private static bool RenameVariable_ReturnValue_IsValid;

	private static FFieldAddress RenameVariable_ReturnValue_PropertyAddress;

	private static int RenameVariable_ReturnValue_Offset;

	private static bool RenameParameter_IsValid;

	private static IntPtr RenameParameter_FunctionAddress;

	private static int RenameParameter_ParamsSize;

	private static bool RenameParameter_InOldName_IsValid;

	private static FFieldAddress RenameParameter_InOldName_PropertyAddress;

	private static int RenameParameter_InOldName_Offset;

	private static bool RenameParameter_InNewName_IsValid;

	private static FFieldAddress RenameParameter_InNewName_PropertyAddress;

	private static int RenameParameter_InNewName_Offset;

	private static bool RenameParameter_bSetupUndoRedo_IsValid;

	private static FFieldAddress RenameParameter_bSetupUndoRedo_PropertyAddress;

	private static int RenameParameter_bSetupUndoRedo_Offset;

	private static bool RenameParameter_ReturnValue_IsValid;

	private static FFieldAddress RenameParameter_ReturnValue_PropertyAddress;

	private static int RenameParameter_ReturnValue_Offset;

	private static bool RenameNode_IsValid;

	private static IntPtr RenameNode_FunctionAddress;

	private static int RenameNode_ParamsSize;

	private static bool RenameNode_InNode_IsValid;

	private static FFieldAddress RenameNode_InNode_PropertyAddress;

	private static int RenameNode_InNode_Offset;

	private static bool RenameNode_InNewName_IsValid;

	private static FFieldAddress RenameNode_InNewName_PropertyAddress;

	private static int RenameNode_InNewName_Offset;

	private static bool RenameNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress RenameNode_bSetupUndoRedo_PropertyAddress;

	private static int RenameNode_bSetupUndoRedo_Offset;

	private static bool RenameNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress RenameNode_bPrintPythonCommand_PropertyAddress;

	private static int RenameNode_bPrintPythonCommand_Offset;

	private static bool RenameNode_ReturnValue_IsValid;

	private static FFieldAddress RenameNode_ReturnValue_PropertyAddress;

	private static int RenameNode_ReturnValue_Offset;

	private static bool RenameLocalVariable_IsValid;

	private static IntPtr RenameLocalVariable_FunctionAddress;

	private static int RenameLocalVariable_ParamsSize;

	private static bool RenameLocalVariable_InVariableName_IsValid;

	private static FFieldAddress RenameLocalVariable_InVariableName_PropertyAddress;

	private static int RenameLocalVariable_InVariableName_Offset;

	private static bool RenameLocalVariable_InNewVariableName_IsValid;

	private static FFieldAddress RenameLocalVariable_InNewVariableName_PropertyAddress;

	private static int RenameLocalVariable_InNewVariableName_Offset;

	private static bool RenameLocalVariable_bSetupUndoRedo_IsValid;

	private static FFieldAddress RenameLocalVariable_bSetupUndoRedo_PropertyAddress;

	private static int RenameLocalVariable_bSetupUndoRedo_Offset;

	private static bool RenameLocalVariable_bPrintPythonCommand_IsValid;

	private static FFieldAddress RenameLocalVariable_bPrintPythonCommand_PropertyAddress;

	private static int RenameLocalVariable_bPrintPythonCommand_Offset;

	private static bool RenameLocalVariable_ReturnValue_IsValid;

	private static FFieldAddress RenameLocalVariable_ReturnValue_PropertyAddress;

	private static int RenameLocalVariable_ReturnValue_Offset;

	private static bool RenameFunction_IsValid;

	private static IntPtr RenameFunction_FunctionAddress;

	private static int RenameFunction_ParamsSize;

	private static bool RenameFunction_InOldFunctionName_IsValid;

	private static FFieldAddress RenameFunction_InOldFunctionName_PropertyAddress;

	private static int RenameFunction_InOldFunctionName_Offset;

	private static bool RenameFunction_InNewFunctionName_IsValid;

	private static FFieldAddress RenameFunction_InNewFunctionName_PropertyAddress;

	private static int RenameFunction_InNewFunctionName_Offset;

	private static bool RenameFunction_bSetupUndoRedo_IsValid;

	private static FFieldAddress RenameFunction_bSetupUndoRedo_PropertyAddress;

	private static int RenameFunction_bSetupUndoRedo_Offset;

	private static bool RenameFunction_ReturnValue_IsValid;

	private static FFieldAddress RenameFunction_ReturnValue_PropertyAddress;

	private static int RenameFunction_ReturnValue_Offset;

	private static bool RenameExposedPin_IsValid;

	private static IntPtr RenameExposedPin_FunctionAddress;

	private static int RenameExposedPin_ParamsSize;

	private static bool RenameExposedPin_InOldPinName_IsValid;

	private static FFieldAddress RenameExposedPin_InOldPinName_PropertyAddress;

	private static int RenameExposedPin_InOldPinName_Offset;

	private static bool RenameExposedPin_InNewPinName_IsValid;

	private static FFieldAddress RenameExposedPin_InNewPinName_PropertyAddress;

	private static int RenameExposedPin_InNewPinName_Offset;

	private static bool RenameExposedPin_bSetupUndoRedo_IsValid;

	private static FFieldAddress RenameExposedPin_bSetupUndoRedo_PropertyAddress;

	private static int RenameExposedPin_bSetupUndoRedo_Offset;

	private static bool RenameExposedPin_bPrintPythonCommand_IsValid;

	private static FFieldAddress RenameExposedPin_bPrintPythonCommand_PropertyAddress;

	private static int RenameExposedPin_bPrintPythonCommand_Offset;

	private static bool RenameExposedPin_ReturnValue_IsValid;

	private static FFieldAddress RenameExposedPin_ReturnValue_PropertyAddress;

	private static int RenameExposedPin_ReturnValue_Offset;

	private static bool RemoveNodeByName_IsValid;

	private static IntPtr RemoveNodeByName_FunctionAddress;

	private static int RemoveNodeByName_ParamsSize;

	private static bool RemoveNodeByName_InNodeName_IsValid;

	private static FFieldAddress RemoveNodeByName_InNodeName_PropertyAddress;

	private static int RemoveNodeByName_InNodeName_Offset;

	private static bool RemoveNodeByName_bSetupUndoRedo_IsValid;

	private static FFieldAddress RemoveNodeByName_bSetupUndoRedo_PropertyAddress;

	private static int RemoveNodeByName_bSetupUndoRedo_Offset;

	private static bool RemoveNodeByName_bRecursive_IsValid;

	private static FFieldAddress RemoveNodeByName_bRecursive_PropertyAddress;

	private static int RemoveNodeByName_bRecursive_Offset;

	private static bool RemoveNodeByName_bPrintPythonCommand_IsValid;

	private static FFieldAddress RemoveNodeByName_bPrintPythonCommand_PropertyAddress;

	private static int RemoveNodeByName_bPrintPythonCommand_Offset;

	private static bool RemoveNodeByName_bRelinkPins_IsValid;

	private static FFieldAddress RemoveNodeByName_bRelinkPins_PropertyAddress;

	private static int RemoveNodeByName_bRelinkPins_Offset;

	private static bool RemoveNodeByName_ReturnValue_IsValid;

	private static FFieldAddress RemoveNodeByName_ReturnValue_PropertyAddress;

	private static int RemoveNodeByName_ReturnValue_Offset;

	private static bool RemoveNode_IsValid;

	private static IntPtr RemoveNode_FunctionAddress;

	private static int RemoveNode_ParamsSize;

	private static bool RemoveNode_InNode_IsValid;

	private static FFieldAddress RemoveNode_InNode_PropertyAddress;

	private static int RemoveNode_InNode_Offset;

	private static bool RemoveNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress RemoveNode_bSetupUndoRedo_PropertyAddress;

	private static int RemoveNode_bSetupUndoRedo_Offset;

	private static bool RemoveNode_bRecursive_IsValid;

	private static FFieldAddress RemoveNode_bRecursive_PropertyAddress;

	private static int RemoveNode_bRecursive_Offset;

	private static bool RemoveNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress RemoveNode_bPrintPythonCommand_PropertyAddress;

	private static int RemoveNode_bPrintPythonCommand_Offset;

	private static bool RemoveNode_bRelinkPins_IsValid;

	private static FFieldAddress RemoveNode_bRelinkPins_PropertyAddress;

	private static int RemoveNode_bRelinkPins_Offset;

	private static bool RemoveNode_ReturnValue_IsValid;

	private static FFieldAddress RemoveNode_ReturnValue_PropertyAddress;

	private static int RemoveNode_ReturnValue_Offset;

	private static bool RemoveLocalVariable_IsValid;

	private static IntPtr RemoveLocalVariable_FunctionAddress;

	private static int RemoveLocalVariable_ParamsSize;

	private static bool RemoveLocalVariable_InVariableName_IsValid;

	private static FFieldAddress RemoveLocalVariable_InVariableName_PropertyAddress;

	private static int RemoveLocalVariable_InVariableName_Offset;

	private static bool RemoveLocalVariable_bSetupUndoRedo_IsValid;

	private static FFieldAddress RemoveLocalVariable_bSetupUndoRedo_PropertyAddress;

	private static int RemoveLocalVariable_bSetupUndoRedo_Offset;

	private static bool RemoveLocalVariable_bPrintPythonCommand_IsValid;

	private static FFieldAddress RemoveLocalVariable_bPrintPythonCommand_PropertyAddress;

	private static int RemoveLocalVariable_bPrintPythonCommand_Offset;

	private static bool RemoveLocalVariable_ReturnValue_IsValid;

	private static FFieldAddress RemoveLocalVariable_ReturnValue_PropertyAddress;

	private static int RemoveLocalVariable_ReturnValue_Offset;

	private static bool RemoveInjectedNode_IsValid;

	private static IntPtr RemoveInjectedNode_FunctionAddress;

	private static int RemoveInjectedNode_ParamsSize;

	private static bool RemoveInjectedNode_InPinPath_IsValid;

	private static FFieldAddress RemoveInjectedNode_InPinPath_PropertyAddress;

	private static int RemoveInjectedNode_InPinPath_Offset;

	private static bool RemoveInjectedNode_bAsInput_IsValid;

	private static FFieldAddress RemoveInjectedNode_bAsInput_PropertyAddress;

	private static int RemoveInjectedNode_bAsInput_Offset;

	private static bool RemoveInjectedNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress RemoveInjectedNode_bSetupUndoRedo_PropertyAddress;

	private static int RemoveInjectedNode_bSetupUndoRedo_Offset;

	private static bool RemoveInjectedNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress RemoveInjectedNode_bPrintPythonCommand_PropertyAddress;

	private static int RemoveInjectedNode_bPrintPythonCommand_Offset;

	private static bool RemoveInjectedNode_ReturnValue_IsValid;

	private static FFieldAddress RemoveInjectedNode_ReturnValue_PropertyAddress;

	private static int RemoveInjectedNode_ReturnValue_Offset;

	private static bool RemoveFunctionFromLibrary_IsValid;

	private static IntPtr RemoveFunctionFromLibrary_FunctionAddress;

	private static int RemoveFunctionFromLibrary_ParamsSize;

	private static bool RemoveFunctionFromLibrary_InFunctionName_IsValid;

	private static FFieldAddress RemoveFunctionFromLibrary_InFunctionName_PropertyAddress;

	private static int RemoveFunctionFromLibrary_InFunctionName_Offset;

	private static bool RemoveFunctionFromLibrary_bSetupUndoRedo_IsValid;

	private static FFieldAddress RemoveFunctionFromLibrary_bSetupUndoRedo_PropertyAddress;

	private static int RemoveFunctionFromLibrary_bSetupUndoRedo_Offset;

	private static bool RemoveFunctionFromLibrary_ReturnValue_IsValid;

	private static FFieldAddress RemoveFunctionFromLibrary_ReturnValue_PropertyAddress;

	private static int RemoveFunctionFromLibrary_ReturnValue_Offset;

	private static bool RemoveExposedPin_IsValid;

	private static IntPtr RemoveExposedPin_FunctionAddress;

	private static int RemoveExposedPin_ParamsSize;

	private static bool RemoveExposedPin_InPinName_IsValid;

	private static FFieldAddress RemoveExposedPin_InPinName_PropertyAddress;

	private static int RemoveExposedPin_InPinName_Offset;

	private static bool RemoveExposedPin_bSetupUndoRedo_IsValid;

	private static FFieldAddress RemoveExposedPin_bSetupUndoRedo_PropertyAddress;

	private static int RemoveExposedPin_bSetupUndoRedo_Offset;

	private static bool RemoveExposedPin_bPrintPythonCommand_IsValid;

	private static FFieldAddress RemoveExposedPin_bPrintPythonCommand_PropertyAddress;

	private static int RemoveExposedPin_bPrintPythonCommand_Offset;

	private static bool RemoveExposedPin_ReturnValue_IsValid;

	private static FFieldAddress RemoveExposedPin_ReturnValue_PropertyAddress;

	private static int RemoveExposedPin_ReturnValue_Offset;

	private static bool RemoveArrayPin_IsValid;

	private static IntPtr RemoveArrayPin_FunctionAddress;

	private static int RemoveArrayPin_ParamsSize;

	private static bool RemoveArrayPin_InArrayElementPinPath_IsValid;

	private static FFieldAddress RemoveArrayPin_InArrayElementPinPath_PropertyAddress;

	private static int RemoveArrayPin_InArrayElementPinPath_Offset;

	private static bool RemoveArrayPin_bSetupUndoRedo_IsValid;

	private static FFieldAddress RemoveArrayPin_bSetupUndoRedo_PropertyAddress;

	private static int RemoveArrayPin_bSetupUndoRedo_Offset;

	private static bool RemoveArrayPin_bPrintPythonCommand_IsValid;

	private static FFieldAddress RemoveArrayPin_bPrintPythonCommand_PropertyAddress;

	private static int RemoveArrayPin_bPrintPythonCommand_Offset;

	private static bool RemoveArrayPin_ReturnValue_IsValid;

	private static FFieldAddress RemoveArrayPin_ReturnValue_PropertyAddress;

	private static int RemoveArrayPin_ReturnValue_Offset;

	private static bool RefreshVariableNode_IsValid;

	private static IntPtr RefreshVariableNode_FunctionAddress;

	private static int RefreshVariableNode_ParamsSize;

	private static bool RefreshVariableNode_InNodeName_IsValid;

	private static FFieldAddress RefreshVariableNode_InNodeName_PropertyAddress;

	private static int RefreshVariableNode_InNodeName_Offset;

	private static bool RefreshVariableNode_InVariableName_IsValid;

	private static FFieldAddress RefreshVariableNode_InVariableName_PropertyAddress;

	private static int RefreshVariableNode_InVariableName_Offset;

	private static bool RefreshVariableNode_InCPPType_IsValid;

	private static FFieldAddress RefreshVariableNode_InCPPType_PropertyAddress;

	private static int RefreshVariableNode_InCPPType_Offset;

	private static bool RefreshVariableNode_InCPPTypeObject_IsValid;

	private static FFieldAddress RefreshVariableNode_InCPPTypeObject_PropertyAddress;

	private static int RefreshVariableNode_InCPPTypeObject_Offset;

	private static bool RefreshVariableNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress RefreshVariableNode_bSetupUndoRedo_PropertyAddress;

	private static int RefreshVariableNode_bSetupUndoRedo_Offset;

	private static bool RefreshVariableNode_bSetupOrphanPins_IsValid;

	private static FFieldAddress RefreshVariableNode_bSetupOrphanPins_PropertyAddress;

	private static int RefreshVariableNode_bSetupOrphanPins_Offset;

	private static bool Redo_IsValid;

	private static IntPtr Redo_FunctionAddress;

	private static int Redo_ParamsSize;

	private static bool Redo_ReturnValue_IsValid;

	private static FFieldAddress Redo_ReturnValue_PropertyAddress;

	private static int Redo_ReturnValue_Offset;

	private static bool PushGraph_IsValid;

	private static IntPtr PushGraph_FunctionAddress;

	private static int PushGraph_ParamsSize;

	private static bool PushGraph_InGraph_IsValid;

	private static FFieldAddress PushGraph_InGraph_PropertyAddress;

	private static int PushGraph_InGraph_Offset;

	private static bool PushGraph_bSetupUndoRedo_IsValid;

	private static FFieldAddress PushGraph_bSetupUndoRedo_PropertyAddress;

	private static int PushGraph_bSetupUndoRedo_Offset;

	private static bool PromotePinToVariable_IsValid;

	private static IntPtr PromotePinToVariable_FunctionAddress;

	private static int PromotePinToVariable_ParamsSize;

	private static bool PromotePinToVariable_InPinPath_IsValid;

	private static FFieldAddress PromotePinToVariable_InPinPath_PropertyAddress;

	private static int PromotePinToVariable_InPinPath_Offset;

	private static bool PromotePinToVariable_bCreateVariableNode_IsValid;

	private static FFieldAddress PromotePinToVariable_bCreateVariableNode_PropertyAddress;

	private static int PromotePinToVariable_bCreateVariableNode_Offset;

	private static bool PromotePinToVariable_InNodePosition_IsValid;

	private static FFieldAddress PromotePinToVariable_InNodePosition_PropertyAddress;

	private static int PromotePinToVariable_InNodePosition_Offset;

	private static bool PromotePinToVariable_bSetupUndoRedo_IsValid;

	private static FFieldAddress PromotePinToVariable_bSetupUndoRedo_PropertyAddress;

	private static int PromotePinToVariable_bSetupUndoRedo_Offset;

	private static bool PromotePinToVariable_bPrintPythonCommand_IsValid;

	private static FFieldAddress PromotePinToVariable_bPrintPythonCommand_PropertyAddress;

	private static int PromotePinToVariable_bPrintPythonCommand_Offset;

	private static bool PromotePinToVariable_ReturnValue_IsValid;

	private static FFieldAddress PromotePinToVariable_ReturnValue_PropertyAddress;

	private static int PromotePinToVariable_ReturnValue_Offset;

	private static bool PromoteFunctionReferenceNodeToCollapseNode_IsValid;

	private static IntPtr PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress;

	private static int PromoteFunctionReferenceNodeToCollapseNode_ParamsSize;

	private static bool PromoteFunctionReferenceNodeToCollapseNode_InNodeName_IsValid;

	private static FFieldAddress PromoteFunctionReferenceNodeToCollapseNode_InNodeName_PropertyAddress;

	private static int PromoteFunctionReferenceNodeToCollapseNode_InNodeName_Offset;

	private static bool PromoteFunctionReferenceNodeToCollapseNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress PromoteFunctionReferenceNodeToCollapseNode_bSetupUndoRedo_PropertyAddress;

	private static int PromoteFunctionReferenceNodeToCollapseNode_bSetupUndoRedo_Offset;

	private static bool PromoteFunctionReferenceNodeToCollapseNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress PromoteFunctionReferenceNodeToCollapseNode_bPrintPythonCommand_PropertyAddress;

	private static int PromoteFunctionReferenceNodeToCollapseNode_bPrintPythonCommand_Offset;

	private static bool PromoteFunctionReferenceNodeToCollapseNode_bRemoveFunctionDefinition_IsValid;

	private static FFieldAddress PromoteFunctionReferenceNodeToCollapseNode_bRemoveFunctionDefinition_PropertyAddress;

	private static int PromoteFunctionReferenceNodeToCollapseNode_bRemoveFunctionDefinition_Offset;

	private static bool PromoteFunctionReferenceNodeToCollapseNode_ReturnValue_IsValid;

	private static FFieldAddress PromoteFunctionReferenceNodeToCollapseNode_ReturnValue_PropertyAddress;

	private static int PromoteFunctionReferenceNodeToCollapseNode_ReturnValue_Offset;

	private static bool PromoteCollapseNodeToFunctionReferenceNode_IsValid;

	private static IntPtr PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress;

	private static int PromoteCollapseNodeToFunctionReferenceNode_ParamsSize;

	private static bool PromoteCollapseNodeToFunctionReferenceNode_InNodeName_IsValid;

	private static FFieldAddress PromoteCollapseNodeToFunctionReferenceNode_InNodeName_PropertyAddress;

	private static int PromoteCollapseNodeToFunctionReferenceNode_InNodeName_Offset;

	private static bool PromoteCollapseNodeToFunctionReferenceNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress PromoteCollapseNodeToFunctionReferenceNode_bSetupUndoRedo_PropertyAddress;

	private static int PromoteCollapseNodeToFunctionReferenceNode_bSetupUndoRedo_Offset;

	private static bool PromoteCollapseNodeToFunctionReferenceNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress PromoteCollapseNodeToFunctionReferenceNode_bPrintPythonCommand_PropertyAddress;

	private static int PromoteCollapseNodeToFunctionReferenceNode_bPrintPythonCommand_Offset;

	private static bool PromoteCollapseNodeToFunctionReferenceNode_InExistingFunctionDefinitionPath_IsValid;

	private static FFieldAddress PromoteCollapseNodeToFunctionReferenceNode_InExistingFunctionDefinitionPath_PropertyAddress;

	private static int PromoteCollapseNodeToFunctionReferenceNode_InExistingFunctionDefinitionPath_Offset;

	private static bool PromoteCollapseNodeToFunctionReferenceNode_ReturnValue_IsValid;

	private static FFieldAddress PromoteCollapseNodeToFunctionReferenceNode_ReturnValue_PropertyAddress;

	private static int PromoteCollapseNodeToFunctionReferenceNode_ReturnValue_Offset;

	private static bool PopGraph_IsValid;

	private static IntPtr PopGraph_FunctionAddress;

	private static int PopGraph_ParamsSize;

	private static bool PopGraph_bSetupUndoRedo_IsValid;

	private static FFieldAddress PopGraph_bSetupUndoRedo_PropertyAddress;

	private static int PopGraph_bSetupUndoRedo_Offset;

	private static bool PopGraph_ReturnValue_IsValid;

	private static FFieldAddress PopGraph_ReturnValue_PropertyAddress;

	private static int PopGraph_ReturnValue_Offset;

	private static bool OpenUndoBracket_IsValid;

	private static IntPtr OpenUndoBracket_FunctionAddress;

	private static int OpenUndoBracket_ParamsSize;

	private static bool OpenUndoBracket_InTitle_IsValid;

	private static FFieldAddress OpenUndoBracket_InTitle_PropertyAddress;

	private static int OpenUndoBracket_InTitle_Offset;

	private static bool OpenUndoBracket_ReturnValue_IsValid;

	private static FFieldAddress OpenUndoBracket_ReturnValue_PropertyAddress;

	private static int OpenUndoBracket_ReturnValue_Offset;

	private static bool OnExternalVariableTypeChangedFromObjectPath_IsValid;

	private static IntPtr OnExternalVariableTypeChangedFromObjectPath_FunctionAddress;

	private static int OnExternalVariableTypeChangedFromObjectPath_ParamsSize;

	private static bool OnExternalVariableTypeChangedFromObjectPath_InVarName_IsValid;

	private static FFieldAddress OnExternalVariableTypeChangedFromObjectPath_InVarName_PropertyAddress;

	private static int OnExternalVariableTypeChangedFromObjectPath_InVarName_Offset;

	private static bool OnExternalVariableTypeChangedFromObjectPath_InCPPType_IsValid;

	private static FFieldAddress OnExternalVariableTypeChangedFromObjectPath_InCPPType_PropertyAddress;

	private static int OnExternalVariableTypeChangedFromObjectPath_InCPPType_Offset;

	private static bool OnExternalVariableTypeChangedFromObjectPath_InCPPTypeObjectPath_IsValid;

	private static FFieldAddress OnExternalVariableTypeChangedFromObjectPath_InCPPTypeObjectPath_PropertyAddress;

	private static int OnExternalVariableTypeChangedFromObjectPath_InCPPTypeObjectPath_Offset;

	private static bool OnExternalVariableTypeChangedFromObjectPath_bSetupUndoRedo_IsValid;

	private static FFieldAddress OnExternalVariableTypeChangedFromObjectPath_bSetupUndoRedo_PropertyAddress;

	private static int OnExternalVariableTypeChangedFromObjectPath_bSetupUndoRedo_Offset;

	private static bool OnExternalVariableTypeChanged_IsValid;

	private static IntPtr OnExternalVariableTypeChanged_FunctionAddress;

	private static int OnExternalVariableTypeChanged_ParamsSize;

	private static bool OnExternalVariableTypeChanged_InVarName_IsValid;

	private static FFieldAddress OnExternalVariableTypeChanged_InVarName_PropertyAddress;

	private static int OnExternalVariableTypeChanged_InVarName_Offset;

	private static bool OnExternalVariableTypeChanged_InCPPType_IsValid;

	private static FFieldAddress OnExternalVariableTypeChanged_InCPPType_PropertyAddress;

	private static int OnExternalVariableTypeChanged_InCPPType_Offset;

	private static bool OnExternalVariableTypeChanged_InCPPTypeObject_IsValid;

	private static FFieldAddress OnExternalVariableTypeChanged_InCPPTypeObject_PropertyAddress;

	private static int OnExternalVariableTypeChanged_InCPPTypeObject_Offset;

	private static bool OnExternalVariableTypeChanged_bSetupUndoRedo_IsValid;

	private static FFieldAddress OnExternalVariableTypeChanged_bSetupUndoRedo_PropertyAddress;

	private static int OnExternalVariableTypeChanged_bSetupUndoRedo_Offset;

	private static bool OnExternalVariableRenamed_IsValid;

	private static IntPtr OnExternalVariableRenamed_FunctionAddress;

	private static int OnExternalVariableRenamed_ParamsSize;

	private static bool OnExternalVariableRenamed_InOldVarName_IsValid;

	private static FFieldAddress OnExternalVariableRenamed_InOldVarName_PropertyAddress;

	private static int OnExternalVariableRenamed_InOldVarName_Offset;

	private static bool OnExternalVariableRenamed_InNewVarName_IsValid;

	private static FFieldAddress OnExternalVariableRenamed_InNewVarName_PropertyAddress;

	private static int OnExternalVariableRenamed_InNewVarName_Offset;

	private static bool OnExternalVariableRenamed_bSetupUndoRedo_IsValid;

	private static FFieldAddress OnExternalVariableRenamed_bSetupUndoRedo_PropertyAddress;

	private static int OnExternalVariableRenamed_bSetupUndoRedo_Offset;

	private static bool OnExternalVariableRemoved_IsValid;

	private static IntPtr OnExternalVariableRemoved_FunctionAddress;

	private static int OnExternalVariableRemoved_ParamsSize;

	private static bool OnExternalVariableRemoved_InVarName_IsValid;

	private static FFieldAddress OnExternalVariableRemoved_InVarName_PropertyAddress;

	private static int OnExternalVariableRemoved_InVarName_Offset;

	private static bool OnExternalVariableRemoved_bSetupUndoRedo_IsValid;

	private static FFieldAddress OnExternalVariableRemoved_bSetupUndoRedo_PropertyAddress;

	private static int OnExternalVariableRemoved_bSetupUndoRedo_Offset;

	private static bool MakeVariableNodeFromBinding_IsValid;

	private static IntPtr MakeVariableNodeFromBinding_FunctionAddress;

	private static int MakeVariableNodeFromBinding_ParamsSize;

	private static bool MakeVariableNodeFromBinding_InPinPath_IsValid;

	private static FFieldAddress MakeVariableNodeFromBinding_InPinPath_PropertyAddress;

	private static int MakeVariableNodeFromBinding_InPinPath_Offset;

	private static bool MakeVariableNodeFromBinding_InNodePosition_IsValid;

	private static FFieldAddress MakeVariableNodeFromBinding_InNodePosition_PropertyAddress;

	private static int MakeVariableNodeFromBinding_InNodePosition_Offset;

	private static bool MakeVariableNodeFromBinding_bSetupUndoRedo_IsValid;

	private static FFieldAddress MakeVariableNodeFromBinding_bSetupUndoRedo_PropertyAddress;

	private static int MakeVariableNodeFromBinding_bSetupUndoRedo_Offset;

	private static bool MakeVariableNodeFromBinding_bPrintPythonCommand_IsValid;

	private static FFieldAddress MakeVariableNodeFromBinding_bPrintPythonCommand_PropertyAddress;

	private static int MakeVariableNodeFromBinding_bPrintPythonCommand_Offset;

	private static bool MakeVariableNodeFromBinding_ReturnValue_IsValid;

	private static FFieldAddress MakeVariableNodeFromBinding_ReturnValue_PropertyAddress;

	private static int MakeVariableNodeFromBinding_ReturnValue_Offset;

	private static bool MakeBindingsFromVariableNode_IsValid;

	private static IntPtr MakeBindingsFromVariableNode_FunctionAddress;

	private static int MakeBindingsFromVariableNode_ParamsSize;

	private static bool MakeBindingsFromVariableNode_InNodeName_IsValid;

	private static FFieldAddress MakeBindingsFromVariableNode_InNodeName_PropertyAddress;

	private static int MakeBindingsFromVariableNode_InNodeName_Offset;

	private static bool MakeBindingsFromVariableNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress MakeBindingsFromVariableNode_bSetupUndoRedo_PropertyAddress;

	private static int MakeBindingsFromVariableNode_bSetupUndoRedo_Offset;

	private static bool MakeBindingsFromVariableNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress MakeBindingsFromVariableNode_bPrintPythonCommand_PropertyAddress;

	private static int MakeBindingsFromVariableNode_bPrintPythonCommand_Offset;

	private static bool MakeBindingsFromVariableNode_ReturnValue_IsValid;

	private static FFieldAddress MakeBindingsFromVariableNode_ReturnValue_PropertyAddress;

	private static int MakeBindingsFromVariableNode_ReturnValue_Offset;

	private static bool LocalizeFunctions_IsValid;

	private static IntPtr LocalizeFunctions_FunctionAddress;

	private static int LocalizeFunctions_ParamsSize;

	private static bool LocalizeFunctions_InFunctionDefinitions_IsValid;

	private static FFieldAddress LocalizeFunctions_InFunctionDefinitions_PropertyAddress;

	private static int LocalizeFunctions_InFunctionDefinitions_Offset;

	private static bool LocalizeFunctions_bLocalizeDependentPrivateFunctions_IsValid;

	private static FFieldAddress LocalizeFunctions_bLocalizeDependentPrivateFunctions_PropertyAddress;

	private static int LocalizeFunctions_bLocalizeDependentPrivateFunctions_Offset;

	private static bool LocalizeFunctions_bSetupUndoRedo_IsValid;

	private static FFieldAddress LocalizeFunctions_bSetupUndoRedo_PropertyAddress;

	private static int LocalizeFunctions_bSetupUndoRedo_Offset;

	private static bool LocalizeFunctions_bPrintPythonCommand_IsValid;

	private static FFieldAddress LocalizeFunctions_bPrintPythonCommand_PropertyAddress;

	private static int LocalizeFunctions_bPrintPythonCommand_Offset;

	private static bool LocalizeFunctions_ReturnValue_IsValid;

	private static FFieldAddress LocalizeFunctions_ReturnValue_PropertyAddress;

	private static int LocalizeFunctions_ReturnValue_Offset;

	private static bool LocalizeFunction_IsValid;

	private static IntPtr LocalizeFunction_FunctionAddress;

	private static int LocalizeFunction_ParamsSize;

	private static bool LocalizeFunction_InFunctionDefinition_IsValid;

	private static FFieldAddress LocalizeFunction_InFunctionDefinition_PropertyAddress;

	private static int LocalizeFunction_InFunctionDefinition_Offset;

	private static bool LocalizeFunction_bLocalizeDependentPrivateFunctions_IsValid;

	private static FFieldAddress LocalizeFunction_bLocalizeDependentPrivateFunctions_PropertyAddress;

	private static int LocalizeFunction_bLocalizeDependentPrivateFunctions_Offset;

	private static bool LocalizeFunction_bSetupUndoRedo_IsValid;

	private static FFieldAddress LocalizeFunction_bSetupUndoRedo_PropertyAddress;

	private static int LocalizeFunction_bSetupUndoRedo_Offset;

	private static bool LocalizeFunction_bPrintPythonCommand_IsValid;

	private static FFieldAddress LocalizeFunction_bPrintPythonCommand_PropertyAddress;

	private static int LocalizeFunction_bPrintPythonCommand_Offset;

	private static bool LocalizeFunction_ReturnValue_IsValid;

	private static FFieldAddress LocalizeFunction_ReturnValue_PropertyAddress;

	private static int LocalizeFunction_ReturnValue_Offset;

	private static bool IsReportingEnabled_IsValid;

	private static IntPtr IsReportingEnabled_FunctionAddress;

	private static int IsReportingEnabled_ParamsSize;

	private static bool IsReportingEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsReportingEnabled_ReturnValue_PropertyAddress;

	private static int IsReportingEnabled_ReturnValue_Offset;

	private static bool InsertArrayPin_IsValid;

	private static IntPtr InsertArrayPin_FunctionAddress;

	private static int InsertArrayPin_ParamsSize;

	private static bool InsertArrayPin_InArrayPinPath_IsValid;

	private static FFieldAddress InsertArrayPin_InArrayPinPath_PropertyAddress;

	private static int InsertArrayPin_InArrayPinPath_Offset;

	private static bool InsertArrayPin_InIndex_IsValid;

	private static FFieldAddress InsertArrayPin_InIndex_PropertyAddress;

	private static int InsertArrayPin_InIndex_Offset;

	private static bool InsertArrayPin_InDefaultValue_IsValid;

	private static FFieldAddress InsertArrayPin_InDefaultValue_PropertyAddress;

	private static int InsertArrayPin_InDefaultValue_Offset;

	private static bool InsertArrayPin_bSetupUndoRedo_IsValid;

	private static FFieldAddress InsertArrayPin_bSetupUndoRedo_PropertyAddress;

	private static int InsertArrayPin_bSetupUndoRedo_Offset;

	private static bool InsertArrayPin_bPrintPythonCommand_IsValid;

	private static FFieldAddress InsertArrayPin_bPrintPythonCommand_PropertyAddress;

	private static int InsertArrayPin_bPrintPythonCommand_Offset;

	private static bool InsertArrayPin_ReturnValue_IsValid;

	private static FFieldAddress InsertArrayPin_ReturnValue_PropertyAddress;

	private static int InsertArrayPin_ReturnValue_Offset;

	private static bool ImportNodesFromText_IsValid;

	private static IntPtr ImportNodesFromText_FunctionAddress;

	private static int ImportNodesFromText_ParamsSize;

	private static bool ImportNodesFromText_InText_IsValid;

	private static FFieldAddress ImportNodesFromText_InText_PropertyAddress;

	private static int ImportNodesFromText_InText_Offset;

	private static bool ImportNodesFromText_bSetupUndoRedo_IsValid;

	private static FFieldAddress ImportNodesFromText_bSetupUndoRedo_PropertyAddress;

	private static int ImportNodesFromText_bSetupUndoRedo_Offset;

	private static bool ImportNodesFromText_bPrintPythonCommands_IsValid;

	private static FFieldAddress ImportNodesFromText_bPrintPythonCommands_PropertyAddress;

	private static int ImportNodesFromText_bPrintPythonCommands_Offset;

	private static bool ImportNodesFromText_ReturnValue_IsValid;

	private static FFieldAddress ImportNodesFromText_ReturnValue_PropertyAddress;

	private static int ImportNodesFromText_ReturnValue_Offset;

	private static bool GetTopLevelGraph_IsValid;

	private static IntPtr GetTopLevelGraph_FunctionAddress;

	private static int GetTopLevelGraph_ParamsSize;

	private static bool GetTopLevelGraph_ReturnValue_IsValid;

	private static FFieldAddress GetTopLevelGraph_ReturnValue_PropertyAddress;

	private static int GetTopLevelGraph_ReturnValue_Offset;

	private static bool GetPinDefaultValue_IsValid;

	private static IntPtr GetPinDefaultValue_FunctionAddress;

	private static int GetPinDefaultValue_ParamsSize;

	private static bool GetPinDefaultValue_InPinPath_IsValid;

	private static FFieldAddress GetPinDefaultValue_InPinPath_PropertyAddress;

	private static int GetPinDefaultValue_InPinPath_Offset;

	private static bool GetPinDefaultValue_ReturnValue_IsValid;

	private static FFieldAddress GetPinDefaultValue_ReturnValue_PropertyAddress;

	private static int GetPinDefaultValue_ReturnValue_Offset;

	private static bool GetGraph_IsValid;

	private static IntPtr GetGraph_FunctionAddress;

	private static int GetGraph_ParamsSize;

	private static bool GetGraph_ReturnValue_IsValid;

	private static FFieldAddress GetGraph_ReturnValue_PropertyAddress;

	private static int GetGraph_ReturnValue_Offset;

	private static bool GeneratePythonCommands_IsValid;

	private static IntPtr GeneratePythonCommands_FunctionAddress;

	private static int GeneratePythonCommands_ParamsSize;

	private static bool GeneratePythonCommands_ReturnValue_IsValid;

	private static FFieldAddress GeneratePythonCommands_ReturnValue_PropertyAddress;

	private static int GeneratePythonCommands_ReturnValue_Offset;

	private static bool ExportSelectedNodesToText_IsValid;

	private static IntPtr ExportSelectedNodesToText_FunctionAddress;

	private static int ExportSelectedNodesToText_ParamsSize;

	private static bool ExportSelectedNodesToText_ReturnValue_IsValid;

	private static FFieldAddress ExportSelectedNodesToText_ReturnValue_PropertyAddress;

	private static int ExportSelectedNodesToText_ReturnValue_Offset;

	private static bool ExportNodesToText_IsValid;

	private static IntPtr ExportNodesToText_FunctionAddress;

	private static int ExportNodesToText_ParamsSize;

	private static bool ExportNodesToText_InNodeNames_IsValid;

	private static FFieldAddress ExportNodesToText_InNodeNames_PropertyAddress;

	private static int ExportNodesToText_InNodeNames_Offset;

	private static bool ExportNodesToText_ReturnValue_IsValid;

	private static FFieldAddress ExportNodesToText_ReturnValue_PropertyAddress;

	private static int ExportNodesToText_ReturnValue_Offset;

	private static bool ExpandLibraryNode_IsValid;

	private static IntPtr ExpandLibraryNode_FunctionAddress;

	private static int ExpandLibraryNode_ParamsSize;

	private static bool ExpandLibraryNode_InNodeName_IsValid;

	private static FFieldAddress ExpandLibraryNode_InNodeName_PropertyAddress;

	private static int ExpandLibraryNode_InNodeName_Offset;

	private static bool ExpandLibraryNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress ExpandLibraryNode_bSetupUndoRedo_PropertyAddress;

	private static int ExpandLibraryNode_bSetupUndoRedo_Offset;

	private static bool ExpandLibraryNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress ExpandLibraryNode_bPrintPythonCommand_PropertyAddress;

	private static int ExpandLibraryNode_bPrintPythonCommand_Offset;

	private static bool ExpandLibraryNode_ReturnValue_IsValid;

	private static FFieldAddress ExpandLibraryNode_ReturnValue_PropertyAddress;

	private static int ExpandLibraryNode_ReturnValue_Offset;

	private static bool EnableReporting_IsValid;

	private static IntPtr EnableReporting_FunctionAddress;

	private static int EnableReporting_ParamsSize;

	private static bool EnableReporting_bEnabled_IsValid;

	private static FFieldAddress EnableReporting_bEnabled_PropertyAddress;

	private static int EnableReporting_bEnabled_Offset;

	private static bool EjectNodeFromPin_IsValid;

	private static IntPtr EjectNodeFromPin_FunctionAddress;

	private static int EjectNodeFromPin_ParamsSize;

	private static bool EjectNodeFromPin_InPinPath_IsValid;

	private static FFieldAddress EjectNodeFromPin_InPinPath_PropertyAddress;

	private static int EjectNodeFromPin_InPinPath_Offset;

	private static bool EjectNodeFromPin_bSetupUndoRedo_IsValid;

	private static FFieldAddress EjectNodeFromPin_bSetupUndoRedo_PropertyAddress;

	private static int EjectNodeFromPin_bSetupUndoRedo_Offset;

	private static bool EjectNodeFromPin_bPrintPythonCommand_IsValid;

	private static FFieldAddress EjectNodeFromPin_bPrintPythonCommand_PropertyAddress;

	private static int EjectNodeFromPin_bPrintPythonCommand_Offset;

	private static bool EjectNodeFromPin_ReturnValue_IsValid;

	private static FFieldAddress EjectNodeFromPin_ReturnValue_PropertyAddress;

	private static int EjectNodeFromPin_ReturnValue_Offset;

	private static bool DuplicateArrayPin_IsValid;

	private static IntPtr DuplicateArrayPin_FunctionAddress;

	private static int DuplicateArrayPin_ParamsSize;

	private static bool DuplicateArrayPin_InArrayElementPinPath_IsValid;

	private static FFieldAddress DuplicateArrayPin_InArrayElementPinPath_PropertyAddress;

	private static int DuplicateArrayPin_InArrayElementPinPath_Offset;

	private static bool DuplicateArrayPin_bSetupUndoRedo_IsValid;

	private static FFieldAddress DuplicateArrayPin_bSetupUndoRedo_PropertyAddress;

	private static int DuplicateArrayPin_bSetupUndoRedo_Offset;

	private static bool DuplicateArrayPin_bPrintPythonCommand_IsValid;

	private static FFieldAddress DuplicateArrayPin_bPrintPythonCommand_PropertyAddress;

	private static int DuplicateArrayPin_bPrintPythonCommand_Offset;

	private static bool DuplicateArrayPin_ReturnValue_IsValid;

	private static FFieldAddress DuplicateArrayPin_ReturnValue_PropertyAddress;

	private static int DuplicateArrayPin_ReturnValue_Offset;

	private static bool CollapseNodes_IsValid;

	private static IntPtr CollapseNodes_FunctionAddress;

	private static int CollapseNodes_ParamsSize;

	private static bool CollapseNodes_InNodeNames_IsValid;

	private static FFieldAddress CollapseNodes_InNodeNames_PropertyAddress;

	private static int CollapseNodes_InNodeNames_Offset;

	private static bool CollapseNodes_InCollapseNodeName_IsValid;

	private static FFieldAddress CollapseNodes_InCollapseNodeName_PropertyAddress;

	private static int CollapseNodes_InCollapseNodeName_Offset;

	private static bool CollapseNodes_bSetupUndoRedo_IsValid;

	private static FFieldAddress CollapseNodes_bSetupUndoRedo_PropertyAddress;

	private static int CollapseNodes_bSetupUndoRedo_Offset;

	private static bool CollapseNodes_bPrintPythonCommand_IsValid;

	private static FFieldAddress CollapseNodes_bPrintPythonCommand_PropertyAddress;

	private static int CollapseNodes_bPrintPythonCommand_Offset;

	private static bool CollapseNodes_ReturnValue_IsValid;

	private static FFieldAddress CollapseNodes_ReturnValue_PropertyAddress;

	private static int CollapseNodes_ReturnValue_Offset;

	private static bool CloseUndoBracket_IsValid;

	private static IntPtr CloseUndoBracket_FunctionAddress;

	private static int CloseUndoBracket_ParamsSize;

	private static bool CloseUndoBracket_ReturnValue_IsValid;

	private static FFieldAddress CloseUndoBracket_ReturnValue_PropertyAddress;

	private static int CloseUndoBracket_ReturnValue_Offset;

	private static bool ClearNodeSelection_IsValid;

	private static IntPtr ClearNodeSelection_FunctionAddress;

	private static int ClearNodeSelection_ParamsSize;

	private static bool ClearNodeSelection_bSetupUndoRedo_IsValid;

	private static FFieldAddress ClearNodeSelection_bSetupUndoRedo_PropertyAddress;

	private static int ClearNodeSelection_bSetupUndoRedo_Offset;

	private static bool ClearNodeSelection_bPrintPythonCommand_IsValid;

	private static FFieldAddress ClearNodeSelection_bPrintPythonCommand_PropertyAddress;

	private static int ClearNodeSelection_bPrintPythonCommand_Offset;

	private static bool ClearNodeSelection_ReturnValue_IsValid;

	private static FFieldAddress ClearNodeSelection_ReturnValue_PropertyAddress;

	private static int ClearNodeSelection_ReturnValue_Offset;

	private static bool ClearArrayPin_IsValid;

	private static IntPtr ClearArrayPin_FunctionAddress;

	private static int ClearArrayPin_ParamsSize;

	private static bool ClearArrayPin_InArrayPinPath_IsValid;

	private static FFieldAddress ClearArrayPin_InArrayPinPath_PropertyAddress;

	private static int ClearArrayPin_InArrayPinPath_Offset;

	private static bool ClearArrayPin_bSetupUndoRedo_IsValid;

	private static FFieldAddress ClearArrayPin_bSetupUndoRedo_PropertyAddress;

	private static int ClearArrayPin_bSetupUndoRedo_Offset;

	private static bool ClearArrayPin_bPrintPythonCommand_IsValid;

	private static FFieldAddress ClearArrayPin_bPrintPythonCommand_PropertyAddress;

	private static int ClearArrayPin_bPrintPythonCommand_Offset;

	private static bool ClearArrayPin_ReturnValue_IsValid;

	private static FFieldAddress ClearArrayPin_ReturnValue_PropertyAddress;

	private static int ClearArrayPin_ReturnValue_Offset;

	private static bool ChangeExposedPinType_IsValid;

	private static IntPtr ChangeExposedPinType_FunctionAddress;

	private static int ChangeExposedPinType_ParamsSize;

	private static bool ChangeExposedPinType_InPinName_IsValid;

	private static FFieldAddress ChangeExposedPinType_InPinName_PropertyAddress;

	private static int ChangeExposedPinType_InPinName_Offset;

	private static bool ChangeExposedPinType_InCPPType_IsValid;

	private static FFieldAddress ChangeExposedPinType_InCPPType_PropertyAddress;

	private static int ChangeExposedPinType_InCPPType_Offset;

	private static bool ChangeExposedPinType_InCPPTypeObjectPath_IsValid;

	private static FFieldAddress ChangeExposedPinType_InCPPTypeObjectPath_PropertyAddress;

	private static int ChangeExposedPinType_InCPPTypeObjectPath_Offset;

	private static bool ChangeExposedPinType_bSetupUndoRedo_IsValid;

	private static FFieldAddress ChangeExposedPinType_bSetupUndoRedo_PropertyAddress;

	private static int ChangeExposedPinType_bSetupUndoRedo_Offset;

	private static bool ChangeExposedPinType_bSetupOrphanPins_IsValid;

	private static FFieldAddress ChangeExposedPinType_bSetupOrphanPins_PropertyAddress;

	private static int ChangeExposedPinType_bSetupOrphanPins_Offset;

	private static bool ChangeExposedPinType_bPrintPythonCommand_IsValid;

	private static FFieldAddress ChangeExposedPinType_bPrintPythonCommand_PropertyAddress;

	private static int ChangeExposedPinType_bPrintPythonCommand_Offset;

	private static bool ChangeExposedPinType_ReturnValue_IsValid;

	private static FFieldAddress ChangeExposedPinType_ReturnValue_PropertyAddress;

	private static int ChangeExposedPinType_ReturnValue_Offset;

	private static bool CanImportNodesFromText_IsValid;

	private static IntPtr CanImportNodesFromText_FunctionAddress;

	private static int CanImportNodesFromText_ParamsSize;

	private static bool CanImportNodesFromText_InText_IsValid;

	private static FFieldAddress CanImportNodesFromText_InText_PropertyAddress;

	private static int CanImportNodesFromText_InText_Offset;

	private static bool CanImportNodesFromText_ReturnValue_IsValid;

	private static FFieldAddress CanImportNodesFromText_ReturnValue_PropertyAddress;

	private static int CanImportNodesFromText_ReturnValue_Offset;

	private static bool CancelUndoBracket_IsValid;

	private static IntPtr CancelUndoBracket_FunctionAddress;

	private static int CancelUndoBracket_ParamsSize;

	private static bool CancelUndoBracket_ReturnValue_IsValid;

	private static FFieldAddress CancelUndoBracket_ReturnValue_PropertyAddress;

	private static int CancelUndoBracket_ReturnValue_Offset;

	private static bool BreakLink_IsValid;

	private static IntPtr BreakLink_FunctionAddress;

	private static int BreakLink_ParamsSize;

	private static bool BreakLink_InOutputPinPath_IsValid;

	private static FFieldAddress BreakLink_InOutputPinPath_PropertyAddress;

	private static int BreakLink_InOutputPinPath_Offset;

	private static bool BreakLink_InInputPinPath_IsValid;

	private static FFieldAddress BreakLink_InInputPinPath_PropertyAddress;

	private static int BreakLink_InInputPinPath_Offset;

	private static bool BreakLink_bSetupUndoRedo_IsValid;

	private static FFieldAddress BreakLink_bSetupUndoRedo_PropertyAddress;

	private static int BreakLink_bSetupUndoRedo_Offset;

	private static bool BreakLink_bPrintPythonCommand_IsValid;

	private static FFieldAddress BreakLink_bPrintPythonCommand_PropertyAddress;

	private static int BreakLink_bPrintPythonCommand_Offset;

	private static bool BreakLink_ReturnValue_IsValid;

	private static FFieldAddress BreakLink_ReturnValue_PropertyAddress;

	private static int BreakLink_ReturnValue_Offset;

	private static bool BreakAllLinks_IsValid;

	private static IntPtr BreakAllLinks_FunctionAddress;

	private static int BreakAllLinks_ParamsSize;

	private static bool BreakAllLinks_InPinPath_IsValid;

	private static FFieldAddress BreakAllLinks_InPinPath_PropertyAddress;

	private static int BreakAllLinks_InPinPath_Offset;

	private static bool BreakAllLinks_bAsInput_IsValid;

	private static FFieldAddress BreakAllLinks_bAsInput_PropertyAddress;

	private static int BreakAllLinks_bAsInput_Offset;

	private static bool BreakAllLinks_bSetupUndoRedo_IsValid;

	private static FFieldAddress BreakAllLinks_bSetupUndoRedo_PropertyAddress;

	private static int BreakAllLinks_bSetupUndoRedo_Offset;

	private static bool BreakAllLinks_bPrintPythonCommand_IsValid;

	private static FFieldAddress BreakAllLinks_bPrintPythonCommand_PropertyAddress;

	private static int BreakAllLinks_bPrintPythonCommand_Offset;

	private static bool BreakAllLinks_ReturnValue_IsValid;

	private static FFieldAddress BreakAllLinks_ReturnValue_PropertyAddress;

	private static int BreakAllLinks_ReturnValue_Offset;

	private static bool BindPinToVariable_IsValid;

	private static IntPtr BindPinToVariable_FunctionAddress;

	private static int BindPinToVariable_ParamsSize;

	private static bool BindPinToVariable_InPinPath_IsValid;

	private static FFieldAddress BindPinToVariable_InPinPath_PropertyAddress;

	private static int BindPinToVariable_InPinPath_Offset;

	private static bool BindPinToVariable_InNewBoundVariablePath_IsValid;

	private static FFieldAddress BindPinToVariable_InNewBoundVariablePath_PropertyAddress;

	private static int BindPinToVariable_InNewBoundVariablePath_Offset;

	private static bool BindPinToVariable_bSetupUndoRedo_IsValid;

	private static FFieldAddress BindPinToVariable_bSetupUndoRedo_PropertyAddress;

	private static int BindPinToVariable_bSetupUndoRedo_Offset;

	private static bool BindPinToVariable_bPrintPythonCommand_IsValid;

	private static FFieldAddress BindPinToVariable_bPrintPythonCommand_PropertyAddress;

	private static int BindPinToVariable_bPrintPythonCommand_Offset;

	private static bool BindPinToVariable_ReturnValue_IsValid;

	private static FFieldAddress BindPinToVariable_ReturnValue_PropertyAddress;

	private static int BindPinToVariable_ReturnValue_Offset;

	private static bool AddVariableNodeFromObjectPath_IsValid;

	private static IntPtr AddVariableNodeFromObjectPath_FunctionAddress;

	private static int AddVariableNodeFromObjectPath_ParamsSize;

	private static bool AddVariableNodeFromObjectPath_InVariableName_IsValid;

	private static FFieldAddress AddVariableNodeFromObjectPath_InVariableName_PropertyAddress;

	private static int AddVariableNodeFromObjectPath_InVariableName_Offset;

	private static bool AddVariableNodeFromObjectPath_InCPPType_IsValid;

	private static FFieldAddress AddVariableNodeFromObjectPath_InCPPType_PropertyAddress;

	private static int AddVariableNodeFromObjectPath_InCPPType_Offset;

	private static bool AddVariableNodeFromObjectPath_InCPPTypeObjectPath_IsValid;

	private static FFieldAddress AddVariableNodeFromObjectPath_InCPPTypeObjectPath_PropertyAddress;

	private static int AddVariableNodeFromObjectPath_InCPPTypeObjectPath_Offset;

	private static bool AddVariableNodeFromObjectPath_bIsGetter_IsValid;

	private static FFieldAddress AddVariableNodeFromObjectPath_bIsGetter_PropertyAddress;

	private static int AddVariableNodeFromObjectPath_bIsGetter_Offset;

	private static bool AddVariableNodeFromObjectPath_InDefaultValue_IsValid;

	private static FFieldAddress AddVariableNodeFromObjectPath_InDefaultValue_PropertyAddress;

	private static int AddVariableNodeFromObjectPath_InDefaultValue_Offset;

	private static bool AddVariableNodeFromObjectPath_InPosition_IsValid;

	private static FFieldAddress AddVariableNodeFromObjectPath_InPosition_PropertyAddress;

	private static int AddVariableNodeFromObjectPath_InPosition_Offset;

	private static bool AddVariableNodeFromObjectPath_InNodeName_IsValid;

	private static FFieldAddress AddVariableNodeFromObjectPath_InNodeName_PropertyAddress;

	private static int AddVariableNodeFromObjectPath_InNodeName_Offset;

	private static bool AddVariableNodeFromObjectPath_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddVariableNodeFromObjectPath_bSetupUndoRedo_PropertyAddress;

	private static int AddVariableNodeFromObjectPath_bSetupUndoRedo_Offset;

	private static bool AddVariableNodeFromObjectPath_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddVariableNodeFromObjectPath_bPrintPythonCommand_PropertyAddress;

	private static int AddVariableNodeFromObjectPath_bPrintPythonCommand_Offset;

	private static bool AddVariableNodeFromObjectPath_ReturnValue_IsValid;

	private static FFieldAddress AddVariableNodeFromObjectPath_ReturnValue_PropertyAddress;

	private static int AddVariableNodeFromObjectPath_ReturnValue_Offset;

	private static bool AddVariableNode_IsValid;

	private static IntPtr AddVariableNode_FunctionAddress;

	private static int AddVariableNode_ParamsSize;

	private static bool AddVariableNode_InVariableName_IsValid;

	private static FFieldAddress AddVariableNode_InVariableName_PropertyAddress;

	private static int AddVariableNode_InVariableName_Offset;

	private static bool AddVariableNode_InCPPType_IsValid;

	private static FFieldAddress AddVariableNode_InCPPType_PropertyAddress;

	private static int AddVariableNode_InCPPType_Offset;

	private static bool AddVariableNode_InCPPTypeObject_IsValid;

	private static FFieldAddress AddVariableNode_InCPPTypeObject_PropertyAddress;

	private static int AddVariableNode_InCPPTypeObject_Offset;

	private static bool AddVariableNode_bIsGetter_IsValid;

	private static FFieldAddress AddVariableNode_bIsGetter_PropertyAddress;

	private static int AddVariableNode_bIsGetter_Offset;

	private static bool AddVariableNode_InDefaultValue_IsValid;

	private static FFieldAddress AddVariableNode_InDefaultValue_PropertyAddress;

	private static int AddVariableNode_InDefaultValue_Offset;

	private static bool AddVariableNode_InPosition_IsValid;

	private static FFieldAddress AddVariableNode_InPosition_PropertyAddress;

	private static int AddVariableNode_InPosition_Offset;

	private static bool AddVariableNode_InNodeName_IsValid;

	private static FFieldAddress AddVariableNode_InNodeName_PropertyAddress;

	private static int AddVariableNode_InNodeName_Offset;

	private static bool AddVariableNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddVariableNode_bSetupUndoRedo_PropertyAddress;

	private static int AddVariableNode_bSetupUndoRedo_Offset;

	private static bool AddVariableNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddVariableNode_bPrintPythonCommand_PropertyAddress;

	private static int AddVariableNode_bPrintPythonCommand_Offset;

	private static bool AddVariableNode_ReturnValue_IsValid;

	private static FFieldAddress AddVariableNode_ReturnValue_PropertyAddress;

	private static int AddVariableNode_ReturnValue_Offset;

	private static bool AddUnitNodeFromStructPath_IsValid;

	private static IntPtr AddUnitNodeFromStructPath_FunctionAddress;

	private static int AddUnitNodeFromStructPath_ParamsSize;

	private static bool AddUnitNodeFromStructPath_InScriptStructPath_IsValid;

	private static FFieldAddress AddUnitNodeFromStructPath_InScriptStructPath_PropertyAddress;

	private static int AddUnitNodeFromStructPath_InScriptStructPath_Offset;

	private static bool AddUnitNodeFromStructPath_InMethodName_IsValid;

	private static FFieldAddress AddUnitNodeFromStructPath_InMethodName_PropertyAddress;

	private static int AddUnitNodeFromStructPath_InMethodName_Offset;

	private static bool AddUnitNodeFromStructPath_InPosition_IsValid;

	private static FFieldAddress AddUnitNodeFromStructPath_InPosition_PropertyAddress;

	private static int AddUnitNodeFromStructPath_InPosition_Offset;

	private static bool AddUnitNodeFromStructPath_InNodeName_IsValid;

	private static FFieldAddress AddUnitNodeFromStructPath_InNodeName_PropertyAddress;

	private static int AddUnitNodeFromStructPath_InNodeName_Offset;

	private static bool AddUnitNodeFromStructPath_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddUnitNodeFromStructPath_bSetupUndoRedo_PropertyAddress;

	private static int AddUnitNodeFromStructPath_bSetupUndoRedo_Offset;

	private static bool AddUnitNodeFromStructPath_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddUnitNodeFromStructPath_bPrintPythonCommand_PropertyAddress;

	private static int AddUnitNodeFromStructPath_bPrintPythonCommand_Offset;

	private static bool AddUnitNodeFromStructPath_ReturnValue_IsValid;

	private static FFieldAddress AddUnitNodeFromStructPath_ReturnValue_PropertyAddress;

	private static int AddUnitNodeFromStructPath_ReturnValue_Offset;

	private static bool AddUnitNode_IsValid;

	private static IntPtr AddUnitNode_FunctionAddress;

	private static int AddUnitNode_ParamsSize;

	private static bool AddUnitNode_InScriptStruct_IsValid;

	private static FFieldAddress AddUnitNode_InScriptStruct_PropertyAddress;

	private static int AddUnitNode_InScriptStruct_Offset;

	private static bool AddUnitNode_InMethodName_IsValid;

	private static FFieldAddress AddUnitNode_InMethodName_PropertyAddress;

	private static int AddUnitNode_InMethodName_Offset;

	private static bool AddUnitNode_InPosition_IsValid;

	private static FFieldAddress AddUnitNode_InPosition_PropertyAddress;

	private static int AddUnitNode_InPosition_Offset;

	private static bool AddUnitNode_InNodeName_IsValid;

	private static FFieldAddress AddUnitNode_InNodeName_PropertyAddress;

	private static int AddUnitNode_InNodeName_Offset;

	private static bool AddUnitNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddUnitNode_bSetupUndoRedo_PropertyAddress;

	private static int AddUnitNode_bSetupUndoRedo_Offset;

	private static bool AddUnitNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddUnitNode_bPrintPythonCommand_PropertyAddress;

	private static int AddUnitNode_bPrintPythonCommand_Offset;

	private static bool AddUnitNode_ReturnValue_IsValid;

	private static FFieldAddress AddUnitNode_ReturnValue_PropertyAddress;

	private static int AddUnitNode_ReturnValue_Offset;

	private static bool AddSelectNodeFromStruct_IsValid;

	private static IntPtr AddSelectNodeFromStruct_FunctionAddress;

	private static int AddSelectNodeFromStruct_ParamsSize;

	private static bool AddSelectNodeFromStruct_InScriptStruct_IsValid;

	private static FFieldAddress AddSelectNodeFromStruct_InScriptStruct_PropertyAddress;

	private static int AddSelectNodeFromStruct_InScriptStruct_Offset;

	private static bool AddSelectNodeFromStruct_InPosition_IsValid;

	private static FFieldAddress AddSelectNodeFromStruct_InPosition_PropertyAddress;

	private static int AddSelectNodeFromStruct_InPosition_Offset;

	private static bool AddSelectNodeFromStruct_InNodeName_IsValid;

	private static FFieldAddress AddSelectNodeFromStruct_InNodeName_PropertyAddress;

	private static int AddSelectNodeFromStruct_InNodeName_Offset;

	private static bool AddSelectNodeFromStruct_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddSelectNodeFromStruct_bSetupUndoRedo_PropertyAddress;

	private static int AddSelectNodeFromStruct_bSetupUndoRedo_Offset;

	private static bool AddSelectNodeFromStruct_ReturnValue_IsValid;

	private static FFieldAddress AddSelectNodeFromStruct_ReturnValue_PropertyAddress;

	private static int AddSelectNodeFromStruct_ReturnValue_Offset;

	private static bool AddSelectNode_IsValid;

	private static IntPtr AddSelectNode_FunctionAddress;

	private static int AddSelectNode_ParamsSize;

	private static bool AddSelectNode_InCPPType_IsValid;

	private static FFieldAddress AddSelectNode_InCPPType_PropertyAddress;

	private static int AddSelectNode_InCPPType_Offset;

	private static bool AddSelectNode_InCPPTypeObjectPath_IsValid;

	private static FFieldAddress AddSelectNode_InCPPTypeObjectPath_PropertyAddress;

	private static int AddSelectNode_InCPPTypeObjectPath_Offset;

	private static bool AddSelectNode_InPosition_IsValid;

	private static FFieldAddress AddSelectNode_InPosition_PropertyAddress;

	private static int AddSelectNode_InPosition_Offset;

	private static bool AddSelectNode_InNodeName_IsValid;

	private static FFieldAddress AddSelectNode_InNodeName_PropertyAddress;

	private static int AddSelectNode_InNodeName_Offset;

	private static bool AddSelectNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddSelectNode_bSetupUndoRedo_PropertyAddress;

	private static int AddSelectNode_bSetupUndoRedo_Offset;

	private static bool AddSelectNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddSelectNode_bPrintPythonCommand_PropertyAddress;

	private static int AddSelectNode_bPrintPythonCommand_Offset;

	private static bool AddSelectNode_ReturnValue_IsValid;

	private static FFieldAddress AddSelectNode_ReturnValue_PropertyAddress;

	private static int AddSelectNode_ReturnValue_Offset;

	private static bool AddRerouteNodeOnPin_IsValid;

	private static IntPtr AddRerouteNodeOnPin_FunctionAddress;

	private static int AddRerouteNodeOnPin_ParamsSize;

	private static bool AddRerouteNodeOnPin_InPinPath_IsValid;

	private static FFieldAddress AddRerouteNodeOnPin_InPinPath_PropertyAddress;

	private static int AddRerouteNodeOnPin_InPinPath_Offset;

	private static bool AddRerouteNodeOnPin_bAsInput_IsValid;

	private static FFieldAddress AddRerouteNodeOnPin_bAsInput_PropertyAddress;

	private static int AddRerouteNodeOnPin_bAsInput_Offset;

	private static bool AddRerouteNodeOnPin_bShowAsFullNode_IsValid;

	private static FFieldAddress AddRerouteNodeOnPin_bShowAsFullNode_PropertyAddress;

	private static int AddRerouteNodeOnPin_bShowAsFullNode_Offset;

	private static bool AddRerouteNodeOnPin_InPosition_IsValid;

	private static FFieldAddress AddRerouteNodeOnPin_InPosition_PropertyAddress;

	private static int AddRerouteNodeOnPin_InPosition_Offset;

	private static bool AddRerouteNodeOnPin_InNodeName_IsValid;

	private static FFieldAddress AddRerouteNodeOnPin_InNodeName_PropertyAddress;

	private static int AddRerouteNodeOnPin_InNodeName_Offset;

	private static bool AddRerouteNodeOnPin_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddRerouteNodeOnPin_bSetupUndoRedo_PropertyAddress;

	private static int AddRerouteNodeOnPin_bSetupUndoRedo_Offset;

	private static bool AddRerouteNodeOnPin_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddRerouteNodeOnPin_bPrintPythonCommand_PropertyAddress;

	private static int AddRerouteNodeOnPin_bPrintPythonCommand_Offset;

	private static bool AddRerouteNodeOnPin_ReturnValue_IsValid;

	private static FFieldAddress AddRerouteNodeOnPin_ReturnValue_PropertyAddress;

	private static int AddRerouteNodeOnPin_ReturnValue_Offset;

	private static bool AddRerouteNodeOnLinkPath_IsValid;

	private static IntPtr AddRerouteNodeOnLinkPath_FunctionAddress;

	private static int AddRerouteNodeOnLinkPath_ParamsSize;

	private static bool AddRerouteNodeOnLinkPath_InLinkPinPathRepresentation_IsValid;

	private static FFieldAddress AddRerouteNodeOnLinkPath_InLinkPinPathRepresentation_PropertyAddress;

	private static int AddRerouteNodeOnLinkPath_InLinkPinPathRepresentation_Offset;

	private static bool AddRerouteNodeOnLinkPath_bShowAsFullNode_IsValid;

	private static FFieldAddress AddRerouteNodeOnLinkPath_bShowAsFullNode_PropertyAddress;

	private static int AddRerouteNodeOnLinkPath_bShowAsFullNode_Offset;

	private static bool AddRerouteNodeOnLinkPath_InPosition_IsValid;

	private static FFieldAddress AddRerouteNodeOnLinkPath_InPosition_PropertyAddress;

	private static int AddRerouteNodeOnLinkPath_InPosition_Offset;

	private static bool AddRerouteNodeOnLinkPath_InNodeName_IsValid;

	private static FFieldAddress AddRerouteNodeOnLinkPath_InNodeName_PropertyAddress;

	private static int AddRerouteNodeOnLinkPath_InNodeName_Offset;

	private static bool AddRerouteNodeOnLinkPath_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddRerouteNodeOnLinkPath_bSetupUndoRedo_PropertyAddress;

	private static int AddRerouteNodeOnLinkPath_bSetupUndoRedo_Offset;

	private static bool AddRerouteNodeOnLinkPath_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddRerouteNodeOnLinkPath_bPrintPythonCommand_PropertyAddress;

	private static int AddRerouteNodeOnLinkPath_bPrintPythonCommand_Offset;

	private static bool AddRerouteNodeOnLinkPath_ReturnValue_IsValid;

	private static FFieldAddress AddRerouteNodeOnLinkPath_ReturnValue_PropertyAddress;

	private static int AddRerouteNodeOnLinkPath_ReturnValue_Offset;

	private static bool AddRerouteNodeOnLink_IsValid;

	private static IntPtr AddRerouteNodeOnLink_FunctionAddress;

	private static int AddRerouteNodeOnLink_ParamsSize;

	private static bool AddRerouteNodeOnLink_InLink_IsValid;

	private static FFieldAddress AddRerouteNodeOnLink_InLink_PropertyAddress;

	private static int AddRerouteNodeOnLink_InLink_Offset;

	private static bool AddRerouteNodeOnLink_bShowAsFullNode_IsValid;

	private static FFieldAddress AddRerouteNodeOnLink_bShowAsFullNode_PropertyAddress;

	private static int AddRerouteNodeOnLink_bShowAsFullNode_Offset;

	private static bool AddRerouteNodeOnLink_InPosition_IsValid;

	private static FFieldAddress AddRerouteNodeOnLink_InPosition_PropertyAddress;

	private static int AddRerouteNodeOnLink_InPosition_Offset;

	private static bool AddRerouteNodeOnLink_InNodeName_IsValid;

	private static FFieldAddress AddRerouteNodeOnLink_InNodeName_PropertyAddress;

	private static int AddRerouteNodeOnLink_InNodeName_Offset;

	private static bool AddRerouteNodeOnLink_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddRerouteNodeOnLink_bSetupUndoRedo_PropertyAddress;

	private static int AddRerouteNodeOnLink_bSetupUndoRedo_Offset;

	private static bool AddRerouteNodeOnLink_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddRerouteNodeOnLink_bPrintPythonCommand_PropertyAddress;

	private static int AddRerouteNodeOnLink_bPrintPythonCommand_Offset;

	private static bool AddRerouteNodeOnLink_ReturnValue_IsValid;

	private static FFieldAddress AddRerouteNodeOnLink_ReturnValue_PropertyAddress;

	private static int AddRerouteNodeOnLink_ReturnValue_Offset;

	private static bool AddPrototypeNode_IsValid;

	private static IntPtr AddPrototypeNode_FunctionAddress;

	private static int AddPrototypeNode_ParamsSize;

	private static bool AddPrototypeNode_InNotation_IsValid;

	private static FFieldAddress AddPrototypeNode_InNotation_PropertyAddress;

	private static int AddPrototypeNode_InNotation_Offset;

	private static bool AddPrototypeNode_InPosition_IsValid;

	private static FFieldAddress AddPrototypeNode_InPosition_PropertyAddress;

	private static int AddPrototypeNode_InPosition_Offset;

	private static bool AddPrototypeNode_InNodeName_IsValid;

	private static FFieldAddress AddPrototypeNode_InNodeName_PropertyAddress;

	private static int AddPrototypeNode_InNodeName_Offset;

	private static bool AddPrototypeNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddPrototypeNode_bSetupUndoRedo_PropertyAddress;

	private static int AddPrototypeNode_bSetupUndoRedo_Offset;

	private static bool AddPrototypeNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddPrototypeNode_bPrintPythonCommand_PropertyAddress;

	private static int AddPrototypeNode_bPrintPythonCommand_Offset;

	private static bool AddPrototypeNode_ReturnValue_IsValid;

	private static FFieldAddress AddPrototypeNode_ReturnValue_PropertyAddress;

	private static int AddPrototypeNode_ReturnValue_Offset;

	private static bool AddParameterNodeFromObjectPath_IsValid;

	private static IntPtr AddParameterNodeFromObjectPath_FunctionAddress;

	private static int AddParameterNodeFromObjectPath_ParamsSize;

	private static bool AddParameterNodeFromObjectPath_InParameterName_IsValid;

	private static FFieldAddress AddParameterNodeFromObjectPath_InParameterName_PropertyAddress;

	private static int AddParameterNodeFromObjectPath_InParameterName_Offset;

	private static bool AddParameterNodeFromObjectPath_InCPPType_IsValid;

	private static FFieldAddress AddParameterNodeFromObjectPath_InCPPType_PropertyAddress;

	private static int AddParameterNodeFromObjectPath_InCPPType_Offset;

	private static bool AddParameterNodeFromObjectPath_InCPPTypeObjectPath_IsValid;

	private static FFieldAddress AddParameterNodeFromObjectPath_InCPPTypeObjectPath_PropertyAddress;

	private static int AddParameterNodeFromObjectPath_InCPPTypeObjectPath_Offset;

	private static bool AddParameterNodeFromObjectPath_bIsInput_IsValid;

	private static FFieldAddress AddParameterNodeFromObjectPath_bIsInput_PropertyAddress;

	private static int AddParameterNodeFromObjectPath_bIsInput_Offset;

	private static bool AddParameterNodeFromObjectPath_InDefaultValue_IsValid;

	private static FFieldAddress AddParameterNodeFromObjectPath_InDefaultValue_PropertyAddress;

	private static int AddParameterNodeFromObjectPath_InDefaultValue_Offset;

	private static bool AddParameterNodeFromObjectPath_InPosition_IsValid;

	private static FFieldAddress AddParameterNodeFromObjectPath_InPosition_PropertyAddress;

	private static int AddParameterNodeFromObjectPath_InPosition_Offset;

	private static bool AddParameterNodeFromObjectPath_InNodeName_IsValid;

	private static FFieldAddress AddParameterNodeFromObjectPath_InNodeName_PropertyAddress;

	private static int AddParameterNodeFromObjectPath_InNodeName_Offset;

	private static bool AddParameterNodeFromObjectPath_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddParameterNodeFromObjectPath_bSetupUndoRedo_PropertyAddress;

	private static int AddParameterNodeFromObjectPath_bSetupUndoRedo_Offset;

	private static bool AddParameterNodeFromObjectPath_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddParameterNodeFromObjectPath_bPrintPythonCommand_PropertyAddress;

	private static int AddParameterNodeFromObjectPath_bPrintPythonCommand_Offset;

	private static bool AddParameterNodeFromObjectPath_ReturnValue_IsValid;

	private static FFieldAddress AddParameterNodeFromObjectPath_ReturnValue_PropertyAddress;

	private static int AddParameterNodeFromObjectPath_ReturnValue_Offset;

	private static bool AddParameterNode_IsValid;

	private static IntPtr AddParameterNode_FunctionAddress;

	private static int AddParameterNode_ParamsSize;

	private static bool AddParameterNode_InParameterName_IsValid;

	private static FFieldAddress AddParameterNode_InParameterName_PropertyAddress;

	private static int AddParameterNode_InParameterName_Offset;

	private static bool AddParameterNode_InCPPType_IsValid;

	private static FFieldAddress AddParameterNode_InCPPType_PropertyAddress;

	private static int AddParameterNode_InCPPType_Offset;

	private static bool AddParameterNode_InCPPTypeObject_IsValid;

	private static FFieldAddress AddParameterNode_InCPPTypeObject_PropertyAddress;

	private static int AddParameterNode_InCPPTypeObject_Offset;

	private static bool AddParameterNode_bIsInput_IsValid;

	private static FFieldAddress AddParameterNode_bIsInput_PropertyAddress;

	private static int AddParameterNode_bIsInput_Offset;

	private static bool AddParameterNode_InDefaultValue_IsValid;

	private static FFieldAddress AddParameterNode_InDefaultValue_PropertyAddress;

	private static int AddParameterNode_InDefaultValue_Offset;

	private static bool AddParameterNode_InPosition_IsValid;

	private static FFieldAddress AddParameterNode_InPosition_PropertyAddress;

	private static int AddParameterNode_InPosition_Offset;

	private static bool AddParameterNode_InNodeName_IsValid;

	private static FFieldAddress AddParameterNode_InNodeName_PropertyAddress;

	private static int AddParameterNode_InNodeName_Offset;

	private static bool AddParameterNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddParameterNode_bSetupUndoRedo_PropertyAddress;

	private static int AddParameterNode_bSetupUndoRedo_Offset;

	private static bool AddParameterNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddParameterNode_bPrintPythonCommand_PropertyAddress;

	private static int AddParameterNode_bPrintPythonCommand_Offset;

	private static bool AddParameterNode_ReturnValue_IsValid;

	private static FFieldAddress AddParameterNode_ReturnValue_PropertyAddress;

	private static int AddParameterNode_ReturnValue_Offset;

	private static bool AddLocalVariableFromObjectPath_IsValid;

	private static IntPtr AddLocalVariableFromObjectPath_FunctionAddress;

	private static int AddLocalVariableFromObjectPath_ParamsSize;

	private static bool AddLocalVariableFromObjectPath_InVariableName_IsValid;

	private static FFieldAddress AddLocalVariableFromObjectPath_InVariableName_PropertyAddress;

	private static int AddLocalVariableFromObjectPath_InVariableName_Offset;

	private static bool AddLocalVariableFromObjectPath_InCPPType_IsValid;

	private static FFieldAddress AddLocalVariableFromObjectPath_InCPPType_PropertyAddress;

	private static int AddLocalVariableFromObjectPath_InCPPType_Offset;

	private static bool AddLocalVariableFromObjectPath_InCPPTypeObjectPath_IsValid;

	private static FFieldAddress AddLocalVariableFromObjectPath_InCPPTypeObjectPath_PropertyAddress;

	private static int AddLocalVariableFromObjectPath_InCPPTypeObjectPath_Offset;

	private static bool AddLocalVariableFromObjectPath_InDefaultValue_IsValid;

	private static FFieldAddress AddLocalVariableFromObjectPath_InDefaultValue_PropertyAddress;

	private static int AddLocalVariableFromObjectPath_InDefaultValue_Offset;

	private static bool AddLocalVariableFromObjectPath_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddLocalVariableFromObjectPath_bSetupUndoRedo_PropertyAddress;

	private static int AddLocalVariableFromObjectPath_bSetupUndoRedo_Offset;

	private static bool AddLocalVariableFromObjectPath_ReturnValue_IsValid;

	private static FFieldAddress AddLocalVariableFromObjectPath_ReturnValue_PropertyAddress;

	private static int AddLocalVariableFromObjectPath_ReturnValue_Offset;

	private static bool AddLocalVariable_IsValid;

	private static IntPtr AddLocalVariable_FunctionAddress;

	private static int AddLocalVariable_ParamsSize;

	private static bool AddLocalVariable_InVariableName_IsValid;

	private static FFieldAddress AddLocalVariable_InVariableName_PropertyAddress;

	private static int AddLocalVariable_InVariableName_Offset;

	private static bool AddLocalVariable_InCPPType_IsValid;

	private static FFieldAddress AddLocalVariable_InCPPType_PropertyAddress;

	private static int AddLocalVariable_InCPPType_Offset;

	private static bool AddLocalVariable_InCPPTypeObject_IsValid;

	private static FFieldAddress AddLocalVariable_InCPPTypeObject_PropertyAddress;

	private static int AddLocalVariable_InCPPTypeObject_Offset;

	private static bool AddLocalVariable_InDefaultValue_IsValid;

	private static FFieldAddress AddLocalVariable_InDefaultValue_PropertyAddress;

	private static int AddLocalVariable_InDefaultValue_Offset;

	private static bool AddLocalVariable_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddLocalVariable_bSetupUndoRedo_PropertyAddress;

	private static int AddLocalVariable_bSetupUndoRedo_Offset;

	private static bool AddLocalVariable_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddLocalVariable_bPrintPythonCommand_PropertyAddress;

	private static int AddLocalVariable_bPrintPythonCommand_Offset;

	private static bool AddLocalVariable_ReturnValue_IsValid;

	private static FFieldAddress AddLocalVariable_ReturnValue_PropertyAddress;

	private static int AddLocalVariable_ReturnValue_Offset;

	private static bool AddLink_IsValid;

	private static IntPtr AddLink_FunctionAddress;

	private static int AddLink_ParamsSize;

	private static bool AddLink_InOutputPinPath_IsValid;

	private static FFieldAddress AddLink_InOutputPinPath_PropertyAddress;

	private static int AddLink_InOutputPinPath_Offset;

	private static bool AddLink_InInputPinPath_IsValid;

	private static FFieldAddress AddLink_InInputPinPath_PropertyAddress;

	private static int AddLink_InInputPinPath_Offset;

	private static bool AddLink_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddLink_bSetupUndoRedo_PropertyAddress;

	private static int AddLink_bSetupUndoRedo_Offset;

	private static bool AddLink_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddLink_bPrintPythonCommand_PropertyAddress;

	private static int AddLink_bPrintPythonCommand_Offset;

	private static bool AddLink_ReturnValue_IsValid;

	private static FFieldAddress AddLink_ReturnValue_PropertyAddress;

	private static int AddLink_ReturnValue_Offset;

	private static bool AddInjectedNodeFromStructPath_IsValid;

	private static IntPtr AddInjectedNodeFromStructPath_FunctionAddress;

	private static int AddInjectedNodeFromStructPath_ParamsSize;

	private static bool AddInjectedNodeFromStructPath_InPinPath_IsValid;

	private static FFieldAddress AddInjectedNodeFromStructPath_InPinPath_PropertyAddress;

	private static int AddInjectedNodeFromStructPath_InPinPath_Offset;

	private static bool AddInjectedNodeFromStructPath_bAsInput_IsValid;

	private static FFieldAddress AddInjectedNodeFromStructPath_bAsInput_PropertyAddress;

	private static int AddInjectedNodeFromStructPath_bAsInput_Offset;

	private static bool AddInjectedNodeFromStructPath_InScriptStructPath_IsValid;

	private static FFieldAddress AddInjectedNodeFromStructPath_InScriptStructPath_PropertyAddress;

	private static int AddInjectedNodeFromStructPath_InScriptStructPath_Offset;

	private static bool AddInjectedNodeFromStructPath_InMethodName_IsValid;

	private static FFieldAddress AddInjectedNodeFromStructPath_InMethodName_PropertyAddress;

	private static int AddInjectedNodeFromStructPath_InMethodName_Offset;

	private static bool AddInjectedNodeFromStructPath_InInputPinName_IsValid;

	private static FFieldAddress AddInjectedNodeFromStructPath_InInputPinName_PropertyAddress;

	private static int AddInjectedNodeFromStructPath_InInputPinName_Offset;

	private static bool AddInjectedNodeFromStructPath_InOutputPinName_IsValid;

	private static FFieldAddress AddInjectedNodeFromStructPath_InOutputPinName_PropertyAddress;

	private static int AddInjectedNodeFromStructPath_InOutputPinName_Offset;

	private static bool AddInjectedNodeFromStructPath_InNodeName_IsValid;

	private static FFieldAddress AddInjectedNodeFromStructPath_InNodeName_PropertyAddress;

	private static int AddInjectedNodeFromStructPath_InNodeName_Offset;

	private static bool AddInjectedNodeFromStructPath_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddInjectedNodeFromStructPath_bSetupUndoRedo_PropertyAddress;

	private static int AddInjectedNodeFromStructPath_bSetupUndoRedo_Offset;

	private static bool AddInjectedNodeFromStructPath_ReturnValue_IsValid;

	private static FFieldAddress AddInjectedNodeFromStructPath_ReturnValue_PropertyAddress;

	private static int AddInjectedNodeFromStructPath_ReturnValue_Offset;

	private static bool AddInjectedNode_IsValid;

	private static IntPtr AddInjectedNode_FunctionAddress;

	private static int AddInjectedNode_ParamsSize;

	private static bool AddInjectedNode_InPinPath_IsValid;

	private static FFieldAddress AddInjectedNode_InPinPath_PropertyAddress;

	private static int AddInjectedNode_InPinPath_Offset;

	private static bool AddInjectedNode_bAsInput_IsValid;

	private static FFieldAddress AddInjectedNode_bAsInput_PropertyAddress;

	private static int AddInjectedNode_bAsInput_Offset;

	private static bool AddInjectedNode_InScriptStruct_IsValid;

	private static FFieldAddress AddInjectedNode_InScriptStruct_PropertyAddress;

	private static int AddInjectedNode_InScriptStruct_Offset;

	private static bool AddInjectedNode_InMethodName_IsValid;

	private static FFieldAddress AddInjectedNode_InMethodName_PropertyAddress;

	private static int AddInjectedNode_InMethodName_Offset;

	private static bool AddInjectedNode_InInputPinName_IsValid;

	private static FFieldAddress AddInjectedNode_InInputPinName_PropertyAddress;

	private static int AddInjectedNode_InInputPinName_Offset;

	private static bool AddInjectedNode_InOutputPinName_IsValid;

	private static FFieldAddress AddInjectedNode_InOutputPinName_PropertyAddress;

	private static int AddInjectedNode_InOutputPinName_Offset;

	private static bool AddInjectedNode_InNodeName_IsValid;

	private static FFieldAddress AddInjectedNode_InNodeName_PropertyAddress;

	private static int AddInjectedNode_InNodeName_Offset;

	private static bool AddInjectedNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddInjectedNode_bSetupUndoRedo_PropertyAddress;

	private static int AddInjectedNode_bSetupUndoRedo_Offset;

	private static bool AddInjectedNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddInjectedNode_bPrintPythonCommand_PropertyAddress;

	private static int AddInjectedNode_bPrintPythonCommand_Offset;

	private static bool AddInjectedNode_ReturnValue_IsValid;

	private static FFieldAddress AddInjectedNode_ReturnValue_PropertyAddress;

	private static int AddInjectedNode_ReturnValue_Offset;

	private static bool AddIfNodeFromStruct_IsValid;

	private static IntPtr AddIfNodeFromStruct_FunctionAddress;

	private static int AddIfNodeFromStruct_ParamsSize;

	private static bool AddIfNodeFromStruct_InScriptStruct_IsValid;

	private static FFieldAddress AddIfNodeFromStruct_InScriptStruct_PropertyAddress;

	private static int AddIfNodeFromStruct_InScriptStruct_Offset;

	private static bool AddIfNodeFromStruct_InPosition_IsValid;

	private static FFieldAddress AddIfNodeFromStruct_InPosition_PropertyAddress;

	private static int AddIfNodeFromStruct_InPosition_Offset;

	private static bool AddIfNodeFromStruct_InNodeName_IsValid;

	private static FFieldAddress AddIfNodeFromStruct_InNodeName_PropertyAddress;

	private static int AddIfNodeFromStruct_InNodeName_Offset;

	private static bool AddIfNodeFromStruct_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddIfNodeFromStruct_bSetupUndoRedo_PropertyAddress;

	private static int AddIfNodeFromStruct_bSetupUndoRedo_Offset;

	private static bool AddIfNodeFromStruct_ReturnValue_IsValid;

	private static FFieldAddress AddIfNodeFromStruct_ReturnValue_PropertyAddress;

	private static int AddIfNodeFromStruct_ReturnValue_Offset;

	private static bool AddIfNode_IsValid;

	private static IntPtr AddIfNode_FunctionAddress;

	private static int AddIfNode_ParamsSize;

	private static bool AddIfNode_InCPPType_IsValid;

	private static FFieldAddress AddIfNode_InCPPType_PropertyAddress;

	private static int AddIfNode_InCPPType_Offset;

	private static bool AddIfNode_InCPPTypeObjectPath_IsValid;

	private static FFieldAddress AddIfNode_InCPPTypeObjectPath_PropertyAddress;

	private static int AddIfNode_InCPPTypeObjectPath_Offset;

	private static bool AddIfNode_InPosition_IsValid;

	private static FFieldAddress AddIfNode_InPosition_PropertyAddress;

	private static int AddIfNode_InPosition_Offset;

	private static bool AddIfNode_InNodeName_IsValid;

	private static FFieldAddress AddIfNode_InNodeName_PropertyAddress;

	private static int AddIfNode_InNodeName_Offset;

	private static bool AddIfNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddIfNode_bSetupUndoRedo_PropertyAddress;

	private static int AddIfNode_bSetupUndoRedo_Offset;

	private static bool AddIfNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddIfNode_bPrintPythonCommand_PropertyAddress;

	private static int AddIfNode_bPrintPythonCommand_Offset;

	private static bool AddIfNode_ReturnValue_IsValid;

	private static FFieldAddress AddIfNode_ReturnValue_PropertyAddress;

	private static int AddIfNode_ReturnValue_Offset;

	private static bool AddFunctionToLibrary_IsValid;

	private static IntPtr AddFunctionToLibrary_FunctionAddress;

	private static int AddFunctionToLibrary_ParamsSize;

	private static bool AddFunctionToLibrary_InFunctionName_IsValid;

	private static FFieldAddress AddFunctionToLibrary_InFunctionName_PropertyAddress;

	private static int AddFunctionToLibrary_InFunctionName_Offset;

	private static bool AddFunctionToLibrary_bMutable_IsValid;

	private static FFieldAddress AddFunctionToLibrary_bMutable_PropertyAddress;

	private static int AddFunctionToLibrary_bMutable_Offset;

	private static bool AddFunctionToLibrary_InNodePosition_IsValid;

	private static FFieldAddress AddFunctionToLibrary_InNodePosition_PropertyAddress;

	private static int AddFunctionToLibrary_InNodePosition_Offset;

	private static bool AddFunctionToLibrary_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddFunctionToLibrary_bSetupUndoRedo_PropertyAddress;

	private static int AddFunctionToLibrary_bSetupUndoRedo_Offset;

	private static bool AddFunctionToLibrary_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddFunctionToLibrary_bPrintPythonCommand_PropertyAddress;

	private static int AddFunctionToLibrary_bPrintPythonCommand_Offset;

	private static bool AddFunctionToLibrary_ReturnValue_IsValid;

	private static FFieldAddress AddFunctionToLibrary_ReturnValue_PropertyAddress;

	private static int AddFunctionToLibrary_ReturnValue_Offset;

	private static bool AddFunctionReferenceNode_IsValid;

	private static IntPtr AddFunctionReferenceNode_FunctionAddress;

	private static int AddFunctionReferenceNode_ParamsSize;

	private static bool AddFunctionReferenceNode_InFunctionDefinition_IsValid;

	private static FFieldAddress AddFunctionReferenceNode_InFunctionDefinition_PropertyAddress;

	private static int AddFunctionReferenceNode_InFunctionDefinition_Offset;

	private static bool AddFunctionReferenceNode_InNodePosition_IsValid;

	private static FFieldAddress AddFunctionReferenceNode_InNodePosition_PropertyAddress;

	private static int AddFunctionReferenceNode_InNodePosition_Offset;

	private static bool AddFunctionReferenceNode_InNodeName_IsValid;

	private static FFieldAddress AddFunctionReferenceNode_InNodeName_PropertyAddress;

	private static int AddFunctionReferenceNode_InNodeName_Offset;

	private static bool AddFunctionReferenceNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddFunctionReferenceNode_bSetupUndoRedo_PropertyAddress;

	private static int AddFunctionReferenceNode_bSetupUndoRedo_Offset;

	private static bool AddFunctionReferenceNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddFunctionReferenceNode_bPrintPythonCommand_PropertyAddress;

	private static int AddFunctionReferenceNode_bPrintPythonCommand_Offset;

	private static bool AddFunctionReferenceNode_ReturnValue_IsValid;

	private static FFieldAddress AddFunctionReferenceNode_ReturnValue_PropertyAddress;

	private static int AddFunctionReferenceNode_ReturnValue_Offset;

	private static bool AddFreeRerouteNode_IsValid;

	private static IntPtr AddFreeRerouteNode_FunctionAddress;

	private static int AddFreeRerouteNode_ParamsSize;

	private static bool AddFreeRerouteNode_bShowAsFullNode_IsValid;

	private static FFieldAddress AddFreeRerouteNode_bShowAsFullNode_PropertyAddress;

	private static int AddFreeRerouteNode_bShowAsFullNode_Offset;

	private static bool AddFreeRerouteNode_InCPPType_IsValid;

	private static FFieldAddress AddFreeRerouteNode_InCPPType_PropertyAddress;

	private static int AddFreeRerouteNode_InCPPType_Offset;

	private static bool AddFreeRerouteNode_InCPPTypeObjectPath_IsValid;

	private static FFieldAddress AddFreeRerouteNode_InCPPTypeObjectPath_PropertyAddress;

	private static int AddFreeRerouteNode_InCPPTypeObjectPath_Offset;

	private static bool AddFreeRerouteNode_bIsConstant_IsValid;

	private static FFieldAddress AddFreeRerouteNode_bIsConstant_PropertyAddress;

	private static int AddFreeRerouteNode_bIsConstant_Offset;

	private static bool AddFreeRerouteNode_InCustomWidgetName_IsValid;

	private static FFieldAddress AddFreeRerouteNode_InCustomWidgetName_PropertyAddress;

	private static int AddFreeRerouteNode_InCustomWidgetName_Offset;

	private static bool AddFreeRerouteNode_InDefaultValue_IsValid;

	private static FFieldAddress AddFreeRerouteNode_InDefaultValue_PropertyAddress;

	private static int AddFreeRerouteNode_InDefaultValue_Offset;

	private static bool AddFreeRerouteNode_InPosition_IsValid;

	private static FFieldAddress AddFreeRerouteNode_InPosition_PropertyAddress;

	private static int AddFreeRerouteNode_InPosition_Offset;

	private static bool AddFreeRerouteNode_InNodeName_IsValid;

	private static FFieldAddress AddFreeRerouteNode_InNodeName_PropertyAddress;

	private static int AddFreeRerouteNode_InNodeName_Offset;

	private static bool AddFreeRerouteNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddFreeRerouteNode_bSetupUndoRedo_PropertyAddress;

	private static int AddFreeRerouteNode_bSetupUndoRedo_Offset;

	private static bool AddFreeRerouteNode_ReturnValue_IsValid;

	private static FFieldAddress AddFreeRerouteNode_ReturnValue_PropertyAddress;

	private static int AddFreeRerouteNode_ReturnValue_Offset;

	private static bool AddExposedPin_IsValid;

	private static IntPtr AddExposedPin_FunctionAddress;

	private static int AddExposedPin_ParamsSize;

	private static bool AddExposedPin_InPinName_IsValid;

	private static FFieldAddress AddExposedPin_InPinName_PropertyAddress;

	private static int AddExposedPin_InPinName_Offset;

	private static bool AddExposedPin_InDirection_IsValid;

	private static FFieldAddress AddExposedPin_InDirection_PropertyAddress;

	private static int AddExposedPin_InDirection_Offset;

	private static bool AddExposedPin_InCPPType_IsValid;

	private static FFieldAddress AddExposedPin_InCPPType_PropertyAddress;

	private static int AddExposedPin_InCPPType_Offset;

	private static bool AddExposedPin_InCPPTypeObjectPath_IsValid;

	private static FFieldAddress AddExposedPin_InCPPTypeObjectPath_PropertyAddress;

	private static int AddExposedPin_InCPPTypeObjectPath_Offset;

	private static bool AddExposedPin_InDefaultValue_IsValid;

	private static FFieldAddress AddExposedPin_InDefaultValue_PropertyAddress;

	private static int AddExposedPin_InDefaultValue_Offset;

	private static bool AddExposedPin_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddExposedPin_bSetupUndoRedo_PropertyAddress;

	private static int AddExposedPin_bSetupUndoRedo_Offset;

	private static bool AddExposedPin_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddExposedPin_bPrintPythonCommand_PropertyAddress;

	private static int AddExposedPin_bPrintPythonCommand_Offset;

	private static bool AddExposedPin_ReturnValue_IsValid;

	private static FFieldAddress AddExposedPin_ReturnValue_PropertyAddress;

	private static int AddExposedPin_ReturnValue_Offset;

	private static bool AddEnumNode_IsValid;

	private static IntPtr AddEnumNode_FunctionAddress;

	private static int AddEnumNode_ParamsSize;

	private static bool AddEnumNode_InCPPTypeObjectPath_IsValid;

	private static FFieldAddress AddEnumNode_InCPPTypeObjectPath_PropertyAddress;

	private static int AddEnumNode_InCPPTypeObjectPath_Offset;

	private static bool AddEnumNode_InPosition_IsValid;

	private static FFieldAddress AddEnumNode_InPosition_PropertyAddress;

	private static int AddEnumNode_InPosition_Offset;

	private static bool AddEnumNode_InNodeName_IsValid;

	private static FFieldAddress AddEnumNode_InNodeName_PropertyAddress;

	private static int AddEnumNode_InNodeName_Offset;

	private static bool AddEnumNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddEnumNode_bSetupUndoRedo_PropertyAddress;

	private static int AddEnumNode_bSetupUndoRedo_Offset;

	private static bool AddEnumNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddEnumNode_bPrintPythonCommand_PropertyAddress;

	private static int AddEnumNode_bPrintPythonCommand_Offset;

	private static bool AddEnumNode_ReturnValue_IsValid;

	private static FFieldAddress AddEnumNode_ReturnValue_PropertyAddress;

	private static int AddEnumNode_ReturnValue_Offset;

	private static bool AddCommentNode_IsValid;

	private static IntPtr AddCommentNode_FunctionAddress;

	private static int AddCommentNode_ParamsSize;

	private static bool AddCommentNode_InCommentText_IsValid;

	private static FFieldAddress AddCommentNode_InCommentText_PropertyAddress;

	private static int AddCommentNode_InCommentText_Offset;

	private static bool AddCommentNode_InPosition_IsValid;

	private static FFieldAddress AddCommentNode_InPosition_PropertyAddress;

	private static int AddCommentNode_InPosition_Offset;

	private static bool AddCommentNode_InSize_IsValid;

	private static FFieldAddress AddCommentNode_InSize_PropertyAddress;

	private static int AddCommentNode_InSize_Offset;

	private static bool AddCommentNode_InColor_IsValid;

	private static FFieldAddress AddCommentNode_InColor_PropertyAddress;

	private static int AddCommentNode_InColor_Offset;

	private static bool AddCommentNode_InNodeName_IsValid;

	private static FFieldAddress AddCommentNode_InNodeName_PropertyAddress;

	private static int AddCommentNode_InNodeName_Offset;

	private static bool AddCommentNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddCommentNode_bSetupUndoRedo_PropertyAddress;

	private static int AddCommentNode_bSetupUndoRedo_Offset;

	private static bool AddCommentNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddCommentNode_bPrintPythonCommand_PropertyAddress;

	private static int AddCommentNode_bPrintPythonCommand_Offset;

	private static bool AddCommentNode_ReturnValue_IsValid;

	private static FFieldAddress AddCommentNode_ReturnValue_PropertyAddress;

	private static int AddCommentNode_ReturnValue_Offset;

	private static bool AddBranchNode_IsValid;

	private static IntPtr AddBranchNode_FunctionAddress;

	private static int AddBranchNode_ParamsSize;

	private static bool AddBranchNode_InPosition_IsValid;

	private static FFieldAddress AddBranchNode_InPosition_PropertyAddress;

	private static int AddBranchNode_InPosition_Offset;

	private static bool AddBranchNode_InNodeName_IsValid;

	private static FFieldAddress AddBranchNode_InNodeName_PropertyAddress;

	private static int AddBranchNode_InNodeName_Offset;

	private static bool AddBranchNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddBranchNode_bSetupUndoRedo_PropertyAddress;

	private static int AddBranchNode_bSetupUndoRedo_Offset;

	private static bool AddBranchNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddBranchNode_bPrintPythonCommand_PropertyAddress;

	private static int AddBranchNode_bPrintPythonCommand_Offset;

	private static bool AddBranchNode_ReturnValue_IsValid;

	private static FFieldAddress AddBranchNode_ReturnValue_PropertyAddress;

	private static int AddBranchNode_ReturnValue_Offset;

	private static bool AddArrayPin_IsValid;

	private static IntPtr AddArrayPin_FunctionAddress;

	private static int AddArrayPin_ParamsSize;

	private static bool AddArrayPin_InArrayPinPath_IsValid;

	private static FFieldAddress AddArrayPin_InArrayPinPath_PropertyAddress;

	private static int AddArrayPin_InArrayPinPath_Offset;

	private static bool AddArrayPin_InDefaultValue_IsValid;

	private static FFieldAddress AddArrayPin_InDefaultValue_PropertyAddress;

	private static int AddArrayPin_InDefaultValue_Offset;

	private static bool AddArrayPin_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddArrayPin_bSetupUndoRedo_PropertyAddress;

	private static int AddArrayPin_bSetupUndoRedo_Offset;

	private static bool AddArrayPin_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddArrayPin_bPrintPythonCommand_PropertyAddress;

	private static int AddArrayPin_bPrintPythonCommand_Offset;

	private static bool AddArrayPin_ReturnValue_IsValid;

	private static FFieldAddress AddArrayPin_ReturnValue_PropertyAddress;

	private static int AddArrayPin_ReturnValue_Offset;

	private static bool AddArrayNodeFromObjectPath_IsValid;

	private static IntPtr AddArrayNodeFromObjectPath_FunctionAddress;

	private static int AddArrayNodeFromObjectPath_ParamsSize;

	private static bool AddArrayNodeFromObjectPath_InOpCode_IsValid;

	private static FFieldAddress AddArrayNodeFromObjectPath_InOpCode_PropertyAddress;

	private static int AddArrayNodeFromObjectPath_InOpCode_Offset;

	private static bool AddArrayNodeFromObjectPath_InCPPType_IsValid;

	private static FFieldAddress AddArrayNodeFromObjectPath_InCPPType_PropertyAddress;

	private static int AddArrayNodeFromObjectPath_InCPPType_Offset;

	private static bool AddArrayNodeFromObjectPath_InCPPTypeObjectPath_IsValid;

	private static FFieldAddress AddArrayNodeFromObjectPath_InCPPTypeObjectPath_PropertyAddress;

	private static int AddArrayNodeFromObjectPath_InCPPTypeObjectPath_Offset;

	private static bool AddArrayNodeFromObjectPath_InPosition_IsValid;

	private static FFieldAddress AddArrayNodeFromObjectPath_InPosition_PropertyAddress;

	private static int AddArrayNodeFromObjectPath_InPosition_Offset;

	private static bool AddArrayNodeFromObjectPath_InNodeName_IsValid;

	private static FFieldAddress AddArrayNodeFromObjectPath_InNodeName_PropertyAddress;

	private static int AddArrayNodeFromObjectPath_InNodeName_Offset;

	private static bool AddArrayNodeFromObjectPath_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddArrayNodeFromObjectPath_bSetupUndoRedo_PropertyAddress;

	private static int AddArrayNodeFromObjectPath_bSetupUndoRedo_Offset;

	private static bool AddArrayNodeFromObjectPath_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddArrayNodeFromObjectPath_bPrintPythonCommand_PropertyAddress;

	private static int AddArrayNodeFromObjectPath_bPrintPythonCommand_Offset;

	private static bool AddArrayNodeFromObjectPath_ReturnValue_IsValid;

	private static FFieldAddress AddArrayNodeFromObjectPath_ReturnValue_PropertyAddress;

	private static int AddArrayNodeFromObjectPath_ReturnValue_Offset;

	private static bool AddArrayNode_IsValid;

	private static IntPtr AddArrayNode_FunctionAddress;

	private static int AddArrayNode_ParamsSize;

	private static bool AddArrayNode_InOpCode_IsValid;

	private static FFieldAddress AddArrayNode_InOpCode_PropertyAddress;

	private static int AddArrayNode_InOpCode_Offset;

	private static bool AddArrayNode_InCPPType_IsValid;

	private static FFieldAddress AddArrayNode_InCPPType_PropertyAddress;

	private static int AddArrayNode_InCPPType_Offset;

	private static bool AddArrayNode_InCPPTypeObject_IsValid;

	private static FFieldAddress AddArrayNode_InCPPTypeObject_PropertyAddress;

	private static int AddArrayNode_InCPPTypeObject_Offset;

	private static bool AddArrayNode_InPosition_IsValid;

	private static FFieldAddress AddArrayNode_InPosition_PropertyAddress;

	private static int AddArrayNode_InPosition_Offset;

	private static bool AddArrayNode_InNodeName_IsValid;

	private static FFieldAddress AddArrayNode_InNodeName_PropertyAddress;

	private static int AddArrayNode_InNodeName_Offset;

	private static bool AddArrayNode_bSetupUndoRedo_IsValid;

	private static FFieldAddress AddArrayNode_bSetupUndoRedo_PropertyAddress;

	private static int AddArrayNode_bSetupUndoRedo_Offset;

	private static bool AddArrayNode_bPrintPythonCommand_IsValid;

	private static FFieldAddress AddArrayNode_bPrintPythonCommand_PropertyAddress;

	private static int AddArrayNode_bPrintPythonCommand_Offset;

	private static bool AddArrayNode_ReturnValue_IsValid;

	private static FFieldAddress AddArrayNode_ReturnValue_PropertyAddress;

	private static int AddArrayNode_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)18014398510006804uL)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:ModifiedEventDynamic")]
	public FRigVMGraphModifiedDynamicEvent ModifiedEvent
	{
		get
		{
			CheckDestroyed();
			if (!ModifiedEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/RigVMDeveloper.RigVMController:ModifiedEventDynamic");
				return new FRigVMGraphModifiedDynamicEvent();
			}
			if (ModifiedEvent_DelegateCached == null)
			{
				ModifiedEvent_DelegateCached = new FRigVMGraphModifiedDynamicEvent();
				ModifiedEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, ModifiedEvent_Offset));
			}
			return ModifiedEvent_DelegateCached;
		}
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:Undo")]
	public unsafe bool Undo()
	{
		CheckDestroyed();
		if (!Undo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:Undo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Undo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Undo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Undo_FunctionAddress, intPtr, Undo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Undo_ReturnValue_Offset), 0, Undo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:UnbindPinFromVariable")]
	public unsafe bool UnbindPinFromVariable(string InPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!UnbindPinFromVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:UnbindPinFromVariable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnbindPinFromVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnbindPinFromVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UnbindPinFromVariable_InPinPath_Offset), 0, UnbindPinFromVariable_InPinPath_PropertyAddress.Address, InPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UnbindPinFromVariable_bSetupUndoRedo_Offset), 0, UnbindPinFromVariable_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UnbindPinFromVariable_bPrintPythonCommand_Offset), 0, UnbindPinFromVariable_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnbindPinFromVariable_FunctionAddress, intPtr, UnbindPinFromVariable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UnbindPinFromVariable_InPinPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, UnbindPinFromVariable_ReturnValue_Offset), 0, UnbindPinFromVariable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetRerouteCompactnessByName")]
	public unsafe bool SetRerouteCompactnessByName(FName InNodeName, bool bShowAsFullNode, bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!SetRerouteCompactnessByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetRerouteCompactnessByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRerouteCompactnessByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRerouteCompactnessByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetRerouteCompactnessByName_InNodeName_Offset), 0, SetRerouteCompactnessByName_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRerouteCompactnessByName_bShowAsFullNode_Offset), 0, SetRerouteCompactnessByName_bShowAsFullNode_PropertyAddress.Address, bShowAsFullNode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRerouteCompactnessByName_bSetupUndoRedo_Offset), 0, SetRerouteCompactnessByName_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRerouteCompactnessByName_FunctionAddress, intPtr, SetRerouteCompactnessByName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetRerouteCompactnessByName_ReturnValue_Offset), 0, SetRerouteCompactnessByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetRerouteCompactness")]
	public unsafe bool SetRerouteCompactness(URigVMNode InNode, bool bShowAsFullNode, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetRerouteCompactness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetRerouteCompactness");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRerouteCompactness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRerouteCompactness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMNode>.ToNative(IntPtr.Add(intPtr, SetRerouteCompactness_InNode_Offset), 0, SetRerouteCompactness_InNode_PropertyAddress.Address, InNode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRerouteCompactness_bShowAsFullNode_Offset), 0, SetRerouteCompactness_bShowAsFullNode_PropertyAddress.Address, bShowAsFullNode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRerouteCompactness_bSetupUndoRedo_Offset), 0, SetRerouteCompactness_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRerouteCompactness_bPrintPythonCommand_Offset), 0, SetRerouteCompactness_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRerouteCompactness_FunctionAddress, intPtr, SetRerouteCompactness_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetRerouteCompactness_ReturnValue_Offset), 0, SetRerouteCompactness_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetRemappedVariable")]
	public unsafe bool SetRemappedVariable(URigVMFunctionReferenceNode InFunctionRefNode, FName InInnerVariableName, FName InOuterVariableName, bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!SetRemappedVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetRemappedVariable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRemappedVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRemappedVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMFunctionReferenceNode>.ToNative(IntPtr.Add(intPtr, SetRemappedVariable_InFunctionRefNode_Offset), 0, SetRemappedVariable_InFunctionRefNode_PropertyAddress.Address, InFunctionRefNode);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetRemappedVariable_InInnerVariableName_Offset), 0, SetRemappedVariable_InInnerVariableName_PropertyAddress.Address, InInnerVariableName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetRemappedVariable_InOuterVariableName_Offset), 0, SetRemappedVariable_InOuterVariableName_PropertyAddress.Address, InOuterVariableName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRemappedVariable_bSetupUndoRedo_Offset), 0, SetRemappedVariable_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRemappedVariable_FunctionAddress, intPtr, SetRemappedVariable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetRemappedVariable_ReturnValue_Offset), 0, SetRemappedVariable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetPinIsWatched")]
	public unsafe bool SetPinIsWatched(string InPinPath, bool bIsWatched, bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!SetPinIsWatched_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetPinIsWatched");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPinIsWatched_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPinIsWatched_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetPinIsWatched_InPinPath_Offset), 0, SetPinIsWatched_InPinPath_PropertyAddress.Address, InPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPinIsWatched_bIsWatched_Offset), 0, SetPinIsWatched_bIsWatched_PropertyAddress.Address, bIsWatched);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPinIsWatched_bSetupUndoRedo_Offset), 0, SetPinIsWatched_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPinIsWatched_FunctionAddress, intPtr, SetPinIsWatched_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPinIsWatched_InPinPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetPinIsWatched_ReturnValue_Offset), 0, SetPinIsWatched_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetPinExpansion")]
	public unsafe bool SetPinExpansion(string InPinPath, bool bIsExpanded, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetPinExpansion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetPinExpansion");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPinExpansion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPinExpansion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetPinExpansion_InPinPath_Offset), 0, SetPinExpansion_InPinPath_PropertyAddress.Address, InPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPinExpansion_bIsExpanded_Offset), 0, SetPinExpansion_bIsExpanded_PropertyAddress.Address, bIsExpanded);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPinExpansion_bSetupUndoRedo_Offset), 0, SetPinExpansion_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPinExpansion_bPrintPythonCommand_Offset), 0, SetPinExpansion_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPinExpansion_FunctionAddress, intPtr, SetPinExpansion_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPinExpansion_InPinPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetPinExpansion_ReturnValue_Offset), 0, SetPinExpansion_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetPinDefaultValue")]
	public unsafe bool SetPinDefaultValue(string InPinPath, string InDefaultValue, bool bResizeArrays = true, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetPinDefaultValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetPinDefaultValue");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPinDefaultValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPinDefaultValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetPinDefaultValue_InPinPath_Offset), 0, SetPinDefaultValue_InPinPath_PropertyAddress.Address, InPinPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetPinDefaultValue_InDefaultValue_Offset), 0, SetPinDefaultValue_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPinDefaultValue_bResizeArrays_Offset), 0, SetPinDefaultValue_bResizeArrays_PropertyAddress.Address, bResizeArrays);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPinDefaultValue_bSetupUndoRedo_Offset), 0, SetPinDefaultValue_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPinDefaultValue_bMergeUndoAction_Offset), 0, SetPinDefaultValue_bMergeUndoAction_PropertyAddress.Address, bMergeUndoAction);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPinDefaultValue_bPrintPythonCommand_Offset), 0, SetPinDefaultValue_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPinDefaultValue_FunctionAddress, intPtr, SetPinDefaultValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPinDefaultValue_InPinPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetPinDefaultValue_InDefaultValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetPinDefaultValue_ReturnValue_Offset), 0, SetPinDefaultValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetNodeSizeByName")]
	public unsafe bool SetNodeSizeByName(FName InNodeName, FVector2D InSize, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetNodeSizeByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetNodeSizeByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeSizeByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeSizeByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNodeSizeByName_InNodeName_Offset), 0, SetNodeSizeByName_InNodeName_PropertyAddress.Address, InNodeName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetNodeSizeByName_InSize_Offset), 0, SetNodeSizeByName_InSize_PropertyAddress.Address, InSize);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeSizeByName_bSetupUndoRedo_Offset), 0, SetNodeSizeByName_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeSizeByName_bMergeUndoAction_Offset), 0, SetNodeSizeByName_bMergeUndoAction_PropertyAddress.Address, bMergeUndoAction);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeSizeByName_bPrintPythonCommand_Offset), 0, SetNodeSizeByName_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodeSizeByName_FunctionAddress, intPtr, SetNodeSizeByName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodeSizeByName_ReturnValue_Offset), 0, SetNodeSizeByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetNodeSize")]
	public unsafe bool SetNodeSize(URigVMNode InNode, FVector2D InSize, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetNodeSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetNodeSize");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMNode>.ToNative(IntPtr.Add(intPtr, SetNodeSize_InNode_Offset), 0, SetNodeSize_InNode_PropertyAddress.Address, InNode);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetNodeSize_InSize_Offset), 0, SetNodeSize_InSize_PropertyAddress.Address, InSize);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeSize_bSetupUndoRedo_Offset), 0, SetNodeSize_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeSize_bMergeUndoAction_Offset), 0, SetNodeSize_bMergeUndoAction_PropertyAddress.Address, bMergeUndoAction);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeSize_bPrintPythonCommand_Offset), 0, SetNodeSize_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodeSize_FunctionAddress, intPtr, SetNodeSize_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodeSize_ReturnValue_Offset), 0, SetNodeSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetNodeSelection")]
	public unsafe bool SetNodeSelection(List<FName> InNodeNames, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetNodeSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetNodeSelection");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FName>(1, SetNodeSelection_InNodeNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, SetNodeSelection_InNodeNames_Offset), InNodeNames);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeSelection_bSetupUndoRedo_Offset), 0, SetNodeSelection_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeSelection_bPrintPythonCommand_Offset), 0, SetNodeSelection_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodeSelection_FunctionAddress, intPtr, SetNodeSelection_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNodeSelection_InNodeNames_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodeSelection_ReturnValue_Offset), 0, SetNodeSelection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetNodePositionByName")]
	public unsafe bool SetNodePositionByName(FName InNodeName, FVector2D InPosition, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetNodePositionByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetNodePositionByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodePositionByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodePositionByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNodePositionByName_InNodeName_Offset), 0, SetNodePositionByName_InNodeName_PropertyAddress.Address, InNodeName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetNodePositionByName_InPosition_Offset), 0, SetNodePositionByName_InPosition_PropertyAddress.Address, InPosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodePositionByName_bSetupUndoRedo_Offset), 0, SetNodePositionByName_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodePositionByName_bMergeUndoAction_Offset), 0, SetNodePositionByName_bMergeUndoAction_PropertyAddress.Address, bMergeUndoAction);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodePositionByName_bPrintPythonCommand_Offset), 0, SetNodePositionByName_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodePositionByName_FunctionAddress, intPtr, SetNodePositionByName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodePositionByName_ReturnValue_Offset), 0, SetNodePositionByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetNodePosition")]
	public unsafe bool SetNodePosition(URigVMNode InNode, FVector2D InPosition, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetNodePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetNodePosition");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMNode>.ToNative(IntPtr.Add(intPtr, SetNodePosition_InNode_Offset), 0, SetNodePosition_InNode_PropertyAddress.Address, InNode);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetNodePosition_InPosition_Offset), 0, SetNodePosition_InPosition_PropertyAddress.Address, InPosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodePosition_bSetupUndoRedo_Offset), 0, SetNodePosition_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodePosition_bMergeUndoAction_Offset), 0, SetNodePosition_bMergeUndoAction_PropertyAddress.Address, bMergeUndoAction);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodePosition_bPrintPythonCommand_Offset), 0, SetNodePosition_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodePosition_FunctionAddress, intPtr, SetNodePosition_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodePosition_ReturnValue_Offset), 0, SetNodePosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetNodeKeywordsByName")]
	public unsafe bool SetNodeKeywordsByName(FName InNodeName, string InKeywords, bool bSetupUndoRedo = true, bool bMergeUndoAction = false)
	{
		CheckDestroyed();
		if (!SetNodeKeywordsByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetNodeKeywordsByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeKeywordsByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeKeywordsByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNodeKeywordsByName_InNodeName_Offset), 0, SetNodeKeywordsByName_InNodeName_PropertyAddress.Address, InNodeName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeKeywordsByName_InKeywords_Offset), 0, SetNodeKeywordsByName_InKeywords_PropertyAddress.Address, InKeywords);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeKeywordsByName_bSetupUndoRedo_Offset), 0, SetNodeKeywordsByName_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeKeywordsByName_bMergeUndoAction_Offset), 0, SetNodeKeywordsByName_bMergeUndoAction_PropertyAddress.Address, bMergeUndoAction);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodeKeywordsByName_FunctionAddress, intPtr, SetNodeKeywordsByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNodeKeywordsByName_InKeywords_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodeKeywordsByName_ReturnValue_Offset), 0, SetNodeKeywordsByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetNodeKeywords")]
	public unsafe bool SetNodeKeywords(URigVMCollapseNode InNode, string InKeywords, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetNodeKeywords_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetNodeKeywords");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeKeywords_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeKeywords_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMCollapseNode>.ToNative(IntPtr.Add(intPtr, SetNodeKeywords_InNode_Offset), 0, SetNodeKeywords_InNode_PropertyAddress.Address, InNode);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeKeywords_InKeywords_Offset), 0, SetNodeKeywords_InKeywords_PropertyAddress.Address, InKeywords);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeKeywords_bSetupUndoRedo_Offset), 0, SetNodeKeywords_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeKeywords_bMergeUndoAction_Offset), 0, SetNodeKeywords_bMergeUndoAction_PropertyAddress.Address, bMergeUndoAction);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeKeywords_bPrintPythonCommand_Offset), 0, SetNodeKeywords_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodeKeywords_FunctionAddress, intPtr, SetNodeKeywords_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNodeKeywords_InKeywords_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodeKeywords_ReturnValue_Offset), 0, SetNodeKeywords_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetNodeDescriptionByName")]
	public unsafe bool SetNodeDescriptionByName(FName InNodeName, string InDescription, bool bSetupUndoRedo = true, bool bMergeUndoAction = false)
	{
		CheckDestroyed();
		if (!SetNodeDescriptionByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetNodeDescriptionByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeDescriptionByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeDescriptionByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNodeDescriptionByName_InNodeName_Offset), 0, SetNodeDescriptionByName_InNodeName_PropertyAddress.Address, InNodeName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeDescriptionByName_InDescription_Offset), 0, SetNodeDescriptionByName_InDescription_PropertyAddress.Address, InDescription);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeDescriptionByName_bSetupUndoRedo_Offset), 0, SetNodeDescriptionByName_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeDescriptionByName_bMergeUndoAction_Offset), 0, SetNodeDescriptionByName_bMergeUndoAction_PropertyAddress.Address, bMergeUndoAction);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodeDescriptionByName_FunctionAddress, intPtr, SetNodeDescriptionByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNodeDescriptionByName_InDescription_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodeDescriptionByName_ReturnValue_Offset), 0, SetNodeDescriptionByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetNodeDescription")]
	public unsafe bool SetNodeDescription(URigVMCollapseNode InNode, string InDescription, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetNodeDescription_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetNodeDescription");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeDescription_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeDescription_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMCollapseNode>.ToNative(IntPtr.Add(intPtr, SetNodeDescription_InNode_Offset), 0, SetNodeDescription_InNode_PropertyAddress.Address, InNode);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeDescription_InDescription_Offset), 0, SetNodeDescription_InDescription_PropertyAddress.Address, InDescription);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeDescription_bSetupUndoRedo_Offset), 0, SetNodeDescription_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeDescription_bMergeUndoAction_Offset), 0, SetNodeDescription_bMergeUndoAction_PropertyAddress.Address, bMergeUndoAction);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeDescription_bPrintPythonCommand_Offset), 0, SetNodeDescription_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodeDescription_FunctionAddress, intPtr, SetNodeDescription_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNodeDescription_InDescription_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodeDescription_ReturnValue_Offset), 0, SetNodeDescription_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetNodeColorByName")]
	public unsafe bool SetNodeColorByName(FName InNodeName, FLinearColor InColor, bool bSetupUndoRedo = true, bool bMergeUndoAction = false)
	{
		CheckDestroyed();
		if (!SetNodeColorByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetNodeColorByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeColorByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeColorByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNodeColorByName_InNodeName_Offset), 0, SetNodeColorByName_InNodeName_PropertyAddress.Address, InNodeName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetNodeColorByName_InColor_Offset), 0, SetNodeColorByName_InColor_PropertyAddress.Address, InColor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeColorByName_bSetupUndoRedo_Offset), 0, SetNodeColorByName_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeColorByName_bMergeUndoAction_Offset), 0, SetNodeColorByName_bMergeUndoAction_PropertyAddress.Address, bMergeUndoAction);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodeColorByName_FunctionAddress, intPtr, SetNodeColorByName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodeColorByName_ReturnValue_Offset), 0, SetNodeColorByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetNodeColor")]
	public unsafe bool SetNodeColor(URigVMNode InNode, FLinearColor InColor, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetNodeColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetNodeColor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMNode>.ToNative(IntPtr.Add(intPtr, SetNodeColor_InNode_Offset), 0, SetNodeColor_InNode_PropertyAddress.Address, InNode);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetNodeColor_InColor_Offset), 0, SetNodeColor_InColor_PropertyAddress.Address, InColor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeColor_bSetupUndoRedo_Offset), 0, SetNodeColor_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeColor_bMergeUndoAction_Offset), 0, SetNodeColor_bMergeUndoAction_PropertyAddress.Address, bMergeUndoAction);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeColor_bPrintPythonCommand_Offset), 0, SetNodeColor_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodeColor_FunctionAddress, intPtr, SetNodeColor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodeColor_ReturnValue_Offset), 0, SetNodeColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetNodeCategoryByName")]
	public unsafe bool SetNodeCategoryByName(FName InNodeName, string InCategory, bool bSetupUndoRedo = true, bool bMergeUndoAction = false)
	{
		CheckDestroyed();
		if (!SetNodeCategoryByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetNodeCategoryByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeCategoryByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeCategoryByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNodeCategoryByName_InNodeName_Offset), 0, SetNodeCategoryByName_InNodeName_PropertyAddress.Address, InNodeName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeCategoryByName_InCategory_Offset), 0, SetNodeCategoryByName_InCategory_PropertyAddress.Address, InCategory);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeCategoryByName_bSetupUndoRedo_Offset), 0, SetNodeCategoryByName_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeCategoryByName_bMergeUndoAction_Offset), 0, SetNodeCategoryByName_bMergeUndoAction_PropertyAddress.Address, bMergeUndoAction);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodeCategoryByName_FunctionAddress, intPtr, SetNodeCategoryByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNodeCategoryByName_InCategory_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodeCategoryByName_ReturnValue_Offset), 0, SetNodeCategoryByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetNodeCategory")]
	public unsafe bool SetNodeCategory(URigVMCollapseNode InNode, string InCategory, bool bSetupUndoRedo = true, bool bMergeUndoAction = false, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetNodeCategory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetNodeCategory");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeCategory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeCategory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMCollapseNode>.ToNative(IntPtr.Add(intPtr, SetNodeCategory_InNode_Offset), 0, SetNodeCategory_InNode_PropertyAddress.Address, InNode);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeCategory_InCategory_Offset), 0, SetNodeCategory_InCategory_PropertyAddress.Address, InCategory);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeCategory_bSetupUndoRedo_Offset), 0, SetNodeCategory_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeCategory_bMergeUndoAction_Offset), 0, SetNodeCategory_bMergeUndoAction_PropertyAddress.Address, bMergeUndoAction);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeCategory_bPrintPythonCommand_Offset), 0, SetNodeCategory_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodeCategory_FunctionAddress, intPtr, SetNodeCategory_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNodeCategory_InCategory_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodeCategory_ReturnValue_Offset), 0, SetNodeCategory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetLocalVariableTypeFromObjectPath")]
	public unsafe bool SetLocalVariableTypeFromObjectPath(FName InVariableName, string InCPPType, string InCPPTypeObjectPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetLocalVariableTypeFromObjectPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetLocalVariableTypeFromObjectPath");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocalVariableTypeFromObjectPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocalVariableTypeFromObjectPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetLocalVariableTypeFromObjectPath_InVariableName_Offset), 0, SetLocalVariableTypeFromObjectPath_InVariableName_PropertyAddress.Address, InVariableName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalVariableTypeFromObjectPath_InCPPType_Offset), 0, SetLocalVariableTypeFromObjectPath_InCPPType_PropertyAddress.Address, InCPPType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalVariableTypeFromObjectPath_InCPPTypeObjectPath_Offset), 0, SetLocalVariableTypeFromObjectPath_InCPPTypeObjectPath_PropertyAddress.Address, InCPPTypeObjectPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalVariableTypeFromObjectPath_bSetupUndoRedo_Offset), 0, SetLocalVariableTypeFromObjectPath_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalVariableTypeFromObjectPath_bPrintPythonCommand_Offset), 0, SetLocalVariableTypeFromObjectPath_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLocalVariableTypeFromObjectPath_FunctionAddress, intPtr, SetLocalVariableTypeFromObjectPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLocalVariableTypeFromObjectPath_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetLocalVariableTypeFromObjectPath_InCPPTypeObjectPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetLocalVariableTypeFromObjectPath_ReturnValue_Offset), 0, SetLocalVariableTypeFromObjectPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetLocalVariableType")]
	public unsafe bool SetLocalVariableType(FName InVariableName, string InCPPType, UObject InCPPTypeObject, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetLocalVariableType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetLocalVariableType");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocalVariableType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocalVariableType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetLocalVariableType_InVariableName_Offset), 0, SetLocalVariableType_InVariableName_PropertyAddress.Address, InVariableName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalVariableType_InCPPType_Offset), 0, SetLocalVariableType_InCPPType_PropertyAddress.Address, InCPPType);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetLocalVariableType_InCPPTypeObject_Offset), 0, SetLocalVariableType_InCPPTypeObject_PropertyAddress.Address, InCPPTypeObject);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalVariableType_bSetupUndoRedo_Offset), 0, SetLocalVariableType_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalVariableType_bPrintPythonCommand_Offset), 0, SetLocalVariableType_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLocalVariableType_FunctionAddress, intPtr, SetLocalVariableType_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLocalVariableType_InCPPType_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetLocalVariableType_ReturnValue_Offset), 0, SetLocalVariableType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetLocalVariableDefaultValue")]
	public unsafe bool SetLocalVariableDefaultValue(FName InVariableName, string InDefaultValue, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false, bool bNotify = true)
	{
		CheckDestroyed();
		if (!SetLocalVariableDefaultValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetLocalVariableDefaultValue");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocalVariableDefaultValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocalVariableDefaultValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetLocalVariableDefaultValue_InVariableName_Offset), 0, SetLocalVariableDefaultValue_InVariableName_PropertyAddress.Address, InVariableName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalVariableDefaultValue_InDefaultValue_Offset), 0, SetLocalVariableDefaultValue_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalVariableDefaultValue_bSetupUndoRedo_Offset), 0, SetLocalVariableDefaultValue_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalVariableDefaultValue_bPrintPythonCommand_Offset), 0, SetLocalVariableDefaultValue_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalVariableDefaultValue_bNotify_Offset), 0, SetLocalVariableDefaultValue_bNotify_PropertyAddress.Address, bNotify);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLocalVariableDefaultValue_FunctionAddress, intPtr, SetLocalVariableDefaultValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLocalVariableDefaultValue_InDefaultValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetLocalVariableDefaultValue_ReturnValue_Offset), 0, SetLocalVariableDefaultValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetIsRunningUnitTest")]
	public unsafe void SetIsRunningUnitTest(bool bIsRunning)
	{
		CheckDestroyed();
		if (!SetIsRunningUnitTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetIsRunningUnitTest");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsRunningUnitTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsRunningUnitTest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsRunningUnitTest_bIsRunning_Offset), 0, SetIsRunningUnitTest_bIsRunning_PropertyAddress.Address, bIsRunning);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsRunningUnitTest_FunctionAddress, intPtr, SetIsRunningUnitTest_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetGraph")]
	public unsafe void SetGraph(URigVMGraph InGraph)
	{
		CheckDestroyed();
		if (!SetGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetGraph");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMGraph>.ToNative(IntPtr.Add(intPtr, SetGraph_InGraph_Offset), 0, SetGraph_InGraph_PropertyAddress.Address, InGraph);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGraph_FunctionAddress, intPtr, SetGraph_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetExposedPinIndex")]
	public unsafe bool SetExposedPinIndex(FName InPinName, int InNewIndex, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetExposedPinIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetExposedPinIndex");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetExposedPinIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetExposedPinIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetExposedPinIndex_InPinName_Offset), 0, SetExposedPinIndex_InPinName_PropertyAddress.Address, InPinName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetExposedPinIndex_InNewIndex_Offset), 0, SetExposedPinIndex_InNewIndex_PropertyAddress.Address, InNewIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetExposedPinIndex_bSetupUndoRedo_Offset), 0, SetExposedPinIndex_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetExposedPinIndex_bPrintPythonCommand_Offset), 0, SetExposedPinIndex_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetExposedPinIndex_FunctionAddress, intPtr, SetExposedPinIndex_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetExposedPinIndex_ReturnValue_Offset), 0, SetExposedPinIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetCommentTextByName")]
	public unsafe bool SetCommentTextByName(FName InNodeName, string InCommentText, int InCommentFontSize, bool bInCommentBubbleVisible, bool bInCommentColorBubble, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetCommentTextByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetCommentTextByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCommentTextByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCommentTextByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetCommentTextByName_InNodeName_Offset), 0, SetCommentTextByName_InNodeName_PropertyAddress.Address, InNodeName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCommentTextByName_InCommentText_Offset), 0, SetCommentTextByName_InCommentText_PropertyAddress.Address, InCommentText);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCommentTextByName_InCommentFontSize_Offset), 0, SetCommentTextByName_InCommentFontSize_PropertyAddress.Address, InCommentFontSize);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCommentTextByName_bInCommentBubbleVisible_Offset), 0, SetCommentTextByName_bInCommentBubbleVisible_PropertyAddress.Address, bInCommentBubbleVisible);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCommentTextByName_bInCommentColorBubble_Offset), 0, SetCommentTextByName_bInCommentColorBubble_PropertyAddress.Address, bInCommentColorBubble);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCommentTextByName_bSetupUndoRedo_Offset), 0, SetCommentTextByName_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCommentTextByName_bPrintPythonCommand_Offset), 0, SetCommentTextByName_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCommentTextByName_FunctionAddress, intPtr, SetCommentTextByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCommentTextByName_InCommentText_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCommentTextByName_ReturnValue_Offset), 0, SetCommentTextByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetCommentText")]
	public unsafe bool SetCommentText(URigVMNode InNode, string InCommentText, int InCommentFontSize, bool bInCommentBubbleVisible, bool bInCommentColorBubble, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetCommentText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetCommentText");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCommentText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCommentText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMNode>.ToNative(IntPtr.Add(intPtr, SetCommentText_InNode_Offset), 0, SetCommentText_InNode_PropertyAddress.Address, InNode);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCommentText_InCommentText_Offset), 0, SetCommentText_InCommentText_PropertyAddress.Address, InCommentText);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCommentText_InCommentFontSize_Offset), 0, SetCommentText_InCommentFontSize_PropertyAddress.Address, InCommentFontSize);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCommentText_bInCommentBubbleVisible_Offset), 0, SetCommentText_bInCommentBubbleVisible_PropertyAddress.Address, bInCommentBubbleVisible);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCommentText_bInCommentColorBubble_Offset), 0, SetCommentText_bInCommentColorBubble_PropertyAddress.Address, bInCommentColorBubble);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCommentText_bSetupUndoRedo_Offset), 0, SetCommentText_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCommentText_bPrintPythonCommand_Offset), 0, SetCommentText_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCommentText_FunctionAddress, intPtr, SetCommentText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCommentText_InCommentText_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCommentText_ReturnValue_Offset), 0, SetCommentText_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SetArrayPinSize")]
	public unsafe bool SetArrayPinSize(string InArrayPinPath, int InSize, string InDefaultValue, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SetArrayPinSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SetArrayPinSize");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetArrayPinSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetArrayPinSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetArrayPinSize_InArrayPinPath_Offset), 0, SetArrayPinSize_InArrayPinPath_PropertyAddress.Address, InArrayPinPath);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetArrayPinSize_InSize_Offset), 0, SetArrayPinSize_InSize_PropertyAddress.Address, InSize);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetArrayPinSize_InDefaultValue_Offset), 0, SetArrayPinSize_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetArrayPinSize_bSetupUndoRedo_Offset), 0, SetArrayPinSize_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetArrayPinSize_bPrintPythonCommand_Offset), 0, SetArrayPinSize_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetArrayPinSize_FunctionAddress, intPtr, SetArrayPinSize_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetArrayPinSize_InArrayPinPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetArrayPinSize_InDefaultValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetArrayPinSize_ReturnValue_Offset), 0, SetArrayPinSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SelectNodeByName")]
	public unsafe bool SelectNodeByName(FName InNodeName, bool bSelect = true, bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!SelectNodeByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SelectNodeByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectNodeByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectNodeByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SelectNodeByName_InNodeName_Offset), 0, SelectNodeByName_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectNodeByName_bSelect_Offset), 0, SelectNodeByName_bSelect_PropertyAddress.Address, bSelect);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectNodeByName_bSetupUndoRedo_Offset), 0, SelectNodeByName_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, SelectNodeByName_FunctionAddress, intPtr, SelectNodeByName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SelectNodeByName_ReturnValue_Offset), 0, SelectNodeByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:SelectNode")]
	public unsafe bool SelectNode(URigVMNode InNode, bool bSelect = true, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!SelectNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:SelectNode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMNode>.ToNative(IntPtr.Add(intPtr, SelectNode_InNode_Offset), 0, SelectNode_InNode_PropertyAddress.Address, InNode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectNode_bSelect_Offset), 0, SelectNode_bSelect_PropertyAddress.Address, bSelect);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectNode_bSetupUndoRedo_Offset), 0, SelectNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectNode_bPrintPythonCommand_Offset), 0, SelectNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, SelectNode_FunctionAddress, intPtr, SelectNode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SelectNode_ReturnValue_Offset), 0, SelectNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:ResetPinDefaultValue")]
	public unsafe bool ResetPinDefaultValue(string InPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!ResetPinDefaultValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:ResetPinDefaultValue");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetPinDefaultValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetPinDefaultValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ResetPinDefaultValue_InPinPath_Offset), 0, ResetPinDefaultValue_InPinPath_PropertyAddress.Address, InPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ResetPinDefaultValue_bSetupUndoRedo_Offset), 0, ResetPinDefaultValue_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ResetPinDefaultValue_bPrintPythonCommand_Offset), 0, ResetPinDefaultValue_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResetPinDefaultValue_FunctionAddress, intPtr, ResetPinDefaultValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ResetPinDefaultValue_InPinPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ResetPinDefaultValue_ReturnValue_Offset), 0, ResetPinDefaultValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:ReplaceParameterNodeWithVariable")]
	public unsafe URigVMVariableNode ReplaceParameterNodeWithVariable(FName InNodeName, FName InVariableName, string InCPPType, UObject InCPPTypeObject, bool bSetupUndoRedo)
	{
		CheckDestroyed();
		if (!ReplaceParameterNodeWithVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:ReplaceParameterNodeWithVariable");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceParameterNodeWithVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceParameterNodeWithVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReplaceParameterNodeWithVariable_InNodeName_Offset), 0, ReplaceParameterNodeWithVariable_InNodeName_PropertyAddress.Address, InNodeName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReplaceParameterNodeWithVariable_InVariableName_Offset), 0, ReplaceParameterNodeWithVariable_InVariableName_PropertyAddress.Address, InVariableName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceParameterNodeWithVariable_InCPPType_Offset), 0, ReplaceParameterNodeWithVariable_InCPPType_PropertyAddress.Address, InCPPType);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReplaceParameterNodeWithVariable_InCPPTypeObject_Offset), 0, ReplaceParameterNodeWithVariable_InCPPTypeObject_PropertyAddress.Address, InCPPTypeObject);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceParameterNodeWithVariable_bSetupUndoRedo_Offset), 0, ReplaceParameterNodeWithVariable_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReplaceParameterNodeWithVariable_FunctionAddress, intPtr, ReplaceParameterNodeWithVariable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceParameterNodeWithVariable_InCPPType_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMVariableNode>.FromNative(IntPtr.Add(intPtr, ReplaceParameterNodeWithVariable_ReturnValue_Offset), 0, ReplaceParameterNodeWithVariable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:RenameVariable")]
	public unsafe bool RenameVariable(FName InOldName, FName InNewName, bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!RenameVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:RenameVariable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameVariable_InOldName_Offset), 0, RenameVariable_InOldName_PropertyAddress.Address, InOldName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameVariable_InNewName_Offset), 0, RenameVariable_InNewName_PropertyAddress.Address, InNewName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RenameVariable_bSetupUndoRedo_Offset), 0, RenameVariable_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenameVariable_FunctionAddress, intPtr, RenameVariable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenameVariable_ReturnValue_Offset), 0, RenameVariable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:RenameParameter")]
	public unsafe bool RenameParameter(FName InOldName, FName InNewName, bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!RenameParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:RenameParameter");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameParameter_InOldName_Offset), 0, RenameParameter_InOldName_PropertyAddress.Address, InOldName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameParameter_InNewName_Offset), 0, RenameParameter_InNewName_PropertyAddress.Address, InNewName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RenameParameter_bSetupUndoRedo_Offset), 0, RenameParameter_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenameParameter_FunctionAddress, intPtr, RenameParameter_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenameParameter_ReturnValue_Offset), 0, RenameParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:RenameNode")]
	public unsafe bool RenameNode(URigVMNode InNode, FName InNewName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!RenameNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:RenameNode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMNode>.ToNative(IntPtr.Add(intPtr, RenameNode_InNode_Offset), 0, RenameNode_InNode_PropertyAddress.Address, InNode);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameNode_InNewName_Offset), 0, RenameNode_InNewName_PropertyAddress.Address, InNewName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RenameNode_bSetupUndoRedo_Offset), 0, RenameNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RenameNode_bPrintPythonCommand_Offset), 0, RenameNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenameNode_FunctionAddress, intPtr, RenameNode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenameNode_ReturnValue_Offset), 0, RenameNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:RenameLocalVariable")]
	public unsafe bool RenameLocalVariable(FName InVariableName, FName InNewVariableName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!RenameLocalVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:RenameLocalVariable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameLocalVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameLocalVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameLocalVariable_InVariableName_Offset), 0, RenameLocalVariable_InVariableName_PropertyAddress.Address, InVariableName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameLocalVariable_InNewVariableName_Offset), 0, RenameLocalVariable_InNewVariableName_PropertyAddress.Address, InNewVariableName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RenameLocalVariable_bSetupUndoRedo_Offset), 0, RenameLocalVariable_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RenameLocalVariable_bPrintPythonCommand_Offset), 0, RenameLocalVariable_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenameLocalVariable_FunctionAddress, intPtr, RenameLocalVariable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenameLocalVariable_ReturnValue_Offset), 0, RenameLocalVariable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:RenameFunction")]
	public unsafe bool RenameFunction(FName InOldFunctionName, FName InNewFunctionName, bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!RenameFunction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:RenameFunction");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameFunction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameFunction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameFunction_InOldFunctionName_Offset), 0, RenameFunction_InOldFunctionName_PropertyAddress.Address, InOldFunctionName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameFunction_InNewFunctionName_Offset), 0, RenameFunction_InNewFunctionName_PropertyAddress.Address, InNewFunctionName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RenameFunction_bSetupUndoRedo_Offset), 0, RenameFunction_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenameFunction_FunctionAddress, intPtr, RenameFunction_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenameFunction_ReturnValue_Offset), 0, RenameFunction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:RenameExposedPin")]
	public unsafe bool RenameExposedPin(FName InOldPinName, FName InNewPinName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!RenameExposedPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:RenameExposedPin");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameExposedPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameExposedPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameExposedPin_InOldPinName_Offset), 0, RenameExposedPin_InOldPinName_PropertyAddress.Address, InOldPinName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RenameExposedPin_InNewPinName_Offset), 0, RenameExposedPin_InNewPinName_PropertyAddress.Address, InNewPinName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RenameExposedPin_bSetupUndoRedo_Offset), 0, RenameExposedPin_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RenameExposedPin_bPrintPythonCommand_Offset), 0, RenameExposedPin_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenameExposedPin_FunctionAddress, intPtr, RenameExposedPin_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenameExposedPin_ReturnValue_Offset), 0, RenameExposedPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:RemoveNodeByName")]
	public unsafe bool RemoveNodeByName(FName InNodeName, bool bSetupUndoRedo = true, bool bRecursive = false, bool bPrintPythonCommand = false, bool bRelinkPins = false)
	{
		CheckDestroyed();
		if (!RemoveNodeByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:RemoveNodeByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveNodeByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveNodeByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveNodeByName_InNodeName_Offset), 0, RemoveNodeByName_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveNodeByName_bSetupUndoRedo_Offset), 0, RemoveNodeByName_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveNodeByName_bRecursive_Offset), 0, RemoveNodeByName_bRecursive_PropertyAddress.Address, bRecursive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveNodeByName_bPrintPythonCommand_Offset), 0, RemoveNodeByName_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveNodeByName_bRelinkPins_Offset), 0, RemoveNodeByName_bRelinkPins_PropertyAddress.Address, bRelinkPins);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveNodeByName_FunctionAddress, intPtr, RemoveNodeByName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveNodeByName_ReturnValue_Offset), 0, RemoveNodeByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:RemoveNode")]
	public unsafe bool RemoveNode(URigVMNode InNode, bool bSetupUndoRedo = true, bool bRecursive = false, bool bPrintPythonCommand = false, bool bRelinkPins = false)
	{
		CheckDestroyed();
		if (!RemoveNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:RemoveNode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMNode>.ToNative(IntPtr.Add(intPtr, RemoveNode_InNode_Offset), 0, RemoveNode_InNode_PropertyAddress.Address, InNode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveNode_bSetupUndoRedo_Offset), 0, RemoveNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveNode_bRecursive_Offset), 0, RemoveNode_bRecursive_PropertyAddress.Address, bRecursive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveNode_bPrintPythonCommand_Offset), 0, RemoveNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveNode_bRelinkPins_Offset), 0, RemoveNode_bRelinkPins_PropertyAddress.Address, bRelinkPins);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveNode_FunctionAddress, intPtr, RemoveNode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveNode_ReturnValue_Offset), 0, RemoveNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:RemoveLocalVariable")]
	public unsafe bool RemoveLocalVariable(FName InVariableName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!RemoveLocalVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:RemoveLocalVariable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveLocalVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveLocalVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveLocalVariable_InVariableName_Offset), 0, RemoveLocalVariable_InVariableName_PropertyAddress.Address, InVariableName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveLocalVariable_bSetupUndoRedo_Offset), 0, RemoveLocalVariable_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveLocalVariable_bPrintPythonCommand_Offset), 0, RemoveLocalVariable_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveLocalVariable_FunctionAddress, intPtr, RemoveLocalVariable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveLocalVariable_ReturnValue_Offset), 0, RemoveLocalVariable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:RemoveInjectedNode")]
	public unsafe bool RemoveInjectedNode(string InPinPath, bool bAsInput, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!RemoveInjectedNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:RemoveInjectedNode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveInjectedNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveInjectedNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveInjectedNode_InPinPath_Offset), 0, RemoveInjectedNode_InPinPath_PropertyAddress.Address, InPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveInjectedNode_bAsInput_Offset), 0, RemoveInjectedNode_bAsInput_PropertyAddress.Address, bAsInput);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveInjectedNode_bSetupUndoRedo_Offset), 0, RemoveInjectedNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveInjectedNode_bPrintPythonCommand_Offset), 0, RemoveInjectedNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveInjectedNode_FunctionAddress, intPtr, RemoveInjectedNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveInjectedNode_InPinPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveInjectedNode_ReturnValue_Offset), 0, RemoveInjectedNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:RemoveFunctionFromLibrary")]
	public unsafe bool RemoveFunctionFromLibrary(FName InFunctionName, bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!RemoveFunctionFromLibrary_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:RemoveFunctionFromLibrary");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveFunctionFromLibrary_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveFunctionFromLibrary_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveFunctionFromLibrary_InFunctionName_Offset), 0, RemoveFunctionFromLibrary_InFunctionName_PropertyAddress.Address, InFunctionName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveFunctionFromLibrary_bSetupUndoRedo_Offset), 0, RemoveFunctionFromLibrary_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveFunctionFromLibrary_FunctionAddress, intPtr, RemoveFunctionFromLibrary_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveFunctionFromLibrary_ReturnValue_Offset), 0, RemoveFunctionFromLibrary_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:RemoveExposedPin")]
	public unsafe bool RemoveExposedPin(FName InPinName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!RemoveExposedPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:RemoveExposedPin");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveExposedPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveExposedPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveExposedPin_InPinName_Offset), 0, RemoveExposedPin_InPinName_PropertyAddress.Address, InPinName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveExposedPin_bSetupUndoRedo_Offset), 0, RemoveExposedPin_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveExposedPin_bPrintPythonCommand_Offset), 0, RemoveExposedPin_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveExposedPin_FunctionAddress, intPtr, RemoveExposedPin_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveExposedPin_ReturnValue_Offset), 0, RemoveExposedPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:RemoveArrayPin")]
	public unsafe bool RemoveArrayPin(string InArrayElementPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!RemoveArrayPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:RemoveArrayPin");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveArrayPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveArrayPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveArrayPin_InArrayElementPinPath_Offset), 0, RemoveArrayPin_InArrayElementPinPath_PropertyAddress.Address, InArrayElementPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveArrayPin_bSetupUndoRedo_Offset), 0, RemoveArrayPin_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveArrayPin_bPrintPythonCommand_Offset), 0, RemoveArrayPin_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveArrayPin_FunctionAddress, intPtr, RemoveArrayPin_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveArrayPin_InArrayElementPinPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveArrayPin_ReturnValue_Offset), 0, RemoveArrayPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:RefreshVariableNode")]
	public unsafe void RefreshVariableNode(FName InNodeName, FName InVariableName, string InCPPType, UObject InCPPTypeObject, bool bSetupUndoRedo, bool bSetupOrphanPins = true)
	{
		CheckDestroyed();
		if (!RefreshVariableNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:RefreshVariableNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshVariableNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshVariableNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RefreshVariableNode_InNodeName_Offset), 0, RefreshVariableNode_InNodeName_PropertyAddress.Address, InNodeName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RefreshVariableNode_InVariableName_Offset), 0, RefreshVariableNode_InVariableName_PropertyAddress.Address, InVariableName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RefreshVariableNode_InCPPType_Offset), 0, RefreshVariableNode_InCPPType_PropertyAddress.Address, InCPPType);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RefreshVariableNode_InCPPTypeObject_Offset), 0, RefreshVariableNode_InCPPTypeObject_PropertyAddress.Address, InCPPTypeObject);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RefreshVariableNode_bSetupUndoRedo_Offset), 0, RefreshVariableNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RefreshVariableNode_bSetupOrphanPins_Offset), 0, RefreshVariableNode_bSetupOrphanPins_PropertyAddress.Address, bSetupOrphanPins);
		NativeReflection.InvokeFunctionOptimized(base.Address, RefreshVariableNode_FunctionAddress, intPtr, RefreshVariableNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RefreshVariableNode_InCPPType_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:Redo")]
	public unsafe bool Redo()
	{
		CheckDestroyed();
		if (!Redo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:Redo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Redo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Redo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Redo_FunctionAddress, intPtr, Redo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Redo_ReturnValue_Offset), 0, Redo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:PushGraph")]
	public unsafe void PushGraph(URigVMGraph InGraph, bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!PushGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:PushGraph");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PushGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PushGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMGraph>.ToNative(IntPtr.Add(intPtr, PushGraph_InGraph_Offset), 0, PushGraph_InGraph_PropertyAddress.Address, InGraph);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PushGraph_bSetupUndoRedo_Offset), 0, PushGraph_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, PushGraph_FunctionAddress, intPtr, PushGraph_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:PromotePinToVariable")]
	public unsafe bool PromotePinToVariable(string InPinPath, bool bCreateVariableNode, FVector2D InNodePosition, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!PromotePinToVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:PromotePinToVariable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PromotePinToVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PromotePinToVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PromotePinToVariable_InPinPath_Offset), 0, PromotePinToVariable_InPinPath_PropertyAddress.Address, InPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PromotePinToVariable_bCreateVariableNode_Offset), 0, PromotePinToVariable_bCreateVariableNode_PropertyAddress.Address, bCreateVariableNode);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, PromotePinToVariable_InNodePosition_Offset), 0, PromotePinToVariable_InNodePosition_PropertyAddress.Address, InNodePosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PromotePinToVariable_bSetupUndoRedo_Offset), 0, PromotePinToVariable_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PromotePinToVariable_bPrintPythonCommand_Offset), 0, PromotePinToVariable_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, PromotePinToVariable_FunctionAddress, intPtr, PromotePinToVariable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PromotePinToVariable_InPinPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PromotePinToVariable_ReturnValue_Offset), 0, PromotePinToVariable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:PromoteFunctionReferenceNodeToCollapseNode")]
	public unsafe FName PromoteFunctionReferenceNodeToCollapseNode(FName InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false, bool bRemoveFunctionDefinition = false)
	{
		CheckDestroyed();
		if (!PromoteFunctionReferenceNodeToCollapseNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:PromoteFunctionReferenceNodeToCollapseNode");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(PromoteFunctionReferenceNodeToCollapseNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PromoteFunctionReferenceNodeToCollapseNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PromoteFunctionReferenceNodeToCollapseNode_InNodeName_Offset), 0, PromoteFunctionReferenceNodeToCollapseNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PromoteFunctionReferenceNodeToCollapseNode_bSetupUndoRedo_Offset), 0, PromoteFunctionReferenceNodeToCollapseNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PromoteFunctionReferenceNodeToCollapseNode_bPrintPythonCommand_Offset), 0, PromoteFunctionReferenceNodeToCollapseNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PromoteFunctionReferenceNodeToCollapseNode_bRemoveFunctionDefinition_Offset), 0, PromoteFunctionReferenceNodeToCollapseNode_bRemoveFunctionDefinition_PropertyAddress.Address, bRemoveFunctionDefinition);
		NativeReflection.InvokeFunctionOptimized(base.Address, PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, intPtr, PromoteFunctionReferenceNodeToCollapseNode_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, PromoteFunctionReferenceNodeToCollapseNode_ReturnValue_Offset), 0, PromoteFunctionReferenceNodeToCollapseNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:PromoteCollapseNodeToFunctionReferenceNode")]
	public unsafe FName PromoteCollapseNodeToFunctionReferenceNode(FName InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false, string InExistingFunctionDefinitionPath = null)
	{
		CheckDestroyed();
		if (!PromoteCollapseNodeToFunctionReferenceNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:PromoteCollapseNodeToFunctionReferenceNode");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(PromoteCollapseNodeToFunctionReferenceNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PromoteCollapseNodeToFunctionReferenceNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PromoteCollapseNodeToFunctionReferenceNode_InNodeName_Offset), 0, PromoteCollapseNodeToFunctionReferenceNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PromoteCollapseNodeToFunctionReferenceNode_bSetupUndoRedo_Offset), 0, PromoteCollapseNodeToFunctionReferenceNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PromoteCollapseNodeToFunctionReferenceNode_bPrintPythonCommand_Offset), 0, PromoteCollapseNodeToFunctionReferenceNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PromoteCollapseNodeToFunctionReferenceNode_InExistingFunctionDefinitionPath_Offset), 0, PromoteCollapseNodeToFunctionReferenceNode_InExistingFunctionDefinitionPath_PropertyAddress.Address, InExistingFunctionDefinitionPath);
		NativeReflection.InvokeFunctionOptimized(base.Address, PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, intPtr, PromoteCollapseNodeToFunctionReferenceNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PromoteCollapseNodeToFunctionReferenceNode_InExistingFunctionDefinitionPath_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, PromoteCollapseNodeToFunctionReferenceNode_ReturnValue_Offset), 0, PromoteCollapseNodeToFunctionReferenceNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:PopGraph")]
	public unsafe URigVMGraph PopGraph(bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!PopGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:PopGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PopGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PopGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PopGraph_bSetupUndoRedo_Offset), 0, PopGraph_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, PopGraph_FunctionAddress, intPtr, PopGraph_ParamsSize);
		return UObjectMarshaler<URigVMGraph>.FromNative(IntPtr.Add(intPtr, PopGraph_ReturnValue_Offset), 0, PopGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:OpenUndoBracket")]
	public unsafe bool OpenUndoBracket(string InTitle)
	{
		CheckDestroyed();
		if (!OpenUndoBracket_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:OpenUndoBracket");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenUndoBracket_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenUndoBracket_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenUndoBracket_InTitle_Offset), 0, OpenUndoBracket_InTitle_PropertyAddress.Address, InTitle);
		NativeReflection.InvokeFunctionOptimized(base.Address, OpenUndoBracket_FunctionAddress, intPtr, OpenUndoBracket_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OpenUndoBracket_InTitle_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenUndoBracket_ReturnValue_Offset), 0, OpenUndoBracket_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:OnExternalVariableTypeChangedFromObjectPath")]
	public unsafe void OnExternalVariableTypeChangedFromObjectPath(FName InVarName, string InCPPType, string InCPPTypeObjectPath, bool bSetupUndoRedo)
	{
		CheckDestroyed();
		if (!OnExternalVariableTypeChangedFromObjectPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:OnExternalVariableTypeChangedFromObjectPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnExternalVariableTypeChangedFromObjectPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnExternalVariableTypeChangedFromObjectPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnExternalVariableTypeChangedFromObjectPath_InVarName_Offset), 0, OnExternalVariableTypeChangedFromObjectPath_InVarName_PropertyAddress.Address, InVarName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnExternalVariableTypeChangedFromObjectPath_InCPPType_Offset), 0, OnExternalVariableTypeChangedFromObjectPath_InCPPType_PropertyAddress.Address, InCPPType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnExternalVariableTypeChangedFromObjectPath_InCPPTypeObjectPath_Offset), 0, OnExternalVariableTypeChangedFromObjectPath_InCPPTypeObjectPath_PropertyAddress.Address, InCPPTypeObjectPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnExternalVariableTypeChangedFromObjectPath_bSetupUndoRedo_Offset), 0, OnExternalVariableTypeChangedFromObjectPath_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnExternalVariableTypeChangedFromObjectPath_FunctionAddress, intPtr, OnExternalVariableTypeChangedFromObjectPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnExternalVariableTypeChangedFromObjectPath_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnExternalVariableTypeChangedFromObjectPath_InCPPTypeObjectPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:OnExternalVariableTypeChanged")]
	public unsafe void OnExternalVariableTypeChanged(FName InVarName, string InCPPType, UObject InCPPTypeObject, bool bSetupUndoRedo)
	{
		CheckDestroyed();
		if (!OnExternalVariableTypeChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:OnExternalVariableTypeChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnExternalVariableTypeChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnExternalVariableTypeChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnExternalVariableTypeChanged_InVarName_Offset), 0, OnExternalVariableTypeChanged_InVarName_PropertyAddress.Address, InVarName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnExternalVariableTypeChanged_InCPPType_Offset), 0, OnExternalVariableTypeChanged_InCPPType_PropertyAddress.Address, InCPPType);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnExternalVariableTypeChanged_InCPPTypeObject_Offset), 0, OnExternalVariableTypeChanged_InCPPTypeObject_PropertyAddress.Address, InCPPTypeObject);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnExternalVariableTypeChanged_bSetupUndoRedo_Offset), 0, OnExternalVariableTypeChanged_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnExternalVariableTypeChanged_FunctionAddress, intPtr, OnExternalVariableTypeChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnExternalVariableTypeChanged_InCPPType_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:OnExternalVariableRenamed")]
	public unsafe void OnExternalVariableRenamed(FName InOldVarName, FName InNewVarName, bool bSetupUndoRedo)
	{
		CheckDestroyed();
		if (!OnExternalVariableRenamed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:OnExternalVariableRenamed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnExternalVariableRenamed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnExternalVariableRenamed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnExternalVariableRenamed_InOldVarName_Offset), 0, OnExternalVariableRenamed_InOldVarName_PropertyAddress.Address, InOldVarName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnExternalVariableRenamed_InNewVarName_Offset), 0, OnExternalVariableRenamed_InNewVarName_PropertyAddress.Address, InNewVarName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnExternalVariableRenamed_bSetupUndoRedo_Offset), 0, OnExternalVariableRenamed_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnExternalVariableRenamed_FunctionAddress, intPtr, OnExternalVariableRenamed_ParamsSize);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:OnExternalVariableRemoved")]
	public unsafe void OnExternalVariableRemoved(FName InVarName, bool bSetupUndoRedo)
	{
		CheckDestroyed();
		if (!OnExternalVariableRemoved_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:OnExternalVariableRemoved");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnExternalVariableRemoved_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnExternalVariableRemoved_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, OnExternalVariableRemoved_InVarName_Offset), 0, OnExternalVariableRemoved_InVarName_PropertyAddress.Address, InVarName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnExternalVariableRemoved_bSetupUndoRedo_Offset), 0, OnExternalVariableRemoved_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnExternalVariableRemoved_FunctionAddress, intPtr, OnExternalVariableRemoved_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:MakeVariableNodeFromBinding")]
	public unsafe bool MakeVariableNodeFromBinding(string InPinPath, FVector2D InNodePosition, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!MakeVariableNodeFromBinding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:MakeVariableNodeFromBinding");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeVariableNodeFromBinding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeVariableNodeFromBinding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MakeVariableNodeFromBinding_InPinPath_Offset), 0, MakeVariableNodeFromBinding_InPinPath_PropertyAddress.Address, InPinPath);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, MakeVariableNodeFromBinding_InNodePosition_Offset), 0, MakeVariableNodeFromBinding_InNodePosition_PropertyAddress.Address, InNodePosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MakeVariableNodeFromBinding_bSetupUndoRedo_Offset), 0, MakeVariableNodeFromBinding_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MakeVariableNodeFromBinding_bPrintPythonCommand_Offset), 0, MakeVariableNodeFromBinding_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, MakeVariableNodeFromBinding_FunctionAddress, intPtr, MakeVariableNodeFromBinding_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MakeVariableNodeFromBinding_InPinPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MakeVariableNodeFromBinding_ReturnValue_Offset), 0, MakeVariableNodeFromBinding_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:MakeBindingsFromVariableNode")]
	public unsafe bool MakeBindingsFromVariableNode(FName InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!MakeBindingsFromVariableNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:MakeBindingsFromVariableNode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeBindingsFromVariableNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeBindingsFromVariableNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, MakeBindingsFromVariableNode_InNodeName_Offset), 0, MakeBindingsFromVariableNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MakeBindingsFromVariableNode_bSetupUndoRedo_Offset), 0, MakeBindingsFromVariableNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MakeBindingsFromVariableNode_bPrintPythonCommand_Offset), 0, MakeBindingsFromVariableNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, MakeBindingsFromVariableNode_FunctionAddress, intPtr, MakeBindingsFromVariableNode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MakeBindingsFromVariableNode_ReturnValue_Offset), 0, MakeBindingsFromVariableNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:LocalizeFunctions")]
	public unsafe Dictionary<URigVMLibraryNode, URigVMLibraryNode> LocalizeFunctions(List<URigVMLibraryNode> InFunctionDefinitions, bool bLocalizeDependentPrivateFunctions = true, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!LocalizeFunctions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:LocalizeFunctions");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LocalizeFunctions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LocalizeFunctions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<URigVMLibraryNode>(1, LocalizeFunctions_InFunctionDefinitions_PropertyAddress, CachedMarshalingDelegates<URigVMLibraryNode, UObjectMarshaler<URigVMLibraryNode>>.FromNative, CachedMarshalingDelegates<URigVMLibraryNode, UObjectMarshaler<URigVMLibraryNode>>.ToNative).ToNative(IntPtr.Add(intPtr, LocalizeFunctions_InFunctionDefinitions_Offset), InFunctionDefinitions);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LocalizeFunctions_bLocalizeDependentPrivateFunctions_Offset), 0, LocalizeFunctions_bLocalizeDependentPrivateFunctions_PropertyAddress.Address, bLocalizeDependentPrivateFunctions);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LocalizeFunctions_bSetupUndoRedo_Offset), 0, LocalizeFunctions_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LocalizeFunctions_bPrintPythonCommand_Offset), 0, LocalizeFunctions_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, LocalizeFunctions_FunctionAddress, intPtr, LocalizeFunctions_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LocalizeFunctions_InFunctionDefinitions_PropertyAddress.Address, intPtr);
		Dictionary<URigVMLibraryNode, URigVMLibraryNode> result = new TMapCopyMarshaler<URigVMLibraryNode, URigVMLibraryNode>(1, LocalizeFunctions_ReturnValue_PropertyAddress, CachedMarshalingDelegates<URigVMLibraryNode, UObjectMarshaler<URigVMLibraryNode>>.FromNative, CachedMarshalingDelegates<URigVMLibraryNode, UObjectMarshaler<URigVMLibraryNode>>.ToNative, CachedMarshalingDelegates<URigVMLibraryNode, UObjectMarshaler<URigVMLibraryNode>>.FromNative, CachedMarshalingDelegates<URigVMLibraryNode, UObjectMarshaler<URigVMLibraryNode>>.ToNative).FromNative(IntPtr.Add(intPtr, LocalizeFunctions_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(LocalizeFunctions_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:LocalizeFunction")]
	public unsafe URigVMLibraryNode LocalizeFunction(URigVMLibraryNode InFunctionDefinition, bool bLocalizeDependentPrivateFunctions = true, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!LocalizeFunction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:LocalizeFunction");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LocalizeFunction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LocalizeFunction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMLibraryNode>.ToNative(IntPtr.Add(intPtr, LocalizeFunction_InFunctionDefinition_Offset), 0, LocalizeFunction_InFunctionDefinition_PropertyAddress.Address, InFunctionDefinition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LocalizeFunction_bLocalizeDependentPrivateFunctions_Offset), 0, LocalizeFunction_bLocalizeDependentPrivateFunctions_PropertyAddress.Address, bLocalizeDependentPrivateFunctions);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LocalizeFunction_bSetupUndoRedo_Offset), 0, LocalizeFunction_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LocalizeFunction_bPrintPythonCommand_Offset), 0, LocalizeFunction_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, LocalizeFunction_FunctionAddress, intPtr, LocalizeFunction_ParamsSize);
		return UObjectMarshaler<URigVMLibraryNode>.FromNative(IntPtr.Add(intPtr, LocalizeFunction_ReturnValue_Offset), 0, LocalizeFunction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:IsReportingEnabled")]
	public unsafe bool IsReportingEnabled()
	{
		CheckDestroyed();
		if (!IsReportingEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:IsReportingEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsReportingEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsReportingEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsReportingEnabled_FunctionAddress, intPtr, IsReportingEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsReportingEnabled_ReturnValue_Offset), 0, IsReportingEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:InsertArrayPin")]
	public unsafe string InsertArrayPin(string InArrayPinPath, int InIndex = -1, string InDefaultValue = null, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!InsertArrayPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:InsertArrayPin");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InsertArrayPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InsertArrayPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InsertArrayPin_InArrayPinPath_Offset), 0, InsertArrayPin_InArrayPinPath_PropertyAddress.Address, InArrayPinPath);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InsertArrayPin_InIndex_Offset), 0, InsertArrayPin_InIndex_PropertyAddress.Address, InIndex);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InsertArrayPin_InDefaultValue_Offset), 0, InsertArrayPin_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, InsertArrayPin_bSetupUndoRedo_Offset), 0, InsertArrayPin_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, InsertArrayPin_bPrintPythonCommand_Offset), 0, InsertArrayPin_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, InsertArrayPin_FunctionAddress, intPtr, InsertArrayPin_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InsertArrayPin_InArrayPinPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InsertArrayPin_InDefaultValue_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, InsertArrayPin_ReturnValue_Offset), 0, InsertArrayPin_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(InsertArrayPin_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:ImportNodesFromText")]
	public unsafe List<FName> ImportNodesFromText(string InText, bool bSetupUndoRedo = true, bool bPrintPythonCommands = false)
	{
		CheckDestroyed();
		if (!ImportNodesFromText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:ImportNodesFromText");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportNodesFromText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportNodesFromText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportNodesFromText_InText_Offset), 0, ImportNodesFromText_InText_PropertyAddress.Address, InText);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportNodesFromText_bSetupUndoRedo_Offset), 0, ImportNodesFromText_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ImportNodesFromText_bPrintPythonCommands_Offset), 0, ImportNodesFromText_bPrintPythonCommands_PropertyAddress.Address, bPrintPythonCommands);
		NativeReflection.InvokeFunctionOptimized(base.Address, ImportNodesFromText_FunctionAddress, intPtr, ImportNodesFromText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportNodesFromText_InText_PropertyAddress.Address, intPtr);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, ImportNodesFromText_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, ImportNodesFromText_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ImportNodesFromText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:GetTopLevelGraph")]
	public unsafe URigVMGraph GetTopLevelGraph()
	{
		CheckDestroyed();
		if (!GetTopLevelGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:GetTopLevelGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTopLevelGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTopLevelGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTopLevelGraph_FunctionAddress, intPtr, GetTopLevelGraph_ParamsSize);
		return UObjectMarshaler<URigVMGraph>.FromNative(IntPtr.Add(intPtr, GetTopLevelGraph_ReturnValue_Offset), 0, GetTopLevelGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:GetPinDefaultValue")]
	public unsafe string GetPinDefaultValue(string InPinPath)
	{
		CheckDestroyed();
		if (!GetPinDefaultValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:GetPinDefaultValue");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPinDefaultValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPinDefaultValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetPinDefaultValue_InPinPath_Offset), 0, GetPinDefaultValue_InPinPath_PropertyAddress.Address, InPinPath);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPinDefaultValue_FunctionAddress, intPtr, GetPinDefaultValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPinDefaultValue_InPinPath_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetPinDefaultValue_ReturnValue_Offset), 0, GetPinDefaultValue_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPinDefaultValue_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:GetGraph")]
	public unsafe URigVMGraph GetGraph()
	{
		CheckDestroyed();
		if (!GetGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:GetGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGraph_FunctionAddress, intPtr, GetGraph_ParamsSize);
		return UObjectMarshaler<URigVMGraph>.FromNative(IntPtr.Add(intPtr, GetGraph_ReturnValue_Offset), 0, GetGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:GeneratePythonCommands")]
	public unsafe List<string> GeneratePythonCommands()
	{
		CheckDestroyed();
		if (!GeneratePythonCommands_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:GeneratePythonCommands");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GeneratePythonCommands_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GeneratePythonCommands_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GeneratePythonCommands_FunctionAddress, intPtr, GeneratePythonCommands_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GeneratePythonCommands_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GeneratePythonCommands_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GeneratePythonCommands_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:ExportSelectedNodesToText")]
	public unsafe string ExportSelectedNodesToText()
	{
		CheckDestroyed();
		if (!ExportSelectedNodesToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:ExportSelectedNodesToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportSelectedNodesToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportSelectedNodesToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExportSelectedNodesToText_FunctionAddress, intPtr, ExportSelectedNodesToText_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ExportSelectedNodesToText_ReturnValue_Offset), 0, ExportSelectedNodesToText_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExportSelectedNodesToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:ExportNodesToText")]
	public unsafe string ExportNodesToText(List<FName> InNodeNames)
	{
		CheckDestroyed();
		if (!ExportNodesToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:ExportNodesToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportNodesToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportNodesToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FName>(1, ExportNodesToText_InNodeNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, ExportNodesToText_InNodeNames_Offset), InNodeNames);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExportNodesToText_FunctionAddress, intPtr, ExportNodesToText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportNodesToText_InNodeNames_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ExportNodesToText_ReturnValue_Offset), 0, ExportNodesToText_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExportNodesToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:ExpandLibraryNode")]
	public unsafe List<URigVMNode> ExpandLibraryNode(FName InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!ExpandLibraryNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:ExpandLibraryNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExpandLibraryNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExpandLibraryNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ExpandLibraryNode_InNodeName_Offset), 0, ExpandLibraryNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ExpandLibraryNode_bSetupUndoRedo_Offset), 0, ExpandLibraryNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ExpandLibraryNode_bPrintPythonCommand_Offset), 0, ExpandLibraryNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExpandLibraryNode_FunctionAddress, intPtr, ExpandLibraryNode_ParamsSize);
		List<URigVMNode> result = new TArrayCopyMarshaler<URigVMNode>(1, ExpandLibraryNode_ReturnValue_PropertyAddress, CachedMarshalingDelegates<URigVMNode, UObjectMarshaler<URigVMNode>>.FromNative, CachedMarshalingDelegates<URigVMNode, UObjectMarshaler<URigVMNode>>.ToNative).FromNative(IntPtr.Add(intPtr, ExpandLibraryNode_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ExpandLibraryNode_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:EnableReporting")]
	public unsafe void EnableReporting(bool bEnabled = true)
	{
		CheckDestroyed();
		if (!EnableReporting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:EnableReporting");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableReporting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableReporting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableReporting_bEnabled_Offset), 0, EnableReporting_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, EnableReporting_FunctionAddress, intPtr, EnableReporting_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:EjectNodeFromPin")]
	public unsafe URigVMNode EjectNodeFromPin(string InPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!EjectNodeFromPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:EjectNodeFromPin");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EjectNodeFromPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EjectNodeFromPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EjectNodeFromPin_InPinPath_Offset), 0, EjectNodeFromPin_InPinPath_PropertyAddress.Address, InPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EjectNodeFromPin_bSetupUndoRedo_Offset), 0, EjectNodeFromPin_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EjectNodeFromPin_bPrintPythonCommand_Offset), 0, EjectNodeFromPin_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, EjectNodeFromPin_FunctionAddress, intPtr, EjectNodeFromPin_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EjectNodeFromPin_InPinPath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMNode>.FromNative(IntPtr.Add(intPtr, EjectNodeFromPin_ReturnValue_Offset), 0, EjectNodeFromPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:DuplicateArrayPin")]
	public unsafe string DuplicateArrayPin(string InArrayElementPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!DuplicateArrayPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:DuplicateArrayPin");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateArrayPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateArrayPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateArrayPin_InArrayElementPinPath_Offset), 0, DuplicateArrayPin_InArrayElementPinPath_PropertyAddress.Address, InArrayElementPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateArrayPin_bSetupUndoRedo_Offset), 0, DuplicateArrayPin_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateArrayPin_bPrintPythonCommand_Offset), 0, DuplicateArrayPin_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, DuplicateArrayPin_FunctionAddress, intPtr, DuplicateArrayPin_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateArrayPin_InArrayElementPinPath_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, DuplicateArrayPin_ReturnValue_Offset), 0, DuplicateArrayPin_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(DuplicateArrayPin_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:CollapseNodes")]
	public unsafe URigVMCollapseNode CollapseNodes(List<FName> InNodeNames, string InCollapseNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!CollapseNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:CollapseNodes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CollapseNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CollapseNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FName>(1, CollapseNodes_InNodeNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, CollapseNodes_InNodeNames_Offset), InNodeNames);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CollapseNodes_InCollapseNodeName_Offset), 0, CollapseNodes_InCollapseNodeName_PropertyAddress.Address, InCollapseNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CollapseNodes_bSetupUndoRedo_Offset), 0, CollapseNodes_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CollapseNodes_bPrintPythonCommand_Offset), 0, CollapseNodes_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, CollapseNodes_FunctionAddress, intPtr, CollapseNodes_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CollapseNodes_InNodeNames_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CollapseNodes_InCollapseNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMCollapseNode>.FromNative(IntPtr.Add(intPtr, CollapseNodes_ReturnValue_Offset), 0, CollapseNodes_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:CloseUndoBracket")]
	public unsafe bool CloseUndoBracket()
	{
		CheckDestroyed();
		if (!CloseUndoBracket_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:CloseUndoBracket");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloseUndoBracket_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseUndoBracket_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CloseUndoBracket_FunctionAddress, intPtr, CloseUndoBracket_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CloseUndoBracket_ReturnValue_Offset), 0, CloseUndoBracket_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:ClearNodeSelection")]
	public unsafe bool ClearNodeSelection(bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!ClearNodeSelection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:ClearNodeSelection");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearNodeSelection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearNodeSelection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ClearNodeSelection_bSetupUndoRedo_Offset), 0, ClearNodeSelection_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ClearNodeSelection_bPrintPythonCommand_Offset), 0, ClearNodeSelection_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClearNodeSelection_FunctionAddress, intPtr, ClearNodeSelection_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ClearNodeSelection_ReturnValue_Offset), 0, ClearNodeSelection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:ClearArrayPin")]
	public unsafe bool ClearArrayPin(string InArrayPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!ClearArrayPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:ClearArrayPin");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearArrayPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearArrayPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ClearArrayPin_InArrayPinPath_Offset), 0, ClearArrayPin_InArrayPinPath_PropertyAddress.Address, InArrayPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ClearArrayPin_bSetupUndoRedo_Offset), 0, ClearArrayPin_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ClearArrayPin_bPrintPythonCommand_Offset), 0, ClearArrayPin_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClearArrayPin_FunctionAddress, intPtr, ClearArrayPin_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ClearArrayPin_InArrayPinPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ClearArrayPin_ReturnValue_Offset), 0, ClearArrayPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:ChangeExposedPinType")]
	public unsafe bool ChangeExposedPinType(FName InPinName, string InCPPType, FName InCPPTypeObjectPath, ref bool bSetupUndoRedo, bool bSetupOrphanPins = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!ChangeExposedPinType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:ChangeExposedPinType");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ChangeExposedPinType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ChangeExposedPinType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ChangeExposedPinType_InPinName_Offset), 0, ChangeExposedPinType_InPinName_PropertyAddress.Address, InPinName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ChangeExposedPinType_InCPPType_Offset), 0, ChangeExposedPinType_InCPPType_PropertyAddress.Address, InCPPType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ChangeExposedPinType_InCPPTypeObjectPath_Offset), 0, ChangeExposedPinType_InCPPTypeObjectPath_PropertyAddress.Address, InCPPTypeObjectPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ChangeExposedPinType_bSetupUndoRedo_Offset), 0, ChangeExposedPinType_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ChangeExposedPinType_bSetupOrphanPins_Offset), 0, ChangeExposedPinType_bSetupOrphanPins_PropertyAddress.Address, bSetupOrphanPins);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ChangeExposedPinType_bPrintPythonCommand_Offset), 0, ChangeExposedPinType_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, ChangeExposedPinType_FunctionAddress, intPtr, ChangeExposedPinType_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ChangeExposedPinType_InCPPType_PropertyAddress.Address, intPtr);
		bSetupUndoRedo = BoolMarshaler.FromNative(IntPtr.Add(intPtr, ChangeExposedPinType_bSetupUndoRedo_Offset), 0, ChangeExposedPinType_bSetupUndoRedo_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ChangeExposedPinType_ReturnValue_Offset), 0, ChangeExposedPinType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:CanImportNodesFromText")]
	public unsafe bool CanImportNodesFromText(string InText)
	{
		CheckDestroyed();
		if (!CanImportNodesFromText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:CanImportNodesFromText");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanImportNodesFromText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanImportNodesFromText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CanImportNodesFromText_InText_Offset), 0, CanImportNodesFromText_InText_PropertyAddress.Address, InText);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanImportNodesFromText_FunctionAddress, intPtr, CanImportNodesFromText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CanImportNodesFromText_InText_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanImportNodesFromText_ReturnValue_Offset), 0, CanImportNodesFromText_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:CancelUndoBracket")]
	public unsafe bool CancelUndoBracket()
	{
		CheckDestroyed();
		if (!CancelUndoBracket_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:CancelUndoBracket");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CancelUndoBracket_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CancelUndoBracket_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CancelUndoBracket_FunctionAddress, intPtr, CancelUndoBracket_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CancelUndoBracket_ReturnValue_Offset), 0, CancelUndoBracket_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:BreakLink")]
	public unsafe bool BreakLink(string InOutputPinPath, string InInputPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!BreakLink_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:BreakLink");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BreakLink_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BreakLink_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BreakLink_InOutputPinPath_Offset), 0, BreakLink_InOutputPinPath_PropertyAddress.Address, InOutputPinPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BreakLink_InInputPinPath_Offset), 0, BreakLink_InInputPinPath_PropertyAddress.Address, InInputPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BreakLink_bSetupUndoRedo_Offset), 0, BreakLink_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BreakLink_bPrintPythonCommand_Offset), 0, BreakLink_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, BreakLink_FunctionAddress, intPtr, BreakLink_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BreakLink_InOutputPinPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BreakLink_InInputPinPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BreakLink_ReturnValue_Offset), 0, BreakLink_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:BreakAllLinks")]
	public unsafe bool BreakAllLinks(string InPinPath, bool bAsInput = true, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!BreakAllLinks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:BreakAllLinks");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BreakAllLinks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BreakAllLinks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BreakAllLinks_InPinPath_Offset), 0, BreakAllLinks_InPinPath_PropertyAddress.Address, InPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BreakAllLinks_bAsInput_Offset), 0, BreakAllLinks_bAsInput_PropertyAddress.Address, bAsInput);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BreakAllLinks_bSetupUndoRedo_Offset), 0, BreakAllLinks_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BreakAllLinks_bPrintPythonCommand_Offset), 0, BreakAllLinks_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, BreakAllLinks_FunctionAddress, intPtr, BreakAllLinks_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BreakAllLinks_InPinPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BreakAllLinks_ReturnValue_Offset), 0, BreakAllLinks_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:BindPinToVariable")]
	public unsafe bool BindPinToVariable(string InPinPath, string InNewBoundVariablePath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!BindPinToVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:BindPinToVariable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BindPinToVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BindPinToVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BindPinToVariable_InPinPath_Offset), 0, BindPinToVariable_InPinPath_PropertyAddress.Address, InPinPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BindPinToVariable_InNewBoundVariablePath_Offset), 0, BindPinToVariable_InNewBoundVariablePath_PropertyAddress.Address, InNewBoundVariablePath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BindPinToVariable_bSetupUndoRedo_Offset), 0, BindPinToVariable_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BindPinToVariable_bPrintPythonCommand_Offset), 0, BindPinToVariable_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, BindPinToVariable_FunctionAddress, intPtr, BindPinToVariable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BindPinToVariable_InPinPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BindPinToVariable_InNewBoundVariablePath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BindPinToVariable_ReturnValue_Offset), 0, BindPinToVariable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddVariableNodeFromObjectPath")]
	public unsafe URigVMVariableNode AddVariableNodeFromObjectPath(FName InVariableName, string InCPPType, string InCPPTypeObjectPath, bool bIsGetter, string InDefaultValue, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddVariableNodeFromObjectPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddVariableNodeFromObjectPath");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddVariableNodeFromObjectPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddVariableNodeFromObjectPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddVariableNodeFromObjectPath_InVariableName_Offset), 0, AddVariableNodeFromObjectPath_InVariableName_PropertyAddress.Address, InVariableName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddVariableNodeFromObjectPath_InCPPType_Offset), 0, AddVariableNodeFromObjectPath_InCPPType_PropertyAddress.Address, InCPPType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddVariableNodeFromObjectPath_InCPPTypeObjectPath_Offset), 0, AddVariableNodeFromObjectPath_InCPPTypeObjectPath_PropertyAddress.Address, InCPPTypeObjectPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddVariableNodeFromObjectPath_bIsGetter_Offset), 0, AddVariableNodeFromObjectPath_bIsGetter_PropertyAddress.Address, bIsGetter);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddVariableNodeFromObjectPath_InDefaultValue_Offset), 0, AddVariableNodeFromObjectPath_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddVariableNodeFromObjectPath_InPosition_Offset), 0, AddVariableNodeFromObjectPath_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddVariableNodeFromObjectPath_InNodeName_Offset), 0, AddVariableNodeFromObjectPath_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddVariableNodeFromObjectPath_bSetupUndoRedo_Offset), 0, AddVariableNodeFromObjectPath_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddVariableNodeFromObjectPath_bPrintPythonCommand_Offset), 0, AddVariableNodeFromObjectPath_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddVariableNodeFromObjectPath_FunctionAddress, intPtr, AddVariableNodeFromObjectPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddVariableNodeFromObjectPath_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddVariableNodeFromObjectPath_InCPPTypeObjectPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddVariableNodeFromObjectPath_InDefaultValue_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddVariableNodeFromObjectPath_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMVariableNode>.FromNative(IntPtr.Add(intPtr, AddVariableNodeFromObjectPath_ReturnValue_Offset), 0, AddVariableNodeFromObjectPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddVariableNode")]
	public unsafe URigVMVariableNode AddVariableNode(FName InVariableName, string InCPPType, UObject InCPPTypeObject, bool bIsGetter, string InDefaultValue, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddVariableNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddVariableNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddVariableNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddVariableNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddVariableNode_InVariableName_Offset), 0, AddVariableNode_InVariableName_PropertyAddress.Address, InVariableName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddVariableNode_InCPPType_Offset), 0, AddVariableNode_InCPPType_PropertyAddress.Address, InCPPType);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddVariableNode_InCPPTypeObject_Offset), 0, AddVariableNode_InCPPTypeObject_PropertyAddress.Address, InCPPTypeObject);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddVariableNode_bIsGetter_Offset), 0, AddVariableNode_bIsGetter_PropertyAddress.Address, bIsGetter);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddVariableNode_InDefaultValue_Offset), 0, AddVariableNode_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddVariableNode_InPosition_Offset), 0, AddVariableNode_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddVariableNode_InNodeName_Offset), 0, AddVariableNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddVariableNode_bSetupUndoRedo_Offset), 0, AddVariableNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddVariableNode_bPrintPythonCommand_Offset), 0, AddVariableNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddVariableNode_FunctionAddress, intPtr, AddVariableNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddVariableNode_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddVariableNode_InDefaultValue_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddVariableNode_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMVariableNode>.FromNative(IntPtr.Add(intPtr, AddVariableNode_ReturnValue_Offset), 0, AddVariableNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddUnitNodeFromStructPath")]
	public unsafe URigVMUnitNode AddUnitNodeFromStructPath(string InScriptStructPath, FName InMethodName, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo, bool bPrintPythonCommand)
	{
		CheckDestroyed();
		if (!AddUnitNodeFromStructPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddUnitNodeFromStructPath");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddUnitNodeFromStructPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddUnitNodeFromStructPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddUnitNodeFromStructPath_InScriptStructPath_Offset), 0, AddUnitNodeFromStructPath_InScriptStructPath_PropertyAddress.Address, InScriptStructPath);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddUnitNodeFromStructPath_InMethodName_Offset), 0, AddUnitNodeFromStructPath_InMethodName_PropertyAddress.Address, InMethodName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddUnitNodeFromStructPath_InPosition_Offset), 0, AddUnitNodeFromStructPath_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddUnitNodeFromStructPath_InNodeName_Offset), 0, AddUnitNodeFromStructPath_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddUnitNodeFromStructPath_bSetupUndoRedo_Offset), 0, AddUnitNodeFromStructPath_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddUnitNodeFromStructPath_bPrintPythonCommand_Offset), 0, AddUnitNodeFromStructPath_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddUnitNodeFromStructPath_FunctionAddress, intPtr, AddUnitNodeFromStructPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddUnitNodeFromStructPath_InScriptStructPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddUnitNodeFromStructPath_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMUnitNode>.FromNative(IntPtr.Add(intPtr, AddUnitNodeFromStructPath_ReturnValue_Offset), 0, AddUnitNodeFromStructPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddUnitNode")]
	public unsafe URigVMUnitNode AddUnitNode(UScriptStruct InScriptStruct, FName InMethodName, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo, bool bPrintPythonCommand)
	{
		CheckDestroyed();
		if (!AddUnitNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddUnitNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddUnitNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddUnitNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UScriptStruct>.ToNative(IntPtr.Add(intPtr, AddUnitNode_InScriptStruct_Offset), 0, AddUnitNode_InScriptStruct_PropertyAddress.Address, InScriptStruct);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddUnitNode_InMethodName_Offset), 0, AddUnitNode_InMethodName_PropertyAddress.Address, InMethodName);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddUnitNode_InPosition_Offset), 0, AddUnitNode_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddUnitNode_InNodeName_Offset), 0, AddUnitNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddUnitNode_bSetupUndoRedo_Offset), 0, AddUnitNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddUnitNode_bPrintPythonCommand_Offset), 0, AddUnitNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddUnitNode_FunctionAddress, intPtr, AddUnitNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddUnitNode_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMUnitNode>.FromNative(IntPtr.Add(intPtr, AddUnitNode_ReturnValue_Offset), 0, AddUnitNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddSelectNodeFromStruct")]
	public unsafe URigVMSelectNode AddSelectNodeFromStruct(UScriptStruct InScriptStruct, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!AddSelectNodeFromStruct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddSelectNodeFromStruct");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSelectNodeFromStruct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSelectNodeFromStruct_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UScriptStruct>.ToNative(IntPtr.Add(intPtr, AddSelectNodeFromStruct_InScriptStruct_Offset), 0, AddSelectNodeFromStruct_InScriptStruct_PropertyAddress.Address, InScriptStruct);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddSelectNodeFromStruct_InPosition_Offset), 0, AddSelectNodeFromStruct_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddSelectNodeFromStruct_InNodeName_Offset), 0, AddSelectNodeFromStruct_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddSelectNodeFromStruct_bSetupUndoRedo_Offset), 0, AddSelectNodeFromStruct_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddSelectNodeFromStruct_FunctionAddress, intPtr, AddSelectNodeFromStruct_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddSelectNodeFromStruct_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMSelectNode>.FromNative(IntPtr.Add(intPtr, AddSelectNodeFromStruct_ReturnValue_Offset), 0, AddSelectNodeFromStruct_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddSelectNode")]
	public unsafe URigVMSelectNode AddSelectNode(string InCPPType, FName InCPPTypeObjectPath, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddSelectNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddSelectNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSelectNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSelectNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddSelectNode_InCPPType_Offset), 0, AddSelectNode_InCPPType_PropertyAddress.Address, InCPPType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddSelectNode_InCPPTypeObjectPath_Offset), 0, AddSelectNode_InCPPTypeObjectPath_PropertyAddress.Address, InCPPTypeObjectPath);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddSelectNode_InPosition_Offset), 0, AddSelectNode_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddSelectNode_InNodeName_Offset), 0, AddSelectNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddSelectNode_bSetupUndoRedo_Offset), 0, AddSelectNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddSelectNode_bPrintPythonCommand_Offset), 0, AddSelectNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddSelectNode_FunctionAddress, intPtr, AddSelectNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddSelectNode_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddSelectNode_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMSelectNode>.FromNative(IntPtr.Add(intPtr, AddSelectNode_ReturnValue_Offset), 0, AddSelectNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddRerouteNodeOnPin")]
	public unsafe URigVMRerouteNode AddRerouteNodeOnPin(string InPinPath, bool bAsInput, bool bShowAsFullNode, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddRerouteNodeOnPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddRerouteNodeOnPin");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddRerouteNodeOnPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddRerouteNodeOnPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnPin_InPinPath_Offset), 0, AddRerouteNodeOnPin_InPinPath_PropertyAddress.Address, InPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnPin_bAsInput_Offset), 0, AddRerouteNodeOnPin_bAsInput_PropertyAddress.Address, bAsInput);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnPin_bShowAsFullNode_Offset), 0, AddRerouteNodeOnPin_bShowAsFullNode_PropertyAddress.Address, bShowAsFullNode);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnPin_InPosition_Offset), 0, AddRerouteNodeOnPin_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnPin_InNodeName_Offset), 0, AddRerouteNodeOnPin_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnPin_bSetupUndoRedo_Offset), 0, AddRerouteNodeOnPin_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnPin_bPrintPythonCommand_Offset), 0, AddRerouteNodeOnPin_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddRerouteNodeOnPin_FunctionAddress, intPtr, AddRerouteNodeOnPin_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddRerouteNodeOnPin_InPinPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddRerouteNodeOnPin_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMRerouteNode>.FromNative(IntPtr.Add(intPtr, AddRerouteNodeOnPin_ReturnValue_Offset), 0, AddRerouteNodeOnPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddRerouteNodeOnLinkPath")]
	public unsafe URigVMRerouteNode AddRerouteNodeOnLinkPath(string InLinkPinPathRepresentation, bool bShowAsFullNode, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddRerouteNodeOnLinkPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddRerouteNodeOnLinkPath");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddRerouteNodeOnLinkPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddRerouteNodeOnLinkPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnLinkPath_InLinkPinPathRepresentation_Offset), 0, AddRerouteNodeOnLinkPath_InLinkPinPathRepresentation_PropertyAddress.Address, InLinkPinPathRepresentation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnLinkPath_bShowAsFullNode_Offset), 0, AddRerouteNodeOnLinkPath_bShowAsFullNode_PropertyAddress.Address, bShowAsFullNode);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnLinkPath_InPosition_Offset), 0, AddRerouteNodeOnLinkPath_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnLinkPath_InNodeName_Offset), 0, AddRerouteNodeOnLinkPath_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnLinkPath_bSetupUndoRedo_Offset), 0, AddRerouteNodeOnLinkPath_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnLinkPath_bPrintPythonCommand_Offset), 0, AddRerouteNodeOnLinkPath_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddRerouteNodeOnLinkPath_FunctionAddress, intPtr, AddRerouteNodeOnLinkPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddRerouteNodeOnLinkPath_InLinkPinPathRepresentation_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddRerouteNodeOnLinkPath_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMRerouteNode>.FromNative(IntPtr.Add(intPtr, AddRerouteNodeOnLinkPath_ReturnValue_Offset), 0, AddRerouteNodeOnLinkPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddRerouteNodeOnLink")]
	public unsafe URigVMRerouteNode AddRerouteNodeOnLink(URigVMLink InLink, bool bShowAsFullNode, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddRerouteNodeOnLink_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddRerouteNodeOnLink");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddRerouteNodeOnLink_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddRerouteNodeOnLink_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMLink>.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnLink_InLink_Offset), 0, AddRerouteNodeOnLink_InLink_PropertyAddress.Address, InLink);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnLink_bShowAsFullNode_Offset), 0, AddRerouteNodeOnLink_bShowAsFullNode_PropertyAddress.Address, bShowAsFullNode);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnLink_InPosition_Offset), 0, AddRerouteNodeOnLink_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnLink_InNodeName_Offset), 0, AddRerouteNodeOnLink_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnLink_bSetupUndoRedo_Offset), 0, AddRerouteNodeOnLink_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddRerouteNodeOnLink_bPrintPythonCommand_Offset), 0, AddRerouteNodeOnLink_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddRerouteNodeOnLink_FunctionAddress, intPtr, AddRerouteNodeOnLink_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddRerouteNodeOnLink_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMRerouteNode>.FromNative(IntPtr.Add(intPtr, AddRerouteNodeOnLink_ReturnValue_Offset), 0, AddRerouteNodeOnLink_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddPrototypeNode")]
	public unsafe URigVMPrototypeNode AddPrototypeNode(FName InNotation, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddPrototypeNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddPrototypeNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddPrototypeNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddPrototypeNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddPrototypeNode_InNotation_Offset), 0, AddPrototypeNode_InNotation_PropertyAddress.Address, InNotation);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddPrototypeNode_InPosition_Offset), 0, AddPrototypeNode_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddPrototypeNode_InNodeName_Offset), 0, AddPrototypeNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddPrototypeNode_bSetupUndoRedo_Offset), 0, AddPrototypeNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddPrototypeNode_bPrintPythonCommand_Offset), 0, AddPrototypeNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddPrototypeNode_FunctionAddress, intPtr, AddPrototypeNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddPrototypeNode_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMPrototypeNode>.FromNative(IntPtr.Add(intPtr, AddPrototypeNode_ReturnValue_Offset), 0, AddPrototypeNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddParameterNodeFromObjectPath")]
	public unsafe URigVMParameterNode AddParameterNodeFromObjectPath(FName InParameterName, string InCPPType, string InCPPTypeObjectPath, bool bIsInput, string InDefaultValue, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddParameterNodeFromObjectPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddParameterNodeFromObjectPath");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddParameterNodeFromObjectPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddParameterNodeFromObjectPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddParameterNodeFromObjectPath_InParameterName_Offset), 0, AddParameterNodeFromObjectPath_InParameterName_PropertyAddress.Address, InParameterName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddParameterNodeFromObjectPath_InCPPType_Offset), 0, AddParameterNodeFromObjectPath_InCPPType_PropertyAddress.Address, InCPPType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddParameterNodeFromObjectPath_InCPPTypeObjectPath_Offset), 0, AddParameterNodeFromObjectPath_InCPPTypeObjectPath_PropertyAddress.Address, InCPPTypeObjectPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddParameterNodeFromObjectPath_bIsInput_Offset), 0, AddParameterNodeFromObjectPath_bIsInput_PropertyAddress.Address, bIsInput);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddParameterNodeFromObjectPath_InDefaultValue_Offset), 0, AddParameterNodeFromObjectPath_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddParameterNodeFromObjectPath_InPosition_Offset), 0, AddParameterNodeFromObjectPath_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddParameterNodeFromObjectPath_InNodeName_Offset), 0, AddParameterNodeFromObjectPath_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddParameterNodeFromObjectPath_bSetupUndoRedo_Offset), 0, AddParameterNodeFromObjectPath_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddParameterNodeFromObjectPath_bPrintPythonCommand_Offset), 0, AddParameterNodeFromObjectPath_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddParameterNodeFromObjectPath_FunctionAddress, intPtr, AddParameterNodeFromObjectPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddParameterNodeFromObjectPath_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddParameterNodeFromObjectPath_InCPPTypeObjectPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddParameterNodeFromObjectPath_InDefaultValue_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddParameterNodeFromObjectPath_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMParameterNode>.FromNative(IntPtr.Add(intPtr, AddParameterNodeFromObjectPath_ReturnValue_Offset), 0, AddParameterNodeFromObjectPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddParameterNode")]
	public unsafe URigVMParameterNode AddParameterNode(FName InParameterName, string InCPPType, UObject InCPPTypeObject, bool bIsInput, string InDefaultValue, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddParameterNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddParameterNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddParameterNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddParameterNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddParameterNode_InParameterName_Offset), 0, AddParameterNode_InParameterName_PropertyAddress.Address, InParameterName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddParameterNode_InCPPType_Offset), 0, AddParameterNode_InCPPType_PropertyAddress.Address, InCPPType);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddParameterNode_InCPPTypeObject_Offset), 0, AddParameterNode_InCPPTypeObject_PropertyAddress.Address, InCPPTypeObject);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddParameterNode_bIsInput_Offset), 0, AddParameterNode_bIsInput_PropertyAddress.Address, bIsInput);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddParameterNode_InDefaultValue_Offset), 0, AddParameterNode_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddParameterNode_InPosition_Offset), 0, AddParameterNode_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddParameterNode_InNodeName_Offset), 0, AddParameterNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddParameterNode_bSetupUndoRedo_Offset), 0, AddParameterNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddParameterNode_bPrintPythonCommand_Offset), 0, AddParameterNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddParameterNode_FunctionAddress, intPtr, AddParameterNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddParameterNode_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddParameterNode_InDefaultValue_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddParameterNode_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMParameterNode>.FromNative(IntPtr.Add(intPtr, AddParameterNode_ReturnValue_Offset), 0, AddParameterNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddLocalVariableFromObjectPath")]
	public unsafe FRigVMGraphVariableDescription AddLocalVariableFromObjectPath(FName InVariableName, string InCPPType, string InCPPTypeObjectPath, string InDefaultValue, bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!AddLocalVariableFromObjectPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddLocalVariableFromObjectPath");
			return default(FRigVMGraphVariableDescription);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddLocalVariableFromObjectPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddLocalVariableFromObjectPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddLocalVariableFromObjectPath_InVariableName_Offset), 0, AddLocalVariableFromObjectPath_InVariableName_PropertyAddress.Address, InVariableName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddLocalVariableFromObjectPath_InCPPType_Offset), 0, AddLocalVariableFromObjectPath_InCPPType_PropertyAddress.Address, InCPPType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddLocalVariableFromObjectPath_InCPPTypeObjectPath_Offset), 0, AddLocalVariableFromObjectPath_InCPPTypeObjectPath_PropertyAddress.Address, InCPPTypeObjectPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddLocalVariableFromObjectPath_InDefaultValue_Offset), 0, AddLocalVariableFromObjectPath_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddLocalVariableFromObjectPath_bSetupUndoRedo_Offset), 0, AddLocalVariableFromObjectPath_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddLocalVariableFromObjectPath_FunctionAddress, intPtr, AddLocalVariableFromObjectPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddLocalVariableFromObjectPath_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddLocalVariableFromObjectPath_InCPPTypeObjectPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddLocalVariableFromObjectPath_InDefaultValue_PropertyAddress.Address, intPtr);
		FRigVMGraphVariableDescription result = FRigVMGraphVariableDescription.FromNative(IntPtr.Add(intPtr, AddLocalVariableFromObjectPath_ReturnValue_Offset), 0, AddLocalVariableFromObjectPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddLocalVariableFromObjectPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddLocalVariable")]
	public unsafe FRigVMGraphVariableDescription AddLocalVariable(FName InVariableName, string InCPPType, UObject InCPPTypeObject, string InDefaultValue, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddLocalVariable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddLocalVariable");
			return default(FRigVMGraphVariableDescription);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddLocalVariable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddLocalVariable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddLocalVariable_InVariableName_Offset), 0, AddLocalVariable_InVariableName_PropertyAddress.Address, InVariableName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddLocalVariable_InCPPType_Offset), 0, AddLocalVariable_InCPPType_PropertyAddress.Address, InCPPType);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddLocalVariable_InCPPTypeObject_Offset), 0, AddLocalVariable_InCPPTypeObject_PropertyAddress.Address, InCPPTypeObject);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddLocalVariable_InDefaultValue_Offset), 0, AddLocalVariable_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddLocalVariable_bSetupUndoRedo_Offset), 0, AddLocalVariable_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddLocalVariable_bPrintPythonCommand_Offset), 0, AddLocalVariable_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddLocalVariable_FunctionAddress, intPtr, AddLocalVariable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddLocalVariable_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddLocalVariable_InDefaultValue_PropertyAddress.Address, intPtr);
		FRigVMGraphVariableDescription result = FRigVMGraphVariableDescription.FromNative(IntPtr.Add(intPtr, AddLocalVariable_ReturnValue_Offset), 0, AddLocalVariable_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddLocalVariable_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddLink")]
	public unsafe bool AddLink(string InOutputPinPath, string InInputPinPath, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddLink_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddLink");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddLink_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddLink_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddLink_InOutputPinPath_Offset), 0, AddLink_InOutputPinPath_PropertyAddress.Address, InOutputPinPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddLink_InInputPinPath_Offset), 0, AddLink_InInputPinPath_PropertyAddress.Address, InInputPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddLink_bSetupUndoRedo_Offset), 0, AddLink_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddLink_bPrintPythonCommand_Offset), 0, AddLink_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddLink_FunctionAddress, intPtr, AddLink_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddLink_InOutputPinPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddLink_InInputPinPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddLink_ReturnValue_Offset), 0, AddLink_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddInjectedNodeFromStructPath")]
	public unsafe URigVMInjectionInfo AddInjectedNodeFromStructPath(string InPinPath, bool bAsInput, string InScriptStructPath, FName InMethodName, FName InInputPinName, FName InOutputPinName, string InNodeName, bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!AddInjectedNodeFromStructPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddInjectedNodeFromStructPath");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddInjectedNodeFromStructPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddInjectedNodeFromStructPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddInjectedNodeFromStructPath_InPinPath_Offset), 0, AddInjectedNodeFromStructPath_InPinPath_PropertyAddress.Address, InPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddInjectedNodeFromStructPath_bAsInput_Offset), 0, AddInjectedNodeFromStructPath_bAsInput_PropertyAddress.Address, bAsInput);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddInjectedNodeFromStructPath_InScriptStructPath_Offset), 0, AddInjectedNodeFromStructPath_InScriptStructPath_PropertyAddress.Address, InScriptStructPath);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddInjectedNodeFromStructPath_InMethodName_Offset), 0, AddInjectedNodeFromStructPath_InMethodName_PropertyAddress.Address, InMethodName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddInjectedNodeFromStructPath_InInputPinName_Offset), 0, AddInjectedNodeFromStructPath_InInputPinName_PropertyAddress.Address, InInputPinName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddInjectedNodeFromStructPath_InOutputPinName_Offset), 0, AddInjectedNodeFromStructPath_InOutputPinName_PropertyAddress.Address, InOutputPinName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddInjectedNodeFromStructPath_InNodeName_Offset), 0, AddInjectedNodeFromStructPath_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddInjectedNodeFromStructPath_bSetupUndoRedo_Offset), 0, AddInjectedNodeFromStructPath_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddInjectedNodeFromStructPath_FunctionAddress, intPtr, AddInjectedNodeFromStructPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddInjectedNodeFromStructPath_InPinPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddInjectedNodeFromStructPath_InScriptStructPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddInjectedNodeFromStructPath_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMInjectionInfo>.FromNative(IntPtr.Add(intPtr, AddInjectedNodeFromStructPath_ReturnValue_Offset), 0, AddInjectedNodeFromStructPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608306177u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddInjectedNode")]
	public unsafe URigVMInjectionInfo AddInjectedNode(string InPinPath, bool bAsInput, UScriptStruct InScriptStruct, FName InMethodName, FName InInputPinName, FName InOutputPinName, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddInjectedNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddInjectedNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddInjectedNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddInjectedNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddInjectedNode_InPinPath_Offset), 0, AddInjectedNode_InPinPath_PropertyAddress.Address, InPinPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddInjectedNode_bAsInput_Offset), 0, AddInjectedNode_bAsInput_PropertyAddress.Address, bAsInput);
		UObjectMarshaler<UScriptStruct>.ToNative(IntPtr.Add(intPtr, AddInjectedNode_InScriptStruct_Offset), 0, AddInjectedNode_InScriptStruct_PropertyAddress.Address, InScriptStruct);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddInjectedNode_InMethodName_Offset), 0, AddInjectedNode_InMethodName_PropertyAddress.Address, InMethodName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddInjectedNode_InInputPinName_Offset), 0, AddInjectedNode_InInputPinName_PropertyAddress.Address, InInputPinName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddInjectedNode_InOutputPinName_Offset), 0, AddInjectedNode_InOutputPinName_PropertyAddress.Address, InOutputPinName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddInjectedNode_InNodeName_Offset), 0, AddInjectedNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddInjectedNode_bSetupUndoRedo_Offset), 0, AddInjectedNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddInjectedNode_bPrintPythonCommand_Offset), 0, AddInjectedNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddInjectedNode_FunctionAddress, intPtr, AddInjectedNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddInjectedNode_InPinPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddInjectedNode_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMInjectionInfo>.FromNative(IntPtr.Add(intPtr, AddInjectedNode_ReturnValue_Offset), 0, AddInjectedNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddIfNodeFromStruct")]
	public unsafe URigVMIfNode AddIfNodeFromStruct(UScriptStruct InScriptStruct, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!AddIfNodeFromStruct_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddIfNodeFromStruct");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddIfNodeFromStruct_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddIfNodeFromStruct_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UScriptStruct>.ToNative(IntPtr.Add(intPtr, AddIfNodeFromStruct_InScriptStruct_Offset), 0, AddIfNodeFromStruct_InScriptStruct_PropertyAddress.Address, InScriptStruct);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddIfNodeFromStruct_InPosition_Offset), 0, AddIfNodeFromStruct_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddIfNodeFromStruct_InNodeName_Offset), 0, AddIfNodeFromStruct_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddIfNodeFromStruct_bSetupUndoRedo_Offset), 0, AddIfNodeFromStruct_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddIfNodeFromStruct_FunctionAddress, intPtr, AddIfNodeFromStruct_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddIfNodeFromStruct_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMIfNode>.FromNative(IntPtr.Add(intPtr, AddIfNodeFromStruct_ReturnValue_Offset), 0, AddIfNodeFromStruct_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddIfNode")]
	public unsafe URigVMIfNode AddIfNode(string InCPPType, FName InCPPTypeObjectPath, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddIfNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddIfNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddIfNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddIfNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddIfNode_InCPPType_Offset), 0, AddIfNode_InCPPType_PropertyAddress.Address, InCPPType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddIfNode_InCPPTypeObjectPath_Offset), 0, AddIfNode_InCPPTypeObjectPath_PropertyAddress.Address, InCPPTypeObjectPath);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddIfNode_InPosition_Offset), 0, AddIfNode_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddIfNode_InNodeName_Offset), 0, AddIfNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddIfNode_bSetupUndoRedo_Offset), 0, AddIfNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddIfNode_bPrintPythonCommand_Offset), 0, AddIfNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddIfNode_FunctionAddress, intPtr, AddIfNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddIfNode_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddIfNode_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMIfNode>.FromNative(IntPtr.Add(intPtr, AddIfNode_ReturnValue_Offset), 0, AddIfNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddFunctionToLibrary")]
	public unsafe URigVMLibraryNode AddFunctionToLibrary(FName InFunctionName, bool bMutable, FVector2D InNodePosition, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddFunctionToLibrary_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddFunctionToLibrary");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFunctionToLibrary_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFunctionToLibrary_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddFunctionToLibrary_InFunctionName_Offset), 0, AddFunctionToLibrary_InFunctionName_PropertyAddress.Address, InFunctionName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddFunctionToLibrary_bMutable_Offset), 0, AddFunctionToLibrary_bMutable_PropertyAddress.Address, bMutable);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddFunctionToLibrary_InNodePosition_Offset), 0, AddFunctionToLibrary_InNodePosition_PropertyAddress.Address, InNodePosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddFunctionToLibrary_bSetupUndoRedo_Offset), 0, AddFunctionToLibrary_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddFunctionToLibrary_bPrintPythonCommand_Offset), 0, AddFunctionToLibrary_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddFunctionToLibrary_FunctionAddress, intPtr, AddFunctionToLibrary_ParamsSize);
		return UObjectMarshaler<URigVMLibraryNode>.FromNative(IntPtr.Add(intPtr, AddFunctionToLibrary_ReturnValue_Offset), 0, AddFunctionToLibrary_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddFunctionReferenceNode")]
	public unsafe URigVMFunctionReferenceNode AddFunctionReferenceNode(URigVMLibraryNode InFunctionDefinition, FVector2D InNodePosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddFunctionReferenceNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddFunctionReferenceNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFunctionReferenceNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFunctionReferenceNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMLibraryNode>.ToNative(IntPtr.Add(intPtr, AddFunctionReferenceNode_InFunctionDefinition_Offset), 0, AddFunctionReferenceNode_InFunctionDefinition_PropertyAddress.Address, InFunctionDefinition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddFunctionReferenceNode_InNodePosition_Offset), 0, AddFunctionReferenceNode_InNodePosition_PropertyAddress.Address, InNodePosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddFunctionReferenceNode_InNodeName_Offset), 0, AddFunctionReferenceNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddFunctionReferenceNode_bSetupUndoRedo_Offset), 0, AddFunctionReferenceNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddFunctionReferenceNode_bPrintPythonCommand_Offset), 0, AddFunctionReferenceNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddFunctionReferenceNode_FunctionAddress, intPtr, AddFunctionReferenceNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddFunctionReferenceNode_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMFunctionReferenceNode>.FromNative(IntPtr.Add(intPtr, AddFunctionReferenceNode_ReturnValue_Offset), 0, AddFunctionReferenceNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddFreeRerouteNode")]
	public unsafe URigVMRerouteNode AddFreeRerouteNode(bool bShowAsFullNode, string InCPPType, FName InCPPTypeObjectPath, bool bIsConstant, FName InCustomWidgetName, string InDefaultValue, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true)
	{
		CheckDestroyed();
		if (!AddFreeRerouteNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddFreeRerouteNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFreeRerouteNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFreeRerouteNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddFreeRerouteNode_bShowAsFullNode_Offset), 0, AddFreeRerouteNode_bShowAsFullNode_PropertyAddress.Address, bShowAsFullNode);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddFreeRerouteNode_InCPPType_Offset), 0, AddFreeRerouteNode_InCPPType_PropertyAddress.Address, InCPPType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddFreeRerouteNode_InCPPTypeObjectPath_Offset), 0, AddFreeRerouteNode_InCPPTypeObjectPath_PropertyAddress.Address, InCPPTypeObjectPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddFreeRerouteNode_bIsConstant_Offset), 0, AddFreeRerouteNode_bIsConstant_PropertyAddress.Address, bIsConstant);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddFreeRerouteNode_InCustomWidgetName_Offset), 0, AddFreeRerouteNode_InCustomWidgetName_PropertyAddress.Address, InCustomWidgetName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddFreeRerouteNode_InDefaultValue_Offset), 0, AddFreeRerouteNode_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddFreeRerouteNode_InPosition_Offset), 0, AddFreeRerouteNode_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddFreeRerouteNode_InNodeName_Offset), 0, AddFreeRerouteNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddFreeRerouteNode_bSetupUndoRedo_Offset), 0, AddFreeRerouteNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddFreeRerouteNode_FunctionAddress, intPtr, AddFreeRerouteNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddFreeRerouteNode_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddFreeRerouteNode_InDefaultValue_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddFreeRerouteNode_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMRerouteNode>.FromNative(IntPtr.Add(intPtr, AddFreeRerouteNode_ReturnValue_Offset), 0, AddFreeRerouteNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddExposedPin")]
	public unsafe FName AddExposedPin(FName InPinName, ERigVMPinDirection InDirection, string InCPPType, FName InCPPTypeObjectPath, string InDefaultValue, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddExposedPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddExposedPin");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddExposedPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddExposedPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddExposedPin_InPinName_Offset), 0, AddExposedPin_InPinName_PropertyAddress.Address, InPinName);
		EnumMarshaler<ERigVMPinDirection>.ToNative(IntPtr.Add(intPtr, AddExposedPin_InDirection_Offset), 0, AddExposedPin_InDirection_PropertyAddress.Address, InDirection);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddExposedPin_InCPPType_Offset), 0, AddExposedPin_InCPPType_PropertyAddress.Address, InCPPType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddExposedPin_InCPPTypeObjectPath_Offset), 0, AddExposedPin_InCPPTypeObjectPath_PropertyAddress.Address, InCPPTypeObjectPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddExposedPin_InDefaultValue_Offset), 0, AddExposedPin_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddExposedPin_bSetupUndoRedo_Offset), 0, AddExposedPin_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddExposedPin_bPrintPythonCommand_Offset), 0, AddExposedPin_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddExposedPin_FunctionAddress, intPtr, AddExposedPin_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddExposedPin_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddExposedPin_InDefaultValue_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, AddExposedPin_ReturnValue_Offset), 0, AddExposedPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddEnumNode")]
	public unsafe URigVMEnumNode AddEnumNode(FName InCPPTypeObjectPath, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddEnumNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddEnumNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddEnumNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddEnumNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddEnumNode_InCPPTypeObjectPath_Offset), 0, AddEnumNode_InCPPTypeObjectPath_PropertyAddress.Address, InCPPTypeObjectPath);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddEnumNode_InPosition_Offset), 0, AddEnumNode_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddEnumNode_InNodeName_Offset), 0, AddEnumNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddEnumNode_bSetupUndoRedo_Offset), 0, AddEnumNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddEnumNode_bPrintPythonCommand_Offset), 0, AddEnumNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddEnumNode_FunctionAddress, intPtr, AddEnumNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddEnumNode_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMEnumNode>.FromNative(IntPtr.Add(intPtr, AddEnumNode_ReturnValue_Offset), 0, AddEnumNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddCommentNode")]
	public unsafe URigVMCommentNode AddCommentNode(string InCommentText, FVector2D InPosition, FVector2D InSize, FLinearColor InColor, string InNodeName, bool bSetupUndoRedo, bool bPrintPythonCommand)
	{
		CheckDestroyed();
		if (!AddCommentNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddCommentNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddCommentNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddCommentNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddCommentNode_InCommentText_Offset), 0, AddCommentNode_InCommentText_PropertyAddress.Address, InCommentText);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddCommentNode_InPosition_Offset), 0, AddCommentNode_InPosition_PropertyAddress.Address, InPosition);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddCommentNode_InSize_Offset), 0, AddCommentNode_InSize_PropertyAddress.Address, InSize);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, AddCommentNode_InColor_Offset), 0, AddCommentNode_InColor_PropertyAddress.Address, InColor);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddCommentNode_InNodeName_Offset), 0, AddCommentNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddCommentNode_bSetupUndoRedo_Offset), 0, AddCommentNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddCommentNode_bPrintPythonCommand_Offset), 0, AddCommentNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddCommentNode_FunctionAddress, intPtr, AddCommentNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddCommentNode_InCommentText_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddCommentNode_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMCommentNode>.FromNative(IntPtr.Add(intPtr, AddCommentNode_ReturnValue_Offset), 0, AddCommentNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddBranchNode")]
	public unsafe URigVMBranchNode AddBranchNode(FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddBranchNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddBranchNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBranchNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBranchNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddBranchNode_InPosition_Offset), 0, AddBranchNode_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddBranchNode_InNodeName_Offset), 0, AddBranchNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddBranchNode_bSetupUndoRedo_Offset), 0, AddBranchNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddBranchNode_bPrintPythonCommand_Offset), 0, AddBranchNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddBranchNode_FunctionAddress, intPtr, AddBranchNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddBranchNode_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMBranchNode>.FromNative(IntPtr.Add(intPtr, AddBranchNode_ReturnValue_Offset), 0, AddBranchNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddArrayPin")]
	public unsafe string AddArrayPin(string InArrayPinPath, string InDefaultValue, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddArrayPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddArrayPin");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddArrayPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddArrayPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddArrayPin_InArrayPinPath_Offset), 0, AddArrayPin_InArrayPinPath_PropertyAddress.Address, InArrayPinPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddArrayPin_InDefaultValue_Offset), 0, AddArrayPin_InDefaultValue_PropertyAddress.Address, InDefaultValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddArrayPin_bSetupUndoRedo_Offset), 0, AddArrayPin_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddArrayPin_bPrintPythonCommand_Offset), 0, AddArrayPin_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddArrayPin_FunctionAddress, intPtr, AddArrayPin_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddArrayPin_InArrayPinPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddArrayPin_InDefaultValue_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, AddArrayPin_ReturnValue_Offset), 0, AddArrayPin_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddArrayPin_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddArrayNodeFromObjectPath")]
	public unsafe URigVMArrayNode AddArrayNodeFromObjectPath(ERigVMOpCode InOpCode, string InCPPType, string InCPPTypeObjectPath, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddArrayNodeFromObjectPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddArrayNodeFromObjectPath");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddArrayNodeFromObjectPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddArrayNodeFromObjectPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERigVMOpCode>.ToNative(IntPtr.Add(intPtr, AddArrayNodeFromObjectPath_InOpCode_Offset), 0, AddArrayNodeFromObjectPath_InOpCode_PropertyAddress.Address, InOpCode);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddArrayNodeFromObjectPath_InCPPType_Offset), 0, AddArrayNodeFromObjectPath_InCPPType_PropertyAddress.Address, InCPPType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddArrayNodeFromObjectPath_InCPPTypeObjectPath_Offset), 0, AddArrayNodeFromObjectPath_InCPPTypeObjectPath_PropertyAddress.Address, InCPPTypeObjectPath);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddArrayNodeFromObjectPath_InPosition_Offset), 0, AddArrayNodeFromObjectPath_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddArrayNodeFromObjectPath_InNodeName_Offset), 0, AddArrayNodeFromObjectPath_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddArrayNodeFromObjectPath_bSetupUndoRedo_Offset), 0, AddArrayNodeFromObjectPath_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddArrayNodeFromObjectPath_bPrintPythonCommand_Offset), 0, AddArrayNodeFromObjectPath_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddArrayNodeFromObjectPath_FunctionAddress, intPtr, AddArrayNodeFromObjectPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddArrayNodeFromObjectPath_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddArrayNodeFromObjectPath_InCPPTypeObjectPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddArrayNodeFromObjectPath_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMArrayNode>.FromNative(IntPtr.Add(intPtr, AddArrayNodeFromObjectPath_ReturnValue_Offset), 0, AddArrayNodeFromObjectPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616694785u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMController:AddArrayNode")]
	public unsafe URigVMArrayNode AddArrayNode(ERigVMOpCode InOpCode, string InCPPType, UObject InCPPTypeObject, FVector2D InPosition, string InNodeName, bool bSetupUndoRedo = true, bool bPrintPythonCommand = false)
	{
		CheckDestroyed();
		if (!AddArrayNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMController:AddArrayNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddArrayNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddArrayNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERigVMOpCode>.ToNative(IntPtr.Add(intPtr, AddArrayNode_InOpCode_Offset), 0, AddArrayNode_InOpCode_PropertyAddress.Address, InOpCode);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddArrayNode_InCPPType_Offset), 0, AddArrayNode_InCPPType_PropertyAddress.Address, InCPPType);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddArrayNode_InCPPTypeObject_Offset), 0, AddArrayNode_InCPPTypeObject_PropertyAddress.Address, InCPPTypeObject);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddArrayNode_InPosition_Offset), 0, AddArrayNode_InPosition_PropertyAddress.Address, InPosition);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddArrayNode_InNodeName_Offset), 0, AddArrayNode_InNodeName_PropertyAddress.Address, InNodeName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddArrayNode_bSetupUndoRedo_Offset), 0, AddArrayNode_bSetupUndoRedo_PropertyAddress.Address, bSetupUndoRedo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddArrayNode_bPrintPythonCommand_Offset), 0, AddArrayNode_bPrintPythonCommand_PropertyAddress.Address, bPrintPythonCommand);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddArrayNode_FunctionAddress, intPtr, AddArrayNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddArrayNode_InCPPType_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddArrayNode_InNodeName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMArrayNode>.FromNative(IntPtr.Add(intPtr, AddArrayNode_ReturnValue_Offset), 0, AddArrayNode_ReturnValue_PropertyAddress.Address);
	}

	static URigVMController()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMController));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMController");
		ModifiedEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModifiedEventDynamic");
		ModifiedEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModifiedEventDynamic", Classes.FMulticastDelegateProperty);
		Undo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Undo");
		Undo_ParamsSize = NativeReflection.GetFunctionParamsSize(Undo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Undo_ReturnValue_PropertyAddress, Undo_FunctionAddress, "ReturnValue");
		Undo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Undo_FunctionAddress, "ReturnValue");
		Undo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Undo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Undo_IsValid = Undo_FunctionAddress != IntPtr.Zero && Undo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:Undo", Undo_IsValid);
		UnbindPinFromVariable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnbindPinFromVariable");
		UnbindPinFromVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(UnbindPinFromVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnbindPinFromVariable_InPinPath_PropertyAddress, UnbindPinFromVariable_FunctionAddress, "InPinPath");
		UnbindPinFromVariable_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(UnbindPinFromVariable_FunctionAddress, "InPinPath");
		UnbindPinFromVariable_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(UnbindPinFromVariable_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UnbindPinFromVariable_bSetupUndoRedo_PropertyAddress, UnbindPinFromVariable_FunctionAddress, "bSetupUndoRedo");
		UnbindPinFromVariable_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(UnbindPinFromVariable_FunctionAddress, "bSetupUndoRedo");
		UnbindPinFromVariable_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(UnbindPinFromVariable_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UnbindPinFromVariable_bPrintPythonCommand_PropertyAddress, UnbindPinFromVariable_FunctionAddress, "bPrintPythonCommand");
		UnbindPinFromVariable_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(UnbindPinFromVariable_FunctionAddress, "bPrintPythonCommand");
		UnbindPinFromVariable_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(UnbindPinFromVariable_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UnbindPinFromVariable_ReturnValue_PropertyAddress, UnbindPinFromVariable_FunctionAddress, "ReturnValue");
		UnbindPinFromVariable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(UnbindPinFromVariable_FunctionAddress, "ReturnValue");
		UnbindPinFromVariable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UnbindPinFromVariable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		UnbindPinFromVariable_IsValid = UnbindPinFromVariable_FunctionAddress != IntPtr.Zero && UnbindPinFromVariable_InPinPath_IsValid && UnbindPinFromVariable_bSetupUndoRedo_IsValid && UnbindPinFromVariable_bPrintPythonCommand_IsValid && UnbindPinFromVariable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:UnbindPinFromVariable", UnbindPinFromVariable_IsValid);
		SetRerouteCompactnessByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRerouteCompactnessByName");
		SetRerouteCompactnessByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRerouteCompactnessByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRerouteCompactnessByName_InNodeName_PropertyAddress, SetRerouteCompactnessByName_FunctionAddress, "InNodeName");
		SetRerouteCompactnessByName_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(SetRerouteCompactnessByName_FunctionAddress, "InNodeName");
		SetRerouteCompactnessByName_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRerouteCompactnessByName_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRerouteCompactnessByName_bShowAsFullNode_PropertyAddress, SetRerouteCompactnessByName_FunctionAddress, "bShowAsFullNode");
		SetRerouteCompactnessByName_bShowAsFullNode_Offset = NativeReflectionCached.GetPropertyOffset(SetRerouteCompactnessByName_FunctionAddress, "bShowAsFullNode");
		SetRerouteCompactnessByName_bShowAsFullNode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRerouteCompactnessByName_FunctionAddress, "bShowAsFullNode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRerouteCompactnessByName_bSetupUndoRedo_PropertyAddress, SetRerouteCompactnessByName_FunctionAddress, "bSetupUndoRedo");
		SetRerouteCompactnessByName_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetRerouteCompactnessByName_FunctionAddress, "bSetupUndoRedo");
		SetRerouteCompactnessByName_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRerouteCompactnessByName_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRerouteCompactnessByName_ReturnValue_PropertyAddress, SetRerouteCompactnessByName_FunctionAddress, "ReturnValue");
		SetRerouteCompactnessByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRerouteCompactnessByName_FunctionAddress, "ReturnValue");
		SetRerouteCompactnessByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRerouteCompactnessByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetRerouteCompactnessByName_IsValid = SetRerouteCompactnessByName_FunctionAddress != IntPtr.Zero && SetRerouteCompactnessByName_InNodeName_IsValid && SetRerouteCompactnessByName_bShowAsFullNode_IsValid && SetRerouteCompactnessByName_bSetupUndoRedo_IsValid && SetRerouteCompactnessByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetRerouteCompactnessByName", SetRerouteCompactnessByName_IsValid);
		SetRerouteCompactness_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRerouteCompactness");
		SetRerouteCompactness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRerouteCompactness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRerouteCompactness_InNode_PropertyAddress, SetRerouteCompactness_FunctionAddress, "InNode");
		SetRerouteCompactness_InNode_Offset = NativeReflectionCached.GetPropertyOffset(SetRerouteCompactness_FunctionAddress, "InNode");
		SetRerouteCompactness_InNode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRerouteCompactness_FunctionAddress, "InNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRerouteCompactness_bShowAsFullNode_PropertyAddress, SetRerouteCompactness_FunctionAddress, "bShowAsFullNode");
		SetRerouteCompactness_bShowAsFullNode_Offset = NativeReflectionCached.GetPropertyOffset(SetRerouteCompactness_FunctionAddress, "bShowAsFullNode");
		SetRerouteCompactness_bShowAsFullNode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRerouteCompactness_FunctionAddress, "bShowAsFullNode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRerouteCompactness_bSetupUndoRedo_PropertyAddress, SetRerouteCompactness_FunctionAddress, "bSetupUndoRedo");
		SetRerouteCompactness_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetRerouteCompactness_FunctionAddress, "bSetupUndoRedo");
		SetRerouteCompactness_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRerouteCompactness_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRerouteCompactness_bPrintPythonCommand_PropertyAddress, SetRerouteCompactness_FunctionAddress, "bPrintPythonCommand");
		SetRerouteCompactness_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetRerouteCompactness_FunctionAddress, "bPrintPythonCommand");
		SetRerouteCompactness_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRerouteCompactness_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRerouteCompactness_ReturnValue_PropertyAddress, SetRerouteCompactness_FunctionAddress, "ReturnValue");
		SetRerouteCompactness_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRerouteCompactness_FunctionAddress, "ReturnValue");
		SetRerouteCompactness_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRerouteCompactness_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetRerouteCompactness_IsValid = SetRerouteCompactness_FunctionAddress != IntPtr.Zero && SetRerouteCompactness_InNode_IsValid && SetRerouteCompactness_bShowAsFullNode_IsValid && SetRerouteCompactness_bSetupUndoRedo_IsValid && SetRerouteCompactness_bPrintPythonCommand_IsValid && SetRerouteCompactness_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetRerouteCompactness", SetRerouteCompactness_IsValid);
		SetRemappedVariable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRemappedVariable");
		SetRemappedVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRemappedVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRemappedVariable_InFunctionRefNode_PropertyAddress, SetRemappedVariable_FunctionAddress, "InFunctionRefNode");
		SetRemappedVariable_InFunctionRefNode_Offset = NativeReflectionCached.GetPropertyOffset(SetRemappedVariable_FunctionAddress, "InFunctionRefNode");
		SetRemappedVariable_InFunctionRefNode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRemappedVariable_FunctionAddress, "InFunctionRefNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRemappedVariable_InInnerVariableName_PropertyAddress, SetRemappedVariable_FunctionAddress, "InInnerVariableName");
		SetRemappedVariable_InInnerVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetRemappedVariable_FunctionAddress, "InInnerVariableName");
		SetRemappedVariable_InInnerVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRemappedVariable_FunctionAddress, "InInnerVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRemappedVariable_InOuterVariableName_PropertyAddress, SetRemappedVariable_FunctionAddress, "InOuterVariableName");
		SetRemappedVariable_InOuterVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetRemappedVariable_FunctionAddress, "InOuterVariableName");
		SetRemappedVariable_InOuterVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRemappedVariable_FunctionAddress, "InOuterVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRemappedVariable_bSetupUndoRedo_PropertyAddress, SetRemappedVariable_FunctionAddress, "bSetupUndoRedo");
		SetRemappedVariable_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetRemappedVariable_FunctionAddress, "bSetupUndoRedo");
		SetRemappedVariable_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRemappedVariable_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRemappedVariable_ReturnValue_PropertyAddress, SetRemappedVariable_FunctionAddress, "ReturnValue");
		SetRemappedVariable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRemappedVariable_FunctionAddress, "ReturnValue");
		SetRemappedVariable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRemappedVariable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetRemappedVariable_IsValid = SetRemappedVariable_FunctionAddress != IntPtr.Zero && SetRemappedVariable_InFunctionRefNode_IsValid && SetRemappedVariable_InInnerVariableName_IsValid && SetRemappedVariable_InOuterVariableName_IsValid && SetRemappedVariable_bSetupUndoRedo_IsValid && SetRemappedVariable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetRemappedVariable", SetRemappedVariable_IsValid);
		SetPinIsWatched_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPinIsWatched");
		SetPinIsWatched_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPinIsWatched_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPinIsWatched_InPinPath_PropertyAddress, SetPinIsWatched_FunctionAddress, "InPinPath");
		SetPinIsWatched_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(SetPinIsWatched_FunctionAddress, "InPinPath");
		SetPinIsWatched_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinIsWatched_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinIsWatched_bIsWatched_PropertyAddress, SetPinIsWatched_FunctionAddress, "bIsWatched");
		SetPinIsWatched_bIsWatched_Offset = NativeReflectionCached.GetPropertyOffset(SetPinIsWatched_FunctionAddress, "bIsWatched");
		SetPinIsWatched_bIsWatched_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinIsWatched_FunctionAddress, "bIsWatched", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinIsWatched_bSetupUndoRedo_PropertyAddress, SetPinIsWatched_FunctionAddress, "bSetupUndoRedo");
		SetPinIsWatched_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetPinIsWatched_FunctionAddress, "bSetupUndoRedo");
		SetPinIsWatched_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinIsWatched_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinIsWatched_ReturnValue_PropertyAddress, SetPinIsWatched_FunctionAddress, "ReturnValue");
		SetPinIsWatched_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPinIsWatched_FunctionAddress, "ReturnValue");
		SetPinIsWatched_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinIsWatched_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetPinIsWatched_IsValid = SetPinIsWatched_FunctionAddress != IntPtr.Zero && SetPinIsWatched_InPinPath_IsValid && SetPinIsWatched_bIsWatched_IsValid && SetPinIsWatched_bSetupUndoRedo_IsValid && SetPinIsWatched_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetPinIsWatched", SetPinIsWatched_IsValid);
		SetPinExpansion_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPinExpansion");
		SetPinExpansion_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPinExpansion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPinExpansion_InPinPath_PropertyAddress, SetPinExpansion_FunctionAddress, "InPinPath");
		SetPinExpansion_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(SetPinExpansion_FunctionAddress, "InPinPath");
		SetPinExpansion_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinExpansion_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinExpansion_bIsExpanded_PropertyAddress, SetPinExpansion_FunctionAddress, "bIsExpanded");
		SetPinExpansion_bIsExpanded_Offset = NativeReflectionCached.GetPropertyOffset(SetPinExpansion_FunctionAddress, "bIsExpanded");
		SetPinExpansion_bIsExpanded_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinExpansion_FunctionAddress, "bIsExpanded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinExpansion_bSetupUndoRedo_PropertyAddress, SetPinExpansion_FunctionAddress, "bSetupUndoRedo");
		SetPinExpansion_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetPinExpansion_FunctionAddress, "bSetupUndoRedo");
		SetPinExpansion_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinExpansion_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinExpansion_bPrintPythonCommand_PropertyAddress, SetPinExpansion_FunctionAddress, "bPrintPythonCommand");
		SetPinExpansion_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetPinExpansion_FunctionAddress, "bPrintPythonCommand");
		SetPinExpansion_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinExpansion_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinExpansion_ReturnValue_PropertyAddress, SetPinExpansion_FunctionAddress, "ReturnValue");
		SetPinExpansion_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPinExpansion_FunctionAddress, "ReturnValue");
		SetPinExpansion_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinExpansion_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetPinExpansion_IsValid = SetPinExpansion_FunctionAddress != IntPtr.Zero && SetPinExpansion_InPinPath_IsValid && SetPinExpansion_bIsExpanded_IsValid && SetPinExpansion_bSetupUndoRedo_IsValid && SetPinExpansion_bPrintPythonCommand_IsValid && SetPinExpansion_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetPinExpansion", SetPinExpansion_IsValid);
		SetPinDefaultValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPinDefaultValue");
		SetPinDefaultValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPinDefaultValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPinDefaultValue_InPinPath_PropertyAddress, SetPinDefaultValue_FunctionAddress, "InPinPath");
		SetPinDefaultValue_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(SetPinDefaultValue_FunctionAddress, "InPinPath");
		SetPinDefaultValue_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinDefaultValue_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinDefaultValue_InDefaultValue_PropertyAddress, SetPinDefaultValue_FunctionAddress, "InDefaultValue");
		SetPinDefaultValue_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPinDefaultValue_FunctionAddress, "InDefaultValue");
		SetPinDefaultValue_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinDefaultValue_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinDefaultValue_bResizeArrays_PropertyAddress, SetPinDefaultValue_FunctionAddress, "bResizeArrays");
		SetPinDefaultValue_bResizeArrays_Offset = NativeReflectionCached.GetPropertyOffset(SetPinDefaultValue_FunctionAddress, "bResizeArrays");
		SetPinDefaultValue_bResizeArrays_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinDefaultValue_FunctionAddress, "bResizeArrays", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinDefaultValue_bSetupUndoRedo_PropertyAddress, SetPinDefaultValue_FunctionAddress, "bSetupUndoRedo");
		SetPinDefaultValue_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetPinDefaultValue_FunctionAddress, "bSetupUndoRedo");
		SetPinDefaultValue_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinDefaultValue_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinDefaultValue_bMergeUndoAction_PropertyAddress, SetPinDefaultValue_FunctionAddress, "bMergeUndoAction");
		SetPinDefaultValue_bMergeUndoAction_Offset = NativeReflectionCached.GetPropertyOffset(SetPinDefaultValue_FunctionAddress, "bMergeUndoAction");
		SetPinDefaultValue_bMergeUndoAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinDefaultValue_FunctionAddress, "bMergeUndoAction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinDefaultValue_bPrintPythonCommand_PropertyAddress, SetPinDefaultValue_FunctionAddress, "bPrintPythonCommand");
		SetPinDefaultValue_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetPinDefaultValue_FunctionAddress, "bPrintPythonCommand");
		SetPinDefaultValue_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinDefaultValue_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPinDefaultValue_ReturnValue_PropertyAddress, SetPinDefaultValue_FunctionAddress, "ReturnValue");
		SetPinDefaultValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPinDefaultValue_FunctionAddress, "ReturnValue");
		SetPinDefaultValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPinDefaultValue_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetPinDefaultValue_IsValid = SetPinDefaultValue_FunctionAddress != IntPtr.Zero && SetPinDefaultValue_InPinPath_IsValid && SetPinDefaultValue_InDefaultValue_IsValid && SetPinDefaultValue_bResizeArrays_IsValid && SetPinDefaultValue_bSetupUndoRedo_IsValid && SetPinDefaultValue_bMergeUndoAction_IsValid && SetPinDefaultValue_bPrintPythonCommand_IsValid && SetPinDefaultValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetPinDefaultValue", SetPinDefaultValue_IsValid);
		SetNodeSizeByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodeSizeByName");
		SetNodeSizeByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeSizeByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSizeByName_InNodeName_PropertyAddress, SetNodeSizeByName_FunctionAddress, "InNodeName");
		SetNodeSizeByName_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSizeByName_FunctionAddress, "InNodeName");
		SetNodeSizeByName_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSizeByName_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSizeByName_InSize_PropertyAddress, SetNodeSizeByName_FunctionAddress, "InSize");
		SetNodeSizeByName_InSize_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSizeByName_FunctionAddress, "InSize");
		SetNodeSizeByName_InSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSizeByName_FunctionAddress, "InSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSizeByName_bSetupUndoRedo_PropertyAddress, SetNodeSizeByName_FunctionAddress, "bSetupUndoRedo");
		SetNodeSizeByName_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSizeByName_FunctionAddress, "bSetupUndoRedo");
		SetNodeSizeByName_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSizeByName_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSizeByName_bMergeUndoAction_PropertyAddress, SetNodeSizeByName_FunctionAddress, "bMergeUndoAction");
		SetNodeSizeByName_bMergeUndoAction_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSizeByName_FunctionAddress, "bMergeUndoAction");
		SetNodeSizeByName_bMergeUndoAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSizeByName_FunctionAddress, "bMergeUndoAction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSizeByName_bPrintPythonCommand_PropertyAddress, SetNodeSizeByName_FunctionAddress, "bPrintPythonCommand");
		SetNodeSizeByName_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSizeByName_FunctionAddress, "bPrintPythonCommand");
		SetNodeSizeByName_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSizeByName_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSizeByName_ReturnValue_PropertyAddress, SetNodeSizeByName_FunctionAddress, "ReturnValue");
		SetNodeSizeByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSizeByName_FunctionAddress, "ReturnValue");
		SetNodeSizeByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSizeByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodeSizeByName_IsValid = SetNodeSizeByName_FunctionAddress != IntPtr.Zero && SetNodeSizeByName_InNodeName_IsValid && SetNodeSizeByName_InSize_IsValid && SetNodeSizeByName_bSetupUndoRedo_IsValid && SetNodeSizeByName_bMergeUndoAction_IsValid && SetNodeSizeByName_bPrintPythonCommand_IsValid && SetNodeSizeByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetNodeSizeByName", SetNodeSizeByName_IsValid);
		SetNodeSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodeSize");
		SetNodeSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSize_InNode_PropertyAddress, SetNodeSize_FunctionAddress, "InNode");
		SetNodeSize_InNode_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSize_FunctionAddress, "InNode");
		SetNodeSize_InNode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSize_FunctionAddress, "InNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSize_InSize_PropertyAddress, SetNodeSize_FunctionAddress, "InSize");
		SetNodeSize_InSize_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSize_FunctionAddress, "InSize");
		SetNodeSize_InSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSize_FunctionAddress, "InSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSize_bSetupUndoRedo_PropertyAddress, SetNodeSize_FunctionAddress, "bSetupUndoRedo");
		SetNodeSize_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSize_FunctionAddress, "bSetupUndoRedo");
		SetNodeSize_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSize_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSize_bMergeUndoAction_PropertyAddress, SetNodeSize_FunctionAddress, "bMergeUndoAction");
		SetNodeSize_bMergeUndoAction_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSize_FunctionAddress, "bMergeUndoAction");
		SetNodeSize_bMergeUndoAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSize_FunctionAddress, "bMergeUndoAction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSize_bPrintPythonCommand_PropertyAddress, SetNodeSize_FunctionAddress, "bPrintPythonCommand");
		SetNodeSize_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSize_FunctionAddress, "bPrintPythonCommand");
		SetNodeSize_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSize_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSize_ReturnValue_PropertyAddress, SetNodeSize_FunctionAddress, "ReturnValue");
		SetNodeSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSize_FunctionAddress, "ReturnValue");
		SetNodeSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSize_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodeSize_IsValid = SetNodeSize_FunctionAddress != IntPtr.Zero && SetNodeSize_InNode_IsValid && SetNodeSize_InSize_IsValid && SetNodeSize_bSetupUndoRedo_IsValid && SetNodeSize_bMergeUndoAction_IsValid && SetNodeSize_bPrintPythonCommand_IsValid && SetNodeSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetNodeSize", SetNodeSize_IsValid);
		SetNodeSelection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodeSelection");
		SetNodeSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSelection_InNodeNames_PropertyAddress, SetNodeSelection_FunctionAddress, "InNodeNames");
		SetNodeSelection_InNodeNames_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSelection_FunctionAddress, "InNodeNames");
		SetNodeSelection_InNodeNames_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSelection_FunctionAddress, "InNodeNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSelection_bSetupUndoRedo_PropertyAddress, SetNodeSelection_FunctionAddress, "bSetupUndoRedo");
		SetNodeSelection_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSelection_FunctionAddress, "bSetupUndoRedo");
		SetNodeSelection_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSelection_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSelection_bPrintPythonCommand_PropertyAddress, SetNodeSelection_FunctionAddress, "bPrintPythonCommand");
		SetNodeSelection_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSelection_FunctionAddress, "bPrintPythonCommand");
		SetNodeSelection_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSelection_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeSelection_ReturnValue_PropertyAddress, SetNodeSelection_FunctionAddress, "ReturnValue");
		SetNodeSelection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeSelection_FunctionAddress, "ReturnValue");
		SetNodeSelection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeSelection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodeSelection_IsValid = SetNodeSelection_FunctionAddress != IntPtr.Zero && SetNodeSelection_InNodeNames_IsValid && SetNodeSelection_bSetupUndoRedo_IsValid && SetNodeSelection_bPrintPythonCommand_IsValid && SetNodeSelection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetNodeSelection", SetNodeSelection_IsValid);
		SetNodePositionByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodePositionByName");
		SetNodePositionByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodePositionByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodePositionByName_InNodeName_PropertyAddress, SetNodePositionByName_FunctionAddress, "InNodeName");
		SetNodePositionByName_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(SetNodePositionByName_FunctionAddress, "InNodeName");
		SetNodePositionByName_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodePositionByName_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodePositionByName_InPosition_PropertyAddress, SetNodePositionByName_FunctionAddress, "InPosition");
		SetNodePositionByName_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetNodePositionByName_FunctionAddress, "InPosition");
		SetNodePositionByName_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodePositionByName_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodePositionByName_bSetupUndoRedo_PropertyAddress, SetNodePositionByName_FunctionAddress, "bSetupUndoRedo");
		SetNodePositionByName_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetNodePositionByName_FunctionAddress, "bSetupUndoRedo");
		SetNodePositionByName_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodePositionByName_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodePositionByName_bMergeUndoAction_PropertyAddress, SetNodePositionByName_FunctionAddress, "bMergeUndoAction");
		SetNodePositionByName_bMergeUndoAction_Offset = NativeReflectionCached.GetPropertyOffset(SetNodePositionByName_FunctionAddress, "bMergeUndoAction");
		SetNodePositionByName_bMergeUndoAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodePositionByName_FunctionAddress, "bMergeUndoAction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodePositionByName_bPrintPythonCommand_PropertyAddress, SetNodePositionByName_FunctionAddress, "bPrintPythonCommand");
		SetNodePositionByName_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetNodePositionByName_FunctionAddress, "bPrintPythonCommand");
		SetNodePositionByName_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodePositionByName_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodePositionByName_ReturnValue_PropertyAddress, SetNodePositionByName_FunctionAddress, "ReturnValue");
		SetNodePositionByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodePositionByName_FunctionAddress, "ReturnValue");
		SetNodePositionByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodePositionByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodePositionByName_IsValid = SetNodePositionByName_FunctionAddress != IntPtr.Zero && SetNodePositionByName_InNodeName_IsValid && SetNodePositionByName_InPosition_IsValid && SetNodePositionByName_bSetupUndoRedo_IsValid && SetNodePositionByName_bMergeUndoAction_IsValid && SetNodePositionByName_bPrintPythonCommand_IsValid && SetNodePositionByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetNodePositionByName", SetNodePositionByName_IsValid);
		SetNodePosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodePosition");
		SetNodePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodePosition_InNode_PropertyAddress, SetNodePosition_FunctionAddress, "InNode");
		SetNodePosition_InNode_Offset = NativeReflectionCached.GetPropertyOffset(SetNodePosition_FunctionAddress, "InNode");
		SetNodePosition_InNode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodePosition_FunctionAddress, "InNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodePosition_InPosition_PropertyAddress, SetNodePosition_FunctionAddress, "InPosition");
		SetNodePosition_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetNodePosition_FunctionAddress, "InPosition");
		SetNodePosition_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodePosition_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodePosition_bSetupUndoRedo_PropertyAddress, SetNodePosition_FunctionAddress, "bSetupUndoRedo");
		SetNodePosition_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetNodePosition_FunctionAddress, "bSetupUndoRedo");
		SetNodePosition_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodePosition_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodePosition_bMergeUndoAction_PropertyAddress, SetNodePosition_FunctionAddress, "bMergeUndoAction");
		SetNodePosition_bMergeUndoAction_Offset = NativeReflectionCached.GetPropertyOffset(SetNodePosition_FunctionAddress, "bMergeUndoAction");
		SetNodePosition_bMergeUndoAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodePosition_FunctionAddress, "bMergeUndoAction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodePosition_bPrintPythonCommand_PropertyAddress, SetNodePosition_FunctionAddress, "bPrintPythonCommand");
		SetNodePosition_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetNodePosition_FunctionAddress, "bPrintPythonCommand");
		SetNodePosition_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodePosition_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodePosition_ReturnValue_PropertyAddress, SetNodePosition_FunctionAddress, "ReturnValue");
		SetNodePosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodePosition_FunctionAddress, "ReturnValue");
		SetNodePosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodePosition_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodePosition_IsValid = SetNodePosition_FunctionAddress != IntPtr.Zero && SetNodePosition_InNode_IsValid && SetNodePosition_InPosition_IsValid && SetNodePosition_bSetupUndoRedo_IsValid && SetNodePosition_bMergeUndoAction_IsValid && SetNodePosition_bPrintPythonCommand_IsValid && SetNodePosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetNodePosition", SetNodePosition_IsValid);
		SetNodeKeywordsByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodeKeywordsByName");
		SetNodeKeywordsByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeKeywordsByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeKeywordsByName_InNodeName_PropertyAddress, SetNodeKeywordsByName_FunctionAddress, "InNodeName");
		SetNodeKeywordsByName_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeKeywordsByName_FunctionAddress, "InNodeName");
		SetNodeKeywordsByName_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeKeywordsByName_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeKeywordsByName_InKeywords_PropertyAddress, SetNodeKeywordsByName_FunctionAddress, "InKeywords");
		SetNodeKeywordsByName_InKeywords_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeKeywordsByName_FunctionAddress, "InKeywords");
		SetNodeKeywordsByName_InKeywords_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeKeywordsByName_FunctionAddress, "InKeywords", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeKeywordsByName_bSetupUndoRedo_PropertyAddress, SetNodeKeywordsByName_FunctionAddress, "bSetupUndoRedo");
		SetNodeKeywordsByName_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeKeywordsByName_FunctionAddress, "bSetupUndoRedo");
		SetNodeKeywordsByName_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeKeywordsByName_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeKeywordsByName_bMergeUndoAction_PropertyAddress, SetNodeKeywordsByName_FunctionAddress, "bMergeUndoAction");
		SetNodeKeywordsByName_bMergeUndoAction_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeKeywordsByName_FunctionAddress, "bMergeUndoAction");
		SetNodeKeywordsByName_bMergeUndoAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeKeywordsByName_FunctionAddress, "bMergeUndoAction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeKeywordsByName_ReturnValue_PropertyAddress, SetNodeKeywordsByName_FunctionAddress, "ReturnValue");
		SetNodeKeywordsByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeKeywordsByName_FunctionAddress, "ReturnValue");
		SetNodeKeywordsByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeKeywordsByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodeKeywordsByName_IsValid = SetNodeKeywordsByName_FunctionAddress != IntPtr.Zero && SetNodeKeywordsByName_InNodeName_IsValid && SetNodeKeywordsByName_InKeywords_IsValid && SetNodeKeywordsByName_bSetupUndoRedo_IsValid && SetNodeKeywordsByName_bMergeUndoAction_IsValid && SetNodeKeywordsByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetNodeKeywordsByName", SetNodeKeywordsByName_IsValid);
		SetNodeKeywords_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodeKeywords");
		SetNodeKeywords_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeKeywords_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeKeywords_InNode_PropertyAddress, SetNodeKeywords_FunctionAddress, "InNode");
		SetNodeKeywords_InNode_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeKeywords_FunctionAddress, "InNode");
		SetNodeKeywords_InNode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeKeywords_FunctionAddress, "InNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeKeywords_InKeywords_PropertyAddress, SetNodeKeywords_FunctionAddress, "InKeywords");
		SetNodeKeywords_InKeywords_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeKeywords_FunctionAddress, "InKeywords");
		SetNodeKeywords_InKeywords_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeKeywords_FunctionAddress, "InKeywords", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeKeywords_bSetupUndoRedo_PropertyAddress, SetNodeKeywords_FunctionAddress, "bSetupUndoRedo");
		SetNodeKeywords_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeKeywords_FunctionAddress, "bSetupUndoRedo");
		SetNodeKeywords_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeKeywords_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeKeywords_bMergeUndoAction_PropertyAddress, SetNodeKeywords_FunctionAddress, "bMergeUndoAction");
		SetNodeKeywords_bMergeUndoAction_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeKeywords_FunctionAddress, "bMergeUndoAction");
		SetNodeKeywords_bMergeUndoAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeKeywords_FunctionAddress, "bMergeUndoAction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeKeywords_bPrintPythonCommand_PropertyAddress, SetNodeKeywords_FunctionAddress, "bPrintPythonCommand");
		SetNodeKeywords_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeKeywords_FunctionAddress, "bPrintPythonCommand");
		SetNodeKeywords_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeKeywords_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeKeywords_ReturnValue_PropertyAddress, SetNodeKeywords_FunctionAddress, "ReturnValue");
		SetNodeKeywords_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeKeywords_FunctionAddress, "ReturnValue");
		SetNodeKeywords_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeKeywords_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodeKeywords_IsValid = SetNodeKeywords_FunctionAddress != IntPtr.Zero && SetNodeKeywords_InNode_IsValid && SetNodeKeywords_InKeywords_IsValid && SetNodeKeywords_bSetupUndoRedo_IsValid && SetNodeKeywords_bMergeUndoAction_IsValid && SetNodeKeywords_bPrintPythonCommand_IsValid && SetNodeKeywords_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetNodeKeywords", SetNodeKeywords_IsValid);
		SetNodeDescriptionByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodeDescriptionByName");
		SetNodeDescriptionByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeDescriptionByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeDescriptionByName_InNodeName_PropertyAddress, SetNodeDescriptionByName_FunctionAddress, "InNodeName");
		SetNodeDescriptionByName_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeDescriptionByName_FunctionAddress, "InNodeName");
		SetNodeDescriptionByName_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeDescriptionByName_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeDescriptionByName_InDescription_PropertyAddress, SetNodeDescriptionByName_FunctionAddress, "InDescription");
		SetNodeDescriptionByName_InDescription_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeDescriptionByName_FunctionAddress, "InDescription");
		SetNodeDescriptionByName_InDescription_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeDescriptionByName_FunctionAddress, "InDescription", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeDescriptionByName_bSetupUndoRedo_PropertyAddress, SetNodeDescriptionByName_FunctionAddress, "bSetupUndoRedo");
		SetNodeDescriptionByName_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeDescriptionByName_FunctionAddress, "bSetupUndoRedo");
		SetNodeDescriptionByName_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeDescriptionByName_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeDescriptionByName_bMergeUndoAction_PropertyAddress, SetNodeDescriptionByName_FunctionAddress, "bMergeUndoAction");
		SetNodeDescriptionByName_bMergeUndoAction_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeDescriptionByName_FunctionAddress, "bMergeUndoAction");
		SetNodeDescriptionByName_bMergeUndoAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeDescriptionByName_FunctionAddress, "bMergeUndoAction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeDescriptionByName_ReturnValue_PropertyAddress, SetNodeDescriptionByName_FunctionAddress, "ReturnValue");
		SetNodeDescriptionByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeDescriptionByName_FunctionAddress, "ReturnValue");
		SetNodeDescriptionByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeDescriptionByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodeDescriptionByName_IsValid = SetNodeDescriptionByName_FunctionAddress != IntPtr.Zero && SetNodeDescriptionByName_InNodeName_IsValid && SetNodeDescriptionByName_InDescription_IsValid && SetNodeDescriptionByName_bSetupUndoRedo_IsValid && SetNodeDescriptionByName_bMergeUndoAction_IsValid && SetNodeDescriptionByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetNodeDescriptionByName", SetNodeDescriptionByName_IsValid);
		SetNodeDescription_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodeDescription");
		SetNodeDescription_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeDescription_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeDescription_InNode_PropertyAddress, SetNodeDescription_FunctionAddress, "InNode");
		SetNodeDescription_InNode_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeDescription_FunctionAddress, "InNode");
		SetNodeDescription_InNode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeDescription_FunctionAddress, "InNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeDescription_InDescription_PropertyAddress, SetNodeDescription_FunctionAddress, "InDescription");
		SetNodeDescription_InDescription_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeDescription_FunctionAddress, "InDescription");
		SetNodeDescription_InDescription_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeDescription_FunctionAddress, "InDescription", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeDescription_bSetupUndoRedo_PropertyAddress, SetNodeDescription_FunctionAddress, "bSetupUndoRedo");
		SetNodeDescription_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeDescription_FunctionAddress, "bSetupUndoRedo");
		SetNodeDescription_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeDescription_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeDescription_bMergeUndoAction_PropertyAddress, SetNodeDescription_FunctionAddress, "bMergeUndoAction");
		SetNodeDescription_bMergeUndoAction_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeDescription_FunctionAddress, "bMergeUndoAction");
		SetNodeDescription_bMergeUndoAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeDescription_FunctionAddress, "bMergeUndoAction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeDescription_bPrintPythonCommand_PropertyAddress, SetNodeDescription_FunctionAddress, "bPrintPythonCommand");
		SetNodeDescription_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeDescription_FunctionAddress, "bPrintPythonCommand");
		SetNodeDescription_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeDescription_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeDescription_ReturnValue_PropertyAddress, SetNodeDescription_FunctionAddress, "ReturnValue");
		SetNodeDescription_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeDescription_FunctionAddress, "ReturnValue");
		SetNodeDescription_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeDescription_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodeDescription_IsValid = SetNodeDescription_FunctionAddress != IntPtr.Zero && SetNodeDescription_InNode_IsValid && SetNodeDescription_InDescription_IsValid && SetNodeDescription_bSetupUndoRedo_IsValid && SetNodeDescription_bMergeUndoAction_IsValid && SetNodeDescription_bPrintPythonCommand_IsValid && SetNodeDescription_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetNodeDescription", SetNodeDescription_IsValid);
		SetNodeColorByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodeColorByName");
		SetNodeColorByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeColorByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeColorByName_InNodeName_PropertyAddress, SetNodeColorByName_FunctionAddress, "InNodeName");
		SetNodeColorByName_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeColorByName_FunctionAddress, "InNodeName");
		SetNodeColorByName_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeColorByName_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeColorByName_InColor_PropertyAddress, SetNodeColorByName_FunctionAddress, "InColor");
		SetNodeColorByName_InColor_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeColorByName_FunctionAddress, "InColor");
		SetNodeColorByName_InColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeColorByName_FunctionAddress, "InColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeColorByName_bSetupUndoRedo_PropertyAddress, SetNodeColorByName_FunctionAddress, "bSetupUndoRedo");
		SetNodeColorByName_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeColorByName_FunctionAddress, "bSetupUndoRedo");
		SetNodeColorByName_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeColorByName_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeColorByName_bMergeUndoAction_PropertyAddress, SetNodeColorByName_FunctionAddress, "bMergeUndoAction");
		SetNodeColorByName_bMergeUndoAction_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeColorByName_FunctionAddress, "bMergeUndoAction");
		SetNodeColorByName_bMergeUndoAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeColorByName_FunctionAddress, "bMergeUndoAction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeColorByName_ReturnValue_PropertyAddress, SetNodeColorByName_FunctionAddress, "ReturnValue");
		SetNodeColorByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeColorByName_FunctionAddress, "ReturnValue");
		SetNodeColorByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeColorByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodeColorByName_IsValid = SetNodeColorByName_FunctionAddress != IntPtr.Zero && SetNodeColorByName_InNodeName_IsValid && SetNodeColorByName_InColor_IsValid && SetNodeColorByName_bSetupUndoRedo_IsValid && SetNodeColorByName_bMergeUndoAction_IsValid && SetNodeColorByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetNodeColorByName", SetNodeColorByName_IsValid);
		SetNodeColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodeColor");
		SetNodeColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeColor_InNode_PropertyAddress, SetNodeColor_FunctionAddress, "InNode");
		SetNodeColor_InNode_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeColor_FunctionAddress, "InNode");
		SetNodeColor_InNode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeColor_FunctionAddress, "InNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeColor_InColor_PropertyAddress, SetNodeColor_FunctionAddress, "InColor");
		SetNodeColor_InColor_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeColor_FunctionAddress, "InColor");
		SetNodeColor_InColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeColor_FunctionAddress, "InColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeColor_bSetupUndoRedo_PropertyAddress, SetNodeColor_FunctionAddress, "bSetupUndoRedo");
		SetNodeColor_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeColor_FunctionAddress, "bSetupUndoRedo");
		SetNodeColor_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeColor_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeColor_bMergeUndoAction_PropertyAddress, SetNodeColor_FunctionAddress, "bMergeUndoAction");
		SetNodeColor_bMergeUndoAction_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeColor_FunctionAddress, "bMergeUndoAction");
		SetNodeColor_bMergeUndoAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeColor_FunctionAddress, "bMergeUndoAction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeColor_bPrintPythonCommand_PropertyAddress, SetNodeColor_FunctionAddress, "bPrintPythonCommand");
		SetNodeColor_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeColor_FunctionAddress, "bPrintPythonCommand");
		SetNodeColor_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeColor_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeColor_ReturnValue_PropertyAddress, SetNodeColor_FunctionAddress, "ReturnValue");
		SetNodeColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeColor_FunctionAddress, "ReturnValue");
		SetNodeColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeColor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodeColor_IsValid = SetNodeColor_FunctionAddress != IntPtr.Zero && SetNodeColor_InNode_IsValid && SetNodeColor_InColor_IsValid && SetNodeColor_bSetupUndoRedo_IsValid && SetNodeColor_bMergeUndoAction_IsValid && SetNodeColor_bPrintPythonCommand_IsValid && SetNodeColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetNodeColor", SetNodeColor_IsValid);
		SetNodeCategoryByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodeCategoryByName");
		SetNodeCategoryByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeCategoryByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeCategoryByName_InNodeName_PropertyAddress, SetNodeCategoryByName_FunctionAddress, "InNodeName");
		SetNodeCategoryByName_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeCategoryByName_FunctionAddress, "InNodeName");
		SetNodeCategoryByName_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeCategoryByName_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeCategoryByName_InCategory_PropertyAddress, SetNodeCategoryByName_FunctionAddress, "InCategory");
		SetNodeCategoryByName_InCategory_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeCategoryByName_FunctionAddress, "InCategory");
		SetNodeCategoryByName_InCategory_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeCategoryByName_FunctionAddress, "InCategory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeCategoryByName_bSetupUndoRedo_PropertyAddress, SetNodeCategoryByName_FunctionAddress, "bSetupUndoRedo");
		SetNodeCategoryByName_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeCategoryByName_FunctionAddress, "bSetupUndoRedo");
		SetNodeCategoryByName_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeCategoryByName_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeCategoryByName_bMergeUndoAction_PropertyAddress, SetNodeCategoryByName_FunctionAddress, "bMergeUndoAction");
		SetNodeCategoryByName_bMergeUndoAction_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeCategoryByName_FunctionAddress, "bMergeUndoAction");
		SetNodeCategoryByName_bMergeUndoAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeCategoryByName_FunctionAddress, "bMergeUndoAction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeCategoryByName_ReturnValue_PropertyAddress, SetNodeCategoryByName_FunctionAddress, "ReturnValue");
		SetNodeCategoryByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeCategoryByName_FunctionAddress, "ReturnValue");
		SetNodeCategoryByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeCategoryByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodeCategoryByName_IsValid = SetNodeCategoryByName_FunctionAddress != IntPtr.Zero && SetNodeCategoryByName_InNodeName_IsValid && SetNodeCategoryByName_InCategory_IsValid && SetNodeCategoryByName_bSetupUndoRedo_IsValid && SetNodeCategoryByName_bMergeUndoAction_IsValid && SetNodeCategoryByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetNodeCategoryByName", SetNodeCategoryByName_IsValid);
		SetNodeCategory_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNodeCategory");
		SetNodeCategory_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeCategory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeCategory_InNode_PropertyAddress, SetNodeCategory_FunctionAddress, "InNode");
		SetNodeCategory_InNode_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeCategory_FunctionAddress, "InNode");
		SetNodeCategory_InNode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeCategory_FunctionAddress, "InNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeCategory_InCategory_PropertyAddress, SetNodeCategory_FunctionAddress, "InCategory");
		SetNodeCategory_InCategory_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeCategory_FunctionAddress, "InCategory");
		SetNodeCategory_InCategory_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeCategory_FunctionAddress, "InCategory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeCategory_bSetupUndoRedo_PropertyAddress, SetNodeCategory_FunctionAddress, "bSetupUndoRedo");
		SetNodeCategory_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeCategory_FunctionAddress, "bSetupUndoRedo");
		SetNodeCategory_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeCategory_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeCategory_bMergeUndoAction_PropertyAddress, SetNodeCategory_FunctionAddress, "bMergeUndoAction");
		SetNodeCategory_bMergeUndoAction_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeCategory_FunctionAddress, "bMergeUndoAction");
		SetNodeCategory_bMergeUndoAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeCategory_FunctionAddress, "bMergeUndoAction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeCategory_bPrintPythonCommand_PropertyAddress, SetNodeCategory_FunctionAddress, "bPrintPythonCommand");
		SetNodeCategory_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeCategory_FunctionAddress, "bPrintPythonCommand");
		SetNodeCategory_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeCategory_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeCategory_ReturnValue_PropertyAddress, SetNodeCategory_FunctionAddress, "ReturnValue");
		SetNodeCategory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeCategory_FunctionAddress, "ReturnValue");
		SetNodeCategory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeCategory_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodeCategory_IsValid = SetNodeCategory_FunctionAddress != IntPtr.Zero && SetNodeCategory_InNode_IsValid && SetNodeCategory_InCategory_IsValid && SetNodeCategory_bSetupUndoRedo_IsValid && SetNodeCategory_bMergeUndoAction_IsValid && SetNodeCategory_bPrintPythonCommand_IsValid && SetNodeCategory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetNodeCategory", SetNodeCategory_IsValid);
		SetLocalVariableTypeFromObjectPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLocalVariableTypeFromObjectPath");
		SetLocalVariableTypeFromObjectPath_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocalVariableTypeFromObjectPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableTypeFromObjectPath_InVariableName_PropertyAddress, SetLocalVariableTypeFromObjectPath_FunctionAddress, "InVariableName");
		SetLocalVariableTypeFromObjectPath_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableTypeFromObjectPath_FunctionAddress, "InVariableName");
		SetLocalVariableTypeFromObjectPath_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableTypeFromObjectPath_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableTypeFromObjectPath_InCPPType_PropertyAddress, SetLocalVariableTypeFromObjectPath_FunctionAddress, "InCPPType");
		SetLocalVariableTypeFromObjectPath_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableTypeFromObjectPath_FunctionAddress, "InCPPType");
		SetLocalVariableTypeFromObjectPath_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableTypeFromObjectPath_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableTypeFromObjectPath_InCPPTypeObjectPath_PropertyAddress, SetLocalVariableTypeFromObjectPath_FunctionAddress, "InCPPTypeObjectPath");
		SetLocalVariableTypeFromObjectPath_InCPPTypeObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableTypeFromObjectPath_FunctionAddress, "InCPPTypeObjectPath");
		SetLocalVariableTypeFromObjectPath_InCPPTypeObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableTypeFromObjectPath_FunctionAddress, "InCPPTypeObjectPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableTypeFromObjectPath_bSetupUndoRedo_PropertyAddress, SetLocalVariableTypeFromObjectPath_FunctionAddress, "bSetupUndoRedo");
		SetLocalVariableTypeFromObjectPath_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableTypeFromObjectPath_FunctionAddress, "bSetupUndoRedo");
		SetLocalVariableTypeFromObjectPath_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableTypeFromObjectPath_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableTypeFromObjectPath_bPrintPythonCommand_PropertyAddress, SetLocalVariableTypeFromObjectPath_FunctionAddress, "bPrintPythonCommand");
		SetLocalVariableTypeFromObjectPath_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableTypeFromObjectPath_FunctionAddress, "bPrintPythonCommand");
		SetLocalVariableTypeFromObjectPath_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableTypeFromObjectPath_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableTypeFromObjectPath_ReturnValue_PropertyAddress, SetLocalVariableTypeFromObjectPath_FunctionAddress, "ReturnValue");
		SetLocalVariableTypeFromObjectPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableTypeFromObjectPath_FunctionAddress, "ReturnValue");
		SetLocalVariableTypeFromObjectPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableTypeFromObjectPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetLocalVariableTypeFromObjectPath_IsValid = SetLocalVariableTypeFromObjectPath_FunctionAddress != IntPtr.Zero && SetLocalVariableTypeFromObjectPath_InVariableName_IsValid && SetLocalVariableTypeFromObjectPath_InCPPType_IsValid && SetLocalVariableTypeFromObjectPath_InCPPTypeObjectPath_IsValid && SetLocalVariableTypeFromObjectPath_bSetupUndoRedo_IsValid && SetLocalVariableTypeFromObjectPath_bPrintPythonCommand_IsValid && SetLocalVariableTypeFromObjectPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetLocalVariableTypeFromObjectPath", SetLocalVariableTypeFromObjectPath_IsValid);
		SetLocalVariableType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLocalVariableType");
		SetLocalVariableType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocalVariableType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableType_InVariableName_PropertyAddress, SetLocalVariableType_FunctionAddress, "InVariableName");
		SetLocalVariableType_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableType_FunctionAddress, "InVariableName");
		SetLocalVariableType_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableType_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableType_InCPPType_PropertyAddress, SetLocalVariableType_FunctionAddress, "InCPPType");
		SetLocalVariableType_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableType_FunctionAddress, "InCPPType");
		SetLocalVariableType_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableType_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableType_InCPPTypeObject_PropertyAddress, SetLocalVariableType_FunctionAddress, "InCPPTypeObject");
		SetLocalVariableType_InCPPTypeObject_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableType_FunctionAddress, "InCPPTypeObject");
		SetLocalVariableType_InCPPTypeObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableType_FunctionAddress, "InCPPTypeObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableType_bSetupUndoRedo_PropertyAddress, SetLocalVariableType_FunctionAddress, "bSetupUndoRedo");
		SetLocalVariableType_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableType_FunctionAddress, "bSetupUndoRedo");
		SetLocalVariableType_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableType_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableType_bPrintPythonCommand_PropertyAddress, SetLocalVariableType_FunctionAddress, "bPrintPythonCommand");
		SetLocalVariableType_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableType_FunctionAddress, "bPrintPythonCommand");
		SetLocalVariableType_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableType_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableType_ReturnValue_PropertyAddress, SetLocalVariableType_FunctionAddress, "ReturnValue");
		SetLocalVariableType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableType_FunctionAddress, "ReturnValue");
		SetLocalVariableType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetLocalVariableType_IsValid = SetLocalVariableType_FunctionAddress != IntPtr.Zero && SetLocalVariableType_InVariableName_IsValid && SetLocalVariableType_InCPPType_IsValid && SetLocalVariableType_InCPPTypeObject_IsValid && SetLocalVariableType_bSetupUndoRedo_IsValid && SetLocalVariableType_bPrintPythonCommand_IsValid && SetLocalVariableType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetLocalVariableType", SetLocalVariableType_IsValid);
		SetLocalVariableDefaultValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLocalVariableDefaultValue");
		SetLocalVariableDefaultValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocalVariableDefaultValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableDefaultValue_InVariableName_PropertyAddress, SetLocalVariableDefaultValue_FunctionAddress, "InVariableName");
		SetLocalVariableDefaultValue_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableDefaultValue_FunctionAddress, "InVariableName");
		SetLocalVariableDefaultValue_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableDefaultValue_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableDefaultValue_InDefaultValue_PropertyAddress, SetLocalVariableDefaultValue_FunctionAddress, "InDefaultValue");
		SetLocalVariableDefaultValue_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableDefaultValue_FunctionAddress, "InDefaultValue");
		SetLocalVariableDefaultValue_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableDefaultValue_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableDefaultValue_bSetupUndoRedo_PropertyAddress, SetLocalVariableDefaultValue_FunctionAddress, "bSetupUndoRedo");
		SetLocalVariableDefaultValue_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableDefaultValue_FunctionAddress, "bSetupUndoRedo");
		SetLocalVariableDefaultValue_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableDefaultValue_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableDefaultValue_bPrintPythonCommand_PropertyAddress, SetLocalVariableDefaultValue_FunctionAddress, "bPrintPythonCommand");
		SetLocalVariableDefaultValue_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableDefaultValue_FunctionAddress, "bPrintPythonCommand");
		SetLocalVariableDefaultValue_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableDefaultValue_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableDefaultValue_bNotify_PropertyAddress, SetLocalVariableDefaultValue_FunctionAddress, "bNotify");
		SetLocalVariableDefaultValue_bNotify_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableDefaultValue_FunctionAddress, "bNotify");
		SetLocalVariableDefaultValue_bNotify_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableDefaultValue_FunctionAddress, "bNotify", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalVariableDefaultValue_ReturnValue_PropertyAddress, SetLocalVariableDefaultValue_FunctionAddress, "ReturnValue");
		SetLocalVariableDefaultValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalVariableDefaultValue_FunctionAddress, "ReturnValue");
		SetLocalVariableDefaultValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalVariableDefaultValue_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetLocalVariableDefaultValue_IsValid = SetLocalVariableDefaultValue_FunctionAddress != IntPtr.Zero && SetLocalVariableDefaultValue_InVariableName_IsValid && SetLocalVariableDefaultValue_InDefaultValue_IsValid && SetLocalVariableDefaultValue_bSetupUndoRedo_IsValid && SetLocalVariableDefaultValue_bPrintPythonCommand_IsValid && SetLocalVariableDefaultValue_bNotify_IsValid && SetLocalVariableDefaultValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetLocalVariableDefaultValue", SetLocalVariableDefaultValue_IsValid);
		SetIsRunningUnitTest_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsRunningUnitTest");
		SetIsRunningUnitTest_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsRunningUnitTest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsRunningUnitTest_bIsRunning_PropertyAddress, SetIsRunningUnitTest_FunctionAddress, "bIsRunning");
		SetIsRunningUnitTest_bIsRunning_Offset = NativeReflectionCached.GetPropertyOffset(SetIsRunningUnitTest_FunctionAddress, "bIsRunning");
		SetIsRunningUnitTest_bIsRunning_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsRunningUnitTest_FunctionAddress, "bIsRunning", Classes.FBoolProperty);
		SetIsRunningUnitTest_IsValid = SetIsRunningUnitTest_FunctionAddress != IntPtr.Zero && SetIsRunningUnitTest_bIsRunning_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetIsRunningUnitTest", SetIsRunningUnitTest_IsValid);
		SetGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGraph");
		SetGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGraph_InGraph_PropertyAddress, SetGraph_FunctionAddress, "InGraph");
		SetGraph_InGraph_Offset = NativeReflectionCached.GetPropertyOffset(SetGraph_FunctionAddress, "InGraph");
		SetGraph_InGraph_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGraph_FunctionAddress, "InGraph", Classes.FObjectProperty);
		SetGraph_IsValid = SetGraph_FunctionAddress != IntPtr.Zero && SetGraph_InGraph_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetGraph", SetGraph_IsValid);
		SetExposedPinIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetExposedPinIndex");
		SetExposedPinIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetExposedPinIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetExposedPinIndex_InPinName_PropertyAddress, SetExposedPinIndex_FunctionAddress, "InPinName");
		SetExposedPinIndex_InPinName_Offset = NativeReflectionCached.GetPropertyOffset(SetExposedPinIndex_FunctionAddress, "InPinName");
		SetExposedPinIndex_InPinName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExposedPinIndex_FunctionAddress, "InPinName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetExposedPinIndex_InNewIndex_PropertyAddress, SetExposedPinIndex_FunctionAddress, "InNewIndex");
		SetExposedPinIndex_InNewIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetExposedPinIndex_FunctionAddress, "InNewIndex");
		SetExposedPinIndex_InNewIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExposedPinIndex_FunctionAddress, "InNewIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetExposedPinIndex_bSetupUndoRedo_PropertyAddress, SetExposedPinIndex_FunctionAddress, "bSetupUndoRedo");
		SetExposedPinIndex_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetExposedPinIndex_FunctionAddress, "bSetupUndoRedo");
		SetExposedPinIndex_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExposedPinIndex_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetExposedPinIndex_bPrintPythonCommand_PropertyAddress, SetExposedPinIndex_FunctionAddress, "bPrintPythonCommand");
		SetExposedPinIndex_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetExposedPinIndex_FunctionAddress, "bPrintPythonCommand");
		SetExposedPinIndex_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExposedPinIndex_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetExposedPinIndex_ReturnValue_PropertyAddress, SetExposedPinIndex_FunctionAddress, "ReturnValue");
		SetExposedPinIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetExposedPinIndex_FunctionAddress, "ReturnValue");
		SetExposedPinIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExposedPinIndex_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetExposedPinIndex_IsValid = SetExposedPinIndex_FunctionAddress != IntPtr.Zero && SetExposedPinIndex_InPinName_IsValid && SetExposedPinIndex_InNewIndex_IsValid && SetExposedPinIndex_bSetupUndoRedo_IsValid && SetExposedPinIndex_bPrintPythonCommand_IsValid && SetExposedPinIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetExposedPinIndex", SetExposedPinIndex_IsValid);
		SetCommentTextByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCommentTextByName");
		SetCommentTextByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCommentTextByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCommentTextByName_InNodeName_PropertyAddress, SetCommentTextByName_FunctionAddress, "InNodeName");
		SetCommentTextByName_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentTextByName_FunctionAddress, "InNodeName");
		SetCommentTextByName_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentTextByName_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCommentTextByName_InCommentText_PropertyAddress, SetCommentTextByName_FunctionAddress, "InCommentText");
		SetCommentTextByName_InCommentText_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentTextByName_FunctionAddress, "InCommentText");
		SetCommentTextByName_InCommentText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentTextByName_FunctionAddress, "InCommentText", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCommentTextByName_InCommentFontSize_PropertyAddress, SetCommentTextByName_FunctionAddress, "InCommentFontSize");
		SetCommentTextByName_InCommentFontSize_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentTextByName_FunctionAddress, "InCommentFontSize");
		SetCommentTextByName_InCommentFontSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentTextByName_FunctionAddress, "InCommentFontSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCommentTextByName_bInCommentBubbleVisible_PropertyAddress, SetCommentTextByName_FunctionAddress, "bInCommentBubbleVisible");
		SetCommentTextByName_bInCommentBubbleVisible_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentTextByName_FunctionAddress, "bInCommentBubbleVisible");
		SetCommentTextByName_bInCommentBubbleVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentTextByName_FunctionAddress, "bInCommentBubbleVisible", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCommentTextByName_bInCommentColorBubble_PropertyAddress, SetCommentTextByName_FunctionAddress, "bInCommentColorBubble");
		SetCommentTextByName_bInCommentColorBubble_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentTextByName_FunctionAddress, "bInCommentColorBubble");
		SetCommentTextByName_bInCommentColorBubble_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentTextByName_FunctionAddress, "bInCommentColorBubble", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCommentTextByName_bSetupUndoRedo_PropertyAddress, SetCommentTextByName_FunctionAddress, "bSetupUndoRedo");
		SetCommentTextByName_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentTextByName_FunctionAddress, "bSetupUndoRedo");
		SetCommentTextByName_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentTextByName_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCommentTextByName_bPrintPythonCommand_PropertyAddress, SetCommentTextByName_FunctionAddress, "bPrintPythonCommand");
		SetCommentTextByName_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentTextByName_FunctionAddress, "bPrintPythonCommand");
		SetCommentTextByName_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentTextByName_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCommentTextByName_ReturnValue_PropertyAddress, SetCommentTextByName_FunctionAddress, "ReturnValue");
		SetCommentTextByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentTextByName_FunctionAddress, "ReturnValue");
		SetCommentTextByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentTextByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCommentTextByName_IsValid = SetCommentTextByName_FunctionAddress != IntPtr.Zero && SetCommentTextByName_InNodeName_IsValid && SetCommentTextByName_InCommentText_IsValid && SetCommentTextByName_InCommentFontSize_IsValid && SetCommentTextByName_bInCommentBubbleVisible_IsValid && SetCommentTextByName_bInCommentColorBubble_IsValid && SetCommentTextByName_bSetupUndoRedo_IsValid && SetCommentTextByName_bPrintPythonCommand_IsValid && SetCommentTextByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetCommentTextByName", SetCommentTextByName_IsValid);
		SetCommentText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCommentText");
		SetCommentText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCommentText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCommentText_InNode_PropertyAddress, SetCommentText_FunctionAddress, "InNode");
		SetCommentText_InNode_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentText_FunctionAddress, "InNode");
		SetCommentText_InNode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentText_FunctionAddress, "InNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCommentText_InCommentText_PropertyAddress, SetCommentText_FunctionAddress, "InCommentText");
		SetCommentText_InCommentText_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentText_FunctionAddress, "InCommentText");
		SetCommentText_InCommentText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentText_FunctionAddress, "InCommentText", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCommentText_InCommentFontSize_PropertyAddress, SetCommentText_FunctionAddress, "InCommentFontSize");
		SetCommentText_InCommentFontSize_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentText_FunctionAddress, "InCommentFontSize");
		SetCommentText_InCommentFontSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentText_FunctionAddress, "InCommentFontSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCommentText_bInCommentBubbleVisible_PropertyAddress, SetCommentText_FunctionAddress, "bInCommentBubbleVisible");
		SetCommentText_bInCommentBubbleVisible_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentText_FunctionAddress, "bInCommentBubbleVisible");
		SetCommentText_bInCommentBubbleVisible_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentText_FunctionAddress, "bInCommentBubbleVisible", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCommentText_bInCommentColorBubble_PropertyAddress, SetCommentText_FunctionAddress, "bInCommentColorBubble");
		SetCommentText_bInCommentColorBubble_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentText_FunctionAddress, "bInCommentColorBubble");
		SetCommentText_bInCommentColorBubble_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentText_FunctionAddress, "bInCommentColorBubble", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCommentText_bSetupUndoRedo_PropertyAddress, SetCommentText_FunctionAddress, "bSetupUndoRedo");
		SetCommentText_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentText_FunctionAddress, "bSetupUndoRedo");
		SetCommentText_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentText_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCommentText_bPrintPythonCommand_PropertyAddress, SetCommentText_FunctionAddress, "bPrintPythonCommand");
		SetCommentText_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentText_FunctionAddress, "bPrintPythonCommand");
		SetCommentText_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentText_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCommentText_ReturnValue_PropertyAddress, SetCommentText_FunctionAddress, "ReturnValue");
		SetCommentText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCommentText_FunctionAddress, "ReturnValue");
		SetCommentText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCommentText_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCommentText_IsValid = SetCommentText_FunctionAddress != IntPtr.Zero && SetCommentText_InNode_IsValid && SetCommentText_InCommentText_IsValid && SetCommentText_InCommentFontSize_IsValid && SetCommentText_bInCommentBubbleVisible_IsValid && SetCommentText_bInCommentColorBubble_IsValid && SetCommentText_bSetupUndoRedo_IsValid && SetCommentText_bPrintPythonCommand_IsValid && SetCommentText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetCommentText", SetCommentText_IsValid);
		SetArrayPinSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetArrayPinSize");
		SetArrayPinSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetArrayPinSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetArrayPinSize_InArrayPinPath_PropertyAddress, SetArrayPinSize_FunctionAddress, "InArrayPinPath");
		SetArrayPinSize_InArrayPinPath_Offset = NativeReflectionCached.GetPropertyOffset(SetArrayPinSize_FunctionAddress, "InArrayPinPath");
		SetArrayPinSize_InArrayPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrayPinSize_FunctionAddress, "InArrayPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetArrayPinSize_InSize_PropertyAddress, SetArrayPinSize_FunctionAddress, "InSize");
		SetArrayPinSize_InSize_Offset = NativeReflectionCached.GetPropertyOffset(SetArrayPinSize_FunctionAddress, "InSize");
		SetArrayPinSize_InSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrayPinSize_FunctionAddress, "InSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetArrayPinSize_InDefaultValue_PropertyAddress, SetArrayPinSize_FunctionAddress, "InDefaultValue");
		SetArrayPinSize_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(SetArrayPinSize_FunctionAddress, "InDefaultValue");
		SetArrayPinSize_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrayPinSize_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetArrayPinSize_bSetupUndoRedo_PropertyAddress, SetArrayPinSize_FunctionAddress, "bSetupUndoRedo");
		SetArrayPinSize_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SetArrayPinSize_FunctionAddress, "bSetupUndoRedo");
		SetArrayPinSize_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrayPinSize_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetArrayPinSize_bPrintPythonCommand_PropertyAddress, SetArrayPinSize_FunctionAddress, "bPrintPythonCommand");
		SetArrayPinSize_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SetArrayPinSize_FunctionAddress, "bPrintPythonCommand");
		SetArrayPinSize_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrayPinSize_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetArrayPinSize_ReturnValue_PropertyAddress, SetArrayPinSize_FunctionAddress, "ReturnValue");
		SetArrayPinSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetArrayPinSize_FunctionAddress, "ReturnValue");
		SetArrayPinSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArrayPinSize_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetArrayPinSize_IsValid = SetArrayPinSize_FunctionAddress != IntPtr.Zero && SetArrayPinSize_InArrayPinPath_IsValid && SetArrayPinSize_InSize_IsValid && SetArrayPinSize_InDefaultValue_IsValid && SetArrayPinSize_bSetupUndoRedo_IsValid && SetArrayPinSize_bPrintPythonCommand_IsValid && SetArrayPinSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SetArrayPinSize", SetArrayPinSize_IsValid);
		SelectNodeByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SelectNodeByName");
		SelectNodeByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectNodeByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectNodeByName_InNodeName_PropertyAddress, SelectNodeByName_FunctionAddress, "InNodeName");
		SelectNodeByName_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(SelectNodeByName_FunctionAddress, "InNodeName");
		SelectNodeByName_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectNodeByName_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectNodeByName_bSelect_PropertyAddress, SelectNodeByName_FunctionAddress, "bSelect");
		SelectNodeByName_bSelect_Offset = NativeReflectionCached.GetPropertyOffset(SelectNodeByName_FunctionAddress, "bSelect");
		SelectNodeByName_bSelect_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectNodeByName_FunctionAddress, "bSelect", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectNodeByName_bSetupUndoRedo_PropertyAddress, SelectNodeByName_FunctionAddress, "bSetupUndoRedo");
		SelectNodeByName_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SelectNodeByName_FunctionAddress, "bSetupUndoRedo");
		SelectNodeByName_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectNodeByName_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectNodeByName_ReturnValue_PropertyAddress, SelectNodeByName_FunctionAddress, "ReturnValue");
		SelectNodeByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SelectNodeByName_FunctionAddress, "ReturnValue");
		SelectNodeByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectNodeByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SelectNodeByName_IsValid = SelectNodeByName_FunctionAddress != IntPtr.Zero && SelectNodeByName_InNodeName_IsValid && SelectNodeByName_bSelect_IsValid && SelectNodeByName_bSetupUndoRedo_IsValid && SelectNodeByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SelectNodeByName", SelectNodeByName_IsValid);
		SelectNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SelectNode");
		SelectNode_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectNode_InNode_PropertyAddress, SelectNode_FunctionAddress, "InNode");
		SelectNode_InNode_Offset = NativeReflectionCached.GetPropertyOffset(SelectNode_FunctionAddress, "InNode");
		SelectNode_InNode_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectNode_FunctionAddress, "InNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectNode_bSelect_PropertyAddress, SelectNode_FunctionAddress, "bSelect");
		SelectNode_bSelect_Offset = NativeReflectionCached.GetPropertyOffset(SelectNode_FunctionAddress, "bSelect");
		SelectNode_bSelect_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectNode_FunctionAddress, "bSelect", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectNode_bSetupUndoRedo_PropertyAddress, SelectNode_FunctionAddress, "bSetupUndoRedo");
		SelectNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(SelectNode_FunctionAddress, "bSetupUndoRedo");
		SelectNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectNode_bPrintPythonCommand_PropertyAddress, SelectNode_FunctionAddress, "bPrintPythonCommand");
		SelectNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(SelectNode_FunctionAddress, "bPrintPythonCommand");
		SelectNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectNode_ReturnValue_PropertyAddress, SelectNode_FunctionAddress, "ReturnValue");
		SelectNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SelectNode_FunctionAddress, "ReturnValue");
		SelectNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SelectNode_IsValid = SelectNode_FunctionAddress != IntPtr.Zero && SelectNode_InNode_IsValid && SelectNode_bSelect_IsValid && SelectNode_bSetupUndoRedo_IsValid && SelectNode_bPrintPythonCommand_IsValid && SelectNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:SelectNode", SelectNode_IsValid);
		ResetPinDefaultValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetPinDefaultValue");
		ResetPinDefaultValue_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetPinDefaultValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetPinDefaultValue_InPinPath_PropertyAddress, ResetPinDefaultValue_FunctionAddress, "InPinPath");
		ResetPinDefaultValue_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(ResetPinDefaultValue_FunctionAddress, "InPinPath");
		ResetPinDefaultValue_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetPinDefaultValue_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetPinDefaultValue_bSetupUndoRedo_PropertyAddress, ResetPinDefaultValue_FunctionAddress, "bSetupUndoRedo");
		ResetPinDefaultValue_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(ResetPinDefaultValue_FunctionAddress, "bSetupUndoRedo");
		ResetPinDefaultValue_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetPinDefaultValue_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetPinDefaultValue_bPrintPythonCommand_PropertyAddress, ResetPinDefaultValue_FunctionAddress, "bPrintPythonCommand");
		ResetPinDefaultValue_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(ResetPinDefaultValue_FunctionAddress, "bPrintPythonCommand");
		ResetPinDefaultValue_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetPinDefaultValue_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetPinDefaultValue_ReturnValue_PropertyAddress, ResetPinDefaultValue_FunctionAddress, "ReturnValue");
		ResetPinDefaultValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ResetPinDefaultValue_FunctionAddress, "ReturnValue");
		ResetPinDefaultValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetPinDefaultValue_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ResetPinDefaultValue_IsValid = ResetPinDefaultValue_FunctionAddress != IntPtr.Zero && ResetPinDefaultValue_InPinPath_IsValid && ResetPinDefaultValue_bSetupUndoRedo_IsValid && ResetPinDefaultValue_bPrintPythonCommand_IsValid && ResetPinDefaultValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:ResetPinDefaultValue", ResetPinDefaultValue_IsValid);
		ReplaceParameterNodeWithVariable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReplaceParameterNodeWithVariable");
		ReplaceParameterNodeWithVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceParameterNodeWithVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceParameterNodeWithVariable_InNodeName_PropertyAddress, ReplaceParameterNodeWithVariable_FunctionAddress, "InNodeName");
		ReplaceParameterNodeWithVariable_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceParameterNodeWithVariable_FunctionAddress, "InNodeName");
		ReplaceParameterNodeWithVariable_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceParameterNodeWithVariable_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceParameterNodeWithVariable_InVariableName_PropertyAddress, ReplaceParameterNodeWithVariable_FunctionAddress, "InVariableName");
		ReplaceParameterNodeWithVariable_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceParameterNodeWithVariable_FunctionAddress, "InVariableName");
		ReplaceParameterNodeWithVariable_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceParameterNodeWithVariable_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceParameterNodeWithVariable_InCPPType_PropertyAddress, ReplaceParameterNodeWithVariable_FunctionAddress, "InCPPType");
		ReplaceParameterNodeWithVariable_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceParameterNodeWithVariable_FunctionAddress, "InCPPType");
		ReplaceParameterNodeWithVariable_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceParameterNodeWithVariable_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceParameterNodeWithVariable_InCPPTypeObject_PropertyAddress, ReplaceParameterNodeWithVariable_FunctionAddress, "InCPPTypeObject");
		ReplaceParameterNodeWithVariable_InCPPTypeObject_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceParameterNodeWithVariable_FunctionAddress, "InCPPTypeObject");
		ReplaceParameterNodeWithVariable_InCPPTypeObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceParameterNodeWithVariable_FunctionAddress, "InCPPTypeObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceParameterNodeWithVariable_bSetupUndoRedo_PropertyAddress, ReplaceParameterNodeWithVariable_FunctionAddress, "bSetupUndoRedo");
		ReplaceParameterNodeWithVariable_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceParameterNodeWithVariable_FunctionAddress, "bSetupUndoRedo");
		ReplaceParameterNodeWithVariable_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceParameterNodeWithVariable_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceParameterNodeWithVariable_ReturnValue_PropertyAddress, ReplaceParameterNodeWithVariable_FunctionAddress, "ReturnValue");
		ReplaceParameterNodeWithVariable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceParameterNodeWithVariable_FunctionAddress, "ReturnValue");
		ReplaceParameterNodeWithVariable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceParameterNodeWithVariable_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ReplaceParameterNodeWithVariable_IsValid = ReplaceParameterNodeWithVariable_FunctionAddress != IntPtr.Zero && ReplaceParameterNodeWithVariable_InNodeName_IsValid && ReplaceParameterNodeWithVariable_InVariableName_IsValid && ReplaceParameterNodeWithVariable_InCPPType_IsValid && ReplaceParameterNodeWithVariable_InCPPTypeObject_IsValid && ReplaceParameterNodeWithVariable_bSetupUndoRedo_IsValid && ReplaceParameterNodeWithVariable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:ReplaceParameterNodeWithVariable", ReplaceParameterNodeWithVariable_IsValid);
		RenameVariable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RenameVariable");
		RenameVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameVariable_InOldName_PropertyAddress, RenameVariable_FunctionAddress, "InOldName");
		RenameVariable_InOldName_Offset = NativeReflectionCached.GetPropertyOffset(RenameVariable_FunctionAddress, "InOldName");
		RenameVariable_InOldName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameVariable_FunctionAddress, "InOldName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameVariable_InNewName_PropertyAddress, RenameVariable_FunctionAddress, "InNewName");
		RenameVariable_InNewName_Offset = NativeReflectionCached.GetPropertyOffset(RenameVariable_FunctionAddress, "InNewName");
		RenameVariable_InNewName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameVariable_FunctionAddress, "InNewName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameVariable_bSetupUndoRedo_PropertyAddress, RenameVariable_FunctionAddress, "bSetupUndoRedo");
		RenameVariable_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(RenameVariable_FunctionAddress, "bSetupUndoRedo");
		RenameVariable_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameVariable_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameVariable_ReturnValue_PropertyAddress, RenameVariable_FunctionAddress, "ReturnValue");
		RenameVariable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameVariable_FunctionAddress, "ReturnValue");
		RenameVariable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameVariable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenameVariable_IsValid = RenameVariable_FunctionAddress != IntPtr.Zero && RenameVariable_InOldName_IsValid && RenameVariable_InNewName_IsValid && RenameVariable_bSetupUndoRedo_IsValid && RenameVariable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:RenameVariable", RenameVariable_IsValid);
		RenameParameter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RenameParameter");
		RenameParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameParameter_InOldName_PropertyAddress, RenameParameter_FunctionAddress, "InOldName");
		RenameParameter_InOldName_Offset = NativeReflectionCached.GetPropertyOffset(RenameParameter_FunctionAddress, "InOldName");
		RenameParameter_InOldName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameParameter_FunctionAddress, "InOldName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameParameter_InNewName_PropertyAddress, RenameParameter_FunctionAddress, "InNewName");
		RenameParameter_InNewName_Offset = NativeReflectionCached.GetPropertyOffset(RenameParameter_FunctionAddress, "InNewName");
		RenameParameter_InNewName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameParameter_FunctionAddress, "InNewName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameParameter_bSetupUndoRedo_PropertyAddress, RenameParameter_FunctionAddress, "bSetupUndoRedo");
		RenameParameter_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(RenameParameter_FunctionAddress, "bSetupUndoRedo");
		RenameParameter_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameParameter_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameParameter_ReturnValue_PropertyAddress, RenameParameter_FunctionAddress, "ReturnValue");
		RenameParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameParameter_FunctionAddress, "ReturnValue");
		RenameParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameParameter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenameParameter_IsValid = RenameParameter_FunctionAddress != IntPtr.Zero && RenameParameter_InOldName_IsValid && RenameParameter_InNewName_IsValid && RenameParameter_bSetupUndoRedo_IsValid && RenameParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:RenameParameter", RenameParameter_IsValid);
		RenameNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RenameNode");
		RenameNode_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameNode_InNode_PropertyAddress, RenameNode_FunctionAddress, "InNode");
		RenameNode_InNode_Offset = NativeReflectionCached.GetPropertyOffset(RenameNode_FunctionAddress, "InNode");
		RenameNode_InNode_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameNode_FunctionAddress, "InNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameNode_InNewName_PropertyAddress, RenameNode_FunctionAddress, "InNewName");
		RenameNode_InNewName_Offset = NativeReflectionCached.GetPropertyOffset(RenameNode_FunctionAddress, "InNewName");
		RenameNode_InNewName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameNode_FunctionAddress, "InNewName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameNode_bSetupUndoRedo_PropertyAddress, RenameNode_FunctionAddress, "bSetupUndoRedo");
		RenameNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(RenameNode_FunctionAddress, "bSetupUndoRedo");
		RenameNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameNode_bPrintPythonCommand_PropertyAddress, RenameNode_FunctionAddress, "bPrintPythonCommand");
		RenameNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(RenameNode_FunctionAddress, "bPrintPythonCommand");
		RenameNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameNode_ReturnValue_PropertyAddress, RenameNode_FunctionAddress, "ReturnValue");
		RenameNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameNode_FunctionAddress, "ReturnValue");
		RenameNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenameNode_IsValid = RenameNode_FunctionAddress != IntPtr.Zero && RenameNode_InNode_IsValid && RenameNode_InNewName_IsValid && RenameNode_bSetupUndoRedo_IsValid && RenameNode_bPrintPythonCommand_IsValid && RenameNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:RenameNode", RenameNode_IsValid);
		RenameLocalVariable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RenameLocalVariable");
		RenameLocalVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameLocalVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameLocalVariable_InVariableName_PropertyAddress, RenameLocalVariable_FunctionAddress, "InVariableName");
		RenameLocalVariable_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(RenameLocalVariable_FunctionAddress, "InVariableName");
		RenameLocalVariable_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameLocalVariable_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameLocalVariable_InNewVariableName_PropertyAddress, RenameLocalVariable_FunctionAddress, "InNewVariableName");
		RenameLocalVariable_InNewVariableName_Offset = NativeReflectionCached.GetPropertyOffset(RenameLocalVariable_FunctionAddress, "InNewVariableName");
		RenameLocalVariable_InNewVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameLocalVariable_FunctionAddress, "InNewVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameLocalVariable_bSetupUndoRedo_PropertyAddress, RenameLocalVariable_FunctionAddress, "bSetupUndoRedo");
		RenameLocalVariable_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(RenameLocalVariable_FunctionAddress, "bSetupUndoRedo");
		RenameLocalVariable_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameLocalVariable_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameLocalVariable_bPrintPythonCommand_PropertyAddress, RenameLocalVariable_FunctionAddress, "bPrintPythonCommand");
		RenameLocalVariable_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(RenameLocalVariable_FunctionAddress, "bPrintPythonCommand");
		RenameLocalVariable_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameLocalVariable_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameLocalVariable_ReturnValue_PropertyAddress, RenameLocalVariable_FunctionAddress, "ReturnValue");
		RenameLocalVariable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameLocalVariable_FunctionAddress, "ReturnValue");
		RenameLocalVariable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameLocalVariable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenameLocalVariable_IsValid = RenameLocalVariable_FunctionAddress != IntPtr.Zero && RenameLocalVariable_InVariableName_IsValid && RenameLocalVariable_InNewVariableName_IsValid && RenameLocalVariable_bSetupUndoRedo_IsValid && RenameLocalVariable_bPrintPythonCommand_IsValid && RenameLocalVariable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:RenameLocalVariable", RenameLocalVariable_IsValid);
		RenameFunction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RenameFunction");
		RenameFunction_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameFunction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameFunction_InOldFunctionName_PropertyAddress, RenameFunction_FunctionAddress, "InOldFunctionName");
		RenameFunction_InOldFunctionName_Offset = NativeReflectionCached.GetPropertyOffset(RenameFunction_FunctionAddress, "InOldFunctionName");
		RenameFunction_InOldFunctionName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameFunction_FunctionAddress, "InOldFunctionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameFunction_InNewFunctionName_PropertyAddress, RenameFunction_FunctionAddress, "InNewFunctionName");
		RenameFunction_InNewFunctionName_Offset = NativeReflectionCached.GetPropertyOffset(RenameFunction_FunctionAddress, "InNewFunctionName");
		RenameFunction_InNewFunctionName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameFunction_FunctionAddress, "InNewFunctionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameFunction_bSetupUndoRedo_PropertyAddress, RenameFunction_FunctionAddress, "bSetupUndoRedo");
		RenameFunction_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(RenameFunction_FunctionAddress, "bSetupUndoRedo");
		RenameFunction_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameFunction_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameFunction_ReturnValue_PropertyAddress, RenameFunction_FunctionAddress, "ReturnValue");
		RenameFunction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameFunction_FunctionAddress, "ReturnValue");
		RenameFunction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameFunction_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenameFunction_IsValid = RenameFunction_FunctionAddress != IntPtr.Zero && RenameFunction_InOldFunctionName_IsValid && RenameFunction_InNewFunctionName_IsValid && RenameFunction_bSetupUndoRedo_IsValid && RenameFunction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:RenameFunction", RenameFunction_IsValid);
		RenameExposedPin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RenameExposedPin");
		RenameExposedPin_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameExposedPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameExposedPin_InOldPinName_PropertyAddress, RenameExposedPin_FunctionAddress, "InOldPinName");
		RenameExposedPin_InOldPinName_Offset = NativeReflectionCached.GetPropertyOffset(RenameExposedPin_FunctionAddress, "InOldPinName");
		RenameExposedPin_InOldPinName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameExposedPin_FunctionAddress, "InOldPinName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameExposedPin_InNewPinName_PropertyAddress, RenameExposedPin_FunctionAddress, "InNewPinName");
		RenameExposedPin_InNewPinName_Offset = NativeReflectionCached.GetPropertyOffset(RenameExposedPin_FunctionAddress, "InNewPinName");
		RenameExposedPin_InNewPinName_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameExposedPin_FunctionAddress, "InNewPinName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameExposedPin_bSetupUndoRedo_PropertyAddress, RenameExposedPin_FunctionAddress, "bSetupUndoRedo");
		RenameExposedPin_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(RenameExposedPin_FunctionAddress, "bSetupUndoRedo");
		RenameExposedPin_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameExposedPin_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameExposedPin_bPrintPythonCommand_PropertyAddress, RenameExposedPin_FunctionAddress, "bPrintPythonCommand");
		RenameExposedPin_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(RenameExposedPin_FunctionAddress, "bPrintPythonCommand");
		RenameExposedPin_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameExposedPin_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameExposedPin_ReturnValue_PropertyAddress, RenameExposedPin_FunctionAddress, "ReturnValue");
		RenameExposedPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameExposedPin_FunctionAddress, "ReturnValue");
		RenameExposedPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameExposedPin_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenameExposedPin_IsValid = RenameExposedPin_FunctionAddress != IntPtr.Zero && RenameExposedPin_InOldPinName_IsValid && RenameExposedPin_InNewPinName_IsValid && RenameExposedPin_bSetupUndoRedo_IsValid && RenameExposedPin_bPrintPythonCommand_IsValid && RenameExposedPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:RenameExposedPin", RenameExposedPin_IsValid);
		RemoveNodeByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveNodeByName");
		RemoveNodeByName_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveNodeByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveNodeByName_InNodeName_PropertyAddress, RemoveNodeByName_FunctionAddress, "InNodeName");
		RemoveNodeByName_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNodeByName_FunctionAddress, "InNodeName");
		RemoveNodeByName_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNodeByName_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveNodeByName_bSetupUndoRedo_PropertyAddress, RemoveNodeByName_FunctionAddress, "bSetupUndoRedo");
		RemoveNodeByName_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNodeByName_FunctionAddress, "bSetupUndoRedo");
		RemoveNodeByName_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNodeByName_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveNodeByName_bRecursive_PropertyAddress, RemoveNodeByName_FunctionAddress, "bRecursive");
		RemoveNodeByName_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNodeByName_FunctionAddress, "bRecursive");
		RemoveNodeByName_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNodeByName_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveNodeByName_bPrintPythonCommand_PropertyAddress, RemoveNodeByName_FunctionAddress, "bPrintPythonCommand");
		RemoveNodeByName_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNodeByName_FunctionAddress, "bPrintPythonCommand");
		RemoveNodeByName_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNodeByName_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveNodeByName_bRelinkPins_PropertyAddress, RemoveNodeByName_FunctionAddress, "bRelinkPins");
		RemoveNodeByName_bRelinkPins_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNodeByName_FunctionAddress, "bRelinkPins");
		RemoveNodeByName_bRelinkPins_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNodeByName_FunctionAddress, "bRelinkPins", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveNodeByName_ReturnValue_PropertyAddress, RemoveNodeByName_FunctionAddress, "ReturnValue");
		RemoveNodeByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNodeByName_FunctionAddress, "ReturnValue");
		RemoveNodeByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNodeByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveNodeByName_IsValid = RemoveNodeByName_FunctionAddress != IntPtr.Zero && RemoveNodeByName_InNodeName_IsValid && RemoveNodeByName_bSetupUndoRedo_IsValid && RemoveNodeByName_bRecursive_IsValid && RemoveNodeByName_bPrintPythonCommand_IsValid && RemoveNodeByName_bRelinkPins_IsValid && RemoveNodeByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:RemoveNodeByName", RemoveNodeByName_IsValid);
		RemoveNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveNode");
		RemoveNode_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveNode_InNode_PropertyAddress, RemoveNode_FunctionAddress, "InNode");
		RemoveNode_InNode_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNode_FunctionAddress, "InNode");
		RemoveNode_InNode_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNode_FunctionAddress, "InNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveNode_bSetupUndoRedo_PropertyAddress, RemoveNode_FunctionAddress, "bSetupUndoRedo");
		RemoveNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNode_FunctionAddress, "bSetupUndoRedo");
		RemoveNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveNode_bRecursive_PropertyAddress, RemoveNode_FunctionAddress, "bRecursive");
		RemoveNode_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNode_FunctionAddress, "bRecursive");
		RemoveNode_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNode_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveNode_bPrintPythonCommand_PropertyAddress, RemoveNode_FunctionAddress, "bPrintPythonCommand");
		RemoveNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNode_FunctionAddress, "bPrintPythonCommand");
		RemoveNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveNode_bRelinkPins_PropertyAddress, RemoveNode_FunctionAddress, "bRelinkPins");
		RemoveNode_bRelinkPins_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNode_FunctionAddress, "bRelinkPins");
		RemoveNode_bRelinkPins_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNode_FunctionAddress, "bRelinkPins", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveNode_ReturnValue_PropertyAddress, RemoveNode_FunctionAddress, "ReturnValue");
		RemoveNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveNode_FunctionAddress, "ReturnValue");
		RemoveNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveNode_IsValid = RemoveNode_FunctionAddress != IntPtr.Zero && RemoveNode_InNode_IsValid && RemoveNode_bSetupUndoRedo_IsValid && RemoveNode_bRecursive_IsValid && RemoveNode_bPrintPythonCommand_IsValid && RemoveNode_bRelinkPins_IsValid && RemoveNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:RemoveNode", RemoveNode_IsValid);
		RemoveLocalVariable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveLocalVariable");
		RemoveLocalVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveLocalVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveLocalVariable_InVariableName_PropertyAddress, RemoveLocalVariable_FunctionAddress, "InVariableName");
		RemoveLocalVariable_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLocalVariable_FunctionAddress, "InVariableName");
		RemoveLocalVariable_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLocalVariable_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveLocalVariable_bSetupUndoRedo_PropertyAddress, RemoveLocalVariable_FunctionAddress, "bSetupUndoRedo");
		RemoveLocalVariable_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLocalVariable_FunctionAddress, "bSetupUndoRedo");
		RemoveLocalVariable_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLocalVariable_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveLocalVariable_bPrintPythonCommand_PropertyAddress, RemoveLocalVariable_FunctionAddress, "bPrintPythonCommand");
		RemoveLocalVariable_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLocalVariable_FunctionAddress, "bPrintPythonCommand");
		RemoveLocalVariable_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLocalVariable_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveLocalVariable_ReturnValue_PropertyAddress, RemoveLocalVariable_FunctionAddress, "ReturnValue");
		RemoveLocalVariable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLocalVariable_FunctionAddress, "ReturnValue");
		RemoveLocalVariable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLocalVariable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveLocalVariable_IsValid = RemoveLocalVariable_FunctionAddress != IntPtr.Zero && RemoveLocalVariable_InVariableName_IsValid && RemoveLocalVariable_bSetupUndoRedo_IsValid && RemoveLocalVariable_bPrintPythonCommand_IsValid && RemoveLocalVariable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:RemoveLocalVariable", RemoveLocalVariable_IsValid);
		RemoveInjectedNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveInjectedNode");
		RemoveInjectedNode_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveInjectedNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveInjectedNode_InPinPath_PropertyAddress, RemoveInjectedNode_FunctionAddress, "InPinPath");
		RemoveInjectedNode_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInjectedNode_FunctionAddress, "InPinPath");
		RemoveInjectedNode_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInjectedNode_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveInjectedNode_bAsInput_PropertyAddress, RemoveInjectedNode_FunctionAddress, "bAsInput");
		RemoveInjectedNode_bAsInput_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInjectedNode_FunctionAddress, "bAsInput");
		RemoveInjectedNode_bAsInput_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInjectedNode_FunctionAddress, "bAsInput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveInjectedNode_bSetupUndoRedo_PropertyAddress, RemoveInjectedNode_FunctionAddress, "bSetupUndoRedo");
		RemoveInjectedNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInjectedNode_FunctionAddress, "bSetupUndoRedo");
		RemoveInjectedNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInjectedNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveInjectedNode_bPrintPythonCommand_PropertyAddress, RemoveInjectedNode_FunctionAddress, "bPrintPythonCommand");
		RemoveInjectedNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInjectedNode_FunctionAddress, "bPrintPythonCommand");
		RemoveInjectedNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInjectedNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveInjectedNode_ReturnValue_PropertyAddress, RemoveInjectedNode_FunctionAddress, "ReturnValue");
		RemoveInjectedNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInjectedNode_FunctionAddress, "ReturnValue");
		RemoveInjectedNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInjectedNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveInjectedNode_IsValid = RemoveInjectedNode_FunctionAddress != IntPtr.Zero && RemoveInjectedNode_InPinPath_IsValid && RemoveInjectedNode_bAsInput_IsValid && RemoveInjectedNode_bSetupUndoRedo_IsValid && RemoveInjectedNode_bPrintPythonCommand_IsValid && RemoveInjectedNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:RemoveInjectedNode", RemoveInjectedNode_IsValid);
		RemoveFunctionFromLibrary_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveFunctionFromLibrary");
		RemoveFunctionFromLibrary_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveFunctionFromLibrary_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveFunctionFromLibrary_InFunctionName_PropertyAddress, RemoveFunctionFromLibrary_FunctionAddress, "InFunctionName");
		RemoveFunctionFromLibrary_InFunctionName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveFunctionFromLibrary_FunctionAddress, "InFunctionName");
		RemoveFunctionFromLibrary_InFunctionName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveFunctionFromLibrary_FunctionAddress, "InFunctionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveFunctionFromLibrary_bSetupUndoRedo_PropertyAddress, RemoveFunctionFromLibrary_FunctionAddress, "bSetupUndoRedo");
		RemoveFunctionFromLibrary_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(RemoveFunctionFromLibrary_FunctionAddress, "bSetupUndoRedo");
		RemoveFunctionFromLibrary_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveFunctionFromLibrary_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveFunctionFromLibrary_ReturnValue_PropertyAddress, RemoveFunctionFromLibrary_FunctionAddress, "ReturnValue");
		RemoveFunctionFromLibrary_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveFunctionFromLibrary_FunctionAddress, "ReturnValue");
		RemoveFunctionFromLibrary_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveFunctionFromLibrary_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveFunctionFromLibrary_IsValid = RemoveFunctionFromLibrary_FunctionAddress != IntPtr.Zero && RemoveFunctionFromLibrary_InFunctionName_IsValid && RemoveFunctionFromLibrary_bSetupUndoRedo_IsValid && RemoveFunctionFromLibrary_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:RemoveFunctionFromLibrary", RemoveFunctionFromLibrary_IsValid);
		RemoveExposedPin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveExposedPin");
		RemoveExposedPin_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveExposedPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveExposedPin_InPinName_PropertyAddress, RemoveExposedPin_FunctionAddress, "InPinName");
		RemoveExposedPin_InPinName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveExposedPin_FunctionAddress, "InPinName");
		RemoveExposedPin_InPinName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveExposedPin_FunctionAddress, "InPinName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveExposedPin_bSetupUndoRedo_PropertyAddress, RemoveExposedPin_FunctionAddress, "bSetupUndoRedo");
		RemoveExposedPin_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(RemoveExposedPin_FunctionAddress, "bSetupUndoRedo");
		RemoveExposedPin_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveExposedPin_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveExposedPin_bPrintPythonCommand_PropertyAddress, RemoveExposedPin_FunctionAddress, "bPrintPythonCommand");
		RemoveExposedPin_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(RemoveExposedPin_FunctionAddress, "bPrintPythonCommand");
		RemoveExposedPin_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveExposedPin_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveExposedPin_ReturnValue_PropertyAddress, RemoveExposedPin_FunctionAddress, "ReturnValue");
		RemoveExposedPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveExposedPin_FunctionAddress, "ReturnValue");
		RemoveExposedPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveExposedPin_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveExposedPin_IsValid = RemoveExposedPin_FunctionAddress != IntPtr.Zero && RemoveExposedPin_InPinName_IsValid && RemoveExposedPin_bSetupUndoRedo_IsValid && RemoveExposedPin_bPrintPythonCommand_IsValid && RemoveExposedPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:RemoveExposedPin", RemoveExposedPin_IsValid);
		RemoveArrayPin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveArrayPin");
		RemoveArrayPin_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveArrayPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveArrayPin_InArrayElementPinPath_PropertyAddress, RemoveArrayPin_FunctionAddress, "InArrayElementPinPath");
		RemoveArrayPin_InArrayElementPinPath_Offset = NativeReflectionCached.GetPropertyOffset(RemoveArrayPin_FunctionAddress, "InArrayElementPinPath");
		RemoveArrayPin_InArrayElementPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveArrayPin_FunctionAddress, "InArrayElementPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveArrayPin_bSetupUndoRedo_PropertyAddress, RemoveArrayPin_FunctionAddress, "bSetupUndoRedo");
		RemoveArrayPin_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(RemoveArrayPin_FunctionAddress, "bSetupUndoRedo");
		RemoveArrayPin_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveArrayPin_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveArrayPin_bPrintPythonCommand_PropertyAddress, RemoveArrayPin_FunctionAddress, "bPrintPythonCommand");
		RemoveArrayPin_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(RemoveArrayPin_FunctionAddress, "bPrintPythonCommand");
		RemoveArrayPin_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveArrayPin_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveArrayPin_ReturnValue_PropertyAddress, RemoveArrayPin_FunctionAddress, "ReturnValue");
		RemoveArrayPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveArrayPin_FunctionAddress, "ReturnValue");
		RemoveArrayPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveArrayPin_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveArrayPin_IsValid = RemoveArrayPin_FunctionAddress != IntPtr.Zero && RemoveArrayPin_InArrayElementPinPath_IsValid && RemoveArrayPin_bSetupUndoRedo_IsValid && RemoveArrayPin_bPrintPythonCommand_IsValid && RemoveArrayPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:RemoveArrayPin", RemoveArrayPin_IsValid);
		RefreshVariableNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RefreshVariableNode");
		RefreshVariableNode_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshVariableNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RefreshVariableNode_InNodeName_PropertyAddress, RefreshVariableNode_FunctionAddress, "InNodeName");
		RefreshVariableNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(RefreshVariableNode_FunctionAddress, "InNodeName");
		RefreshVariableNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(RefreshVariableNode_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RefreshVariableNode_InVariableName_PropertyAddress, RefreshVariableNode_FunctionAddress, "InVariableName");
		RefreshVariableNode_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(RefreshVariableNode_FunctionAddress, "InVariableName");
		RefreshVariableNode_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(RefreshVariableNode_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RefreshVariableNode_InCPPType_PropertyAddress, RefreshVariableNode_FunctionAddress, "InCPPType");
		RefreshVariableNode_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(RefreshVariableNode_FunctionAddress, "InCPPType");
		RefreshVariableNode_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(RefreshVariableNode_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RefreshVariableNode_InCPPTypeObject_PropertyAddress, RefreshVariableNode_FunctionAddress, "InCPPTypeObject");
		RefreshVariableNode_InCPPTypeObject_Offset = NativeReflectionCached.GetPropertyOffset(RefreshVariableNode_FunctionAddress, "InCPPTypeObject");
		RefreshVariableNode_InCPPTypeObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RefreshVariableNode_FunctionAddress, "InCPPTypeObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RefreshVariableNode_bSetupUndoRedo_PropertyAddress, RefreshVariableNode_FunctionAddress, "bSetupUndoRedo");
		RefreshVariableNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(RefreshVariableNode_FunctionAddress, "bSetupUndoRedo");
		RefreshVariableNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(RefreshVariableNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RefreshVariableNode_bSetupOrphanPins_PropertyAddress, RefreshVariableNode_FunctionAddress, "bSetupOrphanPins");
		RefreshVariableNode_bSetupOrphanPins_Offset = NativeReflectionCached.GetPropertyOffset(RefreshVariableNode_FunctionAddress, "bSetupOrphanPins");
		RefreshVariableNode_bSetupOrphanPins_IsValid = NativeReflectionCached.ValidatePropertyClass(RefreshVariableNode_FunctionAddress, "bSetupOrphanPins", Classes.FBoolProperty);
		RefreshVariableNode_IsValid = RefreshVariableNode_FunctionAddress != IntPtr.Zero && RefreshVariableNode_InNodeName_IsValid && RefreshVariableNode_InVariableName_IsValid && RefreshVariableNode_InCPPType_IsValid && RefreshVariableNode_InCPPTypeObject_IsValid && RefreshVariableNode_bSetupUndoRedo_IsValid && RefreshVariableNode_bSetupOrphanPins_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:RefreshVariableNode", RefreshVariableNode_IsValid);
		Redo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Redo");
		Redo_ParamsSize = NativeReflection.GetFunctionParamsSize(Redo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Redo_ReturnValue_PropertyAddress, Redo_FunctionAddress, "ReturnValue");
		Redo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Redo_FunctionAddress, "ReturnValue");
		Redo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Redo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Redo_IsValid = Redo_FunctionAddress != IntPtr.Zero && Redo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:Redo", Redo_IsValid);
		PushGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PushGraph");
		PushGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(PushGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PushGraph_InGraph_PropertyAddress, PushGraph_FunctionAddress, "InGraph");
		PushGraph_InGraph_Offset = NativeReflectionCached.GetPropertyOffset(PushGraph_FunctionAddress, "InGraph");
		PushGraph_InGraph_IsValid = NativeReflectionCached.ValidatePropertyClass(PushGraph_FunctionAddress, "InGraph", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PushGraph_bSetupUndoRedo_PropertyAddress, PushGraph_FunctionAddress, "bSetupUndoRedo");
		PushGraph_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(PushGraph_FunctionAddress, "bSetupUndoRedo");
		PushGraph_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(PushGraph_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		PushGraph_IsValid = PushGraph_FunctionAddress != IntPtr.Zero && PushGraph_InGraph_IsValid && PushGraph_bSetupUndoRedo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:PushGraph", PushGraph_IsValid);
		PromotePinToVariable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PromotePinToVariable");
		PromotePinToVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(PromotePinToVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PromotePinToVariable_InPinPath_PropertyAddress, PromotePinToVariable_FunctionAddress, "InPinPath");
		PromotePinToVariable_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(PromotePinToVariable_FunctionAddress, "InPinPath");
		PromotePinToVariable_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(PromotePinToVariable_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PromotePinToVariable_bCreateVariableNode_PropertyAddress, PromotePinToVariable_FunctionAddress, "bCreateVariableNode");
		PromotePinToVariable_bCreateVariableNode_Offset = NativeReflectionCached.GetPropertyOffset(PromotePinToVariable_FunctionAddress, "bCreateVariableNode");
		PromotePinToVariable_bCreateVariableNode_IsValid = NativeReflectionCached.ValidatePropertyClass(PromotePinToVariable_FunctionAddress, "bCreateVariableNode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PromotePinToVariable_InNodePosition_PropertyAddress, PromotePinToVariable_FunctionAddress, "InNodePosition");
		PromotePinToVariable_InNodePosition_Offset = NativeReflectionCached.GetPropertyOffset(PromotePinToVariable_FunctionAddress, "InNodePosition");
		PromotePinToVariable_InNodePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(PromotePinToVariable_FunctionAddress, "InNodePosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PromotePinToVariable_bSetupUndoRedo_PropertyAddress, PromotePinToVariable_FunctionAddress, "bSetupUndoRedo");
		PromotePinToVariable_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(PromotePinToVariable_FunctionAddress, "bSetupUndoRedo");
		PromotePinToVariable_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(PromotePinToVariable_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PromotePinToVariable_bPrintPythonCommand_PropertyAddress, PromotePinToVariable_FunctionAddress, "bPrintPythonCommand");
		PromotePinToVariable_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(PromotePinToVariable_FunctionAddress, "bPrintPythonCommand");
		PromotePinToVariable_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(PromotePinToVariable_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PromotePinToVariable_ReturnValue_PropertyAddress, PromotePinToVariable_FunctionAddress, "ReturnValue");
		PromotePinToVariable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PromotePinToVariable_FunctionAddress, "ReturnValue");
		PromotePinToVariable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PromotePinToVariable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PromotePinToVariable_IsValid = PromotePinToVariable_FunctionAddress != IntPtr.Zero && PromotePinToVariable_InPinPath_IsValid && PromotePinToVariable_bCreateVariableNode_IsValid && PromotePinToVariable_InNodePosition_IsValid && PromotePinToVariable_bSetupUndoRedo_IsValid && PromotePinToVariable_bPrintPythonCommand_IsValid && PromotePinToVariable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:PromotePinToVariable", PromotePinToVariable_IsValid);
		PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PromoteFunctionReferenceNodeToCollapseNode");
		PromoteFunctionReferenceNodeToCollapseNode_ParamsSize = NativeReflection.GetFunctionParamsSize(PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PromoteFunctionReferenceNodeToCollapseNode_InNodeName_PropertyAddress, PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "InNodeName");
		PromoteFunctionReferenceNodeToCollapseNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "InNodeName");
		PromoteFunctionReferenceNodeToCollapseNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PromoteFunctionReferenceNodeToCollapseNode_bSetupUndoRedo_PropertyAddress, PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "bSetupUndoRedo");
		PromoteFunctionReferenceNodeToCollapseNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "bSetupUndoRedo");
		PromoteFunctionReferenceNodeToCollapseNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PromoteFunctionReferenceNodeToCollapseNode_bPrintPythonCommand_PropertyAddress, PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "bPrintPythonCommand");
		PromoteFunctionReferenceNodeToCollapseNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "bPrintPythonCommand");
		PromoteFunctionReferenceNodeToCollapseNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PromoteFunctionReferenceNodeToCollapseNode_bRemoveFunctionDefinition_PropertyAddress, PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "bRemoveFunctionDefinition");
		PromoteFunctionReferenceNodeToCollapseNode_bRemoveFunctionDefinition_Offset = NativeReflectionCached.GetPropertyOffset(PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "bRemoveFunctionDefinition");
		PromoteFunctionReferenceNodeToCollapseNode_bRemoveFunctionDefinition_IsValid = NativeReflectionCached.ValidatePropertyClass(PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "bRemoveFunctionDefinition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PromoteFunctionReferenceNodeToCollapseNode_ReturnValue_PropertyAddress, PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "ReturnValue");
		PromoteFunctionReferenceNodeToCollapseNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "ReturnValue");
		PromoteFunctionReferenceNodeToCollapseNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		PromoteFunctionReferenceNodeToCollapseNode_IsValid = PromoteFunctionReferenceNodeToCollapseNode_FunctionAddress != IntPtr.Zero && PromoteFunctionReferenceNodeToCollapseNode_InNodeName_IsValid && PromoteFunctionReferenceNodeToCollapseNode_bSetupUndoRedo_IsValid && PromoteFunctionReferenceNodeToCollapseNode_bPrintPythonCommand_IsValid && PromoteFunctionReferenceNodeToCollapseNode_bRemoveFunctionDefinition_IsValid && PromoteFunctionReferenceNodeToCollapseNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:PromoteFunctionReferenceNodeToCollapseNode", PromoteFunctionReferenceNodeToCollapseNode_IsValid);
		PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PromoteCollapseNodeToFunctionReferenceNode");
		PromoteCollapseNodeToFunctionReferenceNode_ParamsSize = NativeReflection.GetFunctionParamsSize(PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PromoteCollapseNodeToFunctionReferenceNode_InNodeName_PropertyAddress, PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "InNodeName");
		PromoteCollapseNodeToFunctionReferenceNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "InNodeName");
		PromoteCollapseNodeToFunctionReferenceNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PromoteCollapseNodeToFunctionReferenceNode_bSetupUndoRedo_PropertyAddress, PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "bSetupUndoRedo");
		PromoteCollapseNodeToFunctionReferenceNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "bSetupUndoRedo");
		PromoteCollapseNodeToFunctionReferenceNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PromoteCollapseNodeToFunctionReferenceNode_bPrintPythonCommand_PropertyAddress, PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "bPrintPythonCommand");
		PromoteCollapseNodeToFunctionReferenceNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "bPrintPythonCommand");
		PromoteCollapseNodeToFunctionReferenceNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PromoteCollapseNodeToFunctionReferenceNode_InExistingFunctionDefinitionPath_PropertyAddress, PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "InExistingFunctionDefinitionPath");
		PromoteCollapseNodeToFunctionReferenceNode_InExistingFunctionDefinitionPath_Offset = NativeReflectionCached.GetPropertyOffset(PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "InExistingFunctionDefinitionPath");
		PromoteCollapseNodeToFunctionReferenceNode_InExistingFunctionDefinitionPath_IsValid = NativeReflectionCached.ValidatePropertyClass(PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "InExistingFunctionDefinitionPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PromoteCollapseNodeToFunctionReferenceNode_ReturnValue_PropertyAddress, PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "ReturnValue");
		PromoteCollapseNodeToFunctionReferenceNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "ReturnValue");
		PromoteCollapseNodeToFunctionReferenceNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		PromoteCollapseNodeToFunctionReferenceNode_IsValid = PromoteCollapseNodeToFunctionReferenceNode_FunctionAddress != IntPtr.Zero && PromoteCollapseNodeToFunctionReferenceNode_InNodeName_IsValid && PromoteCollapseNodeToFunctionReferenceNode_bSetupUndoRedo_IsValid && PromoteCollapseNodeToFunctionReferenceNode_bPrintPythonCommand_IsValid && PromoteCollapseNodeToFunctionReferenceNode_InExistingFunctionDefinitionPath_IsValid && PromoteCollapseNodeToFunctionReferenceNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:PromoteCollapseNodeToFunctionReferenceNode", PromoteCollapseNodeToFunctionReferenceNode_IsValid);
		PopGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PopGraph");
		PopGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(PopGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PopGraph_bSetupUndoRedo_PropertyAddress, PopGraph_FunctionAddress, "bSetupUndoRedo");
		PopGraph_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(PopGraph_FunctionAddress, "bSetupUndoRedo");
		PopGraph_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(PopGraph_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PopGraph_ReturnValue_PropertyAddress, PopGraph_FunctionAddress, "ReturnValue");
		PopGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PopGraph_FunctionAddress, "ReturnValue");
		PopGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PopGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		PopGraph_IsValid = PopGraph_FunctionAddress != IntPtr.Zero && PopGraph_bSetupUndoRedo_IsValid && PopGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:PopGraph", PopGraph_IsValid);
		OpenUndoBracket_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OpenUndoBracket");
		OpenUndoBracket_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenUndoBracket_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenUndoBracket_InTitle_PropertyAddress, OpenUndoBracket_FunctionAddress, "InTitle");
		OpenUndoBracket_InTitle_Offset = NativeReflectionCached.GetPropertyOffset(OpenUndoBracket_FunctionAddress, "InTitle");
		OpenUndoBracket_InTitle_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenUndoBracket_FunctionAddress, "InTitle", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenUndoBracket_ReturnValue_PropertyAddress, OpenUndoBracket_FunctionAddress, "ReturnValue");
		OpenUndoBracket_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenUndoBracket_FunctionAddress, "ReturnValue");
		OpenUndoBracket_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenUndoBracket_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenUndoBracket_IsValid = OpenUndoBracket_FunctionAddress != IntPtr.Zero && OpenUndoBracket_InTitle_IsValid && OpenUndoBracket_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:OpenUndoBracket", OpenUndoBracket_IsValid);
		OnExternalVariableTypeChangedFromObjectPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnExternalVariableTypeChangedFromObjectPath");
		OnExternalVariableTypeChangedFromObjectPath_ParamsSize = NativeReflection.GetFunctionParamsSize(OnExternalVariableTypeChangedFromObjectPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnExternalVariableTypeChangedFromObjectPath_InVarName_PropertyAddress, OnExternalVariableTypeChangedFromObjectPath_FunctionAddress, "InVarName");
		OnExternalVariableTypeChangedFromObjectPath_InVarName_Offset = NativeReflectionCached.GetPropertyOffset(OnExternalVariableTypeChangedFromObjectPath_FunctionAddress, "InVarName");
		OnExternalVariableTypeChangedFromObjectPath_InVarName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExternalVariableTypeChangedFromObjectPath_FunctionAddress, "InVarName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnExternalVariableTypeChangedFromObjectPath_InCPPType_PropertyAddress, OnExternalVariableTypeChangedFromObjectPath_FunctionAddress, "InCPPType");
		OnExternalVariableTypeChangedFromObjectPath_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(OnExternalVariableTypeChangedFromObjectPath_FunctionAddress, "InCPPType");
		OnExternalVariableTypeChangedFromObjectPath_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExternalVariableTypeChangedFromObjectPath_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnExternalVariableTypeChangedFromObjectPath_InCPPTypeObjectPath_PropertyAddress, OnExternalVariableTypeChangedFromObjectPath_FunctionAddress, "InCPPTypeObjectPath");
		OnExternalVariableTypeChangedFromObjectPath_InCPPTypeObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(OnExternalVariableTypeChangedFromObjectPath_FunctionAddress, "InCPPTypeObjectPath");
		OnExternalVariableTypeChangedFromObjectPath_InCPPTypeObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExternalVariableTypeChangedFromObjectPath_FunctionAddress, "InCPPTypeObjectPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnExternalVariableTypeChangedFromObjectPath_bSetupUndoRedo_PropertyAddress, OnExternalVariableTypeChangedFromObjectPath_FunctionAddress, "bSetupUndoRedo");
		OnExternalVariableTypeChangedFromObjectPath_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(OnExternalVariableTypeChangedFromObjectPath_FunctionAddress, "bSetupUndoRedo");
		OnExternalVariableTypeChangedFromObjectPath_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExternalVariableTypeChangedFromObjectPath_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		OnExternalVariableTypeChangedFromObjectPath_IsValid = OnExternalVariableTypeChangedFromObjectPath_FunctionAddress != IntPtr.Zero && OnExternalVariableTypeChangedFromObjectPath_InVarName_IsValid && OnExternalVariableTypeChangedFromObjectPath_InCPPType_IsValid && OnExternalVariableTypeChangedFromObjectPath_InCPPTypeObjectPath_IsValid && OnExternalVariableTypeChangedFromObjectPath_bSetupUndoRedo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:OnExternalVariableTypeChangedFromObjectPath", OnExternalVariableTypeChangedFromObjectPath_IsValid);
		OnExternalVariableTypeChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnExternalVariableTypeChanged");
		OnExternalVariableTypeChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnExternalVariableTypeChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnExternalVariableTypeChanged_InVarName_PropertyAddress, OnExternalVariableTypeChanged_FunctionAddress, "InVarName");
		OnExternalVariableTypeChanged_InVarName_Offset = NativeReflectionCached.GetPropertyOffset(OnExternalVariableTypeChanged_FunctionAddress, "InVarName");
		OnExternalVariableTypeChanged_InVarName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExternalVariableTypeChanged_FunctionAddress, "InVarName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnExternalVariableTypeChanged_InCPPType_PropertyAddress, OnExternalVariableTypeChanged_FunctionAddress, "InCPPType");
		OnExternalVariableTypeChanged_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(OnExternalVariableTypeChanged_FunctionAddress, "InCPPType");
		OnExternalVariableTypeChanged_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExternalVariableTypeChanged_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnExternalVariableTypeChanged_InCPPTypeObject_PropertyAddress, OnExternalVariableTypeChanged_FunctionAddress, "InCPPTypeObject");
		OnExternalVariableTypeChanged_InCPPTypeObject_Offset = NativeReflectionCached.GetPropertyOffset(OnExternalVariableTypeChanged_FunctionAddress, "InCPPTypeObject");
		OnExternalVariableTypeChanged_InCPPTypeObject_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExternalVariableTypeChanged_FunctionAddress, "InCPPTypeObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnExternalVariableTypeChanged_bSetupUndoRedo_PropertyAddress, OnExternalVariableTypeChanged_FunctionAddress, "bSetupUndoRedo");
		OnExternalVariableTypeChanged_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(OnExternalVariableTypeChanged_FunctionAddress, "bSetupUndoRedo");
		OnExternalVariableTypeChanged_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExternalVariableTypeChanged_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		OnExternalVariableTypeChanged_IsValid = OnExternalVariableTypeChanged_FunctionAddress != IntPtr.Zero && OnExternalVariableTypeChanged_InVarName_IsValid && OnExternalVariableTypeChanged_InCPPType_IsValid && OnExternalVariableTypeChanged_InCPPTypeObject_IsValid && OnExternalVariableTypeChanged_bSetupUndoRedo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:OnExternalVariableTypeChanged", OnExternalVariableTypeChanged_IsValid);
		OnExternalVariableRenamed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnExternalVariableRenamed");
		OnExternalVariableRenamed_ParamsSize = NativeReflection.GetFunctionParamsSize(OnExternalVariableRenamed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnExternalVariableRenamed_InOldVarName_PropertyAddress, OnExternalVariableRenamed_FunctionAddress, "InOldVarName");
		OnExternalVariableRenamed_InOldVarName_Offset = NativeReflectionCached.GetPropertyOffset(OnExternalVariableRenamed_FunctionAddress, "InOldVarName");
		OnExternalVariableRenamed_InOldVarName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExternalVariableRenamed_FunctionAddress, "InOldVarName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnExternalVariableRenamed_InNewVarName_PropertyAddress, OnExternalVariableRenamed_FunctionAddress, "InNewVarName");
		OnExternalVariableRenamed_InNewVarName_Offset = NativeReflectionCached.GetPropertyOffset(OnExternalVariableRenamed_FunctionAddress, "InNewVarName");
		OnExternalVariableRenamed_InNewVarName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExternalVariableRenamed_FunctionAddress, "InNewVarName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnExternalVariableRenamed_bSetupUndoRedo_PropertyAddress, OnExternalVariableRenamed_FunctionAddress, "bSetupUndoRedo");
		OnExternalVariableRenamed_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(OnExternalVariableRenamed_FunctionAddress, "bSetupUndoRedo");
		OnExternalVariableRenamed_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExternalVariableRenamed_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		OnExternalVariableRenamed_IsValid = OnExternalVariableRenamed_FunctionAddress != IntPtr.Zero && OnExternalVariableRenamed_InOldVarName_IsValid && OnExternalVariableRenamed_InNewVarName_IsValid && OnExternalVariableRenamed_bSetupUndoRedo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:OnExternalVariableRenamed", OnExternalVariableRenamed_IsValid);
		OnExternalVariableRemoved_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnExternalVariableRemoved");
		OnExternalVariableRemoved_ParamsSize = NativeReflection.GetFunctionParamsSize(OnExternalVariableRemoved_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnExternalVariableRemoved_InVarName_PropertyAddress, OnExternalVariableRemoved_FunctionAddress, "InVarName");
		OnExternalVariableRemoved_InVarName_Offset = NativeReflectionCached.GetPropertyOffset(OnExternalVariableRemoved_FunctionAddress, "InVarName");
		OnExternalVariableRemoved_InVarName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExternalVariableRemoved_FunctionAddress, "InVarName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref OnExternalVariableRemoved_bSetupUndoRedo_PropertyAddress, OnExternalVariableRemoved_FunctionAddress, "bSetupUndoRedo");
		OnExternalVariableRemoved_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(OnExternalVariableRemoved_FunctionAddress, "bSetupUndoRedo");
		OnExternalVariableRemoved_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(OnExternalVariableRemoved_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		OnExternalVariableRemoved_IsValid = OnExternalVariableRemoved_FunctionAddress != IntPtr.Zero && OnExternalVariableRemoved_InVarName_IsValid && OnExternalVariableRemoved_bSetupUndoRedo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:OnExternalVariableRemoved", OnExternalVariableRemoved_IsValid);
		MakeVariableNodeFromBinding_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MakeVariableNodeFromBinding");
		MakeVariableNodeFromBinding_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeVariableNodeFromBinding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeVariableNodeFromBinding_InPinPath_PropertyAddress, MakeVariableNodeFromBinding_FunctionAddress, "InPinPath");
		MakeVariableNodeFromBinding_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(MakeVariableNodeFromBinding_FunctionAddress, "InPinPath");
		MakeVariableNodeFromBinding_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVariableNodeFromBinding_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVariableNodeFromBinding_InNodePosition_PropertyAddress, MakeVariableNodeFromBinding_FunctionAddress, "InNodePosition");
		MakeVariableNodeFromBinding_InNodePosition_Offset = NativeReflectionCached.GetPropertyOffset(MakeVariableNodeFromBinding_FunctionAddress, "InNodePosition");
		MakeVariableNodeFromBinding_InNodePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVariableNodeFromBinding_FunctionAddress, "InNodePosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVariableNodeFromBinding_bSetupUndoRedo_PropertyAddress, MakeVariableNodeFromBinding_FunctionAddress, "bSetupUndoRedo");
		MakeVariableNodeFromBinding_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(MakeVariableNodeFromBinding_FunctionAddress, "bSetupUndoRedo");
		MakeVariableNodeFromBinding_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVariableNodeFromBinding_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVariableNodeFromBinding_bPrintPythonCommand_PropertyAddress, MakeVariableNodeFromBinding_FunctionAddress, "bPrintPythonCommand");
		MakeVariableNodeFromBinding_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(MakeVariableNodeFromBinding_FunctionAddress, "bPrintPythonCommand");
		MakeVariableNodeFromBinding_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVariableNodeFromBinding_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeVariableNodeFromBinding_ReturnValue_PropertyAddress, MakeVariableNodeFromBinding_FunctionAddress, "ReturnValue");
		MakeVariableNodeFromBinding_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeVariableNodeFromBinding_FunctionAddress, "ReturnValue");
		MakeVariableNodeFromBinding_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeVariableNodeFromBinding_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MakeVariableNodeFromBinding_IsValid = MakeVariableNodeFromBinding_FunctionAddress != IntPtr.Zero && MakeVariableNodeFromBinding_InPinPath_IsValid && MakeVariableNodeFromBinding_InNodePosition_IsValid && MakeVariableNodeFromBinding_bSetupUndoRedo_IsValid && MakeVariableNodeFromBinding_bPrintPythonCommand_IsValid && MakeVariableNodeFromBinding_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:MakeVariableNodeFromBinding", MakeVariableNodeFromBinding_IsValid);
		MakeBindingsFromVariableNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MakeBindingsFromVariableNode");
		MakeBindingsFromVariableNode_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeBindingsFromVariableNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeBindingsFromVariableNode_InNodeName_PropertyAddress, MakeBindingsFromVariableNode_FunctionAddress, "InNodeName");
		MakeBindingsFromVariableNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(MakeBindingsFromVariableNode_FunctionAddress, "InNodeName");
		MakeBindingsFromVariableNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBindingsFromVariableNode_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeBindingsFromVariableNode_bSetupUndoRedo_PropertyAddress, MakeBindingsFromVariableNode_FunctionAddress, "bSetupUndoRedo");
		MakeBindingsFromVariableNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(MakeBindingsFromVariableNode_FunctionAddress, "bSetupUndoRedo");
		MakeBindingsFromVariableNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBindingsFromVariableNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeBindingsFromVariableNode_bPrintPythonCommand_PropertyAddress, MakeBindingsFromVariableNode_FunctionAddress, "bPrintPythonCommand");
		MakeBindingsFromVariableNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(MakeBindingsFromVariableNode_FunctionAddress, "bPrintPythonCommand");
		MakeBindingsFromVariableNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBindingsFromVariableNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeBindingsFromVariableNode_ReturnValue_PropertyAddress, MakeBindingsFromVariableNode_FunctionAddress, "ReturnValue");
		MakeBindingsFromVariableNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeBindingsFromVariableNode_FunctionAddress, "ReturnValue");
		MakeBindingsFromVariableNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBindingsFromVariableNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MakeBindingsFromVariableNode_IsValid = MakeBindingsFromVariableNode_FunctionAddress != IntPtr.Zero && MakeBindingsFromVariableNode_InNodeName_IsValid && MakeBindingsFromVariableNode_bSetupUndoRedo_IsValid && MakeBindingsFromVariableNode_bPrintPythonCommand_IsValid && MakeBindingsFromVariableNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:MakeBindingsFromVariableNode", MakeBindingsFromVariableNode_IsValid);
		LocalizeFunctions_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LocalizeFunctions");
		LocalizeFunctions_ParamsSize = NativeReflection.GetFunctionParamsSize(LocalizeFunctions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LocalizeFunctions_InFunctionDefinitions_PropertyAddress, LocalizeFunctions_FunctionAddress, "InFunctionDefinitions");
		LocalizeFunctions_InFunctionDefinitions_Offset = NativeReflectionCached.GetPropertyOffset(LocalizeFunctions_FunctionAddress, "InFunctionDefinitions");
		LocalizeFunctions_InFunctionDefinitions_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalizeFunctions_FunctionAddress, "InFunctionDefinitions", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalizeFunctions_bLocalizeDependentPrivateFunctions_PropertyAddress, LocalizeFunctions_FunctionAddress, "bLocalizeDependentPrivateFunctions");
		LocalizeFunctions_bLocalizeDependentPrivateFunctions_Offset = NativeReflectionCached.GetPropertyOffset(LocalizeFunctions_FunctionAddress, "bLocalizeDependentPrivateFunctions");
		LocalizeFunctions_bLocalizeDependentPrivateFunctions_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalizeFunctions_FunctionAddress, "bLocalizeDependentPrivateFunctions", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalizeFunctions_bSetupUndoRedo_PropertyAddress, LocalizeFunctions_FunctionAddress, "bSetupUndoRedo");
		LocalizeFunctions_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(LocalizeFunctions_FunctionAddress, "bSetupUndoRedo");
		LocalizeFunctions_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalizeFunctions_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalizeFunctions_bPrintPythonCommand_PropertyAddress, LocalizeFunctions_FunctionAddress, "bPrintPythonCommand");
		LocalizeFunctions_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(LocalizeFunctions_FunctionAddress, "bPrintPythonCommand");
		LocalizeFunctions_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalizeFunctions_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalizeFunctions_ReturnValue_PropertyAddress, LocalizeFunctions_FunctionAddress, "ReturnValue");
		LocalizeFunctions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LocalizeFunctions_FunctionAddress, "ReturnValue");
		LocalizeFunctions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalizeFunctions_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		LocalizeFunctions_IsValid = LocalizeFunctions_FunctionAddress != IntPtr.Zero && LocalizeFunctions_InFunctionDefinitions_IsValid && LocalizeFunctions_bLocalizeDependentPrivateFunctions_IsValid && LocalizeFunctions_bSetupUndoRedo_IsValid && LocalizeFunctions_bPrintPythonCommand_IsValid && LocalizeFunctions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:LocalizeFunctions", LocalizeFunctions_IsValid);
		LocalizeFunction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LocalizeFunction");
		LocalizeFunction_ParamsSize = NativeReflection.GetFunctionParamsSize(LocalizeFunction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LocalizeFunction_InFunctionDefinition_PropertyAddress, LocalizeFunction_FunctionAddress, "InFunctionDefinition");
		LocalizeFunction_InFunctionDefinition_Offset = NativeReflectionCached.GetPropertyOffset(LocalizeFunction_FunctionAddress, "InFunctionDefinition");
		LocalizeFunction_InFunctionDefinition_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalizeFunction_FunctionAddress, "InFunctionDefinition", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalizeFunction_bLocalizeDependentPrivateFunctions_PropertyAddress, LocalizeFunction_FunctionAddress, "bLocalizeDependentPrivateFunctions");
		LocalizeFunction_bLocalizeDependentPrivateFunctions_Offset = NativeReflectionCached.GetPropertyOffset(LocalizeFunction_FunctionAddress, "bLocalizeDependentPrivateFunctions");
		LocalizeFunction_bLocalizeDependentPrivateFunctions_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalizeFunction_FunctionAddress, "bLocalizeDependentPrivateFunctions", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalizeFunction_bSetupUndoRedo_PropertyAddress, LocalizeFunction_FunctionAddress, "bSetupUndoRedo");
		LocalizeFunction_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(LocalizeFunction_FunctionAddress, "bSetupUndoRedo");
		LocalizeFunction_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalizeFunction_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalizeFunction_bPrintPythonCommand_PropertyAddress, LocalizeFunction_FunctionAddress, "bPrintPythonCommand");
		LocalizeFunction_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(LocalizeFunction_FunctionAddress, "bPrintPythonCommand");
		LocalizeFunction_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalizeFunction_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LocalizeFunction_ReturnValue_PropertyAddress, LocalizeFunction_FunctionAddress, "ReturnValue");
		LocalizeFunction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LocalizeFunction_FunctionAddress, "ReturnValue");
		LocalizeFunction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LocalizeFunction_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		LocalizeFunction_IsValid = LocalizeFunction_FunctionAddress != IntPtr.Zero && LocalizeFunction_InFunctionDefinition_IsValid && LocalizeFunction_bLocalizeDependentPrivateFunctions_IsValid && LocalizeFunction_bSetupUndoRedo_IsValid && LocalizeFunction_bPrintPythonCommand_IsValid && LocalizeFunction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:LocalizeFunction", LocalizeFunction_IsValid);
		IsReportingEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsReportingEnabled");
		IsReportingEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsReportingEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsReportingEnabled_ReturnValue_PropertyAddress, IsReportingEnabled_FunctionAddress, "ReturnValue");
		IsReportingEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsReportingEnabled_FunctionAddress, "ReturnValue");
		IsReportingEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsReportingEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsReportingEnabled_IsValid = IsReportingEnabled_FunctionAddress != IntPtr.Zero && IsReportingEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:IsReportingEnabled", IsReportingEnabled_IsValid);
		InsertArrayPin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InsertArrayPin");
		InsertArrayPin_ParamsSize = NativeReflection.GetFunctionParamsSize(InsertArrayPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InsertArrayPin_InArrayPinPath_PropertyAddress, InsertArrayPin_FunctionAddress, "InArrayPinPath");
		InsertArrayPin_InArrayPinPath_Offset = NativeReflectionCached.GetPropertyOffset(InsertArrayPin_FunctionAddress, "InArrayPinPath");
		InsertArrayPin_InArrayPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertArrayPin_FunctionAddress, "InArrayPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertArrayPin_InIndex_PropertyAddress, InsertArrayPin_FunctionAddress, "InIndex");
		InsertArrayPin_InIndex_Offset = NativeReflectionCached.GetPropertyOffset(InsertArrayPin_FunctionAddress, "InIndex");
		InsertArrayPin_InIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertArrayPin_FunctionAddress, "InIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertArrayPin_InDefaultValue_PropertyAddress, InsertArrayPin_FunctionAddress, "InDefaultValue");
		InsertArrayPin_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(InsertArrayPin_FunctionAddress, "InDefaultValue");
		InsertArrayPin_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertArrayPin_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertArrayPin_bSetupUndoRedo_PropertyAddress, InsertArrayPin_FunctionAddress, "bSetupUndoRedo");
		InsertArrayPin_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(InsertArrayPin_FunctionAddress, "bSetupUndoRedo");
		InsertArrayPin_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertArrayPin_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertArrayPin_bPrintPythonCommand_PropertyAddress, InsertArrayPin_FunctionAddress, "bPrintPythonCommand");
		InsertArrayPin_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(InsertArrayPin_FunctionAddress, "bPrintPythonCommand");
		InsertArrayPin_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertArrayPin_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InsertArrayPin_ReturnValue_PropertyAddress, InsertArrayPin_FunctionAddress, "ReturnValue");
		InsertArrayPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(InsertArrayPin_FunctionAddress, "ReturnValue");
		InsertArrayPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(InsertArrayPin_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		InsertArrayPin_IsValid = InsertArrayPin_FunctionAddress != IntPtr.Zero && InsertArrayPin_InArrayPinPath_IsValid && InsertArrayPin_InIndex_IsValid && InsertArrayPin_InDefaultValue_IsValid && InsertArrayPin_bSetupUndoRedo_IsValid && InsertArrayPin_bPrintPythonCommand_IsValid && InsertArrayPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:InsertArrayPin", InsertArrayPin_IsValid);
		ImportNodesFromText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ImportNodesFromText");
		ImportNodesFromText_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportNodesFromText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportNodesFromText_InText_PropertyAddress, ImportNodesFromText_FunctionAddress, "InText");
		ImportNodesFromText_InText_Offset = NativeReflectionCached.GetPropertyOffset(ImportNodesFromText_FunctionAddress, "InText");
		ImportNodesFromText_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportNodesFromText_FunctionAddress, "InText", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportNodesFromText_bSetupUndoRedo_PropertyAddress, ImportNodesFromText_FunctionAddress, "bSetupUndoRedo");
		ImportNodesFromText_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(ImportNodesFromText_FunctionAddress, "bSetupUndoRedo");
		ImportNodesFromText_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportNodesFromText_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportNodesFromText_bPrintPythonCommands_PropertyAddress, ImportNodesFromText_FunctionAddress, "bPrintPythonCommands");
		ImportNodesFromText_bPrintPythonCommands_Offset = NativeReflectionCached.GetPropertyOffset(ImportNodesFromText_FunctionAddress, "bPrintPythonCommands");
		ImportNodesFromText_bPrintPythonCommands_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportNodesFromText_FunctionAddress, "bPrintPythonCommands", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportNodesFromText_ReturnValue_PropertyAddress, ImportNodesFromText_FunctionAddress, "ReturnValue");
		ImportNodesFromText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportNodesFromText_FunctionAddress, "ReturnValue");
		ImportNodesFromText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportNodesFromText_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ImportNodesFromText_IsValid = ImportNodesFromText_FunctionAddress != IntPtr.Zero && ImportNodesFromText_InText_IsValid && ImportNodesFromText_bSetupUndoRedo_IsValid && ImportNodesFromText_bPrintPythonCommands_IsValid && ImportNodesFromText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:ImportNodesFromText", ImportNodesFromText_IsValid);
		GetTopLevelGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTopLevelGraph");
		GetTopLevelGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTopLevelGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTopLevelGraph_ReturnValue_PropertyAddress, GetTopLevelGraph_FunctionAddress, "ReturnValue");
		GetTopLevelGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTopLevelGraph_FunctionAddress, "ReturnValue");
		GetTopLevelGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTopLevelGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetTopLevelGraph_IsValid = GetTopLevelGraph_FunctionAddress != IntPtr.Zero && GetTopLevelGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:GetTopLevelGraph", GetTopLevelGraph_IsValid);
		GetPinDefaultValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPinDefaultValue");
		GetPinDefaultValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPinDefaultValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPinDefaultValue_InPinPath_PropertyAddress, GetPinDefaultValue_FunctionAddress, "InPinPath");
		GetPinDefaultValue_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(GetPinDefaultValue_FunctionAddress, "InPinPath");
		GetPinDefaultValue_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPinDefaultValue_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPinDefaultValue_ReturnValue_PropertyAddress, GetPinDefaultValue_FunctionAddress, "ReturnValue");
		GetPinDefaultValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPinDefaultValue_FunctionAddress, "ReturnValue");
		GetPinDefaultValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPinDefaultValue_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetPinDefaultValue_IsValid = GetPinDefaultValue_FunctionAddress != IntPtr.Zero && GetPinDefaultValue_InPinPath_IsValid && GetPinDefaultValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:GetPinDefaultValue", GetPinDefaultValue_IsValid);
		GetGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGraph");
		GetGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGraph_ReturnValue_PropertyAddress, GetGraph_FunctionAddress, "ReturnValue");
		GetGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGraph_FunctionAddress, "ReturnValue");
		GetGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetGraph_IsValid = GetGraph_FunctionAddress != IntPtr.Zero && GetGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:GetGraph", GetGraph_IsValid);
		GeneratePythonCommands_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GeneratePythonCommands");
		GeneratePythonCommands_ParamsSize = NativeReflection.GetFunctionParamsSize(GeneratePythonCommands_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GeneratePythonCommands_ReturnValue_PropertyAddress, GeneratePythonCommands_FunctionAddress, "ReturnValue");
		GeneratePythonCommands_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GeneratePythonCommands_FunctionAddress, "ReturnValue");
		GeneratePythonCommands_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratePythonCommands_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GeneratePythonCommands_IsValid = GeneratePythonCommands_FunctionAddress != IntPtr.Zero && GeneratePythonCommands_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:GeneratePythonCommands", GeneratePythonCommands_IsValid);
		ExportSelectedNodesToText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExportSelectedNodesToText");
		ExportSelectedNodesToText_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportSelectedNodesToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportSelectedNodesToText_ReturnValue_PropertyAddress, ExportSelectedNodesToText_FunctionAddress, "ReturnValue");
		ExportSelectedNodesToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExportSelectedNodesToText_FunctionAddress, "ReturnValue");
		ExportSelectedNodesToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportSelectedNodesToText_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ExportSelectedNodesToText_IsValid = ExportSelectedNodesToText_FunctionAddress != IntPtr.Zero && ExportSelectedNodesToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:ExportSelectedNodesToText", ExportSelectedNodesToText_IsValid);
		ExportNodesToText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExportNodesToText");
		ExportNodesToText_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportNodesToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportNodesToText_InNodeNames_PropertyAddress, ExportNodesToText_FunctionAddress, "InNodeNames");
		ExportNodesToText_InNodeNames_Offset = NativeReflectionCached.GetPropertyOffset(ExportNodesToText_FunctionAddress, "InNodeNames");
		ExportNodesToText_InNodeNames_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportNodesToText_FunctionAddress, "InNodeNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportNodesToText_ReturnValue_PropertyAddress, ExportNodesToText_FunctionAddress, "ReturnValue");
		ExportNodesToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExportNodesToText_FunctionAddress, "ReturnValue");
		ExportNodesToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportNodesToText_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ExportNodesToText_IsValid = ExportNodesToText_FunctionAddress != IntPtr.Zero && ExportNodesToText_InNodeNames_IsValid && ExportNodesToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:ExportNodesToText", ExportNodesToText_IsValid);
		ExpandLibraryNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExpandLibraryNode");
		ExpandLibraryNode_ParamsSize = NativeReflection.GetFunctionParamsSize(ExpandLibraryNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExpandLibraryNode_InNodeName_PropertyAddress, ExpandLibraryNode_FunctionAddress, "InNodeName");
		ExpandLibraryNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(ExpandLibraryNode_FunctionAddress, "InNodeName");
		ExpandLibraryNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(ExpandLibraryNode_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ExpandLibraryNode_bSetupUndoRedo_PropertyAddress, ExpandLibraryNode_FunctionAddress, "bSetupUndoRedo");
		ExpandLibraryNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(ExpandLibraryNode_FunctionAddress, "bSetupUndoRedo");
		ExpandLibraryNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(ExpandLibraryNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExpandLibraryNode_bPrintPythonCommand_PropertyAddress, ExpandLibraryNode_FunctionAddress, "bPrintPythonCommand");
		ExpandLibraryNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(ExpandLibraryNode_FunctionAddress, "bPrintPythonCommand");
		ExpandLibraryNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(ExpandLibraryNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExpandLibraryNode_ReturnValue_PropertyAddress, ExpandLibraryNode_FunctionAddress, "ReturnValue");
		ExpandLibraryNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExpandLibraryNode_FunctionAddress, "ReturnValue");
		ExpandLibraryNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExpandLibraryNode_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ExpandLibraryNode_IsValid = ExpandLibraryNode_FunctionAddress != IntPtr.Zero && ExpandLibraryNode_InNodeName_IsValid && ExpandLibraryNode_bSetupUndoRedo_IsValid && ExpandLibraryNode_bPrintPythonCommand_IsValid && ExpandLibraryNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:ExpandLibraryNode", ExpandLibraryNode_IsValid);
		EnableReporting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EnableReporting");
		EnableReporting_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableReporting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableReporting_bEnabled_PropertyAddress, EnableReporting_FunctionAddress, "bEnabled");
		EnableReporting_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(EnableReporting_FunctionAddress, "bEnabled");
		EnableReporting_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableReporting_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		EnableReporting_IsValid = EnableReporting_FunctionAddress != IntPtr.Zero && EnableReporting_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:EnableReporting", EnableReporting_IsValid);
		EjectNodeFromPin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EjectNodeFromPin");
		EjectNodeFromPin_ParamsSize = NativeReflection.GetFunctionParamsSize(EjectNodeFromPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EjectNodeFromPin_InPinPath_PropertyAddress, EjectNodeFromPin_FunctionAddress, "InPinPath");
		EjectNodeFromPin_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(EjectNodeFromPin_FunctionAddress, "InPinPath");
		EjectNodeFromPin_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(EjectNodeFromPin_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EjectNodeFromPin_bSetupUndoRedo_PropertyAddress, EjectNodeFromPin_FunctionAddress, "bSetupUndoRedo");
		EjectNodeFromPin_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(EjectNodeFromPin_FunctionAddress, "bSetupUndoRedo");
		EjectNodeFromPin_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(EjectNodeFromPin_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EjectNodeFromPin_bPrintPythonCommand_PropertyAddress, EjectNodeFromPin_FunctionAddress, "bPrintPythonCommand");
		EjectNodeFromPin_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(EjectNodeFromPin_FunctionAddress, "bPrintPythonCommand");
		EjectNodeFromPin_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(EjectNodeFromPin_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EjectNodeFromPin_ReturnValue_PropertyAddress, EjectNodeFromPin_FunctionAddress, "ReturnValue");
		EjectNodeFromPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EjectNodeFromPin_FunctionAddress, "ReturnValue");
		EjectNodeFromPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EjectNodeFromPin_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		EjectNodeFromPin_IsValid = EjectNodeFromPin_FunctionAddress != IntPtr.Zero && EjectNodeFromPin_InPinPath_IsValid && EjectNodeFromPin_bSetupUndoRedo_IsValid && EjectNodeFromPin_bPrintPythonCommand_IsValid && EjectNodeFromPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:EjectNodeFromPin", EjectNodeFromPin_IsValid);
		DuplicateArrayPin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DuplicateArrayPin");
		DuplicateArrayPin_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateArrayPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateArrayPin_InArrayElementPinPath_PropertyAddress, DuplicateArrayPin_FunctionAddress, "InArrayElementPinPath");
		DuplicateArrayPin_InArrayElementPinPath_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateArrayPin_FunctionAddress, "InArrayElementPinPath");
		DuplicateArrayPin_InArrayElementPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateArrayPin_FunctionAddress, "InArrayElementPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateArrayPin_bSetupUndoRedo_PropertyAddress, DuplicateArrayPin_FunctionAddress, "bSetupUndoRedo");
		DuplicateArrayPin_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateArrayPin_FunctionAddress, "bSetupUndoRedo");
		DuplicateArrayPin_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateArrayPin_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateArrayPin_bPrintPythonCommand_PropertyAddress, DuplicateArrayPin_FunctionAddress, "bPrintPythonCommand");
		DuplicateArrayPin_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateArrayPin_FunctionAddress, "bPrintPythonCommand");
		DuplicateArrayPin_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateArrayPin_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateArrayPin_ReturnValue_PropertyAddress, DuplicateArrayPin_FunctionAddress, "ReturnValue");
		DuplicateArrayPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateArrayPin_FunctionAddress, "ReturnValue");
		DuplicateArrayPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateArrayPin_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		DuplicateArrayPin_IsValid = DuplicateArrayPin_FunctionAddress != IntPtr.Zero && DuplicateArrayPin_InArrayElementPinPath_IsValid && DuplicateArrayPin_bSetupUndoRedo_IsValid && DuplicateArrayPin_bPrintPythonCommand_IsValid && DuplicateArrayPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:DuplicateArrayPin", DuplicateArrayPin_IsValid);
		CollapseNodes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CollapseNodes");
		CollapseNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(CollapseNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CollapseNodes_InNodeNames_PropertyAddress, CollapseNodes_FunctionAddress, "InNodeNames");
		CollapseNodes_InNodeNames_Offset = NativeReflectionCached.GetPropertyOffset(CollapseNodes_FunctionAddress, "InNodeNames");
		CollapseNodes_InNodeNames_IsValid = NativeReflectionCached.ValidatePropertyClass(CollapseNodes_FunctionAddress, "InNodeNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CollapseNodes_InCollapseNodeName_PropertyAddress, CollapseNodes_FunctionAddress, "InCollapseNodeName");
		CollapseNodes_InCollapseNodeName_Offset = NativeReflectionCached.GetPropertyOffset(CollapseNodes_FunctionAddress, "InCollapseNodeName");
		CollapseNodes_InCollapseNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(CollapseNodes_FunctionAddress, "InCollapseNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CollapseNodes_bSetupUndoRedo_PropertyAddress, CollapseNodes_FunctionAddress, "bSetupUndoRedo");
		CollapseNodes_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(CollapseNodes_FunctionAddress, "bSetupUndoRedo");
		CollapseNodes_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(CollapseNodes_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CollapseNodes_bPrintPythonCommand_PropertyAddress, CollapseNodes_FunctionAddress, "bPrintPythonCommand");
		CollapseNodes_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(CollapseNodes_FunctionAddress, "bPrintPythonCommand");
		CollapseNodes_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(CollapseNodes_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CollapseNodes_ReturnValue_PropertyAddress, CollapseNodes_FunctionAddress, "ReturnValue");
		CollapseNodes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CollapseNodes_FunctionAddress, "ReturnValue");
		CollapseNodes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CollapseNodes_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CollapseNodes_IsValid = CollapseNodes_FunctionAddress != IntPtr.Zero && CollapseNodes_InNodeNames_IsValid && CollapseNodes_InCollapseNodeName_IsValid && CollapseNodes_bSetupUndoRedo_IsValid && CollapseNodes_bPrintPythonCommand_IsValid && CollapseNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:CollapseNodes", CollapseNodes_IsValid);
		CloseUndoBracket_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CloseUndoBracket");
		CloseUndoBracket_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseUndoBracket_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CloseUndoBracket_ReturnValue_PropertyAddress, CloseUndoBracket_FunctionAddress, "ReturnValue");
		CloseUndoBracket_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CloseUndoBracket_FunctionAddress, "ReturnValue");
		CloseUndoBracket_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseUndoBracket_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CloseUndoBracket_IsValid = CloseUndoBracket_FunctionAddress != IntPtr.Zero && CloseUndoBracket_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:CloseUndoBracket", CloseUndoBracket_IsValid);
		ClearNodeSelection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearNodeSelection");
		ClearNodeSelection_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearNodeSelection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearNodeSelection_bSetupUndoRedo_PropertyAddress, ClearNodeSelection_FunctionAddress, "bSetupUndoRedo");
		ClearNodeSelection_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(ClearNodeSelection_FunctionAddress, "bSetupUndoRedo");
		ClearNodeSelection_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearNodeSelection_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearNodeSelection_bPrintPythonCommand_PropertyAddress, ClearNodeSelection_FunctionAddress, "bPrintPythonCommand");
		ClearNodeSelection_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(ClearNodeSelection_FunctionAddress, "bPrintPythonCommand");
		ClearNodeSelection_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearNodeSelection_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearNodeSelection_ReturnValue_PropertyAddress, ClearNodeSelection_FunctionAddress, "ReturnValue");
		ClearNodeSelection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClearNodeSelection_FunctionAddress, "ReturnValue");
		ClearNodeSelection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearNodeSelection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ClearNodeSelection_IsValid = ClearNodeSelection_FunctionAddress != IntPtr.Zero && ClearNodeSelection_bSetupUndoRedo_IsValid && ClearNodeSelection_bPrintPythonCommand_IsValid && ClearNodeSelection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:ClearNodeSelection", ClearNodeSelection_IsValid);
		ClearArrayPin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearArrayPin");
		ClearArrayPin_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearArrayPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearArrayPin_InArrayPinPath_PropertyAddress, ClearArrayPin_FunctionAddress, "InArrayPinPath");
		ClearArrayPin_InArrayPinPath_Offset = NativeReflectionCached.GetPropertyOffset(ClearArrayPin_FunctionAddress, "InArrayPinPath");
		ClearArrayPin_InArrayPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearArrayPin_FunctionAddress, "InArrayPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearArrayPin_bSetupUndoRedo_PropertyAddress, ClearArrayPin_FunctionAddress, "bSetupUndoRedo");
		ClearArrayPin_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(ClearArrayPin_FunctionAddress, "bSetupUndoRedo");
		ClearArrayPin_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearArrayPin_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearArrayPin_bPrintPythonCommand_PropertyAddress, ClearArrayPin_FunctionAddress, "bPrintPythonCommand");
		ClearArrayPin_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(ClearArrayPin_FunctionAddress, "bPrintPythonCommand");
		ClearArrayPin_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearArrayPin_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearArrayPin_ReturnValue_PropertyAddress, ClearArrayPin_FunctionAddress, "ReturnValue");
		ClearArrayPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClearArrayPin_FunctionAddress, "ReturnValue");
		ClearArrayPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearArrayPin_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ClearArrayPin_IsValid = ClearArrayPin_FunctionAddress != IntPtr.Zero && ClearArrayPin_InArrayPinPath_IsValid && ClearArrayPin_bSetupUndoRedo_IsValid && ClearArrayPin_bPrintPythonCommand_IsValid && ClearArrayPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:ClearArrayPin", ClearArrayPin_IsValid);
		ChangeExposedPinType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ChangeExposedPinType");
		ChangeExposedPinType_ParamsSize = NativeReflection.GetFunctionParamsSize(ChangeExposedPinType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ChangeExposedPinType_InPinName_PropertyAddress, ChangeExposedPinType_FunctionAddress, "InPinName");
		ChangeExposedPinType_InPinName_Offset = NativeReflectionCached.GetPropertyOffset(ChangeExposedPinType_FunctionAddress, "InPinName");
		ChangeExposedPinType_InPinName_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeExposedPinType_FunctionAddress, "InPinName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeExposedPinType_InCPPType_PropertyAddress, ChangeExposedPinType_FunctionAddress, "InCPPType");
		ChangeExposedPinType_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(ChangeExposedPinType_FunctionAddress, "InCPPType");
		ChangeExposedPinType_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeExposedPinType_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeExposedPinType_InCPPTypeObjectPath_PropertyAddress, ChangeExposedPinType_FunctionAddress, "InCPPTypeObjectPath");
		ChangeExposedPinType_InCPPTypeObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(ChangeExposedPinType_FunctionAddress, "InCPPTypeObjectPath");
		ChangeExposedPinType_InCPPTypeObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeExposedPinType_FunctionAddress, "InCPPTypeObjectPath", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeExposedPinType_bSetupUndoRedo_PropertyAddress, ChangeExposedPinType_FunctionAddress, "bSetupUndoRedo");
		ChangeExposedPinType_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(ChangeExposedPinType_FunctionAddress, "bSetupUndoRedo");
		ChangeExposedPinType_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeExposedPinType_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeExposedPinType_bSetupOrphanPins_PropertyAddress, ChangeExposedPinType_FunctionAddress, "bSetupOrphanPins");
		ChangeExposedPinType_bSetupOrphanPins_Offset = NativeReflectionCached.GetPropertyOffset(ChangeExposedPinType_FunctionAddress, "bSetupOrphanPins");
		ChangeExposedPinType_bSetupOrphanPins_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeExposedPinType_FunctionAddress, "bSetupOrphanPins", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeExposedPinType_bPrintPythonCommand_PropertyAddress, ChangeExposedPinType_FunctionAddress, "bPrintPythonCommand");
		ChangeExposedPinType_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(ChangeExposedPinType_FunctionAddress, "bPrintPythonCommand");
		ChangeExposedPinType_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeExposedPinType_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ChangeExposedPinType_ReturnValue_PropertyAddress, ChangeExposedPinType_FunctionAddress, "ReturnValue");
		ChangeExposedPinType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ChangeExposedPinType_FunctionAddress, "ReturnValue");
		ChangeExposedPinType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeExposedPinType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ChangeExposedPinType_IsValid = ChangeExposedPinType_FunctionAddress != IntPtr.Zero && ChangeExposedPinType_InPinName_IsValid && ChangeExposedPinType_InCPPType_IsValid && ChangeExposedPinType_InCPPTypeObjectPath_IsValid && ChangeExposedPinType_bSetupUndoRedo_IsValid && ChangeExposedPinType_bSetupOrphanPins_IsValid && ChangeExposedPinType_bPrintPythonCommand_IsValid && ChangeExposedPinType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:ChangeExposedPinType", ChangeExposedPinType_IsValid);
		CanImportNodesFromText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanImportNodesFromText");
		CanImportNodesFromText_ParamsSize = NativeReflection.GetFunctionParamsSize(CanImportNodesFromText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanImportNodesFromText_InText_PropertyAddress, CanImportNodesFromText_FunctionAddress, "InText");
		CanImportNodesFromText_InText_Offset = NativeReflectionCached.GetPropertyOffset(CanImportNodesFromText_FunctionAddress, "InText");
		CanImportNodesFromText_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(CanImportNodesFromText_FunctionAddress, "InText", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CanImportNodesFromText_ReturnValue_PropertyAddress, CanImportNodesFromText_FunctionAddress, "ReturnValue");
		CanImportNodesFromText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanImportNodesFromText_FunctionAddress, "ReturnValue");
		CanImportNodesFromText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanImportNodesFromText_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanImportNodesFromText_IsValid = CanImportNodesFromText_FunctionAddress != IntPtr.Zero && CanImportNodesFromText_InText_IsValid && CanImportNodesFromText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:CanImportNodesFromText", CanImportNodesFromText_IsValid);
		CancelUndoBracket_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CancelUndoBracket");
		CancelUndoBracket_ParamsSize = NativeReflection.GetFunctionParamsSize(CancelUndoBracket_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CancelUndoBracket_ReturnValue_PropertyAddress, CancelUndoBracket_FunctionAddress, "ReturnValue");
		CancelUndoBracket_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CancelUndoBracket_FunctionAddress, "ReturnValue");
		CancelUndoBracket_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CancelUndoBracket_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CancelUndoBracket_IsValid = CancelUndoBracket_FunctionAddress != IntPtr.Zero && CancelUndoBracket_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:CancelUndoBracket", CancelUndoBracket_IsValid);
		BreakLink_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BreakLink");
		BreakLink_ParamsSize = NativeReflection.GetFunctionParamsSize(BreakLink_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BreakLink_InOutputPinPath_PropertyAddress, BreakLink_FunctionAddress, "InOutputPinPath");
		BreakLink_InOutputPinPath_Offset = NativeReflectionCached.GetPropertyOffset(BreakLink_FunctionAddress, "InOutputPinPath");
		BreakLink_InOutputPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakLink_FunctionAddress, "InOutputPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakLink_InInputPinPath_PropertyAddress, BreakLink_FunctionAddress, "InInputPinPath");
		BreakLink_InInputPinPath_Offset = NativeReflectionCached.GetPropertyOffset(BreakLink_FunctionAddress, "InInputPinPath");
		BreakLink_InInputPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakLink_FunctionAddress, "InInputPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakLink_bSetupUndoRedo_PropertyAddress, BreakLink_FunctionAddress, "bSetupUndoRedo");
		BreakLink_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(BreakLink_FunctionAddress, "bSetupUndoRedo");
		BreakLink_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakLink_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakLink_bPrintPythonCommand_PropertyAddress, BreakLink_FunctionAddress, "bPrintPythonCommand");
		BreakLink_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(BreakLink_FunctionAddress, "bPrintPythonCommand");
		BreakLink_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakLink_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakLink_ReturnValue_PropertyAddress, BreakLink_FunctionAddress, "ReturnValue");
		BreakLink_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BreakLink_FunctionAddress, "ReturnValue");
		BreakLink_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakLink_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BreakLink_IsValid = BreakLink_FunctionAddress != IntPtr.Zero && BreakLink_InOutputPinPath_IsValid && BreakLink_InInputPinPath_IsValid && BreakLink_bSetupUndoRedo_IsValid && BreakLink_bPrintPythonCommand_IsValid && BreakLink_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:BreakLink", BreakLink_IsValid);
		BreakAllLinks_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BreakAllLinks");
		BreakAllLinks_ParamsSize = NativeReflection.GetFunctionParamsSize(BreakAllLinks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BreakAllLinks_InPinPath_PropertyAddress, BreakAllLinks_FunctionAddress, "InPinPath");
		BreakAllLinks_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(BreakAllLinks_FunctionAddress, "InPinPath");
		BreakAllLinks_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakAllLinks_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakAllLinks_bAsInput_PropertyAddress, BreakAllLinks_FunctionAddress, "bAsInput");
		BreakAllLinks_bAsInput_Offset = NativeReflectionCached.GetPropertyOffset(BreakAllLinks_FunctionAddress, "bAsInput");
		BreakAllLinks_bAsInput_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakAllLinks_FunctionAddress, "bAsInput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakAllLinks_bSetupUndoRedo_PropertyAddress, BreakAllLinks_FunctionAddress, "bSetupUndoRedo");
		BreakAllLinks_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(BreakAllLinks_FunctionAddress, "bSetupUndoRedo");
		BreakAllLinks_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakAllLinks_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakAllLinks_bPrintPythonCommand_PropertyAddress, BreakAllLinks_FunctionAddress, "bPrintPythonCommand");
		BreakAllLinks_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(BreakAllLinks_FunctionAddress, "bPrintPythonCommand");
		BreakAllLinks_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakAllLinks_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakAllLinks_ReturnValue_PropertyAddress, BreakAllLinks_FunctionAddress, "ReturnValue");
		BreakAllLinks_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BreakAllLinks_FunctionAddress, "ReturnValue");
		BreakAllLinks_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakAllLinks_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BreakAllLinks_IsValid = BreakAllLinks_FunctionAddress != IntPtr.Zero && BreakAllLinks_InPinPath_IsValid && BreakAllLinks_bAsInput_IsValid && BreakAllLinks_bSetupUndoRedo_IsValid && BreakAllLinks_bPrintPythonCommand_IsValid && BreakAllLinks_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:BreakAllLinks", BreakAllLinks_IsValid);
		BindPinToVariable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BindPinToVariable");
		BindPinToVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(BindPinToVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BindPinToVariable_InPinPath_PropertyAddress, BindPinToVariable_FunctionAddress, "InPinPath");
		BindPinToVariable_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(BindPinToVariable_FunctionAddress, "InPinPath");
		BindPinToVariable_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(BindPinToVariable_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BindPinToVariable_InNewBoundVariablePath_PropertyAddress, BindPinToVariable_FunctionAddress, "InNewBoundVariablePath");
		BindPinToVariable_InNewBoundVariablePath_Offset = NativeReflectionCached.GetPropertyOffset(BindPinToVariable_FunctionAddress, "InNewBoundVariablePath");
		BindPinToVariable_InNewBoundVariablePath_IsValid = NativeReflectionCached.ValidatePropertyClass(BindPinToVariable_FunctionAddress, "InNewBoundVariablePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BindPinToVariable_bSetupUndoRedo_PropertyAddress, BindPinToVariable_FunctionAddress, "bSetupUndoRedo");
		BindPinToVariable_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(BindPinToVariable_FunctionAddress, "bSetupUndoRedo");
		BindPinToVariable_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(BindPinToVariable_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BindPinToVariable_bPrintPythonCommand_PropertyAddress, BindPinToVariable_FunctionAddress, "bPrintPythonCommand");
		BindPinToVariable_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(BindPinToVariable_FunctionAddress, "bPrintPythonCommand");
		BindPinToVariable_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(BindPinToVariable_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BindPinToVariable_ReturnValue_PropertyAddress, BindPinToVariable_FunctionAddress, "ReturnValue");
		BindPinToVariable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BindPinToVariable_FunctionAddress, "ReturnValue");
		BindPinToVariable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BindPinToVariable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BindPinToVariable_IsValid = BindPinToVariable_FunctionAddress != IntPtr.Zero && BindPinToVariable_InPinPath_IsValid && BindPinToVariable_InNewBoundVariablePath_IsValid && BindPinToVariable_bSetupUndoRedo_IsValid && BindPinToVariable_bPrintPythonCommand_IsValid && BindPinToVariable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:BindPinToVariable", BindPinToVariable_IsValid);
		AddVariableNodeFromObjectPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddVariableNodeFromObjectPath");
		AddVariableNodeFromObjectPath_ParamsSize = NativeReflection.GetFunctionParamsSize(AddVariableNodeFromObjectPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNodeFromObjectPath_InVariableName_PropertyAddress, AddVariableNodeFromObjectPath_FunctionAddress, "InVariableName");
		AddVariableNodeFromObjectPath_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNodeFromObjectPath_FunctionAddress, "InVariableName");
		AddVariableNodeFromObjectPath_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNodeFromObjectPath_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNodeFromObjectPath_InCPPType_PropertyAddress, AddVariableNodeFromObjectPath_FunctionAddress, "InCPPType");
		AddVariableNodeFromObjectPath_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNodeFromObjectPath_FunctionAddress, "InCPPType");
		AddVariableNodeFromObjectPath_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNodeFromObjectPath_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNodeFromObjectPath_InCPPTypeObjectPath_PropertyAddress, AddVariableNodeFromObjectPath_FunctionAddress, "InCPPTypeObjectPath");
		AddVariableNodeFromObjectPath_InCPPTypeObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNodeFromObjectPath_FunctionAddress, "InCPPTypeObjectPath");
		AddVariableNodeFromObjectPath_InCPPTypeObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNodeFromObjectPath_FunctionAddress, "InCPPTypeObjectPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNodeFromObjectPath_bIsGetter_PropertyAddress, AddVariableNodeFromObjectPath_FunctionAddress, "bIsGetter");
		AddVariableNodeFromObjectPath_bIsGetter_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNodeFromObjectPath_FunctionAddress, "bIsGetter");
		AddVariableNodeFromObjectPath_bIsGetter_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNodeFromObjectPath_FunctionAddress, "bIsGetter", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNodeFromObjectPath_InDefaultValue_PropertyAddress, AddVariableNodeFromObjectPath_FunctionAddress, "InDefaultValue");
		AddVariableNodeFromObjectPath_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNodeFromObjectPath_FunctionAddress, "InDefaultValue");
		AddVariableNodeFromObjectPath_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNodeFromObjectPath_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNodeFromObjectPath_InPosition_PropertyAddress, AddVariableNodeFromObjectPath_FunctionAddress, "InPosition");
		AddVariableNodeFromObjectPath_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNodeFromObjectPath_FunctionAddress, "InPosition");
		AddVariableNodeFromObjectPath_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNodeFromObjectPath_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNodeFromObjectPath_InNodeName_PropertyAddress, AddVariableNodeFromObjectPath_FunctionAddress, "InNodeName");
		AddVariableNodeFromObjectPath_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNodeFromObjectPath_FunctionAddress, "InNodeName");
		AddVariableNodeFromObjectPath_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNodeFromObjectPath_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNodeFromObjectPath_bSetupUndoRedo_PropertyAddress, AddVariableNodeFromObjectPath_FunctionAddress, "bSetupUndoRedo");
		AddVariableNodeFromObjectPath_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNodeFromObjectPath_FunctionAddress, "bSetupUndoRedo");
		AddVariableNodeFromObjectPath_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNodeFromObjectPath_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNodeFromObjectPath_bPrintPythonCommand_PropertyAddress, AddVariableNodeFromObjectPath_FunctionAddress, "bPrintPythonCommand");
		AddVariableNodeFromObjectPath_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNodeFromObjectPath_FunctionAddress, "bPrintPythonCommand");
		AddVariableNodeFromObjectPath_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNodeFromObjectPath_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNodeFromObjectPath_ReturnValue_PropertyAddress, AddVariableNodeFromObjectPath_FunctionAddress, "ReturnValue");
		AddVariableNodeFromObjectPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNodeFromObjectPath_FunctionAddress, "ReturnValue");
		AddVariableNodeFromObjectPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNodeFromObjectPath_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddVariableNodeFromObjectPath_IsValid = AddVariableNodeFromObjectPath_FunctionAddress != IntPtr.Zero && AddVariableNodeFromObjectPath_InVariableName_IsValid && AddVariableNodeFromObjectPath_InCPPType_IsValid && AddVariableNodeFromObjectPath_InCPPTypeObjectPath_IsValid && AddVariableNodeFromObjectPath_bIsGetter_IsValid && AddVariableNodeFromObjectPath_InDefaultValue_IsValid && AddVariableNodeFromObjectPath_InPosition_IsValid && AddVariableNodeFromObjectPath_InNodeName_IsValid && AddVariableNodeFromObjectPath_bSetupUndoRedo_IsValid && AddVariableNodeFromObjectPath_bPrintPythonCommand_IsValid && AddVariableNodeFromObjectPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddVariableNodeFromObjectPath", AddVariableNodeFromObjectPath_IsValid);
		AddVariableNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddVariableNode");
		AddVariableNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddVariableNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNode_InVariableName_PropertyAddress, AddVariableNode_FunctionAddress, "InVariableName");
		AddVariableNode_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNode_FunctionAddress, "InVariableName");
		AddVariableNode_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNode_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNode_InCPPType_PropertyAddress, AddVariableNode_FunctionAddress, "InCPPType");
		AddVariableNode_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNode_FunctionAddress, "InCPPType");
		AddVariableNode_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNode_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNode_InCPPTypeObject_PropertyAddress, AddVariableNode_FunctionAddress, "InCPPTypeObject");
		AddVariableNode_InCPPTypeObject_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNode_FunctionAddress, "InCPPTypeObject");
		AddVariableNode_InCPPTypeObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNode_FunctionAddress, "InCPPTypeObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNode_bIsGetter_PropertyAddress, AddVariableNode_FunctionAddress, "bIsGetter");
		AddVariableNode_bIsGetter_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNode_FunctionAddress, "bIsGetter");
		AddVariableNode_bIsGetter_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNode_FunctionAddress, "bIsGetter", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNode_InDefaultValue_PropertyAddress, AddVariableNode_FunctionAddress, "InDefaultValue");
		AddVariableNode_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNode_FunctionAddress, "InDefaultValue");
		AddVariableNode_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNode_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNode_InPosition_PropertyAddress, AddVariableNode_FunctionAddress, "InPosition");
		AddVariableNode_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNode_FunctionAddress, "InPosition");
		AddVariableNode_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNode_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNode_InNodeName_PropertyAddress, AddVariableNode_FunctionAddress, "InNodeName");
		AddVariableNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNode_FunctionAddress, "InNodeName");
		AddVariableNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNode_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNode_bSetupUndoRedo_PropertyAddress, AddVariableNode_FunctionAddress, "bSetupUndoRedo");
		AddVariableNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNode_FunctionAddress, "bSetupUndoRedo");
		AddVariableNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNode_bPrintPythonCommand_PropertyAddress, AddVariableNode_FunctionAddress, "bPrintPythonCommand");
		AddVariableNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNode_FunctionAddress, "bPrintPythonCommand");
		AddVariableNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVariableNode_ReturnValue_PropertyAddress, AddVariableNode_FunctionAddress, "ReturnValue");
		AddVariableNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddVariableNode_FunctionAddress, "ReturnValue");
		AddVariableNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVariableNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddVariableNode_IsValid = AddVariableNode_FunctionAddress != IntPtr.Zero && AddVariableNode_InVariableName_IsValid && AddVariableNode_InCPPType_IsValid && AddVariableNode_InCPPTypeObject_IsValid && AddVariableNode_bIsGetter_IsValid && AddVariableNode_InDefaultValue_IsValid && AddVariableNode_InPosition_IsValid && AddVariableNode_InNodeName_IsValid && AddVariableNode_bSetupUndoRedo_IsValid && AddVariableNode_bPrintPythonCommand_IsValid && AddVariableNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddVariableNode", AddVariableNode_IsValid);
		AddUnitNodeFromStructPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddUnitNodeFromStructPath");
		AddUnitNodeFromStructPath_ParamsSize = NativeReflection.GetFunctionParamsSize(AddUnitNodeFromStructPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddUnitNodeFromStructPath_InScriptStructPath_PropertyAddress, AddUnitNodeFromStructPath_FunctionAddress, "InScriptStructPath");
		AddUnitNodeFromStructPath_InScriptStructPath_Offset = NativeReflectionCached.GetPropertyOffset(AddUnitNodeFromStructPath_FunctionAddress, "InScriptStructPath");
		AddUnitNodeFromStructPath_InScriptStructPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUnitNodeFromStructPath_FunctionAddress, "InScriptStructPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUnitNodeFromStructPath_InMethodName_PropertyAddress, AddUnitNodeFromStructPath_FunctionAddress, "InMethodName");
		AddUnitNodeFromStructPath_InMethodName_Offset = NativeReflectionCached.GetPropertyOffset(AddUnitNodeFromStructPath_FunctionAddress, "InMethodName");
		AddUnitNodeFromStructPath_InMethodName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUnitNodeFromStructPath_FunctionAddress, "InMethodName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUnitNodeFromStructPath_InPosition_PropertyAddress, AddUnitNodeFromStructPath_FunctionAddress, "InPosition");
		AddUnitNodeFromStructPath_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddUnitNodeFromStructPath_FunctionAddress, "InPosition");
		AddUnitNodeFromStructPath_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUnitNodeFromStructPath_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUnitNodeFromStructPath_InNodeName_PropertyAddress, AddUnitNodeFromStructPath_FunctionAddress, "InNodeName");
		AddUnitNodeFromStructPath_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddUnitNodeFromStructPath_FunctionAddress, "InNodeName");
		AddUnitNodeFromStructPath_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUnitNodeFromStructPath_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUnitNodeFromStructPath_bSetupUndoRedo_PropertyAddress, AddUnitNodeFromStructPath_FunctionAddress, "bSetupUndoRedo");
		AddUnitNodeFromStructPath_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddUnitNodeFromStructPath_FunctionAddress, "bSetupUndoRedo");
		AddUnitNodeFromStructPath_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUnitNodeFromStructPath_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUnitNodeFromStructPath_bPrintPythonCommand_PropertyAddress, AddUnitNodeFromStructPath_FunctionAddress, "bPrintPythonCommand");
		AddUnitNodeFromStructPath_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddUnitNodeFromStructPath_FunctionAddress, "bPrintPythonCommand");
		AddUnitNodeFromStructPath_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUnitNodeFromStructPath_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUnitNodeFromStructPath_ReturnValue_PropertyAddress, AddUnitNodeFromStructPath_FunctionAddress, "ReturnValue");
		AddUnitNodeFromStructPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddUnitNodeFromStructPath_FunctionAddress, "ReturnValue");
		AddUnitNodeFromStructPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUnitNodeFromStructPath_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddUnitNodeFromStructPath_IsValid = AddUnitNodeFromStructPath_FunctionAddress != IntPtr.Zero && AddUnitNodeFromStructPath_InScriptStructPath_IsValid && AddUnitNodeFromStructPath_InMethodName_IsValid && AddUnitNodeFromStructPath_InPosition_IsValid && AddUnitNodeFromStructPath_InNodeName_IsValid && AddUnitNodeFromStructPath_bSetupUndoRedo_IsValid && AddUnitNodeFromStructPath_bPrintPythonCommand_IsValid && AddUnitNodeFromStructPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddUnitNodeFromStructPath", AddUnitNodeFromStructPath_IsValid);
		AddUnitNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddUnitNode");
		AddUnitNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddUnitNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddUnitNode_InScriptStruct_PropertyAddress, AddUnitNode_FunctionAddress, "InScriptStruct");
		AddUnitNode_InScriptStruct_Offset = NativeReflectionCached.GetPropertyOffset(AddUnitNode_FunctionAddress, "InScriptStruct");
		AddUnitNode_InScriptStruct_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUnitNode_FunctionAddress, "InScriptStruct", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUnitNode_InMethodName_PropertyAddress, AddUnitNode_FunctionAddress, "InMethodName");
		AddUnitNode_InMethodName_Offset = NativeReflectionCached.GetPropertyOffset(AddUnitNode_FunctionAddress, "InMethodName");
		AddUnitNode_InMethodName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUnitNode_FunctionAddress, "InMethodName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUnitNode_InPosition_PropertyAddress, AddUnitNode_FunctionAddress, "InPosition");
		AddUnitNode_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddUnitNode_FunctionAddress, "InPosition");
		AddUnitNode_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUnitNode_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUnitNode_InNodeName_PropertyAddress, AddUnitNode_FunctionAddress, "InNodeName");
		AddUnitNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddUnitNode_FunctionAddress, "InNodeName");
		AddUnitNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUnitNode_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUnitNode_bSetupUndoRedo_PropertyAddress, AddUnitNode_FunctionAddress, "bSetupUndoRedo");
		AddUnitNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddUnitNode_FunctionAddress, "bSetupUndoRedo");
		AddUnitNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUnitNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUnitNode_bPrintPythonCommand_PropertyAddress, AddUnitNode_FunctionAddress, "bPrintPythonCommand");
		AddUnitNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddUnitNode_FunctionAddress, "bPrintPythonCommand");
		AddUnitNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUnitNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddUnitNode_ReturnValue_PropertyAddress, AddUnitNode_FunctionAddress, "ReturnValue");
		AddUnitNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddUnitNode_FunctionAddress, "ReturnValue");
		AddUnitNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddUnitNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddUnitNode_IsValid = AddUnitNode_FunctionAddress != IntPtr.Zero && AddUnitNode_InScriptStruct_IsValid && AddUnitNode_InMethodName_IsValid && AddUnitNode_InPosition_IsValid && AddUnitNode_InNodeName_IsValid && AddUnitNode_bSetupUndoRedo_IsValid && AddUnitNode_bPrintPythonCommand_IsValid && AddUnitNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddUnitNode", AddUnitNode_IsValid);
		AddSelectNodeFromStruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddSelectNodeFromStruct");
		AddSelectNodeFromStruct_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSelectNodeFromStruct_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSelectNodeFromStruct_InScriptStruct_PropertyAddress, AddSelectNodeFromStruct_FunctionAddress, "InScriptStruct");
		AddSelectNodeFromStruct_InScriptStruct_Offset = NativeReflectionCached.GetPropertyOffset(AddSelectNodeFromStruct_FunctionAddress, "InScriptStruct");
		AddSelectNodeFromStruct_InScriptStruct_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSelectNodeFromStruct_FunctionAddress, "InScriptStruct", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSelectNodeFromStruct_InPosition_PropertyAddress, AddSelectNodeFromStruct_FunctionAddress, "InPosition");
		AddSelectNodeFromStruct_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddSelectNodeFromStruct_FunctionAddress, "InPosition");
		AddSelectNodeFromStruct_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSelectNodeFromStruct_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSelectNodeFromStruct_InNodeName_PropertyAddress, AddSelectNodeFromStruct_FunctionAddress, "InNodeName");
		AddSelectNodeFromStruct_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddSelectNodeFromStruct_FunctionAddress, "InNodeName");
		AddSelectNodeFromStruct_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSelectNodeFromStruct_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSelectNodeFromStruct_bSetupUndoRedo_PropertyAddress, AddSelectNodeFromStruct_FunctionAddress, "bSetupUndoRedo");
		AddSelectNodeFromStruct_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddSelectNodeFromStruct_FunctionAddress, "bSetupUndoRedo");
		AddSelectNodeFromStruct_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSelectNodeFromStruct_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSelectNodeFromStruct_ReturnValue_PropertyAddress, AddSelectNodeFromStruct_FunctionAddress, "ReturnValue");
		AddSelectNodeFromStruct_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddSelectNodeFromStruct_FunctionAddress, "ReturnValue");
		AddSelectNodeFromStruct_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSelectNodeFromStruct_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddSelectNodeFromStruct_IsValid = AddSelectNodeFromStruct_FunctionAddress != IntPtr.Zero && AddSelectNodeFromStruct_InScriptStruct_IsValid && AddSelectNodeFromStruct_InPosition_IsValid && AddSelectNodeFromStruct_InNodeName_IsValid && AddSelectNodeFromStruct_bSetupUndoRedo_IsValid && AddSelectNodeFromStruct_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddSelectNodeFromStruct", AddSelectNodeFromStruct_IsValid);
		AddSelectNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddSelectNode");
		AddSelectNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSelectNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSelectNode_InCPPType_PropertyAddress, AddSelectNode_FunctionAddress, "InCPPType");
		AddSelectNode_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(AddSelectNode_FunctionAddress, "InCPPType");
		AddSelectNode_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSelectNode_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSelectNode_InCPPTypeObjectPath_PropertyAddress, AddSelectNode_FunctionAddress, "InCPPTypeObjectPath");
		AddSelectNode_InCPPTypeObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(AddSelectNode_FunctionAddress, "InCPPTypeObjectPath");
		AddSelectNode_InCPPTypeObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSelectNode_FunctionAddress, "InCPPTypeObjectPath", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSelectNode_InPosition_PropertyAddress, AddSelectNode_FunctionAddress, "InPosition");
		AddSelectNode_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddSelectNode_FunctionAddress, "InPosition");
		AddSelectNode_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSelectNode_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSelectNode_InNodeName_PropertyAddress, AddSelectNode_FunctionAddress, "InNodeName");
		AddSelectNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddSelectNode_FunctionAddress, "InNodeName");
		AddSelectNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSelectNode_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSelectNode_bSetupUndoRedo_PropertyAddress, AddSelectNode_FunctionAddress, "bSetupUndoRedo");
		AddSelectNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddSelectNode_FunctionAddress, "bSetupUndoRedo");
		AddSelectNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSelectNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSelectNode_bPrintPythonCommand_PropertyAddress, AddSelectNode_FunctionAddress, "bPrintPythonCommand");
		AddSelectNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddSelectNode_FunctionAddress, "bPrintPythonCommand");
		AddSelectNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSelectNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSelectNode_ReturnValue_PropertyAddress, AddSelectNode_FunctionAddress, "ReturnValue");
		AddSelectNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddSelectNode_FunctionAddress, "ReturnValue");
		AddSelectNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSelectNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddSelectNode_IsValid = AddSelectNode_FunctionAddress != IntPtr.Zero && AddSelectNode_InCPPType_IsValid && AddSelectNode_InCPPTypeObjectPath_IsValid && AddSelectNode_InPosition_IsValid && AddSelectNode_InNodeName_IsValid && AddSelectNode_bSetupUndoRedo_IsValid && AddSelectNode_bPrintPythonCommand_IsValid && AddSelectNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddSelectNode", AddSelectNode_IsValid);
		AddRerouteNodeOnPin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddRerouteNodeOnPin");
		AddRerouteNodeOnPin_ParamsSize = NativeReflection.GetFunctionParamsSize(AddRerouteNodeOnPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnPin_InPinPath_PropertyAddress, AddRerouteNodeOnPin_FunctionAddress, "InPinPath");
		AddRerouteNodeOnPin_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnPin_FunctionAddress, "InPinPath");
		AddRerouteNodeOnPin_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnPin_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnPin_bAsInput_PropertyAddress, AddRerouteNodeOnPin_FunctionAddress, "bAsInput");
		AddRerouteNodeOnPin_bAsInput_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnPin_FunctionAddress, "bAsInput");
		AddRerouteNodeOnPin_bAsInput_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnPin_FunctionAddress, "bAsInput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnPin_bShowAsFullNode_PropertyAddress, AddRerouteNodeOnPin_FunctionAddress, "bShowAsFullNode");
		AddRerouteNodeOnPin_bShowAsFullNode_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnPin_FunctionAddress, "bShowAsFullNode");
		AddRerouteNodeOnPin_bShowAsFullNode_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnPin_FunctionAddress, "bShowAsFullNode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnPin_InPosition_PropertyAddress, AddRerouteNodeOnPin_FunctionAddress, "InPosition");
		AddRerouteNodeOnPin_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnPin_FunctionAddress, "InPosition");
		AddRerouteNodeOnPin_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnPin_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnPin_InNodeName_PropertyAddress, AddRerouteNodeOnPin_FunctionAddress, "InNodeName");
		AddRerouteNodeOnPin_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnPin_FunctionAddress, "InNodeName");
		AddRerouteNodeOnPin_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnPin_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnPin_bSetupUndoRedo_PropertyAddress, AddRerouteNodeOnPin_FunctionAddress, "bSetupUndoRedo");
		AddRerouteNodeOnPin_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnPin_FunctionAddress, "bSetupUndoRedo");
		AddRerouteNodeOnPin_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnPin_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnPin_bPrintPythonCommand_PropertyAddress, AddRerouteNodeOnPin_FunctionAddress, "bPrintPythonCommand");
		AddRerouteNodeOnPin_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnPin_FunctionAddress, "bPrintPythonCommand");
		AddRerouteNodeOnPin_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnPin_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnPin_ReturnValue_PropertyAddress, AddRerouteNodeOnPin_FunctionAddress, "ReturnValue");
		AddRerouteNodeOnPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnPin_FunctionAddress, "ReturnValue");
		AddRerouteNodeOnPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnPin_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddRerouteNodeOnPin_IsValid = AddRerouteNodeOnPin_FunctionAddress != IntPtr.Zero && AddRerouteNodeOnPin_InPinPath_IsValid && AddRerouteNodeOnPin_bAsInput_IsValid && AddRerouteNodeOnPin_bShowAsFullNode_IsValid && AddRerouteNodeOnPin_InPosition_IsValid && AddRerouteNodeOnPin_InNodeName_IsValid && AddRerouteNodeOnPin_bSetupUndoRedo_IsValid && AddRerouteNodeOnPin_bPrintPythonCommand_IsValid && AddRerouteNodeOnPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddRerouteNodeOnPin", AddRerouteNodeOnPin_IsValid);
		AddRerouteNodeOnLinkPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddRerouteNodeOnLinkPath");
		AddRerouteNodeOnLinkPath_ParamsSize = NativeReflection.GetFunctionParamsSize(AddRerouteNodeOnLinkPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnLinkPath_InLinkPinPathRepresentation_PropertyAddress, AddRerouteNodeOnLinkPath_FunctionAddress, "InLinkPinPathRepresentation");
		AddRerouteNodeOnLinkPath_InLinkPinPathRepresentation_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnLinkPath_FunctionAddress, "InLinkPinPathRepresentation");
		AddRerouteNodeOnLinkPath_InLinkPinPathRepresentation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnLinkPath_FunctionAddress, "InLinkPinPathRepresentation", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnLinkPath_bShowAsFullNode_PropertyAddress, AddRerouteNodeOnLinkPath_FunctionAddress, "bShowAsFullNode");
		AddRerouteNodeOnLinkPath_bShowAsFullNode_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnLinkPath_FunctionAddress, "bShowAsFullNode");
		AddRerouteNodeOnLinkPath_bShowAsFullNode_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnLinkPath_FunctionAddress, "bShowAsFullNode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnLinkPath_InPosition_PropertyAddress, AddRerouteNodeOnLinkPath_FunctionAddress, "InPosition");
		AddRerouteNodeOnLinkPath_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnLinkPath_FunctionAddress, "InPosition");
		AddRerouteNodeOnLinkPath_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnLinkPath_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnLinkPath_InNodeName_PropertyAddress, AddRerouteNodeOnLinkPath_FunctionAddress, "InNodeName");
		AddRerouteNodeOnLinkPath_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnLinkPath_FunctionAddress, "InNodeName");
		AddRerouteNodeOnLinkPath_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnLinkPath_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnLinkPath_bSetupUndoRedo_PropertyAddress, AddRerouteNodeOnLinkPath_FunctionAddress, "bSetupUndoRedo");
		AddRerouteNodeOnLinkPath_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnLinkPath_FunctionAddress, "bSetupUndoRedo");
		AddRerouteNodeOnLinkPath_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnLinkPath_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnLinkPath_bPrintPythonCommand_PropertyAddress, AddRerouteNodeOnLinkPath_FunctionAddress, "bPrintPythonCommand");
		AddRerouteNodeOnLinkPath_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnLinkPath_FunctionAddress, "bPrintPythonCommand");
		AddRerouteNodeOnLinkPath_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnLinkPath_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnLinkPath_ReturnValue_PropertyAddress, AddRerouteNodeOnLinkPath_FunctionAddress, "ReturnValue");
		AddRerouteNodeOnLinkPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnLinkPath_FunctionAddress, "ReturnValue");
		AddRerouteNodeOnLinkPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnLinkPath_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddRerouteNodeOnLinkPath_IsValid = AddRerouteNodeOnLinkPath_FunctionAddress != IntPtr.Zero && AddRerouteNodeOnLinkPath_InLinkPinPathRepresentation_IsValid && AddRerouteNodeOnLinkPath_bShowAsFullNode_IsValid && AddRerouteNodeOnLinkPath_InPosition_IsValid && AddRerouteNodeOnLinkPath_InNodeName_IsValid && AddRerouteNodeOnLinkPath_bSetupUndoRedo_IsValid && AddRerouteNodeOnLinkPath_bPrintPythonCommand_IsValid && AddRerouteNodeOnLinkPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddRerouteNodeOnLinkPath", AddRerouteNodeOnLinkPath_IsValid);
		AddRerouteNodeOnLink_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddRerouteNodeOnLink");
		AddRerouteNodeOnLink_ParamsSize = NativeReflection.GetFunctionParamsSize(AddRerouteNodeOnLink_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnLink_InLink_PropertyAddress, AddRerouteNodeOnLink_FunctionAddress, "InLink");
		AddRerouteNodeOnLink_InLink_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnLink_FunctionAddress, "InLink");
		AddRerouteNodeOnLink_InLink_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnLink_FunctionAddress, "InLink", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnLink_bShowAsFullNode_PropertyAddress, AddRerouteNodeOnLink_FunctionAddress, "bShowAsFullNode");
		AddRerouteNodeOnLink_bShowAsFullNode_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnLink_FunctionAddress, "bShowAsFullNode");
		AddRerouteNodeOnLink_bShowAsFullNode_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnLink_FunctionAddress, "bShowAsFullNode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnLink_InPosition_PropertyAddress, AddRerouteNodeOnLink_FunctionAddress, "InPosition");
		AddRerouteNodeOnLink_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnLink_FunctionAddress, "InPosition");
		AddRerouteNodeOnLink_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnLink_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnLink_InNodeName_PropertyAddress, AddRerouteNodeOnLink_FunctionAddress, "InNodeName");
		AddRerouteNodeOnLink_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnLink_FunctionAddress, "InNodeName");
		AddRerouteNodeOnLink_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnLink_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnLink_bSetupUndoRedo_PropertyAddress, AddRerouteNodeOnLink_FunctionAddress, "bSetupUndoRedo");
		AddRerouteNodeOnLink_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnLink_FunctionAddress, "bSetupUndoRedo");
		AddRerouteNodeOnLink_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnLink_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnLink_bPrintPythonCommand_PropertyAddress, AddRerouteNodeOnLink_FunctionAddress, "bPrintPythonCommand");
		AddRerouteNodeOnLink_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnLink_FunctionAddress, "bPrintPythonCommand");
		AddRerouteNodeOnLink_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnLink_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRerouteNodeOnLink_ReturnValue_PropertyAddress, AddRerouteNodeOnLink_FunctionAddress, "ReturnValue");
		AddRerouteNodeOnLink_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddRerouteNodeOnLink_FunctionAddress, "ReturnValue");
		AddRerouteNodeOnLink_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRerouteNodeOnLink_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddRerouteNodeOnLink_IsValid = AddRerouteNodeOnLink_FunctionAddress != IntPtr.Zero && AddRerouteNodeOnLink_InLink_IsValid && AddRerouteNodeOnLink_bShowAsFullNode_IsValid && AddRerouteNodeOnLink_InPosition_IsValid && AddRerouteNodeOnLink_InNodeName_IsValid && AddRerouteNodeOnLink_bSetupUndoRedo_IsValid && AddRerouteNodeOnLink_bPrintPythonCommand_IsValid && AddRerouteNodeOnLink_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddRerouteNodeOnLink", AddRerouteNodeOnLink_IsValid);
		AddPrototypeNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddPrototypeNode");
		AddPrototypeNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPrototypeNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddPrototypeNode_InNotation_PropertyAddress, AddPrototypeNode_FunctionAddress, "InNotation");
		AddPrototypeNode_InNotation_Offset = NativeReflectionCached.GetPropertyOffset(AddPrototypeNode_FunctionAddress, "InNotation");
		AddPrototypeNode_InNotation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPrototypeNode_FunctionAddress, "InNotation", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPrototypeNode_InPosition_PropertyAddress, AddPrototypeNode_FunctionAddress, "InPosition");
		AddPrototypeNode_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddPrototypeNode_FunctionAddress, "InPosition");
		AddPrototypeNode_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPrototypeNode_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPrototypeNode_InNodeName_PropertyAddress, AddPrototypeNode_FunctionAddress, "InNodeName");
		AddPrototypeNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddPrototypeNode_FunctionAddress, "InNodeName");
		AddPrototypeNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPrototypeNode_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPrototypeNode_bSetupUndoRedo_PropertyAddress, AddPrototypeNode_FunctionAddress, "bSetupUndoRedo");
		AddPrototypeNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddPrototypeNode_FunctionAddress, "bSetupUndoRedo");
		AddPrototypeNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPrototypeNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPrototypeNode_bPrintPythonCommand_PropertyAddress, AddPrototypeNode_FunctionAddress, "bPrintPythonCommand");
		AddPrototypeNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddPrototypeNode_FunctionAddress, "bPrintPythonCommand");
		AddPrototypeNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPrototypeNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPrototypeNode_ReturnValue_PropertyAddress, AddPrototypeNode_FunctionAddress, "ReturnValue");
		AddPrototypeNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddPrototypeNode_FunctionAddress, "ReturnValue");
		AddPrototypeNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPrototypeNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddPrototypeNode_IsValid = AddPrototypeNode_FunctionAddress != IntPtr.Zero && AddPrototypeNode_InNotation_IsValid && AddPrototypeNode_InPosition_IsValid && AddPrototypeNode_InNodeName_IsValid && AddPrototypeNode_bSetupUndoRedo_IsValid && AddPrototypeNode_bPrintPythonCommand_IsValid && AddPrototypeNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddPrototypeNode", AddPrototypeNode_IsValid);
		AddParameterNodeFromObjectPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddParameterNodeFromObjectPath");
		AddParameterNodeFromObjectPath_ParamsSize = NativeReflection.GetFunctionParamsSize(AddParameterNodeFromObjectPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNodeFromObjectPath_InParameterName_PropertyAddress, AddParameterNodeFromObjectPath_FunctionAddress, "InParameterName");
		AddParameterNodeFromObjectPath_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNodeFromObjectPath_FunctionAddress, "InParameterName");
		AddParameterNodeFromObjectPath_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNodeFromObjectPath_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNodeFromObjectPath_InCPPType_PropertyAddress, AddParameterNodeFromObjectPath_FunctionAddress, "InCPPType");
		AddParameterNodeFromObjectPath_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNodeFromObjectPath_FunctionAddress, "InCPPType");
		AddParameterNodeFromObjectPath_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNodeFromObjectPath_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNodeFromObjectPath_InCPPTypeObjectPath_PropertyAddress, AddParameterNodeFromObjectPath_FunctionAddress, "InCPPTypeObjectPath");
		AddParameterNodeFromObjectPath_InCPPTypeObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNodeFromObjectPath_FunctionAddress, "InCPPTypeObjectPath");
		AddParameterNodeFromObjectPath_InCPPTypeObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNodeFromObjectPath_FunctionAddress, "InCPPTypeObjectPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNodeFromObjectPath_bIsInput_PropertyAddress, AddParameterNodeFromObjectPath_FunctionAddress, "bIsInput");
		AddParameterNodeFromObjectPath_bIsInput_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNodeFromObjectPath_FunctionAddress, "bIsInput");
		AddParameterNodeFromObjectPath_bIsInput_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNodeFromObjectPath_FunctionAddress, "bIsInput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNodeFromObjectPath_InDefaultValue_PropertyAddress, AddParameterNodeFromObjectPath_FunctionAddress, "InDefaultValue");
		AddParameterNodeFromObjectPath_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNodeFromObjectPath_FunctionAddress, "InDefaultValue");
		AddParameterNodeFromObjectPath_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNodeFromObjectPath_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNodeFromObjectPath_InPosition_PropertyAddress, AddParameterNodeFromObjectPath_FunctionAddress, "InPosition");
		AddParameterNodeFromObjectPath_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNodeFromObjectPath_FunctionAddress, "InPosition");
		AddParameterNodeFromObjectPath_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNodeFromObjectPath_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNodeFromObjectPath_InNodeName_PropertyAddress, AddParameterNodeFromObjectPath_FunctionAddress, "InNodeName");
		AddParameterNodeFromObjectPath_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNodeFromObjectPath_FunctionAddress, "InNodeName");
		AddParameterNodeFromObjectPath_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNodeFromObjectPath_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNodeFromObjectPath_bSetupUndoRedo_PropertyAddress, AddParameterNodeFromObjectPath_FunctionAddress, "bSetupUndoRedo");
		AddParameterNodeFromObjectPath_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNodeFromObjectPath_FunctionAddress, "bSetupUndoRedo");
		AddParameterNodeFromObjectPath_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNodeFromObjectPath_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNodeFromObjectPath_bPrintPythonCommand_PropertyAddress, AddParameterNodeFromObjectPath_FunctionAddress, "bPrintPythonCommand");
		AddParameterNodeFromObjectPath_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNodeFromObjectPath_FunctionAddress, "bPrintPythonCommand");
		AddParameterNodeFromObjectPath_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNodeFromObjectPath_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNodeFromObjectPath_ReturnValue_PropertyAddress, AddParameterNodeFromObjectPath_FunctionAddress, "ReturnValue");
		AddParameterNodeFromObjectPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNodeFromObjectPath_FunctionAddress, "ReturnValue");
		AddParameterNodeFromObjectPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNodeFromObjectPath_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddParameterNodeFromObjectPath_IsValid = AddParameterNodeFromObjectPath_FunctionAddress != IntPtr.Zero && AddParameterNodeFromObjectPath_InParameterName_IsValid && AddParameterNodeFromObjectPath_InCPPType_IsValid && AddParameterNodeFromObjectPath_InCPPTypeObjectPath_IsValid && AddParameterNodeFromObjectPath_bIsInput_IsValid && AddParameterNodeFromObjectPath_InDefaultValue_IsValid && AddParameterNodeFromObjectPath_InPosition_IsValid && AddParameterNodeFromObjectPath_InNodeName_IsValid && AddParameterNodeFromObjectPath_bSetupUndoRedo_IsValid && AddParameterNodeFromObjectPath_bPrintPythonCommand_IsValid && AddParameterNodeFromObjectPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddParameterNodeFromObjectPath", AddParameterNodeFromObjectPath_IsValid);
		AddParameterNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddParameterNode");
		AddParameterNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddParameterNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNode_InParameterName_PropertyAddress, AddParameterNode_FunctionAddress, "InParameterName");
		AddParameterNode_InParameterName_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNode_FunctionAddress, "InParameterName");
		AddParameterNode_InParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNode_FunctionAddress, "InParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNode_InCPPType_PropertyAddress, AddParameterNode_FunctionAddress, "InCPPType");
		AddParameterNode_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNode_FunctionAddress, "InCPPType");
		AddParameterNode_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNode_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNode_InCPPTypeObject_PropertyAddress, AddParameterNode_FunctionAddress, "InCPPTypeObject");
		AddParameterNode_InCPPTypeObject_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNode_FunctionAddress, "InCPPTypeObject");
		AddParameterNode_InCPPTypeObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNode_FunctionAddress, "InCPPTypeObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNode_bIsInput_PropertyAddress, AddParameterNode_FunctionAddress, "bIsInput");
		AddParameterNode_bIsInput_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNode_FunctionAddress, "bIsInput");
		AddParameterNode_bIsInput_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNode_FunctionAddress, "bIsInput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNode_InDefaultValue_PropertyAddress, AddParameterNode_FunctionAddress, "InDefaultValue");
		AddParameterNode_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNode_FunctionAddress, "InDefaultValue");
		AddParameterNode_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNode_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNode_InPosition_PropertyAddress, AddParameterNode_FunctionAddress, "InPosition");
		AddParameterNode_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNode_FunctionAddress, "InPosition");
		AddParameterNode_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNode_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNode_InNodeName_PropertyAddress, AddParameterNode_FunctionAddress, "InNodeName");
		AddParameterNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNode_FunctionAddress, "InNodeName");
		AddParameterNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNode_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNode_bSetupUndoRedo_PropertyAddress, AddParameterNode_FunctionAddress, "bSetupUndoRedo");
		AddParameterNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNode_FunctionAddress, "bSetupUndoRedo");
		AddParameterNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNode_bPrintPythonCommand_PropertyAddress, AddParameterNode_FunctionAddress, "bPrintPythonCommand");
		AddParameterNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNode_FunctionAddress, "bPrintPythonCommand");
		AddParameterNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameterNode_ReturnValue_PropertyAddress, AddParameterNode_FunctionAddress, "ReturnValue");
		AddParameterNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddParameterNode_FunctionAddress, "ReturnValue");
		AddParameterNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameterNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddParameterNode_IsValid = AddParameterNode_FunctionAddress != IntPtr.Zero && AddParameterNode_InParameterName_IsValid && AddParameterNode_InCPPType_IsValid && AddParameterNode_InCPPTypeObject_IsValid && AddParameterNode_bIsInput_IsValid && AddParameterNode_InDefaultValue_IsValid && AddParameterNode_InPosition_IsValid && AddParameterNode_InNodeName_IsValid && AddParameterNode_bSetupUndoRedo_IsValid && AddParameterNode_bPrintPythonCommand_IsValid && AddParameterNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddParameterNode", AddParameterNode_IsValid);
		AddLocalVariableFromObjectPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddLocalVariableFromObjectPath");
		AddLocalVariableFromObjectPath_ParamsSize = NativeReflection.GetFunctionParamsSize(AddLocalVariableFromObjectPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddLocalVariableFromObjectPath_InVariableName_PropertyAddress, AddLocalVariableFromObjectPath_FunctionAddress, "InVariableName");
		AddLocalVariableFromObjectPath_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalVariableFromObjectPath_FunctionAddress, "InVariableName");
		AddLocalVariableFromObjectPath_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalVariableFromObjectPath_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalVariableFromObjectPath_InCPPType_PropertyAddress, AddLocalVariableFromObjectPath_FunctionAddress, "InCPPType");
		AddLocalVariableFromObjectPath_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalVariableFromObjectPath_FunctionAddress, "InCPPType");
		AddLocalVariableFromObjectPath_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalVariableFromObjectPath_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalVariableFromObjectPath_InCPPTypeObjectPath_PropertyAddress, AddLocalVariableFromObjectPath_FunctionAddress, "InCPPTypeObjectPath");
		AddLocalVariableFromObjectPath_InCPPTypeObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalVariableFromObjectPath_FunctionAddress, "InCPPTypeObjectPath");
		AddLocalVariableFromObjectPath_InCPPTypeObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalVariableFromObjectPath_FunctionAddress, "InCPPTypeObjectPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalVariableFromObjectPath_InDefaultValue_PropertyAddress, AddLocalVariableFromObjectPath_FunctionAddress, "InDefaultValue");
		AddLocalVariableFromObjectPath_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalVariableFromObjectPath_FunctionAddress, "InDefaultValue");
		AddLocalVariableFromObjectPath_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalVariableFromObjectPath_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalVariableFromObjectPath_bSetupUndoRedo_PropertyAddress, AddLocalVariableFromObjectPath_FunctionAddress, "bSetupUndoRedo");
		AddLocalVariableFromObjectPath_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalVariableFromObjectPath_FunctionAddress, "bSetupUndoRedo");
		AddLocalVariableFromObjectPath_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalVariableFromObjectPath_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalVariableFromObjectPath_ReturnValue_PropertyAddress, AddLocalVariableFromObjectPath_FunctionAddress, "ReturnValue");
		AddLocalVariableFromObjectPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalVariableFromObjectPath_FunctionAddress, "ReturnValue");
		AddLocalVariableFromObjectPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalVariableFromObjectPath_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddLocalVariableFromObjectPath_IsValid = AddLocalVariableFromObjectPath_FunctionAddress != IntPtr.Zero && AddLocalVariableFromObjectPath_InVariableName_IsValid && AddLocalVariableFromObjectPath_InCPPType_IsValid && AddLocalVariableFromObjectPath_InCPPTypeObjectPath_IsValid && AddLocalVariableFromObjectPath_InDefaultValue_IsValid && AddLocalVariableFromObjectPath_bSetupUndoRedo_IsValid && AddLocalVariableFromObjectPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddLocalVariableFromObjectPath", AddLocalVariableFromObjectPath_IsValid);
		AddLocalVariable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddLocalVariable");
		AddLocalVariable_ParamsSize = NativeReflection.GetFunctionParamsSize(AddLocalVariable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddLocalVariable_InVariableName_PropertyAddress, AddLocalVariable_FunctionAddress, "InVariableName");
		AddLocalVariable_InVariableName_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalVariable_FunctionAddress, "InVariableName");
		AddLocalVariable_InVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalVariable_FunctionAddress, "InVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalVariable_InCPPType_PropertyAddress, AddLocalVariable_FunctionAddress, "InCPPType");
		AddLocalVariable_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalVariable_FunctionAddress, "InCPPType");
		AddLocalVariable_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalVariable_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalVariable_InCPPTypeObject_PropertyAddress, AddLocalVariable_FunctionAddress, "InCPPTypeObject");
		AddLocalVariable_InCPPTypeObject_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalVariable_FunctionAddress, "InCPPTypeObject");
		AddLocalVariable_InCPPTypeObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalVariable_FunctionAddress, "InCPPTypeObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalVariable_InDefaultValue_PropertyAddress, AddLocalVariable_FunctionAddress, "InDefaultValue");
		AddLocalVariable_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalVariable_FunctionAddress, "InDefaultValue");
		AddLocalVariable_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalVariable_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalVariable_bSetupUndoRedo_PropertyAddress, AddLocalVariable_FunctionAddress, "bSetupUndoRedo");
		AddLocalVariable_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalVariable_FunctionAddress, "bSetupUndoRedo");
		AddLocalVariable_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalVariable_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalVariable_bPrintPythonCommand_PropertyAddress, AddLocalVariable_FunctionAddress, "bPrintPythonCommand");
		AddLocalVariable_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalVariable_FunctionAddress, "bPrintPythonCommand");
		AddLocalVariable_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalVariable_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLocalVariable_ReturnValue_PropertyAddress, AddLocalVariable_FunctionAddress, "ReturnValue");
		AddLocalVariable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddLocalVariable_FunctionAddress, "ReturnValue");
		AddLocalVariable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLocalVariable_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddLocalVariable_IsValid = AddLocalVariable_FunctionAddress != IntPtr.Zero && AddLocalVariable_InVariableName_IsValid && AddLocalVariable_InCPPType_IsValid && AddLocalVariable_InCPPTypeObject_IsValid && AddLocalVariable_InDefaultValue_IsValid && AddLocalVariable_bSetupUndoRedo_IsValid && AddLocalVariable_bPrintPythonCommand_IsValid && AddLocalVariable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddLocalVariable", AddLocalVariable_IsValid);
		AddLink_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddLink");
		AddLink_ParamsSize = NativeReflection.GetFunctionParamsSize(AddLink_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddLink_InOutputPinPath_PropertyAddress, AddLink_FunctionAddress, "InOutputPinPath");
		AddLink_InOutputPinPath_Offset = NativeReflectionCached.GetPropertyOffset(AddLink_FunctionAddress, "InOutputPinPath");
		AddLink_InOutputPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLink_FunctionAddress, "InOutputPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLink_InInputPinPath_PropertyAddress, AddLink_FunctionAddress, "InInputPinPath");
		AddLink_InInputPinPath_Offset = NativeReflectionCached.GetPropertyOffset(AddLink_FunctionAddress, "InInputPinPath");
		AddLink_InInputPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLink_FunctionAddress, "InInputPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLink_bSetupUndoRedo_PropertyAddress, AddLink_FunctionAddress, "bSetupUndoRedo");
		AddLink_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddLink_FunctionAddress, "bSetupUndoRedo");
		AddLink_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLink_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLink_bPrintPythonCommand_PropertyAddress, AddLink_FunctionAddress, "bPrintPythonCommand");
		AddLink_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddLink_FunctionAddress, "bPrintPythonCommand");
		AddLink_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLink_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLink_ReturnValue_PropertyAddress, AddLink_FunctionAddress, "ReturnValue");
		AddLink_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddLink_FunctionAddress, "ReturnValue");
		AddLink_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLink_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddLink_IsValid = AddLink_FunctionAddress != IntPtr.Zero && AddLink_InOutputPinPath_IsValid && AddLink_InInputPinPath_IsValid && AddLink_bSetupUndoRedo_IsValid && AddLink_bPrintPythonCommand_IsValid && AddLink_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddLink", AddLink_IsValid);
		AddInjectedNodeFromStructPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddInjectedNodeFromStructPath");
		AddInjectedNodeFromStructPath_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInjectedNodeFromStructPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNodeFromStructPath_InPinPath_PropertyAddress, AddInjectedNodeFromStructPath_FunctionAddress, "InPinPath");
		AddInjectedNodeFromStructPath_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNodeFromStructPath_FunctionAddress, "InPinPath");
		AddInjectedNodeFromStructPath_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNodeFromStructPath_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNodeFromStructPath_bAsInput_PropertyAddress, AddInjectedNodeFromStructPath_FunctionAddress, "bAsInput");
		AddInjectedNodeFromStructPath_bAsInput_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNodeFromStructPath_FunctionAddress, "bAsInput");
		AddInjectedNodeFromStructPath_bAsInput_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNodeFromStructPath_FunctionAddress, "bAsInput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNodeFromStructPath_InScriptStructPath_PropertyAddress, AddInjectedNodeFromStructPath_FunctionAddress, "InScriptStructPath");
		AddInjectedNodeFromStructPath_InScriptStructPath_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNodeFromStructPath_FunctionAddress, "InScriptStructPath");
		AddInjectedNodeFromStructPath_InScriptStructPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNodeFromStructPath_FunctionAddress, "InScriptStructPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNodeFromStructPath_InMethodName_PropertyAddress, AddInjectedNodeFromStructPath_FunctionAddress, "InMethodName");
		AddInjectedNodeFromStructPath_InMethodName_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNodeFromStructPath_FunctionAddress, "InMethodName");
		AddInjectedNodeFromStructPath_InMethodName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNodeFromStructPath_FunctionAddress, "InMethodName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNodeFromStructPath_InInputPinName_PropertyAddress, AddInjectedNodeFromStructPath_FunctionAddress, "InInputPinName");
		AddInjectedNodeFromStructPath_InInputPinName_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNodeFromStructPath_FunctionAddress, "InInputPinName");
		AddInjectedNodeFromStructPath_InInputPinName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNodeFromStructPath_FunctionAddress, "InInputPinName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNodeFromStructPath_InOutputPinName_PropertyAddress, AddInjectedNodeFromStructPath_FunctionAddress, "InOutputPinName");
		AddInjectedNodeFromStructPath_InOutputPinName_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNodeFromStructPath_FunctionAddress, "InOutputPinName");
		AddInjectedNodeFromStructPath_InOutputPinName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNodeFromStructPath_FunctionAddress, "InOutputPinName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNodeFromStructPath_InNodeName_PropertyAddress, AddInjectedNodeFromStructPath_FunctionAddress, "InNodeName");
		AddInjectedNodeFromStructPath_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNodeFromStructPath_FunctionAddress, "InNodeName");
		AddInjectedNodeFromStructPath_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNodeFromStructPath_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNodeFromStructPath_bSetupUndoRedo_PropertyAddress, AddInjectedNodeFromStructPath_FunctionAddress, "bSetupUndoRedo");
		AddInjectedNodeFromStructPath_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNodeFromStructPath_FunctionAddress, "bSetupUndoRedo");
		AddInjectedNodeFromStructPath_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNodeFromStructPath_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNodeFromStructPath_ReturnValue_PropertyAddress, AddInjectedNodeFromStructPath_FunctionAddress, "ReturnValue");
		AddInjectedNodeFromStructPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNodeFromStructPath_FunctionAddress, "ReturnValue");
		AddInjectedNodeFromStructPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNodeFromStructPath_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddInjectedNodeFromStructPath_IsValid = AddInjectedNodeFromStructPath_FunctionAddress != IntPtr.Zero && AddInjectedNodeFromStructPath_InPinPath_IsValid && AddInjectedNodeFromStructPath_bAsInput_IsValid && AddInjectedNodeFromStructPath_InScriptStructPath_IsValid && AddInjectedNodeFromStructPath_InMethodName_IsValid && AddInjectedNodeFromStructPath_InInputPinName_IsValid && AddInjectedNodeFromStructPath_InOutputPinName_IsValid && AddInjectedNodeFromStructPath_InNodeName_IsValid && AddInjectedNodeFromStructPath_bSetupUndoRedo_IsValid && AddInjectedNodeFromStructPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddInjectedNodeFromStructPath", AddInjectedNodeFromStructPath_IsValid);
		AddInjectedNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddInjectedNode");
		AddInjectedNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInjectedNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNode_InPinPath_PropertyAddress, AddInjectedNode_FunctionAddress, "InPinPath");
		AddInjectedNode_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNode_FunctionAddress, "InPinPath");
		AddInjectedNode_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNode_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNode_bAsInput_PropertyAddress, AddInjectedNode_FunctionAddress, "bAsInput");
		AddInjectedNode_bAsInput_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNode_FunctionAddress, "bAsInput");
		AddInjectedNode_bAsInput_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNode_FunctionAddress, "bAsInput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNode_InScriptStruct_PropertyAddress, AddInjectedNode_FunctionAddress, "InScriptStruct");
		AddInjectedNode_InScriptStruct_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNode_FunctionAddress, "InScriptStruct");
		AddInjectedNode_InScriptStruct_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNode_FunctionAddress, "InScriptStruct", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNode_InMethodName_PropertyAddress, AddInjectedNode_FunctionAddress, "InMethodName");
		AddInjectedNode_InMethodName_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNode_FunctionAddress, "InMethodName");
		AddInjectedNode_InMethodName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNode_FunctionAddress, "InMethodName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNode_InInputPinName_PropertyAddress, AddInjectedNode_FunctionAddress, "InInputPinName");
		AddInjectedNode_InInputPinName_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNode_FunctionAddress, "InInputPinName");
		AddInjectedNode_InInputPinName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNode_FunctionAddress, "InInputPinName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNode_InOutputPinName_PropertyAddress, AddInjectedNode_FunctionAddress, "InOutputPinName");
		AddInjectedNode_InOutputPinName_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNode_FunctionAddress, "InOutputPinName");
		AddInjectedNode_InOutputPinName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNode_FunctionAddress, "InOutputPinName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNode_InNodeName_PropertyAddress, AddInjectedNode_FunctionAddress, "InNodeName");
		AddInjectedNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNode_FunctionAddress, "InNodeName");
		AddInjectedNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNode_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNode_bSetupUndoRedo_PropertyAddress, AddInjectedNode_FunctionAddress, "bSetupUndoRedo");
		AddInjectedNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNode_FunctionAddress, "bSetupUndoRedo");
		AddInjectedNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNode_bPrintPythonCommand_PropertyAddress, AddInjectedNode_FunctionAddress, "bPrintPythonCommand");
		AddInjectedNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNode_FunctionAddress, "bPrintPythonCommand");
		AddInjectedNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInjectedNode_ReturnValue_PropertyAddress, AddInjectedNode_FunctionAddress, "ReturnValue");
		AddInjectedNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddInjectedNode_FunctionAddress, "ReturnValue");
		AddInjectedNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInjectedNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddInjectedNode_IsValid = AddInjectedNode_FunctionAddress != IntPtr.Zero && AddInjectedNode_InPinPath_IsValid && AddInjectedNode_bAsInput_IsValid && AddInjectedNode_InScriptStruct_IsValid && AddInjectedNode_InMethodName_IsValid && AddInjectedNode_InInputPinName_IsValid && AddInjectedNode_InOutputPinName_IsValid && AddInjectedNode_InNodeName_IsValid && AddInjectedNode_bSetupUndoRedo_IsValid && AddInjectedNode_bPrintPythonCommand_IsValid && AddInjectedNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddInjectedNode", AddInjectedNode_IsValid);
		AddIfNodeFromStruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddIfNodeFromStruct");
		AddIfNodeFromStruct_ParamsSize = NativeReflection.GetFunctionParamsSize(AddIfNodeFromStruct_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddIfNodeFromStruct_InScriptStruct_PropertyAddress, AddIfNodeFromStruct_FunctionAddress, "InScriptStruct");
		AddIfNodeFromStruct_InScriptStruct_Offset = NativeReflectionCached.GetPropertyOffset(AddIfNodeFromStruct_FunctionAddress, "InScriptStruct");
		AddIfNodeFromStruct_InScriptStruct_IsValid = NativeReflectionCached.ValidatePropertyClass(AddIfNodeFromStruct_FunctionAddress, "InScriptStruct", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddIfNodeFromStruct_InPosition_PropertyAddress, AddIfNodeFromStruct_FunctionAddress, "InPosition");
		AddIfNodeFromStruct_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddIfNodeFromStruct_FunctionAddress, "InPosition");
		AddIfNodeFromStruct_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddIfNodeFromStruct_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddIfNodeFromStruct_InNodeName_PropertyAddress, AddIfNodeFromStruct_FunctionAddress, "InNodeName");
		AddIfNodeFromStruct_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddIfNodeFromStruct_FunctionAddress, "InNodeName");
		AddIfNodeFromStruct_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddIfNodeFromStruct_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddIfNodeFromStruct_bSetupUndoRedo_PropertyAddress, AddIfNodeFromStruct_FunctionAddress, "bSetupUndoRedo");
		AddIfNodeFromStruct_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddIfNodeFromStruct_FunctionAddress, "bSetupUndoRedo");
		AddIfNodeFromStruct_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddIfNodeFromStruct_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddIfNodeFromStruct_ReturnValue_PropertyAddress, AddIfNodeFromStruct_FunctionAddress, "ReturnValue");
		AddIfNodeFromStruct_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddIfNodeFromStruct_FunctionAddress, "ReturnValue");
		AddIfNodeFromStruct_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddIfNodeFromStruct_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddIfNodeFromStruct_IsValid = AddIfNodeFromStruct_FunctionAddress != IntPtr.Zero && AddIfNodeFromStruct_InScriptStruct_IsValid && AddIfNodeFromStruct_InPosition_IsValid && AddIfNodeFromStruct_InNodeName_IsValid && AddIfNodeFromStruct_bSetupUndoRedo_IsValid && AddIfNodeFromStruct_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddIfNodeFromStruct", AddIfNodeFromStruct_IsValid);
		AddIfNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddIfNode");
		AddIfNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddIfNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddIfNode_InCPPType_PropertyAddress, AddIfNode_FunctionAddress, "InCPPType");
		AddIfNode_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(AddIfNode_FunctionAddress, "InCPPType");
		AddIfNode_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddIfNode_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddIfNode_InCPPTypeObjectPath_PropertyAddress, AddIfNode_FunctionAddress, "InCPPTypeObjectPath");
		AddIfNode_InCPPTypeObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(AddIfNode_FunctionAddress, "InCPPTypeObjectPath");
		AddIfNode_InCPPTypeObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddIfNode_FunctionAddress, "InCPPTypeObjectPath", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddIfNode_InPosition_PropertyAddress, AddIfNode_FunctionAddress, "InPosition");
		AddIfNode_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddIfNode_FunctionAddress, "InPosition");
		AddIfNode_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddIfNode_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddIfNode_InNodeName_PropertyAddress, AddIfNode_FunctionAddress, "InNodeName");
		AddIfNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddIfNode_FunctionAddress, "InNodeName");
		AddIfNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddIfNode_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddIfNode_bSetupUndoRedo_PropertyAddress, AddIfNode_FunctionAddress, "bSetupUndoRedo");
		AddIfNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddIfNode_FunctionAddress, "bSetupUndoRedo");
		AddIfNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddIfNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddIfNode_bPrintPythonCommand_PropertyAddress, AddIfNode_FunctionAddress, "bPrintPythonCommand");
		AddIfNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddIfNode_FunctionAddress, "bPrintPythonCommand");
		AddIfNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddIfNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddIfNode_ReturnValue_PropertyAddress, AddIfNode_FunctionAddress, "ReturnValue");
		AddIfNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddIfNode_FunctionAddress, "ReturnValue");
		AddIfNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddIfNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddIfNode_IsValid = AddIfNode_FunctionAddress != IntPtr.Zero && AddIfNode_InCPPType_IsValid && AddIfNode_InCPPTypeObjectPath_IsValid && AddIfNode_InPosition_IsValid && AddIfNode_InNodeName_IsValid && AddIfNode_bSetupUndoRedo_IsValid && AddIfNode_bPrintPythonCommand_IsValid && AddIfNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddIfNode", AddIfNode_IsValid);
		AddFunctionToLibrary_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddFunctionToLibrary");
		AddFunctionToLibrary_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFunctionToLibrary_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionToLibrary_InFunctionName_PropertyAddress, AddFunctionToLibrary_FunctionAddress, "InFunctionName");
		AddFunctionToLibrary_InFunctionName_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionToLibrary_FunctionAddress, "InFunctionName");
		AddFunctionToLibrary_InFunctionName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionToLibrary_FunctionAddress, "InFunctionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionToLibrary_bMutable_PropertyAddress, AddFunctionToLibrary_FunctionAddress, "bMutable");
		AddFunctionToLibrary_bMutable_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionToLibrary_FunctionAddress, "bMutable");
		AddFunctionToLibrary_bMutable_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionToLibrary_FunctionAddress, "bMutable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionToLibrary_InNodePosition_PropertyAddress, AddFunctionToLibrary_FunctionAddress, "InNodePosition");
		AddFunctionToLibrary_InNodePosition_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionToLibrary_FunctionAddress, "InNodePosition");
		AddFunctionToLibrary_InNodePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionToLibrary_FunctionAddress, "InNodePosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionToLibrary_bSetupUndoRedo_PropertyAddress, AddFunctionToLibrary_FunctionAddress, "bSetupUndoRedo");
		AddFunctionToLibrary_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionToLibrary_FunctionAddress, "bSetupUndoRedo");
		AddFunctionToLibrary_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionToLibrary_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionToLibrary_bPrintPythonCommand_PropertyAddress, AddFunctionToLibrary_FunctionAddress, "bPrintPythonCommand");
		AddFunctionToLibrary_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionToLibrary_FunctionAddress, "bPrintPythonCommand");
		AddFunctionToLibrary_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionToLibrary_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionToLibrary_ReturnValue_PropertyAddress, AddFunctionToLibrary_FunctionAddress, "ReturnValue");
		AddFunctionToLibrary_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionToLibrary_FunctionAddress, "ReturnValue");
		AddFunctionToLibrary_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionToLibrary_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddFunctionToLibrary_IsValid = AddFunctionToLibrary_FunctionAddress != IntPtr.Zero && AddFunctionToLibrary_InFunctionName_IsValid && AddFunctionToLibrary_bMutable_IsValid && AddFunctionToLibrary_InNodePosition_IsValid && AddFunctionToLibrary_bSetupUndoRedo_IsValid && AddFunctionToLibrary_bPrintPythonCommand_IsValid && AddFunctionToLibrary_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddFunctionToLibrary", AddFunctionToLibrary_IsValid);
		AddFunctionReferenceNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddFunctionReferenceNode");
		AddFunctionReferenceNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFunctionReferenceNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionReferenceNode_InFunctionDefinition_PropertyAddress, AddFunctionReferenceNode_FunctionAddress, "InFunctionDefinition");
		AddFunctionReferenceNode_InFunctionDefinition_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionReferenceNode_FunctionAddress, "InFunctionDefinition");
		AddFunctionReferenceNode_InFunctionDefinition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionReferenceNode_FunctionAddress, "InFunctionDefinition", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionReferenceNode_InNodePosition_PropertyAddress, AddFunctionReferenceNode_FunctionAddress, "InNodePosition");
		AddFunctionReferenceNode_InNodePosition_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionReferenceNode_FunctionAddress, "InNodePosition");
		AddFunctionReferenceNode_InNodePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionReferenceNode_FunctionAddress, "InNodePosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionReferenceNode_InNodeName_PropertyAddress, AddFunctionReferenceNode_FunctionAddress, "InNodeName");
		AddFunctionReferenceNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionReferenceNode_FunctionAddress, "InNodeName");
		AddFunctionReferenceNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionReferenceNode_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionReferenceNode_bSetupUndoRedo_PropertyAddress, AddFunctionReferenceNode_FunctionAddress, "bSetupUndoRedo");
		AddFunctionReferenceNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionReferenceNode_FunctionAddress, "bSetupUndoRedo");
		AddFunctionReferenceNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionReferenceNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionReferenceNode_bPrintPythonCommand_PropertyAddress, AddFunctionReferenceNode_FunctionAddress, "bPrintPythonCommand");
		AddFunctionReferenceNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionReferenceNode_FunctionAddress, "bPrintPythonCommand");
		AddFunctionReferenceNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionReferenceNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFunctionReferenceNode_ReturnValue_PropertyAddress, AddFunctionReferenceNode_FunctionAddress, "ReturnValue");
		AddFunctionReferenceNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddFunctionReferenceNode_FunctionAddress, "ReturnValue");
		AddFunctionReferenceNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFunctionReferenceNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddFunctionReferenceNode_IsValid = AddFunctionReferenceNode_FunctionAddress != IntPtr.Zero && AddFunctionReferenceNode_InFunctionDefinition_IsValid && AddFunctionReferenceNode_InNodePosition_IsValid && AddFunctionReferenceNode_InNodeName_IsValid && AddFunctionReferenceNode_bSetupUndoRedo_IsValid && AddFunctionReferenceNode_bPrintPythonCommand_IsValid && AddFunctionReferenceNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddFunctionReferenceNode", AddFunctionReferenceNode_IsValid);
		AddFreeRerouteNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddFreeRerouteNode");
		AddFreeRerouteNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFreeRerouteNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFreeRerouteNode_bShowAsFullNode_PropertyAddress, AddFreeRerouteNode_FunctionAddress, "bShowAsFullNode");
		AddFreeRerouteNode_bShowAsFullNode_Offset = NativeReflectionCached.GetPropertyOffset(AddFreeRerouteNode_FunctionAddress, "bShowAsFullNode");
		AddFreeRerouteNode_bShowAsFullNode_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFreeRerouteNode_FunctionAddress, "bShowAsFullNode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFreeRerouteNode_InCPPType_PropertyAddress, AddFreeRerouteNode_FunctionAddress, "InCPPType");
		AddFreeRerouteNode_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(AddFreeRerouteNode_FunctionAddress, "InCPPType");
		AddFreeRerouteNode_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFreeRerouteNode_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFreeRerouteNode_InCPPTypeObjectPath_PropertyAddress, AddFreeRerouteNode_FunctionAddress, "InCPPTypeObjectPath");
		AddFreeRerouteNode_InCPPTypeObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(AddFreeRerouteNode_FunctionAddress, "InCPPTypeObjectPath");
		AddFreeRerouteNode_InCPPTypeObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFreeRerouteNode_FunctionAddress, "InCPPTypeObjectPath", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFreeRerouteNode_bIsConstant_PropertyAddress, AddFreeRerouteNode_FunctionAddress, "bIsConstant");
		AddFreeRerouteNode_bIsConstant_Offset = NativeReflectionCached.GetPropertyOffset(AddFreeRerouteNode_FunctionAddress, "bIsConstant");
		AddFreeRerouteNode_bIsConstant_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFreeRerouteNode_FunctionAddress, "bIsConstant", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFreeRerouteNode_InCustomWidgetName_PropertyAddress, AddFreeRerouteNode_FunctionAddress, "InCustomWidgetName");
		AddFreeRerouteNode_InCustomWidgetName_Offset = NativeReflectionCached.GetPropertyOffset(AddFreeRerouteNode_FunctionAddress, "InCustomWidgetName");
		AddFreeRerouteNode_InCustomWidgetName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFreeRerouteNode_FunctionAddress, "InCustomWidgetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFreeRerouteNode_InDefaultValue_PropertyAddress, AddFreeRerouteNode_FunctionAddress, "InDefaultValue");
		AddFreeRerouteNode_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(AddFreeRerouteNode_FunctionAddress, "InDefaultValue");
		AddFreeRerouteNode_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFreeRerouteNode_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFreeRerouteNode_InPosition_PropertyAddress, AddFreeRerouteNode_FunctionAddress, "InPosition");
		AddFreeRerouteNode_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddFreeRerouteNode_FunctionAddress, "InPosition");
		AddFreeRerouteNode_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFreeRerouteNode_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFreeRerouteNode_InNodeName_PropertyAddress, AddFreeRerouteNode_FunctionAddress, "InNodeName");
		AddFreeRerouteNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddFreeRerouteNode_FunctionAddress, "InNodeName");
		AddFreeRerouteNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFreeRerouteNode_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFreeRerouteNode_bSetupUndoRedo_PropertyAddress, AddFreeRerouteNode_FunctionAddress, "bSetupUndoRedo");
		AddFreeRerouteNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddFreeRerouteNode_FunctionAddress, "bSetupUndoRedo");
		AddFreeRerouteNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFreeRerouteNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFreeRerouteNode_ReturnValue_PropertyAddress, AddFreeRerouteNode_FunctionAddress, "ReturnValue");
		AddFreeRerouteNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddFreeRerouteNode_FunctionAddress, "ReturnValue");
		AddFreeRerouteNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFreeRerouteNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddFreeRerouteNode_IsValid = AddFreeRerouteNode_FunctionAddress != IntPtr.Zero && AddFreeRerouteNode_bShowAsFullNode_IsValid && AddFreeRerouteNode_InCPPType_IsValid && AddFreeRerouteNode_InCPPTypeObjectPath_IsValid && AddFreeRerouteNode_bIsConstant_IsValid && AddFreeRerouteNode_InCustomWidgetName_IsValid && AddFreeRerouteNode_InDefaultValue_IsValid && AddFreeRerouteNode_InPosition_IsValid && AddFreeRerouteNode_InNodeName_IsValid && AddFreeRerouteNode_bSetupUndoRedo_IsValid && AddFreeRerouteNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddFreeRerouteNode", AddFreeRerouteNode_IsValid);
		AddExposedPin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddExposedPin");
		AddExposedPin_ParamsSize = NativeReflection.GetFunctionParamsSize(AddExposedPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddExposedPin_InPinName_PropertyAddress, AddExposedPin_FunctionAddress, "InPinName");
		AddExposedPin_InPinName_Offset = NativeReflectionCached.GetPropertyOffset(AddExposedPin_FunctionAddress, "InPinName");
		AddExposedPin_InPinName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddExposedPin_FunctionAddress, "InPinName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddExposedPin_InDirection_PropertyAddress, AddExposedPin_FunctionAddress, "InDirection");
		AddExposedPin_InDirection_Offset = NativeReflectionCached.GetPropertyOffset(AddExposedPin_FunctionAddress, "InDirection");
		AddExposedPin_InDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(AddExposedPin_FunctionAddress, "InDirection", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddExposedPin_InCPPType_PropertyAddress, AddExposedPin_FunctionAddress, "InCPPType");
		AddExposedPin_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(AddExposedPin_FunctionAddress, "InCPPType");
		AddExposedPin_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddExposedPin_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddExposedPin_InCPPTypeObjectPath_PropertyAddress, AddExposedPin_FunctionAddress, "InCPPTypeObjectPath");
		AddExposedPin_InCPPTypeObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(AddExposedPin_FunctionAddress, "InCPPTypeObjectPath");
		AddExposedPin_InCPPTypeObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddExposedPin_FunctionAddress, "InCPPTypeObjectPath", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddExposedPin_InDefaultValue_PropertyAddress, AddExposedPin_FunctionAddress, "InDefaultValue");
		AddExposedPin_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(AddExposedPin_FunctionAddress, "InDefaultValue");
		AddExposedPin_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddExposedPin_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddExposedPin_bSetupUndoRedo_PropertyAddress, AddExposedPin_FunctionAddress, "bSetupUndoRedo");
		AddExposedPin_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddExposedPin_FunctionAddress, "bSetupUndoRedo");
		AddExposedPin_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddExposedPin_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddExposedPin_bPrintPythonCommand_PropertyAddress, AddExposedPin_FunctionAddress, "bPrintPythonCommand");
		AddExposedPin_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddExposedPin_FunctionAddress, "bPrintPythonCommand");
		AddExposedPin_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddExposedPin_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddExposedPin_ReturnValue_PropertyAddress, AddExposedPin_FunctionAddress, "ReturnValue");
		AddExposedPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddExposedPin_FunctionAddress, "ReturnValue");
		AddExposedPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddExposedPin_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		AddExposedPin_IsValid = AddExposedPin_FunctionAddress != IntPtr.Zero && AddExposedPin_InPinName_IsValid && AddExposedPin_InDirection_IsValid && AddExposedPin_InCPPType_IsValid && AddExposedPin_InCPPTypeObjectPath_IsValid && AddExposedPin_InDefaultValue_IsValid && AddExposedPin_bSetupUndoRedo_IsValid && AddExposedPin_bPrintPythonCommand_IsValid && AddExposedPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddExposedPin", AddExposedPin_IsValid);
		AddEnumNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddEnumNode");
		AddEnumNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddEnumNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddEnumNode_InCPPTypeObjectPath_PropertyAddress, AddEnumNode_FunctionAddress, "InCPPTypeObjectPath");
		AddEnumNode_InCPPTypeObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(AddEnumNode_FunctionAddress, "InCPPTypeObjectPath");
		AddEnumNode_InCPPTypeObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEnumNode_FunctionAddress, "InCPPTypeObjectPath", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEnumNode_InPosition_PropertyAddress, AddEnumNode_FunctionAddress, "InPosition");
		AddEnumNode_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddEnumNode_FunctionAddress, "InPosition");
		AddEnumNode_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEnumNode_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEnumNode_InNodeName_PropertyAddress, AddEnumNode_FunctionAddress, "InNodeName");
		AddEnumNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddEnumNode_FunctionAddress, "InNodeName");
		AddEnumNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEnumNode_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEnumNode_bSetupUndoRedo_PropertyAddress, AddEnumNode_FunctionAddress, "bSetupUndoRedo");
		AddEnumNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddEnumNode_FunctionAddress, "bSetupUndoRedo");
		AddEnumNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEnumNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEnumNode_bPrintPythonCommand_PropertyAddress, AddEnumNode_FunctionAddress, "bPrintPythonCommand");
		AddEnumNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddEnumNode_FunctionAddress, "bPrintPythonCommand");
		AddEnumNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEnumNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEnumNode_ReturnValue_PropertyAddress, AddEnumNode_FunctionAddress, "ReturnValue");
		AddEnumNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddEnumNode_FunctionAddress, "ReturnValue");
		AddEnumNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEnumNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddEnumNode_IsValid = AddEnumNode_FunctionAddress != IntPtr.Zero && AddEnumNode_InCPPTypeObjectPath_IsValid && AddEnumNode_InPosition_IsValid && AddEnumNode_InNodeName_IsValid && AddEnumNode_bSetupUndoRedo_IsValid && AddEnumNode_bPrintPythonCommand_IsValid && AddEnumNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddEnumNode", AddEnumNode_IsValid);
		AddCommentNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddCommentNode");
		AddCommentNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddCommentNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddCommentNode_InCommentText_PropertyAddress, AddCommentNode_FunctionAddress, "InCommentText");
		AddCommentNode_InCommentText_Offset = NativeReflectionCached.GetPropertyOffset(AddCommentNode_FunctionAddress, "InCommentText");
		AddCommentNode_InCommentText_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCommentNode_FunctionAddress, "InCommentText", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCommentNode_InPosition_PropertyAddress, AddCommentNode_FunctionAddress, "InPosition");
		AddCommentNode_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddCommentNode_FunctionAddress, "InPosition");
		AddCommentNode_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCommentNode_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCommentNode_InSize_PropertyAddress, AddCommentNode_FunctionAddress, "InSize");
		AddCommentNode_InSize_Offset = NativeReflectionCached.GetPropertyOffset(AddCommentNode_FunctionAddress, "InSize");
		AddCommentNode_InSize_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCommentNode_FunctionAddress, "InSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCommentNode_InColor_PropertyAddress, AddCommentNode_FunctionAddress, "InColor");
		AddCommentNode_InColor_Offset = NativeReflectionCached.GetPropertyOffset(AddCommentNode_FunctionAddress, "InColor");
		AddCommentNode_InColor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCommentNode_FunctionAddress, "InColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCommentNode_InNodeName_PropertyAddress, AddCommentNode_FunctionAddress, "InNodeName");
		AddCommentNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddCommentNode_FunctionAddress, "InNodeName");
		AddCommentNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCommentNode_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCommentNode_bSetupUndoRedo_PropertyAddress, AddCommentNode_FunctionAddress, "bSetupUndoRedo");
		AddCommentNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddCommentNode_FunctionAddress, "bSetupUndoRedo");
		AddCommentNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCommentNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCommentNode_bPrintPythonCommand_PropertyAddress, AddCommentNode_FunctionAddress, "bPrintPythonCommand");
		AddCommentNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddCommentNode_FunctionAddress, "bPrintPythonCommand");
		AddCommentNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCommentNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCommentNode_ReturnValue_PropertyAddress, AddCommentNode_FunctionAddress, "ReturnValue");
		AddCommentNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddCommentNode_FunctionAddress, "ReturnValue");
		AddCommentNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCommentNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddCommentNode_IsValid = AddCommentNode_FunctionAddress != IntPtr.Zero && AddCommentNode_InCommentText_IsValid && AddCommentNode_InPosition_IsValid && AddCommentNode_InSize_IsValid && AddCommentNode_InColor_IsValid && AddCommentNode_InNodeName_IsValid && AddCommentNode_bSetupUndoRedo_IsValid && AddCommentNode_bPrintPythonCommand_IsValid && AddCommentNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddCommentNode", AddCommentNode_IsValid);
		AddBranchNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddBranchNode");
		AddBranchNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBranchNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBranchNode_InPosition_PropertyAddress, AddBranchNode_FunctionAddress, "InPosition");
		AddBranchNode_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddBranchNode_FunctionAddress, "InPosition");
		AddBranchNode_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBranchNode_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBranchNode_InNodeName_PropertyAddress, AddBranchNode_FunctionAddress, "InNodeName");
		AddBranchNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddBranchNode_FunctionAddress, "InNodeName");
		AddBranchNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBranchNode_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBranchNode_bSetupUndoRedo_PropertyAddress, AddBranchNode_FunctionAddress, "bSetupUndoRedo");
		AddBranchNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddBranchNode_FunctionAddress, "bSetupUndoRedo");
		AddBranchNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBranchNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBranchNode_bPrintPythonCommand_PropertyAddress, AddBranchNode_FunctionAddress, "bPrintPythonCommand");
		AddBranchNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddBranchNode_FunctionAddress, "bPrintPythonCommand");
		AddBranchNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBranchNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBranchNode_ReturnValue_PropertyAddress, AddBranchNode_FunctionAddress, "ReturnValue");
		AddBranchNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddBranchNode_FunctionAddress, "ReturnValue");
		AddBranchNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBranchNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddBranchNode_IsValid = AddBranchNode_FunctionAddress != IntPtr.Zero && AddBranchNode_InPosition_IsValid && AddBranchNode_InNodeName_IsValid && AddBranchNode_bSetupUndoRedo_IsValid && AddBranchNode_bPrintPythonCommand_IsValid && AddBranchNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddBranchNode", AddBranchNode_IsValid);
		AddArrayPin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddArrayPin");
		AddArrayPin_ParamsSize = NativeReflection.GetFunctionParamsSize(AddArrayPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddArrayPin_InArrayPinPath_PropertyAddress, AddArrayPin_FunctionAddress, "InArrayPinPath");
		AddArrayPin_InArrayPinPath_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayPin_FunctionAddress, "InArrayPinPath");
		AddArrayPin_InArrayPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayPin_FunctionAddress, "InArrayPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayPin_InDefaultValue_PropertyAddress, AddArrayPin_FunctionAddress, "InDefaultValue");
		AddArrayPin_InDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayPin_FunctionAddress, "InDefaultValue");
		AddArrayPin_InDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayPin_FunctionAddress, "InDefaultValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayPin_bSetupUndoRedo_PropertyAddress, AddArrayPin_FunctionAddress, "bSetupUndoRedo");
		AddArrayPin_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayPin_FunctionAddress, "bSetupUndoRedo");
		AddArrayPin_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayPin_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayPin_bPrintPythonCommand_PropertyAddress, AddArrayPin_FunctionAddress, "bPrintPythonCommand");
		AddArrayPin_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayPin_FunctionAddress, "bPrintPythonCommand");
		AddArrayPin_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayPin_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayPin_ReturnValue_PropertyAddress, AddArrayPin_FunctionAddress, "ReturnValue");
		AddArrayPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayPin_FunctionAddress, "ReturnValue");
		AddArrayPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayPin_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		AddArrayPin_IsValid = AddArrayPin_FunctionAddress != IntPtr.Zero && AddArrayPin_InArrayPinPath_IsValid && AddArrayPin_InDefaultValue_IsValid && AddArrayPin_bSetupUndoRedo_IsValid && AddArrayPin_bPrintPythonCommand_IsValid && AddArrayPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddArrayPin", AddArrayPin_IsValid);
		AddArrayNodeFromObjectPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddArrayNodeFromObjectPath");
		AddArrayNodeFromObjectPath_ParamsSize = NativeReflection.GetFunctionParamsSize(AddArrayNodeFromObjectPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNodeFromObjectPath_InOpCode_PropertyAddress, AddArrayNodeFromObjectPath_FunctionAddress, "InOpCode");
		AddArrayNodeFromObjectPath_InOpCode_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNodeFromObjectPath_FunctionAddress, "InOpCode");
		AddArrayNodeFromObjectPath_InOpCode_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNodeFromObjectPath_FunctionAddress, "InOpCode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNodeFromObjectPath_InCPPType_PropertyAddress, AddArrayNodeFromObjectPath_FunctionAddress, "InCPPType");
		AddArrayNodeFromObjectPath_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNodeFromObjectPath_FunctionAddress, "InCPPType");
		AddArrayNodeFromObjectPath_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNodeFromObjectPath_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNodeFromObjectPath_InCPPTypeObjectPath_PropertyAddress, AddArrayNodeFromObjectPath_FunctionAddress, "InCPPTypeObjectPath");
		AddArrayNodeFromObjectPath_InCPPTypeObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNodeFromObjectPath_FunctionAddress, "InCPPTypeObjectPath");
		AddArrayNodeFromObjectPath_InCPPTypeObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNodeFromObjectPath_FunctionAddress, "InCPPTypeObjectPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNodeFromObjectPath_InPosition_PropertyAddress, AddArrayNodeFromObjectPath_FunctionAddress, "InPosition");
		AddArrayNodeFromObjectPath_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNodeFromObjectPath_FunctionAddress, "InPosition");
		AddArrayNodeFromObjectPath_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNodeFromObjectPath_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNodeFromObjectPath_InNodeName_PropertyAddress, AddArrayNodeFromObjectPath_FunctionAddress, "InNodeName");
		AddArrayNodeFromObjectPath_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNodeFromObjectPath_FunctionAddress, "InNodeName");
		AddArrayNodeFromObjectPath_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNodeFromObjectPath_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNodeFromObjectPath_bSetupUndoRedo_PropertyAddress, AddArrayNodeFromObjectPath_FunctionAddress, "bSetupUndoRedo");
		AddArrayNodeFromObjectPath_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNodeFromObjectPath_FunctionAddress, "bSetupUndoRedo");
		AddArrayNodeFromObjectPath_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNodeFromObjectPath_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNodeFromObjectPath_bPrintPythonCommand_PropertyAddress, AddArrayNodeFromObjectPath_FunctionAddress, "bPrintPythonCommand");
		AddArrayNodeFromObjectPath_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNodeFromObjectPath_FunctionAddress, "bPrintPythonCommand");
		AddArrayNodeFromObjectPath_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNodeFromObjectPath_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNodeFromObjectPath_ReturnValue_PropertyAddress, AddArrayNodeFromObjectPath_FunctionAddress, "ReturnValue");
		AddArrayNodeFromObjectPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNodeFromObjectPath_FunctionAddress, "ReturnValue");
		AddArrayNodeFromObjectPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNodeFromObjectPath_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddArrayNodeFromObjectPath_IsValid = AddArrayNodeFromObjectPath_FunctionAddress != IntPtr.Zero && AddArrayNodeFromObjectPath_InOpCode_IsValid && AddArrayNodeFromObjectPath_InCPPType_IsValid && AddArrayNodeFromObjectPath_InCPPTypeObjectPath_IsValid && AddArrayNodeFromObjectPath_InPosition_IsValid && AddArrayNodeFromObjectPath_InNodeName_IsValid && AddArrayNodeFromObjectPath_bSetupUndoRedo_IsValid && AddArrayNodeFromObjectPath_bPrintPythonCommand_IsValid && AddArrayNodeFromObjectPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddArrayNodeFromObjectPath", AddArrayNodeFromObjectPath_IsValid);
		AddArrayNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddArrayNode");
		AddArrayNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddArrayNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNode_InOpCode_PropertyAddress, AddArrayNode_FunctionAddress, "InOpCode");
		AddArrayNode_InOpCode_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNode_FunctionAddress, "InOpCode");
		AddArrayNode_InOpCode_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNode_FunctionAddress, "InOpCode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNode_InCPPType_PropertyAddress, AddArrayNode_FunctionAddress, "InCPPType");
		AddArrayNode_InCPPType_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNode_FunctionAddress, "InCPPType");
		AddArrayNode_InCPPType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNode_FunctionAddress, "InCPPType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNode_InCPPTypeObject_PropertyAddress, AddArrayNode_FunctionAddress, "InCPPTypeObject");
		AddArrayNode_InCPPTypeObject_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNode_FunctionAddress, "InCPPTypeObject");
		AddArrayNode_InCPPTypeObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNode_FunctionAddress, "InCPPTypeObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNode_InPosition_PropertyAddress, AddArrayNode_FunctionAddress, "InPosition");
		AddArrayNode_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNode_FunctionAddress, "InPosition");
		AddArrayNode_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNode_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNode_InNodeName_PropertyAddress, AddArrayNode_FunctionAddress, "InNodeName");
		AddArrayNode_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNode_FunctionAddress, "InNodeName");
		AddArrayNode_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNode_FunctionAddress, "InNodeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNode_bSetupUndoRedo_PropertyAddress, AddArrayNode_FunctionAddress, "bSetupUndoRedo");
		AddArrayNode_bSetupUndoRedo_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNode_FunctionAddress, "bSetupUndoRedo");
		AddArrayNode_bSetupUndoRedo_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNode_FunctionAddress, "bSetupUndoRedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNode_bPrintPythonCommand_PropertyAddress, AddArrayNode_FunctionAddress, "bPrintPythonCommand");
		AddArrayNode_bPrintPythonCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNode_FunctionAddress, "bPrintPythonCommand");
		AddArrayNode_bPrintPythonCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNode_FunctionAddress, "bPrintPythonCommand", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddArrayNode_ReturnValue_PropertyAddress, AddArrayNode_FunctionAddress, "ReturnValue");
		AddArrayNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddArrayNode_FunctionAddress, "ReturnValue");
		AddArrayNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddArrayNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddArrayNode_IsValid = AddArrayNode_FunctionAddress != IntPtr.Zero && AddArrayNode_InOpCode_IsValid && AddArrayNode_InCPPType_IsValid && AddArrayNode_InCPPTypeObject_IsValid && AddArrayNode_InPosition_IsValid && AddArrayNode_InNodeName_IsValid && AddArrayNode_bSetupUndoRedo_IsValid && AddArrayNode_bPrintPythonCommand_IsValid && AddArrayNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMController:AddArrayNode", AddArrayNode_IsValid);
	}
}
