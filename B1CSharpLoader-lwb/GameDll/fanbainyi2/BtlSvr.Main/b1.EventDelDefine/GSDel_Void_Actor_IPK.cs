using System;
using b1.Prediction;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_Void_Actor_IPK : IFreshAbleGSEvent
{
	public GSDel_Void_Actor_IPK_Del Predict = new GSDel_Void_Actor_IPK_Del();

	public GSDel_Void_Actor_IPK_Del Confirm = new GSDel_Void_Actor_IPK_Del();

	public GSDel_Void_Actor_IPK_Del Cue = new GSDel_Void_Actor_IPK_Del();

	public GSDel_Void_Actor_IPK_Del RollBack = new GSDel_Void_Actor_IPK_Del();

	private Del_Void_Actor _InvokeCallBack;

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

	public GSDel_Void_Actor_IPK(Del_Void_Actor InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(AActor Actor, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(Actor, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(AActor Actor, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(Actor, PredictionKey);
	}

	public void CueInvoke(AActor Actor, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(Actor, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(AActor Actor, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(Actor, PredictionKey);
	}

	public void Invoke(AActor Actor)
	{
		_InvokeCallBack?.Invoke(Actor);
	}
}
