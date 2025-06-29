using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "使Target继承Caster的HP百分比" })]
public class BUEffectInheritedHpByRate : BUEffectTemplate
{
	public BUEffectInheritedHpByRate()
	{
		EffectType = EBuffAndSkillEffectType.InheritedHpByRate;
	}

	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		AActor aActor = ECSExtension.ToActor(EntitySharedRefFuncLib.Entity(BuffInst.RootCasterRef));
		if (aActor == null)
		{
			return;
		}
		BUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(aActor);
		if (readOnlyData != null && readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax) != 0f)
		{
			float num = readOnlyData.GetFloatValue(EBGUAttrFloat.Hp) / readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax);
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			BUC_AttrContainer readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(Target);
			if (buffDescRuntime.GetEffectsCount() > EffectIdx)
			{
				BUS_EventCollectionCS.Get(Target).Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Hp, readOnlyData2.GetFloatValue(EBGUAttrFloat.HpMax) * num - readOnlyData2.GetFloatValue(EBGUAttrFloat.Hp));
			}
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
	}
}
