using System;
using b1.Prediction;

namespace b1.EventDelDefine;

public class GSDel_UnitStateTrigger_IPK : IFreshAbleGSEvent
{
	public GSDel_UnitStateTrigger_IPK_Del Predict = new GSDel_UnitStateTrigger_IPK_Del();

	public GSDel_UnitStateTrigger_IPK_Del Confirm = new GSDel_UnitStateTrigger_IPK_Del();

	public GSDel_UnitStateTrigger_IPK_Del Cue = new GSDel_UnitStateTrigger_IPK_Del();

	public GSDel_UnitStateTrigger_IPK_Del RollBack = new GSDel_UnitStateTrigger_IPK_Del();

	private Del_UnitStateTrigger _InvokeCallBack;

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

	public GSDel_UnitStateTrigger_IPK(Del_UnitStateTrigger InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(EBUStateTrigger TriggerID, float Time, bool NeedForceUpdate = false, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(TriggerID, Time, NeedForceUpdate, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(EBUStateTrigger TriggerID, float Time, bool NeedForceUpdate = false, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(TriggerID, Time, NeedForceUpdate, PredictionKey);
	}

	public void CueInvoke(EBUStateTrigger TriggerID, float Time, bool NeedForceUpdate = false, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(TriggerID, Time, NeedForceUpdate, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(EBUStateTrigger TriggerID, float Time, bool NeedForceUpdate = false, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(TriggerID, Time, NeedForceUpdate, PredictionKey);
	}

	public void Invoke(EBUStateTrigger TriggerID, float Time, bool NeedForceUpdate = false)
	{
		_InvokeCallBack?.Invoke(TriggerID, Time, NeedForceUpdate);
	}
}
