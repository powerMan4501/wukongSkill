using System;
using b1.Prediction;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_SummonSkillCast_IPK : IFreshAbleGSEvent
{
	public GSDel_SummonSkillCast_IPK_Del Predict = new GSDel_SummonSkillCast_IPK_Del();

	public GSDel_SummonSkillCast_IPK_Del Confirm = new GSDel_SummonSkillCast_IPK_Del();

	public GSDel_SummonSkillCast_IPK_Del Cue = new GSDel_SummonSkillCast_IPK_Del();

	public GSDel_SummonSkillCast_IPK_Del RollBack = new GSDel_SummonSkillCast_IPK_Del();

	private Action<int, int, AActor, FEffectInstReq, bool, AActor> _InvokeCallBack;

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

	public GSDel_SummonSkillCast_IPK(Action<int, int, AActor, FEffectInstReq, bool, AActor> InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(int SummonID, int SummonPointIndex, AActor EffectCaster, FEffectInstReq EffectInstReq, bool TeleportSelf = false, AActor SelectPointActor = null, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(SummonID, SummonPointIndex, EffectCaster, in EffectInstReq, TeleportSelf, SelectPointActor, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(int SummonID, int SummonPointIndex, AActor EffectCaster, FEffectInstReq EffectInstReq, bool TeleportSelf = false, AActor SelectPointActor = null, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(SummonID, SummonPointIndex, EffectCaster, in EffectInstReq, TeleportSelf, SelectPointActor, PredictionKey);
	}

	public void CueInvoke(int SummonID, int SummonPointIndex, AActor EffectCaster, FEffectInstReq EffectInstReq, bool TeleportSelf = false, AActor SelectPointActor = null, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(SummonID, SummonPointIndex, EffectCaster, in EffectInstReq, TeleportSelf, SelectPointActor, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(int SummonID, int SummonPointIndex, AActor EffectCaster, FEffectInstReq EffectInstReq, bool TeleportSelf = false, AActor SelectPointActor = null, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(SummonID, SummonPointIndex, EffectCaster, in EffectInstReq, TeleportSelf, SelectPointActor, PredictionKey);
	}

	public void Invoke(int SummonID, int SummonPointIndex, AActor EffectCaster, FEffectInstReq EffectInstReq, bool TeleportSelf = false, AActor SelectPointActor = null)
	{
		_InvokeCallBack?.Invoke(SummonID, SummonPointIndex, EffectCaster, EffectInstReq, TeleportSelf, SelectPointActor);
	}
}
