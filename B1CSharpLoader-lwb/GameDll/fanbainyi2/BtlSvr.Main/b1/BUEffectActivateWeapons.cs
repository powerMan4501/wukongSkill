using System.Linq;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "单向触发效果，通过Buff激活武器时，Buff结束后不会重新禁用", "武器Index填-1时激活全部武器" })]
public class BUEffectActivateWeapons : BUEffectTemplate
{
	public BUEffectActivateWeapons()
	{
		EffectType = EBuffAndSkillEffectType.ActivateWeapons;
	}

	[AffectTarget]
	[ParamInfoI(2, "同上，int参数是武器Index数组")]
	[ParamInfoI(0, "武器Index1")]
	[TemplateFunNote("通过技能激活武器")]
	[ParamInfoI(1, "武器Index2")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster) && !b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null)
			{
				BUS_EventCollectionCS.Get(Target).Evt_ToggleWeaponsStatus_ByEffect.Invoke(skillEffectDesc.EffectParamsInt.ToList(), TriggerActivate: true, NeedOverride: true, EffectID, -1, Reset2Default: false);
			}
		}
	}

	[TemplateFunNote("通过Buff激活武器")]
	[ParamInfoI(0, "武器Index1")]
	[ParamInfoI(2, "同上，int参数是武器Index数组")]
	[AffectTarget]
	[ParamInfoI(1, "武器Index2")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				BUS_EventCollectionCS.Get(Target).Evt_ToggleWeaponsStatus_ByEffect.Invoke(buffDescRuntime.GetIntEffectParamList(EffectIdx), TriggerActivate: true, NeedOverride: true, BuffInst.BuffID, EffectIdx, Reset2Default: false);
			}
		}
	}
}
