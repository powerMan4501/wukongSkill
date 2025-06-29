using b1.ECS;

namespace b1;

public class BUS_RepStateInitHelper
{
	public static void InitNetRole(Entity Entity, int NetRole)
	{
		bool flag = (NetRole & 0x80) != 0;
		bool flag2 = (NetRole & 2) != 0;
		bool flag3 = (NetRole & 0x1000) != 0;
		bool flag4 = (NetRole & 0x800) != 0;
		bool isActive = (!flag3 && (flag || flag2)) || (flag3 && flag4);
		BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(Entity);
		bGW_ECSWorld.GetObject<BUC_ABPHelperData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BUC_AttrContainer>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BUC_BuffData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BUC_ChargeSkillData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BUC_FallDyingData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BUC_MontageSyncData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BUC_PredictionTestData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BUC_ReplicateTestData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BUC_SimpleStateData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BUC_TargetInfoData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BUC_UnitHatredData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BUC_UnitStateData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BUC_ObjActorMovementData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BUC_InteractData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BUC_ProjectileBasicData>(Entity)?._SetRepActive(isActive);
	}
}
