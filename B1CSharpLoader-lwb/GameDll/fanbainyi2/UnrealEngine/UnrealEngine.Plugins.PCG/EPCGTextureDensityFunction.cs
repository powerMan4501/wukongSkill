using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/PCG.EPCGTextureDensityFunction", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGTextureDensityFunction : byte
{
	Ignore,
	Multiply
}
