using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "int参数1，StepValue满值为100，减到0时移除异常状态，例如填100直接移除，不填默认100" })]
public class BUEffectRemoveAbnormalFinalEffectByStep : BUEffectTemplate
{
	public BUEffectRemoveAbnormalFinalEffectByStep()
	{
		EffectType = EBuffAndSkillEffectType.RemoveAbnormalFinalEffectByStep;
	}

	[TemplateFunNote("通过技能逐步移除异常状态效果")]
	[ParamInfoI(0, "异常属性类型（1冰，2火，3毒，4雷，5阴，6阳）")]
	[ParamInfoI(1, "可选参数，StepValue（异常状态移除百分比，总值100）")]
	[AffectTarget]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc != null && skillEffectDesc.EffectParamsInt.Count >= 1)
		{
			int stepValue = ((skillEffectDesc.EffectParamsInt.Count > 1) ? skillEffectDesc.EffectParamsInt[1] : 100);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_RemoveAbnormalFinalEffectByStep.Invoke((EAbnormalStateType)skillEffectDesc.EffectParamsInt[0], stepValue);
			}
		}
	}

	[TemplateFunNote("通过Buff逐步移除异常状态效果")]
	[ParamInfoI(0, "异常属性类型（1冰，2火，3毒，4雷，5阴，6阳）")]
	[ParamInfoI(1, "可选参数，StepValue（异常状态移除百分比，总值100）")]
	[AffectTarget]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		if (intEffectParamCount >= 1)
		{
			int stepValue = ((intEffectParamCount > 1) ? buffDescRuntime.GetIntEffectParam(EffectIdx, 1) : 100);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_RemoveAbnormalFinalEffectByStep.Invoke((EAbnormalStateType)buffDescRuntime.GetIntEffectParam(EffectIdx, 0), stepValue);
			}
		}
	}
}
