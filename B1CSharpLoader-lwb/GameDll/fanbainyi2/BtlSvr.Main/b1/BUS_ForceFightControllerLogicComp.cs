using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

internal class BUS_ForceFightControllerLogicComp : UActorCompBaseCS
{
	private b1.BUC_ForceFightControllerLogicData ForceFightControllerLogicData;

	private BGS_GSEventCollection BGSEvent;

	public override void OnAttach()
	{
		base.OnAttach();
		ForceFightControllerLogicData = RequireWritableData<b1.BUC_ForceFightControllerLogicData>();
		BGSEvent = BGS_GSEventCollection.Get(this);
		BGSEvent.Evt_NotifyTamerSpawnUnit += new Del_Void_String(OnTamerSpawnUnit);
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorLeave);
		base.BUSEventCollection.Evt_EnableAreaOverlap += new Del_Void(OnEnableOverlap);
		base.BUSEventCollection.Evt_DisableAreaOverlap += new Del_Void(OnDisableOverlap);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGSEvent.Evt_NotifyTamerSpawnUnit -= new Del_Void_String(OnTamerSpawnUnit);
		base.OnEndPlay(EndPlayReason);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		foreach (FForceFightUnitGroupConfig item in ForceFightControllerLogicData.ForceFightControlConfig)
		{
			if (item.TriggerCondition != EGSForceFightCondition.ObserveUnitsConditions)
			{
				continue;
			}
			for (int num = item.ObserveUnitsConditions.Count - 1; num >= 0; num--)
			{
				if (item.ObserveUnitsConditions[num].ObservedUnits == null || item.ObserveUnitsConditions[num].ObservedUnits.Count == 0)
				{
					item.ObserveUnitsConditions.RemoveAt(num);
				}
				else
				{
					foreach (string observedUnit in item.ObserveUnitsConditions[num].ObservedUnits)
					{
						AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, observedUnit);
						if (!(actorByGuid == null) && !actorByGuid.IsPendingKill)
						{
							BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
							if (bUS_GSEventCollection != null)
							{
								bUS_GSEventCollection.Evt_UnitStateUpdated += new Del_UnitStateUpdated(OnObservedUnitTriggerUnitState);
								bUS_GSEventCollection.Evt_BuffUpdated += new Del_BuffUpdated(OnObservedUnitAddBuff);
								bUS_GSEventCollection.Evt_UnitSimpleStateUpdated += new Del_UnitSimpleStateUpdated(OnObservedUnitSetSimpleState);
							}
						}
					}
				}
			}
		}
	}

	public void ObserveUnitsConditionsDoLogic()
	{
		for (int num = ForceFightControllerLogicData.ForceFightControlConfig.Count - 1; num >= 0; num--)
		{
			FForceFightUnitGroupConfig fForceFightUnitGroupConfig = ForceFightControllerLogicData.ForceFightControlConfig[num];
			if (fForceFightUnitGroupConfig.TriggerCondition == EGSForceFightCondition.ObserveUnitsConditions && fForceFightUnitGroupConfig.IsValidUnitStateCondition(Owner))
			{
				if (!fForceFightUnitGroupConfig.CanRepeat)
				{
					ForceFightControllerLogicData.ForceFightControlConfig.RemoveAt(num);
				}
				TriggerForceFightUnitGroup(fForceFightUnitGroupConfig, fForceFightUnitGroupConfig.GetAllObserveUnits(Owner));
			}
		}
	}

	private void OnObservedUnitAddBuff(int BuffID)
	{
		ObserveUnitsConditionsDoLogic();
	}

	private void OnObservedUnitSetSimpleState(EBGUSimpleState SimpleStateID, bool IsRemove = false)
	{
		if (!IsRemove)
		{
			ObserveUnitsConditionsDoLogic();
		}
	}

	private void OnObservedUnitTriggerUnitState(EBUStateTrigger TriggerID)
	{
		ObserveUnitsConditionsDoLogic();
	}

	private void OnEnableOverlap()
	{
		ForceFightControllerLogicData.UnitsEnteredArea.Clear();
	}

	private void OnDisableOverlap()
	{
		ForceFightControllerLogicData.UnitsEnteredArea.Clear();
	}

	private void OnActorEnter(AActor OtherActor)
	{
		if (OtherActor == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		bool flag = true;
		foreach (FForceFightUnitGroupConfig item in ForceFightControllerLogicData.ForceFightControlConfig)
		{
			if (!flag)
			{
				break;
			}
			foreach (string item2 in item.TriggerUnitsGuid)
			{
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, item2);
				if (!(actorByGuid == null) && actorByGuid == bGUCharacterCS)
				{
					flag = false;
					break;
				}
			}
		}
		if (flag)
		{
			ForceFightControllerLogicData.UnitsEnteredArea.Add(bGUCharacterCS);
		}
		TriggerForceFightUnitGroupByCondition(EGSForceFightCondition.EnterCollisionArea, new List<BGUCharacterCS> { bGUCharacterCS });
	}

	private void OnActorLeave(AActor OtherActor)
	{
		BGUCharacterCS bGUCharacterCS = OtherActor as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			ForceFightControllerLogicData.UnitsEnteredArea.Remove(bGUCharacterCS);
			TriggerForceFightUnitGroupByCondition(EGSForceFightCondition.LeaveCollisionArea, new List<BGUCharacterCS> { bGUCharacterCS });
		}
	}

	private void TriggerForceFightUnitGroupByCondition(EGSForceFightCondition CurrentCondition, List<BGUCharacterCS> TriggerConditionUnits)
	{
		for (int num = ForceFightControllerLogicData.UnitsEnteredArea.Count - 1; num >= 0; num--)
		{
			if (ForceFightControllerLogicData.UnitsEnteredArea[num] == null)
			{
				ForceFightControllerLogicData.UnitsEnteredArea.RemoveAt(num);
			}
		}
		for (int num2 = ForceFightControllerLogicData.ForceFightControlConfig.Count - 1; num2 >= 0; num2--)
		{
			FForceFightUnitGroupConfig fForceFightUnitGroupConfig = ForceFightControllerLogicData.ForceFightControlConfig[num2];
			if (fForceFightUnitGroupConfig.TriggerCondition == CurrentCondition)
			{
				bool flag = true;
				foreach (BGUCharacterCS TriggerConditionUnit in TriggerConditionUnits)
				{
					if (!fForceFightUnitGroupConfig.CanUnitTriggerForceFight(TriggerConditionUnit))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					if (!fForceFightUnitGroupConfig.CanRepeat)
					{
						ForceFightControllerLogicData.ForceFightControlConfig.RemoveAt(num2);
					}
					TriggerForceFightUnitGroup(fForceFightUnitGroupConfig, TriggerConditionUnits);
				}
			}
		}
	}

	private void TriggerForceFightUnitGroup(FForceFightUnitGroupConfig Config, List<BGUCharacterCS> TriggerConditionUnits)
	{
		BGUCharacterCS bGUCharacterCS = null;
		EGSForceFightTargetType forceFightTargetType = Config.ForceFightTargetType;
		bGUCharacterCS = ((forceFightTargetType <= EGSForceFightTargetType.CollisionOverlappedUnit || forceFightTargetType != EGSForceFightTargetType.SelectedTargetUnit) ? null : (BGU_DataUtil.GetActorByGuid(Owner, Config.TargetUnitGuid) as BGUCharacterCS));
		HashSet<BGUCharacterCS> hashSet = new HashSet<BGUCharacterCS>();
		using (List<EGSForceFightTriggerUnitType>.Enumerator enumerator = Config.TriggerUnitsType.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				switch (enumerator.Current)
				{
				case EGSForceFightTriggerUnitType.TriggerConditionUnit:
					foreach (BGUCharacterCS TriggerConditionUnit in TriggerConditionUnits)
					{
						hashSet.Add(TriggerConditionUnit);
					}
					break;
				case EGSForceFightTriggerUnitType.TriggerConditionUnitEnemy:
					foreach (BGUCharacterCS allActorsOfClass in Owner.World.GetAllActorsOfClassList<BGUCharacterCS>())
					{
						BGUCharacterCS item = BGUFunctionLibraryCS.BGUGetTarget(allActorsOfClass) as BGUCharacterCS;
						if (TriggerConditionUnits.Contains(item))
						{
							hashSet.Add(allActorsOfClass);
						}
					}
					break;
				}
			}
		}
		foreach (string item2 in Config.TriggerUnitsGuid)
		{
			BGUCharacterCS bGUCharacterCS2 = BGU_DataUtil.GetActorByGuid(Owner, item2) as BGUCharacterCS;
			if (bGUCharacterCS2 == null)
			{
				base.BGSEventCollection?.Evt_MarkTamerAlwaysSpawn.Invoke(item2);
				if (!ForceFightControllerLogicData.PendingSpawnUnitRequests.ContainsKey(item2))
				{
					ForceFightControllerLogicData.PendingSpawnUnitRequests.Add(item2, Config);
				}
				else
				{
					ForceFightControllerLogicData.PendingSpawnUnitRequests[item2] = Config;
				}
			}
			else if (!BGUFunctionLibraryCS.BGUHasUnitState(bGUCharacterCS2, EBGUUnitState.Dead) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS2, EBGUSimpleState.PendingDeathInAnimationSyncing))
			{
				hashSet.Add(bGUCharacterCS2);
			}
		}
		List<BGUCharacterCS> list = new List<BGUCharacterCS>();
		foreach (string item3 in Config.IgnoreUnitsGuid)
		{
			BGUCharacterCS bGUCharacterCS3 = BGU_DataUtil.GetActorByGuid(Owner, item3) as BGUCharacterCS;
			if (bGUCharacterCS3 != null)
			{
				list.Add(bGUCharacterCS3);
			}
		}
		foreach (BGUCharacterCS item4 in hashSet)
		{
			TriggerUnit(item4, Config, list, bGUCharacterCS);
		}
	}

	private void TriggerUnit(BGUCharacterCS Unit, FForceFightUnitGroupConfig Config, List<BGUCharacterCS> IgnoreUnits, AActor Target)
	{
		if ((Config.IgnorePlayer && Unit is BGUPlayerCharacterCS) || IgnoreUnits.Contains(Unit))
		{
			return;
		}
		IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Unit);
		if (readOnlyData != null && IgnoreUnits.Contains(readOnlyData.GetMasterActor() as BGUCharacterCS))
		{
			return;
		}
		if (Config.ForceFightTargetType == EGSForceFightTargetType.CollisionOverlappedUnit)
		{
			foreach (BGUCharacterCS item in ForceFightControllerLogicData.UnitsEnteredArea)
			{
				if (BGUFunctionLibraryCS.BGUIsEnemyTeam(Unit, item))
				{
					Target = item;
					break;
				}
			}
			if (Target == null)
			{
				return;
			}
		}
		if (Unit == Target || BGUFunctionLibraryCS.BGUGetTarget(Unit) == Target || BGUFunctionLibraryCS.BGUHasUnitState(Target, EBGUUnitState.Dead) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(Target, EBGUSimpleState.PendingDeathInAnimationSyncing) || (Unit is BGUPlayerCharacterCS && Target != null))
		{
			return;
		}
		if (Target == null)
		{
			switch (Config.ForceFightTargetType)
			{
			case EGSForceFightTargetType.None:
				if (BGU_CommonUtil.IsInFsmState(Unit, EBGUFSMStateName.FSM_STATE_BATTLE))
				{
					BUS_EventCollectionCS.Get(Unit).Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_GOHOME);
				}
				break;
			case EGSForceFightTargetType.KeepCurrentAndStalemate:
				BUS_EventCollectionCS.Get(Unit).Evt_SetPursuitRange.Invoke(EPursuitRangeReqType.ForceFight, 0.01f);
				break;
			}
		}
		else
		{
			BUS_EventCollectionCS.Get(Unit).Evt_AICatchTarget.Invoke(Target, ETargetSourceType.Target_ForceFightAssignTarget);
		}
	}

	private void LogPlayerCatchTargetError(FForceFightUnitGroupConfig Config)
	{
		if (Config.TriggerUnitsType.Count <= 0)
		{
			return;
		}
		string text = "";
		foreach (EGSForceFightTriggerUnitType item in Config.TriggerUnitsType)
		{
			text += $" {item}";
		}
	}

	private void OnTamerSpawnUnit(string TamerGuid)
	{
		if (!ForceFightControllerLogicData.PendingSpawnUnitRequests.ContainsKey(TamerGuid))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(Owner, TamerGuid) as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		FForceFightUnitGroupConfig fForceFightUnitGroupConfig = ForceFightControllerLogicData.PendingSpawnUnitRequests[TamerGuid];
		base.BGSEventCollection?.Evt_UnMarkTamerAlwaysSpawn.Invoke(TamerGuid);
		ForceFightControllerLogicData.PendingSpawnUnitRequests.Remove(TamerGuid);
		BGUCharacterCS bGUCharacterCS2 = null;
		EGSForceFightTargetType forceFightTargetType = fForceFightUnitGroupConfig.ForceFightTargetType;
		bGUCharacterCS2 = ((forceFightTargetType <= EGSForceFightTargetType.CollisionOverlappedUnit || forceFightTargetType != EGSForceFightTargetType.SelectedTargetUnit) ? null : (BGU_DataUtil.GetActorByGuid(Owner, fForceFightUnitGroupConfig.TargetUnitGuid) as BGUCharacterCS));
		List<BGUCharacterCS> list = new List<BGUCharacterCS>();
		foreach (string item in fForceFightUnitGroupConfig.IgnoreUnitsGuid)
		{
			BGUCharacterCS bGUCharacterCS3 = BGU_DataUtil.GetActorByGuid(Owner, item) as BGUCharacterCS;
			if (bGUCharacterCS3 != null)
			{
				list.Add(bGUCharacterCS3);
			}
		}
		TriggerUnit(bGUCharacterCS, fForceFightUnitGroupConfig, list, bGUCharacterCS2);
	}
}
