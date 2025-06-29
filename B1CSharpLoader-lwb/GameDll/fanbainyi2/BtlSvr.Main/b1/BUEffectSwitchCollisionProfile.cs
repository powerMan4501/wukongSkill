using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "可以切换Capsule或Mesh的碰撞预设", "int参数是碰撞类型数组，string参数是碰撞预设数组，两者index是一一对应的" })]
public class BUEffectSwitchCollisionProfile : BUEffectTemplate
{
	public BUEffectSwitchCollisionProfile()
	{
		EffectType = EBuffAndSkillEffectType.SwitchCollisionProfile;
	}

	[AffectTarget]
	[ParamInfoS(2, "同上，所有string参数都是碰撞预设")]
	[ParamInfoS(1, "CollisionProfile(碰撞预设)")]
	[ParamInfoI(1, "碰撞类型（1Capsule，2Mesh）")]
	[ParamInfoI(2, "同上，所有int参数都是碰撞类型数组")]
	[ParamInfoI(0, "碰撞类型（1Capsule，2Mesh）")]
	[ParamInfoS(0, "CollisionProfile(碰撞预设)")]
	[TemplateFunNote("通过Buff切换Capule或者Mesh的碰撞预设")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		IBUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(Target);
		if (readOnlyData == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		for (int i = 0; i < intEffectParamCount; i++)
		{
			int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, i);
			if (buffDescRuntime.GetStringEffectParamCount(EffectIdx) > i)
			{
				string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, i);
				if (intEffectParam == 1 && !BuffInst.PropMgrHandleID.ContainsKey(EPropType.Capsule_CollisionProfileName))
				{
					bUS_GSEventCollection.Evt_SetStringProperty.Invoke(EPropType.Capsule_CollisionProfileName, stringEffectParam);
					BuffInst.AddPropMgrHandleID(EPropType.Capsule_CollisionProfileName, readOnlyData.GetLastHandleID());
				}
				if (intEffectParam == 2 && !BuffInst.PropMgrHandleID.ContainsKey(EPropType.Mesh_CollisionProfileName))
				{
					bUS_GSEventCollection.Evt_SetStringProperty.Invoke(EPropType.Mesh_CollisionProfileName, stringEffectParam);
					BuffInst.AddPropMgrHandleID(EPropType.Mesh_CollisionProfileName, readOnlyData.GetLastHandleID());
				}
				continue;
			}
			break;
		}
	}

	[TemplateFunNote("Buff结束是还原Capsule或Mesh的碰撞预设")]
	[AffectTarget]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			if (BuffInst.PropMgrHandleID.TryGetValue(EPropType.Capsule_CollisionProfileName, out var OutValue))
			{
				bUS_GSEventCollection.Evt_ResetProperty.Invoke(OutValue);
				BuffInst.RemovePropMgrHandleID(EPropType.Capsule_CollisionProfileName);
			}
			if (BuffInst.PropMgrHandleID.TryGetValue(EPropType.Mesh_CollisionProfileName, out OutValue))
			{
				bUS_GSEventCollection.Evt_ResetProperty.Invoke(OutValue);
				BuffInst.RemovePropMgrHandleID(EPropType.Mesh_CollisionProfileName);
			}
		}
	}
}
