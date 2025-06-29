using System;
using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_UnitDead_IPK : IFreshAbleGSEvent
{
	public GSDel_UnitDead_IPK_Del Predict = new GSDel_UnitDead_IPK_Del();

	public GSDel_UnitDead_IPK_Del Confirm = new GSDel_UnitDead_IPK_Del();

	public GSDel_UnitDead_IPK_Del Cue = new GSDel_UnitDead_IPK_Del();

	public GSDel_UnitDead_IPK_Del RollBack = new GSDel_UnitDead_IPK_Del();

	private Action<AActor, EDeadReason, int, int, UAnimMontage, FEffectInstReq, bool, EAbnormalStateType> _InvokeCallBack;

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

	public GSDel_UnitDead_IPK(Action<AActor, EDeadReason, int, int, UAnimMontage, FEffectInstReq, bool, EAbnormalStateType> InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(AActor Attacker, EDeadReason DeadReason, int DmgID = -1, int StiffLevel = -1, UAnimMontage BeAttackedAM = null, FEffectInstReq EffectInstReq = default(FEffectInstReq), bool bIsDotDmg = false, EAbnormalStateType AbnormalStateType = EAbnormalStateType.None, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(Attacker, DeadReason, DmgID, StiffLevel, BeAttackedAM, EffectInstReq, bIsDotDmg, AbnormalStateType, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(AActor Attacker, EDeadReason DeadReason, int DmgID = -1, int StiffLevel = -1, UAnimMontage BeAttackedAM = null, FEffectInstReq EffectInstReq = default(FEffectInstReq), bool bIsDotDmg = false, EAbnormalStateType AbnormalStateType = EAbnormalStateType.None, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(Attacker, DeadReason, DmgID, StiffLevel, BeAttackedAM, EffectInstReq, bIsDotDmg, AbnormalStateType, PredictionKey);
	}

	public void CueInvoke(AActor Attacker, EDeadReason DeadReason, int DmgID = -1, int StiffLevel = -1, UAnimMontage BeAttackedAM = null, FEffectInstReq EffectInstReq = default(FEffectInstReq), bool bIsDotDmg = false, EAbnormalStateType AbnormalStateType = EAbnormalStateType.None, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(Attacker, DeadReason, DmgID, StiffLevel, BeAttackedAM, EffectInstReq, bIsDotDmg, AbnormalStateType, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(AActor Attacker, EDeadReason DeadReason, int DmgID = -1, int StiffLevel = -1, UAnimMontage BeAttackedAM = null, FEffectInstReq EffectInstReq = default(FEffectInstReq), bool bIsDotDmg = false, EAbnormalStateType AbnormalStateType = EAbnormalStateType.None, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(Attacker, DeadReason, DmgID, StiffLevel, BeAttackedAM, EffectInstReq, bIsDotDmg, AbnormalStateType, PredictionKey);
	}

	public void Invoke(AActor Attacker, EDeadReason DeadReason, int DmgID = -1, int StiffLevel = -1, UAnimMontage BeAttackedAM = null, FEffectInstReq EffectInstReq = default(FEffectInstReq), bool bIsDotDmg = false, EAbnormalStateType AbnormalStateType = EAbnormalStateType.None)
	{
		_InvokeCallBack?.Invoke(Attacker, DeadReason, DmgID, StiffLevel, BeAttackedAM, EffectInstReq, bIsDotDmg, AbnormalStateType);
	}
}
