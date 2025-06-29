using System.Collections.Generic;

namespace b1;

internal class BUC_AllowUseSpecialItemAreaData : b1.IBUC_AllowUseSpecialItemAreaData
{
	public Dictionary<int, bool> AllowUseSpecialItemMap { get; set; } = new Dictionary<int, bool>();

	public Dictionary<int, bool> AllowUseSpecialItemRemoveMap { get; set; } = new Dictionary<int, bool>();
}
