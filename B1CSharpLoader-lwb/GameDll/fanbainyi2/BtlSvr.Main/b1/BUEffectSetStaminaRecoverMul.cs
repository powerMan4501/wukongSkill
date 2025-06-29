using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "体力恢复速度 = 默认体力恢复速度 * 体力恢复倍率" })]
public class BUEffectSetStaminaRecoverMul : BUEffectTemplate
{
	public BUEffectSetStaminaRecoverMul()
	{
		EffectType = EBuffAndSkillEffectType.SetStaminaRecoverMul;
	}

	[ParamInfoF(0, "体力恢复倍率")]
	[AffectTarget]
	[TemplateFunNote("通过Buff修改体力恢复倍率")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				float floatEffectParam = buffDescRuntime.GetFloatEffectParam(EffectIdx, 0);
				BUS_EventCollectionCS.Get(Target).Evt_OnSetStaminaRecoverMul.Invoke(floatEffectParam);
			}
		}
	}

	[TemplateFunNote("移除Buff时重置体力恢复速率")]
	[AffectTarget]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_EventCollectionCS.Get(Target).Evt_OnResetStaminaRecoverMul.Invoke();
		}
	}
}
