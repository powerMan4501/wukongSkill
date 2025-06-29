using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "关闭网格体碰撞" })]
public class BUEffectDisableMeshCollision : BUEffectTemplate
{
	public BUEffectDisableMeshCollision()
	{
		EffectType = EBuffAndSkillEffectType.DisableMeshCollision;
	}

	[AffectTarget]
	[ParamInfoS(0, "关闭碰撞用的Preset")]
	[TemplateFuncTips("Buff期间会将Mesh碰撞改为参数指定的Preset。")]
	[TemplateFunNote("Buff期间关闭网格体碰撞")]
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
		if (readOnlyData != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null && !BuffInst.PropMgrHandleID.ContainsKey(EPropType.Mesh_CollisionProfileName))
			{
				bUS_GSEventCollection.Evt_SetStringProperty.Invoke(EPropType.Mesh_CollisionProfileName, value);
				BuffInst.AddPropMgrHandleID(EPropType.Mesh_CollisionProfileName, readOnlyData.GetLastHandleID());
			}
		}
	}

	[TemplateFunNote("Buff结束恢复网格体碰撞")]
	[AffectTarget]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null && BuffInst.PropMgrHandleID.TryGetValue(EPropType.Mesh_CollisionProfileName, out var OutValue))
			{
				bUS_GSEventCollection.Evt_ResetProperty.Invoke(OutValue);
				BuffInst.RemovePropMgrHandleID(EPropType.Mesh_CollisionProfileName);
			}
		}
	}
}
