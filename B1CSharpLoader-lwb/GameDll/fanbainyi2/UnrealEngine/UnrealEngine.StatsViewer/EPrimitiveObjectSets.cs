using UnrealEngine.Runtime;

namespace UnrealEngine.StatsViewer;

[UEnum]
[UMetaPath("/Script/StatsViewer.EPrimitiveObjectSets", "StatsViewer", UnrealModuleType.Engine)]
public enum EPrimitiveObjectSets
{
	PrimitiveObjectSets_AllObjects,
	PrimitiveObjectSets_CurrentLevel,
	PrimitiveObjectSets_SelectedObjects
}
