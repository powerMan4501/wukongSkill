using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_CheckComp : UActorCompBaseCS
{
	private BUC_CheckData CheckData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		CheckData = RequireWritableData<BUC_CheckData>();
		base.BUSEventCollection.Evt_StartGameplayCounter += new Del_Void_GuidGameplayCounterTypeFloat(OnStartGameplayCounter);
		base.BUSEventCollection.Evt_StopGameplayCounter += new Del_Void_Guid(OnStopGameplayCounter);
	}

	public override void PreBeginPlay()
	{
		CheckData.Owner = new TWeakObject<AActor>(Owner);
		CheckData.TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		CheckData.AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		CheckData.SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		CheckData.UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		CheckData.BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		CheckData.FsmData = RequireReadOnlyData<IBUC_FsmData, BUC_FsmData>();
		CheckData.BeAttackData = RequireReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>();
		CheckData.MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		CheckData.GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		CheckData.SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		CheckData.TransformInfoData = RequireReadOnlyData<IBUC_ActorTransformInfoData, BUC_ActorTransformInfoData>();
		CheckData.EnvironmentInteractionMgrData = RequireReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>();
		CheckData.GlobalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		CheckData.TamerFamilyTreeData = RequireReadOnlyGameStateData<IBGC_CircusControlData, BGC_CircusControlData>();
		CheckData.PlayerRoleData = RequireReadOnlyLocalPlayerControlData<IBPC_PlayerRoleData, BPC_PlayerRoleData>();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (CheckData.GameplayCounters.Count <= 0)
		{
			return;
		}
		CheckData.CompletedCounters.Clear();
		foreach (KeyValuePair<Guid, GSGameplayCounter> gameplayCounter in CheckData.GameplayCounters)
		{
			float num = 0f;
			GSGameplayCounter value = gameplayCounter.Value;
			switch (value.CounterType)
			{
			case EGameplayCounterType.Time:
				value.StartValue -= DeltaTime;
				break;
			case EGameplayCounterType.HP:
				num = CheckData.AttrContainer.GetFloatValue(EBGUAttrFloat.Hp);
				break;
			case EGameplayCounterType.HPPercent:
			{
				float floatValue = CheckData.AttrContainer.GetFloatValue(EBGUAttrFloat.Hp);
				float floatValMin = CheckData.AttrContainer.GetFloatValMin(EBGUAttrFloat.Hp);
				float floatValMax = CheckData.AttrContainer.GetFloatValMax(EBGUAttrFloat.Hp);
				num = (floatValue - floatValMin) / (floatValMax - floatValMin) * 100f;
				break;
			}
			default:
				continue;
			}
			float num2 = num - value.StartValue;
			if (value.TargetValue >= 0f)
			{
				if (num2 >= value.TargetValue)
				{
					CheckData.CompletedCounters.Add(gameplayCounter.Key);
				}
			}
			else if (num2 <= value.TargetValue)
			{
				CheckData.CompletedCounters.Add(gameplayCounter.Key);
			}
		}
		foreach (Guid completedCounter in CheckData.CompletedCounters)
		{
			base.BUSEventCollection.Evt_GameplayCountCompleted.Invoke(completedCounter);
		}
	}

	private void OnStartGameplayCounter(Guid Identifier, EGameplayCounterType CounterType, float CompletedValue)
	{
		float inStartValue = 0f;
		switch (CounterType)
		{
		case EGameplayCounterType.Time:
			inStartValue = 0f;
			break;
		case EGameplayCounterType.HP:
			inStartValue = CheckData.AttrContainer.GetFloatValue(EBGUAttrFloat.Hp);
			break;
		case EGameplayCounterType.HPPercent:
		{
			float floatValue = CheckData.AttrContainer.GetFloatValue(EBGUAttrFloat.Hp);
			float floatValMin = CheckData.AttrContainer.GetFloatValMin(EBGUAttrFloat.Hp);
			float floatValMax = CheckData.AttrContainer.GetFloatValMax(EBGUAttrFloat.Hp);
			inStartValue = (floatValue - floatValMin) / (floatValMax - floatValMin) * 100f;
			break;
		}
		}
		GSGameplayCounter value = new GSGameplayCounter(CounterType, inStartValue, CompletedValue);
		CheckData.GameplayCounters[Identifier] = value;
	}

	private void OnStopGameplayCounter(Guid Identifier)
	{
		if (CheckData.GameplayCounters.ContainsKey(Identifier))
		{
			CheckData.GameplayCounters.Remove(Identifier);
		}
	}
}
