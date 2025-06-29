using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[CantUseInMultiEffect]
[EffectTemplateTips(new string[] { "筛选SkillEffect", "定风珠需求同期，根据EffectID筛选", "可屏蔽的数量为IntParam的上限" })]
public class BUEffectFilterSkillEffect : BUEffectTemplate
{
	public BUEffectFilterSkillEffect()
	{
		EffectType = EBuffAndSkillEffectType.FilterSkillEffect;
	}

	[TemplateFunNote("添加Buff时新增EffectID黑名单")]
	[ParamInfoI(0, "第一个Filter的EffectID")]
	[ParamInfoI(1, "第二个Filter的EffectID")]
	[ParamInfoI(2, "以此类推")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null && bUS_GSEventCollection != null)
		{
			int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
			for (int i = 0; i < intEffectParamCount; i++)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, i);
				bUS_GSEventCollection.Evt_FilterSkillEffectAdd.Invoke(BuffInst.BuffID, intEffectParam);
			}
		}
	}

	[ParamInfoI(1, "第二个Filter的EffectID")]
	[TemplateFunNote("移除Buff时清理EffectID黑名单")]
	[ParamInfoI(0, "第一个Filter的EffectID")]
	[ParamInfoI(2, "以此类推")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (buffDescRuntime == null || !(bUS_GSEventCollection != null))
		{
			return;
		}
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		if (intEffectParamCount > 0)
		{
			for (int i = 0; i < intEffectParamCount; i++)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, i);
				bUS_GSEventCollection.Evt_FilterSkillEffectRemove.Invoke(BuffInst.BuffID, intEffectParam);
			}
		}
	}
}
