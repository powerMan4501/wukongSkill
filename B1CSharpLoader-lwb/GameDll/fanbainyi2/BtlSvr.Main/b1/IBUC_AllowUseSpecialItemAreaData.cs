using System.Collections.Generic;

namespace b1;

internal interface IBUC_AllowUseSpecialItemAreaData
{
	Dictionary<int, bool> AllowUseSpecialItemMap { get; }

	Dictionary<int, bool> AllowUseSpecialItemRemoveMap { get; }
}
