using System.Collections.Generic;
using b1.ECS;
using b1.EventDelDefine;
using BtlShare;
using CommB1;
using OssB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_OnlineChallengeSystem : GameStateSystemBase
{
	private BGC_OnlineChallengeData OnlineChallengeData;

	private BGS_GSEventCollection BGSCollection;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	public override void OnAttach()
	{
		OnlineChallengeData = RequireWritableData<BGC_OnlineChallengeData>();
		UnrealGameplayData = RequireReadOnlyData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		BGSCollection = BGS_GSEventCollection.Get(this);
		if (BGSCollection != null)
		{
			BGSCollection.Evt_BGS_OnlineChallengeBegin += new Del_Void_IntInt(OnOnlineChallengeBegin);
			BGSCollection.Evt_BGS_OnlineChallengeFailed += new Del_Void_Int(OnlineChallengeFailed);
			BGSCollection.Evt_BGS_OnlineOnePlayerDead += new Del_OnlineOnePlayerDead(OnlineOnePlayerDead);
			BGSCollection.Evt_BGS_OnlineOnePlayerFaildying += new Del_OnlineOnePlayerDead(OnlineOnePlayerFaildying);
			BGSCollection.Evt_BGS_OnlineChallengeSpawn += new Del_OnlineChallengeSpawn(OnOnlineChallengeSpawn);
			BGSCollection.Evt_BGS_WaveSpawnEventClear += new Del_Void_Actor(OnWaveSpawnEventClear);
		}
	}

	public override void OnNetActive()
	{
		base.OnNetActive();
		InitOnlineChallengeStageDict();
	}

	private void InitOnlineChallengeStageDict()
	{
		if (OnlineChallengeData.OnlineChallengeStageDict == null)
		{
			OnlineChallengeData.OnlineChallengeStageDict = new BindDictInt_EChallengeState();
		}
		Dictionary<int, FUStChallengeDesc> allChallengeDesc = BGW_GameDB.GetAllChallengeDesc();
		if (allChallengeDesc == null)
		{
			return;
		}
		foreach (FUStChallengeDesc value in allChallengeDesc.Values)
		{
			OnlineChallengeData.OnlineChallengeStageDict.Add(value.ID, EChallengeState.None);
		}
	}

	private void OnOnlineChallengeBegin(int ChallengeId, int Level)
	{
		if (!OnlineChallengeData.CheckCanChallengeStageCanBegin(ChallengeId))
		{
			return;
		}
		ChallengeInfo challengeInfo = new ChallengeInfo();
		challengeInfo.ChallengeLevel = Level;
		List<APlayerController> list = new List<APlayerController>();
		BindListEntity bindListEntity = new BindListEntity();
		FUStChallengeDesc challengeDesc = BGW_GameDB.GetChallengeDesc(ChallengeId);
		if (challengeDesc == null)
		{
			return;
		}
		List<APlayerController> allPlayerControllers = BGU_UnrealWorldUtil.GetAllPlayerControllers(GetOwner().World);
		if (allPlayerControllers != null)
		{
			foreach (APlayerController item in allPlayerControllers)
			{
				if (item.GetControlledPawn() != null)
				{
					AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetOwner(), challengeDesc.InteractGuid);
					AActor controlledPawn = item.GetControlledPawn();
					if (FVector.Distance(actorByGuid.GetActorLocation(), controlledPawn.GetActorLocation()) < (float)challengeDesc.Range)
					{
						list.Add(item);
						bindListEntity.Add(ECSExtension.ToEntity(controlledPawn));
					}
				}
			}
			int num = 0;
			switch (Level)
			{
			case 1:
				num = challengeDesc.LimitTimeEasy;
				break;
			case 2:
				num = challengeDesc.LimitTimeNormal;
				break;
			case 3:
				num = challengeDesc.LimitTimeHard;
				break;
			}
			challengeInfo.LimitTime = (float)num * 0.001f;
		}
		challengeInfo.ChallengingPlayerList = bindListEntity;
		challengeInfo.RecordPlayerList = list;
		challengeInfo.FallDyingPlayerList = new BindListEntity();
		challengeInfo.ChallengeId = ChallengeId;
		challengeInfo.BeginTime = UBGWFunctionLibraryCS.GetUTCTimeStamp();
		OnlineChallengeData.ChallengeBegin(ChallengeId, challengeInfo);
		if (OnlineChallengeData.OnlineChallengeStageDict.TryGetValue(ChallengeId, out var _))
		{
			OnlineChallengeData.OnlineChallengeStageDict[ChallengeId] = EChallengeState.Begin;
		}
		foreach (APlayerController item2 in list)
		{
			if (!item2.IsNullOrDestroyed())
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(item2.GetControlledPawn());
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_OnlineChallengeBeginToUI.Invoke(ChallengeId, Level);
				}
			}
		}
		OssReportChallengeBegin(ChallengeId);
	}

	private void OnlineChallengeSuccess(int ChallengeId)
	{
		if (!OnlineChallengeData.OnlineChallengeList.TryGetValue(ChallengeId, out var OutValue))
		{
			return;
		}
		OutValue.ChallengeSuccess = true;
		FUStChallengeDesc challengeDesc = BGW_GameDB.GetChallengeDesc(ChallengeId);
		if (challengeDesc == null)
		{
			return;
		}
		OutValue.RewardDelayTime = (float)challengeDesc.AwardDelayTime * 0.001f;
		foreach (APlayerController recordPlayer in OutValue.RecordPlayerList)
		{
			if (!recordPlayer.IsNullOrDestroyed())
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(recordPlayer.GetControlledPawn());
				if (bUS_GSEventCollection != null)
				{
					bUS_GSEventCollection.Evt_OnlineChallengeEndToUI.Invoke(ChallengeId);
				}
			}
		}
	}

	private void OnlineChallengeFailed(int ChallengeId)
	{
		if (BGW_GameDB.GetChallengeDesc(ChallengeId) == null)
		{
			return;
		}
		if (OnlineChallengeData.OnlineChallengeList.TryGetValue(ChallengeId, out var OutValue))
		{
			foreach (APlayerController recordPlayer in OutValue.RecordPlayerList)
			{
				if (!recordPlayer.IsNullOrDestroyed())
				{
					BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(recordPlayer.GetControlledPawn());
					if (bUS_GSEventCollection != null)
					{
						bUS_GSEventCollection.Evt_OnlineChallengeEndToUI.Invoke(ChallengeId);
					}
				}
			}
		}
		if (OnlineChallengeData.OnlineChallengeStageDict.TryGetValue(ChallengeId, out var _))
		{
			OnlineChallengeData.OnlineChallengeStageDict[ChallengeId] = EChallengeState.Failed;
		}
		OnlineChallengeData.ChallengeFailed(ChallengeId);
	}

	private void OnlineOnePlayerDead(APlayerController PlayerController)
	{
		if (PlayerController.IsNullOrDestroyed())
		{
			return;
		}
		foreach (KeyValuePair<int, ChallengeInfo> onlineChallenge in OnlineChallengeData.OnlineChallengeList)
		{
			BindListEntity challengingPlayerList = onlineChallenge.Value.ChallengingPlayerList;
			foreach (Entity item in challengingPlayerList)
			{
				if (ECSExtension.ToActor(item) == PlayerController?.GetControlledPawn())
				{
					challengingPlayerList.Remove(item);
					break;
				}
			}
			APawn controlledPawn = PlayerController.GetControlledPawn();
			onlineChallenge.Value.FallDyingPlayerList.Add(ECSExtension.ToEntity(controlledPawn));
			if (challengingPlayerList.Count == 0)
			{
				OssReportChallengeEnd(onlineChallenge.Key, EChallengeEndReason.ChallengeAlldead);
				OnlineChallengeFailed(onlineChallenge.Key);
				break;
			}
		}
	}

	private void OnlineOnePlayerFaildying(APlayerController PlayerController)
	{
		if (PlayerController == null)
		{
			return;
		}
		foreach (KeyValuePair<int, ChallengeInfo> onlineChallenge in OnlineChallengeData.OnlineChallengeList)
		{
			BindListEntity fallDyingPlayerList = onlineChallenge.Value.FallDyingPlayerList;
			BindListEntity challengingPlayerList = onlineChallenge.Value.ChallengingPlayerList;
			foreach (Entity item in fallDyingPlayerList)
			{
				if (ECSExtension.ToActor(item) == PlayerController.GetControlledPawn())
				{
					fallDyingPlayerList.Remove(item);
					break;
				}
			}
			if (fallDyingPlayerList.Count == 0 && challengingPlayerList.Count == 0)
			{
				if (BGW_GameDB.GetChallengeDesc(onlineChallenge.Key) != null)
				{
					OnlineChallengeData.ChallengeEnd(onlineChallenge.Key);
				}
				break;
			}
		}
	}

	private void OnOnlineChallengeSpawn(int ChallengeId, AActor Spawner)
	{
		if (OnlineChallengeData.OnlineChallengeList.TryGetValue(ChallengeId, out var OutValue))
		{
			OutValue.ChallengeSpawner = Spawner;
		}
	}

	private void OnWaveSpawnEventClear(AActor Spawner)
	{
		foreach (KeyValuePair<int, ChallengeInfo> onlineChallenge in OnlineChallengeData.OnlineChallengeList)
		{
			if (!(onlineChallenge.Value.ChallengeSpawner == Spawner))
			{
				continue;
			}
			int key = onlineChallenge.Key;
			if (BGW_GameDB.GetChallengeDesc(key) != null)
			{
				OnlineChallengeSuccess(key);
				if (OnlineChallengeData.OnlineChallengeStageDict.TryGetValue(key, out var _))
				{
					OnlineChallengeData.OnlineChallengeStageDict[key] = EChallengeState.Success;
				}
				OssReportChallengeEnd(key, EChallengeEndReason.ChallengeSuccess);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (OnlineChallengeData.OnlineChallengeList != null)
		{
			TickChallengeTime(DeltaTime);
			TickReWardDelayTime(DeltaTime);
		}
	}

	private void TickChallengeTime(float DeltaTime)
	{
		foreach (KeyValuePair<int, EChallengeState> item in OnlineChallengeData.OnlineChallengeStageDict)
		{
			if (item.Value != EChallengeState.Begin)
			{
				continue;
			}
			int key = item.Key;
			if (OnlineChallengeData.OnlineChallengeList[key].LimitTime > 0f)
			{
				OnlineChallengeData.OnlineChallengeList[key].LimitTime -= DeltaTime;
				if (OnlineChallengeData.OnlineChallengeList[key].LimitTime <= 0f)
				{
					OnlineChallengeFailed(key);
					OssReportChallengeEnd(key, EChallengeEndReason.ChallengeTimeout);
					OnlineChallengeData.ChallengeEnd(key);
					break;
				}
			}
		}
	}

	private void TickReWardDelayTime(float DeltaTime)
	{
		foreach (KeyValuePair<int, EChallengeState> item in OnlineChallengeData.OnlineChallengeStageDict)
		{
			if (item.Value != EChallengeState.Success)
			{
				continue;
			}
			int key = item.Key;
			int dropIdByGuid = OnlineChallengeData.GetDropIdByGuid(key, OnlineChallengeData.OnlineChallengeList[key].ChallengeLevel);
			if (OnlineChallengeData.OnlineChallengeList[key].RewardDelayTime > 0f)
			{
				OnlineChallengeData.OnlineChallengeList[key].RewardDelayTime -= DeltaTime;
				if (OnlineChallengeData.OnlineChallengeList[key].RewardDelayTime <= 0f)
				{
					foreach (APlayerController recordPlayer in OnlineChallengeData.OnlineChallengeList[key].RecordPlayerList)
					{
						if (!recordPlayer.IsNullOrDestroyed() && !CheckOnePlayHasReward(recordPlayer, dropIdByGuid))
						{
							BGSCollection.Evt_BGS_ChallengeSuccessDropItem.Invoke(recordPlayer.GetControlledPawn(), dropIdByGuid);
						}
					}
				}
			}
			if (!OnlineChallengeData.OnlineChallengeList[key].ChallengeSuccess)
			{
				continue;
			}
			bool flag = true;
			foreach (APlayerController recordPlayer2 in OnlineChallengeData.OnlineChallengeList[key].RecordPlayerList)
			{
				if (!recordPlayer2.IsNullOrDestroyed() && !CheckOnePlayHasReward(recordPlayer2, dropIdByGuid))
				{
					flag = false;
				}
			}
			if (flag)
			{
				OnlineChallengeAwarded(key);
				OnlineChallengeData.ChallengeEnd(key);
				break;
			}
		}
	}

	private bool CheckOnePlayHasReward(APlayerController PlayerController, int DropId)
	{
		if (PlayerController == null)
		{
			return true;
		}
		BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(PlayerController);
		bool result = false;
		foreach (ReadOnlyDropRecord dropRecord in readOnlyData.RoleData.RoleCs.Drop.DropRecordList)
		{
			if (DropId == dropRecord.DropId && dropRecord.DropCount != 0)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	private void OnlineChallengeAwarded(int ChallengeId)
	{
		if (BGW_GameDB.GetChallengeDesc(ChallengeId) != null && OnlineChallengeData.OnlineChallengeStageDict.TryGetValue(ChallengeId, out var _))
		{
			OnlineChallengeData.OnlineChallengeStageDict[ChallengeId] = EChallengeState.Awarded;
		}
	}

	private void OssReportChallengeBegin(int ChallengeId)
	{
	}

	private void OssReportChallengeEnd(int ChallengeId, EChallengeEndReason EndReason)
	{
	}

	private PlayerInfo GetPlayerInfoByPlayerControl(APlayerController PlayerController)
	{
		PlayerInfo playerInfo = new PlayerInfo();
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(PlayerController);
		playerInfo.Battle = BGUFuncLibPlayer.GetSvrPlayerInfoBattleData(GetOwner().World);
		if (readOnlyData != null && readOnlyData.RoleData != null)
		{
			playerInfo.Role = new PlayerInfoRole();
			RoleDataHelper.FillOssPlayerRoleInfo(readOnlyData.RoleData, playerInfo.Role, PlayerController);
		}
		else
		{
			BGW_LogUtil.LogError("OSS GetPlayerInfoData failed with reason: PlayerRoleData is invalid");
		}
		return playerInfo;
	}
}
