using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Foliage.ESimulationQuery", "Foliage", UnrealModuleType.Engine)]
public enum ESimulationQuery : byte
{
	None,
	CollisionOverlap,
	ShadeOverlap,
	AnyOverlap
}
