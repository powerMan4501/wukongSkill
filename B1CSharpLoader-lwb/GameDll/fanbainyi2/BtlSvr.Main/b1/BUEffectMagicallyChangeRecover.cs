using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "幻化变身还原" })]
public class BUEffectMagicallyChangeRecover : BUEffectTemplate
{
	public BUEffectMagicallyChangeRecover()
	{
		EffectType = EBuffAndSkillEffectType.MagicallyChangeRecover;
	}

	[TemplateFunNote("幻化变身还原 通过skill")]
	[ParamInfoI(0, "幻化变身还原技能ID")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null && skillEffectDesc.EffectParamsInt.Count > 0)
			{
				int p = skillEffectDesc.EffectParamsInt[0];
				BUS_EventCollectionCS.Get(Target).Evt_OnMagicallyChangeRecover.Invoke(p);
			}
		}
	}

	[TemplateFunNote("幻化变身还原 通过buff")]
	[ParamInfoI(0, "幻化变身还原技能ID")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				BUS_EventCollectionCS.Get(Target).Evt_OnMagicallyChangeRecover.Invoke(intEffectParam);
			}
		}
	}
}
