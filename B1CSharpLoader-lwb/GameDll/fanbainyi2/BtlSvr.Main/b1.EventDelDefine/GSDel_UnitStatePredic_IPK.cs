using System;
using b1.Prediction;

namespace b1.EventDelDefine;

public class GSDel_UnitStatePredic_IPK : IFreshAbleGSEvent
{
	public GSDel_UnitStatePredic_IPK_Del Predict = new GSDel_UnitStatePredic_IPK_Del();

	public GSDel_UnitStatePredic_IPK_Del Confirm = new GSDel_UnitStatePredic_IPK_Del();

	public GSDel_UnitStatePredic_IPK_Del Cue = new GSDel_UnitStatePredic_IPK_Del();

	public GSDel_UnitStatePredic_IPK_Del RollBack = new GSDel_UnitStatePredic_IPK_Del();

	private Del_UnitStatePredic _InvokeCallBack;

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

	public GSDel_UnitStatePredic_IPK(Del_UnitStatePredic InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(EBGUUnitState UnitState, bool NeedForceUpdate = false, float Time = -1f, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(UnitState, NeedForceUpdate, Time, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(EBGUUnitState UnitState, bool NeedForceUpdate = false, float Time = -1f, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(UnitState, NeedForceUpdate, Time, PredictionKey);
	}

	public void CueInvoke(EBGUUnitState UnitState, bool NeedForceUpdate = false, float Time = -1f, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(UnitState, NeedForceUpdate, Time, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(EBGUUnitState UnitState, bool NeedForceUpdate = false, float Time = -1f, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(UnitState, NeedForceUpdate, Time, PredictionKey);
	}

	public void Invoke(EBGUUnitState UnitState, bool NeedForceUpdate = false, float Time = -1f)
	{
		_InvokeCallBack?.Invoke(UnitState, NeedForceUpdate, Time);
	}
}
