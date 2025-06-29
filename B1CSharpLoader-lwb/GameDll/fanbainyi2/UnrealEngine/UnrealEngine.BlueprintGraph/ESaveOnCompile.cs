using UnrealEngine.Runtime;

namespace UnrealEngine.BlueprintGraph;

[UEnum]
[UMetaPath("/Script/BlueprintGraph.ESaveOnCompile", "BlueprintGraph", UnrealModuleType.Engine)]
public enum ESaveOnCompile
{
	SoC_Never,
	SoC_SuccessOnly,
	SoC_Always
}
