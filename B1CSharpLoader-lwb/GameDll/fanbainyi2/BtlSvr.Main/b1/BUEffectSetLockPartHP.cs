using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "设置部位HP锁定与否" })]
[CantUseInMultiEffect]
public class BUEffectSetLockPartHP : BUEffectTemplate
{
	public BUEffectSetLockPartHP()
	{
		EffectType = EBuffAndSkillEffectType.SetLockPartHp;
	}

	[TemplateFunNote("触发SkillEffect时锁定指定部位的HP")]
	[ParamInfoI(0, "部位ID")]
	[ParamInfoI(1, "锁定与否")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster) && !b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null)
			{
				int skillEffectDescIntEffectParam = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 0);
				bool p = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 1) == 1;
				BUS_EventCollectionCS.Get(Target).Evt_SetLockPartHP.Invoke(skillEffectDescIntEffectParam, p);
			}
		}
	}

	[TemplateFunNote("添加Buff时锁定指定部位的HP")]
	[ParamInfoI(0, "部位ID")]
	[ParamInfoI(1, "锁定与否")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				bool p = buffDescRuntime.GetIntEffectParam(EffectIdx, 1) == 1;
				BUS_EventCollectionCS.Get(Target).Evt_SetLockPartHP.Invoke(intEffectParam, p);
			}
		}
	}

	[ParamInfoI(1, "锁定与否")]
	[ParamInfoI(0, "部位ID")]
	[TemplateFunNote("移除Buff时指定部位解除HP锁定状态")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				bool flag = buffDescRuntime.GetIntEffectParam(EffectIdx, 1) == 1;
				BUS_EventCollectionCS.Get(Target).Evt_SetLockPartHP.Invoke(intEffectParam, !flag);
			}
		}
	}
}
