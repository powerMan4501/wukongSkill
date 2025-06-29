using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[CantUseInMultiEffect]
[EffectTemplateTips(new string[] { "免疫艰难行走,艰难行走分多种" })]
public class BUEffectImmuneHardMove : BUEffectTemplate
{
	public BUEffectImmuneHardMove()
	{
		EffectType = EBuffAndSkillEffectType.ImmuneHardMove;
	}

	[TemplateFunNote("艰难行走有多个类型，根据参数确定免疫哪一种艰难行走")]
	[ParamInfoI(0, "免疫所有")]
	[ParamInfoI(1, "免疫冰冻艰难行走")]
	[ParamInfoI(2, "免疫泥浆艰难行走")]
	[ParamInfoI(3, "免疫飓风艰难行走")]
	[ParamInfoI(4, "免疫蛛网艰难行走")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		for (int i = 0; i < intEffectParamCount; i++)
		{
			switch (buffDescRuntime.GetIntEffectParam(EffectIdx, i))
			{
			case 0:
				bUS_GSEventCollection.Evt_SetImmuneHardMoveAll.Invoke(IsSelfRescue: true);
				break;
			case 1:
				bUS_GSEventCollection.Evt_SetImmuneHardMoveFrozen.Invoke(IsSelfRescue: true);
				break;
			case 2:
				bUS_GSEventCollection.Evt_SetImmuneHardMoveMuddy.Invoke(IsSelfRescue: true);
				break;
			case 3:
				bUS_GSEventCollection.Evt_SetImmuneHardMoveWindy.Invoke(IsSelfRescue: true);
				break;
			case 4:
				bUS_GSEventCollection.Evt_SetImmuneHardMoveSpiderSilk.Invoke(IsSelfRescue: true);
				break;
			}
		}
	}

	[TemplateFunNote("Buff移除时同时移除免疫效果")]
	[ParamInfoI(0, "免疫所有")]
	[ParamInfoI(2, "免疫泥浆艰难行走")]
	[ParamInfoI(3, "免疫飓风艰难行走")]
	[ParamInfoI(4, "免疫蛛网艰难行走")]
	[ParamInfoI(1, "免疫冰冻艰难行走")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		for (int i = 0; i < intEffectParamCount; i++)
		{
			switch (buffDescRuntime.GetIntEffectParam(EffectIdx, i))
			{
			case 0:
				bUS_GSEventCollection.Evt_SetImmuneHardMoveAll.Invoke(IsSelfRescue: false);
				break;
			case 1:
				bUS_GSEventCollection.Evt_SetImmuneHardMoveFrozen.Invoke(IsSelfRescue: false);
				break;
			case 2:
				bUS_GSEventCollection.Evt_SetImmuneHardMoveMuddy.Invoke(IsSelfRescue: false);
				break;
			case 3:
				bUS_GSEventCollection.Evt_SetImmuneHardMoveWindy.Invoke(IsSelfRescue: false);
				break;
			case 4:
				bUS_GSEventCollection.Evt_SetImmuneHardMoveSpiderSilk.Invoke(IsSelfRescue: false);
				break;
			}
		}
	}
}
