using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "降低异常积累值" })]
public class BUEffectDecreaseAbnormalAccValue : BUEffectTemplate
{
	public BUEffectDecreaseAbnormalAccValue()
	{
		EffectType = EBuffAndSkillEffectType.DecreaseAbnormalAccValue;
	}

	[ParamInfoI(0, "异常属性类型(1冰，2火，3毒，4雷，5阴，6阳)")]
	[ParamInfoI(1, "异常属性积累值减少量")]
	[AffectTarget]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc != null && skillEffectDesc.EffectParamsInt.Count >= 2)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_DecreaseAbnormalAccValue.Invoke((EAbnormalStateType)skillEffectDesc.EffectParamsInt[0], skillEffectDesc.EffectParamsInt[1]);
			}
		}
	}

	[AffectTarget]
	[ParamInfoI(0, "异常属性类型(1冰，2火，3毒，4雷，5阴，6阳)")]
	[ParamInfoI(1, "异常属性积累值减少量")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null && buffDescRuntime.GetIntEffectParamCount(EffectIdx) >= 2)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_DecreaseAbnormalAccValue.Invoke((EAbnormalStateType)buffDescRuntime.GetIntEffectParam(EffectIdx, 0), buffDescRuntime.GetIntEffectParam(EffectIdx, 1));
			}
		}
	}
}
