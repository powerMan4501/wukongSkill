using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectSwitchPlayerCamInfoId : BUEffectTemplate
{
	public BUEffectSwitchPlayerCamInfoId()
	{
		EffectType = EBuffAndSkillEffectType.SwitchPlayerCamInfoId;
	}

	[ParamInfoI(0, "CameraID")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				bUS_GSEventCollection.Evt_EnterPlayerSkillCamera.Invoke(intEffectParam);
			}
		}
	}

	[TemplateFunNote("恢复CamID")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target) && b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst) != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ExitPlayerSkillCamera.Invoke();
			}
		}
	}
}
