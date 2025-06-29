using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Calliope.CalliopeNode", "Calliope", UnrealModuleType.GamePlugin)]
public class UCalliopeNode : UObject, IGsSmartParamObject, IInterface
{
	private static bool SupportsContextPins_IsValid;

	private static FFieldAddress SupportsContextPins_PropertyAddress;

	private static int SupportsContextPins_Offset;

	private static bool Category_IsValid;

	private static int Category_Offset;

	private static bool NodeStyle_IsValid;

	private static FFieldAddress NodeStyle_PropertyAddress;

	private static int NodeStyle_Offset;

	private static bool InputPins_IsValid;

	private static FFieldAddress InputPins_PropertyAddress;

	private static int InputPins_Offset;

	private TArrayReadWriteMarshaler<FCalliopePin> InputPins_MarshalerCached;

	private static bool OutputPins_IsValid;

	private static FFieldAddress OutputPins_PropertyAddress;

	private static int OutputPins_Offset;

	private TArrayReadWriteMarshaler<FCalliopePin> OutputPins_MarshalerCached;

	private static bool Connections_IsValid;

	private static FFieldAddress Connections_PropertyAddress;

	private static int Connections_Offset;

	private TMapReadWriteMarshaler<FName, FCalliopeConnectedPin> Connections_MarshalerCached;

	private static bool NodeGuid_IsValid;

	private static int NodeGuid_Offset;

	private static bool NodeHasError_IsValid;

	private static FFieldAddress NodeHasError_PropertyAddress;

	private static int NodeHasError_Offset;

	private static bool BossPhaseRequireActive_IsValid;

	private static FFieldAddress BossPhaseRequireActive_PropertyAddress;

	private static int BossPhaseRequireActive_Offset;

	private static bool NodeIndex_IsValid;

	private static int NodeIndex_Offset;

	private static bool ParentNode_IsValid;

	private static int ParentNode_Offset;

	private static bool SceneObjPoliceConfig_IsValid;

	private static int SceneObjPoliceConfig_Offset;

	private static bool UnBindAssetOnSubGraphReconstructionRequested_IsValid;

	private static IntPtr UnBindAssetOnSubGraphReconstructionRequested_FunctionAddress;

	private static int UnBindAssetOnSubGraphReconstructionRequested_ParamsSize;

	private static bool UnBindAssetOnSubGraphReconstructionRequested_Asset_IsValid;

	private static FFieldAddress UnBindAssetOnSubGraphReconstructionRequested_Asset_PropertyAddress;

	private static int UnBindAssetOnSubGraphReconstructionRequested_Asset_Offset;

	private static bool SyncSceneObjPoliceConfig_IsValid;

	private static IntPtr SyncSceneObjPoliceConfig_FunctionAddress;

	private static int SyncSceneObjPoliceConfig_ParamsSize;

	private static bool SetSubGraphAssetInPIE_IsValid;

	private IntPtr SetSubGraphAssetInPIE_InstanceFunctionAddress;

	private static IntPtr SetSubGraphAssetInPIE_FunctionAddress;

	private static int SetSubGraphAssetInPIE_ParamsSize;

	private static bool SetSubGraphAssetInPIE_InSubGraphAsset_IsValid;

	private static FFieldAddress SetSubGraphAssetInPIE_InSubGraphAsset_PropertyAddress;

	private static int SetSubGraphAssetInPIE_InSubGraphAsset_Offset;

	private static bool SetOutputPins_IsValid;

	private static IntPtr SetOutputPins_FunctionAddress;

	private static int SetOutputPins_ParamsSize;

	private static bool SetOutputPins_InOutputPins_IsValid;

	private static FFieldAddress SetOutputPins_InOutputPins_PropertyAddress;

	private static int SetOutputPins_InOutputPins_Offset;

	private static bool SetInputPins_IsValid;

	private static IntPtr SetInputPins_FunctionAddress;

	private static int SetInputPins_ParamsSize;

	private static bool SetInputPins_InInputPins_IsValid;

	private static FFieldAddress SetInputPins_InInputPins_PropertyAddress;

	private static int SetInputPins_InInputPins_Offset;

	private static bool SetConnections_IsValid;

	private static IntPtr SetConnections_FunctionAddress;

	private static int SetConnections_ParamsSize;

	private static bool SetConnections_InConnections_IsValid;

	private static FFieldAddress SetConnections_InConnections_PropertyAddress;

	private static int SetConnections_InConnections_Offset;

	private static bool ResetRecordsInCS_IsValid;

	private static IntPtr ResetRecordsInCS_FunctionAddress;

	private static int ResetRecordsInCS_ParamsSize;

	private static bool RefreshSceneObjPoliceConfig_IsValid;

	private static IntPtr RefreshSceneObjPoliceConfig_FunctionAddress;

	private static int RefreshSceneObjPoliceConfig_ParamsSize;

	private static bool RefreshSceneObjPoliceConfig_PreviousNode_IsValid;

	private static FFieldAddress RefreshSceneObjPoliceConfig_PreviousNode_PropertyAddress;

	private static int RefreshSceneObjPoliceConfig_PreviousNode_Offset;

	private static bool RefreshParentNode_IsValid;

	private static IntPtr RefreshParentNode_FunctionAddress;

	private static int RefreshParentNode_ParamsSize;

	private static bool RecordOutput_IsValid;

	private static IntPtr RecordOutput_FunctionAddress;

	private static int RecordOutput_ParamsSize;

	private static bool RecordOutput_PinName_IsValid;

	private static FFieldAddress RecordOutput_PinName_PropertyAddress;

	private static int RecordOutput_PinName_Offset;

	private static bool RecordInput_IsValid;

	private static IntPtr RecordInput_FunctionAddress;

	private static int RecordInput_ParamsSize;

	private static bool RecordInput_PinName_IsValid;

	private static FFieldAddress RecordInput_PinName_PropertyAddress;

	private static int RecordInput_PinName_Offset;

	private static bool PrePropertyChanged_IsValid;

	private IntPtr PrePropertyChanged_InstanceFunctionAddress;

	private static IntPtr PrePropertyChanged_FunctionAddress;

	private static int PrePropertyChanged_ParamsSize;

	private static bool PrePropertyChanged_PropertyName_IsValid;

	private static FFieldAddress PrePropertyChanged_PropertyName_PropertyAddress;

	private static int PrePropertyChanged_PropertyName_Offset;

	private static bool PostPropertyChanged_IsValid;

	private IntPtr PostPropertyChanged_InstanceFunctionAddress;

	private static IntPtr PostPropertyChanged_FunctionAddress;

	private static int PostPropertyChanged_ParamsSize;

	private static bool PostPropertyChanged_MemberName_IsValid;

	private static FFieldAddress PostPropertyChanged_MemberName_PropertyAddress;

	private static int PostPropertyChanged_MemberName_Offset;

	private static bool PostPropertyChanged_PropertyName_IsValid;

	private static FFieldAddress PostPropertyChanged_PropertyName_PropertyAddress;

	private static int PostPropertyChanged_PropertyName_Offset;

	private static bool PostLoadInCS_IsValid;

	private IntPtr PostLoadInCS_InstanceFunctionAddress;

	private static IntPtr PostLoadInCS_FunctionAddress;

	private static int PostLoadInCS_ParamsSize;

	private static bool OnSelectNodeInCS_IsValid;

	private IntPtr OnSelectNodeInCS_InstanceFunctionAddress;

	private static IntPtr OnSelectNodeInCS_FunctionAddress;

	private static int OnSelectNodeInCS_ParamsSize;

	private static bool OnRefreshAssetInCS_IsValid;

	private IntPtr OnRefreshAssetInCS_InstanceFunctionAddress;

	private static IntPtr OnRefreshAssetInCS_FunctionAddress;

	private static int OnRefreshAssetInCS_ParamsSize;

	private static bool OnCreateGraphNodeInCS_IsValid;

	private IntPtr OnCreateGraphNodeInCS_InstanceFunctionAddress;

	private static IntPtr OnCreateGraphNodeInCS_FunctionAddress;

	private static int OnCreateGraphNodeInCS_ParamsSize;

	private static bool LogError_IsValid;

	private static IntPtr LogError_FunctionAddress;

	private static int LogError_ParamsSize;

	private static bool LogError_Message_IsValid;

	private static FFieldAddress LogError_Message_PropertyAddress;

	private static int LogError_Message_Offset;

	private static bool LoadAssetInCS_IsValid;

	private static IntPtr LoadAssetInCS_FunctionAddress;

	private static int LoadAssetInCS_ParamsSize;

	private static bool LoadAssetInCS_AssetPtr_IsValid;

	private static FFieldAddress LoadAssetInCS_AssetPtr_PropertyAddress;

	private static int LoadAssetInCS_AssetPtr_Offset;

	private static bool LoadAssetInCS_ReturnValue_IsValid;

	private static FFieldAddress LoadAssetInCS_ReturnValue_PropertyAddress;

	private static int LoadAssetInCS_ReturnValue_Offset;

	private static bool JumpToMe_IsValid;

	private static IntPtr JumpToMe_FunctionAddress;

	private static int JumpToMe_ParamsSize;

	private static bool IsSupportViewType_IsValid;

	private IntPtr IsSupportViewType_InstanceFunctionAddress;

	private static IntPtr IsSupportViewType_FunctionAddress;

	private static int IsSupportViewType_ParamsSize;

	private static bool IsSupportViewType_InViewType_IsValid;

	private static FFieldAddress IsSupportViewType_InViewType_PropertyAddress;

	private static int IsSupportViewType_InViewType_Offset;

	private static bool IsSupportViewType_ReturnValue_IsValid;

	private static FFieldAddress IsSupportViewType_ReturnValue_PropertyAddress;

	private static int IsSupportViewType_ReturnValue_Offset;

	private static bool IsSubGraphNode_IsValid;

	private IntPtr IsSubGraphNode_InstanceFunctionAddress;

	private static IntPtr IsSubGraphNode_FunctionAddress;

	private static int IsSubGraphNode_ParamsSize;

	private static bool IsSubGraphNode_ReturnValue_IsValid;

	private static FFieldAddress IsSubGraphNode_ReturnValue_PropertyAddress;

	private static int IsSubGraphNode_ReturnValue_Offset;

	private static bool IsPreloaded_IsValid;

	private IntPtr IsPreloaded_InstanceFunctionAddress;

	private static IntPtr IsPreloaded_FunctionAddress;

	private static int IsPreloaded_ParamsSize;

	private static bool IsPreloaded_ReturnValue_IsValid;

	private static FFieldAddress IsPreloaded_ReturnValue_PropertyAddress;

	private static int IsPreloaded_ReturnValue_Offset;

	private static bool IsPlayInEditor_IsValid;

	private IntPtr IsPlayInEditor_InstanceFunctionAddress;

	private static IntPtr IsPlayInEditor_FunctionAddress;

	private static int IsPlayInEditor_ParamsSize;

	private static bool IsPlayInEditor_ReturnValue_IsValid;

	private static FFieldAddress IsPlayInEditor_ReturnValue_PropertyAddress;

	private static int IsPlayInEditor_ReturnValue_Offset;

	private static bool IsOutputConnectTo_IsValid;

	private static IntPtr IsOutputConnectTo_FunctionAddress;

	private static int IsOutputConnectTo_ParamsSize;

	private static bool IsOutputConnectTo_TargetNodeGuid_IsValid;

	private static FFieldAddress IsOutputConnectTo_TargetNodeGuid_PropertyAddress;

	private static int IsOutputConnectTo_TargetNodeGuid_Offset;

	private static bool IsOutputConnectTo_ReturnValue_IsValid;

	private static FFieldAddress IsOutputConnectTo_ReturnValue_PropertyAddress;

	private static int IsOutputConnectTo_ReturnValue_Offset;

	private static bool IsCalliopeWasActive_IsValid;

	private static IntPtr IsCalliopeWasActive_FunctionAddress;

	private static int IsCalliopeWasActive_ParamsSize;

	private static bool IsCalliopeWasActive_ReturnValue_IsValid;

	private static FFieldAddress IsCalliopeWasActive_ReturnValue_PropertyAddress;

	private static int IsCalliopeWasActive_ReturnValue_Offset;

	private static bool IsCalliopeNeverActivated_IsValid;

	private static IntPtr IsCalliopeNeverActivated_FunctionAddress;

	private static int IsCalliopeNeverActivated_ParamsSize;

	private static bool IsCalliopeNeverActivated_ReturnValue_IsValid;

	private static FFieldAddress IsCalliopeNeverActivated_ReturnValue_PropertyAddress;

	private static int IsCalliopeNeverActivated_ReturnValue_Offset;

	private static bool IsCalliopeActive_IsValid;

	private static IntPtr IsCalliopeActive_FunctionAddress;

	private static int IsCalliopeActive_ParamsSize;

	private static bool IsCalliopeActive_ReturnValue_IsValid;

	private static FFieldAddress IsCalliopeActive_ReturnValue_PropertyAddress;

	private static int IsCalliopeActive_ReturnValue_Offset;

	private static bool IsBranchGraphNode_IsValid;

	private IntPtr IsBranchGraphNode_InstanceFunctionAddress;

	private static IntPtr IsBranchGraphNode_FunctionAddress;

	private static int IsBranchGraphNode_ParamsSize;

	private static bool IsBranchGraphNode_ReturnValue_IsValid;

	private static FFieldAddress IsBranchGraphNode_ReturnValue_PropertyAddress;

	private static int IsBranchGraphNode_ReturnValue_Offset;

	private static bool IsBattleStateNode_IsValid;

	private IntPtr IsBattleStateNode_InstanceFunctionAddress;

	private static IntPtr IsBattleStateNode_FunctionAddress;

	private static int IsBattleStateNode_ParamsSize;

	private static bool IsBattleStateNode_ReturnValue_IsValid;

	private static FFieldAddress IsBattleStateNode_ReturnValue_PropertyAddress;

	private static int IsBattleStateNode_ReturnValue_Offset;

	private static bool GetStatusStringInCS_IsValid;

	private IntPtr GetStatusStringInCS_InstanceFunctionAddress;

	private static IntPtr GetStatusStringInCS_FunctionAddress;

	private static int GetStatusStringInCS_ParamsSize;

	private static bool GetStatusStringInCS_ReturnValue_IsValid;

	private static FFieldAddress GetStatusStringInCS_ReturnValue_PropertyAddress;

	private static int GetStatusStringInCS_ReturnValue_Offset;

	private static bool GetParentNodes_IsValid;

	private static IntPtr GetParentNodes_FunctionAddress;

	private static int GetParentNodes_ParamsSize;

	private static bool GetParentNodes_ReturnValue_IsValid;

	private static FFieldAddress GetParentNodes_ReturnValue_PropertyAddress;

	private static int GetParentNodes_ReturnValue_Offset;

	private static bool GetOutputPins_IsValid;

	private static IntPtr GetOutputPins_FunctionAddress;

	private static int GetOutputPins_ParamsSize;

	private static bool GetOutputPins_ReturnValue_IsValid;

	private static FFieldAddress GetOutputPins_ReturnValue_PropertyAddress;

	private static int GetOutputPins_ReturnValue_Offset;

	private static bool GetOutputNames_IsValid;

	private static IntPtr GetOutputNames_FunctionAddress;

	private static int GetOutputNames_ParamsSize;

	private static bool GetOutputNames_ReturnValue_IsValid;

	private static FFieldAddress GetOutputNames_ReturnValue_PropertyAddress;

	private static int GetOutputNames_ReturnValue_Offset;

	private static bool GetNodeDescriptionInCS_IsValid;

	private IntPtr GetNodeDescriptionInCS_InstanceFunctionAddress;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static bool GetInputPins_IsValid;

	private static IntPtr GetInputPins_FunctionAddress;

	private static int GetInputPins_ParamsSize;

	private static bool GetInputPins_ReturnValue_IsValid;

	private static FFieldAddress GetInputPins_ReturnValue_PropertyAddress;

	private static int GetInputPins_ReturnValue_Offset;

	private static bool GetInputNames_IsValid;

	private static IntPtr GetInputNames_FunctionAddress;

	private static int GetInputNames_ParamsSize;

	private static bool GetInputNames_ReturnValue_IsValid;

	private static FFieldAddress GetInputNames_ReturnValue_PropertyAddress;

	private static int GetInputNames_ReturnValue_Offset;

	private static bool GetGuid_IsValid;

	private IntPtr GetGuid_InstanceFunctionAddress;

	private static IntPtr GetGuid_FunctionAddress;

	private static int GetGuid_ParamsSize;

	private static bool GetGuid_ReturnValue_IsValid;

	private static FFieldAddress GetGuid_ReturnValue_PropertyAddress;

	private static int GetGuid_ReturnValue_Offset;

	private static bool GetGraphNodeInCS_IsValid;

	private static IntPtr GetGraphNodeInCS_FunctionAddress;

	private static int GetGraphNodeInCS_ParamsSize;

	private static bool GetGraphNodeInCS_ReturnValue_IsValid;

	private static FFieldAddress GetGraphNodeInCS_ReturnValue_PropertyAddress;

	private static int GetGraphNodeInCS_ReturnValue_Offset;

	private static bool GetGraphIdentifierInCS_IsValid;

	private static IntPtr GetGraphIdentifierInCS_FunctionAddress;

	private static int GetGraphIdentifierInCS_ParamsSize;

	private static bool GetGraphIdentifierInCS_OutGraphIdentifier_IsValid;

	private static FFieldAddress GetGraphIdentifierInCS_OutGraphIdentifier_PropertyAddress;

	private static int GetGraphIdentifierInCS_OutGraphIdentifier_Offset;

	private static bool GetGraphIdentifierInCS_ReturnValue_IsValid;

	private static FFieldAddress GetGraphIdentifierInCS_ReturnValue_PropertyAddress;

	private static int GetGraphIdentifierInCS_ReturnValue_Offset;

	private static bool GetGraphGuidInCS_IsValid;

	private static IntPtr GetGraphGuidInCS_FunctionAddress;

	private static int GetGraphGuidInCS_ParamsSize;

	private static bool GetGraphGuidInCS_OutGraphGuid_IsValid;

	private static FFieldAddress GetGraphGuidInCS_OutGraphGuid_PropertyAddress;

	private static int GetGraphGuidInCS_OutGraphGuid_Offset;

	private static bool GetGraphGuidInCS_ReturnValue_IsValid;

	private static FFieldAddress GetGraphGuidInCS_ReturnValue_PropertyAddress;

	private static int GetGraphGuidInCS_ReturnValue_Offset;

	private static bool GetDefaultOutputPin_IsValid;

	private static IntPtr GetDefaultOutputPin_FunctionAddress;

	private static int GetDefaultOutputPin_ParamsSize;

	private static bool GetDefaultOutputPin_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultOutputPin_ReturnValue_PropertyAddress;

	private static int GetDefaultOutputPin_ReturnValue_Offset;

	private static bool GetDefaultInputPin_IsValid;

	private static IntPtr GetDefaultInputPin_FunctionAddress;

	private static int GetDefaultInputPin_ParamsSize;

	private static bool GetDefaultInputPin_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultInputPin_ReturnValue_PropertyAddress;

	private static int GetDefaultInputPin_ReturnValue_Offset;

	private static bool GetContextOutputsInCS_IsValid;

	private IntPtr GetContextOutputsInCS_InstanceFunctionAddress;

	private static IntPtr GetContextOutputsInCS_FunctionAddress;

	private static int GetContextOutputsInCS_ParamsSize;

	private static bool GetContextOutputsInCS_ReturnValue_IsValid;

	private static FFieldAddress GetContextOutputsInCS_ReturnValue_PropertyAddress;

	private static int GetContextOutputsInCS_ReturnValue_Offset;

	private static bool GetContextInputsInCS_IsValid;

	private IntPtr GetContextInputsInCS_InstanceFunctionAddress;

	private static IntPtr GetContextInputsInCS_FunctionAddress;

	private static int GetContextInputsInCS_ParamsSize;

	private static bool GetContextInputsInCS_ReturnValue_IsValid;

	private static FFieldAddress GetContextInputsInCS_ReturnValue_PropertyAddress;

	private static int GetContextInputsInCS_ReturnValue_Offset;

	private static bool GetConnections_IsValid;

	private static IntPtr GetConnections_FunctionAddress;

	private static int GetConnections_ParamsSize;

	private static bool GetConnections_ReturnValue_IsValid;

	private static FFieldAddress GetConnections_ReturnValue_PropertyAddress;

	private static int GetConnections_ReturnValue_Offset;

	private static bool GetConnection_IsValid;

	private static IntPtr GetConnection_FunctionAddress;

	private static int GetConnection_ParamsSize;

	private static bool GetConnection_OutputName_IsValid;

	private static FFieldAddress GetConnection_OutputName_PropertyAddress;

	private static int GetConnection_OutputName_Offset;

	private static bool GetConnection_ReturnValue_IsValid;

	private static FFieldAddress GetConnection_ReturnValue_PropertyAddress;

	private static int GetConnection_ReturnValue_Offset;

	private static bool GetCalliopeAsset_IsValid;

	private static IntPtr GetCalliopeAsset_FunctionAddress;

	private static int GetCalliopeAsset_ParamsSize;

	private static bool GetCalliopeAsset_ReturnValue_IsValid;

	private static FFieldAddress GetCalliopeAsset_ReturnValue_PropertyAddress;

	private static int GetCalliopeAsset_ReturnValue_Offset;

	private static bool GetBranchGraphToEditInCS_IsValid;

	private IntPtr GetBranchGraphToEditInCS_InstanceFunctionAddress;

	private static IntPtr GetBranchGraphToEditInCS_FunctionAddress;

	private static int GetBranchGraphToEditInCS_ParamsSize;

	private static bool GetBranchGraphToEditInCS_OutBranchGraphIdentifier_IsValid;

	private static FFieldAddress GetBranchGraphToEditInCS_OutBranchGraphIdentifier_PropertyAddress;

	private static int GetBranchGraphToEditInCS_OutBranchGraphIdentifier_Offset;

	private static bool GetBranchGraphToEditInCS_ReturnValue_IsValid;

	private static FFieldAddress GetBranchGraphToEditInCS_ReturnValue_PropertyAddress;

	private static int GetBranchGraphToEditInCS_ReturnValue_Offset;

	private static bool GetAssetToEditInCS_IsValid;

	private IntPtr GetAssetToEditInCS_InstanceFunctionAddress;

	private static IntPtr GetAssetToEditInCS_FunctionAddress;

	private static int GetAssetToEditInCS_ParamsSize;

	private static bool GetAssetToEditInCS_ReturnValue_IsValid;

	private static FFieldAddress GetAssetToEditInCS_ReturnValue_PropertyAddress;

	private static int GetAssetToEditInCS_ReturnValue_Offset;

	private static bool GetAssetPathInCS_IsValid;

	private IntPtr GetAssetPathInCS_InstanceFunctionAddress;

	private static IntPtr GetAssetPathInCS_FunctionAddress;

	private static int GetAssetPathInCS_ParamsSize;

	private static bool GetAssetPathInCS_ReturnValue_IsValid;

	private static FFieldAddress GetAssetPathInCS_ReturnValue_PropertyAddress;

	private static int GetAssetPathInCS_ReturnValue_Offset;

	private static bool GetActorToFocusInCS_IsValid;

	private IntPtr GetActorToFocusInCS_InstanceFunctionAddress;

	private static IntPtr GetActorToFocusInCS_FunctionAddress;

	private static int GetActorToFocusInCS_ParamsSize;

	private static bool GetActorToFocusInCS_ReturnValue_IsValid;

	private static FFieldAddress GetActorToFocusInCS_ReturnValue_PropertyAddress;

	private static int GetActorToFocusInCS_ReturnValue_Offset;

	private static bool ForceRefreshDetailView_IsValid;

	private static IntPtr ForceRefreshDetailView_FunctionAddress;

	private static int ForceRefreshDetailView_ParamsSize;

	private static bool ExecuteOnReconstructionRequested_IsValid;

	private static IntPtr ExecuteOnReconstructionRequested_FunctionAddress;

	private static int ExecuteOnReconstructionRequested_ParamsSize;

	private static bool Deactivate_IsValid;

	private static IntPtr Deactivate_FunctionAddress;

	private static int Deactivate_ParamsSize;

	private static bool Cleanup_IsValid;

	private IntPtr Cleanup_InstanceFunctionAddress;

	private static IntPtr Cleanup_FunctionAddress;

	private static int Cleanup_ParamsSize;

	private static bool CheckCanPassNodeInfo_IsValid;

	private static IntPtr CheckCanPassNodeInfo_FunctionAddress;

	private static int CheckCanPassNodeInfo_ParamsSize;

	private static bool CheckCanPassNodeInfo_PreviousNodeGuid_IsValid;

	private static FFieldAddress CheckCanPassNodeInfo_PreviousNodeGuid_PropertyAddress;

	private static int CheckCanPassNodeInfo_PreviousNodeGuid_Offset;

	private static bool CheckCanPassNodeInfo_ReturnValue_IsValid;

	private static FFieldAddress CheckCanPassNodeInfo_ReturnValue_PropertyAddress;

	private static int CheckCanPassNodeInfo_ReturnValue_Offset;

	private static bool CanUserAddOutputInCS_IsValid;

	private IntPtr CanUserAddOutputInCS_InstanceFunctionAddress;

	private static IntPtr CanUserAddOutputInCS_FunctionAddress;

	private static int CanUserAddOutputInCS_ParamsSize;

	private static bool CanUserAddOutputInCS_ReturnValue_IsValid;

	private static FFieldAddress CanUserAddOutputInCS_ReturnValue_PropertyAddress;

	private static int CanUserAddOutputInCS_ReturnValue_Offset;

	private static bool CanUserAddInputInCS_IsValid;

	private IntPtr CanUserAddInputInCS_InstanceFunctionAddress;

	private static IntPtr CanUserAddInputInCS_FunctionAddress;

	private static int CanUserAddInputInCS_ParamsSize;

	private static bool CanUserAddInputInCS_ReturnValue_IsValid;

	private static FFieldAddress CanUserAddInputInCS_ReturnValue_PropertyAddress;

	private static int CanUserAddInputInCS_ReturnValue_Offset;

	private static bool BindAssetOnSubGraphReconstructionRequested_IsValid;

	private static IntPtr BindAssetOnSubGraphReconstructionRequested_FunctionAddress;

	private static int BindAssetOnSubGraphReconstructionRequested_ParamsSize;

	private static bool BindAssetOnSubGraphReconstructionRequested_Asset_IsValid;

	private static FFieldAddress BindAssetOnSubGraphReconstructionRequested_Asset_PropertyAddress;

	private static int BindAssetOnSubGraphReconstructionRequested_Asset_Offset;

	private static bool AssignInteractorGroupIDPolice_IsValid;

	private static IntPtr AssignInteractorGroupIDPolice_FunctionAddress;

	private static int AssignInteractorGroupIDPolice_ParamsSize;

	private static bool AssignInteractorGroupIDPolice_InIndex_IsValid;

	private static FFieldAddress AssignInteractorGroupIDPolice_InIndex_PropertyAddress;

	private static int AssignInteractorGroupIDPolice_InIndex_Offset;

	private static bool AssignInteractorGroupIDPolice_InGroupIDIndex_IsValid;

	private static FFieldAddress AssignInteractorGroupIDPolice_InGroupIDIndex_PropertyAddress;

	private static int AssignInteractorGroupIDPolice_InGroupIDIndex_Offset;

	private static bool AddOutputPins_IsValid;

	private static IntPtr AddOutputPins_FunctionAddress;

	private static int AddOutputPins_ParamsSize;

	private static bool AddOutputPins_PinNames_IsValid;

	private static FFieldAddress AddOutputPins_PinNames_PropertyAddress;

	private static int AddOutputPins_PinNames_Offset;

	private static bool AddInputPins_IsValid;

	private static IntPtr AddInputPins_FunctionAddress;

	private static int AddInputPins_ParamsSize;

	private static bool AddInputPins_PinNames_IsValid;

	private static FFieldAddress AddInputPins_PinNames_PropertyAddress;

	private static int AddInputPins_PinNames_Offset;

	private static bool Activate_IsValid;

	private static IntPtr Activate_FunctionAddress;

	private static int Activate_ParamsSize;

	[UProperty(Flags = (PropFlags)11267864954667524uL)]
	[UMetaPath("/Script/Calliope.CalliopeNode:bSupportsContextPins")]
	protected bool SupportsContextPins
	{
		get
		{
			CheckDestroyed();
			if (!SupportsContextPins_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:bSupportsContextPins");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SupportsContextPins_Offset), 0, SupportsContextPins_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SupportsContextPins_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:bSupportsContextPins");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SupportsContextPins_Offset), 0, SupportsContextPins_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267795161448964uL)]
	[UMetaPath("/Script/Calliope.CalliopeNode:Category")]
	protected string Category
	{
		get
		{
			CheckDestroyed();
			if (!Category_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:Category");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Category_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Category_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:Category");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Category_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954733061uL)]
	[UMetaPath("/Script/Calliope.CalliopeNode:NodeStyle")]
	protected ECalliopeNodeStyle NodeStyle
	{
		get
		{
			CheckDestroyed();
			if (!NodeStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:NodeStyle");
				return ECalliopeNodeStyle.Condition;
			}
			return EnumMarshaler<ECalliopeNodeStyle>.FromNative(IntPtr.Add(base.Address, NodeStyle_Offset), 0, NodeStyle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NodeStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:NodeStyle");
			}
			else
			{
				EnumMarshaler<ECalliopeNodeStyle>.ToNative(IntPtr.Add(base.Address, NodeStyle_Offset), 0, NodeStyle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627436549uL)]
	[UMetaPath("/Script/Calliope.CalliopeNode:InputPins")]
	protected TArrayReadWrite<FCalliopePin> InputPins
	{
		get
		{
			CheckDestroyed();
			if (!InputPins_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:InputPins");
				return null;
			}
			if (InputPins_MarshalerCached == null)
			{
				InputPins_MarshalerCached = new TArrayReadWriteMarshaler<FCalliopePin>(1, InputPins_PropertyAddress, CachedMarshalingDelegates<FCalliopePin, FCalliopePin>.FromNative, CachedMarshalingDelegates<FCalliopePin, FCalliopePin>.ToNative);
			}
			return InputPins_MarshalerCached.FromNative(IntPtr.Add(base.Address, InputPins_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627436549uL)]
	[UMetaPath("/Script/Calliope.CalliopeNode:OutputPins")]
	protected TArrayReadWrite<FCalliopePin> OutputPins
	{
		get
		{
			CheckDestroyed();
			if (!OutputPins_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:OutputPins");
				return null;
			}
			if (OutputPins_MarshalerCached == null)
			{
				OutputPins_MarshalerCached = new TArrayReadWriteMarshaler<FCalliopePin>(1, OutputPins_PropertyAddress, CachedMarshalingDelegates<FCalliopePin, FCalliopePin>.FromNative, CachedMarshalingDelegates<FCalliopePin, FCalliopePin>.ToNative);
			}
			return OutputPins_MarshalerCached.FromNative(IntPtr.Add(base.Address, OutputPins_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)9015995347894277uL)]
	[UMetaPath("/Script/Calliope.CalliopeNode:Connections")]
	protected TMapReadWrite<FName, FCalliopeConnectedPin> Connections
	{
		get
		{
			CheckDestroyed();
			if (!Connections_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:Connections");
				return null;
			}
			if (Connections_MarshalerCached == null)
			{
				Connections_MarshalerCached = new TMapReadWriteMarshaler<FName, FCalliopeConnectedPin>(1, Connections_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FCalliopeConnectedPin, FCalliopeConnectedPin>.FromNative, CachedMarshalingDelegates<FCalliopeConnectedPin, FCalliopeConnectedPin>.ToNative);
			}
			return Connections_MarshalerCached.FromNative(IntPtr.Add(base.Address, Connections_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.CalliopeNode:NodeGuid")]
	public Guid NodeGuid
	{
		get
		{
			CheckDestroyed();
			if (!NodeGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:NodeGuid");
				return default(Guid);
			}
			return BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(base.Address, NodeGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NodeGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:NodeGuid");
			}
			else
			{
				BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(base.Address, NodeGuid_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.CalliopeNode:bNodeHasError")]
	public bool NodeHasError
	{
		get
		{
			CheckDestroyed();
			if (!NodeHasError_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:bNodeHasError");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NodeHasError_Offset), 0, NodeHasError_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NodeHasError_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:bNodeHasError");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NodeHasError_Offset), 0, NodeHasError_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.CalliopeNode:bBossPhaseRequireActive")]
	public bool BossPhaseRequireActive
	{
		get
		{
			CheckDestroyed();
			if (!BossPhaseRequireActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:bBossPhaseRequireActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BossPhaseRequireActive_Offset), 0, BossPhaseRequireActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BossPhaseRequireActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:bBossPhaseRequireActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BossPhaseRequireActive_Offset), 0, BossPhaseRequireActive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.CalliopeNode:NodeIndex")]
	public int NodeIndex
	{
		get
		{
			CheckDestroyed();
			if (!NodeIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:NodeIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NodeIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NodeIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:NodeIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NodeIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.CalliopeNode:ParentNode")]
	public FGsCalliopeNodeParam ParentNode
	{
		get
		{
			CheckDestroyed();
			if (!ParentNode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:ParentNode");
				return default(FGsCalliopeNodeParam);
			}
			return FGsCalliopeNodeParam.FromNative(IntPtr.Add(base.Address, ParentNode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParentNode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:ParentNode");
			}
			else
			{
				FGsCalliopeNodeParam.ToNative(IntPtr.Add(base.Address, ParentNode_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Calliope.CalliopeNode:SceneObjPoliceConfig")]
	public FGsSceneObjPoliceConfig SceneObjPoliceConfig
	{
		get
		{
			CheckDestroyed();
			if (!SceneObjPoliceConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:SceneObjPoliceConfig");
				return default(FGsSceneObjPoliceConfig);
			}
			return FGsSceneObjPoliceConfig.FromNative(IntPtr.Add(base.Address, SceneObjPoliceConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneObjPoliceConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeNode:SceneObjPoliceConfig");
			}
			else
			{
				FGsSceneObjPoliceConfig.ToNative(IntPtr.Add(base.Address, SceneObjPoliceConfig_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:UnBindAssetOnSubGraphReconstructionRequested")]
	public unsafe void UnBindAssetOnSubGraphReconstructionRequested(UCalliopeAsset Asset)
	{
		CheckDestroyed();
		if (!UnBindAssetOnSubGraphReconstructionRequested_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:UnBindAssetOnSubGraphReconstructionRequested");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnBindAssetOnSubGraphReconstructionRequested_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnBindAssetOnSubGraphReconstructionRequested_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(intPtr, UnBindAssetOnSubGraphReconstructionRequested_Asset_Offset), 0, UnBindAssetOnSubGraphReconstructionRequested_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnBindAssetOnSubGraphReconstructionRequested_FunctionAddress, intPtr, UnBindAssetOnSubGraphReconstructionRequested_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:SyncSceneObjPoliceConfig")]
	public unsafe void SyncSceneObjPoliceConfig()
	{
		CheckDestroyed();
		if (!SyncSceneObjPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:SyncSceneObjPoliceConfig");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SyncSceneObjPoliceConfig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SyncSceneObjPoliceConfig_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SyncSceneObjPoliceConfig_FunctionAddress, argsSize: SyncSceneObjPoliceConfig_ParamsSize);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:SetSubGraphAssetInPIE")]
	public unsafe void SetSubGraphAssetInPIE(UCalliopeAsset InSubGraphAsset)
	{
		CheckDestroyed();
		if (!SetSubGraphAssetInPIE_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:SetSubGraphAssetInPIE");
			return;
		}
		if (SetSubGraphAssetInPIE_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetSubGraphAssetInPIE_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetSubGraphAssetInPIE");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSubGraphAssetInPIE_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSubGraphAssetInPIE_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(intPtr, SetSubGraphAssetInPIE_InSubGraphAsset_Offset), 0, SetSubGraphAssetInPIE_InSubGraphAsset_PropertyAddress.Address, InSubGraphAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSubGraphAssetInPIE_InstanceFunctionAddress, intPtr, SetSubGraphAssetInPIE_ParamsSize);
	}

	protected unsafe virtual void SetSubGraphAssetInPIE_Implementation(UCalliopeAsset InSubGraphAsset)
	{
		CheckDestroyed();
		if (!SetSubGraphAssetInPIE_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:SetSubGraphAssetInPIE");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSubGraphAssetInPIE_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSubGraphAssetInPIE_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(intPtr, SetSubGraphAssetInPIE_InSubGraphAsset_Offset), 0, SetSubGraphAssetInPIE_InSubGraphAsset_PropertyAddress.Address, InSubGraphAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSubGraphAssetInPIE_FunctionAddress, intPtr, SetSubGraphAssetInPIE_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:SetOutputPins")]
	public unsafe void SetOutputPins(List<FCalliopePin> InOutputPins)
	{
		CheckDestroyed();
		if (!SetOutputPins_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:SetOutputPins");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOutputPins_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOutputPins_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FCalliopePin>(1, SetOutputPins_InOutputPins_PropertyAddress, CachedMarshalingDelegates<FCalliopePin, FCalliopePin>.FromNative, CachedMarshalingDelegates<FCalliopePin, FCalliopePin>.ToNative).ToNative(IntPtr.Add(intPtr, SetOutputPins_InOutputPins_Offset), InOutputPins);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOutputPins_FunctionAddress, intPtr, SetOutputPins_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetOutputPins_InOutputPins_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:SetInputPins")]
	public unsafe void SetInputPins(List<FCalliopePin> InInputPins)
	{
		CheckDestroyed();
		if (!SetInputPins_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:SetInputPins");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInputPins_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInputPins_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FCalliopePin>(1, SetInputPins_InInputPins_PropertyAddress, CachedMarshalingDelegates<FCalliopePin, FCalliopePin>.FromNative, CachedMarshalingDelegates<FCalliopePin, FCalliopePin>.ToNative).ToNative(IntPtr.Add(intPtr, SetInputPins_InInputPins_Offset), InInputPins);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInputPins_FunctionAddress, intPtr, SetInputPins_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetInputPins_InInputPins_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:SetConnections")]
	public unsafe void SetConnections(out Dictionary<FName, FCalliopeConnectedPin> InConnections)
	{
		CheckDestroyed();
		if (!SetConnections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:SetConnections");
			InConnections = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConnections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConnections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetConnections_InConnections_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetConnections_FunctionAddress, intPtr, SetConnections_ParamsSize);
		InConnections = new TMapCopyMarshaler<FName, FCalliopeConnectedPin>(1, SetConnections_InConnections_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FCalliopeConnectedPin, FCalliopeConnectedPin>.FromNative, CachedMarshalingDelegates<FCalliopeConnectedPin, FCalliopeConnectedPin>.ToNative).FromNative(IntPtr.Add(intPtr, SetConnections_InConnections_Offset));
		NativeReflection.DestroyValue_InContainer(SetConnections_InConnections_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:ResetRecordsInCS")]
	public unsafe void ResetRecordsInCS()
	{
		CheckDestroyed();
		if (!ResetRecordsInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:ResetRecordsInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetRecordsInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetRecordsInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetRecordsInCS_FunctionAddress, argsSize: ResetRecordsInCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:RefreshSceneObjPoliceConfig")]
	public unsafe void RefreshSceneObjPoliceConfig(UCalliopeNode PreviousNode)
	{
		CheckDestroyed();
		if (!RefreshSceneObjPoliceConfig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:RefreshSceneObjPoliceConfig");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshSceneObjPoliceConfig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshSceneObjPoliceConfig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, RefreshSceneObjPoliceConfig_PreviousNode_Offset), 0, RefreshSceneObjPoliceConfig_PreviousNode_PropertyAddress.Address, PreviousNode);
		NativeReflection.InvokeFunctionOptimized(base.Address, RefreshSceneObjPoliceConfig_FunctionAddress, intPtr, RefreshSceneObjPoliceConfig_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:RefreshParentNode")]
	public unsafe void RefreshParentNode()
	{
		CheckDestroyed();
		if (!RefreshParentNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:RefreshParentNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshParentNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshParentNode_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RefreshParentNode_FunctionAddress, argsSize: RefreshParentNode_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:RecordOutput")]
	public unsafe void RecordOutput(FName PinName)
	{
		CheckDestroyed();
		if (!RecordOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:RecordOutput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecordOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecordOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RecordOutput_PinName_Offset), 0, RecordOutput_PinName_PropertyAddress.Address, PinName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RecordOutput_FunctionAddress, intPtr, RecordOutput_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:RecordInput")]
	public unsafe void RecordInput(FName PinName)
	{
		CheckDestroyed();
		if (!RecordInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:RecordInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecordInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecordInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RecordInput_PinName_Offset), 0, RecordInput_PinName_PropertyAddress.Address, PinName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RecordInput_FunctionAddress, intPtr, RecordInput_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:PrePropertyChanged")]
	public unsafe void PrePropertyChanged(string PropertyName)
	{
		CheckDestroyed();
		if (!PrePropertyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:PrePropertyChanged");
			return;
		}
		if (PrePropertyChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			PrePropertyChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PrePropertyChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrePropertyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrePropertyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PrePropertyChanged_PropertyName_Offset), 0, PrePropertyChanged_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, PrePropertyChanged_InstanceFunctionAddress, intPtr, PrePropertyChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PrePropertyChanged_PropertyName_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void PrePropertyChanged_Implementation(string PropertyName)
	{
		CheckDestroyed();
		if (!PrePropertyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:PrePropertyChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrePropertyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrePropertyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PrePropertyChanged_PropertyName_Offset), 0, PrePropertyChanged_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, PrePropertyChanged_FunctionAddress, intPtr, PrePropertyChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PrePropertyChanged_PropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:PostPropertyChanged")]
	public unsafe void PostPropertyChanged(string MemberName, string PropertyName)
	{
		CheckDestroyed();
		if (!PostPropertyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:PostPropertyChanged");
			return;
		}
		if (PostPropertyChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostPropertyChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostPropertyChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostPropertyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostPropertyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostPropertyChanged_MemberName_Offset), 0, PostPropertyChanged_MemberName_PropertyAddress.Address, MemberName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostPropertyChanged_PropertyName_Offset), 0, PostPropertyChanged_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostPropertyChanged_InstanceFunctionAddress, intPtr, PostPropertyChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PostPropertyChanged_MemberName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PostPropertyChanged_PropertyName_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void PostPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		CheckDestroyed();
		if (!PostPropertyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:PostPropertyChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostPropertyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostPropertyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostPropertyChanged_MemberName_Offset), 0, PostPropertyChanged_MemberName_PropertyAddress.Address, MemberName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostPropertyChanged_PropertyName_Offset), 0, PostPropertyChanged_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, PostPropertyChanged_FunctionAddress, intPtr, PostPropertyChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PostPropertyChanged_MemberName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PostPropertyChanged_PropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:PostLoadInCS")]
	public unsafe void PostLoadInCS()
	{
		CheckDestroyed();
		if (!PostLoadInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:PostLoadInCS");
			return;
		}
		if (PostLoadInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostLoadInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostLoadInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostLoadInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostLoadInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostLoadInCS_InstanceFunctionAddress, argsSize: PostLoadInCS_ParamsSize);
	}

	protected unsafe virtual void PostLoadInCS_Implementation()
	{
		CheckDestroyed();
		if (!PostLoadInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:PostLoadInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostLoadInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostLoadInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostLoadInCS_FunctionAddress, argsSize: PostLoadInCS_ParamsSize);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:OnSelectNodeInCS")]
	public unsafe void OnSelectNodeInCS()
	{
		CheckDestroyed();
		if (!OnSelectNodeInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:OnSelectNodeInCS");
			return;
		}
		if (OnSelectNodeInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnSelectNodeInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnSelectNodeInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSelectNodeInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSelectNodeInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnSelectNodeInCS_InstanceFunctionAddress, argsSize: OnSelectNodeInCS_ParamsSize);
	}

	protected unsafe virtual void OnSelectNodeInCS_Implementation()
	{
		CheckDestroyed();
		if (!OnSelectNodeInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:OnSelectNodeInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnSelectNodeInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSelectNodeInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnSelectNodeInCS_FunctionAddress, argsSize: OnSelectNodeInCS_ParamsSize);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:OnRefreshAssetInCS")]
	public unsafe void OnRefreshAssetInCS()
	{
		CheckDestroyed();
		if (!OnRefreshAssetInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:OnRefreshAssetInCS");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:OnRefreshAssetInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRefreshAssetInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRefreshAssetInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnRefreshAssetInCS_FunctionAddress, argsSize: OnRefreshAssetInCS_ParamsSize);
	}

	[UFunction(Flags = 671221760u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:OnCreateGraphNodeInCS")]
	public unsafe void OnCreateGraphNodeInCS()
	{
		CheckDestroyed();
		if (!OnCreateGraphNodeInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:OnCreateGraphNodeInCS");
			return;
		}
		if (OnCreateGraphNodeInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnCreateGraphNodeInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnCreateGraphNodeInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnCreateGraphNodeInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCreateGraphNodeInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnCreateGraphNodeInCS_InstanceFunctionAddress, argsSize: OnCreateGraphNodeInCS_ParamsSize);
	}

	protected unsafe virtual void OnCreateGraphNodeInCS_Implementation()
	{
		CheckDestroyed();
		if (!OnCreateGraphNodeInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:OnCreateGraphNodeInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnCreateGraphNodeInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCreateGraphNodeInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnCreateGraphNodeInCS_FunctionAddress, argsSize: OnCreateGraphNodeInCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:LogError")]
	public unsafe void LogError(string Message)
	{
		CheckDestroyed();
		if (!LogError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:LogError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LogError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LogError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LogError_Message_Offset), 0, LogError_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeFunctionOptimized(base.Address, LogError_FunctionAddress, intPtr, LogError_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LogError_Message_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:LoadAssetInCS")]
	public unsafe UCalliopeAsset LoadAssetInCS(TSoftObject<UCalliopeAsset> AssetPtr)
	{
		CheckDestroyed();
		if (!LoadAssetInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:LoadAssetInCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadAssetInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadAssetInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(LoadAssetInCS_AssetPtr_PropertyAddress.Address, intPtr);
		TSoftObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(intPtr, LoadAssetInCS_AssetPtr_Offset), 0, LoadAssetInCS_AssetPtr_PropertyAddress.Address, AssetPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, LoadAssetInCS_FunctionAddress, intPtr, LoadAssetInCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadAssetInCS_AssetPtr_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UCalliopeAsset>.FromNative(IntPtr.Add(intPtr, LoadAssetInCS_ReturnValue_Offset), 0, LoadAssetInCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:JumpToMe")]
	public unsafe void JumpToMe()
	{
		CheckDestroyed();
		if (!JumpToMe_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:JumpToMe");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(JumpToMe_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JumpToMe_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: JumpToMe_FunctionAddress, argsSize: JumpToMe_ParamsSize);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:IsSupportViewType")]
	public unsafe bool IsSupportViewType(ECalliopeViewType InViewType)
	{
		CheckDestroyed();
		if (!IsSupportViewType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsSupportViewType");
			return false;
		}
		if (IsSupportViewType_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsSupportViewType_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsSupportViewType");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSupportViewType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSupportViewType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECalliopeViewType>.ToNative(IntPtr.Add(intPtr, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address, InViewType);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSupportViewType_InstanceFunctionAddress, intPtr, IsSupportViewType_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		CheckDestroyed();
		if (!IsSupportViewType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsSupportViewType");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSupportViewType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSupportViewType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECalliopeViewType>.ToNative(IntPtr.Add(intPtr, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address, InViewType);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSupportViewType_FunctionAddress, intPtr, IsSupportViewType_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:IsSubGraphNode")]
	public unsafe bool IsSubGraphNode()
	{
		CheckDestroyed();
		if (!IsSubGraphNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsSubGraphNode");
			return false;
		}
		if (IsSubGraphNode_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsSubGraphNode_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsSubGraphNode");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSubGraphNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSubGraphNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSubGraphNode_InstanceFunctionAddress, intPtr, IsSubGraphNode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSubGraphNode_ReturnValue_Offset), 0, IsSubGraphNode_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsSubGraphNode_Implementation()
	{
		CheckDestroyed();
		if (!IsSubGraphNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsSubGraphNode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSubGraphNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSubGraphNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSubGraphNode_FunctionAddress, intPtr, IsSubGraphNode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSubGraphNode_ReturnValue_Offset), 0, IsSubGraphNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:IsPreloaded")]
	public unsafe bool IsPreloaded()
	{
		CheckDestroyed();
		if (!IsPreloaded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsPreloaded");
			return false;
		}
		if (IsPreloaded_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsPreloaded_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsPreloaded");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPreloaded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPreloaded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPreloaded_InstanceFunctionAddress, intPtr, IsPreloaded_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPreloaded_ReturnValue_Offset), 0, IsPreloaded_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsPreloaded_Implementation()
	{
		CheckDestroyed();
		if (!IsPreloaded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsPreloaded");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPreloaded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPreloaded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPreloaded_FunctionAddress, intPtr, IsPreloaded_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPreloaded_ReturnValue_Offset), 0, IsPreloaded_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:IsPlayInEditor")]
	public unsafe bool IsPlayInEditor()
	{
		CheckDestroyed();
		if (!IsPlayInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsPlayInEditor");
			return false;
		}
		if (IsPlayInEditor_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsPlayInEditor_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsPlayInEditor");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlayInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlayInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlayInEditor_InstanceFunctionAddress, intPtr, IsPlayInEditor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlayInEditor_ReturnValue_Offset), 0, IsPlayInEditor_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsPlayInEditor_Implementation()
	{
		CheckDestroyed();
		if (!IsPlayInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsPlayInEditor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlayInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlayInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlayInEditor_FunctionAddress, intPtr, IsPlayInEditor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlayInEditor_ReturnValue_Offset), 0, IsPlayInEditor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:IsOutputConnectTo")]
	public unsafe bool IsOutputConnectTo(FCalliopeGuid TargetNodeGuid)
	{
		CheckDestroyed();
		if (!IsOutputConnectTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsOutputConnectTo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsOutputConnectTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsOutputConnectTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsOutputConnectTo_TargetNodeGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, IsOutputConnectTo_TargetNodeGuid_Offset), 0, IsOutputConnectTo_TargetNodeGuid_PropertyAddress.Address, TargetNodeGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsOutputConnectTo_FunctionAddress, intPtr, IsOutputConnectTo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsOutputConnectTo_ReturnValue_Offset), 0, IsOutputConnectTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:IsCalliopeWasActive")]
	public unsafe bool IsCalliopeWasActive()
	{
		CheckDestroyed();
		if (!IsCalliopeWasActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsCalliopeWasActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCalliopeWasActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCalliopeWasActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCalliopeWasActive_FunctionAddress, intPtr, IsCalliopeWasActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCalliopeWasActive_ReturnValue_Offset), 0, IsCalliopeWasActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:IsCalliopeNeverActivated")]
	public unsafe bool IsCalliopeNeverActivated()
	{
		CheckDestroyed();
		if (!IsCalliopeNeverActivated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsCalliopeNeverActivated");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCalliopeNeverActivated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCalliopeNeverActivated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCalliopeNeverActivated_FunctionAddress, intPtr, IsCalliopeNeverActivated_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCalliopeNeverActivated_ReturnValue_Offset), 0, IsCalliopeNeverActivated_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:IsCalliopeActive")]
	public unsafe bool IsCalliopeActive()
	{
		CheckDestroyed();
		if (!IsCalliopeActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsCalliopeActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCalliopeActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCalliopeActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCalliopeActive_FunctionAddress, intPtr, IsCalliopeActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCalliopeActive_ReturnValue_Offset), 0, IsCalliopeActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:IsBranchGraphNode")]
	public unsafe bool IsBranchGraphNode()
	{
		CheckDestroyed();
		if (!IsBranchGraphNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsBranchGraphNode");
			return false;
		}
		if (IsBranchGraphNode_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsBranchGraphNode_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsBranchGraphNode");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsBranchGraphNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsBranchGraphNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsBranchGraphNode_InstanceFunctionAddress, intPtr, IsBranchGraphNode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsBranchGraphNode_ReturnValue_Offset), 0, IsBranchGraphNode_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsBranchGraphNode_Implementation()
	{
		CheckDestroyed();
		if (!IsBranchGraphNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsBranchGraphNode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsBranchGraphNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsBranchGraphNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsBranchGraphNode_FunctionAddress, intPtr, IsBranchGraphNode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsBranchGraphNode_ReturnValue_Offset), 0, IsBranchGraphNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:IsBattleStateNode")]
	public unsafe bool IsBattleStateNode()
	{
		CheckDestroyed();
		if (!IsBattleStateNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsBattleStateNode");
			return false;
		}
		if (IsBattleStateNode_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsBattleStateNode_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsBattleStateNode");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsBattleStateNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsBattleStateNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsBattleStateNode_InstanceFunctionAddress, intPtr, IsBattleStateNode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsBattleStateNode_ReturnValue_Offset), 0, IsBattleStateNode_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsBattleStateNode_Implementation()
	{
		CheckDestroyed();
		if (!IsBattleStateNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:IsBattleStateNode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsBattleStateNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsBattleStateNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsBattleStateNode_FunctionAddress, intPtr, IsBattleStateNode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsBattleStateNode_ReturnValue_Offset), 0, IsBattleStateNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetStatusStringInCS")]
	public unsafe string GetStatusStringInCS()
	{
		CheckDestroyed();
		if (!GetStatusStringInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetStatusStringInCS");
			return FStringMarshaler.DefaultString;
		}
		if (GetStatusStringInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetStatusStringInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetStatusStringInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatusStringInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatusStringInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStatusStringInCS_InstanceFunctionAddress, intPtr, GetStatusStringInCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetStatusStringInCS_ReturnValue_Offset), 0, GetStatusStringInCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetStatusStringInCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetStatusStringInCS_Implementation()
	{
		CheckDestroyed();
		if (!GetStatusStringInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetStatusStringInCS");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStatusStringInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStatusStringInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStatusStringInCS_FunctionAddress, intPtr, GetStatusStringInCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetStatusStringInCS_ReturnValue_Offset), 0, GetStatusStringInCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetStatusStringInCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetParentNodes")]
	public unsafe List<FCalliopeGuid> GetParentNodes()
	{
		CheckDestroyed();
		if (!GetParentNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetParentNodes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParentNodes_FunctionAddress, intPtr, GetParentNodes_ParamsSize);
		List<FCalliopeGuid> result = new TArrayCopyMarshaler<FCalliopeGuid>(1, GetParentNodes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.FromNative, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.ToNative).FromNative(IntPtr.Add(intPtr, GetParentNodes_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetParentNodes_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetOutputPins")]
	public unsafe List<FCalliopePin> GetOutputPins()
	{
		CheckDestroyed();
		if (!GetOutputPins_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetOutputPins");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOutputPins_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOutputPins_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOutputPins_FunctionAddress, intPtr, GetOutputPins_ParamsSize);
		List<FCalliopePin> result = new TArrayCopyMarshaler<FCalliopePin>(1, GetOutputPins_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FCalliopePin, FCalliopePin>.FromNative, CachedMarshalingDelegates<FCalliopePin, FCalliopePin>.ToNative).FromNative(IntPtr.Add(intPtr, GetOutputPins_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetOutputPins_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetOutputNames")]
	public unsafe List<FName> GetOutputNames()
	{
		CheckDestroyed();
		if (!GetOutputNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetOutputNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOutputNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOutputNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOutputNames_FunctionAddress, intPtr, GetOutputNames_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetOutputNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetOutputNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetOutputNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetNodeDescriptionInCS")]
	public unsafe string GetNodeDescriptionInCS()
	{
		CheckDestroyed();
		if (!GetNodeDescriptionInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetNodeDescriptionInCS");
			return FStringMarshaler.DefaultString;
		}
		if (GetNodeDescriptionInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetNodeDescriptionInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetNodeDescriptionInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeDescriptionInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeDescriptionInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeDescriptionInCS_InstanceFunctionAddress, intPtr, GetNodeDescriptionInCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetNodeDescriptionInCS_ReturnValue_Offset), 0, GetNodeDescriptionInCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetNodeDescriptionInCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetNodeDescriptionInCS_Implementation()
	{
		CheckDestroyed();
		if (!GetNodeDescriptionInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetNodeDescriptionInCS");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeDescriptionInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeDescriptionInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeDescriptionInCS_FunctionAddress, intPtr, GetNodeDescriptionInCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetNodeDescriptionInCS_ReturnValue_Offset), 0, GetNodeDescriptionInCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetNodeDescriptionInCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetInputPins")]
	public unsafe List<FCalliopePin> GetInputPins()
	{
		CheckDestroyed();
		if (!GetInputPins_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetInputPins");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputPins_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputPins_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputPins_FunctionAddress, intPtr, GetInputPins_ParamsSize);
		List<FCalliopePin> result = new TArrayCopyMarshaler<FCalliopePin>(1, GetInputPins_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FCalliopePin, FCalliopePin>.FromNative, CachedMarshalingDelegates<FCalliopePin, FCalliopePin>.ToNative).FromNative(IntPtr.Add(intPtr, GetInputPins_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetInputPins_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetInputNames")]
	public unsafe List<FName> GetInputNames()
	{
		CheckDestroyed();
		if (!GetInputNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetInputNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputNames_FunctionAddress, intPtr, GetInputNames_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetInputNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetInputNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetInputNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetGuid")]
	public unsafe FCalliopeGuid GetGuid()
	{
		CheckDestroyed();
		if (!GetGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetGuid");
			return default(FCalliopeGuid);
		}
		if (GetGuid_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetGuid_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetGuid");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGuid_InstanceFunctionAddress, intPtr, GetGuid_ParamsSize);
		return FCalliopeGuid.FromNative(IntPtr.Add(intPtr, GetGuid_ReturnValue_Offset), 0, GetGuid_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual FCalliopeGuid GetGuid_Implementation()
	{
		CheckDestroyed();
		if (!GetGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetGuid");
			return default(FCalliopeGuid);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGuid_FunctionAddress, intPtr, GetGuid_ParamsSize);
		return FCalliopeGuid.FromNative(IntPtr.Add(intPtr, GetGuid_ReturnValue_Offset), 0, GetGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetGraphNodeInCS")]
	public unsafe UEdGraphNode GetGraphNodeInCS()
	{
		CheckDestroyed();
		if (!GetGraphNodeInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetGraphNodeInCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGraphNodeInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGraphNodeInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGraphNodeInCS_FunctionAddress, intPtr, GetGraphNodeInCS_ParamsSize);
		return UObjectMarshaler<UEdGraphNode>.FromNative(IntPtr.Add(intPtr, GetGraphNodeInCS_ReturnValue_Offset), 0, GetGraphNodeInCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetGraphIdentifierInCS")]
	public unsafe bool GetGraphIdentifierInCS(out FName OutGraphIdentifier)
	{
		CheckDestroyed();
		if (!GetGraphIdentifierInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetGraphIdentifierInCS");
			OutGraphIdentifier = default(FName);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGraphIdentifierInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGraphIdentifierInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGraphIdentifierInCS_FunctionAddress, intPtr, GetGraphIdentifierInCS_ParamsSize);
		OutGraphIdentifier = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetGraphIdentifierInCS_OutGraphIdentifier_Offset), 0, GetGraphIdentifierInCS_OutGraphIdentifier_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetGraphIdentifierInCS_ReturnValue_Offset), 0, GetGraphIdentifierInCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetGraphGuidInCS")]
	public unsafe bool GetGraphGuidInCS(out FCalliopeGuid OutGraphGuid)
	{
		CheckDestroyed();
		if (!GetGraphGuidInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetGraphGuidInCS");
			OutGraphGuid = default(FCalliopeGuid);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGraphGuidInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGraphGuidInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetGraphGuidInCS_OutGraphGuid_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGraphGuidInCS_FunctionAddress, intPtr, GetGraphGuidInCS_ParamsSize);
		OutGraphGuid = FCalliopeGuid.FromNative(IntPtr.Add(intPtr, GetGraphGuidInCS_OutGraphGuid_Offset), 0, GetGraphGuidInCS_OutGraphGuid_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetGraphGuidInCS_ReturnValue_Offset), 0, GetGraphGuidInCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetDefaultOutputPin")]
	public unsafe FCalliopePin GetDefaultOutputPin()
	{
		CheckDestroyed();
		if (!GetDefaultOutputPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetDefaultOutputPin");
			return default(FCalliopePin);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultOutputPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultOutputPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultOutputPin_FunctionAddress, intPtr, GetDefaultOutputPin_ParamsSize);
		FCalliopePin result = FCalliopePin.FromNative(IntPtr.Add(intPtr, GetDefaultOutputPin_ReturnValue_Offset), 0, GetDefaultOutputPin_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDefaultOutputPin_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetDefaultInputPin")]
	public unsafe FCalliopePin GetDefaultInputPin()
	{
		CheckDestroyed();
		if (!GetDefaultInputPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetDefaultInputPin");
			return default(FCalliopePin);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultInputPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultInputPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultInputPin_FunctionAddress, intPtr, GetDefaultInputPin_ParamsSize);
		FCalliopePin result = FCalliopePin.FromNative(IntPtr.Add(intPtr, GetDefaultInputPin_ReturnValue_Offset), 0, GetDefaultInputPin_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDefaultInputPin_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetContextOutputsInCS")]
	public unsafe List<FName> GetContextOutputsInCS()
	{
		CheckDestroyed();
		if (!GetContextOutputsInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetContextOutputsInCS");
			return null;
		}
		if (GetContextOutputsInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetContextOutputsInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetContextOutputsInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetContextOutputsInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetContextOutputsInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetContextOutputsInCS_InstanceFunctionAddress, intPtr, GetContextOutputsInCS_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetContextOutputsInCS_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetContextOutputsInCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual List<FName> GetContextOutputsInCS_Implementation()
	{
		CheckDestroyed();
		if (!GetContextOutputsInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetContextOutputsInCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetContextOutputsInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetContextOutputsInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetContextOutputsInCS_FunctionAddress, intPtr, GetContextOutputsInCS_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetContextOutputsInCS_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetContextOutputsInCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetContextInputsInCS")]
	public unsafe List<FName> GetContextInputsInCS()
	{
		CheckDestroyed();
		if (!GetContextInputsInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetContextInputsInCS");
			return null;
		}
		if (GetContextInputsInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetContextInputsInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetContextInputsInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetContextInputsInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetContextInputsInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetContextInputsInCS_InstanceFunctionAddress, intPtr, GetContextInputsInCS_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetContextInputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetContextInputsInCS_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetContextInputsInCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual List<FName> GetContextInputsInCS_Implementation()
	{
		CheckDestroyed();
		if (!GetContextInputsInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetContextInputsInCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetContextInputsInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetContextInputsInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetContextInputsInCS_FunctionAddress, intPtr, GetContextInputsInCS_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetContextInputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetContextInputsInCS_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetContextInputsInCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetConnections")]
	public unsafe Dictionary<FName, FCalliopeConnectedPin> GetConnections()
	{
		CheckDestroyed();
		if (!GetConnections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetConnections");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConnections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConnections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetConnections_FunctionAddress, intPtr, GetConnections_ParamsSize);
		Dictionary<FName, FCalliopeConnectedPin> result = new TMapCopyMarshaler<FName, FCalliopeConnectedPin>(1, GetConnections_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FCalliopeConnectedPin, FCalliopeConnectedPin>.FromNative, CachedMarshalingDelegates<FCalliopeConnectedPin, FCalliopeConnectedPin>.ToNative).FromNative(IntPtr.Add(intPtr, GetConnections_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetConnections_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetConnection")]
	public unsafe FCalliopeConnectedPin GetConnection(FName OutputName)
	{
		CheckDestroyed();
		if (!GetConnection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetConnection");
			return default(FCalliopeConnectedPin);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConnection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConnection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetConnection_OutputName_Offset), 0, GetConnection_OutputName_PropertyAddress.Address, OutputName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetConnection_FunctionAddress, intPtr, GetConnection_ParamsSize);
		return FCalliopeConnectedPin.FromNative(IntPtr.Add(intPtr, GetConnection_ReturnValue_Offset), 0, GetConnection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetCalliopeAsset")]
	public unsafe UCalliopeAsset GetCalliopeAsset()
	{
		CheckDestroyed();
		if (!GetCalliopeAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetCalliopeAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCalliopeAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCalliopeAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCalliopeAsset_FunctionAddress, intPtr, GetCalliopeAsset_ParamsSize);
		return UObjectMarshaler<UCalliopeAsset>.FromNative(IntPtr.Add(intPtr, GetCalliopeAsset_ReturnValue_Offset), 0, GetCalliopeAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetBranchGraphToEditInCS")]
	public unsafe bool GetBranchGraphToEditInCS(out string OutBranchGraphIdentifier)
	{
		CheckDestroyed();
		if (!GetBranchGraphToEditInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetBranchGraphToEditInCS");
			OutBranchGraphIdentifier = FStringMarshaler.DefaultString;
			return false;
		}
		if (GetBranchGraphToEditInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetBranchGraphToEditInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetBranchGraphToEditInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBranchGraphToEditInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBranchGraphToEditInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBranchGraphToEditInCS_InstanceFunctionAddress, intPtr, GetBranchGraphToEditInCS_ParamsSize);
		OutBranchGraphIdentifier = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetBranchGraphToEditInCS_OutBranchGraphIdentifier_Offset), 0, GetBranchGraphToEditInCS_OutBranchGraphIdentifier_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetBranchGraphToEditInCS_OutBranchGraphIdentifier_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBranchGraphToEditInCS_ReturnValue_Offset), 0, GetBranchGraphToEditInCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool GetBranchGraphToEditInCS_Implementation(out string OutBranchGraphIdentifier)
	{
		CheckDestroyed();
		if (!GetBranchGraphToEditInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetBranchGraphToEditInCS");
			OutBranchGraphIdentifier = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBranchGraphToEditInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBranchGraphToEditInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBranchGraphToEditInCS_FunctionAddress, intPtr, GetBranchGraphToEditInCS_ParamsSize);
		OutBranchGraphIdentifier = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetBranchGraphToEditInCS_OutBranchGraphIdentifier_Offset), 0, GetBranchGraphToEditInCS_OutBranchGraphIdentifier_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetBranchGraphToEditInCS_OutBranchGraphIdentifier_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBranchGraphToEditInCS_ReturnValue_Offset), 0, GetBranchGraphToEditInCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetAssetToEditInCS")]
	public unsafe UObject GetAssetToEditInCS()
	{
		CheckDestroyed();
		if (!GetAssetToEditInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetAssetToEditInCS");
			return null;
		}
		if (GetAssetToEditInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAssetToEditInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAssetToEditInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetToEditInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetToEditInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAssetToEditInCS_InstanceFunctionAddress, intPtr, GetAssetToEditInCS_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetAssetToEditInCS_ReturnValue_Offset), 0, GetAssetToEditInCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual UObject GetAssetToEditInCS_Implementation()
	{
		CheckDestroyed();
		if (!GetAssetToEditInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetAssetToEditInCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetToEditInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetToEditInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAssetToEditInCS_FunctionAddress, intPtr, GetAssetToEditInCS_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetAssetToEditInCS_ReturnValue_Offset), 0, GetAssetToEditInCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetAssetPathInCS")]
	public unsafe string GetAssetPathInCS()
	{
		CheckDestroyed();
		if (!GetAssetPathInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetAssetPathInCS");
			return FStringMarshaler.DefaultString;
		}
		if (GetAssetPathInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAssetPathInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAssetPathInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetPathInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetPathInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAssetPathInCS_InstanceFunctionAddress, intPtr, GetAssetPathInCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetAssetPathInCS_ReturnValue_Offset), 0, GetAssetPathInCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAssetPathInCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetAssetPathInCS_Implementation()
	{
		CheckDestroyed();
		if (!GetAssetPathInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetAssetPathInCS");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetPathInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetPathInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAssetPathInCS_FunctionAddress, intPtr, GetAssetPathInCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetAssetPathInCS_ReturnValue_Offset), 0, GetAssetPathInCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAssetPathInCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:GetActorToFocusInCS")]
	public unsafe AActor GetActorToFocusInCS()
	{
		CheckDestroyed();
		if (!GetActorToFocusInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetActorToFocusInCS");
			return null;
		}
		if (GetActorToFocusInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetActorToFocusInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetActorToFocusInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorToFocusInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorToFocusInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorToFocusInCS_InstanceFunctionAddress, intPtr, GetActorToFocusInCS_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetActorToFocusInCS_ReturnValue_Offset), 0, GetActorToFocusInCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual AActor GetActorToFocusInCS_Implementation()
	{
		CheckDestroyed();
		if (!GetActorToFocusInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:GetActorToFocusInCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorToFocusInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorToFocusInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorToFocusInCS_FunctionAddress, intPtr, GetActorToFocusInCS_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetActorToFocusInCS_ReturnValue_Offset), 0, GetActorToFocusInCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:ForceRefreshDetailView")]
	public unsafe void ForceRefreshDetailView()
	{
		CheckDestroyed();
		if (!ForceRefreshDetailView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:ForceRefreshDetailView");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceRefreshDetailView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceRefreshDetailView_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceRefreshDetailView_FunctionAddress, argsSize: ForceRefreshDetailView_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:ExecuteOnReconstructionRequested")]
	public unsafe void ExecuteOnReconstructionRequested()
	{
		CheckDestroyed();
		if (!ExecuteOnReconstructionRequested_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:ExecuteOnReconstructionRequested");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteOnReconstructionRequested_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteOnReconstructionRequested_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ExecuteOnReconstructionRequested_FunctionAddress, argsSize: ExecuteOnReconstructionRequested_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:Deactivate")]
	public unsafe void Deactivate()
	{
		CheckDestroyed();
		if (!Deactivate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:Deactivate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Deactivate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Deactivate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Deactivate_FunctionAddress, argsSize: Deactivate_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:Cleanup")]
	public unsafe void Cleanup()
	{
		CheckDestroyed();
		if (!Cleanup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:Cleanup");
			return;
		}
		if (Cleanup_InstanceFunctionAddress == IntPtr.Zero)
		{
			Cleanup_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Cleanup");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Cleanup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Cleanup_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Cleanup_InstanceFunctionAddress, argsSize: Cleanup_ParamsSize);
	}

	protected unsafe virtual void Cleanup_Implementation()
	{
		CheckDestroyed();
		if (!Cleanup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:Cleanup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Cleanup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Cleanup_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Cleanup_FunctionAddress, argsSize: Cleanup_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:CheckCanPassNodeInfo")]
	public unsafe bool CheckCanPassNodeInfo(FCalliopeGuid PreviousNodeGuid)
	{
		CheckDestroyed();
		if (!CheckCanPassNodeInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:CheckCanPassNodeInfo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckCanPassNodeInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckCanPassNodeInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CheckCanPassNodeInfo_PreviousNodeGuid_PropertyAddress.Address, intPtr);
		FCalliopeGuid.ToNative(IntPtr.Add(intPtr, CheckCanPassNodeInfo_PreviousNodeGuid_Offset), 0, CheckCanPassNodeInfo_PreviousNodeGuid_PropertyAddress.Address, PreviousNodeGuid);
		NativeReflection.InvokeFunctionOptimized(base.Address, CheckCanPassNodeInfo_FunctionAddress, intPtr, CheckCanPassNodeInfo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckCanPassNodeInfo_ReturnValue_Offset), 0, CheckCanPassNodeInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:CanUserAddOutputInCS")]
	public unsafe bool CanUserAddOutputInCS()
	{
		CheckDestroyed();
		if (!CanUserAddOutputInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:CanUserAddOutputInCS");
			return false;
		}
		if (CanUserAddOutputInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			CanUserAddOutputInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CanUserAddOutputInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanUserAddOutputInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanUserAddOutputInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanUserAddOutputInCS_InstanceFunctionAddress, intPtr, CanUserAddOutputInCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanUserAddOutputInCS_ReturnValue_Offset), 0, CanUserAddOutputInCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool CanUserAddOutputInCS_Implementation()
	{
		CheckDestroyed();
		if (!CanUserAddOutputInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:CanUserAddOutputInCS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanUserAddOutputInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanUserAddOutputInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanUserAddOutputInCS_FunctionAddress, intPtr, CanUserAddOutputInCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanUserAddOutputInCS_ReturnValue_Offset), 0, CanUserAddOutputInCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:CanUserAddInputInCS")]
	public unsafe bool CanUserAddInputInCS()
	{
		CheckDestroyed();
		if (!CanUserAddInputInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:CanUserAddInputInCS");
			return false;
		}
		if (CanUserAddInputInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			CanUserAddInputInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CanUserAddInputInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanUserAddInputInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanUserAddInputInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanUserAddInputInCS_InstanceFunctionAddress, intPtr, CanUserAddInputInCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanUserAddInputInCS_ReturnValue_Offset), 0, CanUserAddInputInCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool CanUserAddInputInCS_Implementation()
	{
		CheckDestroyed();
		if (!CanUserAddInputInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:CanUserAddInputInCS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanUserAddInputInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanUserAddInputInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanUserAddInputInCS_FunctionAddress, intPtr, CanUserAddInputInCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanUserAddInputInCS_ReturnValue_Offset), 0, CanUserAddInputInCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:BindAssetOnSubGraphReconstructionRequested")]
	public unsafe void BindAssetOnSubGraphReconstructionRequested(UCalliopeAsset Asset)
	{
		CheckDestroyed();
		if (!BindAssetOnSubGraphReconstructionRequested_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:BindAssetOnSubGraphReconstructionRequested");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BindAssetOnSubGraphReconstructionRequested_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BindAssetOnSubGraphReconstructionRequested_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(intPtr, BindAssetOnSubGraphReconstructionRequested_Asset_Offset), 0, BindAssetOnSubGraphReconstructionRequested_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeFunctionOptimized(base.Address, BindAssetOnSubGraphReconstructionRequested_FunctionAddress, intPtr, BindAssetOnSubGraphReconstructionRequested_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:AssignInteractorGroupIDPolice")]
	public unsafe void AssignInteractorGroupIDPolice(int InIndex, int InGroupIDIndex)
	{
		CheckDestroyed();
		if (!AssignInteractorGroupIDPolice_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:AssignInteractorGroupIDPolice");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssignInteractorGroupIDPolice_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssignInteractorGroupIDPolice_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AssignInteractorGroupIDPolice_InIndex_Offset), 0, AssignInteractorGroupIDPolice_InIndex_PropertyAddress.Address, InIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AssignInteractorGroupIDPolice_InGroupIDIndex_Offset), 0, AssignInteractorGroupIDPolice_InGroupIDIndex_PropertyAddress.Address, InGroupIDIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, AssignInteractorGroupIDPolice_FunctionAddress, intPtr, AssignInteractorGroupIDPolice_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:AddOutputPins")]
	public unsafe void AddOutputPins(List<FName> PinNames)
	{
		CheckDestroyed();
		if (!AddOutputPins_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:AddOutputPins");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddOutputPins_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddOutputPins_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FName>(1, AddOutputPins_PinNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, AddOutputPins_PinNames_Offset), PinNames);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddOutputPins_FunctionAddress, intPtr, AddOutputPins_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddOutputPins_PinNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:AddInputPins")]
	public unsafe void AddInputPins(List<FName> PinNames)
	{
		CheckDestroyed();
		if (!AddInputPins_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:AddInputPins");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddInputPins_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddInputPins_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FName>(1, AddInputPins_PinNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, AddInputPins_PinNames_Offset), PinNames);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddInputPins_FunctionAddress, intPtr, AddInputPins_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddInputPins_PinNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeNode:Activate")]
	public unsafe void Activate()
	{
		CheckDestroyed();
		if (!Activate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeNode:Activate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Activate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Activate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Activate_FunctionAddress, argsSize: Activate_ParamsSize);
	}

	static UCalliopeNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCalliopeNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCalliopeNode));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Calliope.CalliopeNode");
		NativeReflectionCached.GetPropertyRef(ref SupportsContextPins_PropertyAddress, intPtr, "bSupportsContextPins");
		SupportsContextPins_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSupportsContextPins");
		SupportsContextPins_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSupportsContextPins", Classes.FBoolProperty);
		Category_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Category");
		Category_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Category", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NodeStyle_PropertyAddress, intPtr, "NodeStyle");
		NodeStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NodeStyle");
		NodeStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NodeStyle", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref InputPins_PropertyAddress, intPtr, "InputPins");
		InputPins_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputPins");
		InputPins_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputPins", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OutputPins_PropertyAddress, intPtr, "OutputPins");
		OutputPins_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputPins");
		OutputPins_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputPins", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Connections_PropertyAddress, intPtr, "Connections");
		Connections_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Connections");
		Connections_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Connections", Classes.FMapProperty);
		NodeGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NodeGuid");
		NodeGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NodeGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NodeHasError_PropertyAddress, intPtr, "bNodeHasError");
		NodeHasError_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNodeHasError");
		NodeHasError_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNodeHasError", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BossPhaseRequireActive_PropertyAddress, intPtr, "bBossPhaseRequireActive");
		BossPhaseRequireActive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBossPhaseRequireActive");
		BossPhaseRequireActive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBossPhaseRequireActive", Classes.FBoolProperty);
		NodeIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NodeIndex");
		NodeIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NodeIndex", Classes.FIntProperty);
		ParentNode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParentNode");
		ParentNode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParentNode", Classes.FStructProperty);
		SceneObjPoliceConfig_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SceneObjPoliceConfig");
		SceneObjPoliceConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SceneObjPoliceConfig", Classes.FStructProperty);
		UnBindAssetOnSubGraphReconstructionRequested_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnBindAssetOnSubGraphReconstructionRequested");
		UnBindAssetOnSubGraphReconstructionRequested_ParamsSize = NativeReflection.GetFunctionParamsSize(UnBindAssetOnSubGraphReconstructionRequested_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnBindAssetOnSubGraphReconstructionRequested_Asset_PropertyAddress, UnBindAssetOnSubGraphReconstructionRequested_FunctionAddress, "Asset");
		UnBindAssetOnSubGraphReconstructionRequested_Asset_Offset = NativeReflectionCached.GetPropertyOffset(UnBindAssetOnSubGraphReconstructionRequested_FunctionAddress, "Asset");
		UnBindAssetOnSubGraphReconstructionRequested_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(UnBindAssetOnSubGraphReconstructionRequested_FunctionAddress, "Asset", Classes.FObjectProperty);
		UnBindAssetOnSubGraphReconstructionRequested_IsValid = UnBindAssetOnSubGraphReconstructionRequested_FunctionAddress != IntPtr.Zero && UnBindAssetOnSubGraphReconstructionRequested_Asset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:UnBindAssetOnSubGraphReconstructionRequested", UnBindAssetOnSubGraphReconstructionRequested_IsValid);
		SyncSceneObjPoliceConfig_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SyncSceneObjPoliceConfig");
		SyncSceneObjPoliceConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(SyncSceneObjPoliceConfig_FunctionAddress);
		SyncSceneObjPoliceConfig_IsValid = SyncSceneObjPoliceConfig_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:SyncSceneObjPoliceConfig", SyncSceneObjPoliceConfig_IsValid);
		SetSubGraphAssetInPIE_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSubGraphAssetInPIE");
		SetSubGraphAssetInPIE_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSubGraphAssetInPIE_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSubGraphAssetInPIE_InSubGraphAsset_PropertyAddress, SetSubGraphAssetInPIE_FunctionAddress, "InSubGraphAsset");
		SetSubGraphAssetInPIE_InSubGraphAsset_Offset = NativeReflectionCached.GetPropertyOffset(SetSubGraphAssetInPIE_FunctionAddress, "InSubGraphAsset");
		SetSubGraphAssetInPIE_InSubGraphAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubGraphAssetInPIE_FunctionAddress, "InSubGraphAsset", Classes.FObjectProperty);
		SetSubGraphAssetInPIE_IsValid = SetSubGraphAssetInPIE_FunctionAddress != IntPtr.Zero && SetSubGraphAssetInPIE_InSubGraphAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:SetSubGraphAssetInPIE", SetSubGraphAssetInPIE_IsValid);
		SetOutputPins_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOutputPins");
		SetOutputPins_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOutputPins_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOutputPins_InOutputPins_PropertyAddress, SetOutputPins_FunctionAddress, "InOutputPins");
		SetOutputPins_InOutputPins_Offset = NativeReflectionCached.GetPropertyOffset(SetOutputPins_FunctionAddress, "InOutputPins");
		SetOutputPins_InOutputPins_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOutputPins_FunctionAddress, "InOutputPins", Classes.FArrayProperty);
		SetOutputPins_IsValid = SetOutputPins_FunctionAddress != IntPtr.Zero && SetOutputPins_InOutputPins_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:SetOutputPins", SetOutputPins_IsValid);
		SetInputPins_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInputPins");
		SetInputPins_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInputPins_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInputPins_InInputPins_PropertyAddress, SetInputPins_FunctionAddress, "InInputPins");
		SetInputPins_InInputPins_Offset = NativeReflectionCached.GetPropertyOffset(SetInputPins_FunctionAddress, "InInputPins");
		SetInputPins_InInputPins_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInputPins_FunctionAddress, "InInputPins", Classes.FArrayProperty);
		SetInputPins_IsValid = SetInputPins_FunctionAddress != IntPtr.Zero && SetInputPins_InInputPins_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:SetInputPins", SetInputPins_IsValid);
		SetConnections_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetConnections");
		SetConnections_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConnections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConnections_InConnections_PropertyAddress, SetConnections_FunctionAddress, "InConnections");
		SetConnections_InConnections_Offset = NativeReflectionCached.GetPropertyOffset(SetConnections_FunctionAddress, "InConnections");
		SetConnections_InConnections_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConnections_FunctionAddress, "InConnections", Classes.FMapProperty);
		SetConnections_IsValid = SetConnections_FunctionAddress != IntPtr.Zero && SetConnections_InConnections_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:SetConnections", SetConnections_IsValid);
		ResetRecordsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetRecordsInCS");
		ResetRecordsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetRecordsInCS_FunctionAddress);
		ResetRecordsInCS_IsValid = ResetRecordsInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:ResetRecordsInCS", ResetRecordsInCS_IsValid);
		RefreshSceneObjPoliceConfig_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RefreshSceneObjPoliceConfig");
		RefreshSceneObjPoliceConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshSceneObjPoliceConfig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RefreshSceneObjPoliceConfig_PreviousNode_PropertyAddress, RefreshSceneObjPoliceConfig_FunctionAddress, "PreviousNode");
		RefreshSceneObjPoliceConfig_PreviousNode_Offset = NativeReflectionCached.GetPropertyOffset(RefreshSceneObjPoliceConfig_FunctionAddress, "PreviousNode");
		RefreshSceneObjPoliceConfig_PreviousNode_IsValid = NativeReflectionCached.ValidatePropertyClass(RefreshSceneObjPoliceConfig_FunctionAddress, "PreviousNode", Classes.FObjectProperty);
		RefreshSceneObjPoliceConfig_IsValid = RefreshSceneObjPoliceConfig_FunctionAddress != IntPtr.Zero && RefreshSceneObjPoliceConfig_PreviousNode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:RefreshSceneObjPoliceConfig", RefreshSceneObjPoliceConfig_IsValid);
		RefreshParentNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RefreshParentNode");
		RefreshParentNode_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshParentNode_FunctionAddress);
		RefreshParentNode_IsValid = RefreshParentNode_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:RefreshParentNode", RefreshParentNode_IsValid);
		RecordOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RecordOutput");
		RecordOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(RecordOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RecordOutput_PinName_PropertyAddress, RecordOutput_FunctionAddress, "PinName");
		RecordOutput_PinName_Offset = NativeReflectionCached.GetPropertyOffset(RecordOutput_FunctionAddress, "PinName");
		RecordOutput_PinName_IsValid = NativeReflectionCached.ValidatePropertyClass(RecordOutput_FunctionAddress, "PinName", Classes.FNameProperty);
		RecordOutput_IsValid = RecordOutput_FunctionAddress != IntPtr.Zero && RecordOutput_PinName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:RecordOutput", RecordOutput_IsValid);
		RecordInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RecordInput");
		RecordInput_ParamsSize = NativeReflection.GetFunctionParamsSize(RecordInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RecordInput_PinName_PropertyAddress, RecordInput_FunctionAddress, "PinName");
		RecordInput_PinName_Offset = NativeReflectionCached.GetPropertyOffset(RecordInput_FunctionAddress, "PinName");
		RecordInput_PinName_IsValid = NativeReflectionCached.ValidatePropertyClass(RecordInput_FunctionAddress, "PinName", Classes.FNameProperty);
		RecordInput_IsValid = RecordInput_FunctionAddress != IntPtr.Zero && RecordInput_PinName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:RecordInput", RecordInput_IsValid);
		PrePropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PrePropertyChanged");
		PrePropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PrePropertyChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PrePropertyChanged_PropertyName_PropertyAddress, PrePropertyChanged_FunctionAddress, "PropertyName");
		PrePropertyChanged_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(PrePropertyChanged_FunctionAddress, "PropertyName");
		PrePropertyChanged_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(PrePropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PrePropertyChanged_IsValid = PrePropertyChanged_FunctionAddress != IntPtr.Zero && PrePropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:PrePropertyChanged", PrePropertyChanged_IsValid);
		PostPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostPropertyChanged");
		PostPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(PostPropertyChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostPropertyChanged_MemberName_PropertyAddress, PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_Offset = NativeReflectionCached.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "MemberName");
		PostPropertyChanged_MemberName_IsValid = NativeReflectionCached.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PostPropertyChanged_PropertyName_PropertyAddress, PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(PostPropertyChanged_FunctionAddress, "PropertyName");
		PostPropertyChanged_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(PostPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		PostPropertyChanged_IsValid = PostPropertyChanged_FunctionAddress != IntPtr.Zero && PostPropertyChanged_MemberName_IsValid && PostPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:PostPropertyChanged", PostPropertyChanged_IsValid);
		PostLoadInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostLoadInCS");
		PostLoadInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostLoadInCS_FunctionAddress);
		PostLoadInCS_IsValid = PostLoadInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:PostLoadInCS", PostLoadInCS_IsValid);
		OnSelectNodeInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnSelectNodeInCS");
		OnSelectNodeInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSelectNodeInCS_FunctionAddress);
		OnSelectNodeInCS_IsValid = OnSelectNodeInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:OnSelectNodeInCS", OnSelectNodeInCS_IsValid);
		OnRefreshAssetInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRefreshAssetInCS");
		OnRefreshAssetInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRefreshAssetInCS_FunctionAddress);
		OnRefreshAssetInCS_IsValid = OnRefreshAssetInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:OnRefreshAssetInCS", OnRefreshAssetInCS_IsValid);
		OnCreateGraphNodeInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnCreateGraphNodeInCS");
		OnCreateGraphNodeInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCreateGraphNodeInCS_FunctionAddress);
		OnCreateGraphNodeInCS_IsValid = OnCreateGraphNodeInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:OnCreateGraphNodeInCS", OnCreateGraphNodeInCS_IsValid);
		LogError_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LogError");
		LogError_ParamsSize = NativeReflection.GetFunctionParamsSize(LogError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LogError_Message_PropertyAddress, LogError_FunctionAddress, "Message");
		LogError_Message_Offset = NativeReflectionCached.GetPropertyOffset(LogError_FunctionAddress, "Message");
		LogError_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(LogError_FunctionAddress, "Message", Classes.FStrProperty);
		LogError_IsValid = LogError_FunctionAddress != IntPtr.Zero && LogError_Message_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:LogError", LogError_IsValid);
		LoadAssetInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LoadAssetInCS");
		LoadAssetInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadAssetInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadAssetInCS_AssetPtr_PropertyAddress, LoadAssetInCS_FunctionAddress, "AssetPtr");
		LoadAssetInCS_AssetPtr_Offset = NativeReflectionCached.GetPropertyOffset(LoadAssetInCS_FunctionAddress, "AssetPtr");
		LoadAssetInCS_AssetPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadAssetInCS_FunctionAddress, "AssetPtr", Classes.FSoftObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadAssetInCS_ReturnValue_PropertyAddress, LoadAssetInCS_FunctionAddress, "ReturnValue");
		LoadAssetInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadAssetInCS_FunctionAddress, "ReturnValue");
		LoadAssetInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadAssetInCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		LoadAssetInCS_IsValid = LoadAssetInCS_FunctionAddress != IntPtr.Zero && LoadAssetInCS_AssetPtr_IsValid && LoadAssetInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:LoadAssetInCS", LoadAssetInCS_IsValid);
		JumpToMe_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "JumpToMe");
		JumpToMe_ParamsSize = NativeReflection.GetFunctionParamsSize(JumpToMe_FunctionAddress);
		JumpToMe_IsValid = JumpToMe_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:JumpToMe", JumpToMe_IsValid);
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflectionCached.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:IsSupportViewType", IsSupportViewType_IsValid);
		IsSubGraphNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSubGraphNode");
		IsSubGraphNode_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSubGraphNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSubGraphNode_ReturnValue_PropertyAddress, IsSubGraphNode_FunctionAddress, "ReturnValue");
		IsSubGraphNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSubGraphNode_FunctionAddress, "ReturnValue");
		IsSubGraphNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSubGraphNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSubGraphNode_IsValid = IsSubGraphNode_FunctionAddress != IntPtr.Zero && IsSubGraphNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:IsSubGraphNode", IsSubGraphNode_IsValid);
		IsPreloaded_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPreloaded");
		IsPreloaded_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPreloaded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPreloaded_ReturnValue_PropertyAddress, IsPreloaded_FunctionAddress, "ReturnValue");
		IsPreloaded_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPreloaded_FunctionAddress, "ReturnValue");
		IsPreloaded_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPreloaded_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPreloaded_IsValid = IsPreloaded_FunctionAddress != IntPtr.Zero && IsPreloaded_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:IsPreloaded", IsPreloaded_IsValid);
		IsPlayInEditor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlayInEditor");
		IsPlayInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayInEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlayInEditor_ReturnValue_PropertyAddress, IsPlayInEditor_FunctionAddress, "ReturnValue");
		IsPlayInEditor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayInEditor_FunctionAddress, "ReturnValue");
		IsPlayInEditor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayInEditor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayInEditor_IsValid = IsPlayInEditor_FunctionAddress != IntPtr.Zero && IsPlayInEditor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:IsPlayInEditor", IsPlayInEditor_IsValid);
		IsOutputConnectTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsOutputConnectTo");
		IsOutputConnectTo_ParamsSize = NativeReflection.GetFunctionParamsSize(IsOutputConnectTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsOutputConnectTo_TargetNodeGuid_PropertyAddress, IsOutputConnectTo_FunctionAddress, "TargetNodeGuid");
		IsOutputConnectTo_TargetNodeGuid_Offset = NativeReflectionCached.GetPropertyOffset(IsOutputConnectTo_FunctionAddress, "TargetNodeGuid");
		IsOutputConnectTo_TargetNodeGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOutputConnectTo_FunctionAddress, "TargetNodeGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsOutputConnectTo_ReturnValue_PropertyAddress, IsOutputConnectTo_FunctionAddress, "ReturnValue");
		IsOutputConnectTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsOutputConnectTo_FunctionAddress, "ReturnValue");
		IsOutputConnectTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsOutputConnectTo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsOutputConnectTo_IsValid = IsOutputConnectTo_FunctionAddress != IntPtr.Zero && IsOutputConnectTo_TargetNodeGuid_IsValid && IsOutputConnectTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:IsOutputConnectTo", IsOutputConnectTo_IsValid);
		IsCalliopeWasActive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsCalliopeWasActive");
		IsCalliopeWasActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCalliopeWasActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCalliopeWasActive_ReturnValue_PropertyAddress, IsCalliopeWasActive_FunctionAddress, "ReturnValue");
		IsCalliopeWasActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCalliopeWasActive_FunctionAddress, "ReturnValue");
		IsCalliopeWasActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCalliopeWasActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCalliopeWasActive_IsValid = IsCalliopeWasActive_FunctionAddress != IntPtr.Zero && IsCalliopeWasActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:IsCalliopeWasActive", IsCalliopeWasActive_IsValid);
		IsCalliopeNeverActivated_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsCalliopeNeverActivated");
		IsCalliopeNeverActivated_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCalliopeNeverActivated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCalliopeNeverActivated_ReturnValue_PropertyAddress, IsCalliopeNeverActivated_FunctionAddress, "ReturnValue");
		IsCalliopeNeverActivated_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCalliopeNeverActivated_FunctionAddress, "ReturnValue");
		IsCalliopeNeverActivated_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCalliopeNeverActivated_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCalliopeNeverActivated_IsValid = IsCalliopeNeverActivated_FunctionAddress != IntPtr.Zero && IsCalliopeNeverActivated_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:IsCalliopeNeverActivated", IsCalliopeNeverActivated_IsValid);
		IsCalliopeActive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsCalliopeActive");
		IsCalliopeActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCalliopeActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCalliopeActive_ReturnValue_PropertyAddress, IsCalliopeActive_FunctionAddress, "ReturnValue");
		IsCalliopeActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCalliopeActive_FunctionAddress, "ReturnValue");
		IsCalliopeActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCalliopeActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCalliopeActive_IsValid = IsCalliopeActive_FunctionAddress != IntPtr.Zero && IsCalliopeActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:IsCalliopeActive", IsCalliopeActive_IsValid);
		IsBranchGraphNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsBranchGraphNode");
		IsBranchGraphNode_ParamsSize = NativeReflection.GetFunctionParamsSize(IsBranchGraphNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsBranchGraphNode_ReturnValue_PropertyAddress, IsBranchGraphNode_FunctionAddress, "ReturnValue");
		IsBranchGraphNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsBranchGraphNode_FunctionAddress, "ReturnValue");
		IsBranchGraphNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBranchGraphNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsBranchGraphNode_IsValid = IsBranchGraphNode_FunctionAddress != IntPtr.Zero && IsBranchGraphNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:IsBranchGraphNode", IsBranchGraphNode_IsValid);
		IsBattleStateNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsBattleStateNode");
		IsBattleStateNode_ParamsSize = NativeReflection.GetFunctionParamsSize(IsBattleStateNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsBattleStateNode_ReturnValue_PropertyAddress, IsBattleStateNode_FunctionAddress, "ReturnValue");
		IsBattleStateNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsBattleStateNode_FunctionAddress, "ReturnValue");
		IsBattleStateNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBattleStateNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsBattleStateNode_IsValid = IsBattleStateNode_FunctionAddress != IntPtr.Zero && IsBattleStateNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:IsBattleStateNode", IsBattleStateNode_IsValid);
		GetStatusStringInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStatusStringInCS");
		GetStatusStringInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStatusStringInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStatusStringInCS_ReturnValue_PropertyAddress, GetStatusStringInCS_FunctionAddress, "ReturnValue");
		GetStatusStringInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStatusStringInCS_FunctionAddress, "ReturnValue");
		GetStatusStringInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStatusStringInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetStatusStringInCS_IsValid = GetStatusStringInCS_FunctionAddress != IntPtr.Zero && GetStatusStringInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetStatusStringInCS", GetStatusStringInCS_IsValid);
		GetParentNodes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetParentNodes");
		GetParentNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentNodes_ReturnValue_PropertyAddress, GetParentNodes_FunctionAddress, "ReturnValue");
		GetParentNodes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentNodes_FunctionAddress, "ReturnValue");
		GetParentNodes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentNodes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetParentNodes_IsValid = GetParentNodes_FunctionAddress != IntPtr.Zero && GetParentNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetParentNodes", GetParentNodes_IsValid);
		GetOutputPins_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOutputPins");
		GetOutputPins_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOutputPins_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOutputPins_ReturnValue_PropertyAddress, GetOutputPins_FunctionAddress, "ReturnValue");
		GetOutputPins_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOutputPins_FunctionAddress, "ReturnValue");
		GetOutputPins_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOutputPins_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetOutputPins_IsValid = GetOutputPins_FunctionAddress != IntPtr.Zero && GetOutputPins_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetOutputPins", GetOutputPins_IsValid);
		GetOutputNames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOutputNames");
		GetOutputNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOutputNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOutputNames_ReturnValue_PropertyAddress, GetOutputNames_FunctionAddress, "ReturnValue");
		GetOutputNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOutputNames_FunctionAddress, "ReturnValue");
		GetOutputNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOutputNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetOutputNames_IsValid = GetOutputNames_FunctionAddress != IntPtr.Zero && GetOutputNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetOutputNames", GetOutputNames_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
		GetInputPins_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInputPins");
		GetInputPins_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputPins_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputPins_ReturnValue_PropertyAddress, GetInputPins_FunctionAddress, "ReturnValue");
		GetInputPins_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputPins_FunctionAddress, "ReturnValue");
		GetInputPins_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputPins_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetInputPins_IsValid = GetInputPins_FunctionAddress != IntPtr.Zero && GetInputPins_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetInputPins", GetInputPins_IsValid);
		GetInputNames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInputNames");
		GetInputNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputNames_ReturnValue_PropertyAddress, GetInputNames_FunctionAddress, "ReturnValue");
		GetInputNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputNames_FunctionAddress, "ReturnValue");
		GetInputNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetInputNames_IsValid = GetInputNames_FunctionAddress != IntPtr.Zero && GetInputNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetInputNames", GetInputNames_IsValid);
		GetGuid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGuid");
		GetGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGuid_ReturnValue_PropertyAddress, GetGuid_FunctionAddress, "ReturnValue");
		GetGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGuid_FunctionAddress, "ReturnValue");
		GetGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGuid_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetGuid_IsValid = GetGuid_FunctionAddress != IntPtr.Zero && GetGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetGuid", GetGuid_IsValid);
		GetGraphNodeInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGraphNodeInCS");
		GetGraphNodeInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGraphNodeInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGraphNodeInCS_ReturnValue_PropertyAddress, GetGraphNodeInCS_FunctionAddress, "ReturnValue");
		GetGraphNodeInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGraphNodeInCS_FunctionAddress, "ReturnValue");
		GetGraphNodeInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraphNodeInCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetGraphNodeInCS_IsValid = GetGraphNodeInCS_FunctionAddress != IntPtr.Zero && GetGraphNodeInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetGraphNodeInCS", GetGraphNodeInCS_IsValid);
		GetGraphIdentifierInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGraphIdentifierInCS");
		GetGraphIdentifierInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGraphIdentifierInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGraphIdentifierInCS_OutGraphIdentifier_PropertyAddress, GetGraphIdentifierInCS_FunctionAddress, "OutGraphIdentifier");
		GetGraphIdentifierInCS_OutGraphIdentifier_Offset = NativeReflectionCached.GetPropertyOffset(GetGraphIdentifierInCS_FunctionAddress, "OutGraphIdentifier");
		GetGraphIdentifierInCS_OutGraphIdentifier_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraphIdentifierInCS_FunctionAddress, "OutGraphIdentifier", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGraphIdentifierInCS_ReturnValue_PropertyAddress, GetGraphIdentifierInCS_FunctionAddress, "ReturnValue");
		GetGraphIdentifierInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGraphIdentifierInCS_FunctionAddress, "ReturnValue");
		GetGraphIdentifierInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraphIdentifierInCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetGraphIdentifierInCS_IsValid = GetGraphIdentifierInCS_FunctionAddress != IntPtr.Zero && GetGraphIdentifierInCS_OutGraphIdentifier_IsValid && GetGraphIdentifierInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetGraphIdentifierInCS", GetGraphIdentifierInCS_IsValid);
		GetGraphGuidInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGraphGuidInCS");
		GetGraphGuidInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGraphGuidInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGraphGuidInCS_OutGraphGuid_PropertyAddress, GetGraphGuidInCS_FunctionAddress, "OutGraphGuid");
		GetGraphGuidInCS_OutGraphGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetGraphGuidInCS_FunctionAddress, "OutGraphGuid");
		GetGraphGuidInCS_OutGraphGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraphGuidInCS_FunctionAddress, "OutGraphGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGraphGuidInCS_ReturnValue_PropertyAddress, GetGraphGuidInCS_FunctionAddress, "ReturnValue");
		GetGraphGuidInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGraphGuidInCS_FunctionAddress, "ReturnValue");
		GetGraphGuidInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraphGuidInCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetGraphGuidInCS_IsValid = GetGraphGuidInCS_FunctionAddress != IntPtr.Zero && GetGraphGuidInCS_OutGraphGuid_IsValid && GetGraphGuidInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetGraphGuidInCS", GetGraphGuidInCS_IsValid);
		GetDefaultOutputPin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultOutputPin");
		GetDefaultOutputPin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultOutputPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultOutputPin_ReturnValue_PropertyAddress, GetDefaultOutputPin_FunctionAddress, "ReturnValue");
		GetDefaultOutputPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultOutputPin_FunctionAddress, "ReturnValue");
		GetDefaultOutputPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultOutputPin_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDefaultOutputPin_IsValid = GetDefaultOutputPin_FunctionAddress != IntPtr.Zero && GetDefaultOutputPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetDefaultOutputPin", GetDefaultOutputPin_IsValid);
		GetDefaultInputPin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultInputPin");
		GetDefaultInputPin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultInputPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultInputPin_ReturnValue_PropertyAddress, GetDefaultInputPin_FunctionAddress, "ReturnValue");
		GetDefaultInputPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultInputPin_FunctionAddress, "ReturnValue");
		GetDefaultInputPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultInputPin_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDefaultInputPin_IsValid = GetDefaultInputPin_FunctionAddress != IntPtr.Zero && GetDefaultInputPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetDefaultInputPin", GetDefaultInputPin_IsValid);
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
		GetContextInputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextInputsInCS");
		GetContextInputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextInputsInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetContextInputsInCS_ReturnValue_PropertyAddress, GetContextInputsInCS_FunctionAddress, "ReturnValue");
		GetContextInputsInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetContextInputsInCS_FunctionAddress, "ReturnValue");
		GetContextInputsInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContextInputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextInputsInCS_IsValid = GetContextInputsInCS_FunctionAddress != IntPtr.Zero && GetContextInputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetContextInputsInCS", GetContextInputsInCS_IsValid);
		GetConnections_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetConnections");
		GetConnections_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConnections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConnections_ReturnValue_PropertyAddress, GetConnections_FunctionAddress, "ReturnValue");
		GetConnections_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConnections_FunctionAddress, "ReturnValue");
		GetConnections_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConnections_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetConnections_IsValid = GetConnections_FunctionAddress != IntPtr.Zero && GetConnections_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetConnections", GetConnections_IsValid);
		GetConnection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetConnection");
		GetConnection_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConnection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConnection_OutputName_PropertyAddress, GetConnection_FunctionAddress, "OutputName");
		GetConnection_OutputName_Offset = NativeReflectionCached.GetPropertyOffset(GetConnection_FunctionAddress, "OutputName");
		GetConnection_OutputName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConnection_FunctionAddress, "OutputName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConnection_ReturnValue_PropertyAddress, GetConnection_FunctionAddress, "ReturnValue");
		GetConnection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConnection_FunctionAddress, "ReturnValue");
		GetConnection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConnection_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetConnection_IsValid = GetConnection_FunctionAddress != IntPtr.Zero && GetConnection_OutputName_IsValid && GetConnection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetConnection", GetConnection_IsValid);
		GetCalliopeAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCalliopeAsset");
		GetCalliopeAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCalliopeAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCalliopeAsset_ReturnValue_PropertyAddress, GetCalliopeAsset_FunctionAddress, "ReturnValue");
		GetCalliopeAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCalliopeAsset_FunctionAddress, "ReturnValue");
		GetCalliopeAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCalliopeAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCalliopeAsset_IsValid = GetCalliopeAsset_FunctionAddress != IntPtr.Zero && GetCalliopeAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetCalliopeAsset", GetCalliopeAsset_IsValid);
		GetBranchGraphToEditInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBranchGraphToEditInCS");
		GetBranchGraphToEditInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBranchGraphToEditInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBranchGraphToEditInCS_OutBranchGraphIdentifier_PropertyAddress, GetBranchGraphToEditInCS_FunctionAddress, "OutBranchGraphIdentifier");
		GetBranchGraphToEditInCS_OutBranchGraphIdentifier_Offset = NativeReflectionCached.GetPropertyOffset(GetBranchGraphToEditInCS_FunctionAddress, "OutBranchGraphIdentifier");
		GetBranchGraphToEditInCS_OutBranchGraphIdentifier_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBranchGraphToEditInCS_FunctionAddress, "OutBranchGraphIdentifier", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBranchGraphToEditInCS_ReturnValue_PropertyAddress, GetBranchGraphToEditInCS_FunctionAddress, "ReturnValue");
		GetBranchGraphToEditInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBranchGraphToEditInCS_FunctionAddress, "ReturnValue");
		GetBranchGraphToEditInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBranchGraphToEditInCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBranchGraphToEditInCS_IsValid = GetBranchGraphToEditInCS_FunctionAddress != IntPtr.Zero && GetBranchGraphToEditInCS_OutBranchGraphIdentifier_IsValid && GetBranchGraphToEditInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetBranchGraphToEditInCS", GetBranchGraphToEditInCS_IsValid);
		GetAssetToEditInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAssetToEditInCS");
		GetAssetToEditInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetToEditInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetToEditInCS_ReturnValue_PropertyAddress, GetAssetToEditInCS_FunctionAddress, "ReturnValue");
		GetAssetToEditInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetToEditInCS_FunctionAddress, "ReturnValue");
		GetAssetToEditInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetToEditInCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAssetToEditInCS_IsValid = GetAssetToEditInCS_FunctionAddress != IntPtr.Zero && GetAssetToEditInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetAssetToEditInCS", GetAssetToEditInCS_IsValid);
		GetAssetPathInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAssetPathInCS");
		GetAssetPathInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetPathInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetPathInCS_ReturnValue_PropertyAddress, GetAssetPathInCS_FunctionAddress, "ReturnValue");
		GetAssetPathInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetPathInCS_FunctionAddress, "ReturnValue");
		GetAssetPathInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetPathInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetAssetPathInCS_IsValid = GetAssetPathInCS_FunctionAddress != IntPtr.Zero && GetAssetPathInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetAssetPathInCS", GetAssetPathInCS_IsValid);
		GetActorToFocusInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorToFocusInCS");
		GetActorToFocusInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorToFocusInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorToFocusInCS_ReturnValue_PropertyAddress, GetActorToFocusInCS_FunctionAddress, "ReturnValue");
		GetActorToFocusInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorToFocusInCS_FunctionAddress, "ReturnValue");
		GetActorToFocusInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorToFocusInCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetActorToFocusInCS_IsValid = GetActorToFocusInCS_FunctionAddress != IntPtr.Zero && GetActorToFocusInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:GetActorToFocusInCS", GetActorToFocusInCS_IsValid);
		ForceRefreshDetailView_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceRefreshDetailView");
		ForceRefreshDetailView_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceRefreshDetailView_FunctionAddress);
		ForceRefreshDetailView_IsValid = ForceRefreshDetailView_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:ForceRefreshDetailView", ForceRefreshDetailView_IsValid);
		ExecuteOnReconstructionRequested_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExecuteOnReconstructionRequested");
		ExecuteOnReconstructionRequested_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecuteOnReconstructionRequested_FunctionAddress);
		ExecuteOnReconstructionRequested_IsValid = ExecuteOnReconstructionRequested_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:ExecuteOnReconstructionRequested", ExecuteOnReconstructionRequested_IsValid);
		Deactivate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Deactivate");
		Deactivate_ParamsSize = NativeReflection.GetFunctionParamsSize(Deactivate_FunctionAddress);
		Deactivate_IsValid = Deactivate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:Deactivate", Deactivate_IsValid);
		Cleanup_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Cleanup");
		Cleanup_ParamsSize = NativeReflection.GetFunctionParamsSize(Cleanup_FunctionAddress);
		Cleanup_IsValid = Cleanup_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:Cleanup", Cleanup_IsValid);
		CheckCanPassNodeInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckCanPassNodeInfo");
		CheckCanPassNodeInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckCanPassNodeInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckCanPassNodeInfo_PreviousNodeGuid_PropertyAddress, CheckCanPassNodeInfo_FunctionAddress, "PreviousNodeGuid");
		CheckCanPassNodeInfo_PreviousNodeGuid_Offset = NativeReflectionCached.GetPropertyOffset(CheckCanPassNodeInfo_FunctionAddress, "PreviousNodeGuid");
		CheckCanPassNodeInfo_PreviousNodeGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckCanPassNodeInfo_FunctionAddress, "PreviousNodeGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckCanPassNodeInfo_ReturnValue_PropertyAddress, CheckCanPassNodeInfo_FunctionAddress, "ReturnValue");
		CheckCanPassNodeInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckCanPassNodeInfo_FunctionAddress, "ReturnValue");
		CheckCanPassNodeInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckCanPassNodeInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckCanPassNodeInfo_IsValid = CheckCanPassNodeInfo_FunctionAddress != IntPtr.Zero && CheckCanPassNodeInfo_PreviousNodeGuid_IsValid && CheckCanPassNodeInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:CheckCanPassNodeInfo", CheckCanPassNodeInfo_IsValid);
		CanUserAddOutputInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanUserAddOutputInCS");
		CanUserAddOutputInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(CanUserAddOutputInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanUserAddOutputInCS_ReturnValue_PropertyAddress, CanUserAddOutputInCS_FunctionAddress, "ReturnValue");
		CanUserAddOutputInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanUserAddOutputInCS_FunctionAddress, "ReturnValue");
		CanUserAddOutputInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanUserAddOutputInCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanUserAddOutputInCS_IsValid = CanUserAddOutputInCS_FunctionAddress != IntPtr.Zero && CanUserAddOutputInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:CanUserAddOutputInCS", CanUserAddOutputInCS_IsValid);
		CanUserAddInputInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanUserAddInputInCS");
		CanUserAddInputInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(CanUserAddInputInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanUserAddInputInCS_ReturnValue_PropertyAddress, CanUserAddInputInCS_FunctionAddress, "ReturnValue");
		CanUserAddInputInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanUserAddInputInCS_FunctionAddress, "ReturnValue");
		CanUserAddInputInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanUserAddInputInCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanUserAddInputInCS_IsValid = CanUserAddInputInCS_FunctionAddress != IntPtr.Zero && CanUserAddInputInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:CanUserAddInputInCS", CanUserAddInputInCS_IsValid);
		BindAssetOnSubGraphReconstructionRequested_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BindAssetOnSubGraphReconstructionRequested");
		BindAssetOnSubGraphReconstructionRequested_ParamsSize = NativeReflection.GetFunctionParamsSize(BindAssetOnSubGraphReconstructionRequested_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BindAssetOnSubGraphReconstructionRequested_Asset_PropertyAddress, BindAssetOnSubGraphReconstructionRequested_FunctionAddress, "Asset");
		BindAssetOnSubGraphReconstructionRequested_Asset_Offset = NativeReflectionCached.GetPropertyOffset(BindAssetOnSubGraphReconstructionRequested_FunctionAddress, "Asset");
		BindAssetOnSubGraphReconstructionRequested_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(BindAssetOnSubGraphReconstructionRequested_FunctionAddress, "Asset", Classes.FObjectProperty);
		BindAssetOnSubGraphReconstructionRequested_IsValid = BindAssetOnSubGraphReconstructionRequested_FunctionAddress != IntPtr.Zero && BindAssetOnSubGraphReconstructionRequested_Asset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:BindAssetOnSubGraphReconstructionRequested", BindAssetOnSubGraphReconstructionRequested_IsValid);
		AssignInteractorGroupIDPolice_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AssignInteractorGroupIDPolice");
		AssignInteractorGroupIDPolice_ParamsSize = NativeReflection.GetFunctionParamsSize(AssignInteractorGroupIDPolice_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssignInteractorGroupIDPolice_InIndex_PropertyAddress, AssignInteractorGroupIDPolice_FunctionAddress, "InIndex");
		AssignInteractorGroupIDPolice_InIndex_Offset = NativeReflectionCached.GetPropertyOffset(AssignInteractorGroupIDPolice_FunctionAddress, "InIndex");
		AssignInteractorGroupIDPolice_InIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(AssignInteractorGroupIDPolice_FunctionAddress, "InIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AssignInteractorGroupIDPolice_InGroupIDIndex_PropertyAddress, AssignInteractorGroupIDPolice_FunctionAddress, "InGroupIDIndex");
		AssignInteractorGroupIDPolice_InGroupIDIndex_Offset = NativeReflectionCached.GetPropertyOffset(AssignInteractorGroupIDPolice_FunctionAddress, "InGroupIDIndex");
		AssignInteractorGroupIDPolice_InGroupIDIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(AssignInteractorGroupIDPolice_FunctionAddress, "InGroupIDIndex", Classes.FIntProperty);
		AssignInteractorGroupIDPolice_IsValid = AssignInteractorGroupIDPolice_FunctionAddress != IntPtr.Zero && AssignInteractorGroupIDPolice_InIndex_IsValid && AssignInteractorGroupIDPolice_InGroupIDIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:AssignInteractorGroupIDPolice", AssignInteractorGroupIDPolice_IsValid);
		AddOutputPins_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddOutputPins");
		AddOutputPins_ParamsSize = NativeReflection.GetFunctionParamsSize(AddOutputPins_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddOutputPins_PinNames_PropertyAddress, AddOutputPins_FunctionAddress, "PinNames");
		AddOutputPins_PinNames_Offset = NativeReflectionCached.GetPropertyOffset(AddOutputPins_FunctionAddress, "PinNames");
		AddOutputPins_PinNames_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOutputPins_FunctionAddress, "PinNames", Classes.FArrayProperty);
		AddOutputPins_IsValid = AddOutputPins_FunctionAddress != IntPtr.Zero && AddOutputPins_PinNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:AddOutputPins", AddOutputPins_IsValid);
		AddInputPins_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddInputPins");
		AddInputPins_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInputPins_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddInputPins_PinNames_PropertyAddress, AddInputPins_FunctionAddress, "PinNames");
		AddInputPins_PinNames_Offset = NativeReflectionCached.GetPropertyOffset(AddInputPins_FunctionAddress, "PinNames");
		AddInputPins_PinNames_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInputPins_FunctionAddress, "PinNames", Classes.FArrayProperty);
		AddInputPins_IsValid = AddInputPins_FunctionAddress != IntPtr.Zero && AddInputPins_PinNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:AddInputPins", AddInputPins_IsValid);
		Activate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Activate");
		Activate_ParamsSize = NativeReflection.GetFunctionParamsSize(Activate_FunctionAddress);
		Activate_IsValid = Activate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeNode:Activate", Activate_IsValid);
	}
}
