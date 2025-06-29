using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectResetBlockInfo : BUEffectTemplate
{
	public BUEffectResetBlockInfo()
	{
		EffectType = EBuffAndSkillEffectType.ResetBlockInfo;
	}

	[TemplateFunNote("通过技能重置格挡信息")]
	[AffectTarget]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster) && !b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_EventCollectionCS.Get(Target).Evt_ResetBlockInfo.Invoke();
		}
	}

	[TemplateFunNote("通过Buff重置格挡信息")]
	[AffectTarget]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_EventCollectionCS.Get(Target).Evt_ResetBlockInfo.Invoke();
		}
	}
}
