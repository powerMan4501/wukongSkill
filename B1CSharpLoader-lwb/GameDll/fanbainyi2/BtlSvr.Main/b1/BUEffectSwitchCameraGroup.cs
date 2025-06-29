using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "切换镜头组", "注意：此效果仅限特殊情况下使用，切换镜头组与Volume冲突且需要手动还原，慎用！！！" })]
[CantUseInMultiEffect]
public class BUEffectSwitchCameraGroup : BUEffectTemplate
{
	public BUEffectSwitchCameraGroup()
	{
		EffectType = EBuffAndSkillEffectType.SwitchCameraGroup;
	}

	[TemplateFunNote("Buff触发时切换镜头组")]
	[ParamInfoI(0, "镜头组ID")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime.GetEffectsCount() > EffectIdx && buffDescRuntime.GetIntEffectParamCount(EffectIdx) >= 1)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				BPS_EventCollectionCS.GetLocal(Target)?.Evt_EnterCameraGroup.Invoke(intEffectParam);
			}
		}
	}

	[TemplateFunNote("Buff移除时切换镜头组")]
	[ParamInfoI(0, "镜头组ID")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime.GetEffectsCount() > EffectIdx && buffDescRuntime.GetIntEffectParamCount(EffectIdx) >= 1)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				BPS_EventCollectionCS.GetLocal(Target)?.Evt_ExitCameraGroup.Invoke(intEffectParam);
			}
		}
	}
}
