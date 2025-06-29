using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "关闭角色重力" })]
public class BUEffectDisableGravity : BUEffectTemplate
{
	public BUEffectDisableGravity()
	{
		EffectType = EBuffAndSkillEffectType.DisableGravity;
	}

	[TemplateFunNote("Buff期间关闭角色重力")]
	[AffectTarget]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (Target.IsNullOrDestroyed())
		{
			return;
		}
		IBUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(Target);
		if (readOnlyData != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null && !BuffInst.PropMgrHandleID.ContainsKey(EPropType.Movement_GravityScale))
			{
				bUS_GSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_GravityScale, 0f);
				BuffInst.AddPropMgrHandleID(EPropType.Movement_GravityScale, readOnlyData.GetLastHandleID());
			}
			if (Target is BGUCharacterCS bGUCharacterCS)
			{
				bGUCharacterCS.CharacterMovement.StopMovementImmediately();
			}
		}
	}

	[AffectTarget]
	[TemplateFunNote("Buff结束恢复角色重力")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null && BuffInst.PropMgrHandleID.TryGetValue(EPropType.Movement_GravityScale, out var OutValue))
			{
				bUS_GSEventCollection.Evt_ResetProperty.Invoke(OutValue);
				BuffInst.RemovePropMgrHandleID(EPropType.Movement_GravityScale);
			}
		}
	}
}
