using b1.Plugins.AkAudio;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "设置BgmState" })]
public class BUEffectSetBGMState : BUEffectTemplate
{
	public BUEffectSetBGMState()
	{
		EffectType = EBuffAndSkillEffectType.SetBgmState;
	}

	[TemplateFuncTips("State是全局设置，使用前请咨询音频同事。")]
	[TemplateFunNote("使用技能设置BgmState")]
	[ParamInfoS(1, "State名")]
	[AffectCaster]
	[ParamInfoS(0, "StateGroup名")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster) && BUS_EventCollectionCS.Get(Caster) != null)
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null && skillEffectDesc.EffectParamsStr.Count > 1)
			{
				UAkGameplayStatics.SetState(null, new FName(skillEffectDesc.EffectParamsStr[0]), new FName(skillEffectDesc.EffectParamsStr[1]));
			}
		}
	}

	[TemplateFunNote("使用Buff设置BgmState")]
	[ParamInfoS(0, "StateGroup名")]
	[ParamInfoS(1, "State名")]
	[AffectTarget]
	[TemplateFuncTips("State是全局设置，使用前请咨询音频同事。")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target) && BUS_EventCollectionCS.Get(Target) != null)
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null && buffDescRuntime.GetStringEffectParamCount(EffectIdx) > 1)
			{
				UAkGameplayStatics.SetState(null, new FName(buffDescRuntime.GetStringEffectParam(EffectIdx, 0)), new FName(buffDescRuntime.GetStringEffectParam(EffectIdx, 1)));
			}
		}
	}
}
