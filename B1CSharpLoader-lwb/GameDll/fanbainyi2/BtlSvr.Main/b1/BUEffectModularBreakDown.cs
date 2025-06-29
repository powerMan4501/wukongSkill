using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[AffectCaster]
public class BUEffectModularBreakDown : BUEffectTemplate
{
	public BUEffectModularBreakDown()
	{
		EffectType = EBuffAndSkillEffectType.ModularBreakDown;
	}

	[AffectCaster]
	[ParamInfoF(0, "破坏力度")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		float breakStrength = ((skillEffectDesc.EffectParamsFloat.Count > 0) ? skillEffectDesc.EffectParamsFloat[0] : 0f);
		BUS_EventCollectionCS.Get(Caster).Evt_ModularBreakDown.Invoke(breakStrength);
	}
}
