using System;
using b1.EventDelDefine;
using CommB1;

namespace b1;

public class FGuardCondition_UnitsTransStage : FGuardConditionBase
{
	private string UnitGuid { get; set; }

	private BGW_EventCollection EventCollection { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.UnitsTransStage;

	protected override void Clean()
	{
		UnitGuid = "";
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Battle BattleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		UnitGuid = InPsmNodeInstance.ParentInstance.ConvertParamID2StringParam(BattleCondition.UnitGuid);
		return true;
	}

	protected override void Start()
	{
		EventCollection = BGW_EventCollection.Get(base.Owner);
		BGW_EventCollection eventCollection = EventCollection;
		eventCollection.Evt_NotifyUnitTransStage = (Del_Void_String)Delegate.Combine(eventCollection.Evt_NotifyUnitTransStage, new Del_Void_String(OnUnitTransStage));
	}

	protected override void Stop()
	{
		BGW_EventCollection eventCollection = EventCollection;
		eventCollection.Evt_NotifyUnitTransStage = (Del_Void_String)Delegate.Remove(eventCollection.Evt_NotifyUnitTransStage, new Del_Void_String(OnUnitTransStage));
	}

	private void OnUnitTransStage(string InUnitGuid)
	{
		if (InUnitGuid == UnitGuid)
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}
