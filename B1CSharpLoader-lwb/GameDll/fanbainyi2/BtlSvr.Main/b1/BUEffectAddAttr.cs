using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "如果FixFunctionID > 0 则执行修正函数修正ChangeValue", "如果Buff已经触发过，且不能重复触发，则不会执行AddAttr逻辑" })]
[CanUseByBulletEffect]
public class BUEffectAddAttr : BUEffectTemplate
{
	public BUEffectAddAttr()
	{
		EffectType = EBuffAndSkillEffectType.AddAttr;
	}

	[ParamInfoI(0, "AttrID(属性ID)")]
	[ParamInfoI(1, "ChangeValue(修正值)")]
	[ParamInfoI(3, "FixFunctionID(修正方法ID)")]
	[ParamInfoI(4, "IngoreLayer, 【FixFunction存在才有意义】是否忽略BuffLayer带来的数值累计修正")]
	[ParamInfoF(0, "ChangeValue(可选，float类型修正值，填写后覆盖int修正值)")]
	[AffectTarget]
	[TemplateFunNote("通过Buff增加属性值")]
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
		int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
		float increaseValue = ((buffDescRuntime.GetFloatEffectParamCount(EffectIdx) > 0) ? buffDescRuntime.GetFloatEffectParam(EffectIdx, 0) : ((float)buffDescRuntime.GetIntEffectParam(EffectIdx, 1)));
		int intEffectParam2 = buffDescRuntime.GetIntEffectParam(EffectIdx, 3);
		if (intEffectParam2 > 0)
		{
			BUFixFunctionTemplate.RunByBuffApply(aActor, Target, intEffectParam2, out var OutAbs, out var _);
			increaseValue = ((buffDescRuntime.GetIntEffectParam(EffectIdx, 4) > 0) ? OutAbs : (OutAbs - BuffInst.CachedFixFunctionReturnValues[EffectIdx]));
			bUS_GSEventCollection.Evt_CacheFixFunctionReturnValue.Invoke(BuffInst.BuffID, EffectIdx, OutAbs);
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Target, EBattleInfoType.FixFunctionModify, $"<character>{aActor.GetName()}</><action>对</><bechosed>{Target.GetName()}</><action>触发了ID为</><effect>{intEffectParam2}</><action>的固定函数修改(ID为</><effect>{intEffectParam}</><action>，固定函数返回值为</><damage>{OutAbs}</><action>)</>", bIsPeriodical ? 1 : 0);
			}
		}
		else if (bIsPeriodical && BuffInst.bHasTriggeredApplyByBuff)
		{
			return;
		}
		EBGUAttrFloat attrID = (EBGUAttrFloat)intEffectParam;
		bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(attrID, increaseValue);
		if (intEffectParam2 > 0)
		{
			BuffInst.bHasTriggeredApplyByBuff = true;
		}
	}

	[AffectTarget]
	[ParamInfoI(4, "IngoreLayer, 【FixFunction存在才有意义】是否忽略BuffLayer带来的数值累计修正")]
	[ParamInfoI(3, "FixFunctionID(修正方法ID)")]
	[ParamInfoI(1, "ChangeValue(修正值)")]
	[ParamInfoI(0, "AttrID(属性ID)")]
	[TemplateFunNote("移除Buff时，清理属性值")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		AActor caster = EntitySharedRefFuncLib.Actor(BuffInst.CasterRef);
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
		float num = -1f * ((buffDescRuntime.GetFloatEffectParamCount(EffectIdx) > 0) ? buffDescRuntime.GetFloatEffectParam(EffectIdx, 0) : ((float)buffDescRuntime.GetIntEffectParam(EffectIdx, 1)));
		int intEffectParam2 = buffDescRuntime.GetIntEffectParam(EffectIdx, 3);
		int intEffectParam3 = buffDescRuntime.GetIntEffectParam(EffectIdx, 4);
		if (intEffectParam2 > 0)
		{
			if (intEffectParam3 <= 0)
			{
				num = 0f - BuffInst.CachedFixFunctionReturnValues[EffectIdx];
			}
			else
			{
				BUFixFunctionTemplate.RunByBuffApply(caster, Target, intEffectParam2, out var OutAbs, out var _);
				num = 0f - OutAbs;
			}
		}
		if (intEffectParam3 <= 0)
		{
			num *= (float)Layer;
		}
		EBGUAttrFloat attrID = (EBGUAttrFloat)intEffectParam;
		bUS_GSEventCollection.Evt_IncreaseAttrFloat.Invoke(attrID, num);
	}
}
