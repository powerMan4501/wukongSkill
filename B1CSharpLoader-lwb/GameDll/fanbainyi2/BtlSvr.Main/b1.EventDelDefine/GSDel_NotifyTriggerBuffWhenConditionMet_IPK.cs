using System;
using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_NotifyTriggerBuffWhenConditionMet_IPK : IFreshAbleGSEvent
{
	public GSDel_NotifyTriggerBuffWhenConditionMet_IPK_Del Predict = new GSDel_NotifyTriggerBuffWhenConditionMet_IPK_Del();

	public GSDel_NotifyTriggerBuffWhenConditionMet_IPK_Del Confirm = new GSDel_NotifyTriggerBuffWhenConditionMet_IPK_Del();

	public GSDel_NotifyTriggerBuffWhenConditionMet_IPK_Del Cue = new GSDel_NotifyTriggerBuffWhenConditionMet_IPK_Del();

	public GSDel_NotifyTriggerBuffWhenConditionMet_IPK_Del RollBack = new GSDel_NotifyTriggerBuffWhenConditionMet_IPK_Del();

	private Action<EBuffEffectTriggerType, FEffectInstReq, AActor> _InvokeCallBack;

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

	public GSDel_NotifyTriggerBuffWhenConditionMet_IPK(Action<EBuffEffectTriggerType, FEffectInstReq, AActor> InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(EBuffEffectTriggerType TriggerType, FEffectInstReq EffectInstReq = default(FEffectInstReq), AActor Victim = null, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(TriggerType, in EffectInstReq, Victim, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(EBuffEffectTriggerType TriggerType, FEffectInstReq EffectInstReq = default(FEffectInstReq), AActor Victim = null, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(TriggerType, in EffectInstReq, Victim, PredictionKey);
	}

	public void CueInvoke(EBuffEffectTriggerType TriggerType, FEffectInstReq EffectInstReq = default(FEffectInstReq), AActor Victim = null, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(TriggerType, in EffectInstReq, Victim, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(EBuffEffectTriggerType TriggerType, FEffectInstReq EffectInstReq = default(FEffectInstReq), AActor Victim = null, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(TriggerType, in EffectInstReq, Victim, PredictionKey);
	}

	public void Invoke(EBuffEffectTriggerType TriggerType, FEffectInstReq EffectInstReq = default(FEffectInstReq), AActor Victim = null)
	{
		_InvokeCallBack?.Invoke(TriggerType, EffectInstReq, Victim);
	}
}
