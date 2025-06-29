using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[CantUseInMultiEffect]
[EffectTemplateTips(new string[] { "通过曲线设置MPC值" })]
public class BUEffectSetMPCParamByFloatCurve : BUEffectTemplate
{
	public BUEffectSetMPCParamByFloatCurve()
	{
		EffectType = EBuffAndSkillEffectType.SetMpcParamByFloatCurve;
	}

	[TemplateFunNote("通过设置曲线在Tick中设置MPC的某个参数值")]
	[ParamInfoF(0, "用到的曲线 TotalTime")]
	[ParamInfoF(1, "当曲线tick超过TotalTime后，直接对参数设置的 FinalValue")]
	[ParamInfoS(0, "MPC Path")]
	[ParamInfoS(1, "曲线 Path")]
	[ParamInfoS(2, "参数名字 ParamName")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime.GetEffectsCount() > EffectIdx && buffDescRuntime.GetFloatEffectParamCount(EffectIdx) >= 2 && buffDescRuntime.GetStringEffectParamCount(EffectIdx) >= 3)
		{
			float floatEffectParam = buffDescRuntime.GetFloatEffectParam(EffectIdx, 0);
			float floatEffectParam2 = buffDescRuntime.GetFloatEffectParam(EffectIdx, 1);
			string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
			string stringEffectParam2 = buffDescRuntime.GetStringEffectParam(EffectIdx, 1);
			string stringEffectParam3 = buffDescRuntime.GetStringEffectParam(EffectIdx, 2);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_TriggerMPCScalarParamTick.Invoke(stringEffectParam, stringEffectParam3, stringEffectParam2, floatEffectParam, floatEffectParam2);
			}
		}
	}
}
