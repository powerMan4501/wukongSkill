using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_TamerStatSyncSystemRemoteControl : PlayerControllerSystemBase
{
	private BPC_SyncTamerDataServer SyncTamerData;

	private BGC_TamerData BGCTamerData;

	public override void OnAttach()
	{
		SyncTamerData = RequireWritableData<BPC_SyncTamerDataServer>();
		BGCTamerData = BGU_DataUtil.GetReadOnlyData<BGC_TamerData>(UGameplayStatics.GetGameState(GetOwner()));
		GetPlayerEventCollection().Evt_BPS_ServerActivateTamer += new Del_ServerActivateTamer(ActivateTamer);
		GetPlayerEventCollection().Evt_BPS_ServerNotifyClientTamerBackToLoad += new Del_ServerNotifyClientTamerBackToLoad(NotifyClientTamerBackToLoad);
		GetPlayerEventCollection().Evt_BPS_ServerNotifyClientAuthorityTamerDead += new Del_ServerNotifyClientAuthorityTamerDead(NotifyClientAuthorityTamerDead);
		GetPlayerEventCollection().Evt_BPS_ServerSpawnDynamicTamer += new Del_ServerSpawnDynamicTamer(SpawnDynamicTamer);
	}

	public override void OnNetActive()
	{
		base.OnNetActive();
		base.BGSEventCollection.Evt_TamerPhaseChanged += new Del_TamerPhaseChanged(OnTamerPhaseChanged);
	}

	public override void OnNetDeActive()
	{
		base.OnNetDeActive();
		base.BGSEventCollection.Evt_TamerPhaseChanged -= new Del_TamerPhaseChanged(OnTamerPhaseChanged);
	}

	private void SpawnDynamicTamer(FDynamicTamerSpawnReq TamerSpawnReq)
	{
		if (BGCTamerData.UnitGuid2Tamer.ContainsKey(TamerSpawnReq.TamerGuidOverride))
		{
			BGW_LogUtil.LogError("SpawnDynamicTamer " + TamerSpawnReq.TamerGuidOverride + " Duplicated!!!");
			return;
		}
		_ = DebugConfig.OpenGSRepLog;
		BUTamerActor bUTamerActor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(GetOwner().World, TamerSpawnReq.TamerClass.Value, TamerSpawnReq.SpawnWorldTransform, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
		if (!(bUTamerActor == null))
		{
			bUTamerActor.MarkAsClientSpawnedTamer(GetOwner() as APlayerController, TamerSpawnReq.TamerGuidOverride);
			UBGUFunctionLibrary.BGUFinishSpawningActor(bUTamerActor, TamerSpawnReq.SpawnWorldTransform);
		}
	}

	private void NotifyClientAuthorityTamerDead(List<string> Tamers)
	{
		foreach (string Tamer in Tamers)
		{
			if (DebugConfig.OpenGSRepLog)
			{
				BGW_LogUtil.LogError("NotifyClientAuthorityTamerDead TamerGuid:" + Tamer);
			}
			if (!BGCTamerData.UnitGuid2Tamer.TryGetValue(Tamer, out var value) || !value.InstancePtr.IsValid())
			{
				BGW_LogUtil.LogError($"NotifyClientAuthorityTamerDead TamerGuid:{Tamer} InValid {value?.InstancePtr.IsValid()}");
				continue;
			}
			BGUCharacterCS bGUCharacterCS = value.MonsterInstancePtr.Get();
			if (bGUCharacterCS.IsNullOrDestroyed() || BGUFunctionLibraryCS.GetCharacterAuthorityPlayerController(bGUCharacterCS) == GetOwner())
			{
				value.SyncMonsterDeadState();
				if (!bGUCharacterCS.IsNullOrDestroyed())
				{
					BGU_UnrealWorldUtil.DestroyActor(bGUCharacterCS);
				}
				else
				{
					BGW_LogUtil.LogError("NotifyClientAuthorityTamerDead TamerGuid:" + Tamer + " Monster IsNullOrDestroyed!!!");
				}
			}
		}
	}

	private void NotifyClientTamerBackToLoad(List<string> Tamers)
	{
		foreach (string Tamer in Tamers)
		{
			_ = DebugConfig.OpenGSRepLog;
			if (!BGCTamerData.UnitGuid2Tamer.TryGetValue(Tamer, out var value) || !value.InstancePtr.IsValid())
			{
				BGW_LogUtil.LogError($"NotifyClientTamerBackToLoad TamerGuid:{Tamer} InValid {value?.InstancePtr.IsValid()}");
				continue;
			}
			SyncTamerData.TamerGuidWaitingSpawn.Remove(Tamer);
			base.BGSEventCollection.Evt_BGS_UnRegisterTamerAuthInfo.Invoke(value.TamerGuid, GetOwner() as APlayerController);
		}
	}

	private void OnTamerPhaseChanged(FTamerRef InTamer, ETamerPhase OldPhase, ETamerPhase NewPhase)
	{
		_ = DebugConfig.OpenGSRepLog;
		if (NewPhase == ETamerPhase.Visible && SyncTamerData.TamerGuidWaitingSpawn.Contains(InTamer.TamerGuid))
		{
			base.BGSEventCollection.Evt_BGS_RegisterTamerAuthInfo.Invoke(InTamer.TamerGuid, GetOwner() as APlayerController);
			SyncTamerData.TamerGuidWaitingSpawn.Remove(InTamer.TamerGuid);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		FlushCharactersWaingtingRoleSync();
	}

	public void FlushCharactersWaingtingRoleSync()
	{
		if (SyncTamerData.GuidsWaingtingRoleSync.Count > 0)
		{
			GetPlayerEventCollection().Evt_BPS_ClientInitCharacterNetRole.Invoke(SyncTamerData.GuidsWaingtingRoleSync);
			SyncTamerData.GuidsWaingtingRoleSync.Clear();
		}
	}

	private void ActivateTamer(List<string> Tamers)
	{
		foreach (string Tamer in Tamers)
		{
			if (!BGCTamerData.UnitGuid2Tamer.TryGetValue(Tamer, out var value) || !value.InstancePtr.IsValid())
			{
				BGW_LogUtil.LogError($"ActivateTamer {Tamer} InValid {value} {value?.InstancePtr.IsValid()}");
				_ = DebugConfig.OpenGSRepLog;
				SyncTamerData.GuidsWaingtingRoleSync.Add(new FTamerRoleSync
				{
					Guid = Tamer,
					SyncState = EClientTamerInitNetState.UnLoaded
				});
				continue;
			}
			_ = DebugConfig.OpenGSRepLog;
			switch (value.Phase)
			{
			case ETamerPhase.UnLoaded:
				BGW_LogUtil.LogError($"ActivateTamer {Tamer} InValid {value} {value?.InstancePtr.IsValid()}");
				_ = DebugConfig.OpenGSRepLog;
				SyncTamerData.GuidsWaingtingRoleSync.Add(new FTamerRoleSync
				{
					Guid = Tamer,
					SyncState = EClientTamerInitNetState.UnLoaded
				});
				break;
			case ETamerPhase.Dead:
				_ = DebugConfig.OpenGSRepLog;
				SyncTamerData.GuidsWaingtingRoleSync.Add(new FTamerRoleSync
				{
					Guid = Tamer,
					SyncState = EClientTamerInitNetState.Dead
				});
				break;
			case ETamerPhase.Loaded:
			case ETamerPhase.Visible:
			case ETamerPhase.ServerWaitingAuthorityECSBeginPlay:
			case ETamerPhase.PreBegunPlay:
			case ETamerPhase.Spawned:
				base.BGSEventCollection.Evt_BGS_RegisterTamerAuthInfo.Invoke(value.TamerGuid, GetOwner() as APlayerController);
				break;
			}
		}
	}
}
