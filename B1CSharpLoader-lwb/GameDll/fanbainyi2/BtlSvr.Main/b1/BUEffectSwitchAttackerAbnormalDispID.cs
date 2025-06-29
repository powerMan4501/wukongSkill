using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "切换攻击者异常表现ID" })]
public class BUEffectSwitchAttackerAbnormalDispID : BUEffectTemplate
{
	public BUEffectSwitchAttackerAbnormalDispID()
	{
		EffectType = EBuffAndSkillEffectType.SwitchAttackerAbnormalDispId;
	}

	[TemplateFunNote("Buff开始切换攻击者异常表现ID")]
	[AffectTarget]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (Target.IsNullOrDestroyed())
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null || buffDescRuntime.GetIntEffectParamCount(EffectIdx) < 1)
		{
			return;
		}
		int value = buffDescRuntime.GetIntEffectParamList(EffectIdx)[0];
		IBUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(Target);
		if (readOnlyData != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null && !BuffInst.PropMgrHandleID.ContainsKey(EPropType.Actor_AttackerAbnormalDispID_Override))
			{
				bUS_GSEventCollection.Evt_SetIntProperty.Invoke(EPropType.Actor_AttackerAbnormalDispID_Override, value);
				BuffInst.AddPropMgrHandleID(EPropType.Actor_AttackerAbnormalDispID_Override, readOnlyData.GetLastHandleID());
			}
		}
	}

	[TemplateFunNote("Buff结束恢复攻击者异常表现ID。")]
	[AffectTarget]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null && BuffInst.PropMgrHandleID.TryGetValue(EPropType.Actor_AttackerAbnormalDispID_Override, out var OutValue))
			{
				bUS_GSEventCollection.Evt_ResetProperty.Invoke(OutValue);
				BuffInst.RemovePropMgrHandleID(EPropType.Actor_AttackerAbnormalDispID_Override);
			}
		}
	}
}
