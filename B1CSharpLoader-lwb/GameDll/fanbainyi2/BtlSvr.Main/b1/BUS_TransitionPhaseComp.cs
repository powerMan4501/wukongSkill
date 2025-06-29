using System.Collections.Generic;
using b1.EventDelDefine;
using BtlShare;
using GurCalliopeState;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_TransitionPhaseComp : UActorCompBaseCS
{
	private BUC_TransitionPhaseData _transitionPhaseData;

	private IBUC_UnitStateData _unitStateData;

	private IBUC_AttrContainer _attrContainer;

	private BUC_BeAttackData _beAttackData;

	private IBUC_GuidData _guidData;

	private BIC_GlobalActorData _globalActorData;

	private IBUC_SkillInstsData _skillInstsData;

	private IBUC_FsmData _fsmData;

	private IBGC_CircusControlData _circusControlData;

	private static int _timestamp;

	public override void OnAttach()
	{
		_transitionPhaseData = RequireWritableData<BUC_TransitionPhaseData>();
		_unitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		_attrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		_beAttackData = RequireWritableData<BUC_BeAttackData>();
		_guidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		_globalActorData = BGWGameInstanceCS.GetObject<BGW_GameDataMgr>(GetOwner()).GetGameInstanceWritableData<BIC_GlobalActorData>();
		_skillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		_fsmData = RequireReadOnlyData<IBUC_FsmData, BUC_FsmData>();
		_circusControlData = RequireReadOnlyGameStateData<IBGC_CircusControlData, BGC_CircusControlData>();
		base.BUSEventCollection.Evt_EnterOrExitPhasePerformance += new Del_Void_BoolString(OnEnterOrExitPhasePerformance);
		base.BUSEventCollection.Evt_FinishDetectCondition += new Del_Bool_DetectCondition(OnFinishDetectCondition);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	private void OnEnterOrExitPhasePerformance(bool bEnter, string Reason)
	{
		if (_fsmData.GetPhaseComp() != null)
		{
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(bEnter ? EBUStateTrigger.EnterPhasePerformance : EBUStateTrigger.ExitPhasePerformance, -1f);
			base.BUSEventCollection.Evt_AIPauseBT.Invoke(bEnter);
			_transitionPhaseData.ShowWarningInfoDuration = _transitionPhaseData.AllowPerformanceDuration;
			Reason = $"【{_timestamp++}】{Reason}";
			if (bEnter)
			{
				_fsmData.GetPhaseComp().LastEnterPhasePerformanceReason = Reason;
			}
			else
			{
				_fsmData.GetPhaseComp().LastLeavePhasePerformanceReason = Reason;
			}
		}
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (_transitionPhaseData.ShowWarningInfoDuration > 0f)
		{
			_transitionPhaseData.ShowWarningInfoDuration -= DeltaTime;
		}
		else if (_unitStateData.HasState(EBGUUnitState.PhasePerformance))
		{
			ThrowErrorMessage($"[{Owner.GetFName()}]角色进入表演状态已经超过{_transitionPhaseData.AllowPerformanceDuration}秒，请配置退出状态！！！");
		}
	}

	private void ThrowErrorMessage(string Message)
	{
		if (!_transitionPhaseData.HasShowMessageBox)
		{
			FMessage.OpenDialog("Something wrong: " + Message);
			_transitionPhaseData.HasShowMessageBox = true;
		}
	}

	private bool OnFinishDetectCondition(CalliopeCustom_DetectCondition DetectCondition)
	{
		switch ((EDetectedElementType)(byte)DetectCondition.DetectedElementType)
		{
		case EDetectedElementType.SimpleState:
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke((EBGUSimpleState)DetectCondition.SimpleState.SimpleState);
			break;
		case EDetectedElementType.UnitState:
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke((EBUStateTrigger)DetectCondition.UnitState.UnitState, -1f);
			break;
		case EDetectedElementType.HasBuff:
			base.BUSEventCollection.Evt_BuffAdd.Invoke(DetectCondition.HasBuff.BuffId, Owner, Owner, -1f, EBuffSourceType.TransitionPhase);
			break;
		case EDetectedElementType.UnitAttr:
		{
			EBGUAttrFloat attrID = (EBGUAttrFloat)DetectCondition.UnitAttr.AttrFloatType;
			float floatValMin = _attrContainer.GetFloatValMin(attrID);
			float floatValMax = _attrContainer.GetFloatValMax(attrID);
			float num = DetectCondition.UnitAttr.CompareValue;
			switch ((EValueCompareOperations)(byte)DetectCondition.UnitAttr.CompareOperation)
			{
			case EValueCompareOperations.NotEqualTo:
			case EValueCompareOperations.GreaterThan:
			case EValueCompareOperations.GreaterThanOrEqualTo:
				num += num;
				break;
			case EValueCompareOperations.LessThan:
			case EValueCompareOperations.LessThanOrEqualTo:
				num /= 2f;
				break;
			case EValueCompareOperations.LessThanPercentage:
			case EValueCompareOperations.LessThanOrEqualToPercentage:
				num = num * (floatValMax - floatValMin) / 2f;
				break;
			case EValueCompareOperations.GreaterThanPercentage:
			case EValueCompareOperations.GreaterThanOrEqualToPercentage:
				num = num * (floatValMax - floatValMin) * 2f;
				break;
			}
			base.BUSEventCollection.Evt_SetAttrFloat.Invoke(attrID, num);
			break;
		}
		case EDetectedElementType.SkillCoolDown:
			BGUFunctionLibraryCS.BGUTryCastSpell(Owner, DetectCondition.SkillCoolDown.SkillId, ECastSkillSourceType.TransitionPhase);
			break;
		case EDetectedElementType.CustomFsmState:
			OnCustomFsmState(DetectCondition.CustomFsmState.CustomFsmState);
			break;
		case EDetectedElementType.LastBeAttackedStiffLevel:
			OnLastBeAttackedStiffLevel(DetectCondition);
			break;
		case EDetectedElementType.CurrentBeAttackedStiffLevel:
			OnCurrentBeAttackedStiffLevel(DetectCondition);
			break;
		case EDetectedElementType.GlobalCastSkillCount:
			OnGlobalCastSkillCount(DetectCondition);
			break;
		case EDetectedElementType.AbnormalState:
			OnAbnormalState(DetectCondition);
			break;
		case EDetectedElementType.DurCastSkill:
			OnDurCastSkill(DetectCondition);
			break;
		case EDetectedElementType.CurSkillCostDmgNum:
			OnCurSkillCostDmgNum(DetectCondition);
			break;
		case EDetectedElementType.SocketUnitsDead:
			OnSocketUnitsDead(BED_CalliopeFuncLib.Deserialize(DetectCondition.SocketUnitsDead.MatchInfo));
			break;
		case EDetectedElementType.SpecifyResIdUnitsDead:
			OnSpecifyResIdUnitsDead(DetectCondition);
			break;
		case EDetectedElementType.FamilySpecifyUnitAttr:
			OnFamilySpecifyUnitAttr(DetectCondition);
			break;
		case EDetectedElementType.FamilyUnitAliveNum:
			OnFamilyUnitAliveNum(DetectCondition);
			break;
		default:
			return false;
		case EDetectedElementType.FsmState:
			break;
		}
		return true;
	}

	private void OnCustomFsmState(string CustomFsmState)
	{
		base.BUSEventCollection.Evt_TriggerFsmEvent.Invoke(GameplayTagExtension.MakeGameplayTag(CustomFsmState));
	}

	private void OnLastBeAttackedStiffLevel(CalliopeCustom_DetectCondition DetectCondition)
	{
		int num = DetectCondition.LastBeAttackedStiffLevel.CompareValueInt;
		switch ((EValueCompareOperations)(byte)DetectCondition.LastBeAttackedStiffLevel.CompareOperation)
		{
		case EValueCompareOperations.NotEqualTo:
		case EValueCompareOperations.GreaterThan:
		case EValueCompareOperations.GreaterThanOrEqualTo:
			num++;
			break;
		case EValueCompareOperations.LessThan:
		case EValueCompareOperations.LessThanOrEqualTo:
			num--;
			break;
		}
		_beAttackData.SetLastBeAttackedStiffLevel(num);
	}

	private void OnCurrentBeAttackedStiffLevel(CalliopeCustom_DetectCondition DetectCondition)
	{
		int num = DetectCondition.LastBeAttackedStiffLevel.CompareValueInt;
		switch ((EValueCompareOperations)(byte)DetectCondition.LastBeAttackedStiffLevel.CompareOperation)
		{
		case EValueCompareOperations.NotEqualTo:
		case EValueCompareOperations.GreaterThan:
		case EValueCompareOperations.GreaterThanOrEqualTo:
			num++;
			break;
		case EValueCompareOperations.LessThan:
		case EValueCompareOperations.LessThanOrEqualTo:
			num--;
			break;
		}
		_beAttackData.SetCurrentBeAttackedStiffLevel(num);
	}

	private void OnGlobalCastSkillCount(CalliopeCustom_DetectCondition DetectCondition)
	{
		int skillId = DetectCondition.GlobalCastSkillCount.SkillId;
		EValueCompareOperations eValueCompareOperations = (EValueCompareOperations)DetectCondition.GlobalCastSkillCount.CompareOperation;
		_ = DetectCondition.GlobalCastSkillCount.CompareValueInt;
		string finalGuid = _guidData.GetFinalGuid();
		int num = DetectCondition.GlobalCastSkillCount.CompareValueInt;
		switch (eValueCompareOperations)
		{
		case EValueCompareOperations.NotEqualTo:
		case EValueCompareOperations.GreaterThan:
		case EValueCompareOperations.GreaterThanOrEqualTo:
			num++;
			break;
		case EValueCompareOperations.LessThan:
		case EValueCompareOperations.LessThanOrEqualTo:
			num--;
			break;
		}
		_globalActorData.GMSetActorCastSkillCount(finalGuid, skillId, num);
	}

	private void OnAbnormalState(CalliopeCustom_DetectCondition DetectCondition)
	{
		base.BUSEventCollection.Evt_HandleAbnormal.Invoke((EAbnormalStateType)DetectCondition.AbnormalState.AbnormalStateType, Owner, EAccAbnormalValueType.IncreaseByINV10000, 10000f, 1);
	}

	private void OnDurCastSkill(CalliopeCustom_DetectCondition DetectCondition)
	{
		using IEnumerator<int> enumerator = DetectCondition.DurCastSkill.SkillIdList.GetEnumerator();
		if (enumerator.MoveNext())
		{
			int current = enumerator.Current;
			BGUFunctionLibraryCS.BGUTryCastSpell(Owner, current, ECastSkillSourceType.TransitionPhase);
		}
	}

	private void OnCurSkillCostDmgNum(CalliopeCustom_DetectCondition DetectCondition)
	{
		int num = DetectCondition.CurSkillCostDmgNum.CompareValueInt;
		switch ((EValueCompareOperations)(byte)DetectCondition.CurSkillCostDmgNum.CompareOperation)
		{
		case EValueCompareOperations.NotEqualTo:
		case EValueCompareOperations.GreaterThan:
		case EValueCompareOperations.GreaterThanOrEqualTo:
			num++;
			break;
		case EValueCompareOperations.LessThan:
		case EValueCompareOperations.LessThanOrEqualTo:
			num--;
			break;
		}
		base.BUSEventCollection?.Evt_OnSkillCostDmg.Invoke(Owner, _skillInstsData.CurrentCastingSkillID, num);
	}

	private void OnSocketUnitsDead(FTamerFamilyMatchChildInfo MatchInfo)
	{
		BGUFunctionLibraryCS.FetchChildActorByMatchInfo(Owner, MatchInfo).ForEach(delegate(AActor child)
		{
			BUS_EventCollectionCS.Get(child).Evt_UnitDead.Invoke(child, EDeadReason.Suicide);
		});
	}

	private void OnSpecifyResIdUnitsDead(CalliopeCustom_DetectCondition DetectCondition)
	{
		List<string> Guids = new List<string>();
		_circusControlData.TravelCircus(Owner, delegate(CircusMember Node)
		{
			if (Node.ResId == DetectCondition.SpecifyResIdUnitsDead.ResId)
			{
				Guids.Add(Node.ActorGuid);
			}
		});
		foreach (string item in Guids)
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, item);
			BUS_EventCollectionCS.Get(actorByGuid).Evt_UnitDead.Invoke(actorByGuid, EDeadReason.Suicide);
		}
	}

	private void OnFamilySpecifyUnitAttr(CalliopeCustom_DetectCondition DetectCondition)
	{
		FTamerFamilyMatchChildInfo matchInfo = BED_CalliopeFuncLib.Deserialize(DetectCondition.FamilySpecifyUnitAttr.MatchInfo);
		EBGUAttrFloat attrID = (EBGUAttrFloat)DetectCondition.FamilySpecifyUnitAttr.AttrFloatType;
		EValueCompareOperations eValueCompareOperations = (EValueCompareOperations)DetectCondition.FamilySpecifyUnitAttr.CompareOperation;
		_ = DetectCondition.FamilySpecifyUnitAttr.CompareValue;
		AActor aActor = null;
		List<string> list = BGUFunctionLibraryCS.FetchChildActorGuidByMatchInfo(Owner, matchInfo);
		if (list.Count < 1)
		{
			return;
		}
		aActor = BGU_DataUtil.GetActorByGuid(Owner, list[0]);
		if (!(aActor == null))
		{
			IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(aActor);
			float floatValMin = readOnlyData.GetFloatValMin(attrID);
			float floatValMax = readOnlyData.GetFloatValMax(attrID);
			float num = DetectCondition.FamilySpecifyUnitAttr.CompareValue;
			switch (eValueCompareOperations)
			{
			case EValueCompareOperations.NotEqualTo:
			case EValueCompareOperations.GreaterThan:
			case EValueCompareOperations.GreaterThanOrEqualTo:
				num += 1f;
				break;
			case EValueCompareOperations.LessThan:
			case EValueCompareOperations.LessThanOrEqualTo:
				num -= 1f;
				break;
			case EValueCompareOperations.LessThanPercentage:
			case EValueCompareOperations.LessThanOrEqualToPercentage:
				num = (num - 1f) / 100f * (floatValMax - floatValMin);
				break;
			case EValueCompareOperations.GreaterThanPercentage:
			case EValueCompareOperations.GreaterThanOrEqualToPercentage:
				num = (num + 1f) / 100f * (floatValMax - floatValMin);
				break;
			}
			BUS_EventCollectionCS.Get(aActor).Evt_SetAttrFloat.Invoke(attrID, num);
		}
	}

	private void OnFamilyUnitAliveNum(CalliopeCustom_DetectCondition DetectCondition)
	{
		FTamerFamilyMatchChildInfo matchInfo = BED_CalliopeFuncLib.Deserialize(DetectCondition.FamilyUnitAliveNum.MatchInfo);
		EValueCompareOperations eValueCompareOperations = (EValueCompareOperations)DetectCondition.FamilyUnitAliveNum.CompareOperation;
		int aliveUnitNum = DetectCondition.FamilyUnitAliveNum.AliveUnitNum;
		int num = 0;
		List<string> list = BGUFunctionLibraryCS.FetchChildActorGuidByMatchInfo(Owner, matchInfo);
		if (list.Count == 0)
		{
			return;
		}
		foreach (string item in list)
		{
			if (!_globalActorData.HasActorAliveState(item))
			{
				num++;
			}
			else if (_globalActorData.GetActorAliveState(item))
			{
				num++;
			}
		}
		int num2 = 0;
		switch (eValueCompareOperations)
		{
		case EValueCompareOperations.EqualTo:
			num2 = num - aliveUnitNum;
			break;
		case EValueCompareOperations.NotEqualTo:
		case EValueCompareOperations.GreaterThan:
		case EValueCompareOperations.GreaterThanOrEqualTo:
			num2 = num - aliveUnitNum - 1;
			break;
		case EValueCompareOperations.LessThan:
		case EValueCompareOperations.LessThanOrEqualTo:
			num2 = num - aliveUnitNum + 1;
			break;
		}
		if (num2 > 0 && num2 < list.Count)
		{
			for (int i = 0; i < num2; i++)
			{
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, list[i]);
				BUS_EventCollectionCS.Get(actorByGuid).Evt_UnitDead.Invoke(actorByGuid, EDeadReason.Suicide);
			}
		}
	}
}
