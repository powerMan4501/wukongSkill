using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "启用精准闪避" })]
public class BUEffectEnablePreciseDodge : BUEffectTemplate
{
	public BUEffectEnablePreciseDodge()
	{
		EffectType = EBuffAndSkillEffectType.EnablePreciseDodge;
	}

	[TemplateFunNote("Buff期间启用精准闪避")]
	[AffectTarget]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UnitSetEnablePreciseDodge.Invoke(P1: true);
			}
		}
	}

	[TemplateFunNote("Buff结束禁用精准闪避")]
	[AffectTarget]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UnitSetEnablePreciseDodge.Invoke(P1: false);
			}
		}
	}
}
