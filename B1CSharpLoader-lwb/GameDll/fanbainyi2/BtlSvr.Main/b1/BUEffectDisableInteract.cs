using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[CantUseInMultiEffect]
[EffectTemplateTips(new string[] { "关闭交互" })]
public class BUEffectDisableInteract : BUEffectTemplate
{
	public BUEffectDisableInteract()
	{
		EffectType = EBuffAndSkillEffectType.DisableInteract;
	}

	[TemplateFunNote("添加Buff时关闭交互")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SwitchNoInteraction.Invoke(P1: false);
			}
		}
	}

	[TemplateFunNote("移除Buff时开启交互")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SwitchNoInteraction.Invoke(P1: true);
			}
		}
	}
}
