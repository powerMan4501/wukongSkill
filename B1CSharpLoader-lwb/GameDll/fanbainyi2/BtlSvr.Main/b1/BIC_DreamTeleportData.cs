using System.Collections.Generic;
using b1.Plugins.AsyncLoadingScreen;

namespace b1;

public class BIC_DreamTeleportData : b1.IBIC_DreamTeleportData
{
	public FDreamTeleportInfo DreamTeleportCache { get; set; }

	public bool bDreamTeleportWaitOpenLevelFinish { get; set; }

	public bool TryGetTeleportTipsId(out List<int> TeleportLoadingTips)
	{
		TeleportLoadingTips = null;
		if (DreamTeleportCache == null)
		{
			return false;
		}
		if (DreamTeleportCache.LoadingScreenType != EGSLoadingScreenType.Full)
		{
			return false;
		}
		if (DreamTeleportCache.TeleportLoadingTips == null || DreamTeleportCache.TeleportLoadingTips.Count == 0)
		{
			return false;
		}
		TeleportLoadingTips = DreamTeleportCache.TeleportLoadingTips;
		return true;
	}
}
