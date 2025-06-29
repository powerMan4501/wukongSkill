using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "黑风大王沿着Spline逃跑用的，现在没法生效" })]
[AffectCaster]
public class BUEffectEscapeAfterDeath : BUEffectTemplate
{
	public BUEffectEscapeAfterDeath()
	{
		EffectType = EBuffAndSkillEffectType.EscapeAfterDeath;
	}

	[ParamInfoS(0, "Spline的ActorTag")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!(Target as ACharacter == null))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null)
			{
				BUS_EventCollectionCS.Get(Caster)?.Evt_EscapeAfterDeath.Invoke(skillEffectDesc.EffectParamsStr[0]);
			}
		}
	}
}
