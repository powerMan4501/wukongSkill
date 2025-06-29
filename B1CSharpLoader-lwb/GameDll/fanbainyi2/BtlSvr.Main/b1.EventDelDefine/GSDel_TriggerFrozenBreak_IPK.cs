using System;
using b1.Prediction;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_TriggerFrozenBreak_IPK : IFreshAbleGSEvent
{
	public GSDel_TriggerFrozenBreak_IPK_Del Predict = new GSDel_TriggerFrozenBreak_IPK_Del();

	public GSDel_TriggerFrozenBreak_IPK_Del Confirm = new GSDel_TriggerFrozenBreak_IPK_Del();

	public GSDel_TriggerFrozenBreak_IPK_Del Cue = new GSDel_TriggerFrozenBreak_IPK_Del();

	public GSDel_TriggerFrozenBreak_IPK_Del RollBack = new GSDel_TriggerFrozenBreak_IPK_Del();

	private Action<FEffectInstReq, UAnimMontage, bool> _InvokeCallBack;

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

	public GSDel_TriggerFrozenBreak_IPK(Action<FEffectInstReq, UAnimMontage, bool> InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(FEffectInstReq EffectInstReq, UAnimMontage FrozenBreakAM, bool bIsNormalStiff, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(in EffectInstReq, FrozenBreakAM, bIsNormalStiff, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(FEffectInstReq EffectInstReq, UAnimMontage FrozenBreakAM, bool bIsNormalStiff, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(in EffectInstReq, FrozenBreakAM, bIsNormalStiff, PredictionKey);
	}

	public void CueInvoke(FEffectInstReq EffectInstReq, UAnimMontage FrozenBreakAM, bool bIsNormalStiff, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(in EffectInstReq, FrozenBreakAM, bIsNormalStiff, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(FEffectInstReq EffectInstReq, UAnimMontage FrozenBreakAM, bool bIsNormalStiff, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(in EffectInstReq, FrozenBreakAM, bIsNormalStiff, PredictionKey);
	}

	public void Invoke(FEffectInstReq EffectInstReq, UAnimMontage FrozenBreakAM, bool bIsNormalStiff)
	{
		_InvokeCallBack?.Invoke(EffectInstReq, FrozenBreakAM, bIsNormalStiff);
	}
}
