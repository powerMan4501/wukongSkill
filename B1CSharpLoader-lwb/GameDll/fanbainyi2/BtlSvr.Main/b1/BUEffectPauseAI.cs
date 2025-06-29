using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "用于暂停AI逻辑，包括BT，FSM，AI感知，仇恨更新" })]
[AffectTarget]
public class BUEffectPauseAI : BUEffectTemplate
{
	public BUEffectPauseAI()
	{
		EffectType = EBuffAndSkillEffectType.PauseAi;
	}

	[TemplateFunNote("添加Buff时暂停AI")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			bUS_GSEventCollection.Evt_AIPauseBT.Invoke(P1: true);
			bUS_GSEventCollection.Evt_AIPauseFsm.Invoke(P1: true);
			bUS_GSEventCollection.Evt_AIPerceptionSetting.Invoke(P1: false);
			bUS_GSEventCollection.Evt_EnableCanUpdateHatred.Invoke(P1: false);
		}
	}

	[TemplateFunNote("移除Buff时恢复AI")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			bUS_GSEventCollection.Evt_AIPauseBT.Invoke(P1: false);
			bUS_GSEventCollection.Evt_AIPauseFsm.Invoke(P1: false);
			bUS_GSEventCollection.Evt_AIPerceptionSetting.Invoke(P1: true);
			bUS_GSEventCollection.Evt_EnableCanUpdateHatred.Invoke(P1: true);
		}
	}
}
