using System;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectSetSimpleState : BUEffectTemplate
{
	public BUEffectSetSimpleState()
	{
		EffectType = EBuffAndSkillEffectType.SetSimpleState;
	}

	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		for (int i = 0; i < intEffectParamCount; i++)
		{
			int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, i);
			if (Enum.IsDefined(typeof(EBGUSimpleState), (byte)intEffectParam))
			{
				EBGUSimpleState eBGUSimpleState = (EBGUSimpleState)intEffectParam;
				if (eBGUSimpleState == EBGUSimpleState.Immobilizing)
				{
					break;
				}
				BUS_EventCollectionCS.Get(Target).Evt_UnitSetSimpleState.Invoke(eBGUSimpleState);
			}
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		int buffID = BuffInst.BuffID;
		if (buffID > 900)
		{
			_ = 999;
		}
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		for (int i = 0; i < intEffectParamCount; i++)
		{
			int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, i);
			if (Enum.IsDefined(typeof(EBGUSimpleState), (byte)intEffectParam))
			{
				EBGUSimpleState eBGUSimpleState = (EBGUSimpleState)intEffectParam;
				if (eBGUSimpleState == EBGUSimpleState.Immobilizing)
				{
					break;
				}
				BUS_EventCollectionCS.Get(Target).Evt_UnitSetSimpleState.Invoke(eBGUSimpleState, IsRemove: true);
			}
		}
	}
}
