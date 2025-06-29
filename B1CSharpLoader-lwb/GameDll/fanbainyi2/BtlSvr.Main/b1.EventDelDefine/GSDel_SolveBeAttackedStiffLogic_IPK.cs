using System;
using b1.Prediction;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SolveBeAttackedStiffLogic_IPK : IFreshAbleGSEvent
{
	public GSDel_SolveBeAttackedStiffLogic_IPK_Del Predict = new GSDel_SolveBeAttackedStiffLogic_IPK_Del();

	public GSDel_SolveBeAttackedStiffLogic_IPK_Del Confirm = new GSDel_SolveBeAttackedStiffLogic_IPK_Del();

	public GSDel_SolveBeAttackedStiffLogic_IPK_Del Cue = new GSDel_SolveBeAttackedStiffLogic_IPK_Del();

	public GSDel_SolveBeAttackedStiffLogic_IPK_Del RollBack = new GSDel_SolveBeAttackedStiffLogic_IPK_Del();

	private Del_SolveBeAttackedStiffLogic _InvokeCallBack;

	public int _EventId;

	public GSEventCollectionBase __OwnerEventCollectionCS;

	public int EventId
	{
		get
		{
			return _EventId;
		}
		set
		{
			_EventId = value;
			Predict.EventId = _EventId + 1;
			Confirm.EventId = _EventId + 2;
			Cue.EventId = _EventId + 3;
			RollBack.EventId = _EventId + 4;
		}
	}

	public GSEventCollectionBase _OwnerEventCollectionCS
	{
		get
		{
			return __OwnerEventCollectionCS;
		}
		set
		{
			__OwnerEventCollectionCS = value;
			Predict._OwnerEventCollectionCS = __OwnerEventCollectionCS;
			Confirm._OwnerEventCollectionCS = __OwnerEventCollectionCS;
			Cue._OwnerEventCollectionCS = __OwnerEventCollectionCS;
			RollBack._OwnerEventCollectionCS = __OwnerEventCollectionCS;
		}
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
	}

	public GSDel_SolveBeAttackedStiffLogic_IPK(Del_SolveBeAttackedStiffLogic InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(UAnimMontage Montage, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(Montage, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(UAnimMontage Montage, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(Montage, PredictionKey);
	}

	public void CueInvoke(UAnimMontage Montage, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(Montage, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(UAnimMontage Montage, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(Montage, PredictionKey);
	}

	public void Invoke(UAnimMontage Montage)
	{
		_InvokeCallBack?.Invoke(Montage);
	}
}
