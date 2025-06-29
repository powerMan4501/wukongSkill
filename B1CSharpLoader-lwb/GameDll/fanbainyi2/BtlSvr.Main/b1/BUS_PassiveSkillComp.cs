using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Google.Protobuf.Collections;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_PassiveSkillComp : UActorCompBaseCS
{
	private BUC_PassiveSkillData PassiveSkillData;

	private BUC_CastImmobilizeData CastImmobilizeData;

	private BUC_IronBodyData IronBodyData;

	private const int ModifyImmobilizeEffect_ID1_BeginEffect = 1;

	private const int ModifyImmobilizeEffect_ID1_EndEffect = 2;

	private const int ModifyImmobilizeEffect_ID1_BreakEffect = 3;

	private const int ModifyImmobilizeEffect_ID1_DeadEffect = 4;

	private const int ModifyImmobilizeEffect_ID3_EffectType = 1;

	private const int ModifyImmobilizeEffect_ID3_TargetBaseType = 2;

	private const int ModifyImmobilizeEffect_ID3_Value = 3;

	public override void OnAttach()
	{
		PassiveSkillData = RequireWritableData<BUC_PassiveSkillData>();
		CastImmobilizeData = RequireWritableData<BUC_CastImmobilizeData>();
		IronBodyData = RequireWritableData<BUC_IronBodyData>();
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_PassiveSkillModifyParam += new Del_PassiveSkillModifyParam(ModifyParam);
		}
	}

	private void ModifyParam(int PassiveSkillID, int PassiveSkillMappingIndexID, bool bRecover, int Level)
	{
		FUStPassiveSkillDesc passiveSkillDescByMappingIndex = BGW_GameDB.GetPassiveSkillDescByMappingIndex(PassiveSkillID, PassiveSkillMappingIndexID);
		if (passiveSkillDescByMappingIndex == null)
		{
			return;
		}
		EModifyMethod modifyMethod = passiveSkillDescByMappingIndex.ModifyMethod;
		string mainID = passiveSkillDescByMappingIndex.MainID;
		int subID = passiveSkillDescByMappingIndex.SubID;
		int subID2 = passiveSkillDescByMappingIndex.SubID2;
		EValOp valOp = passiveSkillDescByMappingIndex.ValOp;
		float val = CalculateFinalValue(Level, passiveSkillDescByMappingIndex.BaseValue, passiveSkillDescByMappingIndex.Multiplier, passiveSkillDescByMappingIndex.MaxValue, passiveSkillDescByMappingIndex.MinValue);
		string[] array = mainID.Split(',');
		for (int i = 0; i < array.Length; i++)
		{
			if (int.TryParse(array[i], out var result))
			{
				ModifyParamImpl(modifyMethod, result, subID, subID2, valOp, val, bRecover);
			}
			else
			{
				BGW_LogUtil.LogError("Failed to parse MainID string with PassiveSkillID = " + PassiveSkillID + "!");
			}
		}
	}

	private float CalculateFinalValue(int Level, float BaseVal, float Multiplier, float MaxVal, float MinVal)
	{
		if (Multiplier == 0f)
		{
			return BaseVal;
		}
		if (!(Multiplier > 0f))
		{
			return Math.Max(BaseVal + (float)Level * Multiplier, MinVal);
		}
		return Math.Min(BaseVal + (float)Level * Multiplier, MaxVal);
	}

	private void ModifyParamImpl(EModifyMethod ModifyMethod, int MainID, int SubID, int SubID2, EValOp Op, float Val, bool bRecover)
	{
		int actorResID = GetActorResID();
		string text = $"{ModifyMethod},{MainID},{SubID},{SubID2}";
		float value = 0f;
		float num = 0f;
		switch (ModifyMethod)
		{
		case EModifyMethod.SkillCooldown:
		{
			FUStSkillSDesc originalSkillSDesc6 = BGW_GameDB.GetOriginalSkillSDesc(MainID);
			if (!PassiveSkillData.CachedSkillSDescs.ContainsKey(MainID))
			{
				FUStSkillSDesc value39 = BGU_DeepCopyUtil.Copy(originalSkillSDesc6);
				PassiveSkillData.CachedSkillSDescs.Add(MainID, value39);
			}
			value = originalSkillSDesc6.CooldownTime;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedSkillSDescs[MainID].CooldownTime = num;
			base.BUSEventCollection?.Evt_OnSkillCooldownChanged.Invoke(MainID, value, num);
			break;
		}
		case EModifyMethod.SkillMinAttrCostBase1:
		{
			FUStSkillSDesc originalSkillSDesc5 = BGW_GameDB.GetOriginalSkillSDesc(MainID);
			if (!PassiveSkillData.CachedSkillSDescs.ContainsKey(MainID))
			{
				FUStSkillSDesc value37 = BGU_DeepCopyUtil.Copy(originalSkillSDesc5);
				PassiveSkillData.CachedSkillSDescs.Add(MainID, value37);
			}
			value = originalSkillSDesc5.MinAttrCostBase1;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedSkillSDescs[MainID].MinAttrCostBase1 = num;
			base.BUSEventCollection?.Evt_OnSkillMinAttrCostBase1Changed.Invoke(MainID, value, num);
			break;
		}
		case EModifyMethod.SkillMinAttrCostBase2:
		{
			FUStSkillSDesc originalSkillSDesc = BGW_GameDB.GetOriginalSkillSDesc(MainID);
			if (!PassiveSkillData.CachedSkillSDescs.ContainsKey(MainID))
			{
				FUStSkillSDesc value3 = BGU_DeepCopyUtil.Copy(originalSkillSDesc);
				PassiveSkillData.CachedSkillSDescs.Add(MainID, value3);
			}
			value = originalSkillSDesc.MinAttrCostBase2;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedSkillSDescs[MainID].MinAttrCostBase2 = num;
			base.BUSEventCollection?.Evt_OnSkillMinAttrCostBase2Changed.Invoke(MainID, value, num);
			break;
		}
		case EModifyMethod.SkillMinAttrCostRatio1:
		{
			FUStSkillSDesc originalSkillSDesc3 = BGW_GameDB.GetOriginalSkillSDesc(MainID);
			if (!PassiveSkillData.CachedSkillSDescs.ContainsKey(MainID))
			{
				FUStSkillSDesc value22 = BGU_DeepCopyUtil.Copy(originalSkillSDesc3);
				PassiveSkillData.CachedSkillSDescs.Add(MainID, value22);
			}
			value = originalSkillSDesc3.MinAttrCostRatio1;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedSkillSDescs[MainID].MinAttrCostRatio1 = num;
			break;
		}
		case EModifyMethod.SkillMinAttrCostRatio2:
		{
			FUStSkillSDesc originalSkillSDesc2 = BGW_GameDB.GetOriginalSkillSDesc(MainID);
			if (!PassiveSkillData.CachedSkillSDescs.ContainsKey(MainID))
			{
				FUStSkillSDesc value9 = BGU_DeepCopyUtil.Copy(originalSkillSDesc2);
				PassiveSkillData.CachedSkillSDescs.Add(MainID, value9);
			}
			value = originalSkillSDesc2.MinAttrCostRatio2;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedSkillSDescs[MainID].MinAttrCostRatio2 = num;
			break;
		}
		case EModifyMethod.SkillEffectFloatN:
		{
			FUStSkillEffectDesc originalSkillEffectDesc3 = BGW_GameDB.GetOriginalSkillEffectDesc(MainID);
			if (!PassiveSkillData.CachedSkillEffectDescs.ContainsKey(MainID))
			{
				FUStSkillEffectDesc value30 = BGU_DeepCopyUtil.Copy(originalSkillEffectDesc3);
				PassiveSkillData.CachedSkillEffectDescs.Add(MainID, value30);
			}
			value = originalSkillEffectDesc3.EffectParamsFloat[SubID];
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedSkillEffectDescs[MainID].EffectParamsFloat[SubID] = num;
			base.BUSEventCollection?.Evt_OnSkillEffectFloatParamChanged.Invoke(MainID, SubID, value, num);
			break;
		}
		case EModifyMethod.SkillEffectIntN:
		{
			FUStSkillEffectDesc originalSkillEffectDesc4 = BGW_GameDB.GetOriginalSkillEffectDesc(MainID);
			if (!PassiveSkillData.CachedSkillEffectDescs.ContainsKey(MainID))
			{
				FUStSkillEffectDesc value34 = BGU_DeepCopyUtil.Copy(originalSkillEffectDesc4);
				PassiveSkillData.CachedSkillEffectDescs.Add(MainID, value34);
			}
			value = originalSkillEffectDesc4.EffectParamsInt[SubID];
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedSkillEffectDescs[MainID].EffectParamsInt[SubID] = (int)num;
			base.BUSEventCollection?.Evt_OnSkillEffectIntParamChanged.Invoke(MainID, SubID, (int)value, (int)num);
			break;
		}
		case EModifyMethod.SkillEffectTargetCount:
		{
			FUStSkillEffectDesc originalSkillEffectDesc2 = BGW_GameDB.GetOriginalSkillEffectDesc(MainID);
			if (!PassiveSkillData.CachedSkillEffectDescs.ContainsKey(MainID))
			{
				FUStSkillEffectDesc value24 = BGU_DeepCopyUtil.Copy(originalSkillEffectDesc2);
				PassiveSkillData.CachedSkillEffectDescs.Add(MainID, value24);
			}
			value = originalSkillEffectDesc2.TargetCount;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedSkillEffectDescs[MainID].TargetCount = (int)num;
			base.BUSEventCollection?.Evt_OnSkillEffectTargetCountChanged.Invoke(MainID, (int)value, (int)num);
			break;
		}
		case EModifyMethod.SkillEffectRange:
		{
			FUStSkillEffectDesc originalSkillEffectDesc5 = BGW_GameDB.GetOriginalSkillEffectDesc(MainID);
			if (!PassiveSkillData.CachedSkillEffectDescs.ContainsKey(MainID))
			{
				FUStSkillEffectDesc value43 = BGU_DeepCopyUtil.Copy(originalSkillEffectDesc5);
				PassiveSkillData.CachedSkillEffectDescs.Add(MainID, value43);
			}
			value = originalSkillEffectDesc5.Range.RangeParam[0];
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedSkillEffectDescs[MainID].Range.RangeParam[0] = (int)num;
			base.BUSEventCollection?.Evt_OnSkillEffectRangeChanged.Invoke(MainID, (int)value, (int)num);
			break;
		}
		case EModifyMethod.BuffDuration:
			value = BGW_GameDB.GetOriginalBuffDesc(MainID).Duration;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			CacheBuffModifyData(MainID, text, num);
			base.BUSEventCollection?.Evt_OnBuffDurationChanged.Invoke(MainID, (int)value, (int)num);
			break;
		case EModifyMethod.BuffEffectFloatN:
			value = BGW_GameDB.GetOriginalBuffDesc(MainID).BuffEffects[SubID].EffectParamsFloat[SubID2];
			num = ProcessValOp(text, Op, value, Val, bRecover);
			CacheBuffModifyData(MainID, text, num);
			base.BUSEventCollection?.Evt_OnBuffEffectFloatParamChanged.Invoke(MainID, SubID, SubID2, value, num);
			break;
		case EModifyMethod.BuffEffectIntN:
			value = BGW_GameDB.GetOriginalBuffDesc(MainID).BuffEffects[SubID].EffectParams[SubID2];
			num = ProcessValOp(text, Op, value, Val, bRecover);
			CacheBuffModifyData(MainID, text, num);
			base.BUSEventCollection?.Evt_OnBuffEffectIntParamChanged.Invoke(MainID, SubID, SubID2, (int)value, (int)num);
			break;
		case EModifyMethod.BuffInterval:
			value = BGW_GameDB.GetOriginalBuffDesc(MainID).Interval;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			CacheBuffModifyData(MainID, text, num);
			base.BUSEventCollection?.Evt_OnBuffIntervalChanged.Invoke(MainID, (int)value, (int)num);
			break;
		case EModifyMethod.BuffMaxLayer:
			value = BGW_GameDB.GetOriginalBuffDesc(MainID).MaxLayer;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			CacheBuffModifyData(MainID, text, num);
			base.BUSEventCollection?.Evt_OnBuffMaxLayerChanged.Invoke(MainID, (int)value, (int)num);
			break;
		case EModifyMethod.BuffTargetCount:
			value = BGW_GameDB.GetOriginalBuffDesc(MainID).TargetCount;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			CacheBuffModifyData(MainID, text, num);
			base.BUSEventCollection?.Evt_OnBuffTargetCountChanged.Invoke(MainID, (int)value, (int)num);
			break;
		case EModifyMethod.BuffRange:
			value = BGW_GameDB.GetOriginalBuffDesc(MainID).Range.RangeParam[0];
			num = ProcessValOp(text, Op, value, Val, bRecover);
			CacheBuffModifyData(MainID, text, num);
			base.BUSEventCollection?.Evt_OnBuffRangeChanged.Invoke(MainID, (int)value, (int)num);
			break;
		case EModifyMethod.SkillEffectActiveConditionParams:
		{
			FUStSkillEffectDesc originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(MainID);
			if (!PassiveSkillData.CachedSkillEffectDescs.ContainsKey(MainID))
			{
				FUStSkillEffectDesc value23 = BGU_DeepCopyUtil.Copy(originalSkillEffectDesc);
				PassiveSkillData.CachedSkillEffectDescs.Add(MainID, value23);
			}
			string[] array2 = originalSkillEffectDesc.EffectActiveCondition.ConditionParams.Split(',');
			if (SubID >= 0 && SubID < array2.Length && int.TryParse(array2[SubID], out var result2))
			{
				value = result2;
				num = ProcessValOp(text, Op, value, Val, bRecover);
				array2[SubID] = num.ToString();
				string text4 = "";
				string[] array3 = array2;
				foreach (string text5 in array3)
				{
					text4 = text4 + text5 + ",";
				}
				PassiveSkillData.CachedSkillEffectDescs[MainID].EffectActiveCondition.ConditionParams = text4;
				base.BUSEventCollection?.Evt_OnSkillEffectActiveConditionParamsChanged.Invoke(MainID, SubID, value, num);
			}
			break;
		}
		case EModifyMethod.BuffActiveConditionParams:
		{
			string[] array = BGW_GameDB.GetOriginalBuffDesc(MainID).BuffActiveCondition.ConditionParams.Split(',');
			if (SubID >= 0 && SubID < array.Length && int.TryParse(array[SubID], out var result))
			{
				value = result;
				num = ProcessValOp(text, Op, value, Val, bRecover);
				CacheBuffModifyData(MainID, text, num);
				base.BUSEventCollection?.Evt_OnBuffActiveConditionParamsChanged.Invoke(MainID, SubID, value, num);
			}
			break;
		}
		case EModifyMethod.ChargeSkillMoveSpeed:
		{
			FUStChargeSkillSDesc originalChargeSkillSDesc = BGW_GameDB.GetOriginalChargeSkillSDesc(MainID);
			if (!PassiveSkillData.CachedChargeSkillSDescs.ContainsKey(MainID))
			{
				FUStChargeSkillSDesc value2 = BGU_DeepCopyUtil.Copy(originalChargeSkillSDesc);
				PassiveSkillData.CachedChargeSkillSDescs.Add(MainID, value2);
			}
			value = (int)originalChargeSkillSDesc.ChargeMoveSpeedRate;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedChargeSkillSDescs[MainID].ChargeMoveSpeedRate = (EMoveSpeedType)num;
			base.BUSEventCollection?.Evt_OnChargeSkillMoveSpeedChanged.Invoke(MainID, (EMoveSpeedType)value, (EMoveSpeedType)num);
			break;
		}
		case EModifyMethod.ChargeSkillMaxChargeTime:
		{
			FUStChargeSkillSDesc originalChargeSkillSDesc3 = BGW_GameDB.GetOriginalChargeSkillSDesc(MainID);
			if (!PassiveSkillData.CachedChargeSkillSDescs.ContainsKey(MainID))
			{
				FUStChargeSkillSDesc value38 = BGU_DeepCopyUtil.Copy(originalChargeSkillSDesc3);
				PassiveSkillData.CachedChargeSkillSDescs.Add(MainID, value38);
			}
			value = originalChargeSkillSDesc3.MaxChargeTime;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedChargeSkillSDescs[MainID].MaxChargeTime = num;
			base.BUSEventCollection?.Evt_OnChargeSkillMaxChargeTimeChanged.Invoke(MainID, value, num);
			break;
		}
		case EModifyMethod.SkillIsComboSkill:
		{
			FUStSkillSDesc originalSkillSDesc4 = BGW_GameDB.GetOriginalSkillSDesc(MainID);
			if (!PassiveSkillData.CachedSkillSDescs.ContainsKey(MainID))
			{
				FUStSkillSDesc value33 = BGU_DeepCopyUtil.Copy(originalSkillSDesc4);
				PassiveSkillData.CachedSkillSDescs.Add(MainID, value33);
			}
			value = (int)originalSkillSDesc4.IsComboSkill;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedSkillSDescs[MainID].IsComboSkill = (EGSYesNo)num;
			base.BUSEventCollection?.Evt_OnSkillIsComboSkillChanged.Invoke(MainID, value, num);
			break;
		}
		case EModifyMethod.RollSkillEnabled:
		{
			FUStRollSkillDesc originalRollSkillDesc = BGW_GameDB.GetOriginalRollSkillDesc(MainID);
			if (!PassiveSkillData.CachedRollDescs.ContainsKey(MainID))
			{
				FUStRollSkillDesc value32 = BGU_DeepCopyUtil.Copy(originalRollSkillDesc);
				PassiveSkillData.CachedRollDescs.Add(MainID, value32);
			}
			value = (int)originalRollSkillDesc.EnableSkill;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedRollDescs[MainID].EnableSkill = (EGSYesNo)num;
			base.BUSEventCollection?.Evt_OnRollSkillEnabledChanged.Invoke(MainID, value, num);
			break;
		}
		case EModifyMethod.ChargeSkillLevelConfigIndex:
		{
			FUStChargeSkillSDesc originalChargeSkillSDesc2 = BGW_GameDB.GetOriginalChargeSkillSDesc(MainID);
			if (!PassiveSkillData.CachedChargeSkillSDescs.ContainsKey(MainID))
			{
				FUStChargeSkillSDesc value20 = BGU_DeepCopyUtil.Copy(originalChargeSkillSDesc2);
				PassiveSkillData.CachedChargeSkillSDescs.Add(MainID, value20);
			}
			value = originalChargeSkillSDesc2.ChargeLevelConfigIndex;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedChargeSkillSDescs[MainID].ChargeLevelConfigIndex = (int)num;
			base.BUSEventCollection?.Evt_OnChargeSkillChargeLevelConfigIndexChanged.Invoke(MainID, value, num);
			break;
		}
		case EModifyMethod.PlayerSkillCtrlAttackRange:
		{
			FUStPlayerSkillCtrlDesc originalPlayerSkillCtrlDesc = BGW_GameDB.GetOriginalPlayerSkillCtrlDesc(MainID);
			if (!PassiveSkillData.CachedPlayerSkillCtrlDescs.ContainsKey(MainID))
			{
				FUStPlayerSkillCtrlDesc value15 = BGU_DeepCopyUtil.Copy(originalPlayerSkillCtrlDesc);
				PassiveSkillData.CachedPlayerSkillCtrlDescs.Add(MainID, value15);
			}
			value = originalPlayerSkillCtrlDesc.AttackRange;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedPlayerSkillCtrlDescs[MainID].AttackRange = num;
			base.BUSEventCollection?.Evt_OnPlayerSkillAttackRangeChanged.Invoke(MainID, value, num);
			break;
		}
		case EModifyMethod.ImmobilizeDuration:
			value = BGW_GameDB.GetImmobilizeSkillConfigDesc(MainID).DurationMs;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			CastImmobilizeData.GetCachedImmobilizeConfigDesc(MainID).DurationMs = (int)num;
			break;
		case EModifyMethod.ImmobilizeTargetCount:
			value = BGW_GameDB.GetImmobilizeSkillConfigDesc(MainID).TargetCount;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			CastImmobilizeData.GetCachedImmobilizeConfigDesc(MainID).TargetCount = (int)num;
			break;
		case EModifyMethod.ImmobilizeRange:
			value = BGW_GameDB.GetImmobilizeSkillConfigDesc(MainID).RangeRadius;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			CastImmobilizeData.GetCachedImmobilizeConfigDesc(MainID).RangeRadius = (int)num;
			break;
		case EModifyMethod.ImmobilizeEffect:
			ModifyImmobilizeEffect(text, MainID, SubID, SubID2, Op, Val, bRecover);
			break;
		case EModifyMethod.IronBodyBeginWindowTime:
		{
			FUStIronBodyConfigDesc originalIronBodyConfigDesc = BGW_GameDB.GetOriginalIronBodyConfigDesc(actorResID);
			value = originalIronBodyConfigDesc.BeginPreciseWindowTime;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			if (!PassiveSkillData.CachedIronBodyConfigDescs.ContainsKey(actorResID))
			{
				FUStIronBodyConfigDesc value7 = BGU_DeepCopyUtil.Copy(originalIronBodyConfigDesc);
				PassiveSkillData.CachedIronBodyConfigDescs.Add(actorResID, value7);
			}
			PassiveSkillData.CachedIronBodyConfigDescs[actorResID].BeginPreciseWindowTime = num;
			break;
		}
		case EModifyMethod.IronBodyWindowTimeLength:
		{
			FUStIronBodyConfigDesc originalIronBodyConfigDesc3 = BGW_GameDB.GetOriginalIronBodyConfigDesc(actorResID);
			value = originalIronBodyConfigDesc3.EndPreciseWindowTime;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			if (!PassiveSkillData.CachedIronBodyConfigDescs.ContainsKey(actorResID))
			{
				FUStIronBodyConfigDesc value42 = BGU_DeepCopyUtil.Copy(originalIronBodyConfigDesc3);
				PassiveSkillData.CachedIronBodyConfigDescs.Add(actorResID, value42);
			}
			PassiveSkillData.CachedIronBodyConfigDescs[actorResID].EndPreciseWindowTime = num;
			break;
		}
		case EModifyMethod.IronBodyBuff:
		{
			FUStIronBodyConfigDesc originalIronBodyConfigDesc2 = BGW_GameDB.GetOriginalIronBodyConfigDesc(actorResID);
			if (!PassiveSkillData.CachedIronBodyConfigDescs.ContainsKey(actorResID))
			{
				FUStIronBodyConfigDesc value40 = BGU_DeepCopyUtil.Copy(originalIronBodyConfigDesc2);
				PassiveSkillData.CachedIronBodyConfigDescs.Add(actorResID, value40);
			}
			switch (SubID)
			{
			case 0:
				value = originalIronBodyConfigDesc2.StartTriggerInfoList[SubID2].BuffID;
				num = ProcessValOp(text, Op, value, Val, bRecover);
				PassiveSkillData.CachedIronBodyConfigDescs[actorResID].StartTriggerInfoList[SubID2].BuffID = (int)num;
				break;
			case 1:
				value = originalIronBodyConfigDesc2.DefeatTriggerInfoList[SubID2].BuffID;
				num = ProcessValOp(text, Op, value, Val, bRecover);
				PassiveSkillData.CachedIronBodyConfigDescs[actorResID].DefeatTriggerInfoList[SubID2].BuffID = (int)num;
				break;
			case 2:
				value = originalIronBodyConfigDesc2.PreciseTriggerInfoList[SubID2].BuffID;
				num = ProcessValOp(text, Op, value, Val, bRecover);
				PassiveSkillData.CachedIronBodyConfigDescs[actorResID].PreciseTriggerInfoList[SubID2].BuffID = (int)num;
				break;
			case 3:
				value = originalIronBodyConfigDesc2.NotPreciseTriggerInfoList[SubID2].BuffID;
				num = ProcessValOp(text, Op, value, Val, bRecover);
				PassiveSkillData.CachedIronBodyConfigDescs[actorResID].NotPreciseTriggerInfoList[SubID2].BuffID = (int)num;
				break;
			}
			break;
		}
		case EModifyMethod.SummonCommAliveTime:
		{
			FUStSummonCommDesc originalSummonCommDesc2 = BGW_GameDB.GetOriginalSummonCommDesc(MainID);
			if (!PassiveSkillData.CachedSummonCommDescs.ContainsKey(MainID))
			{
				FUStSummonCommDesc value36 = BGU_DeepCopyUtil.Copy(originalSummonCommDesc2);
				PassiveSkillData.CachedSummonCommDescs.Add(MainID, value36);
			}
			value = originalSummonCommDesc2.SummonAliveTime;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedSummonCommDescs[MainID].SummonAliveTime = num;
			break;
		}
		case EModifyMethod.SummonCommBuffListN:
		{
			FUStSummonCommDesc originalSummonCommDesc = BGW_GameDB.GetOriginalSummonCommDesc(MainID);
			if (!PassiveSkillData.CachedSummonCommDescs.ContainsKey(MainID))
			{
				FUStSummonCommDesc value35 = BGU_DeepCopyUtil.Copy(originalSummonCommDesc);
				PassiveSkillData.CachedSummonCommDescs.Add(MainID, value35);
			}
			value = originalSummonCommDesc.BuffList[SubID];
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedSummonCommDescs[MainID].BuffList[SubID] = (int)num;
			break;
		}
		case EModifyMethod.PlayerCommDodgeStartSkillId:
		{
			FUStPlayerInputSkillMappingDesc originalPlayerInputSkillMappingDesc2 = BGW_GameDB.GetOriginalPlayerInputSkillMappingDesc(MainID);
			if (!PassiveSkillData.CachedPlayerCommSkillDescs.ContainsKey(MainID))
			{
				FUStPlayerInputSkillMappingDesc value31 = BGU_DeepCopyUtil.Copy(originalPlayerInputSkillMappingDesc2);
				PassiveSkillData.CachedPlayerCommSkillDescs.Add(MainID, value31);
			}
			value = originalPlayerInputSkillMappingDesc2.DodgeStartSkillID;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedPlayerCommSkillDescs[MainID].DodgeStartSkillID = (int)num;
			base.BUSEventCollection.Evt_ResetDodgeSkill.Invoke();
			break;
		}
		case EModifyMethod.PlayerCommPreciseDodgeStartSkillId:
		{
			FUStPlayerInputSkillMappingDesc originalPlayerInputSkillMappingDesc = BGW_GameDB.GetOriginalPlayerInputSkillMappingDesc(MainID);
			if (!PassiveSkillData.CachedPlayerCommSkillDescs.ContainsKey(MainID))
			{
				FUStPlayerInputSkillMappingDesc value29 = BGU_DeepCopyUtil.Copy(originalPlayerInputSkillMappingDesc);
				PassiveSkillData.CachedPlayerCommSkillDescs.Add(MainID, value29);
			}
			value = originalPlayerInputSkillMappingDesc.PreciseDodgeStartSkillID;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedPlayerCommSkillDescs[MainID].PreciseDodgeStartSkillID = (int)num;
			base.BUSEventCollection.Evt_ResetDodgeSkill.Invoke();
			break;
		}
		case EModifyMethod.PlayerCommFallingDamageMultiplier:
		{
			FUStPlayerCommDesc originalPlayerCommDesc = BGW_GameDB.GetOriginalPlayerCommDesc(MainID);
			if (!PassiveSkillData.CachedFUStPlayerCommDescs.ContainsKey(MainID))
			{
				FUStPlayerCommDesc value28 = BGU_DeepCopyUtil.Copy(originalPlayerCommDesc);
				PassiveSkillData.CachedFUStPlayerCommDescs.Add(MainID, value28);
			}
			value = originalPlayerCommDesc.FallingDamageMultiplier;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedFUStPlayerCommDescs[MainID].FallingDamageMultiplier = num;
			break;
		}
		case EModifyMethod.SkillEffectDamageExpandN:
		{
			FUStSkillDamageExpandDesc originalSkillDamageExpandDesc = BGW_GameDB.GetOriginalSkillDamageExpandDesc(MainID);
			if (originalSkillDamageExpandDesc != null)
			{
				if (!PassiveSkillData.CachedSkillDamageExpandDescs.ContainsKey(MainID))
				{
					FUStSkillDamageExpandDesc value21 = BGU_DeepCopyUtil.Copy(originalSkillDamageExpandDesc);
					PassiveSkillData.CachedSkillDamageExpandDescs.Add(MainID, value21);
				}
				switch (SubID)
				{
				case 0:
					value = originalSkillDamageExpandDesc.CanTriggerFX;
					num = ProcessValOp(text, Op, value, Val, bRecover);
					PassiveSkillData.CachedSkillDamageExpandDescs[MainID].CanTriggerFX = (int)num;
					break;
				case 1:
					value = originalSkillDamageExpandDesc.CanTriggerFightBackCounter;
					num = ProcessValOp(text, Op, value, Val, bRecover);
					PassiveSkillData.CachedSkillDamageExpandDescs[MainID].CanTriggerFightBackCounter = (int)num;
					break;
				case 2:
					value = originalSkillDamageExpandDesc.DamageReason;
					num = ProcessValOp(text, Op, value, Val, bRecover);
					PassiveSkillData.CachedSkillDamageExpandDescs[MainID].DamageReason = (int)num;
					break;
				case 3:
					value = originalSkillDamageExpandDesc.CritRateAddition;
					num = ProcessValOp(text, Op, value, Val, bRecover);
					PassiveSkillData.CachedSkillDamageExpandDescs[MainID].CritRateAddition = num;
					break;
				case 4:
					value = originalSkillDamageExpandDesc.CritDmgAddition;
					num = ProcessValOp(text, Op, value, Val, bRecover);
					PassiveSkillData.CachedSkillDamageExpandDescs[MainID].CritDmgAddition = num;
					break;
				case 5:
					PassiveSkillData.CachedSkillDamageExpandDescs[MainID].IgnoreBeAttacked = ((!FMath.IsNearlyZero(value)) ? EGSYesNo.Yes : EGSYesNo.No);
					break;
				case 6:
					value = originalSkillDamageExpandDesc.AddTargetCurHpRatio;
					num = ProcessValOp(text, Op, value, Val, bRecover);
					PassiveSkillData.CachedSkillDamageExpandDescs[MainID].AddTargetCurHpRatio = num;
					break;
				case 7:
					value = originalSkillDamageExpandDesc.ImmobilizeHit;
					num = ProcessValOp(text, Op, value, Val, bRecover);
					PassiveSkillData.CachedSkillDamageExpandDescs[MainID].ImmobilizeHit = num;
					break;
				case 8:
					value = originalSkillDamageExpandDesc.PartDamage;
					num = ProcessValOp(text, Op, value, Val, bRecover);
					PassiveSkillData.CachedSkillDamageExpandDescs[MainID].PartDamage = num;
					break;
				case 9:
					value = originalSkillDamageExpandDesc.PevalueIncrements;
					num = ProcessValOp(text, Op, value, Val, bRecover);
					PassiveSkillData.CachedSkillDamageExpandDescs[MainID].PevalueIncrements = num;
					break;
				case 10:
					value = originalSkillDamageExpandDesc.TransIncrements;
					num = ProcessValOp(text, Op, value, Val, bRecover);
					PassiveSkillData.CachedSkillDamageExpandDescs[MainID].TransIncrements = num;
					break;
				}
			}
			break;
		}
		case EModifyMethod.PotentialEnergyConfigIndex:
		{
			if (!PassiveSkillData.ChachedPotentialEnergyConfigID.ContainsKey(MainID))
			{
				PassiveSkillData.ChachedPotentialEnergyConfigID.Add(MainID, 0);
			}
			value = 0f;
			int p = (int)PassiveSkillData.GetFinalValue(text, value);
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.ChachedPotentialEnergyConfigID[MainID] = (int)num;
			base.BUSEventCollection.Evt_SwitchPEConfig.Invoke(p, (int)num);
			break;
		}
		case EModifyMethod.PartRuleReduceParamsN:
		{
			Dictionary<int, FUStPartRuleInfoDesc> allPartRuleInfoDesc = BGW_GameDB.GetAllPartRuleInfoDesc();
			int num2 = -1;
			foreach (KeyValuePair<int, FUStPartRuleInfoDesc> item in allPartRuleInfoDesc)
			{
				if (item.Value.PartRuleID == MainID && item.Value.PartID == SubID)
				{
					num2 = item.Key;
					break;
				}
			}
			if (num2 >= 0)
			{
				FUStPartRuleInfoDesc originalPartRuleInfoDesc = BGW_GameDB.GetOriginalPartRuleInfoDesc(num2);
				if (!PassiveSkillData.CachedPartRuleInfoDescs.ContainsKey(num2))
				{
					FUStPartRuleInfoDesc value16 = BGU_DeepCopyUtil.Copy(originalPartRuleInfoDesc);
					PassiveSkillData.CachedPartRuleInfoDescs.Add(num2, value16);
				}
				value = originalPartRuleInfoDesc.ReduceParams[SubID2];
				num = ProcessValOp(text, Op, value, Val, bRecover);
				PassiveSkillData.CachedPartRuleInfoDescs[num2].ReduceParams[SubID2] = num;
				base.BUSEventCollection.Evt_RefreshCurPartRuleInfo.Invoke();
			}
			break;
		}
		case EModifyMethod.ProjectileLifeTime:
		{
			FUStProjectileCommDesc originalProjectileCommDesc = BGW_GameDB.GetOriginalProjectileCommDesc(MainID);
			if (!PassiveSkillData.CachedProjectileCommDescs.ContainsKey(MainID))
			{
				FUStProjectileCommDesc value11 = BGU_DeepCopyUtil.Copy(originalProjectileCommDesc);
				PassiveSkillData.CachedProjectileCommDescs.Add(MainID, value11);
			}
			value = originalProjectileCommDesc.ProjectileLifeTime;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedProjectileCommDescs[MainID].ProjectileLifeTime = num;
			break;
		}
		case EModifyMethod.BuffDelayTime:
			value = BGW_GameDB.GetOriginalBuffDesc(MainID).Delay;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			CacheBuffModifyData(MainID, text, num);
			break;
		case EModifyMethod.AttrCopyFactor:
		{
			FUStAttrCopyConfigDesc originalAttrCopyDesc = BGW_GameDB.GetOriginalAttrCopyDesc(MainID);
			if (!PassiveSkillData.CacheAttrCopyConfigDescs.ContainsKey(MainID))
			{
				FUStAttrCopyConfigDesc value6 = BGU_DeepCopyUtil.Copy(originalAttrCopyDesc);
				PassiveSkillData.CacheAttrCopyConfigDescs[MainID] = value6;
			}
			FUStAttrCopyConfigDesc cachedAttrCopyDesc = PassiveSkillData.CacheAttrCopyConfigDescs[MainID];
			CalcAttrCopyModifyData(SubID, SubID2, Op, Val, bRecover, originalAttrCopyDesc, text, cachedAttrCopyDesc);
			break;
		}
		case EModifyMethod.LifeSavingHairDefaultCd:
		{
			FUStLifeSavingHairConfigDesc originalLifeSavingHairConfigDesc = BGW_GameDB.GetOriginalLifeSavingHairConfigDesc(MainID);
			if (!PassiveSkillData.CachedLifeSavingHairConfigDescs.ContainsKey(MainID))
			{
				FUStLifeSavingHairConfigDesc value4 = BGU_DeepCopyUtil.Copy(originalLifeSavingHairConfigDesc);
				PassiveSkillData.CachedLifeSavingHairConfigDescs.Add(MainID, value4);
			}
			value = originalLifeSavingHairConfigDesc.DefaultCD;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedLifeSavingHairConfigDescs[MainID].DefaultCD = (int)num;
			break;
		}
		case EModifyMethod.LifeSavingHairEffectN:
		{
			FUStLifeSavingHairConfigDesc originalLifeSavingHairConfigDesc3 = BGW_GameDB.GetOriginalLifeSavingHairConfigDesc(MainID);
			if (!PassiveSkillData.CachedLifeSavingHairConfigDescs.ContainsKey(MainID))
			{
				FUStLifeSavingHairConfigDesc value44 = BGU_DeepCopyUtil.Copy(originalLifeSavingHairConfigDesc3);
				PassiveSkillData.CachedLifeSavingHairConfigDescs.Add(MainID, value44);
			}
			value = originalLifeSavingHairConfigDesc3.EffectIDList[SubID];
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedLifeSavingHairConfigDescs[MainID].EffectIDList[SubID] = (int)num;
			break;
		}
		case EModifyMethod.LifeSavingHairBuffN:
		{
			FUStLifeSavingHairConfigDesc originalLifeSavingHairConfigDesc2 = BGW_GameDB.GetOriginalLifeSavingHairConfigDesc(MainID);
			if (!PassiveSkillData.CachedLifeSavingHairConfigDescs.ContainsKey(MainID))
			{
				FUStLifeSavingHairConfigDesc value41 = BGU_DeepCopyUtil.Copy(originalLifeSavingHairConfigDesc2);
				PassiveSkillData.CachedLifeSavingHairConfigDescs.Add(MainID, value41);
			}
			value = originalLifeSavingHairConfigDesc2.BuffIDList[SubID];
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedLifeSavingHairConfigDescs[MainID].BuffIDList[SubID] = (int)num;
			break;
		}
		case EModifyMethod.SupreArmorValue:
		{
			FUStSuperArmorLevelDesc superArmorLevelDescOrgByID = BGW_GameDB.GetSuperArmorLevelDescOrgByID(MainID);
			if (!PassiveSkillData.CachedFUStSuperArmorLevelDescs.ContainsKey(MainID))
			{
				PassiveSkillData.CachedFUStSuperArmorLevelDescs.Add(MainID, BGU_DeepCopyUtil.Copy(superArmorLevelDescOrgByID));
			}
			value = superArmorLevelDescOrgByID.SuperArmorValue;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedFUStSuperArmorLevelDescs[MainID].SuperArmorValue = num;
			break;
		}
		case EModifyMethod.StaminaCostMoveFast:
		{
			FUStPlayerCommDesc originalPlayerCommDesc2 = BGW_GameDB.GetOriginalPlayerCommDesc(MainID);
			if (!PassiveSkillData.CachedFUStPlayerCommDescs.ContainsKey(MainID))
			{
				PassiveSkillData.CachedFUStPlayerCommDescs.Add(MainID, BGU_DeepCopyUtil.Copy(originalPlayerCommDesc2));
			}
			value = originalPlayerCommDesc2.StaminaCostMoveFast;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedFUStPlayerCommDescs[MainID].StaminaCostMoveFast = num;
			break;
		}
		case EModifyMethod.PhantomRushDuration:
		{
			FUStPhantomRushSkillConfigDesc phantomRushSkillOrgConfigDesc3 = BGW_GameDB.GetPhantomRushSkillOrgConfigDesc(MainID);
			if (!PassiveSkillData.CachedFUStPhantomRushSkillConfigDescs.ContainsKey(MainID))
			{
				PassiveSkillData.CachedFUStPhantomRushSkillConfigDescs.Add(MainID, BGU_DeepCopyUtil.Copy(phantomRushSkillOrgConfigDesc3));
			}
			value = phantomRushSkillOrgConfigDesc3.PhantomRushDuration;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			num = FMath.Max(num, 0f);
			PassiveSkillData.CachedFUStPhantomRushSkillConfigDescs[MainID].PhantomRushDuration = num;
			break;
		}
		case EModifyMethod.PhantomRushSkillId:
		{
			FUStPhantomRushSkillConfigDesc phantomRushSkillOrgConfigDesc2 = BGW_GameDB.GetPhantomRushSkillOrgConfigDesc(MainID);
			if (!PassiveSkillData.CachedFUStPhantomRushSkillConfigDescs.ContainsKey(MainID))
			{
				PassiveSkillData.CachedFUStPhantomRushSkillConfigDescs.Add(MainID, BGU_DeepCopyUtil.Copy(phantomRushSkillOrgConfigDesc2));
			}
			PassiveSkillData.CachedFUStPhantomRushSkillConfigDescs[MainID].PhantomRushSkillID = (int)Val;
			break;
		}
		case EModifyMethod.PhantomRushBeginAddBuffIdlist:
		{
			FUStPhantomRushSkillConfigDesc phantomRushSkillOrgConfigDesc = BGW_GameDB.GetPhantomRushSkillOrgConfigDesc(MainID);
			if (!PassiveSkillData.CachedFUStPhantomRushSkillConfigDescs.ContainsKey(MainID))
			{
				PassiveSkillData.CachedFUStPhantomRushSkillConfigDescs.Add(MainID, BGU_DeepCopyUtil.Copy(phantomRushSkillOrgConfigDesc));
			}
			PassiveSkillData.CachedFUStPhantomRushSkillConfigDescs[MainID].PhantomRushBeginAddBuffIDList[SubID] = (int)Val;
			break;
		}
		case EModifyMethod.PotentialEnergyProtectTime:
		{
			Dictionary<int, Dictionary<int, FUStPotentialEnergyConfigDesc>> originalPotentialEnergyResConfigDesc3 = BGW_GameDB.GetOriginalPotentialEnergyResConfigDesc(MainID);
			Dictionary<int, FUStPotentialEnergyConfigDesc> originalPotentialEnergyConfigDesc3 = BGW_GameDB.GetOriginalPotentialEnergyConfigDesc(MainID, SubID);
			if (!PassiveSkillData.CachedPotentialEnergyConfigDescs.TryGetValue(MainID, out var value25))
			{
				value25 = BGU_DeepCopyUtil.Copy(originalPotentialEnergyResConfigDesc3);
				PassiveSkillData.CachedPotentialEnergyConfigDescs.Add(MainID, value25);
			}
			if (value25.TryGetValue(SubID, out var value26))
			{
				FUStPotentialEnergyConfigDesc value27;
				if (SubID2 < 0)
				{
					foreach (KeyValuePair<int, FUStPotentialEnergyConfigDesc> item2 in value26)
					{
						string text6 = $",{item2.Key}";
						value = originalPotentialEnergyConfigDesc3[item2.Key].PELevelConfig.ProtectTime;
						num = ProcessValOp(text + text6, Op, value, Val, bRecover);
						item2.Value.PELevelConfig.ProtectTime = num;
					}
				}
				else if (value26.TryGetValue(SubID2, out value27))
				{
					value = originalPotentialEnergyConfigDesc3[SubID2].PELevelConfig.ProtectTime;
					num = ProcessValOp(text, Op, value, Val, bRecover);
					value27.PELevelConfig.ProtectTime = num;
					value26[SubID2] = value27;
				}
			}
			base.BUSEventCollection.Evt_ReloadPEConfig.Invoke();
			break;
		}
		case EModifyMethod.PotentialEnergyDecreaseValue:
		{
			Dictionary<int, Dictionary<int, FUStPotentialEnergyConfigDesc>> originalPotentialEnergyResConfigDesc2 = BGW_GameDB.GetOriginalPotentialEnergyResConfigDesc(MainID);
			Dictionary<int, FUStPotentialEnergyConfigDesc> originalPotentialEnergyConfigDesc2 = BGW_GameDB.GetOriginalPotentialEnergyConfigDesc(MainID, SubID);
			if (!PassiveSkillData.CachedPotentialEnergyConfigDescs.TryGetValue(MainID, out var value17))
			{
				value17 = BGU_DeepCopyUtil.Copy(originalPotentialEnergyResConfigDesc2);
				PassiveSkillData.CachedPotentialEnergyConfigDescs.Add(MainID, value17);
			}
			if (value17.TryGetValue(SubID, out var value18))
			{
				FUStPotentialEnergyConfigDesc value19;
				if (SubID2 < 0)
				{
					foreach (KeyValuePair<int, FUStPotentialEnergyConfigDesc> item3 in value18)
					{
						string text3 = $",{item3.Key}";
						value = originalPotentialEnergyConfigDesc2[item3.Key].PELevelConfig.DecreaseValuePerSecond;
						num = ProcessValOp(text + text3, Op, value, Val, bRecover);
						item3.Value.PELevelConfig.DecreaseValuePerSecond = num;
					}
				}
				else if (value18.TryGetValue(SubID2, out value19))
				{
					value = originalPotentialEnergyConfigDesc2[SubID2].PELevelConfig.DecreaseValuePerSecond;
					num = ProcessValOp(text, Op, value, Val, bRecover);
					value19.PELevelConfig.DecreaseValuePerSecond = num;
					value18[SubID2] = value19;
				}
			}
			base.BUSEventCollection.Evt_ReloadPEConfig.Invoke();
			break;
		}
		case EModifyMethod.PotentialEnergyLevelValue:
		{
			Dictionary<int, Dictionary<int, FUStPotentialEnergyConfigDesc>> originalPotentialEnergyResConfigDesc = BGW_GameDB.GetOriginalPotentialEnergyResConfigDesc(MainID);
			Dictionary<int, FUStPotentialEnergyConfigDesc> originalPotentialEnergyConfigDesc = BGW_GameDB.GetOriginalPotentialEnergyConfigDesc(MainID, SubID);
			if (!PassiveSkillData.CachedPotentialEnergyConfigDescs.TryGetValue(MainID, out var value12))
			{
				value12 = BGU_DeepCopyUtil.Copy(originalPotentialEnergyResConfigDesc);
				PassiveSkillData.CachedPotentialEnergyConfigDescs.Add(MainID, value12);
			}
			if (value12.TryGetValue(SubID, out var value13))
			{
				FUStPotentialEnergyConfigDesc value14;
				if (SubID2 < 0)
				{
					foreach (KeyValuePair<int, FUStPotentialEnergyConfigDesc> item4 in value13)
					{
						string text2 = $",{item4.Key}";
						value = originalPotentialEnergyConfigDesc[item4.Key].PELevelConfig.LevelValue;
						num = ProcessValOp(text + text2, Op, value, Val, bRecover);
						num = FMath.Max(num, 0f);
						item4.Value.PELevelConfig.LevelValue = num;
					}
				}
				else if (value13.TryGetValue(SubID2, out value14))
				{
					value = originalPotentialEnergyConfigDesc[SubID2].PELevelConfig.LevelValue;
					num = ProcessValOp(text, Op, value, Val, bRecover);
					num = FMath.Max(num, 0f);
					value14.PELevelConfig.LevelValue = num;
					value13[SubID2] = value14;
				}
			}
			base.BUSEventCollection.Evt_ReloadPEConfig.Invoke();
			break;
		}
		case EModifyMethod.EffectiveHitProjectileEffectPevalueSwitchRatio:
		{
			FUStEffectiveHitProjectileEffectDesc originalEffectiveHitProjectileEffectDesc3 = BGW_GameDB.GetOriginalEffectiveHitProjectileEffectDesc(MainID);
			if (!PassiveSkillData.CachedEffectiveHitProjectileEffectDescs.ContainsKey(MainID))
			{
				FUStEffectiveHitProjectileEffectDesc value10 = BGU_DeepCopyUtil.Copy(originalEffectiveHitProjectileEffectDesc3);
				PassiveSkillData.CachedEffectiveHitProjectileEffectDescs.Add(MainID, value10);
			}
			value = originalEffectiveHitProjectileEffectDesc3.PEValueSwitchRatio;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedEffectiveHitProjectileEffectDescs[MainID].PEValueSwitchRatio = num;
			break;
		}
		case EModifyMethod.EffectiveHitProjectileEffectCostAttrType:
		{
			FUStEffectiveHitProjectileEffectDesc originalEffectiveHitProjectileEffectDesc2 = BGW_GameDB.GetOriginalEffectiveHitProjectileEffectDesc(MainID);
			if (!PassiveSkillData.CachedEffectiveHitProjectileEffectDescs.ContainsKey(MainID))
			{
				FUStEffectiveHitProjectileEffectDesc value8 = BGU_DeepCopyUtil.Copy(originalEffectiveHitProjectileEffectDesc2);
				PassiveSkillData.CachedEffectiveHitProjectileEffectDescs.Add(MainID, value8);
			}
			value = (int)originalEffectiveHitProjectileEffectDesc2.CostAttr.CostAttrType;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedEffectiveHitProjectileEffectDescs[MainID].CostAttr.CostAttrType = (EProjectileBeHittedCostAttrType)num;
			break;
		}
		case EModifyMethod.EffectiveHitProjectileEffectAttrSwitchRatio:
		{
			FUStEffectiveHitProjectileEffectDesc originalEffectiveHitProjectileEffectDesc = BGW_GameDB.GetOriginalEffectiveHitProjectileEffectDesc(MainID);
			if (!PassiveSkillData.CachedEffectiveHitProjectileEffectDescs.ContainsKey(MainID))
			{
				FUStEffectiveHitProjectileEffectDesc value5 = BGU_DeepCopyUtil.Copy(originalEffectiveHitProjectileEffectDesc);
				PassiveSkillData.CachedEffectiveHitProjectileEffectDescs.Add(MainID, value5);
			}
			value = originalEffectiveHitProjectileEffectDesc.CostAttr.SwitchRatio;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			PassiveSkillData.CachedEffectiveHitProjectileEffectDescs[MainID].CostAttr.SwitchRatio = num;
			break;
		}
		case EModifyMethod.SealingSpellSkillDuration:
		{
			FUStSealingSpellSkillConfigDesc originalSealingSpellSkillConfigDesc = BGW_GameDB.GetOriginalSealingSpellSkillConfigDesc(MainID);
			if (!PassiveSkillData.CachedSealingSpellSkillConfigDescs.ContainsKey(MainID))
			{
				PassiveSkillData.CachedSealingSpellSkillConfigDescs.Add(MainID, BGU_DeepCopyUtil.Copy(originalSealingSpellSkillConfigDesc));
			}
			value = originalSealingSpellSkillConfigDesc.DurationMs;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			num = FMath.Max(num, 0f);
			PassiveSkillData.CachedSealingSpellSkillConfigDescs[MainID].DurationMs = (int)num;
			break;
		}
		case EModifyMethod.QiTianDaShengNormalModeDuration:
		{
			FUStTransQiTianDaShengConfigDesc originalTransQiTianDaShengConfigDesc = BGW_GameDB.GetOriginalTransQiTianDaShengConfigDesc(MainID);
			if (!PassiveSkillData.CachedTransQiTianDaShengConfigDescs.ContainsKey(MainID))
			{
				PassiveSkillData.CachedTransQiTianDaShengConfigDescs.Add(MainID, BGU_DeepCopyUtil.Copy(originalTransQiTianDaShengConfigDesc));
			}
			value = originalTransQiTianDaShengConfigDesc.Duration;
			num = ProcessValOp(text, Op, value, Val, bRecover);
			num = FMath.Max(num, 0f);
			PassiveSkillData.CachedTransQiTianDaShengConfigDescs[MainID].Duration = (int)num;
			break;
		}
		case (EModifyMethod)22:
		case (EModifyMethod)23:
		case (EModifyMethod)24:
		case (EModifyMethod)25:
		case (EModifyMethod)26:
		case (EModifyMethod)27:
		case (EModifyMethod)28:
		case (EModifyMethod)29:
		case EModifyMethod.StaminaDepletedLimitBase:
			break;
		}
	}

	private void CacheBuffModifyData(int MainID, string AggregatedStr, float NewVal)
	{
		if (!PassiveSkillData.CachedBuffModifyData.ContainsKey(MainID))
		{
			PassiveSkillData.CachedBuffModifyData.Add(MainID, new Dictionary<string, float>());
		}
		if (!PassiveSkillData.CachedBuffModifyData[MainID].ContainsKey(AggregatedStr))
		{
			PassiveSkillData.CachedBuffModifyData[MainID].Add(AggregatedStr, 0f);
		}
		PassiveSkillData.CachedBuffModifyData[MainID][AggregatedStr] = NewVal;
	}

	private float ProcessValOp(string AggregatedStr, EValOp Op, float OldVal, float Val, bool bRecover)
	{
		float result = 0f;
		switch (Op)
		{
		case EValOp.Add:
			if (bRecover)
			{
				PassiveSkillData.RemoveFromAddMods(AggregatedStr, Val);
			}
			else
			{
				PassiveSkillData.AddToAddMods(AggregatedStr, Val);
			}
			result = PassiveSkillData.GetFinalValue(AggregatedStr, OldVal);
			break;
		case EValOp.Mul:
		{
			float value = (10000f + Val) * 0.0001f;
			if (bRecover)
			{
				PassiveSkillData.RemoveFromMulMods(AggregatedStr, value);
			}
			else
			{
				PassiveSkillData.AddToMulMods(AggregatedStr, value);
			}
			result = PassiveSkillData.GetFinalValue(AggregatedStr, OldVal);
			break;
		}
		case EValOp.OverrideBase:
			if (bRecover)
			{
				PassiveSkillData.RemoveFromOverrideStack(AggregatedStr, Val);
			}
			else
			{
				PassiveSkillData.AddToOverrideStack(AggregatedStr, OldVal, Val);
			}
			result = PassiveSkillData.GetFinalValue(AggregatedStr, OldVal);
			break;
		}
		return result;
	}

	private void ModifyIronBodyBuffID(string AggregatedStr, int MainID, int SubID, int SubID2, EValOp Op, float Value, bool bRecover)
	{
		int actorResID = GetActorResID();
		RepeatedField<FUStIronBodyBuffTriggerInfo> startTriggerInfoList = BGW_GameDB.GetOriginalIronBodyConfigDesc(actorResID).StartTriggerInfoList;
		startTriggerInfoList = SubID switch
		{
			0 => PassiveSkillData.CachedIronBodyConfigDescs[actorResID].StartTriggerInfoList, 
			1 => PassiveSkillData.CachedIronBodyConfigDescs[actorResID].DefeatTriggerInfoList, 
			2 => PassiveSkillData.CachedIronBodyConfigDescs[actorResID].PreciseTriggerInfoList, 
			3 => PassiveSkillData.CachedIronBodyConfigDescs[actorResID].NotPreciseTriggerInfoList, 
			_ => null, 
		};
		if (startTriggerInfoList != null && SubID2 < startTriggerInfoList.Count)
		{
			float oldVal = startTriggerInfoList[SubID2].BuffID;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Value, bRecover);
			startTriggerInfoList[SubID2].BuffID = (int)num;
		}
	}

	private void ModifyImmobilizeEffect(string AggregatedStr, int MainID, int SubID, int SubID2, EValOp Op, float Value, bool bRecover)
	{
		FUStImmobilizeSkillConfigDesc immobilizeSkillConfigDesc = BGW_GameDB.GetImmobilizeSkillConfigDesc(MainID);
		FUStImmobilizeSkillConfigDesc cachedImmobilizeConfigDesc = CastImmobilizeData.GetCachedImmobilizeConfigDesc(MainID);
		if (SubID < 0)
		{
			return;
		}
		int num = SubID / 100;
		int num2 = SubID % 100 / 10;
		int num3 = SubID % 10;
		FSpellEffect fSpellEffect = null;
		FSpellEffect fSpellEffect2 = null;
		switch (num)
		{
		default:
			return;
		case 1:
			if (immobilizeSkillConfigDesc.BeginEffects.Count <= num2 || cachedImmobilizeConfigDesc.BeginEffects.Count <= num2)
			{
				return;
			}
			fSpellEffect = immobilizeSkillConfigDesc.BeginEffects[num2];
			fSpellEffect2 = cachedImmobilizeConfigDesc.BeginEffects[num2];
			break;
		case 2:
			if (immobilizeSkillConfigDesc.EndEffects.Count <= num2 || cachedImmobilizeConfigDesc.EndEffects.Count <= num2)
			{
				return;
			}
			fSpellEffect = immobilizeSkillConfigDesc.EndEffects[num2];
			fSpellEffect2 = cachedImmobilizeConfigDesc.EndEffects[num2];
			break;
		case 3:
			if (immobilizeSkillConfigDesc.BreakEffects.Count <= num2 || cachedImmobilizeConfigDesc.BreakEffects.Count <= num2)
			{
				return;
			}
			fSpellEffect = immobilizeSkillConfigDesc.BreakEffects[num2];
			fSpellEffect2 = cachedImmobilizeConfigDesc.BreakEffects[num2];
			break;
		case 4:
			if (immobilizeSkillConfigDesc.DeadEffects.Count <= num2 || cachedImmobilizeConfigDesc.DeadEffects.Count <= num2)
			{
				return;
			}
			fSpellEffect = immobilizeSkillConfigDesc.DeadEffects[num2];
			fSpellEffect2 = cachedImmobilizeConfigDesc.DeadEffects[num2];
			break;
		}
		if (fSpellEffect != null && fSpellEffect2 != null)
		{
			float num4 = 0f;
			float num5 = 0f;
			switch (num3)
			{
			case 1:
				num4 = (int)fSpellEffect.EffectType;
				num5 = ProcessValOp(AggregatedStr, Op, num4, Value, bRecover);
				fSpellEffect2.EffectType = (ESpellTriggerEffectType)num5;
				break;
			case 2:
				num4 = (int)fSpellEffect.TargetBaseType;
				num5 = ProcessValOp(AggregatedStr, Op, num4, Value, bRecover);
				fSpellEffect2.TargetBaseType = (ESpellTargetBaseType)num5;
				break;
			case 3:
				num4 = fSpellEffect.Value;
				num5 = ProcessValOp(AggregatedStr, Op, num4, Value, bRecover);
				fSpellEffect2.Value = (int)num5;
				break;
			}
		}
	}

	private void CalcAttrCopyModifyData(int SubID, int SubID2, EValOp Op, float Val, bool bRecover, FUStAttrCopyConfigDesc OriginalAttrCopyDesc, string AggregatedStr, FUStAttrCopyConfigDesc CachedAttrCopyDesc)
	{
		switch (SubID * 100 + SubID2)
		{
		case 1001:
		{
			float oldVal = OriginalAttrCopyDesc.HPBase;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.HPBase = (int)num;
			break;
		}
		case 1002:
		{
			float oldVal = OriginalAttrCopyDesc.HPRatio;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.HPRatio = (int)num;
			break;
		}
		case 1101:
		{
			float oldVal = OriginalAttrCopyDesc.MPBase;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.MPBase = (int)num;
			break;
		}
		case 1102:
		{
			float oldVal = OriginalAttrCopyDesc.MPRatio;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.MPRatio = (int)num;
			break;
		}
		case 1201:
		{
			float oldVal = OriginalAttrCopyDesc.AtkBase;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.AtkBase = (int)num;
			break;
		}
		case 1202:
		{
			float oldVal = OriginalAttrCopyDesc.AtkRatio;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.AtkRatio = (int)num;
			break;
		}
		case 1301:
		{
			float oldVal = OriginalAttrCopyDesc.DefBase;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.DefBase = (int)num;
			break;
		}
		case 1302:
		{
			float oldVal = OriginalAttrCopyDesc.DefRatio;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.DefRatio = (int)num;
			break;
		}
		case 2001:
		{
			float oldVal = OriginalAttrCopyDesc.DmgAdditionBase;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.DmgAdditionBase = (int)num;
			break;
		}
		case 2002:
		{
			float oldVal = OriginalAttrCopyDesc.DmgAdditionRatio;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.DmgAdditionRatio = (int)num;
			break;
		}
		case 2101:
		{
			float oldVal = OriginalAttrCopyDesc.DmgDefBase;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.DmgDefBase = (int)num;
			break;
		}
		case 2102:
		{
			float oldVal = OriginalAttrCopyDesc.DmgDefRatio;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.DmgDefRatio = (int)num;
			break;
		}
		case 2201:
		{
			float oldVal = OriginalAttrCopyDesc.CritRateBase;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.CritRateBase = (int)num;
			break;
		}
		case 2202:
		{
			float oldVal = OriginalAttrCopyDesc.CritRateRatio;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.CritRateRatio = (int)num;
			break;
		}
		case 2301:
		{
			float oldVal = OriginalAttrCopyDesc.CritMultiplierBase;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.CritMultiplierBase = (int)num;
			break;
		}
		case 2302:
		{
			float oldVal = OriginalAttrCopyDesc.CritMultiplierRatio;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.CritMultiplierRatio = (int)num;
			break;
		}
		case 3001:
		{
			float oldVal = OriginalAttrCopyDesc.FreezeDefBase;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.FreezeDefBase = (int)num;
			break;
		}
		case 3002:
		{
			float oldVal = OriginalAttrCopyDesc.FreezeDefRatio;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.FreezeDefRatio = (int)num;
			break;
		}
		case 3101:
		{
			float oldVal = OriginalAttrCopyDesc.BurnDefBase;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.BurnDefBase = (int)num;
			break;
		}
		case 3102:
		{
			float oldVal = OriginalAttrCopyDesc.BurnDefRatio;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.BurnDefRatio = (int)num;
			break;
		}
		case 3201:
		{
			float oldVal = OriginalAttrCopyDesc.PoisonDefBase;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.PoisonDefBase = (int)num;
			break;
		}
		case 3202:
		{
			float oldVal = OriginalAttrCopyDesc.PoisonDefRatio;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.PoisonDefRatio = (int)num;
			break;
		}
		case 3301:
		{
			float oldVal = OriginalAttrCopyDesc.ThunderDefBase;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.ThunderDefBase = (int)num;
			break;
		}
		case 3302:
		{
			float oldVal = OriginalAttrCopyDesc.ThunderDefRatio;
			float num = ProcessValOp(AggregatedStr, Op, oldVal, Val, bRecover);
			CachedAttrCopyDesc.ThunderDefRatio = (int)num;
			break;
		}
		}
	}
}
