using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class FGSPersistentLevelStateLayerInfo
{
	public Dictionary<EGSLevelStateInfoLayerType, FGSPersistentLevelStateInfo> PersistentLevelStateLayers;

	public FGSPersistentLevelStateLayerInfo()
	{
		PersistentLevelStateLayers = new Dictionary<EGSLevelStateInfoLayerType, FGSPersistentLevelStateInfo>();
	}

	public FGSSubLevelStates GetSubLevelStatesByOverlappingBoxGuids(UObject WorldContext, in List<string> OverlappingBoxGuidsQueue)
	{
		FGSSubLevelStates fGSSubLevelStates = new FGSSubLevelStates();
		for (int i = 0; i < 4; i++)
		{
			if (!PersistentLevelStateLayers.TryGetValue((EGSLevelStateInfoLayerType)i, out var value))
			{
				continue;
			}
			foreach (FGSLevelStateControlInfo ControlInfo in value.LevelStateControlInfo.Values)
			{
				string text = OverlappingBoxGuidsQueue?.Find((string r) => ControlInfo.TriggerLevelManageInfo.ContainsKey(r));
				FGSSubLevelStates fGSSubLevelStates2 = ((text != null) ? ControlInfo.TriggerLevelManageInfo[text] : ControlInfo.DefaultLevelManageInfo);
				fGSSubLevelStates.MergeInfo(fGSSubLevelStates2.MatchSubLevelManageInfos(WorldContext));
			}
		}
		return fGSSubLevelStates;
	}
}
