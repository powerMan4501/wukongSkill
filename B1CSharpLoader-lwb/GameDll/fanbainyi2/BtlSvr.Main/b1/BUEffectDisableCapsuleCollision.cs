using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "关闭胶囊体碰撞" })]
public class BUEffectDisableCapsuleCollision : BUEffectTemplate
{
	public BUEffectDisableCapsuleCollision()
	{
		EffectType = EBuffAndSkillEffectType.DisableCapsuleCollision;
	}

	[TemplateFunNote("Buff期间关闭胶囊体碰撞")]
	[ParamInfoS(0, "关闭碰撞用的Preset")]
	[AffectTarget]
	[TemplateFuncTips("Buff期间会将胶囊体碰撞改为参数指定的Preset；HitMove也会被一并关闭。")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (Target.IsNullOrDestroyed())
		{
			return;
		}
		string value = "NoCollision";
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null && buffDescRuntime.GetStringEffectParamCount(EffectIdx) > 0)
		{
			value = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
		}
		IBUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(Target);
		if (readOnlyData == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			if (!BuffInst.PropMgrHandleID.ContainsKey(EPropType.Capsule_CollisionProfileName))
			{
				bUS_GSEventCollection.Evt_SetStringProperty.Invoke(EPropType.Capsule_CollisionProfileName, value);
				BuffInst.AddPropMgrHandleID(EPropType.Capsule_CollisionProfileName, readOnlyData.GetLastHandleID());
			}
			bUS_GSEventCollection.Evt_SetIsEnableCollisionHitMove.Invoke(IsEnableCollisionHitMove: false, ECollisionHitMoveEnableReqType.Buff, BuffInst.BuffID);
		}
	}

	[TemplateFunNote("Buff结束恢复胶囊体碰撞")]
	[AffectTarget]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (Target.IsNullOrDestroyed())
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			if (BuffInst.PropMgrHandleID.TryGetValue(EPropType.Capsule_CollisionProfileName, out var OutValue))
			{
				bUS_GSEventCollection.Evt_ResetProperty.Invoke(OutValue);
				BuffInst.RemovePropMgrHandleID(EPropType.Capsule_CollisionProfileName);
			}
			bUS_GSEventCollection.Evt_ResetIsEnableCollisionHitMove.Invoke(ECollisionHitMoveEnableReqType.Buff, BuffInst.BuffID);
		}
	}
}
