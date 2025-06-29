using System.Collections.Generic;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using GurCalliopeState;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class PsmSubMachine_CommonBattle : PsmSubMachine_TemplateBase
{
	private class BattleStartConditionForPsm
	{
		public EBattleStartConditionType StartConditionType { get; }

		public string UnitGuid { get; }

		public string SpawnerGuid { get; }

		public string OverlapGuid { get; }

		public BattleStartConditionForPsm(CalliopeCustom_BattleStartCondition InStartConditionData, PsmInstance InPsmInstance)
		{
			StartConditionType = (EBattleStartConditionType)InStartConditionData.StartConditionType;
			if (InPsmInstance != null)
			{
				UnitGuid = InPsmInstance.ConvertParamID2StringParam(InStartConditionData.UnitGuid);
				SpawnerGuid = InPsmInstance.ConvertParamID2StringParam(InStartConditionData.SpawnerGuid);
				OverlapGuid = InPsmInstance.ConvertParamID2StringParam(InStartConditionData.OverlapGuid);
			}
		}
	}

	private class State_Idle : PsmSubMachineState
	{
		private IBIC_GlobalActorData GlobalActorData { get; set; }

		private IBIC_TaskData TaskData { get; set; }

		private BattleStartConditionForPsm StartCondition { get; set; }

		public override void OnEnterAction()
		{
			if (!GetSubMachine<PsmSubMachine_CommonBattle>(out var OutSubMachine))
			{
				return;
			}
			OutSubMachine.SetObjStateOnBeginning();
			GlobalActorData = OutSubMachine.GlobalActorData;
			StartCondition = OutSubMachine.StartCondition;
			TaskData = OutSubMachine.TaskData;
			bool flag = false;
			switch (StartCondition.StartConditionType)
			{
			case EBattleStartConditionType.Auto:
				flag = true;
				break;
			case EBattleStartConditionType.UnitActive:
			{
				if (GlobalActorData.GetActorEntity(StartCondition.UnitGuid, out var Entity))
				{
					IBUC_CheckData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_CheckData>(ECSExtension.ToActor(Entity));
					if (readOnlyData != null)
					{
						CalliopeCustom_DetectCondition calliopeCustom_DetectCondition = new CalliopeCustom_DetectCondition();
						calliopeCustom_DetectCondition.DetectedElementType = 5;
						flag = readOnlyData.CheckDetectCondition(calliopeCustom_DetectCondition);
					}
				}
				break;
			}
			case EBattleStartConditionType.SpawnerActive:
				BGS_EventCollectionCS.Get(GetOwner()).Evt_BGS_NotifyGraph += new Del_Void_StringGameplayTag(OnNotifyGraph);
				break;
			case EBattleStartConditionType.EnterOverlap:
			{
				if (TaskData.IsPlayerInOverlap(StartCondition.OverlapGuid, out var bInnerOverlap))
				{
					flag = bInnerOverlap;
				}
				break;
			}
			}
			if (flag)
			{
				NotifyBattleStart();
			}
		}

		private void OnNotifyGraph(string ActorGuid, FGameplayTag NotifyTag)
		{
			bool flag = false;
			if (StartCondition.StartConditionType == EBattleStartConditionType.SpawnerActive && ActorGuid == StartCondition.SpawnerGuid && GameplayTagExtension.IsTag(NotifyTag, BGW_FlowUtils.CommonTag.WakeUp))
			{
				flag = true;
			}
			if (flag)
			{
				NotifyBattleStart();
			}
		}

		public override void OnTickAction(float InDeltaTime)
		{
			bool flag = false;
			bool bInnerOverlap;
			if (StartCondition.StartConditionType == EBattleStartConditionType.UnitActive)
			{
				if (GlobalActorData.GetActorEntity(StartCondition.UnitGuid, out var Entity))
				{
					IBUC_CheckData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_CheckData>(ECSExtension.ToActor(Entity));
					if (readOnlyData != null)
					{
						CalliopeCustom_DetectCondition calliopeCustom_DetectCondition = new CalliopeCustom_DetectCondition();
						calliopeCustom_DetectCondition.DetectedElementType = 5;
						flag = readOnlyData.CheckDetectCondition(calliopeCustom_DetectCondition);
					}
				}
			}
			else if (StartCondition.StartConditionType == EBattleStartConditionType.EnterOverlap && TaskData.IsPlayerInOverlap(StartCondition.OverlapGuid, out bInnerOverlap))
			{
				flag = bInnerOverlap;
			}
			if (flag)
			{
				NotifyBattleStart();
			}
		}

		public override void OnExitAction()
		{
			if (StartCondition.StartConditionType == EBattleStartConditionType.SpawnerActive)
			{
				BGS_EventCollectionCS.Get(GetOwner()).Evt_BGS_NotifyGraph -= new Del_Void_StringGameplayTag(OnNotifyGraph);
			}
		}

		private void NotifyBattleStart()
		{
			NotifySelf(BGW_FlowUtils.CommonTag.BattleStart);
		}
	}

	private class State_Battle : PsmSubMachineState
	{
		private HashSet<string> BlockingSpawnTamers { get; } = new HashSet<string>();

		public override void OnEnterAction()
		{
			if (!GetSubMachine<PsmSubMachine_CommonBattle>(out var OutSubMachine))
			{
				return;
			}
			OutSubMachine.SetObjStateBeforeBattle();
			ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(GetOwner(), 0);
			if (playerCharacter == null)
			{
				return;
			}
			BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(GetOwner());
			if (bGS_GSEventCollection == null)
			{
				return;
			}
			foreach (string battleStartActive in OutSubMachine.BattleStartActiveList)
			{
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(GetOwner(), battleStartActive);
				if (actorByGuid == null)
				{
					bGS_GSEventCollection.Evt_MarkTamerBlockingSpawn.Invoke(battleStartActive);
					BlockingSpawnTamers.Add(battleStartActive);
				}
				actorByGuid = BGU_DataUtil.GetActorByGuid(GetOwner(), battleStartActive);
				if (actorByGuid != null)
				{
					BUS_EventCollectionCS.Get(actorByGuid)?.Evt_AICatchTarget.Invoke(playerCharacter, ETargetSourceType.Target_CPGAssignTarget);
				}
			}
			foreach (string battleStartActiveGroupUnit in OutSubMachine.BattleStartActiveGroupUnitList)
			{
				foreach (AActor item in BGU_DataUtil.GetGroupUnitsByGroupGuid(GetOwner(), battleStartActiveGroupUnit))
				{
					if (item != null)
					{
						BUS_EventCollectionCS.Get(item)?.Evt_AICatchTarget.Invoke(playerCharacter, ETargetSourceType.Target_CPGAssignTarget);
					}
				}
			}
		}

		public override void OnExitAction()
		{
			ClearBlockingSpawnTamers();
		}

		public override void OnResetAction()
		{
		}

		private void ClearBlockingSpawnTamers()
		{
			if (BlockingSpawnTamers.Count == 0)
			{
				return;
			}
			BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(GetOwner());
			if (!(bGS_GSEventCollection != null))
			{
				return;
			}
			foreach (string blockingSpawnTamer in BlockingSpawnTamers)
			{
				bGS_GSEventCollection.Evt_UnMarkTamerBlockingSpawn.Invoke(blockingSpawnTamer);
			}
			BlockingSpawnTamers.Clear();
		}
	}

	private class State_BattleEnd : PsmSubMachineState
	{
		public override void OnEnterAction()
		{
			if (GetSubMachine<PsmSubMachine_CommonBattle>(out var OutSubMachine))
			{
				OutSubMachine.SetObjStateAfterBattle();
			}
		}
	}

	public override string NodeClass => B1CalliopeDef.ProcessMachineNode.Battle;

	protected override FGameplayTag FinalStateTag => BGW_FlowUtils.CommonProcessTag.State_BattleEnd;

	private ProcessCustom_Battle CustomData { get; set; }

	private BattleStartConditionForPsm StartCondition { get; set; }

	private List<string> BattleStartActiveList { get; } = new List<string>();

	private List<string> BattleStartActiveGroupUnitList { get; } = new List<string>();

	private IBIC_GlobalActorData GlobalActorData { get; set; }

	private IBIC_TaskData TaskData { get; set; }

	protected override void InitialData(byte[] CustomDataBytes)
	{
		base.InitialData(CustomDataBytes);
		GlobalActorData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(GetOwner());
		TaskData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(GetOwner());
		CustomData = new ProcessCustom_Battle();
		CustomData.MergeFrom(CustomDataBytes);
		FGameplayTag state_Idle = BGW_FlowUtils.CommonProcessTag.State_Idle;
		FGameplayTag state_Battle = BGW_FlowUtils.CommonProcessTag.State_Battle;
		RegisterStateWithClass(state_Idle, typeof(State_Idle));
		RegisterStateWithClass(state_Battle, typeof(State_Battle));
		RegisterStateWithClass(FinalStateTag, typeof(State_BattleEnd));
		RegisterInitialTransition(state_Idle);
		RegisterStateTransition(state_Idle, BGW_FlowUtils.CommonTag.BattleStart, state_Battle);
		RegisterResetStateTransition(state_Battle, state_Idle);
		base.ManagedSceneObjs.AddRange(CustomData.ManagedObjs);
		base.ManagedNpcUnits.AddRange(CustomData.ManagedNpcUnits);
		base.ManagedInteractors.AddRange(CustomData.ManagedInteractors);
		base.ManagedStreamingLevelStateConfigs.AddRange(CustomData.ManagedStreamingLevelStateConfigs);
		base.ManagedGroupUnits.AddRange(CustomData.ManagedGroupUnits);
	}

	public override void PreStart()
	{
		base.PreStart();
		StartCondition = new BattleStartConditionForPsm(CustomData.StartCondition, base.ParentPsmInstance);
		ClearTerminateGuards();
		foreach (CalliopeCustom_CompositeTransitionCondition_Battle transitionCondition in CustomData.TransitionConditions)
		{
			TransitionGuard guard = new TransitionGuard(transitionCondition, base.ParentNodeInstance);
			RegisterTerminateGuards(guard);
		}
		BattleStartActiveList.Clear();
		foreach (string battleStartActive in CustomData.BattleStartActiveList)
		{
			BattleStartActiveList.Add(base.ParentPsmInstance.ConvertParamID2StringParam(battleStartActive));
		}
		BattleStartActiveGroupUnitList.Clear();
		foreach (string battleStartActiveGroupUnit in CustomData.BattleStartActiveGroupUnitList)
		{
			BattleStartActiveGroupUnitList.Add(base.ParentPsmInstance.ConvertParamID2StringParam(battleStartActiveGroupUnit));
		}
	}

	public override void Shutdown()
	{
		base.Shutdown();
		StartCondition = null;
		BattleStartActiveList.Clear();
		BattleStartActiveGroupUnitList.Clear();
	}
}
