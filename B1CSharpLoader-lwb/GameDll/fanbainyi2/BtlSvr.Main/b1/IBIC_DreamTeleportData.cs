using System.Collections.Generic;

namespace b1;

internal interface IBIC_DreamTeleportData
{
	bool TryGetTeleportTipsId(out List<int> TeleportLoadingTips);
}
