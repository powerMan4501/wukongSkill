using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "异常属性累积值和异常状态都会移除" })]
public class BUEffectClearAbnormalState : BUEffectTemplate
{
	public BUEffectClearAbnormalState()
	{
		EffectType = EBuffAndSkillEffectType.ClearAbnormalState;
	}

	[ParamInfoI(0, "异常属性类型（1冰，2火，3毒，4雷，5阴，6阳）")]
	[TemplateFunNote("通过技能移除异常状态")]
	[ParamInfoI(1, "同上，int参数为异常属性类型数组（后面位置数组元素也一样）")]
	[AffectTarget]
	[TemplateFuncTips("Int类型参数里，填入多少个就会解除对应的异常属性状态")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc == null || skillEffectDesc.EffectParamsInt.Count < 1)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		HashSet<EAbnormalStateType> hashSet = new HashSet<EAbnormalStateType>();
		foreach (int item2 in skillEffectDesc.EffectParamsInt)
		{
			EAbnormalStateType item = (EAbnormalStateType)item2;
			hashSet.Add(item);
		}
		bUS_GSEventCollection.Evt_ClearAbnormalState.Invoke(hashSet);
	}

	[TemplateFunNote("通过Buff移除异常状态")]
	[ParamInfoI(0, "异常属性类型（1冰，2火，3毒，4雷，5阴，6阳）")]
	[ParamInfoI(1, "同上，int参数为异常属性类型数组（后面位置数组元素也一样）")]
	[AffectTarget]
	[TemplateFuncTips("Int类型参数里，填入多少个就会解除对应的异常属性状态")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		if (intEffectParamCount < 1)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			HashSet<EAbnormalStateType> hashSet = new HashSet<EAbnormalStateType>();
			for (int i = 0; i < intEffectParamCount; i++)
			{
				EAbnormalStateType item = (EAbnormalStateType)buffDescRuntime.GetIntEffectParam(EffectIdx, i);
				hashSet.Add(item);
			}
			bUS_GSEventCollection.Evt_ClearAbnormalState.Invoke(hashSet);
		}
	}
}
