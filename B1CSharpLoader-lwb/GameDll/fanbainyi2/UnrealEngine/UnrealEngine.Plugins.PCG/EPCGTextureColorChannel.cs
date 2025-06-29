using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/PCG.EPCGTextureColorChannel", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGTextureColorChannel : byte
{
	Red,
	Green,
	Blue,
	Alpha
}
