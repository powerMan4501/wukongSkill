using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "消耗角色变身能量" })]
public class BUEffectCostPlayerTransEnergy : BUEffectTemplate
{
	public BUEffectCostPlayerTransEnergy()
	{
		EffectType = EBuffAndSkillEffectType.CostPlayerTransEnergy;
	}

	[TemplateFunNote("使用技能消耗角色变身能量")]
	[ParamInfoF(0, "消耗值")]
	[AffectCaster]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc != null && skillEffectDesc.EffectParamsFloat.Count >= 1)
		{
			float p = skillEffectDesc.EffectParamsFloat[0];
			APawn aPawn = Caster as APawn;
			if (aPawn != null)
			{
				BUS_EventCollectionCS.Get(aPawn)?.Evt_CostTransEnergyBySkill.Invoke(p);
			}
		}
	}
}
