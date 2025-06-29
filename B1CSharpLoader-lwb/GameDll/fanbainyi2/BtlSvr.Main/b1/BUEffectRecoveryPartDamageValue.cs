using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectRecoveryPartDamageValue : BUEffectTemplate
{
	public BUEffectRecoveryPartDamageValue()
	{
		EffectType = EBuffAndSkillEffectType.RecoveryPartDamageValue;
	}

	[TemplateFunNote("通过技能触发恢复部位破坏值")]
	[AffectTarget]
	[ParamInfoI(0, "部位ID")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Target);
			if (skillEffectDesc != null && skillEffectDesc.EffectParamsInt.Count > 0)
			{
				int skillEffectDescIntEffectParam = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 0);
				BUS_EventCollectionCS.Get(Target).Evt_RecoveryPartDamageValue.Invoke(skillEffectDescIntEffectParam);
			}
		}
	}
}
