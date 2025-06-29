using System;
using b1.Prediction;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_TriggerNormalDamageEffect_IPK : IFreshAbleGSEvent
{
	public GSDel_TriggerNormalDamageEffect_IPK_Del Predict = new GSDel_TriggerNormalDamageEffect_IPK_Del();

	public GSDel_TriggerNormalDamageEffect_IPK_Del Confirm = new GSDel_TriggerNormalDamageEffect_IPK_Del();

	public GSDel_TriggerNormalDamageEffect_IPK_Del Cue = new GSDel_TriggerNormalDamageEffect_IPK_Del();

	public GSDel_TriggerNormalDamageEffect_IPK_Del RollBack = new GSDel_TriggerNormalDamageEffect_IPK_Del();

	private Action<AActor, FSkillDamageConfig, FEffectInstReq, FBattleAttrSnapShot> _InvokeCallBack;

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

	public GSDel_TriggerNormalDamageEffect_IPK(Action<AActor, FSkillDamageConfig, FEffectInstReq, FBattleAttrSnapShot> InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(AActor Attacker, FSkillDamageConfig SkillDamageConfig, FEffectInstReq EffectInstReq, FBattleAttrSnapShot Attacker_AttrMemData, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(Attacker, in SkillDamageConfig, in EffectInstReq, in Attacker_AttrMemData, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(AActor Attacker, FSkillDamageConfig SkillDamageConfig, FEffectInstReq EffectInstReq, FBattleAttrSnapShot Attacker_AttrMemData, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(Attacker, in SkillDamageConfig, in EffectInstReq, in Attacker_AttrMemData, PredictionKey);
	}

	public void CueInvoke(AActor Attacker, FSkillDamageConfig SkillDamageConfig, FEffectInstReq EffectInstReq, FBattleAttrSnapShot Attacker_AttrMemData, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(Attacker, in SkillDamageConfig, in EffectInstReq, in Attacker_AttrMemData, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(AActor Attacker, FSkillDamageConfig SkillDamageConfig, FEffectInstReq EffectInstReq, FBattleAttrSnapShot Attacker_AttrMemData, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(Attacker, in SkillDamageConfig, in EffectInstReq, in Attacker_AttrMemData, PredictionKey);
	}

	public void Invoke(AActor Attacker, FSkillDamageConfig SkillDamageConfig, FEffectInstReq EffectInstReq, FBattleAttrSnapShot Attacker_AttrMemData)
	{
		_InvokeCallBack?.Invoke(Attacker, SkillDamageConfig, EffectInstReq, Attacker_AttrMemData);
	}
}
