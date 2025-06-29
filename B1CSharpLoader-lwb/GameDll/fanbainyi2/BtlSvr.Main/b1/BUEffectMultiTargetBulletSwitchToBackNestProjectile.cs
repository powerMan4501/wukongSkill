using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "绣花针子弹转归巢【过期效果，无用】" })]
public class BUEffectMultiTargetBulletSwitchToBackNestProjectile : BUEffectTemplate
{
	public BUEffectMultiTargetBulletSwitchToBackNestProjectile()
	{
		EffectType = EBuffAndSkillEffectType.MultiTargetBulletSwitchToBackNestProjectile;
	}

	[TemplateFunNote("绣花针子弹转归巢【过期效果，无用】")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
	}

	[TemplateFunNote("绣花针子弹转归巢【过期效果，无用】")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
	}
}
