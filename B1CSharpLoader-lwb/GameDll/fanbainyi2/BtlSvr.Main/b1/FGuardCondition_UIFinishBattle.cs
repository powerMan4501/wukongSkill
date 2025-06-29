using System;
using b1.EventDelDefine;
using CommB1;

namespace b1;

public class FGuardCondition_UIFinishBattle : FGuardConditionBase
{
	public override EGuardConditionType ConditionType => EGuardConditionType.UIFinishBattle;

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		return true;
	}

	protected override void Start()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection.Evt_SettingEndBattle = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_SettingEndBattle, new Del_Void(OnSettingEndBattle));
	}

	protected override void Stop()
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
		bGW_EventCollection.Evt_SettingEndBattle = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_SettingEndBattle, new Del_Void(OnSettingEndBattle));
	}

	protected override void Clean()
	{
	}

	private void OnSettingEndBattle()
	{
		base.QueryState = EQueryState.QuerySuccess;
	}
}
