using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Foliage.ESimulationOverlap", "Foliage", UnrealModuleType.Engine)]
public enum ESimulationOverlap : byte
{
	CollisionOverlap,
	ShadeOverlap,
	None
}
