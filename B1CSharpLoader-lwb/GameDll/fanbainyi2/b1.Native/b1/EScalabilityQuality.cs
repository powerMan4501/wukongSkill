using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EScalabilityQuality", "UnrealExtent", UnrealModuleType.Game)]
public enum EScalabilityQuality : byte
{
	INVALID,
	LOW,
	MEDIUM,
	HIGH,
	EPIC,
	CINE
}
