using UnrealEngine.Runtime;

namespace UnrealEngine.BlueprintGraph;

[UEnum]
[UMetaPath("/Script/BlueprintGraph.ETunnelBoundaryType", "BlueprintGraph", UnrealModuleType.Engine)]
public enum ETunnelBoundaryType
{
	Unknown,
	EntrySite,
	InputSite,
	OutputSite
}
