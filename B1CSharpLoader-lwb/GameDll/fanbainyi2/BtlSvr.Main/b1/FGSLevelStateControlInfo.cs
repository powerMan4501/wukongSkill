using System.Collections.Generic;

namespace b1;

public class FGSLevelStateControlInfo
{
	public FGSSubLevelStates DefaultLevelManageInfo;

	public Dictionary<string, FGSSubLevelStates> TriggerLevelManageInfo;

	public FGSLevelStateControlInfo()
	{
		DefaultLevelManageInfo = new FGSSubLevelStates();
		TriggerLevelManageInfo = new Dictionary<string, FGSSubLevelStates>();
	}
}
