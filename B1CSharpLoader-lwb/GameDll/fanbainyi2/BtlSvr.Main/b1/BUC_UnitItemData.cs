using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BUC_UnitItemData : IBUC_UnitItemData, IPersistentECSData
{
	public int HuluId { get; set; }

	public int WineItemId { get; set; }

	public List<int> WinePartList { get; set; }

	public BUC_UnitItemData()
	{
		HuluId = 0;
		WineItemId = 0;
		WinePartList = new List<int>();
	}
}
