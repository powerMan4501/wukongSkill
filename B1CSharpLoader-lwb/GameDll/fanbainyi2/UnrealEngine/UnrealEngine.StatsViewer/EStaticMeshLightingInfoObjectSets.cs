using UnrealEngine.Runtime;

namespace UnrealEngine.StatsViewer;

[UEnum]
[UMetaPath("/Script/StatsViewer.EStaticMeshLightingInfoObjectSets", "StatsViewer", UnrealModuleType.Engine)]
public enum EStaticMeshLightingInfoObjectSets
{
	StaticMeshLightingInfoObjectSets_CurrentLevel,
	StaticMeshLightingInfoObjectSets_SelectedLevels,
	StaticMeshLightingInfoObjectSets_AllLevels
}
