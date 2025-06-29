using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "禁止被HitMove推移" })]
public class BUEffectSetHitMoveUnmovable : BUEffectTemplate
{
	public BUEffectSetHitMoveUnmovable()
	{
		EffectType = EBuffAndSkillEffectType.SetHitMoveUnmovable;
	}

	[TemplateFunNote("禁止被HitMove推移")]
	[AffectTarget]
	[TemplateFuncTips("Buff期间会禁止被HitMove推移，但仍然允许推移其他单位。")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetHitMoveUnmovable.Invoke(P1: true);
			}
		}
	}

	[TemplateFunNote("Buff结束恢复HitMove推移。")]
	[AffectTarget]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetHitMoveUnmovable.Invoke(P1: false);
			}
		}
	}
}
