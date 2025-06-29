using System.Collections.Generic;

namespace b1;

public class FGSLevelStateInfoLayer
{
	public Dictionary<int, FGSPersistentLevelStateInfo> LevelControlInfo;

	public FGSLevelStateInfoLayer()
	{
		LevelControlInfo = new Dictionary<int, FGSPersistentLevelStateInfo>();
	}

	public void UpdateLevelState(string RequesterID, int LevelID, FGSLevelStateControlInfo LevelManagedInfo)
	{
		EnsurePersistentLevelStateInfoValid(LevelID);
		LevelControlInfo[LevelID].UpdateLevelState(RequesterID, LevelManagedInfo);
		if (LevelControlInfo[LevelID].IsEmpty())
		{
			LevelControlInfo.Remove(LevelID);
		}
	}

	public bool HasPersistentLevelStateInfo(int LevelID)
	{
		return LevelControlInfo.ContainsKey(LevelID);
	}

	public FGSPersistentLevelStateInfo GetCurrentLevelStateInfo(int LevelID)
	{
		EnsurePersistentLevelStateInfoValid(LevelID);
		return LevelControlInfo[LevelID];
	}

	private void EnsurePersistentLevelStateInfoValid(int LevelID)
	{
		if (!LevelControlInfo.ContainsKey(LevelID))
		{
			LevelControlInfo.Add(LevelID, new FGSPersistentLevelStateInfo());
		}
	}

	public bool IsEmpty()
	{
		return LevelControlInfo.Count == 0;
	}
}
