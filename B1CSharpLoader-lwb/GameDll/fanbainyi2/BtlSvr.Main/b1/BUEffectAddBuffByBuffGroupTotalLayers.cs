using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectAddBuffByBuffGroupTotalLayers : BUEffectTemplate
{
	public BUEffectAddBuffByBuffGroupTotalLayers()
	{
		EffectType = EBuffAndSkillEffectType.AddBuffByBuffGroupTotalLayers;
	}

	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (!(bUS_GSEventCollection == null))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				int intEffectParam2 = buffDescRuntime.GetIntEffectParam(EffectIdx, 1);
				int intEffectParam3 = buffDescRuntime.GetIntEffectParam(EffectIdx, 2);
				int intEffectParam4 = buffDescRuntime.GetIntEffectParam(EffectIdx, 3);
				bUS_GSEventCollection.Evt_EnableCheckBuffGroup.Invoke(intEffectParam, intEffectParam2, intEffectParam3, intEffectParam4);
			}
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (!(bUS_GSEventCollection == null))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				bUS_GSEventCollection.Evt_DisableCheckBuffGroup.Invoke(intEffectParam);
			}
		}
	}
}
