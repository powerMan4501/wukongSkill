using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "对Caster所属的所有召唤物生效" })]
[AffectCaster]
public class BUEffectCallSummonUseSkill : BUEffectTemplate
{
	public BUEffectCallSummonUseSkill()
	{
		EffectType = EBuffAndSkillEffectType.CallSummonUseSkill;
	}

	[ParamInfoI(0, "使用的技能ID")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null)
			{
				BUS_EventCollectionCS.Get(Caster).Evt_SummonUseSkill.Invoke(skillEffectDesc.EffectParamsInt[0]);
			}
		}
	}
}
