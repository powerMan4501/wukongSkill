using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "幻化装备" })]
public class BUEffectApplyIllusionEquipOverride : BUEffectTemplate
{
	public BUEffectApplyIllusionEquipOverride()
	{
		EffectType = EBuffAndSkillEffectType.ApplyIllusionEquipOverride;
	}

	[TemplateFunNote("应用幻化装备")]
	[ParamInfoS(0, "DAPath")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime.GetEffectsCount() > EffectIdx && buffDescRuntime.GetStringEffectParamCount(EffectIdx) >= 1)
		{
			string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_BattleLogicChangeEquipIllusion.Invoke(stringEffectParam);
			}
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst).GetEffectsCount() > EffectIdx)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_BattleLogicResetEquipIllusion.Invoke();
			}
		}
	}
}
