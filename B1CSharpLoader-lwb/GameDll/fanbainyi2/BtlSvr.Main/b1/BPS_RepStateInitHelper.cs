using b1.ECS;

namespace b1;

public class BPS_RepStateInitHelper
{
	public static void InitNetRole(Entity Entity, int NetRole)
	{
		bool flag = (NetRole & 0x80) != 0;
		bool flag2 = (NetRole & 2) != 0;
		bool flag3 = (NetRole & 0x1000) != 0;
		bool flag4 = (NetRole & 0x800) != 0;
		bool isActive = (!flag3 && (flag || flag2)) || (flag3 && flag4);
		BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(Entity);
		bGW_ECSWorld.GetObject<BPC_PlayerStateTestData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BPC_RoleBaseData>(Entity)?._SetRepActive(isActive);
		bGW_ECSWorld.GetObject<BPC_TransactionData>(Entity)?._SetRepActive(isActive);
	}
}
