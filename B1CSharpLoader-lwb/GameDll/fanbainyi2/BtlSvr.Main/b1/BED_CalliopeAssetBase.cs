using System;
using System.Collections.Generic;
using System.Text;
using b1.Plugins.Calliope;
using BtlB1;
using CommB1;
using Google.Protobuf.Collections;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase")]
public class BED_CalliopeAssetBase : UCalliopeAsset, ISmartActorGuidObj, IInterface
{
	private bool bCanHandleSearchChangeRequest = true;

	private static bool GetActorGuid_IsValid;

	private static IntPtr GetActorGuid_FunctionAddress;

	private static int GetActorGuid_ParamsSize;

	private static bool GetActorGuid_InActor_IsValid;

	private static int GetActorGuid_InActor_Offset;

	private static bool GetActorGuid_OutActorGuid_IsValid;

	private static int GetActorGuid_OutActorGuid_Offset;

	private static FFieldAddress GetActorGuid_OutActorGuid_PropertyAddress;

	private static bool GetActorGuid_ReturnValue_IsValid;

	private static int GetActorGuid_ReturnValue_Offset;

	private static FFieldAddress GetActorGuid_ReturnValue_PropertyAddress;

	private IntPtr GetActorGuid_InstanceFunctionAddressInstance;

	private static bool CanManageStates_IsValid;

	private static IntPtr CanManageStates_FunctionAddress;

	private static int CanManageStates_ParamsSize;

	private static bool CanManageStates_ReturnValue_IsValid;

	private static int CanManageStates_ReturnValue_Offset;

	private static FFieldAddress CanManageStates_ReturnValue_PropertyAddress;

	private IntPtr CanManageStates_InstanceFunctionAddressInstance;

	private static bool GetSubGraphNodes_IsValid;

	private static IntPtr GetSubGraphNodes_FunctionAddress;

	private static int GetSubGraphNodes_ParamsSize;

	private static bool GetSubGraphNodes_ReturnValue_IsValid;

	private static int GetSubGraphNodes_ReturnValue_Offset;

	private static FFieldAddress GetSubGraphNodes_ReturnValue_PropertyAddress;

	private static bool ExportDataByExtern_IsValid;

	private static IntPtr ExportDataByExtern_FunctionAddress;

	private static int ExportDataByExtern_ParamsSize;

	private static bool ExportDataByExtern_ReturnValue_IsValid;

	private static int ExportDataByExtern_ReturnValue_Offset;

	private static FFieldAddress ExportDataByExtern_ReturnValue_PropertyAddress;

	private static bool GetActorGuidOptions_IsValid;

	private static IntPtr GetActorGuidOptions_FunctionAddress;

	private static int GetActorGuidOptions_ParamsSize;

	private static bool GetActorGuidOptions_PropertyName_IsValid;

	private static int GetActorGuidOptions_PropertyName_Offset;

	private static FFieldAddress GetActorGuidOptions_PropertyName_PropertyAddress;

	private static bool GetActorGuidOptions_OutOptions_IsValid;

	private static int GetActorGuidOptions_OutOptions_Offset;

	private static FFieldAddress GetActorGuidOptions_OutOptions_PropertyAddress;

	private static bool GetActorGuidOptions_ReturnValue_IsValid;

	private static int GetActorGuidOptions_ReturnValue_Offset;

	private IntPtr GetActorGuidOptions_InstanceFunctionAddressInstance;

	private static bool GetObserveActorNodes_IsValid;

	private static IntPtr GetObserveActorNodes_FunctionAddress;

	private static int GetObserveActorNodes_ParamsSize;

	private static bool GetObserveActorNodes_ReturnValue_IsValid;

	private static int GetObserveActorNodes_ReturnValue_Offset;

	private static FFieldAddress GetObserveActorNodes_ReturnValue_PropertyAddress;

	private static bool GetNode_IsValid;

	private static IntPtr GetNode_FunctionAddress;

	private static int GetNode_ParamsSize;

	private static bool GetNode_InGuid_IsValid;

	private static int GetNode_InGuid_Offset;

	private static FFieldAddress GetNode_InGuid_PropertyAddress;

	private static bool GetNode_ReturnValue_IsValid;

	private static int GetNode_ReturnValue_Offset;

	private static bool GetNodes_IsValid;

	private static IntPtr GetNodes_FunctionAddress;

	private static int GetNodes_ParamsSize;

	private static bool GetNodes_ReturnValue_IsValid;

	private static int GetNodes_ReturnValue_Offset;

	private static FFieldAddress GetNodes_ReturnValue_PropertyAddress;

	private static bool GetViewType_IsValid;

	private static IntPtr GetViewType_FunctionAddress;

	private static int GetViewType_ParamsSize;

	private static bool GetViewType_ReturnValue_IsValid;

	private static int GetViewType_ReturnValue_Offset;

	private static FFieldAddress GetViewType_ReturnValue_PropertyAddress;

	private static bool ExportToData_IsValid;

	private static IntPtr ExportToData_FunctionAddress;

	private static int ExportToData_ParamsSize;

	private static bool ExportToData_ReturnValue_IsValid;

	private static int ExportToData_ReturnValue_Offset;

	private static FFieldAddress ExportToData_ReturnValue_PropertyAddress;

	private static bool RegisterNode_IsValid;

	private static IntPtr RegisterNode_FunctionAddress;

	private static int RegisterNode_ParamsSize;

	private static bool RegisterNode_NewGuid_IsValid;

	private static int RegisterNode_NewGuid_Offset;

	private static FFieldAddress RegisterNode_NewGuid_PropertyAddress;

	private static bool RegisterNode_NewNode_IsValid;

	private static int RegisterNode_NewNode_Offset;

	private static bool OnNodeActivate_IsValid;

	private static IntPtr OnNodeActivate_FunctionAddress;

	private static int OnNodeActivate_ParamsSize;

	private static bool OnNodeActivate_Node_IsValid;

	private static int OnNodeActivate_Node_Offset;

	private static bool UnregisterNode_IsValid;

	private static IntPtr UnregisterNode_FunctionAddress;

	private static int UnregisterNode_ParamsSize;

	private static bool UnregisterNode_NodeGuid_IsValid;

	private static int UnregisterNode_NodeGuid_Offset;

	private static FFieldAddress UnregisterNode_NodeGuid_PropertyAddress;

	private static bool GetCustomInputs_IsValid;

	private static IntPtr GetCustomInputs_FunctionAddress;

	private static int GetCustomInputs_ParamsSize;

	private static bool GetCustomInputs_ReturnValue_IsValid;

	private static int GetCustomInputs_ReturnValue_Offset;

	private static FFieldAddress GetCustomInputs_ReturnValue_PropertyAddress;

	private static bool OnNodeDeactivate_IsValid;

	private static IntPtr OnNodeDeactivate_FunctionAddress;

	private static int OnNodeDeactivate_ParamsSize;

	private static bool OnNodeDeactivate_Node_IsValid;

	private static int OnNodeDeactivate_Node_Offset;

	private static bool GetCustomOutputs_IsValid;

	private static IntPtr GetCustomOutputs_FunctionAddress;

	private static int GetCustomOutputs_ParamsSize;

	private static bool GetCustomOutputs_ReturnValue_IsValid;

	private static int GetCustomOutputs_ReturnValue_Offset;

	private static FFieldAddress GetCustomOutputs_ReturnValue_PropertyAddress;

	private static bool GetStartNodeClass_IsValid;

	private static IntPtr GetStartNodeClass_FunctionAddress;

	private static int GetStartNodeClass_ParamsSize;

	private static bool GetStartNodeClass_ReturnValue_IsValid;

	private static int GetStartNodeClass_ReturnValue_Offset;

	private static bool PreFinishInstance_IsValid;

	private static IntPtr PreFinishInstance_FunctionAddress;

	private static int PreFinishInstance_ParamsSize;

	private static bool PostStartInstance_IsValid;

	private static IntPtr PostStartInstance_FunctionAddress;

	private static int PostStartInstance_ParamsSize;

	private static bool OnPropertyChanged_IsValid;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static int OnPropertyChanged_MemberName_Offset;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	private static bool PostDuplicateInCS_IsValid;

	private static IntPtr PostDuplicateInCS_FunctionAddress;

	private static int PostDuplicateInCS_ParamsSize;

	private static bool PostDuplicateInCS_bDuplicateForPIE_IsValid;

	private static int PostDuplicateInCS_bDuplicateForPIE_Offset;

	private static FFieldAddress PostDuplicateInCS_bDuplicateForPIE_PropertyAddress;

	private static bool GetRerouteNodeClass_IsValid;

	private static IntPtr GetRerouteNodeClass_FunctionAddress;

	private static int GetRerouteNodeClass_ParamsSize;

	private static bool GetRerouteNodeClass_ReturnValue_IsValid;

	private static int GetRerouteNodeClass_ReturnValue_Offset;

	private static bool GetExtraDefaultInputNodes_IsValid;

	private static IntPtr GetExtraDefaultInputNodes_FunctionAddress;

	private static int GetExtraDefaultInputNodes_ParamsSize;

	private static bool GetExtraDefaultInputNodes_OutClasses_IsValid;

	private static int GetExtraDefaultInputNodes_OutClasses_Offset;

	private static FFieldAddress GetExtraDefaultInputNodes_OutClasses_PropertyAddress;

	private static bool GetExtraDefaultInputNodes_ReturnValue_IsValid;

	private static int GetExtraDefaultInputNodes_ReturnValue_Offset;

	private static bool GetExtraDefaultOutputNodes_IsValid;

	private static IntPtr GetExtraDefaultOutputNodes_FunctionAddress;

	private static int GetExtraDefaultOutputNodes_ParamsSize;

	private static bool GetExtraDefaultOutputNodes_OutClasses_IsValid;

	private static int GetExtraDefaultOutputNodes_OutClasses_Offset;

	private static FFieldAddress GetExtraDefaultOutputNodes_OutClasses_PropertyAddress;

	private static bool GetExtraDefaultOutputNodes_ReturnValue_IsValid;

	private static int GetExtraDefaultOutputNodes_ReturnValue_Offset;

	private static bool GetStartNodeClassInBranchGraph_IsValid;

	private static IntPtr GetStartNodeClassInBranchGraph_FunctionAddress;

	private static int GetStartNodeClassInBranchGraph_ParamsSize;

	private static bool GetStartNodeClassInBranchGraph_ReturnValue_IsValid;

	private static int GetStartNodeClassInBranchGraph_ReturnValue_Offset;

	private static bool GetRerouteNodeClassInBranchGraph_IsValid;

	private static IntPtr GetRerouteNodeClassInBranchGraph_FunctionAddress;

	private static int GetRerouteNodeClassInBranchGraph_ParamsSize;

	private static bool GetRerouteNodeClassInBranchGraph_ReturnValue_IsValid;

	private static int GetRerouteNodeClassInBranchGraph_ReturnValue_Offset;

	private static bool GetExtraDefaultInputNodesInBranchGraph_IsValid;

	private static IntPtr GetExtraDefaultInputNodesInBranchGraph_FunctionAddress;

	private static int GetExtraDefaultInputNodesInBranchGraph_ParamsSize;

	private static bool GetExtraDefaultInputNodesInBranchGraph_OutClasses_IsValid;

	private static int GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset;

	private static FFieldAddress GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress;

	private static bool GetExtraDefaultInputNodesInBranchGraph_ReturnValue_IsValid;

	private static int GetExtraDefaultInputNodesInBranchGraph_ReturnValue_Offset;

	private static bool GetExtraDefaultOutputNodesInBranchGraph_IsValid;

	private static IntPtr GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress;

	private static int GetExtraDefaultOutputNodesInBranchGraph_ParamsSize;

	private static bool GetExtraDefaultOutputNodesInBranchGraph_OutClasses_IsValid;

	private static int GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset;

	private static FFieldAddress GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress;

	private static bool GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_IsValid;

	private static int GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_Offset;

	public static bool bIgnoreExportErrorDialogue { get; set; }

	[UFunction]
	[BlueprintCallable]
	[Category("Calliope")]
	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:ExportDataByExtern")]
	public bool ExportDataByExtern()
	{
		return ExportToData();
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Calliope")]
	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetSubGraphNodes")]
	public List<BED_QuestNode_SubGraph> GetSubGraphNodes()
	{
		List<BED_QuestNode_SubGraph> list = new List<BED_QuestNode_SubGraph>();
		foreach (KeyValuePair<FCalliopeGuid, UCalliopeNode> item in GetNodes_Implementation())
		{
			BED_QuestNode_SubGraph bED_QuestNode_SubGraph = item.Value.Cast<BED_QuestNode_SubGraph>();
			if (bED_QuestNode_SubGraph != null)
			{
				list.Add(bED_QuestNode_SubGraph);
			}
		}
		return list;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Calliope")]
	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetObserveActorNodes")]
	public List<BED_QuestNode_ObserveByCondition> GetObserveActorNodes()
	{
		List<BED_QuestNode_ObserveByCondition> list = new List<BED_QuestNode_ObserveByCondition>();
		foreach (KeyValuePair<FCalliopeGuid, UCalliopeNode> item in GetNodes_Implementation())
		{
			BED_QuestNode_ObserveByCondition bED_QuestNode_ObserveByCondition = item.Value.Cast<BED_QuestNode_ObserveByCondition>();
			if (bED_QuestNode_ObserveByCondition != null)
			{
				list.Add(bED_QuestNode_ObserveByCondition);
			}
		}
		return list;
	}

	public virtual bool HasDeleteNodeLimit()
	{
		return false;
	}

	public virtual bool IsStartNodeNecessary()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:OnNodeActivate")]
	protected override void OnNodeActivate_Implementation(UCalliopeNode Node)
	{
		if (CanCalliopeAssetNodeLog())
		{
			BGW_CalliopeDebugManager.Get(this)?.LogCalliopeActivateNode(Node);
		}
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:OnNodeDeactivate")]
	protected override void OnNodeDeactivate_Implementation(UCalliopeNode Node)
	{
		if (CanCalliopeAssetNodeLog())
		{
			BGW_CalliopeDebugManager.Get(this)?.LogCalliopeDeactivateNode(Node);
		}
	}

	protected virtual bool CanCalliopeAssetNodeLog()
	{
		return false;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetCustomInputs")]
	protected override List<FName> GetCustomInputs_Implementation()
	{
		List<FName> list = new List<FName>();
		foreach (FGameplayTag gameplayTag in base.CustomInputs.GameplayTags)
		{
			list.Add(gameplayTag.TagName);
		}
		return list;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetCustomOutputs")]
	protected override List<FName> GetCustomOutputs_Implementation()
	{
		List<FName> list = new List<FName>();
		foreach (FGameplayTag gameplayTag in base.CustomOutputs.GameplayTags)
		{
			list.Add(gameplayTag.TagName);
		}
		return list;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetNode")]
	protected override UCalliopeNode GetNode_Implementation(FCalliopeGuid InGuid)
	{
		if (base.Nodes.ContainsKey(InGuid))
		{
			return base.Nodes[InGuid];
		}
		return null;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:RegisterNode")]
	protected override void RegisterNode_Implementation(FCalliopeGuid NewGuid, UCalliopeNode NewNode)
	{
		NewNode.NodeGuid = GameplayTagExtension.ConvertToGuid(NewGuid);
		base.Nodes.Add(NewGuid, NewNode);
		HarvestNodeConnections();
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:UnregisterNode")]
	protected override void UnregisterNode_Implementation(FCalliopeGuid NodeGuid)
	{
		base.Nodes.Remove(NodeGuid);
		HarvestNodeConnections();
		MarkPackageDirty();
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetNodes")]
	protected override Dictionary<FCalliopeGuid, UCalliopeNode> GetNodes_Implementation()
	{
		List<FCalliopeGuid> list = new List<FCalliopeGuid>();
		Dictionary<FCalliopeGuid, UCalliopeNode> dictionary = new Dictionary<FCalliopeGuid, UCalliopeNode>();
		foreach (KeyValuePair<FCalliopeGuid, UCalliopeNode> node in base.Nodes)
		{
			if (node.Value == null)
			{
				list.Add(node.Key);
			}
			else
			{
				dictionary.Add(node.Key, node.Value);
			}
		}
		foreach (FCalliopeGuid item in list)
		{
			base.Nodes.Remove(item);
		}
		return dictionary;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:PostDuplicateInCS")]
	protected override void PostDuplicateInCS_Implementation(bool bDuplicateForPIE)
	{
		if (!bDuplicateForPIE)
		{
			base.Nodes.Clear();
		}
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:OnPropertyChanged")]
	protected override void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName.Equals("CustomInputs") || PropertyName.Equals("CustomOutputs"))
		{
			ExecuteSubGraphReconstructionRequested();
		}
		if (!bCanHandleSearchChangeRequest)
		{
			return;
		}
		bCanHandleSearchChangeRequest = false;
		if (PropertyName.Equals("SearchNodeGuid"))
		{
			if (Guid.TryParse(base.SearchNodeGuid, out var result))
			{
				FCalliopeGuid key = GameplayTagExtension.ConvertToCalliopeGuid(result);
				if (base.Nodes.TryGetValue(key, out var value))
				{
					base.SearchNodeIndex = value.NodeIndex;
				}
				else
				{
					base.SearchNodeIndex = -1;
				}
			}
			else
			{
				base.SearchNodeIndex = -1;
			}
		}
		else if (PropertyName.Equals("SearchNodeIndex"))
		{
			base.SearchNodeGuid = "";
			foreach (KeyValuePair<FCalliopeGuid, UCalliopeNode> node in base.Nodes)
			{
				UCalliopeNode value2 = node.Value;
				if (value2.NodeIndex == base.SearchNodeIndex)
				{
					base.SearchNodeGuid = value2.NodeGuid.ToString();
					break;
				}
			}
		}
		bCanHandleSearchChangeRequest = true;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:ExportToData")]
	protected override bool ExportToData_Implementation()
	{
		BGUFunctionLibraryCS.RefreshGameDB();
		bool bCanExport = true;
		string OutErrorMessage = "";
		StringBuilder stringBuilder = new StringBuilder();
		base.NeedPreloadAssets.Clear();
		List<FSoftObjectPath> PreloadAssets = new List<FSoftObjectPath>();
		OnRefreshAssetInCS();
		foreach (UCalliopeNode value in base.Nodes.Values)
		{
			if (value == null)
			{
				bCanExport = false;
				stringBuilder.AppendLine("存在过期/不可用节点，请及时清理");
				continue;
			}
			value.OnRefreshAssetInCS();
			if (value.IsSupportViewType(GetViewType()))
			{
				if (!(value is BED_CalliopeNodeBae bED_CalliopeNodeBae))
				{
					continue;
				}
				if (bED_CalliopeNodeBae.CorrectnessCheck(out OutErrorMessage))
				{
					value.NodeHasError = false;
					PreloadAssets.Clear();
					bED_CalliopeNodeBae.GetPreloadAssets(ref PreloadAssets);
					foreach (FSoftObjectPath item in PreloadAssets)
					{
						if (!base.NeedPreloadAssets.Contains(item))
						{
							base.NeedPreloadAssets.Add(item);
						}
					}
				}
				else
				{
					MarkNodeHasError(value, OutErrorMessage, stringBuilder);
				}
			}
			else
			{
				MarkNodeHasError(value, "当前视图不支持该节点", stringBuilder);
			}
		}
		PostRefreshAssetInCS();
		if (bCanExport)
		{
			if (CorrectnessCheck(out OutErrorMessage))
			{
				if (BGW_CalliopeDataConverter.Get().ExportData(this, out var FinalErrorMsg) < 0)
				{
					UGSFuncLibForEditor.ShowNotifyText(FinalErrorMsg);
					BGW_LogUtil.LogError(FinalErrorMsg);
					if (!bIgnoreExportErrorDialogue)
					{
						UGSFuncLibForEditor.ShowMassageDialog(FinalErrorMsg);
					}
				}
				return true;
			}
			stringBuilder.AppendLine(OutErrorMessage);
		}
		string text = $"{GetPathName()} 导出校验失败： \r\n\t {stringBuilder} \r\n";
		UGSFuncLibForEditor.ShowNotifyText(text);
		if (!bIgnoreExportErrorDialogue)
		{
			FMessage.OpenDialog(text);
		}
		BGW_LogUtil.LogError(text);
		return false;
		void MarkNodeHasError(UCalliopeNode Node, string InMessage, StringBuilder StringBuilder)
		{
			string text2 = $"节点{Node.GetFName()}导出错误: \r\n\t\t{InMessage}\r\n";
			Node.GetGraphIdentifierInCS(out var OutGraphIdentifier);
			if (OutGraphIdentifier != FName.None)
			{
				text2 = $"{OutGraphIdentifier}的{text2}";
			}
			StringBuilder.AppendLine(text2);
			Node.NodeHasError = true;
			bCanExport = false;
		}
	}

	protected virtual bool CorrectnessCheck(out string OutErrorMessage)
	{
		OutErrorMessage = "";
		foreach (FGsManagedSequenceID item in base.CalliopeParameters.SequenceIDCollection)
		{
			if (BGW_GameDB.GetMovieSequenceDesc(item.SequenceID) == null)
			{
				OutErrorMessage = "SequenceID不存在";
				return false;
			}
		}
		Dictionary<int, FUStTaskStageDesc> allTaskStageDesc = BGW_GameDB.GetAllTaskStageDesc();
		foreach (FGsManagedTaskStage item2 in base.CalliopeParameters.TaskStageCollection)
		{
			if (!allTaskStageDesc.ContainsKey(item2.TaskStage))
			{
				OutErrorMessage = $"不存在的任务阶段ID({item2.AliasName}: {item2.TaskStage})";
				return false;
			}
		}
		return true;
	}

	public virtual int GetActorGuidOptions_Implementation(string PropertyName, out List<FActorGuidOption> OutOptions)
	{
		OutOptions = new List<FActorGuidOption>();
		return OutOptions.Count;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetActorGuidOptions")]
	public unsafe int GetActorGuidOptions(string PropertyName, out List<FActorGuidOption> OutOptions)
	{
		CheckDestroyed();
		if (!GetActorGuidOptions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BED_CalliopeAssetBase:GetActorGuidOptions");
			OutOptions = null;
			return 0;
		}
		if (GetActorGuidOptions_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			GetActorGuidOptions_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "GetActorGuidOptions");
		}
		byte* value = stackalloc byte[(int)(uint)GetActorGuidOptions_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, GetActorGuidOptions_ParamsSize);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetActorGuidOptions_PropertyName_Offset), PropertyName);
		TArrayCopyMarshaler<FActorGuidOption> tArrayCopyMarshaler = new TArrayCopyMarshaler<FActorGuidOption>(1, GetActorGuidOptions_OutOptions_PropertyAddress, CachedMarshalingDelegates<FActorGuidOption, FActorGuidOption>.FromNative, CachedMarshalingDelegates<FActorGuidOption, FActorGuidOption>.ToNative);
		NativeReflection.InvokeFunction(base.Address, GetActorGuidOptions_InstanceFunctionAddressInstance, intPtr, GetActorGuidOptions_ParamsSize);
		int result = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetActorGuidOptions_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetActorGuidOptions_PropertyName_PropertyAddress.Address, intPtr);
		OutOptions = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuidOptions_OutOptions_Offset));
		NativeReflection.DestroyValue_InContainer(GetActorGuidOptions_OutOptions_PropertyAddress.Address, intPtr);
		return result;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetActorGuid")]
	public unsafe bool GetActorGuid(AActor InActor, out string OutActorGuid)
	{
		CheckDestroyed();
		if (!GetActorGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BED_CalliopeAssetBase:GetActorGuid");
			OutActorGuid = null;
			return false;
		}
		if (GetActorGuid_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			GetActorGuid_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "GetActorGuid");
		}
		byte* value = stackalloc byte[(int)(uint)GetActorGuid_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, GetActorGuid_ParamsSize);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorGuid_InActor_Offset), InActor);
		NativeReflection.InvokeFunction(base.Address, GetActorGuid_InstanceFunctionAddressInstance, intPtr, GetActorGuid_ParamsSize);
		bool result = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuid_ReturnValue_Offset), 0, GetActorGuid_ReturnValue_PropertyAddress.Address);
		OutActorGuid = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuid_OutActorGuid_Offset));
		NativeReflection.DestroyValue_InContainer(GetActorGuid_OutActorGuid_PropertyAddress.Address, intPtr);
		return result;
	}

	public virtual bool GetActorGuid_Implementation(AActor InActor, out string OutActorGuid)
	{
		OutActorGuid = BGU_DataUtil.GetActorGuid(InActor, bFindFromComponent: true);
		return !string.IsNullOrEmpty(OutActorGuid);
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:CanManageStates")]
	public unsafe bool CanManageStates()
	{
		CheckDestroyed();
		if (!CanManageStates_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BED_CalliopeAssetBase:CanManageStates");
			return false;
		}
		if (CanManageStates_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			CanManageStates_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "CanManageStates");
		}
		byte* value = stackalloc byte[(int)(uint)CanManageStates_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, CanManageStates_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, CanManageStates_InstanceFunctionAddressInstance, intPtr, CanManageStates_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanManageStates_ReturnValue_Offset), 0, CanManageStates_ReturnValue_PropertyAddress.Address);
	}

	public virtual bool CanManageStates_Implementation()
	{
		return false;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:PostStartInstance")]
	protected override void PostStartInstance_Implementation()
	{
		BGW_EventCollection.Get(this)?.Evt_StartCalliopeInstance(this);
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:PreFinishInstance")]
	protected override void PreFinishInstance_Implementation()
	{
		BGW_EventCollection.Get(this)?.Evt_FinishCalliopeInstance(this);
	}

	public bool GetParameter(EGsManagedParamType ParamType, string ParamValueString, int ParamValueInt, FName AliasName, out FCalliopeGuid OutGuid)
	{
		if (GetParameterConfigGuidByActorGuid(ParamType, ParamValueString, ParamValueInt, AliasName, out OutGuid))
		{
			return true;
		}
		return AddParameter(ParamType, "", ParamValueString, AliasName, ParamValueInt, out OutGuid);
	}

	public bool GetUnitParameter(string ActorGuid, out Guid OutGuid)
	{
		OutGuid = Guid.Empty;
		foreach (FGsManagedUnit item in base.CalliopeParameters.UnitCollection)
		{
			if (item.ActorGuid == ActorGuid)
			{
				OutGuid = item.ConfigGuid;
				return true;
			}
		}
		return false;
	}

	public bool GetActorParameter(string ActorGuid, out Guid OutGuid)
	{
		OutGuid = Guid.Empty;
		foreach (FGsManagedDynamicObstacle item in base.CalliopeParameters.DynamicObstacleCollection)
		{
			if (item.ActorGuid == ActorGuid)
			{
				OutGuid = item.ConfigGuid;
				return true;
			}
		}
		foreach (FGsManagedOverlap item2 in base.CalliopeParameters.OverlapCollection)
		{
			if (item2.ActorGuid == ActorGuid)
			{
				OutGuid = item2.ConfigGuid;
				return true;
			}
		}
		foreach (FGsManagedInteractor item3 in base.CalliopeParameters.InteractorCollection)
		{
			if (item3.ActorGuid == ActorGuid)
			{
				OutGuid = item3.ConfigGuid;
				return true;
			}
		}
		return false;
	}

	public string GetUnitGuidBySmartParam(FGsSmartParam Param)
	{
		if (Param.ConfigGuid == Guid.Empty)
		{
			return B1GlobalFNames.Player_Wukong.PlainName;
		}
		foreach (FGsManagedUnit item in base.CalliopeParameters.UnitCollection)
		{
			if (item.ConfigGuid == Param.ConfigGuid)
			{
				return item.ActorGuid;
			}
		}
		return "";
	}

	public int GetInteractorGroupIDBySmartParam(FGsSmartParam Param)
	{
		foreach (FGsManagedGroupID item in base.CalliopeParameters.GroupIDCollection)
		{
			if (item.ConfigGuid == Param.ConfigGuid)
			{
				return item.InteractorGroupID;
			}
		}
		return 0;
	}

	public int GetTaskStageIDBySmartParam(FGsSmartParam Param)
	{
		foreach (FGsManagedTaskStage item in base.CalliopeParameters.TaskStageCollection)
		{
			if (item.ConfigGuid == Param.ConfigGuid)
			{
				return item.TaskStage;
			}
		}
		return 0;
	}

	public string GetArchiveLabelBySmartParam(FGsSmartParam Param)
	{
		foreach (FGsManagedArchiveLabel item in base.CalliopeParameters.ArchiveLabelCollection)
		{
			if (item.ConfigGuid == Param.ConfigGuid)
			{
				FName archiveLabel = item.ArchiveLabel;
				return archiveLabel.ToString();
			}
		}
		return "";
	}

	public bool GetTeamIDBySmartParam(FGsSmartParam Param, out int TeamID)
	{
		TeamID = 99;
		if (Param.ConfigGuid == Guid.Empty)
		{
			return true;
		}
		foreach (FGsManagedTeamID item in base.CalliopeParameters.TeamIDCollection)
		{
			if (item.ConfigGuid == Param.ConfigGuid)
			{
				TeamID = item.TeamID;
				return true;
			}
		}
		TeamID = -1;
		return false;
	}

	public bool GetInteractGroupIDBySmartParam(FGsSmartParam Param, out int InteractGroupID)
	{
		InteractGroupID = 0;
		if (Param.ConfigGuid == Guid.Empty)
		{
			return true;
		}
		foreach (FGsManagedInteractGroupID item in base.CalliopeParameters.InteractGroupIDCollection)
		{
			if (item.ConfigGuid == Param.ConfigGuid)
			{
				InteractGroupID = item.InteractGroupID;
				return true;
			}
		}
		InteractGroupID = -1;
		return false;
	}

	public bool GetIdleAMIdxBySmartParam(FGsSmartParam Param, out int IdleAMIdx)
	{
		IdleAMIdx = 0;
		if (Param.ConfigGuid == Guid.Empty)
		{
			return true;
		}
		foreach (FGsManagedIdleAMIdx item in base.CalliopeParameters.IdleAMIdxCollection)
		{
			if (item.ConfigGuid == Param.ConfigGuid)
			{
				IdleAMIdx = item.IdleAMIdx;
				return true;
			}
		}
		IdleAMIdx = -1;
		return false;
	}

	public bool GetLeisureAnimIndexBySmartParam(FGsSmartParam Param, out int LeisureAnimIndex)
	{
		LeisureAnimIndex = 0;
		if (Param.ConfigGuid == Guid.Empty)
		{
			return true;
		}
		foreach (FGsManagedLeisureAnimIndex item in base.CalliopeParameters.LeisureAnimIndexCollection)
		{
			if (item.ConfigGuid == Param.ConfigGuid)
			{
				LeisureAnimIndex = item.LeisureAnimIndex;
				return true;
			}
		}
		LeisureAnimIndex = -1;
		return false;
	}

	public IList<ProcessCustom_Param> GetAssetParams()
	{
		List<ProcessCustom_Param> list = new List<ProcessCustom_Param>();
		foreach (FGsManagedDynamicObstacle item in base.CalliopeParameters.DynamicObstacleCollection)
		{
			ProcessCustom_Param processCustom_Param = new ProcessCustom_Param();
			processCustom_Param.ParamType = (int)item.ParamType;
			Guid configGuid = item.ConfigGuid;
			processCustom_Param.ParamGuid = configGuid.ToString();
			processCustom_Param.ParamString = item.ActorGuid;
			processCustom_Param.ParamInt = (int)item.State;
			FName aliasName = item.AliasName;
			processCustom_Param.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param);
		}
		foreach (FGsManagedOverlap item2 in base.CalliopeParameters.OverlapCollection)
		{
			ProcessCustom_Param processCustom_Param2 = new ProcessCustom_Param();
			processCustom_Param2.ParamType = (int)item2.ParamType;
			Guid configGuid = item2.ConfigGuid;
			processCustom_Param2.ParamGuid = configGuid.ToString();
			processCustom_Param2.ParamString = item2.ActorGuid;
			processCustom_Param2.ParamInt = (int)item2.State;
			FName aliasName = item2.AliasName;
			processCustom_Param2.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param2);
		}
		foreach (FGsManagedInteractor item3 in base.CalliopeParameters.InteractorCollection)
		{
			ProcessCustom_Param processCustom_Param3 = new ProcessCustom_Param();
			processCustom_Param3.ParamType = (int)item3.ParamType;
			Guid configGuid = item3.ConfigGuid;
			processCustom_Param3.ParamGuid = configGuid.ToString();
			processCustom_Param3.ParamString = item3.ActorGuid;
			processCustom_Param3.ParamLinkInt = item3.GroupID.ConfigGuid.ToString();
			FName aliasName = item3.AliasName;
			processCustom_Param3.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param3);
		}
		foreach (FGsManagedSpawner item4 in base.CalliopeParameters.SpawnerCollection)
		{
			ProcessCustom_Param processCustom_Param4 = new ProcessCustom_Param();
			processCustom_Param4.ParamType = (int)item4.ParamType;
			Guid configGuid = item4.ConfigGuid;
			processCustom_Param4.ParamGuid = configGuid.ToString();
			processCustom_Param4.ParamString = item4.ActorGuid;
			processCustom_Param4.ParamInt = (int)item4.State;
			FName aliasName = item4.AliasName;
			processCustom_Param4.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param4);
		}
		foreach (FGsManagedStreamingLevel item5 in base.CalliopeParameters.StreamingLevelCollection)
		{
			ProcessCustom_Param processCustom_Param5 = new ProcessCustom_Param();
			processCustom_Param5.ParamType = (int)item5.ParamType;
			Guid configGuid = item5.ConfigGuid;
			processCustom_Param5.ParamGuid = configGuid.ToString();
			processCustom_Param5.ParamString = $"{item5.PersistentLevelName}.{item5.StreamingLevelName}";
			processCustom_Param5.ParamInt = (int)item5.State;
			FName aliasName = item5.AliasName;
			processCustom_Param5.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param5);
		}
		foreach (FGsManagedUnit item6 in base.CalliopeParameters.UnitCollection)
		{
			ProcessCustom_Param processCustom_Param6 = new ProcessCustom_Param();
			processCustom_Param6.ParamType = (int)item6.ParamType;
			Guid configGuid = item6.ConfigGuid;
			processCustom_Param6.ParamGuid = configGuid.ToString();
			processCustom_Param6.ParamString = item6.ActorGuid;
			processCustom_Param6.ParamInt = (int)item6.State;
			FName aliasName = item6.AliasName;
			processCustom_Param6.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param6);
		}
		foreach (FGsManagedSequenceID item7 in base.CalliopeParameters.SequenceIDCollection)
		{
			ProcessCustom_Param processCustom_Param7 = new ProcessCustom_Param();
			processCustom_Param7.ParamType = (int)item7.ParamType;
			Guid configGuid = item7.ConfigGuid;
			processCustom_Param7.ParamGuid = configGuid.ToString();
			processCustom_Param7.ParamInt = item7.SequenceID;
			FName aliasName = item7.AliasName;
			processCustom_Param7.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param7);
		}
		foreach (FGsManagedTaskStage item8 in base.CalliopeParameters.TaskStageCollection)
		{
			ProcessCustom_Param processCustom_Param8 = new ProcessCustom_Param();
			processCustom_Param8.ParamType = (int)item8.ParamType;
			Guid configGuid = item8.ConfigGuid;
			processCustom_Param8.ParamGuid = configGuid.ToString();
			processCustom_Param8.ParamInt = item8.TaskStage;
			FName aliasName = item8.AliasName;
			processCustom_Param8.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param8);
		}
		foreach (FGsManagedTaskLine item9 in base.CalliopeParameters.TaskLineCollection)
		{
			ProcessCustom_Param processCustom_Param9 = new ProcessCustom_Param();
			processCustom_Param9.ParamType = (int)item9.ParamType;
			Guid configGuid = item9.ConfigGuid;
			processCustom_Param9.ParamGuid = configGuid.ToString();
			processCustom_Param9.ParamInt = item9.TaskLineID;
			FName aliasName = item9.AliasName;
			processCustom_Param9.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param9);
		}
		foreach (FGsManagedBuffID item10 in base.CalliopeParameters.BuffIDCollection)
		{
			ProcessCustom_Param processCustom_Param10 = new ProcessCustom_Param();
			processCustom_Param10.ParamType = (int)item10.ParamType;
			Guid configGuid = item10.ConfigGuid;
			processCustom_Param10.ParamGuid = configGuid.ToString();
			processCustom_Param10.ParamInt = item10.BuffID;
			FName aliasName = item10.AliasName;
			processCustom_Param10.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param10);
		}
		foreach (FGsManagedArchiveLabel item11 in base.CalliopeParameters.ArchiveLabelCollection)
		{
			ProcessCustom_Param processCustom_Param11 = new ProcessCustom_Param();
			processCustom_Param11.ParamType = (int)item11.ParamType;
			Guid configGuid = item11.ConfigGuid;
			processCustom_Param11.ParamGuid = configGuid.ToString();
			FName aliasName = item11.ArchiveLabel;
			processCustom_Param11.ParamString = aliasName.PlainName;
			aliasName = item11.AliasName;
			processCustom_Param11.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param11);
		}
		foreach (FGsManagedNPCUnit item12 in base.CalliopeParameters.NPCUnitCollection)
		{
			ProcessCustom_Param processCustom_Param12 = new ProcessCustom_Param();
			processCustom_Param12.ParamType = (int)item12.ParamType;
			Guid configGuid = item12.ConfigGuid;
			processCustom_Param12.ParamGuid = configGuid.ToString();
			processCustom_Param12.ParamString = item12.ActorGuid;
			FName aliasName = item12.AliasName;
			processCustom_Param12.ParamAliasName = aliasName.PlainName;
			foreach (FGsNPCReferenceInfo item13 in item12.NPCInstanceGroup)
			{
				RepeatedField<ProcessCustom_SubParam> paramSubList = processCustom_Param12.ParamSubList;
				ProcessCustom_SubParam processCustom_SubParam = new ProcessCustom_SubParam();
				configGuid = item13.ConfigGuid;
				processCustom_SubParam.ParamGuid = configGuid.ToString();
				processCustom_SubParam.ParamString = item13.ActorGuid;
				aliasName = item13.AliasName;
				processCustom_SubParam.ParamAliasName = aliasName.PlainName;
				paramSubList.Add(processCustom_SubParam);
			}
			list.Add(processCustom_Param12);
		}
		foreach (FGsManagedGroupID item14 in base.CalliopeParameters.GroupIDCollection)
		{
			ProcessCustom_Param processCustom_Param13 = new ProcessCustom_Param();
			processCustom_Param13.ParamType = (int)item14.ParamType;
			Guid configGuid = item14.ConfigGuid;
			processCustom_Param13.ParamGuid = configGuid.ToString();
			processCustom_Param13.ParamInt = item14.InteractorGroupID;
			FName aliasName = item14.AliasName;
			processCustom_Param13.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param13);
		}
		foreach (FGsManagedAiConversationID item15 in base.CalliopeParameters.AiConversationIDCollection)
		{
			ProcessCustom_Param processCustom_Param14 = new ProcessCustom_Param();
			processCustom_Param14.ParamType = (int)item15.ParamType;
			Guid configGuid = item15.ConfigGuid;
			processCustom_Param14.ParamGuid = configGuid.ToString();
			processCustom_Param14.ParamString = string.Join(",", item15.AiConversationIDList);
			FName aliasName = item15.AliasName;
			processCustom_Param14.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param14);
		}
		foreach (FGsManagedAssociationUnitConfigID item16 in base.CalliopeParameters.AssociationUnitConfigIDCollection)
		{
			ProcessCustom_Param processCustom_Param15 = new ProcessCustom_Param();
			processCustom_Param15.ParamType = (int)item16.ParamType;
			Guid configGuid = item16.ConfigGuid;
			processCustom_Param15.ParamGuid = configGuid.ToString();
			processCustom_Param15.ParamInt = item16.ConfigID;
			FName aliasName = item16.AliasName;
			processCustom_Param15.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param15);
		}
		foreach (FGsManagedAssociationOnFightSkillID item17 in base.CalliopeParameters.AssociationOnFightSkillIDCollection)
		{
			ProcessCustom_Param processCustom_Param16 = new ProcessCustom_Param();
			processCustom_Param16.ParamType = (int)item17.ParamType;
			Guid configGuid = item17.ConfigGuid;
			processCustom_Param16.ParamGuid = configGuid.ToString();
			processCustom_Param16.ParamInt = item17.OnFightSkillID;
			FName aliasName = item17.AliasName;
			processCustom_Param16.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param16);
		}
		foreach (FGsManagedFollowPartnerConfigID item18 in base.CalliopeParameters.FollowPartnerConfigIDCollection)
		{
			ProcessCustom_Param processCustom_Param17 = new ProcessCustom_Param();
			processCustom_Param17.ParamType = (int)item18.ParamType;
			Guid configGuid = item18.ConfigGuid;
			processCustom_Param17.ParamGuid = configGuid.ToString();
			processCustom_Param17.ParamInt = item18.ConfigID;
			FName aliasName = item18.AliasName;
			processCustom_Param17.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param17);
		}
		foreach (FGsManagedTeamID item19 in base.CalliopeParameters.TeamIDCollection)
		{
			ProcessCustom_Param processCustom_Param18 = new ProcessCustom_Param();
			processCustom_Param18.ParamType = (int)item19.ParamType;
			Guid configGuid = item19.ConfigGuid;
			processCustom_Param18.ParamGuid = configGuid.ToString();
			processCustom_Param18.ParamInt = item19.TeamID;
			FName aliasName = item19.AliasName;
			processCustom_Param18.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param18);
		}
		foreach (FGsManagedIdleAMIdx item20 in base.CalliopeParameters.IdleAMIdxCollection)
		{
			ProcessCustom_Param processCustom_Param19 = new ProcessCustom_Param();
			processCustom_Param19.ParamType = (int)item20.ParamType;
			Guid configGuid = item20.ConfigGuid;
			processCustom_Param19.ParamGuid = configGuid.ToString();
			processCustom_Param19.ParamInt = item20.IdleAMIdx;
			FName aliasName = item20.AliasName;
			processCustom_Param19.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param19);
		}
		foreach (FGsManagedLeisureAnimIndex item21 in base.CalliopeParameters.LeisureAnimIndexCollection)
		{
			ProcessCustom_Param processCustom_Param20 = new ProcessCustom_Param();
			processCustom_Param20.ParamType = (int)item21.ParamType;
			Guid configGuid = item21.ConfigGuid;
			processCustom_Param20.ParamGuid = configGuid.ToString();
			processCustom_Param20.ParamInt = item21.LeisureAnimIndex;
			FName aliasName = item21.AliasName;
			processCustom_Param20.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param20);
		}
		foreach (FGsManagedInteractGroupID item22 in base.CalliopeParameters.InteractGroupIDCollection)
		{
			ProcessCustom_Param processCustom_Param21 = new ProcessCustom_Param();
			processCustom_Param21.ParamType = (int)item22.ParamType;
			Guid configGuid = item22.ConfigGuid;
			processCustom_Param21.ParamGuid = configGuid.ToString();
			processCustom_Param21.ParamInt = item22.InteractGroupID;
			FName aliasName = item22.AliasName;
			processCustom_Param21.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param21);
		}
		foreach (FGsManagedStreamingLevelStateConfig item23 in base.CalliopeParameters.StreamingLevelStateConfigCollection)
		{
			ProcessCustom_Param processCustom_Param22 = new ProcessCustom_Param();
			processCustom_Param22.ParamType = (int)item23.ParamType;
			Guid configGuid = item23.ConfigGuid;
			processCustom_Param22.ParamGuid = configGuid.ToString();
			processCustom_Param22.ParamInt = item23.LevelID;
			FName aliasName = item23.AliasName;
			processCustom_Param22.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param22);
		}
		foreach (FGsManagedGroupUnit item24 in base.CalliopeParameters.GroupUnitCollection)
		{
			ProcessCustom_Param processCustom_Param23 = new ProcessCustom_Param();
			processCustom_Param23.ParamType = (int)item24.ParamType;
			Guid configGuid = item24.ConfigGuid;
			processCustom_Param23.ParamGuid = configGuid.ToString();
			processCustom_Param23.ParamString = item24.GroupTag.TagName.PlainName;
			processCustom_Param23.ParamInt = (int)item24.State;
			FName aliasName = item24.AliasName;
			processCustom_Param23.ParamAliasName = aliasName.PlainName;
			list.Add(processCustom_Param23);
		}
		return list;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetViewType")]
	protected override ECalliopeViewType GetViewType_Implementation()
	{
		return ECalliopeViewType.None;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetRerouteNodeClass")]
	protected override TSubclassOf<UObject> GetRerouteNodeClass_Implementation()
	{
		return TSubclassOf<UObject>.Null;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetStartNodeClass")]
	protected override TSubclassOf<UObject> GetStartNodeClass_Implementation()
	{
		return TSubclassOf<UObject>.Null;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetExtraDefaultInputNodes")]
	protected override int GetExtraDefaultInputNodes_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetExtraDefaultOutputNodes")]
	protected override int GetExtraDefaultOutputNodes_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetRerouteNodeClassInBranchGraph")]
	protected override TSubclassOf<UObject> GetRerouteNodeClassInBranchGraph_Implementation()
	{
		return TSubclassOf<UObject>.Null;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetStartNodeClassInBranchGraph")]
	protected override TSubclassOf<UObject> GetStartNodeClassInBranchGraph_Implementation()
	{
		return TSubclassOf<UObject>.Null;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetExtraDefaultInputNodesInBranchGraph")]
	protected override int GetExtraDefaultInputNodesInBranchGraph_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BED_CalliopeAssetBase:GetExtraDefaultOutputNodesInBranchGraph")]
	protected override int GetExtraDefaultOutputNodesInBranchGraph_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetActorGuid")]
	private static void GetActorGuid__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		AActor inActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GetActorGuid_InActor_Offset));
		string OutActorGuid;
		bool actorGuid_Implementation = bED_CalliopeAssetBase.GetActorGuid_Implementation(inActor, out OutActorGuid);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuid_ReturnValue_Offset), 0, GetActorGuid_ReturnValue_PropertyAddress.Address, actorGuid_Implementation);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuid_OutActorGuid_Offset), OutActorGuid);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:CanManageStates")]
	private static void CanManageStates__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		bool value = bED_CalliopeAssetBase.CanManageStates_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CanManageStates_ReturnValue_Offset), 0, CanManageStates_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetSubGraphNodes")]
	private static void GetSubGraphNodes__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		TArrayCopyMarshaler<BED_QuestNode_SubGraph> tArrayCopyMarshaler = new TArrayCopyMarshaler<BED_QuestNode_SubGraph>(1, GetSubGraphNodes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<BED_QuestNode_SubGraph, UObjectMarshaler<BED_QuestNode_SubGraph>>.FromNative, CachedMarshalingDelegates<BED_QuestNode_SubGraph, UObjectMarshaler<BED_QuestNode_SubGraph>>.ToNative);
		List<BED_QuestNode_SubGraph> subGraphNodes = bED_CalliopeAssetBase.GetSubGraphNodes();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSubGraphNodes_ReturnValue_Offset), subGraphNodes);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:ExportDataByExtern")]
	private static void ExportDataByExtern__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		bool value = bED_CalliopeAssetBase.ExportDataByExtern();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ExportDataByExtern_ReturnValue_Offset), 0, ExportDataByExtern_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetActorGuidOptions")]
	private static void GetActorGuidOptions__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GetActorGuidOptions_PropertyName_Offset));
		TArrayCopyMarshaler<FActorGuidOption> tArrayCopyMarshaler = new TArrayCopyMarshaler<FActorGuidOption>(1, GetActorGuidOptions_OutOptions_PropertyAddress, CachedMarshalingDelegates<FActorGuidOption, FActorGuidOption>.FromNative, CachedMarshalingDelegates<FActorGuidOption, FActorGuidOption>.ToNative);
		List<FActorGuidOption> OutOptions = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetActorGuidOptions_OutOptions_Offset));
		int actorGuidOptions_Implementation = bED_CalliopeAssetBase.GetActorGuidOptions_Implementation(propertyName, out OutOptions);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetActorGuidOptions_ReturnValue_Offset), actorGuidOptions_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetActorGuidOptions_OutOptions_Offset), OutOptions);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetObserveActorNodes")]
	private static void GetObserveActorNodes__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		TArrayCopyMarshaler<BED_QuestNode_ObserveByCondition> tArrayCopyMarshaler = new TArrayCopyMarshaler<BED_QuestNode_ObserveByCondition>(1, GetObserveActorNodes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<BED_QuestNode_ObserveByCondition, UObjectMarshaler<BED_QuestNode_ObserveByCondition>>.FromNative, CachedMarshalingDelegates<BED_QuestNode_ObserveByCondition, UObjectMarshaler<BED_QuestNode_ObserveByCondition>>.ToNative);
		List<BED_QuestNode_ObserveByCondition> observeActorNodes = bED_CalliopeAssetBase.GetObserveActorNodes();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetObserveActorNodes_ReturnValue_Offset), observeActorNodes);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetNode")]
	private static void GetNode__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		FCalliopeGuid inGuid = FCalliopeGuid.FromNative(IntPtr.Add(buffer, GetNode_InGuid_Offset));
		UCalliopeNode node_Implementation = bED_CalliopeAssetBase.GetNode_Implementation(inGuid);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(buffer, GetNode_ReturnValue_Offset), node_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetNodes")]
	private static void GetNodes__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		TMapCopyMarshaler<FCalliopeGuid, UCalliopeNode> tMapCopyMarshaler = new TMapCopyMarshaler<FCalliopeGuid, UCalliopeNode>(1, GetNodes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.FromNative, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.ToNative, CachedMarshalingDelegates<UCalliopeNode, UObjectMarshaler<UCalliopeNode>>.FromNative, CachedMarshalingDelegates<UCalliopeNode, UObjectMarshaler<UCalliopeNode>>.ToNative);
		IDictionary<FCalliopeGuid, UCalliopeNode> nodes_Implementation = bED_CalliopeAssetBase.GetNodes_Implementation();
		tMapCopyMarshaler.ToNative(IntPtr.Add(buffer, GetNodes_ReturnValue_Offset), nodes_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetViewType")]
	private static void GetViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		ECalliopeViewType viewType_Implementation = bED_CalliopeAssetBase.GetViewType_Implementation();
		EnumMarshaler<ECalliopeViewType>.ToNative(IntPtr.Add(buffer, GetViewType_ReturnValue_Offset), 0, GetViewType_ReturnValue_PropertyAddress.Address, viewType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:ExportToData")]
	private static void ExportToData__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		bool value = bED_CalliopeAssetBase.ExportToData_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ExportToData_ReturnValue_Offset), 0, ExportToData_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:RegisterNode")]
	private static void RegisterNode__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		FCalliopeGuid newGuid = FCalliopeGuid.FromNative(IntPtr.Add(buffer, RegisterNode_NewGuid_Offset));
		UCalliopeNode newNode = UObjectMarshaler<UCalliopeNode>.FromNative(IntPtr.Add(buffer, RegisterNode_NewNode_Offset));
		bED_CalliopeAssetBase.RegisterNode_Implementation(newGuid, newNode);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:OnNodeActivate")]
	private static void OnNodeActivate__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		UCalliopeNode node = UObjectMarshaler<UCalliopeNode>.FromNative(IntPtr.Add(buffer, OnNodeActivate_Node_Offset));
		bED_CalliopeAssetBase.OnNodeActivate_Implementation(node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:UnregisterNode")]
	private static void UnregisterNode__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		FCalliopeGuid nodeGuid = FCalliopeGuid.FromNative(IntPtr.Add(buffer, UnregisterNode_NodeGuid_Offset));
		bED_CalliopeAssetBase.UnregisterNode_Implementation(nodeGuid);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetCustomInputs")]
	private static void GetCustomInputs__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetCustomInputs_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> customInputs_Implementation = bED_CalliopeAssetBase.GetCustomInputs_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetCustomInputs_ReturnValue_Offset), customInputs_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:OnNodeDeactivate")]
	private static void OnNodeDeactivate__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		UCalliopeNode node = UObjectMarshaler<UCalliopeNode>.FromNative(IntPtr.Add(buffer, OnNodeDeactivate_Node_Offset));
		bED_CalliopeAssetBase.OnNodeDeactivate_Implementation(node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetCustomOutputs")]
	private static void GetCustomOutputs__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetCustomOutputs_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> customOutputs_Implementation = bED_CalliopeAssetBase.GetCustomOutputs_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetCustomOutputs_ReturnValue_Offset), customOutputs_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetStartNodeClass")]
	private static void GetStartNodeClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		TSubclassOf<UObject> startNodeClass_Implementation = bED_CalliopeAssetBase.GetStartNodeClass_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetStartNodeClass_ReturnValue_Offset), startNodeClass_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:PreFinishInstance")]
	private static void PreFinishInstance__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		bED_CalliopeAssetBase.PreFinishInstance_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:PostStartInstance")]
	private static void PostStartInstance__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		bED_CalliopeAssetBase.PostStartInstance_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:OnPropertyChanged")]
	private static void OnPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_PropertyName_Offset));
		bED_CalliopeAssetBase.OnPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:PostDuplicateInCS")]
	private static void PostDuplicateInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		bool bDuplicateForPIE = BoolMarshaler.FromNative(IntPtr.Add(buffer, PostDuplicateInCS_bDuplicateForPIE_Offset), 0, PostDuplicateInCS_bDuplicateForPIE_PropertyAddress.Address);
		bED_CalliopeAssetBase.PostDuplicateInCS_Implementation(bDuplicateForPIE);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetRerouteNodeClass")]
	private static void GetRerouteNodeClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		TSubclassOf<UObject> rerouteNodeClass_Implementation = bED_CalliopeAssetBase.GetRerouteNodeClass_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetRerouteNodeClass_ReturnValue_Offset), rerouteNodeClass_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetExtraDefaultInputNodes")]
	private static void GetExtraDefaultInputNodes__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultInputNodes_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_OutClasses_Offset));
		int extraDefaultInputNodes_Implementation = bED_CalliopeAssetBase.GetExtraDefaultInputNodes_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_ReturnValue_Offset), extraDefaultInputNodes_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetExtraDefaultOutputNodes")]
	private static void GetExtraDefaultOutputNodes__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultOutputNodes_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_OutClasses_Offset));
		int extraDefaultOutputNodes_Implementation = bED_CalliopeAssetBase.GetExtraDefaultOutputNodes_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_ReturnValue_Offset), extraDefaultOutputNodes_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetStartNodeClassInBranchGraph")]
	private static void GetStartNodeClassInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		TSubclassOf<UObject> startNodeClassInBranchGraph_Implementation = bED_CalliopeAssetBase.GetStartNodeClassInBranchGraph_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetStartNodeClassInBranchGraph_ReturnValue_Offset), startNodeClassInBranchGraph_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetRerouteNodeClassInBranchGraph")]
	private static void GetRerouteNodeClassInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		TSubclassOf<UObject> rerouteNodeClassInBranchGraph_Implementation = bED_CalliopeAssetBase.GetRerouteNodeClassInBranchGraph_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetRerouteNodeClassInBranchGraph_ReturnValue_Offset), rerouteNodeClassInBranchGraph_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetExtraDefaultInputNodesInBranchGraph")]
	private static void GetExtraDefaultInputNodesInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset));
		int extraDefaultInputNodesInBranchGraph_Implementation = bED_CalliopeAssetBase.GetExtraDefaultInputNodesInBranchGraph_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodesInBranchGraph_ReturnValue_Offset), extraDefaultInputNodesInBranchGraph_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_CalliopeAssetBase:GetExtraDefaultOutputNodesInBranchGraph")]
	private static void GetExtraDefaultOutputNodesInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_CalliopeAssetBase bED_CalliopeAssetBase = GCHelper.Find<BED_CalliopeAssetBase>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset));
		int extraDefaultOutputNodesInBranchGraph_Implementation = bED_CalliopeAssetBase.GetExtraDefaultOutputNodesInBranchGraph_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_Offset), extraDefaultOutputNodesInBranchGraph_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset), OutClasses);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BED_CalliopeAssetBase");
		GetActorGuid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetActorGuid");
		GetActorGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuid_FunctionAddress);
		GetActorGuid_InActor_Offset = NativeReflection.GetPropertyOffset(GetActorGuid_FunctionAddress, "InActor");
		GetActorGuid_InActor_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuid_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GetActorGuid_OutActorGuid_PropertyAddress, GetActorGuid_FunctionAddress, "OutActorGuid");
		GetActorGuid_OutActorGuid_Offset = NativeReflection.GetPropertyOffset(GetActorGuid_FunctionAddress, "OutActorGuid");
		GetActorGuid_OutActorGuid_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuid_FunctionAddress, "OutActorGuid", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetActorGuid_ReturnValue_PropertyAddress, GetActorGuid_FunctionAddress, "ReturnValue");
		GetActorGuid_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetActorGuid_FunctionAddress, "ReturnValue");
		GetActorGuid_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorGuid_IsValid = GetActorGuid_FunctionAddress != IntPtr.Zero && GetActorGuid_InActor_IsValid && GetActorGuid_OutActorGuid_IsValid && GetActorGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetActorGuid", GetActorGuid_IsValid);
		CanManageStates_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanManageStates");
		CanManageStates_ParamsSize = NativeReflection.GetFunctionParamsSize(CanManageStates_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CanManageStates_ReturnValue_PropertyAddress, CanManageStates_FunctionAddress, "ReturnValue");
		CanManageStates_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CanManageStates_FunctionAddress, "ReturnValue");
		CanManageStates_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CanManageStates_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanManageStates_IsValid = CanManageStates_FunctionAddress != IntPtr.Zero && CanManageStates_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:CanManageStates", CanManageStates_IsValid);
		GetSubGraphNodes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSubGraphNodes");
		GetSubGraphNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSubGraphNodes_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSubGraphNodes_ReturnValue_PropertyAddress, GetSubGraphNodes_FunctionAddress, "ReturnValue");
		GetSubGraphNodes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSubGraphNodes_FunctionAddress, "ReturnValue");
		GetSubGraphNodes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSubGraphNodes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSubGraphNodes_IsValid = GetSubGraphNodes_FunctionAddress != IntPtr.Zero && GetSubGraphNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetSubGraphNodes", GetSubGraphNodes_IsValid);
		ExportDataByExtern_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExportDataByExtern");
		ExportDataByExtern_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportDataByExtern_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ExportDataByExtern_ReturnValue_PropertyAddress, ExportDataByExtern_FunctionAddress, "ReturnValue");
		ExportDataByExtern_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ExportDataByExtern_FunctionAddress, "ReturnValue");
		ExportDataByExtern_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ExportDataByExtern_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExportDataByExtern_IsValid = ExportDataByExtern_FunctionAddress != IntPtr.Zero && ExportDataByExtern_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:ExportDataByExtern", ExportDataByExtern_IsValid);
		GetActorGuidOptions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetActorGuidOptions");
		GetActorGuidOptions_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuidOptions_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetActorGuidOptions_PropertyName_PropertyAddress, GetActorGuidOptions_FunctionAddress, "PropertyName");
		GetActorGuidOptions_PropertyName_Offset = NativeReflection.GetPropertyOffset(GetActorGuidOptions_FunctionAddress, "PropertyName");
		GetActorGuidOptions_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidOptions_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetActorGuidOptions_OutOptions_PropertyAddress, GetActorGuidOptions_FunctionAddress, "OutOptions");
		GetActorGuidOptions_OutOptions_Offset = NativeReflection.GetPropertyOffset(GetActorGuidOptions_FunctionAddress, "OutOptions");
		GetActorGuidOptions_OutOptions_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidOptions_FunctionAddress, "OutOptions", Classes.FArrayProperty);
		GetActorGuidOptions_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetActorGuidOptions_FunctionAddress, "ReturnValue");
		GetActorGuidOptions_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetActorGuidOptions_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetActorGuidOptions_IsValid = GetActorGuidOptions_FunctionAddress != IntPtr.Zero && GetActorGuidOptions_PropertyName_IsValid && GetActorGuidOptions_OutOptions_IsValid && GetActorGuidOptions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetActorGuidOptions", GetActorGuidOptions_IsValid);
		GetObserveActorNodes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetObserveActorNodes");
		GetObserveActorNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObserveActorNodes_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetObserveActorNodes_ReturnValue_PropertyAddress, GetObserveActorNodes_FunctionAddress, "ReturnValue");
		GetObserveActorNodes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetObserveActorNodes_FunctionAddress, "ReturnValue");
		GetObserveActorNodes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetObserveActorNodes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetObserveActorNodes_IsValid = GetObserveActorNodes_FunctionAddress != IntPtr.Zero && GetObserveActorNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetObserveActorNodes", GetObserveActorNodes_IsValid);
		GetNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNode");
		GetNode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNode_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNode_InGuid_PropertyAddress, GetNode_FunctionAddress, "InGuid");
		GetNode_InGuid_Offset = NativeReflection.GetPropertyOffset(GetNode_FunctionAddress, "InGuid");
		GetNode_InGuid_IsValid = NativeReflection.ValidatePropertyClass(GetNode_FunctionAddress, "InGuid", Classes.FStructProperty);
		GetNode_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNode_FunctionAddress, "ReturnValue");
		GetNode_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetNode_IsValid = GetNode_FunctionAddress != IntPtr.Zero && GetNode_InGuid_IsValid && GetNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetNode", GetNode_IsValid);
		GetNodes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodes");
		GetNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodes_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodes_ReturnValue_PropertyAddress, GetNodes_FunctionAddress, "ReturnValue");
		GetNodes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodes_FunctionAddress, "ReturnValue");
		GetNodes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodes_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetNodes_IsValid = GetNodes_FunctionAddress != IntPtr.Zero && GetNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetNodes", GetNodes_IsValid);
		GetViewType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetViewType");
		GetViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetViewType_ReturnValue_PropertyAddress, GetViewType_FunctionAddress, "ReturnValue");
		GetViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetViewType_FunctionAddress, "ReturnValue");
		GetViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetViewType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetViewType_IsValid = GetViewType_FunctionAddress != IntPtr.Zero && GetViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetViewType", GetViewType_IsValid);
		ExportToData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExportToData");
		ExportToData_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportToData_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ExportToData_ReturnValue_PropertyAddress, ExportToData_FunctionAddress, "ReturnValue");
		ExportToData_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ExportToData_FunctionAddress, "ReturnValue");
		ExportToData_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ExportToData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExportToData_IsValid = ExportToData_FunctionAddress != IntPtr.Zero && ExportToData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:ExportToData", ExportToData_IsValid);
		RegisterNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RegisterNode");
		RegisterNode_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterNode_FunctionAddress);
		NativeReflection.GetPropertyRef(ref RegisterNode_NewGuid_PropertyAddress, RegisterNode_FunctionAddress, "NewGuid");
		RegisterNode_NewGuid_Offset = NativeReflection.GetPropertyOffset(RegisterNode_FunctionAddress, "NewGuid");
		RegisterNode_NewGuid_IsValid = NativeReflection.ValidatePropertyClass(RegisterNode_FunctionAddress, "NewGuid", Classes.FStructProperty);
		RegisterNode_NewNode_Offset = NativeReflection.GetPropertyOffset(RegisterNode_FunctionAddress, "NewNode");
		RegisterNode_NewNode_IsValid = NativeReflection.ValidatePropertyClass(RegisterNode_FunctionAddress, "NewNode", Classes.FObjectProperty);
		RegisterNode_IsValid = RegisterNode_FunctionAddress != IntPtr.Zero && RegisterNode_NewGuid_IsValid && RegisterNode_NewNode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:RegisterNode", RegisterNode_IsValid);
		OnNodeActivate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnNodeActivate");
		OnNodeActivate_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNodeActivate_FunctionAddress);
		OnNodeActivate_Node_Offset = NativeReflection.GetPropertyOffset(OnNodeActivate_FunctionAddress, "Node");
		OnNodeActivate_Node_IsValid = NativeReflection.ValidatePropertyClass(OnNodeActivate_FunctionAddress, "Node", Classes.FObjectProperty);
		OnNodeActivate_IsValid = OnNodeActivate_FunctionAddress != IntPtr.Zero && OnNodeActivate_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:OnNodeActivate", OnNodeActivate_IsValid);
		UnregisterNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UnregisterNode");
		UnregisterNode_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterNode_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UnregisterNode_NodeGuid_PropertyAddress, UnregisterNode_FunctionAddress, "NodeGuid");
		UnregisterNode_NodeGuid_Offset = NativeReflection.GetPropertyOffset(UnregisterNode_FunctionAddress, "NodeGuid");
		UnregisterNode_NodeGuid_IsValid = NativeReflection.ValidatePropertyClass(UnregisterNode_FunctionAddress, "NodeGuid", Classes.FStructProperty);
		UnregisterNode_IsValid = UnregisterNode_FunctionAddress != IntPtr.Zero && UnregisterNode_NodeGuid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:UnregisterNode", UnregisterNode_IsValid);
		GetCustomInputs_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomInputs");
		GetCustomInputs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomInputs_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetCustomInputs_ReturnValue_PropertyAddress, GetCustomInputs_FunctionAddress, "ReturnValue");
		GetCustomInputs_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetCustomInputs_FunctionAddress, "ReturnValue");
		GetCustomInputs_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetCustomInputs_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCustomInputs_IsValid = GetCustomInputs_FunctionAddress != IntPtr.Zero && GetCustomInputs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetCustomInputs", GetCustomInputs_IsValid);
		OnNodeDeactivate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnNodeDeactivate");
		OnNodeDeactivate_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNodeDeactivate_FunctionAddress);
		OnNodeDeactivate_Node_Offset = NativeReflection.GetPropertyOffset(OnNodeDeactivate_FunctionAddress, "Node");
		OnNodeDeactivate_Node_IsValid = NativeReflection.ValidatePropertyClass(OnNodeDeactivate_FunctionAddress, "Node", Classes.FObjectProperty);
		OnNodeDeactivate_IsValid = OnNodeDeactivate_FunctionAddress != IntPtr.Zero && OnNodeDeactivate_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:OnNodeDeactivate", OnNodeDeactivate_IsValid);
		GetCustomOutputs_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomOutputs");
		GetCustomOutputs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomOutputs_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetCustomOutputs_ReturnValue_PropertyAddress, GetCustomOutputs_FunctionAddress, "ReturnValue");
		GetCustomOutputs_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetCustomOutputs_FunctionAddress, "ReturnValue");
		GetCustomOutputs_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetCustomOutputs_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCustomOutputs_IsValid = GetCustomOutputs_FunctionAddress != IntPtr.Zero && GetCustomOutputs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetCustomOutputs", GetCustomOutputs_IsValid);
		GetStartNodeClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetStartNodeClass");
		GetStartNodeClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartNodeClass_FunctionAddress);
		GetStartNodeClass_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetStartNodeClass_FunctionAddress, "ReturnValue");
		GetStartNodeClass_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetStartNodeClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetStartNodeClass_IsValid = GetStartNodeClass_FunctionAddress != IntPtr.Zero && GetStartNodeClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetStartNodeClass", GetStartNodeClass_IsValid);
		PreFinishInstance_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PreFinishInstance");
		PreFinishInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(PreFinishInstance_FunctionAddress);
		PreFinishInstance_IsValid = PreFinishInstance_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:PreFinishInstance", PreFinishInstance_IsValid);
		PostStartInstance_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostStartInstance");
		PostStartInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(PostStartInstance_FunctionAddress);
		PostStartInstance_IsValid = PostStartInstance_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:PostStartInstance", PostStartInstance_IsValid);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:OnPropertyChanged", OnPropertyChanged_IsValid);
		PostDuplicateInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostDuplicateInCS");
		PostDuplicateInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostDuplicateInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PostDuplicateInCS_bDuplicateForPIE_PropertyAddress, PostDuplicateInCS_FunctionAddress, "bDuplicateForPIE");
		PostDuplicateInCS_bDuplicateForPIE_Offset = NativeReflection.GetPropertyOffset(PostDuplicateInCS_FunctionAddress, "bDuplicateForPIE");
		PostDuplicateInCS_bDuplicateForPIE_IsValid = NativeReflection.ValidatePropertyClass(PostDuplicateInCS_FunctionAddress, "bDuplicateForPIE", Classes.FBoolProperty);
		PostDuplicateInCS_IsValid = PostDuplicateInCS_FunctionAddress != IntPtr.Zero && PostDuplicateInCS_bDuplicateForPIE_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:PostDuplicateInCS", PostDuplicateInCS_IsValid);
		GetRerouteNodeClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRerouteNodeClass");
		GetRerouteNodeClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRerouteNodeClass_FunctionAddress);
		GetRerouteNodeClass_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetRerouteNodeClass_FunctionAddress, "ReturnValue");
		GetRerouteNodeClass_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetRerouteNodeClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetRerouteNodeClass_IsValid = GetRerouteNodeClass_FunctionAddress != IntPtr.Zero && GetRerouteNodeClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetRerouteNodeClass", GetRerouteNodeClass_IsValid);
		GetExtraDefaultInputNodes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetExtraDefaultInputNodes");
		GetExtraDefaultInputNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultInputNodes_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultInputNodes_OutClasses_PropertyAddress, GetExtraDefaultInputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodes_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodes_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodes_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultInputNodes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodes_FunctionAddress, "ReturnValue");
		GetExtraDefaultInputNodes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodes_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultInputNodes_IsValid = GetExtraDefaultInputNodes_FunctionAddress != IntPtr.Zero && GetExtraDefaultInputNodes_OutClasses_IsValid && GetExtraDefaultInputNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetExtraDefaultInputNodes", GetExtraDefaultInputNodes_IsValid);
		GetExtraDefaultOutputNodes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetExtraDefaultOutputNodes");
		GetExtraDefaultOutputNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultOutputNodes_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultOutputNodes_OutClasses_PropertyAddress, GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodes_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodes_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultOutputNodes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodes_FunctionAddress, "ReturnValue");
		GetExtraDefaultOutputNodes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodes_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultOutputNodes_IsValid = GetExtraDefaultOutputNodes_FunctionAddress != IntPtr.Zero && GetExtraDefaultOutputNodes_OutClasses_IsValid && GetExtraDefaultOutputNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetExtraDefaultOutputNodes", GetExtraDefaultOutputNodes_IsValid);
		GetStartNodeClassInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetStartNodeClassInBranchGraph");
		GetStartNodeClassInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartNodeClassInBranchGraph_FunctionAddress);
		GetStartNodeClassInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetStartNodeClassInBranchGraph_FunctionAddress, "ReturnValue");
		GetStartNodeClassInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetStartNodeClassInBranchGraph_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetStartNodeClassInBranchGraph_IsValid = GetStartNodeClassInBranchGraph_FunctionAddress != IntPtr.Zero && GetStartNodeClassInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetStartNodeClassInBranchGraph", GetStartNodeClassInBranchGraph_IsValid);
		GetRerouteNodeClassInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRerouteNodeClassInBranchGraph");
		GetRerouteNodeClassInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRerouteNodeClassInBranchGraph_FunctionAddress);
		GetRerouteNodeClassInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetRerouteNodeClassInBranchGraph_FunctionAddress, "ReturnValue");
		GetRerouteNodeClassInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetRerouteNodeClassInBranchGraph_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetRerouteNodeClassInBranchGraph_IsValid = GetRerouteNodeClassInBranchGraph_FunctionAddress != IntPtr.Zero && GetRerouteNodeClassInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetRerouteNodeClassInBranchGraph", GetRerouteNodeClassInBranchGraph_IsValid);
		GetExtraDefaultInputNodesInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetExtraDefaultInputNodesInBranchGraph");
		GetExtraDefaultInputNodesInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress, GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodesInBranchGraph_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultInputNodesInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "ReturnValue");
		GetExtraDefaultInputNodesInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultInputNodesInBranchGraph_IsValid = GetExtraDefaultInputNodesInBranchGraph_FunctionAddress != IntPtr.Zero && GetExtraDefaultInputNodesInBranchGraph_OutClasses_IsValid && GetExtraDefaultInputNodesInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetExtraDefaultInputNodesInBranchGraph", GetExtraDefaultInputNodesInBranchGraph_IsValid);
		GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetExtraDefaultOutputNodesInBranchGraph");
		GetExtraDefaultOutputNodesInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress, GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodesInBranchGraph_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "ReturnValue");
		GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultOutputNodesInBranchGraph_IsValid = GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress != IntPtr.Zero && GetExtraDefaultOutputNodesInBranchGraph_OutClasses_IsValid && GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_CalliopeAssetBase:GetExtraDefaultOutputNodesInBranchGraph", GetExtraDefaultOutputNodesInBranchGraph_IsValid);
	}

	static BED_CalliopeAssetBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_CalliopeAssetBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_CalliopeAssetBase));
	}
}
