using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "修改移动速度" })]
[AffectTarget]
public class BUEffectChangeMoveSpd : BUEffectTemplate
{
	public BUEffectChangeMoveSpd()
	{
		EffectType = EBuffAndSkillEffectType.ChangeMoveSpeed;
	}

	[ParamInfoF(2, "疾跑速度")]
	[TemplateFunNote("添加Buff时修改移动速度")]
	[ParamInfoF(0, "慢跑速度")]
	[ParamInfoF(1, "跑步速度")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		IBUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(Target);
		if (readOnlyData == null)
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			float floatEffectParam = buffDescRuntime.GetFloatEffectParam(EffectIdx, 0);
			float floatEffectParam2 = buffDescRuntime.GetFloatEffectParam(EffectIdx, 1);
			float floatEffectParam3 = buffDescRuntime.GetFloatEffectParam(EffectIdx, 2);
			if (!BuffInst.PropMgrHandleID.ContainsKey(EPropType.Movement_SpeedCtrlInfo))
			{
				BUS_EventCollectionCS.Get(Target).Evt_SetVectorProperty.Invoke(EPropType.Movement_SpeedCtrlInfo, new FVector(floatEffectParam3, floatEffectParam2, floatEffectParam));
				BuffInst.AddPropMgrHandleID(EPropType.Movement_SpeedCtrlInfo, readOnlyData.GetLastHandleID());
			}
		}
	}

	[TemplateFunNote("移除Buff时重置移动速度")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target) && BuffInst.PropMgrHandleID.TryGetValue(EPropType.Movement_SpeedCtrlInfo, out var OutValue))
		{
			BUS_EventCollectionCS.Get(Target).Evt_ResetProperty.Invoke(OutValue);
			BuffInst.RemovePropMgrHandleID(EPropType.Movement_SpeedCtrlInfo);
		}
	}
}
