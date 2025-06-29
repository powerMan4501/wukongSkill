using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "切换棍势配置(已废弃，请使用被动技能来管理棍势配置)" })]
[CantUseInMultiEffect]
public class BUEffectSwitchPEConfig : BUEffectTemplate
{
	public BUEffectSwitchPEConfig()
	{
		EffectType = EBuffAndSkillEffectType.SwitchPeconfig;
	}

	[ParamInfoS(0, "DA_PEConfig的路径")]
	[TemplateFunNote("Buff触发时切换棍势配置(已废弃，请使用被动技能来管理棍势配置)")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (BUS_EventCollectionCS.Get(Target) != null)
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				buffDescRuntime.GetStringEffectParamCount(EffectIdx);
				_ = 0;
			}
		}
	}

	[TemplateFunNote("Buff移除时通过BuffID为索引查找，转化为之前的配置(已废弃，请使用被动技能来管理棍势配置)")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		_ = BUS_EventCollectionCS.Get(Target) != null;
	}
}
