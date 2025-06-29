using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BUC_PlayerItemData : IBUC_PlayerItemData, IPersistentECSData
{
	public float CheckTime;

	public int CurUseItemId { get; set; }

	public int CurQuickItemId { get; set; }

	public Dictionary<int, bool> AllowUseSpecialItemMap { get; set; } = new Dictionary<int, bool>();

	public Dictionary<int, int> ShortCutItemList { get; set; }

	public bool IsSpecialItemAllowUse(int itemId)
	{
		if (AllowUseSpecialItemMap.TryGetValue(itemId, out var value))
		{
			return value;
		}
		return false;
	}
}
