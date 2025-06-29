using System;
using System.Collections.Generic;
using b1.BGW;
using b1.Plugins.CustomLightSystem;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BIS_ResetActorManager : GameInstanceSystemBase
{
	private BIC_ResetActorData ResetActorData;

	public override bool bTickEnabled => true;

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	private BGW_EventCollection EvtCollection { get; set; }

	public override void OnAttach()
	{
		ResetActorData = RequireWritableGameInstanceData<BIC_ResetActorData>();
		GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		EvtCollection = BGW_EventCollection.Get(base.Owner);
		BGW_EventCollection evtCollection = EvtCollection;
		evtCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Combine(evtCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnTriggerResetAllActors));
		BGW_EventCollection evtCollection2 = EvtCollection;
		evtCollection2.Evt_TriggerResetOneActor = (BGW_EventCollection.Del_TriggerResetOneActor)Delegate.Combine(evtCollection2.Evt_TriggerResetOneActor, new BGW_EventCollection.Del_TriggerResetOneActor(OnTriggerResetOneActor));
	}

	public override int GetTickGroupMask()
	{
		return 32;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (ResetActorData.NeedResetActorMap.Count == 0)
		{
			return;
		}
		foreach (KeyValuePair<string, EResetActorReason> item in ResetActorData.NeedResetActorMap)
		{
			DoTriggerResetOneActor(item.Key, item.Value);
		}
		ResetActorData.NeedResetActorMap.Clear();
	}

	private void OnTriggerResetAllActors(EResetActorReason ResetReason)
	{
		IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(base.Owner);
		if (gameStateReadonlyData == null)
		{
			return;
		}
		EvtCollection.Evt_ClearOverrideSceneObjStates();
		HashSet<string> resetAllActorList = GlobalActorData.GetResetAllActorList();
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(base.Owner);
		bGS_GSEventCollection.Evt_ClearAllSummon.Invoke();
		bGS_GSEventCollection.Evt_TriggerResetAllTamers.Invoke(ResetReason);
		foreach (string item in resetAllActorList)
		{
			if (!CheckIsPlayer(item) && !gameStateReadonlyData.TryGetTamerEntityRef(item, out var _))
			{
				TriggerResetImpl(item, ResetReason);
			}
		}
		EvtCollection.Evt_ResetPsmInstances();
		ACLSManager.RemoveAllDynamicLevel();
	}

	private void OnTriggerResetOneActor(string UnitGuid, EResetActorReason ResetReason)
	{
		if (ResetActorData.NeedResetActorMap.ContainsKey(UnitGuid))
		{
			ResetActorData.NeedResetActorMap[UnitGuid] = ResetReason;
		}
		else
		{
			ResetActorData.NeedResetActorMap.Add(UnitGuid, ResetReason);
		}
	}

	private void DoTriggerResetOneActor(string UnitGuid, EResetActorReason ResetReason)
	{
		if (CheckIsPlayer(UnitGuid))
		{
			return;
		}
		IBGC_CircusControlData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_CircusControlData>(base.Owner);
		if (gameStateReadonlyData != null)
		{
			CircusMember circusRootMember = gameStateReadonlyData.GetCircusRootMember(UnitGuid);
			if (circusRootMember != null)
			{
				OnTriggerResetCircus(circusRootMember, ResetReason);
				return;
			}
		}
		IBGC_TamerData gameStateReadonlyData2 = BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(base.Owner);
		if (gameStateReadonlyData2 != null)
		{
			if (gameStateReadonlyData2.TryGetTamerEntityRef(UnitGuid, out var OutTamerRef))
			{
				OutTamerRef.OnReset(ResetReason);
			}
			else
			{
				TriggerResetImpl(UnitGuid, ResetReason);
			}
		}
	}

	private void OnTriggerResetCircus(CircusMember RootNode, EResetActorReason ResetReason)
	{
		IBGC_TamerData TamerData = BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(base.Owner);
		if (TamerData == null)
		{
			return;
		}
		((IBGC_CircusControlData)BGU_DataUtil.GetGameStateReadonlyData<BGC_CircusControlData>(base.Owner)).TravelCircus(RootNode, (Action<CircusMember>)delegate(CircusMember Node)
		{
			if (TamerData.TryGetTamerEntityRef(Node.ActorGuid, out var OutTamerRef))
			{
				OutTamerRef.OnReset(ResetReason);
			}
			else
			{
				TriggerResetImpl(Node.ActorGuid, ResetReason);
			}
		});
	}

	private bool TriggerResetImpl(string UnitGuid, EResetActorReason ResetReason)
	{
		bool flag = false;
		List<string> list = new List<string>();
		if (UnitGuid.Length == 0)
		{
			return false;
		}
		switch (ResetReason)
		{
		case EResetActorReason.Rebirth:
		case EResetActorReason.InteractRebirthPoint:
			ResetAliveState(UnitGuid);
			flag = ResetOneActor(UnitGuid, ResetReason);
			break;
		case EResetActorReason.NewSpawn:
		case EResetActorReason.LevelStreaming:
		case EResetActorReason.MaxHeightOffset:
		case EResetActorReason.ReturnHome:
			flag = ResetOneActor(UnitGuid, ResetReason);
			break;
		}
		if (flag)
		{
			list.Add(UnitGuid);
		}
		foreach (string item in list)
		{
			EvtCollection.Evt_RemoveActorData(item);
		}
		return true;
	}

	private bool CheckIsPlayer(string UnitGuid)
	{
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, UnitGuid);
		if (actorByGuid == null)
		{
			return false;
		}
		IBUC_ActorBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_ActorBasicData, BUC_ActorBasicData>(actorByGuid);
		if (readOnlyData == null)
		{
			return false;
		}
		return readOnlyData.ActorType == BGU_ActorType.CharacterPlayer;
	}

	private void ResetAliveState(string UnitGuid)
	{
		if (GlobalActorData.GetActorResetType(UnitGuid, out var ResetType))
		{
			switch (ResetType)
			{
			case EBGUResetType.Destroy:
				EvtCollection.Evt_SetActorAliveState(UnitGuid, P2: false);
				break;
			case EBGUResetType.Spawn:
				EvtCollection.Evt_SetActorAliveState(UnitGuid, P2: true);
				break;
			case EBGUResetType.No:
			case EBGUResetType.Status:
			case EBGUResetType.StatusWithoutHp:
			case EBGUResetType.None:
				break;
			}
		}
	}

	private bool ResetOneActor(string UnitGuid, EResetActorReason ResetReason)
	{
		if (!GlobalActorData.IsActorInitDataInitialized(UnitGuid))
		{
			return false;
		}
		IBGC_CircusControlData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_CircusControlData>(base.Owner);
		string text = null;
		AActor aActor = null;
		if (gameStateReadonlyData != null)
		{
			CircusMember circusRootMember = gameStateReadonlyData.GetCircusRootMember(UnitGuid);
			if (circusRootMember != null)
			{
				text = circusRootMember.ActorGuid;
				aActor = BGU_DataUtil.GetActorByGuid(base.Owner, circusRootMember.ActorGuid);
			}
		}
		if (!(GlobalActorData.GetActorInitData(UnitGuid, EInitDataModuleType.Basic) is b1.GSBasicInitDataModule gSBasicInitDataModule))
		{
			return false;
		}
		if (!GlobalActorData.GetActorResetType(text ?? UnitGuid, out var ResetType))
		{
			return false;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, UnitGuid);
		if (!GlobalActorData.GetActorAliveState(text ?? UnitGuid))
		{
			DestroyOneActorByUnitDead(UnitGuid, actorByGuid);
			return ResetType == EBGUResetType.Destroy;
		}
		switch (ResetReason)
		{
		case EResetActorReason.NewSpawn:
			return ResetType == EBGUResetType.Destroy;
		case EResetActorReason.LevelStreaming:
			if (IsActorValid(actorByGuid))
			{
				ResetActorTransform(actorByGuid, gSBasicInitDataModule.ActorTrans);
				return ResetType == EBGUResetType.Destroy;
			}
			break;
		}
		if (actorByGuid.IsNullOrDestroyed())
		{
			EvtCollection.Evt_SetStateMachineNeedReset(UnitGuid, P2: true);
		}
		UWorld worldForCS = BGWGameInstanceCS.Get(base.Owner).GetWorldForCS();
		UWorld uWorld = BGU_UnrealWorldUtil.FindWorldByPackageName(gSBasicInitDataModule.WorldPackageName, null);
		if (worldForCS != uWorld)
		{
			ULevelStreaming streamingLevel = worldForCS.GetStreamingLevel(new FName(gSBasicInitDataModule.WorldPackageName));
			if (streamingLevel == null || !streamingLevel.IsLevelLoaded() || !streamingLevel.ShouldBeLoaded_18D4FF06())
			{
				return ResetType == EBGUResetType.Destroy;
			}
		}
		if (ResetReason == EResetActorReason.ReturnHome)
		{
			ResetType = EBGUResetType.Status;
		}
		switch (ResetType)
		{
		case EBGUResetType.Destroy:
			DestroyOneActorByUnitDead(UnitGuid, actorByGuid);
			break;
		case EBGUResetType.Status:
		case EBGUResetType.StatusWithoutHp:
			if (IsActorValid(aActor ?? actorByGuid))
			{
				ResetActorStatus(UnitGuid, actorByGuid, ResetReason);
			}
			break;
		case EBGUResetType.Spawn:
			if (actorByGuid is BGUActorBaseCS bGUActorBaseCS)
			{
				bGUActorBaseCS.DestroyActor();
				ResetActorSpawn(UnitGuid);
			}
			else if (IsActorValid(aActor ?? actorByGuid))
			{
				ResetActorStatus(UnitGuid, actorByGuid, ResetReason);
			}
			else
			{
				ResetActorSpawn(UnitGuid);
			}
			break;
		}
		return ResetType == EBGUResetType.Destroy;
	}

	private void ResetActorSpawn(string UnitGuid)
	{
		UWorld uWorld = DestroyOneActor(UnitGuid);
		if (uWorld.IsNullOrDestroyed() || !(GlobalActorData.GetActorInitData(UnitGuid, EInitDataModuleType.Basic) is b1.GSBasicInitDataModule gSBasicInitDataModule) || !(GlobalActorData.GetActorInitData(UnitGuid, EInitDataModuleType.Guid) is b1.GSGuidInitDataModule gSGuidInitDataModule))
		{
			return;
		}
		UClass uClass = BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UClass>(gSBasicInitDataModule.ActorClsPath.Path, ELoadResourceType.SyncLoadAndCache);
		if (uClass == null || gSGuidInitDataModule.GuidData == null)
		{
			return;
		}
		AActor aActor = BGU_UnrealActorUtil.BGUBeginDeferredActorSpawnFromClass(uWorld, uClass, gSBasicInitDataModule.ActorTrans, ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn, null);
		if (!aActor.IsNullOrDestroyed())
		{
			aActor.SetActorScale3D(gSBasicInitDataModule.ActorTrans.GetScale3D());
			BUS_GuidComp componentByClass = aActor.GetComponentByClass<BUS_GuidComp>();
			if (!componentByClass.IsNullOrDestroyed())
			{
				componentByClass.UnitRandomGuid = gSGuidInitDataModule.GuidData.UnitRandomGuid;
			}
			BUS_ConfigInfoComp componentByClass2 = aActor.GetComponentByClass<BUS_ConfigInfoComp>();
			if (!componentByClass2.IsNullOrDestroyed())
			{
				componentByClass2.UnitFixedGuid = new FUnitGuidData
				{
					GameplayTagGuid = gSGuidInitDataModule.GuidData.UnitFixedGuid,
					GameplayTagGuidForGroup = gSGuidInitDataModule.GuidData.UnitFixedGuidForGroup
				};
			}
			BGU_UnrealActorUtil.BGUFinishSpawningActorAndECSBeginPlay(aActor, aActor, gSBasicInitDataModule.ActorTrans);
		}
	}

	private void ResetActorStatus(string UnitGuid, AActor Actor, EResetActorReason ResetReason)
	{
		if (GlobalActorData.GetActorInitData(UnitGuid, EInitDataModuleType.Basic) is b1.GSBasicInitDataModule gSBasicInitDataModule && CheckActorAndGuid(UnitGuid, Actor))
		{
			BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Actor);
			if ((readOnlyData == null || !readOnlyData.HasState(EBGUUnitState.Dead)) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(Actor, EBGUSimpleState.PendingDeathInAnimationSyncing))
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Actor);
				ResetActorTransform(Actor, gSBasicInitDataModule.ActorTrans);
				bUS_GSEventCollection?.Evt_ResetActorStatusPre.Invoke(ResetReason);
				bUS_GSEventCollection?.Evt_ResetActorStatus.Invoke(ResetReason);
				bUS_GSEventCollection?.Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.SceneObjCommonEventTag.Reset);
				bUS_GSEventCollection?.Evt_ResetActorStatusAfterAll.Invoke(ResetReason);
			}
		}
	}

	private void ResetActorTransform(AActor Actor, in FTransform OriTrans)
	{
		BUS_EventCollectionCS.Get(Actor)?.Evt_ClearActorTransformCache.Invoke();
		UBGUFunctionLibraryForCS.BGUTeleportTo(Actor, OriTrans.GetLocation(), OriTrans.GetRotation().Rotator(), bIsATest: false, bNoCheck: true);
		BGUFuncLibActorTransformCS.BGUSetActorTransform(Actor, OriTrans, bSweep: false, bTeleport: false);
		ACharacter aCharacter = Actor as ACharacter;
		if (aCharacter != null)
		{
			AController controller = aCharacter.GetController();
			if (controller != null)
			{
				controller.SetControlRotation(OriTrans.GetRotation().Quat_Rotator());
			}
		}
	}

	private UWorld DestroyOneActor(string UnitGuid)
	{
		if (!(GlobalActorData.GetActorInitData(UnitGuid, EInitDataModuleType.Basic) is b1.GSBasicInitDataModule gSBasicInitDataModule))
		{
			return null;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, UnitGuid);
		if (CheckActorAndGuid(UnitGuid, actorByGuid))
		{
			int num = BGUFunctionLibraryCS.BGUGetWeaponNum(actorByGuid);
			for (int i = 0; i < num; i++)
			{
				AActor aActor = BGUFunctionLibraryCS.BGUGetWeaponByIndex(actorByGuid, i);
				if (aActor != null)
				{
					BGU_UnrealWorldUtil.DestroyActor(aActor);
				}
			}
			actorByGuid.DestroyActor();
			BGS_EventCollectionCS.Get(actorByGuid).Evt_BGS_ResetActorDestroy.Invoke(UnitGuid);
		}
		return BGU_UnrealWorldUtil.FindWorldByPackageName(gSBasicInitDataModule.WorldPackageName, null);
	}

	private void DestroyOneActorByUnitDead(string UnitGuid, AActor Actor)
	{
		if (GlobalActorData.GetActorInitData(UnitGuid, EInitDataModuleType.Basic) is b1.GSBasicInitDataModule && CheckActorAndGuid(UnitGuid, Actor))
		{
			BUS_EventCollectionCS.Get(Actor).Evt_UnitDead.Invoke(null, EDeadReason.OnlyDestroyUnit);
			BGS_EventCollectionCS.Get(Actor).Evt_BGS_ResetActorDestroy.Invoke(UnitGuid);
		}
	}

	private bool CheckActorAndGuid(string UnitGuid, AActor Actor)
	{
		if (Actor.IsNullOrDestroyed())
		{
			return false;
		}
		IBUC_GuidData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_GuidData, BUC_GuidData>(Actor);
		if (readOnlyData == null)
		{
			return false;
		}
		return UnitGuid == readOnlyData.GetFinalGuid();
	}

	private bool IsActorValid(AActor Actor)
	{
		if (Actor != null)
		{
			BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Actor);
			if (readOnlyData == null || !readOnlyData.HasState(EBGUUnitState.Dead))
			{
				return !BGUFunctionLibraryCS.BGUHasUnitSimpleState(Actor, EBGUSimpleState.PendingDeathInAnimationSyncing);
			}
			return false;
		}
		return false;
	}
}
