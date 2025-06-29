using System;
using b1.Prediction;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_TriggerSkillEffectByBuff_IPK : IFreshAbleGSEvent
{
	public GSDel_TriggerSkillEffectByBuff_IPK_Del Predict = new GSDel_TriggerSkillEffectByBuff_IPK_Del();

	public GSDel_TriggerSkillEffectByBuff_IPK_Del Confirm = new GSDel_TriggerSkillEffectByBuff_IPK_Del();

	public GSDel_TriggerSkillEffectByBuff_IPK_Del Cue = new GSDel_TriggerSkillEffectByBuff_IPK_Del();

	public GSDel_TriggerSkillEffectByBuff_IPK_Del RollBack = new GSDel_TriggerSkillEffectByBuff_IPK_Del();

	private Action<int, AActor, int, FEffectInstReq, bool> _InvokeCallBack;

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

	public GSDel_TriggerSkillEffectByBuff_IPK(Action<int, AActor, int, FEffectInstReq, bool> InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(int BuffID, AActor Target, int EffectIdx, FEffectInstReq EffectInstReq, bool bIsPeriodical, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(BuffID, Target, EffectIdx, in EffectInstReq, bIsPeriodical, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(int BuffID, AActor Target, int EffectIdx, FEffectInstReq EffectInstReq, bool bIsPeriodical, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(BuffID, Target, EffectIdx, in EffectInstReq, bIsPeriodical, PredictionKey);
	}

	public void CueInvoke(int BuffID, AActor Target, int EffectIdx, FEffectInstReq EffectInstReq, bool bIsPeriodical, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(BuffID, Target, EffectIdx, in EffectInstReq, bIsPeriodical, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(int BuffID, AActor Target, int EffectIdx, FEffectInstReq EffectInstReq, bool bIsPeriodical, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(BuffID, Target, EffectIdx, in EffectInstReq, bIsPeriodical, PredictionKey);
	}

	public void Invoke(int BuffID, AActor Target, int EffectIdx, FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		_InvokeCallBack?.Invoke(BuffID, Target, EffectIdx, EffectInstReq, bIsPeriodical);
	}
}
