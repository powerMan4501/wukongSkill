using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/PCG.EPCGComponentInput", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGComponentInput : byte
{
	Actor,
	Landscape,
	Other
}
