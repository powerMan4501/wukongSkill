using System;
using System.Collections.Generic;
using System.Linq;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Listener")]
[USharpPath("/Script/b1-Managed.BED_GuideNode_Listener")]
public class BED_GuideNode_Listener : BED_GuideNode_Base
{
	private const int ProtectedDepth = 20;

	private bool _isExceedingDepth;

	private static bool TransitionConditions_IsValid;

	private static int TransitionConditions_Offset;

	private static FFieldAddress TransitionConditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FCompositeTransitionCondition_Guide> TransitionConditions_Marshaler;

	private static bool RelatedGuideGroupList_IsValid;

	private static int RelatedGuideGroupList_Offset;

	private static FFieldAddress RelatedGuideGroupList_PropertyAddress;

	private TMapReadWriteMarshaler<FName, string> RelatedGuideGroupList_Marshaler;

	private static bool GetContextOutputsInCS_IsValid;

	private static IntPtr GetContextOutputsInCS_FunctionAddress;

	private static int GetContextOutputsInCS_ParamsSize;

	private static bool GetContextOutputsInCS_ReturnValue_IsValid;

	private static int GetContextOutputsInCS_ReturnValue_Offset;

	private static FFieldAddress GetContextOutputsInCS_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[DisplayName("跳转条件")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_GuideNode_Listener:TransitionConditions")]
	public TArrayReadWrite<FCompositeTransitionCondition_Guide> TransitionConditions
	{
		get
		{
			CheckDestroyed();
			if (!TransitionConditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_GuideNode_Listener:TransitionConditions");
				return null;
			}
			if (TransitionConditions_Marshaler == null)
			{
				TransitionConditions_Marshaler = new TArrayReadWriteMarshaler<FCompositeTransitionCondition_Guide>(1, TransitionConditions_PropertyAddress, CachedMarshalingDelegates<FCompositeTransitionCondition_Guide, FCompositeTransitionCondition_Guide>.FromNative, CachedMarshalingDelegates<FCompositeTransitionCondition_Guide, FCompositeTransitionCondition_Guide>.ToNative);
			}
			return TransitionConditions_Marshaler.FromNative(IntPtr.Add(base.Address, TransitionConditions_Offset));
		}
	}

	[UProperty]
	[VisibleInstanceOnly]
	[DisplayName("相关教学组Id")]
	[USharpPath("/Script/b1-Managed.BED_GuideNode_Listener:RelatedGuideGroupList")]
	public TMapReadWrite<FName, string> RelatedGuideGroupList
	{
		get
		{
			CheckDestroyed();
			if (!RelatedGuideGroupList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_GuideNode_Listener:RelatedGuideGroupList");
				return null;
			}
			if (RelatedGuideGroupList_Marshaler == null)
			{
				RelatedGuideGroupList_Marshaler = new TMapReadWriteMarshaler<FName, string>(1, RelatedGuideGroupList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return RelatedGuideGroupList_Marshaler.FromNative(IntPtr.Add(base.Address, RelatedGuideGroupList_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.Category = "新手指引";
		base.OutputPins.Clear();
		base.NodeStyle = ECalliopeNodeStyle.SubGraph;
		base.SupportsContextPins = true;
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.GuideNode.Listener;
	}

	[USharpPath("/Script/b1-Managed.BED_GuideNode_Listener:GetContextOutputsInCS")]
	protected override List<FName> GetContextOutputsInCS_Implementation()
	{
		List<FName> contextOutputsInCS_Implementation = base.GetContextOutputsInCS_Implementation();
		if (TransitionConditions.Count > 0)
		{
			foreach (FCompositeTransitionCondition_Guide transitionCondition in TransitionConditions)
			{
				contextOutputsInCS_Implementation.Add(new FName(transitionCondition.Comment));
			}
		}
		return contextOutputsInCS_Implementation;
	}

	public override byte[] GetCustomData()
	{
		RelatedGuideGroupList.Clear();
		GuideCustom_Listener guideCustom_Listener = new GuideCustom_Listener();
		foreach (FCompositeTransitionCondition_Guide transitionCondition in TransitionConditions)
		{
			List<int> relatedGuideGroupIdList = GetRelatedGuideGroupIdList(transitionCondition.Comment);
			CalliopeCustom_CompositeTransitionCondition_Guide calliopeCustom_CompositeTransitionCondition_Guide = new CalliopeCustom_CompositeTransitionCondition_Guide();
			calliopeCustom_CompositeTransitionCondition_Guide.IsUseCompositeCondition = transitionCondition.bUseCompositeCondition;
			calliopeCustom_CompositeTransitionCondition_Guide.PinName = transitionCondition.Comment;
			if (calliopeCustom_CompositeTransitionCondition_Guide.IsUseCompositeCondition)
			{
				calliopeCustom_CompositeTransitionCondition_Guide.ConditionalRelation = (int)transitionCondition.ConditionalRelation;
				calliopeCustom_CompositeTransitionCondition_Guide.Single = new CalliopeCustom_TransitionCondition_Guide
				{
					RelatedGuideGroupId = { (IEnumerable<int>)relatedGuideGroupIdList }
				};
				foreach (FTransitionCondition_Guide condition in transitionCondition.Conditions)
				{
					calliopeCustom_CompositeTransitionCondition_Guide.Conditions.Add(Dump(condition, transitionCondition));
				}
			}
			else
			{
				calliopeCustom_CompositeTransitionCondition_Guide.Single = Dump(transitionCondition.Single, transitionCondition);
			}
			guideCustom_Listener.TransitionConditions.Add(calliopeCustom_CompositeTransitionCondition_Guide);
			RelatedGuideGroupList.Add(new FName(transitionCondition.Comment), string.Join(", ", relatedGuideGroupIdList));
		}
		guideCustom_Listener.ManagedObjs.AddRange(MakeManagedSceneObjCustomData());
		guideCustom_Listener.ManagedNpcUnits.AddRange(MakeManagedNPCUnitCustomData());
		guideCustom_Listener.ManagedInteractors.AddRange(MakeManagedInteractorCustomData());
		guideCustom_Listener.ManagedStreamingLevelStateConfigs.AddRange(MakeManagedStreamingLevelStateConfigCustomData());
		guideCustom_Listener.ManagedGroupUnits.AddRange(MakeManagedGroupUnitCustomData());
		return guideCustom_Listener.ToByteArray();
	}

	private CalliopeCustom_TransitionCondition_Guide Dump(FTransitionCondition_Guide Single, FCompositeTransitionCondition_Guide Composite)
	{
		return new CalliopeCustom_TransitionCondition_Guide
		{
			ConditionType = (int)Single.ConditionType,
			IsReverseCondition = Composite.bReverseCondition,
			PinName = Composite.Comment,
			RelatedGuideGroupId = { (IEnumerable<int>)GetRelatedGuideGroupIdList(Composite.Comment) },
			OverlapGuid = Single.Overlap.ConfigGuid.ToString(),
			AbnormalState = (int)Single.AbnormalState,
			RebirthPointId = Single.RebirthPointId,
			UnitGuid = Single.Unit.ConfigGuid.ToString(),
			ItemId = Single.ItemId,
			CheckRange = Single.CheckRange,
			AttrFloatType = (int)Single.AttrFloatType,
			CompareOperation = (int)Single.CompareOperation,
			CompareValue = Single.CompareValue,
			TaskStageId = Single.TaskStage.ConfigGuid.ToString(),
			TaskStageStatus = (int)Single.TaskStageStatus,
			MapId = Single.MapId,
			UiPageType = (int)Single.UIPageType,
			TalentId = Single.TalentId,
			GuideGroupId = Single.GuideGroupId,
			SequenceId = Single.SequenceId,
			SequencePhase = (int)Single.SequencePhase,
			ItemNum = Single.ItemNum,
			CheckResIdList = { (IEnumerable<int>)Single.CheckResIdList }
		};
	}

	private List<int> GetRelatedGuideGroupIdList(string PinName)
	{
		List<int> GuideGroupList = new List<int>();
		BED_CalliopeAssetBase assetInCS = GetAssetInCS();
		if (assetInCS == null)
		{
			return GuideGroupList;
		}
		if (CheckNeedSearch() && base.Connections.TryGetValue(new FName(PinName), out var value) && assetInCS.Nodes.TryGetValue(value.NodeGuid, out var value2))
		{
			List<UCalliopeNode> SearchedNodes = new List<UCalliopeNode>();
			DepthFirstSearchGuideNode(value2, ref GuideGroupList, ref SearchedNodes);
		}
		return GuideGroupList;
	}

	private UCalliopeNode GetInitialNodeNextNode()
	{
		BED_CalliopeAssetBase assetInCS = GetAssetInCS();
		UCalliopeNode uCalliopeNode = assetInCS.Nodes.Values.First((UCalliopeNode node) => node is BED_GuideNode_Initial);
		if (assetInCS.Nodes.TryGetValue(uCalliopeNode.GetConnections().FirstOrDefault().Value.NodeGuid, out var value))
		{
			return value;
		}
		return null;
	}

	private bool CheckNeedSearch()
	{
		return true;
	}

	private void DepthFirstSearchGuideNode(UCalliopeNode CurrentNode, ref List<int> GuideGroupList, ref List<UCalliopeNode> SearchedNodes, int Depth = 0)
	{
		if (Depth++ > 20)
		{
			_isExceedingDepth = true;
		}
		else
		{
			if (CurrentNode == null || CurrentNode == this || CurrentNode == GetInitialNodeNextNode() || SearchedNodes.Contains(CurrentNode))
			{
				return;
			}
			SearchedNodes.Add(CurrentNode);
			if (CurrentNode is BED_GuideNode_Mark bED_GuideNode_Mark)
			{
				GuideGroupList.Add(bED_GuideNode_Mark.GuildGroupId);
			}
			if (!CurrentNode.GetConnections().Any())
			{
				return;
			}
			BED_CalliopeAssetBase assetInCS = GetAssetInCS();
			if (assetInCS == null)
			{
				return;
			}
			foreach (FCalliopeConnectedPin value2 in CurrentNode.GetConnections().Values)
			{
				if (assetInCS.Nodes.TryGetValue(value2.NodeGuid, out var value))
				{
					DepthFirstSearchGuideNode(value, ref GuideGroupList, ref SearchedNodes, Depth);
				}
			}
		}
	}

	public override bool CorrectnessCheck(out string OutErrorMessage)
	{
		if (_isExceedingDepth)
		{
			OutErrorMessage = "超过了允许深度，麻烦找程序确认";
			_isExceedingDepth = false;
			return false;
		}
		foreach (FCompositeTransitionCondition_Guide transitionCondition in TransitionConditions)
		{
			if (transitionCondition.bUseCompositeCondition)
			{
				foreach (FTransitionCondition_Guide condition in transitionCondition.Conditions)
				{
					if (condition.ConditionType == ETransitionConditionType_Guide.None)
					{
						OutErrorMessage = "存在Condition为None的条件，请删除";
						return false;
					}
				}
			}
			else if (transitionCondition.Single.ConditionType == ETransitionConditionType_Guide.None)
			{
				OutErrorMessage = "存在Condition为None的条件，请删除";
				return false;
			}
		}
		return base.CorrectnessCheck(out OutErrorMessage);
	}

	private List<CalliopeCustom_ManagedSceneObj> MakeManagedSceneObjCustomData()
	{
		List<CalliopeCustom_ManagedSceneObj> list = new List<CalliopeCustom_ManagedSceneObj>();
		foreach (FGsDynamicObstaclePoliceConfig item in base.SceneObjPoliceConfig.DynamicObstacleCollection)
		{
			CalliopeCustom_ManagedSceneObj obj = new CalliopeCustom_ManagedSceneObj
			{
				ObjType = ManagedSceneObjType.DynamicObstacle
			};
			Guid configGuid = item.ConfigGuid;
			obj.ObjGuid = configGuid.ToString();
			obj.DefaultState = (int)item.DefaultState;
			obj.ManagePolice = (int)item.ActualManagePolice;
			list.Add(obj);
		}
		foreach (FGsOverlapPoliceConfig item2 in base.SceneObjPoliceConfig.OverlapCollection)
		{
			CalliopeCustom_ManagedSceneObj obj2 = new CalliopeCustom_ManagedSceneObj
			{
				ObjType = ManagedSceneObjType.Overlap
			};
			Guid configGuid = item2.ConfigGuid;
			obj2.ObjGuid = configGuid.ToString();
			obj2.DefaultState = (int)item2.DefaultState;
			obj2.ManagePolice = (int)item2.ActualManagePolice;
			list.Add(obj2);
		}
		foreach (FGsSpawnerPoliceConfig item3 in base.SceneObjPoliceConfig.SpawnerCollection)
		{
			CalliopeCustom_ManagedSceneObj obj3 = new CalliopeCustom_ManagedSceneObj
			{
				ObjType = ManagedSceneObjType.Spawner
			};
			Guid configGuid = item3.ConfigGuid;
			obj3.ObjGuid = configGuid.ToString();
			obj3.DefaultState = (int)item3.DefaultState;
			obj3.ManagePolice = (int)item3.ActualManagePolice;
			list.Add(obj3);
		}
		foreach (FGsUnitPoliceConfig item4 in base.SceneObjPoliceConfig.UnitCollection)
		{
			CalliopeCustom_ManagedSceneObj obj4 = new CalliopeCustom_ManagedSceneObj
			{
				ObjType = ManagedSceneObjType.Unit
			};
			Guid configGuid = item4.ConfigGuid;
			obj4.ObjGuid = configGuid.ToString();
			obj4.DefaultState = (int)item4.DefaultState;
			obj4.ManagePolice = (int)item4.ActualManagePolice;
			list.Add(obj4);
		}
		foreach (FGsStreamingLevelPoliceConfig item5 in base.SceneObjPoliceConfig.StreamingLevelCollection)
		{
			CalliopeCustom_ManagedSceneObj obj5 = new CalliopeCustom_ManagedSceneObj
			{
				ObjType = ManagedSceneObjType.StreamingLevel
			};
			Guid configGuid = item5.ConfigGuid;
			obj5.ObjGuid = configGuid.ToString();
			obj5.DefaultState = (int)item5.DefaultState;
			obj5.ManagePolice = (int)item5.ActualManagePolice;
			list.Add(obj5);
		}
		return list;
	}

	private List<CalliopeCustom_ManagedNPCUnit> MakeManagedNPCUnitCustomData()
	{
		List<CalliopeCustom_ManagedNPCUnit> list = new List<CalliopeCustom_ManagedNPCUnit>();
		foreach (FGsNPCUnitPoliceConfig NPCUnit in base.SceneObjPoliceConfig.NPCUnitCollection)
		{
			CalliopeCustom_ManagedNPCUnit calliopeCustom_ManagedNPCUnit = new CalliopeCustom_ManagedNPCUnit();
			Guid configGuid = NPCUnit.ConfigGuid;
			calliopeCustom_ManagedNPCUnit.NpcGuid = configGuid.ToString();
			calliopeCustom_ManagedNPCUnit.TeamIdValue = new ManagedNPCUnitParam
			{
				DefaultValue = NPCUnit.ManagedTeamID.DefaultParam,
				ManagedValue = NPCUnit.ManagedTeamID.ActualParam
			};
			ManagedSmartParam managedSmartParam = new ManagedSmartParam();
			configGuid = NPCUnit.ManagedTeamIDParam.DefaultParam.ConfigGuid;
			managedSmartParam.DefaultValue = configGuid.ToString();
			configGuid = NPCUnit.ManagedTeamIDParam.ActualParam.ConfigGuid;
			managedSmartParam.ManagedValue = configGuid.ToString();
			calliopeCustom_ManagedNPCUnit.TeamIdParamValue = managedSmartParam;
			calliopeCustom_ManagedNPCUnit.IdleAmIdxValue = new ManagedNPCUnitParam
			{
				DefaultValue = NPCUnit.ManagedIdleAMIdx.DefaultParam,
				ManagedValue = NPCUnit.ManagedIdleAMIdx.ActualParam
			};
			ManagedSmartParam managedSmartParam2 = new ManagedSmartParam();
			configGuid = NPCUnit.ManagedIdleAMIdxParam.DefaultParam.ConfigGuid;
			managedSmartParam2.DefaultValue = configGuid.ToString();
			configGuid = NPCUnit.ManagedIdleAMIdxParam.ActualParam.ConfigGuid;
			managedSmartParam2.ManagedValue = configGuid.ToString();
			calliopeCustom_ManagedNPCUnit.IdleAmIdxParamValue = managedSmartParam2;
			calliopeCustom_ManagedNPCUnit.LeisureAnimIndexValue = new ManagedNPCUnitParam
			{
				DefaultValue = NPCUnit.ManagedLeisureAnimIndex.DefaultParam,
				ManagedValue = NPCUnit.ManagedLeisureAnimIndex.ActualParam
			};
			ManagedSmartParam managedSmartParam3 = new ManagedSmartParam();
			configGuid = NPCUnit.ManagedLeisureAnimIndexParam.DefaultParam.ConfigGuid;
			managedSmartParam3.DefaultValue = configGuid.ToString();
			configGuid = NPCUnit.ManagedLeisureAnimIndexParam.ActualParam.ConfigGuid;
			managedSmartParam3.ManagedValue = configGuid.ToString();
			calliopeCustom_ManagedNPCUnit.LeisureAnimIndexParamValue = managedSmartParam3;
			calliopeCustom_ManagedNPCUnit.InteractGroupIdValue = new ManagedNPCUnitParam
			{
				DefaultValue = NPCUnit.ManagedInteractGroupID.DefaultParam,
				ManagedValue = NPCUnit.ManagedInteractGroupID.ActualParam
			};
			ManagedSmartParam managedSmartParam4 = new ManagedSmartParam();
			configGuid = NPCUnit.ManagedInteractGroupIDParam.DefaultParam.ConfigGuid;
			managedSmartParam4.DefaultValue = configGuid.ToString();
			configGuid = NPCUnit.ManagedInteractGroupIDParam.ActualParam.ConfigGuid;
			managedSmartParam4.ManagedValue = configGuid.ToString();
			calliopeCustom_ManagedNPCUnit.InteractGroupIdParamValue = managedSmartParam4;
			calliopeCustom_ManagedNPCUnit.ShowStateValue = new ManagedNPCUnitParam
			{
				DefaultValue = (int)NPCUnit.ManagedShowState.DefaultParam,
				ManagedValue = (int)NPCUnit.ManagedShowState.ActualParam
			};
			ManagedNPCUnitActiveInstanceParam managedNPCUnitActiveInstanceParam = new ManagedNPCUnitActiveInstanceParam();
			configGuid = NPCUnit.ManagedActiveInstance.ActualParam;
			managedNPCUnitActiveInstanceParam.DefaultValue = configGuid.ToString();
			configGuid = NPCUnit.ManagedActiveInstance.ActualParam;
			managedNPCUnitActiveInstanceParam.ManagedValue = configGuid.ToString();
			calliopeCustom_ManagedNPCUnit.ActiveInstanceValue = managedNPCUnitActiveInstanceParam;
			CalliopeCustom_ManagedNPCUnit calliopeCustom_ManagedNPCUnit2 = calliopeCustom_ManagedNPCUnit;
			foreach (FGsNPCUnitBuffParamConfig BuffIDInfo in NPCUnit.ManagedBuffIDList)
			{
				if (GetCalliopeAsset().CalliopeParameters.BuffIDCollection.FindIndex((FGsManagedBuffID r) => r.ConfigGuid == BuffIDInfo.ConfigGuid && r.NPCUnit.ConfigGuides.Contains(NPCUnit.ConfigGuid)) != -1)
				{
					RepeatedField<ManagedNPCUnitBuffParam> buffInfoList = calliopeCustom_ManagedNPCUnit2.BuffInfoList;
					ManagedNPCUnitBuffParam managedNPCUnitBuffParam = new ManagedNPCUnitBuffParam();
					configGuid = BuffIDInfo.ConfigGuid;
					managedNPCUnitBuffParam.BuffParamId = configGuid.ToString();
					managedNPCUnitBuffParam.DefaultValue = (int)BuffIDInfo.DefaultParam;
					managedNPCUnitBuffParam.ManagedValue = (int)BuffIDInfo.ActualParam;
					buffInfoList.Add(managedNPCUnitBuffParam);
				}
			}
			list.Add(calliopeCustom_ManagedNPCUnit2);
		}
		return list;
	}

	private List<CalliopeCustom_ManagedGroupUnit> MakeManagedGroupUnitCustomData()
	{
		List<CalliopeCustom_ManagedGroupUnit> list = new List<CalliopeCustom_ManagedGroupUnit>();
		foreach (FGsUnitPoliceConfig item in base.SceneObjPoliceConfig.GroupUnitCollection)
		{
			CalliopeCustom_ManagedGroupUnit calliopeCustom_ManagedGroupUnit = new CalliopeCustom_ManagedGroupUnit();
			Guid configGuid = item.ConfigGuid;
			calliopeCustom_ManagedGroupUnit.ObjGuid = configGuid.ToString();
			calliopeCustom_ManagedGroupUnit.DefaultState = (int)item.DefaultState;
			calliopeCustom_ManagedGroupUnit.ManagePolice = (int)item.ActualManagePolice;
			list.Add(calliopeCustom_ManagedGroupUnit);
		}
		return list;
	}

	private List<CalliopeCustom_ManagedStreamingLevelStateConfig> MakeManagedStreamingLevelStateConfigCustomData()
	{
		List<CalliopeCustom_ManagedStreamingLevelStateConfig> list = new List<CalliopeCustom_ManagedStreamingLevelStateConfig>();
		foreach (FGsStreamingLevelStateConfigPoliceConfig item2 in base.SceneObjPoliceConfig.StreamingLevelStateConfigCollection)
		{
			CalliopeCustom_ManagedStreamingLevelStateConfig calliopeCustom_ManagedStreamingLevelStateConfig = new CalliopeCustom_ManagedStreamingLevelStateConfig();
			Guid configGuid = item2.ConfigGuid;
			calliopeCustom_ManagedStreamingLevelStateConfig.ConfigGuid = configGuid.ToString();
			calliopeCustom_ManagedStreamingLevelStateConfig.DataAssetIdValue = new ManagedStreamingLevelStateConfigParam
			{
				DefaultValue = item2.ManagedDataAssetID.DefaultParam,
				ManagedValue = item2.ManagedDataAssetID.ActualParam
			};
			CalliopeCustom_ManagedStreamingLevelStateConfig item = calliopeCustom_ManagedStreamingLevelStateConfig;
			list.Add(item);
		}
		return list;
	}

	private List<CalliopeCustom_ManagedInteractor> MakeManagedInteractorCustomData()
	{
		List<CalliopeCustom_ManagedInteractor> list = new List<CalliopeCustom_ManagedInteractor>();
		foreach (FGsInteractorPoliceConfig item in base.SceneObjPoliceConfig.InteractorCollection)
		{
			CalliopeCustom_ManagedInteractor calliopeCustom_ManagedInteractor = new CalliopeCustom_ManagedInteractor();
			Guid configGuid = item.ConfigGuid;
			calliopeCustom_ManagedInteractor.ObjGuid = configGuid.ToString();
			calliopeCustom_ManagedInteractor.GroupId = item.ActualValue.ConfigGuid.ToString();
			list.Add(calliopeCustom_ManagedInteractor);
		}
		return list;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_GuideNode_Listener:GetContextOutputsInCS")]
	private static void GetContextOutputsInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_GuideNode_Listener bED_GuideNode_Listener = GCHelper.Find<BED_GuideNode_Listener>(obj);
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetContextOutputsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> contextOutputsInCS_Implementation = bED_GuideNode_Listener.GetContextOutputsInCS_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetContextOutputsInCS_ReturnValue_Offset), contextOutputsInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_GuideNode_Listener");
		NativeReflection.GetPropertyRef(ref TransitionConditions_PropertyAddress, intPtr, "TransitionConditions");
		TransitionConditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "TransitionConditions");
		TransitionConditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TransitionConditions", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RelatedGuideGroupList_PropertyAddress, intPtr, "RelatedGuideGroupList");
		RelatedGuideGroupList_Offset = NativeReflection.GetPropertyOffset(intPtr, "RelatedGuideGroupList");
		RelatedGuideGroupList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RelatedGuideGroupList", Classes.FMapProperty);
		GetContextOutputsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContextOutputsInCS");
		GetContextOutputsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContextOutputsInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetContextOutputsInCS_ReturnValue_PropertyAddress, GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetContextOutputsInCS_FunctionAddress, "ReturnValue");
		GetContextOutputsInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetContextOutputsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContextOutputsInCS_IsValid = GetContextOutputsInCS_FunctionAddress != IntPtr.Zero && GetContextOutputsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_GuideNode_Listener:GetContextOutputsInCS", GetContextOutputsInCS_IsValid);
	}

	static BED_GuideNode_Listener()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_GuideNode_Listener)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_GuideNode_Listener));
	}
}
