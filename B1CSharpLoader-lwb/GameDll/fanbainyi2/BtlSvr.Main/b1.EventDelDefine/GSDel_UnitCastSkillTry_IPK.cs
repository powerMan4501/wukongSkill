using System;
using b1.Prediction;

namespace b1.EventDelDefine;

public class GSDel_UnitCastSkillTry_IPK : IFreshAbleGSEvent
{
	public GSDel_UnitCastSkillTry_IPK_Del Predict = new GSDel_UnitCastSkillTry_IPK_Del();

	public GSDel_UnitCastSkillTry_IPK_Del Confirm = new GSDel_UnitCastSkillTry_IPK_Del();

	public GSDel_UnitCastSkillTry_IPK_Del Cue = new GSDel_UnitCastSkillTry_IPK_Del();

	public GSDel_UnitCastSkillTry_IPK_Del RollBack = new GSDel_UnitCastSkillTry_IPK_Del();

	private Del_UnitCastSkillTry _InvokeCallBack;

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

	public GSDel_UnitCastSkillTry_IPK(Del_UnitCastSkillTry InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(FCastSkillInfo CSI, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(CSI, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(FCastSkillInfo CSI, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(CSI, PredictionKey);
	}

	public void CueInvoke(FCastSkillInfo CSI, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(CSI, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(FCastSkillInfo CSI, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(CSI, PredictionKey);
	}

	public void Invoke(FCastSkillInfo CSI)
	{
		_InvokeCallBack?.Invoke(CSI);
	}
}
