using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "之所以没用AddAttr而是单独开一个Effect，是为了统一不同类型的属性值（AttrFloat/AttrInt），都可以通过一个属性消耗模板消耗", "消耗值 = 消耗绝对值 + 消耗比例值 * 属性最大值" })]
public class BUEffectCostAttr : BUEffectTemplate
{
	public BUEffectCostAttr()
	{
		EffectType = EBuffAndSkillEffectType.CostAttr;
	}

	[TemplateFunNote("通过技能消耗释放者属性")]
	[ParamInfoI(0, "AttrCostType(属性消耗类型)")]
	[ParamInfoF(0, "消耗绝对值")]
	[ParamInfoF(1, "消耗比例值")]
	[AffectCaster]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null)
			{
				EAttrCostType attrCostType = (EAttrCostType)b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 0);
				float skillEffectDescFloatEffectParam = b1.EffectTemplateUtil.GetSkillEffectDescFloatEffectParam(skillEffectDesc, 0);
				float skillEffectDescFloatEffectParam2 = b1.EffectTemplateUtil.GetSkillEffectDescFloatEffectParam(skillEffectDesc, 1);
				IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(Caster);
				BGW_EffectTemplateList.Get(Caster).GetAttrCostTemplate(attrCostType)?.DoCostAttrValue(Caster, readOnlyData, skillEffectDescFloatEffectParam, skillEffectDescFloatEffectParam2);
			}
		}
	}

	[ParamInfoF(0, "消耗绝对值")]
	[ParamInfoI(0, "AttrCostType(属性消耗类型)")]
	[AffectCaster]
	[TemplateFunNote("通过Buff消耗释放者属性")]
	[ParamInfoF(1, "消耗比例值")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		AActor aActor = EntitySharedRefFuncLib.Actor(BuffInst.CasterRef);
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(aActor))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				EAttrCostType attrCostType = (EAttrCostType)buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				float floatEffectParam = buffDescRuntime.GetFloatEffectParam(EffectIdx, 0);
				float floatEffectParam2 = buffDescRuntime.GetFloatEffectParam(EffectIdx, 1);
				IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(aActor);
				BGW_EffectTemplateList.Get(aActor).GetAttrCostTemplate(attrCostType)?.DoCostAttrValue(aActor, readOnlyData, floatEffectParam, floatEffectParam2);
			}
		}
	}
}
