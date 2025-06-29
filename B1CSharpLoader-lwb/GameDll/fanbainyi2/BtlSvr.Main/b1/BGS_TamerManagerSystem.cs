using System;
using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using b1.Plugins.Calliope;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BGS_TamerManagerSystem : GameStateSystemBase
{
	private const int MonsterCountWarningLimit = 15;

	private const int MonsterCountSeriousLimit = 30;

	public static int MonsterCount;

	private BGC_TamerData TamerData { get; set; }

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	private IBIC_TaskData TaskData { get; set; }

	public override void OnAttach()
	{
		TamerData = RequireWritableData<BGC_TamerData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		TaskData = RequireReadonlyGameInstanceData<IBIC_TaskData, BIC_TaskData>();
		TamerData.bEnableTamerStrategy = false;
		TamerData.TamerStrategyMap[ETamerType.LevelLoaded] = new ProcessChainTamerStrategy();
		TamerData.TamerStrategyMap[ETamerType.Spawned] = new SpawnedTamerStrategy();
		TamerData.TamerStrategyMap[ETamerType.Summoned] = new ServantTamerStrategy();
		TamerData.LineTraceManager = UObject.NewObject<UTamerAsyncLineTraceManager>(Owner);
		foreach (KeyValuePair<ETamerType, TamerStrategyBase> item in TamerData.TamerStrategyMap)
		{
			item.Value.Initial(Owner, TamerData.LineTraceManager);
		}
		base.BGSEventCollection.Evt_RegisterTamer += new Del_RegisterTamer(OnRegisterTamer);
		base.BGSEventCollection.Evt_UnregisterTamer += new Del_Void_Tamer(OnUnregisterTamer);
		base.BGSEventCollection.Evt_TamerPhaseChanged += new Del_TamerPhaseChanged(OnTamerPhaseChanged);
		base.BGSEventCollection.Evt_RequestDestroyUnit += new Del_Void_String(OnRequestDestroyUnit);
		base.BGSEventCollection.Evt_MarkTamerNeverSpawn += new Del_Void_Tamer(OnMarkTamerNeverSpawn);
		base.BGSEventCollection.Evt_UnMarkTamerNeverSpawn += new Del_Void_Tamer(OnUnMarkTamerNeverSpawn);
		base.BGSEventCollection.Evt_EnableTamerOnlyMode += new Del_Void_StringList(OnEnableTamerOnlyMode);
		base.BGSEventCollection.Evt_DisableTamerOnlyMode += new Del_Void_StringList(OnDisableTamerOnlyMode);
		base.BGSEventCollection.Evt_MarkTamerAlwaysSpawn += new Del_Void_String(OnMarkTamerAlwaysSpawn);
		base.BGSEventCollection.Evt_UnMarkTamerAlwaysSpawn += new Del_Void_String(OnUnMarkTamerAlwaysSpawn);
		base.BGSEventCollection.Evt_MarkTamerBlockingSpawn += new Del_Void_String(OnMarkTamerBlockingSpawn);
		base.BGSEventCollection.Evt_UnMarkTamerBlockingSpawn += new Del_Void_String(OnUnMarkTamerBlockingSpawn);
		base.BGSEventCollection.Evt_TamerBlockingSpawnImmediately += new Del_Void_String(TamerBlockingSpawnImmediately);
		base.BGSEventCollection.Evt_TriggerResetAllTamers += new Del_Void_ResetActorReason(OnResetAllTamers);
		base.BGSEventCollection.Evt_EnableTamerBack2Load += new Del_Void_Bool(OnEnableTamerBack2Load);
		base.BGSEventCollection.Evt_SetTamerStrategyArea += new Del_Void_SetTamerStrategyArea(SetTamerStrategyArea);
		base.BGSEventCollection.Evt_BGS_UnitDead += new Del_Void_StringDeadReason(OnUnitDead);
		base.BGSEventCollection.Evt_BGS_PostBGUCharacterDeadDestroy += new Del_Void_Actor(OnBGUCharacterDeadDestroy);
		base.BGSEventCollection.Evt_SendServantReq += new Del_Void_ServantReq(OnReceiveServantReq);
		base.BGSEventCollection.Evt_SetBossRushSpawnUnitAllowable += new Del_Void_Bool(SetBossRushSpawnUnitAllowable);
		if (!UGSE_EngineFuncLib.IsStandAlone(GetOwner().World))
		{
			base.BGSEventCollection.Evt_BGS_OnPlayerPostLogin += new Del_OnPlayerPostLogin(OnPlayerPostLogin);
			base.BGSEventCollection.Evt_BGS_OnPlayerLogOut += new Del_OnPlayerLogOut(OnPlayerLogOut);
			APlayerController[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<APlayerController>(Owner);
			foreach (APlayerController newPlayer in allActorsOfClass)
			{
				OnPlayerPostLogin(newPlayer);
			}
		}
		if (base.BGWEventCollection != null)
		{
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_PlayerDelayBeginPlayFinished = (Del_Void)Delegate.Combine(bGWEventCollection.Evt_PlayerDelayBeginPlayFinished, new Del_Void(OnPlayerDelayBeginPlayFinished));
			BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
			bGWEventCollection2.Evt_SetActorResetTypeOverride = (Del_Void_StringResetType)Delegate.Combine(bGWEventCollection2.Evt_SetActorResetTypeOverride, new Del_Void_StringResetType(SetActorResetTypeOverride));
			BGW_EventCollection bGWEventCollection3 = base.BGWEventCollection;
			bGWEventCollection3.Evt_SetGroupResetTypeOverride = (Del_Void_StringResetType)Delegate.Combine(bGWEventCollection3.Evt_SetGroupResetTypeOverride, new Del_Void_StringResetType(SetGroupResetTypeOverride));
			BGW_EventCollection bGWEventCollection4 = base.BGWEventCollection;
			bGWEventCollection4.Evt_ClearActorResetTypeOverride = (Del_Void_String)Delegate.Combine(bGWEventCollection4.Evt_ClearActorResetTypeOverride, new Del_Void_String(ClearActorResetTypeOverride));
			BGW_EventCollection bGWEventCollection5 = base.BGWEventCollection;
			bGWEventCollection5.Evt_BGW_CacheNPCInfo = (BGW_EventCollection.Del_BGW_CacheNPCInfo)Delegate.Combine(bGWEventCollection5.Evt_BGW_CacheNPCInfo, new BGW_EventCollection.Del_BGW_CacheNPCInfo(OnCacheNPCInfo));
		}
	}

	private void SetBossRushSpawnUnitAllowable(bool InAllowable)
	{
		TamerData.bAllowSpawnUnitInBossRushMode = InAllowable;
	}

	private void SetTamerStrategyArea(ETamerStrategyArea InArea)
	{
		FTamerStrategyPreDefines.SetTamerStrategyArea(InArea);
	}

	public override void OnBeginPlay()
	{
		BUTamerActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BUTamerActor>(Owner);
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			allActorsOfClass[i].ReTriggerRegister();
		}
		foreach (KeyValuePair<ETamerType, TamerStrategyBase> item in TamerData.TamerStrategyMap)
		{
			item.Value.BeginPlay();
		}
		foreach (KeyValuePair<string, TamerStrategyBase> item2 in TamerData.RemotePlayerStrategy)
		{
			item2.Value.BeginPlay();
		}
		FTamerStrategyPreDefines.InitDefines();
		BGW_WorldSettings bGW_WorldSettings = Owner.World.GetWorldSettings().Cast<BGW_WorldSettings>();
		if (bGW_WorldSettings != null && bGW_WorldSettings.EnableLevelOverride && bGW_WorldSettings.TamerSettingConfigDataAsset != null)
		{
			FTamerStrategyPreDefines.SetTamerStrategyByWorldSetting(bGW_WorldSettings.TamerSettingConfigDataAsset.TamerStrategyPreDefinesForLevelOverride);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1032;
	}

	public void OnTick(float DeltaTime)
	{
		TamerStrategyBase.CurrentFrameHandleCount = 0;
		foreach (KeyValuePair<ETamerType, TamerStrategyBase> item in TamerData.TamerStrategyMap)
		{
			item.Value.OnTick(DeltaTime);
		}
		foreach (KeyValuePair<string, TamerStrategyBase> item2 in TamerData.RemotePlayerStrategy)
		{
			item2.Value.OnTick(DeltaTime);
		}
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!TamerData.bEnableTamerStrategy || (B1Global.GIsBossRushMode && !TamerData.bAllowSpawnUnitInBossRushMode))
		{
			return;
		}
		switch (TickGroup)
		{
		case 1024:
			OnTick(DeltaTime);
			break;
		case 8:
			foreach (KeyValuePair<ETamerType, TamerStrategyBase> item in TamerData.TamerStrategyMap)
			{
				TamerStrategyBase value = item.Value;
				value.OnAfterAnimTick(DeltaTime);
				foreach (FTamerRef needUnregisterTamer in value.NeedUnregisterTamers)
				{
					OnUnregisterTamer(needUnregisterTamer);
				}
				value.NeedUnregisterTamers.Clear();
			}
			foreach (KeyValuePair<string, TamerStrategyBase> item2 in TamerData.RemotePlayerStrategy)
			{
				item2.Value.OnAfterAnimTick(DeltaTime);
			}
			ConsumeFallingCheckQueue();
			if (TamerData.TickTimeFor1000ms >= 1f)
			{
				OnTickFor1000ms(TamerData.TickTimeFor1000ms);
				TamerData.TickTimeFor1000ms = 0f;
			}
			else
			{
				TamerData.TickTimeFor1000ms += DeltaTime;
			}
			break;
		}
	}

	private void OnTickFor1000ms(float DeltaTime)
	{
		if (TamerData.TamerStrategyMap.ContainsKey(ETamerType.LevelLoaded))
		{
			UpdateSpawnedTamerList();
			int currentFrameDelayDestroyCount = TamerData.TamerStrategyMap[ETamerType.LevelLoaded].CurrentFrameDelayDestroyCount;
			FLinearColor color = FLinearColor.Green;
			if (MonsterCount >= 30)
			{
				color = FLinearColor.Red;
			}
			else if (MonsterCount >= 15)
			{
				color = FLinearColor.Yellow;
			}
			DrawDebugString($"当前怪物数量：{MonsterCount}\n 销毁队列怪物数量: {currentFrameDelayDestroyCount}", DeltaTime, color);
		}
		if (TamerData.FallingCheckQueue.Count != 0)
		{
			return;
		}
		foreach (KeyValuePair<string, FTamerRef> item in TamerData.UnitGuid2Tamer)
		{
			FTamerRef value = item.Value;
			if (value != null && value.Phase == ETamerPhase.Spawned)
			{
				TamerData.FallingCheckQueue.Enqueue(item.Key);
			}
		}
	}

	private void UpdateSpawnedTamerList()
	{
		MonsterCount = 0;
		TamerData.CurrentSpawnedTamers.Clear();
		foreach (KeyValuePair<ETamerType, TamerStrategyBase> item in TamerData.TamerStrategyMap)
		{
			item.Value.GetTamersByPhase(ETamerPhase.Spawned, out var OutTamerRefList);
			foreach (FTamerRef item2 in OutTamerRefList)
			{
				if (item2.IsMonsterValid())
				{
					TamerData.CurrentSpawnedTamers.Add(item2.TamerGuid);
					MonsterCount++;
				}
			}
		}
	}

	private void ConsumeFallingCheckQueue()
	{
		int num = 0;
		while (TamerData.FallingCheckQueue.Count > 0 && num <= 5)
		{
			string unitGuid = TamerData.FallingCheckQueue.Dequeue();
			num++;
			if (TamerData.TryGetTamerEntityRef(unitGuid, out var OutTamerRef) && OutTamerRef.Phase == ETamerPhase.Spawned && OutTamerRef.MonsterInstancePtr.IsValid())
			{
				BGUCharacterCS bGUCharacterCS = OutTamerRef.MonsterInstancePtr.Get();
				if (!(bGUCharacterCS == null) && FMath.Abs(OutTamerRef.LocationZ - BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS).Z) >= OutTamerRef.FallingCheckThreshold)
				{
					BGUFuncLibActorTransformCS.BGUSetActorTransform(bGUCharacterCS, OutTamerRef.TamerTransform, bSweep: false, bTeleport: true);
				}
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		foreach (KeyValuePair<ETamerType, TamerStrategyBase> item in TamerData.TamerStrategyMap)
		{
			item.Value.Destroy();
		}
		TamerData.TamerStrategyMap.Clear();
		foreach (KeyValuePair<string, TamerStrategyBase> item2 in TamerData.RemotePlayerStrategy)
		{
			item2.Value.Destroy();
		}
		TamerData.RemotePlayerStrategy = null;
		foreach (KeyValuePair<ETamerType, List<FTamerRef>> item3 in TamerData.TamerType2Tamer)
		{
			if (item3.Key <= ETamerType.LevelLoaded)
			{
				continue;
			}
			foreach (FTamerRef item4 in item3.Value)
			{
				item4.DestroyTamer();
			}
		}
		TamerData.TamerType2Tamer.Clear();
		if (base.BGWEventCollection != null)
		{
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_PlayerDelayBeginPlayFinished = (Del_Void)Delegate.Remove(bGWEventCollection.Evt_PlayerDelayBeginPlayFinished, new Del_Void(OnPlayerDelayBeginPlayFinished));
			BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
			bGWEventCollection2.Evt_SetActorResetTypeOverride = (Del_Void_StringResetType)Delegate.Remove(bGWEventCollection2.Evt_SetActorResetTypeOverride, new Del_Void_StringResetType(SetActorResetTypeOverride));
			BGW_EventCollection bGWEventCollection3 = base.BGWEventCollection;
			bGWEventCollection3.Evt_SetGroupResetTypeOverride = (Del_Void_StringResetType)Delegate.Remove(bGWEventCollection3.Evt_SetGroupResetTypeOverride, new Del_Void_StringResetType(SetGroupResetTypeOverride));
			BGW_EventCollection bGWEventCollection4 = base.BGWEventCollection;
			bGWEventCollection4.Evt_ClearActorResetTypeOverride = (Del_Void_String)Delegate.Remove(bGWEventCollection4.Evt_ClearActorResetTypeOverride, new Del_Void_String(ClearActorResetTypeOverride));
			BGW_EventCollection bGWEventCollection5 = base.BGWEventCollection;
			bGWEventCollection5.Evt_BGW_CacheNPCInfo = (BGW_EventCollection.Del_BGW_CacheNPCInfo)Delegate.Remove(bGWEventCollection5.Evt_BGW_CacheNPCInfo, new BGW_EventCollection.Del_BGW_CacheNPCInfo(OnCacheNPCInfo));
		}
		TamerData.LineTraceManager.ClearAllData();
		TamerData.LineTraceManager = null;
	}

	private void OnPlayerDelayBeginPlayFinished()
	{
		if (TamerData.bInitialized)
		{
			return;
		}
		TamerData.bInitialized = true;
		foreach (KeyValuePair<string, FTamerRef> item in TamerData.UnitGuid2Tamer)
		{
			if (GlobalActorData.HasActorAliveState(item.Key) && !GlobalActorData.GetActorAliveState(item.Key))
			{
				item.Value.SyncMonsterDeadState();
			}
		}
		if (!B1Global.GIsMovieRendering && !DebugConfig.EnablePlaneMoveMode)
		{
			TamerData.bEnableTamerStrategy = true;
		}
	}

	private void OnResetAllTamers(EResetActorReason ResetReason)
	{
		foreach (FTamerRef item in TamerData.UnitGuid2Tamer.Values.ToList())
		{
			if (item.TamerType > ETamerType.LevelLoaded)
			{
				OnUnregisterTamer(item);
				base.BGSEventCollection.Evt_BGS_ResetActorDestroy.Invoke(item.TamerGuid);
			}
		}
		foreach (FTamerRef item2 in TamerData.UnitGuid2Tamer.Values.ToList())
		{
			if (item2.TamerType <= ETamerType.LevelLoaded)
			{
				item2.OnReset(ResetReason);
			}
		}
	}

	private void OnRegisterTamer(FTamerRef InTamer)
	{
		if (InTamer == null || TamerData.UnitGuid2Tamer.ContainsKey(InTamer.TamerGuid) || !TamerData.TamerStrategyMap.ContainsKey(InTamer.TamerType))
		{
			return;
		}
		TamerData.UnitGuid2Tamer.Add(InTamer.TamerGuid, InTamer);
		if (TamerData.GroupGuid2TamerDict.TryGetValue(InTamer.TamerGoupGuid, out var value))
		{
			if (!value.ContainsKey(InTamer.TamerGuid))
			{
				value.Add(InTamer.TamerGuid, InTamer);
			}
		}
		else
		{
			TamerData.GroupGuid2TamerDict.Add(InTamer.TamerGoupGuid, new Dictionary<string, FTamerRef> { { InTamer.TamerGuid, InTamer } });
		}
		TamerData.TamerStrategyMap[InTamer.TamerType].AddTamer(InTamer);
		if (TamerData.WaitingRuleTamers.TryGetValue(InTamer.TamerGuid, out var value2))
		{
			InTamer.AddSpawnRuleFlag(value2);
			TamerData.WaitingRuleTamers.Remove(InTamer.TamerGuid);
		}
		if (TaskData.TryGetCacheNPCShowState(InTamer.TamerGuid, out var CacheNPCShowState))
		{
			InTamer.NPCShowState = CacheNPCShowState;
		}
		if (GlobalActorData.GetGroupOverrideResetType(InTamer.TamerGoupGuid, out var ResetType))
		{
			InTamer.GroupOverrideResetType = ResetType;
		}
		if (GlobalActorData.GetActorOverrideResetType(InTamer.TamerGuid, out ResetType))
		{
			InTamer.OverrideResetType = ResetType;
		}
		TamerData.LineTraceManager.RegisterTamerRef(InTamer.RefID, new FVector(InTamer.Location2D, InTamer.LocationZ), InTamer.CapsuleHalfHeight);
		InTamer.SyncMonsterDeadState();
	}

	private void OnUnregisterTamer(FTamerRef InTamer)
	{
		if (InTamer == null || !TamerData.UnitGuid2Tamer.ContainsKey(InTamer.TamerGuid))
		{
			return;
		}
		TamerData.TamerStrategyMap[InTamer.TamerType].RemoveTamer(InTamer);
		foreach (KeyValuePair<string, TamerStrategyBase> item in TamerData.RemotePlayerStrategy)
		{
			item.Value.RemoveTamer(InTamer);
		}
		TamerData.UnitGuid2Tamer.Remove(InTamer.TamerGuid);
		if (TamerData.GroupGuid2TamerDict.TryGetValue(InTamer.TamerGoupGuid, out var value))
		{
			if (value.ContainsKey(InTamer.TamerGuid))
			{
				value.Remove(InTamer.TamerGuid);
			}
			if (value.Count == 0)
			{
				TamerData.GroupGuid2TamerDict.Remove(InTamer.TamerGoupGuid);
			}
		}
		InTamer.DestroyTamer();
		TamerData.LineTraceManager.UnregisterTamerRef(InTamer.RefID);
	}

	private void OnUnitDead(string InUnitGuid, EDeadReason InDeadReason)
	{
		if (TamerData.UnitGuid2Tamer.TryGetValue(InUnitGuid, out var value))
		{
			TamerData.TamerStrategyMap[value.TamerType].OnTamerUnitDead(value, InDeadReason);
		}
	}

	private void OnTamerPhaseChanged(FTamerRef InTamer, ETamerPhase OldPhase, ETamerPhase NewPhase)
	{
		if (InTamer == null || !TamerData.UnitGuid2Tamer.ContainsKey(InTamer.TamerGuid))
		{
			return;
		}
		TamerData.TamerStrategyMap[InTamer.TamerType].OnTamerPhaseChanged(InTamer, OldPhase, NewPhase);
		foreach (KeyValuePair<string, TamerStrategyBase> item in TamerData.RemotePlayerStrategy)
		{
			item.Value.OnTamerPhaseChanged(InTamer, OldPhase, NewPhase);
		}
	}

	private void OnPlayerPostLogin(APlayerController NewPlayer)
	{
		if (!NewPlayer.IsNullOrDestroyed() && !NewPlayer.IsLocalController() && !TamerData.RemotePlayerStrategy.ContainsKey(NewPlayer.GetFullName()))
		{
			SpawnedTamerStrategy spawnedTamerStrategy = new SpawnedTamerStrategy();
			spawnedTamerStrategy.Initial(GetOwner(), TamerData.LineTraceManager);
			TamerData.RemotePlayerStrategy.Add(NewPlayer.GetFullName(), spawnedTamerStrategy);
		}
	}

	private void OnPlayerLogOut(AController Exitting)
	{
		if (!Exitting.IsNullOrDestroyed())
		{
			TamerData.RemotePlayerStrategy.Remove(Exitting.GetFullName());
		}
	}

	private void OnRequestDestroyUnit(string InUnitGuid)
	{
		if (TamerData.TryGetTamerEntityRef(InUnitGuid, out var OutTamerRef))
		{
			ETamerType tamerType = OutTamerRef.TamerType;
			if ((uint)(tamerType - 2) <= 1u)
			{
				OnUnregisterTamer(OutTamerRef);
			}
		}
	}

	private void OnMarkTamerNeverSpawn(FTamerRef InTamer)
	{
		InTamer.AddSpawnRuleFlag(ETamerSpawnRule.NeverSpawn);
	}

	private void OnUnMarkTamerNeverSpawn(FTamerRef InTamer)
	{
		InTamer.RemoveSpawnRuleFlag(ETamerSpawnRule.NeverSpawn);
	}

	private void OnMarkTamerAlwaysSpawn(string InTamerGuid)
	{
		AddTamerSpawnRule(InTamerGuid, ETamerSpawnRule.AlwaysSpawn);
	}

	private void OnUnMarkTamerAlwaysSpawn(string InTamerGuid)
	{
		RemoveTamerSpawnRule(InTamerGuid, ETamerSpawnRule.AlwaysSpawn);
	}

	private void TamerBlockingSpawnImmediately(string InTamerGuid)
	{
		if (TamerData.UnitGuid2Tamer.TryGetValue(InTamerGuid, out var value) && value.Phase > ETamerPhase.UnLoaded && value.Phase < ETamerPhase.Dead && value.InstancePtr.IsValid())
		{
			while (value.Phase != ETamerPhase.Spawned && value.IncrementalSpawnUnit(Owner))
			{
			}
			value.MonsterInstancePtr.IsValid();
		}
	}

	private void OnMarkTamerBlockingSpawn(string InTamerGuid)
	{
		AddTamerSpawnRule(InTamerGuid, ETamerSpawnRule.BlockingSpawn);
		TamerBlockingSpawnImmediately(InTamerGuid);
	}

	private void OnBGUCharacterDeadDestroy(AActor Actor)
	{
		if (UGSE_EngineFuncLib.IsStandAlone(Owner.World))
		{
			(((Actor as BGUCharacterCS).GetTamerOwner() as BUTamerActor)?.CurrentRef)?.AfterMonsterDead();
		}
		else
		{
			if (!BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Actor))
			{
				return;
			}
			FTamerRef fTamerRef = ((Actor as BGUCharacterCS).GetTamerOwner() as BUTamerActor)?.CurrentRef;
			bool flag = UGSE_OnlineFuncLib.InServerReal(GetOwner());
			if (fTamerRef != null)
			{
				if (!flag)
				{
					fTamerRef.OnClientAuthorityMonsterDeadDestroy();
				}
				else if (flag)
				{
					fTamerRef.SyncMonsterDeadState();
				}
			}
		}
	}

	private void OnUnMarkTamerBlockingSpawn(string InTamerGuid)
	{
		RemoveTamerSpawnRule(InTamerGuid, ETamerSpawnRule.BlockingSpawn);
	}

	private void OnEnableTamerOnlyMode(List<string> UnitGuidList)
	{
		foreach (string UnitGuid in UnitGuidList)
		{
			AddTamerSpawnRule(UnitGuid, ETamerSpawnRule.OnlySpawn);
		}
		TamerData.TamerStrategyMap[ETamerType.LevelLoaded].EnableOnlyMode();
	}

	private void OnDisableTamerOnlyMode(List<string> UnitGuidList)
	{
		foreach (string UnitGuid in UnitGuidList)
		{
			RemoveTamerSpawnRule(UnitGuid, ETamerSpawnRule.OnlySpawn);
		}
		TamerData.TamerStrategyMap[ETamerType.LevelLoaded].DisableOnlyMode();
	}

	private void OnEnableTamerBack2Load(bool bEnabled)
	{
		TamerData.TamerStrategyMap[ETamerType.LevelLoaded].bCanBack2Load = bEnabled;
	}

	private void SetActorResetTypeOverride(string UnitGuid, EBGUResetType InResetType)
	{
		if (TamerData.UnitGuid2Tamer.TryGetValue(UnitGuid, out var value))
		{
			value.OverrideResetType = InResetType;
		}
	}

	private void SetGroupResetTypeOverride(string UnitGroupGuid, EBGUResetType InResetType)
	{
		foreach (KeyValuePair<string, FTamerRef> item in TamerData.UnitGuid2Tamer)
		{
			FTamerRef value = item.Value;
			if (value != null && value.TamerGoupGuid.Equals(UnitGroupGuid))
			{
				value.GroupOverrideResetType = InResetType;
			}
		}
	}

	private void ClearActorResetTypeOverride(string UnitGuid)
	{
		if (TamerData.UnitGuid2Tamer.TryGetValue(UnitGuid, out var value))
		{
			value.OverrideResetType = null;
			value.GroupOverrideResetType = null;
		}
	}

	private void OnCacheNPCInfo(string UnitGuid, int TeamID, int IdleAMIdx, int LeisureAnimIndex, int InteractGroupID, EGsNPCShowState NPCShowState, List<NPCBuffInfo> NPCBuffInfoList)
	{
		if (TamerData.UnitGuid2Tamer.TryGetValue(UnitGuid, out var value))
		{
			value.NPCShowState = NPCShowState;
		}
	}

	public void DrawDebugString(string DebugString, float Duration, FLinearColor Color)
	{
		if (GSGameplayCVar.CVar_TamerShowMonsterCount.GetValueInGameThread() != 0)
		{
			APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner)?.GetControlledPawn();
			if (!(aPawn == null))
			{
				USystemLibrary.DrawDebugString(aPawn, FVector.UpVector * 100.0, DebugString, aPawn, Color, Duration);
			}
		}
	}

	public void OnReceiveServantReq(FServantReq ServantReq)
	{
		TamerData.ServantTamerReqCache[ServantReq.ServantTamerGuid] = ServantReq;
		base.BGSEventCollection.Evt_NotifyReceiveServantReq.Invoke(ServantReq);
	}

	private void AddTamerSpawnRule(string InTamerGuid, ETamerSpawnRule InSpawnRule)
	{
		if (TamerData.UnitGuid2Tamer.TryGetValue(InTamerGuid, out var value))
		{
			value.AddSpawnRuleFlag(InSpawnRule);
			return;
		}
		Dictionary<string, ETamerSpawnRule> waitingRuleTamers = TamerData.WaitingRuleTamers;
		if (waitingRuleTamers.TryGetValue(InTamerGuid, out var value2))
		{
			TamerSpawnRuleExtension.AddSpawnRuleFlag(ref InSpawnRule, value2);
		}
		waitingRuleTamers[InTamerGuid] = InSpawnRule;
	}

	private void RemoveTamerSpawnRule(string InTamerGuid, ETamerSpawnRule InSpawnRule)
	{
		if (TamerData.UnitGuid2Tamer.TryGetValue(InTamerGuid, out var value))
		{
			value.RemoveSpawnRuleFlag(InSpawnRule);
			return;
		}
		Dictionary<string, ETamerSpawnRule> waitingRuleTamers = TamerData.WaitingRuleTamers;
		if (waitingRuleTamers.TryGetValue(InTamerGuid, out var value2))
		{
			TamerSpawnRuleExtension.RemoveSpawnRuleFlag(ref InSpawnRule, value2);
			if (InSpawnRule == ETamerSpawnRule.Normal)
			{
				waitingRuleTamers.Remove(InTamerGuid);
			}
			else
			{
				waitingRuleTamers[InTamerGuid] = InSpawnRule;
			}
		}
	}
}
