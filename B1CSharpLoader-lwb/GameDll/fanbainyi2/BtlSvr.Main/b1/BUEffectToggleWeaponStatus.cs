using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "切换武器状态", "武器Index填-1时禁用全部武器" })]
public class BUEffectToggleWeaponStatus : BUEffectTemplate
{
	public BUEffectToggleWeaponStatus()
	{
		EffectType = EBuffAndSkillEffectType.ToggleWeaponStatus;
	}

	[ParamInfoI(3, "同上，int参数是武器Index数组")]
	[ParamInfoI(2, "武器Index2")]
	[TemplateFunNote("通过Buff切换武器状态")]
	[ParamInfoI(0, "0表示隐藏，1表示激活")]
	[AffectTarget]
	[ParamInfoI(1, "武器Index1")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			List<int> intEffectParamList = buffDescRuntime.GetIntEffectParamList(EffectIdx);
			if (intEffectParamList.Count >= 2)
			{
				bool triggerActivate = intEffectParamList[0] == 1;
				intEffectParamList.RemoveAt(0);
				BUS_EventCollectionCS.Get(Target).Evt_ToggleWeaponsStatus_ByEffect.Invoke(intEffectParamList, triggerActivate, NeedOverride: true, BuffInst.BuffID, EffectIdx, Reset2Default: false);
			}
		}
	}

	[TemplateFunNote("通过Buff切换武器状态（还原）")]
	[AffectTarget]
	[ParamInfoI(0, "0表示激活，1表示隐藏（和ApplyByBuff成对）")]
	[ParamInfoI(1, "武器Index1")]
	[ParamInfoI(2, "武器Index2")]
	[ParamInfoI(3, "同上，int参数是武器Index数组")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			List<int> intEffectParamList = buffDescRuntime.GetIntEffectParamList(EffectIdx);
			if (intEffectParamList.Count >= 2)
			{
				bool flag = intEffectParamList[0] == 1;
				intEffectParamList.RemoveAt(0);
				BUS_EventCollectionCS.Get(Target).Evt_ToggleWeaponsStatus_ByEffect.Invoke(intEffectParamList, !flag, NeedOverride: false, BuffInst.BuffID, EffectIdx, Reset2Default: false);
			}
		}
	}
}
