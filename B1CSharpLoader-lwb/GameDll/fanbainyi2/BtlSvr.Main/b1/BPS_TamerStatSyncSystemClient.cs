using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_TamerStatSyncSystemClient : PlayerControllerSystemBase
{
	private BPC_SyncTamerDataClient SyncTamerData;

	private BGC_TamerData TamerData;

	public override void OnAttach()
	{
		SyncTamerData = RequireWritableData<BPC_SyncTamerDataClient>();
		TamerData = BGU_DataUtil.GetReadOnlyData<BGC_TamerData>(UGameplayStatics.GetGameState(GetOwner()));
		GetPlayerEventCollection().Evt_BPS_ClientInitCharacterNetRole += new Del_ClientInitCharacterNetRole(ClientInitCharacterNetRole);
		GetPlayerEventCollection().Evt_BPS_ClientInternalReqSpawnDynamicTamer += new Del_ClientInternalReqSpawnDynamicTamer(ReqSpawnDynamicTamer);
		GetPlayerEventCollection().Evt_BPS_BGUCharaterNetReceiveRole += new Del_Void_Actor(OnBGUCharaterNetReceiveRole);
	}

	protected string ReqSpawnDynamicTamer(TSubclassOf<BUTamerActor> TamerClass, FTransform SpawnWorldTransform, FUnitSpawnInfo UnitSpawnInfo, AActor TriggerSpawnActor)
	{
		string text = $"{UGSE_OnlineFuncLib.GetUniqueNetIdStringByPlayerController(GetOwner() as APlayerController)}{DateTime.Now.ToFileTimeUtc()}{SyncTamerData.ClientDynamicTamerSpawnIdxAlloc++}";
		while (SyncTamerData.ClientPendingDynamicTamerSpawnWaitingSpawn.ContainsKey(text) || TamerData.UnitGuid2Tamer.ContainsKey(text))
		{
			text = $"{UGSE_OnlineFuncLib.GetUniqueNetIdStringByPlayerController(GetOwner() as APlayerController)}{DateTime.Now.ToFileTimeUtc()}{SyncTamerData.ClientDynamicTamerSpawnIdxAlloc++}";
		}
		_ = DebugConfig.OpenGSRepLog;
		GetPlayerEventCollection().Evt_BPS_ServerSpawnDynamicTamer.Invoke(new FDynamicTamerSpawnReq
		{
			SpawnWorldTransform = SpawnWorldTransform,
			TamerClass = TamerClass,
			TamerGuidOverride = text,
			TriggerSpawnActor = TriggerSpawnActor
		});
		SyncTamerData.ClientPendingDynamicTamerSpawnWaitingSpawn.Add(text, UnitSpawnInfo);
		return text;
	}

	public override void OnNetActive()
	{
		base.OnNetActive();
		base.BGSEventCollection.Evt_TamerPhaseChanged += new Del_TamerPhaseChanged(OnTamerPhaseChanged);
		base.BGSEventCollection.Evt_BGS_ActorChannelOpen += new Del_ActorChannelOpen(OnActorChannelOpenFinish);
		base.BGSEventCollection.Evt_BGS_ActorChannelCleanUp += new Del_ActorChannelCleanUp(OnActorChannelCleanUp);
		BGU_CharacterAI[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGU_CharacterAI>(GetOwner());
		foreach (BGU_CharacterAI actor in allActorsOfClass)
		{
			OnBGUCharaterNetReceiveRole(actor);
		}
	}

	public override void OnNetDeActive()
	{
		base.OnNetDeActive();
		base.BGSEventCollection.Evt_TamerPhaseChanged -= new Del_TamerPhaseChanged(OnTamerPhaseChanged);
		base.BGSEventCollection.Evt_BGS_ActorChannelOpen -= new Del_ActorChannelOpen(OnActorChannelOpenFinish);
		base.BGSEventCollection.Evt_BGS_ActorChannelCleanUp -= new Del_ActorChannelCleanUp(OnActorChannelCleanUp);
	}

	private void OnActorChannelCleanUp(long ActorNetGUID, APlayerController PlayerController, EChannelCloseReason CloseReason)
	{
		if (CloseReason != EChannelCloseReason.GSAuthSwitchToSimulate && CloseReason != EChannelCloseReason.GSAuthSwitchToAuthority)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = UGSE_OnlineFuncLib.GetObjByNetGuid(GetOwner(), ActorNetGUID) as BGUCharacterCS;
		if (!GSEUtil.Ensure(bGUCharacterCS != null))
		{
			return;
		}
		BUTamerActor bUTamerActor = bGUCharacterCS.GetTamerOwner() as BUTamerActor;
		if (GSEUtil.Ensure(bUTamerActor != null))
		{
			string finalGuid = bUTamerActor.GetFinalGuid();
			GSEUtil.Check(TamerData.UnitGuid2Tamer.TryGetValue(finalGuid, out var value), "BPS_TamerStatSyncSystemClient::OnActorChannelCleanUp GUID:" + finalGuid + " TamerRef Not Found!!!");
			if (CloseReason == EChannelCloseReason.GSAuthSwitchToAuthority)
			{
				SyncTamerData.ClientAuthWaitingChannelOpen.Add(ActorNetGUID);
				UpdateMonsterNetState(value, HasAuthority: true);
			}
			else
			{
				UpdateMonsterNetState(value, HasAuthority: false);
				UpdateActorChannelState(value, HasAuthority: false);
			}
		}
	}

	private void OnBGUCharaterNetReceiveRole(AActor Actor)
	{
		BGUCharacterCS bGUCharacterCS = Actor as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		BUTamerActor bUTamerActor = bGUCharacterCS.GetTamerOwner() as BUTamerActor;
		if (bUTamerActor != null)
		{
			string finalGuid = bUTamerActor.GetFinalGuid();
			GSEUtil.Check(TamerData.UnitGuid2Tamer.TryGetValue(finalGuid, out var value), "BPS_TamerStatSyncSystemClient::OnBGUCharaterNetReceiveRole GUID:" + finalGuid + " TamerRef Not Found!!!");
			if (value.Phase == ETamerPhase.ClientWaitingChannelAndAuthRoleReady && !BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Actor))
			{
				value.OnClientChannelAndNetRoleReady();
				UpdateMonsterNetState(value, HasAuthority: false);
			}
		}
	}

	private void OnActorChannelOpenFinish(AActor Actor, APlayerController PlayerController)
	{
		BGUCharacterCS bGUCharacterCS = Actor as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		BUTamerActor bUTamerActor = bGUCharacterCS.GetTamerOwner() as BUTamerActor;
		if (!(bUTamerActor != null))
		{
			return;
		}
		string finalGuid = bUTamerActor.GetFinalGuid();
		GSEUtil.Check(TamerData.UnitGuid2Tamer.TryGetValue(finalGuid, out var value), "BPS_TamerStatSyncSystemClient::OnActorChannelCreate GUID:" + finalGuid + " TamerRef Not Found!!!");
		long objNetGuid = UGSE_OnlineFuncLib.GetObjNetGuid(value.MonsterInstancePtr.Get());
		if (SyncTamerData.ClientAuthWaitingChannelOpen.Contains(objNetGuid))
		{
			UpdateActorChannelState(value, HasAuthority: true);
			if (value.Phase == ETamerPhase.ClientWaitingChannelAndAuthRoleReady)
			{
				value.OnClientChannelAndNetRoleReady();
			}
			SyncTamerData.ClientAuthWaitingChannelOpen.Remove(objNetGuid);
		}
		else
		{
			UpdateMonsterNetState(value, HasAuthority: false);
		}
	}

	private void OnTamerPhaseChanged(FTamerRef InTamer, ETamerPhase OldPhase, ETamerPhase NewPhase)
	{
		_ = DebugConfig.OpenGSRepLog;
		switch (NewPhase)
		{
		case ETamerPhase.ClientWaitingChannelAndAuthRoleReady:
			SyncTamerData.GuidsWaitingActivate.Add(InTamer.TamerGuid);
			break;
		case ETamerPhase.ClientBackToLoadWaitChannelClose:
			SyncTamerData.GuidsWaitingNotifyBackToLoad.Add(InTamer.TamerGuid);
			break;
		case ETamerPhase.ClientAuthorityDeadDestroyWaitChannelClose:
			SyncTamerData.GuidsWaitingNotifyAuthorityDead.Add(InTamer.TamerGuid);
			break;
		case ETamerPhase.Loaded:
		{
			if (SyncTamerData.ClientPendingDynamicTamerSpawnWaitingSpawn.TryGetValue(InTamer.TamerGuid, out var value))
			{
				InTamer.InstancePtr.Get().MarkAsSpawnedTamer(value);
				SyncTamerData.ClientPendingDynamicTamerSpawnWaitingSpawn.Remove(InTamer.TamerGuid);
			}
			break;
		}
		}
	}

	private void ClientInitCharacterNetRole(List<FTamerRoleSync> Infos)
	{
		foreach (FTamerRoleSync Info in Infos)
		{
			if (!TamerData.UnitGuid2Tamer.TryGetValue(Info.Guid, out var value))
			{
				BGW_LogUtil.LogError("ClientUpdateCharacterNetRole Guid:" + Info.Guid + " TamerRef Not Found");
				continue;
			}
			_ = DebugConfig.OpenGSRepLog;
			if (Info.SyncState == EClientTamerInitNetState.UnLoaded)
			{
				BGW_LogUtil.LogError("ClientUpdateCharacterNetRole Guid:" + Info.Guid + " UnLoaded");
				BGU_UnrealWorldUtil.RequestDestroyUnit(GetOwner(), Info.Guid);
			}
			else if (Info.SyncState == EClientTamerInitNetState.Dead)
			{
				base.BGWEventCollection.Evt_SetActorAliveState(Info.Guid, P2: false);
				value.SyncMonsterDeadState();
			}
		}
	}

	private void UpdateActorChannelState(FTamerRef TamerRef, bool HasAuthority)
	{
		UB1ReplicationGraph uB1ReplicationGraph = UGSE_OnlineFuncLib.GetReplicationGraph(GetOwner()) as UB1ReplicationGraph;
		if (HasAuthority)
		{
			uB1ReplicationGraph.AddBGUCharacterToAlwaysRelevantNodeCS(TamerRef.MonsterInstancePtr.Get());
		}
		else
		{
			uB1ReplicationGraph.RemoveBGUCharacterFromAlwaysRelevantNodeCS(TamerRef.MonsterInstancePtr.Get());
		}
	}

	private void UpdateMonsterNetState(FTamerRef TamerRef, bool HasAuthority)
	{
		TamerRef.MonsterInstancePtr.Get().FreshNetRole(HasAuthority);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (SyncTamerData.GuidsWaitingActivate.Count > 0)
		{
			GetPlayerEventCollection().Evt_BPS_ServerActivateTamer.Invoke(SyncTamerData.GuidsWaitingActivate);
			SyncTamerData.GuidsWaitingActivate.Clear();
		}
		if (SyncTamerData.GuidsWaitingNotifyBackToLoad.Count > 0)
		{
			GetPlayerEventCollection().Evt_BPS_ServerNotifyClientTamerBackToLoad.Invoke(SyncTamerData.GuidsWaitingNotifyBackToLoad);
			SyncTamerData.GuidsWaitingNotifyBackToLoad.Clear();
		}
		if (SyncTamerData.GuidsWaitingNotifyAuthorityDead.Count > 0)
		{
			GetPlayerEventCollection().Evt_BPS_ServerNotifyClientAuthorityTamerDead.Invoke(SyncTamerData.GuidsWaitingNotifyAuthorityDead);
			SyncTamerData.GuidsWaitingNotifyAuthorityDead.Clear();
		}
	}
}
