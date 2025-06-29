using System.Collections.Generic;
using b1.ECS;
using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_TriggerUnitBattle : FIdleProcessExecutorBase
{
	private class TriggerBattleTask
	{
		private class UnitBattleInfo
		{
			public string UnitGuid;

			public int SwitchTeamID;

			public string TargetGuid;

			public UnitBattleInfo(string _UnitGuid, int _SwitchTeamID, string _TargetGuid)
			{
				UnitGuid = _UnitGuid;
				SwitchTeamID = _SwitchTeamID;
				TargetGuid = _TargetGuid;
			}
		}

		private List<UnitBattleInfo> UnitBattleInfos = new List<UnitBattleInfo>();

		public TriggerBattleTask()
		{
			UnitBattleInfos = new List<UnitBattleInfo>();
		}

		public void AddUnitBattleInfo(string _UnitGuid, int _SwitchTeamID, string _TargetGuid)
		{
			UnitBattleInfos.Add(new UnitBattleInfo(_UnitGuid, _SwitchTeamID, _TargetGuid));
		}

		public bool TryTriggerBattle(UObject WorldContext)
		{
			IBGC_TamerData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(WorldContext);
			if (gameStateReadonlyData == null)
			{
				return false;
			}
			foreach (UnitBattleInfo unitBattleInfo in UnitBattleInfos)
			{
				BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(WorldContext, unitBattleInfo.UnitGuid) as BGUCharacterCS;
				BGUCharacterCS bGUCharacterCS2 = BGU_DataUtil.GetActorByGuid(WorldContext, unitBattleInfo.TargetGuid) as BGUCharacterCS;
				if (bGUCharacterCS == null || bGUCharacterCS2 == null || (!BGU_DataUtil.GetIsPlayer(bGUCharacterCS) && !gameStateReadonlyData.IsUnitSpawnFinished(unitBattleInfo.UnitGuid)) || (!BGU_DataUtil.GetIsPlayer(bGUCharacterCS2) && !gameStateReadonlyData.IsUnitSpawnFinished(unitBattleInfo.TargetGuid)))
				{
					return false;
				}
			}
			foreach (UnitBattleInfo unitBattleInfo2 in UnitBattleInfos)
			{
				BGUCharacterCS bGUCharacterCS3 = BGU_DataUtil.GetActorByGuid(WorldContext, unitBattleInfo2.UnitGuid) as BGUCharacterCS;
				if (!(bGUCharacterCS3 == null) && unitBattleInfo2.SwitchTeamID > 0)
				{
					bGUCharacterCS3.SetTeamIDInCS(unitBattleInfo2.SwitchTeamID);
				}
			}
			foreach (UnitBattleInfo unitBattleInfo3 in UnitBattleInfos)
			{
				BGUCharacterCS bGUCharacterCS4 = BGU_DataUtil.GetActorByGuid(WorldContext, unitBattleInfo3.UnitGuid) as BGUCharacterCS;
				BGUCharacterCS bGUCharacterCS5 = BGU_DataUtil.GetActorByGuid(WorldContext, unitBattleInfo3.TargetGuid) as BGUCharacterCS;
				if (bGUCharacterCS4 == null || bGUCharacterCS5 == null)
				{
					continue;
				}
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS4);
				if (!(bUS_GSEventCollection == null))
				{
					UnitLockTargetInfo unitLockTargetInfo = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(bGUCharacterCS4)?.GetTargetInfo();
					if (unitLockTargetInfo != null && unitLockTargetInfo.LockTargetEntity == Entity.Null)
					{
						bUS_GSEventCollection.Evt_AICatchTarget.Invoke(bGUCharacterCS5, ETargetSourceType.AO_AORangeFind);
					}
				}
			}
			return true;
		}
	}

	public class ProcessTriggerUnitBattleConfigForPsm
	{
		public string UnitGuid;

		public int SwitchTeamID;

		public string TargetGuid;

		public ProcessTriggerUnitBattleConfigForPsm(PsmInstance InPsmInstance, CalliopeCustom_TriggerUnitBattleConfig TriggerUnitBattleConfig)
		{
			if (InPsmInstance != null)
			{
				UnitGuid = InPsmInstance.ConvertParamID2UnitGuid(TriggerUnitBattleConfig.UnitGuid);
				SwitchTeamID = TriggerUnitBattleConfig.SwitchTeamId;
				TargetGuid = InPsmInstance.ConvertParamID2UnitGuid(TriggerUnitBattleConfig.TargetGuid);
			}
		}
	}

	public override EIdleProcessActionType ActionType => EIdleProcessActionType.TriggerUnitBattle;

	private List<ProcessTriggerUnitBattleConfigForPsm> TriggerUnitBattleConfigs { get; set; }

	private List<TriggerBattleTask> TriggerUnitBattleTasks { get; } = new List<TriggerBattleTask>();

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		TriggerUnitBattleConfigs = new List<ProcessTriggerUnitBattleConfigForPsm>();
		foreach (CalliopeCustom_TriggerUnitBattleConfig triggerUnitBattleConfig in InIdleProcessAction.TriggerUnitBattleConfigs)
		{
			TriggerUnitBattleConfigs.Add(new ProcessTriggerUnitBattleConfigForPsm(InPsmNodeInstance.ParentInstance, triggerUnitBattleConfig));
		}
	}

	public override void Run(UObject InWorldContext)
	{
		TriggerUnitBattleTasks.Clear();
		TriggerBattleTask triggerBattleTask = new TriggerBattleTask();
		foreach (ProcessTriggerUnitBattleConfigForPsm triggerUnitBattleConfig in TriggerUnitBattleConfigs)
		{
			triggerBattleTask.AddUnitBattleInfo(triggerUnitBattleConfig.UnitGuid, triggerUnitBattleConfig.SwitchTeamID, triggerUnitBattleConfig.TargetGuid);
		}
		TriggerUnitBattleTasks.Add(triggerBattleTask);
	}

	public override void OnTick(UObject InWorldContext, float InDeltaTime)
	{
		for (int num = TriggerUnitBattleTasks.Count - 1; num >= 0; num--)
		{
			if (TriggerUnitBattleTasks[num].TryTriggerBattle(InWorldContext))
			{
				TriggerUnitBattleTasks.RemoveAt(num);
			}
		}
	}

	public override bool IsFinished()
	{
		return TriggerUnitBattleTasks.Count == 0;
	}
}
