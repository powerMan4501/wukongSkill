using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "根据分身ID销毁自身召唤物" })]
public class BUEffectDestroySummonsByID : BUEffectTemplate
{
	public BUEffectDestroySummonsByID()
	{
		EffectType = EBuffAndSkillEffectType.DestroySummonsById;
	}

	[ParamInfoI(6, "同上，选填")]
	[TemplateFuncTips("Int类型参数数量任意，销毁所有Int参数里的分身ID的召唤物")]
	[ParamInfoI(5, "同上，选填")]
	[AffectTarget]
	[ParamInfoI(4, "同上，选填")]
	[ParamInfoI(3, "同上，选填")]
	[ParamInfoI(2, "同上，选填")]
	[ParamInfoI(1, "同上，选填")]
	[ParamInfoI(0, "分身ID")]
	[TemplateFunNote("通过技能，根据分身ID销毁自身召唤物")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Target);
		if (skillEffectDesc == null)
		{
			return;
		}
		foreach (int item in skillEffectDesc.EffectParamsInt)
		{
			bUS_GSEventCollection.Evt_DestroySummonsByID.Invoke(item);
		}
	}

	[TemplateFuncTips("Int类型参数数量任意，销毁所有Int参数里的分身ID的召唤物")]
	[AffectTarget]
	[ParamInfoI(6, "同上，选填")]
	[ParamInfoI(4, "同上，选填")]
	[ParamInfoI(3, "同上，选填")]
	[ParamInfoI(5, "同上，选填")]
	[ParamInfoI(1, "同上，选填")]
	[ParamInfoI(0, "分身ID")]
	[TemplateFunNote("通过Buff，根据分身ID销毁自身召唤物")]
	[ParamInfoI(2, "同上，选填")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null && buffDescRuntime.GetEffectsCount() > EffectIdx)
		{
			int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
			for (int i = 0; i < intEffectParamCount; i++)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, i);
				bUS_GSEventCollection.Evt_DestroySummonsByID.Invoke(intEffectParam);
			}
		}
	}
}
