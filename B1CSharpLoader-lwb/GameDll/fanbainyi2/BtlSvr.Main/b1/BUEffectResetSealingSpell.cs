using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "触发重置禁字符状态" })]
public class BUEffectResetSealingSpell : BUEffectTemplate
{
	public BUEffectResetSealingSpell()
	{
		EffectType = EBuffAndSkillEffectType.ResetSealingSpell;
	}

	[AffectTarget]
	[TemplateFunNote("重置禁字符状态")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_EventCollectionCS.Get(Target)?.Evt_ResetSealingSpell.Invoke();
		}
	}

	[AffectTarget]
	[TemplateFunNote("重置禁字符状态")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_EventCollectionCS.Get(Target)?.Evt_ResetSealingSpell.Invoke();
		}
	}
}
