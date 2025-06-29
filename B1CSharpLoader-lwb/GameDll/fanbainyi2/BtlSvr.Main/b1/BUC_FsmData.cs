using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_FsmData : IBUC_FsmData, IPersistentECSData
{
	private int _identifyCount;

	public MultiMap<FName, FGameplayTag> CurrentStatesMapping { get; } = new MultiMap<FName, FGameplayTag>();

	public Dictionary<FGameplayTag, FsmState> StateMap { get; } = new Dictionary<FGameplayTag, FsmState>();

	public List<string> TemplatePaths { get; } = new List<string>();

	public Dictionary<FGameplayTag, string> SubMachineOverrideMap { get; } = new Dictionary<FGameplayTag, string>();

	public string PhaseTemplatePath { get; set; }

	public List<FsmInstance> Instances { get; } = new List<FsmInstance>();

	public bool bFsmPaused { get; set; }

	public bool bFsmInstancePaused { get; set; }

	public bool bUpdatingCurrentStates { get; set; }

	public string RelationActorName { get; set; }

	public int IdentifyCount => _identifyCount++;

	public BUC_FsmData()
	{
		_identifyCount = 0;
	}

	public bool IsInFsmState(FGameplayTag StateTag)
	{
		CheckIsUpdating();
		if (StateMap.TryGetValue(StateTag, out var value))
		{
			return value.bInState;
		}
		return false;
	}

	public List<string> GetPhaseDebugInfo()
	{
		List<string> list = new List<string>();
		Queue<FsmInstancePhaseComp> queue = new Queue<FsmInstancePhaseComp>();
		queue.Enqueue(GetPhaseComp());
		while (queue.Any())
		{
			FsmInstancePhaseComp fsmInstancePhaseComp = queue.Dequeue();
			if (CurrentStatesMapping.TryGetValue(fsmInstancePhaseComp.FsmIdentify, out var value) && value.Any())
			{
				list.Add(string.Join(", ", value));
			}
			foreach (FsmSubInstance subInstance in fsmInstancePhaseComp.SubInstances)
			{
				if (subInstance.PhaseComp != null)
				{
					queue.Enqueue(subInstance.PhaseComp);
				}
			}
		}
		return list;
	}

	public bool IsInFsmState(EBGUFSMStateName StateNameEnum)
	{
		CheckIsUpdating();
		FGameplayTag stateTag = default(FGameplayTag);
		switch (StateNameEnum)
		{
		case EBGUFSMStateName.FSM_STATE_LIFE:
			stateTag = BGW_FlowUtils.NormalAIFsmStateTag.LifeTime;
			break;
		case EBGUFSMStateName.FSM_STATE_LIFE_RETURNHOME:
			stateTag = BGW_FlowUtils.NormalAIFsmStateTag.LifeTimeReturnHome;
			break;
		case EBGUFSMStateName.FSM_STATE_LIFE_DEAD:
			stateTag = BGW_FlowUtils.NormalAIFsmStateTag.LifeTimeDead;
			break;
		case EBGUFSMStateName.FSM_STATE_BATTLE:
			stateTag = BGW_FlowUtils.NormalAIFsmStateTag.AIBattle;
			break;
		case EBGUFSMStateName.FSM_STATE_BATTLE_ATTACK:
			stateTag = BGW_FlowUtils.NormalAIFsmStateTag.AIBattleAttack;
			break;
		case EBGUFSMStateName.FSM_STATE_BATTLE_WANDER:
			stateTag = BGW_FlowUtils.NormalAIFsmStateTag.AIBattleWander;
			break;
		case EBGUFSMStateName.FSM_STATE_BATTLE_STALEMATE:
			stateTag = BGW_FlowUtils.NormalAIFsmStateTag.LifeTimeStalemate;
			break;
		case EBGUFSMStateName.FSM_STATE_NONCOMBAT:
			stateTag = BGW_FlowUtils.NormalAIFsmStateTag.AINonCombat;
			break;
		case EBGUFSMStateName.FSM_STATE_NONCOMBAT_IDLE:
			stateTag = BGW_FlowUtils.NormalAIFsmStateTag.AINonCombatIdle;
			break;
		case EBGUFSMStateName.FSM_STATE_REVOLVEAROUND:
			stateTag = BGW_FlowUtils.NormalAIFsmStateTag.LifeTimeRevolveAround;
			break;
		case EBGUFSMStateName.FSM_STATE_NEUTRALANIMAL_PATROL:
			stateTag = BGW_FlowUtils.NeutralAnimalAIFsmStateTag.Patrol;
			break;
		case EBGUFSMStateName.FSM_STATE_NEUTRALANIMAL_BATTLE:
			stateTag = BGW_FlowUtils.NeutralAnimalAIFsmStateTag.Battle;
			break;
		case EBGUFSMStateName.FSM_STATE_NEUTRALANIMAL_ESCAPE:
			stateTag = BGW_FlowUtils.NeutralAnimalAIFsmStateTag.Escape;
			break;
		}
		return IsInFsmState(stateTag);
	}

	public List<FGameplayTag> GetCurrentStates()
	{
		List<FGameplayTag> list = new List<FGameplayTag>();
		foreach (List<FGameplayTag> value in CurrentStatesMapping.Values)
		{
			list.AddRange(value);
		}
		return list;
	}

	public FsmInstancePhaseComp GetPhaseComp()
	{
		foreach (FsmInstance instance in Instances)
		{
			if (instance.PhaseComp != null)
			{
				return instance.PhaseComp;
			}
		}
		return null;
	}

	private void CheckIsUpdating()
	{
		if (bUpdatingCurrentStates)
		{
			BGW_LogUtil.LogError("检测到" + RelationActorName + "的FSM状态在更新过程中被查询，可能导致查询中间状态出现异常，看到注意修改！");
		}
	}

	public bool HasOverrideSubMachine(FGameplayTag NeedCheckStateTag)
	{
		string value;
		return SubMachineOverrideMap.TryGetValue(NeedCheckStateTag, out value);
	}
}
