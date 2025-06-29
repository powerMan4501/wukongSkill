using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "测试用-单独设置主角速率（临时测试用）" })]
public class BUEffectSetGmcustomTimeDilation : BUEffectTemplate
{
	public BUEffectSetGmcustomTimeDilation()
	{
		EffectType = EBuffAndSkillEffectType.SetGmcustomTimeDilation;
	}

	[TemplateFunNote("单独设置主角速率")]
	[ParamInfoF(0, "主角速率")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			float floatEffectParam = buffDescRuntime.GetFloatEffectParam(EffectIdx, 0);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetGMCustomTimeDilation.Invoke(floatEffectParam);
			}
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target) && b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst) != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetGMCustomTimeDilation.Invoke(1f);
			}
		}
	}
}
