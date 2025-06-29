using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[CantUseInMultiEffect]
[EffectTemplateTips(new string[] { "不再进入战斗", "关闭感知", "关闭设置目标", "关闭刷新仇恨", "根据参数决定是否回到非战斗状态机", "清空目标", "清空仇恨", "强制脱战（一次性）" })]
public class BUEffectNeverIntoBattle : BUEffectTemplate
{
	public BUEffectNeverIntoBattle()
	{
		EffectType = EBuffAndSkillEffectType.NeverIntoBattle;
	}

	[TemplateFunNote("添加Buff时添加不进入战斗效果")]
	[ParamInfoI(0, "是否回到非战斗状态机")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (Target.IsNullOrDestroyed())
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_AIPerceptionSetting.Invoke(P1: false);
			bUS_GSEventCollection.Evt_EnableCanSetTarget.Invoke(P1: false);
			bUS_GSEventCollection.Evt_EnableCanUpdateHatred.Invoke(P1: false);
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null && buffDescRuntime.GetIntEffectParam(EffectIdx, 0) == 1)
			{
				bUS_GSEventCollection.Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_STANDBY);
			}
			bUS_GSEventCollection.Evt_OnLeaveFight.Invoke();
		}
	}

	[TemplateFunNote("移除Buff时恢复感知，恢复设置目标，恢复刷新仇恨")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_AIPerceptionSetting.Invoke(P1: true);
				bUS_GSEventCollection.Evt_EnableCanSetTarget.Invoke(P1: true);
				bUS_GSEventCollection.Evt_EnableCanUpdateHatred.Invoke(P1: true);
			}
		}
	}
}
