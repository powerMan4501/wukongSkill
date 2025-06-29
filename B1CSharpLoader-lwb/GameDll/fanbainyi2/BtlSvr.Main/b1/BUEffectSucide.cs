using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectSucide : BUEffectTemplate
{
	public BUEffectSucide()
	{
		EffectType = EBuffAndSkillEffectType.Sucide;
	}

	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target) && BGW_GameDB.GetSkillEffectDesc(EffectID, Caster) != null)
		{
			BUS_EventCollectionCS.Get(Target).Evt_UnitDead.Invoke(Target, EDeadReason.Suicide);
		}
	}

	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target) && b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst) != null)
		{
			BUS_EventCollectionCS.Get(Target).Evt_UnitDead.Invoke(Target, EDeadReason.Suicide);
		}
	}
}
