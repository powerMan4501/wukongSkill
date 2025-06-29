using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[AffectTarget]
[EffectTemplateTips(new string[] { "切换行为树" })]
public class BUEffectSwitchBehaviourTree : BUEffectTemplate
{
	public BUEffectSwitchBehaviourTree()
	{
		EffectType = EBuffAndSkillEffectType.SwitchBehaviorTree;
	}

	[TemplateFunNote("通过技能效果切换行为树")]
	[ParamInfoS(0, "要切换的行为树路径")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null && skillEffectDesc.EffectParamsStr.Count >= 1)
			{
				string p = skillEffectDesc.EffectParamsStr[0];
				BUS_EventCollectionCS.Get(Target).Evt_SwitchBehaviourTree.Invoke(P1: true, p);
			}
		}
	}

	[TemplateFunNote("添加Buff时切换行为树")]
	[ParamInfoS(0, "要切换的行为树路径")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
				BUS_EventCollectionCS.Get(Target).Evt_SwitchBehaviourTree.Invoke(P1: true, stringEffectParam);
			}
		}
	}

	[TemplateFunNote("移除Buff时恢复默认的行为树")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target) && b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst) != null)
		{
			BUS_EventCollectionCS.Get(Target).Evt_SwitchBehaviourTree.Invoke(P1: false, "");
		}
	}
}
