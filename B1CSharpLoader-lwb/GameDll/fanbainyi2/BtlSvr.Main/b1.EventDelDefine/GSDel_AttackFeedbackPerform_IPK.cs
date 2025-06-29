using System;
using b1.Prediction;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_AttackFeedbackPerform_IPK : IFreshAbleGSEvent
{
	public GSDel_AttackFeedbackPerform_IPK_Del Predict = new GSDel_AttackFeedbackPerform_IPK_Del();

	public GSDel_AttackFeedbackPerform_IPK_Del Confirm = new GSDel_AttackFeedbackPerform_IPK_Del();

	public GSDel_AttackFeedbackPerform_IPK_Del Cue = new GSDel_AttackFeedbackPerform_IPK_Del();

	public GSDel_AttackFeedbackPerform_IPK_Del RollBack = new GSDel_AttackFeedbackPerform_IPK_Del();

	private Del_AttackFeedbackPerform _InvokeCallBack;

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

	public GSDel_AttackFeedbackPerform_IPK(Del_AttackFeedbackPerform InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(AActor Victim, ESkillDamageType SkillDamageType, EHitPerformFXEventType FinalHitPerformFXEventType, FEffectInstReq EffectInstReq, int CasterResID, int SkillEffectID, int HitPartID, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(Victim, SkillDamageType, FinalHitPerformFXEventType, EffectInstReq, CasterResID, SkillEffectID, HitPartID, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(AActor Victim, ESkillDamageType SkillDamageType, EHitPerformFXEventType FinalHitPerformFXEventType, FEffectInstReq EffectInstReq, int CasterResID, int SkillEffectID, int HitPartID, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(Victim, SkillDamageType, FinalHitPerformFXEventType, EffectInstReq, CasterResID, SkillEffectID, HitPartID, PredictionKey);
	}

	public void CueInvoke(AActor Victim, ESkillDamageType SkillDamageType, EHitPerformFXEventType FinalHitPerformFXEventType, FEffectInstReq EffectInstReq, int CasterResID, int SkillEffectID, int HitPartID, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(Victim, SkillDamageType, FinalHitPerformFXEventType, EffectInstReq, CasterResID, SkillEffectID, HitPartID, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(AActor Victim, ESkillDamageType SkillDamageType, EHitPerformFXEventType FinalHitPerformFXEventType, FEffectInstReq EffectInstReq, int CasterResID, int SkillEffectID, int HitPartID, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(Victim, SkillDamageType, FinalHitPerformFXEventType, EffectInstReq, CasterResID, SkillEffectID, HitPartID, PredictionKey);
	}

	public void Invoke(AActor Victim, ESkillDamageType SkillDamageType, EHitPerformFXEventType FinalHitPerformFXEventType, FEffectInstReq EffectInstReq, int CasterResID, int SkillEffectID, int HitPartID)
	{
		_InvokeCallBack?.Invoke(Victim, SkillDamageType, FinalHitPerformFXEventType, EffectInstReq, CasterResID, SkillEffectID, HitPartID);
	}
}
