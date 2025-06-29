using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "手动允许掉落精魄" })]
public class BUEffectSetEnableVigourDropManually : BUEffectTemplate
{
	public BUEffectSetEnableVigourDropManually()
	{
		EffectType = EBuffAndSkillEffectType.SetEnableVigourDropManually;
	}

	[TemplateFunNote("手动允许掉落精魄")]
	[TemplateFuncTips("Buff期间会手动允许掉落精魄。")]
	[AffectTarget]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetEnableVigourDropManually.Invoke(P1: true);
			}
		}
	}

	[AffectTarget]
	[TemplateFunNote("Buff结束恢复允许掉落精魄状态。")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null && !BuffInst.BuffEndTriggerByDead)
			{
				bUS_GSEventCollection.Evt_SetEnableVigourDropManually.Invoke(P1: false);
			}
		}
	}
}
