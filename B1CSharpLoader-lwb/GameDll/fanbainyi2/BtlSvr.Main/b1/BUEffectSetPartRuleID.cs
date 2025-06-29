using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "如果是通过SkillEffect的形式直接触发，会直接替换掉默认值", "如果通过Buff的形式直接触发，会记录之前的默认值，Buff结束时恢复成默认值" })]
public class BUEffectSetPartRuleID : BUEffectTemplate
{
	public BUEffectSetPartRuleID()
	{
		EffectType = EBuffAndSkillEffectType.SetPartRuleId;
	}

	[AffectTarget]
	[TemplateFunNote("通过技能设置部位规则ID")]
	[ParamInfoI(0, "部位规则ID")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster) && !b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null)
			{
				int skillEffectDescIntEffectParam = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 0);
				BUS_EventCollectionCS.Get(Target).Evt_SetPartRuleID.Invoke(skillEffectDescIntEffectParam, P2: true);
			}
		}
	}

	[TemplateFunNote("通过Buff设置部位规则ID")]
	[ParamInfoI(0, "部位规则ID")]
	[AffectTarget]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				BUS_EventCollectionCS.Get(Target).Evt_SetPartRuleID.Invoke(intEffectParam, P2: false);
			}
		}
	}

	[TemplateFunNote("Buff结束时恢复之前的部位规则ID")]
	[ParamInfoI(0, "部位规则ID")]
	[AffectTarget]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_EventCollectionCS.Get(Target).Evt_ResetPartRuleID.Invoke();
		}
	}
}
