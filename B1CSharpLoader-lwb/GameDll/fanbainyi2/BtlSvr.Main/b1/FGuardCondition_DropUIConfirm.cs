using System;
using CommB1;

namespace b1;

public class FGuardCondition_DropUIConfirm : FGuardConditionBase
{
	public override EGuardConditionType ConditionType => EGuardConditionType.DropUIConfirm;

	private int ItemId { get; set; }

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		ItemId = GuideCondition.ItemId;
		return true;
	}

	protected override void Start()
	{
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(base.Owner);
		bGW_UIEventCollection.Evt_UI_DropUIConfirm = (BGW_UIEventCollection.Del_UI_Int)Delegate.Combine(bGW_UIEventCollection.Evt_UI_DropUIConfirm, new BGW_UIEventCollection.Del_UI_Int(OnDropUIConfirm));
	}

	protected override void Stop()
	{
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(base.Owner);
		bGW_UIEventCollection.Evt_UI_DropUIConfirm = (BGW_UIEventCollection.Del_UI_Int)Delegate.Remove(bGW_UIEventCollection.Evt_UI_DropUIConfirm, new BGW_UIEventCollection.Del_UI_Int(OnDropUIConfirm));
	}

	protected override void Clean()
	{
	}

	private void OnDropUIConfirm(int InItemId)
	{
		if (ItemId == InItemId)
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}
