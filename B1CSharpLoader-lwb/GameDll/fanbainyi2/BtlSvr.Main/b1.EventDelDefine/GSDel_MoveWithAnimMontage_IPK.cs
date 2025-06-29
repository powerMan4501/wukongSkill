using System;
using b1.Prediction;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_MoveWithAnimMontage_IPK : IFreshAbleGSEvent
{
	public GSDel_MoveWithAnimMontage_IPK_Del Predict = new GSDel_MoveWithAnimMontage_IPK_Del();

	public GSDel_MoveWithAnimMontage_IPK_Del Confirm = new GSDel_MoveWithAnimMontage_IPK_Del();

	public GSDel_MoveWithAnimMontage_IPK_Del Cue = new GSDel_MoveWithAnimMontage_IPK_Del();

	public GSDel_MoveWithAnimMontage_IPK_Del RollBack = new GSDel_MoveWithAnimMontage_IPK_Del();

	private Del_MoveWithAnimMontage _InvokeCallBack;

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

	public GSDel_MoveWithAnimMontage_IPK(Del_MoveWithAnimMontage InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(UAnimMontage Montage, float Scale, float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason = EMontageBindReason.Default, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(Montage, Scale, PlayTimeRate, MontagePosOffset, StartSectionName, Reason, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(UAnimMontage Montage, float Scale, float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason = EMontageBindReason.Default, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(Montage, Scale, PlayTimeRate, MontagePosOffset, StartSectionName, Reason, PredictionKey);
	}

	public void CueInvoke(UAnimMontage Montage, float Scale, float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason = EMontageBindReason.Default, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(Montage, Scale, PlayTimeRate, MontagePosOffset, StartSectionName, Reason, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(UAnimMontage Montage, float Scale, float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason = EMontageBindReason.Default, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(Montage, Scale, PlayTimeRate, MontagePosOffset, StartSectionName, Reason, PredictionKey);
	}

	public void Invoke(UAnimMontage Montage, float Scale, float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason = EMontageBindReason.Default)
	{
		_InvokeCallBack?.Invoke(Montage, Scale, PlayTimeRate, MontagePosOffset, StartSectionName, Reason);
	}
}
