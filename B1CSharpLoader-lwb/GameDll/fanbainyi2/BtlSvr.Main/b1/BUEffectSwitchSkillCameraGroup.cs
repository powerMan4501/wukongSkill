using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "切换技能镜头组，注意是技能镜头组，优先级比普通的镜头组高" })]
[CantUseInMultiEffect]
public class BUEffectSwitchSkillCameraGroup : BUEffectTemplate
{
	public BUEffectSwitchSkillCameraGroup()
	{
		EffectType = EBuffAndSkillEffectType.SwitchSkillCameraGroup;
	}

	[ParamInfoI(0, "镜头组ID")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime.GetEffectsCount() > EffectIdx && buffDescRuntime.GetIntEffectParamCount(EffectIdx) >= 1)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				BPS_EventCollectionCS.GetLocal(Target)?.Evt_OnEnterSkillCameraGroup.Invoke(intEffectParam, -1);
			}
		}
	}

	[ParamInfoI(0, "镜头组ID")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime.GetEffectsCount() > EffectIdx && buffDescRuntime.GetIntEffectParamCount(EffectIdx) >= 1)
		{
			int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
			BPS_EventCollectionCS.GetLocal(Target)?.Evt_OnExitSkillCameraGroup.Invoke(intEffectParam, -1);
		}
	}
}
