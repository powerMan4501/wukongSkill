using System;
using System.Collections.Generic;
using System.Linq;
using ArchiveB1;
using b1.BGW;
using b1.CppExport;
using b1.ECS;
using b1.EventDelDefine;
using b1.Plugins.Calliope;
using BtlB1;
using BtlShare;
using CommB1;
using Google.Protobuf.Collections;
using UnrealEngine.Runtime;

namespace b1;

public class BIS_StateMachineManager : GameInstanceSystemBase, ICheckGraphDataQueryable
{
	private struct FPsmInstanceCreationParam
	{
		public readonly int Id;

		public readonly string GraphPath;

		public readonly bool IsEnableByDefault;

		public readonly string DataAssetPath;

		public readonly bool IsForDebug;

		public FPsmInstanceCreationParam(FUStCustomStateMachineDesc CustomStateMachineDesc)
		{
			Id = CustomStateMachineDesc.ID;
			GraphPath = CustomStateMachineDesc.GraphPath;
			IsEnableByDefault = CustomStateMachineDesc.IsEnableByDefault == EGSYesNo.Yes;
			DataAssetPath = CustomStateMachineDesc.DataAssetPath;
			IsForDebug = false;
		}

		public FPsmInstanceCreationParam(FUStGuideAssetConfigDesc GuideAssetConfigDesc)
		{
			Id = GuideAssetConfigDesc.Id;
			GraphPath = GuideAssetConfigDesc.AssetPath;
			IsEnableByDefault = true;
			DataAssetPath = string.Empty;
			IsForDebug = GuideAssetConfigDesc.IsForDebug == EGSYesNo.Yes;
		}
	}

	private static List<PsmInstance> sPsmInstanceLoopCache = new List<PsmInstance>();

	public override bool bTickEnabled => true;

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	private BIC_StateMachineData StateMachineData { get; set; }

	private IBIC_LevelData LevelData { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	public override void OnAttach()
	{
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		StateMachineData = RequireWritableGameInstanceData<BIC_StateMachineData>();
		LevelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		EventCollection = BGW_EventCollection.Get(base.Owner);
		StateMachineData.Owner = base.Owner;
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_TriggerPsmEvent = (Del_Void_StringGameplayTag)Delegate.Combine(eventCollection.Evt_TriggerPsmEvent, new Del_Void_StringGameplayTag(OnTriggerPsmEvent));
			BGW_EventCollection eventCollection2 = EventCollection;
			eventCollection2.Evt_RegisterPsmInstance = (Del_Void_StringPsmInstance)Delegate.Combine(eventCollection2.Evt_RegisterPsmInstance, new Del_Void_StringPsmInstance(OnRegisterPsmInstance));
			BGW_EventCollection eventCollection3 = EventCollection;
			eventCollection3.Evt_UnregisterPsmInstance = (Del_Void_String)Delegate.Combine(eventCollection3.Evt_UnregisterPsmInstance, new Del_Void_String(OnUnregisterPsmInstance));
			BGW_EventCollection eventCollection4 = EventCollection;
			eventCollection4.Evt_ResetPsmInstances = (Del_Void)Delegate.Combine(eventCollection4.Evt_ResetPsmInstances, new Del_Void(OnResetPsmInstances));
			BGW_EventCollection eventCollection5 = EventCollection;
			eventCollection5.Evt_RecoverStateMachineArchiveData = (BGW_EventCollection.Del_Void_StateMachineArchiveData)Delegate.Combine(eventCollection5.Evt_RecoverStateMachineArchiveData, new BGW_EventCollection.Del_Void_StateMachineArchiveData(OnRecoverStateMachineArchiveData));
			BGW_EventCollection eventCollection6 = EventCollection;
			eventCollection6.Evt_RequestUpdateStateMachineArchiveData = (Del_Void)Delegate.Combine(eventCollection6.Evt_RequestUpdateStateMachineArchiveData, new Del_Void(OnRequestUpdateStateMachineArchiveData));
			BGW_EventCollection eventCollection7 = EventCollection;
			eventCollection7.Evt_SaveSceneObjState = (Del_Void_StringGameplayTagContainerGameplayTag)Delegate.Combine(eventCollection7.Evt_SaveSceneObjState, new Del_Void_StringGameplayTagContainerGameplayTag(SaveSceneObjState));
			BGW_EventCollection eventCollection8 = EventCollection;
			eventCollection8.Evt_SaveSceneObjAllStates = (Del_Void_StringGameplayTagContainerGameplayTagContainer)Delegate.Combine(eventCollection8.Evt_SaveSceneObjAllStates, new Del_Void_StringGameplayTagContainerGameplayTagContainer(SaveSceneObjAllStates));
			BGW_EventCollection eventCollection9 = EventCollection;
			eventCollection9.Evt_RecordSceneObjState = (Del_Void_StringGameplayTagContainerGameplayTag)Delegate.Combine(eventCollection9.Evt_RecordSceneObjState, new Del_Void_StringGameplayTagContainerGameplayTag(RecordSceneObjState));
			BGW_EventCollection eventCollection10 = EventCollection;
			eventCollection10.Evt_SaveSceneObjEvent = (Del_Void_StringGameplayTag)Delegate.Combine(eventCollection10.Evt_SaveSceneObjEvent, new Del_Void_StringGameplayTag(SaveSceneObjEvent));
			BGW_EventCollection eventCollection11 = EventCollection;
			eventCollection11.Evt_ClearUnhandledSceneObjEvents = (Del_Void_StringGameplayTagList)Delegate.Combine(eventCollection11.Evt_ClearUnhandledSceneObjEvents, new Del_Void_StringGameplayTagList(ClearUnhandledSceneObjEvents));
			BGW_EventCollection eventCollection12 = EventCollection;
			eventCollection12.Evt_ClearAllSceneObjState = (Del_Void)Delegate.Combine(eventCollection12.Evt_ClearAllSceneObjState, new Del_Void(ClearAllSceneObjState));
			BGW_EventCollection eventCollection13 = EventCollection;
			eventCollection13.Evt_ClearOverrideSceneObjStates = (Del_Void)Delegate.Combine(eventCollection13.Evt_ClearOverrideSceneObjStates, new Del_Void(OnClearOverrideSceneObjStates));
			BGW_EventCollection eventCollection14 = EventCollection;
			eventCollection14.Evt_SendSceneObjEvent = (Del_Void_StringGameplayTag)Delegate.Combine(eventCollection14.Evt_SendSceneObjEvent, new Del_Void_StringGameplayTag(OnSendSceneObjEvent));
			BGW_EventCollection eventCollection15 = EventCollection;
			eventCollection15.Evt_SetSceneObjState = (Del_Void_StringGameplayTag)Delegate.Combine(eventCollection15.Evt_SetSceneObjState, new Del_Void_StringGameplayTag(OnSetSceneObjState));
			BGW_EventCollection eventCollection16 = EventCollection;
			eventCollection16.Evt_RequestCleanupCachedStates = (Del_Void_String)Delegate.Combine(eventCollection16.Evt_RequestCleanupCachedStates, new Del_Void_String(OnRequestCleanupCachedStates));
			BGW_EventCollection eventCollection17 = EventCollection;
			eventCollection17.Evt_RegisterIdleProcessAction = (BGW_EventCollection.Del_RegisterIdleProcessAction)Delegate.Combine(eventCollection17.Evt_RegisterIdleProcessAction, new BGW_EventCollection.Del_RegisterIdleProcessAction(RegisterIdleProcessActions));
			BGW_EventCollection eventCollection18 = EventCollection;
			eventCollection18.Evt_RunIdleProcessActions = (BGW_EventCollection.Del_Void_PsmNodeInstance)Delegate.Combine(eventCollection18.Evt_RunIdleProcessActions, new BGW_EventCollection.Del_Void_PsmNodeInstance(RunIdleProcessActions));
			BGW_EventCollection eventCollection19 = EventCollection;
			eventCollection19.Evt_ResetRunIdleProcessActions = (BGW_EventCollection.Del_Void_PsmNodeInstance)Delegate.Combine(eventCollection19.Evt_ResetRunIdleProcessActions, new BGW_EventCollection.Del_Void_PsmNodeInstance(ResetRunIdleProcessActions));
			BGW_EventCollection eventCollection20 = EventCollection;
			eventCollection20.Evt_RecoverRunIdleProcessActions = (BGW_EventCollection.Del_Void_PsmNodeInstance)Delegate.Combine(eventCollection20.Evt_RecoverRunIdleProcessActions, new BGW_EventCollection.Del_Void_PsmNodeInstance(RecoverRunIdleProcessActions));
			BGW_EventCollection eventCollection21 = EventCollection;
			eventCollection21.Evt_ShutdownIdleProcessActions = (BGW_EventCollection.Del_Void_PsmNodeInstance)Delegate.Combine(eventCollection21.Evt_ShutdownIdleProcessActions, new BGW_EventCollection.Del_Void_PsmNodeInstance(ShutdownRunIdleProcessActions));
			BGW_EventCollection eventCollection22 = EventCollection;
			eventCollection22.Evt_SetProcessGraphPaused = (Del_Void_Bool)Delegate.Combine(eventCollection22.Evt_SetProcessGraphPaused, new Del_Void_Bool(SetProcessGraphPaused));
			if (DebugConfig.EnableUseNewTimelineForCPG)
			{
				BGW_EventCollection eventCollection23 = EventCollection;
				eventCollection23.Evt_GSLoginFinish = (Del_Void)Delegate.Combine(eventCollection23.Evt_GSLoginFinish, new Del_Void(OnGSLoginFinish));
			}
			else
			{
				BGW_EventCollection eventCollection24 = EventCollection;
				eventCollection24.Evt_PlayerDelayBeginPlayFinished = (Del_Void)Delegate.Combine(eventCollection24.Evt_PlayerDelayBeginPlayFinished, new Del_Void(OnGSLoginFinish));
			}
			BGW_EventCollection eventCollection25 = EventCollection;
			eventCollection25.Evt_SetStateMachineNeedReset = (Del_Void_StringBool)Delegate.Combine(eventCollection25.Evt_SetStateMachineNeedReset, new Del_Void_StringBool(OnSetStateMachineNeedReset));
			BGW_EventCollection eventCollection26 = EventCollection;
			eventCollection26.Evt_ClearStateMachineNeedReset = (Del_Void)Delegate.Combine(eventCollection26.Evt_ClearStateMachineNeedReset, new Del_Void(OnClearStateMachineNeedReset));
			BGW_EventCollection eventCollection27 = EventCollection;
			eventCollection27.Evt_ResetGameInstanceData = (BGW_EventCollection.Del_BGW_ResetGameInstanceData)Delegate.Combine(eventCollection27.Evt_ResetGameInstanceData, new BGW_EventCollection.Del_BGW_ResetGameInstanceData(OnReSetGameData));
			BGW_EventCollection eventCollection28 = EventCollection;
			eventCollection28.Evt_ClearAllGameData = (Del_Void)Delegate.Combine(eventCollection28.Evt_ClearAllGameData, new Del_Void(ClearGameData));
		}
	}

	private bool IsNetClient()
	{
		return BGW_GameArchiveMgr.IsNetClient(base.Owner);
	}

	public override void OnInit()
	{
		StateMachineData.bInitialCustomStateMachines = false;
		StateMachineData.PsmArchiveDataCache.Clear();
		StateMachineData.StateCaches.Clear();
		FGSStateFactory.GetAllInstances(out var OutAllInstances);
		foreach (KeyValuePair<Type, BUS_StateMachineCompBase.GSStateBase> item in OutAllInstances)
		{
			BUS_StateMachineCompBase.GSStateBase value = item.Value;
			if (value != null)
			{
				value.OnInitialize();
				StateMachineData.StateCaches.Add(item.Key, value);
			}
		}
	}

	private void OnSetStateMachineNeedReset(string UnitGuid, bool bNeedReset)
	{
		if (!string.IsNullOrEmpty(UnitGuid))
		{
			StateMachineData.StateMachineNeedReset[UnitGuid] = bNeedReset;
		}
	}

	private void OnClearStateMachineNeedReset()
	{
		StateMachineData.StateMachineNeedReset.Clear();
	}

	private void OnGSLoginFinish()
	{
		if (DebugConfig.EnablePlaneMoveMode || IsNetClient() || B1Global.GIsBossRushMode || StateMachineData.bInitialCustomStateMachines)
		{
			return;
		}
		StateMachineData.bInitialCustomStateMachines = true;
		if (BGW_GameDB.GetAllCustomStateMachineDesc(out var CustomStateMachineDescList))
		{
			foreach (FUStCustomStateMachineDesc item in CustomStateMachineDescList)
			{
				CreatePsmInstanceAndStart(new FPsmInstanceCreationParam(item));
			}
		}
		if (BGW_GameDB.GetAllGuideAssetConfigDesc(out var GuideAssetConfigDescList))
		{
			foreach (FUStGuideAssetConfigDesc item2 in GuideAssetConfigDescList)
			{
				CreatePsmInstanceAndStart(new FPsmInstanceCreationParam(item2));
			}
		}
		BGUFunctionLibraryCS.BlockTillLevelStreamingCompleted(base.Owner);
	}

	private void CreatePsmInstanceAndStart(FPsmInstanceCreationParam Param)
	{
		List<PsmInstance> list = new List<PsmInstance>();
		if (string.IsNullOrEmpty(Param.GraphPath) || !Param.IsEnableByDefault || Param.IsForDebug)
		{
			return;
		}
		if (!string.IsNullOrEmpty(Param.DataAssetPath))
		{
			UCalliopeParameterMappingDataAsset uCalliopeParameterMappingDataAsset = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UCalliopeParameterMappingDataAsset>(Param.DataAssetPath, ELoadResourceType.SyncLoadAndCache);
			if (uCalliopeParameterMappingDataAsset != null)
			{
				if (uCalliopeParameterMappingDataAsset.RunTemplateInstance)
				{
					list.Add(PsmInstance.Create(null, Param.GraphPath, base.Owner, Param.Id.ToString(), "BIS"));
				}
				uCalliopeParameterMappingDataAsset.RefreshGroupsParameterValue();
				foreach (FCalliopeParameterMappingGroup group in uCalliopeParameterMappingDataAsset.Groups)
				{
					object arg = Param.Id;
					Guid groupGuid = group.GroupGuid;
					string inPsmGuid = $"{arg}_{groupGuid.ToString()}_{group.Comment}";
					PsmInstance psmInstance = PsmInstance.Create(null, Param.GraphPath, base.Owner, inPsmGuid, group.Comment, "BIS");
					foreach (FCalliopeParameterMapping mapping in group.Mappings)
					{
						if (!mapping.KeepOriginal)
						{
							psmInstance.RegisterParameterOverride(mapping.ParamGuid, mapping.ParamType, mapping.ParameterString, mapping.ParameterInt, mapping.ParameterArrayInt, group.Comment);
						}
					}
					list.Add(psmInstance);
				}
			}
		}
		if (list.Count == 0)
		{
			list.Add(PsmInstance.Create(null, Param.GraphPath, base.Owner, Param.Id.ToString(), null, "BIS"));
		}
		foreach (PsmInstance item in list)
		{
			if (item != null)
			{
				if (StateMachineData.PsmArchiveDataCache.TryGetValue(item.PsmGuid, out var value))
				{
					item.SetRecoverData(value);
				}
				else
				{
					item.OnGraphStart();
				}
			}
		}
		list.Clear();
	}

	public void CheckGraphDataQueryable(out Dictionary<string, List<string>> UnsafeNodeInfoDic)
	{
		UnsafeNodeInfoDic = new Dictionary<string, List<string>>();
		if (!BGW_GameDB.GetAllCustomStateMachineDesc(out var CustomStateMachineDescList))
		{
			return;
		}
		foreach (FUStCustomStateMachineDesc item in CustomStateMachineDescList)
		{
			if (string.IsNullOrEmpty(item.GraphPath) || item.IsEnableByDefault != EGSYesNo.Yes)
			{
				continue;
			}
			string inPsmGuid = item.ID.ToString();
			PsmInstance psmInstance = PsmInstance.Create(null, item.GraphPath, base.Owner, inPsmGuid);
			string graphPath = item.GraphPath;
			int num = graphPath.LastIndexOf('.');
			string key = graphPath.Substring(num + 1);
			foreach (PsmStateNodeInstance psmStateNodeInstance in psmInstance.GetPsmStateNodeInstances())
			{
				if (!psmStateNodeInstance.CheckNodeQueryable(out var ErrorMassager))
				{
					if (UnsafeNodeInfoDic.TryGetValue(key, out var value))
					{
						value.Add(psmStateNodeInstance.Node.NodeClass + "存在风险，原因可能是：" + ErrorMassager + "\n");
						continue;
					}
					List<string> list = new List<string>();
					list.Add(psmStateNodeInstance.Node.NodeClass + "存在风险，原因可能是：" + ErrorMassager + "\n");
					UnsafeNodeInfoDic.Add(key, list);
				}
			}
			foreach (PsmNodeInstance value3 in psmInstance.GetNodeInstances().Values)
			{
				if (!value3.CheckNodeQueryable(out var ErrorMassager2))
				{
					if (UnsafeNodeInfoDic.TryGetValue(key, out var value2))
					{
						value2.Add(value3.Node.NodeClass + "存在风险，原因可能是：" + ErrorMassager2 + "\n");
						continue;
					}
					List<string> list2 = new List<string>();
					list2.Add(value3.Node.NodeClass + "存在风险，原因可能是：" + ErrorMassager2 + "\n");
					UnsafeNodeInfoDic.Add(key, list2);
				}
			}
		}
	}

	public static BIS_StateMachineManager Get(UObject WorldCtx)
	{
		return BGWGameInstanceCS.GetObject<BIS_StateMachineManager>(WorldCtx);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!IsNetClient() && (!StateMachineData.bPaused || GSGameplayCVar.CVar_ForceProcessGraphTick.GetValueInGameThread() != 0))
		{
			FGuardConditionBase.CommonData.UpdateData_PreTick(base.Owner);
			List<PsmInstance> list = sPsmInstanceLoopCache;
			GCFriendlyListCopyHelper.DoCopy(StateMachineData.PsmInstances, sPsmInstanceLoopCache);
			foreach (PsmInstance item in list)
			{
				item?.OnGraphTick(DeltaTime, LevelData.bOpeningLevel);
			}
			FGuardConditionBase.CommonData.ReleaseData_BeforePostUpdateWork();
		}
		EventCollection.Evt_CallTickForMovieSystem(DeltaTime);
	}

	private void SetProcessGraphPaused(bool bInPaused)
	{
		StateMachineData.bPaused = bInPaused;
	}

	private void OnReSetGameData(EGameInstanceResetType ResetType)
	{
		StateMachineData.bInitialCustomStateMachines = false;
		ClearStateMachineData();
	}

	private void ClearGameData()
	{
		ClearStateMachineData();
	}

	private void ClearStateMachineData()
	{
		foreach (PsmInstance item in StateMachineData.PsmInstances.Values.ToList())
		{
			item.Shutdown();
		}
		StateMachineData.PsmArchiveDataCache.Clear();
		StateMachineData.PsmInstances.Clear();
		StateMachineData.SceneObjState.Clear();
		StateMachineData.SceneObjTransientState.Clear();
		StateMachineData.SceneObjEvent.Clear();
		StateMachineData.SceneObjStateCache.Clear();
		sPsmInstanceLoopCache.Clear();
	}

	private void OnRegisterPsmInstance(string PsmGuid, PsmInstance Instance)
	{
		StateMachineData.PsmInstances[PsmGuid] = Instance;
	}

	private void OnUnregisterPsmInstance(string PsmGuid)
	{
		if (StateMachineData.PsmInstances.ContainsKey(PsmGuid))
		{
			StateMachineData.PsmInstances.Remove(PsmGuid);
		}
	}

	private void OnTriggerPsmEvent(string PsmGuid, FGameplayTag EventTag)
	{
		if (StateMachineData.PsmInstances.TryGetValue(PsmGuid, out var value))
		{
			value.OnEvent(EventTag);
		}
	}

	private void OnResetPsmInstances()
	{
		foreach (KeyValuePair<string, PsmInstance> psmInstance in StateMachineData.PsmInstances)
		{
			psmInstance.Value?.OnReset();
		}
	}

	private void OnRecoverStateMachineArchiveData(StateMachineArchiveData ArchiveData)
	{
		if (StateMachineData.bInitialCustomStateMachines)
		{
			foreach (PsmArchiveGraphData psmArchiveDatum in ArchiveData.PsmArchiveData)
			{
				if (StateMachineData.PsmInstances.TryGetValue(psmArchiveDatum.PsmId, out var value))
				{
					value.SetRecoverData(psmArchiveDatum);
				}
			}
		}
		else
		{
			foreach (PsmArchiveGraphData psmArchiveDatum2 in ArchiveData.PsmArchiveData)
			{
				StateMachineData.PsmArchiveDataCache.Add(psmArchiveDatum2.PsmId, psmArchiveDatum2);
			}
		}
		LevelArchiveSceneObjData sceneObjData = ArchiveData.SceneObjData;
		if (sceneObjData != null)
		{
			foreach (LevelArchiveSceneObjStateData stateDatum in sceneObjData.StateData)
			{
				GameplayTagContainerRef gameplayTagContainerRef = new GameplayTagContainerRef();
				foreach (string item in stateDatum.ObjState)
				{
					gameplayTagContainerRef.AddTag(GameplayTagExtension.MakeGameplayTag(item));
				}
				StateMachineData.SceneObjState[stateDatum.ObjGuid] = gameplayTagContainerRef;
			}
			foreach (LevelArchiveSceneObjEventData eventDatum in sceneObjData.EventData)
			{
				List<FGameplayTag> list = new List<FGameplayTag>();
				foreach (string item2 in eventDatum.ObjEvent)
				{
					list.Add(GameplayTagExtension.MakeGameplayTag(item2));
				}
				StateMachineData.SceneObjEvent[eventDatum.ObjGuid] = list;
			}
		}
		if (EventCollection != null)
		{
			EventCollection.Evt_ClearStateMachineNeedReset();
		}
	}

	private void OnRequestUpdateStateMachineArchiveData()
	{
		StateMachineArchiveData stateMachineArchiveData = new StateMachineArchiveData();
		foreach (KeyValuePair<string, PsmInstance> psmInstance in StateMachineData.PsmInstances)
		{
			PsmArchiveGraphData psmArchiveGraphData = psmInstance.Value?.GetRecoverData();
			if (psmArchiveGraphData != null)
			{
				stateMachineArchiveData.PsmArchiveData.Add(psmArchiveGraphData);
			}
		}
		LevelArchiveSceneObjData levelArchiveSceneObjData = new LevelArchiveSceneObjData();
		levelArchiveSceneObjData.StateData.Clear();
		foreach (KeyValuePair<string, GameplayTagContainerRef> item in StateMachineData.SceneObjState)
		{
			item.Value.GetAllTagStrList(out var TagStrList);
			LevelArchiveSceneObjStateData levelArchiveSceneObjStateData = new LevelArchiveSceneObjStateData();
			levelArchiveSceneObjStateData.ObjGuid = item.Key;
			levelArchiveSceneObjStateData.ObjState.Clear();
			levelArchiveSceneObjStateData.ObjState.AddRange(TagStrList);
			levelArchiveSceneObjData.StateData.Add(levelArchiveSceneObjStateData);
		}
		levelArchiveSceneObjData.EventData.Clear();
		foreach (KeyValuePair<string, List<FGameplayTag>> item2 in StateMachineData.SceneObjEvent)
		{
			LevelArchiveSceneObjEventData levelArchiveSceneObjEventData = new LevelArchiveSceneObjEventData();
			levelArchiveSceneObjEventData.ObjGuid = item2.Key;
			levelArchiveSceneObjEventData.ObjEvent.Clear();
			foreach (FGameplayTag item3 in item2.Value)
			{
				RepeatedField<string> objEvent = levelArchiveSceneObjEventData.ObjEvent;
				FName tagName = item3.TagName;
				objEvent.Add(tagName.PlainName);
			}
			levelArchiveSceneObjData.EventData.Add(levelArchiveSceneObjEventData);
		}
		stateMachineArchiveData.SceneObjData = levelArchiveSceneObjData;
		StateMachineData.ArchiveData = stateMachineArchiveData;
	}

	private void SaveSceneObjState(string UnitGuid, GameplayTagContainerRef ObjStateTagContainer, FGameplayTag StateTag)
	{
		Dictionary<string, GameplayTagContainerRef> sceneObjState = StateMachineData.SceneObjState;
		Dictionary<string, Dictionary<FGameplayTag, FGameplayTag>> sceneObjTransientState = StateMachineData.SceneObjTransientState;
		if (!sceneObjState.ContainsKey(UnitGuid))
		{
			GameplayTagContainerRef value = GameplayTagExtension.MakeGameplayTagContainer(StateTag);
			sceneObjState.Add(UnitGuid, value);
			return;
		}
		GameplayTagContainerRef gameplayTagContainerRef = sceneObjState[UnitGuid];
		if (gameplayTagContainerRef.HasTag(StateTag))
		{
			return;
		}
		if (gameplayTagContainerRef.HasAnyTags(ObjStateTagContainer))
		{
			if (sceneObjTransientState.ContainsKey(UnitGuid))
			{
				Dictionary<FGameplayTag, FGameplayTag> dictionary = sceneObjTransientState[UnitGuid];
				foreach (FGameplayTag item in gameplayTagContainerRef.FilterTags(ObjStateTagContainer))
				{
					if (dictionary.ContainsKey(item))
					{
						dictionary.Remove(item);
					}
				}
				sceneObjTransientState[UnitGuid] = dictionary;
			}
			gameplayTagContainerRef.RemoveTags(ObjStateTagContainer);
		}
		gameplayTagContainerRef.AddTag(StateTag);
		sceneObjState[UnitGuid] = gameplayTagContainerRef;
	}

	private void SaveSceneObjAllStates(string UnitGuid, GameplayTagContainerRef ObjStateTagContainer, GameplayTagContainerRef StateTagContainer)
	{
		Dictionary<string, GameplayTagContainerRef> sceneObjState = StateMachineData.SceneObjState;
		Dictionary<string, Dictionary<FGameplayTag, FGameplayTag>> sceneObjTransientState = StateMachineData.SceneObjTransientState;
		if (!sceneObjState.ContainsKey(UnitGuid))
		{
			sceneObjState.Add(UnitGuid, StateTagContainer);
			return;
		}
		sceneObjState[UnitGuid] = StateTagContainer;
		if (sceneObjTransientState.TryGetValue(UnitGuid, out var value))
		{
			value.Clear();
		}
	}

	private void RecordSceneObjState(string UnitGuid, GameplayTagContainerRef ObjStateTagContainer, FGameplayTag StateTag)
	{
		if (StateMachineData.SceneObjState.TryGetValue(UnitGuid, out var value))
		{
			FGameplayTag key = value.FilterTags(ObjStateTagContainer)[0];
			Dictionary<string, Dictionary<FGameplayTag, FGameplayTag>> sceneObjTransientState = StateMachineData.SceneObjTransientState;
			if (!sceneObjTransientState.ContainsKey(UnitGuid))
			{
				Dictionary<FGameplayTag, FGameplayTag> dictionary = new Dictionary<FGameplayTag, FGameplayTag>();
				dictionary.Add(key, StateTag);
				sceneObjTransientState.Add(UnitGuid, dictionary);
			}
			else
			{
				sceneObjTransientState[UnitGuid][key] = StateTag;
			}
		}
	}

	private void OnSetSceneObjState(string UnitGuid, FGameplayTag StateTag)
	{
		Entity Entity;
		bool actorEntity = GlobalActorData.GetActorEntity(UnitGuid, out Entity);
		BUS_GSEventCollection bUS_GSEventCollection = null;
		if (actorEntity)
		{
			bUS_GSEventCollection = BUS_EventCollectionCS.Get(ECSExtension.ToActor(Entity));
		}
		if (bUS_GSEventCollection != null)
		{
			if (!StateMachineData.SceneObjState.TryGetValue(UnitGuid, out var value) || !value.HasTag(StateTag))
			{
				bUS_GSEventCollection.Evt_SceneObjDirectJumpToState.Invoke(StateTag);
			}
			return;
		}
		if (!StateMachineData.SceneObjStateCache.ContainsKey(UnitGuid))
		{
			StateMachineData.SceneObjStateCache.Add(UnitGuid, new Queue<FGameplayTag>());
		}
		StateMachineData.SceneObjStateCache[UnitGuid].Enqueue(StateTag);
	}

	private void OnSendSceneObjEvent(string UnitGuid, FGameplayTag EventTag)
	{
		if (GlobalActorData.GetActorEntity(UnitGuid, out var Entity))
		{
			BUS_EventCollectionCS.Get(ECSExtension.ToActor(Entity))?.Evt_SceneObjTransitByEvent.Invoke(EventTag);
		}
		else
		{
			SaveSceneObjEvent(UnitGuid, EventTag);
		}
	}

	private void SaveSceneObjEvent(string UnitGuid, FGameplayTag EventTag)
	{
		Dictionary<string, List<FGameplayTag>> sceneObjEvent = StateMachineData.SceneObjEvent;
		if (!sceneObjEvent.ContainsKey(UnitGuid))
		{
			sceneObjEvent.Add(UnitGuid, new List<FGameplayTag> { EventTag });
			return;
		}
		List<FGameplayTag> list = sceneObjEvent[UnitGuid];
		if (!list.Any((FGameplayTag p) => GameplayTagExtension.EqualTo(p, EventTag)))
		{
			list.Add(EventTag);
			sceneObjEvent[UnitGuid] = list;
		}
	}

	private void ClearUnhandledSceneObjEvents(string UnitGuid, List<FGameplayTag> EventTags)
	{
		if (StateMachineData.SceneObjEvent.TryGetValue(UnitGuid, out var value))
		{
			value.RemoveAll(EventTags.Contains);
		}
	}

	private void ClearAllSceneObjState()
	{
		StateMachineData.SceneObjState.Clear();
	}

	private void OnRequestCleanupCachedStates(string UnitGuid)
	{
		if (!GlobalActorData.GetActorEntity(UnitGuid, out var Entity))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(ECSExtension.ToActor(Entity));
		if (StateMachineData.SceneObjStateCache.TryGetValue(UnitGuid, out var value))
		{
			while (value.Count > 0)
			{
				bUS_GSEventCollection.Evt_SceneObjDirectJumpToState.Invoke(value.Dequeue());
			}
			StateMachineData.SceneObjStateCache.Remove(UnitGuid);
		}
	}

	private void OnClearOverrideSceneObjStates()
	{
		StateMachineData.SceneObjTransientState.Clear();
	}

	private void RegisterIdleProcessActions(List<CalliopeCustom_IdleProcessAction> InIdleProcessActions, PsmNodeInstance InNodeInstance)
	{
		Guid nodeGuid = InNodeInstance.Node.NodeGuid;
		string psmGuid = InNodeInstance.ParentInstance.PsmGuid;
		ShutdownRunIdleProcessActions(InNodeInstance);
		List<FIdleProcessExecutorBase> list = new List<FIdleProcessExecutorBase>();
		foreach (CalliopeCustom_IdleProcessAction InIdleProcessAction in InIdleProcessActions)
		{
			FIdleProcessExecutorBase fIdleProcessExecutorBase = FIdleProcessExecutorFactory.CreateInstance((EIdleProcessActionType)InIdleProcessAction.ActionType);
			if (fIdleProcessExecutorBase != null)
			{
				fIdleProcessExecutorBase.Initial(InIdleProcessAction, InNodeInstance);
				list.Add(fIdleProcessExecutorBase);
			}
		}
		if (list.Count > 0 && StateMachineData.PsmInstances.TryGetValue(psmGuid, out var value))
		{
			value.IdleNodeProcessActions[nodeGuid] = list;
		}
	}

	private void RunIdleProcessActions(PsmNodeInstance InNodeInstance)
	{
		Guid nodeGuid = InNodeInstance.Node.NodeGuid;
		string psmGuid = InNodeInstance.ParentInstance.PsmGuid;
		if (!StateMachineData.PsmInstances.TryGetValue(psmGuid, out var value) || !value.IdleNodeProcessActions.TryGetValue(nodeGuid, out var value2))
		{
			return;
		}
		foreach (FIdleProcessExecutorBase item in value2)
		{
			item.Run(base.Owner);
		}
	}

	private void ResetRunIdleProcessActions(PsmNodeInstance InNodeInstance)
	{
		Guid nodeGuid = InNodeInstance.Node.NodeGuid;
		string psmGuid = InNodeInstance.ParentInstance.PsmGuid;
		if (!StateMachineData.PsmInstances.TryGetValue(psmGuid, out var value) || !value.IdleNodeProcessActions.TryGetValue(nodeGuid, out var value2))
		{
			return;
		}
		foreach (FIdleProcessExecutorBase item in value2)
		{
			item.ResetRun(base.Owner);
		}
	}

	private void RecoverRunIdleProcessActions(PsmNodeInstance InNodeInstance)
	{
		Guid nodeGuid = InNodeInstance.Node.NodeGuid;
		string psmGuid = InNodeInstance.ParentInstance.PsmGuid;
		if (!StateMachineData.PsmInstances.TryGetValue(psmGuid, out var value) || !value.IdleNodeProcessActions.TryGetValue(nodeGuid, out var value2))
		{
			return;
		}
		foreach (FIdleProcessExecutorBase item in value2)
		{
			item.RecoverRun(base.Owner);
		}
	}

	private void ShutdownRunIdleProcessActions(PsmNodeInstance InNodeInstance)
	{
		Guid nodeGuid = InNodeInstance.Node.NodeGuid;
		string psmGuid = InNodeInstance.ParentInstance.PsmGuid;
		if (!StateMachineData.PsmInstances.TryGetValue(psmGuid, out var value) || !value.IdleNodeProcessActions.TryGetValue(nodeGuid, out var value2))
		{
			return;
		}
		foreach (FIdleProcessExecutorBase item in value2)
		{
			item.Shutdown(base.Owner);
		}
		value.IdleNodeProcessActions.Remove(nodeGuid);
	}
}
