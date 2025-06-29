using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[CantUseInMultiEffect]
[EffectTemplateTips(new string[] { "霸体护甲档位修正（已废弃，改为被动技能修改霸体护甲值）" })]
public class BUEffectSuperArmorLevelModify : BUEffectTemplate
{
	public BUEffectSuperArmorLevelModify()
	{
		EffectType = EBuffAndSkillEffectType.SuperArmorLevelModify;
	}

	[ParamInfoF(1, "间隔最大值")]
	[TemplateFunNote("Buff添加时修正霸体护甲挡位")]
	[ParamInfoS(0, "Original挡位名")]
	[ParamInfoS(1, "Target挡位名")]
	[ParamInfoF(0, "间隔最小值")]
	[ParamInfoF(2, "护甲偏移值")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null && BUS_EventCollectionCS.Get(Target) != null && buffDescRuntime.GetFloatEffectParamCount(EffectIdx) > 2)
		{
			buffDescRuntime.GetStringEffectParamCount(EffectIdx);
			_ = 1;
		}
	}

	[TemplateFunNote("移除Buff时恢复修正")]
	[ParamInfoS(0, "Original挡位名")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null && BUS_EventCollectionCS.Get(Target) != null)
		{
			buffDescRuntime.GetStringEffectParamCount(EffectIdx);
			_ = 0;
		}
	}
}
