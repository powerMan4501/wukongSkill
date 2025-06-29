using System;
using b1.Prediction;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_TriggerJumpSkill_IPK : IFreshAbleGSEvent
{
	public GSDel_TriggerJumpSkill_IPK_Del Predict = new GSDel_TriggerJumpSkill_IPK_Del();

	public GSDel_TriggerJumpSkill_IPK_Del Confirm = new GSDel_TriggerJumpSkill_IPK_Del();

	public GSDel_TriggerJumpSkill_IPK_Del Cue = new GSDel_TriggerJumpSkill_IPK_Del();

	public GSDel_TriggerJumpSkill_IPK_Del RollBack = new GSDel_TriggerJumpSkill_IPK_Del();

	private Del_TriggerJumpSkill _InvokeCallBack;

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

	public GSDel_TriggerJumpSkill_IPK(Del_TriggerJumpSkill InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(ESkillDirection StartJumpDir, FVector2D CurrentInput, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(StartJumpDir, CurrentInput, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(ESkillDirection StartJumpDir, FVector2D CurrentInput, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(StartJumpDir, CurrentInput, PredictionKey);
	}

	public void CueInvoke(ESkillDirection StartJumpDir, FVector2D CurrentInput, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(StartJumpDir, CurrentInput, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(ESkillDirection StartJumpDir, FVector2D CurrentInput, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(StartJumpDir, CurrentInput, PredictionKey);
	}

	public void Invoke(ESkillDirection StartJumpDir, FVector2D CurrentInput)
	{
		_InvokeCallBack?.Invoke(StartJumpDir, CurrentInput);
	}
}
