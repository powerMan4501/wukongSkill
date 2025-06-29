using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[AffectTarget]
public class BUEffectSwitchStateLib : BUEffectTemplate
{
	public BUEffectSwitchStateLib()
	{
		EffectType = EBuffAndSkillEffectType.SwitchStateLib;
	}

	[ParamInfoI(0, ">0 : 切换类型为Mod，否则为Base")]
	[ParamInfoI(1, "StateType，切换的具体组合")]
	[ParamInfoS(0, "StateLib库路径（BGWDataAsset_StateLib）")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster) || b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc != null || skillEffectDesc.EffectParamsInt.Count >= 2)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null && skillEffectDesc.EffectParamsStr.Count >= 1)
			{
				StateLibSwitchType switchType = ((skillEffectDesc.EffectParamsInt[0] <= 0) ? StateLibSwitchType.Base : StateLibSwitchType.Mod);
				bUS_GSEventCollection.Evt_SwitchStateLib.Invoke(skillEffectDesc.EffectParamsStr[0], skillEffectDesc.EffectParamsInt[1], switchType);
			}
		}
	}

	[TemplateFunNote("加Buff时，切换StateLib，在移除Buff时重置")]
	[ParamInfoI(0, "StateType，切换的具体组合")]
	[ParamInfoI(1, "未配置该参数或配置的>0时切换类型为Mod，否则为Base")]
	[ParamInfoS(0, "StateLib库路径（BGWDataAsset_StateLib）")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
			int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
			StateLibSwitchType switchType = StateLibSwitchType.Mod;
			if (buffDescRuntime.GetIntEffectParamCount(EffectIdx) > 1 && buffDescRuntime.GetIntEffectParam(EffectIdx, 1) <= 0)
			{
				switchType = StateLibSwitchType.Base;
			}
			BUS_EventCollectionCS.Get(Target).Evt_SwitchStateLib.Invoke(stringEffectParam, intEffectParam, switchType);
		}
	}

	[ParamInfoI(1, "未配置该参数或配置的>0时切换类型为Mod，否则为Base")]
	[ParamInfoI(0, "StateType，重置的具体组合")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
			StateLibSwitchType switchType = StateLibSwitchType.Mod;
			if (buffDescRuntime.GetIntEffectParamCount(EffectIdx) > 1 && buffDescRuntime.GetIntEffectParam(EffectIdx, 1) <= 0)
			{
				switchType = StateLibSwitchType.Base;
			}
			BUS_EventCollectionCS.Get(Target).Evt_ResetStateLib.Invoke(intEffectParam, switchType);
		}
	}
}
