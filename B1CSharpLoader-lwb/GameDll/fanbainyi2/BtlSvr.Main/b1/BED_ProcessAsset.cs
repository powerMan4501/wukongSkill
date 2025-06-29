using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BED_ProcessAsset")]
public class BED_ProcessAsset : BED_CalliopeAssetBase
{
	private static bool StateTags_IsValid;

	private static int StateTags_Offset;

	private static bool EventTags_IsValid;

	private static int EventTags_Offset;

	private static bool CustomDetectConditions_IsValid;

	private static int CustomDetectConditions_Offset;

	private static FFieldAddress CustomDetectConditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> CustomDetectConditions_Marshaler;

	private static bool SubMachineStateTags_IsValid;

	private static int SubMachineStateTags_Offset;

	private static bool NodeBranchGraphNames_IsValid;

	private static int NodeBranchGraphNames_Offset;

	private static FFieldAddress NodeBranchGraphNames_PropertyAddress;

	private TMapReadWriteMarshaler<FCalliopeGuid, FGameplayTagContainer> NodeBranchGraphNames_Marshaler;

	private static bool HasRevertCondition_IsValid;

	private static IntPtr HasRevertCondition_FunctionAddress;

	private static int HasRevertCondition_ParamsSize;

	private static bool HasRevertCondition_ReturnValue_IsValid;

	private static int HasRevertCondition_ReturnValue_Offset;

	private static FFieldAddress HasRevertCondition_ReturnValue_PropertyAddress;

	private static bool GetViewType_IsValid;

	private static IntPtr GetViewType_FunctionAddress;

	private static int GetViewType_ParamsSize;

	private static bool GetViewType_ReturnValue_IsValid;

	private static int GetViewType_ReturnValue_Offset;

	private static FFieldAddress GetViewType_ReturnValue_PropertyAddress;

	private static bool RegisterNode_IsValid;

	private static IntPtr RegisterNode_FunctionAddress;

	private static int RegisterNode_ParamsSize;

	private static bool RegisterNode_NewGuid_IsValid;

	private static int RegisterNode_NewGuid_Offset;

	private static FFieldAddress RegisterNode_NewGuid_PropertyAddress;

	private static bool RegisterNode_NewNode_IsValid;

	private static int RegisterNode_NewNode_Offset;

	private static bool UnregisterNode_IsValid;

	private static IntPtr UnregisterNode_FunctionAddress;

	private static int UnregisterNode_ParamsSize;

	private static bool UnregisterNode_NodeGuid_IsValid;

	private static int UnregisterNode_NodeGuid_Offset;

	private static FFieldAddress UnregisterNode_NodeGuid_PropertyAddress;

	private static bool IsEditorOnlyCS_IsValid;

	private static IntPtr IsEditorOnlyCS_FunctionAddress;

	private static int IsEditorOnlyCS_ParamsSize;

	private static bool IsEditorOnlyCS_ReturnValue_IsValid;

	private static int IsEditorOnlyCS_ReturnValue_Offset;

	private static FFieldAddress IsEditorOnlyCS_ReturnValue_PropertyAddress;

	private static bool CanManageStates_IsValid;

	private static IntPtr CanManageStates_FunctionAddress;

	private static int CanManageStates_ParamsSize;

	private static bool CanManageStates_ReturnValue_IsValid;

	private static int CanManageStates_ReturnValue_Offset;

	private static FFieldAddress CanManageStates_ReturnValue_PropertyAddress;

	private static bool GetStartNodeClass_IsValid;

	private static IntPtr GetStartNodeClass_FunctionAddress;

	private static int GetStartNodeClass_ParamsSize;

	private static bool GetStartNodeClass_ReturnValue_IsValid;

	private static int GetStartNodeClass_ReturnValue_Offset;

	private static bool OnPropertyChanged_IsValid;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static int OnPropertyChanged_MemberName_Offset;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	private static bool OnRefreshAssetInCS_IsValid;

	private static IntPtr OnRefreshAssetInCS_FunctionAddress;

	private static int OnRefreshAssetInCS_ParamsSize;

	private static bool GetRerouteNodeClass_IsValid;

	private static IntPtr GetRerouteNodeClass_FunctionAddress;

	private static int GetRerouteNodeClass_ParamsSize;

	private static bool GetRerouteNodeClass_ReturnValue_IsValid;

	private static int GetRerouteNodeClass_ReturnValue_Offset;

	private static bool PostRefreshAssetInCS_IsValid;

	private static IntPtr PostRefreshAssetInCS_FunctionAddress;

	private static int PostRefreshAssetInCS_ParamsSize;

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

	[UProperty]
	[BlueprintReadWrite]
	[Category("Process")]
	[DisplayName("状态集合")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:StateTags")]
	public FGameplayTagContainer StateTags
	{
		get
		{
			CheckDestroyed();
			if (!StateTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessAsset:StateTags");
				return default(FGameplayTagContainer);
			}
			return FGameplayTagContainer.FromNative(IntPtr.Add(base.Address, StateTags_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StateTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessAsset:StateTags");
			}
			else
			{
				FGameplayTagContainer.ToNative(IntPtr.Add(base.Address, StateTags_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Process")]
	[DisplayName("事件集合")]
	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:EventTags")]
	public FGameplayTagContainer EventTags
	{
		get
		{
			CheckDestroyed();
			if (!EventTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessAsset:EventTags");
				return default(FGameplayTagContainer);
			}
			return FGameplayTagContainer.FromNative(IntPtr.Add(base.Address, EventTags_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessAsset:EventTags");
			}
			else
			{
				FGameplayTagContainer.ToNative(IntPtr.Add(base.Address, EventTags_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Process")]
	[DisplayName("检测条件集合")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:CustomDetectConditions")]
	public TArrayReadWrite<FName> CustomDetectConditions
	{
		get
		{
			CheckDestroyed();
			if (!CustomDetectConditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessAsset:CustomDetectConditions");
				return null;
			}
			if (CustomDetectConditions_Marshaler == null)
			{
				CustomDetectConditions_Marshaler = new TArrayReadWriteMarshaler<FName>(1, CustomDetectConditions_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return CustomDetectConditions_Marshaler.FromNative(IntPtr.Add(base.Address, CustomDetectConditions_Offset));
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadOnly]
	[DisplayName("可扩展的状态集合")]
	[Category("Process")]
	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:SubMachineStateTags")]
	public FGameplayTagContainer SubMachineStateTags
	{
		get
		{
			CheckDestroyed();
			if (!SubMachineStateTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessAsset:SubMachineStateTags");
				return default(FGameplayTagContainer);
			}
			return FGameplayTagContainer.FromNative(IntPtr.Add(base.Address, SubMachineStateTags_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SubMachineStateTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessAsset:SubMachineStateTags");
			}
			else
			{
				FGameplayTagContainer.ToNative(IntPtr.Add(base.Address, SubMachineStateTags_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[Category("Process")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:NodeBranchGraphNames")]
	private TMapReadWrite<FCalliopeGuid, FGameplayTagContainer> NodeBranchGraphNames
	{
		get
		{
			CheckDestroyed();
			if (!NodeBranchGraphNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessAsset:NodeBranchGraphNames");
				return null;
			}
			if (NodeBranchGraphNames_Marshaler == null)
			{
				NodeBranchGraphNames_Marshaler = new TMapReadWriteMarshaler<FCalliopeGuid, FGameplayTagContainer>(1, NodeBranchGraphNames_PropertyAddress, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.FromNative, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.ToNative, CachedMarshalingDelegates<FGameplayTagContainer, FGameplayTagContainer>.FromNative, CachedMarshalingDelegates<FGameplayTagContainer, FGameplayTagContainer>.ToNative);
			}
			return NodeBranchGraphNames_Marshaler.FromNative(IntPtr.Add(base.Address, NodeBranchGraphNames_Offset));
		}
	}

	public Dictionary<string, BED_ProcessMachineNode_ResetGroup> GroupNodes { get; } = new Dictionary<string, BED_ProcessMachineNode_ResetGroup>();

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:OnPropertyChanged")]
	protected override void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		base.OnPropertyChanged_Implementation(MemberName, PropertyName);
		if (PropertyName.Equals("StateTags"))
		{
			RefreshBranchGraphNames();
		}
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:IsEditorOnlyCS")]
	protected override bool IsEditorOnlyCS_Implementation()
	{
		return true;
	}

	public override bool HasDeleteNodeLimit()
	{
		return true;
	}

	private void RefreshBranchGraphNames()
	{
		foreach (FGameplayTag gameplayTag in StateTags.GameplayTags)
		{
			if (!base.BranchGraphNames.Contains(gameplayTag.TagName))
			{
				AddBranchGraph(gameplayTag.TagName);
			}
		}
		foreach (FGameplayTag gameplayTag2 in SubMachineStateTags.GameplayTags)
		{
			if (!base.BranchGraphNames.Contains(gameplayTag2.TagName))
			{
				AddBranchGraph(gameplayTag2.TagName);
			}
		}
		HashSet<FName> hashSet = new HashSet<FName>();
		foreach (FName branchGraphName in base.BranchGraphNames)
		{
			if (!UCalliopeGameplayTagLibrary.HasTagName(StateTags, branchGraphName, bExactMatch: true) && !UCalliopeGameplayTagLibrary.HasTagName(SubMachineStateTags, branchGraphName, bExactMatch: true))
			{
				hashSet.Add(branchGraphName);
			}
		}
		foreach (FName item in hashSet)
		{
			RemoveBranchGraph(item);
		}
		hashSet.Clear();
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:RegisterNode")]
	protected override void RegisterNode_Implementation(FCalliopeGuid NewGuid, UCalliopeNode NewNode)
	{
		base.RegisterNode_Implementation(NewGuid, NewNode);
		bool flag = false;
		if (NewNode is BED_CalliopeNodeBae bED_CalliopeNodeBae && bED_CalliopeNodeBae.TryGetExtraBranchGraphNames(out var OutBranchGraphNames))
		{
			if (NodeBranchGraphNames.ContainsKey(NewGuid))
			{
				return;
			}
			foreach (FName item in OutBranchGraphNames)
			{
				if (UCalliopeGameplayTagLibrary.HasTagName(SubMachineStateTags, item, bExactMatch: true))
				{
					return;
				}
			}
			FGameplayTagContainer TagContainer = UCalliopeGameplayTagLibrary.MakeGameplayTagContainer();
			foreach (FName item2 in OutBranchGraphNames)
			{
				FGameplayTag tag = GameplayTagExtension.MakeGameplayTag(item2);
				UGameplayTagLibrary.AddGameplayTag(ref TagContainer, tag);
				FGameplayTagContainer TagContainer2 = SubMachineStateTags;
				UGameplayTagLibrary.AddGameplayTag(ref TagContainer2, tag);
				SubMachineStateTags = TagContainer2;
			}
			flag = true;
			NodeBranchGraphNames.Add(NewGuid, TagContainer);
		}
		if (flag)
		{
			RefreshBranchGraphNames();
		}
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:UnregisterNode")]
	protected override void UnregisterNode_Implementation(FCalliopeGuid NodeGuid)
	{
		if (NodeBranchGraphNames.ContainsKey(NodeGuid))
		{
			bool flag = false;
			if (NodeBranchGraphNames.TryGetValue(NodeGuid, out var value))
			{
				foreach (FGameplayTag gameplayTag in value.GameplayTags)
				{
					if (UGameplayTagLibrary.HasTag(SubMachineStateTags, gameplayTag, bExactMatch: true))
					{
						FGameplayTagContainer TagContainer = SubMachineStateTags;
						UGameplayTagLibrary.RemoveGameplayTag(ref TagContainer, gameplayTag);
						SubMachineStateTags = TagContainer;
					}
				}
				flag = true;
				NodeBranchGraphNames.Remove(NodeGuid);
			}
			if (flag)
			{
				RefreshBranchGraphNames();
			}
		}
		base.UnregisterNode_Implementation(NodeGuid);
	}

	protected override bool CorrectnessCheck(out string OutErrorMessage)
	{
		OutErrorMessage = "";
		bool flag = false;
		StringBuilder stringBuilder = new StringBuilder();
		List<FName> list = new List<FName>();
		List<FName> list2 = new List<FName>();
		List<UCalliopeNode> validNodes = GetValidNodes();
		foreach (UCalliopeNode item in validNodes)
		{
			if (item is BED_ProcessMachineNode_State bED_ProcessMachineNode_State)
			{
				if (list.Contains(bED_ProcessMachineNode_State.CurrentState))
				{
					bED_ProcessMachineNode_State.NodeHasError = true;
					stringBuilder.AppendLine($"存在重复的State结点 状态名：{bED_ProcessMachineNode_State.CurrentState}");
					flag = true;
				}
				else
				{
					bED_ProcessMachineNode_State.NodeHasError = false;
					list.Add(bED_ProcessMachineNode_State.CurrentState);
				}
			}
			else if (item is BED_ProcessStateNode_DetectStart bED_ProcessStateNode_DetectStart)
			{
				if (list2.Contains(bED_ProcessStateNode_DetectStart.CurrentCondition))
				{
					bED_ProcessStateNode_DetectStart.NodeHasError = true;
					stringBuilder.AppendLine($"存在重复的条件检测结点 条件名：{bED_ProcessStateNode_DetectStart.CurrentCondition}");
					flag = true;
				}
				else
				{
					bED_ProcessStateNode_DetectStart.NodeHasError = false;
					list2.Add(bED_ProcessStateNode_DetectStart.CurrentCondition);
				}
			}
			else if (item.NodeHasError)
			{
				item.NodeHasError = false;
			}
		}
		if (!BGUFuncLibResCS.CheckCalliopeAssetUniqueControl(this, out var CpgUniqueControlResult))
		{
			flag = true;
			stringBuilder.AppendLine("");
			stringBuilder.AppendLine(CpgUniqueControlResult.ToString(this));
		}
		string levelRepeatControlInfo = CpgUniqueControlResult.CalliopeControlledLevelsInfo.GetLevelRepeatControlInfo();
		if (levelRepeatControlInfo != "")
		{
			FMessage.OpenDialog(levelRepeatControlInfo);
			BGW_LogUtil.LogError(levelRepeatControlInfo);
		}
		if (CheckUnitInfo(validNodes, out var OutErrorMessage2))
		{
			flag = true;
			stringBuilder.AppendLine(OutErrorMessage2);
		}
		if (CheckInputConnections(validNodes, out var OutErrorMessage3))
		{
			flag = true;
			stringBuilder.AppendLine(OutErrorMessage3);
		}
		if (flag)
		{
			OutErrorMessage = stringBuilder.ToString();
			return false;
		}
		return true;
	}

	private bool CheckUnitInfo(List<UCalliopeNode> CheckNodes, out string OutErrorMessage)
	{
		bool result = false;
		OutErrorMessage = "";
		StringBuilder stringBuilder = new StringBuilder();
		foreach (FGsManagedNPCUnit item in base.CalliopeParameters.NPCUnitCollection)
		{
			if (item.NPCInstanceGroup.Count <= 0)
			{
				continue;
			}
			HashSet<FName> hashSet = new HashSet<FName>();
			bool flag = false;
			foreach (FGsNPCReferenceInfo item2 in item.NPCInstanceGroup)
			{
				if (item2.AliasName == FName.None || hashSet.Contains(item2.AliasName))
				{
					flag = true;
					break;
				}
				hashSet.Add(item2.AliasName);
			}
			if (flag)
			{
				result = true;
				stringBuilder.AppendLine($"CPG管理的NPC({item.AliasName})，其NPC实例组内的实例名不能为\"None\"或重复");
			}
		}
		List<UCalliopeNode> list = base.Nodes.Values.ToList();
		for (int i = 0; i < CheckNodes.Count; i++)
		{
			UCalliopeNode Node = CheckNodes[i];
			BED_ProcessMachineNode_TemplateBase bED_ProcessMachineNode_TemplateBase = Node as BED_ProcessMachineNode_TemplateBase;
			if (bED_ProcessMachineNode_TemplateBase == null)
			{
				continue;
			}
			int num = list.FindIndex((UCalliopeNode r) => r == Node);
			foreach (FGsNPCUnitPoliceConfig NpcUnit in bED_ProcessMachineNode_TemplateBase.SceneObjPoliceConfig.NPCUnitCollection)
			{
				FName aliasName = base.CalliopeParameters.NPCUnitCollection.Find((FGsManagedNPCUnit r) => r.ConfigGuid == NpcUnit.ConfigGuid).AliasName;
				int TeamID;
				bool teamIDBySmartParam = GetTeamIDBySmartParam(NpcUnit.ManagedTeamIDParam.ActualParam, out TeamID);
				if (!teamIDBySmartParam || TeamID <= 0)
				{
					result = true;
					if (teamIDBySmartParam)
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})队伍不正确(值:{TeamID} <= 0)");
					}
					else
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})队伍【配置丢失】");
					}
				}
				int IdleAMIdx;
				bool idleAMIdxBySmartParam = GetIdleAMIdxBySmartParam(NpcUnit.ManagedIdleAMIdxParam.ActualParam, out IdleAMIdx);
				if (!idleAMIdxBySmartParam || IdleAMIdx < 0)
				{
					result = true;
					if (idleAMIdxBySmartParam)
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})待机动画不正确(值:{NpcUnit.ManagedIdleAMIdx.ActualParam} < 0)");
					}
					else
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})待机动画【配置丢失】");
					}
				}
				int LeisureAnimIndex;
				bool leisureAnimIndexBySmartParam = GetLeisureAnimIndexBySmartParam(NpcUnit.ManagedLeisureAnimIndexParam.ActualParam, out LeisureAnimIndex);
				if (!leisureAnimIndexBySmartParam || LeisureAnimIndex < -1)
				{
					result = true;
					if (leisureAnimIndexBySmartParam)
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})Leisure动画不正确(值:{NpcUnit.ManagedLeisureAnimIndex.ActualParam} < -1)");
					}
					else
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})Leisure动画【配置丢失】");
					}
				}
				int InteractGroupID;
				bool interactGroupIDBySmartParam = GetInteractGroupIDBySmartParam(NpcUnit.ManagedInteractGroupIDParam.ActualParam, out InteractGroupID);
				if (!interactGroupIDBySmartParam || InteractGroupID < -1)
				{
					result = true;
					if (interactGroupIDBySmartParam)
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})交互动作组不正确(值:{NpcUnit.ManagedInteractGroupID.ActualParam} < -1)");
					}
					else
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})交互动作组【配置丢失】");
					}
				}
			}
		}
		OutErrorMessage = stringBuilder.ToString();
		return result;
	}

	private bool CheckInputConnections(List<UCalliopeNode> CheckNodes, out string OutErrorMessage)
	{
		bool result = false;
		OutErrorMessage = "";
		StringBuilder stringBuilder = new StringBuilder();
		Dictionary<FCalliopeGuid, List<FName>> dictionary = new Dictionary<FCalliopeGuid, List<FName>>();
		foreach (UCalliopeNode CheckNode in CheckNodes)
		{
			foreach (KeyValuePair<FName, FCalliopeConnectedPin> connection in CheckNode.GetConnections())
			{
				if (dictionary.ContainsKey(connection.Value.NodeGuid))
				{
					dictionary[connection.Value.NodeGuid].Add(connection.Key);
					continue;
				}
				dictionary.Add(connection.Value.NodeGuid, new List<FName> { connection.Key });
			}
		}
		foreach (KeyValuePair<FCalliopeGuid, List<FName>> item in dictionary)
		{
			if (item.Value.Count <= 1)
			{
				continue;
			}
			BED_ProcessMachineNode_TemplateBase Node = GetNode(item.Key) as BED_ProcessMachineNode_TemplateBase;
			if (Node != null && !GetNodes().ContainsKey(Node.ParentNode.NodeGuid) && !CheckNodeManagedItemsAllModified(Node, out var OutErrorMessage2))
			{
				result = true;
				stringBuilder.AppendLine($"节点[{base.Nodes.Values.ToList().FindIndex((UCalliopeNode r) => r == Node)}]存在{item.Value.Count}个输入状态，其管理的物件与单位{OutErrorMessage2}不可使用“与前状态保持一致”配置");
			}
		}
		OutErrorMessage += stringBuilder.ToString();
		return result;
	}

	private bool CheckNodeManagedItemsAllModified(BED_ProcessMachineNode_TemplateBase Node, out string OutErrorMessage)
	{
		bool result = true;
		OutErrorMessage = "";
		foreach (FGsDynamicObstaclePoliceConfig item in Node.SceneObjPoliceConfig.DynamicObstacleCollection)
		{
			if (item.ManagePolice == EGsDynamicObstacleManagePolice.SameAsPrevious)
			{
				result = false;
				if (GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(item.ConfigGuid), "", out var OutDisplayName))
				{
					OutErrorMessage = OutErrorMessage + OutDisplayName + " ";
				}
			}
		}
		foreach (FGsOverlapPoliceConfig item2 in Node.SceneObjPoliceConfig.OverlapCollection)
		{
			if (item2.ManagePolice == EGsOverlapManagePolice.SameAsPrevious)
			{
				result = false;
				if (GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(item2.ConfigGuid), "", out var OutDisplayName2))
				{
					OutErrorMessage = OutErrorMessage + OutDisplayName2 + " ";
				}
			}
		}
		foreach (FGsInteractorPoliceConfig item3 in Node.SceneObjPoliceConfig.InteractorCollection)
		{
			if (!item3.CanModify)
			{
				result = false;
				if (GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(item3.ConfigGuid), "", out var OutDisplayName3))
				{
					OutErrorMessage = OutErrorMessage + OutDisplayName3 + " ";
				}
			}
		}
		foreach (FGsSpawnerPoliceConfig item4 in Node.SceneObjPoliceConfig.SpawnerCollection)
		{
			if (item4.ManagePolice == EGsSpawnerManagePolice.SameAsPrevious)
			{
				result = false;
				if (GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(item4.ConfigGuid), "", out var OutDisplayName4))
				{
					OutErrorMessage = OutErrorMessage + OutDisplayName4 + " ";
				}
			}
		}
		foreach (FGsUnitPoliceConfig item5 in Node.SceneObjPoliceConfig.UnitCollection)
		{
			if (item5.ManagePolice == EGsUnitManagePolice.SameAsPrevious)
			{
				result = false;
				if (GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(item5.ConfigGuid), "", out var OutDisplayName5))
				{
					OutErrorMessage = OutErrorMessage + OutDisplayName5 + " ";
				}
			}
		}
		foreach (FGsNPCUnitPoliceConfig item6 in Node.SceneObjPoliceConfig.NPCUnitCollection)
		{
			bool flag = false;
			foreach (FGsManagedNPCUnit item7 in base.CalliopeParameters.NPCUnitCollection)
			{
				if (item7.ConfigGuid == item6.ConfigGuid)
				{
					flag = item7.NPCInstanceGroup.Count > 0;
					break;
				}
			}
			if ((!item6.ManagedTeamIDParam.CanModify || !item6.ManagedIdleAMIdxParam.CanModify || !item6.ManagedInteractGroupIDParam.CanModify || !(flag ? item6.ManagedActiveInstance.CanModify : item6.ManagedShowState.CanModify)) && GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(item6.ConfigGuid), "", out var OutDisplayName6))
			{
				OutErrorMessage = OutErrorMessage + OutDisplayName6 + " ";
			}
		}
		OutErrorMessage = "( " + OutErrorMessage + ")";
		return result;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:OnRefreshAssetInCS")]
	protected override void OnRefreshAssetInCS_Implementation()
	{
		GroupNodes.Clear();
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:PostRefreshAssetInCS")]
	protected override void PostRefreshAssetInCS_Implementation()
	{
		foreach (UCalliopeNode value in base.Nodes.Values)
		{
			if (value is BED_ProcessMachineNode_Initial bED_ProcessMachineNode_Initial)
			{
				bED_ProcessMachineNode_Initial.RefreshTemplateNodeState();
				break;
			}
		}
		foreach (UCalliopeNode value2 in base.Nodes.Values)
		{
			if (value2 is BED_ProcessMachineNode_GroupStart bED_ProcessMachineNode_GroupStart)
			{
				bED_ProcessMachineNode_GroupStart.RefreshTemplateNodeState();
			}
		}
	}

	public void RegisterGroup(string GroupName, BED_ProcessMachineNode_ResetGroup GroupNode)
	{
		if (!string.IsNullOrEmpty(GroupName) && !GroupNodes.ContainsKey(GroupName))
		{
			GroupNodes.Add(GroupName, GroupNode);
		}
	}

	public bool TryGetGroupNode(string GroupName, out BED_ProcessMachineNode_ResetGroup OutGroupNode)
	{
		OutGroupNode = null;
		if (string.IsNullOrEmpty(GroupName))
		{
			return false;
		}
		return GroupNodes.TryGetValue(GroupName, out OutGroupNode);
	}

	public string GetUnitGuidDisplayName(string Guid)
	{
		return Guid;
	}

	public string GetObjGuidDisplayName(string Guid)
	{
		return Guid;
	}

	public List<UCalliopeNode> GetValidNodes()
	{
		List<UCalliopeNode> list = new List<UCalliopeNode>();
		List<UCalliopeNode> list2 = new List<UCalliopeNode>();
		foreach (UCalliopeNode item in GetNodes().Values.ToList())
		{
			if (item is BED_ProcessMachineNode_Initial)
			{
				list.Add(item);
				list2.Add(item);
			}
		}
		while (list2.Count > 0)
		{
			foreach (KeyValuePair<FName, FCalliopeConnectedPin> connection in list2[0].GetConnections())
			{
				UCalliopeNode node = GetNode(connection.Value.NodeGuid);
				if (!list.Contains(node))
				{
					list.Add(node);
					list2.Add(node);
				}
			}
			list2.RemoveAt(0);
		}
		return list;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:CanManageStates")]
	public override bool CanManageStates_Implementation()
	{
		return true;
	}

	protected override bool CanCalliopeAssetNodeLog()
	{
		return true;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:HasRevertCondition")]
	public bool HasRevertCondition()
	{
		foreach (UCalliopeNode value in base.Nodes.Values)
		{
			if (value is BED_ProcessMachineNode_Idle bED_ProcessMachineNode_Idle)
			{
				foreach (FCompositeTransitionCondition_Idle transitionCondition in bED_ProcessMachineNode_Idle.TransitionConditions)
				{
					if (transitionCondition.bReverseCondition)
					{
						return true;
					}
					if (transitionCondition.bUseCompositeCondition)
					{
						foreach (FTransitionCondition_Idle condition in transitionCondition.Conditions)
						{
							if (condition.bReverseCondition)
							{
								return true;
							}
						}
					}
					if (transitionCondition.Single.bReverseCondition)
					{
						return true;
					}
				}
			}
			if (value is BED_ProcessMachineNode_Battle bED_ProcessMachineNode_Battle)
			{
				foreach (FCompositeTransitionCondition_Battle transitionCondition2 in bED_ProcessMachineNode_Battle.TransitionConditions)
				{
					if (transitionCondition2.bReverseCondition)
					{
						return true;
					}
					if (transitionCondition2.bUseCompositeCondition)
					{
						foreach (FTransitionCondition_Battle condition2 in transitionCondition2.Conditions)
						{
							if (condition2.bReverseCondition)
							{
								return true;
							}
						}
					}
					if (transitionCondition2.Single.bReverseCondition)
					{
						return true;
					}
				}
			}
			if (!(value is BED_ProcessMachineNode_ResetGroup bED_ProcessMachineNode_ResetGroup))
			{
				continue;
			}
			foreach (FCompositeTransitionCondition_Group transitionCondition3 in bED_ProcessMachineNode_ResetGroup.TransitionConditions)
			{
				if (transitionCondition3.bReverseCondition)
				{
					return true;
				}
				if (transitionCondition3.bUseCompositeCondition)
				{
					foreach (FTransitionCondition_Group condition3 in transitionCondition3.Conditions)
					{
						if (condition3.bReverseCondition)
						{
							return true;
						}
					}
				}
				if (transitionCondition3.Single.bReverseCondition)
				{
					return true;
				}
			}
		}
		return false;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:GetViewType")]
	protected override ECalliopeViewType GetViewType_Implementation()
	{
		return ECalliopeViewType.Process;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:GetRerouteNodeClass")]
	protected override TSubclassOf<UObject> GetRerouteNodeClass_Implementation()
	{
		return UClass.GetClass<BED_ProcessMachineNode_Reroute>();
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:GetStartNodeClass")]
	protected override TSubclassOf<UObject> GetStartNodeClass_Implementation()
	{
		return UClass.GetClass<BED_ProcessMachineNode_Initial>();
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:GetExtraDefaultInputNodes")]
	protected override int GetExtraDefaultInputNodes_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:GetExtraDefaultOutputNodes")]
	protected override int GetExtraDefaultOutputNodes_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:GetRerouteNodeClassInBranchGraph")]
	protected override TSubclassOf<UObject> GetRerouteNodeClassInBranchGraph_Implementation()
	{
		return UClass.GetClass<BED_ProcessStateNode_Reroute>();
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:GetStartNodeClassInBranchGraph")]
	protected override TSubclassOf<UObject> GetStartNodeClassInBranchGraph_Implementation()
	{
		return UClass.GetClass<BED_ProcessStateNode_EnterAction>();
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:GetExtraDefaultInputNodesInBranchGraph")]
	protected override int GetExtraDefaultInputNodesInBranchGraph_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>
		{
			UClass.GetClass<BED_ProcessStateNode_TickAction>(),
			UClass.GetClass<BED_ProcessStateNode_ExitAction>(),
			UClass.GetClass<BED_ProcessStateNode_ResetAction>()
		};
		return OutClasses.Count;
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessAsset:GetExtraDefaultOutputNodesInBranchGraph")]
	protected override int GetExtraDefaultOutputNodesInBranchGraph_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:HasRevertCondition")]
	private static void HasRevertCondition__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		bool value = bED_ProcessAsset.HasRevertCondition();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, HasRevertCondition_ReturnValue_Offset), 0, HasRevertCondition_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:GetViewType")]
	private static void GetViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		ECalliopeViewType viewType_Implementation = bED_ProcessAsset.GetViewType_Implementation();
		EnumMarshaler<ECalliopeViewType>.ToNative(IntPtr.Add(buffer, GetViewType_ReturnValue_Offset), 0, GetViewType_ReturnValue_PropertyAddress.Address, viewType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:RegisterNode")]
	private static void RegisterNode__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		FCalliopeGuid newGuid = FCalliopeGuid.FromNative(IntPtr.Add(buffer, RegisterNode_NewGuid_Offset));
		UCalliopeNode newNode = UObjectMarshaler<UCalliopeNode>.FromNative(IntPtr.Add(buffer, RegisterNode_NewNode_Offset));
		bED_ProcessAsset.RegisterNode_Implementation(newGuid, newNode);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:UnregisterNode")]
	private static void UnregisterNode__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		FCalliopeGuid nodeGuid = FCalliopeGuid.FromNative(IntPtr.Add(buffer, UnregisterNode_NodeGuid_Offset));
		bED_ProcessAsset.UnregisterNode_Implementation(nodeGuid);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:IsEditorOnlyCS")]
	private static void IsEditorOnlyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		bool value = bED_ProcessAsset.IsEditorOnlyCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsEditorOnlyCS_ReturnValue_Offset), 0, IsEditorOnlyCS_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:CanManageStates")]
	private static void CanManageStates__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		bool value = bED_ProcessAsset.CanManageStates_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CanManageStates_ReturnValue_Offset), 0, CanManageStates_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:GetStartNodeClass")]
	private static void GetStartNodeClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		TSubclassOf<UObject> startNodeClass_Implementation = bED_ProcessAsset.GetStartNodeClass_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetStartNodeClass_ReturnValue_Offset), startNodeClass_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:OnPropertyChanged")]
	private static void OnPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_PropertyName_Offset));
		bED_ProcessAsset.OnPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:OnRefreshAssetInCS")]
	private static void OnRefreshAssetInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		bED_ProcessAsset.OnRefreshAssetInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:GetRerouteNodeClass")]
	private static void GetRerouteNodeClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		TSubclassOf<UObject> rerouteNodeClass_Implementation = bED_ProcessAsset.GetRerouteNodeClass_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetRerouteNodeClass_ReturnValue_Offset), rerouteNodeClass_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:PostRefreshAssetInCS")]
	private static void PostRefreshAssetInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		bED_ProcessAsset.PostRefreshAssetInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:GetExtraDefaultInputNodes")]
	private static void GetExtraDefaultInputNodes__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultInputNodes_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_OutClasses_Offset));
		int extraDefaultInputNodes_Implementation = bED_ProcessAsset.GetExtraDefaultInputNodes_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_ReturnValue_Offset), extraDefaultInputNodes_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:GetExtraDefaultOutputNodes")]
	private static void GetExtraDefaultOutputNodes__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultOutputNodes_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_OutClasses_Offset));
		int extraDefaultOutputNodes_Implementation = bED_ProcessAsset.GetExtraDefaultOutputNodes_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_ReturnValue_Offset), extraDefaultOutputNodes_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:GetStartNodeClassInBranchGraph")]
	private static void GetStartNodeClassInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		TSubclassOf<UObject> startNodeClassInBranchGraph_Implementation = bED_ProcessAsset.GetStartNodeClassInBranchGraph_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetStartNodeClassInBranchGraph_ReturnValue_Offset), startNodeClassInBranchGraph_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:GetRerouteNodeClassInBranchGraph")]
	private static void GetRerouteNodeClassInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		TSubclassOf<UObject> rerouteNodeClassInBranchGraph_Implementation = bED_ProcessAsset.GetRerouteNodeClassInBranchGraph_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetRerouteNodeClassInBranchGraph_ReturnValue_Offset), rerouteNodeClassInBranchGraph_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:GetExtraDefaultInputNodesInBranchGraph")]
	private static void GetExtraDefaultInputNodesInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset));
		int extraDefaultInputNodesInBranchGraph_Implementation = bED_ProcessAsset.GetExtraDefaultInputNodesInBranchGraph_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodesInBranchGraph_ReturnValue_Offset), extraDefaultInputNodesInBranchGraph_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessAsset:GetExtraDefaultOutputNodesInBranchGraph")]
	private static void GetExtraDefaultOutputNodesInBranchGraph__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_ProcessAsset bED_ProcessAsset = GCHelper.Find<BED_ProcessAsset>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset));
		int extraDefaultOutputNodesInBranchGraph_Implementation = bED_ProcessAsset.GetExtraDefaultOutputNodesInBranchGraph_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_Offset), extraDefaultOutputNodesInBranchGraph_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset), OutClasses);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessAsset");
		StateTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "StateTags");
		StateTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StateTags", Classes.FStructProperty);
		EventTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "EventTags");
		EventTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EventTags", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CustomDetectConditions_PropertyAddress, intPtr, "CustomDetectConditions");
		CustomDetectConditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomDetectConditions");
		CustomDetectConditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomDetectConditions", Classes.FArrayProperty);
		SubMachineStateTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "SubMachineStateTags");
		SubMachineStateTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SubMachineStateTags", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref NodeBranchGraphNames_PropertyAddress, intPtr, "NodeBranchGraphNames");
		NodeBranchGraphNames_Offset = NativeReflection.GetPropertyOffset(intPtr, "NodeBranchGraphNames");
		NodeBranchGraphNames_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NodeBranchGraphNames", Classes.FMapProperty);
		HasRevertCondition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasRevertCondition");
		HasRevertCondition_ParamsSize = NativeReflection.GetFunctionParamsSize(HasRevertCondition_FunctionAddress);
		NativeReflection.GetPropertyRef(ref HasRevertCondition_ReturnValue_PropertyAddress, HasRevertCondition_FunctionAddress, "ReturnValue");
		HasRevertCondition_ReturnValue_Offset = NativeReflection.GetPropertyOffset(HasRevertCondition_FunctionAddress, "ReturnValue");
		HasRevertCondition_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(HasRevertCondition_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasRevertCondition_IsValid = HasRevertCondition_FunctionAddress != IntPtr.Zero && HasRevertCondition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:HasRevertCondition", HasRevertCondition_IsValid);
		GetViewType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewType");
		GetViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetViewType_ReturnValue_PropertyAddress, GetViewType_FunctionAddress, "ReturnValue");
		GetViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetViewType_FunctionAddress, "ReturnValue");
		GetViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetViewType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetViewType_IsValid = GetViewType_FunctionAddress != IntPtr.Zero && GetViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:GetViewType", GetViewType_IsValid);
		RegisterNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RegisterNode");
		RegisterNode_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterNode_FunctionAddress);
		NativeReflection.GetPropertyRef(ref RegisterNode_NewGuid_PropertyAddress, RegisterNode_FunctionAddress, "NewGuid");
		RegisterNode_NewGuid_Offset = NativeReflection.GetPropertyOffset(RegisterNode_FunctionAddress, "NewGuid");
		RegisterNode_NewGuid_IsValid = NativeReflection.ValidatePropertyClass(RegisterNode_FunctionAddress, "NewGuid", Classes.FStructProperty);
		RegisterNode_NewNode_Offset = NativeReflection.GetPropertyOffset(RegisterNode_FunctionAddress, "NewNode");
		RegisterNode_NewNode_IsValid = NativeReflection.ValidatePropertyClass(RegisterNode_FunctionAddress, "NewNode", Classes.FObjectProperty);
		RegisterNode_IsValid = RegisterNode_FunctionAddress != IntPtr.Zero && RegisterNode_NewGuid_IsValid && RegisterNode_NewNode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:RegisterNode", RegisterNode_IsValid);
		UnregisterNode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnregisterNode");
		UnregisterNode_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterNode_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UnregisterNode_NodeGuid_PropertyAddress, UnregisterNode_FunctionAddress, "NodeGuid");
		UnregisterNode_NodeGuid_Offset = NativeReflection.GetPropertyOffset(UnregisterNode_FunctionAddress, "NodeGuid");
		UnregisterNode_NodeGuid_IsValid = NativeReflection.ValidatePropertyClass(UnregisterNode_FunctionAddress, "NodeGuid", Classes.FStructProperty);
		UnregisterNode_IsValid = UnregisterNode_FunctionAddress != IntPtr.Zero && UnregisterNode_NodeGuid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:UnregisterNode", UnregisterNode_IsValid);
		IsEditorOnlyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsEditorOnlyCS");
		IsEditorOnlyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEditorOnlyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsEditorOnlyCS_ReturnValue_PropertyAddress, IsEditorOnlyCS_FunctionAddress, "ReturnValue");
		IsEditorOnlyCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsEditorOnlyCS_FunctionAddress, "ReturnValue");
		IsEditorOnlyCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsEditorOnlyCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEditorOnlyCS_IsValid = IsEditorOnlyCS_FunctionAddress != IntPtr.Zero && IsEditorOnlyCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:IsEditorOnlyCS", IsEditorOnlyCS_IsValid);
		CanManageStates_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanManageStates");
		CanManageStates_ParamsSize = NativeReflection.GetFunctionParamsSize(CanManageStates_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CanManageStates_ReturnValue_PropertyAddress, CanManageStates_FunctionAddress, "ReturnValue");
		CanManageStates_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CanManageStates_FunctionAddress, "ReturnValue");
		CanManageStates_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CanManageStates_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanManageStates_IsValid = CanManageStates_FunctionAddress != IntPtr.Zero && CanManageStates_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:CanManageStates", CanManageStates_IsValid);
		GetStartNodeClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStartNodeClass");
		GetStartNodeClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartNodeClass_FunctionAddress);
		GetStartNodeClass_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetStartNodeClass_FunctionAddress, "ReturnValue");
		GetStartNodeClass_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetStartNodeClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetStartNodeClass_IsValid = GetStartNodeClass_FunctionAddress != IntPtr.Zero && GetStartNodeClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:GetStartNodeClass", GetStartNodeClass_IsValid);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:OnPropertyChanged", OnPropertyChanged_IsValid);
		OnRefreshAssetInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRefreshAssetInCS");
		OnRefreshAssetInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRefreshAssetInCS_FunctionAddress);
		OnRefreshAssetInCS_IsValid = OnRefreshAssetInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:OnRefreshAssetInCS", OnRefreshAssetInCS_IsValid);
		GetRerouteNodeClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRerouteNodeClass");
		GetRerouteNodeClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRerouteNodeClass_FunctionAddress);
		GetRerouteNodeClass_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetRerouteNodeClass_FunctionAddress, "ReturnValue");
		GetRerouteNodeClass_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetRerouteNodeClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetRerouteNodeClass_IsValid = GetRerouteNodeClass_FunctionAddress != IntPtr.Zero && GetRerouteNodeClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:GetRerouteNodeClass", GetRerouteNodeClass_IsValid);
		PostRefreshAssetInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostRefreshAssetInCS");
		PostRefreshAssetInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostRefreshAssetInCS_FunctionAddress);
		PostRefreshAssetInCS_IsValid = PostRefreshAssetInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:PostRefreshAssetInCS", PostRefreshAssetInCS_IsValid);
		GetExtraDefaultInputNodes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetExtraDefaultInputNodes");
		GetExtraDefaultInputNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultInputNodes_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultInputNodes_OutClasses_PropertyAddress, GetExtraDefaultInputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodes_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodes_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodes_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultInputNodes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodes_FunctionAddress, "ReturnValue");
		GetExtraDefaultInputNodes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodes_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultInputNodes_IsValid = GetExtraDefaultInputNodes_FunctionAddress != IntPtr.Zero && GetExtraDefaultInputNodes_OutClasses_IsValid && GetExtraDefaultInputNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:GetExtraDefaultInputNodes", GetExtraDefaultInputNodes_IsValid);
		GetExtraDefaultOutputNodes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetExtraDefaultOutputNodes");
		GetExtraDefaultOutputNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultOutputNodes_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultOutputNodes_OutClasses_PropertyAddress, GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodes_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodes_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultOutputNodes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodes_FunctionAddress, "ReturnValue");
		GetExtraDefaultOutputNodes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodes_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultOutputNodes_IsValid = GetExtraDefaultOutputNodes_FunctionAddress != IntPtr.Zero && GetExtraDefaultOutputNodes_OutClasses_IsValid && GetExtraDefaultOutputNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:GetExtraDefaultOutputNodes", GetExtraDefaultOutputNodes_IsValid);
		GetStartNodeClassInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStartNodeClassInBranchGraph");
		GetStartNodeClassInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartNodeClassInBranchGraph_FunctionAddress);
		GetStartNodeClassInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetStartNodeClassInBranchGraph_FunctionAddress, "ReturnValue");
		GetStartNodeClassInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetStartNodeClassInBranchGraph_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetStartNodeClassInBranchGraph_IsValid = GetStartNodeClassInBranchGraph_FunctionAddress != IntPtr.Zero && GetStartNodeClassInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:GetStartNodeClassInBranchGraph", GetStartNodeClassInBranchGraph_IsValid);
		GetRerouteNodeClassInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRerouteNodeClassInBranchGraph");
		GetRerouteNodeClassInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRerouteNodeClassInBranchGraph_FunctionAddress);
		GetRerouteNodeClassInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetRerouteNodeClassInBranchGraph_FunctionAddress, "ReturnValue");
		GetRerouteNodeClassInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetRerouteNodeClassInBranchGraph_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetRerouteNodeClassInBranchGraph_IsValid = GetRerouteNodeClassInBranchGraph_FunctionAddress != IntPtr.Zero && GetRerouteNodeClassInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:GetRerouteNodeClassInBranchGraph", GetRerouteNodeClassInBranchGraph_IsValid);
		GetExtraDefaultInputNodesInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetExtraDefaultInputNodesInBranchGraph");
		GetExtraDefaultInputNodesInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultInputNodesInBranchGraph_OutClasses_PropertyAddress, GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodesInBranchGraph_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodesInBranchGraph_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultInputNodesInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "ReturnValue");
		GetExtraDefaultInputNodesInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodesInBranchGraph_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultInputNodesInBranchGraph_IsValid = GetExtraDefaultInputNodesInBranchGraph_FunctionAddress != IntPtr.Zero && GetExtraDefaultInputNodesInBranchGraph_OutClasses_IsValid && GetExtraDefaultInputNodesInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:GetExtraDefaultInputNodesInBranchGraph", GetExtraDefaultInputNodesInBranchGraph_IsValid);
		GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetExtraDefaultOutputNodesInBranchGraph");
		GetExtraDefaultOutputNodesInBranchGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultOutputNodesInBranchGraph_OutClasses_PropertyAddress, GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodesInBranchGraph_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodesInBranchGraph_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "ReturnValue");
		GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultOutputNodesInBranchGraph_IsValid = GetExtraDefaultOutputNodesInBranchGraph_FunctionAddress != IntPtr.Zero && GetExtraDefaultOutputNodesInBranchGraph_OutClasses_IsValid && GetExtraDefaultOutputNodesInBranchGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessAsset:GetExtraDefaultOutputNodesInBranchGraph", GetExtraDefaultOutputNodesInBranchGraph_IsValid);
	}

	static BED_ProcessAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessAsset));
	}
}
