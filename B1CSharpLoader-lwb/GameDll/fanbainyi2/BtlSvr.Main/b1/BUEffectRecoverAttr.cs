using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectRecoverAttr : BUEffectTemplate
{
	private float INV10000 = 10000f;

	public BUEffectRecoverAttr()
	{
		EffectType = EBuffAndSkillEffectType.RecoverAttr;
	}

	[ParamInfoF(0, "ChangeValue 恢复属性值")]
	[ParamInfoI(1, "AttrID 恢复属性ID")]
	[TemplateFunNote("恢复属性")]
	[AffectTarget]
	[TemplateFuncTips("读取的SkillEffec表是Caster的，触发效果的是Target")]
	[ParamInfoI(2, "ChangeValueType 恢复值类型（0 = 绝对值，1 = 万分比）")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc == null)
		{
			return;
		}
		float num = skillEffectDesc.EffectParamsFloat[0];
		int num2 = ((skillEffectDesc.EffectParamsInt.Count > 2) ? skillEffectDesc.EffectParamsInt[2] : 0);
		EBGUAttrFloat eBGUAttrFloat = (EBGUAttrFloat)skillEffectDesc.EffectParamsInt[1];
		if (b1.EffectTemplateUtil.ReturnIfUnitInPendingOrFakeDead(Target) && eBGUAttrFloat == EBGUAttrFloat.Hp)
		{
			return;
		}
		if (num2 == 1)
		{
			bool IsVaild;
			AttrMinMaxGroup<EBGUAttrFloat, float> minMax = AttrMgr<EBGUAttrFloat, float>.getInstance().GetMinMax(eBGUAttrFloat, out IsVaild);
			if (!IsVaild)
			{
				return;
			}
			num = BGUFunctionLibraryCS.BGUGetFloatAttr(Target, minMax.maxVal) * num / INV10000;
		}
		BUS_EventCollectionCS.Get(Target).Evt_IncreaseAttrFloat.Invoke(eBGUAttrFloat, num);
	}

	[TemplateFunNote("恢复属性")]
	[ParamInfoI(1, "ChangeValue 恢复属性值")]
	[ParamInfoI(3, "ChangeValueType 恢复值类型（0 = 绝对值，1 = 万分比）")]
	[ParamInfoI(4, "FixFunctionID(修正方法ID)")]
	[ParamInfoI(5, "IngoreLayer, 【FixFunction存在才有意义】是否忽略BuffLayer带来的数值累计修正")]
	[AffectTarget]
	[ParamInfoI(0, "AttrID 恢复属性ID")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		AActor aActor = EntitySharedRefFuncLib.Actor(BuffInst.CasterRef);
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		float num = buffDescRuntime.GetIntEffectParam(EffectIdx, 1);
		int num2 = ((buffDescRuntime.GetIntEffectParamCount(EffectIdx) > 3) ? buffDescRuntime.GetIntEffectParam(EffectIdx, 3) : 0);
		EBGUAttrFloat eBGUAttrFloat = (EBGUAttrFloat)buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
		if (b1.EffectTemplateUtil.ReturnIfUnitInPendingOrFakeDead(Target) && eBGUAttrFloat == EBGUAttrFloat.Hp)
		{
			return;
		}
		int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 4);
		if (intEffectParam > 0)
		{
			BUFixFunctionTemplate.RunByBuffApply(aActor, Target, intEffectParam, out var OutAbs, out var _);
			num = ((buffDescRuntime.GetIntEffectParam(EffectIdx, 5) > 0) ? OutAbs : (OutAbs - BuffInst.CachedFixFunctionReturnValues[EffectIdx]));
			bUS_GSEventCollection.Evt_CacheFixFunctionReturnValue.Invoke(BuffInst.BuffID, EffectIdx, OutAbs);
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Target, EBattleInfoType.FixFunctionModify, $"<character>{aActor.GetName()}</><action>对</><bechosed>{Target.GetName()}</><action>触发了ID为</><effect>{intEffectParam}</><action>的固定函数修改(ID为</><effect>{eBGUAttrFloat}</><action>，固定函数返回值为</><damage>{OutAbs}</><action>)</>", bIsPeriodical ? 1 : 0);
			}
		}
		else if (bIsPeriodical && BuffInst.bHasTriggeredApplyByBuff)
		{
			return;
		}
		if (num2 == 1)
		{
			bool IsVaild;
			AttrMinMaxGroup<EBGUAttrFloat, float> minMax = AttrMgr<EBGUAttrFloat, float>.getInstance().GetMinMax(eBGUAttrFloat, out IsVaild);
			if (!IsVaild)
			{
				return;
			}
			num = BGUFunctionLibraryCS.BGUGetFloatAttr(Target, minMax.maxVal) * num / INV10000;
		}
		BUS_EventCollectionCS.Get(Target).Evt_IncreaseAttrFloat.Invoke(eBGUAttrFloat, num);
		if (intEffectParam > 0)
		{
			BuffInst.bHasTriggeredApplyByBuff = true;
		}
	}
}
