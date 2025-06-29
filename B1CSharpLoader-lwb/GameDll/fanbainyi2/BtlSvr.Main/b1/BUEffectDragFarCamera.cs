using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectDragFarCamera : BUEffectTemplate
{
	public BUEffectDragFarCamera()
	{
		EffectType = EBuffAndSkillEffectType.DragFarCamera;
	}

	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			float newMinArmLength = -1f;
			float newMaxArmLength = -1f;
			float newMinSocketZ = -1f;
			float newMaxSocketZ = -1f;
			if (buffDescRuntime.GetIntEffectParamCount(EffectIdx) == 4)
			{
				newMinArmLength = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				newMaxArmLength = buffDescRuntime.GetIntEffectParam(EffectIdx, 1);
				newMinSocketZ = buffDescRuntime.GetIntEffectParam(EffectIdx, 2);
				newMaxSocketZ = buffDescRuntime.GetIntEffectParam(EffectIdx, 3);
			}
			BUS_EventCollectionCS.Get(Target).Evt_DragFarCamera.Invoke(IsDragFarest: true, newMinArmLength, newMaxArmLength, newMinSocketZ, newMaxSocketZ);
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target) && b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst) != null)
		{
			BUS_EventCollectionCS.Get(Target).Evt_DragFarCamera.Invoke(IsDragFarest: false, -1f, -1f, -1f, -1f);
		}
	}
}
