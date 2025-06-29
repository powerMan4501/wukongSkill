using System;
using System.Collections.Generic;
using System.Text;
using b1.BGW;
using BtlB1;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_AssociationUnitSysten : GameStateSystemBase
{
	private BGC_AssociationUnitData AssociationUnitData;

	private IBIC_BossRushData BossRushData;

	private static readonly float TICK_DURATION = 1f;

	private float TickTimer;

	public override void OnAttach()
	{
		AssociationUnitData = RequireWritableData<BGC_AssociationUnitData>();
		BossRushData = RequireReadonlyGameInstanceData<IBIC_BossRushData, BIC_BossRushData>();
		if (base.BGWEventCollection != null)
		{
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_BGW_BlockingSpawnAssociationUnit = (BGW_EventCollection.Del_BGW_BlockingSpawnAssociationUnit)Delegate.Combine(bGWEventCollection.Evt_BGW_BlockingSpawnAssociationUnit, new BGW_EventCollection.Del_BGW_BlockingSpawnAssociationUnit(OnBlockingSpawnAssociationUnit));
			BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
			bGWEventCollection2.Evt_BGW_SpawnAssociationUnit = (BGW_EventCollection.Del_BGW_SpawnAssociationUnit)Delegate.Combine(bGWEventCollection2.Evt_BGW_SpawnAssociationUnit, new BGW_EventCollection.Del_BGW_SpawnAssociationUnit(OnSpawnAssociationUnit));
			BGW_EventCollection bGWEventCollection3 = base.BGWEventCollection;
			bGWEventCollection3.Evt_BGW_ActiveAssociationUnit = (BGW_EventCollection.Del_BGW_ActiveAssociationUnit)Delegate.Combine(bGWEventCollection3.Evt_BGW_ActiveAssociationUnit, new BGW_EventCollection.Del_BGW_ActiveAssociationUnit(OnActiveAssociationUnit));
			BGW_EventCollection bGWEventCollection4 = base.BGWEventCollection;
			bGWEventCollection4.Evt_BGW_KillAssociationUnit = (BGW_EventCollection.Del_BGW_KillAssociationUnit)Delegate.Combine(bGWEventCollection4.Evt_BGW_KillAssociationUnit, new BGW_EventCollection.Del_BGW_KillAssociationUnit(OnKillAssociationUnit));
			BGW_EventCollection bGWEventCollection5 = base.BGWEventCollection;
			bGWEventCollection5.Evt_BGW_NotifyMarkAssociationUnitActive = (BGW_EventCollection.Del_BGW_Int)Delegate.Combine(bGWEventCollection5.Evt_BGW_NotifyMarkAssociationUnitActive, new BGW_EventCollection.Del_BGW_Int(OnMarkAssociationUnitActive));
			BGW_EventCollection bGWEventCollection6 = base.BGWEventCollection;
			bGWEventCollection6.Evt_BGW_PrintCurrentAssociationUnitInfo = (BGW_EventCollection.Del_BGW_Void)Delegate.Combine(bGWEventCollection6.Evt_BGW_PrintCurrentAssociationUnitInfo, new BGW_EventCollection.Del_BGW_Void(OnPrintCurrentAssociationUnitInfo));
		}
		TickTimer = 0f;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		if (base.BGWEventCollection != null)
		{
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_BGW_BlockingSpawnAssociationUnit = (BGW_EventCollection.Del_BGW_BlockingSpawnAssociationUnit)Delegate.Remove(bGWEventCollection.Evt_BGW_BlockingSpawnAssociationUnit, new BGW_EventCollection.Del_BGW_BlockingSpawnAssociationUnit(OnBlockingSpawnAssociationUnit));
			BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
			bGWEventCollection2.Evt_BGW_SpawnAssociationUnit = (BGW_EventCollection.Del_BGW_SpawnAssociationUnit)Delegate.Remove(bGWEventCollection2.Evt_BGW_SpawnAssociationUnit, new BGW_EventCollection.Del_BGW_SpawnAssociationUnit(OnSpawnAssociationUnit));
			BGW_EventCollection bGWEventCollection3 = base.BGWEventCollection;
			bGWEventCollection3.Evt_BGW_ActiveAssociationUnit = (BGW_EventCollection.Del_BGW_ActiveAssociationUnit)Delegate.Remove(bGWEventCollection3.Evt_BGW_ActiveAssociationUnit, new BGW_EventCollection.Del_BGW_ActiveAssociationUnit(OnActiveAssociationUnit));
			BGW_EventCollection bGWEventCollection4 = base.BGWEventCollection;
			bGWEventCollection4.Evt_BGW_KillAssociationUnit = (BGW_EventCollection.Del_BGW_KillAssociationUnit)Delegate.Remove(bGWEventCollection4.Evt_BGW_KillAssociationUnit, new BGW_EventCollection.Del_BGW_KillAssociationUnit(OnKillAssociationUnit));
			BGW_EventCollection bGWEventCollection5 = base.BGWEventCollection;
			bGWEventCollection5.Evt_BGW_NotifyMarkAssociationUnitActive = (BGW_EventCollection.Del_BGW_Int)Delegate.Remove(bGWEventCollection5.Evt_BGW_NotifyMarkAssociationUnitActive, new BGW_EventCollection.Del_BGW_Int(OnMarkAssociationUnitActive));
			BGW_EventCollection bGWEventCollection6 = base.BGWEventCollection;
			bGWEventCollection6.Evt_BGW_PrintCurrentAssociationUnitInfo = (BGW_EventCollection.Del_BGW_Void)Delegate.Remove(bGWEventCollection6.Evt_BGW_PrintCurrentAssociationUnitInfo, new BGW_EventCollection.Del_BGW_Void(OnPrintCurrentAssociationUnitInfo));
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateForSpawnAndActive(DeltaTime);
	}

	private void UpdateForSpawnAndActive(float DeltaTime, int AssignConfigID = -1)
	{
		TickTimer -= DeltaTime;
		if (TickTimer > 0f)
		{
			return;
		}
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(Owner);
		if (!UGSE_EngineFuncLib.IsStandAlone(worldFromObj))
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, AssoicationUnitInfo> item in AssociationUnitData.AssociationUnitInfoDic)
		{
			int key = item.Key;
			AssoicationUnitInfo value = item.Value;
			if (AssignConfigID != -1 && key != AssignConfigID)
			{
				continue;
			}
			if (!value.bIsSpawn)
			{
				value.SpawnDelayTime -= TICK_DURATION - TickTimer;
				if (value.SpawnDelayTime <= 0f)
				{
					FUStAssociationUnitInfoSDesc associationUnitInfoSDesc = BGW_GameDB.GetAssociationUnitInfoSDesc(key);
					if (associationUnitInfoSDesc != null)
					{
						TSubclassOf<BUTamerActor> tSubclassOf = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UClass>(associationUnitInfoSDesc.UnitResBPPath, ELoadResourceType.SyncLoadAndCache);
						if (tSubclassOf != null)
						{
							FindSpawnTransform(value.SpawnType, associationUnitInfoSDesc.SpawnSceneItemTagName, associationUnitInfoSDesc.SpawnEQSPath, out var Location, out var Rotation);
							value.AssociationUnitEntityGUID = BGU_UnrealWorldUtil.RequestSpawnUnit(worldFromObj, tSubclassOf.Value, new FTransform(Rotation.Quaternion(), Location, FVector.OneVector), null);
							if (!string.IsNullOrEmpty(value.AssociationUnitEntityGUID))
							{
								value.bIsSpawn = true;
							}
						}
					}
				}
			}
			else
			{
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(worldFromObj, value.AssociationUnitEntityGUID);
				if (actorByGuid == null || BGUFunctionLibraryCS.BGUHasUnitState(actorByGuid, EBGUUnitState.Dead))
				{
					list.Add(key);
				}
			}
			if (value.bIsSpawn && !value.bIsActive && value.bCanActive)
			{
				value.bIsActive = true;
			}
		}
		foreach (int item2 in list)
		{
			if (AssociationUnitData.AssociationUnitInfoDic.TryGetValue(item2, out var _))
			{
				AssociationUnitData.AssociationUnitInfoDic.Remove(item2);
			}
		}
		TickTimer = TICK_DURATION;
	}

	private void OnBlockingSpawnAssociationUnit(int ConfigID, EAssociationUnitSpawnType SpawnType)
	{
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(Owner);
		if (!UGSE_EngineFuncLib.IsStandAlone(worldFromObj) || (B1Global.GIsBossRushMode && BossRushData.bAllowAssociationUnit.HasValue && !BossRushData.bAllowAssociationUnit.Value))
		{
			return;
		}
		if (!AssociationUnitData.AssociationUnitInfoDic.TryGetValue(ConfigID, out var value))
		{
			FUStAssociationUnitInfoSDesc associationUnitInfoSDesc = BGW_GameDB.GetAssociationUnitInfoSDesc(ConfigID);
			if (associationUnitInfoSDesc != null)
			{
				value = new AssoicationUnitInfo(_bCanActive: false, SpawnType, "", 0f, 0);
				AssociationUnitData.AssociationUnitInfoDic.Add(ConfigID, value);
				if (!value.bIsSpawn)
				{
					TSubclassOf<BUTamerActor> tSubclassOf = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UClass>(associationUnitInfoSDesc.UnitResBPPath, ELoadResourceType.SyncLoadAndCache);
					if (tSubclassOf != null)
					{
						FindSpawnTransform(value.SpawnType, associationUnitInfoSDesc.SpawnSceneItemTagName, associationUnitInfoSDesc.SpawnEQSPath, out var Location, out var Rotation);
						value.AssociationUnitEntityGUID = BGU_UnrealWorldUtil.RequestSpawnUnit(worldFromObj, tSubclassOf.Value, new FTransform(Rotation.Quaternion(), Location, FVector.OneVector), null);
						if (!string.IsNullOrEmpty(value.AssociationUnitEntityGUID))
						{
							value.bIsSpawn = true;
						}
					}
				}
			}
		}
		if (value != null && !string.IsNullOrEmpty(value.AssociationUnitEntityGUID))
		{
			base.BGSEventCollection.Evt_TamerBlockingSpawnImmediately.Invoke(value.AssociationUnitEntityGUID);
		}
	}

	private void FindSpawnTransform(EAssociationUnitSpawnType InSpawnType, string SpawnSceneItemTagName, string SpawnEQSPath, out FVector Location, out FRotator Rotation)
	{
		bool flag = false;
		Location = default(FVector);
		Rotation = default(FRotator);
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner)?.GetControlledPawn();
		if (!(aPawn != null))
		{
			return;
		}
		switch (InSpawnType)
		{
		case EAssociationUnitSpawnType.BySceneItem:
		{
			((IBGC_LevelActorData)BGU_DataUtil.GetGameStateReadonlyData<BGC_LevelActorData>(Owner)).GetSceneItemsByTag(new FName(SpawnSceneItemTagName), out List<AActor> OutSceneItems);
			if (OutSceneItems.Count > 0)
			{
				AActor aActor = OutSceneItems[0];
				if (aActor != null)
				{
					flag = true;
					Location = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
					Rotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(aActor);
				}
			}
			break;
		}
		case EAssociationUnitSpawnType.ByEQS:
		{
			UEnvQuery uEnvQuery = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UEnvQuery>(SpawnEQSPath, ELoadResourceType.SyncLoadAndCache);
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
					Location = ((Locations.Count > num) ? Locations[num] : BGUFuncLibActorTransformCS.BGUGetActorLocation(aPawn));
				}
			}
			Rotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(aPawn);
			break;
		}
		}
		if (!flag)
		{
			Location = BGUFuncLibActorTransformCS.BGUGetActorLocation(aPawn);
			Rotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(aPawn);
		}
	}

	private void OnSpawnAssociationUnit(int ConfigID, int DelayTime, EAssociationUnitSpawnType SpawnType, EAssociationUnitActiveType ActiveType, string TargetGUID, int OnFightSkillID)
	{
		if (UGSE_EngineFuncLib.IsStandAlone(UGSE_EngineFuncLib.GetWorldFromObj(Owner)) && (!B1Global.GIsBossRushMode || !BossRushData.bAllowAssociationUnit.HasValue || BossRushData.bAllowAssociationUnit.Value) && !AssociationUnitData.AssociationUnitInfoDic.TryGetValue(ConfigID, out var _) && BGW_GameDB.GetAssociationUnitInfoSDesc(ConfigID) != null)
		{
			if (ActiveType != EAssociationUnitActiveType.ActiveImmediately)
			{
				TargetGUID = string.Empty;
				OnFightSkillID = 0;
			}
			AssociationUnitData.AssociationUnitInfoDic.Add(ConfigID, new AssoicationUnitInfo(ActiveType == EAssociationUnitActiveType.ActiveImmediately, SpawnType, TargetGUID, DelayTime, OnFightSkillID));
			UpdateForSpawnAndActive(0f, ConfigID);
		}
	}

	private void OnActiveAssociationUnit(int ConfigID, string TargetGUID, int OnFightSkillID)
	{
		if (!UGSE_EngineFuncLib.IsStandAlone(UGSE_EngineFuncLib.GetWorldFromObj(Owner)) || !AssociationUnitData.AssociationUnitInfoDic.TryGetValue(ConfigID, out var value))
		{
			return;
		}
		value.bCanActive = true;
		value.TargetGUID = TargetGUID;
		value.OnFightSkillID = OnFightSkillID;
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, value.AssociationUnitEntityGUID);
		if (actorByGuid != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_NotifyAssociationUnitActive.Invoke(ConfigID, value.TargetGUID, value.OnFightSkillID);
			}
		}
	}

	private void OnKillAssociationUnit(int ConfigID)
	{
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(Owner);
		if (UGSE_EngineFuncLib.IsStandAlone(worldFromObj) && AssociationUnitData.AssociationUnitInfoDic.TryGetValue(ConfigID, out var value))
		{
			BGU_UnrealWorldUtil.RequestDestroyUnit(worldFromObj, value.AssociationUnitEntityGUID);
			AssociationUnitData.AssociationUnitInfoDic.Remove(ConfigID);
		}
	}

	private void OnMarkAssociationUnitActive(int ConfigID)
	{
		if (UGSE_EngineFuncLib.IsStandAlone(UGSE_EngineFuncLib.GetWorldFromObj(Owner)) && AssociationUnitData.AssociationUnitInfoDic.TryGetValue(ConfigID, out var value))
		{
			value.bIsActive = true;
		}
	}

	private void OnPrintCurrentAssociationUnitInfo()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("[PrintCurrentAssociationUnitInfo]");
		stringBuilder.AppendLine("[PrintCurrentAssociationUnitInfo]=================打印当前协同作战单位信息——Begin=================");
		UWorld worldFromObj = UGSE_EngineFuncLib.GetWorldFromObj(Owner);
		stringBuilder.AppendLine($"[PrintCurrentAssociationUnitInfo]当前缓存的协战单位信息个数是：{AssociationUnitData.AssociationUnitInfoDic.Count}");
		foreach (KeyValuePair<int, AssoicationUnitInfo> item in AssociationUnitData.AssociationUnitInfoDic)
		{
			int key = item.Key;
			AssoicationUnitInfo value = item.Value;
			if (value == null)
			{
				continue;
			}
			stringBuilder.AppendLine($"[PrintCurrentAssociationUnitInfo]当前激活的AssociationInfoID : {key}");
			stringBuilder.AppendLine($"[PrintCurrentAssociationUnitInfo]自身GUID是：{value.AssociationUnitEntityGUID}，目标GUID是：{value.TargetGUID}，出生情况：{value.bIsSpawn}，激活情况：{value.bIsActive}");
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(worldFromObj, value.AssociationUnitEntityGUID);
			if (!(actorByGuid != null))
			{
				continue;
			}
			IBUC_BuffData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BuffData, BUC_BuffData>(actorByGuid);
			if (unPersistentReadOnlyData == null)
			{
				continue;
			}
			stringBuilder.AppendLine("[PrintCurrentAssociationUnitInfo]======开始打印协同作战单位身上的Buff信息-Begin======");
			foreach (BuffInstData allBuffInstDatum in unPersistentReadOnlyData.GetAllBuffInstData())
			{
				if (allBuffInstDatum != null)
				{
					stringBuilder.AppendLine($"[PrintCurrentAssociationUnitInfo] BuffID = {allBuffInstDatum.BuffID}，层数 = {allBuffInstDatum.Layer}，剩余时间 = {allBuffInstDatum.LeftTime:F2}秒");
				}
			}
			stringBuilder.AppendLine("[PrintCurrentAssociationUnitInfo]======开始打印协同作战单位身上的Buff信息-End======");
		}
		stringBuilder.AppendLine("[PrintCurrentAssociationUnitInfo]=================打印当前协同作战单位信息——End=================");
	}
}
