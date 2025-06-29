using System.Collections.Generic;
using System.Linq;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectRemoveBuff : BUEffectTemplate
{
	public BUEffectRemoveBuff()
	{
		EffectType = EBuffAndSkillEffectType.RemoveBuff;
	}

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
		if (list2.Count < list.Count || list.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			int num = list[i];
			bool withTriggerRemmoveEffect = true;
			if (num < 0)
			{
				withTriggerRemmoveEffect = false;
				num *= -1;
			}
			bUS_GSEventCollection.Evt_BuffRemove.Invoke(num, EBuffEffectTriggerType.None, (int)list2[i], withTriggerRemmoveEffect);
		}
	}

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
		if (buffDescRuntime.GetFloatEffectParamCount(EffectIdx) < intEffectParamCount || intEffectParamCount <= 0)
		{
			return;
		}
		for (int i = 0; i < intEffectParamCount; i++)
		{
			int num = buffDescRuntime.GetIntEffectParam(EffectIdx, i);
			bool withTriggerRemmoveEffect = true;
			if (num < 0)
			{
				withTriggerRemmoveEffect = false;
				num *= -1;
			}
			int layer = (int)buffDescRuntime.GetFloatEffectParam(EffectIdx, i);
			bUS_GSEventCollection.Evt_BuffRemove.Invoke(num, EBuffEffectTriggerType.None, layer, withTriggerRemmoveEffect);
		}
	}
}
