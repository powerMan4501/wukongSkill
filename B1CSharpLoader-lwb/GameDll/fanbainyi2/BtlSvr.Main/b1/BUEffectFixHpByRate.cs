using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "按FixFunction设置HP上限", "根据传入的FixFunctionID设置HP上限", "当前的血量会按照对应的百分比变化" })]
public class BUEffectFixHpByRate : BUEffectTemplate
{
	public BUEffectFixHpByRate()
	{
		EffectType = EBuffAndSkillEffectType.FixHpByRate;
	}

	[TemplateFunNote("按FixFunction设置HP上限")]
	[ParamInfoI(0, "无用参数")]
	[ParamInfoI(1, "无用参数")]
	[ParamInfoI(2, "无用参数")]
	[ParamInfoI(3, "FixFunctionID")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(Target);
		BUC_BuffData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Target);
		if (readOnlyData == null || readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax) == 0f)
		{
			return;
		}
		float num = readOnlyData.GetFloatValue(EBGUAttrFloat.Hp) / readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax);
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime.GetEffectsCount() > EffectIdx && buffDescRuntime.GetIntEffectParamCount(EffectIdx) >= 4)
		{
			UGameplayStatics.GetGameState(Target.World);
			readOnlyData2.GetBuffLayer(BuffInst.BuffID);
			int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 3);
			float increaseValue = 0f;
			if (intEffectParam > 0)
			{
				BUFixFunctionTemplate.RunByBuffApply(EntitySharedRefFuncLib.Actor(BuffInst.CasterRef), Target, intEffectParam, out var OutAbs, out var _);
				increaseValue = OutAbs;
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.HpMaxMul, increaseValue);
			bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Hp, readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax) * num - readOnlyData.GetFloatValue(EBGUAttrFloat.Hp));
		}
	}

	[ParamInfoI(3, "计算血量百分比的FixFunctionID")]
	[TemplateFunNote("移除FixFunction HP百分比调整")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		BUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(Target);
		BUC_BuffData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Target);
		if (readOnlyData == null || readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax) == 0f)
		{
			return;
		}
		float num = readOnlyData.GetFloatValue(EBGUAttrFloat.Hp) / readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax);
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime.GetEffectsCount() > EffectIdx && buffDescRuntime.GetIntEffectParamCount(EffectIdx) >= 4)
		{
			UGameplayStatics.GetGameState(Target.World);
			readOnlyData2.GetBuffLayer(BuffInst.BuffID);
			int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 3);
			float num2 = 0f;
			if (intEffectParam > 0)
			{
				BUFixFunctionTemplate.RunByBuffApply(EntitySharedRefFuncLib.Actor(BuffInst.CasterRef), Target, intEffectParam, out var OutAbs, out var _);
				num2 = OutAbs;
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.HpMaxMul, 0f - num2);
			bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Hp, readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax) * num - readOnlyData.GetFloatValue(EBGUAttrFloat.Hp));
		}
	}
}
