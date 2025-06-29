using b1.EventDelDefine;
using b1.Prediction;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;

namespace b1;

internal class BUS_TriggerEffectComp : UActorCompBaseCS
{
	private BUC_BuffData BuffData;

	public override void OnAttach()
	{
		BuffData = RequireWritableData<BUC_BuffData>();
		base.BUSEventCollection.Evt_TriggerSkillEffectBySkill.Predict += new GSDel_TriggerSkillEffectBySkill_IPK_Del.Del_Predict(OnTriggerSkillEffectBySkill_Predict);
		base.BUSEventCollection.Evt_TriggerSkillEffectBySkill.Cue += new GSDel_TriggerSkillEffectBySkill_IPK_Del.Del_Predict(OnTriggerSkillEffectBySkill_Cue);
		base.BUSEventCollection.Evt_TriggerSkillEffectBySkill_WithoutRPC += new Del_TriggerSkillEffectBySkill_WithoutRPC(OnTriggerSkillEffectBySkill_WithoutRPC);
		base.BUSEventCollection.Evt_TriggerSkillEffectByBuff += new Del_TriggerSkillEffectByBuff(OnTriggerSkillEffectByBuff);
	}

	private void OnTriggerSkillEffectBySkill_Predict(int EffectID, AActor Owner, AActor Target, in FEffectInstReq EffectInstReq, GSPredictionKey PredictionKey)
	{
		OnTriggerSkillEffectBySkill_Cue(EffectID, Owner, Target, in EffectInstReq, null);
	}

	private void OnTriggerSkillEffectBySkill_Cue(int EffectID, AActor Owner, AActor Target, in FEffectInstReq EffectInstReq, GSPredictionKey PredictionKey)
	{
		if (PredictionKey == null)
		{
			TriggerSkillEffectBySkill_Impl(EffectID, Owner, Target, in EffectInstReq);
		}
	}

	private void OnTriggerSkillEffectBySkill_WithoutRPC(int EffectID, AActor Owner, AActor Target, in FEffectInstReq EffectInstReq)
	{
		TriggerSkillEffectBySkill_Impl(EffectID, Owner, Target, in EffectInstReq);
	}

	private void TriggerSkillEffectBySkill_Impl(int EffectID, AActor Owner, AActor Target, in FEffectInstReq EffectInstReq)
	{
		AActor owner = GetOwner();
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, owner);
		if (!CheckActorIsBeginPlay(Target))
		{
			return;
		}
		BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Target);
		if (readOnlyData != null)
		{
			readOnlyData.GetAllFilterSkillEffectID(out var OutFilterIDs);
			if (OutFilterIDs.Contains(EffectID))
			{
				return;
			}
		}
		if (skillEffectDesc != null)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(owner, EBattleInfoType.SkillEffect, $"<character>{Owner.GetName()}</><action>对</><bechosed>{Target.GetName()}</><action>使用技能类型</><effect>{skillEffectDesc.EffectType.ToString()}</><action>的技能效果</><effectnum>{EffectID}</>");
			}
			if (BGW_EffectTemplateList.Get(owner).EffectTemplatesCS.TryGetValue(skillEffectDesc.EffectType, out var value))
			{
				value.ApplyBySkill(EffectID, Owner, Target, in EffectInstReq);
			}
		}
	}

	private void OnTriggerSkillEffectByBuff(int BuffID, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!(EffectInstReq.Attacker is IECSWorldObj))
		{
			return;
		}
		AActor owner = GetOwner();
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EffectInstReq.Attacker);
		BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(BuffID, readOnlyData);
		if (BGW_LogUtil.LogIfNull(buffDescRuntime, "GetBuffDesc Failed! BuffID:" + BuffID))
		{
			return;
		}
		EBuffAndSkillEffectType effectType = buffDescRuntime.GetEffectType(EffectIdx);
		BGW_EffectTemplateList.Get(owner).EffectTemplatesCS.TryGetValue(effectType, out var value);
		if (value != null && this.BuffData.GetBuffInstData(BuffID, out var BuffData))
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(owner, EBattleInfoType.SkillEffect, $"<character>{owner.GetName()}</><action>通过Buff</><effectnum>{BuffID}</><action>对</><bechosed>{Target.GetName()}</><action>使用技能类型</><effect>{effectType.ToString()}</><action>的技能效果</>", bIsPeriodical ? 1 : 0);
			}
			value.ApplyByBuff(BuffData, Target, EffectIdx, in EffectInstReq, bIsPeriodical);
		}
	}

	private bool CheckActorIsBeginPlay(AActor Target)
	{
		BGUCharacterCS bGUCharacterCS = Target as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_BGUDataComp bUS_BGUDataComp = bGUCharacterCS.DataComp as BUS_BGUDataComp;
			if (bUS_BGUDataComp != null && !bUS_BGUDataComp.IsActorHasBeginPlay())
			{
				return false;
			}
		}
		return true;
	}
}
