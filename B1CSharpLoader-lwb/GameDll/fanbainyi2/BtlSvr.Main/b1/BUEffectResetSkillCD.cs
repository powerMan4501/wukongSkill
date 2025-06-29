using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectResetSkillCD : BUEffectTemplate
{
	public BUEffectResetSkillCD()
	{
		EffectType = EBuffAndSkillEffectType.ResetSkillCd;
	}

	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ResetSkillCD.Invoke();
			}
		}
	}
}
