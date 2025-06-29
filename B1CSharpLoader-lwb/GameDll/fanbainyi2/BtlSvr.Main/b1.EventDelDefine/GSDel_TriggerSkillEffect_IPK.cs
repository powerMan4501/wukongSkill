using System;
using b1.Prediction;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_TriggerSkillEffect_IPK : IFreshAbleGSEvent
{
	public GSDel_TriggerSkillEffect_IPK_Del Predict = new GSDel_TriggerSkillEffect_IPK_Del();

	public GSDel_TriggerSkillEffect_IPK_Del Confirm = new GSDel_TriggerSkillEffect_IPK_Del();

	public GSDel_TriggerSkillEffect_IPK_Del Cue = new GSDel_TriggerSkillEffect_IPK_Del();

	public GSDel_TriggerSkillEffect_IPK_Del RollBack = new GSDel_TriggerSkillEffect_IPK_Del();

	private Action<int, FEffectInstReq, AActor, bool> _InvokeCallBack;

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

	public GSDel_TriggerSkillEffect_IPK(Action<int, FEffectInstReq, AActor, bool> InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(int EffectID, FEffectInstReq EffectInstReq, AActor InnerTarget = null, bool bWithRPCEvent = true, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(EffectID, EffectInstReq, InnerTarget, bWithRPCEvent, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(int EffectID, FEffectInstReq EffectInstReq, AActor InnerTarget = null, bool bWithRPCEvent = true, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(EffectID, EffectInstReq, InnerTarget, bWithRPCEvent, PredictionKey);
	}

	public void CueInvoke(int EffectID, FEffectInstReq EffectInstReq, AActor InnerTarget = null, bool bWithRPCEvent = true, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(EffectID, EffectInstReq, InnerTarget, bWithRPCEvent, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(int EffectID, FEffectInstReq EffectInstReq, AActor InnerTarget = null, bool bWithRPCEvent = true, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(EffectID, EffectInstReq, InnerTarget, bWithRPCEvent, PredictionKey);
	}

	public void Invoke(int EffectID, FEffectInstReq EffectInstReq, AActor InnerTarget = null, bool bWithRPCEvent = true)
	{
		_InvokeCallBack?.Invoke(EffectID, EffectInstReq, InnerTarget, bWithRPCEvent);
	}
}
