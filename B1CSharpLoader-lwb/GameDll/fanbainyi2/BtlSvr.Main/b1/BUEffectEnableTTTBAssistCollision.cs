using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "开启辅助碰撞（TTTB用，给主角四周加上阻挡盒子，Buff结束后移除）" })]
public class BUEffectEnableTTTBAssistCollision : BUEffectTemplate
{
	public BUEffectEnableTTTBAssistCollision()
	{
		EffectType = EBuffAndSkillEffectType.EnableAssistCollision;
	}

	[TemplateFunNote("Buff开启辅助碰撞")]
	[AffectTarget]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnEnableAssistCollision.Invoke(P1: true);
			}
		}
	}

	[TemplateFunNote("Buff结束关闭辅助碰撞")]
	[AffectTarget]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnEnableAssistCollision.Invoke(P1: false);
			}
		}
	}
}
