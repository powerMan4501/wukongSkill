using System.Collections.Generic;

namespace b1;

public class BUC_DashWallData
{
	public Dictionary<int, FDashHitWallInfo> CheckInfoMap { get; set; }

	public BUC_DashWallData()
	{
		CheckInfoMap = new Dictionary<int, FDashHitWallInfo>();
	}
}
