using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "增加棍势", "因为效果逻辑不需要考虑RemoveBuff的情况" })]
[CantUseInMultiEffect]
public class BUEffectIncreasePEValue : BUEffectTemplate
{
	public BUEffectIncreasePEValue()
	{
		EffectType = EBuffAndSkillEffectType.IncreasePevalue;
	}

	[TemplateFunNote("Skill触发时时增加棍势")]
	[ParamInfoI(0, "增加的原因")]
	[ParamInfoF(0, "增加棍势值")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Target);
			if (skillEffectDesc != null)
			{
				float increaseValue = ((skillEffectDesc.EffectParamsFloat.Count > 0) ? skillEffectDesc.EffectParamsFloat[0] : 0f);
				int reason = ((skillEffectDesc.EffectParamsInt.Count > 0) ? skillEffectDesc.EffectParamsInt[0] : 0);
				BUS_EventCollectionCS.Get(Target).Evt_IncreasePEValue.Invoke(increaseValue, (EPotentialEnergyIncreaseReason)reason);
			}
		}
	}

	[TemplateFunNote("Buff触发时时增加棍势")]
	[ParamInfoI(0, "增加的原因")]
	[ParamInfoF(0, "增加棍势值")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				float increaseValue = ((buffDescRuntime.GetFloatEffectParamCount(EffectIdx) > 0) ? buffDescRuntime.GetFloatEffectParam(EffectIdx, 0) : 0f);
				int reason = ((buffDescRuntime.GetIntEffectParamCount(EffectIdx) > 0) ? buffDescRuntime.GetIntEffectParam(EffectIdx, 0) : 0);
				BUS_EventCollectionCS.Get(Target).Evt_IncreasePEValue.Invoke(increaseValue, (EPotentialEnergyIncreaseReason)reason);
			}
		}
	}
}
