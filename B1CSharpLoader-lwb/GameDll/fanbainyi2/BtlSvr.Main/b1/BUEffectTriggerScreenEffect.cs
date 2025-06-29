using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectTriggerScreenEffect : BUEffectTemplate
{
	public BUEffectTriggerScreenEffect()
	{
		EffectType = EBuffAndSkillEffectType.TriggerScreenEffect;
	}

	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
	}
}
