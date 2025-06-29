using CommB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGW_GeoInfoFuncUtil
{
	public static bool IsHaveMap(UObject WorldContext)
	{
		foreach (ReadOnlyRoleItem item in (BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(UGameplayStatics.GetPlayerController(WorldContext, 0))?.RoleData).RoleCs.Bag.ItemList)
		{
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(item.ItemId);
			if (itemDesc != null && itemDesc.ItemType == ItemType.Map)
			{
				return true;
			}
		}
		return false;
	}
}
