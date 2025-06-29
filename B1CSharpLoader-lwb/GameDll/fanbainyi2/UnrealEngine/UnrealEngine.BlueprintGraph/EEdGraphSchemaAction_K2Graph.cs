using UnrealEngine.Runtime;

namespace UnrealEngine.BlueprintGraph;

[UEnum]
[UMetaPath("/Script/BlueprintGraph.EEdGraphSchemaAction_K2Graph", "BlueprintGraph", UnrealModuleType.Engine)]
public enum EEdGraphSchemaAction_K2Graph
{
	Graph,
	Subgraph,
	Function,
	Interface,
	Macro
}
