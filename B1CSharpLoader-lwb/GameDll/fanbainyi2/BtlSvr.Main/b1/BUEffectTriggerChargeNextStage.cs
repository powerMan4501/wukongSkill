using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectTriggerChargeNextStage : BUEffectTemplate
{
	public BUEffectTriggerChargeNextStage()
	{
		EffectType = EBuffAndSkillEffectType.TriggerChargeNextStage;
	}

	[ParamInfoI(0, "是否蓄力超时（1是，0不是）")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc != null && skillEffectDesc.EffectParamsInt.Count >= 1)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bool p = skillEffectDesc.EffectParamsInt[0] != 0;
				bUS_GSEventCollection.Evt_TriggerNextChargeSkillStage.Invoke(p);
			}
		}
	}

	[ParamInfoI(0, "是否蓄力超时（1是，0不是）")]
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
				bool p = buffDescRuntime.GetIntEffectParam(EffectIdx, 0) != 0;
				bUS_GSEventCollection.Evt_TriggerNextChargeSkillStage.Invoke(p);
			}
		}
	}
}
