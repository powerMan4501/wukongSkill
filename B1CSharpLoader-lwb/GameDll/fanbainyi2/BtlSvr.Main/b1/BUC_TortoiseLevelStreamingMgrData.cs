using System.Collections.Generic;

namespace b1;

internal class BUC_TortoiseLevelStreamingMgrData : b1.IBUC_TortoiseLevelStreamingMgrData
{
	public Dictionary<FTortoiseLevelState, FGSLevelStateControlInfo> TortoiseLevelStreamingConfigs;

	public FTortoiseLevelState CurrentLevelState;

	public string RequestGUID;

	public BUC_TortoiseLevelStreamingMgrData()
	{
		TortoiseLevelStreamingConfigs = new Dictionary<FTortoiseLevelState, FGSLevelStateControlInfo>();
	}

	public void AddLevelStreamingConfig(FTortoiseLevelState State, FGSLevelStateControlInfo ControlInfo)
	{
		TortoiseLevelStreamingConfigs.Add(State, ControlInfo);
	}
}
