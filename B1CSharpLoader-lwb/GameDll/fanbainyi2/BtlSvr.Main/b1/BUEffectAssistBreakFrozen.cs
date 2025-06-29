using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[CantUseInMultiEffect]
[EffectTemplateTips(new string[] { "援助破冰", "通过SweepCheck向被援助者添加援助破冰效果" })]
public class BUEffectAssistBreakFrozen : BUEffectTemplate
{
	public BUEffectAssistBreakFrozen()
	{
		EffectType = EBuffAndSkillEffectType.AssistBreakFrozen;
	}

	[TemplateFunNote("skill触发时援助破冰效果")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target) && BUS_EventCollectionCS.Get(Target) != null)
		{
			BUS_EventCollectionCS.Get(Target).Evt_TriggerFrozenBreakByAssist.Invoke(in EffectInstReq);
		}
	}

	[TemplateFunNote("Buff触发时援助破冰效果")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target) && BUS_EventCollectionCS.Get(Target) != null)
		{
			BUS_EventCollectionCS.Get(Target).Evt_TriggerFrozenBreakByAssist.Invoke(in EffectInstReq);
		}
	}
}
