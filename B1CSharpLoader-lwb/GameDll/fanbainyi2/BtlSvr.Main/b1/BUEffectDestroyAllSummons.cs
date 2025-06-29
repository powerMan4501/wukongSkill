using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectDestroyAllSummons : BUEffectTemplate
{
	public BUEffectDestroyAllSummons()
	{
		EffectType = EBuffAndSkillEffectType.DestroyAllSummons;
	}

	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_DestroyAllSummons.Invoke();
		}
	}
}
