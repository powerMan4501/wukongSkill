using System;
using b1.Prediction;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_TriggerSkillEffectBySkill_IPK : IFreshAbleGSEvent
{
	public GSDel_TriggerSkillEffectBySkill_IPK_Del Predict = new GSDel_TriggerSkillEffectBySkill_IPK_Del();

	public GSDel_TriggerSkillEffectBySkill_IPK_Del Confirm = new GSDel_TriggerSkillEffectBySkill_IPK_Del();

	public GSDel_TriggerSkillEffectBySkill_IPK_Del Cue = new GSDel_TriggerSkillEffectBySkill_IPK_Del();

	public GSDel_TriggerSkillEffectBySkill_IPK_Del RollBack = new GSDel_TriggerSkillEffectBySkill_IPK_Del();

	private Action<int, AActor, AActor, FEffectInstReq> _InvokeCallBack;

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

	public GSDel_TriggerSkillEffectBySkill_IPK(Action<int, AActor, AActor, FEffectInstReq> InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(int EffectID, AActor Caster, AActor Target, FEffectInstReq EffectInstReq, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(EffectID, Caster, Target, in EffectInstReq, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(int EffectID, AActor Caster, AActor Target, FEffectInstReq EffectInstReq, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(EffectID, Caster, Target, in EffectInstReq, PredictionKey);
	}

	public void CueInvoke(int EffectID, AActor Caster, AActor Target, FEffectInstReq EffectInstReq, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(EffectID, Caster, Target, in EffectInstReq, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(int EffectID, AActor Caster, AActor Target, FEffectInstReq EffectInstReq, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(EffectID, Caster, Target, in EffectInstReq, PredictionKey);
	}

	public void Invoke(int EffectID, AActor Caster, AActor Target, FEffectInstReq EffectInstReq)
	{
		_InvokeCallBack?.Invoke(EffectID, Caster, Target, EffectInstReq);
	}
}
