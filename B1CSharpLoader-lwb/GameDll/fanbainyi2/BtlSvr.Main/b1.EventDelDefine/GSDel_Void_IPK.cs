using System;
using b1.Prediction;

namespace b1.EventDelDefine;

public class GSDel_Void_IPK : IFreshAbleGSEvent
{
	public GSDel_Void_IPK_Del Predict = new GSDel_Void_IPK_Del();

	public GSDel_Void_IPK_Del Confirm = new GSDel_Void_IPK_Del();

	public GSDel_Void_IPK_Del Cue = new GSDel_Void_IPK_Del();

	public GSDel_Void_IPK_Del RollBack = new GSDel_Void_IPK_Del();

	private Del_Void _InvokeCallBack;

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

	public GSDel_Void_IPK(Del_Void InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(PredictionKey);
	}

	public void CueInvoke(GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(PredictionKey);
	}

	public void Invoke()
	{
		_InvokeCallBack?.Invoke();
	}
}
