using System;
using System.Collections.Generic;
using b1.Prediction;

namespace b1.EventDelDefine;

public class GSDel_SmartCastSkillTry_IPK : IFreshAbleGSEvent
{
	public GSDel_SmartCastSkillTry_IPK_Del Predict = new GSDel_SmartCastSkillTry_IPK_Del();

	public GSDel_SmartCastSkillTry_IPK_Del Confirm = new GSDel_SmartCastSkillTry_IPK_Del();

	public GSDel_SmartCastSkillTry_IPK_Del Cue = new GSDel_SmartCastSkillTry_IPK_Del();

	public GSDel_SmartCastSkillTry_IPK_Del RollBack = new GSDel_SmartCastSkillTry_IPK_Del();

	private Del_SmartCastSkillTry _InvokeCallBack;

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

	public GSDel_SmartCastSkillTry_IPK(Del_SmartCastSkillTry InvokeCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
	}

	public void PredictInvoke(int ID, List<int> RuleIDList, EMontageBindReason Reason = EMontageBindReason.Default, ESkillDirection SkillDirection = ESkillDirection.None, bool bNeedCheckSkillCanCast = true, ECastSkillSourceType SourceType = ECastSkillSourceType.SmartCastSkill, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.PushRelatedEvent(EventId);
		Predict?.Invoke(ID, RuleIDList, Reason, SkillDirection, bNeedCheckSkillCanCast, SourceType, PredictionKey);
		PredictionKey?.PopRelatedEvent();
	}

	public void ConfirmInvoke(int ID, List<int> RuleIDList, EMontageBindReason Reason = EMontageBindReason.Default, ESkillDirection SkillDirection = ESkillDirection.None, bool bNeedCheckSkillCanCast = true, ECastSkillSourceType SourceType = ECastSkillSourceType.SmartCastSkill, GSPredictionKey PredictionKey = null)
	{
		Confirm?.Invoke(ID, RuleIDList, Reason, SkillDirection, bNeedCheckSkillCanCast, SourceType, PredictionKey);
	}

	public void CueInvoke(int ID, List<int> RuleIDList, EMontageBindReason Reason = EMontageBindReason.Default, ESkillDirection SkillDirection = ESkillDirection.None, bool bNeedCheckSkillCanCast = true, ECastSkillSourceType SourceType = ECastSkillSourceType.SmartCastSkill, GSPredictionKey PredictionKey = null)
	{
		PredictionKey?.CompareRelatedEventBegin(EventId);
		Cue?.Invoke(ID, RuleIDList, Reason, SkillDirection, bNeedCheckSkillCanCast, SourceType, PredictionKey);
		PredictionKey?.CompareRelatedEventEnd();
	}

	public void RollBackInvoke(int ID, List<int> RuleIDList, EMontageBindReason Reason = EMontageBindReason.Default, ESkillDirection SkillDirection = ESkillDirection.None, bool bNeedCheckSkillCanCast = true, ECastSkillSourceType SourceType = ECastSkillSourceType.SmartCastSkill, GSPredictionKey PredictionKey = null)
	{
		RollBack?.Invoke(ID, RuleIDList, Reason, SkillDirection, bNeedCheckSkillCanCast, SourceType, PredictionKey);
	}

	public void Invoke(int ID, List<int> RuleIDList, EMontageBindReason Reason = EMontageBindReason.Default, ESkillDirection SkillDirection = ESkillDirection.None, bool bNeedCheckSkillCanCast = true, ECastSkillSourceType SourceType = ECastSkillSourceType.SmartCastSkill)
	{
		_InvokeCallBack?.Invoke(ID, RuleIDList, Reason, SkillDirection, bNeedCheckSkillCanCast, SourceType);
	}
}
