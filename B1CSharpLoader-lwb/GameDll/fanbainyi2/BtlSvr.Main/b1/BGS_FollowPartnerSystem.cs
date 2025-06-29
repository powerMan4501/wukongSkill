using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using b1.BGW;
using b1.ECS;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using CommB1;
using Diana.Common;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_FollowPartnerSystem : GameStateSystemBase
{
	private static readonly float TICK_DURATION = 3f;

	private BGC_FollowPartnerMgrData FollowPartnerMgrData;

	private IBIC_LevelData LevelData;

	private IBIC_TaskData TaskData;

	public override void OnAttach()
	{
		base.OnAttach();
		FollowPartnerMgrData = RequireWritableData<BGC_FollowPartnerMgrData>();
		LevelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		TaskData = RequireReadonlyGameInstanceData<IBIC_TaskData, BIC_TaskData>();
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_PlayerDelayBeginPlayFinished = (Del_Void)Delegate.Combine(bGWEventCollection.Evt_PlayerDelayBeginPlayFinished, new Del_Void(OnPlayerDelayBeginPlayFinished));
		BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
		bGWEventCollection2.Evt_OnCurrentLevelChanged = (Del_Void_Int)Delegate.Combine(bGWEventCollection2.Evt_OnCurrentLevelChanged, new Del_Void_Int(OnCurrentLevelChanged));
		BGW_EventCollection bGWEventCollection3 = base.BGWEventCollection;
		bGWEventCollection3.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Combine(bGWEventCollection3.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnTriggerResetAllActors));
		BGW_EventCollection bGWEventCollection4 = base.BGWEventCollection;
		bGWEventCollection4.Evt_BGW_PlayerTeleportToTriggered = (BGW_EventCollection.Del_PlayerTeleportToTriggered)Delegate.Combine(bGWEventCollection4.Evt_BGW_PlayerTeleportToTriggered, new BGW_EventCollection.Del_PlayerTeleportToTriggered(OnPlayerTeleportToTriggered));
		BGW_EventCollection bGWEventCollection5 = base.BGWEventCollection;
		bGWEventCollection5.Evt_BGW_PlayerTeleportToFinished = (BGW_EventCollection.Del_PlayerTeleportToFinished)Delegate.Combine(bGWEventCollection5.Evt_BGW_PlayerTeleportToFinished, new BGW_EventCollection.Del_PlayerTeleportToFinished(OnPlayerTeleportToFinished));
		BGW_EventCollection bGWEventCollection6 = base.BGWEventCollection;
		bGWEventCollection6.Evt_BGW_PrintCurrentFollowPartnerInfo = (BGW_EventCollection.Del_BGW_Void)Delegate.Combine(bGWEventCollection6.Evt_BGW_PrintCurrentFollowPartnerInfo, new BGW_EventCollection.Del_BGW_Void(OnPrintCurrentFollowPartnerInfo));
		BGW_EventCollection bGWEventCollection7 = base.BGWEventCollection;
		bGWEventCollection7.Evt_BGW_PrintCurrentWeakAiInteractInfo = (BGW_EventCollection.Del_BGW_Void)Delegate.Combine(bGWEventCollection7.Evt_BGW_PrintCurrentWeakAiInteractInfo, new BGW_EventCollection.Del_BGW_Void(OnPrintCurrentWeakAiInteractInfo));
		base.BGSEventCollection.Evt_BGS_EnterFollowPartnerInteractArea += new Del_Void_Actor(OnEnterFollowPartnerInteractArea);
		base.BGSEventCollection.Evt_BGS_ComeCloseToFollowPartnerInteractiveArea += new Del_Void_Actor(OnComeCloseToFollowPartnerInteractiveArea);
		base.BGSEventCollection.Evt_BGS_LeaveFollowPartnerInteractArea += new Del_Void_Actor(OnLeaveFollowPartnerInteractArea);
		base.BGSEventCollection.Evt_BGS_FollowPartnerFinishInteract += new Del_Void_Actor(OnFollowPartnerFinishInteract);
		base.BGSEventCollection.Evt_BGS_EliminationCurrentFollowPartner += new Del_Void_Int(OnEliminationCurrentFollowPartner);
		base.BGSEventCollection.Evt_BGS_NotifyAiBreakInteractAction += new Del_NotifyAiBreakInteractAction(OnNotifyAiBreakInteractAction);
		base.BGSEventCollection.Evt_BGS_NotifyTriggerWeakAiInteract += new Del_Void_String(OnNotifyTriggerWeakAiInteract);
		base.BGSEventCollection.Evt_NotifyTamerSpawnUnit += new Del_Void_String(OnNotifyTamerSpawnUnit);
		if (base.BGSEventCollection != null)
		{
			base.BGSEventCollection.Evt_NotifyMovieBegin += new Del_Void_IntInt(OnMovieBegin);
			base.BGSEventCollection.Evt_NotifyMovieEnd += new Del_Void_IntInt(OnMovieEnd);
		}
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		FollowPartnerMgrData.Init(TICK_DURATION);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_PlayerDelayBeginPlayFinished = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_PlayerDelayBeginPlayFinished, new Del_Void(OnPlayerDelayBeginPlayFinished));
			bGW_EventCollection.Evt_OnCurrentLevelChanged = (Del_Void_Int)Delegate.Remove(bGW_EventCollection.Evt_OnCurrentLevelChanged, new Del_Void_Int(OnCurrentLevelChanged));
			bGW_EventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Remove(bGW_EventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnTriggerResetAllActors));
			bGW_EventCollection.Evt_BGW_PlayerTeleportToTriggered = (BGW_EventCollection.Del_PlayerTeleportToTriggered)Delegate.Remove(bGW_EventCollection.Evt_BGW_PlayerTeleportToTriggered, new BGW_EventCollection.Del_PlayerTeleportToTriggered(OnPlayerTeleportToTriggered));
			bGW_EventCollection.Evt_BGW_PlayerTeleportToFinished = (BGW_EventCollection.Del_PlayerTeleportToFinished)Delegate.Remove(bGW_EventCollection.Evt_BGW_PlayerTeleportToFinished, new BGW_EventCollection.Del_PlayerTeleportToFinished(OnPlayerTeleportToFinished));
			bGW_EventCollection.Evt_BGW_PrintCurrentFollowPartnerInfo = (BGW_EventCollection.Del_BGW_Void)Delegate.Remove(bGW_EventCollection.Evt_BGW_PrintCurrentFollowPartnerInfo, new BGW_EventCollection.Del_BGW_Void(OnPrintCurrentFollowPartnerInfo));
			bGW_EventCollection.Evt_BGW_PrintCurrentWeakAiInteractInfo = (BGW_EventCollection.Del_BGW_Void)Delegate.Remove(bGW_EventCollection.Evt_BGW_PrintCurrentWeakAiInteractInfo, new BGW_EventCollection.Del_BGW_Void(OnPrintCurrentWeakAiInteractInfo));
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!FollowPartnerMgrData.bCanTick)
		{
			return;
		}
		if (FollowPartnerMgrData.WeakAiInteractConversationTimer > 0f)
		{
			FollowPartnerMgrData.WeakAiInteractConversationTimer -= DeltaTime;
		}
		FollowPartnerMgrData.TickTimer -= DeltaTime;
		if (FollowPartnerMgrData.TickTimer > 0f)
		{
			return;
		}
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(Owner);
		if (!UGSE_EngineFuncLib.IsStandAlone(worldFromObj) || B1Global.GIsBossRushMode)
		{
			return;
		}
		foreach (Entity item in FollowPartnerMgrData.EnterInteractAreaList.Keys.ToList())
		{
			bool flag = false;
			if (item == Entity.Null)
			{
				flag = true;
			}
			else
			{
				AActor aActor = ECSExtension.ToActor(item);
				if (aActor == null)
				{
					flag = true;
				}
				else
				{
					IBUC_InteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_InteractData, BUC_InteractData>(aActor);
					if (readOnlyData == null)
					{
						flag = true;
					}
					else if (!readOnlyData.bIsInteracting && readOnlyData.InteractUnitState != EBGUInteractUnitState.BeforeActive)
					{
						flag = true;
					}
				}
			}
			if (flag)
			{
				FollowPartnerMgrData.EnterInteractAreaList.Remove(item);
			}
		}
		if (!FollowPartnerMgrData.FollowPartnerGUID.Equals(string.Empty) && FollowPartnerMgrData.bIsFollowPartnerSpawnFinish)
		{
			FUStFollowPartnerConfigDesc followPartnerConfigDesc = BGW_GameDB.GetFollowPartnerConfigDesc(FollowPartnerMgrData.CurrentUseFollowPartnerConfigID);
			bool flag2 = true;
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(worldFromObj, FollowPartnerMgrData.FollowPartnerGUID);
			if (actorByGuid != null && !BGUFunctionLibraryCS.BGUHasUnitState(actorByGuid, EBGUUnitState.Dead) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(actorByGuid, EBGUSimpleState.PendingDeathInAnimationSyncing))
			{
				APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(worldFromObj);
				if (firstLocalPlayerController != null)
				{
					AActor controlledPawn = firstLocalPlayerController.GetControlledPawn();
					if (controlledPawn != null && FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(controlledPawn), BGUFuncLibActorTransformCS.BGUGetActorLocation(actorByGuid)) <= (float)followPartnerConfigDesc.RespawnCheckDistance)
					{
						flag2 = false;
					}
				}
			}
			if (!flag2 && followPartnerConfigDesc.JudgeConditionAfterPartnerAppear == EGSYesNo.Yes)
			{
				flag2 = !CheckCurrentUseFollowConfigIDStillSuccess();
			}
			if (flag2)
			{
				EliminationFollowPartner(((float?)followPartnerConfigDesc?.RespawnWaitTime) ?? TICK_DURATION);
			}
		}
		else
		{
			FollowPartnerMgrData.SpawnCountdownTimer -= TICK_DURATION - FollowPartnerMgrData.TickTimer;
			if (FollowPartnerMgrData.SpawnCountdownTimer <= 0f)
			{
				int SuccessFollowPartnerConfigID;
				if (FollowPartnerMgrData.CurrentUseFollowPartnerConfigID >= 0)
				{
					EliminationFollowPartner(TICK_DURATION);
				}
				else if (CheckCanRefreshFollowPartner(out SuccessFollowPartnerConfigID))
				{
					FollowPartnerMgrData.CurrentUseFollowPartnerConfigID = SuccessFollowPartnerConfigID;
					RefreshFollowPartner();
					if (FollowPartnerMgrData.FollowPartnerGUID.Equals(string.Empty))
					{
						EliminationFollowPartner(TICK_DURATION);
					}
				}
				FollowPartnerMgrData.SpawnCountdownTimer = TICK_DURATION;
			}
		}
		FollowPartnerMgrData.TickTimer = TICK_DURATION;
	}

	private bool CheckCanRefreshFollowPartner(out int SuccessFollowPartnerConfigID)
	{
		SuccessFollowPartnerConfigID = -1;
		foreach (int currentLevelFollowPartnerConfigID in FollowPartnerMgrData.CurrentLevelFollowPartnerConfigIDList)
		{
			FUStFollowPartnerConfigDesc followPartnerConfigDesc = BGW_GameDB.GetFollowPartnerConfigDesc(currentLevelFollowPartnerConfigID);
			if (followPartnerConfigDesc == null)
			{
				continue;
			}
			bool flag = false;
			if (followPartnerConfigDesc.QuestStageConditionInfoList.Count > 0)
			{
				IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner));
				if (readOnlyData != null && readOnlyData.RoleData != null && readOnlyData.RoleData.RoleCs != null && readOnlyData.RoleData.RoleCs.Task != null && readOnlyData.RoleData.RoleCs.Task.QuestList != null)
				{
					int num = 0;
					foreach (TaskStageInfo questStageConditionInfo in followPartnerConfigDesc.QuestStageConditionInfoList)
					{
						int taskStageID = questStageConditionInfo.TaskStageID;
						int taskStageState = (int)questStageConditionInfo.TaskStageState;
						foreach (ReadOnlyQuestStageOne quest in readOnlyData.RoleData.RoleCs.Task.QuestList)
						{
							if (taskStageID == quest.Id && taskStageState == (int)quest.Stage)
							{
								num++;
								break;
							}
						}
					}
					if (num > 0)
					{
						switch (followPartnerConfigDesc.ConditionType)
						{
						case EConditionRelationType.LogicRelationAnd:
							if (num == followPartnerConfigDesc.QuestStageConditionInfoList.Count)
							{
								flag = true;
							}
							break;
						case EConditionRelationType.LogicRelationOr:
							flag = true;
							break;
						}
					}
				}
			}
			else
			{
				flag = true;
			}
			bool flag2 = false;
			string overlapBoxGUID = followPartnerConfigDesc.OverlapBoxGUID;
			bool bInnerOverlap;
			if (overlapBoxGUID.Equals(string.Empty))
			{
				flag2 = true;
			}
			else if (TaskData.IsPlayerInOverlap(overlapBoxGUID, out bInnerOverlap))
			{
				flag2 = bInnerOverlap;
			}
			if (flag && flag2)
			{
				SuccessFollowPartnerConfigID = currentLevelFollowPartnerConfigID;
				return true;
			}
		}
		return false;
	}

	private bool CheckCurrentUseFollowConfigIDStillSuccess()
	{
		FUStFollowPartnerConfigDesc followPartnerConfigDesc = BGW_GameDB.GetFollowPartnerConfigDesc(FollowPartnerMgrData.CurrentUseFollowPartnerConfigID);
		if (followPartnerConfigDesc != null)
		{
			if (followPartnerConfigDesc.QuestStageConditionInfoList.Count == 0)
			{
				return true;
			}
			IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner));
			if (readOnlyData != null && readOnlyData.RoleData != null && readOnlyData.RoleData.RoleCs != null && readOnlyData.RoleData.RoleCs.Task != null && readOnlyData.RoleData.RoleCs.Task.QuestList != null)
			{
				int num = 0;
				foreach (TaskStageInfo questStageConditionInfo in followPartnerConfigDesc.QuestStageConditionInfoList)
				{
					int taskStageID = questStageConditionInfo.TaskStageID;
					int taskStageState = (int)questStageConditionInfo.TaskStageState;
					foreach (ReadOnlyQuestStageOne quest in readOnlyData.RoleData.RoleCs.Task.QuestList)
					{
						if (taskStageID == quest.Id && taskStageState == (int)quest.Stage)
						{
							num++;
							break;
						}
					}
				}
				if (num > 0)
				{
					switch (followPartnerConfigDesc.ConditionType)
					{
					case EConditionRelationType.LogicRelationAnd:
						return num == followPartnerConfigDesc.QuestStageConditionInfoList.Count;
					case EConditionRelationType.LogicRelationOr:
						return true;
					}
				}
			}
		}
		return false;
	}

	private void RefreshFollowPartner()
	{
		if (!FollowPartnerMgrData.FollowPartnerGUID.Equals(string.Empty))
		{
			return;
		}
		FUStFollowPartnerConfigDesc followPartnerConfigDesc = BGW_GameDB.GetFollowPartnerConfigDesc(FollowPartnerMgrData.CurrentUseFollowPartnerConfigID);
		if (followPartnerConfigDesc == null)
		{
			return;
		}
		FUStAssociationUnitInfoSDesc associationUnitInfoSDesc = BGW_GameDB.GetAssociationUnitInfoSDesc(followPartnerConfigDesc.AssociationUnitInfoID);
		if (associationUnitInfoSDesc == null)
		{
			return;
		}
		TSubclassOf<BUTamerActor> tSubclassOf = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UClass>(associationUnitInfoSDesc.UnitResBPPath, ELoadResourceType.SyncLoadAndCache);
		if (!(tSubclassOf != null))
		{
			return;
		}
		bool flag = false;
		FVector translation = default(FVector);
		FRotator fRotator = default(FRotator);
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(Owner);
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(worldFromObj)?.GetControlledPawn();
		if (!(aPawn != null))
		{
			return;
		}
		switch (followPartnerConfigDesc.FollowPartnerSpawnType)
		{
		case EFollowPartnerSpawnType.BySceneItem:
		{
			((IBGC_LevelActorData)BGU_DataUtil.GetGameStateReadonlyData<BGC_LevelActorData>(Owner)).GetSceneItemsByTag(new FName(associationUnitInfoSDesc.SpawnSceneItemTagName), out List<AActor> OutSceneItems);
			if (OutSceneItems.Count > 0)
			{
				AActor aActor = OutSceneItems[0];
				if (aActor != null)
				{
					flag = true;
					translation = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
					fRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(aActor);
				}
			}
			break;
		}
		case EFollowPartnerSpawnType.ByEqs:
		{
			UEnvQuery uEnvQuery = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UEnvQuery>(associationUnitInfoSDesc.SpawnEQSPath, ELoadResourceType.SyncLoadAndCache);
			if (uEnvQuery != null)
			{
				base.BGSEventCollection.Evt_BGS_EQSObjRunInstant.Invoke(uEnvQuery, aPawn, out var Locations, out var Scores);
				int num = -1;
				float num2 = float.MinValue;
				for (int i = 0; i < Scores.Count; i++)
				{
					if (num2 < Scores[i])
					{
						num2 = Scores[i];
						num = i;
					}
				}
				if (num > -1)
				{
					flag = true;
					translation = ((Locations.Count > num) ? Locations[num] : BGUFuncLibActorTransformCS.BGUGetActorLocation(aPawn));
				}
			}
			fRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(aPawn);
			break;
		}
		}
		if (!flag)
		{
			translation = BGUFuncLibActorTransformCS.BGUGetActorLocation(aPawn);
			fRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(aPawn);
		}
		FollowPartnerMgrData.FollowPartnerGUID = BGU_UnrealWorldUtil.RequestSpawnUnit(worldFromObj, tSubclassOf, new FTransform(fRotator.Quaternion(), translation, FVector.OneVector), null);
		FollowPartnerMgrData.bIsFollowPartnerSpawnFinish = false;
		FollowPartnerMgrData.FollowPartnerDisplayConfig = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_FollowPartnerDisplayConfig>(followPartnerConfigDesc.FollowPartnerDispDAPath, ELoadResourceType.SyncLoadAndCache);
	}

	private void EliminationFollowPartner(float RespawnWaitTime)
	{
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(UGSE_EngineFuncLib.GetWorldFromObj(Owner), FollowPartnerMgrData.FollowPartnerGUID);
		if (actorByGuid != null)
		{
			BUS_EventCollectionCS.Get(actorByGuid).Evt_AiBreakInteract.Invoke(EAiBreakInteractionType.Other);
		}
		if (!FollowPartnerMgrData.FollowPartnerGUID.Equals(string.Empty))
		{
			BGU_UnrealWorldUtil.RequestDestroyUnit(UGSE_EngineFuncLib.GetWorldFromObj(Owner), FollowPartnerMgrData.FollowPartnerGUID);
		}
		FollowPartnerMgrData.FollowPartnerGUID = string.Empty;
		FollowPartnerMgrData.bIsFollowPartnerSpawnFinish = false;
		FollowPartnerMgrData.CurrentUseFollowPartnerConfigID = -1;
		FollowPartnerMgrData.SpawnCountdownTimer = RespawnWaitTime;
		FollowPartnerMgrData.FollowPartnerDisplayConfig = null;
	}

	private void OnCurrentLevelChanged(int NewLevelID)
	{
		if (FollowPartnerMgrData.CurrentLevelIDCache == NewLevelID)
		{
			return;
		}
		FollowPartnerMgrData.CurrentLevelIDCache = NewLevelID;
		FollowPartnerMgrData.CurrentLevelFollowPartnerConfigIDList.Clear();
		FollowPartnerMgrData.CurrentUseFollowPartnerConfigID = -1;
		Dictionary<int, FUStFollowPartnerConfigDesc> allFollowPartnerConfigDesc = BGW_GameDB.GetAllFollowPartnerConfigDesc();
		if (allFollowPartnerConfigDesc == null || allFollowPartnerConfigDesc.Count <= 0)
		{
			return;
		}
		foreach (KeyValuePair<int, FUStFollowPartnerConfigDesc> item in allFollowPartnerConfigDesc)
		{
			FUStFollowPartnerConfigDesc value = item.Value;
			if (value != null && (value.LevelID == NewLevelID || value.LevelID == 0))
			{
				FollowPartnerMgrData.CurrentLevelFollowPartnerConfigIDList.Add(item.Key);
			}
		}
	}

	private void OnTriggerResetAllActors(EResetActorReason ResetReason)
	{
		EliminationFollowPartner(TICK_DURATION);
	}

	private void OnPlayerTeleportToTriggered(ETeleportTypeV2 TeleportType)
	{
		FollowPartnerMgrData.bCanTick = false;
		EliminationFollowPartner(TICK_DURATION);
	}

	private void OnPlayerTeleportToFinished()
	{
		FollowPartnerMgrData.bCanTick = true;
	}

	private void OnEliminationCurrentFollowPartner(int ConfigID)
	{
		if (FollowPartnerMgrData.CurrentUseFollowPartnerConfigID > 0 && FollowPartnerMgrData.CurrentUseFollowPartnerConfigID == ConfigID)
		{
			EliminationFollowPartner(TICK_DURATION);
		}
	}

	private void OnNotifyTamerSpawnUnit(string UnitGuid)
	{
		if (!FollowPartnerMgrData.bIsFollowPartnerSpawnFinish && FollowPartnerMgrData.CurrentUseFollowPartnerConfigID > 0 && FollowPartnerMgrData.FollowPartnerGUID.Equals(UnitGuid))
		{
			FollowPartnerMgrData.bIsFollowPartnerSpawnFinish = true;
		}
	}

	private void OnPrintCurrentFollowPartnerInfo()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("[PrintCurrentFollowPartnerInfo]");
		stringBuilder.AppendLine("[PrintCurrentFollowPartnerInfo]=================打印当前跟随作战单位信息——Begin=================");
		stringBuilder.AppendLine($"[PrintCurrentFollowPartnerInfo]当前跟随作战单位的配置ID是：{FollowPartnerMgrData.CurrentUseFollowPartnerConfigID}，当前跟随作战单位的GUID是：{FollowPartnerMgrData.FollowPartnerGUID}");
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(UGSE_EngineFuncLib.GetWorldFromObj(Owner), FollowPartnerMgrData.FollowPartnerGUID);
		if (actorByGuid != null)
		{
			IBUC_BuffData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BuffData, BUC_BuffData>(actorByGuid);
			if (unPersistentReadOnlyData != null)
			{
				stringBuilder.AppendLine("[PrintCurrentFollowPartnerInfo]======开始打印跟随作战单位身上的Buff信息-Begin======");
				foreach (BuffInstData allBuffInstDatum in unPersistentReadOnlyData.GetAllBuffInstData())
				{
					if (allBuffInstDatum != null)
					{
						stringBuilder.AppendLine($"[PrintCurrentFollowPartnerInfo] BuffID = {allBuffInstDatum.BuffID}，层数 = {allBuffInstDatum.Layer}，剩余时间 = {allBuffInstDatum.LeftTime:F2}秒");
					}
				}
				stringBuilder.AppendLine("[PrintCurrentFollowPartnerInfo]======开始打印跟随作战单位身上的Buff信息-End======");
			}
		}
		stringBuilder.AppendLine("[PrintCurrentFollowPartnerInfo]=================打印当前跟随作战单位信息——End=================");
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.FollowPartnerInfo, stringBuilder.ToString());
		}
	}

	private void OnPrintCurrentWeakAiInteractInfo()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("[PrintCurrentWeakAiInteractInfo]");
		stringBuilder.AppendLine("[PrintCurrentWeakAiInteractInfo]=================打印当前WeakAiInteract信息——Begin=================");
		stringBuilder.AppendLine($"[PrintCurrentWeakAiInteractInfo]当前WeakAiInteract触发剩余时间是：{FollowPartnerMgrData.WeakAiInteractConversationTimer:F2}秒, 触发后CD是：{FollowPartnerMgrData.FollowPartnerDisplayConfig.WeakAiInteractConversationCD}秒");
		if (FollowPartnerMgrData.WeakAiInteractGUIDList.Count > 0)
		{
			stringBuilder.AppendLine("[PrintCurrentWeakAiInteractInfo]======开始打印已经触发过的WeakAiInteractGuid信息-Begin======");
			foreach (string weakAiInteractGUID in FollowPartnerMgrData.WeakAiInteractGUIDList)
			{
				stringBuilder.AppendLine("[PrintCurrentWeakAiInteractInfo] Guid = " + weakAiInteractGUID);
			}
			stringBuilder.AppendLine("[PrintCurrentWeakAiInteractInfo]======开始打印已经触发过的WeakAiInteractGuid信息-End======");
		}
		stringBuilder.AppendLine("[PrintCurrentWeakAiInteractInfo]=================打印当前WeakAiInteract信息——End=================");
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.WeakAiInteractInfo, stringBuilder.ToString());
		}
	}

	private void OnNotifyAiBreakInteractAction(EAiBreakInteractionType BreakType)
	{
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(Owner);
		if (!UGSE_EngineFuncLib.IsStandAlone(worldFromObj) || !(FollowPartnerMgrData.FollowPartnerDisplayConfig != null))
		{
			return;
		}
		foreach (FAiBreakInteractionConversationInfo breakInteractionConversationInfo in FollowPartnerMgrData.FollowPartnerDisplayConfig.BreakInteractionConversationInfoList)
		{
			if (breakInteractionConversationInfo.AiBreakInteractionType == BreakType)
			{
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(worldFromObj, FollowPartnerMgrData.FollowPartnerGUID);
				base.BGSEventCollection?.Evt_PocessEventByContentIDList.Invoke("FllowPartner::Ai打断交互，打断类型:" + BreakType, actorByGuid, breakInteractionConversationInfo.AiConversationIDList);
				break;
			}
		}
	}

	private void OnNotifyTriggerWeakAiInteract(string WeakAIInteractGUID)
	{
		FollowPartnerMgrData.WeakAiInteractConversationTimer = FollowPartnerMgrData.FollowPartnerDisplayConfig.WeakAiInteractConversationCD;
		if (!FollowPartnerMgrData.WeakAiInteractGUIDList.Contains(WeakAIInteractGUID))
		{
			FollowPartnerMgrData.WeakAiInteractGUIDList.Add(WeakAIInteractGUID);
		}
	}

	private void OnMovieBegin(int SeqID, int UniqueID)
	{
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(Owner);
		if (!UGSE_EngineFuncLib.IsStandAlone(worldFromObj))
		{
			return;
		}
		FUStMovieSequenceDesc movieSequenceDesc = BGW_GameDB.GetMovieSequenceDesc(SeqID);
		if (movieSequenceDesc == null || movieSequenceDesc.IsNeedHideFollowPartner != EGSYesNo.Yes)
		{
			return;
		}
		FollowPartnerMgrData.SeqHiddenFlag = true;
		if (FollowPartnerMgrData.FollowPartnerGUID.Equals(string.Empty) || !FollowPartnerMgrData.bIsFollowPartnerSpawnFinish)
		{
			return;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(worldFromObj, FollowPartnerMgrData.FollowPartnerGUID);
		if (actorByGuid != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null && bUS_GSEventCollection.HasBeginPlay)
			{
				bUS_GSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.ShowBegin);
			}
		}
	}

	private void OnMovieEnd(int SeqID, int UniqueID)
	{
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(Owner);
		if (!UGSE_EngineFuncLib.IsStandAlone(worldFromObj))
		{
			return;
		}
		FollowPartnerMgrData.SeqHiddenFlag = false;
		if (FollowPartnerMgrData.FollowPartnerGUID.Equals(string.Empty) || !FollowPartnerMgrData.bIsFollowPartnerSpawnFinish)
		{
			return;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(worldFromObj, FollowPartnerMgrData.FollowPartnerGUID);
		if (actorByGuid != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null && bUS_GSEventCollection.HasBeginPlay)
			{
				bUS_GSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.ShowFinish);
			}
		}
	}

	private bool CheckCanRecordAccessInteractInfo()
	{
		return true;
	}

	private void OnPlayerDelayBeginPlayFinished()
	{
		FollowPartnerMgrData.bCanTick = true;
		OnCurrentLevelChanged(LevelData.CurrentLevelID);
	}

	private void OnEnterFollowPartnerInteractArea(AActor InteractActor)
	{
		if (!CheckCanRecordAccessInteractInfo())
		{
			return;
		}
		Entity entity = ECSExtension.ToEntity(InteractActor);
		if (entity != Entity.Null)
		{
			if (FollowPartnerMgrData.EnterInteractAreaList.TryGetValue(entity, out var _))
			{
				FollowPartnerMgrData.EnterInteractAreaList[entity] = 2;
			}
			else
			{
				FollowPartnerMgrData.EnterInteractAreaList.Add(entity, 2);
			}
		}
	}

	private void OnComeCloseToFollowPartnerInteractiveArea(AActor InteractActor)
	{
		if (CheckCanRecordAccessInteractInfo())
		{
			Entity entity = ECSExtension.ToEntity(InteractActor);
			if (entity != Entity.Null && !FollowPartnerMgrData.EnterInteractAreaList.TryGetValue(entity, out var _))
			{
				FollowPartnerMgrData.EnterInteractAreaList.Add(entity, 1);
			}
		}
	}

	private void OnLeaveFollowPartnerInteractArea(AActor InteractActor)
	{
		if (CheckCanRecordAccessInteractInfo())
		{
			Entity entity = ECSExtension.ToEntity(InteractActor);
			if (entity != Entity.Null && FollowPartnerMgrData.EnterInteractAreaList.TryGetValue(entity, out var _))
			{
				FollowPartnerMgrData.EnterInteractAreaList.Remove(entity);
			}
		}
	}

	private void OnFollowPartnerFinishInteract(AActor InteractActor)
	{
		OnLeaveFollowPartnerInteractArea(InteractActor);
	}
}
