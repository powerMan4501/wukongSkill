using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "根据SocketName禁用手动锁定点" })]
[CantUseInMultiEffect]
public class BUEffectDisableCameraLockPoint : BUEffectTemplate
{
	public BUEffectDisableCameraLockPoint()
	{
		EffectType = EBuffAndSkillEffectType.DisableCameraLockPoint;
	}

	[TemplateFunNote("Buff触发时禁用手动锁定点")]
	[ParamInfoS(0, "第一个要被禁用的SocketName1")]
	[ParamInfoS(1, "第二个要被禁用的SocketName2")]
	[ParamInfoS(2, "第三个要被禁用的SocketName3")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime.GetEffectsCount() > EffectIdx)
		{
			int stringEffectParamCount = buffDescRuntime.GetStringEffectParamCount(EffectIdx);
			if (stringEffectParamCount > 0)
			{
				BUS_EventCollectionCS.Get(Target).Evt_SetCameraLockPointEnabled.Invoke(buffDescRuntime.GetStringEffectParam(EffectIdx, 0), P2: false);
			}
			if (stringEffectParamCount > 1)
			{
				BUS_EventCollectionCS.Get(Target).Evt_SetCameraLockPointEnabled.Invoke(buffDescRuntime.GetStringEffectParam(EffectIdx, 1), P2: false);
			}
			if (stringEffectParamCount > 2)
			{
				BUS_EventCollectionCS.Get(Target).Evt_SetCameraLockPointEnabled.Invoke(buffDescRuntime.GetStringEffectParam(EffectIdx, 2), P2: false);
			}
		}
	}

	[ParamInfoS(1, "第二个要被禁用的SocketName2")]
	[ParamInfoS(0, "第一个要被禁用的SocketName1")]
	[ParamInfoS(2, "第三个要被禁用的SocketName3")]
	[TemplateFunNote("Buff移除时恢复手动锁定点")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime.GetEffectsCount() > EffectIdx)
		{
			int stringEffectParamCount = buffDescRuntime.GetStringEffectParamCount(EffectIdx);
			if (stringEffectParamCount > 0)
			{
				BUS_EventCollectionCS.Get(Target).Evt_SetCameraLockPointEnabled.Invoke(buffDescRuntime.GetStringEffectParam(EffectIdx, 0), P2: true);
			}
			if (stringEffectParamCount > 1)
			{
				BUS_EventCollectionCS.Get(Target).Evt_SetCameraLockPointEnabled.Invoke(buffDescRuntime.GetStringEffectParam(EffectIdx, 1), P2: true);
			}
			if (stringEffectParamCount > 2)
			{
				BUS_EventCollectionCS.Get(Target).Evt_SetCameraLockPointEnabled.Invoke(buffDescRuntime.GetStringEffectParam(EffectIdx, 2), P2: true);
			}
		}
	}
}
