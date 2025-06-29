using System.Collections.Generic;

namespace b1;

public interface IBUC_UnitItemData
{
	int HuluId { get; }

	int WineItemId { get; }

	List<int> WinePartList { get; }
}
