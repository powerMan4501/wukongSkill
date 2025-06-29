using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class FGSSubLevelStates
{
	public Dictionary<string, FGSLevelStateInfo> ManagedLevels;

	public FGSSubLevelStates()
	{
		ManagedLevels = new Dictionary<string, FGSLevelStateInfo>();
	}

	public FGSSubLevelStates(FGSSubLevelStates Other)
	{
		ManagedLevels = new Dictionary<string, FGSLevelStateInfo>();
		MergeInfo(Other);
	}

	public bool MergeLevelStateInfo(string LevelName, FGSLevelStateInfo StateInfo)
	{
		bool result = true;
		if (ManagedLevels.ContainsKey(LevelName))
		{
			result = ManagedLevels[LevelName].MergeInfo(StateInfo);
		}
		else
		{
			ManagedLevels.Add(LevelName, new FGSLevelStateInfo(StateInfo));
		}
		return result;
	}

	public bool MergeInfo(FGSSubLevelStates OtherInfo)
	{
		bool flag = true;
		foreach (KeyValuePair<string, FGSLevelStateInfo> managedLevel in OtherInfo.ManagedLevels)
		{
			flag &= MergeLevelStateInfo(managedLevel.Key, managedLevel.Value);
		}
		return flag;
	}

	public Dictionary<string, FGSLevelStateInfo> GetAbsenceLevels(FGSSubLevelStates CompareLevelStates)
	{
		Dictionary<string, FGSLevelStateInfo> dictionary = new Dictionary<string, FGSLevelStateInfo>();
		foreach (string key in CompareLevelStates.ManagedLevels.Keys)
		{
			if (!ManagedLevels.ContainsKey(key))
			{
				dictionary[key] = CompareLevelStates.ManagedLevels[key];
			}
		}
		return dictionary;
	}

	public FGSSubLevelStates MatchSubLevelManageInfos(UObject WorldContext)
	{
		FGSSubLevelStates fGSSubLevelStates = new FGSSubLevelStates();
		foreach (KeyValuePair<string, FGSLevelStateInfo> managedLevel in ManagedLevels)
		{
			List<string> list = new List<string>();
			List<string> levelNamesByKeyword = UBGUWCStreamingFuncLib.GetLevelNamesByKeyword(WorldContext, managedLevel.Key);
			if (!managedLevel.Value.DisableKeyword)
			{
				list.AddRange(levelNamesByKeyword);
			}
			else if (levelNamesByKeyword.Contains(managedLevel.Key))
			{
				list.Add(managedLevel.Key);
			}
			foreach (string item in list)
			{
				if (fGSSubLevelStates.ManagedLevels.ContainsKey(item))
				{
					fGSSubLevelStates.ManagedLevels[item].MergeInfo(managedLevel.Value);
				}
				else
				{
					fGSSubLevelStates.ManagedLevels[item] = new FGSLevelStateInfo(managedLevel.Value);
				}
			}
		}
		return fGSSubLevelStates;
	}
}
