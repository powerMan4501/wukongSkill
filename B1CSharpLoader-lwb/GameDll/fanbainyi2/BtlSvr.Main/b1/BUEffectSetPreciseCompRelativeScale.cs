using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "设置精准闪避Comp相对缩放" })]
public class BUEffectSetPreciseCompRelativeScale : BUEffectTemplate
{
	public BUEffectSetPreciseCompRelativeScale()
	{
		EffectType = EBuffAndSkillEffectType.SetPreciseCompRelativeScale;
	}

	[TemplateFunNote("设置精准闪避Comp相对缩放")]
	[ParamInfoF(1, "相对缩放Scale Y")]
	[ParamInfoF(2, "相对缩放Scale Z")]
	[ParamInfoF(0, "相对缩放Scale X")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!(Target == null))
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null && buffDescRuntime.GetFloatEffectParamCount(EffectIdx) >= 3)
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
				float floatEffectParam = buffDescRuntime.GetFloatEffectParam(EffectIdx, 0);
				float floatEffectParam2 = buffDescRuntime.GetFloatEffectParam(EffectIdx, 1);
				float floatEffectParam3 = buffDescRuntime.GetFloatEffectParam(EffectIdx, 2);
				bUS_GSEventCollection.Evt_SetPreciseCompRelativeScale.Invoke(new FVector(floatEffectParam, floatEffectParam2, floatEffectParam3));
			}
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!(Target == null))
		{
			BUS_EventCollectionCS.Get(Target).Evt_ResetPreciseCompRelativeScale.Invoke();
		}
	}
}
