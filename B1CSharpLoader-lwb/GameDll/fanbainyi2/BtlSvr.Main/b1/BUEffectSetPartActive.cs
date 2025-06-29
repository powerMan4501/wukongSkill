using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "如果通过Buff设置部位是否激活，在Buff移除时，会把部位激活状态设置为本次Buff效果参数的取反状态。例如通过Buff把部位激活状态设为false，那在这个Buff结束时，一定会把激活状态设为true，而不是记录Buff前的状态" })]
public class BUEffectSetPartActive : BUEffectTemplate
{
	public BUEffectSetPartActive()
	{
		EffectType = EBuffAndSkillEffectType.SetPartActive;
	}

	[TemplateFunNote("通过技能设置部位是否激活")]
	[ParamInfoI(0, "部位ID")]
	[ParamInfoI(1, "是否激活（1激活，0不激活）")]
	[AffectTarget]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster) && !b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null)
			{
				int skillEffectDescIntEffectParam = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 0);
				bool p = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 1) == 1;
				BUS_EventCollectionCS.Get(Target).Evt_SetPartActive.Invoke(skillEffectDescIntEffectParam, p);
			}
		}
	}

	[ParamInfoI(1, "是否激活（1激活，0不激活）")]
	[AffectTarget]
	[TemplateFunNote("通过Buff设置部位是否激活")]
	[ParamInfoI(0, "部位ID")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				bool p = buffDescRuntime.GetIntEffectParam(EffectIdx, 1) == 1;
				BUS_EventCollectionCS.Get(Target).Evt_SetPartActive.Invoke(intEffectParam, p);
			}
		}
	}

	[AffectTarget]
	[TemplateFunNote("Buff结束时重置部位是否激活")]
	[ParamInfoI(1, "是否激活（1激活，0不激活）")]
	[ParamInfoI(0, "部位ID")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				bool flag = buffDescRuntime.GetIntEffectParam(EffectIdx, 1) == 1;
				BUS_EventCollectionCS.Get(Target).Evt_SetPartActive.Invoke(intEffectParam, !flag);
			}
		}
	}
}
