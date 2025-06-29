using System;
using CommB1;

namespace b1;

public class FGuardCondition_GroupUnitDead : FGuardConditionBase
{
	private string GroupUnit { get; set; } = string.Empty;

	private int UnitDeadNum { get; set; }

	private int UnitDeadCounter { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.GroupUnitDead;

	protected override void Clean()
	{
		GroupUnit = string.Empty;
		UnitDeadNum = 0;
		UnitDeadCounter = 0;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Battle BattleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		GroupUnit = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(BattleCondition.GroupUnit);
		UnitDeadNum = BattleCondition.UnitDeadNum;
		return true;
	}

	protected override void Start()
	{
		EventCollection = BGW_EventCollection.Get(base.Owner);
		BGW_EventCollection eventCollection = EventCollection;
		eventCollection.Evt_BGW_GroupUnitDead = (BGW_EventCollection.Del_BGW_GroupUnitDead)Delegate.Combine(eventCollection.Evt_BGW_GroupUnitDead, new BGW_EventCollection.Del_BGW_GroupUnitDead(OnGroupUnitDead));
	}

	protected override void Stop()
	{
		if (EventCollection != null)
		{
			BGW_EventCollection eventCollection = EventCollection;
			eventCollection.Evt_BGW_GroupUnitDead = (BGW_EventCollection.Del_BGW_GroupUnitDead)Delegate.Remove(eventCollection.Evt_BGW_GroupUnitDead, new BGW_EventCollection.Del_BGW_GroupUnitDead(OnGroupUnitDead));
		}
	}

	private void OnGroupUnitDead(string GroupGuidStr)
	{
		if (GroupGuidStr == GroupUnit)
		{
			UnitDeadCounter++;
			if (UnitDeadCounter >= UnitDeadNum)
			{
				base.QueryState = EQueryState.QuerySuccess;
			}
		}
	}
}
