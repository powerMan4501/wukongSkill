using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "通过技能累积异常值时，会首先判断命中部位是否免疫异常积累；通过Buff累积异常值时则不会判断" })]
public class BUEffectAccumulateAbnormalValue : BUEffectTemplate
{
	public BUEffectAccumulateAbnormalValue()
	{
		EffectType = EBuffAndSkillEffectType.AccumulateAbnormalValue;
	}

	[ParamInfoI(3, "异常属性值增量")]
	[AffectTarget]
	[ParamInfoI(1, "异常属性等级")]
	[ParamInfoI(0, "异常属性类型(1冰，2火，3毒，4雷，5阴，6阳)")]
	[TemplateFunNote("通过技能累积异常值")]
	[ParamInfoI(2, "异常属性增加类型（0绝对值，1万分比）")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		IBUC_PartMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PartMgrData, BUC_PartMgrData>(Target);
		if (readOnlyData != null && readOnlyData.GetPartInfo(EffectInstReq.HitPartID, out var PartInfoOut) && PartInfoOut.ImmueAbnormalStateAcc)
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc != null && skillEffectDesc.EffectParamsInt.Count >= 4)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_HandleAbnormal.Invoke((EAbnormalStateType)skillEffectDesc.EffectParamsInt[0], Caster, (EAccAbnormalValueType)skillEffectDesc.EffectParamsInt[2], skillEffectDesc.EffectParamsInt[3], skillEffectDesc.EffectParamsInt[1]);
			}
		}
	}

	[TemplateFunNote("通过Buff累积异常值")]
	[ParamInfoI(0, "异常属性类型(1冰，2火，3毒，4雷，5阴，6阳)")]
	[ParamInfoI(1, "异常属性等级")]
	[ParamInfoI(2, "异常属性增加类型（0绝对值，1万分比）")]
	[ParamInfoI(3, "异常属性值增量")]
	[AffectTarget]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null && buffDescRuntime.GetIntEffectParamCount(EffectIdx) >= 4)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_HandleAbnormal.Invoke((EAbnormalStateType)buffDescRuntime.GetIntEffectParam(EffectIdx, 0), EntitySharedRefFuncLib.Actor(BuffInst.CasterRef), (EAccAbnormalValueType)buffDescRuntime.GetIntEffectParam(EffectIdx, 2), buffDescRuntime.GetIntEffectParam(EffectIdx, 3), buffDescRuntime.GetIntEffectParam(EffectIdx, 1));
			}
		}
	}
}
