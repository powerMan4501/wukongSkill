using System;
using b1.Prediction;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_BeAttackedVisualEffect_IPK : IFreshAbleGSEvent
{
	public GSDel_BeAttackedVisualEffect_IPK_Del Predict = new GSDel_BeAttackedVisualEffect_IPK_Del();

	public GSDel_BeAttackedVisualEffect_IPK_Del Confirm = new GSDel_BeAttackedVisualEffect_IPK_Del();

	public GSDel_BeAttackedVisualEffect_IPK_Del Cue = new GSDel_BeAttackedVisualEffect_IPK_Del();

	public GSDel_BeAttackedVisualEffect_IPK_Del RollBack = new GSDel_BeAttackedVisualEffect_IPK_Del();

	private Del_BeAttackedVisualEffect _InvokeCallBack;

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

	public GSDel_BeAttackedVisualEffect_IPK(Del_BeAttackedVisualEffect InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(AActor Attacker, ESkillDamageType SkillDamageType, EHitPerformFXEventType ExtraAkCheck, FEffectInstReq HitReq, int SkillEffectID, int HitPartID, bool bCostDmg = true, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(Attacker, SkillDamageType, ExtraAkCheck, HitReq, SkillEffectID, HitPartID, bCostDmg, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(AActor Attacker, ESkillDamageType SkillDamageType, EHitPerformFXEventType ExtraAkCheck, FEffectInstReq HitReq, int SkillEffectID, int HitPartID, bool bCostDmg = true, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(Attacker, SkillDamageType, ExtraAkCheck, HitReq, SkillEffectID, HitPartID, bCostDmg, PredictionKey);
	}

	public void CueInvoke(AActor Attacker, ESkillDamageType SkillDamageType, EHitPerformFXEventType ExtraAkCheck, FEffectInstReq HitReq, int SkillEffectID, int HitPartID, bool bCostDmg = true, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(Attacker, SkillDamageType, ExtraAkCheck, HitReq, SkillEffectID, HitPartID, bCostDmg, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(AActor Attacker, ESkillDamageType SkillDamageType, EHitPerformFXEventType ExtraAkCheck, FEffectInstReq HitReq, int SkillEffectID, int HitPartID, bool bCostDmg = true, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(Attacker, SkillDamageType, ExtraAkCheck, HitReq, SkillEffectID, HitPartID, bCostDmg, PredictionKey);
	}

	public void Invoke(AActor Attacker, ESkillDamageType SkillDamageType, EHitPerformFXEventType ExtraAkCheck, FEffectInstReq HitReq, int SkillEffectID, int HitPartID, bool bCostDmg = true)
	{
		_InvokeCallBack?.Invoke(Attacker, SkillDamageType, ExtraAkCheck, HitReq, SkillEffectID, HitPartID, bCostDmg);
	}
}
