using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "击坠筋斗云" })]
public class BUEffectBreakCloudMove : BUEffectTemplate
{
	public BUEffectBreakCloudMove()
	{
		EffectType = EBuffAndSkillEffectType.BreakCloudMove;
	}

	[TemplateFunNote("Skill击坠筋斗云")]
	[ParamInfoI(0, "击坠动画ID；可缺省，缺省时默认为0")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc != null)
		{
			int p = 0;
			if (skillEffectDesc.EffectParamsInt.Count > 0)
			{
				p = skillEffectDesc.EffectParamsInt[0];
			}
			BUS_EventCollectionCS.Get(Target).Evt_BreakCloudMove.Invoke(p);
		}
	}

	[ParamInfoI(0, "击坠动画ID；可缺省，缺省时默认为0")]
	[TemplateFunNote("Buff击坠筋斗云")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			int p = 0;
			if (buffDescRuntime.GetIntEffectParamCount(EffectIdx) > 0)
			{
				p = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
			}
			BUS_EventCollectionCS.Get(Target).Evt_BreakCloudMove.Invoke(p);
		}
	}
}
