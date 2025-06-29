using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "减少救命毫毛CD" })]
public class BUEffectDecreaseLifeSavingHairCoolDown : BUEffectTemplate
{
	public BUEffectDecreaseLifeSavingHairCoolDown()
	{
		EffectType = EBuffAndSkillEffectType.DecreaseLifeSavingHairCoolDown;
	}

	[TemplateFunNote("减少救命毫毛CD 通过skill")]
	[ParamInfoF(0, "CD减少值")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null && skillEffectDesc.EffectParamsFloat.Count > 0)
			{
				float p = skillEffectDesc.EffectParamsFloat[0];
				BUS_EventCollectionCS.Get(Target).Evt_DecreaseLifeSavingHairCoolDown.Invoke(p);
			}
		}
	}

	[TemplateFunNote("减少救命毫毛CD 通过buff")]
	[ParamInfoF(0, "CD减少值")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				float floatEffectParam = buffDescRuntime.GetFloatEffectParam(EffectIdx, 0);
				BUS_EventCollectionCS.Get(Target).Evt_DecreaseLifeSavingHairCoolDown.Invoke(floatEffectParam);
			}
		}
	}
}
