using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using CommB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_GamePlusSpawnCompImpl : BUS_TriggerBaseComp
{
	private IBGC_LocalPlayerSharedData LocalPlayerSharedData;

	protected BUC_GamePlusSpawnData GamePlusSpawnData { get; set; }

	protected BGC_TaskCollectionMgrData TaskCollectionMgrData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		GamePlusSpawnData = RequireWritableData<BUC_GamePlusSpawnData>();
		TaskCollectionMgrData = RequireReadOnlyGameStateData<BGC_TaskCollectionMgrData, BGC_TaskCollectionMgrData>();
		base.BUSEventCollection.Evt_TaskCollectiontDestoryForever += new Del_Void(TaskCollectiontDestoryForever);
		base.BUSEventCollection.Evt_TaskCollectionInteracted += new Del_Void_Int(OnTaskCollectionInteracted);
		LocalPlayerSharedData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_PushTaskStageStateSuccess = (BGW_EventCollection.Del_BGW_Void_PushTaskStageStateSuccess)Delegate.Combine(bGW_EventCollection.Evt_PushTaskStageStateSuccess, new BGW_EventCollection.Del_BGW_Void_PushTaskStageStateSuccess(OnPushTaskStageStateSuccess));
		}
	}

	private void OnPushTaskStageStateSuccess(int TaskStageID, QuestStage StageState)
	{
		if (GamePlusSpawnData.TaskStageId == TaskStageID && GamePlusSpawnData.TaskStageStage == (int)StageState)
		{
			GamePlusSpawnData.TaskStageFinish = true;
		}
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		CheckSpawnState();
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetOwner(), 0);
		AController controller = playerCharacter.GetController();
		if (!(playerCharacter != null) || !(playerCharacter.PlayerState != null))
		{
			return;
		}
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(controller);
		if (readOnlyData == null || readOnlyData.RoleData == null || readOnlyData.RoleData.RoleCs == null || readOnlyData.RoleData.RoleCs.Task == null)
		{
			return;
		}
		foreach (ReadOnlyQuestStageOne quest in readOnlyData.RoleData.RoleCs.Task.QuestList)
		{
			int id = quest.Id;
			QuestStage stage = quest.Stage;
			if (GamePlusSpawnData.TaskStageId == id && GamePlusSpawnData.TaskStageStage == (int)stage)
			{
				GamePlusSpawnData.TaskStageFinish = true;
			}
		}
	}

	private void OnTaskCollectionInteracted(int CurCD)
	{
		double totalSeconds = (DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
		GamePlusSpawnData.LastCollectTime = totalSeconds;
		GamePlusSpawnData.CurCD = CurCD;
		GamePlusSpawnData.TargetSpawnActorIndex = 0;
		GamePlusSpawnData.CollectionCount++;
	}

	private void TaskCollectiontDestoryForever()
	{
		GamePlusSpawnData.DestoryForever = true;
		int curGamePlayCount = BGW_GamePlayCountUtil.GetCurGamePlayCount(base.Owner);
		if (curGamePlayCount >= 0)
		{
			GamePlusSpawnData.LastCollectGamePlayCount = curGamePlayCount;
		}
	}

	public void CheckSpawnState()
	{
		if (!CheckCollectionNeedShow())
		{
			return;
		}
		string key = base.GuidData.GetFinalGuid() + "_GamePlus";
		if (TaskCollectionMgrData.TaskCollectionDict.ContainsKey(key))
		{
			return;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		if (!(firstLocalPlayerController != null))
		{
			return;
		}
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController);
		if (readOnlyData == null)
		{
			return;
		}
		int curGamePlayCount = BGW_GamePlayCountUtil.GetCurGamePlayCount(base.Owner, readOnlyData);
		int num = 0;
		List<GamePlusSpawnerConfig> spawnerConfigList = new List<GamePlusSpawnerConfig>();
		foreach (GamePlusSpawnConfig gamePlusSpawnConfig in GamePlusSpawnData.GamePlusSpawnConfigList)
		{
			if (num < gamePlusSpawnConfig.GamePlusCount)
			{
				num = gamePlusSpawnConfig.GamePlusCount;
				spawnerConfigList = gamePlusSpawnConfig.SpawnerConfig;
			}
			if (gamePlusSpawnConfig.GamePlusCount == curGamePlayCount)
			{
				spawnerConfigList = gamePlusSpawnConfig.SpawnerConfig;
				break;
			}
		}
		SpwanActorByGamePlusConfig(spawnerConfigList);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		CheckSpawnState();
	}

	private bool CheckCollectionNeedShow()
	{
		if (GamePlusSpawnData.CollectionCountMax > 0 && GamePlusSpawnData.CollectionCount >= GamePlusSpawnData.CollectionCountMax)
		{
			return false;
		}
		if (GamePlusSpawnData.TaskStageId > 0 && !GamePlusSpawnData.TaskStageFinish)
		{
			return false;
		}
		if (GamePlusSpawnData.DestoryForever && GamePlusSpawnData.LastCollectGamePlayCount >= BGW_GamePlayCountUtil.GetCurGamePlayCount(base.Owner))
		{
			return false;
		}
		if (GamePlusSpawnData.CurSpawnActor != null || GamePlusSpawnData.TargetSpawnActorIndex != 0)
		{
			return false;
		}
		if (GamePlusSpawnData.LastCollectTime > 0.0)
		{
			double totalSeconds = (DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
			if ((double)GamePlusSpawnData.CurCD >= totalSeconds - GamePlusSpawnData.LastCollectTime)
			{
				return false;
			}
		}
		if (FVector.Distance(GetOwner().GetActorLocation(), LocalPlayerSharedData.CachedLocalPlayerLocation) > 10000f)
		{
			return false;
		}
		return true;
	}

	private void SpwanActorByGamePlusConfig(List<GamePlusSpawnerConfig> SpawnerConfigList)
	{
		if (GamePlusSpawnData.TargetSpawnActorIndex > 0)
		{
			SpawnActorByClass(SpawnerConfigList[GamePlusSpawnData.TargetSpawnActorIndex - 1].ActorClass);
		}
		else
		{
			RandomAndSpawnActor(SpawnerConfigList);
		}
	}

	private void RandomAndSpawnActor(List<GamePlusSpawnerConfig> SpawnerConfigList)
	{
		var (targetSpawnActorIndex, actorClass) = BGU_CollectionActorUtil.RandomTargetSpawnActor(SpawnerConfigList);
		GamePlusSpawnData.TargetSpawnActorIndex = targetSpawnActorIndex;
		SpawnActorByClass(actorClass);
	}

	private void SpawnActorByClass(TSubclassOf<AActor> ActorClass)
	{
		if (ActorClass != null)
		{
			FVector location = GetOwner().GetActorLocation();
			FRotator rotation = GetOwner().GetActorRotation();
			FActorSpawnParameters parameters = default(FActorSpawnParameters);
			AActor aActor = GetOwner().World.SpawnActor(ActorClass.Value, ref location, ref rotation, ref parameters);
			string unitRandomGuid = base.GuidData.GetFinalGuid() + "_GamePlus";
			BUS_GuidComp componentByClass = aActor.GetComponentByClass<BUS_GuidComp>();
			componentByClass.UnitRandomGuid = unitRandomGuid;
			base.BGSEventCollection.Evt_BGS_RegisterTaskCollectiont.Invoke(componentByClass.UnitRandomGuid, aActor);
			BGU_DataUtil.GetReadOnlyData<BUC_TaskCollectionData>(aActor).SpawnerActor = GetOwner();
			GamePlusSpawnData.CurSpawnActor = aActor;
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(GamePlusSpawnData.CurSpawnActor);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_TaskCollectiontSpawnerDestory.Invoke();
		}
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_PushTaskStageStateSuccess = (BGW_EventCollection.Del_BGW_Void_PushTaskStageStateSuccess)Delegate.Remove(bGW_EventCollection.Evt_PushTaskStageStateSuccess, new BGW_EventCollection.Del_BGW_Void_PushTaskStageStateSuccess(OnPushTaskStageStateSuccess));
		}
	}
}
