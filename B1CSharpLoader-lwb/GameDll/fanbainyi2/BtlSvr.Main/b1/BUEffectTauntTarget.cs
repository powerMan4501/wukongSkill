using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "嘲讽" })]
[AffectTarget]
[StopMaintenance]
public class BUEffectTauntTarget : BUEffectTemplate
{
	public BUEffectTauntTarget()
	{
		EffectType = EBuffAndSkillEffectType.TauntTarget;
	}

	[TemplateFunNote("Buff持有者会被Buff释放者强制嘲讽")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target) && !(BUS_EventCollectionCS.Get(Target) == null))
		{
			AActor taunter = EntitySharedRefFuncLib.Actor(BuffInst.CasterRef);
			BUS_EventCollectionCS.Get(Target).Evt_TriggerBeTaunted.Invoke(taunter, IsReMove: false);
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			AActor taunter = EntitySharedRefFuncLib.Actor(BuffInst.CasterRef);
			BUS_EventCollectionCS.Get(Target).Evt_TriggerBeTaunted.Invoke(taunter, IsReMove: true);
		}
	}
}
