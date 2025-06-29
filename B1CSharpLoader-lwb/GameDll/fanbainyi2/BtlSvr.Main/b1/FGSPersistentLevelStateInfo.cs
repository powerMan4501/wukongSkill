using System.Collections.Generic;

namespace b1;

public class FGSPersistentLevelStateInfo
{
	public Dictionary<string, FGSLevelStateControlInfo> LevelStateControlInfo;

	public FGSPersistentLevelStateInfo()
	{
		LevelStateControlInfo = new Dictionary<string, FGSLevelStateControlInfo>();
	}

	public FGSPersistentLevelStateInfo(string RequesterID, FGSLevelStateControlInfo LevelManagedInfo)
	{
		LevelStateControlInfo = new Dictionary<string, FGSLevelStateControlInfo> { { RequesterID, LevelManagedInfo } };
	}

	public void UpdateLevelState(string RequesterID, FGSLevelStateControlInfo LevelManagedInfo)
	{
		if (LevelManagedInfo != null)
		{
			if (LevelStateControlInfo.ContainsKey(RequesterID))
			{
				LevelStateControlInfo[RequesterID] = LevelManagedInfo;
			}
			else
			{
				LevelStateControlInfo.Add(RequesterID, LevelManagedInfo);
			}
		}
		else
		{
			LevelStateControlInfo.Remove(RequesterID);
		}
	}

	public bool IsEmpty()
	{
		return LevelStateControlInfo.Count == 0;
	}
}
