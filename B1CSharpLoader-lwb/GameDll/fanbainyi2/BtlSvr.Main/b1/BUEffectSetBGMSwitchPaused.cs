using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "暂停BGM" })]
[CantUseInMultiEffect]
public class BUEffectSetBGMSwitchPaused : BUEffectTemplate
{
	public BUEffectSetBGMSwitchPaused()
	{
		EffectType = EBuffAndSkillEffectType.SetBgmSwitchPaused;
	}

	[TemplateFunNote("Buff触发时暂停BGM")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Target).GetControlledPawn() != Target))
		{
			BGS_EventCollectionCS.Get(Target)?.Evt_BGS_SetBattleBgmCanTick.Invoke(NewIsCanTick: false);
		}
	}

	[TemplateFunNote("Buff移除时开启BGM")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Target).GetControlledPawn() != Target))
		{
			BGS_EventCollectionCS.Get(Target)?.Evt_BGS_SetBattleBgmCanTick.Invoke(NewIsCanTick: true);
		}
	}
}
