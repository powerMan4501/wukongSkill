using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraph;

[UEnum]
[UMetaPath("/Script/AnimGraph.EBlueprintUsage", "AnimGraph", UnrealModuleType.Engine)]
public enum EBlueprintUsage
{
	NoProperties,
	DoesNotUseBlueprint,
	UsesBlueprint
}
