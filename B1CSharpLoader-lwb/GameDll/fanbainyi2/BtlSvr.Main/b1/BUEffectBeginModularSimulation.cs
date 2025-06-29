using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectBeginModularSimulation : BUEffectTemplate
{
	public BUEffectBeginModularSimulation()
	{
		EffectType = EBuffAndSkillEffectType.BeginModularSimulation;
	}

	[ParamInfoS(0, "DA路径（BGWDataAsset_TigerWoodsConfig）")]
	[AffectCaster]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			string tigerWoodsDataAssetPath = ((skillEffectDesc.EffectParamsStr.Count > 0) ? skillEffectDesc.EffectParamsStr[0] : "");
			BUS_EventCollectionCS.Get(Caster).Evt_BeginModularSimulation.Invoke(tigerWoodsDataAssetPath);
		}
	}

	[ParamInfoS(0, "DA路径（BGWDataAsset_TigerWoodsConfig）")]
	[AffectTarget]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
				BUS_EventCollectionCS.Get(Target).Evt_BeginModularSimulation.Invoke(stringEffectParam);
			}
		}
	}

	[ParamInfoF(0, "部位破坏的力度")]
	[ParamInfoI(0, ">0:移除Buff时不触发模块破坏 <=0:移除Buff同时模块破坏")]
	[AffectTarget]
	[TemplateFunNote("移除Buff时可以选择是否触发模块破坏（针对所有模块）")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null && buffDescRuntime.GetIntEffectParam(EffectIdx, 0) > 0)
			{
				float floatEffectParam = buffDescRuntime.GetFloatEffectParam(EffectIdx, 0);
				BUS_EventCollectionCS.Get(Target).Evt_ModularBreakDown.Invoke(floatEffectParam);
			}
		}
	}
}
