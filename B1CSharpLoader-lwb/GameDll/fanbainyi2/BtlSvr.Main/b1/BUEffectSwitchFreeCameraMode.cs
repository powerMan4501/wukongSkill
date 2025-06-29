using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "切换到自由镜头模式" })]
public class BUEffectSwitchFreeCameraMode : BUEffectTemplate
{
	public BUEffectSwitchFreeCameraMode()
	{
		EffectType = EBuffAndSkillEffectType.SwitchFreeCameraMode;
	}

	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SwitchFreeCameraMode.Invoke(EPlayerFreeCameraType.None);
			}
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SwitchFreeCameraMode.Invoke(EPlayerFreeCameraType.None);
			}
		}
	}
}
