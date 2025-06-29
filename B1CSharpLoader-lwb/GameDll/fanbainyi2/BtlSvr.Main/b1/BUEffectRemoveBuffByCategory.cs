using System.Collections.Generic;
using System.Linq;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "驱散目标某一Category的所有Buff" })]
public class BUEffectRemoveBuffByCategory : BUEffectTemplate
{
	public BUEffectRemoveBuffByCategory()
	{
		EffectType = EBuffAndSkillEffectType.RemoveBuffByCategory;
	}

	[ParamInfoI(5, "要驱散的Category类别6")]
	[AffectTarget]
	[ParamInfoF(3, "Category_4类型Buff驱散层数")]
	[ParamInfoF(4, "Category_5类型Buff驱散层数")]
	[ParamInfoF(5, "Category_6类型Buff驱散层数")]
	[TemplateFuncTips("参数数量任意, Int与Float参数数量要相同")]
	[ParamInfoF(2, "Category_3类型Buff驱散层数")]
	[ParamInfoI(3, "要驱散的Category类别4")]
	[ParamInfoI(2, "要驱散的Category类别3")]
	[ParamInfoI(1, "要驱散的Category类别2")]
	[ParamInfoI(0, "要驱散的Category类别1（Neutral = 0, Positive = 1, Negative = 2）")]
	[TemplateFunNote("通过技能驱散目标某一Category的所有Buff")]
	[ParamInfoF(1, "Category_2类型Buff驱散层数")]
	[ParamInfoI(4, "要驱散的Category类别5")]
	[ParamInfoF(0, "Category_1类型Buff驱散层数")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection == null)
		{
			return;
		}
		List<int> list = skillEffectDesc.EffectParamsInt.ToList();
		List<float> list2 = skillEffectDesc.EffectParamsFloat.ToList();
		if (list2.Count < list.Count)
		{
			return;
		}
		List<BuffInstData> list3 = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Target)?.GetAllBuffInstData();
		if (list3 == null)
		{
			return;
		}
		foreach (BuffInstData item in list3)
		{
			int num = item.BuffID;
			bool withTriggerRemmoveEffect = true;
			if (num < 0)
			{
				withTriggerRemmoveEffect = false;
				num *= -1;
			}
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i] == (int)b1.BUS_BuffComp.GetBuffCategory(num))
				{
					bUS_GSEventCollection.Evt_BuffRemove.Invoke(num, EBuffEffectTriggerType.None, (int)list2[i], withTriggerRemmoveEffect);
				}
			}
		}
	}

	[ParamInfoI(4, "要驱散的Category类别5")]
	[TemplateFunNote("通过Buff驱散目标某一Category的所有Buff")]
	[TemplateFuncTips("参数数量任意, Int与Float参数数量要相同")]
	[AffectTarget]
	[ParamInfoF(5, "Category_6类型Buff驱散层数")]
	[ParamInfoF(4, "Category_5类型Buff驱散层数")]
	[ParamInfoF(2, "Category_3类型Buff驱散层数")]
	[ParamInfoF(1, "Category_2类型Buff驱散层数")]
	[ParamInfoF(3, "Category_4类型Buff驱散层数")]
	[ParamInfoI(5, "要驱散的Category类别6")]
	[ParamInfoI(3, "要驱散的Category类别4")]
	[ParamInfoI(2, "要驱散的Category类别3")]
	[ParamInfoI(1, "要驱散的Category类别2")]
	[ParamInfoI(0, "要驱散的Category类别1（Neutral = 0, Positive = 1, Negative = 2）")]
	[ParamInfoF(0, "Category_1类型Buff驱散层数")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection == null)
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		if (buffDescRuntime.GetFloatEffectParamCount(EffectIdx) < intEffectParamCount)
		{
			return;
		}
		List<BuffInstData> list = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Target)?.GetAllBuffInstData();
		if (list == null)
		{
			return;
		}
		foreach (BuffInstData item in list)
		{
			int num = item.BuffID;
			bool withTriggerRemmoveEffect = true;
			if (num < 0)
			{
				withTriggerRemmoveEffect = false;
				num *= -1;
			}
			for (int i = 0; i < intEffectParamCount; i++)
			{
				if (buffDescRuntime.GetIntEffectParam(EffectIdx, i) == (int)b1.BUS_BuffComp.GetBuffCategory(num))
				{
					bUS_GSEventCollection.Evt_BuffRemove.Invoke(num, EBuffEffectTriggerType.None, (int)buffDescRuntime.GetFloatEffectParam(EffectIdx, i), withTriggerRemmoveEffect);
				}
			}
		}
	}
}
