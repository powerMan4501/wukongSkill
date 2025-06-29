using System.Collections.Generic;
using b1.Plugins.AsyncLoadingScreen;

namespace b1;

public class FDreamTeleportInfo
{
	public bool bTeleportToOtherLevel { get; set; }

	public int TargetLevelID { get; set; }

	public string BeforeTeleportMontagePath { get; set; }

	public string AfterTeleportMontagePath { get; set; }

	public string TeleportName { get; set; }

	public bool bDropTeleportPoint { get; set; }

	public string DroppedTeleportPointId { get; set; }

	public bool bSaveArchiveAfterTeleport { get; set; }

	public string ScheduleLabel { get; set; }

	public int TargetRebirthPointId { get; set; }

	public bool DontResetPlayerState { get; set; }

	public EGSLoadingScreenType LoadingScreenType { get; set; }

	public List<int> TeleportLoadingTips { get; set; }
}
