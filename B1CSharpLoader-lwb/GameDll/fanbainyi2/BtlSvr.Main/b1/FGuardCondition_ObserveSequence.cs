using System;
using b1.EventDelDefine;
using CommB1;

namespace b1;

public class FGuardCondition_ObserveSequence : FGuardConditionBase
{
	public override EGuardConditionType ConditionType => EGuardConditionType.ObserveSequence;

	private int SequenceId { get; set; }

	private ESequencePhase SequencePhase { get; set; }

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		SequenceId = GuideCondition.SequenceId;
		SequencePhase = (ESequencePhase)GuideCondition.SequencePhase;
		return true;
	}

	protected override void Start()
	{
		if (BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_MovieData, BIC_MovieData>(base.Owner).IsSequencePlayed(SequenceId) && SequencePhase == ESequencePhase.Started)
		{
			base.QueryState = EQueryState.QuerySuccess;
			return;
		}
		switch (SequencePhase)
		{
		case ESequencePhase.Started:
		{
			BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(base.Owner);
			bGW_EventCollection2.Evt_NotifyMovieInstanceStarted = (Del_Void_Int)Delegate.Combine(bGW_EventCollection2.Evt_NotifyMovieInstanceStarted, new Del_Void_Int(CheckSequenceInCurrentPhase));
			break;
		}
		case ESequencePhase.Finished:
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
			bGW_EventCollection.Evt_NotifyMovieInstanceFinished = (Del_Void_Int)Delegate.Combine(bGW_EventCollection.Evt_NotifyMovieInstanceFinished, new Del_Void_Int(CheckSequenceInCurrentPhase));
			break;
		}
		}
	}

	private void CheckSequenceInCurrentPhase(int MovieSequenceId)
	{
		if (SequenceId == MovieSequenceId)
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}

	protected override void Stop()
	{
		switch (SequencePhase)
		{
		case ESequencePhase.Started:
		{
			BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(base.Owner);
			bGW_EventCollection2.Evt_NotifyMovieInstanceStarted = (Del_Void_Int)Delegate.Remove(bGW_EventCollection2.Evt_NotifyMovieInstanceStarted, new Del_Void_Int(CheckSequenceInCurrentPhase));
			break;
		}
		case ESequencePhase.Finished:
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(base.Owner);
			bGW_EventCollection.Evt_NotifyMovieInstanceFinished = (Del_Void_Int)Delegate.Remove(bGW_EventCollection.Evt_NotifyMovieInstanceFinished, new Del_Void_Int(CheckSequenceInCurrentPhase));
			break;
		}
		}
	}

	protected override void Clean()
	{
	}
}
