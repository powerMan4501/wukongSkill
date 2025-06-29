using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/PCG.EPCGComponentGenerationTrigger", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGComponentGenerationTrigger : byte
{
	GenerateOnLoad,
	GenerateOnDemand
}
