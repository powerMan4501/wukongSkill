using System;
using CommB1;

namespace b1;

public class FGuardCondition_OpenUIPage : FGuardConditionBase
{
	private EUIPageType UIPageType;

	public override EGuardConditionType ConditionType => EGuardConditionType.OpenUIPage;

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		UIPageType = (EUIPageType)GuideCondition.UiPageType;
		return true;
	}

	protected override void Clean()
	{
	}

	protected override void Start()
	{
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(GetOwner());
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UIShowAnFinishScript = (BGW_UIEventCollection.Del_UI_UIShowAnFinish)Delegate.Combine(bGW_UIEventCollection.Evt_UIShowAnFinishScript, new BGW_UIEventCollection.Del_UI_UIShowAnFinish(OnUIShowAnFinish));
		}
	}

	protected override void Stop()
	{
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(GetOwner());
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UIShowAnFinishScript = (BGW_UIEventCollection.Del_UI_UIShowAnFinish)Delegate.Remove(bGW_UIEventCollection.Evt_UIShowAnFinishScript, new BGW_UIEventCollection.Del_UI_UIShowAnFinish(OnUIShowAnFinish));
		}
	}

	private void OnUIShowAnFinish(EUIPageType PageId)
	{
		if (UIPageType != EUIPageType.None && PageId == UIPageType)
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}
}
