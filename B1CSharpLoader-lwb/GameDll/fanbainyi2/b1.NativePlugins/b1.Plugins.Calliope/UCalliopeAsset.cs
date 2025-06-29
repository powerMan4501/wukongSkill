using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Calliope.CalliopeAsset", "Calliope", UnrealModuleType.GamePlugin)]
public class UCalliopeAsset : UObject, IGsSmartParamObject, IInterface
{
	private static IntPtr classAddress;

	private static bool CustomInputs_IsValid;

	private static int CustomInputs_Offset;

	private static bool CustomOutputs_IsValid;

	private static int CustomOutputs_Offset;

	private static bool Nodes_IsValid;

	private static FFieldAddress Nodes_PropertyAddress;

	private static int Nodes_Offset;

	private TMapReadWriteMarshaler<FCalliopeGuid, UCalliopeNode> Nodes_MarshalerCached;

	private static bool PreloadedNodes_IsValid;

	private static FFieldAddress PreloadedNodes_PropertyAddress;

	private static int PreloadedNodes_Offset;

	private TSetReadWriteMarshaler<UCalliopeNode> PreloadedNodes_MarshalerCached;

	private static bool ActiveNodes_IsValid;

	private static FFieldAddress ActiveNodes_PropertyAddress;

	private static int ActiveNodes_Offset;

	private TArrayReadWriteMarshaler<UCalliopeNode> ActiveNodes_MarshalerCached;

	private static bool RecordedNodes_IsValid;

	private static FFieldAddress RecordedNodes_PropertyAddress;

	private static int RecordedNodes_Offset;

	private TArrayReadWriteMarshaler<UCalliopeNode> RecordedNodes_MarshalerCached;

	private static bool ExecuteHistory_IsValid;

	private static FFieldAddress ExecuteHistory_PropertyAddress;

	private static int ExecuteHistory_Offset;

	private TArrayReadWriteMarshaler<int> ExecuteHistory_MarshalerCached;

	private static bool BranchGraphNames_IsValid;

	private static FFieldAddress BranchGraphNames_PropertyAddress;

	private static int BranchGraphNames_Offset;

	private TSetReadWriteMarshaler<FName> BranchGraphNames_MarshalerCached;

	private static bool NeedPreloadAssets_IsValid;

	private static FFieldAddress NeedPreloadAssets_PropertyAddress;

	private static int NeedPreloadAssets_Offset;

	private TArrayReadWriteMarshaler<FSoftObjectPath> NeedPreloadAssets_MarshalerCached;

	private static bool CalliopeParameters_IsValid;

	private static int CalliopeParameters_Offset;

	private static bool SearchNodeGuid_IsValid;

	private static int SearchNodeGuid_Offset;

	private static bool SearchNodeIndex_IsValid;

	private static int SearchNodeIndex_Offset;

	private static bool UpdateParameterActorReferenceAndAliasName_IsValid;

	private static IntPtr UpdateParameterActorReferenceAndAliasName_FunctionAddress;

	private static int UpdateParameterActorReferenceAndAliasName_ParamsSize;

	private static bool UpdateParameterActorReferenceAndAliasName_ObjectPath_IsValid;

	private static FFieldAddress UpdateParameterActorReferenceAndAliasName_ObjectPath_PropertyAddress;

	private static int UpdateParameterActorReferenceAndAliasName_ObjectPath_Offset;

	private static bool UpdateParameterActorReferenceAndAliasName_ActorGuid_IsValid;

	private static FFieldAddress UpdateParameterActorReferenceAndAliasName_ActorGuid_PropertyAddress;

	private static int UpdateParameterActorReferenceAndAliasName_ActorGuid_Offset;

	private static bool UpdateParameterActorReferenceAndAliasName_AliasName_IsValid;

	private static FFieldAddress UpdateParameterActorReferenceAndAliasName_AliasName_PropertyAddress;

	private static int UpdateParameterActorReferenceAndAliasName_AliasName_Offset;

	private static bool UnregisterNode_IsValid;

	private IntPtr UnregisterNode_InstanceFunctionAddress;

	private static IntPtr UnregisterNode_FunctionAddress;

	private static int UnregisterNode_ParamsSize;

	private static bool UnregisterNode_NodeGuid_IsValid;

	private static FFieldAddress UnregisterNode_NodeGuid_PropertyAddress;

	private static int UnregisterNode_NodeGuid_Offset;

	private static bool StartInstance_IsValid;

	private static IntPtr StartInstance_FunctionAddress;

	private static int StartInstance_ParamsSize;

	private static bool StartAsSubInstance_IsValid;

	private static IntPtr StartAsSubInstance_FunctionAddress;

	private static int StartAsSubInstance_ParamsSize;

	private static bool StartAsSubInstance_ParentInstance_IsValid;

	private static FFieldAddress StartAsSubInstance_ParentInstance_PropertyAddress;

	private static int StartAsSubInstance_ParentInstance_Offset;

	private static bool StartAsSubInstance_InSubNodeGuid_IsValid;

	private static FFieldAddress StartAsSubInstance_InSubNodeGuid_PropertyAddress;

	private static int StartAsSubInstance_InSubNodeGuid_Offset;

	private static bool SetSubGraphAssetInPIE_IsValid;

	private static IntPtr SetSubGraphAssetInPIE_FunctionAddress;

	private static int SetSubGraphAssetInPIE_ParamsSize;

	private static bool SetSubGraphAssetInPIE_InGuid_IsValid;

	private static FFieldAddress SetSubGraphAssetInPIE_InGuid_PropertyAddress;

	private static int SetSubGraphAssetInPIE_InGuid_Offset;

	private static bool SetSubGraphAssetInPIE_CalliopeAsset_IsValid;

	private static FFieldAddress SetSubGraphAssetInPIE_CalliopeAsset_PropertyAddress;

	private static int SetSubGraphAssetInPIE_CalliopeAsset_Offset;

	private static bool RemoveBranchGraph_IsValid;

	private static IntPtr RemoveBranchGraph_FunctionAddress;

	private static int RemoveBranchGraph_ParamsSize;

	private static bool RemoveBranchGraph_GraphName_IsValid;

	private static FFieldAddress RemoveBranchGraph_GraphName_PropertyAddress;

	private static int RemoveBranchGraph_GraphName_Offset;

	private static bool RegisterNode_IsValid;

	private IntPtr RegisterNode_InstanceFunctionAddress;

	private static IntPtr RegisterNode_FunctionAddress;

	private static int RegisterNode_ParamsSize;

	private static bool RegisterNode_NewGuid_IsValid;

	private static FFieldAddress RegisterNode_NewGuid_PropertyAddress;

	private static int RegisterNode_NewGuid_Offset;

	private static bool RegisterNode_NewNode_IsValid;

	private static FFieldAddress RegisterNode_NewNode_PropertyAddress;

	private static int RegisterNode_NewNode_Offset;

	private static bool RecordOutput_IsValid;

	private static IntPtr RecordOutput_FunctionAddress;

	private static int RecordOutput_ParamsSize;

	private static bool RecordOutput_InGuid_IsValid;

	private static FFieldAddress RecordOutput_InGuid_PropertyAddress;

	private static int RecordOutput_InGuid_Offset;

	private static bool RecordOutput_InPinName_IsValid;

	private static FFieldAddress RecordOutput_InPinName_PropertyAddress;

	private static int RecordOutput_InPinName_Offset;

	private static bool RecordOnlyNode_IsValid;

	private static IntPtr RecordOnlyNode_FunctionAddress;

	private static int RecordOnlyNode_ParamsSize;

	private static bool RecordOnlyNode_InGuid_IsValid;

	private static FFieldAddress RecordOnlyNode_InGuid_PropertyAddress;

	private static int RecordOnlyNode_InGuid_Offset;

	private static bool RecordInput_IsValid;

	private static IntPtr RecordInput_FunctionAddress;

	private static int RecordInput_ParamsSize;

	private static bool RecordInput_InGuid_IsValid;

	private static FFieldAddress RecordInput_InGuid_PropertyAddress;

	private static int RecordInput_InGuid_Offset;

	private static bool RecordInput_InPinName_IsValid;

	private static FFieldAddress RecordInput_InPinName_PropertyAddress;

	private static int RecordInput_InPinName_Offset;

	private static bool PreFinishInstance_IsValid;

	private IntPtr PreFinishInstance_InstanceFunctionAddress;

	private static IntPtr PreFinishInstance_FunctionAddress;

	private static int PreFinishInstance_ParamsSize;

	private static bool PostStartInstance_IsValid;

	private IntPtr PostStartInstance_InstanceFunctionAddress;

	private static IntPtr PostStartInstance_FunctionAddress;

	private static int PostStartInstance_ParamsSize;

	private static bool PostRefreshAssetInCS_IsValid;

	private IntPtr PostRefreshAssetInCS_InstanceFunctionAddress;

	private static IntPtr PostRefreshAssetInCS_FunctionAddress;

	private static int PostRefreshAssetInCS_ParamsSize;

	private static bool PostDuplicateInCS_IsValid;

	private IntPtr PostDuplicateInCS_InstanceFunctionAddress;

	private static IntPtr PostDuplicateInCS_FunctionAddress;

	private static int PostDuplicateInCS_ParamsSize;

	private static bool PostDuplicateInCS_bDuplicateForPIE_IsValid;

	private static FFieldAddress PostDuplicateInCS_bDuplicateForPIE_PropertyAddress;

	private static int PostDuplicateInCS_bDuplicateForPIE_Offset;

	private static bool OnRefreshAssetInCS_IsValid;

	private IntPtr OnRefreshAssetInCS_InstanceFunctionAddress;

	private static IntPtr OnRefreshAssetInCS_FunctionAddress;

	private static int OnRefreshAssetInCS_ParamsSize;

	private static bool OnRefreshAsset_IsValid;

	private static IntPtr OnRefreshAsset_FunctionAddress;

	private static int OnRefreshAsset_ParamsSize;

	private static bool OnPropertyChanged_IsValid;

	private IntPtr OnPropertyChanged_InstanceFunctionAddress;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static int OnPropertyChanged_MemberName_Offset;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static bool OnNodeDeactivate_IsValid;

	private IntPtr OnNodeDeactivate_InstanceFunctionAddress;

	private static IntPtr OnNodeDeactivate_FunctionAddress;

	private static int OnNodeDeactivate_ParamsSize;

	private static bool OnNodeDeactivate_Node_IsValid;

	private static FFieldAddress OnNodeDeactivate_Node_PropertyAddress;

	private static int OnNodeDeactivate_Node_Offset;

	private static bool OnNodeActivate_IsValid;

	private IntPtr OnNodeActivate_InstanceFunctionAddress;

	private static IntPtr OnNodeActivate_FunctionAddress;

	private static int OnNodeActivate_ParamsSize;

	private static bool OnNodeActivate_Node_IsValid;

	private static FFieldAddress OnNodeActivate_Node_PropertyAddress;

	private static int OnNodeActivate_Node_Offset;

	private static bool IsEditorOnlyCS_IsValid;

	private IntPtr IsEditorOnlyCS_InstanceFunctionAddress;

	private static IntPtr IsEditorOnlyCS_FunctionAddress;

	private static int IsEditorOnlyCS_ParamsSize;

	private static bool IsEditorOnlyCS_ReturnValue_IsValid;

	private static FFieldAddress IsEditorOnlyCS_ReturnValue_PropertyAddress;

	private static int IsEditorOnlyCS_ReturnValue_Offset;

	private static bool HarvestNodeConnections_IsValid;

	private static IntPtr HarvestNodeConnections_FunctionAddress;

	private static int HarvestNodeConnections_ParamsSize;

	private static bool GetViewType_IsValid;

	private IntPtr GetViewType_InstanceFunctionAddress;

	private static IntPtr GetViewType_FunctionAddress;

	private static int GetViewType_ParamsSize;

	private static bool GetViewType_ReturnValue_IsValid;

	private static FFieldAddress GetViewType_ReturnValue_PropertyAddress;

	private static int GetViewType_ReturnValue_Offset;

	private static bool GetStartNodeClassInBranchGraph_IsValid;

	private IntPtr GetStartNodeClassInBranchGraph_InstanceFunctionAddress;

	private static IntPtr GetStartNodeClassInBranchGraph_FunctionAddress;

	private static int GetStartNodeClassInBranchGraph_ParamsSize;

	private static bool GetStartNodeClassInBranchGraph_ReturnValue_IsValid;

	private static FFieldAddress GetStartNodeClassInBranchGraph_ReturnValue_PropertyAddress;

	private static int GetStartNodeClassInBranchGraph_ReturnValue_Offset;

	private static bool GetStartNodeClass_IsValid;

	private IntPtr GetStartNodeClass_InstanceFunctionAddress;

	private static IntPtr GetStartNodeClass_FunctionAddress;

	private static int GetStartNodeClass_ParamsSize;

	private static bool GetStartNodeClass_ReturnValue_IsValid;

	private static FFieldAddress GetStartNodeClass_ReturnValue_PropertyAddress;

	private static int GetStartNodeClass_ReturnValue_Offset;

	private static bool GetRerouteNodeClassInBranchGraph_IsValid;

	private IntPtr GetRerouteNodeClassInBranchGraph_InstanceFunctionAddress;

	private static IntPtr GetRerouteNodeClassInBranchGraph_FunctionAddress;

	private static int GetRerouteNodeClassInBranchGraph_ParamsSize;

	private static bool GetRerouteNodeClassInBranchGraph_ReturnValue_IsValid;

	private static FFieldAddress GetRerouteNodeClassInBranchGraph_ReturnValue_PropertyAddress;

	private static int GetRerouteNodeClassInBranchGraph_ReturnValue_Offset;

	private static bool GetRerouteNodeClass_IsValid;

	private IntPtr GetRerouteNodeClass_InstanceFunctionAddress;

	private static IntPtr GetRerouteNodeClass_FunctionAddress;

	private static int GetRerouteNodeClass_ParamsSize;

	private static bool GetRerouteNodeClass_ReturnValue_IsValid;

	private static FFieldAddress GetRerouteNodeClass_ReturnValue_PropertyAddress;

	private static int GetRerouteNodeClass_ReturnValue_Offset;

	private static bool GetPossibleParamsCS_IsValid;

	private IntPtr GetPossibleParamsCS_InstanceFunctionAddress;

	private static IntPtr GetPossibleParamsCS_FunctionAddress;

	private static int GetPossibleParamsCS_ParamsSize;

	private static bool GetPossibleParamsCS_ParentPropertyName_IsValid;

	private static FFieldAddress GetPossibleParamsCS_ParentPropertyName_PropertyAddress;

	private static int GetPossibleParamsCS_ParentPropertyName_Offset;

	private static bool GetPossibleParamsCS_PropertyName_IsValid;

	private static FFieldAddress GetPossibleParamsCS_PropertyName_PropertyAddress;

	private static int GetPossibleParamsCS_PropertyName_Offset;

	private static bool GetPossibleParamsCS_OutParamArray_IsValid;

	private static FFieldAddress GetPossibleParamsCS_OutParamArray_PropertyAddress;

	private static int GetPossibleParamsCS_OutParamArray_Offset;

	private static bool GetPossibleParamsCS_ReturnValue_IsValid;

	private static FFieldAddress GetPossibleParamsCS_ReturnValue_PropertyAddress;

	private static int GetPossibleParamsCS_ReturnValue_Offset;

	private static bool GetParameterTaskStateIDByConfigGuid_IsValid;

	private static IntPtr GetParameterTaskStateIDByConfigGuid_FunctionAddress;

	private static int GetParameterTaskStateIDByConfigGuid_ParamsSize;

	private static bool GetParameterTaskStateIDByConfigGuid_InConfigGuid_IsValid;

	private static FFieldAddress GetParameterTaskStateIDByConfigGuid_InConfigGuid_PropertyAddress;

	private static int GetParameterTaskStateIDByConfigGuid_InConfigGuid_Offset;

	private static bool GetParameterTaskStateIDByConfigGuid_OutTaskStageID_IsValid;

	private static FFieldAddress GetParameterTaskStateIDByConfigGuid_OutTaskStageID_PropertyAddress;

	private static int GetParameterTaskStateIDByConfigGuid_OutTaskStageID_Offset;

	private static bool GetParameterTaskStateIDByConfigGuid_ReturnValue_IsValid;

	private static FFieldAddress GetParameterTaskStateIDByConfigGuid_ReturnValue_PropertyAddress;

	private static int GetParameterTaskStateIDByConfigGuid_ReturnValue_Offset;

	private static bool GetParameterSequenceIDByConfigGuid_IsValid;

	private static IntPtr GetParameterSequenceIDByConfigGuid_FunctionAddress;

	private static int GetParameterSequenceIDByConfigGuid_ParamsSize;

	private static bool GetParameterSequenceIDByConfigGuid_InConfigGuid_IsValid;

	private static FFieldAddress GetParameterSequenceIDByConfigGuid_InConfigGuid_PropertyAddress;

	private static int GetParameterSequenceIDByConfigGuid_InConfigGuid_Offset;

	private static bool GetParameterSequenceIDByConfigGuid_OutSequenceID_IsValid;

	private static FFieldAddress GetParameterSequenceIDByConfigGuid_OutSequenceID_PropertyAddress;

	private static int GetParameterSequenceIDByConfigGuid_OutSequenceID_Offset;

	private static bool GetParameterSequenceIDByConfigGuid_ReturnValue_IsValid;

	private static FFieldAddress GetParameterSequenceIDByConfigGuid_ReturnValue_PropertyAddress;

	private static int GetParameterSequenceIDByConfigGuid_ReturnValue_Offset;

	private static bool GetParameterDisplayNameByConfigGuid_IsValid;

	private static IntPtr GetParameterDisplayNameByConfigGuid_FunctionAddress;

	private static int GetParameterDisplayNameByConfigGuid_ParamsSize;

	private static bool GetParameterDisplayNameByConfigGuid_InConfigGuid_IsValid;

	private static FFieldAddress GetParameterDisplayNameByConfigGuid_InConfigGuid_PropertyAddress;

	private static int GetParameterDisplayNameByConfigGuid_InConfigGuid_Offset;

	private static bool GetParameterDisplayNameByConfigGuid_InPropertyName_IsValid;

	private static FFieldAddress GetParameterDisplayNameByConfigGuid_InPropertyName_PropertyAddress;

	private static int GetParameterDisplayNameByConfigGuid_InPropertyName_Offset;

	private static bool GetParameterDisplayNameByConfigGuid_OutDisplayName_IsValid;

	private static FFieldAddress GetParameterDisplayNameByConfigGuid_OutDisplayName_PropertyAddress;

	private static int GetParameterDisplayNameByConfigGuid_OutDisplayName_Offset;

	private static bool GetParameterDisplayNameByConfigGuid_ReturnValue_IsValid;

	private static FFieldAddress GetParameterDisplayNameByConfigGuid_ReturnValue_PropertyAddress;

	private static int GetParameterDisplayNameByConfigGuid_ReturnValue_Offset;

	private static bool GetParameterConfigGuidByActorGuid_IsValid;

	private static IntPtr GetParameterConfigGuidByActorGuid_FunctionAddress;

	private static int GetParameterConfigGuidByActorGuid_ParamsSize;

	private static bool GetParameterConfigGuidByActorGuid_ParamType_IsValid;

	private static FFieldAddress GetParameterConfigGuidByActorGuid_ParamType_PropertyAddress;

	private static int GetParameterConfigGuidByActorGuid_ParamType_Offset;

	private static bool GetParameterConfigGuidByActorGuid_ParamValueString_IsValid;

	private static FFieldAddress GetParameterConfigGuidByActorGuid_ParamValueString_PropertyAddress;

	private static int GetParameterConfigGuidByActorGuid_ParamValueString_Offset;

	private static bool GetParameterConfigGuidByActorGuid_ParamValueInt_IsValid;

	private static FFieldAddress GetParameterConfigGuidByActorGuid_ParamValueInt_PropertyAddress;

	private static int GetParameterConfigGuidByActorGuid_ParamValueInt_Offset;

	private static bool GetParameterConfigGuidByActorGuid_ParamValueName_IsValid;

	private static FFieldAddress GetParameterConfigGuidByActorGuid_ParamValueName_PropertyAddress;

	private static int GetParameterConfigGuidByActorGuid_ParamValueName_Offset;

	private static bool GetParameterConfigGuidByActorGuid_OutGuid_IsValid;

	private static FFieldAddress GetParameterConfigGuidByActorGuid_OutGuid_PropertyAddress;

	private static int GetParameterConfigGuidByActorGuid_OutGuid_Offset;

	private static bool GetParameterConfigGuidByActorGuid_ReturnValue_IsValid;

	private static FFieldAddress GetParameterConfigGuidByActorGuid_ReturnValue_PropertyAddress;

	private static int GetParameterConfigGuidByActorGuid_ReturnValue_Offset;

	private static bool GetParameterBuffIDByConfigGuid_IsValid;

	private static IntPtr GetParameterBuffIDByConfigGuid_FunctionAddress;

	private static int GetParameterBuffIDByConfigGuid_ParamsSize;

	private static bool GetParameterBuffIDByConfigGuid_InConfigGuid_IsValid;

	private static FFieldAddress GetParameterBuffIDByConfigGuid_InConfigGuid_PropertyAddress;

	private static int GetParameterBuffIDByConfigGuid_InConfigGuid_Offset;

	private static bool GetParameterBuffIDByConfigGuid_OutBuffID_IsValid;

	private static FFieldAddress GetParameterBuffIDByConfigGuid_OutBuffID_PropertyAddress;

	private static int GetParameterBuffIDByConfigGuid_OutBuffID_Offset;

	private static bool GetParameterBuffIDByConfigGuid_ReturnValue_IsValid;

	private static FFieldAddress GetParameterBuffIDByConfigGuid_ReturnValue_PropertyAddress;

	private static int GetParameterBuffIDByConfigGuid_ReturnValue_Offset;

	private static bool GetParameterActorGuidByConfigGuid_IsValid;

	private static IntPtr GetParameterActorGuidByConfigGuid_FunctionAddress;

	private static int GetParameterActorGuidByConfigGuid_ParamsSize;

	private static bool GetParameterActorGuidByConfigGuid_InConfigGuid_IsValid;

	private static FFieldAddress GetParameterActorGuidByConfigGuid_InConfigGuid_PropertyAddress;

	private static int GetParameterActorGuidByConfigGuid_InConfigGuid_Offset;

	private static bool GetParameterActorGuidByConfigGuid_OutActorGuid_IsValid;

	private static FFieldAddress GetParameterActorGuidByConfigGuid_OutActorGuid_PropertyAddress;

	private static int GetParameterActorGuidByConfigGuid_OutActorGuid_Offset;

	private static bool GetParameterActorGuidByConfigGuid_ReturnValue_IsValid;

	private static FFieldAddress GetParameterActorGuidByConfigGuid_ReturnValue_PropertyAddress;

	private static int GetParameterActorGuidByConfigGuid_ReturnValue_Offset;

	private static bool GetParamDisplayNameCS_IsValid;

	private IntPtr GetParamDisplayNameCS_InstanceFunctionAddress;

	private static IntPtr GetParamDisplayNameCS_FunctionAddress;

	private static int GetParamDisplayNameCS_ParamsSize;

	private static bool GetParamDisplayNameCS_PropertyName_IsValid;

	private static FFieldAddress GetParamDisplayNameCS_PropertyName_PropertyAddress;

	private static int GetParamDisplayNameCS_PropertyName_Offset;

	private static bool GetParamDisplayNameCS_InConfigGuid_IsValid;

	private static FFieldAddress GetParamDisplayNameCS_InConfigGuid_PropertyAddress;

	private static int GetParamDisplayNameCS_InConfigGuid_Offset;

	private static bool GetParamDisplayNameCS_OutDisplayName_IsValid;

	private static FFieldAddress GetParamDisplayNameCS_OutDisplayName_PropertyAddress;

	private static int GetParamDisplayNameCS_OutDisplayName_Offset;

	private static bool GetParamDisplayNameCS_ReturnValue_IsValid;

	private static FFieldAddress GetParamDisplayNameCS_ReturnValue_PropertyAddress;

	private static int GetParamDisplayNameCS_ReturnValue_Offset;

	private static bool GetNodes_IsValid;

	private IntPtr GetNodes_InstanceFunctionAddress;

	private static IntPtr GetNodes_FunctionAddress;

	private static int GetNodes_ParamsSize;

	private static bool GetNodes_ReturnValue_IsValid;

	private static FFieldAddress GetNodes_ReturnValue_PropertyAddress;

	private static int GetNodes_ReturnValue_Offset;

	private static bool GetNode_IsValid;

	private IntPtr GetNode_InstanceFunctionAddress;

	private static IntPtr GetNode_FunctionAddress;

	private static int GetNode_ParamsSize;

	private static bool GetNode_InGuid_IsValid;

	private static FFieldAddress GetNode_InGuid_PropertyAddress;

	private static int GetNode_InGuid_Offset;

	private static bool GetNode_ReturnValue_IsValid;

	private static FFieldAddress GetNode_ReturnValue_PropertyAddress;

	private static int GetNode_ReturnValue_Offset;

	private static bool GetExtraDefaultOutputNodesInBranchGraph_IsValid;

	private IntPtr GetExtraDefaultOutputNodesInBranchGraph_InstanceFunctionAddress;

	private static IntPtr GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress;

	private static int GetExtraDefaultOutputNodesInBranchGraph_ParamsSize;

	private static bool GetExtraDefaultOutputNodesInBranchGraph_OutClasses_IsValid;

	private static FFieldAddress GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress;

	private static int GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset;

	private static bool GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_IsValid;

	private static FFieldAddress GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_PropertyAddress;

	private static int GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_Offset;

	private static bool GetExtraDefaultOutputNodes_IsValid;

	private IntPtr GetExtraDefaultOutputNodes_InstanceFunctionAddress;

	private static IntPtr GetExtraDefaultOutputNodes_FunctionAddress;

	private static int GetExtraDefaultOutputNodes_ParamsSize;

	private static bool GetExtraDefaultOutputNodes_OutClasses_IsValid;

	private static FFieldAddress GetExtraDefaultOutputNodes_OutClasses_PropertyAddress;

	private static int GetExtraDefaultOutputNodes_OutClasses_Offset;

	private static bool GetExtraDefaultOutputNodes_ReturnValue_IsValid;

	private static FFieldAddress GetExtraDefaultOutputNodes_ReturnValue_PropertyAddress;

	private static int GetExtraDefaultOutputNodes_ReturnValue_Offset;

	private static bool GetExtraDefaultInputNodesInBranchGraph_IsValid;

	private IntPtr GetExtraDefaultInputNodesInBranchGraph_InstanceFunctionAddress;

	private static IntPtr GetExtraDefaultInputNodesInBranchGraph_FunctionAddress;

	private static int GetExtraDefaultInputNodesInBranchGraph_ParamsSize;

	private static bool GetExtraDefaultInputNodesInBranchGraph_OutClasses_IsValid;

	private static FFieldAddress GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress;

	private static int GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset;

	private static bool GetExtraDefaultInputNodesInBranchGraph_ReturnValue_IsValid;

	private static FFieldAddress GetExtraDefaultInputNodesInBranchGraph_ReturnValue_PropertyAddress;

	private static int GetExtraDefaultInputNodesInBranchGraph_ReturnValue_Offset;

	private static bool GetExtraDefaultInputNodes_IsValid;

	private IntPtr GetExtraDefaultInputNodes_InstanceFunctionAddress;

	private static IntPtr GetExtraDefaultInputNodes_FunctionAddress;

	private static int GetExtraDefaultInputNodes_ParamsSize;

	private static bool GetExtraDefaultInputNodes_OutClasses_IsValid;

	private static FFieldAddress GetExtraDefaultInputNodes_OutClasses_PropertyAddress;

	private static int GetExtraDefaultInputNodes_OutClasses_Offset;

	private static bool GetExtraDefaultInputNodes_ReturnValue_IsValid;

	private static FFieldAddress GetExtraDefaultInputNodes_ReturnValue_PropertyAddress;

	private static int GetExtraDefaultInputNodes_ReturnValue_Offset;

	private static bool GetCustomOutputs_IsValid;

	private IntPtr GetCustomOutputs_InstanceFunctionAddress;

	private static IntPtr GetCustomOutputs_FunctionAddress;

	private static int GetCustomOutputs_ParamsSize;

	private static bool GetCustomOutputs_ReturnValue_IsValid;

	private static FFieldAddress GetCustomOutputs_ReturnValue_PropertyAddress;

	private static int GetCustomOutputs_ReturnValue_Offset;

	private static bool GetCustomInputs_IsValid;

	private IntPtr GetCustomInputs_InstanceFunctionAddress;

	private static IntPtr GetCustomInputs_FunctionAddress;

	private static int GetCustomInputs_ParamsSize;

	private static bool GetCustomInputs_ReturnValue_IsValid;

	private static FFieldAddress GetCustomInputs_ReturnValue_PropertyAddress;

	private static int GetCustomInputs_ReturnValue_Offset;

	private static bool FinishInstance_IsValid;

	private static IntPtr FinishInstance_FunctionAddress;

	private static int FinishInstance_ParamsSize;

	private static bool ExportToData_IsValid;

	private IntPtr ExportToData_InstanceFunctionAddress;

	private static IntPtr ExportToData_FunctionAddress;

	private static int ExportToData_ParamsSize;

	private static bool ExportToData_ReturnValue_IsValid;

	private static FFieldAddress ExportToData_ReturnValue_PropertyAddress;

	private static int ExportToData_ReturnValue_Offset;

	private static bool ExecuteSubGraphReconstructionRequested_IsValid;

	private static IntPtr ExecuteSubGraphReconstructionRequested_FunctionAddress;

	private static int ExecuteSubGraphReconstructionRequested_ParamsSize;

	private static bool DeactivateNode_IsValid;

	private static IntPtr DeactivateNode_FunctionAddress;

	private static int DeactivateNode_ParamsSize;

	private static bool DeactivateNode_InGuid_IsValid;

	private static FFieldAddress DeactivateNode_InGuid_PropertyAddress;

	private static int DeactivateNode_InGuid_Offset;

	private static bool CreateInstance_IsValid;

	private static IntPtr CreateInstance_FunctionAddress;

	private static int CreateInstance_ParamsSize;

	private static bool CreateInstance_Owner_IsValid;

	private static FFieldAddress CreateInstance_Owner_PropertyAddress;

	private static int CreateInstance_Owner_Offset;

	private static bool CreateInstance_CalliopeAsset_IsValid;

	private static FFieldAddress CreateInstance_CalliopeAsset_PropertyAddress;

	private static int CreateInstance_CalliopeAsset_Offset;

	private static bool CreateInstance_InstancePrefixName_IsValid;

	private static FFieldAddress CreateInstance_InstancePrefixName_PropertyAddress;

	private static int CreateInstance_InstancePrefixName_Offset;

	private static bool CreateInstance_ReturnValue_IsValid;

	private static FFieldAddress CreateInstance_ReturnValue_PropertyAddress;

	private static int CreateInstance_ReturnValue_Offset;

	private static bool ClearRecordData_IsValid;

	private static IntPtr ClearRecordData_FunctionAddress;

	private static int ClearRecordData_ParamsSize;

	private static bool ClearParameters_IsValid;

	private static IntPtr ClearParameters_FunctionAddress;

	private static int ClearParameters_ParamsSize;

	private static bool ClearInvalidBranchGraph_IsValid;

	private static IntPtr ClearInvalidBranchGraph_FunctionAddress;

	private static int ClearInvalidBranchGraph_ParamsSize;

	private static bool BroadcastRegenerateToolbars_IsValid;

	private static IntPtr BroadcastRegenerateToolbars_FunctionAddress;

	private static int BroadcastRegenerateToolbars_ParamsSize;

	private static bool AssignParameterUnitTamerReference_IsValid;

	private static IntPtr AssignParameterUnitTamerReference_FunctionAddress;

	private static int AssignParameterUnitTamerReference_ParamsSize;

	private static bool AssignParameterUnitTamerReference_InConfigGuid_IsValid;

	private static FFieldAddress AssignParameterUnitTamerReference_InConfigGuid_PropertyAddress;

	private static int AssignParameterUnitTamerReference_InConfigGuid_Offset;

	private static bool AssignParameterUnitTamerReference_ObjectPath_IsValid;

	private static FFieldAddress AssignParameterUnitTamerReference_ObjectPath_PropertyAddress;

	private static int AssignParameterUnitTamerReference_ObjectPath_Offset;

	private static bool AddParameter_IsValid;

	private static IntPtr AddParameter_FunctionAddress;

	private static int AddParameter_ParamsSize;

	private static bool AddParameter_ParamType_IsValid;

	private static FFieldAddress AddParameter_ParamType_PropertyAddress;

	private static int AddParameter_ParamType_Offset;

	private static bool AddParameter_ObjectPath_IsValid;

	private static FFieldAddress AddParameter_ObjectPath_PropertyAddress;

	private static int AddParameter_ObjectPath_Offset;

	private static bool AddParameter_ActorGuid_IsValid;

	private static FFieldAddress AddParameter_ActorGuid_PropertyAddress;

	private static int AddParameter_ActorGuid_Offset;

	private static bool AddParameter_AliasName_IsValid;

	private static FFieldAddress AddParameter_AliasName_PropertyAddress;

	private static int AddParameter_AliasName_Offset;

	private static bool AddParameter_State_IsValid;

	private static FFieldAddress AddParameter_State_PropertyAddress;

	private static int AddParameter_State_Offset;

	private static bool AddParameter_OutConfigGuid_IsValid;

	private static FFieldAddress AddParameter_OutConfigGuid_PropertyAddress;

	private static int AddParameter_OutConfigGuid_Offset;

	private static bool AddParameter_ReturnValue_IsValid;

	private static FFieldAddress AddParameter_ReturnValue_PropertyAddress;

	private static int AddParameter_ReturnValue_Offset;

	private static bool AddBranchGraph_IsValid;

	private static IntPtr AddBranchGraph_FunctionAddress;

	private static int AddBranchGraph_ParamsSize;

	private static bool AddBranchGraph_GraphName_IsValid;

	private static FFieldAddress AddBranchGraph_GraphName_PropertyAddress;

	private static int AddBranchGraph_GraphName_Offset;

	[UProperty(Flags = (PropFlags)4503599627436037uL)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:CustomInputs")]
	protected FGameplayTagContainer CustomInputs
	{
		get
		{
			CheckDestroyed();
			if (!CustomInputs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:CustomInputs");
				return default(FGameplayTagContainer);
			}
			return FGameplayTagContainer.FromNative(IntPtr.Add(base.Address, CustomInputs_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomInputs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:CustomInputs");
			}
			else
			{
				FGameplayTagContainer.ToNative(IntPtr.Add(base.Address, CustomInputs_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627436037uL)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:CustomOutputs")]
	protected FGameplayTagContainer CustomOutputs
	{
		get
		{
			CheckDestroyed();
			if (!CustomOutputs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:CustomOutputs");
				return default(FGameplayTagContainer);
			}
			return FGameplayTagContainer.FromNative(IntPtr.Add(base.Address, CustomOutputs_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomOutputs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:CustomOutputs");
			}
			else
			{
				FGameplayTagContainer.ToNative(IntPtr.Add(base.Address, CustomOutputs_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627501573uL)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:Nodes")]
	public TMapReadWrite<FCalliopeGuid, UCalliopeNode> Nodes
	{
		get
		{
			CheckDestroyed();
			if (!Nodes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:Nodes");
				return null;
			}
			if (Nodes_MarshalerCached == null)
			{
				Nodes_MarshalerCached = new TMapReadWriteMarshaler<FCalliopeGuid, UCalliopeNode>(1, Nodes_PropertyAddress, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.FromNative, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.ToNative, CachedMarshalingDelegates<UCalliopeNode, UObjectMarshaler<UCalliopeNode>>.FromNative, CachedMarshalingDelegates<UCalliopeNode, UObjectMarshaler<UCalliopeNode>>.ToNative);
			}
			return Nodes_MarshalerCached.FromNative(IntPtr.Add(base.Address, Nodes_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:PreloadedNodes")]
	public TSetReadWrite<UCalliopeNode> PreloadedNodes
	{
		get
		{
			CheckDestroyed();
			if (!PreloadedNodes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:PreloadedNodes");
				return null;
			}
			if (PreloadedNodes_MarshalerCached == null)
			{
				PreloadedNodes_MarshalerCached = new TSetReadWriteMarshaler<UCalliopeNode>(1, PreloadedNodes_PropertyAddress, CachedMarshalingDelegates<UCalliopeNode, UObjectMarshaler<UCalliopeNode>>.FromNative, CachedMarshalingDelegates<UCalliopeNode, UObjectMarshaler<UCalliopeNode>>.ToNative);
			}
			return PreloadedNodes_MarshalerCached.FromNative(IntPtr.Add(base.Address, PreloadedNodes_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:ActiveNodes")]
	public TArrayReadWrite<UCalliopeNode> ActiveNodes
	{
		get
		{
			CheckDestroyed();
			if (!ActiveNodes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:ActiveNodes");
				return null;
			}
			if (ActiveNodes_MarshalerCached == null)
			{
				ActiveNodes_MarshalerCached = new TArrayReadWriteMarshaler<UCalliopeNode>(1, ActiveNodes_PropertyAddress, CachedMarshalingDelegates<UCalliopeNode, UObjectMarshaler<UCalliopeNode>>.FromNative, CachedMarshalingDelegates<UCalliopeNode, UObjectMarshaler<UCalliopeNode>>.ToNative);
			}
			return ActiveNodes_MarshalerCached.FromNative(IntPtr.Add(base.Address, ActiveNodes_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:RecordedNodes")]
	public TArrayReadWrite<UCalliopeNode> RecordedNodes
	{
		get
		{
			CheckDestroyed();
			if (!RecordedNodes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:RecordedNodes");
				return null;
			}
			if (RecordedNodes_MarshalerCached == null)
			{
				RecordedNodes_MarshalerCached = new TArrayReadWriteMarshaler<UCalliopeNode>(1, RecordedNodes_PropertyAddress, CachedMarshalingDelegates<UCalliopeNode, UObjectMarshaler<UCalliopeNode>>.FromNative, CachedMarshalingDelegates<UCalliopeNode, UObjectMarshaler<UCalliopeNode>>.ToNative);
			}
			return RecordedNodes_MarshalerCached.FromNative(IntPtr.Add(base.Address, RecordedNodes_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:ExecuteHistory")]
	public TArrayReadWrite<int> ExecuteHistory
	{
		get
		{
			CheckDestroyed();
			if (!ExecuteHistory_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:ExecuteHistory");
				return null;
			}
			if (ExecuteHistory_MarshalerCached == null)
			{
				ExecuteHistory_MarshalerCached = new TArrayReadWriteMarshaler<int>(1, ExecuteHistory_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ExecuteHistory_MarshalerCached.FromNative(IntPtr.Add(base.Address, ExecuteHistory_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:BranchGraphNames")]
	public TSetReadWrite<FName> BranchGraphNames
	{
		get
		{
			CheckDestroyed();
			if (!BranchGraphNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:BranchGraphNames");
				return null;
			}
			if (BranchGraphNames_MarshalerCached == null)
			{
				BranchGraphNames_MarshalerCached = new TSetReadWriteMarshaler<FName>(1, BranchGraphNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return BranchGraphNames_MarshalerCached.FromNative(IntPtr.Add(base.Address, BranchGraphNames_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:NeedPreloadAssets")]
	public TArrayReadWrite<FSoftObjectPath> NeedPreloadAssets
	{
		get
		{
			CheckDestroyed();
			if (!NeedPreloadAssets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:NeedPreloadAssets");
				return null;
			}
			if (NeedPreloadAssets_MarshalerCached == null)
			{
				NeedPreloadAssets_MarshalerCached = new TArrayReadWriteMarshaler<FSoftObjectPath>(1, NeedPreloadAssets_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
			}
			return NeedPreloadAssets_MarshalerCached.FromNative(IntPtr.Add(base.Address, NeedPreloadAssets_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:CalliopeParameters")]
	public FCalliopeParameters CalliopeParameters
	{
		get
		{
			CheckDestroyed();
			if (!CalliopeParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:CalliopeParameters");
				return default(FCalliopeParameters);
			}
			return FCalliopeParameters.FromNative(IntPtr.Add(base.Address, CalliopeParameters_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CalliopeParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:CalliopeParameters");
			}
			else
			{
				FCalliopeParameters.ToNative(IntPtr.Add(base.Address, CalliopeParameters_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441064453uL)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:SearchNodeGuid")]
	public string SearchNodeGuid
	{
		get
		{
			CheckDestroyed();
			if (!SearchNodeGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:SearchNodeGuid");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, SearchNodeGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SearchNodeGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:SearchNodeGuid");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, SearchNodeGuid_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283013uL)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:SearchNodeIndex")]
	public int SearchNodeIndex
	{
		get
		{
			CheckDestroyed();
			if (!SearchNodeIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:SearchNodeIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SearchNodeIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SearchNodeIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeAsset:SearchNodeIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SearchNodeIndex_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:UpdateParameterActorReferenceAndAliasName")]
	public unsafe void UpdateParameterActorReferenceAndAliasName(string ObjectPath, string ActorGuid, FName AliasName)
	{
		CheckDestroyed();
		if (!UpdateParameterActorReferenceAndAliasName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:UpdateParameterActorReferenceAndAliasName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateParameterActorReferenceAndAliasName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateParameterActorReferenceAndAliasName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UpdateParameterActorReferenceAndAliasName_ObjectPath_Offset), 0, UpdateParameterActorReferenceAndAliasName_ObjectPath_PropertyAddress.Address, ObjectPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UpdateParameterActorReferenceAndAliasName_ActorGuid_Offset), 0, UpdateParameterActorReferenceAndAliasName_ActorGuid_PropertyAddress.Address, ActorGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, UpdateParameterActorReferenceAndAliasName_AliasName_Offset), 0, UpdateParameterActorReferenceAndAliasName_AliasName_PropertyAddress.Address, AliasName);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateParameterActorReferenceAndAliasName_FunctionAddress, intPtr, UpdateParameterActorReferenceAndAliasName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UpdateParameterActorReferenceAndAliasName_ObjectPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(UpdateParameterActorReferenceAndAliasName_ActorGuid_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:UnregisterNode")]
	public unsafe void UnregisterNode(FCalliopeGuid NodeGuid)
	{
		CheckDestroyed();
		if (!UnregisterNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:UnregisterNode");
			return;
		}
		if (UnregisterNode_InstanceFunctionAddress == IntPtr.Zero)
		{
			UnregisterNode_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "UnregisterNode");
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(UnregisterNode_NodeGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, UnregisterNode_NodeGuid_Offset), 0, UnregisterNode_NodeGuid_PropertyAddress.Address, NodeGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnregisterNode_InstanceFunctionAddress, intPtr, UnregisterNode_ParamsSize);
	}

	protected unsafe virtual void UnregisterNode_Implementation(FCalliopeGuid NodeGuid)
	{
		CheckDestroyed();
		if (!UnregisterNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:UnregisterNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(UnregisterNode_NodeGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, UnregisterNode_NodeGuid_Offset), 0, UnregisterNode_NodeGuid_PropertyAddress.Address, NodeGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnregisterNode_FunctionAddress, intPtr, UnregisterNode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:StartInstance")]
	public unsafe void StartInstance()
	{
		CheckDestroyed();
		if (!StartInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:StartInstance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartInstance_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StartInstance_FunctionAddress, argsSize: StartInstance_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:StartAsSubInstance")]
	public unsafe void StartAsSubInstance(UCalliopeAsset ParentInstance, FCalliopeGuid InSubNodeGuid)
	{
		CheckDestroyed();
		if (!StartAsSubInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:StartAsSubInstance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartAsSubInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartAsSubInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(intPtr, StartAsSubInstance_ParentInstance_Offset), 0, StartAsSubInstance_ParentInstance_PropertyAddress.Address, ParentInstance);
		NativeReflection.InitializeValue_InContainer(StartAsSubInstance_InSubNodeGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, StartAsSubInstance_InSubNodeGuid_Offset), 0, StartAsSubInstance_InSubNodeGuid_PropertyAddress.Address, InSubNodeGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartAsSubInstance_FunctionAddress, intPtr, StartAsSubInstance_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:SetSubGraphAssetInPIE")]
	public unsafe void SetSubGraphAssetInPIE(FCalliopeGuid InGuid, UCalliopeAsset CalliopeAsset)
	{
		CheckDestroyed();
		if (!SetSubGraphAssetInPIE_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:SetSubGraphAssetInPIE");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSubGraphAssetInPIE_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSubGraphAssetInPIE_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSubGraphAssetInPIE_InGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, SetSubGraphAssetInPIE_InGuid_Offset), 0, SetSubGraphAssetInPIE_InGuid_PropertyAddress.Address, InGuid);
		UObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(intPtr, SetSubGraphAssetInPIE_CalliopeAsset_Offset), 0, SetSubGraphAssetInPIE_CalliopeAsset_PropertyAddress.Address, CalliopeAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSubGraphAssetInPIE_FunctionAddress, intPtr, SetSubGraphAssetInPIE_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:RemoveBranchGraph")]
	public unsafe void RemoveBranchGraph(FName GraphName)
	{
		CheckDestroyed();
		if (!RemoveBranchGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:RemoveBranchGraph");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveBranchGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveBranchGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveBranchGraph_GraphName_Offset), 0, RemoveBranchGraph_GraphName_PropertyAddress.Address, GraphName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveBranchGraph_FunctionAddress, intPtr, RemoveBranchGraph_ParamsSize);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:RegisterNode")]
	public unsafe void RegisterNode(FCalliopeGuid NewGuid, UCalliopeNode NewNode)
	{
		CheckDestroyed();
		if (!RegisterNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:RegisterNode");
			return;
		}
		if (RegisterNode_InstanceFunctionAddress == IntPtr.Zero)
		{
			RegisterNode_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "RegisterNode");
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RegisterNode_NewGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, RegisterNode_NewGuid_Offset), 0, RegisterNode_NewGuid_PropertyAddress.Address, NewGuid);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, RegisterNode_NewNode_Offset), 0, RegisterNode_NewNode_PropertyAddress.Address, NewNode);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterNode_InstanceFunctionAddress, intPtr, RegisterNode_ParamsSize);
	}

	protected unsafe virtual void RegisterNode_Implementation(FCalliopeGuid NewGuid, UCalliopeNode NewNode)
	{
		CheckDestroyed();
		if (!RegisterNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:RegisterNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RegisterNode_NewGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, RegisterNode_NewGuid_Offset), 0, RegisterNode_NewGuid_PropertyAddress.Address, NewGuid);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, RegisterNode_NewNode_Offset), 0, RegisterNode_NewNode_PropertyAddress.Address, NewNode);
		NativeReflection.InvokeFunctionOptimized(base.Address, RegisterNode_FunctionAddress, intPtr, RegisterNode_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:RecordOutput")]
	public unsafe void RecordOutput(FCalliopeGuid InGuid, FName InPinName)
	{
		CheckDestroyed();
		if (!RecordOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:RecordOutput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecordOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecordOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RecordOutput_InGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, RecordOutput_InGuid_Offset), 0, RecordOutput_InGuid_PropertyAddress.Address, InGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RecordOutput_InPinName_Offset), 0, RecordOutput_InPinName_PropertyAddress.Address, InPinName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RecordOutput_FunctionAddress, intPtr, RecordOutput_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:RecordOnlyNode")]
	public unsafe void RecordOnlyNode(FCalliopeGuid InGuid)
	{
		CheckDestroyed();
		if (!RecordOnlyNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:RecordOnlyNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecordOnlyNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecordOnlyNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RecordOnlyNode_InGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, RecordOnlyNode_InGuid_Offset), 0, RecordOnlyNode_InGuid_PropertyAddress.Address, InGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, RecordOnlyNode_FunctionAddress, intPtr, RecordOnlyNode_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:RecordInput")]
	public unsafe void RecordInput(FCalliopeGuid InGuid, FName InPinName)
	{
		CheckDestroyed();
		if (!RecordInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:RecordInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecordInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecordInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RecordInput_InGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, RecordInput_InGuid_Offset), 0, RecordInput_InGuid_PropertyAddress.Address, InGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RecordInput_InPinName_Offset), 0, RecordInput_InPinName_PropertyAddress.Address, InPinName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RecordInput_FunctionAddress, intPtr, RecordInput_ParamsSize);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:PreFinishInstance")]
	public unsafe void PreFinishInstance()
	{
		CheckDestroyed();
		if (!PreFinishInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:PreFinishInstance");
			return;
		}
		if (PreFinishInstance_InstanceFunctionAddress == IntPtr.Zero)
		{
			PreFinishInstance_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PreFinishInstance");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreFinishInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreFinishInstance_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreFinishInstance_InstanceFunctionAddress, argsSize: PreFinishInstance_ParamsSize);
	}

	protected unsafe virtual void PreFinishInstance_Implementation()
	{
		CheckDestroyed();
		if (!PreFinishInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:PreFinishInstance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreFinishInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreFinishInstance_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreFinishInstance_FunctionAddress, argsSize: PreFinishInstance_ParamsSize);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:PostStartInstance")]
	public unsafe void PostStartInstance()
	{
		CheckDestroyed();
		if (!PostStartInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:PostStartInstance");
			return;
		}
		if (PostStartInstance_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostStartInstance_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostStartInstance");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostStartInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostStartInstance_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostStartInstance_InstanceFunctionAddress, argsSize: PostStartInstance_ParamsSize);
	}

	protected unsafe virtual void PostStartInstance_Implementation()
	{
		CheckDestroyed();
		if (!PostStartInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:PostStartInstance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostStartInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostStartInstance_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostStartInstance_FunctionAddress, argsSize: PostStartInstance_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:PostRefreshAssetInCS")]
	public unsafe void PostRefreshAssetInCS()
	{
		CheckDestroyed();
		if (!PostRefreshAssetInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:PostRefreshAssetInCS");
			return;
		}
		if (PostRefreshAssetInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostRefreshAssetInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostRefreshAssetInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostRefreshAssetInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostRefreshAssetInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostRefreshAssetInCS_InstanceFunctionAddress, argsSize: PostRefreshAssetInCS_ParamsSize);
	}

	protected unsafe virtual void PostRefreshAssetInCS_Implementation()
	{
		CheckDestroyed();
		if (!PostRefreshAssetInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:PostRefreshAssetInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostRefreshAssetInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostRefreshAssetInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostRefreshAssetInCS_FunctionAddress, argsSize: PostRefreshAssetInCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:PostDuplicateInCS")]
	public unsafe void PostDuplicateInCS(bool bDuplicateForPIE)
	{
		CheckDestroyed();
		if (!PostDuplicateInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:PostDuplicateInCS");
			return;
		}
		if (PostDuplicateInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostDuplicateInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostDuplicateInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostDuplicateInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostDuplicateInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PostDuplicateInCS_bDuplicateForPIE_Offset), 0, PostDuplicateInCS_bDuplicateForPIE_PropertyAddress.Address, bDuplicateForPIE);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostDuplicateInCS_InstanceFunctionAddress, intPtr, PostDuplicateInCS_ParamsSize);
	}

	protected unsafe virtual void PostDuplicateInCS_Implementation(bool bDuplicateForPIE)
	{
		CheckDestroyed();
		if (!PostDuplicateInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:PostDuplicateInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostDuplicateInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostDuplicateInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PostDuplicateInCS_bDuplicateForPIE_Offset), 0, PostDuplicateInCS_bDuplicateForPIE_PropertyAddress.Address, bDuplicateForPIE);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostDuplicateInCS_FunctionAddress, intPtr, PostDuplicateInCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:OnRefreshAssetInCS")]
	public unsafe void OnRefreshAssetInCS()
	{
		CheckDestroyed();
		if (!OnRefreshAssetInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:OnRefreshAssetInCS");
			return;
		}
		if (OnRefreshAssetInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnRefreshAssetInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnRefreshAssetInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRefreshAssetInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRefreshAssetInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnRefreshAssetInCS_InstanceFunctionAddress, argsSize: OnRefreshAssetInCS_ParamsSize);
	}

	protected unsafe virtual void OnRefreshAssetInCS_Implementation()
	{
		CheckDestroyed();
		if (!OnRefreshAssetInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:OnRefreshAssetInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRefreshAssetInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRefreshAssetInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnRefreshAssetInCS_FunctionAddress, argsSize: OnRefreshAssetInCS_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:OnRefreshAsset")]
	public unsafe void OnRefreshAsset()
	{
		CheckDestroyed();
		if (!OnRefreshAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:OnRefreshAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRefreshAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRefreshAsset_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnRefreshAsset_FunctionAddress, argsSize: OnRefreshAsset_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:OnPropertyChanged")]
	public unsafe void OnPropertyChanged(string MemberName, string PropertyName)
	{
		CheckDestroyed();
		if (!OnPropertyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:OnPropertyChanged");
			return;
		}
		if (OnPropertyChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPropertyChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPropertyChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPropertyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPropertyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_MemberName_Offset), 0, OnPropertyChanged_MemberName_PropertyAddress.Address, MemberName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_PropertyName_Offset), 0, OnPropertyChanged_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPropertyChanged_InstanceFunctionAddress, intPtr, OnPropertyChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_MemberName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_PropertyName_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		CheckDestroyed();
		if (!OnPropertyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:OnPropertyChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPropertyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPropertyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_MemberName_Offset), 0, OnPropertyChanged_MemberName_PropertyAddress.Address, MemberName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_PropertyName_Offset), 0, OnPropertyChanged_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPropertyChanged_FunctionAddress, intPtr, OnPropertyChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_MemberName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_PropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:OnNodeDeactivate")]
	public unsafe void OnNodeDeactivate(UCalliopeNode Node)
	{
		CheckDestroyed();
		if (!OnNodeDeactivate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:OnNodeDeactivate");
			return;
		}
		if (OnNodeDeactivate_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnNodeDeactivate_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnNodeDeactivate");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNodeDeactivate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNodeDeactivate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, OnNodeDeactivate_Node_Offset), 0, OnNodeDeactivate_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNodeDeactivate_InstanceFunctionAddress, intPtr, OnNodeDeactivate_ParamsSize);
	}

	protected unsafe virtual void OnNodeDeactivate_Implementation(UCalliopeNode Node)
	{
		CheckDestroyed();
		if (!OnNodeDeactivate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:OnNodeDeactivate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNodeDeactivate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNodeDeactivate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, OnNodeDeactivate_Node_Offset), 0, OnNodeDeactivate_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNodeDeactivate_FunctionAddress, intPtr, OnNodeDeactivate_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:OnNodeActivate")]
	public unsafe void OnNodeActivate(UCalliopeNode Node)
	{
		CheckDestroyed();
		if (!OnNodeActivate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:OnNodeActivate");
			return;
		}
		if (OnNodeActivate_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnNodeActivate_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnNodeActivate");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNodeActivate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNodeActivate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, OnNodeActivate_Node_Offset), 0, OnNodeActivate_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNodeActivate_InstanceFunctionAddress, intPtr, OnNodeActivate_ParamsSize);
	}

	protected unsafe virtual void OnNodeActivate_Implementation(UCalliopeNode Node)
	{
		CheckDestroyed();
		if (!OnNodeActivate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:OnNodeActivate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNodeActivate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNodeActivate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, OnNodeActivate_Node_Offset), 0, OnNodeActivate_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNodeActivate_FunctionAddress, intPtr, OnNodeActivate_ParamsSize);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:IsEditorOnlyCS")]
	public unsafe bool IsEditorOnlyCS()
	{
		CheckDestroyed();
		if (!IsEditorOnlyCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:IsEditorOnlyCS");
			return false;
		}
		if (IsEditorOnlyCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsEditorOnlyCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsEditorOnlyCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEditorOnlyCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEditorOnlyCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEditorOnlyCS_InstanceFunctionAddress, intPtr, IsEditorOnlyCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEditorOnlyCS_ReturnValue_Offset), 0, IsEditorOnlyCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsEditorOnlyCS_Implementation()
	{
		CheckDestroyed();
		if (!IsEditorOnlyCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:IsEditorOnlyCS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEditorOnlyCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEditorOnlyCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEditorOnlyCS_FunctionAddress, intPtr, IsEditorOnlyCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEditorOnlyCS_ReturnValue_Offset), 0, IsEditorOnlyCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:HarvestNodeConnections")]
	public unsafe void HarvestNodeConnections()
	{
		CheckDestroyed();
		if (!HarvestNodeConnections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:HarvestNodeConnections");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HarvestNodeConnections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HarvestNodeConnections_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HarvestNodeConnections_FunctionAddress, argsSize: HarvestNodeConnections_ParamsSize);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetViewType")]
	public unsafe ECalliopeViewType GetViewType()
	{
		CheckDestroyed();
		if (!GetViewType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetViewType");
			return ECalliopeViewType.None;
		}
		if (GetViewType_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetViewType_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetViewType");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewType_InstanceFunctionAddress, intPtr, GetViewType_ParamsSize);
		return EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(intPtr, GetViewType_ReturnValue_Offset), 0, GetViewType_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual ECalliopeViewType GetViewType_Implementation()
	{
		CheckDestroyed();
		if (!GetViewType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetViewType");
			return ECalliopeViewType.None;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewType_FunctionAddress, intPtr, GetViewType_ParamsSize);
		return EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(intPtr, GetViewType_ReturnValue_Offset), 0, GetViewType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetStartNodeClassInBranchGraph")]
	public unsafe TSubclassOf<UObject> GetStartNodeClassInBranchGraph()
	{
		CheckDestroyed();
		if (!GetStartNodeClassInBranchGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetStartNodeClassInBranchGraph");
			return default(TSubclassOf<UObject>);
		}
		if (GetStartNodeClassInBranchGraph_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetStartNodeClassInBranchGraph_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetStartNodeClassInBranchGraph");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartNodeClassInBranchGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartNodeClassInBranchGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartNodeClassInBranchGraph_InstanceFunctionAddress, intPtr, GetStartNodeClassInBranchGraph_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetStartNodeClassInBranchGraph_ReturnValue_Offset), 0, GetStartNodeClassInBranchGraph_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual TSubclassOf<UObject> GetStartNodeClassInBranchGraph_Implementation()
	{
		CheckDestroyed();
		if (!GetStartNodeClassInBranchGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetStartNodeClassInBranchGraph");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartNodeClassInBranchGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartNodeClassInBranchGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartNodeClassInBranchGraph_FunctionAddress, intPtr, GetStartNodeClassInBranchGraph_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetStartNodeClassInBranchGraph_ReturnValue_Offset), 0, GetStartNodeClassInBranchGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetStartNodeClass")]
	public unsafe TSubclassOf<UObject> GetStartNodeClass()
	{
		CheckDestroyed();
		if (!GetStartNodeClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetStartNodeClass");
			return default(TSubclassOf<UObject>);
		}
		if (GetStartNodeClass_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetStartNodeClass_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetStartNodeClass");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartNodeClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartNodeClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartNodeClass_InstanceFunctionAddress, intPtr, GetStartNodeClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetStartNodeClass_ReturnValue_Offset), 0, GetStartNodeClass_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual TSubclassOf<UObject> GetStartNodeClass_Implementation()
	{
		CheckDestroyed();
		if (!GetStartNodeClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetStartNodeClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartNodeClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartNodeClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartNodeClass_FunctionAddress, intPtr, GetStartNodeClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetStartNodeClass_ReturnValue_Offset), 0, GetStartNodeClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetRerouteNodeClassInBranchGraph")]
	public unsafe TSubclassOf<UObject> GetRerouteNodeClassInBranchGraph()
	{
		CheckDestroyed();
		if (!GetRerouteNodeClassInBranchGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetRerouteNodeClassInBranchGraph");
			return default(TSubclassOf<UObject>);
		}
		if (GetRerouteNodeClassInBranchGraph_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetRerouteNodeClassInBranchGraph_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetRerouteNodeClassInBranchGraph");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRerouteNodeClassInBranchGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRerouteNodeClassInBranchGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRerouteNodeClassInBranchGraph_InstanceFunctionAddress, intPtr, GetRerouteNodeClassInBranchGraph_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetRerouteNodeClassInBranchGraph_ReturnValue_Offset), 0, GetRerouteNodeClassInBranchGraph_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual TSubclassOf<UObject> GetRerouteNodeClassInBranchGraph_Implementation()
	{
		CheckDestroyed();
		if (!GetRerouteNodeClassInBranchGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetRerouteNodeClassInBranchGraph");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRerouteNodeClassInBranchGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRerouteNodeClassInBranchGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRerouteNodeClassInBranchGraph_FunctionAddress, intPtr, GetRerouteNodeClassInBranchGraph_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetRerouteNodeClassInBranchGraph_ReturnValue_Offset), 0, GetRerouteNodeClassInBranchGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetRerouteNodeClass")]
	public unsafe TSubclassOf<UObject> GetRerouteNodeClass()
	{
		CheckDestroyed();
		if (!GetRerouteNodeClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetRerouteNodeClass");
			return default(TSubclassOf<UObject>);
		}
		if (GetRerouteNodeClass_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetRerouteNodeClass_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetRerouteNodeClass");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRerouteNodeClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRerouteNodeClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRerouteNodeClass_InstanceFunctionAddress, intPtr, GetRerouteNodeClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetRerouteNodeClass_ReturnValue_Offset), 0, GetRerouteNodeClass_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual TSubclassOf<UObject> GetRerouteNodeClass_Implementation()
	{
		CheckDestroyed();
		if (!GetRerouteNodeClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetRerouteNodeClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRerouteNodeClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRerouteNodeClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRerouteNodeClass_FunctionAddress, intPtr, GetRerouteNodeClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetRerouteNodeClass_ReturnValue_Offset), 0, GetRerouteNodeClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetPossibleParamsCS")]
	public unsafe bool GetPossibleParamsCS(string ParentPropertyName, string PropertyName, out List<FCalliopeGuid> OutParamArray)
	{
		CheckDestroyed();
		if (!GetPossibleParamsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetPossibleParamsCS");
			OutParamArray = null;
			return false;
		}
		if (GetPossibleParamsCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetPossibleParamsCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetPossibleParamsCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPossibleParamsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPossibleParamsCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetPossibleParamsCS_ParentPropertyName_Offset), 0, GetPossibleParamsCS_ParentPropertyName_PropertyAddress.Address, ParentPropertyName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetPossibleParamsCS_PropertyName_Offset), 0, GetPossibleParamsCS_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPossibleParamsCS_InstanceFunctionAddress, intPtr, GetPossibleParamsCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPossibleParamsCS_ParentPropertyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetPossibleParamsCS_PropertyName_PropertyAddress.Address, intPtr);
		OutParamArray = new TArrayCopyMarshaler<FCalliopeGuid>(1, GetPossibleParamsCS_OutParamArray_PropertyAddress, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.FromNative, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.ToNative).FromNative(IntPtr.Add(intPtr, GetPossibleParamsCS_OutParamArray_Offset));
		NativeReflection.DestroyValue_InContainer(GetPossibleParamsCS_OutParamArray_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetPossibleParamsCS_ReturnValue_Offset), 0, GetPossibleParamsCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool GetPossibleParamsCS_Implementation(string ParentPropertyName, string PropertyName, out List<FCalliopeGuid> OutParamArray)
	{
		CheckDestroyed();
		if (!GetPossibleParamsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetPossibleParamsCS");
			OutParamArray = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPossibleParamsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPossibleParamsCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetPossibleParamsCS_ParentPropertyName_Offset), 0, GetPossibleParamsCS_ParentPropertyName_PropertyAddress.Address, ParentPropertyName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetPossibleParamsCS_PropertyName_Offset), 0, GetPossibleParamsCS_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPossibleParamsCS_FunctionAddress, intPtr, GetPossibleParamsCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPossibleParamsCS_ParentPropertyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetPossibleParamsCS_PropertyName_PropertyAddress.Address, intPtr);
		OutParamArray = new TArrayCopyMarshaler<FCalliopeGuid>(1, GetPossibleParamsCS_OutParamArray_PropertyAddress, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.FromNative, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.ToNative).FromNative(IntPtr.Add(intPtr, GetPossibleParamsCS_OutParamArray_Offset));
		NativeReflection.DestroyValue_InContainer(GetPossibleParamsCS_OutParamArray_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetPossibleParamsCS_ReturnValue_Offset), 0, GetPossibleParamsCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetParameterTaskStateIDByConfigGuid")]
	public unsafe bool GetParameterTaskStateIDByConfigGuid(FCalliopeGuid InConfigGuid, out int OutTaskStageID)
	{
		CheckDestroyed();
		if (!GetParameterTaskStateIDByConfigGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetParameterTaskStateIDByConfigGuid");
			OutTaskStageID = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterTaskStateIDByConfigGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterTaskStateIDByConfigGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParameterTaskStateIDByConfigGuid_InConfigGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, GetParameterTaskStateIDByConfigGuid_InConfigGuid_Offset), 0, GetParameterTaskStateIDByConfigGuid_InConfigGuid_PropertyAddress.Address, InConfigGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterTaskStateIDByConfigGuid_FunctionAddress, intPtr, GetParameterTaskStateIDByConfigGuid_ParamsSize);
		OutTaskStageID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetParameterTaskStateIDByConfigGuid_OutTaskStageID_Offset), 0, GetParameterTaskStateIDByConfigGuid_OutTaskStageID_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetParameterTaskStateIDByConfigGuid_ReturnValue_Offset), 0, GetParameterTaskStateIDByConfigGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetParameterSequenceIDByConfigGuid")]
	public unsafe bool GetParameterSequenceIDByConfigGuid(FCalliopeGuid InConfigGuid, out int OutSequenceID)
	{
		CheckDestroyed();
		if (!GetParameterSequenceIDByConfigGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetParameterSequenceIDByConfigGuid");
			OutSequenceID = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterSequenceIDByConfigGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterSequenceIDByConfigGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParameterSequenceIDByConfigGuid_InConfigGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, GetParameterSequenceIDByConfigGuid_InConfigGuid_Offset), 0, GetParameterSequenceIDByConfigGuid_InConfigGuid_PropertyAddress.Address, InConfigGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterSequenceIDByConfigGuid_FunctionAddress, intPtr, GetParameterSequenceIDByConfigGuid_ParamsSize);
		OutSequenceID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetParameterSequenceIDByConfigGuid_OutSequenceID_Offset), 0, GetParameterSequenceIDByConfigGuid_OutSequenceID_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetParameterSequenceIDByConfigGuid_ReturnValue_Offset), 0, GetParameterSequenceIDByConfigGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetParameterDisplayNameByConfigGuid")]
	public unsafe bool GetParameterDisplayNameByConfigGuid(FCalliopeGuid InConfigGuid, string InPropertyName, out string OutDisplayName)
	{
		CheckDestroyed();
		if (!GetParameterDisplayNameByConfigGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetParameterDisplayNameByConfigGuid");
			OutDisplayName = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterDisplayNameByConfigGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterDisplayNameByConfigGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParameterDisplayNameByConfigGuid_InConfigGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, GetParameterDisplayNameByConfigGuid_InConfigGuid_Offset), 0, GetParameterDisplayNameByConfigGuid_InConfigGuid_PropertyAddress.Address, InConfigGuid);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetParameterDisplayNameByConfigGuid_InPropertyName_Offset), 0, GetParameterDisplayNameByConfigGuid_InPropertyName_PropertyAddress.Address, InPropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterDisplayNameByConfigGuid_FunctionAddress, intPtr, GetParameterDisplayNameByConfigGuid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetParameterDisplayNameByConfigGuid_InPropertyName_PropertyAddress.Address, intPtr);
		OutDisplayName = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetParameterDisplayNameByConfigGuid_OutDisplayName_Offset), 0, GetParameterDisplayNameByConfigGuid_OutDisplayName_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetParameterDisplayNameByConfigGuid_OutDisplayName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetParameterDisplayNameByConfigGuid_ReturnValue_Offset), 0, GetParameterDisplayNameByConfigGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetParameterConfigGuidByActorGuid")]
	public unsafe bool GetParameterConfigGuidByActorGuid(EGsManagedParamType ParamType, string ParamValueString, int ParamValueInt, FName ParamValueName, out FCalliopeGuid OutGuid)
	{
		CheckDestroyed();
		if (!GetParameterConfigGuidByActorGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetParameterConfigGuidByActorGuid");
			OutGuid = default(FCalliopeGuid);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterConfigGuidByActorGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterConfigGuidByActorGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(intPtr, GetParameterConfigGuidByActorGuid_ParamType_Offset), 0, GetParameterConfigGuidByActorGuid_ParamType_PropertyAddress.Address, ParamType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetParameterConfigGuidByActorGuid_ParamValueString_Offset), 0, GetParameterConfigGuidByActorGuid_ParamValueString_PropertyAddress.Address, ParamValueString);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetParameterConfigGuidByActorGuid_ParamValueInt_Offset), 0, GetParameterConfigGuidByActorGuid_ParamValueInt_PropertyAddress.Address, ParamValueInt);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetParameterConfigGuidByActorGuid_ParamValueName_Offset), 0, GetParameterConfigGuidByActorGuid_ParamValueName_PropertyAddress.Address, ParamValueName);
		NativeReflection.InitializeValue_InContainer(GetParameterConfigGuidByActorGuid_OutGuid_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterConfigGuidByActorGuid_FunctionAddress, intPtr, GetParameterConfigGuidByActorGuid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetParameterConfigGuidByActorGuid_ParamValueString_PropertyAddress.Address, intPtr);
		OutGuid = FCalliopeGuid.FromNative(IntPtr.Add(intPtr, GetParameterConfigGuidByActorGuid_OutGuid_Offset), 0, GetParameterConfigGuidByActorGuid_OutGuid_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetParameterConfigGuidByActorGuid_ReturnValue_Offset), 0, GetParameterConfigGuidByActorGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetParameterBuffIDByConfigGuid")]
	public unsafe bool GetParameterBuffIDByConfigGuid(FCalliopeGuid InConfigGuid, out int OutBuffID)
	{
		CheckDestroyed();
		if (!GetParameterBuffIDByConfigGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetParameterBuffIDByConfigGuid");
			OutBuffID = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterBuffIDByConfigGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterBuffIDByConfigGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParameterBuffIDByConfigGuid_InConfigGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, GetParameterBuffIDByConfigGuid_InConfigGuid_Offset), 0, GetParameterBuffIDByConfigGuid_InConfigGuid_PropertyAddress.Address, InConfigGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterBuffIDByConfigGuid_FunctionAddress, intPtr, GetParameterBuffIDByConfigGuid_ParamsSize);
		OutBuffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetParameterBuffIDByConfigGuid_OutBuffID_Offset), 0, GetParameterBuffIDByConfigGuid_OutBuffID_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetParameterBuffIDByConfigGuid_ReturnValue_Offset), 0, GetParameterBuffIDByConfigGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetParameterActorGuidByConfigGuid")]
	public unsafe bool GetParameterActorGuidByConfigGuid(FCalliopeGuid InConfigGuid, out string OutActorGuid)
	{
		CheckDestroyed();
		if (!GetParameterActorGuidByConfigGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetParameterActorGuidByConfigGuid");
			OutActorGuid = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterActorGuidByConfigGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterActorGuidByConfigGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParameterActorGuidByConfigGuid_InConfigGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, GetParameterActorGuidByConfigGuid_InConfigGuid_Offset), 0, GetParameterActorGuidByConfigGuid_InConfigGuid_PropertyAddress.Address, InConfigGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterActorGuidByConfigGuid_FunctionAddress, intPtr, GetParameterActorGuidByConfigGuid_ParamsSize);
		OutActorGuid = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetParameterActorGuidByConfigGuid_OutActorGuid_Offset), 0, GetParameterActorGuidByConfigGuid_OutActorGuid_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetParameterActorGuidByConfigGuid_OutActorGuid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetParameterActorGuidByConfigGuid_ReturnValue_Offset), 0, GetParameterActorGuidByConfigGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetParamDisplayNameCS")]
	public unsafe bool GetParamDisplayNameCS(string PropertyName, FCalliopeGuid InConfigGuid, out string OutDisplayName)
	{
		CheckDestroyed();
		if (!GetParamDisplayNameCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetParamDisplayNameCS");
			OutDisplayName = FStringMarshaler.DefaultString;
			return false;
		}
		if (GetParamDisplayNameCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetParamDisplayNameCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetParamDisplayNameCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParamDisplayNameCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParamDisplayNameCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetParamDisplayNameCS_PropertyName_Offset), 0, GetParamDisplayNameCS_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InitializeValue_InContainer(GetParamDisplayNameCS_InConfigGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, GetParamDisplayNameCS_InConfigGuid_Offset), 0, GetParamDisplayNameCS_InConfigGuid_PropertyAddress.Address, InConfigGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParamDisplayNameCS_InstanceFunctionAddress, intPtr, GetParamDisplayNameCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetParamDisplayNameCS_PropertyName_PropertyAddress.Address, intPtr);
		OutDisplayName = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetParamDisplayNameCS_OutDisplayName_Offset), 0, GetParamDisplayNameCS_OutDisplayName_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetParamDisplayNameCS_OutDisplayName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetParamDisplayNameCS_ReturnValue_Offset), 0, GetParamDisplayNameCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool GetParamDisplayNameCS_Implementation(string PropertyName, FCalliopeGuid InConfigGuid, out string OutDisplayName)
	{
		CheckDestroyed();
		if (!GetParamDisplayNameCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetParamDisplayNameCS");
			OutDisplayName = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParamDisplayNameCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParamDisplayNameCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetParamDisplayNameCS_PropertyName_Offset), 0, GetParamDisplayNameCS_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InitializeValue_InContainer(GetParamDisplayNameCS_InConfigGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, GetParamDisplayNameCS_InConfigGuid_Offset), 0, GetParamDisplayNameCS_InConfigGuid_PropertyAddress.Address, InConfigGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParamDisplayNameCS_FunctionAddress, intPtr, GetParamDisplayNameCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetParamDisplayNameCS_PropertyName_PropertyAddress.Address, intPtr);
		OutDisplayName = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetParamDisplayNameCS_OutDisplayName_Offset), 0, GetParamDisplayNameCS_OutDisplayName_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetParamDisplayNameCS_OutDisplayName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetParamDisplayNameCS_ReturnValue_Offset), 0, GetParamDisplayNameCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetNodes")]
	public unsafe Dictionary<FCalliopeGuid, UCalliopeNode> GetNodes()
	{
		CheckDestroyed();
		if (!GetNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetNodes");
			return null;
		}
		if (GetNodes_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetNodes_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetNodes");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodes_InstanceFunctionAddress, intPtr, GetNodes_ParamsSize);
		Dictionary<FCalliopeGuid, UCalliopeNode> result = new TMapCopyMarshaler<FCalliopeGuid, UCalliopeNode>(1, GetNodes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.FromNative, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.ToNative, CachedMarshalingDelegates<UCalliopeNode, UObjectMarshaler<UCalliopeNode>>.FromNative, CachedMarshalingDelegates<UCalliopeNode, UObjectMarshaler<UCalliopeNode>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNodes_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNodes_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual Dictionary<FCalliopeGuid, UCalliopeNode> GetNodes_Implementation()
	{
		CheckDestroyed();
		if (!GetNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetNodes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodes_FunctionAddress, intPtr, GetNodes_ParamsSize);
		Dictionary<FCalliopeGuid, UCalliopeNode> result = new TMapCopyMarshaler<FCalliopeGuid, UCalliopeNode>(1, GetNodes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.FromNative, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.ToNative, CachedMarshalingDelegates<UCalliopeNode, UObjectMarshaler<UCalliopeNode>>.FromNative, CachedMarshalingDelegates<UCalliopeNode, UObjectMarshaler<UCalliopeNode>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNodes_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNodes_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetNode")]
	public unsafe UCalliopeNode GetNode(FCalliopeGuid InGuid)
	{
		CheckDestroyed();
		if (!GetNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetNode");
			return null;
		}
		if (GetNode_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetNode_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetNode");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNode_InGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, GetNode_InGuid_Offset), 0, GetNode_InGuid_PropertyAddress.Address, InGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNode_InstanceFunctionAddress, intPtr, GetNode_ParamsSize);
		return UObjectMarshaler<UCalliopeNode>.FromNative(IntPtr.Add(intPtr, GetNode_ReturnValue_Offset), 0, GetNode_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual UCalliopeNode GetNode_Implementation(FCalliopeGuid InGuid)
	{
		CheckDestroyed();
		if (!GetNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNode_InGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, GetNode_InGuid_Offset), 0, GetNode_InGuid_PropertyAddress.Address, InGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNode_FunctionAddress, intPtr, GetNode_ParamsSize);
		return UObjectMarshaler<UCalliopeNode>.FromNative(IntPtr.Add(intPtr, GetNode_ReturnValue_Offset), 0, GetNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetExtraDefaultOutputNodesInBranchGraph")]
	public unsafe int GetExtraDefaultOutputNodesInBranchGraph(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetExtraDefaultOutputNodesInBranchGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetExtraDefaultOutputNodesInBranchGraph");
			OutClasses = null;
			return 0;
		}
		if (GetExtraDefaultOutputNodesInBranchGraph_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetExtraDefaultOutputNodesInBranchGraph_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetExtraDefaultOutputNodesInBranchGraph");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExtraDefaultOutputNodesInBranchGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExtraDefaultOutputNodesInBranchGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetExtraDefaultOutputNodesInBranchGraph_InstanceFunctionAddress, intPtr, GetExtraDefaultOutputNodesInBranchGraph_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_Offset), 0, GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GetExtraDefaultOutputNodesInBranchGraph_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetExtraDefaultOutputNodesInBranchGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetExtraDefaultOutputNodesInBranchGraph");
			OutClasses = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExtraDefaultOutputNodesInBranchGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExtraDefaultOutputNodesInBranchGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, intPtr, GetExtraDefaultOutputNodesInBranchGraph_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_Offset), 0, GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetExtraDefaultOutputNodes")]
	public unsafe int GetExtraDefaultOutputNodes(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetExtraDefaultOutputNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetExtraDefaultOutputNodes");
			OutClasses = null;
			return 0;
		}
		if (GetExtraDefaultOutputNodes_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetExtraDefaultOutputNodes_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetExtraDefaultOutputNodes");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExtraDefaultOutputNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExtraDefaultOutputNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetExtraDefaultOutputNodes_InstanceFunctionAddress, intPtr, GetExtraDefaultOutputNodes_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultOutputNodes_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetExtraDefaultOutputNodes_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetExtraDefaultOutputNodes_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetExtraDefaultOutputNodes_ReturnValue_Offset), 0, GetExtraDefaultOutputNodes_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GetExtraDefaultOutputNodes_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetExtraDefaultOutputNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetExtraDefaultOutputNodes");
			OutClasses = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExtraDefaultOutputNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExtraDefaultOutputNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetExtraDefaultOutputNodes_FunctionAddress, intPtr, GetExtraDefaultOutputNodes_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultOutputNodes_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetExtraDefaultOutputNodes_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetExtraDefaultOutputNodes_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetExtraDefaultOutputNodes_ReturnValue_Offset), 0, GetExtraDefaultOutputNodes_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetExtraDefaultInputNodesInBranchGraph")]
	public unsafe int GetExtraDefaultInputNodesInBranchGraph(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetExtraDefaultInputNodesInBranchGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetExtraDefaultInputNodesInBranchGraph");
			OutClasses = null;
			return 0;
		}
		if (GetExtraDefaultInputNodesInBranchGraph_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetExtraDefaultInputNodesInBranchGraph_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetExtraDefaultInputNodesInBranchGraph");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExtraDefaultInputNodesInBranchGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExtraDefaultInputNodesInBranchGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetExtraDefaultInputNodesInBranchGraph_InstanceFunctionAddress, intPtr, GetExtraDefaultInputNodesInBranchGraph_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetExtraDefaultInputNodesInBranchGraph_ReturnValue_Offset), 0, GetExtraDefaultInputNodesInBranchGraph_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GetExtraDefaultInputNodesInBranchGraph_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetExtraDefaultInputNodesInBranchGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetExtraDefaultInputNodesInBranchGraph");
			OutClasses = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExtraDefaultInputNodesInBranchGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExtraDefaultInputNodesInBranchGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, intPtr, GetExtraDefaultInputNodesInBranchGraph_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetExtraDefaultInputNodesInBranchGraph_ReturnValue_Offset), 0, GetExtraDefaultInputNodesInBranchGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetExtraDefaultInputNodes")]
	public unsafe int GetExtraDefaultInputNodes(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetExtraDefaultInputNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetExtraDefaultInputNodes");
			OutClasses = null;
			return 0;
		}
		if (GetExtraDefaultInputNodes_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetExtraDefaultInputNodes_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetExtraDefaultInputNodes");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExtraDefaultInputNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExtraDefaultInputNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetExtraDefaultInputNodes_InstanceFunctionAddress, intPtr, GetExtraDefaultInputNodes_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultInputNodes_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetExtraDefaultInputNodes_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetExtraDefaultInputNodes_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetExtraDefaultInputNodes_ReturnValue_Offset), 0, GetExtraDefaultInputNodes_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GetExtraDefaultInputNodes_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		CheckDestroyed();
		if (!GetExtraDefaultInputNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetExtraDefaultInputNodes");
			OutClasses = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExtraDefaultInputNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExtraDefaultInputNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetExtraDefaultInputNodes_FunctionAddress, intPtr, GetExtraDefaultInputNodes_ParamsSize);
		OutClasses = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultInputNodes_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetExtraDefaultInputNodes_OutClasses_Offset));
		NativeReflection.DestroyValue_InContainer(GetExtraDefaultInputNodes_OutClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetExtraDefaultInputNodes_ReturnValue_Offset), 0, GetExtraDefaultInputNodes_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetCustomOutputs")]
	public unsafe List<FName> GetCustomOutputs()
	{
		CheckDestroyed();
		if (!GetCustomOutputs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetCustomOutputs");
			return null;
		}
		if (GetCustomOutputs_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetCustomOutputs_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetCustomOutputs");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomOutputs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomOutputs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomOutputs_InstanceFunctionAddress, intPtr, GetCustomOutputs_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetCustomOutputs_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCustomOutputs_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCustomOutputs_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual List<FName> GetCustomOutputs_Implementation()
	{
		CheckDestroyed();
		if (!GetCustomOutputs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetCustomOutputs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomOutputs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomOutputs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomOutputs_FunctionAddress, intPtr, GetCustomOutputs_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetCustomOutputs_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCustomOutputs_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCustomOutputs_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:GetCustomInputs")]
	public unsafe List<FName> GetCustomInputs()
	{
		CheckDestroyed();
		if (!GetCustomInputs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetCustomInputs");
			return null;
		}
		if (GetCustomInputs_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetCustomInputs_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetCustomInputs");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomInputs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomInputs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomInputs_InstanceFunctionAddress, intPtr, GetCustomInputs_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetCustomInputs_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCustomInputs_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCustomInputs_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual List<FName> GetCustomInputs_Implementation()
	{
		CheckDestroyed();
		if (!GetCustomInputs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:GetCustomInputs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomInputs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomInputs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomInputs_FunctionAddress, intPtr, GetCustomInputs_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetCustomInputs_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCustomInputs_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCustomInputs_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:FinishInstance")]
	public unsafe void FinishInstance()
	{
		CheckDestroyed();
		if (!FinishInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:FinishInstance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FinishInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FinishInstance_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FinishInstance_FunctionAddress, argsSize: FinishInstance_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:ExportToData")]
	public unsafe bool ExportToData()
	{
		CheckDestroyed();
		if (!ExportToData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:ExportToData");
			return false;
		}
		if (ExportToData_InstanceFunctionAddress == IntPtr.Zero)
		{
			ExportToData_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ExportToData");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportToData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportToData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExportToData_InstanceFunctionAddress, intPtr, ExportToData_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ExportToData_ReturnValue_Offset), 0, ExportToData_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ExportToData_Implementation()
	{
		CheckDestroyed();
		if (!ExportToData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:ExportToData");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportToData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportToData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExportToData_FunctionAddress, intPtr, ExportToData_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ExportToData_ReturnValue_Offset), 0, ExportToData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:ExecuteSubGraphReconstructionRequested")]
	public unsafe void ExecuteSubGraphReconstructionRequested()
	{
		CheckDestroyed();
		if (!ExecuteSubGraphReconstructionRequested_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:ExecuteSubGraphReconstructionRequested");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteSubGraphReconstructionRequested_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteSubGraphReconstructionRequested_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ExecuteSubGraphReconstructionRequested_FunctionAddress, argsSize: ExecuteSubGraphReconstructionRequested_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:DeactivateNode")]
	public unsafe void DeactivateNode(FCalliopeGuid InGuid)
	{
		CheckDestroyed();
		if (!DeactivateNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:DeactivateNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeactivateNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeactivateNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DeactivateNode_InGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, DeactivateNode_InGuid_Offset), 0, DeactivateNode_InGuid_PropertyAddress.Address, InGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeactivateNode_FunctionAddress, intPtr, DeactivateNode_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:CreateInstance")]
	public unsafe static UCalliopeAsset CreateInstance(UObject Owner, UCalliopeAsset CalliopeAsset, string InstancePrefixName)
	{
		if (!CreateInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:CreateInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateInstance_Owner_Offset), 0, CreateInstance_Owner_PropertyAddress.Address, Owner);
		UObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(intPtr, CreateInstance_CalliopeAsset_Offset), 0, CreateInstance_CalliopeAsset_PropertyAddress.Address, CalliopeAsset);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateInstance_InstancePrefixName_Offset), 0, CreateInstance_InstancePrefixName_PropertyAddress.Address, InstancePrefixName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateInstance_FunctionAddress, intPtr, CreateInstance_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateInstance_InstancePrefixName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UCalliopeAsset>.FromNative(IntPtr.Add(intPtr, CreateInstance_ReturnValue_Offset), 0, CreateInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:ClearRecordData")]
	public unsafe void ClearRecordData()
	{
		CheckDestroyed();
		if (!ClearRecordData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:ClearRecordData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearRecordData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearRecordData_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearRecordData_FunctionAddress, argsSize: ClearRecordData_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:ClearParameters")]
	public unsafe void ClearParameters()
	{
		CheckDestroyed();
		if (!ClearParameters_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:ClearParameters");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearParameters_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearParameters_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearParameters_FunctionAddress, argsSize: ClearParameters_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:ClearInvalidBranchGraph")]
	public unsafe void ClearInvalidBranchGraph()
	{
		CheckDestroyed();
		if (!ClearInvalidBranchGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:ClearInvalidBranchGraph");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearInvalidBranchGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearInvalidBranchGraph_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearInvalidBranchGraph_FunctionAddress, argsSize: ClearInvalidBranchGraph_ParamsSize);
	}

	[UFunction(Flags = 1141376001u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:BroadcastRegenerateToolbars")]
	protected unsafe void BroadcastRegenerateToolbars()
	{
		CheckDestroyed();
		if (!BroadcastRegenerateToolbars_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:BroadcastRegenerateToolbars");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BroadcastRegenerateToolbars_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BroadcastRegenerateToolbars_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BroadcastRegenerateToolbars_FunctionAddress, argsSize: BroadcastRegenerateToolbars_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:AssignParameterUnitTamerReference")]
	public unsafe void AssignParameterUnitTamerReference(FCalliopeGuid InConfigGuid, string ObjectPath)
	{
		CheckDestroyed();
		if (!AssignParameterUnitTamerReference_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:AssignParameterUnitTamerReference");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssignParameterUnitTamerReference_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssignParameterUnitTamerReference_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AssignParameterUnitTamerReference_InConfigGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, AssignParameterUnitTamerReference_InConfigGuid_Offset), 0, AssignParameterUnitTamerReference_InConfigGuid_PropertyAddress.Address, InConfigGuid);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssignParameterUnitTamerReference_ObjectPath_Offset), 0, AssignParameterUnitTamerReference_ObjectPath_PropertyAddress.Address, ObjectPath);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssignParameterUnitTamerReference_FunctionAddress, intPtr, AssignParameterUnitTamerReference_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssignParameterUnitTamerReference_ObjectPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:AddParameter")]
	public unsafe bool AddParameter(EGsManagedParamType ParamType, string ObjectPath, string ActorGuid, FName AliasName, int State, out FCalliopeGuid OutConfigGuid)
	{
		CheckDestroyed();
		if (!AddParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:AddParameter");
			OutConfigGuid = default(FCalliopeGuid);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EGsManagedParamType>.ToNative(IntPtr.Add(intPtr, AddParameter_ParamType_Offset), 0, AddParameter_ParamType_PropertyAddress.Address, ParamType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddParameter_ObjectPath_Offset), 0, AddParameter_ObjectPath_PropertyAddress.Address, ObjectPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddParameter_ActorGuid_Offset), 0, AddParameter_ActorGuid_PropertyAddress.Address, ActorGuid);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddParameter_AliasName_Offset), 0, AddParameter_AliasName_PropertyAddress.Address, AliasName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddParameter_State_Offset), 0, AddParameter_State_PropertyAddress.Address, State);
		NativeReflection.InitializeValue_InContainer(AddParameter_OutConfigGuid_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddParameter_FunctionAddress, intPtr, AddParameter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddParameter_ObjectPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddParameter_ActorGuid_PropertyAddress.Address, intPtr);
		OutConfigGuid = FCalliopeGuid.FromNative(IntPtr.Add(intPtr, AddParameter_OutConfigGuid_Offset), 0, AddParameter_OutConfigGuid_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddParameter_ReturnValue_Offset), 0, AddParameter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeAsset:AddBranchGraph")]
	public unsafe void AddBranchGraph(FName GraphName)
	{
		CheckDestroyed();
		if (!AddBranchGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeAsset:AddBranchGraph");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBranchGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBranchGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddBranchGraph_GraphName_Offset), 0, AddBranchGraph_GraphName_PropertyAddress.Address, GraphName);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddBranchGraph_FunctionAddress, intPtr, AddBranchGraph_ParamsSize);
	}

	static UCalliopeAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCalliopeAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCalliopeAsset));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Calliope.CalliopeAsset");
		CustomInputs_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "CustomInputs");
		CustomInputs_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "CustomInputs", Classes.FStructProperty);
		CustomOutputs_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "CustomOutputs");
		CustomOutputs_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "CustomOutputs", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Nodes_PropertyAddress, classAddress, "Nodes");
		Nodes_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "Nodes");
		Nodes_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "Nodes", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref PreloadedNodes_PropertyAddress, classAddress, "PreloadedNodes");
		PreloadedNodes_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "PreloadedNodes");
		PreloadedNodes_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "PreloadedNodes", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref ActiveNodes_PropertyAddress, classAddress, "ActiveNodes");
		ActiveNodes_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "ActiveNodes");
		ActiveNodes_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "ActiveNodes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RecordedNodes_PropertyAddress, classAddress, "RecordedNodes");
		RecordedNodes_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "RecordedNodes");
		RecordedNodes_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "RecordedNodes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteHistory_PropertyAddress, classAddress, "ExecuteHistory");
		ExecuteHistory_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "ExecuteHistory");
		ExecuteHistory_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "ExecuteHistory", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BranchGraphNames_PropertyAddress, classAddress, "BranchGraphNames");
		BranchGraphNames_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "BranchGraphNames");
		BranchGraphNames_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "BranchGraphNames", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref NeedPreloadAssets_PropertyAddress, classAddress, "NeedPreloadAssets");
		NeedPreloadAssets_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "NeedPreloadAssets");
		NeedPreloadAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "NeedPreloadAssets", Classes.FArrayProperty);
		CalliopeParameters_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "CalliopeParameters");
		CalliopeParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "CalliopeParameters", Classes.FStructProperty);
		SearchNodeGuid_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "SearchNodeGuid");
		SearchNodeGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "SearchNodeGuid", Classes.FStrProperty);
		SearchNodeIndex_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "SearchNodeIndex");
		SearchNodeIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "SearchNodeIndex", Classes.FIntProperty);
		UpdateParameterActorReferenceAndAliasName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateParameterActorReferenceAndAliasName");
		UpdateParameterActorReferenceAndAliasName_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateParameterActorReferenceAndAliasName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateParameterActorReferenceAndAliasName_ObjectPath_PropertyAddress, UpdateParameterActorReferenceAndAliasName_FunctionAddress, "ObjectPath");
		UpdateParameterActorReferenceAndAliasName_ObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(UpdateParameterActorReferenceAndAliasName_FunctionAddress, "ObjectPath");
		UpdateParameterActorReferenceAndAliasName_ObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateParameterActorReferenceAndAliasName_FunctionAddress, "ObjectPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateParameterActorReferenceAndAliasName_ActorGuid_PropertyAddress, UpdateParameterActorReferenceAndAliasName_FunctionAddress, "ActorGuid");
		UpdateParameterActorReferenceAndAliasName_ActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(UpdateParameterActorReferenceAndAliasName_FunctionAddress, "ActorGuid");
		UpdateParameterActorReferenceAndAliasName_ActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateParameterActorReferenceAndAliasName_FunctionAddress, "ActorGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateParameterActorReferenceAndAliasName_AliasName_PropertyAddress, UpdateParameterActorReferenceAndAliasName_FunctionAddress, "AliasName");
		UpdateParameterActorReferenceAndAliasName_AliasName_Offset = NativeReflectionCached.GetPropertyOffset(UpdateParameterActorReferenceAndAliasName_FunctionAddress, "AliasName");
		UpdateParameterActorReferenceAndAliasName_AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateParameterActorReferenceAndAliasName_FunctionAddress, "AliasName", Classes.FNameProperty);
		UpdateParameterActorReferenceAndAliasName_IsValid = UpdateParameterActorReferenceAndAliasName_FunctionAddress != IntPtr.Zero && UpdateParameterActorReferenceAndAliasName_ObjectPath_IsValid && UpdateParameterActorReferenceAndAliasName_ActorGuid_IsValid && UpdateParameterActorReferenceAndAliasName_AliasName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:UpdateParameterActorReferenceAndAliasName", UpdateParameterActorReferenceAndAliasName_IsValid);
		UnregisterNode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnregisterNode");
		UnregisterNode_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnregisterNode_NodeGuid_PropertyAddress, UnregisterNode_FunctionAddress, "NodeGuid");
		UnregisterNode_NodeGuid_Offset = NativeReflectionCached.GetPropertyOffset(UnregisterNode_FunctionAddress, "NodeGuid");
		UnregisterNode_NodeGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(UnregisterNode_FunctionAddress, "NodeGuid", Classes.FStructProperty);
		UnregisterNode_IsValid = UnregisterNode_FunctionAddress != IntPtr.Zero && UnregisterNode_NodeGuid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:UnregisterNode", UnregisterNode_IsValid);
		StartInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartInstance");
		StartInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(StartInstance_FunctionAddress);
		StartInstance_IsValid = StartInstance_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:StartInstance", StartInstance_IsValid);
		StartAsSubInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartAsSubInstance");
		StartAsSubInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(StartAsSubInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartAsSubInstance_ParentInstance_PropertyAddress, StartAsSubInstance_FunctionAddress, "ParentInstance");
		StartAsSubInstance_ParentInstance_Offset = NativeReflectionCached.GetPropertyOffset(StartAsSubInstance_FunctionAddress, "ParentInstance");
		StartAsSubInstance_ParentInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAsSubInstance_FunctionAddress, "ParentInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartAsSubInstance_InSubNodeGuid_PropertyAddress, StartAsSubInstance_FunctionAddress, "InSubNodeGuid");
		StartAsSubInstance_InSubNodeGuid_Offset = NativeReflectionCached.GetPropertyOffset(StartAsSubInstance_FunctionAddress, "InSubNodeGuid");
		StartAsSubInstance_InSubNodeGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAsSubInstance_FunctionAddress, "InSubNodeGuid", Classes.FStructProperty);
		StartAsSubInstance_IsValid = StartAsSubInstance_FunctionAddress != IntPtr.Zero && StartAsSubInstance_ParentInstance_IsValid && StartAsSubInstance_InSubNodeGuid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:StartAsSubInstance", StartAsSubInstance_IsValid);
		SetSubGraphAssetInPIE_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSubGraphAssetInPIE");
		SetSubGraphAssetInPIE_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSubGraphAssetInPIE_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSubGraphAssetInPIE_InGuid_PropertyAddress, SetSubGraphAssetInPIE_FunctionAddress, "InGuid");
		SetSubGraphAssetInPIE_InGuid_Offset = NativeReflectionCached.GetPropertyOffset(SetSubGraphAssetInPIE_FunctionAddress, "InGuid");
		SetSubGraphAssetInPIE_InGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubGraphAssetInPIE_FunctionAddress, "InGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSubGraphAssetInPIE_CalliopeAsset_PropertyAddress, SetSubGraphAssetInPIE_FunctionAddress, "CalliopeAsset");
		SetSubGraphAssetInPIE_CalliopeAsset_Offset = NativeReflectionCached.GetPropertyOffset(SetSubGraphAssetInPIE_FunctionAddress, "CalliopeAsset");
		SetSubGraphAssetInPIE_CalliopeAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubGraphAssetInPIE_FunctionAddress, "CalliopeAsset", Classes.FObjectProperty);
		SetSubGraphAssetInPIE_IsValid = SetSubGraphAssetInPIE_FunctionAddress != IntPtr.Zero && SetSubGraphAssetInPIE_InGuid_IsValid && SetSubGraphAssetInPIE_CalliopeAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:SetSubGraphAssetInPIE", SetSubGraphAssetInPIE_IsValid);
		RemoveBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveBranchGraph");
		RemoveBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveBranchGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveBranchGraph_GraphName_PropertyAddress, RemoveBranchGraph_FunctionAddress, "GraphName");
		RemoveBranchGraph_GraphName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBranchGraph_FunctionAddress, "GraphName");
		RemoveBranchGraph_GraphName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBranchGraph_FunctionAddress, "GraphName", Classes.FNameProperty);
		RemoveBranchGraph_IsValid = RemoveBranchGraph_FunctionAddress != IntPtr.Zero && RemoveBranchGraph_GraphName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:RemoveBranchGraph", RemoveBranchGraph_IsValid);
		RegisterNode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterNode");
		RegisterNode_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterNode_NewGuid_PropertyAddress, RegisterNode_FunctionAddress, "NewGuid");
		RegisterNode_NewGuid_Offset = NativeReflectionCached.GetPropertyOffset(RegisterNode_FunctionAddress, "NewGuid");
		RegisterNode_NewGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterNode_FunctionAddress, "NewGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterNode_NewNode_PropertyAddress, RegisterNode_FunctionAddress, "NewNode");
		RegisterNode_NewNode_Offset = NativeReflectionCached.GetPropertyOffset(RegisterNode_FunctionAddress, "NewNode");
		RegisterNode_NewNode_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterNode_FunctionAddress, "NewNode", Classes.FObjectProperty);
		RegisterNode_IsValid = RegisterNode_FunctionAddress != IntPtr.Zero && RegisterNode_NewGuid_IsValid && RegisterNode_NewNode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:RegisterNode", RegisterNode_IsValid);
		RecordOutput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RecordOutput");
		RecordOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(RecordOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RecordOutput_InGuid_PropertyAddress, RecordOutput_FunctionAddress, "InGuid");
		RecordOutput_InGuid_Offset = NativeReflectionCached.GetPropertyOffset(RecordOutput_FunctionAddress, "InGuid");
		RecordOutput_InGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(RecordOutput_FunctionAddress, "InGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RecordOutput_InPinName_PropertyAddress, RecordOutput_FunctionAddress, "InPinName");
		RecordOutput_InPinName_Offset = NativeReflectionCached.GetPropertyOffset(RecordOutput_FunctionAddress, "InPinName");
		RecordOutput_InPinName_IsValid = NativeReflectionCached.ValidatePropertyClass(RecordOutput_FunctionAddress, "InPinName", Classes.FNameProperty);
		RecordOutput_IsValid = RecordOutput_FunctionAddress != IntPtr.Zero && RecordOutput_InGuid_IsValid && RecordOutput_InPinName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:RecordOutput", RecordOutput_IsValid);
		RecordOnlyNode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RecordOnlyNode");
		RecordOnlyNode_ParamsSize = NativeReflection.GetFunctionParamsSize(RecordOnlyNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RecordOnlyNode_InGuid_PropertyAddress, RecordOnlyNode_FunctionAddress, "InGuid");
		RecordOnlyNode_InGuid_Offset = NativeReflectionCached.GetPropertyOffset(RecordOnlyNode_FunctionAddress, "InGuid");
		RecordOnlyNode_InGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(RecordOnlyNode_FunctionAddress, "InGuid", Classes.FStructProperty);
		RecordOnlyNode_IsValid = RecordOnlyNode_FunctionAddress != IntPtr.Zero && RecordOnlyNode_InGuid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:RecordOnlyNode", RecordOnlyNode_IsValid);
		RecordInput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RecordInput");
		RecordInput_ParamsSize = NativeReflection.GetFunctionParamsSize(RecordInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RecordInput_InGuid_PropertyAddress, RecordInput_FunctionAddress, "InGuid");
		RecordInput_InGuid_Offset = NativeReflectionCached.GetPropertyOffset(RecordInput_FunctionAddress, "InGuid");
		RecordInput_InGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(RecordInput_FunctionAddress, "InGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RecordInput_InPinName_PropertyAddress, RecordInput_FunctionAddress, "InPinName");
		RecordInput_InPinName_Offset = NativeReflectionCached.GetPropertyOffset(RecordInput_FunctionAddress, "InPinName");
		RecordInput_InPinName_IsValid = NativeReflectionCached.ValidatePropertyClass(RecordInput_FunctionAddress, "InPinName", Classes.FNameProperty);
		RecordInput_IsValid = RecordInput_FunctionAddress != IntPtr.Zero && RecordInput_InGuid_IsValid && RecordInput_InPinName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:RecordInput", RecordInput_IsValid);
		PreFinishInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PreFinishInstance");
		PreFinishInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(PreFinishInstance_FunctionAddress);
		PreFinishInstance_IsValid = PreFinishInstance_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:PreFinishInstance", PreFinishInstance_IsValid);
		PostStartInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostStartInstance");
		PostStartInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(PostStartInstance_FunctionAddress);
		PostStartInstance_IsValid = PostStartInstance_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:PostStartInstance", PostStartInstance_IsValid);
		PostRefreshAssetInCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostRefreshAssetInCS");
		PostRefreshAssetInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostRefreshAssetInCS_FunctionAddress);
		PostRefreshAssetInCS_IsValid = PostRefreshAssetInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:PostRefreshAssetInCS", PostRefreshAssetInCS_IsValid);
		PostDuplicateInCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostDuplicateInCS");
		PostDuplicateInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostDuplicateInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostDuplicateInCS_bDuplicateForPIE_PropertyAddress, PostDuplicateInCS_FunctionAddress, "bDuplicateForPIE");
		PostDuplicateInCS_bDuplicateForPIE_Offset = NativeReflectionCached.GetPropertyOffset(PostDuplicateInCS_FunctionAddress, "bDuplicateForPIE");
		PostDuplicateInCS_bDuplicateForPIE_IsValid = NativeReflectionCached.ValidatePropertyClass(PostDuplicateInCS_FunctionAddress, "bDuplicateForPIE", Classes.FBoolProperty);
		PostDuplicateInCS_IsValid = PostDuplicateInCS_FunctionAddress != IntPtr.Zero && PostDuplicateInCS_bDuplicateForPIE_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:PostDuplicateInCS", PostDuplicateInCS_IsValid);
		OnRefreshAssetInCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnRefreshAssetInCS");
		OnRefreshAssetInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRefreshAssetInCS_FunctionAddress);
		OnRefreshAssetInCS_IsValid = OnRefreshAssetInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:OnRefreshAssetInCS", OnRefreshAssetInCS_IsValid);
		OnRefreshAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnRefreshAsset");
		OnRefreshAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRefreshAsset_FunctionAddress);
		OnRefreshAsset_IsValid = OnRefreshAsset_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:OnRefreshAsset", OnRefreshAsset_IsValid);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflectionCached.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:OnPropertyChanged", OnPropertyChanged_IsValid);
		OnNodeDeactivate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnNodeDeactivate");
		OnNodeDeactivate_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNodeDeactivate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNodeDeactivate_Node_PropertyAddress, OnNodeDeactivate_FunctionAddress, "Node");
		OnNodeDeactivate_Node_Offset = NativeReflectionCached.GetPropertyOffset(OnNodeDeactivate_FunctionAddress, "Node");
		OnNodeDeactivate_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNodeDeactivate_FunctionAddress, "Node", Classes.FObjectProperty);
		OnNodeDeactivate_IsValid = OnNodeDeactivate_FunctionAddress != IntPtr.Zero && OnNodeDeactivate_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:OnNodeDeactivate", OnNodeDeactivate_IsValid);
		OnNodeActivate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnNodeActivate");
		OnNodeActivate_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNodeActivate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNodeActivate_Node_PropertyAddress, OnNodeActivate_FunctionAddress, "Node");
		OnNodeActivate_Node_Offset = NativeReflectionCached.GetPropertyOffset(OnNodeActivate_FunctionAddress, "Node");
		OnNodeActivate_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNodeActivate_FunctionAddress, "Node", Classes.FObjectProperty);
		OnNodeActivate_IsValid = OnNodeActivate_FunctionAddress != IntPtr.Zero && OnNodeActivate_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:OnNodeActivate", OnNodeActivate_IsValid);
		IsEditorOnlyCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsEditorOnlyCS");
		IsEditorOnlyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEditorOnlyCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEditorOnlyCS_ReturnValue_PropertyAddress, IsEditorOnlyCS_FunctionAddress, "ReturnValue");
		IsEditorOnlyCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEditorOnlyCS_FunctionAddress, "ReturnValue");
		IsEditorOnlyCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEditorOnlyCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEditorOnlyCS_IsValid = IsEditorOnlyCS_FunctionAddress != IntPtr.Zero && IsEditorOnlyCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:IsEditorOnlyCS", IsEditorOnlyCS_IsValid);
		HarvestNodeConnections_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HarvestNodeConnections");
		HarvestNodeConnections_ParamsSize = NativeReflection.GetFunctionParamsSize(HarvestNodeConnections_FunctionAddress);
		HarvestNodeConnections_IsValid = HarvestNodeConnections_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:HarvestNodeConnections", HarvestNodeConnections_IsValid);
		GetViewType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetViewType");
		GetViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewType_ReturnValue_PropertyAddress, GetViewType_FunctionAddress, "ReturnValue");
		GetViewType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewType_FunctionAddress, "ReturnValue");
		GetViewType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetViewType_IsValid = GetViewType_FunctionAddress != IntPtr.Zero && GetViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetViewType", GetViewType_IsValid);
		GetStartNodeClassInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStartNodeClassInBranchGraph");
		GetStartNodeClassInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartNodeClassInBranchGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartNodeClassInBranchGraph_ReturnValue_PropertyAddress, GetStartNodeClassInBranchGraph_FunctionAddress, "ReturnValue");
		GetStartNodeClassInBranchGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartNodeClassInBranchGraph_FunctionAddress, "ReturnValue");
		GetStartNodeClassInBranchGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartNodeClassInBranchGraph_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetStartNodeClassInBranchGraph_IsValid = GetStartNodeClassInBranchGraph_FunctionAddress != IntPtr.Zero && GetStartNodeClassInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetStartNodeClassInBranchGraph", GetStartNodeClassInBranchGraph_IsValid);
		GetStartNodeClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStartNodeClass");
		GetStartNodeClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartNodeClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartNodeClass_ReturnValue_PropertyAddress, GetStartNodeClass_FunctionAddress, "ReturnValue");
		GetStartNodeClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartNodeClass_FunctionAddress, "ReturnValue");
		GetStartNodeClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartNodeClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetStartNodeClass_IsValid = GetStartNodeClass_FunctionAddress != IntPtr.Zero && GetStartNodeClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetStartNodeClass", GetStartNodeClass_IsValid);
		GetRerouteNodeClassInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRerouteNodeClassInBranchGraph");
		GetRerouteNodeClassInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRerouteNodeClassInBranchGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRerouteNodeClassInBranchGraph_ReturnValue_PropertyAddress, GetRerouteNodeClassInBranchGraph_FunctionAddress, "ReturnValue");
		GetRerouteNodeClassInBranchGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRerouteNodeClassInBranchGraph_FunctionAddress, "ReturnValue");
		GetRerouteNodeClassInBranchGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRerouteNodeClassInBranchGraph_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetRerouteNodeClassInBranchGraph_IsValid = GetRerouteNodeClassInBranchGraph_FunctionAddress != IntPtr.Zero && GetRerouteNodeClassInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetRerouteNodeClassInBranchGraph", GetRerouteNodeClassInBranchGraph_IsValid);
		GetRerouteNodeClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRerouteNodeClass");
		GetRerouteNodeClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRerouteNodeClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRerouteNodeClass_ReturnValue_PropertyAddress, GetRerouteNodeClass_FunctionAddress, "ReturnValue");
		GetRerouteNodeClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRerouteNodeClass_FunctionAddress, "ReturnValue");
		GetRerouteNodeClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRerouteNodeClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetRerouteNodeClass_IsValid = GetRerouteNodeClass_FunctionAddress != IntPtr.Zero && GetRerouteNodeClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetRerouteNodeClass", GetRerouteNodeClass_IsValid);
		GetPossibleParamsCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPossibleParamsCS");
		GetPossibleParamsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPossibleParamsCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPossibleParamsCS_ParentPropertyName_PropertyAddress, GetPossibleParamsCS_FunctionAddress, "ParentPropertyName");
		GetPossibleParamsCS_ParentPropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetPossibleParamsCS_FunctionAddress, "ParentPropertyName");
		GetPossibleParamsCS_ParentPropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPossibleParamsCS_FunctionAddress, "ParentPropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPossibleParamsCS_PropertyName_PropertyAddress, GetPossibleParamsCS_FunctionAddress, "PropertyName");
		GetPossibleParamsCS_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetPossibleParamsCS_FunctionAddress, "PropertyName");
		GetPossibleParamsCS_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPossibleParamsCS_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPossibleParamsCS_OutParamArray_PropertyAddress, GetPossibleParamsCS_FunctionAddress, "OutParamArray");
		GetPossibleParamsCS_OutParamArray_Offset = NativeReflectionCached.GetPropertyOffset(GetPossibleParamsCS_FunctionAddress, "OutParamArray");
		GetPossibleParamsCS_OutParamArray_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPossibleParamsCS_FunctionAddress, "OutParamArray", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPossibleParamsCS_ReturnValue_PropertyAddress, GetPossibleParamsCS_FunctionAddress, "ReturnValue");
		GetPossibleParamsCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPossibleParamsCS_FunctionAddress, "ReturnValue");
		GetPossibleParamsCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPossibleParamsCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetPossibleParamsCS_IsValid = GetPossibleParamsCS_FunctionAddress != IntPtr.Zero && GetPossibleParamsCS_ParentPropertyName_IsValid && GetPossibleParamsCS_PropertyName_IsValid && GetPossibleParamsCS_OutParamArray_IsValid && GetPossibleParamsCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetPossibleParamsCS", GetPossibleParamsCS_IsValid);
		GetParameterTaskStateIDByConfigGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParameterTaskStateIDByConfigGuid");
		GetParameterTaskStateIDByConfigGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterTaskStateIDByConfigGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterTaskStateIDByConfigGuid_InConfigGuid_PropertyAddress, GetParameterTaskStateIDByConfigGuid_FunctionAddress, "InConfigGuid");
		GetParameterTaskStateIDByConfigGuid_InConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterTaskStateIDByConfigGuid_FunctionAddress, "InConfigGuid");
		GetParameterTaskStateIDByConfigGuid_InConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterTaskStateIDByConfigGuid_FunctionAddress, "InConfigGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterTaskStateIDByConfigGuid_OutTaskStageID_PropertyAddress, GetParameterTaskStateIDByConfigGuid_FunctionAddress, "OutTaskStageID");
		GetParameterTaskStateIDByConfigGuid_OutTaskStageID_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterTaskStateIDByConfigGuid_FunctionAddress, "OutTaskStageID");
		GetParameterTaskStateIDByConfigGuid_OutTaskStageID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterTaskStateIDByConfigGuid_FunctionAddress, "OutTaskStageID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterTaskStateIDByConfigGuid_ReturnValue_PropertyAddress, GetParameterTaskStateIDByConfigGuid_FunctionAddress, "ReturnValue");
		GetParameterTaskStateIDByConfigGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterTaskStateIDByConfigGuid_FunctionAddress, "ReturnValue");
		GetParameterTaskStateIDByConfigGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterTaskStateIDByConfigGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetParameterTaskStateIDByConfigGuid_IsValid = GetParameterTaskStateIDByConfigGuid_FunctionAddress != IntPtr.Zero && GetParameterTaskStateIDByConfigGuid_InConfigGuid_IsValid && GetParameterTaskStateIDByConfigGuid_OutTaskStageID_IsValid && GetParameterTaskStateIDByConfigGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetParameterTaskStateIDByConfigGuid", GetParameterTaskStateIDByConfigGuid_IsValid);
		GetParameterSequenceIDByConfigGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParameterSequenceIDByConfigGuid");
		GetParameterSequenceIDByConfigGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterSequenceIDByConfigGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterSequenceIDByConfigGuid_InConfigGuid_PropertyAddress, GetParameterSequenceIDByConfigGuid_FunctionAddress, "InConfigGuid");
		GetParameterSequenceIDByConfigGuid_InConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterSequenceIDByConfigGuid_FunctionAddress, "InConfigGuid");
		GetParameterSequenceIDByConfigGuid_InConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterSequenceIDByConfigGuid_FunctionAddress, "InConfigGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterSequenceIDByConfigGuid_OutSequenceID_PropertyAddress, GetParameterSequenceIDByConfigGuid_FunctionAddress, "OutSequenceID");
		GetParameterSequenceIDByConfigGuid_OutSequenceID_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterSequenceIDByConfigGuid_FunctionAddress, "OutSequenceID");
		GetParameterSequenceIDByConfigGuid_OutSequenceID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterSequenceIDByConfigGuid_FunctionAddress, "OutSequenceID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterSequenceIDByConfigGuid_ReturnValue_PropertyAddress, GetParameterSequenceIDByConfigGuid_FunctionAddress, "ReturnValue");
		GetParameterSequenceIDByConfigGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterSequenceIDByConfigGuid_FunctionAddress, "ReturnValue");
		GetParameterSequenceIDByConfigGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterSequenceIDByConfigGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetParameterSequenceIDByConfigGuid_IsValid = GetParameterSequenceIDByConfigGuid_FunctionAddress != IntPtr.Zero && GetParameterSequenceIDByConfigGuid_InConfigGuid_IsValid && GetParameterSequenceIDByConfigGuid_OutSequenceID_IsValid && GetParameterSequenceIDByConfigGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetParameterSequenceIDByConfigGuid", GetParameterSequenceIDByConfigGuid_IsValid);
		GetParameterDisplayNameByConfigGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParameterDisplayNameByConfigGuid");
		GetParameterDisplayNameByConfigGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterDisplayNameByConfigGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterDisplayNameByConfigGuid_InConfigGuid_PropertyAddress, GetParameterDisplayNameByConfigGuid_FunctionAddress, "InConfigGuid");
		GetParameterDisplayNameByConfigGuid_InConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterDisplayNameByConfigGuid_FunctionAddress, "InConfigGuid");
		GetParameterDisplayNameByConfigGuid_InConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterDisplayNameByConfigGuid_FunctionAddress, "InConfigGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterDisplayNameByConfigGuid_InPropertyName_PropertyAddress, GetParameterDisplayNameByConfigGuid_FunctionAddress, "InPropertyName");
		GetParameterDisplayNameByConfigGuid_InPropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterDisplayNameByConfigGuid_FunctionAddress, "InPropertyName");
		GetParameterDisplayNameByConfigGuid_InPropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterDisplayNameByConfigGuid_FunctionAddress, "InPropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterDisplayNameByConfigGuid_OutDisplayName_PropertyAddress, GetParameterDisplayNameByConfigGuid_FunctionAddress, "OutDisplayName");
		GetParameterDisplayNameByConfigGuid_OutDisplayName_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterDisplayNameByConfigGuid_FunctionAddress, "OutDisplayName");
		GetParameterDisplayNameByConfigGuid_OutDisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterDisplayNameByConfigGuid_FunctionAddress, "OutDisplayName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterDisplayNameByConfigGuid_ReturnValue_PropertyAddress, GetParameterDisplayNameByConfigGuid_FunctionAddress, "ReturnValue");
		GetParameterDisplayNameByConfigGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterDisplayNameByConfigGuid_FunctionAddress, "ReturnValue");
		GetParameterDisplayNameByConfigGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterDisplayNameByConfigGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetParameterDisplayNameByConfigGuid_IsValid = GetParameterDisplayNameByConfigGuid_FunctionAddress != IntPtr.Zero && GetParameterDisplayNameByConfigGuid_InConfigGuid_IsValid && GetParameterDisplayNameByConfigGuid_InPropertyName_IsValid && GetParameterDisplayNameByConfigGuid_OutDisplayName_IsValid && GetParameterDisplayNameByConfigGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetParameterDisplayNameByConfigGuid", GetParameterDisplayNameByConfigGuid_IsValid);
		GetParameterConfigGuidByActorGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParameterConfigGuidByActorGuid");
		GetParameterConfigGuidByActorGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterConfigGuidByActorGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterConfigGuidByActorGuid_ParamType_PropertyAddress, GetParameterConfigGuidByActorGuid_FunctionAddress, "ParamType");
		GetParameterConfigGuidByActorGuid_ParamType_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterConfigGuidByActorGuid_FunctionAddress, "ParamType");
		GetParameterConfigGuidByActorGuid_ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterConfigGuidByActorGuid_FunctionAddress, "ParamType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterConfigGuidByActorGuid_ParamValueString_PropertyAddress, GetParameterConfigGuidByActorGuid_FunctionAddress, "ParamValueString");
		GetParameterConfigGuidByActorGuid_ParamValueString_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterConfigGuidByActorGuid_FunctionAddress, "ParamValueString");
		GetParameterConfigGuidByActorGuid_ParamValueString_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterConfigGuidByActorGuid_FunctionAddress, "ParamValueString", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterConfigGuidByActorGuid_ParamValueInt_PropertyAddress, GetParameterConfigGuidByActorGuid_FunctionAddress, "ParamValueInt");
		GetParameterConfigGuidByActorGuid_ParamValueInt_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterConfigGuidByActorGuid_FunctionAddress, "ParamValueInt");
		GetParameterConfigGuidByActorGuid_ParamValueInt_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterConfigGuidByActorGuid_FunctionAddress, "ParamValueInt", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterConfigGuidByActorGuid_ParamValueName_PropertyAddress, GetParameterConfigGuidByActorGuid_FunctionAddress, "ParamValueName");
		GetParameterConfigGuidByActorGuid_ParamValueName_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterConfigGuidByActorGuid_FunctionAddress, "ParamValueName");
		GetParameterConfigGuidByActorGuid_ParamValueName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterConfigGuidByActorGuid_FunctionAddress, "ParamValueName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterConfigGuidByActorGuid_OutGuid_PropertyAddress, GetParameterConfigGuidByActorGuid_FunctionAddress, "OutGuid");
		GetParameterConfigGuidByActorGuid_OutGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterConfigGuidByActorGuid_FunctionAddress, "OutGuid");
		GetParameterConfigGuidByActorGuid_OutGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterConfigGuidByActorGuid_FunctionAddress, "OutGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterConfigGuidByActorGuid_ReturnValue_PropertyAddress, GetParameterConfigGuidByActorGuid_FunctionAddress, "ReturnValue");
		GetParameterConfigGuidByActorGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterConfigGuidByActorGuid_FunctionAddress, "ReturnValue");
		GetParameterConfigGuidByActorGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterConfigGuidByActorGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetParameterConfigGuidByActorGuid_IsValid = GetParameterConfigGuidByActorGuid_FunctionAddress != IntPtr.Zero && GetParameterConfigGuidByActorGuid_ParamType_IsValid && GetParameterConfigGuidByActorGuid_ParamValueString_IsValid && GetParameterConfigGuidByActorGuid_ParamValueInt_IsValid && GetParameterConfigGuidByActorGuid_ParamValueName_IsValid && GetParameterConfigGuidByActorGuid_OutGuid_IsValid && GetParameterConfigGuidByActorGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetParameterConfigGuidByActorGuid", GetParameterConfigGuidByActorGuid_IsValid);
		GetParameterBuffIDByConfigGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParameterBuffIDByConfigGuid");
		GetParameterBuffIDByConfigGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterBuffIDByConfigGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterBuffIDByConfigGuid_InConfigGuid_PropertyAddress, GetParameterBuffIDByConfigGuid_FunctionAddress, "InConfigGuid");
		GetParameterBuffIDByConfigGuid_InConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterBuffIDByConfigGuid_FunctionAddress, "InConfigGuid");
		GetParameterBuffIDByConfigGuid_InConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterBuffIDByConfigGuid_FunctionAddress, "InConfigGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterBuffIDByConfigGuid_OutBuffID_PropertyAddress, GetParameterBuffIDByConfigGuid_FunctionAddress, "OutBuffID");
		GetParameterBuffIDByConfigGuid_OutBuffID_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterBuffIDByConfigGuid_FunctionAddress, "OutBuffID");
		GetParameterBuffIDByConfigGuid_OutBuffID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterBuffIDByConfigGuid_FunctionAddress, "OutBuffID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterBuffIDByConfigGuid_ReturnValue_PropertyAddress, GetParameterBuffIDByConfigGuid_FunctionAddress, "ReturnValue");
		GetParameterBuffIDByConfigGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterBuffIDByConfigGuid_FunctionAddress, "ReturnValue");
		GetParameterBuffIDByConfigGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterBuffIDByConfigGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetParameterBuffIDByConfigGuid_IsValid = GetParameterBuffIDByConfigGuid_FunctionAddress != IntPtr.Zero && GetParameterBuffIDByConfigGuid_InConfigGuid_IsValid && GetParameterBuffIDByConfigGuid_OutBuffID_IsValid && GetParameterBuffIDByConfigGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetParameterBuffIDByConfigGuid", GetParameterBuffIDByConfigGuid_IsValid);
		GetParameterActorGuidByConfigGuid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParameterActorGuidByConfigGuid");
		GetParameterActorGuidByConfigGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterActorGuidByConfigGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterActorGuidByConfigGuid_InConfigGuid_PropertyAddress, GetParameterActorGuidByConfigGuid_FunctionAddress, "InConfigGuid");
		GetParameterActorGuidByConfigGuid_InConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterActorGuidByConfigGuid_FunctionAddress, "InConfigGuid");
		GetParameterActorGuidByConfigGuid_InConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterActorGuidByConfigGuid_FunctionAddress, "InConfigGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterActorGuidByConfigGuid_OutActorGuid_PropertyAddress, GetParameterActorGuidByConfigGuid_FunctionAddress, "OutActorGuid");
		GetParameterActorGuidByConfigGuid_OutActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterActorGuidByConfigGuid_FunctionAddress, "OutActorGuid");
		GetParameterActorGuidByConfigGuid_OutActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterActorGuidByConfigGuid_FunctionAddress, "OutActorGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParameterActorGuidByConfigGuid_ReturnValue_PropertyAddress, GetParameterActorGuidByConfigGuid_FunctionAddress, "ReturnValue");
		GetParameterActorGuidByConfigGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterActorGuidByConfigGuid_FunctionAddress, "ReturnValue");
		GetParameterActorGuidByConfigGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterActorGuidByConfigGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetParameterActorGuidByConfigGuid_IsValid = GetParameterActorGuidByConfigGuid_FunctionAddress != IntPtr.Zero && GetParameterActorGuidByConfigGuid_InConfigGuid_IsValid && GetParameterActorGuidByConfigGuid_OutActorGuid_IsValid && GetParameterActorGuidByConfigGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetParameterActorGuidByConfigGuid", GetParameterActorGuidByConfigGuid_IsValid);
		GetParamDisplayNameCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParamDisplayNameCS");
		GetParamDisplayNameCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParamDisplayNameCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParamDisplayNameCS_PropertyName_PropertyAddress, GetParamDisplayNameCS_FunctionAddress, "PropertyName");
		GetParamDisplayNameCS_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(GetParamDisplayNameCS_FunctionAddress, "PropertyName");
		GetParamDisplayNameCS_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParamDisplayNameCS_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParamDisplayNameCS_InConfigGuid_PropertyAddress, GetParamDisplayNameCS_FunctionAddress, "InConfigGuid");
		GetParamDisplayNameCS_InConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetParamDisplayNameCS_FunctionAddress, "InConfigGuid");
		GetParamDisplayNameCS_InConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParamDisplayNameCS_FunctionAddress, "InConfigGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParamDisplayNameCS_OutDisplayName_PropertyAddress, GetParamDisplayNameCS_FunctionAddress, "OutDisplayName");
		GetParamDisplayNameCS_OutDisplayName_Offset = NativeReflectionCached.GetPropertyOffset(GetParamDisplayNameCS_FunctionAddress, "OutDisplayName");
		GetParamDisplayNameCS_OutDisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParamDisplayNameCS_FunctionAddress, "OutDisplayName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParamDisplayNameCS_ReturnValue_PropertyAddress, GetParamDisplayNameCS_FunctionAddress, "ReturnValue");
		GetParamDisplayNameCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParamDisplayNameCS_FunctionAddress, "ReturnValue");
		GetParamDisplayNameCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParamDisplayNameCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetParamDisplayNameCS_IsValid = GetParamDisplayNameCS_FunctionAddress != IntPtr.Zero && GetParamDisplayNameCS_PropertyName_IsValid && GetParamDisplayNameCS_InConfigGuid_IsValid && GetParamDisplayNameCS_OutDisplayName_IsValid && GetParamDisplayNameCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetParamDisplayNameCS", GetParamDisplayNameCS_IsValid);
		GetNodes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNodes");
		GetNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodes_ReturnValue_PropertyAddress, GetNodes_FunctionAddress, "ReturnValue");
		GetNodes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodes_FunctionAddress, "ReturnValue");
		GetNodes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodes_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetNodes_IsValid = GetNodes_FunctionAddress != IntPtr.Zero && GetNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetNodes", GetNodes_IsValid);
		GetNode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNode");
		GetNode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNode_InGuid_PropertyAddress, GetNode_FunctionAddress, "InGuid");
		GetNode_InGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetNode_FunctionAddress, "InGuid");
		GetNode_InGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNode_FunctionAddress, "InGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNode_ReturnValue_PropertyAddress, GetNode_FunctionAddress, "ReturnValue");
		GetNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNode_FunctionAddress, "ReturnValue");
		GetNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetNode_IsValid = GetNode_FunctionAddress != IntPtr.Zero && GetNode_InGuid_IsValid && GetNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetNode", GetNode_IsValid);
		GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetExtraDefaultOutputNodesInBranchGraph");
		GetExtraDefaultOutputNodesInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress, GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodesInBranchGraph_OutClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_PropertyAddress, GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "ReturnValue");
		GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "ReturnValue");
		GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultOutputNodesInBranchGraph_IsValid = GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress != IntPtr.Zero && GetExtraDefaultOutputNodesInBranchGraph_OutClasses_IsValid && GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetExtraDefaultOutputNodesInBranchGraph", GetExtraDefaultOutputNodesInBranchGraph_IsValid);
		GetExtraDefaultOutputNodes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetExtraDefaultOutputNodes");
		GetExtraDefaultOutputNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultOutputNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetExtraDefaultOutputNodes_OutClasses_PropertyAddress, GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodes_OutClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodes_OutClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetExtraDefaultOutputNodes_ReturnValue_PropertyAddress, GetExtraDefaultOutputNodes_FunctionAddress, "ReturnValue");
		GetExtraDefaultOutputNodes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetExtraDefaultOutputNodes_FunctionAddress, "ReturnValue");
		GetExtraDefaultOutputNodes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtraDefaultOutputNodes_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultOutputNodes_IsValid = GetExtraDefaultOutputNodes_FunctionAddress != IntPtr.Zero && GetExtraDefaultOutputNodes_OutClasses_IsValid && GetExtraDefaultOutputNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetExtraDefaultOutputNodes", GetExtraDefaultOutputNodes_IsValid);
		GetExtraDefaultInputNodesInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetExtraDefaultInputNodesInBranchGraph");
		GetExtraDefaultInputNodesInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress, GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodesInBranchGraph_OutClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetExtraDefaultInputNodesInBranchGraph_ReturnValue_PropertyAddress, GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "ReturnValue");
		GetExtraDefaultInputNodesInBranchGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "ReturnValue");
		GetExtraDefaultInputNodesInBranchGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultInputNodesInBranchGraph_IsValid = GetExtraDefaultInputNodesInBranchGraph_FunctionAddress != IntPtr.Zero && GetExtraDefaultInputNodesInBranchGraph_OutClasses_IsValid && GetExtraDefaultInputNodesInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetExtraDefaultInputNodesInBranchGraph", GetExtraDefaultInputNodesInBranchGraph_IsValid);
		GetExtraDefaultInputNodes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetExtraDefaultInputNodes");
		GetExtraDefaultInputNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultInputNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetExtraDefaultInputNodes_OutClasses_PropertyAddress, GetExtraDefaultInputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodes_OutClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetExtraDefaultInputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodes_OutClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtraDefaultInputNodes_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetExtraDefaultInputNodes_ReturnValue_PropertyAddress, GetExtraDefaultInputNodes_FunctionAddress, "ReturnValue");
		GetExtraDefaultInputNodes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetExtraDefaultInputNodes_FunctionAddress, "ReturnValue");
		GetExtraDefaultInputNodes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtraDefaultInputNodes_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultInputNodes_IsValid = GetExtraDefaultInputNodes_FunctionAddress != IntPtr.Zero && GetExtraDefaultInputNodes_OutClasses_IsValid && GetExtraDefaultInputNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetExtraDefaultInputNodes", GetExtraDefaultInputNodes_IsValid);
		GetCustomOutputs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCustomOutputs");
		GetCustomOutputs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomOutputs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomOutputs_ReturnValue_PropertyAddress, GetCustomOutputs_FunctionAddress, "ReturnValue");
		GetCustomOutputs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomOutputs_FunctionAddress, "ReturnValue");
		GetCustomOutputs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomOutputs_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCustomOutputs_IsValid = GetCustomOutputs_FunctionAddress != IntPtr.Zero && GetCustomOutputs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetCustomOutputs", GetCustomOutputs_IsValid);
		GetCustomInputs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCustomInputs");
		GetCustomInputs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomInputs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomInputs_ReturnValue_PropertyAddress, GetCustomInputs_FunctionAddress, "ReturnValue");
		GetCustomInputs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomInputs_FunctionAddress, "ReturnValue");
		GetCustomInputs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomInputs_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCustomInputs_IsValid = GetCustomInputs_FunctionAddress != IntPtr.Zero && GetCustomInputs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:GetCustomInputs", GetCustomInputs_IsValid);
		FinishInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FinishInstance");
		FinishInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(FinishInstance_FunctionAddress);
		FinishInstance_IsValid = FinishInstance_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:FinishInstance", FinishInstance_IsValid);
		ExportToData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportToData");
		ExportToData_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportToData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportToData_ReturnValue_PropertyAddress, ExportToData_FunctionAddress, "ReturnValue");
		ExportToData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExportToData_FunctionAddress, "ReturnValue");
		ExportToData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportToData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExportToData_IsValid = ExportToData_FunctionAddress != IntPtr.Zero && ExportToData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:ExportToData", ExportToData_IsValid);
		ExecuteSubGraphReconstructionRequested_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExecuteSubGraphReconstructionRequested");
		ExecuteSubGraphReconstructionRequested_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecuteSubGraphReconstructionRequested_FunctionAddress);
		ExecuteSubGraphReconstructionRequested_IsValid = ExecuteSubGraphReconstructionRequested_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:ExecuteSubGraphReconstructionRequested", ExecuteSubGraphReconstructionRequested_IsValid);
		DeactivateNode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeactivateNode");
		DeactivateNode_ParamsSize = NativeReflection.GetFunctionParamsSize(DeactivateNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeactivateNode_InGuid_PropertyAddress, DeactivateNode_FunctionAddress, "InGuid");
		DeactivateNode_InGuid_Offset = NativeReflectionCached.GetPropertyOffset(DeactivateNode_FunctionAddress, "InGuid");
		DeactivateNode_InGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(DeactivateNode_FunctionAddress, "InGuid", Classes.FStructProperty);
		DeactivateNode_IsValid = DeactivateNode_FunctionAddress != IntPtr.Zero && DeactivateNode_InGuid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:DeactivateNode", DeactivateNode_IsValid);
		CreateInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateInstance");
		CreateInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateInstance_Owner_PropertyAddress, CreateInstance_FunctionAddress, "Owner");
		CreateInstance_Owner_Offset = NativeReflectionCached.GetPropertyOffset(CreateInstance_FunctionAddress, "Owner");
		CreateInstance_Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInstance_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateInstance_CalliopeAsset_PropertyAddress, CreateInstance_FunctionAddress, "CalliopeAsset");
		CreateInstance_CalliopeAsset_Offset = NativeReflectionCached.GetPropertyOffset(CreateInstance_FunctionAddress, "CalliopeAsset");
		CreateInstance_CalliopeAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInstance_FunctionAddress, "CalliopeAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateInstance_InstancePrefixName_PropertyAddress, CreateInstance_FunctionAddress, "InstancePrefixName");
		CreateInstance_InstancePrefixName_Offset = NativeReflectionCached.GetPropertyOffset(CreateInstance_FunctionAddress, "InstancePrefixName");
		CreateInstance_InstancePrefixName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInstance_FunctionAddress, "InstancePrefixName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateInstance_ReturnValue_PropertyAddress, CreateInstance_FunctionAddress, "ReturnValue");
		CreateInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateInstance_FunctionAddress, "ReturnValue");
		CreateInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateInstance_IsValid = CreateInstance_FunctionAddress != IntPtr.Zero && CreateInstance_Owner_IsValid && CreateInstance_CalliopeAsset_IsValid && CreateInstance_InstancePrefixName_IsValid && CreateInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:CreateInstance", CreateInstance_IsValid);
		ClearRecordData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearRecordData");
		ClearRecordData_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearRecordData_FunctionAddress);
		ClearRecordData_IsValid = ClearRecordData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:ClearRecordData", ClearRecordData_IsValid);
		ClearParameters_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearParameters");
		ClearParameters_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearParameters_FunctionAddress);
		ClearParameters_IsValid = ClearParameters_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:ClearParameters", ClearParameters_IsValid);
		ClearInvalidBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearInvalidBranchGraph");
		ClearInvalidBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearInvalidBranchGraph_FunctionAddress);
		ClearInvalidBranchGraph_IsValid = ClearInvalidBranchGraph_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:ClearInvalidBranchGraph", ClearInvalidBranchGraph_IsValid);
		BroadcastRegenerateToolbars_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BroadcastRegenerateToolbars");
		BroadcastRegenerateToolbars_ParamsSize = NativeReflection.GetFunctionParamsSize(BroadcastRegenerateToolbars_FunctionAddress);
		BroadcastRegenerateToolbars_IsValid = BroadcastRegenerateToolbars_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:BroadcastRegenerateToolbars", BroadcastRegenerateToolbars_IsValid);
		AssignParameterUnitTamerReference_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AssignParameterUnitTamerReference");
		AssignParameterUnitTamerReference_ParamsSize = NativeReflection.GetFunctionParamsSize(AssignParameterUnitTamerReference_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssignParameterUnitTamerReference_InConfigGuid_PropertyAddress, AssignParameterUnitTamerReference_FunctionAddress, "InConfigGuid");
		AssignParameterUnitTamerReference_InConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(AssignParameterUnitTamerReference_FunctionAddress, "InConfigGuid");
		AssignParameterUnitTamerReference_InConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(AssignParameterUnitTamerReference_FunctionAddress, "InConfigGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AssignParameterUnitTamerReference_ObjectPath_PropertyAddress, AssignParameterUnitTamerReference_FunctionAddress, "ObjectPath");
		AssignParameterUnitTamerReference_ObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(AssignParameterUnitTamerReference_FunctionAddress, "ObjectPath");
		AssignParameterUnitTamerReference_ObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AssignParameterUnitTamerReference_FunctionAddress, "ObjectPath", Classes.FStrProperty);
		AssignParameterUnitTamerReference_IsValid = AssignParameterUnitTamerReference_FunctionAddress != IntPtr.Zero && AssignParameterUnitTamerReference_InConfigGuid_IsValid && AssignParameterUnitTamerReference_ObjectPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:AssignParameterUnitTamerReference", AssignParameterUnitTamerReference_IsValid);
		AddParameter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddParameter");
		AddParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(AddParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddParameter_ParamType_PropertyAddress, AddParameter_FunctionAddress, "ParamType");
		AddParameter_ParamType_Offset = NativeReflectionCached.GetPropertyOffset(AddParameter_FunctionAddress, "ParamType");
		AddParameter_ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameter_FunctionAddress, "ParamType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameter_ObjectPath_PropertyAddress, AddParameter_FunctionAddress, "ObjectPath");
		AddParameter_ObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(AddParameter_FunctionAddress, "ObjectPath");
		AddParameter_ObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameter_FunctionAddress, "ObjectPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameter_ActorGuid_PropertyAddress, AddParameter_FunctionAddress, "ActorGuid");
		AddParameter_ActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(AddParameter_FunctionAddress, "ActorGuid");
		AddParameter_ActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameter_FunctionAddress, "ActorGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameter_AliasName_PropertyAddress, AddParameter_FunctionAddress, "AliasName");
		AddParameter_AliasName_Offset = NativeReflectionCached.GetPropertyOffset(AddParameter_FunctionAddress, "AliasName");
		AddParameter_AliasName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameter_FunctionAddress, "AliasName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameter_State_PropertyAddress, AddParameter_FunctionAddress, "State");
		AddParameter_State_Offset = NativeReflectionCached.GetPropertyOffset(AddParameter_FunctionAddress, "State");
		AddParameter_State_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameter_FunctionAddress, "State", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameter_OutConfigGuid_PropertyAddress, AddParameter_FunctionAddress, "OutConfigGuid");
		AddParameter_OutConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(AddParameter_FunctionAddress, "OutConfigGuid");
		AddParameter_OutConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameter_FunctionAddress, "OutConfigGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParameter_ReturnValue_PropertyAddress, AddParameter_FunctionAddress, "ReturnValue");
		AddParameter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddParameter_FunctionAddress, "ReturnValue");
		AddParameter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParameter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddParameter_IsValid = AddParameter_FunctionAddress != IntPtr.Zero && AddParameter_ParamType_IsValid && AddParameter_ObjectPath_IsValid && AddParameter_ActorGuid_IsValid && AddParameter_AliasName_IsValid && AddParameter_State_IsValid && AddParameter_OutConfigGuid_IsValid && AddParameter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:AddParameter", AddParameter_IsValid);
		AddBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddBranchGraph");
		AddBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBranchGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBranchGraph_GraphName_PropertyAddress, AddBranchGraph_FunctionAddress, "GraphName");
		AddBranchGraph_GraphName_Offset = NativeReflectionCached.GetPropertyOffset(AddBranchGraph_FunctionAddress, "GraphName");
		AddBranchGraph_GraphName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBranchGraph_FunctionAddress, "GraphName", Classes.FNameProperty);
		AddBranchGraph_IsValid = AddBranchGraph_FunctionAddress != IntPtr.Zero && AddBranchGraph_GraphName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeAsset:AddBranchGraph", AddBranchGraph_IsValid);
	}
}
