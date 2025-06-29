using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "触发抛射物Reaction" })]
public class BUEffectTriggerProjectileReaction : BUEffectTemplate
{
	public BUEffectTriggerProjectileReaction()
	{
		EffectType = EBuffAndSkillEffectType.TriggerProjectileReaction;
	}

	[TemplateFunNote("触发抛射物Reaction")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_EventCollectionCS.Get(Target)?.Evt_HandleReactionWhenBeHitted_ByEffect.Invoke(Caster, EffectID);
		}
	}
}
